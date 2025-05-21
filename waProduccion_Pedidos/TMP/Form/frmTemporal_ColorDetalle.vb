Imports System.IO
Public Class frmTemporal_ColorDetalle
    Private pTipo As String
    Private pColor As String

    Public Property ppTipo() As String
        Get
            Return pTipo
        End Get
        Set(ByVal Value As String)

            pTipo = Value
        End Set
    End Property
    Public Property ppColor() As String
        Get
            Return pColor
        End Get
        Set(ByVal Value As String)

            pColor = Value
        End Set
    End Property


    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub frmTemporal_ColorDetalle_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim dtColor As New DataTable()
            dtColor = GET_Catalogo_Colores(pColor)
            If Not dtColor.Rows.Count = Nothing Then
                txtColorNombre.EditValue = dtColor.Rows(0)("Nombre").ToString
            End If


            Dim pFile As String()
            Dim pExtension As String = String.Empty

            pFile = Directory.GetFiles("\\192.168.1.245\Imagenes SAP\CATALOGO\COLORES\", pColor + ".*")
            If Not pFile.Length = 0 Then
                picColor.Image = Image.FromFile(pFile.First.ToString)
            Else
                picColor.Image = Nothing
            End If




            Dim dt As New DataTable()
            dt = mSQLSelect.GET_Colores_Detalle(pTipo, pColor)
            If dt.Rows.Count = Nothing Then
                DsTemporal_ColorDetalle1.Tables(DsTemporal_ColorDetalle1.dsdtColorDetalle.TableName.ToString).Clear()
                mMensajes.msg_Informacion("No existe detalle de " + pTipo + " en color " + pColor + Environment.NewLine + "Intente de nuevo!")
                Me.Close()
            End If

            DsTemporal_ColorDetalle1.Tables(DsTemporal_ColorDetalle1.dsdtColorDetalle.TableName.ToString).Clear()
            DsTemporal_ColorDetalle1.Tables(DsTemporal_ColorDetalle1.dsdtColorDetalle.TableName.ToString).Merge(dt)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBuscar.ItemClick
        Try
            mFunciones.FCN_XTRAGRID_Buscar(grdviewColores)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            grdviewColores.ShowRibbonPrintPreview()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            sfdSave.Filter = "Archivos Excel | *.xlsx"
            If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                grdviewColores.ExportToXlsx(sfdSave.FileName)
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class