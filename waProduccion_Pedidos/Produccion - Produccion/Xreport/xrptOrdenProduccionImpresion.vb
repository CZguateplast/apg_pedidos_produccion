Imports DevExpress.XtraPrinting
Imports System
Imports DevExpress.XtraReports.UI

Public Class xrptOrdenProduccionImpresion
    Private Sub xrptOrdenProduccionImpresion_AfterPrint(sender As Object, e As EventArgs) Handles MyBase.AfterPrint
        Try
            DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionListaMateriales.TableName.ToString).Clear()
            DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionOrdenes.TableName.ToString).Clear()

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
                DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionOrdenes.TableName.ToString).Clear()
                DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionOrdenes.TableName.ToString).Merge(dtImpresionOrdenes)
            End If

            Dim pLista As String = mFunciones.FCN_GET_Columna(dtImpresionOrdenes, "NumeroSAP")
            Dim dtOrdenesSAP As New DataTable()

            dtOrdenesSAP = mSQLSelect.GET_Fill_EnsambleProduccion_ConListaExcluir(vpCodigoArticulo, pLista)
            If Not dtOrdenesSAP.Rows.Count = Nothing Then
                DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtImpresionOrdenes.TableName.ToString).Merge(dtOrdenesSAP)
            End If


            Dim RPTdocumento2 As DevExpress.XtraReports.UI.XtraReport = New xrptOrdenProduccionImpresionResumen

            RPTdocumento2.DataSource = Me.DsOrdenProduccionImpresion1
            RPTdocumento2.DataMember = DsOrdenProduccionImpresion1.dsdtImpresionOrdenes.TableName.ToString
            RPTdocumento2.Parameters("pUsuario").Value = My.Settings.log_Usuario.ToString
            RPTdocumento2.CreateDocument()

            Dim pages As PageList = RPTdocumento2.PrintingSystem.Document.Pages
            Me.Pages.AddRange(pages)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub XrSubreportOrdenProduccionComentarios_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrSubreportOrdenProduccionComentarios.BeforePrint
        Try
            ' Validar si el ReportSource está instanciado
            Dim subReport = CType(sender, DevExpress.XtraReports.UI.XRSubreport)

            If subReport.ReportSource Is Nothing Then
                ' Si no está instanciado, creamos una nueva instancia
                subReport.ReportSource = New xrptOrdenProduccionComentarios()
            End If

            ' Asignar valores a los parámetros
            CType(subReport.ReportSource, xrptOrdenProduccionComentarios).pCodigoArticulo.Value = Convert.ToString(GetCurrentColumnValue("CodigoArticulo"))
            CType(subReport.ReportSource, xrptOrdenProduccionComentarios).pTipoOrden.Value = Convert.ToString(GetCurrentColumnValue("TipoOrden"))

        Catch ex As Exception
            ' Manejo de errores
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub XrSubreport1_BeforePrint_1(sender As Object, e As Printing.PrintEventArgs)
        Try
            'PARAMETROS DE MATERIALES
            Dim dtMateriales As New DataTable("dtImpresionorden")
            dtMateriales = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.Material_Porcentaje '" + vpCodigoArticulo + "'")
            If Not dtMateriales.Rows.Count = Nothing Then
                DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtMateriales.TableName.ToString).Clear()
                DsOrdenProduccionImpresion1.Tables(DsOrdenProduccionImpresion1.dsdtMateriales.TableName.ToString).Merge(dtMateriales)
            End If


            CType((CType(sender, XRSubreport)).ReportSource, xrptOrdenesProduccionImpresionMateriales).Father.Value = Convert.ToString(GetCurrentColumnValue("Father"))


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class