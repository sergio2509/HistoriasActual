Public Class FormRenombraHistoria
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents labNombreAntiguo As System.Windows.Forms.Label
    Friend WithEvents labCedulaAntigua As System.Windows.Forms.Label
    Friend WithEvents txtNombreNuevo As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaNueva As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labNumeroHistoria As System.Windows.Forms.Label
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents BotCancelar As System.Windows.Forms.Button
    Friend WithEvents labMensaje As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormRenombraHistoria))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labNombreAntiguo = New System.Windows.Forms.Label()
        Me.labCedulaAntigua = New System.Windows.Forms.Label()
        Me.txtNombreNuevo = New System.Windows.Forms.TextBox()
        Me.txtCedulaNueva = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labNumeroHistoria = New System.Windows.Forms.Label()
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.BotCancelar = New System.Windows.Forms.Button()
        Me.labMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre actual"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nuevo Nombre"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cédula Actual"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(40, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nueva Cédula"
        '
        'labNombreAntiguo
        '
        Me.labNombreAntiguo.BackColor = System.Drawing.SystemColors.Info
        Me.labNombreAntiguo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombreAntiguo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombreAntiguo.Location = New System.Drawing.Point(152, 40)
        Me.labNombreAntiguo.Name = "labNombreAntiguo"
        Me.labNombreAntiguo.Size = New System.Drawing.Size(296, 20)
        Me.labNombreAntiguo.TabIndex = 3
        '
        'labCedulaAntigua
        '
        Me.labCedulaAntigua.BackColor = System.Drawing.SystemColors.Info
        Me.labCedulaAntigua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCedulaAntigua.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCedulaAntigua.Location = New System.Drawing.Point(152, 104)
        Me.labCedulaAntigua.Name = "labCedulaAntigua"
        Me.labCedulaAntigua.Size = New System.Drawing.Size(88, 20)
        Me.labCedulaAntigua.TabIndex = 7
        '
        'txtNombreNuevo
        '
        Me.txtNombreNuevo.Location = New System.Drawing.Point(152, 72)
        Me.txtNombreNuevo.Name = "txtNombreNuevo"
        Me.txtNombreNuevo.Size = New System.Drawing.Size(296, 20)
        Me.txtNombreNuevo.TabIndex = 5
        Me.txtNombreNuevo.Text = ""
        '
        'txtCedulaNueva
        '
        Me.txtCedulaNueva.Location = New System.Drawing.Point(152, 136)
        Me.txtCedulaNueva.Name = "txtCedulaNueva"
        Me.txtCedulaNueva.Size = New System.Drawing.Size(88, 20)
        Me.txtCedulaNueva.TabIndex = 9
        Me.txtCedulaNueva.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(40, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Historia No."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNumeroHistoria
        '
        Me.labNumeroHistoria.BackColor = System.Drawing.SystemColors.Info
        Me.labNumeroHistoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumeroHistoria.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumeroHistoria.Location = New System.Drawing.Point(152, 8)
        Me.labNumeroHistoria.Name = "labNumeroHistoria"
        Me.labNumeroHistoria.Size = New System.Drawing.Size(88, 20)
        Me.labNumeroHistoria.TabIndex = 1
        '
        'botAceptar
        '
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.Image = CType(resources.GetObject("botAceptar.Image"), System.Drawing.Bitmap)
        Me.botAceptar.Location = New System.Drawing.Point(240, 168)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(224, 23)
        Me.botAceptar.TabIndex = 11
        Me.botAceptar.Text = "Aceptar"
        '
        'BotCancelar
        '
        Me.BotCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BotCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotCancelar.Image = CType(resources.GetObject("BotCancelar.Image"), System.Drawing.Bitmap)
        Me.BotCancelar.Location = New System.Drawing.Point(8, 168)
        Me.BotCancelar.Name = "BotCancelar"
        Me.BotCancelar.Size = New System.Drawing.Size(224, 23)
        Me.BotCancelar.TabIndex = 10
        Me.BotCancelar.Text = "Salir"
        '
        'labMensaje
        '
        Me.labMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labMensaje.ForeColor = System.Drawing.Color.Black
        Me.labMensaje.Image = CType(resources.GetObject("labMensaje.Image"), System.Drawing.Bitmap)
        Me.labMensaje.Location = New System.Drawing.Point(8, 200)
        Me.labMensaje.Name = "labMensaje"
        Me.labMensaje.Size = New System.Drawing.Size(456, 23)
        Me.labMensaje.TabIndex = 12
        Me.labMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormRenombraHistoria
        '
        Me.AcceptButton = Me.botAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.BotCancelar
        Me.ClientSize = New System.Drawing.Size(474, 232)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.labMensaje, Me.BotCancelar, Me.botAceptar, Me.labNumeroHistoria, Me.Label5, Me.txtCedulaNueva, Me.txtNombreNuevo, Me.labCedulaAntigua, Me.labNombreAntiguo, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormRenombraHistoria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambia el Nombre o la Cédula de la Historia Seleccionada"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim BotonOnGrande, BotonOffGrande As Image

    Private Sub FormRenombraHistoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        labNumeroHistoria.Text = Form1.PSstrNumeroHistoriaSeleccionada
        labNombreAntiguo.Text = Form1.PSstrPacienteSeleccionadaNombre
        labCedulaAntigua.Text = Form1.PSstrPacienteSeleccionadaCedula
        txtCedulaNueva.Text = Form1.PSstrPacienteSeleccionadaCedula
        txtNombreNuevo.Text = Form1.PSstrPacienteSeleccionadaNombre
        botAceptar.Enabled = False
        BotCancelar.Text = "Salir"

        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande

    End Sub


    Private Sub txtCedulaNueva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCedulaNueva.TextChanged, txtNombreNuevo.TextChanged
        If txtNombreNuevo.Text.Length > 0 And txtCedulaNueva.Text.Length > 6 Then
            botAceptar.Enabled = True
            labMensaje.Text = "Aceptar para confirmar"
        Else
            botAceptar.Enabled = False
            labMensaje.Text = "Faltan Datos"
        End If

        BotCancelar.Text = "Descarta Cambios"
    End Sub

    Private Sub txtNombrePaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreNuevo.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            e.Handled = True
        Else
            If Not Char.IsControl(c) Then
                If txtNombreNuevo.Text.Length > 39 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub


    Private Sub txtCedulaPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaNueva.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If Not Char.IsControl(c) Then
                If txtCedulaNueva.Text.Length > 7 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub






    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        Dim reply As MsgBoxResult
        reply = MsgBox("¿Deseas modificar historia con estos datos?", MsgBoxStyle.YesNo, "Confirmar")
        If reply = MsgBoxResult.Yes Then
            If Len(txtCedulaNueva.Text) = 7 Then
                txtCedulaNueva.Text = "0" & txtCedulaNueva.Text
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub BotCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'eventos graficos de los botones
    Private Sub botaceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseEnter
        botAceptar.Image = BotonOnGrande
    End Sub
    Private Sub botaceptar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseLeave
        botAceptar.Image = BotonOffGrande
    End Sub
    Private Sub botcancelar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotCancelar.MouseEnter
        BotCancelar.Image = BotonOnGrande
    End Sub
    Private Sub botcancelar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotCancelar.MouseLeave
        BotCancelar.Image = BotonOffGrande
    End Sub
End Class
