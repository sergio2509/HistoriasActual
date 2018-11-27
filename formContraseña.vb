Imports System.Environment
Imports System.IO

Public Class formContraseña
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
    Friend WithEvents botOk As System.Windows.Forms.Button
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents labNumeroUnico As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formContraseña))
        Me.botOk = New System.Windows.Forms.Button
        Me.txtContraseña = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.labNumeroUnico = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'botOk
        '
        Me.botOk.BackColor = System.Drawing.SystemColors.Control
        Me.botOk.BackgroundImage = CType(resources.GetObject("botOk.BackgroundImage"), System.Drawing.Image)
        Me.botOk.Enabled = False
        Me.botOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botOk.Location = New System.Drawing.Point(56, 112)
        Me.botOk.Name = "botOk"
        Me.botOk.Size = New System.Drawing.Size(120, 23)
        Me.botOk.TabIndex = 1
        Me.botOk.Text = "Activa Programa"
        Me.botOk.UseVisualStyleBackColor = False
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(176, 64)
        Me.txtContraseña.MaxLength = 18
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(184, 20)
        Me.txtContraseña.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(8, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 112)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(416, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.labNumeroUnico)
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Controls.Add(Me.botOk)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Introduce Código de Activación"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(240, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(48, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Código de Activación"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código de Verificación"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labNumeroUnico
        '
        Me.labNumeroUnico.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroUnico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroUnico.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroUnico.Location = New System.Drawing.Point(176, 16)
        Me.labNumeroUnico.Name = "labNumeroUnico"
        Me.labNumeroUnico.Size = New System.Drawing.Size(184, 40)
        Me.labNumeroUnico.TabIndex = 2
        Me.labNumeroUnico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formContraseña
        '
        Me.AcceptButton = Me.botOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(506, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formContraseña"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historias Clínicas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared Contraseña As Long
    Public Shared NombreaRevisar As String

    Dim BotonOn, BotonOff As Image


    Private Sub botOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botOk.Click
        Contraseña = CType(txtContraseña.Text, Long)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub formContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "HISTORIAS CLÍNICAS. Versión 8.0" & vbCrLf
        Label1.Text += "Programación : Sergio T. González R." & vbCrLf
        Label1.Text += "email: sergio2509@cantv.net" & vbCrLf
       
        BotonOn = Image.FromFile(Form1.PSstrDirectorioDeLaAplicacion & "\botonon.bmp")
        BotonOff = Image.FromFile(Form1.PSstrDirectorioDeLaAplicacion & "\botonoff.bmp")

        Dim X As String
        Dim Y As Date
        Dim NumeroPC As String
        'Dim NumeroInicial As Long

        X = Environment.SystemDirectory
        'MsgBox("cargo el procedimiento load")
        If Directory.Exists(X) Then
            Y = Directory.GetCreationTime(X)
            NumeroPC = Y.Ticks.ToString
            NumeroPC = NumeroPC.Substring(8, 10)

            labNumeroUnico.Text += NumeroPC & vbCrLf
        
        End If

    End Sub

    Private Sub txtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseña.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContraseña.TextChanged
        If txtContraseña.Text.Length > 0 Then
            botOk.Enabled = True
        Else
            botOk.Enabled = False
        End If
    End Sub

    Private Sub botAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botOk.MouseEnter
        botOk.BackgroundImage = BotonOn
    End Sub
    Private Sub botAceptar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botOk.MouseLeave
        botOk.BackgroundImage = BotonOff
    End Sub

    Private Sub button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = BotonOn
    End Sub
    Private Sub button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = BotonOff
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        
    End Sub
End Class
