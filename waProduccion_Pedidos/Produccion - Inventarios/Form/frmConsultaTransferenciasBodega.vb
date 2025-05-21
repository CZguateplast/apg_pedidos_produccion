Public Class frmConsultaTransferenciasBodega
    ' Propiedad para recibir el DataTable
    Public Property Transacciones As DataTable
    'Buscador dinamico
    Private bsDatos As BindingSource
    Private Sub frmConsultaTransferenciasBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Puedes usar el DataTable aquí, por ejemplo, para enlazarlo a un DataGridView
        If Transacciones IsNot Nothing Then
            ' Crear y configurar el BindingSource
            bsDatos = New BindingSource()
            bsDatos.DataSource = Transacciones

            ' Enlazar el BindingSource al DataGridView
            grdViewDatos.DataSource = bsDatos

            'Configuraciones de DataGrepView
            grdViewDatos.ReadOnly = True
            grdViewDatos.Columns(0).Frozen = True
            grdViewDatos.Columns(1).Frozen = True
            grdViewDatos.Columns(0).HeaderText = "Fecha de Traslado"
            grdViewDatos.Columns(1).HeaderText = "Codigo"
            grdViewDatos.Columns(0).DefaultCellStyle.BackColor = ColorTranslator.FromOle(RGB(193, 222, 234))
            grdViewDatos.Columns(1).DefaultCellStyle.BackColor = ColorTranslator.FromOle(RGB(193, 222, 234))

            'Nombres
            grdViewDatos.Columns(2).HeaderText = "Nombre del Producto"
            grdViewDatos.Columns(3).HeaderText = "Bodega Destino"
            grdViewDatos.Columns(4).HeaderText = "Stock"
            grdViewDatos.Columns(5).HeaderText = "Comprometido"
            grdViewDatos.Columns(6).HeaderText = "Solicitado"
            grdViewDatos.Columns(7).HeaderText = "Requerido"
            grdViewDatos.Columns(8).HeaderText = "Bodega Origen"
            grdViewDatos.Columns(9).HeaderText = "Cantidad Bodega"
            grdViewDatos.Columns(38).HeaderText = "Pendiente"
            grdViewDatos.Columns(39).HeaderText = "Realizado por"


            ' Mostrar la cantidad de registros
            lblCantRegistros.Text = grdViewDatos.Rows.Count.ToString()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Buscar
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ' Verificar si el BindingSource ha sido inicializado
        If bsDatos IsNot Nothing Then
            ' Aplicar filtro dinámico para todas las columnas
            Dim filter As String = String.Empty

            For Each col As DataColumn In Transacciones.Columns
                If col.DataType = GetType(String) Then
                    If filter.Length > 0 Then filter &= " OR "
                    filter &= String.Format("[{0}] LIKE '%{1}%'", col.ColumnName, txtBuscar.Text)
                ElseIf col.DataType = GetType(Integer) OrElse col.DataType = GetType(Double) Then
                    ' Filtrar por columnas de tipo numérico (opcional)
                    If IsNumeric(txtBuscar.Text) Then
                        If filter.Length > 0 Then filter &= " OR "
                        filter &= String.Format("[{0}] = {1}", col.ColumnName, txtBuscar.Text)
                    End If
                End If
            Next

            ' Aplicar el filtro al BindingSource
            bsDatos.Filter = filter
            lblCantRegistros.Text = grdViewDatos.Rows.Count.ToString() ' Actualizar la cantidad de registros
        End If
    End Sub

End Class