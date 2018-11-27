Public Class Nueva_Historia
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
    Friend WithEvents txtNombrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCedulaPaciente As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nueva_Historia))
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCedulaPaciente = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.botAceptar = New System.Windows.Forms.Button
        Me.botCancelar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePaciente.Location = New System.Drawing.Point(64, 8)
        Me.txtNombrePaciente.MaxLength = 35
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(312, 20)
        Me.txtNombrePaciente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cédula"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCedulaPaciente
        '
        Me.txtCedulaPaciente.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaPaciente.Location = New System.Drawing.Point(168, 40)
        Me.txtCedulaPaciente.MaxLength = 8
        Me.txtCedulaPaciente.Name = "txtCedulaPaciente"
        Me.txtCedulaPaciente.Size = New System.Drawing.Size(104, 20)
        Me.txtCedulaPaciente.TabIndex = 3
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(64, 40)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Tiene"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(64, 64)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.Text = "No tiene"
        '
        'botAceptar
        '
        Me.botAceptar.Enabled = False
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.Image = CType(resources.GetObject("botAceptar.Image"), System.Drawing.Image)
        Me.botAceptar.Location = New System.Drawing.Point(224, 96)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(120, 23)
        Me.botAceptar.TabIndex = 6
        Me.botAceptar.Text = "Aceptar"
        '
        'botCancelar
        '
        Me.botCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Image)
        Me.botCancelar.Location = New System.Drawing.Point(40, 96)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(120, 23)
        Me.botCancelar.TabIndex = 7
        Me.botCancelar.Text = "Cancelar"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(16, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(360, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Introduce los Datos de la Paciente"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Nueva_Historia
        '
        Me.AcceptButton = Me.botAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.botCancelar
        Me.ClientSize = New System.Drawing.Size(386, 168)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.botCancelar)
        Me.Controls.Add(Me.botAceptar)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtCedulaPaciente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombrePaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Nueva_Historia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea Nueva Historia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Botonon As Image
    Dim Botonoff As Image
    Dim reply As MsgBoxResult
    Dim Indice As Integer = 0
    Dim CI As String
    Dim HE As New Form1.BaseDatosIndiceHistorias

    Private Sub Nueva_Historia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Botonon = Form1.BotonOn
        Botonoff = Form1.BotonOff

    End Sub


    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click


        If Len(txtCedulaPaciente.Text) = 7 Then
            txtCedulaPaciente.Text = "0" & txtCedulaPaciente.Text
        End If

        'se debe revisar que esta cedula de identidad no exista en la base de datos el nombre podria ser pero la ci no
        CI = txtCedulaPaciente.Text
        For Me.Indice = 0 To Form1.Historias.Count - 1
            HE = Form1.Historias(Indice)
            If HE.CedulaPaciente = CI And CI <> "00000000" Then
                'existe esta cedula en la base de datos
                MsgBox("La Cédula de Identidad introducida ya se encuentra registrada en la Base de Datos y pertenece a la Paciente " & HE.NombrePaciente & ". Si es una duplicación por favor busca la historia #" & HE.NumeroHistoria & " en el Listado de Historias, o rectifica lo introducido...", MsgBoxStyle.Information, "Cédula de Identidad Existe")
                Exit Sub
            End If
        Next

        'si llega hasta aca todo esta bien acepta los datos
        Me.DialogResult = Windows.Forms.DialogResult.OK
        
    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtNombrePaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombrePaciente.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtCedulaPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedulaPaciente.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub RadioButtonsCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked = True Then
            If txtCedulaPaciente.Text = "00000000" Then txtCedulaPaciente.Clear()

            If txtNombrePaciente.Text.Length > 0 Then
                txtCedulaPaciente.Enabled = True
                txtCedulaPaciente.SelectAll()
                txtCedulaPaciente.Focus()
                If txtCedulaPaciente.Text.Length >= 6 Then
                    botAceptar.Enabled = True
                    Label3.Text = "Para confirmar los datos presiona Aceptar"
                Else
                    botAceptar.Enabled = False
                    Label3.Text = "Cédula de identidad inválida"
                End If
            Else
                txtCedulaPaciente.Enabled = False
                botAceptar.Enabled = False
                Label3.Text = "Introduce primero el nombre"
                txtNombrePaciente.Focus()
            End If
        Else
            txtCedulaPaciente.Enabled = False
            txtCedulaPaciente.Text = "00000000"
            If txtNombrePaciente.Text.Length > 0 Then
                botAceptar.Enabled = True
                Label3.Text = "Para confirmar los datos presiona Aceptar"
            Else
                botAceptar.Enabled = False
                Label3.Text = "Falta el nombre de la paciente"
                txtNombrePaciente.Focus()
            End If
        End If


    End Sub

    Private Sub txtCedulaPaciente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedulaPaciente.Leave
        If Len(txtCedulaPaciente.Text) < 6 Then
            Label3.Text = "Falta la Cédula de Identidad"
            txtCedulaPaciente.Clear()
        End If
    End Sub


    Private Sub txtCedulaPaciente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCedulaPaciente.TextChanged
        If txtCedulaPaciente.Text.Length >= 6 Then
            botAceptar.Enabled = True
            Label3.Text = "Para confirmar los datos presiona Aceptar"
        Else
            botAceptar.Enabled = False
            Label3.Text = "Cédula de identidad inválida"
        End If
    End Sub

    Private Sub txtNombrePaciente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombrePaciente.TextChanged
        If txtNombrePaciente.Text.Length < 1 Then
            botAceptar.Enabled = False
            txtCedulaPaciente.Enabled = False
            Label3.Text = "Introduce el Nombre de la paciente"
        Else
            If RadioButton1.Checked = True Then
                txtCedulaPaciente.Enabled = True
                If txtCedulaPaciente.Text.Length >= 6 Then
                    botAceptar.Enabled = True
                    Label3.Text = "Para confirmar los datos presiona Aceptar"
                Else
                    botAceptar.Enabled = False
                    Label3.Text = "Cédula de identidad inválida"
                End If
            Else
                botAceptar.Enabled = True
                Label3.Text = "Para confirmar los datos presiona Aceptar"
            End If

        End If

    End Sub

    Private Sub botAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseEnter
        botAceptar.Image = Botonon
    End Sub

    Private Sub botAceptar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseLeave
        botAceptar.Image = Botonoff
    End Sub

    Private Sub botcancelar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseEnter
        botCancelar.Image = Botonon
    End Sub

    Private Sub botcancelar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseLeave
        botCancelar.Image = Botonoff
    End Sub

End Class
