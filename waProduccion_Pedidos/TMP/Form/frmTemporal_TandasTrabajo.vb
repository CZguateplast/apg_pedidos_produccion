Public Class frmTemporal_TandasTrabajo
    Private mMaquina As String
    Private mCodigo As String
    Private mNombre As String
    Private dtTandas As DataTable

    Public Property mmMaquina As String
        Get
            Return mMaquina
        End Get
        Set(value As String)
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
    Public Property mmNombre As String
        Get
            Return mNombre
        End Get
        Set(value As String)
            mNombre = value
        End Set
    End Property
    Public Property mmdtTandas As DataTable
        Get
            Return dtTandas
        End Get
        Set(value As DataTable)
            dtTandas = Nothing
        End Set
    End Property



    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmTemporal_TandasTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtMaquina.EditValue = mMaquina
            txtCodigo.EditValue = mCodigo
            txtNombre.EditValue = mNombre
            DsTemporal_TandasTrabajo1.Tables(DsTemporal_TandasTrabajo1.dsdtTrabajos.TableName.ToString).Clear()
            'DsTemporal_TandasTrabajo1.Tables(DsTemporal_TandasTrabajo1.dsdtTrabajos.TableName.ToString).Merge(dtTandas)

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try


    End Sub

    Private Sub barbtnAgregarTanda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregarTanda.ItemClick
        Try
            Dim dt As New DataTable()
            dt = DsTemporal_TandasTrabajo1.dsdtTrabajos.Clone

            'LIMPIA LAS FILAS
            dt.Rows.Clear()

            'AGREGAR UNA FILA VACIA
            dt.Rows.Add(txtCodigo.EditValue, spinUTotal.EditValue, _
                        spinUBuenas.EditValue, spinUMalas.EditValue, _
                        timeTiempoTotal.EditValue, timeHoraInicio.EditValue, _
                        timeHoraFinal.EditValue, memoReporteUnidadesMalas.EditValue, _
                        memoReporteTiempoPerdido.EditValue)

            DsTemporal_TandasTrabajo1.Tables(DsTemporal_TandasTrabajo1.dsdtTrabajos.TableName.ToString).Merge(dt)


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrabar.ItemClick
        Try
            dtTandas = DsTemporal_TandasTrabajo1.dsdtTrabajos
            Me.Close()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub spinUBuenas_EditValueChanged(sender As Object, e As EventArgs) Handles spinUBuenas.EditValueChanged
        Try
            FC_Calculo_Unidades()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub spinUMalas_EditValueChanged(sender As Object, e As EventArgs) Handles spinUMalas.EditValueChanged
        Try
            FC_Calculo_Unidades()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FC_Calculo_Unidades()
        Try
            spinUTotal.EditValue = Val(spinUBuenas.EditValue) + Val(spinUMalas.EditValue)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub timeHoraInicio_EditValueChanged(sender As Object, e As EventArgs) Handles timeHoraInicio.EditValueChanged
        Try
            FC_Calculo_Tiempo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub timeHoraFinal_EditValueChanged(sender As Object, e As EventArgs) Handles timeHoraFinal.EditValueChanged
        Try
            FC_Calculo_Tiempo()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FC_Calculo_Tiempo()
        Try
            If timeHoraInicio.EditValue > "00:00:00" And timeHoraFinal.EditValue > "00:00:00" Then
                If timeHoraInicio.EditValue > timeHoraFinal.EditValue Then
                    Dim t1 As DateTime
                    Dim t2 As String
                    Dim t3 As String
                    Dim t4 As String

                    t1 = Convert.ToDateTime("2019-09-13")
                    t2 = Format(timeHoraInicio.EditValue, "hh:mm:ss")
                    t3 = Format(timeHoraFinal.EditValue, "hh:mm:ss")


                    t4 = DateDiff(DateInterval.Minute, t1, timeHoraInicio.EditValue)

                    Dim minutos As Integer = 84

                    Dim hora As String = String.Format("{0:N0}:{1:N0}", minutos / 60, minutos Mod 60)


                    t4 = Format((TimeValue(t1) - TimeValue(t2)), "hh:mm:ss") + TimeValue(t3)
                    timeTiempoTotal.Text = Format(TimeValue(t1) - TimeValue(t2), "hh:mm:ss") + TimeValue(t3)
                Else
                    timeTiempoTotal.EditValue = timeHoraFinal.EditValue - timeHoraInicio.EditValue
                End If
            Else
                timeTiempoTotal.EditValue = Nothing
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    
End Class