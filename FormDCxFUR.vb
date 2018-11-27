Public Class FormDCxFUR
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
    Friend WithEvents botSalir As System.Windows.Forms.Button
    Friend WithEvents labResultado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MCfecha01 As System.Windows.Forms.MonthCalendar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormDCxFUR))
        Me.botSalir = New System.Windows.Forms.Button()
        Me.labResultado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MCfecha01 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'botSalir
        '
        Me.botSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSalir.Image = CType(resources.GetObject("botSalir.Image"), System.Drawing.Bitmap)
        Me.botSalir.Location = New System.Drawing.Point(131, 255)
        Me.botSalir.Name = "botSalir"
        Me.botSalir.Size = New System.Drawing.Size(224, 23)
        Me.botSalir.TabIndex = 22
        Me.botSalir.Text = "Salir"
        '
        'labResultado
        '
        Me.labResultado.Image = CType(resources.GetObject("labResultado.Image"), System.Drawing.Bitmap)
        Me.labResultado.Location = New System.Drawing.Point(19, 223)
        Me.labResultado.Name = "labResultado"
        Me.labResultado.Size = New System.Drawing.Size(472, 23)
        Me.labResultado.TabIndex = 21
        Me.labResultado.Text = "Selecciona el día de FUR"
        Me.labResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(147, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Introduce el día de la FUR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'MCfecha01
        '
        Me.MCfecha01.Location = New System.Drawing.Point(163, 39)
        Me.MCfecha01.MaxSelectionCount = 1
        Me.MCfecha01.Name = "MCfecha01"
        Me.MCfecha01.ShowToday = False
        Me.MCfecha01.ShowTodayCircle = False
        Me.MCfecha01.TabIndex = 19
        '
        'FormDCxFUR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(510, 292)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.botSalir, Me.labResultado, Me.Label1, Me.MCfecha01})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormDCxFUR"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcula el Día del Ciclo Menstrual en Base a la FUR"
        Me.ResumeLayout(False)

    End Sub

#End Region

    'variables de imagen para los botones
    Dim BotonOnGrande As Image
    Dim BotonOffGrande As Image
    Dim FlechitaArribaOFF, FlechitaArribaON As Image
    Dim FlechitaAbajoOFF, FlechitaAbajoON As Image

    Dim FUR As Date
    Dim Semanas As Integer
    Dim Dias As Integer
    Dim EG As Integer

    Private Sub FormDCxFUR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
    End Sub

    Private Sub MCfecha01_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MCfecha01.DateSelected
        If MCfecha01.SelectionStart > Today Then
            MsgBox("La FUR no puede situarse en el futuro...", MsgBoxStyle.Information, "Fecha Inválida...")
            labResultado.Text = "Selecciona el día de FUR"
            MCfecha01.SelectionStart = Today
        Else
            FUR = MCfecha01.SelectionStart
            'calcula los dias desde que se hizo el eco hasta hoy
            EG = (DateDiff(DateInterval.Day, FUR, Today)) + 1

            'procesa la info en un texto
            ProcesaDiasEnSemanasMasDias()
        End If
    End Sub

    Private Sub ProcesaDiasEnSemanasMasDias()

        'Dim intSemanas, intDias As Integer
        'Dim Calculo As Double
        'Dim TextoSemana, TextoDia As String
        'Dim SemanasFinal, DiasFinal As Integer
        Dim TextoDeEGenSemanasyDias As String

        If EG < 1 Then
            'valor invalido
            'vamos a ver que le pongo
            TextoDeEGenSemanasyDias = "Error en FUR, corrige..."
            labResultado.Text = TextoDeEGenSemanasyDias

        ElseIf EG > 365 Then
            'los ciclos tienen mas de 1 año sin presentarse, menopausica coño
            TextoDeEGenSemanasyDias = "Según esta FUR tiene más de un año sin ver regla..."
            labResultado.Text = TextoDeEGenSemanasyDias

        Else
            'esta en el rango de calculo lo hace

            TextoDeEGenSemanasyDias = "Según esta FUR esta en su día " & EG & " del ciclo."
            labResultado.Text = TextoDeEGenSemanasyDias
        End If
    End Sub

    Private Sub botSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub botSALIR_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalir.MouseEnter
        botSalir.Image = BotonOnGrande
    End Sub
    Private Sub botSALIR_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalir.MouseLeave
        botSalir.Image = BotonOffGrande
    End Sub

End Class
