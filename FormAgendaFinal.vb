Imports System.IO

Public Class FormAgendaFinal
      'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image

    'variables de archivos
    Dim strPathAgenda As String
    Dim strArchivoIndice As String
    Dim strArchivoIndiceProximos As String
    Dim strArchivoControlDiario As String
    Dim strArchivoControlMensual As String
    Dim strArchivoControlAnual As String
    Dim strArchivoControlAnualIslr As String
    Dim strArchivoPropioAGD As String

    'variables de fechas
    Dim dateFechaConsultadaDia As Date
    Dim dateMesConsultado As Date
    Dim dateAñoConsultado As Date

    'variables de control de archivos
    Dim FS As FileStream
    Dim BW As BinaryWriter
    Dim BR As BinaryReader
    Dim REnum As IEnumerator
    Dim C As Integer

    'variables del entorno
    Dim booIniciando As Boolean
    Dim strMesSeleccionadoCadena As String
    Dim strMesSeleccionadoNumero As Integer
    Dim strAñoseleccionadoFecha As Date
    Dim strAñoSeleccionadoNumerodeAño As Integer 'exclusivo para calculo de años
    Dim strAñoSeleccionadoNumerodeMes As Integer 'exclusivo para calulo de meses

    Dim strArchivoControlMensualdelDia As String 'para verificar las fechas donde hay consultas


    'estructuras
    Dim DP As Form1.DatosPersonales

    'variables de structura y array correspondientes nuevas en pantalla

    'Dim Tipo01 As EstructuraTipo01
    'Dim Tipo02 As EstructuraTipo02
    Dim estControlDiaMesAno As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual
    Dim estControlProximo As Form1.TablaDeArchivosDeProximosControles
    Dim estIndiceProxControles As Form1.TablaDeArchivosDeIndiceDeProximosControles

    Dim alsControlesDelDia As New ArrayList()
    Dim alsControlesDelMes As New ArrayList()
    Dim alsControlesDelAño As New ArrayList()

    Dim alsControlesProximos As New ArrayList()
    Dim alsIndiceDeProximosControles As New ArrayList()

    Dim ArraydeLineas As New ArrayList()
    Dim ArraydeLineasVencidas As New ArrayList()
    'estas variables son de la parte de proximos
    Dim ArrayNumerosOrdenados As New ArrayList() 'array ordenado de la lisbox despues de puesto en orden de fecha
    Dim ArrayNumerosOrdenadosVencidos As New ArrayList() 'array ordenado vencidos de la lisbox despues de puesto en orden de fecha
    Structure Orden
        Dim NumeroHistoria As String
        Dim FechaProxima As String
    End Structure
    Dim P As New Orden()

    Structure OrdenAño
        Dim NumeroHistoria As String
        Dim FechaControl As String
    End Structure
    Dim OA As New OrdenAño()
    Dim ArrayNumerosAñoOrdenados As New ArrayList()

    Structure OrdenMes
        Dim NumeroHistoria As String
        Dim FechaControl As String
    End Structure
    Dim OM As New OrdenMes()
    Dim ArrayNumerosMesOrdenados As New ArrayList()

    Structure BaseDatosIndiceHistorias
        Dim NumeroHistoria As String
        Dim NombrePaciente As String
        Dim CedulaPaciente As String
    End Structure
    Dim H As New BaseDatosIndiceHistorias()
    Dim ArrayHistorias As New ArrayList()

    Structure OrdenPaciente
        Dim NumeroHistoria As String
        Dim NombrePaciente As String
    End Structure
    Dim OP As New OrdenPaciente()
    Dim arrayPacientesFiltrados As New ArrayList()

    Dim CDMA As New Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual()
    Dim CP As New Form1.TablaDeArchivosDeProximosControles()
    Dim IP As New Form1.TablaDeArchivosDeIndiceDeProximosControles()
    Dim PA As New Form1.TablaDePagos


    '0000000000000000000 Variables de las IQ

    Dim strPathIQ As String

    'variables de la vista de dias
    Dim dateFechaSeleccionadaIQvistaDia As Date
    Dim strPathIQsubVistaDia As String
    Dim strAñoSeleccionadoIQvistadia As String
    Dim strMesSeleccionadoIQvistadia As String
    Dim strDiaSeleccionadoIQvistadia As String
    Dim strArchivoIQDia As String
    Dim strArchivoIQMesDelDiaSeleccionado As String

    'variables de la vista de meses
    Dim dateFechaSeleccionadaIQvistames As Date
    Dim strPathIQsubVistames As String
    Dim strAñoSeleccionadoIQvistames As Integer
    Dim strAñoSeleccionadoIQvistamesCadena As String
    Dim strMesSeleccionadoIQvistames As Integer
    Dim strMesSeleccionadoIQvistamesCadena As String
    Dim strArchivoIQMes As String

    'variables de la vista de año
    Dim dateFechaSeleccionadaIQvistaaño As Date
    Dim strPathIQsubVistaaño As String
    Dim strAñoSeleccionadoIQvistaaño As String
    Dim strArchivoIQaño As String

    'variables de control de la estructura de IQ
    Dim IQ As Form1.TablaDeIntervenciones
    Dim alsIntervencionesDelMesDelDiaSeleccionado As New ArrayList
    Dim alsIntervencionesDelDia As New ArrayList()
    Dim alsDeIntervencionesDelMes As New ArrayList()
    Dim alsDeIntervencionesDelAño As New ArrayList()

    'variables de orden de vista mes de IQs
    Structure OrdenMesIQ
        Dim FechaControl As String
        Dim Nombre As String
        Dim TipoIQ As String
    End Structure
    Dim OMiq As New OrdenMesIQ()
    Dim alsMesOrdenadosIQ As New ArrayList()

    'variables de orden de vista año de IQs
    Structure OrdenAñoIQ
        Dim FechaControl As String
        Dim Nombre As String
        Dim TipoIQ As String
        Dim PendienteIQ As String
    End Structure
    Dim OAiq As New OrdenAñoIQ()
    Dim alsAñoOrdenadosIQ As New ArrayList()


    '0000000000000000000 Variables de los Pagos 000000000000000000000

    Dim strPathPAGO As String
    Dim estPAGO As Form1.TablaDePagos

    'variables de la vista de dias
    Dim FechaSeleccionadaPAGOvistaDia As Date
    Dim PathPAGOsubVistaDia As String
    Dim AñoSeleccionadoPAGOvistadia As String
    Dim MesSeleccionadoPAGOvistadia As String
    Dim DiaSeleccionadoPAGOvistadia As String
    Dim archivoPAGODia As String
    Dim archivoPAGOConsultasDelDia As String
    'variables de control de la estructura de PAGOS
    Dim arrayDePAGODia As New ArrayList()
    Dim alsPAGOSdelDiaOrdenados As System.Collections.Generic.IEnumerable(Of Historias.Form1.TablaDePagos)

    'variables de la vista de Meses
    Dim FechaSeleccionadaPAGOvistaMes As Date
    Dim PathPAGOsubVistaMes As String
    Dim AñoSeleccionadoPAGOvistaMes As String
    Dim MesSeleccionadoPAGOvistaMes As String
    Dim DiaSeleccionadoPAGOvistaMes As String
    Dim archivoPAGOMes As String
    Dim archivoPAGOConsultasDelMes As String
    'variables de control de la estructura de PAGOS
    Dim arrayDePAGOMes As New ArrayList()
    Dim alsPAGOSdelMesOrdenados As System.Collections.Generic.IEnumerable(Of Historias.Form1.TablaDePagos)

    'variables de la vista de AÑOes
    Dim FechaSeleccionadaPAGOvistaAÑO As Date
    Dim PathPAGOsubVistaAÑO As String
    Dim AñoSeleccionadoPAGOvistaAÑO As String
    Dim DiaSeleccionadoPAGOvistaAÑO As String
    Dim archivoPAGOAÑO As String
    Dim archivoPAGOConsultasDelAÑO As String
    'variables de control de la estructura de PAGOS
    Dim arrayDePAGOAÑO As New ArrayList()
    Dim alsPAGOSdelAÑOOrdenados As System.Collections.Generic.IEnumerable(Of Historias.Form1.TablaDePagos)

    'variables para el calculo de los datos de islr automatico
    Dim FechaSeleccionadaPAGOvistaAÑOISLR As Date
    Dim PathPAGOsubVistaAÑOISLR As String
    Dim AñoSeleccionadoPAGOvistaAÑOISLR As String
    Dim archivoPAGOAÑOislr As String
    Dim archivoPAGOConsultasDelAÑOislr As String
    'variables de control de la estructura de PAGOS ISLR
    Dim arrayDePAGOañoISLR As New ArrayList()
    Dim alsPAGOSdelAÑOIslrOrdenados As System.Collections.Generic.IEnumerable(Of Historias.Form1.TablaDePagos)
    'datos para calcular el enero del año siguiente
    Dim FechaSeleccionadaPAGOvistaAÑOsiguienteISLR As Date
    Dim PathPAGOsubVistaAÑOsiguienteISLR As String
    Dim AñoSeleccionadoPAGOvistaAÑOsiguienteISLR As String
    Dim archivoPAGOAÑOsiguienteislr As String
    Dim arrayDePAGOañoSiguienteISLR As New ArrayList()
    Dim alsPAGOSdelAÑOsiguienteIslrOrdenados As System.Collections.Generic.IEnumerable(Of Historias.Form1.TablaDePagos)

    '0000000000000000000000000variables de la ficha de honorarios 00000000000000000

    Dim FechaSeleccionadaHonorarios As Date
    Dim AñoseleccionadoHonorarios As String
    Dim ArchivoHonorariosMesIQ As String
    Dim ArchivoHonorariosMesCON As String
    Dim decFichaHonPendientesIQ As Decimal
    Dim decFichaHonPagadosIQ As Decimal
    Dim decFichaHonConsultas As Decimal

    'variables comunes de honorarios
    Dim decHonorariosPendientes As Decimal
    Dim decHonorariosPagados As Decimal
    Dim decHonorariosTotales As Decimal

    Dim archivoHonIQene As String
    Dim archivoHonIQfeb As String
    Dim archivoHonIQmar As String
    Dim archivoHonIQabr As String
    Dim archivoHonIQmay As String
    Dim archivoHonIQjun As String
    Dim archivoHonIQjul As String
    Dim archivoHonIQago As String
    Dim archivoHonIQsep As String
    Dim archivoHonIQoct As String
    Dim archivoHonIQnov As String
    Dim archivoHonIQdic As String
    Dim archivoHonCONene As String
    Dim archivoHonCONfeb As String
    Dim archivoHonCONmar As String
    Dim archivoHonCONabr As String
    Dim archivoHonCONmay As String
    Dim archivoHonCONjun As String
    Dim archivoHonCONjul As String
    Dim archivoHonCONago As String
    Dim archivoHonCONsep As String
    Dim archivoHonCONoct As String
    Dim archivoHonCONnov As String
    Dim archivoHonCONdic As String

    'variables ficha de pagos
    Dim strPagosPathPAGO As String
    Dim strPagosPathIQ As String
    Dim strPagosPathAGENDA As String
    Dim datPagosFechaSeleccionada As Date
    Dim intPagosAñoSeleccionado As Integer
    Dim strPagosArchivoMesIQ As String
    Dim strPagosArchivoMesPAGO As String
    Dim strPagosArchivoMesCON As String
    'variables generales para todos los meses en ficha
    Dim decPagosIQPendienteMES As Decimal
    Dim decPagosIQPagadosMES As Decimal
    Dim decPagosIQTotalMES As Decimal
    Dim decPagosConsultasMES As Decimal
    Dim decPagosPagoSDMES As Decimal
    Dim decPagosRetencionesMES As Decimal
    Dim decPagosISLRmes As Decimal
    Dim decPagosOtrasRetMes As Decimal

    'variables de Archivos x mes IQ
    Dim strPagosArchivo01IQ As String
    Dim strPagosArchivo02IQ As String
    Dim strPagosArchivo03IQ As String
    Dim strPagosArchivo04IQ As String
    Dim strPagosArchivo05IQ As String
    Dim strPagosArchivo06IQ As String
    Dim strPagosArchivo07IQ As String
    Dim strPagosArchivo08IQ As String
    Dim strPagosArchivo09IQ As String
    Dim strPagosArchivo10IQ As String
    Dim strPagosArchivo11IQ As String
    Dim strPagosArchivo12IQ As String
    'variables de Archivos x mes PAGO
    Dim strPagosArchivo01PAGO As String
    Dim strPagosArchivo02PAGO As String
    Dim strPagosArchivo03PAGO As String
    Dim strPagosArchivo04PAGO As String
    Dim strPagosArchivo05PAGO As String
    Dim strPagosArchivo06PAGO As String
    Dim strPagosArchivo07PAGO As String
    Dim strPagosArchivo08PAGO As String
    Dim strPagosArchivo09PAGO As String
    Dim strPagosArchivo10PAGO As String
    Dim strPagosArchivo11PAGO As String
    Dim strPagosArchivo12PAGO As String
    'variables de Archivos x mes CON
    Dim strPagosArchivo01CON As String
    Dim strPagosArchivo02CON As String
    Dim strPagosArchivo03CON As String
    Dim strPagosArchivo04CON As String
    Dim strPagosArchivo05CON As String
    Dim strPagosArchivo06CON As String
    Dim strPagosArchivo07CON As String
    Dim strPagosArchivo08CON As String
    Dim strPagosArchivo09CON As String
    Dim strPagosArchivo10CON As String
    Dim strPagosArchivo11CON As String
    Dim strPagosArchivo12CON As String




    'variables para la impresion
    Dim LargoDelNumeroDeHistoria As Integer
    Public Shared ArrayListaControlesMes As New ArrayList()
    Public Shared ArrayListaControlesAño As New ArrayList()
    Public Shared ArrayListaControlesVigentes As New ArrayList()
    Public Shared ArrayListaControlesVencidos As New ArrayList()
    Public Shared ArrayListaPacientes As New ArrayList()
    Public Shared ArrayListaIQmes As New ArrayList()
    Public Shared ArrayListaIQaño As New ArrayList()

    Dim booSeEstaCargandoElForm As Boolean


    Private Sub FormAgenda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If booSeEstaCargandoElForm = True Then
            ArrancaPues()
            booSeEstaCargandoElForm = False
        End If

    End Sub


    Private Sub FormAgenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        booSeEstaCargandoElForm = True

    End Sub

    Private Sub botActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botActualizar.Click
        ArrancaPues()
    End Sub




    Private Sub ArrancaPues()

        BarraEstadoAgenda.Text = ""
        BarraProgresoAgenda.Value = 0
        Me.Refresh()
        InicializaDatos()
        ConstruyeNombreControlDiario()
        VerificaDia()
        BarraProgresoAgenda.Value = 20
        Me.Refresh()
        ConstruyeNombreControlMensual()
        VerificaMes()
        ConstruyeNombreControlAnual()
        VerificaAño()
        BarraProgresoAgenda.Value = 30
        Me.Refresh()
        MuestraProximos()
        CargaArrayHistorias()
        MuestraPacientes()
        BarraProgresoAgenda.Value = 40
        Me.Refresh()
        ConstruyeNombresIQvistadia()
        VerificaDiaIQ()
        BarraProgresoAgenda.Value = 50
        Me.Refresh()
        ConstruyeNombresIQvistames()
        VerificaMesIQ()
        BarraProgresoAgenda.Value = 60
        Me.Refresh()
        ConstruyeNombresIQvistaaño()
        VerificaAñoIQ()
        BarraProgresoAgenda.Value = 70
        Me.Refresh()
        ConstruyeNombresHonorariosVIEJA()
        VerificaHonorariosVIEJA()
        BarraProgresoAgenda.Value = 85
        Me.Refresh()

        ConstruyeNombresPAGOvistadia()
        VerificaDiaPAGO()
        ConstruyeNombresPAGOvistaMes()
        VerificaMesPAGO()
        ConstruyeNombresPAGOvistaAÑO()
        VerificaAÑOPAGO()

        ConstruyeNombresPAGOvistaAñoIslr()
        VerificaAñoIslrPago()

        ConstruyeNombresHONORARIOS()
        VerificaPagos()
        BarraProgresoAgenda.Value = 0
        Me.Refresh()

        CDMA = Nothing

    End Sub

    Private Sub InicializaDatos()
        Form1.AgendaAbierta = True

        'recupera nombres de los botones
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff
        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
        BarraSinMensaje = Form1.BarraSinMensaje
        FlechaIzqOff = Form1.FlechaIzqOff
        FlechaIzqOn = Form1.FlechaIzqOn
        FlechaDerOff = Form1.FlechaDerOff
        FlechaDerOn = Form1.FlechaDerOn


        'construye nombres de indices
        strPathAgenda = Form1.PSstrPathAgendaBDH

        strPathPAGO = Form1.PathPago



        'creo q no se usaran aca pero...
        'ArchivoIndice = PathAgenda & "\IndiceControles.agd"
        strArchivoIndiceProximos = strPathAgenda & "\IndiceProximos.agd"

        'apunta a la fecha de hoy en la parte de controles diarios
        CalendarioAgendaDias.SelectionStart = Today
        'apaga inicialmente el boton de editar la consulta seleccionada (porq aun no se selecciono nada
        botCONTROLESdiaEditarConsulta.Enabled = False

        'apunta el inicio de meses al mes y año actuales (para meses)
        strMesSeleccionadoNumero = Form1.PSdateFechaDeArraqueDeAgenda.Month
        strAñoSeleccionadoNumerodeMes = Form1.PSdateFechaDeArraqueDeAgenda.Year

        'apunta el inicio de años al año actual (para años)
        strAñoSeleccionadoNumerodeAño = Form1.PSdateFechaDeArraqueDeAgenda.Year


        'pone la vista en consulta de dias
        radControlDiario.Checked = True
        PanelControlMensual.Visible = False
        PanelControlAnual.Visible = False

        'situa los paneles en su sitio pero ocultos
        Me.PanelControlMensual.Location = New System.Drawing.Point(8, 32)
        Me.PanelControlAnual.Location = New System.Drawing.Point(8, 32)
        'el de control diario ya esta en su sitio no se mueve

        '0000000000 parte de la IQ
        'situa el calendario de IQ en la fecha de hoy
        CalendarioIQdia.SelectionStart = Today
        dateFechaSeleccionadaIQvistaDia = Today

        'apunta el inicio de meses al mes y año actuales (para meses)
        dateFechaSeleccionadaIQvistames = Today
        strAñoSeleccionadoIQvistames = Today.Year
        strMesSeleccionadoIQvistames = Today.Month


        dateFechaSeleccionadaIQvistaaño = Today
        strAñoSeleccionadoIQvistaaño = Today.Year


        'Recupera el inicio del path de IQ
        strPathIQ = Form1.PathIQ

        'pone la vista de las IQ en dias
        radIQdia.Checked = True
        PanelIQmes.Visible = False
        PanelIQaño.Visible = False

        'situa los paneles en su sitio pero ocultos
        Me.PanelIQmes.Location = New System.Drawing.Point(8, 32)
        Me.PanelIQaño.Location = New System.Drawing.Point(8, 32)
        'el de IQdia ya esta en su sitio no se mueve

        '000000000 parte de los pagos
        FechaSeleccionadaPAGOvistaDia = Today

        FechaSeleccionadaPAGOvistaMes = Nothing
        FechaSeleccionadaPAGOvistaMes = FechaSeleccionadaPAGOvistaMes.AddYears(Today.Year - 1)
        FechaSeleccionadaPAGOvistaMes = FechaSeleccionadaPAGOvistaMes.AddMonths(Today.Month - 1)
        labPagosMesSeleccionado.Text = FechaSeleccionadaPAGOvistaMes.Month.ToString & " - " & FechaSeleccionadaPAGOvistaMes.Year.ToString
        'queda como dia 1 del mes y año actual

        FechaSeleccionadaPAGOvistaAÑO = Nothing
        FechaSeleccionadaPAGOvistaAÑO = FechaSeleccionadaPAGOvistaAÑO.AddYears(Today.Year - 1)
        labPagosAñoSeleccionado.Text = FechaSeleccionadaPAGOvistaAÑO.Year.ToString

        'de la ficha pagos islr
        FechaSeleccionadaPAGOvistaAÑOISLR = Nothing
        FechaSeleccionadaPAGOvistaAÑOISLR = FechaSeleccionadaPAGOvistaAÑOISLR.AddYears(Today.Year - 1)
        labPagosAñoIslrSeleccionado.Text = FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString
        FechaSeleccionadaPAGOvistaAÑOsiguienteISLR = FechaSeleccionadaPAGOvistaAÑOISLR.AddYears(1)


        '0000000000
        'parte de las variables de los honorarios
        FechaSeleccionadaHonorarios = Today
        AñoseleccionadoHonorarios = Today.Year

        '´parte de los resumenes de honorarios
        datPagosFechaSeleccionada = Today
        intPagosAñoSeleccionado = Today.Year

        'Recupera el inicio del path de Pagos y IQ de la ficha pagos
        strPagosPathIQ = Form1.PathIQ
        strPagosPathPAGO = Form1.PathPago
        strPagosPathAGENDA = Form1.PSstrPathAgendaBDH

    End Sub

    Private Sub botCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCerrar.Click
        Me.Close()
    End Sub

    Private Sub FormAgenda_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.AgendaAbierta = False

    End Sub


    Private Sub radControl_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radControlDiario.Click, radControlMensual.Click, radControlAnual.Click
        If radControlDiario.Checked = True Then
            PanelControlDiario.Visible = True
            PanelControlMensual.Visible = False
            PanelControlAnual.Visible = False
            BorraDatosPacienteSeleccionadoDia()
            ConstruyeNombreControlDiario()
            VerificaDia()
        End If
        If radControlMensual.Checked = True Then
            PanelControlDiario.Visible = False
            PanelControlMensual.Visible = True
            PanelControlAnual.Visible = False
            BorraDatosPacienteSeleccionadoMes()
            ConstruyeNombreControlMensual()
            VerificaMes()
        End If
        If radControlAnual.Checked = True Then
            PanelControlDiario.Visible = False
            PanelControlMensual.Visible = False
            PanelControlAnual.Visible = True
            BorraDatosPacienteSeleccionadoAño()
            ConstruyeNombreControlAnual()
            VerificaAño()
        End If
    End Sub

    Private Sub radIQVista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles radIQdia.CheckedChanged, radIQmes.CheckedChanged, radIQaño.CheckedChanged
        If radIQdia.Checked = True Then
            PanelIQdia.Visible = True
            PanelIQmes.Visible = False
            PanelIQaño.Visible = False
            ConstruyeNombresIQvistadia()
            VerificaDiaIQ()
        End If
        If radIQmes.Checked = True Then
            PanelIQdia.Visible = False
            PanelIQmes.Visible = True
            PanelIQaño.Visible = False
            ConstruyeNombresIQvistames()
            VerificaMesIQ()
        End If
        If radIQaño.Checked = True Then
            PanelIQdia.Visible = False
            PanelIQmes.Visible = False
            PanelIQaño.Visible = True
            ConstruyeNombresIQvistaaño()
            VerificaAñoIQ()
        End If
    End Sub


    'Parte de los dias

    Private Sub ConstruyeNombreControlDiario()
        Dim Temporal As String
        Dim Largo As Integer
        Dim FechaDe8 As String
        Dim AñoConsultado As String
        Dim FechaDe6 As String

        dateFechaConsultadaDia = CalendarioAgendaDias.SelectionStart
        Temporal = dateFechaConsultadaDia.ToString("s")
        Largo = Temporal.Length
        FechaDe8 = Temporal.Remove(Largo - 9, 9)
        FechaDe8 = FechaDe8.Remove(4, 1)
        FechaDe8 = FechaDe8.Remove(6, 1)
        FechaDe6 = FechaDe8.Remove(6, 2)
        AñoConsultado = dateFechaConsultadaDia.Year.ToString
        strArchivoControlDiario = Form1.PSstrPathAgendaBDH & "\" & AñoConsultado & "\Control-" & FechaDe8 & ".agd"
        strArchivoControlMensualdelDia = Form1.PSstrPathAgendaBDH & "\" & AñoConsultado & "\Control-" & FechaDe6 & ".agd"
    End Sub


    Private Sub VerificaDia()

        'variables de verificacion de dias
        Dim PacienteDeEsteDia As String
        Dim decHonorarios As Decimal
        Dim decHonorariosTotalesDia As Decimal
        Dim strHonorariosFormateadosDia As String
        Dim NumeroPacientesDia As Integer

        'limpia lista de pacientes
        ListBoxPacientesDia.Items.Clear()

        'inicializa las variables dependientes
        decHonorarios = 0
        decHonorariosTotalesDia = 0
        NumeroPacientesDia = 0
        LabelPacientes.Text = "Consultas del día " & dateFechaConsultadaDia.ToLongDateString

        'ahora revisa si hay un archivo de control de ese dia
        If File.Exists(strArchivoControlDiario) = True Then
            'existe un archivo de control de este dia, lo lee
            FS = New FileStream(strArchivoControlDiario, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            alsControlesDelDia.Clear()
            C = BR.PeekChar
            While FS.Position < FS.Length
                CDMA = Nothing
                ' Read fields and populate structure
                CDMA.a01NumeroHistoria = BR.ReadString
                CDMA.a02Nombre = BR.ReadString
                CDMA.a03Cedula = BR.ReadString
                CDMA.a04Clinica = BR.ReadString
                CDMA.a05NotaseIDx = BR.ReadString
                CDMA.a06Tratamiento = BR.ReadString
                CDMA.a07Pendiente = BR.ReadString
                CDMA.a08ProximaConsulta = BR.ReadString
                CDMA.a09Honorarios = BR.ReadString
                CDMA.a10FechaConsulta = BR.ReadString
                CDMA.a11FacturaAsociada = BR.ReadString
                CDMA.a16Referencia = BR.ReadString
                CDMA.a15Banco = BR.ReadString
                CDMA.a14FormaDePago = BR.ReadString
                CDMA.a13FechaDePago = BR.ReadString
                CDMA.a12Pagador = BR.ReadString

                'calcula honorarios de esta consulta
                If IsNumeric(CDMA.a09Honorarios) = True Then
                    decHonorarios = CType(CDMA.a09Honorarios, Decimal)
                Else
                    decHonorarios = 0
                End If
                decHonorariosTotalesDia += decHonorarios

                'calcula los pacientes q van
                NumeroPacientesDia += 1

                'añade el paciente a la lista de pacientes
                PacienteDeEsteDia = "Historia: " & CDMA.a01NumeroHistoria & "   de   " & CDMA.a02Nombre
                ListBoxPacientesDia.Items.Add(PacienteDeEsteDia)
                alsControlesDelDia.Add(CDMA)
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'prende el list box para poder seleccionar de la lista
            ListBoxPacientesDia.Enabled = True

            'muestra los honorarios del dia
            strHonorariosFormateadosDia = FormatCurrency(decHonorariosTotalesDia, 2,,, TriState.True)
            labHonorariosTotalesDia.Text = strHonorariosFormateadosDia
            'muestra cuantos pacientes
            labNumeroPacientesDia.Text = NumeroPacientesDia
        Else
            'no hay pacientes vistas este dia
            ListBoxPacientesDia.Items.Add("No se ingresaron consultas a la agenda en este día")
            ListBoxPacientesDia.Enabled = False
            'muestra los honorarios del dia
            strHonorariosFormateadosDia = FormatCurrency(decHonorariosTotalesDia, 2,,, TriState.True)
            labHonorariosTotalesDia.Text = strHonorariosFormateadosDia
            'muestra cuantos pacientes
            labNumeroPacientesDia.Text = NumeroPacientesDia.ToString
        End If

        '000000000000000000000000000000000000000000000
        'parte de las fechas que tienen consultas

        Dim U As New ArrayList() 'FechasConConsultaMes
        Dim Fecha As Date
        Dim Año As Integer
        Dim Mes As Integer
        Dim Dia As Integer
        Dim Fechas() As Date


        U.Clear()

        If File.Exists(strArchivoControlMensualdelDia) = True Then
            'existe un archivo de control de mes, lo lee
            FS = New FileStream(strArchivoControlMensualdelDia, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim Contador As Integer = -1
            C = BR.PeekChar
            While FS.Position < FS.Length
                CDMA = Nothing
                ' Read fields and populate structure
                CDMA.a01NumeroHistoria = BR.ReadString
                CDMA.a02Nombre = BR.ReadString
                CDMA.a03Cedula = BR.ReadString
                CDMA.a04Clinica = BR.ReadString
                CDMA.a05NotaseIDx = BR.ReadString
                CDMA.a06Tratamiento = BR.ReadString
                CDMA.a07Pendiente = BR.ReadString
                CDMA.a08ProximaConsulta = BR.ReadString
                CDMA.a09Honorarios = BR.ReadString
                CDMA.a10FechaConsulta = BR.ReadString
                CDMA.a11FacturaAsociada = BR.ReadString
                CDMA.a16Referencia = BR.ReadString
                CDMA.a15Banco = BR.ReadString
                CDMA.a14FormaDePago = BR.ReadString
                CDMA.a13FechaDePago = BR.ReadString
                CDMA.a12Pagador = BR.ReadString

                '0000000000000000000000000
                Fecha = CType(CDMA.a10FechaConsulta, Date)
                U.Add(Fecha)
                Contador += 1
                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While
            BR.Close()
            FS.Close()

            ReDim Fechas(Contador)
            'pone el array de fechas en negrita en el calendario
            Contador = -1
            REnum = U.GetEnumerator
            While REnum.MoveNext
                Contador += 1
                Fecha = CType(REnum.Current, Date)
                Año = Fecha.Year
                Mes = Fecha.Month
                Dia = Fecha.Day
                Fechas(Contador) = New Date(Año, Mes, Dia)
            End While
            Me.CalendarioAgendaDias.BoldedDates = Fechas
            Me.CalendarioAgendaDias.UpdateBoldedDates()
        End If

        'descarga datos de F
        CDMA = Nothing

    End Sub

    Private Sub Calendario_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioAgendaDias.DateChanged
        BorraDatosPacienteSeleccionadoDia()
        ConstruyeNombreControlDiario()
        VerificaDia()
        ' ActualizaFechasConConsulta()

    End Sub

    Private Sub BorraDatosPacienteSeleccionadoDia()
        labNumeroHistoriaDia.Text = ""
        labNombreDia.Text = ""
        labCedulaDia.Text = ""
        labLugarDia.Text = ""
        labHonorariosDia.Text = ""
        labProximaCitaDia.Text = ""
        labCelularDia.Text = ""
        labFacturaDia.Text = ""
        labPagadorDia.Text = ""
        labBancoDia.Text = ""
        labReferenciaDia.Text = ""
        labFormaDePagoDia.Text = ""
        labEstatusCancelacionDia.Text = ""
        labEstatusCancelacionDia.BackColor = Color.LightGreen
        labFechaDeCancelacionDia.Text = ""
        txtAUTOdia.Clear()
        txtIDxDia.Clear()
        txtTtoDia.Clear()
        txtPendienteDia.Clear()

        'inicializa tambien la estructura para q coincida con la pantalla
        CDMA = Nothing
        'apaga el boton de editar consulta
        botCONTROLESdiaEditarConsulta.Enabled = False


    End Sub

    Private Sub ListBoxPacientesDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ListBoxPacientesDia.SelectedIndexChanged
        Dim NumeroSeleccionado As Integer
        'Dim NumerohistoriaSeleccionado As String
        Dim strFormatoMoneda As String
        Dim decHonorarios As Decimal

        'toma el index seleccionado (ojo 0 es el primero)
        NumeroSeleccionado = ListBoxPacientesDia.SelectedIndex
        'asigna lo guardado en ese index a la estructura f
        CDMA = alsControlesDelDia(NumeroSeleccionado)
        'obtiene los valores a partir de f
        labNumeroHistoriaDia.Text = CDMA.a01NumeroHistoria
        labNombreDia.Text = CDMA.a02Nombre
        'las Cedulas
        Dim CedulaActual As String = ""
        CedulaActual = CDMA.a03Cedula
        CedulaActual = CedulaActual.Substring(0, 2) & "." & CedulaActual.Substring(2, 3) & "." & CedulaActual.Substring(5, 3)
        If CedulaActual(0) = "0" Then
            CedulaActual = CedulaActual.Remove(0, 1)
        End If
        labCedulaDia.Text = CedulaActual
        labLugarDia.Text = CDMA.a04Clinica
        'la proxima cita
        If CDMA.a08ProximaConsulta.IndexOf("-"c) > -1 Then
            'tiene formato de string("s") primero transforma
            labProximaCitaDia.Text = (CType(CDMA.a08ProximaConsulta, Date)).ToLongDateString
        Else
            'o esta vacio o en formato de LDS de una vez lo muestra
            labProximaCitaDia.Text = CDMA.a08ProximaConsulta
        End If

        txtIDxDia.Text = CDMA.a05NotaseIDx
        txtTtoDia.Text = CDMA.a06Tratamiento
        txtPendienteDia.Text = CDMA.a07Pendiente
        'formatea honorarios
        If IsNumeric(CDMA.a09Honorarios) Then
            decHonorarios = CType(CDMA.a09Honorarios, Decimal)
        Else
            decHonorarios = 0
        End If
        strFormatoMoneda = FormatCurrency(decHonorarios, 2,,, TriState.True)

        labHonorariosDia.Text = strFormatoMoneda

        'la factura
        If CDMA.a11FacturaAsociada <> "" Then
            labFacturaDia.Text = CDMA.a11FacturaAsociada.PadLeft(5, "0"c)
        Else
            labFacturaDia.Text = ""
        End If

        'el pagador
        If CDMA.a12Pagador <> "" Then
            'hay un dato fue pagada por alguien mas
            labPagadorDia.Text = CDMA.a12Pagador
        Else
            'esta en blanco fue pagada por la pte
            labPagadorDia.Text = "La paciente"
        End If

        'parte nueva la mayoria va a estar en blanco porq no habra necesidad de rellenar todo solo los cambios seran tomados
        If CDMA.a13FechaDePago = "" Then
            'esta en blanco... se considera q fue pagada el mismo dia los pone
            labEstatusCancelacionDia.Text = "Cancelada el mismo día"
            labEstatusCancelacionDia.BackColor = Color.LightGreen
            labFechaDeCancelacionDia.Text = CType(CDMA.a10FechaConsulta, Date).ToShortDateString
        Else
            'ok es un dato nuevo reciente que cambio este dato verifica
            If IsDate(CDMA.a13FechaDePago) Then
                'hay una fecha valida la compara
                If CType(CDMA.a13FechaDePago, Date).Date = CType(CDMA.a10FechaConsulta, Date).Date Then
                    'se cancelo el mismo dia 
                    labEstatusCancelacionDia.Text = "Cancelada el mismo día"
                    labEstatusCancelacionDia.BackColor = Color.LightGreen
                    labFechaDeCancelacionDia.Text = CType(CDMA.a10FechaConsulta, Date).ToShortDateString

                ElseIf CType(CDMA.a13FechaDePago, Date) = Nothing Then
                    'si esta explicitamente en nothin se considera pendiente asi se programara en anota la agenda
                    labEstatusCancelacionDia.Text = "Pendiente"
                    labEstatusCancelacionDia.BackColor = Color.LightPink
                    labFechaDeCancelacionDia.Text = ""
                Else
                    'se cancelo otro dia
                    labEstatusCancelacionDia.Text = "Cancelada Otro día"
                    labEstatusCancelacionDia.BackColor = Color.LightCyan
                    labFechaDeCancelacionDia.Text = CType(CDMA.a13FechaDePago, Date).ToShortDateString
                End If

            End If
        End If

        'los datos de la forma de pago
        If CDMA.a14FormaDePago = "" Then
            'en blanco se considera en efectivo
            labFormaDePagoDia.Text = "Efectivo"
            labBancoDia.Text = ""
            labReferenciaDia.Text = ""
        Else
            'hay algo en forma de pago lo muestra
            labFormaDePagoDia.Text = CDMA.a14FormaDePago
            'ahora muestra lo q esta en banco y ref
            labBancoDia.Text = CDMA.a15Banco
            labReferenciaDia.Text = CDMA.a16Referencia
        End If


        '===================================================

        '-----Busca Datos Autogenerados---------------------

        strNumeroHistoriaSeleccionado = CDMA.a01NumeroHistoria
        dateFechaSeleccionada = dateFechaConsultadaDia

        subGeneraDatosAutomaticos()

        txtAUTOdia.Text = strAutoGeneradoControlObs & vbCrLf & strAutoGeneradoEco


        '===================================================

        'prende el boton de editar consulta
        botCONTROLESdiaEditarConsulta.Enabled = True

    End Sub

    Private Sub botCONTROLESdiaEditarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCONTROLESdiaEditarConsulta.Click
        'verifica que se haya seleccionado a alguien
        If CDMA.a01NumeroHistoria = "" Then
            MsgBox("Selecciona A alguien Primero....")
            Exit Sub
        ElseIf Form1.PSbooHistoriaAbierta = True Then
            MsgBox("Hay una Historia abierta, cierrala primero para no afectar sus datos...")
            Exit Sub
        End If
        'si llega hasta aca edita la agenda
        EditaAgenda()
        'al regresar borra datos de seleccionada porq no esta seleccionando a nadie
        BorraDatosPacienteSeleccionadoDia()
    End Sub

    Private Sub EditaAgenda()

        'prende la bandera de q es una edicion rapida de agenda
        Form1.PSbooEdicionRapidaDeLaConsulta = True

        'inicializa las variables necesarias
        Form1.PSdateFechaDeArraqueDeAgenda = CType(CDMA.a10FechaConsulta, Date)
        Form1.PSstrNumeroHistoriaSeleccionada = CDMA.a01NumeroHistoria
        Form1.PSstrPacienteSeleccionadaNombre = CDMA.a02Nombre
        Form1.PSstrPacienteSeleccionadaCedula = CDMA.a03Cedula
        Form1.PSstrPrefijoHistoriaSeleccionada = Form1.PSstrNumeroHistoriaSeleccionada.Substring(0, 5)
        Form1.NumeroDeHistoriaCompleto = CDMA.a01NumeroHistoria

        Form1.AnotaTrueBorraFalseEnLaAgenda = True

        Form1.PSstrPathHistoriasConPrefijo = Form1.PSstrPathHistoriasSinPrefijo & "\" & Form1.PSstrPrefijoHistoriaSeleccionada
        Form1.PathAgendaControlesActual = Form1.PSstrPathAgendaBDH & "\" & Form1.PSdateFechaDeArraqueDeAgenda.Year.ToString

        Form1.ArchivoPropioAGD = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & ".agd"
        Form1.ArchivoIndice = Form1.PSstrPathAgendaBDH & "\IndiceControles.agd"
        Form1.ArchivoIndiceProximos = Form1.PSstrPathAgendaBDH & "\IndiceProximos.agd"
        Form1.ArchivoPropioAgdBAK = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & ".bak"
        Form1.ArchivoIndiceBAK = Form1.PSstrPathAgendaBDH & "\IndiceControles.bak"
        Form1.ArchivoIndiceProximosBAK = Form1.PSstrPathAgendaBDH & "\IndiceProximos.bak"

        Form1.strArchivoControlEcograficoDelPteSeleccionado = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Control Ecográfico.dat"
        Form1.strArchivoControlObstetricoDelPteSeleccionado = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Control Obstétrico.dat"

        Form1.ArchivoControlDiario = Form1.PathAgendaControlesActual & "\Control-" & Form1.PSdateFechaDeArraqueDeAgenda.Year.ToString & _
                                                                                     Form1.PSdateFechaDeArraqueDeAgenda.Month.ToString.PadLeft(2, "0"c) & _
                                                                                     Form1.PSdateFechaDeArraqueDeAgenda.Day.ToString.PadLeft(2, "0"c) & ".agd"
        Form1.ArchivoControlMensual = Form1.PathAgendaControlesActual & "\Control-" & Form1.PSdateFechaDeArraqueDeAgenda.Year.ToString & _
                                                                                             Form1.PSdateFechaDeArraqueDeAgenda.Month.ToString.PadLeft(2, "0"c) & ".agd"
        Form1.ArchivoControlAnual = Form1.PathAgendaControlesActual & "\Control-" & Form1.PSdateFechaDeArraqueDeAgenda.Year.ToString & ".agd"


        Form1.ArchivoControlDiarioBAK = Form1.PathAgendaControlesActual & "\Control-" & Form1.PSdateFechaDeArraqueDeAgenda.Year.ToString & _
                                                                                        Form1.PSdateFechaDeArraqueDeAgenda.Month.ToString.PadLeft(2, "0"c) & _
                                                                                        Form1.PSdateFechaDeArraqueDeAgenda.Day.ToString.PadLeft(2, "0"c) & ".bak"
        Form1.ArchivoControlMensualBAK = Form1.PathAgendaControlesActual & "\Control-" & Form1.PSdateFechaDeArraqueDeAgenda.Year.ToString & _
                                                                                        Form1.PSdateFechaDeArraqueDeAgenda.Month.ToString.PadLeft(2, "0"c) & ".bak"
        Form1.ArchivoControlAnualBAK = Form1.PathAgendaControlesActual & "\Control-" & Form1.PSdateFechaDeArraqueDeAgenda.Year.ToString & ".bak"

        If CDMA.a08ProximaConsulta <> Nothing Then
            Form1.FechaPendienteProximaConsulta = CType(CDMA.a08ProximaConsulta, Date)
            Form1.PendienteConsulta = True
        Else
            Form1.FechaPendienteProximaConsulta = Nothing
            Form1.PendienteConsulta = False
        End If

        'revisa si es la ultima consulta de este paciente
        If File.Exists(Form1.ArchivoPropioAGD) Then
            'existe lo lee
            Dim BR As BinaryReader
            Dim FS As FileStream
            Dim T1 As Form1.TablaDeArchivosPropiosDeAgenda
            Dim alsConsultasDelPaciente As New ArrayList

            alsConsultasDelPaciente.Clear()
            FS = New FileStream(Form1.ArchivoPropioAGD, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim C As Integer
            C = BR.PeekChar
            Dim contador As Integer = 0
            While FS.Position < FS.Length
                T1.a10FechaConsulta = BR.ReadString
                T1.a02Clinica = BR.ReadString
                T1.a03NotaseIDx = BR.ReadString
                T1.a04Tratamiento = BR.ReadString
                T1.a05Pendiente = BR.ReadString
                T1.a06ProximaConsulta = BR.ReadString
                T1.a07Honorarios = BR.ReadString
                T1.a11FacturaAsociada = BR.ReadString
                T1.a16Referencia = BR.ReadString
                T1.a15Banco = BR.ReadString
                T1.a14FormaDePago = BR.ReadString
                T1.a13FechaDePago = BR.ReadString
                T1.a12Pagador = BR.ReadString
                alsConsultasDelPaciente.Add(T1)
                C = BR.PeekChar
                contador += 1
            End While
            BR.Close()
            FS.Close()

            'ya tengo todas las consultas las ordeno
            Dim alsConsultasOrdenadas = From est As Form1.TablaDeArchivosPropiosDeAgenda In alsConsultasDelPaciente _
                                        Order By est.a10FechaConsulta Descending _
                                        Select est

            If CDMA.a10FechaConsulta = alsConsultasOrdenadas(0).a10FechaConsulta Then
                'esta es la ultima consulta
                Form1.EsLaUltimaConsultaLaSeleccionada = True
            Else
                Form1.EsLaUltimaConsultaLaSeleccionada = False
            End If
        End If

        'antes de salir recuerda en q fecha estaba el calendario
        Dim dateFechaDeLaModificacion = CType(CDMA.a10FechaConsulta, Date)

        'ahora anota en la agenda
        Dim DLG As New FormAnotaEnLaAgenda()
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If

        'actualizo los datos de agenda
        ArrancaPues()

        'vuelvo a seleccionar la fecha donde estaba
        CalendarioAgendaDias.SelectionStart = dateFechaDeLaModificacion


        'sea cual sea lo q se edito se prende la bandera de actualizar form1
        Form1.booSeDebeActualizarAgenda = True


    End Sub



    Private Sub subConstruyeNombresDeControlesDeAgendaDependienteDeLaFecha()

        'crea nombre de archivos relacionados


        Dim Temporal = Form1.PSdateFechaDeArraqueDeAgenda.ToString("s")
        Dim Largo = Temporal.Length
        Dim FechaDe8 = Temporal.Remove(Largo - 9, 9)
        FechaDe8 = FechaDe8.Remove(4, 1)
        FechaDe8 = FechaDe8.Remove(6, 1)
        Dim FechaDe6 = FechaDe8.Remove(6, 2)
        Dim FechaDe4 = FechaDe6.Remove(4, 2)

        'estos van en el directorio de año de la agenda
        Form1.ArchivoControlDiario = Form1.PathAgendaControlesActual & "\Control-" & FechaDe8 & ".agd"
        Form1.ArchivoControlDiarioBAK = Form1.PathAgendaControlesActual & "\Control-" & FechaDe8 & ".bak"
        Form1.ArchivoControlMensual = Form1.PathAgendaControlesActual & "\Control-" & FechaDe6 & ".agd"
        Form1.ArchivoControlMensualBAK = Form1.PathAgendaControlesActual & "\Control-" & FechaDe6 & ".bak"
        Form1.ArchivoControlAnual = Form1.PathAgendaControlesActual & "\Control-" & FechaDe4 & ".agd"
        Form1.ArchivoControlAnualBAK = Form1.PathAgendaControlesActual & "\Control-" & FechaDe4 & ".bak"

    End Sub

    Private Sub subRevisaCitasProximas()

        ' Dim Nombre, Cedula, NumeroHistoria, NumeroCompleto As String



        '0000000000000000000000000000000000000000
        'parte de verificacion de proximas citas
        Dim FS As FileStream
        Dim BR As BinaryReader

        Dim FechaBuscada As String
        Dim HistoriaBuscada As String
        Dim HistoriaComparada As String

        Dim arrProximasCitas As New ArrayList


        Dim NumeroControlesEnIndice As Integer = 0
        Dim NumeroProximosControlesEnIndice As Integer = 0

        If File.Exists(Form1.ArchivoIndiceProximos) = True Then
            'existe un indice de proximos, lo carga

            'ahora revisa los indices de proximas consultas
            FS = New FileStream(Form1.ArchivoIndiceProximos, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim K As New Form1.TablaDeArchivosDeIndiceDeProximosControles()
            Dim C As Integer
            arrProximasCitas.Clear()
            C = BR.PeekChar
            While FS.Position < FS.Length
                K = Nothing
                ' Read fields and populate structure
                K.a01FechaProximocontrol = BR.ReadString
                K.a02NumeroHistoria = BR.ReadString
                K.a03Nombre = BR.ReadString
                arrProximasCitas.Add(K)
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            NumeroProximosControlesEnIndice = arrProximasCitas.Count

            'ahora revisa si la base de datos de proximas consultas esta o no vacia 
            If NumeroProximosControlesEnIndice > 0 Then
                'existe al menos un dato de prox consultas , lee el contenido del array list
                HistoriaBuscada = Form1.PSstrNumeroHistoriaSeleccionada

                'inicializa la bandera a que no esta pendiente
                Form1.PendienteConsulta = False

                For Each est As Form1.TablaDeArchivosDeIndiceDeProximosControles In arrProximasCitas

                    HistoriaComparada = est.a02NumeroHistoria

                    If HistoriaBuscada = HistoriaComparada Then
                        FechaBuscada = est.a01FechaProximocontrol
                        Form1.FechaPendienteProximaConsulta = CType(FechaBuscada, Date)
                        Form1.PendienteConsulta = True
                    End If

                Next
            End If
        End If
    End Sub

    Private Sub subAnotaEnLaAgenda()
        Dim DLG As New FormAnotaEnLaAgenda()
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If
    End Sub


    '==== variables publicas autogeneradas del form ===============================================================
    Dim strNumeroHistoriaSeleccionado As String = ""
    Dim dateFechaSeleccionada As Date = Nothing

    Dim strAutoGeneradoControlObs As String = ""
    Dim strAutoGeneradoEco As String = ""

    'esta guarda el nombredel control obstetrico actual
    Dim strArchivoControlObsDelPteSeleccionado As String
    Dim arrEmbarazosDeLaPteSeleccionada As New ArrayList

    'el archivo de ecos personales
    Dim strArchivoControlEcoDelPteSeleccionado As String
    Dim arrEcosDelPacienteActual As New ArrayList

    'el archivo de datos complementarios
    Dim strArchivoDatosPersonalesDelPteSeleccionado As String


    Dim estOBS As New FormControlObstetrico.TablaDeDatosRescatadosDelControlObs
    Dim estECO As New FormControlObstetrico.TablaDeDatosRescatadosDelEco

    Dim strFUR As String = ""
    Dim dateFUR As Date = Nothing
    Dim dateFecha As Date = Nothing
    '-------------------------------
    Private Sub subGeneraDatosAutomaticos()
        Dim strPrefijo = strNumeroHistoriaSeleccionado.Substring(0, 5)

        strArchivoControlObsDelPteSeleccionado = Form1.PSstrPathHistoriasSinPrefijo & "\" & strPrefijo & "\" & strNumeroHistoriaSeleccionado & "-Control Obstétrico.dat"
        strArchivoControlEcoDelPteSeleccionado = Form1.PSstrPathHistoriasSinPrefijo & "\" & strPrefijo & "\" & strNumeroHistoriaSeleccionado & "-Control Ecográfico.dat"
        strArchivoDatosPersonalesDelPteSeleccionado = Form1.PSstrPathHistoriasSinPrefijo & "\" & strPrefijo & "\" & strNumeroHistoriaSeleccionado & "-Datos Personales.dat"

        'carga controles obstetricos
        subCargaControlesObstetricosDeLaPteSeleccionada()
        'Busca los datos adecuados segun fecha seleccionada
        subBuscaDatosObstetricosDeLaFechaSeleccionada()
        'Genera las notas obs automaticas
        subGeneraNotasObstetricasAutomaticas()

        'carga controles ecograficos
        subCargaEcografiasDeLaPteSeleccionada()
        'Busca los datos adecuados segun fecha seleccionada
        subBuscaDatosEcograficosDeLaFechaSeleccionada()
        'Genera las notas eco automaticas
        subGeneraNotasEcograficasAutomaticas()

        'carga los datos pesonales y muestra si puede el telefono
        subCargaDatosPersonalesDeLaPacienteSeleccionada()

    End Sub

    Private Sub subCargaDatosPersonalesDeLaPacienteSeleccionada()

        If File.Exists(strArchivoDatosPersonalesDelPteSeleccionado) Then
            'existe lo carga los datos personales almacenados
            FS = New FileStream(strArchivoDatosPersonalesDelPteSeleccionado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            DP = Nothing
            ' Read fields and populate structure
            DP.a01Nombre = BR.ReadString
            DP.FechaNacimiento = BR.ReadString
            DP.Edad = BR.ReadString
            DP.Cedula = BR.ReadString
            DP.Profesion = BR.ReadString
            DP.Telefono = BR.ReadString
            DP.AntecedentesFamiliares = BR.ReadString
            DP.AntecedentesPersonales = BR.ReadString
            DP.AntecedentesGinecologicos = BR.ReadString
            DP.AntecedentesObstetricos = BR.ReadString
            DP.AntecedentesQuirurgicos = BR.ReadString
            DP.x01DireccionDeHabitacion = BR.ReadString
            DP.x02GradoDeInstruccion = BR.ReadString
            DP.x03Religion = BR.ReadString
            DP.x04CiaDeSeguros = BR.ReadString
            DP.x05FamiliarNombre = BR.ReadString
            DP.x06FamiliarParentesco = BR.ReadString
            DP.x07FamiliarCelular = BR.ReadString
            DP.x08FamiliarOcupacion = BR.ReadString
            DP.z01 = BR.ReadString
            DP.z02 = BR.ReadString
            DP.z03 = BR.ReadString
            DP.z04 = BR.ReadString
            DP.z05 = BR.ReadString
            DP.z06 = BR.ReadString
            DP.z07 = BR.ReadString
            DP.z08 = BR.ReadString
            DP.z09 = BR.ReadString
            DP.z10 = BR.ReadString

            BR.Close()
            FS.Close()


            'ahora muestra si esta..el telefono
            If DP.Telefono <> "" Then
                Dim tel As String
                Dim pedazo1, pedazo2, pedazo3, pedazo4 As String
                If DP.Telefono.Length = 10 Then 'si se introdujero todos los numeros
                    pedazo1 = DP.Telefono.Substring(0, 3)
                    pedazo2 = DP.Telefono.Substring(3, 3)
                    pedazo3 = DP.Telefono.Substring(6, 2)
                    pedazo4 = DP.Telefono.Substring(8, 2)
                    tel = "(0" & pedazo1 & ") " & pedazo2 & "." & pedazo3 & "." & pedazo4
                    labCelularDia.Text = tel
                ElseIf DP.Telefono.Length = 7 Then 'si solo se metieron los 7 numeros sin codigo
                    pedazo2 = DP.Telefono.Substring(0, 3)
                    pedazo3 = DP.Telefono.Substring(3, 2)
                    pedazo4 = DP.Telefono.Substring(5, 2)
                    tel = pedazo2 & "." & pedazo3 & "." & pedazo4
                    labCelularDia.Text = tel
                Else 'si es otro numero de digitos ??? muestralos tal cual
                    labCelularDia.Text = DP.Telefono
                End If
            Else 'si no se metio nada entonces
                labCelularDia.Text = "(N / A)"
            End If

        Else
            'no exite el archivo pone las casillitas dependientes en blanco
            labCelularDia.Text = "(N/A)"
        End If 'finaliza comprobacion de si existe el archivo de datos personales

    End Sub

    Private Sub subCargaControlesObstetricosDeLaPteSeleccionada()

        Dim R As New Form1.TablaDeDatosObstetricos

        If File.Exists(strArchivoControlObsDelPteSeleccionado) Then
            'si existe lo lee
            FS = New FileStream(strArchivoControlObsDelPteSeleccionado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            arrEmbarazosDeLaPteSeleccionada.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                R = Nothing
                ' Read fields and populate structure

                R.FechaInicioControl = BR.ReadString
                R.ObservacionesIniciales = BR.ReadString
                R.FUR = BR.ReadString
                R.ParidadInicial = BR.ReadString
                R.TerminoGestacion = BR.ReadString
                R.ControlTerminoEn = BR.ReadString
                R.PesoInicial = BR.ReadString
                R.IDx = BR.ReadString
                R.ObservacionesPrivadas = BR.ReadString
                R.Fecha00 = BR.ReadString : R.Fecha01 = BR.ReadString : R.Fecha02 = BR.ReadString : R.Fecha03 = BR.ReadString : R.Fecha04 = BR.ReadString : R.Fecha05 = BR.ReadString
                R.Fecha06 = BR.ReadString : R.Fecha07 = BR.ReadString : R.Fecha08 = BR.ReadString : R.Fecha09 = BR.ReadString : R.Fecha10 = BR.ReadString
                R.Fecha11 = BR.ReadString : R.Fecha12 = BR.ReadString : R.Fecha13 = BR.ReadString : R.Fecha14 = BR.ReadString : R.Fecha15 = BR.ReadString
                R.Fecha16 = BR.ReadString
                R.Peso00 = BR.ReadString : R.Peso01 = BR.ReadString : R.Peso02 = BR.ReadString : R.Peso03 = BR.ReadString : R.Peso04 = BR.ReadString : R.Peso05 = BR.ReadString
                R.Peso06 = BR.ReadString : R.Peso07 = BR.ReadString : R.Peso08 = BR.ReadString : R.Peso09 = BR.ReadString : R.Peso10 = BR.ReadString
                R.Peso11 = BR.ReadString : R.Peso12 = BR.ReadString : R.Peso13 = BR.ReadString : R.Peso14 = BR.ReadString : R.Peso15 = BR.ReadString
                R.Peso16 = BR.ReadString
                R.TAS00 = BR.ReadString : R.TAS01 = BR.ReadString : R.TAS02 = BR.ReadString : R.TAS03 = BR.ReadString : R.TAS04 = BR.ReadString : R.TAS05 = BR.ReadString
                R.TAS06 = BR.ReadString : R.TAS07 = BR.ReadString : R.TAS08 = BR.ReadString : R.TAS09 = BR.ReadString : R.TAS10 = BR.ReadString
                R.TAS11 = BR.ReadString : R.TAS12 = BR.ReadString : R.TAS13 = BR.ReadString : R.TAS14 = BR.ReadString : R.TAS15 = BR.ReadString
                R.TAS16 = BR.ReadString
                R.TAD00 = BR.ReadString : R.TAD01 = BR.ReadString : R.TAD02 = BR.ReadString : R.TAD03 = BR.ReadString : R.TAD04 = BR.ReadString : R.TAD05 = BR.ReadString
                R.TAD06 = BR.ReadString : R.TAD07 = BR.ReadString : R.TAD08 = BR.ReadString : R.TAD09 = BR.ReadString : R.TAD10 = BR.ReadString
                R.TAD11 = BR.ReadString : R.TAD12 = BR.ReadString : R.TAD13 = BR.ReadString : R.TAD14 = BR.ReadString : R.TAD15 = BR.ReadString
                R.TAD16 = BR.ReadString
                R.Edema00 = BR.ReadString : R.Edema01 = BR.ReadString : R.Edema02 = BR.ReadString : R.Edema03 = BR.ReadString : R.Edema04 = BR.ReadString : R.Edema05 = BR.ReadString
                R.Edema06 = BR.ReadString : R.Edema07 = BR.ReadString : R.Edema08 = BR.ReadString : R.Edema09 = BR.ReadString : R.Edema10 = BR.ReadString
                R.Edema11 = BR.ReadString : R.Edema12 = BR.ReadString : R.Edema13 = BR.ReadString : R.Edema14 = BR.ReadString : R.Edema15 = BR.ReadString
                R.Edema16 = BR.ReadString
                R.AU00 = BR.ReadString : R.AU01 = BR.ReadString : R.AU02 = BR.ReadString : R.AU03 = BR.ReadString : R.AU04 = BR.ReadString : R.AU05 = BR.ReadString
                R.AU06 = BR.ReadString : R.AU07 = BR.ReadString : R.AU08 = BR.ReadString : R.AU09 = BR.ReadString : R.AU10 = BR.ReadString
                R.AU11 = BR.ReadString : R.AU12 = BR.ReadString : R.AU13 = BR.ReadString : R.AU14 = BR.ReadString : R.AU15 = BR.ReadString
                R.AU16 = BR.ReadString
                R.Pres00 = BR.ReadString : R.Pres01 = BR.ReadString : R.Pres02 = BR.ReadString : R.Pres03 = BR.ReadString : R.Pres04 = BR.ReadString : R.Pres05 = BR.ReadString
                R.Pres06 = BR.ReadString : R.Pres07 = BR.ReadString : R.Pres08 = BR.ReadString : R.Pres09 = BR.ReadString : R.Pres10 = BR.ReadString
                R.Pres11 = BR.ReadString : R.Pres12 = BR.ReadString : R.Pres13 = BR.ReadString : R.Pres14 = BR.ReadString : R.Pres15 = BR.ReadString
                R.Pres16 = BR.ReadString
                R.Sit00 = BR.ReadString : R.Sit01 = BR.ReadString : R.Sit02 = BR.ReadString : R.Sit03 = BR.ReadString : R.Sit04 = BR.ReadString : R.Sit05 = BR.ReadString
                R.Sit06 = BR.ReadString : R.Sit07 = BR.ReadString : R.Sit08 = BR.ReadString : R.Sit09 = BR.ReadString : R.Sit10 = BR.ReadString
                R.Sit11 = BR.ReadString : R.Sit12 = BR.ReadString : R.Sit13 = BR.ReadString : R.Sit14 = BR.ReadString : R.Sit15 = BR.ReadString
                R.Sit16 = BR.ReadString
                R.MF00 = BR.ReadString : R.MF01 = BR.ReadString : R.MF02 = BR.ReadString : R.MF03 = BR.ReadString : R.MF04 = BR.ReadString : R.MF05 = BR.ReadString
                R.MF06 = BR.ReadString : R.MF07 = BR.ReadString : R.MF08 = BR.ReadString : R.MF09 = BR.ReadString : R.MF10 = BR.ReadString
                R.MF11 = BR.ReadString : R.MF12 = BR.ReadString : R.MF13 = BR.ReadString : R.MF14 = BR.ReadString : R.MF15 = BR.ReadString
                R.MF16 = BR.ReadString
                R.FF00 = BR.ReadString : R.FF01 = BR.ReadString : R.FF02 = BR.ReadString : R.FF03 = BR.ReadString : R.FF04 = BR.ReadString : R.FF05 = BR.ReadString
                R.FF06 = BR.ReadString : R.FF07 = BR.ReadString : R.FF08 = BR.ReadString : R.FF09 = BR.ReadString : R.FF10 = BR.ReadString
                R.FF11 = BR.ReadString : R.FF12 = BR.ReadString : R.FF13 = BR.ReadString : R.FF14 = BR.ReadString : R.FF15 = BR.ReadString
                R.FF16 = BR.ReadString
                R.Obs00 = BR.ReadString : R.Obs01 = BR.ReadString : R.Obs02 = BR.ReadString : R.Obs03 = BR.ReadString : R.Obs04 = BR.ReadString : R.Obs05 = BR.ReadString
                R.Obs06 = BR.ReadString : R.Obs07 = BR.ReadString : R.Obs08 = BR.ReadString : R.Obs09 = BR.ReadString : R.Obs10 = BR.ReadString
                R.Obs11 = BR.ReadString : R.Obs12 = BR.ReadString : R.Obs13 = BR.ReadString : R.Obs14 = BR.ReadString : R.Obs15 = BR.ReadString
                R.Obs16 = BR.ReadString
                R.Comentarios = BR.ReadString

                R.FechaLab00 = BR.ReadString : R.FechaLab01 = BR.ReadString : R.FechaLab02 = BR.ReadString : R.FechaLab03 = BR.ReadString : R.FechaLab04 = BR.ReadString : R.FechaLab05 = BR.ReadString
                R.FechaLab06 = BR.ReadString : R.FechaLab07 = BR.ReadString
                R.Hb00 = BR.ReadString : R.Hb01 = BR.ReadString : R.Hb02 = BR.ReadString : R.Hb03 = BR.ReadString : R.Hb04 = BR.ReadString : R.Hb05 = BR.ReadString
                R.Hb06 = BR.ReadString : R.Hb07 = BR.ReadString
                R.Hto00 = BR.ReadString : R.Hto01 = BR.ReadString : R.Hto02 = BR.ReadString : R.Hto03 = BR.ReadString : R.Hto04 = BR.ReadString : R.Hto05 = BR.ReadString
                R.Hto06 = BR.ReadString : R.Hto07 = BR.ReadString
                R.GB00 = BR.ReadString : R.GB01 = BR.ReadString : R.GB02 = BR.ReadString : R.GB03 = BR.ReadString : R.GB04 = BR.ReadString : R.GB05 = BR.ReadString
                R.GB06 = BR.ReadString : R.GB07 = BR.ReadString
                R.Seg00 = BR.ReadString : R.Seg01 = BR.ReadString : R.Seg02 = BR.ReadString : R.Seg03 = BR.ReadString : R.Seg04 = BR.ReadString : R.Seg05 = BR.ReadString
                R.Seg06 = BR.ReadString : R.Seg07 = BR.ReadString
                R.Lin00 = BR.ReadString : R.Lin01 = BR.ReadString : R.Lin02 = BR.ReadString : R.Lin03 = BR.ReadString : R.Lin04 = BR.ReadString : R.Lin05 = BR.ReadString
                R.Lin06 = BR.ReadString : R.Lin07 = BR.ReadString
                R.Mon00 = BR.ReadString : R.Mon01 = BR.ReadString : R.Mon02 = BR.ReadString : R.Mon03 = BR.ReadString : R.Mon04 = BR.ReadString : R.Mon05 = BR.ReadString
                R.Mon06 = BR.ReadString : R.Mon07 = BR.ReadString
                R.Plaq00 = BR.ReadString : R.Plaq01 = BR.ReadString : R.Plaq02 = BR.ReadString : R.Plaq03 = BR.ReadString : R.Plaq04 = BR.ReadString : R.Plaq05 = BR.ReadString
                R.Plaq06 = BR.ReadString : R.Plaq07 = BR.ReadString
                R.PT00 = BR.ReadString : R.PT01 = BR.ReadString : R.PT02 = BR.ReadString : R.PT03 = BR.ReadString : R.PT04 = BR.ReadString : R.PT05 = BR.ReadString
                R.PT06 = BR.ReadString : R.PT07 = BR.ReadString
                R.PTT00 = BR.ReadString : R.PTT01 = BR.ReadString : R.PTT02 = BR.ReadString : R.PTT03 = BR.ReadString : R.PTT04 = BR.ReadString : R.PTT05 = BR.ReadString
                R.PTT06 = BR.ReadString : R.PTT07 = BR.ReadString
                R.Gli00 = BR.ReadString : R.Gli01 = BR.ReadString : R.Gli02 = BR.ReadString : R.Gli03 = BR.ReadString : R.Gli04 = BR.ReadString : R.Gli05 = BR.ReadString
                R.Gli06 = BR.ReadString : R.Gli07 = BR.ReadString
                R.Crea00 = BR.ReadString : R.Crea01 = BR.ReadString : R.Crea02 = BR.ReadString : R.Crea03 = BR.ReadString : R.Crea04 = BR.ReadString : R.Crea05 = BR.ReadString
                R.Crea06 = BR.ReadString : R.Crea07 = BR.ReadString
                R.VDRL00 = BR.ReadString : R.VDRL01 = BR.ReadString : R.VDRL02 = BR.ReadString : R.VDRL03 = BR.ReadString : R.VDRL04 = BR.ReadString : R.VDRL05 = BR.ReadString
                R.VDRL06 = BR.ReadString : R.VDRL07 = BR.ReadString
                R.HIV00 = BR.ReadString : R.HIV01 = BR.ReadString : R.HIV02 = BR.ReadString : R.HIV03 = BR.ReadString : R.HIV04 = BR.ReadString : R.HIV05 = BR.ReadString
                R.HIV06 = BR.ReadString : R.HIV07 = BR.ReadString
                R.Tox00 = BR.ReadString : R.Tox01 = BR.ReadString : R.Tox02 = BR.ReadString : R.Tox03 = BR.ReadString : R.Tox04 = BR.ReadString : R.Tox05 = BR.ReadString
                R.Tox06 = BR.ReadString : R.Tox07 = BR.ReadString
                R.Tipiaje00 = BR.ReadString : R.Tipiaje01 = BR.ReadString : R.Tipiaje02 = BR.ReadString : R.Tipiaje03 = BR.ReadString : R.Tipiaje04 = BR.ReadString : R.Tipiaje05 = BR.ReadString
                R.Tipiaje06 = BR.ReadString : R.Tipiaje07 = BR.ReadString
                R.Coombs00 = BR.ReadString : R.Coombs01 = BR.ReadString : R.Coombs02 = BR.ReadString : R.Coombs03 = BR.ReadString : R.Coombs04 = BR.ReadString : R.Coombs05 = BR.ReadString
                R.Coombs06 = BR.ReadString : R.Coombs07 = BR.ReadString
                R.TipiajeEsp00 = BR.ReadString : R.TipiajeEsp01 = BR.ReadString : R.TipiajeEsp02 = BR.ReadString : R.TipiajeEsp03 = BR.ReadString : R.TipiajeEsp04 = BR.ReadString : R.TipiajeEsp05 = BR.ReadString
                R.TipiajeEsp06 = BR.ReadString : R.TipiajeEsp07 = BR.ReadString
                R.OtroExA = BR.ReadString
                R.OtroExA00 = BR.ReadString : R.OtroExA01 = BR.ReadString : R.OtroExA02 = BR.ReadString : R.OtroExA03 = BR.ReadString : R.OtroExA04 = BR.ReadString : R.OtroExA05 = BR.ReadString
                R.OtroExA06 = BR.ReadString : R.OtroExA07 = BR.ReadString
                R.OtroExB = BR.ReadString
                R.OtroExB00 = BR.ReadString : R.OtroExB01 = BR.ReadString : R.OtroExB02 = BR.ReadString : R.OtroExB03 = BR.ReadString : R.OtroExB04 = BR.ReadString : R.OtroExB05 = BR.ReadString
                R.OtroExB06 = BR.ReadString : R.OtroExB07 = BR.ReadString
                R.OtroExC = BR.ReadString
                R.OtroExC00 = BR.ReadString : R.OtroExC01 = BR.ReadString : R.OtroExC02 = BR.ReadString : R.OtroExC03 = BR.ReadString : R.OtroExC04 = BR.ReadString
                R.NombreDelControl = BR.ReadString
                R.Adicional01 = BR.ReadString
                R.ImpresionDx = BR.ReadString
                R.Orina = BR.ReadString
                R.Urocultivo = BR.ReadString
                R.Heces = BR.ReadString

                arrEmbarazosDeLaPteSeleccionada.Add(R)

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()


        Else 'no existe el archivo

            'no hay datos obstetricos para el paciente inicializa la arrray en blanco
            arrEmbarazosDeLaPteSeleccionada.Clear()
            estOBS = Nothing
        End If

    End Sub
    Private Sub subBuscaDatosObstetricosDeLaFechaSeleccionada()
        'busca datos de la fecha seleccionada si existen
        Dim strFechaBuscadaSDS = dateFechaSeleccionada.ToShortDateString

        'inicializa a O
        estOBS = Nothing

        'busca datos del control obs
        For Each est As Form1.TablaDeDatosObstetricos In arrEmbarazosDeLaPteSeleccionada

            'obtiene la FUR del embarazo revisado actual
            strFUR = est.FUR

            'revisa las fechas del control actual para ver cual coincide y sacar los datos de ahi
            If strFechaBuscadaSDS = est.Fecha00 Then
                'saca los datos de la linea 00
                dateFecha = CType(est.Fecha00, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso00 : estOBS.a03TAS = est.TAS00 : estOBS.a04TAD = est.TAD00
                estOBS.a05Ede = est.Edema00 : estOBS.a06AU = est.AU00 : estOBS.a07MF = est.MF00 : estOBS.a08FF = est.FF00
                estOBS.a09Obs = est.Obs00
            ElseIf strFechaBuscadaSDS = est.Fecha01 Then
                'saca los datos de la linea 01
                dateFecha = CType(est.Fecha01, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso01 : estOBS.a03TAS = est.TAS01 : estOBS.a04TAD = est.TAD01
                estOBS.a05Ede = est.Edema01 : estOBS.a06AU = est.AU01 : estOBS.a07MF = est.MF01 : estOBS.a08FF = est.FF01
                estOBS.a09Obs = est.Obs01
            ElseIf strFechaBuscadaSDS = est.Fecha02 Then
                'saca los datos de la linea 02
                dateFecha = CType(est.Fecha02, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso02 : estOBS.a03TAS = est.TAS02 : estOBS.a04TAD = est.TAD02
                estOBS.a05Ede = est.Edema02 : estOBS.a06AU = est.AU02 : estOBS.a07MF = est.MF02 : estOBS.a08FF = est.FF02
                estOBS.a09Obs = est.Obs02
            ElseIf strFechaBuscadaSDS = est.Fecha03 Then
                'saca los datos de la linea 03
                dateFecha = CType(est.Fecha03, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso03 : estOBS.a03TAS = est.TAS03 : estOBS.a04TAD = est.TAD03
                estOBS.a05Ede = est.Edema03 : estOBS.a06AU = est.AU03 : estOBS.a07MF = est.MF03 : estOBS.a08FF = est.FF03
                estOBS.a09Obs = est.Obs03
            ElseIf strFechaBuscadaSDS = est.Fecha04 Then
                'saca los datos de la linea 04
                dateFecha = CType(est.Fecha04, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso04 : estOBS.a03TAS = est.TAS04 : estOBS.a04TAD = est.TAD04
                estOBS.a05Ede = est.Edema04 : estOBS.a06AU = est.AU04 : estOBS.a07MF = est.MF04 : estOBS.a08FF = est.FF04
                estOBS.a09Obs = est.Obs04
            ElseIf strFechaBuscadaSDS = est.Fecha05 Then
                'saca los datos de la linea 05
                dateFecha = CType(est.Fecha05, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso05 : estOBS.a03TAS = est.TAS05 : estOBS.a04TAD = est.TAD05
                estOBS.a05Ede = est.Edema05 : estOBS.a06AU = est.AU05 : estOBS.a07MF = est.MF05 : estOBS.a08FF = est.FF05
                estOBS.a09Obs = est.Obs05
            ElseIf strFechaBuscadaSDS = est.Fecha06 Then
                'saca los datos de la linea 06
                dateFecha = CType(est.Fecha06, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso06 : estOBS.a03TAS = est.TAS06 : estOBS.a04TAD = est.TAD06
                estOBS.a05Ede = est.Edema06 : estOBS.a06AU = est.AU06 : estOBS.a07MF = est.MF06 : estOBS.a08FF = est.FF06
                estOBS.a09Obs = est.Obs06
            ElseIf strFechaBuscadaSDS = est.Fecha07 Then
                'saca los datos de la linea 07
                dateFecha = CType(est.Fecha07, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso07 : estOBS.a03TAS = est.TAS07 : estOBS.a04TAD = est.TAD07
                estOBS.a05Ede = est.Edema07 : estOBS.a06AU = est.AU07 : estOBS.a07MF = est.MF07 : estOBS.a08FF = est.FF07
                estOBS.a09Obs = est.Obs07
            ElseIf strFechaBuscadaSDS = est.Fecha08 Then
                'saca los datos de la linea 08
                dateFecha = CType(est.Fecha08, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso08 : estOBS.a03TAS = est.TAS08 : estOBS.a04TAD = est.TAD08
                estOBS.a05Ede = est.Edema08 : estOBS.a06AU = est.AU08 : estOBS.a07MF = est.MF08 : estOBS.a08FF = est.FF08
                estOBS.a09Obs = est.Obs08
            ElseIf strFechaBuscadaSDS = est.Fecha09 Then
                'saca los datos de la linea 09
                dateFecha = CType(est.Fecha09, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso09 : estOBS.a03TAS = est.TAS09 : estOBS.a04TAD = est.TAD09
                estOBS.a05Ede = est.Edema09 : estOBS.a06AU = est.AU09 : estOBS.a07MF = est.MF09 : estOBS.a08FF = est.FF09
                estOBS.a09Obs = est.Obs09
            ElseIf strFechaBuscadaSDS = est.Fecha10 Then
                'saca los datos de la linea 10
                dateFecha = CType(est.Fecha10, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso10 : estOBS.a03TAS = est.TAS10 : estOBS.a04TAD = est.TAD10
                estOBS.a05Ede = est.Edema10 : estOBS.a06AU = est.AU10 : estOBS.a07MF = est.MF10 : estOBS.a08FF = est.FF10
                estOBS.a09Obs = est.Obs10
            ElseIf strFechaBuscadaSDS = est.Fecha11 Then
                'saca los datos de la linea 11
                dateFecha = CType(est.Fecha11, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso11 : estOBS.a03TAS = est.TAS11 : estOBS.a04TAD = est.TAD11
                estOBS.a05Ede = est.Edema11 : estOBS.a06AU = est.AU11 : estOBS.a07MF = est.MF11 : estOBS.a08FF = est.FF11
                estOBS.a09Obs = est.Obs11
            ElseIf strFechaBuscadaSDS = est.Fecha12 Then
                'saca los datos de la linea 12
                dateFecha = CType(est.Fecha12, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso12 : estOBS.a03TAS = est.TAS12 : estOBS.a04TAD = est.TAD12
                estOBS.a05Ede = est.Edema12 : estOBS.a06AU = est.AU12 : estOBS.a07MF = est.MF12 : estOBS.a08FF = est.FF12
                estOBS.a09Obs = est.Obs12
            ElseIf strFechaBuscadaSDS = est.Fecha13 Then
                'saca los datos de la linea 13
                dateFecha = CType(est.Fecha13, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso13 : estOBS.a03TAS = est.TAS13 : estOBS.a04TAD = est.TAD13
                estOBS.a05Ede = est.Edema13 : estOBS.a06AU = est.AU13 : estOBS.a07MF = est.MF13 : estOBS.a08FF = est.FF13
                estOBS.a09Obs = est.Obs13
            ElseIf strFechaBuscadaSDS = est.Fecha14 Then
                'saca los datos de la linea 14
                dateFecha = CType(est.Fecha14, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso14 : estOBS.a03TAS = est.TAS14 : estOBS.a04TAD = est.TAD14
                estOBS.a05Ede = est.Edema14 : estOBS.a06AU = est.AU14 : estOBS.a07MF = est.MF14 : estOBS.a08FF = est.FF14
                estOBS.a09Obs = est.Obs14
            ElseIf strFechaBuscadaSDS = est.Fecha15 Then
                'saca los datos de la linea 15
                dateFecha = CType(est.Fecha15, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso15 : estOBS.a03TAS = est.TAS15 : estOBS.a04TAD = est.TAD15
                estOBS.a05Ede = est.Edema15 : estOBS.a06AU = est.AU15 : estOBS.a07MF = est.MF15 : estOBS.a08FF = est.FF15
                estOBS.a09Obs = est.Obs15
            ElseIf strFechaBuscadaSDS = est.Fecha16 Then
                'saca los datos de la linea 16
                dateFecha = CType(est.Fecha16, Date)
                estOBS.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                estOBS.a02Peso = est.Peso16 : estOBS.a03TAS = est.TAS16 : estOBS.a04TAD = est.TAD16
                estOBS.a05Ede = est.Edema16 : estOBS.a06AU = est.AU16 : estOBS.a07MF = est.MF16 : estOBS.a08FF = est.FF16
                estOBS.a09Obs = est.Obs16
            End If


        Next
    End Sub
    Function funcionCalculaEGretornaStringXXsXXd(ByVal dateFechaConsulta As Date) As String

        Dim Semanas As Long = 0
        Dim Calculo As Double
        Dim Dias As Integer
        Dim EG As Long

        If IsDate(strFUR) Then
            dateFUR = CType(strFUR, Date)
        Else
            Return "FUR ??"
        End If

        EG = (DateDiff(DateInterval.Day, dateFUR, dateFechaConsulta))
        If EG <= 0 Then
            Return "??"
        ElseIf EG > 294 Then
            Return "+42s"
        Else
            Semanas = EG \ 7
            Calculo = (EG / 7) - Semanas
            If Calculo = 0 Then
                Dias = 0
            Else
                Dias = CInt(Calculo * 7)
            End If
            Return Semanas & "s" & " " & Dias & "d"
        End If
    End Function
    Private Sub subGeneraNotasObstetricasAutomaticas()

        'inicializa autogenerado
        strAutoGeneradoControlObs = ""

        'revisa si hay consulta obstetrica en esta fecha
        If estOBS.a01EG = Nothing Then
            strAutoGeneradoControlObs += "No Hay Datos Obstétricos en esta fecha..." & vbCrLf
            Exit Sub 'sal prematuramente no hay datos
        End If

        'si llega aca hay algo lo genera
        Dim booEcribioAlgoEnLaLinea As Boolean = False

        strAutoGeneradoControlObs = "DATOS DEL CONTROL OBSTETRICO" & vbCrLf


        '1ra linea
        strAutoGeneradoControlObs += "Edad Gestacional x FUR: " & estOBS.a01EG & ". " & vbCrLf

        '2da linea
        booEcribioAlgoEnLaLinea = False
        If IsNumeric(estOBS.a02Peso) Then
            strAutoGeneradoControlObs += "Peso: " & estOBS.a02Peso & " Kg. "
            booEcribioAlgoEnLaLinea = True
        End If
        If IsNumeric(estOBS.a03TAS) And IsNumeric(estOBS.a04TAD) Then
            strAutoGeneradoControlObs += "TA: " & estOBS.a03TAS & "/" & estOBS.a04TAD & " mmHg."
            booEcribioAlgoEnLaLinea = True
        End If
        'revisa si escribio algo
        If booEcribioAlgoEnLaLinea = True Then
            strAutoGeneradoControlObs += vbCrLf
        End If

        '3ra linea
        booEcribioAlgoEnLaLinea = False
        If estOBS.a05Ede <> "" Then
            strAutoGeneradoControlObs += "Edema: " & estOBS.a05Ede & "  "
            booEcribioAlgoEnLaLinea = True
        End If
        If IsNumeric(estOBS.a06AU) Then
            strAutoGeneradoControlObs += "AU: " & estOBS.a06AU & " cm. "
            booEcribioAlgoEnLaLinea = True
        End If
        If estOBS.a07MF <> "" Then
            strAutoGeneradoControlObs += "MF: " & estOBS.a07MF & "  "
            booEcribioAlgoEnLaLinea = True
        End If
        If estOBS.a08FF <> "" Then
            If estOBS.a08FF.IndexOf("+"c) > -1 Or estOBS.a08FF.IndexOf("-"c) > -1 Then
                strAutoGeneradoControlObs += "FF: " & estOBS.a08FF
                booEcribioAlgoEnLaLinea = True
            ElseIf IsNumeric(estOBS.a08FF) Then
                strAutoGeneradoControlObs += "FF: " & estOBS.a08FF & " lpm."
                booEcribioAlgoEnLaLinea = True
            End If
        End If
        'revisa si escribio algo
        If booEcribioAlgoEnLaLinea = True Then
            strAutoGeneradoControlObs += vbCrLf
        End If

        '4ta linea
        If estOBS.a09Obs <> "" Then
            strAutoGeneradoControlObs += "Observaciones: " & estOBS.a09Obs & vbCrLf
        End If
    End Sub

    Private Sub subCargaEcografiasDeLaPteSeleccionada()

        Dim estH As New Form1.TablaDeDatosEcograficos()

        If File.Exists(strArchivoControlEcoDelPteSeleccionado) = True Then

            'existe el archivo lo lee
            FS = New FileStream(strArchivoControlEcoDelPteSeleccionado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)


            arrEcosDelPacienteActual.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                estH = Nothing
                ' Read fields and populate structure
                estH.c00TipoDeEstudio = BR.ReadString
                estH.c01FechaControl = BR.ReadString
                estH.c02Paridad = BR.ReadString
                estH.c03FUR = BR.ReadString
                estH.c04FPP = BR.ReadString
                estH.c05EGxFUR = BR.ReadString
                estH.c06IDx = BR.ReadString
                estH.c07Nombre = BR.ReadString
                estH.c08Edad = BR.ReadString
                estH.d01SGlongitudinal = BR.ReadString
                estH.d02SGanteroposterior = BR.ReadString
                estH.d03SGtransversal = BR.ReadString
                estH.d04LCC = BR.ReadString
                estH.d05ImplatacionSG = BR.ReadString
                estH.d06EmbrionVisible = BR.ReadString
                estH.d07MovimientosPresentes = BR.ReadString
                estH.d08ActividadCardiaca = BR.ReadString
                estH.d09Comentarios1erT = BR.ReadString
                estH.d10OtroA = BR.ReadString
                estH.d11AdicionalesB1erT = BR.ReadString
                estH.d12IDxAdicionales1erT = BR.ReadString
                estH.d13Adicionales1erT = BR.ReadString
                estH.e01Presentacion = BR.ReadString
                estH.e02Situacion = BR.ReadString
                estH.e03Posicion = BR.ReadString
                estH.e04Cabeza = BR.ReadString
                estH.e05Ventriculos = BR.ReadString
                estH.e06Columna = BR.ReadString
                estH.e07Torax = BR.ReadString
                estH.e08Corazon = BR.ReadString
                estH.e09Abdomen = BR.ReadString
                estH.e10Riñones = BR.ReadString
                estH.e11Extremidades = BR.ReadString
                estH.e12Notas01del2y3erT = BR.ReadString
                estH.e13DiametroBiParietal = BR.ReadString
                estH.e14DiametroOccipitoFrontal = BR.ReadString
                estH.e15DiametroAnteroPosteriorTorax = BR.ReadString
                estH.e16DiametroAnteroPosteriorCorazon = BR.ReadString
                estH.e17aDiametroAnteroPosteriorAbdomen = BR.ReadString
                estH.e17bDiametroTransversoAbdomen = BR.ReadString
                estH.e18Aorta = BR.ReadString
                estH.e19VenaCava = BR.ReadString
                estH.e20LongitudSacro = BR.ReadString
                estH.e21LongitudFemur = BR.ReadString
                estH.e22Actitud = BR.ReadString
                estH.e23Tono = BR.ReadString
                estH.e24MovimientosFetales = BR.ReadString
                estH.e25ActividadCardiaca = BR.ReadString
                estH.e26MovimientosRespiratorios = BR.ReadString
                estH.e27RelacionAortoCava = BR.ReadString
                estH.e28CamaraGastrica = BR.ReadString
                estH.e29Intestino = BR.ReadString
                estH.e30Vejiga = BR.ReadString
                estH.e31Notas02del2y3erT = BR.ReadString
                estH.e32LocalizacionPlacenta = BR.ReadString
                estH.e33GrosorPlacenta = BR.ReadString
                estH.e34GradoPlacenta = BR.ReadString
                estH.e35LiquidoAmniotico = BR.ReadString
                estH.e36ILA = BR.ReadString
                estH.e37CordonUmbilical = BR.ReadString
                estH.e38Notas03del2y3erT = BR.ReadString
                estH.e39Embarazo = BR.ReadString
                estH.e40Feto = BR.ReadString
                estH.e41BiometricosAdicionales = BR.ReadString
                estH.e42Rostro = BR.ReadString
                estH.e43Sexo = BR.ReadString
                estH.f01Menopausia = BR.ReadString
                estH.f02EstudioPorVia = BR.ReadString
                estH.f03UteroLongitudinal = BR.ReadString
                estH.f04UteroAnteroposterior = BR.ReadString
                estH.f05UteroTransverso = BR.ReadString
                estH.f06OvarioDerechoLongitudinal = BR.ReadString
                estH.f07OvarioDerechoTransverso = BR.ReadString
                estH.f08OvarioDerechoAnteroPosterior = BR.ReadString
                estH.f09OvarioIzquierdoLongitudinal = BR.ReadString
                estH.f10OvarioIzquierdoTransverso = BR.ReadString
                estH.f11OvarioIzquierdoAnteroPosterior = BR.ReadString
                estH.f12FoliculoDerecho01 = BR.ReadString
                estH.f13FoliculoDerecho02 = BR.ReadString
                estH.f14FoliculoDerecho03 = BR.ReadString
                estH.f15FoliculoDerecho04 = BR.ReadString
                estH.f16FoliculoIzquierdo01 = BR.ReadString
                estH.f17FoliculoIzquierdo02 = BR.ReadString
                estH.f18FoliculoIzquierdo03 = BR.ReadString
                estH.f19FoliculoIzquierdo04 = BR.ReadString
                estH.f20EndometrioGrosor = BR.ReadString
                estH.f21ObsGinecologicas = BR.ReadString
                estH.f22OtrosA = BR.ReadString
                estH.f23OtrosB = BR.ReadString
                estH.f24OtrosC = BR.ReadString
                estH.f25AdicionalesGin = BR.ReadString
                estH.r01SGPromedio = BR.ReadString
                estH.r02EGxSG = BR.ReadString
                estH.r03EGxLCC = BR.ReadString
                estH.r04EG1erT = BR.ReadString
                estH.r05DBPc = BR.ReadString
                estH.r06CirCef = BR.ReadString
                estH.r07IndCef = BR.ReadString
                estH.r08CirAbd = BR.ReadString
                estH.r09DBF = BR.ReadString
                estH.r10EGxDBP = BR.ReadString
                estH.r11EGxDBPc = BR.ReadString
                estH.r12EGxCC = BR.ReadString
                estH.r13EGxCA = BR.ReadString
                estH.r14EGxFemur = BR.ReadString
                estH.r15PesoEstimado = BR.ReadString
                estH.r16PesoenBaseA = BR.ReadString
                estH.r17EG2y3erT = BR.ReadString
                estH.r18DiaCiclo = BR.ReadString
                estH.r19OtroA = BR.ReadString
                estH.r20OtroB = BR.ReadString
                estH.r21OtroC = BR.ReadString
                estH.e44ChorizoDiagnostico = BR.ReadString
                estH.c09NombreInforme = BR.ReadString

                arrEcosDelPacienteActual.Add(estH)

                'inicia llenado del array de fechas de controles anteriores para despues ordenarlas

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        Else
            'no hay datos ecograficos para el paciente inicializa la arrray en blanco
            arrEcosDelPacienteActual.Clear()
        End If

    End Sub
    Private Sub subBuscaDatosEcograficosDeLaFechaSeleccionada()
        'busca datos de la fecha seleccionada si existen
        Dim strFechaBuscadaSDS = dateFechaSeleccionada.ToShortDateString


        estECO = Nothing

        For Each est As Form1.TablaDeDatosEcograficos In arrEcosDelPacienteActual
            Dim dateFechaComparada As Date = CType(est.c01FechaControl, Date)
            Dim strFechaComparadaSDS As String = dateFechaComparada.ToShortDateString

            If strFechaBuscadaSDS = strFechaComparadaSDS Then
                'este es el hombre. primero saca todos los datos directos


                'ahora verifica que tipo de eco es
                If est.c00TipoDeEstudio = "1" Then
                    'es del 1er trim
                    estECO.a00TipoDeEstudio = "1erTrim"
                    If est.d04LCC <> "" Then
                        estECO.a01DCN = est.d04LCC
                    Else
                        estECO.a01DCN = "-"
                    End If

                    'saca los de chorizo biometrico 2 del 1er trimestre
                    If est.d11AdicionalesB1erT <> "" Then 'revisa q ya este convertido
                        Dim arrPartesBiometricasAdicionales1erT() = est.d11AdicionalesB1erT.Split("|"c)

                        'verifica si tienen datos numericos validos
                        If IsNumeric(arrPartesBiometricasAdicionales1erT(0)) Then 'dbp 1er t
                            estECO.a02DBP = arrPartesBiometricasAdicionales1erT(0)
                        Else
                            estECO.a02DBP = "-"
                        End If

                        If IsNumeric(arrPartesBiometricasAdicionales1erT(1)) Then 'cc del 1er t
                            estECO.a03CC = arrPartesBiometricasAdicionales1erT(1)
                        Else
                            estECO.a03CC = "-"
                        End If

                        If IsNumeric(arrPartesBiometricasAdicionales1erT(2)) Then 'ca del 1er t
                            estECO.a04CA = arrPartesBiometricasAdicionales1erT(2)
                        Else
                            estECO.a04CA = "-"
                        End If

                        If IsNumeric(arrPartesBiometricasAdicionales1erT(3)) Then
                            estECO.a05FEM = arrPartesBiometricasAdicionales1erT(3)
                        Else
                            estECO.a05FEM = "-"
                        End If
                    Else
                        'es viejo y no tiene 2do chorizo del 1er trim todo a guioncito
                        estECO.a02DBP = "-"
                        estECO.a03CC = "-"
                        estECO.a04CA = "-"
                        estECO.a05FEM = "-"
                    End If

                    estECO.a06PesoEst = "-"
                    estECO.a07Talla = "-"

                    'saca la edad gestacional del 1er trim
                    If est.r04EG1erT <> "Faltan Datos" Then
                        Dim strEG1erTrimLong As String = est.r04EG1erT
                        If strEG1erTrimLong.IndexOf("Exactas.") > -1 Then
                            'es de terminacion exacta, sustiutuye toda las letras x S
                            estECO.a08EGxEco = strEG1erTrimLong.Replace(" Semanas Exactas.", "s 0d")
                        ElseIf strEG1erTrimLong.IndexOf("días.") > -1 Then
                            'se temina en distinto de 1 dia
                            estECO.a08EGxEco = strEG1erTrimLong.Replace(" Semanas y", "s")
                            estECO.a08EGxEco = estECO.a08EGxEco.Replace(" días.", "d")
                        Else
                            'se tiene q haber terminado en 1 dia
                            estECO.a08EGxEco = strEG1erTrimLong.Replace(" Semanas y", "s")
                            estECO.a08EGxEco = estECO.a08EGxEco.Replace(" día.", "d")
                        End If
                    Else
                        estECO.a08EGxEco = "N/A"
                    End If

                    estECO.a09Percen = "-"

                    'el saco gestacional
                    Dim intTotal As Integer = 0
                    Dim intCuenta As Integer = 0
                    'verifica datos validos
                    If IsNumeric(est.d01SGlongitudinal) Then
                        intTotal += est.d01SGlongitudinal
                        intCuenta += 1
                    End If
                    If IsNumeric(est.d02SGanteroposterior) Then
                        intTotal += est.d02SGanteroposterior
                        intCuenta += 1
                    End If
                    If IsNumeric(est.d03SGtransversal) Then
                        intTotal += est.d03SGtransversal
                        intCuenta += 1
                    End If
                    'saca promedio si puede y lo coloca en la estructurita
                    If intCuenta > 0 Then
                        'hay datos los calcula
                        estECO.a10SG = intTotal \ intCuenta
                    Else
                        estECO.a10SG = "-"
                    End If

                    'la presentacion y situacion
                    estECO.a11Pres = "-"
                    estECO.a12Sit = "-"



                ElseIf est.c00TipoDeEstudio = "2" Then

                    'es del 2y3 trim
                    estECO.a00TipoDeEstudio = "2doy3erTrim"
                    estECO.a01DCN = "-"
                    If IsNumeric(est.e13DiametroBiParietal) Then
                        estECO.a02DBP = est.e13DiametroBiParietal
                    Else
                        estECO.a02DBP = "-"
                    End If
                    If IsNumeric(est.e21LongitudFemur) Then
                        estECO.a05FEM = est.e21LongitudFemur
                    Else
                        estECO.a05FEM = "-"
                    End If
                    'saca los de chorizo biometrico
                    If est.e41BiometricosAdicionales <> "" Then 'revisa q ya este convertido
                        Dim arrPartesBiometricas() = est.e41BiometricosAdicionales.Split("|"c)

                        'verifica si tienen datos numericos validos
                        If IsNumeric(arrPartesBiometricas(0)) Then
                            estECO.a03CC = arrPartesBiometricas(0)
                        Else
                            estECO.a03CC = "-"
                        End If

                        If IsNumeric(arrPartesBiometricas(6)) Then
                            estECO.a04CA = arrPartesBiometricas(6)
                        Else
                            estECO.a04CA = "-"
                        End If

                        If IsNumeric(arrPartesBiometricas(14)) Then
                            estECO.a06PesoEst = arrPartesBiometricas(14)
                        Else
                            estECO.a06PesoEst = "-"
                        End If

                        If IsNumeric(arrPartesBiometricas(15)) Then
                            estECO.a07Talla = arrPartesBiometricas(15)
                        Else
                            estECO.a07Talla = "-"
                        End If
                    Else
                        'es viejo y no tiene chorizo biometrico todo a guioncito
                        estECO.a03CC = "-"
                        estECO.a04CA = "-"
                        estECO.a06PesoEst = "-"
                        estECO.a07Talla = "-"
                    End If

                    'ahora revisa el chorizodx del 2y3er trim
                    If est.e44ChorizoDiagnostico <> "" Then
                        'hay chorizo dx lo revisa
                        Dim arrPartesDxDel2y3erTrim() = est.e44ChorizoDiagnostico.Split("|"c)

                        'saca la edad gestacional del 2y3er trim
                        If arrPartesDxDel2y3erTrim(0) <> "@" And arrPartesDxDel2y3erTrim(0) <> "Faltan datos." Then
                            Dim strEG2y3erTrimLong As String = arrPartesDxDel2y3erTrim(0)
                            If strEG2y3erTrimLong.IndexOf("Exactas.") > -1 Then
                                'es de terminacion exacta, sustiutuye toda las letras x S
                                estECO.a08EGxEco = strEG2y3erTrimLong.Replace(" Semanas Exactas.", "s 0d")
                            ElseIf strEG2y3erTrimLong.IndexOf("días.") > -1 Then
                                'se temina en distinto de 1 dia
                                estECO.a08EGxEco = strEG2y3erTrimLong.Replace(" Semanas y", "s")
                                estECO.a08EGxEco = estECO.a08EGxEco.Replace(" días.", "d")
                            Else
                                'se tiene q haber terminado en 1 dia
                                estECO.a08EGxEco = strEG2y3erTrimLong.Replace(" Semanas y", "s")
                                estECO.a08EGxEco = estECO.a08EGxEco.Replace(" día.", "d")
                            End If
                        Else
                            estECO.a08EGxEco = "N/A"
                        End If

                        'el percentil
                        If IsNumeric(arrPartesDxDel2y3erTrim(1)) Then
                            estECO.a09Percen = arrPartesDxDel2y3erTrim(1)
                        Else
                            estECO.a09Percen = "-"
                        End If


                    Else
                        'no habia info en el chorizo dx
                        estECO.a08EGxEco = "N/A"
                        estECO.a09Percen = "-"
                    End If

                    'el saco gestacional
                    estECO.a10SG = "-"

                    'la pres 
                    If est.e01Presentacion = "1" Then
                        estECO.a11Pres = "Cef"
                    ElseIf est.e01Presentacion = "2" Then
                        estECO.a11Pres = "Pod"
                    Else
                        estECO.a11Pres = "-"
                    End If

                    'la situacion
                    If est.e02Situacion = "1" Then
                        estECO.a12Sit = "Long"
                    ElseIf est.e02Situacion = "2" Then
                        estECO.a12Sit = "Obli"
                    Else
                        estECO.a12Sit = "Tras"
                    End If


                Else
                    'es un eco ginecologico debe acomodarse esto


                End If


                Exit For
            End If
        Next


    End Sub
    Private Sub subGeneraNotasEcograficasAutomaticas()

        'inicializa autogenerado
        strAutoGeneradoEco = ""

        If estECO.a00TipoDeEstudio = Nothing Then
            'no hay eco asociado en esta fecha
            strAutoGeneradoEco += "No se ha realizado ECOGRAFIA en este día."
        ElseIf estECO.a00TipoDeEstudio = "1erTrim" Then
            'es del 1er trimestre
            strAutoGeneradoEco += "DATOS ECOGRAFICOS (1er Trimestre)" & vbCrLf
            If estECO.a10SG <> "-" Then
                strAutoGeneradoEco += "SG: " & estECO.a10SG & "mm. "
            End If
            If estECO.a01DCN <> "-" Then
                strAutoGeneradoEco += "DCN: " & estECO.a01DCN & "mm. "
            End If
            If estECO.a02DBP <> "-" Then
                strAutoGeneradoEco += "DBP: " & estECO.a02DBP & "mm. "
            End If
            If estECO.a03CC <> "-" Then
                strAutoGeneradoEco += "CC: " & estECO.a03CC & "mm. "
            End If
            If estECO.a04CA <> "-" Then
                strAutoGeneradoEco += "CA: " & estECO.a04CA & "mm. "
            End If
            If estECO.a05FEM <> "-" Then
                strAutoGeneradoEco += "Fem: " & estECO.a05FEM & "mm."
            End If

            If estECO.a10SG <> "-" Or estECO.a01DCN <> "-" Or estECO.a02DBP <> "-" Or estECO.a03CC <> "-" Or estECO.a04CA <> "-" Or estECO.a05FEM <> "-" Then
                'si se escribio algo entonces baja la linea
                strAutoGeneradoEco += vbCrLf
            End If
            strAutoGeneradoEco += "Edad Gestacional x Eco: " & estECO.a08EGxEco & vbCrLf
        Else
            'es del 2do y 3er trimestre
            strAutoGeneradoEco += "DATOS ECOGRAFICOS (2do y 3er Trimestre)" & vbCrLf
            If estECO.a11Pres <> "-" Then
                strAutoGeneradoEco += "Presentación: " & estECO.a11Pres & ", Situación: " & estECO.a12Sit & "." & vbCrLf
            Else
                strAutoGeneradoEco += "Presentación: n/a, Situación: " & estECO.a12Sit & "." & vbCrLf
            End If

            'linea de los biometricos
            If estECO.a02DBP <> "-" Then
                strAutoGeneradoEco += "DBP: " & estECO.a02DBP & "mm. "
            End If
            If estECO.a03CC <> "-" Then
                strAutoGeneradoEco += "CC: " & estECO.a03CC & "mm. "
            End If
            If estECO.a04CA <> "-" Then
                strAutoGeneradoEco += "CA: " & estECO.a04CA & "mm. "
            End If
            If estECO.a05FEM <> "-" Then
                strAutoGeneradoEco += "Fem: " & estECO.a05FEM & "mm. "
            End If
            'revisa si se escribio algo
            If estECO.a02DBP <> "-" Or estECO.a03CC <> "-" Or estECO.a04CA <> "-" Or estECO.a05FEM <> "-" Then
                strAutoGeneradoEco += vbCrLf 'se escribio algo baja la linea
            End If

            'linea de peso , talla y percentil
            If estECO.a06PesoEst <> "-" Then
                strAutoGeneradoEco += "Peso estimado: " & estECO.a06PesoEst & "gr. "
            End If
            If estECO.a07Talla <> "-" Then
                strAutoGeneradoEco += "Talla: " & estECO.a07Talla & "cm. "
            End If
            If estECO.a09Percen <> "-" Then
                strAutoGeneradoEco += "Percentil: " & estECO.a09Percen & "."
            End If
            'revisa si escribio algo
            If estECO.a06PesoEst <> "-" Or estECO.a07Talla <> "-" Or estECO.a09Percen <> "-" Then
                strAutoGeneradoEco += vbCrLf 'se escribio algo baja la linea
            End If

            'linea de la edad ges x eco
            If estECO.a08EGxEco <> "-" Then
                strAutoGeneradoEco += "Edad Gestacional x Eco: " & estECO.a08EGxEco & vbCrLf
            End If

            'sustituciones finales
            strAutoGeneradoEco = strAutoGeneradoEco.Replace("Cef", "Cefálica")
            strAutoGeneradoEco = strAutoGeneradoEco.Replace("Pod", "Podálica")
            strAutoGeneradoEco = strAutoGeneradoEco.Replace("Long", "Longitudinal")
            strAutoGeneradoEco = strAutoGeneradoEco.Replace("Obli", "Oblícua")
            strAutoGeneradoEco = strAutoGeneradoEco.Replace("Tras", "Trasversa")

        End If
    End Sub

    '=============Parte de los meses======================================================

    Private Sub ConstruyeNombreControlMensual()
        'primero muestra que mes esta seleccionado
        strMesSeleccionadoCadena = MonthName(strMesSeleccionadoNumero)
        labMesSeleccionado.Text = strMesSeleccionadoCadena & " de " & strAñoSeleccionadoNumerodeMes

        'ahora construye el nombre del archivo de control de meses
        Dim Mes, Año As String
        'primero la cadena del mes
        If strMesSeleccionadoNumero < 10 Then
            Mes = "0" & strMesSeleccionadoNumero.ToString
        Else
            Mes = strMesSeleccionadoNumero.ToString
        End If
        'ahora la cadena de año
        Año = strAñoSeleccionadoNumerodeMes.ToString

        strArchivoControlMensual = Form1.PSstrPathAgendaBDH & "\" & Año & "\Control-" & Año & Mes & ".agd"
        'Label2.Text = ArchivoControlMensual
    End Sub

    Private Sub VerificaMes()
        '000000000000000000000000000000000000
        'verificacion de meses
        Dim Fecha As Date
        Dim Linea As String
        Dim FechaFormateada As String
        Dim decHonorarios As Decimal
        Dim decHonorariosTotalesMes As Decimal
        Dim strHonorariosFormateadosMes As String
        Dim NumeroPacientesMes As Integer

        'limpia lista de pacientes
        ListBoxPacientesMes.Items.Clear()

        'inicializa las variables dependientes
        decHonorarios = 0
        decHonorariosTotalesMes = 0
        NumeroPacientesMes = 0

        'ahora revisa si hay un archivo de control de ese dia
        If File.Exists(strArchivoControlMensual) = True Then
            'existe un archivo de control de este mes, lo lee
            FS = New FileStream(strArchivoControlMensual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            alsControlesDelMes.Clear()
            ArraydeLineas.Clear()
            ArrayListaControlesMes.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                CDMA = Nothing
                ' Read fields and populate structure
                CDMA.a01NumeroHistoria = BR.ReadString
                CDMA.a02Nombre = BR.ReadString
                CDMA.a03Cedula = BR.ReadString
                CDMA.a04Clinica = BR.ReadString
                CDMA.a05NotaseIDx = BR.ReadString
                CDMA.a06Tratamiento = BR.ReadString
                CDMA.a07Pendiente = BR.ReadString
                CDMA.a08ProximaConsulta = BR.ReadString
                CDMA.a09Honorarios = BR.ReadString
                CDMA.a10FechaConsulta = BR.ReadString
                CDMA.a11FacturaAsociada = BR.ReadString
                CDMA.a16Referencia = BR.ReadString
                CDMA.a15Banco = BR.ReadString
                CDMA.a14FormaDePago = BR.ReadString
                CDMA.a13FechaDePago = BR.ReadString
                CDMA.a12Pagador = BR.ReadString

                'calcula honorarios de esta consulta
                If IsNumeric(CDMA.a09Honorarios) Then
                    decHonorarios = CType(CDMA.a09Honorarios, Decimal)
                Else
                    decHonorarios = 0
                End If
                decHonorariosTotalesMes += decHonorarios
                'calcula los pacientes q van
                NumeroPacientesMes += 1
                '0000000000000000000000000


                'formatea fecha
                Fecha = CType(CDMA.a10FechaConsulta, Date)
                FechaFormateada = Fecha.ToString("s")
                'crea la linea  
                Linea = FechaFormateada & "|" & CDMA.a01NumeroHistoria & "|" & CDMA.a02Nombre
                ArraydeLineas.Add(Linea)
                'va preparando la lista para la impresion
                Dim strHonFormateados = FormatNumber(decHonorarios, 2,,, TriState.True)
                Linea = Fecha.ToString("s") & "|" & CDMA.a03Cedula & "|" & CDMA.a01NumeroHistoria & "|" & CDMA.a02Nombre & "|" & "Bs. " & strHonFormateados.PadLeft(11) & "|" & CDMA.a04Clinica
                ArrayListaControlesMes.Add(Linea)
                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While

            BR.Close()
            FS.Close()

            '=====================================

            If NumeroPacientesMes > 0 Then
                'el archivo no esta vacio, lo ordena
                botImprimeConsultasDelMes.Enabled = True

                'prende el list box para poder seleccionar de la lista
                ListBoxPacientesMes.Enabled = True

                'ojo: obtiene el largo del numero de historia
                LargoDelNumeroDeHistoria = CDMA.a01NumeroHistoria.Length

                'ordena segun las fechas
                ArraydeLineas.Sort()
                'ahora prepara la array donde se guardaran el numero de historia en el orden del list box
                ArrayNumerosMesOrdenados.Clear()
                'ahora formatea las fechas
                REnum = ArraydeLineas.GetEnumerator

                Dim restodelaLinea As String
                Dim NumeroDeHistoriaOrdenado As String

                While REnum.MoveNext
                    Linea = CType(REnum.Current, String)
                    'deja los primeros 19 caracteres (fecha) en la variable fechaformateada
                    FechaFormateada = Linea.Substring(0, 19)
                    'asiga la fechaformateada a la variable fecha as date
                    Fecha = CType(FechaFormateada, Date)
                    'ahora devuelve la fecha  a la fecha formateada pero con formato de fecha corta
                    FechaFormateada = Fecha.ToShortDateString ' lista la fecha
                    'ahora agarra el resto de la linea
                    restodelaLinea = Linea.Remove(0, 20) 'quita los primeros 20 caracteres (la fecha) y el separador
                    NumeroDeHistoriaOrdenado = restodelaLinea.Substring(0, LargoDelNumeroDeHistoria)
                    'ahora rellena la estructurita O con los datos
                    OM.NumeroHistoria = NumeroDeHistoriaOrdenado
                    OM.FechaControl = FechaFormateada
                    ArrayNumerosMesOrdenados.Add(OM)
                    'reconstituye la linea
                    Linea = FechaFormateada & "|" & restodelaLinea
                    'la añade formateada y en orden de fecha al list box
                    ListBoxPacientesMes.Items.Add(Linea)
                End While
            Else
                'el archivo esta vacio, se creó pero no se le ha metido ninguna cita programada
                ListBoxPacientesMes.Items.Add("No hay consultas registradas en este mes")
                ListBoxPacientesMes.Enabled = False
                'apaga el boton de imprimir la lista ¿cual lista?
                botImprimeConsultasDelMes.Enabled = False
            End If
            '================================
            'muestra los honorarios del mes
            strHonorariosFormateadosMes = FormatCurrency(decHonorariosTotalesMes, 2, , , TriState.True)
            labHonorariosTotalesMes.Text = strHonorariosFormateadosMes
            'muestra cuantos pacientes
            labNumeroPacientesMes.Text = NumeroPacientesMes.ToString
        Else
            'no hay pacientes vistas este mes
            ListBoxPacientesMes.Items.Add("No hay consultas registradas en este mes")
            ListBoxPacientesMes.Enabled = False
            'muestra los honorarios del mes
            strHonorariosFormateadosMes = FormatCurrency(decHonorariosTotalesMes, 2, ,, TriState.True)
            labHonorariosTotalesMes.Text = strHonorariosFormateadosMes
            'muestra cuantos pacientes
            labNumeroPacientesMes.Text = NumeroPacientesMes.ToString
            'apaga el boton de imprimir la lista ¿cual lista?
            botImprimeConsultasDelMes.Enabled = False
        End If
    End Sub

    Private Sub botAdelantaMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdelantaMes.Click
        strMesSeleccionadoNumero += 1
        If strMesSeleccionadoNumero = 13 Then
            strMesSeleccionadoNumero = 1
            strAñoSeleccionadoNumerodeMes += 1
        End If
        'MuestraMes
        ConstruyeNombreControlMensual()
        VerificaMes()
        BorraDatosPacienteSeleccionadoMes()
    End Sub

    Private Sub botRetrocedeMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRetrocedeMes.Click
        strMesSeleccionadoNumero -= 1
        If strMesSeleccionadoNumero = 0 Then
            strMesSeleccionadoNumero = 12
            strAñoSeleccionadoNumerodeMes -= 1
        End If
        'MuestraMes
        ConstruyeNombreControlMensual()
        VerificaMes()
        BorraDatosPacienteSeleccionadoMes()
    End Sub

    Private Sub BorraDatosPacienteSeleccionadoMes()
        'borra datos del paciente seleccioado de la lista de consultas en el mes
        labNumeroHistoriaMes.Text = ""
        labNombreMes.Text = ""
        LabCedulaMes.Text = ""
        labLugarMes.Text = ""
        labHonorariosMes.Text = ""
        labFacturaMes.Text = ""
        labProximaMes.Text = ""
        labPagadorMes.Text = ""
        txtAUTOmes.Clear()
        txtIDxMes.Clear()
        txtTtoMes.Clear()
        txtPendienteMes.Clear()
    End Sub

    Private Sub ListBoxPacientesMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxPacientesMes.SelectedIndexChanged


        Dim Indice As Integer
        Dim HistoriaBuscada As String
        Dim FechaBuscada As Date
        'Dim FechaCadena As String
        Dim Largo As String
        Dim Año As Integer
        'Dim ArchivoProximaCita As String
        Dim Temporal As String
        Dim FechaDe8 As String
        Dim FechaDe6 As String
        Dim decHonorarios As Decimal
        Dim strFormatoMoneda As String

        Indice = ListBoxPacientesMes.SelectedIndex
        OM = ArrayNumerosMesOrdenados(Indice)
        HistoriaBuscada = OM.NumeroHistoria

        labNumeroHistoriaMes.Text = HistoriaBuscada

        FechaBuscada = OM.FechaControl

        Temporal = FechaBuscada.ToString("s")
        Largo = Temporal.Length
        FechaDe8 = Temporal.Remove(Largo - 9, 9)
        FechaDe8 = FechaDe8.Remove(4, 1)
        FechaDe8 = FechaDe8.Remove(6, 1)
        FechaDe6 = FechaDe8.Remove(6, 2)

        Año = FechaBuscada.Year

        strArchivoControlMensual = Form1.PSstrPathAgendaBDH & "\" & Año & "\Control-" & FechaDe6 & ".agd"

        BorraDatosPacienteSeleccionadoMes()
        'busca archivo de proximas consultas
        If File.Exists(strArchivoControlMensual) Then
            'existe un archivo de control mensual lo carga
            FS = New FileStream(strArchivoControlMensual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'ya Dim C se definio un poco arriba por eso falta aca
            C = BR.PeekChar
            While FS.Position < FS.Length
                CDMA = Nothing
                ' Read fields and populate structure
                CDMA.a01NumeroHistoria = BR.ReadString
                CDMA.a02Nombre = BR.ReadString
                CDMA.a03Cedula = BR.ReadString
                CDMA.a04Clinica = BR.ReadString
                CDMA.a05NotaseIDx = BR.ReadString
                CDMA.a06Tratamiento = BR.ReadString
                CDMA.a07Pendiente = BR.ReadString
                CDMA.a08ProximaConsulta = BR.ReadString
                CDMA.a09Honorarios = BR.ReadString
                CDMA.a10FechaConsulta = BR.ReadString
                CDMA.a11FacturaAsociada = BR.ReadString
                CDMA.a16Referencia = BR.ReadString
                CDMA.a15Banco = BR.ReadString
                CDMA.a14FormaDePago = BR.ReadString
                CDMA.a13FechaDePago = BR.ReadString
                CDMA.a12Pagador = BR.ReadString

                'compara el numero de historia para ver si es esta la que se debe mostrar
                If CDMA.a01NumeroHistoria = HistoriaBuscada Then
                    'esta es la historia ahora ve si es la fecha
                    If CDMA.a10FechaConsulta = FechaBuscada Then
                        'esta es, la muestra
                        labNumeroHistoriaMes.Text = CDMA.a01NumeroHistoria
                        labNombreMes.Text = CDMA.a02Nombre
                        'las Cedulas
                        Dim CedulaActual As String = ""
                        CedulaActual = CDMA.a03Cedula
                        CedulaActual = CedulaActual.Substring(0, 2) & "." & CedulaActual.Substring(2, 3) & "." & CedulaActual.Substring(5, 3)
                        If CedulaActual(0) = "0" Then
                            CedulaActual = CedulaActual.Remove(0, 1)
                        End If
                        LabCedulaMes.Text = CedulaActual
                        labLugarMes.Text = CDMA.a04Clinica
                        'la proxima cita
                        If CDMA.a08ProximaConsulta.IndexOf("-"c) > -1 Then
                            'tiene formato de string("s") primero transforma
                            labProximaMes.Text = (CType(CDMA.a08ProximaConsulta, Date)).ToLongDateString
                        Else
                            'o esta vacio o en formato de LDS de una vez lo muestra
                            labProximaMes.Text = CDMA.a08ProximaConsulta
                        End If
                        txtIDxMes.Text = CDMA.a05NotaseIDx
                        txtTtoMes.Text = CDMA.a06Tratamiento
                        txtPendienteMes.Text = CDMA.a07Pendiente

                        'formatea honorarios
                        If IsNumeric(CDMA.a09Honorarios) Then
                            decHonorarios = CType(CDMA.a09Honorarios, Decimal)
                        Else
                            decHonorarios = 0
                        End If
                        strFormatoMoneda = FormatCurrency(decHonorarios, 2, ,, TriState.True)
                        labHonorariosMes.Text = strFormatoMoneda

                        'la factura
                        If CDMA.a11FacturaAsociada <> "" Then
                            labFacturaMes.Text = CDMA.a11FacturaAsociada.PadLeft(5, "0"c)
                        Else
                            labFacturaMes.Text = ""
                        End If

                        'el pagador
                        labPagadorMes.Text = CDMA.a12Pagador

                        Exit While 'ya mostro lo q queria

                    End If
                End If
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
        Else
            labNumeroHistoriaMes.Text = "Consulta no disponible"
        End If

        '==============Busca Auto Generados de Mes=========

        strNumeroHistoriaSeleccionado = HistoriaBuscada

        dateFechaSeleccionada = FechaBuscada

        subGeneraDatosAutomaticos()

        txtAUTOmes.Text = strAutoGeneradoControlObs & vbCrLf & strAutoGeneradoEco
        '===================================================

    End Sub


    'Parte de los años

    Private Sub ConstruyeNombreControlAnual()
        Dim Año As String
        'primero muestra que año esta seleccionado
        labAñoSeleccionado.Text = strAñoSeleccionadoNumerodeAño
        'construye el nombre de control anual
        Año = strAñoSeleccionadoNumerodeAño.ToString
        strArchivoControlAnual = Form1.PSstrPathAgendaBDH & "\" & Año & "\Control-" & Año & ".agd"
    End Sub

    Private Sub VerificaAño()

        '000000000000000000000000000000000000
        'verificacion de años

        'variables de verificacion de años
        Dim FechaFormateada As String
        Dim Fecha As Date
        Dim decHonorarios As Decimal
        Dim decHonorariosTotalesAño As Decimal
        Dim strHonorariosFormateadosAño As String
        Dim NumeroPacientesAño As Integer
        Dim Linea As String
        Dim LargoDelNumeroDeHistoria As Integer

        'limpia lista de pacientes
        ListBoxPacientesAño.Items.Clear()

        'inicializa las variables dependientes
        decHonorarios = 0
        decHonorariosTotalesAño = 0
        NumeroPacientesAño = 0

        'ahora revisa si hay un archivo de control de ese año
        If File.Exists(strArchivoControlAnual) = True Then
            'existe un archivo de control de este año, lo lee
            FS = New FileStream(strArchivoControlAnual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            alsControlesDelAño.Clear()
            ArraydeLineas.Clear()
            ArrayListaControlesAño.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                CDMA = Nothing
                ' Read fields and populate structure
                CDMA.a01NumeroHistoria = BR.ReadString
                CDMA.a02Nombre = BR.ReadString
                CDMA.a03Cedula = BR.ReadString
                CDMA.a04Clinica = BR.ReadString
                CDMA.a05NotaseIDx = BR.ReadString
                CDMA.a06Tratamiento = BR.ReadString
                CDMA.a07Pendiente = BR.ReadString
                CDMA.a08ProximaConsulta = BR.ReadString
                CDMA.a09Honorarios = BR.ReadString
                CDMA.a10FechaConsulta = BR.ReadString
                CDMA.a11FacturaAsociada = BR.ReadString
                CDMA.a16Referencia = BR.ReadString
                CDMA.a15Banco = BR.ReadString
                CDMA.a14FormaDePago = BR.ReadString
                CDMA.a13FechaDePago = BR.ReadString
                CDMA.a12Pagador = BR.ReadString

                'calcula honorarios de esta consulta
                If IsNumeric(CDMA.a09Honorarios) Then
                    decHonorarios = CType(CDMA.a09Honorarios, Decimal)
                Else
                    decHonorarios = 0
                End If
                decHonorariosTotalesAño += decHonorarios
                'calcula los pacientes q van
                NumeroPacientesAño += 1

                'formatea la fecha
                Fecha = CType(CDMA.a10FechaConsulta, Date)
                FechaFormateada = Fecha.ToString("s")
                'crea la linea  
                Linea = FechaFormateada & "|" & CDMA.a01NumeroHistoria & "|" & CDMA.a02Nombre
                ArraydeLineas.Add(Linea)
                C = BR.PeekChar
                '00000000000000000000000000000000000

                'va preparando la lista para la impresion
                Dim strHonFormateados = FormatNumber(CDMA.a09Honorarios, 2,,, TriState.True)
                Linea = Fecha.ToString("s") & "|" & CDMA.a03Cedula & "|" & CDMA.a01NumeroHistoria & "|" & CDMA.a02Nombre & "|" & "Bs. " & strHonFormateados.PadLeft(11) & "|" & CDMA.a04Clinica
                ArrayListaControlesAño.Add(Linea)

            End While
            BR.Close()
            FS.Close()

            '=====================================

            If NumeroPacientesAño > 0 Then
                'el archivo no esta vacio, lo ordena

                'prende el boton de imprimir la lista de controles
                botImprimeConsultasDelAño.Enabled = True

                'prende el list box para poder seleccionar de la lista
                ListBoxPacientesAño.Enabled = True

                'ojo: obtiene el largo del numero de historia
                LargoDelNumeroDeHistoria = CDMA.a01NumeroHistoria.Length

                'ordena segun las fechas
                ArraydeLineas.Sort()
                'ahora prepara la array donde se guardaran el numero de historia en el orden del list box
                ArrayNumerosAñoOrdenados.Clear()
                'ahora formatea las fechas
                REnum = ArraydeLineas.GetEnumerator

                Dim restodelaLinea As String
                Dim NumeroDeHistoriaOrdenado As String

                While REnum.MoveNext
                    Linea = CType(REnum.Current, String)
                    'deja los primeros 19 caracteres (fecha) en la variable fechaformateada
                    FechaFormateada = Linea.Substring(0, 19)
                    'asiga la fechaformateada a la variable fecha as date
                    Fecha = CType(FechaFormateada, Date)
                    'ahora devuelve la fecha  a la fecha formateada pero con formato de fecha corta
                    FechaFormateada = Fecha.ToShortDateString ' lista la fecha

                    'ahora agarra el resto de la linea
                    restodelaLinea = Linea.Remove(0, 20) 'quita los primeros 20 caracteres (la fecha) y el separador
                    NumeroDeHistoriaOrdenado = restodelaLinea.Substring(0, LargoDelNumeroDeHistoria)

                    'ahora rellena la estructurita O con los datos
                    OA.NumeroHistoria = NumeroDeHistoriaOrdenado
                    OA.FechaControl = FechaFormateada
                    ArrayNumerosAñoOrdenados.Add(OA)
                    'reconstituye la linea
                    Linea = FechaFormateada & "|" & restodelaLinea
                    'la añade formateada y en orden de fecha al list box
                    ListBoxPacientesAño.Items.Add(Linea)
                End While
            Else
                'el archivo esta vacio, se creó pero no se le ha metido ninguna cita programada
                ListBoxPacientesAño.Items.Add("No hay consultas registradas en este año")
                ListBoxPacientesAño.Enabled = False
                'apaga el boton de imprimir la lista
                botImprimeConsultasDelAño.Enabled = False
            End If

            '================================

            'muestra los honorarios del año
            strHonorariosFormateadosAño = FormatCurrency(decHonorariosTotalesAño, 2, , , TriState.True)
            labHonorariosTotalesAño.Text = strHonorariosFormateadosAño
            'muestra cuantos pacientes
            labNumeroPacientesAño.Text = NumeroPacientesAño.ToString

        Else
            'no hay pacientes vistas este año
            ListBoxPacientesAño.Items.Add("No hay consultas registradas en este año")
            ListBoxPacientesAño.Enabled = False
            'muestra los honorarios del año
            strHonorariosFormateadosAño = FormatCurrency(decHonorariosTotalesAño, 2, ,, TriState.True)
            labHonorariosTotalesAño.Text = strHonorariosFormateadosAño
            'muestra cuantos pacientes
            labNumeroPacientesAño.Text = NumeroPacientesAño.ToString
            'apaga el boton de imprimir la lista
            botImprimeConsultasDelAño.Enabled = False
        End If


        '00000000000000000000000000
    End Sub

    Private Sub botAdelantaAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdelantaAño.Click
        strAñoSeleccionadoNumerodeAño += 1
        'Muestraaño
        ConstruyeNombreControlAnual()
        VerificaAño()
        BorraDatosPacienteSeleccionadoAño()
    End Sub

    Private Sub botRetrocedeAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRetrocedeAño.Click
        strAñoSeleccionadoNumerodeAño -= 1
        'Muestraaño
        ConstruyeNombreControlAnual()
        VerificaAño()
        BorraDatosPacienteSeleccionadoAño()
    End Sub

    Private Sub BorraDatosPacienteSeleccionadoAño()
        'borra los datos del paciente slecionado de la lista del año
        labNumeroHistoriaAño.Text = ""
        labNombreAño.Text = ""
        labCedulaAño.Text = ""
        labLugarAño.Text = ""
        labHonorariosAño.Text = ""
        labFacturaAño.Text = ""
        labProximaAño.Text = ""
        labPagadorAño.Text = ""
        txtAUTOaño.Clear()
        txtIDxAño.Clear()
        txtTtoAño.Clear()
        txtPendienteAño.Clear()
    End Sub

    Private Sub ListBoxPacientesAño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxPacientesAño.SelectedIndexChanged

        Dim Indice As Integer
        Dim HistoriaBuscada As String
        Dim FechaBuscada As Date
        Dim FechaComparada As Date
        'Dim FechaCadena As String
        Dim Largo As String
        Dim Año As Integer
        'Dim ArchivoProximaCita As String
        Dim Temporal As String
        Dim FechaDe8 As String
        Dim decHonorarios As Decimal
        Dim strFormatoMoneda As String

        Indice = ListBoxPacientesAño.SelectedIndex
        OA = ArrayNumerosAñoOrdenados(Indice)
        HistoriaBuscada = OA.NumeroHistoria

        labNumeroHistoriaAño.Text = HistoriaBuscada

        FechaBuscada = CType(OA.FechaControl, Date)

        Temporal = FechaBuscada.ToString("s")
        Largo = Temporal.Length
        FechaDe8 = Temporal.Remove(Largo - 9, 9)
        FechaDe8 = FechaDe8.Remove(4, 1)
        FechaDe8 = FechaDe8.Remove(6, 1)

        Año = FechaBuscada.Year

        strArchivoControlAnual = Form1.PSstrPathAgendaBDH & "\" & Año & "\Control-" & Año & ".agd"

        BorraDatosPacienteSeleccionadoAño()
        'busca archivo de proximas consultas
        If File.Exists(strArchivoControlAnual) Then
            'existe un archivo de proximas citas ese dia lo carga
            FS = New FileStream(strArchivoControlAnual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'ya Dim C se definio un poco arriba por eso falta aca
            C = BR.PeekChar
            While FS.Position < FS.Length
                CDMA = Nothing
                ' Read fields and populate structure
                CDMA.a01NumeroHistoria = BR.ReadString
                CDMA.a02Nombre = BR.ReadString
                CDMA.a03Cedula = BR.ReadString
                CDMA.a04Clinica = BR.ReadString
                CDMA.a05NotaseIDx = BR.ReadString
                CDMA.a06Tratamiento = BR.ReadString
                CDMA.a07Pendiente = BR.ReadString
                CDMA.a08ProximaConsulta = BR.ReadString
                CDMA.a09Honorarios = BR.ReadString
                CDMA.a10FechaConsulta = BR.ReadString
                CDMA.a11FacturaAsociada = BR.ReadString
                CDMA.a16Referencia = BR.ReadString
                CDMA.a15Banco = BR.ReadString
                CDMA.a14FormaDePago = BR.ReadString
                CDMA.a13FechaDePago = BR.ReadString
                CDMA.a12Pagador = BR.ReadString

                'compara el numero de historia para ver si es esta la que se debe mostrar
                If CDMA.a01NumeroHistoria = HistoriaBuscada Then
                    'esta es la historia ve si tambien es la fecha
                    FechaComparada = CType(CDMA.a10FechaConsulta, Date) 'lo carga en una variable date...
                    If FechaComparada = FechaBuscada Then
                        'esta es la historia y la fecha la muestra
                        labNumeroHistoriaAño.Text = CDMA.a01NumeroHistoria
                        labNombreAño.Text = CDMA.a02Nombre
                        'las Cedulas
                        Dim CedulaActual As String = ""
                        CedulaActual = CDMA.a03Cedula
                        CedulaActual = CedulaActual.Substring(0, 2) & "." & CedulaActual.Substring(2, 3) & "." & CedulaActual.Substring(5, 3)
                        If CedulaActual(0) = "0" Then
                            CedulaActual = CedulaActual.Remove(0, 1)
                        End If
                        labCedulaAño.Text = CedulaActual
                        labLugarAño.Text = CDMA.a04Clinica
                        'la proxima cita
                        If CDMA.a08ProximaConsulta.IndexOf("-"c) > -1 Then
                            'tiene formato de string("s") primero transforma
                            labProximaAño.Text = (CType(CDMA.a08ProximaConsulta, Date)).ToLongDateString
                        Else
                            'o esta vacio o en formato de LDS de una vez lo muestra
                            labProximaAño.Text = CDMA.a08ProximaConsulta
                        End If
                        txtIDxAño.Text = CDMA.a05NotaseIDx
                        txtTtoAño.Text = CDMA.a06Tratamiento
                        txtPendienteAño.Text = CDMA.a07Pendiente

                        'formatea honorarios
                        If IsNumeric(CDMA.a09Honorarios) Then
                            decHonorarios = CType(CDMA.a09Honorarios, Decimal)
                        Else
                            decHonorarios = 0
                        End If
                        strFormatoMoneda = FormatCurrency(decHonorarios, 2, , , TriState.True)
                        labHonorariosAño.Text = strFormatoMoneda

                        'la factura
                        If CDMA.a11FacturaAsociada <> "" Then
                            labFacturaAño.Text = CDMA.a11FacturaAsociada.PadLeft(5, "0"c)
                        Else
                            labFacturaAño.Text = ""
                        End If

                        'el pagador
                        labPagadorAño.Text = CDMA.a12Pagador

                        Exit While 'ya mostro lo q queria
                    End If
                End If
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
        Else
            labNumeroHistoriaAño.Text = "Consulta no disponible"
        End If

        '===== AUTO GENERADOS ==============================================

        strNumeroHistoriaSeleccionado = HistoriaBuscada

        dateFechaSeleccionada = FechaBuscada

        subGeneraDatosAutomaticos()

        txtAUTOaño.Text = strAutoGeneradoControlObs & vbCrLf & strAutoGeneradoEco
        '===================================================

    End Sub


    'parte de los proximos

    Private Sub BorraDatosPacienteSeleccionadoProximo()
        'borra los datos del paciente slecionado de la lista del año
        labNumeroHistoriaProxima.Text = ""
        labNombreProxima.Text = ""
        labCedulaProxima.Text = ""
        labTelefonoProxima.Text = ""
        labLugarProxima.Text = ""
        labHonorariosProxima.Text = ""
        labFechaConsultaProxima.Text = ""
        txtAUTOproxima.Clear()
        txtIDxProxima.Clear()
        txtTtoProxima.Clear()
        txtPendienteProxima.Clear()
        labCelVerificadoProxima.Text = ""
        txtUltimoSMSproxima.Clear()
        labReferidaPorProxima.Text = ""
        txtRefirioAproxima.Text = ""
        txtNotasProxima.Clear()
    End Sub
    Private Sub MuestraProximos()
        Dim Linea As String
        Dim Fecha As Date
        Dim FechaFormateada As String
        Dim RestodelaLinea As String
        Dim Largo As Integer
        Dim NumerodeProgramadas As Integer
        Dim NumerodeProgramadasVencidas As Integer
        Dim LargoDelNumeroDeHistoria As Integer
        Dim NumeroDeHistoriaOrdenado As String

        Dim Todo As String
        Dim Parte() As String
        Dim NumeroHistoria1ros5numeros As String
        Dim NumeroHistoriaCompleto As String
        Dim ArchivoDatosPersonales As String
        Dim ArchivoAgenda As String

        'crea una representacion local de la estruc de Archivo.agd
        Dim AG As Form1.TablaDeArchivosPropiosDeAgenda

        Dim Telefono As String
        Dim LugarConsulta As String




        'borra el list box
        ListBoxProximas.Items.Clear()
        ListBoxVencidas.Items.Clear()


        'INICIALIZA VARs
        NumerodeProgramadas = 0
        NumerodeProgramadasVencidas = 0

        'INICIALIZA LOS ARRAYS DE LISTA DE IMPRESION
        ArrayListaControlesVigentes.Clear()
        ArrayListaControlesVencidos.Clear()

        'busca el indice
        If File.Exists(strArchivoIndiceProximos) = True Then
            ListBoxProximas.Enabled = True
            ListBoxVencidas.Enabled = True
            'existe lo muestra en el list box
            FS = New FileStream(strArchivoIndiceProximos, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'ya fue declarada antes Dim C As Integer

            'inicializa arrays
            ArraydeLineas.Clear()
            ArraydeLineasVencidas.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                IP = Nothing
                ' Read fields and populate structure
                IP.a01FechaProximocontrol = BR.ReadString
                IP.a02NumeroHistoria = BR.ReadString
                IP.a03Nombre = BR.ReadString

                'inicializa la  variable "fecha"
                Fecha = CType(IP.a01FechaProximocontrol, Date)

                If Fecha >= Today Then
                    'cita vigente
                    'formatea fecha
                    FechaFormateada = Fecha.ToString("s")
                    'Console.WriteLine("FechaFormateada(s): " & FechaFormateada)
                    'crea la linea  
                    Linea = FechaFormateada & "|" & IP.a02NumeroHistoria & "|" & IP.a03Nombre
                    'Console.WriteLine("Linea: " & Linea)
                    ArraydeLineas.Add(Linea)
                    NumerodeProgramadas += 1
                Else
                    'esta cita esta vencida
                    FechaFormateada = Fecha.ToString("s")
                    'Console.WriteLine("FechaFormateada(s): " & FechaFormateada)
                    'crea la linea  
                    Linea = FechaFormateada & "|" & IP.a02NumeroHistoria & "|" & IP.a03Nombre
                    'Console.WriteLine("Linea: " & Linea)
                    ArraydeLineasVencidas.Add(Linea)
                    NumerodeProgramadasVencidas += 1
                End If
                C = BR.PeekChar
            End While


            BR.Close()
            FS.Close()

            'vamos con las vigentes
            If NumerodeProgramadas > 0 Then
                'se mando algo pa aca, lo ordena

                'prende el boton de imprimir las vigentes
                botImprimeVigentes.Enabled = True

                'ojo: obtiene el largo del numero de historia
                LargoDelNumeroDeHistoria = IP.a02NumeroHistoria.Length

                'ordena segun las fechas
                ArraydeLineas.Sort()
                'ahora prepara la array donde se guardaran el numero de historia en el orden del list box
                ArrayNumerosOrdenados.Clear()
                'ahora formatea las fechas
                REnum = ArraydeLineas.GetEnumerator
                While REnum.MoveNext
                    Linea = CType(REnum.Current, String)
                    'deja los primeros 19 caracteres (fecha) en la variable fechaformateada
                    FechaFormateada = Linea 'aqui va todo
                    Largo = FechaFormateada.Length
                    FechaFormateada = FechaFormateada.Remove(19, Largo - 19)

                    'asiga la fechaformateada a la variable fecha as date
                    Fecha = FechaFormateada
                    'ahora devuelve la fecha  a la fecha formateada pero con formato de fecha corta
                    FechaFormateada = Fecha.ToShortDateString ' lista la fecha
                    'ahora agarra el resto de la linea
                    RestodelaLinea = Linea 'aqui va todo
                    RestodelaLinea = RestodelaLinea.Remove(0, 19) 'quita los primeros 19 caracteres (la fecha)

                    'ahora agarra el numero de historia de esta linea
                    NumeroDeHistoriaOrdenado = RestodelaLinea
                    'primero borra el primer caracter q es el separador
                    NumeroDeHistoriaOrdenado = NumeroDeHistoriaOrdenado.Remove(0, 1)
                    'ahora borra lo demas despues del numero de historia
                    Largo = NumeroDeHistoriaOrdenado.Length
                    NumeroDeHistoriaOrdenado = NumeroDeHistoriaOrdenado.Remove(LargoDelNumeroDeHistoria, Largo - LargoDelNumeroDeHistoria)

                    'ahoa rellena la estructurita P con los datos

                    P.NumeroHistoria = NumeroDeHistoriaOrdenado
                    P.FechaProxima = FechaFormateada
                    ArrayNumerosOrdenados.Add(P)
                    'reconstituye la linea
                    Linea = FechaFormateada & RestodelaLinea
                    'la añade formateada y en orden de fecha al list box
                    ListBoxProximas.Items.Add(Linea)

                    'va preparando la lista para la impresion

                    'AQUI VAMOS A BUSCAR EL TELEFONO

                    If Linea.IndexOf("-") > 0 Then
                        'la forma del numero de historia tiene prefijo
                        Todo = Linea
                        Parte = Split(Todo, "-")
                        NumeroHistoria1ros5numeros = Parte(1).Substring(0, 5)
                        NumeroHistoriaCompleto = Parte(1).Substring(0, 6)
                        ArchivoDatosPersonales = Form1.PSstrPathHistoriasSinPrefijo & "\" & NumeroHistoria1ros5numeros & "\" & NumeroHistoriaCompleto & "-Datos Personales.dat"
                        ArchivoAgenda = Form1.PSstrPathHistoriasSinPrefijo & "\" & NumeroHistoria1ros5numeros & "\" & Parte(1) & ".agd"
                    Else
                        'la forma del numero de historia no tiene prefijo
                        NumeroHistoria1ros5numeros = NumeroDeHistoriaOrdenado.Substring(0, 5)
                        ArchivoDatosPersonales = Form1.PSstrPathHistoriasSinPrefijo & "\" & NumeroHistoria1ros5numeros & "\" & NumeroDeHistoriaOrdenado & "-Datos Personales.dat"
                        ArchivoAgenda = Form1.PSstrPathHistoriasSinPrefijo & "\" & NumeroHistoria1ros5numeros & "\" & NumeroDeHistoriaOrdenado & ".agd"
                    End If

                    If File.Exists(ArchivoDatosPersonales) = True Then
                        'existe y lo lee
                        FS = New FileStream(ArchivoDatosPersonales, FileMode.Open, FileAccess.Read)
                        BR = New BinaryReader(FS)
                        BR.BaseStream.Seek(0, SeekOrigin.Begin)

                        DP = Nothing
                        DP.a01Nombre = BR.ReadString
                        DP.FechaNacimiento = BR.ReadString
                        DP.Edad = BR.ReadString
                        DP.Cedula = BR.ReadString
                        DP.Profesion = BR.ReadString
                        DP.Telefono = BR.ReadString
                        DP.AntecedentesFamiliares = BR.ReadString
                        DP.AntecedentesPersonales = BR.ReadString
                        DP.AntecedentesGinecologicos = BR.ReadString
                        DP.AntecedentesObstetricos = BR.ReadString
                        DP.AntecedentesQuirurgicos = BR.ReadString
                        DP.x01DireccionDeHabitacion = BR.ReadString
                        DP.x02GradoDeInstruccion = BR.ReadString
                        DP.x03Religion = BR.ReadString
                        DP.x04CiaDeSeguros = BR.ReadString
                        DP.x05FamiliarNombre = BR.ReadString
                        DP.x06FamiliarParentesco = BR.ReadString
                        DP.x07FamiliarCelular = BR.ReadString
                        DP.x08FamiliarOcupacion = BR.ReadString
                        DP.z01 = BR.ReadString
                        DP.z02 = BR.ReadString
                        DP.z03 = BR.ReadString
                        DP.z04 = BR.ReadString
                        DP.z05 = BR.ReadString
                        DP.z06 = BR.ReadString
                        DP.z07 = BR.ReadString
                        DP.z08 = BR.ReadString
                        DP.z09 = BR.ReadString
                        DP.z10 = BR.ReadString

                        BR.Close()
                        FS.Close()

                        If DP.Telefono <> "" Then
                            Telefono = "0" & DP.Telefono
                        Else
                            Telefono = "No disponib"
                        End If
                    Else
                        'no existe el archivo de datos personales
                        Telefono = "No disponib"
                    End If

                    'ahora busca el sitio de consulta
                    If File.Exists(ArchivoAgenda) = True Then
                        'existe y lo lee
                        FS = New FileStream(ArchivoAgenda, FileMode.Open, FileAccess.Read)
                        BR = New BinaryReader(FS)
                        BR.BaseStream.Seek(0, SeekOrigin.Begin)
                        C = BR.PeekChar
                        AG.a02Clinica = ""
                        While FS.Position < FS.Length
                            AG = Nothing
                            AG.a10FechaConsulta = BR.ReadString
                            AG.a02Clinica = BR.ReadString
                            AG.a03NotaseIDx = BR.ReadString
                            AG.a04Tratamiento = BR.ReadString
                            AG.a05Pendiente = BR.ReadString
                            AG.a06ProximaConsulta = BR.ReadString
                            AG.a07Honorarios = BR.ReadString
                            AG.a11FacturaAsociada = BR.ReadString
                            AG.a16Referencia = BR.ReadString
                            AG.a15Banco = BR.ReadString
                            AG.a14FormaDePago = BR.ReadString
                            AG.a13FechaDePago = BR.ReadString
                            AG.a12Pagador = BR.ReadString
                            C = BR.PeekChar
                        End While
                        BR.Close()
                        FS.Close()
                        If AG.a02Clinica <> "" Then
                            LugarConsulta = AG.a02Clinica
                        Else
                            LugarConsulta = "No disponible"
                        End If
                    Else
                        'no existe el archivo de agenda
                        LugarConsulta = "No disponible"
                    End If

                    'reacomoda la linea añadiendo el telefono
                    Linea = Linea & "|" & Telefono & "|" & LugarConsulta
                    ArrayListaControlesVigentes.Add(Linea)

                End While
            Else
                'el archivo esta vacio, se creó pero no se le ha metido ninguna cita programada
                ListBoxProximas.Items.Add("No existen consultas programadas vigentes...")
                ListBoxProximas.Enabled = False
                'apaga el boton de imprimir las vigentes
                botImprimeVigentes.Enabled = False
            End If

            'vamos con las vencidas
            If NumerodeProgramadasVencidas > 0 Then
                'se mando algo pa aca, lo ordena NumerodeProgramadasVencidas

                'prende el boton de imprimir las vencidas
                botImprimeVencidas.Enabled = True

                'ojo: obtiene el largo del numero de historia
                LargoDelNumeroDeHistoria = IP.a02NumeroHistoria.Length

                'ordena segun las fechas
                ArraydeLineasVencidas.Sort()
                ArraydeLineasVencidas.Reverse()
                'ahora prepara la array donde se guardaran el numero de historia en el orden del list box
                ArrayNumerosOrdenadosVencidos.Clear()
                'ahora formatea las fechas
                REnum = ArraydeLineasVencidas.GetEnumerator
                While REnum.MoveNext
                    Linea = CType(REnum.Current, String)
                    'deja los primeros 19 caracteres (fecha) en la variable fechaformateada
                    FechaFormateada = Linea 'aqui va todo
                    Largo = FechaFormateada.Length
                    FechaFormateada = FechaFormateada.Remove(19, Largo - 19)
                    'asiga la fechaformateada a la variable fecha as date
                    Fecha = FechaFormateada
                    'ahora devuelve la fecha  a la fecha formateada pero con formato de fecha corta
                    FechaFormateada = Fecha.ToShortDateString ' lista la fecha
                    'ahora agarra el resto de la linea
                    RestodelaLinea = Linea 'aqui va todo
                    RestodelaLinea = RestodelaLinea.Remove(0, 19) 'quita los primeros 19 caracteres (la fecha)

                    'ahora agarra el numero de historia de esta linea
                    NumeroDeHistoriaOrdenado = RestodelaLinea
                    'primero borra el primer caracter q es el separador
                    NumeroDeHistoriaOrdenado = NumeroDeHistoriaOrdenado.Remove(0, 1)
                    'ahora borra lo demas despues del numero de historia
                    Largo = NumeroDeHistoriaOrdenado.Length
                    NumeroDeHistoriaOrdenado = NumeroDeHistoriaOrdenado.Remove(LargoDelNumeroDeHistoria, Largo - LargoDelNumeroDeHistoria)

                    'ahora rellena la estructurita P con los datos
                    P.NumeroHistoria = NumeroDeHistoriaOrdenado
                    P.FechaProxima = FechaFormateada
                    ArrayNumerosOrdenadosVencidos.Add(P)
                    'reconstituye la linea
                    Linea = FechaFormateada & RestodelaLinea
                    'la añade formateada y en orden de fecha al list box
                    ListBoxVencidas.Items.Add(Linea)

                    'parte de la lista tabulada de impresion
                    'AQUI VAMOS A BUSCAR EL TELEFONO

                    If Linea.IndexOf("-") > 0 Then
                        'la forma del numero de historia tiene prefijo
                        Todo = Linea
                        Parte = Split(Todo, "-")
                        NumeroHistoria1ros5numeros = Parte(1).Substring(0, 5)
                        NumeroHistoriaCompleto = Parte(1).Substring(0, 6)
                        ArchivoDatosPersonales = Form1.PSstrPathHistoriasSinPrefijo & "\" & NumeroHistoria1ros5numeros & "\" & NumeroHistoriaCompleto & "-Datos Personales.dat"
                        ArchivoAgenda = Form1.PSstrPathHistoriasSinPrefijo & "\" & NumeroHistoria1ros5numeros & "\" & NumeroHistoriaCompleto & ".agd"
                    Else
                        'la forma del numero de historia no tiene prefijo
                        NumeroHistoria1ros5numeros = NumeroDeHistoriaOrdenado.Substring(0, 5)
                        ArchivoDatosPersonales = Form1.PSstrPathHistoriasSinPrefijo & "\" & NumeroHistoria1ros5numeros & "\" & NumeroDeHistoriaOrdenado & "-Datos Personales.dat"
                        ArchivoAgenda = Form1.PSstrPathHistoriasSinPrefijo & "\" & NumeroHistoria1ros5numeros & "\" & NumeroDeHistoriaOrdenado & ".agd"
                    End If

                    If File.Exists(ArchivoDatosPersonales) = True Then
                        'existe y lo lee
                        FS = New FileStream(ArchivoDatosPersonales, FileMode.Open, FileAccess.Read)
                        BR = New BinaryReader(FS)
                        BR.BaseStream.Seek(0, SeekOrigin.Begin)

                        DP = Nothing
                        DP.a01Nombre = BR.ReadString
                        DP.FechaNacimiento = BR.ReadString
                        DP.Edad = BR.ReadString
                        DP.Cedula = BR.ReadString
                        DP.Profesion = BR.ReadString
                        DP.Telefono = BR.ReadString
                        DP.AntecedentesFamiliares = BR.ReadString
                        DP.AntecedentesPersonales = BR.ReadString
                        DP.AntecedentesGinecologicos = BR.ReadString
                        DP.AntecedentesObstetricos = BR.ReadString
                        DP.AntecedentesQuirurgicos = BR.ReadString
                        DP.x01DireccionDeHabitacion = BR.ReadString
                        DP.x02GradoDeInstruccion = BR.ReadString
                        DP.x03Religion = BR.ReadString
                        DP.x04CiaDeSeguros = BR.ReadString
                        DP.x05FamiliarNombre = BR.ReadString
                        DP.x06FamiliarParentesco = BR.ReadString
                        DP.x07FamiliarCelular = BR.ReadString
                        DP.x08FamiliarOcupacion = BR.ReadString
                        DP.z01 = BR.ReadString
                        DP.z02 = BR.ReadString
                        DP.z03 = BR.ReadString
                        DP.z04 = BR.ReadString
                        DP.z05 = BR.ReadString
                        DP.z06 = BR.ReadString
                        DP.z07 = BR.ReadString
                        DP.z08 = BR.ReadString
                        DP.z09 = BR.ReadString
                        DP.z10 = BR.ReadString

                        BR.Close()
                        FS.Close()
                        If DP.Telefono <> "" Then
                            Telefono = "0" & DP.Telefono
                        Else
                            Telefono = "No disponib"
                        End If
                    Else
                        'no existe el archivo de datos personales
                        Telefono = "No disponib"
                    End If

                    'ahora busca el sitio de consulta
                    If File.Exists(ArchivoAgenda) = True Then
                        'existe y lo lee
                        FS = New FileStream(ArchivoAgenda, FileMode.Open, FileAccess.Read)
                        BR = New BinaryReader(FS)
                        BR.BaseStream.Seek(0, SeekOrigin.Begin)
                        C = BR.PeekChar
                        AG.a02Clinica = ""
                        While FS.Position < FS.Length
                            AG = Nothing
                            AG.a10FechaConsulta = BR.ReadString
                            AG.a02Clinica = BR.ReadString
                            AG.a03NotaseIDx = BR.ReadString
                            AG.a04Tratamiento = BR.ReadString
                            AG.a05Pendiente = BR.ReadString
                            AG.a06ProximaConsulta = BR.ReadString
                            AG.a07Honorarios = BR.ReadString
                            AG.a11FacturaAsociada = BR.ReadString
                            AG.a16Referencia = BR.ReadString
                            AG.a15Banco = BR.ReadString
                            AG.a14FormaDePago = BR.ReadString
                            AG.a13FechaDePago = BR.ReadString
                            AG.a12Pagador = BR.ReadString
                            C = BR.PeekChar
                        End While
                        BR.Close()
                        FS.Close()
                        If AG.a02Clinica <> "" Then
                            LugarConsulta = AG.a02Clinica
                        Else
                            LugarConsulta = "No disponible"
                        End If
                    Else
                        'no existe el archivo de agenda
                        LugarConsulta = "No disponible"
                    End If

                    'reacomoda la linea añadiendo el telefono
                    Linea = Linea & "|" & Telefono & "|" & LugarConsulta
                    ArrayListaControlesVencidos.Add(Linea)

                End While
            Else
                'el archivo esta vacio, se creó pero no se le ha metido ninguna cita programada
                ListBoxVencidas.Items.Add("No existen consultas programadas vencidas...")
                ListBoxVencidas.Enabled = False
                'apaga el boton de imprimir las vencidas
                botImprimeVencidas.Enabled = False
            End If
        Else
            'no existe el archivo indice proximos borra el list box
            ListBoxProximas.Items.Add("No existen consultas programadas vigentes...")
            ListBoxVencidas.Items.Add("No existen consultas programadas vencidas...")
            ListBoxProximas.Enabled = False
            ListBoxVencidas.Enabled = False
            'apaga los botones de imprimir las listas
            botImprimeVigentes.Enabled = False
            botImprimeVencidas.Enabled = False
        End If
        labTotalProgramadas.Text = NumerodeProgramadas
        labTotalProgramadasVencidas.Text = NumerodeProgramadasVencidas
    End Sub


    Private Sub ListBoxProximas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ListBoxProximas.SelectedIndexChanged

        If ListBoxProximas.SelectedIndex = -1 Then
            Exit Sub
        End If

        subMuestraProximaConsultaSeleccionada()

    End Sub
    Private Sub subMuestraProximaConsultaSeleccionada()
        Dim Indice As Integer
        Dim HistoriaBuscada As String
        Dim FechaBuscada As Date
        Dim FechaCadena As String
        Dim Largo As String
        Dim Año As Integer
        Dim ArchivoProximaCita As String
        Dim LocalTelefono As String

        'ojo variables locales para este procedimiento
        Dim localArchivoDatosPersonales As String 'ojo variable tipo local solo para este proceso
        Dim localPrimeros5numeros As String





        Indice = ListBoxProximas.SelectedIndex

        P = ArrayNumerosOrdenados(Indice)
        'If Form1.NumPrefijo <> "" Then
        '    HistoriaBuscada = (P.NumeroHistoria.Replace(Form1.NumPrefijo, "")).Substring(0, 6)
        'Else
        '    HistoriaBuscada = P.NumeroHistoria.Substring(0, 6)
        'End If

        HistoriaBuscada = P.NumeroHistoria

        FechaBuscada = CType(P.FechaProxima, Date)
        'lo pasa a formato de sistema a una variable string
        FechaCadena = FechaBuscada.ToString("s")
        Largo = FechaCadena.Length
        FechaCadena = FechaCadena.Remove(Largo - 9, 9)
        FechaCadena = FechaCadena.Remove(4, 1)
        FechaCadena = FechaCadena.Remove(6, 1)
        Año = FechaBuscada.Year
        ArchivoProximaCita = Form1.PSstrPathAgendaBDH & "\" & Año & "\Proximo-" & FechaCadena & ".agd"
        'borra los datos en pantalla
        BorraDatosPacienteSeleccionadoProximo()
        'busca archivo de proximas consultas
        If File.Exists(ArchivoProximaCita) Then
            'existe un archivo de proximas citas ese dia lo carga
            FS = New FileStream(ArchivoProximaCita, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            C = BR.PeekChar
            While FS.Position < FS.Length
                CP = Nothing
                ' Read fields and populate structure
                CP.a01NumeroHistoria = BR.ReadString
                CP.a02Nombre = BR.ReadString
                CP.a03Cedula = BR.ReadString
                CP.a04ClinicaUltimoControl = BR.ReadString
                CP.a05NotaseIDxUltimoControl = BR.ReadString
                CP.a06TratamientoUltimoControl = BR.ReadString
                CP.a07Pendiente = BR.ReadString
                CP.a08FechaUltimoControl = BR.ReadString
                CP.a09HonorariosUltimoControl = BR.ReadString
                CP.a10FechaProximoControl = BR.ReadString

                'acomoda numero de historia
                Dim strNumeroBuscadoLocal As String

                strNumeroBuscadoLocal = CP.a01NumeroHistoria

                'compara el numero de historia para ver si es esta la que se debe mostrar
                If strNumeroBuscadoLocal = HistoriaBuscada Then
                    'esta es la muestra
                    labNumeroHistoriaProxima.Text = CP.a01NumeroHistoria
                    labNombreProxima.Text = CP.a02Nombre
                    'las Cedulas
                    Dim CedulaActual As String = ""
                    CedulaActual = CP.a03Cedula
                    CedulaActual = CedulaActual.Substring(0, 2) & "." & CedulaActual.Substring(2, 3) & "." & CedulaActual.Substring(5, 3)
                    If CedulaActual(0) = "0" Then
                        CedulaActual = CedulaActual.Remove(0, 1)
                    End If
                    labCedulaProxima.Text = CedulaActual
                    labLugarProxima.Text = CP.a04ClinicaUltimoControl
                    'los honorarios
                    Dim strHonorariosFormateados As String
                    Dim decHonorarios As Decimal
                    If IsNumeric(CP.a09HonorariosUltimoControl) Then
                        decHonorarios = CType(CP.a09HonorariosUltimoControl, Decimal)
                    Else
                        decHonorarios = 0
                    End If

                    strHonorariosFormateados = FormatCurrency(decHonorarios, 2, , , TriState.True)
                    labHonorariosProxima.Text = strHonorariosFormateados
                    'formatea la fecha
                    If CP.a08FechaUltimoControl.IndexOf("-"c) > -1 Then
                        'esta en formato ordenado pasa a LDS
                        labFechaConsultaProxima.Text = (CType(CP.a08FechaUltimoControl, Date)).ToLongDateString
                    Else
                        'esta en formato de LDS
                        labFechaConsultaProxima.Text = CP.a08FechaUltimoControl
                    End If

                    txtIDxProxima.Text = CP.a05NotaseIDxUltimoControl
                    txtTtoProxima.Text = CP.a06TratamientoUltimoControl
                    txtPendienteProxima.Text = CP.a07Pendiente

                    Exit While

                End If
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()


            'revisa el archivo de datos personales por el telefono
            localPrimeros5numeros = HistoriaBuscada.Substring(0, 5)
            localArchivoDatosPersonales = Form1.PSstrPathHistoriasSinPrefijo & "\" & localPrimeros5numeros & "\" & HistoriaBuscada & "-Datos Personales.dat"

            'inicializa la variable del telefono para q no quede en memoria
            LocalTelefono = ""

            If File.Exists(localArchivoDatosPersonales) = True Then

                'existe y lo lee
                FS = New FileStream(localArchivoDatosPersonales, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)

                DP = Nothing
                DP.a01Nombre = BR.ReadString
                DP.FechaNacimiento = BR.ReadString
                DP.Edad = BR.ReadString
                DP.Cedula = BR.ReadString
                DP.Profesion = BR.ReadString
                DP.Telefono = BR.ReadString
                DP.AntecedentesFamiliares = BR.ReadString
                DP.AntecedentesPersonales = BR.ReadString
                DP.AntecedentesGinecologicos = BR.ReadString
                DP.AntecedentesObstetricos = BR.ReadString
                DP.AntecedentesQuirurgicos = BR.ReadString
                DP.x01DireccionDeHabitacion = BR.ReadString
                DP.x02GradoDeInstruccion = BR.ReadString
                DP.x03Religion = BR.ReadString
                DP.x04CiaDeSeguros = BR.ReadString
                DP.x05FamiliarNombre = BR.ReadString
                DP.x06FamiliarParentesco = BR.ReadString
                DP.x07FamiliarCelular = BR.ReadString
                DP.x08FamiliarOcupacion = BR.ReadString
                DP.z01 = BR.ReadString
                DP.z02 = BR.ReadString
                DP.z03 = BR.ReadString
                DP.z04 = BR.ReadString
                DP.z05 = BR.ReadString
                DP.z06 = BR.ReadString
                DP.z07 = BR.ReadString
                DP.z08 = BR.ReadString
                DP.z09 = BR.ReadString
                DP.z10 = BR.ReadString

                LocalTelefono = DP.Telefono

                BR.Close()
                FS.Close()

                If LocalTelefono <> "" Then
                    labTelefonoProxima.Text = "0" & LocalTelefono
                Else
                    labTelefonoProxima.Text = "Falta"
                End If


            Else
                'no existe el archivo de datos personales
                labTelefonoProxima.Text = "Falta"
            End If


            '  REVISA LOS DATOS COMPLEMENTARIOS

            Dim DC As New Form1.DatosComplementarios
            Dim localArchivoDatosComplementarios As String

            localArchivoDatosComplementarios = Form1.PSstrPathHistoriasSinPrefijo & "\" & localPrimeros5numeros & "\" & HistoriaBuscada & "-Datos Complementarios.dat"

            If File.Exists(localArchivoDatosComplementarios) Then
                'existe archivo lo lee todo
                FS = New FileStream(localArchivoDatosComplementarios, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)
                'C = BR.PeekChar
                ' Read todo
                DC = Nothing
                DC.a01Notas = BR.ReadString
                DC.a02Resumen = BR.ReadString
                DC.a03NumeroDelReferidor = BR.ReadString
                DC.a04Vinculos = BR.ReadString
                DC.a05ReferidaPor = BR.ReadString
                DC.a06TelefonoVerificado = BR.ReadString
                DC.a07UltimoSMS = BR.ReadString 'este es el ultimo sms
                DC.a08TipoDeReferidor = BR.ReadString
                DC.a09VinculoConReferidor = BR.ReadString
                DC.a10 = BR.ReadString
                'cierra la vaina
                BR.Close()
                FS.Close()

                labCelVerificadoProxima.Text = DC.a06TelefonoVerificado
                txtUltimoSMSproxima.Text = DC.a07UltimoSMS
                labReferidaPorProxima.Text = DC.a05ReferidaPor
                txtNotasProxima.Text = DC.a01Notas

            Else 'no existe el archivo de datos complementarios lo debe inizializar

                labCelVerificadoProxima.Text = ""
                txtUltimoSMSproxima.Text = ""
                labReferidaPorProxima.Text = ""
                txtNotasProxima.Text = ""
            End If



        Else
            labNumeroHistoriaProxima.Text = HistoriaBuscada
            labNombreProxima.Text = "Consulta no disponible, Falta Archivo"
        End If

        'busca las ptes referidas por esta pte.
        Dim strArchivoDeReferenciaPtes As String
        Dim alsOtrasReferidasPorPte As New ArrayList

        Dim strNombreCorto As String = ""
        'agarra solo el nombre de la pte
        For Each charC As Char In DP.a01Nombre
            If charC <> " "c Then
                strNombreCorto += charC
            Else
                Exit For
            End If
        Next

        'crea la direccion al archivo
        localPrimeros5numeros = HistoriaBuscada.Substring(0, 5)
        strArchivoDeReferenciaPtes = Form1.PSstrPathHistoriasSinPrefijo & "\" & localPrimeros5numeros & "\" & HistoriaBuscada & "-Referidas.dat"
        'comprueba si existe
        If File.Exists(strArchivoDeReferenciaPtes) Then
            'existe lo lee y carga los datos en la alsOtrasReferidasPorPte
            Dim BR As BinaryReader
            Dim FS As FileStream
            Dim REF As Form1.TablaDeReferidas
            Dim C As Integer

            'inicializa la als de otras pacientes referidas
            alsOtrasReferidasPorPte.Clear()

            'ya esta comprobado q existe
            FS = New FileStream(strArchivoDeReferenciaPtes, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            ' Read todo
            C = BR.PeekChar
            While FS.Position < FS.Length
                REF = Nothing
                REF.a01NumeroHistoria = BR.ReadString
                REF.a02Nombre = BR.ReadString
                REF.a03Cedula = BR.ReadString
                REF.a04FechaDeReferenciaSDS = BR.ReadString
                REF.b01 = BR.ReadString
                REF.b02 = BR.ReadString


                'las incluye en la lista de otras referidas
                alsOtrasReferidasPorPte.Add(REF)

            End While

            'cierra la vaina
            BR.Close()
            FS.Close()

            'ahora muestra los datos en el text box acomoda el lab de titulo
            labRefirioAproxima.Text = strNombreCorto & " ha referido a"

            If alsOtrasReferidasPorPte.Count > 0 Then 'hay al menos un dato lo ordena
                'ordena la lista por fecha de referencia
                Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorPte _
                                           Order By CType(est.a04FechaDeReferenciaSDS, Date) _
                                           Select est
                'las muestra ordenadas en el text box
                For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                    txtRefirioAproxima.Text += "El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre & vbCrLf
                Next

            Else
                'el archivo existe pero esta vacio dice q no ha referido a nadie
                labRefirioAproxima.Text = strNombreCorto & " ha referido a"
                txtRefirioAproxima.Text = "No ha referido a nadie."
            End If
        Else
            'no existeel archivo lo muestra de una vez en el listbox de otras referidas
            labRefirioAproxima.Text = strNombreCorto & " ha referido a"
            txtRefirioAproxima.Text = "No ha referido a nadie."
        End If

        '===================================================


        strNumeroHistoriaSeleccionado = HistoriaBuscada 'ojo ya fue eliminado el prefijo si lo habia arriba al principio

        'ojo normalmente sera fechaBuscada pero como aca fecha buscada es la prox consulta no hay datos, revisa entonces lo q hubo en la ultima consulta
        dateFechaSeleccionada = CType(CP.a08FechaUltimoControl, Date)

        subGeneraDatosAutomaticos()

        txtAUTOproxima.Text = strAutoGeneradoControlObs & vbCrLf & strAutoGeneradoEco
        '===================================================

        'deselecciona el listbox vencidas
        ListBoxVencidas.SelectedIndex = -1

    End Sub

    Private Sub ListBoxVencidas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ListBoxVencidas.SelectedIndexChanged

        If ListBoxVencidas.SelectedIndex = -1 Then
            Exit Sub
        End If

        subMuestraConsultaVencidaSeleccionada()

    End Sub
    Private Sub subMuestraConsultaVencidaSeleccionada()
        Dim Indice As Integer
        Dim HistoriaBuscada As String
        Dim FechaBuscada As Date
        Dim FechaCadena As String
        Dim Largo As String
        Dim Año As Integer
        Dim ArchivoProximaCita As String

        'ojo variables locales para este procedimiento
        Dim localArchivoDatosPersonales As String 'ojo variable tipo local solo para este proceso
        Dim localPrimeros5numeros As String
        Dim localTelefono As String

        Indice = ListBoxVencidas.SelectedIndex

        P = ArrayNumerosOrdenadosVencidos(Indice)

        'If Form1.NumPrefijo <> "" Then
        '    HistoriaBuscada = (P.NumeroHistoria.Replace(Form1.NumPrefijo, "")).Substring(0, 6)
        'Else
        '    HistoriaBuscada = P.NumeroHistoria.Substring(0, 6)
        'End If

        HistoriaBuscada = P.NumeroHistoria

        FechaBuscada = CType(P.FechaProxima, Date)
        'lo pasa a formato de sistema a una variable string
        FechaCadena = FechaBuscada.ToString("s")
        Largo = FechaCadena.Length
        FechaCadena = FechaCadena.Remove(Largo - 9, 9)
        FechaCadena = FechaCadena.Remove(4, 1)
        FechaCadena = FechaCadena.Remove(6, 1)
        Año = FechaBuscada.Year
        ArchivoProximaCita = Form1.PSstrPathAgendaBDH & "\" & Año & "\Proximo-" & FechaCadena & ".agd"
        'borra las entradas
        BorraDatosPacienteSeleccionadoProximo()
        'busca archivo de proximas consultas
        If File.Exists(ArchivoProximaCita) Then
            'existe un archivo de proximas citas ese dia lo carga
            FS = New FileStream(ArchivoProximaCita, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            C = BR.PeekChar
            While FS.Position < FS.Length
                CP = Nothing
                ' Read fields and populate structure
                CP.a01NumeroHistoria = BR.ReadString
                CP.a02Nombre = BR.ReadString
                CP.a03Cedula = BR.ReadString
                CP.a04ClinicaUltimoControl = BR.ReadString
                CP.a05NotaseIDxUltimoControl = BR.ReadString
                CP.a06TratamientoUltimoControl = BR.ReadString
                CP.a07Pendiente = BR.ReadString
                CP.a08FechaUltimoControl = BR.ReadString
                CP.a09HonorariosUltimoControl = BR.ReadString
                CP.a10FechaProximoControl = BR.ReadString

                'acomoda numero de historia
                Dim strNumeroBuscadoLocal As String

                strNumeroBuscadoLocal = CP.a01NumeroHistoria
                'compara el numero de historia para ver si es esta la que se debe mostrar
                If strNumeroBuscadoLocal = HistoriaBuscada Then
                    'esta es la muestra
                    labNumeroHistoriaProxima.Text = CP.a01NumeroHistoria
                    labNombreProxima.Text = CP.a02Nombre
                    'las Cedulas
                    Dim CedulaActual As String = ""
                    CedulaActual = CP.a03Cedula
                    CedulaActual = CedulaActual.Substring(0, 2) & "." & CedulaActual.Substring(2, 3) & "." & CedulaActual.Substring(5, 3)
                    If CedulaActual(0) = "0" Then
                        CedulaActual = CedulaActual.Remove(0, 1)
                    End If
                    labCedulaProxima.Text = CedulaActual
                    labLugarProxima.Text = CP.a04ClinicaUltimoControl
                    'los honorarios
                    Dim strHonorariosFormateados As String
                    Dim decHonorarios As Decimal
                    If IsNumeric(CP.a09HonorariosUltimoControl) Then
                        decHonorarios = CType(CP.a09HonorariosUltimoControl, Decimal)
                    Else
                        decHonorarios = 0
                    End If
                    strHonorariosFormateados = FormatCurrency(decHonorarios, 2, , , TriState.True)
                    labHonorariosProxima.Text = strHonorariosFormateados
                    'formatea la fecha
                    If CP.a08FechaUltimoControl.IndexOf("-"c) > -1 Then
                        'esta en formato ordenado pasa a LDS
                        labFechaConsultaProxima.Text = (CType(CP.a08FechaUltimoControl, Date)).ToLongDateString
                    Else
                        'esta en formato de LDS
                        labFechaConsultaProxima.Text = CP.a08FechaUltimoControl
                    End If
                    txtIDxProxima.Text = CP.a05NotaseIDxUltimoControl
                    txtTtoProxima.Text = CP.a06TratamientoUltimoControl
                    txtPendienteProxima.Text = CP.a07Pendiente

                    Exit While 'para salir con los datos correctos

                End If
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'revisa el archivo de datos personales por el telefono
            localPrimeros5numeros = HistoriaBuscada.Substring(0, 5)
            localArchivoDatosPersonales = Form1.PSstrPathHistoriasSinPrefijo & "\" & localPrimeros5numeros & "\" & HistoriaBuscada & "-Datos Personales.dat"

            'inicializa la variable del telefono para q no quede en memoria
            localTelefono = ""

            If File.Exists(localArchivoDatosPersonales) = True Then

                'existe y lo lee
                FS = New FileStream(localArchivoDatosPersonales, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)

                DP = Nothing
                DP.a01Nombre = BR.ReadString
                DP.FechaNacimiento = BR.ReadString
                DP.Edad = BR.ReadString
                DP.Cedula = BR.ReadString
                DP.Profesion = BR.ReadString
                DP.Telefono = BR.ReadString
                DP.AntecedentesFamiliares = BR.ReadString
                DP.AntecedentesPersonales = BR.ReadString
                DP.AntecedentesGinecologicos = BR.ReadString
                DP.AntecedentesObstetricos = BR.ReadString
                DP.AntecedentesQuirurgicos = BR.ReadString
                DP.x01DireccionDeHabitacion = BR.ReadString
                DP.x02GradoDeInstruccion = BR.ReadString
                DP.x03Religion = BR.ReadString
                DP.x04CiaDeSeguros = BR.ReadString
                DP.x05FamiliarNombre = BR.ReadString
                DP.x06FamiliarParentesco = BR.ReadString
                DP.x07FamiliarCelular = BR.ReadString
                DP.x08FamiliarOcupacion = BR.ReadString
                DP.z01 = BR.ReadString
                DP.z02 = BR.ReadString
                DP.z03 = BR.ReadString
                DP.z04 = BR.ReadString
                DP.z05 = BR.ReadString
                DP.z06 = BR.ReadString
                DP.z07 = BR.ReadString
                DP.z08 = BR.ReadString
                DP.z09 = BR.ReadString
                DP.z10 = BR.ReadString

                localTelefono = DP.Telefono

                BR.Close()
                FS.Close()

                If localTelefono <> "" Then
                    labTelefonoProxima.Text = "0" & localTelefono
                Else
                    labTelefonoProxima.Text = "Falta"
                End If


            Else
                'no existe el archivo de datos personales
                labTelefonoProxima.Text = "Falta"
            End If

            Dim DC As New Form1.DatosComplementarios
            Dim localArchivoDatosComplementarios As String

            localArchivoDatosComplementarios = Form1.PSstrPathHistoriasSinPrefijo & "\" & localPrimeros5numeros & "\" & HistoriaBuscada & "-Datos Complementarios.dat"

            If File.Exists(localArchivoDatosComplementarios) Then
                'existe archivo lo lee todo
                FS = New FileStream(localArchivoDatosComplementarios, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)
                'C = BR.PeekChar
                ' Read todo
                DC = Nothing
                DC.a01Notas = BR.ReadString
                DC.a02Resumen = BR.ReadString
                DC.a03NumeroDelReferidor = BR.ReadString
                DC.a04Vinculos = BR.ReadString
                DC.a05ReferidaPor = BR.ReadString
                DC.a06TelefonoVerificado = BR.ReadString
                DC.a07UltimoSMS = BR.ReadString 'este es el ultimo sms
                DC.a08TipoDeReferidor = BR.ReadString
                DC.a09VinculoConReferidor = BR.ReadString
                DC.a10 = BR.ReadString
                'cierra la vaina
                BR.Close()
                FS.Close()

                labCelVerificadoProxima.Text = DC.a06TelefonoVerificado
                txtUltimoSMSproxima.Text = DC.a07UltimoSMS
                labReferidaPorProxima.Text = DC.a05ReferidaPor
                txtNotasProxima.Text = DC.a01Notas

            Else 'no existe el archivo de datos complementarios lo debe inizializar

                labCelVerificadoProxima.Text = ""
                txtUltimoSMSproxima.Text = ""
                labReferidaPorProxima.Text = ""
                txtNotasProxima.Text = ""

            End If

        Else
            labNumeroHistoriaProxima.Text = "Consulta no disponible"
        End If


        'busca las ptes referidas por esta pte.
        Dim strArchivoDeReferenciaPtes As String
        Dim alsOtrasReferidasPorPte As New ArrayList

        Dim strNombreCorto As String = ""
        'agarra solo el nombre de la pte
        For Each charC As Char In DP.a01Nombre
            If charC <> " "c Then
                strNombreCorto += charC
            Else
                Exit For
            End If
        Next

        'crea la direccion al archivo
        localPrimeros5numeros = HistoriaBuscada.Substring(0, 5)
        strArchivoDeReferenciaPtes = Form1.PSstrPathHistoriasSinPrefijo & "\" & localPrimeros5numeros & "\" & HistoriaBuscada & "-Referidas.dat"
        'comprueba si existe
        If File.Exists(strArchivoDeReferenciaPtes) Then
            'existe lo lee y carga los datos en la alsOtrasReferidasPorPte
            Dim BR As BinaryReader
            Dim FS As FileStream
            Dim REF As Form1.TablaDeReferidas
            Dim C As Integer

            'inicializa la als de otras pacientes referidas
            alsOtrasReferidasPorPte.Clear()

            'ya esta comprobado q existe
            FS = New FileStream(strArchivoDeReferenciaPtes, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            ' Read todo
            C = BR.PeekChar
            While FS.Position < FS.Length
                REF = Nothing
                REF.a01NumeroHistoria = BR.ReadString
                REF.a02Nombre = BR.ReadString
                REF.a03Cedula = BR.ReadString
                REF.a04FechaDeReferenciaSDS = BR.ReadString
                REF.b01 = BR.ReadString
                REF.b02 = BR.ReadString


                'las incluye en la lista de otras referidas
                alsOtrasReferidasPorPte.Add(REF)

            End While

            'cierra la vaina
            BR.Close()
            FS.Close()

            'ahora muestra los datos en el text box acomoda el lab de titulo
            labRefirioAproxima.Text = strNombreCorto & " ha referido a"

            If alsOtrasReferidasPorPte.Count > 0 Then 'hay al menos un dato lo ordena
                'ordena la lista por fecha de referencia
                Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorPte _
                                           Order By CType(est.a04FechaDeReferenciaSDS, Date) _
                                           Select est
                'las muestra ordenadas en el text box
                For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                    txtRefirioAproxima.Text += "El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre & vbCrLf
                Next

            Else
                'el archivo existe pero esta vacio dice q no ha referido a nadie
                labRefirioAproxima.Text = strNombreCorto & " ha referido a"
                txtRefirioAproxima.Text = "No ha referido a nadie."
            End If

        Else
            'no existeel archivo lo muestra de una vez en el listbox de otras referidas
            labRefirioAproxima.Text = strNombreCorto & " ha referido a"
            txtRefirioAproxima.Text = "No ha referido a nadie."
        End If


        '===================================================
        strNumeroHistoriaSeleccionado = HistoriaBuscada 'ojo ya fue eliminado el prefijo si lo habia arriba al principio

        'ojo normalmente sera fechaBuscada pero como aca fecha buscada es la prox consulta no hay datos, revisa entonces lo q hubo en la ultima consulta
        dateFechaSeleccionada = CType(CP.a08FechaUltimoControl, Date)

        subGeneraDatosAutomaticos()

        txtAUTOproxima.Text = strAutoGeneradoControlObs & vbCrLf & strAutoGeneradoEco
        '===================================================



        'deselecciona listbox proximas
        ListBoxProximas.SelectedIndex = -1
    End Sub


    'parte de las consultas por pacientes

    Private Sub CargaArrayHistorias()

        Dim HonorariosTotalesPaciente As Integer
        Dim NumeroPacientes As Integer
        Dim ArchivoBaseDeDatos As String
        Dim Honorarios As Integer

        'inicializa las variables dependientes
        Honorarios = 0
        HonorariosTotalesPaciente = 0
        NumeroPacientes = 0
        ArchivoBaseDeDatos = Form1.BaseModificada
        'ahora carga el indice de pacientes de la base de datos
        FS = New FileStream(ArchivoBaseDeDatos, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        C = BR.PeekChar
        ArrayHistorias.Clear()
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H.NumeroHistoria = BR.ReadString
            H.CedulaPaciente = BR.ReadString
            H.NombrePaciente = BR.ReadString
            ArrayHistorias.Add(H)
            NumeroPacientes += 1
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
        If NumeroPacientes = 0 Then
            'la base esta vacia ??? creo que no puede pasar pero bueee... porsia
            ListBoxPacientes.Items.Add("No hay pacientes en esta Base de Datos")
            ListBoxPacientes.Enabled = False
        End If
    End Sub

    Private Sub MuestraPacientes()

        'variables de numeracion
        'Dim ValorSufijo As Int64
        'Dim Sufijo As String
        Dim Elemento As Integer = 0
        Dim Linea As String
        Dim Filtro As String
        Dim contador As Integer = 0
        Dim Filtrados As Integer = 0

        'limpia lista de pacientes
        ListBoxPacientes.Items.Clear()

        'inicializa arrays
        arrayPacientesFiltrados.Clear()
        ArrayListaPacientes.Clear()

        'inicialmente prende el boton de impresion
        botImprimePacientes.Enabled = True

        REnum = ArrayHistorias.GetEnumerator
        Filtro = txtFiltro.Text.ToUpper
        While REnum.MoveNext
            H = CType(REnum.Current, BaseDatosIndiceHistorias)

            Linea = H.NumeroHistoria & "|" & H.NombrePaciente

            If Filtro = "" Then
                'no hay filtro, pasan todos
                ListBoxPacientes.Items.Add(Linea)
                OP.NumeroHistoria = H.NumeroHistoria
                OP.NombrePaciente = H.NombrePaciente
                arrayPacientesFiltrados.Add(OP)

                'aqui voy a preparar la lista tabulada de pacientes para impresion
                'reacomoda la linea añadiendo el telefono
                'Linea = Linea & "|" & Cedula & "|" & Telefono & "|" & LugarConsulta
                'ArrayListaPacientes.Add(Linea)
            Else
                'hay filtro, verifica la cadena
                If Linea.ToUpper.IndexOf(Filtro) >= 0 Then
                    'la cadena concuerda con el filtro la añade
                    ListBoxPacientes.Items.Add(Linea)
                    OP.NumeroHistoria = H.NumeroHistoria
                    OP.NombrePaciente = H.NombrePaciente
                    arrayPacientesFiltrados.Add(OP)

                    'aqui voy a preparar la lista tabulada de pacientes para impresion
                    'reacomoda la linea añadiendo el telefono
                    'Linea = Linea & "|" & Cedula & "|" & Telefono & "|" & LugarConsulta
                    'ArrayListaPacientes.Add(Linea)

                    Filtrados += 1
                Else
                    'no concuerda, no lo añade ni al listbox ni al array
                End If
            End If
            contador += 1
        End While
        'aqui solo para poner la etiqueta del filtro
        If Filtro = "" Then
            labFiltro.Text = "Todos los Pacientes de la Base de Datos = " & contador & " pacientes"
        Else
            labFiltro.Text = "Pacientes filtrados por: " & Filtro.ToUpper & " = " & Filtrados & " pacientes"
            If Filtrados = 0 Then
                'no paso ninguno
                'apaga el boton de imprimir las vigentes
                botImprimePacientes.Enabled = False
            End If
        End If
    End Sub

    Private Sub MuestraPacientesParaImpresion()

        'variables de numeracion
        'Dim ValorSufijo As Int64
        'Dim Sufijo As String
        Dim Elemento As Integer = 0
        Dim Linea As String
        Dim Filtro As String
        Dim contador As Integer = 0
        Dim Filtrados As Integer = 0

        'Dim Todo As String
        'Dim Parte() As String
        Dim Primeros5numeros As String
        Dim archivoDatosPersonales As String
        Dim ArchivoAgenda As String
        'crea una representacion local de la estruc de Archivo.agd
        Dim AG As Form1.TablaDeArchivosPropiosDeAgenda

        Dim Cedula As String
        Dim Telefono As String
        Dim LugarConsulta As String

        'limpia lista de pacientes
        'ListBoxPacientes.Items.Clear()

        'inicializa arrays
        arrayPacientesFiltrados.Clear()
        ArrayListaPacientes.Clear()

        'inicialmente prende el boton de impresion
        botImprimePacientes.Enabled = True


        REnum = ArrayHistorias.GetEnumerator
        Filtro = txtFiltro.Text.ToUpper
        While REnum.MoveNext
            H = CType(REnum.Current, BaseDatosIndiceHistorias)

            Linea = H.NumeroHistoria & "|" & H.NombrePaciente

            'AQUI VAMOS A BUSCAR Datos
            Primeros5numeros = H.NumeroHistoria.Substring(0, 5)
            archivoDatosPersonales = Form1.PSstrPathHistoriasSinPrefijo & "\" & Primeros5numeros & "\" & H.NumeroHistoria & "-Datos Personales.dat"
            ArchivoAgenda = Form1.PSstrPathHistoriasSinPrefijo & "\" & Primeros5numeros & "\" & H.NumeroHistoria & ".agd"

            If File.Exists(archivoDatosPersonales) = True Then
                'existe y lo lee
                FS = New FileStream(archivoDatosPersonales, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)

                DP = Nothing
                DP.a01Nombre = BR.ReadString
                DP.FechaNacimiento = BR.ReadString
                DP.Edad = BR.ReadString
                DP.Cedula = BR.ReadString
                DP.Profesion = BR.ReadString
                DP.Telefono = BR.ReadString
                DP.AntecedentesFamiliares = BR.ReadString
                DP.AntecedentesPersonales = BR.ReadString
                DP.AntecedentesGinecologicos = BR.ReadString
                DP.AntecedentesObstetricos = BR.ReadString
                DP.AntecedentesQuirurgicos = BR.ReadString
                DP.x01DireccionDeHabitacion = BR.ReadString
                DP.x02GradoDeInstruccion = BR.ReadString
                DP.x03Religion = BR.ReadString
                DP.x04CiaDeSeguros = BR.ReadString
                DP.x05FamiliarNombre = BR.ReadString
                DP.x06FamiliarParentesco = BR.ReadString
                DP.x07FamiliarCelular = BR.ReadString
                DP.x08FamiliarOcupacion = BR.ReadString
                DP.z01 = BR.ReadString
                DP.z02 = BR.ReadString
                DP.z03 = BR.ReadString
                DP.z04 = BR.ReadString
                DP.z05 = BR.ReadString
                DP.z06 = BR.ReadString
                DP.z07 = BR.ReadString
                DP.z08 = BR.ReadString
                DP.z09 = BR.ReadString
                DP.z10 = BR.ReadString

                BR.Close()
                FS.Close()

                'busca la cedula
                If DP.Cedula <> "" Then
                    Cedula = DP.Cedula
                Else
                    Cedula = "No disp "
                End If

                'busca el telefono
                If DP.Telefono <> "" Then
                    Telefono = "0" & DP.Telefono
                Else
                    Telefono = "No disponib"
                End If
            Else
                'no existe el archivo de datos personales
                Cedula = "No disp "
                Telefono = "No disponib"
            End If

            'ahora busca el sitio de consulta en la agenda
            If File.Exists(ArchivoAgenda) = True Then
                'existe y lo lee
                FS = New FileStream(ArchivoAgenda, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)
                C = BR.PeekChar
                AG.a02Clinica = ""
                While FS.Position < FS.Length
                    AG = Nothing
                    AG.a10FechaConsulta = BR.ReadString
                    AG.a02Clinica = BR.ReadString
                    AG.a03NotaseIDx = BR.ReadString
                    AG.a04Tratamiento = BR.ReadString
                    AG.a05Pendiente = BR.ReadString
                    AG.a06ProximaConsulta = BR.ReadString
                    AG.a07Honorarios = BR.ReadString
                    AG.a11FacturaAsociada = BR.ReadString
                    AG.a16Referencia = BR.ReadString
                    AG.a15Banco = BR.ReadString
                    AG.a14FormaDePago = BR.ReadString
                    AG.a13FechaDePago = BR.ReadString
                    AG.a12Pagador = BR.ReadString
                    C = BR.PeekChar
                End While
                BR.Close()
                FS.Close()
                If AG.a02Clinica <> "" Then
                    LugarConsulta = AG.a02Clinica
                Else
                    LugarConsulta = "No disponible"
                End If
            Else
                'no existe el archivo de agenda
                LugarConsulta = "No disponible"
            End If

            If Filtro = "" Then
                'no hay filtro, pasan todos
                'ListBoxPacientes.Items.Add(Linea)
                OP.NumeroHistoria = H.NumeroHistoria
                OP.NombrePaciente = H.NombrePaciente
                arrayPacientesFiltrados.Add(OP)

                'aqui voy a preparar la lista tabulada de pacientes para impresion
                'reacomoda la linea añadiendo el telefono
                Linea = Linea & "|" & Cedula & "|" & Telefono & "|" & LugarConsulta
                ArrayListaPacientes.Add(Linea)
            Else
                'hay filtro, verifica la cadena
                If Linea.ToUpper.IndexOf(Filtro) >= 0 Then
                    'la cadena concuerda con el filtro la añade
                    'ListBoxPacientes.Items.Add(Linea)
                    OP.NumeroHistoria = H.NumeroHistoria
                    OP.NombrePaciente = H.NombrePaciente
                    arrayPacientesFiltrados.Add(OP)

                    'aqui voy a preparar la lista tabulada de pacientes para impresion
                    'reacomoda la linea añadiendo el telefono
                    Linea = Linea & "|" & Cedula & "|" & Telefono & "|" & LugarConsulta
                    ArrayListaPacientes.Add(Linea)

                    Filtrados += 1
                Else
                    'no concuerda, no lo añade ni al listbox ni al array
                End If
            End If
            contador += 1
        End While
        'aqui solo para poner la etiqueta del filtro
        If Filtro = "" Then
            labFiltro.Text = "Todos los Pacientes de la Base de Datos = " & contador & " pacientes"
        Else
            labFiltro.Text = "Pacientes filtrados por: " & Filtro.ToUpper & " = " & Filtrados & " pacientes"
            If Filtrados = 0 Then
                'no paso ninguno
                'apaga el boton de imprimir las vigentes
                botImprimePacientes.Enabled = False
            End If
        End If
    End Sub

    Private Sub BorraDatosPacienteSeleccionadoPaciente()
        labFechaConsultaPaciente.Text = ""
        labLugarPaciente.Text = ""
        labHonorariosPaciente.Text = ""
        labProximaPaciente.Text = ""
        txtAUTOpaciente.Clear()
        txtIDxPaciente.Clear()
        txtTtoPaciente.Clear()
        txtPendientePaciente.Clear()
    End Sub

    Private Sub txtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged
        MuestraPacientes()
        listBoxConsultas.Items.Clear()
        labConsultas.Text = "Consultas Archivadas"
        BorraDatosPacienteSeleccionadoPaciente()
    End Sub

    Private Sub ListBoxPacientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ListBoxPacientes.SelectedIndexChanged
        Dim Indice As Integer
        Dim HistoriaBuscada As String
        Dim NombreBuscado As String
        Dim Fecha As Date
        'Dim FechaCadena As String
        'Dim Largo As String
        'Dim Año As Integer
        Dim Path As String
        Dim Prefijo As String
        Dim R As New Form1.TablaDeArchivosPropiosDeAgenda()
        Dim contador As Integer = 0
        Dim strHonorariosTotalesFormateadosPaciente As String
        Dim decHonorariosTotalesPaciente As Decimal
        Dim decHonorarios As Decimal
        Dim year2008 As Date = "31-12-2007"

        Dim arrayFechasDeConsultas As New ArrayList



        'primero borra los datos del que estuviera seleccionado
        BorraDatosPacienteSeleccionadoPaciente()

        Indice = ListBoxPacientes.SelectedIndex
        OP = arrayPacientesFiltrados(Indice)
        HistoriaBuscada = OP.NumeroHistoria
        NombreBuscado = OP.NombrePaciente

        Prefijo = HistoriaBuscada.Remove(5, 1)
        Path = Form1.DirBaseModificada
        Path = Path & "\" & Prefijo
        strArchivoPropioAGD = Path & "\" & HistoriaBuscada & ".agd"
        listBoxConsultas.Items.Clear()
        decHonorariosTotalesPaciente = 0
        arrayFechasDeConsultas.Clear()
        'busca archivo de proximas consultas
        If File.Exists(strArchivoPropioAGD) Then
            'existe un archivo de proximas citas ese dia lo carga
            FS = New FileStream(strArchivoPropioAGD, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'ya Dim C se definio un poco arriba por eso falta aca
            C = BR.PeekChar
            While FS.Position < FS.Length
                R = Nothing
                ' Read fields and populate structure
                R.a10FechaConsulta = BR.ReadString
                R.a02Clinica = BR.ReadString
                R.a03NotaseIDx = BR.ReadString
                R.a04Tratamiento = BR.ReadString
                R.a05Pendiente = BR.ReadString
                R.a06ProximaConsulta = BR.ReadString
                R.a07Honorarios = BR.ReadString
                R.a11FacturaAsociada = BR.ReadString
                R.a16Referencia = BR.ReadString
                R.a15Banco = BR.ReadString
                R.a14FormaDePago = BR.ReadString
                R.a13FechaDePago = BR.ReadString
                R.a12Pagador = BR.ReadString
                Fecha = CType(R.a10FechaConsulta, Date)

                If IsNumeric(R.a07Honorarios) Then
                    decHonorarios = CType(R.a07Honorarios, Decimal)
                    If Fecha < year2008 Then
                        decHonorarios = decHonorarios / 1000
                    End If
                Else
                    decHonorarios = 0
                End If
                decHonorariosTotalesPaciente += decHonorarios

                arrayFechasDeConsultas.Add(Fecha)
                contador += 1
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
            If contador = 0 Then
                'archivo vacio ??? creo q no puede pero porsia
                listBoxConsultas.Items.Add("No Tiene Controles registrados")
                listBoxConsultas.Enabled = False
                labConsultas.Text = "Consultas Archivadas"
            Else
                'ordena el array y pasa los datos al list box
                arrayFechasDeConsultas.Sort()
                For Indice = 0 To contador - 1
                    Fecha = CType(arrayFechasDeConsultas(Indice), Date)
                    listBoxConsultas.Items.Add(Fecha.ToShortDateString)
                Next
                labConsultas.Text = "Consultas de " & NombreBuscado
                listBoxConsultas.Enabled = True
            End If

            'muestra los honorarios totales del paciente
            strHonorariosTotalesFormateadosPaciente = FormatCurrency(decHonorariosTotalesPaciente, 2, , , TriState.True)
            labHonorariosTotalesPaciente.Text = strHonorariosTotalesFormateadosPaciente
            'muestra cuantos pacientes
            labNumeroConsultasPaciente.Text = contador.ToString
        Else
            listBoxConsultas.Items.Add("No Tiene Controles registrados")
            listBoxConsultas.Enabled = False
            labConsultas.Text = "Consultas Archivadas"
            'muestra los honorarios totales del paciente
            strHonorariosTotalesFormateadosPaciente = FormatCurrency(decHonorariosTotalesPaciente, 2, , , TriState.True)
            labHonorariosTotalesPaciente.Text = strHonorariosTotalesFormateadosPaciente
            'muestra cuantos pacientes
            labNumeroConsultasPaciente.Text = contador.ToString
        End If

        '====================== para los autogenerados aca solo en numero de historia resto mas adelante ======================
        'If Form1.NumPrefijo <> "" Then
        '    Dim strHistoriaSinPrefijo = HistoriaBuscada.Replace(Form1.NumPrefijo, "")
        '    strNumeroHistoriaSeleccionado = strHistoriaSinPrefijo.Substring(0, 6)
        'Else
        '    strNumeroHistoriaSeleccionado = HistoriaBuscada.Substring(0, 6)
        'End If
        strNumeroHistoriaSeleccionado = HistoriaBuscada
        '============================================

    End Sub

    Private Sub listBoxConsultas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listBoxConsultas.SelectedIndexChanged

        Dim R As New Form1.TablaDeArchivosPropiosDeAgenda()
        Dim FechaBuscada As Date
        Dim FechaComparada As Date
        Dim decHonorarios As Decimal
        Dim strHonorariosFormateadosPaciente As String

        FechaBuscada = CType(listBoxConsultas.SelectedItem, Date)
        If File.Exists(strArchivoPropioAGD) Then
            FS = New FileStream(strArchivoPropioAGD, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            C = BR.PeekChar
            While FS.Position < FS.Length
                R = Nothing
                ' Read fields and populate structure
                R.a10FechaConsulta = BR.ReadString
                R.a02Clinica = BR.ReadString
                R.a03NotaseIDx = BR.ReadString
                R.a04Tratamiento = BR.ReadString
                R.a05Pendiente = BR.ReadString
                R.a06ProximaConsulta = BR.ReadString
                R.a07Honorarios = BR.ReadString
                R.a11FacturaAsociada = BR.ReadString
                R.a16Referencia = BR.ReadString
                R.a15Banco = BR.ReadString
                R.a14FormaDePago = BR.ReadString
                R.a13FechaDePago = BR.ReadString
                R.a12Pagador = BR.ReadString

                If IsDate(R.a10FechaConsulta) Then
                    FechaComparada = CType(R.a10FechaConsulta, Date)
                    If FechaBuscada = FechaComparada Then
                        'este es el que se esta apuntando, lo muestra
                        labLugarPaciente.Text = R.a02Clinica

                        txtIDxPaciente.Text = R.a03NotaseIDx
                        txtTtoPaciente.Text = R.a04Tratamiento
                        txtPendientePaciente.Text = R.a05Pendiente
                        labProximaPaciente.Text = R.a06ProximaConsulta
                        'honorarios de esta consulta
                        If IsNumeric(R.a07Honorarios) Then
                            decHonorarios = CType(R.a07Honorarios, Decimal)
                        Else
                            decHonorarios = 0
                        End If
                        strHonorariosFormateadosPaciente = FormatCurrency(decHonorarios, 2, ,, TriState.True)
                        labHonorariosPaciente.Text = strHonorariosFormateadosPaciente
                        'fecha de la consulta
                        If R.a10FechaConsulta.IndexOf("-"c) > -1 Then
                            labFechaConsultaPaciente.Text = (CType(R.a10FechaConsulta, Date)).ToLongDateString
                        Else
                            labFechaConsultaPaciente.Text = R.a10FechaConsulta
                        End If

                        'ya que lo mostro todo sale del while
                        Exit While
                    End If
                End If
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
        End If

        '=========================================
        dateFechaSeleccionada = FechaBuscada

        subGeneraDatosAutomaticos()

        txtAUTOpaciente.Text = strAutoGeneradoControlObs & vbCrLf & strAutoGeneradoEco
        '===================================================
    End Sub


    '0        Parte de los IQs de vista de dias

    Private Sub CalendarioIQ_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioIQdia.DateChanged
        BorraDatosIQSeleccionadoDia()
        dateFechaSeleccionadaIQvistaDia = CalendarioIQdia.SelectionStart
        'actualiza por si se va a editar
        Form1.dateFechaDeInicioParaModificarIntervenciones = CalendarioIQdia.SelectionStart
        ConstruyeNombresIQvistadia()
        VerificaDiaIQ()
    End Sub

    Private Sub BorraDatosIQSeleccionadoDia()
        labNombreIQdia.Text = ""
        labEdadIQdia.Text = ""
        labTipoIQdia.Text = ""
        labRolIQdia.Text = ""
        labMedico1IQdia.Text = ""
        labRolMedico1IQdia.Text = ""
        labMedico2IQdia.Text = ""
        labRolMedico2IQdia.Text = ""
        labLugarIQdia.Text = ""
        labFormaPagoIQdia.Text = ""
        labHonorariosEstimadosIQdia.Text = ""
        labHonorariosPagadosIQdia.Text = ""
        txtNotasIQdia.Clear()
        labFechaNacimientoIQdia.Text = ""
        labCedulaIQdia.Text = ""

    End Sub

    Private Sub ConstruyeNombresIQvistadia()
        strAñoSeleccionadoIQvistadia = dateFechaSeleccionadaIQvistaDia.Year.ToString
        strMesSeleccionadoIQvistadia = dateFechaSeleccionadaIQvistaDia.Month.ToString.PadLeft(2, "0"c)
        strDiaSeleccionadoIQvistadia = dateFechaSeleccionadaIQvistaDia.Day.ToString.PadLeft(2, "0"c)

        strPathIQsubVistaDia = strPathIQ & "\" & strAñoSeleccionadoIQvistadia
        strArchivoIQDia = strPathIQsubVistaDia & "\IQ-" & strAñoSeleccionadoIQvistadia & strMesSeleccionadoIQvistadia & strDiaSeleccionadoIQvistadia & ".iqr"
        strArchivoIQMesDelDiaSeleccionado = strPathIQsubVistaDia & "\IQ-" & strAñoSeleccionadoIQvistadia & strMesSeleccionadoIQvistadia & ".iqr"

    End Sub

    Private Sub VerificaDiaIQ()

        'verificacion de dias sin usar los archivos diario solo el del mes explorando con linq los del dia

        'variables de verificacion de dias IQ
        Dim IQdeEsteDia As String
        Dim decHonorariosPendientesDia As Decimal
        Dim decHonorariosPagadosDia As Decimal
        Dim decHonorariosTotalesDia As Decimal
        Dim NumeroIQDia As Integer

        'para las fechas con negrita
        Dim alsFechasConIQ As New ArrayList() 'FechasConConsultaMes

        'limpia lista de pacientes
        ListBoxIQdia.Items.Clear()

        'inicializa las variables dependientes
        decHonorariosPendientesDia = 0
        decHonorariosPagadosDia = 0
        decHonorariosTotalesDia = 0
        NumeroIQDia = 0

        'inicializa las als dependientes
        alsIntervencionesDelMesDelDiaSeleccionado.Clear()
        alsIntervencionesDelDia.Clear()
        alsFechasConIQ.Clear()

        'ahora revisa si hay un archivo de IQ de ese mes
        If File.Exists(strArchivoIQMesDelDiaSeleccionado) = True Then
            'existe un archivo de control mensual para este dia, lo lee
            FS = New FileStream(strArchivoIQMesDelDiaSeleccionado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)


            C = BR.PeekChar
            While FS.Position < FS.Length
                IQ = Nothing
                ' Read fields and populate structure
                IQ.a01Fecha = BR.ReadString
                IQ.a02NombrePaciente = BR.ReadString
                IQ.a03EdadPaciente = BR.ReadString
                IQ.a04TipoIntervencion = BR.ReadString
                IQ.a05RolEnLaIntervencion = BR.ReadString
                IQ.a06Medico01 = BR.ReadString
                IQ.a07RolMedico01 = BR.ReadString
                IQ.a08Medico02 = BR.ReadString
                IQ.a09RolMedico02 = BR.ReadString
                IQ.a10Lugar = BR.ReadString
                IQ.a11FormaDePago = BR.ReadString
                IQ.a12PagoEfectuado = BR.ReadString
                IQ.a13HonorariosEstimados = BR.ReadString
                IQ.a14HonorariosNetosPagados = BR.ReadString
                IQ.a15Notas = BR.ReadString
                IQ.a16FechaDeNacimiento = BR.ReadString
                IQ.a17Cedula = BR.ReadString
                IQ.b03OtrosC = BR.ReadString
                IQ.b04OtrosD = BR.ReadString
                IQ.b05OtrosE = BR.ReadString

                IQ.a01Fecha = IQ.a01Fecha.Substring(0, 10)
                Dim Fecha = CType(IQ.a01Fecha, Date)
                alsFechasConIQ.Add(Fecha)


                alsIntervencionesDelMesDelDiaSeleccionado.Add(IQ)
                C = BR.PeekChar

            End While
            BR.Close()
            FS.Close()

            'antes de seguir para ver si hay iq el dia seleccionado muestra las fechas q tiene iq del mes poniendolas negritas en el calendario
            Dim Fechas() As Date

            ReDim Fechas(alsFechasConIQ.Count)
            'pone el array de fechas en negrita en el calendario

            Dim Contador = -1
            For Each dateFechaEncontrada As Date In alsFechasConIQ
                Contador += 1
                Fechas(Contador) = dateFechaEncontrada
            Next

            Me.CalendarioIQdia.BoldedDates = Fechas
            Me.CalendarioIQdia.UpdateBoldedDates()


            'ya tengo todas las iq del mes ahora busca las q sean este dia seleccionado
            Dim alsIQsDelDiaSelecionado = From est As Form1.TablaDeIntervenciones In alsIntervencionesDelMesDelDiaSeleccionado
                                          Where CType(est.a01Fecha, Date) = dateFechaSeleccionadaIQvistaDia
                                          Select est

            'revisa si existe almenos 1
            If alsIQsDelDiaSelecionado.Count > 0 Then
                'hay alguna la muestra

                For Each est As Form1.TablaDeIntervenciones In alsIQsDelDiaSelecionado



                    'calcula honorarios de esta IQ
                    If IsNumeric(est.a13HonorariosEstimados) Then
                        decHonorariosPendientes = CType(est.a13HonorariosEstimados, Decimal)
                    Else
                        decHonorariosPendientes = 0
                    End If
                    If IsNumeric(est.a14HonorariosNetosPagados) Then
                        decHonorariosPagados = CType(est.a14HonorariosNetosPagados, Decimal)
                    Else
                        decHonorariosPagados = 0
                    End If
                    decHonorariosPendientesDia += decHonorariosPendientes
                    decHonorariosPagadosDia += decHonorariosPagados
                    decHonorariosTotalesDia += decHonorariosPendientes + decHonorariosPagados

                    'calcula las IQ q van
                    NumeroIQDia += 1

                    'añade la IQ a la lista de intervenciones
                    IQdeEsteDia = est.a02NombrePaciente & " - " & est.a04TipoIntervencion & " - " & est.a05RolEnLaIntervencion
                    ListBoxIQdia.Items.Add(IQdeEsteDia)

                    'añade la iq la la als fuerte q mantiene los datos fuera del procedure
                    alsIntervencionesDelDia.Add(est)

                Next

                'muestra el label con informacion del dia
                labIQdia.Text = "Intervenciones del día " & dateFechaSeleccionadaIQvistaDia.ToLongDateString & ": (" & NumeroIQDia & ")"

                'prende el list box para poder seleccionar de la lista
                ListBoxIQdia.Enabled = True

                'muestra los honorarios del dia
                labHonorariosPendientesTotalesIQdia.Text = FormatCurrency(decHonorariosPendientesDia, 2, ,, TriState.True)
                labHonorariosPagadosTotalesIQdia.Text = FormatCurrency(decHonorariosPagadosDia, 2, ,, TriState.True)
                labHonorariosTotalesIQdia.Text = FormatCurrency(decHonorariosTotalesDia, 2, ,, TriState.True)
            Else
                'no hay iq este dia lo dice
                ListBoxIQdia.Items.Add("No se ingresaron IQ a la agenda en este día")
                ListBoxIQdia.Enabled = False
                'muestra los honorarios del dia
                decHonorariosPendientesDia = 0
                decHonorariosPagadosDia = 0
                decHonorariosTotalesDia = 0
                labHonorariosPendientesTotalesIQdia.Text = FormatCurrency(decHonorariosPendientesDia, 2, , , TriState.True)
                labHonorariosPagadosTotalesIQdia.Text = FormatCurrency(decHonorariosPagadosDia, 2, , , TriState.True)
                labHonorariosTotalesIQdia.Text = FormatCurrency(decHonorariosTotalesDia, 2, , , TriState.True)

                'muestra cuantos pacientes
                labIQdia.Text = "Intervenciones del día " & dateFechaSeleccionadaIQvistaDia.ToLongDateString & ": (0)"
            End If


        Else
            'no hay archivo de iq de este mes por lo q tampoco habra de este dia no?
            ListBoxIQdia.Items.Add("No se ingresaron IQ a la agenda en este día")
            ListBoxIQdia.Enabled = False
            'muestra los honorarios del dia
            decHonorariosPendientesDia = 0
            decHonorariosPagadosDia = 0
            decHonorariosTotalesDia = 0
            labHonorariosPendientesTotalesIQdia.Text = FormatCurrency(decHonorariosPendientesDia, 2, , , TriState.True)
            labHonorariosPagadosTotalesIQdia.Text = FormatCurrency(decHonorariosPagadosDia, 2, , , TriState.True)
            labHonorariosTotalesIQdia.Text = FormatCurrency(decHonorariosTotalesDia, 2, , , TriState.True)

            'muestra cuantos pacientes
            labIQdia.Text = "Intervenciones del día " & dateFechaSeleccionadaIQvistaDia.ToLongDateString & ": (0)"

        End If

    End Sub

    Private Sub ListBoxIQdia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxIQdia.SelectedIndexChanged
        Dim NumeroSeleccionado As Integer
        Dim decHonorarios As Decimal

        'toma el index seleccionado (ojo 0 es el primero)
        NumeroSeleccionado = ListBoxIQdia.SelectedIndex
        'asigna lo guardado en ese index a la estructura IQ
        IQ = alsIntervencionesDelDia(NumeroSeleccionado)
        'obtiene los valores a partir de IQ
        labNombreIQdia.Text = IQ.a02NombrePaciente
        labEdadIQdia.Text = IQ.a03EdadPaciente
        labTipoIQdia.Text = IQ.a04TipoIntervencion
        labRolIQdia.Text = IQ.a05RolEnLaIntervencion
        labMedico1IQdia.Text = IQ.a06Medico01
        labRolMedico1IQdia.Text = IQ.a07RolMedico01
        labMedico2IQdia.Text = IQ.a08Medico02
        labRolMedico2IQdia.Text = IQ.a09RolMedico02
        labLugarIQdia.Text = IQ.a10Lugar
        labFormaPagoIQdia.Text = IQ.a11FormaDePago
        'formatea honorarios pendientes
        If IsNumeric(IQ.a13HonorariosEstimados) Then
            decHonorarios = CType(IQ.a13HonorariosEstimados, Decimal)
        Else
            decHonorarios = 0
        End If
        labHonorariosEstimadosIQdia.Text = FormatCurrency(decHonorarios, 2, , , TriState.True)
        'formatea honorarios pagados
        If IsNumeric(IQ.a14HonorariosNetosPagados) Then
            decHonorarios = CType(IQ.a14HonorariosNetosPagados, Decimal)
        Else
            decHonorarios = 0
        End If
        labHonorariosPagadosIQdia.Text = FormatCurrency(decHonorarios, 2, ,, TriState.True)
        txtNotasIQdia.Text = IQ.a15Notas

        If IQ.a16FechaDeNacimiento.IndexOf("-"c) > -1 Then
            If IsDate(IQ.a16FechaDeNacimiento) Then
                labFechaNacimientoIQdia.Text = (CType(IQ.a16FechaDeNacimiento, Date)).ToShortDateString
            Else
                labFechaNacimientoIQdia.Text = ""
            End If

        Else
            labFechaNacimientoIQdia.Text = IQ.a16FechaDeNacimiento
        End If
        labCedulaIQdia.Text = IQ.a17Cedula


    End Sub

    Private Sub botAgendaIqEditaIQ_Click(sender As System.Object, e As System.EventArgs) Handles botAgendaIqEditaIQ.Click
        Dim Intervenciones As New FormIntervenciones()

        'coloca la fecha actual como inicio de edicion para las intervenciones
        'Form1.dateFechaDeInicioParaModificarIntervenciones = ya se actualiza cada vez q la fecha cambia en el calendario esta lista

        If Intervenciones.ShowDialog = Windows.Forms.DialogResult.OK Then
            'muestra la ventana de edicion de iq
        End If

        'de todas todas actualiza
        ActualizaLightDespuesDeEditarIQ()
        'borra los datos para q no queden desactualizados
        BorraDatosIQSeleccionadoDia()

    End Sub

    Private Sub ActualizaLightDespuesDeEditarIQ()
        'Esto es parte de lo q sale en inicializa al cargar el form agenda pero solo modifica la parte de intervenciones
        CalendarioIQdia.SelectionStart = Form1.dateFechaDeInicioParaModificarIntervenciones
        dateFechaSeleccionadaIQvistaDia = Form1.dateFechaDeInicioParaModificarIntervenciones

        'apunta el inicio de meses al mes y año actuales (para meses)
        dateFechaSeleccionadaIQvistames = Form1.dateFechaDeInicioParaModificarIntervenciones
        strAñoSeleccionadoIQvistames = Form1.dateFechaDeInicioParaModificarIntervenciones.Year
        strMesSeleccionadoIQvistames = Form1.dateFechaDeInicioParaModificarIntervenciones.Month


        dateFechaSeleccionadaIQvistaaño = Form1.dateFechaDeInicioParaModificarIntervenciones
        strAñoSeleccionadoIQvistaaño = Form1.dateFechaDeInicioParaModificarIntervenciones.Year

        'pone la vista de las IQ en dias
        radIQdia.Checked = True
        PanelIQmes.Visible = False
        PanelIQaño.Visible = False

        'y ahora la parte q inicializaba las iq despues de lo anterior al cargar el form
        ConstruyeNombresIQvistadia()
        VerificaDiaIQ()
        ConstruyeNombresIQvistames()
        VerificaMesIQ()
        ConstruyeNombresIQvistaaño()
        VerificaAñoIQ()

    End Sub

    '0        Parte de los IQs de vista de mes

    Private Sub ConstruyeNombresIQvistames()

        'primero muestra que mes esta seleccionado en la vista de mes IQ
        strMesSeleccionadoIQvistamesCadena = MonthName(strMesSeleccionadoIQvistames)
        labMesSeleccionadoIQ.Text = strMesSeleccionadoIQvistamesCadena & " de " & strAñoSeleccionadoIQvistames

        'ahora construye el nombre del archivo de control de meses
        Dim Mes, Año As String
        'primero la cadena del mes
        If strMesSeleccionadoIQvistames < 10 Then
            Mes = "0" & strMesSeleccionadoIQvistames.ToString
        Else
            Mes = strMesSeleccionadoIQvistames.ToString
        End If
        'ahora la cadena de año
        Año = strAñoSeleccionadoIQvistames.ToString

        strPathIQsubVistames = strPathIQ & "\" & Año
        strArchivoIQMes = strPathIQsubVistames & "\IQ-" & Año & Mes & ".iqr"

    End Sub

    Private Sub VerificaMesIQ()
        '000000000000000000000000000000000000
        'variables de verificacion de meses IQ
        Dim decHonorariosPendientesMes As Decimal
        Dim decHonorariosPagadosMes As Decimal
        Dim decHonorariosTotalesMes As Decimal
        Dim NumeroIQMes As Integer

        Dim Fecha As Date
        Dim FechaFormateada As String
        Dim Linea As String

        'variables de la estructura de orden de iq
        Dim Largo As Integer
        Dim PartesDeLaLinea() As String
        Dim NombreOrdenado As String
        Dim TipoIQordenado As String
        Dim PendienteIQ As String

        'limpia lista de pacientes
        ListBoxIQmes.Items.Clear()
        'inicializa las variables dependientes
        decHonorariosPendientesMes = 0
        decHonorariosPagadosMes = 0
        decHonorariosTotalesMes = 0
        NumeroIQMes = 0

        'ahora revisa si hay un archivo de IQs de ese mes
        If File.Exists(strArchivoIQMes) = True Then
            'existe un archivo de IQs de este Mes, lo lee
            FS = New FileStream(strArchivoIQMes, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'resetea los arrays dependientes
            alsDeIntervencionesDelMes.Clear()
            ArraydeLineas.Clear()
            ArrayListaIQmes.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                IQ = Nothing
                ' Read fields and populate structure
                IQ.a01Fecha = BR.ReadString
                IQ.a02NombrePaciente = BR.ReadString
                IQ.a03EdadPaciente = BR.ReadString
                IQ.a04TipoIntervencion = BR.ReadString
                IQ.a05RolEnLaIntervencion = BR.ReadString
                IQ.a06Medico01 = BR.ReadString
                IQ.a07RolMedico01 = BR.ReadString
                IQ.a08Medico02 = BR.ReadString
                IQ.a09RolMedico02 = BR.ReadString
                IQ.a10Lugar = BR.ReadString
                IQ.a11FormaDePago = BR.ReadString
                IQ.a12PagoEfectuado = BR.ReadString
                IQ.a13HonorariosEstimados = BR.ReadString
                IQ.a14HonorariosNetosPagados = BR.ReadString
                IQ.a15Notas = BR.ReadString
                IQ.a16FechaDeNacimiento = BR.ReadString
                IQ.a17Cedula = BR.ReadString
                IQ.b03OtrosC = BR.ReadString
                IQ.b04OtrosD = BR.ReadString
                IQ.b05OtrosE = BR.ReadString
                'primero anota los datos sin orden pero todos en la array de IQ Mes
                'pero primero formatea la fecha como la van a buscar despues...

                'ojo modificacion cuando se puso marica y no queria convertir las fechas
                If IQ.a01Fecha.Length > 10 Then
                    IQ.a01Fecha = IQ.a01Fecha.Substring(0, 10)
                    'MsgBox(IQ.a01Fecha)
                End If

                Fecha = CType(IQ.a01Fecha, Date)
                IQ.a01Fecha = Fecha.ToString("s")
                'ahora si, lo añade todo a la array list de IQ del Mes
                alsDeIntervencionesDelMes.Add(IQ)
                'calcula honorarios de esta IQ
                If IsNumeric(IQ.a13HonorariosEstimados) Then
                    decHonorariosPendientes = CType(IQ.a13HonorariosEstimados, Decimal)
                Else
                    decHonorariosPendientes = 0
                End If
                If IsNumeric(IQ.a14HonorariosNetosPagados) Then
                    decHonorariosPagados = CType(IQ.a14HonorariosNetosPagados, Decimal)
                Else
                    decHonorariosPagados = 0
                End If
                decHonorariosPendientesMes += decHonorariosPendientes
                decHonorariosPagadosMes += decHonorariosPagados
                decHonorariosTotalesMes += decHonorariosPendientes + decHonorariosPagados
                'calcula las IQs q van en el mes
                NumeroIQMes += 1
                '0000000000000000000000000
                'inicia construccion de la linea sorteable
                'formatea fecha
                Fecha = CType(IQ.a01Fecha, Date)
                FechaFormateada = Fecha.ToString("s")
                'procesa si esta o no pendiente..
                If IQ.a12PagoEfectuado = "1" Then
                    PendienteIQ = "Pendiente"
                Else
                    PendienteIQ = "Cancelada"
                End If
                'crea la linea  
                Linea = FechaFormateada & "|" & IQ.a02NombrePaciente & "|" & IQ.a04TipoIntervencion & "|" & PendienteIQ
                ArraydeLineas.Add(Linea)

                'inicia ahora la creacion de la lista para impresion
                If IQ.a12PagoEfectuado = "1" Then
                    Dim strHonEst As String
                    If IsNumeric(IQ.a13HonorariosEstimados) Then
                        strHonEst = FormatNumber(CType(IQ.a13HonorariosEstimados, Decimal), 2,,, TriState.True)
                    Else
                        strHonEst = FormatNumber(0, 2,,, TriState.True)
                    End If
                    Linea = FechaFormateada & "|" & IQ.a02NombrePaciente & "|" & IQ.a04TipoIntervencion & "|" & IQ.a05RolEnLaIntervencion & "|" & IQ.a10Lugar & "|" & strHonEst.PadLeft(11) & "|" & PendienteIQ
                Else
                    Dim strHonPag As String
                    If IsNumeric(IQ.a14HonorariosNetosPagados) Then
                        strHonPag = FormatNumber(CType(IQ.a14HonorariosNetosPagados, Decimal), 2,,, TriState.True)
                    Else
                        strHonPag = FormatNumber(0, 2,,, TriState.True)
                    End If
                    Linea = FechaFormateada & "|" & IQ.a02NombrePaciente & "|" & IQ.a04TipoIntervencion & "|" & IQ.a05RolEnLaIntervencion & "|" & IQ.a10Lugar & "|" & strHonPag.PadLeft(11) & "|" & PendienteIQ
                End If
                ArrayListaIQmes.Add(Linea)

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
            If NumeroIQMes > 0 Then
                'el archivo no esta vacio, lo ordena
                'prende el list box para poder seleccionar de la lista
                ListBoxIQmes.Enabled = True
                'prende el boton de imprime mes
                botImprimeIQmes.Enabled = True

                'ordena segun las fechas
                ArraydeLineas.Sort()
                'ahora prepara la array donde se guardaran el numero de historia en el orden del list box
                alsMesOrdenadosIQ.Clear()
                REnum = ArraydeLineas.GetEnumerator
                'recorre la array de lineas ordenadas segun la fecha
                While REnum.MoveNext
                    'saca la fecha de la linea
                    Linea = CType(REnum.Current, String)
                    'obtiene las partes de la linea delimitadas por el signo "|"
                    PartesDeLaLinea = Linea.Split(CChar("|"))
                    'asigna las partes de la linea a las diferentes variables
                    FechaFormateada = PartesDeLaLinea(0)
                    NombreOrdenado = PartesDeLaLinea(1)
                    TipoIQordenado = PartesDeLaLinea(2)
                    PendienteIQ = PartesDeLaLinea(3)
                    'ahora rellena la estructurita Aiq con los datos ordenados
                    OMiq.FechaControl = FechaFormateada
                    OMiq.Nombre = NombreOrdenado
                    OMiq.TipoIQ = TipoIQordenado
                    'añade la estructura al array list de IQ ordenados por fecha del mes
                    alsMesOrdenadosIQ.Add(OMiq)
                    'reconstituye la linea con las columnas formateadas
                    'la fecha (la formatea a forma corta (10 caracteres)
                    Fecha = CType(FechaFormateada, Date)
                    FechaFormateada = Fecha.ToShortDateString
                    'ahora el nombre, lo recorta o rellena para q tenga 38 caracteres
                    Largo = NombreOrdenado.Length
                    If Largo > 38 Then
                        NombreOrdenado = NombreOrdenado.Remove(38, Largo - 38)
                    ElseIf Largo < 38 Then
                        NombreOrdenado = NombreOrdenado.PadRight(38)
                    Else
                        'el nombre tiene 38 caracteres lo deja igual
                    End If
                    'ahora el tipo de iq igual, a 38
                    Largo = TipoIQordenado.Length
                    If Largo > 38 Then
                        TipoIQordenado = TipoIQordenado.Remove(38, Largo - 38)
                    ElseIf Largo < 38 Then
                        TipoIQordenado = TipoIQordenado.PadRight(38)
                    Else
                        'el tipoIQ tiene 38 caracteres lo deja igual
                    End If
                    'el pendiente empieza igual no importa cuanto tenga
                    Linea = FechaFormateada & "|" & NombreOrdenado & "|" & TipoIQordenado & "|" & PendienteIQ
                    'la añade formateada y en el mismo orden de fecha al list box
                    ListBoxIQmes.Items.Add(Linea)
                End While
            Else
                'el archivo esta vacio, se creó pero no se le ha metido ninguna cita programada
                ListBoxIQmes.Items.Add("No hay intervenciones registradas en el Mes")
                ListBoxIQmes.Enabled = False
                'apaga el boton de imprime mes
                botImprimeIQmes.Enabled = False
            End If
            '================================
            'muestra los honorarios por IQ del Mes
            labHonorariosPendientesTotalesIQmes.Text = FormatCurrency(decHonorariosPendientesMes, 2, , , TriState.True)
            labHonorariosPagadosTotalesIQmes.Text = FormatCurrency(decHonorariosPagadosMes, 2, ,, TriState.True)
            labHonorariosTotalesIQmes.Text = FormatCurrency(decHonorariosTotalesMes, 2, ,, TriState.True)
            'muestra el numero de IQs en el mes
            labNumeroIQmes.Text = NumeroIQMes.ToString
        Else
            'no hay IQ hechas este Mes
            ListBoxIQmes.Items.Add("No hay intervenciones registradas en el Mes")
            ListBoxIQmes.Enabled = False
            'apaga el boton de imprime mes
            botImprimeIQmes.Enabled = False

            'muestra los honorarios del Mes
            decHonorariosPendientesMes = 0
            decHonorariosPagadosMes = 0
            decHonorariosTotalesMes = 0
            labHonorariosPendientesTotalesIQmes.Text = FormatCurrency(decHonorariosPendientesMes, 2, , , TriState.True)
            labHonorariosPagadosTotalesIQmes.Text = FormatCurrency(decHonorariosPagadosMes, 2, , , TriState.True)
            labHonorariosTotalesIQmes.Text = FormatCurrency(decHonorariosTotalesMes, 2, , , TriState.True)
            'muestra cuantos pacientes
            labNumeroIQmes.Text = "0"
        End If
    End Sub

    Private Sub botAdelantaMesIQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdelantaMesIQ.Click
        strMesSeleccionadoIQvistames += 1
        If strMesSeleccionadoIQvistames = 13 Then
            strMesSeleccionadoIQvistames = 1
            strAñoSeleccionadoIQvistames += 1
        End If
        'MuestraMes
        ConstruyeNombresIQvistames()
        VerificaMesIQ()
        BorraDatosIQSeleccionadoMes()
    End Sub

    Private Sub botRetrocedeMesIQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRetrocedeMesIQ.Click
        strMesSeleccionadoIQvistames -= 1
        If strMesSeleccionadoIQvistames = 0 Then
            strMesSeleccionadoIQvistames = 12
            strAñoSeleccionadoIQvistames -= 1
        End If
        'MuestraMes
        ConstruyeNombresIQvistames()
        VerificaMesIQ()
        BorraDatosIQSeleccionadoMes()
    End Sub

    Private Sub BorraDatosIQSeleccionadoMes()
        labNombreIQmes.Text = ""
        labEdadIQmes.Text = ""
        labTipoIQmes.Text = ""
        labRolIQmes.Text = ""
        labMedico1IQmes.Text = ""
        labRolMedico1IQmes.Text = ""
        labMedico2IQmes.Text = ""
        labRolMedico2IQmes.Text = ""
        LabLugarIQmes.Text = ""
        labFormaPagoIQmes.Text = ""
        labHonorariosPendientesIQmes.Text = ""
        labHonorariosPagadosIQmes.Text = ""
        txtNotasIQmes.Clear()
        labFechaNacimientoIQmes.Text = ""
        labCedulaIQmes.Text = ""

    End Sub

    Private Sub ListBoxIQMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxIQmes.SelectedIndexChanged

        'variables locales
        Dim Indice As Integer
        Dim FechaBuscada As Date
        Dim FechaComparada As Date
        Dim NombreBuscado As String
        Dim TipoIQBuscada As String

        Dim decHonorarios As Decimal
        Dim SeConsiguieronLosDatos As Boolean

        'primero toma el indice del elemento seleccionado en la estructura
        Indice = ListBoxIQmes.SelectedIndex
        'ahora asigna el contenido del arraylist ordenado en el indice a Miq
        OMiq = alsMesOrdenadosIQ(Indice)
        'recupera los valores buscados de Miq
        FechaBuscada = OMiq.FechaControl
        NombreBuscado = OMiq.Nombre
        TipoIQBuscada = OMiq.TipoIQ

        BorraDatosIQSeleccionadoMes()

        REnum = alsDeIntervencionesDelMes.GetEnumerator

        'apaga la baderita inicialmente
        SeConsiguieronLosDatos = False

        While REnum.MoveNext
            IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
            'compara los datos para ver si es esta la que se debe mostrar
            FechaComparada = CType(IQ.a01Fecha, Date)
            If FechaComparada = FechaBuscada Then
                'esta es la fecha ahora ve si es el nombre
                If IQ.a02NombrePaciente = NombreBuscado Then
                    'este tambien es el nombre busca si es la misma IQ (no sea q se opero 2 veces el mismo dia a la pte)
                    If IQ.a04TipoIntervencion = TipoIQBuscada Then
                        'definitivamente esta es la IQ q hay que mostrar, la muestra
                        'prende banderita de que la encontro...
                        SeConsiguieronLosDatos = True
                        'muestra los datos
                        labNombreIQmes.Text = IQ.a02NombrePaciente
                        labEdadIQmes.Text = IQ.a03EdadPaciente
                        labTipoIQmes.Text = IQ.a04TipoIntervencion
                        labRolIQmes.Text = IQ.a05RolEnLaIntervencion
                        labMedico1IQmes.Text = IQ.a06Medico01
                        labRolMedico1IQmes.Text = IQ.a07RolMedico01
                        labMedico2IQmes.Text = IQ.a08Medico02
                        labRolMedico2IQmes.Text = IQ.a09RolMedico02
                        LabLugarIQmes.Text = IQ.a10Lugar
                        labFormaPagoIQmes.Text = IQ.a11FormaDePago
                        txtNotasIQmes.Text = IQ.a15Notas
                        If IQ.a16FechaDeNacimiento.IndexOf("-"c) > -1 Then
                            labFechaNacimientoIQmes.Text = (CType(IQ.a16FechaDeNacimiento, Date)).ToShortDateString
                        Else
                            labFechaNacimientoIQmes.Text = IQ.a16FechaDeNacimiento
                        End If
                        labCedulaIQmes.Text = IQ.a17Cedula
                        'formatea honorarios pendientes
                        If IsNumeric(IQ.a13HonorariosEstimados) Then
                            decHonorarios = CType(IQ.a13HonorariosEstimados, Decimal)
                        Else
                            decHonorarios = 0
                        End If
                        labHonorariosPendientesIQmes.Text = FormatCurrency(decHonorarios, 2, , , TriState.True)
                        'formatea honorarios pagados
                        If IsNumeric(IQ.a14HonorariosNetosPagados) Then
                            decHonorarios = CType(IQ.a14HonorariosNetosPagados, Decimal)
                        Else
                            decHonorarios = 0
                        End If
                        labHonorariosPagadosIQmes.Text = FormatCurrency(decHonorarios, 2, , , TriState.True)
                    End If
                End If
            End If
        End While
        'porsi algun error no se puede agarrar los datos
        If SeConsiguieronLosDatos = False Then
            labNombreIQmes.Text = "Datos de la IQ no disponibles"
        End If
    End Sub

    '0        Parte de los IQs de vista de año

    Private Sub ConstruyeNombresIQvistaaño()
        Dim Año As String
        'primero muestra que año esta seleccionado
        labAñoSeleccionadoIQ.Text = strAñoSeleccionadoIQvistaaño.ToString

        'construye el nombre de control anual
        Año = strAñoSeleccionadoIQvistaaño.ToString
        strPathIQsubVistaaño = strPathIQ & "\" & Año
        strArchivoIQaño = strPathIQsubVistaaño & "\IQ-" & Año & ".iqr"
    End Sub

    Private Sub VerificaAñoIQ()
        '000000000000000000000000000000000000
        'variables de verificacion de años IQ
        Dim decHonorariosPendientesAño As Decimal
        Dim decHonorariosPagadosAño As Decimal
        Dim decHonorariosTotalesAño As Decimal
        Dim NumeroIQAño As Integer

        Dim Fecha As Date
        Dim FechaFormateada As String
        Dim Linea As String

        'variables de la estructura de orden de iq
        Dim Largo As Integer
        Dim PartesDeLaLinea() As String
        Dim NombreOrdenado As String
        Dim TipoIQordenado As String
        Dim PendienteIQ As String


        'limpia lista de pacientes
        ListBoxIQaño.Items.Clear()

        'inicializa las variables dependientes
        decHonorariosPendientesAño = 0
        decHonorariosPagadosAño = 0
        decHonorariosTotalesAño = 0
        NumeroIQAño = 0

        'ahora revisa si hay un archivo de IQs de ese año
        If File.Exists(strArchivoIQaño) = True Then
            'existe un archivo de IQs de este año, lo lee
            FS = New FileStream(strArchivoIQaño, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            alsDeIntervencionesDelAño.Clear()
            ArraydeLineas.Clear()
            ArrayListaIQaño.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                IQ = Nothing
                ' Read fields and populate structure
                IQ.a01Fecha = BR.ReadString
                IQ.a02NombrePaciente = BR.ReadString
                IQ.a03EdadPaciente = BR.ReadString
                IQ.a04TipoIntervencion = BR.ReadString
                IQ.a05RolEnLaIntervencion = BR.ReadString
                IQ.a06Medico01 = BR.ReadString
                IQ.a07RolMedico01 = BR.ReadString
                IQ.a08Medico02 = BR.ReadString
                IQ.a09RolMedico02 = BR.ReadString
                IQ.a10Lugar = BR.ReadString
                IQ.a11FormaDePago = BR.ReadString
                IQ.a12PagoEfectuado = BR.ReadString
                IQ.a13HonorariosEstimados = BR.ReadString
                IQ.a14HonorariosNetosPagados = BR.ReadString
                IQ.a15Notas = BR.ReadString
                IQ.a16FechaDeNacimiento = BR.ReadString
                IQ.a17Cedula = BR.ReadString
                IQ.b03OtrosC = BR.ReadString
                IQ.b04OtrosD = BR.ReadString
                IQ.b05OtrosE = BR.ReadString

                'primero anota los datos sin orden pero todos en la array de IQ año
                'pero primero formatea la fecha como la van a buscar despues...
                If IQ.a01Fecha.Length > 10 Then
                    IQ.a01Fecha = IQ.a01Fecha.Substring(0, 10)
                End If
                Fecha = CType(IQ.a01Fecha, Date)
                IQ.a01Fecha = Fecha.ToString("s")
                'ahora si, lo añade todo a la array list de IQ del año
                alsDeIntervencionesDelAño.Add(IQ)

                'calcula honorarios de esta IQ
                If IsNumeric(IQ.a13HonorariosEstimados) Then
                    decHonorariosPendientes = CType(IQ.a13HonorariosEstimados, Decimal)
                Else
                    decHonorariosPendientes = 0
                End If
                If IsNumeric(IQ.a14HonorariosNetosPagados) Then
                    decHonorariosPagados = CType(IQ.a14HonorariosNetosPagados, Decimal)
                Else
                    decHonorariosPagados = 0
                End If
                decHonorariosPendientesAño += decHonorariosPendientes
                decHonorariosPagadosAño += decHonorariosPagados
                decHonorariosTotalesAño += decHonorariosPendientes + decHonorariosPagados

                'calcula las IQs q van en el mes
                NumeroIQAño += 1
                '0000000000000000000000000

                'inicia construccion de la linea sorteable

                'formatea fecha
                Fecha = CType(IQ.a01Fecha, Date)
                FechaFormateada = Fecha.ToString("s")
                'procesa si esta o no pendiente..
                If IQ.a12PagoEfectuado = "1" Then
                    PendienteIQ = "Pendiente"
                Else
                    PendienteIQ = "Cancelada"
                End If

                'crea la linea  
                Linea = FechaFormateada & "|" & IQ.a02NombrePaciente & "|" & IQ.a04TipoIntervencion & "|" & PendienteIQ
                ArraydeLineas.Add(Linea)

                'inicia ahora la creacon de la lista para impresion
                If IQ.a12PagoEfectuado = "1" Then
                    Dim strHonEst As String
                    If IsNumeric(IQ.a13HonorariosEstimados) Then
                        strHonEst = FormatNumber(CType(IQ.a13HonorariosEstimados, Decimal), 2,,, TriState.True)
                    Else
                        strHonEst = FormatNumber(0, 2,,, TriState.True)
                    End If
                    Linea = FechaFormateada & "|" & IQ.a02NombrePaciente & "|" & IQ.a04TipoIntervencion & "|" & IQ.a05RolEnLaIntervencion & "|" & IQ.a10Lugar & "|" & strHonEst.PadLeft(11) & "|" & PendienteIQ
                Else
                    Dim strHonPag As String
                    If IsNumeric(IQ.a14HonorariosNetosPagados) Then
                        strHonPag = FormatNumber(CType(IQ.a14HonorariosNetosPagados, Decimal), 2,,, TriState.True)
                    Else
                        strHonPag = FormatNumber(0, 2,,, TriState.True)
                    End If
                    Linea = FechaFormateada & "|" & IQ.a02NombrePaciente & "|" & IQ.a04TipoIntervencion & "|" & IQ.a05RolEnLaIntervencion & "|" & IQ.a10Lugar & "|" & strHonPag.PadLeft(11) & "|" & PendienteIQ
                End If
                ArrayListaIQaño.Add(Linea)

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            If NumeroIQAño > 0 Then
                'el archivo no esta vacio, lo ordena
                'prende el list box para poder seleccionar de la lista
                ListBoxIQaño.Enabled = True
                'prende el boton de imprime año
                botImprimeIQaño.Enabled = True

                'ordena segun las fechas
                ArraydeLineas.Sort()

                'ahora prepara la array donde se guardaran el numero de historia en el orden del list box
                alsAñoOrdenadosIQ.Clear()
                REnum = ArraydeLineas.GetEnumerator
                'recorre la array de lineas ordenadas segun la fecha
                While REnum.MoveNext
                    'saca la fecha de la linea
                    Linea = CType(REnum.Current, String)

                    'obtiene las partes de la linea delimitadas por el signo "|"
                    PartesDeLaLinea = Linea.Split(CChar("|"))
                    'asigna las partes de la linea a las diferentes variables
                    FechaFormateada = PartesDeLaLinea(0)
                    NombreOrdenado = PartesDeLaLinea(1)
                    TipoIQordenado = PartesDeLaLinea(2)
                    PendienteIQ = PartesDeLaLinea(3)

                    'ahora rellena la estructurita Aiq con los datos ordenados
                    OAiq.FechaControl = FechaFormateada
                    OAiq.Nombre = NombreOrdenado
                    OAiq.TipoIQ = TipoIQordenado
                    OAiq.PendienteIQ = PendienteIQ
                    'añade la estructura al array list de IQ ordenados por fecha del año
                    alsAñoOrdenadosIQ.Add(OAiq)

                    'reconstituye la linea con las columnas formateadas

                    'la fecha (la formatea a forma corta (10 caracteres)
                    Fecha = CType(FechaFormateada, Date)
                    FechaFormateada = Fecha.ToShortDateString

                    'ahora el nombre, lo recorta o rellena para q tenga 38 caracteres
                    Largo = NombreOrdenado.Length
                    If Largo > 38 Then
                        NombreOrdenado = NombreOrdenado.Remove(38, Largo - 38)
                    ElseIf Largo < 38 Then
                        NombreOrdenado = NombreOrdenado.PadRight(38)
                    Else
                        'el nombre tiene 38 caracteres lo deja igual
                    End If

                    'ahora el tipo de iq igual, a 38
                    Largo = TipoIQordenado.Length
                    If Largo > 38 Then
                        TipoIQordenado = TipoIQordenado.Remove(38, Largo - 38)
                    ElseIf Largo < 38 Then
                        TipoIQordenado = TipoIQordenado.PadRight(38)
                    Else
                        'el tipoIQ tiene 38 caracteres lo deja igual
                    End If

                    'el pendiente empieza igual no importa cuanto tenga

                    Linea = FechaFormateada & "|" & NombreOrdenado & "|" & TipoIQordenado & "|" & PendienteIQ
                    'la añade formateada y en el mismo orden de fecha al list box
                    ListBoxIQaño.Items.Add(Linea)
                End While
            Else
                'el archivo esta vacio, se creó pero no se le ha metido ninguna cita programada
                ListBoxIQaño.Items.Add("No hay intervenciones registradas en el año")
                ListBoxIQaño.Enabled = False
                'apaga el boton de imprime año
                botImprimeIQaño.Enabled = False
            End If
            '================================
            'muestra los honorarios por IQ del año
            labHonorariosPendientesTotalesIQaño.Text = FormatCurrency(decHonorariosPendientesAño, 2, , , TriState.True)
            labHonorariosPagadosTotalesIQaño.Text = FormatCurrency(decHonorariosPagadosAño, 2, , , TriState.True)
            labHonorariosTotalesIQaño.Text = FormatCurrency(decHonorariosTotalesAño, 2, , , TriState.True)
            'muestra el numero de IQs en el mes
            labNumeroIQaño.Text = NumeroIQAño.ToString
        Else
            'no hay IQ hechas este año
            ListBoxIQaño.Items.Add("No hay intervenciones registradas en el año")
            ListBoxIQaño.Enabled = False
            'apaga el boton de imprime año
            botImprimeIQaño.Enabled = False

            'muestra los honorarios del año
            decHonorariosPendientesAño = 0
            decHonorariosPagadosAño = 0
            decHonorariosTotalesAño = 0
            labHonorariosPendientesTotalesIQaño.Text = FormatCurrency(decHonorariosPendientesAño, 2, , , TriState.True)
            labHonorariosPagadosTotalesIQaño.Text = FormatCurrency(decHonorariosPagadosAño, 2, ,, TriState.True)
            labHonorariosTotalesIQaño.Text = FormatCurrency(decHonorariosTotalesAño, 2, , , TriState.True)
            'muestra cuantos pacientes
            labNumeroIQaño.Text = "0"
        End If
    End Sub

    Private Sub botAdelantaAñoIQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdelantaAñoIQ.Click
        strAñoSeleccionadoIQvistaaño += 1
        'MuestraAño
        ConstruyeNombresIQvistaaño()
        VerificaAñoIQ()
        BorraDatosIQSeleccionadoAño()
    End Sub

    Private Sub botRetrocedeAñoIQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRetrocedeAñoIQ.Click
        strAñoSeleccionadoIQvistaaño -= 1
        'MuestraAño
        ConstruyeNombresIQvistaaño()
        VerificaAñoIQ()
        BorraDatosIQSeleccionadoAño()
    End Sub

    Private Sub BorraDatosIQSeleccionadoAño()
        labNombreIQaño.Text = ""
        labEdadIQaño.Text = ""
        labTipoIQaño.Text = ""
        labRolIQaño.Text = ""
        labMedico1IQaño.Text = ""
        labRolMedico1IQaño.Text = ""
        labMedico2IQaño.Text = ""
        labRolMedico2IQaño.Text = ""
        labLugarIQaño.Text = ""
        labFormaPagoIQaño.Text = ""
        labHonorariosPendientesIQaño.Text = ""
        labHonorariosPagadosIQaño.Text = ""
        txtNotasIQaño.Clear()
        labFechaNacimientoIQaño.Text = ""
        labCedulaIQaño.Text = ""

    End Sub

    Private Sub ListBoxIQaño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxIQaño.SelectedIndexChanged
        'variables locales
        Dim Indice As Integer
        Dim FechaBuscada As Date
        Dim FechaComparada As Date
        Dim NombreBuscado As String
        Dim TipoIQBuscada As String

        Dim decHonorarios As Decimal
        Dim SeConsiguieronLosDatos As Boolean

        'primero toma el indice del elemento seleccionado en la estructura
        Indice = ListBoxIQaño.SelectedIndex
        'ahora asigna el contenido del arraylist ordenado en el indice a Aiq
        OAiq = alsAñoOrdenadosIQ(Indice)
        'recupera los valores buscados de Aiq
        FechaBuscada = OAiq.FechaControl
        NombreBuscado = OAiq.Nombre
        TipoIQBuscada = OAiq.TipoIQ

        BorraDatosIQSeleccionadoAño()

        REnum = alsDeIntervencionesDelAño.GetEnumerator

        'apaga la baderita inicialmente
        SeConsiguieronLosDatos = False

        While REnum.MoveNext
            IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
            'compara los datos para ver si es esta la que se debe mostrar
            FechaComparada = CType(IQ.a01Fecha, Date)
            If FechaComparada = FechaBuscada Then
                'esta es la fecha ahora ve si es el nombre
                If IQ.a02NombrePaciente = NombreBuscado Then
                    'este tambien es el nombre busca si es la misma IQ (no sea q se opero 2 veces el mismo dia a la pte)
                    If IQ.a04TipoIntervencion = TipoIQBuscada Then
                        'definitivamente esta es la IQ q hay que mostrar, la muestra
                        'prende banderita de que la encontro...
                        SeConsiguieronLosDatos = True
                        'muestra los datos
                        labNombreIQaño.Text = IQ.a02NombrePaciente
                        labEdadIQaño.Text = IQ.a03EdadPaciente
                        labTipoIQaño.Text = IQ.a04TipoIntervencion
                        labRolIQaño.Text = IQ.a05RolEnLaIntervencion
                        labMedico1IQaño.Text = IQ.a06Medico01
                        labRolMedico1IQaño.Text = IQ.a07RolMedico01
                        labMedico2IQaño.Text = IQ.a08Medico02
                        labRolMedico2IQaño.Text = IQ.a09RolMedico02
                        labLugarIQaño.Text = IQ.a10Lugar
                        labFormaPagoIQaño.Text = IQ.a11FormaDePago
                        txtNotasIQaño.Text = IQ.a15Notas
                        If IQ.a16FechaDeNacimiento.IndexOf("-"c) > -1 Then
                            labFechaNacimientoIQaño.Text = (CType(IQ.a16FechaDeNacimiento, Date)).ToShortDateString
                        Else
                            labFechaNacimientoIQaño.Text = IQ.a16FechaDeNacimiento
                        End If
                        labCedulaIQaño.Text = IQ.a17Cedula
                        'formatea honorarios pendientes
                        If IsNumeric(IQ.a13HonorariosEstimados) Then
                            decHonorarios = CType(IQ.a13HonorariosEstimados, Decimal)
                        Else
                            decHonorarios = 0
                        End If
                        labHonorariosPendientesIQaño.Text = FormatCurrency(decHonorarios, 2, , , TriState.True)
                        'formatea honorarios pagados
                        If IsNumeric(IQ.a14HonorariosNetosPagados) Then
                            decHonorarios = CType(IQ.a14HonorariosNetosPagados, Decimal)
                        Else
                            decHonorarios = 0
                        End If
                        labHonorariosPagadosIQaño.Text = FormatCurrency(decHonorarios, 2, , , TriState.True)
                    End If
                End If
            End If
        End While
        'porsi algun error no se puede agarrar los datos
        If SeConsiguieronLosDatos = False Then
            labNombreIQaño.Text = "Datos de la IQ no disponibles"
        End If
    End Sub



    '0        Parte de los Pagos x Dia

    Private Sub chkPAGOincluyeNoFacturados_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPAGOincluyeNoFacturadosDIA.CheckedChanged
        ConstruyeNombresPAGOvistadia()
        VerificaDiaPAGO()
    End Sub

    Private Sub ConstruyeNombresPAGOvistadia()
        AñoSeleccionadoPAGOvistadia = FechaSeleccionadaPAGOvistaDia.Year.ToString
        MesSeleccionadoPAGOvistadia = FechaSeleccionadaPAGOvistaDia.Month.ToString.PadLeft(2, "0"c)
        DiaSeleccionadoPAGOvistadia = FechaSeleccionadaPAGOvistaDia.Day.ToString.PadLeft(2, "0"c)
        PathPAGOsubVistaDia = strPathPAGO & "\" & AñoSeleccionadoPAGOvistadia
        archivoPAGODia = PathPAGOsubVistaDia & "\Pagos-" & AñoSeleccionadoPAGOvistadia & MesSeleccionadoPAGOvistadia & DiaSeleccionadoPAGOvistadia & ".dat"
        strArchivoControlDiario = strPathAgenda & "\" & AñoSeleccionadoPAGOvistadia & "\Control-" & AñoSeleccionadoPAGOvistadia & MesSeleccionadoPAGOvistadia & DiaSeleccionadoPAGOvistadia & ".agd"
    End Sub

    Private Sub VerificaDiaPAGO()

        'variables de verificacion de dias PAGO
        Dim strPAGOdeEsteDia As String

        Dim decPAGOpagoNetoDia As Decimal = 0
        Dim decPAGOretISLRdia As Decimal = 0
        Dim decPAGOretADMdia As Decimal = 0
        Dim decPAGOretOTRASdia As Decimal = 0
        Dim decPAGOpagoTotalDia As Decimal = 0
        Dim intNumeroDePAGOsDia As Integer = 0

        Dim estPAGOconsulta As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual 'est para recopilar info de las consultas del dia

        'limpia lista de pagos
        ListBoxPagosDia.Items.Clear()
        arrayDePAGODia.Clear()

        'ahora revisa si hay un archivo de pagos de ese dia
        If File.Exists(archivoPAGODia) = True Then
            'existe un archivo de control de este dia, lo lee
            FS = New FileStream(archivoPAGODia, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                estPAGO = Nothing
                ' Read fields and populate structure
                estPAGO.a00strIndice = BR.ReadString
                estPAGO.a01datFecha = BR.ReadString
                estPAGO.a02strPagador = BR.ReadString
                estPAGO.a03strMedioDePago = BR.ReadString
                estPAGO.a04strBanco = BR.ReadString
                estPAGO.a05strNumeroReferencia = BR.ReadString
                estPAGO.a06intFacturaAsociada = BR.ReadString
                estPAGO.a06bStrFacturero = BR.ReadString
                estPAGO.a07decRetencionISLR = BR.ReadString
                estPAGO.a08decRetencionADM = BR.ReadString
                estPAGO.a09decRetencionOTROS = BR.ReadString
                estPAGO.a10decMontoNetoPagado = BR.ReadString
                estPAGO.a11decTotalPago = BR.ReadString
                estPAGO.a12booIncluidoEnFacturacion = BR.ReadString
                estPAGO.a13strNotas = BR.ReadString
                estPAGO.a14Rif = BR.ReadString
                estPAGO.b01 = BR.ReadString
                estPAGO.b02 = BR.ReadString
                estPAGO.b03 = BR.ReadString
                estPAGO.b04 = BR.ReadString


                'se debe decidir si se cargan todos o solos los incluidos en facturacion
                If chkPAGOincluyeNoFacturadosDIA.Checked = True Then

                    'incluye todos facturado y no calcula Pagos de este pago especifico
                    If estPAGO.a10decMontoNetoPagado <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a10decMontoNetoPagado) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOpagoNetoDia += CType(estPAGO.a10decMontoNetoPagado, Decimal)
                        End If
                    End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado

                    If estPAGO.a07decRetencionISLR <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a07decRetencionISLR) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOretISLRdia += CType(estPAGO.a07decRetencionISLR, Decimal) * -1 'lo pone negativo de una vez
                        End If
                    End If

                    If estPAGO.a08decRetencionADM <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a08decRetencionADM) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOretADMdia += CType(estPAGO.a08decRetencionADM, Decimal) * -1
                        End If
                    End If

                    If estPAGO.a09decRetencionOTROS <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a09decRetencionOTROS) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOretOTRASdia += CType(estPAGO.a09decRetencionOTROS, Decimal) * -1
                        End If
                    End If

                    arrayDePAGODia.Add(estPAGO)

                Else 'solo incluye los facturados

                    If estPAGO.a12booIncluidoEnFacturacion = "True" Then 'revisa si esta incluido en facturacion y procede

                        If estPAGO.a10decMontoNetoPagado <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a10decMontoNetoPagado) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOpagoNetoDia += CType(estPAGO.a10decMontoNetoPagado, Decimal)
                            End If
                        End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado

                        If estPAGO.a07decRetencionISLR <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a07decRetencionISLR) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOretISLRdia += CType(estPAGO.a07decRetencionISLR, Decimal) * -1 'lo pone negativo de una vez
                            End If
                        End If

                        If estPAGO.a08decRetencionADM <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a08decRetencionADM) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOretADMdia += CType(estPAGO.a08decRetencionADM, Decimal) * -1
                            End If
                        End If

                        If estPAGO.a09decRetencionOTROS <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a09decRetencionOTROS) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOretOTRASdia += CType(estPAGO.a09decRetencionOTROS, Decimal) * -1
                            End If
                        End If

                        arrayDePAGODia.Add(estPAGO)

                    End If
                End If

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        End If

        'aca se debe: leer el control del dia, convertir sus datos sobre la marcha en formato de pago, añadirlos a la als de arriba y luego ordenarlos todos juntos

        If File.Exists(strArchivoControlDiario) = True Then
            'existe un archivo de control de este dia, lo lee
            FS = New FileStream(strArchivoControlDiario, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            'arrayDePAGODia.Clear() no la limpio porq ya se introdujeron datos arriba, se le continuan añadiendo aca

            C = BR.PeekChar
            While FS.Position < FS.Length

                estPAGOconsulta = Nothing
                ' Read fields and populate structure
                estPAGOconsulta.a01NumeroHistoria = BR.ReadString
                estPAGOconsulta.a02Nombre = BR.ReadString
                estPAGOconsulta.a03Cedula = BR.ReadString
                estPAGOconsulta.a04Clinica = BR.ReadString
                estPAGOconsulta.a05NotaseIDx = BR.ReadString
                estPAGOconsulta.a06Tratamiento = BR.ReadString
                estPAGOconsulta.a07Pendiente = BR.ReadString
                estPAGOconsulta.a08ProximaConsulta = BR.ReadString
                estPAGOconsulta.a09Honorarios = BR.ReadString
                estPAGOconsulta.a10FechaConsulta = BR.ReadString
                estPAGOconsulta.a11FacturaAsociada = BR.ReadString
                estPAGOconsulta.a16Referencia = BR.ReadString
                estPAGOconsulta.a15Banco = BR.ReadString
                estPAGOconsulta.a14FormaDePago = BR.ReadString
                estPAGOconsulta.a13FechaDePago = BR.ReadString
                estPAGOconsulta.a12Pagador = BR.ReadString

                ' se inicia la transformacion a la estructura tipo tabla de pago

                estPAGO = Nothing
                estPAGO.a00strIndice = "" 'los valores q no aplique o q no tengan dato en las consultas se ponen en blanco
                estPAGO.a01datFecha = estPAGOconsulta.a10FechaConsulta
                estPAGO.a02strPagador = estPAGOconsulta.a02Nombre
                estPAGO.a03strMedioDePago = "Efectivo" 'siempre sera efectivo por aca
                estPAGO.a04strBanco = ""
                estPAGO.a05strNumeroReferencia = ""
                estPAGO.a06intFacturaAsociada = estPAGOconsulta.a11FacturaAsociada
                estPAGO.a06bStrFacturero = "Maternidad"
                estPAGO.a07decRetencionISLR = "0"
                estPAGO.a08decRetencionADM = "0"
                estPAGO.a09decRetencionOTROS = "0"
                estPAGO.a10decMontoNetoPagado = estPAGOconsulta.a09Honorarios
                estPAGO.a11decTotalPago = estPAGOconsulta.a09Honorarios
                If estPAGOconsulta.a11FacturaAsociada = "-1" Or estPAGOconsulta.a11FacturaAsociada = "" Then
                    'esta en blanco o a nulo dice q false
                    estPAGO.a12booIncluidoEnFacturacion = "False"
                Else
                    'hay algo
                    estPAGO.a12booIncluidoEnFacturacion = "True"
                End If
                estPAGO.a13strNotas = ""
                estPAGO.a14Rif = estPAGOconsulta.a03Cedula
                estPAGO.b01 = ""
                estPAGO.b02 = ""
                estPAGO.b03 = ""
                estPAGO.b04 = ""


                'se debe decidir si se cargan todos o solos los incluidos en facturacion
                If chkPAGOincluyeNoFacturadosDIA.Checked = True Then 'entran todos

                    'calcula Pagos de este pago especifico
                    If estPAGOconsulta.a09Honorarios <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGOconsulta.a09Honorarios) Then
                            'ok es numerico lo convierte y lo suma
                            Dim pagoActual = CType(estPAGOconsulta.a09Honorarios, Decimal)
                            If pagoActual > 0 Then 'si hubo pago realmente lo suma y añade a la als
                                decPAGOpagoNetoDia += CType(estPAGOconsulta.a09Honorarios, Decimal)
                                arrayDePAGODia.Add(estPAGO)
                            End If
                        End If
                    End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado

                Else 'solo incluye los q esten facturados

                    If estPAGO.a12booIncluidoEnFacturacion = "True" Then 'revisa si esta incluido en la facturacion

                        'calcula Pagos de este pago especifico
                        If estPAGOconsulta.a09Honorarios <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGOconsulta.a09Honorarios) Then
                                'ok es numerico lo convierte y lo suma
                                Dim pagoActual = CType(estPAGOconsulta.a09Honorarios, Decimal)
                                If pagoActual > 0 Then 'si hubo pago realmente lo suma y añade a la als
                                    decPAGOpagoNetoDia += CType(estPAGOconsulta.a09Honorarios, Decimal)
                                    arrayDePAGODia.Add(estPAGO)
                                End If
                            End If
                        End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado


                    End If
                End If

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        End If

        'totaliza el pago total del dia despues de recopilar la info desde los pagos y consultas
        decPAGOpagoTotalDia = decPAGOpagoNetoDia - decPAGOretADMdia - decPAGOretISLRdia - decPAGOretOTRASdia

        'ya se cargaron los pagos del dia en la array ahora la ordena 
        alsPAGOSdelDiaOrdenados = From est As Form1.TablaDePagos In arrayDePAGODia _
                                     Order By est.a06intFacturaAsociada _
                                     Order By CType(est.a01datFecha, Date) _
                                     Select est

        'ahora q estan ordenaditos muestra el encabezado
        For Each est As Form1.TablaDePagos In alsPAGOSdelDiaOrdenados

            Dim strFechaSDS = CType(est.a01datFecha, Date).ToShortDateString

            Dim strFactura = "     " 'inicializa en blanco, si hay algo escrito lo reemplaza
            If est.a06intFacturaAsociada <> "" Then
                strFactura = est.a06intFacturaAsociada.PadLeft(5, "0"c)
            End If

            Dim strPagoNeto = "0.00" 'inicializa a una cadena de 0,00 si hay algo lo reemplaza
            If IsNumeric(est.a10decMontoNetoPagado) Then
                'hay un dato valido lo procesa
                strPagoNeto = FormatNumber(CType(est.a10decMontoNetoPagado, Decimal), 2, , , TriState.True)
            End If

            'crea la linea y la muestra
            strPAGOdeEsteDia = strFechaSDS & "     #" & strFactura & "     " & est.a02strPagador.PadRight(43, " "c) & "     " & strPagoNeto.PadLeft(12, " "c)
            ListBoxPagosDia.Items.Add(strPAGOdeEsteDia)

        Next




        'muestra el label con informacion del dia
        labPagosDia.Text = "Pagos del día " & FechaSeleccionadaPAGOvistaDia.ToLongDateString & ": (" & arrayDePAGODia.Count & ")"
        'prende el list box para poder seleccionar de la lista
        ListBoxPagosDia.Enabled = True


        'de todas todas muestra los totales en 0 o si hay archivo en lo q se calculo
        labPagoDiaTotalDevengado.Text = FormatNumber(decPAGOpagoTotalDia, 2, , , TriState.True)
        labPagoDiaRetISLR.Text = FormatNumber(decPAGOretISLRdia, 2, , , TriState.True)
        labPagoDiaRetAdm.Text = FormatNumber(decPAGOretADMdia, 2, , , TriState.True)
        labPagoDiaOtrasRet.Text = FormatNumber(decPAGOretOTRASdia, 2, , , TriState.True)
        labPagoDiaPagadoNeto.Text = FormatNumber(decPAGOpagoNetoDia, 2, , , TriState.True)



        '000000000000000000000000000000000000000000000
        'parte de las fechas que tienen Pagos

        Dim U As New ArrayList() 'FechasConPagosMes
        Dim Fecha As Date
        Dim Año As Integer
        Dim Mes As Integer
        Dim Dia As Integer
        Dim Fechas() As Date
        Dim ArchivoPAGOdelMesdelaVistadeDia As String
        Dim ArchivoPAGOconsultasDelMesdelaVistadeDia As String



        'construye el nombre del mes que se esta viendo en la vista de dias
        ArchivoPAGOdelMesdelaVistadeDia = PathPAGOsubVistaDia & "\Pagos-" & AñoSeleccionadoPAGOvistadia & MesSeleccionadoPAGOvistadia & ".dat"
        ArchivoPAGOconsultasDelMesdelaVistadeDia = strPathAgenda & "\" & AñoSeleccionadoPAGOvistadia & "\Control-" & AñoSeleccionadoPAGOvistadia & MesSeleccionadoPAGOvistadia & ".agd"

        U.Clear()
        Dim Contador As Integer = -1

        If File.Exists(ArchivoPAGOdelMesdelaVistadeDia) = True Then
            'existe un archivo de control de mes, lo lee
            FS = New FileStream(ArchivoPAGOdelMesdelaVistadeDia, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                estPAGO = Nothing
                ' Read fields and populate structure
                estPAGO.a00strIndice = BR.ReadString
                estPAGO.a01datFecha = BR.ReadString
                estPAGO.a02strPagador = BR.ReadString
                estPAGO.a03strMedioDePago = BR.ReadString
                estPAGO.a04strBanco = BR.ReadString
                estPAGO.a05strNumeroReferencia = BR.ReadString
                estPAGO.a06intFacturaAsociada = BR.ReadString
                estPAGO.a06bStrFacturero = BR.ReadString
                estPAGO.a07decRetencionISLR = BR.ReadString
                estPAGO.a08decRetencionADM = BR.ReadString
                estPAGO.a09decRetencionOTROS = BR.ReadString
                estPAGO.a10decMontoNetoPagado = BR.ReadString
                estPAGO.a11decTotalPago = BR.ReadString
                estPAGO.a12booIncluidoEnFacturacion = BR.ReadString
                estPAGO.a13strNotas = BR.ReadString
                estPAGO.a14Rif = BR.ReadString
                estPAGO.b01 = BR.ReadString
                estPAGO.b02 = BR.ReadString
                estPAGO.b03 = BR.ReadString
                estPAGO.b04 = BR.ReadString


                'revisa si se estan incluyendo tosos o solo los facturados
                If chkPAGOincluyeNoFacturadosDIA.Checked = True Then 'se estan incluyendo todos

                    Fecha = CType(estPAGO.a01datFecha, Date)
                    U.Add(Fecha)
                    Contador += 1

                Else 'solo los facturados

                    If estPAGO.a12booIncluidoEnFacturacion = "True" Then
                        Fecha = CType(estPAGO.a01datFecha, Date)
                        U.Add(Fecha)
                        Contador += 1
                    End If

                End If

                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While
            BR.Close()
            FS.Close()


        End If

        If File.Exists(ArchivoPAGOconsultasDelMesdelaVistadeDia) = True Then
            'existe un archivo de control de mes, lo lee
            FS = New FileStream(ArchivoPAGOconsultasDelMesdelaVistadeDia, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                estPAGOconsulta = Nothing
                ' Read fields and populate structure
                estPAGOconsulta.a01NumeroHistoria = BR.ReadString
                estPAGOconsulta.a02Nombre = BR.ReadString
                estPAGOconsulta.a03Cedula = BR.ReadString
                estPAGOconsulta.a04Clinica = BR.ReadString
                estPAGOconsulta.a05NotaseIDx = BR.ReadString
                estPAGOconsulta.a06Tratamiento = BR.ReadString
                estPAGOconsulta.a07Pendiente = BR.ReadString
                estPAGOconsulta.a08ProximaConsulta = BR.ReadString
                estPAGOconsulta.a09Honorarios = BR.ReadString
                estPAGOconsulta.a10FechaConsulta = BR.ReadString
                estPAGOconsulta.a11FacturaAsociada = BR.ReadString
                estPAGOconsulta.a16Referencia = BR.ReadString
                estPAGOconsulta.a15Banco = BR.ReadString
                estPAGOconsulta.a14FormaDePago = BR.ReadString
                estPAGOconsulta.a13FechaDePago = BR.ReadString
                estPAGOconsulta.a12Pagador = BR.ReadString

                'verifica si se efectuo un paga efectivamente no fue exonerada o una anotacion de cesarea en algun sitio
                If IsNumeric(estPAGOconsulta.a09Honorarios) Then
                    Dim pagoActual = CType(estPAGOconsulta.a09Honorarios, Decimal)
                    If pagoActual > 0 Then

                        'aca revisa si se estan metiendo todos o solo los facturados
                        If chkPAGOincluyeNoFacturadosDIA.Checked = True Then 'entran todos
                            Fecha = CType(estPAGOconsulta.a10FechaConsulta, Date)
                            U.Add(Fecha)
                            Contador += 1
                        Else 'solo los facturados
                            If estPAGOconsulta.a11FacturaAsociada <> "" Then 'ok hay algo en facturacion ya se vera si es un numero y esta bien, bueno para corregir errores
                                Fecha = CType(estPAGOconsulta.a10FechaConsulta, Date)
                                U.Add(Fecha)
                                Contador += 1
                            End If
                        End If

                    End If
                End If

                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While
            BR.Close()
            FS.Close()

        End If

        ReDim Fechas(Contador)
        'pone el array de fechas en negrita en el calendario
        Contador = -1
        REnum = U.GetEnumerator
        While REnum.MoveNext
            Contador += 1
            Fecha = CType(REnum.Current, Date)
            Año = Fecha.Year
            Mes = Fecha.Month
            Dia = Fecha.Day
            Fechas(Contador) = New Date(Año, Mes, Dia)
        End While
        Me.CalendarioPagosDia.BoldedDates = Fechas
        Me.CalendarioPagosDia.UpdateBoldedDates()

    End Sub

    Private Sub CalendarioPAGO_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioPagosDia.DateChanged
        BorraPAGOdiaPteSel()
        FechaSeleccionadaPAGOvistaDia = CalendarioPagosDia.SelectionStart
        ConstruyeNombresPAGOvistadia()
        VerificaDiaPAGO()
    End Sub

    Private Sub ListBoxPagosDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxPagosDia.SelectedIndexChanged
        If ListBoxPagosDia.SelectedIndex > -1 Then 'hay una seleccion valida la muestra

            'el rango va de 0 a alsPAGOSdelDiaOrdenados.count
            Dim est As Form1.TablaDePagos = alsPAGOSdelDiaOrdenados(ListBoxPagosDia.SelectedIndex) 'carga el pago en memoria

            BorraPAGOdiaPteSel()

            'muestra los datos
            labPAGOdiaFechaSel.Text = CType(est.a01datFecha, Date).ToShortDateString

            'la factura y su serie. (maternidad serie A y amauri es la serie B
            If est.a12booIncluidoEnFacturacion = "True" Then
                'esta incluida, busca numero de factura
                If IsNumeric(est.a06intFacturaAsociada) Then
                    'ok tiene un numero lo muestra
                    labPAGOdiaFacturaSel.Text = est.a06intFacturaAsociada.PadLeft(5, "0"c)
                Else
                    'esta incluida pero no tiene factura avisa para corregir
                    labPAGOdiaFacturaSel.Text = "Inc S/F"
                    ' MsgBox("Este Pago esta incluido en Facturación pero no tiene asociado un número de factura, revisa", MsgBoxStyle.Information, "Pago incluido en Facturación sin Factura?")
                End If
            Else
                'no esta incluida revisa si tiene numero no deberia tener
                If IsNumeric(est.a06intFacturaAsociada) Then
                    If est.a06intFacturaAsociada = "-1" Then
                        'ok esta a nulo asi se ponian al principio no pasa nada
                        labPAGOdiaFacturaSel.Text = ""
                    Else
                        'tiene un numero pero no esta incluida lo muestra interrogado
                        labPAGOdiaFacturaSel.Text = est.a06intFacturaAsociada.PadLeft(5, "0"c) & "?"
                        MsgBox("Este Pago no esta incluido en Facturación pero tiene asociado un número de factura, revisa", MsgBoxStyle.Information, "Pago incluido en Facturación?")
                    End If

                Else
                    'no esta incluida y no tiene factura se deja en blanco
                    labPAGOdiaFacturaSel.Text = ""
                End If

            End If

            'el pagador
            labPAGOdiaPagadorSel.Text = est.a02strPagador

            'el rif
            labPAGOdiaRif.Text = est.a14Rif

            'el modo de pago
            If est.a03strMedioDePago.ToUpper = "CHEQUE" Then
                'es un cheque revisa el banco y el # de cheque
                labPAGOdiaModoPagoSel.Text = "Cheque " & est.a04strBanco & " #" & est.a05strNumeroReferencia

            ElseIf est.a03strMedioDePago.ToUpper = "DEPÓSITO BANCARIO" Then
                labPAGOdiaModoPagoSel.Text = "Dep.Ban. " & est.a04strBanco & " #" & est.a05strNumeroReferencia

            ElseIf est.a03strMedioDePago.ToUpper = "EFECTIVO" Then 'fue efectivo
                labPAGOdiaModoPagoSel.Text = "Efectivo "

            Else 'CUALQUIER OTRA COSA LO PONE EN ORDEN

                labPAGOdiaModoPagoSel.Text = est.a03strMedioDePago & " " & est.a04strBanco

                If IsNumeric(est.a05strNumeroReferencia) Then
                    labPAGOdiaModoPagoSel.Text += " #" & est.a05strNumeroReferencia
                Else
                    labPAGOdiaModoPagoSel.Text += " " & est.a05strNumeroReferencia
                End If

            End If

            'los pagosy retenciones
            Dim decTotalDevSEL = CType(est.a11decTotalPago, Decimal)
            Dim decNetoSEL = CType(est.a10decMontoNetoPagado, Decimal)
            Dim decRetAdmSEL = CType(est.a08decRetencionADM, Decimal) * -1
            Dim decRetIslrSEL = CType(est.a07decRetencionISLR, Decimal) * -1
            Dim decRetOtrSEL = CType(est.a09decRetencionOTROS, Decimal) * -1

            labPAGOdiaTotalDevengadoSel.Text = FormatNumber(decTotalDevSEL, 2, , , TriState.True)
            labPagoDiaPagadoNetoSel.Text = FormatNumber(decNetoSEL, 2, , , TriState.True)
            labPagoDiaRetAdmSel.Text = FormatNumber(decRetAdmSEL, 2, , , TriState.True)
            labPagoDiaRetISLRsel.Text = FormatNumber(decRetIslrSEL, 2, , , TriState.True)
            labPagoDiaOtrasRetSel.Text = FormatNumber(decRetOtrSEL, 2, , , TriState.True)

            'el porcentaje de retencion
            If decTotalDevSEL > 0 Then
                Dim decPorcentajeRET As Decimal
                decPorcentajeRET = ((decRetAdmSEL + decRetIslrSEL + decRetOtrSEL) * 100) / decTotalDevSEL
                labPAGOdiaPorcentajeDeRetencion.Text = FormatNumber(decPorcentajeRET, 2, , , TriState.True)
            Else
                labPAGOdiaPorcentajeDeRetencion.Text = FormatNumber(0, 2, , , TriState.True)
            End If


            'la inclusion en facturacion
            If est.a12booIncluidoEnFacturacion = "True" Then
                labPAGOdiaIncluidoSel.Text = "(Incluida)"
            Else
                labPAGOdiaIncluidoSel.Text = "(NO Incluida)"
            End If

            'las Notas
            txtPAGOdiaNotasSel.Text = est.a13strNotas

        End If
    End Sub

    Private Sub BorraPAGOdiaPteSel()
        labPAGOdiaFechaSel.Text = ""
        labPAGOdiaFacturaSel.Text = ""
        labPAGOdiaPagadorSel.Text = ""
        labPAGOdiaRif.Text = ""
        labPAGOdiaModoPagoSel.Text = ""
        labPagoDiaRetISLRsel.Text = ""
        labPagoDiaRetAdmSel.Text = ""
        labPagoDiaOtrasRetSel.Text = ""
        labPagoDiaPagadoNetoSel.Text = ""
        labPAGOdiaTotalDevengadoSel.Text = ""
        labPAGOdiaPorcentajeDeRetencion.Text = ""
        labPAGOdiaIncluidoSel.Text = ""
        txtPAGOdiaNotasSel.Clear()
    End Sub


    ' 0000000000 Parte de los Pagos x Mes
    Private Sub chkPAGOincluyeNoFacturadosMES_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPAGOincluyeNoFacturadosMES.CheckedChanged
        ConstruyeNombresPAGOvistaMES()
        VerificaMesPAGO()
    End Sub

    Private Sub ConstruyeNombresPAGOvistaMes()
        AñoSeleccionadoPAGOvistaMes = FechaSeleccionadaPAGOvistaMes.Year.ToString
        MesSeleccionadoPAGOvistaMes = FechaSeleccionadaPAGOvistaMes.Month.ToString.PadLeft(2, "0"c)
        'DiaSeleccionadoPAGOvistadia = FechaSeleccionadaPAGOvistaDia.Day.ToString.PadLeft(2, "0"c)
        PathPAGOsubVistaMes = strPathPAGO & "\" & AñoSeleccionadoPAGOvistaMes
        archivoPAGOMes = PathPAGOsubVistaMes & "\Pagos-" & AñoSeleccionadoPAGOvistaMes & MesSeleccionadoPAGOvistaMes & ".dat"
        strArchivoControlMensual = strPathAgenda & "\" & AñoSeleccionadoPAGOvistaMes & "\Control-" & AñoSeleccionadoPAGOvistaMes & MesSeleccionadoPAGOvistaMes & ".agd"
    End Sub

    Private Sub VerificaMesPAGO()

        'variables de verificacion de meses PAGO
        Dim strPAGOdeEsteMes As String

        Dim decPAGOpagoNetoMes As Decimal = 0
        Dim decPAGOretISLRMes As Decimal = 0
        Dim decPAGOretADMMes As Decimal = 0
        Dim decPAGOretOTRASMes As Decimal = 0
        Dim decPAGOpagoTotalMes As Decimal = 0
        Dim intNumeroDePAGOsMes As Integer = 0

        Dim estPAGOconsulta As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual 'est para recopilar info de las consultas del dia

        'limpia lista de pagos
        ListBoxPagosMes.Items.Clear()
        arrayDePAGOMes.Clear()

        'ahora revisa si hay un archivo de pagos de ese mes
        If File.Exists(archivoPAGOMes) = True Then
            'existe un archivo de control de este mes, lo lee
            FS = New FileStream(archivoPAGOMes, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                estPAGO = Nothing
                ' Read fields and populate structure
                estPAGO.a00strIndice = BR.ReadString
                estPAGO.a01datFecha = BR.ReadString
                estPAGO.a02strPagador = BR.ReadString
                estPAGO.a03strMedioDePago = BR.ReadString
                estPAGO.a04strBanco = BR.ReadString
                estPAGO.a05strNumeroReferencia = BR.ReadString
                estPAGO.a06intFacturaAsociada = BR.ReadString
                estPAGO.a06bStrFacturero = BR.ReadString
                estPAGO.a07decRetencionISLR = BR.ReadString
                estPAGO.a08decRetencionADM = BR.ReadString
                estPAGO.a09decRetencionOTROS = BR.ReadString
                estPAGO.a10decMontoNetoPagado = BR.ReadString
                estPAGO.a11decTotalPago = BR.ReadString
                estPAGO.a12booIncluidoEnFacturacion = BR.ReadString
                estPAGO.a13strNotas = BR.ReadString
                estPAGO.a14Rif = BR.ReadString
                estPAGO.b01 = BR.ReadString
                estPAGO.b02 = BR.ReadString
                estPAGO.b03 = BR.ReadString
                estPAGO.b04 = BR.ReadString


                'se debe decidir si se cargan todos o solos los incluidos en facturacion
                If chkPAGOincluyeNoFacturadosMES.Checked = True Then

                    'incluye todos facturado y no calcula Pagos de este pago especifico
                    If estPAGO.a10decMontoNetoPagado <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a10decMontoNetoPagado) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOpagoNetoMes += CType(estPAGO.a10decMontoNetoPagado, Decimal)
                        End If
                    End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado

                    If estPAGO.a07decRetencionISLR <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a07decRetencionISLR) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOretISLRMes += CType(estPAGO.a07decRetencionISLR, Decimal) * -1 'lo pone negativo de una vez
                        End If
                    End If

                    If estPAGO.a08decRetencionADM <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a08decRetencionADM) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOretADMMes += CType(estPAGO.a08decRetencionADM, Decimal) * -1
                        End If
                    End If

                    If estPAGO.a09decRetencionOTROS <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a09decRetencionOTROS) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOretOTRASMes += CType(estPAGO.a09decRetencionOTROS, Decimal) * -1
                        End If
                    End If

                    arrayDePAGOMes.Add(estPAGO)

                Else 'solo incluye los facturados

                    If estPAGO.a12booIncluidoEnFacturacion = "True" Then 'revisa si esta incluido en facturacion y procede

                        If estPAGO.a10decMontoNetoPagado <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a10decMontoNetoPagado) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOpagoNetoMes += CType(estPAGO.a10decMontoNetoPagado, Decimal)
                            End If
                        End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado

                        If estPAGO.a07decRetencionISLR <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a07decRetencionISLR) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOretISLRMes += CType(estPAGO.a07decRetencionISLR, Decimal) * -1 'lo pone negativo de una vez
                            End If
                        End If

                        If estPAGO.a08decRetencionADM <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a08decRetencionADM) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOretADMMes += CType(estPAGO.a08decRetencionADM, Decimal) * -1
                            End If
                        End If

                        If estPAGO.a09decRetencionOTROS <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a09decRetencionOTROS) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOretOTRASMes += CType(estPAGO.a09decRetencionOTROS, Decimal) * -1
                            End If
                        End If

                        arrayDePAGOMes.Add(estPAGO)

                    End If
                End If

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        End If

        'aca se debe: leer el control del mes, convertir sus datos sobre la marcha en formato de pago, añadirlos a la als de arriba y luego ordenarlos todos juntos

        If File.Exists(strArchivoControlMensual) = True Then
            'existe un archivo de control de este dia, lo lee
            FS = New FileStream(strArchivoControlMensual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            'arrayDePAGOMes.Clear() no la limpio porq ya se introdujeron datos arriba, se le continuan añadiendo aca

            C = BR.PeekChar
            While FS.Position < FS.Length

                estPAGOconsulta = Nothing
                ' Read fields and populate structure
                estPAGOconsulta.a01NumeroHistoria = BR.ReadString
                estPAGOconsulta.a02Nombre = BR.ReadString
                estPAGOconsulta.a03Cedula = BR.ReadString
                estPAGOconsulta.a04Clinica = BR.ReadString
                estPAGOconsulta.a05NotaseIDx = BR.ReadString
                estPAGOconsulta.a06Tratamiento = BR.ReadString
                estPAGOconsulta.a07Pendiente = BR.ReadString
                estPAGOconsulta.a08ProximaConsulta = BR.ReadString
                estPAGOconsulta.a09Honorarios = BR.ReadString
                estPAGOconsulta.a10FechaConsulta = BR.ReadString
                estPAGOconsulta.a11FacturaAsociada = BR.ReadString
                estPAGOconsulta.a16Referencia = BR.ReadString
                estPAGOconsulta.a15Banco = BR.ReadString
                estPAGOconsulta.a14FormaDePago = BR.ReadString
                estPAGOconsulta.a13FechaDePago = BR.ReadString
                estPAGOconsulta.a12Pagador = BR.ReadString

                ' se inicia la transformacion a la estructura tipo tabla de pago

                estPAGO = Nothing
                estPAGO.a00strIndice = "" 'los valores q no aplique o q no tengan dato en las consultas se ponen en blanco
                estPAGO.a01datFecha = estPAGOconsulta.a10FechaConsulta
                estPAGO.a02strPagador = estPAGOconsulta.a02Nombre
                estPAGO.a03strMedioDePago = "Efectivo" 'siempre sera efectivo por aca
                estPAGO.a04strBanco = ""
                estPAGO.a05strNumeroReferencia = ""
                estPAGO.a06intFacturaAsociada = estPAGOconsulta.a11FacturaAsociada
                estPAGO.a06bStrFacturero = "Maternidad"
                estPAGO.a07decRetencionISLR = "0"
                estPAGO.a08decRetencionADM = "0"
                estPAGO.a09decRetencionOTROS = "0"
                estPAGO.a10decMontoNetoPagado = estPAGOconsulta.a09Honorarios
                estPAGO.a11decTotalPago = estPAGOconsulta.a09Honorarios
                If estPAGOconsulta.a11FacturaAsociada = "-1" Or estPAGOconsulta.a11FacturaAsociada = "" Then
                    'esta en blanco o a nulo dice q false
                    estPAGO.a12booIncluidoEnFacturacion = "False"
                Else
                    'hay algo
                    estPAGO.a12booIncluidoEnFacturacion = "True"
                End If
                estPAGO.a13strNotas = ""
                estPAGO.a14Rif = estPAGOconsulta.a03Cedula
                estPAGO.b01 = ""
                estPAGO.b02 = ""
                estPAGO.b03 = ""
                estPAGO.b04 = ""


                'se debe decidir si se cargan todos o solos los incluidos en facturacion
                If chkPAGOincluyeNoFacturadosMES.Checked = True Then 'entran todos

                    'calcula Pagos de este pago especifico
                    If estPAGOconsulta.a09Honorarios <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGOconsulta.a09Honorarios) Then
                            'ok es numerico lo convierte y lo suma
                            Dim pagoActual = CType(estPAGOconsulta.a09Honorarios, Decimal)
                            If pagoActual > 0 Then 'si hubo pago realmente lo suma y añade a la als
                                decPAGOpagoNetoMes += CType(estPAGOconsulta.a09Honorarios, Decimal)
                                arrayDePAGOMes.Add(estPAGO)
                            End If
                        End If
                    End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado

                Else 'solo incluye los q esten facturados

                    If estPAGO.a12booIncluidoEnFacturacion = "True" Then 'revisa si esta incluido en la facturacion

                        'calcula Pagos de este pago especifico
                        If estPAGOconsulta.a09Honorarios <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGOconsulta.a09Honorarios) Then
                                'ok es numerico lo convierte y lo suma
                                Dim pagoActual = CType(estPAGOconsulta.a09Honorarios, Decimal)
                                If pagoActual > 0 Then 'si hubo pago realmente lo suma y añade a la als
                                    decPAGOpagoNetoMes += CType(estPAGOconsulta.a09Honorarios, Decimal)
                                    arrayDePAGOMes.Add(estPAGO)
                                End If
                            End If
                        End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado


                    End If
                End If

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        End If

        'totaliza el pago total del mes despues de recopilar la info desde los pagos y consultas
        decPAGOpagoTotalMes = decPAGOpagoNetoMes - decPAGOretADMMes - decPAGOretISLRMes - decPAGOretOTRASMes

        'ya se cargaron los pagos del mes en la array ahora la ordena 
        alsPAGOSdelMesOrdenados = From est As Form1.TablaDePagos In arrayDePAGOMes _
                                      Order By est.a06intFacturaAsociada _
                                      Order By CType(est.a01datFecha, Date) _
                                      Select est

        'ahora q estan ordenaditos muestra el encabezado
        For Each est As Form1.TablaDePagos In alsPAGOSdelMesOrdenados

            Dim strFechaSDS = CType(est.a01datFecha, Date).ToShortDateString

            Dim strFactura = "     " 'inicializa en blanco, si hay algo escrito lo reemplaza
            If est.a06intFacturaAsociada = "" Or est.a06intFacturaAsociada = "-1" Then
                'no hace nada ya esta inicializada al espacio correcto la factura esta vacia o en nulo (-1)
            Else
                'ok hay un numero lo muestra
                strFactura = est.a06intFacturaAsociada.PadLeft(5, "0"c)
            End If

            Dim strPagoNeto = "0.00" 'inicializa a una cadena de 0,00 si hay algo lo reemplaza
            If IsNumeric(est.a10decMontoNetoPagado) Then
                'hay un dato valido lo procesa
                strPagoNeto = FormatNumber(CType(est.a10decMontoNetoPagado, Decimal), 2, , , TriState.True)
            End If

            'crea la linea y la muestra
            strPAGOdeEsteMes = strFechaSDS & "     #" & strFactura & "     " & est.a02strPagador.PadRight(43, " "c) & "     " & strPagoNeto.PadLeft(11, " "c)
            ListBoxPagosMes.Items.Add(strPAGOdeEsteMes)

        Next




        'muestra el label con informacion del dia
        labPagosMes.Text = "Pagos del mes : (" & arrayDePAGOMes.Count & ")"
        'prende el list box para poder seleccionar de la lista
        ListBoxPagosMes.Enabled = True


        'de todas todas muestra los totales en 0 o si hay archivo en lo q se calculo
        labPagoMesTotalDevengado.Text = FormatNumber(decPAGOpagoTotalMes, 2, , , TriState.True)
        labPagoMesRetISLR.Text = FormatNumber(decPAGOretISLRMes, 2, , , TriState.True)
        labPagoMesRetAdm.Text = FormatNumber(decPAGOretADMMes, 2, , , TriState.True)
        labPagoMesOtrasRet.Text = FormatNumber(decPAGOretOTRASMes, 2, , , TriState.True)
        labPagoMesPagadoNeto.Text = FormatNumber(decPAGOpagoNetoMes, 2, , , TriState.True)

    End Sub

    Private Sub botPagoMesRetrocedeMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPagoMesRetrocedeMes.Click
        BorraPAGOmesPteSel()
        FechaSeleccionadaPAGOvistaMes = FechaSeleccionadaPAGOvistaMes.AddMonths(-1)
        labPagosMesSeleccionado.Text = FechaSeleccionadaPAGOvistaMes.Month.ToString & " - " & FechaSeleccionadaPAGOvistaMes.Year.ToString
        ConstruyeNombresPAGOvistaMes()
        VerificaMesPAGO()
    End Sub

    Private Sub botPagoMesAdelantaMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPagoMesAdelantaMes.Click
        BorraPAGOmesPteSel()
        FechaSeleccionadaPAGOvistaMes = FechaSeleccionadaPAGOvistaMes.AddMonths(1)
        labPagosMesSeleccionado.Text = FechaSeleccionadaPAGOvistaMes.Month.ToString & " - " & FechaSeleccionadaPAGOvistaMes.Year.ToString
        ConstruyeNombresPAGOvistaMes()
        VerificaMesPAGO()
    End Sub

    Private Sub BorraPAGOmesPteSel()
        labPAGOmesFechaSel.Text = ""
        labPAGOmesFacturaSel.Text = ""
        labPAGOmesPagadorSel.Text = ""
        labPAGOmesModoPagoSel.Text = ""
        labPagoMesRetISLRsel.Text = ""
        labPagoMesRetAdmSel.Text = ""
        labPagoMesOtrasRetSel.Text = ""
        labPagoMesPagadoNetoSel.Text = ""
        labPAGOmesTotalDevengadoSel.Text = ""
        labPAGOMesPorcentajeDeRetencion.Text = ""
        labPAGOmesIncluidoSel.Text = ""
        txtPAGOmesNotasSel.Clear()
        labPAGOmesRif.Text = ""
    End Sub

    Private Sub ListBoxPagosMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxPagosMes.SelectedIndexChanged

        If ListBoxPagosMes.SelectedIndex > -1 Then 'hay una seleccion valida la muestra

            'el rango va de 0 a alsPAGOSdelMesOrdenados.count
            Dim est As Form1.TablaDePagos = alsPAGOSdelMesOrdenados(ListBoxPagosMes.SelectedIndex) 'carga el pago en memoria

            BorraPAGOmesPteSel()

            'muestra los datos
            labPAGOmesFechaSel.Text = CType(est.a01datFecha, Date).ToShortDateString

            'la factura y su serie. (maternidad serie A y amauri es la serie B
            If est.a12booIncluidoEnFacturacion = "True" Then
                'esta incluida, busca numero de factura
                If IsNumeric(est.a06intFacturaAsociada) Then
                    'ok tiene un numero lo muestra
                    labPAGOmesFacturaSel.Text = est.a06intFacturaAsociada.PadLeft(5, "0"c)
                Else
                    'esta incluida pero no tiene factura avisa para corregir
                    labPAGOmesFacturaSel.Text = "Inc S/F"
                    'MsgBox("Este Pago esta incluido en Facturación pero no tiene asociado un número de factura, revisa", MsgBoxStyle.Information, "Pago incluido en Facturación sin Factura?")
                End If
            Else
                'no esta incluida revisa si tiene numero no deberia tener
                If IsNumeric(est.a06intFacturaAsociada) Then
                    If est.a06intFacturaAsociada = "-1" Then
                        'ok no pasa nada asi estaba a nulo al principio
                        labPAGOmesFacturaSel.Text = ""
                    Else
                        'tiene un numero pero no esta incluida lo muestra interrogado
                        labPAGOmesFacturaSel.Text = est.a06intFacturaAsociada.PadLeft(5, "0"c) & "?"
                        MsgBox("Este Pago no esta incluido en Facturación pero tiene asociado un número de factura, revisa", MsgBoxStyle.Information, "Pago incluido en Facturación?")
                    End If

                Else
                    'no esta incluida y no tiene factura se deja en blanco
                    labPAGOmesFacturaSel.Text = ""
                End If

            End If

            'el pagador
            labPAGOmesPagadorSel.Text = est.a02strPagador

            'el rif
            labPAGOmesRif.Text = est.a14Rif

            'el modo de pago
            If est.a03strMedioDePago.ToUpper = "CHEQUE" Then
                'es un cheque revisa el banco y el # de cheque
                labPAGOmesModoPagoSel.Text = "Cheque " & est.a04strBanco & " #" & est.a05strNumeroReferencia

            ElseIf est.a03strMedioDePago.ToUpper = "DEPÓSITO BANCARIO" Then
                labPAGOmesModoPagoSel.Text = "Dep.Ban. " & est.a04strBanco & " #" & est.a05strNumeroReferencia

            ElseIf est.a03strMedioDePago.ToUpper = "EFECTIVO" Then 'fue efectivo
                labPAGOmesModoPagoSel.Text = "Efectivo "

            Else 'CUALQUIER OTRA COSA LO PONE EN ORDEN

                labPAGOmesModoPagoSel.Text = est.a03strMedioDePago & " " & est.a04strBanco

                If IsNumeric(est.a05strNumeroReferencia) Then
                    labPAGOmesModoPagoSel.Text += " #" & est.a05strNumeroReferencia
                Else
                    labPAGOmesModoPagoSel.Text += " " & est.a05strNumeroReferencia
                End If

            End If

            'los pagosy retenciones
            Dim decTotalDevSEL = CType(est.a11decTotalPago, Decimal)
            Dim decNetoSEL = CType(est.a10decMontoNetoPagado, Decimal)
            Dim decRetAdmSEL = CType(est.a08decRetencionADM, Decimal) * -1
            Dim decRetIslrSEL = CType(est.a07decRetencionISLR, Decimal) * -1
            Dim decRetOtrSEL = CType(est.a09decRetencionOTROS, Decimal) * -1

            labPAGOmesTotalDevengadoSel.Text = FormatNumber(decTotalDevSEL, 2, , , TriState.True)
            labPagoMesPagadoNetoSel.Text = FormatNumber(decNetoSEL, 2, , , TriState.True)
            labPagoMesRetAdmSel.Text = FormatNumber(decRetAdmSEL, 2, , , TriState.True)
            labPagoMesRetISLRsel.Text = FormatNumber(decRetIslrSEL, 2, , , TriState.True)
            labPagoMesOtrasRetSel.Text = FormatNumber(decRetOtrSEL, 2, , , TriState.True)

            'el porcentaje de retencion
            If decTotalDevSEL > 0 Then
                Dim decPorcentajeRET As Decimal
                decPorcentajeRET = ((decRetAdmSEL + decRetIslrSEL + decRetOtrSEL) * 100) / decTotalDevSEL
                labPAGOMesPorcentajeDeRetencion.Text = FormatNumber(decPorcentajeRET, 2, , , TriState.True)
            Else
                labPAGOMesPorcentajeDeRetencion.Text = FormatNumber(0, 2, , , TriState.True)
            End If

            'la inclusion en facturacion
            If est.a12booIncluidoEnFacturacion = "True" Then
                labPAGOmesIncluidoSel.Text = "(Incluida)"
            Else
                labPAGOmesIncluidoSel.Text = "(NO Incluida)"
            End If

            'las Notas
            txtPAGOmesNotasSel.Text = est.a13strNotas

        End If
    End Sub


    ' 0000000000 Parte de los Pagos x AÑO
    Private Sub chkPAGOincluyeNoFacturadosAÑO_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPAGOincluyeNoFacturadosAÑO.CheckedChanged
        PagosCargaAño()
    End Sub

    Private Sub botPagoAÑORetrocedeAÑO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPagoaÑORetrocedeAño.Click
        BorraPAGOAÑOPteSel()
        FechaSeleccionadaPAGOvistaAÑO = FechaSeleccionadaPAGOvistaAÑO.AddYears(-1)
        labPagosAñoSeleccionado.Text = FechaSeleccionadaPAGOvistaAÑO.Year.ToString
        ListBoxPagosAño.Items.Clear()
        PagosCargaAño()
    End Sub

    Private Sub botPagoAÑOAdelantaAÑO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPagoAÑOAdelantaAño.Click
        BorraPAGOAÑOPteSel()
        FechaSeleccionadaPAGOvistaAÑO = FechaSeleccionadaPAGOvistaAÑO.AddYears(1)
        labPagosAñoSeleccionado.Text = FechaSeleccionadaPAGOvistaAÑO.Year.ToString
        ListBoxPagosAño.Items.Clear()
        PagosCargaAño()
    End Sub

    Private Sub PagosCargaAño()
        ConstruyeNombresPAGOvistaAÑO()
        VerificaAÑOPAGO()
    End Sub

    Private Sub ConstruyeNombresPAGOvistaAÑO()
        AñoSeleccionadoPAGOvistaAÑO = FechaSeleccionadaPAGOvistaAÑO.Year.ToString
        PathPAGOsubVistaAÑO = strPathPAGO & "\" & AñoSeleccionadoPAGOvistaAÑO
        archivoPAGOAÑO = PathPAGOsubVistaAÑO & "\Pagos-" & AñoSeleccionadoPAGOvistaAÑO & ".dat"
        strArchivoControlAnual = strPathAgenda & "\" & AñoSeleccionadoPAGOvistaAÑO & "\Control-" & AñoSeleccionadoPAGOvistaAÑO & ".agd"
    End Sub

    Private Sub VerificaAÑOPAGO()

        'variables de verificacion de AÑOes PAGO
        Dim strPAGOdeEsteAÑO As String

        Dim decPAGOpagoNetoAÑO As Decimal = 0
        Dim decPAGOretISLRAÑO As Decimal = 0
        Dim decPAGOretADMAÑO As Decimal = 0
        Dim decPAGOretOTRASAÑO As Decimal = 0
        Dim decPAGOpagoTotalAÑO As Decimal = 0
        Dim intNumeroDePAGOsAÑO As Integer = 0

        Dim estPAGOconsulta As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual 'est para recopilar info de las consultas del dia

        'limpia lista de pagos
        ListBoxPagosAño.Items.Clear()
        arrayDePAGOAÑO.Clear()

        ProgressBarAÑO.Value = 0

        'ahora revisa si hay un archivo de pagos de ese AÑO
        If File.Exists(archivoPAGOAÑO) = True Then
            'existe un archivo de control de este AÑO, lo lee
            FS = New FileStream(archivoPAGOAÑO, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length

                ProgressBarAÑO.Value = (FS.Position * 100) \ FS.Length
                Me.ProgressBarAÑO.Refresh()

                estPAGO = Nothing
                ' Read fields and populate structure
                estPAGO.a00strIndice = BR.ReadString
                estPAGO.a01datFecha = BR.ReadString
                estPAGO.a02strPagador = BR.ReadString
                estPAGO.a03strMedioDePago = BR.ReadString
                estPAGO.a04strBanco = BR.ReadString
                estPAGO.a05strNumeroReferencia = BR.ReadString
                estPAGO.a06intFacturaAsociada = BR.ReadString
                estPAGO.a06bStrFacturero = BR.ReadString
                estPAGO.a07decRetencionISLR = BR.ReadString
                estPAGO.a08decRetencionADM = BR.ReadString
                estPAGO.a09decRetencionOTROS = BR.ReadString
                estPAGO.a10decMontoNetoPagado = BR.ReadString
                estPAGO.a11decTotalPago = BR.ReadString
                estPAGO.a12booIncluidoEnFacturacion = BR.ReadString
                estPAGO.a13strNotas = BR.ReadString
                estPAGO.a14Rif = BR.ReadString
                estPAGO.b01 = BR.ReadString
                estPAGO.b02 = BR.ReadString
                estPAGO.b03 = BR.ReadString
                estPAGO.b04 = BR.ReadString


                'se debe decidir si se cargan todos o solos los incluidos en facturacion
                If chkPAGOincluyeNoFacturadosAÑO.Checked = True Then

                    'incluye todos facturado y no calcula Pagos de este pago especifico
                    If estPAGO.a10decMontoNetoPagado <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a10decMontoNetoPagado) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOpagoNetoAÑO += CType(estPAGO.a10decMontoNetoPagado, Decimal)
                        End If
                    End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado

                    If estPAGO.a07decRetencionISLR <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a07decRetencionISLR) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOretISLRAÑO += CType(estPAGO.a07decRetencionISLR, Decimal) * -1 'lo pone negativo de una vez
                        End If
                    End If

                    If estPAGO.a08decRetencionADM <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a08decRetencionADM) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOretADMAÑO += CType(estPAGO.a08decRetencionADM, Decimal) * -1
                        End If
                    End If

                    If estPAGO.a09decRetencionOTROS <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGO.a09decRetencionOTROS) Then
                            'ok es numerico lo convierte y lo suma
                            decPAGOretOTRASAÑO += CType(estPAGO.a09decRetencionOTROS, Decimal) * -1
                        End If
                    End If

                    arrayDePAGOAÑO.Add(estPAGO)

                Else 'solo incluye los facturados

                    If estPAGO.a12booIncluidoEnFacturacion = "True" Then 'revisa si esta incluido en facturacion y procede

                        If estPAGO.a10decMontoNetoPagado <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a10decMontoNetoPagado) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOpagoNetoAÑO += CType(estPAGO.a10decMontoNetoPagado, Decimal)
                            End If
                        End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado

                        If estPAGO.a07decRetencionISLR <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a07decRetencionISLR) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOretISLRAÑO += CType(estPAGO.a07decRetencionISLR, Decimal) * -1 'lo pone negativo de una vez
                            End If
                        End If

                        If estPAGO.a08decRetencionADM <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a08decRetencionADM) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOretADMAÑO += CType(estPAGO.a08decRetencionADM, Decimal) * -1
                            End If
                        End If

                        If estPAGO.a09decRetencionOTROS <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGO.a09decRetencionOTROS) Then
                                'ok es numerico lo convierte y lo suma
                                decPAGOretOTRASAÑO += CType(estPAGO.a09decRetencionOTROS, Decimal) * -1
                            End If
                        End If

                        arrayDePAGOAÑO.Add(estPAGO)

                    End If
                End If

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        End If

        'aca se debe: leer el control del AÑO, convertir sus datos sobre la marcha en formato de pago, añadirlos a la als de arriba y luego ordenarlos todos juntos

        If File.Exists(strArchivoControlAnual) = True Then
            'existe un archivo de control de este dia, lo lee
            FS = New FileStream(strArchivoControlAnual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            'arrayDePAGOAÑO.Clear() no la limpio porq ya se introdujeron datos arriba, se le continuan añadiendo aca

            C = BR.PeekChar
            While FS.Position < FS.Length

                ProgressBarAÑO.Value = (FS.Position * 100) \ FS.Length
                Me.ProgressBarAÑO.Refresh()

                estPAGOconsulta = Nothing
                ' Read fields and populate structure
                estPAGOconsulta.a01NumeroHistoria = BR.ReadString
                estPAGOconsulta.a02Nombre = BR.ReadString
                estPAGOconsulta.a03Cedula = BR.ReadString
                estPAGOconsulta.a04Clinica = BR.ReadString
                estPAGOconsulta.a05NotaseIDx = BR.ReadString
                estPAGOconsulta.a06Tratamiento = BR.ReadString
                estPAGOconsulta.a07Pendiente = BR.ReadString
                estPAGOconsulta.a08ProximaConsulta = BR.ReadString
                estPAGOconsulta.a09Honorarios = BR.ReadString
                estPAGOconsulta.a10FechaConsulta = BR.ReadString
                estPAGOconsulta.a11FacturaAsociada = BR.ReadString
                estPAGOconsulta.a16Referencia = BR.ReadString
                estPAGOconsulta.a15Banco = BR.ReadString
                estPAGOconsulta.a14FormaDePago = BR.ReadString
                estPAGOconsulta.a13FechaDePago = BR.ReadString
                estPAGOconsulta.a12Pagador = BR.ReadString

                ' se inicia la transformacion a la estructura tipo tabla de pago

                estPAGO = Nothing
                estPAGO.a00strIndice = "" 'los valores q no aplique o q no tengan dato en las consultas se ponen en blanco
                estPAGO.a01datFecha = estPAGOconsulta.a10FechaConsulta
                estPAGO.a02strPagador = estPAGOconsulta.a02Nombre
                estPAGO.a03strMedioDePago = "Efectivo" 'siempre sera efectivo por aca
                estPAGO.a04strBanco = ""
                estPAGO.a05strNumeroReferencia = ""
                estPAGO.a06intFacturaAsociada = estPAGOconsulta.a11FacturaAsociada
                estPAGO.a06bStrFacturero = "Maternidad"
                estPAGO.a07decRetencionISLR = "0"
                estPAGO.a08decRetencionADM = "0"
                estPAGO.a09decRetencionOTROS = "0"
                estPAGO.a10decMontoNetoPagado = estPAGOconsulta.a09Honorarios
                estPAGO.a11decTotalPago = estPAGOconsulta.a09Honorarios

                If estPAGOconsulta.a11FacturaAsociada = "-1" Or estPAGOconsulta.a11FacturaAsociada = "" Then
                    'esta en blanco o a nulo dice q false
                    estPAGO.a12booIncluidoEnFacturacion = "False"
                Else
                    'hay algo
                    estPAGO.a12booIncluidoEnFacturacion = "True"
                End If

                estPAGO.a13strNotas = ""
                estPAGO.a14Rif = estPAGOconsulta.a03Cedula
                estPAGO.b01 = ""
                estPAGO.b02 = ""
                estPAGO.b03 = ""
                estPAGO.b04 = ""


                'se debe decidir si se cargan todos o solos los incluidos en facturacion
                If chkPAGOincluyeNoFacturadosAÑO.Checked = True Then 'entran todos

                    'calcula Pagos de este pago especifico
                    If estPAGOconsulta.a09Honorarios <> "" Then
                        'hay algo, verifica q sea numerico
                        If IsNumeric(estPAGOconsulta.a09Honorarios) Then
                            'ok es numerico lo convierte y lo suma
                            Dim pagoActual = CType(estPAGOconsulta.a09Honorarios, Decimal)
                            If pagoActual > 0 Then 'si hubo pago realmente lo suma y añade a la als
                                decPAGOpagoNetoAÑO += pagoActual
                                arrayDePAGOAÑO.Add(estPAGO)
                            End If
                        End If
                    End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado

                Else 'solo incluye los q esten facturados

                    If estPAGO.a12booIncluidoEnFacturacion = "True" Then 'revisa si esta incluido en la facturacion

                        'calcula Pagos de este pago especifico
                        If estPAGOconsulta.a09Honorarios <> "" Then
                            'hay algo, verifica q sea numerico
                            If IsNumeric(estPAGOconsulta.a09Honorarios) Then
                                'ok es numerico lo convierte y lo suma
                                Dim pagoActual = CType(estPAGOconsulta.a09Honorarios, Decimal)
                                If pagoActual > 0 Then 'si hubo pago realmente lo suma y añade a la als
                                    decPAGOpagoNetoAÑO += pagoActual
                                    arrayDePAGOAÑO.Add(estPAGO)
                                End If
                            End If
                        End If 'cualquier caso en blanco o no numerico no hace nada mantiene igual el acumulado


                    End If
                End If

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        End If

        'totaliza el pago total del AÑO despues de recopilar la info desde los pagos y consultas
        decPAGOpagoTotalAÑO = decPAGOpagoNetoAÑO - decPAGOretADMAÑO - decPAGOretISLRAÑO - decPAGOretOTRASAÑO

        'ya se cargaron los pagos del AÑO en la array ahora la ordena 
        alsPAGOSdelAÑOOrdenados = From est As Form1.TablaDePagos In arrayDePAGOAÑO _
                                      Order By est.a06intFacturaAsociada _
                                      Order By CType(est.a01datFecha, Date) _
                                      Select est

        'ahora q estan ordenaditos muestra el encabezado
        For Each est As Form1.TablaDePagos In alsPAGOSdelAÑOOrdenados

            Dim strFechaSDS = CType(est.a01datFecha, Date).ToShortDateString

            Dim strFactura = "     " 'inicializa en blanco, si hay algo escrito lo reemplaza
            If est.a06intFacturaAsociada = "" Or est.a06intFacturaAsociada = "-1" Then
                'no hace nada ya se inicializo al espacio correcto esta a nulo o no hay dato
            Else
                'formatea a 5 cifras la factura que esta en disco
                strFactura = est.a06intFacturaAsociada.PadLeft(5, "0"c)
            End If

            Dim strPagoNeto = "0.00" 'inicializa a una cadena de 0,00 si hay algo lo reemplaza
            If IsNumeric(est.a10decMontoNetoPagado) Then
                'hay un dato valido lo procesa
                strPagoNeto = FormatNumber(CType(est.a10decMontoNetoPagado, Decimal), 2, , , TriState.True)
            End If

            'crea la linea y la muestra
            strPAGOdeEsteAÑO = strFechaSDS & "     #" & strFactura & "     " & est.a02strPagador.PadRight(43, " "c) & "     " & strPagoNeto.PadLeft(11, " "c)
            ListBoxPagosAño.Items.Add(strPAGOdeEsteAÑO)

        Next




        'muestra el label con informacion del AÑO
        labPagosAño.Text = "Pagos del AÑO : (" & arrayDePAGOAÑO.Count & ")"
        'prende el list box para poder seleccionar de la lista
        ListBoxPagosAño.Enabled = True


        'de todas todas muestra los totales en 0 o si hay archivo en lo q se calculo
        labPagoAñoTotalDevengado.Text = FormatNumber(decPAGOpagoTotalAÑO, 2, , , TriState.True)
        labPagoAñoRetISLR.Text = FormatNumber(decPAGOretISLRAÑO, 2, , , TriState.True)
        labPagoAñoRetAdm.Text = FormatNumber(decPAGOretADMAÑO, 2, , , TriState.True)
        labPagoAñoOtrasRet.Text = FormatNumber(decPAGOretOTRASAÑO, 2, , , TriState.True)
        labPagoAñoPagadoNeto.Text = FormatNumber(decPAGOpagoNetoAÑO, 2, , , TriState.True)

        'apaga la barra de prog¿reso
        ProgressBarAÑO.Value = 0

    End Sub

    Private Sub BorraPAGOAÑOPteSel()
        labPAGOañoFechaSel.Text = ""
        labPAGOañoFacturaSel.Text = ""
        labPAGOañoPagadorSel.Text = ""
        labPAGOañoModoPagoSel.Text = ""
        labPagoAñoRetISLRsel.Text = ""
        labPagoAñoRetAdmSel.Text = ""
        labPagoAñoOtrasRetSel.Text = ""
        labPagoAñoPagadoNetoSel.Text = ""
        labPAGOañoTotalDevengadoSel.Text = ""
        labPAGOAñoPorcentajeDeRetencion.Text = ""
        labPAGOañoIncluidoSel.Text = ""
        txtPAGOañoNotasSel.Clear()
        labPAGOañoRif.Text = ""
    End Sub

    Private Sub ListBoxPagosAÑO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxPagosAño.SelectedIndexChanged

        If ListBoxPagosAño.SelectedIndex > -1 Then 'hay una seleccion valida la muestra

            'el rango va de 0 a alsPAGOSdelAÑOOrdenados.count
            Dim est As Form1.TablaDePagos = alsPAGOSdelAÑOOrdenados(ListBoxPagosAño.SelectedIndex) 'carga el pago en memoria

            BorraPAGOAÑOPteSel()

            'muestra los datos
            labPAGOañoFechaSel.Text = CType(est.a01datFecha, Date).ToShortDateString

            'la factura y su serie. (maternidad serie A y amauri es la serie B
            If est.a12booIncluidoEnFacturacion = "True" Then
                'esta incluida, busca numero de factura
                If IsNumeric(est.a06intFacturaAsociada) Then
                    'ok tiene un numero lo muestra
                    labPAGOañoFacturaSel.Text = est.a06intFacturaAsociada.PadLeft(5, "0"c)
                Else
                    'esta incluida pero no tiene factura avisa para corregir
                    labPAGOañoFacturaSel.Text = "Inc S/F"
                    'MsgBox("Este Pago esta incluido en Facturación pero no tiene asociado un número de factura, revisa", MsgBoxStyle.Information, "Pago incluido en Facturación sin Factura?")
                End If
            Else
                'no esta incluida revisa si tiene numero no deberia tener
                If IsNumeric(est.a06intFacturaAsociada) Then
                    If est.a06intFacturaAsociada = "-1" Then
                        'ok no pasa nada asi estaba  a nulo al principio
                        labPAGOañoFacturaSel.Text = ""
                    Else
                        'tiene un numero pero no esta incluida lo muestra interrogado
                        labPAGOañoFacturaSel.Text = est.a06intFacturaAsociada.PadLeft(5, "0"c) & "?"
                        MsgBox("Este Pago no esta incluido en Facturación pero tiene asociado un número de factura, revisa", MsgBoxStyle.Information, "Pago incluido en Facturación?")
                    End If
                Else
                    'no esta incluida y no tiene factura se deja en blanco
                    labPAGOañoFacturaSel.Text = ""
                End If

            End If

            'el pagador
            labPAGOañoPagadorSel.Text = est.a02strPagador

            'el Rif
            labPAGOañoRif.Text = est.a14Rif

            'el modo de pago
            If est.a03strMedioDePago.ToUpper = "CHEQUE" Then
                'es un cheque revisa el banco y el # de cheque
                labPAGOañoModoPagoSel.Text = "Cheque " & est.a04strBanco & " #" & est.a05strNumeroReferencia

            ElseIf est.a03strMedioDePago.ToUpper = "DEPÓSITO BANCARIO" Then
                labPAGOañoModoPagoSel.Text = "Dep.Ban. " & est.a04strBanco & " #" & est.a05strNumeroReferencia

            ElseIf est.a03strMedioDePago.ToUpper = "EFECTIVO" Then 'fue efectivo
                labPAGOañoModoPagoSel.Text = "Efectivo "

            Else 'CUALQUIER OTRA COSA LO PONE EN ORDEN

                labPAGOañoModoPagoSel.Text = est.a03strMedioDePago & " " & est.a04strBanco

                If IsNumeric(est.a05strNumeroReferencia) Then
                    labPAGOañoModoPagoSel.Text += " #" & est.a05strNumeroReferencia
                Else
                    labPAGOañoModoPagoSel.Text += " " & est.a05strNumeroReferencia
                End If

            End If

            'los pagosy retenciones
            Dim decTotalDevSEL = CType(est.a11decTotalPago, Decimal)
            Dim decNetoSEL = CType(est.a10decMontoNetoPagado, Decimal)
            Dim decRetAdmSEL = CType(est.a08decRetencionADM, Decimal) * -1
            Dim decRetIslrSEL = CType(est.a07decRetencionISLR, Decimal) * -1
            Dim decRetOtrSEL = CType(est.a09decRetencionOTROS, Decimal) * -1

            labPAGOañoTotalDevengadoSel.Text = FormatNumber(decTotalDevSEL, 2, , , TriState.True)
            labPagoAñoPagadoNetoSel.Text = FormatNumber(decNetoSEL, 2, , , TriState.True)
            labPagoAñoRetAdmSel.Text = FormatNumber(decRetAdmSEL, 2, , , TriState.True)
            labPagoAñoRetISLRsel.Text = FormatNumber(decRetIslrSEL, 2, , , TriState.True)
            labPagoAñoOtrasRetSel.Text = FormatNumber(decRetOtrSEL, 2, , , TriState.True)

            'el porcentaje de retencion
            Dim decPorcentajeRET As Decimal
            If decTotalDevSEL > 0 Then
                decPorcentajeRET = ((decRetAdmSEL + decRetIslrSEL + decRetOtrSEL) * 100) / decTotalDevSEL
            Else
                decPorcentajeRET = 0
            End If
            labPAGOAñoPorcentajeDeRetencion.Text = FormatNumber(decPorcentajeRET, 2, , , TriState.True)

            'la inclusion en facturacion
            If est.a12booIncluidoEnFacturacion = "True" Then
                labPAGOañoIncluidoSel.Text = "(Incluida)"
            Else
                labPAGOañoIncluidoSel.Text = "(NO Incluida)"
            End If

            'las Notas
            txtPAGOañoNotasSel.Text = est.a13strNotas

        End If
    End Sub

    'parte de los pagos y el islr automatico

    Private Sub ConstruyeNombresPAGOvistaAñoIslr()
        AñoSeleccionadoPAGOvistaAÑOISLR = FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString
        PathPAGOsubVistaAÑOISLR = strPathPAGO & "\" & AñoSeleccionadoPAGOvistaAÑOISLR
        archivoPAGOAÑOislr = PathPAGOsubVistaAÑOISLR & "\Pagos-" & AñoSeleccionadoPAGOvistaAÑOISLR & ".dat"
        strArchivoControlAnualIslr = strPathAgenda & "\" & AñoSeleccionadoPAGOvistaAÑOISLR & "\Control-" & AñoSeleccionadoPAGOvistaAÑOISLR & ".agd"

        AñoSeleccionadoPAGOvistaAÑOsiguienteISLR = FechaSeleccionadaPAGOvistaAÑOsiguienteISLR.Year.ToString
        PathPAGOsubVistaAÑOsiguienteISLR = strPathPAGO & "\" & AñoSeleccionadoPAGOvistaAÑOsiguienteISLR
        archivoPAGOAÑOsiguienteislr = PathPAGOsubVistaAÑOsiguienteISLR & "\Pagos-" & AñoSeleccionadoPAGOvistaAÑOsiguienteISLR & ".dat"

    End Sub

    Private Sub VerificaAñoIslrPago()

        Dim estPAGOconsulta As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual 'est para recopilar info de las consultas del dia

        arrayDePAGOañoISLR.Clear()

        ProgressBarAÑOislr.Value = 0

        'ahora revisa si hay un archivo de pagos de ese AÑO
        If File.Exists(archivoPAGOAÑOislr) = True Then
            'existe un archivo de pagos de este AÑO, lo lee

            FS = New FileStream(archivoPAGOAÑOislr, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length

                ProgressBarAñoIslr.Value = (FS.Position * 100) \ FS.Length
                Me.ProgressBarAñoIslr.Refresh()

                estPAGO = Nothing
                ' Read fields and populate structure
                estPAGO.a00strIndice = BR.ReadString
                estPAGO.a01datFecha = BR.ReadString
                estPAGO.a02strPagador = BR.ReadString
                estPAGO.a03strMedioDePago = BR.ReadString
                estPAGO.a04strBanco = BR.ReadString
                estPAGO.a05strNumeroReferencia = BR.ReadString
                estPAGO.a06intFacturaAsociada = BR.ReadString
                estPAGO.a06bStrFacturero = BR.ReadString
                estPAGO.a07decRetencionISLR = BR.ReadString
                estPAGO.a08decRetencionADM = BR.ReadString
                estPAGO.a09decRetencionOTROS = BR.ReadString
                estPAGO.a10decMontoNetoPagado = BR.ReadString
                estPAGO.a11decTotalPago = BR.ReadString
                estPAGO.a12booIncluidoEnFacturacion = BR.ReadString
                estPAGO.a13strNotas = BR.ReadString
                estPAGO.a14Rif = BR.ReadString
                estPAGO.b01 = BR.ReadString
                estPAGO.b02 = BR.ReadString
                estPAGO.b03 = BR.ReadString
                estPAGO.b04 = BR.ReadString


                'verifica q el pago este incluido en la facturacion obvia los demas

                If estPAGO.a12booIncluidoEnFacturacion = "True" Then 'revisa si esta incluido en facturacion y procede

                    arrayDePAGOañoISLR.Add(estPAGO)

                End If

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        End If

        'aca se debe: leer el control del AÑO, convertir sus datos sobre la marcha en formato de pago, añadirlos a la als de arriba y luego ordenarlos todos juntos

        If File.Exists(strArchivoControlAnualIslr) = True Then
            'existe un archivo de control de este año, lo lee
            FS = New FileStream(strArchivoControlAnualIslr, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            'arrayDePAGOAÑOislr.Clear() no la limpio porq ya se introdujeron datos arriba, se le continuan añadiendo aca

            C = BR.PeekChar
            While FS.Position < FS.Length

                ProgressBarAñoIslr.Value = (FS.Position * 100) \ FS.Length
                Me.ProgressBarAñoIslr.Refresh()

                estPAGOconsulta = Nothing
                ' Read fields and populate structure
                estPAGOconsulta.a01NumeroHistoria = BR.ReadString
                estPAGOconsulta.a02Nombre = BR.ReadString
                estPAGOconsulta.a03Cedula = BR.ReadString
                estPAGOconsulta.a04Clinica = BR.ReadString
                estPAGOconsulta.a05NotaseIDx = BR.ReadString
                estPAGOconsulta.a06Tratamiento = BR.ReadString
                estPAGOconsulta.a07Pendiente = BR.ReadString
                estPAGOconsulta.a08ProximaConsulta = BR.ReadString
                estPAGOconsulta.a09Honorarios = BR.ReadString
                estPAGOconsulta.a10FechaConsulta = BR.ReadString
                estPAGOconsulta.a11FacturaAsociada = BR.ReadString
                estPAGOconsulta.a16Referencia = BR.ReadString
                estPAGOconsulta.a15Banco = BR.ReadString
                estPAGOconsulta.a14FormaDePago = BR.ReadString
                estPAGOconsulta.a13FechaDePago = BR.ReadString
                estPAGOconsulta.a12Pagador = BR.ReadString

                ' se inicia la transformacion a la estructura tipo tabla de pago

                estPAGO = Nothing
                estPAGO.a00strIndice = "" 'los valores q no aplique o q no tengan dato en las consultas se ponen en blanco
                estPAGO.a01datFecha = estPAGOconsulta.a10FechaConsulta
                estPAGO.a02strPagador = estPAGOconsulta.a02Nombre
                estPAGO.a03strMedioDePago = "Efectivo" 'siempre sera efectivo por aca
                estPAGO.a04strBanco = ""
                estPAGO.a05strNumeroReferencia = ""
                estPAGO.a06intFacturaAsociada = estPAGOconsulta.a11FacturaAsociada
                estPAGO.a06bStrFacturero = "Maternidad"
                estPAGO.a07decRetencionISLR = "0"
                estPAGO.a08decRetencionADM = "0"
                estPAGO.a09decRetencionOTROS = "0"
                estPAGO.a10decMontoNetoPagado = estPAGOconsulta.a09Honorarios
                estPAGO.a11decTotalPago = estPAGOconsulta.a09Honorarios

                If estPAGOconsulta.a11FacturaAsociada = "-1" Or estPAGOconsulta.a11FacturaAsociada = "" Then
                    'esta en blanco o a nulo dice q false
                    estPAGO.a12booIncluidoEnFacturacion = "False"
                Else
                    'hay algo
                    estPAGO.a12booIncluidoEnFacturacion = "True"
                End If

                estPAGO.a13strNotas = ""
                estPAGO.a14Rif = estPAGOconsulta.a03Cedula
                estPAGO.b01 = ""
                estPAGO.b02 = ""
                estPAGO.b03 = ""
                estPAGO.b04 = ""


                'se deben procesar solo los incluidos en facturacion
                If estPAGO.a12booIncluidoEnFacturacion = "True" Then 'revisa si esta incluido en la facturacion

                    arrayDePAGOañoISLR.Add(estPAGO)

                End If
                C = BR.PeekChar

            End While
            BR.Close()
            FS.Close()

        End If

        'ya se cargaron los pagos del AÑO en la array ahora la ordena 
        alsPAGOSdelAÑOIslrOrdenados = From est As Form1.TablaDePagos In arrayDePAGOañoISLR _
                                      Order By est.a06intFacturaAsociada _
                                      Order By CType(est.a01datFecha, Date) _
                                      Select est

        'apaga la barra de prog¿reso
        ProgressBarAñoIslr.Value = 0


        'finalmente hace los calculos para el año siguiente para buscar los datos de enero y sacar la retencion de ese islr revisa si hay un archivo de pagos de ese AÑO
        arrayDePAGOañoSiguienteISLR.Clear()

        If File.Exists(archivoPAGOAÑOsiguienteislr) = True Then
            'existe un archivo de pagos de este AÑO, lo lee

            FS = New FileStream(archivoPAGOAÑOsiguienteislr, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length

                ProgressBarAñoIslr.Value = (FS.Position * 100) \ FS.Length
                Me.ProgressBarAñoIslr.Refresh()

                estPAGO = Nothing
                ' Read fields and populate structure
                estPAGO.a00strIndice = BR.ReadString
                estPAGO.a01datFecha = BR.ReadString
                estPAGO.a02strPagador = BR.ReadString
                estPAGO.a03strMedioDePago = BR.ReadString
                estPAGO.a04strBanco = BR.ReadString
                estPAGO.a05strNumeroReferencia = BR.ReadString
                estPAGO.a06intFacturaAsociada = BR.ReadString
                estPAGO.a06bStrFacturero = BR.ReadString
                estPAGO.a07decRetencionISLR = BR.ReadString
                estPAGO.a08decRetencionADM = BR.ReadString
                estPAGO.a09decRetencionOTROS = BR.ReadString
                estPAGO.a10decMontoNetoPagado = BR.ReadString
                estPAGO.a11decTotalPago = BR.ReadString
                estPAGO.a12booIncluidoEnFacturacion = BR.ReadString
                estPAGO.a13strNotas = BR.ReadString
                estPAGO.a14Rif = BR.ReadString
                estPAGO.b01 = BR.ReadString
                estPAGO.b02 = BR.ReadString
                estPAGO.b03 = BR.ReadString
                estPAGO.b04 = BR.ReadString


                'verifica q el pago este incluido en la facturacion obvia los demas

                If estPAGO.a12booIncluidoEnFacturacion = "True" Then 'revisa si esta incluido en facturacion y procede

                    arrayDePAGOañoSiguienteISLR.Add(estPAGO)

                End If

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        End If

        'ORDENA LO QUE HAYA asi este vacio
        'ya se cargaron los pagos del AÑO en la array ahora la ordena 
        alsPAGOSdelAÑOsiguienteIslrOrdenados = From est As Form1.TablaDePagos In arrayDePAGOañoSiguienteISLR _
                                               Order By est.a06intFacturaAsociada _
                                               Order By CType(est.a01datFecha, Date) _
                                               Select est

        ProgressBarAñoIslr.Value = 0

    End Sub

    Private Sub botPagoMuestraDatosDelAñoIslr_Click(sender As System.Object, e As System.EventArgs) Handles botPagoMuestraDatosDelAñoIslr.Click
        subCalculaPAGOañoIslr()
    End Sub

    Private Sub subCalculaPAGOañoIslr()
        Dim decNetoPagadoAño As Decimal = 0
        Dim decRetAdmAño As Decimal = 0
        Dim decRetIslrAño As Decimal = 0
        Dim decRetOtroAño As Decimal = 0
        Dim decTotalPagoAño As Decimal = 0

        Dim decNetoPagadoMes, decRetAdmMes, decRetIslrMes, decRetOtroMes, decTotalPagoMes As Decimal

        'esta de abajo son los acumulados de los pagos especiales del año (acciones)
        'Dim decNetoPagadoAñoEsp As Decimal = 0
        'Dim decRetAdmAñoEsp As Decimal = 0
        'Dim decRetIslrAñoEsp As Decimal = 0
        'Dim decRetOtroAñoEsp As Decimal = 0
        'Dim decTotalPagoAñoEsp As Decimal = 0

        'para el calculo del acumulado del islr de febreo a enero año siguiente
        Dim decRetIslrAcumuladoFebDic As Decimal = 0
        Dim decRetIslrAcumuladoFebEne As Decimal = 0
        Dim decRetIslrEneroSiguiente As Decimal = 0

        'mensaje de alerta de q falta el mes de enero del año siguiente
        Dim strMsgAlerteDeFaltaIslrDeEnero As String = ""



        txtPagosExportacionDatos.Text = ""
        Me.txtPagosExportacionDatos.Refresh()

        'titulo General
        txtPagosExportacionDatos.Text += "                                              BALANCE GENERAL DE INGRESOS Y RETENCIONES DEL AÑO " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf & vbCrLf


        txtPagosExportacionDatos.Text += "PAGOS DEL AÑO " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf & vbCrLf

        For intMes = 1 To 12

            ProgressBarAñoIslr.Value = (intMes * 100) \ 12
            Me.ProgressBarAñoIslr.Refresh()
            Me.txtPagosExportacionDatos.Refresh()

            decNetoPagadoMes = 0
            decRetAdmMes = 0
            decRetIslrMes = 0
            decRetOtroMes = 0
            decTotalPagoMes = 0

            Select Case intMes
                Case 1
                    txtPagosExportacionDatos.Text += "ENERO de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 2
                    txtPagosExportacionDatos.Text += "FEBRERO de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 3
                    txtPagosExportacionDatos.Text += "MARZO de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 4
                    txtPagosExportacionDatos.Text += "ABRIL de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 5
                    txtPagosExportacionDatos.Text += "MAYO de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 6
                    txtPagosExportacionDatos.Text += "JUNIO de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 7
                    txtPagosExportacionDatos.Text += "JULIO de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 8
                    txtPagosExportacionDatos.Text += "AGOSTO de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 9
                    txtPagosExportacionDatos.Text += "SEPTIEMBRE de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 10
                    txtPagosExportacionDatos.Text += "OCTUBRE de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 11
                    txtPagosExportacionDatos.Text += "NOVIEMBRE de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
                Case 12
                    txtPagosExportacionDatos.Text += "DICIEMBRE de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf
            End Select

            txtPagosExportacionDatos.Text += "#FACT     FECHA       RIF/CI      PAGADOR                                       PAGO NETO     DesC.ADM    Desc.ISLR    Desc.Otro   TOTAL DEVENGADO" & vbCrLf

            Dim intMesParaElQuery = intMes 'variable local para q no haya lios con el query 

            'Dim alsPAGOSdelMES = From est As Form1.TablaDePagos In alsPAGOSdelAÑOIslrOrdenados
            '                      Where CType(est.a01datFecha, Date).Month = intMesParaElQuery AndAlso est.a06intFacturaAsociada <> ""
            '                      Select est

            Dim alsPAGOSdelMES = From est As Form1.TablaDePagos In alsPAGOSdelAÑOIslrOrdenados
                                Where CType(est.a01datFecha, Date).Month = intMesParaElQuery
                                Select est


            For Each est As Form1.TablaDePagos In alsPAGOSdelMES

                'verifica si tiene numero de factura...
                If est.a06intFacturaAsociada <> "" Then
                    'hay algo lo deja pasar y rellena con ceros
                    txtPagosExportacionDatos.Text += est.a06intFacturaAsociada.PadLeft(6, "0"c) & " "
                Else
                    'esta en blanco debe haber sido un pago sin factura con hojita rosada coloca NA-------
                    txtPagosExportacionDatos.Text += "(N/A)- "
                End If

                txtPagosExportacionDatos.Text += CType(est.a01datFecha, Date).ToShortDateString & " "
                txtPagosExportacionDatos.Text += est.a14Rif.PadLeft(12, " "c) & " "
                txtPagosExportacionDatos.Text += est.a02strPagador.PadRight(45, " "c) & " "
                txtPagosExportacionDatos.Text += FormatNumber(est.a10decMontoNetoPagado, 2, , , TriState.True).PadLeft(12, " "c) & " "
                txtPagosExportacionDatos.Text += FormatNumber(est.a08decRetencionADM, 2, , , TriState.True).PadLeft(12, " "c) & " "
                txtPagosExportacionDatos.Text += FormatNumber(est.a07decRetencionISLR, 2, , , TriState.True).PadLeft(12, " "c) & " "
                txtPagosExportacionDatos.Text += FormatNumber(est.a09decRetencionOTROS, 2, , , TriState.True).PadLeft(12, " "c) & " "
                txtPagosExportacionDatos.Text += FormatNumber(est.a11decTotalPago, 2, , , TriState.True).PadLeft(12, " "c) & " "

                txtPagosExportacionDatos.Text += vbCrLf

                'calculos del mes
                decNetoPagadoMes += CType(est.a10decMontoNetoPagado, Decimal)
                decRetAdmMes += CType(est.a08decRetencionADM, Decimal)
                decRetIslrMes += CType(est.a07decRetencionISLR, Decimal)
                decRetOtroMes += CType(est.a09decRetencionOTROS, Decimal)
                decTotalPagoMes += CType(est.a11decTotalPago, Decimal)

            Next

            'totaliza el mes
            txtPagosExportacionDatos.Text += "Totales del Mes".PadRight(76, " "c) & " "
            txtPagosExportacionDatos.Text += FormatNumber(decNetoPagadoMes, 2, , , TriState.True).PadLeft(12, " "c) & " "
            txtPagosExportacionDatos.Text += FormatNumber(decRetAdmMes, 2, , , TriState.True).PadLeft(12, " "c) & " "
            txtPagosExportacionDatos.Text += FormatNumber(decRetIslrMes, 2, , , TriState.True).PadLeft(12, " "c) & " "
            txtPagosExportacionDatos.Text += FormatNumber(decRetOtroMes, 2, , , TriState.True).PadLeft(12, " "c) & " "
            txtPagosExportacionDatos.Text += FormatNumber(decTotalPagoMes, 2, , , TriState.True).PadLeft(12, " "c) & " "

            txtPagosExportacionDatos.Text += vbCrLf & vbCrLf

            'acumula el mes para la cuenta de año
            decNetoPagadoAño += decNetoPagadoMes
            decRetAdmAño += decRetAdmMes
            decRetIslrAño += decRetIslrMes
            decRetOtroAño += decRetOtroMes
            decTotalPagoAño += decTotalPagoMes

            'busca el acumulado de febrero a diciembre del año investigado
            If intMes <> 1 Then
                decRetIslrAcumuladoFebDic += decRetIslrMes
            End If


        Next

        'TOTALIZA EL AÑO


        txtPagosExportacionDatos.Text += vbCrLf & vbCrLf & "".PadRight(150, "-"c) & vbCrLf & vbCrLf 'rayita larga

        txtPagosExportacionDatos.Text += "                                                                                PAGO NETO     DesC.ADM    Desc.ISLR    Desc.Otro   TOTAL DEVENGADO" & vbCrLf
        txtPagosExportacionDatos.Text += "Total Pagos del Año".PadRight(76, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decNetoPagadoAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetAdmAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetIslrAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetOtroAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decTotalPagoAño, 2, , , TriState.True).PadLeft(12, " "c) & " "


        txtPagosExportacionDatos.Text += vbCrLf & vbCrLf & "".PadRight(150, "-"c) & vbCrLf & vbCrLf 'rayita larga

        'calcula los pagos especiales q estan incluidos pero sin numero de factura x ejemplo las acciones

        'Dim alsPAGOSespecialesdelAño = From est As Form1.TablaDePagos In alsPAGOSdelAÑOIslrOrdenados
        '                               Where est.a06intFacturaAsociada = ""
        '                               Select est

        ''encabezado
        'txtPagosExportacionDatos.Text += "PAGOS ESPECIALES (DIVIDENDOS Y OTROS INGRESOS) de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf & vbCrLf
        'txtPagosExportacionDatos.Text += "#FACT     FECHA       RIF/CI      PAGADOR                                       PAGO NETO     DesC.ADM    Desc.ISLR    Desc.Otro   TOTAL DEVENGADO" & vbCrLf

        'For Each est As Form1.TablaDePagos In alsPAGOSespecialesdelAño

        '    txtPagosExportacionDatos.Text += est.a06intFacturaAsociada.PadLeft(6, "-"c) & " "
        '    txtPagosExportacionDatos.Text += CType(est.a01datFecha, Date).ToShortDateString & " "
        '    txtPagosExportacionDatos.Text += est.a14Rif.PadLeft(12, " "c) & " "
        '    txtPagosExportacionDatos.Text += est.a02strPagador.PadRight(45, " "c) & " "
        '    txtPagosExportacionDatos.Text += FormatNumber(est.a10decMontoNetoPagado, 2, , , TriState.True).PadLeft(12, " "c) & " "
        '    txtPagosExportacionDatos.Text += FormatNumber(est.a08decRetencionADM, 2, , , TriState.True).PadLeft(12, " "c) & " "
        '    txtPagosExportacionDatos.Text += FormatNumber(est.a07decRetencionISLR, 2, , , TriState.True).PadLeft(12, " "c) & " "
        '    txtPagosExportacionDatos.Text += FormatNumber(est.a09decRetencionOTROS, 2, , , TriState.True).PadLeft(12, " "c) & " "
        '    txtPagosExportacionDatos.Text += FormatNumber(est.a11decTotalPago, 2, , , TriState.True).PadLeft(12, " "c) & " "

        '    txtPagosExportacionDatos.Text += vbCrLf

        '    'calculos de ingresos especiales del año
        '    decNetoPagadoAñoEsp += CType(est.a10decMontoNetoPagado, Decimal)
        '    decRetAdmAñoEsp += CType(est.a08decRetencionADM, Decimal)
        '    decRetIslrAñoEsp += CType(est.a07decRetencionISLR, Decimal)
        '    decRetOtroAñoEsp += CType(est.a09decRetencionOTROS, Decimal)
        '    decTotalPagoAñoEsp += CType(est.a11decTotalPago, Decimal)

        '    'verifica acumulado de feb a dic para el islr acumulado a declarar
        '    If CType(est.a01datFecha, Date).Month <> 1 Then
        '        decRetIslrAcumuladoFebDic += CType(est.a07decRetencionISLR, Decimal)
        '    End If

        'Next

        ''totaliza pagos especiales del año
        'txtPagosExportacionDatos.Text += "Sub Total de Pagos Especiales".PadRight(76, " "c) & " "
        'txtPagosExportacionDatos.Text += FormatNumber(decNetoPagadoAñoEsp, 2, , , TriState.True).PadLeft(12, " "c) & " "
        'txtPagosExportacionDatos.Text += FormatNumber(decRetAdmAñoEsp, 2, , , TriState.True).PadLeft(12, " "c) & " "
        'txtPagosExportacionDatos.Text += FormatNumber(decRetIslrAñoEsp, 2, , , TriState.True).PadLeft(12, " "c) & " "
        'txtPagosExportacionDatos.Text += FormatNumber(decRetOtroAñoEsp, 2, , , TriState.True).PadLeft(12, " "c) & " "
        'txtPagosExportacionDatos.Text += FormatNumber(decTotalPagoAñoEsp, 2, , , TriState.True).PadLeft(12, " "c) & " "

        ''rayita larga
        'txtPagosExportacionDatos.Text += vbCrLf & vbCrLf & "".PadRight(150, "-"c) & vbCrLf & vbCrLf

        ''totaliza los ingresos generales del año
        'decNetoPagadoAño += decNetoPagadoAñoEsp
        'decRetAdmAño += decRetAdmAñoEsp
        'decRetIslrAño += decRetIslrAñoEsp
        'decRetOtroAño += decRetOtroAñoEsp
        'decTotalPagoAño += decTotalPagoAñoEsp

        'txtPagosExportacionDatos.Text += "TOTAL GENERAL DE INGRESOS DEL AÑO".PadRight(76, " "c) & " "
        'txtPagosExportacionDatos.Text += FormatNumber(decNetoPagadoAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        'txtPagosExportacionDatos.Text += FormatNumber(decRetAdmAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        'txtPagosExportacionDatos.Text += FormatNumber(decRetIslrAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        'txtPagosExportacionDatos.Text += FormatNumber(decRetOtroAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        'txtPagosExportacionDatos.Text += FormatNumber(decTotalPagoAño, 2, , , TriState.True).PadLeft(12, " "c) & " "

        'rayita larga
        txtPagosExportacionDatos.Text += vbCrLf & vbCrLf & "".PadRight(150, "-"c) & vbCrLf & vbCrLf

        'TERMINA DE CALCULAR LO DEL ISLR le suma al acumulador de feb a dic el mes de enero del siguiente año -------------------

        If alsPAGOSdelAÑOsiguienteIslrOrdenados.Count > 0 Then 'hay algun pago en el año siguiente procede a revisarlo

            'calcula el islr de enero del año siguiente


            'ojo se pone 1 por enero y se quita lo d q tenga #de factura porq no importa si fue un gasto facturado o un otro ingreso hay q agarrar el islr de ese ingreso
            Dim alsPAGOSdeEneroSiguiente = From est As Form1.TablaDePagos In alsPAGOSdelAÑOsiguienteIslrOrdenados
                                           Where CType(est.a01datFecha, Date).Month = 1
                                           Select est

            For Each est As Form1.TablaDePagos In alsPAGOSdeEneroSiguiente
                'calculos del mes
                If IsNumeric(est.a07decRetencionISLR) Then
                    decRetIslrEneroSiguiente += CType(est.a07decRetencionISLR, Decimal)
                End If

            Next

            'Añade el mes de enero siguiente al acumulado feb-dic
            decRetIslrAcumuladoFebEne = decRetIslrAcumuladoFebDic + decRetIslrEneroSiguiente

            'mensaje porsia es cero
            If decRetIslrEneroSiguiente = 0 Then
                strMsgAlerteDeFaltaIslrDeEnero = "El ISLR retenido en Enero(" & FechaSeleccionadaPAGOvistaAÑOsiguienteISLR.Year.ToString & ") correspondiente a lo generado en Diciembre(" & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & ") actualmente es 0,00 Bs (Verifica)"
            End If

        Else 'no hay pagos en el año siguiente se pone a cero y avisa q falta el mes de enero del año siguiente para los calculos

            'no suma cero no hace falta pero da aviso
            strMsgAlerteDeFaltaIslrDeEnero = "No se han incluido pagos en el próximo año, falta el ISLR de Enero... (Datos Incompletos)"

        End If

        'muestra retencion final de feb a ene
        txtPagosExportacionDatos.Text += "RETENCION ACUMULADA DE ISLR LAPSO FEBRERO(" & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & ")-ENERO(" & FechaSeleccionadaPAGOvistaAÑOsiguienteISLR.Year.ToString & ")" & vbCrLf & vbCrLf

        txtPagosExportacionDatos.Text += "                                                                               ACUMULADO FEB-DIC     ENERO SIGUIENTE         TOTAL RETENIDO" & vbCrLf

        txtPagosExportacionDatos.Text += "TOTAL ACUMULADO".PadRight(83, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetIslrAcumuladoFebDic, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetIslrEneroSiguiente, 2, , , TriState.True).PadLeft(19, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetIslrAcumuladoFebEne, 2, , , TriState.True).PadLeft(19, " "c) & " "

        'RAYA FINAL
        txtPagosExportacionDatos.Text += vbCrLf & vbCrLf & "".PadRight(150, "-"c) & vbCrLf & vbCrLf

        'MESAJE FINAL SI HAY
        txtPagosExportacionDatos.Text += strMsgAlerteDeFaltaIslrDeEnero







    End Sub




    Private Sub botPagoAÑORetrocedeAÑOislr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPagoRetrocedeAñoIslr.Click
        txtPagosExportacionDatos.Clear()
        FechaSeleccionadaPAGOvistaAÑOISLR = FechaSeleccionadaPAGOvistaAÑOISLR.AddYears(-1)
        FechaSeleccionadaPAGOvistaAÑOsiguienteISLR = FechaSeleccionadaPAGOvistaAÑOsiguienteISLR.AddYears(-1)
        labPagosAñoIslrSeleccionado.Text = FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString
        ConstruyeNombresPAGOvistaAñoIslr()
        VerificaAñoIslrPago()
    End Sub

    Private Sub botPagoAÑOAdelantaAÑOislr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPagoAdelantaAñoIslr.Click
        txtPagosExportacionDatos.Clear()
        FechaSeleccionadaPAGOvistaAÑOISLR = FechaSeleccionadaPAGOvistaAÑOISLR.AddYears(1)
        FechaSeleccionadaPAGOvistaAÑOsiguienteISLR = FechaSeleccionadaPAGOvistaAÑOsiguienteISLR.AddYears(1)
        labPagosAñoIslrSeleccionado.Text = FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString
        ConstruyeNombresPAGOvistaAñoIslr()
        VerificaAñoIslrPago()
    End Sub




#Region "00000000000000000000000000000000 ficha de Resumen de Honorarios  VIEJAS 000000000000000000000000000000000 "

    Private Sub ConstruyeNombresHonorariosVIEJA()
        Dim Año As String
        'primero muestra que año esta seleccionado
        labAñoSeleccionadoHon.Text = AñoseleccionadoHonorarios
        Año = AñoseleccionadoHonorarios
        'construye los nombres de archivo de mes de la agenda de ese año
        archivoHonIQene = strPathIQ & "\" & Año & "\IQ-" & Año & "01.iqr"
        archivoHonIQfeb = strPathIQ & "\" & Año & "\IQ-" & Año & "02.iqr"
        archivoHonIQmar = strPathIQ & "\" & Año & "\IQ-" & Año & "03.iqr"
        archivoHonIQabr = strPathIQ & "\" & Año & "\IQ-" & Año & "04.iqr"
        archivoHonIQmay = strPathIQ & "\" & Año & "\IQ-" & Año & "05.iqr"
        archivoHonIQjun = strPathIQ & "\" & Año & "\IQ-" & Año & "06.iqr"
        archivoHonIQjul = strPathIQ & "\" & Año & "\IQ-" & Año & "07.iqr"
        archivoHonIQago = strPathIQ & "\" & Año & "\IQ-" & Año & "08.iqr"
        archivoHonIQsep = strPathIQ & "\" & Año & "\IQ-" & Año & "09.iqr"
        archivoHonIQoct = strPathIQ & "\" & Año & "\IQ-" & Año & "10.iqr"
        archivoHonIQnov = strPathIQ & "\" & Año & "\IQ-" & Año & "11.iqr"
        archivoHonIQdic = strPathIQ & "\" & Año & "\IQ-" & Año & "12.iqr"

        'construye los nombres de archivo de mes de los controles de ese año
        archivoHonCONene = strPathAgenda & "\" & Año & "\Control-" & Año & "01.agd"
        archivoHonCONfeb = strPathAgenda & "\" & Año & "\Control-" & Año & "02.agd"
        archivoHonCONmar = strPathAgenda & "\" & Año & "\Control-" & Año & "03.agd"
        archivoHonCONabr = strPathAgenda & "\" & Año & "\Control-" & Año & "04.agd"
        archivoHonCONmay = strPathAgenda & "\" & Año & "\Control-" & Año & "05.agd"
        archivoHonCONjun = strPathAgenda & "\" & Año & "\Control-" & Año & "06.agd"
        archivoHonCONjul = strPathAgenda & "\" & Año & "\Control-" & Año & "07.agd"
        archivoHonCONago = strPathAgenda & "\" & Año & "\Control-" & Año & "08.agd"
        archivoHonCONsep = strPathAgenda & "\" & Año & "\Control-" & Año & "09.agd"
        archivoHonCONoct = strPathAgenda & "\" & Año & "\Control-" & Año & "10.agd"
        archivoHonCONnov = strPathAgenda & "\" & Año & "\Control-" & Año & "11.agd"
        archivoHonCONdic = strPathAgenda & "\" & Año & "\Control-" & Año & "12.agd"


    End Sub

    Private Sub botAdelantaAñoHON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdelantaAñoHon.Click
        AñoseleccionadoHonorarios += 1
        'MuestraAño
        ConstruyeNombresHonorariosVIEJA()
        VerificaHonorariosVIEJA()

    End Sub

    Private Sub botRetrocedeAñoHON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRetrocedeAñoHon.Click
        AñoseleccionadoHonorarios -= 1
        'MuestraAño
        ConstruyeNombresHonorariosVIEJA()
        VerificaHonorariosVIEJA()

    End Sub


    Private Sub VerificaHonorariosVIEJA()
        Dim Año As String
        Dim dec01iqPen, dec02iqPen, dec03iqPen, dec04iqPen, dec05iqPen, dec06iqPen, dec07iqPen, dec08iqPen, dec09iqPen, dec10iqPen, dec11iqPen, dec12iqPen As Decimal
        Dim dec01iqCan, dec02iqCan, dec03iqCan, dec04iqCan, dec05iqCan, dec06iqCan, dec07iqCan, dec08iqCan, dec09iqCan, dec10iqCan, dec11iqCan, dec12iqCan As Decimal
        Dim dec01consulta, dec02consulta, dec03consulta, dec04consulta, dec05consulta, dec06consulta, dec07consulta, dec08consulta, dec09consulta, dec10consulta, dec11consulta, dec12consulta As Decimal



        'pone los meses
        Año = AñoseleccionadoHonorarios
        labEnero.Text = "Enero de " & Año
        labFebrero.Text = "Febrero de " & Año
        labMarzo.Text = "Marzo de " & Año
        labAbril.Text = "Abril de " & Año
        labMayo.Text = "Mayo de " & Año
        labJunio.Text = "Junio de " & Año
        labJulio.Text = "Julio de " & Año
        labAgosto.Text = "Agosto de " & Año
        labSeptiembre.Text = "Septiembre de " & Año
        labOctubre.Text = "Octubre de " & Año
        labNoviembre.Text = "Noviembre de " & Año
        labDiciembre.Text = "Diciembre de " & Año

        'primero las IQ....

        'mes de enero
        ArchivoHonorariosMesIQ = archivoHonIQene
        VerificaMesesHonorariosIQ()
        dec01iqPen = decFichaHonPendientesIQ
        dec01iqCan = decFichaHonPagadosIQ
        lab01iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, ,, TriState.True)
        lab01iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, ,, TriState.True)

        'mes de febrero
        ArchivoHonorariosMesIQ = archivoHonIQfeb
        VerificaMesesHonorariosIQ()
        dec02iqPen = decFichaHonPendientesIQ
        dec02iqCan = decFichaHonPagadosIQ
        lab02iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab02iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'mes de marzo
        ArchivoHonorariosMesIQ = archivoHonIQmar
        VerificaMesesHonorariosIQ()
        dec03iqPen = decFichaHonPendientesIQ
        dec03iqCan = decFichaHonPagadosIQ
        lab03iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab03iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'mes de abril
        ArchivoHonorariosMesIQ = archivoHonIQabr
        VerificaMesesHonorariosIQ()
        dec04iqPen = decFichaHonPendientesIQ
        dec04iqCan = decFichaHonPagadosIQ
        lab04iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab04iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'mes de mayo
        ArchivoHonorariosMesIQ = archivoHonIQmay
        VerificaMesesHonorariosIQ()
        dec05iqPen = decFichaHonPendientesIQ
        dec05iqCan = decFichaHonPagadosIQ
        lab05iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab05iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'mes de junio
        ArchivoHonorariosMesIQ = archivoHonIQjun
        VerificaMesesHonorariosIQ()
        dec06iqPen = decFichaHonPendientesIQ
        dec06iqCan = decFichaHonPagadosIQ
        lab06iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab06iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'mes de julio
        ArchivoHonorariosMesIQ = archivoHonIQjul
        VerificaMesesHonorariosIQ()
        dec07iqPen = decFichaHonPendientesIQ
        dec07iqCan = decFichaHonPagadosIQ
        lab07iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab07iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'mes de agosto
        ArchivoHonorariosMesIQ = archivoHonIQago
        VerificaMesesHonorariosIQ()
        dec08iqPen = decFichaHonPendientesIQ
        dec08iqCan = decFichaHonPagadosIQ
        lab08iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab08iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'mes de septiembre
        ArchivoHonorariosMesIQ = archivoHonIQsep
        VerificaMesesHonorariosIQ()
        dec09iqPen = decFichaHonPendientesIQ
        dec09iqCan = decFichaHonPagadosIQ
        lab09iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab09iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'mes de octubre
        ArchivoHonorariosMesIQ = archivoHonIQoct
        VerificaMesesHonorariosIQ()
        dec10iqPen = decFichaHonPendientesIQ
        dec10iqCan = decFichaHonPagadosIQ
        lab10iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab10iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'mes de noviembre
        ArchivoHonorariosMesIQ = archivoHonIQnov
        VerificaMesesHonorariosIQ()
        dec11iqPen = decFichaHonPendientesIQ
        dec11iqCan = decFichaHonPagadosIQ
        lab11iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab11iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'mes de diciembre
        ArchivoHonorariosMesIQ = archivoHonIQdic
        VerificaMesesHonorariosIQ()
        dec12iqPen = decFichaHonPendientesIQ
        dec12iqCan = decFichaHonPagadosIQ
        lab12iqPen.Text = FormatCurrency(decFichaHonPendientesIQ, 2, , , TriState.True)
        lab12iqCan.Text = FormatCurrency(decFichaHonPagadosIQ, 2, , , TriState.True)

        'ahora las consultas...

        'enero
        ArchivoHonorariosMesCON = archivoHonCONene
        VerificaMesesHonorariosCON()
        dec01consulta = decFichaHonConsultas
        lab01cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'febrero
        ArchivoHonorariosMesCON = archivoHonCONfeb
        VerificaMesesHonorariosCON()
        dec02consulta = decFichaHonConsultas
        lab02cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'marzo
        ArchivoHonorariosMesCON = archivoHonCONmar
        VerificaMesesHonorariosCON()
        dec03consulta = decFichaHonConsultas
        lab03cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'abril
        ArchivoHonorariosMesCON = archivoHonCONabr
        VerificaMesesHonorariosCON()
        dec04consulta = decFichaHonConsultas
        lab04cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'mayo
        ArchivoHonorariosMesCON = archivoHonCONmay
        VerificaMesesHonorariosCON()
        dec05consulta = decFichaHonConsultas
        lab05cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'junio
        ArchivoHonorariosMesCON = archivoHonCONjun
        VerificaMesesHonorariosCON()
        dec06consulta = decFichaHonConsultas
        lab06cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'julio
        ArchivoHonorariosMesCON = archivoHonCONjul
        VerificaMesesHonorariosCON()
        dec07consulta = decFichaHonConsultas
        lab07cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'agosto
        ArchivoHonorariosMesCON = archivoHonCONago
        VerificaMesesHonorariosCON()
        dec08consulta = decFichaHonConsultas
        lab08cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'septiembre
        ArchivoHonorariosMesCON = archivoHonCONsep
        VerificaMesesHonorariosCON()
        dec09consulta = decFichaHonConsultas
        lab09cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'octubre
        ArchivoHonorariosMesCON = archivoHonCONoct
        VerificaMesesHonorariosCON()
        dec10consulta = decFichaHonConsultas
        lab10cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'noviembre
        ArchivoHonorariosMesCON = archivoHonCONnov
        VerificaMesesHonorariosCON()
        dec11consulta = decFichaHonConsultas
        lab11cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'diciembre
        ArchivoHonorariosMesCON = archivoHonCONdic
        VerificaMesesHonorariosCON()
        dec12consulta = decFichaHonConsultas
        lab12cons.Text = FormatCurrency(decFichaHonConsultas, 2, , , TriState.True)

        'totales mensuales
        Dim dec01total, dec02total, dec03total, dec04total, dec05total, dec06total, dec07total, dec08total, dec09total, dec10total, dec11total, dec12total As Decimal

        dec01total = dec01consulta + dec01iqCan + dec01iqPen : lab01total.Text = FormatCurrency(dec01total, 2, , , TriState.True)
        dec02total = dec02consulta + dec02iqCan + dec02iqPen : lab02total.Text = FormatCurrency(dec02total, 2, , , TriState.True)
        dec03total = dec03consulta + dec03iqCan + dec03iqPen : lab03total.Text = FormatCurrency(dec03total, 2, , , TriState.True)
        dec04total = dec04consulta + dec04iqCan + dec04iqPen : lab04total.Text = FormatCurrency(dec04total, 2, , , TriState.True)
        dec05total = dec05consulta + dec05iqCan + dec05iqPen : lab05total.Text = FormatCurrency(dec05total, 2, , , TriState.True)
        dec06total = dec06consulta + dec06iqCan + dec06iqPen : lab06total.Text = FormatCurrency(dec06total, 2, , , TriState.True)
        dec07total = dec07consulta + dec07iqCan + dec07iqPen : lab07total.Text = FormatCurrency(dec07total, 2, , , TriState.True)
        dec08total = dec08consulta + dec08iqCan + dec08iqPen : lab08total.Text = FormatCurrency(dec08total, 2, , , TriState.True)
        dec09total = dec09consulta + dec09iqCan + dec09iqPen : lab09total.Text = FormatCurrency(dec09total, 2, , , TriState.True)
        dec10total = dec10consulta + dec10iqCan + dec10iqPen : lab10total.Text = FormatCurrency(dec10total, 2, , , TriState.True)
        dec11total = dec11consulta + dec11iqCan + dec11iqPen : lab11total.Text = FormatCurrency(dec11total, 2, , , TriState.True)
        dec12total = dec12consulta + dec12iqCan + dec12iqPen : lab12total.Text = FormatCurrency(dec12total, 2, , , TriState.True)

        'totales de categorias
        Dim decTotalConsultas, decTotalPendientes, decTotalCanceladas, decTotalIQ As Decimal

        decTotalConsultas = dec01consulta + dec02consulta + dec03consulta + dec04consulta + dec05consulta + dec06consulta +
                            dec07consulta + dec08consulta + dec09consulta + dec10consulta + dec11consulta + dec12consulta
        decTotalPendientes = dec01iqPen + dec02iqPen + dec03iqPen + dec04iqPen + dec05iqPen + dec06iqPen +
                             dec07iqPen + dec08iqPen + dec09iqPen + dec10iqPen + dec11iqPen + dec12iqPen
        decTotalCanceladas = dec01iqCan + dec02iqCan + dec03iqCan + dec04iqCan + dec05iqCan + dec06iqCan +
                             dec07iqCan + dec08iqCan + dec09iqCan + dec10iqCan + dec11iqCan + dec12iqCan
        decTotalIQ = decTotalCanceladas + decTotalPendientes


        labTotalConsultas.Text = FormatCurrency(decTotalConsultas, 2, ,, TriState.True)
        labTotalConsultas2.Text = FormatCurrency(decTotalConsultas, 2, , , TriState.True)

        labTotalIQpen.Text = FormatCurrency(decTotalPendientes, 2, , , TriState.True)

        labTotalIQcan.Text = FormatCurrency(decTotalCanceladas, 2, , , TriState.True)

        labTotalIQ.Text = FormatCurrency(decTotalIQ, 2, , , TriState.True)

        'Total total
        Dim decTotalGeneral As Decimal

        decTotalGeneral = decTotalIQ + decTotalConsultas

        labTotalAño.Text = FormatCurrency(decTotalGeneral, 2, , , TriState.True)
        labTotalAño2.Text = FormatCurrency(decTotalGeneral, 2, , , TriState.True)
        'nojoda !!!!
    End Sub

    Private Sub VerificaMesesHonorariosIQ()
        '000000000000000000000000000000000000
        'variables de verificacion de meses IQ
        Dim decHonorariosPendientesMes As Decimal
        Dim decHonorariosPagadosMes As Decimal

        'inicializa las variables dependientes
        decFichaHonPendientesIQ = 0
        decFichaHonPagadosIQ = 0
        'ahora revisa si hay un archivo de IQs de ese mes
        If File.Exists(ArchivoHonorariosMesIQ) = True Then
            'existe un archivo de IQs de este Mes, lo lee
            FS = New FileStream(ArchivoHonorariosMesIQ, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'resetea los arrays dependientes
            C = BR.PeekChar
            While FS.Position < FS.Length
                IQ = Nothing
                ' Read fields and populate structure
                IQ.a01Fecha = BR.ReadString
                IQ.a02NombrePaciente = BR.ReadString
                IQ.a03EdadPaciente = BR.ReadString
                IQ.a04TipoIntervencion = BR.ReadString
                IQ.a05RolEnLaIntervencion = BR.ReadString
                IQ.a06Medico01 = BR.ReadString
                IQ.a07RolMedico01 = BR.ReadString
                IQ.a08Medico02 = BR.ReadString
                IQ.a09RolMedico02 = BR.ReadString
                IQ.a10Lugar = BR.ReadString
                IQ.a11FormaDePago = BR.ReadString
                IQ.a12PagoEfectuado = BR.ReadString
                IQ.a13HonorariosEstimados = BR.ReadString
                IQ.a14HonorariosNetosPagados = BR.ReadString
                IQ.a15Notas = BR.ReadString
                IQ.a16FechaDeNacimiento = BR.ReadString
                IQ.a17Cedula = BR.ReadString
                IQ.b03OtrosC = BR.ReadString
                IQ.b04OtrosD = BR.ReadString
                IQ.b05OtrosE = BR.ReadString
                'primero anota los datos sin orden pero todos en la array de IQ Mes
                'pero primero formatea la fecha como la van a buscar despues...

                'calcula honorarios de esta IQ
                If IsNumeric(IQ.a13HonorariosEstimados) Then
                    decHonorariosPendientesMes = CType(IQ.a13HonorariosEstimados, Decimal)
                Else
                    decHonorariosPendientesMes = 0
                End If
                If IsNumeric(IQ.a14HonorariosNetosPagados) Then
                    decHonorariosPagadosMes = CType(IQ.a14HonorariosNetosPagados, Decimal)
                Else
                    decHonorariosPagadosMes = 0
                End If
                decFichaHonPendientesIQ += decHonorariosPendientesMes
                decFichaHonPagadosIQ += decHonorariosPagadosMes

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
        Else
            'muestra los honorarios del Mes
            decFichaHonPendientesIQ = 0
            decFichaHonPagadosIQ = 0
        End If
    End Sub

    Private Sub VerificaMesesHonorariosCON()
        '000000000000000000000000000000000000
        'verificacion de meses
        Dim decHonorarios As Decimal


        'inicializa las variables dependientes
        decFichaHonConsultas = 0

        'ahora revisa si hay un archivo de control de ese dia
        If File.Exists(ArchivoHonorariosMesCON) = True Then
            'existe un archivo de control de este mes, lo lee
            FS = New FileStream(ArchivoHonorariosMesCON, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                CDMA = Nothing
                ' Read fields and populate structure
                CDMA.a01NumeroHistoria = BR.ReadString
                CDMA.a02Nombre = BR.ReadString
                CDMA.a03Cedula = BR.ReadString
                CDMA.a04Clinica = BR.ReadString
                CDMA.a05NotaseIDx = BR.ReadString
                CDMA.a06Tratamiento = BR.ReadString
                CDMA.a07Pendiente = BR.ReadString
                CDMA.a08ProximaConsulta = BR.ReadString
                CDMA.a09Honorarios = BR.ReadString
                CDMA.a10FechaConsulta = BR.ReadString
                CDMA.a11FacturaAsociada = BR.ReadString
                CDMA.a16Referencia = BR.ReadString
                CDMA.a15Banco = BR.ReadString
                CDMA.a14FormaDePago = BR.ReadString
                CDMA.a13FechaDePago = BR.ReadString
                CDMA.a12Pagador = BR.ReadString

                'calcula honorarios de esta consulta
                If IsNumeric(CDMA.a09Honorarios) Then
                    decHonorarios = CType(CDMA.a09Honorarios, Decimal)
                Else
                    decHonorarios = 0
                End If
                decFichaHonConsultas += decHonorarios

                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While
            BR.Close()
            FS.Close()
        Else
            decFichaHonConsultas = 0
        End If
    End Sub

#End Region


#Region "00000000000000000000000000000000 ficha de Resumen de Honorarios 000000000000000000000000000000000 "

    Private Sub ConstruyeNombresHONORARIOS()
        Dim strAño As String
        'primero muestra que año esta seleccionado
        labHonorariosAñoSeleccionado.Text = intPagosAñoSeleccionado.ToString
        strAño = intPagosAñoSeleccionado

        'construye los nombres de archivo de mes de IQ ficha Pagos
        strPagosArchivo01IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "01.iqr"
        strPagosArchivo02IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "02.iqr"
        strPagosArchivo03IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "03.iqr"
        strPagosArchivo04IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "04.iqr"
        strPagosArchivo05IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "05.iqr"
        strPagosArchivo06IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "06.iqr"
        strPagosArchivo07IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "07.iqr"
        strPagosArchivo08IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "08.iqr"
        strPagosArchivo09IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "09.iqr"
        strPagosArchivo10IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "10.iqr"
        strPagosArchivo11IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "11.iqr"
        strPagosArchivo12IQ = strPagosPathIQ & "\" & strAño & "\IQ-" & strAño & "12.iqr"

        'construye los nombres de archivo de mes de Pagos ficha Pagos
        strPagosArchivo01PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "01.dat"
        strPagosArchivo02PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "02.dat"
        strPagosArchivo03PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "03.dat"
        strPagosArchivo04PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "04.dat"
        strPagosArchivo05PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "05.dat"
        strPagosArchivo06PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "06.dat"
        strPagosArchivo07PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "07.dat"
        strPagosArchivo08PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "08.dat"
        strPagosArchivo09PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "09.dat"
        strPagosArchivo10PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "10.dat"
        strPagosArchivo11PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "11.dat"
        strPagosArchivo12PAGO = strPagosPathPAGO & "\" & strAño & "\Pagos-" & strAño & "12.dat"

        'construye los nombres de archivo de mes de los controles ficha Pagos
        strPagosArchivo01CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "01.agd"
        strPagosArchivo02CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "02.agd"
        strPagosArchivo03CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "03.agd"
        strPagosArchivo04CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "04.agd"
        strPagosArchivo05CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "05.agd"
        strPagosArchivo06CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "06.agd"
        strPagosArchivo07CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "07.agd"
        strPagosArchivo08CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "08.agd"
        strPagosArchivo09CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "09.agd"
        strPagosArchivo10CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "10.agd"
        strPagosArchivo11CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "11.agd"
        strPagosArchivo12CON = strPagosPathAGENDA & "\" & strAño & "\Control-" & strAño & "12.agd"



    End Sub
    Private Sub botHonorariosRetrocedeAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botHonorariosRetrocedeAño.Click
        intPagosAñoSeleccionado -= 1
        'MuestraAño
        ConstruyeNombresHONORARIOS()
        VerificaPagos()
    End Sub
    Private Sub botHonorariosAdelantaAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botHonorariosAdelantaAño.Click
        intPagosAñoSeleccionado += 1
        'MuestraAño
        ConstruyeNombresHONORARIOS()
        VerificaPagos()
    End Sub
    Private Sub radPagos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radHonorariosGenerados.CheckedChanged, radHonorariosFacturados.CheckedChanged, radHonorariosTotales.CheckedChanged

        VerificaPagos()

    End Sub

    Private Sub VerificaPagos()
        If radHonorariosFacturados.Checked = True Then
            'genera pagos facturados al islr
            VerificaPagosISLR()
        ElseIf radHonorariosGenerados.Checked = True Then
            'genera pagos generados 
            VerificaPagosGenerados()
        ElseIf radHonorariosTotales.Checked = True Then
            'genera pagos totales
            VerificaPagosTotales()
        End If
    End Sub

    Private Sub VerificaPagosGenerados()

        Dim strLinea As String

        Dim decPagosIQPendiente01, decPagosIQPendiente02, decPagosIQPendiente03 As Decimal
        Dim decPagosIQPendiente04, decPagosIQPendiente05, decPagosIQPendiente06 As Decimal
        Dim decPagosIQPendiente07, decPagosIQPendiente08, decPagosIQPendiente09 As Decimal
        Dim decPagosIQPendiente10, decPagosIQPendiente11, decPagosIQPendiente12 As Decimal

        Dim decPagosIQPagados01, decPagosIQPagados02, decPagosIQPagados03 As Decimal
        Dim decPagosIQPagados04, decPagosIQPagados05, decPagosIQPagados06 As Decimal
        Dim decPagosIQPagados07, decPagosIQPagados08, decPagosIQPagados09 As Decimal
        Dim decPagosIQPagados10, decPagosIQPagados11, decPagosIQPagados12 As Decimal

        Dim decPagosIQTotal01, decPagosIQTotal02, decPagosIQTotal03 As Decimal
        Dim decPagosIQTotal04, decPagosIQTotal05, decPagosIQTotal06 As Decimal
        Dim decPagosIQTotal07, decPagosIQTotal08, decPagosIQTotal09 As Decimal
        Dim decPagosIQTotal10, decPagosIQTotal11, decPagosIQTotal12 As Decimal

        Dim decPagosConsultas01, decPagosConsultas02, decPagosConsultas03 As Decimal
        Dim decPagosConsultas04, decPagosConsultas05, decPagosConsultas06 As Decimal
        Dim decPagosConsultas07, decPagosConsultas08, decPagosConsultas09 As Decimal
        Dim decPagosConsultas10, decPagosConsultas11, decPagosConsultas12 As Decimal

        Dim decPagosGenerados01, decPagosGenerados02, decPagosGenerados03 As Decimal
        Dim decPagosGenerados04, decPagosGenerados05, decPagosGenerados06 As Decimal
        Dim decPagosGenerados07, decPagosGenerados08, decPagosGenerados09 As Decimal
        Dim decPagosGenerados10, decPagosGenerados11, decPagosGenerados12 As Decimal

        Dim decPagosConsultasAño, decPagosIQPendienteAño, decPagosIQPagadosAño, decPagosIQTotalAño, decPagosGeneradosAño As Decimal


        'emcabezado
        strLinea = "                HONORARIOS PROFESIONALES GENERADOS EN EL AÑO " & intPagosAñoSeleccionado.ToString & vbCrLf & vbCrLf
        txtHonorariosDisplay.Text = strLinea

        strLinea = " MES            CONSULTAS + INTERVENCIONES = TOTAL GENERADO      PENDIENTE x IQ"
        txtHonorariosDisplay.Text += strLinea & vbCrLf
        txtHonorariosDisplay.Text += "-".PadRight(80, "-"c) & vbCrLf

        'mes 01 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo01IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente01 = decPagosIQPendienteMES
        decPagosIQPagados01 = decPagosIQPagadosMES
        decPagosIQTotal01 = decPagosIQTotalMES
        'mes 01 Consultas
        strPagosArchivoMesCON = strPagosArchivo01CON
        VerificaMesesPagosCON()
        decPagosConsultas01 = decPagosConsultasMES
        'mes 01 Total Generado
        decPagosGenerados01 = decPagosIQTotal01 + decPagosConsultas01
        'ensamble de la linea
        strLinea = "01 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas01, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal01, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados01, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente01, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 02 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo02IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente02 = decPagosIQPendienteMES
        decPagosIQPagados02 = decPagosIQPagadosMES
        decPagosIQTotal02 = decPagosIQTotalMES
        'mes 02 Consultas
        strPagosArchivoMesCON = strPagosArchivo02CON
        VerificaMesesPagosCON()
        decPagosConsultas02 = decPagosConsultasMES
        'mes 02 Total Generado
        decPagosGenerados02 = decPagosIQTotal02 + decPagosConsultas02
        'ensamble de la linea
        strLinea = "02 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas02, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal02, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados02, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente02, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 03 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo03IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente03 = decPagosIQPendienteMES
        decPagosIQPagados03 = decPagosIQPagadosMES
        decPagosIQTotal03 = decPagosIQTotalMES
        'mes 03 Consultas
        strPagosArchivoMesCON = strPagosArchivo03CON
        VerificaMesesPagosCON()
        decPagosConsultas03 = decPagosConsultasMES
        'mes 03 Total Generado
        decPagosGenerados03 = decPagosIQTotal03 + decPagosConsultas03
        'ensamble de la linea
        strLinea = "03 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas03, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal03, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados03, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente03, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 04 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo04IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente04 = decPagosIQPendienteMES
        decPagosIQPagados04 = decPagosIQPagadosMES
        decPagosIQTotal04 = decPagosIQTotalMES
        'mes 04 Consultas
        strPagosArchivoMesCON = strPagosArchivo04CON
        VerificaMesesPagosCON()
        decPagosConsultas04 = decPagosConsultasMES
        'mes 04 Total Generado
        decPagosGenerados04 = decPagosIQTotal04 + decPagosConsultas04
        'ensamble de la linea
        strLinea = "04 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas04, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal04, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados04, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente04, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 05 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo05IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente05 = decPagosIQPendienteMES
        decPagosIQPagados05 = decPagosIQPagadosMES
        decPagosIQTotal05 = decPagosIQTotalMES
        'mes 05 Consultas
        strPagosArchivoMesCON = strPagosArchivo05CON
        VerificaMesesPagosCON()
        decPagosConsultas05 = decPagosConsultasMES
        'mes 05 Total Generado
        decPagosGenerados05 = decPagosIQTotal05 + decPagosConsultas05
        'ensamble de la linea
        strLinea = "05 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas05, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal05, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados05, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente05, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 06 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo06IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente06 = decPagosIQPendienteMES
        decPagosIQPagados06 = decPagosIQPagadosMES
        decPagosIQTotal06 = decPagosIQTotalMES
        'mes 06 Consultas
        strPagosArchivoMesCON = strPagosArchivo06CON
        VerificaMesesPagosCON()
        decPagosConsultas06 = decPagosConsultasMES
        'mes 06 Total Generado
        decPagosGenerados06 = decPagosIQTotal06 + decPagosConsultas06
        'ensamble de la linea
        strLinea = "06 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas06, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal06, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados06, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente06, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 07 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo07IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente07 = decPagosIQPendienteMES
        decPagosIQPagados07 = decPagosIQPagadosMES
        decPagosIQTotal07 = decPagosIQTotalMES
        'mes 07 Consultas
        strPagosArchivoMesCON = strPagosArchivo07CON
        VerificaMesesPagosCON()
        decPagosConsultas07 = decPagosConsultasMES
        'mes 07 Total Generado
        decPagosGenerados07 = decPagosIQTotal07 + decPagosConsultas07
        'ensamble de la linea
        strLinea = "07 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas07, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal07, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados07, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente07, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 08 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo08IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente08 = decPagosIQPendienteMES
        decPagosIQPagados08 = decPagosIQPagadosMES
        decPagosIQTotal08 = decPagosIQTotalMES
        'mes 08 Consultas
        strPagosArchivoMesCON = strPagosArchivo08CON
        VerificaMesesPagosCON()
        decPagosConsultas08 = decPagosConsultasMES
        'mes 08 Total Generado
        decPagosGenerados08 = decPagosIQTotal08 + decPagosConsultas08
        'ensamble de la linea
        strLinea = "08 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas08, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal08, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados08, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente08, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 09 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo09IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente09 = decPagosIQPendienteMES
        decPagosIQPagados09 = decPagosIQPagadosMES
        decPagosIQTotal09 = decPagosIQTotalMES
        'mes 09 Consultas
        strPagosArchivoMesCON = strPagosArchivo09CON
        VerificaMesesPagosCON()
        decPagosConsultas09 = decPagosConsultasMES
        'mes 09 Total Generado
        decPagosGenerados09 = decPagosIQTotal09 + decPagosConsultas09
        'ensamble de la linea
        strLinea = "09 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas09, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal09, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados09, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente09, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 10 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo10IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente10 = decPagosIQPendienteMES
        decPagosIQPagados10 = decPagosIQPagadosMES
        decPagosIQTotal10 = decPagosIQTotalMES
        'mes 10 Consultas
        strPagosArchivoMesCON = strPagosArchivo10CON
        VerificaMesesPagosCON()
        decPagosConsultas10 = decPagosConsultasMES
        'mes 10 Total Generado
        decPagosGenerados10 = decPagosIQTotal10 + decPagosConsultas10
        'ensamble de la linea
        strLinea = "10 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas10, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal10, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados10, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente10, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 11 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo11IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente11 = decPagosIQPendienteMES
        decPagosIQPagados11 = decPagosIQPagadosMES
        decPagosIQTotal11 = decPagosIQTotalMES
        'mes 11 Consultas
        strPagosArchivoMesCON = strPagosArchivo11CON
        VerificaMesesPagosCON()
        decPagosConsultas11 = decPagosConsultasMES
        'mes 11 Total Generado
        decPagosGenerados11 = decPagosIQTotal11 + decPagosConsultas11
        'ensamble de la linea
        strLinea = "11 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas11, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal11, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados11, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente11, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 12 Intervenciones
        strPagosArchivoMesIQ = strPagosArchivo12IQ
        VerificaMesesPagosIQ()
        decPagosIQPendiente12 = decPagosIQPendienteMES
        decPagosIQPagados12 = decPagosIQPagadosMES
        decPagosIQTotal12 = decPagosIQTotalMES
        'mes 12 Consultas
        strPagosArchivoMesCON = strPagosArchivo12CON
        VerificaMesesPagosCON()
        decPagosConsultas12 = decPagosConsultasMES
        'mes 12 Total Generado
        decPagosGenerados12 = decPagosIQTotal12 + decPagosConsultas12
        'ensamble de la linea
        strLinea = "12 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas12, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosIQTotal12, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGenerados12, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendiente12, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'calcula totales
        decPagosConsultasAño = decPagosConsultas01 + decPagosConsultas02 + decPagosConsultas03 + decPagosConsultas04 + decPagosConsultas05 + decPagosConsultas06
        decPagosConsultasAño += decPagosConsultas07 + decPagosConsultas08 + decPagosConsultas09 + decPagosConsultas10 + decPagosConsultas11 + decPagosConsultas12

        decPagosIQPendienteAño = decPagosIQPendiente01 + decPagosIQPendiente02 + decPagosIQPendiente03 + decPagosIQPendiente04 + decPagosIQPendiente05 + decPagosIQPendiente06
        decPagosIQPendienteAño += decPagosIQPendiente07 + decPagosIQPendiente08 + decPagosIQPendiente09 + decPagosIQPendiente10 + decPagosIQPendiente11 + decPagosIQPendiente12

        decPagosIQPagadosAño = decPagosIQPagados01 + decPagosIQPagados02 + decPagosIQPagados03 + decPagosIQPagados04 + decPagosIQPagados05 + decPagosIQPagados06
        decPagosIQPagadosAño += decPagosIQPagados07 + decPagosIQPagados08 + decPagosIQPagados09 + decPagosIQPagados10 + decPagosIQPagados11 + decPagosIQPagados12

        decPagosIQTotalAño = decPagosIQTotal01 + decPagosIQTotal02 + decPagosIQTotal03 + decPagosIQTotal04 + decPagosIQTotal05 + decPagosIQTotal06
        decPagosIQTotalAño += decPagosIQTotal07 + decPagosIQTotal08 + decPagosIQTotal09 + decPagosIQTotal10 + decPagosIQTotal11 + decPagosIQTotal12

        decPagosGeneradosAño = decPagosGenerados01 + decPagosGenerados02 + decPagosGenerados03 + decPagosGenerados04 + decPagosGenerados05 + decPagosGenerados06
        decPagosGeneradosAño += decPagosGenerados07 + decPagosGenerados08 + decPagosGenerados09 + decPagosGenerados10 + decPagosGenerados11 + decPagosGenerados12


        'muestra totales
        txtHonorariosDisplay.Text += vbCrLf & "-".PadRight(80, "-"c) & vbCrLf

        'ensamble de la linea
        strLinea = "TOTAL " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultasAño, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosIQTotalAño, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosGeneradosAño, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosIQPendienteAño, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf




    End Sub
    Private Sub VerificaPagosTotales()

        Dim strLinea As String

        Dim decPagosRetenciones01, decPagosRetenciones02, decPagosRetenciones03 As Decimal
        Dim decPagosRetenciones04, decPagosRetenciones05, decPagosRetenciones06 As Decimal
        Dim decPagosRetenciones07, decPagosRetenciones08, decPagosRetenciones09 As Decimal
        Dim decPagosRetenciones10, decPagosRetenciones11, decPagosRetenciones12 As Decimal

        Dim decPagosPagoSD01, decPagosPagoSD02, decPagosPagoSD03 As Decimal
        Dim decPagosPagoSD04, decPagosPagoSD05, decPagosPagoSD06 As Decimal
        Dim decPagosPagoSD07, decPagosPagoSD08, decPagosPagoSD09 As Decimal
        Dim decPagosPagoSD10, decPagosPagoSD11, decPagosPagoSD12 As Decimal

        Dim decPagosConsultas01, decPagosConsultas02, decPagosConsultas03 As Decimal
        Dim decPagosConsultas04, decPagosConsultas05, decPagosConsultas06 As Decimal
        Dim decPagosConsultas07, decPagosConsultas08, decPagosConsultas09 As Decimal
        Dim decPagosConsultas10, decPagosConsultas11, decPagosConsultas12 As Decimal

        Dim decPagosTotales01, decPagosTotales02, decPagosTotales03 As Decimal
        Dim decPagosTotales04, decPagosTotales05, decPagosTotales06 As Decimal
        Dim decPagosTotales07, decPagosTotales08, decPagosTotales09 As Decimal
        Dim decPagosTotales10, decPagosTotales11, decPagosTotales12 As Decimal

        Dim decPagosTotalDevengado01, decPagosTotalDevengado02, decPagosTotalDevengado03 As Decimal
        Dim decPagosTotalDevengado04, decPagosTotalDevengado05, decPagosTotalDevengado06 As Decimal
        Dim decPagosTotalDevengado07, decPagosTotalDevengado08, decPagosTotalDevengado09 As Decimal
        Dim decPagosTotalDevengado10, decPagosTotalDevengado11, decPagosTotalDevengado12 As Decimal

        Dim decPagosConsultasAño, decPagosPagoSDAño, decPagosTotalesAño, decPagosTotalDevengadoAño, decPagosRetencionesAño As Decimal


        'emcabezado
        strLinea = "            HONORARIOS PROFESIONALES TOTALES COBRADOS EN EL AÑO " & intPagosAñoSeleccionado.ToString & vbCrLf & vbCrLf
        txtHonorariosDisplay.Text = strLinea

        strLinea = " MES            CONSULTAS    +   PAGOS S/D  =  Total Devengado   -   Retenciones   =  TOTAL COBRADO"
        txtHonorariosDisplay.Text += strLinea & vbCrLf
        txtHonorariosDisplay.Text += "-".PadRight(110, "-"c) & vbCrLf

        'mes 01 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo01PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD01 = decPagosPagoSDMES
        decPagosRetenciones01 = decPagosRetencionesMES
        'mes 01 Consultas
        strPagosArchivoMesCON = strPagosArchivo01CON
        VerificaMesesPagosCON()
        decPagosConsultas01 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado01 = decPagosPagoSD01 + decPagosConsultas01
        'mes 01 Total pagado
        decPagosTotales01 = decPagosPagoSD01 + decPagosConsultas01 + decPagosRetenciones01
        'ensamble de la linea
        strLinea = "01 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas01, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD01, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado01, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones01, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales01, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 02 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo02PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD02 = decPagosPagoSDMES
        decPagosRetenciones02 = decPagosRetencionesMES
        'mes 02 Consultas
        strPagosArchivoMesCON = strPagosArchivo02CON
        VerificaMesesPagosCON()
        decPagosConsultas02 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado02 = decPagosPagoSD02 + decPagosConsultas02
        'mes 02 Total pagado
        decPagosTotales02 = decPagosPagoSD02 + decPagosConsultas02 + decPagosRetenciones02
        'ensamble de la linea
        strLinea = "02 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas02, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD02, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado02, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones02, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales02, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 03 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo03PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD03 = decPagosPagoSDMES
        decPagosRetenciones03 = decPagosRetencionesMES
        'mes 03 Consultas
        strPagosArchivoMesCON = strPagosArchivo03CON
        VerificaMesesPagosCON()
        decPagosConsultas03 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado03 = decPagosPagoSD03 + decPagosConsultas03
        'mes 03 Total pagado
        decPagosTotales03 = decPagosPagoSD03 + decPagosConsultas03 + decPagosRetenciones03
        'ensamble de la linea
        strLinea = "03 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas03, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD03, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado03, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones03, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales03, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 04 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo04PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD04 = decPagosPagoSDMES
        decPagosRetenciones04 = decPagosRetencionesMES
        'mes 04 Consultas
        strPagosArchivoMesCON = strPagosArchivo04CON
        VerificaMesesPagosCON()
        decPagosConsultas04 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado04 = decPagosPagoSD04 + decPagosConsultas04
        'mes 04 Total pagado
        decPagosTotales04 = decPagosPagoSD04 + decPagosConsultas04 + decPagosRetenciones04
        'ensamble de la linea
        strLinea = "04 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas04, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD04, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado04, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones04, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales04, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 05 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo05PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD05 = decPagosPagoSDMES
        decPagosRetenciones05 = decPagosRetencionesMES
        'mes 05 Consultas
        strPagosArchivoMesCON = strPagosArchivo05CON
        VerificaMesesPagosCON()
        decPagosConsultas05 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado05 = decPagosPagoSD05 + decPagosConsultas05
        'mes 05 Total pagado
        decPagosTotales05 = decPagosPagoSD05 + decPagosConsultas05 + decPagosRetenciones05
        'ensamble de la linea
        strLinea = "05 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas05, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD05, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado05, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones05, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales05, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 06 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo06PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD06 = decPagosPagoSDMES
        decPagosRetenciones06 = decPagosRetencionesMES
        'mes 06 Consultas
        strPagosArchivoMesCON = strPagosArchivo06CON
        VerificaMesesPagosCON()
        decPagosConsultas06 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado06 = decPagosPagoSD06 + decPagosConsultas06
        'mes 06 Total pagado
        decPagosTotales06 = decPagosPagoSD06 + decPagosConsultas06 + decPagosRetenciones06
        'ensamble de la linea
        strLinea = "06 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas06, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD06, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado06, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones06, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales06, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 07 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo07PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD07 = decPagosPagoSDMES
        decPagosRetenciones07 = decPagosRetencionesMES
        'mes 07 Consultas
        strPagosArchivoMesCON = strPagosArchivo07CON
        VerificaMesesPagosCON()
        decPagosConsultas07 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado07 = decPagosPagoSD07 + decPagosConsultas07
        'mes 07 Total pagado
        decPagosTotales07 = decPagosPagoSD07 + decPagosConsultas07 + decPagosRetenciones07
        'ensamble de la linea
        strLinea = "07 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas07, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD07, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado07, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones07, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales07, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 08 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo08PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD08 = decPagosPagoSDMES
        decPagosRetenciones08 = decPagosRetencionesMES
        'mes 08 Consultas
        strPagosArchivoMesCON = strPagosArchivo08CON
        VerificaMesesPagosCON()
        decPagosConsultas08 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado08 = decPagosPagoSD08 + decPagosConsultas08
        'mes 08 Total pagado
        decPagosTotales08 = decPagosPagoSD08 + decPagosConsultas08 + decPagosRetenciones08
        'ensamble de la linea
        strLinea = "08 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas08, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD08, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado08, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones08, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales08, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 09 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo09PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD09 = decPagosPagoSDMES
        decPagosRetenciones09 = decPagosRetencionesMES
        'mes 09 Consultas
        strPagosArchivoMesCON = strPagosArchivo09CON
        VerificaMesesPagosCON()
        decPagosConsultas09 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado09 = decPagosPagoSD09 + decPagosConsultas09
        'mes 09 Total pagado
        decPagosTotales09 = decPagosPagoSD09 + decPagosConsultas09 + decPagosRetenciones09
        'ensamble de la linea
        strLinea = "09 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas09, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD09, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado09, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones09, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales09, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 10 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo10PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD10 = decPagosPagoSDMES
        decPagosRetenciones10 = decPagosRetencionesMES
        'mes 10 Consultas
        strPagosArchivoMesCON = strPagosArchivo10CON
        VerificaMesesPagosCON()
        decPagosConsultas10 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado10 = decPagosPagoSD10 + decPagosConsultas10
        'mes 10 Total pagado
        decPagosTotales10 = decPagosPagoSD10 + decPagosConsultas10 + decPagosRetenciones10
        'ensamble de la linea
        strLinea = "10 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas10, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD10, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado10, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones10, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales10, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 11 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo11PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD11 = decPagosPagoSDMES
        decPagosRetenciones11 = decPagosRetencionesMES
        'mes 11 Consultas
        strPagosArchivoMesCON = strPagosArchivo11CON
        VerificaMesesPagosCON()
        decPagosConsultas11 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado11 = decPagosPagoSD11 + decPagosConsultas11
        'mes 11 Total pagado
        decPagosTotales11 = decPagosPagoSD11 + decPagosConsultas11 + decPagosRetenciones11
        'ensamble de la linea
        strLinea = "11 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas11, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD11, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado11, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones11, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales11, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 12 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo12PAGO
        VerificaMesesPagosPAGO()
        decPagosPagoSD12 = decPagosPagoSDMES
        decPagosRetenciones12 = decPagosRetencionesMES
        'mes 12 Consultas
        strPagosArchivoMesCON = strPagosArchivo12CON
        VerificaMesesPagosCON()
        decPagosConsultas12 = decPagosConsultasMES
        'total devengado
        decPagosTotalDevengado12 = decPagosPagoSD12 + decPagosConsultas12
        'mes 12 Total pagado
        decPagosTotales12 = decPagosPagoSD12 + decPagosConsultas12 + decPagosRetenciones12
        'ensamble de la linea
        strLinea = "12 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas12, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD12, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado12, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetenciones12, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotales12, 2, , , TriState.True).PadLeft(20, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'calcula totales
        decPagosConsultasAño = decPagosConsultas01 + decPagosConsultas02 + decPagosConsultas03 + decPagosConsultas04 + decPagosConsultas05 + decPagosConsultas06
        decPagosConsultasAño += decPagosConsultas07 + decPagosConsultas08 + decPagosConsultas09 + decPagosConsultas10 + decPagosConsultas11 + decPagosConsultas12

        decPagosPagoSDAño = decPagosPagoSD01 + decPagosPagoSD02 + decPagosPagoSD03 + decPagosPagoSD04 + decPagosPagoSD05 + decPagosPagoSD06
        decPagosPagoSDAño += decPagosPagoSD07 + decPagosPagoSD08 + decPagosPagoSD09 + decPagosPagoSD10 + decPagosPagoSD11 + decPagosPagoSD12

        decPagosTotalDevengadoAño = decPagosTotalDevengado01 + decPagosTotalDevengado02 + decPagosTotalDevengado03 + decPagosTotalDevengado04 + decPagosTotalDevengado05 + decPagosTotalDevengado06
        decPagosTotalDevengadoAño += decPagosTotalDevengado07 + decPagosTotalDevengado08 + decPagosTotalDevengado09 + decPagosTotalDevengado10 + decPagosTotalDevengado11 + decPagosTotalDevengado12

        decPagosTotalesAño = decPagosTotales01 + decPagosTotales02 + decPagosTotales03 + decPagosTotales04 + decPagosTotales05 + decPagosTotales06
        decPagosTotalesAño += decPagosTotales07 + decPagosTotales08 + decPagosTotales09 + decPagosTotales10 + decPagosTotales11 + decPagosTotales12

        decPagosRetencionesAño = decPagosRetenciones01 + decPagosRetenciones02 + decPagosRetenciones03 + decPagosRetenciones04 + decPagosRetenciones05 + decPagosRetenciones06
        decPagosRetencionesAño += decPagosRetenciones07 + decPagosRetenciones08 + decPagosRetenciones09 + decPagosRetenciones10 + decPagosRetenciones11 + decPagosRetenciones12

        ''muestra totales
        txtHonorariosDisplay.Text += vbCrLf & "-".PadRight(110, "-"c) & vbCrLf

        'ensamble de la linea
        strLinea = "TOTAL " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultasAño, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosPagoSDAño, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalDevengadoAño, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosRetencionesAño, 2, , , TriState.True).PadLeft(17, " "c)
        strLinea += FormatNumber(decPagosTotalesAño, 2, , , TriState.True).PadLeft(20, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf




    End Sub
    Private Sub VerificaPagosISLR()

        Dim strLinea As String

        Dim decPagosOtrasRet01, decPagosOtrasRet02, decPagosOtrasRet03 As Decimal
        Dim decPagosOtrasRet04, decPagosOtrasRet05, decPagosOtrasRet06 As Decimal
        Dim decPagosOtrasRet07, decPagosOtrasRet08, decPagosOtrasRet09 As Decimal
        Dim decPagosOtrasRet10, decPagosOtrasRet11, decPagosOtrasRet12 As Decimal

        Dim decPagosISLR01, decPagosISLR02, decPagosISLR03 As Decimal
        Dim decPagosISLR04, decPagosISLR05, decPagosISLR06 As Decimal
        Dim decPagosISLR07, decPagosISLR08, decPagosISLR09 As Decimal
        Dim decPagosISLR10, decPagosISLR11, decPagosISLR12 As Decimal


        Dim decPagosPagoSD01, decPagosPagoSD02, decPagosPagoSD03 As Decimal
        Dim decPagosPagoSD04, decPagosPagoSD05, decPagosPagoSD06 As Decimal
        Dim decPagosPagoSD07, decPagosPagoSD08, decPagosPagoSD09 As Decimal
        Dim decPagosPagoSD10, decPagosPagoSD11, decPagosPagoSD12 As Decimal

        Dim decPagosConsultas01, decPagosConsultas02, decPagosConsultas03 As Decimal
        Dim decPagosConsultas04, decPagosConsultas05, decPagosConsultas06 As Decimal
        Dim decPagosConsultas07, decPagosConsultas08, decPagosConsultas09 As Decimal
        Dim decPagosConsultas10, decPagosConsultas11, decPagosConsultas12 As Decimal

        Dim decPagosTotales01, decPagosTotales02, decPagosTotales03 As Decimal
        Dim decPagosTotales04, decPagosTotales05, decPagosTotales06 As Decimal
        Dim decPagosTotales07, decPagosTotales08, decPagosTotales09 As Decimal
        Dim decPagosTotales10, decPagosTotales11, decPagosTotales12 As Decimal

        Dim decPagosTotalDevengado01, decPagosTotalDevengado02, decPagosTotalDevengado03 As Decimal
        Dim decPagosTotalDevengado04, decPagosTotalDevengado05, decPagosTotalDevengado06 As Decimal
        Dim decPagosTotalDevengado07, decPagosTotalDevengado08, decPagosTotalDevengado09 As Decimal
        Dim decPagosTotalDevengado10, decPagosTotalDevengado11, decPagosTotalDevengado12 As Decimal

        Dim decPagosConsultasAño, decPagosPagoSDAño, decPagosTotalesAño, decPagosTotalDevengadoAño, decPagosOtrasRetAño, decPagosISLRaño As Decimal


        'emcabezado
        strLinea = "            HONORARIOS PROFESIONALES FACTURADOS AL ISLR EN EL AÑO " & intPagosAñoSeleccionado.ToString & vbCrLf & vbCrLf
        txtHonorariosDisplay.Text = strLinea

        strLinea = " MES            CONSULTAS   +  PAGOS S/D  =  TOTAL DEVENGADO  -  RET ISLR   -  OTRAS RET  =  TOTAL COBRADO"
        txtHonorariosDisplay.Text += strLinea & vbCrLf
        txtHonorariosDisplay.Text += "-".PadRight(108, "-"c) & vbCrLf

        'mes 01 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo01PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD01 = decPagosPagoSDMES
        decPagosOtrasRet01 = decPagosOtrasRetMes
        decPagosISLR01 = decPagosISLRmes
        'mes 01 Consultas
        strPagosArchivoMesCON = strPagosArchivo01CON
        VerificaMesesPagosCONislr()
        decPagosConsultas01 = decPagosConsultasMES
        'mes 01 Total Devengado
        decPagosTotalDevengado01 = decPagosPagoSD01 + decPagosConsultas01
        'mes 01 Total pagado
        decPagosTotales01 = decPagosPagoSD01 + decPagosConsultas01 + decPagosOtrasRet01 + decPagosISLR01
        'ensamble de la linea
        strLinea = "01 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas01, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD01, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado01, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR01, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet01, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales01, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 02 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo02PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD02 = decPagosPagoSDMES
        decPagosOtrasRet02 = decPagosOtrasRetMes
        decPagosISLR02 = decPagosISLRmes
        'mes 02 Consultas
        strPagosArchivoMesCON = strPagosArchivo02CON
        VerificaMesesPagosCONislr()
        decPagosConsultas02 = decPagosConsultasMES
        'mes 02 Total Devengado
        decPagosTotalDevengado02 = decPagosPagoSD02 + decPagosConsultas02
        'mes 02 Total pagado
        decPagosTotales02 = decPagosPagoSD02 + decPagosConsultas02 + decPagosOtrasRet02 + decPagosISLR02
        'ensamble de la linea
        strLinea = "02 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas02, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD02, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado02, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR02, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet02, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales02, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 03 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo03PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD03 = decPagosPagoSDMES
        decPagosOtrasRet03 = decPagosOtrasRetMes
        decPagosISLR03 = decPagosISLRmes
        'mes 03 Consultas
        strPagosArchivoMesCON = strPagosArchivo03CON
        VerificaMesesPagosCONislr()
        decPagosConsultas03 = decPagosConsultasMES
        'mes 03 Total Devengado
        decPagosTotalDevengado03 = decPagosPagoSD03 + decPagosConsultas03
        'mes 03 Total pagado
        decPagosTotales03 = decPagosPagoSD03 + decPagosConsultas03 + decPagosOtrasRet03 + decPagosISLR03
        'ensamble de la linea
        strLinea = "03 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas03, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD03, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado03, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR03, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet03, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales03, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 04 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo04PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD04 = decPagosPagoSDMES
        decPagosOtrasRet04 = decPagosOtrasRetMes
        decPagosISLR04 = decPagosISLRmes
        'mes 04 Consultas
        strPagosArchivoMesCON = strPagosArchivo04CON
        VerificaMesesPagosCONislr()
        decPagosConsultas04 = decPagosConsultasMES
        'mes 04 Total Devengado
        decPagosTotalDevengado04 = decPagosPagoSD04 + decPagosConsultas04
        'mes 04 Total pagado
        decPagosTotales04 = decPagosPagoSD04 + decPagosConsultas04 + decPagosOtrasRet04 + decPagosISLR04
        'ensamble de la linea
        strLinea = "04 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas04, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD04, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado04, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR04, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet04, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales04, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 05 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo05PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD05 = decPagosPagoSDMES
        decPagosOtrasRet05 = decPagosOtrasRetMes
        decPagosISLR05 = decPagosISLRmes
        'mes 05 Consultas
        strPagosArchivoMesCON = strPagosArchivo05CON
        VerificaMesesPagosCONislr()
        decPagosConsultas05 = decPagosConsultasMES
        'mes 05 Total Devengado
        decPagosTotalDevengado05 = decPagosPagoSD05 + decPagosConsultas05
        'mes 05 Total pagado
        decPagosTotales05 = decPagosPagoSD05 + decPagosConsultas05 + decPagosOtrasRet05 + decPagosISLR05
        'ensamble de la linea
        strLinea = "05 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas05, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD05, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado05, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR05, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet05, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales05, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 06 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo06PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD06 = decPagosPagoSDMES
        decPagosOtrasRet06 = decPagosOtrasRetMes
        decPagosISLR06 = decPagosISLRmes
        'mes 06 Consultas
        strPagosArchivoMesCON = strPagosArchivo06CON
        VerificaMesesPagosCONislr()
        decPagosConsultas06 = decPagosConsultasMES
        'mes 06 Total Devengado
        decPagosTotalDevengado06 = decPagosPagoSD06 + decPagosConsultas06
        'mes 06 Total pagado
        decPagosTotales06 = decPagosPagoSD06 + decPagosConsultas06 + decPagosOtrasRet06 + decPagosISLR06
        'ensamble de la linea
        strLinea = "06 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas06, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD06, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado06, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR06, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet06, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales06, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 07 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo07PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD07 = decPagosPagoSDMES
        decPagosOtrasRet07 = decPagosOtrasRetMes
        decPagosISLR07 = decPagosISLRmes
        'mes 07 Consultas
        strPagosArchivoMesCON = strPagosArchivo07CON
        VerificaMesesPagosCONislr()
        decPagosConsultas07 = decPagosConsultasMES
        'mes 07 Total Devengado
        decPagosTotalDevengado07 = decPagosPagoSD07 + decPagosConsultas07
        'mes 07 Total pagado
        decPagosTotales07 = decPagosPagoSD07 + decPagosConsultas07 + decPagosOtrasRet07 + decPagosISLR07
        'ensamble de la linea
        strLinea = "07 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas07, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD07, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado07, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR07, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet07, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales07, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 08 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo08PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD08 = decPagosPagoSDMES
        decPagosOtrasRet08 = decPagosOtrasRetMes
        decPagosISLR08 = decPagosISLRmes
        'mes 08 Consultas
        strPagosArchivoMesCON = strPagosArchivo08CON
        VerificaMesesPagosCONislr()
        decPagosConsultas08 = decPagosConsultasMES
        'mes 08 Total Devengado
        decPagosTotalDevengado08 = decPagosPagoSD08 + decPagosConsultas08
        'mes 08 Total pagado
        decPagosTotales08 = decPagosPagoSD08 + decPagosConsultas08 + decPagosOtrasRet08 + decPagosISLR08
        'ensamble de la linea
        strLinea = "08 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas08, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD08, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado08, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR08, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet08, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales08, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 09 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo09PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD09 = decPagosPagoSDMES
        decPagosOtrasRet09 = decPagosOtrasRetMes
        decPagosISLR09 = decPagosISLRmes
        'mes 09 Consultas
        strPagosArchivoMesCON = strPagosArchivo09CON
        VerificaMesesPagosCONislr()
        decPagosConsultas09 = decPagosConsultasMES
        'mes 09 Total Devengado
        decPagosTotalDevengado09 = decPagosPagoSD09 + decPagosConsultas09
        'mes 09 Total pagado
        decPagosTotales09 = decPagosPagoSD09 + decPagosConsultas09 + decPagosOtrasRet09 + decPagosISLR09
        'ensamble de la linea
        strLinea = "09 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas09, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD09, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado09, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR09, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet09, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales09, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 10 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo10PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD10 = decPagosPagoSDMES
        decPagosOtrasRet10 = decPagosOtrasRetMes
        decPagosISLR10 = decPagosISLRmes
        'mes 10 Consultas
        strPagosArchivoMesCON = strPagosArchivo10CON
        VerificaMesesPagosCONislr()
        decPagosConsultas10 = decPagosConsultasMES
        'mes 10 Total Devengado
        decPagosTotalDevengado10 = decPagosPagoSD10 + decPagosConsultas10
        'mes 10 Total pagado
        decPagosTotales10 = decPagosPagoSD10 + decPagosConsultas10 + decPagosOtrasRet10 + decPagosISLR10
        'ensamble de la linea
        strLinea = "10 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas10, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD10, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado10, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR10, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet10, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales10, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 11 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo11PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD11 = decPagosPagoSDMES
        decPagosOtrasRet11 = decPagosOtrasRetMes
        decPagosISLR11 = decPagosISLRmes
        'mes 11 Consultas
        strPagosArchivoMesCON = strPagosArchivo11CON
        VerificaMesesPagosCONislr()
        decPagosConsultas11 = decPagosConsultasMES
        'mes 11 Total Devengado
        decPagosTotalDevengado11 = decPagosPagoSD11 + decPagosConsultas11
        'mes 11 Total pagado
        decPagosTotales11 = decPagosPagoSD11 + decPagosConsultas11 + decPagosOtrasRet11 + decPagosISLR11
        'ensamble de la linea
        strLinea = "11 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas11, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD11, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado11, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR11, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet11, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales11, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'mes 12 INGRESOS X IQ Y RETENCIONES
        strPagosArchivoMesPAGO = strPagosArchivo12PAGO
        VerificaMesesPagosPAGOislr()
        decPagosPagoSD12 = decPagosPagoSDMES
        decPagosOtrasRet12 = decPagosOtrasRetMes
        decPagosISLR12 = decPagosISLRmes
        'mes 12 Consultas
        strPagosArchivoMesCON = strPagosArchivo12CON
        VerificaMesesPagosCONislr()
        decPagosConsultas12 = decPagosConsultasMES
        'mes 12 Total Devengado
        decPagosTotalDevengado12 = decPagosPagoSD12 + decPagosConsultas12
        'mes 12 Total pagado
        decPagosTotales12 = decPagosPagoSD12 + decPagosConsultas12 + decPagosOtrasRet12 + decPagosISLR12
        'ensamble de la linea
        strLinea = "12 - " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultas12, 2, , , TriState.True).PadLeft(16, " "c)
        strLinea += FormatNumber(decPagosPagoSD12, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengado12, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLR12, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRet12, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotales12, 2, , , TriState.True).PadLeft(18, " "c)
        'muestra linea
        txtHonorariosDisplay.Text += strLinea & vbCrLf

        'calcula totales
        decPagosConsultasAño = decPagosConsultas01 + decPagosConsultas02 + decPagosConsultas03 + decPagosConsultas04 + decPagosConsultas05 + decPagosConsultas06
        decPagosConsultasAño += decPagosConsultas07 + decPagosConsultas08 + decPagosConsultas09 + decPagosConsultas10 + decPagosConsultas11 + decPagosConsultas12

        decPagosPagoSDAño = decPagosPagoSD01 + decPagosPagoSD02 + decPagosPagoSD03 + decPagosPagoSD04 + decPagosPagoSD05 + decPagosPagoSD06
        decPagosPagoSDAño += decPagosPagoSD07 + decPagosPagoSD08 + decPagosPagoSD09 + decPagosPagoSD10 + decPagosPagoSD11 + decPagosPagoSD12

        decPagosTotalDevengadoAño = decPagosTotalDevengado01 + decPagosTotalDevengado02 + decPagosTotalDevengado03 + decPagosTotalDevengado04 + decPagosTotalDevengado05 + decPagosTotalDevengado06
        decPagosTotalDevengadoAño += decPagosTotalDevengado07 + decPagosTotalDevengado08 + decPagosTotalDevengado09 + decPagosTotalDevengado10 + decPagosTotalDevengado11 + decPagosTotalDevengado12

        decPagosTotalesAño = decPagosTotales01 + decPagosTotales02 + decPagosTotales03 + decPagosTotales04 + decPagosTotales05 + decPagosTotales06
        decPagosTotalesAño += decPagosTotales07 + decPagosTotales08 + decPagosTotales09 + decPagosTotales10 + decPagosTotales11 + decPagosTotales12

        decPagosOtrasRetAño = decPagosOtrasRet01 + decPagosOtrasRet02 + decPagosOtrasRet03 + decPagosOtrasRet04 + decPagosOtrasRet05 + decPagosOtrasRet06
        decPagosOtrasRetAño += decPagosOtrasRet07 + decPagosOtrasRet08 + decPagosOtrasRet09 + decPagosOtrasRet10 + decPagosOtrasRet11 + decPagosOtrasRet12

        decPagosISLRaño = decPagosISLR01 + decPagosISLR02 + decPagosISLR03 + decPagosISLR04 + decPagosISLR05 + decPagosISLR06
        decPagosISLRaño += decPagosISLR07 + decPagosISLR08 + decPagosISLR09 + decPagosISLR10 + decPagosISLR11 + decPagosISLR12

        ''muestra totales
        txtHonorariosDisplay.Text += vbCrLf & "-".PadRight(108, "-"c) & vbCrLf

        'ensamble de la linea
        strLinea = "TOTAL " & intPagosAñoSeleccionado.ToString
        strLinea += FormatNumber(decPagosConsultasAño, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosPagoSDAño, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalDevengadoAño, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosISLRaño, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosOtrasRetAño, 2, , , TriState.True).PadLeft(15, " "c)
        strLinea += FormatNumber(decPagosTotalesAño, 2, , , TriState.True).PadLeft(18, " "c)
        txtHonorariosDisplay.Text += strLinea & vbCrLf

    End Sub


    Private Sub VerificaMesesPagosIQ()
        '000000000000000000000000000000000000
        'variables de verificacion de meses IQ
        Dim decPagosIQPendientePte As Decimal
        Dim decPagosIQPagadosPte As Decimal

        'inicializa las variables dependientes publicas de intercambio
        decPagosIQPendienteMES = 0
        decPagosIQPagadosMES = 0
        decPagosIQTotalMES = 0

        'ahora revisa si hay un archivo de IQs de ese mes
        If File.Exists(strPagosArchivoMesIQ) = True Then
            'existe un archivo de IQs de este Mes, lo lee
            FS = New FileStream(strPagosArchivoMesIQ, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            C = BR.PeekChar
            While FS.Position < FS.Length
                IQ = Nothing
                ' Read fields and populate structure
                IQ.a01Fecha = BR.ReadString
                IQ.a02NombrePaciente = BR.ReadString
                IQ.a03EdadPaciente = BR.ReadString
                IQ.a04TipoIntervencion = BR.ReadString
                IQ.a05RolEnLaIntervencion = BR.ReadString
                IQ.a06Medico01 = BR.ReadString
                IQ.a07RolMedico01 = BR.ReadString
                IQ.a08Medico02 = BR.ReadString
                IQ.a09RolMedico02 = BR.ReadString
                IQ.a10Lugar = BR.ReadString
                IQ.a11FormaDePago = BR.ReadString
                IQ.a12PagoEfectuado = BR.ReadString
                IQ.a13HonorariosEstimados = BR.ReadString
                IQ.a14HonorariosNetosPagados = BR.ReadString
                IQ.a15Notas = BR.ReadString
                IQ.a16FechaDeNacimiento = BR.ReadString
                IQ.a17Cedula = BR.ReadString
                IQ.b03OtrosC = BR.ReadString
                IQ.b04OtrosD = BR.ReadString
                IQ.b05OtrosE = BR.ReadString

                'calcula honorarios de esta IQ
                If IQ.a13HonorariosEstimados <> "" Then
                    decPagosIQPendientePte = CType(IQ.a13HonorariosEstimados, Decimal)
                Else
                    decPagosIQPendientePte = 0
                End If
                If IQ.a14HonorariosNetosPagados <> "" Then
                    decPagosIQPagadosPte = CType(IQ.a14HonorariosNetosPagados, Decimal)
                Else
                    decPagosIQPagadosPte = 0
                End If
                decPagosIQPendienteMES += decPagosIQPendientePte
                decPagosIQPagadosMES += decPagosIQPagadosPte

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'calcula el total
            decPagosIQTotalMES = decPagosIQPagadosMES + decPagosIQPendienteMES

            'normaliza a Bs Fuertes
            If intPagosAñoSeleccionado < 2008 Then
                'se debe dividir entre 1000
                decPagosIQTotalMES = decPagosIQTotalMES / 1000
                decPagosIQPagadosMES = decPagosIQPagadosMES / 1000
                decPagosIQPendienteMES = decPagosIQPendienteMES / 1000
            End If

        Else
            'muestra los honorarios del Mes
            decPagosIQPagadosMES = 0
            decPagosIQPendienteMES = 0
            decPagosIQTotalMES = 0
        End If
    End Sub
    Private Sub VerificaMesesPagosCON()
        '000000000000000000000000000000000000
        'verificacion de meses
        Dim decPagosConsultasPte As Decimal


        'inicializa las variables dependientes
        decPagosConsultasMES = 0


        'ahora revisa si hay un archivo de control de ese dia
        If File.Exists(strPagosArchivoMesCON) = True Then
            'existe un archivo de control de este mes, lo lee
            FS = New FileStream(strPagosArchivoMesCON, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                CDMA = Nothing
                ' Read fields and populate structure
                CDMA.a01NumeroHistoria = BR.ReadString
                CDMA.a02Nombre = BR.ReadString
                CDMA.a03Cedula = BR.ReadString
                CDMA.a04Clinica = BR.ReadString
                CDMA.a05NotaseIDx = BR.ReadString
                CDMA.a06Tratamiento = BR.ReadString
                CDMA.a07Pendiente = BR.ReadString
                CDMA.a08ProximaConsulta = BR.ReadString
                CDMA.a09Honorarios = BR.ReadString
                CDMA.a10FechaConsulta = BR.ReadString
                CDMA.a11FacturaAsociada = BR.ReadString
                CDMA.a16Referencia = BR.ReadString
                CDMA.a15Banco = BR.ReadString
                CDMA.a14FormaDePago = BR.ReadString
                CDMA.a13FechaDePago = BR.ReadString
                CDMA.a12Pagador = BR.ReadString

                'calcula honorarios de esta consulta
                If CDMA.a09Honorarios <> "" Then
                    If IsNumeric(CDMA.a09Honorarios) Then
                        decPagosConsultasPte = CType(CDMA.a09Honorarios, Decimal)
                    Else
                        MsgBox(strPagosArchivoMesCON & vbCrLf & CDMA.a01NumeroHistoria & vbCrLf & CDMA.a10FechaConsulta)
                        decPagosConsultasPte = 0
                    End If

                Else
                    decPagosConsultasPte = 0
                End If
                decPagosConsultasMES += decPagosConsultasPte

                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While
            BR.Close()
            FS.Close()

            'normaliza a Bs Fuertes
            If intPagosAñoSeleccionado < 2008 Then
                'se debe dividir entre 1000
                decPagosConsultasMES = decPagosConsultasMES / 1000
            End If

        Else
            decPagosConsultasMES = 0
        End If
    End Sub
    Private Sub VerificaMesesPagosPAGO()
        'verificacion de meses
        Dim decPagosPagoActual As Decimal
        Dim decPagosRetencionActual As Decimal


        'inicializa las variables dependientes
        decPagosPagoSDMES = 0
        decPagosRetencionesMES = 0

        'ahora revisa si hay un archivo de pagos de ese mes
        If File.Exists(strPagosArchivoMesPAGO) = True Then
            'existe un archivo de pagos de este mes, lo lee
            FS = New FileStream(strPagosArchivoMesPAGO, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                PA = Nothing
                ' Read fields and populate structure
                PA.a00strIndice = BR.ReadString
                PA.a01datFecha = BR.ReadString
                PA.a02strPagador = BR.ReadString
                PA.a03strMedioDePago = BR.ReadString
                PA.a04strBanco = BR.ReadString
                PA.a05strNumeroReferencia = BR.ReadString
                PA.a06intFacturaAsociada = BR.ReadString
                PA.a06bStrFacturero = BR.ReadString
                PA.a07decRetencionISLR = BR.ReadString
                PA.a08decRetencionADM = BR.ReadString
                PA.a09decRetencionOTROS = BR.ReadString
                PA.a10decMontoNetoPagado = BR.ReadString
                PA.a11decTotalPago = BR.ReadString
                PA.a12booIncluidoEnFacturacion = BR.ReadString
                PA.a13strNotas = BR.ReadString
                PA.a14Rif = BR.ReadString
                PA.b01 = BR.ReadString
                PA.b02 = BR.ReadString
                PA.b03 = BR.ReadString
                PA.b04 = BR.ReadString


                'El Pago sin descuento o pago total
                If PA.a11decTotalPago <> "" Then
                    decPagosPagoActual = CType(PA.a11decTotalPago, Decimal)
                Else
                    decPagosPagoActual = 0
                End If
                decPagosPagoSDMES += decPagosPagoActual

                'las retenciones
                decPagosRetencionActual = 0

                If PA.a07decRetencionISLR <> "" Then
                    decPagosRetencionActual += CType(PA.a07decRetencionISLR, Decimal)
                End If

                If PA.a08decRetencionADM <> "" Then
                    decPagosRetencionActual += CType(PA.a08decRetencionADM, Decimal)
                End If

                If PA.a09decRetencionOTROS <> "" Then
                    decPagosRetencionActual += CType(PA.a09decRetencionOTROS, Decimal)
                End If

                decPagosRetencionesMES += decPagosRetencionActual

                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While
            BR.Close()
            FS.Close()

            'normaliza a Bs Fuertes
            If intPagosAñoSeleccionado < 2008 Then
                'se debe dividir entre 1000
                decPagosPagoSDMES = decPagosPagoSDMES / 1000
                decPagosRetencionesMES = decPagosRetencionesMES / 1000
            End If

            'negativiza las retenciones
            decPagosRetencionesMES = decPagosRetencionesMES * -1

        End If

    End Sub
    Private Sub VerificaMesesPagosPAGOislr()
        'verificacion de meses
        Dim decPagosPagoActual As Decimal
        Dim decPagosOtrasRetActual As Decimal
        Dim decPagosISLRactual As Decimal


        'inicializa las variables dependientes
        decPagosPagoSDMES = 0
        decPagosOtrasRetMes = 0
        decPagosISLRmes = 0


        'ahora revisa si hay un archivo de pagos de ese mes
        If File.Exists(strPagosArchivoMesPAGO) = True Then
            'existe un archivo de pagos de este mes, lo lee
            FS = New FileStream(strPagosArchivoMesPAGO, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                PA = Nothing
                ' Read fields and populate structure
                PA.a00strIndice = BR.ReadString
                PA.a01datFecha = BR.ReadString
                PA.a02strPagador = BR.ReadString
                PA.a03strMedioDePago = BR.ReadString
                PA.a04strBanco = BR.ReadString
                PA.a05strNumeroReferencia = BR.ReadString
                PA.a06intFacturaAsociada = BR.ReadString
                PA.a06bStrFacturero = BR.ReadString
                PA.a07decRetencionISLR = BR.ReadString
                PA.a08decRetencionADM = BR.ReadString
                PA.a09decRetencionOTROS = BR.ReadString
                PA.a10decMontoNetoPagado = BR.ReadString
                PA.a11decTotalPago = BR.ReadString
                PA.a12booIncluidoEnFacturacion = BR.ReadString
                PA.a13strNotas = BR.ReadString
                PA.a14Rif = BR.ReadString
                PA.b01 = BR.ReadString
                PA.b02 = BR.ReadString
                PA.b03 = BR.ReadString
                PA.b04 = BR.ReadString


                If PA.a12booIncluidoEnFacturacion = "True" Then 'se incluyo en la facturacion del islr procede

                    'El Pago sin descuento o pago total
                    If PA.a11decTotalPago <> "" Then
                        decPagosPagoActual = CType(PA.a11decTotalPago, Decimal)
                    Else
                        decPagosPagoActual = 0
                    End If
                    decPagosPagoSDMES += decPagosPagoActual

                    'el ISLR
                    If PA.a07decRetencionISLR <> "" Then
                        decPagosISLRactual = CType(PA.a07decRetencionISLR, Decimal)
                    Else
                        decPagosISLRactual = 0
                    End If
                    decPagosISLRmes += decPagosISLRactual

                    'las otras ret
                    decPagosOtrasRetActual = 0

                    If PA.a08decRetencionADM <> "" Then
                        decPagosOtrasRetActual += CType(PA.a08decRetencionADM, Decimal)
                    End If

                    If PA.a09decRetencionOTROS <> "" Then
                        decPagosOtrasRetActual += CType(PA.a09decRetencionOTROS, Decimal)
                    End If

                    decPagosOtrasRetMes += decPagosOtrasRetActual

                End If


                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While
            BR.Close()
            FS.Close()

            'normaliza a Bs Fuertes
            If intPagosAñoSeleccionado < 2008 Then
                'se debe dividir entre 1000
                decPagosPagoSDMES = decPagosPagoSDMES / 1000
                decPagosOtrasRetMes = decPagosRetencionesMES / 1000
                decPagosISLRmes = decPagosISLRmes / 1000
            End If

            'negativiza las retenciones
            decPagosOtrasRetMes = decPagosOtrasRetMes * -1
            decPagosISLRmes = decPagosISLRmes * -1

        End If
    End Sub
    Private Sub VerificaMesesPagosCONislr()
        '000000000000000000000000000000000000
        'verificacion de meses
        Dim decPagosConsultasPte As Decimal


        'inicializa las variables dependientes
        decPagosConsultasMES = 0


        'ahora revisa si hay un archivo de control de ese dia
        If File.Exists(strPagosArchivoMesCON) = True Then
            'existe un archivo de control de este mes, lo lee
            FS = New FileStream(strPagosArchivoMesCON, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                CDMA = Nothing
                ' Read fields and populate structure
                CDMA.a01NumeroHistoria = BR.ReadString
                CDMA.a02Nombre = BR.ReadString
                CDMA.a03Cedula = BR.ReadString
                CDMA.a04Clinica = BR.ReadString
                CDMA.a05NotaseIDx = BR.ReadString
                CDMA.a06Tratamiento = BR.ReadString
                CDMA.a07Pendiente = BR.ReadString
                CDMA.a08ProximaConsulta = BR.ReadString
                CDMA.a09Honorarios = BR.ReadString
                CDMA.a10FechaConsulta = BR.ReadString
                CDMA.a11FacturaAsociada = BR.ReadString
                CDMA.a16Referencia = BR.ReadString
                CDMA.a15Banco = BR.ReadString
                CDMA.a14FormaDePago = BR.ReadString
                CDMA.a13FechaDePago = BR.ReadString
                CDMA.a12Pagador = BR.ReadString

                If CDMA.a11FacturaAsociada <> "" Then 'se asocio a una factura la procesa

                    'calcula honorarios de esta consulta
                    If CDMA.a09Honorarios <> "" Then
                        If IsNumeric(CDMA.a09Honorarios) Then
                            decPagosConsultasPte = CType(CDMA.a09Honorarios, Decimal)
                        Else
                            MsgBox(strPagosArchivoMesCON & vbCrLf & CDMA.a01NumeroHistoria & vbCrLf & CDMA.a10FechaConsulta, MsgBoxStyle.Information, "Corrige Honorarios...")
                            decPagosConsultasPte = 0
                        End If

                    Else
                        decPagosConsultasPte = 0
                    End If
                    decPagosConsultasMES += decPagosConsultasPte

                End If

                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While
            BR.Close()
            FS.Close()

            'normaliza a Bs Fuertes
            If intPagosAñoSeleccionado < 2008 Then
                'se debe dividir entre 1000
                decPagosConsultasMES = decPagosConsultasMES / 1000
            End If

        End If
    End Sub

#End Region



    'parte de la formacion de tablas resumen para el cuadro de impresion

    Private Sub botImprimeConsultasDelMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImprimeConsultasDelMes.Click
        Dim DLG As New FormVentanaImpresion()
        Dim Linea As String
        Dim Parte() As String
        Dim FechaDeAqui As Date
        Dim NumeroDeCHARSdelaHistoria As Integer

        'ordena la lista segun las fechas
        ArrayListaControlesMes.Sort()

        REnum = ArrayListaControlesMes.GetEnumerator

        Form1.TextoIntercambio = ""
        Form1.TituloVentanaDeTexto = "Lista de Controles Realizados durante el Mes de " & labMesSeleccionado.Text
        Form1.TamañoDeLetra = 7

        NumeroDeCHARSdelaHistoria = LargoDelNumeroDeHistoria

        If NumeroDeCHARSdelaHistoria < 8 Then
            NumeroDeCHARSdelaHistoria = 8 'por si es mas corto que la palabra historia
        End If




        'crea el encabezamiento
        Form1.TextoIntercambio += "Lista de Controles Realizados durante el Mes de " & labMesSeleccionado.Text & vbCrLf & vbCrLf

        Form1.TextoIntercambio += "----------|--------|" & "".PadRight(NumeroDeCHARSdelaHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf
        Form1.TextoIntercambio += "FECHA     |CEDULA  |" & "HIST0RIA".PadRight(NumeroDeCHARSdelaHistoria) & "|" & "NOMBRE".PadRight(45) & "|HONORARIOS |LUGAR DE CONSULTA" & vbCrLf
        Form1.TextoIntercambio += "----------|--------|" & "".PadRight(NumeroDeCHARSdelaHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf

        While REnum.MoveNext
            Linea = CType(REnum.Current, String)
            Parte = Split(Linea, "|")

            'acomoda la fecha
            FechaDeAqui = Parte(0)
            'acomoda nombre
            If Parte(3).Length > 45 Then
                Parte(3) = Parte(3).Substring(0, 45)
            End If
            'acomoda honorarios
            If Parte(4).Length > 11 Then
                Parte(4) = Parte(4).Substring(0, 11)
            End If
            'acomoda lugar
            If Parte(5).Length > 20 Then
                Parte(5) = Parte(5).Substring(0, 20)
            End If

            Form1.TextoIntercambio += FechaDeAqui.ToShortDateString & "|" & Parte(1) & "|" & Parte(2).PadRight(NumeroDeCHARSdelaHistoria) & "|" & Parte(3).PadRight(45) & "|" & Parte(4).PadLeft(11) & "|" & Parte(5).PadRight(20) & vbCrLf

        End While

        Form1.TextoIntercambio += "----------|--------|" & "".PadRight(NumeroDeCHARSdelaHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf

        Form1.TextoIntercambio += vbCrLf & " TOTAL DE CONSULTAS REALIZADAS EN EL PERIODO    : " & labNumeroPacientesMes.Text & vbCrLf
        Form1.TextoIntercambio += vbCrLf & " TOTAL DE HONORARIOS DEVENGADOS EN EL PERIODO   : " & labHonorariosTotalesMes.Text & vbCrLf

        'muestra la ventana
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If


    End Sub

    Private Sub ImprimeConsultasDelAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImprimeConsultasDelAño.Click
        Dim DLG As New FormVentanaImpresion()
        Dim Linea As String
        Dim Parte() As String
        Dim fechadeAqui As Date
        Dim NumeroDeCHARSdelaHistoria As Integer


        'ordena el array
        ArrayListaControlesAño.Sort()

        REnum = ArrayListaControlesAño.GetEnumerator

        Form1.TextoIntercambio = ""
        Form1.TituloVentanaDeTexto = "Lista de Controles Realizados durante el Año de " & labAñoSeleccionado.Text
        Form1.TamañoDeLetra = 7

        NumeroDeCHARSdelaHistoria = LargoDelNumeroDeHistoria

        If NumeroDeCHARSdelaHistoria < 8 Then
            NumeroDeCHARSdelaHistoria = 8 'por si es mas corto que la palabra historia
        End If



        'crea el encabezamiento
        Form1.TextoIntercambio += "Lista de Controles Realizados durante el Año de " & labAñoSeleccionado.Text & vbCrLf & vbCrLf

        Form1.TextoIntercambio += "----------|--------|" & "".PadRight(NumeroDeCHARSdelaHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf
        Form1.TextoIntercambio += "FECHA     |CEDULA  |" & "HIST0RIA".PadRight(NumeroDeCHARSdelaHistoria) & "|" & "NOMBRE".PadRight(45) & "|HONORARIOS |LUGAR DE CONSULTA" & vbCrLf
        Form1.TextoIntercambio += "----------|--------|" & "".PadRight(NumeroDeCHARSdelaHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf

        While REnum.MoveNext
            Linea = CType(REnum.Current, String)
            Parte = Split(Linea, "|")

            'acomoda la fecha
            fechadeAqui = Parte(0)

            'acomoda nombre
            If Parte(3).Length > 45 Then
                Parte(3) = Parte(3).Substring(0, 45)
            End If
            'acomoda honorarios
            If Parte(4).Length > 11 Then
                Parte(4) = Parte(4).Substring(0, 11)
            End If
            'acomoda lugar
            If Parte(5).Length > 20 Then
                Parte(5) = Parte(5).Substring(0, 20)
            End If

            Form1.TextoIntercambio += fechadeAqui.ToShortDateString & "|" & Parte(1) & "|" & Parte(2).PadRight(NumeroDeCHARSdelaHistoria) & "|" & Parte(3).PadRight(45) & "|" & Parte(4).PadLeft(11) & "|" & Parte(5).PadRight(20) & vbCrLf

        End While

        Form1.TextoIntercambio += "----------|--------|" & "".PadRight(NumeroDeCHARSdelaHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf

        Form1.TextoIntercambio += vbCrLf & " TOTAL DE CONSULTAS REALIZADAS EN EL PERIODO    : " & labNumeroPacientesAño.Text & vbCrLf
        Form1.TextoIntercambio += vbCrLf & " TOTAL DE HONORARIOS DEVENGADOS EN EL PERIODO   : " & labHonorariosTotalesAño.Text & vbCrLf


        'muestra la ventana
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub botImprimepROXIMAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botImprimeVigentes.Click, botImprimeVencidas.Click

        Dim DLG As New FormVentanaImpresion()
        Dim Linea As String
        Dim Parte() As String
        Dim NoCharsHistoria As Integer

        'hace un pequeño peek para ver el largo de los campos...
        If ArrayListaControlesVigentes.Count > 0 Then
            'hay elementos vigentes
            Linea = ArrayListaControlesVigentes(0)
            Parte = Split(Linea, "|")
            NoCharsHistoria = Parte(1).Length
            If NoCharsHistoria < 8 Then
                'ojo por si es un numero sin prefijo para que tome el ancho de la palabra "HISTORIA"
                NoCharsHistoria = 8
            End If
        Else
            'ajuro deben haber elementos vencido sino no se habria podido pulsar imprimeir
            Linea = ArrayListaControlesVencidos(0)
            Parte = Split(Linea, "|")
            NoCharsHistoria = Parte(1).Length
            If NoCharsHistoria < 8 Then
                'ojo por si es un numero sin prefijo para que tome el ancho de la palabra "HISTORIA"
                NoCharsHistoria = 8
            End If
        End If


        'PRIMERO LAS VIGENTES

        'verifica que hayan elementos

        If ArrayListaControlesVigentes.Count > 0 Then
            REnum = ArrayListaControlesVigentes.GetEnumerator

            Form1.TextoIntercambio = ""
            Form1.TituloVentanaDeTexto = "Lista de Controles Programados"
            Form1.TamañoDeLetra = 10

            'crea el encabezamiento
            Form1.TextoIntercambio += "LISTA DE CONTROLES PROGRAMADOS VIGENTES" & vbCrLf & vbCrLf

            Form1.TextoIntercambio += "----------|" & "".PadRight(NoCharsHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf
            Form1.TextoIntercambio += "FECHA     |" & "HISTORIA".PadRight(NoCharsHistoria) & "|" & "NOMBRE".PadRight(45) & "|Teléfono   |Lugar de Consulta" & vbCrLf
            Form1.TextoIntercambio += "----------|" & "".PadRight(NoCharsHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf

            While REnum.MoveNext
                Linea = CType(REnum.Current, String)
                Parte = Split(Linea, "|")

                'acomoda nombre
                If Parte(2).Length > 45 Then
                    Parte(2) = Parte(2).Substring(0, 45)
                End If
                'acomoda lugar
                If Parte(4).Length > 20 Then
                    Parte(4) = Parte(4).Substring(0, 20)
                End If

                'construye la linea tabulada
                Form1.TextoIntercambio += Parte(0) & "|" & Parte(1).PadRight(NoCharsHistoria) & "|" & Parte(2).PadRight(45) & "|" & Parte(3) & "|" & Parte(4).PadRight(20) & vbCrLf
            End While

            Form1.TextoIntercambio += "----------|" & "".PadRight(NoCharsHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf

            Form1.TextoIntercambio += vbCrLf & " TOTAL DE CONSULTAS PROGRAMADAS VIGENTES    : " & labTotalProgramadas.Text & vbCrLf & vbCrLf & vbCrLf & vbCrLf

        End If

        'LUEGO LAS VENCIDAS

        'verifica que haya al menos un elemento
        If ArrayListaControlesVencidos.Count > 0 Then

            REnum = ArrayListaControlesVencidos.GetEnumerator

            'crea el encabezamiento
            Form1.TextoIntercambio += "LISTA DE CONTROLES PROGRAMADOS VENCIDOS" & vbCrLf & vbCrLf
            Form1.TextoIntercambio += "----------|" & "".PadRight(NoCharsHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf
            Form1.TextoIntercambio += "FECHA     |" & "HISTORIA".PadRight(NoCharsHistoria) & "|" & "NOMBRE".PadRight(45) & "|Teléfono   |Lugar de Consulta" & vbCrLf
            Form1.TextoIntercambio += "----------|" & "".PadRight(NoCharsHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf

            While REnum.MoveNext
                Linea = CType(REnum.Current, String)
                Parte = Split(Linea, "|")

                'acomoda nombre
                If Parte(2).Length > 45 Then
                    Parte(2) = Parte(2).Substring(0, 45)
                End If
                'acomoda lugar
                If Parte(4).Length > 20 Then
                    Parte(4) = Parte(4).Substring(0, 20)
                End If

                'construye la linea tabulada
                Form1.TextoIntercambio += Parte(0) & "|" & Parte(1).PadRight(NoCharsHistoria) & "|" & Parte(2).PadRight(45) & "|" & Parte(3) & "|" & Parte(4) & vbCrLf
            End While

            Form1.TextoIntercambio += "----------|" & "".PadRight(NoCharsHistoria, "-") & "|" & "".PadRight(45, "-") & "|-----------|--------------------" & vbCrLf

            Form1.TextoIntercambio += vbCrLf & " TOTAL DE CONSULTAS PROGRAMADAS VENCIDAS    : " & labTotalProgramadasVencidas.Text & vbCrLf

        End If

        'muestra la ventana
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If


    End Sub

    Private Sub botImprimePacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles botImprimePacientes.Click

        Dim Filtro As String
        Dim DLG As New FormVentanaImpresion()
        Dim Linea As String
        Dim Parte() As String
        Dim NoCharsHistoria As Integer
        Dim cont As Integer = 0


        Filtro = txtFiltro.Text.ToUpper

        'pa ver si sirve
        MuestraPacientesParaImpresion()

        '******************
        REnum = ArrayListaPacientes.GetEnumerator
        Form1.TextoIntercambio = ""
        If Filtro = "" Then
            Form1.TituloVentanaDeTexto = "Listado General de Pacientes"
        Else
            Form1.TituloVentanaDeTexto = "Listado Parcial de Pacientes (filtrado por: " & Filtro & ")"
        End If

        Form1.TamañoDeLetra = 10

        'hace un pequeño peek para ver el largo de los campos...
        Linea = ArrayListaPacientes(0)
        Parte = Split(Linea, "|")
        NoCharsHistoria = Parte(0).Length

        If NoCharsHistoria < 8 Then
            NoCharsHistoria = 8 'por si es mas corto q la palabra historia
        End If

        'crea el encabezamiento
        If Filtro = "" Then
            Form1.TextoIntercambio = "LISTADO GENERAL DE PACIENTES" & vbCrLf & vbCrLf
        Else
            Form1.TextoIntercambio = "LISTADO PARCIAL DE PACIENTES (filtrado por: " & Filtro & ")" & vbCrLf & vbCrLf
        End If

        Form1.TextoIntercambio += "".PadRight(NoCharsHistoria, "-") & "|---------------------------------------------|--------|-----------|--------------------" & vbCrLf
        Form1.TextoIntercambio += "HISTORIA".PadRight(NoCharsHistoria) & "|" & "NOMBRE".PadRight(45) & "|CEDULA  |TELEFONO   |LUGAR DE CONSULTA" & vbCrLf
        Form1.TextoIntercambio += "".PadRight(NoCharsHistoria, "-") & "|---------------------------------------------|--------|-----------|--------------------" & vbCrLf

        While REnum.MoveNext
            Linea = CType(REnum.Current, String)
            Parte = Split(Linea, "|")

            'ACOMODA nombre
            If Parte(1).Length > 45 Then
                Parte(1) = Parte(1).Substring(0, 45)
            End If

            'ACOMODA lugar de consulta
            If Parte(4).Length > 20 Then
                Parte(4) = Parte(4).Substring(0, 20)
            End If

            'construye la linea tabulada
            Form1.TextoIntercambio += Parte(0).PadRight(NoCharsHistoria) & "|" & Parte(1).PadRight(45) & "|" & Parte(2).PadRight(8) & "|" & Parte(3).PadRight(11) & "|" & Parte(4).PadRight(20) & vbCrLf
            cont += 1
        End While

        Form1.TextoIntercambio += "".PadRight(NoCharsHistoria, "-") & "|---------------------------------------------|--------|-----------|--------------------" & vbCrLf


        Form1.TextoIntercambio += vbCrLf & vbCrLf & " TOTAL DE PACIENTES INCLUIDOS: " & cont & vbCrLf

        'muestra la ventana
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If


    End Sub

    Private Sub botImprimeIQmes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botImprimeIQmes.Click

        Dim DLG As New FormVentanaImpresion()
        Dim Linea As String
        Dim Parte() As String
        Dim cont As Integer = 0
        Dim FECHADEAQUI As Date

        'ordena las intervenciones
        ArrayListaIQmes.Sort()

        REnum = ArrayListaIQmes.GetEnumerator
        'inicializa texto
        Form1.TextoIntercambio = ""
        'hace el titulo de la ventana
        Form1.TituloVentanaDeTexto = "Listado de Intervenciones Quirúrgicas del mes de " & labMesSeleccionadoIQ.Text
        Form1.TamañoDeLetra = 7
        'hace el titulo del texto en el textbox
        Form1.TextoIntercambio = "LISTADO DE INTERVENCIONES QUIRURGICAS DEL MES DE " & labMesSeleccionadoIQ.Text & vbCrLf & vbCrLf
        'hace el encabezado
        Form1.TextoIntercambio += "----------|--------------------------------------|--------------------------------------|------------|--------------------|----------|---------" & vbCrLf
        Form1.TextoIntercambio += "FECHA     |" & "NOMBRE".PadRight(38) & "|" & "TIPO de IQ".PadRight(38) & "|" & "ROL en la IQ".PadRight(12) & "|" & "CLINICA".PadRight(20) & "|HONORARIOS|ESTADO   " & vbCrLf
        Form1.TextoIntercambio += "----------|--------------------------------------|--------------------------------------|------------|--------------------|----------|---------" & vbCrLf

        While REnum.MoveNext
            Linea = CType(REnum.Current, String)
            Parte = Split(Linea, "|")
            'acomoda fecha
            FECHADEAQUI = Parte(0)
            'acomoda nombre
            If Parte(1).Length > 38 Then
                Parte(1) = Parte(1).Substring(0, 38)
            End If
            'acomoda tipo de iq
            If Parte(2).Length > 38 Then
                Parte(2) = Parte(2).Substring(0, 38)
            End If
            'acomoda rol
            If Parte(3).Length > 12 Then
                Parte(3) = Parte(3).Substring(0, 12)
            End If
            'acomoda lugar
            If Parte(4).Length > 20 Then
                Parte(4) = Parte(4).Substring(0, 20)
            End If
            'acomoda honorarios
            If Parte(5).Length > 10 Then
                Parte(5) = Parte(5).Substring(0, 10)
            End If

            'construye la linea tabulada
            Form1.TextoIntercambio += FECHADEAQUI.ToShortDateString & "|" & Parte(1).PadRight(38) & "|" & Parte(2).PadRight(38) & "|" & Parte(3).PadRight(12) & "|" & Parte(4).PadRight(20) & "|" & Parte(5).PadLeft(10) & "|" & Parte(6).PadRight(9) & vbCrLf
            cont += 1
        End While

        Form1.TextoIntercambio += "----------|--------------------------------------|--------------------------------------|------------|--------------------|----------|---------" & vbCrLf


        Form1.TextoIntercambio += vbCrLf & vbCrLf & " TOTAL DE INTERVENCIONES REALIZADAS EN EL MES: " & cont & vbCrLf & vbCrLf
        Form1.TextoIntercambio += " HONORARIOS PENDIENTES DE PAGO DEL MES       : " & labHonorariosPendientesTotalesIQmes.Text.PadLeft(14) & vbCrLf
        Form1.TextoIntercambio += " HONORARIOS CANCELADOS DEL MES               : " & labHonorariosPagadosTotalesIQmes.Text.PadLeft(14) & vbCrLf
        Form1.TextoIntercambio += " HONORARIOS TOTALES POR IQ DEL MES           : " & labHonorariosTotalesIQmes.Text.PadLeft(14) & vbCrLf

        'muestra la ventana
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If


    End Sub

    Private Sub botImprimeIQAÑO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles botImprimeIQaño.Click

        Dim DLG As New FormVentanaImpresion()
        Dim Linea As String
        Dim Parte() As String
        Dim cont As Integer = 0
        Dim FECHADEAQUI As Date

        'ordena las intervenciones
        ArrayListaIQaño.Sort()

        REnum = ArrayListaIQaño.GetEnumerator
        'inicializa texto
        Form1.TextoIntercambio = ""
        'hace el titulo de la ventana
        Form1.TituloVentanaDeTexto = "Listado de Intervenciones Quirúrgicas del año " & labAñoSeleccionadoIQ.Text
        Form1.TamañoDeLetra = 7
        'hace el titulo del texto en el textbox
        Form1.TextoIntercambio = "LISTADO DE INTERVENCIONES QUIRURGICAS DEL AÑO " & labAñoSeleccionadoIQ.Text & vbCrLf & vbCrLf
        'hace el encabezado
        Form1.TextoIntercambio += "----------|--------------------------------------|--------------------------------------|------------|--------------------|----------|---------" & vbCrLf
        Form1.TextoIntercambio += "FECHA     |" & "NOMBRE".PadRight(38) & "|" & "TIPO de IQ".PadRight(38) & "|" & "ROL en la IQ".PadRight(12) & "|" & "CLINICA".PadRight(20) & "|HONORARIOS|ESTADO   " & vbCrLf
        Form1.TextoIntercambio += "----------|--------------------------------------|--------------------------------------|------------|--------------------|----------|---------" & vbCrLf

        While REnum.MoveNext
            Linea = CType(REnum.Current, String)
            Parte = Split(Linea, "|")
            'acomoda fecha
            FECHADEAQUI = Parte(0)
            'acomoda nombre
            If Parte(1).Length > 38 Then
                Parte(1) = Parte(1).Substring(0, 38)
            End If
            'acomoda tipo de iq
            If Parte(2).Length > 38 Then
                Parte(2) = Parte(2).Substring(0, 38)
            End If
            'acomoda rol
            If Parte(3).Length > 12 Then
                Parte(3) = Parte(3).Substring(0, 12)
            End If
            'acomoda lugar
            If Parte(4).Length > 20 Then
                Parte(4) = Parte(4).Substring(0, 20)
            End If
            'acomoda honorarios
            If Parte(5).Length > 10 Then
                Parte(5) = Parte(5).Substring(0, 10)
            End If

            'construye la linea tabulada
            Form1.TextoIntercambio += FECHADEAQUI.ToShortDateString & "|" & Parte(1).PadRight(38) & "|" & Parte(2).PadRight(38) & "|" & Parte(3).PadRight(12) & "|" & Parte(4).PadRight(20) & "|" & Parte(5).PadLeft(10) & "|" & Parte(6).PadRight(9) & vbCrLf
            cont += 1
        End While

        Form1.TextoIntercambio += "----------|--------------------------------------|--------------------------------------|------------|--------------------|----------|---------" & vbCrLf


        Form1.TextoIntercambio += vbCrLf & vbCrLf & " TOTAL DE INTERVENCIONES REALIZADAS EN EL AÑO: " & cont & vbCrLf & vbCrLf
        Form1.TextoIntercambio += " HONORARIOS PENDIENTES DE PAGO DEL AÑO       : " & labHonorariosPendientesTotalesIQaño.Text.PadLeft(14) & vbCrLf
        Form1.TextoIntercambio += " HONORARIOS CANCELADOS DEL AÑO               : " & labHonorariosPagadosTotalesIQaño.Text.PadLeft(14) & vbCrLf
        Form1.TextoIntercambio += " HONORARIOS TOTALES POR IQ DEL AÑO           : " & labHonorariosTotalesIQaño.Text.PadLeft(14) & vbCrLf


        'muestra la ventana
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If


    End Sub











    Private Sub botAdelantaMesIQ_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAdelantaMesIQ.MouseEnter
        botAdelantaMesIQ.Image = FlechaDerOn
    End Sub
    Private Sub botAdelantaMesIQ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAdelantaMesIQ.MouseLeave
        botAdelantaMesIQ.Image = FlechaDerOff
    End Sub
    Private Sub botretrocedeMesIQ_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRetrocedeMesIQ.MouseEnter
        botRetrocedeMesIQ.Image = FlechaIzqOn
    End Sub
    Private Sub botretrocedeMesIQ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRetrocedeMesIQ.MouseLeave
        botRetrocedeMesIQ.Image = FlechaIzqOff
    End Sub
    Private Sub botAdelantaañoIQ_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAdelantaAñoIQ.MouseEnter
        botAdelantaAñoIQ.Image = FlechaDerOn
    End Sub
    Private Sub botAdelantaañoIQ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAdelantaAñoIQ.MouseLeave
        botAdelantaAñoIQ.Image = FlechaDerOff
    End Sub
    Private Sub botretrocedeañoIQ_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRetrocedeAñoIQ.MouseEnter
        botRetrocedeAñoIQ.Image = FlechaIzqOn
    End Sub
    Private Sub botretrocedeañoIQ_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRetrocedeAñoIQ.MouseLeave
        botRetrocedeAñoIQ.Image = FlechaIzqOff
    End Sub
    Private Sub botAdelantaMes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAdelantaMes.MouseEnter
        botAdelantaMes.Image = FlechaDerOn
    End Sub
    Private Sub botAdelantaMes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAdelantaMes.MouseLeave
        botAdelantaMes.Image = FlechaDerOff
    End Sub
    Private Sub botretrocedeMes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRetrocedeMes.MouseEnter
        botRetrocedeMes.Image = FlechaIzqOn
    End Sub
    Private Sub botretrocedeMes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRetrocedeMes.MouseLeave
        botRetrocedeMes.Image = FlechaIzqOff
    End Sub
    Private Sub botAdelantaaño_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAdelantaAño.MouseEnter
        botAdelantaAño.Image = FlechaDerOn
    End Sub
    Private Sub botAdelantaaño_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAdelantaAño.MouseLeave
        botAdelantaAño.Image = FlechaDerOff
    End Sub
    Private Sub botretrocedeaño_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRetrocedeAño.MouseEnter
        botRetrocedeAño.Image = FlechaIzqOn
    End Sub
    Private Sub botretrocedeaño_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRetrocedeAño.MouseLeave
        botRetrocedeAño.Image = FlechaIzqOff
    End Sub
    Private Sub botCerrar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCerrar.MouseEnter
        botCerrar.Image = BotonOnGrande
    End Sub
    Private Sub botCerrar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCerrar.MouseLeave
        botCerrar.Image = BotonOffGrande
    End Sub
    Private Sub botAdelantaañoHON_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAdelantaAñoHon.MouseEnter
        botAdelantaAñoHon.Image = FlechaDerOn
    End Sub
    Private Sub botAdelantaañoHON_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAdelantaAñoHon.MouseLeave
        botAdelantaAñoHon.Image = FlechaDerOff
    End Sub
    Private Sub botretrocedeañoHON_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRetrocedeAñoHon.MouseEnter
        botRetrocedeAñoHon.Image = FlechaIzqOn
    End Sub
    Private Sub botretrocedeañoHON_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRetrocedeAñoHon.MouseLeave
        botRetrocedeAñoHon.Image = FlechaIzqOff
    End Sub
    Private Sub botImprimeConsultasDelMes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeConsultasDelMes.MouseEnter
        botImprimeConsultasDelMes.Image = BotonOn
    End Sub
    Private Sub botImprimeConsultasDelMes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeConsultasDelMes.MouseLeave
        botImprimeConsultasDelMes.Image = BotonOff
    End Sub
    Private Sub botImprimeConsultasDelAño_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeConsultasDelAño.MouseEnter
        botImprimeConsultasDelAño.Image = BotonOn
    End Sub
    Private Sub botImprimeConsultasDelAño_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeConsultasDelAño.MouseLeave
        botImprimeConsultasDelAño.Image = BotonOff
    End Sub
    Private Sub botImprimevigentes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeVigentes.MouseEnter
        botImprimeVigentes.Image = BotonOn
    End Sub
    Private Sub botImprimevigentes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeVigentes.MouseLeave
        botImprimeVigentes.Image = BotonOff
    End Sub
    Private Sub botImprimevencidas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeVencidas.MouseEnter
        botImprimeVencidas.Image = BotonOn
    End Sub
    Private Sub botImprimevencidas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeVencidas.MouseLeave
        botImprimeVencidas.Image = BotonOff
    End Sub
    Private Sub botImprimePacientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimePacientes.MouseEnter
        botImprimePacientes.Image = BotonOn
    End Sub
    Private Sub botImprimePacientes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimePacientes.MouseLeave
        botImprimePacientes.Image = BotonOff
    End Sub



    Private Sub botImprimeIQmes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeIQmes.MouseEnter
        botImprimeIQmes.Image = BotonOn
    End Sub
    Private Sub botImprimeIQmes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeIQmes.MouseLeave
        botImprimeIQmes.Image = BotonOff
    End Sub
    Private Sub botImprimeIQaño_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeIQaño.MouseEnter
        botImprimeIQaño.Image = BotonOn
    End Sub
    Private Sub botImprimeIQaño_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeIQaño.MouseLeave
        botImprimeIQaño.Image = BotonOff
    End Sub

   

  
    
End Class