Imports System.IO

Public Class FormAntObstetricos
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
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOtrosNotas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanelEmbarazos As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtVivo01 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso01 As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo01 As System.Windows.Forms.TextBox
    Friend WithEvents txtCaracteristicas01 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo01 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño01 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtVivo02 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso02 As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo02 As System.Windows.Forms.TextBox
    Friend WithEvents txtCaracteristicas02 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo02 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño02 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtVivo03 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso03 As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo03 As System.Windows.Forms.TextBox
    Friend WithEvents txtCaracteristicas03 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo03 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño03 As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtVivo04 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso04 As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo04 As System.Windows.Forms.TextBox
    Friend WithEvents txtCaracteristicas04 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo04 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño04 As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtVivo05 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso05 As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo05 As System.Windows.Forms.TextBox
    Friend WithEvents txtCaracteristicas05 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo05 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño05 As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtVivo06 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso06 As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo06 As System.Windows.Forms.TextBox
    Friend WithEvents txtCaracteristicas06 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo06 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño06 As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtVivo07 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso07 As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo07 As System.Windows.Forms.TextBox
    Friend WithEvents txtCaracteristicas07 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo07 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño07 As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txtVivo08 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso08 As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo08 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo08 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño08 As System.Windows.Forms.TextBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents txtVivo09 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso09 As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo09 As System.Windows.Forms.TextBox
    Friend WithEvents txtCaracteristicas09 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo09 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño09 As System.Windows.Forms.TextBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents txtVivo10 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso10 As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo10 As System.Windows.Forms.TextBox
    Friend WithEvents txtCaracteristicas10 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo10 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño10 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCaracteristicas08 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents labGesta As System.Windows.Forms.Label
    Friend WithEvents labEctoSs As System.Windows.Forms.Label
    Friend WithEvents labAboSs As System.Windows.Forms.Label
    Friend WithEvents labCesaSs As System.Windows.Forms.Label
    Friend WithEvents botGestaMas As System.Windows.Forms.Button
    Friend WithEvents botGestaMenos As System.Windows.Forms.Button
    Friend WithEvents botParaMenos As System.Windows.Forms.Button
    Friend WithEvents botParaMas As System.Windows.Forms.Button
    Friend WithEvents labPara As System.Windows.Forms.Label
    Friend WithEvents botCesaMenos As System.Windows.Forms.Button
    Friend WithEvents botCesaMas As System.Windows.Forms.Button
    Friend WithEvents labCesa As System.Windows.Forms.Label
    Friend WithEvents botAboMenos As System.Windows.Forms.Button
    Friend WithEvents botAboMas As System.Windows.Forms.Button
    Friend WithEvents labAbo As System.Windows.Forms.Label
    Friend WithEvents botEctoMenos As System.Windows.Forms.Button
    Friend WithEvents botEctoMas As System.Windows.Forms.Button
    Friend WithEvents labEcto As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAntObstetricos))
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.botEctoMenos = New System.Windows.Forms.Button()
        Me.botEctoMas = New System.Windows.Forms.Button()
        Me.labEcto = New System.Windows.Forms.Label()
        Me.botAboMenos = New System.Windows.Forms.Button()
        Me.botAboMas = New System.Windows.Forms.Button()
        Me.labAbo = New System.Windows.Forms.Label()
        Me.botCesaMenos = New System.Windows.Forms.Button()
        Me.botCesaMas = New System.Windows.Forms.Button()
        Me.labCesa = New System.Windows.Forms.Label()
        Me.botParaMenos = New System.Windows.Forms.Button()
        Me.botParaMas = New System.Windows.Forms.Button()
        Me.labPara = New System.Windows.Forms.Label()
        Me.botGestaMenos = New System.Windows.Forms.Button()
        Me.botGestaMas = New System.Windows.Forms.Button()
        Me.labGesta = New System.Windows.Forms.Label()
        Me.labEctoSs = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.labAboSs = New System.Windows.Forms.Label()
        Me.labCesaSs = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOtrosNotas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelEmbarazos = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtVivo10 = New System.Windows.Forms.TextBox()
        Me.txtPeso10 = New System.Windows.Forms.TextBox()
        Me.txtSexo10 = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas10 = New System.Windows.Forms.TextBox()
        Me.txtTipo10 = New System.Windows.Forms.TextBox()
        Me.txtAño10 = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtVivo09 = New System.Windows.Forms.TextBox()
        Me.txtPeso09 = New System.Windows.Forms.TextBox()
        Me.txtSexo09 = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas09 = New System.Windows.Forms.TextBox()
        Me.txtTipo09 = New System.Windows.Forms.TextBox()
        Me.txtAño09 = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtVivo08 = New System.Windows.Forms.TextBox()
        Me.txtPeso08 = New System.Windows.Forms.TextBox()
        Me.txtSexo08 = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas08 = New System.Windows.Forms.TextBox()
        Me.txtTipo08 = New System.Windows.Forms.TextBox()
        Me.txtAño08 = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtVivo07 = New System.Windows.Forms.TextBox()
        Me.txtPeso07 = New System.Windows.Forms.TextBox()
        Me.txtSexo07 = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas07 = New System.Windows.Forms.TextBox()
        Me.txtTipo07 = New System.Windows.Forms.TextBox()
        Me.txtAño07 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtVivo06 = New System.Windows.Forms.TextBox()
        Me.txtPeso06 = New System.Windows.Forms.TextBox()
        Me.txtSexo06 = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas06 = New System.Windows.Forms.TextBox()
        Me.txtTipo06 = New System.Windows.Forms.TextBox()
        Me.txtAño06 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtVivo05 = New System.Windows.Forms.TextBox()
        Me.txtPeso05 = New System.Windows.Forms.TextBox()
        Me.txtSexo05 = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas05 = New System.Windows.Forms.TextBox()
        Me.txtTipo05 = New System.Windows.Forms.TextBox()
        Me.txtAño05 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtVivo04 = New System.Windows.Forms.TextBox()
        Me.txtPeso04 = New System.Windows.Forms.TextBox()
        Me.txtSexo04 = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas04 = New System.Windows.Forms.TextBox()
        Me.txtTipo04 = New System.Windows.Forms.TextBox()
        Me.txtAño04 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtVivo03 = New System.Windows.Forms.TextBox()
        Me.txtPeso03 = New System.Windows.Forms.TextBox()
        Me.txtSexo03 = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas03 = New System.Windows.Forms.TextBox()
        Me.txtTipo03 = New System.Windows.Forms.TextBox()
        Me.txtAño03 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtVivo02 = New System.Windows.Forms.TextBox()
        Me.txtPeso02 = New System.Windows.Forms.TextBox()
        Me.txtSexo02 = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas02 = New System.Windows.Forms.TextBox()
        Me.txtTipo02 = New System.Windows.Forms.TextBox()
        Me.txtAño02 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtVivo01 = New System.Windows.Forms.TextBox()
        Me.txtPeso01 = New System.Windows.Forms.TextBox()
        Me.txtSexo01 = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas01 = New System.Windows.Forms.TextBox()
        Me.txtTipo01 = New System.Windows.Forms.TextBox()
        Me.txtAño01 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2.SuspendLayout()
        Me.PanelEmbarazos.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'botAceptar
        '
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.Image = CType(resources.GetObject("botAceptar.Image"), System.Drawing.Image)
        Me.botAceptar.Location = New System.Drawing.Point(744, 627)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(224, 23)
        Me.botAceptar.TabIndex = 18
        Me.botAceptar.Text = "Aceptar"
        '
        'botCancelar
        '
        Me.botCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Image)
        Me.botCancelar.Location = New System.Drawing.Point(8, 627)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(224, 23)
        Me.botCancelar.TabIndex = 17
        Me.botCancelar.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.botEctoMenos)
        Me.GroupBox2.Controls.Add(Me.botEctoMas)
        Me.GroupBox2.Controls.Add(Me.labEcto)
        Me.GroupBox2.Controls.Add(Me.botAboMenos)
        Me.GroupBox2.Controls.Add(Me.botAboMas)
        Me.GroupBox2.Controls.Add(Me.labAbo)
        Me.GroupBox2.Controls.Add(Me.botCesaMenos)
        Me.GroupBox2.Controls.Add(Me.botCesaMas)
        Me.GroupBox2.Controls.Add(Me.labCesa)
        Me.GroupBox2.Controls.Add(Me.botParaMenos)
        Me.GroupBox2.Controls.Add(Me.botParaMas)
        Me.GroupBox2.Controls.Add(Me.labPara)
        Me.GroupBox2.Controls.Add(Me.botGestaMenos)
        Me.GroupBox2.Controls.Add(Me.botGestaMas)
        Me.GroupBox2.Controls.Add(Me.labGesta)
        Me.GroupBox2.Controls.Add(Me.labEctoSs)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.labAboSs)
        Me.GroupBox2.Controls.Add(Me.labCesaSs)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtOtrosNotas)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 204)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paridad"
        '
        'botEctoMenos
        '
        Me.botEctoMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEctoMenos.Image = CType(resources.GetObject("botEctoMenos.Image"), System.Drawing.Image)
        Me.botEctoMenos.Location = New System.Drawing.Point(176, 140)
        Me.botEctoMenos.Name = "botEctoMenos"
        Me.botEctoMenos.Size = New System.Drawing.Size(20, 12)
        Me.botEctoMenos.TabIndex = 31
        '
        'botEctoMas
        '
        Me.botEctoMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEctoMas.Image = CType(resources.GetObject("botEctoMas.Image"), System.Drawing.Image)
        Me.botEctoMas.Location = New System.Drawing.Point(176, 128)
        Me.botEctoMas.Name = "botEctoMas"
        Me.botEctoMas.Size = New System.Drawing.Size(20, 12)
        Me.botEctoMas.TabIndex = 30
        '
        'labEcto
        '
        Me.labEcto.BackColor = System.Drawing.SystemColors.Window
        Me.labEcto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEcto.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEcto.Location = New System.Drawing.Point(136, 128)
        Me.labEcto.Name = "labEcto"
        Me.labEcto.Size = New System.Drawing.Size(40, 23)
        Me.labEcto.TabIndex = 29
        Me.labEcto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botAboMenos
        '
        Me.botAboMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAboMenos.Image = CType(resources.GetObject("botAboMenos.Image"), System.Drawing.Image)
        Me.botAboMenos.Location = New System.Drawing.Point(176, 112)
        Me.botAboMenos.Name = "botAboMenos"
        Me.botAboMenos.Size = New System.Drawing.Size(20, 12)
        Me.botAboMenos.TabIndex = 28
        '
        'botAboMas
        '
        Me.botAboMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAboMas.Image = CType(resources.GetObject("botAboMas.Image"), System.Drawing.Image)
        Me.botAboMas.Location = New System.Drawing.Point(176, 100)
        Me.botAboMas.Name = "botAboMas"
        Me.botAboMas.Size = New System.Drawing.Size(20, 12)
        Me.botAboMas.TabIndex = 27
        '
        'labAbo
        '
        Me.labAbo.BackColor = System.Drawing.SystemColors.Window
        Me.labAbo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labAbo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAbo.Location = New System.Drawing.Point(136, 100)
        Me.labAbo.Name = "labAbo"
        Me.labAbo.Size = New System.Drawing.Size(40, 23)
        Me.labAbo.TabIndex = 26
        Me.labAbo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botCesaMenos
        '
        Me.botCesaMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCesaMenos.Image = CType(resources.GetObject("botCesaMenos.Image"), System.Drawing.Image)
        Me.botCesaMenos.Location = New System.Drawing.Point(176, 84)
        Me.botCesaMenos.Name = "botCesaMenos"
        Me.botCesaMenos.Size = New System.Drawing.Size(20, 12)
        Me.botCesaMenos.TabIndex = 25
        '
        'botCesaMas
        '
        Me.botCesaMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCesaMas.Image = CType(resources.GetObject("botCesaMas.Image"), System.Drawing.Image)
        Me.botCesaMas.Location = New System.Drawing.Point(176, 72)
        Me.botCesaMas.Name = "botCesaMas"
        Me.botCesaMas.Size = New System.Drawing.Size(20, 12)
        Me.botCesaMas.TabIndex = 24
        '
        'labCesa
        '
        Me.labCesa.BackColor = System.Drawing.SystemColors.Window
        Me.labCesa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCesa.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCesa.Location = New System.Drawing.Point(136, 72)
        Me.labCesa.Name = "labCesa"
        Me.labCesa.Size = New System.Drawing.Size(40, 23)
        Me.labCesa.TabIndex = 23
        Me.labCesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botParaMenos
        '
        Me.botParaMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botParaMenos.Image = CType(resources.GetObject("botParaMenos.Image"), System.Drawing.Image)
        Me.botParaMenos.Location = New System.Drawing.Point(176, 56)
        Me.botParaMenos.Name = "botParaMenos"
        Me.botParaMenos.Size = New System.Drawing.Size(20, 12)
        Me.botParaMenos.TabIndex = 22
        '
        'botParaMas
        '
        Me.botParaMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botParaMas.Image = CType(resources.GetObject("botParaMas.Image"), System.Drawing.Image)
        Me.botParaMas.Location = New System.Drawing.Point(176, 44)
        Me.botParaMas.Name = "botParaMas"
        Me.botParaMas.Size = New System.Drawing.Size(20, 12)
        Me.botParaMas.TabIndex = 21
        '
        'labPara
        '
        Me.labPara.BackColor = System.Drawing.SystemColors.Window
        Me.labPara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPara.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPara.Location = New System.Drawing.Point(136, 44)
        Me.labPara.Name = "labPara"
        Me.labPara.Size = New System.Drawing.Size(40, 23)
        Me.labPara.TabIndex = 20
        Me.labPara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botGestaMenos
        '
        Me.botGestaMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botGestaMenos.Image = CType(resources.GetObject("botGestaMenos.Image"), System.Drawing.Image)
        Me.botGestaMenos.Location = New System.Drawing.Point(176, 28)
        Me.botGestaMenos.Name = "botGestaMenos"
        Me.botGestaMenos.Size = New System.Drawing.Size(20, 12)
        Me.botGestaMenos.TabIndex = 19
        '
        'botGestaMas
        '
        Me.botGestaMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botGestaMas.Image = CType(resources.GetObject("botGestaMas.Image"), System.Drawing.Image)
        Me.botGestaMas.Location = New System.Drawing.Point(176, 16)
        Me.botGestaMas.Name = "botGestaMas"
        Me.botGestaMas.Size = New System.Drawing.Size(20, 12)
        Me.botGestaMas.TabIndex = 18
        '
        'labGesta
        '
        Me.labGesta.BackColor = System.Drawing.SystemColors.Window
        Me.labGesta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labGesta.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labGesta.Location = New System.Drawing.Point(136, 16)
        Me.labGesta.Name = "labGesta"
        Me.labGesta.Size = New System.Drawing.Size(40, 23)
        Me.labGesta.TabIndex = 17
        Me.labGesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labEctoSs
        '
        Me.labEctoSs.Location = New System.Drawing.Point(196, 128)
        Me.labEctoSs.Name = "labEctoSs"
        Me.labEctoSs.Size = New System.Drawing.Size(56, 23)
        Me.labEctoSs.TabIndex = 16
        Me.labEctoSs.Text = "Ectopico"
        Me.labEctoSs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(16, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 23)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Número de Ectópicos"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labAboSs
        '
        Me.labAboSs.Location = New System.Drawing.Point(196, 100)
        Me.labAboSs.Name = "labAboSs"
        Me.labAboSs.Size = New System.Drawing.Size(56, 23)
        Me.labAboSs.TabIndex = 13
        Me.labAboSs.Text = "Aborto"
        Me.labAboSs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labCesaSs
        '
        Me.labCesaSs.Location = New System.Drawing.Point(196, 72)
        Me.labCesaSs.Name = "labCesaSs"
        Me.labCesaSs.Size = New System.Drawing.Size(56, 23)
        Me.labCesaSs.TabIndex = 12
        Me.labCesaSs.Text = "Cesárea"
        Me.labCesaSs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(196, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Para"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(196, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Gesta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOtrosNotas
        '
        Me.txtOtrosNotas.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtrosNotas.Location = New System.Drawing.Point(84, 156)
        Me.txtOtrosNotas.Multiline = True
        Me.txtOtrosNotas.Name = "txtOtrosNotas"
        Me.txtOtrosNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOtrosNotas.Size = New System.Drawing.Size(220, 40)
        Me.txtOtrosNotas.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Otros/Notas:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Número de Abortos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de Embarazos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Número de Partos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Número de Cesáreas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelEmbarazos
        '
        Me.PanelEmbarazos.AutoScroll = True
        Me.PanelEmbarazos.Controls.Add(Me.Panel10)
        Me.PanelEmbarazos.Controls.Add(Me.Panel9)
        Me.PanelEmbarazos.Controls.Add(Me.Panel8)
        Me.PanelEmbarazos.Controls.Add(Me.Panel7)
        Me.PanelEmbarazos.Controls.Add(Me.Panel6)
        Me.PanelEmbarazos.Controls.Add(Me.Panel5)
        Me.PanelEmbarazos.Controls.Add(Me.Panel4)
        Me.PanelEmbarazos.Controls.Add(Me.Panel3)
        Me.PanelEmbarazos.Controls.Add(Me.Panel2)
        Me.PanelEmbarazos.Controls.Add(Me.Panel1)
        Me.PanelEmbarazos.Location = New System.Drawing.Point(8, 244)
        Me.PanelEmbarazos.Name = "PanelEmbarazos"
        Me.PanelEmbarazos.Size = New System.Drawing.Size(776, 212)
        Me.PanelEmbarazos.TabIndex = 21
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.txtVivo10)
        Me.Panel10.Controls.Add(Me.txtPeso10)
        Me.Panel10.Controls.Add(Me.txtSexo10)
        Me.Panel10.Controls.Add(Me.txtCaracteristicas10)
        Me.Panel10.Controls.Add(Me.txtTipo10)
        Me.Panel10.Controls.Add(Me.txtAño10)
        Me.Panel10.Location = New System.Drawing.Point(0, 180)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(772, 20)
        Me.Panel10.TabIndex = 16
        '
        'txtVivo10
        '
        Me.txtVivo10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVivo10.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVivo10.Location = New System.Drawing.Point(736, 0)
        Me.txtVivo10.MaxLength = 1
        Me.txtVivo10.Name = "txtVivo10"
        Me.txtVivo10.Size = New System.Drawing.Size(32, 18)
        Me.txtVivo10.TabIndex = 12
        Me.txtVivo10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso10
        '
        Me.txtPeso10.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso10.Location = New System.Drawing.Point(688, 0)
        Me.txtPeso10.MaxLength = 4
        Me.txtPeso10.Name = "txtPeso10"
        Me.txtPeso10.Size = New System.Drawing.Size(48, 18)
        Me.txtPeso10.TabIndex = 11
        Me.txtPeso10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSexo10
        '
        Me.txtSexo10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo10.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo10.Location = New System.Drawing.Point(656, 0)
        Me.txtSexo10.MaxLength = 1
        Me.txtSexo10.Name = "txtSexo10"
        Me.txtSexo10.Size = New System.Drawing.Size(32, 18)
        Me.txtSexo10.TabIndex = 10
        Me.txtSexo10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaracteristicas10
        '
        Me.txtCaracteristicas10.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicas10.Location = New System.Drawing.Point(212, 0)
        Me.txtCaracteristicas10.MaxLength = 58
        Me.txtCaracteristicas10.Name = "txtCaracteristicas10"
        Me.txtCaracteristicas10.Size = New System.Drawing.Size(444, 18)
        Me.txtCaracteristicas10.TabIndex = 9
        '
        'txtTipo10
        '
        Me.txtTipo10.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo10.Location = New System.Drawing.Point(56, 0)
        Me.txtTipo10.MaxLength = 20
        Me.txtTipo10.Name = "txtTipo10"
        Me.txtTipo10.Size = New System.Drawing.Size(156, 18)
        Me.txtTipo10.TabIndex = 8
        Me.txtTipo10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño10
        '
        Me.txtAño10.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño10.Location = New System.Drawing.Point(8, 0)
        Me.txtAño10.MaxLength = 4
        Me.txtAño10.Name = "txtAño10"
        Me.txtAño10.Size = New System.Drawing.Size(48, 18)
        Me.txtAño10.TabIndex = 7
        Me.txtAño10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtVivo09)
        Me.Panel9.Controls.Add(Me.txtPeso09)
        Me.Panel9.Controls.Add(Me.txtSexo09)
        Me.Panel9.Controls.Add(Me.txtCaracteristicas09)
        Me.Panel9.Controls.Add(Me.txtTipo09)
        Me.Panel9.Controls.Add(Me.txtAño09)
        Me.Panel9.Location = New System.Drawing.Point(0, 160)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(772, 20)
        Me.Panel9.TabIndex = 15
        '
        'txtVivo09
        '
        Me.txtVivo09.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVivo09.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVivo09.Location = New System.Drawing.Point(736, 0)
        Me.txtVivo09.MaxLength = 1
        Me.txtVivo09.Name = "txtVivo09"
        Me.txtVivo09.Size = New System.Drawing.Size(32, 18)
        Me.txtVivo09.TabIndex = 12
        Me.txtVivo09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso09
        '
        Me.txtPeso09.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso09.Location = New System.Drawing.Point(688, 0)
        Me.txtPeso09.MaxLength = 4
        Me.txtPeso09.Name = "txtPeso09"
        Me.txtPeso09.Size = New System.Drawing.Size(48, 18)
        Me.txtPeso09.TabIndex = 11
        Me.txtPeso09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSexo09
        '
        Me.txtSexo09.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo09.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo09.Location = New System.Drawing.Point(656, 0)
        Me.txtSexo09.MaxLength = 1
        Me.txtSexo09.Name = "txtSexo09"
        Me.txtSexo09.Size = New System.Drawing.Size(32, 18)
        Me.txtSexo09.TabIndex = 10
        Me.txtSexo09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaracteristicas09
        '
        Me.txtCaracteristicas09.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicas09.Location = New System.Drawing.Point(212, 0)
        Me.txtCaracteristicas09.MaxLength = 58
        Me.txtCaracteristicas09.Name = "txtCaracteristicas09"
        Me.txtCaracteristicas09.Size = New System.Drawing.Size(444, 18)
        Me.txtCaracteristicas09.TabIndex = 9
        '
        'txtTipo09
        '
        Me.txtTipo09.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo09.Location = New System.Drawing.Point(56, 0)
        Me.txtTipo09.MaxLength = 20
        Me.txtTipo09.Name = "txtTipo09"
        Me.txtTipo09.Size = New System.Drawing.Size(156, 18)
        Me.txtTipo09.TabIndex = 8
        Me.txtTipo09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño09
        '
        Me.txtAño09.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño09.Location = New System.Drawing.Point(8, 0)
        Me.txtAño09.MaxLength = 4
        Me.txtAño09.Name = "txtAño09"
        Me.txtAño09.Size = New System.Drawing.Size(48, 18)
        Me.txtAño09.TabIndex = 7
        Me.txtAño09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtVivo08)
        Me.Panel8.Controls.Add(Me.txtPeso08)
        Me.Panel8.Controls.Add(Me.txtSexo08)
        Me.Panel8.Controls.Add(Me.txtCaracteristicas08)
        Me.Panel8.Controls.Add(Me.txtTipo08)
        Me.Panel8.Controls.Add(Me.txtAño08)
        Me.Panel8.Location = New System.Drawing.Point(0, 140)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(772, 20)
        Me.Panel8.TabIndex = 14
        '
        'txtVivo08
        '
        Me.txtVivo08.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVivo08.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVivo08.Location = New System.Drawing.Point(736, 0)
        Me.txtVivo08.MaxLength = 1
        Me.txtVivo08.Name = "txtVivo08"
        Me.txtVivo08.Size = New System.Drawing.Size(32, 18)
        Me.txtVivo08.TabIndex = 12
        Me.txtVivo08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso08
        '
        Me.txtPeso08.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso08.Location = New System.Drawing.Point(688, 0)
        Me.txtPeso08.MaxLength = 4
        Me.txtPeso08.Name = "txtPeso08"
        Me.txtPeso08.Size = New System.Drawing.Size(48, 18)
        Me.txtPeso08.TabIndex = 11
        Me.txtPeso08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSexo08
        '
        Me.txtSexo08.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo08.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo08.Location = New System.Drawing.Point(656, 0)
        Me.txtSexo08.MaxLength = 1
        Me.txtSexo08.Name = "txtSexo08"
        Me.txtSexo08.Size = New System.Drawing.Size(32, 18)
        Me.txtSexo08.TabIndex = 10
        Me.txtSexo08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaracteristicas08
        '
        Me.txtCaracteristicas08.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicas08.Location = New System.Drawing.Point(212, 0)
        Me.txtCaracteristicas08.MaxLength = 58
        Me.txtCaracteristicas08.Name = "txtCaracteristicas08"
        Me.txtCaracteristicas08.Size = New System.Drawing.Size(444, 18)
        Me.txtCaracteristicas08.TabIndex = 9
        '
        'txtTipo08
        '
        Me.txtTipo08.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo08.Location = New System.Drawing.Point(56, 0)
        Me.txtTipo08.MaxLength = 20
        Me.txtTipo08.Name = "txtTipo08"
        Me.txtTipo08.Size = New System.Drawing.Size(156, 18)
        Me.txtTipo08.TabIndex = 8
        Me.txtTipo08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño08
        '
        Me.txtAño08.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño08.Location = New System.Drawing.Point(8, 0)
        Me.txtAño08.MaxLength = 4
        Me.txtAño08.Name = "txtAño08"
        Me.txtAño08.Size = New System.Drawing.Size(48, 18)
        Me.txtAño08.TabIndex = 7
        Me.txtAño08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtVivo07)
        Me.Panel7.Controls.Add(Me.txtPeso07)
        Me.Panel7.Controls.Add(Me.txtSexo07)
        Me.Panel7.Controls.Add(Me.txtCaracteristicas07)
        Me.Panel7.Controls.Add(Me.txtTipo07)
        Me.Panel7.Controls.Add(Me.txtAño07)
        Me.Panel7.Location = New System.Drawing.Point(0, 120)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(772, 20)
        Me.Panel7.TabIndex = 13
        '
        'txtVivo07
        '
        Me.txtVivo07.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVivo07.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVivo07.Location = New System.Drawing.Point(736, 0)
        Me.txtVivo07.MaxLength = 1
        Me.txtVivo07.Name = "txtVivo07"
        Me.txtVivo07.Size = New System.Drawing.Size(32, 18)
        Me.txtVivo07.TabIndex = 12
        Me.txtVivo07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso07
        '
        Me.txtPeso07.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso07.Location = New System.Drawing.Point(688, 0)
        Me.txtPeso07.MaxLength = 4
        Me.txtPeso07.Name = "txtPeso07"
        Me.txtPeso07.Size = New System.Drawing.Size(48, 18)
        Me.txtPeso07.TabIndex = 11
        Me.txtPeso07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSexo07
        '
        Me.txtSexo07.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo07.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo07.Location = New System.Drawing.Point(656, 0)
        Me.txtSexo07.MaxLength = 1
        Me.txtSexo07.Name = "txtSexo07"
        Me.txtSexo07.Size = New System.Drawing.Size(32, 18)
        Me.txtSexo07.TabIndex = 10
        Me.txtSexo07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaracteristicas07
        '
        Me.txtCaracteristicas07.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicas07.Location = New System.Drawing.Point(212, 0)
        Me.txtCaracteristicas07.MaxLength = 58
        Me.txtCaracteristicas07.Name = "txtCaracteristicas07"
        Me.txtCaracteristicas07.Size = New System.Drawing.Size(444, 18)
        Me.txtCaracteristicas07.TabIndex = 9
        '
        'txtTipo07
        '
        Me.txtTipo07.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo07.Location = New System.Drawing.Point(56, 0)
        Me.txtTipo07.MaxLength = 20
        Me.txtTipo07.Name = "txtTipo07"
        Me.txtTipo07.Size = New System.Drawing.Size(156, 18)
        Me.txtTipo07.TabIndex = 8
        Me.txtTipo07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño07
        '
        Me.txtAño07.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño07.Location = New System.Drawing.Point(8, 0)
        Me.txtAño07.MaxLength = 4
        Me.txtAño07.Name = "txtAño07"
        Me.txtAño07.Size = New System.Drawing.Size(48, 18)
        Me.txtAño07.TabIndex = 7
        Me.txtAño07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtVivo06)
        Me.Panel6.Controls.Add(Me.txtPeso06)
        Me.Panel6.Controls.Add(Me.txtSexo06)
        Me.Panel6.Controls.Add(Me.txtCaracteristicas06)
        Me.Panel6.Controls.Add(Me.txtTipo06)
        Me.Panel6.Controls.Add(Me.txtAño06)
        Me.Panel6.Location = New System.Drawing.Point(0, 100)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(772, 20)
        Me.Panel6.TabIndex = 12
        '
        'txtVivo06
        '
        Me.txtVivo06.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVivo06.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVivo06.Location = New System.Drawing.Point(736, 0)
        Me.txtVivo06.MaxLength = 1
        Me.txtVivo06.Name = "txtVivo06"
        Me.txtVivo06.Size = New System.Drawing.Size(32, 18)
        Me.txtVivo06.TabIndex = 12
        Me.txtVivo06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso06
        '
        Me.txtPeso06.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso06.Location = New System.Drawing.Point(688, 0)
        Me.txtPeso06.MaxLength = 4
        Me.txtPeso06.Name = "txtPeso06"
        Me.txtPeso06.Size = New System.Drawing.Size(48, 18)
        Me.txtPeso06.TabIndex = 11
        Me.txtPeso06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSexo06
        '
        Me.txtSexo06.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo06.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo06.Location = New System.Drawing.Point(656, 0)
        Me.txtSexo06.MaxLength = 1
        Me.txtSexo06.Name = "txtSexo06"
        Me.txtSexo06.Size = New System.Drawing.Size(32, 18)
        Me.txtSexo06.TabIndex = 10
        Me.txtSexo06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaracteristicas06
        '
        Me.txtCaracteristicas06.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicas06.Location = New System.Drawing.Point(212, 0)
        Me.txtCaracteristicas06.MaxLength = 58
        Me.txtCaracteristicas06.Name = "txtCaracteristicas06"
        Me.txtCaracteristicas06.Size = New System.Drawing.Size(444, 18)
        Me.txtCaracteristicas06.TabIndex = 9
        '
        'txtTipo06
        '
        Me.txtTipo06.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo06.Location = New System.Drawing.Point(56, 0)
        Me.txtTipo06.MaxLength = 20
        Me.txtTipo06.Name = "txtTipo06"
        Me.txtTipo06.Size = New System.Drawing.Size(156, 18)
        Me.txtTipo06.TabIndex = 8
        Me.txtTipo06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño06
        '
        Me.txtAño06.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño06.Location = New System.Drawing.Point(8, 0)
        Me.txtAño06.MaxLength = 4
        Me.txtAño06.Name = "txtAño06"
        Me.txtAño06.Size = New System.Drawing.Size(48, 18)
        Me.txtAño06.TabIndex = 7
        Me.txtAño06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtVivo05)
        Me.Panel5.Controls.Add(Me.txtPeso05)
        Me.Panel5.Controls.Add(Me.txtSexo05)
        Me.Panel5.Controls.Add(Me.txtCaracteristicas05)
        Me.Panel5.Controls.Add(Me.txtTipo05)
        Me.Panel5.Controls.Add(Me.txtAño05)
        Me.Panel5.Location = New System.Drawing.Point(0, 80)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(772, 20)
        Me.Panel5.TabIndex = 11
        '
        'txtVivo05
        '
        Me.txtVivo05.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVivo05.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVivo05.Location = New System.Drawing.Point(736, 0)
        Me.txtVivo05.MaxLength = 1
        Me.txtVivo05.Name = "txtVivo05"
        Me.txtVivo05.Size = New System.Drawing.Size(32, 18)
        Me.txtVivo05.TabIndex = 12
        Me.txtVivo05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso05
        '
        Me.txtPeso05.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso05.Location = New System.Drawing.Point(688, 0)
        Me.txtPeso05.MaxLength = 4
        Me.txtPeso05.Name = "txtPeso05"
        Me.txtPeso05.Size = New System.Drawing.Size(48, 18)
        Me.txtPeso05.TabIndex = 11
        Me.txtPeso05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSexo05
        '
        Me.txtSexo05.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo05.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo05.Location = New System.Drawing.Point(656, 0)
        Me.txtSexo05.MaxLength = 1
        Me.txtSexo05.Name = "txtSexo05"
        Me.txtSexo05.Size = New System.Drawing.Size(32, 18)
        Me.txtSexo05.TabIndex = 10
        Me.txtSexo05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaracteristicas05
        '
        Me.txtCaracteristicas05.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicas05.Location = New System.Drawing.Point(212, 0)
        Me.txtCaracteristicas05.MaxLength = 58
        Me.txtCaracteristicas05.Name = "txtCaracteristicas05"
        Me.txtCaracteristicas05.Size = New System.Drawing.Size(444, 18)
        Me.txtCaracteristicas05.TabIndex = 9
        '
        'txtTipo05
        '
        Me.txtTipo05.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo05.Location = New System.Drawing.Point(56, 0)
        Me.txtTipo05.MaxLength = 20
        Me.txtTipo05.Name = "txtTipo05"
        Me.txtTipo05.Size = New System.Drawing.Size(156, 18)
        Me.txtTipo05.TabIndex = 8
        Me.txtTipo05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño05
        '
        Me.txtAño05.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño05.Location = New System.Drawing.Point(8, 0)
        Me.txtAño05.MaxLength = 4
        Me.txtAño05.Name = "txtAño05"
        Me.txtAño05.Size = New System.Drawing.Size(48, 18)
        Me.txtAño05.TabIndex = 7
        Me.txtAño05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtVivo04)
        Me.Panel4.Controls.Add(Me.txtPeso04)
        Me.Panel4.Controls.Add(Me.txtSexo04)
        Me.Panel4.Controls.Add(Me.txtCaracteristicas04)
        Me.Panel4.Controls.Add(Me.txtTipo04)
        Me.Panel4.Controls.Add(Me.txtAño04)
        Me.Panel4.Location = New System.Drawing.Point(0, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(772, 20)
        Me.Panel4.TabIndex = 10
        '
        'txtVivo04
        '
        Me.txtVivo04.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVivo04.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVivo04.Location = New System.Drawing.Point(736, 0)
        Me.txtVivo04.MaxLength = 1
        Me.txtVivo04.Name = "txtVivo04"
        Me.txtVivo04.Size = New System.Drawing.Size(32, 18)
        Me.txtVivo04.TabIndex = 12
        Me.txtVivo04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso04
        '
        Me.txtPeso04.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso04.Location = New System.Drawing.Point(688, 0)
        Me.txtPeso04.MaxLength = 4
        Me.txtPeso04.Name = "txtPeso04"
        Me.txtPeso04.Size = New System.Drawing.Size(48, 18)
        Me.txtPeso04.TabIndex = 11
        Me.txtPeso04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSexo04
        '
        Me.txtSexo04.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo04.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo04.Location = New System.Drawing.Point(656, 0)
        Me.txtSexo04.MaxLength = 1
        Me.txtSexo04.Name = "txtSexo04"
        Me.txtSexo04.Size = New System.Drawing.Size(32, 18)
        Me.txtSexo04.TabIndex = 10
        Me.txtSexo04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaracteristicas04
        '
        Me.txtCaracteristicas04.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicas04.Location = New System.Drawing.Point(212, 0)
        Me.txtCaracteristicas04.MaxLength = 58
        Me.txtCaracteristicas04.Name = "txtCaracteristicas04"
        Me.txtCaracteristicas04.Size = New System.Drawing.Size(444, 18)
        Me.txtCaracteristicas04.TabIndex = 9
        '
        'txtTipo04
        '
        Me.txtTipo04.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo04.Location = New System.Drawing.Point(56, 0)
        Me.txtTipo04.MaxLength = 20
        Me.txtTipo04.Name = "txtTipo04"
        Me.txtTipo04.Size = New System.Drawing.Size(156, 18)
        Me.txtTipo04.TabIndex = 8
        Me.txtTipo04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño04
        '
        Me.txtAño04.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño04.Location = New System.Drawing.Point(8, 0)
        Me.txtAño04.MaxLength = 4
        Me.txtAño04.Name = "txtAño04"
        Me.txtAño04.Size = New System.Drawing.Size(48, 18)
        Me.txtAño04.TabIndex = 7
        Me.txtAño04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtVivo03)
        Me.Panel3.Controls.Add(Me.txtPeso03)
        Me.Panel3.Controls.Add(Me.txtSexo03)
        Me.Panel3.Controls.Add(Me.txtCaracteristicas03)
        Me.Panel3.Controls.Add(Me.txtTipo03)
        Me.Panel3.Controls.Add(Me.txtAño03)
        Me.Panel3.Location = New System.Drawing.Point(0, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(772, 20)
        Me.Panel3.TabIndex = 9
        '
        'txtVivo03
        '
        Me.txtVivo03.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVivo03.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVivo03.Location = New System.Drawing.Point(736, 0)
        Me.txtVivo03.MaxLength = 1
        Me.txtVivo03.Name = "txtVivo03"
        Me.txtVivo03.Size = New System.Drawing.Size(32, 18)
        Me.txtVivo03.TabIndex = 12
        Me.txtVivo03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso03
        '
        Me.txtPeso03.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso03.Location = New System.Drawing.Point(688, 0)
        Me.txtPeso03.MaxLength = 4
        Me.txtPeso03.Name = "txtPeso03"
        Me.txtPeso03.Size = New System.Drawing.Size(48, 18)
        Me.txtPeso03.TabIndex = 11
        Me.txtPeso03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSexo03
        '
        Me.txtSexo03.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo03.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo03.Location = New System.Drawing.Point(656, 0)
        Me.txtSexo03.MaxLength = 1
        Me.txtSexo03.Name = "txtSexo03"
        Me.txtSexo03.Size = New System.Drawing.Size(32, 18)
        Me.txtSexo03.TabIndex = 10
        Me.txtSexo03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaracteristicas03
        '
        Me.txtCaracteristicas03.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicas03.Location = New System.Drawing.Point(212, 0)
        Me.txtCaracteristicas03.MaxLength = 58
        Me.txtCaracteristicas03.Name = "txtCaracteristicas03"
        Me.txtCaracteristicas03.Size = New System.Drawing.Size(444, 18)
        Me.txtCaracteristicas03.TabIndex = 9
        '
        'txtTipo03
        '
        Me.txtTipo03.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo03.Location = New System.Drawing.Point(56, 0)
        Me.txtTipo03.MaxLength = 20
        Me.txtTipo03.Name = "txtTipo03"
        Me.txtTipo03.Size = New System.Drawing.Size(156, 18)
        Me.txtTipo03.TabIndex = 8
        Me.txtTipo03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño03
        '
        Me.txtAño03.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño03.Location = New System.Drawing.Point(8, 0)
        Me.txtAño03.MaxLength = 4
        Me.txtAño03.Name = "txtAño03"
        Me.txtAño03.Size = New System.Drawing.Size(48, 18)
        Me.txtAño03.TabIndex = 7
        Me.txtAño03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtVivo02)
        Me.Panel2.Controls.Add(Me.txtPeso02)
        Me.Panel2.Controls.Add(Me.txtSexo02)
        Me.Panel2.Controls.Add(Me.txtCaracteristicas02)
        Me.Panel2.Controls.Add(Me.txtTipo02)
        Me.Panel2.Controls.Add(Me.txtAño02)
        Me.Panel2.Location = New System.Drawing.Point(0, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 20)
        Me.Panel2.TabIndex = 8
        '
        'txtVivo02
        '
        Me.txtVivo02.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVivo02.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVivo02.Location = New System.Drawing.Point(736, 0)
        Me.txtVivo02.MaxLength = 1
        Me.txtVivo02.Name = "txtVivo02"
        Me.txtVivo02.Size = New System.Drawing.Size(32, 18)
        Me.txtVivo02.TabIndex = 12
        Me.txtVivo02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso02
        '
        Me.txtPeso02.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso02.Location = New System.Drawing.Point(688, 0)
        Me.txtPeso02.MaxLength = 4
        Me.txtPeso02.Name = "txtPeso02"
        Me.txtPeso02.Size = New System.Drawing.Size(48, 18)
        Me.txtPeso02.TabIndex = 11
        Me.txtPeso02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSexo02
        '
        Me.txtSexo02.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo02.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo02.Location = New System.Drawing.Point(656, 0)
        Me.txtSexo02.MaxLength = 1
        Me.txtSexo02.Name = "txtSexo02"
        Me.txtSexo02.Size = New System.Drawing.Size(32, 18)
        Me.txtSexo02.TabIndex = 10
        Me.txtSexo02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaracteristicas02
        '
        Me.txtCaracteristicas02.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicas02.Location = New System.Drawing.Point(212, 0)
        Me.txtCaracteristicas02.MaxLength = 58
        Me.txtCaracteristicas02.Name = "txtCaracteristicas02"
        Me.txtCaracteristicas02.Size = New System.Drawing.Size(444, 18)
        Me.txtCaracteristicas02.TabIndex = 9
        '
        'txtTipo02
        '
        Me.txtTipo02.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo02.Location = New System.Drawing.Point(56, 0)
        Me.txtTipo02.MaxLength = 20
        Me.txtTipo02.Name = "txtTipo02"
        Me.txtTipo02.Size = New System.Drawing.Size(156, 18)
        Me.txtTipo02.TabIndex = 8
        Me.txtTipo02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño02
        '
        Me.txtAño02.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño02.Location = New System.Drawing.Point(8, 0)
        Me.txtAño02.MaxLength = 4
        Me.txtAño02.Name = "txtAño02"
        Me.txtAño02.Size = New System.Drawing.Size(48, 18)
        Me.txtAño02.TabIndex = 7
        Me.txtAño02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtVivo01)
        Me.Panel1.Controls.Add(Me.txtPeso01)
        Me.Panel1.Controls.Add(Me.txtSexo01)
        Me.Panel1.Controls.Add(Me.txtCaracteristicas01)
        Me.Panel1.Controls.Add(Me.txtTipo01)
        Me.Panel1.Controls.Add(Me.txtAño01)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 20)
        Me.Panel1.TabIndex = 7
        '
        'txtVivo01
        '
        Me.txtVivo01.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVivo01.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVivo01.Location = New System.Drawing.Point(736, 0)
        Me.txtVivo01.MaxLength = 1
        Me.txtVivo01.Name = "txtVivo01"
        Me.txtVivo01.Size = New System.Drawing.Size(32, 18)
        Me.txtVivo01.TabIndex = 12
        Me.txtVivo01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso01
        '
        Me.txtPeso01.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso01.Location = New System.Drawing.Point(688, 0)
        Me.txtPeso01.MaxLength = 4
        Me.txtPeso01.Name = "txtPeso01"
        Me.txtPeso01.Size = New System.Drawing.Size(48, 18)
        Me.txtPeso01.TabIndex = 11
        Me.txtPeso01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSexo01
        '
        Me.txtSexo01.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo01.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo01.Location = New System.Drawing.Point(656, 0)
        Me.txtSexo01.MaxLength = 1
        Me.txtSexo01.Name = "txtSexo01"
        Me.txtSexo01.Size = New System.Drawing.Size(32, 18)
        Me.txtSexo01.TabIndex = 10
        Me.txtSexo01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaracteristicas01
        '
        Me.txtCaracteristicas01.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaracteristicas01.Location = New System.Drawing.Point(212, 0)
        Me.txtCaracteristicas01.MaxLength = 58
        Me.txtCaracteristicas01.Name = "txtCaracteristicas01"
        Me.txtCaracteristicas01.Size = New System.Drawing.Size(444, 18)
        Me.txtCaracteristicas01.TabIndex = 9
        '
        'txtTipo01
        '
        Me.txtTipo01.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo01.Location = New System.Drawing.Point(56, 0)
        Me.txtTipo01.MaxLength = 20
        Me.txtTipo01.Name = "txtTipo01"
        Me.txtTipo01.Size = New System.Drawing.Size(156, 18)
        Me.txtTipo01.TabIndex = 8
        Me.txtTipo01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAño01
        '
        Me.txtAño01.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño01.Location = New System.Drawing.Point(8, 0)
        Me.txtAño01.MaxLength = 4
        Me.txtAño01.Name = "txtAño01"
        Me.txtAño01.Size = New System.Drawing.Size(48, 18)
        Me.txtAño01.TabIndex = 7
        Me.txtAño01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(16, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Año"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(64, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Tipo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(220, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(442, 23)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Características"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(662, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 23)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Sexo"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(744, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 23)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Vivo"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(696, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 23)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Peso"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox18)
        Me.GroupBox1.Controls.Add(Me.CheckBox17)
        Me.GroupBox1.Controls.Add(Me.CheckBox16)
        Me.GroupBox1.Controls.Add(Me.CheckBox15)
        Me.GroupBox1.Controls.Add(Me.CheckBox14)
        Me.GroupBox1.Controls.Add(Me.CheckBox13)
        Me.GroupBox1.Controls.Add(Me.CheckBox12)
        Me.GroupBox1.Controls.Add(Me.CheckBox11)
        Me.GroupBox1.Controls.Add(Me.CheckBox10)
        Me.GroupBox1.Controls.Add(Me.CheckBox9)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 204)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Antecedentes"
        '
        'CheckBox18
        '
        Me.CheckBox18.Location = New System.Drawing.Point(232, 176)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox18.TabIndex = 17
        Me.CheckBox18.Text = "Oligohidramnios"
        '
        'CheckBox17
        '
        Me.CheckBox17.Location = New System.Drawing.Point(232, 156)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox17.TabIndex = 16
        Me.CheckBox17.Text = "Sufrimiento Fetal"
        '
        'CheckBox16
        '
        Me.CheckBox16.Location = New System.Drawing.Point(232, 136)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox16.TabIndex = 15
        Me.CheckBox16.Text = "Obito Fetal"
        '
        'CheckBox15
        '
        Me.CheckBox15.Location = New System.Drawing.Point(232, 116)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox15.TabIndex = 14
        Me.CheckBox15.Text = "Hipertiroidismo y embarazo"
        '
        'CheckBox14
        '
        Me.CheckBox14.Location = New System.Drawing.Point(232, 96)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox14.TabIndex = 13
        Me.CheckBox14.Text = "Hipotiroidismo y embarazo"
        '
        'CheckBox13
        '
        Me.CheckBox13.Location = New System.Drawing.Point(232, 76)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox13.TabIndex = 12
        Me.CheckBox13.Text = "Isoinmunización Rh"
        '
        'CheckBox12
        '
        Me.CheckBox12.Location = New System.Drawing.Point(232, 56)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox12.TabIndex = 11
        Me.CheckBox12.Text = "Nefropatía y embarazo"
        '
        'CheckBox11
        '
        Me.CheckBox11.Location = New System.Drawing.Point(232, 36)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox11.TabIndex = 10
        Me.CheckBox11.Text = "Diabetes gestacional"
        '
        'CheckBox10
        '
        Me.CheckBox10.Location = New System.Drawing.Point(232, 16)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox10.TabIndex = 9
        Me.CheckBox10.Text = "Cardiopatía y embarazo"
        '
        'CheckBox9
        '
        Me.CheckBox9.Location = New System.Drawing.Point(8, 176)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox9.TabIndex = 8
        Me.CheckBox9.Text = "Polihidramnios"
        '
        'CheckBox8
        '
        Me.CheckBox8.Location = New System.Drawing.Point(8, 156)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "Parto Instrumental"
        '
        'CheckBox7
        '
        Me.CheckBox7.Location = New System.Drawing.Point(8, 136)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(128, 24)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "Embarazo Múltiple"
        '
        'CheckBox5
        '
        Me.CheckBox5.Location = New System.Drawing.Point(8, 96)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "Trabajo de Parto Pretérmino"
        '
        'CheckBox4
        '
        Me.CheckBox4.Location = New System.Drawing.Point(8, 76)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(128, 24)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "DPP"
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(8, 56)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(104, 24)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Placenta Previa"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(8, 36)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(160, 24)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Enfermedad Trofoblastica"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(8, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Preeclampsia"
        '
        'CheckBox6
        '
        Me.CheckBox6.Location = New System.Drawing.Point(8, 116)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(208, 24)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "Emb. Cronológicamente Prolongado"
        '
        'FormAntObstetricos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PanelEmbarazos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.botAceptar)
        Me.Controls.Add(Me.botCancelar)
        Me.Controls.Add(Me.Label7)
        Me.Name = "FormAntObstetricos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antecedentes Obstétricos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelEmbarazos.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'VARIABLES DEL PROCEDIMIENTO
    Dim fileAntObstetricos As String


    

    Dim AO As Form1.TablaDeAntecedentesObstetricos




    Dim booDatosModificados As Boolean
    Dim intNumeroGestaciones As Integer
    Dim intNumeroAbortos As Integer
    Dim intNumeroPartos As Integer
    Dim intNumeroCesareas As Integer
    Dim intNumeroEctopicos As Integer

    Dim booPrimeraVezQuedaMas As Boolean

    'variables del tratamiento de las partes de los panels
    Dim strLinea As String
    Dim arrDstrPartes(5) As String

    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim FlechitaArribaOFF, FlechitaArribaON As Image
    Dim FlechitaAbajoOFF, FlechitaAbajoON As Image
    Dim BarraSinMensaje As Image


    Private Sub FormAntObstetricos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Form1.PSbooConsultaAntecedentesObstetricos = True Then

            'se esta accediendo para consultar los antedentes y regresar con los datos

            Form1.PSbooConsultaAntecedentesObstetricos = False 'apaga la bandera

            'primero crea los nombres y pone todo en cero
            InicializaParaConsulta()
           
            'ahora revisa si existe un archivo de antecedentes
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
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else
                'no hay datos responde en blanco
                Form1.PSstrResultadoAntecedentesObstetricos = ""
                Form1.PSstrPacienteSeleccionadaParidad = ""
                Form1.PSintPesoMaximo = 0

                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        Else
            'se esta accediendo normalemente para editar

            'primero crea los nombres y pone todo en cero
            Inicializa()
            'ahora revisa si existe un archivo de antecedentes
            If File.Exists(fileAntObstetricos) = True Then
                'existe un archivo lo carga y muestra
                'Carga el registro previo de antecedentes familiares
                CargaAntecedentesObstetricos()
                'actualiza los datos numericos con la estructura
                ActualizaDatosNumericosConLaEstructura()
                'muestra los paneles adecuados en  pantalla
                ActualizaPanelesEnPantalla()
                'rellena los paneles con los datos recuperados
                MuestraContenidoDeLosPaneles()

                'dice a la bandera que no se han producido cambios y lo pone al principo asi
                booDatosModificados = False
                botCancelar.Text = "Salir"
                'botAceptar.Enabled = False

            Else
                'se esta creando un archivo nuevo
                'se escribe la estructura en blanco para darle formato
                'EscribeAntecedentesObstetricosAlDisco()
                'como se esta creando algo nuevo prende de una vez el boton aceptar para guardar si se decide hacerlo aun sin cambios q seria nuligesta
                booDatosModificados = True
                botCancelar.Text = "Descarta Cambios"
                'botAceptar.Enabled = True

            End If



        End If



    End Sub

    Private Sub Inicializa()
        'crea el nombre del archivo de antecedentes 
        fileAntObstetricos = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Obstetricos.dat"

        'le pone nombre al titulo
        Me.Text = "Antecedentes Obstétricos de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        'nombre de los graficos
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff
        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
        BarraSinMensaje = Form1.BarraSinMensaje
        FlechitaArribaOFF = Form1.FlechitaArribaOFF
        FlechitaArribaON = Form1.FlechitaArribaON
        FlechitaAbajoOFF = Form1.FlechitaAbajoOFF
        FlechitaAbajoON = Form1.FlechitaAbajoON

        'inicializa los valores
        intNumeroGestaciones = 0
        intNumeroAbortos = 0
        intNumeroPartos = 0
        intNumeroCesareas = 0
        intNumeroEctopicos = 0

        'inicializa la variable de respuesta local
        Form1.PSstrResultadoAntecedentesObstetricos = ""

        'coloca los valores en pantalla
        labGesta.Text = ""
        labAbo.Text = ""
        labPara.Text = ""
        labEcto.Text = ""
        labCesa.Text = ""
        txtOtrosNotas.Text = ""

        'actualiza la pantalla, (apaga todos porq esta en cero)
        ActualizaPanelesEnPantalla()

        'inicializa la variable para saber si es la 1ra vez
        'que se pasa el #de gestaciones para el aviso
        'de embarazos multiples
        booPrimeraVezQuedaMas = True

        InicializaEstructura()


    End Sub

    Private Sub InicializaParaConsulta()
        'crea el nombre del archivo de antecedentes 
        fileAntObstetricos = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Obstetricos.dat"

        'inicializa los valores
        intNumeroGestaciones = 0
        intNumeroAbortos = 0
        intNumeroPartos = 0
        intNumeroCesareas = 0
        intNumeroEctopicos = 0

        'inicializa la variable de respuesta local
        Form1.PSstrResultadoAntecedentesObstetricos = ""

    End Sub

    Private Sub InicializaEstructura()
        AO.a01Gestas = "" : AO.a02Paras = "" : AO.a03Cesareas = "" : AO.a04Abortos = "" : AO.a05Ectopicos = ""
        AO.a06strNotas = "" : AO.Dato006 = "" : AO.Dato007 = "" : AO.Dato008 = "" : AO.Dato009 = ""
        AO.Dato010 = "" : AO.Dato011 = "" : AO.Dato012 = "" : AO.Dato013 = "" : AO.Dato014 = ""
        AO.Dato015 = "" : AO.Dato016 = "" : AO.Dato017 = "" : AO.Dato018 = "" : AO.Dato019 = ""
        AO.Dato020 = "" : AO.Dato021 = "" : AO.Dato022 = "" : AO.Dato023 = "" : AO.Dato024 = ""
        AO.Dato025 = "" : AO.Dato026 = "" : AO.Dato027 = "" : AO.Dato028 = "" : AO.Dato029 = ""
        AO.Dato030 = "" : AO.Dato031 = "" : AO.Dato032 = "" : AO.Dato033 = "" : AO.Dato034 = ""
        AO.Dato035 = "" : AO.Dato036 = "" : AO.Dato037 = "" : AO.Dato038 = "" : AO.Dato039 = ""
        AO.Dato040 = "" : AO.Dato041 = "" : AO.Dato042 = "" : AO.Dato043 = "" : AO.Dato044peso01 = ""
        AO.Dato045 = "" : AO.Dato046 = "" : AO.Dato047 = "" : AO.Dato048 = "" : AO.Dato049 = ""
        AO.Dato050 = "" : AO.Dato051 = "" : AO.Dato052 = "" : AO.Dato053 = "" : AO.Dato054peso02 = ""
        AO.Dato055 = "" : AO.Dato056 = "" : AO.Dato057 = "" : AO.Dato058 = "" : AO.Dato059 = ""
        AO.Dato060 = "" : AO.Dato061 = "" : AO.Dato062 = "" : AO.Dato063 = "" : AO.Dato064peso03 = ""
        AO.Dato065 = "" : AO.Dato066 = "" : AO.Dato067 = "" : AO.Dato068 = "" : AO.Dato069 = ""
        AO.Dato070 = "" : AO.Dato071 = "" : AO.Dato072 = "" : AO.Dato073 = "" : AO.Dato074peso04 = ""
        AO.Dato075 = "" : AO.Dato076 = "" : AO.Dato077 = "" : AO.Dato078 = "" : AO.Dato079 = ""
        AO.Dato080 = "" : AO.Dato081 = "" : AO.Dato082 = "" : AO.Dato083 = "" : AO.Dato084peso05 = ""
        AO.Dato085 = "" : AO.Dato086 = "" : AO.Dato087 = "" : AO.Dato088 = "" : AO.Dato089 = ""
        AO.Dato090 = "" : AO.Dato091 = "" : AO.Dato092 = "" : AO.Dato093 = "" : AO.Dato094peso06 = ""
        AO.Dato095 = "" : AO.Dato096 = "" : AO.Dato097 = "" : AO.Dato098 = "" : AO.Dato099 = ""
        AO.Dato100 = "" : AO.Dato101 = "" : AO.Dato102 = "" : AO.Dato103 = "" : AO.Dato104peso07 = ""
        AO.Dato105 = "" : AO.Dato106 = "" : AO.Dato107 = "" : AO.Dato108 = "" : AO.Dato109 = ""
        AO.Dato110 = "" : AO.Dato111 = "" : AO.Dato112 = "" : AO.Dato113 = "" : AO.Dato114peso08 = ""
        AO.Dato115 = "" : AO.Dato116 = "" : AO.Dato117 = "" : AO.Dato118 = "" : AO.Dato119 = ""
        AO.Dato120 = "" : AO.Dato121 = "" : AO.Dato122 = "" : AO.Dato123 = "" : AO.Dato124peso09 = ""
        AO.Dato125 = "" : AO.Dato126 = "" : AO.Dato127 = "" : AO.Dato128 = "" : AO.Dato129 = ""
        AO.Dato130 = "" : AO.Dato131 = "" : AO.Dato132 = "" : AO.Dato133 = "" : AO.Dato134peso10 = ""
        AO.Dato135 = "" : AO.Dato136 = "" : AO.Dato137 = "" : AO.Dato138 = "" : AO.Dato139 = ""
        AO.Dato140 = "" : AO.Dato141 = "" : AO.Dato142 = "" : AO.Dato143 = "" : AO.Dato144 = ""
        AO.Dato145 = "" : AO.Dato146 = "" : AO.Dato147 = "" : AO.Dato148 = "" : AO.Dato149 = ""
    End Sub

    Private Sub CargaAntecedentesObstetricos()
        Dim FS As FileStream
        Dim BR As BinaryReader

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

    Private Sub ActualizaPanelesEnPantalla()

        Dim SumaDeGestaciones As Integer
        Dim NumeroCasillas As Integer

        SumaDeGestaciones = intNumeroPartos + intNumeroAbortos + intNumeroCesareas + intNumeroEctopicos
        If intNumeroGestaciones = 0 Then
            NumeroCasillas = 0
            booPrimeraVezQuedaMas = True
        Else
            PrendeBotonesAdicionales()
            txtOtrosNotas.Enabled = True

            If SumaDeGestaciones > intNumeroGestaciones Then
                NumeroCasillas = SumaDeGestaciones
                If booPrimeraVezQuedaMas = True Then
                    MsgBox("La suma de los partos, cesareas y abortos es mayor que el numero de gestaciones," & vbCrLf & _
                           "deben existir embarazos gemelares, por favor acláralo en las notas...", MsgBoxStyle.Information, "Antecedentes Obstétricos")
                End If
                booPrimeraVezQuedaMas = False
            Else
                booPrimeraVezQuedaMas = True
                NumeroCasillas = intNumeroGestaciones
            End If
        End If

        If NumeroCasillas < 1 Then
            intNumeroAbortos = 0
            intNumeroPartos = 0
            intNumeroCesareas = 0
            intNumeroEctopicos = 0

            ApagaBotonesAdicionales()

            labPara.Text = ""
            labAbo.Text = ""
            labCesa.Text = ""
            labEcto.Text = ""
            txtOtrosNotas.Text = ""
            txtOtrosNotas.Enabled = False

            BorrayApagaPanelDeLaDerecha()
            txtAño01.Clear()
            txtTipo01.Clear()
            txtCaracteristicas01.Clear()
            txtSexo01.Clear()
            txtPeso01.Clear()
            txtVivo01.Clear()
            Panel1.Visible = False

        End If

        If NumeroCasillas < 2 Then
            txtAño02.Clear()
            txtTipo02.Clear()
            txtCaracteristicas02.Clear()
            txtSexo02.Clear()
            txtPeso02.Clear()
            txtVivo02.Clear()
            Panel2.Visible = False
        End If

        If NumeroCasillas < 3 Then
            txtAño03.Clear()
            txtTipo03.Clear()
            txtCaracteristicas03.Clear()
            txtSexo03.Clear()
            txtPeso03.Clear()
            txtVivo03.Clear()
            Panel3.Visible = False
        End If
        If NumeroCasillas < 4 Then
            txtAño04.Clear()
            txtTipo04.Clear()
            txtCaracteristicas04.Clear()
            txtSexo04.Clear()
            txtPeso04.Clear()
            txtVivo04.Clear()
            Panel4.Visible = False
        End If
        If NumeroCasillas < 5 Then
            txtAño05.Clear()
            txtTipo05.Clear()
            txtCaracteristicas05.Clear()
            txtSexo05.Clear()
            txtPeso05.Clear()
            txtVivo05.Clear()
            Panel5.Visible = False
        End If
        If NumeroCasillas < 6 Then
            txtAño06.Clear()
            txtTipo06.Clear()
            txtCaracteristicas06.Clear()
            txtSexo06.Clear()
            txtPeso06.Clear()
            txtVivo06.Clear()
            Panel6.Visible = False
        End If
        If NumeroCasillas < 7 Then
            txtAño07.Clear()
            txtTipo07.Clear()
            txtCaracteristicas07.Clear()
            txtSexo07.Clear()
            txtPeso07.Clear()
            txtVivo07.Clear()
            Panel7.Visible = False
        End If
        If NumeroCasillas < 8 Then
            txtAño08.Clear()
            txtTipo08.Clear()
            txtCaracteristicas08.Clear()
            txtSexo08.Clear()
            txtPeso08.Clear()
            txtVivo08.Clear()
            Panel8.Visible = False
        End If
        If NumeroCasillas < 9 Then
            txtAño09.Clear()
            txtTipo09.Clear()
            txtCaracteristicas09.Clear()
            txtSexo09.Clear()
            txtPeso09.Clear()
            txtVivo09.Clear()
            Panel9.Visible = False
        End If
        If NumeroCasillas < 10 Then
            txtAño10.Clear()
            txtTipo10.Clear()
            txtCaracteristicas10.Clear()
            txtSexo10.Clear()
            txtPeso10.Clear()
            txtVivo10.Clear()
            Panel10.Visible = False
        End If
        If NumeroCasillas = 10 Then
            'no apaga ninguno deja todo igual
        End If

        'zona de prender:
        If NumeroCasillas > 0 Then
            Panel1.Visible = True
            GroupBox1.Enabled = True
        End If
        If NumeroCasillas > 1 Then
            Panel2.Visible = True
        End If
        If NumeroCasillas > 2 Then
            Panel3.Visible = True
        End If
        If NumeroCasillas > 3 Then
            Panel4.Visible = True
        End If
        If NumeroCasillas > 4 Then
            Panel5.Visible = True
        End If
        If NumeroCasillas > 5 Then
            Panel6.Visible = True
        End If
        If NumeroCasillas > 6 Then
            Panel7.Visible = True
        End If
        If NumeroCasillas > 7 Then
            Panel8.Visible = True
        End If
        If NumeroCasillas > 8 Then
            Panel9.Visible = True
        End If
        If NumeroCasillas > 9 Then
            Panel10.Visible = True
        End If
    End Sub

    Private Sub MuestraContenidoDeLosPaneles()
        'panel superior derecho
        Select Case intNumeroGestaciones
            Case 0
                labGesta.Text = ""
            Case 1
                labGesta.Text = "I"
            Case 2
                labGesta.Text = "II"
            Case 3
                labGesta.Text = "III"
            Case 4
                labGesta.Text = "IV"
            Case 5
                labGesta.Text = "V"
            Case 6
                labGesta.Text = "VI"
            Case 7
                labGesta.Text = "VII"
            Case 8
                labGesta.Text = "VIII"
            Case 9
                labGesta.Text = "IX"
            Case 10
                labGesta.Text = "X"
        End Select

        Select Case intNumeroPartos
            Case 0
                labPara.Text = ""
            Case 1
                labPara.Text = "I"
            Case 2
                labPara.Text = "II"
            Case 3
                labPara.Text = "III"
            Case 4
                labPara.Text = "IV"
            Case 5
                labPara.Text = "V"
            Case 6
                labPara.Text = "VI"
            Case 7
                labPara.Text = "VII"
            Case 8
                labPara.Text = "VIII"
            Case 9
                labPara.Text = "IX"
            Case 10
                labPara.Text = "X"
        End Select

        Select Case intNumeroCesareas
            Case 0
                labCesa.Text = ""
            Case 1
                labCesa.Text = "I"
            Case 2
                labCesa.Text = "II"
            Case 3
                labCesa.Text = "III"
            Case 4
                labCesa.Text = "IV"
            Case 5
                labCesa.Text = "V"
            Case 6
                labCesa.Text = "VI"
            Case 7
                labCesa.Text = "VII"
            Case 8
                labCesa.Text = "VIII"
            Case 9
                labCesa.Text = "IX"
            Case 10
                labCesa.Text = "X"
        End Select

        Select Case intNumeroAbortos
            Case 0
                labAbo.Text = ""
            Case 1
                labAbo.Text = "I"
            Case 2
                labAbo.Text = "II"
            Case 3
                labAbo.Text = "III"
            Case 4
                labAbo.Text = "IV"
            Case 5
                labAbo.Text = "V"
            Case 6
                labAbo.Text = "VI"
            Case 7
                labAbo.Text = "VII"
            Case 8
                labAbo.Text = "VIII"
            Case 9
                labAbo.Text = "IX"
            Case 10
                labAbo.Text = "X"
        End Select

        Select Case intNumeroEctopicos
            Case 0
                labEcto.Text = ""
            Case 1
                labEcto.Text = "I"
            Case 2
                labEcto.Text = "II"
            Case 3
                labEcto.Text = "III"
            Case 4
                labEcto.Text = "IV"
            Case 5
                labEcto.Text = "V"
            Case 6
                labEcto.Text = "VI"
            Case 7
                labEcto.Text = "VII"
            Case 8
                labEcto.Text = "VIII"
            Case 9
                labEcto.Text = "IX"
            Case 10
                labEcto.Text = "X"
        End Select

        txtOtrosNotas.Text = AO.a06strNotas

        'panel superior izquierdo
        If AO.Dato011 = "1" Then
            CheckBox1.Checked = True
        End If

        If AO.Dato012 = "1" Then
            CheckBox2.Checked = True
        End If

        If AO.Dato013 = "1" Then
            CheckBox3.Checked = True
        End If

        If AO.Dato014 = "1" Then
            CheckBox4.Checked = True
        End If

        If AO.Dato015 = "1" Then
            CheckBox5.Checked = True
        End If

        If AO.Dato016 = "1" Then
            CheckBox6.Checked = True
        End If

        If AO.Dato017 = "1" Then
            CheckBox7.Checked = True
        End If

        If AO.Dato018 = "1" Then
            CheckBox8.Checked = True
        End If

        If AO.Dato019 = "1" Then
            CheckBox9.Checked = True
        End If

        If AO.Dato020 = "1" Then
            CheckBox10.Checked = True
        End If

        If AO.Dato021 = "1" Then
            CheckBox11.Checked = True
        End If

        If AO.Dato022 = "1" Then
            CheckBox12.Checked = True
        End If

        If AO.Dato023 = "1" Then
            CheckBox13.Checked = True
        End If

        If AO.Dato024 = "1" Then
            CheckBox14.Checked = True
        End If

        If AO.Dato025 = "1" Then
            CheckBox15.Checked = True
        End If

        If AO.Dato026 = "1" Then
            CheckBox16.Checked = True
        End If

        If AO.Dato027 = "1" Then
            CheckBox17.Checked = True
        End If

        If AO.Dato028 = "1" Then
            CheckBox18.Checked = True
        End If

        'paneles inferiores

        'panel 01
        txtAño01.Text = AO.Dato040 : txtTipo01.Text = AO.Dato041
        txtCaracteristicas01.Text = AO.Dato042
        txtSexo01.Text = AO.Dato043 : txtPeso01.Text = AO.Dato044peso01
        txtVivo01.Text = AO.Dato045

        'panel 02
        txtAño02.Text = AO.Dato050 : txtTipo02.Text = AO.Dato051
        txtCaracteristicas02.Text = AO.Dato052
        txtSexo02.Text = AO.Dato053 : txtPeso02.Text = AO.Dato054peso02
        txtVivo02.Text = AO.Dato055

        'panel 03
        txtAño03.Text = AO.Dato060 : txtTipo03.Text = AO.Dato061
        txtCaracteristicas03.Text = AO.Dato062
        txtSexo03.Text = AO.Dato063 : txtPeso03.Text = AO.Dato064peso03
        txtVivo03.Text = AO.Dato065

        'panel 04
        txtAño04.Text = AO.Dato070 : txtTipo04.Text = AO.Dato071
        txtCaracteristicas04.Text = AO.Dato072
        txtSexo04.Text = AO.Dato073 : txtPeso04.Text = AO.Dato074peso04
        txtVivo04.Text = AO.Dato075

        'panel 05
        txtAño05.Text = AO.Dato080 : txtTipo05.Text = AO.Dato081
        txtCaracteristicas05.Text = AO.Dato082
        txtSexo05.Text = AO.Dato083 : txtPeso05.Text = AO.Dato084peso05
        txtVivo05.Text = AO.Dato085

        'panel 06
        txtAño06.Text = AO.Dato090 : txtTipo06.Text = AO.Dato091
        txtCaracteristicas06.Text = AO.Dato092
        txtSexo06.Text = AO.Dato093 : txtPeso06.Text = AO.Dato094peso06
        txtVivo06.Text = AO.Dato095

        'panel 07
        txtAño07.Text = AO.Dato100 : txtTipo07.Text = AO.Dato101
        txtCaracteristicas07.Text = AO.Dato102
        txtSexo07.Text = AO.Dato103 : txtPeso07.Text = AO.Dato104peso07
        txtVivo07.Text = AO.Dato105

        'panel 08
        txtAño08.Text = AO.Dato110 : txtTipo08.Text = AO.Dato111
        txtCaracteristicas08.Text = AO.Dato112
        txtSexo08.Text = AO.Dato113 : txtPeso08.Text = AO.Dato114peso08
        txtVivo08.Text = AO.Dato115

        'panel 09
        txtAño09.Text = AO.Dato120 : txtTipo09.Text = AO.Dato121
        txtCaracteristicas09.Text = AO.Dato122
        txtSexo09.Text = AO.Dato123 : txtPeso09.Text = AO.Dato124peso09
        txtVivo09.Text = AO.Dato125

        'panel 10
        txtAño10.Text = AO.Dato130 : txtTipo10.Text = AO.Dato131
        txtCaracteristicas10.Text = AO.Dato132
        txtSexo10.Text = AO.Dato133 : txtPeso10.Text = AO.Dato134peso10
        txtVivo10.Text = AO.Dato135

    End Sub

    'subrutina para cuando se producen cambios
    Private Sub SeProdujoUnCambio()
        booDatosModificados = True
        botCancelar.Text = "Descarta Cambios"
        'botAceptar.Enabled = True
    End Sub

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        'traduce el texto en pantalla
        ConstruyeAntecedentes()
        'codifica los datos en pantalla en la estructura
        CodificaDatosEnPantalla()
        'escribe los datos en la estructura al disco
        EscribeAntecedentesObstetricosAlDisco()

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ConstruyeAntecedentes()
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


            If txtOtrosNotas.Text <> "" Then
                Ant += "Nota: " & txtOtrosNotas.Text & "  "
            End If

            'peso maximo si esta
            Dim alsPesos As New ArrayList
            alsPesos.Clear()

            If txtPeso01.Text <> "" Then
                If IsNumeric(txtPeso01.Text) Then
                    alsPesos.Add(CType(txtPeso01.Text, Decimal))
                End If
            End If
            If txtPeso02.Text <> "" Then
                If IsNumeric(txtPeso02.Text) Then
                    alsPesos.Add(CType(txtPeso02.Text, Decimal))
                End If
            End If
            If txtPeso03.Text <> "" Then
                If IsNumeric(txtPeso03.Text) Then
                    alsPesos.Add(CType(txtPeso03.Text, Decimal))
                End If
            End If
            If txtPeso04.Text <> "" Then
                If IsNumeric(txtPeso04.Text) Then
                    alsPesos.Add(CType(txtPeso04.Text, Decimal))
                End If
            End If
            If txtPeso05.Text <> "" Then
                If IsNumeric(txtPeso05.Text) Then
                    alsPesos.Add(CType(txtPeso05.Text, Decimal))
                End If
            End If
            If txtPeso06.Text <> "" Then
                If IsNumeric(txtPeso06.Text) Then
                    alsPesos.Add(CType(txtPeso06.Text, Decimal))
                End If
            End If
            If txtPeso07.Text <> "" Then
                If IsNumeric(txtPeso07.Text) Then
                    alsPesos.Add(CType(txtPeso07.Text, Decimal))
                End If
            End If
            If txtPeso08.Text <> "" Then
                If IsNumeric(txtPeso08.Text) Then
                    alsPesos.Add(CType(txtPeso08.Text, Decimal))
                End If
            End If
            If txtPeso09.Text <> "" Then
                If IsNumeric(txtPeso09.Text) Then
                    alsPesos.Add(CType(txtPeso09.Text, Decimal))
                End If
            End If
            If txtPeso10.Text <> "" Then
                If IsNumeric(txtPeso10.Text) Then
                    alsPesos.Add(CType(txtPeso10.Text, Decimal))
                End If
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
            If CheckBox1.Checked = True Then
                Ant += "Patológicos: "
                Ant += CheckBox1.Text
                AntecedentesPatologicos = True
            End If
            If CheckBox2.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox2.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox2.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox3.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox3.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox3.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox4.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox4.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox4.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox5.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox5.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox5.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox6.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox6.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox6.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox7.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox7.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox7.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox8.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox8.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox8.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox9.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox9.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox9.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox10.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox10.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox10.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox11.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox11.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox11.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox12.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox12.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox12.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox13.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox13.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox13.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox14.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox14.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox14.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox15.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox15.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox15.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox16.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox16.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox16.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox17.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox17.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox17.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If CheckBox18.Checked = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox18.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox18.Text
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


            If txtOtrosNotas.Text <> "" Then
                Ant += vbCrLf & "Nota: " & txtOtrosNotas.Text & "  "
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
                Ant += "Patológicos: "
                Ant += CheckBox1.Text
                AntecedentesPatologicos = True
            End If

            If AO.Dato012 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox2.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox2.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato013 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox3.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox3.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato014 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox4.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox4.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato015 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox5.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox5.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato016 = "1" = True Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox6.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox6.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato017 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox7.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox7.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato018 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox8.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox8.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato019 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox9.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox9.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato020 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox10.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox10.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato021 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox11.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox11.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato022 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox12.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox12.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato023 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox13.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox13.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato024 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox14.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox14.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato025 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox15.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox15.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato026 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox16.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox16.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato027 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox17.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox17.Text
                    AntecedentesPatologicos = True
                End If
            End If
            If AO.Dato028 = "1" Then
                If AntecedentesPatologicos = True Then
                    Ant += ", " & CheckBox18.Text
                Else
                    Ant += "Patológicos: "
                    Ant += CheckBox18.Text
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

    'Private Sub ProcesaPartesDeLosPaneles()
    '    If arrDstrPartes(0).Length < 4 Then
    '        arrDstrPartes(0) = arrDstrPartes(0).PadRight(4, " ")
    '    End If

    '    If arrDstrPartes(1).Length < 20 Then
    '        arrDstrPartes(1) = arrDstrPartes(1).PadRight(20, " ")
    '    End If

    '    If arrDstrPartes(2).Length < 58 Then
    '        arrDstrPartes(2) = arrDstrPartes(2).PadRight(58, " ")
    '    End If

    '    If arrDstrPartes(3).Length < 1 Then
    '        arrDstrPartes(3) = " "
    '    End If

    '    If arrDstrPartes(4).Length < 4 Then
    '        arrDstrPartes(4) = arrDstrPartes(4).PadRight(4, " ")
    '    End If

    '    If arrDstrPartes(5).Length < 1 Then
    '        arrDstrPartes(5) = " "
    '    End If


    'End Sub

    Private Sub CodificaDatosEnPantalla()
        'Panel Superior Izquierdo
        AO.a01Gestas = intNumeroGestaciones.ToString
        AO.a02Paras = intNumeroPartos.ToString
        AO.a03Cesareas = intNumeroCesareas.ToString
        AO.a04Abortos = intNumeroAbortos.ToString
        AO.a05Ectopicos = intNumeroEctopicos.ToString
        AO.a06strNotas = txtOtrosNotas.Text

        'Panel Superior Derecho
        If CheckBox1.Checked = True Then
            AO.Dato011 = "1"
        Else
            AO.Dato011 = ""
        End If
        If CheckBox2.Checked = True Then
            AO.Dato012 = "1"
        Else
            AO.Dato012 = ""
        End If
        If CheckBox3.Checked = True Then
            AO.Dato013 = "1"
        Else
            AO.Dato013 = ""
        End If
        If CheckBox4.Checked = True Then
            AO.Dato014 = "1"
        Else
            AO.Dato014 = ""
        End If
        If CheckBox5.Checked = True Then
            AO.Dato015 = "1"
        Else
            AO.Dato015 = ""
        End If
        If CheckBox6.Checked = True Then
            AO.Dato016 = "1"
        Else
            AO.Dato016 = ""
        End If
        If CheckBox7.Checked = True Then
            AO.Dato017 = "1"
        Else
            AO.Dato017 = ""
        End If
        If CheckBox8.Checked = True Then
            AO.Dato018 = "1"
        Else
            AO.Dato018 = ""
        End If
        If CheckBox9.Checked = True Then
            AO.Dato019 = "1"
        Else
            AO.Dato019 = ""
        End If
        If CheckBox10.Checked = True Then
            AO.Dato020 = "1"
        Else
            AO.Dato020 = ""
        End If
        If CheckBox11.Checked = True Then
            AO.Dato021 = "1"
        Else
            AO.Dato021 = ""
        End If
        If CheckBox12.Checked = True Then
            AO.Dato022 = "1"
        Else
            AO.Dato022 = ""
        End If
        If CheckBox13.Checked = True Then
            AO.Dato023 = "1"
        Else
            AO.Dato023 = ""
        End If
        If CheckBox14.Checked = True Then
            AO.Dato024 = "1"
        Else
            AO.Dato024 = ""
        End If
        If CheckBox15.Checked = True Then
            AO.Dato025 = "1"
        Else
            AO.Dato025 = ""
        End If
        If CheckBox16.Checked = True Then
            AO.Dato026 = "1"
        Else
            AO.Dato026 = ""
        End If
        If CheckBox17.Checked = True Then
            AO.Dato027 = "1"
        Else
            AO.Dato027 = ""
        End If
        If CheckBox18.Checked = True Then
            AO.Dato028 = "1"
        Else
            AO.Dato028 = ""
        End If

        'paneles inferiores

        'panel 01
        AO.Dato040 = txtAño01.Text : AO.Dato041 = txtTipo01.Text
        AO.Dato042 = txtCaracteristicas01.Text
        AO.Dato043 = txtSexo01.Text : AO.Dato044peso01 = txtPeso01.Text
        AO.Dato045 = txtVivo01.Text
        'panel 02
        AO.Dato050 = txtAño02.Text : AO.Dato051 = txtTipo02.Text
        AO.Dato052 = txtCaracteristicas02.Text
        AO.Dato053 = txtSexo02.Text : AO.Dato054peso02 = txtPeso02.Text
        AO.Dato055 = txtVivo02.Text
        'panel 03
        AO.Dato060 = txtAño03.Text : AO.Dato061 = txtTipo03.Text
        AO.Dato062 = txtCaracteristicas03.Text
        AO.Dato063 = txtSexo03.Text : AO.Dato064peso03 = txtPeso03.Text
        AO.Dato065 = txtVivo03.Text
        'panel 04
        AO.Dato070 = txtAño04.Text : AO.Dato071 = txtTipo04.Text
        AO.Dato072 = txtCaracteristicas04.Text
        AO.Dato073 = txtSexo04.Text : AO.Dato074peso04 = txtPeso04.Text
        AO.Dato075 = txtVivo04.Text
        'panel 05
        AO.Dato080 = txtAño05.Text : AO.Dato081 = txtTipo05.Text
        AO.Dato082 = txtCaracteristicas05.Text
        AO.Dato083 = txtSexo05.Text : AO.Dato084peso05 = txtPeso05.Text
        AO.Dato085 = txtVivo05.Text
        'panel 06
        AO.Dato090 = txtAño06.Text : AO.Dato091 = txtTipo06.Text
        AO.Dato092 = txtCaracteristicas06.Text
        AO.Dato093 = txtSexo06.Text : AO.Dato094peso06 = txtPeso06.Text
        AO.Dato095 = txtVivo06.Text
        'panel 07
        AO.Dato100 = txtAño07.Text : AO.Dato101 = txtTipo07.Text
        AO.Dato102 = txtCaracteristicas07.Text
        AO.Dato103 = txtSexo07.Text : AO.Dato104peso07 = txtPeso07.Text
        AO.Dato105 = txtVivo07.Text
        'panel 08
        AO.Dato110 = txtAño08.Text : AO.Dato111 = txtTipo08.Text
        AO.Dato112 = txtCaracteristicas08.Text
        AO.Dato113 = txtSexo08.Text : AO.Dato114peso08 = txtPeso08.Text
        AO.Dato115 = txtVivo08.Text
        'panel 09
        AO.Dato120 = txtAño09.Text : AO.Dato121 = txtTipo09.Text
        AO.Dato122 = txtCaracteristicas09.Text
        AO.Dato123 = txtSexo09.Text : AO.Dato124peso09 = txtPeso09.Text
        AO.Dato125 = txtVivo09.Text
        'panel 10
        AO.Dato130 = txtAño10.Text : AO.Dato131 = txtTipo10.Text
        AO.Dato132 = txtCaracteristicas10.Text
        AO.Dato133 = txtSexo10.Text : AO.Dato134peso10 = txtPeso10.Text
        AO.Dato135 = txtVivo10.Text






    End Sub

    Private Sub EscribeAntecedentesObstetricosAlDisco()

        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(fileAntObstetricos, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)

        'ahora lo escribe

        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(AO.a01Gestas) : BW.Write(AO.a02Paras) : BW.Write(AO.a03Cesareas)
        BW.Write(AO.a04Abortos) : BW.Write(AO.a05Ectopicos) : BW.Write(AO.a06strNotas)
        BW.Write(AO.Dato006) : BW.Write(AO.Dato007) : BW.Write(AO.Dato008)
        BW.Write(AO.Dato009)

        BW.Write(AO.Dato010) : BW.Write(AO.Dato011) : BW.Write(AO.Dato012)
        BW.Write(AO.Dato013) : BW.Write(AO.Dato014) : BW.Write(AO.Dato015)
        BW.Write(AO.Dato016) : BW.Write(AO.Dato017) : BW.Write(AO.Dato018)
        BW.Write(AO.Dato019)

        BW.Write(AO.Dato020) : BW.Write(AO.Dato021) : BW.Write(AO.Dato022)
        BW.Write(AO.Dato023) : BW.Write(AO.Dato024) : BW.Write(AO.Dato025)
        BW.Write(AO.Dato026) : BW.Write(AO.Dato027) : BW.Write(AO.Dato028)
        BW.Write(AO.Dato029)

        BW.Write(AO.Dato030) : BW.Write(AO.Dato031) : BW.Write(AO.Dato032)
        BW.Write(AO.Dato033) : BW.Write(AO.Dato034) : BW.Write(AO.Dato035)
        BW.Write(AO.Dato036) : BW.Write(AO.Dato037) : BW.Write(AO.Dato038)
        BW.Write(AO.Dato039)

        BW.Write(AO.Dato040) : BW.Write(AO.Dato041) : BW.Write(AO.Dato042)
        BW.Write(AO.Dato043) : BW.Write(AO.Dato044peso01) : BW.Write(AO.Dato045)
        BW.Write(AO.Dato046) : BW.Write(AO.Dato047) : BW.Write(AO.Dato048)
        BW.Write(AO.Dato049)

        BW.Write(AO.Dato050) : BW.Write(AO.Dato051) : BW.Write(AO.Dato052)
        BW.Write(AO.Dato053) : BW.Write(AO.Dato054peso02) : BW.Write(AO.Dato055)
        BW.Write(AO.Dato056) : BW.Write(AO.Dato057) : BW.Write(AO.Dato058)
        BW.Write(AO.Dato059)

        BW.Write(AO.Dato060) : BW.Write(AO.Dato061) : BW.Write(AO.Dato062)
        BW.Write(AO.Dato063) : BW.Write(AO.Dato064peso03) : BW.Write(AO.Dato065)
        BW.Write(AO.Dato066) : BW.Write(AO.Dato067) : BW.Write(AO.Dato068)
        BW.Write(AO.Dato069)

        BW.Write(AO.Dato070) : BW.Write(AO.Dato071) : BW.Write(AO.Dato072)
        BW.Write(AO.Dato073) : BW.Write(AO.Dato074peso04) : BW.Write(AO.Dato075)
        BW.Write(AO.Dato076) : BW.Write(AO.Dato077) : BW.Write(AO.Dato078)
        BW.Write(AO.Dato079)

        BW.Write(AO.Dato080) : BW.Write(AO.Dato081) : BW.Write(AO.Dato082)
        BW.Write(AO.Dato083) : BW.Write(AO.Dato084peso05) : BW.Write(AO.Dato085)
        BW.Write(AO.Dato086) : BW.Write(AO.Dato087) : BW.Write(AO.Dato088)
        BW.Write(AO.Dato089)

        BW.Write(AO.Dato090) : BW.Write(AO.Dato091) : BW.Write(AO.Dato092)
        BW.Write(AO.Dato093) : BW.Write(AO.Dato094peso06) : BW.Write(AO.Dato095)
        BW.Write(AO.Dato096) : BW.Write(AO.Dato097) : BW.Write(AO.Dato098)
        BW.Write(AO.Dato099)

        BW.Write(AO.Dato100) : BW.Write(AO.Dato101) : BW.Write(AO.Dato102)
        BW.Write(AO.Dato103) : BW.Write(AO.Dato104peso07) : BW.Write(AO.Dato105)
        BW.Write(AO.Dato106) : BW.Write(AO.Dato107) : BW.Write(AO.Dato108)
        BW.Write(AO.Dato109)

        BW.Write(AO.Dato110) : BW.Write(AO.Dato111) : BW.Write(AO.Dato112)
        BW.Write(AO.Dato113) : BW.Write(AO.Dato114peso08) : BW.Write(AO.Dato115)
        BW.Write(AO.Dato116) : BW.Write(AO.Dato117) : BW.Write(AO.Dato118)
        BW.Write(AO.Dato119)

        BW.Write(AO.Dato120) : BW.Write(AO.Dato121) : BW.Write(AO.Dato122)
        BW.Write(AO.Dato123) : BW.Write(AO.Dato124peso09) : BW.Write(AO.Dato125)
        BW.Write(AO.Dato126) : BW.Write(AO.Dato127) : BW.Write(AO.Dato128)
        BW.Write(AO.Dato129)

        BW.Write(AO.Dato130) : BW.Write(AO.Dato131) : BW.Write(AO.Dato132)
        BW.Write(AO.Dato133) : BW.Write(AO.Dato134peso10) : BW.Write(AO.Dato135)
        BW.Write(AO.Dato136) : BW.Write(AO.Dato137) : BW.Write(AO.Dato138)
        BW.Write(AO.Dato139)

        BW.Write(AO.Dato140) : BW.Write(AO.Dato141) : BW.Write(AO.Dato142)
        BW.Write(AO.Dato143) : BW.Write(AO.Dato144) : BW.Write(AO.Dato145)
        BW.Write(AO.Dato146) : BW.Write(AO.Dato147) : BW.Write(AO.Dato148)
        BW.Write(AO.Dato149)

        BW.Close()
        FS.Close()
    End Sub


    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click

        If booDatosModificados = True Then
            'se van a perder los datos, pregunta para confirmar
            Dim reply As MsgBoxResult
            reply = MsgBox("Se perderan las últimas modificaciones realizadas, para confirmar presiona aceptar...", MsgBoxStyle.OkCancel, "Confirmar")

            If reply = MsgBoxResult.Ok Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                'se arrepintio deja abierta la vaina
            End If
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

    End Sub








    Private Sub BorrayApagaPanelDeLaDerecha()
        GroupBox1.Enabled = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
    End Sub

    Private Sub OcultaPanelesSucesivos()
        'apaga los paneles
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
        Panel8.Visible = False
        Panel9.Visible = False
        Panel10.Visible = False
    End Sub

    Private Sub PrendeBotonesAdicionales()
        botParaMas.Enabled = True
        botParaMenos.Enabled = True
        botCesaMas.Enabled = True
        botCesaMenos.Enabled = True
        botAboMas.Enabled = True
        botAboMenos.Enabled = True
        botEctoMas.Enabled = True
        botEctoMenos.Enabled = True
    End Sub

    Private Sub ApagaBotonesAdicionales()
        botParaMas.Enabled = False
        botParaMenos.Enabled = False
        botCesaMas.Enabled = False
        botCesaMenos.Enabled = False
        botAboMas.Enabled = False
        botAboMenos.Enabled = False
        botEctoMas.Enabled = False
        botEctoMenos.Enabled = False
    End Sub

    Private Sub botGestaMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botGestaMas.Click

        If intNumeroGestaciones < 10 Then
            intNumeroGestaciones += 1
            Select Case intNumeroGestaciones
                Case 1
                    labGesta.Text = "I"
                Case 2
                    labGesta.Text = "II"
                Case 3
                    labGesta.Text = "III"
                Case 4
                    labGesta.Text = "IV"
                Case 5
                    labGesta.Text = "V"
                Case 6
                    labGesta.Text = "VI"
                Case 7
                    labGesta.Text = "VII"
                Case 8
                    labGesta.Text = "VIII"
                Case 9
                    labGesta.Text = "IX"
                Case 10
                    labGesta.Text = "X"
            End Select

            ActualizaPanelesEnPantalla()

            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If

        End If

    End Sub

    Private Sub botGestaMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botGestaMenos.Click

        If intNumeroGestaciones > 0 Then
            intNumeroGestaciones -= 1
            Select Case intNumeroGestaciones
                Case 0
                    labGesta.Text = ""
                Case 1
                    labGesta.Text = "I"
                Case 2
                    labGesta.Text = "II"
                Case 3
                    labGesta.Text = "III"
                Case 4
                    labGesta.Text = "IV"
                Case 5
                    labGesta.Text = "V"
                Case 6
                    labGesta.Text = "VI"
                Case 7
                    labGesta.Text = "VII"
                Case 8
                    labGesta.Text = "VIII"
                Case 9
                    labGesta.Text = "IX"
            End Select

            ActualizaPanelesEnPantalla()

            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If

        End If

    End Sub

    Private Sub botParaMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botParaMas.Click

        If intNumeroPartos < 10 Then
            intNumeroPartos += 1
            Select Case intNumeroPartos
                Case 1
                    labPara.Text = "I"
                Case 2
                    labPara.Text = "II"
                Case 3
                    labPara.Text = "III"
                Case 4
                    labPara.Text = "IV"
                Case 5
                    labPara.Text = "V"
                Case 6
                    labPara.Text = "VI"
                Case 7
                    labPara.Text = "VII"
                Case 8
                    labPara.Text = "VIII"
                Case 9
                    labPara.Text = "IX"
                Case 10
                    labPara.Text = "X"
            End Select

            ActualizaPanelesEnPantalla()

            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If

        End If

    End Sub

    Private Sub botParaMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botParaMenos.Click

        If intNumeroPartos > 0 Then
            intNumeroPartos -= 1
            Select Case intNumeroPartos
                Case 0
                    labPara.Text = ""
                Case 1
                    labPara.Text = "I"
                Case 2
                    labPara.Text = "II"
                Case 3
                    labPara.Text = "III"
                Case 4
                    labPara.Text = "IV"
                Case 5
                    labPara.Text = "V"
                Case 6
                    labPara.Text = "VI"
                Case 7
                    labPara.Text = "VII"
                Case 8
                    labPara.Text = "VIII"
                Case 9
                    labPara.Text = "IX"
            End Select

            ActualizaPanelesEnPantalla()

            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If

        End If

    End Sub

    Private Sub botCesaMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCesaMas.Click

        If intNumeroCesareas < 10 Then
            intNumeroCesareas += 1
            Select Case intNumeroCesareas
                Case 1
                    labCesa.Text = "I"
                Case 2
                    labCesa.Text = "II"
                Case 3
                    labCesa.Text = "III"
                Case 4
                    labCesa.Text = "IV"
                Case 5
                    labCesa.Text = "V"
                Case 6
                    labCesa.Text = "VI"
                Case 7
                    labCesa.Text = "VII"
                Case 8
                    labCesa.Text = "VIII"
                Case 9
                    labCesa.Text = "IX"
                Case 10
                    labCesa.Text = "X"
            End Select

            ActualizaPanelesEnPantalla()

            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If

        End If

    End Sub

    Private Sub botCesaMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCesaMenos.Click

        If intNumeroCesareas > 0 Then
            intNumeroCesareas -= 1
            Select Case intNumeroCesareas
                Case 0
                    labCesa.Text = ""
                Case 1
                    labCesa.Text = "I"
                Case 2
                    labCesa.Text = "II"
                Case 3
                    labCesa.Text = "III"
                Case 4
                    labCesa.Text = "IV"
                Case 5
                    labCesa.Text = "V"
                Case 6
                    labCesa.Text = "VI"
                Case 7
                    labCesa.Text = "VII"
                Case 8
                    labCesa.Text = "VIII"
                Case 9
                    labCesa.Text = "IX"
            End Select

            ActualizaPanelesEnPantalla()

            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If

        End If

    End Sub

    Private Sub botAboMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAboMas.Click

        If intNumeroAbortos < 10 Then
            intNumeroAbortos += 1
            Select Case intNumeroAbortos
                Case 1
                    labAbo.Text = "I"
                Case 2
                    labAbo.Text = "II"
                Case 3
                    labAbo.Text = "III"
                Case 4
                    labAbo.Text = "IV"
                Case 5
                    labAbo.Text = "V"
                Case 6
                    labAbo.Text = "VI"
                Case 7
                    labAbo.Text = "VII"
                Case 8
                    labAbo.Text = "VIII"
                Case 9
                    labAbo.Text = "IX"
                Case 10
                    labAbo.Text = "X"
            End Select

            ActualizaPanelesEnPantalla()

            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If

        End If

    End Sub

    Private Sub botAboMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAboMenos.Click

        If intNumeroAbortos > 0 Then
            intNumeroAbortos -= 1
            Select Case intNumeroAbortos
                Case 0
                    labAbo.Text = ""
                Case 1
                    labAbo.Text = "I"
                Case 2
                    labAbo.Text = "II"
                Case 3
                    labAbo.Text = "III"
                Case 4
                    labAbo.Text = "IV"
                Case 5
                    labAbo.Text = "V"
                Case 6
                    labAbo.Text = "VI"
                Case 7
                    labAbo.Text = "VII"
                Case 8
                    labAbo.Text = "VIII"
                Case 9
                    labAbo.Text = "IX"
            End Select

            ActualizaPanelesEnPantalla()

            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If

        End If

    End Sub

    Private Sub botEctoMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEctoMas.Click

        If intNumeroEctopicos < 10 Then
            intNumeroEctopicos += 1
            Select Case intNumeroEctopicos
                Case 1
                    labEcto.Text = "I"
                Case 2
                    labEcto.Text = "II"
                Case 3
                    labEcto.Text = "III"
                Case 4
                    labEcto.Text = "IV"
                Case 5
                    labEcto.Text = "V"
                Case 6
                    labEcto.Text = "VI"
                Case 7
                    labEcto.Text = "VII"
                Case 8
                    labEcto.Text = "VIII"
                Case 9
                    labEcto.Text = "IX"
                Case 10
                    labEcto.Text = "X"
            End Select

            ActualizaPanelesEnPantalla()

            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If

        End If

    End Sub

    Private Sub botEctoMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEctoMenos.Click

        If intNumeroEctopicos > 0 Then
            intNumeroEctopicos -= 1
            Select Case intNumeroEctopicos
                Case 0
                    labEcto.Text = ""
                Case 1
                    labEcto.Text = "I"
                Case 2
                    labEcto.Text = "II"
                Case 3
                    labEcto.Text = "III"
                Case 4
                    labEcto.Text = "IV"
                Case 5
                    labEcto.Text = "V"
                Case 6
                    labEcto.Text = "VI"
                Case 7
                    labEcto.Text = "VII"
                Case 8
                    labEcto.Text = "VIII"
                Case 9
                    labEcto.Text = "IX"
            End Select

            ActualizaPanelesEnPantalla()

            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If

        End If

    End Sub





    Private Sub txtAñosdeGesta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtAño01.KeyPress, txtAño02.KeyPress, txtAño03.KeyPress, txtAño04.KeyPress, txtAño05.KeyPress, _
            txtAño06.KeyPress, txtAño07.KeyPress, txtAño08.KeyPress, txtAño09.KeyPress, txtAño10.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If
        End If
    End Sub

    Private Sub txtTIPOdeGESTA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtTipo01.KeyPress, txtTipo02.KeyPress, txtTipo03.KeyPress, txtTipo04.KeyPress, txtTipo05.KeyPress, _
                txtTipo06.KeyPress, txtTipo07.KeyPress, txtTipo08.KeyPress, txtTipo09.KeyPress, txtTipo10.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or c = "." Or c = "," Or c = " ") Then
            e.Handled = True
        Else
            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If
        End If
    End Sub

    Private Sub txtCARACTERISTICAS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtCaracteristicas01.KeyPress, txtCaracteristicas02.KeyPress, txtCaracteristicas03.KeyPress, _
                txtCaracteristicas04.KeyPress, txtCaracteristicas05.KeyPress, txtCaracteristicas06.KeyPress, _
                txtCaracteristicas07.KeyPress, txtCaracteristicas08.KeyPress, txtCaracteristicas09.KeyPress, _
                txtCaracteristicas10.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or c = " " Or c = "," Or c = "." Or c = "(" Or c = ")") Then
            e.Handled = True
        Else
            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If
        End If
    End Sub


    Private Sub txtSEXO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtSexo01.KeyPress, txtSexo02.KeyPress, txtSexo03.KeyPress, _
                txtSexo04.KeyPress, txtSexo05.KeyPress, txtSexo06.KeyPress, _
                txtSexo07.KeyPress, txtSexo08.KeyPress, txtSexo09.KeyPress, _
                txtSexo10.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or c = "f" Or c = "F" Or c = "m" Or c = "M") Then
            e.Handled = True
        Else
            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If
        End If
    End Sub

    Private Sub txtVIVO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtVivo01.KeyPress, txtVivo02.KeyPress, txtVivo03.KeyPress, _
                txtVivo04.KeyPress, txtVivo05.KeyPress, txtVivo06.KeyPress, _
                txtVivo07.KeyPress, txtVivo08.KeyPress, txtVivo09.KeyPress, _
                txtVivo10.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or c = "V" Or c = "v" Or c = "m" Or c = "M") Then
            e.Handled = True
        Else
            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If
        End If
    End Sub

    Private Sub txtPESOGesta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtPeso01.KeyPress, txtPeso02.KeyPress, txtPeso03.KeyPress, txtPeso04.KeyPress, txtPeso05.KeyPress, _
               txtPeso06.KeyPress, txtPeso07.KeyPress, txtPeso08.KeyPress, txtPeso09.KeyPress, txtPeso10.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If booDatosModificados = False Then
                SeProdujoUnCambio()
            End If
        End If
    End Sub

    Private Sub CheckBoxes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
     Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, _
             CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, _
             CheckBox5.CheckedChanged, CheckBox6.CheckedChanged, _
             CheckBox7.CheckedChanged, CheckBox8.CheckedChanged, _
             CheckBox9.CheckedChanged, CheckBox10.CheckedChanged, _
             CheckBox11.CheckedChanged, CheckBox12.CheckedChanged, _
             CheckBox13.CheckedChanged, CheckBox14.CheckedChanged, _
             CheckBox15.CheckedChanged, CheckBox16.CheckedChanged, _
             CheckBox17.CheckedChanged, CheckBox18.CheckedChanged

        If booDatosModificados = False Then
            SeProdujoUnCambio()
        End If

    End Sub



    'eventos graficos de los botones
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

    Private Sub botGestaMas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botGestaMas.MouseEnter
        botGestaMas.Image = FlechitaArribaON
    End Sub
    Private Sub botGestaMas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botGestaMas.MouseLeave
        botGestaMas.Image = FlechitaArribaOFF
    End Sub

    Private Sub botGestaMenos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botGestaMenos.MouseEnter
        botGestaMenos.Image = FlechitaAbajoON
    End Sub
    Private Sub botGestaMenos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botGestaMenos.MouseLeave
        botGestaMenos.Image = FlechitaAbajoOFF
    End Sub

    Private Sub botParaMas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botParaMas.MouseEnter
        botParaMas.Image = FlechitaArribaON
    End Sub
    Private Sub botParaMas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botParaMas.MouseLeave
        botParaMas.Image = FlechitaArribaOFF
    End Sub

    Private Sub botParaMenos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botParaMenos.MouseEnter
        botParaMenos.Image = FlechitaAbajoON
    End Sub
    Private Sub botParaMenos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botParaMenos.MouseLeave
        botParaMenos.Image = FlechitaAbajoOFF
    End Sub

    Private Sub botCesaMas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCesaMas.MouseEnter
        botCesaMas.Image = FlechitaArribaON
    End Sub
    Private Sub botCesaMas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCesaMas.MouseLeave
        botCesaMas.Image = FlechitaArribaOFF
    End Sub

    Private Sub botCesaMenos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCesaMenos.MouseEnter
        botCesaMenos.Image = FlechitaAbajoON
    End Sub
    Private Sub botCesaMenos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCesaMenos.MouseLeave
        botCesaMenos.Image = FlechitaAbajoOFF
    End Sub

    Private Sub botAboMas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAboMas.MouseEnter
        botAboMas.Image = FlechitaArribaON
    End Sub
    Private Sub botAboMas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAboMas.MouseLeave
        botAboMas.Image = FlechitaArribaOFF
    End Sub

    Private Sub botAboMenos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAboMenos.MouseEnter
        botAboMenos.Image = FlechitaAbajoON
    End Sub
    Private Sub botAboMenos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAboMenos.MouseLeave
        botAboMenos.Image = FlechitaAbajoOFF
    End Sub

    Private Sub botEctoMas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEctoMas.MouseEnter
        botEctoMas.Image = FlechitaArribaON
    End Sub
    Private Sub botEctoMas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEctoMas.MouseLeave
        botEctoMas.Image = FlechitaArribaOFF
    End Sub

    Private Sub botEctoMenos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEctoMenos.MouseEnter
        botEctoMenos.Image = FlechitaAbajoON
    End Sub
    Private Sub botEctoMenos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEctoMenos.MouseLeave
        botEctoMenos.Image = FlechitaAbajoOFF
    End Sub




End Class
