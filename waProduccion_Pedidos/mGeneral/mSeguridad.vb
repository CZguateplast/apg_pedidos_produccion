Imports System.Text
Module mSeguridad
    Public Sub APG_Seguridad(ByVal pPestana As DevExpress.XtraBars.Ribbon.RibbonPage)

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" RolId, ")
            qry.Append(" AplicacionId, ")
            qry.Append(" PestanaId, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGS.dbo.SEG_Aplicaciones_Pestanas ")
            qry.Append(" WHERE RolId = '" + My.Settings.log_Usuario.ToString + "'  ")
            qry.Append(" AND AplicacionId = '" + My.Application.Info.Title.ToString + "' ")
            qry.Append(" AND PestanaId = '" + pPestana.Name.ToString + "' ")

            Dim dt As New DataTable("dtSeguridadPestana")
            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If Not dt.Rows.Count = Nothing Then
                pPestana.Visible = True
            Else
                pPestana.Visible = False
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
        End Try
    End Sub
    Public Sub APG_Seguridad(ByVal pVentana As DevExpress.XtraBars.BarButtonItem)

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" RolId, ")
            qry.Append(" AplicacionId, ")
            qry.Append(" VentanaId, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGS.dbo.SEG_Aplicaciones_Ventanas ")
            qry.Append(" WHERE RolId = '" + My.Settings.log_Usuario.ToString + "'  ")
            qry.Append(" AND AplicacionId = '" + My.Application.Info.Title.ToString + "' ")
            qry.Append(" AND VentanaId = '" + pVentana.Name.ToString + "' ")

            Dim dt As New DataTable("dtSeguridadPestana")
            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If Not dt.Rows.Count = Nothing Then
                pVentana.Enabled = True
            Else
                pVentana.Enabled = False
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
        End Try
    End Sub
    Public Sub APG_Seguridad(ByVal pForm As System.Windows.Forms.Form, ByVal pBoton As DevExpress.XtraBars.BarButtonItem)

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" RolId, ")
            qry.Append(" AplicacionId, ")
            qry.Append(" FormId, ")
            qry.Append(" BotonId, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGS.dbo.SEG_Aplicaciones_Botones ")
            qry.Append(" WHERE RolId = '" + My.Settings.log_Usuario.ToString + "'  ")
            qry.Append(" AND AplicacionId = '" + My.Application.Info.Title.ToString + "' ")
            qry.Append(" AND FormId = '" + pForm.Name.ToString + "' ")
            qry.Append(" AND BotonId = '" + pBoton.Name.ToString + "' ")


            Dim dt As New DataTable("dtSeguridadPestana")
            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If Not dt.Rows.Count = Nothing Then
                pBoton.Enabled = True
            Else
                pBoton.Enabled = False
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.InnerException.ToString)
        End Try
    End Sub
    Public Sub APG_Seguridad(ByVal pForm As System.Windows.Forms.Form, ByVal pBoton As DevExpress.XtraEditors.SimpleButton)

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" RolId, ")
            qry.Append(" AplicacionId, ")
            qry.Append(" FormId, ")
            qry.Append(" BotonId, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGS.dbo.SEG_Aplicaciones_Botones ")
            qry.Append(" WHERE RolId = '" + My.Settings.log_Usuario.ToString + "'  ")
            qry.Append(" AND AplicacionId = '" + My.Application.Info.Title.ToString + "' ")
            qry.Append(" AND FormId = '" + pForm.Name.ToString + "' ")
            qry.Append(" AND BotonId = '" + pBoton.Name.ToString + "' ")


            Dim dt As New DataTable("dtSeguridadPestana")
            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If Not dt.Rows.Count = Nothing Then
                pBoton.Enabled = True
            Else
                pBoton.Enabled = False
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
        End Try
    End Sub
    Public Sub APG_Seguridad(ByVal pForm As System.Windows.Forms.Form, ByVal pBoton As DevExpress.XtraEditors.SearchLookUpEdit)

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" RolId, ")
            qry.Append(" AplicacionId, ")
            qry.Append(" FormId, ")
            qry.Append(" BotonId, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGS.dbo.SEG_Aplicaciones_Botones ")
            qry.Append(" WHERE RolId = '" + My.Settings.log_Usuario.ToString + "'  ")
            qry.Append(" AND AplicacionId = '" + My.Application.Info.Title.ToString + "' ")
            qry.Append(" AND FormId = '" + pForm.Name.ToString + "' ")
            qry.Append(" AND BotonId = '" + pBoton.Name.ToString + "' ")


            Dim dt As New DataTable("dtSeguridadPestana")
            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If Not dt.Rows.Count = Nothing Then
                pBoton.Enabled = True
            Else
                pBoton.Enabled = False
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
        End Try
    End Sub
    Public Sub APG_Seguridad(ByVal pForm As System.Windows.Forms.Form, ByVal pBoton As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit)

        Try
            Dim qry As New StringBuilder

            qry.Append(" SELECT ")
            qry.Append(" RolId, ")
            qry.Append(" AplicacionId, ")
            qry.Append(" FormId, ")
            qry.Append(" BotonId, ")
            qry.Append(" Estatus, ")
            qry.Append(" Bit_CreacionUsuario, ")
            qry.Append(" Bit_CreacionFecha, ")
            qry.Append(" Bit_ModificacionUsuario, ")
            qry.Append(" Bit_ModificacionFecha ")
            qry.Append(" FROM APGS.dbo.SEG_Aplicaciones_Botones ")
            qry.Append(" WHERE RolId = '" + My.Settings.log_Usuario.ToString + "'  ")
            qry.Append(" AND AplicacionId = '" + My.Application.Info.Title.ToString + "' ")
            qry.Append(" AND FormId = '" + pForm.Name.ToString + "' ")
            qry.Append(" AND BotonId = '" + pBoton.Name.ToString + "' ")


            Dim dt As New DataTable("dtSeguridadPestana")
            dt = mConexion.ConectarSQLGT_DT(qry.ToString) 'Ejecutar

            If Not dt.Rows.Count = Nothing Then
                pBoton.ReadOnly = False
            Else
                pBoton.ReadOnly = True
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message)
        End Try
    End Sub

End Module
