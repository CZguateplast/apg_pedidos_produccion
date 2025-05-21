
Public Class frmTemporal_OrdenesCerradasResultado


    Public vpEnviarCorreo As Boolean = False
    Private pTipoEvento As String
    Private pCodigoArticulo As String

    
    Public Property ppTipoEvento() As String
        Get
            Return pTipoEvento
        End Get
        Set(ByVal Value As String)
            pTipoEvento = Value
        End Set
    End Property
    Public Property ppCodigoArticulo() As String
        Get
            Return pCodigoArticulo
        End Get
        Set(ByVal Value As String)
            pCodigoArticulo = Value
        End Set
    End Property

    Private Sub frmTemporal_OrdenesCerradasResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            dt = GET_Temporal_OrdenesCerradas_EnviarPorCorreo(pCodigoArticulo)

            If Not dt.Rows.Count = Nothing Then
                DsTemporal_OrdenesCerradas1.Tables("dsdtTemporal_OrdenesCerradas").Clear()
                DsTemporal_OrdenesCerradas1.Tables("dsdtTemporal_OrdenesCerradas").Merge(dt)
            End If

            
            '---------------------------------- PROCEDIMIENTO PARA ENVIAR ORDENES CERRADAS --------------------------------
            If pTipoEvento = "Cerradas" Then

                If Not dt.Rows.Count = Nothing Then
                    Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptTemporal_OrdenesCerradas
                    RPTdocumento.DataSource = Me.DsTemporal_OrdenesCerradas1
                    RPTdocumento.DataMember = DsTemporal_OrdenesCerradas1.dsdtTemporal_OrdenesCerradas.TableName.ToString

                    '(ReporteSeleccion,NombredelArchivo)
                    mFunciones.ExportToPNG(RPTdocumento, "xrptTemporal_OrdenesCerradas")

                    '(EmailTipo,Asunto,EncabezadoReporte,NombreArchivoAdjunto)
                    'mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("Prueba", _
                    mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("OrdenesModificadasCerradas", _
                                                                "Ordenes Cerradas por " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]", _
                                                                "A continuación encontrará la lista de ordenes en SAP que fueron modificadas: ", _
                                                                "xrptTemporal_OrdenesCerradas")
                End If
            End If
            '---------------------------------- FINAL PROCEDIMIENTO PARA ENVIAR ORDENES CERRADAS --------------------------------


            If pTipoEvento = "Liberadas" Then

                Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptTemporal_OrdenesLiberadas
                RPTdocumento.DataSource = Me.DsTemporal_OrdenesCerradas1
                RPTdocumento.DataMember = DsTemporal_OrdenesCerradas1.dsdtTemporal_OrdenesCerradas.TableName.ToString

                '(ReporteSeleccion,NombredelArchivo)
                mFunciones.ExportToPNG(RPTdocumento, "xrptTemporal_OrdenesLiberadas")

                '(EmailTipo,Asunto,EncabezadoReporte,NombreArchivoAdjunto)
                mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("OrdenesModificadasLiberadas", _
                                                             "Ordenes Liberadas por " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]", _
                                                             "A continuación encontrará la lista de ordenes en SAP que fueron Liberadas: ", _
                                                             "xrptTemporal_OrdenesLiberadas")
            End If
            '---------------------------------- FINAL PROCEDIMIENTO PARA ENVIAR ORDENES CERRADAS --------------------------------


            Dim dt2 As New DataTable
            dt2 = GET_Temporal_OrdenesCerradas(pCodigoArticulo)

            If Not dt2.Rows.Count = Nothing Then
                DsTemporal_OrdenesCerradas1.Tables("dsdtTemporal_OrdenesCerradas").Clear()
                DsTemporal_OrdenesCerradas1.Tables("dsdtTemporal_OrdenesCerradas").Merge(dt2)
            End If




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub sbtnOk_Click(sender As Object, e As EventArgs) Handles sbtnOk.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            grdviewOrdenesCerradas.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToArray)
        End Try
    End Sub

    'If vpEnviarCorreo = True Then
    'Eliminar columnas que no se quieren detallar en el correo
    'dt.Columns.Remove("Tipo")
    'dt.Columns.Remove("NombreArticulo")
    'dt.Columns.Remove("Planeado")
    'dt.Columns.Remove("Completado")
    'dt.Columns.Remove("Creación")
    'dt.Columns.Remove("Vencimiento")
    'dt.Columns.Remove("Dias Atrasado")

    'FCN_Email_EnviarSinAdjunto("OrdenesModificadas", _
    '                          "Ordenes Modificadas [ " + DateTime.Now.ToString + " ] Usuario > " + My.Settings.log_Usuario.ToString, _
    '                       "A continuación encontrará la lista de ordenes en SAP que fueron modificadas: ", dt)
    'End If




End Class