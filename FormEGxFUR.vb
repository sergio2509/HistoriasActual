Public Class FormEGxFUR
    Inherits System.Windows.Forms.Form

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MCfecha01 As System.Windows.Forms.MonthCalendar
    Friend WithEvents botSalir As System.Windows.Forms.Button
    Friend WithEvents labResultado As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormEGxFUR))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MCfecha01 = New System.Windows.Forms.MonthCalendar()
        Me.botSalir = New System.Windows.Forms.Button()
        Me.labResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(152, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Introduce el d�a de la FUR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'MCfecha01
        '
        Me.MCfecha01.Location = New System.Drawing.Point(168, 48)
        Me.MCfecha01.MaxSelectionCount = 1
        Me.MCfecha01.Name = "MCfecha01"
        Me.MCfecha01.ShowToday = False
        Me.MCfecha01.ShowTodayCircle = False
        Me.MCfecha01.TabIndex = 3
        '
        'botSalir
        '
        Me.botSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSalir.Image = CType(resources.GetObject("botSalir.Image"), System.Drawing.Bitmap)
        Me.botSalir.Location = New System.Drawing.Point(136, 264)
        Me.botSalir.Name = "botSalir"
        Me.botSalir.Size = New System.Drawing.Size(224, 23)
        Me.botSalir.TabIndex = 18
        Me.botSalir.Text = "Salir"
        '
        'labResultado
        '
        Me.labResultado.Image = CType(resources.GetObject("labResultado.Image"), System.Drawing.Bitmap)
        Me.labResultado.Location = New System.Drawing.Point(24, 232)
        Me.labResultado.Name = "labResultado"
        Me.labResultado.Size = New System.Drawing.Size(472, 23)
        Me.labResultado.TabIndex = 17
        Me.labResultado.Text = "Selecciona el d�a de FUR"
        Me.labResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormEGxFUR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 294)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.botSalir, Me.labResultado, Me.Label1, Me.MCfecha01})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormEGxFUR"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcula la Edad Gestacional en Base a la FUR"
        Me.ResumeLayout(False)

    End Sub

#End Region

    'variables de imagen para los botones
    Dim BotonOnGrande As Image
    Dim BotonOffGrande As Image
    Dim FlechitaArribaOFF, FlechitaArribaON As Image
    Dim FlechitaAbajoOFF, FlechitaAbajoON As Image

    Dim FUR, FPP As Date
    Dim Semanas As Integer
    Dim Dias As Integer
    Dim EG As Integer

    Private Sub FormEGxFUR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
    End Sub

    Private Sub MCfecha01_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MCfecha01.DateSelected
        If MCfecha01.SelectionStart > Today Then
            MsgBox("La FUR no puede situarse en el futuro...", MsgBoxStyle.Information, "Fecha Inv�lida...")
            labResultado.Text = "Selecciona el d�a de FUR"
            MCfecha01.SelectionStart = Today
        Else
            FUR = MCfecha01.SelectionStart
            'calcula los dias desde que se hizo el eco hasta hoy
            EG = (DateDiff(DateInterval.Day, FUR, Today))
            FPP = FUR.AddDays(280)
            'procesa la info en un texto
            ProcesaDiasEnSemanasMasDias()
        End If
    End Sub

    Private Sub ProcesaDiasEnSemanasMasDias()

        'Dim intSemanas, intDias As Integer
        Dim Calculo As Double
        Dim TextoSemana, TextoDia As String
        Dim SemanasFinal, DiasFinal As Integer
        Dim TextoDeEGenSemanasyDias As String

        'inicializa
        TextoDia = ""
        TextoSemana = ""
    
        If EG < 1 Then
            'valor invalido
            'vamos a ver que le pongo
            TextoDeEGenSemanasyDias = "Error en FUR, corrige..."
            labResultado.Text = TextoDeEGenSemanasyDias

        ElseIf EG > 300 Then
            'la eg da 43 semanas o mas, lo dice
            TextoDeEGenSemanasyDias = "Seg�n esta FUR deber�a tener m�s de 43 semanas, revisa FUR..."
            labResultado.Text = TextoDeEGenSemanasyDias

        Else
            'esta en el rango de calculo lo hace
            SemanasFinal = EG \ 7
            Calculo = (EG / 7) - SemanasFinal
            If Calculo = 0 Then
                DiasFinal = 0
            Else
                DiasFinal = CInt(Calculo * 7)
            End If
            If SemanasFinal = 1 Then
                TextoSemana = "1 semana"
            Else
                TextoSemana = SemanasFinal & " semanas"
            End If
            If DiasFinal = 0 And SemanasFinal = 1 Then
                TextoDia = " exacta"
            ElseIf DiasFinal = 0 And SemanasFinal <> 1 Then
                TextoDia = " exactas"
            ElseIf DiasFinal = 1 Then
                TextoDia = " y 1 d�a."
            ElseIf DiasFinal > 1 Then
                TextoDia = " y " & DiasFinal & " d�as"
            End If

            TextoDeEGenSemanasyDias = TextoSemana & TextoDia
            labResultado.Text = "Seg�n esta FUR tiene " & TextoDeEGenSemanasyDias & " de gestaci�n, la FPP"
            If FPP < Today Then
                labResultado.Text += " fue el " & FPP.ToShortDateString
            ElseIf FPP = Today Then
                labResultado.Text += " es hoy " & FPP.ToShortDateString
            Else
                labResultado.Text += " es el " & FPP.ToShortDateString
            End If

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
