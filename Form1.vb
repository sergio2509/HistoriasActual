Imports System.Environment
Imports System.IO

Public Class Form1
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
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListBoxHistorias As System.Windows.Forms.ListBox
    Friend WithEvents BotNuevaHistoria As System.Windows.Forms.Button
    Friend WithEvents botAbrirHistoria As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ListBoxContenido As System.Windows.Forms.ListBox
    Friend WithEvents botDatosPersonales As System.Windows.Forms.Button
    Friend WithEvents botNuevaHistoriaObstetrica As System.Windows.Forms.Button
    Friend WithEvents botNuevoEco As System.Windows.Forms.Button
    Friend WithEvents LabHistoriaAbierta As System.Windows.Forms.Label
    Friend WithEvents LabMensajeBaseDatos As System.Windows.Forms.Label
    Friend WithEvents botCerrarHistoria As System.Windows.Forms.Button
    Friend WithEvents botCerrarHistoria2 As System.Windows.Forms.Button
    Friend WithEvents botRenombraHistoria As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents botGuardias As System.Windows.Forms.Button
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelFiltro As System.Windows.Forms.Label
    Friend WithEvents botConsultaHoy As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuAbreBase As System.Windows.Forms.MenuItem
    Friend WithEvents MenuCreaBase As System.Windows.Forms.MenuItem
    Friend WithEvents ListBoxConsultas As System.Windows.Forms.ListBox
    Friend WithEvents labConsultasArchivadas As System.Windows.Forms.Label
    Friend WithEvents MenuBasedeDatos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAgenda As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemVademecum As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemRecipes As System.Windows.Forms.MenuItem
    Friend WithEvents LabNombreBaseDatos As System.Windows.Forms.Label
    Friend WithEvents LabNumeroSeleccionado As System.Windows.Forms.Label
    Friend WithEvents LabCedulaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents LabNombreSeleccionado As System.Windows.Forms.Label
    Friend WithEvents botIntervenciones As System.Windows.Forms.Button
    Friend WithEvents BotControlGinecologico As System.Windows.Forms.Button
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menuCalculoEGconECO As System.Windows.Forms.MenuItem
    Friend WithEvents menuCalculoEGconFUR As System.Windows.Forms.MenuItem
    Friend WithEvents menuCalculoDCconFUR As System.Windows.Forms.MenuItem
    Friend WithEvents MenuDatosDelUsuario As System.Windows.Forms.MenuItem
    Friend WithEvents botConsultaOtroDia As System.Windows.Forms.Button
    Friend WithEvents labDCfechaDeNacimiento As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents labDCprofesion As System.Windows.Forms.Label
    Friend WithEvents labDCedadActual As System.Windows.Forms.Label
    Friend WithEvents labDCtelefono As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents labDCparidad As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TabControlNotas As System.Windows.Forms.TabControl
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents labDCultimaConsulta As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents labDCnumeroConsultas As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents labDCpacienteDesde As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents PanelAniversarios As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ListBoxCS As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ListBoxCH As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents radEdadViejas As System.Windows.Forms.RadioButton
    Friend WithEvents radEdadMILF As System.Windows.Forms.RadioButton
    Friend WithEvents radEdadMujeres As System.Windows.Forms.RadioButton
    Friend WithEvents radEdadChamas As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PanelEtarios As System.Windows.Forms.Panel
    Friend WithEvents labPacientesGrupoEtario As System.Windows.Forms.Label
    Friend WithEvents ListBoxEdades As System.Windows.Forms.ListBox
    Friend WithEvents radEdadSinDatos As System.Windows.Forms.RadioButton
    Friend WithEvents labDCLugarUltimaConsulta As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents labDCHonorariosTotales As System.Windows.Forms.Label
    Friend WithEvents Label16b As System.Windows.Forms.Label
    Friend WithEvents labDCPromedioPorConsulta As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents botEliminarConsulta As System.Windows.Forms.Button
    Friend WithEvents BaseDatosIndiceHistoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TabPageResumen As System.Windows.Forms.TabPage
    Friend WithEvents botEditarConsulta As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents txtAgendaAuto As System.Windows.Forms.TextBox
    Friend WithEvents txtAgendaManual As System.Windows.Forms.TextBox
    Friend WithEvents txtAgendaPendiente As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents txtAgendaTratamiento As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents txtAgendaProximaConsulta As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents txtAgendaLugarConsulta As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents txtAgendaHonorarios As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents labDCLugar1raConsulta As System.Windows.Forms.Label
    Friend WithEvents labDCTelefonoVerificado As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CalendarioConsultaOtraDia As System.Windows.Forms.MonthCalendar
    Friend WithEvents botPagos As System.Windows.Forms.Button
    Friend WithEvents txtAgendaFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtDCnotas As System.Windows.Forms.TextBox
    Friend WithEvents txtDCultimoSMS As System.Windows.Forms.TextBox
    Friend WithEvents TabPageConsultas As System.Windows.Forms.TabPage
    Friend WithEvents txtDCReferencias As System.Windows.Forms.TextBox
    Friend WithEvents txtDCFamiliatrabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtHistoriaNotificaciones As System.Windows.Forms.TextBox
    Friend WithEvents botConsultaOtroDiaAccion As System.Windows.Forms.Button
    Friend WithEvents labCalendarioConsultaOtroDia As System.Windows.Forms.Label
    Friend WithEvents labDCReferidaPor As System.Windows.Forms.Label
    Friend WithEvents txtDCpacientesReferidasPorReferidor As System.Windows.Forms.TextBox
    Friend WithEvents labDCpacientesReferidasPorReferidor As System.Windows.Forms.Label
    Friend WithEvents LabNombreSeleccionado4 As System.Windows.Forms.Label
    Friend WithEvents LabNombreSeleccionado3 As System.Windows.Forms.Label
    Friend WithEvents radBASEpacientesReferidasPorPtes As System.Windows.Forms.RadioButton
    Friend WithEvents radBASEpacientesReferidoras As System.Windows.Forms.RadioButton
    Friend WithEvents radBASEtodasLasPacientes As System.Windows.Forms.RadioButton
    Friend WithEvents labMensajedeAgenda As System.Windows.Forms.Label
    Friend WithEvents labEncabezado As System.Windows.Forms.Label
    Friend WithEvents radBASEControlObs As System.Windows.Forms.RadioButton
    Friend WithEvents radBASEembarazadas As System.Windows.Forms.RadioButton
    Friend WithEvents radBASEReferidasPorOtros As System.Windows.Forms.RadioButton
    Friend WithEvents radBASEptesDeOtrosMedicos As System.Windows.Forms.RadioButton
    Friend WithEvents radBASEacudieronExpontaneamente As System.Windows.Forms.RadioButton
    Friend WithEvents radBASEconConsultaPendiente As System.Windows.Forms.RadioButton
    Friend WithEvents txtBASEnotificaciones As System.Windows.Forms.TextBox
    Friend WithEvents radBASEseDesconoceReferencia As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents radBASEconConsultaPendienteProxMes As System.Windows.Forms.RadioButton
    Friend WithEvents txtBASEresumenPte As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAgendaPagador As System.Windows.Forms.TextBox
    Friend WithEvents labDCproximaConsulta As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtAgendaBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtAgendaReferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtAgendaFormaDePago As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAgendaFechaDeCancelacion As System.Windows.Forms.TextBox
    Friend WithEvents txtAgendaEstatusCancelacion As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents labDCdireccion As System.Windows.Forms.Label
    Friend WithEvents labDCVinculoDeLaPteConElReferidor As Label
    Friend WithEvents labDCVinculoDeLaPteConElReferidorTitulo As Label
    Friend WithEvents menuCalculoEGconBiometria As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.txtBASEresumenPte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radBASEconConsultaPendienteProxMes = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radBASEseDesconoceReferencia = New System.Windows.Forms.RadioButton()
        Me.txtBASEnotificaciones = New System.Windows.Forms.TextBox()
        Me.radBASEconConsultaPendiente = New System.Windows.Forms.RadioButton()
        Me.radBASEacudieronExpontaneamente = New System.Windows.Forms.RadioButton()
        Me.radBASEptesDeOtrosMedicos = New System.Windows.Forms.RadioButton()
        Me.radBASEReferidasPorOtros = New System.Windows.Forms.RadioButton()
        Me.radBASEembarazadas = New System.Windows.Forms.RadioButton()
        Me.radBASEControlObs = New System.Windows.Forms.RadioButton()
        Me.labEncabezado = New System.Windows.Forms.Label()
        Me.radBASEpacientesReferidasPorPtes = New System.Windows.Forms.RadioButton()
        Me.radBASEpacientesReferidoras = New System.Windows.Forms.RadioButton()
        Me.radBASEtodasLasPacientes = New System.Windows.Forms.RadioButton()
        Me.botPagos = New System.Windows.Forms.Button()
        Me.LabelFiltro = New System.Windows.Forms.Label()
        Me.botIntervenciones = New System.Windows.Forms.Button()
        Me.LabMensajeBaseDatos = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.botGuardias = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabNombreSeleccionado = New System.Windows.Forms.Label()
        Me.botCerrarHistoria = New System.Windows.Forms.Button()
        Me.botRenombraHistoria = New System.Windows.Forms.Button()
        Me.labMensajedeAgenda = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.botAbrirHistoria = New System.Windows.Forms.Button()
        Me.LabCedulaSeleccionada = New System.Windows.Forms.Label()
        Me.BotNuevaHistoria = New System.Windows.Forms.Button()
        Me.LabNumeroSeleccionado = New System.Windows.Forms.Label()
        Me.ListBoxHistorias = New System.Windows.Forms.ListBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelAniversarios = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ListBoxCS = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBoxCH = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.PanelEtarios = New System.Windows.Forms.Panel()
        Me.radEdadSinDatos = New System.Windows.Forms.RadioButton()
        Me.ListBoxEdades = New System.Windows.Forms.ListBox()
        Me.labPacientesGrupoEtario = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.radEdadChamas = New System.Windows.Forms.RadioButton()
        Me.radEdadViejas = New System.Windows.Forms.RadioButton()
        Me.radEdadMujeres = New System.Windows.Forms.RadioButton()
        Me.radEdadMILF = New System.Windows.Forms.RadioButton()
        Me.LabNombreBaseDatos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtHistoriaNotificaciones = New System.Windows.Forms.TextBox()
        Me.TabControlNotas = New System.Windows.Forms.TabControl()
        Me.TabPageResumen = New System.Windows.Forms.TabPage()
        Me.labDCVinculoDeLaPteConElReferidor = New System.Windows.Forms.Label()
        Me.labDCVinculoDeLaPteConElReferidorTitulo = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.labDCdireccion = New System.Windows.Forms.Label()
        Me.labDCproximaConsulta = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDCpacientesReferidasPorReferidor = New System.Windows.Forms.TextBox()
        Me.labDCpacientesReferidasPorReferidor = New System.Windows.Forms.Label()
        Me.LabNombreSeleccionado4 = New System.Windows.Forms.Label()
        Me.LabNombreSeleccionado3 = New System.Windows.Forms.Label()
        Me.labDCReferidaPor = New System.Windows.Forms.Label()
        Me.labDCPromedioPorConsulta = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDCFamiliatrabajo = New System.Windows.Forms.TextBox()
        Me.labDCnumeroConsultas = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDCultimoSMS = New System.Windows.Forms.TextBox()
        Me.txtDCReferencias = New System.Windows.Forms.TextBox()
        Me.labDCHonorariosTotales = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.labDCLugar1raConsulta = New System.Windows.Forms.Label()
        Me.Label16b = New System.Windows.Forms.Label()
        Me.txtDCnotas = New System.Windows.Forms.TextBox()
        Me.labDCTelefonoVerificado = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.labDCLugarUltimaConsulta = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.labDCultimaConsulta = New System.Windows.Forms.Label()
        Me.labDCfechaDeNacimiento = New System.Windows.Forms.Label()
        Me.labDCedadActual = New System.Windows.Forms.Label()
        Me.labDCprofesion = New System.Windows.Forms.Label()
        Me.labDCpacienteDesde = New System.Windows.Forms.Label()
        Me.labDCparidad = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.labDCtelefono = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabPageConsultas = New System.Windows.Forms.TabPage()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtAgendaBanco = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtAgendaReferencia = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtAgendaFormaDePago = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtAgendaFechaDeCancelacion = New System.Windows.Forms.TextBox()
        Me.txtAgendaEstatusCancelacion = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAgendaPagador = New System.Windows.Forms.TextBox()
        Me.labCalendarioConsultaOtroDia = New System.Windows.Forms.Label()
        Me.CalendarioConsultaOtraDia = New System.Windows.Forms.MonthCalendar()
        Me.txtAgendaFactura = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.labConsultasArchivadas = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtAgendaManual = New System.Windows.Forms.TextBox()
        Me.txtAgendaAuto = New System.Windows.Forms.TextBox()
        Me.txtAgendaProximaConsulta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botConsultaOtroDiaAccion = New System.Windows.Forms.Button()
        Me.botEliminarConsulta = New System.Windows.Forms.Button()
        Me.botEditarConsulta = New System.Windows.Forms.Button()
        Me.botConsultaOtroDia = New System.Windows.Forms.Button()
        Me.botConsultaHoy = New System.Windows.Forms.Button()
        Me.ListBoxConsultas = New System.Windows.Forms.ListBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.txtAgendaLugarConsulta = New System.Windows.Forms.TextBox()
        Me.txtAgendaTratamiento = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.txtAgendaHonorarios = New System.Windows.Forms.TextBox()
        Me.txtAgendaPendiente = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.LabHistoriaAbierta = New System.Windows.Forms.Label()
        Me.BotControlGinecologico = New System.Windows.Forms.Button()
        Me.botCerrarHistoria2 = New System.Windows.Forms.Button()
        Me.botNuevoEco = New System.Windows.Forms.Button()
        Me.botNuevaHistoriaObstetrica = New System.Windows.Forms.Button()
        Me.botDatosPersonales = New System.Windows.Forms.Button()
        Me.ListBoxContenido = New System.Windows.Forms.ListBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuBasedeDatos = New System.Windows.Forms.MenuItem()
        Me.MenuAbreBase = New System.Windows.Forms.MenuItem()
        Me.MenuCreaBase = New System.Windows.Forms.MenuItem()
        Me.MenuDatosDelUsuario = New System.Windows.Forms.MenuItem()
        Me.MenuItemAgenda = New System.Windows.Forms.MenuItem()
        Me.MenuItemVademecum = New System.Windows.Forms.MenuItem()
        Me.MenuItemRecipes = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuCalculoEGconECO = New System.Windows.Forms.MenuItem()
        Me.menuCalculoEGconFUR = New System.Windows.Forms.MenuItem()
        Me.menuCalculoDCconFUR = New System.Windows.Forms.MenuItem()
        Me.menuCalculoEGconBiometria = New System.Windows.Forms.MenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BaseDatosIndiceHistoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAniversarios.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.PanelEtarios.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControlNotas.SuspendLayout()
        Me.TabPageResumen.SuspendLayout()
        Me.TabPageConsultas.SuspendLayout()
        CType(Me.BaseDatosIndiceHistoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(990, 660)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.TabControl2)
        Me.TabPage4.Controls.Add(Me.LabNombreBaseDatos)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(982, 634)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Base de Datos"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(5, 46)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(974, 575)
        Me.TabControl2.TabIndex = 46
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage6.Controls.Add(Me.txtBASEresumenPte)
        Me.TabPage6.Controls.Add(Me.Label5)
        Me.TabPage6.Controls.Add(Me.radBASEconConsultaPendienteProxMes)
        Me.TabPage6.Controls.Add(Me.Label4)
        Me.TabPage6.Controls.Add(Me.radBASEseDesconoceReferencia)
        Me.TabPage6.Controls.Add(Me.txtBASEnotificaciones)
        Me.TabPage6.Controls.Add(Me.radBASEconConsultaPendiente)
        Me.TabPage6.Controls.Add(Me.radBASEacudieronExpontaneamente)
        Me.TabPage6.Controls.Add(Me.radBASEptesDeOtrosMedicos)
        Me.TabPage6.Controls.Add(Me.radBASEReferidasPorOtros)
        Me.TabPage6.Controls.Add(Me.radBASEembarazadas)
        Me.TabPage6.Controls.Add(Me.radBASEControlObs)
        Me.TabPage6.Controls.Add(Me.labEncabezado)
        Me.TabPage6.Controls.Add(Me.radBASEpacientesReferidasPorPtes)
        Me.TabPage6.Controls.Add(Me.radBASEpacientesReferidoras)
        Me.TabPage6.Controls.Add(Me.radBASEtodasLasPacientes)
        Me.TabPage6.Controls.Add(Me.botPagos)
        Me.TabPage6.Controls.Add(Me.LabelFiltro)
        Me.TabPage6.Controls.Add(Me.botIntervenciones)
        Me.TabPage6.Controls.Add(Me.LabMensajeBaseDatos)
        Me.TabPage6.Controls.Add(Me.PictureBox1)
        Me.TabPage6.Controls.Add(Me.botGuardias)
        Me.TabPage6.Controls.Add(Me.Label3)
        Me.TabPage6.Controls.Add(Me.LabNombreSeleccionado)
        Me.TabPage6.Controls.Add(Me.botCerrarHistoria)
        Me.TabPage6.Controls.Add(Me.botRenombraHistoria)
        Me.TabPage6.Controls.Add(Me.labMensajedeAgenda)
        Me.TabPage6.Controls.Add(Me.txtFiltro)
        Me.TabPage6.Controls.Add(Me.botAbrirHistoria)
        Me.TabPage6.Controls.Add(Me.LabCedulaSeleccionada)
        Me.TabPage6.Controls.Add(Me.BotNuevaHistoria)
        Me.TabPage6.Controls.Add(Me.LabNumeroSeleccionado)
        Me.TabPage6.Controls.Add(Me.ListBoxHistorias)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(966, 549)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Listado de Pacientes"
        '
        'txtBASEresumenPte
        '
        Me.txtBASEresumenPte.BackColor = System.Drawing.SystemColors.Info
        Me.txtBASEresumenPte.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBASEresumenPte.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtBASEresumenPte.Location = New System.Drawing.Point(701, 250)
        Me.txtBASEresumenPte.MaxLength = 3000
        Me.txtBASEresumenPte.Multiline = True
        Me.txtBASEresumenPte.Name = "txtBASEresumenPte"
        Me.txtBASEresumenPte.ReadOnly = True
        Me.txtBASEresumenPte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBASEresumenPte.Size = New System.Drawing.Size(259, 296)
        Me.txtBASEresumenPte.TabIndex = 66
        Me.ToolTip1.SetToolTip(Me.txtBASEresumenPte, "Doble Cilck Selecciona Referidas")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(701, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(259, 20)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "RESUMEN DE Pte SELECCIONADA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radBASEconConsultaPendienteProxMes
        '
        Me.radBASEconConsultaPendienteProxMes.AutoSize = True
        Me.radBASEconConsultaPendienteProxMes.Location = New System.Drawing.Point(574, 46)
        Me.radBASEconConsultaPendienteProxMes.Name = "radBASEconConsultaPendienteProxMes"
        Me.radBASEconConsultaPendienteProxMes.Size = New System.Drawing.Size(251, 17)
        Me.radBASEconConsultaPendienteProxMes.TabIndex = 64
        Me.radBASEconConsultaPendienteProxMes.Text = "Pacientes con Consulta Pendiente Proximo Mes"
        Me.radBASEconConsultaPendienteProxMes.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label4.Location = New System.Drawing.Point(701, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 20)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Notificaciones Generales de la Base de Datos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radBASEseDesconoceReferencia
        '
        Me.radBASEseDesconoceReferencia.AutoSize = True
        Me.radBASEseDesconoceReferencia.Location = New System.Drawing.Point(574, 6)
        Me.radBASEseDesconoceReferencia.Name = "radBASEseDesconoceReferencia"
        Me.radBASEseDesconoceReferencia.Size = New System.Drawing.Size(165, 17)
        Me.radBASEseDesconoceReferencia.TabIndex = 62
        Me.radBASEseDesconoceReferencia.Text = "Se Desconoce su Referencia"
        Me.radBASEseDesconoceReferencia.UseVisualStyleBackColor = True
        '
        'txtBASEnotificaciones
        '
        Me.txtBASEnotificaciones.BackColor = System.Drawing.SystemColors.Info
        Me.txtBASEnotificaciones.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBASEnotificaciones.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtBASEnotificaciones.Location = New System.Drawing.Point(701, 92)
        Me.txtBASEnotificaciones.MaxLength = 3000
        Me.txtBASEnotificaciones.Multiline = True
        Me.txtBASEnotificaciones.Name = "txtBASEnotificaciones"
        Me.txtBASEnotificaciones.ReadOnly = True
        Me.txtBASEnotificaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBASEnotificaciones.Size = New System.Drawing.Size(259, 129)
        Me.txtBASEnotificaciones.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.txtBASEnotificaciones, "Doble Cilck para editar...")
        '
        'radBASEconConsultaPendiente
        '
        Me.radBASEconConsultaPendiente.AutoSize = True
        Me.radBASEconConsultaPendiente.Location = New System.Drawing.Point(377, 46)
        Me.radBASEconConsultaPendiente.Name = "radBASEconConsultaPendiente"
        Me.radBASEconConsultaPendiente.Size = New System.Drawing.Size(188, 17)
        Me.radBASEconConsultaPendiente.TabIndex = 60
        Me.radBASEconConsultaPendiente.Text = "Pacientes con Consulta Pendiente"
        Me.radBASEconConsultaPendiente.UseVisualStyleBackColor = True
        '
        'radBASEacudieronExpontaneamente
        '
        Me.radBASEacudieronExpontaneamente.AutoSize = True
        Me.radBASEacudieronExpontaneamente.Location = New System.Drawing.Point(176, 46)
        Me.radBASEacudieronExpontaneamente.Name = "radBASEacudieronExpontaneamente"
        Me.radBASEacudieronExpontaneamente.Size = New System.Drawing.Size(162, 17)
        Me.radBASEacudieronExpontaneamente.TabIndex = 59
        Me.radBASEacudieronExpontaneamente.Text = "Acudieron Expontáneamente"
        Me.radBASEacudieronExpontaneamente.UseVisualStyleBackColor = True
        '
        'radBASEptesDeOtrosMedicos
        '
        Me.radBASEptesDeOtrosMedicos.AutoSize = True
        Me.radBASEptesDeOtrosMedicos.Location = New System.Drawing.Point(176, 26)
        Me.radBASEptesDeOtrosMedicos.Name = "radBASEptesDeOtrosMedicos"
        Me.radBASEptesDeOtrosMedicos.Size = New System.Drawing.Size(158, 17)
        Me.radBASEptesDeOtrosMedicos.TabIndex = 58
        Me.radBASEptesDeOtrosMedicos.Text = "Pacientes de Otros Médicos"
        Me.radBASEptesDeOtrosMedicos.UseVisualStyleBackColor = True
        '
        'radBASEReferidasPorOtros
        '
        Me.radBASEReferidasPorOtros.AutoSize = True
        Me.radBASEReferidasPorOtros.Location = New System.Drawing.Point(176, 6)
        Me.radBASEReferidasPorOtros.Name = "radBASEReferidasPorOtros"
        Me.radBASEReferidasPorOtros.Size = New System.Drawing.Size(156, 17)
        Me.radBASEReferidasPorOtros.TabIndex = 57
        Me.radBASEReferidasPorOtros.Text = "Pacientes Referidas x Otros"
        Me.radBASEReferidasPorOtros.UseVisualStyleBackColor = True
        '
        'radBASEembarazadas
        '
        Me.radBASEembarazadas.AutoSize = True
        Me.radBASEembarazadas.Location = New System.Drawing.Point(377, 26)
        Me.radBASEembarazadas.Name = "radBASEembarazadas"
        Me.radBASEembarazadas.Size = New System.Drawing.Size(139, 17)
        Me.radBASEembarazadas.TabIndex = 56
        Me.radBASEembarazadas.Text = "Pacientes Embarazadas"
        Me.radBASEembarazadas.UseVisualStyleBackColor = True
        '
        'radBASEControlObs
        '
        Me.radBASEControlObs.AutoSize = True
        Me.radBASEControlObs.Location = New System.Drawing.Point(377, 6)
        Me.radBASEControlObs.Name = "radBASEControlObs"
        Me.radBASEControlObs.Size = New System.Drawing.Size(154, 17)
        Me.radBASEControlObs.TabIndex = 55
        Me.radBASEControlObs.Text = "Pacientes con Control Obs."
        Me.radBASEControlObs.UseVisualStyleBackColor = True
        '
        'labEncabezado
        '
        Me.labEncabezado.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.labEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labEncabezado.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEncabezado.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEncabezado.Location = New System.Drawing.Point(2, 126)
        Me.labEncabezado.Name = "labEncabezado"
        Me.labEncabezado.Size = New System.Drawing.Size(583, 20)
        Me.labEncabezado.TabIndex = 54
        Me.labEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'radBASEpacientesReferidasPorPtes
        '
        Me.radBASEpacientesReferidasPorPtes.AutoSize = True
        Me.radBASEpacientesReferidasPorPtes.Location = New System.Drawing.Point(6, 46)
        Me.radBASEpacientesReferidasPorPtes.Name = "radBASEpacientesReferidasPorPtes"
        Me.radBASEpacientesReferidasPorPtes.Size = New System.Drawing.Size(152, 17)
        Me.radBASEpacientesReferidasPorPtes.TabIndex = 50
        Me.radBASEpacientesReferidasPorPtes.Text = "Pacientes Referidas x Ptes"
        Me.radBASEpacientesReferidasPorPtes.UseVisualStyleBackColor = True
        '
        'radBASEpacientesReferidoras
        '
        Me.radBASEpacientesReferidoras.AutoSize = True
        Me.radBASEpacientesReferidoras.Location = New System.Drawing.Point(6, 26)
        Me.radBASEpacientesReferidoras.Name = "radBASEpacientesReferidoras"
        Me.radBASEpacientesReferidoras.Size = New System.Drawing.Size(129, 17)
        Me.radBASEpacientesReferidoras.TabIndex = 49
        Me.radBASEpacientesReferidoras.Text = "Pacientes Referidoras"
        Me.radBASEpacientesReferidoras.UseVisualStyleBackColor = True
        '
        'radBASEtodasLasPacientes
        '
        Me.radBASEtodasLasPacientes.AutoSize = True
        Me.radBASEtodasLasPacientes.Checked = True
        Me.radBASEtodasLasPacientes.Location = New System.Drawing.Point(6, 6)
        Me.radBASEtodasLasPacientes.Name = "radBASEtodasLasPacientes"
        Me.radBASEtodasLasPacientes.Size = New System.Drawing.Size(121, 17)
        Me.radBASEtodasLasPacientes.TabIndex = 48
        Me.radBASEtodasLasPacientes.TabStop = True
        Me.radBASEtodasLasPacientes.Text = "Todas las Pacientes"
        Me.radBASEtodasLasPacientes.UseVisualStyleBackColor = True
        '
        'botPagos
        '
        Me.botPagos.BackColor = System.Drawing.SystemColors.Control
        Me.botPagos.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botPagos.Enabled = False
        Me.botPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botPagos.ForeColor = System.Drawing.Color.Black
        Me.botPagos.Location = New System.Drawing.Point(591, 126)
        Me.botPagos.Name = "botPagos"
        Me.botPagos.Size = New System.Drawing.Size(104, 23)
        Me.botPagos.TabIndex = 46
        Me.botPagos.Text = "Pagos"
        Me.botPagos.UseVisualStyleBackColor = False
        '
        'LabelFiltro
        '
        Me.LabelFiltro.BackColor = System.Drawing.SystemColors.Info
        Me.LabelFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFiltro.ForeColor = System.Drawing.SystemColors.InfoText
        Me.LabelFiltro.Location = New System.Drawing.Point(2, 93)
        Me.LabelFiltro.Name = "LabelFiltro"
        Me.LabelFiltro.Size = New System.Drawing.Size(583, 20)
        Me.LabelFiltro.TabIndex = 29
        Me.LabelFiltro.Text = "Todos los Pacientes de la Base de Datos = 0  Pacientes"
        Me.LabelFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botIntervenciones
        '
        Me.botIntervenciones.BackColor = System.Drawing.SystemColors.Control
        Me.botIntervenciones.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botIntervenciones.Enabled = False
        Me.botIntervenciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botIntervenciones.ForeColor = System.Drawing.Color.Black
        Me.botIntervenciones.Location = New System.Drawing.Point(591, 155)
        Me.botIntervenciones.Name = "botIntervenciones"
        Me.botIntervenciones.Size = New System.Drawing.Size(104, 23)
        Me.botIntervenciones.TabIndex = 45
        Me.botIntervenciones.Text = "Intervenciones"
        Me.botIntervenciones.UseVisualStyleBackColor = False
        '
        'LabMensajeBaseDatos
        '
        Me.LabMensajeBaseDatos.BackColor = System.Drawing.SystemColors.Control
        Me.LabMensajeBaseDatos.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMensajeBaseDatos.ForeColor = System.Drawing.Color.Black
        Me.LabMensajeBaseDatos.Image = Global.Historias.My.Resources.Resources.BarraMensajeMal
        Me.LabMensajeBaseDatos.Location = New System.Drawing.Point(3, 523)
        Me.LabMensajeBaseDatos.Name = "LabMensajeBaseDatos"
        Me.LabMensajeBaseDatos.Size = New System.Drawing.Size(582, 23)
        Me.LabMensajeBaseDatos.TabIndex = 11
        Me.LabMensajeBaseDatos.Text = "Primero Abre o Crea una Base de Datos..."
        Me.LabMensajeBaseDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Historias.My.Resources.Resources.fotoForm1
        Me.PictureBox1.Location = New System.Drawing.Point(591, 374)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'botGuardias
        '
        Me.botGuardias.BackColor = System.Drawing.SystemColors.Control
        Me.botGuardias.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botGuardias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botGuardias.ForeColor = System.Drawing.Color.Black
        Me.botGuardias.Location = New System.Drawing.Point(591, 300)
        Me.botGuardias.Name = "botGuardias"
        Me.botGuardias.Size = New System.Drawing.Size(104, 23)
        Me.botGuardias.TabIndex = 25
        Me.botGuardias.Text = "Eventos"
        Me.botGuardias.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Filtro :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabNombreSeleccionado
        '
        Me.LabNombreSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabNombreSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabNombreSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNombreSeleccionado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabNombreSeleccionado.Location = New System.Drawing.Point(205, 464)
        Me.LabNombreSeleccionado.Name = "LabNombreSeleccionado"
        Me.LabNombreSeleccionado.Size = New System.Drawing.Size(380, 24)
        Me.LabNombreSeleccionado.TabIndex = 44
        Me.LabNombreSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botCerrarHistoria
        '
        Me.botCerrarHistoria.BackColor = System.Drawing.SystemColors.Control
        Me.botCerrarHistoria.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botCerrarHistoria.Enabled = False
        Me.botCerrarHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCerrarHistoria.ForeColor = System.Drawing.Color.Black
        Me.botCerrarHistoria.Location = New System.Drawing.Point(591, 271)
        Me.botCerrarHistoria.Name = "botCerrarHistoria"
        Me.botCerrarHistoria.Size = New System.Drawing.Size(104, 23)
        Me.botCerrarHistoria.TabIndex = 16
        Me.botCerrarHistoria.Text = "Cerrar Historia"
        Me.botCerrarHistoria.UseVisualStyleBackColor = False
        '
        'botRenombraHistoria
        '
        Me.botRenombraHistoria.BackColor = System.Drawing.SystemColors.Control
        Me.botRenombraHistoria.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botRenombraHistoria.Enabled = False
        Me.botRenombraHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRenombraHistoria.ForeColor = System.Drawing.Color.Black
        Me.botRenombraHistoria.Location = New System.Drawing.Point(591, 242)
        Me.botRenombraHistoria.Name = "botRenombraHistoria"
        Me.botRenombraHistoria.Size = New System.Drawing.Size(104, 23)
        Me.botRenombraHistoria.TabIndex = 22
        Me.botRenombraHistoria.Text = "Renombrar Pte"
        Me.botRenombraHistoria.UseVisualStyleBackColor = False
        '
        'labMensajedeAgenda
        '
        Me.labMensajedeAgenda.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.labMensajedeAgenda.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labMensajedeAgenda.ForeColor = System.Drawing.Color.Black
        Me.labMensajedeAgenda.Image = Global.Historias.My.Resources.Resources.BarraSinMensaje
        Me.labMensajedeAgenda.Location = New System.Drawing.Point(3, 493)
        Me.labMensajedeAgenda.Name = "labMensajedeAgenda"
        Me.labMensajedeAgenda.Size = New System.Drawing.Size(582, 23)
        Me.labMensajedeAgenda.TabIndex = 30
        Me.labMensajedeAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(47, 70)
        Me.txtFiltro.MaxLength = 45
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(538, 20)
        Me.txtFiltro.TabIndex = 27
        '
        'botAbrirHistoria
        '
        Me.botAbrirHistoria.BackColor = System.Drawing.SystemColors.Control
        Me.botAbrirHistoria.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botAbrirHistoria.Enabled = False
        Me.botAbrirHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAbrirHistoria.ForeColor = System.Drawing.Color.Black
        Me.botAbrirHistoria.Location = New System.Drawing.Point(591, 213)
        Me.botAbrirHistoria.Name = "botAbrirHistoria"
        Me.botAbrirHistoria.Size = New System.Drawing.Size(104, 23)
        Me.botAbrirHistoria.TabIndex = 12
        Me.botAbrirHistoria.Text = "Abrir Historia"
        Me.botAbrirHistoria.UseVisualStyleBackColor = False
        '
        'LabCedulaSeleccionada
        '
        Me.LabCedulaSeleccionada.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabCedulaSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabCedulaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCedulaSeleccionada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabCedulaSeleccionada.Location = New System.Drawing.Point(121, 464)
        Me.LabCedulaSeleccionada.Name = "LabCedulaSeleccionada"
        Me.LabCedulaSeleccionada.Size = New System.Drawing.Size(82, 24)
        Me.LabCedulaSeleccionada.TabIndex = 43
        Me.LabCedulaSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BotNuevaHistoria
        '
        Me.BotNuevaHistoria.BackColor = System.Drawing.SystemColors.Control
        Me.BotNuevaHistoria.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.BotNuevaHistoria.Enabled = False
        Me.BotNuevaHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotNuevaHistoria.ForeColor = System.Drawing.Color.Black
        Me.BotNuevaHistoria.Location = New System.Drawing.Point(591, 184)
        Me.BotNuevaHistoria.Name = "BotNuevaHistoria"
        Me.BotNuevaHistoria.Size = New System.Drawing.Size(104, 23)
        Me.BotNuevaHistoria.TabIndex = 7
        Me.BotNuevaHistoria.Text = "Nueva Historia"
        Me.BotNuevaHistoria.UseVisualStyleBackColor = False
        '
        'LabNumeroSeleccionado
        '
        Me.LabNumeroSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabNumeroSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabNumeroSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNumeroSeleccionado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabNumeroSeleccionado.Location = New System.Drawing.Point(2, 464)
        Me.LabNumeroSeleccionado.Name = "LabNumeroSeleccionado"
        Me.LabNumeroSeleccionado.Size = New System.Drawing.Size(117, 24)
        Me.LabNumeroSeleccionado.TabIndex = 42
        Me.LabNumeroSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBoxHistorias
        '
        Me.ListBoxHistorias.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxHistorias.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxHistorias.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxHistorias.ItemHeight = 9
        Me.ListBoxHistorias.Location = New System.Drawing.Point(2, 149)
        Me.ListBoxHistorias.Name = "ListBoxHistorias"
        Me.ListBoxHistorias.Size = New System.Drawing.Size(583, 310)
        Me.ListBoxHistorias.TabIndex = 6
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage7.Controls.Add(Me.PictureBox2)
        Me.TabPage7.Controls.Add(Me.PanelAniversarios)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(966, 549)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Aniversarios"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Historias.My.Resources.Resources.Aniversario
        Me.PictureBox2.Location = New System.Drawing.Point(625, 212)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PanelAniversarios
        '
        Me.PanelAniversarios.Controls.Add(Me.Label15)
        Me.PanelAniversarios.Controls.Add(Me.ListBoxCS)
        Me.PanelAniversarios.Controls.Add(Me.Label12)
        Me.PanelAniversarios.Controls.Add(Me.ListBoxCH)
        Me.PanelAniversarios.Location = New System.Drawing.Point(6, 6)
        Me.PanelAniversarios.Name = "PanelAniversarios"
        Me.PanelAniversarios.Size = New System.Drawing.Size(609, 367)
        Me.PanelAniversarios.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(180, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Cumpleañeras de los proximos 7 dias"
        '
        'ListBoxCS
        '
        Me.ListBoxCS.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxCS.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxCS.FormattingEnabled = True
        Me.ListBoxCS.ItemHeight = 11
        Me.ListBoxCS.Location = New System.Drawing.Point(6, 105)
        Me.ListBoxCS.Name = "ListBoxCS"
        Me.ListBoxCS.Size = New System.Drawing.Size(600, 246)
        Me.ListBoxCS.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Cumpleañeras de hoy"
        '
        'ListBoxCH
        '
        Me.ListBoxCH.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxCH.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxCH.FormattingEnabled = True
        Me.ListBoxCH.ItemHeight = 11
        Me.ListBoxCH.Location = New System.Drawing.Point(3, 21)
        Me.ListBoxCH.Name = "ListBoxCH"
        Me.ListBoxCH.Size = New System.Drawing.Size(603, 48)
        Me.ListBoxCH.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.PanelEtarios)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(966, 549)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Grupos Etarios de la Base"
        '
        'PanelEtarios
        '
        Me.PanelEtarios.Controls.Add(Me.radEdadSinDatos)
        Me.PanelEtarios.Controls.Add(Me.ListBoxEdades)
        Me.PanelEtarios.Controls.Add(Me.labPacientesGrupoEtario)
        Me.PanelEtarios.Controls.Add(Me.Label17)
        Me.PanelEtarios.Controls.Add(Me.Label22)
        Me.PanelEtarios.Controls.Add(Me.radEdadChamas)
        Me.PanelEtarios.Controls.Add(Me.radEdadViejas)
        Me.PanelEtarios.Controls.Add(Me.radEdadMujeres)
        Me.PanelEtarios.Controls.Add(Me.radEdadMILF)
        Me.PanelEtarios.Location = New System.Drawing.Point(3, 3)
        Me.PanelEtarios.Name = "PanelEtarios"
        Me.PanelEtarios.Size = New System.Drawing.Size(613, 373)
        Me.PanelEtarios.TabIndex = 6
        '
        'radEdadSinDatos
        '
        Me.radEdadSinDatos.AutoSize = True
        Me.radEdadSinDatos.Location = New System.Drawing.Point(418, 25)
        Me.radEdadSinDatos.Name = "radEdadSinDatos"
        Me.radEdadSinDatos.Size = New System.Drawing.Size(71, 17)
        Me.radEdadSinDatos.TabIndex = 8
        Me.radEdadSinDatos.TabStop = True
        Me.radEdadSinDatos.Text = "Sin Datos"
        Me.radEdadSinDatos.UseVisualStyleBackColor = True
        '
        'ListBoxEdades
        '
        Me.ListBoxEdades.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxEdades.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEdades.FormattingEnabled = True
        Me.ListBoxEdades.ItemHeight = 11
        Me.ListBoxEdades.Location = New System.Drawing.Point(8, 84)
        Me.ListBoxEdades.Name = "ListBoxEdades"
        Me.ListBoxEdades.Size = New System.Drawing.Size(600, 268)
        Me.ListBoxEdades.TabIndex = 7
        '
        'labPacientesGrupoEtario
        '
        Me.labPacientesGrupoEtario.BackColor = System.Drawing.SystemColors.Info
        Me.labPacientesGrupoEtario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labPacientesGrupoEtario.Location = New System.Drawing.Point(241, 52)
        Me.labPacientesGrupoEtario.Name = "labPacientesGrupoEtario"
        Me.labPacientesGrupoEtario.Size = New System.Drawing.Size(44, 20)
        Me.labPacientesGrupoEtario.TabIndex = 6
        Me.labPacientesGrupoEtario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Selecciona Grupo Etario"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(5, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(230, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Número de pacientes del grupo seleccionado:"
        '
        'radEdadChamas
        '
        Me.radEdadChamas.AutoSize = True
        Me.radEdadChamas.Location = New System.Drawing.Point(6, 25)
        Me.radEdadChamas.Name = "radEdadChamas"
        Me.radEdadChamas.Size = New System.Drawing.Size(95, 17)
        Me.radEdadChamas.TabIndex = 1
        Me.radEdadChamas.TabStop = True
        Me.radEdadChamas.Text = "de 19 ó menos"
        Me.radEdadChamas.UseVisualStyleBackColor = True
        '
        'radEdadViejas
        '
        Me.radEdadViejas.AutoSize = True
        Me.radEdadViejas.Location = New System.Drawing.Point(325, 25)
        Me.radEdadViejas.Name = "radEdadViejas"
        Me.radEdadViejas.Size = New System.Drawing.Size(83, 17)
        Me.radEdadViejas.TabIndex = 4
        Me.radEdadViejas.TabStop = True
        Me.radEdadViejas.Text = "de 40 ó más"
        Me.radEdadViejas.UseVisualStyleBackColor = True
        '
        'radEdadMujeres
        '
        Me.radEdadMujeres.AutoSize = True
        Me.radEdadMujeres.Location = New System.Drawing.Point(108, 25)
        Me.radEdadMujeres.Name = "radEdadMujeres"
        Me.radEdadMujeres.Size = New System.Drawing.Size(102, 17)
        Me.radEdadMujeres.TabIndex = 2
        Me.radEdadMujeres.TabStop = True
        Me.radEdadMujeres.Text = "de 20 a 29 años"
        Me.radEdadMujeres.UseVisualStyleBackColor = True
        '
        'radEdadMILF
        '
        Me.radEdadMILF.AutoSize = True
        Me.radEdadMILF.Location = New System.Drawing.Point(216, 25)
        Me.radEdadMILF.Name = "radEdadMILF"
        Me.radEdadMILF.Size = New System.Drawing.Size(102, 17)
        Me.radEdadMILF.TabIndex = 3
        Me.radEdadMILF.TabStop = True
        Me.radEdadMILF.Text = "de 30 a 39 años"
        Me.radEdadMILF.UseVisualStyleBackColor = True
        '
        'LabNombreBaseDatos
        '
        Me.LabNombreBaseDatos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LabNombreBaseDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabNombreBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNombreBaseDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabNombreBaseDatos.Location = New System.Drawing.Point(8, 20)
        Me.LabNombreBaseDatos.Name = "LabNombreBaseDatos"
        Me.LabNombreBaseDatos.Size = New System.Drawing.Size(750, 20)
        Me.LabNombreBaseDatos.TabIndex = 38
        Me.LabNombreBaseDatos.Text = "Ninguna"
        Me.LabNombreBaseDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Base de Datos Actual"
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.txtHistoriaNotificaciones)
        Me.TabPage1.Controls.Add(Me.TabControlNotas)
        Me.TabPage1.Controls.Add(Me.LabHistoriaAbierta)
        Me.TabPage1.Controls.Add(Me.BotControlGinecologico)
        Me.TabPage1.Controls.Add(Me.botCerrarHistoria2)
        Me.TabPage1.Controls.Add(Me.botNuevoEco)
        Me.TabPage1.Controls.Add(Me.botNuevaHistoriaObstetrica)
        Me.TabPage1.Controls.Add(Me.botDatosPersonales)
        Me.TabPage1.Controls.Add(Me.ListBoxContenido)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(982, 634)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Historia Actual"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(8, 335)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(74, 13)
        Me.Label32.TabIndex = 59
        Me.Label32.Text = "Notificaciones"
        '
        'txtHistoriaNotificaciones
        '
        Me.txtHistoriaNotificaciones.BackColor = System.Drawing.SystemColors.Info
        Me.txtHistoriaNotificaciones.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtHistoriaNotificaciones.Location = New System.Drawing.Point(8, 352)
        Me.txtHistoriaNotificaciones.MaxLength = 3000
        Me.txtHistoriaNotificaciones.Multiline = True
        Me.txtHistoriaNotificaciones.Name = "txtHistoriaNotificaciones"
        Me.txtHistoriaNotificaciones.ReadOnly = True
        Me.txtHistoriaNotificaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHistoriaNotificaciones.Size = New System.Drawing.Size(224, 237)
        Me.txtHistoriaNotificaciones.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.txtHistoriaNotificaciones, "Doble Cilck para editar...")
        '
        'TabControlNotas
        '
        Me.TabControlNotas.Controls.Add(Me.TabPageResumen)
        Me.TabControlNotas.Controls.Add(Me.TabPageConsultas)
        Me.TabControlNotas.Location = New System.Drawing.Point(238, 34)
        Me.TabControlNotas.Name = "TabControlNotas"
        Me.TabControlNotas.SelectedIndex = 0
        Me.TabControlNotas.Size = New System.Drawing.Size(736, 584)
        Me.TabControlNotas.TabIndex = 51
        '
        'TabPageResumen
        '
        Me.TabPageResumen.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPageResumen.Controls.Add(Me.labDCVinculoDeLaPteConElReferidor)
        Me.TabPageResumen.Controls.Add(Me.labDCVinculoDeLaPteConElReferidorTitulo)
        Me.TabPageResumen.Controls.Add(Me.Label35)
        Me.TabPageResumen.Controls.Add(Me.labDCdireccion)
        Me.TabPageResumen.Controls.Add(Me.labDCproximaConsulta)
        Me.TabPageResumen.Controls.Add(Me.Label8)
        Me.TabPageResumen.Controls.Add(Me.txtDCpacientesReferidasPorReferidor)
        Me.TabPageResumen.Controls.Add(Me.labDCpacientesReferidasPorReferidor)
        Me.TabPageResumen.Controls.Add(Me.LabNombreSeleccionado4)
        Me.TabPageResumen.Controls.Add(Me.LabNombreSeleccionado3)
        Me.TabPageResumen.Controls.Add(Me.labDCReferidaPor)
        Me.TabPageResumen.Controls.Add(Me.labDCPromedioPorConsulta)
        Me.TabPageResumen.Controls.Add(Me.Label2)
        Me.TabPageResumen.Controls.Add(Me.txtDCFamiliatrabajo)
        Me.TabPageResumen.Controls.Add(Me.labDCnumeroConsultas)
        Me.TabPageResumen.Controls.Add(Me.Label26)
        Me.TabPageResumen.Controls.Add(Me.txtDCultimoSMS)
        Me.TabPageResumen.Controls.Add(Me.txtDCReferencias)
        Me.TabPageResumen.Controls.Add(Me.labDCHonorariosTotales)
        Me.TabPageResumen.Controls.Add(Me.Label16)
        Me.TabPageResumen.Controls.Add(Me.labDCLugar1raConsulta)
        Me.TabPageResumen.Controls.Add(Me.Label16b)
        Me.TabPageResumen.Controls.Add(Me.txtDCnotas)
        Me.TabPageResumen.Controls.Add(Me.labDCTelefonoVerificado)
        Me.TabPageResumen.Controls.Add(Me.Label27)
        Me.TabPageResumen.Controls.Add(Me.labDCLugarUltimaConsulta)
        Me.TabPageResumen.Controls.Add(Me.Label30)
        Me.TabPageResumen.Controls.Add(Me.Label25)
        Me.TabPageResumen.Controls.Add(Me.Label14)
        Me.TabPageResumen.Controls.Add(Me.Label18)
        Me.TabPageResumen.Controls.Add(Me.Label10)
        Me.TabPageResumen.Controls.Add(Me.Label9)
        Me.TabPageResumen.Controls.Add(Me.Label11)
        Me.TabPageResumen.Controls.Add(Me.Label13)
        Me.TabPageResumen.Controls.Add(Me.labDCultimaConsulta)
        Me.TabPageResumen.Controls.Add(Me.labDCfechaDeNacimiento)
        Me.TabPageResumen.Controls.Add(Me.labDCedadActual)
        Me.TabPageResumen.Controls.Add(Me.labDCprofesion)
        Me.TabPageResumen.Controls.Add(Me.labDCpacienteDesde)
        Me.TabPageResumen.Controls.Add(Me.labDCparidad)
        Me.TabPageResumen.Controls.Add(Me.Label19)
        Me.TabPageResumen.Controls.Add(Me.Label23)
        Me.TabPageResumen.Controls.Add(Me.labDCtelefono)
        Me.TabPageResumen.Controls.Add(Me.Label28)
        Me.TabPageResumen.Location = New System.Drawing.Point(4, 22)
        Me.TabPageResumen.Name = "TabPageResumen"
        Me.TabPageResumen.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageResumen.Size = New System.Drawing.Size(728, 558)
        Me.TabPageResumen.TabIndex = 1
        Me.TabPageResumen.Text = "Resumen de la Paciente"
        '
        'labDCVinculoDeLaPteConElReferidor
        '
        Me.labDCVinculoDeLaPteConElReferidor.BackColor = System.Drawing.SystemColors.Window
        Me.labDCVinculoDeLaPteConElReferidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCVinculoDeLaPteConElReferidor.Location = New System.Drawing.Point(416, 332)
        Me.labDCVinculoDeLaPteConElReferidor.Name = "labDCVinculoDeLaPteConElReferidor"
        Me.labDCVinculoDeLaPteConElReferidor.Size = New System.Drawing.Size(306, 16)
        Me.labDCVinculoDeLaPteConElReferidor.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.labDCVinculoDeLaPteConElReferidor, "Doble Cilck para editar...")
        '
        'labDCVinculoDeLaPteConElReferidorTitulo
        '
        Me.labDCVinculoDeLaPteConElReferidorTitulo.AutoSize = True
        Me.labDCVinculoDeLaPteConElReferidorTitulo.Location = New System.Drawing.Point(413, 317)
        Me.labDCVinculoDeLaPteConElReferidorTitulo.Name = "labDCVinculoDeLaPteConElReferidorTitulo"
        Me.labDCVinculoDeLaPteConElReferidorTitulo.Size = New System.Drawing.Size(142, 13)
        Me.labDCVinculoDeLaPteConElReferidorTitulo.TabIndex = 71
        Me.labDCVinculoDeLaPteConElReferidorTitulo.Text = "El Referidor es (??) de la Pte"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(50, 53)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(52, 13)
        Me.Label35.TabIndex = 69
        Me.Label35.Text = "Dirección"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labDCdireccion
        '
        Me.labDCdireccion.BackColor = System.Drawing.SystemColors.Info
        Me.labDCdireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCdireccion.Location = New System.Drawing.Point(108, 52)
        Me.labDCdireccion.Name = "labDCdireccion"
        Me.labDCdireccion.Size = New System.Drawing.Size(277, 16)
        Me.labDCdireccion.TabIndex = 70
        '
        'labDCproximaConsulta
        '
        Me.labDCproximaConsulta.BackColor = System.Drawing.SystemColors.Info
        Me.labDCproximaConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCproximaConsulta.Location = New System.Drawing.Point(110, 533)
        Me.labDCproximaConsulta.Name = "labDCproximaConsulta"
        Me.labDCproximaConsulta.Size = New System.Drawing.Size(116, 16)
        Me.labDCproximaConsulta.TabIndex = 68
        Me.labDCproximaConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 535)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Próxima Consulta"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDCpacientesReferidasPorReferidor
        '
        Me.txtDCpacientesReferidasPorReferidor.BackColor = System.Drawing.SystemColors.Info
        Me.txtDCpacientesReferidasPorReferidor.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtDCpacientesReferidasPorReferidor.Location = New System.Drawing.Point(416, 369)
        Me.txtDCpacientesReferidasPorReferidor.MaxLength = 3000
        Me.txtDCpacientesReferidasPorReferidor.Multiline = True
        Me.txtDCpacientesReferidasPorReferidor.Name = "txtDCpacientesReferidasPorReferidor"
        Me.txtDCpacientesReferidasPorReferidor.ReadOnly = True
        Me.txtDCpacientesReferidasPorReferidor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDCpacientesReferidasPorReferidor.Size = New System.Drawing.Size(306, 109)
        Me.txtDCpacientesReferidasPorReferidor.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.txtDCpacientesReferidasPorReferidor, "Se actualiza automaticamente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "al ir asociando Pacientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a su referidora")
        '
        'labDCpacientesReferidasPorReferidor
        '
        Me.labDCpacientesReferidasPorReferidor.AutoSize = True
        Me.labDCpacientesReferidasPorReferidor.Location = New System.Drawing.Point(413, 353)
        Me.labDCpacientesReferidasPorReferidor.Name = "labDCpacientesReferidasPorReferidor"
        Me.labDCpacientesReferidasPorReferidor.Size = New System.Drawing.Size(118, 13)
        Me.labDCpacientesReferidasPorReferidor.TabIndex = 62
        Me.labDCpacientesReferidasPorReferidor.Text = "Pacientes referidas por "
        '
        'LabNombreSeleccionado4
        '
        Me.LabNombreSeleccionado4.AutoSize = True
        Me.LabNombreSeleccionado4.Location = New System.Drawing.Point(108, 279)
        Me.LabNombreSeleccionado4.Name = "LabNombreSeleccionado4"
        Me.LabNombreSeleccionado4.Size = New System.Drawing.Size(66, 13)
        Me.LabNombreSeleccionado4.TabIndex = 61
        Me.LabNombreSeleccionado4.Text = "ha referido a"
        '
        'LabNombreSeleccionado3
        '
        Me.LabNombreSeleccionado3.AutoSize = True
        Me.LabNombreSeleccionado3.Location = New System.Drawing.Point(413, 279)
        Me.LabNombreSeleccionado3.Name = "LabNombreSeleccionado3"
        Me.LabNombreSeleccionado3.Size = New System.Drawing.Size(81, 13)
        Me.LabNombreSeleccionado3.TabIndex = 60
        Me.LabNombreSeleccionado3.Text = "fue referida  por"
        '
        'labDCReferidaPor
        '
        Me.labDCReferidaPor.BackColor = System.Drawing.SystemColors.Window
        Me.labDCReferidaPor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCReferidaPor.Location = New System.Drawing.Point(416, 295)
        Me.labDCReferidaPor.Name = "labDCReferidaPor"
        Me.labDCReferidaPor.Size = New System.Drawing.Size(306, 16)
        Me.labDCReferidaPor.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.labDCReferidaPor, "Doble Cilck para editar...")
        '
        'labDCPromedioPorConsulta
        '
        Me.labDCPromedioPorConsulta.BackColor = System.Drawing.SystemColors.Info
        Me.labDCPromedioPorConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCPromedioPorConsulta.Location = New System.Drawing.Point(606, 533)
        Me.labDCPromedioPorConsulta.Name = "labDCPromedioPorConsulta"
        Me.labDCPromedioPorConsulta.Size = New System.Drawing.Size(116, 16)
        Me.labDCPromedioPorConsulta.TabIndex = 54
        Me.labDCPromedioPorConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labDCPromedioPorConsulta.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 493)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "fue en:"
        '
        'txtDCFamiliatrabajo
        '
        Me.txtDCFamiliatrabajo.BackColor = System.Drawing.SystemColors.Window
        Me.txtDCFamiliatrabajo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtDCFamiliatrabajo.Location = New System.Drawing.Point(108, 402)
        Me.txtDCFamiliatrabajo.MaxLength = 3000
        Me.txtDCFamiliatrabajo.Multiline = True
        Me.txtDCFamiliatrabajo.Name = "txtDCFamiliatrabajo"
        Me.txtDCFamiliatrabajo.ReadOnly = True
        Me.txtDCFamiliatrabajo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDCFamiliatrabajo.Size = New System.Drawing.Size(277, 76)
        Me.txtDCFamiliatrabajo.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.txtDCFamiliatrabajo, "Doble Cilck para editar...")
        '
        'labDCnumeroConsultas
        '
        Me.labDCnumeroConsultas.BackColor = System.Drawing.SystemColors.Info
        Me.labDCnumeroConsultas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCnumeroConsultas.Location = New System.Drawing.Point(606, 491)
        Me.labDCnumeroConsultas.Name = "labDCnumeroConsultas"
        Me.labDCnumeroConsultas.Size = New System.Drawing.Size(38, 16)
        Me.labDCnumeroConsultas.TabIndex = 46
        Me.labDCnumeroConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(487, 535)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(113, 13)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Promedio por Consulta"
        Me.Label26.Visible = False
        '
        'txtDCultimoSMS
        '
        Me.txtDCultimoSMS.BackColor = System.Drawing.SystemColors.Window
        Me.txtDCultimoSMS.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtDCultimoSMS.Location = New System.Drawing.Point(108, 121)
        Me.txtDCultimoSMS.MaxLength = 3000
        Me.txtDCultimoSMS.Multiline = True
        Me.txtDCultimoSMS.Name = "txtDCultimoSMS"
        Me.txtDCultimoSMS.ReadOnly = True
        Me.txtDCultimoSMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDCultimoSMS.Size = New System.Drawing.Size(614, 59)
        Me.txtDCultimoSMS.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.txtDCultimoSMS, "Doble Cilck para editar...")
        '
        'txtDCReferencias
        '
        Me.txtDCReferencias.BackColor = System.Drawing.SystemColors.Info
        Me.txtDCReferencias.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtDCReferencias.Location = New System.Drawing.Point(108, 295)
        Me.txtDCReferencias.MaxLength = 3000
        Me.txtDCReferencias.Multiline = True
        Me.txtDCReferencias.Name = "txtDCReferencias"
        Me.txtDCReferencias.ReadOnly = True
        Me.txtDCReferencias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDCReferencias.Size = New System.Drawing.Size(277, 84)
        Me.txtDCReferencias.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.txtDCReferencias, "Se actualiza automaticamente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "al ir asociando Pacientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a su referidora")
        '
        'labDCHonorariosTotales
        '
        Me.labDCHonorariosTotales.BackColor = System.Drawing.SystemColors.Info
        Me.labDCHonorariosTotales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCHonorariosTotales.Location = New System.Drawing.Point(606, 511)
        Me.labDCHonorariosTotales.Name = "labDCHonorariosTotales"
        Me.labDCHonorariosTotales.Size = New System.Drawing.Size(116, 16)
        Me.labDCHonorariosTotales.TabIndex = 52
        Me.labDCHonorariosTotales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labDCHonorariosTotales.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(512, 493)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "No. de Consultas"
        '
        'labDCLugar1raConsulta
        '
        Me.labDCLugar1raConsulta.BackColor = System.Drawing.SystemColors.Info
        Me.labDCLugar1raConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCLugar1raConsulta.Location = New System.Drawing.Point(277, 491)
        Me.labDCLugar1raConsulta.Name = "labDCLugar1raConsulta"
        Me.labDCLugar1raConsulta.Size = New System.Drawing.Size(195, 15)
        Me.labDCLugar1raConsulta.TabIndex = 56
        Me.labDCLugar1raConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16b
        '
        Me.Label16b.AutoSize = True
        Me.Label16b.Location = New System.Drawing.Point(515, 514)
        Me.Label16b.Name = "Label16b"
        Me.Label16b.Size = New System.Drawing.Size(85, 13)
        Me.Label16b.TabIndex = 51
        Me.Label16b.Text = "Total Honorarios"
        Me.Label16b.Visible = False
        '
        'txtDCnotas
        '
        Me.txtDCnotas.BackColor = System.Drawing.SystemColors.Window
        Me.txtDCnotas.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtDCnotas.Location = New System.Drawing.Point(108, 186)
        Me.txtDCnotas.MaxLength = 3000
        Me.txtDCnotas.Multiline = True
        Me.txtDCnotas.Name = "txtDCnotas"
        Me.txtDCnotas.ReadOnly = True
        Me.txtDCnotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDCnotas.Size = New System.Drawing.Size(614, 88)
        Me.txtDCnotas.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.txtDCnotas, "Doble Cilck para editar...")
        '
        'labDCTelefonoVerificado
        '
        Me.labDCTelefonoVerificado.BackColor = System.Drawing.SystemColors.Window
        Me.labDCTelefonoVerificado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCTelefonoVerificado.Location = New System.Drawing.Point(639, 32)
        Me.labDCTelefonoVerificado.Name = "labDCTelefonoVerificado"
        Me.labDCTelefonoVerificado.Size = New System.Drawing.Size(83, 16)
        Me.labDCTelefonoVerificado.TabIndex = 53
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 124)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(99, 13)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "Mensajes Enviados"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labDCLugarUltimaConsulta
        '
        Me.labDCLugarUltimaConsulta.BackColor = System.Drawing.SystemColors.Info
        Me.labDCLugarUltimaConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCLugarUltimaConsulta.Location = New System.Drawing.Point(277, 512)
        Me.labDCLugarUltimaConsulta.Name = "labDCLugarUltimaConsulta"
        Me.labDCLugarUltimaConsulta.Size = New System.Drawing.Size(195, 16)
        Me.labDCLugarUltimaConsulta.TabIndex = 50
        Me.labDCLugarUltimaConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(108, 385)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(158, 13)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "Vinculos Familiares y de Trabajo"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(231, 514)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 13)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "fue en:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(565, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Verificado el:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 514)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 13)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Ultima Consulta el"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Edad"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(152, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Fecha de Nacimiento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Ocupación"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 493)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Paciente desde el"
        '
        'labDCultimaConsulta
        '
        Me.labDCultimaConsulta.BackColor = System.Drawing.SystemColors.Info
        Me.labDCultimaConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCultimaConsulta.Location = New System.Drawing.Point(109, 512)
        Me.labDCultimaConsulta.Name = "labDCultimaConsulta"
        Me.labDCultimaConsulta.Size = New System.Drawing.Size(116, 16)
        Me.labDCultimaConsulta.TabIndex = 48
        Me.labDCultimaConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDCfechaDeNacimiento
        '
        Me.labDCfechaDeNacimiento.BackColor = System.Drawing.SystemColors.Info
        Me.labDCfechaDeNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCfechaDeNacimiento.Location = New System.Drawing.Point(266, 11)
        Me.labDCfechaDeNacimiento.Name = "labDCfechaDeNacimiento"
        Me.labDCfechaDeNacimiento.Size = New System.Drawing.Size(216, 16)
        Me.labDCfechaDeNacimiento.TabIndex = 42
        '
        'labDCedadActual
        '
        Me.labDCedadActual.BackColor = System.Drawing.SystemColors.Info
        Me.labDCedadActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCedadActual.Location = New System.Drawing.Point(108, 11)
        Me.labDCedadActual.Name = "labDCedadActual"
        Me.labDCedadActual.Size = New System.Drawing.Size(37, 16)
        Me.labDCedadActual.TabIndex = 43
        '
        'labDCprofesion
        '
        Me.labDCprofesion.BackColor = System.Drawing.SystemColors.Info
        Me.labDCprofesion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCprofesion.Location = New System.Drawing.Point(108, 32)
        Me.labDCprofesion.Name = "labDCprofesion"
        Me.labDCprofesion.Size = New System.Drawing.Size(277, 16)
        Me.labDCprofesion.TabIndex = 44
        '
        'labDCpacienteDesde
        '
        Me.labDCpacienteDesde.BackColor = System.Drawing.SystemColors.Info
        Me.labDCpacienteDesde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCpacienteDesde.Location = New System.Drawing.Point(109, 491)
        Me.labDCpacienteDesde.Name = "labDCpacienteDesde"
        Me.labDCpacienteDesde.Size = New System.Drawing.Size(116, 16)
        Me.labDCpacienteDesde.TabIndex = 44
        Me.labDCpacienteDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labDCparidad
        '
        Me.labDCparidad.BackColor = System.Drawing.SystemColors.Info
        Me.labDCparidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCparidad.Location = New System.Drawing.Point(537, 11)
        Me.labDCparidad.Name = "labDCparidad"
        Me.labDCparidad.Size = New System.Drawing.Size(185, 16)
        Me.labDCparidad.TabIndex = 50
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(391, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Teléfono"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(488, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Paridad"
        '
        'labDCtelefono
        '
        Me.labDCtelefono.BackColor = System.Drawing.SystemColors.Info
        Me.labDCtelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDCtelefono.Location = New System.Drawing.Point(446, 32)
        Me.labDCtelefono.Name = "labDCtelefono"
        Me.labDCtelefono.Size = New System.Drawing.Size(113, 16)
        Me.labDCtelefono.TabIndex = 48
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(67, 189)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(35, 13)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Notas"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabPageConsultas
        '
        Me.TabPageConsultas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPageConsultas.Controls.Add(Me.Label34)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaBanco)
        Me.TabPageConsultas.Controls.Add(Me.Label33)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaReferencia)
        Me.TabPageConsultas.Controls.Add(Me.Label29)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaFormaDePago)
        Me.TabPageConsultas.Controls.Add(Me.Label24)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaFechaDeCancelacion)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaEstatusCancelacion)
        Me.TabPageConsultas.Controls.Add(Me.Label20)
        Me.TabPageConsultas.Controls.Add(Me.Label6)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaPagador)
        Me.TabPageConsultas.Controls.Add(Me.labCalendarioConsultaOtroDia)
        Me.TabPageConsultas.Controls.Add(Me.CalendarioConsultaOtraDia)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaFactura)
        Me.TabPageConsultas.Controls.Add(Me.Label84)
        Me.TabPageConsultas.Controls.Add(Me.labConsultasArchivadas)
        Me.TabPageConsultas.Controls.Add(Me.Label31)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaManual)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaAuto)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaProximaConsulta)
        Me.TabPageConsultas.Controls.Add(Me.Label1)
        Me.TabPageConsultas.Controls.Add(Me.botConsultaOtroDiaAccion)
        Me.TabPageConsultas.Controls.Add(Me.botEliminarConsulta)
        Me.TabPageConsultas.Controls.Add(Me.botEditarConsulta)
        Me.TabPageConsultas.Controls.Add(Me.botConsultaOtroDia)
        Me.TabPageConsultas.Controls.Add(Me.botConsultaHoy)
        Me.TabPageConsultas.Controls.Add(Me.ListBoxConsultas)
        Me.TabPageConsultas.Controls.Add(Me.Label83)
        Me.TabPageConsultas.Controls.Add(Me.Label82)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaLugarConsulta)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaTratamiento)
        Me.TabPageConsultas.Controls.Add(Me.Label79)
        Me.TabPageConsultas.Controls.Add(Me.Label81)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaHonorarios)
        Me.TabPageConsultas.Controls.Add(Me.txtAgendaPendiente)
        Me.TabPageConsultas.Controls.Add(Me.Label80)
        Me.TabPageConsultas.Location = New System.Drawing.Point(4, 22)
        Me.TabPageConsultas.Name = "TabPageConsultas"
        Me.TabPageConsultas.Size = New System.Drawing.Size(728, 558)
        Me.TabPageConsultas.TabIndex = 3
        Me.TabPageConsultas.Text = "Consultas"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(372, 477)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(38, 13)
        Me.Label34.TabIndex = 83
        Me.Label34.Text = "Banco"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAgendaBanco
        '
        Me.txtAgendaBanco.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Amauri Rengel"})
        Me.txtAgendaBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtAgendaBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAgendaBanco.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaBanco.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaBanco.Location = New System.Drawing.Point(375, 493)
        Me.txtAgendaBanco.MaxLength = 30
        Me.txtAgendaBanco.Name = "txtAgendaBanco"
        Me.txtAgendaBanco.ReadOnly = True
        Me.txtAgendaBanco.Size = New System.Drawing.Size(136, 20)
        Me.txtAgendaBanco.TabIndex = 82
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(517, 477)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(66, 13)
        Me.Label33.TabIndex = 81
        Me.Label33.Text = "#Referencia"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAgendaReferencia
        '
        Me.txtAgendaReferencia.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Amauri Rengel"})
        Me.txtAgendaReferencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtAgendaReferencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAgendaReferencia.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaReferencia.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaReferencia.Location = New System.Drawing.Point(520, 493)
        Me.txtAgendaReferencia.MaxLength = 30
        Me.txtAgendaReferencia.Name = "txtAgendaReferencia"
        Me.txtAgendaReferencia.ReadOnly = True
        Me.txtAgendaReferencia.Size = New System.Drawing.Size(136, 20)
        Me.txtAgendaReferencia.TabIndex = 80
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(372, 438)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(79, 13)
        Me.Label29.TabIndex = 79
        Me.Label29.Text = "Forma de Pago"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAgendaFormaDePago
        '
        Me.txtAgendaFormaDePago.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Amauri Rengel"})
        Me.txtAgendaFormaDePago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtAgendaFormaDePago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAgendaFormaDePago.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaFormaDePago.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaFormaDePago.Location = New System.Drawing.Point(375, 454)
        Me.txtAgendaFormaDePago.MaxLength = 30
        Me.txtAgendaFormaDePago.Name = "txtAgendaFormaDePago"
        Me.txtAgendaFormaDePago.ReadOnly = True
        Me.txtAgendaFormaDePago.Size = New System.Drawing.Size(136, 20)
        Me.txtAgendaFormaDePago.TabIndex = 78
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(517, 399)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(114, 13)
        Me.Label24.TabIndex = 77
        Me.Label24.Text = "Fecha de Cancelación"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAgendaFechaDeCancelacion
        '
        Me.txtAgendaFechaDeCancelacion.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaFechaDeCancelacion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaFechaDeCancelacion.Location = New System.Drawing.Point(520, 415)
        Me.txtAgendaFechaDeCancelacion.MaxLength = 7
        Me.txtAgendaFechaDeCancelacion.Name = "txtAgendaFechaDeCancelacion"
        Me.txtAgendaFechaDeCancelacion.ReadOnly = True
        Me.txtAgendaFechaDeCancelacion.Size = New System.Drawing.Size(205, 20)
        Me.txtAgendaFechaDeCancelacion.TabIndex = 76
        '
        'txtAgendaEstatusCancelacion
        '
        Me.txtAgendaEstatusCancelacion.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Amauri Rengel"})
        Me.txtAgendaEstatusCancelacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtAgendaEstatusCancelacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAgendaEstatusCancelacion.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaEstatusCancelacion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaEstatusCancelacion.Location = New System.Drawing.Point(375, 415)
        Me.txtAgendaEstatusCancelacion.MaxLength = 30
        Me.txtAgendaEstatusCancelacion.Name = "txtAgendaEstatusCancelacion"
        Me.txtAgendaEstatusCancelacion.ReadOnly = True
        Me.txtAgendaEstatusCancelacion.Size = New System.Drawing.Size(139, 20)
        Me.txtAgendaEstatusCancelacion.TabIndex = 75
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(372, 399)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(119, 13)
        Me.Label20.TabIndex = 74
        Me.Label20.Text = "Estatus de Cancelación"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(517, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Pagador"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAgendaPagador
        '
        Me.txtAgendaPagador.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Amauri Rengel"})
        Me.txtAgendaPagador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtAgendaPagador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAgendaPagador.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaPagador.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaPagador.Location = New System.Drawing.Point(520, 454)
        Me.txtAgendaPagador.MaxLength = 30
        Me.txtAgendaPagador.Name = "txtAgendaPagador"
        Me.txtAgendaPagador.ReadOnly = True
        Me.txtAgendaPagador.Size = New System.Drawing.Size(205, 20)
        Me.txtAgendaPagador.TabIndex = 72
        '
        'labCalendarioConsultaOtroDia
        '
        Me.labCalendarioConsultaOtroDia.AutoSize = True
        Me.labCalendarioConsultaOtroDia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labCalendarioConsultaOtroDia.Location = New System.Drawing.Point(372, 6)
        Me.labCalendarioConsultaOtroDia.Name = "labCalendarioConsultaOtroDia"
        Me.labCalendarioConsultaOtroDia.Size = New System.Drawing.Size(171, 13)
        Me.labCalendarioConsultaOtroDia.TabIndex = 71
        Me.labCalendarioConsultaOtroDia.Text = "Selecciona la fecha de la Consulta"
        Me.labCalendarioConsultaOtroDia.Visible = False
        '
        'CalendarioConsultaOtraDia
        '
        Me.CalendarioConsultaOtraDia.Location = New System.Drawing.Point(375, 23)
        Me.CalendarioConsultaOtraDia.Name = "CalendarioConsultaOtraDia"
        Me.CalendarioConsultaOtraDia.TabIndex = 67
        Me.CalendarioConsultaOtraDia.Visible = False
        '
        'txtAgendaFactura
        '
        Me.txtAgendaFactura.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaFactura.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaFactura.Location = New System.Drawing.Point(375, 532)
        Me.txtAgendaFactura.MaxLength = 7
        Me.txtAgendaFactura.Name = "txtAgendaFactura"
        Me.txtAgendaFactura.ReadOnly = True
        Me.txtAgendaFactura.Size = New System.Drawing.Size(136, 20)
        Me.txtAgendaFactura.TabIndex = 69
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(5, 190)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(200, 13)
        Me.Label84.TabIndex = 55
        Me.Label84.Text = "Signos Objetivos y Datos Autogenerados"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labConsultasArchivadas
        '
        Me.labConsultasArchivadas.AutoSize = True
        Me.labConsultasArchivadas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labConsultasArchivadas.Location = New System.Drawing.Point(5, 6)
        Me.labConsultasArchivadas.Name = "labConsultasArchivadas"
        Me.labConsultasArchivadas.Size = New System.Drawing.Size(181, 13)
        Me.labConsultasArchivadas.TabIndex = 35
        Me.labConsultasArchivadas.Text = "Consultas Archivadas en la Agenda :"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(372, 516)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(90, 13)
        Me.Label31.TabIndex = 68
        Me.Label31.Text = "Factura Asociada"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAgendaManual
        '
        Me.txtAgendaManual.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaManual.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtAgendaManual.Location = New System.Drawing.Point(5, 376)
        Me.txtAgendaManual.MaxLength = 3000
        Me.txtAgendaManual.Multiline = True
        Me.txtAgendaManual.Name = "txtAgendaManual"
        Me.txtAgendaManual.ReadOnly = True
        Me.txtAgendaManual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAgendaManual.Size = New System.Drawing.Size(364, 98)
        Me.txtAgendaManual.TabIndex = 53
        '
        'txtAgendaAuto
        '
        Me.txtAgendaAuto.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaAuto.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtAgendaAuto.Location = New System.Drawing.Point(5, 207)
        Me.txtAgendaAuto.MaxLength = 3000
        Me.txtAgendaAuto.Multiline = True
        Me.txtAgendaAuto.Name = "txtAgendaAuto"
        Me.txtAgendaAuto.ReadOnly = True
        Me.txtAgendaAuto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAgendaAuto.Size = New System.Drawing.Size(361, 149)
        Me.txtAgendaAuto.TabIndex = 54
        '
        'txtAgendaProximaConsulta
        '
        Me.txtAgendaProximaConsulta.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaProximaConsulta.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaProximaConsulta.Location = New System.Drawing.Point(520, 336)
        Me.txtAgendaProximaConsulta.MaxLength = 7
        Me.txtAgendaProximaConsulta.Name = "txtAgendaProximaConsulta"
        Me.txtAgendaProximaConsulta.ReadOnly = True
        Me.txtAgendaProximaConsulta.Size = New System.Drawing.Size(205, 20)
        Me.txtAgendaProximaConsulta.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Signos Subjetivos y Datos Manuales"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botConsultaOtroDiaAccion
        '
        Me.botConsultaOtroDiaAccion.BackColor = System.Drawing.SystemColors.Control
        Me.botConsultaOtroDiaAccion.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botConsultaOtroDiaAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botConsultaOtroDiaAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botConsultaOtroDiaAccion.ForeColor = System.Drawing.Color.Black
        Me.botConsultaOtroDiaAccion.Location = New System.Drawing.Point(615, 23)
        Me.botConsultaOtroDiaAccion.Name = "botConsultaOtroDiaAccion"
        Me.botConsultaOtroDiaAccion.Size = New System.Drawing.Size(110, 23)
        Me.botConsultaOtroDiaAccion.TabIndex = 70
        Me.botConsultaOtroDiaAccion.Text = "Nueva Consulta"
        Me.botConsultaOtroDiaAccion.UseVisualStyleBackColor = False
        Me.botConsultaOtroDiaAccion.Visible = False
        '
        'botEliminarConsulta
        '
        Me.botEliminarConsulta.BackColor = System.Drawing.SystemColors.Control
        Me.botEliminarConsulta.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botEliminarConsulta.Enabled = False
        Me.botEliminarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEliminarConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botEliminarConsulta.ForeColor = System.Drawing.Color.Black
        Me.botEliminarConsulta.Location = New System.Drawing.Point(259, 110)
        Me.botEliminarConsulta.Name = "botEliminarConsulta"
        Me.botEliminarConsulta.Size = New System.Drawing.Size(110, 23)
        Me.botEliminarConsulta.TabIndex = 38
        Me.botEliminarConsulta.Text = "Eliminar Consulta"
        Me.botEliminarConsulta.UseVisualStyleBackColor = False
        '
        'botEditarConsulta
        '
        Me.botEditarConsulta.BackColor = System.Drawing.SystemColors.Control
        Me.botEditarConsulta.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botEditarConsulta.Enabled = False
        Me.botEditarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEditarConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botEditarConsulta.ForeColor = System.Drawing.Color.Black
        Me.botEditarConsulta.Location = New System.Drawing.Point(259, 81)
        Me.botEditarConsulta.Name = "botEditarConsulta"
        Me.botEditarConsulta.Size = New System.Drawing.Size(110, 23)
        Me.botEditarConsulta.TabIndex = 52
        Me.botEditarConsulta.Text = "Editar Consulta"
        Me.botEditarConsulta.UseVisualStyleBackColor = False
        '
        'botConsultaOtroDia
        '
        Me.botConsultaOtroDia.BackColor = System.Drawing.SystemColors.Control
        Me.botConsultaOtroDia.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botConsultaOtroDia.Enabled = False
        Me.botConsultaOtroDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botConsultaOtroDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botConsultaOtroDia.ForeColor = System.Drawing.Color.Black
        Me.botConsultaOtroDia.Location = New System.Drawing.Point(259, 52)
        Me.botConsultaOtroDia.Name = "botConsultaOtroDia"
        Me.botConsultaOtroDia.Size = New System.Drawing.Size(110, 23)
        Me.botConsultaOtroDia.TabIndex = 37
        Me.botConsultaOtroDia.Text = "Consulta otro Día"
        Me.botConsultaOtroDia.UseVisualStyleBackColor = False
        '
        'botConsultaHoy
        '
        Me.botConsultaHoy.BackColor = System.Drawing.SystemColors.Control
        Me.botConsultaHoy.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botConsultaHoy.Enabled = False
        Me.botConsultaHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botConsultaHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botConsultaHoy.ForeColor = System.Drawing.Color.Black
        Me.botConsultaHoy.Location = New System.Drawing.Point(259, 23)
        Me.botConsultaHoy.Name = "botConsultaHoy"
        Me.botConsultaHoy.Size = New System.Drawing.Size(110, 23)
        Me.botConsultaHoy.TabIndex = 31
        Me.botConsultaHoy.Text = "Consulta HOY"
        Me.botConsultaHoy.UseVisualStyleBackColor = False
        '
        'ListBoxConsultas
        '
        Me.ListBoxConsultas.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxConsultas.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxConsultas.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxConsultas.ItemHeight = 11
        Me.ListBoxConsultas.Location = New System.Drawing.Point(5, 23)
        Me.ListBoxConsultas.Name = "ListBoxConsultas"
        Me.ListBoxConsultas.Size = New System.Drawing.Size(223, 136)
        Me.ListBoxConsultas.TabIndex = 36
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(517, 320)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(88, 13)
        Me.Label83.TabIndex = 65
        Me.Label83.Text = "Próxima Consulta"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(5, 477)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(107, 13)
        Me.Label82.TabIndex = 57
        Me.Label82.Text = "Tratamiento Indicado"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAgendaLugarConsulta
        '
        Me.txtAgendaLugarConsulta.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Amauri Rengel"})
        Me.txtAgendaLugarConsulta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtAgendaLugarConsulta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAgendaLugarConsulta.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaLugarConsulta.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaLugarConsulta.Location = New System.Drawing.Point(375, 336)
        Me.txtAgendaLugarConsulta.MaxLength = 30
        Me.txtAgendaLugarConsulta.Name = "txtAgendaLugarConsulta"
        Me.txtAgendaLugarConsulta.ReadOnly = True
        Me.txtAgendaLugarConsulta.Size = New System.Drawing.Size(139, 20)
        Me.txtAgendaLugarConsulta.TabIndex = 64
        '
        'txtAgendaTratamiento
        '
        Me.txtAgendaTratamiento.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaTratamiento.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaTratamiento.Location = New System.Drawing.Point(5, 493)
        Me.txtAgendaTratamiento.MaxLength = 1000
        Me.txtAgendaTratamiento.Multiline = True
        Me.txtAgendaTratamiento.Name = "txtAgendaTratamiento"
        Me.txtAgendaTratamiento.ReadOnly = True
        Me.txtAgendaTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAgendaTratamiento.Size = New System.Drawing.Size(364, 59)
        Me.txtAgendaTratamiento.TabIndex = 58
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(372, 320)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(104, 13)
        Me.Label79.TabIndex = 63
        Me.Label79.Text = "Lugar de la Consulta"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(372, 190)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(165, 13)
        Me.Label81.TabIndex = 59
        Me.Label81.Text = "Pendiente en la Próxima Consulta"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAgendaHonorarios
        '
        Me.txtAgendaHonorarios.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaHonorarios.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaHonorarios.Location = New System.Drawing.Point(375, 376)
        Me.txtAgendaHonorarios.MaxLength = 7
        Me.txtAgendaHonorarios.Name = "txtAgendaHonorarios"
        Me.txtAgendaHonorarios.ReadOnly = True
        Me.txtAgendaHonorarios.Size = New System.Drawing.Size(139, 20)
        Me.txtAgendaHonorarios.TabIndex = 62
        Me.txtAgendaHonorarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAgendaPendiente
        '
        Me.txtAgendaPendiente.BackColor = System.Drawing.SystemColors.Info
        Me.txtAgendaPendiente.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAgendaPendiente.Location = New System.Drawing.Point(375, 207)
        Me.txtAgendaPendiente.MaxLength = 1000
        Me.txtAgendaPendiente.Multiline = True
        Me.txtAgendaPendiente.Name = "txtAgendaPendiente"
        Me.txtAgendaPendiente.ReadOnly = True
        Me.txtAgendaPendiente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAgendaPendiente.Size = New System.Drawing.Size(350, 110)
        Me.txtAgendaPendiente.TabIndex = 60
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(372, 360)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(113, 13)
        Me.Label80.TabIndex = 61
        Me.Label80.Text = "Honorarios Generados"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabHistoriaAbierta
        '
        Me.LabHistoriaAbierta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabHistoriaAbierta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabHistoriaAbierta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHistoriaAbierta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabHistoriaAbierta.Location = New System.Drawing.Point(8, 3)
        Me.LabHistoriaAbierta.Name = "LabHistoriaAbierta"
        Me.LabHistoriaAbierta.Size = New System.Drawing.Size(966, 23)
        Me.LabHistoriaAbierta.TabIndex = 22
        Me.LabHistoriaAbierta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BotControlGinecologico
        '
        Me.BotControlGinecologico.BackColor = System.Drawing.SystemColors.Control
        Me.BotControlGinecologico.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.BotControlGinecologico.Enabled = False
        Me.BotControlGinecologico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotControlGinecologico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotControlGinecologico.ForeColor = System.Drawing.Color.Black
        Me.BotControlGinecologico.Location = New System.Drawing.Point(8, 150)
        Me.BotControlGinecologico.Name = "BotControlGinecologico"
        Me.BotControlGinecologico.Size = New System.Drawing.Size(224, 23)
        Me.BotControlGinecologico.TabIndex = 38
        Me.BotControlGinecologico.Text = "Control Ginecológico"
        Me.BotControlGinecologico.UseVisualStyleBackColor = False
        '
        'botCerrarHistoria2
        '
        Me.botCerrarHistoria2.BackColor = System.Drawing.SystemColors.Control
        Me.botCerrarHistoria2.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botCerrarHistoria2.Enabled = False
        Me.botCerrarHistoria2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCerrarHistoria2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botCerrarHistoria2.ForeColor = System.Drawing.Color.Black
        Me.botCerrarHistoria2.Location = New System.Drawing.Point(8, 595)
        Me.botCerrarHistoria2.Name = "botCerrarHistoria2"
        Me.botCerrarHistoria2.Size = New System.Drawing.Size(224, 23)
        Me.botCerrarHistoria2.TabIndex = 27
        Me.botCerrarHistoria2.Text = "Cierra Historia"
        Me.botCerrarHistoria2.UseVisualStyleBackColor = False
        '
        'botNuevoEco
        '
        Me.botNuevoEco.BackColor = System.Drawing.SystemColors.Control
        Me.botNuevoEco.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botNuevoEco.Enabled = False
        Me.botNuevoEco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botNuevoEco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botNuevoEco.ForeColor = System.Drawing.Color.Black
        Me.botNuevoEco.Location = New System.Drawing.Point(8, 200)
        Me.botNuevoEco.Name = "botNuevoEco"
        Me.botNuevoEco.Size = New System.Drawing.Size(224, 23)
        Me.botNuevoEco.TabIndex = 20
        Me.botNuevoEco.Text = "Control Ecográfico"
        Me.botNuevoEco.UseVisualStyleBackColor = False
        '
        'botNuevaHistoriaObstetrica
        '
        Me.botNuevaHistoriaObstetrica.BackColor = System.Drawing.SystemColors.Control
        Me.botNuevaHistoriaObstetrica.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botNuevaHistoriaObstetrica.Enabled = False
        Me.botNuevaHistoriaObstetrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botNuevaHistoriaObstetrica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botNuevaHistoriaObstetrica.ForeColor = System.Drawing.Color.Black
        Me.botNuevaHistoriaObstetrica.Location = New System.Drawing.Point(8, 175)
        Me.botNuevaHistoriaObstetrica.Name = "botNuevaHistoriaObstetrica"
        Me.botNuevaHistoriaObstetrica.Size = New System.Drawing.Size(224, 23)
        Me.botNuevaHistoriaObstetrica.TabIndex = 19
        Me.botNuevaHistoriaObstetrica.Text = "Control Obstétrico"
        Me.botNuevaHistoriaObstetrica.UseVisualStyleBackColor = False
        '
        'botDatosPersonales
        '
        Me.botDatosPersonales.BackColor = System.Drawing.SystemColors.Control
        Me.botDatosPersonales.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botDatosPersonales.Enabled = False
        Me.botDatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botDatosPersonales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botDatosPersonales.ForeColor = System.Drawing.Color.Black
        Me.botDatosPersonales.Location = New System.Drawing.Point(8, 125)
        Me.botDatosPersonales.Name = "botDatosPersonales"
        Me.botDatosPersonales.Size = New System.Drawing.Size(224, 23)
        Me.botDatosPersonales.TabIndex = 17
        Me.botDatosPersonales.Text = "Datos Personales y Antecedentes"
        Me.botDatosPersonales.UseVisualStyleBackColor = False
        '
        'ListBoxContenido
        '
        Me.ListBoxContenido.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxContenido.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxContenido.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxContenido.ItemHeight = 11
        Me.ListBoxContenido.Location = New System.Drawing.Point(8, 53)
        Me.ListBoxContenido.Name = "ListBoxContenido"
        Me.ListBoxContenido.Size = New System.Drawing.Size(224, 70)
        Me.ListBoxContenido.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(5, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(184, 16)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Contenido de la Historia"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuBasedeDatos, Me.MenuItemAgenda, Me.MenuItemVademecum, Me.MenuItemRecipes, Me.MenuItem1})
        '
        'MenuBasedeDatos
        '
        Me.MenuBasedeDatos.Index = 0
        Me.MenuBasedeDatos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuAbreBase, Me.MenuCreaBase, Me.MenuDatosDelUsuario})
        Me.MenuBasedeDatos.Text = "Base de Datos"
        '
        'MenuAbreBase
        '
        Me.MenuAbreBase.Index = 0
        Me.MenuAbreBase.Text = "Abrir Base de Datos"
        '
        'MenuCreaBase
        '
        Me.MenuCreaBase.Index = 1
        Me.MenuCreaBase.Text = "Crear Base de Datos"
        '
        'MenuDatosDelUsuario
        '
        Me.MenuDatosDelUsuario.Index = 2
        Me.MenuDatosDelUsuario.Text = "Datos del Usuario"
        '
        'MenuItemAgenda
        '
        Me.MenuItemAgenda.Index = 1
        Me.MenuItemAgenda.Text = "Agenda"
        '
        'MenuItemVademecum
        '
        Me.MenuItemVademecum.Index = 2
        Me.MenuItemVademecum.Text = "Vademecum"
        '
        'MenuItemRecipes
        '
        Me.MenuItemRecipes.Index = 3
        Me.MenuItemRecipes.Text = "Récipes y Papelería"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 4
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuCalculoEGconECO, Me.menuCalculoEGconFUR, Me.menuCalculoDCconFUR, Me.menuCalculoEGconBiometria})
        Me.MenuItem1.Text = "Herramientas"
        '
        'menuCalculoEGconECO
        '
        Me.menuCalculoEGconECO.Index = 0
        Me.menuCalculoEGconECO.Text = "Cálculo de EG con ECO"
        '
        'menuCalculoEGconFUR
        '
        Me.menuCalculoEGconFUR.Index = 1
        Me.menuCalculoEGconFUR.Text = "Cálculo de EG con FUR"
        '
        'menuCalculoDCconFUR
        '
        Me.menuCalculoDCconFUR.Index = 2
        Me.menuCalculoDCconFUR.Text = "Cálculo de Día del Ciclo con FUR"
        '
        'menuCalculoEGconBiometria
        '
        Me.menuCalculoEGconBiometria.Index = 3
        Me.menuCalculoEGconBiometria.Text = "Cálculo de EG y Peso Por Biometría"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(990, 660)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historias Clínicas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAniversarios.ResumeLayout(False)
        Me.PanelAniversarios.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.PanelEtarios.ResumeLayout(False)
        Me.PanelEtarios.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControlNotas.ResumeLayout(False)
        Me.TabPageResumen.ResumeLayout(False)
        Me.TabPageResumen.PerformLayout()
        Me.TabPageConsultas.ResumeLayout(False)
        Me.TabPageConsultas.PerformLayout()
        CType(Me.BaseDatosIndiceHistoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'variables Publicas iniciales
    Public Shared PSstrArchivoNombreBaseDeDatos As String
    Public Shared PSstrArchivoHistoriaHIS As String
    Public Shared PSstrDirectorioDeLaAplicacion As String
    Public Shared PSdateFechaDeArraqueDeAgenda As Date

    'variables publicas de saber de donde se cargo algo y banderas
    Public Shared PSbooHistoriaAbierta As Boolean = False
    'Public Shared strMensajeAlAbrirHistoria As String = ""

    Public Shared PSbooBaseDeDatos_ProcesoDeAbrir As Boolean = False


    Dim NumeroHistoriaNuevo As String   'se usa en la ventan nuevahistoria y siguientes
    Dim NombreNuevo As String           'igual
    Dim CedulaNueva As String           'igual

    Structure BaseDatosIndiceHistorias
        Dim NumeroHistoria As String
        Dim NombrePaciente As String
        Dim CedulaPaciente As String
    End Structure
    Public Shared Historias As New ArrayList()        'array con las historias de una base de datos


    Public Shared ElementosHistoria As New ArrayList()     'array con las subcarpetas de una historia determinada

    Structure BaseDatosIndiceHistorias2
        Dim a01NumeroHistoria As String
        Dim a02NombreCompletoPaciente As String
        Dim a03NombrePaciente As String
        Dim a04ApellidoPaciente As String
        Dim a05CedulaPaciente As String
    End Structure

    Structure TablaDePacientesConDatosAmpliados
        Dim a01NumeroHistoria As String
        Dim a02NombrePaciente As String
        Dim a03CedulaPaciente As String
        Dim b01NumeroDePacientesReferidas As String
        Dim b02FechaDeNacimiento As String
        Dim b03Telefono As String
        Dim b04NumeroDeConsultas As String
        Dim b05NumeroDeEmbarazos As String
        Dim c01 As String
        Dim c02 As String
        Dim c03 As String
        Dim c04 As String
        Dim c05 As String
    End Structure

    Structure TablaDePacientesBDH
        Dim a01NumeroHistoria As String
        Dim a02NombrePaciente As String
        Dim a03CedulaPaciente As String

        'para los grupos 
        Dim a04NumeroDeReferidas As String
        Dim a05TieneControlObstetrico As String
        Dim a06EstaEmbarazada As String
        Dim a07TieneConsultaPendiente As String
        Dim a08NumeroDeConsultas As String
        Dim a09VinoExpontaneamente As String
        Dim a10FueReferidaPorPaciente As String
        Dim a11FueReferidaPorOtroReferidor As String
        Dim a12EsPacienteDeOtroMedico As String
        Dim a13SeDeconoceReferencia As String
        Dim a14FURdelUltimoControl As String
        Dim a15FechaProximoControl As String
        Dim A16NombreDelReferidor As String
        Dim a17PacienteDesde As String




    End Structure

    Public Shared alsPacientes As New ArrayList

    Public Shared alsPacientesReferidoras As New ArrayList

    '00000000000000 Variables y Estructuras de la modificacion a Serializacion 0000000000000000000000000
    Structure TablaDePacientesSerializadas
        Dim a01intNumeroDeHistoria As Integer
        Dim a02strNombreDePaciente As String
        Dim a03strCedulaDeIdentidad As String
        '-------------------
        Dim a04dateFechaDeNacimiento As Date
        Dim a05strCelular As String
        Dim a06strTelefono As String
        Dim a07strOcupacion As String
        '----------------------
        Dim a08strDireccionDeHabitacion As String
        Dim a09strGradoDeInstruccion As String
        Dim a10strCiaDeSeguros As String
        Dim a11strEmail As String
        Dim a12strBBPin As String
        Dim a13strReligion As String
        Dim a14strNombreDeFamiliar As String
        Dim a15strCelularDeFamiliar As String
        Dim a16strOcupacionDeFamiliar As String
        '-------------------
        Dim a17booReferidaExpontaneamente As Boolean
        Dim a18booReferidaPorPaciente As Boolean
        Dim a19booReferidaPorMedico As Boolean
        Dim a20booReferidaNoIncluidaAun As Boolean
        Dim a21intNumeroIdDelReferidor As Integer
        Dim a22booEsPacienteReferidora As Boolean
        Dim a23intNumeroDeReferidas As Integer
        '--------------------------------
        Dim a24booTieneControlObstetrico As Boolean
        Dim a25booEstaActualmenteEmbarazada As Boolean
        Dim a26dateFUR As Date
        Dim a27booLeAtendiCesarea As Boolean
        Dim a28booLeAtendiParto As Boolean
        Dim a29booLeAtendiLegrado As Boolean
        Dim a30intParidadEmbarazos As Integer
        Dim a31intParidadCesareas As Integer
        Dim a32intParidadPartos As Integer
        Dim a33intParidadAbortos As Integer
        Dim a34intParidadEctopicos As Integer
        '------------------------
        Dim a35booTieneConsultaPendiente As Boolean
        Dim a36dateFechaDeLaCita As Date
        Dim a37booCitaObstetrica As Boolean
        Dim a38booCitaGinecologica As Boolean
        Dim a39booCitaPostOperatoria As Boolean
        Dim a40booCitaControlAnualCitologico As Boolean
        '-------------------------
        Dim a41dateFechaDeUltimaConsulta As Date
        Dim a42dateFechaDePrimeraConsulta As Date
        Dim a43intNumeroDeConsultas
        '-----------------------
        Dim a44int As Integer
        Dim a45int As Integer
        Dim a46int As Integer
        Dim a47int As Integer
        Dim a48int As Integer
        Dim a49str As String
        Dim a50str As String
        Dim a51str As String
        Dim a52str As String
        Dim a53str As String
        Dim a54date As Date
        Dim a55date As Date
        Dim a56date As Date
        Dim a57date As Date
        Dim a58date As Date
        Dim a59boo As Boolean
        Dim a60boo As Boolean
        Dim a61boo As Boolean
        Dim a62boo As Boolean
        Dim a63boo As Boolean
    End Structure

    Public Shared PSalsPacientesSerializadas As New ArrayList
    '000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000

    Structure DatosPersonales
        Dim a01Nombre As String
        Dim FechaNacimiento As String
        Dim Edad As String
        Dim Cedula As String
        Dim Profesion As String
        Dim Telefono As String
        Dim AntecedentesFamiliares As String
        Dim AntecedentesPersonales As String
        Dim AntecedentesGinecologicos As String
        Dim AntecedentesObstetricos As String
        Dim AntecedentesQuirurgicos As String
        Dim x01DireccionDeHabitacion As String
        Dim x02GradoDeInstruccion As String
        Dim x03Religion As String
        Dim x04CiaDeSeguros As String
        Dim x05FamiliarNombre As String
        Dim x06FamiliarParentesco As String
        Dim x07FamiliarCelular As String
        Dim x08FamiliarOcupacion As String
        Dim z01 As String
        Dim z02 As String
        Dim z03 As String
        Dim z04 As String
        Dim z05 As String
        Dim z06 As String
        Dim z07 As String
        Dim z08 As String
        Dim z09 As String
        Dim z10 As String
    End Structure

    'estructura para la modificacion de las listas de aniversario y otros
    Structure structureListadoPacientesDatosComplementarios
        Dim d00NumeroHistoria As String
        Dim d01Nombre As String
        Dim d02FechaNacimiento As String
        Dim d03Cedula As String
        Dim d04Telefono As String
        Dim d05 As String
        Dim d06 As String
        Dim d07 As String
    End Structure
    Dim arrayAniversarios As New ArrayList

    'estructura para la lista de aniversarios en las bases de datos
    Structure structureDatosDeAniversario
        Dim Nombre As String
        Dim FechaNacimiento As String
        Dim Edad As String
        Dim Telefono As String
    End Structure
    'y su respectiva array de los cumpleañeras de hoy y de la semana
    Dim arrayAniversarioHoy As New ArrayList
    Dim arrayAniversarioSemana As New ArrayList
    'y las arrays de los grupos etarios
    Dim arrayEdad0a19 As New ArrayList
    Dim arrayEdad20a29 As New ArrayList
    Dim arrayEdad30a39 As New ArrayList
    Dim arrayEdad40a99 As New ArrayList
    'para las historias q no tengan datos de fecha de nacimiento o datos personales
    Structure structureHistoriasSinDatosPersonales
        Dim NumeroHistoria As String
        Dim Nombre As String
        Dim Cedula As String
    End Structure
    'y su respectiva array
    Dim arrayHistoriasSinDatos As New ArrayList



    Structure TablaDeDatosGinecologicos
        Dim FechaActual As String
        Dim FUR As String
        Dim DiaCiclo As String
        Dim MotivoConsulta As String
        Dim CondicionesGenerales As String
        Dim TAS As String
        Dim TAD As String
        Dim Peso As String
        Dim Cardiovascular As String
        Dim Respiratorio As String
        Dim MamaIzq As String
        Dim MamaDer As String
        Dim Abdomen As String
        Dim GenitalesExt As String
        Dim Vagina As String
        Dim Cuello As String
        Dim Shiller As String
        Dim Tacto As String
        Dim MiembrosInf As String
        Dim Neurologico As String
        Dim Otros As String
    End Structure

    Structure TablaDeAntecedentesObstetricos
        Dim a01Gestas, a02Paras, a03Cesareas, a04Abortos, a05Ectopicos, a06strNotas, Dato006, Dato007, Dato008, Dato009 As String
        Dim Dato010, Dato011, Dato012, Dato013, Dato014, Dato015, Dato016, Dato017, Dato018, Dato019 As String
        Dim Dato020, Dato021, Dato022, Dato023, Dato024, Dato025, Dato026, Dato027, Dato028, Dato029 As String
        Dim Dato030, Dato031, Dato032, Dato033, Dato034, Dato035, Dato036, Dato037, Dato038, Dato039 As String
        Dim Dato040, Dato041, Dato042, Dato043, Dato044peso01, Dato045, Dato046, Dato047, Dato048, Dato049 As String
        Dim Dato050, Dato051, Dato052, Dato053, Dato054peso02, Dato055, Dato056, Dato057, Dato058, Dato059 As String
        Dim Dato060, Dato061, Dato062, Dato063, Dato064peso03, Dato065, Dato066, Dato067, Dato068, Dato069 As String
        Dim Dato070, Dato071, Dato072, Dato073, Dato074peso04, Dato075, Dato076, Dato077, Dato078, Dato079 As String
        Dim Dato080, Dato081, Dato082, Dato083, Dato084peso05, Dato085, Dato086, Dato087, Dato088, Dato089 As String
        Dim Dato090, Dato091, Dato092, Dato093, Dato094peso06, Dato095, Dato096, Dato097, Dato098, Dato099 As String
        Dim Dato100, Dato101, Dato102, Dato103, Dato104peso07, Dato105, Dato106, Dato107, Dato108, Dato109 As String
        Dim Dato110, Dato111, Dato112, Dato113, Dato114peso08, Dato115, Dato116, Dato117, Dato118, Dato119 As String
        Dim Dato120, Dato121, Dato122, Dato123, Dato124peso09, Dato125, Dato126, Dato127, Dato128, Dato129 As String
        Dim Dato130, Dato131, Dato132, Dato133, Dato134peso10, Dato135, Dato136, Dato137, Dato138, Dato139 As String
        Dim Dato140, Dato141, Dato142, Dato143, Dato144, Dato145, Dato146, Dato147, Dato148, Dato149 As String

    End Structure

    Structure TablaDeDatosObstetricos
        Dim FechaInicioControl As String
        Dim ObservacionesIniciales As String
        Dim FUR As String
        Dim ParidadInicial As String
        Dim TerminoGestacion As String
        Dim ControlTerminoEn As String
        Dim PesoInicial As String
        Dim IDx As String
        Dim ObservacionesPrivadas As String


        Dim Fecha00, Fecha01, Fecha02, Fecha03, Fecha04, Fecha05, Fecha06, Fecha07, Fecha08 As String
        Dim Fecha09, Fecha10, Fecha11, Fecha12, Fecha13, Fecha14, Fecha15, Fecha16 As String
        Dim Peso00, Peso01, Peso02, Peso03, Peso04, Peso05, Peso06, Peso07, Peso08 As String
        Dim Peso09, Peso10, Peso11, Peso12, Peso13, Peso14, Peso15, Peso16 As String
        Dim TAS00, TAS01, TAS02, TAS03, TAS04, TAS05, TAS06, TAS07, TAS08 As String
        Dim TAS09, TAS10, TAS11, TAS12, TAS13, TAS14, TAS15, TAS16 As String
        Dim TAD00 As String
        Dim TAD01 As String
        Dim TAD02 As String
        Dim TAD03 As String
        Dim TAD04 As String
        Dim TAD05 As String
        Dim TAD06 As String
        Dim TAD07 As String
        Dim TAD08 As String
        Dim TAD09 As String
        Dim TAD10 As String
        Dim TAD11 As String
        Dim TAD12 As String
        Dim TAD13 As String
        Dim TAD14 As String
        Dim TAD15 As String
        Dim TAD16 As String

        Dim Edema00 As String
        Dim Edema01 As String
        Dim Edema02 As String
        Dim Edema03 As String
        Dim Edema04 As String
        Dim Edema05 As String
        Dim Edema06 As String
        Dim Edema07 As String
        Dim Edema08 As String
        Dim Edema09 As String
        Dim Edema10 As String
        Dim Edema11 As String
        Dim Edema12 As String
        Dim Edema13 As String
        Dim Edema14 As String
        Dim Edema15 As String
        Dim Edema16 As String

        Dim AU00 As String
        Dim AU01 As String
        Dim AU02 As String
        Dim AU03 As String
        Dim AU04 As String
        Dim AU05 As String
        Dim AU06 As String
        Dim AU07 As String
        Dim AU08 As String
        Dim AU09 As String
        Dim AU10 As String
        Dim AU11 As String
        Dim AU12 As String
        Dim AU13 As String
        Dim AU14 As String
        Dim AU15 As String
        Dim AU16 As String

        Dim Pres00 As String
        Dim Pres01 As String
        Dim Pres02 As String
        Dim Pres03 As String
        Dim Pres04 As String
        Dim Pres05 As String
        Dim Pres06 As String
        Dim Pres07 As String
        Dim Pres08 As String
        Dim Pres09 As String
        Dim Pres10 As String
        Dim Pres11 As String
        Dim Pres12 As String
        Dim Pres13 As String
        Dim Pres14 As String
        Dim Pres15 As String
        Dim Pres16 As String

        Dim Sit00 As String
        Dim Sit01 As String
        Dim Sit02 As String
        Dim Sit03 As String
        Dim Sit04 As String
        Dim Sit05 As String
        Dim Sit06 As String
        Dim Sit07 As String
        Dim Sit08 As String
        Dim Sit09 As String
        Dim Sit10 As String
        Dim Sit11 As String
        Dim Sit12 As String
        Dim Sit13 As String
        Dim Sit14 As String
        Dim Sit15 As String
        Dim Sit16 As String

        Dim MF00 As String
        Dim MF01 As String
        Dim MF02 As String
        Dim MF03 As String
        Dim MF04 As String
        Dim MF05 As String
        Dim MF06 As String
        Dim MF07 As String
        Dim MF08 As String
        Dim MF09 As String
        Dim MF10 As String
        Dim MF11 As String
        Dim MF12 As String
        Dim MF13 As String
        Dim MF14 As String
        Dim MF15 As String
        Dim MF16 As String

        Dim FF00 As String
        Dim FF01 As String
        Dim FF02 As String
        Dim FF03 As String
        Dim FF04 As String
        Dim FF05 As String
        Dim FF06 As String
        Dim FF07 As String
        Dim FF08 As String
        Dim FF09 As String
        Dim FF10 As String
        Dim FF11 As String
        Dim FF12 As String
        Dim FF13 As String
        Dim FF14 As String
        Dim FF15 As String
        Dim FF16 As String

        Dim Obs00 As String
        Dim Obs01 As String
        Dim Obs02 As String
        Dim Obs03 As String
        Dim Obs04 As String
        Dim Obs05 As String
        Dim Obs06 As String
        Dim Obs07 As String
        Dim Obs08 As String
        Dim Obs09 As String
        Dim Obs10 As String
        Dim Obs11 As String
        Dim Obs12 As String
        Dim Obs13 As String
        Dim Obs14 As String
        Dim Obs15 As String
        Dim Obs16 As String

        Dim Comentarios As String

        Dim FechaLab00, FechaLab01, FechaLab02, FechaLab03, FechaLab04, FechaLab05, FechaLab06, FechaLab07 As String
        Dim Hb00, Hb01, Hb02, Hb03, Hb04, Hb05, Hb06, Hb07 As String
        Dim Hto00, Hto01, Hto02, Hto03, Hto04, Hto05, Hto06, Hto07 As String
        Dim GB00, GB01, GB02, GB03, GB04, GB05, GB06, GB07 As String
        Dim Seg00, Seg01, Seg02, Seg03, Seg04, Seg05, Seg06, Seg07 As String
        Dim Lin00, Lin01, Lin02, Lin03, Lin04, Lin05, Lin06, Lin07 As String
        Dim Mon00, Mon01, Mon02, Mon03, Mon04, Mon05, Mon06, Mon07 As String
        Dim Plaq00, Plaq01, Plaq02, Plaq03, Plaq04, Plaq05, Plaq06, Plaq07 As String
        Dim PT00, PT01, PT02, PT03, PT04, PT05, PT06, PT07 As String
        Dim PTT00, PTT01, PTT02, PTT03, PTT04, PTT05, PTT06, PTT07 As String
        Dim Gli00, Gli01, Gli02, Gli03, Gli04, Gli05, Gli06, Gli07 As String
        Dim Crea00, Crea01, Crea02, Crea03, Crea04, Crea05, Crea06, Crea07 As String
        Dim VDRL00, VDRL01, VDRL02, VDRL03, VDRL04, VDRL05, VDRL06, VDRL07 As String
        Dim HIV00, HIV01, HIV02, HIV03, HIV04, HIV05, HIV06, HIV07 As String
        Dim Tox00, Tox01, Tox02, Tox03, Tox04, Tox05, Tox06, Tox07 As String
        Dim Tipiaje00, Tipiaje01, Tipiaje02, Tipiaje03, Tipiaje04, Tipiaje05, Tipiaje06, Tipiaje07 As String
        Dim Coombs00, Coombs01, Coombs02, Coombs03, Coombs04, Coombs05, Coombs06, Coombs07 As String
        Dim TipiajeEsp00, TipiajeEsp01, TipiajeEsp02, TipiajeEsp03, TipiajeEsp04, TipiajeEsp05, TipiajeEsp06, TipiajeEsp07 As String
        Dim OtroExA, OtroExA00, OtroExA01, OtroExA02, OtroExA03, OtroExA04, OtroExA05, OtroExA06, OtroExA07 As String
        Dim OtroExB, OtroExB00, OtroExB01, OtroExB02, OtroExB03, OtroExB04, OtroExB05, OtroExB06, OtroExB07 As String
        Dim OtroExC, OtroExC00, OtroExC01, OtroExC02, OtroExC03, OtroExC04 As String
        'Adicionales porsia
        Dim NombreDelControl As String
        Dim Adicional01 As String
        Dim ImpresionDx As String
        Dim Orina, Urocultivo, Heces As String


    End Structure

    Structure TablaDeDatosEcograficos

        'Comunes a los tres informes
        Dim c00TipoDeEstudio As String
        Dim c01FechaControl As String
        Dim c02Paridad As String
        Dim c03FUR As String
        Dim c04FPP As String
        Dim c05EGxFUR As String
        Dim c06IDx As String
        Dim c07Nombre As String
        Dim c08Edad As String
        '-----------------------
        'los del 1er trimestre. 
        '------------------------
        Dim d01SGlongitudinal As String
        Dim d02SGanteroposterior As String
        Dim d03SGtransversal As String
        Dim d04LCC As String
        Dim d05ImplatacionSG As String
        Dim d06EmbrionVisible As String
        Dim d07MovimientosPresentes As String
        Dim d08ActividadCardiaca As String
        Dim d09Comentarios1erT As String
        'adicionales en medidas de 1er trimestre para compatibilidad y expansion futura
        Dim d10OtroA As String 'OJO AQUI SE ESTABAN GUARDANDO EL ENCABEZADO DE LAS FOTOS
        Dim d11AdicionalesB1erT As String
        Dim d12IDxAdicionales1erT As String 'se guardan el chorizo diagnostico del comen y la idx del 1erT
        Dim d13Adicionales1erT As String 'se guardan los 1ros adicionales del 1er T
        'resultados de calculos
        Dim r01SGPromedio As String
        Dim r02EGxSG As String
        Dim r03EGxLCC As String
        Dim r04EG1erT As String
        '--------------------------
        '= estos son los datos del 2 y 3er trimestre
        '--------------------------
        'anatomicos
        Dim e01Presentacion As String
        Dim e02Situacion As String
        Dim e03Posicion As String
        Dim e04Cabeza As String
        Dim e05Ventriculos As String
        Dim e06Columna As String
        Dim e07Torax As String
        Dim e08Corazon As String
        Dim e09Abdomen As String
        Dim e10Riñones As String
        Dim e11Extremidades As String
        Dim e12Notas01del2y3erT As String
        'biometricos
        Dim e13DiametroBiParietal As String
        Dim e14DiametroOccipitoFrontal As String
        Dim e15DiametroAnteroPosteriorTorax As String
        Dim e16DiametroAnteroPosteriorCorazon As String
        Dim e17aDiametroAnteroPosteriorAbdomen As String
        Dim e17bDiametroTransversoAbdomen As String
        Dim e18Aorta As String
        Dim e19VenaCava As String
        Dim e20LongitudSacro As String
        Dim e21LongitudFemur As String
        'funcionales
        Dim e22Actitud As String
        Dim e23Tono As String
        Dim e24MovimientosFetales As String
        Dim e25ActividadCardiaca As String
        Dim e26MovimientosRespiratorios As String
        Dim e27RelacionAortoCava As String
        Dim e28CamaraGastrica As String
        Dim e29Intestino As String
        Dim e30Vejiga As String
        Dim e31Notas02del2y3erT As String
        'Placentarios
        Dim e32LocalizacionPlacenta As String
        Dim e33GrosorPlacenta As String
        Dim e34GradoPlacenta As String
        'liquido amniotico
        Dim e35LiquidoAmniotico As String
        Dim e36ILA As String
        Dim e37CordonUmbilical As String
        Dim e38Notas03del2y3erT As String
        'adicionales usados en la modificacion de octubre 2007 feto y embarazo
        Dim e39Embarazo As String
        Dim e40Feto As String
        Dim e41BiometricosAdicionales As String 'aqui se guardara el chorizo de datos biometricos de la modificacion
        'adicionales usados en la parte anatomica
        Dim e42Rostro As String
        Dim e43Sexo As String
        'resultados de calculos
        Dim r05DBPc As String
        Dim r06CirCef As String
        Dim r07IndCef As String
        Dim r08CirAbd As String
        Dim r09DBF As String
        Dim r10EGxDBP As String
        Dim r11EGxDBPc As String
        Dim r12EGxCC As String
        Dim r13EGxCA As String
        Dim r14EGxFemur As String
        Dim r15PesoEstimado As String
        Dim r16PesoenBaseA As String
        Dim r17EG2y3erT As String
        '----------------------
        'Informe ginecologico
        '----------------------
        Dim f01Menopausia As String
        Dim f02EstudioPorVia As String 'via transvaginal (1) abdominal (2)
        Dim f03UteroLongitudinal As String
        Dim f04UteroAnteroposterior As String
        Dim f05UteroTransverso As String
        Dim f06OvarioDerechoLongitudinal As String
        Dim f07OvarioDerechoTransverso As String
        Dim f08OvarioDerechoAnteroPosterior As String
        Dim f09OvarioIzquierdoLongitudinal As String
        Dim f10OvarioIzquierdoTransverso As String
        Dim f11OvarioIzquierdoAnteroPosterior As String
        Dim f12FoliculoDerecho01 As String
        Dim f13FoliculoDerecho02 As String
        Dim f14FoliculoDerecho03 As String
        Dim f15FoliculoDerecho04 As String
        Dim f16FoliculoIzquierdo01 As String
        Dim f17FoliculoIzquierdo02 As String
        Dim f18FoliculoIzquierdo03 As String
        Dim f19FoliculoIzquierdo04 As String
        Dim f20EndometrioGrosor As String
        Dim f21ObsGinecologicas As String
        'adicionales porsia
        Dim f22OtrosA As String
        Dim f23OtrosB As String
        Dim f24OtrosC As String
        Dim f25AdicionalesGin As String
        'resultados de calculos en ginecologico
        Dim r18DiaCiclo As String
        'adicionales para calculos porsia
        Dim r19OtroA As String
        Dim r20OtroB As String
        Dim r21OtroC As String
        Dim e44ChorizoDiagnostico As String
        'empiezo a usar los adicionales
        Dim c09NombreInforme As String
    End Structure

    'para recolectar la info de los laboratorios x fechas en control obstetrico
    Structure TablaDeLaboratorio
        Dim a01Hb As String
        Dim a02Hto As String
        Dim a03GB As String
        Dim a04Seg As String
        Dim a05Lin As String
        Dim a06Mon As String
        Dim a07Plaq As String
        Dim a08Pt As String
        Dim a09Ptt As String
        Dim a10Gli As String
        Dim a11Crea As String
        Dim a12VDRL As String
        Dim a13HIV As String
        Dim a14Tox As String
        Dim a15Tipiaje As String
        Dim a16Coombs As String
        Dim a17Ph As String
        Dim a18Densidad As String
        Dim a19Bacterias As String
        Dim a20Leucocitos As String
        Dim a21AcumLeuco As String
        Dim a22Hematies As String
        Dim a23Cristales As String
        Dim a24GramBaterias As String
        Dim a25GramLeucocitos As String
    End Structure

    Structure TablaDeResultadosDeLaboratorioDeLaFecha
        Dim a01strHemato As String
        Dim a02strOrina As String
        Dim a03strGram As String
    End Structure

    Structure OrdenPaciente
        Dim NumeroHistoria As String
        Dim NombrePaciente As String
        Dim CedulaPaciente As String
    End Structure
    Dim OP As New TablaDePacientesBDH

    Dim arrayPacientesFiltrados As New ArrayList()

    Structure DatosComplementarios
        Dim a01Notas As String
        Dim a02Resumen As String
        Dim a03NumeroDelReferidor As String 'el numero de historia si es paciente o el numero del otro referidor....
        Dim a04Vinculos As String
        Dim a05ReferidaPor As String
        Dim a06TelefonoVerificado As String
        Dim a07UltimoSMS As String
        Dim a08TipoDeReferidor As String
        Dim a09VinculoConReferidor As String
        Dim a10 As String
    End Structure
    Public Shared PSstrArchivoDatosComplementarios As String

    'tabla para los archivos de referidas por una paciente o por otros referidores
    Structure TablaDeReferidas
        Dim a01NumeroHistoria As String
        Dim a02Nombre As String
        Dim a03Cedula As String
        Dim a04FechaDeReferenciaSDS As String
        Dim b01 As String
        Dim b02 As String
    End Structure

    'tabla de otros referidores
    Structure TablaDeOtrosReferidores
        Dim a01NumeroID As String
        Dim a02Nombre As String
        Dim b01 As String
        Dim b02 As String
        Dim b03 As String
    End Structure

    Structure EstructuraGuardias
        Dim a01Fecha As String
        Dim a02Lugar1 As String
        Dim a03Descripcion1 As String
        Dim a04Lugar2 As String
        Dim a05Descripcion2 As String
        Dim a06Lugar3 As String
        Dim a07Descripcion3 As String
        Dim a08 As String
        Dim a09 As String
        Dim a10 As String
    End Structure

    Dim GU As New EstructuraGuardias

    Structure TablaDeIntervenciones
        Dim a01Fecha As String
        Dim a02NombrePaciente As String
        Dim a03EdadPaciente As String
        Dim a04TipoIntervencion As String
        Dim a05RolEnLaIntervencion As String
        Dim a06Medico01 As String
        Dim a07RolMedico01 As String
        Dim a08Medico02 As String
        Dim a09RolMedico02 As String
        Dim a10Lugar As String
        Dim a11FormaDePago As String
        Dim a12PagoEfectuado As String
        Dim a13HonorariosEstimados As String
        Dim a14HonorariosNetosPagados As String
        Dim a15Notas As String
        Dim a16FechaDeNacimiento As String
        Dim a17Cedula As String
        Dim b03OtrosC As String
        Dim b04OtrosD As String
        Dim b05OtrosE As String
    End Structure

    'variables publicas de todo el programa
    Public Shared PSstrPacienteSeleccionadaNombre As String = ""
    Public Shared PSstrPacienteSeleccionadaCedula As String = ""
    Public Shared PSdatPacienteSeleccionadaFechaDeNacimiento As Date
    Public Shared PSintPacienteSeleccionadaEdad As Integer
    Public Shared PSstrPacienteSeleccionadaDireccion As String
    Public Shared PSstrPacienteSeleccionadaCelular As String

    'estructura publica con su est para los recipes ya que pueden estar abiertos sin estar abierta una historia y si hay una paciente seleccionada q no abierta tambien muestran sus datos
    Structure TablaDePacienteConHistoriaAbierta
        Dim a01strNombre As String
        Dim a02strCedula As String
        Dim a03datFechaDeNacimiento As Date
        Dim a04intEdadActual As Integer
        Dim a05strParidad As String
        Dim a06strDireccion As String
        Dim a07strCelular As String
    End Structure
    Public Shared estPacienteAbierta As New Form1.TablaDePacienteConHistoriaAbierta

    Public Shared PSstrNumeroHistoriaSeleccionada As String = ""
    Public Shared PSstrPrefijoHistoriaSeleccionada As String = ""
    Public Shared PSstrPathHistoriasConPrefijo As String
    Public Shared PSstrPathHistoriasSinPrefijo As String
    Public Shared PathImagenesSinPrefijo As String
    Public Shared PathImagenes As String

    Public Shared PSstrPathAgendaBDH As String
    Public Shared PathAgendaControlesActual As String
    Public Shared PathAgendaControlesConsulta As String
    Public Shared PathIQ As String
    Public Shared PathPago As String
    Public Shared AnotaTrueBorraFalseEnLaAgenda As Boolean
    Public Shared EsLaUltimaConsultaLaSeleccionada As Boolean




    Public Shared NumeroDeHistoriaCompleto As String
    Public Shared NumerodeHistoriasActuales As Integer

    Public Shared ExisteDatosPersonales As Boolean
    Public Shared ExisteControlGinecologico2 As Boolean
    Public Shared NumeroHistoriasObstetricas As Integer
    Public Shared ExisteControlObstetrico As Boolean
    Public Shared ExistenImagenesEcograficas As Boolean
    Public Shared CreaNuevoControlObstetrico As Boolean
    Public Shared ExisteControlEcografico As Boolean
    Public Shared VademecumAbierto As Boolean
    Public Shared RecipesAbierto As Boolean
    Public Shared AgendaAbierta As Boolean
    Dim IniciandoAplicacion As Boolean

    Dim Filtro As Boolean
    Dim IndiceHistoriaAbierta As Integer = 0


    '================
    'variables de respaldo a flopy
    'version 2
    Public Shared BaseModificada As String
    Public Shared DirBaseModificada As String
    Public Shared HoraDeAccesoaLaBase As Date
    Public Shared SeModificaronDatos As Boolean
    '===============================

    'Variables de la parte de la numeracion de las historias y password
    Public Shared NumPrefijo As String
    Public Shared NumNumero As Int64
    Public Shared NumTieneSufijo As Boolean
    Public Shared NumIncremento As Int64
    Public Shared NumPassword As Int64
    Public Shared BaseDatosINI As String
    Public Shared TipoDeContraseña As Integer
    Public Shared ContraseñaCorrecta As Boolean
    '====================================================

    'Variables de la parte de la Agenda
    'variables de archivos principales
    Public Shared ArchivoPropioAGD, ArchivoIndice, ArchivoIndiceProximos As String
    Public Shared ArchivoControlDiario, ArchivoControlMensual, ArchivoControlAnual As String

    'variable para seleccion automatica de la fecha inicial de la ventana de Intervenciones
    Public Shared dateFechaDeInicioParaModificarIntervenciones As Date

    'variables de Respaldo de archivos
    Public Shared ArchivoPropioAgdBAK As String
    Public Shared ArchivoIndiceBAK As String
    Public Shared ArchivoIndiceProximosBAK As String
    Public Shared ArchivoControlDiarioBAK As String
    Public Shared ArchivoControlMensualBAK As String
    Public Shared ArchivoControlAnualBAK As String

    Public Shared FechaPendienteProximaConsulta As Date
    Public Shared PendienteConsulta As Boolean

    'variables publicas de direccion al ecografia y control ob para datos autogenerados
    Public Shared strArchivoControlObstetricoDelPteSeleccionado As String = ""
    Public Shared strArchivoControlEcograficoDelPteSeleccionado As String = ""

    'variables de la seleccion de fecha
    Public Shared FechaSeleccionada As Date
    Public Shared FechaSeleccionadaMensaje As String

    'variables para la seleccion del nombre de la serie u otra cosa
    Public Shared NombreElegido As String
    Public Shared NombreElegidoMensaje As String
    Public Shared NombreElegidoTitulo As String

    'variables publicas para el intercambio de EF en los chorizos
    Public Shared ExamenFisicoCodificado As String
    Public Shared ExamenFisicoTraducido As String

    'variables publicas para la ventan de texto multiple
    Public Shared TextoIntercambio As String
    Public Shared TextoIntercambio2 As String
    Public Shared TextoIntercambio3 As String
    Public Shared TituloVentanaDeTexto As String
    Public Shared TamañoDeLetra As Integer
    Public Shared EsUnRecipe As Boolean
    'variables para el intercambio de texto local de procedure
    Dim TextoEnVentana As String
    Dim TituloEnVentana As String
    Dim LargoEnVentana As Integer

    'variables publicas para la ventana de recopilacion de datos de doppler
    Public Shared PS_strTipoDeDatoMostrado As String
    Public Shared PS_strRecopilacionDatos As String
    Public Shared PS_strArchivoDeDatosRecopilados As String

    'variables publicas para la ventana de resumen del control
    Public Shared PS_strResumenDelControl As String

    'variables underground
    Public Shared PS_booMuestraOcultos As Boolean = False
    Dim booPrevioMuestraOcultos As Boolean = False

    'variables para el informe ecografico
    Public Shared Informe01TipoInforme As String
    Public Shared Informe02VeReglas As Boolean
    Public Shared Informe03ConoceFUR As Boolean
    Public Shared Informe04FUR As Date
    Public Shared Informe05Trimestre As String
    Public Shared Informe06Nombre As String

    Public Structure TablaDeArchivosPropiosDeAgenda
        'es la de los archivos #historia.agd
        Dim a10FechaConsulta As String
        Dim a02Clinica As String
        Dim a03NotaseIDx As String
        Dim a04Tratamiento As String
        Dim a05Pendiente As String
        Dim a06ProximaConsulta As String
        Dim a07Honorarios As String
        Dim a11FacturaAsociada As String
        Dim a16Referencia As String
        Dim a15Banco As String
        Dim a14FormaDePago As String
        Dim a13FechaDePago As String
        Dim a12Pagador As String
    End Structure

    Public Structure TablaDeArchivosIndiceControlesAGD
        'es la de los indices de los controles realizados "IndiceControles.AGD"
        Dim a01Fecha As String
        Dim a02NumeroHistoria As String
        Dim a03Nombre As String
    End Structure

    Public Structure TablaDeArchivosDeAgendaControlDiarioMensualAnual
        'es la de los archivos de controles realizados: diarios, mensuales y anuales
        ' diarios: "[C]+[fechacontrolde8dig]+[.AGD]" ej. C20040310.agd
        ' Mensuales: "[C]+[fechacontrolde6dig]+[.AGD]" ej. C200403.agd
        ' anuales: "[C]+[fechacontrolde4dig]+[.AGD]" ej. C2004.agd
        Dim a01NumeroHistoria As String
        Dim a02Nombre As String
        Dim a03Cedula As String
        Dim a04Clinica As String
        Dim a05NotaseIDx As String
        Dim a06Tratamiento As String
        Dim a07Pendiente As String
        Dim a08ProximaConsulta As String
        Dim a09Honorarios As String
        Dim a10FechaConsulta As String
        Dim a11FacturaAsociada As String
        Dim a16Referencia As String
        Dim a15Banco As String
        Dim a14FormaDePago As String
        Dim a13FechaDePago As String
        Dim a12Pagador As String
    End Structure


    Public Structure TablaDeArchivosDeProximosControles
        'es la de los proximos controles: 
        ' "[P]+[fechaproximocontrolde8dig]+[.AGD]" ej. P20040310.agd
        Dim a01NumeroHistoria As String
        Dim a02Nombre As String
        Dim a03Cedula As String
        Dim a04ClinicaUltimoControl As String
        Dim a05NotaseIDxUltimoControl As String
        Dim a06TratamientoUltimoControl As String
        Dim a07Pendiente As String
        Dim a08FechaUltimoControl As String
        Dim a09HonorariosUltimoControl As String
        Dim a10FechaProximoControl As String
    End Structure

    Public Structure TablaDeArchivosDeIndiceDeProximosControles
        'es la de los indices de los proximos controles: "IndiceProximos.AGD"
        Dim a01FechaProximocontrol As String
        Dim a02NumeroHistoria As String
        Dim a03Nombre As String
    End Structure

    Public Structure TablaDePagos
        Dim a00strIndice As String
        Dim a01datFecha As String
        Dim a02strPagador As String
        Dim a03strMedioDePago As String
        Dim a04strBanco As String
        Dim a05strNumeroReferencia As String
        Dim a06intFacturaAsociada As String
        Dim a06bStrFacturero As String
        Dim a07decRetencionISLR As String
        Dim a08decRetencionADM As String
        Dim a09decRetencionOTROS As String
        Dim a10decMontoNetoPagado As String
        Dim a11decTotalPago As String
        Dim a12booIncluidoEnFacturacion As String
        Dim a13strNotas As String
        Dim a14Rif As String
        Dim b01 As String
        Dim b02 As String
        Dim b03 As String
        Dim b04 As String

    End Structure

    'variables de structura y array correspondientes nuevas en pantalla
    Dim Tipo01 As TablaDeArchivosPropiosDeAgenda
    Dim Tipo02 As TablaDeArchivosIndiceControlesAGD
    Dim Tipo03 As TablaDeArchivosDeAgendaControlDiarioMensualAnual
    Dim Tipo04 As TablaDeArchivosDeProximosControles
    Dim Tipo05 As TablaDeArchivosDeIndiceDeProximosControles

    Dim Array01 As New ArrayList()
    Dim Array02 As New ArrayList()
    Dim Array03 As New ArrayList()
    Dim Array04 As New ArrayList()
    Dim Array05 As New ArrayList()
    '0000000000000000000000000000000000000000000000000000000000

    'variables de imagen para los botones
    Public Shared BotonOn As Image
    Public Shared BotonOff As Image
    Public Shared BotonOnGrande As Image
    Public Shared BotonOffGrande As Image
    Public Shared BarraSinMensaje As Image
    Public Shared BarraMensajeBien As Image
    Public Shared BarraMensajeMal As Image
    Public Shared FlechaIzqOff, FlechaIzqOn As Image
    Public Shared FlechaDerOff, FlechaDerOn As Image
    Public Shared BotoncitoOn As Image
    Public Shared BotoncitoOFF As Image
    Public Shared FlechitaArribaOFF, FlechitaArribaON As Image
    Public Shared FlechitaAbajoOFF, FlechitaAbajoON As Image
    Public Shared imagenLogoDelUsuario As Image


    Public Shared SeBorraronImagenes As Boolean = False

    'variables publicas de datos del usuario
    Public Shared UsuarioNombre As String
    Public Shared UsuarioEspecialidad As String
    Public Shared UsuarioDir01 As String
    Public Shared UsuarioDir02 As String
    'Public Shared UsuarioImagen As String
    Public Shared PathDatosDelUsuario As String
    Public Shared ArchivoDatosDelUsuario As String
    Public Shared ArchivoImagenDelUsuario As String
    Public Shared ArchivoImagenDelUsuarioTemporal As String
    Public Shared booSeDebeActualizarImagenDelUsuarioAlCerrar As Boolean = False
    Public Shared ArchivoImagenDelUsuarioNuevo As String
    Public Shared ArchivoDatosDeAniversario As String
    Public Shared ArchivoGuardiasDelUsuario As String
    'Public Shared PathArchivoHIS As String
    Public Shared booExistenDatosDelUsuario As Boolean = False
    Public Shared BaseDeDatosCargada As Boolean

    Dim SeCargaronLosDatosDeAniversario As Boolean = False ' para saber si se deben carga o no los cumpleaños
    Public Shared booFechaNacimientoModificada As Boolean = False

    Public Shared TooltipFechaNacimiento As String
    Public Shared TooltipEdad As String
    Public Shared TooltipParidad As String
    Public Shared TooltipTelefono As String
    Public Shared TooltipPteDesde As String
    Public Shared TooltipConsultasTotales As String
    Public Shared TooltipUltimaConsulta As String
    Public Shared TooltipHonorariosTotales As String
    Public Shared TooltipReferencias As String
    Public Shared TooltipReferidaPor As String
    Public Shared TooltipVinculos As String

    Dim ToolTipNombrePaciente As New ToolTip
    Dim TooltipNumeroHistoria As New ToolTip
    Dim TooltipCedulaPaciente As New ToolTip

    Dim TooltipMensajeNombrePaciente As String = ""
    Dim TooltipMensajeNumeroHistoria As String = ""
    Dim TooltipMensajeCedulaPaciente As String = ""

    'para ubicar automaticamente la FUR cuando se esta creando un informe ecografico
    Public Shared datFURactiva As Date = Nothing
    Public Shared booSeleccionandoFechaParaControlEcografico As Boolean = False

    Public Shared strParidadActiva As String = ""

    'para los ecos creados a partir del control obstetrico
    Public Shared booSeCargoDesdeControlObs As Boolean = False
    Public Shared booEsUnEcoNuevo As Boolean = False
    Public Shared dateFechaInicioInformeSeleccionado As Date

    'para la ventanita de seleccion de nombre (form Nueva serie)
    Public Shared booSeEstaCreandoUnNuevoControlObstetrico As Boolean

    'variables para elementos de titulares de la base de datos
    Public Structure estTitularesDeLaBase
        Dim a01strNotasPendientes As String
        Dim a02strProximasIntervenciones As String

    End Structure

    Public Shared booSeDebeActualizarAgenda As Boolean = False

    'variables para saber cuando se debenactualizar datos de la pte
    Dim booEsNecesarioVerificarParidad As Boolean = False
    Dim booEsNecesarioVerificarCelular As Boolean = False
    Public Shared PSbooSeModificoElTelefono As Boolean = False


    'parte 2010 variables publicas para consultar en los form y volver con informacion puntual
    Public Shared PSbooConsultaAntecedentesObstetricos As Boolean
    'variables publicas q sirven en todo el programa desde donde se llamen
    Public Shared PSstrResultadoAntecedentesObstetricos As String
    Public Shared PSstrPacienteSeleccionadaParidad As String = " " 'para q no sea igual a nada y la 1ra vez no embrome
    Public Shared PSintPesoMaximo As Integer

    Public Shared PSbooConsultaAntecedentesPersonales As Boolean
    Public Shared PSstrResultadoAntecedentesPersonales As String

    Public Shared PSbooConsultaAntecedentesFamiliares As Boolean
    Public Shared PSstrResultadoAntecedentesFamiliares As String

    Public Shared PSbooConsultaAntecedentesGinecologicos As Boolean
    Public Shared PSstrResultadoAntecedentesGinecologicos As String

    Public Shared PSbooConsultaAntecedentesQuirurgicos As Boolean
    Public Shared PSstrResultadoAntecedentesQuirurgicos As String

    'bandera para saber si se abre una consulta normalmente o desde la vista de agenda
    Public Shared PSbooEdicionRapidaDeLaConsulta As Boolean

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Form1.booSeDebeActualizarImagenDelUsuarioAlCerrar = True Then
            ' se debe actualizar el archivo de imgen de logo de la base abierta
            Try
                File.Copy(Form1.ArchivoImagenDelUsuarioNuevo, ArchivoImagenDelUsuario, True)
            Catch ex As Exception
                MsgBox("No se pudo Guardar la nueva imagen del Logo del Usuario. Reinicia el Programa e intentalo nuevamente sin abrir multiples veces la misma base de datos...", MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub CompruebaArchivo()

        Dim DLG As New formContraseña()

        Dim Y As Date
        Dim NumeroPC As String
        Dim NumeroInicial As Long
        Dim Parte(3) As String
        Dim ParteLong(3) As Long
        Dim Resultado As Long


        Dim DirSistema As String
        Dim ArchivoDLL As String
        Dim BW As BinaryWriter
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim Clave As String
        Dim ClaveLong As Long



        DirSistema = Environment.SystemDirectory
        ArchivoDLL = PSstrDirectorioDeLaAplicacion & "\hc.his"

        If Directory.Exists(DirSistema) Then
            Y = Directory.GetCreationTime(DirSistema)
            NumeroPC = Y.Ticks.ToString
            NumeroPC = NumeroPC.Substring(8, 10)

            Parte(0) = NumeroPC.Substring(0, 4)
            Parte(1) = NumeroPC.Substring(2, 4)
            Parte(2) = NumeroPC.Substring(4, 2)
            Parte(3) = NumeroPC.Substring(6, 2)

            'verificacion
            If Parte(0) = "0000" Then Parte(0) = "5555"
            If Parte(1) = "0000" Then Parte(1) = "5555"
            If Parte(2) = "00" Then Parte(2) = "55"
            If Parte(3) = "00" Then Parte(3) = "55"

            'pasa a long
            NumeroInicial = CType(NumeroPC, Long)
            ParteLong(0) = CType(Parte(0), Long)
            ParteLong(1) = CType(Parte(1), Long)
            ParteLong(2) = CType(Parte(2), Long)
            ParteLong(3) = CType(Parte(3), Long)


            Resultado = NumeroInicial + ParteLong(0)
            Resultado = Resultado * ParteLong(2)
            Resultado = Resultado - ParteLong(1)
            Resultado = Resultado * ParteLong(3)
        End If


        If File.Exists(ArchivoDLL) = False Then
            'no existe el archivo busca la intro de la clave
            'MsgBox("paso donde se ve que no existe el dll")
            If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
                'se acepto una clave, la verifica
                'MsgBox("volvio de formcontraseña con un ok")
                ClaveLong = formContraseña.Contraseña

                If ClaveLong = Resultado Then
                    'MsgBox("el resultado fue igualk a la clave")
                    'esta bien crea el archivo y escribe la clave
                    FS = New FileStream(ArchivoDLL, FileMode.Create, FileAccess.Write)
                    BW = New BinaryWriter(FS)
                    BW.BaseStream.Seek(0, SeekOrigin.Begin)
                    BW.Write(ClaveLong)
                    FS.Close()
                    BW.Close()
                    Dim creacion As Date = Now
                    Dim acceso As Date = Now
                    Dim escritura As Date = Now
                    creacion = creacion.AddMonths(-6)
                    acceso = acceso.AddMonths(-6)
                    escritura = escritura.AddMonths(-6)
                    File.SetCreationTime(ArchivoDLL, creacion)
                    File.SetLastWriteTime(ArchivoDLL, escritura)
                    File.SetLastAccessTime(ArchivoDLL, acceso)
                    MsgBox("El programa ha sido Activado...")
                    ClaveOK()
                Else
                    'MsgBox("la clave introducida fue iuncorrecta")
                    ClaveIncorrecta()
                End If
            Else
                'MsgBox("volvio del procedimiento contraseña con un NO")
                ClaveAusente()
            End If
        Else
            'existe el archivo lo lee y lo verifica
            'MsgBox("existe el archivo dll")
            FS = New FileStream(ArchivoDLL, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim C As Integer
            C = BR.PeekChar
            'Clave = ""
            'While FS.Position < FS.Length
            'ClaveLong = BR.ReadInt64
            'C = BR.PeekChar
            'End While

            ClaveLong = BR.ReadInt64

            BR.Close()
            FS.Close()

            'MsgBox("abrio y leyo el dll la clave es: " & Clave)

            If ClaveLong = Resultado Then
                'todo bien, sigue sin decir nada
                'MsgBox("la clave es correcta sigue con el programa")
                ClaveOK()
            Else
                MsgBox("El Código de Activación no es válido.", MsgBoxStyle.Information)
                If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
                    'se acepto una clave, la verifica
                    Clave = formContraseña.Contraseña
                    If IsNumeric(Clave) Then
                        ClaveLong = CType(Clave, Long)
                    Else
                        ClaveIncorrecta()
                    End If

                    If ClaveLong = Resultado Then
                        'esta bien crea el archivo y escribe la clave
                        FS = New FileStream(ArchivoDLL, FileMode.Create, FileAccess.Write)
                        BW = New BinaryWriter(FS)
                        BW.BaseStream.Seek(0, SeekOrigin.Begin)
                        BW.Write(Clave)
                        FS.Close()
                        BW.Close()
                        Dim creacion As Date = Now
                        Dim acceso As Date = Now
                        Dim escritura As Date = Now
                        creacion = creacion.AddMonths(-6)
                        acceso = acceso.AddMonths(-6)
                        escritura = escritura.AddMonths(-6)
                        File.SetCreationTime(ArchivoDLL, creacion)
                        File.SetLastWriteTime(ArchivoDLL, escritura)
                        File.SetLastAccessTime(ArchivoDLL, acceso)
                        MsgBox("El programa ha sido activado...")
                        ClaveOK()
                    Else
                        ClaveIncorrecta()
                    End If
                Else
                    ClaveAusente()
                End If
            End If





        End If
    End Sub

    Private Sub ClaveIncorrecta()
        MsgBox("Código de Activación Incorrecto")
        Me.Close()
    End Sub

    Private Sub ClaveOK()
        'MsgBox("paso por el proc clave ok")
        ConfiguracionBaseDatosNoCargada()
        'MsgBox("cargo el procedimiento base de datos no cargada")
    End Sub

    Private Sub ClaveAusente()
        'no selecciono nada
        'MsgBox("no selecciono clave")
        Me.Close()
    End Sub

    Private Sub Aplicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Size = New System.Drawing.Size(1010, 710)
        PSstrDirectorioDeLaAplicacion = Directory.GetCurrentDirectory
        CargaImagenesDeLosBotones()
        MuestraPresentacion()
        'CompruebaArchivo()
        ClaveOK()
        subInicializaTooltips()

    End Sub

    Private Sub CargaImagenesDeLosBotones()
        'carga las imagenes de graficos para los botones
        BotonOn = FormImagenes.picBotonOn.Image
        BotonOff = FormImagenes.picBotonOff.Image
        BotonOnGrande = FormImagenes.picBotonOnGrande.Image
        BotonOffGrande = FormImagenes.picBotonOffGrande.Image
        BarraSinMensaje = FormImagenes.picBarraSinMensaje.Image
        BarraMensajeBien = FormImagenes.picBarraMensajeBien.Image
        BarraMensajeMal = FormImagenes.picBarraMensajeMal.Image
        FlechaDerOff = FormImagenes.picFlechaDerOff.Image
        FlechaDerOn = FormImagenes.picFlechaDerOn.Image
        FlechaIzqOff = FormImagenes.picFlechaIzqOff.Image
        FlechaIzqOn = FormImagenes.picFlechaIzqOn.Image
        BotoncitoOFF = FormImagenes.picBotoncitoOff.Image
        BotoncitoOn = FormImagenes.picBotoncitoOn.Image
        FlechitaAbajoOFF = FormImagenes.picFlechitaAbajoOff.Image
        FlechitaAbajoON = FormImagenes.picFlechitaAbajoOn.Image
        FlechitaArribaOFF = FormImagenes.picFlechitaArribaOff.Image
        FlechitaArribaON = FormImagenes.picFlechitaArribaOn.Image
    End Sub
    Private Sub MuestraPresentacion()
        Dim DLG As New FormPresentacion()
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'sigue
        End If
    End Sub
    Private Sub subInicializaTooltips()
        'contruye los datos formateados ara los tooltips
        'NOMBREPACIENTE
        ' Set up the delays for the ToolTip.
        ToolTipNombrePaciente.AutoPopDelay = 30000
        ToolTipNombrePaciente.InitialDelay = 250
        ToolTipNombrePaciente.ReshowDelay = 250
        ' Force the ToolTip text to be displayed whether or not the form is active.
        ToolTipNombrePaciente.ShowAlways = True
        ' Set up the ToolTip text for the Button and Checkbox.
        'toolTipNombrePaciente.SetToolTip(Me.LabNombreSeleccionado, TooltipMensajeNombrePaciente)

        'NUMEROHISTORIA
        ' Set up the delays for the ToolTip.
        TooltipNumeroHistoria.AutoPopDelay = 30000
        TooltipNumeroHistoria.InitialDelay = 250
        TooltipNumeroHistoria.ReshowDelay = 250
        ' Force the ToolTip text to be displayed whether or not the form is active.
        TooltipNumeroHistoria.ShowAlways = True
        ' Set up the ToolTip text for the Button and Checkbox.
        'TooltipNumeroHistoria.SetToolTip(Me.LabNumeroSeleccionado, TooltipMensajeNumeroHistoria)

        'CEDULAPACIENTE
        ' Set up the delays for the ToolTip.
        TooltipCedulaPaciente.AutoPopDelay = 30000
        TooltipCedulaPaciente.InitialDelay = 250
        TooltipCedulaPaciente.ReshowDelay = 250
        ' Force the ToolTip text to be displayed whether or not the form is active.
        TooltipCedulaPaciente.ShowAlways = True
        ' Set up the ToolTip text for the Button and Checkbox.
        'TooltipNumeroHistoria.SetToolTip(Me.LabNumeroSeleccionado, TooltipMensajeNumeroHistoria)

    End Sub

    Private Sub Form1Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'se ejecuta cada vez que la ventana principal toma el foco
        If VademecumAbierto = True Then
            MenuItemVademecum.Enabled = False
        Else
            MenuItemVademecum.Enabled = True
        End If
        If RecipesAbierto = True Then
            MenuItemRecipes.Enabled = False
        Else
            MenuItemRecipes.Enabled = True
        End If
        If AgendaAbierta = True Then
            MenuItemAgenda.Enabled = False
        Else
            MenuItemAgenda.Enabled = True
        End If

        If Form1.UsuarioNombre <> Nothing Then
            'actualiza el titulo de la ventana ppal
            Me.Text = "Historias Clínicas - " & UsuarioNombre & " - " & Today.ToLongDateString
        End If

        If Form1.booSeDebeActualizarAgenda = True Then 'se actualizo la agenda sea con historia abierta normal o desde la propia agenda con historia cerrada

            'ahora verifica si hay una historia abierta...
            If Form1.PSbooHistoriaAbierta = True Then 'hay una historia abierta

                'refresca datos nuevos si los hay
                subInicializaAgenda()
                'carga y muestra las consultas archivadas si las hay en la pagina de historia seleccionada
                subCargaArchivoPropioAGD()
                subMuestraFechasDeConsultasDelPaciente()
                'se deben actualizar los campos de los DC referentes a la agenda los otros no pueden cambiar por lo q no se buscan
                subRefrescaEnPantallaLosDatosDeAgenda()
                'vuelve a poner la fecha de hoy como base para que calcule bien las citas prox y perdidas
                PSdateFechaDeArraqueDeAgenda = Today

            Else 'no hay historia abierta se debe haber modificado la agenda directamente desde la misma con el boton edita consulta.

                'como no hay nada abierto no se actualiza la pantalla
            End If

            'sea q haya una historia abierta o no apaga bandera
            Form1.booSeDebeActualizarAgenda = False

        End If


    End Sub

    Private Sub subRefrescaEnPantallaLosDatosDeAgenda()

        Dim txt As String = ""
        Dim SinDatos As String = "Dato no introducido en la base de datos"
        Dim SinDatosCorto As String = "Dato no introducido"

        'ojo variables locales para hacer un peek en los archivos

        Dim ArchivoAgendaBuscado As String
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim DP As New DatosPersonales
        Dim AO As New Form1.TablaDeAntecedentesObstetricos
        Dim DC As New DatosComplementarios

        Dim C As Integer

        'inicializa verificacion 
        booEsNecesarioVerificarCelular = False
        booEsNecesarioVerificarParidad = False



        'construye el nombre del archivo de la agenda buscado
        ArchivoAgendaBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & ".agd"

        'busqueda de datos de la agenda de este paciente
        If File.Exists(ArchivoAgendaBuscado) Then
            Dim T1 As TablaDeArchivosPropiosDeAgenda
            '  Dim ArraydeFechas As New ArrayList
            Dim alsConsultasDeLaPte As New ArrayList
            Dim FechasDeConsulta As Date = Today
            Dim HonorariosTotales As Integer = 0
            Dim HonorariosDeLaConsulta As Integer = 0
            Dim HonorariosPromedio As Integer = 0

            Dim year2008 As Date = #12/31/2007#

            'existe archivo de agenda propio de esta historia lo lee
            FS = New FileStream(ArchivoAgendaBuscado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            'ArraydeFechas.Clear()
            alsConsultasDeLaPte.Clear()

            C = BR.PeekChar
            'Dim contador As Integer = 0
            T1 = Nothing

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

                'acomoda la fecha a sorteable y calcula los honorarios de una vez
                If IsDate(T1.a10FechaConsulta) Then
                    'acomoda la fecha
                    Dim dateFechaDeLaConsulta = CType(T1.a10FechaConsulta, Date)
                    T1.a10FechaConsulta = dateFechaDeLaConsulta.ToString("s")
                    'calcula los honorarios 
                    If IsNumeric(T1.a07Honorarios) Then
                        HonorariosDeLaConsulta = CType(T1.a07Honorarios, Integer)
                        If dateFechaDeLaConsulta < year2008 Then
                            HonorariosDeLaConsulta = HonorariosDeLaConsulta \ 1000
                        Else
                            'deja la consulta asi igual a como se guardo
                        End If
                    Else
                        HonorariosDeLaConsulta = 0
                    End If
                    HonorariosTotales += HonorariosDeLaConsulta

                    'finalmente añade a la als
                    alsConsultasDeLaPte.Add(T1)

                End If



                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'ahora ordena las fechas de consulta y saca la primera consulta
            Dim alsConsultasOrdenadasDeLaPtePorFecha = From est As Form1.TablaDeArchivosPropiosDeAgenda In alsConsultasDeLaPte
                                                       Order By est.a10FechaConsulta
                                                       Select est

            Dim intCuentaDeConsultas = alsConsultasOrdenadasDeLaPtePorFecha.Count

            'primera consulta
            labDCpacienteDesde.Text = (CType(alsConsultasOrdenadasDeLaPtePorFecha(0).a10FechaConsulta, Date)).ToShortDateString
            If alsConsultasOrdenadasDeLaPtePorFecha(0).a02Clinica <> "" Then
                labDCLugar1raConsulta.Text = alsConsultasOrdenadasDeLaPtePorFecha(0).a02Clinica
            Else
                labDCLugar1raConsulta.Text = SinDatos
            End If

            'ultima consulta
            labDCultimaConsulta.Text = (CType(alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a10FechaConsulta, Date)).ToShortDateString
            If alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a02Clinica <> "" Then
                labDCLugarUltimaConsulta.Text = alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a02Clinica
            Else
                labDCLugarUltimaConsulta.Text = SinDatos
            End If


            'el numero de consultas 
            labDCnumeroConsultas.Text = intCuentaDeConsultas.ToString
            'los honorarios
            labDCHonorariosTotales.Text = FormatCurrency(HonorariosTotales, , , TriState.True, TriState.True)
            'el promedio x consulta
            If intCuentaDeConsultas <> 0 Then
                HonorariosPromedio = HonorariosTotales \ intCuentaDeConsultas
                labDCPromedioPorConsulta.Text = FormatCurrency(HonorariosPromedio, , , TriState.True, TriState.True)
            Else
                labDCPromedioPorConsulta.Text = "n/a"
            End If

        Else
            'no hay archivo muestra q faltan datos en la casillas correspondientes
            labDCpacienteDesde.Text = SinDatosCorto
            labDCultimaConsulta.Text = SinDatosCorto
            labDCnumeroConsultas.Text = "0"
            labDCLugarUltimaConsulta.Text = SinDatos
            labDCHonorariosTotales.Text = "n/a"
            labDCPromedioPorConsulta.Text = "n/a"
        End If

    End Sub


#Region "*****  Parte de la Barra de Menus  *****"

    Private Sub MenuItemVademecum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemVademecum.Click
        Dim Vademecum As New FormMedicamentos()
        MenuItemVademecum.Enabled = False
        Vademecum.Show()
        Vademecum.Focus()
    End Sub

    Private Sub MenuItemRecipes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemRecipes.Click
        Dim Recipes As New FormRecipes()
        MenuItemRecipes.Enabled = False
        Recipes.Show()
        Recipes.Focus()
    End Sub

    Private Sub MenuItemAgenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAgenda.Click
        Dim Agenda As New FormAgendaFinal()

        If LabNombreBaseDatos.Text = "Ninguna" Then
            'no se ha abierto una base de datos
            MsgBox("Primero abre o crea una base de datos...", MsgBoxStyle.Information, "Agenda")
        Else

            If Directory.Exists(PSstrPathAgendaBDH) = True Or Directory.Exists(PathIQ) = True Or Directory.Exists(PathPago) = True Then
                MenuItemAgenda.Enabled = False
                Agenda.Show()
                Agenda.Focus()
            Else 'no existe el directorio de agenda
                MsgBox("No se han introducido datos a la Agenda en esta Base de Datos, la agenda esta vacía...", MsgBoxStyle.Information, "Agenda")
            End If
        End If
    End Sub

    Private Sub MenuDatosDelUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDatosDelUsuario.Click
        MuestraVentanaDeDatosDelUsuario()
    End Sub

    Private Sub menuCalculoEGconECO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculoEGconECO.Click
        Dim dlg As New FormEGxECO()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub menuCalculoEGconFUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculoEGconFUR.Click
        Dim dlg As New FormEGxFUR()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub menuCalculoDCconFUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculoDCconFUR.Click
        Dim dlg As New FormDCxFUR()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub menuCalculoEGconBiometria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculoEGconBiometria.Click
        Dim dlg As New FormCalculosBiometricos()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

#End Region


#Region "******  BASE DE DATOS *******"

    Private Sub MenuCreaBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCreaBase.Click
        'crea base de datos nueva o sobreescribe una existente
        CreaBaseDeDatos()
    End Sub
    Private Sub CreaBaseDeDatos()

        'primero q nada verifica q no hubiese una base abierta con combio de logo para guardar los cambios
        If Form1.booSeDebeActualizarImagenDelUsuarioAlCerrar = True Then ' se debe actualizar el archivo de imgen de logo de la base abierta
            'sea como sea apaga la bandera
            Form1.booSeDebeActualizarImagenDelUsuarioAlCerrar = False
            'trata de copiar los cambios
            Try
                File.Copy(Form1.ArchivoImagenDelUsuarioNuevo, ArchivoImagenDelUsuario, True)
            Catch ex As Exception
                MsgBox("No se pudo Guardar la nueva imagen del Logo del Usuario. Reinicia el Programa e intentalo nuevamente sin abrir multiples veces la misma base de datos...", MsgBoxStyle.Information)
            End Try
        End If

        'ahora si empieza a crear la base de datos nueva
        Dim FS As FileStream
        Dim Largo As Integer


        SaveFileDialog1.DefaultExt = ".BDH"      'extension predeterminada
        SaveFileDialog1.AddExtension = True     'añade de forma automatica la extension
        SaveFileDialog1.Filter = "Bases de Datos de Historias (*.bdh)|*.bdh" 'coloca el filtro de archivos de la ventana

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'apunta a la primera pagina
            TabControl1.SelectedTab = TabPage4
            'apaga el filtro
            txtFiltro.Text = ""

            'si se sale con ok se coloca el resultado en filename
            PSstrArchivoNombreBaseDeDatos = SaveFileDialog1.FileName

            subCreaRutasDeLaBaseDeDatos()

            If Directory.Exists(PSstrPathHistoriasSinPrefijo) Then
                If MsgBox("La Carpeta: " & PSstrPathHistoriasSinPrefijo & " ya existe, se perderan todas  las Historias almacenadas en ella, para confirmar presiona Aceptar.",
                            MsgBoxStyle.OkCancel, "Confirmar la Eliminación") = MsgBoxResult.Ok Then
                    CargaBasedeDatosINI() ' carga los datos ini de la numeracion y la contraseña de la base de datos
                    TipoDeContraseña = 3
                    subBuscaContraseñaBasedeDatos()
                    If ContraseñaCorrecta = True Then

                        'pide la creacion de una nueva contraseña
                        TipoDeContraseña = 1        '1= crea contraseña, 2=pide la contraseña para entrar
                        subBuscaContraseñaBasedeDatos()     '3= pide la contraseña para eliminar

                        'sobreescribe el directorio y borra su contenido
                        Directory.Delete(PSstrPathHistoriasSinPrefijo, True)
                        'si existe una carpeta de imagenes la borra tambien
                        If Directory.Exists(PathImagenesSinPrefijo) = True Then
                            Directory.Delete(PathImagenesSinPrefijo, True)
                        End If
                        Directory.CreateDirectory(PSstrPathHistoriasSinPrefijo)
                        FS = New FileStream(PSstrArchivoNombreBaseDeDatos, FileMode.Create, FileAccess.ReadWrite)
                        FS.Close()
                        'crea la carpeta de datos personales
                        If Directory.Exists(PathDatosDelUsuario) = False Then
                            'no existe aun, lo crea
                            Directory.CreateDirectory(PathDatosDelUsuario)
                        End If
                        '===================================
                        'inicializa las variables chimbas de numeracion a nada
                        Form1.NumPrefijo = ""
                        Form1.NumNumero = 0
                        Form1.NumTieneSufijo = False
                        Form1.NumIncremento = 0
                        'Password = Form1.NumPassword 'ya se definio el password antes

                        'crea el archivo ini y le escribe los valores
                        Dim BW As BinaryWriter

                        FS = New FileStream(BaseDatosINI, FileMode.Create, FileAccess.Write)
                        BW = New BinaryWriter(FS)
                        BW.BaseStream.Seek(0, SeekOrigin.Begin)

                        BW.Write(NumPrefijo)        'String
                        BW.Write(NumNumero)        'Integer
                        BW.Write(NumTieneSufijo)   'Boolean
                        BW.Write(NumIncremento)    'integer
                        BW.Write(NumPassword)      'integer

                        BW.Close()
                        FS.Close()                 'cuando se crea la numeracion se cargan los datos de una vez por lo que no hace falta cargarlos
                        'CargaBasedeDatosINI() 'carga los datos recien creados en creatipodenumeracion

                        MsgBox("Se sobreescribió la carpeta " & PSstrPathHistoriasSinPrefijo & ", se perdieron todas las historias almacenadas en ella", MsgBoxStyle.Information)

                        '================================

                        Historias.Clear()
                        LeeContenidoBaseDatos()
                        'pide los datos del usuario 
                        CompruebaDatosDelUsuario()
                        'carga los datos de aniversario
                        CompruebaCumpleaños()
                        'muestra la base
                        MuestraContenidoBaseDatos()
                        '===========================
                        'inicio modificacion de respaldo v2
                        BaseModificada = PSstrArchivoNombreBaseDeDatos
                        Largo = BaseModificada.Length
                        DirBaseModificada = BaseModificada.Remove(Largo - 4, 4) & "-Historias"
                        HoraDeAccesoaLaBase = Now
                        SeModificaronDatos = False
                        '=============================== fin en caso de incendio borrar hasta aqui...
                    Else
                        MsgBox("Contraseña incorrecta. No se realizaron modificaciones a la carpeta " & PSstrPathHistoriasSinPrefijo, MsgBoxStyle.Critical)
                        ConfiguracionBaseDatosNoCargada()
                    End If
                Else
                    'no se sobreescribe el directorio existente
                    MsgBox("No se realizaron modificaciones a la carpeta " & PSstrPathHistoriasSinPrefijo, MsgBoxStyle.Information)
                    ConfiguracionBaseDatosNoCargada()
                End If
            Else
                'no hay ningun directorio con ese nombre no hay problema...
                Directory.CreateDirectory(PSstrPathHistoriasSinPrefijo)
                FS = New FileStream(PSstrArchivoNombreBaseDeDatos, FileMode.Create, FileAccess.ReadWrite)
                FS.Close()
                'crea la carpeta de datos personales del usuario
                If Directory.Exists(PathDatosDelUsuario) = False Then
                    'no existe aun, lo crea
                    Directory.CreateDirectory(PathDatosDelUsuario)
                End If
                '=========================
                'crea una contraseña para la base de datos
                TipoDeContraseña = 1        '1= crea contraseña, 2=pide la contraseña para entrar
                subBuscaContraseñaBasedeDatos()     '3= pide la contraseña para eliminar

                'inicializa las variables chimbas de numeracion a nada
                Form1.NumPrefijo = ""
                Form1.NumNumero = 0
                Form1.NumTieneSufijo = False
                Form1.NumIncremento = 0
                'Password = Form1.NumPassword 'ya se definio el password antes

                'crea el archivo ini y le escribe los valores
                Dim BW As BinaryWriter

                FS = New FileStream(BaseDatosINI, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)

                BW.Write(NumPrefijo)        'String
                BW.Write(NumNumero)        'Integer
                BW.Write(NumTieneSufijo)   'Boolean
                BW.Write(NumIncremento)    'integer
                BW.Write(NumPassword)      'integer

                BW.Close()
                FS.Close()
                'cuando se crea la numeracion se cargan los datos de una vez por lo que no hace falta cargarlos
                '====================================
                'carga la base de datos sencilla antigua
                LeeContenidoBaseDatos()
                'comprueba si tiene datos del usuario si no tiene pregunta si quiere introducirlos
                CompruebaDatosDelUsuario()
                'carga los datos de aniversario
                CompruebaCumpleaños()

                'muestra el contrnido de la base segun esten colocados loas rad, inicialmente estara mostrando todas las ptes
                MuestraContenidoBaseDatos()
                '===========================
                'inicio modificacion de respaldo v2
                BaseModificada = PSstrArchivoNombreBaseDeDatos
                Largo = BaseModificada.Length
                DirBaseModificada = BaseModificada.Remove(Largo - 4, 4) & "-Historias"
                HoraDeAccesoaLaBase = Now
                SeModificaronDatos = False
                '=============================== fin en caso de incendio borrar hasta aqui...
            End If
        Else
            'no se acepto un nombre se cancelo procedimiento
            'deja todo igual
            'ConfiguracionBaseDatosNoCargada()
        End If
    End Sub

    Private Sub MenuAbreBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAbreBase.Click
        'abre la base que se seleccionara
        AbreBaseDeDatos()
    End Sub
    Private Sub AbreBaseDeDatos()

        'primero q nada verifica q no hubiese una base abierta con cambio de logo para guardar los cambios
        If Form1.booSeDebeActualizarImagenDelUsuarioAlCerrar = True Then ' se debe actualizar el archivo de imgen de logo de la base abierta
            'sea como sea apaga la bandera
            Form1.booSeDebeActualizarImagenDelUsuarioAlCerrar = False
            'trata de copiar los cambios
            Try
                File.Copy(Form1.ArchivoImagenDelUsuarioNuevo, ArchivoImagenDelUsuario, True)
            Catch ex As Exception
                MsgBox("No se pudo Guardar la nueva imagen del Logo del Usuario. Reinicia el Programa e intentalo nuevamente sin abrir multiples veces la misma base de datos...", MsgBoxStyle.Information)
            End Try
        End If

        'ahora si empieza a carga la base de datos
        Dim Largo As Integer
        OpenFileDialog1.DefaultExt = ".BDH"
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.Filter = "Bases de Datos de Historias (*.bdh) |*.bdh"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'se acepto abrir la base
            PSstrArchivoNombreBaseDeDatos = OpenFileDialog1.FileName

            'apunta a la primera pagina
            TabControl1.SelectedTab = TabPage4
            'apaga el filtro
            txtFiltro.Text = ""

            'crea las rutas a los archivos y directorios de la base de datos
            subCreaRutasSerializadas()
            subCreaRutasDeLaBaseDeDatos()

            '===========================
            'inicio modificacion de respaldo v2
            BaseModificada = PSstrArchivoNombreBaseDeDatos
            Largo = BaseModificada.Length
            DirBaseModificada = BaseModificada.Remove(Largo - 4, 4) & "-Historias"
            'la variable siguiente se utiliza en la parte de numeracion
            BaseDatosINI = DirBaseModificada & "\Base de Datos.ini"
            CargaBasedeDatosINI() ' carga los datos ini de la numeracion y la contraseña de la base de datos
            HoraDeAccesoaLaBase = Now
            SeModificaronDatos = False
            '=============================== fin en caso de incendio borrar hasta aqui...
            'modificacion de recopilacion de datos de historias para la tesis
            PS_strArchivoDeDatosRecopilados = DirBaseModificada & "\DatosDeRecopilacion.dat"
            PS_strRecopilacionDatos = FuncionCargaArchivoDeRecopilacionDeDatos(PS_strArchivoDeDatosRecopilados)
            '================================

            'parte de la modificacion de pedir contraseña de la base de datos
            TipoDeContraseña = 2 'pide la contraseña para abrirla
            ContraseñaCorrecta = False
            subBuscaContraseñaBasedeDatos() 'pide la contraseña para abrirla
            If ContraseñaCorrecta = True Then
                'se introdujo la contraseña correcat, procede a abrirla
                PSbooBaseDeDatos_ProcesoDeAbrir = True 'prende la bandera q solo hace q se muestre el proceso de carga...

                'primero carga el archivo de otros referidores para poder compaginar los datos mostrados en pantalla
                subCargaArchivoDeOtrosRef()

                'inicializa la historia seleccionada en el list box
                IndiceHistoriaAbierta = 0
                'lee las historias de la base y las carga en la als Historias (tabla sencilla de nombre cedula numero)
                LeeContenidoBaseDatos()

                'comprueba si tiene datos del usuario si no tiene pregunta si quiere introducirlos
                CompruebaDatosDelUsuario()
                'carga los datos de aniversario
                CompruebaCumpleaños()

                'muestra el contrnido de la base segun esten colocados loas rad, inicialmente estara mostrando todas las ptes
                MuestraContenidoBaseDatos()

                'refresca la pantalla para q no se bloquue
                labMensajedeAgenda.Text = "Base de Datos Cargada..."
                labMensajedeAgenda.Refresh()

                'apaga la bandera de carga inicial
                PSbooBaseDeDatos_ProcesoDeAbrir = False

            Else
                MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical)
                ConfiguracionBaseDatosNoCargada()
            End If
            '---------------------------------
        Else
            'se cancelo la apertura de la base de datos, deja todo igual
            'ConfiguracionBaseDatosNoCargada()
        End If
    End Sub

    '00000000000000000 base serializada
    Public Shared PSstrCarpetaDeLaBaseDeDatosSER As String
    Public Shared PSstrArchivoDeLaBaseDeDatosSER As String

    Private Sub subCreaRutasSerializadas()

        Dim DI As IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(PSstrArchivoNombreBaseDeDatos)
        PSstrCarpetaDeLaBaseDeDatosSER = DI.Parent.FullName

        '---------- solo mientras se hace la transicion final este nombre debe tomarse al abrir el archivo----------------------------------
        PSstrArchivoDeLaBaseDeDatosSER = PSstrArchivoNombreBaseDeDatos
        Dim largo = PSstrArchivoDeLaBaseDeDatosSER.Length
        'remueve la ext vieja y pone la nueva mas el punto
        PSstrArchivoDeLaBaseDeDatosSER = PSstrArchivoDeLaBaseDeDatosSER.Remove(largo - 4, 4) & ".bhs" 'base historias serializadas
        '------------------------------------------------------------------------------------------------------------------------------------
    End Sub
    '00000000000000000000 fin de segmento

    Private Sub subCreaRutasDeLaBaseDeDatos()
        Dim largo As Integer

        'crea los path que se pueden crear de una vez
        PSstrPathHistoriasSinPrefijo = PSstrArchivoNombreBaseDeDatos
        largo = PSstrPathHistoriasSinPrefijo.Length
        PSstrPathHistoriasSinPrefijo = PSstrPathHistoriasSinPrefijo.Remove(largo - 4, 4) & "-Historias"

        PathImagenesSinPrefijo = PSstrArchivoNombreBaseDeDatos
        largo = PathImagenesSinPrefijo.Length
        PathImagenesSinPrefijo = PathImagenesSinPrefijo.Remove(largo - 4, 4) & "-Imagenes"

        'PathAgenda = PathHistoriasSinPrefijo & "\Agenda"
        PSstrPathAgendaBDH = PSstrPathHistoriasSinPrefijo & "\AgendaBDH"

        PathIQ = PSstrPathHistoriasSinPrefijo & "\Intervenciones"
        PathPago = PSstrPathHistoriasSinPrefijo & "\Pagos"

        'nuevo path de agenda convertida
        PSstrPathAgendaBDH = PSstrPathHistoriasSinPrefijo & "\AgendaBDH"

        'la variable siguiente se utiliza en la parte de numeracion
        BaseDatosINI = PSstrPathHistoriasSinPrefijo & "\Base de Datos.ini"

        'construye los nombres de los datos del usuario y aniversario
        PathDatosDelUsuario = PSstrPathHistoriasSinPrefijo & "\Datos del Usuario"
        ArchivoDatosDelUsuario = PathDatosDelUsuario & "\Usuario.dat"
        ArchivoDatosDeAniversario = PathDatosDelUsuario & "\Aniversarios.dat"
        ArchivoImagenDelUsuario = PathDatosDelUsuario & "\Imagen.jpg"
        ArchivoImagenDelUsuarioTemporal = PathDatosDelUsuario & "\ImagenTemp.jpg"

        ''crea la carpeta de datos personales del usuario
        ''si no existe 
        'If Directory.Exists(PathDatosDelUsuario) = False Then
        '    'no existe aun, lo crea
        '    Directory.CreateDirectory(PathDatosDelUsuario)
        'End If

    End Sub

    Private Sub subBuscaContraseñaBasedeDatos()
        Dim DLG As New FormContraseñaBaseDatos()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'regreso a donde llamo
        End If

    End Sub

    Private Sub CargaBasedeDatosINI()
        Dim BR As BinaryReader
        Dim FS As FileStream
        'basedatosini se crea en la parte de abrir o crear base de datos y es el nombre del archivo ini
        If File.Exists(BaseDatosINI) Then
            FS = New FileStream(BaseDatosINI, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            NumPrefijo = BR.ReadString
            NumNumero = BR.ReadInt64
            NumTieneSufijo = BR.ReadBoolean
            NumIncremento = BR.ReadInt64
            NumPassword = BR.ReadInt64
            BR.Close()
            FS.Close()
        Else
            MsgBox("No se encontró archivo INI", MsgBoxStyle.Information)
        End If

    End Sub

    Function FuncionCargaArchivoDeRecopilacionDeDatos(ByVal strArchivo As String) As String
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim strDatos As String

        'Archivo se crea en la parte de abrir o crear base de datos y es el nombre del archivo de la recopilacion de datos
        If File.Exists(strArchivo) Then
            FS = New FileStream(strArchivo, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            strDatos = BR.ReadString
            BR.Close()
            FS.Close()
        Else
            strDatos = ""
        End If

        Return strDatos
    End Function

    Private Sub CompruebaDatosDelUsuario()
        Dim Reply As MsgBoxResult
        'Dim BW As BinaryWriter
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim Adicional As String

        'primero revisa el logo del usuario
        'ahora lo de la imagen del logo
        If File.Exists(Form1.ArchivoImagenDelUsuario) And File.Exists(Form1.ArchivoImagenDelUsuarioTemporal) Then ' existen los 2, compara los archivos a ver si son iguales

            Dim dateTiempoDeModificacion1 = File.GetLastWriteTime(Form1.ArchivoImagenDelUsuario)
            Dim dateTiempoDeModificacion2 = File.GetLastWriteTime(Form1.ArchivoImagenDelUsuarioTemporal)

            If dateTiempoDeModificacion1 = dateTiempoDeModificacion2 Then
                'MsgBox("las fecha son iguales no hace nada")
                'carga la imagen temporal en la variable publica
                imagenLogoDelUsuario = Image.FromFile(ArchivoImagenDelUsuarioTemporal)
            Else
                'MsgBox("las fechas son distintos se debe actualizar")
                'actualiza el temporal
                Try
                    File.Copy(Form1.ArchivoImagenDelUsuario, Form1.ArchivoImagenDelUsuarioTemporal, True)
                    'ahora se debe poner la misma fecha de creacion pa q se vean igualitos la proxima vez
                    File.SetLastWriteTime(Form1.ArchivoImagenDelUsuarioTemporal, dateTiempoDeModificacion1)
                    'carga la imagen temporal en la variable publica
                    imagenLogoDelUsuario = Image.FromFile(ArchivoImagenDelUsuarioTemporal)

                Catch ex As Exception
                    MsgBox("El Programa necesita reiniciar para guardar cambios a la imagen del logo del Usuario... Se terminará la aplicación", MsgBoxStyle.Information)
                    Form1.booSeDebeActualizarImagenDelUsuarioAlCerrar = False
                    Me.Close()
                End Try

            End If

        ElseIf File.Exists(Form1.ArchivoImagenDelUsuario) Then 'solo existe el original se debe estar empezando a usar la base de datos luego de seleccionar la imagen la siguiente vez

            'se debe copiar 
            ' MsgBox("aun no existia un logo temporal, se debe crear, solo la primera vez no deberia volver a pasar en esta base a menos q se borre manualmente")

            'obtiene la fecha de creacion del logo original
            Dim dateTiempoDeCreacion1 = File.GetCreationTime(Form1.ArchivoImagenDelUsuario)
            'actualiza el temporal
            File.Copy(Form1.ArchivoImagenDelUsuario, Form1.ArchivoImagenDelUsuarioTemporal, True)
            'ahora se debe poner la misma fecha de creacion pa q se vean igualitos la proxima vez
            File.SetCreationTime(Form1.ArchivoImagenDelUsuarioTemporal, dateTiempoDeCreacion1)
            'carga la imagen temporal en la variable publica
            imagenLogoDelUsuario = Image.FromFile(ArchivoImagenDelUsuarioTemporal)


        Else
            'no se ha seleccionado una imagen
            Form1.imagenLogoDelUsuario = FormImagenes.picImagenVacia.Image
        End If

        'de todas todas actualiza la bandera de q no han habido cambios del logo ( se esta cargando)
        Form1.booSeDebeActualizarImagenDelUsuarioAlCerrar = False

        'ahora comprueba si existe el archivo de datos
        booExistenDatosDelUsuario = False 'inicializa a false antes de la comprobacion
        If File.Exists(ArchivoDatosDelUsuario) = True Then
            'existe lo lee
            FS = New FileStream(Form1.ArchivoDatosDelUsuario, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            Form1.UsuarioNombre = BR.ReadString
            Form1.UsuarioEspecialidad = BR.ReadString
            Form1.UsuarioDir01 = BR.ReadString
            Form1.UsuarioDir02 = BR.ReadString
            'la imagen es siempre la misma no se gurdara
            'Form1.UsuarioImagen = BR.ReadString
            Adicional = BR.ReadString
            Adicional = BR.ReadString
            Adicional = BR.ReadString
            Adicional = BR.ReadString
            Adicional = BR.ReadString
            Adicional = BR.ReadString

            BR.Close()
            FS.Close()

            'actualiza el titulo de la ventana ppal
            Me.Text = "Historias Clínicas - " & UsuarioNombre & " - " & Today.ToLongDateString

            'actualiza la bandera de existencia de datos
            booExistenDatosDelUsuario = True

        Else
            'como no hay datos pone este titulo generico
            Me.Text = "Historias Clínicas"
            'pregunta si quieres introducir los datos del usuario
            Reply = MsgBox("¿Deseas introducir los Datos del Usuario para personalizar los Récipes e Informes de tu Base de Datos?", MsgBoxStyle.YesNo, "Personaliza Base de Datos")
            If Reply = MsgBoxResult.Yes Then
                'desea crear el archivo
                MuestraVentanaDeDatosDelUsuario()
            End If
        End If


    End Sub
    Private Sub MuestraVentanaDeDatosDelUsuario()
        Dim DLG As New FormDatosDelUsuario()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'se acepto lo que se metio

            'actualiza el titulo de la ventana ppal
            Me.Text = "Historias Clínicas - " & UsuarioNombre & " - " & Today.ToLongDateString
            'actualiza la bandera de existencia de datos
            booExistenDatosDelUsuario = True

        End If
    End Sub


    Private Sub CompruebaCumpleaños()
        Dim Indice As Integer
        Dim Elementos As Integer
        'Dim H As New BaseDatosIndiceHistorias()
        Dim DA As New structureListadoPacientesDatosComplementarios
        'Dim DP As New DatosPersonales

        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim C As Integer
        Dim FechaNacimiento As Date
        Dim FechaNacimientoEsteAño As Date
        Dim FechaNacimientoEsteAñoString As String
        Dim Dia As Integer
        Dim Mes As Integer
        Dim DiferenciadeDias As Integer

        Dim CH As New structureDatosDeAniversario 'datos de cumpleaños hoy
        Dim CS As New structureDatosDeAniversario 'datos de cumpleaños semana
        Dim Ed As New structureDatosDeAniversario 'estructuras por edad (es la misma vains de todas formas)
        Dim SD As New structureHistoriasSinDatosPersonales 'estructura ded historias sin datos (igualitra a la de los indices)

        Dim NoCH, NoCS As Integer
        Dim intGrupoMenor20, intGrupode20a29, intGrupode30a39, intGrupo40oMas As Integer
        Dim intGrupoSinDatos As Integer
        Dim Linea As String
        Dim cumple As Integer
        Dim tel As String
        Dim pedazo1, pedazo2, pedazo3, pedazo4 As String
        Dim edad As Long


        Dim AumentoBarraprogreso As Integer = 0


        SeCargaronLosDatosDeAniversario = True


        'inicializa las estructuras q guardan los cumpleañeras y las cuentas de aniversarios
        arrayAniversarioHoy.Clear()
        arrayAniversarioSemana.Clear()
        arrayEdad0a19.Clear()
        arrayEdad20a29.Clear()
        arrayEdad30a39.Clear()
        arrayEdad40a99.Clear()
        arrayHistoriasSinDatos.Clear()
        'flipflap para deseleccionar
        radEdadChamas.Checked = True
        radEdadChamas.Checked = False
        labPacientesGrupoEtario.Text = ""

        NoCH = 0
        NoCS = 0
        intGrupoMenor20 = 0
        intGrupode20a29 = 0
        intGrupode30a39 = 0
        intGrupo40oMas = 0
        intGrupoSinDatos = 0

        'inicializa la array de aniversarios
        arrayAniversarios.Clear()
        Dim J As New Form1.structureListadoPacientesDatosComplementarios

        'copia las diferentes fuentes a la array de aniversarios
        If NumerodeHistoriasActuales > 0 Then
            For Each est As Form1.BaseDatosIndiceHistorias In Historias

                J = Nothing

                'copio lo primero
                J.d00NumeroHistoria = est.NumeroHistoria
                J.d01Nombre = est.NombrePaciente
                J.d03Cedula = est.CedulaPaciente

                'ahora saco la fecha de nacimiento y el telefono de los datos complementarios
                Dim ParteDe5 As String = est.NumeroHistoria.Substring(0, 5)
                Dim archivoDP = Form1.PSstrPathHistoriasSinPrefijo & "\" & ParteDe5 & "\" & est.NumeroHistoria & "-Datos Personales.dat"

                If File.Exists(archivoDP) Then
                    'lo lee
                    FS = New FileStream(archivoDP, FileMode.Open, FileAccess.Read)
                    BR = New BinaryReader(FS)
                    BR.BaseStream.Seek(0, SeekOrigin.Begin)

                    C = BR.PeekChar

                    Dim DP As DatosPersonales

                    'modificacion para q no de error tomando try
                    Dim arrCadenas(28) As String
                    Dim booError As Boolean = False

                    For intC = 0 To 28
                        Try
                            arrCadenas(intC) = BR.ReadString
                        Catch ex As Exception
                            MsgBox("Se produj un error con el archivo: " & archivoDP & vbCrLf & "El Archivo será renombrado como .bak tendras que buscar los datos personales de la paciente " & est.NombrePaciente)
                            booError = True
                            Exit For
                        End Try
                    Next

                    BR.Close()
                    FS.Close()

                    If booError = False Then
                        DP = Nothing
                        ' Read fields and populate structure
                        DP.a01Nombre = arrCadenas(0)
                        DP.FechaNacimiento = arrCadenas(1)
                        DP.Edad = arrCadenas(2)
                        DP.Cedula = arrCadenas(3)
                        DP.Profesion = arrCadenas(4)
                        DP.Telefono = arrCadenas(5)
                        DP.AntecedentesFamiliares = arrCadenas(6)
                        DP.AntecedentesGinecologicos = arrCadenas(7)
                        DP.AntecedentesObstetricos = arrCadenas(8)
                        DP.AntecedentesPersonales = arrCadenas(9)
                        DP.AntecedentesQuirurgicos = arrCadenas(10)
                        DP.x01DireccionDeHabitacion = arrCadenas(11)
                        DP.x02GradoDeInstruccion = arrCadenas(12)
                        DP.x03Religion = arrCadenas(13)
                        DP.x04CiaDeSeguros = arrCadenas(14)
                        DP.x05FamiliarNombre = arrCadenas(15)
                        DP.x06FamiliarParentesco = arrCadenas(16)
                        DP.x07FamiliarCelular = arrCadenas(17)
                        DP.x08FamiliarOcupacion = arrCadenas(18)
                        DP.z01 = arrCadenas(19)
                        DP.z02 = arrCadenas(20)
                        DP.z03 = arrCadenas(21)
                        DP.z04 = arrCadenas(22)
                        DP.z05 = arrCadenas(23)
                        DP.z06 = arrCadenas(24)
                        DP.z07 = arrCadenas(25)
                        DP.z08 = arrCadenas(26)
                        DP.z09 = arrCadenas(27)
                        DP.z10 = arrCadenas(28)

                    Else
                        'renomnbra a bak y borra el original
                        File.Copy(archivoDP, archivoDP & ".bak")
                        File.Delete(archivoDP)

                        'pone todo a ""
                        DP.a01Nombre = ""
                        DP.FechaNacimiento = ""
                        DP.Edad = ""
                        DP.Cedula = ""
                        DP.Profesion = ""
                        DP.Telefono = ""
                        DP.AntecedentesFamiliares = ""
                        DP.AntecedentesGinecologicos = ""
                        DP.AntecedentesObstetricos = ""
                        DP.AntecedentesPersonales = ""
                        DP.AntecedentesQuirurgicos = ""
                        DP.x01DireccionDeHabitacion = ""
                        DP.x02GradoDeInstruccion = ""
                        DP.x03Religion = ""
                        DP.x04CiaDeSeguros = ""
                        DP.x05FamiliarNombre = ""
                        DP.x06FamiliarParentesco = ""
                        DP.x07FamiliarCelular = ""
                        DP.x08FamiliarOcupacion = ""
                        DP.z01 = ""
                        DP.z02 = ""
                        DP.z03 = ""
                        DP.z04 = ""
                        DP.z05 = ""
                        DP.z06 = ""
                        DP.z07 = ""
                        DP.z08 = ""
                        DP.z09 = ""
                        DP.z10 = ""
                    End If

                    '---------------------





                    'verifica la fecha de nacimiento
                    If DP.FechaNacimiento <> "" Then
                        If IsDate(DP.FechaNacimiento) Then
                            J.d02FechaNacimiento = (CType(DP.FechaNacimiento, Date)).ToString("s")
                        Else
                            J.d02FechaNacimiento = ""
                        End If
                    Else
                        J.d02FechaNacimiento = ""
                    End If

                    'verifica el telefono
                    If DP.Telefono <> "" Then
                        J.d04Telefono = DP.Telefono
                    Else
                        J.d04Telefono = ""
                    End If


                Else 'si no tiene archivo de datos personales
                    J.d02FechaNacimiento = ""
                    J.d04Telefono = ""
                End If

                'ya tengo todo los datos del pte actual pa la array
                arrayAniversarios.Add(J)

            Next
        End If



        'revisa si la base de datos tiene algo para procesar...
        If arrayAniversarios.Count > 0 Then

            Elementos = arrayAniversarios.Count
            'SeCargaronLosDatosDeAniversario = True 'pone la bandera a true

            For Indice = 0 To Elementos - 1 'recorre el array de aniverarios listo
                DA = arrayAniversarios(Indice) 'carga el dato actual

                'revisa el aniversario de la pte
                If IsDate(DA.d02FechaNacimiento) Then
                    'tiene fecha de nacimiento: ve si estacumpliendo o va a cumplir
                    FechaNacimiento = DA.d02FechaNacimiento
                    Dia = FechaNacimiento.Day
                    Mes = FechaNacimiento.Month
                    If Dia = 29 And Mes = 2 Then
                        Dia = 28
                    End If
                    FechaNacimientoEsteAñoString = Dia.ToString & "/" & Mes.ToString & "/" & Today.Year.ToString
                    FechaNacimientoEsteAño = FechaNacimientoEsteAñoString
                    DiferenciadeDias = (DateDiff(DateInterval.Day, FechaNacimientoEsteAño, Today()))
                    'la edad real
                    FechaNacimiento = DA.d02FechaNacimiento
                    edad = (DateDiff(DateInterval.Day, FechaNacimiento, Today())) + 1
                    edad = edad * 100 \ 36525
                    If DiferenciadeDias = 0 Then
                        'esta de cumpleaños hoy
                        'carga los datos actuales en la estructura
                        If DA.d01Nombre.Length < 30 Then
                            CH.Nombre = DA.d01Nombre.PadRight(30)
                        Else
                            CH.Nombre = DA.d01Nombre.Remove(30, DA.d01Nombre.Length - 30)
                        End If
                        CH.FechaNacimiento = DA.d02FechaNacimiento
                        CH.Edad = edad.ToString 'edad real actual
                        CH.Telefono = DA.d04Telefono
                        'añade los datos al array
                        arrayAniversarioHoy.Add(CH)
                        'incrementa el numero de cumpleañeras de hoy
                        NoCH += 1
                    ElseIf DiferenciadeDias < 0 And DiferenciadeDias > -8 Then
                        'cumple años en los proximos 7 dias
                        'carga los datos actuales en la estructura
                        If DA.d01Nombre.Length < 30 Then
                            CS.Nombre = DA.d01Nombre.PadRight(30)
                        Else
                            CS.Nombre = DA.d01Nombre.Remove(30, DA.d01Nombre.Length - 30)
                        End If
                        CS.FechaNacimiento = DA.d02FechaNacimiento

                        CS.Edad = edad.ToString 'edad real actual se le sumara 1 para saber cuanto cumplira
                        CS.Telefono = DA.d04Telefono
                        'añade los datos al array
                        arrayAniversarioSemana.Add(CS)
                        'incrementa el numero de cumpleañeras de la semana prox
                        NoCS += 1
                    End If

                    '=========================hasta aqui realmente es lo de los aniversarios

                    'rellena la estructurita q se guardara en los arrays
                    'corta el nombre a 30 chars
                    If DA.d01Nombre.Length < 30 Then
                        Ed.Nombre = DA.d01Nombre.PadRight(30)
                    Else
                        Ed.Nombre = DA.d01Nombre.Remove(30, DA.d01Nombre.Length - 30)
                    End If
                    Ed.FechaNacimiento = DA.d02FechaNacimiento
                    'la edad real se calculo arriba (edad.tostring)
                    Ed.Edad = edad.ToString
                    Ed.Telefono = DA.d04Telefono
                    'clasifica segun la edad real actual
                    If edad < 20 Then
                        arrayEdad0a19.Add(Ed)
                        intGrupoMenor20 += 1
                    ElseIf edad >= 20 And edad < 30 Then
                        arrayEdad20a29.Add(Ed)
                        intGrupode20a29 += 1
                    ElseIf edad >= 30 And edad < 40 Then
                        arrayEdad30a39.Add(Ed)
                        intGrupode30a39 += 1
                    ElseIf edad >= 40 Then
                        arrayEdad40a99.Add(Ed)
                        intGrupo40oMas += 1
                    End If

                Else
                    'no hay dato de fecha de nacimiento en los datos persoanales de esta historia
                    intGrupoSinDatos += 1
                    If DA.d01Nombre.Length < 30 Then
                        SD.Nombre = DA.d01Nombre.PadRight(30)
                    Else
                        SD.Nombre = DA.d01Nombre.Remove(30, DA.d01Nombre.Length - 30)
                    End If
                    SD.Cedula = DA.d03Cedula & ". Falta Fecha de Nacimiento"
                    SD.NumeroHistoria = DA.d00NumeroHistoria
                    arrayHistoriasSinDatos.Add(SD)
                End If

            Next

            '=======================================================================

            PanelAniversarios.Enabled = True
            ListBoxCH.Items.Clear()
            ListBoxCS.Items.Clear()
            PanelEtarios.Enabled = True
            ListBoxEdades.Items.Clear()
            txtBASEnotificaciones.Text = "Cumpleañeras del día:" & vbCrLf

            If NoCH = 0 Then
                'nadie cumpleaño hoy
                ListBoxCH.Items.Add("No hay cumpleañeras hoy...")
                txtBASEnotificaciones.Text += "- NINGUNA." & vbCrLf
            Else
                'ordena la array
                Dim alsOrdenada = From est As Form1.structureDatosDeAniversario In arrayAniversarioHoy
                                  Order By CType(est.FechaNacimiento, Date)
                                  Select est

                For Each est As Form1.structureDatosDeAniversario In alsOrdenada
                    If est.Telefono <> "" Then
                        If est.Telefono.Length = 10 Then 'si se introdujero todos los numeros
                            pedazo1 = est.Telefono.Substring(0, 3)
                            pedazo2 = est.Telefono.Substring(3, 3)
                            pedazo3 = est.Telefono.Substring(6, 2)
                            pedazo4 = est.Telefono.Substring(8, 2)
                            tel = "(0" & pedazo1 & ") " & pedazo2 & "." & pedazo3 & "." & pedazo4
                        ElseIf est.Telefono.Length = 7 Then 'si solo se metieron los 7 numeros sin codigo
                            pedazo2 = est.Telefono.Substring(0, 3)
                            pedazo3 = est.Telefono.Substring(3, 2)
                            pedazo4 = est.Telefono.Substring(5, 2)
                            tel = pedazo2 & "." & pedazo3 & "." & pedazo4
                        Else 'si es otro numero de digitos ??? muestralos tal cual
                            tel = est.Telefono
                        End If
                    Else 'si no se metio nada entonces
                        tel = "n/a"
                    End If
                    Linea = (CType(est.FechaNacimiento, Date)).ToShortDateString & "-" & est.Nombre & " Cumple " & est.Edad.ToString & " años. Teléfono:" & tel
                    ListBoxCH.Items.Add(Linea)
                    txtBASEnotificaciones.Text += "- " & CType(est.FechaNacimiento, Date).ToShortDateString & " " & est.Nombre & vbCrLf
                Next

            End If

            txtBASEnotificaciones.Text += vbCrLf & "Cumpleañeras de la prox semana:" & vbCrLf
            If NoCS = 0 Then
                'nadie cumpleaño en los prox 7 dias
                ListBoxCS.Items.Add("No hay cumpleañeras en los próximos 7 días...")
                txtBASEnotificaciones.Text += "-Ninguna" & vbCrLf
            Else
                Dim alsOrdenada = From est As Form1.structureDatosDeAniversario In arrayAniversarioSemana
                                  Order By CType(est.FechaNacimiento, Date).Day Order By CType(est.FechaNacimiento, Date).Month
                                  Select est


                'Order By CType(est.FechaNacimiento, Date).Month

                For Each est As Form1.structureDatosDeAniversario In alsOrdenada

                    cumple = CType(est.Edad, Integer) + 1
                    If est.Telefono <> "" Then
                        If est.Telefono.Length = 10 Then 'si se introdujero todos los numeros
                            pedazo1 = est.Telefono.Substring(0, 3)
                            pedazo2 = est.Telefono.Substring(3, 3)
                            pedazo3 = est.Telefono.Substring(6, 2)
                            pedazo4 = est.Telefono.Substring(8, 2)
                            tel = "(0" & pedazo1 & ") " & pedazo2 & "." & pedazo3 & "." & pedazo4
                        ElseIf est.Telefono.Length = 7 Then 'si solo se metieron los 7 numeros sin codigo
                            pedazo2 = est.Telefono.Substring(0, 3)
                            pedazo3 = est.Telefono.Substring(3, 2)
                            pedazo4 = est.Telefono.Substring(5, 2)
                            tel = pedazo2 & "." & pedazo3 & "." & pedazo4
                        Else 'si es otro numero de digitos ??? muestralos tal cual
                            tel = est.Telefono
                        End If
                    Else 'si no se metio nada entonces
                        tel = "n/a"
                    End If
                    Linea = (CType(est.FechaNacimiento, Date)).ToShortDateString & "-" & est.Nombre & " Cumple " & cumple.ToString & " años. Teléfono:" & tel
                    ListBoxCS.Items.Add(Linea)
                    txtBASEnotificaciones.Text += "- " & CType(est.FechaNacimiento, Date).ToShortDateString & " " & est.Nombre & vbCrLf
                Next
            End If
        End If


    End Sub

    Dim strArchivoIndiceDeOtrosReferidores As String
    Dim alsOtrosRef As New ArrayList

    Private Sub subCargaArchivoDeOtrosRef()
        Dim FS As FileStream
        Dim BR As BinaryReader
        Dim Ot As Form1.TablaDeOtrosReferidores
        Dim C As Integer

        alsOtrosRef.Clear()

        strArchivoIndiceDeOtrosReferidores = Form1.PSstrPathHistoriasSinPrefijo & "\OtrosReferidores\Indice.dat"
        If File.Exists(strArchivoIndiceDeOtrosReferidores) Then
            'existe lo carga
            FS = New FileStream(strArchivoIndiceDeOtrosReferidores, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            ' Read todo
            C = BR.PeekChar
            While FS.Position < FS.Length
                Ot = Nothing
                Ot.a01NumeroID = BR.ReadString
                Ot.a02Nombre = BR.ReadString
                Ot.b01 = BR.ReadString
                Ot.b02 = BR.ReadString
                Ot.b03 = BR.ReadString

                'incluye en la als de otros referidores (completa)
                alsOtrosRef.Add(Ot)
            End While

            'cierra la vaina
            BR.Close()
            FS.Close()
        Else
            'no existe es primera vez se debe crear el dir si no existe y el archivo en blanco
            If Directory.Exists(Form1.PSstrPathHistoriasSinPrefijo & "\OtrosReferidores") Then
                'existe el directorio pero el archivo no debe haber sido borrado manualmente lo crea en blanco
                FS = New FileStream(strArchivoIndiceDeOtrosReferidores, FileMode.Create, FileAccess.ReadWrite)
                FS.Close()
                'como esta vacio la als q lo guarda tambien debe estarlo no?
                alsOtrosRef.Clear()
            Else
                'no existe tampoco lo debe crear primero el directorio
                Directory.CreateDirectory(Form1.PSstrPathHistoriasSinPrefijo & "\OtrosReferidores")
                'y ahora el archivo de indice
                FS = New FileStream(strArchivoIndiceDeOtrosReferidores, FileMode.Create, FileAccess.ReadWrite)
                FS.Close()
                'como esta vacio la als q lo guarda tambien debe estarlo no?
                alsOtrosRef.Clear()
            End If
        End If
    End Sub

    Private Sub LeeContenidoBaseDatos()
        Dim BR As BinaryReader
        Dim FS As FileStream
        FS = New FileStream(PSstrArchivoNombreBaseDeDatos, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim H As New BaseDatosIndiceHistorias()
        Dim C As Integer

        'inicializa la als principal
        Historias.Clear()

        NumerodeHistoriasActuales = 0
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H.NumeroHistoria = BR.ReadString
            H.CedulaPaciente = BR.ReadString
            H.NombrePaciente = BR.ReadString
            Historias.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'revisa si la base de datos esta o no vacia 
        NumerodeHistoriasActuales = Historias.Count
        If NumerodeHistoriasActuales > 0 Then
            ConfiguracionBaseDatosNoVacia()
        Else
            ConfiguracionBaseDatosVacia()
        End If

        ''blanquea las notificaciones de la base
        'txtBASEnotificaciones.Clear()

        'amplia la base de datos con la als ampliada a los datos para los grupos
        subAmpliaLaBaseDeDatos()
        'busca los datos de las ptes referidas por el paciente)
        subBuscaDatosDePacientesReferidoras()
        'busca los datos de los controles obstetricos
        subBuscaDatosDeControlesObstetricos()
        'busca los datos de quien refirio al pte
        subBuscaDatosDeRefencia()
        'busca los datos de las consultas
        subBuscaDatosDeLasConsultas()

    End Sub
    Private Sub subAmpliaLaBaseDeDatos()
        Dim estPteAmpliado As New Form1.TablaDePacientesBDH



        'inicializa la als ampliada
        alsPacientes.Clear()

        If PSbooBaseDeDatos_ProcesoDeAbrir = True Then
            labMensajedeAgenda.Text = "Ampliando Base a ALS...."
            Me.Refresh()
        End If

        'recorre la base original 
        For Each est As Form1.BaseDatosIndiceHistorias In Form1.Historias

            'añade los datos y deja en blanco el resto por ahora
            estPteAmpliado.a01NumeroHistoria = est.NumeroHistoria
            estPteAmpliado.a02NombrePaciente = est.NombrePaciente
            estPteAmpliado.a03CedulaPaciente = est.CedulaPaciente
            estPteAmpliado.a04NumeroDeReferidas = ""
            estPteAmpliado.a05TieneControlObstetrico = ""
            estPteAmpliado.a06EstaEmbarazada = ""
            estPteAmpliado.a07TieneConsultaPendiente = ""
            estPteAmpliado.a08NumeroDeConsultas = ""
            estPteAmpliado.a09VinoExpontaneamente = ""
            estPteAmpliado.a10FueReferidaPorPaciente = ""
            estPteAmpliado.a11FueReferidaPorOtroReferidor = ""
            estPteAmpliado.a12EsPacienteDeOtroMedico = ""
            estPteAmpliado.a13SeDeconoceReferencia = ""
            estPteAmpliado.a14FURdelUltimoControl = ""
            estPteAmpliado.a15FechaProximoControl = ""
            estPteAmpliado.A16NombreDelReferidor = ""
            estPteAmpliado.a17PacienteDesde = ""

            'añade la estAmpliada a  su als
            alsPacientes.Add(estPteAmpliado)
        Next
    End Sub
    Private Sub subBuscaDatosDePacientesReferidoras()
        Dim strArchivoReferidasLocal As String = ""
        Dim alsPacientesTemporal As New ArrayList 'guarda los datos temporale mientras se van recopilando
        Dim alsReferidasPorPteActual As New ArrayList

        'inicializa la temporal
        alsPacientesTemporal.Clear()

        'vamos a buscar las referidoras muestra mensaje solo muestra la actualizacion del lab si se esta cargando la base
        If PSbooBaseDeDatos_ProcesoDeAbrir = True Then
            labMensajedeAgenda.Text = "Buscando Datos de Referencia..."
            Me.Refresh()
        End If

        'hace el loop
        For Each est As Form1.TablaDePacientesBDH In Form1.alsPacientes

            'va copiando las als al principio todo igual
            Dim estTemporal = est
            'inicializa el valor que se esta buscando a 0 si hay algo se cambiara
            estTemporal.a04NumeroDeReferidas = "0"

            'crea la ruta al archivo de referencias
            strArchivoReferidasLocal = Form1.PSstrPathHistoriasSinPrefijo & "\" & est.a01NumeroHistoria.Substring(0, 5) & "\" & est.a01NumeroHistoria & "-Referidas.dat"
            If File.Exists(strArchivoReferidasLocal) Then
                'esxiste lo lee
                Dim BR As BinaryReader
                Dim FS As FileStream
                Dim REF As Form1.TablaDeReferidas
                Dim C As Integer

                'inicializa la als de otras pacientes referidas por esta pte
                alsReferidasPorPteActual.Clear()

                'ya esta comprobado q existe
                FS = New FileStream(strArchivoReferidasLocal, FileMode.Open, FileAccess.Read)
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
                    alsReferidasPorPteActual.Add(REF)

                End While

                If alsReferidasPorPteActual.Count > 0 Then
                    'ok hay alguna referida
                    estTemporal.a04NumeroDeReferidas = alsReferidasPorPteActual.Count.ToString
                Else
                    'deja todo igual en "0" como estaba inicializado
                End If

                'cierra la vaina
                BR.Close()
                FS.Close()
            End If

            'ok ahora ya se debe haber modificado a = o se debe haber puesto cuantas referidas tiene la añado a la als
            alsPacientesTemporal.Add(estTemporal)

        Next

        'ya tengo la recopilacion de los datos de referidas los devuelvo a la als publica
        alsPacientes.Clear()

        For Each est As Form1.TablaDePacientesBDH In alsPacientesTemporal
            alsPacientes.Add(est)
        Next


    End Sub
    Private Sub subBuscaDatosDeControlesObstetricos()
        Dim strArchivoControlObstetricoLocal As String = ""
        Dim alsPacientesTemporal As New ArrayList 'guarda los datos temporale mientras se van recopilando
        Dim alsControlesObstetricosPteActual As New ArrayList

        'inicializa la temporal
        alsPacientesTemporal.Clear()

        'solo muestra la actualizacion del lab si se esta cargando la base para ahorrar tiempo. esto seejecuta tambien cuando se añade una nueva historia 
        If PSbooBaseDeDatos_ProcesoDeAbrir = True Then
            'refresca la pantalla para q no se bloquue
            labMensajedeAgenda.Text = "Buscando Datos de Controles Obstétricos..."
            Me.Refresh()
        End If

        'vamos a buscar los datos obstetricos
        For Each est As Form1.TablaDePacientesBDH In Form1.alsPacientes

            'va copiando las als al principio todo igual
            Dim estTemporal = est
            'inicializa el valor que se esta buscando si hay algo se cambiara
            estTemporal.a05TieneControlObstetrico = "False"
            estTemporal.a06EstaEmbarazada = "False"
            estTemporal.a14FURdelUltimoControl = ""


            'crea la ruta al archivo de referencias
            strArchivoControlObstetricoLocal = Form1.PSstrPathHistoriasSinPrefijo & "\" & est.a01NumeroHistoria.Substring(0, 5) & "\" & est.a01NumeroHistoria & "-Control Obstétrico.dat"
            If File.Exists(strArchivoControlObstetricoLocal) Then
                'esxiste lo lee
                Dim BR As BinaryReader
                Dim FS As FileStream
                Dim R As Form1.TablaDeDatosObstetricos
                Dim C As Integer

                Dim booEstaEmbarazada As Boolean = False


                'inicializa la als de otras pacientes referidas por esta pte
                alsControlesObstetricosPteActual.Clear()

                'ya esta comprobado q existe
                FS = New FileStream(strArchivoControlObstetricoLocal, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)

                ' Read todo
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

                    'las incluye en los controles obstetricos de la pte actual
                    alsControlesObstetricosPteActual.Add(R)

                    C = BR.PeekChar
                End While

                'cierra la vaina
                BR.Close()
                FS.Close()


                'revisa a ver si hay controles
                If alsControlesObstetricosPteActual.Count > 0 Then
                    'ok dice primeramente q hay controles obstetricos
                    estTemporal.a05TieneControlObstetrico = "True"

                    'ordena para ver el ultimo control
                    Dim alsOrdenadasPorFecha = From estConsulta As Form1.TablaDeDatosObstetricos In alsControlesObstetricosPteActual
                                               Order By CType(estConsulta.FechaInicioControl, Date) Descending
                                               Select estConsulta
                    'el utimo control esta en (0)
                    Dim estUltimoControl = alsOrdenadasPorFecha(0)



                    If estUltimoControl.TerminoGestacion = "1" Then '"1" significa q esta embarazada y "2" significa q ya termino gestacion
                        'revisa si los datos estan bien
                        If IsDate(estUltimoControl.FUR) Then
                            'esta todo bien añade el resto
                            estTemporal.a06EstaEmbarazada = "True"
                            estTemporal.a14FURdelUltimoControl = estUltimoControl.FUR
                        Else
                            txtBASEnotificaciones.Text += "Revisar FUR de " & est.a02NombrePaciente & vbCrLf
                            'blanquea todo pa q no se meta en peo
                            estTemporal.a05TieneControlObstetrico = "False"
                            estTemporal.a06EstaEmbarazada = "False"
                            estTemporal.a14FURdelUltimoControl = ""
                        End If
                    Else 'no esta embarazada actualmente
                        'revisa si los datos estan bien
                        If IsDate(estUltimoControl.FUR) Then
                            'esta todo bien añade el resto
                            estTemporal.a06EstaEmbarazada = "False" 'no esta embarazada pero tiene una fur valida
                            estTemporal.a14FURdelUltimoControl = estUltimoControl.FUR
                        Else
                            txtBASEnotificaciones.Text += "Revisar FUR de " & est.a02NombrePaciente & vbCrLf
                            'blanquea todo pa q no se meta en peo
                            estTemporal.a05TieneControlObstetrico = "False"
                            estTemporal.a06EstaEmbarazada = "False"
                            estTemporal.a14FURdelUltimoControl = ""
                        End If
                    End If

                Else
                    'no hay controles ???? estara el archivo vacio nos e q pasa revisa esa verga
                    txtBASEnotificaciones.Text += "Revisar ControlObs de " & est.a02NombrePaciente & vbCrLf
                    'blanquea todo pa q no se meta en peo
                    estTemporal.a05TieneControlObstetrico = "False"
                    estTemporal.a06EstaEmbarazada = "False"
                    estTemporal.a14FURdelUltimoControl = ""

                End If







            End If

            'ok ahora ya se debe haber modificado a = "False" se debe haber puesto a "true" si era preciso la añado a la als
            alsPacientesTemporal.Add(estTemporal)

        Next

        'ya tengo la recopilacion de los datos de referidas los devuelvo a la als publica
        alsPacientes.Clear()

        For Each est As Form1.TablaDePacientesBDH In alsPacientesTemporal
            alsPacientes.Add(est)
        Next


    End Sub
    Private Sub subBuscaDatosDeRefencia()
        Dim strArchivoDatosComplementariosLocal As String = ""
        Dim alsPacientesTemporal As New ArrayList 'guarda los datos temporale mientras se van recopilando

        'inicializa la temporal
        alsPacientesTemporal.Clear()


        'solo muestra la actualizacion del lab si se esta cargando la base para ahorrar tiempo. 
        If PSbooBaseDeDatos_ProcesoDeAbrir = True Then
            'refresca la pantalla para q no se bloquue
            labMensajedeAgenda.Text = "Completando Datos de Referencia..."
            Me.Refresh()
        End If

        'vamos a buscar las referidoras
        For Each est As Form1.TablaDePacientesBDH In Form1.alsPacientes




            'va copiando las als al principio todo igual
            Dim estTemporal = est

            'inicializa el valor que se esta buscando  si hay algo se cambiara
            estTemporal.a09VinoExpontaneamente = "False"
            estTemporal.a10FueReferidaPorPaciente = "False"
            estTemporal.a11FueReferidaPorOtroReferidor = "False"
            estTemporal.a12EsPacienteDeOtroMedico = "False"
            estTemporal.a13SeDeconoceReferencia = "False"
            estTemporal.A16NombreDelReferidor = "Desconocida"

            'crea la ruta al archivo de datos complementarios
            strArchivoDatosComplementariosLocal = Form1.PSstrPathHistoriasSinPrefijo & "\" & est.a01NumeroHistoria.Substring(0, 5) & "\" & est.a01NumeroHistoria & "-Datos Complementarios.dat"
            If File.Exists(strArchivoDatosComplementariosLocal) Then
                'esxiste lo lee
                Dim BR As BinaryReader
                Dim BW As BinaryWriter
                Dim FS As FileStream
                Dim DC As Form1.DatosComplementarios
                'Dim C As Integer

                'ya esta comprobado q existe
                FS = New FileStream(strArchivoDatosComplementariosLocal, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)

                DC = Nothing

                ' Read todo
                'C = BR.PeekChar
                While FS.Position < FS.Length
                    DC = Nothing
                    DC.a01Notas = BR.ReadString
                    DC.a02Resumen = BR.ReadString
                    DC.a03NumeroDelReferidor = BR.ReadString
                    DC.a04Vinculos = BR.ReadString
                    DC.a05ReferidaPor = BR.ReadString
                    DC.a06TelefonoVerificado = BR.ReadString
                    DC.a07UltimoSMS = BR.ReadString
                    DC.a08TipoDeReferidor = BR.ReadString
                    DC.a09VinculoConReferidor = BR.ReadString
                    DC.a10 = BR.ReadString
                End While

                'cierra la vaina
                BR.Close()
                FS.Close()

                'sea como sea debe haber un referidor no
                estTemporal.A16NombreDelReferidor = DC.a05ReferidaPor

                If DC.a08TipoDeReferidor = "Sola" Then
                    estTemporal.a09VinoExpontaneamente = "True"
                ElseIf DC.a08TipoDeReferidor = "Pte" Then
                    estTemporal.a10FueReferidaPorPaciente = "True"
                ElseIf DC.a08TipoDeReferidor = "Otro" Then
                    'revisa si es de un doctor o de un otroref
                    If DC.a05ReferidaPor.ToUpper.Contains("PTE") Or DC.a05ReferidaPor.ToUpper.Contains("PACIENTE") Then
                        estTemporal.a11FueReferidaPorOtroReferidor = "False"
                        estTemporal.a12EsPacienteDeOtroMedico = "True"

                        'revisa si se actualizaron cambios en los nombres de los medicos
                        Dim referidor As Form1.TablaDeOtrosReferidores = alsOtrosRef(CType(DC.a03NumeroDelReferidor, Integer))
                        If referidor.a02Nombre <> DC.a05ReferidaPor Then
                            'estan distintos se debe actualizar el archivo de dc y lo q se va a mostrar
                            DC.a05ReferidaPor = referidor.a02Nombre 'actualiza el nombre
                            estTemporal.A16NombreDelReferidor = referidor.a02Nombre
                            'ahora se debe guardar el archivo dc modificado
                            FS = New FileStream(strArchivoDatosComplementariosLocal, FileMode.Create, FileAccess.Write)
                            BW = New BinaryWriter(FS)
                            BW.BaseStream.Seek(0, SeekOrigin.Begin)

                            BW.Write(DC.a01Notas)
                            BW.Write(DC.a02Resumen)
                            BW.Write(DC.a03NumeroDelReferidor)
                            BW.Write(DC.a04Vinculos)
                            BW.Write(DC.a05ReferidaPor)
                            BW.Write(DC.a06TelefonoVerificado)
                            BW.Write(DC.a07UltimoSMS)
                            BW.Write(DC.a08TipoDeReferidor)
                            BW.Write(DC.a09VinculoConReferidor)
                            BW.Write(DC.a10)

                            BW.Close()
                            FS.Close()
                        Else
                            'ok estan iguales no hace nada
                        End If


                    Else
                        estTemporal.a11FueReferidaPorOtroReferidor = "True"
                        estTemporal.a12EsPacienteDeOtroMedico = "False"
                    End If
                Else 'si no hay datos en tipo de referidor esta nuevo
                    estTemporal.a13SeDeconoceReferencia = "True"

                End If




            Else
                'no hay archivo de datos complementarios se debe desconocer entonces
                estTemporal.a13SeDeconoceReferencia = "True"
            End If

            'ok ahora ya se debe haber modificado a = o se debe haber puesto cuantas referidas tiene la añado a la als
            alsPacientesTemporal.Add(estTemporal)

        Next

        'ya tengo la recopilacion de los datos de referidas los devuelvo a la als publica
        alsPacientes.Clear()

        For Each est As Form1.TablaDePacientesBDH In alsPacientesTemporal
            alsPacientes.Add(est)
        Next


    End Sub
    Private Sub subBuscaDatosDeLasConsultas()
        Dim strArchivoDeConsultasLocal As String = ""
        Dim alsPacientesTemporal As New ArrayList 'guarda los datos temporale mientras se van recopilando
        Dim alsConsultasDelPteActual As New ArrayList

        'inicializa la temporal
        alsPacientesTemporal.Clear()

        'solo muestra la actualizacion del lab si se esta cargando la base para ahorrar tiempo. esto seejecuta tambien cuando se añade una nueva historia
        If PSbooBaseDeDatos_ProcesoDeAbrir = True Then
            'refresca la pantalla para q no se bloquue
            labMensajedeAgenda.Text = "Buscando Datos de Consultas..."
            Me.Refresh()
        End If

        'vamos a buscar las referidoras
        For Each est As Form1.TablaDePacientesBDH In Form1.alsPacientes

            'va copiando las als al principio todo igual
            Dim estTemporal = est
            'inicializa el valor que se esta buscando  si hay algo se cambiara
            estTemporal.a08NumeroDeConsultas = "0"
            estTemporal.a07TieneConsultaPendiente = "False"
            estTemporal.a15FechaProximoControl = ""
            estTemporal.a17PacienteDesde = ""

            'crea la ruta al archivo de referencias
            strArchivoDeConsultasLocal = Form1.PSstrPathHistoriasSinPrefijo & "\" & est.a01NumeroHistoria.Substring(0, 5) & "\" & est.a01NumeroHistoria & ".agd"
            If File.Exists(strArchivoDeConsultasLocal) Then
                'esxiste lo lee
                Dim BR As BinaryReader
                Dim FS As FileStream
                Dim Ag As Form1.TablaDeArchivosPropiosDeAgenda
                Dim C As Integer

                'inicializa la als de consultas de esta pte
                alsConsultasDelPteActual.Clear()

                'ya esta comprobado q existe
                FS = New FileStream(strArchivoDeConsultasLocal, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)

                ' Read todo
                C = BR.PeekChar
                While FS.Position < FS.Length
                    Ag = Nothing
                    Ag.a10FechaConsulta = BR.ReadString
                    Ag.a02Clinica = BR.ReadString
                    Ag.a03NotaseIDx = BR.ReadString
                    Ag.a04Tratamiento = BR.ReadString
                    Ag.a05Pendiente = BR.ReadString
                    Ag.a06ProximaConsulta = BR.ReadString
                    Ag.a07Honorarios = BR.ReadString
                    Ag.a11FacturaAsociada = BR.ReadString
                    Ag.a16Referencia = BR.ReadString
                    Ag.a15Banco = BR.ReadString
                    Ag.a14FormaDePago = BR.ReadString
                    Ag.a13FechaDePago = BR.ReadString
                    Ag.a12Pagador = BR.ReadString

                    'las incluye en la lista de otras referidas
                    alsConsultasDelPteActual.Add(Ag)

                End While

                If alsConsultasDelPteActual.Count > 0 Then
                    'ok hay alguna referida las ordena para revisar la ultima
                    Dim alsConsultasOrdenadas = From estConsulta As Form1.TablaDeArchivosPropiosDeAgenda In alsConsultasDelPteActual
                                                Order By CType(estConsulta.a10FechaConsulta, Date) Descending
                                                Select estConsulta

                    'revisa si en el dato (0) q es la ultima consulta hay alguna fecha proxima
                    If alsConsultasOrdenadas(0).a06ProximaConsulta <> "" Then
                        'hay algo ahi debe haber una consulta proxima pendiente
                        estTemporal.a07TieneConsultaPendiente = "True"
                        estTemporal.a15FechaProximoControl = alsConsultasOrdenadas(0).a06ProximaConsulta
                    End If

                    'ahora revisa desde cuando es paciente
                    estTemporal.a17PacienteDesde = alsConsultasOrdenadas(alsConsultasOrdenadas.Count - 1).a10FechaConsulta

                    'el numero de consultas es facil no...
                    estTemporal.a08NumeroDeConsultas = alsConsultasDelPteActual.Count.ToString

                Else
                    'deja todo igual en "0" como estaba inicializado
                End If

                'cierra la vaina
                BR.Close()
                FS.Close()
            End If

            'ok ahora ya se debe haber modificado a = o se debe haber puesto cuantas referidas tiene la añado a la als
            alsPacientesTemporal.Add(estTemporal)

        Next

        'ya tengo la recopilacion de los datos de referidas los devuelvo a la als publica
        alsPacientes.Clear()

        For Each est As Form1.TablaDePacientesBDH In alsPacientesTemporal
            alsPacientes.Add(est)
        Next


    End Sub

    Private Sub ConfiguracionBaseDatosNoCargada()


        MenuCreaBase.Enabled = True
        MenuAbreBase.Enabled = True
        MenuDatosDelUsuario.Enabled = False

        Me.Text = "Historias Clínicas"

        ListBoxHistorias.Items.Clear()
        ListBoxContenido.Items.Clear()
        ListBoxConsultas.Items.Clear()

        subLimpiaCuadrosDeTextoDeAgendaEnForm1()

        botAbrirHistoria.Enabled = False
        BotNuevaHistoria.Enabled = False
        botIntervenciones.Enabled = False
        botPagos.Enabled = False

        txtFiltro.Enabled = False

        txtBASEnotificaciones.Clear()

        botRenombraHistoria.Enabled = False
        botGuardias.Enabled = False

        Filtro = False
        botCerrarHistoria.Enabled = False
        botCerrarHistoria2.Enabled = False
        botConsultaHoy.Enabled = False
        LabNumeroSeleccionado.Text = ""
        LabCedulaSeleccionada.Text = ""
        LabNombreSeleccionado.Text = ""
        LabHistoriaAbierta.Text = ""

        LabNombreSeleccionado3.Text = "fue referida por"
        LabNombreSeleccionado4.Text = "ha referido a"
        labDCpacientesReferidasPorReferidor.Text = "ha referido a"
        labDCpacientesReferidasPorReferidor.Visible = False
        txtDCpacientesReferidasPorReferidor.Visible = False

        'chequea todas las pacientes
        radBASEtodasLasPacientes.Checked = True
        'apaga todos los rads
        radBASEacudieronExpontaneamente.Enabled = False
        radBASEconConsultaPendiente.Enabled = False
        radBASEconConsultaPendienteProxMes.Enabled = False
        radBASEControlObs.Enabled = False
        radBASEembarazadas.Enabled = False
        radBASEpacientesReferidasPorPtes.Enabled = False
        radBASEpacientesReferidoras.Enabled = False
        radBASEptesDeOtrosMedicos.Enabled = False
        radBASEReferidasPorOtros.Enabled = False
        radBASEseDesconoceReferencia.Enabled = False
        radBASEtodasLasPacientes.Enabled = False

        LabNombreBaseDatos.Text = "Ninguna"
        LabelFiltro.Text = "Todos los Pacientes de la Base de Datos = 0  Pacientes"
        botDatosPersonales.Enabled = False
        BotControlGinecologico.Enabled = False
        botNuevaHistoriaObstetrica.Enabled = False
        botNuevoEco.Enabled = False

        LabMensajeBaseDatos.Text = "Primero ABRE o CREA una Base de Datos..."
        LabMensajeBaseDatos.Image = BarraMensajeMal
        labMensajedeAgenda.Text = ""
        labMensajedeAgenda.Image = BarraSinMensaje

        '=================== parte del respaldo de archivos
        SeModificaronDatos = False
        '=================== parte de la agenda
        PSdateFechaDeArraqueDeAgenda = Today

        '---colores
        TabControl1.BackColor = Color.OldLace

        'ìnicializa las tab page de los aniversarios y etarios
        PanelAniversarios.Enabled = False
        ListBoxCH.Items.Clear()
        ListBoxCS.Items.Clear()
        PanelEtarios.Enabled = False
        ListBoxEdades.Items.Clear()

        'inicializa panel de datos complementarios
        LimpiaDatosComplementariosDePantalla()
        TabControlNotas.Enabled = False

        'actualiza bandera de base de datos no cargada
        BaseDeDatosCargada = False
        'actualiza la bandera de form1.existendatosdelusuario
        Form1.booExistenDatosDelUsuario = False
        Form1.imagenLogoDelUsuario = FormImagenes.picImagenVacia.Image
        Form1.booSeDebeActualizarImagenDelUsuarioAlCerrar = False
    End Sub
    Private Sub ConfiguracionBaseDatosVacia()
        botAbrirHistoria.Enabled = False
        botRenombraHistoria.Enabled = False
        BotNuevaHistoria.Enabled = True
        botGuardias.Enabled = False
        botIntervenciones.Enabled = True
        botPagos.Enabled = True

        Me.Text = "Historias Clínicas"

        txtFiltro.Enabled = False

        ListBoxConsultas.Items.Clear()

        subLimpiaCuadrosDeTextoDeAgendaEnForm1()

        MenuCreaBase.Enabled = True
        MenuAbreBase.Enabled = True
        MenuDatosDelUsuario.Enabled = True
        botCerrarHistoria.Enabled = False
        botConsultaHoy.Enabled = False
        botCerrarHistoria2.Enabled = False
        LabNumeroSeleccionado.Text = ""
        LabCedulaSeleccionada.Text = ""
        LabNombreSeleccionado.Text = ""
        LabHistoriaAbierta.Text = ""

        txtBASEnotificaciones.Clear()

        LabNombreSeleccionado3.Text = "fue referida por"
        LabNombreSeleccionado4.Text = "ha referido a"
        labDCpacientesReferidasPorReferidor.Text = "ha referido a"
        labDCpacientesReferidasPorReferidor.Visible = False
        txtDCpacientesReferidasPorReferidor.Visible = False

        ListBoxContenido.Items.Clear()

        labMensajedeAgenda.Text = ""
        labMensajedeAgenda.Image = BarraSinMensaje

        botDatosPersonales.Enabled = False
        BotControlGinecologico.Enabled = False
        botNuevaHistoriaObstetrica.Enabled = False
        botNuevoEco.Enabled = False

        LabMensajeBaseDatos.Text = "Primero CREA la primera Historia de la Base de Datos..."
        LabMensajeBaseDatos.Image = BarraMensajeMal

        LabNombreBaseDatos.Text = PSstrArchivoNombreBaseDeDatos
        LabelFiltro.Text = "Todos los Pacientes de la Base de Datos = 0  Pacientes"

        radBASEacudieronExpontaneamente.Enabled = False
        radBASEconConsultaPendiente.Enabled = False
        radBASEconConsultaPendienteProxMes.Enabled = False
        radBASEControlObs.Enabled = False
        radBASEembarazadas.Enabled = False
        radBASEpacientesReferidasPorPtes.Enabled = False
        radBASEpacientesReferidoras.Enabled = False
        radBASEptesDeOtrosMedicos.Enabled = False
        radBASEReferidasPorOtros.Enabled = False
        radBASEseDesconoceReferencia.Enabled = False
        radBASEtodasLasPacientes.Enabled = False

        'actualiza bandera de base de datos cargada
        BaseDeDatosCargada = True
    End Sub
    Private Sub ConfiguracionBaseDatosNoVacia()
        botAbrirHistoria.Enabled = False
        botRenombraHistoria.Enabled = False
        BotNuevaHistoria.Enabled = True
        botGuardias.Enabled = True
        botIntervenciones.Enabled = True
        botPagos.Enabled = True

        txtFiltro.Enabled = True

        txtBASEresumenPte.Clear()

        ListBoxConsultas.Items.Clear()

        subLimpiaCuadrosDeTextoDeAgendaEnForm1()

        MenuCreaBase.Enabled = True
        MenuAbreBase.Enabled = True
        MenuDatosDelUsuario.Enabled = True
        botCerrarHistoria.Enabled = False
        botCerrarHistoria2.Enabled = False
        botConsultaHoy.Enabled = False
        LabNumeroSeleccionado.Text = ""
        LabCedulaSeleccionada.Text = ""
        LabNombreSeleccionado.Text = ""
        LabHistoriaAbierta.Text = ""

        LabNombreSeleccionado3.Text = "fue referida por"
        LabNombreSeleccionado4.Text = "ha referido a"
        labDCpacientesReferidasPorReferidor.Text = "ha referido a"
        labDCpacientesReferidasPorReferidor.Visible = False
        txtDCpacientesReferidasPorReferidor.Visible = False


        ListBoxContenido.Items.Clear()
        botDatosPersonales.Enabled = False
        BotControlGinecologico.Enabled = False
        botNuevaHistoriaObstetrica.Enabled = False
        botNuevoEco.Enabled = False

        LabMensajeBaseDatos.Text = "Selecciona una historia de la Lista o Crea una Historia Nueva"
        LabMensajeBaseDatos.Image = BarraMensajeBien
        labMensajedeAgenda.Text = ""
        labMensajedeAgenda.Image = BarraSinMensaje
        LabNombreBaseDatos.Text = PSstrArchivoNombreBaseDeDatos

        radBASEacudieronExpontaneamente.Enabled = True
        radBASEconConsultaPendiente.Enabled = True
        radBASEconConsultaPendienteProxMes.Enabled = True
        radBASEControlObs.Enabled = True
        radBASEembarazadas.Enabled = True
        radBASEpacientesReferidasPorPtes.Enabled = True
        radBASEpacientesReferidoras.Enabled = True
        radBASEptesDeOtrosMedicos.Enabled = True
        radBASEReferidasPorOtros.Enabled = True
        radBASEseDesconoceReferencia.Enabled = True
        radBASEtodasLasPacientes.Enabled = True

        'actualiza bandera de base de datos cargada
        BaseDeDatosCargada = True
    End Sub


    Private Sub radBASEgrupos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
Handles radBASEtodasLasPacientes.CheckedChanged, radBASEpacientesReferidoras.CheckedChanged, radBASEpacientesReferidasPorPtes.CheckedChanged, radBASEControlObs.CheckedChanged, radBASEembarazadas.CheckedChanged, radBASEReferidasPorOtros.CheckedChanged, radBASEptesDeOtrosMedicos.CheckedChanged, radBASEacudieronExpontaneamente.CheckedChanged, radBASEconConsultaPendiente.CheckedChanged, radBASEseDesconoceReferencia.CheckedChanged, radBASEconConsultaPendienteProxMes.CheckedChanged

        MuestraContenidoBaseDatos()

        ConfiguracionBaseDatosNoVacia()

    End Sub


    Private Sub MuestraContenidoBaseDatos()

        Dim Linea As String
        Dim Filtro As String
        Dim alsGrupoSeleccionado As New ArrayList

        'limpia lista de pacientes
        ListBoxHistorias.Items.Clear()
        'inicilaiza el array con los datos de las ptes filtradas segun grupo y filtro
        arrayPacientesFiltrados.Clear()
        alsGrupoSeleccionado.Clear()
        'carga el filtro sea lo q sea q este
        Filtro = txtFiltro.Text.ToUpper

        'revisa q esta seleccionado
        If radBASEtodasLasPacientes.Checked = True Then
            'grupo todas las pacientes
            For Each est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Todas las Pacientes "

        ElseIf radBASEpacientesReferidoras.Checked = True Then
            'grupo de ptes referidoras
            Dim alsReferidoras = From est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                                 Where est.a04NumeroDeReferidas <> "0"
                                 Order By CType(est.a04NumeroDeReferidas, Integer) Descending
                                 Select est

            For Each est As Form1.TablaDePacientesBDH In alsReferidoras
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Referidoras "

        ElseIf radBASEpacientesReferidasPorPtes.Checked = True Then
            'grupo de ptes referidas x ptes
            Dim alsReferidasPorPtes = From est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                                      Where est.a10FueReferidaPorPaciente = "True"
                                      Order By CType(est.a08NumeroDeConsultas, Integer) Descending
                                      Select est

            For Each est As Form1.TablaDePacientesBDH In alsReferidasPorPtes
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Referidas x Otras Ptes "

        ElseIf radBASEReferidasPorOtros.Checked = True Then
            'grupo de ptes referidas x ptes
            Dim alsReferidasPorOtros = From est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                                       Where est.a11FueReferidaPorOtroReferidor = "True"
                                       Order By CType(est.a08NumeroDeConsultas, Integer) Descending
                                       Select est

            For Each est As Form1.TablaDePacientesBDH In alsReferidasPorOtros
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Referidas x Otros Referidores "

        ElseIf radBASEptesDeOtrosMedicos.Checked = True Then
            'grupo de ptes de otros medicos
            Dim alsPtesDeOtrosMedicos = From est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                                        Where est.a12EsPacienteDeOtroMedico = "True"
                                        Order By est.a01NumeroHistoria
                                        Select est

            For Each est As Form1.TablaDePacientesBDH In alsPtesDeOtrosMedicos
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Pacientes de Otros Médicos "

        ElseIf radBASEacudieronExpontaneamente.Checked = True Then
            'grupo de ptes acudieron expontaneo
            Dim alsAcudieronExp = From est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                                  Where est.a09VinoExpontaneamente = "True"
                                  Order By CType(est.a08NumeroDeConsultas, Integer) Descending
                                  Select est

            For Each est As Form1.TablaDePacientesBDH In alsAcudieronExp
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Pacientes que acudieron expontáneamente "

        ElseIf radBASEControlObs.Checked = True Then
            'grupo de ptes con control obs
            Dim alsConControlObs = From est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                                   Where est.a05TieneControlObstetrico = "True" And IsDate(est.a14FURdelUltimoControl)
                                   Order By CType(est.a14FURdelUltimoControl, Date) Descending
                                   Order By est.a06EstaEmbarazada Descending
                                   Select est

            For Each est As Form1.TablaDePacientesBDH In alsConControlObs
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Pacientes con Control Obstétrico "

            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        ElseIf radBASEseDesconoceReferencia.Checked = True Then
            'grupo de ptes referencia desconocida
            Dim alsSeDesconoceReferencia = From est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                                           Where est.a13SeDeconoceReferencia = "True"
                                           Select est

            For Each est As Form1.TablaDePacientesBDH In alsSeDesconoceReferencia
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Pacientes con Referencia Desconocida "
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        ElseIf radBASEembarazadas.Checked = True Then
            'grupo de ptes embarzadas
            Dim alsEmbarazadas = From est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                                 Where est.a06EstaEmbarazada = "True" And IsDate(est.a14FURdelUltimoControl)
                                 Order By CType(est.a14FURdelUltimoControl, Date) Descending
                                 Select est

            For Each est As Form1.TablaDePacientesBDH In alsEmbarazadas
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Pacientes Embarazadas "

        ElseIf radBASEconConsultaPendiente.Checked = True Then
            'grupo de ptes con consulta pendiente vencida o no
            Dim alsConConsultaPendiente = From est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                                          Where est.a07TieneConsultaPendiente = "True" And IsDate(est.a15FechaProximoControl)
                                          Order By CType(est.a15FechaProximoControl, Date)
                                          Select est

            For Each est As Form1.TablaDePacientesBDH In alsConConsultaPendiente
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Con Consulta pendiente "

        ElseIf radBASEconConsultaPendienteProxMes.Checked = True Then
            'grupo de ptes con consulta pendiente prox 30 dias
            Dim alsConConsultaPendiente = From est As Form1.TablaDePacientesBDH In Form1.alsPacientes
                                          Where est.a07TieneConsultaPendiente = "True" AndAlso IsDate(est.a15FechaProximoControl)
                                          Order By CType(est.a15FechaProximoControl, Date)
                                          Select est

            Dim alsConConsultaPendienteProxMes = From est As Form1.TablaDePacientesBDH In alsConConsultaPendiente
                                                 Where CType(est.a15FechaProximoControl, Date) >= Today And CType(est.a15FechaProximoControl, Date) < Today.AddDays(30)
                                                 Select est

            For Each est As Form1.TablaDePacientesBDH In alsConConsultaPendienteProxMes
                alsGrupoSeleccionado.Add(est)
            Next
            'va construyendo el label
            LabelFiltro.Text = "Con Consulta pendiente Proximos 30 días "

        End If

        Dim strNombre35espacios As String = ""
        Dim strCedula8espacios As String = ""

        'recorre la als del grupo seleccionado de historias para filtrar con el filtro de texto (si lo hay)
        For Each est As Form1.TablaDePacientesBDH In alsGrupoSeleccionado

            If est.a02NombrePaciente.Length > 35 Then
                strNombre35espacios = est.a02NombrePaciente.Substring(0, 35)
            Else
                strNombre35espacios = est.a02NombrePaciente.PadRight(35, " "c)
            End If

            strCedula8espacios = est.a03CedulaPaciente.PadLeft(8, "0"c)

            Linea = ""

            If radBASEtodasLasPacientes.Checked = True Then
                If IsDate(est.a17PacienteDesde) Then
                    Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a04NumeroDeReferidas.PadLeft(2, "0"c) & "   |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   |   " & CType(est.a17PacienteDesde, Date).ToShortDateString & "   |   "
                Else
                    Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a04NumeroDeReferidas.PadLeft(2, "0"c) & "   |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   |   " & "(N/A)        |   "
                End If

            ElseIf radBASEpacientesReferidoras.Checked = True Then
                Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a04NumeroDeReferidas.PadLeft(2, "0"c) & "   |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   |   "

            ElseIf radBASEpacientesReferidasPorPtes.Checked = True Then
                Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a04NumeroDeReferidas.PadLeft(2, "0"c) & "   |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   |   " & est.A16NombreDelReferidor

            ElseIf radBASEReferidasPorOtros.Checked = True Then
                Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a04NumeroDeReferidas.PadLeft(2, "0"c) & "   |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   |   " & est.A16NombreDelReferidor
            ElseIf radBASEptesDeOtrosMedicos.Checked = True Then
                Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a04NumeroDeReferidas.PadLeft(2, "0"c) & "   |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   |   " & est.A16NombreDelReferidor
            ElseIf radBASEacudieronExpontaneamente.Checked = True Then
                Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a04NumeroDeReferidas.PadLeft(2, "0"c) & "   |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   |   "
            ElseIf radBASEseDesconoceReferencia.Checked = True Then
                Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a04NumeroDeReferidas.PadLeft(2, "0"c) & "   |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   |   "

            ElseIf radBASEControlObs.Checked = True Then
                Dim strEstaEmbarazada = ""
                Dim strEG = ""
                If est.a06EstaEmbarazada = "True" Then
                    strEstaEmbarazada = "Si"
                    'se debe calcular la eg
                    If IsDate(est.a14FURdelUltimoControl) Then
                        strEG = funcionCalculaEGconFURhastaHoyRetornaStringXXsXXd(CType(est.a14FURdelUltimoControl, Date))
                    Else
                        strEG = "revisar"
                    End If
                    Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |     " & strEstaEmbarazada & "     |  " & strEG.PadLeft(7, " "c) & "  | " & est.A16NombreDelReferidor
                Else
                    strEstaEmbarazada = "No"
                    strEG = ""
                    Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |     " & strEstaEmbarazada & "     |  " & strEG.PadLeft(7, " "c) & "  | " & est.A16NombreDelReferidor
                End If

            ElseIf radBASEembarazadas.Checked = True Then
                Dim strEG = ""
                Dim str38a39 = ""
                'se debe calcular la eg
                If IsDate(est.a14FURdelUltimoControl) Then
                    strEG = funcionCalculaEGconFURhastaHoyRetornaStringXXsXXd(CType(est.a14FURdelUltimoControl, Date))
                    Dim date38sem = (CType(est.a14FURdelUltimoControl, Date)).AddDays(266)
                    Dim date39sem = date38sem.AddDays(7)
                    str38a39 = "(" & date38sem.Day.ToString.PadLeft(2, "0") & "-" & date38sem.Month.ToString.PadLeft(2, "0") & " al " & date39sem.Day.ToString.PadLeft(2, "0") & "-" & date39sem.Month.ToString.PadLeft(2, "0") & ")"
                Else
                    strEG = "revisar"
                    str38a39 = "(              )"
                End If
                Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   | " & strEG.PadLeft(7, " "c) & "  | " & str38a39

            ElseIf radBASEconConsultaPendiente.Checked = True Then
                Dim strProxControl = ""
                If IsDate(est.a15FechaProximoControl) Then
                    strProxControl = CType(est.a15FechaProximoControl, Date).ToShortDateString
                Else
                    strProxControl = "revisar "
                End If
                Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   |   " & strProxControl & "   |"

            ElseIf radBASEconConsultaPendienteProxMes.Checked = True Then
                Dim strProxControl = ""
                If IsDate(est.a15FechaProximoControl) Then
                    strProxControl = CType(est.a15FechaProximoControl, Date).ToShortDateString
                Else
                    strProxControl = "revisar "
                End If
                Linea = est.a01NumeroHistoria & " | " & strCedula8espacios & " | " & strNombre35espacios & " |   " & est.a08NumeroDeConsultas.PadLeft(3, "0"c) & "   |   " & strProxControl & "   |"

            End If



            If Filtro = "" Then
                'no hay filtro, pasan todos
                ListBoxHistorias.Items.Add(Linea)
                arrayPacientesFiltrados.Add(est)
            Else
                'hay filtro, verifica la cadena
                If Linea.ToUpper.Contains(Filtro) Then
                    'la cadena concuerda con el filtro la añade
                    ListBoxHistorias.Items.Add(Linea)
                    arrayPacientesFiltrados.Add(est)
                Else
                    'no concuerda, no lo añade ni al listbox ni al array
                End If
            End If
        Next

        'aqui solo para poner la etiqueta del filtro
        If Filtro = "" Then
            LabelFiltro.Text += " =  " & arrayPacientesFiltrados.Count
        Else
            LabelFiltro.Text += " =  Mostrando " & arrayPacientesFiltrados.Count & " de " & alsGrupoSeleccionado.Count & " filtradas x (" & Filtro & ")"
        End If


        'y aca para el encabezado de la tabla una sola vez claro
        If radBASEtodasLasPacientes.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE                #REF   #CONS      Pte Desde"
        ElseIf radBASEpacientesReferidoras.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE                #REF   #CONS "
        ElseIf radBASEpacientesReferidasPorPtes.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE                #REF   #CONS            Pte. REFERIDORA"
        ElseIf radBASEReferidasPorOtros.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE                #REF   #CONS            OTRO REFERIDOR"
        ElseIf radBASEptesDeOtrosMedicos.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE                #REF   #CONS            MEDICO"
        ElseIf radBASEacudieronExpontaneamente.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE                #REF   #CONS "
        ElseIf radBASEseDesconoceReferencia.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE                #REF   #CONS "
        ElseIf radBASEControlObs.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE               EMBARAZADA     EG            PROCEDENCIA"
        ElseIf radBASEembarazadas.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE                #CONS      EG      38 a 39 SEM"
        ElseIf radBASEconConsultaPendiente.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE                #CONS   PROX.CONTROL "
        ElseIf radBASEconConsultaPendienteProxMes.Checked = True Then
            labEncabezado.Text = "  No.      C.I.                NOMBRE                #CONS   PROX.CONTROL "
        End If


    End Sub

#End Region

    Private Sub txtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged
        MuestraContenidoBaseDatos()
        botAbrirHistoria.Enabled = False
        botRenombraHistoria.Enabled = False
        LabNumeroSeleccionado.Text = ""
        LabNombreSeleccionado.Text = ""
        LabCedulaSeleccionada.Text = ""
        txtBASEresumenPte.Text = ""
        labMensajedeAgenda.Text = ""
        labMensajedeAgenda.Image = BarraSinMensaje
        LabMensajeBaseDatos.Text = "Selecciona de la Lista una historia o Crea una Historia Nueva"
        LabMensajeBaseDatos.Image = BarraMensajeBien


    End Sub

    Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
        If TabControl2.SelectedIndex = 1 Then
            If SeCargaronLosDatosDeAniversario = False Then
                CompruebaCumpleaños()
            End If
        End If
        If TabControl2.SelectedIndex = 2 Then
            If SeCargaronLosDatosDeAniversario = False Then
                CompruebaCumpleaños()
            End If
        End If
    End Sub

    Private Sub ListBoxHistorias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxHistorias.SelectedIndexChanged

        Dim Indice As Integer

        '---------------------------------------------------------------------------------------

        If ListBoxHistorias.SelectedIndex = -1 Then
            Exit Sub
        End If

        Indice = ListBoxHistorias.SelectedIndex
        Dim estHistoria As Form1.TablaDePacientesBDH = arrayPacientesFiltrados(Indice)

        'Coloca en los labels la historia señalada
        LabNumeroSeleccionado.Text = estHistoria.a01NumeroHistoria
        LabNombreSeleccionado.Text = estHistoria.a02NombrePaciente
        LabCedulaSeleccionada.Text = estHistoria.a03CedulaPaciente

        botAbrirHistoria.Enabled = True
        botRenombraHistoria.Enabled = True
        LabMensajeBaseDatos.Text = "Ahora puedes ABRIR o RENOMBRAR la Historia seleccionada ó CREAR una nueva"

        'muestra los datos de proxima consulta en los labels
        labMensajedeAgenda.Text = "Esta paciente no tiene citas programadas" 'inicializo con el mensaje como si no tuviese consulta---
        labMensajedeAgenda.Image = BarraSinMensaje

        If estHistoria.a07TieneConsultaPendiente = "True" Then 'ojo es una cadena por eso las comillas

            'comprueba q la fecha este bien
            If IsDate(CType(estHistoria.a15FechaProximoControl, Date)) Then
                If CType(estHistoria.a15FechaProximoControl, Date) < Today Then
                    'debia haber venido antes
                    labMensajedeAgenda.Text = estHistoria.a02NombrePaciente & " tenía cita el " & CType(estHistoria.a15FechaProximoControl, Date).ToShortDateString
                    labMensajedeAgenda.Image = BarraMensajeMal
                ElseIf CType(estHistoria.a15FechaProximoControl, Date) = Today Then
                    'vino el dia preciso
                    labMensajedeAgenda.Text = estHistoria.a02NombrePaciente & " tiene cita hoy " & Today.ToShortDateString
                    labMensajedeAgenda.Image = BarraMensajeBien
                Else
                    'vino antes de tiempo
                    labMensajedeAgenda.Text = estHistoria.a02NombrePaciente & " tiene cita para el " & CType(estHistoria.a15FechaProximoControl, Date).ToShortDateString
                    labMensajedeAgenda.Image = BarraMensajeBien
                End If
            Else
                'no es fecha valida lo pone como si no tuviese control
            End If
            'es false no tiene consulas
        End If

        'busaca resumen corto de la pte
        subRecopilaMuestraResumenCortoDeLaPaciente()

    End Sub


    Private Sub txtBASEresumenPte_DoubleClick(sender As Object, e As System.EventArgs) Handles txtBASEresumenPte.DoubleClick


        'revisa si escrito y no esta abierta una historia
        If PSbooHistoriaAbierta = False And txtBASEresumenPte.Text <> "" Then

            If alsOtrasReferidasPorPte.Count = 0 Then
                MsgBox("La Paciente seleccionada no ha referido a nadie...")
            Else
                'muestra las pacientes referidas por la paciente
                radBASEpacientesReferidasPorPtes.Checked = True
                txtFiltro.Text = PSstrPacienteSeleccionadaNombre
                txtFiltro.Focus()
                txtFiltro.SelectAll()

            End If

        End If
    End Sub

    'hace la variable publica a otros procedimientos de form1
    Dim alsOtrasReferidasPorPte As New ArrayList

    Private Sub subRecopilaMuestraResumenCortoDeLaPaciente()

        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim DP As New DatosPersonales
        Dim DC As New DatosComplementarios

        Dim intIndice As Integer = ListBoxHistorias.SelectedIndex
        Dim estHistoria As Form1.TablaDePacientesBDH = arrayPacientesFiltrados(intIndice)

        'estos son datos publicos necesarios para recopilar datos como si se hubiese abierto la historia realmente
        PSstrNumeroHistoriaSeleccionada = estHistoria.a01NumeroHistoria
        PSstrPacienteSeleccionadaCedula = estHistoria.a03CedulaPaciente
        PSstrPacienteSeleccionadaNombre = estHistoria.a02NombrePaciente
        PSstrPrefijoHistoriaSeleccionada = estHistoria.a01NumeroHistoria.Remove(5, 1)
        PSstrPathHistoriasConPrefijo = PSstrPathHistoriasSinPrefijo & "\" & PSstrPrefijoHistoriaSeleccionada 'la sin prefijo se calcula al abrir la base la con depende del numero de historia (prefijo)

        'variable para ir construyendo el mensaje
        Dim strResumenDeLaPte As String = ""

        'contruye el nombre del archivo con los datos personales
        Dim strArchivoDatosPersonales As String = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Personales.dat"
        'el archivo con las referidas por esta paciente
        Dim strArchivoDeReferidasPorLaPte = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Referidas.dat"
        'contruye el nombre del archivo con los datos de antecedentes obstetricos
        Dim strArchivoAntObstetricosBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Ant Obstetricos.dat"
        'construye el nombre del archivo de la agenda buscado
        Dim strArchivoAgendaBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & ".agd"
        'contruye el nombre del archivo con los datos complementarios
        Dim strArchivoDatosComplementariosBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Complementarios.dat"


        'lo primero el nombre
        Dim strNombrePte As String = ""
        strNombrePte = "Nombre: " & estHistoria.a02NombrePaciente.ToUpper

        'Busca la paridad en los antecedentes obstetricos, prende la bandera de q solo va a consultar
        Dim strLocalParidad As String = ""

        subBuscaParidadDeLaPacienteSeleccionada()
        If Form1.PSstrPacienteSeleccionadaParidad <> "" Then
            'trae algun dato
            strLocalParidad = "Paridad: " & Form1.PSstrPacienteSeleccionadaParidad
            If Form1.PSintPesoMaximo <> 0 Then
                'hay algun dato de peso lo muestra
                strLocalParidad += vbCrLf & "Peso Max: " & Form1.PSintPesoMaximo.ToString & " gr"
            End If
        Else
            strLocalParidad = "Paridad: No Incluida."
        End If


        'busqueda de datos de la agenda de este paciente
        Dim strPacienteDesde As String = ""
        Dim strUltimaConsultaFue As String = ""
        Dim strProximaConsultaES As String = ""
        Dim strNumeroDeConsultas As String = ""
        Dim strNotasSubjetivasUltimaConsulta As String = ""

        If File.Exists(strArchivoAgendaBuscado) Then 'existe archivo de agenda propio de esta historia lo lee
            Dim T1 As TablaDeArchivosPropiosDeAgenda
            Dim alsConsultasDeLaPte As New ArrayList
            Dim FechasDeConsulta As Date = Today

            Dim year2008 As Date = #12/31/2007#


            FS = New FileStream(strArchivoAgendaBuscado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            alsConsultasDeLaPte.Clear()

            Dim C = BR.PeekChar

            While FS.Position < FS.Length

                T1 = Nothing

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

                'acomoda la fecha a sorteable y calcula los honorarios de una vez
                If IsDate(T1.a10FechaConsulta) Then
                    'acomoda la fecha
                    Dim dateFechaDeLaConsulta = CType(T1.a10FechaConsulta, Date)
                    T1.a10FechaConsulta = dateFechaDeLaConsulta.ToString("s")

                    'finalmente añade a la als
                    alsConsultasDeLaPte.Add(T1)

                End If



                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'ahora ordena las fechas de consulta y saca la primera consulta
            Dim alsConsultasOrdenadasDeLaPtePorFecha = From est As Form1.TablaDeArchivosPropiosDeAgenda In alsConsultasDeLaPte
                                                       Order By est.a10FechaConsulta
                                                       Select est

            Dim intCuentaDeConsultas = alsConsultasOrdenadasDeLaPtePorFecha.Count

            'revisa si al final quedaron consultas q examinar
            If intCuentaDeConsultas > 0 Then 'si hay cponsultas examina

                'desde cuando es paciente
                If IsDate(alsConsultasOrdenadasDeLaPtePorFecha(0).a10FechaConsulta) Then
                    strPacienteDesde = "Paciente Desde: " & (CType(alsConsultasOrdenadasDeLaPtePorFecha(0).a10FechaConsulta, Date)).ToShortDateString
                Else
                    strPacienteDesde = "Paciente Desde: (N/A)"
                End If

                'ultima consulta 'si hay mas de dos
                If intCuentaDeConsultas > 1 Then
                    If IsDate(alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a10FechaConsulta) Then
                        strUltimaConsultaFue = "Ultima Consulta: " & (CType(alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a10FechaConsulta, Date)).ToShortDateString
                    Else
                        strUltimaConsultaFue = "Ultima Consulta: (N/A) (REVISA)"
                    End If

                Else
                    strUltimaConsultaFue = "Ultima Consulta: (solo 1 consulta)"
                End If

                'proxima consulta
                If IsDate(alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a06ProximaConsulta) Then
                    'ES DATE PROCEDE
                    strProximaConsultaES = "Próxima Consulta: " & (CType(alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a06ProximaConsulta, Date)).ToShortDateString
                Else
                    'NO ES DATE
                    strProximaConsultaES = "Próxima Consulta: (N/A)"
                End If

                'el numero de consultas 
                strNumeroDeConsultas = "Número de Consultas: " & intCuentaDeConsultas.ToString

                'los datos subjetivos de la ultima consulta
                strNotasSubjetivasUltimaConsulta = "Notas de la Ultima Consulta: " & alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a03NotaseIDx

            Else
                'no hay consultas....}
                strPacienteDesde = "Paciente Desde: (N/A)"
                strUltimaConsultaFue = "Ultima Consulta: (N/A)"
                strProximaConsultaES = "Próxima Copnsulta: (N/A)"
                strNumeroDeConsultas = "Número de Consultas: 0"
                strNotasSubjetivasUltimaConsulta = "Notas de la Ultima Consulta: (N/A)"

            End If


        Else
            'no hay archivo muestra q faltan datos en la casillas correspondientes
            strPacienteDesde = "Paciente Desde: (N/A)"
            strUltimaConsultaFue = "Ultima Consulta: (N/A)"
            strProximaConsultaES = "Próxima Copnsulta: (N/A)"
            strNumeroDeConsultas = "Número de Consultas: 0"
            strNotasSubjetivasUltimaConsulta = "Notas de la Ultima Consulta: (N/A)"
        End If

        'busca los datos complementaRIOS DE LA PTE
        Dim strPteReferidaPor As String = ""
        Dim strCelularVefificado As String = ""


        If File.Exists(strArchivoDatosComplementariosBuscado) Then 'existe archivo lo lee
            FS = New FileStream(strArchivoDatosComplementariosBuscado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            ' Read 
            DC = Nothing 'inicializa cada vez para no retener datos del anterior
            DC.a01Notas = BR.ReadString
            DC.a02Resumen = BR.ReadString
            DC.a03NumeroDelReferidor = BR.ReadString
            DC.a04Vinculos = BR.ReadString
            DC.a05ReferidaPor = BR.ReadString
            DC.a06TelefonoVerificado = BR.ReadString 'esta sera si el telefono esta verificado una fecha en string
            DC.a07UltimoSMS = BR.ReadString 'este sera el ultimo sms enviado a la pte
            DC.a08TipoDeReferidor = BR.ReadString
            DC.a09VinculoConReferidor = BR.ReadString
            DC.a10 = BR.ReadString

            'cierra la vaina
            BR.Close()
            FS.Close()

            'la referencia
            If DC.a08TipoDeReferidor = "Sola" Or DC.a08TipoDeReferidor = "" Then
                'o vino sola o no se ha incluido un referidor lo dice
                strPteReferidaPor = "Referida por: Acudió expontaneamente."
            Else
                'revisa q no sea un (pte de fulanitez)
                If DC.a05ReferidaPor.ToUpper.Contains("PTE") Or DC.a05ReferidaPor.ToUpper.Contains("PACIENTE") Then
                    'es un pte de otro medico
                    strPteReferidaPor = DC.a05ReferidaPor 'dice "Paciente de zxxzzzz"
                Else
                    'fue referida x alguien mas
                    strPteReferidaPor = "Referida por: " & DC.a05ReferidaPor
                End If
            End If

            'si el celular esta verificado
            If IsDate(DC.a06TelefonoVerificado) Then
                strCelularVefificado = "Celular Verificado el: " & CType(DC.a06TelefonoVerificado, Date).ToShortDateString
            Else
                strCelularVefificado = "Celular Verificado el: (N/A)"
            End If

        Else 'no existe el archivo de datos complementarios
            strPteReferidaPor = "Referida por: (N/A)"
            strCelularVefificado = "Celular Verificado el: (N/A)"
        End If


        '----------saca las referidas de la pte desde el archivo de referidas propio--------------------------------------
        Dim strPtesReferidasPorLaPte As String = ""


        'inicializa la als de otras pacientes referidas
        alsOtrasReferidasPorPte.Clear()

        If File.Exists(strArchivoDeReferidasPorLaPte) Then 'comprueba si existe
            'existe lo lee y carga los datos en la alsOtrasReferidasPorPte
            Dim REF As Form1.TablaDeReferidas

            'lee el archivo de referidas propias
            FS = New FileStream(strArchivoDeReferidasPorLaPte, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            ' Read todo
            Dim C = BR.PeekChar
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
                C = BR.PeekChar
            End While

            'cierra la vaina
            BR.Close()
            FS.Close()

            If alsOtrasReferidasPorPte.Count > 0 Then
                'ordena la lista por fecha de referencia
                Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorPte
                                           Order By CType(est.a04FechaDeReferenciaSDS, Date)
                                           Select est

                'las agarra ordenadas 
                strPtesReferidasPorLaPte += "Ha Referido a (" & alsOtrasReferidasPorPte.Count.ToString & ") pacientes." & vbCrLf
                For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                    If est.a02Nombre.Length > 25 Then
                        strPtesReferidasPorLaPte += "El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre.Substring(0, 25) & vbCrLf
                    Else
                        strPtesReferidasPorLaPte += "El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre & vbCrLf
                    End If

                Next
            Else
                'existe el archivo pero esta en blanco dice q no ha referido a mas nadie
                strPtesReferidasPorLaPte += "No a referido a ninguna Paciente."
            End If

        Else
            'no existe pone el letrerito de q no refirio a nadie
            strPtesReferidasPorLaPte += "No a referido a ninguna Paciente."
        End If

        'finalmente los datos personales
        Dim strFechaDeNacimiento As String = ""
        Dim strOcupacion As String = ""
        Dim strCelular As String = ""


        If File.Exists(strArchivoDatosPersonales) Then
            'existe lo carga los datos personales almacenados
            FS = New FileStream(strArchivoDatosPersonales, FileMode.Open, FileAccess.Read)
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


            'ahora muestra si esta.. los datos primero la fecha de nacimiento y edad
            If IsDate(DP.FechaNacimiento) Then
                Dim fdn As Date
                Dim edad As Integer

                fdn = CType(DP.FechaNacimiento, Date)
                edad = (DateDiff(DateInterval.Day, fdn, Today())) + 1
                edad = edad * 100 \ 36525
                strFechaDeNacimiento = "Fecha de Nacimiento: " & fdn.ToShortDateString & " (" & edad.ToString & " años)"
            Else
                strFechaDeNacimiento = "Fecha de Nacimiento: (N/A)"
            End If

            'ahora la profesion
            If DP.Profesion <> "" Then
                If DP.Profesion.Length > 30 Then
                    strOcupacion = "Ocupación: " & DP.Profesion.Substring(0, 30)
                Else
                    strOcupacion = "Ocupación: " & DP.Profesion
                End If

            Else
                strOcupacion = "Ocupación: (N/A)"
            End If

            'el telefono
            If DP.Telefono <> "" Then
                Dim tel As String
                Dim pedazo1, pedazo2, pedazo3, pedazo4 As String
                If DP.Telefono.Length = 10 Then 'si se introdujero todos los numeros
                    pedazo1 = DP.Telefono.Substring(0, 3)
                    pedazo2 = DP.Telefono.Substring(3, 3)
                    pedazo3 = DP.Telefono.Substring(6, 2)
                    pedazo4 = DP.Telefono.Substring(8, 2)
                    tel = "(0" & pedazo1 & ") " & pedazo2 & "." & pedazo3 & "." & pedazo4
                    strCelular = "Celular: " & tel
                ElseIf DP.Telefono.Length = 7 Then 'si solo se metieron los 7 numeros sin codigo
                    pedazo2 = DP.Telefono.Substring(0, 3)
                    pedazo3 = DP.Telefono.Substring(3, 2)
                    pedazo4 = DP.Telefono.Substring(5, 2)
                    tel = pedazo2 & "." & pedazo3 & "." & pedazo4
                    strCelular = "Celular: " & tel
                Else 'si es otro numero de digitos ??? muestralos tal cual
                    strCelular = "Celular: " & DP.Telefono
                End If
            Else 'si no se metio nada entonces
                strCelular = "Celular: (N/A)"
            End If

        Else
            'no exite el archivo pone las casillitas dependientes en blanco
            strFechaDeNacimiento = "Fecha de Nacimiento: (N/A)"
            strOcupacion = "Ocupación: (N/A)"
            strCelular = "Celular: (N/A)"
        End If 'finaliza comprobacion de si existe el archivo de datos personales

        'construye el mensaje
        txtBASEresumenPte.Text = ""
        txtBASEresumenPte.Text += strNombrePte & vbCrLf & vbCrLf
        txtBASEresumenPte.Text += strFechaDeNacimiento & vbCrLf
        txtBASEresumenPte.Text += strCelular & vbCrLf
        txtBASEresumenPte.Text += strCelularVefificado & vbCrLf & vbCrLf
        txtBASEresumenPte.Text += strOcupacion & vbCrLf & vbCrLf
        txtBASEresumenPte.Text += strLocalParidad & vbCrLf & vbCrLf
        txtBASEresumenPte.Text += strPteReferidaPor & vbCrLf & vbCrLf
        txtBASEresumenPte.Text += strPtesReferidasPorLaPte & vbCrLf & vbCrLf
        txtBASEresumenPte.Text += strPacienteDesde & vbCrLf
        txtBASEresumenPte.Text += strUltimaConsultaFue & vbCrLf
        txtBASEresumenPte.Text += strProximaConsultaES & vbCrLf
        txtBASEresumenPte.Text += strNumeroDeConsultas & vbCrLf & vbCrLf
        txtBASEresumenPte.Text += strNotasSubjetivasUltimaConsulta & vbCrLf



    End Sub

    'la crea aca afuera para q pueda ser pasada entre procedimientos no requiere una als porq es una sola
    Dim AO As Form1.TablaDeAntecedentesObstetricos
    'inicializa los valores
    Dim intNumeroGestaciones = 0
    Dim intNumeroAbortos = 0
    Dim intNumeroPartos = 0
    Dim intNumeroCesareas = 0
    Dim intNumeroEctopicos = 0
    Private Sub subBuscaParidadDeLaPacienteSeleccionada()

        'crea el nombre del archivo de antecedentes 
        Dim fileAntObstetricos = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Obstetricos.dat"



        'inicializa la variable de respuesta local
        Form1.PSstrResultadoAntecedentesObstetricos = ""

        If File.Exists(fileAntObstetricos) = True Then 'existe un archivo lo carga

            'Carga el registro previo de antecedentes familiares
            CargaAntecedentesObstetricos()
            'actualiza los datos numericos con la estructura
            ActualizaDatosNumericosConLaEstructura()
            'muestra los paneles adecuados en  pantalla
            ' ActualizaPanelesEnPantalla()
            'rellena los paneles con los datos recuperados
            '  MuestraContenidoDeLosPaneles()

            'inicio igual ahora construye con lo q tiene y cierrra 'traduce el texto en pantalla
            ConstruyeAntecedentesParaConsulta()

        Else
            'no hay datos responde en blanco
            Form1.PSstrResultadoAntecedentesObstetricos = ""
            Form1.PSstrPacienteSeleccionadaParidad = ""
            Form1.PSintPesoMaximo = 0

        End If

    End Sub
    Private Sub CargaAntecedentesObstetricos()
        Dim FS As FileStream
        Dim BR As BinaryReader

        'vuelve a crear el nombre para q sea local 
        Dim fileAntObstetricos = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Obstetricos.dat"
        'ojo ya se verifico q si existia
        FS = New FileStream(fileAntObstetricos, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim C As Integer
        C = BR.PeekChar
        While FS.Position < FS.Length
            AO = Nothing
            ' Read fields and populate structure
            AO.a01Gestas = BR.ReadString : AO.a02Paras = BR.ReadString : AO.a03Cesareas = BR.ReadString
            AO.a04Abortos = BR.ReadString : AO.a05Ectopicos = BR.ReadString : AO.a06strNotas = BR.ReadString
            AO.Dato006 = BR.ReadString : AO.Dato007 = BR.ReadString : AO.Dato008 = BR.ReadString
            AO.Dato009 = BR.ReadString

            AO.Dato010 = BR.ReadString : AO.Dato011 = BR.ReadString : AO.Dato012 = BR.ReadString
            AO.Dato013 = BR.ReadString : AO.Dato014 = BR.ReadString : AO.Dato015 = BR.ReadString
            AO.Dato016 = BR.ReadString : AO.Dato017 = BR.ReadString : AO.Dato018 = BR.ReadString
            AO.Dato019 = BR.ReadString

            AO.Dato020 = BR.ReadString : AO.Dato021 = BR.ReadString : AO.Dato022 = BR.ReadString
            AO.Dato023 = BR.ReadString : AO.Dato024 = BR.ReadString : AO.Dato025 = BR.ReadString
            AO.Dato026 = BR.ReadString : AO.Dato027 = BR.ReadString : AO.Dato028 = BR.ReadString
            AO.Dato029 = BR.ReadString

            AO.Dato030 = BR.ReadString : AO.Dato031 = BR.ReadString : AO.Dato032 = BR.ReadString
            AO.Dato033 = BR.ReadString : AO.Dato034 = BR.ReadString : AO.Dato035 = BR.ReadString
            AO.Dato036 = BR.ReadString : AO.Dato037 = BR.ReadString : AO.Dato038 = BR.ReadString
            AO.Dato039 = BR.ReadString

            AO.Dato040 = BR.ReadString : AO.Dato041 = BR.ReadString : AO.Dato042 = BR.ReadString
            AO.Dato043 = BR.ReadString : AO.Dato044peso01 = BR.ReadString : AO.Dato045 = BR.ReadString
            AO.Dato046 = BR.ReadString : AO.Dato047 = BR.ReadString : AO.Dato048 = BR.ReadString
            AO.Dato049 = BR.ReadString

            AO.Dato050 = BR.ReadString : AO.Dato051 = BR.ReadString : AO.Dato052 = BR.ReadString
            AO.Dato053 = BR.ReadString : AO.Dato054peso02 = BR.ReadString : AO.Dato055 = BR.ReadString
            AO.Dato056 = BR.ReadString : AO.Dato057 = BR.ReadString : AO.Dato058 = BR.ReadString
            AO.Dato059 = BR.ReadString

            AO.Dato060 = BR.ReadString : AO.Dato061 = BR.ReadString : AO.Dato062 = BR.ReadString
            AO.Dato063 = BR.ReadString : AO.Dato064peso03 = BR.ReadString : AO.Dato065 = BR.ReadString
            AO.Dato066 = BR.ReadString : AO.Dato067 = BR.ReadString : AO.Dato068 = BR.ReadString
            AO.Dato069 = BR.ReadString

            AO.Dato070 = BR.ReadString : AO.Dato071 = BR.ReadString : AO.Dato072 = BR.ReadString
            AO.Dato073 = BR.ReadString : AO.Dato074peso04 = BR.ReadString : AO.Dato075 = BR.ReadString
            AO.Dato076 = BR.ReadString : AO.Dato077 = BR.ReadString : AO.Dato078 = BR.ReadString
            AO.Dato079 = BR.ReadString

            AO.Dato080 = BR.ReadString : AO.Dato081 = BR.ReadString : AO.Dato082 = BR.ReadString
            AO.Dato083 = BR.ReadString : AO.Dato084peso05 = BR.ReadString : AO.Dato085 = BR.ReadString
            AO.Dato086 = BR.ReadString : AO.Dato087 = BR.ReadString : AO.Dato088 = BR.ReadString
            AO.Dato089 = BR.ReadString

            AO.Dato090 = BR.ReadString : AO.Dato091 = BR.ReadString : AO.Dato092 = BR.ReadString
            AO.Dato093 = BR.ReadString : AO.Dato094peso06 = BR.ReadString : AO.Dato095 = BR.ReadString
            AO.Dato096 = BR.ReadString : AO.Dato097 = BR.ReadString : AO.Dato098 = BR.ReadString
            AO.Dato099 = BR.ReadString

            AO.Dato100 = BR.ReadString : AO.Dato101 = BR.ReadString : AO.Dato102 = BR.ReadString
            AO.Dato103 = BR.ReadString : AO.Dato104peso07 = BR.ReadString : AO.Dato105 = BR.ReadString
            AO.Dato106 = BR.ReadString : AO.Dato107 = BR.ReadString : AO.Dato108 = BR.ReadString
            AO.Dato109 = BR.ReadString

            AO.Dato110 = BR.ReadString : AO.Dato111 = BR.ReadString : AO.Dato112 = BR.ReadString
            AO.Dato113 = BR.ReadString : AO.Dato114peso08 = BR.ReadString : AO.Dato115 = BR.ReadString
            AO.Dato116 = BR.ReadString : AO.Dato117 = BR.ReadString : AO.Dato118 = BR.ReadString
            AO.Dato119 = BR.ReadString

            AO.Dato120 = BR.ReadString : AO.Dato121 = BR.ReadString : AO.Dato122 = BR.ReadString
            AO.Dato123 = BR.ReadString : AO.Dato124peso09 = BR.ReadString : AO.Dato125 = BR.ReadString
            AO.Dato126 = BR.ReadString : AO.Dato127 = BR.ReadString : AO.Dato128 = BR.ReadString
            AO.Dato129 = BR.ReadString

            AO.Dato130 = BR.ReadString : AO.Dato131 = BR.ReadString : AO.Dato132 = BR.ReadString
            AO.Dato133 = BR.ReadString : AO.Dato134peso10 = BR.ReadString : AO.Dato135 = BR.ReadString
            AO.Dato136 = BR.ReadString : AO.Dato137 = BR.ReadString : AO.Dato138 = BR.ReadString
            AO.Dato139 = BR.ReadString

            AO.Dato140 = BR.ReadString : AO.Dato141 = BR.ReadString : AO.Dato142 = BR.ReadString
            AO.Dato143 = BR.ReadString : AO.Dato144 = BR.ReadString : AO.Dato145 = BR.ReadString
            AO.Dato146 = BR.ReadString : AO.Dato147 = BR.ReadString : AO.Dato148 = BR.ReadString
            AO.Dato149 = BR.ReadString

            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub
    Private Sub ActualizaDatosNumericosConLaEstructura()
        'Panel Superior Izquierdo
        If AO.a01Gestas = "" Then
            intNumeroGestaciones = 0
        Else
            intNumeroGestaciones = CType(AO.a01Gestas, Integer)
        End If

        If AO.a02Paras = "" Then
            intNumeroPartos = 0
        Else
            intNumeroPartos = CType(AO.a02Paras, Integer)
        End If

        If AO.a03Cesareas = "" Then
            intNumeroCesareas = 0
        Else
            intNumeroCesareas = CType(AO.a03Cesareas, Integer)
        End If

        If AO.a04Abortos = "" Then
            intNumeroAbortos = 0
        Else
            intNumeroAbortos = AO.a04Abortos
        End If

        If AO.a05Ectopicos = "" Then
            intNumeroEctopicos = 0
        Else
            intNumeroEctopicos = CType(AO.a05Ectopicos, Integer)
        End If


    End Sub
    Private Sub ConstruyeAntecedentesParaConsulta()
        Dim Ant As String
        Dim Gesta As String
        Dim Para, Cesa, Abo, Ecto As String
        Dim AntecedentesPatologicos As Boolean

        'inicializa variables para evitar peos
        Ant = ""
        Gesta = ""
        Para = ""
        Cesa = ""
        Abo = ""
        Ecto = ""
        AntecedentesPatologicos = False

        If intNumeroGestaciones = 0 Then
            'lo pasa a la variable publica
            Form1.PSstrPacienteSeleccionadaParidad = "Nuligesta."
            Form1.PSintPesoMaximo = 0
            Form1.PSstrResultadoAntecedentesObstetricos = "Nuligesta"

        Else
            If intNumeroGestaciones = 1 Then
                Gesta = "IG"
            ElseIf intNumeroGestaciones = 2 Then
                Gesta = "IIG"
            ElseIf intNumeroGestaciones = 3 Then
                Gesta = "IIIG"
            ElseIf intNumeroGestaciones = 4 Then
                Gesta = "IVG"
            ElseIf intNumeroGestaciones = 5 Then
                Gesta = "VG"
            ElseIf intNumeroGestaciones = 6 Then
                Gesta = "VIG"
            ElseIf intNumeroGestaciones = 7 Then
                Gesta = "VIIG"
            ElseIf intNumeroGestaciones = 8 Then
                Gesta = "VIIIG"
            ElseIf intNumeroGestaciones = 9 Then
                Gesta = "IGX"
            ElseIf intNumeroGestaciones = 10 Then
                Gesta = "XG"
            End If

            Ant += Gesta

            'LOS PARTOS
            If intNumeroPartos > 0 Then
                If intNumeroPartos = 1 Then
                    Para = "IP"
                ElseIf intNumeroPartos = 2 Then
                    Para = "IIP"
                ElseIf intNumeroPartos = 3 Then
                    Para = "IIIP"
                ElseIf intNumeroPartos = 4 Then
                    Para = "IVP"
                ElseIf intNumeroPartos = 5 Then
                    Para = "VP"
                ElseIf intNumeroPartos = 6 Then
                    Para = "VIP"
                ElseIf intNumeroPartos = 7 Then
                    Para = "VIIP"
                ElseIf intNumeroPartos = 8 Then
                    Para = "VIIIP"
                ElseIf intNumeroPartos = 9 Then
                    Para = "IXP"
                ElseIf intNumeroPartos = 10 Then
                    Para = "XP"
                End If

                Ant += " " & Para

            End If

            'LAS CESAREAS
            If intNumeroCesareas > 0 Then
                If intNumeroCesareas = 1 Then
                    Cesa = "IC"
                ElseIf intNumeroCesareas = 2 Then
                    Cesa = "IIC"
                ElseIf intNumeroCesareas = 3 Then
                    Cesa = "IIIC"
                ElseIf intNumeroCesareas = 4 Then
                    Cesa = "IVC"
                ElseIf intNumeroCesareas = 5 Then
                    Cesa = "VC"
                ElseIf intNumeroCesareas = 6 Then
                    Cesa = "VIC"
                ElseIf intNumeroCesareas = 7 Then
                    Cesa = "VIIC"
                ElseIf intNumeroCesareas = 8 Then
                    Cesa = "VIIIC"
                ElseIf intNumeroCesareas = 9 Then
                    Cesa = "IXC"
                ElseIf intNumeroCesareas = 10 Then
                    Cesa = "XC"
                End If

                Ant += " " & Cesa

            End If

            'LOS ABORTOS
            If intNumeroAbortos > 0 Then
                If intNumeroAbortos = 1 Then
                    Abo = "IAb"
                ElseIf intNumeroAbortos = 2 Then
                    Abo = "IIAb"
                ElseIf intNumeroAbortos = 3 Then
                    Abo = "IIIAb"
                ElseIf intNumeroAbortos = 4 Then
                    Abo = "IVAb"
                ElseIf intNumeroAbortos = 5 Then
                    Abo = "VAb"
                ElseIf intNumeroAbortos = 6 Then
                    Abo = "VIAb"
                ElseIf intNumeroAbortos = 7 Then
                    Abo = "VIIAb"
                ElseIf intNumeroAbortos = 8 Then
                    Abo = "VIIIAb"
                ElseIf intNumeroAbortos = 9 Then
                    Abo = "IXAb"
                ElseIf intNumeroAbortos = 10 Then
                    Abo = "XAb"
                End If

                Ant += " " & Abo

            End If

            'ectopicos
            If intNumeroEctopicos > 0 Then
                If intNumeroEctopicos = 1 Then
                    Ecto = "IEc"
                ElseIf intNumeroEctopicos = 2 Then
                    Ecto = "IIEc"
                ElseIf intNumeroEctopicos = 3 Then
                    Ecto = "IIIEc"
                ElseIf intNumeroEctopicos = 4 Then
                    Ecto = "IVEc"
                ElseIf intNumeroEctopicos = 5 Then
                    Ecto = "VEc"
                ElseIf intNumeroEctopicos = 6 Then
                    Ecto = "VIEc"
                ElseIf intNumeroEctopicos = 7 Then
                    Ecto = "VIIEc"
                ElseIf intNumeroEctopicos = 8 Then
                    Ecto = "VIIIEc"
                ElseIf intNumeroEctopicos = 9 Then
                    Ecto = "IXEc"
                ElseIf intNumeroEctopicos = 10 Then
                    Ecto = "XEc"
                End If

                Ant += " " & Ecto

            End If

            Ant += ". "

            'hasta aca ant solo tiene la paridad
            Form1.PSstrPacienteSeleccionadaParidad = Ant


            If AO.a06strNotas <> "" Then
                Ant += vbCrLf & "Nota: " & AO.a06strNotas & "  "
            End If

            'peso maximo si esta
            Dim alsPesos As New ArrayList
            alsPesos.Clear()

            If IsNumeric(AO.Dato044peso01) Then
                alsPesos.Add(CType(AO.Dato044peso01, Decimal))
            End If
            If IsNumeric(AO.Dato054peso02) Then
                alsPesos.Add(CType(AO.Dato054peso02, Decimal))
            End If
            If IsNumeric(AO.Dato064peso03) Then
                alsPesos.Add(CType(AO.Dato064peso03, Decimal))
            End If
            If IsNumeric(AO.Dato074peso04) Then
                alsPesos.Add(CType(AO.Dato074peso04, Decimal))
            End If
            If IsNumeric(AO.Dato084peso05) Then
                alsPesos.Add(CType(AO.Dato084peso05, Decimal))
            End If
            If IsNumeric(AO.Dato094peso06) Then
                alsPesos.Add(CType(AO.Dato094peso06, Decimal))
            End If
            If IsNumeric(AO.Dato104peso07) Then
                alsPesos.Add(CType(AO.Dato104peso07, Decimal))
            End If
            If IsNumeric(AO.Dato114peso08) Then
                alsPesos.Add(CType(AO.Dato114peso08, Decimal))
            End If
            If IsNumeric(AO.Dato124peso09) Then
                alsPesos.Add(CType(AO.Dato124peso09, Decimal))
            End If
            If IsNumeric(AO.Dato124peso09) Then
                alsPesos.Add(CType(AO.Dato124peso09, Decimal))
            End If

            If alsPesos.Count > 0 Then
                Dim alsPesosOrdenados = From est As Decimal In alsPesos
                                        Order By est Descending
                                        Select est

                Ant += "Peso Fetal Máximo: " & alsPesosOrdenados(0).ToString & "gr. "
                'saca para la variable publica
                Form1.PSintPesoMaximo = alsPesosOrdenados(0)
            Else
                'no hay pesos
                Form1.PSintPesoMaximo = 0

            End If

            'patologicos si hay
            If AO.Dato011 = "1" Then
                Ant += "Patológicos: Preeclampsia"
                AntecedentesPatologicos = True
            End If

            If AO.Dato012 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Enfermedad Trofoblastica"
                Else
                    Ant += "Patológicos: Enfermedad Trofoblastica"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato013 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Placenta Previa"
                Else
                    Ant += "Patológicos: Placenta Previa"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato014 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", DPP"
                Else
                    Ant += "Patológicos: DPP"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato015 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Trabajo de Parto Pretérmino"
                Else
                    Ant += "Patológicos: Trabajo de Parto Pretérmino"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato016 = "1" = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Emb. Cronológicamente Prolongado"
                Else
                    Ant += "Patológicos: Emb. Cronológicamente Prolongado"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato017 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Embarazo Múltiple"
                Else
                    Ant += "Patológicos: Embarazo Múltiple"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato018 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Parto Instrumental"
                Else
                    Ant += "Patológicos: Parto Instrumental"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato019 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Polihidramnios"
                Else
                    Ant += "Patológicos: Polihidramnios"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato020 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Cardiopatía y embarazo"
                Else
                    Ant += "Patológicos: Cardiopatía y embarazo"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato021 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Diabetes gestacional"
                Else
                    Ant += "Patológicos: Diabetes gestacional"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato022 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Nefropatía y embarazo"
                Else
                    Ant += "Patológicos: Nefropatía y embarazo"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato023 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Isoinmunización Rh"
                Else
                    Ant += "Patológicos: Isoinmunización Rh"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato024 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Hipotiroidismo y embarazo"
                Else
                    Ant += "Patológicos: Hipotiroidismo y embarazo"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato025 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Hipertiroidismo y embarazo"
                Else
                    Ant += "Patológicos: Hipertiroidismo y embarazo"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato026 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Obito Fetal"
                Else
                    Ant += "Patológicos: Obito Fetal"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato027 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Sufrimiento Fetal"
                Else
                    Ant += "Patológicos: Sufrimiento Fetal"
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato028 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", Oligohidramnios"
                Else
                    Ant += "Patológicos: Oligohidramnios"
                    AntecedentesPatologicos = True
                End If
            End If

            If AntecedentesPatologicos = True Then
                Ant += ". "
            Else
                Ant += "Patológicos: Niega. "
            End If

            'finalmente pasa todo lo recolectado a la varible publica
            Form1.PSstrResultadoAntecedentesObstetricos = Ant

        End If


    End Sub


    Private Sub BuscaDatosParaTooltip()

        'variables del peek a las historias para el tooltip
        Dim txt As String = ""
        Dim SinDatos As String = "Dato no introducido en la base de datos"
        Dim SinDatosCorto As String = "Dato no introducido"

        '---------variables locales de direcciones a los archivos
        Dim indice As Integer

        indice = ListBoxHistorias.SelectedIndex
        OP = arrayPacientesFiltrados(indice)
        Dim NumHistoriaSeleccionada, NomPacienteSeleccionado, CedPacienteSeleccionado, PreHistoriaSeleccionada As String
        Dim Pathlocal As String
        Dim NombreHistorialocal, ArchivoDatosComplementarioslocal As String
        Dim strArchivoDeReferidasPorLaPte As String

        'crea las variables publicas
        NumHistoriaSeleccionada = OP.a01NumeroHistoria
        NomPacienteSeleccionado = OP.a02NombrePaciente
        CedPacienteSeleccionado = OP.a03CedulaPaciente
        PreHistoriaSeleccionada = OP.a01NumeroHistoria.Remove(5, 1)

        'CreaPathEspecificos de prefijos y año
        Pathlocal = PSstrPathHistoriasSinPrefijo & "\" & PreHistoriaSeleccionada
        'crea el nombre His de la historia actual
        NombreHistorialocal = Pathlocal & "\" & NumHistoriaSeleccionada & ".his"
        'crea el nombre del archivo de datos complementarios
        ArchivoDatosComplementarioslocal = Pathlocal & "\" & NumHistoriaSeleccionada & ".dat"
        'crea el nombre de las ptes referidas por la pte
        strArchivoDeReferidasPorLaPte = Pathlocal & "\" & NumHistoriaSeleccionada & "-Referidas.dat"

        'ojo variables locales para hacer un peek en los archivos
        Dim ArchivoDatosPersonalesBuscado As String
        Dim ArchivoAntObstetricosBuscado As String
        Dim ArchivoDatosComplementariosBuscado As String
        Dim ArchivoAgendaBuscado As String
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim H As New DatosPersonales
        Dim R As New Form1.TablaDeAntecedentesObstetricos
        Dim DC As New DatosComplementarios

        Dim C As Integer
        '-------------------------------------------------------------------

        'contruye el nombre del archivo con los datos personales
        ArchivoDatosPersonalesBuscado = Pathlocal & "\" & NumHistoriaSeleccionada & "-Datos Personales.dat"
        'contruye el nombre del archivo con los datos de antecedentes obstetricos
        ArchivoAntObstetricosBuscado = Pathlocal & "\" & NumHistoriaSeleccionada & "-Ant Obstetricos.dat"
        'construye el nombre del archivo de la agenda buscado
        ArchivoAgendaBuscado = Pathlocal & "\" & NumHistoriaSeleccionada & ".agd"
        'contruye el nombre del archivo con los datos complementarios
        ArchivoDatosComplementariosBuscado = Pathlocal & "\" & NumHistoriaSeleccionada & "-Datos Complementarios.dat"

        'Busca en el archivo de datos personales si existe
        If File.Exists(ArchivoDatosPersonalesBuscado) Then
            'existe lo carga los datos personales almacenados
            FS = New FileStream(ArchivoDatosPersonalesBuscado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            H = Nothing
            ' Read fields and populate structure
            H.a01Nombre = BR.ReadString
            H.FechaNacimiento = BR.ReadString
            H.Edad = BR.ReadString
            H.Cedula = BR.ReadString
            H.Profesion = BR.ReadString
            H.Telefono = BR.ReadString
            H.AntecedentesFamiliares = BR.ReadString
            H.AntecedentesPersonales = BR.ReadString
            H.AntecedentesGinecologicos = BR.ReadString
            H.AntecedentesObstetricos = BR.ReadString
            H.AntecedentesQuirurgicos = BR.ReadString
            H.x01DireccionDeHabitacion = BR.ReadString
            H.x02GradoDeInstruccion = BR.ReadString
            H.x03Religion = BR.ReadString
            H.x04CiaDeSeguros = BR.ReadString
            H.x05FamiliarNombre = BR.ReadString
            H.x06FamiliarParentesco = BR.ReadString
            H.x07FamiliarCelular = BR.ReadString
            H.x08FamiliarOcupacion = BR.ReadString
            H.z01 = BR.ReadString
            H.z02 = BR.ReadString
            H.z03 = BR.ReadString
            H.z04 = BR.ReadString
            H.z05 = BR.ReadString
            H.z06 = BR.ReadString
            H.z07 = BR.ReadString
            H.z08 = BR.ReadString
            H.z09 = BR.ReadString
            H.z10 = BR.ReadString

            BR.Close()
            FS.Close()

            'ahora muestra si esta.. los datos primero la fecha de nacimiento y edad
            If IsDate(H.FechaNacimiento) Then
                Dim fdn As Date
                Dim edad As Integer

                fdn = CType(H.FechaNacimiento, Date)
                TooltipFechaNacimiento = "Fecha de nacimiento: " & fdn.ToLongDateString
                edad = (DateDiff(DateInterval.Day, fdn, Today())) + 1
                edad = edad * 100 \ 36525
                TooltipEdad = "Edad: " & edad.ToString
            Else
                TooltipFechaNacimiento = "Fecha de nacimiento: " & SinDatosCorto
                TooltipEdad = "Edad: " & SinDatosCorto
            End If

            'el telefono
            If H.Telefono <> "" Then
                Dim tel As String
                Dim pedazo1, pedazo2, pedazo3, pedazo4 As String
                If H.Telefono.Length = 10 Then 'si se introdujero todos los numeros
                    pedazo1 = H.Telefono.Substring(0, 3)
                    pedazo2 = H.Telefono.Substring(3, 3)
                    pedazo3 = H.Telefono.Substring(6, 2)
                    pedazo4 = H.Telefono.Substring(8, 2)
                    tel = "(0" & pedazo1 & ") " & pedazo2 & "." & pedazo3 & "." & pedazo4
                    TooltipTelefono = "Teléfono: " & tel
                ElseIf H.Telefono.Length = 7 Then 'si solo se metieron los 7 numeros sin codigo
                    pedazo2 = H.Telefono.Substring(0, 3)
                    pedazo3 = H.Telefono.Substring(3, 2)
                    pedazo4 = H.Telefono.Substring(5, 2)
                    tel = pedazo2 & "." & pedazo3 & "." & pedazo4
                    TooltipTelefono = "Teléfono: " & tel
                Else 'si es otro numero de digitos ??? muestralos tal cual
                    TooltipTelefono = "Teléfono: " & H.Telefono
                End If
            Else 'si no se metio nada entonces
                TooltipTelefono = "Teléfono: " & SinDatosCorto
            End If
        Else
            'no exite el archivo pone las casillitas dependientes en blanco
            TooltipFechaNacimiento = "Fecha de nacimiento: " & SinDatosCorto
            TooltipEdad = "Edad: " & SinDatosCorto
            TooltipTelefono = "Teléfono: " & SinDatosCorto
        End If 'finaliza comprobacion de si existe el archivo de datos personales------------------------------------------

        'inicia busqueda de la paridad en ant obstetricos
        If File.Exists(ArchivoAntObstetricosBuscado) Then 'existe archivo de ant obs lo lee
            Dim Gestas As Integer
            Dim Paras As Integer
            Dim Abortos As Integer
            Dim Cesareas As Integer
            Dim Ectopicos As Integer
            Dim Paridad As String = ""

            FS = New FileStream(ArchivoAntObstetricosBuscado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            C = BR.PeekChar
            ' Read (ojo solo los primeros 5 datos que tienen la paridad)
            R = Nothing
            R.a01Gestas = BR.ReadString : R.a02Paras = BR.ReadString : R.a03Cesareas = BR.ReadString
            R.a04Abortos = BR.ReadString : R.a05Ectopicos = BR.ReadString
            'cierra la vaina
            BR.Close()
            FS.Close()
            If R.a01Gestas <> "" Then 'existe algun DE GESTACION
                If IsNumeric(R.a01Gestas) Then
                    Gestas = CType(R.a01Gestas, Integer)
                    Select Case Gestas
                        Case 0
                            Paridad = "Nuligesta"
                        Case 1
                            Paridad = "I G"
                        Case 2
                            Paridad = "II G"
                        Case 3
                            Paridad = "III G"
                        Case 4
                            Paridad = "IV G"
                        Case 5
                            Paridad = "V G"
                        Case 6
                            Paridad = "VI G"
                        Case 7
                            Paridad = "VII G"
                        Case 8
                            Paridad = "VIII G"
                        Case 9
                            Paridad = "IX G"
                        Case 10
                            Paridad = "X G"
                    End Select
                End If
            Else 'no hay ningun dato de gestas no deberia haber nada mas pero sigamos
                Paridad = ""
            End If

            If R.a02Paras <> "" And Paridad <> "" Then 'existe algun dato DE LAS PARAS y hay ya de gestas
                If IsNumeric(R.a02Paras) Then

                    Paras = CType(R.a02Paras, Integer)
                    Select Case Paras
                        Case 0
                            'no ha parido deja todo igual
                            Paridad += ""
                        Case 1
                            Paridad += ", I P"
                        Case 2
                            Paridad += ", II P"
                        Case 3
                            Paridad += ", III P"
                        Case 4
                            Paridad += ", IV P"
                        Case 5
                            Paridad += ", V P"
                        Case 6
                            Paridad += ", VI P"
                        Case 7
                            Paridad += ", VII P"
                        Case 8
                            Paridad += ", VIII P"
                        Case 9
                            Paridad += ", IX P"
                        Case 10
                            Paridad += ", X P"
                    End Select
                End If
            Else 'no hay ningun dato de paras
                'deja todo igual
                Paridad += ""
            End If

            If R.a03Cesareas <> "" And Paridad <> "" Then 'existe algun dato DE CESAREAS y hay ya de gestas
                If IsNumeric(R.a03Cesareas) Then

                    Cesareas = CType(R.a03Cesareas, Integer)
                    Select Case Cesareas
                        Case 0
                            'no ha tenido cesareas deja todo igual
                            Paridad += ""
                        Case 1
                            Paridad += ", I C"
                        Case 2
                            Paridad += ", II C"
                        Case 3
                            Paridad += ", III C"
                        Case 4
                            Paridad += ", IV C"
                        Case 5
                            Paridad += ", V C"
                        Case 6
                            Paridad += ", VI C"
                        Case 7
                            Paridad += ", VII C"
                        Case 8
                            Paridad += ", VIII C"
                        Case 9
                            Paridad += ", IX C"
                        Case 10
                            Paridad += ", X C"
                    End Select
                End If
            Else 'no hay ningun dato de CESAREAS
                'deja todo igual
                Paridad += ""
            End If

            If R.a04Abortos <> "" And Paridad <> "" Then 'existe algun dato DE ABORTOS y hay ya de gestas
                If IsNumeric(R.a04Abortos) Then

                    Abortos = CType(R.a04Abortos, Integer)
                    Select Case Abortos
                        Case 0
                            'no ha tenido ABORTOS deja todo igual
                            Paridad += ""
                        Case 1
                            Paridad += ", I A"
                        Case 2
                            Paridad += ", II A"
                        Case 3
                            Paridad += ", III A"
                        Case 4
                            Paridad += ", IV A"
                        Case 5
                            Paridad += ", V A"
                        Case 6
                            Paridad += ", VI A"
                        Case 7
                            Paridad += ", VII A"
                        Case 8
                            Paridad += ", VIII A"
                        Case 9
                            Paridad += ", IX A"
                        Case 10
                            Paridad += ", X A"
                    End Select
                End If
            Else 'no hay ningun dato de ABORTOS
                'deja todo igual
                Paridad += ""
            End If

            If R.a05Ectopicos <> "" And Paridad <> "" Then 'existe algun dato DE ECTOPICOS y hay ya de gestas
                If IsNumeric(R.a05Ectopicos) Then

                    Ectopicos = CType(R.a05Ectopicos, Integer)
                    Select Case Ectopicos
                        Case 0
                            'no ha tenido ECTOPICOS deja todo igual
                            Paridad += ""
                        Case 1
                            Paridad += ", I Ec"
                        Case 2
                            Paridad += ", II Ec"
                        Case 3
                            Paridad += ", III Ec"
                        Case 4
                            Paridad += ", IV Ec"
                        Case 5
                            Paridad += ", V Ec"
                        Case 6
                            Paridad += ", VI Ec"
                        Case 7
                            Paridad += ", VII Ec"
                        Case 8
                            Paridad += ", VIII Ec"
                        Case 9
                            Paridad += ", IX Ec"
                        Case 10
                            Paridad += ", X Ec"
                    End Select
                End If
            Else 'no hay ningun dato de Ectopicos
                'deja todo igual
                Paridad += ""
            End If

            If Paridad <> "" Then 'SE ESCRIBIO ALGO EN PARIDAD
                TooltipParidad = "Paridad: " & Paridad & "."
            Else 'NO HAY NADA DE DATOS DE PARIDAD
                TooltipParidad = "Paridad: " & SinDatosCorto
            End If
        Else 'no existen ant obstetricos
            TooltipParidad = "Paridad: " & SinDatosCorto
        End If
        '-------------------------------------------------------------------

        'busqueda de datos de la agenda de este paciente
        If File.Exists(ArchivoAgendaBuscado) Then
            Dim T1 As TablaDeArchivosPropiosDeAgenda
            Dim ArraydeFechas As New ArrayList
            Dim FechasDeConsulta As Date = Today
            Dim FechaComparada As Date = Today
            Dim Fecha1raConsulta As Date = Today
            Dim FechaUltimaConsulta As Date = Today
            Dim Honorarios As Integer = 0
            Dim Consulta As Integer = 0
            Dim Promedio As Integer = 0
            Dim HonorariosFormateados As String = ""
            'DATOS PARA EL TOOLTIP DE LA AGENDA
            Dim Clinica As String = ""
            Dim Notas As String = ""
            Dim Tratamiento As String = ""
            Dim Pendiente As String = ""

            'existe archivo de agenda propio de esta historia lo lee
            FS = New FileStream(ArchivoAgendaBuscado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            ArraydeFechas.Clear()

            C = BR.PeekChar
            Dim contador As Integer = 0
            T1.a10FechaConsulta = ""
            T1.a02Clinica = ""
            T1.a03NotaseIDx = ""
            T1.a04Tratamiento = ""
            T1.a05Pendiente = ""

            Dim year2008 As Date
            year2008 = "31-12-2007"


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

                If IsDate(T1.a10FechaConsulta) Then
                    FechasDeConsulta = CType(T1.a10FechaConsulta, Date)
                    ArraydeFechas.Add(FechasDeConsulta)
                End If

                If IsNumeric(T1.a07Honorarios) Then
                    If FechasDeConsulta < year2008 Then
                        'fue antes del 2008
                        Consulta = CType(T1.a07Honorarios, Integer)
                        Consulta = Consulta \ 1000
                    Else
                        Consulta = CType(T1.a07Honorarios, Integer)
                    End If

                Else
                    Consulta = 0
                End If
                Honorarios = Honorarios + Consulta
                C = BR.PeekChar
                contador += 1
            End While
            BR.Close()
            FS.Close()

            'ahora ordena las fechas de consulta y saca la primera consulta
            ArraydeFechas.Sort()
            Fecha1raConsulta = CType(ArraydeFechas(0), Date)
            'muestra el dato en pantalla
            TooltipPteDesde = "Paciente desde: " & Fecha1raConsulta.ToLongDateString
            'ahora voltea para ver la ultima
            ArraydeFechas.Reverse()
            FechaUltimaConsulta = CType(ArraydeFechas(0), Date)

            TooltipUltimaConsulta = "Ultima consulta fue el: " & FechaUltimaConsulta.ToLongDateString
            'el numero de consultas es facil
            TooltipConsultasTotales = "Número de Consultas: " & contador.ToString
            'los honorarios
            HonorariosFormateados = FormatCurrency(Honorarios, , , TriState.True, TriState.True)
            TooltipHonorariosTotales = "Total de Honorarios a la fecha: " & HonorariosFormateados

            'aca se buscan todos los datos de la ultima consulta para el tooltip
            'se debe recorrer todas las consultas para buscar la ultima
            FS = New FileStream(ArchivoAgendaBuscado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin) 'dataset al inicio

            C = BR.PeekChar
            While FS.Position < FS.Length
                'lee el siguiente record de agenda
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

                'revisa que en esta fecha este un dato valido
                If IsDate(T1.a10FechaConsulta) Then
                    'compara la fecha para saber si es la ultima consulta
                    FechaComparada = CType(T1.a10FechaConsulta, Date)
                    If FechaComparada = FechaUltimaConsulta Then
                        'esta es la ultima saca los datos y sale del while
                        Clinica = T1.a02Clinica
                        Notas = T1.a03NotaseIDx
                        Tratamiento = T1.a04Tratamiento
                        Pendiente = T1.a05Pendiente
                        Exit While
                    End If
                End If
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'Construye el mensaje del tooltip de la ultima consulta
            TooltipMensajeCedulaPaciente = "Datos de la última Consulta" & vbCrLf & vbCrLf
            TooltipMensajeCedulaPaciente += "Fecha: " & FechaUltimaConsulta.ToLongDateString
            If Clinica <> "" Then
                TooltipMensajeCedulaPaciente += vbCrLf & "Lugar de la última Consulta: " & Clinica
            Else
                TooltipMensajeCedulaPaciente += vbCrLf & "Lugar de la última Consulta: Dato no disponible."
            End If

            If Notas <> "" Then
                TooltipMensajeCedulaPaciente += vbCrLf & vbCrLf & "Notas y Evolución en la Consulta: " & vbCrLf & Notas
            Else
                TooltipMensajeCedulaPaciente += vbCrLf & vbCrLf & "Notas y Evolución en la Consulta: " & vbCrLf & "Dato no disponible."
            End If

            If Tratamiento <> "" Then
                TooltipMensajeCedulaPaciente += vbCrLf & vbCrLf & "Tratamiento Indicado en la Consulta: " & vbCrLf & Tratamiento
            Else
                TooltipMensajeCedulaPaciente += vbCrLf & vbCrLf & "Tratamiento Indicado en la Consulta: " & vbCrLf & "Dato no disponible."
            End If

            If Pendiente <> "" Then
                TooltipMensajeCedulaPaciente += vbCrLf & vbCrLf & "Pendiente para la Próxima Consulta: " & vbCrLf & Pendiente
            Else
                TooltipMensajeCedulaPaciente += vbCrLf & vbCrLf & "Pendiente para la Próxima Consulta: " & vbCrLf & "Dato no disponible."
            End If

        Else
            'no hay archivo muestra q faltan datos en la casillas correspondientes
            TooltipPteDesde = "Paciente desde: " & SinDatosCorto
            TooltipUltimaConsulta = "Ultima consulta fue el: " & SinDatosCorto
            TooltipConsultasTotales = "Número de Consultas: " & SinDatosCorto
            TooltipHonorariosTotales = "Total de Honorarios a la fecha: " & SinDatosCorto
            'no hay datos de las consultas en la agenda
            TooltipMensajeCedulaPaciente = "Datos de la última Consulta" & vbCrLf & vbCrLf
            TooltipMensajeCedulaPaciente = "Datos no disponibles."
        End If
        '----------------------------------------------------------------------------------------------------------

        If File.Exists(ArchivoDatosComplementariosBuscado) Then 'existe archivo lo lee
            'inicializa las variables del tooltip
            TooltipReferidaPor = ""
            TooltipVinculos = ""



            FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            ' Read solo el primer dato q tiene las notas
            DC = Nothing
            DC.a01Notas = BR.ReadString
            DC.a02Resumen = BR.ReadString
            DC.a03NumeroDelReferidor = BR.ReadString
            DC.a04Vinculos = BR.ReadString
            DC.a05ReferidaPor = BR.ReadString
            DC.a06TelefonoVerificado = BR.ReadString
            DC.a07UltimoSMS = BR.ReadString
            DC.a08TipoDeReferidor = BR.ReadString
            DC.a09VinculoConReferidor = BR.ReadString
            DC.a10 = BR.ReadString
            'cierra la vaina
            BR.Close()
            FS.Close()
            If DC.a05ReferidaPor.Length > 400 Then
                TooltipReferidaPor = DC.a05ReferidaPor.Substring(0, 399)
            Else
                TooltipReferidaPor = DC.a05ReferidaPor
            End If


            If DC.a04Vinculos.Length > 400 Then
                TooltipVinculos = DC.a04Vinculos.Substring(0, 399)
            Else
                TooltipVinculos = DC.a04Vinculos
            End If

        Else 'no existe el archivo de datos complementarios
            'inicializa las variables del tooltip
            TooltipReferidaPor = ""
            TooltipVinculos = ""
        End If

        '----------saca las referidas desde el archivo de referidas propio--------------------------------------
        Dim alsOtrasReferidasPorPte As New ArrayList
        TooltipReferencias = "" 'inicializa tooltip referencias

        If File.Exists(strArchivoDeReferidasPorLaPte) Then 'comprueba si existe
            'existe lo lee y carga los datos en la alsOtrasReferidasPorPte
            'Dim BR As BinaryReader
            'Dim FS As FileStream
            Dim REF As Form1.TablaDeReferidas
            'Dim C As Integer

            'inicializa la als de otras pacientes referidas
            alsOtrasReferidasPorPte.Clear()

            'lee el archivo de referidas propias
            FS = New FileStream(strArchivoDeReferidasPorLaPte, FileMode.Open, FileAccess.Read)
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

            If alsOtrasReferidasPorPte.Count > 0 Then
                'ordena la lista por fecha de referencia
                Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorPte
                                           Order By CType(est.a04FechaDeReferenciaSDS, Date)
                                           Select est
                'las muestra ordenadas en el tooltip
                TooltipReferencias = "" 'inicializa en blanco
                For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                    TooltipReferencias += "El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre & vbCrLf
                Next
            Else
                'existe pero ta vacio
                TooltipReferencias = "No a referido a ninguna Paciente."
            End If

        Else
            'no existe 'pone el letrerito de q no refirio a nadie
            TooltipReferencias = "No a referido a ninguna Paciente."
        End If

        'construye el mensaje
        'Dim MensajeNOMBREPACIENTE As String = ""
        TooltipMensajeNombrePaciente = "Datos Personales" & vbCrLf & vbCrLf
        TooltipMensajeNombrePaciente += TooltipFechaNacimiento & vbCrLf
        TooltipMensajeNombrePaciente += TooltipEdad & vbCrLf
        TooltipMensajeNombrePaciente += TooltipParidad & vbCrLf
        TooltipMensajeNombrePaciente += TooltipTelefono
        If TooltipReferidaPor <> "" Then
            TooltipMensajeNombrePaciente += vbCrLf & vbCrLf & "Esta Paciente fue Referida por:" & vbCrLf & TooltipReferidaPor
        End If
        If TooltipReferencias <> "" Then
            TooltipMensajeNombrePaciente += vbCrLf & vbCrLf & "Esta Paciente Refirió a:" & vbCrLf & TooltipReferencias
        End If
        If TooltipVinculos <> "" Then
            TooltipMensajeNombrePaciente += vbCrLf & vbCrLf & "Vínculos Familiares y de Trabajo:" & vbCrLf & TooltipVinculos
        End If

        'construye el mensaje del tooltip de los datos de las consultas (se ve en el numero de historia
        TooltipMensajeNumeroHistoria = "Estadísticas de las Consultas de la Paciente" & vbCrLf & vbCrLf
        TooltipMensajeNumeroHistoria += TooltipPteDesde & vbCrLf
        TooltipMensajeNumeroHistoria += TooltipConsultasTotales & vbCrLf
        TooltipMensajeNumeroHistoria += TooltipUltimaConsulta & vbCrLf
        TooltipMensajeNumeroHistoria += TooltipHonorariosTotales

        'asocia los mensajes a sus respectivos tooltips
        ToolTipNombrePaciente.SetToolTip(Me.LabNombreSeleccionado, TooltipMensajeNombrePaciente)
        TooltipNumeroHistoria.SetToolTip(Me.LabNumeroSeleccionado, TooltipMensajeNumeroHistoria)
        TooltipCedulaPaciente.SetToolTip(Me.LabCedulaSeleccionada, TooltipMensajeCedulaPaciente)


    End Sub

    Private Sub radEdadSeleccionada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radEdadChamas.CheckedChanged, radEdadMujeres.CheckedChanged, radEdadMILF.CheckedChanged, radEdadViejas.CheckedChanged, radEdadSinDatos.CheckedChanged

        Dim NoChamas, NoMujeres, NoMILF, NoViejas, NoSinDatos As Integer
        Dim Indice As Integer
        Dim Pedazo1, Pedazo2, Pedazo3, Pedazo4 As String
        Dim Ed As New structureDatosDeAniversario 'estructuras por edad (es la misma vains de todas formas)
        Dim SD As New structureHistoriasSinDatosPersonales
        Dim Tel, Linea As String



        ListBoxEdades.Items.Clear()

        If radEdadChamas.Checked = True Then
            'se seleccionaron las chamas
            NoChamas = arrayEdad0a19.Count
            If NoChamas = 0 Then
                'No hay menores de 19 años en esta base de datos
                Linea = "No existen pacientes de menos de 20 años de edad en esta Base de Datos."
                ListBoxEdades.Items.Add(Linea)
            Else
                'ordena el array
                Dim alsOrdenado = From est As Form1.structureDatosDeAniversario In arrayEdad0a19
                                  Order By est.FechaNacimiento Descending
                                  Select est

                For Indice = 0 To NoChamas - 1
                    Ed = alsOrdenado(Indice)
                    If Ed.Telefono <> "" Then
                        If Ed.Telefono.Length = 10 Then 'si se introdujero todos los numeros
                            Pedazo1 = Ed.Telefono.Substring(0, 3)
                            Pedazo2 = Ed.Telefono.Substring(3, 3)
                            Pedazo3 = Ed.Telefono.Substring(6, 2)
                            Pedazo4 = Ed.Telefono.Substring(8, 2)
                            Tel = "(0" & Pedazo1 & ") " & Pedazo2 & "." & Pedazo3 & "." & Pedazo4
                        ElseIf Ed.Telefono.Length = 7 Then 'si solo se metieron los 7 numeros sin codigo
                            Pedazo2 = Ed.Telefono.Substring(0, 3)
                            Pedazo3 = Ed.Telefono.Substring(3, 2)
                            Pedazo4 = Ed.Telefono.Substring(5, 2)
                            Tel = Pedazo2 & "." & Pedazo3 & "." & Pedazo4
                        Else 'si es otro numero de digitos ??? muestralos tal cual
                            Tel = Ed.Telefono
                        End If
                    Else 'si no se metio nada entonces
                        Tel = "n/a"
                    End If

                    Linea = (CType(Ed.FechaNacimiento, Date)).ToShortDateString & "-" & Ed.Nombre & " " & Ed.Edad & " años" & "-Teléfono: " & Tel
                    ListBoxEdades.Items.Add(Linea)
                Next
            End If
            labPacientesGrupoEtario.Text = NoChamas.ToString
        End If

        If radEdadMujeres.Checked = True Then
            'se seleccionaron las de 20 a 29
            NoMujeres = arrayEdad20a29.Count
            If NoMujeres = 0 Then
                'No hay entre 20 y 29 en esta base de datos
                Linea = "No existen pacientes de entre 20 y 29 años de edad en esta Base de Datos."
                ListBoxEdades.Items.Add(Linea)
            Else
                'ordena el array
                Dim alsOrdenado = From est As Form1.structureDatosDeAniversario In arrayEdad20a29
                                  Order By est.FechaNacimiento Descending
                                  Select est

                For Indice = 0 To NoMujeres - 1
                    Ed = alsOrdenado(Indice)
                    If Ed.Telefono <> "" Then
                        If Ed.Telefono.Length = 10 Then 'si se introdujero todos los numeros
                            Pedazo1 = Ed.Telefono.Substring(0, 3)
                            Pedazo2 = Ed.Telefono.Substring(3, 3)
                            Pedazo3 = Ed.Telefono.Substring(6, 2)
                            Pedazo4 = Ed.Telefono.Substring(8, 2)
                            Tel = "(0" & Pedazo1 & ") " & Pedazo2 & "." & Pedazo3 & "." & Pedazo4
                        ElseIf Ed.Telefono.Length = 7 Then 'si solo se metieron los 7 numeros sin codigo
                            Pedazo2 = Ed.Telefono.Substring(0, 3)
                            Pedazo3 = Ed.Telefono.Substring(3, 2)
                            Pedazo4 = Ed.Telefono.Substring(5, 2)
                            Tel = Pedazo2 & "." & Pedazo3 & "." & Pedazo4
                        Else 'si es otro numero de digitos ??? muestralos tal cual
                            Tel = Ed.Telefono
                        End If
                    Else 'si no se metio nada entonces
                        Tel = "n/a"
                    End If

                    Linea = (CType(Ed.FechaNacimiento, Date)).ToShortDateString & "-" & Ed.Nombre & " " & Ed.Edad & " años" & "-Teléfono: " & Tel
                    ListBoxEdades.Items.Add(Linea)
                Next
            End If
            labPacientesGrupoEtario.Text = NoMujeres.ToString
        End If

        If radEdadMILF.Checked = True Then
            'se seleccionaron las de 30 a 39
            NoMILF = arrayEdad30a39.Count
            If NoMILF = 0 Then
                'No hay entre 30 y 39 en esta base de datos
                Linea = "No existen pacientes de entre 30 y 39 años de edad en esta Base de Datos."
                ListBoxEdades.Items.Add(Linea)
            Else
                'ordena el array
                Dim alsOrdenado = From est As Form1.structureDatosDeAniversario In arrayEdad30a39
                                  Order By est.FechaNacimiento Descending
                                  Select est
                For Indice = 0 To NoMILF - 1
                    Ed = alsOrdenado(Indice)
                    If Ed.Telefono <> "" Then
                        If Ed.Telefono.Length = 10 Then 'si se introdujero todos los numeros
                            Pedazo1 = Ed.Telefono.Substring(0, 3)
                            Pedazo2 = Ed.Telefono.Substring(3, 3)
                            Pedazo3 = Ed.Telefono.Substring(6, 2)
                            Pedazo4 = Ed.Telefono.Substring(8, 2)
                            Tel = "(0" & Pedazo1 & ") " & Pedazo2 & "." & Pedazo3 & "." & Pedazo4
                        ElseIf Ed.Telefono.Length = 7 Then 'si solo se metieron los 7 numeros sin codigo
                            Pedazo2 = Ed.Telefono.Substring(0, 3)
                            Pedazo3 = Ed.Telefono.Substring(3, 2)
                            Pedazo4 = Ed.Telefono.Substring(5, 2)
                            Tel = Pedazo2 & "." & Pedazo3 & "." & Pedazo4
                        Else 'si es otro numero de digitos ??? muestralos tal cual
                            Tel = Ed.Telefono
                        End If
                    Else 'si no se metio nada entonces
                        Tel = "n/a"
                    End If

                    Linea = (CType(Ed.FechaNacimiento, Date)).ToShortDateString & "-" & Ed.Nombre & " " & Ed.Edad & " años" & "-Teléfono: " & Tel
                    ListBoxEdades.Items.Add(Linea)
                Next
            End If
            labPacientesGrupoEtario.Text = NoMILF.ToString
        End If

        If radEdadViejas.Checked = True Then
            'se seleccionaron las de 40 y mas
            NoViejas = arrayEdad40a99.Count
            If NoViejas = 0 Then
                'No hay de 40 o mas en esta base de datos
                Linea = "No existen pacientes de 40 o más años en esta Base de Datos."
                ListBoxEdades.Items.Add(Linea)
            Else
                'ordena el array
                Dim alsOrdenado = From est As Form1.structureDatosDeAniversario In arrayEdad40a99
                                  Order By est.FechaNacimiento Descending
                                  Select est
                For Indice = 0 To NoViejas - 1
                    Ed = alsOrdenado(Indice)
                    If Ed.Telefono <> "" Then
                        If Ed.Telefono.Length = 10 Then 'si se introdujero todos los numeros
                            Pedazo1 = Ed.Telefono.Substring(0, 3)
                            Pedazo2 = Ed.Telefono.Substring(3, 3)
                            Pedazo3 = Ed.Telefono.Substring(6, 2)
                            Pedazo4 = Ed.Telefono.Substring(8, 2)
                            Tel = "(0" & Pedazo1 & ") " & Pedazo2 & "." & Pedazo3 & "." & Pedazo4
                        ElseIf Ed.Telefono.Length = 7 Then 'si solo se metieron los 7 numeros sin codigo
                            Pedazo2 = Ed.Telefono.Substring(0, 3)
                            Pedazo3 = Ed.Telefono.Substring(3, 2)
                            Pedazo4 = Ed.Telefono.Substring(5, 2)
                            Tel = Pedazo2 & "." & Pedazo3 & "." & Pedazo4
                        Else 'si es otro numero de digitos ??? muestralos tal cual
                            Tel = Ed.Telefono
                        End If
                    Else 'si no se metio nada entonces
                        Tel = "n/a"
                    End If

                    Linea = (CType(Ed.FechaNacimiento, Date)).ToShortDateString & "-" & Ed.Nombre & " " & Ed.Edad & " años" & "-Teléfono: " & Tel
                    ListBoxEdades.Items.Add(Linea)
                Next
            End If
            labPacientesGrupoEtario.Text = NoViejas.ToString
        End If

        If radEdadSinDatos.Checked = True Then
            'se seleccionaron las sin datos
            NoSinDatos = arrayHistoriasSinDatos.Count
            If NoSinDatos = 0 Then
                'No hay pacientes sin datos en esta base de datos
                Linea = "Todas las pacientes en esta Base de Datos tienen sus datos personales."
                ListBoxEdades.Items.Add(Linea)
            Else
                'ordena el array
                Dim alsOrdenado = From est As Form1.structureHistoriasSinDatosPersonales In arrayHistoriasSinDatos
                                  Order By est.NumeroHistoria
                                  Select est
                For Indice = 0 To NoSinDatos - 1
                    SD = alsOrdenado(Indice)
                    Linea = "#" & SD.NumeroHistoria & "-" & SD.Nombre & " C.I.:" & SD.Cedula
                    ListBoxEdades.Items.Add(Linea)
                Next
            End If
            labPacientesGrupoEtario.Text = NoSinDatos.ToString
        End If

    End Sub

    Private Sub botRenombraHistoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRenombraHistoria.Click
        Dim DLG As New FormRenombraHistoria()
        Dim NumeroHistoriaParaModificar As String
        Dim CedulaNueva, NombreNuevo As String

        Dim Indice As Integer

        Indice = ListBoxHistorias.SelectedIndex
        OP = arrayPacientesFiltrados(Indice)

        PSstrNumeroHistoriaSeleccionada = OP.a01NumeroHistoria
        PSstrPacienteSeleccionadaNombre = OP.a02NombrePaciente
        PSstrPacienteSeleccionadaCedula = OP.a03CedulaPaciente

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            NumeroHistoriaParaModificar = PSstrNumeroHistoriaSeleccionada
            CedulaNueva = DLG.txtCedulaNueva.Text
            NombreNuevo = DLG.txtNombreNuevo.Text

            Dim BW As BinaryWriter
            Dim BR As BinaryReader
            Dim FS As FileStream
            Dim REnum As IEnumerator

            REnum = Historias.GetEnumerator
            Dim R As New BaseDatosIndiceHistorias()
            FS = New FileStream(PSstrArchivoNombreBaseDeDatos, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            While REnum.MoveNext
                R = CType(REnum.Current, BaseDatosIndiceHistorias)

                If R.NumeroHistoria <> NumeroHistoriaParaModificar Then
                    BW.Write(R.NumeroHistoria)
                    BW.Write(R.CedulaPaciente)
                    BW.Write(R.NombrePaciente)
                Else
                    BW.Write(R.NumeroHistoria)
                    BW.Write(CedulaNueva)
                    BW.Write(NombreNuevo)
                End If
            End While
            FS.Close()
            BW.Close()

            'modificacion para el respaldo de archivos
            SeModificaronDatos = True

            'ahora revisa si existe un archivo de datos personales
            Dim ArchivoDeDatosPersonales As String
            Dim Primeros5Numeros As String

            Primeros5Numeros = PSstrNumeroHistoriaSeleccionada.Substring(0, 5)
            ArchivoDeDatosPersonales = PSstrPathHistoriasSinPrefijo & "\" & Primeros5Numeros & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Personales.dat"

            If File.Exists(ArchivoDeDatosPersonales) = True Then
                'existe hay que actualizar los datos

                'carga los datos personales almacenados
                FS = New FileStream(ArchivoDeDatosPersonales, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)

                Dim Hz As New DatosPersonales()

                Hz = Nothing

                ' Read fields and populate structure
                Hz.a01Nombre = BR.ReadString
                Hz.FechaNacimiento = BR.ReadString
                Hz.Edad = BR.ReadString
                Hz.Cedula = BR.ReadString
                Hz.Profesion = BR.ReadString
                Hz.Telefono = BR.ReadString
                Hz.AntecedentesFamiliares = BR.ReadString
                Hz.AntecedentesPersonales = BR.ReadString
                Hz.AntecedentesGinecologicos = BR.ReadString
                Hz.AntecedentesObstetricos = BR.ReadString
                Hz.AntecedentesQuirurgicos = BR.ReadString
                Hz.x01DireccionDeHabitacion = BR.ReadString
                Hz.x02GradoDeInstruccion = BR.ReadString
                Hz.x03Religion = BR.ReadString
                Hz.x04CiaDeSeguros = BR.ReadString
                Hz.x05FamiliarNombre = BR.ReadString
                Hz.x06FamiliarParentesco = BR.ReadString
                Hz.x07FamiliarCelular = BR.ReadString
                Hz.x08FamiliarOcupacion = BR.ReadString
                Hz.z01 = BR.ReadString
                Hz.z02 = BR.ReadString
                Hz.z03 = BR.ReadString
                Hz.z04 = BR.ReadString
                Hz.z05 = BR.ReadString
                Hz.z06 = BR.ReadString
                Hz.z07 = BR.ReadString
                Hz.z08 = BR.ReadString
                Hz.z09 = BR.ReadString
                Hz.z10 = BR.ReadString

                BR.Close()
                FS.Close()

                'modifica la cedula y el nombre
                Hz.a01Nombre = NombreNuevo
                Hz.Cedula = CedulaNueva

                'ahora los vuelve a escribir los datos
                FS = New FileStream(ArchivoDeDatosPersonales, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)

                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                BW.Write(Hz.a01Nombre)
                BW.Write(Hz.FechaNacimiento)
                BW.Write(Hz.Edad)
                BW.Write(Hz.Cedula)
                BW.Write(Hz.Profesion)
                BW.Write(Hz.Telefono)
                BW.Write(Hz.AntecedentesFamiliares)
                BW.Write(Hz.AntecedentesPersonales)
                BW.Write(Hz.AntecedentesGinecologicos)
                BW.Write(Hz.AntecedentesObstetricos)
                BW.Write(Hz.AntecedentesQuirurgicos)
                BW.Write(Hz.x01DireccionDeHabitacion)
                BW.Write(Hz.x02GradoDeInstruccion)
                BW.Write(Hz.x03Religion)
                BW.Write(Hz.x04CiaDeSeguros)
                BW.Write(Hz.x05FamiliarNombre)
                BW.Write(Hz.x06FamiliarParentesco)
                BW.Write(Hz.x07FamiliarCelular)
                BW.Write(Hz.x08FamiliarOcupacion)
                BW.Write(Hz.z01)
                BW.Write(Hz.z02)
                BW.Write(Hz.z03)
                BW.Write(Hz.z04)
                BW.Write(Hz.z05)
                BW.Write(Hz.z06)
                BW.Write(Hz.z07)
                BW.Write(Hz.z08)
                BW.Write(Hz.z09)
                BW.Write(Hz.z10)

                FS.Close()
                BW.Close()

            Else
                'no existe, aun no ha sido creado deja todo igual
            End If

            'para finalizar lee las historias de la base y las carga en la als Historias (tabla sencilla de nombre cedula numero)
            LeeContenidoBaseDatos()
            MuestraContenidoBaseDatos()

            'selecciona la misma historia si se puede verifica si esta en la lista al actualizar el nombre
            If txtFiltro.Text.ToUpper <> "" Then
                'hay algo en el filtro hay q verificar si esta incluido en la lista
                If NombreNuevo.ToUpper.Contains(txtFiltro.Text.ToUpper) Or CedulaNueva.Contains(txtFiltro.Text) Then
                    'el nombre esta incluido en la lista filtrada no deberia haber problema en seleccionarlo
                    ListBoxHistorias.SelectedIndex = Indice
                Else
                    'el nombre no esta en la lista de mostrados, se debe haber salido al renombrar el nombre.. no se selecciona nada
                    MsgBox("La paciente modificada no fue seleccionada en la lista al ser excluida de las pacientes mostradas segun el filtro.", MsgBoxStyle.Information)
                End If

            Else
                'el filtro esta vacio deben estar todas las historias se podra seleccionar sin problema
                ListBoxHistorias.SelectedIndex = Indice
            End If

        End If
    End Sub

    Function funcionObtieneSufijo(ByVal strNumeroDeLaHistoria As String) As String

        If Form1.NumTieneSufijo = True Then
            If IsNumeric(strNumeroDeLaHistoria) Then
                Dim intNumeroReal = CType(strNumeroDeLaHistoria, Integer) - Form1.NumNumero
                Dim ValorSufijo = (intNumeroReal * Form1.NumIncremento) + 1
                Dim Sufijo = ValorSufijo.ToString

                If Sufijo.Length = 1 Then
                    Sufijo = "-00" & Sufijo
                ElseIf Sufijo.Length = 2 Then
                    Sufijo = "-0" & Sufijo
                ElseIf Sufijo.Length = 3 Then
                    Sufijo = "-" & Sufijo
                ElseIf Sufijo.Length = 4 Then
                    Sufijo = "-" & Sufijo.Substring(1, 3)
                ElseIf Sufijo.Length = 5 Then
                    Sufijo = "-" & Sufijo.Substring(2, 3)
                ElseIf Sufijo.Length = 6 Then
                    Sufijo = "-" & Sufijo.Substring(3, 3)
                ElseIf Sufijo.Length = 7 Then
                    Sufijo = "-" & Sufijo.Substring(4, 3)
                End If

                Return Sufijo

            Else 'no es numerico
                Return ""
            End If
        Else 'no tiene sufijo
            Return ""
        End If
    End Function

    Private Sub BotNuevaHistoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotNuevaHistoria.Click
        'primero que nada apaga el filtro y muestra todas las historias
        txtFiltro.Text = ""
        radBASEtodasLasPacientes.Checked = True
        'lee los datos guardados
        'LeeContenidoBaseDatos()
        'muestra lo anterior en pantalla
        'MuestraContenidoBaseDatos()

        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim REnum As IEnumerator
        'Dim texto As String
        Dim H As New BaseDatosIndiceHistorias()

        Dim DLG As New Nueva_Historia()
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

            'recupera el nombre y la cedula nuevos
            NombreNuevo = DLG.txtNombrePaciente.Text
            CedulaNueva = DLG.txtCedulaPaciente.Text
            'crea el nuevo numero de historia
            Dim intNumeroTemp = NumNumero + Historias.Count
            NumeroHistoriaNuevo = intNumeroTemp.ToString.PadLeft(6, "0"c)

            'crea las variables publicas para acceso en otros modulos
            PSstrNumeroHistoriaSeleccionada = NumeroHistoriaNuevo
            PSstrPacienteSeleccionadaNombre = NombreNuevo
            PSstrPacienteSeleccionadaCedula = CedulaNueva
            PSstrPrefijoHistoriaSeleccionada = NumeroHistoriaNuevo.Remove(5, 1)
            NumeroDeHistoriaCompleto = NumeroHistoriaNuevo

            'Crea los PathEspecificos con prefijos y año respectivamente
            Dim Año As String

            PSstrPathHistoriasConPrefijo = PSstrPathHistoriasSinPrefijo & "\" & PSstrPrefijoHistoriaSeleccionada
            PathImagenes = PathImagenesSinPrefijo & "\" & PSstrPrefijoHistoriaSeleccionada
            Año = PSdateFechaDeArraqueDeAgenda.Year 'es la fecha de hoy ves confdebasedatosnocargada
            PathAgendaControlesActual = PSstrPathAgendaBDH & "\" & Año

            'verifica la existencia del directorio
            If Directory.Exists(PSstrPathHistoriasConPrefijo) Then
                'ya existe el subdirectorio no hace nada
            Else
                'no existe aun el subdirectorio, primero lo crea
                Directory.CreateDirectory(PSstrPathHistoriasConPrefijo)
            End If

            'crea el archivo de la base de datos
            PSstrArchivoHistoriaHIS = PSstrPathHistoriasConPrefijo & "\" & NumeroHistoriaNuevo & ".his"
            FS = New FileStream(PSstrArchivoHistoriaHIS, FileMode.Create)
            FS.Close()
            'modificacion para el respaldo de archivos
            SeModificaronDatos = True

            'prende la bandera para q se actualicen las listas de aniversario si se revisaran
            SeCargaronLosDatosDeAniversario = False

            'ActualizaBaseDatos con los datos nuevos 'Asigna los nuevos datos a la array list de historias de la base de datos
            H.NumeroHistoria = NumeroHistoriaNuevo
            H.CedulaPaciente = CedulaNueva
            H.NombrePaciente = NombreNuevo
            Historias.Add(H)

            'pasa el contenido de la array list a la base de datos para actualizarla con la nueva historia
            REnum = Historias.GetEnumerator
            FS = New FileStream(PSstrArchivoNombreBaseDeDatos, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            While REnum.MoveNext
                H = CType(REnum.Current, BaseDatosIndiceHistorias)
                BW.Write(H.NumeroHistoria)
                BW.Write(H.CedulaPaciente)
                BW.Write(H.NombrePaciente)
            End While
            FS.Close()
            BW.Close()

            'obtiene el numero de historia actuales (no se pa q)
            NumerodeHistoriasActuales = Historias.Count

            'selecciona la linea de la historia nueva para volver en ella al cerrar
            IndiceHistoriaAbierta = NumerodeHistoriasActuales - 1

            'carga los datos nuevos
            LeeContenidoBaseDatos()
            'actualiza el list box con los datos nuevos
            MuestraContenidoBaseDatos()
            'selecciona la pte nueva en el list box
            ListBoxHistorias.SelectedIndex = IndiceHistoriaAbierta
            'abre la historia como de costumbre
            AbreLaHistoriaSeleccionada()
            'pide de forma automatica los datos personales despues de abrir la historia
            MuestraVentanaDatosPersonales()
            LeeContenidoHistoria()
            MuestraContenidoHistoria()
            subVerificaDatosComplementariosMuestraNotificaciones()

        End If
    End Sub



    Private Sub ListBoxHistorias_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxHistorias.DoubleClick
        If ListBoxHistorias.SelectedIndex >= 0 Then
            AbreLaHistoriaSeleccionada()
        End If
    End Sub

    Private Sub botAbrirHistoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAbrirHistoria.Click
        AbreLaHistoriaSeleccionada()
    End Sub

    Private Sub AbreLaHistoriaSeleccionada()
        Dim indice As Integer

        indice = ListBoxHistorias.SelectedIndex
        IndiceHistoriaAbierta = indice
        OP = arrayPacientesFiltrados(indice)

        'crea las variables publicas
        PSstrNumeroHistoriaSeleccionada = OP.a01NumeroHistoria
        PSstrPacienteSeleccionadaNombre = OP.a02NombrePaciente
        PSstrPacienteSeleccionadaCedula = OP.a03CedulaPaciente
        PSstrPrefijoHistoriaSeleccionada = OP.a01NumeroHistoria.Remove(5, 1)
        NumeroDeHistoriaCompleto = OP.a01NumeroHistoria

        'inicializa y actualiza la estructura de paciente abierta (nombre y cedula hasta ahora)
        estPacienteAbierta = Nothing
        estPacienteAbierta.a01strNombre = PSstrPacienteSeleccionadaNombre
        estPacienteAbierta.a02strCedula = PSstrPacienteSeleccionadaCedula

        'actualiza los labels de la pantalla de historia seleccionada
        LabHistoriaAbierta.Text = "Historia #" & OP.a01NumeroHistoria & "   -   "
        LabHistoriaAbierta.Text += "Nombre: " & OP.a02NombrePaciente & "   -   "
        If IsNumeric(OP.a03CedulaPaciente) Then
            'ok es numerica vamos a acomodara para leerla mejor
            LabHistoriaAbierta.Text += "Cédula: " & FormatNumber(CType(OP.a03CedulaPaciente, Integer), 0, TriState.False, TriState.False, TriState.True)
        Else
            'no es numerica??? bueno pone lo q haya asi igualito
            LabHistoriaAbierta.Text += OP.a03CedulaPaciente
        End If


        'agarra solo el nombre
        Dim strNombreCorto As String = ""
        For Each charC As Char In Form1.PSstrPacienteSeleccionadaNombre
            If charC <> " " Then
                strNombreCorto += charC
            Else
                Exit For
            End If
        Next
        LabNombreSeleccionado3.Text = strNombreCorto & " fue referida por"
        LabNombreSeleccionado4.Text = strNombreCorto & " ha referido a"

        'CreaPathEspecificos de prefijos y año
        Dim Año As String
        PSstrPathHistoriasConPrefijo = PSstrPathHistoriasSinPrefijo & "\" & PSstrPrefijoHistoriaSeleccionada
        PathImagenes = PathImagenesSinPrefijo & "\" & PSstrPrefijoHistoriaSeleccionada
        Año = PSdateFechaDeArraqueDeAgenda.Year.ToString 'es la fecha de hoy ves confdebasedatosnocargada
        PathAgendaControlesActual = PSstrPathAgendaBDH & "\" & Año

        'crea el nombre His de la historia actual
        PSstrArchivoHistoriaHIS = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & ".his"

        'crea el nombre del archivo de datos complementarios
        PSstrArchivoDatosComplementarios = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & ".dat"

        'carga en memoria y muestra el contenido del indice de la historia seleccionada
        LeeContenidoHistoria()
        MuestraContenidoHistoria()
        'entra en el modo de historia abierta
        subModoHistoriaAbierta()
        'busca los elementos en la historia y prende los botones adecuados segun el caso
        BuscaElementosEnHistoria()
        'aqui deberia ir la parte de busqueda de la agenda
        subInicializaAgenda()
        'muestra las consultas archivadas si las hay en la pagina de historia seleccionada
        subCargaArchivoPropioAGD()
        subMuestraFechasDeConsultasDelPaciente()
        'muestra las fechas con consultas en el calendario otros dias para añadir consultas
        subMuestraFechasDeConsultasEnElCalendario()
        'busca y muestra los datos complementarios si los hay
        subRecopilaDespuesMuestraDatosComplementarios()
        'vewrifica si hay que añadir o actualizar datos de la pte seleccionada
        subVerificaDatosComplementariosMuestraNotificaciones()

        'termina de acomodar la linea de la historia abierta con los datos q pueda haber recolectado
        If Form1.PSintPacienteSeleccionadaEdad <> -1 Then
            LabHistoriaAbierta.Text += "  -  Edad actual: " & labDCedadActual.Text & " años"
        End If

        If Form1.PSstrPacienteSeleccionadaParidad <> "" Then
            LabHistoriaAbierta.Text += "  -  Paridad: " & Form1.PSstrPacienteSeleccionadaParidad
        End If

        'sigue acomodando la estructura publica con los datos de la historia abierta
        estPacienteAbierta.a03datFechaDeNacimiento = PSdatPacienteSeleccionadaFechaDeNacimiento
        estPacienteAbierta.a04intEdadActual = PSintPacienteSeleccionadaEdad
        estPacienteAbierta.a05strParidad = PSstrPacienteSeleccionadaParidad
        estPacienteAbierta.a06strDireccion = PSstrPacienteSeleccionadaDireccion
        estPacienteAbierta.a07strCelular = PSstrPacienteSeleccionadaCelular

        'muestra la ficha de historia seleccionada
        TabControl1.SelectedTab = TabPage1
        TabControlNotas.SelectedTab = TabPageResumen



    End Sub

    Private Sub LeeContenidoHistoria()
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim LineaDatos As String

        If File.Exists(PSstrArchivoHistoriaHIS) = True Then
            FS = New FileStream(PSstrArchivoHistoriaHIS, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim C As Integer
            ElementosHistoria.Clear()
            C = BR.PeekChar
            Dim contador As Integer = 0
            While FS.Position < FS.Length
                LineaDatos = BR.ReadString
                ElementosHistoria.Add(LineaDatos)
                C = BR.PeekChar
                contador += 1
            End While
            BR.Close()
            FS.Close()
        Else
            MsgBox("La historia de " & PSstrPacienteSeleccionadaNombre & " no se puede ubicar en " & PSstrArchivoHistoriaHIS)
            ElementosHistoria.Clear()
        End If

    End Sub

    Private Sub MuestraContenidoHistoria()

        Dim REnum As IEnumerator
        REnum = ElementosHistoria.GetEnumerator
        Dim LineaDatos As String

        ListBoxContenido.Items.Clear()
        Dim contador As Integer = 0
        While REnum.MoveNext
            LineaDatos = CType(REnum.Current, String)
            ListBoxContenido.Items.Add(LineaDatos)
            contador += 1
        End While
    End Sub

    Private Sub BuscaElementosEnHistoria()
        Dim REnum As IEnumerator
        REnum = ElementosHistoria.GetEnumerator
        Dim LineaDatos As String
        ExisteDatosPersonales = False
        ExisteControlGinecologico2 = False
        ExisteControlEcografico = False
        ExisteControlObstetrico = False
        ExistenImagenesEcograficas = False


        While REnum.MoveNext
            LineaDatos = CType(REnum.Current, String)

            If LineaDatos = PSstrNumeroHistoriaSeleccionada & "-Datos Personales" Then
                ExisteDatosPersonales = True
            End If
            If LineaDatos = PSstrNumeroHistoriaSeleccionada & "-Control Ginecológico" Then
                ExisteControlGinecologico2 = True
            End If
            If LineaDatos = PSstrNumeroHistoriaSeleccionada & "-Control Ecográfico" Then
                ExisteControlEcografico = True
            End If
            If LineaDatos = PSstrNumeroHistoriaSeleccionada & "-Control Obstétrico" Then
                ExisteControlObstetrico = True
            End If
            If LineaDatos = PSstrNumeroHistoriaSeleccionada & "-Imágenes Ecográficas" Then
                ExistenImagenesEcograficas = True
            End If
        End While

        If ExisteDatosPersonales = False Then
            'la historia esta vacia
            botDatosPersonales.Enabled = True
            BotControlGinecologico.Enabled = False
            botNuevaHistoriaObstetrica.Enabled = False
            botNuevoEco.Enabled = False

        Else
            'la historia no esta vacia
            botDatosPersonales.Enabled = True
            BotControlGinecologico.Enabled = True
            botNuevaHistoriaObstetrica.Enabled = True
            botNuevoEco.Enabled = True

        End If
    End Sub

    Private Sub subInicializaAgenda()
        Dim Temporal As String
        Dim Largo As Integer
        Dim FechaDe8, FechaDe6, FechaDe4 As String

        Dim Fechaconsulta As Date
        Dim Nombre, Cedula, NumeroHistoria As String
        Fechaconsulta = PSdateFechaDeArraqueDeAgenda
        Nombre = PSstrPacienteSeleccionadaNombre
        Cedula = PSstrPacienteSeleccionadaCedula
        NumeroHistoria = PSstrNumeroHistoriaSeleccionada

        'crea nombre de archivos relacionados
        ArchivoPropioAGD = Form1.PSstrPathHistoriasConPrefijo & "\" & NumeroHistoria & ".agd"
        ArchivoPropioAgdBAK = Form1.PSstrPathHistoriasConPrefijo & "\" & NumeroHistoria & ".bak"
        ArchivoIndice = Form1.PSstrPathAgendaBDH & "\IndiceControles.agd"
        ArchivoIndiceBAK = Form1.PSstrPathAgendaBDH & "\IndiceControles.bak"
        ArchivoIndiceProximos = Form1.PSstrPathAgendaBDH & "\IndiceProximos.agd"
        ArchivoIndiceProximosBAK = Form1.PSstrPathAgendaBDH & "\IndiceProximos.bak"
        'para los autogenerados
        strArchivoControlEcograficoDelPteSeleccionado = Form1.PSstrPathHistoriasConPrefijo & "\" & NumeroHistoria & "-Control Ecográfico.dat"
        strArchivoControlObstetricoDelPteSeleccionado = Form1.PSstrPathHistoriasConPrefijo & "\" & NumeroHistoria & "-Control Obstétrico.dat"

        Temporal = Fechaconsulta.ToString("s")
        Largo = Temporal.Length
        FechaDe8 = Temporal.Remove(Largo - 9, 9)
        FechaDe8 = FechaDe8.Remove(4, 1)
        FechaDe8 = FechaDe8.Remove(6, 1)
        FechaDe6 = FechaDe8.Remove(6, 2)
        FechaDe4 = FechaDe6.Remove(4, 2)

        'estos van en el directorio de año de la agenda
        ArchivoControlDiario = Form1.PathAgendaControlesActual & "\Control-" & FechaDe8 & ".agd"
        ArchivoControlDiarioBAK = Form1.PathAgendaControlesActual & "\Control-" & FechaDe8 & ".bak"
        ArchivoControlMensual = Form1.PathAgendaControlesActual & "\Control-" & FechaDe6 & ".agd"
        ArchivoControlMensualBAK = Form1.PathAgendaControlesActual & "\Control-" & FechaDe6 & ".bak"
        ArchivoControlAnual = Form1.PathAgendaControlesActual & "\Control-" & FechaDe4 & ".agd"
        ArchivoControlAnualBAK = Form1.PathAgendaControlesActual & "\Control-" & FechaDe4 & ".bak"

        '0000000000000000000000000000000000000000
        'parte de verificacion de proximas citas
        Dim FS As FileStream
        Dim BR As BinaryReader

        Dim FechaBuscada As String
        Dim HistoriaBuscada As String
        Dim HistoriaComparada As String


        Dim NumeroControlesEnIndice As Integer = 0
        Dim NumeroProximosControlesEnIndice As Integer = 0

        'inicializa las variables q se pueden modificar aca
        FechaPendienteProximaConsulta = Nothing
        PendienteConsulta = False

        If File.Exists(ArchivoIndiceProximos) = True Then
            'existe un indice de proximos, lo carga

            'ahora revisa los indices de proximas consultas
            FS = New FileStream(ArchivoIndiceProximos, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim K As New TablaDeArchivosDeIndiceDeProximosControles()
            Dim C As Integer
            Array05.Clear()
            C = BR.PeekChar
            While FS.Position < FS.Length
                K = Nothing
                ' Read fields and populate structure
                K.a01FechaProximocontrol = BR.ReadString
                K.a02NumeroHistoria = BR.ReadString
                K.a03Nombre = BR.ReadString
                Array05.Add(K)
                NumeroProximosControlesEnIndice += 1
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'ahora revisa si la base de datos de proximas consultas esta o no vacia 
            If NumeroProximosControlesEnIndice > 0 Then
                'existe al menos un dato de prox consultas , lee el contenido del array list
                Dim REnum As IEnumerator
                REnum = Array05.GetEnumerator
                'esta es la historia que se esta buscando revisa que exista o no
                HistoriaBuscada = NumeroHistoria
                PendienteConsulta = False
                While REnum.MoveNext
                    K = CType(REnum.Current, TablaDeArchivosDeIndiceDeProximosControles)
                    If Form1.NumPrefijo <> "" Then
                        'si hay num prefijo "STGR-"
                        HistoriaComparada = K.a02NumeroHistoria.Replace(Form1.NumPrefijo, "") 'primero lo elimina sustituyendolo por ""
                        HistoriaComparada = HistoriaComparada.Substring(0, 6) 'luego toma los primeros 6 caracteres q tienen el numero de historia
                    Else
                        'si no tiene num prefijo toma los primero 6 caracteres de una
                        HistoriaComparada = K.a02NumeroHistoria.Substring(0, 6)
                    End If

                    If HistoriaBuscada = HistoriaComparada Then
                        FechaBuscada = K.a01FechaProximocontrol
                        'ojo esta redundancia es porq quiero q las dos variables de abajo tomen su valor, son publicas y
                        'se utilizan en las otras ventanas
                        FechaPendienteProximaConsulta = CType(FechaBuscada, Date)
                        PendienteConsulta = True
                    End If
                End While
            End If

        End If
    End Sub

    Private Sub subCargaArchivoPropioAGD()
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim T1 As TablaDeArchivosPropiosDeAgenda

        Array01.Clear()
        If File.Exists(ArchivoPropioAGD) = True Then
            FS = New FileStream(ArchivoPropioAGD, FileMode.Open, FileAccess.Read)
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
                Array01.Add(T1)
                C = BR.PeekChar
                contador += 1
            End While
            BR.Close()
            FS.Close()
        End If
    End Sub

    Private Sub subMuestraFechasDeConsultasDelPaciente()
        Dim REnum As IEnumerator
        REnum = Array01.GetEnumerator
        Dim T1 As TablaDeArchivosPropiosDeAgenda
        Dim ArrayFechas As New ArrayList()
        Dim Fecha As Date
        'Dim Dia As String
        Dim FechaString As String

        'primero carga las fechas de consulta en un array list de fechas

        Dim contador As Integer = 0
        While REnum.MoveNext
            T1 = CType(REnum.Current, TablaDeArchivosPropiosDeAgenda)
            Fecha = T1.a10FechaConsulta
            FechaString = Fecha.ToString("s")
            ArrayFechas.Add(FechaString)
            contador += 1
        End While

        'ahora ordena las fechas
        ArrayFechas.Sort()
        ArrayFechas.Reverse()

        'ahora pasa las fechas ordenadas al list box
        ListBoxConsultas.Items.Clear()

        REnum = ArrayFechas.GetEnumerator
        While REnum.MoveNext
            Fecha = CType(REnum.Current, Date)
            ListBoxConsultas.Items.Add(Fecha.ToShortDateString)
        End While

        'ahora ve si se anoto alguno o estaba vacio
        If contador = 0 Then
            'esta vacio
            ListBoxConsultas.Items.Add("No existen datos...")
        End If
        'finalmente limpia el cuadro de texto
        subLimpiaCuadrosDeTextoDeAgendaEnForm1()


    End Sub
    Private Sub subLimpiaCuadrosDeTextoDeAgendaEnForm1()
        txtAgendaAuto.Clear()
        txtAgendaBanco.Clear()
        txtAgendaEstatusCancelacion.Clear()
        txtAgendaFactura.Clear()
        txtAgendaFechaDeCancelacion.Clear()
        txtAgendaFormaDePago.Clear()
        txtAgendaHonorarios.Clear()
        txtAgendaLugarConsulta.Clear()
        txtAgendaManual.Clear()
        txtAgendaPagador.Clear()
        txtAgendaPendiente.Clear()
        txtAgendaProximaConsulta.Clear()
        txtAgendaReferencia.Clear()
        txtAgendaTratamiento.Clear()
    End Sub

    Private Sub subMuestraFechasDeConsultasEnElCalendario()

        Dim Fechas() As Date
        Dim U As New ArrayList

        If Array01.Count > 0 Then

            'agarra las fechas en una array lis temporal U
            U.Clear()
            For Each est As Form1.TablaDeArchivosPropiosDeAgenda In Array01
                If IsDate(est.a10FechaConsulta) Then
                    Dim dateFechaAgarrada = CType(est.a10FechaConsulta, Date)
                    U.Add(dateFechaAgarrada)
                Else
                    txtHistoriaNotificaciones.Text = "revisa la Consulta del: " & est.a10FechaConsulta & vbCrLf &
                                                      txtHistoriaNotificaciones.Text
                End If
            Next

            If U.Count > 0 Then 'ok hay al menos un dato q sombrear
                'prepara la array de fechas para recibir los datos segun sean los elementos
                ReDim Fechas(U.Count - 1)

                Dim Contador = -1
                For Each est As Date In U
                    Contador += 1
                    Fechas(Contador) = est
                Next

                Me.CalendarioConsultaOtraDia.BoldedDates = Fechas
                Me.CalendarioConsultaOtraDia.UpdateBoldedDates()
            End If

        End If


    End Sub

    Private Sub subRecopilaDespuesMuestraDatosComplementarios()

        Dim txt As String = ""
        Dim SinDatos As String = "Dato no introducido en la base de datos"
        Dim SinDatosCorto As String = "Dato no introducido"

        'ojo variables locales para hacer un peek en los archivos
        Dim ArchivoDatosPersonalesBuscado As String
        Dim ArchivoAntObstetricosBuscado As String
        Dim ArchivoDatosComplementariosBuscado As String
        Dim strArchivoDeReferidasPorLaPte As String
        Dim ArchivoAgendaBuscado As String
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim DP As New DatosPersonales
        Dim AO As New Form1.TablaDeAntecedentesObstetricos
        Dim DC As New DatosComplementarios

        Dim C As Integer

        'inicializa verificacion 
        booEsNecesarioVerificarCelular = False
        booEsNecesarioVerificarParidad = False

        'contruye el nombre del archivo con los datos personales
        ArchivoDatosPersonalesBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Personales.dat"
        'el archivo con las referidas por esta paciente
        strArchivoDeReferidasPorLaPte = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Referidas.dat"
        'contruye el nombre del archivo con los datos de antecedentes obstetricos
        ArchivoAntObstetricosBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Ant Obstetricos.dat"
        'construye el nombre del archivo de la agenda buscado
        ArchivoAgendaBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & ".agd"
        'contruye el nombre del archivo con los datos complementarios
        ArchivoDatosComplementariosBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Complementarios.dat"

        'Busca la paridad en los antecedentes obstetricos, prende la bandera de q solo va a consultar
        subBuscaParidadDeLaPacienteSeleccionada()
        If Form1.PSstrPacienteSeleccionadaParidad <> "" Then
            'trae algun dato
            labDCparidad.Text = Form1.PSstrPacienteSeleccionadaParidad
        Else
            labDCparidad.Text = ""
        End If

        'busqueda de datos de la agenda de este paciente
        If File.Exists(ArchivoAgendaBuscado) Then
            Dim T1 As TablaDeArchivosPropiosDeAgenda
            '  Dim ArraydeFechas As New ArrayList
            Dim alsConsultasDeLaPte As New ArrayList
            Dim FechasDeConsulta As Date = Today
            'Dim HonorariosTotales As Integer = 0
            'Dim HonorariosDeLaConsulta As Integer = 0
            'Dim HonorariosPromedio As Integer = 0

            'Dim Reconversion2008 As Date = #12/31/2007#
            'Dim reconversion2018 As Date = #01/01/2018#


            'existe archivo de agenda propio de esta historia lo lee
            FS = New FileStream(ArchivoAgendaBuscado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            'ArraydeFechas.Clear()
            alsConsultasDeLaPte.Clear()

            C = BR.PeekChar
            'Dim contador As Integer = 0
            T1 = Nothing

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

                'acomoda la fecha a sorteable y calcula los honorarios de una vez
                If IsDate(T1.a10FechaConsulta) Then
                    'acomoda la fecha
                    Dim dateFechaDeLaConsulta = CType(T1.a10FechaConsulta, Date)
                    T1.a10FechaConsulta = dateFechaDeLaConsulta.ToString("s")
                    ''calcula los honorarios 
                    'If IsNumeric(T1.a07Honorarios) Then
                    '    HonorariosDeLaConsulta = CType(T1.a07Honorarios, Integer)
                    '    If dateFechaDeLaConsulta <= Reconversion2008 Then
                    '        HonorariosDeLaConsulta = HonorariosDeLaConsulta \ 100000000
                    '    Else
                    '        'deja la consulta asi igual a como se guardo
                    '    End If
                    'Else
                    '    HonorariosDeLaConsulta = 0
                    'End If
                    'HonorariosTotales += HonorariosDeLaConsulta

                    'finalmente añade a la als
                    alsConsultasDeLaPte.Add(T1)

                End If



                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'ahora ordena las fechas de consulta y saca la primera consulta
            Dim alsConsultasOrdenadasDeLaPtePorFecha = From est As Form1.TablaDeArchivosPropiosDeAgenda In alsConsultasDeLaPte
                                                       Order By est.a10FechaConsulta
                                                       Select est

            Dim intCuentaDeConsultas = alsConsultasOrdenadasDeLaPtePorFecha.Count

            'primera consulta
            labDCpacienteDesde.Text = (CType(alsConsultasOrdenadasDeLaPtePorFecha(0).a10FechaConsulta, Date)).ToShortDateString
            If alsConsultasOrdenadasDeLaPtePorFecha(0).a02Clinica <> "" Then
                labDCLugar1raConsulta.Text = alsConsultasOrdenadasDeLaPtePorFecha(0).a02Clinica
            Else
                labDCLugar1raConsulta.Text = SinDatos
            End If

            'ultima consulta
            labDCultimaConsulta.Text = (CType(alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a10FechaConsulta, Date)).ToShortDateString
            If alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a02Clinica <> "" Then
                labDCLugarUltimaConsulta.Text = alsConsultasOrdenadasDeLaPtePorFecha(intCuentaDeConsultas - 1).a02Clinica
            Else
                labDCLugarUltimaConsulta.Text = SinDatos
            End If


            'el numero de consultas 
            labDCnumeroConsultas.Text = intCuentaDeConsultas.ToString
            ''los honorarios
            'labDCHonorariosTotales.Text = FormatCurrency(HonorariosTotales, , , TriState.True, TriState.True)
            ''el promedio x consulta
            'If intCuentaDeConsultas <> 0 Then
            '    HonorariosPromedio = HonorariosTotales \ intCuentaDeConsultas
            '    labDCPromedioPorConsulta.Text = FormatCurrency(HonorariosPromedio, , , TriState.True, TriState.True)
            'Else
            '    labDCPromedioPorConsulta.Text = "n/a"
            'End If

            'la proxima consulta ya se calculo antes al abrir la historia... esperemos
            If IsDate(FechaPendienteProximaConsulta) Then
                If FechaPendienteProximaConsulta <> Nothing Then
                    labDCproximaConsulta.Text = FechaPendienteProximaConsulta.ToShortDateString
                Else
                    labDCproximaConsulta.Text = "n/a"
                End If
            Else
                labDCproximaConsulta.Text = "n/a"
            End If




        Else
            'no hay archivo muestra q faltan datos en la casillas correspondientes
            labDCpacienteDesde.Text = SinDatosCorto
            labDCultimaConsulta.Text = SinDatosCorto
            labDCproximaConsulta.Text = "n/a"
            labDCnumeroConsultas.Text = "0"
            labDCLugarUltimaConsulta.Text = SinDatos
            labDCHonorariosTotales.Text = "n/a"
            labDCPromedioPorConsulta.Text = "n/a"
        End If

        'busca los datos complementaRIOS DE LA PTE
        DC = Nothing 'inicializa sea como sea antes de revisar por el archivo
        If File.Exists(ArchivoDatosComplementariosBuscado) Then 'existe archivo lo lee
            FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            'C = BR.PeekChar

            ' Read 
            DC = Nothing 'inicializa cada vez para no retener datos del anterior
            DC.a01Notas = BR.ReadString
            DC.a02Resumen = BR.ReadString
            DC.a03NumeroDelReferidor = BR.ReadString
            DC.a04Vinculos = BR.ReadString
            DC.a05ReferidaPor = BR.ReadString
            DC.a06TelefonoVerificado = BR.ReadString 'esta sera si el telefono esta verificado una fecha en string
            DC.a07UltimoSMS = BR.ReadString 'este sera el ultimo sms enviado a la pte
            DC.a08TipoDeReferidor = BR.ReadString
            DC.a09VinculoConReferidor = BR.ReadString
            DC.a10 = BR.ReadString
            'cierra la vaina
            BR.Close()
            FS.Close()
            txtDCnotas.Text = DC.a01Notas
            txtDCFamiliatrabajo.Text = DC.a04Vinculos
            labDCReferidaPor.Text = DC.a05ReferidaPor

            'acomoda label de las referidas por este referidor
            Dim strNombreCorto As String = ""
            If DC.a08TipoDeReferidor = "Sola" Or DC.a08TipoDeReferidor = "" Then
                'o vino sola o no se ha incluido un referidor lo dice
                labDCpacientesReferidasPorReferidor.Visible = False
                labDCVinculoDeLaPteConElReferidor.Visible = False
                txtDCpacientesReferidasPorReferidor.Visible = False

                labDCVinculoDeLaPteConElReferidor.Text = ""
                labDCVinculoDeLaPteConElReferidor.Visible = False
                labDCVinculoDeLaPteConElReferidorTitulo.Visible = False
            Else
                labDCpacientesReferidasPorReferidor.Visible = True
                labDCVinculoDeLaPteConElReferidor.Visible = True
                txtDCpacientesReferidasPorReferidor.Visible = True

                labDCVinculoDeLaPteConElReferidor.Visible = True
                labDCVinculoDeLaPteConElReferidorTitulo.Visible = True

                'coloca lo que este en vinculo con el referidor
                labDCVinculoDeLaPteConElReferidor.Text = DC.a09VinculoConReferidor

                'agarra solo el nombre del referidor
                For Each charC As Char In DC.a05ReferidaPor
                    If charC <> " " Then
                        strNombreCorto += charC
                    Else
                        Exit For
                    End If
                Next

                'revisa q no sea un (pte de fulanitez)
                If DC.a05ReferidaPor.ToUpper.Contains("PTE") Or DC.a05ReferidaPor.ToUpper.Contains("PACIENTE") Then
                    'es un pte de otro medico
                    labDCpacientesReferidasPorReferidor.Text = "Pacientes Evaluadas de este Médico..."
                ElseIf DC.a05ReferidaPor.ToUpper.Contains("CAMBIARSE") Then
                    'es una pte q era de otro medico pero decidio cambiarse
                    labDCpacientesReferidasPorReferidor.Text = "Otras Pacientes que se cambiaron..."
                Else
                    'es un referidor habitual usa su nombre
                    labDCpacientesReferidasPorReferidor.Text = strNombreCorto & " ha referido a"
                End If


            End If


            'estos datos son nuevos
            labDCTelefonoVerificado.Text = DC.a06TelefonoVerificado
            txtDCultimoSMS.Text = DC.a07UltimoSMS

        Else 'no existe el archivo de datos complementarios
            txtDCnotas.Text = ""
            txtDCFamiliatrabajo.Text = ""
            labDCReferidaPor.Text = "Dato no Introducido."
            labDCTelefonoVerificado.Text = ""
            txtDCultimoSMS.Text = ""
            labDCVinculoDeLaPteConElReferidor.Visible = False
            labDCVinculoDeLaPteConElReferidor.Text = ""
            labDCpacientesReferidasPorReferidor.Visible = False
            txtDCpacientesReferidasPorReferidor.Visible = False
        End If


        '----------saca las referidas de la pte desde el archivo de referidas propio--------------------------------------
        Dim alsOtrasReferidasPorPte As New ArrayList

        If File.Exists(strArchivoDeReferidasPorLaPte) Then 'comprueba si existe
            'existe lo lee y carga los datos en la alsOtrasReferidasPorPte
            'Dim BR As BinaryReader
            'Dim FS As FileStream
            Dim REF As Form1.TablaDeReferidas
            'Dim C As Integer

            'inicializa la als de otras pacientes referidas
            alsOtrasReferidasPorPte.Clear()

            'lee el archivo de referidas propias
            FS = New FileStream(strArchivoDeReferidasPorLaPte, FileMode.Open, FileAccess.Read)
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

            If alsOtrasReferidasPorPte.Count > 0 Then
                'ordena la lista por fecha de referencia
                Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorPte
                                           Order By CType(est.a04FechaDeReferenciaSDS, Date)
                                           Select est

                'las muestra ordenadas en el txtDCreferencias
                txtDCReferencias.Text = "" 'inicializa en blanco
                For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                    txtDCReferencias.Text += "El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre & vbCrLf
                Next
            Else
                'existe el archivo pero esta en blanco dice q no ha referido a mas nadie
                txtDCReferencias.Text = "No a referido a ninguna Paciente."
            End If

        Else
            'no existe pone el letrerito de q no refirio a nadie
            txtDCReferencias.Text = "No a referido a ninguna Paciente."
        End If




        '----------saca las referidas del REFERIDOR desde el archivo de referidas propio SEA PTE O SEA OTROREF--------------------------------------

        'Dim alsOtrasReferidasPorPte As New ArrayList YA FUE DECLARADA ARRIBA SOLO LA INICIALIZO
        Dim alsOtrasReferidasPorOtroRef As New ArrayList

        '1ro ve a donde debe buscar.
        If DC.a08TipoDeReferidor = "Sola" Or DC.a08TipoDeReferidor = Nothing Then
            'no hay datos o vino sola no hace nada ya debe estar apagado el lab y el txtbox

        ElseIf DC.a08TipoDeReferidor = "Pte" Then
            'revisa si tiene archivo de referidas (deberia)
            Dim strArchivoDeReferidasDeLaReferidora As String = ""
            strArchivoDeReferidasDeLaReferidora = Form1.PSstrPathHistoriasSinPrefijo & "\" & DC.a03NumeroDelReferidor.Substring(0, 5) & "\" & DC.a03NumeroDelReferidor & "-Referidas.dat"

            If File.Exists(strArchivoDeReferidasDeLaReferidora) Then 'comprueba si existe
                'existe lo lee y carga los datos en la alsOtrasReferidasPorPte
                'Dim BR As BinaryReader
                'Dim FS As FileStream
                Dim REF As Form1.TablaDeReferidas
                'Dim C As Integer

                'inicializa la als de otras pacientes referidas
                alsOtrasReferidasPorPte.Clear()

                'lee el archivo de referidas propias
                FS = New FileStream(strArchivoDeReferidasDeLaReferidora, FileMode.Open, FileAccess.Read)
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

                If alsOtrasReferidasPorPte.Count > 0 Then
                    'ordena la lista por fecha de referencia
                    Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorPte
                                               Order By CType(est.a04FechaDeReferenciaSDS, Date)
                                               Select est

                    'las muestra ordenadas en el txtDCpacientes referidas por referidor
                    txtDCpacientesReferidasPorReferidor.Text = "" 'inicializa en blanco
                    For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                        txtDCpacientesReferidasPorReferidor.Text += "El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre & vbCrLf
                    Next
                Else
                    'existe el archivo pero esta en blanco dice q no ha referido a mas nadie
                    txtDCpacientesReferidasPorReferidor.Text = "No a referido a ninguna Paciente."
                End If

            Else
                'no existe pone el letrerito de q no refirio a nadie
                txtDCpacientesReferidasPorReferidor.Text = "No a referido a ninguna Paciente."
            End If

        ElseIf DC.a08TipoDeReferidor = "Otro" Then
            'revisa si tiene archivo de referidas (deberia)
            Dim strArchivoDeReferidasDeLaReferidora As String = ""
            strArchivoDeReferidasDeLaReferidora = Form1.PSstrPathHistoriasSinPrefijo & "\OtrosReferidores\" & DC.a03NumeroDelReferidor.PadLeft(4, "0"c) & "-Referidas.dat"

            If File.Exists(strArchivoDeReferidasDeLaReferidora) Then 'comprueba si existe
                'existe lo lee y carga los datos en la alsOtrasReferidasPorPte
                'Dim BR As BinaryReader
                'Dim FS As FileStream
                Dim REF As Form1.TablaDeReferidas
                'Dim C As Integer

                'inicializa la als de otras pacientes referidas
                alsOtrasReferidasPorOtroRef.Clear()

                'lee el archivo de referidas propias
                FS = New FileStream(strArchivoDeReferidasDeLaReferidora, FileMode.Open, FileAccess.Read)
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
                    alsOtrasReferidasPorOtroRef.Add(REF)

                End While

                'cierra la vaina
                BR.Close()
                FS.Close()

                If alsOtrasReferidasPorOtroRef.Count > 0 Then
                    'ordena la lista por fecha de referencia
                    Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorOtroRef
                                               Order By CType(est.a04FechaDeReferenciaSDS, Date)
                                               Select est

                    'las muestra ordenadas en el txtDCpacientes referidas por referidor
                    txtDCpacientesReferidasPorReferidor.Text = "" 'inicializa en blanco
                    For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                        txtDCpacientesReferidasPorReferidor.Text += "El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre & vbCrLf
                    Next
                Else
                    'existe el archivo pero esta en blanco dice q no ha referido a mas nadie
                    txtDCpacientesReferidasPorReferidor.Text = "No a referido a ninguna Paciente."
                End If

            Else
                'no existe pone el letrerito de q no refirio a nadie
                txtDCpacientesReferidasPorReferidor.Text = "No a referido a ninguna Paciente."
            End If

        End If

        'finalmente procesa el archivo de datos personales ya debe estar casi todo escrito
        'si el archivo existe lo carga
        If File.Exists(ArchivoDatosPersonalesBuscado) Then
            'existe lo carga los datos personales almacenados
            FS = New FileStream(ArchivoDatosPersonalesBuscado, FileMode.Open, FileAccess.Read)
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

            'ahora muestra si esta.. los datos primero la fecha de nacimiento y edad
            If IsDate(DP.FechaNacimiento) Then
                Dim fdn As Date
                Dim edad As Integer

                'obtiene la fecha de nacimiento y calcula la edad
                fdn = CType(DP.FechaNacimiento, Date)
                edad = (DateDiff(DateInterval.Day, fdn, Today())) + 1
                edad = edad * 100 \ 36525
                'muestra los resultados en las casillas respectivas de la ficha de datos complementarios
                labDCfechaDeNacimiento.Text = fdn.ToLongDateString
                labDCedadActual.Text = edad.ToString
                'coloca los datos en las variables publicas para todas las ventanas
                PSintPacienteSeleccionadaEdad = edad
                PSdatPacienteSeleccionadaFechaDeNacimiento = fdn

            Else

                labDCfechaDeNacimiento.Text = SinDatos
                labDCedadActual.Text = ""

                'coloca los datos en las variables publicas para todas las ventanas
                PSintPacienteSeleccionadaEdad = -1
                PSdatPacienteSeleccionadaFechaDeNacimiento = Nothing
            End If


            'ahora la profesion
            If DP.Profesion <> "" Then
                labDCprofesion.Text = DP.Profesion
            Else
                labDCprofesion.Text = SinDatos
            End If

            'el telefono
            If DP.Telefono <> "" Then
                Dim tel As String
                Dim pedazo1, pedazo2, pedazo3, pedazo4 As String
                If DP.Telefono.Length = 10 Then 'si se introdujero todos los numeros
                    pedazo1 = DP.Telefono.Substring(0, 3)
                    pedazo2 = DP.Telefono.Substring(3, 3)
                    pedazo3 = DP.Telefono.Substring(6, 2)
                    pedazo4 = DP.Telefono.Substring(8, 2)
                    tel = "(0" & pedazo1 & ") " & pedazo2 & "." & pedazo3 & "." & pedazo4
                    labDCtelefono.Text = tel
                ElseIf DP.Telefono.Length = 7 Then 'si solo se metieron los 7 numeros sin codigo
                    pedazo2 = DP.Telefono.Substring(0, 3)
                    pedazo3 = DP.Telefono.Substring(3, 2)
                    pedazo4 = DP.Telefono.Substring(5, 2)
                    tel = pedazo2 & "." & pedazo3 & "." & pedazo4
                    labDCtelefono.Text = tel
                Else 'si es otro numero de digitos ??? muestralos tal cual
                    labDCtelefono.Text = DP.Telefono
                End If
                'actualiza la variable publica
                PSstrPacienteSeleccionadaCelular = labDCtelefono.Text
            Else 'si no se metio nada entonces
                labDCtelefono.Text = SinDatosCorto
                PSstrPacienteSeleccionadaCelular = ""
            End If

            'la direccion 
            If DP.x01DireccionDeHabitacion <> "" Then
                'ok agarra los datos
                labDCdireccion.Text = DP.x01DireccionDeHabitacion
                PSstrPacienteSeleccionadaDireccion = DP.x01DireccionDeHabitacion
            Else
                'no hay nada
                labDCdireccion.Text = ""
                PSstrPacienteSeleccionadaDireccion = ""
            End If

        Else
            'no exite el archivo pone las casillitas dependientes en blanco
            labDCfechaDeNacimiento.Text = SinDatos
            labDCedadActual.Text = ""
            labDCprofesion.Text = SinDatos
            labDCtelefono.Text = SinDatosCorto

            'y actualiza las variables publicas
            PSintPacienteSeleccionadaEdad = -1
            PSdatPacienteSeleccionadaFechaDeNacimiento = Nothing
            PSstrPacienteSeleccionadaCelular = ""
            PSstrPacienteSeleccionadaDireccion = ""

        End If 'finaliza comprobacion de si existe el archivo de datos personales



    End Sub

    Private Sub subVerificaDatosComplementariosMuestraNotificaciones()
        'avisa si falta el telefono y otras cosas q se me vayan ocurriendo
        Dim booFaltanDatos As Boolean = False
        Dim booSeDebeActualizar As Boolean = False
        Dim strMensajeFalta As String = ""
        Dim strMensajeActualizar As String = ""
        Dim strMensaje As String = ""


        'averigua si el telefono esta viejo
        If labDCTelefonoVerificado.Text <> "" Then
            'verifica si hay alguna fecha aca
            If IsDate(labDCTelefonoVerificado.Text) = True Then
                Dim fechaUltimaActualizacion = CType(labDCTelefonoVerificado.Text, Date)
                Dim fechaHaceUnAño = Today.AddDays(-365)

                If fechaUltimaActualizacion < fechaHaceUnAño Then
                    'tiene mas de un año de actualizado
                    booEsNecesarioVerificarCelular = True
                End If
            Else
                'hay algo pero no es una fecha valida
                booEsNecesarioVerificarCelular = True
                labDCTelefonoVerificado.Text = ""
            End If

        Else
            'no hay ni siquiera fecha pide la verificacion
            booEsNecesarioVerificarCelular = True
        End If

        If labDCtelefono.Text = "Dato no introducido" Then
            'falta el telefono
            strMensajeFalta += " - Celular" & vbCrLf
            booFaltanDatos = True
            'apaga la posibilidad de modificar manualmente la fecha de verificacion
            labDCTelefonoVerificado.Enabled = False

        Else
            'esta el celular pero averigua si tiene tiempo sin actualizarse
            If booEsNecesarioVerificarCelular = True Then
                strMensajeActualizar += " - Celular" & vbCrLf
                booEsNecesarioVerificarCelular = False 'ya se hizo la maldad
                booSeDebeActualizar = True
            End If
            'en todo caso prende la posibilidad de modificar manualmente la fecha de verificacion
            labDCTelefonoVerificado.Enabled = True
        End If

        If labDCedadActual.Text = "" Then
            'falta la fecha de nacimiento
            strMensajeFalta += " - Fecha de Nacimiento" & vbCrLf
            booFaltanDatos = True
        End If

        'averigua si la paridad esta vieja
        Dim fileAntObstetricos As String = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Obstetricos.dat"
        If File.Exists(fileAntObstetricos) = True Then
            'existe lo revisa
            If File.GetLastWriteTime(fileAntObstetricos) < Today.AddDays(-365) Then
                booEsNecesarioVerificarParidad = True
            End If
        End If

        If labDCparidad.Text = "" Then
            'falta la paridad
            strMensajeFalta += " - Paridad" & vbCrLf
            booFaltanDatos = True
        Else
            'esta la paridad pero averigua si tiene tiempo sin actualizarse
            If booEsNecesarioVerificarParidad = True Then
                strMensajeActualizar += " - Paridad" & vbCrLf
                booEsNecesarioVerificarParidad = False 'ya se hizo la maldad
                booSeDebeActualizar = True
            End If
        End If

        If labDCReferidaPor.Text = "Dato no Introducido." Then
            'falta las referencia
            strMensajeFalta += " - Referencia" & vbCrLf
            booFaltanDatos = True
        End If

        If labDCprofesion.Text = "Dato no introducido en la base de datos" Then
            'falta la profesion
            strMensajeFalta += " - Ocupación" & vbCrLf
            booFaltanDatos = True
        End If

        'construye el mensaje
        If booFaltanDatos = True Then
            strMensaje += "DATOS AUSENTES" & vbCrLf
            strMensaje += "--------------" & vbCrLf
            strMensaje += strMensajeFalta & vbCrLf
        End If

        If booSeDebeActualizar = True Then
            strMensaje += "DATOS DESACTUALIZADOS" & vbCrLf
            strMensaje += "---------------------" & vbCrLf
            strMensaje += strMensajeActualizar
        End If

        If strMensaje <> "" Then
            'hay algo que decir lo hace
            'MsgBox(strMensaje, MsgBoxStyle.Information, "Incluir y Actualizar Datos...")
            txtHistoriaNotificaciones.Text = strMensaje
            txtHistoriaNotificaciones.ForeColor = Color.Red
        Else
            txtHistoriaNotificaciones.Text = "DATOS BASICOS COMPLETOS" & vbCrLf & "Y ACTUALIZADOS"
            txtHistoriaNotificaciones.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LimpiaDatosComplementariosDePantalla()
        labDCfechaDeNacimiento.Text = ""
        labDCedadActual.Text = ""
        labDCprofesion.Text = ""
        labDCparidad.Text = ""
        labDCtelefono.Text = ""
        txtDCnotas.Text = ""
        labDCdireccion.Text = ""
        labDCReferidaPor.Text = ""
        txtDCReferencias.Text = ""
        txtDCFamiliatrabajo.Text = ""
        labDCpacienteDesde.Text = ""
        labDCultimaConsulta.Text = ""
        labDCLugar1raConsulta.Text = ""
        txtDCultimoSMS.Clear()
        labDCLugarUltimaConsulta.Text = ""
        labDCnumeroConsultas.Text = ""
        labDCHonorariosTotales.Text = ""
        labDCPromedioPorConsulta.Text = ""
        labDCproximaConsulta.Text = ""
    End Sub

    Private Sub txtDCnotas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDCnotas.DoubleClick

        'ojo variable local para crear o modificar el archivo de datos personales
        Dim ArchivoDatosComplementariosBuscado As String
        Dim BR As BinaryReader
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim DC As New DatosComplementarios

        'Dim C As Integer

        'contruye el nombre del archivo con los datos complementarios
        ArchivoDatosComplementariosBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Complementarios.dat"

        If File.Exists(ArchivoDatosComplementariosBuscado) Then
            'existe archivo lo lee todo
            FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Open, FileAccess.Read)
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
            DC.a06TelefonoVerificado = BR.ReadString 'telefono verificado?
            DC.a07UltimoSMS = BR.ReadString  'ultimo sms
            DC.a08TipoDeReferidor = BR.ReadString
            DC.a09VinculoConReferidor = BR.ReadString
            DC.a10 = BR.ReadString
            'cierra la vaina
            BR.Close()
            FS.Close()

        Else 'no existe el archivo de datos complementarios lo debe inizializar
            'inicializa la estructura
            DC.a01Notas = ""
            DC.a02Resumen = ""
            DC.a03NumeroDelReferidor = ""
            DC.a04Vinculos = ""
            DC.a05ReferidaPor = ""
            DC.a06TelefonoVerificado = ""
            DC.a07UltimoSMS = ""
            DC.a08TipoDeReferidor = ""
            DC.a09VinculoConReferidor = ""
            DC.a10 = ""
        End If

        'ahora q tengo la estructura vacia o llena pongo el texto de intercambio
        TextoEnVentana = DC.a01Notas
        TituloEnVentana = "NOTAS de " & PSstrPacienteSeleccionadaNombre & " - (Historia #" & NumeroDeHistoriaCompleto & ")"
        'procesa texto
        ProcesaTextoIntercambio()
        'muestra el texto de nuevo
        txtDCnotas.Text = TextoEnVentana
        'ACTUALIZA la variable afectada
        DC.a01Notas = TextoEnVentana

        'escribe al disco la estructura con el dato modificado (toda)
        FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(DC.a01Notas)
        BW.Write(DC.a02Resumen)
        BW.Write(DC.a03NumeroDelReferidor)
        BW.Write(DC.a04Vinculos)
        BW.Write(DC.a05ReferidaPor)
        BW.Write(DC.a06TelefonoVerificado)
        BW.Write(DC.a07UltimoSMS)
        BW.Write(DC.a08TipoDeReferidor)
        BW.Write(DC.a09VinculoConReferidor)
        BW.Write(DC.a10)

        'cierra la vaina
        BW.Close()
        FS.Close()

    End Sub

    Private Sub txtDCFamiliatrabajo_DobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDCFamiliatrabajo.DoubleClick

        'ojo variable local para crear o modificar el archivo de datos personales
        Dim ArchivoDatosComplementariosBuscado As String
        Dim BR As BinaryReader
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim DC As New DatosComplementarios

        'Dim C As Integer

        'contruye el nombre del archivo con los datos complementarios
        ArchivoDatosComplementariosBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Complementarios.dat"

        If File.Exists(ArchivoDatosComplementariosBuscado) Then
            'existe archivo lo lee todo
            FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Open, FileAccess.Read)
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
            DC.a07UltimoSMS = BR.ReadString
            DC.a08TipoDeReferidor = BR.ReadString
            DC.a09VinculoConReferidor = BR.ReadString
            DC.a10 = BR.ReadString
            'cierra la vaina
            BR.Close()
            FS.Close()

        Else 'no existe el archivo de datos complementarios lo debe inizializar
            'inicializa la estructura
            DC.a01Notas = ""
            DC.a02Resumen = ""
            DC.a03NumeroDelReferidor = ""
            DC.a04Vinculos = ""
            DC.a05ReferidaPor = ""
            DC.a06TelefonoVerificado = ""
            DC.a07UltimoSMS = ""
            DC.a08TipoDeReferidor = ""
            DC.a09VinculoConReferidor = ""
            DC.a10 = ""
        End If

        'ahora q tengo la estructura vacia o llena pongo el texto de intercambio
        TextoEnVentana = DC.a04Vinculos
        TituloEnVentana = PSstrPacienteSeleccionadaNombre & " - (Historia #" & NumeroDeHistoriaCompleto & ")  VINCULOS FAMILIARES Y DE TRABAJO: "
        'procesa texto
        ProcesaTextoIntercambio()
        'muestra el texto de nuevo
        txtDCFamiliatrabajo.Text = TextoEnVentana
        'ACTUALIZA la variable afectada
        DC.a04Vinculos = TextoEnVentana

        'escribe al disco la estructura con el dato modificado (toda)
        FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(DC.a01Notas)
        BW.Write(DC.a02Resumen)
        BW.Write(DC.a03NumeroDelReferidor)
        BW.Write(DC.a04Vinculos)
        BW.Write(DC.a05ReferidaPor)
        BW.Write(DC.a06TelefonoVerificado)
        BW.Write(DC.a07UltimoSMS)
        BW.Write(DC.a08TipoDeReferidor)
        BW.Write(DC.a09VinculoConReferidor)
        BW.Write(DC.a10)

        'cierra la vaina
        BW.Close()
        FS.Close()

    End Sub

    Private Sub labDCVinculoDeLaPteConElReferidor_DobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labDCVinculoDeLaPteConElReferidor.DoubleClick

        'ojo variable local para crear o modificar el archivo de datos personales
        Dim ArchivoDatosComplementariosBuscado As String
        Dim BR As BinaryReader
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim DC As New DatosComplementarios

        'Dim C As Integer

        'contruye el nombre del archivo con los datos complementarios
        ArchivoDatosComplementariosBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Complementarios.dat"

        If File.Exists(ArchivoDatosComplementariosBuscado) Then
            'existe archivo lo lee todo
            FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Open, FileAccess.Read)
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
            DC.a07UltimoSMS = BR.ReadString
            DC.a08TipoDeReferidor = BR.ReadString
            DC.a09VinculoConReferidor = BR.ReadString
            DC.a10 = BR.ReadString
            'cierra la vaina
            BR.Close()
            FS.Close()

        Else 'no existe el archivo de datos complementarios lo debe inizializar
            'inicializa la estructura
            DC.a01Notas = ""
            DC.a02Resumen = ""
            DC.a03NumeroDelReferidor = ""
            DC.a04Vinculos = ""
            DC.a05ReferidaPor = ""
            DC.a06TelefonoVerificado = ""
            DC.a07UltimoSMS = ""
            DC.a08TipoDeReferidor = ""
            DC.a09VinculoConReferidor = ""
            DC.a10 = ""
        End If

        'ahora q tengo la estructura vacia o llena pongo el texto de intercambio
        TextoEnVentana = DC.a09VinculoConReferidor
        TituloEnVentana = PSstrPacienteSeleccionadaNombre & " - (Historia #" & NumeroDeHistoriaCompleto & ")  VINCULO DE LA PACIENTE CON SU REFERIDOR: "
        'procesa texto
        ProcesaTextoIntercambio()
        'muestra el texto de nuevo
        labDCVinculoDeLaPteConElReferidor.Text = TextoEnVentana
        'ACTUALIZA la variable afectada
        DC.a09VinculoConReferidor = TextoEnVentana

        'escribe al disco la estructura con el dato modificado (toda)
        FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(DC.a01Notas)
        BW.Write(DC.a02Resumen)
        BW.Write(DC.a03NumeroDelReferidor)
        BW.Write(DC.a04Vinculos)
        BW.Write(DC.a05ReferidaPor)
        BW.Write(DC.a06TelefonoVerificado)
        BW.Write(DC.a07UltimoSMS)
        BW.Write(DC.a08TipoDeReferidor)
        BW.Write(DC.a09VinculoConReferidor)
        BW.Write(DC.a10)

        'cierra la vaina
        BW.Close()
        FS.Close()

    End Sub

    Public Shared strTipoDeReferidor As String = ""     'para compartir con la venana de referencias el tipo de referidor
    Public Shared strReferidor As String = ""           'y el referidor en si mismo
    Public Shared strNumeroDelReferidor As String = ""  'y el numero de la historia o de otroreferidor

    Private Sub labDCReferidaPor_DobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labDCReferidaPor.DoubleClick

        'ojo variable local para crear o modificar el archivo de datos personales
        Dim ArchivoDatosComplementariosBuscado As String
        Dim BR As BinaryReader
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim DC As New DatosComplementarios

        'Dim C As Integer

        'contruye el nombre del archivo con los datos complementarios
        ArchivoDatosComplementariosBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Complementarios.dat"

        If File.Exists(ArchivoDatosComplementariosBuscado) Then
            'existe archivo lo lee todo
            FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Open, FileAccess.Read)
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
            DC.a07UltimoSMS = BR.ReadString
            DC.a08TipoDeReferidor = BR.ReadString
            DC.a09VinculoConReferidor = BR.ReadString
            DC.a10 = BR.ReadString
            'cierra la vaina
            BR.Close()
            FS.Close()

        Else 'no existe el archivo de datos complementarios lo debe inizializar
            'inicializa la estructura
            DC.a01Notas = ""
            DC.a02Resumen = ""
            DC.a03NumeroDelReferidor = ""
            DC.a04Vinculos = ""
            DC.a05ReferidaPor = ""
            DC.a06TelefonoVerificado = ""
            DC.a07UltimoSMS = ""
            DC.a08TipoDeReferidor = ""
            DC.a09VinculoConReferidor = ""
            DC.a10 = ""
        End If

        'INICIALIZA VARIABLES DE TRANSFERENCIA
        Form1.TituloVentanaDeTexto = PSstrPacienteSeleccionadaNombre & " - (Historia #" & NumeroDeHistoriaCompleto & ")"
        Form1.strReferidor = DC.a05ReferidaPor
        Form1.strTipoDeReferidor = DC.a08TipoDeReferidor
        'normaliza el numero de referidor de la estructura vieja eran los refidos...
        If IsNumeric(DC.a03NumeroDelReferidor) Then
            'hay un numero debe estar actualizado con datos nuevos lo carga
            Form1.strNumeroDelReferidor = DC.a03NumeroDelReferidor
        Else
            'o esta en blaco(nuevo) o tiene datos de referidos(viejo) en todo caso lo pone en blanco
            Form1.strNumeroDelReferidor = ""
        End If

        'muestra la ventana de referencias
        Dim DLG As New FormReferencias()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

            'se acepto, se cargan los datos nuevos en la estructura
            DC.a05ReferidaPor = Form1.strReferidor
            DC.a08TipoDeReferidor = Form1.strTipoDeReferidor
            DC.a03NumeroDelReferidor = Form1.strNumeroDelReferidor

            'ahora se debe mostrar los cambios en pantalla
            labDCReferidaPor.Text = DC.a05ReferidaPor

            'finalmente grabar los cambios en el archivo escribe al disco la estructura con el dato modificado (toda)
            FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Create, FileAccess.ReadWrite)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            BW.Write(DC.a01Notas)
            BW.Write(DC.a02Resumen)
            BW.Write(DC.a03NumeroDelReferidor)
            BW.Write(DC.a04Vinculos)
            BW.Write(DC.a05ReferidaPor)
            BW.Write(DC.a06TelefonoVerificado)
            BW.Write(DC.a07UltimoSMS)
            BW.Write(DC.a08TipoDeReferidor)
            BW.Write(DC.a09VinculoConReferidor)
            BW.Write(DC.a10)

            'cierra la vaina
            BW.Close()
            FS.Close()

            'carga de nuevo el archivo de otros referidores en memoria por si hubo cambios
            subCargaArchivoDeOtrosRef()
            'actualiza los cambiosen pantalla
            subRecopilaDespuesMuestraDatosComplementarios()
            'revisa a ver si hay notificaciones
            subVerificaDatosComplementariosMuestraNotificaciones()

        Else
            'no se aceptaron los cambio no hace nada
        End If

    End Sub




    Private Sub labDCTelefonoVerificado_DobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labDCTelefonoVerificado.DoubleClick

        subActualizaTelefonoVerificado()
        'actualiza los cambiosen pantalla
        subRecopilaDespuesMuestraDatosComplementarios()
        'revisa a ver si hay notificaciones
        subVerificaDatosComplementariosMuestraNotificaciones()

    End Sub

    'variable para saber si esta actualizando automaticamente al modificar los datos personales o por doble click
    Dim booActualizadoVerificacionDeCelularAutomaticamente As Boolean = False

    Private Sub subActualizaTelefonoVerificado()
        'ojo variable local para crear o modificar el archivo de datos personales
        Dim ArchivoDatosComplementariosBuscado As String
        Dim BR As BinaryReader
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim DC As New DatosComplementarios

        'Dim C As Integer

        'contruye el nombre del archivo con los datos complementarios
        ArchivoDatosComplementariosBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Complementarios.dat"

        If File.Exists(ArchivoDatosComplementariosBuscado) Then
            'existe archivo lo lee todo
            FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Open, FileAccess.Read)
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
            DC.a07UltimoSMS = BR.ReadString
            DC.a08TipoDeReferidor = BR.ReadString
            DC.a09VinculoConReferidor = BR.ReadString
            DC.a10 = BR.ReadString
            'cierra la vaina
            BR.Close()
            FS.Close()

        Else 'no existe el archivo de datos complementarios lo debe inizializar
            'inicializa la estructura
            DC.a01Notas = ""
            DC.a02Resumen = ""
            DC.a03NumeroDelReferidor = ""
            DC.a04Vinculos = ""
            DC.a05ReferidaPor = ""
            DC.a06TelefonoVerificado = ""
            DC.a07UltimoSMS = ""
            DC.a08TipoDeReferidor = ""
            DC.a09VinculoConReferidor = ""
            DC.a10 = ""
        End If

        ''ahora q tengo la estructura vacia o llena verifico desde donde se llamo

        If booActualizadoVerificacionDeCelularAutomaticamente = False Then
            'actualizando por doble clik normal
            Dim strRespuesta = InputBox("Introduce la fecha de verificación o la palabra (Hoy) para usar la fecha actual", "Teléfono Verificado el día:", "Hoy")
            If strRespuesta.ToUpper = "HOY" Then
                DC.a06TelefonoVerificado = Today.ToShortDateString
                labDCTelefonoVerificado.Text = DC.a06TelefonoVerificado
            ElseIf IsDate(strRespuesta) Then
                Dim datfecha = CType(strRespuesta, Date)
                DC.a06TelefonoVerificado = datfecha.ToShortDateString
                labDCTelefonoVerificado.Text = DC.a06TelefonoVerificado
            Else
                'no es hoy ni es una fecha
                MsgBox("No se introdujo una fecha válida...", MsgBoxStyle.Information)
                Exit Sub
            End If

        Else
            'actualizando automaticamente despues de modificar el telefono en datos personales
            If labDCtelefono.Text = "Dato no introducido" Then
                'se borro el telefono al editar los datos personales
                DC.a06TelefonoVerificado = "" 'lo pone como nunca verificado
                labDCTelefonoVerificado.Text = ""

            Else
                'se modifico el telefono se dejo algo se debe actualiza a hoy
                DC.a06TelefonoVerificado = Today
                labDCTelefonoVerificado.Text = Today.ToShortDateString

            End If

            'apaga la bandera
            booActualizadoVerificacionDeCelularAutomaticamente = False
        End If

        'escribe al disco la estructura con el dato modificado (toda)
        FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(DC.a01Notas)
        BW.Write(DC.a02Resumen)
        BW.Write(DC.a03NumeroDelReferidor)
        BW.Write(DC.a04Vinculos)
        BW.Write(DC.a05ReferidaPor)
        BW.Write(DC.a06TelefonoVerificado)
        BW.Write(DC.a07UltimoSMS)
        BW.Write(DC.a08TipoDeReferidor)
        BW.Write(DC.a09VinculoConReferidor)
        BW.Write(DC.a10)

        'cierra la vaina
        BW.Close()
        FS.Close()
    End Sub


    Private Sub labDCultimoSMS_DobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDCultimoSMS.DoubleClick

        'ojo variable local para crear o modificar el archivo de datos personales
        Dim ArchivoDatosComplementariosBuscado As String
        Dim BR As BinaryReader
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim DC As New DatosComplementarios

        'Dim C As Integer

        'contruye el nombre del archivo con los datos complementarios
        ArchivoDatosComplementariosBuscado = PSstrPathHistoriasConPrefijo & "\" & PSstrNumeroHistoriaSeleccionada & "-Datos Complementarios.dat"

        If File.Exists(ArchivoDatosComplementariosBuscado) Then
            'existe archivo lo lee todo
            FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Open, FileAccess.Read)
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

        Else 'no existe el archivo de datos complementarios lo debe inizializar
            'inicializa la estructura
            DC.a01Notas = ""
            DC.a02Resumen = ""
            DC.a03NumeroDelReferidor = ""
            DC.a04Vinculos = ""
            DC.a05ReferidaPor = ""
            DC.a06TelefonoVerificado = ""
            DC.a07UltimoSMS = ""
            DC.a08TipoDeReferidor = ""
            DC.a09VinculoConReferidor = ""
            DC.a10 = ""
        End If

        'ahora q tengo la estructura vacia o llena pongo el texto de intercambio
        TextoEnVentana = DC.a07UltimoSMS 'ultimo sms?
        TituloEnVentana = PSstrPacienteSeleccionadaNombre & " - (Historia #" & NumeroDeHistoriaCompleto & ")  Ultimo SMS enviado: "
        'procesa texto
        ProcesaTextoIntercambio()
        'muestra el texto de nuevo
        txtDCultimoSMS.Text = TextoEnVentana
        'ACTUALIZA la variable afectada
        DC.a07UltimoSMS = TextoEnVentana

        'escribe al disco la estructura con el dato modificado (toda)
        FS = New FileStream(ArchivoDatosComplementariosBuscado, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(DC.a01Notas)
        BW.Write(DC.a02Resumen)
        BW.Write(DC.a03NumeroDelReferidor)
        BW.Write(DC.a04Vinculos)
        BW.Write(DC.a05ReferidaPor)
        BW.Write(DC.a06TelefonoVerificado)
        BW.Write(DC.a07UltimoSMS)
        BW.Write(DC.a08TipoDeReferidor)
        BW.Write(DC.a09VinculoConReferidor)
        BW.Write(DC.a10)

        'cierra la vaina
        BW.Close()
        FS.Close()

    End Sub

    'TEXTO DE INTERCAMBIO 
    Private Sub ProcesaTextoIntercambio()
        Dim DLG As New FormVentanaLectura()
        'inicializa las variables de intercambio publicas
        If TextoEnVentana <> "" Then
            TextoIntercambio = TextoEnVentana
        Else
            TextoIntercambio = ""
        End If
        TituloVentanaDeTexto = TituloEnVentana
        'muestra la ventana de texto
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'si aceptas actualiza variable de texto local
            TextoEnVentana = TextoIntercambio
        End If
    End Sub

    Private Sub botCerrarHistoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botCerrarHistoria.Click, botCerrarHistoria2.Click

        subModoHistoriaNoAbierta()

        If ListBoxHistorias.Items.Count > 0 Then
            'para poner la historia seleccionada a la vista al cerrar
            If IndiceHistoriaAbierta >= ListBoxHistorias.Items.Count Then
                'estoy sobrepasando la capacidad de la listbox selecciona el ultimo elemento
                ListBoxHistorias.SelectedIndex = ListBoxHistorias.Items.Count - 1
            Else
                'ok todo bien puede seleccionar la misma historia q se cerro
                ListBoxHistorias.SelectedIndex = IndiceHistoriaAbierta
            End If
        Else
            'no selecciona nada porq esta vacio
        End If



    End Sub

    Private Sub botConsultaHoy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botConsultaHoy.Click

        'primero pone la fecha a hoy
        PSdateFechaDeArraqueDeAgenda = Today
        Dim año = PSdateFechaDeArraqueDeAgenda.Year
        PathAgendaControlesActual = PSstrPathAgendaBDH & "\" & año.ToString
        subInicializaAgenda()
        'prende la bandera de anotar en la agenda... ojooooo
        AnotaTrueBorraFalseEnLaAgenda = True
        'prende la bandera de la ultima consultaseleccionada ya que si se esta metiendo hoy debe ser la ultima no?
        EsLaUltimaConsultaLaSeleccionada = True
        'ahora anota en la agenda
        AnotaEnLaAgenda()
        'refresca datos nuevos si los hay
        subInicializaAgenda()
        'muestra las consultas archivadas si las hay en la pagina de historia seleccionada
        subCargaArchivoPropioAGD()
        subMuestraFechasDeConsultasDelPaciente()
        'busca y muestra los datos complementarios si los hay para refrescar cualquier cambio
        subRecopilaDespuesMuestraDatosComplementarios()
        'vuelve a poner la fecha de hoy como base para que calcule bien las citas prox y perdidas
        PSdateFechaDeArraqueDeAgenda = Today
        'selecciona el index (0) q se habra acabado de introducir
        ListBoxConsultas.SelectedIndex = 0





    End Sub

    Private Sub botConsultaOtroDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botConsultaOtroDia.Click

        If CalendarioConsultaOtraDia.Visible = False Then
            'prende los referente a consulta otro dia
            CalendarioConsultaOtraDia.Visible = True
            botConsultaOtroDiaAccion.Visible = True
            labCalendarioConsultaOtroDia.Visible = True
            'apaga el list box original
            ListBoxConsultas.Visible = False
            labConsultasArchivadas.Visible = False
            'acomoda los botones
            botConsultaOtroDia.Text = "Cancelar Otro Día"
            botConsultaHoy.Enabled = False
            botEliminarConsulta.Enabled = False
            botEditarConsulta.Enabled = False

            'que voy a mostrar de fecha en el calendario
            If ListBoxConsultas.SelectedIndex > -1 Then
                'hay algo seleccionado inicia en esa fecha
                Dim dateFechaInicial = CType(ListBoxConsultas.SelectedItem, Date)
                CalendarioConsultaOtraDia.SelectionStart = dateFechaInicial
                CalendarioConsultaOtraDia.SelectionEnd = dateFechaInicial
                'deselecciona el list box
                ListBoxConsultas.SelectedIndex = -1
            Else
                'no se ha seleccionado nada empieza hoy
                CalendarioConsultaOtraDia.SelectionStart = Today
            End If

            'como sea lo manda a revisar si la fecha tiene algo y actua en condicion
            subVerificaSiHayConsultaElDiaSeleccionado()


        Else
            'se esta cancelando se muestra normal sin nada seleccionado
            CalendarioConsultaOtraDia.Visible = False
            botConsultaOtroDiaAccion.Visible = False
            labCalendarioConsultaOtroDia.Visible = False
            ListBoxConsultas.Visible = True
            labConsultasArchivadas.Visible = True
            botConsultaOtroDia.Text = "Consulta Otro Día"
            botConsultaHoy.Enabled = True
            botEliminarConsulta.Enabled = False
            botEditarConsulta.Enabled = False
            'borra lo q este en pantalla
            txtAgendaAuto.Clear()
            txtAgendaFactura.Clear()
            txtAgendaHonorarios.Clear()
            txtAgendaLugarConsulta.Clear()
            txtAgendaManual.Clear()
            txtAgendaPendiente.Clear()
            txtAgendaProximaConsulta.Clear()
            txtAgendaTratamiento.Clear()
        End If



    End Sub

    Private Sub CalendarioConsultaOtraDia_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) _
       Handles CalendarioConsultaOtraDia.DateChanged

        If CalendarioConsultaOtraDia.SelectionStart = Nothing Then
            'se deselecciono solo (avecespasa) borra todo
            txtAgendaAuto.Clear()
            txtAgendaFactura.Clear()
            txtAgendaHonorarios.Clear()
            txtAgendaLugarConsulta.Clear()
            txtAgendaManual.Clear()
            txtAgendaPendiente.Clear()
            txtAgendaProximaConsulta.Clear()
            txtAgendaTratamiento.Clear()
            Exit Sub 'sale despues de acomodar la vaina
        End If

        subVerificaSiHayConsultaElDiaSeleccionado()

    End Sub

    Private Sub subVerificaSiHayConsultaElDiaSeleccionado()

        Dim dateDiaBuscado = CalendarioConsultaOtraDia.SelectionStart 'variable con la fecha buscada es seleccionada en el calendario
        Dim booLoEncontro As Boolean = False 'variable para saber si ese dia seleccionado hay una consulta

        'revisa si hay una consulta el dia los datos de la consultas estan en array01
        For Each est As Form1.TablaDeArchivosPropiosDeAgenda In Array01
            Dim dateDiaRevisado = CType(est.a10FechaConsulta, Date)
            If dateDiaBuscado = dateDiaRevisado Then
                booLoEncontro = True
                Exit For
            End If
        Next


        If booLoEncontro = True Then
            'si la hay la muestra en los labs de abajo y prende el boton como edicion de consulta
            subMuestraConsultaSeleccionada(CType(CalendarioConsultaOtraDia.SelectionStart, Date))
            botConsultaOtroDiaAccion.Text = "Edita la Consulta"
        Else
            'si no hay consulta limpia los labs y prende el boton como crear nueva
            txtAgendaAuto.Clear()
            txtAgendaFactura.Clear()
            txtAgendaHonorarios.Clear()
            txtAgendaLugarConsulta.Clear()
            txtAgendaManual.Clear()
            txtAgendaPendiente.Clear()
            txtAgendaProximaConsulta.Clear()
            txtAgendaTratamiento.Clear()
            botConsultaOtroDiaAccion.Text = "Nueva Consulta"
        End If



    End Sub

    Private Sub botConsultaOtroDiaAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botConsultaOtroDiaAccion.Click

        'guarda en memoria la fecha seleccionada en el listbox para volver a mostrarla al final
        Dim dateFechaSeleccionadaOriginalmente = CalendarioConsultaOtraDia.SelectionStart

        'prende la bandera de anotar en la agenda... ojooooo
        AnotaTrueBorraFalseEnLaAgenda = True
        'arraca con la fecha seleccionada
        PSdateFechaDeArraqueDeAgenda = dateFechaSeleccionadaOriginalmente
        Dim año = PSdateFechaDeArraqueDeAgenda.Year
        PathAgendaControlesActual = PSstrPathAgendaBDH & "\" & año.ToString
        'crea la ruta a los archivos de agenda de año mes y dia y verifica si esa fecha tiene consulta pendiente y q dia
        subInicializaAgenda()

        'verifica si la historia es la mas reciente
        Dim alsFechaOrdenadasDeConsultas = From est As Form1.TablaDeArchivosPropiosDeAgenda In Array01
                                           Order By CType(est.a10FechaConsulta, Date) Descending
                                           Select CType(est.a10FechaConsulta, Date)


        'revisamos si se esta añadiendo una nueva o se esta editando retorcidamente por aqui
        If botConsultaOtroDiaAccion.Text = "Edita la Consulta" Then
            'se esta editando se usa igual porq se esta seleccionando una especifica
            If alsFechaOrdenadasDeConsultas(0) = dateFechaSeleccionadaOriginalmente Then
                EsLaUltimaConsultaLaSeleccionada = True 'en (0) se guarda la ultima consulta
            Else
                EsLaUltimaConsultaLaSeleccionada = False 'esta seleccionada cualquier otra fecha
            End If

        ElseIf botConsultaOtroDiaAccion.Text = "Nueva Consulta" Then
            'se esta añadiendo deberia ser distinta 
            If alsFechaOrdenadasDeConsultas(0) < dateFechaSeleccionadaOriginalmente Then
                EsLaUltimaConsultaLaSeleccionada = True 'en (0) se guarda la ultima consulta
            Else
                EsLaUltimaConsultaLaSeleccionada = False 'esta seleccionada cualquier otra fecha
            End If

        End If

        'ahora anota en la agenda
        AnotaEnLaAgenda()
        'refresca datos nuevos si los hay
        subInicializaAgenda()
        'muestra las fechas archivadas 
        subCargaArchivoPropioAGD()
        subMuestraFechasDeConsultasDelPaciente()
        subMuestraFechasDeConsultasEnElCalendario()
        'busca y muestra los datos complementarios si los hay para refrescar cualquier cambio
        subRecopilaDespuesMuestraDatosComplementarios()
        'vuelve a poner la fecha de hoy como base para que calcule bien las citas prox y perdidas
        PSdateFechaDeArraqueDeAgenda = Today

        'selecciona nuevamente lo q estaba seleccionado
        CalendarioConsultaOtraDia.SelectionStart = dateFechaSeleccionadaOriginalmente
        CalendarioConsultaOtraDia.SelectionEnd = dateFechaSeleccionadaOriginalmente
        'y lo muestra
        subVerificaSiHayConsultaElDiaSeleccionado()


    End Sub

    Private Sub botEditarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botEditarConsulta.Click

        EditarConsulta()

    End Sub
    Private Sub EditarConsulta()
        'guarda en memoria la fecha seleccionada en el listbox para volver a mostrarla al final
        Dim intIndex = ListBoxConsultas.SelectedIndex

        'prende la bandera de anotar en la agenda... ojooooo
        AnotaTrueBorraFalseEnLaAgenda = True
        'arraca con la fecha seleccionada
        PSdateFechaDeArraqueDeAgenda = CType(ListBoxConsultas.SelectedItem, Date)
        Dim año = PSdateFechaDeArraqueDeAgenda.Year 'es la fecha de hoy ver confdebasedatosnocargada
        PathAgendaControlesActual = PSstrPathAgendaBDH & "\" & año.ToString
        'crea la ruta a los archivos de agenda de año mes y dia y verifica si esa fecha tiene consulta pendiente y q dia
        subInicializaAgenda()
        'verifica si la historia es la mas reciente
        If ListBoxConsultas.SelectedIndex = 0 Then
            EsLaUltimaConsultaLaSeleccionada = True 'en (0) se guarda la ultima consulta
        Else
            EsLaUltimaConsultaLaSeleccionada = False 'esta seleccionada cualquier otra fecha
        End If
        'ahora anota en la agenda
        AnotaEnLaAgenda()
        'refresca datos nuevos si los hay
        subInicializaAgenda()
        'muestra las fechas archivadas 
        subCargaArchivoPropioAGD()
        subMuestraFechasDeConsultasDelPaciente()
        subMuestraFechasDeConsultasEnElCalendario()
        'busca y muestra los datos complementarios si los hay para refrescar cualquier cambio
        subRecopilaDespuesMuestraDatosComplementarios()
        'vuelve a poner la fecha de hoy como base para que calcule bien las citas prox y perdidas
        PSdateFechaDeArraqueDeAgenda = Today

        'selecciona nuevamente lo q estaba seleccionado
        ListBoxConsultas.SelectedIndex = intIndex
    End Sub

    Private Sub botEliminarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botEliminarConsulta.Click

        'bandera colocada a borrar la fecha seleccionada
        AnotaTrueBorraFalseEnLaAgenda = False
        'arraca con la fecha seleccionada
        PSdateFechaDeArraqueDeAgenda = CType(ListBoxConsultas.SelectedItem, Date)
        Dim año = PSdateFechaDeArraqueDeAgenda.Year 'es la fecha de hoy ver confdebasedatosnocargada
        PathAgendaControlesActual = PSstrPathAgendaBDH & "\" & año.ToString
        'crea la ruta a los archivos de agenda de año mes y dia y verifica si esa fecha tiene consulta pendiente y q dia
        subInicializaAgenda()
        'verifica si la historia es la mas reciente
        If ListBoxConsultas.SelectedIndex = 0 Then
            EsLaUltimaConsultaLaSeleccionada = True 'en (0) se guarda la ultima consulta
        Else
            EsLaUltimaConsultaLaSeleccionada = False 'esta seleccionada cualquier otra fecha
        End If
        'ahora anota en la agenda
        Dim DLG As New FormAnotaEnLaAgenda()
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'refresca datos nuevos si los hay
            subInicializaAgenda()
            'muestra las fechas archivadas 
            subCargaArchivoPropioAGD()
            subMuestraFechasDeConsultasDelPaciente()
            subMuestraFechasDeConsultasEnElCalendario()
            'busca y muestra los datos complementarios si los hay para refrescar cualquier cambio
            subRecopilaDespuesMuestraDatosComplementarios()
            'apaga los botones de editar y eliminar porq no habra nada seleccionado
            botEditarConsulta.Enabled = False
            botEliminarConsulta.Enabled = False
        End If
        'vuelve a poner la fecha de hoy como base para que calcule bien las citas prox y perdidas
        PSdateFechaDeArraqueDeAgenda = Today

    End Sub


    Private Sub AnotaEnLaAgenda()
        Dim DLG As New FormAnotaEnLaAgenda()
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub subModoHistoriaAbierta()

        'prende la bandera de Historia abierta
        PSbooHistoriaAbierta = True

        'coloca todos los botones y mensajes para el momento en que este seleccionada una historia
        'apaga el listbox de las historias para evitar que se seleccione otra mientras se edita la actual
        ListBoxHistorias.Enabled = False
        'anuncia que debes deseleccionar la historia para poder seleccionar otra
        LabMensajeBaseDatos.Text = "Debes cerrar la historia actual para poder seleccionar otra..."
        LabMensajeBaseDatos.Image = BarraMensajeMal
        'apaga los botones de crear nueva y abrir historias y bases de dato
        botAbrirHistoria.Enabled = False
        BotNuevaHistoria.Enabled = False
        MenuCreaBase.Enabled = False
        MenuAbreBase.Enabled = False
        botRenombraHistoria.Enabled = False
        'prende el boton de deseleccionar
        botCerrarHistoria.Enabled = True
        botCerrarHistoria2.Enabled = True
        botConsultaHoy.Enabled = True
        botConsultaOtroDia.Enabled = True

        radBASEacudieronExpontaneamente.Enabled = False
        radBASEconConsultaPendiente.Enabled = False
        radBASEconConsultaPendienteProxMes.Enabled = False
        radBASEControlObs.Enabled = False
        radBASEembarazadas.Enabled = False
        radBASEpacientesReferidasPorPtes.Enabled = False
        radBASEpacientesReferidoras.Enabled = False
        radBASEptesDeOtrosMedicos.Enabled = False
        radBASEReferidasPorOtros.Enabled = False
        radBASEseDesconoceReferencia.Enabled = False
        radBASEtodasLasPacientes.Enabled = False

        txtBASEresumenPte.Enabled = False

        txtFiltro.Enabled = False

        TabControlNotas.Enabled = True

    End Sub

    Private Sub subModoHistoriaNoAbierta()

        'apaga la bandera de historia abierta
        PSbooHistoriaAbierta = False

        ListBoxHistorias.Enabled = True
        LabMensajeBaseDatos.Text = "Selecciona de la Lista una historia o Crea una Historia Nueva"
        LabMensajeBaseDatos.Image = BarraMensajeBien
        labMensajedeAgenda.Text = ""
        labMensajedeAgenda.Image = BarraSinMensaje

        botAbrirHistoria.Enabled = False
        BotNuevaHistoria.Enabled = True
        botRenombraHistoria.Enabled = False
        MenuCreaBase.Enabled = True
        MenuAbreBase.Enabled = True
        botCerrarHistoria.Enabled = False
        botCerrarHistoria2.Enabled = False
        botConsultaHoy.Enabled = False
        botConsultaOtroDia.Enabled = False
        botEditarConsulta.Enabled = False
        botEliminarConsulta.Enabled = False

        txtBASEresumenPte.Enabled = True

        radBASEacudieronExpontaneamente.Enabled = True
        radBASEconConsultaPendiente.Enabled = True
        radBASEconConsultaPendienteProxMes.Enabled = True
        radBASEControlObs.Enabled = True
        radBASEembarazadas.Enabled = True
        radBASEpacientesReferidasPorPtes.Enabled = True
        radBASEpacientesReferidoras.Enabled = True
        radBASEptesDeOtrosMedicos.Enabled = True
        radBASEReferidasPorOtros.Enabled = True
        radBASEseDesconoceReferencia.Enabled = True
        radBASEtodasLasPacientes.Enabled = True

        txtFiltro.Enabled = True

        ListBoxConsultas.Items.Clear()

        subLimpiaCuadrosDeTextoDeAgendaEnForm1()

        LabNumeroSeleccionado.Text = ""
        LabCedulaSeleccionada.Text = ""
        LabNombreSeleccionado.Text = ""
        LabHistoriaAbierta.Text = ""

        LabNombreSeleccionado3.Text = "fue referida por"
        LabNombreSeleccionado4.Text = "ha referido a"
        labDCpacientesReferidasPorReferidor.Text = "ha referido a"
        labDCpacientesReferidasPorReferidor.Visible = False
        txtDCpacientesReferidasPorReferidor.Visible = False
        labDCVinculoDeLaPteConElReferidor.Text = ""
        labDCVinculoDeLaPteConElReferidor.Visible = False
        labDCVinculoDeLaPteConElReferidorTitulo.Visible = False

        'estos datos no se si quitarlos porq igual al seleccionar sin abrir vuelven a cargarse, realmente los que hay q apagar son los de la estPacienteAbierta
        PSstrPacienteSeleccionadaNombre = ""
        PSstrPacienteSeleccionadaCedula = ""
        PSdatPacienteSeleccionadaFechaDeNacimiento = Nothing
        PSintPacienteSeleccionadaEdad = -1
        PSstrNumeroHistoriaSeleccionada = ""
        NumeroDeHistoriaCompleto = ""

        estPacienteAbierta.a01strNombre = ""
        estPacienteAbierta.a02strCedula = ""
        estPacienteAbierta.a03datFechaDeNacimiento = Nothing
        estPacienteAbierta.a04intEdadActual = -1
        estPacienteAbierta.a05strParidad = ""

        txtHistoriaNotificaciones.Clear()

        ListBoxContenido.Items.Clear()
        botDatosPersonales.Enabled = False
        BotControlGinecologico.Enabled = False
        botNuevaHistoriaObstetrica.Enabled = False
        botNuevoEco.Enabled = False

        LimpiaDatosComplementariosDePantalla()
        TabControlNotas.Enabled = False

        'borra la paridad para q no quede echando vaina
        Form1.PSstrPacienteSeleccionadaParidad = ""

        Me.Refresh()

        subCargaArchivoDeOtrosRef()
        LeeContenidoBaseDatos()
        MuestraContenidoBaseDatos()
        If Form1.booFechaNacimientoModificada = True Then
            CompruebaCumpleaños()
        End If

        'muestra la lista de ptes despues q s acomodo todo
        TabControl1.SelectedTab = TabPage4
    End Sub


    Private Sub ListBoxConsultas_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxConsultas.DoubleClick
        If ListBoxConsultas.SelectedIndex = -1 Or ListBoxConsultas.SelectedItem = "No existen datos..." Then
            Exit Sub 'sale sin hacer nada
        End If

        EditarConsulta()

    End Sub





    Private Sub ListBoxConsultas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ListBoxConsultas.SelectedIndexChanged

        If ListBoxConsultas.SelectedIndex = -1 Or ListBoxConsultas.SelectedItem = "No existen datos..." Then
            Exit Sub 'sale sin hacer nada
        End If

        'enciende los botones de edicion y borrar la consulta
        botEliminarConsulta.Enabled = True
        botEditarConsulta.Enabled = True

        subLimpiaCuadrosDeTextoDeAgendaEnForm1()

        'muestra la consulta pasando la fecha q esta seleccionada en el listbox
        subMuestraConsultaSeleccionada(CType(ListBoxConsultas.SelectedItem, Date))

    End Sub

    Private Sub subMuestraConsultaSeleccionada(ByVal dateFechaDeLaConsultaParaMostrar As Date)

        Dim FechaBuscada As Date
        Dim FechaComparada As Date

        'adquiere la fecha pasada depende desde donde se haya mandado
        FechaBuscada = dateFechaDeLaConsultaParaMostrar

        'busca en el array de las consultas de la agenda cual es la seleccionada
        For Each est As Form1.TablaDeArchivosPropiosDeAgenda In Array01
            FechaComparada = CType(est.a10FechaConsulta, Date)
            If FechaBuscada = FechaComparada Then

                txtAgendaManual.Text = est.a03NotaseIDx
                txtAgendaTratamiento.Text = est.a04Tratamiento
                txtAgendaPendiente.Text = est.a05Pendiente
                txtAgendaLugarConsulta.Text = est.a02Clinica

                If est.a11FacturaAsociada <> "" Then
                    txtAgendaFactura.Text = est.a11FacturaAsociada.PadLeft(5, "0"c)
                Else
                    'esta en blanco no tiene factura
                    txtAgendaFactura.Text = ""
                End If

                If est.a12Pagador <> "" Then
                    'hay un dato fue pagada por alguien mas
                    txtAgendaPagador.Text = est.a12Pagador
                Else
                    'esta en blanco fue pagada por la pte
                    txtAgendaPagador.Text = "La paciente"
                End If


                'parte nueva la mayoria va a estar en blanco porq no habra necesidad de rellenar todo solo los cambios seran tomados
                If est.a13FechaDePago = "" Then
                    'esta en blanco... se considera q fue pagada el mismo dia los pone
                    txtAgendaEstatusCancelacion.Text = "Cancelada el mismo día"
                    txtAgendaFechaDeCancelacion.Text = CType(est.a10FechaConsulta, Date).ToShortDateString
                Else
                    'ok es un dato nuevo reciente que cambio este dato verifica
                    If IsDate(est.a13FechaDePago) Then
                        'hay una fecha valida la compara
                        If CType(est.a13FechaDePago, Date).Date = CType(est.a10FechaConsulta, Date).Date Then
                            'se cancelo el mismo dia 
                            txtAgendaEstatusCancelacion.Text = "Cancelada el mismo día"
                            txtAgendaFechaDeCancelacion.Text = CType(est.a10FechaConsulta, Date).ToShortDateString

                        ElseIf CType(est.a13FechaDePago, Date) = Nothing Then
                            'si esta explicitamente en nothin se considera pendiente asi se programara en anota la agenda
                            txtAgendaEstatusCancelacion.Text = "Pendiente"
                            txtAgendaFechaDeCancelacion.Text = ""
                        Else
                            'se cancelo otro dia
                            txtAgendaEstatusCancelacion.Text = "Cancelada diferida el día"
                            txtAgendaFechaDeCancelacion.Text = CType(est.a10FechaConsulta, Date).ToShortDateString
                        End If

                    End If
                End If

                'los datos de la forma de pago
                If est.a14FormaDePago = "" Then
                    'en blanco se considera en efectivo
                    txtAgendaFormaDePago.Text = "Efectivo"
                    txtAgendaBanco.Text = ""
                    txtAgendaReferencia.Text = ""
                Else
                    'hay algo en forma de pago lo muestra
                    txtAgendaFormaDePago.Text = est.a14FormaDePago
                    'ahora muestra lo q esta en banco y ref
                    txtAgendaBanco.Text = est.a15Banco
                    txtAgendaReferencia.Text = est.a16Referencia
                End If

                'formatea honorarios
                Dim decHonorarios As Decimal
                If est.a07Honorarios <> "" Then
                    decHonorarios = CType(est.a07Honorarios, Decimal)
                Else
                    decHonorarios = 0
                End If
                'Dim strHonorariosFormatoMoneda = FormatCurrency(decHonorarios, 2, , TriState.True, TriState.True)
                Dim strHonorariosFormatoMoneda = FormatCurrency(decHonorarios, 2,,,)
                txtAgendaHonorarios.Text = strHonorariosFormatoMoneda

                'formatea proxima fecha
                If IsDate(est.a06ProximaConsulta) Then
                    txtAgendaProximaConsulta.Text = (CType(est.a06ProximaConsulta, Date)).ToLongDateString
                Else
                    txtAgendaProximaConsulta.Text = ""
                End If

                Exit For  'sal del for ya mostro todo

            End If
        Next

        'obtiene datos automaticos desde control obs y ecografias con la fecha seleccionada
        subGeneraDatosAutomaticos()
        txtAgendaAuto.Text = strAutoGeneradoControlObs & vbCrLf & strAutoGeneradoEco
    End Sub




#Region "       ****** APERTURA DE LAS DIFERENTES PARTES DE LA HISTORIA *******"

    Private Sub ListBoxContenido_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxContenido.DoubleClick
        ' aca es donde se abre un elemento que ya existia
        'revisa si se quiere modificar los datos personales
        If ListBoxContenido.SelectedItem = PSstrNumeroHistoriaSeleccionada & "-Datos Personales" Then
            MuestraVentanaDatosPersonales()
            LeeContenidoHistoria()
            MuestraContenidoHistoria()
        End If
        If ListBoxContenido.SelectedItem = PSstrNumeroHistoriaSeleccionada & "-Control Ginecológico" Then
            MuestraVentanaControlGinecologico2()
            LeeContenidoHistoria()
            MuestraContenidoHistoria()
        End If
        If ListBoxContenido.SelectedItem = PSstrNumeroHistoriaSeleccionada & "-Control Obstétrico" Then
            MuestraVentanaControlObstetrico()
            LeeContenidoHistoria()
            MuestraContenidoHistoria()
        End If
        If ListBoxContenido.SelectedItem = PSstrNumeroHistoriaSeleccionada & "-Control Ecográfico" Then
            MuestraVentanaControlEcografico2()
            LeeContenidoHistoria()
            MuestraContenidoHistoria()
        End If
        If ListBoxContenido.SelectedItem = PSstrNumeroHistoriaSeleccionada & "-Imágenes Ecográficas" Then
            MuestraVentanaControlEcografico2()
            LeeContenidoHistoria()
            MuestraContenidoHistoria()
        End If

    End Sub

    Private Sub botDatosPersonales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botDatosPersonales.Click
        MuestraVentanaDatosPersonales()

        LeeContenidoHistoria()
        MuestraContenidoHistoria()
        'actualiza los datos q puedan haber cambiado
        subRecopilaDespuesMuestraDatosComplementarios()

    End Sub
    Private Sub MuestraVentanaDatosPersonales()
        Dim DLG As New Datos_Personales()
        'Dim LineaDatos As String

        'busca los elementos de la subhistoria
        BuscaElementosEnHistoria()
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'se aceptaron los cambios lo informa
            MuestraContenidoHistoria()
            BuscaElementosEnHistoria()
            BotControlGinecologico.Enabled = True
            botNuevaHistoriaObstetrica.Enabled = True
            botNuevoEco.Enabled = True

            'actualiza los datos complementarios en pantalla
            subRecopilaDespuesMuestraDatosComplementarios()

            'ahora verifica si cambio el telefono...
            If Form1.PSbooSeModificoElTelefono = True Then
                'hubo modificacion, automaticamente verifica a hoy
                Form1.PSbooSeModificoElTelefono = False 'apaga la bandera...

                'actualiza el archivo de DC con los datos nuevos
                booActualizadoVerificacionDeCelularAutomaticamente = True 'prende la bandera de q se va a actualizar automaticamrente
                subActualizaTelefonoVerificado()

            End If

            'revisa a ver si hay notificaciones
            subVerificaDatosComplementariosMuestraNotificaciones()

        Else
            'se presiono salir o descartar datos segun si se hayan producido modificaciones
            'se realizaron modificaciones y se descartaron
            BuscaElementosEnHistoria()
            If ExisteDatosPersonales = True Then
                BotControlGinecologico.Enabled = True
                botNuevaHistoriaObstetrica.Enabled = True
                botNuevoEco.Enabled = True
            Else
                BotControlGinecologico.Enabled = False
                botNuevaHistoriaObstetrica.Enabled = False
                botNuevoEco.Enabled = False
            End If
            'actualiza los cambiosen pantalla
            subRecopilaDespuesMuestraDatosComplementarios()
            'revisa a ver si hay notificaciones
            subVerificaDatosComplementariosMuestraNotificaciones()
        End If



    End Sub

    Private Sub botControlGinecologico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotControlGinecologico.Click
        MuestraVentanaControlGinecologico2()
        LeeContenidoHistoria()
        MuestraContenidoHistoria()
    End Sub
    Private Sub MuestraVentanaControlGinecologico2()
        Dim DLG As New FormControlGinecologico2()

        BuscaElementosEnHistoria()
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        Else
            'MsgBox("Se habrian desechado los cambios", MsgBoxStyle.Information)
        End If
        'actualiza los cambiosen pantalla
        subRecopilaDespuesMuestraDatosComplementarios()
        'revisa a ver si hay notificaciones
        subVerificaDatosComplementariosMuestraNotificaciones()
    End Sub

    Private Sub botNuevaHistoriaObstetrica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNuevaHistoriaObstetrica.Click
        MuestraVentanaControlObstetrico()
        LeeContenidoHistoria()
        MuestraContenidoHistoria()
    End Sub
    Private Sub MuestraVentanaControlObstetrico()
        Dim DLG As New FormControlObstetrico()
        BuscaElementosEnHistoria()
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        Else

        End If
        'actualiza los cambiosen pantalla
        subRecopilaDespuesMuestraDatosComplementarios()
        'revisa a ver si hay notificaciones
        subVerificaDatosComplementariosMuestraNotificaciones()
    End Sub

    Private Sub botNuevoEco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNuevoEco.Click
        MuestraVentanaControlEcografico2()
        LeeContenidoHistoria()
        MuestraContenidoHistoria()
    End Sub
    Private Sub MuestraVentanaControlEcografico2()
        Dim DLG As New FormControlEcografico2()

        BuscaElementosEnHistoria()
        'Me.Visible = False

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        Else

        End If
        'Me.Visible = True

        'actualiza los cambiosen pantalla
        subRecopilaDespuesMuestraDatosComplementarios()
        'revisa a ver si hay notificaciones
        subVerificaDatosComplementariosMuestraNotificaciones()
    End Sub

    Private Sub botGuardias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
          Handles botGuardias.Click

        Dim DLG As New FormGuardias()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        Else
            'MsgBox("Se habrian desechado los cambios", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub botIntervenciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botIntervenciones.Click
        Dim Intervenciones As New FormIntervenciones()

        'coloca la fecha actual como inicio de edicion para las intervenciones
        Form1.dateFechaDeInicioParaModificarIntervenciones = Today

        If Intervenciones.ShowDialog = Windows.Forms.DialogResult.OK Then
            'se acepto lo introducido
        End If
    End Sub
    Private Sub botPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPagos.Click
        Dim Pagos As New FormPagos

        If Pagos.ShowDialog = Windows.Forms.DialogResult.OK Then
            'se acepto
        Else
            'se cancelo
        End If
    End Sub

#End Region

    Private Sub MuestraVentanaContraseña()

        Dim Y As Date
        Dim NumeroPC As String
        Dim NumeroInicial As Long
        Dim Resultado As Long


        Dim DirSistema As String
        Dim ArchivoDLL As String
        Dim BW As BinaryWriter
        'Dim BR As BinaryReader
        Dim FS As FileStream
        Dim Clave As String
        Dim ClaveLong As Long

        Dim DLG As New formContraseña()

        DirSistema = Environment.SystemDirectory
        ArchivoDLL = DirSistema & "\hc.dll"

        If Directory.Exists(DirSistema) Then
            Y = Directory.GetCreationTime(DirSistema)
            NumeroPC = Y.Ticks.ToString
            NumeroPC = NumeroPC.Substring(8, 10)
            NumeroInicial = CType(NumeroPC, Long)
            Resultado = NumeroInicial + 10061997
            Resultado *= 7
            Resultado -= 25091968
            Resultado *= 36
        End If


        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

            Clave = formContraseña.Contraseña
            If IsNumeric(Clave) Then
                ClaveLong = CType(Clave, Long)
            Else
                ClaveIncorrecta()
            End If

            If ClaveLong = Resultado Then
                'esta bien crea el archivo y escribe la clave
                FS = New FileStream(ArchivoDLL, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)

                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                BW.Write(Clave)

                FS.Close()
                BW.Close()
                MsgBox("Clave OK...")
            Else
                ClaveIncorrecta()
            End If
        Else
            ClaveIncorrecta()
        End If

    End Sub

#Region "       ********** EVENTOS DE ENTRADA SALIDA MOUSE ***********"

    Private Sub BotNuevaHistoria_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles BotNuevaHistoria.MouseEnter
        BotNuevaHistoria.BackgroundImage = BotonOn
    End Sub
    Private Sub BotNuevaHistoria_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles BotNuevaHistoria.MouseLeave
        BotNuevaHistoria.BackgroundImage = BotonOff
    End Sub

    Private Sub BotAbreHistoria_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botAbrirHistoria.MouseEnter
        botAbrirHistoria.BackgroundImage = BotonOn
    End Sub
    Private Sub BotabrirHistoria_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botAbrirHistoria.MouseLeave
        botAbrirHistoria.BackgroundImage = BotonOff
    End Sub

    Private Sub BotrenombraHistoria_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botRenombraHistoria.MouseEnter
        botRenombraHistoria.BackgroundImage = BotonOn
    End Sub
    Private Sub BotrenombraHistoria_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botRenombraHistoria.MouseLeave
        botRenombraHistoria.BackgroundImage = BotonOff
    End Sub

    Private Sub BotcerrarHistoria_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botCerrarHistoria.MouseEnter
        botCerrarHistoria.BackgroundImage = BotonOn
    End Sub
    Private Sub BotcerrarHistoria_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botCerrarHistoria.MouseLeave
        botCerrarHistoria.BackgroundImage = BotonOff
    End Sub

    Private Sub Botrespalda_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botGuardias.MouseEnter
        botGuardias.BackgroundImage = BotonOn
    End Sub
    Private Sub Botrespalda_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botGuardias.MouseLeave
        botGuardias.BackgroundImage = BotonOff
    End Sub

    Private Sub Botdatospersonales_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botDatosPersonales.MouseEnter
        botDatosPersonales.BackgroundImage = BotonOnGrande
    End Sub
    Private Sub Botdatospersonales_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botDatosPersonales.MouseLeave
        botDatosPersonales.BackgroundImage = BotonOffGrande
    End Sub

    Private Sub Botcontrolginecologico_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotControlGinecologico.MouseEnter
        BotControlGinecologico.BackgroundImage = BotonOnGrande
    End Sub
    Private Sub Botcontrolginecologico_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotControlGinecologico.MouseLeave
        BotControlGinecologico.BackgroundImage = BotonOffGrande
    End Sub

    Private Sub Botnuevahistoriaobstetrica_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botNuevaHistoriaObstetrica.MouseEnter
        botNuevaHistoriaObstetrica.BackgroundImage = BotonOnGrande
    End Sub
    Private Sub Botnuevahistoriaobstetrica_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botNuevaHistoriaObstetrica.MouseLeave
        botNuevaHistoriaObstetrica.BackgroundImage = BotonOffGrande
    End Sub

    Private Sub Botnuevoeco_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botNuevoEco.MouseEnter
        botNuevoEco.BackgroundImage = BotonOnGrande
    End Sub
    Private Sub Botnuevoeco_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botNuevoEco.MouseLeave
        botNuevoEco.BackgroundImage = BotonOffGrande
    End Sub

    Private Sub botcerrarhistoria2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles botCerrarHistoria2.MouseEnter
        botCerrarHistoria2.BackgroundImage = BotonOnGrande
    End Sub
    Private Sub botcerrarhistoria2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botCerrarHistoria2.MouseLeave
        botCerrarHistoria2.BackgroundImage = BotonOffGrande
    End Sub

    Private Sub botAgendaHoy_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botConsultaHoy.MouseEnter
        botConsultaHoy.BackgroundImage = BotonOn
    End Sub
    Private Sub botAgendaHoy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botConsultaHoy.MouseLeave
        botConsultaHoy.BackgroundImage = BotonOff
    End Sub

    Private Sub botintervenciones_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botIntervenciones.MouseEnter
        botIntervenciones.BackgroundImage = BotonOn
    End Sub
    Private Sub botintervenciones_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles botIntervenciones.MouseLeave
        botIntervenciones.BackgroundImage = BotonOff
    End Sub

    Private Sub botConsultaOtroDia_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botConsultaOtroDia.MouseEnter
        botConsultaOtroDia.BackgroundImage = BotonOn
    End Sub
    Private Sub botConsultaOtroDia_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botConsultaOtroDia.MouseLeave
        botConsultaOtroDia.BackgroundImage = BotonOff
    End Sub

    Private Sub botEliminarConsulta_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botEliminarConsulta.MouseEnter
        botEliminarConsulta.BackgroundImage = BotonOn
    End Sub
    Private Sub botEliminarConsulta_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botEliminarConsulta.MouseLeave
        botEliminarConsulta.BackgroundImage = BotonOff
    End Sub

    Private Sub botPagos_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botPagos.MouseEnter
        botPagos.BackgroundImage = BotonOn
    End Sub
    Private Sub botPagos_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botPagos.MouseLeave
        botPagos.BackgroundImage = BotonOff
    End Sub
    Private Sub botConsultaOtroDiaAccion_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botConsultaOtroDiaAccion.MouseEnter
        botConsultaOtroDiaAccion.BackgroundImage = BotonOn
    End Sub
    Private Sub botConsultaOtroDiaAccion_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botConsultaOtroDiaAccion.MouseLeave
        botConsultaOtroDiaAccion.BackgroundImage = BotonOff
    End Sub
    Private Sub botEditarConsulta_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botEditarConsulta.MouseEnter
        botEditarConsulta.BackgroundImage = BotonOn
    End Sub
    Private Sub botEditarConsulta_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles botEditarConsulta.MouseLeave
        botEditarConsulta.BackgroundImage = BotonOff
    End Sub

#End Region

#Region "       ******DATOS AUTOGENERADOS ********"

    'VARIABLES LOCALES DEL FORM PARA LOS AUTOGENERADOS
    Dim arrEmbarazosDeLaPteSeleccionada As New ArrayList
    Dim estOBS As New FormControlObstetrico.TablaDeDatosRescatadosDelControlObs

    Dim arrEcosDelPacienteActual As New ArrayList
    Dim estECO As New FormControlObstetrico.TablaDeDatosRescatadosDelEco

    Dim strFUR As String = ""
    Dim dateFUR As Date = Nothing
    Dim dateFecha As Date = Nothing

    Dim strAutoGeneradoControlObs As String = ""
    Dim strAutoGeneradoEco As String = ""


    Private Sub subGeneraDatosAutomaticos()

        'carga controles obstetricos
        subCargaControlesObstetricosDeLaPteSeleccionada()
        ''Busca los datos adecuados segun fecha seleccionada revisa q se esta seleccionando
        If CalendarioConsultaOtraDia.Visible = True Then
            'se esta viendo el calendario de otro dia saca la fecha de ahi
            subBuscaDatosObstetricosDeLaFechaSeleccionada(CalendarioConsultaOtraDia.SelectionStart)
        Else
            'se esta seleccionando por el list box saca la fecha de ahi
            Dim dateDiaSeleccionadoParaMostrarDatos = CType(ListBoxConsultas.SelectedItem, Date)
            subBuscaDatosObstetricosDeLaFechaSeleccionada(dateDiaSeleccionadoParaMostrarDatos)
        End If

        ''Genera las notas obs automaticas
        subGeneraNotasObstetricasAutomaticas()

        'carga controles ecograficos
        subCargaEcografiasDeLaPteSeleccionada()
        'Busca los datos adecuados segun fecha seleccionada
        If CalendarioConsultaOtraDia.Visible = True Then
            'se esta viendo el calendario de otro dia saca la fecha de ahi
            subBuscaDatosEcograficosDeLaFechaSeleccionada(CalendarioConsultaOtraDia.SelectionStart)
        Else
            'se esta seleccionando por el list box saca la fecha de ahi
            Dim dateDiaSeleccionadoParaMostrarDatos = CType(ListBoxConsultas.SelectedItem, Date)
            subBuscaDatosEcograficosDeLaFechaSeleccionada(dateDiaSeleccionadoParaMostrarDatos)
        End If

        'Genera las notas eco automaticas
        subGeneraNotasEcograficasAutomaticas()


    End Sub

    'region underground
    Private Sub LabNumeroSeleccionado_DClick(sender As Object, e As EventArgs) Handles LabNumeroSeleccionado.DoubleClick

        booPrevioMuestraOcultos = True

    End Sub
    Private Sub LabNombreBaseDatos_DClick(sender As Object, e As EventArgs) Handles LabNombreBaseDatos.DoubleClick

        If booPrevioMuestraOcultos = False Then
            Exit Sub
        End If

        Dim strCodigo = InputBox("Código: ", "Validación", "xxxxxx",,)
        If strCodigo = "251012" Then
            If PS_booMuestraOcultos = False Then
                PS_booMuestraOcultos = True
                MsgBox("Mostrando")
            Else
                PS_booMuestraOcultos = False
                MsgBox("NO Mostrando")
            End If
        End If

        booPrevioMuestraOcultos = False

    End Sub

    Private Sub subCargaControlesObstetricosDeLaPteSeleccionada()
        Dim FS As FileStream
        Dim BR As BinaryReader

        Dim R As New Form1.TablaDeDatosObstetricos

        If File.Exists(strArchivoControlObstetricoDelPteSeleccionado) Then
            'si existe lo lee
            FS = New FileStream(strArchivoControlObstetricoDelPteSeleccionado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            arrEmbarazosDeLaPteSeleccionada.Clear()

            Dim C = BR.PeekChar
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
    Private Sub subBuscaDatosObstetricosDeLaFechaSeleccionada(ByVal dateFechaSeleccionadaParaMostrarDatos As Date)
        'busca datos de la fecha seleccionada si existen
        'Dim strFechaBuscadaSDS = ListBoxConsultas.SelectedItem.ToString
        Dim strFechaBuscadaSDS = dateFechaSeleccionadaParaMostrarDatos.ToShortDateString

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
    Function funcionCalculaEGconFURhastaHoyRetornaStringXXsXXd(ByVal dateFUR As Date) As String

        Dim Semanas As Long = 0
        Dim Calculo As Double
        Dim Dias As Integer
        Dim EG As Long

        EG = (DateDiff(DateInterval.Day, dateFUR, Today))
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
            Return Semanas.ToString.PadLeft(2, "0"c) & "s" & " " & Dias.ToString & "d"
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
        Dim FS As FileStream
        Dim BR As BinaryReader

        Dim estH As New Form1.TablaDeDatosEcograficos()

        If File.Exists(strArchivoControlEcograficoDelPteSeleccionado) = True Then

            'existe el archivo lo lee
            FS = New FileStream(strArchivoControlEcograficoDelPteSeleccionado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)


            arrEcosDelPacienteActual.Clear()

            Dim C = BR.PeekChar
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
    Private Sub subBuscaDatosEcograficosDeLaFechaSeleccionada(ByVal dateFechaSeleccionadaParaMostrarDatos As Date)
        'busca datos de la fecha seleccionada si existen
        'Dim strFechaBuscadaSDS = ListBoxConsultas.SelectedItem.ToString
        Dim strFechaBuscadaSDS = dateFechaSeleccionadaParaMostrarDatos.ToShortDateString

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
                strAutoGeneradoEco += "DCN: " & estECO.a01DCN & "mm."
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



#End Region

End Class
