Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports DevExpress.XtraGrid
Imports System.Text
Imports System.Runtime.InteropServices

Module mConexion

    Public oCompanyGT As New SAPbobsCOM.Company()
    Public oCompanyES As New SAPbobsCOM.Company()
    Public oCompanyCR As New SAPbobsCOM.Company()
    Public oCompanyMX As New SAPbobsCOM.Company()

    'Obtener usuario y contraseña SAP
    Public Sub GET_Usuario_SAP(ByVal pFirma As String, ByRef sapUsuario As String, ByRef sapPassword As String)
        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT sap.sap_usuario, sap.sap_password ")
            qry.Append(" FROM APGS.dbo.SEG_Usuarios sap")
            qry.Append(" where UsuarioId = '" + pFirma + "' ")

            ' Valores por defecto
            sapUsuario = "apg"
            sapPassword = "24271400"

            ' Ejecutar la consulta y obtener el DataTable
            Dim dt As DataTable = mConexion.ConectarSQLGT_DT(qry.ToString)

            ' Comprobar si el DataTable tiene filas y manejar los valores nulos
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                If Not IsDBNull(row("sap_usuario")) Then
                    sapUsuario = row("sap_usuario").ToString()
                End If
                If Not IsDBNull(row("sap_password")) Then
                    sapPassword = row("sap_password").ToString()
                End If
            End If

            ' Asignar valores por defecto solo si tanto usuario como contraseña son nulos
            If sapUsuario Is Nothing AndAlso sapPassword Is Nothing Then
                sapUsuario = "apg"
                sapPassword = "24271400"
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            'Al existir una excepcion asigna por defeto el usuairo apg
            sapUsuario = "apg"
            sapPassword = "24271400"
        End Try
    End Sub

    Public Function ValidarOpciones(ByVal pUsuario As String, ByVal pAplicacion As String, ByVal pOpcion As String) As Boolean

        Dim qry As String = String.Empty
        Dim dt As New DataTable("dtPaises")

        Try
            qry = "SELECT A.IdUsuario,A.IdRol,B.IdAplicacion,B.IdPermiso,B.Estatus "
            qry += " FROM APGS.dbo.SeguridadRolesUsuarios A"
            qry += " LEFT JOIN APGS.dbo.SeguridadPermisosAplicaciones B ON B.IdRol = A.IdRol"
            qry += " WHERE a.IdUsuario = '" + pUsuario + "' and B.IdAplicacion = '" + pAplicacion + "' and B.IdPermiso = '" + pOpcion + "'"
            qry += " ORDER BY Estatus DESC"

            dt = mConexion.ConectarSQLGT_DT(qry) 'Ejecutar  

            If dt.Rows.Count = 0 Then
                Return True
            Else
                If dt.Rows(0)("Estatus").ToString = "True" Then
                    Return True
                Else
                    Return False
                End If
            End If
            '34844932
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Sub AccesoSeguridad()
        Try

            'Dim tmp() As String
            'Dim a As Integer
            Dim op As String = String.Empty
            Dim Arraylistt As String()

            My.Settings.log_Usuario = String.Empty

            'Validar Usuario
            If Environment.GetCommandLineArgs.Length = 2 Then
                Arraylistt = Environment.GetCommandLineArgs(1).Split(" ")
                For i = 0 To Arraylistt.Length - 1
                    op += Arraylistt(i).ToString
                Next

                My.Settings.log_Usuario = op
                'MsgBox(op)

            ElseIf Environment.UserName <> "" Then
                My.Settings.log_Usuario = Environment.UserName
            Else

                MsgBox("No se encuentra Usuario Activo. Comunicarse a informatica", MsgBoxStyle.OkOnly)
            End If

            Dim pDT As New DataTable()
            pDT = GET_Usuario(My.Settings.log_Usuario.ToString)
            My.Settings.log_Nombre = pDT.Rows(0)("UsuarioNombre").ToString

            'CONEXION SQL
            'VALIDAR BASE DE DATOS A TRABAJAR    < 1 = SBOGuateplast [PRODUCTIVA]>  /  < 2 = SBOGuatetest [TEST]>
            My.Settings.log_DB = mSQLSelect.GET_SEG_Catalogos("SAPDB", pDT.Rows(0)("SAPDB").ToString).Rows(0)("Nombre").ToString

            'CONEXION DI API
            If pDT.Rows(0)("SAPDB").ToString = 1 Then
                My.Settings.dbconectionDIAPI_GT_Tipo = "dbconectionDIAPI_GT"
            Else
                My.Settings.dbconectionDIAPI_GT_Tipo = "dbconectionDIAPI_GTT"
            End If


            'MsgBox(My.Settings.log_DB.ToString)
            'My.Settings.ref_Usuario_Activo = "ejperez"
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Public Function ConectarSQLGT_DT(ByVal pString As String) As DataTable
        Try
            Dim cnn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable("dtResultado")
            Dim ConeccionTipoGT As String = My.Settings.dbconectionSQL_GT_Tipo

            If My.Settings.dbconectionSQL_GT_Tipo = "dbconectionSQL_GT" Then
                ConeccionTipoGT = My.Settings.dbconectionSQL_GT
            ElseIf My.Settings.dbconectionDIAPI_GT_Tipo = "dbconectionSQL_GTT" Then
                ConeccionTipoGT = My.Settings.dbconectionSQL_GTT
            End If

            cnn.ConnectionString = Decrypt(ConeccionTipoGT, "infogua")
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandTimeout = 900000
            cmd.CommandText = pString
            adp.SelectCommand = cmd
            adp.Fill(dt)
            cnn.Close()
            Return dt



        Catch ex As Exception
            mMensajes.msg_Error(ex.ToString)
            Return Nothing
        End Try
    End Function

    'Conexion de Mexico
    Public Function ConectarSQL_MX(ByVal pString As String) As DataTable
        Try
            Dim cnn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable("dtResultado")


            cnn.ConnectionString = Decrypt(My.Settings.dbconectionSQL_MX, "infogua")
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = pString
            adp.SelectCommand = cmd
            adp.Fill(dt)
            cnn.Close()
            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function ConectarSQLSV_DT(ByVal pString As String) As DataTable
        Try
            Dim cnn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable("dtResultado")


            cnn.ConnectionString = Decrypt(My.Settings.dbconectionSQL_SV, "infogua")
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = pString
            adp.SelectCommand = cmd
            adp.Fill(dt)
            cnn.Close()
            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function ConectarSQLCR_DT(ByVal pString As String) As DataTable
        Try
            Dim cnn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable("dtResultado")


            cnn.ConnectionString = Decrypt(My.Settings.dbconectionSQL_CR, "infogua")
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = pString
            adp.SelectCommand = cmd
            adp.Fill(dt)
            cnn.Close()
            Return dt

        Catch ex As Exception
            mMensajes.msg_Error(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function ConectarDIAPIGT() As Boolean
        'Obtener usuario de sap y contraseña de usuaario logeado
        Dim usuario As String = ""
        Dim contrasena As String = ""
        GET_Usuario_SAP(My.Settings.log_Usuario.ToString, usuario, contrasena)
        Try
            Dim ConeccionDIAPI_GT_TIPO As String = String.Empty
            If My.Settings.dbconectionDIAPI_GT_Tipo = "dbconectionDIAPI_GT" Then
                ConeccionDIAPI_GT_TIPO = My.Settings.dbconectionDIAPI_GT
            ElseIf My.Settings.dbconectionDIAPI_GT_Tipo = "dbconectionDIAPI_GTT" Then
                ConeccionDIAPI_GT_TIPO = My.Settings.dbconectionDIAPI_GTT
            End If
            Dim arrConexionDIAPI() As String = Decrypt(ConeccionDIAPI_GT_TIPO, "infogua").Split(";")

            oCompanyGT.Server = arrConexionDIAPI(0).Split("=")(1).ToString
            oCompanyGT.CompanyDB = arrConexionDIAPI(1).Split("=")(1).ToString
            'oCompanyGT.UserName = arrConexionDIAPI(2).Split("=")(1).ToString
            'oCompanyGT.Password = arrConexionDIAPI(3).Split("=")(1).ToString
            oCompanyGT.UserName = usuario
            oCompanyGT.Password = contrasena
            oCompanyGT.DbUserName = arrConexionDIAPI(4).Split("=")(1).ToString
            oCompanyGT.DbPassword = arrConexionDIAPI(5).Split("=")(1).ToString
            oCompanyGT.DbServerType = arrConexionDIAPI(6).Split("=")(1).ToString
            oCompanyGT.language = arrConexionDIAPI(7).Split("=")(1).ToString
            oCompanyGT.LicenseServer = arrConexionDIAPI(8).Split("=")(1).ToString

            Dim oResultado As Integer = 1

            If (oCompanyGT IsNot Nothing AndAlso oCompanyGT.Connected) Then
                ' Valida que exista una conexión, de ser así, no la vuelve a crear
                Return True
            Else
                oResultado = oCompanyGT.Connect()
                If (oResultado = 0) Then
                    If My.Settings.dbconectionDIAPI_GT_Tipo = "dbconectionDIAPI_GT" Then
                        ' MsgBox("Conectado con éxito! Guatemala")
                    ElseIf My.Settings.dbconectionDIAPI_GT_Tipo = "dbconectionDIAPI_GTT" Then
                        ' MsgBox("Conectado con éxito! Guatemala TEST")
                    End If
                    Return True
                Else
                    Throw New Exception(oCompanyGT.GetLastErrorDescription())
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ConectarDIAPISV() As Boolean
        'Obtener usuario de sap y contraseña de usuaario logeado
        Dim usuario As String = ""
        Dim contrasena As String = ""
        GET_Usuario_SAP(My.Settings.log_Usuario.ToString, usuario, contrasena)
        Try
            Dim arrConexionDIAPI() As String = Decrypt(My.Settings.dbconectionDIAPI_SV, "infogua").Split(";")

            oCompanyES.Server = arrConexionDIAPI(0).Split("=")(1).ToString
            oCompanyES.CompanyDB = arrConexionDIAPI(1).Split("=")(1).ToString
            'oCompany.UserName = arrConexionDIAPI(2).Split("=")(1).ToString
            'oCompany.Password = arrConexionDIAPI(3).Split("=")(1).ToString
            oCompanyES.UserName = usuario
            oCompanyES.Password = contrasena
            oCompanyES.DbUserName = arrConexionDIAPI(4).Split("=")(1).ToString
            oCompanyES.DbPassword = arrConexionDIAPI(5).Split("=")(1).ToString
            oCompanyES.DbServerType = arrConexionDIAPI(6).Split("=")(1).ToString
            oCompanyES.language = arrConexionDIAPI(7).Split("=")(1).ToString
            oCompanyES.LicenseServer = arrConexionDIAPI(8).Split("=")(1).ToString

            Dim oResultado As Integer = 1

            If (oCompanyES IsNot Nothing AndAlso oCompanyES.Connected) Then 'Valida que exista un conexion de ser asi no la vulve a crear
                Return True
            Else
                oResultado = oCompanyES.Connect()
                If (oResultado = 0) Then
                    'MsgBox("Conectado con exito! El Salvador")
                    Return True
                Else
                    Throw New Exception(oCompanyES.GetLastErrorDescription())
                    Return False
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Conexion de Mexico
    Public Function ConectarDIAPI_MX() As Boolean
        'Obtener usuario de sap y contraseña de usuaario logeado
        Dim usuario As String = ""
        Dim contrasena As String = ""
        GET_Usuario_SAP(My.Settings.log_Usuario.ToString, usuario, contrasena)
        Try
            Dim arrConexionDIAPI() As String = Decrypt(My.Settings.dbconectionDIAPI_MX, "infogua").Split(";")

            oCompanyMX.Server = arrConexionDIAPI(0).Split("=")(1).ToString
            oCompanyMX.CompanyDB = arrConexionDIAPI(1).Split("=")(1).ToString
            'oCompanyMX.UserName = arrConexionDIAPI(2).Split("=")(1).ToString
            'oCompanyMX.Password = arrConexionDIAPI(3).Split("=")(1).ToString
            oCompanyMX.UserName = usuario
            oCompanyMX.Password = contrasena
            oCompanyMX.DbUserName = arrConexionDIAPI(4).Split("=")(1).ToString
            oCompanyMX.DbPassword = arrConexionDIAPI(5).Split("=")(1).ToString
            oCompanyMX.DbServerType = arrConexionDIAPI(6).Split("=")(1).ToString
            oCompanyMX.language = arrConexionDIAPI(7).Split("=")(1).ToString
            oCompanyMX.LicenseServer = arrConexionDIAPI(8).Split("=")(1).ToString

            Dim oResultado As Integer = 1

            If (oCompanyMX IsNot Nothing AndAlso oCompanyMX.Connected) Then 'Valida que exista un conexion de ser asi no la vulve a crear
                Return True
            Else
                oResultado = oCompanyMX.Connect()
                If (oResultado = 0) Then
                    Return True
                Else
                    Throw New Exception(oCompanyMX.GetLastErrorDescription())
                    Return False
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ConectarDIAPICR() As Boolean
        'Obtener usuario de sap y contraseña de usuaario logeado
        Dim usuario As String = ""
        Dim contrasena As String = ""
        GET_Usuario_SAP(My.Settings.log_Usuario.ToString, usuario, contrasena)
        Try
            Dim arrConexionDIAPI() As String = Decrypt(My.Settings.dbconectionDIAPI_CR, "infogua").Split(";")

            oCompanyCR.Server = arrConexionDIAPI(0).Split("=")(1).ToString
            oCompanyCR.CompanyDB = arrConexionDIAPI(1).Split("=")(1).ToString
            'oCompanyCR.UserName = arrConexionDIAPI(2).Split("=")(1).ToString
            'oCompanyCR.Password = arrConexionDIAPI(3).Split("=")(1).ToString
            oCompanyCR.UserName = usuario
            oCompanyCR.Password = contrasena
            oCompanyCR.DbUserName = arrConexionDIAPI(4).Split("=")(1).ToString
            oCompanyCR.DbPassword = arrConexionDIAPI(5).Split("=")(1).ToString
            oCompanyCR.DbServerType = arrConexionDIAPI(6).Split("=")(1).ToString
            oCompanyCR.language = arrConexionDIAPI(7).Split("=")(1).ToString
            oCompanyCR.LicenseServer = arrConexionDIAPI(8).Split("=")(1).ToString

            Dim oResultado As Integer = 1
            If (oCompanyCR IsNot Nothing AndAlso oCompanyCR.Connected) Then 'Valida que exista un conexion de ser asi no la vulve a crear
                Return True
            Else

                oResultado = oCompanyCR.Connect()
                If (oResultado = 0) Then
                    'MsgBox("Conectado con exito. Costa Rica!")
                    Return True
                Else
                    Throw New Exception(oCompanyCR.GetLastErrorDescription())
                    Return False
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub DesconectarDIAPIGT()
        Try
            Dim ConeccionTipoGT As String = My.Settings.dbconectionSQL_GT_Tipo

            If My.Settings.dbconectionSQL_GT_Tipo = "dbconectionSQL_GT" Then
                If (oCompanyGT.Connected) Then
                    'oCompanyGT.Disconnect()
                End If
            ElseIf My.Settings.dbconectionDIAPI_GT_Tipo = "dbconectionSQL_GTT" Then
                If (oCompanyGT.Connected) Then
                    'oCompanyGT.Disconnect()
                End If

            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub DesconectarDIAPISV()
        Try
            If (oCompanyES.Connected) Then
                ' oCompanyES.Disconnect()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    'Desconexion de Mexico
    Public Sub DesconectarDIAPI_MX()
        Try
            If (oCompanyMX.Connected) Then
                'oCompanyMX.Disconnect()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Public Sub DesconectarDIAPICR()
        Try
            If (oCompanyCR.Connected) Then
                'oCompanyCR.Disconnect()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Public Sub DesconectarDIAPI_Goblal()
        Try
            Dim ConeccionTipoGT As String = My.Settings.dbconectionSQL_GT_Tipo
            'Guatemala
            If My.Settings.dbconectionSQL_GT_Tipo = "dbconectionSQL_GT" Then
                If (oCompanyGT IsNot Nothing AndAlso oCompanyGT.Connected) Then
                    'oCompanyGT.Disconnect()
                End If
            ElseIf My.Settings.dbconectionDIAPI_GT_Tipo = "dbconectionSQL_GTT" Then
                If (oCompanyGT IsNot Nothing AndAlso oCompanyGT.Connected) Then
                    'oCompanyGT.Disconnect()
                End If

            End If

            'CostaRica
            If (oCompanyCR IsNot Nothing AndAlso oCompanyCR.Connected) Then
                'oCompanyCR.Disconnect()
            End If

            'ElSalvador
            If (oCompanyES IsNot Nothing AndAlso oCompanyES.Connected) Then
                'oCompanyES.Disconnect()
            End If

            'Mexico
            If (oCompanyMX IsNot Nothing AndAlso oCompanyMX.Connected) Then
                'oCompanyMX.Disconnect()
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Module
