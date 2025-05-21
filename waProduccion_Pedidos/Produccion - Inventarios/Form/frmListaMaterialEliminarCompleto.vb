Imports System.Threading
Imports DevExpress.XtraSplashScreen
Public Class frmListaMaterialEliminarCompleto

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAplicar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAplicar.ItemClick
        Try

            splashEsperar.ShowWaitForm()

            splashEsperar.SetWaitFormDescription("   ***** Proceso Iniciado *****   ")

            Dim pCodigo As String = String.Empty
            For I = 0 To grdviewListaMateriales.RowCount - 1
                pCodigo = mFunciones.FCN_GetCellValue(grdviewListaMateriales, "CodigoArticulo", I)
                splashEsperar.SetWaitFormDescription(pCodigo)
                If SAP_DIAPI_ListaMateriales_EliminarItem(pCodigo) Then
                    splashEsperar.SetWaitFormDescription(pCodigo + "  OK...")
                Else
                    splashEsperar.SetWaitFormDescription(pCodigo + "  Error...")
                End If
            Next
            Thread.Sleep(25)
            splashEsperar.SetWaitFormDescription("    ***** Proceso Finalizado *****   ")

            If splashEsperar.IsSplashFormVisible() Then : splashEsperar.CloseWaitForm() : End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAbrirExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAbrirExcel.ItemClick
        Try
            Try

                Dim pRuta As String = String.Empty


                ofdAbrir.FileName = Nothing
                ofdAbrir.Title = "Abrir Archivo"
                ofdAbrir.Filter = "Archivos Excel | *.xlsx; *.xls"
                If ofdAbrir.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pRuta = ofdAbrir.FileName.ToString
                Else
                    Exit Sub
                End If

                Dim MyConnection As System.Data.OleDb.OleDbConnection
                Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
                Dim dt As New DataTable()
                MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + pRuta + "'; Extended Properties=Excel 12.0 xml;")
                MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Plantilla$]", MyConnection)
                MyCommand.Fill(dt)
                MyConnection.Close()

                If dt.Rows.Count = Nothing Then
                    Exit Sub
                End If

                If grdviewListaMateriales.RowCount = Nothing Then

                Else
                    If MsgBox("Desea borrar los Articulos que actualmente estan en la Lista?", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then
                        DsListaMaterialEliminarCompleto1.Tables(DsListaMaterialEliminarCompleto1.dsdtListaMaterialEliminarCompleto.TableName.ToString).Clear()
                    End If
                End If

                DsListaMaterialEliminarCompleto1.Tables(DsListaMaterialEliminarCompleto1.dsdtListaMaterialEliminarCompleto.TableName.ToString).Merge(dt)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewListaMateriales_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewListaMateriales.FocusedRowChanged
        Try
            If e.FocusedRowHandle < 0 Then
                colCodigoArticulo.OptionsColumn.AllowEdit = True
            Else
                colCodigoArticulo.OptionsColumn.AllowEdit = False
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnDescargarPlantilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDescargarPlantilla.ItemClick
        Try

            If sfdSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(Application.StartupPath.ToString + "\Plntll\Plantilla_ListaMateriales_Borrar.xlsx",
                                                sfdSave.FileName + ".xlsx",
                                                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                                                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

                mMensajes.msg_Informacion("Archivo Descargado en ." + Environment.NewLine + sfdSave.FileName + ".xlsx")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class