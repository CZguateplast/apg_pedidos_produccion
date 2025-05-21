Imports DevExpress.XtraGrid.Views.Layout.LayoutView
Imports DevExpress.XtraGrid.Views.Layout.Events
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Layout.ViewInfo

Public Class frmControlProduccion_Ingreso

    Dim mMaquina As Integer
    Dim mCodigo As String

    Dim mTotal As Integer
    Dim mBuenas As Integer
    Dim mMalas As Integer


    Public Property mmMaquina As Integer
        Get
            Return mMaquina
        End Get
        Set(value As Integer)
            mMaquina = value
        End Set
    End Property

    Public Property mmCodigo As String
        Get
            Return mCodigo
        End Get
        Set(value As String)
            mCodigo = value
        End Set
    End Property

    Private Sub frmControlProduccion_Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtMaquina.EditValue = mMaquina
            txtCodigo.EditValue = mCodigo
            dteFecha.EditValue = Date.Now

            'DATOS DE COLORES
            Dim dtColores As New DataTable()
            dtColores = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Ensamble_Ordenes_Hijos] CP," + mCodigo)

            DsControlProduccion_Ingreso1.Tables(DsControlProduccion_Ingreso1.dsdtColores.TableName.ToString).Clear()
            DsControlProduccion_Ingreso1.Tables(DsControlProduccion_Ingreso1.dsdtColores.TableName.ToString).Merge(dtColores)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub lyviewTrabajos_GotFocus(sender As Object, e As EventArgs)
        Try
            grdColoresEncabezado.UseEmbeddedNavigator = True
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub lyviewTrabajos_LostFocus(sender As Object, e As EventArgs)
        Try
            grdColoresEncabezado.UseEmbeddedNavigator = False
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
    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    'Private Sub cardviewTrabajos_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
    '    'Try
    '    '    Dim pTotal As String = String.Empty
    '    '    pTotal = e.Row("TotalUnidades").ToString

    '    '    MsgBox(pTotal)
    '    '    e.Valid = True
    '    'Catch ex As Exception
    '    '    mMensajes.msg_Error(ex.Message.ToString)
    '    'End Try

    '    ''MsgBox(e.Row("UnidadesMalas").ToString)

    'End Sub
    'Private Sub cardviewTrabajos_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs)

    '    'MsgBox(e.Value.ToString)
    '    'Try
    '    '    Dim pBuenas As Integer = 0
    '    '    Dim pMalas As Integer = 0
    '    '    Dim pTotal As Integer = 0


    '    '    pTotal = cardviewTrabajos.GetRowCellValue(cardviewTrabajos.FocusedRowHandle, "TotalUnidades")
    '    '    pBuenas = cardviewTrabajos.GetRowCellValue(cardviewTrabajos.FocusedRowHandle, "UnidadesBuenas")




    '    '    If pTotal < 1 Or pBuenas < 1 Then
    '    '        Exit Sub
    '    '    End If

    '    '    pMalas = pTotal - pBuenas

    '    '    cardviewTrabajos.SetRowCellValue(cardviewTrabajos.FocusedRowHandle, "UnidadesMalas", pMalas)



    '    '    e.Valid = True
    '    'Catch ex As Exception
    '    '    mMensajes.msg_Error(ex.Message.ToString)
    '    '    e.Valid = False
    '    'End Try



    'End Sub

    'Private Sub cardviewTrabajos_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
    '    'MsgBox(e.Value.ToString)
    'End Sub

    'Private Sub cardviewTrabajos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
    '    Try

    '        'Dim pBuenas As String = String.Empty
    '        'Dim pMalas As String = String.Empty
    '        'Dim pTotal As String = String.Empty

    '        'Dim selectedRows() As Integer = lyviewTrabajos.GetSelectedRows()
    '        'For Each rowHandle As Integer In selectedRows
    '        '    If rowHandle >= 0 Then
    '        '        Dim cellValue = lyviewTrabajos.GetRowCellValue(rowHandle, "TotalUnidades")
    '        '    End If
    '        'Next rowHandle


    '        'pTotal = lyviewTrabajos.GetRowCellValue(lyviewTrabajos.FocusedRowHandle, "TotalUnidades")
    '        'pBuenas = lyviewTrabajos.GetRowCellValue(lyviewTrabajos.FocusedRowHandle, "UnidadesBuenas")

    '        'If Val(pTotal) < 1 Or Val(pBuenas) < 1 Then
    '        '    Exit Sub
    '        'End If

    '        'pMalas = Val(pTotal) - Val(pBuenas)

    '        'lyviewTrabajos.SetRowCellValue(lyviewTrabajos.FocusedRowHandle, "UnidadesMalas", pMalas)

    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try
    'End Sub





    'Private Sub lyviewTrabajos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
    '    Try
    '        'Dim ptotalUnidades As Integer = 0

    '        'ptotalUnidades = lyviewTrabajos.GetRowCellValue(e.RowHandle, "TotalUnidades")


    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try


    'End Sub

    'Private Sub lyviewTrabajos_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
    '    Try

    '        'mBuenas = 0
    '        'mMalas = 0
    '        'mTotal = 0

    '        'Dim fieldFirstName As LayoutViewField = colTotalUnidades5.LayoutViewField

    '        'MsgBox(fieldFirstName.EditValue.ToString)
    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try

    'End Sub


    'Private Sub GridControl1_ViewRegistered(sender As Object, e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles grdviewColores.ViewRegistered

    'End Sub

    'Private Sub lView_CustomCardLayout(ByVal sender As Object, ByVal e As LayoutViewCustomCardLayoutEventArgs)

    'End Sub


    'Private Sub grdColoresEncabezado_ViewRegistered(sender As Object, e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles grdColoresEncabezado.ViewRegistered
    '    Dim lView = TryCast(e.View, LayoutView)
    '    If lView IsNot Nothing Then
    '        AddHandler lView.CustomCardLayout, AddressOf lyviewTrabajos_CustomCardLayout
    '    End If

    '    MsgBox("Prueba")

    'End Sub

    'Private Sub lyviewTrabajos_CustomCardLayout(sender As Object, e As LayoutViewCustomCardLayoutEventArgs) Handles lyviewTrabajos.CustomCardLayout
    '    Dim lView = TryCast(sender, LayoutView)
    '    For Each col As LayoutViewColumn In lView.Columns
    '        If lView.GetRowCellValue(e.RowHandle, col) Is Nothing Then
    '            e.CardDifferences.AddItemDifference(col.LayoutViewField.Name, LayoutItemDifferenceType.ItemVisibility, False)
    '        End If
    '    Next col
    'End Sub

    'Private Sub lyviewTrabajos_DoubleClick(sender As Object, e As EventArgs)
    '    'Dim args As MouseEventArgs = TryCast(e, MouseEventArgs)
    '    'Dim view As LayoutView = TryCast(sender, LayoutView)
    '    'Dim hi As LayoutViewHitInfo = view.CalcHitInfo(args.Location)
    '    'If hi.InField AndAlso hi.Column.FieldName = "TotalUnidades" Then
    '    '    Dim id As Object = view.GetRowCellValue(hi.RowHandle, "TotalUnidades")

    '    'End If


    '    'MsgBox(lyviewGetDATA(sender, e, "TotalUnidades").ToString + " " + lyviewGetDATA(sender, e, "UnidadesBuenas").ToString)

    'End Sub

    'Private Function lyviewGetDATA(sender As Object, e As EventArgs, ByVal pColumna As String) As Object
    '    'Dim args As MouseEventArgs = TryCast(e, MouseEventArgs)
    '    ''Dim view As LayoutView = TryCast(sender, LayoutView)

    '    'Dim view As LayoutView = lyviewTrabajos
    '    'Dim hi As LayoutViewHitInfo = view.CalcHitInfo(args.Location)
    '    ''If hi.InField AndAlso hi.Column.FieldName = pColumna Then
    '    'Dim id As Object = view.GetRowCellValue(hi.RowHandle, pColumna)
    '    'Return id
    '    'End If
    'End Function


#Region "Botones de Funciones"
    Private Sub barbtnAgregarProduccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregarProduccion.ItemClick
        Try
            Dim dtTandas As New DataTable()
            frmTemporal_ProduccionColores_Padre.mmCodigo = txtCodigo.EditValue
            frmTemporal_ProduccionColores_Padre.ShowDialog(Me)

            Dim pResultado As String = String.Empty
            pResultado = frmTemporal_ProduccionColores_Padre.mmResultado

            If pResultado = Nothing Then
                Exit Sub
            End If
            Dim pCondicion As String
            pCondicion = "CodigoArticulo = '" + pResultado.ToString + "'"

            frmTemporal_TandasTrabajo.mmMaquina = txtMaquina.EditValue
            frmTemporal_TandasTrabajo.mmCodigo = pResultado
            frmTemporal_TandasTrabajo.ShowDialog(Me)

            'SET DATOS AL RESUMEN
            DsControlProduccion_Ingreso1.Tables(DsControlProduccion_Ingreso1.dsdtTrabajos.TableName.ToString).Merge(frmTemporal_TandasTrabajo.mmdtTandas)

            DsControlProduccion_Ingreso1.dsdtTrabajos.AcceptChanges()
            DsControlProduccion_Ingreso1.dsdtColores.AcceptChanges()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

#End Region

End Class

