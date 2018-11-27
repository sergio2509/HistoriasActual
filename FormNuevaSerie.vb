Public Class FormNuevaSerie
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
    Friend WithEvents labMensaje As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormNuevaSerie))
        Me.labMensaje = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labMensaje
        '
        Me.labMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMensaje.Location = New System.Drawing.Point(8, 8)
        Me.labMensaje.Name = "labMensaje"
        Me.labMensaje.Size = New System.Drawing.Size(368, 64)
        Me.labMensaje.TabIndex = 0
        Me.labMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(8, 80)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(368, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = ""
        '
        'botCancelar
        '
        Me.botCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Bitmap)
        Me.botCancelar.Location = New System.Drawing.Point(8, 112)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(120, 23)
        Me.botCancelar.TabIndex = 2
        Me.botCancelar.Text = "Cancelar"
        '
        'botAceptar
        '
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.Image = CType(resources.GetObject("botAceptar.Image"), System.Drawing.Bitmap)
        Me.botAceptar.Location = New System.Drawing.Point(256, 112)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(120, 23)
        Me.botAceptar.TabIndex = 3
        Me.botAceptar.Text = "Aceptar"
        '
        'FormNuevaSerie
        '
        Me.AcceptButton = Me.botAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.botCancelar
        Me.ClientSize = New System.Drawing.Size(386, 138)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.botAceptar, Me.botCancelar, Me.txtNombre, Me.labMensaje})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormNuevaSerie"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim BotonOn As Image
    Dim BotonOff As Image

    Private Sub FormNuevaSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Form1.NombreElegidoTitulo
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff
        labMensaje.Text = Form1.NombreElegidoMensaje

        'depende desde donde se cargo hace...
        If Form1.booSeEstaCreandoUnNuevoControlObstetrico = True Then
            'calcula el mes y año en q fue iniciado el control para el nombre
            Dim strMes As String = ""
            Dim strAno As String = ""
            Dim intMes = Form1.FechaSeleccionada.Month

            If intMes = 1 Then strMes = " Enero de "
            If intMes = 2 Then strMes = " Febrero de "
            If intMes = 3 Then strMes = " Marzo de "
            If intMes = 4 Then strMes = " Abril de "
            If intMes = 5 Then strMes = " Mayo de "
            If intMes = 6 Then strMes = " Junio de "
            If intMes = 7 Then strMes = " Julio de "
            If intMes = 8 Then strMes = " Agosto de "
            If intMes = 9 Then strMes = " Septiembre de "
            If intMes = 10 Then strMes = " Octubre"
            If intMes = 11 Then strMes = " Noviembre"
            If intMes = 12 Then strMes = " Diciembre"

            strAno = Form1.FechaSeleccionada.Year.ToString


            txtNombre.Text = "Embarazo de " & Form1.labDCparidad.Text & " Control iniciado en" & strMes & strAno
            botAceptar.Enabled = True
            botAceptar.Focus()


        Else
            txtNombre.Clear()
            botAceptar.Enabled = False
            txtNombre.Focus()

        End If


    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtNombre.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsWhiteSpace(c) Or Char.IsLetterOrDigit(c) Or c = "-" Or c = "(" Or c = ")" Or c = "+") Then
            e.Handled = True
        End If
    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        Form1.NombreElegido = "  " & txtNombre.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text <> "" Then
            botAceptar.Enabled = True
        Else
            botAceptar.Enabled = False
        End If
    End Sub

    '00000000000000000000
    'EVENTOS GRAFICOS DE LOS BOTONES

    Private Sub botACEPTAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseEnter
        botAceptar.Image = BotonOn
    End Sub
    Private Sub botACEPTAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseLeave
        botAceptar.Image = BotonOff
    End Sub

    Private Sub botCancelar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseEnter
        botCancelar.Image = BotonOn
    End Sub
    Private Sub botCancelar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseLeave
        botCancelar.Image = BotonOff
    End Sub

End Class
