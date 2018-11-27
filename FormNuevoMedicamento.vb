Public Class FormNuevoMedicamento
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
    Friend WithEvents ListBoxCoincidencias As System.Windows.Forms.ListBox
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents txtNombreFarmaco As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormNuevoMedicamento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreFarmaco = New System.Windows.Forms.TextBox()
        Me.ListBoxCoincidencias = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Medicamento"
        '
        'txtNombreFarmaco
        '
        Me.txtNombreFarmaco.Location = New System.Drawing.Point(16, 32)
        Me.txtNombreFarmaco.Name = "txtNombreFarmaco"
        Me.txtNombreFarmaco.Size = New System.Drawing.Size(496, 20)
        Me.txtNombreFarmaco.TabIndex = 1
        Me.txtNombreFarmaco.Text = ""
        '
        'ListBoxCoincidencias
        '
        Me.ListBoxCoincidencias.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxCoincidencias.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxCoincidencias.Location = New System.Drawing.Point(16, 88)
        Me.ListBoxCoincidencias.Name = "ListBoxCoincidencias"
        Me.ListBoxCoincidencias.Size = New System.Drawing.Size(496, 238)
        Me.ListBoxCoincidencias.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Coincidencias en la Base de Datos"
        '
        'botAceptar
        '
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.Image = CType(resources.GetObject("botAceptar.Image"), System.Drawing.Bitmap)
        Me.botAceptar.Location = New System.Drawing.Point(288, 336)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(224, 23)
        Me.botAceptar.TabIndex = 4
        Me.botAceptar.Text = "Aceptar"
        '
        'botCancelar
        '
        Me.botCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Bitmap)
        Me.botCancelar.Location = New System.Drawing.Point(16, 336)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(224, 23)
        Me.botCancelar.TabIndex = 5
        Me.botCancelar.Text = "Cancelar"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(184, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Caracteres permitidos: A-Z a-z 0-9 (punto) (guión) (%) (espacio)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormNuevoMedicamento
        '
        Me.AcceptButton = Me.botAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.botCancelar
        Me.ClientSize = New System.Drawing.Size(522, 368)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.botCancelar, Me.botAceptar, Me.Label2, Me.ListBoxCoincidencias, Me.txtNombreFarmaco, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormNuevoMedicamento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Introduce Nuevo Medicamento"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Iguales As Boolean

    'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image


    Private Sub FormNuevoMedicamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'recupera nombres de los botones
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff
        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
        BarraSinMensaje = Form1.BarraSinMensaje
        FlechaIzqOff = Form1.FlechaIzqOff
        FlechaIzqOn = Form1.FlechaIzqOn
        FlechaDerOff = Form1.FlechaDerOff
        FlechaDerOn = Form1.FlechaDerOn

        'inicia la ventanita
        If FormMedicamentos.SeEstaCreandoUnMedicamentoNuevo = True Then
            Me.Text = "Introduce el nombre del nuevo medicamento..."
        Else
            Me.Text = "Renombra el medicamento: " & FormMedicamentos.MedicamentoResaltado
        End If
        botAceptar.Enabled = False
    End Sub

    Private Sub txtNombreFarmaco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreFarmaco.TextChanged
        Dim CaracteresNuevos(50) As Char
        Dim LargoNuevo, LargoViejo As Integer
        Dim CaracteresExistentes(50) As Char
        Dim Similares As Boolean
        Dim t As Integer
        Dim REnum As IEnumerator
        REnum = FormMedicamentos.Farmacos.GetEnumerator
        Dim Medicamento As String


        LargoNuevo = txtNombreFarmaco.Text.Length

        If LargoNuevo > 0 Then
            botAceptar.Enabled = True
        Else
            botAceptar.Enabled = False
        End If

        For t = 0 To LargoNuevo - 1
            CaracteresNuevos(t) = txtNombreFarmaco.Text.Chars(t)
        Next

        ListBoxCoincidencias.Items.Clear()

        While REnum.MoveNext
            Medicamento = CType(REnum.Current, String)
            If txtNombreFarmaco.Text.ToUpper = Medicamento.ToUpper Then
                Iguales = True
            End If
            LargoViejo = Medicamento.Length

            If LargoNuevo > LargoViejo Then
                Similares = True
                For t = 0 To LargoViejo - 1
                    CaracteresExistentes(t) = Medicamento.Chars(t)
                    If Char.ToUpper(CaracteresNuevos(t)) <> Char.ToUpper(CaracteresExistentes(t)) Then
                        Similares = False
                        Exit For
                    End If
                Next
                If Similares = True And LargoNuevo > 0 Then
                    ListBoxCoincidencias.Items.Add(Medicamento)
                End If
            Else 'entonces largoviejo es mayor que el largonuevo
                Similares = True
                For t = 0 To LargoNuevo - 1
                    CaracteresExistentes(t) = Medicamento.Chars(t)
                    If Char.ToUpper(CaracteresNuevos(t)) <> Char.ToUpper(CaracteresExistentes(t)) Then
                        Similares = False
                        Exit For
                    End If
                Next
                If Similares = True And LargoNuevo > 0 Then
                    ListBoxCoincidencias.Items.Add(Medicamento)
                End If
            End If
        End While
    End Sub

    Private Sub txtNombreFarmaco_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreFarmaco.KeyPress
        Dim c As Char
        c = e.KeyChar

        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or c = "-" Or c = "." Or c = "%" Or c = " ") Then
            e.Handled = True
        End If

    End Sub

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        Dim REnum As IEnumerator
        REnum = FormMedicamentos.Farmacos.GetEnumerator
        Dim Medicamento As String

        Iguales = False
        While REnum.MoveNext
            Medicamento = CType(REnum.Current, String)
            If Medicamento.ToUpper = txtNombreFarmaco.Text.ToUpper Then
                Iguales = True
            End If
        End While
        If Iguales = True Then
            MsgBox("Este medicamento ya fue introducido a la base de datos." & vbCrLf & _
                "Para modificarlo o introducir nuevos datos seleccionalo y presiona el botón 'Editar Medicamento'", _
                MsgBoxStyle.Information, "Medicamento existente en la Base de Datos")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else 'no es igual a ninguno, Revisa que empiece por una letra o numero
            Dim PrimerCaracter As Char
            PrimerCaracter = txtNombreFarmaco.Text.Chars(0)
            If Char.IsLetterOrDigit(PrimerCaracter) = True Then
                'si es una letra o un digito entonces crea el archivo
                Dim reply As MsgBoxResult
                reply = MsgBox("¿Confirmas el nombre: " & txtNombreFarmaco.Text & " ?", MsgBoxStyle.OKCancel, "Nuevo Medicamento")
                If reply = MsgBoxResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    txtNombreFarmaco.Clear()
                    txtNombreFarmaco.Focus()
                End If
            Else
                MsgBox("El primer caracter del nombre del farmaco debe ser una letra o un número, Rectifícalo...", MsgBoxStyle.Information, "Nombre Incorrecto")
                txtNombreFarmaco.Clear()
                txtNombreFarmaco.Focus()
            End If
        End If
    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'eventos del mouse sobre los botones
    Private Sub botAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseEnter
        botAceptar.Image = BotonOnGrande
    End Sub
    Private Sub botAceptar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseLeave
        botAceptar.Image = BotonOffGrande
    End Sub

    Private Sub botCancelar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseEnter
        botCancelar.Image = BotonOnGrande
    End Sub
    Private Sub botCancelar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseLeave
        botCancelar.Image = BotonOffGrande
    End Sub
End Class
