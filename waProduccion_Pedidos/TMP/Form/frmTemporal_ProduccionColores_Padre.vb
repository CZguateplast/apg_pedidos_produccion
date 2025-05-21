Public Class frmTemporal_ProduccionColores_Padre
    Private mCodigo As String
    Private mResultado As String
    Private mTipo As String


    Public Property mmCodigo As String
        Get
            Return mCodigo
        End Get
        Set(value As String)
            mCodigo = value
        End Set
    End Property
    Public Property mmResultado As String
        Get
            Return mResultado
        End Get
        Set(value As String)
            mResultado = String.Empty
        End Set
    End Property

    Public Property mmTipo As String
        Get
            Return mTipo
        End Get
        Set(value As String)
            mTipo = value
        End Set
    End Property



    Private Sub Fill_Colores()
        Try
            
            Dim dtColores As New DataTable()
            dtColores = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[Ensamble_Ordenes_Hijos] CP," + mCodigo.ToString)

            'COLORES - Limpiar Controles
            DsTemporal_ProduccionColores_Padre1.Tables(DsTemporal_ProduccionColores_Padre1.dsdtColores.TableName.ToString).Clear()
            'txtCodigoPadre.EditValue = Nothing

            'COLORES - Llenar Controles
            If Not dtColores.Rows.Count = Nothing Then
                'txtCodigoPadre.EditValue = dtColores.Rows(0)("CodigoPadre")
                'LLENA LA TABLA DE COLORES
                DsTemporal_ProduccionColores_Padre1.Tables(DsTemporal_ProduccionColores_Padre1.dsdtColores.TableName.ToString).Merge(dtColores)
            End If


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            mResultado = Nothing
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmTemporal_ProduccionColores_Padre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            mResultado = Nothing
            Fill_Colores()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

    Private Sub barbtnAceptar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAceptar.ItemClick
        Try
            'VALIDACION DE CODIGO
            If grdviewColores.RowCount = Nothing Then
                MsgBox("Seleccione un codigo valido.")
                Exit Sub
            End If

            mResultado = grdviewColores.GetRowCellValue(grdviewColores.FocusedRowHandle, "CodigoArticulo")
            If mResultado = Nothing Then
                Exit Sub
            End If

            Me.Close()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class