Imports DevExpress.XtraReports.UI
Public Class frmEtiquetasSolicitud
    Private mmCodigoPadre As String
    Private mmMaquina As String
    Private mmUbicacion As String

    Public Property vpCodigoPadre() As String
        Get
            Return mmCodigoPadre
        End Get
        Set(ByVal Value As String)

            mmCodigoPadre = Value
        End Set
    End Property

    Public Property vpMaquina() As String
        Get
            Return mmMaquina
        End Get
        Set(ByVal Value As String)

            mmMaquina = Value
        End Set
    End Property

    Public Property vpUbicacion() As String
        Get
            Return mmUbicacion
        End Get
        Set(ByVal Value As String)

            mmUbicacion = Value
        End Set
    End Property





    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmEtiquetasSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dtMaquina As New DataTable()

            dtMaquina = GET_Catalogo_Maquinas(mmMaquina)

            If Not dtMaquina.Rows.Count = Nothing Then
                mmUbicacion = dtMaquina.Rows(0)("Ubicacion").ToString

            End If

            mFunciones.FCN_FILL_SearchLookUpEdit(rslueOrigen, mSQLSelect.GET_PROD_CatListados("Orden_Origen"), "Id", "Nombre")

            DsEtiquetasSolicitud1.Tables(DsEtiquetasSolicitud1.dsdtCodigoHijos.TableName.ToString).Clear()
            DsEtiquetasSolicitud1.Tables(DsEtiquetasSolicitud1.dsdtEtiquetas.TableName.ToString).Clear()

            If mmCodigoPadre = Nothing Then
                MsgBox("Debe elegir un codigo valido para poder continuar.! Intente de Nuevo")
                Exit Sub
            End If


            Dim dtListaProducciones As New DataTable()
            dtListaProducciones = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_ListadoCodigoArticulo_OrdenesAbiertas_Padre " + "'" + mmCodigoPadre + "%'")

            If Not dtListaProducciones.Rows.Count = Nothing Then
                DsEtiquetasSolicitud1.Tables(DsEtiquetasSolicitud1.dsdtCodigoHijos.TableName.ToString).Clear()
                DsEtiquetasSolicitud1.Tables(DsEtiquetasSolicitud1.dsdtCodigoHijos.TableName.ToString).Merge(dtListaProducciones)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnSolicitarEtiquetas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSolicitarEtiquetas.ItemClick
        Try

            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If

            Dim pNumSAP As New ArrayList()
            Dim pEnvios As String = String.Empty


            pNumSAP = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadas(grdviewEtiquetas)



            For i = 0 To pNumSAP.Count - 1

                ssmEsperar.SetWaitFormCaption("Grabando...")
                ssmEsperar.SetWaitFormDescription(pNumSAP(i)("NumSAP").ToString)
                mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.Etiquetas_spInsert_Etiquetas_Solicitudes " _
                                           + pNumSAP(i)("NumSAP").ToString _
                                           + ", S ," _
                                           + "'" + mmUbicacion.ToString + "' ," _
                                           + "'" + My.Settings.log_Usuario.ToString + "'"
                                           )
            Next

            '+ "'" + pNumSAP(i)("Origen").ToString + "' ," _
            'ENVIO POR CORREO DE ETIQUETAS

            ssmEsperar.SetWaitFormCaption("Enviando...")
            ssmEsperar.SetWaitFormDescription("Correos")


            Dim dt As New DataTable()

            DsEtiquetasSolicitud1.Tables(DsEtiquetasSolicitud1.dsdtEtiquetasEnviadas.TableName.ToString).Clear()
            For i = 0 To pNumSAP.Count - 1
                Dim dtE As New DataTable()
                dtE = mConexion.ConectarSQLGT_DT("APGProduccion.dbo.Etiquetas_sp_Etiquetas_Solicitud_SAP '" + pNumSAP(i)("NumSAP").ToString + "'")
                DsEtiquetasSolicitud1.Tables(DsEtiquetasSolicitud1.dsdtEtiquetasEnviadas.TableName.ToString).Merge(dtE)
            Next


            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptEtiquetasSolicitud
            RPTdocumento.DataSource = Me.DsEtiquetasSolicitud1
            RPTdocumento.DataMember = Me.DsEtiquetasSolicitud1.dsdtEtiquetasEnviadas.TableName.ToString
            ''dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)

            mFunciones.ExportToPNG(RPTdocumento, "Reporte_EtiquetasSolicitud")
            mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("EtiquetasSolicitud", _
                                                        "Etiquetas Solicitadas por " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]", _
                                                        "Etiquetas", _
                                                        "Reporte_EtiquetasSolicitud")

            ssmEsperar.SetWaitFormCaption("Enviado...")
            ssmEsperar.SetWaitFormDescription("")
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If

            If MsgBox("Su correo ha sido enviado exitosamente!." + Environment.NewLine + "¿Desea ver el reporte?", MsgBoxStyle.YesNo, "Correo...") = MsgBoxResult.Yes Then
                PrintTool.ShowRibbonPreviewDialog()
            End If






            pEnvios = mFunciones.FCN_XTRAGRID_GetFilasSeleccionadasSinApostrofes(grdviewEtiquetas, "NumSAP")
            mMensajes.msg_Informacion("Se han enviado la solicitud de las siguientes Ordenes: " + Environment.NewLine + pEnvios)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub

    Private Sub grdviewCodigosHijos_DoubleClick(sender As Object, e As EventArgs) Handles grdviewCodigosHijos.DoubleClick
        Try
            Dim pCodigoHijo As String = String.Empty
            pCodigoHijo = mFunciones.FCN_GetCellValue(grdviewCodigosHijos, "CodigoArticulo")


            Dim dt As New DataTable()
            'dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.Etiquetas_sp_Etiquetas_Solicitud '" + pCodigoHijo + "'")
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_OrdenesAbiertasEnsamble_Hijo '" + pCodigoHijo + "'")

            DsEtiquetasSolicitud1.Tables(DsEtiquetasSolicitud1.dsdtEtiquetas.TableName.ToString).Clear()
            If Not dt.Rows.Count = Nothing Then
                For i = 0 To dt.Rows.Count - 1
                    Dim dtE As New DataTable()
                    dtE = mConexion.ConectarSQLGT_DT("APGProduccion.dbo.Etiquetas_sp_Etiquetas_Solicitud_SAP '" + dt.Rows(i)("NumeroSAP").ToString + "'")
                    DsEtiquetasSolicitud1.Tables(DsEtiquetasSolicitud1.dsdtEtiquetas.TableName.ToString).Merge(dtE)
                Next
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class