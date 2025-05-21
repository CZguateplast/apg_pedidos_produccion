Public Class frmTemporal_OrdenesProduccionEnsambleDetalle

    Private pCodigoArticulo As String
    Private pCodigoTipo As String


    Public Property ppCodigoArticulo As String
        Get
            Return pCodigoArticulo
        End Get
        Set(ByVal Value As String)
            pCodigoArticulo = Value
        End Set
    End Property

    Public Property ppCodigoTipo As String
        Get
            Return pCodigoTipo
        End Get
        Set(ByVal Value As String)
            pCodigoTipo = Value
        End Set
    End Property

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmTemporal_OrdenesProduccionEnsambleDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim dt As New DataTable()
            dt = mSQLSelect.GET_OrdenesProduccion_Orden(pCodigoTipo, pCodigoArticulo)
            If dt.Rows.Count = Nothing Then
                DsTemporal_OrdenesProduccionEnsambleDetalle1.Tables(DsTemporal_OrdenesProduccionEnsambleDetalle1.dsdtTemporal_OrdenesProduccionEnsambleDetalle.TableName.ToString).Clear()
                Me.Close()
            End If

            DsTemporal_OrdenesProduccionEnsambleDetalle1.Tables(DsTemporal_OrdenesProduccionEnsambleDetalle1.dsdtTemporal_OrdenesProduccionEnsambleDetalle.TableName.ToString).Clear()
            DsTemporal_OrdenesProduccionEnsambleDetalle1.Tables(DsTemporal_OrdenesProduccionEnsambleDetalle1.dsdtTemporal_OrdenesProduccionEnsambleDetalle.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDocumentoDetalle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDocumentoDetalle.ItemClick
        Try

            If grdviewOrdenesProduccionEnsambleDetalle.RowCount = Nothing Then
                Exit Sub
            End If

            Dim pSAP As String = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccionEnsambleDetalle, "NumSAP")
            If pSAP = String.Empty Then
                Exit Sub
            End If

            frmOrdenProduccionEnsamble.ppNumSAP = pSAP
            frmOrdenProduccionEnsamble.ppTipo = "Consulta"
            frmOrdenProduccionEnsamble.ShowDialog()



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnRecibos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnRecibos.ItemClick
        Try
            Dim pSap As String = String.Empty

            pSap = grdviewOrdenesProduccionEnsambleDetalle.GetRowCellValue(grdviewOrdenesProduccionEnsambleDetalle.FocusedRowHandle, "NumSAP")


            frmTemporal_Recibos.ppNumeroSAP = pSap
            frmTemporal_Recibos.ShowDialog()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class