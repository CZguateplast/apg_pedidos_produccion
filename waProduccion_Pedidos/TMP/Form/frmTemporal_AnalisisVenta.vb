Imports DevExpress.XtraCharts
Imports DevExpress.Charts.Native.SimpleDiagramPanel
Imports DevExpress.Charts.Native.DateTimeMeasureUnitNative
Imports System.DateTime




Public Class frmTemporal_AnalisisVenta

    Private pCodigoArticulo As String

    Public Property ppCodigoArticulo() As String
        Get
            Return pCodigoArticulo
        End Get
        Set(ByVal Value As String)

            pCodigoArticulo = Value
        End Set
    End Property

    Private Sub frmTemporal_AnalisisVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable
            dt = mSQLSelect.GET_Temporal_AnalisisVenta("'" + pCodigoArticulo + "'")
            If Not dt.Rows.Count = Nothing Then
                txtCodigoArticulo.EditValue = dt.Rows(0)("ItemCode").ToString
                txtNombreArticulo.EditValue = dt.Rows(0)("ItemName").ToString
                txtDeLinea.EditValue = dt.Rows(0)("TIPO_ART").ToString
                txtU01.EditValue = dt.Rows(0)("U_01").ToString
                txtU02.EditValue = dt.Rows(0)("U_02").ToString
                txtU03.EditValue = dt.Rows(0)("U_03").ToString
                txtU04.EditValue = dt.Rows(0)("U_04").ToString
                txtU05.EditValue = dt.Rows(0)("U_05").ToString
                txtU06.EditValue = dt.Rows(0)("U_06").ToString
                txtU07.EditValue = dt.Rows(0)("U_07").ToString
                txtU08.EditValue = dt.Rows(0)("U_08").ToString
                txtU09.EditValue = dt.Rows(0)("U_09").ToString
                txtU10.EditValue = dt.Rows(0)("U_10").ToString
                txtU11.EditValue = dt.Rows(0)("U_11").ToString
                txtU12.EditValue = dt.Rows(0)("U_12").ToString
                txtU13.EditValue = dt.Rows(0)("U_13").ToString
                txtU14.EditValue = dt.Rows(0)("U_14").ToString
                txtU15.EditValue = dt.Rows(0)("U_15").ToString
                txtTotalUnidadesVendidas.EditValue = dt.Rows(0)("TOT_UV").ToString

                txtStock.EditValue = dt.Rows(0)("STOCK").ToString
                txtMaximo.EditValue = dt.Rows(0)("STOCK_MAX").ToString
                txtMinimo.EditValue = dt.Rows(0)("STOCK_MIN").ToString
                txtMaximoUnidadesVendidas.EditValue = dt.Rows(0)("MUVM").ToString
                txtMesesConMovimiento.EditValue = dt.Rows(0)("M_CMOV").ToString
                txtPromedioCompuesto.EditValue = dt.Rows(0)("MOV_PROM_COMP").ToString
                txtPromedioSimple.EditValue = dt.Rows(0)("MOV_PROM_SIMP").ToString
                txtMesesCompuesto.EditValue = dt.Rows(0)("MI_PC").ToString
                txtMesesSimple.EditValue = dt.Rows(0)("MI_PS").ToString
                txt3MesesSuma.EditValue = dt.Rows(0)("SumProy3M").ToString
                txt3MesesPromedio.EditValue = dt.Rows(0)("ProProy3M").ToString

                DsAnalisisVenta.Tables("dsdtAnalisisVenta").Clear() 'Borrar DataSet
                DsAnalisisVenta.Tables("dsdtAnalisisVenta").Merge(dt) 'Llenar DSDT con Qry
            Else
                mMensajes.msg_Informacion("Esta Opcion no tiene valores para mostrar")
                Me.Close()
            End If

            FCN_Meses()
        Catch ex As Exception
            Me.Close()
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub


    Private Sub FCN_Meses()
        Try

        
            Dim dt As New DataTable()
            dt = mSQLSelect.GET_Nombre15Meses()
            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If


            lyc01.Text = dt.Rows(0)("m01").ToString
            lyc02.Text = dt.Rows(0)("m02").ToString
            lyc03.Text = dt.Rows(0)("m03").ToString
            lyc04.Text = dt.Rows(0)("m04").ToString
            lyc05.Text = dt.Rows(0)("m05").ToString
            lyc06.Text = dt.Rows(0)("m06").ToString
            lyc07.Text = dt.Rows(0)("m07").ToString
            lyc08.Text = dt.Rows(0)("m08").ToString
            lyc09.Text = dt.Rows(0)("m09").ToString
            lyc10.Text = dt.Rows(0)("m10").ToString
            lyc11.Text = dt.Rows(0)("m11").ToString
            lyc12.Text = dt.Rows(0)("m12").ToString
            lyc13.Text = dt.Rows(0)("m13").ToString
            lyc14.Text = dt.Rows(0)("m14").ToString
            lyc15.Text = dt.Rows(0)("m15").ToString

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
End Class