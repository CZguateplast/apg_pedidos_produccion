Public Class frmPlanPrioridadesAlmacen_Hijos

    Private pCodigoPadre As String


    Public Property ppCodigoPadre() As String
        Get
            Return pCodigoPadre
        End Get
        Set(ByVal Value As String)

            pCodigoPadre = Value
        End Set
    End Property


    Private Sub frmPlanPrioridadesAlmacen_Hijos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Hijos.TableName.ToString).Clear()
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Hijos.TableName.ToString).Clear()

            Dim dt As New DataTable("dtProduccionHijos")

            If pCodigoPadre = String.Empty Then
                Exit Sub
            End If

            dt = mSQLSelect.GET_OrdenesProduccion_Hijos(pCodigoPadre)
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If
            DsEmergenciasProduccion1.Tables(DsEmergenciasProduccion1.dsdtEmergenciasProduccion_Hijos.TableName.ToString).Merge(dt)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
        

    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnOrdenProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnOrdenProduccion.ItemClick
        Try
            Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(grdviewPlanPrioridadesAlmacen, "CodigoArticulo")

            If pCodigoArticulo = Nothing Then
                Exit Sub
            End If

            frmTemporal_OrdenesProduccionEnsambleDetalle.ppCodigoTipo = "CP"
            frmTemporal_OrdenesProduccionEnsambleDetalle.ppCodigoArticulo = pCodigoArticulo

            frmTemporal_OrdenesProduccionEnsambleDetalle.ShowDialog(Me)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_ImprimirGrid(grdviewPlanPrioridadesAlmacen)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class