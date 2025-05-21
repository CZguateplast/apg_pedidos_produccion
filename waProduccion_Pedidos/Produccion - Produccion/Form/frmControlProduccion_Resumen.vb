Public Class frmControlProduccion_Resumen

    Private mProducciones As DataTable
    Private mEnsambles As DataTable
    Private mMaquina As String
    Private mCodigoPadre As String

    Public Property ppdtProducciones() As DataTable
        Get
            Return mProducciones
        End Get
        Set(ByVal Value As DataTable)
            mProducciones = Value
        End Set
    End Property
    Public Property ppdtEnsambles() As DataTable
        Get
            Return mEnsambles
        End Get
        Set(ByVal Value As DataTable)
            mEnsambles = Value
        End Set
    End Property
    Public Property ppMaquina() As String
        Get
            Return mMaquina
        End Get
        Set(ByVal Value As String)
            mMaquina = Value
        End Set
    End Property
    Public Property ppCodigoPadre() As String
        Get
            Return mCodigoPadre
        End Get
        Set(ByVal Value As String)
            mCodigoPadre = Value
        End Set
    End Property

    Private Sub frmControlProduccion_Resumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'CARGAR PRODUCCIONES
            Dim pNumProduccion As String = String.Empty
            Dim dtProduccion As New DataTable()

            pNumProduccion = mFunciones.FCN_GET_Columna(mProducciones, "SAP")

            DsControlProduccion_Resumen1.Tables(DsControlProduccion_Resumen1.dsdtProduccion.TableName.ToString).Clear()

            If Not pNumProduccion = Nothing Then
                dtProduccion = mSQLSelect.GET_Recibos_ControlProduccion(pNumProduccion)
                For i = 0 To dtProduccion.Rows.Count - 1
                    Dim pNumeroSAP As String = String.Empty
                    pNumeroSAP = dtProduccion.Rows(i)("SAP").ToString
                    For j = 0 To mProducciones.Rows.Count - 1
                        If pNumeroSAP = mProducciones.Rows(j)("SAP") Then
                            dtProduccion.Rows(i)("Cargar") = mProducciones.Rows(j)("Cargar")
                            dtProduccion.Rows(i)("Comentarios") = mProducciones.Rows(j)("Comentarios")
                        End If
                    Next
                Next
                DsControlProduccion_Resumen1.Tables(DsControlProduccion_Resumen1.dsdtProduccion.TableName.ToString).Merge(dtProduccion)
            End If

            'CARGAR ENSAMBLES
            Dim pNumEnsamble As String = String.Empty
            Dim dtEnsambles As New DataTable()

            pNumEnsamble = mFunciones.FCN_GET_Columna(mEnsambles, "SAP")


            DsControlProduccion_Resumen1.Tables(DsControlProduccion_Resumen1.dsdtEnsambles.TableName.ToString).Clear()

            If Not pNumEnsamble = Nothing Then
                dtEnsambles = mSQLSelect.GET_Recibos_ControlProduccion(pNumEnsamble)

                For i = 0 To dtEnsambles.Rows.Count - 1
                    Dim pNumeroSAP As String = String.Empty
                    pNumeroSAP = dtEnsambles.Rows(i)("SAP").ToString
                    For j = 0 To mEnsambles.Rows.Count - 1
                        If pNumeroSAP = mEnsambles.Rows(j)("SAP") Then
                            dtEnsambles.Rows(i)("Cargar") = mEnsambles.Rows(j)("Cargar")
                            dtEnsambles.Rows(i)("Comentarios") = mEnsambles.Rows(j)("Comentarios")
                        End If
                    Next
                Next
                DsControlProduccion_Resumen1.Tables(DsControlProduccion_Resumen1.dsdtEnsambles.TableName.ToString).Merge(dtEnsambles)
            End If



            mFunciones.FCN_FILL_SearchLookUpEdit(slueTurno, mSQLSelect.GET_Listado("Tipo_Turno"), "Id", "Nombre")




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEditarOrden_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEditarOrden.ItemClick
        Try
            Dim pNumSAP As String = String.Empty

            If grdviewProducciones.IsFocusedView Then
                pNumSAP = mFunciones.FCN_GetCellValue(grdviewProducciones, "SAP")
            ElseIf grdviewEnsambles.IsFocusedView Then
                pNumSAP = mFunciones.FCN_GetCellValue(grdviewEnsambles, "SAP")
            End If


            frmOrdenProduccionEnsamble.ppTipo = "Buscar"
            frmOrdenProduccionEnsamble.ppNumSAP = pNumSAP
            frmOrdenProduccionEnsamble.ShowDialog(Me)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub barbtnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabar.ItemClick
        Try
            ''------------------------------------
            ''TABLA PROD_Trabajo_Maquina----------
            ''------------------------------------
            Dim dtTrabajo_Maquina As New DataTable()
            dtTrabajo_Maquina = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.spPROD_Trabajo_Maquina '" + ppMaquina + "','" + ppCodigoPadre + "'")

            If dtTrabajo_Maquina.Rows.Count = Nothing Then
                mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.spPROD_Trabajo_Maquina_Inicio '" + ppMaquina + "','" + ppCodigoPadre + "','" + mFunciones.ConvertirFechaSQL(dteInicioTrabajo) + "','" + My.Settings.log_Usuario + "'")
            End If



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class