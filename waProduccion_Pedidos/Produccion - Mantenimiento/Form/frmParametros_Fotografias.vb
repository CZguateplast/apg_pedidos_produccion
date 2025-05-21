Imports System.IO

Public Class frmParametros_Fotografias

    Private pCodigo As String
    Private pNombre As String

    Public Property ppCodigo() As String
        Get
            Return pCodigo
        End Get
        Set(value As String)
            pCodigo = value
        End Set
    End Property

    Public Property ppNombre() As String
        Get
            Return pNombre
        End Get
        Set(value As String)
            pNombre = value
        End Set
    End Property

    Private Sub frmParametros_Fotografias_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Me.Controls.Clear()
            Me.InitializeComponent()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmParametros_Fotografias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mFunciones.FCN_FILL_SearchLookUpEdit(slueTipoLibreria, mSQLSelect.GET_Listado("Tipo_Libreria"), "Id", "Nombre")
            txtCodigo.EditValue = pCodigo
            txtNombre.EditValue = pNombre
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

    Private Sub slueTipoLibreria_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles slueTipoLibreria.EditValueChanging
        Try
            TipoLibreria_CambiarValor(e.NewValue.ToString)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub TipoLibreria_CambiarValor(ByVal e As String)
        Try
            Select Case e
                Case "1"
                    Dim dtInstrucciones As New DataTable()
                    dtInstrucciones = mSQLSelect.GET_Listado("Instrucciones_PathFotografias")
                    If dtInstrucciones.Rows.Count = 0 Then
                        msg_Informacion("No existen parametros de Desetino de Imagenes")
                        Exit Sub
                    End If
                    txtDestinoDB.EditValue = dtInstrucciones.Rows(0)("Descripcion").ToString
                    txtBackupDB.EditValue = dtInstrucciones.Rows(1)("Descripcion").ToString
                    barbtnAgregar.Enabled = True
                    barbtnCancelarImagen.Enabled = False
                    barbtnGrabarImagen.Enabled = False

                Case "2"
                    Dim dtInstrucciones As New DataTable()
                    dtInstrucciones = mSQLSelect.GET_Listado("Advertencias_PathFotografias")
                    If dtInstrucciones.Rows.Count = 0 Then
                        msg_Informacion("No existen parametros de Desetino de Imagenes")
                        Exit Sub
                    End If
                    txtDestinoDB.EditValue = dtInstrucciones.Rows(0)("Descripcion").ToString
                    txtBackupDB.EditValue = dtInstrucciones.Rows(1)("Descripcion").ToString
                    barbtnAgregar.Enabled = True
                    barbtnCancelarImagen.Enabled = False
                    barbtnGrabarImagen.Enabled = False

                Case "3"
                    Dim dtInstrucciones As New DataTable()
                    dtInstrucciones = mSQLSelect.GET_Listado("Calidad_PathFotografias")
                    If dtInstrucciones.Rows.Count = 0 Then
                        msg_Informacion("No existen parametros de Desetino de Imagenes")
                        Exit Sub
                    End If
                    txtDestinoDB.EditValue = dtInstrucciones.Rows(0)("Descripcion").ToString
                    txtBackupDB.EditValue = dtInstrucciones.Rows(1)("Descripcion").ToString
                    barbtnAgregar.Enabled = True
                    barbtnCancelarImagen.Enabled = False
                    barbtnGrabarImagen.Enabled = False
                Case Else
                    txtDestinoDB.EditValue = String.Empty
                    txtBackupDB.EditValue = String.Empty
                    DsParametros_Fotografias1.Tables(DsParametros_Fotografias1.dsdtImpresion_FotoInstruccionesTrabajo.TableName.ToString).Clear()
                    picImage.Image = Nothing
                    barbtnAgregar.Enabled = False
                    barbtnCancelarImagen.Enabled = False
                    barbtnGrabarImagen.Enabled = False
                    Exit Sub
            End Select

            'HACER BUSQUEDA DE FOTOGRAFIAS GUARDADAS
            Dim pPath As String = String.Empty
            pPath = txtDestinoDB.EditValue

            'CREACION DE TABLA PARA GUARDAR DIRECTORIOS DE COINCIDENCIAS DE FOTOGRAFIAS
            Dim dt As New DataTable()
            dt.Columns.Add("Path", GetType(String))

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(
             pPath, FileIO.SearchOption.SearchAllSubDirectories, "" + pCodigo + "*")
                dt.Rows.Add(foundFile.ToString)
            Next

            For i = 0 To dt.Rows.Count - 1
                dt.Rows(i)(0) = My.Computer.FileSystem.GetFileInfo(dt.Rows(i)(0).ToString).Name.ToString
            Next

            DsParametros_Fotografias1.Tables(DsParametros_Fotografias1.dsdtImpresion_FotoInstruccionesTrabajo.TableName.ToString).Clear()
            DsParametros_Fotografias1.Tables(DsParametros_Fotografias1.dsdtImpresion_FotoInstruccionesTrabajo.TableName.ToString).Merge(dt)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewListaFotografias_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewListaFotografias.FocusedRowChanged
        Try
            If grdviewListaFotografias.RowCount = 0 Then
                memoDescripcionFotografias.EditValue = String.Empty
                Exit Sub
            End If

            Dim pFile As String()
            Dim pExtension As String = String.Empty
            Dim pFotografia As String = grdviewListaFotografias.GetRowCellValue(grdviewListaFotografias.FocusedRowHandle, "Path")
            pFile = Directory.GetFiles(txtDestinoDB.EditValue, pFotografia)
            If Not pFile.Length = 0 Then
                Dim extension = Path.GetExtension(pFotografia).ToLower()
                If EsImagenValida(pFotografia) Then
                    Dim xx As Image
                    Using str As Stream = File.OpenRead(Path.Combine(txtDestinoDB.EditValue, pFotografia))
                        xx = Image.FromStream(str)
                    End Using
                    picImage.Image = xx
                Else
                    ' Mostrar ícono genérico (asegúrate de tenerlo en recursos)
                    picImage.Image = My.Resources.Guateplast_Splash

                End If
            Else
                picImage.Image = Nothing
            End If

            Dim dtFotografias_Descripcion As New DataTable()
            dtFotografias_Descripcion = GET_Parametros_Fotografias(pFotografia.Substring(0, 12), slueTipoLibreria.EditValue)
            If dtFotografias_Descripcion.Rows.Count <> 0 Then
                memoDescripcionFotografias.EditValue = dtFotografias_Descripcion.Rows(0)("Descripcion").ToString
            Else
                memoDescripcionFotografias.EditValue = String.Empty
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Sub_Fill_Descripcion_Fotografia()
        Try
            Dim pCodigo As String = String.Empty
            Dim pDescripcion As String = String.Empty
            Dim pUsuario As String = String.Empty

            pCodigo = grdviewListaFotografias.GetRowCellValue(grdviewListaFotografias.FocusedRowHandle, "Path").ToString().Substring(0, 12)
            pDescripcion = memoDescripcionFotografias.EditValue
            pUsuario = My.Settings.log_Usuario.ToString

            If String.IsNullOrEmpty(pCodigo) Then Exit Sub

            If mSQLSelect.GET_DescripcionFotografia(pCodigo, slueTipoLibreria.EditValue.ToString).Rows.Count = 0 Then
                'INSERT
                mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[DescripcionFotografias_Parametros_Insert] '" + pCodigo + "','" + pDescripcion.ToString + "','" + slueTipoLibreria.EditValue + "','" + pUsuario + "'")
            Else
                'UPDATE
                mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.[DescripcionFotografias_Parametros_Update] '" + pCodigo + "','" + pDescripcion.ToString + "','" + slueTipoLibreria.EditValue + "','" + pUsuario + "'")
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub memoDescripcionFotografias_KeyDown(sender As Object, e As KeyEventArgs) Handles memoDescripcionFotografias.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                Sub_Fill_Descripcion_Fotografia()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub memoDescripcionFotografias_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles memoDescripcionFotografias.Validating
        Try
            Sub_Fill_Descripcion_Fotografia()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    ' Permitir imágenes, videos y documentos
    Private Function EsArchivoPermitido(rutaArchivo As String) As Boolean
        Try
            Dim ext = Path.GetExtension(rutaArchivo).ToLower()
            Dim imagenes = {".jpg", ".jpeg", ".png", ".bmp", ".gif"}
            Dim videos = {".mp4", ".avi", ".mov", ".wmv"}
            Dim docs = {".pdf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx"}
            Return imagenes.Contains(ext) OrElse videos.Contains(ext) OrElse docs.Contains(ext)
        Catch
            Return False
        End Try
    End Function

    ' Permitir solo imágenes para la vista previa
    Private Function EsImagenValida(rutaArchivo As String) As Boolean
        Try
            Dim extensionesValidas As String() = {".jpg", ".jpeg", ".png", ".bmp", ".gif"}
            Dim extension As String = Path.GetExtension(rutaArchivo).ToLower()
            Return extensionesValidas.Contains(extension)
        Catch
            Return False
        End Try
    End Function

    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            ofdImagen.FileName = ""
            ofdImagen.Title = "Seleccionar Archivo"
            ofdImagen.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Videos|*.mp4;*.avi;*.mov;*.wmv|Documentos|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx|Todos los archivos|*.*"

            If ofdImagen.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If Not EsArchivoPermitido(ofdImagen.FileName) Then
                    mMensajes.msg_Informacion("Tipo de archivo no permitido.")
                    Exit Sub
                End If

                txtImagenNombre.EditValue = ofdImagen.SafeFileName
                txtImagenOrigen.EditValue = ofdImagen.FileName
                txtImagenExtension.EditValue = Path.GetExtension(ofdImagen.FileName)

                ' Vista previa solo si es imagen
                If EsImagenValida(ofdImagen.FileName) Then
                    picImage.Image = Image.FromFile(ofdImagen.FileName)
                Else
                    picImage.Image = My.Resources.Guateplast_Splash ' Agrega un ícono genérico para videos/documentos
                End If

                grdListaFotografias.Enabled = False
                memoDescripcionFotografias.Enabled = False

                Dim pCantidadFotografias As Integer = grdviewListaFotografias.RowCount + 1
                Dim pDisponible As String = String.Format("{0:000}", pCantidadFotografias)
                txtImagenNombre.EditValue = $"{txtCodigo.EditValue}-{pDisponible}"

                barbtnAgregar.Enabled = False
                barbtnCancelarImagen.Enabled = True
                barbtnGrabarImagen.Enabled = True
            End If

        Catch ex As Exception
            mMensajes.msg_Error($"Error al cargar el archivo: {ex.Message}")
        End Try
    End Sub

    Private Sub barbtnCancelarImagen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCancelarImagen.ItemClick
        Try
            txtImagenNombre.EditValue = String.Empty
            txtImagenExtension.EditValue = String.Empty
            txtImagenOrigen.EditValue = String.Empty
            grdListaFotografias.Enabled = True
            memoDescripcionFotografias.Enabled = True
            picImage.Image = Nothing
            barbtnAgregar.Enabled = True
            barbtnCancelarImagen.Enabled = False
            barbtnGrabarImagen.Enabled = False
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewListaFotografias_DoubleClick(sender As Object, e As EventArgs) Handles grdviewListaFotografias.DoubleClick
        Try
            ofdImagen.FileName = ""
            ofdImagen.Title = "Abrir Archivo"
            ofdImagen.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Videos|*.mp4;*.avi;*.mov;*.wmv|Documentos|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx|Todos los archivos|*.*"

            If ofdImagen.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If Not EsArchivoPermitido(ofdImagen.FileName) Then
                    mMensajes.msg_Informacion("Tipo de archivo no permitido.")
                    Exit Sub
                End If

                txtImagenOrigen.EditValue = ofdImagen.FileName
                txtImagenExtension.EditValue = Path.GetExtension(ofdImagen.FileName)
                txtImagenNombre.EditValue = grdviewListaFotografias.GetRowCellValue(grdviewListaFotografias.FocusedRowHandle, "Path").ToString().Substring(0, 12)

                If EsImagenValida(ofdImagen.FileName) Then
                    picImage.Image = Image.FromFile(ofdImagen.FileName)
                Else
                    picImage.Image = My.Resources.Guateplast_Splash
                End If

                grdListaFotografias.Enabled = False
                memoDescripcionFotografias.Enabled = False

                barbtnAgregar.Enabled = False
                barbtnCancelarImagen.Enabled = True
                barbtnGrabarImagen.Enabled = True
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnGrabarImagen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabarImagen.ItemClick
        Try
            Dim nombre = Convert.ToString(txtImagenNombre.EditValue)
            Dim origen = Convert.ToString(txtImagenOrigen.EditValue)
            Dim extension = Convert.ToString(txtImagenExtension.EditValue)
            Dim destino = Convert.ToString(txtDestinoDB.EditValue)

            If String.IsNullOrEmpty(nombre) Then
                mMensajes.msg_Informacion("Debe seleccionar un archivo para cargar. Intente de nuevo.")
                Exit Sub
            ElseIf String.IsNullOrEmpty(destino) Then
                mMensajes.msg_Informacion("No existe ruta de Destino." + Environment.NewLine + "Seleccione una carpeta de Destino!")
                Exit Sub
            ElseIf Not EsArchivoPermitido(origen) Then
                mMensajes.msg_Informacion("Tipo de archivo no permitido.")
                Exit Sub
            End If

            Dim fullPath = Path.Combine(destino, nombre & extension)
            Application.DoEvents()
            My.Computer.FileSystem.CopyFile(origen, fullPath, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            mMensajes.msg_Proceso_ok()

            grdListaFotografias.Enabled = True
            memoDescripcionFotografias.Enabled = True
            barbtnAgregar.Enabled = True
            barbtnCancelarImagen.Enabled = False
            barbtnGrabarImagen.Enabled = False
            txtImagenNombre.EditValue = String.Empty
            txtImagenExtension.EditValue = String.Empty
            txtImagenOrigen.EditValue = String.Empty
            picImage.Image = Nothing
            TipoLibreria_CambiarValor(slueTipoLibreria.EditValue.ToString)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Borrar_Fotografias()
        Try
            If grdviewListaFotografias.RowCount = 0 Then
                memoDescripcionFotografias.EditValue = String.Empty
                Exit Sub
            End If

            Dim pFotografia As String = grdviewListaFotografias.GetRowCellValue(grdviewListaFotografias.FocusedRowHandle, "Path")
            picImage.Image = Nothing
            Dim FileToDelete As String
            FileToDelete = Path.Combine(txtDestinoDB.EditValue.ToString, pFotografia.ToString)

            If System.IO.File.Exists(FileToDelete) = True Then
                System.IO.File.Delete(FileToDelete)
                MsgBox("Archivo Eliminado")
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnAyuda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAyuda.ItemClick
        Try
            Dim path = System.IO.Path.Combine(Application.StartupPath, "help/helpMantFotografias_1.png")
            System.Diagnostics.Process.Start(path)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class
