<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgendaFinal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgendaFinal))
        Me.botActualizar = New System.Windows.Forms.Button()
        Me.botCerrar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageControles = New System.Windows.Forms.TabPage()
        Me.radControlAnual = New System.Windows.Forms.RadioButton()
        Me.radControlMensual = New System.Windows.Forms.RadioButton()
        Me.radControlDiario = New System.Windows.Forms.RadioButton()
        Me.PanelControlAnual = New System.Windows.Forms.Panel()
        Me.botImprimeConsultasDelAño = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.labPagadorAño = New System.Windows.Forms.Label()
        Me.Label175 = New System.Windows.Forms.Label()
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
        Me.labPagadorMes = New System.Windows.Forms.Label()
        Me.Label173 = New System.Windows.Forms.Label()
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
        Me.CalendarioAgendaDias = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LabelPacientes = New System.Windows.Forms.Label()
        Me.GroupBoxConsultaSeleccionadaDia = New System.Windows.Forms.GroupBox()
        Me.labFechaDeCancelacionDia = New System.Windows.Forms.Label()
        Me.labReferenciaDia = New System.Windows.Forms.Label()
        Me.labBancoDia = New System.Windows.Forms.Label()
        Me.labFormaDePagoDia = New System.Windows.Forms.Label()
        Me.labEstatusCancelacionDia = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label176 = New System.Windows.Forms.Label()
        Me.Label177 = New System.Windows.Forms.Label()
        Me.Label178 = New System.Windows.Forms.Label()
        Me.Label189 = New System.Windows.Forms.Label()
        Me.labPagadorDia = New System.Windows.Forms.Label()
        Me.Label161 = New System.Windows.Forms.Label()
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
        Me.botAgendaIqEditaIQ = New System.Windows.Forms.Button()
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
        Me.labCelularDia = New System.Windows.Forms.Label()
        Me.Label201 = New System.Windows.Forms.Label()
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
        'botActualizar
        '
        Me.botActualizar.BackColor = System.Drawing.SystemColors.Control
        Me.botActualizar.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botActualizar.Location = New System.Drawing.Point(8, 620)
        Me.botActualizar.Name = "botActualizar"
        Me.botActualizar.Size = New System.Drawing.Size(224, 23)
        Me.botActualizar.TabIndex = 11
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
        Me.botCerrar.TabIndex = 10
        Me.botCerrar.Text = "Cierra Agenda"
        Me.botCerrar.UseVisualStyleBackColor = False
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
        Me.TabControl1.TabIndex = 9
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
        Me.radControlAnual.Location = New System.Drawing.Point(264, 3)
        Me.radControlAnual.Name = "radControlAnual"
        Me.radControlAnual.Size = New System.Drawing.Size(104, 23)
        Me.radControlAnual.TabIndex = 5
        Me.radControlAnual.Text = "Vista Anual"
        Me.radControlAnual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radControlMensual
        '
        Me.radControlMensual.Location = New System.Drawing.Point(144, 3)
        Me.radControlMensual.Name = "radControlMensual"
        Me.radControlMensual.Size = New System.Drawing.Size(104, 23)
        Me.radControlMensual.TabIndex = 4
        Me.radControlMensual.Text = "Vista Mensual"
        Me.radControlMensual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radControlDiario
        '
        Me.radControlDiario.BackColor = System.Drawing.SystemColors.Control
        Me.radControlDiario.Checked = True
        Me.radControlDiario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.radControlDiario.Location = New System.Drawing.Point(24, 3)
        Me.radControlDiario.Name = "radControlDiario"
        Me.radControlDiario.Size = New System.Drawing.Size(104, 23)
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
        Me.GroupBox3.Controls.Add(Me.labPagadorAño)
        Me.GroupBox3.Controls.Add(Me.Label175)
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
        'labPagadorAño
        '
        Me.labPagadorAño.BackColor = System.Drawing.SystemColors.Info
        Me.labPagadorAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagadorAño.ForeColor = System.Drawing.Color.Black
        Me.labPagadorAño.Location = New System.Drawing.Point(542, 71)
        Me.labPagadorAño.Name = "labPagadorAño"
        Me.labPagadorAño.Size = New System.Drawing.Size(200, 20)
        Me.labPagadorAño.TabIndex = 37
        Me.labPagadorAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label175
        '
        Me.Label175.AutoSize = True
        Me.Label175.Location = New System.Drawing.Point(483, 75)
        Me.Label175.Name = "Label175"
        Me.Label175.Size = New System.Drawing.Size(53, 13)
        Me.Label175.TabIndex = 38
        Me.Label175.Text = "Pagador: "
        Me.Label175.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labFacturaAño
        '
        Me.labFacturaAño.BackColor = System.Drawing.SystemColors.Info
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
        Me.labHonorariosAño.BackColor = System.Drawing.SystemColors.Info
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
        Me.labHonorariosTotalesAño.BackColor = System.Drawing.SystemColors.Info
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
        Me.GroupBox2.Controls.Add(Me.labPagadorMes)
        Me.GroupBox2.Controls.Add(Me.Label173)
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
        'labPagadorMes
        '
        Me.labPagadorMes.BackColor = System.Drawing.SystemColors.Info
        Me.labPagadorMes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagadorMes.ForeColor = System.Drawing.Color.Black
        Me.labPagadorMes.Location = New System.Drawing.Point(542, 71)
        Me.labPagadorMes.Name = "labPagadorMes"
        Me.labPagadorMes.Size = New System.Drawing.Size(200, 20)
        Me.labPagadorMes.TabIndex = 35
        Me.labPagadorMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label173
        '
        Me.Label173.AutoSize = True
        Me.Label173.Location = New System.Drawing.Point(483, 75)
        Me.Label173.Name = "Label173"
        Me.Label173.Size = New System.Drawing.Size(53, 13)
        Me.Label173.TabIndex = 36
        Me.Label173.Text = "Pagador: "
        Me.Label173.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labFacturaMes
        '
        Me.labFacturaMes.BackColor = System.Drawing.SystemColors.Info
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
        Me.labHonorariosMes.BackColor = System.Drawing.SystemColors.Info
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
        Me.labHonorariosTotalesMes.BackColor = System.Drawing.SystemColors.Info
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
        Me.PanelControlDiario.Controls.Add(Me.CalendarioAgendaDias)
        Me.PanelControlDiario.Controls.Add(Me.Label1)
        Me.PanelControlDiario.Controls.Add(Me.Panel6)
        Me.PanelControlDiario.Controls.Add(Me.GroupBoxConsultaSeleccionadaDia)
        Me.PanelControlDiario.Controls.Add(Me.labHonorariosTotalesDia)
        Me.PanelControlDiario.Controls.Add(Me.Label6)
        Me.PanelControlDiario.Controls.Add(Me.labNumeroPacientesDia)
        Me.PanelControlDiario.Controls.Add(Me.ListBoxPacientesDia)
        Me.PanelControlDiario.Location = New System.Drawing.Point(8, 32)
        Me.PanelControlDiario.Name = "PanelControlDiario"
        Me.PanelControlDiario.Size = New System.Drawing.Size(925, 545)
        Me.PanelControlDiario.TabIndex = 0
        '
        'CalendarioAgendaDias
        '
        Me.CalendarioAgendaDias.Location = New System.Drawing.Point(9, 9)
        Me.CalendarioAgendaDias.Name = "CalendarioAgendaDias"
        Me.CalendarioAgendaDias.ShowToday = False
        Me.CalendarioAgendaDias.ShowTodayCircle = False
        Me.CalendarioAgendaDias.TabIndex = 19
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
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labCelularDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label201)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labFechaDeCancelacionDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labReferenciaDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labBancoDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labFormaDePagoDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labEstatusCancelacionDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label118)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label176)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label177)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label178)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label189)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.labPagadorDia)
        Me.GroupBoxConsultaSeleccionadaDia.Controls.Add(Me.Label161)
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
        Me.GroupBoxConsultaSeleccionadaDia.Location = New System.Drawing.Point(8, 180)
        Me.GroupBoxConsultaSeleccionadaDia.Name = "GroupBoxConsultaSeleccionadaDia"
        Me.GroupBoxConsultaSeleccionadaDia.Size = New System.Drawing.Size(914, 362)
        Me.GroupBoxConsultaSeleccionadaDia.TabIndex = 7
        Me.GroupBoxConsultaSeleccionadaDia.TabStop = False
        Me.GroupBoxConsultaSeleccionadaDia.Text = "Consulta Seleccionada"
        '
        'labFechaDeCancelacionDia
        '
        Me.labFechaDeCancelacionDia.BackColor = System.Drawing.SystemColors.Info
        Me.labFechaDeCancelacionDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFechaDeCancelacionDia.ForeColor = System.Drawing.Color.Black
        Me.labFechaDeCancelacionDia.Location = New System.Drawing.Point(444, 91)
        Me.labFechaDeCancelacionDia.Name = "labFechaDeCancelacionDia"
        Me.labFechaDeCancelacionDia.Size = New System.Drawing.Size(200, 20)
        Me.labFechaDeCancelacionDia.TabIndex = 98
        Me.labFechaDeCancelacionDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'labReferenciaDia
        '
        Me.labReferenciaDia.BackColor = System.Drawing.SystemColors.Info
        Me.labReferenciaDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labReferenciaDia.ForeColor = System.Drawing.Color.Black
        Me.labReferenciaDia.Location = New System.Drawing.Point(444, 138)
        Me.labReferenciaDia.Name = "labReferenciaDia"
        Me.labReferenciaDia.Size = New System.Drawing.Size(112, 20)
        Me.labReferenciaDia.TabIndex = 97
        Me.labReferenciaDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'labBancoDia
        '
        Me.labBancoDia.BackColor = System.Drawing.SystemColors.Info
        Me.labBancoDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labBancoDia.ForeColor = System.Drawing.Color.Black
        Me.labBancoDia.Location = New System.Drawing.Point(128, 138)
        Me.labBancoDia.Name = "labBancoDia"
        Me.labBancoDia.Size = New System.Drawing.Size(200, 20)
        Me.labBancoDia.TabIndex = 96
        Me.labBancoDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'labFormaDePagoDia
        '
        Me.labFormaDePagoDia.BackColor = System.Drawing.SystemColors.Info
        Me.labFormaDePagoDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFormaDePagoDia.ForeColor = System.Drawing.Color.Black
        Me.labFormaDePagoDia.Location = New System.Drawing.Point(128, 114)
        Me.labFormaDePagoDia.Name = "labFormaDePagoDia"
        Me.labFormaDePagoDia.Size = New System.Drawing.Size(200, 20)
        Me.labFormaDePagoDia.TabIndex = 95
        Me.labFormaDePagoDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'labEstatusCancelacionDia
        '
        Me.labEstatusCancelacionDia.BackColor = System.Drawing.Color.LightGreen
        Me.labEstatusCancelacionDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEstatusCancelacionDia.ForeColor = System.Drawing.Color.Black
        Me.labEstatusCancelacionDia.Location = New System.Drawing.Point(128, 91)
        Me.labEstatusCancelacionDia.Name = "labEstatusCancelacionDia"
        Me.labEstatusCancelacionDia.Size = New System.Drawing.Size(181, 20)
        Me.labEstatusCancelacionDia.TabIndex = 94
        Me.labEstatusCancelacionDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Location = New System.Drawing.Point(84, 142)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(38, 13)
        Me.Label118.TabIndex = 93
        Me.Label118.Text = "Banco"
        Me.Label118.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label176
        '
        Me.Label176.AutoSize = True
        Me.Label176.Location = New System.Drawing.Point(372, 142)
        Me.Label176.Name = "Label176"
        Me.Label176.Size = New System.Drawing.Size(66, 13)
        Me.Label176.TabIndex = 91
        Me.Label176.Text = "#Referencia"
        Me.Label176.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label177
        '
        Me.Label177.AutoSize = True
        Me.Label177.Location = New System.Drawing.Point(43, 118)
        Me.Label177.Name = "Label177"
        Me.Label177.Size = New System.Drawing.Size(79, 13)
        Me.Label177.TabIndex = 89
        Me.Label177.Text = "Forma de Pago"
        Me.Label177.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label178
        '
        Me.Label178.AutoSize = True
        Me.Label178.Location = New System.Drawing.Point(321, 94)
        Me.Label178.Name = "Label178"
        Me.Label178.Size = New System.Drawing.Size(117, 13)
        Me.Label178.TabIndex = 87
        Me.Label178.Text = "Fecha de Cancelación:"
        Me.Label178.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label189
        '
        Me.Label189.AutoSize = True
        Me.Label189.Location = New System.Drawing.Point(77, 94)
        Me.Label189.Name = "Label189"
        Me.Label189.Size = New System.Drawing.Size(45, 13)
        Me.Label189.TabIndex = 84
        Me.Label189.Text = "Estatus:"
        Me.Label189.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPagadorDia
        '
        Me.labPagadorDia.BackColor = System.Drawing.SystemColors.Info
        Me.labPagadorDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPagadorDia.ForeColor = System.Drawing.Color.Black
        Me.labPagadorDia.Location = New System.Drawing.Point(444, 114)
        Me.labPagadorDia.Name = "labPagadorDia"
        Me.labPagadorDia.Size = New System.Drawing.Size(200, 20)
        Me.labPagadorDia.TabIndex = 33
        Me.labPagadorDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label161
        '
        Me.Label161.AutoSize = True
        Me.Label161.Location = New System.Drawing.Point(385, 118)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(53, 13)
        Me.Label161.TabIndex = 34
        Me.Label161.Text = "Pagador: "
        Me.Label161.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botCONTROLESdiaEditarConsulta
        '
        Me.botCONTROLESdiaEditarConsulta.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botCONTROLESdiaEditarConsulta.Location = New System.Drawing.Point(785, 141)
        Me.botCONTROLESdiaEditarConsulta.Name = "botCONTROLESdiaEditarConsulta"
        Me.botCONTROLESdiaEditarConsulta.Size = New System.Drawing.Size(112, 23)
        Me.botCONTROLESdiaEditarConsulta.TabIndex = 32
        Me.botCONTROLESdiaEditarConsulta.Text = "Editar Consulta"
        Me.botCONTROLESdiaEditarConsulta.UseVisualStyleBackColor = True
        '
        'labFacturaDia
        '
        Me.labFacturaDia.BackColor = System.Drawing.SystemColors.Info
        Me.labFacturaDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFacturaDia.ForeColor = System.Drawing.Color.Black
        Me.labFacturaDia.Location = New System.Drawing.Point(785, 114)
        Me.labFacturaDia.Name = "labFacturaDia"
        Me.labFacturaDia.Size = New System.Drawing.Size(112, 20)
        Me.labFacturaDia.TabIndex = 30
        Me.labFacturaDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Location = New System.Drawing.Point(686, 118)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(93, 13)
        Me.Label121.TabIndex = 31
        Me.Label121.Text = "Factura Asociada:"
        Me.Label121.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(334, 171)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(179, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Signos Subjetivos y Datos Manuales"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(6, 171)
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
        Me.txtAUTOdia.Location = New System.Drawing.Point(9, 187)
        Me.txtAUTOdia.MaxLength = 3000
        Me.txtAUTOdia.Multiline = True
        Me.txtAUTOdia.Name = "txtAUTOdia"
        Me.txtAUTOdia.ReadOnly = True
        Me.txtAUTOdia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAUTOdia.Size = New System.Drawing.Size(300, 169)
        Me.txtAUTOdia.TabIndex = 26
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(643, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Procedimientos y Tratamiento"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(643, 247)
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
        Me.txtPendienteDia.Location = New System.Drawing.Point(643, 263)
        Me.txtPendienteDia.Multiline = True
        Me.txtPendienteDia.Name = "txtPendienteDia"
        Me.txtPendienteDia.ReadOnly = True
        Me.txtPendienteDia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPendienteDia.Size = New System.Drawing.Size(264, 93)
        Me.txtPendienteDia.TabIndex = 21
        '
        'txtTtoDia
        '
        Me.txtTtoDia.BackColor = System.Drawing.SystemColors.Info
        Me.txtTtoDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTtoDia.Location = New System.Drawing.Point(646, 187)
        Me.txtTtoDia.MaxLength = 1000
        Me.txtTtoDia.Multiline = True
        Me.txtTtoDia.Name = "txtTtoDia"
        Me.txtTtoDia.ReadOnly = True
        Me.txtTtoDia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTtoDia.Size = New System.Drawing.Size(261, 57)
        Me.txtTtoDia.TabIndex = 20
        '
        'txtIDxDia
        '
        Me.txtIDxDia.BackColor = System.Drawing.SystemColors.Info
        Me.txtIDxDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtIDxDia.Location = New System.Drawing.Point(337, 187)
        Me.txtIDxDia.MaxLength = 3000
        Me.txtIDxDia.Multiline = True
        Me.txtIDxDia.Name = "txtIDxDia"
        Me.txtIDxDia.ReadOnly = True
        Me.txtIDxDia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDxDia.Size = New System.Drawing.Size(300, 169)
        Me.txtIDxDia.TabIndex = 19
        '
        'labHonorariosDia
        '
        Me.labHonorariosDia.BackColor = System.Drawing.SystemColors.Info
        Me.labHonorariosDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labHonorariosDia.ForeColor = System.Drawing.Color.Black
        Me.labHonorariosDia.Location = New System.Drawing.Point(128, 68)
        Me.labHonorariosDia.Name = "labHonorariosDia"
        Me.labHonorariosDia.Size = New System.Drawing.Size(181, 20)
        Me.labHonorariosDia.TabIndex = 17
        Me.labHonorariosDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(61, 72)
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
        Me.labProximaCitaDia.Location = New System.Drawing.Point(444, 43)
        Me.labProximaCitaDia.Name = "labProximaCitaDia"
        Me.labProximaCitaDia.Size = New System.Drawing.Size(232, 20)
        Me.labProximaCitaDia.TabIndex = 16
        Me.labProximaCitaDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(386, 47)
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
        Me.labLugarDia.Location = New System.Drawing.Point(128, 43)
        Me.labLugarDia.Name = "labLugarDia"
        Me.labLugarDia.Size = New System.Drawing.Size(181, 20)
        Me.labLugarDia.TabIndex = 14
        Me.labLugarDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(85, 47)
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
        Me.labCedulaDia.Location = New System.Drawing.Point(787, 18)
        Me.labCedulaDia.Name = "labCedulaDia"
        Me.labCedulaDia.Size = New System.Drawing.Size(110, 20)
        Me.labCedulaDia.TabIndex = 12
        Me.labCedulaDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(739, 22)
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
        Me.labNombreDia.Location = New System.Drawing.Point(444, 18)
        Me.labNombreDia.Name = "labNombreDia"
        Me.labNombreDia.Size = New System.Drawing.Size(232, 20)
        Me.labNombreDia.TabIndex = 10
        Me.labNombreDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(391, 22)
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
        Me.labNumeroHistoriaDia.Location = New System.Drawing.Point(128, 18)
        Me.labNumeroHistoriaDia.Name = "labNumeroHistoriaDia"
        Me.labNumeroHistoriaDia.Size = New System.Drawing.Size(78, 20)
        Me.labNumeroHistoriaDia.TabIndex = 8
        Me.labNumeroHistoriaDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Historia #"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHonorariosTotalesDia
        '
        Me.labHonorariosTotalesDia.BackColor = System.Drawing.SystemColors.Info
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
        Me.ListBoxPacientesDia.Size = New System.Drawing.Size(480, 147)
        Me.ListBoxPacientesDia.TabIndex = 1
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
        Me.PanelIQdia.Controls.Add(Me.botAgendaIqEditaIQ)
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
        'botAgendaIqEditaIQ
        '
        Me.botAgendaIqEditaIQ.Location = New System.Drawing.Point(8, 182)
        Me.botAgendaIqEditaIQ.Name = "botAgendaIqEditaIQ"
        Me.botAgendaIqEditaIQ.Size = New System.Drawing.Size(204, 23)
        Me.botAgendaIqEditaIQ.TabIndex = 62
        Me.botAgendaIqEditaIQ.Text = "Editar Fecha"
        Me.botAgendaIqEditaIQ.UseVisualStyleBackColor = True
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
        Me.StatusStrip1.TabIndex = 12
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
        Me.BarraEstadoAgenda.Size = New System.Drawing.Size(120, 17)
        Me.BarraEstadoAgenda.Text = "ToolStripStatusLabel1"
        '
        'labCelularDia
        '
        Me.labCelularDia.BackColor = System.Drawing.SystemColors.Info
        Me.labCelularDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCelularDia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCelularDia.Location = New System.Drawing.Point(787, 43)
        Me.labCelularDia.Name = "labCelularDia"
        Me.labCelularDia.Size = New System.Drawing.Size(110, 20)
        Me.labCelularDia.TabIndex = 100
        Me.labCelularDia.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label201
        '
        Me.Label201.AutoSize = True
        Me.Label201.Location = New System.Drawing.Point(739, 47)
        Me.Label201.Name = "Label201"
        Me.Label201.Size = New System.Drawing.Size(42, 13)
        Me.Label201.TabIndex = 99
        Me.Label201.Text = "Celular:"
        Me.Label201.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormAgendaFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 668)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.botActualizar)
        Me.Controls.Add(Me.botCerrar)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAgendaFinal"
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
    Friend WithEvents botActualizar As System.Windows.Forms.Button
    Friend WithEvents botCerrar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageControles As System.Windows.Forms.TabPage
    Friend WithEvents radControlAnual As System.Windows.Forms.RadioButton
    Friend WithEvents radControlMensual As System.Windows.Forms.RadioButton
    Friend WithEvents radControlDiario As System.Windows.Forms.RadioButton
    Friend WithEvents PanelControlAnual As System.Windows.Forms.Panel
    Friend WithEvents botImprimeConsultasDelAño As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents labFacturaAño As System.Windows.Forms.Label
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents txtAUTOaño As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents botAdelantaAño As System.Windows.Forms.Button
    Friend WithEvents botRetrocedeAño As System.Windows.Forms.Button
    Friend WithEvents labAñoSeleccionado As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesAño As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents labNumeroPacientesAño As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ListBoxPacientesAño As System.Windows.Forms.ListBox
    Friend WithEvents PanelControlMensual As System.Windows.Forms.Panel
    Friend WithEvents botImprimeConsultasDelMes As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents labFacturaMes As System.Windows.Forms.Label
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents txtAUTOmes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPendienteMes As System.Windows.Forms.TextBox
    Friend WithEvents txtTtoMes As System.Windows.Forms.TextBox
    Friend WithEvents txtIDxMes As System.Windows.Forms.TextBox
    Friend WithEvents labHonorariosMes As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents labProximaMes As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents labLugarMes As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LabCedulaMes As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents labNombreMes As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents labNumeroHistoriaMes As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesMes As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents labNumeroPacientesMes As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListBoxPacientesMes As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents botAdelantaMes As System.Windows.Forms.Button
    Friend WithEvents botRetrocedeMes As System.Windows.Forms.Button
    Friend WithEvents labMesSeleccionado As System.Windows.Forms.Label
    Friend WithEvents PanelControlDiario As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents LabelPacientes As System.Windows.Forms.Label
    Friend WithEvents GroupBoxConsultaSeleccionadaDia As System.Windows.Forms.GroupBox
    Friend WithEvents botCONTROLESdiaEditarConsulta As System.Windows.Forms.Button
    Friend WithEvents labFacturaDia As System.Windows.Forms.Label
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents txtAUTOdia As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPendienteDia As System.Windows.Forms.TextBox
    Friend WithEvents txtTtoDia As System.Windows.Forms.TextBox
    Friend WithEvents txtIDxDia As System.Windows.Forms.TextBox
    Friend WithEvents labHonorariosDia As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents labProximaCitaDia As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents labLugarDia As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents labCedulaDia As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents labNombreDia As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents labNumeroHistoriaDia As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesDia As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents labNumeroPacientesDia As System.Windows.Forms.Label
    Friend WithEvents ListBoxPacientesDia As System.Windows.Forms.ListBox
    Friend WithEvents TabPageProximos As System.Windows.Forms.TabPage
    Friend WithEvents botImprimeVencidas As System.Windows.Forms.Button
    Friend WithEvents botImprimeVigentes As System.Windows.Forms.Button
    Friend WithEvents labTotalProgramadasVencidas As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents ListBoxVencidas As System.Windows.Forms.ListBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRefirioAproxima As System.Windows.Forms.TextBox
    Friend WithEvents txtUltimoSMSproxima As System.Windows.Forms.TextBox
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents txtNotasProxima As System.Windows.Forms.TextBox
    Friend WithEvents labRefirioAproxima As System.Windows.Forms.Label
    Friend WithEvents labReferidaPorProxima As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents labCelVerificadoProxima As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtAUTOproxima As System.Windows.Forms.TextBox
    Friend WithEvents labTelefonoProxima As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents txtTtoProxima As System.Windows.Forms.TextBox
    Friend WithEvents txtIDxProxima As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtPendienteProxima As System.Windows.Forms.TextBox
    Friend WithEvents labHonorariosProxima As System.Windows.Forms.Label
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
    Friend WithEvents TabPagePacientes As System.Windows.Forms.TabPage
    Friend WithEvents botImprimePacientes As System.Windows.Forms.Button
    Friend WithEvents labNumeroConsultasPaciente As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesPaciente As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtAUTOpaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtPendientePaciente As System.Windows.Forms.TextBox
    Friend WithEvents txtTtoPaciente As System.Windows.Forms.TextBox
    Friend WithEvents txtIDxPaciente As System.Windows.Forms.TextBox
    Friend WithEvents labHonorariosPaciente As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents labProximaPaciente As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents labLugarPaciente As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents labFechaConsultaPaciente As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents labConsultas As System.Windows.Forms.Label
    Friend WithEvents listBoxConsultas As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxPacientes As System.Windows.Forms.ListBox
    Friend WithEvents labFiltro As System.Windows.Forms.Label
    Friend WithEvents TabPageIntervenciones As System.Windows.Forms.TabPage
    Friend WithEvents PanelIQaño As System.Windows.Forms.Panel
    Friend WithEvents botImprimeIQaño As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents labCedulaIQaño As System.Windows.Forms.Label
    Friend WithEvents labFechaNacimientoIQaño As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
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
    Friend WithEvents labEdadIQaño As System.Windows.Forms.Label
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents labNombreIQaño As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesIQaño As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPagadosTotalesIQaño As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPendientesTotalesIQaño As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents labNumeroIQaño As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents botAdelantaAñoIQ As System.Windows.Forms.Button
    Friend WithEvents botRetrocedeAñoIQ As System.Windows.Forms.Button
    Friend WithEvents labAñoSeleccionadoIQ As System.Windows.Forms.Label
    Friend WithEvents ListBoxIQaño As System.Windows.Forms.ListBox
    Friend WithEvents PanelIQmes As System.Windows.Forms.Panel
    Friend WithEvents botImprimeIQmes As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents labCedulaIQmes As System.Windows.Forms.Label
    Friend WithEvents labFechaNacimientoIQmes As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents txtNotasIQmes As System.Windows.Forms.TextBox
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
    Friend WithEvents labEdadIQmes As System.Windows.Forms.Label
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents labNombreIQmes As System.Windows.Forms.Label
    Friend WithEvents Label136 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosTotalesIQmes As System.Windows.Forms.Label
    Friend WithEvents Label140 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPagadosTotalesIQmes As System.Windows.Forms.Label
    Friend WithEvents Label138 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPendientesTotalesIQmes As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents labNumeroIQmes As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents ListBoxIQmes As System.Windows.Forms.ListBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents botAdelantaMesIQ As System.Windows.Forms.Button
    Friend WithEvents botRetrocedeMesIQ As System.Windows.Forms.Button
    Friend WithEvents labMesSeleccionadoIQ As System.Windows.Forms.Label
    Friend WithEvents radIQaño As System.Windows.Forms.RadioButton
    Friend WithEvents radIQmes As System.Windows.Forms.RadioButton
    Friend WithEvents radIQdia As System.Windows.Forms.RadioButton
    Friend WithEvents PanelIQdia As System.Windows.Forms.Panel
    Friend WithEvents labHonorariosTotalesIQdia As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPagadosTotalesIQdia As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents labCedulaIQdia As System.Windows.Forms.Label
    Friend WithEvents labFechaNacimientoIQdia As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtNotasIQdia As System.Windows.Forms.TextBox
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
    Friend WithEvents labEdadIQdia As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents labNombreIQdia As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents labHonorariosPendientesTotalesIQdia As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents labIQdia As System.Windows.Forms.Label
    Friend WithEvents ListBoxIQdia As System.Windows.Forms.ListBox
    Friend WithEvents CalendarioIQdia As System.Windows.Forms.MonthCalendar
    Friend WithEvents TabPagePagos As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPagePagosXdia As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents labPAGOdiaRif As System.Windows.Forms.Label
    Friend WithEvents Label171 As System.Windows.Forms.Label
    Friend WithEvents labPAGOdiaPorcentajeDeRetencion As System.Windows.Forms.Label
    Friend WithEvents Label155 As System.Windows.Forms.Label
    Friend WithEvents Label154 As System.Windows.Forms.Label
    Friend WithEvents txtPAGOdiaNotasSel As System.Windows.Forms.TextBox
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
    Friend WithEvents chkPAGOincluyeNoFacturadosDIA As System.Windows.Forms.CheckBox
    Friend WithEvents Label143 As System.Windows.Forms.Label
    Friend WithEvents Label142 As System.Windows.Forms.Label
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents labPagoDiaTotalDevengado As System.Windows.Forms.Label
    Friend WithEvents Label137 As System.Windows.Forms.Label
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
    Friend WithEvents TabPagePagosXmes As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents labPAGOmesRif As System.Windows.Forms.Label
    Friend WithEvents Label172 As System.Windows.Forms.Label
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
    Friend WithEvents labPagosMesSeleccionado As System.Windows.Forms.Label
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
    Friend WithEvents labPagosMes As System.Windows.Forms.Label
    Friend WithEvents Label156 As System.Windows.Forms.Label
    Friend WithEvents Label158 As System.Windows.Forms.Label
    Friend WithEvents Label159 As System.Windows.Forms.Label
    Friend WithEvents Label160 As System.Windows.Forms.Label
    Friend WithEvents botPagoMesAdelantaMes As System.Windows.Forms.Button
    Friend WithEvents botPagoMesRetrocedeMes As System.Windows.Forms.Button
    Friend WithEvents ListBoxPagosMes As System.Windows.Forms.ListBox
    Friend WithEvents TabPagePagosXaño As System.Windows.Forms.TabPage
    Friend WithEvents ProgressBarAÑO As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents labPAGOañoRif As System.Windows.Forms.Label
    Friend WithEvents Label174 As System.Windows.Forms.Label
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
    Friend WithEvents botPagoAÑOAdelantaAño As System.Windows.Forms.Button
    Friend WithEvents botPagoaÑORetrocedeAño As System.Windows.Forms.Button
    Friend WithEvents ListBoxPagosAño As System.Windows.Forms.ListBox
    Friend WithEvents TabPageISLR As System.Windows.Forms.TabPage
    Friend WithEvents ProgressBarAñoIslr As System.Windows.Forms.ProgressBar
    Friend WithEvents labPagosAñoIslrSeleccionado As System.Windows.Forms.Label
    Friend WithEvents botPagoAdelantaAñoIslr As System.Windows.Forms.Button
    Friend WithEvents botPagoRetrocedeAñoIslr As System.Windows.Forms.Button
    Friend WithEvents txtPagosExportacionDatos As System.Windows.Forms.TextBox
    Friend WithEvents botPagoMuestraDatosDelAñoIslr As System.Windows.Forms.Button
    Friend WithEvents TabPageResHonorarios As System.Windows.Forms.TabPage
    Friend WithEvents txtHonorariosDisplay As System.Windows.Forms.TextBox
    Friend WithEvents radHonorariosTotales As System.Windows.Forms.RadioButton
    Friend WithEvents radHonorariosFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents radHonorariosGenerados As System.Windows.Forms.RadioButton
    Friend WithEvents labHonorariosAñoSeleccionado As System.Windows.Forms.Label
    Friend WithEvents botHonorariosAdelantaAño As System.Windows.Forms.Button
    Friend WithEvents botHonorariosRetrocedeAño As System.Windows.Forms.Button
    Friend WithEvents TabPageCalendario As System.Windows.Forms.TabPage
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents TabPageHonorarios As System.Windows.Forms.TabPage
    Friend WithEvents labTotalAño2 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents labTotalConsultas2 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents labTotalIQ As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents labTotalIQcan As System.Windows.Forms.Label
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
    Friend WithEvents labDiciembre As System.Windows.Forms.Label
    Friend WithEvents lab12cons As System.Windows.Forms.Label
    Friend WithEvents lab12iqPen As System.Windows.Forms.Label
    Friend WithEvents lab12total As System.Windows.Forms.Label
    Friend WithEvents labNoviembre As System.Windows.Forms.Label
    Friend WithEvents lab11cons As System.Windows.Forms.Label
    Friend WithEvents lab11iqPen As System.Windows.Forms.Label
    Friend WithEvents lab11total As System.Windows.Forms.Label
    Friend WithEvents labOctubre As System.Windows.Forms.Label
    Friend WithEvents lab10cons As System.Windows.Forms.Label
    Friend WithEvents lab10iqPen As System.Windows.Forms.Label
    Friend WithEvents lab10total As System.Windows.Forms.Label
    Friend WithEvents labSeptiembre As System.Windows.Forms.Label
    Friend WithEvents lab09cons As System.Windows.Forms.Label
    Friend WithEvents lab09iqPen As System.Windows.Forms.Label
    Friend WithEvents lab09total As System.Windows.Forms.Label
    Friend WithEvents labAgosto As System.Windows.Forms.Label
    Friend WithEvents lab08cons As System.Windows.Forms.Label
    Friend WithEvents lab08iqPen As System.Windows.Forms.Label
    Friend WithEvents lab08total As System.Windows.Forms.Label
    Friend WithEvents labJulio As System.Windows.Forms.Label
    Friend WithEvents lab07cons As System.Windows.Forms.Label
    Friend WithEvents lab07iqPen As System.Windows.Forms.Label
    Friend WithEvents lab07total As System.Windows.Forms.Label
    Friend WithEvents labJunio As System.Windows.Forms.Label
    Friend WithEvents lab06cons As System.Windows.Forms.Label
    Friend WithEvents lab06iqPen As System.Windows.Forms.Label
    Friend WithEvents lab06total As System.Windows.Forms.Label
    Friend WithEvents labMayo As System.Windows.Forms.Label
    Friend WithEvents lab05cons As System.Windows.Forms.Label
    Friend WithEvents lab05iqPen As System.Windows.Forms.Label
    Friend WithEvents lab05total As System.Windows.Forms.Label
    Friend WithEvents labAbril As System.Windows.Forms.Label
    Friend WithEvents lab04cons As System.Windows.Forms.Label
    Friend WithEvents lab04iqPen As System.Windows.Forms.Label
    Friend WithEvents lab04total As System.Windows.Forms.Label
    Friend WithEvents labMarzo As System.Windows.Forms.Label
    Friend WithEvents lab03cons As System.Windows.Forms.Label
    Friend WithEvents lab03iqPen As System.Windows.Forms.Label
    Friend WithEvents lab03total As System.Windows.Forms.Label
    Friend WithEvents labFebrero As System.Windows.Forms.Label
    Friend WithEvents lab02cons As System.Windows.Forms.Label
    Friend WithEvents lab02iqPen As System.Windows.Forms.Label
    Friend WithEvents lab02total As System.Windows.Forms.Label
    Friend WithEvents labEnero As System.Windows.Forms.Label
    Friend WithEvents lab01cons As System.Windows.Forms.Label
    Friend WithEvents lab01iqPen As System.Windows.Forms.Label
    Friend WithEvents lab01total As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents botAdelantaAñoHon As System.Windows.Forms.Button
    Friend WithEvents botRetrocedeAñoHon As System.Windows.Forms.Button
    Friend WithEvents labAñoSeleccionadoHon As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents labTotalAño As System.Windows.Forms.Label
    Friend WithEvents labTotalIQpen As System.Windows.Forms.Label
    Friend WithEvents labTotalConsultas As System.Windows.Forms.Label
    Friend WithEvents Label157 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BarraProgresoAgenda As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents BarraEstadoAgenda As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents botAgendaIqEditaIQ As System.Windows.Forms.Button
    Friend WithEvents labPagadorAño As System.Windows.Forms.Label
    Friend WithEvents Label175 As System.Windows.Forms.Label
    Friend WithEvents labPagadorMes As System.Windows.Forms.Label
    Friend WithEvents Label173 As System.Windows.Forms.Label
    Friend WithEvents labPagadorDia As System.Windows.Forms.Label
    Friend WithEvents Label161 As System.Windows.Forms.Label
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents Label176 As System.Windows.Forms.Label
    Friend WithEvents Label177 As System.Windows.Forms.Label
    Friend WithEvents Label178 As System.Windows.Forms.Label
    Friend WithEvents Label189 As System.Windows.Forms.Label
    Friend WithEvents labEstatusCancelacionDia As System.Windows.Forms.Label
    Friend WithEvents labFormaDePagoDia As System.Windows.Forms.Label
    Friend WithEvents labReferenciaDia As System.Windows.Forms.Label
    Friend WithEvents labBancoDia As System.Windows.Forms.Label
    Friend WithEvents labFechaDeCancelacionDia As System.Windows.Forms.Label
    Friend WithEvents CalendarioAgendaDias As System.Windows.Forms.MonthCalendar
    Friend WithEvents labCelularDia As Label
    Friend WithEvents Label201 As Label
End Class
