Imports System.IO

Public Class FormAgenda
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageControles As System.Windows.Forms.TabPage
    Friend WithEvents TabPageProximos As System.Windows.Forms.TabPage
    Friend WithEvents TabPageCalendario As System.Windows.Forms.TabPage
    Friend WithEvents PanelControlDiario As System.Windows.Forms.Panel
    Friend WithEvents PanelControlMensual As System.Windows.Forms.Panel
    Friend WithEvents PanelControlAnual As System.Windows.Forms.Panel
    Friend WithEvents radControlDiario As System.Windows.Forms.RadioButton
    Friend WithEvents radControlMensual As System.Windows.Forms.RadioButton
    Friend WithEvents radControlAnual As System.Windows.Forms.RadioButton
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents LabelPacientes As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents botCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBoxConsultaSeleccionadaDia As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents labNumeroPacientesDia As System.Windows.Forms.Label
    Friend WithEvents ListBoxPacientesDia As System.Windows.Forms.ListBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents labLugarDia As System.Windows.Forms.Label
    Friend WithEvents labCedulaDia As System.Windows.Forms.Label
    Friend WithEvents labNombreDia As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesDia As System.Windows.Forms.Label
    Friend WithEvents txtPendienteDia As System.Windows.Forms.TextBox
    Friend WithEvents txtTtoDia As System.Windows.Forms.TextBox
    Friend WithEvents txtIDxDia As System.Windows.Forms.TextBox
    Friend WithEvents labHonorariosDia As System.Windows.Forms.Label
    Friend WithEvents labProximaCitaDia As System.Windows.Forms.Label
    Friend WithEvents labNumeroHistoriaDia As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents botRetrocedeMes As System.Windows.Forms.Button
    Friend WithEvents botAdelantaMes As System.Windows.Forms.Button
    Friend WithEvents labMesSeleccionado As System.Windows.Forms.Label
    Friend WithEvents ListBoxPacientesMes As System.Windows.Forms.ListBox
    Friend WithEvents labHonorariosTotalesMes As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents labNumeroPacientesMes As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtPendienteMes As System.Windows.Forms.TextBox
    Friend WithEvents txtTtoMes As System.Windows.Forms.TextBox
    Friend WithEvents txtIDxMes As System.Windows.Forms.TextBox
    Friend WithEvents labHonorariosMes As System.Windows.Forms.Label
    Friend WithEvents labProximaMes As System.Windows.Forms.Label
    Friend WithEvents labLugarMes As System.Windows.Forms.Label
    Friend WithEvents LabCedulaMes As System.Windows.Forms.Label
    Friend WithEvents labNombreMes As System.Windows.Forms.Label
    Friend WithEvents labNumeroHistoriaMes As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesAño As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ListBoxPacientesAño As System.Windows.Forms.ListBox
    Friend WithEvents labNumeroPacientesAño As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtPendienteProxima As System.Windows.Forms.TextBox
    Friend WithEvents txtTtoProxima As System.Windows.Forms.TextBox
    Friend WithEvents txtIDxProxima As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents labFechaConsultaProxima As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents labLugarProxima As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents labCedulaProxima As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents labNombreProxima As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents labNumeroHistoriaProxima As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents labTotalProgramadas As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents ListBoxProximas As System.Windows.Forms.ListBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosProxima As System.Windows.Forms.Label
    Friend WithEvents TabPagePacientes As System.Windows.Forms.TabPage
    Friend WithEvents ListBoxPacientes As System.Windows.Forms.ListBox
    Friend WithEvents listBoxConsultas As System.Windows.Forms.ListBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txtPendientePaciente As System.Windows.Forms.TextBox
    Friend WithEvents txtTtoPaciente As System.Windows.Forms.TextBox
    Friend WithEvents txtIDxPaciente As System.Windows.Forms.TextBox
    Friend WithEvents labHonorariosPaciente As System.Windows.Forms.Label
    Friend WithEvents labProximaPaciente As System.Windows.Forms.Label
    Friend WithEvents labLugarPaciente As System.Windows.Forms.Label
    Friend WithEvents labFiltro As System.Windows.Forms.Label
    Friend WithEvents labConsultas As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesPaciente As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents labNumeroConsultasPaciente As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents labFechaConsultaPaciente As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents TabPageIntervenciones As System.Windows.Forms.TabPage
    Friend WithEvents radIQaño As System.Windows.Forms.RadioButton
    Friend WithEvents radIQmes As System.Windows.Forms.RadioButton
    Friend WithEvents radIQdia As System.Windows.Forms.RadioButton
    Friend WithEvents PanelIQdia As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents ListBoxIQdia As System.Windows.Forms.ListBox
    Friend WithEvents CalendarioIQdia As System.Windows.Forms.MonthCalendar
    Friend WithEvents PanelIQmes As System.Windows.Forms.Panel
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents ListBoxIQmes As System.Windows.Forms.ListBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents botAdelantaMesIQ As System.Windows.Forms.Button
    Friend WithEvents botRetrocedeMesIQ As System.Windows.Forms.Button
    Friend WithEvents labMesSeleccionadoIQ As System.Windows.Forms.Label
    Friend WithEvents PanelIQaño As System.Windows.Forms.Panel
    Friend WithEvents ListBoxIQaño As System.Windows.Forms.ListBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents Label138 As System.Windows.Forms.Label
    Friend WithEvents Label140 As System.Windows.Forms.Label
    Friend WithEvents labIQdia As System.Windows.Forms.Label
    Friend WithEvents labFormaPagoIQdia As System.Windows.Forms.Label
    Friend WithEvents labRolMedico2IQdia As System.Windows.Forms.Label
    Friend WithEvents labRolMedico1IQdia As System.Windows.Forms.Label
    Friend WithEvents labRolIQdia As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPagadosIQdia As System.Windows.Forms.Label
    Friend WithEvents labHonorariosEstimadosIQdia As System.Windows.Forms.Label
    Friend WithEvents labLugarIQdia As System.Windows.Forms.Label
    Friend WithEvents labMedico2IQdia As System.Windows.Forms.Label
    Friend WithEvents labMedico1IQdia As System.Windows.Forms.Label
    Friend WithEvents labTipoIQdia As System.Windows.Forms.Label
    Friend WithEvents labEdadIQdia As System.Windows.Forms.Label
    Friend WithEvents labNombreIQdia As System.Windows.Forms.Label
    Friend WithEvents txtNotasIQdia As System.Windows.Forms.TextBox
    Friend WithEvents labNumeroIQmes As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesIQmes As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesIQdia As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPagadosTotalesIQdia As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPendientesTotalesIQdia As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPagadosTotalesIQmes As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPendientesTotalesIQmes As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNotasIQmes As System.Windows.Forms.TextBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents Label136 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents labFormaPagoIQmes As System.Windows.Forms.Label
    Friend WithEvents labRolMedico2IQmes As System.Windows.Forms.Label
    Friend WithEvents labRolMedico1IQmes As System.Windows.Forms.Label
    Friend WithEvents labRolIQmes As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPagadosIQmes As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPendientesIQmes As System.Windows.Forms.Label
    Friend WithEvents LabLugarIQmes As System.Windows.Forms.Label
    Friend WithEvents labMedico2IQmes As System.Windows.Forms.Label
    Friend WithEvents labMedico1IQmes As System.Windows.Forms.Label
    Friend WithEvents labTipoIQmes As System.Windows.Forms.Label
    Friend WithEvents labEdadIQmes As System.Windows.Forms.Label
    Friend WithEvents labNombreIQmes As System.Windows.Forms.Label
    Friend WithEvents botAdelantaAñoIQ As System.Windows.Forms.Button
    Friend WithEvents botRetrocedeAñoIQ As System.Windows.Forms.Button
    Friend WithEvents labAñoSeleccionadoIQ As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesIQaño As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPagadosTotalesIQaño As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPendientesTotalesIQaño As System.Windows.Forms.Label
    Friend WithEvents labNumeroIQaño As System.Windows.Forms.Label
    Friend WithEvents txtNotasIQaño As System.Windows.Forms.TextBox
    Friend WithEvents labFormaPagoIQaño As System.Windows.Forms.Label
    Friend WithEvents labRolMedico2IQaño As System.Windows.Forms.Label
    Friend WithEvents labRolMedico1IQaño As System.Windows.Forms.Label
    Friend WithEvents labRolIQaño As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPagadosIQaño As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPendientesIQaño As System.Windows.Forms.Label
    Friend WithEvents labLugarIQaño As System.Windows.Forms.Label
    Friend WithEvents labMedico2IQaño As System.Windows.Forms.Label
    Friend WithEvents labMedico1IQaño As System.Windows.Forms.Label
    Friend WithEvents labTipoIQaño As System.Windows.Forms.Label
    Friend WithEvents labEdadIQaño As System.Windows.Forms.Label
    Friend WithEvents labNombreIQaño As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents botAdelantaAño As System.Windows.Forms.Button
    Friend WithEvents botRetrocedeAño As System.Windows.Forms.Button
    Friend WithEvents labAñoSeleccionado As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPendienteAño As System.Windows.Forms.TextBox
    Friend WithEvents txtTtoAño As System.Windows.Forms.TextBox
    Friend WithEvents txtIDxAño As System.Windows.Forms.TextBox
    Friend WithEvents labHonorariosAño As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents labProximaAño As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents labLugarAño As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents labCedulaAño As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents labNombreAño As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents labNumeroHistoriaAño As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents TabPageHonorarios As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents botAdelantaAñoHon As System.Windows.Forms.Button
    Friend WithEvents botRetrocedeAñoHon As System.Windows.Forms.Button
    Friend WithEvents labAñoSeleccionadoHon As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lab01total As System.Windows.Forms.Label
    Friend WithEvents lab01cons As System.Windows.Forms.Label
    Friend WithEvents labEnero As System.Windows.Forms.Label
    Friend WithEvents labFebrero As System.Windows.Forms.Label
    Friend WithEvents lab02cons As System.Windows.Forms.Label
    Friend WithEvents lab02total As System.Windows.Forms.Label
    Friend WithEvents labMarzo As System.Windows.Forms.Label
    Friend WithEvents lab03cons As System.Windows.Forms.Label
    Friend WithEvents lab03total As System.Windows.Forms.Label
    Friend WithEvents labAbril As System.Windows.Forms.Label
    Friend WithEvents lab04cons As System.Windows.Forms.Label
    Friend WithEvents lab04total As System.Windows.Forms.Label
    Friend WithEvents labMayo As System.Windows.Forms.Label
    Friend WithEvents lab05cons As System.Windows.Forms.Label
    Friend WithEvents lab05total As System.Windows.Forms.Label
    Friend WithEvents labJunio As System.Windows.Forms.Label
    Friend WithEvents lab06cons As System.Windows.Forms.Label
    Friend WithEvents lab06total As System.Windows.Forms.Label
    Friend WithEvents labJulio As System.Windows.Forms.Label
    Friend WithEvents lab07cons As System.Windows.Forms.Label
    Friend WithEvents lab07total As System.Windows.Forms.Label
    Friend WithEvents labDiciembre As System.Windows.Forms.Label
    Friend WithEvents lab12cons As System.Windows.Forms.Label
    Friend WithEvents lab12total As System.Windows.Forms.Label
    Friend WithEvents labNoviembre As System.Windows.Forms.Label
    Friend WithEvents lab11cons As System.Windows.Forms.Label
    Friend WithEvents lab11total As System.Windows.Forms.Label
    Friend WithEvents labOctubre As System.Windows.Forms.Label
    Friend WithEvents lab10cons As System.Windows.Forms.Label
    Friend WithEvents lab10total As System.Windows.Forms.Label
    Friend WithEvents labSeptiembre As System.Windows.Forms.Label
    Friend WithEvents lab09cons As System.Windows.Forms.Label
    Friend WithEvents lab09total As System.Windows.Forms.Label
    Friend WithEvents labAgosto As System.Windows.Forms.Label
    Friend WithEvents lab08cons As System.Windows.Forms.Label
    Friend WithEvents lab08total As System.Windows.Forms.Label
    Friend WithEvents Label157 As System.Windows.Forms.Label
    Friend WithEvents labTotalConsultas As System.Windows.Forms.Label
    Friend WithEvents labTotalAño As System.Windows.Forms.Label
    Friend WithEvents lab12iqPen As System.Windows.Forms.Label
    Friend WithEvents lab11iqPen As System.Windows.Forms.Label
    Friend WithEvents lab10iqPen As System.Windows.Forms.Label
    Friend WithEvents lab09iqPen As System.Windows.Forms.Label
    Friend WithEvents lab08iqPen As System.Windows.Forms.Label
    Friend WithEvents lab07iqPen As System.Windows.Forms.Label
    Friend WithEvents lab06iqPen As System.Windows.Forms.Label
    Friend WithEvents lab05iqPen As System.Windows.Forms.Label
    Friend WithEvents lab04iqPen As System.Windows.Forms.Label
    Friend WithEvents lab03iqPen As System.Windows.Forms.Label
    Friend WithEvents lab02iqPen As System.Windows.Forms.Label
    Friend WithEvents lab01iqPen As System.Windows.Forms.Label
    Friend WithEvents lab12iqCan As System.Windows.Forms.Label
    Friend WithEvents lab11iqCan As System.Windows.Forms.Label
    Friend WithEvents lab10iqCan As System.Windows.Forms.Label
    Friend WithEvents lab09iqCan As System.Windows.Forms.Label
    Friend WithEvents lab08iqCan As System.Windows.Forms.Label
    Friend WithEvents lab07iqCan As System.Windows.Forms.Label
    Friend WithEvents lab06iqCan As System.Windows.Forms.Label
    Friend WithEvents lab05iqCan As System.Windows.Forms.Label
    Friend WithEvents lab04iqCan As System.Windows.Forms.Label
    Friend WithEvents lab03iqCan As System.Windows.Forms.Label
    Friend WithEvents lab02iqCan As System.Windows.Forms.Label
    Friend WithEvents lab01iqCan As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents labTotalIQcan As System.Windows.Forms.Label
    Friend WithEvents labTotalIQpen As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents labTotalIQ As System.Windows.Forms.Label
    Friend WithEvents labTotalConsultas2 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents labTotalAño2 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents ListBoxVencidas As System.Windows.Forms.ListBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents labTotalProgramadasVencidas As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents botImprimeConsultasDelMes As System.Windows.Forms.Button
    Friend WithEvents botImprimeConsultasDelAño As System.Windows.Forms.Button
    Friend WithEvents botImprimeVigentes As System.Windows.Forms.Button
    Friend WithEvents botImprimeVencidas As System.Windows.Forms.Button
    Friend WithEvents botImprimePacientes As System.Windows.Forms.Button
    Friend WithEvents botImprimeIQmes As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BarraProgresoAgenda As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents BarraEstadoAgenda As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents labTelefonoProxima As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAUTOaño As System.Windows.Forms.TextBox
    Friend WithEvents txtAUTOmes As System.Windows.Forms.TextBox
    Friend WithEvents txtAUTOdia As System.Windows.Forms.TextBox
    Friend WithEvents txtAUTOproxima As System.Windows.Forms.TextBox
    Friend WithEvents txtAUTOpaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents labCedulaIQaño As System.Windows.Forms.Label
    Friend WithEvents labFechaNacimientoIQaño As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents labCedulaIQmes As System.Windows.Forms.Label
    Friend WithEvents labFechaNacimientoIQmes As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents labCedulaIQdia As System.Windows.Forms.Label
    Friend WithEvents labFechaNacimientoIQdia As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents labCelVerificadoProxima As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents labRefirioAproxima As System.Windows.Forms.Label
    Friend WithEvents labReferidaPorProxima As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents txtNotasProxima As System.Windows.Forms.TextBox
    Friend WithEvents botActualizar As System.Windows.Forms.Button
    Friend WithEvents TabPageResHonorarios As System.Windows.Forms.TabPage
    Friend WithEvents botHonorariosAdelantaAño As System.Windows.Forms.Button
    Friend WithEvents botHonorariosRetrocedeAño As System.Windows.Forms.Button
    Friend WithEvents labHonorariosAñoSeleccionado As System.Windows.Forms.Label
    Friend WithEvents radHonorariosTotales As System.Windows.Forms.RadioButton
    Friend WithEvents radHonorariosFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents radHonorariosGenerados As System.Windows.Forms.RadioButton
    Friend WithEvents txtHonorariosDisplay As System.Windows.Forms.TextBox
    Friend WithEvents labFacturaDia As System.Windows.Forms.Label
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents labFacturaAño As System.Windows.Forms.Label
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents labFacturaMes As System.Windows.Forms.Label
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents txtUltimoSMSproxima As System.Windows.Forms.TextBox
    Friend WithEvents txtRefirioAproxima As System.Windows.Forms.TextBox
    Friend WithEvents TabPagePagos As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPagePagosXdia As System.Windows.Forms.TabPage
    Friend WithEvents TabPagePagosXmes As System.Windows.Forms.TabPage
    Friend WithEvents TabPagePagosXaño As System.Windows.Forms.TabPage
    Friend WithEvents labPagoDiaOtrasRet As System.Windows.Forms.Label
    Friend WithEvents Label135 As System.Windows.Forms.Label
    Friend WithEvents labPagoDiaRetAdm As System.Windows.Forms.Label
    Friend WithEvents Label133 As System.Windows.Forms.Label
    Friend WithEvents labPagoDiaRetISLR As System.Windows.Forms.Label
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents labPagoDiaPagadoNeto As System.Windows.Forms.Label
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents labPagosDia As System.Windows.Forms.Label
    Friend WithEvents ListBoxPagosDia As System.Windows.Forms.ListBox
    Friend WithEvents CalendarioPagosDia As System.Windows.Forms.MonthCalendar
    Friend WithEvents labPagoDiaTotalDevengado As System.Windows.Forms.Label
    Friend WithEvents Label137 As System.Windows.Forms.Label
    Friend WithEvents Label143 As System.Windows.Forms.Label
    Friend WithEvents Label142 As System.Windows.Forms.Label
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents chkPAGOincluyeNoFacturadosDIA As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents labPAGOdiaIncluidoSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOdiaTotalDevengadoSel As System.Windows.Forms.Label
    Friend WithEvents labPagoDiaOtrasRetSel As System.Windows.Forms.Label
    Friend WithEvents labPagoDiaRetAdmSel As System.Windows.Forms.Label
    Friend WithEvents labPagoDiaRetISLRsel As System.Windows.Forms.Label
    Friend WithEvents labPagoDiaPagadoNetoSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOdiaModoPagoSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOdiaPagadorSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOdiaFacturaSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOdiaFechaSel As System.Windows.Forms.Label
    Friend WithEvents Label153 As System.Windows.Forms.Label
    Friend WithEvents Label152 As System.Windows.Forms.Label
    Friend WithEvents Label151 As System.Windows.Forms.Label
    Friend WithEvents Label150 As System.Windows.Forms.Label
    Friend WithEvents Label149 As System.Windows.Forms.Label
    Friend WithEvents Label147 As System.Windows.Forms.Label
    Friend WithEvents Label148 As System.Windows.Forms.Label
    Friend WithEvents Label146 As System.Windows.Forms.Label
    Friend WithEvents Label145 As System.Windows.Forms.Label
    Friend WithEvents Label144 As System.Windows.Forms.Label
    Friend WithEvents txtPAGOdiaNotasSel As System.Windows.Forms.TextBox
    Friend WithEvents Label154 As System.Windows.Forms.Label
    Friend WithEvents botCONTROLESdiaEditarConsulta As System.Windows.Forms.Button
    Friend WithEvents labPAGOdiaPorcentajeDeRetencion As System.Windows.Forms.Label
    Friend WithEvents Label155 As System.Windows.Forms.Label
    Friend WithEvents labPagosMes As System.Windows.Forms.Label
    Friend WithEvents Label156 As System.Windows.Forms.Label
    Friend WithEvents Label158 As System.Windows.Forms.Label
    Friend WithEvents Label159 As System.Windows.Forms.Label
    Friend WithEvents Label160 As System.Windows.Forms.Label
    Friend WithEvents ListBoxPagosMes As System.Windows.Forms.ListBox
    Friend WithEvents botPagoMesRetrocedeMes As System.Windows.Forms.Button
    Friend WithEvents labPagoMesTotalDevengado As System.Windows.Forms.Label
    Friend WithEvents Label162 As System.Windows.Forms.Label
    Friend WithEvents labPagoMesOtrasRet As System.Windows.Forms.Label
    Friend WithEvents Label164 As System.Windows.Forms.Label
    Friend WithEvents labPagoMesRetAdm As System.Windows.Forms.Label
    Friend WithEvents Label166 As System.Windows.Forms.Label
    Friend WithEvents labPagoMesRetISLR As System.Windows.Forms.Label
    Friend WithEvents Label168 As System.Windows.Forms.Label
    Friend WithEvents labPagoMesPagadoNeto As System.Windows.Forms.Label
    Friend WithEvents Label170 As System.Windows.Forms.Label
    Friend WithEvents chkPAGOincluyeNoFacturadosMES As System.Windows.Forms.CheckBox
    Friend WithEvents botPagoMesAdelantaMes As System.Windows.Forms.Button
    Friend WithEvents labPagosMesSeleccionado As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents labPAGOMesPorcentajeDeRetencion As System.Windows.Forms.Label
    Friend WithEvents Label163 As System.Windows.Forms.Label
    Friend WithEvents Label165 As System.Windows.Forms.Label
    Friend WithEvents txtPAGOmesNotasSel As System.Windows.Forms.TextBox
    Friend WithEvents labPAGOmesIncluidoSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOmesTotalDevengadoSel As System.Windows.Forms.Label
    Friend WithEvents labPagoMesOtrasRetSel As System.Windows.Forms.Label
    Friend WithEvents labPagoMesRetAdmSel As System.Windows.Forms.Label
    Friend WithEvents labPagoMesRetISLRsel As System.Windows.Forms.Label
    Friend WithEvents labPagoMesPagadoNetoSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOmesModoPagoSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOmesPagadorSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOmesFacturaSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOmesFechaSel As System.Windows.Forms.Label
    Friend WithEvents Label179 As System.Windows.Forms.Label
    Friend WithEvents Label180 As System.Windows.Forms.Label
    Friend WithEvents Label181 As System.Windows.Forms.Label
    Friend WithEvents Label182 As System.Windows.Forms.Label
    Friend WithEvents Label183 As System.Windows.Forms.Label
    Friend WithEvents Label184 As System.Windows.Forms.Label
    Friend WithEvents Label185 As System.Windows.Forms.Label
    Friend WithEvents Label186 As System.Windows.Forms.Label
    Friend WithEvents Label187 As System.Windows.Forms.Label
    Friend WithEvents Label188 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents labPAGOAñoPorcentajeDeRetencion As System.Windows.Forms.Label
    Friend WithEvents Label167 As System.Windows.Forms.Label
    Friend WithEvents Label169 As System.Windows.Forms.Label
    Friend WithEvents txtPAGOañoNotasSel As System.Windows.Forms.TextBox
    Friend WithEvents labPAGOañoIncluidoSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOañoTotalDevengadoSel As System.Windows.Forms.Label
    Friend WithEvents labPagoAñoOtrasRetSel As System.Windows.Forms.Label
    Friend WithEvents labPagoAñoRetAdmSel As System.Windows.Forms.Label
    Friend WithEvents labPagoAñoRetISLRsel As System.Windows.Forms.Label
    Friend WithEvents labPagoAñoPagadoNetoSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOañoModoPagoSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOañoPagadorSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOañoFacturaSel As System.Windows.Forms.Label
    Friend WithEvents labPAGOañoFechaSel As System.Windows.Forms.Label
    Friend WithEvents Label191 As System.Windows.Forms.Label
    Friend WithEvents Label192 As System.Windows.Forms.Label
    Friend WithEvents Label193 As System.Windows.Forms.Label
    Friend WithEvents Label194 As System.Windows.Forms.Label
    Friend WithEvents Label195 As System.Windows.Forms.Label
    Friend WithEvents Label196 As System.Windows.Forms.Label
    Friend WithEvents Label197 As System.Windows.Forms.Label
    Friend WithEvents Label198 As System.Windows.Forms.Label
    Friend WithEvents Label199 As System.Windows.Forms.Label
    Friend WithEvents Label200 As System.Windows.Forms.Label
    Friend WithEvents labPagosAñoSeleccionado As System.Windows.Forms.Label
    Friend WithEvents botPagoAÑOAdelantaAño As System.Windows.Forms.Button
    Friend WithEvents botPagoaÑORetrocedeAño As System.Windows.Forms.Button
    Friend WithEvents labPagoAñoTotalDevengado As System.Windows.Forms.Label
    Friend WithEvents Label203 As System.Windows.Forms.Label
    Friend WithEvents labPagoAñoOtrasRet As System.Windows.Forms.Label
    Friend WithEvents Label205 As System.Windows.Forms.Label
    Friend WithEvents labPagoAñoRetAdm As System.Windows.Forms.Label
    Friend WithEvents Label207 As System.Windows.Forms.Label
    Friend WithEvents labPagoAñoRetISLR As System.Windows.Forms.Label
    Friend WithEvents Label209 As System.Windows.Forms.Label
    Friend WithEvents labPagoAñoPagadoNeto As System.Windows.Forms.Label
    Friend WithEvents Label211 As System.Windows.Forms.Label
    Friend WithEvents chkPAGOincluyeNoFacturadosAÑO As System.Windows.Forms.CheckBox
    Friend WithEvents labPagosAño As System.Windows.Forms.Label
    Friend WithEvents Label213 As System.Windows.Forms.Label
    Friend WithEvents Label214 As System.Windows.Forms.Label
    Friend WithEvents Label215 As System.Windows.Forms.Label
    Friend WithEvents Label216 As System.Windows.Forms.Label
    Friend WithEvents ListBoxPagosAño As System.Windows.Forms.ListBox
    Friend WithEvents ProgressBarAÑO As System.Windows.Forms.ProgressBar
    Friend WithEvents labPAGOdiaRif As System.Windows.Forms.Label
    Friend WithEvents Label171 As System.Windows.Forms.Label
    Friend WithEvents labPAGOmesRif As System.Windows.Forms.Label
    Friend WithEvents Label172 As System.Windows.Forms.Label
    Friend WithEvents labPAGOañoRif As System.Windows.Forms.Label
    Friend WithEvents Label174 As System.Windows.Forms.Label
    Friend WithEvents TabPageISLR As System.Windows.Forms.TabPage
    Friend WithEvents botPagoMuestraDatosDelAñoIslr As System.Windows.Forms.Button
    Friend WithEvents txtPagosExportacionDatos As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBarAñoIslr As System.Windows.Forms.ProgressBar
    Friend WithEvents labPagosAñoIslrSeleccionado As System.Windows.Forms.Label
    Friend WithEvents botPagoAdelantaAñoIslr As System.Windows.Forms.Button
    Friend WithEvents botPagoRetrocedeAñoIslr As System.Windows.Forms.Button
    Friend WithEvents botImprimeIQaño As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgenda))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageControles = New System.Windows.Forms.TabPage()
        Me.radControlAnual = New System.Windows.Forms.RadioButton()
        Me.radControlMensual = New System.Windows.Forms.RadioButton()
        Me.radControlDiario = New System.Windows.Forms.RadioButton()
        Me.PanelControlAnual = New System.Windows.Forms.Panel()
        Me.botImprimeConsultasDelAño = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.labFacturaAño = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.txtAUTOaño = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPendienteAño = New System.Windows.Forms.TextBox()
        Me.txtTtoAño = New System.Windows.Forms.TextBox()
        Me.txtIDxAño = New System.Windows.Forms.TextBox()
        Me.labHonorariosAño = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.labProximaAño = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.labLugarAño = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.labCedulaAño = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.labNombreAño = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.labNumeroHistoriaAño = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.botAdelantaAño = New System.Windows.Forms.Button()
        Me.botRetrocedeAño = New System.Windows.Forms.Button()
        Me.labAñoSeleccionado = New System.Windows.Forms.Label()
        Me.labHonorariosTotalesAño = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.labNumeroPacientesAño = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ListBoxPacientesAño = New System.Windows.Forms.ListBox()
        Me.PanelControlMensual = New System.Windows.Forms.Panel()
        Me.botImprimeConsultasDelMes = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.labFacturaMes = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtAUTOmes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPendienteMes = New System.Windows.Forms.TextBox()
        Me.txtTtoMes = New System.Windows.Forms.TextBox()
        Me.txtIDxMes = New System.Windows.Forms.TextBox()
        Me.labHonorariosMes = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.labProximaMes = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.labLugarMes = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LabCedulaMes = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.labNombreMes = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.labNumeroHistoriaMes = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.labHonorariosTotalesMes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labNumeroPacientesMes = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBoxPacientesMes = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.botAdelantaMes = New System.Windows.Forms.Button()
        Me.botRetrocedeMes = New System.Windows.Forms.Button()
        Me.labMesSeleccionado = New System.Windows.Forms.Label()
        Me.PanelControlDiario = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LabelPacientes = New System.Windows.Forms.Label()
        Me.GroupBoxConsultaSeleccionadaDia = New System.Windows.Forms.GroupBox()
        Me.botCONTROLESdiaEditarConsulta = New System.Windows.Forms.Button()
        Me.labFacturaDia = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txtAUTOdia = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPendienteDia = New System.Windows.Forms.TextBox()
        Me.txtTtoDia = New System.Windows.Forms.TextBox()
        Me.txtIDxDia = New System.Windows.Forms.TextBox()
        Me.labHonorariosDia = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.labProximaCitaDia = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.labLugarDia = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.labCedulaDia = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.labNombreDia = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labNumeroHistoriaDia = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labHonorariosTotalesDia = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labNumeroPacientesDia = New System.Windows.Forms.Label()
        Me.ListBoxPacientesDia = New System.Windows.Forms.ListBox()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.TabPageProximos = New System.Windows.Forms.TabPage()
        Me.botImprimeVencidas = New System.Windows.Forms.Button()
        Me.botImprimeVigentes = New System.Windows.Forms.Button()
        Me.labTotalProgramadasVencidas = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.ListBoxVencidas = New System.Windows.Forms.ListBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRefirioAproxima = New System.Windows.Forms.TextBox()
        Me.txtUltimoSMSproxima = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.txtNotasProxima = New System.Windows.Forms.TextBox()
        Me.labRefirioAproxima = New System.Windows.Forms.Label()
        Me.labReferidaPorProxima = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.labCelVerificadoProxima = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtAUTOproxima = New System.Windows.Forms.TextBox()
        Me.labTelefonoProxima = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.txtTtoProxima = New System.Windows.Forms.TextBox()
        Me.txtIDxProxima = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtPendienteProxima = New System.Windows.Forms.TextBox()
        Me.labHonorariosProxima = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.labFechaConsultaProxima = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.labLugarProxima = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.labCedulaProxima = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.labNombreProxima = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.labNumeroHistoriaProxima = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.labTotalProgramadas = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.ListBoxProximas = New System.Windows.Forms.ListBox()
        Me.TabPagePacientes = New System.Windows.Forms.TabPage()
        Me.botImprimePacientes = New System.Windows.Forms.Button()
        Me.labNumeroConsultasPaciente = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.labHonorariosTotalesPaciente = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtAUTOpaciente = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtPendientePaciente = New System.Windows.Forms.TextBox()
        Me.txtTtoPaciente = New System.Windows.Forms.TextBox()
        Me.txtIDxPaciente = New System.Windows.Forms.TextBox()
        Me.labHonorariosPaciente = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.labProximaPaciente = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.labLugarPaciente = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.labFechaConsultaPaciente = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.labConsultas = New System.Windows.Forms.Label()
        Me.listBoxConsultas = New System.Windows.Forms.ListBox()
        Me.ListBoxPacientes = New System.Windows.Forms.ListBox()
        Me.labFiltro = New System.Windows.Forms.Label()
        Me.TabPageIntervenciones = New System.Windows.Forms.TabPage()
        Me.PanelIQaño = New System.Windows.Forms.Panel()
        Me.botImprimeIQaño = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.labCedulaIQaño = New System.Windows.Forms.Label()
        Me.labFechaNacimientoIQaño = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.txtNotasIQaño = New System.Windows.Forms.TextBox()
        Me.labFormaPagoIQaño = New System.Windows.Forms.Label()
        Me.labRolMedico2IQaño = New System.Windows.Forms.Label()
        Me.labRolMedico1IQaño = New System.Windows.Forms.Label()
        Me.labRolIQaño = New System.Windows.Forms.Label()
        Me.labHonorariosPagadosIQaño = New System.Windows.Forms.Label()
        Me.labHonorariosPendientesIQaño = New System.Windows.Forms.Label()
        Me.labLugarIQaño = New System.Windows.Forms.Label()
        Me.labMedico2IQaño = New System.Windows.Forms.Label()
        Me.labMedico1IQaño = New System.Windows.Forms.Label()
        Me.labTipoIQaño = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.labEdadIQaño = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.labNombreIQaño = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.labHonorariosTotalesIQaño = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.labHonorariosPagadosTotalesIQaño = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.labHonorariosPendientesTotalesIQaño = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.labNumeroIQaño = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.botAdelantaAñoIQ = New System.Windows.Forms.Button()
        Me.botRetrocedeAñoIQ = New System.Windows.Forms.Button()
        Me.labAñoSeleccionadoIQ = New System.Windows.Forms.Label()
        Me.ListBoxIQaño = New System.Windows.Forms.ListBox()
        Me.PanelIQmes = New System.Windows.Forms.Panel()
        Me.botImprimeIQmes = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.labCedulaIQmes = New System.Windows.Forms.Label()
        Me.labFechaNacimientoIQmes = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.txtNotasIQmes = New System.Windows.Forms.TextBox()
        Me.labFormaPagoIQmes = New System.Windows.Forms.Label()
        Me.labRolMedico2IQmes = New System.Windows.Forms.Label()
        Me.labRolMedico1IQmes = New System.Windows.Forms.Label()
        Me.labRolIQmes = New System.Windows.Forms.Label()
        Me.labHonorariosPagadosIQmes = New System.Windows.Forms.Label()
        Me.labHonorariosPendientesIQmes = New System.Windows.Forms.Label()
        Me.LabLugarIQmes = New System.Windows.Forms.Label()
        Me.labMedico2IQmes = New System.Windows.Forms.Label()
        Me.labMedico1IQmes = New System.Windows.Forms.Label()
        Me.labTipoIQmes = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.labEdadIQmes = New System.Windows.Forms.Label()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.labNombreIQmes = New System.Windows.Forms.Label()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.labHonorariosTotalesIQmes = New System.Windows.Forms.Label()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.labHonorariosPagadosTotalesIQmes = New System.Windows.Forms.Label()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.labHonorariosPendientesTotalesIQmes = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.labNumeroIQmes = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.ListBoxIQmes = New System.Windows.Forms.ListBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.botAdelantaMesIQ = New System.Windows.Forms.Button()
        Me.botRetrocedeMesIQ = New System.Windows.Forms.Button()
        Me.labMesSeleccionadoIQ = New System.Windows.Forms.Label()
        Me.radIQaño = New System.Windows.Forms.RadioButton()
        Me.radIQmes = New System.Windows.Forms.RadioButton()
        Me.radIQdia = New System.Windows.Forms.RadioButton()
        Me.PanelIQdia = New System.Windows.Forms.Panel()
        Me.labHonorariosTotalesIQdia = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.labHonorariosPagadosTotalesIQdia = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.labCedulaIQdia = New System.Windows.Forms.Label()
        Me.labFechaNacimientoIQdia = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtNotasIQdia = New System.Windows.Forms.TextBox()
        Me.labFormaPagoIQdia = New System.Windows.Forms.Label()
        Me.labRolMedico2IQdia = New System.Windows.Forms.Label()
        Me.labRolMedico1IQdia = New System.Windows.Forms.Label()
        Me.labRolIQdia = New System.Windows.Forms.Label()
        Me.labHonorariosPagadosIQdia = New System.Windows.Forms.Label()
        Me.labHonorariosEstimadosIQdia = New System.Windows.Forms.Label()
        Me.labLugarIQdia = New System.Windows.Forms.Label()
        Me.labMedico2IQdia = New System.Windows.Forms.Label()
        Me.labMedico1IQdia = New System.Windows.Forms.Label()
        Me.labTipoIQdia = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.labEdadIQdia = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.labNombreIQdia = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.labHonorariosPendientesTotalesIQdia = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.labIQdia = New System.Windows.Forms.Label()
        Me.ListBoxIQdia = New System.Windows.Forms.ListBox()
        Me.CalendarioIQdia = New System.Windows.Forms.MonthCalendar()
        Me.TabPagePagos = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPagePagosXdia = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labPAGOdiaRif = New System.Windows.Forms.Label()
        Me.Label171 = New System.Windows.Forms.Label()
        Me.labPAGOdiaPorcentajeDeRetencion = New System.Windows.Forms.Label()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.txtPAGOdiaNotasSel = New System.Windows.Forms.TextBox()
        Me.labPAGOdiaIncluidoSel = New System.Windows.Forms.Label()
        Me.labPAGOdiaTotalDevengadoSel = New System.Windows.Forms.Label()
        Me.labPagoDiaOtrasRetSel = New System.Windows.Forms.Label()
        Me.labPagoDiaRetAdmSel = New System.Windows.Forms.Label()
        Me.labPagoDiaRetISLRsel = New System.Windows.Forms.Label()
        Me.labPagoDiaPagadoNetoSel = New System.Windows.Forms.Label()
        Me.labPAGOdiaModoPagoSel = New System.Windows.Forms.Label()
        Me.labPAGOdiaPagadorSel = New System.Windows.Forms.Label()
        Me.labPAGOdiaFacturaSel = New System.Windows.Forms.Label()
        Me.labPAGOdiaFechaSel = New System.Windows.Forms.Label()
        Me.Label153 = New System.Windows.Forms.Label()
        Me.Label152 = New System.Windows.Forms.Label()
        Me.Label151 = New System.Windows.Forms.Label()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.Label149 = New System.Windows.Forms.Label()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.Label148 = New System.Windows.Forms.Label()
        Me.Label146 = New System.Windows.Forms.Label()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.chkPAGOincluyeNoFacturadosDIA = New System.Windows.Forms.CheckBox()
        Me.Label143 = New System.Windows.Forms.Label()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.labPagoDiaTotalDevengado = New System.Windows.Forms.Label()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.labPagoDiaOtrasRet = New System.Windows.Forms.Label()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.labPagoDiaRetAdm = New System.Windows.Forms.Label()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.labPagoDiaRetISLR = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.labPagoDiaPagadoNeto = New System.Windows.Forms.Label()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.labPagosDia = New System.Windows.Forms.Label()
        Me.ListBoxPagosDia = New System.Windows.Forms.ListBox()
        Me.CalendarioPagosDia = New System.Windows.Forms.MonthCalendar()
        Me.TabPagePagosXmes = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.labPAGOmesRif = New System.Windows.Forms.Label()
        Me.Label172 = New System.Windows.Forms.Label()
        Me.labPAGOMesPorcentajeDeRetencion = New System.Windows.Forms.Label()
        Me.Label163 = New System.Windows.Forms.Label()
        Me.Label165 = New System.Windows.Forms.Label()
        Me.txtPAGOmesNotasSel = New System.Windows.Forms.TextBox()
        Me.labPAGOmesIncluidoSel = New System.Windows.Forms.Label()
        Me.labPAGOmesTotalDevengadoSel = New System.Windows.Forms.Label()
        Me.labPagoMesOtrasRetSel = New System.Windows.Forms.Label()
        Me.labPagoMesRetAdmSel = New System.Windows.Forms.Label()
        Me.labPagoMesRetISLRsel = New System.Windows.Forms.Label()
        Me.labPagoMesPagadoNetoSel = New System.Windows.Forms.Label()
        Me.labPAGOmesModoPagoSel = New System.Windows.Forms.Label()
        Me.labPAGOmesPagadorSel = New System.Windows.Forms.Label()
        Me.labPAGOmesFacturaSel = New System.Windows.Forms.Label()
        Me.labPAGOmesFechaSel = New System.Windows.Forms.Label()
        Me.Label179 = New System.Windows.Forms.Label()
        Me.Label180 = New System.Windows.Forms.Label()
        Me.Label181 = New System.Windows.Forms.Label()
        Me.Label182 = New System.Windows.Forms.Label()
        Me.Label183 = New System.Windows.Forms.Label()
        Me.Label184 = New System.Windows.Forms.Label()
        Me.Label185 = New System.Windows.Forms.Label()
        Me.Label186 = New System.Windows.Forms.Label()
        Me.Label187 = New System.Windows.Forms.Label()
        Me.Label188 = New System.Windows.Forms.Label()
        Me.labPagosMesSeleccionado = New System.Windows.Forms.Label()
        Me.labPagoMesTotalDevengado = New System.Windows.Forms.Label()
        Me.Label162 = New System.Windows.Forms.Label()
        Me.labPagoMesOtrasRet = New System.Windows.Forms.Label()
        Me.Label164 = New System.Windows.Forms.Label()
        Me.labPagoMesRetAdm = New System.Windows.Forms.Label()
        Me.Label166 = New System.Windows.Forms.Label()
        Me.labPagoMesRetISLR = New System.Windows.Forms.Label()
        Me.Label168 = New System.Windows.Forms.Label()
        Me.labPagoMesPagadoNeto = New System.Windows.Forms.Label()
        Me.Label170 = New System.Windows.Forms.Label()
        Me.chkPAGOincluyeNoFacturadosMES = New System.Windows.Forms.CheckBox()
        Me.labPagosMes = New System.Windows.Forms.Label()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.Label159 = New System.Windows.Forms.Label()
        Me.Label160 = New System.Windows.Forms.Label()
        Me.botPagoMesAdelantaMes = New System.Windows.Forms.Button()
        Me.botPagoMesRetrocedeMes = New System.Windows.Forms.Button()
        Me.ListBoxPagosMes = New System.Windows.Forms.ListBox()
        Me.TabPagePagosXaño = New System.Windows.Forms.TabPage()
        Me.ProgressBarAÑO = New System.Windows.Forms.ProgressBar()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.labPAGOañoRif = New System.Windows.Forms.Label()
        Me.Label174 = New System.Windows.Forms.Label()
        Me.labPAGOAñoPorcentajeDeRetencion = New System.Windows.Forms.Label()
        Me.Label167 = New System.Windows.Forms.Label()
        Me.Label169 = New System.Windows.Forms.Label()
        Me.txtPAGOañoNotasSel = New System.Windows.Forms.TextBox()
        Me.labPAGOañoIncluidoSel = New System.Windows.Forms.Label()
        Me.labPAGOañoTotalDevengadoSel = New System.Windows.Forms.Label()
        Me.labPagoAñoOtrasRetSel = New System.Windows.Forms.Label()
        Me.labPagoAñoRetAdmSel = New System.Windows.Forms.Label()
        Me.labPagoAñoRetISLRsel = New System.Windows.Forms.Label()
        Me.labPagoAñoPagadoNetoSel = New System.Windows.Forms.Label()
        Me.labPAGOañoModoPagoSel = New System.Windows.Forms.Label()
        Me.labPAGOañoPagadorSel = New System.Windows.Forms.Label()
        Me.labPAGOañoFacturaSel = New System.Windows.Forms.Label()
        Me.labPAGOañoFechaSel = New System.Windows.Forms.Label()
        Me.Label191 = New System.Windows.Forms.Label()
        Me.Label192 = New System.Windows.Forms.Label()
        Me.Label193 = New System.Windows.Forms.Label()
        Me.Label194 = New System.Windows.Forms.Label()
        Me.Label195 = New System.Windows.Forms.Label()
        Me.Label196 = New System.Windows.Forms.Label()
        Me.Label197 = New System.Windows.Forms.Label()
        Me.Label198 = New System.Windows.Forms.Label()
        Me.Label199 = New System.Windows.Forms.Label()
        Me.Label200 = New System.Windows.Forms.Label()
        Me.labPagosAñoSeleccionado = New System.Windows.Forms.Label()
        Me.labPagoAñoTotalDevengado = New System.Windows.Forms.Label()
        Me.Label203 = New System.Windows.Forms.Label()
        Me.labPagoAñoOtrasRet = New System.Windows.Forms.Label()
        Me.Label205 = New System.Windows.Forms.Label()
        Me.labPagoAñoRetAdm = New System.Windows.Forms.Label()
        Me.Label207 = New System.Windows.Forms.Label()
        Me.labPagoAñoRetISLR = New System.Windows.Forms.Label()
        Me.Label209 = New System.Windows.Forms.Label()
        Me.labPagoAñoPagadoNeto = New System.Windows.Forms.Label()
        Me.Label211 = New System.Windows.Forms.Label()
        Me.chkPAGOincluyeNoFacturadosAÑO = New System.Windows.Forms.CheckBox()
        Me.labPagosAño = New System.Windows.Forms.Label()
        Me.Label213 = New System.Windows.Forms.Label()
        Me.Label214 = New System.Windows.Forms.Label()
        Me.Label215 = New System.Windows.Forms.Label()
        Me.Label216 = New System.Windows.Forms.Label()
        Me.botPagoAÑOAdelantaAño = New System.Windows.Forms.Button()
        Me.botPagoaÑORetrocedeAño = New System.Windows.Forms.Button()
        Me.ListBoxPagosAño = New System.Windows.Forms.ListBox()
        Me.TabPageISLR = New System.Windows.Forms.TabPage()
        Me.ProgressBarAñoIslr = New System.Windows.Forms.ProgressBar()
        Me.labPagosAñoIslrSeleccionado = New System.Windows.Forms.Label()
        Me.botPagoAdelantaAñoIslr = New System.Windows.Forms.Button()
        Me.botPagoRetrocedeAñoIslr = New System.Windows.Forms.Button()
        Me.txtPagosExportacionDatos = New System.Windows.Forms.TextBox()
        Me.botPagoMuestraDatosDelAñoIslr = New System.Windows.Forms.Button()
        Me.TabPageResHonorarios = New System.Windows.Forms.TabPage()
        Me.txtHonorariosDisplay = New System.Windows.Forms.TextBox()
        Me.radHonorariosTotales = New System.Windows.Forms.RadioButton()
        Me.radHonorariosFacturados = New System.Windows.Forms.RadioButton()
        Me.radHonorariosGenerados = New System.Windows.Forms.RadioButton()
        Me.labHonorariosAñoSeleccionado = New System.Windows.Forms.Label()
        Me.botHonorariosAdelantaAño = New System.Windows.Forms.Button()
        Me.botHonorariosRetrocedeAño = New System.Windows.Forms.Button()
        Me.TabPageCalendario = New System.Windows.Forms.TabPage()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TabPageHonorarios = New System.Windows.Forms.TabPage()
        Me.labTotalAño2 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.labTotalConsultas2 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.labTotalIQ = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.labTotalIQcan = New System.Windows.Forms.Label()
        Me.lab12iqCan = New System.Windows.Forms.Label()
        Me.lab11iqCan = New System.Windows.Forms.Label()
        Me.lab10iqCan = New System.Windows.Forms.Label()
        Me.lab09iqCan = New System.Windows.Forms.Label()
        Me.lab08iqCan = New System.Windows.Forms.Label()
        Me.lab07iqCan = New System.Windows.Forms.Label()
        Me.lab06iqCan = New System.Windows.Forms.Label()
        Me.lab05iqCan = New System.Windows.Forms.Label()
        Me.lab04iqCan = New System.Windows.Forms.Label()
        Me.lab03iqCan = New System.Windows.Forms.Label()
        Me.lab02iqCan = New System.Windows.Forms.Label()
        Me.lab01iqCan = New System.Windows.Forms.Label()
        Me.labDiciembre = New System.Windows.Forms.Label()
        Me.lab12cons = New System.Windows.Forms.Label()
        Me.lab12iqPen = New System.Windows.Forms.Label()
        Me.lab12total = New System.Windows.Forms.Label()
        Me.labNoviembre = New System.Windows.Forms.Label()
        Me.lab11cons = New System.Windows.Forms.Label()
        Me.lab11iqPen = New System.Windows.Forms.Label()
        Me.lab11total = New System.Windows.Forms.Label()
        Me.labOctubre = New System.Windows.Forms.Label()
        Me.lab10cons = New System.Windows.Forms.Label()
        Me.lab10iqPen = New System.Windows.Forms.Label()
        Me.lab10total = New System.Windows.Forms.Label()
        Me.labSeptiembre = New System.Windows.Forms.Label()
        Me.lab09cons = New System.Windows.Forms.Label()
        Me.lab09iqPen = New System.Windows.Forms.Label()
        Me.lab09total = New System.Windows.Forms.Label()
        Me.labAgosto = New System.Windows.Forms.Label()
        Me.lab08cons = New System.Windows.Forms.Label()
        Me.lab08iqPen = New System.Windows.Forms.Label()
        Me.lab08total = New System.Windows.Forms.Label()
        Me.labJulio = New System.Windows.Forms.Label()
        Me.lab07cons = New System.Windows.Forms.Label()
        Me.lab07iqPen = New System.Windows.Forms.Label()
        Me.lab07total = New System.Windows.Forms.Label()
        Me.labJunio = New System.Windows.Forms.Label()
        Me.lab06cons = New System.Windows.Forms.Label()
        Me.lab06iqPen = New System.Windows.Forms.Label()
        Me.lab06total = New System.Windows.Forms.Label()
        Me.labMayo = New System.Windows.Forms.Label()
        Me.lab05cons = New System.Windows.Forms.Label()
        Me.lab05iqPen = New System.Windows.Forms.Label()
        Me.lab05total = New System.Windows.Forms.Label()
        Me.labAbril = New System.Windows.Forms.Label()
        Me.lab04cons = New System.Windows.Forms.Label()
        Me.lab04iqPen = New System.Windows.Forms.Label()
        Me.lab04total = New System.Windows.Forms.Label()
        Me.labMarzo = New System.Windows.Forms.Label()
        Me.lab03cons = New System.Windows.Forms.Label()
        Me.lab03iqPen = New System.Windows.Forms.Label()
        Me.lab03total = New System.Windows.Forms.Label()
        Me.labFebrero = New System.Windows.Forms.Label()
        Me.lab02cons = New System.Windows.Forms.Label()
        Me.lab02iqPen = New System.Windows.Forms.Label()
        Me.lab02total = New System.Windows.Forms.Label()
        Me.labEnero = New System.Windows.Forms.Label()
        Me.lab01cons = New System.Windows.Forms.Label()
        Me.lab01iqPen = New System.Windows.Forms.Label()
        Me.lab01total = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.botAdelantaAñoHon = New System.Windows.Forms.Button()
        Me.botRetrocedeAñoHon = New System.Windows.Forms.Button()
        Me.labAñoSeleccionadoHon = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.labTotalAño = New System.Windows.Forms.Label()
        Me.labTotalIQpen = New System.Windows.Forms.Label()
        Me.labTotalConsultas = New System.Windows.Forms.Label()
        Me.Label157 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BarraProgresoAgenda = New System.Windows.Forms.ToolStripProgressBar()
        Me.BarraEstadoAgenda = New System.Windows.Forms.ToolStripStatusLabel()
        Me.botActualizar = New System.Windows.Forms.Button()
        Me.botCerrar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPageControles.SuspendLayout()
        Me.PanelControlAnual.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelControlMensual.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelControlDiario.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBoxConsultaSeleccionadaDia.SuspendLayout()
        Me.TabPageProximos.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPagePacientes.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPageIntervenciones.SuspendLayout()
        Me.PanelIQaño.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelIQmes.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelIQdia.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPagePagos.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPagePagosXdia.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPagePagosXmes.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabPagePagosXaño.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabPageISLR.SuspendLayout()
        Me.TabPageResHonorarios.SuspendLayout()
        Me.TabPageCalendario.SuspendLayout()
        Me.TabPageHonorarios.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageControles)
        Me.TabControl1.Controls.Add(Me.TabPageProximos)
        Me.TabControl1.Controls.Add(Me.TabPagePacientes)
        Me.TabControl1.Controls.Add(Me.TabPageIntervenciones)
        Me.TabControl1.Controls.Add(Me.TabPagePagos)
        Me.TabControl1.Controls.Add(Me.TabPageResHonorarios)
        Me.TabControl1.Controls.Add(Me.TabPageCalendario)
        Me.TabControl1.Controls.Add(Me.TabPageHonorarios)
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(970, 606)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageControles
        '
        Me.TabPageControles.AutoScroll = True
        Me.TabPageControles.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageControles.Controls.Add(Me.radControlAnual)
        Me.TabPageControles.Controls.Add(Me.radControlMensual)
        Me.TabPageControles.Controls.Add(Me.radControlDiario)
        Me.TabPageControles.Controls.Add(Me.PanelControlAnual)
        Me.TabPageControles.Controls.Add(Me.PanelControlMensual)
        Me.TabPageControles.Controls.Add(Me.PanelControlDiario)
        Me.TabPageControles.Location = New System.Drawing.Point(4, 22)
        Me.TabPageControles.Name = "TabPageControles"
        Me.TabPageControles.Size = New System.Drawing.Size(962, 580)
        Me.TabPageControles.TabIndex = 0
        Me.TabPageControles.Text = "Controles Realizados"
        '
        'radControlAnual
        '
        Me.radControlAnual.Location = New System.Drawing.Point(264, 8)
        Me.radControlAnual.Name = "radControlAnual"
        Me.radControlAnual.Size = New System.Drawing.Size(104, 24)
        Me.radControlAnual.TabIndex = 5
        Me.radControlAnual.Text = "Vista Anual"
        Me.radControlAnual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radControlMensual
        '
        Me.radControlMensual.Location = New System.Drawing.Point(144, 8)
        Me.radControlMensual.Name = "radControlMensual"
        Me.radControlMensual.Size = New System.Drawing.Size(104, 24)
        Me.radControlMensual.TabIndex = 4
        Me.radControlMensual.Text = "Vista Mensual"
        Me.radControlMensual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radControlDiario
        '
        Me.radControlDiario.BackColor = System.Drawing.SystemColors.Control
        Me.radControlDiario.Checked = True
        Me.radControlDiario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.radControlDiario.Location = New System.Drawing.Point(24, 8)
        Me.radControlDiario.Name = "radControlDiario"
        Me.radControlDiario.Size = New System.Drawing.Size(104, 24)
        Me.radControlDiario.TabIndex = 3
        Me.radControlDiario.TabStop = True
        Me.radControlDiario.Text = "Vista Diaria"
        Me.radControlDiario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radControlDiario.UseVisualStyleBackColor = False
        '
        'PanelControlAnual
        '
        Me.PanelControlAnual.Controls.Add(Me.botImprimeConsultasDelAño)
        Me.PanelControlAnual.Controls.Add(Me.GroupBox3)
        Me.PanelControlAnual.Controls.Add(Me.Panel2)
        Me.PanelControlAnual.Controls.Add(Me.labHonorariosTotalesAño)
        Me.PanelControlAnual.Controls.Add(Me.Label20)
        Me.PanelControlAnual.Controls.Add(Me.labNumeroPacientesAño)
        Me.PanelControlAnual.Controls.Add(Me.Label24)
        Me.PanelControlAnual.Controls.Add(Me.ListBoxPacientesAño)
        Me.PanelControlAnual.Location = New System.Drawing.Point(8, 1186)
        Me.PanelControlAnual.Name = "PanelControlAnual"
        Me.PanelControlAnual.Size = New System.Drawing.Size(925, 535)
        Me.PanelControlAnual.TabIndex = 2
        '
        'botImprimeConsultasDelAño
        '
        Me.botImprimeConsultasDelAño.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botImprimeConsultasDelAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImprimeConsultasDelAño.Location = New System.Drawing.Point(795, 159)
        Me.botImprimeConsultasDelAño.Name = "botImprimeConsultasDelAño"
        Me.botImprimeConsultasDelAño.Size = New System.Drawing.Size(120, 23)
        Me.botImprimeConsultasDelAño.TabIndex = 18
        Me.botImprimeConsultasDelAño.Text = "Imprime"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.labFacturaAño)
        Me.GroupBox3.Controls.Add(Me.Label123)
        Me.GroupBox3.Controls.Add(Me.Label77)
        Me.GroupBox3.Controls.Add(Me.Label95)
        Me.GroupBox3.Controls.Add(Me.txtAUTOaño)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtPendienteAño)
        Me.GroupBox3.Controls.Add(Me.txtTtoAño)
        Me.GroupBox3.Controls.Add(Me.txtIDxAño)
        Me.GroupBox3.Controls.Add(Me.labHonorariosAño)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.labProximaAño)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.labLugarAño)
        Me.GroupBox3.Controls.Add(Me.Label64)
        Me.GroupBox3.Controls.Add(Me.labCedulaAño)
        Me.GroupBox3.Controls.Add(Me.Label73)
        Me.GroupBox3.Controls.Add(Me.labNombreAño)
        Me.GroupBox3.Controls.Add(Me.Label76)
        Me.GroupBox3.Controls.Add(Me.labNumeroHistoriaAño)
        Me.GroupBox3.Controls.Add(Me.Label78)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(914, 334)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Consulta Seleccionada"
        '
        'labFacturaAño
        '
        Me.labFacturaAño.BackColor = System.Drawing.Color.LightCyan
        Me.labFacturaAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFacturaAño.ForeColor = System.Drawing.Color.Black
        Me.labFacturaAño.Location = New System.Drawing.Point(337, 71)
        Me.labFacturaAño.Name = "labFacturaAño"
        Me.labFacturaAño.Size = New System.Drawing.Size(112, 20)
        Me.labFacturaAño.TabIndex = 32
        Me.labFacturaAño.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Location = New System.Drawing.Point(238, 75)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(93, 13)
        Me.Label123.TabIndex = 33
        Me.Label123.Text = "Factura Asociada:"
        Me.Label123.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(363, 110)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(179, 13)
        Me.Label77.TabIndex = 30
        Me.Label77.Text = "Signos Subjetivos y Datos Manuales"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(6, 110)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(200, 13)
        Me.Label95.TabIndex = 29
        Me.Label95.Text = "Signos Objetivos y Datos Autogenerados"
        Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAUTOaño
        '
        Me.txtAUTOaño.BackColor = System.Drawing.SystemColors.Info
        Me.txtAUTOaño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtAUTOaño.Location = New System.Drawing.Point(9, 127)
        Me.txtAUTOaño.MaxLength = 3000
        Me.txtAUTOaño.Multiline = True
        Me.txtAUTOaño.Name = "txtAUTOaño"
        Me.txtAUTOaño.ReadOnly = True
        Me.txtAUTOaño.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAUTOaño.Size = New System.Drawing.Size(300, 200)
        Me.txtAUTOaño.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(672, 222)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Pendiente en la Próxima Cita"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(672, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(146, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Procedimientos y Tratamiento"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPendienteAño
        '
        Me.txtPendienteAño.BackColor = System.Drawing.SystemColors.Info
        Me.txtPendienteAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPendienteAño.Location = New System.Drawing.Point(675, 239)
        Me.txtPendienteAño.MaxLength = 1000
        Me.txtPendienteAño.Multiline = True
        Me.txtPendienteAño.Name = "txtPendienteAño"
        Me.txtPendienteAño.ReadOnly = True
        Me.txtPendienteAño.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPendienteAño.Size = New System.Drawing.Size(232, 88)
        Me.txtPendienteAño.TabIndex = 21
        '
        'txtTtoAño
        '
        Me.txtTtoAño.BackColor = System.Drawing.SystemColors.Info
        Me.txtTtoAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTtoAño.Location = New System.Drawing.Point(675, 127)
        Me.txtTtoAño.MaxLength = 1000
        Me.txtTtoAño.Multiline = True
        Me.txtTtoAño.Name = "txtTtoAño"
        Me.txtTtoAño.ReadOnly = True
        Me.txtTtoAño.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTtoAño.Size = New System.Drawing.Size(232, 88)
        Me.txtTtoAño.TabIndex = 20
        '
        'txtIDxAño
        '
        Me.txtIDxAño.BackColor = System.Drawing.SystemColors.Info
        Me.txtIDxAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtIDxAño.Location = New System.Drawing.Point(366, 127)
        Me.txtIDxAño.MaxLength = 3000
        Me.txtIDxAño.Multiline = True
        Me.txtIDxAño.Name = "txtIDxAño"
        Me.txtIDxAño.ReadOnly = True
        Me.txtIDxAño.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDxAño.Size = New System.Drawing.Size(300, 200)
        Me.txtIDxAño.TabIndex = 19
        '
        'labHonorariosAño
        '
        Me.labHonorariosAño.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosAño.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosAño.Location = New System.Drawing.Point(73, 71)
        Me.labHonorariosAño.Name = "labHonorariosAño"
        Me.labHonorariosAño.Size = New System.Drawing.Size(112, 20)
        Me.labHonorariosAño.TabIndex = 17
        Me.labHonorariosAño.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 75)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(61, 13)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Honorarios:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labProximaAño
        '
        Me.labProximaAño.BackColor = System.Drawing.SystemColors.Info
        Me.labProximaAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labProximaAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labProximaAño.Location = New System.Drawing.Point(337, 46)
        Me.labProximaAño.Name = "labProximaAño"
        Me.labProximaAño.Size = New System.Drawing.Size(232, 20)
        Me.labProximaAño.TabIndex = 16
        Me.labProximaAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(279, 50)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(52, 13)
        Me.Label37.TabIndex = 15
        Me.Label37.Text = "Próx Cita:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labLugarAño
        '
        Me.labLugarAño.BackColor = System.Drawing.SystemColors.Info
        Me.labLugarAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labLugarAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labLugarAño.Location = New System.Drawing.Point(73, 46)
        Me.labLugarAño.Name = "labLugarAño"
        Me.labLugarAño.Size = New System.Drawing.Size(200, 20)
        Me.labLugarAño.TabIndex = 14
        Me.labLugarAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(30, 50)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(37, 13)
        Me.Label64.TabIndex = 13
        Me.Label64.Text = "Lugar:"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labCedulaAño
        '
        Me.labCedulaAño.BackColor = System.Drawing.SystemColors.Info
        Me.labCedulaAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCedulaAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCedulaAño.Location = New System.Drawing.Point(767, 21)
        Me.labCedulaAño.Name = "labCedulaAño"
        Me.labCedulaAño.Size = New System.Drawing.Size(140, 20)
        Me.labCedulaAño.TabIndex = 12
        Me.labCedulaAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(718, 25)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(43, 13)
        Me.Label73.TabIndex = 11
        Me.Label73.Text = "Cédula:"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNombreAño
        '
        Me.labNombreAño.BackColor = System.Drawing.SystemColors.Info
        Me.labNombreAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombreAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombreAño.Location = New System.Drawing.Point(252, 21)
        Me.labNombreAño.Name = "labNombreAño"
        Me.labNombreAño.Size = New System.Drawing.Size(460, 20)
        Me.labNombreAño.TabIndex = 10
        Me.labNombreAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(199, 25)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(47, 13)
        Me.Label76.TabIndex = 9
        Me.Label76.Text = "Nombre:"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNumeroHistoriaAño
        '
        Me.labNumeroHistoriaAño.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroHistoriaAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroHistoriaAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroHistoriaAño.Location = New System.Drawing.Point(73, 21)
        Me.labNumeroHistoriaAño.Name = "labNumeroHistoriaAño"
        Me.labNumeroHistoriaAño.Size = New System.Drawing.Size(120, 20)
        Me.labNumeroHistoriaAño.TabIndex = 8
        Me.labNumeroHistoriaAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(15, 25)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(52, 13)
        Me.Label78.TabIndex = 7
        Me.Label78.Text = "Historia #"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.botAdelantaAño)
        Me.Panel2.Controls.Add(Me.botRetrocedeAño)
        Me.Panel2.Controls.Add(Me.labAñoSeleccionado)
        Me.Panel2.Location = New System.Drawing.Point(240, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 24)
        Me.Panel2.TabIndex = 16
        '
        'botAdelantaAño
        '
        Me.botAdelantaAño.BackColor = System.Drawing.SystemColors.Control
        Me.botAdelantaAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAdelantaAño.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botAdelantaAño.Image = CType(resources.GetObject("botAdelantaAño.Image"), System.Drawing.Image)
        Me.botAdelantaAño.Location = New System.Drawing.Point(456, 0)
        Me.botAdelantaAño.Name = "botAdelantaAño"
        Me.botAdelantaAño.Size = New System.Drawing.Size(24, 24)
        Me.botAdelantaAño.TabIndex = 1
        Me.botAdelantaAño.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botAdelantaAño.UseVisualStyleBackColor = False
        '
        'botRetrocedeAño
        '
        Me.botRetrocedeAño.BackColor = System.Drawing.SystemColors.Control
        Me.botRetrocedeAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRetrocedeAño.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRetrocedeAño.Image = CType(resources.GetObject("botRetrocedeAño.Image"), System.Drawing.Image)
        Me.botRetrocedeAño.Location = New System.Drawing.Point(0, 0)
        Me.botRetrocedeAño.Name = "botRetrocedeAño"
        Me.botRetrocedeAño.Size = New System.Drawing.Size(24, 24)
        Me.botRetrocedeAño.TabIndex = 0
        Me.botRetrocedeAño.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botRetrocedeAño.UseVisualStyleBackColor = False
        '
        'labAñoSeleccionado
        '
        Me.labAñoSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labAñoSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAñoSeleccionado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labAñoSeleccionado.Location = New System.Drawing.Point(30, 1)
        Me.labAñoSeleccionado.Name = "labAñoSeleccionado"
        Me.labAñoSeleccionado.Size = New System.Drawing.Size(420, 20)
        Me.labAñoSeleccionado.TabIndex = 3
        Me.labAñoSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labHonorariosTotalesAño
        '
        Me.labHonorariosTotalesAño.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosTotalesAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosTotalesAño.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosTotalesAño.Location = New System.Drawing.Point(803, 100)
        Me.labHonorariosTotalesAño.Name = "labHonorariosTotalesAño"
        Me.labHonorariosTotalesAño.Size = New System.Drawing.Size(112, 20)
        Me.labHonorariosTotalesAño.TabIndex = 15
        Me.labHonorariosTotalesAño.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(731, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(184, 20)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Honorarios por Consultas del año :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labNumeroPacientesAño
        '
        Me.labNumeroPacientesAño.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroPacientesAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroPacientesAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroPacientesAño.Location = New System.Drawing.Point(803, 44)
        Me.labNumeroPacientesAño.Name = "labNumeroPacientesAño"
        Me.labNumeroPacientesAño.Size = New System.Drawing.Size(112, 20)
        Me.labNumeroPacientesAño.TabIndex = 13
        Me.labNumeroPacientesAño.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(731, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(184, 20)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "Consultas realizadas en el año:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListBoxPacientesAño
        '
        Me.ListBoxPacientesAño.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxPacientesAño.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPacientesAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxPacientesAño.ItemHeight = 11
        Me.ListBoxPacientesAño.Location = New System.Drawing.Point(240, 24)
        Me.ListBoxPacientesAño.Name = "ListBoxPacientesAño"
        Me.ListBoxPacientesAño.Size = New System.Drawing.Size(480, 158)
        Me.ListBoxPacientesAño.TabIndex = 11
        '
        'PanelControlMensual
        '
        Me.PanelControlMensual.Controls.Add(Me.botImprimeConsultasDelMes)
        Me.PanelControlMensual.Controls.Add(Me.GroupBox2)
        Me.PanelControlMensual.Controls.Add(Me.labHonorariosTotalesMes)
        Me.PanelControlMensual.Controls.Add(Me.Label4)
        Me.PanelControlMensual.Controls.Add(Me.labNumeroPacientesMes)
        Me.PanelControlMensual.Controls.Add(Me.Label9)
        Me.PanelControlMensual.Controls.Add(Me.ListBoxPacientesMes)
        Me.PanelControlMensual.Controls.Add(Me.Panel1)
        Me.PanelControlMensual.Location = New System.Drawing.Point(8, 603)
        Me.PanelControlMensual.Name = "PanelControlMensual"
        Me.PanelControlMensual.Size = New System.Drawing.Size(925, 535)
        Me.PanelControlMensual.TabIndex = 1
        '
        'botImprimeConsultasDelMes
        '
        Me.botImprimeConsultasDelMes.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botImprimeConsultasDelMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImprimeConsultasDelMes.Location = New System.Drawing.Point(795, 159)
        Me.botImprimeConsultasDelMes.Name = "botImprimeConsultasDelMes"
        Me.botImprimeConsultasDelMes.Size = New System.Drawing.Size(120, 23)
        Me.botImprimeConsultasDelMes.TabIndex = 12
        Me.botImprimeConsultasDelMes.Text = "Imprime"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.labFacturaMes)
        Me.GroupBox2.Controls.Add(Me.Label122)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label83)
        Me.GroupBox2.Controls.Add(Me.txtAUTOmes)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtPendienteMes)
        Me.GroupBox2.Controls.Add(Me.txtTtoMes)
        Me.GroupBox2.Controls.Add(Me.txtIDxMes)
        Me.GroupBox2.Controls.Add(Me.labHonorariosMes)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.labProximaMes)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.labLugarMes)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.LabCedulaMes)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.labNombreMes)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.labNumeroHistoriaMes)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(914, 334)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consulta Seleccionada"
        '
        'labFacturaMes
        '
        Me.labFacturaMes.BackColor = System.Drawing.Color.LightCyan
        Me.labFacturaMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFacturaMes.ForeColor = System.Drawing.Color.Black
        Me.labFacturaMes.Location = New System.Drawing.Point(337, 71)
        Me.labFacturaMes.Name = "labFacturaMes"
        Me.labFacturaMes.Size = New System.Drawing.Size(112, 20)
        Me.labFacturaMes.TabIndex = 32
        Me.labFacturaMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Location = New System.Drawing.Point(238, 75)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(93, 13)
        Me.Label122.TabIndex = 33
        Me.Label122.Text = "Factura Asociada:"
        Me.Label122.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(363, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(179, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Signos Subjetivos y Datos Manuales"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(6, 110)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(200, 13)
        Me.Label83.TabIndex = 28
        Me.Label83.Text = "Signos Objetivos y Datos Autogenerados"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAUTOmes
        '
        Me.txtAUTOmes.BackColor = System.Drawing.SystemColors.Info
        Me.txtAUTOmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtAUTOmes.Location = New System.Drawing.Point(9, 127)
        Me.txtAUTOmes.Multiline = True
        Me.txtAUTOmes.Name = "txtAUTOmes"
        Me.txtAUTOmes.ReadOnly = True
        Me.txtAUTOmes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAUTOmes.Size = New System.Drawing.Size(300, 200)
        Me.txtAUTOmes.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(676, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Pendiente en la Próxima Cita"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(672, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Procedimientos y Tratamiento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPendienteMes
        '
        Me.txtPendienteMes.BackColor = System.Drawing.SystemColors.Info
        Me.txtPendienteMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPendienteMes.Location = New System.Drawing.Point(675, 239)
        Me.txtPendienteMes.MaxLength = 1000
        Me.txtPendienteMes.Multiline = True
        Me.txtPendienteMes.Name = "txtPendienteMes"
        Me.txtPendienteMes.ReadOnly = True
        Me.txtPendienteMes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPendienteMes.Size = New System.Drawing.Size(232, 88)
        Me.txtPendienteMes.TabIndex = 21
        '
        'txtTtoMes
        '
        Me.txtTtoMes.BackColor = System.Drawing.SystemColors.Info
        Me.txtTtoMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTtoMes.Location = New System.Drawing.Point(675, 127)
        Me.txtTtoMes.MaxLength = 1000
        Me.txtTtoMes.Multiline = True
        Me.txtTtoMes.Name = "txtTtoMes"
        Me.txtTtoMes.ReadOnly = True
        Me.txtTtoMes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTtoMes.Size = New System.Drawing.Size(232, 88)
        Me.txtTtoMes.TabIndex = 20
        '
        'txtIDxMes
        '
        Me.txtIDxMes.BackColor = System.Drawing.SystemColors.Info
        Me.txtIDxMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDxMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtIDxMes.Location = New System.Drawing.Point(366, 127)
        Me.txtIDxMes.Multiline = True
        Me.txtIDxMes.Name = "txtIDxMes"
        Me.txtIDxMes.ReadOnly = True
        Me.txtIDxMes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDxMes.Size = New System.Drawing.Size(300, 200)
        Me.txtIDxMes.TabIndex = 19
        '
        'labHonorariosMes
        '
        Me.labHonorariosMes.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosMes.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosMes.Location = New System.Drawing.Point(73, 71)
        Me.labHonorariosMes.Name = "labHonorariosMes"
        Me.labHonorariosMes.Size = New System.Drawing.Size(112, 20)
        Me.labHonorariosMes.TabIndex = 17
        Me.labHonorariosMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Honorarios:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labProximaMes
        '
        Me.labProximaMes.BackColor = System.Drawing.SystemColors.Info
        Me.labProximaMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labProximaMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labProximaMes.Location = New System.Drawing.Point(337, 46)
        Me.labProximaMes.Name = "labProximaMes"
        Me.labProximaMes.Size = New System.Drawing.Size(232, 20)
        Me.labProximaMes.TabIndex = 16
        Me.labProximaMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(279, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Próx Cita:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labLugarMes
        '
        Me.labLugarMes.BackColor = System.Drawing.SystemColors.Info
        Me.labLugarMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labLugarMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labLugarMes.Location = New System.Drawing.Point(73, 46)
        Me.labLugarMes.Name = "labLugarMes"
        Me.labLugarMes.Size = New System.Drawing.Size(200, 20)
        Me.labLugarMes.TabIndex = 14
        Me.labLugarMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(30, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Lugar:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabCedulaMes
        '
        Me.LabCedulaMes.BackColor = System.Drawing.SystemColors.Info
        Me.LabCedulaMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabCedulaMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.LabCedulaMes.Location = New System.Drawing.Point(767, 21)
        Me.LabCedulaMes.Name = "LabCedulaMes"
        Me.LabCedulaMes.Size = New System.Drawing.Size(140, 20)
        Me.LabCedulaMes.TabIndex = 12
        Me.LabCedulaMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(718, 25)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Cédula:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNombreMes
        '
        Me.labNombreMes.BackColor = System.Drawing.SystemColors.Info
        Me.labNombreMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombreMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombreMes.Location = New System.Drawing.Point(252, 21)
        Me.labNombreMes.Name = "labNombreMes"
        Me.labNombreMes.Size = New System.Drawing.Size(460, 20)
        Me.labNombreMes.TabIndex = 10
        Me.labNombreMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(199, 25)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 13)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "Nombre:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNumeroHistoriaMes
        '
        Me.labNumeroHistoriaMes.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroHistoriaMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroHistoriaMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroHistoriaMes.Location = New System.Drawing.Point(73, 21)
        Me.labNumeroHistoriaMes.Name = "labNumeroHistoriaMes"
        Me.labNumeroHistoriaMes.Size = New System.Drawing.Size(120, 20)
        Me.labNumeroHistoriaMes.TabIndex = 8
        Me.labNumeroHistoriaMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(15, 25)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(52, 13)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Historia #"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosTotalesMes
        '
        Me.labHonorariosTotalesMes.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosTotalesMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosTotalesMes.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosTotalesMes.Location = New System.Drawing.Point(803, 100)
        Me.labHonorariosTotalesMes.Name = "labHonorariosTotalesMes"
        Me.labHonorariosTotalesMes.Size = New System.Drawing.Size(112, 20)
        Me.labHonorariosTotalesMes.TabIndex = 10
        Me.labHonorariosTotalesMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(731, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Honorarios por Consultas del mes:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labNumeroPacientesMes
        '
        Me.labNumeroPacientesMes.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroPacientesMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroPacientesMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroPacientesMes.Location = New System.Drawing.Point(803, 44)
        Me.labNumeroPacientesMes.Name = "labNumeroPacientesMes"
        Me.labNumeroPacientesMes.Size = New System.Drawing.Size(112, 20)
        Me.labNumeroPacientesMes.TabIndex = 8
        Me.labNumeroPacientesMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(747, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Consultas realizadas en el mes:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListBoxPacientesMes
        '
        Me.ListBoxPacientesMes.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxPacientesMes.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPacientesMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxPacientesMes.ItemHeight = 11
        Me.ListBoxPacientesMes.Location = New System.Drawing.Point(240, 24)
        Me.ListBoxPacientesMes.Name = "ListBoxPacientesMes"
        Me.ListBoxPacientesMes.Size = New System.Drawing.Size(480, 158)
        Me.ListBoxPacientesMes.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.botAdelantaMes)
        Me.Panel1.Controls.Add(Me.botRetrocedeMes)
        Me.Panel1.Controls.Add(Me.labMesSeleccionado)
        Me.Panel1.Location = New System.Drawing.Point(240, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 24)
        Me.Panel1.TabIndex = 2
        '
        'botAdelantaMes
        '
        Me.botAdelantaMes.BackColor = System.Drawing.SystemColors.Control
        Me.botAdelantaMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAdelantaMes.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botAdelantaMes.Image = CType(resources.GetObject("botAdelantaMes.Image"), System.Drawing.Image)
        Me.botAdelantaMes.Location = New System.Drawing.Point(456, 0)
        Me.botAdelantaMes.Name = "botAdelantaMes"
        Me.botAdelantaMes.Size = New System.Drawing.Size(24, 24)
        Me.botAdelantaMes.TabIndex = 1
        Me.botAdelantaMes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botAdelantaMes.UseVisualStyleBackColor = False
        '
        'botRetrocedeMes
        '
        Me.botRetrocedeMes.BackColor = System.Drawing.SystemColors.Control
        Me.botRetrocedeMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRetrocedeMes.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRetrocedeMes.Image = CType(resources.GetObject("botRetrocedeMes.Image"), System.Drawing.Image)
        Me.botRetrocedeMes.Location = New System.Drawing.Point(0, 0)
        Me.botRetrocedeMes.Name = "botRetrocedeMes"
        Me.botRetrocedeMes.Size = New System.Drawing.Size(24, 24)
        Me.botRetrocedeMes.TabIndex = 0
        Me.botRetrocedeMes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botRetrocedeMes.UseVisualStyleBackColor = False
        '
        'labMesSeleccionado
        '
        Me.labMesSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labMesSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labMesSeleccionado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labMesSeleccionado.Location = New System.Drawing.Point(30, 1)
        Me.labMesSeleccionado.Name = "labMesSeleccionado"
        Me.labMesSeleccionado.Size = New System.Drawing.Size(420, 20)
        Me.labMesSeleccionado.TabIndex = 3
        Me.labMesSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelControlDiario
        '
        Me.PanelControlDiario.Controls.Add(Me.Label1)
        Me.PanelControlDiario.Controls.Add(Me.Panel6)
        Me.PanelControlDiario.Controls.Add(Me.GroupBoxConsultaSeleccionadaDia)
        Me.PanelControlDiario.Controls.Add(Me.labHonorariosTotalesDia)
        Me.PanelControlDiario.Controls.Add(Me.Label6)
        Me.PanelControlDiario.Controls.Add(Me.labNumeroPacientesDia)
        Me.PanelControlDiario.Controls.Add(Me.ListBoxPacientesDia)
        Me.PanelControlDiario.Controls.Add(Me.Calendario)
        Me.PanelControlDiario.Location = New System.Drawing.Point(8, 32)
        Me.PanelControlDiario.Name = "PanelControlDiario"
        Me.PanelControlDiario.Size = New System.Drawing.Size(925, 535)
        Me.PanelControlDiario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(747, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Consultas realizadas en el día:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel6.Controls.Add(Me.LabelPacientes)
        Me.Panel6.Location = New System.Drawing.Point(240, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(480, 24)
        Me.Panel6.TabIndex = 17
        '
        'LabelPacientes
        '
        Me.LabelPacientes.Location = New System.Drawing.Point(30, 1)
        Me.LabelPacientes.Name = "LabelPacientes"
        Me.LabelPacientes.Size = New System.Drawing.Size(420, 20)
        Me.LabelPacientes.TabIndex = 2
        Me.LabelPacientes.Text = "Pacientes del dia ..."
        Me.LabelPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxConsultaSeleccionadaDia
        '
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.botCONTROLESdiaEditarConsulta)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labFacturaDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label121)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label17)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label84)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.txtAUTOdia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label18)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label19)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.txtPendienteDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.txtTtoDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.txtIDxDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labHonorariosDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label16)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labProximaCitaDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label14)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labLugarDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label12)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labCedulaDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label10)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labNombreDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label8)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labNumeroHistoriaDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label5)
        Me.GroupBoxConsultaSeleccionadaDia.Location = New System.Drawing.Point(8, 198)
        Me.GroupBoxConsultaSeleccionadaDia.Name = "GroupBoxConsultaSeleccionadaDia"
        Me.GroupBoxConsultaSeleccionadaDia.Size = New System.Drawing.Size(914, 334)
        Me.GroupBoxConsultaSeleccionadaDia.TabIndex = 7
        Me.GroupBoxConsultaSeleccionadaDia.TabStop = False
        Me.GroupBoxConsultaSeleccionadaDia.Text = "Consulta Seleccionada"
        '
        'botCONTROLESdiaEditarConsulta
        '
        Me.botCONTROLESdiaEditarConsulta.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botCONTROLESdiaEditarConsulta.Location = New System.Drawing.Point(797, 44)
        Me.botCONTROLESdiaEditarConsulta.Name = "botCONTROLESdiaEditarConsulta"
        Me.botCONTROLESdiaEditarConsulta.Size = New System.Drawing.Size(110, 23)
        Me.botCONTROLESdiaEditarConsulta.TabIndex = 32
        Me.botCONTROLESdiaEditarConsulta.Text = "Editar Consulta"
        Me.botCONTROLESdiaEditarConsulta.UseVisualStyleBackColor = True
        '
        'labFacturaDia
        '
        Me.labFacturaDia.BackColor = System.Drawing.Color.LightCyan
        Me.labFacturaDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFacturaDia.ForeColor = System.Drawing.Color.Black
        Me.labFacturaDia.Location = New System.Drawing.Point(337, 71)
        Me.labFacturaDia.Name = "labFacturaDia"
        Me.labFacturaDia.Size = New System.Drawing.Size(112, 20)
        Me.labFacturaDia.TabIndex = 30
        Me.labFacturaDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Location = New System.Drawing.Point(238, 75)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(93, 13)
        Me.Label121.TabIndex = 31
        Me.Label121.Text = "Factura Asociada:"
        Me.Label121.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(363, 110)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(179, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Signos Subjetivos y Datos Manuales"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(6, 110)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(200, 13)
        Me.Label84.TabIndex = 28
        Me.Label84.Text = "Signos Objetivos y Datos Autogenerados"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAUTOdia
        '
        Me.txtAUTOdia.BackColor = System.Drawing.SystemColors.Info
        Me.txtAUTOdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtAUTOdia.Location = New System.Drawing.Point(9, 127)
        Me.txtAUTOdia.MaxLength = 3000
        Me.txtAUTOdia.Multiline = True
        Me.txtAUTOdia.Name = "txtAUTOdia"
        Me.txtAUTOdia.ReadOnly = True
        Me.txtAUTOdia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAUTOdia.Size = New System.Drawing.Size(300, 200)
        Me.txtAUTOdia.TabIndex = 26
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(672, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Procedimientos y Tratamiento"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(672, 222)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 13)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Pendiente en la Próxima Cita"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPendienteDia
        '
        Me.txtPendienteDia.BackColor = System.Drawing.SystemColors.Info
        Me.txtPendienteDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPendienteDia.Location = New System.Drawing.Point(675, 239)
        Me.txtPendienteDia.Multiline = True
        Me.txtPendienteDia.Name = "txtPendienteDia"
        Me.txtPendienteDia.ReadOnly = True
        Me.txtPendienteDia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPendienteDia.Size = New System.Drawing.Size(232, 88)
        Me.txtPendienteDia.TabIndex = 21
        '
        'txtTtoDia
        '
        Me.txtTtoDia.BackColor = System.Drawing.SystemColors.Info
        Me.txtTtoDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTtoDia.Location = New System.Drawing.Point(675, 127)
        Me.txtTtoDia.MaxLength = 1000
        Me.txtTtoDia.Multiline = True
        Me.txtTtoDia.Name = "txtTtoDia"
        Me.txtTtoDia.ReadOnly = True
        Me.txtTtoDia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTtoDia.Size = New System.Drawing.Size(232, 88)
        Me.txtTtoDia.TabIndex = 20
        '
        'txtIDxDia
        '
        Me.txtIDxDia.BackColor = System.Drawing.SystemColors.Info
        Me.txtIDxDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtIDxDia.Location = New System.Drawing.Point(366, 127)
        Me.txtIDxDia.MaxLength = 3000
        Me.txtIDxDia.Multiline = True
        Me.txtIDxDia.Name = "txtIDxDia"
        Me.txtIDxDia.ReadOnly = True
        Me.txtIDxDia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDxDia.Size = New System.Drawing.Size(300, 200)
        Me.txtIDxDia.TabIndex = 19
        '
        'labHonorariosDia
        '
        Me.labHonorariosDia.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosDia.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosDia.Location = New System.Drawing.Point(73, 71)
        Me.labHonorariosDia.Name = "labHonorariosDia"
        Me.labHonorariosDia.Size = New System.Drawing.Size(112, 20)
        Me.labHonorariosDia.TabIndex = 17
        Me.labHonorariosDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Honorarios:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labProximaCitaDia
        '
        Me.labProximaCitaDia.BackColor = System.Drawing.SystemColors.Info
        Me.labProximaCitaDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labProximaCitaDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labProximaCitaDia.Location = New System.Drawing.Point(337, 46)
        Me.labProximaCitaDia.Name = "labProximaCitaDia"
        Me.labProximaCitaDia.Size = New System.Drawing.Size(232, 20)
        Me.labProximaCitaDia.TabIndex = 16
        Me.labProximaCitaDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(279, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Próx Cita:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labLugarDia
        '
        Me.labLugarDia.BackColor = System.Drawing.SystemColors.Info
        Me.labLugarDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labLugarDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labLugarDia.Location = New System.Drawing.Point(73, 46)
        Me.labLugarDia.Name = "labLugarDia"
        Me.labLugarDia.Size = New System.Drawing.Size(200, 20)
        Me.labLugarDia.TabIndex = 14
        Me.labLugarDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Lugar:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labCedulaDia
        '
        Me.labCedulaDia.BackColor = System.Drawing.SystemColors.Info
        Me.labCedulaDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCedulaDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCedulaDia.Location = New System.Drawing.Point(797, 21)
        Me.labCedulaDia.Name = "labCedulaDia"
        Me.labCedulaDia.Size = New System.Drawing.Size(110, 20)
        Me.labCedulaDia.TabIndex = 12
        Me.labCedulaDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(748, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Cédula:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNombreDia
        '
        Me.labNombreDia.BackColor = System.Drawing.SystemColors.Info
        Me.labNombreDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombreDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombreDia.Location = New System.Drawing.Point(337, 21)
        Me.labNombreDia.Name = "labNombreDia"
        Me.labNombreDia.Size = New System.Drawing.Size(405, 20)
        Me.labNombreDia.TabIndex = 10
        Me.labNombreDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(284, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nombre:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNumeroHistoriaDia
        '
        Me.labNumeroHistoriaDia.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroHistoriaDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroHistoriaDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroHistoriaDia.Location = New System.Drawing.Point(73, 21)
        Me.labNumeroHistoriaDia.Name = "labNumeroHistoriaDia"
        Me.labNumeroHistoriaDia.Size = New System.Drawing.Size(200, 20)
        Me.labNumeroHistoriaDia.TabIndex = 8
        Me.labNumeroHistoriaDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Historia #"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosTotalesDia
        '
        Me.labHonorariosTotalesDia.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosTotalesDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosTotalesDia.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosTotalesDia.Location = New System.Drawing.Point(803, 100)
        Me.labHonorariosTotalesDia.Name = "labHonorariosTotalesDia"
        Me.labHonorariosTotalesDia.Size = New System.Drawing.Size(112, 20)
        Me.labHonorariosTotalesDia.TabIndex = 6
        Me.labHonorariosTotalesDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(734, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Honorarios por Consultas del día"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labNumeroPacientesDia
        '
        Me.labNumeroPacientesDia.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroPacientesDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroPacientesDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroPacientesDia.Location = New System.Drawing.Point(803, 44)
        Me.labNumeroPacientesDia.Name = "labNumeroPacientesDia"
        Me.labNumeroPacientesDia.Size = New System.Drawing.Size(112, 20)
        Me.labNumeroPacientesDia.TabIndex = 4
        Me.labNumeroPacientesDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListBoxPacientesDia
        '
        Me.ListBoxPacientesDia.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxPacientesDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxPacientesDia.Location = New System.Drawing.Point(240, 24)
        Me.ListBoxPacientesDia.Name = "ListBoxPacientesDia"
        Me.ListBoxPacientesDia.Size = New System.Drawing.Size(480, 160)
        Me.ListBoxPacientesDia.TabIndex = 1
        '
        'Calendario
        '
        Me.Calendario.Location = New System.Drawing.Point(8, 24)
        Me.Calendario.MaxSelectionCount = 1
        Me.Calendario.Name = "Calendario"
        Me.Calendario.ShowToday = False
        Me.Calendario.ShowTodayCircle = False
        Me.Calendario.TabIndex = 0
        '
        'TabPageProximos
        '
        Me.TabPageProximos.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageProximos.Controls.Add(Me.botImprimeVencidas)
        Me.TabPageProximos.Controls.Add(Me.botImprimeVigentes)
        Me.TabPageProximos.Controls.Add(Me.labTotalProgramadasVencidas)
        Me.TabPageProximos.Controls.Add(Me.Label80)
        Me.TabPageProximos.Controls.Add(Me.Label75)
        Me.TabPageProximos.Controls.Add(Me.ListBoxVencidas)
        Me.TabPageProximos.Controls.Add(Me.Label49)
        Me.TabPageProximos.Controls.Add(Me.GroupBox4)
        Me.TabPageProximos.Controls.Add(Me.labTotalProgramadas)
        Me.TabPageProximos.Controls.Add(Me.Label50)
        Me.TabPageProximos.Controls.Add(Me.ListBoxProximas)
        Me.TabPageProximos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageProximos.Name = "TabPageProximos"
        Me.TabPageProximos.Size = New System.Drawing.Size(962, 580)
        Me.TabPageProximos.TabIndex = 1
        Me.TabPageProximos.Text = "Controles Programados"
        '
        'botImprimeVencidas
        '
        Me.botImprimeVencidas.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botImprimeVencidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImprimeVencidas.Location = New System.Drawing.Point(505, 171)
        Me.botImprimeVencidas.Name = "botImprimeVencidas"
        Me.botImprimeVencidas.Size = New System.Drawing.Size(120, 23)
        Me.botImprimeVencidas.TabIndex = 22
        Me.botImprimeVencidas.Text = "Imprime"
        '
        'botImprimeVigentes
        '
        Me.botImprimeVigentes.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botImprimeVigentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImprimeVigentes.Location = New System.Drawing.Point(8, 171)
        Me.botImprimeVigentes.Name = "botImprimeVigentes"
        Me.botImprimeVigentes.Size = New System.Drawing.Size(120, 23)
        Me.botImprimeVigentes.TabIndex = 21
        Me.botImprimeVigentes.Text = "Imprime"
        '
        'labTotalProgramadasVencidas
        '
        Me.labTotalProgramadasVencidas.BackColor = System.Drawing.Color.MistyRose
        Me.labTotalProgramadasVencidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labTotalProgramadasVencidas.ForeColor = System.Drawing.Color.Black
        Me.labTotalProgramadasVencidas.Location = New System.Drawing.Point(919, 172)
        Me.labTotalProgramadasVencidas.Name = "labTotalProgramadasVencidas"
        Me.labTotalProgramadasVencidas.Size = New System.Drawing.Size(36, 20)
        Me.labTotalProgramadasVencidas.TabIndex = 20
        Me.labTotalProgramadasVencidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(693, 176)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(207, 13)
        Me.Label80.TabIndex = 19
        Me.Label80.Text = "Total de Consultas Programadas Vencidas"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(502, 2)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(165, 13)
        Me.Label75.TabIndex = 18
        Me.Label75.Text = "Consultas Programadas Vencidas"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBoxVencidas
        '
        Me.ListBoxVencidas.BackColor = System.Drawing.Color.MistyRose
        Me.ListBoxVencidas.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxVencidas.ForeColor = System.Drawing.Color.Black
        Me.ListBoxVencidas.ItemHeight = 11
        Me.ListBoxVencidas.Location = New System.Drawing.Point(505, 18)
        Me.ListBoxVencidas.Name = "ListBoxVencidas"
        Me.ListBoxVencidas.Size = New System.Drawing.Size(450, 147)
        Me.ListBoxVencidas.TabIndex = 17
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(5, 2)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(162, 13)
        Me.Label49.TabIndex = 16
        Me.Label49.Text = "Consultas Programadas Vigentes"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtRefirioAproxima)
        Me.GroupBox4.Controls.Add(Me.txtUltimoSMSproxima)
        Me.GroupBox4.Controls.Add(Me.Label116)
        Me.GroupBox4.Controls.Add(Me.txtNotasProxima)
        Me.GroupBox4.Controls.Add(Me.labRefirioAproxima)
        Me.GroupBox4.Controls.Add(Me.labReferidaPorProxima)
        Me.GroupBox4.Controls.Add(Me.Label104)
        Me.GroupBox4.Controls.Add(Me.Label96)
        Me.GroupBox4.Controls.Add(Me.labCelVerificadoProxima)
        Me.GroupBox4.Controls.Add(Me.Label92)
        Me.GroupBox4.Controls.Add(Me.Label85)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.txtAUTOproxima)
        Me.GroupBox4.Controls.Add(Me.labTelefonoProxima)
        Me.GroupBox4.Controls.Add(Me.Label82)
        Me.GroupBox4.Controls.Add(Me.txtTtoProxima)
        Me.GroupBox4.Controls.Add(Me.txtIDxProxima)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.txtPendienteProxima)
        Me.GroupBox4.Controls.Add(Me.labHonorariosProxima)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.labFechaConsultaProxima)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.labLugarProxima)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.labCedulaProxima)
        Me.GroupBox4.Controls.Add(Me.Label44)
        Me.GroupBox4.Controls.Add(Me.labNombreProxima)
        Me.GroupBox4.Controls.Add(Me.Label46)
        Me.GroupBox4.Controls.Add(Me.labNumeroHistoriaProxima)
        Me.GroupBox4.Controls.Add(Me.Label48)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(947, 377)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Consulta Programada Seleccionada"
        '
        'txtRefirioAproxima
        '
        Me.txtRefirioAproxima.BackColor = System.Drawing.SystemColors.Info
        Me.txtRefirioAproxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtRefirioAproxima.Location = New System.Drawing.Point(13, 195)
        Me.txtRefirioAproxima.MaxLength = 3000
        Me.txtRefirioAproxima.Multiline = True
        Me.txtRefirioAproxima.Name = "txtRefirioAproxima"
        Me.txtRefirioAproxima.ReadOnly = True
        Me.txtRefirioAproxima.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRefirioAproxima.Size = New System.Drawing.Size(331, 65)
        Me.txtRefirioAproxima.TabIndex = 42
        '
        'txtUltimoSMSproxima
        '
        Me.txtUltimoSMSproxima.BackColor = System.Drawing.SystemColors.Info
        Me.txtUltimoSMSproxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtUltimoSMSproxima.Location = New System.Drawing.Point(299, 62)
        Me.txtUltimoSMSproxima.MaxLength = 3000
        Me.txtUltimoSMSproxima.Multiline = True
        Me.txtUltimoSMSproxima.Name = "txtUltimoSMSproxima"
        Me.txtUltimoSMSproxima.ReadOnly = True
        Me.txtUltimoSMSproxima.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUltimoSMSproxima.Size = New System.Drawing.Size(642, 70)
        Me.txtUltimoSMSproxima.TabIndex = 41
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Location = New System.Drawing.Point(11, 265)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(117, 13)
        Me.Label116.TabIndex = 40
        Me.Label116.Text = "Notas y Observaciones"
        Me.Label116.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNotasProxima
        '
        Me.txtNotasProxima.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotasProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtNotasProxima.Location = New System.Drawing.Point(13, 282)
        Me.txtNotasProxima.MaxLength = 3000
        Me.txtNotasProxima.Multiline = True
        Me.txtNotasProxima.Name = "txtNotasProxima"
        Me.txtNotasProxima.ReadOnly = True
        Me.txtNotasProxima.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotasProxima.Size = New System.Drawing.Size(331, 87)
        Me.txtNotasProxima.TabIndex = 39
        '
        'labRefirioAproxima
        '
        Me.labRefirioAproxima.AutoSize = True
        Me.labRefirioAproxima.Location = New System.Drawing.Point(11, 178)
        Me.labRefirioAproxima.Name = "labRefirioAproxima"
        Me.labRefirioAproxima.Size = New System.Drawing.Size(49, 13)
        Me.labRefirioAproxima.TabIndex = 37
        Me.labRefirioAproxima.Text = "Refirio a:"
        Me.labRefirioAproxima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labReferidaPorProxima
        '
        Me.labReferidaPorProxima.BackColor = System.Drawing.SystemColors.Info
        Me.labReferidaPorProxima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labReferidaPorProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labReferidaPorProxima.Location = New System.Drawing.Point(14, 153)
        Me.labReferidaPorProxima.Name = "labReferidaPorProxima"
        Me.labReferidaPorProxima.Size = New System.Drawing.Size(330, 20)
        Me.labReferidaPorProxima.TabIndex = 36
        Me.labReferidaPorProxima.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Location = New System.Drawing.Point(11, 136)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(68, 13)
        Me.Label104.TabIndex = 35
        Me.Label104.Text = "Referida por:"
        Me.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(231, 67)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(62, 13)
        Me.Label96.TabIndex = 33
        Me.Label96.Text = "Ultimo SMS"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labCelVerificadoProxima
        '
        Me.labCelVerificadoProxima.BackColor = System.Drawing.SystemColors.Info
        Me.labCelVerificadoProxima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCelVerificadoProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCelVerificadoProxima.Location = New System.Drawing.Point(108, 86)
        Me.labCelVerificadoProxima.Name = "labCelVerificadoProxima"
        Me.labCelVerificadoProxima.Size = New System.Drawing.Size(100, 20)
        Me.labCelVerificadoProxima.TabIndex = 32
        Me.labCelVerificadoProxima.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(29, 91)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(68, 13)
        Me.Label92.TabIndex = 31
        Me.Label92.Text = "Verificado el:"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(356, 265)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(179, 13)
        Me.Label85.TabIndex = 30
        Me.Label85.Text = "Signos Subjetivos y Datos Manuales"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(356, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(200, 13)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "Signos Objetivos y Datos Autogenerados"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAUTOproxima
        '
        Me.txtAUTOproxima.BackColor = System.Drawing.SystemColors.Info
        Me.txtAUTOproxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtAUTOproxima.Location = New System.Drawing.Point(359, 153)
        Me.txtAUTOproxima.MaxLength = 3000
        Me.txtAUTOproxima.Multiline = True
        Me.txtAUTOproxima.Name = "txtAUTOproxima"
        Me.txtAUTOproxima.ReadOnly = True
        Me.txtAUTOproxima.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAUTOproxima.Size = New System.Drawing.Size(300, 109)
        Me.txtAUTOproxima.TabIndex = 28
        '
        'labTelefonoProxima
        '
        Me.labTelefonoProxima.BackColor = System.Drawing.SystemColors.Info
        Me.labTelefonoProxima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labTelefonoProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labTelefonoProxima.Location = New System.Drawing.Point(108, 62)
        Me.labTelefonoProxima.Name = "labTelefonoProxima"
        Me.labTelefonoProxima.Size = New System.Drawing.Size(100, 20)
        Me.labTelefonoProxima.TabIndex = 26
        Me.labTelefonoProxima.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(8, 67)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(89, 13)
        Me.Label82.TabIndex = 25
        Me.Label82.Text = "Teléfono/Celular:"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTtoProxima
        '
        Me.txtTtoProxima.BackColor = System.Drawing.SystemColors.Info
        Me.txtTtoProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTtoProxima.Location = New System.Drawing.Point(700, 153)
        Me.txtTtoProxima.MaxLength = 3000
        Me.txtTtoProxima.Multiline = True
        Me.txtTtoProxima.Name = "txtTtoProxima"
        Me.txtTtoProxima.ReadOnly = True
        Me.txtTtoProxima.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTtoProxima.Size = New System.Drawing.Size(232, 109)
        Me.txtTtoProxima.TabIndex = 20
        '
        'txtIDxProxima
        '
        Me.txtIDxProxima.BackColor = System.Drawing.SystemColors.Info
        Me.txtIDxProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtIDxProxima.Location = New System.Drawing.Point(359, 282)
        Me.txtIDxProxima.MaxLength = 3000
        Me.txtIDxProxima.Multiline = True
        Me.txtIDxProxima.Name = "txtIDxProxima"
        Me.txtIDxProxima.ReadOnly = True
        Me.txtIDxProxima.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDxProxima.Size = New System.Drawing.Size(300, 89)
        Me.txtIDxProxima.TabIndex = 19
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(697, 265)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(95, 13)
        Me.Label26.TabIndex = 24
        Me.Label26.Text = "Quedó pendiente :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(697, 136)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(130, 13)
        Me.Label30.TabIndex = 23
        Me.Label30.Text = "Tratamiento indicado fue :"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPendienteProxima
        '
        Me.txtPendienteProxima.BackColor = System.Drawing.SystemColors.Info
        Me.txtPendienteProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPendienteProxima.Location = New System.Drawing.Point(700, 282)
        Me.txtPendienteProxima.MaxLength = 3000
        Me.txtPendienteProxima.Multiline = True
        Me.txtPendienteProxima.Name = "txtPendienteProxima"
        Me.txtPendienteProxima.ReadOnly = True
        Me.txtPendienteProxima.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPendienteProxima.Size = New System.Drawing.Size(232, 88)
        Me.txtPendienteProxima.TabIndex = 21
        '
        'labHonorariosProxima
        '
        Me.labHonorariosProxima.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosProxima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosProxima.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosProxima.Location = New System.Drawing.Point(841, 39)
        Me.labHonorariosProxima.Name = "labHonorariosProxima"
        Me.labHonorariosProxima.Size = New System.Drawing.Size(100, 20)
        Me.labHonorariosProxima.TabIndex = 17
        Me.labHonorariosProxima.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(774, 44)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(61, 13)
        Me.Label36.TabIndex = 18
        Me.Label36.Text = "Honorarios:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labFechaConsultaProxima
        '
        Me.labFechaConsultaProxima.BackColor = System.Drawing.SystemColors.Info
        Me.labFechaConsultaProxima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFechaConsultaProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFechaConsultaProxima.Location = New System.Drawing.Point(108, 39)
        Me.labFechaConsultaProxima.Name = "labFechaConsultaProxima"
        Me.labFechaConsultaProxima.Size = New System.Drawing.Size(268, 20)
        Me.labFechaConsultaProxima.TabIndex = 16
        Me.labFechaConsultaProxima.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(3, 44)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(94, 13)
        Me.Label40.TabIndex = 15
        Me.Label40.Text = "Ultima Consulta el:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labLugarProxima
        '
        Me.labLugarProxima.BackColor = System.Drawing.SystemColors.Info
        Me.labLugarProxima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labLugarProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labLugarProxima.Location = New System.Drawing.Point(459, 39)
        Me.labLugarProxima.Name = "labLugarProxima"
        Me.labLugarProxima.Size = New System.Drawing.Size(309, 20)
        Me.labLugarProxima.TabIndex = 14
        Me.labLugarProxima.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(385, 44)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(68, 13)
        Me.Label42.TabIndex = 13
        Me.Label42.Text = "Fue vista en:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labCedulaProxima
        '
        Me.labCedulaProxima.BackColor = System.Drawing.SystemColors.Info
        Me.labCedulaProxima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCedulaProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCedulaProxima.Location = New System.Drawing.Point(841, 16)
        Me.labCedulaProxima.Name = "labCedulaProxima"
        Me.labCedulaProxima.Size = New System.Drawing.Size(100, 20)
        Me.labCedulaProxima.TabIndex = 12
        Me.labCedulaProxima.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(792, 21)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(43, 13)
        Me.Label44.TabIndex = 11
        Me.Label44.Text = "Cédula:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNombreProxima
        '
        Me.labNombreProxima.BackColor = System.Drawing.SystemColors.Info
        Me.labNombreProxima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombreProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombreProxima.Location = New System.Drawing.Point(351, 16)
        Me.labNombreProxima.Name = "labNombreProxima"
        Me.labNombreProxima.Size = New System.Drawing.Size(417, 20)
        Me.labNombreProxima.TabIndex = 10
        Me.labNombreProxima.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(297, 21)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(47, 13)
        Me.Label46.TabIndex = 9
        Me.Label46.Text = "Nombre:"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNumeroHistoriaProxima
        '
        Me.labNumeroHistoriaProxima.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroHistoriaProxima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroHistoriaProxima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroHistoriaProxima.Location = New System.Drawing.Point(108, 16)
        Me.labNumeroHistoriaProxima.Name = "labNumeroHistoriaProxima"
        Me.labNumeroHistoriaProxima.Size = New System.Drawing.Size(163, 20)
        Me.labNumeroHistoriaProxima.TabIndex = 8
        Me.labNumeroHistoriaProxima.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(45, 21)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(52, 13)
        Me.Label48.TabIndex = 7
        Me.Label48.Text = "Historia #"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTotalProgramadas
        '
        Me.labTotalProgramadas.BackColor = System.Drawing.Color.LightCyan
        Me.labTotalProgramadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labTotalProgramadas.ForeColor = System.Drawing.Color.Black
        Me.labTotalProgramadas.Location = New System.Drawing.Point(422, 172)
        Me.labTotalProgramadas.Name = "labTotalProgramadas"
        Me.labTotalProgramadas.Size = New System.Drawing.Size(36, 20)
        Me.labTotalProgramadas.TabIndex = 14
        Me.labTotalProgramadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(194, 176)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(204, 13)
        Me.Label50.TabIndex = 13
        Me.Label50.Text = "Total de Consultas Programadas Vigentes"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListBoxProximas
        '
        Me.ListBoxProximas.BackColor = System.Drawing.Color.LightCyan
        Me.ListBoxProximas.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxProximas.ForeColor = System.Drawing.Color.Black
        Me.ListBoxProximas.ItemHeight = 11
        Me.ListBoxProximas.Location = New System.Drawing.Point(8, 18)
        Me.ListBoxProximas.Name = "ListBoxProximas"
        Me.ListBoxProximas.Size = New System.Drawing.Size(450, 147)
        Me.ListBoxProximas.TabIndex = 12
        '
        'TabPagePacientes
        '
        Me.TabPagePacientes.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePacientes.Controls.Add(Me.botImprimePacientes)
        Me.TabPagePacientes.Controls.Add(Me.labNumeroConsultasPaciente)
        Me.TabPagePacientes.Controls.Add(Me.Label53)
        Me.TabPagePacientes.Controls.Add(Me.labHonorariosTotalesPaciente)
        Me.TabPagePacientes.Controls.Add(Me.Label38)
        Me.TabPagePacientes.Controls.Add(Me.GroupBox5)
        Me.TabPagePacientes.Controls.Add(Me.txtFiltro)
        Me.TabPagePacientes.Controls.Add(Me.Label41)
        Me.TabPagePacientes.Controls.Add(Me.labConsultas)
        Me.TabPagePacientes.Controls.Add(Me.listBoxConsultas)
        Me.TabPagePacientes.Controls.Add(Me.ListBoxPacientes)
        Me.TabPagePacientes.Controls.Add(Me.labFiltro)
        Me.TabPagePacientes.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePacientes.Name = "TabPagePacientes"
        Me.TabPagePacientes.Size = New System.Drawing.Size(962, 580)
        Me.TabPagePacientes.TabIndex = 3
        Me.TabPagePacientes.Text = "Controles por Paciente"
        '
        'botImprimePacientes
        '
        Me.botImprimePacientes.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botImprimePacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImprimePacientes.Location = New System.Drawing.Point(788, 202)
        Me.botImprimePacientes.Name = "botImprimePacientes"
        Me.botImprimePacientes.Size = New System.Drawing.Size(120, 23)
        Me.botImprimePacientes.TabIndex = 23
        Me.botImprimePacientes.Text = "Imprime"
        '
        'labNumeroConsultasPaciente
        '
        Me.labNumeroConsultasPaciente.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroConsultasPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroConsultasPaciente.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroConsultasPaciente.Location = New System.Drawing.Point(788, 110)
        Me.labNumeroConsultasPaciente.Name = "labNumeroConsultasPaciente"
        Me.labNumeroConsultasPaciente.Size = New System.Drawing.Size(32, 20)
        Me.labNumeroConsultasPaciente.TabIndex = 22
        Me.labNumeroConsultasPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(785, 90)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(80, 20)
        Me.Label53.TabIndex = 21
        Me.Label53.Text = "# de Consultas"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosTotalesPaciente
        '
        Me.labHonorariosTotalesPaciente.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosTotalesPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosTotalesPaciente.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosTotalesPaciente.Location = New System.Drawing.Point(788, 170)
        Me.labHonorariosTotalesPaciente.Name = "labHonorariosTotalesPaciente"
        Me.labHonorariosTotalesPaciente.Size = New System.Drawing.Size(96, 20)
        Me.labHonorariosTotalesPaciente.TabIndex = 19
        Me.labHonorariosTotalesPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(785, 150)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(64, 20)
        Me.Label38.TabIndex = 20
        Me.Label38.Text = "Honorarios:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label47)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.txtAUTOpaciente)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.txtPendientePaciente)
        Me.GroupBox5.Controls.Add(Me.txtTtoPaciente)
        Me.GroupBox5.Controls.Add(Me.txtIDxPaciente)
        Me.GroupBox5.Controls.Add(Me.labHonorariosPaciente)
        Me.GroupBox5.Controls.Add(Me.Label52)
        Me.GroupBox5.Controls.Add(Me.labProximaPaciente)
        Me.GroupBox5.Controls.Add(Me.Label54)
        Me.GroupBox5.Controls.Add(Me.labLugarPaciente)
        Me.GroupBox5.Controls.Add(Me.Label56)
        Me.GroupBox5.Controls.Add(Me.labFechaConsultaPaciente)
        Me.GroupBox5.Controls.Add(Me.Label62)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 231)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(947, 346)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Consulta Seleccionada"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(371, 69)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(179, 13)
        Me.Label47.TabIndex = 31
        Me.Label47.Text = "Signos Subjetivos y Datos Manuales"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(16, 69)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(200, 13)
        Me.Label32.TabIndex = 30
        Me.Label32.Text = "Signos Objetivos y Datos Autogenerados"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAUTOpaciente
        '
        Me.txtAUTOpaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtAUTOpaciente.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtAUTOpaciente.Location = New System.Drawing.Point(19, 88)
        Me.txtAUTOpaciente.Multiline = True
        Me.txtAUTOpaciente.Name = "txtAUTOpaciente"
        Me.txtAUTOpaciente.ReadOnly = True
        Me.txtAUTOpaciente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAUTOpaciente.Size = New System.Drawing.Size(300, 217)
        Me.txtAUTOpaciente.TabIndex = 29
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(704, 191)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(160, 23)
        Me.Label43.TabIndex = 24
        Me.Label43.Text = "Pendiente en la Próxima Cita"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(704, 64)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(80, 23)
        Me.Label45.TabIndex = 23
        Me.Label45.Text = "Tratamiento"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPendientePaciente
        '
        Me.txtPendientePaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtPendientePaciente.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPendientePaciente.Location = New System.Drawing.Point(707, 217)
        Me.txtPendientePaciente.Multiline = True
        Me.txtPendientePaciente.Name = "txtPendientePaciente"
        Me.txtPendientePaciente.ReadOnly = True
        Me.txtPendientePaciente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPendientePaciente.Size = New System.Drawing.Size(232, 88)
        Me.txtPendientePaciente.TabIndex = 21
        '
        'txtTtoPaciente
        '
        Me.txtTtoPaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtTtoPaciente.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTtoPaciente.Location = New System.Drawing.Point(707, 88)
        Me.txtTtoPaciente.Multiline = True
        Me.txtTtoPaciente.Name = "txtTtoPaciente"
        Me.txtTtoPaciente.ReadOnly = True
        Me.txtTtoPaciente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTtoPaciente.Size = New System.Drawing.Size(232, 88)
        Me.txtTtoPaciente.TabIndex = 20
        '
        'txtIDxPaciente
        '
        Me.txtIDxPaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtIDxPaciente.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtIDxPaciente.Location = New System.Drawing.Point(374, 88)
        Me.txtIDxPaciente.Multiline = True
        Me.txtIDxPaciente.Name = "txtIDxPaciente"
        Me.txtIDxPaciente.ReadOnly = True
        Me.txtIDxPaciente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDxPaciente.Size = New System.Drawing.Size(300, 217)
        Me.txtIDxPaciente.TabIndex = 19
        '
        'labHonorariosPaciente
        '
        Me.labHonorariosPaciente.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPaciente.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosPaciente.Location = New System.Drawing.Point(128, 40)
        Me.labHonorariosPaciente.Name = "labHonorariosPaciente"
        Me.labHonorariosPaciente.Size = New System.Drawing.Size(112, 20)
        Me.labHonorariosPaciente.TabIndex = 17
        Me.labHonorariosPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.Location = New System.Drawing.Point(64, 40)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(64, 20)
        Me.Label52.TabIndex = 18
        Me.Label52.Text = "Honorarios:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labProximaPaciente
        '
        Me.labProximaPaciente.BackColor = System.Drawing.SystemColors.Info
        Me.labProximaPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labProximaPaciente.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labProximaPaciente.Location = New System.Drawing.Point(637, 40)
        Me.labProximaPaciente.Name = "labProximaPaciente"
        Me.labProximaPaciente.Size = New System.Drawing.Size(304, 20)
        Me.labProximaPaciente.TabIndex = 16
        Me.labProximaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(575, 40)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(56, 20)
        Me.Label54.TabIndex = 15
        Me.Label54.Text = "Próx Cita:"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labLugarPaciente
        '
        Me.labLugarPaciente.BackColor = System.Drawing.SystemColors.Info
        Me.labLugarPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labLugarPaciente.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labLugarPaciente.Location = New System.Drawing.Point(637, 16)
        Me.labLugarPaciente.Name = "labLugarPaciente"
        Me.labLugarPaciente.Size = New System.Drawing.Size(304, 20)
        Me.labLugarPaciente.TabIndex = 14
        Me.labLugarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(591, 16)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(40, 20)
        Me.Label56.TabIndex = 13
        Me.Label56.Text = "Lugar:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labFechaConsultaPaciente
        '
        Me.labFechaConsultaPaciente.BackColor = System.Drawing.SystemColors.Info
        Me.labFechaConsultaPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFechaConsultaPaciente.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFechaConsultaPaciente.Location = New System.Drawing.Point(128, 16)
        Me.labFechaConsultaPaciente.Name = "labFechaConsultaPaciente"
        Me.labFechaConsultaPaciente.Size = New System.Drawing.Size(232, 20)
        Me.labFechaConsultaPaciente.TabIndex = 8
        Me.labFechaConsultaPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(16, 16)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(112, 20)
        Me.Label62.TabIndex = 7
        Me.Label62.Text = "Fecha de la Consulta"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(48, 8)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(200, 20)
        Me.txtFiltro.TabIndex = 6
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(8, 8)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(40, 23)
        Me.Label41.TabIndex = 7
        Me.Label41.Text = "Filtro :"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labConsultas
        '
        Me.labConsultas.Location = New System.Drawing.Point(480, 32)
        Me.labConsultas.Name = "labConsultas"
        Me.labConsultas.Size = New System.Drawing.Size(280, 20)
        Me.labConsultas.TabIndex = 5
        Me.labConsultas.Text = "Consultas Archivadas"
        Me.labConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'listBoxConsultas
        '
        Me.listBoxConsultas.BackColor = System.Drawing.SystemColors.Info
        Me.listBoxConsultas.Enabled = False
        Me.listBoxConsultas.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBoxConsultas.ForeColor = System.Drawing.SystemColors.InfoText
        Me.listBoxConsultas.ItemHeight = 11
        Me.listBoxConsultas.Location = New System.Drawing.Point(480, 56)
        Me.listBoxConsultas.Name = "listBoxConsultas"
        Me.listBoxConsultas.Size = New System.Drawing.Size(280, 169)
        Me.listBoxConsultas.TabIndex = 4
        '
        'ListBoxPacientes
        '
        Me.ListBoxPacientes.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxPacientes.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPacientes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxPacientes.ItemHeight = 11
        Me.ListBoxPacientes.Location = New System.Drawing.Point(8, 56)
        Me.ListBoxPacientes.Name = "ListBoxPacientes"
        Me.ListBoxPacientes.Size = New System.Drawing.Size(464, 169)
        Me.ListBoxPacientes.TabIndex = 0
        '
        'labFiltro
        '
        Me.labFiltro.Location = New System.Drawing.Point(8, 32)
        Me.labFiltro.Name = "labFiltro"
        Me.labFiltro.Size = New System.Drawing.Size(464, 20)
        Me.labFiltro.TabIndex = 3
        Me.labFiltro.Text = "Pacientes de la Base de Datos"
        Me.labFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPageIntervenciones
        '
        Me.TabPageIntervenciones.AutoScroll = True
        Me.TabPageIntervenciones.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageIntervenciones.Controls.Add(Me.PanelIQaño)
        Me.TabPageIntervenciones.Controls.Add(Me.PanelIQmes)
        Me.TabPageIntervenciones.Controls.Add(Me.radIQaño)
        Me.TabPageIntervenciones.Controls.Add(Me.radIQmes)
        Me.TabPageIntervenciones.Controls.Add(Me.radIQdia)
        Me.TabPageIntervenciones.Controls.Add(Me.PanelIQdia)
        Me.TabPageIntervenciones.Location = New System.Drawing.Point(4, 22)
        Me.TabPageIntervenciones.Name = "TabPageIntervenciones"
        Me.TabPageIntervenciones.Size = New System.Drawing.Size(962, 580)
        Me.TabPageIntervenciones.TabIndex = 4
        Me.TabPageIntervenciones.Text = "Intervenciones"
        '
        'PanelIQaño
        '
        Me.PanelIQaño.Controls.Add(Me.botImprimeIQaño)
        Me.PanelIQaño.Controls.Add(Me.GroupBox8)
        Me.PanelIQaño.Controls.Add(Me.labHonorariosTotalesIQaño)
        Me.PanelIQaño.Controls.Add(Me.Label70)
        Me.PanelIQaño.Controls.Add(Me.labHonorariosPagadosTotalesIQaño)
        Me.PanelIQaño.Controls.Add(Me.Label74)
        Me.PanelIQaño.Controls.Add(Me.labHonorariosPendientesTotalesIQaño)
        Me.PanelIQaño.Controls.Add(Me.Label90)
        Me.PanelIQaño.Controls.Add(Me.labNumeroIQaño)
        Me.PanelIQaño.Controls.Add(Me.Label94)
        Me.PanelIQaño.Controls.Add(Me.Panel3)
        Me.PanelIQaño.Controls.Add(Me.ListBoxIQaño)
        Me.PanelIQaño.Location = New System.Drawing.Point(8, 1204)
        Me.PanelIQaño.Name = "PanelIQaño"
        Me.PanelIQaño.Size = New System.Drawing.Size(934, 541)
        Me.PanelIQaño.TabIndex = 11
        '
        'botImprimeIQaño
        '
        Me.botImprimeIQaño.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botImprimeIQaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImprimeIQaño.Location = New System.Drawing.Point(248, 144)
        Me.botImprimeIQaño.Name = "botImprimeIQaño"
        Me.botImprimeIQaño.Size = New System.Drawing.Size(120, 23)
        Me.botImprimeIQaño.TabIndex = 35
        Me.botImprimeIQaño.Text = "Imprime"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.labCedulaIQaño)
        Me.GroupBox8.Controls.Add(Me.labFechaNacimientoIQaño)
        Me.GroupBox8.Controls.Add(Me.Label102)
        Me.GroupBox8.Controls.Add(Me.Label103)
        Me.GroupBox8.Controls.Add(Me.txtNotasIQaño)
        Me.GroupBox8.Controls.Add(Me.labFormaPagoIQaño)
        Me.GroupBox8.Controls.Add(Me.labRolMedico2IQaño)
        Me.GroupBox8.Controls.Add(Me.labRolMedico1IQaño)
        Me.GroupBox8.Controls.Add(Me.labRolIQaño)
        Me.GroupBox8.Controls.Add(Me.labHonorariosPagadosIQaño)
        Me.GroupBox8.Controls.Add(Me.labHonorariosPendientesIQaño)
        Me.GroupBox8.Controls.Add(Me.labLugarIQaño)
        Me.GroupBox8.Controls.Add(Me.labMedico2IQaño)
        Me.GroupBox8.Controls.Add(Me.labMedico1IQaño)
        Me.GroupBox8.Controls.Add(Me.labTipoIQaño)
        Me.GroupBox8.Controls.Add(Me.Label105)
        Me.GroupBox8.Controls.Add(Me.Label106)
        Me.GroupBox8.Controls.Add(Me.Label107)
        Me.GroupBox8.Controls.Add(Me.Label108)
        Me.GroupBox8.Controls.Add(Me.Label109)
        Me.GroupBox8.Controls.Add(Me.Label110)
        Me.GroupBox8.Controls.Add(Me.Label111)
        Me.GroupBox8.Controls.Add(Me.Label112)
        Me.GroupBox8.Controls.Add(Me.Label113)
        Me.GroupBox8.Controls.Add(Me.Label114)
        Me.GroupBox8.Controls.Add(Me.Label115)
        Me.GroupBox8.Controls.Add(Me.labEdadIQaño)
        Me.GroupBox8.Controls.Add(Me.Label117)
        Me.GroupBox8.Controls.Add(Me.labNombreIQaño)
        Me.GroupBox8.Controls.Add(Me.Label119)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 275)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(913, 250)
        Me.GroupBox8.TabIndex = 34
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Intervención Seleccionada"
        '
        'labCedulaIQaño
        '
        Me.labCedulaIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labCedulaIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCedulaIQaño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCedulaIQaño.Location = New System.Drawing.Point(144, 219)
        Me.labCedulaIQaño.Name = "labCedulaIQaño"
        Me.labCedulaIQaño.Size = New System.Drawing.Size(136, 20)
        Me.labCedulaIQaño.TabIndex = 61
        Me.labCedulaIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labFechaNacimientoIQaño
        '
        Me.labFechaNacimientoIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labFechaNacimientoIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFechaNacimientoIQaño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFechaNacimientoIQaño.Location = New System.Drawing.Point(144, 195)
        Me.labFechaNacimientoIQaño.Name = "labFechaNacimientoIQaño"
        Me.labFechaNacimientoIQaño.Size = New System.Drawing.Size(136, 20)
        Me.labFechaNacimientoIQaño.TabIndex = 60
        Me.labFechaNacimientoIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(93, 223)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(43, 13)
        Me.Label102.TabIndex = 59
        Me.Label102.Text = "Cédula:"
        Me.Label102.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Location = New System.Drawing.Point(25, 199)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(111, 13)
        Me.Label103.TabIndex = 58
        Me.Label103.Text = "Fecha de Nacimiento:"
        Me.Label103.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNotasIQaño
        '
        Me.txtNotasIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotasIQaño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtNotasIQaño.Location = New System.Drawing.Point(144, 160)
        Me.txtNotasIQaño.Multiline = True
        Me.txtNotasIQaño.Name = "txtNotasIQaño"
        Me.txtNotasIQaño.ReadOnly = True
        Me.txtNotasIQaño.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotasIQaño.Size = New System.Drawing.Size(568, 32)
        Me.txtNotasIQaño.TabIndex = 53
        '
        'labFormaPagoIQaño
        '
        Me.labFormaPagoIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labFormaPagoIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFormaPagoIQaño.Location = New System.Drawing.Point(536, 112)
        Me.labFormaPagoIQaño.Name = "labFormaPagoIQaño"
        Me.labFormaPagoIQaño.Size = New System.Drawing.Size(176, 20)
        Me.labFormaPagoIQaño.TabIndex = 51
        Me.labFormaPagoIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRolMedico2IQaño
        '
        Me.labRolMedico2IQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labRolMedico2IQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRolMedico2IQaño.Location = New System.Drawing.Point(576, 88)
        Me.labRolMedico2IQaño.Name = "labRolMedico2IQaño"
        Me.labRolMedico2IQaño.Size = New System.Drawing.Size(136, 20)
        Me.labRolMedico2IQaño.TabIndex = 50
        Me.labRolMedico2IQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRolMedico1IQaño
        '
        Me.labRolMedico1IQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labRolMedico1IQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRolMedico1IQaño.Location = New System.Drawing.Point(576, 64)
        Me.labRolMedico1IQaño.Name = "labRolMedico1IQaño"
        Me.labRolMedico1IQaño.Size = New System.Drawing.Size(136, 20)
        Me.labRolMedico1IQaño.TabIndex = 49
        Me.labRolMedico1IQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRolIQaño
        '
        Me.labRolIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labRolIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRolIQaño.Location = New System.Drawing.Point(576, 40)
        Me.labRolIQaño.Name = "labRolIQaño"
        Me.labRolIQaño.Size = New System.Drawing.Size(136, 20)
        Me.labRolIQaño.TabIndex = 48
        Me.labRolIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosPagadosIQaño
        '
        Me.labHonorariosPagadosIQaño.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosPagadosIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPagadosIQaño.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosPagadosIQaño.Location = New System.Drawing.Point(536, 136)
        Me.labHonorariosPagadosIQaño.Name = "labHonorariosPagadosIQaño"
        Me.labHonorariosPagadosIQaño.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosPagadosIQaño.TabIndex = 47
        Me.labHonorariosPagadosIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labHonorariosPendientesIQaño
        '
        Me.labHonorariosPendientesIQaño.BackColor = System.Drawing.Color.MistyRose
        Me.labHonorariosPendientesIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPendientesIQaño.Location = New System.Drawing.Point(144, 136)
        Me.labHonorariosPendientesIQaño.Name = "labHonorariosPendientesIQaño"
        Me.labHonorariosPendientesIQaño.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosPendientesIQaño.TabIndex = 46
        Me.labHonorariosPendientesIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labLugarIQaño
        '
        Me.labLugarIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labLugarIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labLugarIQaño.Location = New System.Drawing.Point(120, 112)
        Me.labLugarIQaño.Name = "labLugarIQaño"
        Me.labLugarIQaño.Size = New System.Drawing.Size(320, 20)
        Me.labLugarIQaño.TabIndex = 44
        Me.labLugarIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labMedico2IQaño
        '
        Me.labMedico2IQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labMedico2IQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMedico2IQaño.Location = New System.Drawing.Point(120, 88)
        Me.labMedico2IQaño.Name = "labMedico2IQaño"
        Me.labMedico2IQaño.Size = New System.Drawing.Size(320, 20)
        Me.labMedico2IQaño.TabIndex = 43
        Me.labMedico2IQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labMedico1IQaño
        '
        Me.labMedico1IQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labMedico1IQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMedico1IQaño.Location = New System.Drawing.Point(120, 64)
        Me.labMedico1IQaño.Name = "labMedico1IQaño"
        Me.labMedico1IQaño.Size = New System.Drawing.Size(320, 20)
        Me.labMedico1IQaño.TabIndex = 42
        Me.labMedico1IQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTipoIQaño
        '
        Me.labTipoIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labTipoIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labTipoIQaño.Location = New System.Drawing.Point(120, 40)
        Me.labTipoIQaño.Name = "labTipoIQaño"
        Me.labTipoIQaño.Size = New System.Drawing.Size(320, 20)
        Me.labTipoIQaño.TabIndex = 41
        Me.labTipoIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label105
        '
        Me.Label105.Location = New System.Drawing.Point(8, 160)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(128, 20)
        Me.Label105.TabIndex = 40
        Me.Label105.Text = "Notas y Observaciones"
        Me.Label105.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label106
        '
        Me.Label106.Location = New System.Drawing.Point(400, 136)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(144, 20)
        Me.Label106.TabIndex = 39
        Me.Label106.Text = "Honorarios netos pagados :"
        Me.Label106.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label107
        '
        Me.Label107.Location = New System.Drawing.Point(8, 136)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(128, 20)
        Me.Label107.TabIndex = 38
        Me.Label107.Text = "Honorarios  estimados :"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label108
        '
        Me.Label108.Location = New System.Drawing.Point(448, 112)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(88, 20)
        Me.Label108.TabIndex = 37
        Me.Label108.Text = "Forma de Pago :"
        Me.Label108.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label109
        '
        Me.Label109.Location = New System.Drawing.Point(448, 88)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(136, 20)
        Me.Label109.TabIndex = 36
        Me.Label109.Text = "Rol del Acompañante #2 :"
        Me.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label110
        '
        Me.Label110.Location = New System.Drawing.Point(8, 112)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(112, 20)
        Me.Label110.TabIndex = 35
        Me.Label110.Text = "La IQ se realizó en :"
        Me.Label110.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label111
        '
        Me.Label111.Location = New System.Drawing.Point(448, 64)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(136, 20)
        Me.Label111.TabIndex = 34
        Me.Label111.Text = "Rol del Acompañante #1 :"
        Me.Label111.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label112
        '
        Me.Label112.Location = New System.Drawing.Point(8, 88)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(104, 20)
        Me.Label112.TabIndex = 33
        Me.Label112.Text = "Acompañante #2 :"
        Me.Label112.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label113
        '
        Me.Label113.Location = New System.Drawing.Point(8, 64)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(104, 20)
        Me.Label113.TabIndex = 32
        Me.Label113.Text = "Acompañante #1 :"
        Me.Label113.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label114
        '
        Me.Label114.Location = New System.Drawing.Point(448, 40)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(120, 20)
        Me.Label114.TabIndex = 31
        Me.Label114.Text = "Rol en la Intervención :"
        Me.Label114.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label115
        '
        Me.Label115.Location = New System.Drawing.Point(8, 40)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(120, 20)
        Me.Label115.TabIndex = 30
        Me.Label115.Text = "Tipo de Intervención :"
        Me.Label115.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labEdadIQaño
        '
        Me.labEdadIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labEdadIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEdadIQaño.Location = New System.Drawing.Point(672, 16)
        Me.labEdadIQaño.Name = "labEdadIQaño"
        Me.labEdadIQaño.Size = New System.Drawing.Size(40, 20)
        Me.labEdadIQaño.TabIndex = 12
        Me.labEdadIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label117
        '
        Me.Label117.Location = New System.Drawing.Point(624, 16)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(48, 20)
        Me.Label117.TabIndex = 11
        Me.Label117.Text = "Edad:"
        Me.Label117.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNombreIQaño
        '
        Me.labNombreIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labNombreIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombreIQaño.Location = New System.Drawing.Point(56, 16)
        Me.labNombreIQaño.Name = "labNombreIQaño"
        Me.labNombreIQaño.Size = New System.Drawing.Size(560, 20)
        Me.labNombreIQaño.TabIndex = 10
        Me.labNombreIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label119
        '
        Me.Label119.Location = New System.Drawing.Point(8, 16)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(48, 20)
        Me.Label119.TabIndex = 9
        Me.Label119.Text = "Nombre:"
        Me.Label119.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosTotalesIQaño
        '
        Me.labHonorariosTotalesIQaño.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosTotalesIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosTotalesIQaño.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosTotalesIQaño.Location = New System.Drawing.Point(600, 192)
        Me.labHonorariosTotalesIQaño.Name = "labHonorariosTotalesIQaño"
        Me.labHonorariosTotalesIQaño.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosTotalesIQaño.TabIndex = 33
        Me.labHonorariosTotalesIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(424, 192)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(192, 23)
        Me.Label70.TabIndex = 32
        Me.Label70.Text = "Honorarios totales por IQ en el año :"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosPagadosTotalesIQaño
        '
        Me.labHonorariosPagadosTotalesIQaño.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosPagadosTotalesIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPagadosTotalesIQaño.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosPagadosTotalesIQaño.Location = New System.Drawing.Point(600, 168)
        Me.labHonorariosPagadosTotalesIQaño.Name = "labHonorariosPagadosTotalesIQaño"
        Me.labHonorariosPagadosTotalesIQaño.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosPagadosTotalesIQaño.TabIndex = 31
        Me.labHonorariosPagadosTotalesIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(400, 168)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(216, 23)
        Me.Label74.TabIndex = 30
        Me.Label74.Text = "Honorarios cancelados por IQ en el año :"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosPendientesTotalesIQaño
        '
        Me.labHonorariosPendientesTotalesIQaño.BackColor = System.Drawing.Color.MistyRose
        Me.labHonorariosPendientesTotalesIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPendientesTotalesIQaño.Location = New System.Drawing.Point(600, 144)
        Me.labHonorariosPendientesTotalesIQaño.Name = "labHonorariosPendientesTotalesIQaño"
        Me.labHonorariosPendientesTotalesIQaño.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosPendientesTotalesIQaño.TabIndex = 29
        Me.labHonorariosPendientesTotalesIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label90
        '
        Me.Label90.Location = New System.Drawing.Point(400, 144)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(216, 23)
        Me.Label90.TabIndex = 28
        Me.Label90.Text = "Honorarios pendientes por IQ en el año :"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNumeroIQaño
        '
        Me.labNumeroIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroIQaño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroIQaño.Location = New System.Drawing.Point(192, 144)
        Me.labNumeroIQaño.Name = "labNumeroIQaño"
        Me.labNumeroIQaño.Size = New System.Drawing.Size(40, 20)
        Me.labNumeroIQaño.TabIndex = 27
        Me.labNumeroIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label94
        '
        Me.Label94.Location = New System.Drawing.Point(8, 144)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(192, 23)
        Me.Label94.TabIndex = 26
        Me.Label94.Text = "Intervenciones realizadas en el año :"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.botAdelantaAñoIQ)
        Me.Panel3.Controls.Add(Me.botRetrocedeAñoIQ)
        Me.Panel3.Controls.Add(Me.labAñoSeleccionadoIQ)
        Me.Panel3.Location = New System.Drawing.Point(8, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(720, 24)
        Me.Panel3.TabIndex = 25
        '
        'botAdelantaAñoIQ
        '
        Me.botAdelantaAñoIQ.BackColor = System.Drawing.SystemColors.Control
        Me.botAdelantaAñoIQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAdelantaAñoIQ.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botAdelantaAñoIQ.Image = CType(resources.GetObject("botAdelantaAñoIQ.Image"), System.Drawing.Image)
        Me.botAdelantaAñoIQ.Location = New System.Drawing.Point(696, 0)
        Me.botAdelantaAñoIQ.Name = "botAdelantaAñoIQ"
        Me.botAdelantaAñoIQ.Size = New System.Drawing.Size(24, 24)
        Me.botAdelantaAñoIQ.TabIndex = 1
        Me.botAdelantaAñoIQ.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botAdelantaAñoIQ.UseVisualStyleBackColor = False
        '
        'botRetrocedeAñoIQ
        '
        Me.botRetrocedeAñoIQ.BackColor = System.Drawing.SystemColors.Control
        Me.botRetrocedeAñoIQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRetrocedeAñoIQ.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRetrocedeAñoIQ.Image = CType(resources.GetObject("botRetrocedeAñoIQ.Image"), System.Drawing.Image)
        Me.botRetrocedeAñoIQ.Location = New System.Drawing.Point(0, 0)
        Me.botRetrocedeAñoIQ.Name = "botRetrocedeAñoIQ"
        Me.botRetrocedeAñoIQ.Size = New System.Drawing.Size(24, 24)
        Me.botRetrocedeAñoIQ.TabIndex = 0
        Me.botRetrocedeAñoIQ.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botRetrocedeAñoIQ.UseVisualStyleBackColor = False
        '
        'labAñoSeleccionadoIQ
        '
        Me.labAñoSeleccionadoIQ.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labAñoSeleccionadoIQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAñoSeleccionadoIQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labAñoSeleccionadoIQ.Location = New System.Drawing.Point(32, 2)
        Me.labAñoSeleccionadoIQ.Name = "labAñoSeleccionadoIQ"
        Me.labAñoSeleccionadoIQ.Size = New System.Drawing.Size(656, 20)
        Me.labAñoSeleccionadoIQ.TabIndex = 3
        Me.labAñoSeleccionadoIQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBoxIQaño
        '
        Me.ListBoxIQaño.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxIQaño.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxIQaño.ItemHeight = 11
        Me.ListBoxIQaño.Location = New System.Drawing.Point(8, 24)
        Me.ListBoxIQaño.Name = "ListBoxIQaño"
        Me.ListBoxIQaño.Size = New System.Drawing.Size(720, 114)
        Me.ListBoxIQaño.TabIndex = 11
        '
        'PanelIQmes
        '
        Me.PanelIQmes.Controls.Add(Me.botImprimeIQmes)
        Me.PanelIQmes.Controls.Add(Me.GroupBox7)
        Me.PanelIQmes.Controls.Add(Me.labHonorariosTotalesIQmes)
        Me.PanelIQmes.Controls.Add(Me.Label140)
        Me.PanelIQmes.Controls.Add(Me.labHonorariosPagadosTotalesIQmes)
        Me.PanelIQmes.Controls.Add(Me.Label138)
        Me.PanelIQmes.Controls.Add(Me.labHonorariosPendientesTotalesIQmes)
        Me.PanelIQmes.Controls.Add(Me.Label91)
        Me.PanelIQmes.Controls.Add(Me.labNumeroIQmes)
        Me.PanelIQmes.Controls.Add(Me.Label93)
        Me.PanelIQmes.Controls.Add(Me.ListBoxIQmes)
        Me.PanelIQmes.Controls.Add(Me.Panel5)
        Me.PanelIQmes.Location = New System.Drawing.Point(8, 598)
        Me.PanelIQmes.Name = "PanelIQmes"
        Me.PanelIQmes.Size = New System.Drawing.Size(934, 541)
        Me.PanelIQmes.TabIndex = 10
        '
        'botImprimeIQmes
        '
        Me.botImprimeIQmes.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botImprimeIQmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImprimeIQmes.Location = New System.Drawing.Point(256, 144)
        Me.botImprimeIQmes.Name = "botImprimeIQmes"
        Me.botImprimeIQmes.Size = New System.Drawing.Size(120, 23)
        Me.botImprimeIQmes.TabIndex = 22
        Me.botImprimeIQmes.Text = "Imprime"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.labCedulaIQmes)
        Me.GroupBox7.Controls.Add(Me.labFechaNacimientoIQmes)
        Me.GroupBox7.Controls.Add(Me.Label98)
        Me.GroupBox7.Controls.Add(Me.Label99)
        Me.GroupBox7.Controls.Add(Me.txtNotasIQmes)
        Me.GroupBox7.Controls.Add(Me.labFormaPagoIQmes)
        Me.GroupBox7.Controls.Add(Me.labRolMedico2IQmes)
        Me.GroupBox7.Controls.Add(Me.labRolMedico1IQmes)
        Me.GroupBox7.Controls.Add(Me.labRolIQmes)
        Me.GroupBox7.Controls.Add(Me.labHonorariosPagadosIQmes)
        Me.GroupBox7.Controls.Add(Me.labHonorariosPendientesIQmes)
        Me.GroupBox7.Controls.Add(Me.LabLugarIQmes)
        Me.GroupBox7.Controls.Add(Me.labMedico2IQmes)
        Me.GroupBox7.Controls.Add(Me.labMedico1IQmes)
        Me.GroupBox7.Controls.Add(Me.labTipoIQmes)
        Me.GroupBox7.Controls.Add(Me.Label86)
        Me.GroupBox7.Controls.Add(Me.Label87)
        Me.GroupBox7.Controls.Add(Me.Label88)
        Me.GroupBox7.Controls.Add(Me.Label89)
        Me.GroupBox7.Controls.Add(Me.Label126)
        Me.GroupBox7.Controls.Add(Me.Label127)
        Me.GroupBox7.Controls.Add(Me.Label128)
        Me.GroupBox7.Controls.Add(Me.Label129)
        Me.GroupBox7.Controls.Add(Me.Label130)
        Me.GroupBox7.Controls.Add(Me.Label131)
        Me.GroupBox7.Controls.Add(Me.Label132)
        Me.GroupBox7.Controls.Add(Me.labEdadIQmes)
        Me.GroupBox7.Controls.Add(Me.Label134)
        Me.GroupBox7.Controls.Add(Me.labNombreIQmes)
        Me.GroupBox7.Controls.Add(Me.Label136)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 275)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(913, 250)
        Me.GroupBox7.TabIndex = 16
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Intervención Seleccionada"
        '
        'labCedulaIQmes
        '
        Me.labCedulaIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labCedulaIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCedulaIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCedulaIQmes.Location = New System.Drawing.Point(144, 219)
        Me.labCedulaIQmes.Name = "labCedulaIQmes"
        Me.labCedulaIQmes.Size = New System.Drawing.Size(136, 20)
        Me.labCedulaIQmes.TabIndex = 57
        Me.labCedulaIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labFechaNacimientoIQmes
        '
        Me.labFechaNacimientoIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labFechaNacimientoIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFechaNacimientoIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFechaNacimientoIQmes.Location = New System.Drawing.Point(144, 195)
        Me.labFechaNacimientoIQmes.Name = "labFechaNacimientoIQmes"
        Me.labFechaNacimientoIQmes.Size = New System.Drawing.Size(136, 20)
        Me.labFechaNacimientoIQmes.TabIndex = 56
        Me.labFechaNacimientoIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Location = New System.Drawing.Point(93, 223)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(43, 13)
        Me.Label98.TabIndex = 55
        Me.Label98.Text = "Cédula:"
        Me.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(25, 199)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(111, 13)
        Me.Label99.TabIndex = 54
        Me.Label99.Text = "Fecha de Nacimiento:"
        Me.Label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNotasIQmes
        '
        Me.txtNotasIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotasIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtNotasIQmes.Location = New System.Drawing.Point(144, 160)
        Me.txtNotasIQmes.Multiline = True
        Me.txtNotasIQmes.Name = "txtNotasIQmes"
        Me.txtNotasIQmes.ReadOnly = True
        Me.txtNotasIQmes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotasIQmes.Size = New System.Drawing.Size(568, 32)
        Me.txtNotasIQmes.TabIndex = 53
        '
        'labFormaPagoIQmes
        '
        Me.labFormaPagoIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labFormaPagoIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFormaPagoIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFormaPagoIQmes.Location = New System.Drawing.Point(536, 112)
        Me.labFormaPagoIQmes.Name = "labFormaPagoIQmes"
        Me.labFormaPagoIQmes.Size = New System.Drawing.Size(176, 20)
        Me.labFormaPagoIQmes.TabIndex = 51
        Me.labFormaPagoIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRolMedico2IQmes
        '
        Me.labRolMedico2IQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labRolMedico2IQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRolMedico2IQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labRolMedico2IQmes.Location = New System.Drawing.Point(576, 88)
        Me.labRolMedico2IQmes.Name = "labRolMedico2IQmes"
        Me.labRolMedico2IQmes.Size = New System.Drawing.Size(136, 20)
        Me.labRolMedico2IQmes.TabIndex = 50
        Me.labRolMedico2IQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRolMedico1IQmes
        '
        Me.labRolMedico1IQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labRolMedico1IQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRolMedico1IQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labRolMedico1IQmes.Location = New System.Drawing.Point(576, 64)
        Me.labRolMedico1IQmes.Name = "labRolMedico1IQmes"
        Me.labRolMedico1IQmes.Size = New System.Drawing.Size(136, 20)
        Me.labRolMedico1IQmes.TabIndex = 49
        Me.labRolMedico1IQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRolIQmes
        '
        Me.labRolIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labRolIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRolIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labRolIQmes.Location = New System.Drawing.Point(576, 40)
        Me.labRolIQmes.Name = "labRolIQmes"
        Me.labRolIQmes.Size = New System.Drawing.Size(136, 20)
        Me.labRolIQmes.TabIndex = 48
        Me.labRolIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosPagadosIQmes
        '
        Me.labHonorariosPagadosIQmes.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosPagadosIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPagadosIQmes.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosPagadosIQmes.Location = New System.Drawing.Point(536, 136)
        Me.labHonorariosPagadosIQmes.Name = "labHonorariosPagadosIQmes"
        Me.labHonorariosPagadosIQmes.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosPagadosIQmes.TabIndex = 47
        Me.labHonorariosPagadosIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labHonorariosPendientesIQmes
        '
        Me.labHonorariosPendientesIQmes.BackColor = System.Drawing.Color.MistyRose
        Me.labHonorariosPendientesIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPendientesIQmes.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosPendientesIQmes.Location = New System.Drawing.Point(144, 136)
        Me.labHonorariosPendientesIQmes.Name = "labHonorariosPendientesIQmes"
        Me.labHonorariosPendientesIQmes.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosPendientesIQmes.TabIndex = 46
        Me.labHonorariosPendientesIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabLugarIQmes
        '
        Me.LabLugarIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.LabLugarIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabLugarIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.LabLugarIQmes.Location = New System.Drawing.Point(120, 112)
        Me.LabLugarIQmes.Name = "LabLugarIQmes"
        Me.LabLugarIQmes.Size = New System.Drawing.Size(320, 20)
        Me.LabLugarIQmes.TabIndex = 44
        Me.LabLugarIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labMedico2IQmes
        '
        Me.labMedico2IQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labMedico2IQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMedico2IQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labMedico2IQmes.Location = New System.Drawing.Point(120, 88)
        Me.labMedico2IQmes.Name = "labMedico2IQmes"
        Me.labMedico2IQmes.Size = New System.Drawing.Size(320, 20)
        Me.labMedico2IQmes.TabIndex = 43
        Me.labMedico2IQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labMedico1IQmes
        '
        Me.labMedico1IQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labMedico1IQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMedico1IQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labMedico1IQmes.Location = New System.Drawing.Point(120, 64)
        Me.labMedico1IQmes.Name = "labMedico1IQmes"
        Me.labMedico1IQmes.Size = New System.Drawing.Size(320, 20)
        Me.labMedico1IQmes.TabIndex = 42
        Me.labMedico1IQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTipoIQmes
        '
        Me.labTipoIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labTipoIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labTipoIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labTipoIQmes.Location = New System.Drawing.Point(120, 40)
        Me.labTipoIQmes.Name = "labTipoIQmes"
        Me.labTipoIQmes.Size = New System.Drawing.Size(320, 20)
        Me.labTipoIQmes.TabIndex = 41
        Me.labTipoIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label86
        '
        Me.Label86.Location = New System.Drawing.Point(8, 160)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(128, 20)
        Me.Label86.TabIndex = 40
        Me.Label86.Text = "Notas y Observaciones"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label87
        '
        Me.Label87.Location = New System.Drawing.Point(400, 136)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(144, 20)
        Me.Label87.TabIndex = 39
        Me.Label87.Text = "Honorarios netos pagados :"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label88
        '
        Me.Label88.Location = New System.Drawing.Point(8, 136)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(128, 20)
        Me.Label88.TabIndex = 38
        Me.Label88.Text = "Honorarios  estimados :"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label89
        '
        Me.Label89.Location = New System.Drawing.Point(448, 112)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(88, 20)
        Me.Label89.TabIndex = 37
        Me.Label89.Text = "Forma de Pago :"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label126
        '
        Me.Label126.Location = New System.Drawing.Point(448, 88)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(136, 20)
        Me.Label126.TabIndex = 36
        Me.Label126.Text = "Rol del Acompañante #2 :"
        Me.Label126.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label127
        '
        Me.Label127.Location = New System.Drawing.Point(8, 112)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(112, 20)
        Me.Label127.TabIndex = 35
        Me.Label127.Text = "La IQ se realizó en :"
        Me.Label127.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label128
        '
        Me.Label128.Location = New System.Drawing.Point(448, 64)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(136, 20)
        Me.Label128.TabIndex = 34
        Me.Label128.Text = "Rol del Acompañante #1 :"
        Me.Label128.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label129
        '
        Me.Label129.Location = New System.Drawing.Point(8, 88)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(104, 20)
        Me.Label129.TabIndex = 33
        Me.Label129.Text = "Acompañante #2 :"
        Me.Label129.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label130
        '
        Me.Label130.Location = New System.Drawing.Point(8, 64)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(104, 20)
        Me.Label130.TabIndex = 32
        Me.Label130.Text = "Acompañante #1 :"
        Me.Label130.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label131
        '
        Me.Label131.Location = New System.Drawing.Point(448, 40)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(120, 20)
        Me.Label131.TabIndex = 31
        Me.Label131.Text = "Rol en la Intervención :"
        Me.Label131.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label132
        '
        Me.Label132.Location = New System.Drawing.Point(8, 40)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(120, 20)
        Me.Label132.TabIndex = 30
        Me.Label132.Text = "Tipo de Intervención :"
        Me.Label132.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labEdadIQmes
        '
        Me.labEdadIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labEdadIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEdadIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEdadIQmes.Location = New System.Drawing.Point(672, 16)
        Me.labEdadIQmes.Name = "labEdadIQmes"
        Me.labEdadIQmes.Size = New System.Drawing.Size(40, 20)
        Me.labEdadIQmes.TabIndex = 12
        Me.labEdadIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label134
        '
        Me.Label134.Location = New System.Drawing.Point(624, 16)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(48, 20)
        Me.Label134.TabIndex = 11
        Me.Label134.Text = "Edad:"
        Me.Label134.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNombreIQmes
        '
        Me.labNombreIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labNombreIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombreIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombreIQmes.Location = New System.Drawing.Point(56, 16)
        Me.labNombreIQmes.Name = "labNombreIQmes"
        Me.labNombreIQmes.Size = New System.Drawing.Size(560, 20)
        Me.labNombreIQmes.TabIndex = 10
        Me.labNombreIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label136
        '
        Me.Label136.Location = New System.Drawing.Point(8, 16)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(48, 20)
        Me.Label136.TabIndex = 9
        Me.Label136.Text = "Nombre:"
        Me.Label136.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosTotalesIQmes
        '
        Me.labHonorariosTotalesIQmes.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosTotalesIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosTotalesIQmes.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosTotalesIQmes.Location = New System.Drawing.Point(600, 192)
        Me.labHonorariosTotalesIQmes.Name = "labHonorariosTotalesIQmes"
        Me.labHonorariosTotalesIQmes.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosTotalesIQmes.TabIndex = 15
        Me.labHonorariosTotalesIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label140
        '
        Me.Label140.Location = New System.Drawing.Point(424, 192)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(192, 23)
        Me.Label140.TabIndex = 14
        Me.Label140.Text = "Honorarios totales por IQ en el mes :"
        Me.Label140.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosPagadosTotalesIQmes
        '
        Me.labHonorariosPagadosTotalesIQmes.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosPagadosTotalesIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPagadosTotalesIQmes.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosPagadosTotalesIQmes.Location = New System.Drawing.Point(600, 168)
        Me.labHonorariosPagadosTotalesIQmes.Name = "labHonorariosPagadosTotalesIQmes"
        Me.labHonorariosPagadosTotalesIQmes.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosPagadosTotalesIQmes.TabIndex = 13
        Me.labHonorariosPagadosTotalesIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label138
        '
        Me.Label138.Location = New System.Drawing.Point(400, 168)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(216, 23)
        Me.Label138.TabIndex = 12
        Me.Label138.Text = "Honorarios cancelados por IQ en el mes :"
        Me.Label138.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosPendientesTotalesIQmes
        '
        Me.labHonorariosPendientesTotalesIQmes.BackColor = System.Drawing.Color.MistyRose
        Me.labHonorariosPendientesTotalesIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPendientesTotalesIQmes.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosPendientesTotalesIQmes.Location = New System.Drawing.Point(600, 144)
        Me.labHonorariosPendientesTotalesIQmes.Name = "labHonorariosPendientesTotalesIQmes"
        Me.labHonorariosPendientesTotalesIQmes.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosPendientesTotalesIQmes.TabIndex = 10
        Me.labHonorariosPendientesTotalesIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label91
        '
        Me.Label91.Location = New System.Drawing.Point(400, 144)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(216, 23)
        Me.Label91.TabIndex = 9
        Me.Label91.Text = "Honorarios pendientes por IQ en el mes :"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNumeroIQmes
        '
        Me.labNumeroIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroIQmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroIQmes.Location = New System.Drawing.Point(192, 144)
        Me.labNumeroIQmes.Name = "labNumeroIQmes"
        Me.labNumeroIQmes.Size = New System.Drawing.Size(40, 20)
        Me.labNumeroIQmes.TabIndex = 8
        Me.labNumeroIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label93
        '
        Me.Label93.Location = New System.Drawing.Point(8, 144)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(192, 23)
        Me.Label93.TabIndex = 7
        Me.Label93.Text = "Intervenciones realizadas en el mes :"
        Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBoxIQmes
        '
        Me.ListBoxIQmes.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxIQmes.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxIQmes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxIQmes.ItemHeight = 11
        Me.ListBoxIQmes.Location = New System.Drawing.Point(8, 24)
        Me.ListBoxIQmes.Name = "ListBoxIQmes"
        Me.ListBoxIQmes.Size = New System.Drawing.Size(720, 114)
        Me.ListBoxIQmes.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel5.Controls.Add(Me.botAdelantaMesIQ)
        Me.Panel5.Controls.Add(Me.botRetrocedeMesIQ)
        Me.Panel5.Controls.Add(Me.labMesSeleccionadoIQ)
        Me.Panel5.Location = New System.Drawing.Point(8, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(720, 24)
        Me.Panel5.TabIndex = 2
        '
        'botAdelantaMesIQ
        '
        Me.botAdelantaMesIQ.BackColor = System.Drawing.SystemColors.Control
        Me.botAdelantaMesIQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAdelantaMesIQ.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botAdelantaMesIQ.Image = CType(resources.GetObject("botAdelantaMesIQ.Image"), System.Drawing.Image)
        Me.botAdelantaMesIQ.Location = New System.Drawing.Point(696, 0)
        Me.botAdelantaMesIQ.Name = "botAdelantaMesIQ"
        Me.botAdelantaMesIQ.Size = New System.Drawing.Size(24, 24)
        Me.botAdelantaMesIQ.TabIndex = 1
        Me.botAdelantaMesIQ.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botAdelantaMesIQ.UseVisualStyleBackColor = False
        '
        'botRetrocedeMesIQ
        '
        Me.botRetrocedeMesIQ.BackColor = System.Drawing.SystemColors.Control
        Me.botRetrocedeMesIQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRetrocedeMesIQ.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRetrocedeMesIQ.Image = CType(resources.GetObject("botRetrocedeMesIQ.Image"), System.Drawing.Image)
        Me.botRetrocedeMesIQ.Location = New System.Drawing.Point(0, 0)
        Me.botRetrocedeMesIQ.Name = "botRetrocedeMesIQ"
        Me.botRetrocedeMesIQ.Size = New System.Drawing.Size(24, 24)
        Me.botRetrocedeMesIQ.TabIndex = 0
        Me.botRetrocedeMesIQ.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botRetrocedeMesIQ.UseVisualStyleBackColor = False
        '
        'labMesSeleccionadoIQ
        '
        Me.labMesSeleccionadoIQ.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labMesSeleccionadoIQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labMesSeleccionadoIQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labMesSeleccionadoIQ.Location = New System.Drawing.Point(32, 2)
        Me.labMesSeleccionadoIQ.Name = "labMesSeleccionadoIQ"
        Me.labMesSeleccionadoIQ.Size = New System.Drawing.Size(656, 20)
        Me.labMesSeleccionadoIQ.TabIndex = 3
        Me.labMesSeleccionadoIQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radIQaño
        '
        Me.radIQaño.Location = New System.Drawing.Point(272, 7)
        Me.radIQaño.Name = "radIQaño"
        Me.radIQaño.Size = New System.Drawing.Size(104, 24)
        Me.radIQaño.TabIndex = 9
        Me.radIQaño.Text = "Vista Anual"
        Me.radIQaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radIQmes
        '
        Me.radIQmes.Location = New System.Drawing.Point(152, 7)
        Me.radIQmes.Name = "radIQmes"
        Me.radIQmes.Size = New System.Drawing.Size(104, 24)
        Me.radIQmes.TabIndex = 8
        Me.radIQmes.Text = "Vista Mensual"
        Me.radIQmes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radIQdia
        '
        Me.radIQdia.Checked = True
        Me.radIQdia.Location = New System.Drawing.Point(32, 7)
        Me.radIQdia.Name = "radIQdia"
        Me.radIQdia.Size = New System.Drawing.Size(104, 24)
        Me.radIQdia.TabIndex = 7
        Me.radIQdia.TabStop = True
        Me.radIQdia.Text = "Vista Diaria"
        Me.radIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelIQdia
        '
        Me.PanelIQdia.BackColor = System.Drawing.SystemColors.Control
        Me.PanelIQdia.Controls.Add(Me.labHonorariosTotalesIQdia)
        Me.PanelIQdia.Controls.Add(Me.Label125)
        Me.PanelIQdia.Controls.Add(Me.labHonorariosPagadosTotalesIQdia)
        Me.PanelIQdia.Controls.Add(Me.Label72)
        Me.PanelIQdia.Controls.Add(Me.GroupBox6)
        Me.PanelIQdia.Controls.Add(Me.labHonorariosPendientesTotalesIQdia)
        Me.PanelIQdia.Controls.Add(Me.Label71)
        Me.PanelIQdia.Controls.Add(Me.labIQdia)
        Me.PanelIQdia.Controls.Add(Me.ListBoxIQdia)
        Me.PanelIQdia.Controls.Add(Me.CalendarioIQdia)
        Me.PanelIQdia.Location = New System.Drawing.Point(8, 31)
        Me.PanelIQdia.Name = "PanelIQdia"
        Me.PanelIQdia.Size = New System.Drawing.Size(934, 541)
        Me.PanelIQdia.TabIndex = 6
        '
        'labHonorariosTotalesIQdia
        '
        Me.labHonorariosTotalesIQdia.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosTotalesIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosTotalesIQdia.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosTotalesIQdia.Location = New System.Drawing.Point(592, 152)
        Me.labHonorariosTotalesIQdia.Name = "labHonorariosTotalesIQdia"
        Me.labHonorariosTotalesIQdia.Size = New System.Drawing.Size(136, 20)
        Me.labHonorariosTotalesIQdia.TabIndex = 11
        Me.labHonorariosTotalesIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label125
        '
        Me.Label125.Location = New System.Drawing.Point(432, 152)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(168, 20)
        Me.Label125.TabIndex = 10
        Me.Label125.Text = "Honorarios totales del día :"
        Me.Label125.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosPagadosTotalesIQdia
        '
        Me.labHonorariosPagadosTotalesIQdia.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosPagadosTotalesIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPagadosTotalesIQdia.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosPagadosTotalesIQdia.Location = New System.Drawing.Point(592, 128)
        Me.labHonorariosPagadosTotalesIQdia.Name = "labHonorariosPagadosTotalesIQdia"
        Me.labHonorariosPagadosTotalesIQdia.Size = New System.Drawing.Size(136, 20)
        Me.labHonorariosPagadosTotalesIQdia.TabIndex = 9
        Me.labHonorariosPagadosTotalesIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(432, 128)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(168, 20)
        Me.Label72.TabIndex = 8
        Me.Label72.Text = "Honorarios cancelados del día :"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.labCedulaIQdia)
        Me.GroupBox6.Controls.Add(Me.labFechaNacimientoIQdia)
        Me.GroupBox6.Controls.Add(Me.Label100)
        Me.GroupBox6.Controls.Add(Me.Label101)
        Me.GroupBox6.Controls.Add(Me.Label59)
        Me.GroupBox6.Controls.Add(Me.txtNotasIQdia)
        Me.GroupBox6.Controls.Add(Me.labFormaPagoIQdia)
        Me.GroupBox6.Controls.Add(Me.labRolMedico2IQdia)
        Me.GroupBox6.Controls.Add(Me.labRolMedico1IQdia)
        Me.GroupBox6.Controls.Add(Me.labRolIQdia)
        Me.GroupBox6.Controls.Add(Me.labHonorariosPagadosIQdia)
        Me.GroupBox6.Controls.Add(Me.labHonorariosEstimadosIQdia)
        Me.GroupBox6.Controls.Add(Me.labLugarIQdia)
        Me.GroupBox6.Controls.Add(Me.labMedico2IQdia)
        Me.GroupBox6.Controls.Add(Me.labMedico1IQdia)
        Me.GroupBox6.Controls.Add(Me.labTipoIQdia)
        Me.GroupBox6.Controls.Add(Me.Label34)
        Me.GroupBox6.Controls.Add(Me.Label51)
        Me.GroupBox6.Controls.Add(Me.Label55)
        Me.GroupBox6.Controls.Add(Me.Label57)
        Me.GroupBox6.Controls.Add(Me.Label58)
        Me.GroupBox6.Controls.Add(Me.Label60)
        Me.GroupBox6.Controls.Add(Me.Label61)
        Me.GroupBox6.Controls.Add(Me.Label63)
        Me.GroupBox6.Controls.Add(Me.Label68)
        Me.GroupBox6.Controls.Add(Me.Label69)
        Me.GroupBox6.Controls.Add(Me.labEdadIQdia)
        Me.GroupBox6.Controls.Add(Me.Label65)
        Me.GroupBox6.Controls.Add(Me.labNombreIQdia)
        Me.GroupBox6.Controls.Add(Me.Label67)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 275)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(913, 250)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Intervención Seleccionada"
        '
        'labCedulaIQdia
        '
        Me.labCedulaIQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labCedulaIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCedulaIQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCedulaIQdia.Location = New System.Drawing.Point(144, 219)
        Me.labCedulaIQdia.Name = "labCedulaIQdia"
        Me.labCedulaIQdia.Size = New System.Drawing.Size(136, 20)
        Me.labCedulaIQdia.TabIndex = 61
        Me.labCedulaIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labFechaNacimientoIQdia
        '
        Me.labFechaNacimientoIQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labFechaNacimientoIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFechaNacimientoIQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFechaNacimientoIQdia.Location = New System.Drawing.Point(144, 195)
        Me.labFechaNacimientoIQdia.Name = "labFechaNacimientoIQdia"
        Me.labFechaNacimientoIQdia.Size = New System.Drawing.Size(136, 20)
        Me.labFechaNacimientoIQdia.TabIndex = 60
        Me.labFechaNacimientoIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Location = New System.Drawing.Point(93, 223)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(43, 13)
        Me.Label100.TabIndex = 59
        Me.Label100.Text = "Cédula:"
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(25, 199)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(111, 13)
        Me.Label101.TabIndex = 58
        Me.Label101.Text = "Fecha de Nacimiento:"
        Me.Label101.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(8, 112)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(112, 20)
        Me.Label59.TabIndex = 53
        Me.Label59.Text = "La IQ se realizó en :"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNotasIQdia
        '
        Me.txtNotasIQdia.BackColor = System.Drawing.SystemColors.Info
        Me.txtNotasIQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtNotasIQdia.Location = New System.Drawing.Point(144, 160)
        Me.txtNotasIQdia.Multiline = True
        Me.txtNotasIQdia.Name = "txtNotasIQdia"
        Me.txtNotasIQdia.ReadOnly = True
        Me.txtNotasIQdia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotasIQdia.Size = New System.Drawing.Size(568, 32)
        Me.txtNotasIQdia.TabIndex = 52
        '
        'labFormaPagoIQdia
        '
        Me.labFormaPagoIQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labFormaPagoIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFormaPagoIQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFormaPagoIQdia.Location = New System.Drawing.Point(536, 112)
        Me.labFormaPagoIQdia.Name = "labFormaPagoIQdia"
        Me.labFormaPagoIQdia.Size = New System.Drawing.Size(176, 20)
        Me.labFormaPagoIQdia.TabIndex = 51
        Me.labFormaPagoIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRolMedico2IQdia
        '
        Me.labRolMedico2IQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labRolMedico2IQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRolMedico2IQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labRolMedico2IQdia.Location = New System.Drawing.Point(576, 88)
        Me.labRolMedico2IQdia.Name = "labRolMedico2IQdia"
        Me.labRolMedico2IQdia.Size = New System.Drawing.Size(136, 20)
        Me.labRolMedico2IQdia.TabIndex = 50
        Me.labRolMedico2IQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRolMedico1IQdia
        '
        Me.labRolMedico1IQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labRolMedico1IQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRolMedico1IQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labRolMedico1IQdia.Location = New System.Drawing.Point(576, 64)
        Me.labRolMedico1IQdia.Name = "labRolMedico1IQdia"
        Me.labRolMedico1IQdia.Size = New System.Drawing.Size(136, 20)
        Me.labRolMedico1IQdia.TabIndex = 49
        Me.labRolMedico1IQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRolIQdia
        '
        Me.labRolIQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labRolIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRolIQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labRolIQdia.Location = New System.Drawing.Point(576, 40)
        Me.labRolIQdia.Name = "labRolIQdia"
        Me.labRolIQdia.Size = New System.Drawing.Size(136, 20)
        Me.labRolIQdia.TabIndex = 48
        Me.labRolIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosPagadosIQdia
        '
        Me.labHonorariosPagadosIQdia.BackColor = System.Drawing.Color.LightCyan
        Me.labHonorariosPagadosIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPagadosIQdia.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosPagadosIQdia.Location = New System.Drawing.Point(536, 136)
        Me.labHonorariosPagadosIQdia.Name = "labHonorariosPagadosIQdia"
        Me.labHonorariosPagadosIQdia.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosPagadosIQdia.TabIndex = 47
        Me.labHonorariosPagadosIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labHonorariosEstimadosIQdia
        '
        Me.labHonorariosEstimadosIQdia.BackColor = System.Drawing.Color.MistyRose
        Me.labHonorariosEstimadosIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosEstimadosIQdia.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosEstimadosIQdia.Location = New System.Drawing.Point(144, 136)
        Me.labHonorariosEstimadosIQdia.Name = "labHonorariosEstimadosIQdia"
        Me.labHonorariosEstimadosIQdia.Size = New System.Drawing.Size(128, 20)
        Me.labHonorariosEstimadosIQdia.TabIndex = 46
        Me.labHonorariosEstimadosIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labLugarIQdia
        '
        Me.labLugarIQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labLugarIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labLugarIQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labLugarIQdia.Location = New System.Drawing.Point(120, 112)
        Me.labLugarIQdia.Name = "labLugarIQdia"
        Me.labLugarIQdia.Size = New System.Drawing.Size(320, 20)
        Me.labLugarIQdia.TabIndex = 44
        Me.labLugarIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labMedico2IQdia
        '
        Me.labMedico2IQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labMedico2IQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMedico2IQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labMedico2IQdia.Location = New System.Drawing.Point(120, 88)
        Me.labMedico2IQdia.Name = "labMedico2IQdia"
        Me.labMedico2IQdia.Size = New System.Drawing.Size(320, 20)
        Me.labMedico2IQdia.TabIndex = 43
        Me.labMedico2IQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labMedico1IQdia
        '
        Me.labMedico1IQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labMedico1IQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMedico1IQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labMedico1IQdia.Location = New System.Drawing.Point(120, 64)
        Me.labMedico1IQdia.Name = "labMedico1IQdia"
        Me.labMedico1IQdia.Size = New System.Drawing.Size(320, 20)
        Me.labMedico1IQdia.TabIndex = 42
        Me.labMedico1IQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTipoIQdia
        '
        Me.labTipoIQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labTipoIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labTipoIQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labTipoIQdia.Location = New System.Drawing.Point(120, 40)
        Me.labTipoIQdia.Name = "labTipoIQdia"
        Me.labTipoIQdia.Size = New System.Drawing.Size(320, 20)
        Me.labTipoIQdia.TabIndex = 41
        Me.labTipoIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(8, 160)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(128, 20)
        Me.Label34.TabIndex = 40
        Me.Label34.Text = "Notas y Observaciones"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(400, 136)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(144, 20)
        Me.Label51.TabIndex = 39
        Me.Label51.Text = "Honorarios netos pagados :"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(8, 136)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(128, 20)
        Me.Label55.TabIndex = 38
        Me.Label55.Text = "Honorarios  estimados :"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(448, 112)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(88, 20)
        Me.Label57.TabIndex = 37
        Me.Label57.Text = "Forma de Pago :"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.Location = New System.Drawing.Point(448, 88)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(136, 20)
        Me.Label58.TabIndex = 36
        Me.Label58.Text = "Rol del Acompañante #2 :"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(448, 64)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(136, 20)
        Me.Label60.TabIndex = 34
        Me.Label60.Text = "Rol del Acompañante #1 :"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(8, 88)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(104, 20)
        Me.Label61.TabIndex = 33
        Me.Label61.Text = "Acompañante #2 :"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(8, 64)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(104, 20)
        Me.Label63.TabIndex = 32
        Me.Label63.Text = "Acompañante #1 :"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(448, 40)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(120, 20)
        Me.Label68.TabIndex = 31
        Me.Label68.Text = "Rol en la Intervención :"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(8, 40)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(120, 20)
        Me.Label69.TabIndex = 30
        Me.Label69.Text = "Tipo de Intervención :"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labEdadIQdia
        '
        Me.labEdadIQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labEdadIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEdadIQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEdadIQdia.Location = New System.Drawing.Point(672, 16)
        Me.labEdadIQdia.Name = "labEdadIQdia"
        Me.labEdadIQdia.Size = New System.Drawing.Size(40, 20)
        Me.labEdadIQdia.TabIndex = 12
        Me.labEdadIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(632, 16)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(48, 20)
        Me.Label65.TabIndex = 11
        Me.Label65.Text = "Edad:"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNombreIQdia
        '
        Me.labNombreIQdia.BackColor = System.Drawing.SystemColors.Info
        Me.labNombreIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombreIQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombreIQdia.Location = New System.Drawing.Point(56, 16)
        Me.labNombreIQdia.Name = "labNombreIQdia"
        Me.labNombreIQdia.Size = New System.Drawing.Size(568, 20)
        Me.labNombreIQdia.TabIndex = 10
        Me.labNombreIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(8, 16)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(48, 20)
        Me.Label67.TabIndex = 9
        Me.Label67.Text = "Nombre:"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosPendientesTotalesIQdia
        '
        Me.labHonorariosPendientesTotalesIQdia.BackColor = System.Drawing.Color.MistyRose
        Me.labHonorariosPendientesTotalesIQdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosPendientesTotalesIQdia.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosPendientesTotalesIQdia.Location = New System.Drawing.Point(592, 104)
        Me.labHonorariosPendientesTotalesIQdia.Name = "labHonorariosPendientesTotalesIQdia"
        Me.labHonorariosPendientesTotalesIQdia.Size = New System.Drawing.Size(136, 20)
        Me.labHonorariosPendientesTotalesIQdia.TabIndex = 6
        Me.labHonorariosPendientesTotalesIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(432, 104)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(168, 20)
        Me.Label71.TabIndex = 5
        Me.Label71.Text = "Honorarios pendientes del día :"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labIQdia
        '
        Me.labIQdia.AutoSize = True
        Me.labIQdia.Location = New System.Drawing.Point(213, 14)
        Me.labIQdia.Name = "labIQdia"
        Me.labIQdia.Size = New System.Drawing.Size(77, 13)
        Me.labIQdia.TabIndex = 2
        Me.labIQdia.Text = "Intervenciones"
        Me.labIQdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBoxIQdia
        '
        Me.ListBoxIQdia.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxIQdia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxIQdia.Location = New System.Drawing.Point(216, 32)
        Me.ListBoxIQdia.Name = "ListBoxIQdia"
        Me.ListBoxIQdia.Size = New System.Drawing.Size(512, 69)
        Me.ListBoxIQdia.TabIndex = 1
        '
        'CalendarioIQdia
        '
        Me.CalendarioIQdia.Location = New System.Drawing.Point(8, 8)
        Me.CalendarioIQdia.MaxSelectionCount = 1
        Me.CalendarioIQdia.Name = "CalendarioIQdia"
        Me.CalendarioIQdia.ShowToday = False
        Me.CalendarioIQdia.ShowTodayCircle = False
        Me.CalendarioIQdia.TabIndex = 0
        '
        'TabPagePagos
        '
        Me.TabPagePagos.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePagos.Controls.Add(Me.TabControl2)
        Me.TabPagePagos.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePagos.Name = "TabPagePagos"
        Me.TabPagePagos.Size = New System.Drawing.Size(962, 580)
        Me.TabPagePagos.TabIndex = 7
        Me.TabPagePagos.Text = "Pagos"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPagePagosXdia)
        Me.TabControl2.Controls.Add(Me.TabPagePagosXmes)
        Me.TabControl2.Controls.Add(Me.TabPagePagosXaño)
        Me.TabControl2.Controls.Add(Me.TabPageISLR)
        Me.TabControl2.Location = New System.Drawing.Point(3, 15)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(956, 562)
        Me.TabControl2.TabIndex = 0
        '
        'TabPagePagosXdia
        '
        Me.TabPagePagosXdia.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePagosXdia.Controls.Add(Me.GroupBox1)
        Me.TabPagePagosXdia.Controls.Add(Me.chkPAGOincluyeNoFacturadosDIA)
        Me.TabPagePagosXdia.Controls.Add(Me.Label143)
        Me.TabPagePagosXdia.Controls.Add(Me.Label142)
        Me.TabPagePagosXdia.Controls.Add(Me.Label141)
        Me.TabPagePagosXdia.Controls.Add(Me.Label120)
        Me.TabPagePagosXdia.Controls.Add(Me.labPagoDiaTotalDevengado)
        Me.TabPagePagosXdia.Controls.Add(Me.Label137)
        Me.TabPagePagosXdia.Controls.Add(Me.labPagoDiaOtrasRet)
        Me.TabPagePagosXdia.Controls.Add(Me.Label135)
        Me.TabPagePagosXdia.Controls.Add(Me.labPagoDiaRetAdm)
        Me.TabPagePagosXdia.Controls.Add(Me.Label133)
        Me.TabPagePagosXdia.Controls.Add(Me.labPagoDiaRetISLR)
        Me.TabPagePagosXdia.Controls.Add(Me.Label124)
        Me.TabPagePagosXdia.Controls.Add(Me.labPagoDiaPagadoNeto)
        Me.TabPagePagosXdia.Controls.Add(Me.Label139)
        Me.TabPagePagosXdia.Controls.Add(Me.labPagosDia)
        Me.TabPagePagosXdia.Controls.Add(Me.ListBoxPagosDia)
        Me.TabPagePagosXdia.Controls.Add(Me.CalendarioPagosDia)
        Me.TabPagePagosXdia.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePagosXdia.Name = "TabPagePagosXdia"
        Me.TabPagePagosXdia.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePagosXdia.Size = New System.Drawing.Size(948, 536)
        Me.TabPagePagosXdia.TabIndex = 0
        Me.TabPagePagosXdia.Text = "Pagos x Día"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labPAGOdiaRif)
        Me.GroupBox1.Controls.Add(Me.Label171)
        Me.GroupBox1.Controls.Add(Me.labPAGOdiaPorcentajeDeRetencion)
        Me.GroupBox1.Controls.Add(Me.Label155)
        Me.GroupBox1.Controls.Add(Me.Label154)
        Me.GroupBox1.Controls.Add(Me.txtPAGOdiaNotasSel)
        Me.GroupBox1.Controls.Add(Me.labPAGOdiaIncluidoSel)
        Me.GroupBox1.Controls.Add(Me.labPAGOdiaTotalDevengadoSel)
        Me.GroupBox1.Controls.Add(Me.labPagoDiaOtrasRetSel)
        Me.GroupBox1.Controls.Add(Me.labPagoDiaRetAdmSel)
        Me.GroupBox1.Controls.Add(Me.labPagoDiaRetISLRsel)
        Me.GroupBox1.Controls.Add(Me.labPagoDiaPagadoNetoSel)
        Me.GroupBox1.Controls.Add(Me.labPAGOdiaModoPagoSel)
        Me.GroupBox1.Controls.Add(Me.labPAGOdiaPagadorSel)
        Me.GroupBox1.Controls.Add(Me.labPAGOdiaFacturaSel)
        Me.GroupBox1.Controls.Add(Me.labPAGOdiaFechaSel)
        Me.GroupBox1.Controls.Add(Me.Label153)
        Me.GroupBox1.Controls.Add(Me.Label152)
        Me.GroupBox1.Controls.Add(Me.Label151)
        Me.GroupBox1.Controls.Add(Me.Label150)
        Me.GroupBox1.Controls.Add(Me.Label149)
        Me.GroupBox1.Controls.Add(Me.Label147)
        Me.GroupBox1.Controls.Add(Me.Label148)
        Me.GroupBox1.Controls.Add(Me.Label146)
        Me.GroupBox1.Controls.Add(Me.Label145)
        Me.GroupBox1.Controls.Add(Me.Label144)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 324)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pago Seleccionado"
        '
        'labPAGOdiaRif
        '
        Me.labPAGOdiaRif.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOdiaRif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOdiaRif.ForeColor = System.Drawing.Color.Black
        Me.labPAGOdiaRif.Location = New System.Drawing.Point(465, 36)
        Me.labPAGOdiaRif.Name = "labPAGOdiaRif"
        Me.labPAGOdiaRif.Size = New System.Drawing.Size(96, 20)
        Me.labPAGOdiaRif.TabIndex = 67
        Me.labPAGOdiaRif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label171
        '
        Me.Label171.AutoSize = True
        Me.Label171.Location = New System.Drawing.Point(462, 20)
        Me.Label171.Name = "Label171"
        Me.Label171.Size = New System.Drawing.Size(41, 13)
        Me.Label171.TabIndex = 66
        Me.Label171.Text = "Rif / CI"
        Me.Label171.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOdiaPorcentajeDeRetencion
        '
        Me.labPAGOdiaPorcentajeDeRetencion.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOdiaPorcentajeDeRetencion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOdiaPorcentajeDeRetencion.ForeColor = System.Drawing.Color.Black
        Me.labPAGOdiaPorcentajeDeRetencion.Location = New System.Drawing.Point(141, 264)
        Me.labPAGOdiaPorcentajeDeRetencion.Name = "labPAGOdiaPorcentajeDeRetencion"
        Me.labPAGOdiaPorcentajeDeRetencion.Size = New System.Drawing.Size(75, 20)
        Me.labPAGOdiaPorcentajeDeRetencion.TabIndex = 65
        Me.labPAGOdiaPorcentajeDeRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label155
        '
        Me.Label155.AutoSize = True
        Me.Label155.Location = New System.Drawing.Point(47, 268)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(88, 13)
        Me.Label155.TabIndex = 64
        Me.Label155.Text = "(%) de Retención"
        Me.Label155.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label154
        '
        Me.Label154.AutoSize = True
        Me.Label154.Location = New System.Drawing.Point(279, 69)
        Me.Label154.Name = "Label154"
        Me.Label154.Size = New System.Drawing.Size(230, 13)
        Me.Label154.TabIndex = 63
        Me.Label154.Text = "Notas y Observaciones del Pago Seleccionado"
        Me.Label154.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPAGOdiaNotasSel
        '
        Me.txtPAGOdiaNotasSel.BackColor = System.Drawing.SystemColors.Info
        Me.txtPAGOdiaNotasSel.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPAGOdiaNotasSel.Location = New System.Drawing.Point(282, 86)
        Me.txtPAGOdiaNotasSel.MaxLength = 5000
        Me.txtPAGOdiaNotasSel.Multiline = True
        Me.txtPAGOdiaNotasSel.Name = "txtPAGOdiaNotasSel"
        Me.txtPAGOdiaNotasSel.ReadOnly = True
        Me.txtPAGOdiaNotasSel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPAGOdiaNotasSel.Size = New System.Drawing.Size(635, 223)
        Me.txtPAGOdiaNotasSel.TabIndex = 62
        '
        'labPAGOdiaIncluidoSel
        '
        Me.labPAGOdiaIncluidoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOdiaIncluidoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOdiaIncluidoSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOdiaIncluidoSel.Location = New System.Drawing.Point(141, 289)
        Me.labPAGOdiaIncluidoSel.Name = "labPAGOdiaIncluidoSel"
        Me.labPAGOdiaIncluidoSel.Size = New System.Drawing.Size(75, 20)
        Me.labPAGOdiaIncluidoSel.TabIndex = 61
        Me.labPAGOdiaIncluidoSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOdiaTotalDevengadoSel
        '
        Me.labPAGOdiaTotalDevengadoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOdiaTotalDevengadoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOdiaTotalDevengadoSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOdiaTotalDevengadoSel.Location = New System.Drawing.Point(141, 86)
        Me.labPAGOdiaTotalDevengadoSel.Name = "labPAGOdiaTotalDevengadoSel"
        Me.labPAGOdiaTotalDevengadoSel.Size = New System.Drawing.Size(112, 20)
        Me.labPAGOdiaTotalDevengadoSel.TabIndex = 60
        Me.labPAGOdiaTotalDevengadoSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoDiaOtrasRetSel
        '
        Me.labPagoDiaOtrasRetSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoDiaOtrasRetSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoDiaOtrasRetSel.ForeColor = System.Drawing.Color.Black
        Me.labPagoDiaOtrasRetSel.Location = New System.Drawing.Point(141, 155)
        Me.labPagoDiaOtrasRetSel.Name = "labPagoDiaOtrasRetSel"
        Me.labPagoDiaOtrasRetSel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoDiaOtrasRetSel.TabIndex = 59
        Me.labPagoDiaOtrasRetSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoDiaRetAdmSel
        '
        Me.labPagoDiaRetAdmSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoDiaRetAdmSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoDiaRetAdmSel.ForeColor = System.Drawing.Color.Black
        Me.labPagoDiaRetAdmSel.Location = New System.Drawing.Point(141, 132)
        Me.labPagoDiaRetAdmSel.Name = "labPagoDiaRetAdmSel"
        Me.labPagoDiaRetAdmSel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoDiaRetAdmSel.TabIndex = 58
        Me.labPagoDiaRetAdmSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoDiaRetISLRsel
        '
        Me.labPagoDiaRetISLRsel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoDiaRetISLRsel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoDiaRetISLRsel.ForeColor = System.Drawing.Color.Black
        Me.labPagoDiaRetISLRsel.Location = New System.Drawing.Point(141, 109)
        Me.labPagoDiaRetISLRsel.Name = "labPagoDiaRetISLRsel"
        Me.labPagoDiaRetISLRsel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoDiaRetISLRsel.TabIndex = 57
        Me.labPagoDiaRetISLRsel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoDiaPagadoNetoSel
        '
        Me.labPagoDiaPagadoNetoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoDiaPagadoNetoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoDiaPagadoNetoSel.ForeColor = System.Drawing.Color.Black
        Me.labPagoDiaPagadoNetoSel.Location = New System.Drawing.Point(141, 178)
        Me.labPagoDiaPagadoNetoSel.Name = "labPagoDiaPagadoNetoSel"
        Me.labPagoDiaPagadoNetoSel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoDiaPagadoNetoSel.TabIndex = 56
        Me.labPagoDiaPagadoNetoSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPAGOdiaModoPagoSel
        '
        Me.labPAGOdiaModoPagoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOdiaModoPagoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOdiaModoPagoSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOdiaModoPagoSel.Location = New System.Drawing.Point(567, 36)
        Me.labPAGOdiaModoPagoSel.Name = "labPAGOdiaModoPagoSel"
        Me.labPAGOdiaModoPagoSel.Size = New System.Drawing.Size(350, 20)
        Me.labPAGOdiaModoPagoSel.TabIndex = 55
        Me.labPAGOdiaModoPagoSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOdiaPagadorSel
        '
        Me.labPAGOdiaPagadorSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOdiaPagadorSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOdiaPagadorSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOdiaPagadorSel.Location = New System.Drawing.Point(151, 36)
        Me.labPAGOdiaPagadorSel.Name = "labPAGOdiaPagadorSel"
        Me.labPAGOdiaPagadorSel.Size = New System.Drawing.Size(308, 20)
        Me.labPAGOdiaPagadorSel.TabIndex = 54
        Me.labPAGOdiaPagadorSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOdiaFacturaSel
        '
        Me.labPAGOdiaFacturaSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOdiaFacturaSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOdiaFacturaSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOdiaFacturaSel.Location = New System.Drawing.Point(80, 36)
        Me.labPAGOdiaFacturaSel.Name = "labPAGOdiaFacturaSel"
        Me.labPAGOdiaFacturaSel.Size = New System.Drawing.Size(65, 20)
        Me.labPAGOdiaFacturaSel.TabIndex = 53
        Me.labPAGOdiaFacturaSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOdiaFechaSel
        '
        Me.labPAGOdiaFechaSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOdiaFechaSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOdiaFechaSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOdiaFechaSel.Location = New System.Drawing.Point(6, 36)
        Me.labPAGOdiaFechaSel.Name = "labPAGOdiaFechaSel"
        Me.labPAGOdiaFechaSel.Size = New System.Drawing.Size(65, 20)
        Me.labPAGOdiaFechaSel.TabIndex = 52
        Me.labPAGOdiaFechaSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label153
        '
        Me.Label153.AutoSize = True
        Me.Label153.Location = New System.Drawing.Point(17, 293)
        Me.Label153.Name = "Label153"
        Me.Label153.Size = New System.Drawing.Size(118, 13)
        Me.Label153.TabIndex = 51
        Me.Label153.Text = "Incluido en Facturación"
        Me.Label153.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label152
        '
        Me.Label152.AutoSize = True
        Me.Label152.Location = New System.Drawing.Point(45, 90)
        Me.Label152.Name = "Label152"
        Me.Label152.Size = New System.Drawing.Size(90, 13)
        Me.Label152.TabIndex = 50
        Me.Label152.Text = "Total Devengado"
        Me.Label152.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label151
        '
        Me.Label151.AutoSize = True
        Me.Label151.Location = New System.Drawing.Point(77, 182)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(58, 13)
        Me.Label151.TabIndex = 49
        Me.Label151.Text = "Pago Neto"
        Me.Label151.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label150
        '
        Me.Label150.AutoSize = True
        Me.Label150.Location = New System.Drawing.Point(40, 159)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(95, 13)
        Me.Label150.TabIndex = 48
        Me.Label150.Text = "Otras Retenciones"
        Me.Label150.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label149
        '
        Me.Label149.AutoSize = True
        Me.Label149.Location = New System.Drawing.Point(52, 113)
        Me.Label149.Name = "Label149"
        Me.Label149.Size = New System.Drawing.Size(83, 13)
        Me.Label149.TabIndex = 47
        Me.Label149.Text = "Retencion ISLR"
        Me.Label149.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label147
        '
        Me.Label147.AutoSize = True
        Me.Label147.Location = New System.Drawing.Point(11, 136)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(124, 13)
        Me.Label147.TabIndex = 46
        Me.Label147.Text = "Retencion Administrativa"
        Me.Label147.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label148
        '
        Me.Label148.AutoSize = True
        Me.Label148.Location = New System.Drawing.Point(77, 20)
        Me.Label148.Name = "Label148"
        Me.Label148.Size = New System.Drawing.Size(43, 13)
        Me.Label148.TabIndex = 45
        Me.Label148.Text = "Factura"
        Me.Label148.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label146
        '
        Me.Label146.AutoSize = True
        Me.Label146.Location = New System.Drawing.Point(564, 20)
        Me.Label146.Name = "Label146"
        Me.Label146.Size = New System.Drawing.Size(77, 13)
        Me.Label146.TabIndex = 44
        Me.Label146.Text = "Modo de Pago"
        Me.Label146.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label145
        '
        Me.Label145.AutoSize = True
        Me.Label145.Location = New System.Drawing.Point(150, 20)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(47, 13)
        Me.Label145.TabIndex = 43
        Me.Label145.Text = "Pagador"
        Me.Label145.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.Location = New System.Drawing.Point(6, 20)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(37, 13)
        Me.Label144.TabIndex = 42
        Me.Label144.Text = "Fecha"
        Me.Label144.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPAGOincluyeNoFacturadosDIA
        '
        Me.chkPAGOincluyeNoFacturadosDIA.AutoSize = True
        Me.chkPAGOincluyeNoFacturadosDIA.Checked = True
        Me.chkPAGOincluyeNoFacturadosDIA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPAGOincluyeNoFacturadosDIA.Location = New System.Drawing.Point(8, 183)
        Me.chkPAGOincluyeNoFacturadosDIA.Name = "chkPAGOincluyeNoFacturadosDIA"
        Me.chkPAGOincluyeNoFacturadosDIA.Size = New System.Drawing.Size(197, 17)
        Me.chkPAGOincluyeNoFacturadosDIA.TabIndex = 26
        Me.chkPAGOincluyeNoFacturadosDIA.Text = "Incluye Facturados y No Facturados"
        Me.chkPAGOincluyeNoFacturadosDIA.UseVisualStyleBackColor = True
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.Location = New System.Drawing.Point(593, 14)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(73, 13)
        Me.Label143.TabIndex = 25
        Me.Label143.Text = "Neto Cobrado"
        Me.Label143.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Location = New System.Drawing.Point(348, 14)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(47, 13)
        Me.Label142.TabIndex = 24
        Me.Label142.Text = "Pagador"
        Me.Label142.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Location = New System.Drawing.Point(287, 14)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(43, 13)
        Me.Label141.TabIndex = 23
        Me.Label141.Text = "Factura"
        Me.Label141.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Location = New System.Drawing.Point(228, 14)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(37, 13)
        Me.Label120.TabIndex = 22
        Me.Label120.Text = "Fecha"
        Me.Label120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoDiaTotalDevengado
        '
        Me.labPagoDiaTotalDevengado.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoDiaTotalDevengado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoDiaTotalDevengado.ForeColor = System.Drawing.Color.Black
        Me.labPagoDiaTotalDevengado.Location = New System.Drawing.Point(830, 32)
        Me.labPagoDiaTotalDevengado.Name = "labPagoDiaTotalDevengado"
        Me.labPagoDiaTotalDevengado.Size = New System.Drawing.Size(112, 20)
        Me.labPagoDiaTotalDevengado.TabIndex = 21
        Me.labPagoDiaTotalDevengado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.Location = New System.Drawing.Point(696, 36)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(128, 13)
        Me.Label137.TabIndex = 20
        Me.Label137.Text = "Total Devengado del Día"
        Me.Label137.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoDiaOtrasRet
        '
        Me.labPagoDiaOtrasRet.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoDiaOtrasRet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoDiaOtrasRet.ForeColor = System.Drawing.Color.Black
        Me.labPagoDiaOtrasRet.Location = New System.Drawing.Point(830, 104)
        Me.labPagoDiaOtrasRet.Name = "labPagoDiaOtrasRet"
        Me.labPagoDiaOtrasRet.Size = New System.Drawing.Size(112, 20)
        Me.labPagoDiaOtrasRet.TabIndex = 19
        Me.labPagoDiaOtrasRet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.Location = New System.Drawing.Point(691, 108)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(133, 13)
        Me.Label135.TabIndex = 18
        Me.Label135.Text = "Otras Retenciones del Día"
        Me.Label135.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoDiaRetAdm
        '
        Me.labPagoDiaRetAdm.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoDiaRetAdm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoDiaRetAdm.ForeColor = System.Drawing.Color.Black
        Me.labPagoDiaRetAdm.Location = New System.Drawing.Point(830, 80)
        Me.labPagoDiaRetAdm.Name = "labPagoDiaRetAdm"
        Me.labPagoDiaRetAdm.Size = New System.Drawing.Size(112, 20)
        Me.labPagoDiaRetAdm.TabIndex = 17
        Me.labPagoDiaRetAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Location = New System.Drawing.Point(706, 84)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(118, 13)
        Me.Label133.TabIndex = 16
        Me.Label133.Text = "Retención Adm del Día"
        Me.Label133.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoDiaRetISLR
        '
        Me.labPagoDiaRetISLR.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoDiaRetISLR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoDiaRetISLR.ForeColor = System.Drawing.Color.Black
        Me.labPagoDiaRetISLR.Location = New System.Drawing.Point(830, 56)
        Me.labPagoDiaRetISLR.Name = "labPagoDiaRetISLR"
        Me.labPagoDiaRetISLR.Size = New System.Drawing.Size(112, 20)
        Me.labPagoDiaRetISLR.TabIndex = 15
        Me.labPagoDiaRetISLR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Location = New System.Drawing.Point(703, 60)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(121, 13)
        Me.Label124.TabIndex = 14
        Me.Label124.Text = "Retención ISLR del Día"
        Me.Label124.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoDiaPagadoNeto
        '
        Me.labPagoDiaPagadoNeto.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoDiaPagadoNeto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoDiaPagadoNeto.ForeColor = System.Drawing.Color.Black
        Me.labPagoDiaPagadoNeto.Location = New System.Drawing.Point(830, 128)
        Me.labPagoDiaPagadoNeto.Name = "labPagoDiaPagadoNeto"
        Me.labPagoDiaPagadoNeto.Size = New System.Drawing.Size(112, 20)
        Me.labPagoDiaPagadoNeto.TabIndex = 13
        Me.labPagoDiaPagadoNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Location = New System.Drawing.Point(716, 132)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(108, 13)
        Me.Label139.TabIndex = 12
        Me.Label139.Text = "Neto Pagado del Día"
        Me.Label139.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagosDia
        '
        Me.labPagosDia.AutoSize = True
        Me.labPagosDia.Location = New System.Drawing.Point(228, 184)
        Me.labPagosDia.Name = "labPagosDia"
        Me.labPagosDia.Size = New System.Drawing.Size(37, 13)
        Me.labPagosDia.TabIndex = 4
        Me.labPagosDia.Text = "Pagos"
        Me.labPagosDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBoxPagosDia
        '
        Me.ListBoxPagosDia.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxPagosDia.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPagosDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxPagosDia.ItemHeight = 9
        Me.ListBoxPagosDia.Location = New System.Drawing.Point(216, 32)
        Me.ListBoxPagosDia.Name = "ListBoxPagosDia"
        Me.ListBoxPagosDia.Size = New System.Drawing.Size(460, 148)
        Me.ListBoxPagosDia.TabIndex = 3
        '
        'CalendarioPagosDia
        '
        Me.CalendarioPagosDia.Location = New System.Drawing.Point(8, 8)
        Me.CalendarioPagosDia.MaxSelectionCount = 1
        Me.CalendarioPagosDia.Name = "CalendarioPagosDia"
        Me.CalendarioPagosDia.ShowToday = False
        Me.CalendarioPagosDia.ShowTodayCircle = False
        Me.CalendarioPagosDia.TabIndex = 1
        '
        'TabPagePagosXmes
        '
        Me.TabPagePagosXmes.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePagosXmes.Controls.Add(Me.GroupBox9)
        Me.TabPagePagosXmes.Controls.Add(Me.labPagosMesSeleccionado)
        Me.TabPagePagosXmes.Controls.Add(Me.labPagoMesTotalDevengado)
        Me.TabPagePagosXmes.Controls.Add(Me.Label162)
        Me.TabPagePagosXmes.Controls.Add(Me.labPagoMesOtrasRet)
        Me.TabPagePagosXmes.Controls.Add(Me.Label164)
        Me.TabPagePagosXmes.Controls.Add(Me.labPagoMesRetAdm)
        Me.TabPagePagosXmes.Controls.Add(Me.Label166)
        Me.TabPagePagosXmes.Controls.Add(Me.labPagoMesRetISLR)
        Me.TabPagePagosXmes.Controls.Add(Me.Label168)
        Me.TabPagePagosXmes.Controls.Add(Me.labPagoMesPagadoNeto)
        Me.TabPagePagosXmes.Controls.Add(Me.Label170)
        Me.TabPagePagosXmes.Controls.Add(Me.chkPAGOincluyeNoFacturadosMES)
        Me.TabPagePagosXmes.Controls.Add(Me.labPagosMes)
        Me.TabPagePagosXmes.Controls.Add(Me.Label156)
        Me.TabPagePagosXmes.Controls.Add(Me.Label158)
        Me.TabPagePagosXmes.Controls.Add(Me.Label159)
        Me.TabPagePagosXmes.Controls.Add(Me.Label160)
        Me.TabPagePagosXmes.Controls.Add(Me.botPagoMesAdelantaMes)
        Me.TabPagePagosXmes.Controls.Add(Me.botPagoMesRetrocedeMes)
        Me.TabPagePagosXmes.Controls.Add(Me.ListBoxPagosMes)
        Me.TabPagePagosXmes.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePagosXmes.Name = "TabPagePagosXmes"
        Me.TabPagePagosXmes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePagosXmes.Size = New System.Drawing.Size(948, 536)
        Me.TabPagePagosXmes.TabIndex = 1
        Me.TabPagePagosXmes.Text = "Pagos x Mes"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.labPAGOmesRif)
        Me.GroupBox9.Controls.Add(Me.Label172)
        Me.GroupBox9.Controls.Add(Me.labPAGOMesPorcentajeDeRetencion)
        Me.GroupBox9.Controls.Add(Me.Label163)
        Me.GroupBox9.Controls.Add(Me.Label165)
        Me.GroupBox9.Controls.Add(Me.txtPAGOmesNotasSel)
        Me.GroupBox9.Controls.Add(Me.labPAGOmesIncluidoSel)
        Me.GroupBox9.Controls.Add(Me.labPAGOmesTotalDevengadoSel)
        Me.GroupBox9.Controls.Add(Me.labPagoMesOtrasRetSel)
        Me.GroupBox9.Controls.Add(Me.labPagoMesRetAdmSel)
        Me.GroupBox9.Controls.Add(Me.labPagoMesRetISLRsel)
        Me.GroupBox9.Controls.Add(Me.labPagoMesPagadoNetoSel)
        Me.GroupBox9.Controls.Add(Me.labPAGOmesModoPagoSel)
        Me.GroupBox9.Controls.Add(Me.labPAGOmesPagadorSel)
        Me.GroupBox9.Controls.Add(Me.labPAGOmesFacturaSel)
        Me.GroupBox9.Controls.Add(Me.labPAGOmesFechaSel)
        Me.GroupBox9.Controls.Add(Me.Label179)
        Me.GroupBox9.Controls.Add(Me.Label180)
        Me.GroupBox9.Controls.Add(Me.Label181)
        Me.GroupBox9.Controls.Add(Me.Label182)
        Me.GroupBox9.Controls.Add(Me.Label183)
        Me.GroupBox9.Controls.Add(Me.Label184)
        Me.GroupBox9.Controls.Add(Me.Label185)
        Me.GroupBox9.Controls.Add(Me.Label186)
        Me.GroupBox9.Controls.Add(Me.Label187)
        Me.GroupBox9.Controls.Add(Me.Label188)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 206)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(934, 324)
        Me.GroupBox9.TabIndex = 46
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Pago Seleccionado"
        '
        'labPAGOmesRif
        '
        Me.labPAGOmesRif.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOmesRif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOmesRif.ForeColor = System.Drawing.Color.Black
        Me.labPAGOmesRif.Location = New System.Drawing.Point(465, 36)
        Me.labPAGOmesRif.Name = "labPAGOmesRif"
        Me.labPAGOmesRif.Size = New System.Drawing.Size(96, 20)
        Me.labPAGOmesRif.TabIndex = 67
        Me.labPAGOmesRif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label172
        '
        Me.Label172.AutoSize = True
        Me.Label172.Location = New System.Drawing.Point(462, 20)
        Me.Label172.Name = "Label172"
        Me.Label172.Size = New System.Drawing.Size(41, 13)
        Me.Label172.TabIndex = 66
        Me.Label172.Text = "Rif / CI"
        Me.Label172.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOMesPorcentajeDeRetencion
        '
        Me.labPAGOMesPorcentajeDeRetencion.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOMesPorcentajeDeRetencion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOMesPorcentajeDeRetencion.ForeColor = System.Drawing.Color.Black
        Me.labPAGOMesPorcentajeDeRetencion.Location = New System.Drawing.Point(141, 264)
        Me.labPAGOMesPorcentajeDeRetencion.Name = "labPAGOMesPorcentajeDeRetencion"
        Me.labPAGOMesPorcentajeDeRetencion.Size = New System.Drawing.Size(75, 20)
        Me.labPAGOMesPorcentajeDeRetencion.TabIndex = 65
        Me.labPAGOMesPorcentajeDeRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label163
        '
        Me.Label163.AutoSize = True
        Me.Label163.Location = New System.Drawing.Point(47, 268)
        Me.Label163.Name = "Label163"
        Me.Label163.Size = New System.Drawing.Size(88, 13)
        Me.Label163.TabIndex = 64
        Me.Label163.Text = "(%) de Retención"
        Me.Label163.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label165
        '
        Me.Label165.AutoSize = True
        Me.Label165.Location = New System.Drawing.Point(279, 69)
        Me.Label165.Name = "Label165"
        Me.Label165.Size = New System.Drawing.Size(230, 13)
        Me.Label165.TabIndex = 63
        Me.Label165.Text = "Notas y Observaciones del Pago Seleccionado"
        Me.Label165.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPAGOmesNotasSel
        '
        Me.txtPAGOmesNotasSel.BackColor = System.Drawing.SystemColors.Info
        Me.txtPAGOmesNotasSel.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPAGOmesNotasSel.Location = New System.Drawing.Point(282, 86)
        Me.txtPAGOmesNotasSel.MaxLength = 5000
        Me.txtPAGOmesNotasSel.Multiline = True
        Me.txtPAGOmesNotasSel.Name = "txtPAGOmesNotasSel"
        Me.txtPAGOmesNotasSel.ReadOnly = True
        Me.txtPAGOmesNotasSel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPAGOmesNotasSel.Size = New System.Drawing.Size(635, 223)
        Me.txtPAGOmesNotasSel.TabIndex = 62
        '
        'labPAGOmesIncluidoSel
        '
        Me.labPAGOmesIncluidoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOmesIncluidoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOmesIncluidoSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOmesIncluidoSel.Location = New System.Drawing.Point(141, 289)
        Me.labPAGOmesIncluidoSel.Name = "labPAGOmesIncluidoSel"
        Me.labPAGOmesIncluidoSel.Size = New System.Drawing.Size(75, 20)
        Me.labPAGOmesIncluidoSel.TabIndex = 61
        Me.labPAGOmesIncluidoSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOmesTotalDevengadoSel
        '
        Me.labPAGOmesTotalDevengadoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOmesTotalDevengadoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOmesTotalDevengadoSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOmesTotalDevengadoSel.Location = New System.Drawing.Point(141, 86)
        Me.labPAGOmesTotalDevengadoSel.Name = "labPAGOmesTotalDevengadoSel"
        Me.labPAGOmesTotalDevengadoSel.Size = New System.Drawing.Size(112, 20)
        Me.labPAGOmesTotalDevengadoSel.TabIndex = 60
        Me.labPAGOmesTotalDevengadoSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoMesOtrasRetSel
        '
        Me.labPagoMesOtrasRetSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoMesOtrasRetSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoMesOtrasRetSel.ForeColor = System.Drawing.Color.Black
        Me.labPagoMesOtrasRetSel.Location = New System.Drawing.Point(141, 155)
        Me.labPagoMesOtrasRetSel.Name = "labPagoMesOtrasRetSel"
        Me.labPagoMesOtrasRetSel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoMesOtrasRetSel.TabIndex = 59
        Me.labPagoMesOtrasRetSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoMesRetAdmSel
        '
        Me.labPagoMesRetAdmSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoMesRetAdmSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoMesRetAdmSel.ForeColor = System.Drawing.Color.Black
        Me.labPagoMesRetAdmSel.Location = New System.Drawing.Point(141, 132)
        Me.labPagoMesRetAdmSel.Name = "labPagoMesRetAdmSel"
        Me.labPagoMesRetAdmSel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoMesRetAdmSel.TabIndex = 58
        Me.labPagoMesRetAdmSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoMesRetISLRsel
        '
        Me.labPagoMesRetISLRsel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoMesRetISLRsel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoMesRetISLRsel.ForeColor = System.Drawing.Color.Black
        Me.labPagoMesRetISLRsel.Location = New System.Drawing.Point(141, 109)
        Me.labPagoMesRetISLRsel.Name = "labPagoMesRetISLRsel"
        Me.labPagoMesRetISLRsel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoMesRetISLRsel.TabIndex = 57
        Me.labPagoMesRetISLRsel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoMesPagadoNetoSel
        '
        Me.labPagoMesPagadoNetoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoMesPagadoNetoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoMesPagadoNetoSel.ForeColor = System.Drawing.Color.Black
        Me.labPagoMesPagadoNetoSel.Location = New System.Drawing.Point(141, 178)
        Me.labPagoMesPagadoNetoSel.Name = "labPagoMesPagadoNetoSel"
        Me.labPagoMesPagadoNetoSel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoMesPagadoNetoSel.TabIndex = 56
        Me.labPagoMesPagadoNetoSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPAGOmesModoPagoSel
        '
        Me.labPAGOmesModoPagoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOmesModoPagoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOmesModoPagoSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOmesModoPagoSel.Location = New System.Drawing.Point(567, 36)
        Me.labPAGOmesModoPagoSel.Name = "labPAGOmesModoPagoSel"
        Me.labPAGOmesModoPagoSel.Size = New System.Drawing.Size(350, 20)
        Me.labPAGOmesModoPagoSel.TabIndex = 55
        Me.labPAGOmesModoPagoSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOmesPagadorSel
        '
        Me.labPAGOmesPagadorSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOmesPagadorSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOmesPagadorSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOmesPagadorSel.Location = New System.Drawing.Point(151, 36)
        Me.labPAGOmesPagadorSel.Name = "labPAGOmesPagadorSel"
        Me.labPAGOmesPagadorSel.Size = New System.Drawing.Size(308, 20)
        Me.labPAGOmesPagadorSel.TabIndex = 54
        Me.labPAGOmesPagadorSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOmesFacturaSel
        '
        Me.labPAGOmesFacturaSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOmesFacturaSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOmesFacturaSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOmesFacturaSel.Location = New System.Drawing.Point(80, 36)
        Me.labPAGOmesFacturaSel.Name = "labPAGOmesFacturaSel"
        Me.labPAGOmesFacturaSel.Size = New System.Drawing.Size(65, 20)
        Me.labPAGOmesFacturaSel.TabIndex = 53
        Me.labPAGOmesFacturaSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOmesFechaSel
        '
        Me.labPAGOmesFechaSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOmesFechaSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOmesFechaSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOmesFechaSel.Location = New System.Drawing.Point(6, 36)
        Me.labPAGOmesFechaSel.Name = "labPAGOmesFechaSel"
        Me.labPAGOmesFechaSel.Size = New System.Drawing.Size(65, 20)
        Me.labPAGOmesFechaSel.TabIndex = 52
        Me.labPAGOmesFechaSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label179
        '
        Me.Label179.AutoSize = True
        Me.Label179.Location = New System.Drawing.Point(17, 293)
        Me.Label179.Name = "Label179"
        Me.Label179.Size = New System.Drawing.Size(118, 13)
        Me.Label179.TabIndex = 51
        Me.Label179.Text = "Incluido en Facturación"
        Me.Label179.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label180
        '
        Me.Label180.AutoSize = True
        Me.Label180.Location = New System.Drawing.Point(45, 90)
        Me.Label180.Name = "Label180"
        Me.Label180.Size = New System.Drawing.Size(90, 13)
        Me.Label180.TabIndex = 50
        Me.Label180.Text = "Total Devengado"
        Me.Label180.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label181
        '
        Me.Label181.AutoSize = True
        Me.Label181.Location = New System.Drawing.Point(77, 182)
        Me.Label181.Name = "Label181"
        Me.Label181.Size = New System.Drawing.Size(58, 13)
        Me.Label181.TabIndex = 49
        Me.Label181.Text = "Pago Neto"
        Me.Label181.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label182
        '
        Me.Label182.AutoSize = True
        Me.Label182.Location = New System.Drawing.Point(40, 159)
        Me.Label182.Name = "Label182"
        Me.Label182.Size = New System.Drawing.Size(95, 13)
        Me.Label182.TabIndex = 48
        Me.Label182.Text = "Otras Retenciones"
        Me.Label182.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label183
        '
        Me.Label183.AutoSize = True
        Me.Label183.Location = New System.Drawing.Point(52, 113)
        Me.Label183.Name = "Label183"
        Me.Label183.Size = New System.Drawing.Size(83, 13)
        Me.Label183.TabIndex = 47
        Me.Label183.Text = "Retencion ISLR"
        Me.Label183.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label184
        '
        Me.Label184.AutoSize = True
        Me.Label184.Location = New System.Drawing.Point(11, 136)
        Me.Label184.Name = "Label184"
        Me.Label184.Size = New System.Drawing.Size(124, 13)
        Me.Label184.TabIndex = 46
        Me.Label184.Text = "Retencion Administrativa"
        Me.Label184.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label185
        '
        Me.Label185.AutoSize = True
        Me.Label185.Location = New System.Drawing.Point(77, 20)
        Me.Label185.Name = "Label185"
        Me.Label185.Size = New System.Drawing.Size(43, 13)
        Me.Label185.TabIndex = 45
        Me.Label185.Text = "Factura"
        Me.Label185.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label186
        '
        Me.Label186.AutoSize = True
        Me.Label186.Location = New System.Drawing.Point(564, 20)
        Me.Label186.Name = "Label186"
        Me.Label186.Size = New System.Drawing.Size(77, 13)
        Me.Label186.TabIndex = 44
        Me.Label186.Text = "Modo de Pago"
        Me.Label186.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label187
        '
        Me.Label187.AutoSize = True
        Me.Label187.Location = New System.Drawing.Point(150, 20)
        Me.Label187.Name = "Label187"
        Me.Label187.Size = New System.Drawing.Size(47, 13)
        Me.Label187.TabIndex = 43
        Me.Label187.Text = "Pagador"
        Me.Label187.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label188
        '
        Me.Label188.AutoSize = True
        Me.Label188.Location = New System.Drawing.Point(6, 20)
        Me.Label188.Name = "Label188"
        Me.Label188.Size = New System.Drawing.Size(37, 13)
        Me.Label188.TabIndex = 42
        Me.Label188.Text = "Fecha"
        Me.Label188.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagosMesSeleccionado
        '
        Me.labPagosMesSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labPagosMesSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPagosMesSeleccionado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labPagosMesSeleccionado.Location = New System.Drawing.Point(35, 31)
        Me.labPagosMesSeleccionado.Name = "labPagosMesSeleccionado"
        Me.labPagosMesSeleccionado.Size = New System.Drawing.Size(122, 23)
        Me.labPagosMesSeleccionado.TabIndex = 45
        Me.labPagosMesSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPagoMesTotalDevengado
        '
        Me.labPagoMesTotalDevengado.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoMesTotalDevengado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoMesTotalDevengado.ForeColor = System.Drawing.Color.Black
        Me.labPagoMesTotalDevengado.Location = New System.Drawing.Point(830, 32)
        Me.labPagoMesTotalDevengado.Name = "labPagoMesTotalDevengado"
        Me.labPagoMesTotalDevengado.Size = New System.Drawing.Size(112, 20)
        Me.labPagoMesTotalDevengado.TabIndex = 42
        Me.labPagoMesTotalDevengado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label162
        '
        Me.Label162.AutoSize = True
        Me.Label162.Location = New System.Drawing.Point(696, 36)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(130, 13)
        Me.Label162.TabIndex = 41
        Me.Label162.Text = "Total Devengado del Mes"
        Me.Label162.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoMesOtrasRet
        '
        Me.labPagoMesOtrasRet.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoMesOtrasRet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoMesOtrasRet.ForeColor = System.Drawing.Color.Black
        Me.labPagoMesOtrasRet.Location = New System.Drawing.Point(830, 104)
        Me.labPagoMesOtrasRet.Name = "labPagoMesOtrasRet"
        Me.labPagoMesOtrasRet.Size = New System.Drawing.Size(112, 20)
        Me.labPagoMesOtrasRet.TabIndex = 40
        Me.labPagoMesOtrasRet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label164
        '
        Me.Label164.AutoSize = True
        Me.Label164.Location = New System.Drawing.Point(691, 108)
        Me.Label164.Name = "Label164"
        Me.Label164.Size = New System.Drawing.Size(135, 13)
        Me.Label164.TabIndex = 39
        Me.Label164.Text = "Otras Retenciones del Mes"
        Me.Label164.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoMesRetAdm
        '
        Me.labPagoMesRetAdm.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoMesRetAdm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoMesRetAdm.ForeColor = System.Drawing.Color.Black
        Me.labPagoMesRetAdm.Location = New System.Drawing.Point(830, 80)
        Me.labPagoMesRetAdm.Name = "labPagoMesRetAdm"
        Me.labPagoMesRetAdm.Size = New System.Drawing.Size(112, 20)
        Me.labPagoMesRetAdm.TabIndex = 38
        Me.labPagoMesRetAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label166
        '
        Me.Label166.AutoSize = True
        Me.Label166.Location = New System.Drawing.Point(706, 84)
        Me.Label166.Name = "Label166"
        Me.Label166.Size = New System.Drawing.Size(120, 13)
        Me.Label166.TabIndex = 37
        Me.Label166.Text = "Retención Adm del Mes"
        Me.Label166.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoMesRetISLR
        '
        Me.labPagoMesRetISLR.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoMesRetISLR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoMesRetISLR.ForeColor = System.Drawing.Color.Black
        Me.labPagoMesRetISLR.Location = New System.Drawing.Point(830, 56)
        Me.labPagoMesRetISLR.Name = "labPagoMesRetISLR"
        Me.labPagoMesRetISLR.Size = New System.Drawing.Size(112, 20)
        Me.labPagoMesRetISLR.TabIndex = 36
        Me.labPagoMesRetISLR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label168
        '
        Me.Label168.AutoSize = True
        Me.Label168.Location = New System.Drawing.Point(703, 60)
        Me.Label168.Name = "Label168"
        Me.Label168.Size = New System.Drawing.Size(123, 13)
        Me.Label168.TabIndex = 35
        Me.Label168.Text = "Retención ISLR del Mes"
        Me.Label168.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoMesPagadoNeto
        '
        Me.labPagoMesPagadoNeto.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoMesPagadoNeto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoMesPagadoNeto.ForeColor = System.Drawing.Color.Black
        Me.labPagoMesPagadoNeto.Location = New System.Drawing.Point(830, 128)
        Me.labPagoMesPagadoNeto.Name = "labPagoMesPagadoNeto"
        Me.labPagoMesPagadoNeto.Size = New System.Drawing.Size(112, 20)
        Me.labPagoMesPagadoNeto.TabIndex = 34
        Me.labPagoMesPagadoNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label170
        '
        Me.Label170.AutoSize = True
        Me.Label170.Location = New System.Drawing.Point(716, 132)
        Me.Label170.Name = "Label170"
        Me.Label170.Size = New System.Drawing.Size(110, 13)
        Me.Label170.TabIndex = 33
        Me.Label170.Text = "Neto Pagado del Mes"
        Me.Label170.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPAGOincluyeNoFacturadosMES
        '
        Me.chkPAGOincluyeNoFacturadosMES.AutoSize = True
        Me.chkPAGOincluyeNoFacturadosMES.Checked = True
        Me.chkPAGOincluyeNoFacturadosMES.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPAGOincluyeNoFacturadosMES.Location = New System.Drawing.Point(8, 183)
        Me.chkPAGOincluyeNoFacturadosMES.Name = "chkPAGOincluyeNoFacturadosMES"
        Me.chkPAGOincluyeNoFacturadosMES.Size = New System.Drawing.Size(197, 17)
        Me.chkPAGOincluyeNoFacturadosMES.TabIndex = 32
        Me.chkPAGOincluyeNoFacturadosMES.Text = "Incluye Facturados y No Facturados"
        Me.chkPAGOincluyeNoFacturadosMES.UseVisualStyleBackColor = True
        '
        'labPagosMes
        '
        Me.labPagosMes.AutoSize = True
        Me.labPagosMes.Location = New System.Drawing.Point(228, 184)
        Me.labPagosMes.Name = "labPagosMes"
        Me.labPagosMes.Size = New System.Drawing.Size(37, 13)
        Me.labPagosMes.TabIndex = 31
        Me.labPagosMes.Text = "Pagos"
        Me.labPagosMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Location = New System.Drawing.Point(593, 14)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(73, 13)
        Me.Label156.TabIndex = 30
        Me.Label156.Text = "Neto Cobrado"
        Me.Label156.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Location = New System.Drawing.Point(348, 14)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(47, 13)
        Me.Label158.TabIndex = 29
        Me.Label158.Text = "Pagador"
        Me.Label158.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label159
        '
        Me.Label159.AutoSize = True
        Me.Label159.Location = New System.Drawing.Point(287, 14)
        Me.Label159.Name = "Label159"
        Me.Label159.Size = New System.Drawing.Size(43, 13)
        Me.Label159.TabIndex = 28
        Me.Label159.Text = "Factura"
        Me.Label159.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label160
        '
        Me.Label160.AutoSize = True
        Me.Label160.Location = New System.Drawing.Point(228, 14)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(37, 13)
        Me.Label160.TabIndex = 27
        Me.Label160.Text = "Fecha"
        Me.Label160.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botPagoMesAdelantaMes
        '
        Me.botPagoMesAdelantaMes.BackgroundImage = Global.Historias.My.Resources.Resources.BotonFlechaDerOff
        Me.botPagoMesAdelantaMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botPagoMesAdelantaMes.Location = New System.Drawing.Point(156, 28)
        Me.botPagoMesAdelantaMes.Name = "botPagoMesAdelantaMes"
        Me.botPagoMesAdelantaMes.Size = New System.Drawing.Size(28, 28)
        Me.botPagoMesAdelantaMes.TabIndex = 44
        Me.botPagoMesAdelantaMes.UseVisualStyleBackColor = True
        '
        'botPagoMesRetrocedeMes
        '
        Me.botPagoMesRetrocedeMes.BackgroundImage = Global.Historias.My.Resources.Resources.BotonFlechaIzqOff
        Me.botPagoMesRetrocedeMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botPagoMesRetrocedeMes.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botPagoMesRetrocedeMes.Location = New System.Drawing.Point(8, 28)
        Me.botPagoMesRetrocedeMes.Name = "botPagoMesRetrocedeMes"
        Me.botPagoMesRetrocedeMes.Size = New System.Drawing.Size(28, 28)
        Me.botPagoMesRetrocedeMes.TabIndex = 43
        Me.botPagoMesRetrocedeMes.UseVisualStyleBackColor = True
        '
        'ListBoxPagosMes
        '
        Me.ListBoxPagosMes.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxPagosMes.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPagosMes.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxPagosMes.ItemHeight = 9
        Me.ListBoxPagosMes.Location = New System.Drawing.Point(216, 32)
        Me.ListBoxPagosMes.Name = "ListBoxPagosMes"
        Me.ListBoxPagosMes.Size = New System.Drawing.Size(460, 148)
        Me.ListBoxPagosMes.TabIndex = 26
        '
        'TabPagePagosXaño
        '
        Me.TabPagePagosXaño.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePagosXaño.Controls.Add(Me.ProgressBarAÑO)
        Me.TabPagePagosXaño.Controls.Add(Me.GroupBox10)
        Me.TabPagePagosXaño.Controls.Add(Me.labPagosAñoSeleccionado)
        Me.TabPagePagosXaño.Controls.Add(Me.labPagoAñoTotalDevengado)
        Me.TabPagePagosXaño.Controls.Add(Me.Label203)
        Me.TabPagePagosXaño.Controls.Add(Me.labPagoAñoOtrasRet)
        Me.TabPagePagosXaño.Controls.Add(Me.Label205)
        Me.TabPagePagosXaño.Controls.Add(Me.labPagoAñoRetAdm)
        Me.TabPagePagosXaño.Controls.Add(Me.Label207)
        Me.TabPagePagosXaño.Controls.Add(Me.labPagoAñoRetISLR)
        Me.TabPagePagosXaño.Controls.Add(Me.Label209)
        Me.TabPagePagosXaño.Controls.Add(Me.labPagoAñoPagadoNeto)
        Me.TabPagePagosXaño.Controls.Add(Me.Label211)
        Me.TabPagePagosXaño.Controls.Add(Me.chkPAGOincluyeNoFacturadosAÑO)
        Me.TabPagePagosXaño.Controls.Add(Me.labPagosAño)
        Me.TabPagePagosXaño.Controls.Add(Me.Label213)
        Me.TabPagePagosXaño.Controls.Add(Me.Label214)
        Me.TabPagePagosXaño.Controls.Add(Me.Label215)
        Me.TabPagePagosXaño.Controls.Add(Me.Label216)
        Me.TabPagePagosXaño.Controls.Add(Me.botPagoAÑOAdelantaAño)
        Me.TabPagePagosXaño.Controls.Add(Me.botPagoaÑORetrocedeAño)
        Me.TabPagePagosXaño.Controls.Add(Me.ListBoxPagosAño)
        Me.TabPagePagosXaño.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePagosXaño.Name = "TabPagePagosXaño"
        Me.TabPagePagosXaño.Size = New System.Drawing.Size(948, 536)
        Me.TabPagePagosXaño.TabIndex = 2
        Me.TabPagePagosXaño.Text = "Pagos x Año"
        '
        'ProgressBarAÑO
        '
        Me.ProgressBarAÑO.Location = New System.Drawing.Point(8, 62)
        Me.ProgressBarAÑO.Name = "ProgressBarAÑO"
        Me.ProgressBarAÑO.Size = New System.Drawing.Size(176, 11)
        Me.ProgressBarAÑO.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBarAÑO.TabIndex = 68
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.labPAGOañoRif)
        Me.GroupBox10.Controls.Add(Me.Label174)
        Me.GroupBox10.Controls.Add(Me.labPAGOAñoPorcentajeDeRetencion)
        Me.GroupBox10.Controls.Add(Me.Label167)
        Me.GroupBox10.Controls.Add(Me.Label169)
        Me.GroupBox10.Controls.Add(Me.txtPAGOañoNotasSel)
        Me.GroupBox10.Controls.Add(Me.labPAGOañoIncluidoSel)
        Me.GroupBox10.Controls.Add(Me.labPAGOañoTotalDevengadoSel)
        Me.GroupBox10.Controls.Add(Me.labPagoAñoOtrasRetSel)
        Me.GroupBox10.Controls.Add(Me.labPagoAñoRetAdmSel)
        Me.GroupBox10.Controls.Add(Me.labPagoAñoRetISLRsel)
        Me.GroupBox10.Controls.Add(Me.labPagoAñoPagadoNetoSel)
        Me.GroupBox10.Controls.Add(Me.labPAGOañoModoPagoSel)
        Me.GroupBox10.Controls.Add(Me.labPAGOañoPagadorSel)
        Me.GroupBox10.Controls.Add(Me.labPAGOañoFacturaSel)
        Me.GroupBox10.Controls.Add(Me.labPAGOañoFechaSel)
        Me.GroupBox10.Controls.Add(Me.Label191)
        Me.GroupBox10.Controls.Add(Me.Label192)
        Me.GroupBox10.Controls.Add(Me.Label193)
        Me.GroupBox10.Controls.Add(Me.Label194)
        Me.GroupBox10.Controls.Add(Me.Label195)
        Me.GroupBox10.Controls.Add(Me.Label196)
        Me.GroupBox10.Controls.Add(Me.Label197)
        Me.GroupBox10.Controls.Add(Me.Label198)
        Me.GroupBox10.Controls.Add(Me.Label199)
        Me.GroupBox10.Controls.Add(Me.Label200)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 206)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(934, 324)
        Me.GroupBox10.TabIndex = 67
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Pago Seleccionado"
        '
        'labPAGOañoRif
        '
        Me.labPAGOañoRif.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOañoRif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOañoRif.ForeColor = System.Drawing.Color.Black
        Me.labPAGOañoRif.Location = New System.Drawing.Point(465, 36)
        Me.labPAGOañoRif.Name = "labPAGOañoRif"
        Me.labPAGOañoRif.Size = New System.Drawing.Size(96, 20)
        Me.labPAGOañoRif.TabIndex = 69
        Me.labPAGOañoRif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label174
        '
        Me.Label174.AutoSize = True
        Me.Label174.Location = New System.Drawing.Point(462, 20)
        Me.Label174.Name = "Label174"
        Me.Label174.Size = New System.Drawing.Size(41, 13)
        Me.Label174.TabIndex = 68
        Me.Label174.Text = "Rif / CI"
        Me.Label174.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOAñoPorcentajeDeRetencion
        '
        Me.labPAGOAñoPorcentajeDeRetencion.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOAñoPorcentajeDeRetencion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOAñoPorcentajeDeRetencion.ForeColor = System.Drawing.Color.Black
        Me.labPAGOAñoPorcentajeDeRetencion.Location = New System.Drawing.Point(141, 264)
        Me.labPAGOAñoPorcentajeDeRetencion.Name = "labPAGOAñoPorcentajeDeRetencion"
        Me.labPAGOAñoPorcentajeDeRetencion.Size = New System.Drawing.Size(75, 20)
        Me.labPAGOAñoPorcentajeDeRetencion.TabIndex = 65
        Me.labPAGOAñoPorcentajeDeRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label167
        '
        Me.Label167.AutoSize = True
        Me.Label167.Location = New System.Drawing.Point(47, 268)
        Me.Label167.Name = "Label167"
        Me.Label167.Size = New System.Drawing.Size(88, 13)
        Me.Label167.TabIndex = 64
        Me.Label167.Text = "(%) de Retención"
        Me.Label167.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label169
        '
        Me.Label169.AutoSize = True
        Me.Label169.Location = New System.Drawing.Point(279, 69)
        Me.Label169.Name = "Label169"
        Me.Label169.Size = New System.Drawing.Size(230, 13)
        Me.Label169.TabIndex = 63
        Me.Label169.Text = "Notas y Observaciones del Pago Seleccionado"
        Me.Label169.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPAGOañoNotasSel
        '
        Me.txtPAGOañoNotasSel.BackColor = System.Drawing.SystemColors.Info
        Me.txtPAGOañoNotasSel.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPAGOañoNotasSel.Location = New System.Drawing.Point(282, 86)
        Me.txtPAGOañoNotasSel.MaxLength = 5000
        Me.txtPAGOañoNotasSel.Multiline = True
        Me.txtPAGOañoNotasSel.Name = "txtPAGOañoNotasSel"
        Me.txtPAGOañoNotasSel.ReadOnly = True
        Me.txtPAGOañoNotasSel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPAGOañoNotasSel.Size = New System.Drawing.Size(635, 223)
        Me.txtPAGOañoNotasSel.TabIndex = 62
        '
        'labPAGOañoIncluidoSel
        '
        Me.labPAGOañoIncluidoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOañoIncluidoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOañoIncluidoSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOañoIncluidoSel.Location = New System.Drawing.Point(141, 289)
        Me.labPAGOañoIncluidoSel.Name = "labPAGOañoIncluidoSel"
        Me.labPAGOañoIncluidoSel.Size = New System.Drawing.Size(75, 20)
        Me.labPAGOañoIncluidoSel.TabIndex = 61
        Me.labPAGOañoIncluidoSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOañoTotalDevengadoSel
        '
        Me.labPAGOañoTotalDevengadoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOañoTotalDevengadoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOañoTotalDevengadoSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOañoTotalDevengadoSel.Location = New System.Drawing.Point(141, 86)
        Me.labPAGOañoTotalDevengadoSel.Name = "labPAGOañoTotalDevengadoSel"
        Me.labPAGOañoTotalDevengadoSel.Size = New System.Drawing.Size(112, 20)
        Me.labPAGOañoTotalDevengadoSel.TabIndex = 60
        Me.labPAGOañoTotalDevengadoSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoAñoOtrasRetSel
        '
        Me.labPagoAñoOtrasRetSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoAñoOtrasRetSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoAñoOtrasRetSel.ForeColor = System.Drawing.Color.Black
        Me.labPagoAñoOtrasRetSel.Location = New System.Drawing.Point(141, 155)
        Me.labPagoAñoOtrasRetSel.Name = "labPagoAñoOtrasRetSel"
        Me.labPagoAñoOtrasRetSel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoAñoOtrasRetSel.TabIndex = 59
        Me.labPagoAñoOtrasRetSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoAñoRetAdmSel
        '
        Me.labPagoAñoRetAdmSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoAñoRetAdmSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoAñoRetAdmSel.ForeColor = System.Drawing.Color.Black
        Me.labPagoAñoRetAdmSel.Location = New System.Drawing.Point(141, 132)
        Me.labPagoAñoRetAdmSel.Name = "labPagoAñoRetAdmSel"
        Me.labPagoAñoRetAdmSel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoAñoRetAdmSel.TabIndex = 58
        Me.labPagoAñoRetAdmSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoAñoRetISLRsel
        '
        Me.labPagoAñoRetISLRsel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoAñoRetISLRsel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoAñoRetISLRsel.ForeColor = System.Drawing.Color.Black
        Me.labPagoAñoRetISLRsel.Location = New System.Drawing.Point(141, 109)
        Me.labPagoAñoRetISLRsel.Name = "labPagoAñoRetISLRsel"
        Me.labPagoAñoRetISLRsel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoAñoRetISLRsel.TabIndex = 57
        Me.labPagoAñoRetISLRsel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagoAñoPagadoNetoSel
        '
        Me.labPagoAñoPagadoNetoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoAñoPagadoNetoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoAñoPagadoNetoSel.ForeColor = System.Drawing.Color.Black
        Me.labPagoAñoPagadoNetoSel.Location = New System.Drawing.Point(141, 178)
        Me.labPagoAñoPagadoNetoSel.Name = "labPagoAñoPagadoNetoSel"
        Me.labPagoAñoPagadoNetoSel.Size = New System.Drawing.Size(112, 20)
        Me.labPagoAñoPagadoNetoSel.TabIndex = 56
        Me.labPagoAñoPagadoNetoSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPAGOañoModoPagoSel
        '
        Me.labPAGOañoModoPagoSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOañoModoPagoSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOañoModoPagoSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOañoModoPagoSel.Location = New System.Drawing.Point(567, 36)
        Me.labPAGOañoModoPagoSel.Name = "labPAGOañoModoPagoSel"
        Me.labPAGOañoModoPagoSel.Size = New System.Drawing.Size(350, 20)
        Me.labPAGOañoModoPagoSel.TabIndex = 55
        Me.labPAGOañoModoPagoSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOañoPagadorSel
        '
        Me.labPAGOañoPagadorSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOañoPagadorSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOañoPagadorSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOañoPagadorSel.Location = New System.Drawing.Point(151, 36)
        Me.labPAGOañoPagadorSel.Name = "labPAGOañoPagadorSel"
        Me.labPAGOañoPagadorSel.Size = New System.Drawing.Size(308, 20)
        Me.labPAGOañoPagadorSel.TabIndex = 54
        Me.labPAGOañoPagadorSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOañoFacturaSel
        '
        Me.labPAGOañoFacturaSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOañoFacturaSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOañoFacturaSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOañoFacturaSel.Location = New System.Drawing.Point(80, 36)
        Me.labPAGOañoFacturaSel.Name = "labPAGOañoFacturaSel"
        Me.labPAGOañoFacturaSel.Size = New System.Drawing.Size(65, 20)
        Me.labPAGOañoFacturaSel.TabIndex = 53
        Me.labPAGOañoFacturaSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOañoFechaSel
        '
        Me.labPAGOañoFechaSel.BackColor = System.Drawing.SystemColors.Info
        Me.labPAGOañoFechaSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPAGOañoFechaSel.ForeColor = System.Drawing.Color.Black
        Me.labPAGOañoFechaSel.Location = New System.Drawing.Point(6, 36)
        Me.labPAGOañoFechaSel.Name = "labPAGOañoFechaSel"
        Me.labPAGOañoFechaSel.Size = New System.Drawing.Size(65, 20)
        Me.labPAGOañoFechaSel.TabIndex = 52
        Me.labPAGOañoFechaSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label191
        '
        Me.Label191.AutoSize = True
        Me.Label191.Location = New System.Drawing.Point(17, 293)
        Me.Label191.Name = "Label191"
        Me.Label191.Size = New System.Drawing.Size(118, 13)
        Me.Label191.TabIndex = 51
        Me.Label191.Text = "Incluido en Facturación"
        Me.Label191.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label192
        '
        Me.Label192.AutoSize = True
        Me.Label192.Location = New System.Drawing.Point(45, 90)
        Me.Label192.Name = "Label192"
        Me.Label192.Size = New System.Drawing.Size(90, 13)
        Me.Label192.TabIndex = 50
        Me.Label192.Text = "Total Devengado"
        Me.Label192.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label193
        '
        Me.Label193.AutoSize = True
        Me.Label193.Location = New System.Drawing.Point(77, 182)
        Me.Label193.Name = "Label193"
        Me.Label193.Size = New System.Drawing.Size(58, 13)
        Me.Label193.TabIndex = 49
        Me.Label193.Text = "Pago Neto"
        Me.Label193.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label194
        '
        Me.Label194.AutoSize = True
        Me.Label194.Location = New System.Drawing.Point(40, 159)
        Me.Label194.Name = "Label194"
        Me.Label194.Size = New System.Drawing.Size(95, 13)
        Me.Label194.TabIndex = 48
        Me.Label194.Text = "Otras Retenciones"
        Me.Label194.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label195
        '
        Me.Label195.AutoSize = True
        Me.Label195.Location = New System.Drawing.Point(52, 113)
        Me.Label195.Name = "Label195"
        Me.Label195.Size = New System.Drawing.Size(83, 13)
        Me.Label195.TabIndex = 47
        Me.Label195.Text = "Retencion ISLR"
        Me.Label195.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label196
        '
        Me.Label196.AutoSize = True
        Me.Label196.Location = New System.Drawing.Point(11, 136)
        Me.Label196.Name = "Label196"
        Me.Label196.Size = New System.Drawing.Size(124, 13)
        Me.Label196.TabIndex = 46
        Me.Label196.Text = "Retencion Administrativa"
        Me.Label196.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label197
        '
        Me.Label197.AutoSize = True
        Me.Label197.Location = New System.Drawing.Point(77, 20)
        Me.Label197.Name = "Label197"
        Me.Label197.Size = New System.Drawing.Size(43, 13)
        Me.Label197.TabIndex = 45
        Me.Label197.Text = "Factura"
        Me.Label197.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label198
        '
        Me.Label198.AutoSize = True
        Me.Label198.Location = New System.Drawing.Point(564, 20)
        Me.Label198.Name = "Label198"
        Me.Label198.Size = New System.Drawing.Size(77, 13)
        Me.Label198.TabIndex = 44
        Me.Label198.Text = "Modo de Pago"
        Me.Label198.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label199
        '
        Me.Label199.AutoSize = True
        Me.Label199.Location = New System.Drawing.Point(150, 20)
        Me.Label199.Name = "Label199"
        Me.Label199.Size = New System.Drawing.Size(47, 13)
        Me.Label199.TabIndex = 43
        Me.Label199.Text = "Pagador"
        Me.Label199.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label200
        '
        Me.Label200.AutoSize = True
        Me.Label200.Location = New System.Drawing.Point(6, 20)
        Me.Label200.Name = "Label200"
        Me.Label200.Size = New System.Drawing.Size(37, 13)
        Me.Label200.TabIndex = 42
        Me.Label200.Text = "Fecha"
        Me.Label200.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagosAñoSeleccionado
        '
        Me.labPagosAñoSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labPagosAñoSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPagosAñoSeleccionado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labPagosAñoSeleccionado.Location = New System.Drawing.Point(35, 31)
        Me.labPagosAñoSeleccionado.Name = "labPagosAñoSeleccionado"
        Me.labPagosAñoSeleccionado.Size = New System.Drawing.Size(122, 23)
        Me.labPagosAñoSeleccionado.TabIndex = 66
        Me.labPagosAñoSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPagoAñoTotalDevengado
        '
        Me.labPagoAñoTotalDevengado.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoAñoTotalDevengado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoAñoTotalDevengado.ForeColor = System.Drawing.Color.Black
        Me.labPagoAñoTotalDevengado.Location = New System.Drawing.Point(830, 32)
        Me.labPagoAñoTotalDevengado.Name = "labPagoAñoTotalDevengado"
        Me.labPagoAñoTotalDevengado.Size = New System.Drawing.Size(112, 20)
        Me.labPagoAñoTotalDevengado.TabIndex = 63
        Me.labPagoAñoTotalDevengado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label203
        '
        Me.Label203.AutoSize = True
        Me.Label203.Location = New System.Drawing.Point(696, 36)
        Me.Label203.Name = "Label203"
        Me.Label203.Size = New System.Drawing.Size(129, 13)
        Me.Label203.TabIndex = 62
        Me.Label203.Text = "Total Devengado del Año"
        Me.Label203.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoAñoOtrasRet
        '
        Me.labPagoAñoOtrasRet.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoAñoOtrasRet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoAñoOtrasRet.ForeColor = System.Drawing.Color.Black
        Me.labPagoAñoOtrasRet.Location = New System.Drawing.Point(830, 104)
        Me.labPagoAñoOtrasRet.Name = "labPagoAñoOtrasRet"
        Me.labPagoAñoOtrasRet.Size = New System.Drawing.Size(112, 20)
        Me.labPagoAñoOtrasRet.TabIndex = 61
        Me.labPagoAñoOtrasRet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label205
        '
        Me.Label205.AutoSize = True
        Me.Label205.Location = New System.Drawing.Point(691, 108)
        Me.Label205.Name = "Label205"
        Me.Label205.Size = New System.Drawing.Size(134, 13)
        Me.Label205.TabIndex = 60
        Me.Label205.Text = "Otras Retenciones del Año"
        Me.Label205.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoAñoRetAdm
        '
        Me.labPagoAñoRetAdm.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoAñoRetAdm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoAñoRetAdm.ForeColor = System.Drawing.Color.Black
        Me.labPagoAñoRetAdm.Location = New System.Drawing.Point(830, 80)
        Me.labPagoAñoRetAdm.Name = "labPagoAñoRetAdm"
        Me.labPagoAñoRetAdm.Size = New System.Drawing.Size(112, 20)
        Me.labPagoAñoRetAdm.TabIndex = 59
        Me.labPagoAñoRetAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label207
        '
        Me.Label207.AutoSize = True
        Me.Label207.Location = New System.Drawing.Point(706, 84)
        Me.Label207.Name = "Label207"
        Me.Label207.Size = New System.Drawing.Size(119, 13)
        Me.Label207.TabIndex = 58
        Me.Label207.Text = "Retención Adm del Año"
        Me.Label207.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoAñoRetISLR
        '
        Me.labPagoAñoRetISLR.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoAñoRetISLR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoAñoRetISLR.ForeColor = System.Drawing.Color.Black
        Me.labPagoAñoRetISLR.Location = New System.Drawing.Point(830, 56)
        Me.labPagoAñoRetISLR.Name = "labPagoAñoRetISLR"
        Me.labPagoAñoRetISLR.Size = New System.Drawing.Size(112, 20)
        Me.labPagoAñoRetISLR.TabIndex = 57
        Me.labPagoAñoRetISLR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label209
        '
        Me.Label209.AutoSize = True
        Me.Label209.Location = New System.Drawing.Point(703, 60)
        Me.Label209.Name = "Label209"
        Me.Label209.Size = New System.Drawing.Size(122, 13)
        Me.Label209.TabIndex = 56
        Me.Label209.Text = "Retención ISLR del Año"
        Me.Label209.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPagoAñoPagadoNeto
        '
        Me.labPagoAñoPagadoNeto.BackColor = System.Drawing.SystemColors.Info
        Me.labPagoAñoPagadoNeto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagoAñoPagadoNeto.ForeColor = System.Drawing.Color.Black
        Me.labPagoAñoPagadoNeto.Location = New System.Drawing.Point(830, 128)
        Me.labPagoAñoPagadoNeto.Name = "labPagoAñoPagadoNeto"
        Me.labPagoAñoPagadoNeto.Size = New System.Drawing.Size(112, 20)
        Me.labPagoAñoPagadoNeto.TabIndex = 55
        Me.labPagoAñoPagadoNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label211
        '
        Me.Label211.AutoSize = True
        Me.Label211.Location = New System.Drawing.Point(716, 132)
        Me.Label211.Name = "Label211"
        Me.Label211.Size = New System.Drawing.Size(109, 13)
        Me.Label211.TabIndex = 54
        Me.Label211.Text = "Neto Pagado del Año"
        Me.Label211.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPAGOincluyeNoFacturadosAÑO
        '
        Me.chkPAGOincluyeNoFacturadosAÑO.AutoSize = True
        Me.chkPAGOincluyeNoFacturadosAÑO.Checked = True
        Me.chkPAGOincluyeNoFacturadosAÑO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPAGOincluyeNoFacturadosAÑO.Location = New System.Drawing.Point(8, 183)
        Me.chkPAGOincluyeNoFacturadosAÑO.Name = "chkPAGOincluyeNoFacturadosAÑO"
        Me.chkPAGOincluyeNoFacturadosAÑO.Size = New System.Drawing.Size(197, 17)
        Me.chkPAGOincluyeNoFacturadosAÑO.TabIndex = 53
        Me.chkPAGOincluyeNoFacturadosAÑO.Text = "Incluye Facturados y No Facturados"
        Me.chkPAGOincluyeNoFacturadosAÑO.UseVisualStyleBackColor = True
        '
        'labPagosAño
        '
        Me.labPagosAño.AutoSize = True
        Me.labPagosAño.Location = New System.Drawing.Point(228, 184)
        Me.labPagosAño.Name = "labPagosAño"
        Me.labPagosAño.Size = New System.Drawing.Size(37, 13)
        Me.labPagosAño.TabIndex = 52
        Me.labPagosAño.Text = "Pagos"
        Me.labPagosAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label213
        '
        Me.Label213.AutoSize = True
        Me.Label213.Location = New System.Drawing.Point(593, 14)
        Me.Label213.Name = "Label213"
        Me.Label213.Size = New System.Drawing.Size(73, 13)
        Me.Label213.TabIndex = 51
        Me.Label213.Text = "Neto Cobrado"
        Me.Label213.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label214
        '
        Me.Label214.AutoSize = True
        Me.Label214.Location = New System.Drawing.Point(348, 14)
        Me.Label214.Name = "Label214"
        Me.Label214.Size = New System.Drawing.Size(47, 13)
        Me.Label214.TabIndex = 50
        Me.Label214.Text = "Pagador"
        Me.Label214.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label215
        '
        Me.Label215.AutoSize = True
        Me.Label215.Location = New System.Drawing.Point(287, 14)
        Me.Label215.Name = "Label215"
        Me.Label215.Size = New System.Drawing.Size(43, 13)
        Me.Label215.TabIndex = 49
        Me.Label215.Text = "Factura"
        Me.Label215.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label216
        '
        Me.Label216.AutoSize = True
        Me.Label216.Location = New System.Drawing.Point(228, 14)
        Me.Label216.Name = "Label216"
        Me.Label216.Size = New System.Drawing.Size(37, 13)
        Me.Label216.TabIndex = 48
        Me.Label216.Text = "Fecha"
        Me.Label216.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botPagoAÑOAdelantaAño
        '
        Me.botPagoAÑOAdelantaAño.BackgroundImage = Global.Historias.My.Resources.Resources.BotonFlechaDerOff
        Me.botPagoAÑOAdelantaAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botPagoAÑOAdelantaAño.Location = New System.Drawing.Point(156, 28)
        Me.botPagoAÑOAdelantaAño.Name = "botPagoAÑOAdelantaAño"
        Me.botPagoAÑOAdelantaAño.Size = New System.Drawing.Size(28, 28)
        Me.botPagoAÑOAdelantaAño.TabIndex = 65
        Me.botPagoAÑOAdelantaAño.UseVisualStyleBackColor = True
        '
        'botPagoaÑORetrocedeAño
        '
        Me.botPagoaÑORetrocedeAño.BackgroundImage = Global.Historias.My.Resources.Resources.BotonFlechaIzqOff
        Me.botPagoaÑORetrocedeAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botPagoaÑORetrocedeAño.Location = New System.Drawing.Point(8, 28)
        Me.botPagoaÑORetrocedeAño.Name = "botPagoaÑORetrocedeAño"
        Me.botPagoaÑORetrocedeAño.Size = New System.Drawing.Size(28, 28)
        Me.botPagoaÑORetrocedeAño.TabIndex = 64
        Me.botPagoaÑORetrocedeAño.UseVisualStyleBackColor = True
        '
        'ListBoxPagosAño
        '
        Me.ListBoxPagosAño.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxPagosAño.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPagosAño.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxPagosAño.ItemHeight = 9
        Me.ListBoxPagosAño.Location = New System.Drawing.Point(216, 32)
        Me.ListBoxPagosAño.Name = "ListBoxPagosAño"
        Me.ListBoxPagosAño.Size = New System.Drawing.Size(460, 148)
        Me.ListBoxPagosAño.TabIndex = 47
        '
        'TabPageISLR
        '
        Me.TabPageISLR.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageISLR.Controls.Add(Me.ProgressBarAñoIslr)
        Me.TabPageISLR.Controls.Add(Me.labPagosAñoIslrSeleccionado)
        Me.TabPageISLR.Controls.Add(Me.botPagoAdelantaAñoIslr)
        Me.TabPageISLR.Controls.Add(Me.botPagoRetrocedeAñoIslr)
        Me.TabPageISLR.Controls.Add(Me.txtPagosExportacionDatos)
        Me.TabPageISLR.Controls.Add(Me.botPagoMuestraDatosDelAñoIslr)
        Me.TabPageISLR.Location = New System.Drawing.Point(4, 22)
        Me.TabPageISLR.Name = "TabPageISLR"
        Me.TabPageISLR.Size = New System.Drawing.Size(948, 536)
        Me.TabPageISLR.TabIndex = 3
        Me.TabPageISLR.Text = "Genera Datos ISLR"
        '
        'ProgressBarAñoIslr
        '
        Me.ProgressBarAñoIslr.Location = New System.Drawing.Point(259, 42)
        Me.ProgressBarAñoIslr.Name = "ProgressBarAñoIslr"
        Me.ProgressBarAñoIslr.Size = New System.Drawing.Size(176, 11)
        Me.ProgressBarAñoIslr.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBarAñoIslr.TabIndex = 72
        '
        'labPagosAñoIslrSeleccionado
        '
        Me.labPagosAñoIslrSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labPagosAñoIslrSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPagosAñoIslrSeleccionado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labPagosAñoIslrSeleccionado.Location = New System.Drawing.Point(286, 11)
        Me.labPagosAñoIslrSeleccionado.Name = "labPagosAñoIslrSeleccionado"
        Me.labPagosAñoIslrSeleccionado.Size = New System.Drawing.Size(122, 23)
        Me.labPagosAñoIslrSeleccionado.TabIndex = 71
        Me.labPagosAñoIslrSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botPagoAdelantaAñoIslr
        '
        Me.botPagoAdelantaAñoIslr.BackgroundImage = Global.Historias.My.Resources.Resources.BotonFlechaDerOff
        Me.botPagoAdelantaAñoIslr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botPagoAdelantaAñoIslr.Location = New System.Drawing.Point(407, 8)
        Me.botPagoAdelantaAñoIslr.Name = "botPagoAdelantaAñoIslr"
        Me.botPagoAdelantaAñoIslr.Size = New System.Drawing.Size(28, 28)
        Me.botPagoAdelantaAñoIslr.TabIndex = 70
        Me.botPagoAdelantaAñoIslr.UseVisualStyleBackColor = True
        '
        'botPagoRetrocedeAñoIslr
        '
        Me.botPagoRetrocedeAñoIslr.BackgroundImage = Global.Historias.My.Resources.Resources.BotonFlechaIzqOff
        Me.botPagoRetrocedeAñoIslr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botPagoRetrocedeAñoIslr.Location = New System.Drawing.Point(259, 8)
        Me.botPagoRetrocedeAñoIslr.Name = "botPagoRetrocedeAñoIslr"
        Me.botPagoRetrocedeAñoIslr.Size = New System.Drawing.Size(28, 28)
        Me.botPagoRetrocedeAñoIslr.TabIndex = 69
        Me.botPagoRetrocedeAñoIslr.UseVisualStyleBackColor = True
        '
        'txtPagosExportacionDatos
        '
        Me.txtPagosExportacionDatos.BackColor = System.Drawing.SystemColors.Info
        Me.txtPagosExportacionDatos.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagosExportacionDatos.Location = New System.Drawing.Point(14, 59)
        Me.txtPagosExportacionDatos.Multiline = True
        Me.txtPagosExportacionDatos.Name = "txtPagosExportacionDatos"
        Me.txtPagosExportacionDatos.ReadOnly = True
        Me.txtPagosExportacionDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPagosExportacionDatos.Size = New System.Drawing.Size(914, 462)
        Me.txtPagosExportacionDatos.TabIndex = 10
        '
        'botPagoMuestraDatosDelAñoIslr
        '
        Me.botPagoMuestraDatosDelAñoIslr.BackColor = System.Drawing.SystemColors.Control
        Me.botPagoMuestraDatosDelAñoIslr.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botPagoMuestraDatosDelAñoIslr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botPagoMuestraDatosDelAñoIslr.Location = New System.Drawing.Point(14, 13)
        Me.botPagoMuestraDatosDelAñoIslr.Name = "botPagoMuestraDatosDelAñoIslr"
        Me.botPagoMuestraDatosDelAñoIslr.Size = New System.Drawing.Size(224, 23)
        Me.botPagoMuestraDatosDelAñoIslr.TabIndex = 9
        Me.botPagoMuestraDatosDelAñoIslr.Text = "Muestra DatosDel Año Seleccionado"
        Me.botPagoMuestraDatosDelAñoIslr.UseVisualStyleBackColor = False
        '
        'TabPageResHonorarios
        '
        Me.TabPageResHonorarios.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageResHonorarios.Controls.Add(Me.txtHonorariosDisplay)
        Me.TabPageResHonorarios.Controls.Add(Me.radHonorariosTotales)
        Me.TabPageResHonorarios.Controls.Add(Me.radHonorariosFacturados)
        Me.TabPageResHonorarios.Controls.Add(Me.radHonorariosGenerados)
        Me.TabPageResHonorarios.Controls.Add(Me.labHonorariosAñoSeleccionado)
        Me.TabPageResHonorarios.Controls.Add(Me.botHonorariosAdelantaAño)
        Me.TabPageResHonorarios.Controls.Add(Me.botHonorariosRetrocedeAño)
        Me.TabPageResHonorarios.Location = New System.Drawing.Point(4, 22)
        Me.TabPageResHonorarios.Name = "TabPageResHonorarios"
        Me.TabPageResHonorarios.Size = New System.Drawing.Size(962, 580)
        Me.TabPageResHonorarios.TabIndex = 6
        Me.TabPageResHonorarios.Text = "Resumen Honorarios"
        '
        'txtHonorariosDisplay
        '
        Me.txtHonorariosDisplay.BackColor = System.Drawing.SystemColors.Info
        Me.txtHonorariosDisplay.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHonorariosDisplay.Location = New System.Drawing.Point(15, 61)
        Me.txtHonorariosDisplay.Multiline = True
        Me.txtHonorariosDisplay.Name = "txtHonorariosDisplay"
        Me.txtHonorariosDisplay.ReadOnly = True
        Me.txtHonorariosDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHonorariosDisplay.Size = New System.Drawing.Size(797, 281)
        Me.txtHonorariosDisplay.TabIndex = 11
        '
        'radHonorariosTotales
        '
        Me.radHonorariosTotales.AutoSize = True
        Me.radHonorariosTotales.Location = New System.Drawing.Point(818, 107)
        Me.radHonorariosTotales.Name = "radHonorariosTotales"
        Me.radHonorariosTotales.Size = New System.Drawing.Size(93, 17)
        Me.radHonorariosTotales.TabIndex = 10
        Me.radHonorariosTotales.TabStop = True
        Me.radHonorariosTotales.Text = "Pagos Totales"
        Me.radHonorariosTotales.UseVisualStyleBackColor = True
        '
        'radHonorariosFacturados
        '
        Me.radHonorariosFacturados.AutoSize = True
        Me.radHonorariosFacturados.Location = New System.Drawing.Point(818, 84)
        Me.radHonorariosFacturados.Name = "radHonorariosFacturados"
        Me.radHonorariosFacturados.Size = New System.Drawing.Size(138, 17)
        Me.radHonorariosFacturados.TabIndex = 9
        Me.radHonorariosFacturados.TabStop = True
        Me.radHonorariosFacturados.Text = "Pagos Facturados ISLR"
        Me.radHonorariosFacturados.UseVisualStyleBackColor = True
        '
        'radHonorariosGenerados
        '
        Me.radHonorariosGenerados.AutoSize = True
        Me.radHonorariosGenerados.Checked = True
        Me.radHonorariosGenerados.Location = New System.Drawing.Point(818, 61)
        Me.radHonorariosGenerados.Name = "radHonorariosGenerados"
        Me.radHonorariosGenerados.Size = New System.Drawing.Size(131, 17)
        Me.radHonorariosGenerados.TabIndex = 8
        Me.radHonorariosGenerados.TabStop = True
        Me.radHonorariosGenerados.Text = "Honorarios Generados"
        Me.radHonorariosGenerados.UseVisualStyleBackColor = True
        '
        'labHonorariosAñoSeleccionado
        '
        Me.labHonorariosAñoSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labHonorariosAñoSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labHonorariosAñoSeleccionado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labHonorariosAñoSeleccionado.Location = New System.Drawing.Point(45, 33)
        Me.labHonorariosAñoSeleccionado.Name = "labHonorariosAñoSeleccionado"
        Me.labHonorariosAñoSeleccionado.Size = New System.Drawing.Size(737, 20)
        Me.labHonorariosAñoSeleccionado.TabIndex = 6
        Me.labHonorariosAñoSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botHonorariosAdelantaAño
        '
        Me.botHonorariosAdelantaAño.BackColor = System.Drawing.SystemColors.Control
        Me.botHonorariosAdelantaAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botHonorariosAdelantaAño.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botHonorariosAdelantaAño.Image = CType(resources.GetObject("botHonorariosAdelantaAño.Image"), System.Drawing.Image)
        Me.botHonorariosAdelantaAño.Location = New System.Drawing.Point(788, 33)
        Me.botHonorariosAdelantaAño.Name = "botHonorariosAdelantaAño"
        Me.botHonorariosAdelantaAño.Size = New System.Drawing.Size(24, 24)
        Me.botHonorariosAdelantaAño.TabIndex = 5
        Me.botHonorariosAdelantaAño.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botHonorariosAdelantaAño.UseVisualStyleBackColor = False
        '
        'botHonorariosRetrocedeAño
        '
        Me.botHonorariosRetrocedeAño.BackColor = System.Drawing.SystemColors.Control
        Me.botHonorariosRetrocedeAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botHonorariosRetrocedeAño.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botHonorariosRetrocedeAño.Image = CType(resources.GetObject("botHonorariosRetrocedeAño.Image"), System.Drawing.Image)
        Me.botHonorariosRetrocedeAño.Location = New System.Drawing.Point(15, 31)
        Me.botHonorariosRetrocedeAño.Name = "botHonorariosRetrocedeAño"
        Me.botHonorariosRetrocedeAño.Size = New System.Drawing.Size(24, 24)
        Me.botHonorariosRetrocedeAño.TabIndex = 4
        Me.botHonorariosRetrocedeAño.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botHonorariosRetrocedeAño.UseVisualStyleBackColor = False
        '
        'TabPageCalendario
        '
        Me.TabPageCalendario.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageCalendario.Controls.Add(Me.MonthCalendar1)
        Me.TabPageCalendario.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCalendario.Name = "TabPageCalendario"
        Me.TabPageCalendario.Size = New System.Drawing.Size(962, 580)
        Me.TabPageCalendario.TabIndex = 2
        Me.TabPageCalendario.Text = "Calendario"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(3, 4)
        Me.MonthCalendar1.Location = New System.Drawing.Point(9, 9)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.ShowWeekNumbers = True
        Me.MonthCalendar1.TabIndex = 0
        '
        'TabPageHonorarios
        '
        Me.TabPageHonorarios.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageHonorarios.Controls.Add(Me.labTotalAño2)
        Me.TabPageHonorarios.Controls.Add(Me.Label81)
        Me.TabPageHonorarios.Controls.Add(Me.labTotalConsultas2)
        Me.TabPageHonorarios.Controls.Add(Me.Label79)
        Me.TabPageHonorarios.Controls.Add(Me.labTotalIQ)
        Me.TabPageHonorarios.Controls.Add(Me.Label66)
        Me.TabPageHonorarios.Controls.Add(Me.labTotalIQcan)
        Me.TabPageHonorarios.Controls.Add(Me.lab12iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab11iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab10iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab09iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab08iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab07iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab06iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab05iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab04iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab03iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab02iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.lab01iqCan)
        Me.TabPageHonorarios.Controls.Add(Me.labDiciembre)
        Me.TabPageHonorarios.Controls.Add(Me.lab12cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab12iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab12total)
        Me.TabPageHonorarios.Controls.Add(Me.labNoviembre)
        Me.TabPageHonorarios.Controls.Add(Me.lab11cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab11iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab11total)
        Me.TabPageHonorarios.Controls.Add(Me.labOctubre)
        Me.TabPageHonorarios.Controls.Add(Me.lab10cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab10iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab10total)
        Me.TabPageHonorarios.Controls.Add(Me.labSeptiembre)
        Me.TabPageHonorarios.Controls.Add(Me.lab09cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab09iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab09total)
        Me.TabPageHonorarios.Controls.Add(Me.labAgosto)
        Me.TabPageHonorarios.Controls.Add(Me.lab08cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab08iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab08total)
        Me.TabPageHonorarios.Controls.Add(Me.labJulio)
        Me.TabPageHonorarios.Controls.Add(Me.lab07cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab07iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab07total)
        Me.TabPageHonorarios.Controls.Add(Me.labJunio)
        Me.TabPageHonorarios.Controls.Add(Me.lab06cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab06iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab06total)
        Me.TabPageHonorarios.Controls.Add(Me.labMayo)
        Me.TabPageHonorarios.Controls.Add(Me.lab05cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab05iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab05total)
        Me.TabPageHonorarios.Controls.Add(Me.labAbril)
        Me.TabPageHonorarios.Controls.Add(Me.lab04cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab04iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab04total)
        Me.TabPageHonorarios.Controls.Add(Me.labMarzo)
        Me.TabPageHonorarios.Controls.Add(Me.lab03cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab03iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab03total)
        Me.TabPageHonorarios.Controls.Add(Me.labFebrero)
        Me.TabPageHonorarios.Controls.Add(Me.lab02cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab02iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab02total)
        Me.TabPageHonorarios.Controls.Add(Me.labEnero)
        Me.TabPageHonorarios.Controls.Add(Me.lab01cons)
        Me.TabPageHonorarios.Controls.Add(Me.lab01iqPen)
        Me.TabPageHonorarios.Controls.Add(Me.lab01total)
        Me.TabPageHonorarios.Controls.Add(Me.Panel4)
        Me.TabPageHonorarios.Controls.Add(Me.Label97)
        Me.TabPageHonorarios.Controls.Add(Me.labTotalAño)
        Me.TabPageHonorarios.Controls.Add(Me.labTotalIQpen)
        Me.TabPageHonorarios.Controls.Add(Me.labTotalConsultas)
        Me.TabPageHonorarios.Controls.Add(Me.Label157)
        Me.TabPageHonorarios.Controls.Add(Me.Label39)
        Me.TabPageHonorarios.Controls.Add(Me.Label35)
        Me.TabPageHonorarios.Controls.Add(Me.Label31)
        Me.TabPageHonorarios.Controls.Add(Me.Label3)
        Me.TabPageHonorarios.Location = New System.Drawing.Point(4, 22)
        Me.TabPageHonorarios.Name = "TabPageHonorarios"
        Me.TabPageHonorarios.Size = New System.Drawing.Size(962, 580)
        Me.TabPageHonorarios.TabIndex = 5
        Me.TabPageHonorarios.Text = "Honorarios"
        '
        'labTotalAño2
        '
        Me.labTotalAño2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalAño2.ForeColor = System.Drawing.Color.White
        Me.labTotalAño2.Image = CType(resources.GetObject("labTotalAño2.Image"), System.Drawing.Image)
        Me.labTotalAño2.Location = New System.Drawing.Point(464, 396)
        Me.labTotalAño2.Name = "labTotalAño2"
        Me.labTotalAño2.Size = New System.Drawing.Size(140, 23)
        Me.labTotalAño2.TabIndex = 106
        Me.labTotalAño2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label81
        '
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.Black
        Me.Label81.Image = CType(resources.GetObject("Label81.Image"), System.Drawing.Image)
        Me.Label81.Location = New System.Drawing.Point(160, 396)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(304, 23)
        Me.Label81.TabIndex = 105
        Me.Label81.Text = "Total Honorarios del Año"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTotalConsultas2
        '
        Me.labTotalConsultas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalConsultas2.ForeColor = System.Drawing.Color.White
        Me.labTotalConsultas2.Image = CType(resources.GetObject("labTotalConsultas2.Image"), System.Drawing.Image)
        Me.labTotalConsultas2.Location = New System.Drawing.Point(464, 348)
        Me.labTotalConsultas2.Name = "labTotalConsultas2"
        Me.labTotalConsultas2.Size = New System.Drawing.Size(140, 23)
        Me.labTotalConsultas2.TabIndex = 104
        Me.labTotalConsultas2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label79
        '
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Black
        Me.Label79.Image = CType(resources.GetObject("Label79.Image"), System.Drawing.Image)
        Me.Label79.Location = New System.Drawing.Point(160, 348)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(304, 23)
        Me.Label79.TabIndex = 103
        Me.Label79.Text = "Total de Honorarios por Consultas"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTotalIQ
        '
        Me.labTotalIQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalIQ.ForeColor = System.Drawing.Color.White
        Me.labTotalIQ.Image = CType(resources.GetObject("labTotalIQ.Image"), System.Drawing.Image)
        Me.labTotalIQ.Location = New System.Drawing.Point(464, 372)
        Me.labTotalIQ.Name = "labTotalIQ"
        Me.labTotalIQ.Size = New System.Drawing.Size(140, 23)
        Me.labTotalIQ.TabIndex = 102
        Me.labTotalIQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Image = CType(resources.GetObject("Label66.Image"), System.Drawing.Image)
        Me.Label66.Location = New System.Drawing.Point(160, 372)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(304, 23)
        Me.Label66.TabIndex = 101
        Me.Label66.Text = "Total de Honorarios por IQ Pagadas y Pendientes"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTotalIQcan
        '
        Me.labTotalIQcan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalIQcan.ForeColor = System.Drawing.Color.White
        Me.labTotalIQcan.Image = CType(resources.GetObject("labTotalIQcan.Image"), System.Drawing.Image)
        Me.labTotalIQcan.Location = New System.Drawing.Point(464, 304)
        Me.labTotalIQcan.Name = "labTotalIQcan"
        Me.labTotalIQcan.Size = New System.Drawing.Size(140, 23)
        Me.labTotalIQcan.TabIndex = 100
        Me.labTotalIQcan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab12iqCan
        '
        Me.lab12iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab12iqCan.Location = New System.Drawing.Point(464, 284)
        Me.lab12iqCan.Name = "lab12iqCan"
        Me.lab12iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab12iqCan.TabIndex = 99
        Me.lab12iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab11iqCan
        '
        Me.lab11iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab11iqCan.Location = New System.Drawing.Point(464, 264)
        Me.lab11iqCan.Name = "lab11iqCan"
        Me.lab11iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab11iqCan.TabIndex = 98
        Me.lab11iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab10iqCan
        '
        Me.lab10iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab10iqCan.Location = New System.Drawing.Point(464, 244)
        Me.lab10iqCan.Name = "lab10iqCan"
        Me.lab10iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab10iqCan.TabIndex = 97
        Me.lab10iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab09iqCan
        '
        Me.lab09iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab09iqCan.Location = New System.Drawing.Point(464, 224)
        Me.lab09iqCan.Name = "lab09iqCan"
        Me.lab09iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab09iqCan.TabIndex = 96
        Me.lab09iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab08iqCan
        '
        Me.lab08iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab08iqCan.Location = New System.Drawing.Point(464, 204)
        Me.lab08iqCan.Name = "lab08iqCan"
        Me.lab08iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab08iqCan.TabIndex = 95
        Me.lab08iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab07iqCan
        '
        Me.lab07iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab07iqCan.Location = New System.Drawing.Point(464, 184)
        Me.lab07iqCan.Name = "lab07iqCan"
        Me.lab07iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab07iqCan.TabIndex = 94
        Me.lab07iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab06iqCan
        '
        Me.lab06iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab06iqCan.Location = New System.Drawing.Point(464, 164)
        Me.lab06iqCan.Name = "lab06iqCan"
        Me.lab06iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab06iqCan.TabIndex = 93
        Me.lab06iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab05iqCan
        '
        Me.lab05iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab05iqCan.Location = New System.Drawing.Point(464, 144)
        Me.lab05iqCan.Name = "lab05iqCan"
        Me.lab05iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab05iqCan.TabIndex = 92
        Me.lab05iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab04iqCan
        '
        Me.lab04iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab04iqCan.Location = New System.Drawing.Point(464, 124)
        Me.lab04iqCan.Name = "lab04iqCan"
        Me.lab04iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab04iqCan.TabIndex = 91
        Me.lab04iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab03iqCan
        '
        Me.lab03iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab03iqCan.Location = New System.Drawing.Point(464, 104)
        Me.lab03iqCan.Name = "lab03iqCan"
        Me.lab03iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab03iqCan.TabIndex = 90
        Me.lab03iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab02iqCan
        '
        Me.lab02iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab02iqCan.Location = New System.Drawing.Point(464, 84)
        Me.lab02iqCan.Name = "lab02iqCan"
        Me.lab02iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab02iqCan.TabIndex = 89
        Me.lab02iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab01iqCan
        '
        Me.lab01iqCan.BackColor = System.Drawing.Color.MintCream
        Me.lab01iqCan.Location = New System.Drawing.Point(464, 64)
        Me.lab01iqCan.Name = "lab01iqCan"
        Me.lab01iqCan.Size = New System.Drawing.Size(140, 16)
        Me.lab01iqCan.TabIndex = 88
        Me.lab01iqCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labDiciembre
        '
        Me.labDiciembre.BackColor = System.Drawing.Color.Beige
        Me.labDiciembre.Location = New System.Drawing.Point(24, 284)
        Me.labDiciembre.Name = "labDiciembre"
        Me.labDiciembre.Size = New System.Drawing.Size(160, 16)
        Me.labDiciembre.TabIndex = 82
        Me.labDiciembre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab12cons
        '
        Me.lab12cons.BackColor = System.Drawing.Color.MintCream
        Me.lab12cons.Location = New System.Drawing.Point(184, 284)
        Me.lab12cons.Name = "lab12cons"
        Me.lab12cons.Size = New System.Drawing.Size(140, 16)
        Me.lab12cons.TabIndex = 81
        Me.lab12cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab12iqPen
        '
        Me.lab12iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab12iqPen.Location = New System.Drawing.Point(324, 284)
        Me.lab12iqPen.Name = "lab12iqPen"
        Me.lab12iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab12iqPen.TabIndex = 80
        Me.lab12iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab12total
        '
        Me.lab12total.BackColor = System.Drawing.Color.Turquoise
        Me.lab12total.Location = New System.Drawing.Point(604, 284)
        Me.lab12total.Name = "lab12total"
        Me.lab12total.Size = New System.Drawing.Size(140, 16)
        Me.lab12total.TabIndex = 79
        Me.lab12total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labNoviembre
        '
        Me.labNoviembre.BackColor = System.Drawing.Color.Beige
        Me.labNoviembre.Location = New System.Drawing.Point(24, 264)
        Me.labNoviembre.Name = "labNoviembre"
        Me.labNoviembre.Size = New System.Drawing.Size(160, 16)
        Me.labNoviembre.TabIndex = 78
        Me.labNoviembre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab11cons
        '
        Me.lab11cons.BackColor = System.Drawing.Color.MintCream
        Me.lab11cons.Location = New System.Drawing.Point(184, 264)
        Me.lab11cons.Name = "lab11cons"
        Me.lab11cons.Size = New System.Drawing.Size(140, 16)
        Me.lab11cons.TabIndex = 77
        Me.lab11cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab11iqPen
        '
        Me.lab11iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab11iqPen.Location = New System.Drawing.Point(324, 264)
        Me.lab11iqPen.Name = "lab11iqPen"
        Me.lab11iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab11iqPen.TabIndex = 76
        Me.lab11iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab11total
        '
        Me.lab11total.BackColor = System.Drawing.Color.Turquoise
        Me.lab11total.Location = New System.Drawing.Point(604, 264)
        Me.lab11total.Name = "lab11total"
        Me.lab11total.Size = New System.Drawing.Size(140, 16)
        Me.lab11total.TabIndex = 75
        Me.lab11total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labOctubre
        '
        Me.labOctubre.BackColor = System.Drawing.Color.Beige
        Me.labOctubre.Location = New System.Drawing.Point(24, 244)
        Me.labOctubre.Name = "labOctubre"
        Me.labOctubre.Size = New System.Drawing.Size(160, 16)
        Me.labOctubre.TabIndex = 74
        Me.labOctubre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab10cons
        '
        Me.lab10cons.BackColor = System.Drawing.Color.MintCream
        Me.lab10cons.Location = New System.Drawing.Point(184, 244)
        Me.lab10cons.Name = "lab10cons"
        Me.lab10cons.Size = New System.Drawing.Size(140, 16)
        Me.lab10cons.TabIndex = 73
        Me.lab10cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab10iqPen
        '
        Me.lab10iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab10iqPen.Location = New System.Drawing.Point(324, 244)
        Me.lab10iqPen.Name = "lab10iqPen"
        Me.lab10iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab10iqPen.TabIndex = 72
        Me.lab10iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab10total
        '
        Me.lab10total.BackColor = System.Drawing.Color.Turquoise
        Me.lab10total.Location = New System.Drawing.Point(604, 244)
        Me.lab10total.Name = "lab10total"
        Me.lab10total.Size = New System.Drawing.Size(140, 16)
        Me.lab10total.TabIndex = 71
        Me.lab10total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labSeptiembre
        '
        Me.labSeptiembre.BackColor = System.Drawing.Color.Beige
        Me.labSeptiembre.Location = New System.Drawing.Point(24, 224)
        Me.labSeptiembre.Name = "labSeptiembre"
        Me.labSeptiembre.Size = New System.Drawing.Size(160, 16)
        Me.labSeptiembre.TabIndex = 70
        Me.labSeptiembre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab09cons
        '
        Me.lab09cons.BackColor = System.Drawing.Color.MintCream
        Me.lab09cons.Location = New System.Drawing.Point(184, 224)
        Me.lab09cons.Name = "lab09cons"
        Me.lab09cons.Size = New System.Drawing.Size(140, 16)
        Me.lab09cons.TabIndex = 69
        Me.lab09cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab09iqPen
        '
        Me.lab09iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab09iqPen.Location = New System.Drawing.Point(324, 224)
        Me.lab09iqPen.Name = "lab09iqPen"
        Me.lab09iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab09iqPen.TabIndex = 68
        Me.lab09iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab09total
        '
        Me.lab09total.BackColor = System.Drawing.Color.Turquoise
        Me.lab09total.Location = New System.Drawing.Point(604, 224)
        Me.lab09total.Name = "lab09total"
        Me.lab09total.Size = New System.Drawing.Size(140, 16)
        Me.lab09total.TabIndex = 67
        Me.lab09total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labAgosto
        '
        Me.labAgosto.BackColor = System.Drawing.Color.Beige
        Me.labAgosto.Location = New System.Drawing.Point(24, 204)
        Me.labAgosto.Name = "labAgosto"
        Me.labAgosto.Size = New System.Drawing.Size(160, 16)
        Me.labAgosto.TabIndex = 66
        Me.labAgosto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab08cons
        '
        Me.lab08cons.BackColor = System.Drawing.Color.MintCream
        Me.lab08cons.Location = New System.Drawing.Point(184, 204)
        Me.lab08cons.Name = "lab08cons"
        Me.lab08cons.Size = New System.Drawing.Size(140, 16)
        Me.lab08cons.TabIndex = 65
        Me.lab08cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab08iqPen
        '
        Me.lab08iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab08iqPen.Location = New System.Drawing.Point(324, 204)
        Me.lab08iqPen.Name = "lab08iqPen"
        Me.lab08iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab08iqPen.TabIndex = 64
        Me.lab08iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab08total
        '
        Me.lab08total.BackColor = System.Drawing.Color.Turquoise
        Me.lab08total.Location = New System.Drawing.Point(604, 204)
        Me.lab08total.Name = "lab08total"
        Me.lab08total.Size = New System.Drawing.Size(140, 16)
        Me.lab08total.TabIndex = 63
        Me.lab08total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labJulio
        '
        Me.labJulio.BackColor = System.Drawing.Color.Beige
        Me.labJulio.Location = New System.Drawing.Point(24, 184)
        Me.labJulio.Name = "labJulio"
        Me.labJulio.Size = New System.Drawing.Size(160, 16)
        Me.labJulio.TabIndex = 62
        Me.labJulio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab07cons
        '
        Me.lab07cons.BackColor = System.Drawing.Color.MintCream
        Me.lab07cons.Location = New System.Drawing.Point(184, 184)
        Me.lab07cons.Name = "lab07cons"
        Me.lab07cons.Size = New System.Drawing.Size(140, 16)
        Me.lab07cons.TabIndex = 61
        Me.lab07cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab07iqPen
        '
        Me.lab07iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab07iqPen.Location = New System.Drawing.Point(324, 184)
        Me.lab07iqPen.Name = "lab07iqPen"
        Me.lab07iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab07iqPen.TabIndex = 60
        Me.lab07iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab07total
        '
        Me.lab07total.BackColor = System.Drawing.Color.Turquoise
        Me.lab07total.Location = New System.Drawing.Point(604, 184)
        Me.lab07total.Name = "lab07total"
        Me.lab07total.Size = New System.Drawing.Size(140, 16)
        Me.lab07total.TabIndex = 59
        Me.lab07total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labJunio
        '
        Me.labJunio.BackColor = System.Drawing.Color.Beige
        Me.labJunio.Location = New System.Drawing.Point(24, 164)
        Me.labJunio.Name = "labJunio"
        Me.labJunio.Size = New System.Drawing.Size(160, 16)
        Me.labJunio.TabIndex = 58
        Me.labJunio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab06cons
        '
        Me.lab06cons.BackColor = System.Drawing.Color.MintCream
        Me.lab06cons.Location = New System.Drawing.Point(184, 164)
        Me.lab06cons.Name = "lab06cons"
        Me.lab06cons.Size = New System.Drawing.Size(140, 16)
        Me.lab06cons.TabIndex = 57
        Me.lab06cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab06iqPen
        '
        Me.lab06iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab06iqPen.Location = New System.Drawing.Point(324, 164)
        Me.lab06iqPen.Name = "lab06iqPen"
        Me.lab06iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab06iqPen.TabIndex = 56
        Me.lab06iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab06total
        '
        Me.lab06total.BackColor = System.Drawing.Color.Turquoise
        Me.lab06total.Location = New System.Drawing.Point(604, 164)
        Me.lab06total.Name = "lab06total"
        Me.lab06total.Size = New System.Drawing.Size(140, 16)
        Me.lab06total.TabIndex = 55
        Me.lab06total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labMayo
        '
        Me.labMayo.BackColor = System.Drawing.Color.Beige
        Me.labMayo.Location = New System.Drawing.Point(24, 144)
        Me.labMayo.Name = "labMayo"
        Me.labMayo.Size = New System.Drawing.Size(160, 16)
        Me.labMayo.TabIndex = 54
        Me.labMayo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab05cons
        '
        Me.lab05cons.BackColor = System.Drawing.Color.MintCream
        Me.lab05cons.Location = New System.Drawing.Point(184, 144)
        Me.lab05cons.Name = "lab05cons"
        Me.lab05cons.Size = New System.Drawing.Size(140, 16)
        Me.lab05cons.TabIndex = 53
        Me.lab05cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab05iqPen
        '
        Me.lab05iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab05iqPen.Location = New System.Drawing.Point(324, 144)
        Me.lab05iqPen.Name = "lab05iqPen"
        Me.lab05iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab05iqPen.TabIndex = 52
        Me.lab05iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab05total
        '
        Me.lab05total.BackColor = System.Drawing.Color.Turquoise
        Me.lab05total.Location = New System.Drawing.Point(604, 144)
        Me.lab05total.Name = "lab05total"
        Me.lab05total.Size = New System.Drawing.Size(140, 16)
        Me.lab05total.TabIndex = 51
        Me.lab05total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labAbril
        '
        Me.labAbril.BackColor = System.Drawing.Color.Beige
        Me.labAbril.Location = New System.Drawing.Point(24, 124)
        Me.labAbril.Name = "labAbril"
        Me.labAbril.Size = New System.Drawing.Size(160, 16)
        Me.labAbril.TabIndex = 50
        Me.labAbril.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab04cons
        '
        Me.lab04cons.BackColor = System.Drawing.Color.MintCream
        Me.lab04cons.Location = New System.Drawing.Point(184, 124)
        Me.lab04cons.Name = "lab04cons"
        Me.lab04cons.Size = New System.Drawing.Size(140, 16)
        Me.lab04cons.TabIndex = 49
        Me.lab04cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab04iqPen
        '
        Me.lab04iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab04iqPen.Location = New System.Drawing.Point(324, 124)
        Me.lab04iqPen.Name = "lab04iqPen"
        Me.lab04iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab04iqPen.TabIndex = 48
        Me.lab04iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab04total
        '
        Me.lab04total.BackColor = System.Drawing.Color.Turquoise
        Me.lab04total.Location = New System.Drawing.Point(604, 124)
        Me.lab04total.Name = "lab04total"
        Me.lab04total.Size = New System.Drawing.Size(140, 16)
        Me.lab04total.TabIndex = 47
        Me.lab04total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labMarzo
        '
        Me.labMarzo.BackColor = System.Drawing.Color.Beige
        Me.labMarzo.Location = New System.Drawing.Point(24, 104)
        Me.labMarzo.Name = "labMarzo"
        Me.labMarzo.Size = New System.Drawing.Size(160, 16)
        Me.labMarzo.TabIndex = 46
        Me.labMarzo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab03cons
        '
        Me.lab03cons.BackColor = System.Drawing.Color.MintCream
        Me.lab03cons.Location = New System.Drawing.Point(184, 104)
        Me.lab03cons.Name = "lab03cons"
        Me.lab03cons.Size = New System.Drawing.Size(140, 16)
        Me.lab03cons.TabIndex = 45
        Me.lab03cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab03iqPen
        '
        Me.lab03iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab03iqPen.Location = New System.Drawing.Point(324, 104)
        Me.lab03iqPen.Name = "lab03iqPen"
        Me.lab03iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab03iqPen.TabIndex = 44
        Me.lab03iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab03total
        '
        Me.lab03total.BackColor = System.Drawing.Color.Turquoise
        Me.lab03total.Location = New System.Drawing.Point(604, 104)
        Me.lab03total.Name = "lab03total"
        Me.lab03total.Size = New System.Drawing.Size(140, 16)
        Me.lab03total.TabIndex = 43
        Me.lab03total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labFebrero
        '
        Me.labFebrero.BackColor = System.Drawing.Color.Beige
        Me.labFebrero.Location = New System.Drawing.Point(24, 84)
        Me.labFebrero.Name = "labFebrero"
        Me.labFebrero.Size = New System.Drawing.Size(160, 16)
        Me.labFebrero.TabIndex = 42
        Me.labFebrero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab02cons
        '
        Me.lab02cons.BackColor = System.Drawing.Color.MintCream
        Me.lab02cons.Location = New System.Drawing.Point(184, 84)
        Me.lab02cons.Name = "lab02cons"
        Me.lab02cons.Size = New System.Drawing.Size(140, 16)
        Me.lab02cons.TabIndex = 41
        Me.lab02cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab02iqPen
        '
        Me.lab02iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab02iqPen.Location = New System.Drawing.Point(324, 84)
        Me.lab02iqPen.Name = "lab02iqPen"
        Me.lab02iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab02iqPen.TabIndex = 40
        Me.lab02iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab02total
        '
        Me.lab02total.BackColor = System.Drawing.Color.Turquoise
        Me.lab02total.Location = New System.Drawing.Point(604, 84)
        Me.lab02total.Name = "lab02total"
        Me.lab02total.Size = New System.Drawing.Size(140, 16)
        Me.lab02total.TabIndex = 39
        Me.lab02total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labEnero
        '
        Me.labEnero.BackColor = System.Drawing.Color.Beige
        Me.labEnero.Location = New System.Drawing.Point(24, 64)
        Me.labEnero.Name = "labEnero"
        Me.labEnero.Size = New System.Drawing.Size(160, 16)
        Me.labEnero.TabIndex = 38
        Me.labEnero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab01cons
        '
        Me.lab01cons.BackColor = System.Drawing.Color.MintCream
        Me.lab01cons.Location = New System.Drawing.Point(184, 64)
        Me.lab01cons.Name = "lab01cons"
        Me.lab01cons.Size = New System.Drawing.Size(140, 16)
        Me.lab01cons.TabIndex = 37
        Me.lab01cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab01iqPen
        '
        Me.lab01iqPen.BackColor = System.Drawing.Color.MistyRose
        Me.lab01iqPen.Location = New System.Drawing.Point(324, 64)
        Me.lab01iqPen.Name = "lab01iqPen"
        Me.lab01iqPen.Size = New System.Drawing.Size(140, 16)
        Me.lab01iqPen.TabIndex = 36
        Me.lab01iqPen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab01total
        '
        Me.lab01total.BackColor = System.Drawing.Color.Turquoise
        Me.lab01total.Location = New System.Drawing.Point(604, 64)
        Me.lab01total.Name = "lab01total"
        Me.lab01total.Size = New System.Drawing.Size(140, 16)
        Me.lab01total.TabIndex = 35
        Me.lab01total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.botAdelantaAñoHon)
        Me.Panel4.Controls.Add(Me.botRetrocedeAñoHon)
        Me.Panel4.Controls.Add(Me.labAñoSeleccionadoHon)
        Me.Panel4.Location = New System.Drawing.Point(24, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(720, 24)
        Me.Panel4.TabIndex = 26
        '
        'botAdelantaAñoHon
        '
        Me.botAdelantaAñoHon.BackColor = System.Drawing.SystemColors.Control
        Me.botAdelantaAñoHon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAdelantaAñoHon.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botAdelantaAñoHon.Image = CType(resources.GetObject("botAdelantaAñoHon.Image"), System.Drawing.Image)
        Me.botAdelantaAñoHon.Location = New System.Drawing.Point(696, 0)
        Me.botAdelantaAñoHon.Name = "botAdelantaAñoHon"
        Me.botAdelantaAñoHon.Size = New System.Drawing.Size(24, 24)
        Me.botAdelantaAñoHon.TabIndex = 1
        Me.botAdelantaAñoHon.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botAdelantaAñoHon.UseVisualStyleBackColor = False
        '
        'botRetrocedeAñoHon
        '
        Me.botRetrocedeAñoHon.BackColor = System.Drawing.SystemColors.Control
        Me.botRetrocedeAñoHon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRetrocedeAñoHon.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRetrocedeAñoHon.Image = CType(resources.GetObject("botRetrocedeAñoHon.Image"), System.Drawing.Image)
        Me.botRetrocedeAñoHon.Location = New System.Drawing.Point(0, 0)
        Me.botRetrocedeAñoHon.Name = "botRetrocedeAñoHon"
        Me.botRetrocedeAñoHon.Size = New System.Drawing.Size(24, 24)
        Me.botRetrocedeAñoHon.TabIndex = 0
        Me.botRetrocedeAñoHon.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botRetrocedeAñoHon.UseVisualStyleBackColor = False
        '
        'labAñoSeleccionadoHon
        '
        Me.labAñoSeleccionadoHon.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labAñoSeleccionadoHon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAñoSeleccionadoHon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labAñoSeleccionadoHon.Location = New System.Drawing.Point(32, 2)
        Me.labAñoSeleccionadoHon.Name = "labAñoSeleccionadoHon"
        Me.labAñoSeleccionadoHon.Size = New System.Drawing.Size(656, 20)
        Me.labAñoSeleccionadoHon.TabIndex = 3
        Me.labAñoSeleccionadoHon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label97
        '
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Image = CType(resources.GetObject("Label97.Image"), System.Drawing.Image)
        Me.Label97.Location = New System.Drawing.Point(464, 40)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(140, 23)
        Me.Label97.TabIndex = 87
        Me.Label97.Text = "Total  IQ Canceladas"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labTotalAño
        '
        Me.labTotalAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalAño.ForeColor = System.Drawing.Color.White
        Me.labTotalAño.Image = CType(resources.GetObject("labTotalAño.Image"), System.Drawing.Image)
        Me.labTotalAño.Location = New System.Drawing.Point(604, 304)
        Me.labTotalAño.Name = "labTotalAño"
        Me.labTotalAño.Size = New System.Drawing.Size(140, 23)
        Me.labTotalAño.TabIndex = 86
        Me.labTotalAño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labTotalIQpen
        '
        Me.labTotalIQpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalIQpen.ForeColor = System.Drawing.Color.White
        Me.labTotalIQpen.Image = CType(resources.GetObject("labTotalIQpen.Image"), System.Drawing.Image)
        Me.labTotalIQpen.Location = New System.Drawing.Point(324, 304)
        Me.labTotalIQpen.Name = "labTotalIQpen"
        Me.labTotalIQpen.Size = New System.Drawing.Size(140, 23)
        Me.labTotalIQpen.TabIndex = 85
        Me.labTotalIQpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labTotalConsultas
        '
        Me.labTotalConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTotalConsultas.ForeColor = System.Drawing.Color.White
        Me.labTotalConsultas.Image = CType(resources.GetObject("labTotalConsultas.Image"), System.Drawing.Image)
        Me.labTotalConsultas.Location = New System.Drawing.Point(184, 304)
        Me.labTotalConsultas.Name = "labTotalConsultas"
        Me.labTotalConsultas.Size = New System.Drawing.Size(140, 23)
        Me.labTotalConsultas.TabIndex = 84
        Me.labTotalConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label157
        '
        Me.Label157.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label157.ForeColor = System.Drawing.Color.Black
        Me.Label157.Image = CType(resources.GetObject("Label157.Image"), System.Drawing.Image)
        Me.Label157.Location = New System.Drawing.Point(24, 304)
        Me.Label157.Name = "Label157"
        Me.Label157.Size = New System.Drawing.Size(160, 23)
        Me.Label157.TabIndex = 83
        Me.Label157.Text = "Total en el Año"
        Me.Label157.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.Location = New System.Drawing.Point(604, 40)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(140, 23)
        Me.Label39.TabIndex = 34
        Me.Label39.Text = "Total General"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Image = CType(resources.GetObject("Label35.Image"), System.Drawing.Image)
        Me.Label35.Location = New System.Drawing.Point(324, 40)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(140, 23)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Total  IQ Pendientes"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Image = CType(resources.GetObject("Label31.Image"), System.Drawing.Image)
        Me.Label31.Location = New System.Drawing.Point(184, 40)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(140, 23)
        Me.Label31.TabIndex = 32
        Me.Label31.Text = "Total Consultas"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(24, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Mes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarraProgresoAgenda, Me.BarraEstadoAgenda})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 646)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(990, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BarraProgresoAgenda
        '
        Me.BarraProgresoAgenda.Name = "BarraProgresoAgenda"
        Me.BarraProgresoAgenda.Size = New System.Drawing.Size(100, 16)
        '
        'BarraEstadoAgenda
        '
        Me.BarraEstadoAgenda.Name = "BarraEstadoAgenda"
        Me.BarraEstadoAgenda.Size = New System.Drawing.Size(121, 17)
        Me.BarraEstadoAgenda.Text = "ToolStripStatusLabel1"
        '
        'botActualizar
        '
        Me.botActualizar.BackColor = System.Drawing.SystemColors.Control
        Me.botActualizar.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botActualizar.Location = New System.Drawing.Point(8, 620)
        Me.botActualizar.Name = "botActualizar"
        Me.botActualizar.Size = New System.Drawing.Size(224, 23)
        Me.botActualizar.TabIndex = 8
        Me.botActualizar.Text = "Actualizar Datos"
        Me.botActualizar.UseVisualStyleBackColor = False
        '
        'botCerrar
        '
        Me.botCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.botCerrar.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCerrar.Location = New System.Drawing.Point(754, 620)
        Me.botCerrar.Name = "botCerrar"
        Me.botCerrar.Size = New System.Drawing.Size(224, 23)
        Me.botCerrar.TabIndex = 1
        Me.botCerrar.Text = "Cierra Agenda"
        Me.botCerrar.UseVisualStyleBackColor = False
        '
        'FormAgenda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(990, 668)
        Me.Controls.Add(Me.botActualizar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.botCerrar)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageControles.ResumeLayout(False)
        Me.PanelControlAnual.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.PanelControlMensual.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelControlDiario.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBoxConsultaSeleccionadaDia.ResumeLayout(False)
        Me.GroupBoxConsultaSeleccionadaDia.PerformLayout()
        Me.TabPageProximos.ResumeLayout(False)
        Me.TabPageProximos.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPagePacientes.ResumeLayout(False)
        Me.TabPagePacientes.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPageIntervenciones.ResumeLayout(False)
        Me.PanelIQaño.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.PanelIQmes.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.PanelIQdia.ResumeLayout(False)
        Me.PanelIQdia.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPagePagos.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPagePagosXdia.ResumeLayout(False)
        Me.TabPagePagosXdia.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPagePagosXmes.ResumeLayout(False)
        Me.TabPagePagosXmes.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabPagePagosXaño.ResumeLayout(False)
        Me.TabPagePagosXaño.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabPageISLR.ResumeLayout(False)
        Me.TabPageISLR.PerformLayout()
        Me.TabPageResHonorarios.ResumeLayout(False)
        Me.TabPageResHonorarios.PerformLayout()
        Me.TabPageCalendario.ResumeLayout(False)
        Me.TabPageHonorarios.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image

    'variables de archivos
    Dim PathAgenda As String
    Dim ArchivoIndice As String
    Dim ArchivoIndiceProximos As String
    Dim ArchivoControlDiario As String
    Dim ArchivoControlMensual As String
    Dim ArchivoControlAnual As String
    Dim ArchivoControlAnualIslr As String
    Dim ArchivoPropioAGD As String

    'variables de fechas
    Dim FechaConsultadaDia As Date
    Dim MesConsultado As Date
    Dim AñoConsultado As Date

    'variables de control de archivos
    Dim FS As FileStream
    Dim BW As BinaryWriter
    Dim BR As BinaryReader
    Dim REnum As IEnumerator
    Dim C As Integer

    'variables del entorno
    Dim Iniciando As Boolean
    Dim MesSeleccionadoCadena As String
    Dim MesSeleccionadoNumero As Integer
    Dim AñoseleccionadoFecha As Date
    Dim AñoSeleccionadoNumerodeAño As Integer 'exclusivo para calculo de años
    Dim AñoSeleccionadoNumerodeMes As Integer 'exclusivo para calulo de meses

    Dim ArchivoControlMensualdelDia As String 'para verificar las fechas donde hay consultas


    'estructuras
    Dim DP As Form1.DatosPersonales

    'variables de structura y array correspondientes nuevas en pantalla

    'Dim Tipo01 As EstructuraTipo01
    'Dim Tipo02 As EstructuraTipo02
    Dim Tipo03 As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual
    Dim Tipo04 As Form1.TablaDeArchivosDeProximosControles
    Dim Tipo05 As Form1.TablaDeArchivosDeIndiceDeProximosControles

    'Dim Array01 As New ArrayList()
    'Dim Array02 As New ArrayList()
    Dim Array03deDias As New ArrayList()
    Dim Array03deMeses As New ArrayList()
    Dim Array03deAños As New ArrayList()

    Dim Array04 As New ArrayList()
    Dim Array05 As New ArrayList()

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
    Dim O As New OrdenAño()
    Dim ArrayNumerosAñoOrdenados As New ArrayList()

    Structure OrdenMes
        Dim NumeroHistoria As String
        Dim FechaControl As String
    End Structure
    Dim M As New OrdenMes()
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

    Dim F As New Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual()
    Dim J As New Form1.TablaDeArchivosDeProximosControles()
    Dim K As New Form1.TablaDeArchivosDeIndiceDeProximosControles()
    Dim L As New Form1.TablaDePagos


    '0000000000000000000 Variables de las IQ

    Dim PathIQ As String

    'variables de la vista de dias
    Dim FechaSeleccionadaIQvistaDia As Date
    Dim PathIQsubVistaDia As String
    Dim AñoSeleccionadoIQvistadia As String
    Dim MesSeleccionadoIQvistadia As String
    Dim DiaSeleccionadoIQvistadia As String
    Dim archivoIQDia As String

    'variables de la vista de meses
    Dim FechaSeleccionadaIQvistames As Date
    Dim PathIQsubVistames As String
    Dim AñoSeleccionadoIQvistames As Integer
    Dim AñoSeleccionadoIQvistamesCadena As String
    Dim MesSeleccionadoIQvistames As Integer
    Dim MesSeleccionadoIQvistamesCadena As String
    Dim archivoIQMes As String

    'variables de la vista de año
    Dim FechaSeleccionadaIQvistaaño As Date
    Dim PathIQsubVistaaño As String
    Dim AñoSeleccionadoIQvistaaño As String
    Dim archivoIQaño As String

    'variables de control de la estructura de IQ
    Dim IQ As Form1.TablaDeIntervenciones
    Dim arrayDeIntervencionesDia As New ArrayList()
    Dim arrayDeIntervencionesMes As New ArrayList()
    Dim arrayDeIntervencionesAño As New ArrayList()

    'variables de orden de vista mes de IQs
    Structure OrdenMesIQ
        Dim FechaControl As String
        Dim Nombre As String
        Dim TipoIQ As String
    End Structure
    Dim Miq As New OrdenMesIQ()
    Dim ArrayMesOrdenadosIQ As New ArrayList()

    'variables de orden de vista año de IQs
    Structure OrdenAñoIQ
        Dim FechaControl As String
        Dim Nombre As String
        Dim TipoIQ As String
        Dim PendienteIQ As String
    End Structure
    Dim Aiq As New OrdenAñoIQ()
    Dim ArrayAñoOrdenadosIQ As New ArrayList()


    '0000000000000000000 Variables de los Pagos 000000000000000000000

    Dim PathPAGO As String
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
    Dim FichaHonPendientesIQ As Integer
    Dim FichaHonPagadosIQ As Integer
    Dim FichaHonConsultas As Integer

    'variables comunes de honorarios
    Dim HonorariosPendientes As Integer
    Dim HonorariosPagados As Integer
    Dim HonorariosTotales As Integer

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

        F = Nothing

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
        PathAgenda = Form1.PSstrPathAgendaBDH

        PathPAGO = Form1.PathPago



        'creo q no se usaran aca pero...
        'ArchivoIndice = PathAgenda & "\IndiceControles.agd"
        ArchivoIndiceProximos = PathAgenda & "\IndiceProximos.agd"

        'apunta a la fecha de hoy en la parte de controles diarios
        Calendario.SelectionStart = Today
        'apaga inicialmente el boton de editar la consulta seleccionada (porq aun no se selecciono nada
        botCONTROLESdiaEditarConsulta.Enabled = False

        'apunta el inicio de meses al mes y año actuales (para meses)
        MesSeleccionadoNumero = Form1.PSdateFechaDeArraqueDeAgenda.Month
        AñoSeleccionadoNumerodeMes = Form1.PSdateFechaDeArraqueDeAgenda.Year

        'apunta el inicio de años al año actual (para años)
        AñoSeleccionadoNumerodeAño = Form1.PSdateFechaDeArraqueDeAgenda.Year


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
        FechaSeleccionadaIQvistaDia = Today

        'apunta el inicio de meses al mes y año actuales (para meses)
        FechaSeleccionadaIQvistames = Today
        AñoSeleccionadoIQvistames = Today.Year
        MesSeleccionadoIQvistames = Today.Month


        FechaSeleccionadaIQvistaaño = Today
        AñoSeleccionadoIQvistaaño = Today.Year


        'Recupera el inicio del path de IQ
        PathIQ = Form1.PathIQ

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

        FechaConsultadaDia = Calendario.SelectionStart
        Temporal = FechaConsultadaDia.ToString("s")
        Largo = Temporal.Length
        FechaDe8 = Temporal.Remove(Largo - 9, 9)
        FechaDe8 = FechaDe8.Remove(4, 1)
        FechaDe8 = FechaDe8.Remove(6, 1)
        FechaDe6 = FechaDe8.Remove(6, 2)
        AñoConsultado = FechaConsultadaDia.Year.ToString
        ArchivoControlDiario = Form1.PSstrPathAgendaBDH & "\" & AñoConsultado & "\Control-" & FechaDe8 & ".agd"
        ArchivoControlMensualdelDia = Form1.PSstrPathAgendaBDH & "\" & AñoConsultado & "\Control-" & FechaDe6 & ".agd"
    End Sub

    Private Sub VerificaDia()

        'variables de verificacion de dias
        Dim PacienteDeEsteDia As String
        Dim Honorarios As Integer
        Dim HonorariosTotalesDia As Integer
        Dim HonorariosFormateadosDia As String
        Dim NumeroPacientesDia As Integer

        'limpia lista de pacientes
        ListBoxPacientesDia.Items.Clear()

        'inicializa las variables dependientes
        Honorarios = 0
        HonorariosTotalesDia = 0
        NumeroPacientesDia = 0
        LabelPacientes.Text = "Consultas del día " & FechaConsultadaDia.ToLongDateString

        'ahora revisa si hay un archivo de control de ese dia
        If File.Exists(ArchivoControlDiario) = True Then
            'existe un archivo de control de este dia, lo lee
            FS = New FileStream(ArchivoControlDiario, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Array03deDias.Clear()
            C = BR.PeekChar
            While FS.Position < FS.Length
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                'calcula honorarios de esta consulta
                If IsNumeric(F.a09Honorarios) = True Then
                    Honorarios = CType(F.a09Honorarios, Integer)
                Else
                    Honorarios = 0
                End If
                HonorariosTotalesDia += Honorarios

                'calcula los pacientes q van
                NumeroPacientesDia += 1

                'añade el paciente a la lista de pacientes
                PacienteDeEsteDia = "Historia: " & F.a01NumeroHistoria & "   de   " & F.a02Nombre
                ListBoxPacientesDia.Items.Add(PacienteDeEsteDia)
                Array03deDias.Add(F)
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'prende el list box para poder seleccionar de la lista
            ListBoxPacientesDia.Enabled = True

            'muestra los honorarios del dia
            HonorariosFormateadosDia = FormatCurrency(HonorariosTotalesDia, , , TriState.True, TriState.True)
            labHonorariosTotalesDia.Text = HonorariosFormateadosDia
            'muestra cuantos pacientes
            labNumeroPacientesDia.Text = NumeroPacientesDia
        Else
            'no hay pacientes vistas este dia
            ListBoxPacientesDia.Items.Add("No se ingresaron consultas a la agenda en este día")
            ListBoxPacientesDia.Enabled = False
            'muestra los honorarios del dia
            HonorariosFormateadosDia = FormatCurrency(HonorariosTotalesDia, , , TriState.True, TriState.True)
            labHonorariosTotalesDia.Text = HonorariosFormateadosDia
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

        If File.Exists(ArchivoControlMensualdelDia) = True Then
            'existe un archivo de control de mes, lo lee
            FS = New FileStream(ArchivoControlMensualdelDia, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim Contador As Integer = -1
            C = BR.PeekChar
            While FS.Position < FS.Length
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                '0000000000000000000000000
                Fecha = CType(F.a10FechaConsulta, Date)
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
            Me.Calendario.BoldedDates = Fechas
            Me.Calendario.UpdateBoldedDates()
        End If

        'descarga datos de F
        F = Nothing

    End Sub

    Private Sub Calendario_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        BorraDatosPacienteSeleccionadoDia()
        ConstruyeNombreControlDiario()
        VerificaDia()
    End Sub

    Private Sub BorraDatosPacienteSeleccionadoDia()
        labNumeroHistoriaDia.Text = ""
        labNombreDia.Text = ""
        labCedulaDia.Text = ""
        labLugarDia.Text = ""
        labHonorariosDia.Text = ""
        labProximaCitaDia.Text = ""
        labFacturaDia.Text = ""
        txtAUTOdia.Clear()
        txtIDxDia.Clear()
        txtTtoDia.Clear()
        txtPendienteDia.Clear()
        'inicializa tambien la estructura para q coincida con la pantalla
        F = Nothing
        'apaga el boton de editar consulta
        botCONTROLESdiaEditarConsulta.Enabled = False


    End Sub

    Private Sub ListBoxPacientesDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ListBoxPacientesDia.SelectedIndexChanged
        Dim NumeroSeleccionado As Integer
        'Dim NumerohistoriaSeleccionado As String
        Dim FormatoMoneda As String
        Dim Honorarios As Integer

        'toma el index seleccionado (ojo 0 es el primero)
        NumeroSeleccionado = ListBoxPacientesDia.SelectedIndex
        'asigna lo guardado en ese index a la estructura f
        F = Array03deDias(NumeroSeleccionado)
        'obtiene los valores a partir de f
        labNumeroHistoriaDia.Text = F.a01NumeroHistoria
        labNombreDia.Text = F.a02Nombre
        'las Cedulas
        Dim CedulaActual As String = ""
        CedulaActual = F.a03Cedula
        CedulaActual = CedulaActual.Substring(0, 2) & "." & CedulaActual.Substring(2, 3) & "." & CedulaActual.Substring(5, 3)
        If CedulaActual(0) = "0" Then
            CedulaActual = CedulaActual.Remove(0, 1)
        End If
        labCedulaDia.Text = CedulaActual
        labLugarDia.Text = F.a04Clinica
        'la proxima cita
        If F.a08ProximaConsulta.IndexOf("-"c) > -1 Then
            'tiene formato de string("s") primero transforma
            labProximaCitaDia.Text = (CType(F.a08ProximaConsulta, Date)).ToLongDateString
        Else
            'o esta vacio o en formato de LDS de una vez lo muestra
            labProximaCitaDia.Text = F.a08ProximaConsulta
        End If

        txtIDxDia.Text = F.a05NotaseIDx
        txtTtoDia.Text = F.a06Tratamiento
        txtPendienteDia.Text = F.a07Pendiente
        'formatea honorarios
        If F.a09Honorarios <> "" Then
            Honorarios = F.a09Honorarios
        Else
            Honorarios = 0
        End If
        FormatoMoneda = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
        labHonorariosDia.Text = FormatoMoneda

        'la factura
        If F.a11FacturaAsociada <> "" Then
            labFacturaDia.Text = F.a11FacturaAsociada.PadLeft(5, "0"c)
        Else
            labFacturaDia.Text = ""
        End If


        '===================================================

        '-----Busca Datos Autogenerados---------------------

        'If Form1.NumPrefijo <> "" Then
        '    Dim strHistoriaSinPrefijo = F.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")
        '    strNumeroHistoriaSeleccionado = strHistoriaSinPrefijo.Substring(0, 6)
        'Else
        '    strNumeroHistoriaSeleccionado = F.a01NumeroHistoria.Substring(0, 6)
        'End If

        strNumeroHistoriaSeleccionado = F.a01NumeroHistoria
        dateFechaSeleccionada = FechaConsultadaDia

        subGeneraDatosAutomaticos()

        txtAUTOdia.Text = strAutoGeneradoControlObs & vbCrLf & strAutoGeneradoEco



        '===================================================

        'prende el boton de editar consulta
        botCONTROLESdiaEditarConsulta.Enabled = True

    End Sub

    Private Sub botCONTROLESdiaEditarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCONTROLESdiaEditarConsulta.Click
        'verifica que se haya seleccionado a alguien
        If F.a01NumeroHistoria = "" Then
            MsgBox("Selecciona A alguien Primero....")
            Exit Sub
        ElseIf Form1.PSbooHistoriaAbierta = True Then
            MsgBox("Hay una Historia abierta, cierrala primero para no afectar sus datos...")
            Exit Sub
        End If
        'si llega hasta aca edita la agenda
        EditaAgenda()
    End Sub

    Private Sub EditaAgenda()

        'prende la bandera de q es una edicion rapida de agenda
        Form1.PSbooEdicionRapidaDeLaConsulta = True

        'inicializa las variables necesarias
        Form1.PSdateFechaDeArraqueDeAgenda = CType(F.a10FechaConsulta, Date)
        Form1.PSstrNumeroHistoriaSeleccionada = F.a01NumeroHistoria
        Form1.PSstrPacienteSeleccionadaNombre = F.a02Nombre
        Form1.PSstrPacienteSeleccionadaCedula = F.a03Cedula
        Form1.PSstrPrefijoHistoriaSeleccionada = Form1.PSstrNumeroHistoriaSeleccionada.Substring(0, 5)
        Form1.NumeroDeHistoriaCompleto = F.a01NumeroHistoria

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

        If F.a08ProximaConsulta <> Nothing Then
            Form1.FechaPendienteProximaConsulta = CType(F.a08ProximaConsulta, Date)
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

            If F.a10FechaConsulta = alsConsultasOrdenadas(0).a10FechaConsulta Then
                'esta es la ultima consulta
                Form1.EsLaUltimaConsultaLaSeleccionada = True
            Else
                Form1.EsLaUltimaConsultaLaSeleccionada = False
            End If
        End If

        'antes de salir recuerda en q fecha estaba el calendario
        Dim dateFechaDeLaModificacion = CType(F.a10FechaConsulta, Date)

        'ahora anota en la agenda
        Dim DLG As New FormAnotaEnLaAgenda()
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If

        'actualizo los datos de agenda
        ArrancaPues()

        'vuelvo a seleccionar la fecha donde estaba
        Calendario.SelectionStart = dateFechaDeLaModificacion


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

                'If Form1.NumPrefijo <> "" Then
                '    HistoriaBuscada = (Form1.NumeroDeHistoriaCompleto.Replace(Form1.NumPrefijo, "")).Substring(0, 6)
                'Else
                '    HistoriaBuscada = Form1.NumeroDeHistoriaCompleto.Substring(0, 6)
                'End If

                HistoriaBuscada = Form1.PSstrNumeroHistoriaSeleccionada

                'inicializa la bandera a que no esta pendiente
                Form1.PendienteConsulta = False

                For Each est As Form1.TablaDeArchivosDeIndiceDeProximosControles In arrProximasCitas

                    'If Form1.NumPrefijo <> "" Then
                    '    HistoriaComparada = (est.a02NumeroHistoria.Replace(Form1.NumPrefijo, "")).Substring(0, 6)
                    'Else
                    '    HistoriaComparada = est.a02NumeroHistoria.Substring(0, 6)
                    'End If

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
        MesSeleccionadoCadena = MonthName(MesSeleccionadoNumero)
        labMesSeleccionado.Text = MesSeleccionadoCadena & " de " & AñoSeleccionadoNumerodeMes

        'ahora construye el nombre del archivo de control de meses
        Dim Mes, Año As String
        'primero la cadena del mes
        If MesSeleccionadoNumero < 10 Then
            Mes = "0" & MesSeleccionadoNumero.ToString
        Else
            Mes = MesSeleccionadoNumero.ToString
        End If
        'ahora la cadena de año
        Año = AñoSeleccionadoNumerodeMes.ToString

        ArchivoControlMensual = Form1.PSstrPathAgendaBDH & "\" & Año & "\Control-" & Año & Mes & ".agd"
        'Label2.Text = ArchivoControlMensual
    End Sub

    Private Sub VerificaMes()
        '000000000000000000000000000000000000
        'verificacion de meses
        Dim Fecha As Date
        Dim Linea As String
        Dim FechaFormateada As String
        Dim Honorarios As Integer
        Dim HonorariosTotalesMes As Integer
        Dim HonorariosFormateadosMes As String
        Dim NumeroPacientesMes As Integer

        'limpia lista de pacientes
        ListBoxPacientesMes.Items.Clear()

        'inicializa las variables dependientes
        Honorarios = 0
        HonorariosTotalesMes = 0
        NumeroPacientesMes = 0

        'ahora revisa si hay un archivo de control de ese dia
        If File.Exists(ArchivoControlMensual) = True Then
            'existe un archivo de control de este mes, lo lee
            FS = New FileStream(ArchivoControlMensual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            Array03deMeses.Clear()
            ArraydeLineas.Clear()
            ArrayListaControlesMes.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                'calcula honorarios de esta consulta
                If F.a09Honorarios <> "" Then
                    Honorarios = CType(F.a09Honorarios, Integer)
                Else
                    Honorarios = 0
                End If
                HonorariosTotalesMes += Honorarios
                'calcula los pacientes q van
                NumeroPacientesMes += 1
                '0000000000000000000000000


                'formatea fecha
                Fecha = CType(F.a10FechaConsulta, Date)
                FechaFormateada = Fecha.ToString("s")
                'crea la linea  
                Linea = FechaFormateada & "|" & F.a01NumeroHistoria & "|" & F.a02Nombre
                ArraydeLineas.Add(Linea)
                'va preparando la lista para la impresion
                Linea = Fecha.ToString("s") & "|" & F.a03Cedula & "|" & F.a01NumeroHistoria & "|" & F.a02Nombre & "|" & "Bs. " & F.a09Honorarios.PadLeft(7) & "|" & F.a04Clinica
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
                LargoDelNumeroDeHistoria = F.a01NumeroHistoria.Length

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
                    M.NumeroHistoria = NumeroDeHistoriaOrdenado
                    M.FechaControl = FechaFormateada
                    ArrayNumerosMesOrdenados.Add(M)
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
            HonorariosFormateadosMes = FormatCurrency(HonorariosTotalesMes, , , TriState.True, TriState.True)
            labHonorariosTotalesMes.Text = HonorariosFormateadosMes
            'muestra cuantos pacientes
            labNumeroPacientesMes.Text = NumeroPacientesMes.ToString
        Else
            'no hay pacientes vistas este mes
            ListBoxPacientesMes.Items.Add("No hay consultas registradas en este mes")
            ListBoxPacientesMes.Enabled = False
            'muestra los honorarios del mes
            HonorariosFormateadosMes = FormatCurrency(HonorariosTotalesMes, , , TriState.True, TriState.True)
            labHonorariosTotalesMes.Text = HonorariosFormateadosMes
            'muestra cuantos pacientes
            labNumeroPacientesMes.Text = NumeroPacientesMes.ToString
            'apaga el boton de imprimir la lista ¿cual lista?
            botImprimeConsultasDelMes.Enabled = False
        End If
    End Sub

    Private Sub botAdelantaMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdelantaMes.Click
        MesSeleccionadoNumero += 1
        If MesSeleccionadoNumero = 13 Then
            MesSeleccionadoNumero = 1
            AñoSeleccionadoNumerodeMes += 1
        End If
        'MuestraMes
        ConstruyeNombreControlMensual()
        VerificaMes()
        BorraDatosPacienteSeleccionadoMes()
    End Sub

    Private Sub botRetrocedeMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRetrocedeMes.Click
        MesSeleccionadoNumero -= 1
        If MesSeleccionadoNumero = 0 Then
            MesSeleccionadoNumero = 12
            AñoSeleccionadoNumerodeMes -= 1
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
        Dim Honorarios As Integer
        Dim FormatoMoneda As String

        Indice = ListBoxPacientesMes.SelectedIndex
        M = ArrayNumerosMesOrdenados(Indice)
        HistoriaBuscada = M.NumeroHistoria

        labNumeroHistoriaMes.Text = HistoriaBuscada

        FechaBuscada = M.FechaControl

        Temporal = FechaBuscada.ToString("s")
        Largo = Temporal.Length
        FechaDe8 = Temporal.Remove(Largo - 9, 9)
        FechaDe8 = FechaDe8.Remove(4, 1)
        FechaDe8 = FechaDe8.Remove(6, 1)
        FechaDe6 = FechaDe8.Remove(6, 2)

        Año = FechaBuscada.Year

        ArchivoControlMensual = Form1.PSstrPathAgendaBDH & "\" & Año & "\Control-" & FechaDe6 & ".agd"

        BorraDatosPacienteSeleccionadoMes()
        'busca archivo de proximas consultas
        If File.Exists(ArchivoControlMensual) Then
            'existe un archivo de control mensual lo carga
            FS = New FileStream(ArchivoControlMensual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'ya Dim C se definio un poco arriba por eso falta aca
            C = BR.PeekChar
            While FS.Position < FS.Length
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                'compara el numero de historia para ver si es esta la que se debe mostrar
                If F.a01NumeroHistoria = HistoriaBuscada Then
                    'esta es la historia ahora ve si es la fecha
                    If F.a10FechaConsulta = FechaBuscada Then
                        'esta es, la muestra
                        labNumeroHistoriaMes.Text = F.a01NumeroHistoria
                        labNombreMes.Text = F.a02Nombre
                        'las Cedulas
                        Dim CedulaActual As String = ""
                        CedulaActual = F.a03Cedula
                        CedulaActual = CedulaActual.Substring(0, 2) & "." & CedulaActual.Substring(2, 3) & "." & CedulaActual.Substring(5, 3)
                        If CedulaActual(0) = "0" Then
                            CedulaActual = CedulaActual.Remove(0, 1)
                        End If
                        LabCedulaMes.Text = CedulaActual
                        labLugarMes.Text = F.a04Clinica
                        'la proxima cita
                        If F.a08ProximaConsulta.IndexOf("-"c) > -1 Then
                            'tiene formato de string("s") primero transforma
                            labProximaMes.Text = (CType(F.a08ProximaConsulta, Date)).ToLongDateString
                        Else
                            'o esta vacio o en formato de LDS de una vez lo muestra
                            labProximaMes.Text = F.a08ProximaConsulta
                        End If
                        txtIDxMes.Text = F.a05NotaseIDx
                        txtTtoMes.Text = F.a06Tratamiento
                        txtPendienteMes.Text = F.a07Pendiente

                        'formatea honorarios
                        If F.a09Honorarios <> "" Then
                            Honorarios = F.a09Honorarios
                        Else
                            Honorarios = 0
                        End If
                        FormatoMoneda = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
                        labHonorariosMes.Text = FormatoMoneda

                        'la factura
                        If F.a11FacturaAsociada <> "" Then
                            labFacturaMes.Text = F.a11FacturaAsociada.PadLeft(5, "0"c)
                        Else
                            labFacturaMes.Text = ""
                        End If

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

        'If Form1.NumPrefijo <> "" Then
        '    Dim strHistoriaSinPrefijo = HistoriaBuscada.Replace(Form1.NumPrefijo, "")
        '    strNumeroHistoriaSeleccionado = strHistoriaSinPrefijo.Substring(0, 6)
        'Else
        '    strNumeroHistoriaSeleccionado = HistoriaBuscada.Substring(0, 6)
        'End If

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
        labAñoSeleccionado.Text = AñoSeleccionadoNumerodeAño
        'construye el nombre de control anual
        Año = AñoSeleccionadoNumerodeAño.ToString
        ArchivoControlAnual = Form1.PSstrPathAgendaBDH & "\" & Año & "\Control-" & Año & ".agd"
    End Sub

    Private Sub VerificaAño()

        '000000000000000000000000000000000000
        'verificacion de años

        'variables de verificacion de años
        Dim FechaFormateada As String
        Dim Fecha As Date
        Dim Honorarios As Integer
        Dim HonorariosTotalesAño As Integer
        Dim HonorariosFormateadosAño As String
        Dim NumeroPacientesAño As Integer
        Dim Linea As String
        Dim LargoDelNumeroDeHistoria As Integer

        'limpia lista de pacientes
        ListBoxPacientesAño.Items.Clear()

        'inicializa las variables dependientes
        Honorarios = 0
        HonorariosTotalesAño = 0
        NumeroPacientesAño = 0

        'ahora revisa si hay un archivo de control de ese año
        If File.Exists(ArchivoControlAnual) = True Then
            'existe un archivo de control de este año, lo lee
            FS = New FileStream(ArchivoControlAnual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            Array03deAños.Clear()
            ArraydeLineas.Clear()
            ArrayListaControlesAño.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                'calcula honorarios de esta consulta
                If F.a09Honorarios <> "" Then
                    Honorarios = CType(F.a09Honorarios, Integer)
                Else
                    Honorarios = 0
                End If
                HonorariosTotalesAño += Honorarios
                'calcula los pacientes q van
                NumeroPacientesAño += 1

                'formatea la fecha
                Fecha = CType(F.a10FechaConsulta, Date)
                FechaFormateada = Fecha.ToString("s")
                'crea la linea  
                Linea = FechaFormateada & "|" & F.a01NumeroHistoria & "|" & F.a02Nombre
                ArraydeLineas.Add(Linea)
                C = BR.PeekChar
                '00000000000000000000000000000000000

                'va preparando la lista para la impresion
                Linea = Fecha.ToString("s") & "|" & F.a03Cedula & "|" & F.a01NumeroHistoria & "|" & F.a02Nombre & "|" & "Bs. " & F.a09Honorarios.PadLeft(7) & "|" & F.a04Clinica
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
                LargoDelNumeroDeHistoria = F.a01NumeroHistoria.Length

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
                    O.NumeroHistoria = NumeroDeHistoriaOrdenado
                    O.FechaControl = FechaFormateada
                    ArrayNumerosAñoOrdenados.Add(O)
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
            HonorariosFormateadosAño = FormatCurrency(HonorariosTotalesAño, , , TriState.True, TriState.True)
            labHonorariosTotalesAño.Text = HonorariosFormateadosAño
            'muestra cuantos pacientes
            labNumeroPacientesAño.Text = NumeroPacientesAño.ToString

        Else
            'no hay pacientes vistas este año
            ListBoxPacientesAño.Items.Add("No hay consultas registradas en este año")
            ListBoxPacientesAño.Enabled = False
            'muestra los honorarios del año
            HonorariosFormateadosAño = FormatCurrency(HonorariosTotalesAño, , , TriState.True, TriState.True)
            labHonorariosTotalesAño.Text = HonorariosFormateadosAño
            'muestra cuantos pacientes
            labNumeroPacientesAño.Text = NumeroPacientesAño.ToString
            'apaga el boton de imprimir la lista
            botImprimeConsultasDelAño.Enabled = False
        End If


        '00000000000000000000000000
    End Sub

    Private Sub botAdelantaAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdelantaAño.Click
        AñoSeleccionadoNumerodeAño += 1
        'Muestraaño
        ConstruyeNombreControlAnual()
        VerificaAño()
        BorraDatosPacienteSeleccionadoAño()
    End Sub

    Private Sub botRetrocedeAño_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRetrocedeAño.Click
        AñoSeleccionadoNumerodeAño -= 1
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
        Dim Honorarios As Integer
        Dim FormatoMoneda As String

        Indice = ListBoxPacientesAño.SelectedIndex
        O = ArrayNumerosAñoOrdenados(Indice)
        HistoriaBuscada = O.NumeroHistoria

        labNumeroHistoriaAño.Text = HistoriaBuscada

        FechaBuscada = CType(O.FechaControl, Date)

        Temporal = FechaBuscada.ToString("s")
        Largo = Temporal.Length
        FechaDe8 = Temporal.Remove(Largo - 9, 9)
        FechaDe8 = FechaDe8.Remove(4, 1)
        FechaDe8 = FechaDe8.Remove(6, 1)

        Año = FechaBuscada.Year

        ArchivoControlAnual = Form1.PSstrPathAgendaBDH & "\" & Año & "\Control-" & Año & ".agd"

        BorraDatosPacienteSeleccionadoAño()
        'busca archivo de proximas consultas
        If File.Exists(ArchivoControlAnual) Then
            'existe un archivo de proximas citas ese dia lo carga
            FS = New FileStream(ArchivoControlAnual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'ya Dim C se definio un poco arriba por eso falta aca
            C = BR.PeekChar
            While FS.Position < FS.Length
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                'compara el numero de historia para ver si es esta la que se debe mostrar
                If F.a01NumeroHistoria = HistoriaBuscada Then
                    'esta es la historia ve si tambien es la fecha
                    FechaComparada = CType(F.a10FechaConsulta, Date) 'lo carga en una variable date...
                    If FechaComparada = FechaBuscada Then
                        'esta es la historia y la fecha la muestra
                        labNumeroHistoriaAño.Text = F.a01NumeroHistoria
                        labNombreAño.Text = F.a02Nombre
                        'las Cedulas
                        Dim CedulaActual As String = ""
                        CedulaActual = F.a03Cedula
                        CedulaActual = CedulaActual.Substring(0, 2) & "." & CedulaActual.Substring(2, 3) & "." & CedulaActual.Substring(5, 3)
                        If CedulaActual(0) = "0" Then
                            CedulaActual = CedulaActual.Remove(0, 1)
                        End If
                        labCedulaAño.Text = CedulaActual
                        labLugarAño.Text = F.a04Clinica
                        'la proxima cita
                        If F.a08ProximaConsulta.IndexOf("-"c) > -1 Then
                            'tiene formato de string("s") primero transforma
                            labProximaAño.Text = (CType(F.a08ProximaConsulta, Date)).ToLongDateString
                        Else
                            'o esta vacio o en formato de LDS de una vez lo muestra
                            labProximaAño.Text = F.a08ProximaConsulta
                        End If
                        txtIDxAño.Text = F.a05NotaseIDx
                        txtTtoAño.Text = F.a06Tratamiento
                        txtPendienteAño.Text = F.a07Pendiente

                        'formatea honorarios
                        If F.a09Honorarios <> "" Then
                            Honorarios = F.a09Honorarios
                        Else
                            Honorarios = 0
                        End If
                        FormatoMoneda = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
                        labHonorariosAño.Text = FormatoMoneda

                        'la factura
                        If F.a11FacturaAsociada <> "" Then
                            labFacturaAño.Text = F.a11FacturaAsociada.PadLeft(5, "0"c)
                        Else
                            labFacturaAño.Text = ""
                        End If

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

        'If Form1.NumPrefijo <> "" Then
        '    Dim strHistoriaSinPrefijo = HistoriaBuscada.Replace(Form1.NumPrefijo, "")
        '    strNumeroHistoriaSeleccionado = strHistoriaSinPrefijo.Substring(0, 6)
        'Else
        '    strNumeroHistoriaSeleccionado = HistoriaBuscada.Substring(0, 6)
        'End If

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
        If File.Exists(ArchivoIndiceProximos) = True Then
            ListBoxProximas.Enabled = True
            ListBoxVencidas.Enabled = True
            'existe lo muestra en el list box
            FS = New FileStream(ArchivoIndiceProximos, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'ya fue declarada antes Dim C As Integer

            'inicializa arrays
            ArraydeLineas.Clear()
            ArraydeLineasVencidas.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                K = Nothing
                ' Read fields and populate structure
                K.a01FechaProximocontrol = BR.ReadString
                K.a02NumeroHistoria = BR.ReadString
                K.a03Nombre = BR.ReadString

                'inicializa la  variable "fecha"
                Fecha = CType(K.a01FechaProximocontrol, Date)

                If Fecha >= Today Then
                    'cita vigente
                    'formatea fecha
                    FechaFormateada = Fecha.ToString("s")
                    'Console.WriteLine("FechaFormateada(s): " & FechaFormateada)
                    'crea la linea  
                    Linea = FechaFormateada & "|" & K.a02NumeroHistoria & "|" & K.a03Nombre
                    'Console.WriteLine("Linea: " & Linea)
                    ArraydeLineas.Add(Linea)
                    NumerodeProgramadas += 1
                Else
                    'esta cita esta vencida
                    FechaFormateada = Fecha.ToString("s")
                    'Console.WriteLine("FechaFormateada(s): " & FechaFormateada)
                    'crea la linea  
                    Linea = FechaFormateada & "|" & K.a02NumeroHistoria & "|" & K.a03Nombre
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
                LargoDelNumeroDeHistoria = K.a02NumeroHistoria.Length

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
                LargoDelNumeroDeHistoria = K.a02NumeroHistoria.Length

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
                J = Nothing
                ' Read fields and populate structure
                J.a01NumeroHistoria = BR.ReadString
                J.a02Nombre = BR.ReadString
                J.a03Cedula = BR.ReadString
                J.a04ClinicaUltimoControl = BR.ReadString
                J.a05NotaseIDxUltimoControl = BR.ReadString
                J.a06TratamientoUltimoControl = BR.ReadString
                J.a07Pendiente = BR.ReadString
                J.a08FechaUltimoControl = BR.ReadString
                J.a09HonorariosUltimoControl = BR.ReadString
                J.a10FechaProximoControl = BR.ReadString

                'acomoda numero de historia
                Dim strNumeroBuscadoLocal As String
                'If Form1.NumPrefijo <> "" Then
                '    strNumeroBuscadoLocal = (J.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")).Substring(0, 6)
                'Else
                '    strNumeroBuscadoLocal = J.a01NumeroHistoria.Substring(0, 6)
                'End If

                strNumeroBuscadoLocal = J.a01NumeroHistoria

                'compara el numero de historia para ver si es esta la que se debe mostrar
                If strNumeroBuscadoLocal = HistoriaBuscada Then
                    'esta es la muestra
                    labNumeroHistoriaProxima.Text = J.a01NumeroHistoria
                    labNombreProxima.Text = J.a02Nombre
                    'las Cedulas
                    Dim CedulaActual As String = ""
                    CedulaActual = J.a03Cedula
                    CedulaActual = CedulaActual.Substring(0, 2) & "." & CedulaActual.Substring(2, 3) & "." & CedulaActual.Substring(5, 3)
                    If CedulaActual(0) = "0" Then
                        CedulaActual = CedulaActual.Remove(0, 1)
                    End If
                    labCedulaProxima.Text = CedulaActual
                    labLugarProxima.Text = J.a04ClinicaUltimoControl
                    'los honorarios
                    Dim HonorariosFormateados As String
                    Dim Honorarios As Integer
                    If J.a09HonorariosUltimoControl = "" Then
                        Honorarios = 0
                    Else
                        Honorarios = CType(J.a09HonorariosUltimoControl, Integer)
                    End If

                    HonorariosFormateados = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
                    labHonorariosProxima.Text = HonorariosFormateados
                    'formatea la fecha
                    If J.a08FechaUltimoControl.IndexOf("-"c) > -1 Then
                        'esta en formato ordenado pasa a LDS
                        labFechaConsultaProxima.Text = (CType(J.a08FechaUltimoControl, Date)).ToLongDateString
                    Else
                        'esta en formato de LDS
                        labFechaConsultaProxima.Text = J.a08FechaUltimoControl
                    End If

                    txtIDxProxima.Text = J.a05NotaseIDxUltimoControl
                    txtTtoProxima.Text = J.a06TratamientoUltimoControl
                    txtPendienteProxima.Text = J.a07Pendiente

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
        dateFechaSeleccionada = CType(J.a08FechaUltimoControl, Date)

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
                J = Nothing
                ' Read fields and populate structure
                J.a01NumeroHistoria = BR.ReadString
                J.a02Nombre = BR.ReadString
                J.a03Cedula = BR.ReadString
                J.a04ClinicaUltimoControl = BR.ReadString
                J.a05NotaseIDxUltimoControl = BR.ReadString
                J.a06TratamientoUltimoControl = BR.ReadString
                J.a07Pendiente = BR.ReadString
                J.a08FechaUltimoControl = BR.ReadString
                J.a09HonorariosUltimoControl = BR.ReadString
                J.a10FechaProximoControl = BR.ReadString

                'acomoda numero de historia
                Dim strNumeroBuscadoLocal As String
                'If Form1.NumPrefijo <> "" Then
                '    strNumeroBuscadoLocal = (J.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")).Substring(0, 6)
                'Else
                '    strNumeroBuscadoLocal = J.a01NumeroHistoria.Substring(0, 6)
                'End If

                strNumeroBuscadoLocal = J.a01NumeroHistoria
                'compara el numero de historia para ver si es esta la que se debe mostrar
                If strNumeroBuscadoLocal = HistoriaBuscada Then
                    'esta es la muestra
                    labNumeroHistoriaProxima.Text = J.a01NumeroHistoria
                    labNombreProxima.Text = J.a02Nombre
                    'las Cedulas
                    Dim CedulaActual As String = ""
                    CedulaActual = J.a03Cedula
                    CedulaActual = CedulaActual.Substring(0, 2) & "." & CedulaActual.Substring(2, 3) & "." & CedulaActual.Substring(5, 3)
                    If CedulaActual(0) = "0" Then
                        CedulaActual = CedulaActual.Remove(0, 1)
                    End If
                    labCedulaProxima.Text = CedulaActual
                    labLugarProxima.Text = J.a04ClinicaUltimoControl
                    'los honorarios
                    Dim HonorariosFormateados As String
                    Dim Honorarios As Integer
                    Honorarios = CType(J.a09HonorariosUltimoControl, Integer)
                    HonorariosFormateados = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
                    labHonorariosProxima.Text = HonorariosFormateados
                    'formatea la fecha
                    If J.a08FechaUltimoControl.IndexOf("-"c) > -1 Then
                        'esta en formato ordenado pasa a LDS
                        labFechaConsultaProxima.Text = (CType(J.a08FechaUltimoControl, Date)).ToLongDateString
                    Else
                        'esta en formato de LDS
                        labFechaConsultaProxima.Text = J.a08FechaUltimoControl
                    End If
                    txtIDxProxima.Text = J.a05NotaseIDxUltimoControl
                    txtTtoProxima.Text = J.a06TratamientoUltimoControl
                    txtPendienteProxima.Text = J.a07Pendiente

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
        dateFechaSeleccionada = CType(J.a08FechaUltimoControl, Date)

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
            'If Form1.NumTieneSufijo = True Then
            '    ValorSufijo = (contador * Form1.NumIncremento) + 1
            '    If ValorSufijo >= 1000 Then
            '        ValorSufijo = ValorSufijo - 1000
            '    End If

            '    Sufijo = ValorSufijo.ToString
            '    If Sufijo.Length = 1 Then
            '        Sufijo = "-00" & Sufijo
            '    ElseIf Sufijo.Length = 2 Then
            '        Sufijo = "-0" & Sufijo
            '    ElseIf Sufijo.Length = 3 Then
            '        Sufijo = "-" & Sufijo
            '    End If
            'Else
            '    Sufijo = ""
            'End If
            'Linea = Form1.NumPrefijo & H.NumeroHistoria & Sufijo & "|" & H.NombrePaciente

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
        Dim HonorariosTotalesFormateadosPaciente As String
        Dim HonorariosTotalesPaciente As Integer
        Dim Honorarios As Integer
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
        ArchivoPropioAGD = Path & "\" & HistoriaBuscada & ".agd"
        listBoxConsultas.Items.Clear()
        HonorariosTotalesPaciente = 0
        arrayFechasDeConsultas.Clear()
        'busca archivo de proximas consultas
        If File.Exists(ArchivoPropioAGD) Then
            'existe un archivo de proximas citas ese dia lo carga
            FS = New FileStream(ArchivoPropioAGD, FileMode.Open, FileAccess.Read)
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

                If R.a07Honorarios = "" Then
                    Honorarios = 0
                Else
                    Honorarios = CType(R.a07Honorarios, Integer)
                    If Fecha < year2008 Then
                        Honorarios = Honorarios \ 1000
                    End If

                End If
                HonorariosTotalesPaciente += Honorarios

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
            HonorariosTotalesFormateadosPaciente = FormatCurrency(HonorariosTotalesPaciente, , , TriState.True, TriState.True)
            labHonorariosTotalesPaciente.Text = HonorariosTotalesFormateadosPaciente
            'muestra cuantos pacientes
            labNumeroConsultasPaciente.Text = contador.ToString
        Else
            listBoxConsultas.Items.Add("No Tiene Controles registrados")
            listBoxConsultas.Enabled = False
            labConsultas.Text = "Consultas Archivadas"
            'muestra los honorarios totales del paciente
            HonorariosTotalesFormateadosPaciente = FormatCurrency(HonorariosTotalesPaciente, , , TriState.True, TriState.True)
            labHonorariosTotalesPaciente.Text = HonorariosTotalesFormateadosPaciente
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
        Dim Honorarios As Integer
        Dim HonorariosFormateadosPaciente As String

        FechaBuscada = CType(listBoxConsultas.SelectedItem, Date)
        If File.Exists(ArchivoPropioAGD) Then
            FS = New FileStream(ArchivoPropioAGD, FileMode.Open, FileAccess.Read)
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
                        If R.a07Honorarios = "" Then
                            Honorarios = 0
                        Else
                            Honorarios = CType(R.a07Honorarios, Integer)
                        End If
                        HonorariosFormateadosPaciente = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
                        labHonorariosPaciente.Text = HonorariosFormateadosPaciente
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

    Private Sub ConstruyeNombresIQvistadia()
        AñoSeleccionadoIQvistadia = FechaSeleccionadaIQvistaDia.Year.ToString
        MesSeleccionadoIQvistadia = FechaSeleccionadaIQvistaDia.Month.ToString
        If MesSeleccionadoIQvistadia.Length = 1 Then
            MesSeleccionadoIQvistadia = "0" & MesSeleccionadoIQvistadia
        End If
        DiaSeleccionadoIQvistadia = FechaSeleccionadaIQvistaDia.Day.ToString
        If DiaSeleccionadoIQvistadia.Length = 1 Then
            DiaSeleccionadoIQvistadia = "0" & DiaSeleccionadoIQvistadia
        End If

        PathIQsubVistaDia = PathIQ & "\" & AñoSeleccionadoIQvistadia
        archivoIQDia = PathIQsubVistaDia & "\IQ-" & AñoSeleccionadoIQvistadia & MesSeleccionadoIQvistadia & DiaSeleccionadoIQvistadia & ".iqr"
    End Sub

    Private Sub VerificaDiaIQ()

      
        'verificacion de dias

        'variables de verificacion de dias IQ
        Dim IQdeEsteDia As String
        Dim HonorariosPendientesDia As Integer
        Dim HonorariosPagadosDia As Integer
        Dim HonorariosTotalesDia As Integer
        Dim NumeroIQDia As Integer

        'limpia lista de pacientes
        ListBoxIQdia.Items.Clear()

        'inicializa las variables dependientes
        HonorariosPendientesDia = 0
        HonorariosPagadosDia = 0
        HonorariosTotalesDia = 0
        NumeroIQDia = 0

        'ahora revisa si hay un archivo de IQ de ese dia
        If File.Exists(archivoIQDia) = True Then
            'existe un archivo de control de este dia, lo lee
            FS = New FileStream(archivoIQDia, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            arrayDeIntervencionesDia.Clear()
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
                    HonorariosPendientes = CType(IQ.a13HonorariosEstimados, Integer)
                Else
                    HonorariosPendientes = 0
                End If
                If IQ.a14HonorariosNetosPagados <> "" Then
                    HonorariosPagados = CType(IQ.a14HonorariosNetosPagados, Integer)
                Else
                    HonorariosPagados = 0
                End If
                HonorariosPendientesDia += HonorariosPendientes
                HonorariosPagadosDia += HonorariosPagados
                HonorariosTotalesDia += HonorariosPendientes + HonorariosPagados

                'calcula las IQ q van
                NumeroIQDia += 1

                'añade la IQ a la lista de intervenciones
                IQdeEsteDia = IQ.a02NombrePaciente & " - " & IQ.a04TipoIntervencion
                ListBoxIQdia.Items.Add(IQdeEsteDia)

                arrayDeIntervencionesDia.Add(IQ)
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'muestra el label con informacion del dia
            labIQdia.Text = "Intervenciones del día " & FechaSeleccionadaIQvistaDia.ToLongDateString & ": (" & NumeroIQDia & ")"

            'prende el list box para poder seleccionar de la lista
            ListBoxIQdia.Enabled = True

            'muestra los honorarios del dia
            labHonorariosPendientesTotalesIQdia.Text = FormatCurrency(HonorariosPendientesDia, , , TriState.True, TriState.True)
            labHonorariosPagadosTotalesIQdia.Text = FormatCurrency(HonorariosPagadosDia, , , TriState.True, TriState.True)
            labHonorariosTotalesIQdia.Text = FormatCurrency(HonorariosTotalesDia, , , TriState.True, TriState.True)

        Else
            'no hay pacientes vistas este dia
            ListBoxIQdia.Items.Add("No se ingresaron IQ a la agenda en este día")
            ListBoxIQdia.Enabled = False
            'muestra los honorarios del dia
            HonorariosPendientesDia = 0
            HonorariosPagadosDia = 0
            HonorariosTotalesDia = 0
            labHonorariosPendientesTotalesIQdia.Text = FormatCurrency(HonorariosPendientesDia, , , TriState.True, TriState.True)
            labHonorariosPagadosTotalesIQdia.Text = FormatCurrency(HonorariosPagadosDia, , , TriState.True, TriState.True)
            labHonorariosTotalesIQdia.Text = FormatCurrency(HonorariosTotalesDia, , , TriState.True, TriState.True)

            'muestra cuantos pacientes
            labIQdia.Text = "Intervenciones del día " & FechaSeleccionadaIQvistaDia.ToLongDateString & ": (0)"

        End If

        '000000000000000000000000000000000000000000000
        'parte de las fechas que tienen IQ 

        Dim U As New ArrayList() 'FechasConConsultaMes
        Dim Fecha As Date
        Dim Año As Integer
        Dim Mes As Integer
        Dim Dia As Integer
        Dim Fechas() As Date
        Dim ArchivoIQdelMesdelaVistadeDia As String

        'construye el nombre del mes que se esta viendo en la vista de dias
        ArchivoIQdelMesdelaVistadeDia = PathIQsubVistaDia & "\IQ-" & AñoSeleccionadoIQvistadia & MesSeleccionadoIQvistadia & ".iqr"

        U.Clear()

        If File.Exists(ArchivoIQdelMesdelaVistadeDia) = True Then
            'existe un archivo de control de mes, lo lee
            FS = New FileStream(ArchivoIQdelMesdelaVistadeDia, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim Contador As Integer = -1
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

                '0000000000000000000000000
                'ojo modificacion cuando se puso marica y no queria convertir las fechas
                If IQ.a01Fecha.Length > 10 Then
                    IQ.a01Fecha = IQ.a01Fecha.Substring(0, 10)
                End If

                Fecha = CType(IQ.a01Fecha, Date)
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
            Me.CalendarioIQdia.BoldedDates = Fechas
            Me.CalendarioIQdia.UpdateBoldedDates()
        End If
    End Sub

    Private Sub CalendarioIQ_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioIQdia.DateChanged
        BorraDatosIQSeleccionadoDia()
        FechaSeleccionadaIQvistaDia = CalendarioIQdia.SelectionStart
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

    Private Sub ListBoxIQdia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxIQdia.SelectedIndexChanged
        Dim NumeroSeleccionado As Integer
        Dim Honorarios As Integer

        'toma el index seleccionado (ojo 0 es el primero)
        NumeroSeleccionado = ListBoxIQdia.SelectedIndex
        'asigna lo guardado en ese index a la estructura IQ
        IQ = arrayDeIntervencionesDia(NumeroSeleccionado)
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
        If IQ.a13HonorariosEstimados <> "" Then
            Honorarios = CType(IQ.a13HonorariosEstimados, Integer)
        Else
            Honorarios = 0
        End If
        labHonorariosEstimadosIQdia.Text = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
        'formatea honorarios pagados
        If IQ.a14HonorariosNetosPagados <> "" Then
            Honorarios = CType(IQ.a14HonorariosNetosPagados, Integer)
        Else
            Honorarios = 0
        End If
        labHonorariosPagadosIQdia.Text = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
        txtNotasIQdia.Text = IQ.a15Notas

        If IQ.a16FechaDeNacimiento.IndexOf("-"c) > -1 Then
            labFechaNacimientoIQdia.Text = (CType(IQ.a16FechaDeNacimiento, Date)).ToShortDateString
        Else
            labFechaNacimientoIQdia.Text = IQ.a16FechaDeNacimiento
        End If
        labCedulaIQdia.Text = IQ.a17Cedula


    End Sub

    '0        Parte de los IQs de vista de mes

    Private Sub ConstruyeNombresIQvistames()

        'primero muestra que mes esta seleccionado en la vista de mes IQ
        MesSeleccionadoIQvistamesCadena = MonthName(MesSeleccionadoIQvistames)
        labMesSeleccionadoIQ.Text = MesSeleccionadoIQvistamesCadena & " de " & AñoSeleccionadoIQvistames

        'ahora construye el nombre del archivo de control de meses
        Dim Mes, Año As String
        'primero la cadena del mes
        If MesSeleccionadoIQvistames < 10 Then
            Mes = "0" & MesSeleccionadoIQvistames.ToString
        Else
            Mes = MesSeleccionadoIQvistames.ToString
        End If
        'ahora la cadena de año
        Año = AñoSeleccionadoIQvistames.ToString

        PathIQsubVistames = PathIQ & "\" & Año
        archivoIQMes = PathIQsubVistames & "\IQ-" & Año & Mes & ".iqr"

    End Sub

    Private Sub VerificaMesIQ()
        '000000000000000000000000000000000000
        'variables de verificacion de meses IQ
        Dim HonorariosPendientesMes As Integer
        Dim HonorariosPagadosMes As Integer
        Dim HonorariosTotalesMes As Integer
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
        HonorariosPendientesMes = 0
        HonorariosPagadosMes = 0
        HonorariosTotalesMes = 0
        NumeroIQMes = 0

        'ahora revisa si hay un archivo de IQs de ese mes
        If File.Exists(archivoIQMes) = True Then
            'existe un archivo de IQs de este Mes, lo lee
            FS = New FileStream(archivoIQMes, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'resetea los arrays dependientes
            arrayDeIntervencionesMes.Clear()
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
                arrayDeIntervencionesMes.Add(IQ)
                'calcula honorarios de esta IQ
                If IQ.a13HonorariosEstimados <> "" Then
                    HonorariosPendientes = CType(IQ.a13HonorariosEstimados, Integer)
                Else
                    HonorariosPendientes = 0
                End If
                If IQ.a14HonorariosNetosPagados <> "" Then
                    HonorariosPagados = CType(IQ.a14HonorariosNetosPagados, Integer)
                Else
                    HonorariosPagados = 0
                End If
                HonorariosPendientesMes += HonorariosPendientes
                HonorariosPagadosMes += HonorariosPagados
                HonorariosTotalesMes += HonorariosPendientes + HonorariosPagados
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
                    Linea = FechaFormateada & "|" & IQ.a02NombrePaciente & "|" & IQ.a04TipoIntervencion & "|" & IQ.a05RolEnLaIntervencion & "|" & IQ.a10Lugar & "|" & IQ.a13HonorariosEstimados & "|" & PendienteIQ
                Else
                    Linea = FechaFormateada & "|" & IQ.a02NombrePaciente & "|" & IQ.a04TipoIntervencion & "|" & IQ.a05RolEnLaIntervencion & "|" & IQ.a10Lugar & "|" & IQ.a14HonorariosNetosPagados & "|" & PendienteIQ
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
                ArrayMesOrdenadosIQ.Clear()
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
                    Miq.FechaControl = FechaFormateada
                    Miq.Nombre = NombreOrdenado
                    Miq.TipoIQ = TipoIQordenado
                    'añade la estructura al array list de IQ ordenados por fecha del mes
                    ArrayMesOrdenadosIQ.Add(Miq)
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
            labHonorariosPendientesTotalesIQmes.Text = FormatCurrency(HonorariosPendientesMes, , , TriState.True, TriState.True)
            labHonorariosPagadosTotalesIQmes.Text = FormatCurrency(HonorariosPagadosMes, , , TriState.True, TriState.True)
            labHonorariosTotalesIQmes.Text = FormatCurrency(HonorariosTotalesMes, , , TriState.True, TriState.True)
            'muestra el numero de IQs en el mes
            labNumeroIQmes.Text = NumeroIQMes.ToString
        Else
            'no hay IQ hechas este Mes
            ListBoxIQmes.Items.Add("No hay intervenciones registradas en el Mes")
            ListBoxIQmes.Enabled = False
            'apaga el boton de imprime mes
            botImprimeIQmes.Enabled = False

            'muestra los honorarios del Mes
            HonorariosPendientesMes = 0
            HonorariosPagadosMes = 0
            HonorariosTotalesMes = 0
            labHonorariosPendientesTotalesIQmes.Text = FormatCurrency(HonorariosPendientesMes, , , TriState.True, TriState.True)
            labHonorariosPagadosTotalesIQmes.Text = FormatCurrency(HonorariosPagadosMes, , , TriState.True, TriState.True)
            labHonorariosTotalesIQmes.Text = FormatCurrency(HonorariosTotalesMes, , , TriState.True, TriState.True)
            'muestra cuantos pacientes
            labNumeroIQmes.Text = "0"
        End If
    End Sub

    Private Sub botAdelantaMesIQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdelantaMesIQ.Click
        MesSeleccionadoIQvistames += 1
        If MesSeleccionadoIQvistames = 13 Then
            MesSeleccionadoIQvistames = 1
            AñoSeleccionadoIQvistames += 1
        End If
        'MuestraMes
        ConstruyeNombresIQvistames()
        VerificaMesIQ()
        BorraDatosIQSeleccionadoMes()
    End Sub

    Private Sub botRetrocedeMesIQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRetrocedeMesIQ.Click
        MesSeleccionadoIQvistames -= 1
        If MesSeleccionadoIQvistames = 0 Then
            MesSeleccionadoIQvistames = 12
            AñoSeleccionadoIQvistames -= 1
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

        Dim Honorarios As Integer
        Dim SeConsiguieronLosDatos As Boolean

        'primero toma el indice del elemento seleccionado en la estructura
        Indice = ListBoxIQmes.SelectedIndex
        'ahora asigna el contenido del arraylist ordenado en el indice a Miq
        Miq = ArrayMesOrdenadosIQ(Indice)
        'recupera los valores buscados de Miq
        FechaBuscada = Miq.FechaControl
        NombreBuscado = Miq.Nombre
        TipoIQBuscada = Miq.TipoIQ

        BorraDatosIQSeleccionadoMes()

        REnum = arrayDeIntervencionesMes.GetEnumerator

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
                        If IQ.a13HonorariosEstimados <> "" Then
                            Honorarios = CType(IQ.a13HonorariosEstimados, Integer)
                        Else
                            Honorarios = 0
                        End If
                        labHonorariosPendientesIQmes.Text = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
                        'formatea honorarios pagados
                        If IQ.a14HonorariosNetosPagados <> "" Then
                            Honorarios = CType(IQ.a14HonorariosNetosPagados, Integer)
                        Else
                            Honorarios = 0
                        End If
                        labHonorariosPagadosIQmes.Text = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
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
        labAñoSeleccionadoIQ.Text = AñoSeleccionadoIQvistaaño.ToString

        'construye el nombre de control anual
        Año = AñoSeleccionadoIQvistaaño.ToString
        PathIQsubVistaaño = PathIQ & "\" & Año
        archivoIQaño = PathIQsubVistaaño & "\IQ-" & Año & ".iqr"
    End Sub

    Private Sub VerificaAñoIQ()
        '000000000000000000000000000000000000
        'variables de verificacion de años IQ
        Dim HonorariosPendientesAño As Integer
        Dim HonorariosPagadosAño As Integer
        Dim HonorariosTotalesAño As Integer
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
        HonorariosPendientesAño = 0
        HonorariosPagadosAño = 0
        HonorariosTotalesAño = 0
        NumeroIQAño = 0

        'ahora revisa si hay un archivo de IQs de ese año
        If File.Exists(archivoIQaño) = True Then
            'existe un archivo de IQs de este año, lo lee
            FS = New FileStream(archivoIQaño, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            arrayDeIntervencionesAño.Clear()
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
                arrayDeIntervencionesAño.Add(IQ)

                'calcula honorarios de esta IQ
                If IQ.a13HonorariosEstimados <> "" Then
                    HonorariosPendientes = CType(IQ.a13HonorariosEstimados, Integer)
                Else
                    HonorariosPendientes = 0
                End If
                If IQ.a14HonorariosNetosPagados <> "" Then
                    HonorariosPagados = CType(IQ.a14HonorariosNetosPagados, Integer)
                Else
                    HonorariosPagados = 0
                End If
                HonorariosPendientesAño += HonorariosPendientes
                HonorariosPagadosAño += HonorariosPagados
                HonorariosTotalesAño += HonorariosPendientes + HonorariosPagados

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
                    Linea = FechaFormateada & "|" & IQ.a02NombrePaciente & "|" & IQ.a04TipoIntervencion & "|" & IQ.a05RolEnLaIntervencion & "|" & IQ.a10Lugar & "|" & IQ.a13HonorariosEstimados & "|" & PendienteIQ
                Else
                    Linea = FechaFormateada & "|" & IQ.a02NombrePaciente & "|" & IQ.a04TipoIntervencion & "|" & IQ.a05RolEnLaIntervencion & "|" & IQ.a10Lugar & "|" & IQ.a14HonorariosNetosPagados & "|" & PendienteIQ
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
                ArrayAñoOrdenadosIQ.Clear()
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
                    Aiq.FechaControl = FechaFormateada
                    Aiq.Nombre = NombreOrdenado
                    Aiq.TipoIQ = TipoIQordenado
                    Aiq.PendienteIQ = PendienteIQ
                    'añade la estructura al array list de IQ ordenados por fecha del año
                    ArrayAñoOrdenadosIQ.Add(Aiq)

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
            labHonorariosPendientesTotalesIQaño.Text = FormatCurrency(HonorariosPendientesAño, , , TriState.True, TriState.True)
            labHonorariosPagadosTotalesIQaño.Text = FormatCurrency(HonorariosPagadosAño, , , TriState.True, TriState.True)
            labHonorariosTotalesIQaño.Text = FormatCurrency(HonorariosTotalesAño, , , TriState.True, TriState.True)
            'muestra el numero de IQs en el mes
            labNumeroIQaño.Text = NumeroIQAño.ToString
        Else
            'no hay IQ hechas este año
            ListBoxIQaño.Items.Add("No hay intervenciones registradas en el año")
            ListBoxIQaño.Enabled = False
            'apaga el boton de imprime año
            botImprimeIQaño.Enabled = False

            'muestra los honorarios del año
            HonorariosPendientesAño = 0
            HonorariosPagadosAño = 0
            HonorariosTotalesAño = 0
            labHonorariosPendientesTotalesIQaño.Text = FormatCurrency(HonorariosPendientesAño, , , TriState.True, TriState.True)
            labHonorariosPagadosTotalesIQaño.Text = FormatCurrency(HonorariosPagadosAño, , , TriState.True, TriState.True)
            labHonorariosTotalesIQaño.Text = FormatCurrency(HonorariosTotalesAño, , , TriState.True, TriState.True)
            'muestra cuantos pacientes
            labNumeroIQaño.Text = "0"
        End If
    End Sub

    Private Sub botAdelantaAñoIQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAdelantaAñoIQ.Click
        AñoSeleccionadoIQvistaaño += 1
        'MuestraAño
        ConstruyeNombresIQvistaaño()
        VerificaAñoIQ()
        BorraDatosIQSeleccionadoAño()
    End Sub

    Private Sub botRetrocedeAñoIQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRetrocedeAñoIQ.Click
        AñoSeleccionadoIQvistaaño -= 1
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

        Dim Honorarios As Integer
        Dim SeConsiguieronLosDatos As Boolean

        'primero toma el indice del elemento seleccionado en la estructura
        Indice = ListBoxIQaño.SelectedIndex
        'ahora asigna el contenido del arraylist ordenado en el indice a Aiq
        Aiq = ArrayAñoOrdenadosIQ(Indice)
        'recupera los valores buscados de Aiq
        FechaBuscada = Aiq.FechaControl
        NombreBuscado = Aiq.Nombre
        TipoIQBuscada = Aiq.TipoIQ

        BorraDatosIQSeleccionadoAño()

        REnum = arrayDeIntervencionesAño.GetEnumerator

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
                        If IQ.a13HonorariosEstimados <> "" Then
                            Honorarios = CType(IQ.a13HonorariosEstimados, Integer)
                        Else
                            Honorarios = 0
                        End If
                        labHonorariosPendientesIQaño.Text = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
                        'formatea honorarios pagados
                        If IQ.a14HonorariosNetosPagados <> "" Then
                            Honorarios = CType(IQ.a14HonorariosNetosPagados, Integer)
                        Else
                            Honorarios = 0
                        End If
                        labHonorariosPagadosIQaño.Text = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
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
        PathPAGOsubVistaDia = PathPAGO & "\" & AñoSeleccionadoPAGOvistadia
        archivoPAGODia = PathPAGOsubVistaDia & "\Pagos-" & AñoSeleccionadoPAGOvistadia & MesSeleccionadoPAGOvistadia & DiaSeleccionadoPAGOvistadia & ".dat"
        ArchivoControlDiario = PathAgenda & "\" & AñoSeleccionadoPAGOvistadia & "\Control-" & AñoSeleccionadoPAGOvistadia & MesSeleccionadoPAGOvistadia & DiaSeleccionadoPAGOvistadia & ".agd"
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

        If File.Exists(ArchivoControlDiario) = True Then
            'existe un archivo de control de este dia, lo lee
            FS = New FileStream(ArchivoControlDiario, FileMode.Open, FileAccess.Read)
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

            Dim strPagoNeto = "0,00" 'inicializa a una cadena de 0,00 si hay algo lo reemplaza
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
        ArchivoPAGOconsultasDelMesdelaVistadeDia = PathAgenda & "\" & AñoSeleccionadoPAGOvistadia & "\Control-" & AñoSeleccionadoPAGOvistadia & MesSeleccionadoPAGOvistadia & ".agd"

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
                    labPAGOdiaFacturaSel.Text = "Corrige"
                    MsgBox("Este Pago esta incluido en Facturación pero no tiene asociado un número de factura, revisa", MsgBoxStyle.Information, "Pago incluido en Facturación sin Factura?")
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
        PathPAGOsubVistaMes = PathPAGO & "\" & AñoSeleccionadoPAGOvistaMes
        archivoPAGOMes = PathPAGOsubVistaMes & "\Pagos-" & AñoSeleccionadoPAGOvistaMes & MesSeleccionadoPAGOvistaMes & ".dat"
        ArchivoControlMensual = PathAgenda & "\" & AñoSeleccionadoPAGOvistaMes & "\Control-" & AñoSeleccionadoPAGOvistaMes & MesSeleccionadoPAGOvistaMes & ".agd"
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

        If File.Exists(ArchivoControlMensual) = True Then
            'existe un archivo de control de este dia, lo lee
            FS = New FileStream(ArchivoControlMensual, FileMode.Open, FileAccess.Read)
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

            Dim strPagoNeto = "0,00" 'inicializa a una cadena de 0,00 si hay algo lo reemplaza
            If IsNumeric(est.a10decMontoNetoPagado) Then
                'hay un dato valido lo procesa
                strPagoNeto = FormatNumber(CType(est.a10decMontoNetoPagado, Decimal), 2, , , TriState.True)
            End If

            'crea la linea y la muestra
            strPAGOdeEsteMes = strFechaSDS & "     #" & strFactura & "     " & est.a02strPagador.PadRight(43, " "c) & "     " & strPagoNeto.PadLeft(12, " "c)
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
                    labPAGOmesFacturaSel.Text = "Corrige"
                    MsgBox("Este Pago esta incluido en Facturación pero no tiene asociado un número de factura, revisa", MsgBoxStyle.Information, "Pago incluido en Facturación sin Factura?")
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
        PathPAGOsubVistaAÑO = PathPAGO & "\" & AñoSeleccionadoPAGOvistaAÑO
        archivoPAGOAÑO = PathPAGOsubVistaAÑO & "\Pagos-" & AñoSeleccionadoPAGOvistaAÑO & ".dat"
        ArchivoControlAnual = PathAgenda & "\" & AñoSeleccionadoPAGOvistaAÑO & "\Control-" & AñoSeleccionadoPAGOvistaAÑO & ".agd"
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

        If File.Exists(ArchivoControlAnual) = True Then
            'existe un archivo de control de este dia, lo lee
            FS = New FileStream(ArchivoControlAnual, FileMode.Open, FileAccess.Read)
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

            Dim strPagoNeto = "0,00" 'inicializa a una cadena de 0,00 si hay algo lo reemplaza
            If IsNumeric(est.a10decMontoNetoPagado) Then
                'hay un dato valido lo procesa
                strPagoNeto = FormatNumber(CType(est.a10decMontoNetoPagado, Decimal), 2, , , TriState.True)
            End If

            'crea la linea y la muestra
            strPAGOdeEsteAÑO = strFechaSDS & "     #" & strFactura & "     " & est.a02strPagador.PadRight(43, " "c) & "     " & strPagoNeto.PadLeft(12, " "c)
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
                    labPAGOañoFacturaSel.Text = "Corrige"
                    MsgBox("Este Pago esta incluido en Facturación pero no tiene asociado un número de factura, revisa", MsgBoxStyle.Information, "Pago incluido en Facturación sin Factura?")
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
            decPorcentajeRET = ((decRetAdmSEL + decRetIslrSEL + decRetOtrSEL) * 100) / decTotalDevSEL
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
        PathPAGOsubVistaAÑOISLR = PathPAGO & "\" & AñoSeleccionadoPAGOvistaAÑOISLR
        archivoPAGOAÑOislr = PathPAGOsubVistaAÑOISLR & "\Pagos-" & AñoSeleccionadoPAGOvistaAÑOISLR & ".dat"
        ArchivoControlAnualIslr = PathAgenda & "\" & AñoSeleccionadoPAGOvistaAÑOISLR & "\Control-" & AñoSeleccionadoPAGOvistaAÑOISLR & ".agd"

        AñoSeleccionadoPAGOvistaAÑOsiguienteISLR = FechaSeleccionadaPAGOvistaAÑOsiguienteISLR.Year.ToString
        PathPAGOsubVistaAÑOsiguienteISLR = PathPAGO & "\" & AñoSeleccionadoPAGOvistaAÑOsiguienteISLR
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

        If File.Exists(ArchivoControlAnualIslr) = True Then
            'existe un archivo de control de este año, lo lee
            FS = New FileStream(ArchivoControlAnualIslr, FileMode.Open, FileAccess.Read)
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
        Dim decNetoPagadoAñoEsp As Decimal = 0
        Dim decRetAdmAñoEsp As Decimal = 0
        Dim decRetIslrAñoEsp As Decimal = 0
        Dim decRetOtroAñoEsp As Decimal = 0
        Dim decTotalPagoAñoEsp As Decimal = 0
       
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


        txtPagosExportacionDatos.Text += "PAGOS ORDINARIOS DEL AÑO " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf & vbCrLf

        For intMes = 1 To 12

            ProgressBarAñoIslr.Value = (intMes * 100) \ 12
            Me.ProgressBarAñoIslr.Refresh()


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
            Dim alsPAGOSdelMES = From est As Form1.TablaDePagos In alsPAGOSdelAÑOIslrOrdenados
                                  Where CType(est.a01datFecha, Date).Month = intMesParaElQuery AndAlso est.a06intFacturaAsociada <> ""
                                  Select est

            For Each est As Form1.TablaDePagos In alsPAGOSdelMES

                txtPagosExportacionDatos.Text += est.a06intFacturaAsociada.PadLeft(6, "0"c) & " "
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

        'subTOTALIZA EL AÑO
        txtPagosExportacionDatos.Text += "Sub Total Pagos Ordinarios del Año".PadRight(76, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decNetoPagadoAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetAdmAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetIslrAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetOtroAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decTotalPagoAño, 2, , , TriState.True).PadLeft(12, " "c) & " "

        'rayita larga
        txtPagosExportacionDatos.Text += vbCrLf & vbCrLf & "".PadRight(150, "-"c) & vbCrLf & vbCrLf

        'calcula los pagos especiales q estan incluidos pero sin numero de factura x ejemplo las acciones
     
        Dim alsPAGOSespecialesdelAño = From est As Form1.TablaDePagos In alsPAGOSdelAÑOIslrOrdenados
                                       Where est.a06intFacturaAsociada = ""
                                       Select est

        'encabezado
        txtPagosExportacionDatos.Text += "PAGOS ESPECIALES (DIVIDENDOS Y OTROS INGRESOS) de " & FechaSeleccionadaPAGOvistaAÑOISLR.Year.ToString & "." & vbCrLf & vbCrLf
        txtPagosExportacionDatos.Text += "#FACT     FECHA       RIF/CI      PAGADOR                                       PAGO NETO     DesC.ADM    Desc.ISLR    Desc.Otro   TOTAL DEVENGADO" & vbCrLf

        For Each est As Form1.TablaDePagos In alsPAGOSespecialesdelAño

            txtPagosExportacionDatos.Text += est.a06intFacturaAsociada.PadLeft(6, "-"c) & " "
            txtPagosExportacionDatos.Text += CType(est.a01datFecha, Date).ToShortDateString & " "
            txtPagosExportacionDatos.Text += est.a14Rif.PadLeft(12, " "c) & " "
            txtPagosExportacionDatos.Text += est.a02strPagador.PadRight(45, " "c) & " "
            txtPagosExportacionDatos.Text += FormatNumber(est.a10decMontoNetoPagado, 2, , , TriState.True).PadLeft(12, " "c) & " "
            txtPagosExportacionDatos.Text += FormatNumber(est.a08decRetencionADM, 2, , , TriState.True).PadLeft(12, " "c) & " "
            txtPagosExportacionDatos.Text += FormatNumber(est.a07decRetencionISLR, 2, , , TriState.True).PadLeft(12, " "c) & " "
            txtPagosExportacionDatos.Text += FormatNumber(est.a09decRetencionOTROS, 2, , , TriState.True).PadLeft(12, " "c) & " "
            txtPagosExportacionDatos.Text += FormatNumber(est.a11decTotalPago, 2, , , TriState.True).PadLeft(12, " "c) & " "

            txtPagosExportacionDatos.Text += vbCrLf

            'calculos de ingresos especiales del año
            decNetoPagadoAñoEsp += CType(est.a10decMontoNetoPagado, Decimal)
            decRetAdmAñoEsp += CType(est.a08decRetencionADM, Decimal)
            decRetIslrAñoEsp += CType(est.a07decRetencionISLR, Decimal)
            decRetOtroAñoEsp += CType(est.a09decRetencionOTROS, Decimal)
            decTotalPagoAñoEsp += CType(est.a11decTotalPago, Decimal)

            'verifica acumulado de feb a dic para el islr acumulado a declarar
            If CType(est.a01datFecha, Date).Month <> 1 Then
                decRetIslrAcumuladoFebDic += CType(est.a07decRetencionISLR, Decimal)
            End If

        Next

        'totaliza pagos especiales del año
        txtPagosExportacionDatos.Text += "Sub Total de Pagos Especiales".PadRight(76, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decNetoPagadoAñoEsp, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetAdmAñoEsp, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetIslrAñoEsp, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetOtroAñoEsp, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decTotalPagoAñoEsp, 2, , , TriState.True).PadLeft(12, " "c) & " "

        'rayita larga
        txtPagosExportacionDatos.Text += vbCrLf & vbCrLf & "".PadRight(150, "-"c) & vbCrLf & vbCrLf

        'totaliza los ingresos generales del año
        decNetoPagadoAño += decNetoPagadoAñoEsp
        decRetAdmAño += decRetAdmAñoEsp
        decRetIslrAño += decRetIslrAñoEsp
        decRetOtroAño += decRetOtroAñoEsp
        decTotalPagoAño += decTotalPagoAñoEsp

        txtPagosExportacionDatos.Text += "TOTAL GENERAL DE INGRESOS DEL AÑO".PadRight(76, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decNetoPagadoAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetAdmAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetIslrAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decRetOtroAño, 2, , , TriState.True).PadLeft(12, " "c) & " "
        txtPagosExportacionDatos.Text += FormatNumber(decTotalPagoAño, 2, , , TriState.True).PadLeft(12, " "c) & " "

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
        archivoHonIQene = PathIQ & "\" & Año & "\IQ-" & Año & "01.iqr"
        archivoHonIQfeb = PathIQ & "\" & Año & "\IQ-" & Año & "02.iqr"
        archivoHonIQmar = PathIQ & "\" & Año & "\IQ-" & Año & "03.iqr"
        archivoHonIQabr = PathIQ & "\" & Año & "\IQ-" & Año & "04.iqr"
        archivoHonIQmay = PathIQ & "\" & Año & "\IQ-" & Año & "05.iqr"
        archivoHonIQjun = PathIQ & "\" & Año & "\IQ-" & Año & "06.iqr"
        archivoHonIQjul = PathIQ & "\" & Año & "\IQ-" & Año & "07.iqr"
        archivoHonIQago = PathIQ & "\" & Año & "\IQ-" & Año & "08.iqr"
        archivoHonIQsep = PathIQ & "\" & Año & "\IQ-" & Año & "09.iqr"
        archivoHonIQoct = PathIQ & "\" & Año & "\IQ-" & Año & "10.iqr"
        archivoHonIQnov = PathIQ & "\" & Año & "\IQ-" & Año & "11.iqr"
        archivoHonIQdic = PathIQ & "\" & Año & "\IQ-" & Año & "12.iqr"

        'construye los nombres de archivo de mes de los controles de ese año
        archivoHonCONene = PathAgenda & "\" & Año & "\Control-" & Año & "01.agd"
        archivoHonCONfeb = PathAgenda & "\" & Año & "\Control-" & Año & "02.agd"
        archivoHonCONmar = PathAgenda & "\" & Año & "\Control-" & Año & "03.agd"
        archivoHonCONabr = PathAgenda & "\" & Año & "\Control-" & Año & "04.agd"
        archivoHonCONmay = PathAgenda & "\" & Año & "\Control-" & Año & "05.agd"
        archivoHonCONjun = PathAgenda & "\" & Año & "\Control-" & Año & "06.agd"
        archivoHonCONjul = PathAgenda & "\" & Año & "\Control-" & Año & "07.agd"
        archivoHonCONago = PathAgenda & "\" & Año & "\Control-" & Año & "08.agd"
        archivoHonCONsep = PathAgenda & "\" & Año & "\Control-" & Año & "09.agd"
        archivoHonCONoct = PathAgenda & "\" & Año & "\Control-" & Año & "10.agd"
        archivoHonCONnov = PathAgenda & "\" & Año & "\Control-" & Año & "11.agd"
        archivoHonCONdic = PathAgenda & "\" & Año & "\Control-" & Año & "12.agd"


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
        Dim int01iqPen, int02iqPen, int03iqPen, int04iqPen, int05iqPen, int06iqPen, int07iqPen, int08iqPen, int09iqPen, int10iqPen, int11iqPen, int12iqPen As Integer
        Dim int01iqCan, int02iqCan, int03iqCan, int04iqCan, int05iqCan, int06iqCan, int07iqCan, int08iqCan, int09iqCan, int10iqCan, int11iqCan, int12iqCan As Integer
        Dim int01consulta, int02consulta, int03consulta, int04consulta, int05consulta, int06consulta, int07consulta, int08consulta, int09consulta, int10consulta, int11consulta, int12consulta As Integer



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
        int01iqPen = FichaHonPendientesIQ
        int01iqCan = FichaHonPagadosIQ
        lab01iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab01iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de febrero
        ArchivoHonorariosMesIQ = archivoHonIQfeb
        VerificaMesesHonorariosIQ()
        int02iqPen = FichaHonPendientesIQ
        int02iqCan = FichaHonPagadosIQ
        lab02iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab02iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de marzo
        ArchivoHonorariosMesIQ = archivoHonIQmar
        VerificaMesesHonorariosIQ()
        int03iqPen = FichaHonPendientesIQ
        int03iqCan = FichaHonPagadosIQ
        lab03iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab03iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de abril
        ArchivoHonorariosMesIQ = archivoHonIQabr
        VerificaMesesHonorariosIQ()
        int04iqPen = FichaHonPendientesIQ
        int04iqCan = FichaHonPagadosIQ
        lab04iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab04iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de mayo
        ArchivoHonorariosMesIQ = archivoHonIQmay
        VerificaMesesHonorariosIQ()
        int05iqPen = FichaHonPendientesIQ
        int05iqCan = FichaHonPagadosIQ
        lab05iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab05iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de junio
        ArchivoHonorariosMesIQ = archivoHonIQjun
        VerificaMesesHonorariosIQ()
        int06iqPen = FichaHonPendientesIQ
        int06iqCan = FichaHonPagadosIQ
        lab06iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab06iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de julio
        ArchivoHonorariosMesIQ = archivoHonIQjul
        VerificaMesesHonorariosIQ()
        int07iqPen = FichaHonPendientesIQ
        int07iqCan = FichaHonPagadosIQ
        lab07iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab07iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de agosto
        ArchivoHonorariosMesIQ = archivoHonIQago
        VerificaMesesHonorariosIQ()
        int08iqPen = FichaHonPendientesIQ
        int08iqCan = FichaHonPagadosIQ
        lab08iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab08iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de septiembre
        ArchivoHonorariosMesIQ = archivoHonIQsep
        VerificaMesesHonorariosIQ()
        int09iqPen = FichaHonPendientesIQ
        int09iqCan = FichaHonPagadosIQ
        lab09iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab09iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de octubre
        ArchivoHonorariosMesIQ = archivoHonIQoct
        VerificaMesesHonorariosIQ()
        int10iqPen = FichaHonPendientesIQ
        int10iqCan = FichaHonPagadosIQ
        lab10iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab10iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de noviembre
        ArchivoHonorariosMesIQ = archivoHonIQnov
        VerificaMesesHonorariosIQ()
        int11iqPen = FichaHonPendientesIQ
        int11iqCan = FichaHonPagadosIQ
        lab11iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab11iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'mes de diciembre
        ArchivoHonorariosMesIQ = archivoHonIQdic
        VerificaMesesHonorariosIQ()
        int12iqPen = FichaHonPendientesIQ
        int12iqCan = FichaHonPagadosIQ
        lab12iqPen.Text = FormatCurrency(FichaHonPendientesIQ, , , TriState.True, TriState.True)
        lab12iqCan.Text = FormatCurrency(FichaHonPagadosIQ, , , TriState.True, TriState.True)

        'ahora las consultas...

        'enero
        ArchivoHonorariosMesCON = archivoHonCONene
        VerificaMesesHonorariosCON()
        int01consulta = FichaHonConsultas
        lab01cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'febrero
        ArchivoHonorariosMesCON = archivoHonCONfeb
        VerificaMesesHonorariosCON()
        int02consulta = FichaHonConsultas
        lab02cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'marzo
        ArchivoHonorariosMesCON = archivoHonCONmar
        VerificaMesesHonorariosCON()
        int03consulta = FichaHonConsultas
        lab03cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'abril
        ArchivoHonorariosMesCON = archivoHonCONabr
        VerificaMesesHonorariosCON()
        int04consulta = FichaHonConsultas
        lab04cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'mayo
        ArchivoHonorariosMesCON = archivoHonCONmay
        VerificaMesesHonorariosCON()
        int05consulta = FichaHonConsultas
        lab05cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'junio
        ArchivoHonorariosMesCON = archivoHonCONjun
        VerificaMesesHonorariosCON()
        int06consulta = FichaHonConsultas
        lab06cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'julio
        ArchivoHonorariosMesCON = archivoHonCONjul
        VerificaMesesHonorariosCON()
        int07consulta = FichaHonConsultas
        lab07cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'agosto
        ArchivoHonorariosMesCON = archivoHonCONago
        VerificaMesesHonorariosCON()
        int08consulta = FichaHonConsultas
        lab08cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'septiembre
        ArchivoHonorariosMesCON = archivoHonCONsep
        VerificaMesesHonorariosCON()
        int09consulta = FichaHonConsultas
        lab09cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'octubre
        ArchivoHonorariosMesCON = archivoHonCONoct
        VerificaMesesHonorariosCON()
        int10consulta = FichaHonConsultas
        lab10cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'noviembre
        ArchivoHonorariosMesCON = archivoHonCONnov
        VerificaMesesHonorariosCON()
        int11consulta = FichaHonConsultas
        lab11cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)

        'diciembre
        ArchivoHonorariosMesCON = archivoHonCONdic
        VerificaMesesHonorariosCON()
        int12consulta = FichaHonConsultas
        lab12cons.Text = FormatCurrency(FichaHonConsultas, , , TriState.True, TriState.True)


        'totales mensuales
        Dim int01total, int02total, int03total, int04total, int05total, int06total, int07total, int08total, int09total, int10total, int11total, int12total As Integer

        int01total = int01consulta + int01iqCan + int01iqPen
        lab01total.Text = FormatCurrency(int01total, , , TriState.True, TriState.True)

        int02total = int02consulta + int02iqCan + int02iqPen
        lab02total.Text = FormatCurrency(int02total, , , TriState.True, TriState.True)

        int03total = int03consulta + int03iqCan + int03iqPen
        lab03total.Text = FormatCurrency(int03total, , , TriState.True, TriState.True)

        int04total = int04consulta + int04iqCan + int04iqPen
        lab04total.Text = FormatCurrency(int04total, , , TriState.True, TriState.True)

        int05total = int05consulta + int05iqCan + int05iqPen
        lab05total.Text = FormatCurrency(int05total, , , TriState.True, TriState.True)

        int06total = int06consulta + int06iqCan + int06iqPen
        lab06total.Text = FormatCurrency(int06total, , , TriState.True, TriState.True)

        int07total = int07consulta + int07iqCan + int07iqPen
        lab07total.Text = FormatCurrency(int07total, , , TriState.True, TriState.True)

        int08total = int08consulta + int08iqCan + int08iqPen
        lab08total.Text = FormatCurrency(int08total, , , TriState.True, TriState.True)

        int09total = int09consulta + int09iqCan + int09iqPen
        lab09total.Text = FormatCurrency(int09total, , , TriState.True, TriState.True)

        int10total = int10consulta + int10iqCan + int10iqPen
        lab10total.Text = FormatCurrency(int10total, , , TriState.True, TriState.True)

        int11total = int11consulta + int11iqCan + int11iqPen
        lab11total.Text = FormatCurrency(int11total, , , TriState.True, TriState.True)

        int12total = int12consulta + int12iqCan + int12iqPen
        lab12total.Text = FormatCurrency(int12total, , , TriState.True, TriState.True)

        'totales de categorias
        Dim intTotalConsultas, intTotalPendientes, intTotalCanceladas, intTotalIQ As Integer

        intTotalConsultas = int01consulta + int02consulta + int03consulta + int04consulta + int05consulta + int06consulta + _
                            int07consulta + int08consulta + int09consulta + int10consulta + int11consulta + int12consulta
        intTotalPendientes = int01iqPen + int02iqPen + int03iqPen + int04iqPen + int05iqPen + int06iqPen + _
                             int07iqPen + int08iqPen + int09iqPen + int10iqPen + int11iqPen + int12iqPen
        intTotalCanceladas = int01iqCan + int02iqCan + int03iqCan + int04iqCan + int05iqCan + int06iqCan + _
                             int07iqCan + int08iqCan + int09iqCan + int10iqCan + int11iqCan + int12iqCan
        intTotalIQ = intTotalCanceladas + intTotalPendientes


        labTotalConsultas.Text = FormatCurrency(intTotalConsultas, , , TriState.True, TriState.True)
        labTotalConsultas2.Text = FormatCurrency(intTotalConsultas, , , TriState.True, TriState.True)

        labTotalIQpen.Text = FormatCurrency(intTotalPendientes, , , TriState.True, TriState.True)

        labTotalIQcan.Text = FormatCurrency(intTotalCanceladas, , , TriState.True, TriState.True)

        labTotalIQ.Text = FormatCurrency(intTotalIQ, , , TriState.True, TriState.True)

        'Total total
        Dim intTotalGeneral As Integer

        intTotalGeneral = intTotalIQ + intTotalConsultas

        labTotalAño.Text = FormatCurrency(intTotalGeneral, , , TriState.True, TriState.True)
        labTotalAño2.Text = FormatCurrency(intTotalGeneral, , , TriState.True, TriState.True)
        'nojoda !!!!
    End Sub

    Private Sub VerificaMesesHonorariosIQ()
        '000000000000000000000000000000000000
        'variables de verificacion de meses IQ
        Dim HonorariosPendientesMes As Integer
        Dim HonorariosPagadosMes As Integer

        'inicializa las variables dependientes
        FichaHonPendientesIQ = 0
        FichaHonPagadosIQ = 0
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
                If IQ.a13HonorariosEstimados <> "" Then
                    HonorariosPendientesMes = CType(IQ.a13HonorariosEstimados, Integer)
                Else
                    HonorariosPendientesMes = 0
                End If
                If IQ.a14HonorariosNetosPagados <> "" Then
                    HonorariosPagadosMes = CType(IQ.a14HonorariosNetosPagados, Integer)
                Else
                    HonorariosPagadosMes = 0
                End If
                FichaHonPendientesIQ += HonorariosPendientesMes
                FichaHonPagadosIQ += HonorariosPagadosMes

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
        Else
            'muestra los honorarios del Mes
            FichaHonPendientesIQ = 0
            FichaHonPagadosIQ = 0
        End If
    End Sub

    Private Sub VerificaMesesHonorariosCON()
        '000000000000000000000000000000000000
        'verificacion de meses
        Dim Honorarios As Integer


        'inicializa las variables dependientes
        FichaHonConsultas = 0

        'ahora revisa si hay un archivo de control de ese dia
        If File.Exists(ArchivoHonorariosMesCON) = True Then
            'existe un archivo de control de este mes, lo lee
            FS = New FileStream(ArchivoHonorariosMesCON, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                'calcula honorarios de esta consulta
                If F.a09Honorarios <> "" Then
                    Honorarios = CType(F.a09Honorarios, Integer)
                Else
                    Honorarios = 0
                End If
                FichaHonConsultas += Honorarios

                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While
            BR.Close()
            FS.Close()
        Else
            FichaHonConsultas = 0
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
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                'calcula honorarios de esta consulta
                If F.a09Honorarios <> "" Then
                    If IsNumeric(F.a09Honorarios) Then
                        decPagosConsultasPte = CType(F.a09Honorarios, Decimal)
                    Else
                        MsgBox(strPagosArchivoMesCON & vbCrLf & F.a01NumeroHistoria & vbCrLf & F.a10FechaConsulta)
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
                L = Nothing
                ' Read fields and populate structure
                L.a00strIndice = BR.ReadString
                L.a01datFecha = BR.ReadString
                L.a02strPagador = BR.ReadString
                L.a03strMedioDePago = BR.ReadString
                L.a04strBanco = BR.ReadString
                L.a05strNumeroReferencia = BR.ReadString
                L.a06intFacturaAsociada = BR.ReadString
                L.a06bStrFacturero = BR.ReadString
                L.a07decRetencionISLR = BR.ReadString
                L.a08decRetencionADM = BR.ReadString
                L.a09decRetencionOTROS = BR.ReadString
                L.a10decMontoNetoPagado = BR.ReadString
                L.a11decTotalPago = BR.ReadString
                L.a12booIncluidoEnFacturacion = BR.ReadString
                L.a13strNotas = BR.ReadString
                L.a14Rif = BR.ReadString
                L.b01 = BR.ReadString
                L.b02 = BR.ReadString
                L.b03 = BR.ReadString
                L.b04 = BR.ReadString


                'El Pago sin descuento o pago total
                If L.a11decTotalPago <> "" Then
                    decPagosPagoActual = CType(L.a11decTotalPago, Decimal)
                Else
                    decPagosPagoActual = 0
                End If
                decPagosPagoSDMES += decPagosPagoActual

                'las retenciones
                decPagosRetencionActual = 0

                If L.a07decRetencionISLR <> "" Then
                    decPagosRetencionActual += CType(L.a07decRetencionISLR, Decimal)
                End If

                If L.a08decRetencionADM <> "" Then
                    decPagosRetencionActual += CType(L.a08decRetencionADM, Decimal)
                End If

                If L.a09decRetencionOTROS <> "" Then
                    decPagosRetencionActual += CType(L.a09decRetencionOTROS, Decimal)
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
                L = Nothing
                ' Read fields and populate structure
                L.a00strIndice = BR.ReadString
                L.a01datFecha = BR.ReadString
                L.a02strPagador = BR.ReadString
                L.a03strMedioDePago = BR.ReadString
                L.a04strBanco = BR.ReadString
                L.a05strNumeroReferencia = BR.ReadString
                L.a06intFacturaAsociada = BR.ReadString
                L.a06bStrFacturero = BR.ReadString
                L.a07decRetencionISLR = BR.ReadString
                L.a08decRetencionADM = BR.ReadString
                L.a09decRetencionOTROS = BR.ReadString
                L.a10decMontoNetoPagado = BR.ReadString
                L.a11decTotalPago = BR.ReadString
                L.a12booIncluidoEnFacturacion = BR.ReadString
                L.a13strNotas = BR.ReadString
                L.a14Rif = BR.ReadString
                L.b01 = BR.ReadString
                L.b02 = BR.ReadString
                L.b03 = BR.ReadString
                L.b04 = BR.ReadString


                If L.a12booIncluidoEnFacturacion = "True" Then 'se incluyo en la facturacion del islr procede

                    'El Pago sin descuento o pago total
                    If L.a11decTotalPago <> "" Then
                        decPagosPagoActual = CType(L.a11decTotalPago, Decimal)
                    Else
                        decPagosPagoActual = 0
                    End If
                    decPagosPagoSDMES += decPagosPagoActual

                    'el ISLR
                    If L.a07decRetencionISLR <> "" Then
                        decPagosISLRactual = CType(L.a07decRetencionISLR, Decimal)
                    Else
                        decPagosISLRactual = 0
                    End If
                    decPagosISLRmes += decPagosISLRactual

                    'las otras ret
                    decPagosOtrasRetActual = 0

                    If L.a08decRetencionADM <> "" Then
                        decPagosOtrasRetActual += CType(L.a08decRetencionADM, Decimal)
                    End If

                    If L.a09decRetencionOTROS <> "" Then
                        decPagosOtrasRetActual += CType(L.a09decRetencionOTROS, Decimal)
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
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                If F.a11FacturaAsociada <> "" Then 'se asocio a una factura la procesa

                    'calcula honorarios de esta consulta
                    If F.a09Honorarios <> "" Then
                        If IsNumeric(F.a09Honorarios) Then
                            decPagosConsultasPte = CType(F.a09Honorarios, Decimal)
                        Else
                            MsgBox(strPagosArchivoMesCON & vbCrLf & F.a01NumeroHistoria & vbCrLf & F.a10FechaConsulta, MsgBoxStyle.Information, "Corrige Honorarios...")
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
