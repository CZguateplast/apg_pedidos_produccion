Imports DevExpress.XtraPrinting
Imports System
Imports DevExpress.XtraReports.UI

Public Class xrptEnsambleResumen

    Private Sub xrptEnsambleResumen_AfterPrint(sender As Object, e As EventArgs) Handles Me.AfterPrint
        Try
            'DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionListaMateriales.TableName.ToString).Clear()
            DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtOrdenesXHijo.TableName.ToString).Clear()

            If vpBoolean = False Then
                Exit Sub
            End If
            Dim dtImpresionOrdenes As New DataTable("dtImpresionOrdenes")

            'dtImpresionOrdenes = mSQLSelect.GET_Impresion_ParametrosOrdenes(vpCodigoArticulo)

            dtImpresionOrdenes = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[OrdenesProduccionEnsamble_XPadre] " + vpCodigoArticulo.ToString + "," + vpTipoOrden.ToString)

            Dim pIndex As Integer = 0


            For i = 0 To dtImpresionOrdenes.Rows.Count - 1
                If i = 0 Then
                    dtImpresionOrdenes.Rows(i)("Id_Nivel2") = pIndex
                Else
                    If dtImpresionOrdenes.Rows(i)("Tipo") = "PRODUCCION" Then
                        If Not dtImpresionOrdenes.Rows(i)("CodigoArticulo") = dtImpresionOrdenes.Rows(i - 1)("CodigoArticulo") Then
                            pIndex = pIndex + 1
                        End If
                    Else
                        pIndex = pIndex + 1
                    End If
                    dtImpresionOrdenes.Rows(i)("Id_Nivel2") = pIndex
                End If
            Next



            If Not dtImpresionOrdenes.Rows.Count = Nothing Then
                DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtOrdenesXHijo.TableName.ToString).Clear()
                DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtOrdenesXHijo.TableName.ToString).Merge(dtImpresionOrdenes)
            End If

            Dim pLista As String = mFunciones.FCN_GET_Columna(dtImpresionOrdenes, "NumeroSAP")
            Dim dtOrdenesSAP As New DataTable()

            dtOrdenesSAP = mSQLSelect.GET_Fill_EnsambleProduccion_ConListaExcluir(vpCodigoArticulo, pLista)
            If Not dtOrdenesSAP.Rows.Count = Nothing Then
                DsEnsambleOrdenImpresion1.Tables(DsEnsambleOrdenImpresion1.dsdtOrdenesXHijo.TableName.ToString).Merge(dtOrdenesSAP)
            End If


            Dim RPTdocumento2 As DevExpress.XtraReports.UI.XtraReport = New xrptEnsambleDetalle

            RPTdocumento2.DataSource = Me.DsEnsambleOrdenImpresion1
            RPTdocumento2.DataMember = DsEnsambleOrdenImpresion1.dsdtOrdenesXHijo.TableName.ToString
            RPTdocumento2.Parameters("pUsuario").Value = My.Settings.log_Usuario.ToString
            RPTdocumento2.CreateDocument()

            Dim pages As PageList = RPTdocumento2.PrintingSystem.Document.Pages
            Me.Pages.AddRange(pages)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class