Public Class FormEligeFecha
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
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents LabMensaje As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormEligeFecha))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.LabMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(40, 64)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 0
        '
        'botCancelar
        '
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Bitmap)
        Me.botCancelar.Location = New System.Drawing.Point(64, 232)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(120, 23)
        Me.botCancelar.TabIndex = 1
        Me.botCancelar.Text = "Cancelar"
        '
        'LabMensaje
        '
        Me.LabMensaje.BackColor = System.Drawing.SystemColors.Info
        Me.LabMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabMensaje.Location = New System.Drawing.Point(8, 8)
        Me.LabMensaje.Name = "LabMensaje"
        Me.LabMensaje.Size = New System.Drawing.Size(240, 48)
        Me.LabMensaje.TabIndex = 2
        Me.LabMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormEligeFecha
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(258, 264)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.LabMensaje, Me.botCancelar, Me.MonthCalendar1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormEligeFecha"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecciona Fecha"
        Me.ResumeLayout(False)

    End Sub

#End Region

    'variables de imagen para los botones
    Dim BotonOn As Image
    Dim BotonOff As Image

    Private Sub FormEligeFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabMensaje.Text = Form1.FechaSeleccionadaMensaje
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff

        If Form1.booSeleccionandoFechaParaControlEcografico = True Then

            MonthCalendar1.SelectionStart = Form1.datFURactiva
            Form1.booSeleccionandoFechaParaControlEcografico = False

        End If
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If MonthCalendar1.SelectionStart > Today Then
            MsgBox("La fecha seleccionada no puede ser situada en el futuro...", MsgBoxStyle.Information, "Fecha Inválida")
            MonthCalendar1.SelectionStart = Today
        Else
            Form1.FechaSeleccionada = MonthCalendar1.SelectionStart
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub botCANCELAR_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.MouseEnter
        botCancelar.Image = BotonOn
    End Sub
    Private Sub botCANCELAR_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.MouseLeave
        botCancelar.Image = BotonOff
    End Sub
End Class
