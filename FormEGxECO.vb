Public Class FormEGxECO
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
    Friend WithEvents MCfecha01 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents labSemanas As System.Windows.Forms.Label
    Friend WithEvents labDias As System.Windows.Forms.Label
    Friend WithEvents botSemanasMas As System.Windows.Forms.Button
    Friend WithEvents botDiasMas As System.Windows.Forms.Button
    Friend WithEvents botSemanasMenos As System.Windows.Forms.Button
    Friend WithEvents botDiasMenos As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents botCalcula As System.Windows.Forms.Button
    Friend WithEvents botSalir As System.Windows.Forms.Button
    Friend WithEvents labResultado As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormEGxECO))
        Me.MCfecha01 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labSemanas = New System.Windows.Forms.Label()
        Me.labDias = New System.Windows.Forms.Label()
        Me.botSemanasMas = New System.Windows.Forms.Button()
        Me.botDiasMas = New System.Windows.Forms.Button()
        Me.botSemanasMenos = New System.Windows.Forms.Button()
        Me.botDiasMenos = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.botCalcula = New System.Windows.Forms.Button()
        Me.labResultado = New System.Windows.Forms.Label()
        Me.botSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MCfecha01
        '
        Me.MCfecha01.Location = New System.Drawing.Point(24, 56)
        Me.MCfecha01.MaxSelectionCount = 1
        Me.MCfecha01.Name = "MCfecha01"
        Me.MCfecha01.ShowToday = False
        Me.MCfecha01.ShowTodayCircle = False
        Me.MCfecha01.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Introduce el día en que se efectuó el ECO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Paso No. 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(248, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Introduce la Edad Gestacional según el ECO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(248, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Paso No. 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labSemanas
        '
        Me.labSemanas.BackColor = System.Drawing.SystemColors.Window
        Me.labSemanas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labSemanas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSemanas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.labSemanas.Location = New System.Drawing.Point(248, 72)
        Me.labSemanas.Name = "labSemanas"
        Me.labSemanas.Size = New System.Drawing.Size(32, 24)
        Me.labSemanas.TabIndex = 6
        Me.labSemanas.Text = "4"
        Me.labSemanas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDias
        '
        Me.labDias.BackColor = System.Drawing.SystemColors.Window
        Me.labDias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDias.ForeColor = System.Drawing.SystemColors.WindowText
        Me.labDias.Location = New System.Drawing.Point(376, 72)
        Me.labDias.Name = "labDias"
        Me.labDias.Size = New System.Drawing.Size(32, 24)
        Me.labDias.TabIndex = 7
        Me.labDias.Text = "0"
        Me.labDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botSemanasMas
        '
        Me.botSemanasMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSemanasMas.Image = CType(resources.GetObject("botSemanasMas.Image"), System.Drawing.Bitmap)
        Me.botSemanasMas.Location = New System.Drawing.Point(280, 72)
        Me.botSemanasMas.Name = "botSemanasMas"
        Me.botSemanasMas.Size = New System.Drawing.Size(20, 12)
        Me.botSemanasMas.TabIndex = 8
        '
        'botDiasMas
        '
        Me.botDiasMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botDiasMas.Image = CType(resources.GetObject("botDiasMas.Image"), System.Drawing.Bitmap)
        Me.botDiasMas.Location = New System.Drawing.Point(408, 72)
        Me.botDiasMas.Name = "botDiasMas"
        Me.botDiasMas.Size = New System.Drawing.Size(20, 12)
        Me.botDiasMas.TabIndex = 9
        '
        'botSemanasMenos
        '
        Me.botSemanasMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSemanasMenos.Image = CType(resources.GetObject("botSemanasMenos.Image"), System.Drawing.Bitmap)
        Me.botSemanasMenos.Location = New System.Drawing.Point(280, 84)
        Me.botSemanasMenos.Name = "botSemanasMenos"
        Me.botSemanasMenos.Size = New System.Drawing.Size(20, 12)
        Me.botSemanasMenos.TabIndex = 10
        '
        'botDiasMenos
        '
        Me.botDiasMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botDiasMenos.Image = CType(resources.GetObject("botDiasMenos.Image"), System.Drawing.Bitmap)
        Me.botDiasMenos.Location = New System.Drawing.Point(408, 84)
        Me.botDiasMenos.Name = "botDiasMenos"
        Me.botDiasMenos.Size = New System.Drawing.Size(20, 12)
        Me.botDiasMenos.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(304, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Semanas  y"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(432, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Días"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botCalcula
        '
        Me.botCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCalcula.Image = CType(resources.GetObject("botCalcula.Image"), System.Drawing.Bitmap)
        Me.botCalcula.Location = New System.Drawing.Point(248, 144)
        Me.botCalcula.Name = "botCalcula"
        Me.botCalcula.Size = New System.Drawing.Size(224, 23)
        Me.botCalcula.TabIndex = 14
        Me.botCalcula.Text = "Calcula Edad Gestacional Actual"
        '
        'labResultado
        '
        Me.labResultado.Image = CType(resources.GetObject("labResultado.Image"), System.Drawing.Bitmap)
        Me.labResultado.Location = New System.Drawing.Point(24, 232)
        Me.labResultado.Name = "labResultado"
        Me.labResultado.Size = New System.Drawing.Size(472, 23)
        Me.labResultado.TabIndex = 15
        Me.labResultado.Text = "Completa los datos y calcula la edad gestacional"
        Me.labResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botSalir
        '
        Me.botSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSalir.Image = CType(resources.GetObject("botSalir.Image"), System.Drawing.Bitmap)
        Me.botSalir.Location = New System.Drawing.Point(136, 264)
        Me.botSalir.Name = "botSalir"
        Me.botSalir.Size = New System.Drawing.Size(224, 23)
        Me.botSalir.TabIndex = 16
        Me.botSalir.Text = "Salir"
        '
        'FormEGxECO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(514, 296)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.botSalir, Me.labResultado, Me.botCalcula, Me.Label6, Me.Label5, Me.botDiasMenos, Me.botSemanasMenos, Me.botDiasMas, Me.botSemanasMas, Me.labDias, Me.labSemanas, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.MCfecha01})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormEGxECO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcula la Edad Gestacional en Base a un ECO"
        Me.ResumeLayout(False)

    End Sub

#End Region

    'variables de imagen para los botones
    Dim BotonOnGrande As Image
    Dim BotonOffGrande As Image
    Dim FlechitaArribaOFF, FlechitaArribaON As Image
    Dim FlechitaAbajoOFF, FlechitaAbajoON As Image

    Dim FechaDelEco As Date
    Dim Semanas As Integer
    Dim Dias As Integer
    Dim EG As Integer


    Private Sub FormEGxECO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
        FlechitaArribaON = Form1.FlechitaArribaON
        FlechitaArribaOFF = Form1.FlechitaArribaOFF
        FlechitaAbajoON = Form1.FlechitaAbajoON
        FlechitaAbajoOFF = Form1.FlechitaAbajoOFF



        MCfecha01.SelectionStart = Today.AddDays(-1)
        FechaDelEco = MCfecha01.SelectionStart
        Semanas = 4
        Dias = 0
    End Sub


    Private Sub MCfecha01_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MCfecha01.DateSelected
        If MCfecha01.SelectionStart >= Today Then
            MsgBox("La fecha de realización del ECO no puede situarse ni hoy ni en el futuro...", MsgBoxStyle.Information, "Fecha Inválida...")
            MCfecha01.SelectionStart = Today.AddDays(-1)
        Else
            FechaDelEco = MCfecha01.SelectionStart
        End If
    End Sub

    Private Sub botSemanasMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSemanasMas.Click
        If Semanas >= 40 Then
            'no hace nada ya llego al tope
        Else
            Semanas += 1
            labSemanas.Text = Semanas
        End If
    End Sub

    Private Sub botSemanasMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSemanasMenos.Click
        If Semanas <= 4 Then
            'no hace nada
        Else
            Semanas -= 1
            labSemanas.Text = Semanas
        End If
    End Sub

    Private Sub botSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub botDiasMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botDiasMas.Click
        If Dias >= 6 Then
            'no hace nada
        Else
            Dias += 1
            labDias.Text = Dias
            If Dias = 1 Then
                Label6.Text = "Día"
            Else
                Label6.Text = "Días"
            End If
        End If
    End Sub

    Private Sub botDiasMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botDiasMenos.Click
        If Dias <= 0 Then
            'no hace nada
        Else
            Dias -= 1
            labDias.Text = Dias
            If Dias = 1 Then
                Label6.Text = "Día"
            Else
                Label6.Text = "Días"
            End If
        End If
    End Sub

    Private Sub botCalcula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCalcula.Click
        'revisa el calendario porsia n se ha seleccionado bien
        If MCfecha01.SelectionStart >= Today Then
            MsgBox("La fecha de realización del ECO no puede situarse ni hoy ni en el futuro...", MsgBoxStyle.Information, "Fecha Inválida...")
            MCfecha01.SelectionStart = Today.AddDays(-1)
        Else
            FechaDelEco = MCfecha01.SelectionStart
        End If

        'calcula los dias desde que se hizo el eco hasta hoy
        EG = (DateDiff(DateInterval.Day, FechaDelEco, Today))
        'ahora le suma los dias que decia que tenia en ese momento
        EG = EG + (Semanas * 7) + Dias
        'procesa la info en un texto
        ProcesaDiasEnSemanasMasDias()

    End Sub

    Private Sub ProcesaDiasEnSemanasMasDias()

        'Dim intSemanas, intDias As Integer
        Dim Calculo As Double
        Dim TextoSemana, TextoDia As String
        Dim SemanasFinal, DiasFinal As Integer
        Dim TextoDeEGenSemanasyDias As String
        Dim DiasQueFaltanPara280 As Integer
        Dim FPP As Date

        'inicializa
        TextoDia = ""
        TextoSemana = ""

        DiasQueFaltanPara280 = 280 - EG
        FPP = Today.AddDays(DiasQueFaltanPara280)
        

        If EG < 1 Then
            'valor invalido
            'vamos a ver que le pongo
            TextoDeEGenSemanasyDias = "Error en fechas y/o edad gestacional introducida, corrige..."
            labResultado.Text = TextoDeEGenSemanasyDias

        ElseIf EG > 300 Then
            'la eg da 43 semanas o mas, lo dice
            TextoDeEGenSemanasyDias = "Según este ECO debería tener más de 43 semanas, revisa datos..."
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
                TextoDia = " y 1 día."
            ElseIf DiasFinal > 1 Then
                TextoDia = " y " & DiasFinal & " días"
            End If

            TextoDeEGenSemanasyDias = TextoSemana & TextoDia
            labResultado.Text = "Según este ECO tiene " & TextoDeEGenSemanasyDias & " de gestación, la FPP"
            If FPP < Today Then
                labResultado.Text += " fue el " & FPP.ToShortDateString
            ElseIf FPP = Today Then
                labResultado.Text += " es hoy " & FPP.ToShortDateString
            Else
                labResultado.Text += " es el " & FPP.ToShortDateString
            End If

        End If

    End Sub

    'procesos graficos de los botones
    Private Sub botSEMANASMAS_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSemanasMas.MouseEnter
        botSemanasMas.Image = FlechitaArribaON
    End Sub
    Private Sub botSEMANASMAS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSemanasMas.MouseLeave
        botSemanasMas.Image = FlechitaArribaOFF
    End Sub

    Private Sub botSEMANASMENOS_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSemanasMenos.MouseEnter
        botSemanasMenos.Image = FlechitaAbajoON
    End Sub
    Private Sub botSEMANASMENOS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSemanasMenos.MouseLeave
        botSemanasMenos.Image = FlechitaAbajoOFF
    End Sub

    Private Sub botDIASMAS_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botDiasMas.MouseEnter
        botDiasMas.Image = FlechitaArribaON
    End Sub
    Private Sub botDIASMAS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botDiasMas.MouseLeave
        botDiasMas.Image = FlechitaArribaOFF
    End Sub

    Private Sub botDIASMENOS_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botDiasMenos.MouseEnter
        botDiasMenos.Image = FlechitaAbajoON
    End Sub
    Private Sub botDIASMENOS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botDiasMenos.MouseLeave
        botDiasMenos.Image = FlechitaAbajoOFF
    End Sub

    Private Sub botCALCULA_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCalcula.MouseEnter
        botCalcula.Image = BotonOnGrande
    End Sub
    Private Sub botCALCULA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCalcula.MouseLeave
        botCalcula.Image = BotonOffGrande
    End Sub

    Private Sub botSALIR_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalir.MouseEnter
        botSalir.Image = BotonOnGrande
    End Sub
    Private Sub botSALIR_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalir.MouseLeave
        botSalir.Image = BotonOffGrande
    End Sub


End Class
