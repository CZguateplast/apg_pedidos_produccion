Imports System.Threading
Imports DevExpress.XtraSplashScreen
Public Class frmCargarDatosProduccion

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCargarPlantilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCargarPlantilla.ItemClick
        Try
            Dim pRuta As String = String.Empty
            ofdOpen.FileName = Nothing
            ofdOpen.Title = "Abrir Archivo"
            ofdOpen.Filter = "Archivos Excel | *.xlsx; *.xls"
            If ofdOpen.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pRuta = ofdOpen.FileName.ToString
            Else
                Exit Sub
            End If

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            'Dim DtSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim dt As New DataTable()
            MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + pRuta + "'; Extended Properties=Excel 12.0 xml;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Plantilla$]", MyConnection)
            'MyCommand.TableMappings.Add("Table", "TestTable")
            'DtSet = New System.Data.DataSet
            MyCommand.Fill(dt)
            MyConnection.Close()

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsCargarDatosProduccion1.Tables(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.TableName.ToString).Clear()
            DsCargarDatosProduccion1.Tables(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.TableName.ToString).Merge(dt)



            FC_CalcularDatosProduccion()

            txtTotalCodigos.EditValue = grdviewDatos.RowCount
            FC_Conteo_Articulos()

            'txtTotalAgregar.EditValue = Val(txtTotalCodigos.EditValue) - Val(txtTotalActualizar.EditValue)


            'DataGridView1.DataSource = DtSet.Tables(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub barbtnEliminarLinea_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminarLinea.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_EliminarFilasSeleccionadas(grdviewDatos)
            DsCargarDatosProduccion1.dsdtCargarDatosProduccion.AcceptChanges()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Function FC_CalcularDatosProduccion() As Boolean
        Try
            
            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If

            ssmEsperar.SetWaitFormDescription("   ***** Proceso Iniciado *****   ")
            Application.DoEvents()

            For i = 0 To DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows.Count - 1
                DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionHora") = FC_Unidades_A_Inyecciones(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("UnidadesHora"), DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("CavidadesMolde"))
                DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionGrms") = DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("PesoGramos")
                DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionVariacion") = FC_InyeccionVariacion(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("PesoGramos"), DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("NumeroMaquina"))
                DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Estado") = mSQLSelect.GET_ValidarCodigo_paraActualizar(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Codigo"), DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("CodigoMolde")).Rows(0)(0)
                Application.DoEvents()
                ssmEsperar.SetWaitFormDescription("Calculando " + DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Codigo").ToString)
                Application.DoEvents()
            Next
            ssmEsperar.SetWaitFormDescription("** Proceso Finalizado **")
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
            Return True
        Catch ex As Exception
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        Finally
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        End Try

    End Function


    Private Function FC_Unidades_A_Inyecciones(ByVal pUnidades As String, ByVal pCavidades As String) As Integer
        Try
            Dim pResultado As Integer
            If pCavidades < 1 Then
                pCavidades = 1
            End If
            pResultado = Val(pUnidades) / Val(pCavidades)

            Return pResultado
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Private Function FC_InyeccionVariacion(ByVal pInyeccionGramos As String, ByVal pMaquina As String) As Decimal
        Try
            Dim pResultado As Decimal = 0
            Dim pPorcentaje As Decimal = 0

            pPorcentaje = mSQLSelect.GET_PorcentajeInyeccionVariacion(pMaquina).Rows(0)(0)
            If pPorcentaje = Nothing Then
                Return 0
            End If

            pResultado = (pInyeccionGramos * pPorcentaje) / 100
            pResultado = Math.Round(pResultado, 1)

            Return pResultado
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return Nothing
        End Try

    End Function

    



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        ' Do some time-consuming work on this thread.
        System.Threading.Thread.Sleep(1000)
    End Sub

    Private Sub barbtnDescargarPlantilla_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDescargarPlantilla.ItemClick
        Try

            If sfdSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(Application.StartupPath.ToString + "\Plntll\Plantilla_CargaDatosCP.xlsx",
                                                sfdSave.FileName + ".xlsx",
                                                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                                                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

                mMensajes.msg_Informacion("Archivo Descargado en ." + Environment.NewLine + sfdSave.FileName + ".xlsx")
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub rdgTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rdgTipo.SelectedIndexChanged
        Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FC_Conteo_Articulos()
        Try
            Dim pCodigo As String
            Dim pResultadoActualizar As Integer
            Dim pResultadoInsertar As Integer
            Dim pResultadoCP As Integer
            Dim pResultadoMolde As Integer

            pResultadoActualizar = 0
            pResultadoInsertar = 0
            pResultadoCP = 0
            pResultadoMolde = 0


            For i = 0 To grdviewDatos.RowCount - 1

                pCodigo = grdviewDatos.GetRowCellValue(i, "Estado")
                Select Case pCodigo
                    Case "Actualizar"
                        pResultadoActualizar = pResultadoActualizar + 1
                    Case "Insertar"
                        pResultadoInsertar = pResultadoInsertar + 1
                    Case "CP No existe en DB"
                        pResultadoCP = pResultadoCP + 1
                    Case "Molde NO existe en DB"
                        pResultadoMolde = pResultadoMolde + 1
                End Select
            Next

            txtTotalActualizar.EditValue = pResultadoActualizar
            txtTotalAgregar.EditValue = pResultadoInsertar
            txtErrorCP.EditValue = pResultadoCP
            txtErrorMolde.EditValue = pResultadoMolde


            'pResultado = mSQLSelect.GET_CargaProduccion_Existentes(mFunciones.FCN_GetColumn(grdviewDatos, "Codigo")).Rows(0)(0)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            'DECLARAR CONTROLES
            Dim pRegistrosBuenos As Integer = 0
            Dim pRegistrosMalos As Integer = 0

            'LIMPIA CONTROLES
            memoError.EditValue = Nothing

            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If


            If rdgTipo.EditValue = 0 Then
                ssmEsperar.SetWaitFormCaption("Actualizando...")
                'ACTUALIZAR-------------------------
                For i = 0 To grdviewDatos.RowCount - 1
                    If DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Estado").ToString = "Actualizar" Then

                        'MENSAJE SPLASH
                        ssmEsperar.SetWaitFormDescription(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Codigo").ToString)

                        If GET_CargaProduccion_ExistenteCodigo(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Codigo").ToString) Then
                            'SI EXISTE EL CODIGO HACE LA ACTUALIZACION
                            If chkInyeccionGramos.Checked = True And chkInyeccionVariacion.Checked = True And chkInyeccionHora.Checked = True Then
                                'ACTUALIZAR TODO
                                mSQLUpdate.UPDATE_CargaProduccion_Todo(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Codigo").ToString, _
                                                                       DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionGrms"), _
                                                                       DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionVariacion"), _
                                                                       DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionHora").ToString)
                            Else
                                'GRAMOS
                                If chkInyeccionGramos.Checked Then
                                    mSQLUpdate.UPDATE_CargaProduccion_InyeccionGramos(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Codigo").ToString, _
                                                                       DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionGrms"))
                                End If

                                'VARIACION
                                If chkInyeccionVariacion.Checked Then
                                    mSQLUpdate.UPDATE_CargaProduccion_InyeccionVariacion(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Codigo").ToString, _
                                                                       DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionVariacion"))
                                End If

                                'HORA
                                If chkInyeccionHora.Checked Then
                                    mSQLUpdate.UPDATE_CargaProduccion_InyeccionHora(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Codigo").ToString, _
                                                                       DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionHora").ToString)
                                End If
                            End If
                        End If
                        pRegistrosBuenos = pRegistrosBuenos + 1
                    End If



                Next
                If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
                MsgBox("Registros Recorridos: " + pRegistrosBuenos.ToString, MsgBoxStyle.OkOnly)
            Else
                Dim pError As String = Nothing
                ssmEsperar.SetWaitFormCaption("Insertando...")
                'INSERTAR --------------------------
                For i = 0 To grdviewDatos.RowCount - 1
                    If DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Estado").ToString = "Insertar" Then


                        'MENSAJE SPLASH
                        ssmEsperar.SetWaitFormDescription(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Codigo").ToString)

                        If Not mSQLInsert.SET_CargaProduccion_(DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("Codigo").ToString, _
                                                        DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionGrms"), _
                                                                       DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionVariacion"), _
                                                                       DsCargarDatosProduccion1.dsdtCargarDatosProduccion.Rows(i)("InyeccionHora").ToString, pError) Then
                            memoError.EditValue = memoError.EditValue + Environment.NewLine + pError
                            pRegistrosMalos = pRegistrosMalos + 1
                        Else
                            pRegistrosBuenos = pRegistrosBuenos + 1
                        End If
                    End If

                Next

                If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If

                MsgBox("Registros Buenos: " + pRegistrosBuenos.ToString + Environment.NewLine + _
                       "Registros Malos: " + pRegistrosMalos.ToString, MsgBoxStyle.OkOnly)

            End If


        Catch ex As Exception
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewDatos)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_ImprimirGrid(grdviewDatos)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try

            mFunciones.FCN_XTRAGRID_ExportarExcel(grdviewDatos, sfdSave)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class