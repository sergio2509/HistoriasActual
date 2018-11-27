Imports System.IO

Public Class FormMedicamentos
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
    Friend WithEvents ListBoxSalida As System.Windows.Forms.ListBox
    Friend WithEvents BotAbreBaseDatos As System.Windows.Forms.Button
    Friend WithEvents BotCreaBaseDatos As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabNombreBaseDatos As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabMensaje As System.Windows.Forms.Label
    Friend WithEvents botNuevoMedicamento As System.Windows.Forms.Button
    Friend WithEvents LabMedicamentoResaltado As System.Windows.Forms.Label
    Friend WithEvents botMostrarMedicamento As System.Windows.Forms.Button
    Friend WithEvents botEliminaMedicamento As System.Windows.Forms.Button
    Friend WithEvents botRenombraMedicamento As System.Windows.Forms.Button
    Friend WithEvents txtBuscaMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormMedicamentos))
        Me.ListBoxSalida = New System.Windows.Forms.ListBox()
        Me.botNuevoMedicamento = New System.Windows.Forms.Button()
        Me.BotAbreBaseDatos = New System.Windows.Forms.Button()
        Me.BotCreaBaseDatos = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LabMensaje = New System.Windows.Forms.Label()
        Me.LabNombreBaseDatos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.botMostrarMedicamento = New System.Windows.Forms.Button()
        Me.LabMedicamentoResaltado = New System.Windows.Forms.Label()
        Me.botEliminaMedicamento = New System.Windows.Forms.Button()
        Me.botRenombraMedicamento = New System.Windows.Forms.Button()
        Me.txtBuscaMedicamento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxSalida
        '
        Me.ListBoxSalida.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxSalida.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxSalida.Location = New System.Drawing.Point(16, 152)
        Me.ListBoxSalida.Name = "ListBoxSalida"
        Me.ListBoxSalida.Size = New System.Drawing.Size(440, 290)
        Me.ListBoxSalida.TabIndex = 0
        '
        'botNuevoMedicamento
        '
        Me.botNuevoMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botNuevoMedicamento.Image = CType(resources.GetObject("botNuevoMedicamento.Image"), System.Drawing.Bitmap)
        Me.botNuevoMedicamento.Location = New System.Drawing.Point(24, 16)
        Me.botNuevoMedicamento.Name = "botNuevoMedicamento"
        Me.botNuevoMedicamento.Size = New System.Drawing.Size(120, 23)
        Me.botNuevoMedicamento.TabIndex = 1
        Me.botNuevoMedicamento.Text = "Nuevo"
        '
        'BotAbreBaseDatos
        '
        Me.BotAbreBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotAbreBaseDatos.Image = CType(resources.GetObject("BotAbreBaseDatos.Image"), System.Drawing.Bitmap)
        Me.BotAbreBaseDatos.Location = New System.Drawing.Point(240, 8)
        Me.BotAbreBaseDatos.Name = "BotAbreBaseDatos"
        Me.BotAbreBaseDatos.Size = New System.Drawing.Size(224, 23)
        Me.BotAbreBaseDatos.TabIndex = 3
        Me.BotAbreBaseDatos.Text = "Abrir Base de Datos"
        '
        'BotCreaBaseDatos
        '
        Me.BotCreaBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotCreaBaseDatos.Image = CType(resources.GetObject("BotCreaBaseDatos.Image"), System.Drawing.Bitmap)
        Me.BotCreaBaseDatos.Location = New System.Drawing.Point(8, 8)
        Me.BotCreaBaseDatos.Name = "BotCreaBaseDatos"
        Me.BotCreaBaseDatos.Size = New System.Drawing.Size(224, 23)
        Me.BotCreaBaseDatos.TabIndex = 2
        Me.BotCreaBaseDatos.Text = "Crear Nueva Base de datos"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        '
        'LabMensaje
        '
        Me.LabMensaje.BackColor = System.Drawing.SystemColors.Control
        Me.LabMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMensaje.Image = CType(resources.GetObject("LabMensaje.Image"), System.Drawing.Bitmap)
        Me.LabMensaje.Location = New System.Drawing.Point(16, 488)
        Me.LabMensaje.Name = "LabMensaje"
        Me.LabMensaje.Size = New System.Drawing.Size(760, 23)
        Me.LabMensaje.TabIndex = 14
        Me.LabMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabNombreBaseDatos
        '
        Me.LabNombreBaseDatos.BackColor = System.Drawing.SystemColors.Control
        Me.LabNombreBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNombreBaseDatos.ForeColor = System.Drawing.Color.White
        Me.LabNombreBaseDatos.Image = CType(resources.GetObject("LabNombreBaseDatos.Image"), System.Drawing.Bitmap)
        Me.LabNombreBaseDatos.Location = New System.Drawing.Point(16, 56)
        Me.LabNombreBaseDatos.Name = "LabNombreBaseDatos"
        Me.LabNombreBaseDatos.Size = New System.Drawing.Size(760, 23)
        Me.LabNombreBaseDatos.TabIndex = 13
        Me.LabNombreBaseDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Base de Datos Actual"
        '
        'botMostrarMedicamento
        '
        Me.botMostrarMedicamento.Enabled = False
        Me.botMostrarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botMostrarMedicamento.Image = CType(resources.GetObject("botMostrarMedicamento.Image"), System.Drawing.Bitmap)
        Me.botMostrarMedicamento.Location = New System.Drawing.Point(24, 48)
        Me.botMostrarMedicamento.Name = "botMostrarMedicamento"
        Me.botMostrarMedicamento.Size = New System.Drawing.Size(120, 23)
        Me.botMostrarMedicamento.TabIndex = 17
        Me.botMostrarMedicamento.Text = "Editar"
        '
        'LabMedicamentoResaltado
        '
        Me.LabMedicamentoResaltado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMedicamentoResaltado.ForeColor = System.Drawing.Color.White
        Me.LabMedicamentoResaltado.Image = CType(resources.GetObject("LabMedicamentoResaltado.Image"), System.Drawing.Bitmap)
        Me.LabMedicamentoResaltado.Location = New System.Drawing.Point(16, 456)
        Me.LabMedicamentoResaltado.Name = "LabMedicamentoResaltado"
        Me.LabMedicamentoResaltado.Size = New System.Drawing.Size(440, 23)
        Me.LabMedicamentoResaltado.TabIndex = 18
        Me.LabMedicamentoResaltado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botEliminaMedicamento
        '
        Me.botEliminaMedicamento.Enabled = False
        Me.botEliminaMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEliminaMedicamento.Image = CType(resources.GetObject("botEliminaMedicamento.Image"), System.Drawing.Bitmap)
        Me.botEliminaMedicamento.Location = New System.Drawing.Point(160, 48)
        Me.botEliminaMedicamento.Name = "botEliminaMedicamento"
        Me.botEliminaMedicamento.Size = New System.Drawing.Size(120, 23)
        Me.botEliminaMedicamento.TabIndex = 19
        Me.botEliminaMedicamento.Text = "Eliminar"
        '
        'botRenombraMedicamento
        '
        Me.botRenombraMedicamento.Enabled = False
        Me.botRenombraMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRenombraMedicamento.Image = CType(resources.GetObject("botRenombraMedicamento.Image"), System.Drawing.Bitmap)
        Me.botRenombraMedicamento.Location = New System.Drawing.Point(160, 16)
        Me.botRenombraMedicamento.Name = "botRenombraMedicamento"
        Me.botRenombraMedicamento.Size = New System.Drawing.Size(120, 23)
        Me.botRenombraMedicamento.TabIndex = 20
        Me.botRenombraMedicamento.Text = "Cambiar Nombre"
        '
        'txtBuscaMedicamento
        '
        Me.txtBuscaMedicamento.Location = New System.Drawing.Point(16, 120)
        Me.txtBuscaMedicamento.Name = "txtBuscaMedicamento"
        Me.txtBuscaMedicamento.Size = New System.Drawing.Size(440, 20)
        Me.txtBuscaMedicamento.TabIndex = 21
        Me.txtBuscaMedicamento.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Introduce las primeras letras del fármaco para filtrar la lista"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtDescripcion.Location = New System.Drawing.Point(472, 200)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(304, 280)
        Me.txtDescripcion.TabIndex = 23
        Me.txtDescripcion.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.botNuevoMedicamento, Me.botRenombraMedicamento, Me.botMostrarMedicamento, Me.botEliminaMedicamento})
        Me.GroupBox1.Location = New System.Drawing.Point(472, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 80)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicamentos"
        '
        'FormMedicamentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(790, 516)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.txtDescripcion, Me.Label1, Me.txtBuscaMedicamento, Me.LabMedicamentoResaltado, Me.LabMensaje, Me.LabNombreBaseDatos, Me.Label7, Me.BotAbreBaseDatos, Me.BotCreaBaseDatos, Me.ListBoxSalida})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMedicamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vademecum"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image

    Public Shared Farmacos As New ArrayList()
    Public Shared Tipo1 As New ArrayList()
    Public Shared Tipo2 As New ArrayList()
    Public Shared Tipo3 As New ArrayList()
    Public Shared Tipo4 As New ArrayList()
    Public Shared Tipo5 As New ArrayList()
    Public Shared Tipo6 As New ArrayList()
    Public Shared Tipo7 As New ArrayList()
    Public Shared Tipo8 As New ArrayList()
    Public Shared Tipo9 As New ArrayList()
    Public Shared Tipo10 As New ArrayList()
    Public Shared Tipo11 As New ArrayList()
    Public Shared Tipo12 As New ArrayList()
    Public Shared Tipo13 As New ArrayList()
    Public Shared Tipo14 As New ArrayList()
    Public Shared Tipo15 As New ArrayList()
    Public Shared Tipo16 As New ArrayList()
    Public Shared Tipo17 As New ArrayList()
    Public Shared Tipo18 As New ArrayList()

    Public Shared Path As String
    Public Shared NombreArchivoFarmaco As String
    Dim NombreBaseDatosMedicamentos As String
    Dim Filtro As Boolean

    Dim NombreFarmaco As String
    Dim Descripcion As String
    Dim PalabrasClave As String
    Public Shared MedicamentoResaltado As String
    Public Shared SeEstaCreandoUnMedicamentoNuevo As Boolean

    Structure DatosFarmaco
        Dim Nombre As String
        Dim Presentacion As String
        Dim Dosificacion As String
        Dim Cantidad As String
        Dim Indicaciones As String
        Dim Descripcion As String
        Dim Tipo1 As Boolean
        Dim Tipo2 As Boolean
        Dim Tipo3 As Boolean
        Dim Tipo4 As Boolean
        Dim Tipo5 As Boolean
        Dim Tipo6 As Boolean
        Dim Tipo7 As Boolean
        Dim Tipo8 As Boolean
        Dim Tipo9 As Boolean
        Dim Tipo10 As Boolean
        Dim Tipo11 As Boolean
        Dim Tipo12 As Boolean
        Dim Tipo13 As Boolean
        Dim Tipo14 As Boolean
        Dim Tipo15 As Boolean
        Dim Tipo16 As Boolean
        Dim Tipo17 As Boolean
        Dim Tipo18 As Boolean
    End Structure


    Private Sub FormMedicamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        Form1.VademecumAbierto = True
        Filtro = False
        ConfiguracionBaseDatosNoCargada()
    End Sub

    Private Sub FormularioClose(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim reply As MsgBoxResult
        reply = MsgBox("¿Deseas cerrar la ventana de vademecum?" & vbCrLf & _
        "También puedes minimizarla y seguir trabajando sin cerrarla..." & vbCrLf & _
        "Presiona Ok para confirmar salida.", MsgBoxStyle.OkCancel, "Confirma salir del Vademecum")
        If reply = MsgBoxResult.Cancel Then
            e.Cancel = True
        Else
            Form1.VademecumAbierto = False
        End If

    End Sub

    Private Sub BotCreaBaseDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotCreaBaseDatos.Click
        Dim FS As FileStream
        Dim Largo As Integer


        SaveFileDialog1.DefaultExt = ".BDM"      'extension predeterminada
        SaveFileDialog1.AddExtension = True     'añade de forma automatica la extension
        SaveFileDialog1.Filter = "Bases de Datos de Medicamentos (*.bdm)|*.bdm" 'coloca el filtro de archivos de la ventana

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'si se sale con ok se coloca el resultado en filename
            NombreBaseDatosMedicamentos = SaveFileDialog1.FileName
            'crea un directorio para guardar las historias de esta base de datos recien creada
            Path = NombreBaseDatosMedicamentos
            Largo = Path.Length
            Path = Path.Remove(Largo - 4, 4) & "-Contenido"

            If Directory.Exists(Path) Then
                'aqui deberia poner una contraseña para permitir la eliminación de las historias.....

                If MsgBox("La Carpeta: " & Path & " ya existe, se perderan todos  los Medicamentos almacenados en ella, para confirmar presiona Aceptar.", _
                            MsgBoxStyle.OkCancel, "Confirmar la Eliminación") = MsgBoxResult.Ok Then
                    MsgBox("Se sobreescribió la carpeta " & Path & ", se perdieron todos los medicamentos almacenados en ella", MsgBoxStyle.Critical)
                    Directory.Delete(Path, True)
                    Directory.CreateDirectory(Path)

                    'directorio general de farmacos
                    FS = New FileStream(NombreBaseDatosMedicamentos, FileMode.Create, FileAccess.ReadWrite)
                    FS.Close()
                    'directorios de tipos de farmacos

                    Dim T As Integer
                    Dim NombreSubBase As String
                    For T = 1 To 18
                        NombreSubBase = Path & "\Tipo" & T.ToString & ".bds"
                        FS = New FileStream(NombreSubBase, FileMode.Create, FileAccess.ReadWrite)
                        FS.Close()
                    Next

                    Farmacos.Clear()
                    LeeContenidoBaseDatos()
                    MuestraContenidoBaseDatos()
                Else
                    'no se sobreescribe el directorio existente
                    MsgBox("No se realizaron modificaciones a la carpeta " & Path, MsgBoxStyle.Information)
                    ConfiguracionBaseDatosNoCargada()
                End If
            Else
                'no hay ningun directorio con ese nombre no hay problema...
                Directory.CreateDirectory(Path)
                'crea el indice general de la base de datos
                FS = New FileStream(NombreBaseDatosMedicamentos, FileMode.Create, FileAccess.ReadWrite)
                FS.Close()
                'crea los indices especificos de tipos de farmacos (18 en total los pone dentro de la subcarpeta
                Dim T As Integer
                Dim NombreSubBase As String
                For T = 1 To 18
                    NombreSubBase = Path & "\Tipo" & T.ToString & ".bds"
                    FS = New FileStream(NombreSubBase, FileMode.Create, FileAccess.ReadWrite)
                    FS.Close()
                Next
                Farmacos.Clear()
                LeeContenidoBaseDatos()
                MuestraContenidoBaseDatos()
            End If
        End If
    End Sub

    Private Sub BotAbreBaseDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotAbreBaseDatos.Click
        Dim Largo As Integer
        OpenFileDialog1.DefaultExt = ".BDM"
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.Filter = "Bases de Datos de Medicamentos (*.bdm) |*.bdm"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            NombreBaseDatosMedicamentos = OpenFileDialog1.FileName
            Path = NombreBaseDatosMedicamentos
            Largo = Path.Length
            Path = Path.Remove(Largo - 4, 4) & "-Contenido"
            LeeContenidoBaseDatos()
            MuestraContenidoBaseDatos()
        Else
            'ConfiguracionBaseDatosNoCargada()
        End If
    End Sub

    Private Sub LeeContenidoBaseDatos()
        Dim BR As BinaryReader
        Dim FS As FileStream

        'lee el indice general y lo guarda en array lid farmacos
        FS = New FileStream(NombreBaseDatosMedicamentos, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim H As String
        Dim C As Integer
        Farmacos.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Farmacos.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'lee los subindices y los guarda en sus respectivas array lists
        FS = New FileStream(Path & "\Tipo1.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo1.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo1.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo2.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo2.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo2.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo3.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo3.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo3.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo4.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo4.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo4.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo5.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo5.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo5.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo6.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo6.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo6.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo7.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo7.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo7.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo8.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo8.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo8.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo9.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo9.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo9.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo10.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo10.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo10.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo11.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo11.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo11.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo12.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo12.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo12.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo13.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo13.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo13.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo14.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo14.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo14.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo15.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo15.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo15.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo16.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo16.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo16.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo17.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo17.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo17.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        FS = New FileStream(Path & "\Tipo18.bds", FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Tipo18.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H = BR.ReadString
            Tipo18.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub

    Private Sub MuestraContenidoBaseDatos()
        Dim REnum As IEnumerator
        REnum = Farmacos.GetEnumerator
        Dim Medicamento As String
        Dim CaracteresIntroducidos(50) As Char
        Dim LargoNuevo, LargoViejo As Integer
        Dim CaracteresExistentes(50) As Char
        Dim Similares, Iguales As Boolean
        Dim t As Integer

        ListBoxSalida.Items.Clear()
        txtDescripcion.Clear()

        Dim contador As Integer = 0

        LargoNuevo = txtBuscaMedicamento.Text.Length

        If Filtro = True Then
            'aqui va la parte de filtro
            For t = 0 To LargoNuevo - 1
                CaracteresIntroducidos(t) = txtBuscaMedicamento.Text.Chars(t)
            Next

            Iguales = False

            While REnum.MoveNext
                Medicamento = CType(REnum.Current, String)
                If txtBuscaMedicamento.Text.ToUpper = Medicamento.ToUpper Then
                    ListBoxSalida.Items.Add(Medicamento)
                    Iguales = True
                    contador += 1
                End If

                LargoViejo = Medicamento.Length
                If LargoNuevo > LargoViejo Then
                    Similares = True
                    For t = 0 To LargoViejo - 1
                        CaracteresExistentes(t) = Medicamento.Chars(t)
                        If Char.ToUpper(CaracteresIntroducidos(t)) <> Char.ToUpper(CaracteresExistentes(t)) Then
                            Similares = False
                            Exit For
                        End If
                    Next
                    If Similares = True And LargoNuevo > 0 And Iguales = False Then
                        ListBoxSalida.Items.Add(Medicamento)
                        contador += 1
                    End If
                Else 'entonces largoviejo es mayor que el largonuevo
                    Similares = True
                    For t = 0 To LargoNuevo - 1
                        CaracteresExistentes(t) = Medicamento.Chars(t)
                        If Char.ToUpper(CaracteresIntroducidos(t)) <> Char.ToUpper(CaracteresExistentes(t)) Then
                            Similares = False
                            Exit For
                        End If
                    Next
                    If Similares = True And LargoNuevo > 0 And Iguales = False Then
                        ListBoxSalida.Items.Add(Medicamento)
                        contador += 1
                    End If
                End If
            End While
            If contador = 0 Then
                ConfiguracionBaseDatosVacia()
                LabMensaje.Text = "No existe un medicamento con esta combinación de letras en la Base de Datos..."
                txtBuscaMedicamento.Enabled = True
                txtBuscaMedicamento.Focus()
            Else
                ConfiguracionBaseDatosNoVacia()
            End If
        Else
            While REnum.MoveNext
                Medicamento = CType(REnum.Current, String)
                ListBoxSalida.Items.Add(Medicamento)
                contador += 1

            End While
            If contador = 0 Then
                ConfiguracionBaseDatosVacia()
            Else
                ConfiguracionBaseDatosNoVacia()
            End If
        End If

    End Sub

    Private Sub ConfiguracionBaseDatosNoCargada()
        ListBoxSalida.Items.Clear()
        BotCreaBaseDatos.Enabled = True
        BotAbreBaseDatos.Enabled = True
        botNuevoMedicamento.Enabled = False
        botEliminaMedicamento.Enabled = False
        botMostrarMedicamento.Enabled = False
        botRenombraMedicamento.Enabled = False
        LabNombreBaseDatos.Text = "Ninguna"
        LabMedicamentoResaltado.Text = ""
        LabMensaje.Text = "Primero Abre o Crea una Base de Datos..."
        txtBuscaMedicamento.Enabled = False
    End Sub

    Private Sub ConfiguracionBaseDatosVacia()
        BotCreaBaseDatos.Enabled = True
        BotAbreBaseDatos.Enabled = True
        botNuevoMedicamento.Enabled = True
        botMostrarMedicamento.Enabled = False
        botEliminaMedicamento.Enabled = False
        botRenombraMedicamento.Enabled = False
        LabNombreBaseDatos.Text = NombreBaseDatosMedicamentos
        LabMedicamentoResaltado.Text = ""
        LabMensaje.Text = "Primero introduce al menos un medicamento a la Base de Datos..."
        txtBuscaMedicamento.Enabled = False
    End Sub

    Private Sub ConfiguracionBaseDatosNoVacia()
        BotCreaBaseDatos.Enabled = True
        BotAbreBaseDatos.Enabled = True
        botNuevoMedicamento.Enabled = True
        botMostrarMedicamento.Enabled = False
        botEliminaMedicamento.Enabled = False
        botRenombraMedicamento.Enabled = False
        LabNombreBaseDatos.Text = NombreBaseDatosMedicamentos
        LabMedicamentoResaltado.Text = ""
        LabMensaje.Text = "Selecciona un medicamento de la lista o Introduce uno nuevo"
        txtBuscaMedicamento.Enabled = True
    End Sub

    Private Sub ListBoxSalida_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxSalida.SelectedIndexChanged

        MedicamentoResaltado = ListBoxSalida.SelectedItem
        botMostrarMedicamento.Enabled = True
        botEliminaMedicamento.Enabled = True
        botRenombraMedicamento.Enabled = True
        LabMedicamentoResaltado.Text = MedicamentoResaltado
        LabMensaje.Text = "Ahora puedes: MODIFICAR, ELIMINAR o RENOMBRAR el medicamento seleccionado o AÑADIR uno nuevo"

        Dim MedicamentoSeleccionado As String = ListBoxSalida.SelectedItem


        txtDescripcion.Clear()

        'accede a los datos del medicamento y los muestra en la descripcion
        NombreArchivoFarmaco = Path & "\" & MedicamentoSeleccionado & ".far"
        Dim BR As BinaryReader
        Dim FS As FileStream
        FS = New FileStream(NombreArchivoFarmaco, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim H As New DatosFarmaco()
        Dim C As Integer

        While FS.Position < FS.Length
            H = Nothing
            H.Nombre = BR.ReadString
            H.Presentacion = BR.ReadString
            H.Dosificacion = BR.ReadString
            H.Cantidad = BR.ReadString
            H.Indicaciones = BR.ReadString
            H.Descripcion = BR.ReadString
            H.Tipo1 = BR.ReadBoolean
            H.Tipo2 = BR.ReadBoolean
            H.Tipo3 = BR.ReadBoolean
            H.Tipo4 = BR.ReadBoolean
            H.Tipo5 = BR.ReadBoolean
            H.Tipo6 = BR.ReadBoolean
            H.Tipo7 = BR.ReadBoolean
            H.Tipo8 = BR.ReadBoolean
            H.Tipo9 = BR.ReadBoolean
            H.Tipo10 = BR.ReadBoolean
            H.Tipo11 = BR.ReadBoolean
            H.Tipo12 = BR.ReadBoolean
            H.Tipo13 = BR.ReadBoolean
            H.Tipo14 = BR.ReadBoolean
            H.Tipo15 = BR.ReadBoolean
            H.Tipo16 = BR.ReadBoolean
            H.Tipo17 = BR.ReadBoolean
            H.Tipo18 = BR.ReadBoolean
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
        txtDescripcion.Text += H.Nombre.ToUpper & vbCrLf
        txtDescripcion.Text += vbCrLf
        txtDescripcion.Text += H.Presentacion & " - " & H.Dosificacion & vbCrLf
        txtDescripcion.Text += H.Cantidad & vbCrLf
        txtDescripcion.Text += vbCrLf
        txtDescripcion.Text += "Posología: " & H.Indicaciones & vbCrLf
        txtDescripcion.Text += vbCrLf
        txtDescripcion.Text += "Descripción: " & H.Descripcion & vbCrLf
    End Sub

    Private Sub ListBoxSalida_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxSalida.DoubleClick
        If ListBoxSalida.SelectedItem <> "" Then
            MedicamentoResaltado = ListBoxSalida.SelectedItem
            LabMedicamentoResaltado.Text = MedicamentoResaltado
            MostrarMedicamento()
        End If
    End Sub

    Private Sub botNuevoMedicamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNuevoMedicamento.Click
        Dim DLG As New FormNuevoMedicamento()

        'esta es la bandera para saber si se esta creando un nuevo medicamento o se esta modificando su nombre...
        SeEstaCreandoUnMedicamentoNuevo = True

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            NombreFarmaco = DLG.txtNombreFarmaco.Text

            CreaMedicamento()
            ActualizaBaseDatos()
            MuestraContenidoBaseDatos()
        Else
            'se cancelo y no se introdujo nada nuevo
        End If
    End Sub

    Private Sub CreaMedicamento()
        Dim DLG As New FormEditarMedicamento()
        Dim FS As FileStream
        Dim BW As BinaryWriter

        MedicamentoResaltado = NombreFarmaco
        NombreArchivoFarmaco = Path & "\" & NombreFarmaco & ".far"
        FS = New FileStream(NombreArchivoFarmaco, FileMode.Create)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write("")
        BW.Write("")
        BW.Write("")
        BW.Write("")
        BW.Write("")
        BW.Write("")
        'inicializa las 18 categorias de farmacos a false
        Dim T As Integer
        For T = 1 To 18
            BW.Write(False)
        Next
        FS.Close()
        BW.Close()
        Console.WriteLine("Se creó el archivo: " & NombreArchivoFarmaco)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'revisar si hay cambios para actualizar los datos
        Else
            'se salio cancelando
        End If

    End Sub

    Private Sub ActualizaBaseDatos()

        Farmacos.Add(NombreFarmaco)
        Farmacos.Sort()
        'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim REnum As IEnumerator

        REnum = Farmacos.GetEnumerator
        Dim R As String
        FS = New FileStream(NombreBaseDatosMedicamentos, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        While REnum.MoveNext
            R = CType(REnum.Current, String)
            BW.Write(R)
        End While
        FS.Close()
        BW.Close()
    End Sub

    Private Sub botRenombraMedicamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRenombraMedicamento.Click
        RenombraFarmaco()
    End Sub

    Private Sub RenombraFarmaco()
        Dim NombreAntiguo, NombreNuevo As String
        Dim DLG As New FormNuevoMedicamento()

        'no se esta creando solo se modifica el nombre
        SeEstaCreandoUnMedicamentoNuevo = False

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            NombreAntiguo = MedicamentoResaltado
            NombreNuevo = DLG.txtNombreFarmaco.Text

            'modifica el array list principal
            Farmacos.Remove(NombreAntiguo)
            Farmacos.Add(NombreNuevo)
            Farmacos.Sort()
            'escribe al disco el contenido de la base de datos modificada
            Dim BW As BinaryWriter
            Dim FS As FileStream
            Dim REnum As IEnumerator

            REnum = Farmacos.GetEnumerator
            Dim R As String
            FS = New FileStream(NombreBaseDatosMedicamentos, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()

            'modifica los arrays de subtipo si esta en ellos el farmaco
            If Tipo1.Contains(NombreAntiguo) = True Then
                Tipo1.Remove(NombreAntiguo)
                Tipo1.Add(NombreNuevo)
                Tipo1.Sort()
                REnum = Tipo1.GetEnumerator
                FS = New FileStream(Path & "\Tipo1.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo2.Contains(NombreAntiguo) = True Then
                Tipo2.Remove(NombreAntiguo)
                Tipo2.Add(NombreNuevo)
                Tipo2.Sort()
                REnum = Tipo2.GetEnumerator
                FS = New FileStream(Path & "\Tipo2.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo3.Contains(NombreAntiguo) = True Then
                Tipo3.Remove(NombreAntiguo)
                Tipo3.Add(NombreNuevo)
                Tipo3.Sort()
                REnum = Tipo3.GetEnumerator
                FS = New FileStream(Path & "\Tipo3.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo4.Contains(NombreAntiguo) = True Then
                Tipo4.Remove(NombreAntiguo)
                Tipo4.Add(NombreNuevo)
                Tipo4.Sort()
                REnum = Tipo4.GetEnumerator
                FS = New FileStream(Path & "\Tipo4.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo5.Contains(NombreAntiguo) = True Then
                Tipo5.Remove(NombreAntiguo)
                Tipo5.Add(NombreNuevo)
                Tipo5.Sort()
                REnum = Tipo5.GetEnumerator
                FS = New FileStream(Path & "\Tipo5.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo6.Contains(NombreAntiguo) = True Then
                Tipo6.Remove(NombreAntiguo)
                Tipo6.Add(NombreNuevo)
                Tipo6.Sort()
                REnum = Tipo6.GetEnumerator
                FS = New FileStream(Path & "\Tipo6.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo7.Contains(NombreAntiguo) = True Then
                Tipo7.Remove(NombreAntiguo)
                Tipo7.Add(NombreNuevo)
                Tipo7.Sort()
                REnum = Tipo7.GetEnumerator
                FS = New FileStream(Path & "\Tipo7.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo8.Contains(NombreAntiguo) = True Then
                Tipo8.Remove(NombreAntiguo)
                Tipo8.Add(NombreNuevo)
                Tipo8.Sort()
                REnum = Tipo8.GetEnumerator
                FS = New FileStream(Path & "\Tipo8.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo9.Contains(NombreAntiguo) = True Then
                Tipo9.Remove(NombreAntiguo)
                Tipo9.Add(NombreNuevo)
                Tipo9.Sort()
                REnum = Tipo9.GetEnumerator
                FS = New FileStream(Path & "\Tipo9.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo10.Contains(NombreAntiguo) = True Then
                Tipo10.Remove(NombreAntiguo)
                Tipo10.Add(NombreNuevo)
                Tipo10.Sort()
                REnum = Tipo10.GetEnumerator
                FS = New FileStream(Path & "\Tipo10.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo11.Contains(NombreAntiguo) = True Then
                Tipo11.Remove(NombreAntiguo)
                Tipo11.Add(NombreNuevo)
                Tipo11.Sort()
                REnum = Tipo11.GetEnumerator
                FS = New FileStream(Path & "\Tipo11.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo12.Contains(NombreAntiguo) = True Then
                Tipo12.Remove(NombreAntiguo)
                Tipo12.Add(NombreNuevo)
                Tipo12.Sort()
                REnum = Tipo12.GetEnumerator
                FS = New FileStream(Path & "\Tipo12.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo13.Contains(NombreAntiguo) = True Then
                Tipo13.Remove(NombreAntiguo)
                Tipo13.Add(NombreNuevo)
                Tipo13.Sort()
                REnum = Tipo13.GetEnumerator
                FS = New FileStream(Path & "\Tipo13.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo14.Contains(NombreAntiguo) = True Then
                Tipo14.Remove(NombreAntiguo)
                Tipo14.Add(NombreNuevo)
                Tipo14.Sort()
                REnum = Tipo14.GetEnumerator
                FS = New FileStream(Path & "\Tipo14.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo15.Contains(NombreAntiguo) = True Then
                Tipo15.Remove(NombreAntiguo)
                Tipo15.Add(NombreNuevo)
                Tipo15.Sort()
                REnum = Tipo15.GetEnumerator
                FS = New FileStream(Path & "\Tipo15.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo16.Contains(NombreAntiguo) = True Then
                Tipo16.Remove(NombreAntiguo)
                Tipo16.Add(NombreNuevo)
                Tipo16.Sort()
                REnum = Tipo16.GetEnumerator
                FS = New FileStream(Path & "\Tipo16.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo17.Contains(NombreAntiguo) = True Then
                Tipo17.Remove(NombreAntiguo)
                Tipo17.Add(NombreNuevo)
                Tipo17.Sort()
                REnum = Tipo17.GetEnumerator
                FS = New FileStream(Path & "\Tipo17.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            If Tipo18.Contains(NombreAntiguo) = True Then
                Tipo18.Remove(NombreAntiguo)
                Tipo18.Add(NombreNuevo)
                Tipo18.Sort()
                REnum = Tipo18.GetEnumerator
                FS = New FileStream(Path & "\Tipo18.bds", FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BW.Write(R)
                End While
                FS.Close()
                BW.Close()
            End If

            NombreAntiguo = Path & "\" & NombreAntiguo & ".far"
            NombreNuevo = Path & "\" & NombreNuevo & ".far"

            File.Copy(NombreAntiguo, NombreNuevo)
            File.Delete(NombreAntiguo)

            MuestraContenidoBaseDatos()

        Else
            'se cancelo y no se introdujo nada nuevo
        End If

    End Sub

    Private Sub botEliminaMedicamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEliminaMedicamento.Click
        Dim reply As MsgBoxResult
        reply = MsgBox("¿Deseas eliminar el fármaco seleccionado?", MsgBoxStyle.YesNo, "Confirma la Eliminación del Fármaco")
        If reply = MsgBoxResult.Yes Then
            EliminaFarmaco()
        End If
    End Sub

    Private Sub EliminaFarmaco()

        'elimina farmaco del arraylist
        Dim FarmacoEliminado As String
        FarmacoEliminado = MedicamentoResaltado
        Farmacos.Remove(FarmacoEliminado)
        Farmacos.Sort()

        'escribe al disco el contenido de la base de datos sin el farmaco eliminado
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim REnum As IEnumerator

        REnum = Farmacos.GetEnumerator
        Dim R As String
        FS = New FileStream(NombreBaseDatosMedicamentos, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        While REnum.MoveNext
            R = CType(REnum.Current, String)
            BW.Write(R)
        End While
        FS.Close()
        BW.Close()

        'modifica los arrays de subtipo si esta en ellos el farmaco
        If Tipo1.Contains(FarmacoEliminado) = True Then
            Tipo1.Remove(FarmacoEliminado)
            Tipo1.Sort()
            REnum = Tipo1.GetEnumerator
            FS = New FileStream(Path & "\Tipo1.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo2.Contains(FarmacoEliminado) = True Then
            Tipo2.Remove(FarmacoEliminado)
            Tipo2.Sort()
            REnum = Tipo2.GetEnumerator
            FS = New FileStream(Path & "\Tipo2.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo3.Contains(FarmacoEliminado) = True Then
            Tipo3.Remove(FarmacoEliminado)
            Tipo3.Sort()
            REnum = Tipo3.GetEnumerator
            FS = New FileStream(Path & "\Tipo3.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo4.Contains(FarmacoEliminado) = True Then
            Tipo4.Remove(FarmacoEliminado)
            Tipo4.Sort()
            REnum = Tipo4.GetEnumerator
            FS = New FileStream(Path & "\Tipo4.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo5.Contains(FarmacoEliminado) = True Then
            Tipo5.Remove(FarmacoEliminado)
            Tipo5.Sort()
            REnum = Tipo5.GetEnumerator
            FS = New FileStream(Path & "\Tipo5.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo6.Contains(FarmacoEliminado) = True Then
            Tipo6.Remove(FarmacoEliminado)
            Tipo6.Sort()
            REnum = Tipo6.GetEnumerator
            FS = New FileStream(Path & "\Tipo6.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo7.Contains(FarmacoEliminado) = True Then
            Tipo7.Remove(FarmacoEliminado)
            Tipo7.Sort()
            REnum = Tipo7.GetEnumerator
            FS = New FileStream(Path & "\Tipo7.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo8.Contains(FarmacoEliminado) = True Then
            Tipo8.Remove(FarmacoEliminado)
            Tipo8.Sort()
            REnum = Tipo8.GetEnumerator
            FS = New FileStream(Path & "\Tipo8.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo9.Contains(FarmacoEliminado) = True Then
            Tipo9.Remove(FarmacoEliminado)
            Tipo9.Sort()
            REnum = Tipo9.GetEnumerator
            FS = New FileStream(Path & "\Tipo9.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo10.Contains(FarmacoEliminado) = True Then
            Tipo10.Remove(FarmacoEliminado)
            Tipo10.Sort()
            REnum = Tipo10.GetEnumerator
            FS = New FileStream(Path & "\Tipo10.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo11.Contains(FarmacoEliminado) = True Then
            Tipo11.Remove(FarmacoEliminado)
            Tipo11.Sort()
            REnum = Tipo11.GetEnumerator
            FS = New FileStream(Path & "\Tipo11.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo12.Contains(FarmacoEliminado) = True Then
            Tipo12.Remove(FarmacoEliminado)
            Tipo12.Sort()
            REnum = Tipo12.GetEnumerator
            FS = New FileStream(Path & "\Tipo12.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo13.Contains(FarmacoEliminado) = True Then
            Tipo13.Remove(FarmacoEliminado)
            Tipo13.Sort()
            REnum = Tipo13.GetEnumerator
            FS = New FileStream(Path & "\Tipo13.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo14.Contains(FarmacoEliminado) = True Then
            Tipo14.Remove(FarmacoEliminado)
            Tipo14.Sort()
            REnum = Tipo14.GetEnumerator
            FS = New FileStream(Path & "\Tipo14.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo15.Contains(FarmacoEliminado) = True Then
            Tipo15.Remove(FarmacoEliminado)
            Tipo15.Sort()
            REnum = Tipo15.GetEnumerator
            FS = New FileStream(Path & "\Tipo15.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo16.Contains(FarmacoEliminado) = True Then
            Tipo16.Remove(FarmacoEliminado)
            Tipo16.Sort()
            REnum = Tipo16.GetEnumerator
            FS = New FileStream(Path & "\Tipo16.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo17.Contains(FarmacoEliminado) = True Then
            Tipo17.Remove(FarmacoEliminado)
            Tipo17.Sort()
            REnum = Tipo17.GetEnumerator
            FS = New FileStream(Path & "\Tipo17.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        If Tipo18.Contains(FarmacoEliminado) = True Then
            Tipo18.Remove(FarmacoEliminado)
            Tipo18.Sort()
            REnum = Tipo18.GetEnumerator
            FS = New FileStream(Path & "\Tipo18.bds", FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            While REnum.MoveNext
                R = CType(REnum.Current, String)
                BW.Write(R)
            End While
            FS.Close()
            BW.Close()
        End If

        'elimina el archivo del farmaco del disco
        NombreArchivoFarmaco = Path & "\" & MedicamentoResaltado & ".far"
        File.Delete(NombreArchivoFarmaco)

        'muestra el contenido de la base de datos actualizada
        MuestraContenidoBaseDatos()

        'borra el cuadro de descripcion de medicamento
        txtDescripcion.Text = ""

        'da foco al cuadro de busqueda
        txtBuscaMedicamento.Focus()

    End Sub

    Private Sub MostrarMedicamento()
        Dim DLG As New FormEditarMedicamento()

        NombreFarmaco = MedicamentoResaltado
        NombreArchivoFarmaco = Path & "\" & NombreFarmaco & ".far"
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'revisar si hay cambios para actualizar los datos
        Else
            'se salio cancelando
        End If
    End Sub

    Private Sub botMostrarMedicamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botMostrarMedicamento.Click
        MostrarMedicamento()
    End Sub

    Private Sub txtBuscamedicamento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscaMedicamento.TextChanged
        Dim LargoNuevo As Integer

        LargoNuevo = txtBuscaMedicamento.Text.Length

        If LargoNuevo > 0 Then
            'se introdujo algo es decir hay que filtrar segun el contenido
            Filtro = True
            MuestraContenidoBaseDatos()
        Else
            'no se ha introducido nada sale la lista completa
            Filtro = False
            MuestraContenidoBaseDatos()
        End If


    End Sub

    Private Sub txtbuscamedicamento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscaMedicamento.KeyPress
        Dim c As Char
        c = e.KeyChar

        If txtBuscaMedicamento.Text.Length > 48 Then
            If Not Char.IsControl(c) Then
                e.Handled = True
                Exit Sub
            End If
        End If

    End Sub

    Private Sub botCreaBaseDatos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotCreaBaseDatos.MouseEnter
        BotCreaBaseDatos.Image = BotonOnGrande
    End Sub
    Private Sub botCreaBaseDatos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotCreaBaseDatos.MouseLeave
        BotCreaBaseDatos.Image = BotonOffGrande
    End Sub

    Private Sub botAbreBaseDatos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotAbreBaseDatos.MouseEnter
        BotAbreBaseDatos.Image = BotonOnGrande
    End Sub
    Private Sub botAbreBaseDatos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotAbreBaseDatos.MouseLeave
        BotAbreBaseDatos.Image = BotonOffGrande
    End Sub

    Private Sub botNuevoMedicamento_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botNuevoMedicamento.MouseEnter
        botNuevoMedicamento.Image = BotonOn
    End Sub
    Private Sub botNuevoMedicamento_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botNuevoMedicamento.MouseLeave
        botNuevoMedicamento.Image = BotonOff
    End Sub

    Private Sub botrenombramedicamento_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRenombraMedicamento.MouseEnter
        botRenombraMedicamento.Image = BotonOn
    End Sub
    Private Sub botrenombramedicamento_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRenombraMedicamento.MouseLeave
        botRenombraMedicamento.Image = BotonOff
    End Sub

    Private Sub botMostrarMedicamento_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botMostrarMedicamento.MouseEnter
        botMostrarMedicamento.Image = BotonOn
    End Sub
    Private Sub botMostrarMedicamento_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botMostrarMedicamento.MouseLeave
        botMostrarMedicamento.Image = BotonOff
    End Sub

    Private Sub botEliminaMedicamento_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEliminaMedicamento.MouseEnter
        botEliminaMedicamento.Image = BotonOn
    End Sub
    Private Sub botEliminaMedicamento_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEliminaMedicamento.MouseLeave
        botEliminaMedicamento.Image = BotonOff
    End Sub



End Class
