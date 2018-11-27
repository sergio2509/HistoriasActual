Imports System.IO


Public Class FormIntervenciones
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
    Friend WithEvents botSalir As System.Windows.Forms.Button
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents labIQdelaFecha As System.Windows.Forms.Label
    Friend WithEvents ListBoxIntervenciones As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoIntervencion As System.Windows.Forms.TextBox
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents txtMedico1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRolMedico1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMedico2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRolMedico2 As System.Windows.Forms.TextBox
    Friend WithEvents txtLugar As System.Windows.Forms.TextBox
    Friend WithEvents RadPendiente As System.Windows.Forms.RadioButton
    Friend WithEvents radCancelado As System.Windows.Forms.RadioButton
    Friend WithEvents txtHonorariosEstimados As System.Windows.Forms.TextBox
    Friend WithEvents txtHonorariosPagados As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNotas As System.Windows.Forms.TextBox
    Friend WithEvents txtFormaDePago As System.Windows.Forms.TextBox
    Friend WithEvents labMensaje As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents botProceder As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFechaDeNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents botReparar As System.Windows.Forms.Button
    Friend WithEvents botRechazarReparacion As System.Windows.Forms.Button
    Friend WithEvents botAceptarReparacion As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents botEntraEnReparar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents botElimina As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIntervenciones))
        Me.botSalir = New System.Windows.Forms.Button
        Me.botAceptar = New System.Windows.Forms.Button
        Me.Calendario = New System.Windows.Forms.MonthCalendar
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListBoxIntervenciones = New System.Windows.Forms.ListBox
        Me.labIQdelaFecha = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtFechaDeNacimiento = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNotas = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtHonorariosPagados = New System.Windows.Forms.TextBox
        Me.txtHonorariosEstimados = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.radCancelado = New System.Windows.Forms.RadioButton
        Me.RadPendiente = New System.Windows.Forms.RadioButton
        Me.txtFormaDePago = New System.Windows.Forms.TextBox
        Me.txtLugar = New System.Windows.Forms.TextBox
        Me.txtRolMedico2 = New System.Windows.Forms.TextBox
        Me.txtMedico2 = New System.Windows.Forms.TextBox
        Me.txtRolMedico1 = New System.Windows.Forms.TextBox
        Me.txtMedico1 = New System.Windows.Forms.TextBox
        Me.txtRol = New System.Windows.Forms.TextBox
        Me.txtTipoIntervencion = New System.Windows.Forms.TextBox
        Me.txtEdad = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.labMensaje = New System.Windows.Forms.Label
        Me.botElimina = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.botRechazarReparacion = New System.Windows.Forms.Button
        Me.botAceptarReparacion = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.botProceder = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.botReparar = New System.Windows.Forms.Button
        Me.botCancelar = New System.Windows.Forms.Button
        Me.botEntraEnReparar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'botSalir
        '
        Me.botSalir.BackColor = System.Drawing.SystemColors.Control
        Me.botSalir.BackgroundImage = CType(resources.GetObject("botSalir.BackgroundImage"), System.Drawing.Image)
        Me.botSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSalir.ForeColor = System.Drawing.Color.Black
        Me.botSalir.Location = New System.Drawing.Point(12, 637)
        Me.botSalir.Name = "botSalir"
        Me.botSalir.Size = New System.Drawing.Size(224, 23)
        Me.botSalir.TabIndex = 25
        Me.botSalir.Text = "Salir"
        Me.botSalir.UseVisualStyleBackColor = False
        '
        'botAceptar
        '
        Me.botAceptar.BackgroundImage = CType(resources.GetObject("botAceptar.BackgroundImage"), System.Drawing.Image)
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.ForeColor = System.Drawing.Color.Black
        Me.botAceptar.Location = New System.Drawing.Point(758, 637)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(224, 23)
        Me.botAceptar.TabIndex = 24
        Me.botAceptar.Text = "Guardar Cambios"
        '
        'Calendario
        '
        Me.Calendario.Location = New System.Drawing.Point(12, 33)
        Me.Calendario.MaxSelectionCount = 1
        Me.Calendario.Name = "Calendario"
        Me.Calendario.ShowToday = False
        Me.Calendario.ShowTodayCircle = False
        Me.Calendario.TabIndex = 26
        Me.Calendario.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Fecha de la Intervención"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBoxIntervenciones
        '
        Me.ListBoxIntervenciones.Location = New System.Drawing.Point(251, 33)
        Me.ListBoxIntervenciones.Name = "ListBoxIntervenciones"
        Me.ListBoxIntervenciones.Size = New System.Drawing.Size(528, 95)
        Me.ListBoxIntervenciones.TabIndex = 28
        '
        'labIQdelaFecha
        '
        Me.labIQdelaFecha.Location = New System.Drawing.Point(251, 9)
        Me.labIQdelaFecha.Name = "labIQdelaFecha"
        Me.labIQdelaFecha.Size = New System.Drawing.Size(530, 23)
        Me.labIQdelaFecha.TabIndex = 29
        Me.labIQdelaFecha.Text = "Intervenciones del día"
        Me.labIQdelaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtFechaDeNacimiento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNotas)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtHonorariosPagados)
        Me.GroupBox1.Controls.Add(Me.txtHonorariosEstimados)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.radCancelado)
        Me.GroupBox1.Controls.Add(Me.RadPendiente)
        Me.GroupBox1.Controls.Add(Me.txtFormaDePago)
        Me.GroupBox1.Controls.Add(Me.txtLugar)
        Me.GroupBox1.Controls.Add(Me.txtRolMedico2)
        Me.GroupBox1.Controls.Add(Me.txtMedico2)
        Me.GroupBox1.Controls.Add(Me.txtRolMedico1)
        Me.GroupBox1.Controls.Add(Me.txtMedico1)
        Me.GroupBox1.Controls.Add(Me.txtRol)
        Me.GroupBox1.Controls.Add(Me.txtTipoIntervencion)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(957, 314)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(157, 269)
        Me.txtCedula.MaxLength = 15
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(120, 20)
        Me.txtCedula.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(102, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Cédula :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaDeNacimiento
        '
        Me.txtFechaDeNacimiento.Location = New System.Drawing.Point(157, 243)
        Me.txtFechaDeNacimiento.MaxLength = 15
        Me.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento"
        Me.txtFechaDeNacimiento.Size = New System.Drawing.Size(120, 20)
        Me.txtFechaDeNacimiento.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Fecha de Nacimiento:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(157, 197)
        Me.txtNotas.MaxLength = 1000
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotas.Size = New System.Drawing.Size(655, 40)
        Me.txtNotas.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(25, 200)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Notas y Observaciones :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHonorariosPagados
        '
        Me.txtHonorariosPagados.Location = New System.Drawing.Point(403, 172)
        Me.txtHonorariosPagados.MaxLength = 15
        Me.txtHonorariosPagados.Name = "txtHonorariosPagados"
        Me.txtHonorariosPagados.Size = New System.Drawing.Size(99, 20)
        Me.txtHonorariosPagados.TabIndex = 28
        Me.txtHonorariosPagados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHonorariosEstimados
        '
        Me.txtHonorariosEstimados.Location = New System.Drawing.Point(403, 146)
        Me.txtHonorariosEstimados.MaxLength = 15
        Me.txtHonorariosEstimados.Name = "txtHonorariosEstimados"
        Me.txtHonorariosEstimados.Size = New System.Drawing.Size(99, 20)
        Me.txtHonorariosEstimados.TabIndex = 27
        Me.txtHonorariosEstimados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(260, 175)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(137, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Honorarios netos pagados :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(280, 149)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Honorarios  estimados :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'radCancelado
        '
        Me.radCancelado.AutoSize = True
        Me.radCancelado.Location = New System.Drawing.Point(157, 173)
        Me.radCancelado.Name = "radCancelado"
        Me.radCancelado.Size = New System.Drawing.Size(81, 17)
        Me.radCancelado.TabIndex = 24
        Me.radCancelado.Text = "Cancelados"
        '
        'RadPendiente
        '
        Me.RadPendiente.AutoSize = True
        Me.RadPendiente.Location = New System.Drawing.Point(157, 147)
        Me.RadPendiente.Name = "RadPendiente"
        Me.RadPendiente.Size = New System.Drawing.Size(78, 17)
        Me.RadPendiente.TabIndex = 23
        Me.RadPendiente.Text = "Pendientes"
        '
        'txtFormaDePago
        '
        Me.txtFormaDePago.AutoCompleteCustomSource.AddRange(New String() {"Efectivo", "Seguros"})
        Me.txtFormaDePago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtFormaDePago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFormaDePago.Location = New System.Drawing.Point(655, 120)
        Me.txtFormaDePago.MaxLength = 60
        Me.txtFormaDePago.Name = "txtFormaDePago"
        Me.txtFormaDePago.Size = New System.Drawing.Size(228, 20)
        Me.txtFormaDePago.TabIndex = 21
        '
        'txtLugar
        '
        Me.txtLugar.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Clínica Santa Mónica", "IEQ Los Mangos", "Centro Clínico San Rafael", "Centro Quirúrgico Cardiovascular", "Fundación Clínica La Nacional", "CENAG", "Centro Médico Sinaí", "Centro Médico San Francisco de Asís", "Clínica Dr. Amauri Rengel", "Maternidad  y Centro Pedíatrico Santa María", "Centro Clínico La Milagrosa", "Células Madre de Venezuela"})
        Me.txtLugar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtLugar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLugar.Location = New System.Drawing.Point(154, 120)
        Me.txtLugar.MaxLength = 45
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(348, 20)
        Me.txtLugar.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.txtLugar, resources.GetString("txtLugar.ToolTip"))
        '
        'txtRolMedico2
        '
        Me.txtRolMedico2.AutoCompleteCustomSource.AddRange(New String() {"Cirujano", "1er Ayudante", "2do Ayudante"})
        Me.txtRolMedico2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRolMedico2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRolMedico2.Location = New System.Drawing.Point(655, 94)
        Me.txtRolMedico2.MaxLength = 15
        Me.txtRolMedico2.Name = "txtRolMedico2"
        Me.txtRolMedico2.Size = New System.Drawing.Size(120, 20)
        Me.txtRolMedico2.TabIndex = 19
        '
        'txtMedico2
        '
        Me.txtMedico2.AutoCompleteCustomSource.AddRange(New String() {"Dra. Gabriela Di Carlo", "Dra. Alicia de González", "Dra. Rosa de Rivero", "Dr. Antonio Scaramella", "Dr. Jesús Scaramella", "Dr. Nestor Sánchez", "Dr. Jesús Sánchez", "Dr. Hadnan Ezzi", "Dr. César Escalante", "Dr. Carlos González Cintra", "Dr. Jesús Silva", "Dra. Auriedy Silva", "Dra. Carolina Palacios", "Dra. Angela Martínez", "Dra. Yelitza Bonalde", "Dr. Ricardo Delgado", "Dra. Miriam Lara", "Dra. Carmen Ríos", "Dr. Jorge Carrillo", "Dr. Jorge Aldana", "Dr. William Sutil", "Dr. José Luis Peralta", "Dra. María Helena Hurtado"})
        Me.txtMedico2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtMedico2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMedico2.Location = New System.Drawing.Point(154, 94)
        Me.txtMedico2.MaxLength = 60
        Me.txtMedico2.Name = "txtMedico2"
        Me.txtMedico2.Size = New System.Drawing.Size(348, 20)
        Me.txtMedico2.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.txtMedico2, resources.GetString("txtMedico2.ToolTip"))
        '
        'txtRolMedico1
        '
        Me.txtRolMedico1.AutoCompleteCustomSource.AddRange(New String() {"Cirujano", "1er Ayudante", "2do Ayudante"})
        Me.txtRolMedico1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRolMedico1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRolMedico1.Location = New System.Drawing.Point(655, 68)
        Me.txtRolMedico1.MaxLength = 15
        Me.txtRolMedico1.Name = "txtRolMedico1"
        Me.txtRolMedico1.Size = New System.Drawing.Size(120, 20)
        Me.txtRolMedico1.TabIndex = 17
        '
        'txtMedico1
        '
        Me.txtMedico1.AutoCompleteCustomSource.AddRange(New String() {"Dra. Gabriela Di Carlo", "Dra. Alicia de González", "Dra. Rosa de Rivero", "Dr. Antonio Scaramella", "Dr. Jesús Scaramella", "Dr. Nestor Sánchez", "Dr. Jesús Sánchez", "Dr. Hadnan Ezzi", "Dr. César Escalante", "Dr. Carlos González Cintra", "Dr. Jesús Silva", "Dra. Auriedy Silva", "Dra. Carolina Palacios", "Dra. Angela Martínez", "Dra. Yelitza Bonalde", "Dr. Ricardo Delgado", "Dra. Miriam Lara", "Dra. Carmen Ríos", "Dr. Jorge Carrillo", "Dr. Jorge Aldana", "Dr. William Sutil", "Dr. José Luis Peralta", "Dra. María Helena Hurtado"})
        Me.txtMedico1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtMedico1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMedico1.Location = New System.Drawing.Point(154, 68)
        Me.txtMedico1.MaxLength = 60
        Me.txtMedico1.Name = "txtMedico1"
        Me.txtMedico1.Size = New System.Drawing.Size(348, 20)
        Me.txtMedico1.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.txtMedico1, resources.GetString("txtMedico1.ToolTip"))
        '
        'txtRol
        '
        Me.txtRol.AutoCompleteCustomSource.AddRange(New String() {"Cirujano", "1er Ayudante", "2do Ayudante"})
        Me.txtRol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRol.Location = New System.Drawing.Point(655, 42)
        Me.txtRol.MaxLength = 15
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(120, 20)
        Me.txtRol.TabIndex = 15
        '
        'txtTipoIntervencion
        '
        Me.txtTipoIntervencion.AutoCompleteCustomSource.AddRange(New String() {"Cesárea Segmentaria", "Cesárea Segmentaria y EQ", "Parto Normal", "Histerectomía Abdominal Total", "Histerectomía Abdominal Sub Total", "Histerectomía Vaginal", "Cura de Prolapso", "Laparotomía Exploradora x", "Esterilización Quirúrgica", "Miomectomía", "Legrado Uterino"})
        Me.txtTipoIntervencion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtTipoIntervencion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTipoIntervencion.Location = New System.Drawing.Point(154, 42)
        Me.txtTipoIntervencion.MaxLength = 60
        Me.txtTipoIntervencion.Name = "txtTipoIntervencion"
        Me.txtTipoIntervencion.Size = New System.Drawing.Size(348, 20)
        Me.txtTipoIntervencion.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtTipoIntervencion, resources.GetString("txtTipoIntervencion.ToolTip"))
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(655, 16)
        Me.txtEdad.MaxLength = 2
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(32, 20)
        Me.txtEdad.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(154, 16)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(348, 20)
        Me.txtNombre.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(84, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Honorarios :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(564, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Forma de Pago :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(518, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Rol del Acompañante #2 :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Intervención realizada en :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(518, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Rol del Acompañante #1 :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Acompañante #2 :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Acompañante #1 :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(508, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Rol durante la Intervención :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo de Intervención :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Edad  a la fecha de la IQ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre de la Paciente :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labMensaje
        '
        Me.labMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMensaje.Location = New System.Drawing.Point(251, 129)
        Me.labMensaje.Name = "labMensaje"
        Me.labMensaje.Size = New System.Drawing.Size(530, 23)
        Me.labMensaje.TabIndex = 31
        Me.labMensaje.Text = "Selecciona la fecha y un registro existente para Modificarlo o Añade un Registro " & _
            "nuevo..."
        Me.labMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botElimina
        '
        Me.botElimina.BackgroundImage = CType(resources.GetObject("botElimina.BackgroundImage"), System.Drawing.Image)
        Me.botElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botElimina.ForeColor = System.Drawing.Color.Black
        Me.botElimina.Location = New System.Drawing.Point(380, 161)
        Me.botElimina.Name = "botElimina"
        Me.botElimina.Size = New System.Drawing.Size(224, 23)
        Me.botElimina.TabIndex = 32
        Me.botElimina.Text = "Elimina Intervención"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.ListBox3)
        Me.GroupBox2.Controls.Add(Me.botRechazarReparacion)
        Me.GroupBox2.Controls.Add(Me.botAceptarReparacion)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.ListBox2)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.txtYear)
        Me.GroupBox2.Controls.Add(Me.botProceder)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(957, 512)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Repara Archivo de Año de Intervenciones"
        Me.GroupBox2.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(601, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(214, 13)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Todas las Intervenciones del Año Originales"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(604, 99)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(310, 342)
        Me.ListBox3.TabIndex = 11
        '
        'botRechazarReparacion
        '
        Me.botRechazarReparacion.Enabled = False
        Me.botRechazarReparacion.Location = New System.Drawing.Point(604, 447)
        Me.botRechazarReparacion.Name = "botRechazarReparacion"
        Me.botRechazarReparacion.Size = New System.Drawing.Size(136, 23)
        Me.botRechazarReparacion.TabIndex = 10
        Me.botRechazarReparacion.Text = "Rechazar Reparación"
        Me.botRechazarReparacion.UseVisualStyleBackColor = True
        '
        'botAceptarReparacion
        '
        Me.botAceptarReparacion.Enabled = False
        Me.botAceptarReparacion.Location = New System.Drawing.Point(778, 447)
        Me.botAceptarReparacion.Name = "botAceptarReparacion"
        Me.botAceptarReparacion.Size = New System.Drawing.Size(136, 23)
        Me.botAceptarReparacion.TabIndex = 9
        Me.botAceptarReparacion.Text = "Aceptar Reparación"
        Me.botAceptarReparacion.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(306, 83)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(220, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Todas las Intervenciones del Año Reparadas"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(145, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Intervenciones Según Meses"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(124, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(135, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Introduce el Año a arreglar:"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(309, 99)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(289, 342)
        Me.ListBox2.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(20, 99)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(283, 342)
        Me.ListBox1.TabIndex = 4
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(265, 29)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 1
        '
        'botProceder
        '
        Me.botProceder.Location = New System.Drawing.Point(388, 27)
        Me.botProceder.Name = "botProceder"
        Me.botProceder.Size = New System.Drawing.Size(75, 23)
        Me.botProceder.TabIndex = 0
        Me.botProceder.Text = "Proceder"
        Me.botProceder.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(264, 549)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(249, 111)
        Me.TabControl1.TabIndex = 34
        Me.TabControl1.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.botReparar)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(241, 85)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'botReparar
        '
        Me.botReparar.Location = New System.Drawing.Point(16, 17)
        Me.botReparar.Name = "botReparar"
        Me.botReparar.Size = New System.Drawing.Size(176, 23)
        Me.botReparar.TabIndex = 34
        Me.botReparar.Text = "Reparar"
        Me.botReparar.UseVisualStyleBackColor = True
        '
        'botCancelar
        '
        Me.botCancelar.BackgroundImage = CType(resources.GetObject("botCancelar.BackgroundImage"), System.Drawing.Image)
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.ForeColor = System.Drawing.Color.Black
        Me.botCancelar.Location = New System.Drawing.Point(528, 637)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(224, 23)
        Me.botCancelar.TabIndex = 35
        Me.botCancelar.Text = "Cancelar Cambios"
        '
        'botEntraEnReparar
        '
        Me.botEntraEnReparar.BackColor = System.Drawing.SystemColors.Control
        Me.botEntraEnReparar.BackgroundImage = CType(resources.GetObject("botEntraEnReparar.BackgroundImage"), System.Drawing.Image)
        Me.botEntraEnReparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEntraEnReparar.ForeColor = System.Drawing.Color.Black
        Me.botEntraEnReparar.Location = New System.Drawing.Point(12, 591)
        Me.botEntraEnReparar.Name = "botEntraEnReparar"
        Me.botEntraEnReparar.Size = New System.Drawing.Size(224, 23)
        Me.botEntraEnReparar.TabIndex = 36
        Me.botEntraEnReparar.Text = "Reparar"
        Me.botEntraEnReparar.UseVisualStyleBackColor = False
        '
        'FormIntervenciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.botEntraEnReparar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.botCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.botElimina)
        Me.Controls.Add(Me.botSalir)
        Me.Controls.Add(Me.ListBoxIntervenciones)
        Me.Controls.Add(Me.botAceptar)
        Me.Controls.Add(Me.labMensaje)
        Me.Controls.Add(Me.labIQdelaFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormIntervenciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Intervenciones Quirúrgicas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'variables del entorno
    Dim FechaSeleccionada As Date
    Dim AñoSeleccionado As String
    Dim MesSeleccionado As String
    Dim DiaSeleccionado As String
    Dim SeModificaronDatos As Boolean
    Dim EsUnaNuevaIntervencion As Boolean

    Dim Nombre As String
    Dim Edad As String
    Dim TipoIQ As String
    Dim Rol As String
    Dim Medico1 As String
    Dim Medico2 As String
    Dim RolMedico1 As String
    Dim RolMedico2 As String
    Dim Lugar As String
    Dim FormaDePago As String
    Dim SePagaronLosHonorarios As Boolean
    Dim HonorariosEstimados As Decimal
    Dim HonorariosPagados As Decimal
    Dim Notas As String
    Dim FechaDeNacimiento As String
    Dim Cedula As String


    Dim NumerodeIQ As Integer
    Dim FechaComoDate As Date
    Dim FechaFormateada As String
    Dim EncabezadoNombre As String
    Dim EncabezadoTipoIQ As String

    Dim FechaOriginal As String
    Dim NombreOriginal As String
    Dim IQoriginal As String




    'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image

    'variables de Nombres de archivo
    Dim archivoIQDia As String
    Dim archivoIQMes As String
    Dim archivoIQAño As String

    'variables de directorios y paths
    Dim PathIQ As String
    Dim PathIQsub As String
    Dim ExistePathIQ As Boolean
    Dim ExistePathIQsub As Boolean

    Dim IQ As Form1.TablaDeIntervenciones
    Dim arrayDeIntervencionesDia As New ArrayList()
    Dim arrayDeIntervencionesMes As New ArrayList()
    Dim arrayDeIntervencionesAño As New ArrayList()

    'variables de control de IO
    Dim FS As FileStream
    Dim BW As BinaryWriter
    Dim BR As BinaryReader
    Dim REnum As IEnumerator

    Dim C As Integer


    Private Sub FormIntervenciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'inicializa nombre de variables y valores
        Inicializa()
        'construye nombres
        ConstruyeNombres()
        'borra todo
        LimpiaTodo()
        'verifica la fecha
        VerificaFecha()
    End Sub

    Private Sub Inicializa()
        'nombre de los graficos
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff
        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
        BarraSinMensaje = Form1.BarraSinMensaje

        'situa el calendario en la fecha adecuada
        Calendario.SelectionStart = Form1.dateFechaDeInicioParaModificarIntervenciones
        FechaSeleccionada = Calendario.SelectionStart

        'verifica la existencia de la carpeta principal si no existe la crea
        PathIQ = Form1.PathIQ
        If Directory.Exists(PathIQ) = False Then
            Directory.CreateDirectory(PathIQ)
        End If


    End Sub

    Private Sub ConstruyeNombres()
        AñoSeleccionado = FechaSeleccionada.Year.ToString
        MesSeleccionado = FechaSeleccionada.Month.ToString
        If MesSeleccionado.Length = 1 Then
            MesSeleccionado = "0" & MesSeleccionado
        End If
        DiaSeleccionado = FechaSeleccionada.Day.ToString
        If DiaSeleccionado.Length = 1 Then
            DiaSeleccionado = "0" & DiaSeleccionado
        End If

        PathIQsub = PathIQ & "\" & AñoSeleccionado
        If Directory.Exists(PathIQsub) = True Then
            ExistePathIQsub = True
        Else
            ExistePathIQsub = False
        End If

        archivoIQDia = PathIQsub & "\IQ-" & AñoSeleccionado & MesSeleccionado & DiaSeleccionado & ".iqr"
        archivoIQMes = PathIQsub & "\IQ-" & AñoSeleccionado & MesSeleccionado & ".iqr"
        archivoIQAño = PathIQsub & "\IQ-" & AñoSeleccionado & ".iqr"
    End Sub

    Private Sub LimpiaTodo()
        'Limpia los text boxes
        txtNombre.Clear()
        txtEdad.Clear()
        txtTipoIntervencion.Clear()
        txtRol.Clear()
        txtMedico1.Clear()
        txtRolMedico1.Clear()
        txtMedico2.Clear()
        txtRolMedico2.Clear()
        txtLugar.Clear()
        txtFormaDePago.Clear()
        RadPendiente.Checked = True
        txtHonorariosEstimados.Clear()
        txtHonorariosPagados.Clear()
        txtNotas.Clear()
        txtFechaDeNacimiento.Clear()
        txtCedula.Clear()

        'borra el list box intervenciones
        ListBoxIntervenciones.Items.Clear()

        'pon la variable de se modifico la vaina a false
        SeModificaronDatos = False

        'acomoda los botones de salida y aceptar
        botSalir.Text = "Salir"
        botAceptar.Enabled = False
        botCancelar.Enabled = False

        GroupBox1.Enabled = False
        botElimina.Enabled = False

    End Sub

    Private Sub LimpiaSoloTextBoxes()
        txtNombre.Clear()
        txtEdad.Clear()
        txtTipoIntervencion.Clear()
        txtRol.Clear()
        txtMedico1.Clear()
        txtRolMedico1.Clear()
        txtMedico2.Clear()
        txtRolMedico2.Clear()
        txtLugar.Clear()
        txtFormaDePago.Clear()
        RadPendiente.Checked = True
        txtHonorariosEstimados.Clear()
        txtHonorariosPagados.Clear()
        txtNotas.Clear()
        txtFechaDeNacimiento.Clear()
        txtCedula.Clear()
    End Sub

    Private Sub Calendario_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateSelected
        If Calendario.SelectionStart > Today Then
            MsgBox("La fecha seleccionada se encuentra en el Futuro, se seleccionará automáticamente la fecha actual...", MsgBoxStyle.Information, "Registro de Intervenciones")
            Calendario.SelectionStart = Today
        End If
        'actualiza la fecha seleccionada
        FechaSeleccionada = Calendario.SelectionStart
        'construye los nombres de archivo segun el dia seleccionado
        ConstruyeNombres()
        'ahora borra todos los datos metios
        LimpiaTodo()
        'verifica la fecha seleccionada y actua en consecuencia
        VerificaFecha()
    End Sub

    Private Sub Calendario_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Calendario.MouseDown
        'actualiza la fecha seleccionada
        FechaSeleccionada = Calendario.SelectionStart
        'construye los nombres de archivo segun el dia seleccionado
        ConstruyeNombres()
        'ahora borra todos los datos metios
        LimpiaTodo()
        'verifica la fecha seleccionada y actua en consecuencia
        VerificaFecha()
    End Sub

    Private Sub VerificaFecha()
        'verifica la existencia de un archivo de intervenciones el dia seleccionado
        If File.Exists(archivoIQDia) = True Then
            'existe el archivo, lo lee y muestra su encabezado en el list box
            LeeArchivoIQdia()
            'ahora muestra los encabezados en el list box
            REnum = arrayDeIntervencionesDia.GetEnumerator
            While REnum.MoveNext
                IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
                EncabezadoNombre = IQ.a02NombrePaciente
                EncabezadoTipoIQ = IQ.a04TipoIntervencion
                ListBoxIntervenciones.Items.Add(EncabezadoNombre & " - " & EncabezadoTipoIQ)
            End While

            'acomoda el label del list box
            labIQdelaFecha.Text = "Intervenciones del día " & FechaSeleccionada.ToLongDateString & ": (" & NumerodeIQ & ")"
            'añade finalmente la opcion de meter otra IQ
            ListBoxIntervenciones.Items.Add("Anota una Intervención Nueva...")
        Else
            'no existe el archivo, lo dice en el listbox intervenciones
            labIQdelaFecha.Text = "Intervenciones del día " & FechaSeleccionada.ToLongDateString & ": No se ha registrado ninguna..."
            ListBoxIntervenciones.Items.Add("Anota una Intervención Nueva...")
        End If


        '000000000000000000000000000000000000000000000
        'parte de las fechas que tienen IQ 

        Dim U As New ArrayList() 'FechasConConsultaMes
        Dim Fecha As Date
        Dim Año As Integer
        Dim Mes As Integer
        Dim Dia As Integer
        Dim Fechas() As Date
        'Dim ArchivoIQdelMes As String

        'construye el nombre del mes que se esta viendo en la vista de dias
        'ArchivoIQMes = Se conbstruye en crear nombres....


        U.Clear()

        If File.Exists(archivoIQMes) = True Then
            'existe un archivo de control de mes, lo lee
            FS = New FileStream(archivoIQMes, FileMode.Open, FileAccess.Read)
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
                Fecha = CType(IQ.a01Fecha.Substring(0, 10), Date)
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

    End Sub

    Private Sub ListBoxIntervenciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxIntervenciones.SelectedIndexChanged
        'una vez seleccionado añadir uno nuevo o modificar uno existente, apaga las partes de desplazamiento
        'apaga el list box para que no se pueda seleccionar otra IQ
        ListBoxIntervenciones.Enabled = False
        'apaga el calendario para que no se pueda cambiar el dia
        Calendario.Enabled = False
        Calendario.ForeColor = System.Drawing.SystemColors.GrayText
        Calendario.TitleForeColor = System.Drawing.SystemColors.GrayText


        'ahora ve que fue lo que se escogio
        If ListBoxIntervenciones.SelectedItem = "Anota una Intervención Nueva..." Then
            'se va a añadir una intervencion a este dia (si se acepta claro...)
            EsUnaNuevaIntervencion = True
            'pone un mensaje de orientacion
            labMensaje.Text = "Introduce los datos conocidos, después podrás añadir otros o modificarlos..."
            'limpia los text boxes
            LimpiaSoloTextBoxes()
            'prende el group box
            GroupBox1.Enabled = True
            'inicializa las variables
            Nombre = ""
            Edad = ""
            TipoIQ = ""
            Rol = ""
            Medico1 = ""
            Medico2 = ""
            RolMedico1 = ""
            RolMedico2 = ""
            Lugar = ""
            FormaDePago = ""
            SePagaronLosHonorarios = False
            HonorariosEstimados = 0
            HonorariosPagados = 0
            Notas = ""
            FechaDeNacimiento = ""
            Cedula = ""

            'inicializa los rad buttons
            RadPendiente.Checked = True
            'formatea los montos de efectivo
            txtHonorariosEstimados.Text = FormatCurrency(HonorariosEstimados, , , TriState.True, TriState.True)
            txtHonorariosPagados.Text = FormatCurrency(HonorariosPagados, , , TriState.True, TriState.True)
            'le da el foco al text box del nombre
            txtNombre.Focus()

            'acomoda los botones de salida y aceptar
            botSalir.Text = "Salir"
            botAceptar.Enabled = False
            SeModificaronDatos = False
            'prende el boton cancelar para salir de la edicion
            botCancelar.Enabled = True


        Else
            'se esta seleccionando una intervencion existente, la lee y muestra...
            EsUnaNuevaIntervencion = False
            'pone un mensaje de orientacion
            labMensaje.Text = "Modifica o añade nuevos datos o Elimina el Registro seleccionado..."
            'prende el boton de eliminar
            botElimina.Enabled = True
            Dim Indice As Integer
            Indice = ListBoxIntervenciones.SelectedIndex
            IQ = arrayDeIntervencionesDia(Indice)
            'primero recuerda el nombre y la IQ originales (para cosas de sustituciones)
            FechaOriginal = IQ.a01Fecha
            NombreOriginal = IQ.a02NombrePaciente
            IQoriginal = IQ.a04TipoIntervencion
            'limpia los text boxes
            LimpiaSoloTextBoxes()
            'prende el group box
            GroupBox1.Enabled = True
            'inicializa las variables
            Nombre = IQ.a02NombrePaciente
            txtNombre.Text = Nombre
            Edad = IQ.a03EdadPaciente
            txtEdad.Text = Edad
            TipoIQ = IQ.a04TipoIntervencion
            txtTipoIntervencion.Text = TipoIQ
            Rol = IQ.a05RolEnLaIntervencion
            txtRol.Text = Rol
            Medico1 = IQ.a06Medico01
            txtMedico1.Text = Medico1
            Medico2 = IQ.a08Medico02
            txtMedico2.Text = Medico2
            RolMedico1 = IQ.a07RolMedico01
            txtRolMedico1.Text = RolMedico1
            RolMedico2 = IQ.a09RolMedico02
            txtRolMedico2.Text = RolMedico2
            Lugar = IQ.a10Lugar
            txtLugar.Text = Lugar
            FormaDePago = IQ.a11FormaDePago
            txtFormaDePago.Text = FormaDePago
            If IQ.a12PagoEfectuado = "1" Then
                SePagaronLosHonorarios = False
                RadPendiente.Checked = True
                HonorariosEstimados = IQ.a13HonorariosEstimados
                HonorariosPagados = 0
                txtHonorariosEstimados.Text = FormatCurrency(HonorariosEstimados, , , TriState.True, TriState.True)
                txtHonorariosPagados.Text = FormatCurrency(HonorariosPagados, , , TriState.True, TriState.True)
            Else
                SePagaronLosHonorarios = True
                radCancelado.Checked = True
                HonorariosEstimados = 0
                HonorariosPagados = IQ.a14HonorariosNetosPagados
                txtHonorariosEstimados.Text = FormatCurrency(HonorariosEstimados, , , TriState.True, TriState.True)
                txtHonorariosPagados.Text = FormatCurrency(HonorariosPagados, , , TriState.True, TriState.True)
            End If
            Notas = IQ.a15Notas
            txtNotas.Text = Notas
            FechaDeNacimiento = IQ.a16FechaDeNacimiento
            If IsDate(FechaDeNacimiento) Then
                txtFechaDeNacimiento.Text = (CType(FechaDeNacimiento, Date)).ToShortDateString
            Else
                txtFechaDeNacimiento.Text = "" 'si no hay una fecha valida borra el campo
            End If
            Cedula = IQ.a17Cedula
            txtCedula.Text = Cedula

            'le da el foco al text box del nombre
            txtNombre.Focus()
            'acomoda los botones de salida y aceptar
            botSalir.Text = "Salir"
            botAceptar.Enabled = False
            SeModificaronDatos = False
            'prende el boton cancelar para salir de la edicion
            botCancelar.Enabled = True
        End If
    End Sub

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        Dim Cancelado As String
        Dim Otros As String

        'revisa si la fecha de nacimiento es fecha
        If txtFechaDeNacimiento.Text <> "" Then
            If IsDate(txtFechaDeNacimiento.Text) Then
                Dim FN = CType(txtFechaDeNacimiento.Text, Date)
                If FN > Today Then
                    'la fecha de nacimiento esta en el futuro
                    MsgBox("La fecha de nacimiento introducida (" & txtFechaDeNacimiento.Text & ") está en el futuro, corrígela o deja el campo en blanco...", MsgBoxStyle.Information, "Fecha de Nacimiento Inválida")
                    Exit Sub
                End If
            Else
                'no hay una fecha valida lo dice
                MsgBox("Corrige la fecha de nacimiento introducida (" & txtFechaDeNacimiento.Text & ") o deja el campo en blanco...", MsgBoxStyle.Information, "Fecha de Nacimiento Inválida")
                Exit Sub
            End If
        End If

        'convierte el boolean en string "1" es pendiente y "2" es cancelado
        If SePagaronLosHonorarios = True Then
            Cancelado = "2"
        Else
            Cancelado = "1"
        End If
        'inicializa las variables otros (hasta ahora en blanco)
        Otros = ""

        'revisa si es una nueva o se modifica una vieja
        If EsUnaNuevaIntervencion = True Then
            'se esta creando una nueva entrada
            If ExistePathIQsub = False Then
                ' no existe el directorio lo crea
                Directory.CreateDirectory(PathIQsub)
            End If
            '000000000000000000primero el archivo de IQ de dias
            If File.Exists(archivoIQDia) = True Then
                'existe un archivo se le añade esta IQ al final
                LeeArchivoIQdia()
                'ahora añade la IQ actual
                IQ = Nothing
                IQ.a01Fecha = FechaSeleccionada.ToString
                IQ.a02NombrePaciente = Nombre
                IQ.a03EdadPaciente = Edad
                IQ.a04TipoIntervencion = TipoIQ
                IQ.a05RolEnLaIntervencion = Rol
                IQ.a06Medico01 = Medico1
                IQ.a07RolMedico01 = RolMedico1
                IQ.a08Medico02 = Medico2
                IQ.a09RolMedico02 = RolMedico2
                IQ.a10Lugar = Lugar
                IQ.a11FormaDePago = FormaDePago
                IQ.a12PagoEfectuado = Cancelado
                IQ.a13HonorariosEstimados = HonorariosEstimados.ToString
                IQ.a14HonorariosNetosPagados = HonorariosPagados.ToString
                IQ.a15Notas = Notas
                IQ.a16FechaDeNacimiento = FechaDeNacimiento
                IQ.a17Cedula = Cedula
                IQ.b03OtrosC = Otros
                IQ.b04OtrosD = Otros
                IQ.b05OtrosE = Otros
                'añade la estructura de los datos nuevos a las existentes en elarray
                arrayDeIntervencionesDia.Add(IQ)
                'escribe los datos desde el array de vuelta al archivo
                EscribeArchivoIQdia()
                'MsgBox("Se añadió un registro de la Intervención a las de este día...")

            Else
                'no existe lo crea y luego le añade el iq
                FS = New FileStream(archivoIQDia, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                'escribe directo de las variables al archivo
                BW.Write(FechaSeleccionada.ToString)
                BW.Write(Nombre)
                BW.Write(Edad)
                BW.Write(TipoIQ)
                BW.Write(Rol)
                BW.Write(Medico1)
                BW.Write(RolMedico1)
                BW.Write(Medico2)
                BW.Write(RolMedico2)
                BW.Write(Lugar)
                BW.Write(FormaDePago)
                BW.Write(Cancelado)
                BW.Write(HonorariosEstimados.ToString)
                BW.Write(HonorariosPagados.ToString)
                BW.Write(Notas)
                BW.Write(FechaDeNacimiento)
                BW.Write(Cedula)
                BW.Write(Otros)
                BW.Write(Otros)
                BW.Write(Otros)

                BW.Close()
                FS.Close()
                'MsgBox("Se creo un registro de la Intervención en este día...")
            End If

            '0000000000000 ahora el archivo de meses
            If File.Exists(archivoIQMes) = True Then
                'existe un archivo se le añade esta IQ al final
                LeeArchivoIQmes()
                'ahora añade la IQ actual
                IQ = Nothing
                IQ.a01Fecha = FechaSeleccionada.ToString
                IQ.a02NombrePaciente = Nombre
                IQ.a03EdadPaciente = Edad
                IQ.a04TipoIntervencion = TipoIQ
                IQ.a05RolEnLaIntervencion = Rol
                IQ.a06Medico01 = Medico1
                IQ.a07RolMedico01 = RolMedico1
                IQ.a08Medico02 = Medico2
                IQ.a09RolMedico02 = RolMedico2
                IQ.a10Lugar = Lugar
                IQ.a11FormaDePago = FormaDePago
                IQ.a12PagoEfectuado = Cancelado
                IQ.a13HonorariosEstimados = HonorariosEstimados.ToString
                IQ.a14HonorariosNetosPagados = HonorariosPagados.ToString
                IQ.a15Notas = Notas
                IQ.a16FechaDeNacimiento = FechaDeNacimiento
                IQ.a17Cedula = Cedula
                IQ.b03OtrosC = Otros
                IQ.b04OtrosD = Otros
                IQ.b05OtrosE = Otros
                'añade la estructura de los datos nuevos a las existentes en elarray
                arrayDeIntervencionesMes.Add(IQ)
                'escribe los datos desde el array de vuelta al archivo
                EscribeArchivoIQmes()
            Else
                'no existe lo crea y luego le añade el iq
                FS = New FileStream(archivoIQMes, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                'escribe directo de las variables al archivo
                BW.Write(FechaSeleccionada.ToString)
                BW.Write(Nombre)
                BW.Write(Edad)
                BW.Write(TipoIQ)
                BW.Write(Rol)
                BW.Write(Medico1)
                BW.Write(RolMedico1)
                BW.Write(Medico2)
                BW.Write(RolMedico2)
                BW.Write(Lugar)
                BW.Write(FormaDePago)
                BW.Write(Cancelado)
                BW.Write(HonorariosEstimados.ToString)
                BW.Write(HonorariosPagados.ToString)
                BW.Write(Notas)
                BW.Write(FechaDeNacimiento)
                BW.Write(Cedula)
                BW.Write(Otros)
                BW.Write(Otros)
                BW.Write(Otros)

                BW.Close()
                FS.Close()
            End If

            '0000000000000 ahora el archivo de años
            If File.Exists(archivoIQAño) = True Then
                'existe un archivo se le añade esta IQ al final
                LeeArchivoIQaño()
                'ahora añade la IQ actual
                IQ = Nothing
                IQ.a01Fecha = FechaSeleccionada.ToString
                IQ.a02NombrePaciente = Nombre
                IQ.a03EdadPaciente = Edad
                IQ.a04TipoIntervencion = TipoIQ
                IQ.a05RolEnLaIntervencion = Rol
                IQ.a06Medico01 = Medico1
                IQ.a07RolMedico01 = RolMedico1
                IQ.a08Medico02 = Medico2
                IQ.a09RolMedico02 = RolMedico2
                IQ.a10Lugar = Lugar
                IQ.a11FormaDePago = FormaDePago
                IQ.a12PagoEfectuado = Cancelado
                IQ.a13HonorariosEstimados = HonorariosEstimados.ToString
                IQ.a14HonorariosNetosPagados = HonorariosPagados.ToString
                IQ.a15Notas = Notas
                IQ.a16FechaDeNacimiento = FechaDeNacimiento
                IQ.a17Cedula = Cedula
                IQ.b03OtrosC = Otros
                IQ.b04OtrosD = Otros
                IQ.b05OtrosE = Otros
                'añade la estructura de los datos nuevos a las existentes en elarray
                arrayDeIntervencionesAño.Add(IQ)
                'escribe los datos desde el array de vuelta al archivo
                EscribeArchivoIQaño()
            Else
                'no existe lo crea y luego le añade el iq
                FS = New FileStream(archivoIQAño, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                'escribe directo de las variables al archivo
                BW.Write(FechaSeleccionada.ToString)
                BW.Write(Nombre)
                BW.Write(Edad)
                BW.Write(TipoIQ)
                BW.Write(Rol)
                BW.Write(Medico1)
                BW.Write(RolMedico1)
                BW.Write(Medico2)
                BW.Write(RolMedico2)
                BW.Write(Lugar)
                BW.Write(FormaDePago)
                BW.Write(Cancelado)
                BW.Write(HonorariosEstimados.ToString)
                BW.Write(HonorariosPagados.ToString)
                BW.Write(Notas)
                BW.Write(FechaDeNacimiento)
                BW.Write(Cedula)
                BW.Write(Otros)
                BW.Write(Otros)
                BW.Write(Otros)

                BW.Close()
                FS.Close()
            End If
        Else
            'se esta editando una intervencion antigua

            '0000000000000000archivo de dias
            'primero busca la intervencion a modificar...
            Dim Indice As Integer
            Dim Contador As Integer = 0
            Indice = ListBoxIntervenciones.SelectedIndex

            'ojo creo q no hace falta pero porsia
            LeeArchivoIQdia()

            REnum = arrayDeIntervencionesDia.GetEnumerator
            FS = New FileStream(archivoIQDia, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
                If Indice = Contador Then
                    'este es el que se esta modificando, sustituye los datos con la pantalla
                    IQ = Nothing
                    IQ.a01Fecha = FechaSeleccionada.ToString
                    IQ.a02NombrePaciente = Nombre
                    IQ.a03EdadPaciente = Edad
                    IQ.a04TipoIntervencion = TipoIQ
                    IQ.a05RolEnLaIntervencion = Rol
                    IQ.a06Medico01 = Medico1
                    IQ.a07RolMedico01 = RolMedico1
                    IQ.a08Medico02 = Medico2
                    IQ.a09RolMedico02 = RolMedico2
                    IQ.a10Lugar = Lugar
                    IQ.a11FormaDePago = FormaDePago
                    IQ.a12PagoEfectuado = Cancelado
                    IQ.a13HonorariosEstimados = HonorariosEstimados.ToString
                    IQ.a14HonorariosNetosPagados = HonorariosPagados.ToString
                    IQ.a15Notas = Notas
                    IQ.a16FechaDeNacimiento = FechaDeNacimiento
                    IQ.a17Cedula = Cedula
                    IQ.b03OtrosC = Otros
                    IQ.b04OtrosD = Otros
                    IQ.b05OtrosE = Otros
                End If
                'escribe los datos al archivo
                BW.Write(IQ.a01Fecha)
                BW.Write(IQ.a02NombrePaciente)
                BW.Write(IQ.a03EdadPaciente)
                BW.Write(IQ.a04TipoIntervencion)
                BW.Write(IQ.a05RolEnLaIntervencion)
                BW.Write(IQ.a06Medico01)
                BW.Write(IQ.a07RolMedico01)
                BW.Write(IQ.a08Medico02)
                BW.Write(IQ.a09RolMedico02)
                BW.Write(IQ.a10Lugar)
                BW.Write(IQ.a11FormaDePago)
                BW.Write(IQ.a12PagoEfectuado)
                BW.Write(IQ.a13HonorariosEstimados)
                BW.Write(IQ.a14HonorariosNetosPagados)
                BW.Write(IQ.a15Notas)
                BW.Write(IQ.a16FechaDeNacimiento)
                BW.Write(IQ.a17Cedula)
                BW.Write(IQ.b03OtrosC)
                BW.Write(IQ.b04OtrosD)
                BW.Write(IQ.b05OtrosE)

                Contador += 1
            End While
            FS.Close()
            BW.Close()
            'MsgBox("Se modifico el registro de la Intervención seleccionada")

            '000000000000000 ahora los de meses
            'primero lee lo que esta en disco
            LeeArchivoIQmes()
            'ahora recorre el array con los datos para buscar el que se va a modificar
            REnum = arrayDeIntervencionesMes.GetEnumerator
            FS = New FileStream(archivoIQMes, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
                If FechaOriginal = IQ.a01Fecha Then
                    If NombreOriginal = IQ.a02NombrePaciente Then
                        If IQoriginal = IQ.a04TipoIntervencion Then
                            'este es el que se esta modificando, sustituye los datos con la pantalla
                            IQ = Nothing
                            IQ.a01Fecha = FechaSeleccionada.ToString
                            IQ.a02NombrePaciente = Nombre
                            IQ.a03EdadPaciente = Edad
                            IQ.a04TipoIntervencion = TipoIQ
                            IQ.a05RolEnLaIntervencion = Rol
                            IQ.a06Medico01 = Medico1
                            IQ.a07RolMedico01 = RolMedico1
                            IQ.a08Medico02 = Medico2
                            IQ.a09RolMedico02 = RolMedico2
                            IQ.a10Lugar = Lugar
                            IQ.a11FormaDePago = FormaDePago
                            IQ.a12PagoEfectuado = Cancelado
                            IQ.a13HonorariosEstimados = HonorariosEstimados.ToString
                            IQ.a14HonorariosNetosPagados = HonorariosPagados.ToString
                            IQ.a15Notas = Notas
                            IQ.a16FechaDeNacimiento = FechaDeNacimiento
                            IQ.a17Cedula = Cedula
                            IQ.b03OtrosC = Otros
                            IQ.b04OtrosD = Otros
                            IQ.b05OtrosE = Otros
                        End If
                    End If
                End If
                'escribe los datos al archivo
                BW.Write(IQ.a01Fecha)
                BW.Write(IQ.a02NombrePaciente)
                BW.Write(IQ.a03EdadPaciente)
                BW.Write(IQ.a04TipoIntervencion)
                BW.Write(IQ.a05RolEnLaIntervencion)
                BW.Write(IQ.a06Medico01)
                BW.Write(IQ.a07RolMedico01)
                BW.Write(IQ.a08Medico02)
                BW.Write(IQ.a09RolMedico02)
                BW.Write(IQ.a10Lugar)
                BW.Write(IQ.a11FormaDePago)
                BW.Write(IQ.a12PagoEfectuado)
                BW.Write(IQ.a13HonorariosEstimados)
                BW.Write(IQ.a14HonorariosNetosPagados)
                BW.Write(IQ.a15Notas)
                BW.Write(IQ.a16FechaDeNacimiento)
                BW.Write(IQ.a17Cedula)
                BW.Write(IQ.b03OtrosC)
                BW.Write(IQ.b04OtrosD)
                BW.Write(IQ.b05OtrosE)
            End While
            FS.Close()
            BW.Close()


            '000000000000000 ahora los de años
            'primero lee lo que esta en disco
            LeeArchivoIQaño()
            'ahora recorre el array con los datos para buscar el que se va a modificar
            REnum = arrayDeIntervencionesAño.GetEnumerator
            FS = New FileStream(archivoIQAño, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
                If FechaOriginal = IQ.a01Fecha Then
                    If NombreOriginal = IQ.a02NombrePaciente Then
                        If IQoriginal = IQ.a04TipoIntervencion Then
                            'este es el que se esta modificando, sustituye los datos con la pantalla
                            IQ = Nothing
                            IQ.a01Fecha = FechaSeleccionada.ToString
                            IQ.a02NombrePaciente = Nombre
                            IQ.a03EdadPaciente = Edad
                            IQ.a04TipoIntervencion = TipoIQ
                            IQ.a05RolEnLaIntervencion = Rol
                            IQ.a06Medico01 = Medico1
                            IQ.a07RolMedico01 = RolMedico1
                            IQ.a08Medico02 = Medico2
                            IQ.a09RolMedico02 = RolMedico2
                            IQ.a10Lugar = Lugar
                            IQ.a11FormaDePago = FormaDePago
                            IQ.a12PagoEfectuado = Cancelado
                            IQ.a13HonorariosEstimados = HonorariosEstimados.ToString
                            IQ.a14HonorariosNetosPagados = HonorariosPagados.ToString
                            IQ.a15Notas = Notas
                            IQ.a16FechaDeNacimiento = FechaDeNacimiento
                            IQ.a17Cedula = Cedula
                            IQ.b03OtrosC = Otros
                            IQ.b04OtrosD = Otros
                            IQ.b05OtrosE = Otros
                        End If
                    End If
                End If
                'escribe los datos al archivo
                BW.Write(IQ.a01Fecha)
                BW.Write(IQ.a02NombrePaciente)
                BW.Write(IQ.a03EdadPaciente)
                BW.Write(IQ.a04TipoIntervencion)
                BW.Write(IQ.a05RolEnLaIntervencion)
                BW.Write(IQ.a06Medico01)
                BW.Write(IQ.a07RolMedico01)
                BW.Write(IQ.a08Medico02)
                BW.Write(IQ.a09RolMedico02)
                BW.Write(IQ.a10Lugar)
                BW.Write(IQ.a11FormaDePago)
                BW.Write(IQ.a12PagoEfectuado)
                BW.Write(IQ.a13HonorariosEstimados)
                BW.Write(IQ.a14HonorariosNetosPagados)
                BW.Write(IQ.a15Notas)
                BW.Write(IQ.a16FechaDeNacimiento)
                BW.Write(IQ.a17Cedula)
                BW.Write(IQ.b03OtrosC)
                BW.Write(IQ.b04OtrosD)
                BW.Write(IQ.b05OtrosE)
            End While
            FS.Close()
            BW.Close()

        End If




        'prende el list box otra vez
        ListBoxIntervenciones.Enabled = True
        'prende el calendario otra vez
        Calendario.Enabled = True
        Calendario.ForeColor = System.Drawing.SystemColors.WindowText
        Calendario.TitleForeColor = System.Drawing.SystemColors.ActiveCaptionText

        'borra todo
        LimpiaTodo()
        'verifica la fecha
        VerificaFecha()

    End Sub

    Private Sub botElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botElimina.Click
        Dim reply As MsgBoxResult
        reply = MsgBox("Para eliminar el registro de la intervención seleccionada presiona ACEPTAR...", MsgBoxStyle.OkCancel, "Confirmación de Eliminación")
        If reply = MsgBoxResult.Ok Then
            '0000000000000000archivo de dias
            'primero busca la intervencion a modificar...
            Dim Indice As Integer
            Dim Contador As Integer = 0
            Indice = ListBoxIntervenciones.SelectedIndex

            'ojo creo q no hace falta pero porsia
            LeeArchivoIQdia()

            REnum = arrayDeIntervencionesDia.GetEnumerator
            FS = New FileStream(archivoIQDia, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
                If Indice = Contador Then
                    'este es el que se esta eliminando, no lo escribe
                    Contador += 1
                Else
                    'este no se esta eliminando lo escribe
                    BW.Write(IQ.a01Fecha)
                    BW.Write(IQ.a02NombrePaciente)
                    BW.Write(IQ.a03EdadPaciente)
                    BW.Write(IQ.a04TipoIntervencion)
                    BW.Write(IQ.a05RolEnLaIntervencion)
                    BW.Write(IQ.a06Medico01)
                    BW.Write(IQ.a07RolMedico01)
                    BW.Write(IQ.a08Medico02)
                    BW.Write(IQ.a09RolMedico02)
                    BW.Write(IQ.a10Lugar)
                    BW.Write(IQ.a11FormaDePago)
                    BW.Write(IQ.a12PagoEfectuado)
                    BW.Write(IQ.a13HonorariosEstimados)
                    BW.Write(IQ.a14HonorariosNetosPagados)
                    BW.Write(IQ.a15Notas)
                    BW.Write(IQ.a16FechaDeNacimiento)
                    BW.Write(IQ.a17Cedula)
                    BW.Write(IQ.b03OtrosC)
                    BW.Write(IQ.b04OtrosD)
                    BW.Write(IQ.b05OtrosE)

                    Contador += 1
                End If
            End While
            FS.Close()
            BW.Close()

            '000000000000000 ahora los de meses
            'primero lee lo que esta en disco
            Dim SeEscribe As Boolean

            LeeArchivoIQmes()
            'ahora recorre el array con los datos para buscar el que se va a eliminar
            REnum = arrayDeIntervencionesMes.GetEnumerator
            FS = New FileStream(archivoIQMes, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                SeEscribe = True 'en un principio se escriben todos
                IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
                If FechaOriginal = IQ.a01Fecha Then
                    If NombreOriginal = IQ.a02NombrePaciente Then
                        If IQoriginal = IQ.a04TipoIntervencion Then
                            'este es el que se esta eliminando, no lo escribe
                            SeEscribe = False ' a menos q sea el que nose quiere escribir...
                        End If
                    End If
                End If
                If SeEscribe = True Then
                    BW.Write(IQ.a01Fecha)
                    BW.Write(IQ.a02NombrePaciente)
                    BW.Write(IQ.a03EdadPaciente)
                    BW.Write(IQ.a04TipoIntervencion)
                    BW.Write(IQ.a05RolEnLaIntervencion)
                    BW.Write(IQ.a06Medico01)
                    BW.Write(IQ.a07RolMedico01)
                    BW.Write(IQ.a08Medico02)
                    BW.Write(IQ.a09RolMedico02)
                    BW.Write(IQ.a10Lugar)
                    BW.Write(IQ.a11FormaDePago)
                    BW.Write(IQ.a12PagoEfectuado)
                    BW.Write(IQ.a13HonorariosEstimados)
                    BW.Write(IQ.a14HonorariosNetosPagados)
                    BW.Write(IQ.a15Notas)
                    BW.Write(IQ.a16FechaDeNacimiento)
                    BW.Write(IQ.a17Cedula)
                    BW.Write(IQ.b03OtrosC)
                    BW.Write(IQ.b04OtrosD)
                    BW.Write(IQ.b05OtrosE)
                End If
            End While
            FS.Close()
            BW.Close()

            '000000000000000 ahora los de años
            'primero lee lo que esta en disco
            LeeArchivoIQaño()
            'ahora recorre el array con los datos para buscar el que se va a eliminar
            REnum = arrayDeIntervencionesAño.GetEnumerator
            FS = New FileStream(archivoIQAño, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                SeEscribe = True
                IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
                If FechaOriginal = IQ.a01Fecha Then
                    If NombreOriginal = IQ.a02NombrePaciente Then
                        If IQoriginal = IQ.a04TipoIntervencion Then
                            'este es el que se esta eliminando, no lo escribe
                            SeEscribe = False
                        End If
                    End If
                End If
                If SeEscribe = True Then
                    BW.Write(IQ.a01Fecha)
                    BW.Write(IQ.a02NombrePaciente)
                    BW.Write(IQ.a03EdadPaciente)
                    BW.Write(IQ.a04TipoIntervencion)
                    BW.Write(IQ.a05RolEnLaIntervencion)
                    BW.Write(IQ.a06Medico01)
                    BW.Write(IQ.a07RolMedico01)
                    BW.Write(IQ.a08Medico02)
                    BW.Write(IQ.a09RolMedico02)
                    BW.Write(IQ.a10Lugar)
                    BW.Write(IQ.a11FormaDePago)
                    BW.Write(IQ.a12PagoEfectuado)
                    BW.Write(IQ.a13HonorariosEstimados)
                    BW.Write(IQ.a14HonorariosNetosPagados)
                    BW.Write(IQ.a15Notas)
                    BW.Write(IQ.a16FechaDeNacimiento)
                    BW.Write(IQ.a17Cedula)
                    BW.Write(IQ.b03OtrosC)
                    BW.Write(IQ.b04OtrosD)
                    BW.Write(IQ.b05OtrosE)
                End If
            End While
            FS.Close()
            BW.Close()
            'MsgBox("Se eliminó el registro de la Intervención seleccionada", MsgBoxStyle.Information)
        Else
            'no se acepto eliminar, lo dice
            MsgBox("No se realizaron cambios al registro de intervenciones del día", MsgBoxStyle.Information)
        End If

        'prende el list box otra vez
        ListBoxIntervenciones.Enabled = True
        'prende el calendario otra vez
        Calendario.Enabled = True
        Calendario.ForeColor = System.Drawing.SystemColors.WindowText
        Calendario.TitleForeColor = System.Drawing.SystemColors.ActiveCaptionText

        'borra todo
        LimpiaTodo()
        'verifica la fecha
        VerificaFecha()

    End Sub

    Private Sub LeeArchivoIQdia()
        FS = New FileStream(archivoIQDia, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim C As Integer
        arrayDeIntervencionesDia.Clear()
        NumerodeIQ = 0
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
            'añade la estructura al array
            arrayDeIntervencionesDia.Add(IQ)
            NumerodeIQ += 1
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub

    Private Sub LeeArchivoIQmes()
        FS = New FileStream(archivoIQMes, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim C As Integer
        arrayDeIntervencionesMes.Clear()
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
            'añade la estructura al array
            arrayDeIntervencionesMes.Add(IQ)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub

    Private Sub LeeArchivoIQaño()
        FS = New FileStream(archivoIQAño, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim C As Integer
        arrayDeIntervencionesAño.Clear()
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
            'añade la estructura al array
            arrayDeIntervencionesAño.Add(IQ)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub

    Private Sub EscribeArchivoIQdia()
        REnum = arrayDeIntervencionesDia.GetEnumerator
        FS = New FileStream(archivoIQDia, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        While REnum.MoveNext
            IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
            BW.Write(IQ.a01Fecha)
            BW.Write(IQ.a02NombrePaciente)
            BW.Write(IQ.a03EdadPaciente)
            BW.Write(IQ.a04TipoIntervencion)
            BW.Write(IQ.a05RolEnLaIntervencion)
            BW.Write(IQ.a06Medico01)
            BW.Write(IQ.a07RolMedico01)
            BW.Write(IQ.a08Medico02)
            BW.Write(IQ.a09RolMedico02)
            BW.Write(IQ.a10Lugar)
            BW.Write(IQ.a11FormaDePago)
            BW.Write(IQ.a12PagoEfectuado)
            BW.Write(IQ.a13HonorariosEstimados)
            BW.Write(IQ.a14HonorariosNetosPagados)
            BW.Write(IQ.a15Notas)
            BW.Write(IQ.a16FechaDeNacimiento)
            BW.Write(IQ.a17Cedula)
            BW.Write(IQ.b03OtrosC)
            BW.Write(IQ.b04OtrosD)
            BW.Write(IQ.b05OtrosE)
        End While
        FS.Close()
        BW.Close()
    End Sub

    Private Sub EscribeArchivoIQmes()
        REnum = arrayDeIntervencionesMes.GetEnumerator
        FS = New FileStream(archivoIQMes, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        While REnum.MoveNext
            IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
            BW.Write(IQ.a01Fecha)
            BW.Write(IQ.a02NombrePaciente)
            BW.Write(IQ.a03EdadPaciente)
            BW.Write(IQ.a04TipoIntervencion)
            BW.Write(IQ.a05RolEnLaIntervencion)
            BW.Write(IQ.a06Medico01)
            BW.Write(IQ.a07RolMedico01)
            BW.Write(IQ.a08Medico02)
            BW.Write(IQ.a09RolMedico02)
            BW.Write(IQ.a10Lugar)
            BW.Write(IQ.a11FormaDePago)
            BW.Write(IQ.a12PagoEfectuado)
            BW.Write(IQ.a13HonorariosEstimados)
            BW.Write(IQ.a14HonorariosNetosPagados)
            BW.Write(IQ.a15Notas)
            BW.Write(IQ.a16FechaDeNacimiento)
            BW.Write(IQ.a17Cedula)
            BW.Write(IQ.b03OtrosC)
            BW.Write(IQ.b04OtrosD)
            BW.Write(IQ.b05OtrosE)
        End While
        FS.Close()
        BW.Close()
    End Sub

    Private Sub EscribeArchivoIQaño()
        REnum = arrayDeIntervencionesAño.GetEnumerator
        FS = New FileStream(archivoIQAño, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        While REnum.MoveNext
            IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
            BW.Write(IQ.a01Fecha)
            BW.Write(IQ.a02NombrePaciente)
            BW.Write(IQ.a03EdadPaciente)
            BW.Write(IQ.a04TipoIntervencion)
            BW.Write(IQ.a05RolEnLaIntervencion)
            BW.Write(IQ.a06Medico01)
            BW.Write(IQ.a07RolMedico01)
            BW.Write(IQ.a08Medico02)
            BW.Write(IQ.a09RolMedico02)
            BW.Write(IQ.a10Lugar)
            BW.Write(IQ.a11FormaDePago)
            BW.Write(IQ.a12PagoEfectuado)
            BW.Write(IQ.a13HonorariosEstimados)
            BW.Write(IQ.a14HonorariosNetosPagados)
            BW.Write(IQ.a15Notas)
            BW.Write(IQ.a16FechaDeNacimiento)
            BW.Write(IQ.a17Cedula)
            BW.Write(IQ.b03OtrosC)
            BW.Write(IQ.b04OtrosD)
            BW.Write(IQ.b05OtrosE)
        End While
        FS.Close()
        BW.Close()
    End Sub

    Private Sub botSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalir.Click
        Dim Reply As DialogResult

        If SeModificaronDatos = True Then
            'se han hecho cambios que no se han guardado
            Reply = MsgBox("Se han realizado cambios que no han sido guardados, para confirmar salida presiona ACEPTAR...", MsgBoxStyle.OkCancel, "Confirma salida...")
            If Reply = Windows.Forms.DialogResult.OK Then
                'se confirmo sale pal coño
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Else
            'todos los cambios fueron guardados al menos sale con ok
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If


    End Sub

    'verifica cualquier cambio
    Private Sub txtCUALQUIERTEXTO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtNombre.TextChanged, txtEdad.TextChanged, txtTipoIntervencion.TextChanged, txtRol.TextChanged, txtMedico1.TextChanged, txtMedico2.TextChanged, txtRolMedico1.TextChanged, txtRolMedico2.TextChanged, txtLugar.TextChanged, txtFormaDePago.TextChanged, txtHonorariosEstimados.TextChanged, txtHonorariosPagados.TextChanged, txtNotas.TextChanged, txtFechaDeNacimiento.TextChanged, txtCedula.TextChanged

        If SeModificaronDatos = False Then
            'se produjo un cambio, prende el boton y acomoda la vaina
            SeModificaronDatos = True
            botAceptar.Enabled = True
            botSalir.Text = "Descarta Cambios"
        End If

    End Sub

    '---------Nombre
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.Leave
        Nombre = txtNombre.Text
    End Sub


    '---------Edad
    Private Sub txtEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdad.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtEdad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEdad.Leave
        Edad = txtEdad.Text
    End Sub

    '---------Tipo de IQ
    Private Sub txtTipoIntervencion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoIntervencion.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c) Or c = "-"c Or c = "+"c Or c = "."c) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTipoIntervencion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoIntervencion.Leave
        TipoIQ = txtTipoIntervencion.Text
    End Sub

    '---------Roles 
    Private Sub Roles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtRol.KeyPress, txtRolMedico1.KeyPress, txtRolMedico2.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtRol_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRol.Leave
        Rol = txtRol.Text
    End Sub
    Private Sub txtRolMedico1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRolMedico1.Leave
        RolMedico1 = txtRolMedico1.Text
    End Sub
    Private Sub txtRolMedico2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRolMedico2.Leave
        RolMedico2 = txtRolMedico2.Text
    End Sub

    '-------Medicos acompañantes
    Private Sub txtAcompañantes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtMedico1.KeyPress, txtMedico2.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c) Or c = "."c) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtMedico1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMedico1.Leave
        Medico1 = txtMedico1.Text
    End Sub
    Private Sub txtMedico2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMedico2.Leave
        Medico2 = txtMedico2.Text
    End Sub

    '--------Lugar de la intervencion
    Private Sub txtLugar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLugar.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtLugar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLugar.Leave
        Lugar = txtLugar.Text
    End Sub

    '-------- Forma de pago
    Private Sub txtFormaPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFormaDePago.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtFormadePago_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFormaDePago.Leave
        FormaDePago = txtFormaDePago.Text
    End Sub

    '---------SePagaronLosHonorarios
    Private Sub SePagoIQ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles RadPendiente.CheckedChanged, radCancelado.CheckedChanged

        If RadPendiente.Checked = True Then
            txtHonorariosEstimados.Enabled = True
            txtHonorariosPagados.Enabled = False
            HonorariosPagados = 0
            txtHonorariosPagados.Text = FormatCurrency(HonorariosPagados, , , TriState.True, TriState.True)
            SePagaronLosHonorarios = False
        End If
        If radCancelado.Checked = True Then
            txtHonorariosEstimados.Enabled = False
            txtHonorariosPagados.Enabled = True
            HonorariosEstimados = 0
            txtHonorariosEstimados.Text = FormatCurrency(HonorariosEstimados, , , TriState.True, TriState.True)
            SePagaronLosHonorarios = True
        End If
    End Sub

    '----------Honorarios estimados
    Private Sub txtHonorariosEstimados_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHonorariosEstimados.Enter
        txtHonorariosEstimados.Clear()
    End Sub
    Private Sub txtHonorariosEstimados_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHonorariosEstimados.Leave
        If txtHonorariosEstimados.Text = "" Then
            HonorariosEstimados = 0
        Else
            HonorariosEstimados = txtHonorariosEstimados.Text
        End If
        txtHonorariosEstimados.Text = FormatCurrency(HonorariosEstimados, , , TriState.True, TriState.True)
    End Sub
    Private Sub txtHonorariosEstimados_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHonorariosEstimados.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "."c) Then
            e.Handled = True
        End If
    End Sub

    '----------Honorarios Pagados
    Private Sub txtHonorariospagados_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHonorariosPagados.Enter
        txtHonorariosPagados.Clear()
    End Sub
    Private Sub txtHonorariospagados_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHonorariosPagados.Leave
        If txtHonorariosPagados.Text = "" Then
            HonorariosPagados = 0
        Else
            HonorariosPagados = txtHonorariosPagados.Text
        End If
        txtHonorariosPagados.Text = FormatCurrency(HonorariosPagados, , , TriState.True, TriState.True)
    End Sub
    Private Sub txtHonorariospagados_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHonorariosPagados.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "."c) Then
            e.Handled = True
        End If
    End Sub

    '---------Notas 
    Private Sub Notas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtNotas.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c) Or Char.IsDigit(c) Or Char.IsPunctuation(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNotas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNotas.Leave
        Notas = txtNotas.Text
    End Sub

    '------------- fecha de nacimiento
    Private Sub FechaDeNacimiento_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaDeNacimiento.KeyPress
        Dim c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "-"c Or c = "/"c) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtFechaDeNacimiento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaDeNacimiento.Leave
        If txtFechaDeNacimiento.Text <> "" Then
            If IsDate(txtFechaDeNacimiento.Text) = True Then
                Dim fn = CType(txtFechaDeNacimiento.Text, Date)
                If fn < Today Then
                    FechaDeNacimiento = (CType(txtFechaDeNacimiento.Text, Date)).ToString("s")
                    txtFechaDeNacimiento.Text = fn.ToShortDateString
                Else
                    'la fecha de nacimiento esta en el futuro (no avisa el error de inmediato solo si se aceptan los datos)
                    'MsgBox("La fecha de nacimiento introducida (" & txtFechaDeNacimiento.Text & ") está en el futuro, corrígela o deja el campo en blanco...", MsgBoxStyle.Information, "Fecha de Nacimiento Inválida")
                End If
            Else
                'no hay una fecha valida (no avisa de inmediato solo si se aceptan los datos)
                'MsgBox("Corrige la fecha de nacimiento introducida (" & txtFechaDeNacimiento.Text & ") o deja el campo en blanco...", MsgBoxStyle.Information, "Fecha de Nacimiento Inválida")
            End If
        Else
            'esta en blanco permite, no la sabe pues...
            FechaDeNacimiento = ""
        End If


    End Sub

    '---------- la cedula
    Private Sub txtCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtCedula.KeyPress
        Dim c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtCedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedula.Leave
        If txtCedula.Text <> "" Then
            Cedula = txtCedula.Text
        Else
            Cedula = ""
        End If

    End Sub

    '---------- el año para arreglar
    Private Sub txtYear_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtYear.KeyPress
        Dim c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        End If
    End Sub






























    'procedimientos de graficos de botones
    Private Sub botAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseEnter
        botAceptar.BackgroundImage = BotonOnGrande
    End Sub
    Private Sub botAceptar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseLeave
        botAceptar.BackgroundImage = BotonOffGrande
    End Sub
    Private Sub botcancelar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSalir.MouseEnter
        botSalir.BackgroundImage = BotonOnGrande
    End Sub
    Private Sub botcancelar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSalir.MouseLeave
        botSalir.BackgroundImage = BotonOffGrande
    End Sub
    Private Sub botElimina_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botElimina.MouseEnter
        botElimina.BackgroundImage = BotonOnGrande
    End Sub
    Private Sub botElimina_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botElimina.MouseLeave
        botElimina.BackgroundImage = BotonOffGrande
    End Sub
















    Dim arraylocalDeIntervencionesMes As New ArrayList
    Dim arraylocalDeIntervencionesAño As New ArrayList
    Dim localAño As String
    Dim localAñoBak As String

    Private Sub botProceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botProceder.Click
        Dim localMes As String
        Dim pedacito As String



        Dim locallinea As String
        Dim localContador As Integer = 0
        Dim localContadorAño As Integer = 0
        Dim localHonorariosAño As Integer = 0
        Dim localHonorariosMes As Integer = 0
        Dim t As Integer = 0

        If txtYear.Text <> "" Then
            If (CType(txtYear.Text, Integer)) < 2004 Then
                MsgBox("No existen intervenciones antes del 2004")
                Exit Sub
            Else
                If (CType(txtYear.Text, Integer)) > Today.Year Then
                    MsgBox("Se puede arreglar maximo hasta el año en curso")
                    Exit Sub
                Else
                    'esta bien sigue y acomoda la vaina

                End If
            End If
        Else
            MsgBox("Introduce el año q se debe reparar")
            Exit Sub
        End If

        'desactiva lo de arriba
        botReparar.Enabled = False
        botProceder.Enabled = False

        localAño = PathIQ & "\" & txtYear.Text & "\IQ-" & txtYear.Text & ".iqr"
        localAñoBak = PathIQ & "\" & txtYear.Text & "\IQ-" & txtYear.Text & ".bak"

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        locallinea = "Intervenciones de " & txtYear.Text
        ListBox2.Items.Add(locallinea)
        locallinea = " "
        ListBox2.Items.Add(locallinea)

        ListBox3.Items.Add(locallinea)
        locallinea = " "
        ListBox3.Items.Add(locallinea)

        arraylocalDeIntervencionesAño.Clear()
        localContadorAño = 0
        localHonorariosAño = 0

        'muestra lo actual loco
        If File.Exists(localAño) Then
            FS = New FileStream(localAño, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim C As Integer

            localContador = 0

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

                C = BR.PeekChar

                localContadorAño += 1
                localHonorariosAño += CType(IQ.a13HonorariosEstimados, Integer) + CType(IQ.a14HonorariosNetosPagados, Integer)

                locallinea = localContadorAño & " - " & IQ.a01Fecha & " - " & IQ.a02NombrePaciente
                ListBox3.Items.Add(locallinea)

            End While

            locallinea = " "
            ListBox3.Items.Add(locallinea)
            locallinea = "Honorarios del año: " & localHonorariosAño
            ListBox3.Items.Add(locallinea)

        End If


        'muestra los cambios reparados
        arraylocalDeIntervencionesAño.Clear()
        localContadorAño = 0
        localHonorariosAño = 0

        For t = 1 To 12

            If t < 10 Then
                pedacito = "0" & t.ToString
            Else
                pedacito = t.ToString
            End If

            localMes = PathIQ & "\" & txtYear.Text & "\IQ-" & txtYear.Text & pedacito & ".iqr"

            locallinea = "Intervenciones de " & pedacito & "-" & txtYear.Text
            ListBox1.Items.Add(locallinea)
            locallinea = " "
            ListBox1.Items.Add(locallinea)

            If File.Exists(localMes) Then
                FS = New FileStream(localMes, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)
                Dim C As Integer
                arraylocalDeIntervencionesMes.Clear()

                localContador = 0
                localHonorariosMes = 0

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
                    'añade la estructura al array
                    arraylocalDeIntervencionesMes.Add(IQ)
                    arraylocalDeIntervencionesAño.Add(IQ)
                    C = BR.PeekChar
                    localContador += 1
                    localContadorAño += 1

                    localHonorariosMes += CType(IQ.a13HonorariosEstimados, Integer) + CType(IQ.a14HonorariosNetosPagados, Integer)
                    localHonorariosAño += CType(IQ.a13HonorariosEstimados, Integer) + CType(IQ.a14HonorariosNetosPagados, Integer)

                    locallinea = localContador & " - " & IQ.a01Fecha & " - " & IQ.a02NombrePaciente
                    ListBox1.Items.Add(locallinea)
                    locallinea = localContadorAño & " - " & IQ.a01Fecha & " - " & IQ.a02NombrePaciente
                    ListBox2.Items.Add(locallinea)

                End While

                locallinea = " "
                ListBox1.Items.Add(locallinea)
                locallinea = "Honorarios del mes: " & localHonorariosMes
                ListBox1.Items.Add(locallinea)

                locallinea = " "
                ListBox2.Items.Add(locallinea)

                BR.Close()
                FS.Close()
            End If
        Next t

        locallinea = " "
        ListBox2.Items.Add(locallinea)
        locallinea = "Honorarios del año: " & localHonorariosAño
        ListBox2.Items.Add(locallinea)

        MsgBox("Revisa la información en los listbox y decide si Aceptas o Rechazas la reparación...", MsgBoxStyle.Information)


        botAceptarReparacion.Enabled = True
        botRechazarReparacion.Enabled = True


    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        'prende el list box otra vez
        ListBoxIntervenciones.Enabled = True
        'prende el calendario otra vez
        Calendario.Enabled = True
        Calendario.ForeColor = System.Drawing.SystemColors.WindowText
        Calendario.TitleForeColor = System.Drawing.SystemColors.ActiveCaptionText

        'borra todo
        LimpiaTodo()
        'verifica la fecha
        VerificaFecha()
    End Sub

    Private Sub botReparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botReparar.Click
        botProceder.Enabled = True
        GroupBox2.Visible = True
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        txtYear.Clear()
    End Sub

    Private Sub botAceptarReparacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptarReparacion.Click
        'primero respalda el año 
        If File.Exists(localAñoBak) Then
            'primero borra cualquier rezagado
            File.Delete(localAñoBak)
        End If
        'ahora respalda
        File.Copy(localAño, localAñoBak)

        'ahora si modifica el archivo q va a quedar
        REnum = arraylocalDeIntervencionesAño.GetEnumerator
        FS = New FileStream(archivoIQAño, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        While REnum.MoveNext
            IQ = CType(REnum.Current, Form1.TablaDeIntervenciones)
            BW.Write(IQ.a01Fecha)
            BW.Write(IQ.a02NombrePaciente)
            BW.Write(IQ.a03EdadPaciente)
            BW.Write(IQ.a04TipoIntervencion)
            BW.Write(IQ.a05RolEnLaIntervencion)
            BW.Write(IQ.a06Medico01)
            BW.Write(IQ.a07RolMedico01)
            BW.Write(IQ.a08Medico02)
            BW.Write(IQ.a09RolMedico02)
            BW.Write(IQ.a10Lugar)
            BW.Write(IQ.a11FormaDePago)
            BW.Write(IQ.a12PagoEfectuado)
            BW.Write(IQ.a13HonorariosEstimados)
            BW.Write(IQ.a14HonorariosNetosPagados)
            BW.Write(IQ.a15Notas)
            BW.Write(IQ.a16FechaDeNacimiento)
            BW.Write(IQ.a17Cedula)
            BW.Write(IQ.b03OtrosC)
            BW.Write(IQ.b04OtrosD)
            BW.Write(IQ.b05OtrosE)
        End While
        FS.Close()
        BW.Close()

        MsgBox("Los cambios fueron guardados satisfactoriamente. Se guardo un archivo .bak con los datos anteriores en caso de ser necesario...", MsgBoxStyle.Information)

        botAceptarReparacion.Enabled = False
        botRechazarReparacion.Enabled = False

        GroupBox2.Visible = False

        TabControl1.Visible = False

    End Sub

    Private Sub botRechazarReparacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRechazarReparacion.Click

        MsgBox("Ningún cambio fue guardado, todo quedó como estaba...", MsgBoxStyle.Information)
        botAceptarReparacion.Enabled = False
        botRechazarReparacion.Enabled = False
        GroupBox2.Visible = False

        botReparar.Text = "Reparar Otro Año"
        botReparar.Enabled = True

        TabControl1.Visible = False

    End Sub

    Private Sub botEntraEnReparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEntraEnReparar.Click
        If InputBox("Introduce Contraseña:", , , , ) = "10061997" Then
            'ok aplia el tab de reparacion
            TabControl1.Height = 605
            TabControl1.Width = 970
            TabControl1.Left = 12
            TabControl1.Top = 9

            TabControl1.Visible = True

        End If

    End Sub
End Class
