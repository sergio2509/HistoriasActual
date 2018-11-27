Imports System.IO

Public Class FormVentanaImpresion
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
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents botImprimeInforme As System.Windows.Forms.Button
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents botPersonaliza As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormVentanaImpresion))
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.botImprimeInforme = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.botPersonaliza = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'botCancelar
        '
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Bitmap)
        Me.botCancelar.Location = New System.Drawing.Point(8, 496)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(224, 23)
        Me.botCancelar.TabIndex = 9
        Me.botCancelar.Text = "Salir"
        '
        'txtTexto
        '
        Me.txtTexto.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto.Location = New System.Drawing.Point(8, 8)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTexto.Size = New System.Drawing.Size(776, 480)
        Me.txtTexto.TabIndex = 10
        Me.txtTexto.Text = ""
        '
        'botImprimeInforme
        '
        Me.botImprimeInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImprimeInforme.Image = CType(resources.GetObject("botImprimeInforme.Image"), System.Drawing.Bitmap)
        Me.botImprimeInforme.Location = New System.Drawing.Point(560, 496)
        Me.botImprimeInforme.Name = "botImprimeInforme"
        Me.botImprimeInforme.Size = New System.Drawing.Size(224, 23)
        Me.botImprimeInforme.TabIndex = 11
        Me.botImprimeInforme.Text = "Imprime Informe"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(159, 17)
        Me.PrintPreviewDialog1.MaximumSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Opacity = 1
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'botPersonaliza
        '
        Me.botPersonaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botPersonaliza.Image = CType(resources.GetObject("botPersonaliza.Image"), System.Drawing.Bitmap)
        Me.botPersonaliza.Location = New System.Drawing.Point(336, 496)
        Me.botPersonaliza.Name = "botPersonaliza"
        Me.botPersonaliza.Size = New System.Drawing.Size(120, 23)
        Me.botPersonaliza.TabIndex = 21
        Me.botPersonaliza.Text = "Personaliza Informe"
        '
        'FormVentanaImpresion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 528)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.botPersonaliza, Me.botImprimeInforme, Me.txtTexto, Me.botCancelar})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormVentanaImpresion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormVentanaImpresion"
        Me.ResumeLayout(False)

    End Sub

#End Region

    'variables para la impresion (la mayoria en el procedimiento)
    Dim HojaconMembrete As Boolean
    Dim LineasPorPagina As Integer
    Dim NumerodePaginas As Integer
    Dim IniciodeRecipeX, IniciodeRecipeY As Integer
    Dim FindeRecipeX, FindeRecipeY As Integer
    Dim AnchodeRecipe, AltodeRecipe As Integer
    'Dim LineaImpresa() As String
    Dim ArrayListLineaImpresa As New ArrayList()
    Dim altoenPixels As Integer

    'variables de los graficos
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BotonOn, BotonOff As Image

    Dim Tamaño As System.Drawing.Printing.PaperSize


    Private Sub FormVentanaImpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'recupera nombres de los botones
        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff

        'inicializa ventana
        txtTexto.Text = Form1.TextoIntercambio
        Me.Text = Form1.TituloVentanaDeTexto

        If Form1.TamañoDeLetra = 10 Then
            Me.txtTexto.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Else
            Me.txtTexto.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End If

    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        'Dim Reply As MsgBoxResult

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

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
                'pasa el caracter al texto
            End If

        End If
    End Sub

    Private Sub botImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImprimeInforme.Click

        If txtTexto.Text = "" Then
            MsgBox("La ventana de texto está vacía...", MsgBoxStyle.Information, "Control Ecográfico")
            Exit Sub
        End If


        PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings
        PageSetupDialog1.PageSettings.Margins.Left = 125
        PageSetupDialog1.PageSettings.Margins.Right = 125
        PageSetupDialog1.PageSettings.Margins.Top = 200
        PageSetupDialog1.PageSettings.Margins.Bottom = 250

        If PageSetupDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
        End If

        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Respuesta As MsgBoxResult
            Respuesta = MsgBox("¿Estas imprimiendo en hojas con Membrete?", MsgBoxStyle.YesNo, "Selección de Hojas")
            If Respuesta = MsgBoxResult.Yes Then
                HojaconMembrete = True
            Else
                HojaconMembrete = False
            End If
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings

            If Form1.booExistenDatosDelUsuario = False And HojaconMembrete = False Then
                'no hay datos Y SE quieren personalizar lo dice
                MsgBox("No se han intoducido los Datos del Usuario, para personalizar los Informes se deben introducir estos Datos primero...", MsgBoxStyle.Information, "Faltan Datos del Usuario")
            End If

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
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
        Dim variableFont As Font
        Dim T As Integer

        'variables de prepararecipe
        '============================================
        Dim iLine As Integer
        Dim LineaProcesandose As String
        Dim PalabraActual As String
        Dim LineaActual As String

        '=============================
        Dim anchoenPixels As Integer
        Dim NumerodeParrafos As Integer
        Dim LineaParrafo() As String
        Dim NumerodeLineas As Integer

        Dim C As Integer
        Dim Caracter As Char
        'Dim largoActual As Integer
        Dim anchoActual As Integer
        Dim NumerodeCaracteres As Integer
        'Dim LineasdelParrafo As Integer

        Static Z As Integer ' contador de paginas
        Dim Y As Integer    'contador de lineas por pagina

        If Form1.TamañoDeLetra = 10 Then
            pFont = New Font("Lucida Console", 8)
        Else
            pFont = New Font("Lucida Console", 7)
        End If
        nombreFont = New Font("Times New Roman", 16, FontStyle.Italic)
        otrosFont = New Font("Times New Roman", 8)
        direccionFont = New Font("Times New Roman", 6)
        fechaFont = New Font("Times New Roman", 10, FontStyle.Italic)
        RecipeFont = New Font("Lucida Console", 10)
        IndicacionesFont = New Font("Times New Roman", 10, FontStyle.Italic)

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


        IniciodeRecipeX = Lmargin
        IniciodeRecipeY = Tmargin + 100  'Deja lineas en blanco arriba para el encabezado del recipe
        AnchodeRecipe = PrintWidth
        FindeRecipeX = Lmargin + AnchodeRecipe
        FindeRecipeY = pageHeight - Bmargin - 50
        AltodeRecipe = FindeRecipeY - IniciodeRecipeY

        Dim R As Rectangle
        Dim P As Pen
        P = New Pen(Color.Black, 1)
        R = New Rectangle(IniciodeRecipeX, Tmargin, AnchodeRecipe, PrintHeight)
        'e.Graphics.DrawRectangle(Pens.Blue, R)

        anchoenPixels = AnchodeRecipe
        NumerodeParrafos = txtTexto.Lines.GetUpperBound(0)
        ReDim LineaParrafo(NumerodeParrafos)
        For T = 0 To NumerodeParrafos
            LineaParrafo(T) = ""
        Next

        For T = 0 To NumerodeParrafos
            LineaParrafo(T) = txtTexto.Lines(T)
        Next
        'ahora carga el tipo de letra que se va a usar

        variableFont = pFont

        '=====================================
        'ReDim LineaImpresa(NumerodeParrafos)
        'For T = 0 To NumerodeParrafos - 1
        'LineaImpresa(T) = ""
        'Next
        ArrayListLineaImpresa.Clear()
        'ojo le mete un caracter sin espacio en el indice 0
        ArrayListLineaImpresa.Add("")

        NumerodeLineas = 1
        LineaActual = ""
        PalabraActual = ""

        For iLine = 0 To NumerodeParrafos - 1
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
                        'LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                        ArrayListLineaImpresa.Add(LineaActual & vbCrLf)
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
                'LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                ArrayListLineaImpresa.Add(LineaActual & vbCrLf)
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            Else
                'la palabra no cabe pone la linea sin esa palabra, pasa a otra linea
                'LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                ArrayListLineaImpresa.Add(LineaActual & vbCrLf)
                'hace la nueva linea solamente con la palabra actual que no cupo arriba
                LineaActual = PalabraActual
                NumerodeLineas += 1
                'LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                ArrayListLineaImpresa.Add(LineaActual & vbCrLf)
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            End If
        Next

        '=====================================================
        'PreparaRecipe()
        Dim Encabezado(4) As String
        Dim InicioCentradoRecipe As Integer
        Dim strAncho, strAlto As Integer
        Dim FechayFirma As String
        Dim iniciodeFechayFirmaY As Integer
        Dim AnchodeRaya As Integer
        Dim LaLinea As String
        Dim Imagen As String
        Dim Temp As String
        Dim Tumb As Image
        Dim Origen As Integer

        LaLinea = CType(ArrayListLineaImpresa(1), String)
        altoenPixels = ((e.Graphics.MeasureString(LaLinea, variableFont).Height) - 2)
        LineasPorPagina = AltodeRecipe \ altoenPixels

        If NumerodeLineas <= LineasPorPagina Then
            NumerodePaginas = 0
            'hay menos lineas de las que caben en una pagina se imprime todo aqui
            For Linea = 1 To NumerodeLineas - 1
                LaLinea = CType(ArrayListLineaImpresa(Linea), String)
                e.Graphics.DrawString(LaLinea, variableFont, Brushes.Black, IniciodeRecipeX, IniciodeRecipeY + altoenPixels * Linea)
            Next

        Else
            'ojo se le quitan 3 al numero de lineas porque la numera cion empieza en cero
            'y se añade un vbcrlf al final lo que da un total de 2 mas, si se pone en menos 2
            'cuando se imprime un numero exacto de lineas en cada pagina es decir si caben 52
            'y el numerodelineas-2 es 104 el numero de pagina daria 2 (es decir 3 paginas)
            'aunque la ultima pagina no tendria nada que poner porque ya las 104 lineas con
            'informacion ya se escribieron, restando tres en cambio daria 103/52 y daria 
            'una fraccion de 1 y picote que al redondear seria igua a 1 (es decir solo 2 paginas)
            NumerodePaginas = Math.Floor((NumerodeLineas - 3) / LineasPorPagina)
            'Console.WriteLine("Numero de Lineas: " & NumerodeLineas)
            'Console.WriteLine("Numero de Lineas menos 3: " & NumerodeLineas - 3)
            'Console.WriteLine("Lineas por pagina: " & LineasPorPagina)
            'Console.WriteLine("Numero de paginas: " & NumerodePaginas)


            Dim LineasEscritas As Integer

            'ojo empieza en 0 por lo que hay una pagina mas de lo que diga
            If Z < NumerodePaginas Then
                For Y = 1 To LineasPorPagina
                    Linea = (Z * LineasPorPagina) + Y
                    LaLinea = CType(ArrayListLineaImpresa(Linea), String)
                    e.Graphics.DrawString(LaLinea, variableFont, Brushes.Black, IniciodeRecipeX, IniciodeRecipeY + altoenPixels * Y)
                Next
                Z = Z + 1
            Else
                LineasEscritas = NumerodePaginas * LineasPorPagina
                'Console.WriteLine("Lineas escritas + 1: " & LineasEscritas + 1)
                'Console.WriteLine("Numero de lineas - 2: " & NumerodeLineas - 2)
                For Linea = LineasEscritas + 1 To NumerodeLineas - 1
                    Dim LineaImprimiendose As Integer
                    LineaImprimiendose = Linea - LineasEscritas
                    LaLinea = CType(ArrayListLineaImpresa(Linea), String)
                    e.Graphics.DrawString(LaLinea, variableFont, Brushes.Black, IniciodeRecipeX, IniciodeRecipeY + altoenPixels * LineaImprimiendose)
                Next
                Z = Z + 1

            End If

            If Z <= NumerodePaginas Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                Z = 0
            End If
        End If

        If HojaconMembrete = True Then
            Exit Sub
        End If

        If Form1.booExistenDatosDelUsuario = False Then
            'no hay datos
            Exit Sub
        End If

        Encabezado(0) = Form1.UsuarioEspecialidad
        Encabezado(1) = Form1.UsuarioNombre
        Encabezado(2) = Form1.UsuarioDir01
        Encabezado(3) = Form1.UsuarioDir02

        strAlto = e.Graphics.MeasureString(Encabezado(0), otrosFont).Height
        AnchodeRaya = AnchodeRecipe - (60) '60 es el ancho de la imagen de la embarazada

        strAncho = e.Graphics.MeasureString(Encabezado(0), otrosFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        e.Graphics.DrawString(Encabezado(0), otrosFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 0)

        strAncho = e.Graphics.MeasureString(Encabezado(1), nombreFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        e.Graphics.DrawString(Encabezado(1), nombreFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 20)

        strAncho = e.Graphics.MeasureString(Encabezado(2), direccionFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        e.Graphics.DrawString(Encabezado(2), direccionFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 50)

        strAncho = e.Graphics.MeasureString(Encabezado(3), direccionFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        e.Graphics.DrawString(Encabezado(3), direccionFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 60)

        'grafico de la embarazada
        Imagen = Form1.PathDatosDelUsuario & "\Imagen.jpg"
        Temp = Form1.PathDatosDelUsuario & "\Temp.jpg"
        File.Copy(Imagen, Temp, True)
        Tumb = Image.FromFile(Temp)

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
        Else
            'es mas ancha que alta
            AnchoDelDibujo = 48
            AltoDelDibujo = Int(Tumb.Height * 48) \ Tumb.Width
            'situa en el recipe
            Origen = (Tmargin + 40) - (AltoDelDibujo \ 2)
            R = New Rectangle(IniciodeRecipeX, Origen, AnchoDelDibujo, AltoDelDibujo)
            e.Graphics.DrawImage(Tumb, R)
        End If

        'fecha y firma 
        FechayFirma = "Fecha:         /        /                                           Firma y Sello."
        iniciodeFechayFirmaY = pageHeight - Bmargin
        strAncho = e.Graphics.MeasureString(FechayFirma, fechaFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + Lmargin
        e.Graphics.DrawString(FechayFirma, fechaFont, Brushes.Black, InicioCentradoRecipe, iniciodeFechayFirmaY)

        'pone lineas arriba y abajo
        strAncho = AnchodeRaya
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28

        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, Tmargin + 15, Lmargin + InicioCentradoRecipe + strAncho, Tmargin + 15)
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, Tmargin + 48, Lmargin + InicioCentradoRecipe + strAncho, Tmargin + 48)
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, Tmargin + 70, Lmargin + InicioCentradoRecipe + strAncho, Tmargin + 70)

        'linea de abajo 
        Dim RayaFinalY As Integer
        RayaFinalY = pageHeight - (Bmargin + 35)
        strAncho = AnchodeRecipe
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2)))
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, RayaFinalY, Lmargin + InicioCentradoRecipe + strAncho, RayaFinalY)


        'grafico de la embarazada
        'R = New Rectangle(IniciodeRecipeX, Tmargin, 48, 80)
        'e.Graphics.DrawImage(PictureImpresora.Image, R)

    End Sub

    Private Sub botpersonaliza_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.MouseEnter
        botPersonaliza.Image = BotonOn
    End Sub
    Private Sub botPersonaliza_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.MouseLeave
        botPersonaliza.Image = BotonOff
    End Sub

    'personalizacion de informes
    Private Sub botPersonaliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.Click
        MuestraVentanaDeDatosDelUsuario()
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


    'eventos gaficos de los botones
    Private Sub botCancelar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseEnter
        botCancelar.Image = BotonOnGrande
    End Sub
    Private Sub botCancelar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseLeave
        botCancelar.Image = BotonOffGrande
    End Sub
    Private Sub botImprimeInforme_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeInforme.MouseEnter
        botImprimeInforme.Image = BotonOnGrande
    End Sub
    Private Sub botimprime_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botImprimeInforme.MouseLeave
        botImprimeInforme.Image = BotonOffGrande
    End Sub

End Class
