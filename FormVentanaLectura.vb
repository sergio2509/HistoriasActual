Public Class FormVentanaLectura
    Inherits System.Windows.Forms.Form

    Dim DatosModificados As Boolean


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
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents botGuardarNuevosDatos As System.Windows.Forms.Button
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormVentanaLectura))
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.botGuardarNuevosDatos = New System.Windows.Forms.Button()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'botCancelar
        '
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Bitmap)
        Me.botCancelar.Location = New System.Drawing.Point(4, 416)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(224, 23)
        Me.botCancelar.TabIndex = 8
        Me.botCancelar.Text = "Cancelar"
        '
        'botGuardarNuevosDatos
        '
        Me.botGuardarNuevosDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botGuardarNuevosDatos.Image = CType(resources.GetObject("botGuardarNuevosDatos.Image"), System.Drawing.Bitmap)
        Me.botGuardarNuevosDatos.Location = New System.Drawing.Point(468, 416)
        Me.botGuardarNuevosDatos.Name = "botGuardarNuevosDatos"
        Me.botGuardarNuevosDatos.Size = New System.Drawing.Size(224, 23)
        Me.botGuardarNuevosDatos.TabIndex = 7
        Me.botGuardarNuevosDatos.Text = "Guarda Nuevos Datos"
        '
        'txtTexto
        '
        Me.txtTexto.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto.Location = New System.Drawing.Point(4, 12)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTexto.Size = New System.Drawing.Size(688, 396)
        Me.txtTexto.TabIndex = 9
        Me.txtTexto.Text = ""
        '
        'FormVentanaLectura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(694, 444)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtTexto, Me.botCancelar, Me.botGuardarNuevosDatos})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormVentanaLectura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        Dim Reply As MsgBoxResult

        If DatosModificados = False Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Reply = MsgBox("Se perderán los últimos datos introducidos, para confirmar presiona Aceptar...", MsgBoxStyle.OKCancel)
            If Reply = MsgBoxResult.OK Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                'se cancelo la salida deja todo igual
            End If
        End If
    End Sub

    Private Sub FormVentanaLectura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'inicializa ventana
        txtTexto.Text = Form1.TextoIntercambio
        Me.Text = Form1.TituloVentanaDeTexto
        'pone la bandera a no cambios
        DatosNoModificados()
        txtTexto.SelectionStart = txtTexto.Text.Length
        txtTexto.ScrollToCaret()
        txtTexto.Focus()
    End Sub

    Private Sub DatosNoModificados()
        'inicializa botones y opciones
        botCancelar.Enabled = True
        botCancelar.Text = "Salir"
        botGuardarNuevosDatos.Enabled = False
        DatosModificados = False
    End Sub

    Private Sub DatosSeModificaron()
        botCancelar.Text = "Descarta Cambios"
        botGuardarNuevosDatos.Enabled = True
        DatosModificados = True
    End Sub

    Private Sub Texto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtTexto.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                If DatosModificados = False Then
                    DatosSeModificaron()
                End If
            End If

        End If
    End Sub

    Private Sub txtTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTexto.TextChanged
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    Private Sub botGuardarNuevosDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botGuardarNuevosDatos.Click
        Form1.TextoIntercambio = txtTexto.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub



End Class
