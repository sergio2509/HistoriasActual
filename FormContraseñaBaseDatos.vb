Public Class FormContraseñaBaseDatos
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
    Friend WithEvents labInfo As System.Windows.Forms.Label
    Friend WithEvents txtPass1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPass2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormContraseñaBaseDatos))
        Me.labInfo = New System.Windows.Forms.Label()
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        '
        'labInfo
        '
        Me.labInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labInfo.Image = CType(resources.GetObject("labInfo.Image"), System.Drawing.Bitmap)
        Me.labInfo.Location = New System.Drawing.Point(8, 16)
        Me.labInfo.Name = "labInfo"
        Me.labInfo.Size = New System.Drawing.Size(352, 24)
        Me.labInfo.TabIndex = 0
        Me.labInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPass1
        '
        Me.txtPass1.Location = New System.Drawing.Point(160, 56)
        Me.txtPass1.MaxLength = 10
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Microsoft.VisualBasic.ChrW(35)
        Me.txtPass1.TabIndex = 1
        Me.txtPass1.Text = ""
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(160, 104)
        Me.txtPass2.MaxLength = 10
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Microsoft.VisualBasic.ChrW(35)
        Me.txtPass2.TabIndex = 2
        Me.txtPass2.Text = ""
        '
        'botAceptar
        '
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.Image = CType(resources.GetObject("botAceptar.Image"), System.Drawing.Bitmap)
        Me.botAceptar.Location = New System.Drawing.Point(32, 152)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(224, 23)
        Me.botAceptar.TabIndex = 3
        Me.botAceptar.Text = "Aceptar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Introduce contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirma Contraseña"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(288, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 128)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'FormContraseñaBaseDatos
        '
        Me.AcceptButton = Me.botAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 184)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.Label3, Me.Label2, Me.botAceptar, Me.txtPass2, Me.txtPass1, Me.labInfo})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormContraseñaBaseDatos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contraseña de la Base de Datos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim BotonOnGrande, BotonOffGrande As Image

    Private Sub FormContraseñaBaseDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande

        If Form1.TipoDeContraseña = 1 Then
            CreaContraseña()
        ElseIf Form1.TipoDeContraseña = 2 Then
            EntraBaseDatos()
        ElseIf Form1.TipoDeContraseña = 3 Then
            EliminaBaseDatos()
        End If
    End Sub

    Private Sub CreaContraseña()
        labInfo.Text = "Crea Nueva Contraseña (sólo números)(Máx 10)"
        txtPass1.Focus()
    End Sub

    Private Sub EntraBaseDatos()
        labInfo.Text = "Introduce la Contraseña Correcta"
        Label3.Visible = False
        txtPass2.Visible = False
        txtPass1.Focus()
    End Sub

    Private Sub EliminaBaseDatos()
        labInfo.Text = "Introduce la Contraseña Correcta"
        Label3.Visible = False
        txtPass2.Visible = False
        txtPass1.Focus()
    End Sub


    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        If Form1.TipoDeContraseña = 1 Then
            If txtPass1.Text = txtPass2.Text And txtPass1.Text <> "" Then
                Form1.NumPassword = txtPass1.Text
            Else
                MsgBox("Las contraseñas no concuerdan, por favor introdúcelas nuevamente...", MsgBoxStyle.Information)
                txtPass1.Clear()
                txtPass2.Clear()
                txtPass1.Focus()
                Exit Sub
            End If
        ElseIf Form1.TipoDeContraseña = 2 Then
            If Form1.NumPassword.ToString = txtPass1.Text Then
                Form1.ContraseñaCorrecta = True
            Else
                Form1.ContraseñaCorrecta = False
            End If
        ElseIf Form1.TipoDeContraseña = 3 Then
            If Form1.NumPassword.ToString = txtPass1.Text Then
                Form1.ContraseñaCorrecta = True
            Else
                Form1.ContraseñaCorrecta = False
            End If
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtPass1.KeyPress, txtPass2.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub botAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseEnter
        botAceptar.Image = BotonOnGrande
    End Sub
    Private Sub botAceptar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseLeave
        botAceptar.Image = BotonOffGrande
    End Sub
End Class
