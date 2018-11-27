Imports System.IO

Public Class FormDatosDelUsuario
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents botOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecialidad As System.Windows.Forms.TextBox
    Friend WithEvents txtDir01 As System.Windows.Forms.TextBox
    Friend WithEvents txtDir02 As System.Windows.Forms.TextBox
    Friend WithEvents labEspecialidad As System.Windows.Forms.Label
    Friend WithEvents labNombre As System.Windows.Forms.Label
    Friend WithEvents labDir As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents botImagen As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormDatosDelUsuario))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.botOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.txtDir01 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDir02 = New System.Windows.Forms.TextBox()
        Me.labEspecialidad = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.labDir = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.botImagen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Bitmap)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(368, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        '
        'botOk
        '
        Me.botOk.BackColor = System.Drawing.SystemColors.Control
        Me.botOk.BackgroundImage = CType(resources.GetObject("botOk.BackgroundImage"), System.Drawing.Bitmap)
        Me.botOk.Enabled = False
        Me.botOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botOk.Location = New System.Drawing.Point(224, 360)
        Me.botOk.Name = "botOk"
        Me.botOk.Size = New System.Drawing.Size(120, 23)
        Me.botOk.TabIndex = 6
        Me.botOk.Text = "Aceptar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(528, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre y Título. P.e.: Dr John H. Watson, M. D. (máx. 33 letras)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(28, 28)
        Me.txtNombre.MaxLength = 33
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(476, 26)
        Me.txtNombre.TabIndex = 9
        Me.txtNombre.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(528, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Especialidad: P.e.: Obstetricia y Ginecología (máx. 55 letras)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecialidad.Location = New System.Drawing.Point(28, 84)
        Me.txtEspecialidad.MaxLength = 55
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(476, 20)
        Me.txtEspecialidad.TabIndex = 11
        Me.txtEspecialidad.Text = ""
        '
        'txtDir01
        '
        Me.txtDir01.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir01.Location = New System.Drawing.Point(28, 132)
        Me.txtDir01.MaxLength = 95
        Me.txtDir01.Name = "txtDir01"
        Me.txtDir01.Size = New System.Drawing.Size(680, 18)
        Me.txtDir01.TabIndex = 12
        Me.txtDir01.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(528, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Dirección y Teléfono del Consultorio. (2 lineas cada una máx de 95 letras)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDir02
        '
        Me.txtDir02.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir02.Location = New System.Drawing.Point(28, 156)
        Me.txtDir02.MaxLength = 95
        Me.txtDir02.Name = "txtDir02"
        Me.txtDir02.Size = New System.Drawing.Size(680, 18)
        Me.txtDir02.TabIndex = 14
        Me.txtDir02.Text = ""
        '
        'labEspecialidad
        '
        Me.labEspecialidad.BackColor = System.Drawing.SystemColors.Info
        Me.labEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labEspecialidad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEspecialidad.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEspecialidad.Location = New System.Drawing.Point(100, 256)
        Me.labEspecialidad.Name = "labEspecialidad"
        Me.labEspecialidad.Size = New System.Drawing.Size(608, 28)
        Me.labEspecialidad.TabIndex = 15
        Me.labEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labNombre
        '
        Me.labNombre.BackColor = System.Drawing.SystemColors.Info
        Me.labNombre.Font = New System.Drawing.Font("Times New Roman", 14.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombre.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombre.Location = New System.Drawing.Point(104, 284)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(604, 32)
        Me.labNombre.TabIndex = 16
        Me.labNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDir
        '
        Me.labDir.BackColor = System.Drawing.SystemColors.Info
        Me.labDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labDir.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDir.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labDir.Location = New System.Drawing.Point(100, 316)
        Me.labDir.Name = "labDir"
        Me.labDir.Size = New System.Drawing.Size(608, 28)
        Me.labDir.TabIndex = 17
        Me.labDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Info
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label8.Location = New System.Drawing.Point(704, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(4, 88)
        Me.Label8.TabIndex = 19
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(700, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Muestra del Encabezado de los Récipes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(528, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Selecciona una imagen para los Récipes e Informes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botImagen
        '
        Me.botImagen.BackColor = System.Drawing.SystemColors.Control
        Me.botImagen.BackgroundImage = CType(resources.GetObject("botImagen.BackgroundImage"), System.Drawing.Bitmap)
        Me.botImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImagen.Location = New System.Drawing.Point(28, 204)
        Me.botImagen.Name = "botImagen"
        Me.botImagen.Size = New System.Drawing.Size(120, 23)
        Me.botImagen.TabIndex = 22
        Me.botImagen.Text = "Imagen"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 260)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Info
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label7.Location = New System.Drawing.Point(32, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 88)
        Me.Label7.TabIndex = 18
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FormDatosDelUsuario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(718, 388)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.botImagen, Me.Label5, Me.Label4, Me.Label8, Me.Label7, Me.labDir, Me.labNombre, Me.labEspecialidad, Me.txtDir02, Me.Label3, Me.txtDir01, Me.txtEspecialidad, Me.Label2, Me.txtNombre, Me.Label1, Me.Button1, Me.botOk})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormDatosDelUsuario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Usuario"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim BotonOn, BotonOff As Image
    Public Shared archivoOrigenImagen As String
    Dim Temp As String
    Dim Imagen As String
    Dim Tumb As Image
    Dim Ancho As Integer
    Dim Origen As Integer
    Dim Alto As Integer
    Dim UsuarioImagen As String
    Public Shared SeCambioLaImagen As Boolean
    Dim SeProdujoUnCambio As Boolean

    Dim BW As BinaryWriter
    Dim BR As BinaryReader
    Dim FS As FileStream



    'adicional es una cadena en blaco para meter mas datos porsia luego
    'pienso poner 5 adicionales porsia caso
    Dim Adicional As String



    Private Sub FormDatosDelUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializa()
        RevisaSiExisteElArchivo()

         VerificaOk()
    End Sub

    Private Sub Inicializa()
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff

    End Sub

    Private Sub RevisaSiExisteElArchivo()
        If File.Exists(Form1.ArchivoDatosDelUsuario) = True Then
            'existe lee  el archivo

            FS = New FileStream(Form1.ArchivoDatosDelUsuario, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            Form1.UsuarioNombre = BR.ReadString
            Form1.UsuarioEspecialidad = BR.ReadString
            Form1.UsuarioDir01 = BR.ReadString
            Form1.UsuarioDir02 = BR.ReadString
            'como siempre es igua no hace falta guardarlo
            'Form1.UsuarioImagen = BR.ReadString
            Adicional = BR.ReadString
            Adicional = BR.ReadString
            Adicional = BR.ReadString
            Adicional = BR.ReadString
            Adicional = BR.ReadString
            Adicional = BR.ReadString

            BR.Close()
            FS.Close()

            'ahora actualiza la pantalla con los datos leidos
            txtNombre.Text = Form1.UsuarioNombre
            txtEspecialidad.Text = Form1.UsuarioEspecialidad
            txtDir01.Text = Form1.UsuarioDir01
            txtDir02.Text = Form1.UsuarioDir02
            labNombre.Text = Form1.UsuarioNombre
            labEspecialidad.Text = Form1.UsuarioEspecialidad
            labDir.Text = Form1.UsuarioDir01 & vbCrLf & Form1.UsuarioDir02

            'actualiza la imagen con lo que esta en la carpeta de los datos
            Imagen = Form1.PathDatosDelUsuario & "\Imagen.jpg"
            Form1.UsuarioImagen = Imagen
            Temp = Form1.PathDatosDelUsuario & "\Temp.jpg"
            File.Copy(Imagen, Temp, True)
            Tumb = Image.FromFile(Temp)


            If Tumb.Height > Tumb.Width Then
                'es mas alta que ancha
                '48x80
                PictureBox1.Height = 80
                Ancho = Int(Tumb.Width * 80) \ Tumb.Height
                PictureBox1.Width = Ancho
                Origen = 68 - (Ancho \ 2)
                Me.PictureBox1.Location = New System.Drawing.Point(Origen, 260)

            Else
                'es mas ancha que alta
                PictureBox1.Width = 48
                Alto = Int(Tumb.Height * 48) \ Tumb.Width
                PictureBox1.Height = Alto
                Origen = 300 - (Alto \ 2)
                Me.PictureBox1.Location = New System.Drawing.Point(44, Origen)

            End If
            PictureBox1.Image = Tumb
            SeCambioLaImagen = False
            SeProdujoUnCambio = False
            Button1.Text = "Salir"
        Else
            'no existe hay que crear el archivo
            'inicializa el archivo de graficos porsia no se cambia
            archivoOrigenImagen = Form1.DirectorioDeLaAplicacion & "\Embarazada.jpg"
            SeCambioLaImagen = True
            SeProdujoUnCambio = True
            Button1.Text = "Salir"
        End If
    End Sub

    Private Sub txtTextos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtNombre.KeyPress, txtEspecialidad.KeyPress, _
                txtDir01.KeyPress, txtDir02.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsWhiteSpace(c)) Then
            e.Handled = True
        Else
            SeProdujoUnCambio = True
            Button1.Text = "Cancelar"
        End If
    End Sub

    Private Sub botOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botOk.Click

        'Dim Z As Integer
        'Dim EliminaPrimero As Boolean

        Adicional = ""

        'si se puede hacer clik en OK es porq hay datos en todas partes
        Form1.UsuarioNombre = txtNombre.Text
        Form1.UsuarioEspecialidad = txtEspecialidad.Text
        Form1.UsuarioDir01 = txtDir01.Text
        Form1.UsuarioDir02 = txtDir02.Text

        If SeCambioLaImagen = True Then
            Form1.UsuarioImagen = Form1.PathDatosDelUsuario & "\Imagen.jpg"
        Else
            'no se cambio la imagen no hace nada
        End If



        'ahora escribe los datos al archivo de datos del usuario
        FS = New FileStream(Form1.ArchivoDatosDelUsuario, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        'escribe los datos
        BW.Write(Form1.UsuarioNombre)
        BW.Write(Form1.UsuarioEspecialidad)
        BW.Write(Form1.UsuarioDir01)
        BW.Write(Form1.UsuarioDir02)
        'no escribe la imagen no hace falta porque siempre es igual
        'BW.Write(Form1.UsuarioImagen)
        BW.Write(Adicional)
        BW.Write(Adicional)
        BW.Write(Adicional)
        BW.Write(Adicional)
        BW.Write(Adicional)
        BW.Write(Adicional)

        FS.Close()
        BW.Close()

        'Tumb = Image.FromFile(Form1.DirectorioDeLaAplicacion & "\embarazada.jpg")

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SeCambioLaImagen = False
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    'eventos graficos de los botones

    Private Sub botAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botOk.MouseEnter
        botOk.BackgroundImage = BotonOn
    End Sub
    Private Sub botAceptar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botOk.MouseLeave
        botOk.BackgroundImage = BotonOff
    End Sub

    Private Sub botCancelar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = BotonOn
    End Sub
    Private Sub botCancelar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = BotonOff
    End Sub

    'EVENTOS DE ACTUALIZACION

    Private Sub txtNombre_CHANGE(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text <> "" Then
            labNombre.Text = txtNombre.Text
        Else
            labNombre.Text = ""
        End If
        VerificaOk()
    End Sub

    Private Sub txtEspecialidad_CHANGE(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEspecialidad.TextChanged
        If txtEspecialidad.Text <> "" Then
            labEspecialidad.Text = txtEspecialidad.Text
        Else
            labEspecialidad.Text = ""
        End If
        VerificaOk()
    End Sub

    Private Sub txtdir01_CHANGE(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDir01.TextChanged
        If txtDir01.Text <> "" Then
            labDir.Text = txtDir01.Text & vbCrLf & txtDir02.Text
        Else
            labDir.Text = txtDir02.Text
        End If
        VerificaOk()
    End Sub

    Private Sub txtdir02_CHANGE(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDir02.TextChanged
        If txtDir02.Text <> "" Then
            labDir.Text = txtDir01.Text & vbCrLf & txtDir02.Text
        Else
            labDir.Text = txtDir01.Text
        End If
        VerificaOk()
    End Sub

    Private Sub VerificaOk()
        If labNombre.Text <> "" And labEspecialidad.Text <> "" And labDir.Text <> "" Then
            'estan todos los escritos. ve si se produo un cambio
            If SeProdujoUnCambio = True Then
                'si se produjo, prende el boton ok
                botOk.Enabled = True
            End If
        Else
            botOk.Enabled = False
        End If
    End Sub

    Private Sub botImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImagen.Click
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.Filter = "All Image Formats (*.bmp;*.jpg;*.jpeg;*.gif;*.tif)|" & _
                       "*.bmp;*.jpg;*.jpeg;*.gif;*.tif|Bitmaps (*.bmp)|*.bmp|" & _
                       "GIFs (*.gif)|*.gif|JPEGs (*.jpg)|*.jpg;*.jpeg|TIFs (*.tif)|*.tif"
        OpenFileDialog1.FilterIndex = 1

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'se seleccionó un archivo
            archivoOrigenImagen = OpenFileDialog1.FileName
            Tumb = Image.FromFile(archivoOrigenImagen)

            If Tumb.Height > Tumb.Width Then
                'es mas alta que ancha
                '48x80
                PictureBox1.Height = 80
                Ancho = Int(Tumb.Width * 80) \ Tumb.Height
                PictureBox1.Width = Ancho
                Origen = 68 - (Ancho \ 2)
                Me.PictureBox1.Location = New System.Drawing.Point(Origen, 260)

            Else
                'es mas ancha que alta
                PictureBox1.Width = 48
                Alto = Int(Tumb.Height * 48) \ Tumb.Width
                PictureBox1.Height = Alto
                Origen = 300 - (Alto \ 2)
                Me.PictureBox1.Location = New System.Drawing.Point(44, Origen)

            End If
            PictureBox1.Image = Tumb
            SeCambioLaImagen = True
            SeProdujoUnCambio = True
            Button1.Text = "Cancelar"
            VerificaOk()
        Else
            'no se selecciono archivo jpg, no hace nada
        End If
    End Sub




End Class
