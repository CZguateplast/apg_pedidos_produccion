Public Class frmEnsambleImpresion 

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmEnsambleImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Fill_Ensambles_Padres()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Fill_Ensambles_Padres()
        Try
            Dim dt As New DataTable()
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Ensamble_Ordenes_Padres] AR")

            DsEnsambleImpresion1.Tables(DsEnsambleImpresion1.dsdtEnsamblePadres.TableName.ToString).Clear()
            'llenar Grid con datos Actualizados
            If Not dt.Rows.Count = Nothing Then
                DsEnsambleImpresion1.Tables(DsEnsambleImpresion1.dsdtEnsamblePadres.TableName.ToString).Merge(dt)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewEnsamblePadres_DoubleClick(sender As Object, e As EventArgs) Handles grdviewEnsamblePadres.DoubleClick
        Try
            'Fill_Ensambles_Hijos()
            FC_ImprimirEnsamble()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Fill_Ensambles_Hijos()
        Try
            DsEnsambleImpresion1.Tables(DsEnsambleImpresion1.dsdtEnsambleOrdenes.TableName.ToString).Clear()
            DsEnsambleImpresion1.Tables(DsEnsambleImpresion1.dsdtEnsambleHijos.TableName.ToString).Clear()

            If grdviewEnsamblePadres.RowCount = Nothing Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtProduccionHijos")
            Dim pCodigoPadre As String = mFunciones.FCN_GetCellValue(grdviewEnsamblePadres, "CodigoArticulo")

            If pCodigoPadre = String.Empty Then
                'DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionHijos.TableName.ToString).Clear()
                Exit Sub
            End If
            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Ensamble_Ordenes_Hijos] AR," + pCodigoPadre.ToString)
            If dt.Rows.Count = Nothing Then
                'DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtProduccionHijos.TableName.ToString).Clear()
                Exit Sub
            End If

            DsEnsambleImpresion1.Tables(DsEnsambleImpresion1.dsdtEnsambleHijos.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Fill_Ensambles_Ordenes()
        Try
            If grdviewEnsambleHijos.RowCount = Nothing Then
                Exit Sub
            End If

            Dim dt As New DataTable("dtEnsambleOrdenes")
            Dim pCodigoArticulo As String = mFunciones.FCN_GetCellValue(grdviewEnsambleHijos, "CodigoArticulo")

            If pCodigoArticulo = String.Empty Then
                DsEnsambleImpresion1.Tables(DsEnsambleImpresion1.dsdtEnsambleOrdenes.TableName.ToString).Clear()
                Exit Sub
            End If

            dt = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Ensamble_Ordenes_Ordenes] AR, EE, '" + pCodigoArticulo.ToString + "'")

            If dt.Rows.Count = Nothing Then
                DsEnsambleImpresion1.Tables(DsEnsambleImpresion1.dsdtEnsambleOrdenes.TableName.ToString).Clear()
                Exit Sub
            End If

            DsEnsambleImpresion1.Tables(DsEnsambleImpresion1.dsdtEnsambleOrdenes.TableName.ToString).Clear()
            DsEnsambleImpresion1.Tables(DsEnsambleImpresion1.dsdtEnsambleOrdenes.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub grdviewEnsamblePadres_ColumnFilterChanged(sender As Object, e As EventArgs) Handles grdviewEnsamblePadres.ColumnFilterChanged
        Try
            Fill_Ensambles_Hijos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdviewEnsambleHijos_ColumnFilterChanged(sender As Object, e As EventArgs) Handles grdviewEnsambleHijos.ColumnFilterChanged
        Try
            Fill_Ensambles_Ordenes()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewEnsambleHijos_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewEnsambleHijos.FocusedRowChanged
        Try
            Fill_Ensambles_Ordenes()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub




    Private Sub grdviewEnsamblePadres_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewEnsamblePadres.FocusedRowChanged
        Try
            Fill_Ensambles_Hijos()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewEnsambleHijos_DoubleClick(sender As Object, e As EventArgs) Handles grdviewEnsambleHijos.DoubleClick
        Try
            Fill_Ensambles_Ordenes()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirEnsamble_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirEnsamble.ItemClick
        Try
            FC_ImprimirEnsamble()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FC_ImprimirEnsamble()
        Try
            'VALIDAR QUE TENGA DATOS CORRECTOS
            If grdviewEnsamblePadres.FocusedRowHandle < 0 Then
                Exit Sub
            End If
            If grdviewEnsamblePadres.RowCount = Nothing Then
                Exit Sub
            End If

            'CALL FORM CON VISTA PREVIA
            frmEnsambleOrdenImpresion.mmCodigoArticulo = grdviewEnsamblePadres.GetRowCellValue(grdviewEnsamblePadres.FocusedRowHandle, "CodigoArticulo")
            frmEnsambleOrdenImpresion.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmEnsambleImpresion_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            Sub_CentrarSplit()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_CentrarSplit()
        Try
            Dim pPosicion As Integer = Val(Me.Size.Width - 50) / 2
            SplitContainerControl1.SplitterPosition = pPosicion
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewEnsambleHijos, grdviewEnsamblePadres, grdviewEnsambleOrdenes)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_ImprimirGrid(grdviewEnsambleHijos, grdviewEnsamblePadres, grdviewEnsambleOrdenes)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarGrid.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_ExportarExcel(grdviewEnsambleHijos, grdviewEnsamblePadres, grdviewEnsambleOrdenes, sfdSave)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            frmReciboProduccionEnsamble.Text = "Recibos de Produccion y Ensamble"
            frmReciboProduccionEnsamble.StartPosition = FormStartPosition.CenterScreen
            frmReciboProduccionEnsamble.vpCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewEnsamblePadres, "CodigoArticulo")
            frmReciboProduccionEnsamble.ShowDialog(Me)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnActualizarDatos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnActualizarDatos.ItemClick
        Try
            Fill_Ensambles_Padres()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class