Public Class frmTemporal_ParametrosDefault

    Private pTipo As String




    Private Sub barbtnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSalir.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAceptar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If MsgBox("Desea < GRABAR > los cambios?", MsgBoxStyle.YesNo, "Grabar...") = MsgBoxResult.Yes Then

            Else

            End If


            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmTemporal_ParametrosDefault_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Me.Controls.Clear()
            Me.InitializeComponent()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmTemporal_ParametrosDefault_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pTipo = String.Empty
            pTipo = slueTipo.EditValue = Nothing
            FCN_Fill_Tipo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub FCN_Fill_Tipo()

        Dim dt As New DataTable()
        dt = mSQLSelect.GET_Listado("ParametrosDefault")

        mFunciones.FCN_FILL_SearchLookUpEdit(slueTipo, dt, "Id", "Descripcion")

    End Sub

    
    Private Sub slueTipo_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueTipo.EditValueChanging
        Try

            DsTemporal_ParametrosDefault1.Tables(DsTemporal_ParametrosDefault1.dsdtListaDisponible.TableName.ToString).Clear()
            DsTemporal_ParametrosDefault1.Tables(DsTemporal_ParametrosDefault1.dsdtListaGrabada.TableName.ToString).Clear()

            Select e.NewValue
                Case "1"
                    pTipo = "ParametrosDefault_Campanas"

                    Dim dtCampanasVigentes As New DataTable()
                    dtCampanasVigentes = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[ParametrosDefault_CampanasVigentes]" _
                                                                 + My.Settings.log_Usuario.ToString + "," _
                                                                 + My.Application.Info.Title.ToString + _
                                                                 "," + pTipo)



                    'LLENAR GRID CAMPANAS DISPONIBLES
                    If Not dtCampanasVigentes.Rows.Count = Nothing Then
                        DsTemporal_ParametrosDefault1.Tables(DsTemporal_ParametrosDefault1.dsdtListaDisponible.TableName.ToString).Merge(dtCampanasVigentes)
                    End If

                    'LLENAR GRID CAMPANAS GRABADAS
                    Dim dtCampanasGrabadas As New DataTable()
                    dtCampanasGrabadas = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[ParametrosDefault_CampanasGrabadas]" _
                                                                    + My.Settings.log_Usuario.ToString + "," _
                                                                    + My.Application.Info.Title.ToString + _
                                                                    "," + pTipo)
                    If Not dtCampanasGrabadas.Rows.Count = Nothing Then
                        DsTemporal_ParametrosDefault1.Tables(DsTemporal_ParametrosDefault1.dsdtListaGrabada.TableName.ToString).Merge(dtCampanasGrabadas)
                    End If




                Case "2"
                    pTipo = "ParametrosDefault_Campanas"

                    Dim dtTodasCampanas As New DataTable()
                    dtTodasCampanas = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[ParametrosDefault_TodasCampanas]" _
                                                                 + My.Settings.log_Usuario.ToString + "," _
                                                                 + My.Application.Info.Title.ToString + _
                                                                 "," + pTipo)



                    'LLENAR GRID CAMPANAS DISPONIBLES
                    If Not dtTodasCampanas.Rows.Count = Nothing Then
                        DsTemporal_ParametrosDefault1.Tables(DsTemporal_ParametrosDefault1.dsdtListaDisponible.TableName.ToString).Merge(dtTodasCampanas)
                    End If

                    'LLENAR GRID CAMPANAS GRABADAS
                    Dim dtCampanasGrabadas As New DataTable()
                    dtCampanasGrabadas = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[ParametrosDefault_CampanasGrabadas]" _
                                                                    + My.Settings.log_Usuario.ToString + "," _
                                                                    + My.Application.Info.Title.ToString + _
                                                                    "," + pTipo)
                    If Not dtCampanasGrabadas.Rows.Count = Nothing Then
                        DsTemporal_ParametrosDefault1.Tables(DsTemporal_ParametrosDefault1.dsdtListaGrabada.TableName.ToString).Merge(dtCampanasGrabadas)
                    End If

                    


                Case "3"

                    pTipo = "ParametrosDefault_OrdenesVenta_Abiertas"

                    Dim dtOrdenesVenta As New DataTable()
                    dtOrdenesVenta = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[ParametrosDefault_OrdenesVenta_Abiertas]")



                    'LLENAR GRID CAMPANAS DISPONIBLES
                    If Not dtOrdenesVenta.Rows.Count = Nothing Then
                        DsTemporal_ParametrosDefault1.Tables(DsTemporal_ParametrosDefault1.dsdtListaDisponible.TableName.ToString).Merge(dtOrdenesVenta)
                    End If

                    'LLENAR GRID CAMPANAS GRABADAS
                    Dim dtCampanasGrabadas As New DataTable()
                    dtCampanasGrabadas = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[ParametrosDefault_CampanasGrabadas]" _
                                                                    + My.Settings.log_Usuario.ToString + "," _
                                                                    + My.Application.Info.Title.ToString + _
                                                                    "," + pTipo)
                    If Not dtCampanasGrabadas.Rows.Count = Nothing Then
                        DsTemporal_ParametrosDefault1.Tables(DsTemporal_ParametrosDefault1.dsdtListaGrabada.TableName.ToString).Merge(dtCampanasGrabadas)
                    End If






            End Select







        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            fcn_barbtnAgregar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub fcn_barbtnAgregar()
        Try
            If grdviewListaDisponible.SelectedRowsCount = Nothing Then
                mMensajes.msg_Informacion("Seleciones una linea valida...")
                Exit Sub
            End If

            Dim pIdDisponible As String = String.Empty
            Dim pDescripcionDisponible As String = String.Empty

            pIdDisponible = mFunciones.FCN_GetCellValue(grdviewListaDisponible, "Id")
            pDescripcionDisponible = mFunciones.FCN_GetCellValue(grdviewListaDisponible, "Descripcion")

            mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[ParametrosDefault_Insert]" _
                                       + My.Settings.log_Usuario.ToString + "," _
                                       + My.Application.Info.Title.ToString _
                                       + "," + pTipo _
                                       + ", '" + pIdDisponible + _
                                       "','" + pDescripcionDisponible + "'")


            'AGREGAR LA LINEA A LA LISTA GRABADA
            DsTemporal_ParametrosDefault1.dsdtListaGrabada.Rows.Add(pIdDisponible, pDescripcionDisponible)
            'ELIMINAR LINEA SELECCIONADA
            grdviewListaDisponible.DeleteSelectedRows()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnQuitar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnQuitar.ItemClick
        Try
            fcn_barbtnQuitar()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub fcn_barbtnQuitar()
        Try

            If grdviewListaGrabada.SelectedRowsCount = Nothing Then
                mMensajes.msg_Informacion("Seleciones una linea valida...")
                Exit Sub
            End If

            Dim pIdGrabada As String = String.Empty
            Dim pDescripcionGrabada As String = String.Empty

            pIdGrabada = mFunciones.FCN_GetCellValue(grdviewListaGrabada, "Id")
            pDescripcionGrabada = mFunciones.FCN_GetCellValue(grdviewListaGrabada, "Descripcion")

            'ELIMINAR LA LINEA DE LA BASE DE DATOS
            mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[ParametrosDefault_Delete]" _
                                       + My.Settings.log_Usuario.ToString + "," _
                                       + My.Application.Info.Title.ToString _
                                       + "," + pTipo _
                                       + ", '" + pIdGrabada + "'")


            'AGREGAR LA LINEA A LA LISTA DISPONIBLE
            DsTemporal_ParametrosDefault1.dsdtListaDisponible.Rows.Add(pIdGrabada, pDescripcionGrabada)
            grdviewListaDisponible.Columns("Id").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

            'ELIMINAR LINEA SELECCIONADA
            grdviewListaGrabada.DeleteSelectedRows()


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewListaDisponible_DoubleClick(sender As Object, e As EventArgs) Handles grdviewListaDisponible.DoubleClick
        Try
            fcn_barbtnAgregar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewListaGrabada_DoubleClick(sender As Object, e As EventArgs) Handles grdviewListaGrabada.DoubleClick
        Try
            fcn_barbtnQuitar()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdListaDisponible_Enter(sender As Object, e As EventArgs) Handles grdListaDisponible.Enter
        Try
            barbtnAgregar.Enabled = True
            barbtnQuitar.Enabled = False

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdListaGrabada_Enter(sender As Object, e As EventArgs) Handles grdListaGrabada.Enter
        Try
            barbtnAgregar.Enabled = False
            barbtnQuitar.Enabled = True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class