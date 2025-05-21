Imports System.IO      ' Puede ser necesario para manejo de imágenes si se extiende
Imports System.Net.Security
Imports System.Text     ' Para SecurityElement.Escape
Imports MailKit              ' Imports básicos
Imports MailKit.Net.Smtp    ' Para el cliente SMTP (SmtpClient)
Imports MailKit.Security    ' Para opciones de seguridad (SecureSocketOptions)
Imports MimeKit             ' Para crear mensajes (MimeMessage, MailboxAddress, BodyBuilder)

Module mSendEmail

    ' --- Envía un correo básico (Texto Plano) SIN adjuntos ---
    ' Uso: Cuando tienes todos los datos directamente.
    Public Function SendBasicEmail(ByVal pFrom As String, ByVal pFromPassword As String, ByVal pTo As String,
                                   ByVal pSubject As String, ByVal pBody As String) As Boolean
        Try
            Dim message As New MimeMessage()
            message.From.Add(New MailboxAddress(pFrom, pFrom))

            ' Procesar Destinatarios (permite ; o , como separador)
            Dim recipients As String() = pTo.Split(New Char() {";"c, ","c}, StringSplitOptions.RemoveEmptyEntries)
            Dim addedRecipients As Integer = 0
            For Each addr In recipients
                Dim trimmedAddr = addr.Trim()
                If Not String.IsNullOrWhiteSpace(trimmedAddr) Then
                    Try
                        message.To.Add(MailboxAddress.Parse(trimmedAddr))
                        addedRecipients += 1
                    Catch exFormat As FormatException
                        System.Diagnostics.Trace.WriteLine($"Formato de correo inválido en SendBasicEmail: {trimmedAddr} - {exFormat.Message}")
                    End Try
                End If
            Next
            If addedRecipients = 0 Then Throw New ArgumentException("No se proporcionaron destinatarios válidos.")

            message.Subject = pSubject

            ' Cuerpo del mensaje (Texto Plano)
            Dim bodyBuilder As New BodyBuilder() With {.TextBody = pBody}
            message.Body = bodyBuilder.ToMessageBody()

            ' Enviar usando MailKit
            Using client As New SmtpClient()
                client.Connect("smtp.migadu.com", 465, SecureSocketOptions.SslOnConnect)
                client.Authenticate(pFrom, pFromPassword) ' Contraseña del BUZÓN de Migadu
                client.Send(message)
                client.Disconnect(True)
            End Using

            Return True

        Catch authEx As AuthenticationException
            LogAndShowError($"Error de Autenticación en SendBasicEmail ({pFrom})", authEx)
            Return False
        Catch argEx As ArgumentException ' Error en destinatarios
            LogAndShowError($"Error en Parámetros de SendBasicEmail", argEx)
            Return False
        Catch serviceEx As ServiceNotConnectedException
            LogAndShowError($"Error de Conexión en SendBasicEmail", serviceEx)
            Return False
        Catch smtpEx As SmtpCommandException
            LogAndShowError($"Error SMTP en SendBasicEmail", smtpEx)
            Return False
        Catch ioEx As IOException
            LogAndShowError($"Error de Red/IO en SendBasicEmail", ioEx)
            Return False
        Catch ex As Exception ' Captura general para otros errores (conexión, SMTP, etc.)
            LogAndShowError($"Error General en SendBasicEmail", ex)
            Return False
        End Try
    End Function

    ' --- Envía un correo básico (Texto Plano) CON adjunto ---
    ' Uso: Cuando tienes todos los datos directamente.
    Public Function SendBasicEmailWithAttachment(ByVal pFrom As String, ByVal pFromPassword As String, ByVal pTo As String,
                                                 ByVal pSubject As String, ByVal pBody As String, ByVal pAttachmentPath As String) As Boolean
        Try
            Dim message As New MimeMessage()
            message.From.Add(New MailboxAddress(pFrom, pFrom))

            ' Procesar Destinatarios
            Dim recipients As String() = pTo.Split(New Char() {";"c, ","c}, StringSplitOptions.RemoveEmptyEntries)
            Dim addedRecipients As Integer = 0
            For Each addr In recipients
                Dim trimmedAddr = addr.Trim()
                If Not String.IsNullOrWhiteSpace(trimmedAddr) Then
                    Try
                        message.To.Add(MailboxAddress.Parse(trimmedAddr))
                        addedRecipients += 1
                    Catch exFormat As FormatException
                        System.Diagnostics.Trace.WriteLine($"Formato de correo inválido en SendBasicEmailWithAttachment: {trimmedAddr} - {exFormat.Message}")
                    End Try
                End If
            Next
            If addedRecipients = 0 Then Throw New ArgumentException("No se proporcionaron destinatarios válidos.")

            message.Subject = pSubject

            ' Cuerpo y Adjunto
            Dim bodyBuilder As New BodyBuilder() With {.TextBody = pBody}
            If Not String.IsNullOrEmpty(pAttachmentPath) AndAlso File.Exists(pAttachmentPath) Then
                bodyBuilder.Attachments.Add(pAttachmentPath)
            ElseIf Not String.IsNullOrEmpty(pAttachmentPath) Then
                System.Diagnostics.Trace.WriteLine($"Advertencia SendBasicEmailWithAttachment: Archivo adjunto no encontrado: {pAttachmentPath}")
                ' Decide si fallar o enviar sin adjunto. Aquí enviamos sin él.
            End If
            message.Body = bodyBuilder.ToMessageBody()

            ' Enviar usando MailKit
            Using client As New SmtpClient()
                client.Connect("smtp.migadu.com", 465, SecureSocketOptions.SslOnConnect)
                client.Authenticate(pFrom, pFromPassword) ' Contraseña del BUZÓN Migadu
                client.Send(message)
                client.Disconnect(True)
            End Using

            Return True

        Catch authEx As AuthenticationException
            LogAndShowError($"Error de Autenticación en SendBasicEmailWithAttachment ({pFrom})", authEx)
            Return False
        Catch argEx As ArgumentException
            LogAndShowError($"Error en Parámetros de SendBasicEmailWithAttachment", argEx)
            Return False
        Catch serviceEx As ServiceNotConnectedException
            LogAndShowError($"Error de Conexión en SendBasicEmailWithAttachment", serviceEx)
            Return False
        Catch smtpEx As SmtpCommandException
            LogAndShowError($"Error SMTP en SendBasicEmailWithAttachment", smtpEx)
            Return False
        Catch ioEx As IOException
            LogAndShowError($"Error de Red/IO en SendBasicEmailWithAttachment", ioEx)
            Return False
        Catch ex As Exception
            LogAndShowError($"Error General en SendBasicEmailWithAttachment", ex)
            Return False
        End Try
    End Function

    ' --- Envía correo SIN adjunto, obteniendo datos de BD y formateando cuerpo desde DataTable ---
    ' Renombrada desde FCN_Email_EnviarSinAdjunto
    Public Function SendDataTableEmail(ByVal pEmailTipo As String, ByVal pSubject As String,
                                        ByVal pBodyHeader As String, ByVal dtBody As DataTable) As Boolean

        Dim pMasterCorreo As String = String.Empty ' Para visibilidad en Catch
        Dim pMasterPassword As String = String.Empty
        Try
            ' --- Obtener credenciales maestras (Sin usar ?.) ---
            Dim dtMasterCorreo = GET_Correos("Master", "Master_Correo")
            If dtMasterCorreo IsNot Nothing AndAlso dtMasterCorreo.Rows.Count > 0 AndAlso Not IsDBNull(dtMasterCorreo.Rows(0)(0)) Then
                pMasterCorreo = dtMasterCorreo.Rows(0)(0).ToString()
            End If

            Dim dtMasterPassword = GET_Correos("Master", "Master_Password")
            If dtMasterPassword IsNot Nothing AndAlso dtMasterPassword.Rows.Count > 0 AndAlso Not IsDBNull(dtMasterPassword.Rows(0)(0)) Then
                pMasterPassword = dtMasterPassword.Rows(0)(0).ToString()
            End If

            ' Verificar después de intentar obtenerlas
            If String.IsNullOrEmpty(pMasterCorreo) OrElse String.IsNullOrEmpty(pMasterPassword) Then
                Throw New Exception("No se pudieron obtener las credenciales maestras de correo.")
            End If


            ' Obtener Destinatarios
            Dim dtDestinatarios = GET_Correos(My.Application.Info.Title.ToString, pEmailTipo)
            If dtDestinatarios Is Nothing OrElse dtDestinatarios.Rows.Count = 0 Then
                System.Diagnostics.Trace.WriteLine($"SendDataTableEmail: No se encontraron destinatarios para el tipo: {pEmailTipo}")
                Return False
            End If

            Dim message As New MimeMessage()
            message.From.Add(New MailboxAddress(pMasterCorreo, pMasterCorreo))

            ' Procesar Destinatarios desde DataTable
            Dim addedRecipients As Integer = 0
            For Each row As DataRow In dtDestinatarios.Rows
                Dim emailValue = row("EmailUsuario")
                Dim emailAddr As String = String.Empty
                If Not IsDBNull(emailValue) AndAlso emailValue IsNot Nothing Then
                    emailAddr = emailValue.ToString()
                End If
                If Not String.IsNullOrWhiteSpace(emailAddr) Then
                    Try
                        message.To.Add(MailboxAddress.Parse(emailAddr.Trim()))
                        addedRecipients += 1
                    Catch exFormat As FormatException
                        System.Diagnostics.Trace.WriteLine($"Formato de correo inválido en SendDataTableEmail: {emailAddr} - {exFormat.Message}")
                    End Try
                End If
            Next
            If addedRecipients = 0 Then
                System.Diagnostics.Trace.WriteLine($"SendDataTableEmail: No se añadieron destinatarios válidos para el tipo: {pEmailTipo}")
                Return False
            End If

            message.Subject = pSubject

            ' Construir Cuerpo desde DataTable (Texto Plano con Tabs)
            Dim sbBody As New StringBuilder()
            If Not String.IsNullOrWhiteSpace(pBodyHeader) Then
                sbBody.AppendLine(pBodyHeader)
                sbBody.AppendLine()
                sbBody.AppendLine()
            End If
            Dim headers As New List(Of String)
            For Each col As DataColumn In dtBody.Columns
                headers.Add(col.ColumnName)
            Next
            sbBody.AppendLine(String.Join(vbTab & vbTab, headers))
            sbBody.AppendLine("---------------------------------------------------")
            For Each row As DataRow In dtBody.Rows
                Dim rowData As New List(Of String)
                For Each item In row.ItemArray
                    Dim cellValue As String = String.Empty
                    If item IsNot Nothing AndAlso Not IsDBNull(item) Then
                        cellValue = item.ToString()
                    End If
                    rowData.Add(cellValue)
                Next
                sbBody.AppendLine(String.Join(vbTab & vbTab, rowData))
            Next

            Dim bodyBuilder As New BodyBuilder() With {.TextBody = sbBody.ToString()}
            message.Body = bodyBuilder.ToMessageBody()

            ' Enviar
            Using client As New SmtpClient()
                client.Connect("smtp.migadu.com", 465, SecureSocketOptions.SslOnConnect)
                client.Authenticate(pMasterCorreo, pMasterPassword)
                client.Send(message)
                client.Disconnect(True)
            End Using

            Return True

        Catch authEx As AuthenticationException
            LogAndShowError($"Error de Autenticación en SendDataTableEmail ({pMasterCorreo})", authEx)
            Return False
        Catch serviceEx As ServiceNotConnectedException
            LogAndShowError($"Error de Conexión en SendDataTableEmail (Tipo: {pEmailTipo})", serviceEx)
            Return False
        Catch smtpEx As SmtpCommandException
            LogAndShowError($"Error SMTP en SendDataTableEmail (Tipo: {pEmailTipo})", smtpEx)
            Return False
        Catch ioEx As IOException
            LogAndShowError($"Error de Red/IO en SendDataTableEmail (Tipo: {pEmailTipo})", ioEx)
            Return False
        Catch ex As Exception
            LogAndShowError($"Error General en SendDataTableEmail (Tipo: {pEmailTipo})", ex)
            Return False
        End Try
    End Function

    ' --- Envía correo CON adjunto PDF, obteniendo datos de BD ---
    ' Renombrada desde FCN_Email_EnviarConAdjunto
    Public Function SendPdfAttachmentEmail(ByVal pEmailTipo As String, ByVal pSubject As String,
                                           ByVal pBodyHeader As String, ByVal pNameAtt As String) As Boolean

        Dim pMasterCorreo As String = String.Empty
        Dim pMasterPassword As String = String.Empty
        Try
            ' --- Obtener credenciales maestras (Sin usar ?.) ---
            Dim dtMasterCorreo = GET_Correos("Master", "Master_Correo")
            If dtMasterCorreo IsNot Nothing AndAlso dtMasterCorreo.Rows.Count > 0 AndAlso Not IsDBNull(dtMasterCorreo.Rows(0)(0)) Then
                pMasterCorreo = dtMasterCorreo.Rows(0)(0).ToString()
            End If

            Dim dtMasterPassword = GET_Correos("Master", "Master_Password")
            If dtMasterPassword IsNot Nothing AndAlso dtMasterPassword.Rows.Count > 0 AndAlso Not IsDBNull(dtMasterPassword.Rows(0)(0)) Then
                pMasterPassword = dtMasterPassword.Rows(0)(0).ToString()
            End If

            If String.IsNullOrEmpty(pMasterCorreo) OrElse String.IsNullOrEmpty(pMasterPassword) Then
                Throw New Exception("No se pudieron obtener las credenciales maestras de correo.")
            End If


            ' Obtener Destinatarios
            Dim dtDestinatarios = GET_Correos(My.Application.Info.Title.ToString, pEmailTipo)
            If dtDestinatarios Is Nothing OrElse dtDestinatarios.Rows.Count = 0 Then
                System.Diagnostics.Trace.WriteLine($"SendPdfAttachmentEmail: No se encontraron destinatarios para tipo: {pEmailTipo}")
                Return False
            End If

            Dim message As New MimeMessage()
            message.From.Add(New MailboxAddress(pMasterCorreo, pMasterCorreo))

            ' Procesar Destinatarios
            Dim addedRecipients As Integer = 0
            For Each row As DataRow In dtDestinatarios.Rows
                Dim emailValue = row("EmailUsuario")
                Dim emailAddr As String = String.Empty
                If Not IsDBNull(emailValue) AndAlso emailValue IsNot Nothing Then
                    emailAddr = emailValue.ToString()
                End If

                If Not String.IsNullOrWhiteSpace(emailAddr) Then
                    Try
                        message.To.Add(MailboxAddress.Parse(emailAddr.Trim()))
                        addedRecipients += 1
                    Catch exFormat As FormatException
                        System.Diagnostics.Trace.WriteLine($"Formato de correo inválido en SendPdfAttachmentEmail: {emailAddr} - {exFormat.Message}")
                    End Try
                End If
            Next
            If addedRecipients = 0 Then
                System.Diagnostics.Trace.WriteLine($"SendPdfAttachmentEmail: No se añadieron destinatarios válidos para tipo: {pEmailTipo}")
                Return False
            End If

            message.Subject = pSubject

            ' Cuerpo y Adjunto PDF
            Dim bodyBuilder As New BodyBuilder() With {.TextBody = pBodyHeader}
            Dim attachmentPath As String = Path.Combine(Application.StartupPath, "Att", pNameAtt & ".pdf")

            If File.Exists(attachmentPath) Then
                bodyBuilder.Attachments.Add(attachmentPath)
            Else
                System.Diagnostics.Trace.WriteLine($"Advertencia SendPdfAttachmentEmail: Archivo PDF adjunto no encontrado: {attachmentPath}")
                Throw New FileNotFoundException("El archivo PDF adjunto especificado no fue encontrado.", attachmentPath)
            End If
            message.Body = bodyBuilder.ToMessageBody()

            ' Enviar
            Using client As New SmtpClient()
                client.Connect("smtp.migadu.com", 465, SecureSocketOptions.SslOnConnect)
                client.Authenticate(pMasterCorreo, pMasterPassword)
                client.Send(message)
                client.Disconnect(True)
            End Using

            Return True

        Catch authEx As AuthenticationException
            LogAndShowError($"Error de Autenticación en SendPdfAttachmentEmail ({pMasterCorreo})", authEx)
            Return False
        Catch fnfEx As FileNotFoundException
            LogAndShowError($"Error en SendPdfAttachmentEmail (Tipo: {pEmailTipo})", fnfEx)
            Return False
        Catch serviceEx As ServiceNotConnectedException
            LogAndShowError($"Error de Conexión en SendPdfAttachmentEmail (Tipo: {pEmailTipo})", serviceEx)
            Return False
        Catch smtpEx As SmtpCommandException
            LogAndShowError($"Error SMTP en SendPdfAttachmentEmail (Tipo: {pEmailTipo})", smtpEx)
            Return False
        Catch ioEx As IOException
            LogAndShowError($"Error de Red/IO en SendPdfAttachmentEmail (Tipo: {pEmailTipo})", ioEx)
            Return False
        Catch ex As Exception
            LogAndShowError($"Error General en SendPdfAttachmentEmail (Tipo: {pEmailTipo})", ex)
            Return False
        End Try
    End Function

    ' --- Envía correo CON imagen EMBEBIDA, obteniendo datos de BD ---
    ' *** NOMBRE RESTAURADO *** a FCN_Email_EnviarConAdjuntoDeFondo
    Public Function FCN_Email_EnviarConAdjuntoDeFondo(ByVal pEmailTipo As String, ByVal pSubject As String,
                                                      ByVal pBodyHtmlTemplate As String, ByVal pImageName As String) As Boolean

        Dim pMasterCorreo As String = String.Empty
        Dim pMasterPassword As String = String.Empty
        Try
            ' --- Obtener credenciales maestras (Sin usar ?.) ---
            Dim dtMasterCorreo = GET_Correos("Master", "Master_Correo")
            If dtMasterCorreo IsNot Nothing AndAlso dtMasterCorreo.Rows.Count > 0 AndAlso Not IsDBNull(dtMasterCorreo.Rows(0)(0)) Then
                pMasterCorreo = dtMasterCorreo.Rows(0)(0).ToString()
            End If

            Dim dtMasterPassword = GET_Correos("Master", "Master_Password")
            If dtMasterPassword IsNot Nothing AndAlso dtMasterPassword.Rows.Count > 0 AndAlso Not IsDBNull(dtMasterPassword.Rows(0)(0)) Then
                pMasterPassword = dtMasterPassword.Rows(0)(0).ToString()
            End If

            If String.IsNullOrEmpty(pMasterCorreo) OrElse String.IsNullOrEmpty(pMasterPassword) Then
                Throw New Exception("No se pudieron obtener las credenciales maestras de correo.")
            End If


            ' Obtener Destinatarios
            Dim dtDestinatarios = GET_Correos(My.Application.Info.Title.ToString, pEmailTipo)
            If dtDestinatarios Is Nothing OrElse dtDestinatarios.Rows.Count = 0 Then
                System.Diagnostics.Trace.WriteLine($"FCN_Email_EnviarConAdjuntoDeFondo: No se encontraron destinatarios para tipo: {pEmailTipo}")
                Return False
            End If

            Dim message As New MimeMessage()
            message.From.Add(New MailboxAddress(pMasterCorreo, pMasterCorreo))

            ' Procesar Destinatarios
            Dim addedRecipients As Integer = 0
            For Each row As DataRow In dtDestinatarios.Rows
                Dim emailValue = row("EmailUsuario")
                Dim emailAddr As String = String.Empty
                If Not IsDBNull(emailValue) AndAlso emailValue IsNot Nothing Then
                    emailAddr = emailValue.ToString()
                End If

                If Not String.IsNullOrWhiteSpace(emailAddr) Then
                    Try
                        message.To.Add(MailboxAddress.Parse(emailAddr.Trim()))
                        addedRecipients += 1
                    Catch exFormat As FormatException
                        System.Diagnostics.Trace.WriteLine($"Formato de correo inválido en FCN_Email_EnviarConAdjuntoDeFondo: {emailAddr} - {exFormat.Message}")
                    End Try
                End If
            Next
            If addedRecipients = 0 Then
                System.Diagnostics.Trace.WriteLine($"FCN_Email_EnviarConAdjuntoDeFondo: No se añadieron destinatarios válidos para tipo: {pEmailTipo}")
                Return False
            End If

            message.Subject = pSubject

            ' Cuerpo HTML y Recurso Vinculado (Imagen Embebida)
            Dim bodyBuilder As New BodyBuilder()
            Dim imagePath As String = Path.Combine(Application.StartupPath, "Att", pImageName) ' Asume extensión en pImageName o añádela

            If File.Exists(imagePath) Then
                Dim imageResource = bodyBuilder.LinkedResources.Add(imagePath)
                imageResource.ContentId = MimeKit.Utils.MimeUtils.GenerateMessageId()

                ' Asume que pBodyHtmlTemplate contiene algo como <img src="cid:{IMAGE_CID}">
                bodyBuilder.HtmlBody = pBodyHtmlTemplate.Replace("{IMAGE_CID}", imageResource.ContentId)
            Else
                System.Diagnostics.Trace.WriteLine($"Advertencia FCN_Email_EnviarConAdjuntoDeFondo: Imagen no encontrada: {imagePath}")
                bodyBuilder.HtmlBody = pBodyHtmlTemplate.Replace($"<img src=""cid:{{IMAGE_CID}}"">", $"[Imagen '{pImageName}' no encontrada]") ' Usar comillas dobles escapadas
            End If
            message.Body = bodyBuilder.ToMessageBody()

            ' Enviar
            Using client As New SmtpClient()
                client.SslProtocols = System.Security.Authentication.SslProtocols.Tls12 ' o Tls13
                client.Connect("smtp.migadu.com", 465, SecureSocketOptions.SslOnConnect)
                client.Authenticate(pMasterCorreo, pMasterPassword)

                ' Timeout de 30 segundos
                client.Timeout = 30000

                client.Send(message)
                client.Disconnect(True)
            End Using

            Return True

        Catch authEx As AuthenticationException
            LogAndShowError($"Error de Autenticación en FCN_Email_EnviarConAdjuntoDeFondo ({pMasterCorreo})", authEx)
            Return False
        Catch fnfEx As FileNotFoundException
            LogAndShowError($"Error en FCN_Email_EnviarConAdjuntoDeFondo (Tipo: {pEmailTipo})", fnfEx)
            Return False
        Catch serviceEx As ServiceNotConnectedException
            LogAndShowError($"Error de Conexión en FCN_Email_EnviarConAdjuntoDeFondo (Tipo: {pEmailTipo})", serviceEx)
            Return False
        Catch smtpEx As SmtpCommandException
            LogAndShowError($"Error SMTP en FCN_Email_EnviarConAdjuntoDeFondo (Tipo: {pEmailTipo})", smtpEx)
            Return False
        Catch ioEx As IOException
            LogAndShowError($"Error de Red/IO en FCN_Email_EnviarConAdjuntoDeFondo (Tipo: {pEmailTipo})", ioEx)
            Return False
        Catch ex As Exception
            LogAndShowError($"Error General en FCN_Email_EnviarConAdjuntoDeFondo (Tipo: {pEmailTipo})", ex)
            Return False
        End Try
    End Function

    ' --- Helper Function para obtener destinatarios (Tu código original, con chequeo de nulos) ---
    ' Asume que mConexion y mMensajes existen en tu proyecto
    Public Function GET_Correos(ByVal pAplicacionId As String, ByVal pEmailTipo As String) As DataTable
        Dim dt As DataTable = Nothing ' Inicializar a Nothing
        Try
            Dim qry As New StringBuilder()

            ' Considera usar parámetros SQL para seguridad
            qry.Append(" SELECT EmailUsuario ")
            qry.Append(" FROM APGS.dbo.SEG_Email ")
            qry.Append(" WHERE AplicacionId = '" & pAplicacionId.Replace("'", "''") & "' ")
            qry.Append(" AND EmailTipo = '" & pEmailTipo.Replace("'", "''") & "' ")

            dt = mConexion.ConectarSQLGT_DT(qry.ToString) ' Usa tu clase real
            Return dt

        Catch ex As Exception
            LogAndShowError($"Error en GET_Correos (App: {pAplicacionId}, Tipo: {pEmailTipo})", ex, False) ' Solo loguear
            Return Nothing
        End Try
    End Function

    ' --- Helper privado para Loguear Error y Mostrar Mensaje (Opcional) ---
    Private Sub LogAndShowError(ByVal contextMessage As String, ByVal exception As Exception, Optional showMsgBox As Boolean = True)
        Dim fullErrorMessage As String = $"{contextMessage}: ({exception.GetType().Name}) - {exception.Message}"
        System.Diagnostics.Trace.WriteLine(fullErrorMessage)
        System.Diagnostics.Trace.WriteLine(exception.ToString())

        If showMsgBox Then
            Try
                ' Asumiendo que msg_Error es un método Shared en tu clase mMensajes
                mMensajes.msg_Error(fullErrorMessage)
            Catch msgEx As Exception
                System.Diagnostics.Trace.WriteLine($"Error al llamar a mMensajes.msg_Error: {msgEx.Message}")
                MsgBox(fullErrorMessage, MsgBoxStyle.Critical, "Error de Envío de Correo (Fallo Log)")
            End Try
        End If
    End Sub

End Module
