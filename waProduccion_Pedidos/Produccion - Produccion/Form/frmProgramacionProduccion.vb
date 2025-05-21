Imports DevExpress.XtraReports.UI

Imports System
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.GridSummaryItem


Public Class frmProgramacionProduccion
    Dim pSaveRow As Integer

    Dim pHorasPromedioMaquina As Boolean = False



    Private Sub frmProgramacionProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            mFunciones.FCN_FILL_SearchLookUpEdit(rsluePrioridadEmergencias, mSQLSelect.GET_PROD_CatListados("Tipo_Prioridad"), "Id", "Nombre")
            FCN_LOAD()

            grdviewOrdenesProduccion.ExpandAllGroups()
            grdviewProgramacionAsignados.ExpandAllGroups()

            FCN_ProgramacionProduccion_Enumerar()
            FC_Calcular_Horas_Promedio()

            'barwVistas.WorkspacesPath = My.Application.Info.DirectoryPath + "\Wrksp\"
            Fill_Workspace()
            wsmVistasOrdenes.ApplyWorkspace("Vista Default")
            
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Fill_Workspace()
        Try
            wsmVistasOrdenes.LoadWorkspace("Vista Default", My.Application.Info.DirectoryPath + "\Wrksp\VistaDefault.xml")
            wsmVistasOrdenes.LoadWorkspace("Vista Grupo Maquina", My.Application.Info.DirectoryPath + "\Wrksp\VistaGrupoMaquina.xml")

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub



    Private Sub FC_Calcular_Horas_Promedio()
        Try
            'CALCULAR PROMEDIO DE HORAS POR MAQUINA

            Dim pGrupoAnterior As Integer = 0
            Dim pGrupoActual As Integer = 0
            Dim pMaquinaAnterior As Integer = 0
            Dim pMaquinaActual As Integer = 0
            Dim pTotalPendiente As Integer = 0
            Dim pTotalMaquina As Integer = 0

            For irow = 0 To DsProgramacionProduccion.dsdtOrdenesProduccion.Rows.Count - 1
                If irow = 0 Then
                    pGrupoAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("GrupoMaquina")
                    pMaquinaAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("Preferencial")
                    pTotalMaquina = 1
                Else
                    pGrupoAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(Val(irow - 1))("GrupoMaquina")
                    pMaquinaAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(Val(irow - 1))("Preferencial")
                End If
                pGrupoActual = DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("GrupoMaquina")
                pMaquinaActual = DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("Preferencial")

                'MISMO GRUPO
                If pGrupoAnterior = pGrupoActual Then
                    'MISMA MAQUINA
                    If pMaquinaAnterior = pMaquinaActual Then
                        pTotalPendiente = pTotalPendiente + Val(DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("HorasPendiente"))

                    Else 'NO ES LA MISMA MAQUINA
                        pTotalPendiente = pTotalPendiente + Val(DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("HorasPendiente"))
                        pTotalMaquina = pTotalMaquina + 1
                    End If

                Else 'NO ES EL MISMO GRUPO
                    'GRABAR DATOS EN LA FILA ANTERIOR
                    If pTotalPendiente > 0 And pTotalMaquina > 0 Then

                        'TRAER CANTIDAD DE MAQUINAS ASIGNADAS EN GRUPO
                        pTotalMaquina = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_MaquinasXGrupo_Cantidad " + DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(Val(irow - 1))("GrupoMaquina").ToString).Rows(0)(0).ToString
                        'VALIDAR SI TRAE CERO MAQUINAS HAY QUE DIVIDIR ENTRE 1
                        If pTotalMaquina = 0 Then : pTotalMaquina = 1 : End If

                        'MAQUINAS EN GRUPO
                        If irow = Val(DsProgramacionProduccion.dsdtOrdenesProduccion.Rows.Count - 1) Then
                            DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(Val(irow - 1))("PromedioMaquina") = CInt(pTotalPendiente / pTotalMaquina)

                            'VALIDAR ULTIMA LINEA
                            pTotalMaquina = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_MaquinasXGrupo_Cantidad " + DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("GrupoMaquina").ToString).Rows(0)(0).ToString
                            'VALIDAR SI TRAE CERO MAQUINAS HAY QUE DIVIDIR ENTRE 1
                            If pTotalMaquina = 0 Then : pTotalMaquina = 1 : End If
                            pTotalPendiente = Val(DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("HorasPendiente"))
                            DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("PromedioMaquina") = CInt(pTotalPendiente / pTotalMaquina)
                        Else
                            DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(Val(irow - 1))("PromedioMaquina") = CInt(pTotalPendiente / pTotalMaquina)
                        End If
                    End If

                    'PROCEDER A GRABAR OTRA VEZ
                    pGrupoAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(Val(irow - 1))("GrupoMaquina")
                    pMaquinaAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(Val(irow - 1))("Preferencial")
                    pGrupoActual = DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("GrupoMaquina")
                    pMaquinaActual = DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("Preferencial")

                    pTotalPendiente = Val(DsProgramacionProduccion.dsdtOrdenesProduccion.Rows(irow)("HorasPendiente"))
                    pTotalMaquina = 1

                End If
                DsProgramacionProduccion.dsdtOrdenesProduccion.AcceptChanges()
            Next

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FC_Calcular_Horas_Promedio_Todas()
        Try
            'CALCULAR PROMEDIO DE HORAS POR MAQUINA

            Dim pGrupoAnterior As Integer = 0
            Dim pGrupoActual As Integer = 0
            Dim pMaquinaAnterior As Integer = 0
            Dim pMaquinaActual As Integer = 0
            Dim pTotalPendiente As Integer = 0
            Dim pTotalMaquina As Integer = 0
            Dim pMaquinasEnGrupo As String = String.Empty
            Dim pRangoToneladas As String = String.Empty

            For irow = 0 To DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows.Count - 1

                'ASIGNAR VALORES A VARIABLES
                If irow = 0 Then
                    pGrupoAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("GrupoMaquina")
                    pMaquinaAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("Preferencial")
                    pTotalMaquina = 1
                Else
                    pGrupoAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(Val(irow - 1))("GrupoMaquina")
                    pMaquinaAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(Val(irow - 1))("Preferencial")
                End If
                pGrupoActual = DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("GrupoMaquina")
                pMaquinaActual = DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("Preferencial")

                'ASIGNAR MAQUINAS EN GRUPO
                pMaquinasEnGrupo = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_MaquinasXGrupo_NumerosMaquina " + DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("GrupoMaquina").ToString).Rows(0)(0).ToString
                DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("MaquinasEnGrupo") = pMaquinasEnGrupo

                pRangoToneladas = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_Maquinas_ToneladasXGrupo " + DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("GrupoMaquina").ToString).Rows(0)(0).ToString
                DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("RangoToneladas") = pRangoToneladas

                'MISMO GRUPO
                If pGrupoAnterior = pGrupoActual Then
                    'MISMA MAQUINA
                    If pMaquinaAnterior = pMaquinaActual Then
                        pTotalPendiente = pTotalPendiente + Val(DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("HorasPendiente"))

                    Else 'NO ES LA MISMA MAQUINA
                        pTotalPendiente = pTotalPendiente + Val(DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("HorasPendiente"))
                        pTotalMaquina = pTotalMaquina + 1
                    End If


                Else 'NO ES EL MISMO GRUPO
                    'GRABAR DATOS EN LA FILA ANTERIOR
                    If pTotalPendiente > 0 And pTotalMaquina > 0 Then

                        'TRAER CANTIDAD DE MAQUINAS ASIGNADAS EN GRUPO
                        pTotalMaquina = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_MaquinasXGrupo_Cantidad " + DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(Val(irow - 1))("GrupoMaquina").ToString).Rows(0)(0).ToString
                        'VALIDAR SI TRAE CERO MAQUINAS HAY QUE DIVIDIR ENTRE 1
                        If pTotalMaquina = 0 Then : pTotalMaquina = 1 : End If

                        'MAQUINAS EN GRUPO
                        'VALIDAR SI ES ULTIMA LINEA
                        If irow = Val(DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows.Count - 1) Then
                            'VALIDAR FILA ANTERIOR
                            DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(Val(irow - 1))("PromedioMaquina") = CInt(pTotalPendiente / pTotalMaquina)

                            'VALIDAR ULTIMA LINEA
                            pTotalMaquina = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_MaquinasXGrupo_Cantidad " + DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("GrupoMaquina").ToString).Rows(0)(0).ToString
                            'VALIDAR SI TRAE CERO MAQUINAS HAY QUE DIVIDIR ENTRE 1
                            If pTotalMaquina = 0 Then : pTotalMaquina = 1 : End If
                            pTotalPendiente = Val(DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("HorasPendiente"))
                            DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("PromedioMaquina") = CInt(pTotalPendiente / pTotalMaquina)
                        Else
                            DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(Val(irow - 1))("PromedioMaquina") = CInt(pTotalPendiente / pTotalMaquina)
                        End If
                    End If

                    'PROCEDER A GRABAR OTRA VEZ
                    pGrupoAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(Val(irow - 1))("GrupoMaquina")
                    pMaquinaAnterior = DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(Val(irow - 1))("Preferencial")
                    pGrupoActual = DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("GrupoMaquina")
                    pMaquinaActual = DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("Preferencial")

                    pTotalPendiente = Val(DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.Rows(irow)("HorasPendiente"))
                    pTotalMaquina = 1

                End If
                DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.AcceptChanges()
            Next
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub


    Private Sub Fill_OrdenesProduccion()
        Try
            'LLENAR GRID DE ORDENES DE PRODUCCION
            Dim dtOrdenesProduccion As New DataTable()
            'dtOrdenesProduccion = mSQLSelect.GET_PlanificacionProduccion_Ordenes()
            dtOrdenesProduccion = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_OrdenesProduccion_Padres")


            If dtOrdenesProduccion.Rows.Count = Nothing Then
                DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion.TableName.ToString).Clear()
                'Exit Sub
            End If


            For irow = 0 To dtOrdenesProduccion.Rows.Count - 1  'RECORRE TABLA CON DATOS DE ARTICULOS PADRE
                Dim dtParametrosMolde As New DataTable()
                Dim pHorasPendiente As String = String.Empty
                dtParametrosMolde = mSQLSelect.GET_MoldesProduccionParametros(dtOrdenesProduccion.Rows(irow)("CodigoArticulo")) 'OBTIENE PARAMETROS DE TIEMPO SEGUN LA ROW

                'SI TRAE DATOS GRABAR EN TABLA PARAMETROS DE PRODUCCION POR HORA Y HORAS PENDIENTES
                If Not dtParametrosMolde.Rows.Count = Nothing Then

                    dtOrdenesProduccion.Rows(irow)("ProduccionHora") = dtParametrosMolde.Rows(0)("ArticulosHora")

                    'If hay articulos pendientes de produccion, calcula las horas pendientes de trabajo.
                    If dtOrdenesProduccion.Rows(irow)("Pendiente") > 0 Then
                        Dim pArticulosHora As Double = Val(dtParametrosMolde.Rows(0)("ArticulosHora"))
                        If pArticulosHora > 0 Then
                            pHorasPendiente = Val(dtOrdenesProduccion.Rows(irow)("Pendiente")) / pArticulosHora
                            dtOrdenesProduccion.Rows(irow)("HorasPendiente") = CInt(pHorasPendiente)
                        End If
                    End If

                End If
            Next

            DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion.TableName.ToString).Clear()
            DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion.TableName.ToString).Merge(dtOrdenesProduccion)

            grdviewOrdenesProduccion.ExpandAllGroups()

            FC_Calcular_Horas_Promedio()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try

    End Sub

    Private Sub FCN_LOAD()
        Try

            Fill_OrdenesProduccion()
            ''LLENAR GRID DE ORDENES DE PRODUCCION
            'Dim dtOrdenesProduccion As New DataTable()
            ''dtOrdenesProduccion = mSQLSelect.GET_PlanificacionProduccion_Ordenes()
            'dtOrdenesProduccion = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_OrdenesProduccion_Padres")


            'If dtOrdenesProduccion.Rows.Count = Nothing Then
            '    DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion.TableName.ToString).Clear()
            '    'Exit Sub
            'End If


            'For irow = 0 To dtOrdenesProduccion.Rows.Count - 1  'RECORRE TABLA CON DATOS DE ARTICULOS PADRE
            '    Dim dtParametrosMolde As New DataTable()
            '    Dim pHorasPendiente As String = String.Empty
            '    dtParametrosMolde = mSQLSelect.GET_MoldesProduccionParametros(dtOrdenesProduccion.Rows(irow)("CodigoArticulo")) 'OBTIENE PARAMETROS DE TIEMPO SEGUN LA ROW

            '    'SI TRAE DATOS GRABAR EN TABLA PARAMETROS DE PRODUCCION POR HORA Y HORAS PENDIENTES
            '    If Not dtParametrosMolde.Rows.Count = Nothing Then

            '        dtOrdenesProduccion.Rows(irow)("ProduccionHora") = dtParametrosMolde.Rows(0)("ArticulosHora")

            '        'If hay articulos pendientes de produccion, calcula las horas pendientes de trabajo.
            '        If dtOrdenesProduccion.Rows(irow)("Pendiente") > 0 Then
            '            Dim pArticulosHora As Double = Val(dtParametrosMolde.Rows(0)("ArticulosHora"))
            '            If pArticulosHora > 0 Then
            '                pHorasPendiente = Val(dtOrdenesProduccion.Rows(irow)("Pendiente")) / pArticulosHora
            '                dtOrdenesProduccion.Rows(irow)("HorasPendiente") = CInt(pHorasPendiente)
            '            End If


            '        End If

            '    End If
            'Next

            'DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion.TableName.ToString).Clear()
            'DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion.TableName.ToString).Merge(dtOrdenesProduccion)

            'ARTICULOS PROGRAMADOS
            Dim dtOrdenesProgramadas As New DataTable()
            'dtOrdenesProgramadas = GET_PlanificacionProduccion_Programada()
            dtOrdenesProgramadas = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_ProgramacionProduccion")

            For I = 0 To dtOrdenesProgramadas.Rows.Count - 1
                Dim pHorasPendiente As String = String.Empty
                Dim pProduccionHora As String = String.Empty
                Dim dtDatosMolde As New DataTable()

                pHorasPendiente = mFunciones.FCN_ProduccionHoras(dtOrdenesProgramadas.Rows(I)("CodigoArticulo"), dtOrdenesProgramadas.Rows(I)("Pendiente"))
                If Not pHorasPendiente = Nothing Then
                    dtOrdenesProgramadas.Rows(I)("HorasPendiente") = pHorasPendiente
                Else
                    dtOrdenesProgramadas.Rows(I)("HorasPendiente") = 1
                End If

                'dtDatosMolde = mSQLSelect.GET_MoldesProduccionParametros(dtOrdenesProgramadas.Rows(I)("CodigoArticulo"))
                dtDatosMolde = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_ProduccionParametros " + dtOrdenesProgramadas.Rows(I)("CodigoArticulo").ToString)

                If Not dtDatosMolde.Rows.Count = Nothing Then
                    pProduccionHora = dtDatosMolde.Rows(0)("ArticulosHora")
                End If

                If Not pProduccionHora = Nothing Then
                    dtOrdenesProgramadas.Rows(I)("ProduccionHora") = pProduccionHora
                End If

            Next

            DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Clear()
            If Not dtOrdenesProgramadas.Rows.Count = Nothing Then
                DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtOrdenesProgramadas)
            End If

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub FCN_Programacion_Agregar()
        Try
            If grdviewOrdenesProduccion.FocusedRowHandle < 0 Then
                Exit Sub
            End If

            Dim pCodigoArticulo As String = String.Empty
            Dim pNombreArticulo As String = String.Empty
            Dim pMaquina As String = String.Empty
            Dim pFaltante As String = String.Empty

            pFaltante = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccion, "Pendiente")
            If pFaltante < 1 Then
                mMensajes.msg_Informacion("Este Componente no tiene produccion Pendiente.")
                Exit Sub
            End If

            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccion, "CodigoArticulo")
            pNombreArticulo = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccion, "NombreArticulo")
            pMaquina = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccion, "Preferencial")


            '--------Inicia nuevo Proceso'-----------------
            '----------------------------------------------
            frmTemporal_MaquinasParaTrabajar.ppTipoProceso = "M"
            frmTemporal_MaquinasParaTrabajar.ppCodigoPadre = pCodigoArticulo
            frmTemporal_MaquinasParaTrabajar.ppNombre = pNombreArticulo
            frmTemporal_MaquinasParaTrabajar.ShowDialog(Me)

            If frmTemporal_MaquinasParaTrabajar.ppBoolean = False Then
                Exit Sub
            End If


            If Not frmTemporal_MaquinasParaTrabajar.ppMaquinaSeleccionada = String.Empty Then
                Dim dtAgregar As New DataTable()
                dtAgregar = GET_PlanificacionProduccion_Programada(pCodigoArticulo)
                If dtAgregar.Rows.Count = Nothing Then
                    Exit Sub
                End If

                Dim dtParametrosMolde As New DataTable()
                Dim pHorasPendiente As String = String.Empty
                dtParametrosMolde = mSQLSelect.GET_MoldesProduccionParametros(pCodigoArticulo)

                dtAgregar.Rows(0)("Preferencial") = frmTemporal_MaquinasParaTrabajar.ppMaquinaSeleccionada
                dtAgregar.Rows(0)("PrioridadMaquina") = mSQLSelect.GET_PrioridadMaquina_Siguiente(dtAgregar.Rows(0)("Preferencial"))

                pHorasPendiente = mFunciones.FCN_ProduccionHoras(pCodigoArticulo, dtAgregar.Rows(0)("Pendiente"))
                If pHorasPendiente = Nothing Then
                    mMensajes.msg_Informacion("No existen parametros de Produccion para [" + pCodigoArticulo + "] ")
                Else

                    dtAgregar.Rows(0)("HorasPendiente") = pHorasPendiente

                    If Not dtParametrosMolde.Rows.Count = Nothing Then
                        dtAgregar.Rows(0)("ProduccionHora") = dtParametrosMolde.Rows(0)("ArticulosHora").ToString
                    End If

                    SET_PlanificacionProduccion_Programada(dtAgregar.Rows(0)("Preferencial").ToString, _
                                                           dtAgregar.Rows(0)("Estado").ToString, _
                                                           dtAgregar.Rows(0)("Prioridad").ToString, _
                                                           dtAgregar.Rows(0)("PrioridadMaquina").ToString, _
                                                           dtAgregar.Rows(0)("CodigoArticulo").ToString, _
                                                           dtAgregar.Rows(0)("Comentarios").ToString)


                    DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtAgregar)

                    'ACTUALIZAR ORDENES PRODUCCION
                    'FCN_Fill_Producciones_Ordenes()
                    Fill_OrdenesProduccion()
                End If
            End If

            '------Termina nuevo proceso.



            'Dim pResultado As MsgBoxResult = Nothing
            'If pMaquina <= 1 Then
            '    pResultado = MsgBoxResult.No
            'Else
            '    pResultado = MsgBox("¿Desea agregar el componente [" + pCodigoArticulo + "] a la Maquina Preferencial < " + pMaquina + " > ?", MsgBoxStyle.YesNoCancel, "Asigar")
            'End If

            'Select Case pResultado
            '    Case MsgBoxResult.Yes

            '        Dim dtAgregar As New DataTable()
            '        dtAgregar = GET_PlanificacionProduccion_Programada(pCodigoArticulo)
            '        If dtAgregar.Rows.Count = Nothing Then
            '            Exit Sub
            '        End If

            '        Dim dtParametrosMolde As New DataTable()
            '        Dim pHorasPendiente As String = String.Empty
            '        dtParametrosMolde = mSQLSelect.GET_MoldesProduccionParametros(pCodigoArticulo)

            '        dtAgregar.Rows(0)("PrioridadMaquina") = mSQLSelect.GET_PrioridadMaquina_Siguiente(dtAgregar.Rows(0)("Preferencial"))

            '        pHorasPendiente = mFunciones.FCN_ProduccionHoras(pCodigoArticulo, dtAgregar.Rows(0)("Pendiente"))
            '        If pHorasPendiente = Nothing Then
            '            mMensajes.msg_Informacion("No existen parametros de Produccion para [" + pCodigoArticulo + "] ")
            '        Else

            '            dtAgregar.Rows(0)("HorasPendiente") = pHorasPendiente
            '            If Not dtParametrosMolde.Rows.Count = Nothing Then
            '                dtAgregar.Rows(0)("ProduccionHora") = dtParametrosMolde.Rows(0)("ArticulosHora").ToString
            '            End If

            '            SET_PlanificacionProduccion_Programada(dtAgregar.Rows(0)("Preferencial").ToString, _
            '                                                   dtAgregar.Rows(0)("Estado").ToString, _
            '                                                   dtAgregar.Rows(0)("Prioridad").ToString, _
            '                                                   dtAgregar.Rows(0)("PrioridadMaquina").ToString, _
            '                                                   dtAgregar.Rows(0)("CodigoArticulo").ToString, _
            '                                                   dtAgregar.Rows(0)("Comentarios").ToString)


            '            DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtAgregar)

            '            'ACTUALIZAR ORDENES PRODUCCION
            '            FCN_Fill_Producciones_Ordenes()
            '        End If
            '    Case MsgBoxResult.No

            'frmTemporal_MaquinasParaTrabajar.ppCodigoPadre = pCodigoArticulo
            'frmTemporal_MaquinasParaTrabajar.ppNombre = pNombreArticulo
            'frmTemporal_MaquinasParaTrabajar.ShowDialog(Me)

            'If frmTemporal_MaquinasParaTrabajar.ppBoolean = False Then
            '    Exit Sub
            'End If


            'If Not frmTemporal_MaquinasParaTrabajar.ppMaquinaSeleccionada = String.Empty Then
            '    Dim dtAgregar As New DataTable()
            '    dtAgregar = GET_PlanificacionProduccion_Programada(pCodigoArticulo)
            '    If dtAgregar.Rows.Count = Nothing Then
            '        Exit Sub
            '    End If

            '    Dim dtParametrosMolde As New DataTable()
            '    Dim pHorasPendiente As String = String.Empty
            '    dtParametrosMolde = mSQLSelect.GET_MoldesProduccionParametros(pCodigoArticulo)

            '    dtAgregar.Rows(0)("Preferencial") = frmTemporal_MaquinasParaTrabajar.ppMaquinaSeleccionada
            '    dtAgregar.Rows(0)("PrioridadMaquina") = mSQLSelect.GET_PrioridadMaquina_Siguiente(dtAgregar.Rows(0)("Preferencial"))

            '    pHorasPendiente = mFunciones.FCN_ProduccionHoras(pCodigoArticulo, dtAgregar.Rows(0)("Pendiente"))
            '    If pHorasPendiente = Nothing Then
            '        mMensajes.msg_Informacion("No existen parametros de Produccion para [" + pCodigoArticulo + "] ")
            '    Else

            '        dtAgregar.Rows(0)("HorasPendiente") = pHorasPendiente

            '        If Not dtParametrosMolde.Rows.Count = Nothing Then
            '            dtAgregar.Rows(0)("ProduccionHora") = dtParametrosMolde.Rows(0)("ArticulosHora").ToString
            '        End If

            '        SET_PlanificacionProduccion_Programada(dtAgregar.Rows(0)("Preferencial").ToString, _
            '                                               dtAgregar.Rows(0)("Estado").ToString, _
            '                                               dtAgregar.Rows(0)("Prioridad").ToString, _
            '                                               dtAgregar.Rows(0)("PrioridadMaquina").ToString, _
            '                                               dtAgregar.Rows(0)("CodigoArticulo").ToString, _
            '                                               dtAgregar.Rows(0)("Comentarios").ToString)


            '        DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtAgregar)

            '        'ACTUALIZAR ORDENES PRODUCCION
            '        FCN_Fill_Producciones_Ordenes()
            '    End If
            'End If






            '    Case MsgBoxResult.Cancel
            '        MsgBox("Cancel")
            '        Exit Sub
            'End Select







        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub FCN_Fill_Producciones_Ordenes()
        Try
            'ACTUALIZAR 
            'LLENAR GRID DE ORDENES DE PRODUCCION
            Dim dtOrdenesProduccion As New DataTable()
            'dtOrdenesProduccion = mSQLSelect.GET_PlanificacionProduccion_Ordenes()
            dtOrdenesProduccion = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_OrdenesProduccion_Padres")
            If dtOrdenesProduccion.Rows.Count = Nothing Then
                DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion.TableName.ToString).Clear()
                Exit Sub
            End If
            DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion.TableName.ToString).Clear()
            DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion.TableName.ToString).Merge(dtOrdenesProduccion)

            grdviewOrdenesProduccion.ExpandAllGroups()
            'FCN_ProgramacionProduccion_Enumerar()

            FC_Calcular_Horas_Promedio()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub FCN_Fill_Producciones_Programadas()
        Try
            'ARTICULOS PROGRAMADOS
            Dim dtOrdenesProgramadas As New DataTable()
            dtOrdenesProgramadas = GET_PlanificacionProduccion_Programada()

            For I = 0 To dtOrdenesProgramadas.Rows.Count - 1
                dtOrdenesProgramadas.Rows(I)("HorasPendiente") = mFunciones.FCN_ProduccionHoras(dtOrdenesProgramadas.Rows(I)("CodigoArticulo"), dtOrdenesProgramadas.Rows(I)("Pendiente"))
                dtOrdenesProgramadas.Rows(I)("ProduccionHora") = mSQLSelect.GET_MoldesProduccionParametros(dtOrdenesProgramadas.Rows(I)("CodigoArticulo").ToString).Rows(0)("ArticulosHora")
            Next

            DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Clear()
            If Not dtOrdenesProgramadas.Rows.Count = Nothing Then
                DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtOrdenesProgramadas)
            End If

            grdviewProgramacionAsignados.ExpandAllGroups()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub FCN_Maquina_Cambiar()
        Try
            If grdviewProgramacionAsignados.FocusedRowHandle < 0 Then
                Exit Sub
            End If

            Dim pEstado As String = String.Empty
            pEstado = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Estado")

            If pEstado = "En Proceso" Then
                mMensajes.msg_Informacion("Para cambiar de Maquina es necesario detener el Proceso. " + Environment.NewLine + "Detenga primero el proceso y despues es posible de asignar nuevamente la maquina.")

                Exit Sub
            End If

            Dim pCodigoArticulo As String = String.Empty
            Dim pNombreArticulo As String = String.Empty
            Dim pMaquina As String = String.Empty
            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "CodigoArticulo")
            pNombreArticulo = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "NombreArticulo")
            pMaquina = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Preferencial")

            frmTemporal_MaquinasParaTrabajar.ppCodigoPadre = pCodigoArticulo
            frmTemporal_MaquinasParaTrabajar.ppNombre = pNombreArticulo
            frmTemporal_MaquinasParaTrabajar.ShowDialog(Me)

            If Not frmTemporal_MaquinasParaTrabajar.ppMaquinaSeleccionada = String.Empty Then
                grdviewProgramacionAsignados.SetRowCellValue(grdviewProgramacionAsignados.FocusedRowHandle, "Preferencial", frmTemporal_MaquinasParaTrabajar.ppMaquinaSeleccionada)

                Dim dtAgregar As New DataTable()
                dtAgregar = GET_PlanificacionProduccion_Programada(pCodigoArticulo)
                If dtAgregar.Rows.Count = Nothing Then
                    Exit Sub
                End If

                Dim dtParametrosMolde As New DataTable()
                dtParametrosMolde = mSQLSelect.GET_MoldesProduccionParametros(pCodigoArticulo)

                dtAgregar.Rows(0)("Preferencial") = frmTemporal_MaquinasParaTrabajar.ppMaquinaSeleccionada
                dtAgregar.Rows(0)("PrioridadMaquina") = mSQLSelect.GET_PrioridadMaquina_Siguiente(dtAgregar.Rows(0)("Preferencial"))
                dtAgregar.Rows(0)("HorasPendiente") = mFunciones.FCN_ProduccionHoras(pCodigoArticulo, dtAgregar.Rows(0)("Pendiente"))


                If Not dtParametrosMolde.Rows.Count = Nothing Then
                    dtAgregar.Rows(0)("ProduccionHora") = dtParametrosMolde.Rows(0)("ArticulosHora").ToString
                End If

                'ELIMINAR DE LA PROGRAMACION EL CODIGO DE ARTICULO
                mSQLDelete.DELETE_PlanificacionProduccion_Programada(dtAgregar.Rows(0)("CodigoArticulo").ToString)

                'INSERTAR DE LA PROGRAMACION EL CODIGO DE ARTICULO
                mSQLInsert.SET_PlanificacionProduccion_Programada(dtAgregar.Rows(0)("Preferencial").ToString, _
                                                       dtAgregar.Rows(0)("Estado").ToString, _
                                                       dtAgregar.Rows(0)("Prioridad").ToString, _
                                                       dtAgregar.Rows(0)("PrioridadMaquina").ToString, _
                                                       dtAgregar.Rows(0)("CodigoArticulo").ToString, _
                                                       dtAgregar.Rows(0)("Comentarios").ToString)


                DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtAgregar)

                'ACTUALIZAR ORDENES PRODUCCION
                'FCN_Fill_Producciones_Ordenes()
                Fill_OrdenesProduccion()
                FCN_Fill_Producciones_Programadas()
                FCN_ProgramacionProduccion_Enumerar()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub FCN_ProgramacionProduccion_Enumerar()
        Try
            Dim pPrioridadMaquina As Integer = 1
            For i = 0 To DsProgramacionProduccion.dsdtOrdenesProgramadas.Rows.Count - 1
                If i = 0 Then
                    DsProgramacionProduccion.dsdtOrdenesProgramadas.Rows(i)("PrioridadMaquina") = 1
                Else
                    Dim pMaquinaAnterior As String = String.Empty
                    Dim pMaquinaActual As String = String.Empty
                    pMaquinaAnterior = DsProgramacionProduccion.dsdtOrdenesProgramadas.Rows(Val(i - 1))("Preferencial")
                    pMaquinaActual = DsProgramacionProduccion.dsdtOrdenesProgramadas.Rows(i)("Preferencial")

                    If pMaquinaActual = pMaquinaAnterior Then
                        pPrioridadMaquina = pPrioridadMaquina + 1
                    Else
                        pPrioridadMaquina = 1
                    End If
                    If Not DsProgramacionProduccion.dsdtOrdenesProgramadas.Rows(i)("PrioridadMaquina") = pPrioridadMaquina Then
                        DsProgramacionProduccion.dsdtOrdenesProgramadas.Rows(i)("PrioridadMaquina") = pPrioridadMaquina
                        mSQLUpdate.UPDATE_ProgramacionProduccion_Prioridad(DsProgramacionProduccion.dsdtOrdenesProgramadas.Rows(i)("CodigoArticulo").ToString, pPrioridadMaquina.ToString)
                    End If
                End If
            Next
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Function FCN_UPDATE_ProgramacionProduccion() As Boolean
        Try
            Dim pCodigoArticulo As String = String.Empty
            Dim pPreferencial As String = String.Empty
            Dim pEstado As String = String.Empty
            Dim pPrioridad As String = String.Empty
            Dim pPrioridadMaquina As String = String.Empty
            Dim pComentarios As String = String.Empty

            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "CodigoArticulo")
            pPreferencial = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Preferencial")
            pEstado = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Estado")
            pPrioridad = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Prioridad")
            pPrioridadMaquina = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "PrioridadMaquina")
            pComentarios = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Comentarios")

            If mSQLUpdate.UPDATE_ProgramacionProduccion(pCodigoArticulo, pPreferencial, pEstado, pPrioridad, pPrioridadMaquina, pComentarios) Then
                Return True
            End If

            Return False
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
            Return False
        End Try
    End Function

    Private Sub grdviewOrdenesProduccion_DoubleClick(sender As Object, e As EventArgs) Handles grdviewOrdenesProduccion.DoubleClick
        Try
            FCN_Programacion_Agregar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdviewProgramacionAsignados_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdviewProgramacionAsignados.CellValueChanged
        Try
            FCN_UPDATE_ProgramacionProduccion()
            FCN_ProgramacionProduccion_Enumerar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdviewProgramacionAsignados_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdviewProgramacionAsignados.FocusedRowChanged
        Try
            If grdviewProgramacionAsignados.FocusedRowHandle < 0 Then
                barbtnSubir.Enabled = False
                barbtnBajar.Enabled = False
                barbtnIniciarProceso.Enabled = False
                barbtnDetener.Enabled = False
                barbtnMantenimiento1.Enabled = False
                barbtnMaquinaCambiar.Enabled = False
                Exit Sub
            End If

            Dim pPrioridad As Integer = 0
            Dim pPrioridadMaxima As Integer = 0
            Dim pMaquina As String = String.Empty
            Dim pEstado As String = String.Empty
            Dim pRowActual As Integer = 0

            pRowActual = grdviewProgramacionAsignados.FocusedRowHandle()
            pPrioridad = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "PrioridadMaquina")
            pMaquina = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Preferencial")
            pPrioridadMaxima = mSQLSelect.GET_PrioridadMaquina_Maxima(pMaquina)
            pEstado = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Estado")

            'VALIDAR SUBIR PRIORIDAD
            If pPrioridad = 1 Then
                barbtnSubir.Enabled = False
            Else
                barbtnSubir.Enabled = True
            End If

            If pPrioridad = 2 Then
                Dim pEstadoAnterior As String = String.Empty
                Dim pRowAnterior As Integer = 0

                pRowAnterior = pRowActual - 1
                pEstadoAnterior = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Estado", pRowAnterior)

                Select Case pEstadoAnterior
                    Case "En Proceso"
                        barbtnSubir.Enabled = False
                End Select

            End If

            'VALIDAR BAJAR PRIORIDAD
            If pPrioridadMaxima = pPrioridad Then
                barbtnBajar.Enabled = False
            Else
                barbtnBajar.Enabled = True
            End If

            'VALIDAR BOTONES DE EJECUCION
            Select Case pEstado
                Case "En Proceso"
                    barbtnIniciarProceso.Enabled = False
                    barbtnDetener.Enabled = True
                    barbtnMantenimiento1.Enabled = True
                    barbtnMaquinaCambiar.Enabled = False
                    barbtnBajar.Enabled = False
                Case "En Espera"
                    If pPrioridad = 1 Then
                        barbtnIniciarProceso.Enabled = True
                    Else
                        barbtnIniciarProceso.Enabled = False
                    End If
                    barbtnDetener.Enabled = False
                    barbtnMantenimiento1.Enabled = True
                    barbtnMaquinaCambiar.Enabled = True
                Case "Mantenimiento"
                    barbtnIniciarProceso.Enabled = True
                    barbtnDetener.Enabled = True
                    barbtnMantenimiento1.Enabled = False
                    barbtnMaquinaCambiar.Enabled = True
            End Select
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub grdviewProgramacionAsignados_DoubleClick(sender As Object, e As EventArgs) Handles grdviewProgramacionAsignados.DoubleClick
        Try
            FCN_Maquina_Cambiar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub printingSystem_StartPrint(ByVal sender As Object, _
ByVal e As PrintDocumentEventArgs)
        ' Set the printer name.
        e.PrintDocument.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters(0)
    End Sub

#Region "Botones"
    Private Sub barbtnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnAgregar.ItemClick
        Try
            FCN_Programacion_Agregar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnQuitar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnQuitar.ItemClick
        Try
            If Not grdviewProgramacionAsignados.FocusedRowHandle > -1 Then
                Exit Sub
            End If

            Dim pCodigoArticulo As String = String.Empty

            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "CodigoArticulo")

            If pCodigoArticulo = String.Empty Then
                Exit Sub
            End If

            If MsgBox("Desea quitar de la programación el Codigo [" + pCodigoArticulo + "]?", MsgBoxStyle.YesNo, "Quitar") = MsgBoxResult.Yes Then
                mSQLDelete.DELETE_PlanificacionProduccion_Programada(pCodigoArticulo)
            End If

            'Actualizacion de Grid
            'FCN_Fill_Producciones_Ordenes()
            Fill_OrdenesProduccion()
            FCN_Fill_Producciones_Programadas()
            FCN_ProgramacionProduccion_Enumerar()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnColumnas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnColumnas.ItemClick
        Try
            grdviewOrdenesProduccion.ShowCustomization()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnExpandir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExpandir.ItemClick
        Try
            grdviewProgramacionAsignados.ExpandAllGroups()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnColapsar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnColapsar.ItemClick
        Try
            grdviewProgramacionAsignados.CollapseAllGroups()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnIniciar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnIniciarProceso.ItemClick
        Try
            If grdviewProgramacionAsignados.IsFocusedView Then
                If grdviewProgramacionAsignados.FocusedRowHandle > -1 Then
                    Dim pEstado As String = String.Empty
                    pEstado = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Estado")
                    Select Case pEstado
                        Case "En Espera"
                            grdviewProgramacionAsignados.SetRowCellValue(grdviewProgramacionAsignados.FocusedRowHandle, "Estado", "En Proceso")
                            FCN_UPDATE_ProgramacionProduccion()
                        Case "Mantenimiento"
                            grdviewProgramacionAsignados.SetRowCellValue(grdviewProgramacionAsignados.FocusedRowHandle, "Estado", "En Proceso")
                            FCN_UPDATE_ProgramacionProduccion()
                    End Select
                End If

                barbtnIniciarProceso.Enabled = False
                barbtnDetener.Enabled = True
                barbtnBajar.Enabled = False
                barbtnMaquinaCambiar.Enabled = False

            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        Finally

        End Try
    End Sub
    Private Sub barbtnDetener_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDetener.ItemClick
        Try
            If grdviewProgramacionAsignados.IsFocusedView Then
                If grdviewProgramacionAsignados.FocusedRowHandle > -1 Then
                    Dim pEstado As String = String.Empty
                    pEstado = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Estado")
                    Select Case pEstado
                        Case "En Proceso"
                            grdviewProgramacionAsignados.SetRowCellValue(grdviewProgramacionAsignados.FocusedRowHandle, "Estado", "En Espera")
                            FCN_UPDATE_ProgramacionProduccion()
                        Case "Mantenimiento"
                            grdviewProgramacionAsignados.SetRowCellValue(grdviewProgramacionAsignados.FocusedRowHandle, "Estado", "En Espera")
                            FCN_UPDATE_ProgramacionProduccion()
                    End Select
                End If

            End If

            barbtnDetener.Enabled = False
            barbtnIniciarProceso.Enabled = True

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)

        End Try
    End Sub
    Private Sub barbtnMaquinaCambiar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnMaquinaCambiar.ItemClick
        Try
            FCN_Maquina_Cambiar()
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnMantenimiento1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnMantenimiento1.ItemClick
        Try
            If grdviewProgramacionAsignados.IsFocusedView Then
                If grdviewProgramacionAsignados.FocusedRowHandle > -1 Then
                    Dim pEstado As String = String.Empty
                    pEstado = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Estado")
                    Select Case pEstado
                        Case "En Proceso"
                            grdviewProgramacionAsignados.SetRowCellValue(grdviewProgramacionAsignados.FocusedRowHandle, "Estado", "Mantenimiento")
                            FCN_UPDATE_ProgramacionProduccion()
                        Case "En Espera"
                            grdviewProgramacionAsignados.SetRowCellValue(grdviewProgramacionAsignados.FocusedRowHandle, "Estado", "Mantenimiento")
                            FCN_UPDATE_ProgramacionProduccion()
                    End Select
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)

        End Try
    End Sub
    Private Sub barbtnSubir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnSubir.ItemClick
        Try
            If grdviewProgramacionAsignados.FocusedRowHandle < 0 Then
                Exit Sub
            End If

            Dim pPrioridadActual As Integer = 0
            Dim pPrioridadAnterior As Integer = 0
            Dim pFilaActual As Integer = grdviewProgramacionAsignados.FocusedRowHandle
            Dim pFilaAnterior As Integer = pFilaActual - 1
            Dim pCodigoActual As String = String.Empty
            Dim pCodigoAnterior As String = String.Empty

            pPrioridadActual = Val(mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "PrioridadMaquina"))
            pPrioridadAnterior = pPrioridadActual - 1
            pCodigoActual = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "CodigoArticulo", pFilaActual)
            pCodigoAnterior = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "CodigoArticulo", pFilaAnterior)

            If pPrioridadActual = 1 Then
                mMensajes.msg_Informacion("No puede Subir de prioridad este Componente [" + pCodigoActual + "].")
                Exit Sub
            End If

            'mSQLUpdate.UPDATE_ProgramacionProduccion_Prioridad(pCodigoActual, pPrioridadAnterior.ToString)
            mConexion.ConectarSQLGT_DT("APGProduccion.dbo.sp_UPDATE_ProgramacionProduccion_Prioridad " + pPrioridadAnterior.ToString + " ," + pCodigoActual)

            'mSQLUpdate.UPDATE_ProgramacionProduccion_Prioridad(pCodigoAnterior, pPrioridadActual.ToString)
            mConexion.ConectarSQLGT_DT("APGProduccion.dbo.sp_UPDATE_ProgramacionProduccion_Prioridad " + pPrioridadActual.ToString + " ," + pCodigoAnterior)

            FCN_Fill_Producciones_Programadas()
            Dim pRow As Integer = 0

            pRow = grdviewProgramacionAsignados.LocateByValue("CodigoArticulo", pCodigoActual)
            grdviewProgramacionAsignados.FocusedRowHandle = pRow


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnBajar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnBajar.ItemClick
        Try
            If grdviewProgramacionAsignados.FocusedRowHandle < 0 Then
                Exit Sub
            End If

            Dim pPrioridadActual As Integer = 0
            Dim pPrioridadSiguiente As Integer = 0
            Dim pPrioridadMaxima As Integer = 0
            Dim pFilaActual As Integer = grdviewProgramacionAsignados.FocusedRowHandle
            Dim pFilaSiguiente As Integer = pFilaActual + 1
            Dim pCodigoActual As String = String.Empty
            Dim pCodigoSiguiente As String = String.Empty
            Dim pMaquina As String = String.Empty

            pPrioridadActual = Val(mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "PrioridadMaquina"))
            pPrioridadSiguiente = pPrioridadActual + 1
            pCodigoActual = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "CodigoArticulo", pFilaActual)
            pCodigoSiguiente = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "CodigoArticulo", pFilaSiguiente)
            pMaquina = mFunciones.FCN_GetCellValue(grdviewProgramacionAsignados, "Preferencial", pFilaActual)

            pPrioridadMaxima = mSQLSelect.GET_PrioridadMaquina_Maxima(pMaquina)

            If pPrioridadActual = pPrioridadMaxima Then
                mMensajes.msg_Informacion("No puede Bajar de prioridad este Componente [" + pCodigoActual + "].")
                Exit Sub
            End If

            mSQLUpdate.UPDATE_ProgramacionProduccion_Prioridad(pCodigoActual, pPrioridadSiguiente.ToString)
            mSQLUpdate.UPDATE_ProgramacionProduccion_Prioridad(pCodigoSiguiente, pPrioridadActual.ToString)

            FCN_Fill_Producciones_Programadas()
            Dim pRow As Integer = 0

            pRow = grdviewProgramacionAsignados.LocateByValue("CodigoArticulo", pCodigoActual)
            grdviewProgramacionAsignados.FocusedRowHandle = pRow


        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnProgramacionGrafica_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnProgramacionGrafica.ItemClick
        Try
            frmTemporal_ProgramacionGrafica.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnImprimirGrid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnImprimirGrid.ItemClick
        Try
            If grdviewOrdenesProduccion.IsFocusedView() Then
                grdviewOrdenesProduccion.ShowRibbonPrintPreview()
            ElseIf grdviewProgramacionAsignados.IsFocusedView() Then
                grdviewProgramacionAsignados.ShowRibbonPrintPreview()
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnExportarXlsx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnExportarXlsx.ItemClick
        Try
            If grdviewOrdenesProduccion.IsFocusedView() Then
                sfdSave.Filter = "Archivos Excel | *.xlsx"
                If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    grdviewOrdenesProduccion.ExportToXlsx(sfdSave.FileName)
                End If
            ElseIf grdviewProgramacionAsignados.IsFocusedView() Then
                sfdSave.Filter = "Archivos Excel | *.xlsx"
                If sfdSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    grdviewProgramacionAsignados.ExportToXlsx(sfdSave.FileName)
                End If
            End If
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnProgramacionAutomatica_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnProgramacionAutomatica.ItemClick
        Try

            If Not ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.ShowWaitForm() : End If


            'TRAER EL LISTADO DE CP PARA ASIGNAR
            Dim dtCPSeleccionados As New DataTable()


            dtCPSeleccionados = mFunciones.FCN_XTRAGRID_GetColumn_DataTable(grdviewOrdenesProduccion, "CodigoArticulo")

            If dtCPSeleccionados.Rows.Count = Nothing Then
                Exit Sub
            End If

            'TRAER ORDEN DE MAQUINAS DISPONIBLES PARA EL CP
            Dim pCodigoPadre As String = String.Empty
            Dim pCodigosPendientes As Integer = 0
            For i = 0 To dtCPSeleccionados.Rows.Count - 1
                pCodigosPendientes = (dtCPSeleccionados.Rows.Count - 1) - i

                ssmEsperar.SetWaitFormCaption("Procesando...")

                pCodigoPadre = dtCPSeleccionados.Rows(i)("CodigoArticulo").ToString 'CP Seleccionado
                ssmEsperar.SetWaitFormCaption(pCodigoPadre + " " + pCodigosPendientes.ToString)


                Dim dt As New DataTable()
                'dt = mSQLSelect.GET_Temporal_MaquinasParaTrabajar(pCodigoPadre)
                dt = mConexion.ConectarSQLGT_DT("Exec APGProduccion.dbo.sp_MaquinasCompatibles " + pCodigoPadre)

                If Not dt.Rows.Count = Nothing Then
                    Dim pHorasPendientes As String = String.Empty
                    For j = 0 To dt.Rows.Count - 1
                        pHorasPendientes = Nothing

                        ssmEsperar.SetWaitFormDescription("Horas Pendientes...")
                        Dim dtHorasPendientes = mConexion.ConectarSQLGT_DT("Exec APGProduccion.dbo.sp_Maquina_HorasPendienteTrabajo " + dt.Rows(j)("Maquina").ToString)
                        If Not dtHorasPendientes.Rows.Count = Nothing Then
                            pHorasPendientes = dtHorasPendientes.Rows(0)(0).ToString
                        End If

                        If pHorasPendientes = Nothing Then
                            dt.Rows(j)("HorasPendientes") = 0
                        Else
                            dt.Rows(j)("HorasPendientes") = Val(pHorasPendientes)
                        End If
                    Next

                    'ORDER BY CARGA DE ARTICULOS
                    'ORDER BY PRIORIDAD
                    dt.DefaultView.Sort = "HorasPendientes ASC,Prioridad ASC"
                    dt = dt.DefaultView.ToTable

                    'ASIGNAR CP A MAQUINA

                    ssmEsperar.SetWaitFormDescription("Agregar Trabajo...")
                    Dim dtAgregar As New DataTable()
                    'dtAgregar = GET_PlanificacionProduccion_Programada(pCodigoPadre)
                    dtAgregar = mConexion.ConectarSQLGT_DT("Exec APGProduccion.dbo.sp_ProgramacionProduccion_Agregar " + pCodigoPadre)

                    If Not dtAgregar.Rows.Count = Nothing Then

                        If dtAgregar.Rows(0)("Pendiente") > 0 Then
                            Dim dtParametrosMolde As New DataTable()
                            'dtParametrosMolde = mSQLSelect.GET_MoldesProduccionParametros(pCodigoPadre)
                            dtParametrosMolde = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_ProduccionParametros " + pCodigoPadre)

                            dtAgregar.Rows(0)("Preferencial") = dt.Rows(0)("Maquina")
                            'dtAgregar.Rows(0)("PrioridadMaquina") = mSQLSelect.GET_PrioridadMaquina_Siguiente(dtAgregar.Rows(0)("Preferencial"))
                            Dim dtPrioridadMaquina As New DataTable()
                            dtPrioridadMaquina = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_MaquinaPrioridad_Siguiente " + dtAgregar.Rows(0)("Preferencial").ToString)
                            dtAgregar.Rows(0)("PrioridadMaquina") = dtPrioridadMaquina.Rows(0)(0)

                            Dim pPendiente As String = String.Empty
                            pPendiente = mFunciones.FCN_ProduccionHoras(pCodigoPadre, dtAgregar.Rows(0)("Pendiente"))
                            If Val(pPendiente) > 0 Then
                                dtAgregar.Rows(0)("HorasPendiente") = pPendiente
                            Else
                                dtAgregar.Rows(0)("HorasPendiente") = 0
                            End If


                            If Not dtParametrosMolde.Rows.Count = Nothing Then
                                dtAgregar.Rows(0)("ProduccionHora") = dtParametrosMolde.Rows(0)("ArticulosHora").ToString
                            End If
                            ssmEsperar.SetWaitFormDescription("Grabando...")
                            If pPendiente > 0 Then
                                SET_PlanificacionProduccion_Programada(dtAgregar.Rows(0)("Preferencial").ToString, _
                                                                dtAgregar.Rows(0)("Estado").ToString, _
                                                                dtAgregar.Rows(0)("Prioridad").ToString, _
                                                                dtAgregar.Rows(0)("PrioridadMaquina").ToString, _
                                                                dtAgregar.Rows(0)("CodigoArticulo").ToString, _
                                                                dtAgregar.Rows(0)("Comentarios").ToString)


                                DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtAgregar)

                                ssmEsperar.SetWaitFormDescription("Actualizando Grid...")
                                'ACTUALIZAR ORDENES PRODUCCION
                                'FCN_Fill_Producciones_Ordenes()
                                Fill_OrdenesProduccion()
                            End If
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
            mMensajes.msg_Error(ex.Message.ToString)
        Finally
            If ssmEsperar.IsSplashFormVisible() Then : ssmEsperar.CloseWaitForm() : End If
        End Try
    End Sub
    Private Sub barbtnProgramacionFinal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnProgramacionFinal.ItemClick
        Try
            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptProgramacionProduccionFinal
            RPTdocumento.DataSource = Me.DsProgramacionProduccion
            RPTdocumento.DataMember = Me.DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString
            ''dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)


            'mFunciones.ExportToPNG(RPTdocumento, "Reporte_ProgramacionProduccionFinal")
            'mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("Prueba", _
            '                                            "Programacion Produccion Final", _
            '                                            "Detalle de Programacion", _
            '                                            "Reporte_ProgramacionProduccionFinal")

            PrintTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
    Private Sub barbtnEmail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEmail.ItemClick

        Try
            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptProgramacionProduccionFinal
            RPTdocumento.DataSource = Me.DsProgramacionProduccion
            RPTdocumento.DataMember = Me.DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString
            ''dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)

            mFunciones.ExportToPNG(RPTdocumento, "Reporte_ProgramacionProduccionFinal")
            mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("Prueba", _
                                                        "Programacion Produccion Final " + My.Settings.log_Usuario.ToString + " [ " + DateTime.Now.ToString + " ]", _
                                                        "Detalle de Programacion", _
                                                        "Reporte_ProgramacionProduccionFinal")

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
#End Region

    Private Sub grdProgramacionAsignados_Click(sender As Object, e As EventArgs) Handles grdProgramacionAsignados.Click

    End Sub

    Private Sub barbtnDetalleColores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnDetalleColores.ItemClick
        Try
            Dim pCodigoPadre As String = String.Empty


            If grdviewOrdenesProduccion.IsFocusedView() Then
                pCodigoPadre = grdviewOrdenesProduccion.GetRowCellValue(grdviewOrdenesProduccion.FocusedRowHandle, "CodigoArticulo")
            ElseIf grdviewProgramacionAsignados.IsFocusedView Then
                pCodigoPadre = grdviewProgramacionAsignados.GetRowCellValue(grdviewProgramacionAsignados.FocusedRowHandle, "CodigoArticulo")
            End If


            If pCodigoPadre = String.Empty Then
                Exit Sub
            End If

            frmPlanPrioridadesAlmacen_Hijos.ppCodigoPadre = pCodigoPadre
            frmPlanPrioridadesAlmacen_Hijos.ShowDialog(Me)
        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnGrupoMaquina_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnGrupoMaquina.ItemClick
        Try
            If grdviewOrdenesProduccion.FocusedRowHandle < 0 Then
                Exit Sub
            End If

            Dim pCodigoArticulo As String = String.Empty
            Dim pNombreArticulo As String = String.Empty
            Dim pMaquina As String = String.Empty
            Dim pFaltante As String = String.Empty

            'pFaltante = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccion, "Pendiente")
            'If pFaltante < 1 Then
            '    mMensajes.msg_Informacion("Este Componente no tiene produccion Pendiente.")
            '    Exit Sub
            'End If


            pCodigoArticulo = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccion, "CodigoArticulo")
            pNombreArticulo = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccion, "NombreArticulo")
            pMaquina = mFunciones.FCN_GetCellValue(grdviewOrdenesProduccion, "Preferencial")


            '--------Inicia nuevo Proceso'-----------------
            '----------------------------------------------
            frmTemporal_MaquinasParaTrabajar.ppTipoProceso = "G"
            frmTemporal_MaquinasParaTrabajar.ppCodigoPadre = pCodigoArticulo
            frmTemporal_MaquinasParaTrabajar.ppNombre = pNombreArticulo
            frmTemporal_MaquinasParaTrabajar.ShowDialog(Me)

            If frmTemporal_MaquinasParaTrabajar.ppBoolean = False Then
                Exit Sub
            End If


            If Not frmTemporal_MaquinasParaTrabajar.ppMaquinaSeleccionada = String.Empty Then
                Dim dtAgregar As New DataTable()
                dtAgregar = GET_PlanificacionProduccion_Programada(pCodigoArticulo)
                If dtAgregar.Rows.Count = Nothing Then
                    Exit Sub
                End If

                Dim dtParametrosMolde As New DataTable()
                Dim pHorasPendiente As String = String.Empty
                dtParametrosMolde = mSQLSelect.GET_MoldesProduccionParametros(pCodigoArticulo)

                dtAgregar.Rows(0)("Preferencial") = frmTemporal_MaquinasParaTrabajar.ppMaquinaSeleccionada
                dtAgregar.Rows(0)("PrioridadMaquina") = mSQLSelect.GET_PrioridadMaquina_Siguiente(dtAgregar.Rows(0)("Preferencial"))

                pHorasPendiente = mFunciones.FCN_ProduccionHoras(pCodigoArticulo, dtAgregar.Rows(0)("Pendiente"))
                If pHorasPendiente = Nothing Then
                    mMensajes.msg_Informacion("No existen parametros de Produccion para [" + pCodigoArticulo + "] ")
                Else

                    dtAgregar.Rows(0)("HorasPendiente") = pHorasPendiente

                    If Not dtParametrosMolde.Rows.Count = Nothing Then
                        dtAgregar.Rows(0)("ProduccionHora") = dtParametrosMolde.Rows(0)("ArticulosHora").ToString
                    End If

                    SET_PlanificacionProduccion_Programada(dtAgregar.Rows(0)("Preferencial").ToString, _
                                                           dtAgregar.Rows(0)("Estado").ToString, _
                                                           dtAgregar.Rows(0)("Prioridad").ToString, _
                                                           dtAgregar.Rows(0)("PrioridadMaquina").ToString, _
                                                           dtAgregar.Rows(0)("CodigoArticulo").ToString, _
                                                           dtAgregar.Rows(0)("Comentarios").ToString)


                    DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProgramadas.TableName.ToString).Merge(dtAgregar)

                    'ACTUALIZAR ORDENES PRODUCCION
                    'FCN_Fill_Producciones_Ordenes()
                    Fill_OrdenesProduccion()
                End If
            End If

            '------Termina nuevo proceso.





        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnEliminar.ItemClick
        Try
            If grdviewProgramacionAsignados.OptionsSelection.MultiSelect = False Then
                grdviewProgramacionAsignados.OptionsSelection.MultiSelect = True
            ElseIf grdviewProgramacionAsignados.OptionsSelection.MultiSelect = True Then
                If grdviewProgramacionAsignados.SelectedRowsCount > 0 Then

                    If MsgBox("Desea eliminar las filas seleccionadas?", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.No Then
                        Exit Sub
                    End If

                    For i = 0 To grdviewProgramacionAsignados.RowCount - 1
                        If grdviewProgramacionAsignados.IsRowSelected(i) Then
                            If grdviewProgramacionAsignados.IsGroupRow(i) = False Then
                                If mSQLSelect.GET_Codigo_EstadoProceso(grdviewProgramacionAsignados.GetRowCellValue(i, "CodigoArticulo")).Rows(0)(0) <> "1" Then
                                    mSQLDelete.DELETE_PlanificacionProduccion_Programada(grdviewProgramacionAsignados.GetRowCellValue(i, "CodigoArticulo"))
                                End If
                            End If
                        End If

                    Next

                    'Actualizacion de Grid
                    'FCN_Fill_Producciones_Ordenes()
                    Fill_OrdenesProduccion()

                    FCN_Fill_Producciones_Programadas()
                    FCN_ProgramacionProduccion_Enumerar()
                    grdviewProgramacionAsignados.OptionsSelection.MultiSelect = False
                Else
                    grdviewProgramacionAsignados.OptionsSelection.MultiSelect = False
                End If
            End If




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub barbtnVistaDefault_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnVistaDefault.ItemClick
        Try

        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub

    Private Sub grdviewOrdenesProduccion_CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles grdviewOrdenesProduccion.CustomSummaryCalculate


        Dim pTotal As Integer = 0
        Dim SumaryId As Integer = Convert.ToInt32(grdviewOrdenesProduccion.Tag)

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
            pTotal = 0
        End If

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
            Select Case SumaryId
                Case 1
                    pTotal = pTotal + 1
                    Exit Sub
            End Select
        End If

        If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then
            e.TotalValue = pTotal
        End If







        'Dim pItem As New DevExpress.XtraGrid.GridSummaryItem

        ''pItem.FieldName = "GrupoMaquina"
        'If e.IsGroupSummary And e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then

        '    'e.TotalValue = grdviewOrdenesProduccion.GroupSummary("GrupoMaquina").SummaryType = DevExpress.Data.SummaryItemType.Average
        'End If


    End Sub

    Private Sub frmProgramacionProduccion_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub bwsVista_GetItemData(sender As Object, e As EventArgs) Handles bwsVista.GetItemData

    End Sub

    Private Sub bwsVista_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bwsVista.ItemClick
        'MsgBox(e.Item.Name.ToString)
    End Sub

    Private Sub wsmVistasOrdenes_BeforeApplyWorkspace(sender As Object, e As EventArgs) Handles wsmVistasOrdenes.BeforeApplyWorkspace

        'MsgBox(wsmVistasOrdenes.RecentWorkspaces(0).Name.ToString)

        'MsgBox(wsmVistasOrdenes.Workspaces.LastIndexOf(wsmVistasOrdenes.Workspaces.Item()).ToString)




    End Sub

    
    'Private Sub grdviewOrdenesProduccion_RowCountChanged(sender As Object, e As EventArgs) Handles grdviewOrdenesProduccion.RowCountChanged
    '    Try
    '        FC_Calcular_Horas_Promedio()
    '    Catch ex As Exception
    '        mMensajes.msg_Error(ex.Message.ToString)
    '    End Try
    'End Sub

    Private Sub barbtnOrdenesProduccion_Todas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbtnOrdenesProduccion_Todas.ItemClick
        Try
            'LLENAR GRID DE ORDENES DE PRODUCCION
            Dim dtOrdenesProduccion As New DataTable()
            'dtOrdenesProduccion = mSQLSelect.GET_PlanificacionProduccion_Ordenes()
            dtOrdenesProduccion = mConexion.ConectarSQLGT_DT("EXEC APGProduccion.dbo.sp_OrdenesProduccion_Padres_Todas")


            If dtOrdenesProduccion.Rows.Count = Nothing Then
                DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion.TableName.ToString).Clear()
                'Exit Sub
            End If


            For irow = 0 To dtOrdenesProduccion.Rows.Count - 1  'RECORRE TABLA CON DATOS DE ARTICULOS PADRE
                Dim dtParametrosMolde As New DataTable()
                Dim pHorasPendiente As String = String.Empty
                dtParametrosMolde = mSQLSelect.GET_MoldesProduccionParametros(dtOrdenesProduccion.Rows(irow)("CodigoArticulo")) 'OBTIENE PARAMETROS DE TIEMPO SEGUN LA ROW

                'SI TRAE DATOS GRABAR EN TABLA PARAMETROS DE PRODUCCION POR HORA Y HORAS PENDIENTES
                If Not dtParametrosMolde.Rows.Count = Nothing Then

                    dtOrdenesProduccion.Rows(irow)("ProduccionHora") = dtParametrosMolde.Rows(0)("ArticulosHora")

                    'If hay articulos pendientes de produccion, calcula las horas pendientes de trabajo.
                    If dtOrdenesProduccion.Rows(irow)("Pendiente") > 0 Then
                        Dim pArticulosHora As Double = Val(dtParametrosMolde.Rows(0)("ArticulosHora"))
                        If pArticulosHora > 0 Then
                            pHorasPendiente = Val(dtOrdenesProduccion.Rows(irow)("Pendiente")) / pArticulosHora
                            dtOrdenesProduccion.Rows(irow)("HorasPendiente") = CInt(pHorasPendiente)
                        End If
                    End If

                End If
            Next

            DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.TableName.ToString).Clear()
            DsProgramacionProduccion.Tables(DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.TableName.ToString).Merge(dtOrdenesProduccion)
            FC_Calcular_Horas_Promedio_Todas()


            Dim RPTdocumento As DevExpress.XtraReports.UI.XtraReport = New xrptProgramacionProduccion_Todas
            RPTdocumento.DataSource = Me.DsProgramacionProduccion
            RPTdocumento.DataMember = Me.DsProgramacionProduccion.dsdtOrdenesProduccion_Todas.TableName.ToString
            ''dvwReportes.DocumentSource = RPTdocumento
            Dim PrintTool As New ReportPrintTool(RPTdocumento)


            'mFunciones.ExportToPNG(RPTdocumento, "Reporte_ProgramacionProduccionFinal")
            'mSendEmail.FCN_Email_EnviarConAdjuntoDeFondo("Prueba", _
            '                                            "Programacion Produccion Final", _
            '                                            "Detalle de Programacion", _
            '                                            "Reporte_ProgramacionProduccionFinal")

            PrintTool.ShowRibbonPreviewDialog()




        Catch ex As Exception
            mMensajes.msg_Error(ex.Message.ToString)
        End Try
    End Sub
End Class