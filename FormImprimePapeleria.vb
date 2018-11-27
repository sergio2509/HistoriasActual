Imports System.IO

Public Class FormImprimePapeleria
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
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents botVisualiza As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents botPersonaliza As System.Windows.Forms.Button
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents chkImprimeMembrete As System.Windows.Forms.CheckBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormImprimePapeleria))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.botVisualiza = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.botPersonaliza = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.chkImprimeMembrete = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(555, 12)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(427, 485)
        Me.TextBox2.TabIndex = 12
        '
        'botVisualiza
        '
        Me.botVisualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botVisualiza.Image = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botVisualiza.Location = New System.Drawing.Point(753, 653)
        Me.botVisualiza.Name = "botVisualiza"
        Me.botVisualiza.Size = New System.Drawing.Size(229, 23)
        Me.botVisualiza.TabIndex = 9
        Me.botVisualiza.Text = "Vista Previa de Impresión"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(427, 358)
        Me.TextBox1.TabIndex = 11
        '
        'botPersonaliza
        '
        Me.botPersonaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botPersonaliza.Image = CType(resources.GetObject("botPersonaliza.Image"), System.Drawing.Image)
        Me.botPersonaliza.Location = New System.Drawing.Point(12, 653)
        Me.botPersonaliza.Name = "botPersonaliza"
        Me.botPersonaliza.Size = New System.Drawing.Size(120, 23)
        Me.botPersonaliza.TabIndex = 15
        Me.botPersonaliza.Text = "Modifica Membrete"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(12, 407)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(537, 90)
        Me.TextBox3.TabIndex = 19
        '
        'chkImprimeMembrete
        '
        Me.chkImprimeMembrete.AutoSize = True
        Me.chkImprimeMembrete.Location = New System.Drawing.Point(808, 630)
        Me.chkImprimeMembrete.Name = "chkImprimeMembrete"
        Me.chkImprimeMembrete.Size = New System.Drawing.Size(112, 17)
        Me.chkImprimeMembrete.TabIndex = 20
        Me.chkImprimeMembrete.Text = "Imprime Membrete"
        Me.chkImprimeMembrete.UseVisualStyleBackColor = True
        '
        'FormImprimePapeleria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 688)
        Me.Controls.Add(Me.chkImprimeMembrete)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.botVisualiza)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.botPersonaliza)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormImprimePapeleria"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresión de Papelería"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim LineaImpresa(100) As String
    Dim NumerodeLineas As Integer
    Dim AnchodelParrafo As Integer
    Dim NumerodeParrafos As Integer
    Dim LineaParrafo(50) As String

    'variables del prepara el recipe
    Dim variableFont As Font
    Dim anchoenPixels As Integer
    Dim altoenPixels As Integer

    'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image



    Private Sub FormImprimePapeleria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    'Dim imagenLogoEmbarazada As Image

    Private Sub FormImprimePapeleria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        'imagenLogoEmbarazada = Form1.imagenLogoDelUsuario

        'prende o apaga el boton de personalizar la base de datos
        If Form1.BaseDeDatosCargada = True Then
            botPersonaliza.Enabled = True
        Else
            botPersonaliza.Enabled = False
        End If

        'barra de titulo
        If Form1.estPacienteAbierta.a01strNombre = "" Then
            Me.Text = "Récipes y Papelería - No se ha seleccionado una historia."
        Else
            Me.Text = "Récipes y Papelería - Historia Seleccionada: " & Form1.estPacienteAbierta.a01strNombre & " CI: " & Form1.estPacienteAbierta.a02strCedula
            'la edad si se tiene
            If Form1.estPacienteAbierta.a04intEdadActual <> -1 Then
                Me.Text += " Edad: " & Form1.estPacienteAbierta.a04intEdadActual.ToString & " años"
            End If
        End If


        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

        'rellena la o las ventanas con la información
        TextBox1.Text = Form1.TextoIntercambio
        TextBox2.Text = Form1.TextoIntercambio2

        'aca depende de si es un recipe
        If Form1.EsUnRecipe = True Then

            'es un recipe entonces aca aluego q añadio todos los medicamentos pone los datos de la paciente abierta si los hay
            'aca aluego q añadio todos los medicamentos pone los datos de la paciente abierta si los hay
            If Form1.estPacienteAbierta.a01strNombre <> "" Then
                'hay datos
                TextBox3.Text += "Paciente: " & Form1.estPacienteAbierta.a01strNombre & vbCrLf
                'la cedula formateada
                If Form1.estPacienteAbierta.a02strCedula.Length = 8 Then
                    'cedula de 8 cifras puede o no tener 0 inicial...
                    Dim strCedulaFormateada As String = Form1.estPacienteAbierta.a02strCedula.Substring(0, 2) & "." & Form1.estPacienteAbierta.a02strCedula.Substring(2, 3) & "." & Form1.estPacienteAbierta.a02strCedula.Substring(5, 3)
                    If strCedulaFormateada(0) = "0" Then
                        'tiene un cero inicial, lo quita
                        strCedulaFormateada = strCedulaFormateada.Substring(1, 9)
                    Else
                        'es un numero de 8  cifras con dos punticos 10.xxx.xxx lo deja talcual
                    End If
                    'una vez acomodado lo pone
                    TextBox3.Text += "CI de la Paciente: " & strCedulaFormateada & vbCrLf
                Else
                    'no tiene 8 cifras, revisa si hay algo
                    If Form1.estPacienteAbierta.a02strCedula <> "" Then
                        'ok hay algo pero no tiene 8 cifras ??? lo muestra tal cual
                        TextBox3.Text += "CI de la Paciente: " & Form1.estPacienteAbierta.a02strCedula & vbCrLf
                    Else
                        'no hay nada lo deja en blanco
                        TextBox3.Text += "CI de la Paciente: " & vbCrLf
                    End If
                End If
                'la fecha de nacimiento
                If Form1.estPacienteAbierta.a03datFechaDeNacimiento <> Nothing Then
                    TextBox3.Text += "Fecha de Nacimiento de la Paciente: " & Form1.estPacienteAbierta.a03datFechaDeNacimiento.ToShortDateString & " (" & Form1.estPacienteAbierta.a04intEdadActual.ToString & ") años" & vbCrLf
                Else
                    TextBox3.Text += "Fecha de Nacimiento de la Paciente: " & vbCrLf
                End If
                'la direccion
                If Form1.estPacienteAbierta.a06strDireccion <> "" Then
                    If Form1.estPacienteAbierta.a06strDireccion.Length > 50 Then
                        TextBox3.Text += "Dirección de la Paciente: " & Form1.estPacienteAbierta.a06strDireccion.Substring(0, 50) & vbCrLf
                    Else
                        TextBox3.Text += "Dirección de la Paciente: " & Form1.estPacienteAbierta.a06strDireccion & vbCrLf
                    End If
                Else
                    TextBox3.Text += "Dirección de la Paciente: " & vbCrLf
                End If
                'cellar o telefono
                If Form1.estPacienteAbierta.a07strCelular <> "" Then
                    TextBox3.Text += "Celular/Teléfono de la Paciente: " & Form1.estPacienteAbierta.a07strCelular & vbCrLf
                Else
                    TextBox3.Text += "Celular/Teléfono de la Paciente: " & vbCrLf
                End If

                TextBox3.Text += vbCrLf & "Fecha de Emisión: " & Today.ToShortDateString

            Else
                'recipe sin datos de pac abierta
                TextBox3.Text += "Paciente: " & vbCrLf
                TextBox3.Text += "CI de la Paciente: " & vbCrLf
                TextBox3.Text += "Fecha de Nacimiento de la Paciente: " & vbCrLf
                TextBox3.Text += "Dirección de la Paciente: " & vbCrLf
                TextBox3.Text += "Celular/Teléfono de la Paciente: " & vbCrLf

                TextBox3.Text += vbCrLf & "Fecha de Emisión: " & Today.ToShortDateString
            End If

        Else
            'no es recipe debe ser un informe o constancia, apaga la textbox3 y redimensiona la 1
            TextBox3.Visible = False
            TextBox1.Size = New System.Drawing.Size(427, 485)
        End If



    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
    Handles PrintDocument1.PrintPage

        Dim Linea As Integer

        Dim pFont As Font
        Dim nombreFont As Font
        Dim otrosFont As Font
        Dim direccionFont As Font
        Dim fechaFont As Font
        Dim RecipeFont As Font
        Dim IndicacionesFont As Font
        Dim DatosPacienteFont As Font
        Dim T As Integer

        'variables de prepararecipe
        '============================================
        Dim iLine As Integer
        Dim LineaProcesandose As String
        Dim PalabraActual As String
        Dim LineaActual As String

        Dim NumerodeCaracteres As Integer
        'Dim LineasdelParrafo As Integer
        'Dim t As Integer

        Dim C As Integer
        Dim Caracter As Char
        'Dim largoActual As Integer
        Dim anchoActual As Integer
        '=============================

        pFont = New Font("Courier New", 10)
        nombreFont = New Font("Times New Roman", 16, FontStyle.Italic)
        otrosFont = New Font("Times New Roman", 8, FontStyle.Bold)
        direccionFont = New Font("Times New Roman", 6)
        fechaFont = New Font("Times New Roman", 12, FontStyle.Bold)
        RecipeFont = New Font("Times New Roman", 10, FontStyle.Italic)
        IndicacionesFont = New Font("Times New Roman", 10, FontStyle.Italic)
        DatosPacienteFont = New Font("Lucida Console", 7)

        Dim Lmargin, Rmargin, Tmargin, Bmargin, pageHeight, pageWidth As Integer
        With PrintDocument1.DefaultPageSettings.Margins
            Lmargin = .Left
            Rmargin = .Right
            Tmargin = .Top
            Bmargin = .Bottom
        End With
        Dim PrintWidth, PrintHeight As Integer
        With PrintDocument1.DefaultPageSettings.PaperSize
            PrintWidth = .Width - Lmargin - Rmargin
            PrintHeight = .Height - Tmargin - Bmargin
            pageHeight = .Height
            pageWidth = .Width
        End With
        If PrintDocument1.DefaultPageSettings.Landscape = True Then
            'Dim Temporal As Integer
            With PrintDocument1.DefaultPageSettings.PaperSize
                PrintWidth = .Height - Rmargin - Lmargin
                PrintHeight = .Width - Tmargin - Bmargin
                Lmargin = PrintDocument1.DefaultPageSettings.Margins.Left
                Rmargin = PrintDocument1.DefaultPageSettings.Margins.Right
                Tmargin = PrintDocument1.DefaultPageSettings.Margins.Top
                Bmargin = PrintDocument1.DefaultPageSettings.Margins.Bottom
                pageHeight = .Width
                pageWidth = .Height
            End With
        End If

        Dim IniciodeRecipeX, IniciodeRecipeY, IniciodeIndicacionesX, IniciodeIndicacionesY As Integer
        Dim FindeRecipeX, FindeIndicacionesX As Integer
        'Dim FindeRecipeY, FindeIndicacionesY As Integer
        Dim AnchodeRecipe, AnchodeIndicaciones As Integer

        IniciodeRecipeX = Lmargin
        IniciodeRecipeY = Tmargin + 120  'Deja lineas en blanco arriba para el encabezado del recipe
        AnchodeRecipe = (PrintWidth \ 2) - Rmargin
        FindeRecipeX = Lmargin + AnchodeRecipe



        IniciodeIndicacionesX = (Lmargin * 2) + Rmargin + AnchodeRecipe
        IniciodeIndicacionesY = Tmargin + 120
        AnchodeIndicaciones = (PrintWidth \ 2) - Lmargin
        FindeIndicacionesX = PrintWidth + Lmargin

        Dim R As Rectangle
        Dim P As Pen
        P = New Pen(Color.Black, 1)
        R = New Rectangle(IniciodeRecipeX, Tmargin, AnchodeRecipe, PrintHeight)
        'e.Graphics.DrawRectangle(Pens.Blue, R)
        R = New Rectangle(IniciodeIndicacionesX, Tmargin, AnchodeIndicaciones, PrintHeight)
        'e.Graphics.DrawRectangle(Pens.Blue, R)

        'e.Graphics.DrawLine(P, (pageWidth \ 2), Tmargin, (pageWidth \ 2), pageHeight - Bmargin)

        anchoenPixels = AnchodeRecipe
        NumerodeParrafos = TextBox1.Lines.GetUpperBound(0)
        For T = 0 To 50
            LineaParrafo(T) = ""
        Next
        'nota: si hay mas de 50 lineas solo toma las primeras 50 
        If NumerodeParrafos > 50 Then NumerodeParrafos = 50

        For T = 0 To NumerodeParrafos
            LineaParrafo(T) = TextBox1.Lines(T)
        Next
        'ahora carga el tipo de letra que se va a usar
        variableFont = RecipeFont

        '=====================================
        For T = 0 To 100
            LineaImpresa(T) = ""
        Next

        NumerodeLineas = 0
        LineaActual = ""
        PalabraActual = ""


        For iLine = 0 To NumerodeParrafos
            LineaProcesandose = LineaParrafo(iLine)
            'calcula el numero de caracteres del parrafo actual
            NumerodeCaracteres = LineaProcesandose.Length

            For C = 0 To NumerodeCaracteres - 1
                Caracter = LineaProcesandose.Chars(C)
                If Caracter <> " " Then
                    PalabraActual += Caracter
                Else
                    PalabraActual += Caracter
                    'largoActual = LineaActual.Length + PalabraActual.Length
                    anchoActual = e.Graphics.MeasureString(LineaActual & PalabraActual, variableFont).Width

                    If anchoActual <= anchoenPixels Then
                        'la palabra cabe en esta linea
                        LineaActual += PalabraActual
                        PalabraActual = ""
                    Else
                        'la palabra no cabe
                        LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                        LineaActual = PalabraActual
                        PalabraActual = ""
                        NumerodeLineas += 1
                    End If
                End If
            Next
            'se acabo el parrafo, calcula el largo de la linea actual
            'largoActual = LineaActual.Length + PalabraActual.Length
            anchoActual = e.Graphics.MeasureString(LineaActual & PalabraActual, variableFont).Width

            If anchoActual <= anchoenPixels Then
                'la palabra cabe en esta linea
                LineaActual += PalabraActual
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            Else
                'la palabra no cabe pone la linea sin esa palabra, pasa a otra linea
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                'hace la nueva linea solamente con la palabra actual que no cupo arriba
                LineaActual = PalabraActual
                NumerodeLineas += 1
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            End If
        Next



        '=====================================================
        'PreparaRecipe()

        For Linea = 0 To NumerodeLineas
            altoenPixels = Math.Abs((e.Graphics.MeasureString(LineaImpresa(Linea), variableFont).Height) * 1.05)
            e.Graphics.DrawString(LineaImpresa(Linea), variableFont, Brushes.Black, IniciodeRecipeX, IniciodeRecipeY + altoenPixels * Linea)
        Next


        'INDICACIONES
        '=============
        anchoenPixels = AnchodeIndicaciones
        NumerodeParrafos = TextBox2.Lines.GetUpperBound(0)
        For T = 0 To 50
            LineaParrafo(T) = ""
        Next

        'nota: si hay mas de 50 lineas solo toma las primeras 50 
        If NumerodeParrafos > 50 Then NumerodeParrafos = 50

        For T = 0 To NumerodeParrafos
            LineaParrafo(T) = TextBox2.Lines(T)
        Next

        variableFont = IndicacionesFont

        '========================================
        For T = 0 To 100
            LineaImpresa(T) = ""
        Next

        NumerodeLineas = 0
        LineaActual = ""
        PalabraActual = ""

        For iLine = 0 To NumerodeParrafos
            LineaProcesandose = LineaParrafo(iLine)
            'calcula el numero de caracteres del parrafo actual
            NumerodeCaracteres = LineaProcesandose.Length

            For C = 0 To NumerodeCaracteres - 1
                Caracter = LineaProcesandose.Chars(C)
                If Caracter <> " " Then
                    PalabraActual += Caracter
                Else
                    PalabraActual += Caracter
                    anchoActual = e.Graphics.MeasureString(LineaActual & PalabraActual, variableFont).Width

                    If anchoActual <= anchoenPixels Then
                        'la palabra cabe en esta linea
                        LineaActual += PalabraActual
                        PalabraActual = ""
                    Else
                        'la palabra no cabe
                        LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                        LineaActual = PalabraActual
                        PalabraActual = ""
                        NumerodeLineas += 1
                    End If
                End If
            Next
            'se acabo el parrafo, calcula el largo de la linea actual
            anchoActual = e.Graphics.MeasureString(LineaActual & PalabraActual, variableFont).Width

            If anchoActual <= anchoenPixels Then
                'la palabra cabe en esta linea
                LineaActual += PalabraActual
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            Else
                'la palabra no cabe pone la linea sin esa palabra, pasa a otra linea
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                'hace la nueva linea solamente con la palabra actual que no cupo arriba
                LineaActual = PalabraActual
                NumerodeLineas += 1
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            End If
        Next

        '===================================
        'PreparaRecipe()
        For Linea = 0 To NumerodeLineas
            altoenPixels = Math.Abs((e.Graphics.MeasureString(LineaImpresa(Linea), variableFont).Height) * 1.05)
            e.Graphics.DrawString(LineaImpresa(Linea), variableFont, Brushes.Black, IniciodeIndicacionesX, IniciodeIndicacionesY + altoenPixels * Linea)
        Next



        Dim Encabezado(4) As String
        Dim InicioCentradoRecipe, InicioCentradoIndicaciones As Integer
        Dim strAncho, strAlto As Integer
        Dim FechayFirma As String
        Dim Tumb As Image
        Dim Origen As Integer

        Encabezado(0) = Form1.UsuarioEspecialidad
        Encabezado(1) = Form1.UsuarioNombre
        Encabezado(2) = Form1.UsuarioDir01
        Encabezado(3) = Form1.UsuarioDir02
        FechayFirma = "Fecha:         /        /                              Firma y Sello."


        'los datos de la paciente si es un recipe

        If Form1.EsUnRecipe = True Then
            'RP e Indicaciones
            e.Graphics.DrawString("RP.", nombreFont, Brushes.Black, IniciodeRecipeX + 80, Tmargin + 75)
            e.Graphics.DrawString("Indicaciones.", nombreFont, Brushes.Black, IniciodeIndicacionesX + 80, Tmargin + 75)

            'una liniecita en la parte de abajo
            Dim InicioYdeLineaAbajo As Integer
            InicioYdeLineaAbajo = pageHeight - (Bmargin + 130)
            'toma el ancho del recipe completo
            strAncho = AnchodeRecipe
            InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2)))
            InicioCentradoIndicaciones = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + (pageWidth \ 2)
            'pone lineas abajo
            e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, InicioYdeLineaAbajo, Lmargin + InicioCentradoRecipe + strAncho, InicioYdeLineaAbajo)

            'datos de la paciente (textbox3)
            Dim intLineaTextBox3 As Integer = 0
            For Each strLinea As String In TextBox3.Lines
                Dim intPosY = (pageHeight - 200) + (20 * intLineaTextBox3)

                If intLineaTextBox3 < 7 Then
                    If strLinea.Contains("Emisi") Then
                        'es la linea de la fecha escribela mas greande
                        e.Graphics.DrawString(strLinea, fechaFont, Brushes.Black, IniciodeRecipeX, intPosY)
                    Else
                        'es una linea normal
                        e.Graphics.DrawString(strLinea, DatosPacienteFont, Brushes.Black, IniciodeRecipeX, intPosY)
                    End If

                End If
                intLineaTextBox3 += 1
            Next

        End If

        'para aca si no hay datos del Usuario (medico)
        If Form1.booExistenDatosDelUsuario = False Then
            'no hay datos
            Exit Sub
        End If


        'para aca si no se quiere imprimir el membrete 0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
        If chkImprimeMembrete.Checked = False Then
            Exit Sub
        End If


        Tumb = Form1.imagenLogoDelUsuario

        Dim AltoDelDibujo, AnchoDelDibujo As Integer

        If Tumb.Height > Tumb.Width Then
            'es mas alta que ancha
            '48x80
            AltoDelDibujo = 80
            AnchoDelDibujo = Int(Tumb.Width * 80) \ Tumb.Height

            'situa en el recipe
            Origen = (IniciodeRecipeX + 24) - (AnchoDelDibujo \ 2)
            R = New Rectangle(Origen, Tmargin, AnchoDelDibujo, AltoDelDibujo)
            e.Graphics.DrawImage(Tumb, R)
            'situa en las indicaciones
            Origen = (IniciodeIndicacionesX + 24) - (AnchoDelDibujo \ 2)
            R = New Rectangle(Origen, Tmargin, AnchoDelDibujo, AltoDelDibujo)
            e.Graphics.DrawImage(Tumb, R)
        Else
            'es mas ancha que alta
            AnchoDelDibujo = 48
            AltoDelDibujo = Int(Tumb.Height * 48) \ Tumb.Width
            'situa en el recipe
            Origen = (Tmargin + 40) - (AltoDelDibujo \ 2)
            R = New Rectangle(IniciodeRecipeX, Origen, AnchoDelDibujo, AltoDelDibujo)
            e.Graphics.DrawImage(Tumb, R)
            'situa en las indicaciones
            Origen = (Tmargin + 40) - (AltoDelDibujo \ 2)
            R = New Rectangle(IniciodeIndicacionesX, Origen, AnchoDelDibujo, AltoDelDibujo)
            e.Graphics.DrawImage(Tumb, R)
        End If

        strAlto = e.Graphics.MeasureString(Encabezado(0), otrosFont).Height

        strAncho = e.Graphics.MeasureString(Encabezado(0), otrosFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        InicioCentradoIndicaciones = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + (pageWidth \ 2) + 28
        e.Graphics.DrawString(Encabezado(0), otrosFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 0)
        e.Graphics.DrawString(Encabezado(0), otrosFont, Brushes.Black, Lmargin + InicioCentradoIndicaciones, Tmargin + 0)

        strAncho = e.Graphics.MeasureString(Encabezado(1), nombreFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        InicioCentradoIndicaciones = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + (pageWidth \ 2) + 28
        e.Graphics.DrawString(Encabezado(1), nombreFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 20)
        e.Graphics.DrawString(Encabezado(1), nombreFont, Brushes.Black, Lmargin + InicioCentradoIndicaciones, Tmargin + 20)

        strAncho = e.Graphics.MeasureString(Encabezado(2), direccionFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        InicioCentradoIndicaciones = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + (pageWidth \ 2) + 28
        e.Graphics.DrawString(Encabezado(2), direccionFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 50)
        e.Graphics.DrawString(Encabezado(2), direccionFont, Brushes.Black, Lmargin + InicioCentradoIndicaciones, Tmargin + 50)

        strAncho = e.Graphics.MeasureString(Encabezado(3), direccionFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        InicioCentradoIndicaciones = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + (pageWidth \ 2) + 28
        e.Graphics.DrawString(Encabezado(3), direccionFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 60)
        e.Graphics.DrawString(Encabezado(3), direccionFont, Brushes.Black, Lmargin + InicioCentradoIndicaciones, Tmargin + 60)

        'toma el ancho del recipe menos el dibujito
        strAncho = AnchodeRecipe - 50 '50 es el ancho de dibujito - un margencito
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 25
        InicioCentradoIndicaciones = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + (pageWidth \ 2) + 25

        'pone lineas arriba y abajo
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, Tmargin + 15, Lmargin + InicioCentradoRecipe + strAncho, Tmargin + 15)
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, Tmargin + 48, Lmargin + InicioCentradoRecipe + strAncho, Tmargin + 48)
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, Tmargin + 70, Lmargin + InicioCentradoRecipe + strAncho, Tmargin + 70)

        e.Graphics.DrawLine(P, Lmargin + InicioCentradoIndicaciones, Tmargin + 15, Lmargin + InicioCentradoIndicaciones + strAncho, Tmargin + 15)
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoIndicaciones, Tmargin + 48, Lmargin + InicioCentradoIndicaciones + strAncho, Tmargin + 48)
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoIndicaciones, Tmargin + 70, Lmargin + InicioCentradoIndicaciones + strAncho, Tmargin + 70)





        ''fecha y firma
        'iniciodeFechayFirmaY = pageHeight - Bmargin
        'strAncho = e.Graphics.MeasureString(FechayFirma, fechaFont).Width
        'InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + Lmargin
        'InicioCentradoIndicaciones = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + (pageWidth \ 2) + Lmargin
        'e.Graphics.DrawString(FechayFirma, fechaFont, Brushes.Black, InicioCentradoRecipe, iniciodeFechayFirmaY)
        'e.Graphics.DrawString(FechayFirma, fechaFont, Brushes.Black, InicioCentradoIndicaciones, iniciodeFechayFirmaY)


    End Sub

    Private Sub PreparaRecipe()
        Dim iLine As Integer
        Dim LineaProcesandose As String
        Dim PalabraActual As String
        Dim LineaActual As String

        Dim NumerodeCaracteres As Integer
        'Dim LineasdelParrafo As Integer
        Dim t As Integer

        Dim C As Integer
        Dim Caracter As Char

        For t = 0 To 100
            LineaImpresa(t) = ""
        Next

        NumerodeLineas = 0

        LineaActual = ""
        PalabraActual = ""
        Dim largoActual As Integer
        'Dim anchoActual As Integer

        For iLine = 0 To NumerodeParrafos
            LineaProcesandose = LineaParrafo(iLine)
            'calcula el numero de caracteres del parrafo actual
            NumerodeCaracteres = LineaProcesandose.Length

            For C = 0 To NumerodeCaracteres - 1
                Caracter = LineaProcesandose.Chars(C)
                If Caracter <> " " Then
                    PalabraActual += Caracter
                Else
                    PalabraActual += Caracter
                    largoActual = LineaActual.Length + PalabraActual.Length


                    If largoActual <= AnchodelParrafo Then
                        'la palabra cabe en esta linea
                        LineaActual += PalabraActual
                        PalabraActual = ""
                    Else
                        'la palabra no cabe
                        LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                        LineaActual = PalabraActual
                        PalabraActual = ""
                        NumerodeLineas += 1
                    End If
                End If
            Next
            'se acabo el parrafo, calcula el largo de la linea actual
            largoActual = LineaActual.Length + PalabraActual.Length
            If largoActual <= AnchodelParrafo Then
                'la palabra cabe en esta linea
                LineaActual += PalabraActual
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            Else
                'la palabra no cabe pone la linea sin esa palabra, pasa a otra linea
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                'hace la nueva linea solamente con la palabra actual que no cupo arriba
                LineaActual = PalabraActual
                NumerodeLineas += 1
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            End If
        Next


    End Sub

    Private Sub PreparaIndicaciones()
        Dim iLine As Integer
        Dim LineaProcesandose As String
        Dim PalabraActual As String
        Dim LineaActual As String

        Dim NumerodeCaracteres As Integer
        'Dim LineasdelParrafo As Integer

        Dim t As Integer

        Dim C As Integer
        Dim Caracter As Char

        For t = 0 To 100
            LineaImpresa(t) = ""
        Next

        NumerodeLineas = 0

        LineaActual = ""
        PalabraActual = ""
        Dim largoActual As Integer

        Console.WriteLine("el numero de parrafos es: " & NumerodeParrafos)

        For iLine = 0 To NumerodeParrafos
            LineaProcesandose = LineaParrafo(iLine)
            'calcula el numero de caracteres del parrafo actual
            NumerodeCaracteres = LineaProcesandose.Length

            For C = 0 To NumerodeCaracteres - 1
                Caracter = LineaProcesandose.Chars(C)
                If Caracter <> " " Then
                    PalabraActual += Caracter
                Else
                    PalabraActual += Caracter
                    largoActual = LineaActual.Length + PalabraActual.Length
                    If largoActual <= AnchodelParrafo Then
                        'la palabra cabe en esta linea
                        LineaActual += PalabraActual
                        PalabraActual = ""
                    Else
                        'la palabra no cabe
                        LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                        LineaActual = PalabraActual
                        PalabraActual = ""
                        NumerodeLineas += 1
                    End If
                End If
            Next
            'se acabo el parrafo, calcula el largo de la linea actual
            largoActual = LineaActual.Length + PalabraActual.Length
            If largoActual <= AnchodelParrafo Then
                'la palabra cabe en esta linea
                LineaActual += PalabraActual
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            Else
                'la palabra no cabe pone la linea sin esa palabra, pasa a otra linea
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                'hace la nueva linea solamente con la palabra actual que no cupo arriba
                LineaActual = PalabraActual
                NumerodeLineas += 1
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            End If
        Next


    End Sub

    Private Sub botPersonaliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.Click
        MuestraVentanaDeDatosDelUsuario()
    End Sub

    Private Sub botVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botVisualiza.Click

        If Form1.BaseDeDatosCargada = False Then
            'no se ha cargado una base
            've si se quiere imprimir con membrete
            If chkImprimeMembrete.Checked = True Then
                'se quiere recipe personalizado ???
                MsgBox("No se ha cargado una Base de Datos de Historias, sólo se pueden personalizar los Récipes cuando se ha cargado una...", MsgBoxStyle.Information, "Base de Datos no cargada")
            End If
        Else
            'si se cargo una base, ve si hay datos y se 
            'quiere imprimir un membrete personalizado
            If Form1.booExistenDatosDelUsuario = False And chkImprimeMembrete.Checked = True Then
                'no hay datos
                MsgBox("No existen Datos del Usuario para personalizar los Récipes impresos en hojas sin membrete...", MsgBoxStyle.Information, "Faltan Datos")
            End If
        End If

        PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings

        PageSetupDialog1.PageSettings.Margins.Left = 150
        PageSetupDialog1.PageSettings.Margins.Right = 150
        PageSetupDialog1.PageSettings.Margins.Top = 200
        PageSetupDialog1.PageSettings.Margins.Bottom = 200
        PageSetupDialog1.PageSettings.Landscape = True

        If PageSetupDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
        Else
            Exit Sub
        End If

        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings

            'preview
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If




    End Sub

    'eventos del mouse sobre los botones
    Private Sub botPersonaliza_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.MouseEnter
        botPersonaliza.Image = BotonOn
    End Sub
    Private Sub botPeronaliza_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.MouseLeave
        botPersonaliza.Image = BotonOff
    End Sub
    Private Sub botVisualiza_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botVisualiza.MouseEnter
        botVisualiza.Image = BotonOnGrande
    End Sub
    Private Sub botVisualiza_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botVisualiza.MouseLeave
        botVisualiza.Image = BotonOffGrande
    End Sub

    Private Sub chkImprimeMembrete_CheckedChanged(sender As Object, e As EventArgs) Handles chkImprimeMembrete.CheckedChanged

        Dim Reply As MsgBoxResult

        If chkImprimeMembrete.Checked = True Then
            If Form1.booExistenDatosDelUsuario = False Then
                'no existe, ve si se cargo una base de datos
                If Form1.BaseDeDatosCargada = True Then
                    'si se cargo y no hay datos, pregunta si quiere introducirlos
                    Reply = MsgBox("No existen Datos del Usuario para personalizar los Récipes impresos en hojas sin membrete..." & vbCrLf & "¿Deseas introducir los Datos del Usuario para personalizar los Récipes e Informes de tu Base de Datos?", MsgBoxStyle.YesNo, "Personaliza Base de Datos")
                    If Reply = MsgBoxResult.Yes Then
                        'desea crear el archivo
                        MuestraVentanaDeDatosDelUsuario()
                    End If
                Else
                    'no se cargo una base informa pero no dice nada de que si quieres personalizarlos
                    MsgBox("No se ha cargado una Base de Datos de Historias, sólo se pueden personalizar los Récipes cuando se ha cargado una...", MsgBoxStyle.Information, "Base de Datos no cargada")
                    'apaga el chek
                    chkImprimeMembrete.Checked = False
                End If
            End If
        End If
    End Sub

    Private Sub MuestraVentanaDeDatosDelUsuario()
        Dim DLG As New FormDatosDelUsuario()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'se acepto lo que se metio

            ''revisa si se cambio la imagen
            'If FormDatosDelUsuario.SeCambioLaImagen = True Then
            '    'si se cambio la sustituye
            '    File.Copy(FormDatosDelUsuario.pathImagenNuevaSeleccionada, Form1.UsuarioImagen, True)
            'End If
            Form1.booExistenDatosDelUsuario = True
        End If
    End Sub


  
   
End Class
