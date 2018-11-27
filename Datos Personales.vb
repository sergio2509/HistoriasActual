Imports System.IO

Public Class Datos_Personales
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProfesion As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents botAntecedentesFamiliares As System.Windows.Forms.Button
    Friend WithEvents botAntecedentesPersonales As System.Windows.Forms.Button
    Friend WithEvents botAntecedentesQuirurgicos As System.Windows.Forms.Button
    Friend WithEvents botAntecedentesGinecologicos As System.Windows.Forms.Button
    Friend WithEvents botAntecedentesObstetricos As System.Windows.Forms.Button
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGradoDeInstruccion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtReligion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCiaDeSeguros As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFamiliarNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFamiliarParentesco As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtFamiliarOcupacion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFamiliarTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAntecedentesGeneral As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Datos_Personales))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProfesion = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.botAntecedentesFamiliares = New System.Windows.Forms.Button()
        Me.botAntecedentesPersonales = New System.Windows.Forms.Button()
        Me.botAntecedentesQuirurgicos = New System.Windows.Forms.Button()
        Me.botAntecedentesGinecologicos = New System.Windows.Forms.Button()
        Me.botAntecedentesObstetricos = New System.Windows.Forms.Button()
        Me.txtAntecedentesGeneral = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGradoDeInstruccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReligion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCiaDeSeguros = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFamiliarNombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFamiliarParentesco = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFamiliarOcupacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFamiliarTelefono = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombrePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePaciente.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtNombrePaciente.Location = New System.Drawing.Point(96, 16)
        Me.txtNombrePaciente.MaxLength = 60
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.ReadOnly = True
        Me.txtNombrePaciente.Size = New System.Drawing.Size(512, 20)
        Me.txtNombrePaciente.TabIndex = 1
        Me.txtNombrePaciente.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(617, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Nacimiento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(716, 16)
        Me.txtFechaNacimiento.MaxLength = 10
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(84, 20)
        Me.txtFechaNacimiento.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(806, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Edad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.SystemColors.Info
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(844, 16)
        Me.txtEdad.MaxLength = 2
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(28, 20)
        Me.txtEdad.TabIndex = 5
        Me.txtEdad.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(50, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cédula"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.SystemColors.Info
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtCedula.Location = New System.Drawing.Point(96, 41)
        Me.txtCedula.MaxLength = 8
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(93, 20)
        Me.txtCedula.TabIndex = 7
        Me.txtCedula.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ocupación"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProfesion
        '
        Me.txtProfesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfesion.Location = New System.Drawing.Point(266, 41)
        Me.txtProfesion.MaxLength = 50
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.Size = New System.Drawing.Size(342, 20)
        Me.txtProfesion.TabIndex = 9
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(643, 44)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(67, 13)
        Me.label6.TabIndex = 10
        Me.label6.Text = "Teléfono :  0"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(716, 41)
        Me.txtTelefono.MaxLength = 10
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(84, 20)
        Me.txtTelefono.TabIndex = 11
        '
        'botAceptar
        '
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.ForeColor = System.Drawing.Color.Black
        Me.botAceptar.Image = CType(resources.GetObject("botAceptar.Image"), System.Drawing.Image)
        Me.botAceptar.Location = New System.Drawing.Point(758, 637)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(224, 23)
        Me.botAceptar.TabIndex = 4
        Me.botAceptar.Text = "Guardar Cambios"
        '
        'botCancelar
        '
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.ForeColor = System.Drawing.Color.Black
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Image)
        Me.botCancelar.Location = New System.Drawing.Point(12, 637)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(224, 23)
        Me.botCancelar.TabIndex = 3
        Me.botCancelar.Text = "Salir"
        '
        'botAntecedentesFamiliares
        '
        Me.botAntecedentesFamiliares.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAntecedentesFamiliares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botAntecedentesFamiliares.ForeColor = System.Drawing.Color.Black
        Me.botAntecedentesFamiliares.Image = CType(resources.GetObject("botAntecedentesFamiliares.Image"), System.Drawing.Image)
        Me.botAntecedentesFamiliares.Location = New System.Drawing.Point(12, 19)
        Me.botAntecedentesFamiliares.Name = "botAntecedentesFamiliares"
        Me.botAntecedentesFamiliares.Size = New System.Drawing.Size(224, 23)
        Me.botAntecedentesFamiliares.TabIndex = 0
        Me.botAntecedentesFamiliares.Text = "Antecedentes Familiares"
        '
        'botAntecedentesPersonales
        '
        Me.botAntecedentesPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAntecedentesPersonales.Image = CType(resources.GetObject("botAntecedentesPersonales.Image"), System.Drawing.Image)
        Me.botAntecedentesPersonales.Location = New System.Drawing.Point(360, 19)
        Me.botAntecedentesPersonales.Name = "botAntecedentesPersonales"
        Me.botAntecedentesPersonales.Size = New System.Drawing.Size(224, 23)
        Me.botAntecedentesPersonales.TabIndex = 1
        Me.botAntecedentesPersonales.Text = "Antecedentes Personales"
        '
        'botAntecedentesQuirurgicos
        '
        Me.botAntecedentesQuirurgicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAntecedentesQuirurgicos.Image = CType(resources.GetObject("botAntecedentesQuirurgicos.Image"), System.Drawing.Image)
        Me.botAntecedentesQuirurgicos.Location = New System.Drawing.Point(360, 48)
        Me.botAntecedentesQuirurgicos.Name = "botAntecedentesQuirurgicos"
        Me.botAntecedentesQuirurgicos.Size = New System.Drawing.Size(224, 23)
        Me.botAntecedentesQuirurgicos.TabIndex = 4
        Me.botAntecedentesQuirurgicos.Text = "Antecedentes Quirúrgicos"
        '
        'botAntecedentesGinecologicos
        '
        Me.botAntecedentesGinecologicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAntecedentesGinecologicos.Image = CType(resources.GetObject("botAntecedentesGinecologicos.Image"), System.Drawing.Image)
        Me.botAntecedentesGinecologicos.Location = New System.Drawing.Point(713, 19)
        Me.botAntecedentesGinecologicos.Name = "botAntecedentesGinecologicos"
        Me.botAntecedentesGinecologicos.Size = New System.Drawing.Size(224, 23)
        Me.botAntecedentesGinecologicos.TabIndex = 2
        Me.botAntecedentesGinecologicos.Text = "Antecedentes Ginecológicos"
        '
        'botAntecedentesObstetricos
        '
        Me.botAntecedentesObstetricos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAntecedentesObstetricos.Image = CType(resources.GetObject("botAntecedentesObstetricos.Image"), System.Drawing.Image)
        Me.botAntecedentesObstetricos.Location = New System.Drawing.Point(12, 48)
        Me.botAntecedentesObstetricos.Name = "botAntecedentesObstetricos"
        Me.botAntecedentesObstetricos.Size = New System.Drawing.Size(224, 23)
        Me.botAntecedentesObstetricos.TabIndex = 3
        Me.botAntecedentesObstetricos.Text = "Antecedentes Obstétricos"
        '
        'txtAntecedentesGeneral
        '
        Me.txtAntecedentesGeneral.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntecedentesGeneral.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntecedentesGeneral.Location = New System.Drawing.Point(12, 107)
        Me.txtAntecedentesGeneral.MaxLength = 2000
        Me.txtAntecedentesGeneral.Multiline = True
        Me.txtAntecedentesGeneral.Name = "txtAntecedentesGeneral"
        Me.txtAntecedentesGeneral.ReadOnly = True
        Me.txtAntecedentesGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntecedentesGeneral.Size = New System.Drawing.Size(925, 230)
        Me.txtAntecedentesGeneral.TabIndex = 6
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(96, 26)
        Me.txtDireccion.MaxLength = 47
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(512, 20)
        Me.txtDireccion.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Dirección"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGradoDeInstruccion
        '
        Me.txtGradoDeInstruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGradoDeInstruccion.Location = New System.Drawing.Point(96, 50)
        Me.txtGradoDeInstruccion.MaxLength = 50
        Me.txtGradoDeInstruccion.Name = "txtGradoDeInstruccion"
        Me.txtGradoDeInstruccion.Size = New System.Drawing.Size(221, 20)
        Me.txtGradoDeInstruccion.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "° de Instrucción"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReligion
        '
        Me.txtReligion.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReligion.Location = New System.Drawing.Point(387, 52)
        Me.txtReligion.MaxLength = 50
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.Size = New System.Drawing.Size(221, 18)
        Me.txtReligion.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(336, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Religión"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCiaDeSeguros
        '
        Me.txtCiaDeSeguros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiaDeSeguros.Location = New System.Drawing.Point(716, 50)
        Me.txtCiaDeSeguros.MaxLength = 50
        Me.txtCiaDeSeguros.Name = "txtCiaDeSeguros"
        Me.txtCiaDeSeguros.Size = New System.Drawing.Size(221, 20)
        Me.txtCiaDeSeguros.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(628, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Cia. de Seguros"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFamiliarNombre
        '
        Me.txtFamiliarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamiliarNombre.Location = New System.Drawing.Point(96, 74)
        Me.txtFamiliarNombre.MaxLength = 50
        Me.txtFamiliarNombre.Name = "txtFamiliarNombre"
        Me.txtFamiliarNombre.Size = New System.Drawing.Size(512, 20)
        Me.txtFamiliarNombre.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Familiar"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFamiliarParentesco
        '
        Me.txtFamiliarParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamiliarParentesco.Location = New System.Drawing.Point(716, 74)
        Me.txtFamiliarParentesco.MaxLength = 50
        Me.txtFamiliarParentesco.Name = "txtFamiliarParentesco"
        Me.txtFamiliarParentesco.Size = New System.Drawing.Size(221, 20)
        Me.txtFamiliarParentesco.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(649, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Parentesco"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFamiliarOcupacion
        '
        Me.txtFamiliarOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamiliarOcupacion.Location = New System.Drawing.Point(96, 98)
        Me.txtFamiliarOcupacion.MaxLength = 50
        Me.txtFamiliarOcupacion.Name = "txtFamiliarOcupacion"
        Me.txtFamiliarOcupacion.Size = New System.Drawing.Size(357, 20)
        Me.txtFamiliarOcupacion.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Ocupación"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFamiliarTelefono
        '
        Me.txtFamiliarTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamiliarTelefono.Location = New System.Drawing.Point(532, 98)
        Me.txtFamiliarTelefono.MaxLength = 10
        Me.txtFamiliarTelefono.Name = "txtFamiliarTelefono"
        Me.txtFamiliarTelefono.Size = New System.Drawing.Size(84, 20)
        Me.txtFamiliarTelefono.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(459, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Teléfono :  0"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtFamiliarTelefono)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtFamiliarOcupacion)
        Me.GroupBox1.Controls.Add(Me.txtGradoDeInstruccion)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtFamiliarParentesco)
        Me.GroupBox1.Controls.Add(Me.txtReligion)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtFamiliarNombre)
        Me.GroupBox1.Controls.Add(Me.txtCiaDeSeguros)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 136)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Adicionales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNombrePaciente)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtFechaNacimiento)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtEdad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCedula)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtProfesion)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(970, 76)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Básicos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.botAntecedentesFamiliares)
        Me.GroupBox3.Controls.Add(Me.botAntecedentesPersonales)
        Me.GroupBox3.Controls.Add(Me.botAntecedentesGinecologicos)
        Me.GroupBox3.Controls.Add(Me.txtAntecedentesGeneral)
        Me.GroupBox3.Controls.Add(Me.botAntecedentesObstetricos)
        Me.GroupBox3.Controls.Add(Me.botAntecedentesQuirurgicos)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(970, 357)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Antecedentes"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Resumen de los Antecedentes"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Datos_Personales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.botCancelar)
        Me.Controls.Add(Me.botAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Datos_Personales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Personales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim DP As Form1.DatosPersonales

    Dim booDatosModificados As Boolean



    Dim strArchivoHistoriaHIS As String
    Dim strArchivoDatosPersonales As String
   
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image

    Dim strAntecedentesFamiliares As String
    Dim strAntecedentesPersonales As String
    Dim strAntecedentesGinecologicos As String
    Dim strAntecedentesObstetricos As String
    Dim strAntecedentesQuirurgicos As String
    Dim strAntecedentesGeneral As String


    Private Sub Datos_Personales_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        If DP.FechaNacimiento <> "" Then
            botCancelar.Focus()
        Else
            txtFechaNacimiento.Focus()
        End If
    End Sub



    Private Sub Datos_Personales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'inicializa la variable q registra cambios en la fecha de nacimiento
        Form1.booFechaNacimientoModificada = False
        ConstruyeNombresArchivos()
        If File.Exists(strArchivoDatosPersonales) = True Then
            MostrarContenido()
        Else
            InicializaDatos()
        End If

    End Sub


    Private Sub ConstruyeNombresArchivos()

        strArchivoHistoriaHIS = Form1.PSstrArchivoHistoriaHIS
        'contruye el nombre del archivo con los datos personales
        strArchivoDatosPersonales = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Datos Personales.dat"
     
        'le pone nombre al titulo
        Me.Text = "Datos Personales de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"

        'nombre de los graficos
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff
        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
        BarraSinMensaje = Form1.BarraSinMensaje
    End Sub


    Private Sub MostrarContenido()
        'subrutina que mostrara el contenido almacenado en disco de esta ventana
        Dim BR As BinaryReader
        Dim FS As FileStream

        'carga los datos personales almacenados ya se verifico la existencia del archivo
        FS = New FileStream(strArchivoDatosPersonales, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)


        DP = Nothing
        ' los items con asterisco no tienen relevancia porq se usan los de form1
        DP.a01Nombre = BR.ReadString ' *
        DP.FechaNacimiento = BR.ReadString
        DP.Edad = BR.ReadString '*
        DP.Cedula = BR.ReadString '*
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

        'muestra los datos personales en sus respectivas casillas
        booDatosModificados = False

        txtNombrePaciente.Text = Form1.PSstrPacienteSeleccionadaNombre
        txtCedula.Text = Form1.PSstrPacienteSeleccionadaCedula

        If IsDate(DP.FechaNacimiento) Then
            txtFechaNacimiento.Text = CType(DP.FechaNacimiento, Date).ToShortDateString
            CalculaEdadActual() 'si todo va bien mostrara la edad
        Else
            'revisa si estaba vacio o habia una dato malo
            If DP.FechaNacimiento = "" Then
                'estaba vacio pone vacio la edad y la fecha pero no prende el boton aceptar
                txtFechaNacimiento.Text = ""
                txtEdad.Text = ""
            Else
                'habia una fecha mala se debe blanquear y prender el boton aceptar da un mensaje
                txtFechaNacimiento.Text = ""
                txtEdad.Text = ""
                MsgBox("Se descartó la fecha de nacimiento incluida en los registros por tener una falla de formato, corrígela", MsgBoxStyle.Information)
                'hubo modificacion prende botones
                botAceptar.Enabled = True
                botCancelar.Text = "Descartar Cambios"
                booDatosModificados = True

            End If

        End If

        txtProfesion.Text = DP.Profesion
        txtTelefono.Text = DP.Telefono

        txtDireccion.Text = DP.x01DireccionDeHabitacion
        txtGradoDeInstruccion.Text = DP.x02GradoDeInstruccion
        txtReligion.Text = DP.x03Religion
        txtCiaDeSeguros.Text = DP.x04CiaDeSeguros
        txtFamiliarNombre.Text = DP.x05FamiliarNombre
        txtFamiliarParentesco.Text = DP.x06FamiliarParentesco
        txtFamiliarTelefono.Text = DP.x07FamiliarCelular
        txtFamiliarOcupacion.Text = DP.x08FamiliarOcupacion

        strAntecedentesFamiliares = DP.AntecedentesFamiliares
        strAntecedentesPersonales = DP.AntecedentesPersonales
        strAntecedentesGinecologicos = DP.AntecedentesGinecologicos
        strAntecedentesObstetricos = DP.AntecedentesObstetricos
        strAntecedentesQuirurgicos = DP.AntecedentesQuirurgicos

        '=============================================
        'actualiza desde los antecedentes  propiamente
        subBuscaParidadDeLaPacienteSeleccionada()
        If strAntecedentesObstetricos = Form1.PSstrResultadoAntecedentesObstetricos Then
            'no hubo cambios no hace nada
        Else
            'se actualizaron automaticamente prende los botones de salvar
            strAntecedentesObstetricos = Form1.PSstrResultadoAntecedentesObstetricos
            'subEnsamblaAntecedentes()
            'se acetaron cambios
            botAceptar.Enabled = True
            botCancelar.Text = "Descartar Cambios"
            booDatosModificados = True
        End If

        'actualiza desde los antecedentes  propiamente, prende la bandera de q solo va a consultar
        Form1.PSbooConsultaAntecedentesFamiliares = True

        Dim dlgAF As New FormAntecedentesFamiliares()
        If dlgAF.ShowDialog = Windows.Forms.DialogResult.OK Then
            If strAntecedentesFamiliares = Form1.PSstrResultadoAntecedentesFamiliares Then
                'no hubo cambios no hace nada
            Else
                'se actualizaron automaticamente prende los botones de salvar
                strAntecedentesFamiliares = Form1.PSstrResultadoAntecedentesFamiliares
                'subEnsamblaAntecedentes()
                'se acetaron cambios
                botAceptar.Enabled = True
                botCancelar.Text = "Descartar Cambios"
                booDatosModificados = True
            End If

        End If

        'actualiza desde los antecedentes  propiamente, prende la bandera de q solo va a consultar
        Form1.PSbooConsultaAntecedentesPersonales = True

        Dim dlgAP As New FormAntecedentesPersonales()
        If dlgAP.ShowDialog = Windows.Forms.DialogResult.OK Then
            If strAntecedentesPersonales = Form1.PSstrResultadoAntecedentesPersonales Then
                'no hubo cambios no hace nada
            Else
                'se actualizaron automaticamente prende los botones de salvar
                strAntecedentesPersonales = Form1.PSstrResultadoAntecedentesPersonales
                'subEnsamblaAntecedentes()
                'se acetaron cambios
                botAceptar.Enabled = True
                botCancelar.Text = "Descartar Cambios"
                booDatosModificados = True
            End If

        End If

        'actualiza desde los antecedentes  propiamente, prende la bandera de q solo va a consultar
        Form1.PSbooConsultaAntecedentesGinecologicos = True

        Dim dlgAG As New FormAntecedentesGinecologicos()
        If dlgAG.ShowDialog = Windows.Forms.DialogResult.OK Then
            If strAntecedentesGinecologicos = Form1.PSstrResultadoAntecedentesGinecologicos Then
                'no hubo cambios no hace nada
            Else
                'se actualizaron automaticamente prende los botones de salvar
                strAntecedentesGinecologicos = Form1.PSstrResultadoAntecedentesGinecologicos
                'subEnsamblaAntecedentes()
                'se acetaron cambios
                botAceptar.Enabled = True
                botCancelar.Text = "Descartar Cambios"
                booDatosModificados = True
            End If

        End If

        'actualiza desde los antecedentes  propiamente, prende la bandera de q solo va a consultar
        Form1.PSbooConsultaAntecedentesQuirurgicos = True

        Dim dlgAQ As New FormAntecedentesQuirurgicos()
        If dlgAQ.ShowDialog = Windows.Forms.DialogResult.OK Then
            If strAntecedentesQuirurgicos = Form1.PSstrResultadoAntecedentesQuirurgicos Then
                'no hubo cambios no hace nada
            Else
                'se actualizaron automaticamente prende los botones de salvar
                strAntecedentesQuirurgicos = Form1.PSstrResultadoAntecedentesQuirurgicos
                'subEnsamblaAntecedentes()
                'se acetaron cambios
                botAceptar.Enabled = True
                botCancelar.Text = "Descartar Cambios"
                booDatosModificados = True
            End If

        End If


        '= ENSAMBLA FINALMENTE LOS ANTECEDENTES=============================================
        subEnsamblaAntecedentes()

    End Sub

    'VARIABLES DE LA BUSQUEDA DE ANT OBSTETRICOS la crea aca afuera para q pueda ser pasada entre procedimientos no requiere una als porq es una sola
    Dim AO As Form1.TablaDeAntecedentesObstetricos
    'inicializa los valores
    Dim intNumeroGestaciones = 0
    Dim intNumeroAbortos = 0
    Dim intNumeroPartos = 0
    Dim intNumeroCesareas = 0
    Dim intNumeroEctopicos = 0
    Private Sub subBuscaParidadDeLaPacienteSeleccionada()

        'crea el nombre del archivo de antecedentes 
        Dim strArchivoAntObstetricos = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Obstetricos.dat"



        'inicializa la variable de respuesta local
        Form1.PSstrResultadoAntecedentesObstetricos = ""

        If File.Exists(strArchivoAntObstetricos) = True Then 'existe un archivo lo carga

            'Carga el registro previo de antecedentes familiares
            CargaAntecedentesObstetricos()
            'actualiza los datos numericos con la estructura
            ActualizaDatosNumericosConLaEstructura()
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
        Dim strArchivoAntObstetricos = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Obstetricos.dat"
        'ojo ya se verifico q si existia
        FS = New FileStream(strArchivoAntObstetricos, FileMode.Open, FileAccess.Read)
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


    Private Sub subEnsamblaAntecedentes() 'ensambla antecedentes en una sola ventana

        'limpia variables
        strAntecedentesGeneral = ""
        txtAntecedentesGeneral.Clear()

        'ensambla
        If strAntecedentesFamiliares <> "" Then
            strAntecedentesGeneral += "ANTECEDENTES FAMILIARES: " & strAntecedentesFamiliares & vbCrLf
        End If
        If strAntecedentesPersonales <> "" Then
            strAntecedentesGeneral += "ANTECEDENTES PERSONALES: " & strAntecedentesPersonales & vbCrLf
        End If
        If strAntecedentesGinecologicos <> "" Then
            strAntecedentesGeneral += "ANTECEDENTES GINECOLOGICOS: " & strAntecedentesGinecologicos & vbCrLf
        End If
        If strAntecedentesObstetricos <> "" Then
            strAntecedentesGeneral += "ANTECEDENTES OBSTETRICOS: " & strAntecedentesObstetricos & vbCrLf
        End If
        If strAntecedentesQuirurgicos <> "" Then
            strAntecedentesGeneral += "ANTECEDENTES QUIRURGICOS: " & strAntecedentesQuirurgicos & vbCrLf
        End If
        'muestra resultados
        txtAntecedentesGeneral.Text = strAntecedentesGeneral

    End Sub

    Private Sub InicializaDatos()
        'inicializa la ventana de datos personales cuando se esta creando por primera vez solo las q tienen datos
        txtNombrePaciente.Text = Form1.PSstrPacienteSeleccionadaNombre
        txtCedula.Text = Form1.PSstrPacienteSeleccionadaCedula

        'y las variables
        strAntecedentesFamiliares = ""
        strAntecedentesGinecologicos = ""
        strAntecedentesQuirurgicos = ""
        strAntecedentesObstetricos = ""
        strAntecedentesPersonales = ""
        strAntecedentesGeneral = ""

        'y sincroniza la estructura
        DP.a01Nombre = Form1.PSstrPacienteSeleccionadaNombre
        DP.FechaNacimiento = ""
        DP.Edad = ""
        DP.Cedula = Form1.PSstrPacienteSeleccionadaCedula
        DP.Profesion = ""
        DP.Telefono = ""
        DP.AntecedentesFamiliares = strAntecedentesFamiliares
        DP.AntecedentesPersonales = strAntecedentesPersonales
        DP.AntecedentesGinecologicos = strAntecedentesGinecologicos
        DP.AntecedentesObstetricos = strAntecedentesObstetricos
        DP.AntecedentesQuirurgicos = strAntecedentesQuirurgicos
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

        'ahora de una vez escribe los datos en blanco para crear el archivo de una
        Dim BW As BinaryWriter
        Dim FS As FileStream

        'pasa al disco los datos
        FS = New FileStream(strArchivoDatosPersonales, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(DP.a01Nombre)
        BW.Write(DP.FechaNacimiento)
        BW.Write(DP.Edad)
        BW.Write(DP.Cedula)
        BW.Write(DP.Profesion)
        BW.Write(DP.Telefono)
        BW.Write(DP.AntecedentesFamiliares)
        BW.Write(DP.AntecedentesPersonales)
        BW.Write(DP.AntecedentesGinecologicos)
        BW.Write(DP.AntecedentesObstetricos)
        BW.Write(DP.AntecedentesQuirurgicos)
        BW.Write(DP.x01DireccionDeHabitacion)
        BW.Write(DP.x02GradoDeInstruccion)
        BW.Write(DP.x03Religion)
        BW.Write(DP.x04CiaDeSeguros)
        BW.Write(DP.x05FamiliarNombre)
        BW.Write(DP.x06FamiliarParentesco)
        BW.Write(DP.x07FamiliarCelular)
        BW.Write(DP.x08FamiliarOcupacion)
        BW.Write(DP.z01)
        BW.Write(DP.z02)
        BW.Write(DP.z03)
        BW.Write(DP.z04)
        BW.Write(DP.z05)
        BW.Write(DP.z06)
        BW.Write(DP.z07)
        BW.Write(DP.z08)
        BW.Write(DP.z09)
        BW.Write(DP.z10)

        FS.Close()
        BW.Close()

        'apaga la bandera de cambios
        booDatosModificados = False



    End Sub


    Private Sub txtFechaNacimiento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFechaNacimiento.Leave

        If IsDate(txtFechaNacimiento.Text) Then
            txtFechaNacimiento.Text = CType(txtFechaNacimiento.Text, Date).ToShortDateString
            CalculaEdadActual() 'si todo va bien mostrara la fecha de nac y la edad
        Else
            txtFechaNacimiento.Text = ""
            txtEdad.Text = ""
        End If

    End Sub

    Private Sub CalculaEdadActual()
        Dim edad As Integer
        Dim fechaNacimiento As Date
        Dim Reply As MsgBoxResult

        'ya se verifico que el dato era fecha.....
        fechaNacimiento = CType(txtFechaNacimiento.Text, Date)
        edad = (DateDiff(DateInterval.Day, fechaNacimiento, Today())) + 1
        edad = edad * 100 \ 36525
        If edad < 1 Then
            MsgBox("La fecha de nacimiento introducida es erronea, según ésta la paciente está recien nacida o aún no ha nacido...", MsgBoxStyle.Information)
            txtFechaNacimiento.Text = ""
            txtEdad.Text = ""
            Exit Sub
        ElseIf edad < 3 Then
            MsgBox("Introduce una fecha de nacimiento válida... (¿Es la paciente una lactante?)", MsgBoxStyle.Information)
            txtFechaNacimiento.Text = ""
            txtEdad.Text = ""
            Exit Sub
        ElseIf edad < 10 Then
            Reply = MsgBox("Según la Fecha de Nacimiento introducida, la paciente tiene " & edad & " años." & vbCrLf & "Para confirmar esta fecha presiona Aceptar...", MsgBoxStyle.OkCancel)
            If Reply = MsgBoxResult.Ok Then
                txtEdad.Text = edad.ToString
                txtFechaNacimiento.Text = fechaNacimiento.ToShortDateString
            Else
                txtFechaNacimiento.Text = ""
                txtEdad.Text = ""
                Exit Sub
            End If
        Else 'entonces la paciente tiene mas de 9 años y se introdujo la fecha bien
            txtEdad.Text = edad.ToString
        End If

    End Sub



    Private Sub txtFechaNacimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFechaNacimiento.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "-" Or c = "/") Then
            e.Handled = True
        Else
            botAceptar.Enabled = True
            botCancelar.Text = "Descartar Cambios"
            booDatosModificados = True
            Form1.booFechaNacimientoModificada = True
        End If
    End Sub


    Private Sub TodosLosTextos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProfesion.KeyPress, _
                txtDireccion.KeyPress, txtGradoDeInstruccion.KeyPress, txtReligion.KeyPress, txtCiaDeSeguros.KeyPress, txtFamiliarNombre.KeyPress, _
                txtFamiliarOcupacion.KeyPress, txtFamiliarParentesco.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c) Or Char.IsPunctuation(c) Or c = "-" Or c = "(" Or c = ")") Then
            e.Handled = True
        Else
            botAceptar.Enabled = True
            botCancelar.Text = "Descartar Cambios"
            booDatosModificados = True
        End If
    End Sub

    Dim booSeModificoElTelefono As Boolean = False
    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            'se modifico el telefono
            booSeModificoElTelefono = True
            botAceptar.Enabled = True
            botCancelar.Text = "Descartar Cambios"
            booDatosModificados = True
        End If
    End Sub

    Private Sub txtFamiliarTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFamiliarTelefono.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            botAceptar.Enabled = True
            botCancelar.Text = "Descartar Cambios"
            booDatosModificados = True
        End If
    End Sub

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim LineaDatos As String

        'guarda los datos al archivo de datos personales
        EscribeDatosPersonales()

        'si se aceptaron los datos se considera q fue verificado, se dejo igual o se modificara se dice que esta actualizado
        Form1.PSbooSeModificoElTelefono = True
        ''actualiza la fecha de verificacion del celular/telefono si este fue modificado
        'If booSeModificoElTelefono = True Then
        '    'hubo modificacion en el telefono y fueron aceptadas prende la bandera publica...
        '    Form1.PSbooSeModificoElTelefono = True
        'End If

        'actualiza el contenidop de la historia (anacronico) se deberia buscar alternativas a esta comprobacion
        If Form1.ExisteDatosPersonales = True Then
            'modificacion para el respaldo de archivos
            Form1.SeModificaronDatos = True
        Else
            'no existe un control previo debe actualizar la array subhistorias
            LineaDatos = Form1.PSstrNumeroHistoriaSeleccionada & "-Datos Personales"
            Form1.ElementosHistoria.Add(LineaDatos)

            FS = New FileStream(strArchivoHistoriaHIS, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)

            'pone el archivo al inicio
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            For Each Str As String In Form1.ElementosHistoria
                BW.Write(Str)
            Next

            'cierra todo
            FS.Close()
            BW.Close()

            'modificacion para el respaldo de archivos
            Form1.SeModificaronDatos = True


        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click

        If booDatosModificados = True Then
            'se van a perder los datos, pregunta para confirmar
            Dim reply As MsgBoxResult
            reply = MsgBox("Se perderan las últimas modificaciones realizadas, para confirmar presiona aceptar...", MsgBoxStyle.OKCancel, "Confirmar")

            If reply = MsgBoxResult.OK Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                'se arrepintio deja abierta la vaina
            End If
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub EscribeDatosPersonales()
        Dim BW As BinaryWriter
        Dim FS As FileStream

        'actualiza la estructura con los datos en pantalla
        DP.a01Nombre = Form1.PSstrPacienteSeleccionadaNombre
        DP.FechaNacimiento = txtFechaNacimiento.Text
        DP.Edad = txtEdad.Text
        DP.Cedula = Form1.PSstrPacienteSeleccionadaCedula
        DP.Profesion = txtProfesion.Text
        DP.Telefono = txtTelefono.Text
        DP.AntecedentesFamiliares = strAntecedentesFamiliares
        DP.AntecedentesPersonales = strAntecedentesPersonales
        DP.AntecedentesGinecologicos = strAntecedentesGinecologicos
        DP.AntecedentesObstetricos = strAntecedentesObstetricos
        DP.AntecedentesQuirurgicos = strAntecedentesQuirurgicos
        DP.x01DireccionDeHabitacion = txtDireccion.Text
        DP.x02GradoDeInstruccion = txtGradoDeInstruccion.Text
        DP.x03Religion = txtReligion.Text
        DP.x04CiaDeSeguros = txtCiaDeSeguros.Text
        DP.x05FamiliarNombre = txtFamiliarNombre.Text
        DP.x06FamiliarParentesco = txtFamiliarParentesco.Text
        DP.x07FamiliarCelular = txtFamiliarTelefono.Text
        DP.x08FamiliarOcupacion = txtFamiliarOcupacion.Text
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

        'pasa al disco los datos
        FS = New FileStream(strArchivoDatosPersonales, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(DP.a01Nombre)
        BW.Write(DP.FechaNacimiento)
        BW.Write(DP.Edad)
        BW.Write(DP.Cedula)
        BW.Write(DP.Profesion)
        BW.Write(DP.Telefono)
        BW.Write(DP.AntecedentesFamiliares)
        BW.Write(DP.AntecedentesPersonales)
        BW.Write(DP.AntecedentesGinecologicos)
        BW.Write(DP.AntecedentesObstetricos)
        BW.Write(DP.AntecedentesQuirurgicos)
        BW.Write(DP.x01DireccionDeHabitacion)
        BW.Write(DP.x02GradoDeInstruccion)
        BW.Write(DP.x03Religion)
        BW.Write(DP.x04CiaDeSeguros)
        BW.Write(DP.x05FamiliarNombre)
        BW.Write(DP.x06FamiliarParentesco)
        BW.Write(DP.x07FamiliarCelular)
        BW.Write(DP.x08FamiliarOcupacion)
        BW.Write(DP.z01)
        BW.Write(DP.z02)
        BW.Write(DP.z03)
        BW.Write(DP.z04)
        BW.Write(DP.z05)
        BW.Write(DP.z06)
        BW.Write(DP.z07)
        BW.Write(DP.z08)
        BW.Write(DP.z09)
        BW.Write(DP.z10)

        FS.Close()
        BW.Close()

    End Sub

    Private Sub botAntecedentesFamiliares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAntecedentesFamiliares.Click
        Dim dlg As New FormAntecedentesFamiliares()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            strAntecedentesFamiliares = Form1.PSstrResultadoAntecedentesFamiliares
            subEnsamblaAntecedentes()
            'se acetaron cambios
            'botAceptar.Enabled = True
            botCancelar.Text = "Descartar Cambios"
            booDatosModificados = True
        End If
    End Sub

    Private Sub botAntecedentesPersonales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAntecedentesPersonales.Click
        Dim dlg As New FormAntecedentesPersonales()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            strAntecedentesPersonales = Form1.PSstrResultadoAntecedentesPersonales
            subEnsamblaAntecedentes()
            'se acetaron cambios
            'botAceptar.Enabled = True
            botCancelar.Text = "Descartar Cambios"
            booDatosModificados = True
        End If
    End Sub

    Private Sub botAntecedentesQuirurgicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAntecedentesQuirurgicos.Click
        Dim dlg As New FormAntecedentesQuirurgicos()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            strAntecedentesQuirurgicos = Form1.PSstrResultadoAntecedentesQuirurgicos
            subEnsamblaAntecedentes()
            'se acetaron cambios
            'botAceptar.Enabled = True
            botCancelar.Text = "Descartar Cambios"
            booDatosModificados = True
        End If
    End Sub

    Private Sub botAntecedentesGinecologicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAntecedentesGinecologicos.Click
        Dim dlg As New FormAntecedentesGinecologicos()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            strAntecedentesGinecologicos = Form1.PSstrResultadoAntecedentesGinecologicos
            subEnsamblaAntecedentes()
            'se acetaron cambios
            'botAceptar.Enabled = True
            botCancelar.Text = "Descartar Cambios"
            booDatosModificados = True
        End If
    End Sub

    Private Sub botAntecedentesObstetricos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAntecedentesObstetricos.Click
        Dim dlg As New FormAntObstetricos()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            strAntecedentesObstetricos = Form1.PSstrResultadoAntecedentesObstetricos
            subEnsamblaAntecedentes()
            'se acetaron cambios
            'botAceptar.Enabled = True
            botCancelar.Text = "Descartar Cambios"
            booDatosModificados = True
        End If
    End Sub

    Private Sub botAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseEnter
        botAceptar.Image = BotonOnGrande
    End Sub
    Private Sub botAceptar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseLeave
        botAceptar.Image = BotonOffGrande
    End Sub
    Private Sub botcancelar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseEnter
        botCancelar.Image = BotonOnGrande
    End Sub
    Private Sub botcancelar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseLeave
        botCancelar.Image = BotonOffGrande
    End Sub
    Private Sub botantecedentesfamiliares_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAntecedentesFamiliares.MouseEnter
        botAntecedentesFamiliares.Image = BotonOnGrande
    End Sub
    Private Sub botantecedentesfamiliares_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAntecedentesFamiliares.MouseLeave
        botAntecedentesFamiliares.Image = BotonOffGrande
    End Sub
    Private Sub botantecedentespersonales_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAntecedentesPersonales.MouseEnter
        botAntecedentesPersonales.Image = BotonOnGrande
    End Sub
    Private Sub botantecedentespersonales_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAntecedentesPersonales.MouseLeave
        botAntecedentesPersonales.Image = BotonOffGrande
    End Sub
    Private Sub botantecedentesginecologicos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAntecedentesGinecologicos.MouseEnter
        botAntecedentesGinecologicos.Image = BotonOnGrande
    End Sub
    Private Sub botantecedentesginecologicos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAntecedentesGinecologicos.MouseLeave
        botAntecedentesGinecologicos.Image = BotonOffGrande
    End Sub
    Private Sub botantecedentesobstetricos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAntecedentesObstetricos.MouseEnter
        botAntecedentesObstetricos.Image = BotonOnGrande
    End Sub
    Private Sub botantecedentesobstetricos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAntecedentesObstetricos.MouseLeave
        botAntecedentesObstetricos.Image = BotonOffGrande
    End Sub
    Private Sub botantecedentesquirurgicos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAntecedentesQuirurgicos.MouseEnter
        botAntecedentesQuirurgicos.Image = BotonOnGrande
    End Sub
    Private Sub botantecedentesquirurgicos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAntecedentesQuirurgicos.MouseLeave
        botAntecedentesQuirurgicos.Image = BotonOffGrande
    End Sub
























End Class
