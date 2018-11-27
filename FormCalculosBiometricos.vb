Public Class FormCalculosBiometricos
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents labEGxCA As System.Windows.Forms.Label
    Friend WithEvents labPesoTEXT As System.Windows.Forms.Label
    Friend WithEvents labPesoEstimado As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents labIndCef As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txtTransAbdomen As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents LabEdadEcografica2y3erT As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents labEGxFemur As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents labEGxCC As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents labEGxDBPc As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents labEGxDBP As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents labDBF As System.Windows.Forms.Label
    Friend WithEvents txtFemur As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents labCirAbd As System.Windows.Forms.Label
    Friend WithEvents txtAPA As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents labCirCef As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents labDBPc As System.Windows.Forms.Label
    Friend WithEvents txtDOF As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtDBP As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabEdadEcografica1erT As System.Windows.Forms.Label
    Friend WithEvents labEGxLCC As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtLCC As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSGtransversal As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents labSGpromedio As System.Windows.Forms.Label
    Friend WithEvents txtSGanteroposterior As System.Windows.Forms.TextBox
    Friend WithEvents txtSGlongitudinal As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents labEGxSG As System.Windows.Forms.Label
    Friend WithEvents botSalirSinGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormCalculosBiometricos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.labEGxCA = New System.Windows.Forms.Label()
        Me.labPesoTEXT = New System.Windows.Forms.Label()
        Me.labPesoEstimado = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.labIndCef = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtTransAbdomen = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.LabEdadEcografica2y3erT = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.labEGxFemur = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.labEGxCC = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.labEGxDBPc = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.labEGxDBP = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.labDBF = New System.Windows.Forms.Label()
        Me.txtFemur = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.labCirAbd = New System.Windows.Forms.Label()
        Me.txtAPA = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.labCirCef = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.labDBPc = New System.Windows.Forms.Label()
        Me.txtDOF = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtDBP = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabEdadEcografica1erT = New System.Windows.Forms.Label()
        Me.labEGxLCC = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtLCC = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSGtransversal = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.labSGpromedio = New System.Windows.Forms.Label()
        Me.txtSGanteroposterior = New System.Windows.Forms.TextBox()
        Me.txtSGlongitudinal = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labEGxSG = New System.Windows.Forms.Label()
        Me.botSalirSinGuardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label67, Me.Label104, Me.Label103, Me.Label102, Me.Label101, Me.Label100, Me.Label99, Me.Label95, Me.Label94, Me.Label91, Me.Label90, Me.Label89, Me.labEGxCA, Me.labPesoTEXT, Me.labPesoEstimado, Me.Label76, Me.labIndCef, Me.Label71, Me.txtTransAbdomen, Me.GroupBox11, Me.Label65, Me.labEGxFemur, Me.Label63, Me.labEGxCC, Me.Label61, Me.labEGxDBPc, Me.Label59, Me.labEGxDBP, Me.Label57, Me.labDBF, Me.txtFemur, Me.Label56, Me.Label51, Me.labCirAbd, Me.txtAPA, Me.Label50, Me.Label45, Me.labCirCef, Me.Label40, Me.labDBPc, Me.txtDOF, Me.Label37, Me.txtDBP, Me.Label34})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 264)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "2do y 3er Trimestre"
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(728, 154)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(16, 23)
        Me.Label67.TabIndex = 148
        Me.Label67.Text = "g"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label104
        '
        Me.Label104.Location = New System.Drawing.Point(320, 66)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(72, 23)
        Me.Label104.TabIndex = 147
        Me.Label104.Text = "VN: 79% +-8"
        Me.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label103
        '
        Me.Label103.Location = New System.Drawing.Point(320, 114)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(32, 23)
        Me.Label103.TabIndex = 146
        Me.Label103.Text = "mm"
        Me.Label103.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label102
        '
        Me.Label102.Location = New System.Drawing.Point(320, 90)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(32, 23)
        Me.Label102.TabIndex = 145
        Me.Label102.Text = "mm"
        Me.Label102.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label101
        '
        Me.Label101.Location = New System.Drawing.Point(320, 42)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(32, 23)
        Me.Label101.TabIndex = 144
        Me.Label101.Text = "mm"
        Me.Label101.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label100
        '
        Me.Label100.Location = New System.Drawing.Point(320, 18)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(32, 23)
        Me.Label100.TabIndex = 143
        Me.Label100.Text = "mm"
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label99
        '
        Me.Label99.Location = New System.Drawing.Point(128, 114)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(32, 23)
        Me.Label99.TabIndex = 142
        Me.Label99.Text = "mm"
        Me.Label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label95
        '
        Me.Label95.Location = New System.Drawing.Point(128, 90)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(32, 23)
        Me.Label95.TabIndex = 141
        Me.Label95.Text = "mm"
        Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label94
        '
        Me.Label94.Location = New System.Drawing.Point(128, 66)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(32, 23)
        Me.Label94.TabIndex = 140
        Me.Label94.Text = "mm"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label91
        '
        Me.Label91.Location = New System.Drawing.Point(128, 42)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(32, 23)
        Me.Label91.TabIndex = 139
        Me.Label91.Text = "mm"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label90
        '
        Me.Label90.Location = New System.Drawing.Point(128, 18)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(32, 23)
        Me.Label90.TabIndex = 138
        Me.Label90.Text = "mm"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label89
        '
        Me.Label89.Location = New System.Drawing.Point(424, 90)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(120, 23)
        Me.Label89.TabIndex = 136
        Me.Label89.Text = "EG x Cir. Abdominal :"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labEGxCA
        '
        Me.labEGxCA.BackColor = System.Drawing.SystemColors.Info
        Me.labEGxCA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEGxCA.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEGxCA.Location = New System.Drawing.Point(552, 90)
        Me.labEGxCA.Name = "labEGxCA"
        Me.labEGxCA.Size = New System.Drawing.Size(168, 23)
        Me.labEGxCA.TabIndex = 137
        Me.labEGxCA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPesoTEXT
        '
        Me.labPesoTEXT.Location = New System.Drawing.Point(376, 138)
        Me.labPesoTEXT.Name = "labPesoTEXT"
        Me.labPesoTEXT.Size = New System.Drawing.Size(344, 16)
        Me.labPesoTEXT.TabIndex = 134
        Me.labPesoTEXT.Text = "Peso Estimado (Faltan Datos) :"
        Me.labPesoTEXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labPesoEstimado
        '
        Me.labPesoEstimado.BackColor = System.Drawing.SystemColors.Info
        Me.labPesoEstimado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPesoEstimado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPesoEstimado.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labPesoEstimado.Location = New System.Drawing.Point(552, 154)
        Me.labPesoEstimado.Name = "labPesoEstimado"
        Me.labPesoEstimado.Size = New System.Drawing.Size(168, 23)
        Me.labPesoEstimado.TabIndex = 135
        Me.labPesoEstimado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(200, 66)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(80, 23)
        Me.Label76.TabIndex = 132
        Me.Label76.Text = "Ind. Cefálico :"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labIndCef
        '
        Me.labIndCef.BackColor = System.Drawing.SystemColors.Info
        Me.labIndCef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labIndCef.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labIndCef.Location = New System.Drawing.Point(280, 66)
        Me.labIndCef.Name = "labIndCef"
        Me.labIndCef.Size = New System.Drawing.Size(40, 23)
        Me.labIndCef.TabIndex = 133
        Me.labIndCef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(24, 90)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(72, 23)
        Me.Label71.TabIndex = 111
        Me.Label71.Text = "T. Abdomen"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransAbdomen
        '
        Me.txtTransAbdomen.Location = New System.Drawing.Point(96, 90)
        Me.txtTransAbdomen.MaxLength = 3
        Me.txtTransAbdomen.Name = "txtTransAbdomen"
        Me.txtTransAbdomen.Size = New System.Drawing.Size(32, 20)
        Me.txtTransAbdomen.TabIndex = 112
        Me.txtTransAbdomen.Text = ""
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.AddRange(New System.Windows.Forms.Control() {Me.LabEdadEcografica2y3erT})
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(472, 192)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(288, 52)
        Me.GroupBox11.TabIndex = 131
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Edad Gestacional Promedio x Biometria Fetal"
        '
        'LabEdadEcografica2y3erT
        '
        Me.LabEdadEcografica2y3erT.BackColor = System.Drawing.SystemColors.Info
        Me.LabEdadEcografica2y3erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabEdadEcografica2y3erT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabEdadEcografica2y3erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.LabEdadEcografica2y3erT.Location = New System.Drawing.Point(40, 20)
        Me.LabEdadEcografica2y3erT.Name = "LabEdadEcografica2y3erT"
        Me.LabEdadEcografica2y3erT.Size = New System.Drawing.Size(216, 24)
        Me.LabEdadEcografica2y3erT.TabIndex = 0
        Me.LabEdadEcografica2y3erT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(440, 114)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(104, 23)
        Me.Label65.TabIndex = 129
        Me.Label65.Text = "EG x Fémur :"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labEGxFemur
        '
        Me.labEGxFemur.BackColor = System.Drawing.SystemColors.Info
        Me.labEGxFemur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEGxFemur.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEGxFemur.Location = New System.Drawing.Point(552, 114)
        Me.labEGxFemur.Name = "labEGxFemur"
        Me.labEGxFemur.Size = New System.Drawing.Size(168, 23)
        Me.labEGxFemur.TabIndex = 130
        Me.labEGxFemur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(440, 66)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(104, 23)
        Me.Label63.TabIndex = 127
        Me.Label63.Text = "EG x Cir. Cefálica :"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labEGxCC
        '
        Me.labEGxCC.BackColor = System.Drawing.SystemColors.Info
        Me.labEGxCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEGxCC.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEGxCC.Location = New System.Drawing.Point(552, 66)
        Me.labEGxCC.Name = "labEGxCC"
        Me.labEGxCC.Size = New System.Drawing.Size(168, 23)
        Me.labEGxCC.TabIndex = 128
        Me.labEGxCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(464, 42)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(80, 23)
        Me.Label61.TabIndex = 125
        Me.Label61.Text = "EG x DBPc :"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labEGxDBPc
        '
        Me.labEGxDBPc.BackColor = System.Drawing.SystemColors.Info
        Me.labEGxDBPc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEGxDBPc.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEGxDBPc.Location = New System.Drawing.Point(552, 42)
        Me.labEGxDBPc.Name = "labEGxDBPc"
        Me.labEGxDBPc.Size = New System.Drawing.Size(168, 23)
        Me.labEGxDBPc.TabIndex = 126
        Me.labEGxDBPc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(464, 18)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(80, 23)
        Me.Label59.TabIndex = 123
        Me.Label59.Text = "EG x DBP :"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labEGxDBP
        '
        Me.labEGxDBP.BackColor = System.Drawing.SystemColors.Info
        Me.labEGxDBP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEGxDBP.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEGxDBP.Location = New System.Drawing.Point(552, 18)
        Me.labEGxDBP.Name = "labEGxDBP"
        Me.labEGxDBP.Size = New System.Drawing.Size(168, 23)
        Me.labEGxDBP.TabIndex = 124
        Me.labEGxDBP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(200, 114)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(76, 23)
        Me.Label57.TabIndex = 121
        Me.Label57.Text = "DBF :"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labDBF
        '
        Me.labDBF.BackColor = System.Drawing.SystemColors.Info
        Me.labDBF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDBF.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labDBF.Location = New System.Drawing.Point(280, 114)
        Me.labDBF.Name = "labDBF"
        Me.labDBF.Size = New System.Drawing.Size(40, 23)
        Me.labDBF.TabIndex = 122
        Me.labDBF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFemur
        '
        Me.txtFemur.Location = New System.Drawing.Point(96, 114)
        Me.txtFemur.MaxLength = 3
        Me.txtFemur.Name = "txtFemur"
        Me.txtFemur.Size = New System.Drawing.Size(32, 20)
        Me.txtFemur.TabIndex = 114
        Me.txtFemur.Text = ""
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(24, 114)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(72, 23)
        Me.Label56.TabIndex = 113
        Me.Label56.Text = "Fémur"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(192, 90)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(88, 23)
        Me.Label51.TabIndex = 119
        Me.Label51.Text = "Cir. Abdomen :"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labCirAbd
        '
        Me.labCirAbd.BackColor = System.Drawing.SystemColors.Info
        Me.labCirAbd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCirAbd.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCirAbd.Location = New System.Drawing.Point(280, 90)
        Me.labCirAbd.Name = "labCirAbd"
        Me.labCirAbd.Size = New System.Drawing.Size(40, 23)
        Me.labCirAbd.TabIndex = 120
        Me.labCirAbd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAPA
        '
        Me.txtAPA.Location = New System.Drawing.Point(96, 66)
        Me.txtAPA.MaxLength = 3
        Me.txtAPA.Name = "txtAPA"
        Me.txtAPA.Size = New System.Drawing.Size(32, 20)
        Me.txtAPA.TabIndex = 110
        Me.txtAPA.Text = ""
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(24, 66)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(72, 23)
        Me.Label50.TabIndex = 109
        Me.Label50.Text = "AP.Abdomen"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(200, 42)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(80, 23)
        Me.Label45.TabIndex = 117
        Me.Label45.Text = "Cir. Cefálica :"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labCirCef
        '
        Me.labCirCef.BackColor = System.Drawing.SystemColors.Info
        Me.labCirCef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCirCef.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCirCef.Location = New System.Drawing.Point(280, 42)
        Me.labCirCef.Name = "labCirCef"
        Me.labCirCef.Size = New System.Drawing.Size(40, 23)
        Me.labCirCef.TabIndex = 118
        Me.labCirCef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(200, 18)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(80, 23)
        Me.Label40.TabIndex = 115
        Me.Label40.Text = "DBPc :"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labDBPc
        '
        Me.labDBPc.BackColor = System.Drawing.SystemColors.Info
        Me.labDBPc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDBPc.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labDBPc.Location = New System.Drawing.Point(280, 18)
        Me.labDBPc.Name = "labDBPc"
        Me.labDBPc.Size = New System.Drawing.Size(40, 23)
        Me.labDBPc.TabIndex = 116
        Me.labDBPc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDOF
        '
        Me.txtDOF.Location = New System.Drawing.Point(96, 42)
        Me.txtDOF.MaxLength = 3
        Me.txtDOF.Name = "txtDOF"
        Me.txtDOF.Size = New System.Drawing.Size(32, 20)
        Me.txtDOF.TabIndex = 108
        Me.txtDOF.Text = ""
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(24, 42)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 23)
        Me.Label37.TabIndex = 107
        Me.Label37.Text = "DOF"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDBP
        '
        Me.txtDBP.Location = New System.Drawing.Point(96, 18)
        Me.txtDBP.MaxLength = 3
        Me.txtDBP.Name = "txtDBP"
        Me.txtDBP.Size = New System.Drawing.Size(32, 20)
        Me.txtDBP.TabIndex = 106
        Me.txtDBP.Text = ""
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(24, 18)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 23)
        Me.Label34.TabIndex = 105
        Me.Label34.Text = "DBP"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.labEGxLCC, Me.Label30, Me.txtLCC, Me.Label28, Me.Label9, Me.txtSGtransversal, Me.Label26, Me.labSGpromedio, Me.txtSGanteroposterior, Me.txtSGlongitudinal, Me.Label25, Me.Label17, Me.Label16, Me.Label15, Me.Label8, Me.labEGxSG})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 176)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "1er Trimestre"
        '
        'LabEdadEcografica1erT
        '
        Me.LabEdadEcografica1erT.BackColor = System.Drawing.SystemColors.Info
        Me.LabEdadEcografica1erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabEdadEcografica1erT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabEdadEcografica1erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.LabEdadEcografica1erT.Location = New System.Drawing.Point(40, 16)
        Me.LabEdadEcografica1erT.Name = "LabEdadEcografica1erT"
        Me.LabEdadEcografica1erT.Size = New System.Drawing.Size(216, 23)
        Me.LabEdadEcografica1erT.TabIndex = 35
        Me.LabEdadEcografica1erT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labEGxLCC
        '
        Me.labEGxLCC.BackColor = System.Drawing.SystemColors.Info
        Me.labEGxLCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEGxLCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEGxLCC.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEGxLCC.Location = New System.Drawing.Point(584, 37)
        Me.labEGxLCC.Name = "labEGxLCC"
        Me.labEGxLCC.Size = New System.Drawing.Size(128, 23)
        Me.labEGxLCC.TabIndex = 33
        Me.labEGxLCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(568, 37)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(8, 23)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "="
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLCC
        '
        Me.txtLCC.Location = New System.Drawing.Point(528, 37)
        Me.txtLCC.MaxLength = 3
        Me.txtLCC.Name = "txtLCC"
        Me.txtLCC.Size = New System.Drawing.Size(32, 20)
        Me.txtLCC.TabIndex = 31
        Me.txtLCC.Text = ""
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(456, 37)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 23)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Longitudinal:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(448, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Longitud Craneo Caudal"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSGtransversal
        '
        Me.txtSGtransversal.Location = New System.Drawing.Point(156, 88)
        Me.txtSGtransversal.MaxLength = 3
        Me.txtSGtransversal.Name = "txtSGtransversal"
        Me.txtSGtransversal.Size = New System.Drawing.Size(32, 20)
        Me.txtSGtransversal.TabIndex = 24
        Me.txtSGtransversal.Text = ""
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(196, 120)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(8, 23)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "="
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labSGpromedio
        '
        Me.labSGpromedio.BackColor = System.Drawing.SystemColors.Info
        Me.labSGpromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labSGpromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.labSGpromedio.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labSGpromedio.Location = New System.Drawing.Point(156, 120)
        Me.labSGpromedio.Name = "labSGpromedio"
        Me.labSGpromedio.Size = New System.Drawing.Size(32, 23)
        Me.labSGpromedio.TabIndex = 26
        Me.labSGpromedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSGanteroposterior
        '
        Me.txtSGanteroposterior.Location = New System.Drawing.Point(156, 64)
        Me.txtSGanteroposterior.MaxLength = 3
        Me.txtSGanteroposterior.Name = "txtSGanteroposterior"
        Me.txtSGanteroposterior.Size = New System.Drawing.Size(32, 20)
        Me.txtSGanteroposterior.TabIndex = 22
        Me.txtSGanteroposterior.Text = ""
        '
        'txtSGlongitudinal
        '
        Me.txtSGlongitudinal.Location = New System.Drawing.Point(156, 40)
        Me.txtSGlongitudinal.MaxLength = 3
        Me.txtSGlongitudinal.Name = "txtSGlongitudinal"
        Me.txtSGlongitudinal.Size = New System.Drawing.Size(32, 20)
        Me.txtSGlongitudinal.TabIndex = 20
        Me.txtSGlongitudinal.Text = ""
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label25.Location = New System.Drawing.Point(84, 120)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 23)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Promedio:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(84, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 23)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Transversal:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(84, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 23)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Longitudinal:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(84, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 23)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Antero/Post:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(92, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 23)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Saco Gestacional"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labEGxSG
        '
        Me.labEGxSG.BackColor = System.Drawing.SystemColors.Info
        Me.labEGxSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEGxSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEGxSG.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEGxSG.Location = New System.Drawing.Point(212, 120)
        Me.labEGxSG.Name = "labEGxSG"
        Me.labEGxSG.Size = New System.Drawing.Size(128, 23)
        Me.labEGxSG.TabIndex = 28
        Me.labEGxSG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botSalirSinGuardar
        '
        Me.botSalirSinGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSalirSinGuardar.Image = CType(resources.GetObject("botSalirSinGuardar.Image"), System.Drawing.Bitmap)
        Me.botSalirSinGuardar.Location = New System.Drawing.Point(280, 480)
        Me.botSalirSinGuardar.Name = "botSalirSinGuardar"
        Me.botSalirSinGuardar.Size = New System.Drawing.Size(224, 23)
        Me.botSalirSinGuardar.TabIndex = 20
        Me.botSalirSinGuardar.Text = "Salir"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.LabEdadEcografica1erT})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(472, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 52)
        Me.GroupBox3.TabIndex = 132
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Edad Gestacional Promedio x Biometria Fetal"
        '
        'FormCalculosBiometricos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(794, 520)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.botSalirSinGuardar, Me.GroupBox2, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCalculosBiometricos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo de Edad Gestacional según Biometria Fetal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'estas las utilizo en las cosas del 1er trimestre
    Dim EGxSGenDias As Integer
    Dim EGxLCCenDias As Integer
    Dim EGxECO1erTenDias As Integer

    'estas son del 2 y 3er trimestre
    Dim EGxDBPenDias As Integer
    Dim EGxDBPcenDias As Integer
    Dim EGxCCenDias As Integer
    Dim EGxCAenDias As Integer
    Dim EGxFEMURenDias As Integer

    Dim EGxECO2y3erTenDias As Integer


    'estas tres variables las uso como funcion para devolver semanas y dias de un numero de dias
    Dim NumeroDiasEG As Integer
    Dim TextoDeEGenSemanasyDias As String
    Dim TextoDeFPP As String

    'esta variable es para saber cual es el texto que se utiliza para calcular las EG de los controles sucesivos
    Dim FechaParaVerificar As String
    Dim ResultadoEG As String
    Dim RespaldodeFUR As String

    Dim TablaSG(70) As Integer
    Dim TablaLCC(100) As Integer
    Dim TablaDBP(120) As Integer
    Dim TablaCC(80) As Integer
    Dim TablaCA(80) As Integer
    Dim TablaFemur(100) As Integer

    Dim DatosModificados As Boolean = False

    Private Sub FormCalculosBiometricos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BorraDatos()
        CargaTablas()


    End Sub


    Private Sub BorraDatos()

        'Biometria 1er trimestre
        txtSGlongitudinal.Clear()
        txtSGanteroposterior.Clear()
        txtSGtransversal.Clear()
        labSGpromedio.Text = ""
        labEGxSG.Text = ""
        txtLCC.Clear()
        labEGxLCC.Text = ""
        LabEdadEcografica1erT.Text = ""

        'biometria 2do t 3er trimestre
        txtDBP.Clear()
        txtDOF.Clear()
        txtAPA.Clear()
        txtTransAbdomen.Clear()
        txtFemur.Clear()
        labCirCef.Text = ""
        labIndCef.Text = ""
        labCirAbd.Text = ""
        labPesoEstimado.Text = ""
        labPesoTEXT.Text = "Peso Estimado (Faltan Datos) :"
        labDBF.Text = ""
        labEGxDBP.Text = ""
        labEGxDBPc.Text = ""
        labEGxCC.Text = ""
        labEGxCA.Text = ""
        labEGxFemur.Text = ""
        LabEdadEcografica2y3erT.Text = ""
    End Sub

    Private Sub CargaTablas()
        'variables locales
        Dim t As Integer

        'Tabla de Saco Gestacional  Hansmann (14-29)--------------------------
        For t = 0 To 70
            TablaSG(t) = 0
        Next
        TablaSG(10) = 33 : TablaSG(11) = 34 : TablaSG(12) = 35 : TablaSG(13) = 36
        TablaSG(14) = 37 : TablaSG(15) = 38 : TablaSG(16) = 39 : TablaSG(17) = 40
        TablaSG(18) = 41 : TablaSG(19) = 42 : TablaSG(20) = 43 : TablaSG(21) = 44
        TablaSG(22) = 45 : TablaSG(23) = 46 : TablaSG(24) = 47 : TablaSG(25) = 48
        TablaSG(26) = 49 : TablaSG(27) = 50 : TablaSG(28) = 51 : TablaSG(29) = 52
        TablaSG(30) = 53 : TablaSG(31) = 54 : TablaSG(32) = 55 : TablaSG(33) = 56
        TablaSG(34) = 57 : TablaSG(35) = 58 : TablaSG(36) = 58 : TablaSG(37) = 59
        TablaSG(38) = 60 : TablaSG(39) = 61 : TablaSG(40) = 62 : TablaSG(41) = 63
        TablaSG(42) = 64 : TablaSG(43) = 65 : TablaSG(44) = 66 : TablaSG(45) = 67
        TablaSG(46) = 68 : TablaSG(47) = 69 : TablaSG(48) = 70 : TablaSG(49) = 71
        TablaSG(50) = 72 : TablaSG(51) = 73 : TablaSG(52) = 74 : TablaSG(53) = 75
        TablaSG(54) = 76 : TablaSG(55) = 77 : TablaSG(56) = 78 : TablaSG(57) = 79
        TablaSG(58) = 80 : TablaSG(59) = 81 : TablaSG(60) = 82 : TablaSG(61) = 83
        TablaSG(62) = 84 : TablaSG(63) = 85 : TablaSG(64) = 86 : TablaSG(65) = 87

        'Tabla de longitus craneo caudal   PARIS  (14-36)------------------------
        For t = 0 To 100
            TablaLCC(t) = 0
        Next
        TablaLCC(2) = 40 : TablaLCC(3) = 41 : TablaLCC(4) = 42 : TablaLCC(5) = 42
        TablaLCC(6) = 43 : TablaLCC(7) = 44 : TablaLCC(8) = 46 : TablaLCC(9) = 47
        TablaLCC(10) = 49 : TablaLCC(11) = 50 : TablaLCC(12) = 51 : TablaLCC(13) = 52
        TablaLCC(14) = 53 : TablaLCC(15) = 54 : TablaLCC(16) = 55 : TablaLCC(17) = 56
        TablaLCC(18) = 57 : TablaLCC(19) = 58 : TablaLCC(20) = 59 : TablaLCC(21) = 60
        TablaLCC(22) = 61 : TablaLCC(23) = 63 : TablaLCC(24) = 63 : TablaLCC(25) = 64
        TablaLCC(26) = 65 : TablaLCC(27) = 66 : TablaLCC(28) = 66 : TablaLCC(29) = 67
        TablaLCC(30) = 68 : TablaLCC(31) = 69 : TablaLCC(32) = 70 : TablaLCC(33) = 70
        TablaLCC(34) = 71 : TablaLCC(35) = 71 : TablaLCC(36) = 72 : TablaLCC(37) = 73
        TablaLCC(38) = 73 : TablaLCC(39) = 74 : TablaLCC(40) = 74 : TablaLCC(41) = 75
        TablaLCC(42) = 76 : TablaLCC(43) = 76 : TablaLCC(44) = 77 : TablaLCC(45) = 77
        TablaLCC(46) = 78 : TablaLCC(47) = 79 : TablaLCC(48) = 79 : TablaLCC(49) = 80
        TablaLCC(50) = 80 : TablaLCC(51) = 81 : TablaLCC(52) = 82 : TablaLCC(53) = 82
        TablaLCC(54) = 83 : TablaLCC(55) = 84 : TablaLCC(56) = 84 : TablaLCC(57) = 85
        TablaLCC(58) = 85 : TablaLCC(59) = 86 : TablaLCC(60) = 86 : TablaLCC(61) = 87
        TablaLCC(62) = 87 : TablaLCC(63) = 88 : TablaLCC(64) = 88 : TablaLCC(65) = 89
        TablaLCC(66) = 89 : TablaLCC(67) = 90 : TablaLCC(68) = 90 : TablaLCC(69) = 91
        TablaLCC(70) = 91 : TablaLCC(71) = 91 : TablaLCC(72) = 92 : TablaLCC(73) = 92
        TablaLCC(74) = 93 : TablaLCC(75) = 93 : TablaLCC(76) = 94 : TablaLCC(77) = 94
        TablaLCC(78) = 94 : TablaLCC(79) = 95 : TablaLCC(80) = 95 : TablaLCC(81) = 96
        TablaLCC(82) = 96 : TablaLCC(83) = 97 : TablaLCC(84) = 97 : TablaLCC(85) = 98

        'Tabla de Diametro Bi Parietal
        '------------------------------------------------------------------------------
        For t = 0 To 120
            TablaDBP(t) = 0
        Next
        TablaDBP(14) = 83 : TablaDBP(15) = 84 : TablaDBP(16) = 86 : TablaDBP(17) = 87
        TablaDBP(18) = 89 : TablaDBP(19) = 90 : TablaDBP(20) = 92 : TablaDBP(21) = 93
        TablaDBP(22) = 95 : TablaDBP(23) = 96 : TablaDBP(24) = 98 : TablaDBP(25) = 100
        TablaDBP(26) = 101 : TablaDBP(27) = 103 : TablaDBP(28) = 105 : TablaDBP(29) = 106
        TablaDBP(30) = 108 : TablaDBP(31) = 110 : TablaDBP(32) = 112 : TablaDBP(33) = 113
        TablaDBP(34) = 115 : TablaDBP(35) = 117 : TablaDBP(36) = 119 : TablaDBP(37) = 121
        TablaDBP(38) = 123 : TablaDBP(39) = 125 : TablaDBP(40) = 127 : TablaDBP(41) = 129
        TablaDBP(42) = 131 : TablaDBP(43) = 133 : TablaDBP(44) = 135 : TablaDBP(45) = 137
        TablaDBP(46) = 139 : TablaDBP(47) = 141 : TablaDBP(48) = 143 : TablaDBP(49) = 145
        TablaDBP(50) = 147 : TablaDBP(51) = 150 : TablaDBP(52) = 152 : TablaDBP(53) = 154
        TablaDBP(54) = 157 : TablaDBP(55) = 159 : TablaDBP(56) = 161 : TablaDBP(57) = 164
        TablaDBP(58) = 166 : TablaDBP(59) = 168 : TablaDBP(60) = 171 : TablaDBP(61) = 173
        TablaDBP(62) = 176 : TablaDBP(63) = 178 : TablaDBP(64) = 181 : TablaDBP(65) = 183
        TablaDBP(66) = 186 : TablaDBP(67) = 188 : TablaDBP(68) = 191 : TablaDBP(69) = 194
        TablaDBP(70) = 196 : TablaDBP(71) = 199 : TablaDBP(72) = 202 : TablaDBP(73) = 205
        TablaDBP(74) = 207 : TablaDBP(75) = 210 : TablaDBP(76) = 213 : TablaDBP(77) = 216
        TablaDBP(78) = 219 : TablaDBP(79) = 221 : TablaDBP(80) = 224 : TablaDBP(81) = 227
        TablaDBP(82) = 230 : TablaDBP(83) = 233 : TablaDBP(84) = 236 : TablaDBP(85) = 239
        TablaDBP(86) = 242 : TablaDBP(87) = 245 : TablaDBP(88) = 248 : TablaDBP(89) = 252
        TablaDBP(90) = 255 : TablaDBP(91) = 258 : TablaDBP(92) = 261 : TablaDBP(93) = 264
        TablaDBP(94) = 267 : TablaDBP(95) = 271 : TablaDBP(96) = 274 : TablaDBP(97) = 277
        TablaDBP(98) = 281 : TablaDBP(99) = 284 : TablaDBP(100) = 287 : TablaDBP(101) = 291
        TablaDBP(102) = 294 : TablaDBP(103) = 298

        'Tabla de Circunferencia Cefalica
        '------------------------------------------------------------------------------
        For t = 0 To 80
            TablaCC(t) = 0
        Next
        TablaCC(11) = 83 : TablaCC(12) = 85 : TablaCC(13) = 87
        TablaCC(14) = 89 : TablaCC(15) = 91 : TablaCC(16) = 94 : TablaCC(17) = 96
        TablaCC(18) = 98 : TablaCC(19) = 100 : TablaCC(20) = 102 : TablaCC(21) = 104
        TablaCC(22) = 107 : TablaCC(23) = 109 : TablaCC(24) = 111 : TablaCC(25) = 114
        TablaCC(26) = 116 : TablaCC(27) = 118 : TablaCC(28) = 121 : TablaCC(29) = 123
        TablaCC(30) = 126 : TablaCC(31) = 129 : TablaCC(32) = 131 : TablaCC(33) = 134
        TablaCC(34) = 137 : TablaCC(35) = 140 : TablaCC(36) = 143 : TablaCC(37) = 145
        TablaCC(38) = 148 : TablaCC(39) = 151 : TablaCC(40) = 155 : TablaCC(41) = 158
        TablaCC(42) = 161 : TablaCC(43) = 164 : TablaCC(44) = 168 : TablaCC(45) = 171
        TablaCC(46) = 175 : TablaCC(47) = 178 : TablaCC(48) = 182 : TablaCC(49) = 186
        TablaCC(50) = 190 : TablaCC(51) = 193 : TablaCC(52) = 197 : TablaCC(53) = 201
        TablaCC(54) = 206 : TablaCC(55) = 210 : TablaCC(56) = 214 : TablaCC(57) = 219
        TablaCC(58) = 223 : TablaCC(59) = 228 : TablaCC(60) = 232 : TablaCC(61) = 237
        TablaCC(62) = 242 : TablaCC(63) = 247 : TablaCC(64) = 252 : TablaCC(65) = 257
        TablaCC(66) = 262 : TablaCC(67) = 268 : TablaCC(68) = 273 : TablaCC(69) = 279
        TablaCC(70) = 285 : TablaCC(71) = 290 : TablaCC(72) = 296

        'Tabla de Circunferencia Abdominal
        '------------------------------------------------------------------------------
        For t = 0 To 80
            TablaCA(t) = 0
        Next
        TablaCA(10) = 84 : TablaCA(11) = 86 : TablaCA(12) = 89 : TablaCA(13) = 92
        TablaCA(14) = 95 : TablaCA(15) = 97 : TablaCA(16) = 100 : TablaCA(17) = 103
        TablaCA(18) = 106 : TablaCA(19) = 109 : TablaCA(20) = 112 : TablaCA(21) = 115
        TablaCA(22) = 118 : TablaCA(23) = 120 : TablaCA(24) = 123 : TablaCA(25) = 126
        TablaCA(26) = 129 : TablaCA(27) = 132 : TablaCA(28) = 135 : TablaCA(29) = 138
        TablaCA(30) = 141 : TablaCA(31) = 144 : TablaCA(32) = 147 : TablaCA(33) = 150
        TablaCA(34) = 153 : TablaCA(35) = 156 : TablaCA(36) = 160 : TablaCA(37) = 163
        TablaCA(38) = 166 : TablaCA(39) = 169 : TablaCA(40) = 172 : TablaCA(41) = 175
        TablaCA(42) = 178 : TablaCA(43) = 181 : TablaCA(44) = 185 : TablaCA(45) = 188
        TablaCA(46) = 191 : TablaCA(47) = 194 : TablaCA(48) = 198 : TablaCA(49) = 201
        TablaCA(50) = 204 : TablaCA(51) = 207 : TablaCA(52) = 211 : TablaCA(53) = 214
        TablaCA(54) = 217 : TablaCA(55) = 220 : TablaCA(56) = 224 : TablaCA(57) = 227
        TablaCA(58) = 231 : TablaCA(59) = 234 : TablaCA(60) = 237 : TablaCA(61) = 241
        TablaCA(62) = 244 : TablaCA(63) = 248 : TablaCA(64) = 251 : TablaCA(65) = 254
        TablaCA(66) = 258 : TablaCA(67) = 261 : TablaCA(68) = 264 : TablaCA(69) = 269
        TablaCA(70) = 273 : TablaCA(71) = 276 : TablaCA(72) = 279 : TablaCA(73) = 284
        TablaCA(74) = 288 : TablaCA(75) = 292 : TablaCA(76) = 295 : TablaCA(77) = 299

        'Tabla de Femur 
        '------------------------------------------------------------------------------
        For t = 0 To 100
            TablaFemur(t) = 0
        Next
        TablaFemur(6) = 83 : TablaFemur(7) = 85 : TablaFemur(8) = 87 : TablaFemur(9) = 88
        TablaFemur(10) = 90 : TablaFemur(11) = 92 : TablaFemur(12) = 94 : TablaFemur(13) = 96
        TablaFemur(14) = 98 : TablaFemur(15) = 100 : TablaFemur(16) = 103 : TablaFemur(17) = 105
        TablaFemur(18) = 107 : TablaFemur(19) = 109 : TablaFemur(20) = 111 : TablaFemur(21) = 113
        TablaFemur(22) = 116 : TablaFemur(23) = 118 : TablaFemur(24) = 120 : TablaFemur(25) = 122
        TablaFemur(26) = 125 : TablaFemur(27) = 127 : TablaFemur(28) = 129 : TablaFemur(29) = 132
        TablaFemur(30) = 134 : TablaFemur(31) = 137 : TablaFemur(32) = 139 : TablaFemur(33) = 142
        TablaFemur(34) = 144 : TablaFemur(35) = 147 : TablaFemur(36) = 149 : TablaFemur(37) = 152
        TablaFemur(38) = 155 : TablaFemur(39) = 157 : TablaFemur(40) = 160 : TablaFemur(41) = 163
        TablaFemur(42) = 165 : TablaFemur(43) = 168 : TablaFemur(44) = 171 : TablaFemur(45) = 174
        TablaFemur(46) = 176 : TablaFemur(47) = 179 : TablaFemur(48) = 182 : TablaFemur(49) = 185
        TablaFemur(50) = 188 : TablaFemur(51) = 191 : TablaFemur(52) = 194 : TablaFemur(53) = 197
        TablaFemur(54) = 200 : TablaFemur(55) = 203 : TablaFemur(56) = 206 : TablaFemur(57) = 209
        TablaFemur(58) = 212 : TablaFemur(59) = 215 : TablaFemur(60) = 218 : TablaFemur(61) = 221
        TablaFemur(62) = 224 : TablaFemur(63) = 228 : TablaFemur(64) = 231 : TablaFemur(65) = 234
        TablaFemur(66) = 237 : TablaFemur(67) = 241 : TablaFemur(68) = 244 : TablaFemur(69) = 247
        TablaFemur(70) = 251 : TablaFemur(71) = 254 : TablaFemur(72) = 258 : TablaFemur(73) = 261
        TablaFemur(74) = 265 : TablaFemur(75) = 268 : TablaFemur(76) = 272 : TablaFemur(77) = 275
        TablaFemur(78) = 279 : TablaFemur(79) = 282 : TablaFemur(80) = 286 : TablaFemur(81) = 290
        TablaFemur(82) = 293 : TablaFemur(83) = 297
    End Sub

    Private Sub SeRealizoUnCambio()
        DatosModificados = True
    End Sub

    Private Sub DatosSinCambios()
        DatosModificados = False
    End Sub


    '---------------------------------------------------------------------
    '= Procesamiento de EG en dias a EG en Semanas + Dias                =
    '= necesita NumeroDiasEG as integer desde donde se llama y...        =
    '= Calcula: TextoDeEGenSemanasyDias as string y TextodeFPP as string =
    '---------------------------------------------------------------------
    Private Sub ProcesaDiasEnSemanasMasDias()
        Dim EG As Integer
        Dim Semanas, Dias As Integer
        Dim Calculo As Double
        'Dim Hoy As Date
        Dim FPP As Date
        Dim TextoSemana, TextoDia As String
        Dim FURinicio As Date

        'inicializa variables para evitar error
        TextoSemana = ""
        TextoDia = ""

        EG = NumeroDiasEG
        FURinicio = Form1.Informe04FUR
        FPP = FURinicio.AddDays(280)

        If EG < 1 Then
            'valor invalido
            'vamos a ver que le pongo
            TextoDeEGenSemanasyDias = ""
            TextoDeFPP = FPP.ToString("dd/MM/yyyy")
        ElseIf EG > 300 Then
            'la eg da 43 semanas o mas, lo dice
            TextoDeEGenSemanasyDias = "Más de 43 semanas"
            TextoDeFPP = FPP.ToString("dd/MM/yyyy")
        Else
            'esta en el rango de calculo lo hace
            Semanas = EG \ 7
            Calculo = (EG / 7) - Semanas
            If Calculo = 0 Then
                Dias = 0
            Else
                Dias = CInt(Calculo * 7)
            End If
            If Semanas = 1 Then
                TextoSemana = "1 Semana"
            Else
                TextoSemana = Semanas & " Semanas"
            End If
            If Dias = 0 And Semanas = 1 Then
                TextoDia = " Exacta."
            ElseIf Dias = 0 And Semanas <> 1 Then
                TextoDia = " Exactas."
            ElseIf Dias = 1 Then
                TextoDia = " y 1 día."
            ElseIf Dias > 1 Then
                TextoDia = " y " & Dias & " días."
            End If

            TextoDeEGenSemanasyDias = TextoSemana & TextoDia
            TextoDeFPP = FPP.ToString("dd/MM/yyyy")
        End If

    End Sub

    'R.d01SGlongitudinal, R.d02SGAnteroPosterior y R.d03SGTransversal
    Private Sub txtSG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtSGlongitudinal.KeyPress, txtSGanteroposterior.KeyPress, txtSGtransversal.KeyPress
        Dim c As Char
        c = e.KeyChar

        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub

    Private Sub txtSacoGestacional_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtSGlongitudinal.Leave, txtSGanteroposterior.Leave, txtSGtransversal.Leave

        CalculaEGxSG()

    End Sub

    Private Sub CalculaEGxSG()
        Dim Promedio As Integer
        Dim NumerodeValores As Integer = 0
        Dim V1, V2, V3 As Integer

        If txtSGlongitudinal.Text <> "" Then
            V1 = txtSGlongitudinal.Text
            NumerodeValores += 1
        Else
            V1 = 0
        End If

        If txtSGanteroposterior.Text <> "" Then
            V2 = txtSGanteroposterior.Text
            NumerodeValores += 1
        Else
            V2 = 0
        End If

        If txtSGtransversal.Text <> "" Then
            V3 = txtSGtransversal.Text
            NumerodeValores += 1
        Else
            V3 = 0
        End If

        If NumerodeValores > 0 Then
            Promedio = (V1 + V2 + V3) \ NumerodeValores
            labSGpromedio.Text = Promedio.ToString
            If Promedio < 10 Then
                'por debajo del rango
                labEGxSG.Text = "Fuera de rango"
                EGxSGenDias = 0
            ElseIf Promedio > 65 Then
                'por arriba del rango
                labEGxSG.Text = "Fuera de rango"
                EGxSGenDias = 0
            Else
                'dentro del rango
                EGxSGenDias = TablaSG(Promedio)
                NumeroDiasEG = EGxSGenDias
                ProcesaDiasEnSemanasMasDias()
                labEGxSG.Text = TextoDeEGenSemanasyDias
            End If

            'despues de que calcule esto trata de calcular el definitivo
            CalculaEG1erTxECO()
        Else
            labSGpromedio.Text = ""
            labEGxSG.Text = "Faltan Datos"
            EGxSGenDias = 0
            CalculaEG1erTxECO()
        End If
    End Sub

    Private Sub txtLCC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLCC.KeyPress
        Dim c As Char
        c = e.KeyChar

        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If

    End Sub

    Private Sub txtLCC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLCC.Leave
        CalculaEGxLCC()
    End Sub

    Private Sub CalculaEGxLCC()
        Dim Promedio As Integer

        If txtLCC.Text <> "" Then
            Promedio = txtLCC.Text
            If Promedio < 2 Then
                'por debajo del rango
                labEGxLCC.Text = "Fuera de rango"
                EGxLCCenDias = 0
            ElseIf Promedio > 80 Then
                'por arriba del rango
                labEGxLCC.Text = "Fuera de rango"
                EGxLCCenDias = 0
            Else
                'dentro del rango
                EGxLCCenDias = TablaLCC(Promedio)
                NumeroDiasEG = EGxLCCenDias
                ProcesaDiasEnSemanasMasDias()
                labEGxLCC.Text = TextoDeEGenSemanasyDias
            End If
            'despues de calcular la egxlcc trata de calcular el promedio final
            CalculaEG1erTxECO()
        Else
            labEGxLCC.Text = "Faltan Datos"
            EGxLCCenDias = 0
            CalculaEG1erTxECO()
        End If
    End Sub

    'Calcula la edad ecografica del 1er trimestre
    Private Sub CalculaEG1erTxECO()
        Dim NumeroValores As Integer = 0
        If EGxSGenDias <> 0 Then
            NumeroValores += 1
        End If
        If EGxLCCenDias <> 0 Then
            NumeroValores += 1
        End If
        EGxECO1erTenDias = EGxSGenDias + EGxLCCenDias
        If NumeroValores = 0 Then
            LabEdadEcografica1erT.Text = "Faltan Datos"
        ElseIf NumeroValores = 1 Then
            NumeroDiasEG = EGxECO1erTenDias
            ProcesaDiasEnSemanasMasDias()
            LabEdadEcografica1erT.Text = TextoDeEGenSemanasyDias
        ElseIf NumeroValores = 2 Then
            NumeroDiasEG = (EGxECO1erTenDias) \ 2
            ProcesaDiasEnSemanasMasDias()
            LabEdadEcografica1erT.Text = TextoDeEGenSemanasyDias
        End If
    End Sub

    '2 y 3er trimestre BIOMETRICAS
    'Todos los keypress
    Private Sub txtBiometricasTodas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtDBP.KeyPress, txtDOF.KeyPress, txtFemur.KeyPress, txtAPA.KeyPress, txtTransAbdomen.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub

    'r.e13 = txtDBP
    Private Sub txtDBP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDBP.Leave
        CalculaEGconDBP()
        CalculaDBF()
    End Sub

    Private Sub CalculaEGconDBP()
        Dim Valor As Integer
        'Dim Promedio As Integer

        If txtDBP.Text <> "" Then
            'existe un dato, calcula la EGxDBP, 
            Valor = txtDBP.Text
            If Valor < 14 Then
                'fuera del rango hacia abajo pone a cero
                EGxDBPenDias = 0
                labEGxDBP.Text = "Por debajo del rango"
                CalculaCC_DBPc_IC()
                CalculaPesoEstimado()
                CalculaEG2y3erTxECO()
            ElseIf Valor > 120 Then
                'valor exagerado ni siquiera hidrocefalia bloquea calculos
                EGxDBPenDias = 0
                labEGxDBP.Text = "Fuera de Rango"
                CalculaCC_DBPc_IC()
                CalculaPesoEstimado()
                CalculaEG2y3erTxECO()
            ElseIf Valor > 103 Then
                'fuera del rango hacia arriba pone a 43 semanas
                EGxDBPenDias = 301
                labEGxDBP.Text = "Más de 43 semanas"
                CalculaCC_DBPc_IC()
                CalculaPesoEstimado()
                CalculaEG2y3erTxECO()
            Else
                'dentro del rango calcula normal
                EGxDBPenDias = TablaDBP(Valor)
                NumeroDiasEG = EGxDBPenDias
                ProcesaDiasEnSemanasMasDias()
                labEGxDBP.Text = TextoDeEGenSemanasyDias
                'trata de calcular la Cir Cef, el Indice cefalico y el DBPc
                CalculaCC_DBPc_IC()
                'trata de calcular el peso estimado
                CalculaPesoEstimado()
                'trata de calcular el promedio final
                CalculaEG2y3erTxECO()
            End If
        Else
            'la casilla esta vacia
            EGxDBPenDias = 0
            labEGxDBP.Text = "Faltan Datos"
            CalculaCC_DBPc_IC()
            CalculaPesoEstimado()
            CalculaEG2y3erTxECO()
        End If
    End Sub

    'r.e14 = txtDOF
    Private Sub txtDOF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDOF.Leave
        CalculaCC_DBPc_IC()
        CalculaPesoEstimado()
        CalculaEG2y3erTxECO()
    End Sub

    'calcula Circunferencia cef e indice cefalico si puede....
    Private Sub CalculaCC_DBPc_IC()

        If txtDBP.Text <> "" And txtDOF.Text <> "" Then
            'tengo los dos valores vamos a ver si estan en los limites 
            Dim DBPc As Integer
            Dim DBP, DOF As Integer
            Dim CC As Integer
            Dim IC As Integer
            Dim Valor As Integer

            'asigna valores iniciales
            DBP = txtDBP.Text
            DOF = txtDOF.Text

            'calcula DBPc
            DBPc = Math.Abs(Math.Sqrt((DBP * DOF) / 1.265))
            Valor = DBPc
            'verifica que valor este entro del rango permitido
            If Valor < 14 Then
                'fuera del rango
                labDBPc.Text = "F/R"
                labEGxDBPc.Text = "Por Debajo del Rango"
                EGxDBPcenDias = 0
            ElseIf Valor > 103 Then
                'valor es mayor que la tabla lo pone a 43 semanas
                labDBPc.Text = DBPc
                labEGxDBPc.Text = "Más de 43 semanas"
                EGxDBPcenDias = 301
            Else
                'dentro del rango hace los calculos
                EGxDBPcenDias = TablaDBP(Valor)
                NumeroDiasEG = EGxDBPcenDias
                ProcesaDiasEnSemanasMasDias()
                labDBPc.Text = DBPc
                labEGxDBPc.Text = TextoDeEGenSemanasyDias
            End If


            'calcula circunferencia cefalica
            CC = 1.57 * (DBP + DOF)
            Valor = CC \ 5  'la tablaCC esta basada en segmentos de 5 cm

            'verifica que valor este entre el rango de la tabla
            If Valor < 11 Then
                'esta fuera del rango
                labCirCef.Text = "F/R"
                labEGxCC.Text = "Por debajo del rango"
                EGxCCenDias = 0
            ElseIf Valor > 72 Then
                'valor por encima de la tabla lo pone a 43 semanas
                labCirCef.Text = CC
                labEGxCC.Text = "Más de 43 semanas"
                EGxCCenDias = 301
            Else
                'esta dentro del rango, calcula la CC
                EGxCCenDias = TablaCC(Valor)
                NumeroDiasEG = EGxCCenDias
                ProcesaDiasEnSemanasMasDias()
                labCirCef.Text = CC
                labEGxCC.Text = TextoDeEGenSemanasyDias
            End If

            'calcula Indice cefalico si es distinto de 0 el dof
            If DOF <> 0 Then
                IC = DBP * 100 \ DOF
                labIndCef.Text = IC & " %"
            Else
                labIndCef.Text = ""
            End If
        Else
            'falta alguno de los dos datos
            labDBPc.Text = ""
            labCirCef.Text = ""
            labIndCef.Text = ""
            labEGxDBPc.Text = "Faltan Datos"
            labEGxCC.Text = "Faltan Datos"
            EGxDBPcenDias = 0
            EGxCCenDias = 0
        End If
    End Sub

    'r.e17a = txtAPA 
    Private Sub txtAPA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAPA.Leave
        'trata de calcular la CA
        CalculaCA()
        'trata de calcular el peso estimado
        CalculaPesoEstimado()
        'trata de calcular el promedio final
        CalculaEG2y3erTxECO()
    End Sub

    'r.e17b = txttransAbd 
    Private Sub txtTransAbdomen_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransAbdomen.Leave
        'trata de calcular la Circunferencia Abdominal
        CalculaCA()
        'trata de calcular el peso estimado
        CalculaPesoEstimado()
        'trata de calcular el promedio final
        CalculaEG2y3erTxECO()
    End Sub

    'calcula la circunferencia abdominal si puede...
    Private Sub CalculaCA()
        'variables locales para los calculos
        Dim APA, TransABD As Integer
        Dim CA As Integer
        Dim valor As Integer
        '---------------------
        If txtAPA.Text <> "" And txtTransAbdomen.Text <> "" Then
            'tengo los dos datos necesarios calcula todo

            'calcula Circunferencia Abdominal
            '--------------------------------
            APA = txtAPA.Text
            TransABD = txtTransAbdomen.Text
            CA = 1.57 * (APA + TransABD)

            valor = CA \ 5 'la tabla esta basada en escalas de 5 en 5 mm

            'verifica que el valor este dentro de los rangos de la tabla
            If valor < 10 Then
                'por debajo del nivel minimo
                EGxCAenDias = 0
                labCirAbd.Text = "F/R"
                labEGxCA.Text = "Por debajo del rango"
            ElseIf valor > 100 Then
                'valor excesivo exagerado pon a F/R
                EGxCAenDias = 0
                labCirAbd.Text = "F/R"
                labEGxCA.Text = "Fuera del rango"
            ElseIf valor > 77 Then
                'fuera del rango por poco pone al valor maximo
                EGxCAenDias = 301
                NumeroDiasEG = EGxCAenDias
                ProcesaDiasEnSemanasMasDias()
                labCirAbd.Text = CA
                labEGxCA.Text = TextoDeEGenSemanasyDias
            Else
                'dentro del rango normal hace los calculos
                EGxCAenDias = TablaCA(valor)
                NumeroDiasEG = EGxCAenDias
                ProcesaDiasEnSemanasMasDias()
                labCirAbd.Text = CA
                labEGxCA.Text = TextoDeEGenSemanasyDias
            End If
        Else
            'falta alguno de los dos datos borra las cosas que dependen de el
            EGxCAenDias = 0
            labCirAbd.Text = ""
            labEGxCA.Text = "Faltan Datos"
        End If
    End Sub

    Private Sub txtFemur_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFemur.Leave
        CalculaDBF()
        CalculaEGxFemur()
        CalculaPesoEstimado()
        CalculaEG2y3erTxECO()
    End Sub

    Private Sub CalculaDBF()
        Dim DBF As Integer
        Dim Femur, DBP As Integer

        If txtFemur.Text <> "" And txtDBP.Text <> "" Then
            DBP = txtDBP.Text
            Femur = txtFemur.Text
            DBF = DBP + Femur
            labDBF.Text = DBF
        Else
            labDBF.Text = ""
        End If
    End Sub

    Private Sub CalculaEGxFemur()
        Dim Valor As Integer
        '-----------------------
        If txtFemur.Text <> "" Then
            'hay un dato trata de hacer los calculos
            Valor = txtFemur.Text
            If Valor < 6 Then
                'por debajo del rango de la tabla
                EGxFEMURenDias = 0
                labEGxFemur.Text = "Por debajo del rango"
            ElseIf Valor > 140 Then
                'valor exagerado borra no toma en cuenta
                EGxFEMURenDias = 0
                labEGxFemur.Text = "Fuera de rango"
            ElseIf Valor > 83 Then
                'valor sobre el limite pero no tanto pone al maximo
                EGxFEMURenDias = 301
                labEGxFemur.Text = "Más de 43 semanas"
            Else
                'valor dentro del rango de la tabla hace los calculos
                EGxFEMURenDias = TablaFemur(Valor)
                NumeroDiasEG = EGxFEMURenDias
                ProcesaDiasEnSemanasMasDias()
                labEGxFemur.Text = TextoDeEGenSemanasyDias
            End If
        Else
            'no hay nada borra lo que depende de el
            EGxFEMURenDias = 0
            labEGxFemur.Text = "Faltan Datos"
        End If
    End Sub

    'calcula el peso estimado si puede
    Private Sub CalculaPesoEstimado()
        'variables locales
        'Dim Exponente As Double
        'Dim CA, DBP, DBPc, LF As Integer
        Dim TenemosCA As Boolean
        Dim TenemosCC As Boolean
        Dim TenemosFemur As Boolean
        Dim TenemosDBP As Boolean
        Dim TenemosDBPc As Boolean
        Dim CodigoBinario As Byte
        '--------------------------------

        'revisa de que datos disponemos
        CodigoBinario = 0

        If EGxDBPenDias = 0 Then
            TenemosDBP = False
            TenemosDBPc = False
            TenemosCC = False
        Else
            TenemosDBP = True
            CodigoBinario += 1
            If EGxDBPcenDias = 0 Then
                TenemosDBPc = False
                TenemosCC = False
            Else
                TenemosDBPc = True
                TenemosCC = True
                CodigoBinario += 2
            End If
        End If
        If EGxCAenDias = 0 Then
            TenemosCA = False
        Else
            TenemosCA = True
            CodigoBinario += 4
        End If
        If EGxFEMURenDias = 0 Then
            TenemosFemur = False
        Else
            TenemosFemur = True
            CodigoBinario += 8
        End If

        If CodigoBinario = 4 Then
            Formula4()
        ElseIf CodigoBinario = 5 Then
            Formula1()
        ElseIf CodigoBinario = 7 Then
            Formula5()
        ElseIf CodigoBinario = 12 Then
            Formula3()
        ElseIf CodigoBinario = 13 Then
            Formula1()
        ElseIf CodigoBinario = 15 Then
            Formula2()
        Else
            labPesoEstimado.Text = "Faltan Datos"
            labPesoTEXT.Text = "Peso Fetal Estimado (Faltan Datos)"
        End If
    End Sub

    'formulas del peso estimado
    Private Sub Formula1()
        Dim Valor, Exponente As Double
        Dim Peso As Int64
        Dim CA, DBP As Double
        CA = labCirAbd.Text
        CA = CA / 10
        DBP = txtDBP.Text
        DBP = DBP / 10
        Exponente = (0.166 * DBP) + (0.046 * CA) - (0.002646 * CA * DBP) - 1.7492
        Valor = 1000 * (10 ^ Exponente)
        Peso = Math.Abs(Valor)
        labPesoEstimado.Text = Peso
        labPesoTEXT.Text = "Peso Fetal Estimado (por CA y DBP)"
    End Sub
    Private Sub Formula2()
        Dim Valor, Exponente As Double
        Dim Peso As Int64
        Dim CA, CC, DBP, LF As Double
        CA = labCirAbd.Text
        CA = CA / 10
        CC = labCirCef.Text
        CC = CC / 10
        DBP = txtDBP.Text
        DBP = DBP / 10
        LF = txtFemur.Text
        LF = LF / 10
        Exponente = 1.5662 - (0.0108 * CC) + (0.0468 * CA) + (0.171 * LF) + (0.00034 * (CC ^ 2)) - (0.003685 * CA * LF)
        Valor = 10 ^ Exponente
        Peso = Math.Abs(Valor)
        labPesoEstimado.Text = Peso
        labPesoTEXT.Text = "Peso Fetal Estimado (por CC, CA y LF)"
    End Sub
    Private Sub Formula3()
        Dim Valor, Exponente As Double
        Dim Peso As Int64
        Dim CA, LF As Double
        CA = labCirAbd.Text
        CA = CA / 10
        LF = txtFemur.Text
        LF = LF / 10
        Exponente = 1.304 + (0.05281 * CA) + (0.1938 * LF) - (0.004 * CA * LF)
        Valor = 10 ^ Exponente
        Peso = Math.Abs(Valor)
        labPesoEstimado.Text = Peso
        labPesoTEXT.Text = "Peso Fetal Estimado (por CA y LF)"
    End Sub
    Private Sub Formula4()
        Dim Valor As Double
        Dim Peso As Int64
        Dim CA As Double
        CA = labCirAbd.Text
        CA = CA / 10
        Valor = (CA ^ 3) * 0.0816
        Peso = Math.Abs(Valor)
        labPesoEstimado.Text = Peso
        labPesoTEXT.Text = "Peso Fetal Estimado (por CA)"
    End Sub
    Private Sub Formula5()
        Dim Valor, Exponente As Double
        Dim Peso As Int64
        Dim CA, CC As Double
        CA = labCirAbd.Text
        CA = CA / 10
        CC = labCirCef.Text
        CC = CC / 10
        Exponente = 1.6575 + (0.04035 * CC) + (0.01285 * CA)
        Valor = 10 ^ Exponente
        Peso = Math.Abs(Valor)
        labPesoEstimado.Text = Peso
        labPesoTEXT.Text = "Peso Fetal Estimado (por CC y CA)"
    End Sub

    'calcula eg x eco 2y 3er trimestre si puede....
    Private Sub CalculaEG2y3erTxECO()
        Dim NumeroValores As Integer = 0

        If EGxDBPenDias <> 0 Then
            NumeroValores += 1
        End If
        If EGxDBPcenDias <> 0 Then
            NumeroValores += 1
        End If
        If EGxCCenDias <> 0 Then
            NumeroValores += 1
        End If
        If EGxCAenDias <> 0 Then
            NumeroValores += 1
        End If
        If EGxFEMURenDias <> 0 Then
            NumeroValores += 1
        End If

        EGxECO2y3erTenDias = EGxDBPenDias + EGxDBPcenDias + EGxCCenDias + EGxCAenDias + EGxFEMURenDias
        If NumeroValores = 0 Then
            LabEdadEcografica2y3erT.Text = ""
        ElseIf NumeroValores = 1 Then
            NumeroDiasEG = EGxECO2y3erTenDias
            ProcesaDiasEnSemanasMasDias()
            LabEdadEcografica2y3erT.Text = TextoDeEGenSemanasyDias
        ElseIf NumeroValores = 2 Then
            NumeroDiasEG = (EGxECO2y3erTenDias) \ 2
            ProcesaDiasEnSemanasMasDias()
            LabEdadEcografica2y3erT.Text = TextoDeEGenSemanasyDias
        ElseIf NumeroValores = 3 Then
            NumeroDiasEG = (EGxECO2y3erTenDias) \ 3
            ProcesaDiasEnSemanasMasDias()
            LabEdadEcografica2y3erT.Text = TextoDeEGenSemanasyDias
        ElseIf NumeroValores = 4 Then
            NumeroDiasEG = (EGxECO2y3erTenDias) \ 4
            ProcesaDiasEnSemanasMasDias()
            LabEdadEcografica2y3erT.Text = TextoDeEGenSemanasyDias
        ElseIf NumeroValores = 5 Then
            NumeroDiasEG = (EGxECO2y3erTenDias) \ 5
            ProcesaDiasEnSemanasMasDias()
            LabEdadEcografica2y3erT.Text = TextoDeEGenSemanasyDias
        End If
    End Sub


    Private Sub botSalirSinGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalirSinGuardar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class
