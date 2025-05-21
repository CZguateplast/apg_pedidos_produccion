Public Class frmTemporal_Prioridades

    Private mCodigo As String
    Private mProceso As Boolean

    Public Property ppCodigo() As String
        Get
            Return mCodigo
        End Get
        Set(ByVal Value As String)

            mCodigo = Value
        End Set
    End Property


    Public Property ppProceso() As Boolean
        Get
            Return mProceso
        End Get
        Set(ByVal Value As Boolean)
            mProceso = False
        End Set
    End Property


    Private Sub frmPrioridades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable()

            If Len(mCodigo) < 6 Then
                Exit Sub
            End If

            dt = GET_OrdenesProduccion_ByCodigoArticulo(mCodigo)

            If dt.Rows.Count = Nothing Then
                Exit Sub
            End If

            DsTemporal_Prioridades1.Tables(DsTemporal_Prioridades1.dsdtPrioridad.TableName.ToString).Clear()
            DsTemporal_Prioridades1.Tables(DsTemporal_Prioridades1.dsdtPrioridad.TableName.ToString).Merge(dt)



        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub spinPrioridad_EditValueChanged(sender As Object, e As EventArgs) Handles spinPrioridad.EditValueChanged
        Try
            For i = 0 To grdviewPrioridades.RowCount - 1
                If spinPrioridad.EditValue > 0 Then
                    grdviewPrioridades.SetRowCellValue(i, "Prioridad", spinPrioridad.EditValue.ToString)
                End If
            Next
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnCerrar.ItemClick
        Try
            mProceso = False
            Me.Close()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnSAP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSAP.ItemClick
        Try
            Dim pNumSAP As String = String.Empty
            Dim pPrioridad As String = String.Empty


            If Not ssmEsperar.IsSplashFormVisible Then : ssmEsperar.ShowWaitForm() : End If

            For i = 0 To DsTemporal_Prioridades1.dsdtPrioridad.Rows.Count - 1
                'Declarar Variables
                pNumSAP = DsTemporal_Prioridades1.dsdtPrioridad.Rows(i)("NumSAP").ToString
                pPrioridad = DsTemporal_Prioridades1.dsdtPrioridad.Rows(i)("Prioridad").ToString

                'splash
                ssmEsperar.SetWaitFormCaption("Actualizando...")
                ssmEsperar.SetWaitFormDescription("Orden:" + pNumSAP.ToString + " Prioridad: " + pPrioridad.ToString)
                'Subir a SAP

                If SAP_DIAPI_Produccion_UpdatePrioridad(pNumSAP, pPrioridad) Then
                    ssmEsperar.SetWaitFormCaption("Hecho...")
                    ssmEsperar.SetWaitFormDescription("Orden:" + pNumSAP.ToString + " Prioridad: " + pPrioridad.ToString)
                Else
                    ssmEsperar.SetWaitFormCaption("Error...")
                    ssmEsperar.SetWaitFormDescription("Orden:" + pNumSAP.ToString + " Prioridad: " + pPrioridad.ToString)
                End If
            Next



            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
            mMensajes.msg_Proceso_ok()

            mProceso = True
            Me.Close()

        Catch ex As Exception
            mMensajes.msg_Proceso_Error()
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub

    Private Sub frmTemporal_Prioridades_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Me.Controls.Clear()
            Me.InitializeComponent()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class