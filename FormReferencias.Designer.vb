<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReferencias
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
        Me.botSalir = New System.Windows.Forms.Button
        Me.GroupBoxNUEVA = New System.Windows.Forms.GroupBox
        Me.PanelNUEVAreferidaPorOtro = New System.Windows.Forms.Panel
        Me.botNUEVAnuevoReferidor = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.ListBoxNUEVAreferidasPorOtro = New System.Windows.Forms.ListBox
        Me.labNUEVAotroSeleccionada = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.labNUEVAListadoOtros = New System.Windows.Forms.Label
        Me.txtNUEVAotrosFiltro = New System.Windows.Forms.TextBox
        Me.ListBoxNUEVAotros = New System.Windows.Forms.ListBox
        Me.PanelNUEVAreferidaPorPaciente = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.ListBoxNUEVAreferidasPorPaciente = New System.Windows.Forms.ListBox
        Me.labNUEVApacienteSeleccionada = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.labNUEVAlistadoPacientes = New System.Windows.Forms.Label
        Me.txtNUEVApacientesFiltro = New System.Windows.Forms.TextBox
        Me.ListBoxNUEVApacientes = New System.Windows.Forms.ListBox
        Me.radNUEVAreferidaPorOtro = New System.Windows.Forms.RadioButton
        Me.radNUEVAreferidaPorPaciente = New System.Windows.Forms.RadioButton
        Me.radNUEVAacudioSola = New System.Windows.Forms.RadioButton
        Me.GroupBoxACTUALIZAR = New System.Windows.Forms.GroupBox
        Me.PanelACTUALIZAreferidaPorOtro = New System.Windows.Forms.Panel
        Me.botACTUALIZAnuevoReferidor = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.ListBoxACTUALIZAreferidasPorOtro = New System.Windows.Forms.ListBox
        Me.labACTUALIZAotroSeleccionada = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.labACTUALIZAListadoOtros = New System.Windows.Forms.Label
        Me.txtACTUALIZAotrosFiltro = New System.Windows.Forms.TextBox
        Me.ListBoxACTUALIZAotros = New System.Windows.Forms.ListBox
        Me.PanelACTUALIZAreferidaPorPaciente = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListBoxACTUALIZAreferidasPorPaciente = New System.Windows.Forms.ListBox
        Me.labACTUALIZApacienteSeleccionada = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.labACTUALIZAlistadoPacientes = New System.Windows.Forms.Label
        Me.txtACTUALIZApacientesFiltro = New System.Windows.Forms.TextBox
        Me.ListBoxACTUALIZApacientes = New System.Windows.Forms.ListBox
        Me.radACTUALIZAreferidaPorOtro = New System.Windows.Forms.RadioButton
        Me.radACTUALIZAreferidaPorPaciente = New System.Windows.Forms.RadioButton
        Me.radACTUALIZAacudioSola = New System.Windows.Forms.RadioButton
        Me.botAceptar = New System.Windows.Forms.Button
        Me.botNUEVAeditaReferidor = New System.Windows.Forms.Button
        Me.botACTUALIZAeditaReferidor = New System.Windows.Forms.Button
        Me.GroupBoxNUEVA.SuspendLayout()
        Me.PanelNUEVAreferidaPorOtro.SuspendLayout()
        Me.PanelNUEVAreferidaPorPaciente.SuspendLayout()
        Me.GroupBoxACTUALIZAR.SuspendLayout()
        Me.PanelACTUALIZAreferidaPorOtro.SuspendLayout()
        Me.PanelACTUALIZAreferidaPorPaciente.SuspendLayout()
        Me.SuspendLayout()
        '
        'botSalir
        '
        Me.botSalir.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botSalir.Location = New System.Drawing.Point(12, 622)
        Me.botSalir.Name = "botSalir"
        Me.botSalir.Size = New System.Drawing.Size(224, 23)
        Me.botSalir.TabIndex = 1
        Me.botSalir.Text = "Salir"
        Me.botSalir.UseVisualStyleBackColor = True
        '
        'GroupBoxNUEVA
        '
        Me.GroupBoxNUEVA.Controls.Add(Me.PanelNUEVAreferidaPorOtro)
        Me.GroupBoxNUEVA.Controls.Add(Me.PanelNUEVAreferidaPorPaciente)
        Me.GroupBoxNUEVA.Controls.Add(Me.radNUEVAreferidaPorOtro)
        Me.GroupBoxNUEVA.Controls.Add(Me.radNUEVAreferidaPorPaciente)
        Me.GroupBoxNUEVA.Controls.Add(Me.radNUEVAacudioSola)
        Me.GroupBoxNUEVA.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxNUEVA.Name = "GroupBoxNUEVA"
        Me.GroupBoxNUEVA.Size = New System.Drawing.Size(937, 597)
        Me.GroupBoxNUEVA.TabIndex = 2
        Me.GroupBoxNUEVA.TabStop = False
        Me.GroupBoxNUEVA.Text = "Nueva Referencia"
        '
        'PanelNUEVAreferidaPorOtro
        '
        Me.PanelNUEVAreferidaPorOtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelNUEVAreferidaPorOtro.Controls.Add(Me.botNUEVAeditaReferidor)
        Me.PanelNUEVAreferidaPorOtro.Controls.Add(Me.botNUEVAnuevoReferidor)
        Me.PanelNUEVAreferidaPorOtro.Controls.Add(Me.Label5)
        Me.PanelNUEVAreferidaPorOtro.Controls.Add(Me.ListBoxNUEVAreferidasPorOtro)
        Me.PanelNUEVAreferidaPorOtro.Controls.Add(Me.labNUEVAotroSeleccionada)
        Me.PanelNUEVAreferidaPorOtro.Controls.Add(Me.Label7)
        Me.PanelNUEVAreferidaPorOtro.Controls.Add(Me.Label8)
        Me.PanelNUEVAreferidaPorOtro.Controls.Add(Me.labNUEVAListadoOtros)
        Me.PanelNUEVAreferidaPorOtro.Controls.Add(Me.txtNUEVAotrosFiltro)
        Me.PanelNUEVAreferidaPorOtro.Controls.Add(Me.ListBoxNUEVAotros)
        Me.PanelNUEVAreferidaPorOtro.Enabled = False
        Me.PanelNUEVAreferidaPorOtro.Location = New System.Drawing.Point(309, 69)
        Me.PanelNUEVAreferidaPorOtro.Name = "PanelNUEVAreferidaPorOtro"
        Me.PanelNUEVAreferidaPorOtro.Size = New System.Drawing.Size(299, 522)
        Me.PanelNUEVAreferidaPorOtro.TabIndex = 4
        '
        'botNUEVAnuevoReferidor
        '
        Me.botNUEVAnuevoReferidor.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botNUEVAnuevoReferidor.Location = New System.Drawing.Point(41, 258)
        Me.botNUEVAnuevoReferidor.Name = "botNUEVAnuevoReferidor"
        Me.botNUEVAnuevoReferidor.Size = New System.Drawing.Size(224, 23)
        Me.botNUEVAnuevoReferidor.TabIndex = 50
        Me.botNUEVAnuevoReferidor.Text = "Incluye Nuevo Referidor"
        Me.botNUEVAnuevoReferidor.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Otras Pacientes Referidas por este Referidor"
        '
        'ListBoxNUEVAreferidasPorOtro
        '
        Me.ListBoxNUEVAreferidasPorOtro.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNUEVAreferidasPorOtro.FormattingEnabled = True
        Me.ListBoxNUEVAreferidasPorOtro.ItemHeight = 9
        Me.ListBoxNUEVAreferidasPorOtro.Location = New System.Drawing.Point(6, 378)
        Me.ListBoxNUEVAreferidasPorOtro.Name = "ListBoxNUEVAreferidasPorOtro"
        Me.ListBoxNUEVAreferidasPorOtro.Size = New System.Drawing.Size(278, 139)
        Me.ListBoxNUEVAreferidasPorOtro.TabIndex = 48
        '
        'labNUEVAotroSeleccionada
        '
        Me.labNUEVAotroSeleccionada.BackColor = System.Drawing.SystemColors.Info
        Me.labNUEVAotroSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labNUEVAotroSeleccionada.Location = New System.Drawing.Point(6, 335)
        Me.labNUEVAotroSeleccionada.Name = "labNUEVAotroSeleccionada"
        Me.labNUEVAotroSeleccionada.Size = New System.Drawing.Size(278, 23)
        Me.labNUEVAotroSeleccionada.TabIndex = 5
        Me.labNUEVAotroSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Otro(a) Referidor Seleccionado(a)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Filtro:"
        '
        'labNUEVAListadoOtros
        '
        Me.labNUEVAListadoOtros.AutoSize = True
        Me.labNUEVAListadoOtros.Location = New System.Drawing.Point(3, 9)
        Me.labNUEVAListadoOtros.Name = "labNUEVAListadoOtros"
        Me.labNUEVAListadoOtros.Size = New System.Drawing.Size(159, 13)
        Me.labNUEVAListadoOtros.TabIndex = 2
        Me.labNUEVAListadoOtros.Text = "Listado de Otros Referidores: (0)"
        '
        'txtNUEVAotrosFiltro
        '
        Me.txtNUEVAotrosFiltro.Location = New System.Drawing.Point(234, 6)
        Me.txtNUEVAotrosFiltro.Name = "txtNUEVAotrosFiltro"
        Me.txtNUEVAotrosFiltro.Size = New System.Drawing.Size(50, 20)
        Me.txtNUEVAotrosFiltro.TabIndex = 1
        '
        'ListBoxNUEVAotros
        '
        Me.ListBoxNUEVAotros.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNUEVAotros.FormattingEnabled = True
        Me.ListBoxNUEVAotros.ItemHeight = 9
        Me.ListBoxNUEVAotros.Location = New System.Drawing.Point(6, 32)
        Me.ListBoxNUEVAotros.Name = "ListBoxNUEVAotros"
        Me.ListBoxNUEVAotros.Size = New System.Drawing.Size(278, 220)
        Me.ListBoxNUEVAotros.TabIndex = 0
        '
        'PanelNUEVAreferidaPorPaciente
        '
        Me.PanelNUEVAreferidaPorPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelNUEVAreferidaPorPaciente.Controls.Add(Me.Label4)
        Me.PanelNUEVAreferidaPorPaciente.Controls.Add(Me.ListBoxNUEVAreferidasPorPaciente)
        Me.PanelNUEVAreferidaPorPaciente.Controls.Add(Me.labNUEVApacienteSeleccionada)
        Me.PanelNUEVAreferidaPorPaciente.Controls.Add(Me.Label3)
        Me.PanelNUEVAreferidaPorPaciente.Controls.Add(Me.Label2)
        Me.PanelNUEVAreferidaPorPaciente.Controls.Add(Me.labNUEVAlistadoPacientes)
        Me.PanelNUEVAreferidaPorPaciente.Controls.Add(Me.txtNUEVApacientesFiltro)
        Me.PanelNUEVAreferidaPorPaciente.Controls.Add(Me.ListBoxNUEVApacientes)
        Me.PanelNUEVAreferidaPorPaciente.Enabled = False
        Me.PanelNUEVAreferidaPorPaciente.Location = New System.Drawing.Point(6, 69)
        Me.PanelNUEVAreferidaPorPaciente.Name = "PanelNUEVAreferidaPorPaciente"
        Me.PanelNUEVAreferidaPorPaciente.Size = New System.Drawing.Size(297, 522)
        Me.PanelNUEVAreferidaPorPaciente.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Otras Pacientes Referidas por esta Paciente"
        '
        'ListBoxNUEVAreferidasPorPaciente
        '
        Me.ListBoxNUEVAreferidasPorPaciente.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNUEVAreferidasPorPaciente.FormattingEnabled = True
        Me.ListBoxNUEVAreferidasPorPaciente.ItemHeight = 9
        Me.ListBoxNUEVAreferidasPorPaciente.Location = New System.Drawing.Point(6, 378)
        Me.ListBoxNUEVAreferidasPorPaciente.Name = "ListBoxNUEVAreferidasPorPaciente"
        Me.ListBoxNUEVAreferidasPorPaciente.Size = New System.Drawing.Size(278, 139)
        Me.ListBoxNUEVAreferidasPorPaciente.TabIndex = 48
        '
        'labNUEVApacienteSeleccionada
        '
        Me.labNUEVApacienteSeleccionada.BackColor = System.Drawing.SystemColors.Info
        Me.labNUEVApacienteSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labNUEVApacienteSeleccionada.Location = New System.Drawing.Point(6, 335)
        Me.labNUEVApacienteSeleccionada.Name = "labNUEVApacienteSeleccionada"
        Me.labNUEVApacienteSeleccionada.Size = New System.Drawing.Size(278, 23)
        Me.labNUEVApacienteSeleccionada.TabIndex = 5
        Me.labNUEVApacienteSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Paciente Seleccionada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Filtro:"
        '
        'labNUEVAlistadoPacientes
        '
        Me.labNUEVAlistadoPacientes.AutoSize = True
        Me.labNUEVAlistadoPacientes.Location = New System.Drawing.Point(3, 9)
        Me.labNUEVAlistadoPacientes.Name = "labNUEVAlistadoPacientes"
        Me.labNUEVAlistadoPacientes.Size = New System.Drawing.Size(124, 13)
        Me.labNUEVAlistadoPacientes.TabIndex = 2
        Me.labNUEVAlistadoPacientes.Text = "Listado de Pacientes: (0)"
        '
        'txtNUEVApacientesFiltro
        '
        Me.txtNUEVApacientesFiltro.Location = New System.Drawing.Point(214, 6)
        Me.txtNUEVApacientesFiltro.Name = "txtNUEVApacientesFiltro"
        Me.txtNUEVApacientesFiltro.Size = New System.Drawing.Size(50, 20)
        Me.txtNUEVApacientesFiltro.TabIndex = 1
        '
        'ListBoxNUEVApacientes
        '
        Me.ListBoxNUEVApacientes.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNUEVApacientes.FormattingEnabled = True
        Me.ListBoxNUEVApacientes.ItemHeight = 9
        Me.ListBoxNUEVApacientes.Location = New System.Drawing.Point(6, 32)
        Me.ListBoxNUEVApacientes.Name = "ListBoxNUEVApacientes"
        Me.ListBoxNUEVApacientes.Size = New System.Drawing.Size(278, 220)
        Me.ListBoxNUEVApacientes.TabIndex = 0
        '
        'radNUEVAreferidaPorOtro
        '
        Me.radNUEVAreferidaPorOtro.AutoSize = True
        Me.radNUEVAreferidaPorOtro.Location = New System.Drawing.Point(309, 42)
        Me.radNUEVAreferidaPorOtro.Name = "radNUEVAreferidaPorOtro"
        Me.radNUEVAreferidaPorOtro.Size = New System.Drawing.Size(118, 17)
        Me.radNUEVAreferidaPorOtro.TabIndex = 2
        Me.radNUEVAreferidaPorOtro.TabStop = True
        Me.radNUEVAreferidaPorOtro.Text = "Referida por Otro(a)"
        Me.radNUEVAreferidaPorOtro.UseVisualStyleBackColor = True
        '
        'radNUEVAreferidaPorPaciente
        '
        Me.radNUEVAreferidaPorPaciente.AutoSize = True
        Me.radNUEVAreferidaPorPaciente.Location = New System.Drawing.Point(6, 42)
        Me.radNUEVAreferidaPorPaciente.Name = "radNUEVAreferidaPorPaciente"
        Me.radNUEVAreferidaPorPaciente.Size = New System.Drawing.Size(149, 17)
        Me.radNUEVAreferidaPorPaciente.TabIndex = 1
        Me.radNUEVAreferidaPorPaciente.TabStop = True
        Me.radNUEVAreferidaPorPaciente.Text = "Referida por una Paciente"
        Me.radNUEVAreferidaPorPaciente.UseVisualStyleBackColor = True
        '
        'radNUEVAacudioSola
        '
        Me.radNUEVAacudioSola.AutoSize = True
        Me.radNUEVAacudioSola.Location = New System.Drawing.Point(6, 19)
        Me.radNUEVAacudioSola.Name = "radNUEVAacudioSola"
        Me.radNUEVAacudioSola.Size = New System.Drawing.Size(140, 17)
        Me.radNUEVAacudioSola.TabIndex = 0
        Me.radNUEVAacudioSola.TabStop = True
        Me.radNUEVAacudioSola.Text = "La Paciente Acudió sola"
        Me.radNUEVAacudioSola.UseVisualStyleBackColor = True
        '
        'GroupBoxACTUALIZAR
        '
        Me.GroupBoxACTUALIZAR.Controls.Add(Me.PanelACTUALIZAreferidaPorOtro)
        Me.GroupBoxACTUALIZAR.Controls.Add(Me.PanelACTUALIZAreferidaPorPaciente)
        Me.GroupBoxACTUALIZAR.Controls.Add(Me.radACTUALIZAreferidaPorOtro)
        Me.GroupBoxACTUALIZAR.Controls.Add(Me.radACTUALIZAreferidaPorPaciente)
        Me.GroupBoxACTUALIZAR.Controls.Add(Me.radACTUALIZAacudioSola)
        Me.GroupBoxACTUALIZAR.Location = New System.Drawing.Point(994, 12)
        Me.GroupBoxACTUALIZAR.Name = "GroupBoxACTUALIZAR"
        Me.GroupBoxACTUALIZAR.Size = New System.Drawing.Size(937, 597)
        Me.GroupBoxACTUALIZAR.TabIndex = 3
        Me.GroupBoxACTUALIZAR.TabStop = False
        Me.GroupBoxACTUALIZAR.Text = "Actualizar Referencia"
        '
        'PanelACTUALIZAreferidaPorOtro
        '
        Me.PanelACTUALIZAreferidaPorOtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelACTUALIZAreferidaPorOtro.Controls.Add(Me.botACTUALIZAeditaReferidor)
        Me.PanelACTUALIZAreferidaPorOtro.Controls.Add(Me.botACTUALIZAnuevoReferidor)
        Me.PanelACTUALIZAreferidaPorOtro.Controls.Add(Me.Label6)
        Me.PanelACTUALIZAreferidaPorOtro.Controls.Add(Me.ListBoxACTUALIZAreferidasPorOtro)
        Me.PanelACTUALIZAreferidaPorOtro.Controls.Add(Me.labACTUALIZAotroSeleccionada)
        Me.PanelACTUALIZAreferidaPorOtro.Controls.Add(Me.Label12)
        Me.PanelACTUALIZAreferidaPorOtro.Controls.Add(Me.Label13)
        Me.PanelACTUALIZAreferidaPorOtro.Controls.Add(Me.labACTUALIZAListadoOtros)
        Me.PanelACTUALIZAreferidaPorOtro.Controls.Add(Me.txtACTUALIZAotrosFiltro)
        Me.PanelACTUALIZAreferidaPorOtro.Controls.Add(Me.ListBoxACTUALIZAotros)
        Me.PanelACTUALIZAreferidaPorOtro.Enabled = False
        Me.PanelACTUALIZAreferidaPorOtro.Location = New System.Drawing.Point(309, 69)
        Me.PanelACTUALIZAreferidaPorOtro.Name = "PanelACTUALIZAreferidaPorOtro"
        Me.PanelACTUALIZAreferidaPorOtro.Size = New System.Drawing.Size(299, 522)
        Me.PanelACTUALIZAreferidaPorOtro.TabIndex = 5
        '
        'botACTUALIZAnuevoReferidor
        '
        Me.botACTUALIZAnuevoReferidor.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botACTUALIZAnuevoReferidor.Location = New System.Drawing.Point(40, 258)
        Me.botACTUALIZAnuevoReferidor.Name = "botACTUALIZAnuevoReferidor"
        Me.botACTUALIZAnuevoReferidor.Size = New System.Drawing.Size(224, 23)
        Me.botACTUALIZAnuevoReferidor.TabIndex = 50
        Me.botACTUALIZAnuevoReferidor.Text = "Incluye Nuevo Referidor"
        Me.botACTUALIZAnuevoReferidor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Otras Pacientes Referidas por este Referidor"
        '
        'ListBoxACTUALIZAreferidasPorOtro
        '
        Me.ListBoxACTUALIZAreferidasPorOtro.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxACTUALIZAreferidasPorOtro.FormattingEnabled = True
        Me.ListBoxACTUALIZAreferidasPorOtro.ItemHeight = 9
        Me.ListBoxACTUALIZAreferidasPorOtro.Location = New System.Drawing.Point(6, 378)
        Me.ListBoxACTUALIZAreferidasPorOtro.Name = "ListBoxACTUALIZAreferidasPorOtro"
        Me.ListBoxACTUALIZAreferidasPorOtro.Size = New System.Drawing.Size(278, 139)
        Me.ListBoxACTUALIZAreferidasPorOtro.TabIndex = 48
        '
        'labACTUALIZAotroSeleccionada
        '
        Me.labACTUALIZAotroSeleccionada.BackColor = System.Drawing.SystemColors.Info
        Me.labACTUALIZAotroSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labACTUALIZAotroSeleccionada.Location = New System.Drawing.Point(6, 335)
        Me.labACTUALIZAotroSeleccionada.Name = "labACTUALIZAotroSeleccionada"
        Me.labACTUALIZAotroSeleccionada.Size = New System.Drawing.Size(278, 23)
        Me.labACTUALIZAotroSeleccionada.TabIndex = 5
        Me.labACTUALIZAotroSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Otro(a) Referidor Seleccionado(a)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(196, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Filtro:"
        '
        'labACTUALIZAListadoOtros
        '
        Me.labACTUALIZAListadoOtros.AutoSize = True
        Me.labACTUALIZAListadoOtros.Location = New System.Drawing.Point(3, 9)
        Me.labACTUALIZAListadoOtros.Name = "labACTUALIZAListadoOtros"
        Me.labACTUALIZAListadoOtros.Size = New System.Drawing.Size(159, 13)
        Me.labACTUALIZAListadoOtros.TabIndex = 2
        Me.labACTUALIZAListadoOtros.Text = "Listado de Otros Referidores: (0)"
        '
        'txtACTUALIZAotrosFiltro
        '
        Me.txtACTUALIZAotrosFiltro.Location = New System.Drawing.Point(234, 6)
        Me.txtACTUALIZAotrosFiltro.Name = "txtACTUALIZAotrosFiltro"
        Me.txtACTUALIZAotrosFiltro.Size = New System.Drawing.Size(50, 20)
        Me.txtACTUALIZAotrosFiltro.TabIndex = 1
        '
        'ListBoxACTUALIZAotros
        '
        Me.ListBoxACTUALIZAotros.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxACTUALIZAotros.FormattingEnabled = True
        Me.ListBoxACTUALIZAotros.ItemHeight = 9
        Me.ListBoxACTUALIZAotros.Location = New System.Drawing.Point(6, 32)
        Me.ListBoxACTUALIZAotros.Name = "ListBoxACTUALIZAotros"
        Me.ListBoxACTUALIZAotros.Size = New System.Drawing.Size(278, 220)
        Me.ListBoxACTUALIZAotros.TabIndex = 0
        '
        'PanelACTUALIZAreferidaPorPaciente
        '
        Me.PanelACTUALIZAreferidaPorPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelACTUALIZAreferidaPorPaciente.Controls.Add(Me.Label1)
        Me.PanelACTUALIZAreferidaPorPaciente.Controls.Add(Me.ListBoxACTUALIZAreferidasPorPaciente)
        Me.PanelACTUALIZAreferidaPorPaciente.Controls.Add(Me.labACTUALIZApacienteSeleccionada)
        Me.PanelACTUALIZAreferidaPorPaciente.Controls.Add(Me.Label9)
        Me.PanelACTUALIZAreferidaPorPaciente.Controls.Add(Me.Label10)
        Me.PanelACTUALIZAreferidaPorPaciente.Controls.Add(Me.labACTUALIZAlistadoPacientes)
        Me.PanelACTUALIZAreferidaPorPaciente.Controls.Add(Me.txtACTUALIZApacientesFiltro)
        Me.PanelACTUALIZAreferidaPorPaciente.Controls.Add(Me.ListBoxACTUALIZApacientes)
        Me.PanelACTUALIZAreferidaPorPaciente.Enabled = False
        Me.PanelACTUALIZAreferidaPorPaciente.Location = New System.Drawing.Point(6, 69)
        Me.PanelACTUALIZAreferidaPorPaciente.Name = "PanelACTUALIZAreferidaPorPaciente"
        Me.PanelACTUALIZAreferidaPorPaciente.Size = New System.Drawing.Size(297, 522)
        Me.PanelACTUALIZAreferidaPorPaciente.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Otras Pacientes Referidas por esta Paciente"
        '
        'ListBoxACTUALIZAreferidasPorPaciente
        '
        Me.ListBoxACTUALIZAreferidasPorPaciente.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxACTUALIZAreferidasPorPaciente.FormattingEnabled = True
        Me.ListBoxACTUALIZAreferidasPorPaciente.ItemHeight = 9
        Me.ListBoxACTUALIZAreferidasPorPaciente.Location = New System.Drawing.Point(6, 378)
        Me.ListBoxACTUALIZAreferidasPorPaciente.Name = "ListBoxACTUALIZAreferidasPorPaciente"
        Me.ListBoxACTUALIZAreferidasPorPaciente.Size = New System.Drawing.Size(278, 139)
        Me.ListBoxACTUALIZAreferidasPorPaciente.TabIndex = 48
        '
        'labACTUALIZApacienteSeleccionada
        '
        Me.labACTUALIZApacienteSeleccionada.BackColor = System.Drawing.SystemColors.Info
        Me.labACTUALIZApacienteSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labACTUALIZApacienteSeleccionada.Location = New System.Drawing.Point(6, 335)
        Me.labACTUALIZApacienteSeleccionada.Name = "labACTUALIZApacienteSeleccionada"
        Me.labACTUALIZApacienteSeleccionada.Size = New System.Drawing.Size(278, 23)
        Me.labACTUALIZApacienteSeleccionada.TabIndex = 5
        Me.labACTUALIZApacienteSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 318)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Paciente Seleccionada"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(176, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Filtro:"
        '
        'labACTUALIZAlistadoPacientes
        '
        Me.labACTUALIZAlistadoPacientes.AutoSize = True
        Me.labACTUALIZAlistadoPacientes.Location = New System.Drawing.Point(3, 9)
        Me.labACTUALIZAlistadoPacientes.Name = "labACTUALIZAlistadoPacientes"
        Me.labACTUALIZAlistadoPacientes.Size = New System.Drawing.Size(124, 13)
        Me.labACTUALIZAlistadoPacientes.TabIndex = 2
        Me.labACTUALIZAlistadoPacientes.Text = "Listado de Pacientes: (0)"
        '
        'txtACTUALIZApacientesFiltro
        '
        Me.txtACTUALIZApacientesFiltro.Location = New System.Drawing.Point(214, 6)
        Me.txtACTUALIZApacientesFiltro.Name = "txtACTUALIZApacientesFiltro"
        Me.txtACTUALIZApacientesFiltro.Size = New System.Drawing.Size(50, 20)
        Me.txtACTUALIZApacientesFiltro.TabIndex = 1
        '
        'ListBoxACTUALIZApacientes
        '
        Me.ListBoxACTUALIZApacientes.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxACTUALIZApacientes.FormattingEnabled = True
        Me.ListBoxACTUALIZApacientes.ItemHeight = 9
        Me.ListBoxACTUALIZApacientes.Location = New System.Drawing.Point(6, 32)
        Me.ListBoxACTUALIZApacientes.Name = "ListBoxACTUALIZApacientes"
        Me.ListBoxACTUALIZApacientes.Size = New System.Drawing.Size(278, 220)
        Me.ListBoxACTUALIZApacientes.TabIndex = 0
        '
        'radACTUALIZAreferidaPorOtro
        '
        Me.radACTUALIZAreferidaPorOtro.AutoSize = True
        Me.radACTUALIZAreferidaPorOtro.Location = New System.Drawing.Point(309, 42)
        Me.radACTUALIZAreferidaPorOtro.Name = "radACTUALIZAreferidaPorOtro"
        Me.radACTUALIZAreferidaPorOtro.Size = New System.Drawing.Size(118, 17)
        Me.radACTUALIZAreferidaPorOtro.TabIndex = 2
        Me.radACTUALIZAreferidaPorOtro.TabStop = True
        Me.radACTUALIZAreferidaPorOtro.Text = "Referida por Otro(a)"
        Me.radACTUALIZAreferidaPorOtro.UseVisualStyleBackColor = True
        '
        'radACTUALIZAreferidaPorPaciente
        '
        Me.radACTUALIZAreferidaPorPaciente.AutoSize = True
        Me.radACTUALIZAreferidaPorPaciente.Location = New System.Drawing.Point(6, 42)
        Me.radACTUALIZAreferidaPorPaciente.Name = "radACTUALIZAreferidaPorPaciente"
        Me.radACTUALIZAreferidaPorPaciente.Size = New System.Drawing.Size(149, 17)
        Me.radACTUALIZAreferidaPorPaciente.TabIndex = 1
        Me.radACTUALIZAreferidaPorPaciente.TabStop = True
        Me.radACTUALIZAreferidaPorPaciente.Text = "Referida por una Paciente"
        Me.radACTUALIZAreferidaPorPaciente.UseVisualStyleBackColor = True
        '
        'radACTUALIZAacudioSola
        '
        Me.radACTUALIZAacudioSola.AutoSize = True
        Me.radACTUALIZAacudioSola.Location = New System.Drawing.Point(6, 19)
        Me.radACTUALIZAacudioSola.Name = "radACTUALIZAacudioSola"
        Me.radACTUALIZAacudioSola.Size = New System.Drawing.Size(140, 17)
        Me.radACTUALIZAacudioSola.TabIndex = 0
        Me.radACTUALIZAacudioSola.TabStop = True
        Me.radACTUALIZAacudioSola.Text = "La Paciente Acudió sola"
        Me.radACTUALIZAacudioSola.UseVisualStyleBackColor = True
        '
        'botAceptar
        '
        Me.botAceptar.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botAceptar.Enabled = False
        Me.botAceptar.Location = New System.Drawing.Point(725, 622)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(224, 23)
        Me.botAceptar.TabIndex = 4
        Me.botAceptar.Text = "Aceptar"
        Me.botAceptar.UseVisualStyleBackColor = True
        '
        'botNUEVAeditaReferidor
        '
        Me.botNUEVAeditaReferidor.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botNUEVAeditaReferidor.Enabled = False
        Me.botNUEVAeditaReferidor.Location = New System.Drawing.Point(41, 287)
        Me.botNUEVAeditaReferidor.Name = "botNUEVAeditaReferidor"
        Me.botNUEVAeditaReferidor.Size = New System.Drawing.Size(224, 23)
        Me.botNUEVAeditaReferidor.TabIndex = 51
        Me.botNUEVAeditaReferidor.Text = "Editar Referidor Seleccionado"
        Me.botNUEVAeditaReferidor.UseVisualStyleBackColor = True
        '
        'botACTUALIZAeditaReferidor
        '
        Me.botACTUALIZAeditaReferidor.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botACTUALIZAeditaReferidor.Enabled = False
        Me.botACTUALIZAeditaReferidor.Location = New System.Drawing.Point(40, 287)
        Me.botACTUALIZAeditaReferidor.Name = "botACTUALIZAeditaReferidor"
        Me.botACTUALIZAeditaReferidor.Size = New System.Drawing.Size(224, 23)
        Me.botACTUALIZAeditaReferidor.TabIndex = 52
        Me.botACTUALIZAeditaReferidor.Text = "Editar Referidor Seleccionado"
        Me.botACTUALIZAeditaReferidor.UseVisualStyleBackColor = True
        '
        'FormReferencias
        '
        Me.AcceptButton = Me.botAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(984, 696)
        Me.ControlBox = False
        Me.Controls.Add(Me.botAceptar)
        Me.Controls.Add(Me.GroupBoxACTUALIZAR)
        Me.Controls.Add(Me.GroupBoxNUEVA)
        Me.Controls.Add(Me.botSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormReferencias"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Referencias"
        Me.GroupBoxNUEVA.ResumeLayout(False)
        Me.GroupBoxNUEVA.PerformLayout()
        Me.PanelNUEVAreferidaPorOtro.ResumeLayout(False)
        Me.PanelNUEVAreferidaPorOtro.PerformLayout()
        Me.PanelNUEVAreferidaPorPaciente.ResumeLayout(False)
        Me.PanelNUEVAreferidaPorPaciente.PerformLayout()
        Me.GroupBoxACTUALIZAR.ResumeLayout(False)
        Me.GroupBoxACTUALIZAR.PerformLayout()
        Me.PanelACTUALIZAreferidaPorOtro.ResumeLayout(False)
        Me.PanelACTUALIZAreferidaPorOtro.PerformLayout()
        Me.PanelACTUALIZAreferidaPorPaciente.ResumeLayout(False)
        Me.PanelACTUALIZAreferidaPorPaciente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents botSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBoxNUEVA As System.Windows.Forms.GroupBox
    Friend WithEvents radNUEVAacudioSola As System.Windows.Forms.RadioButton
    Friend WithEvents radNUEVAreferidaPorOtro As System.Windows.Forms.RadioButton
    Friend WithEvents radNUEVAreferidaPorPaciente As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxACTUALIZAR As System.Windows.Forms.GroupBox
    Friend WithEvents radACTUALIZAreferidaPorOtro As System.Windows.Forms.RadioButton
    Friend WithEvents radACTUALIZAreferidaPorPaciente As System.Windows.Forms.RadioButton
    Friend WithEvents radACTUALIZAacudioSola As System.Windows.Forms.RadioButton
    Friend WithEvents PanelNUEVAreferidaPorPaciente As System.Windows.Forms.Panel
    Friend WithEvents labNUEVApacienteSeleccionada As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents labNUEVAlistadoPacientes As System.Windows.Forms.Label
    Friend WithEvents txtNUEVApacientesFiltro As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxNUEVApacientes As System.Windows.Forms.ListBox
    Friend WithEvents PanelNUEVAreferidaPorOtro As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBoxNUEVAreferidasPorOtro As System.Windows.Forms.ListBox
    Friend WithEvents labNUEVAotroSeleccionada As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents labNUEVAListadoOtros As System.Windows.Forms.Label
    Friend WithEvents txtNUEVAotrosFiltro As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxNUEVAotros As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBoxNUEVAreferidasPorPaciente As System.Windows.Forms.ListBox
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents botNUEVAnuevoReferidor As System.Windows.Forms.Button
    Friend WithEvents PanelACTUALIZAreferidaPorOtro As System.Windows.Forms.Panel
    Friend WithEvents botACTUALIZAnuevoReferidor As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBoxACTUALIZAreferidasPorOtro As System.Windows.Forms.ListBox
    Friend WithEvents labACTUALIZAotroSeleccionada As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents labACTUALIZAListadoOtros As System.Windows.Forms.Label
    Friend WithEvents txtACTUALIZAotrosFiltro As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxACTUALIZAotros As System.Windows.Forms.ListBox
    Friend WithEvents PanelACTUALIZAreferidaPorPaciente As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBoxACTUALIZAreferidasPorPaciente As System.Windows.Forms.ListBox
    Friend WithEvents labACTUALIZApacienteSeleccionada As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents labACTUALIZAlistadoPacientes As System.Windows.Forms.Label
    Friend WithEvents txtACTUALIZApacientesFiltro As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxACTUALIZApacientes As System.Windows.Forms.ListBox
    Friend WithEvents botNUEVAeditaReferidor As System.Windows.Forms.Button
    Friend WithEvents botACTUALIZAeditaReferidor As System.Windows.Forms.Button
End Class
