Imports System.IO

Public Class FormEditarMedicamento
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
    Friend WithEvents LabMedicamentoAbierto As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents botGuardaCambios As System.Windows.Forms.Button
    Friend WithEvents botDescartaDatos As System.Windows.Forms.Button
    Friend WithEvents txtDosificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtIndicaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chk18 As System.Windows.Forms.CheckBox
    Friend WithEvents chk17 As System.Windows.Forms.CheckBox
    Friend WithEvents chk16 As System.Windows.Forms.CheckBox
    Friend WithEvents chk15 As System.Windows.Forms.CheckBox
    Friend WithEvents chk14 As System.Windows.Forms.CheckBox
    Friend WithEvents chk13 As System.Windows.Forms.CheckBox
    Friend WithEvents chk12 As System.Windows.Forms.CheckBox
    Friend WithEvents chk11 As System.Windows.Forms.CheckBox
    Friend WithEvents chk10 As System.Windows.Forms.CheckBox
    Friend WithEvents chk08 As System.Windows.Forms.CheckBox
    Friend WithEvents chk07 As System.Windows.Forms.CheckBox
    Friend WithEvents chk06 As System.Windows.Forms.CheckBox
    Friend WithEvents chk04 As System.Windows.Forms.CheckBox
    Friend WithEvents chk02 As System.Windows.Forms.CheckBox
    Friend WithEvents chk01 As System.Windows.Forms.CheckBox
    Friend WithEvents chk05 As System.Windows.Forms.CheckBox
    Friend WithEvents chk09 As System.Windows.Forms.CheckBox
    Friend WithEvents chk03 As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormEditarMedicamento))
        Me.LabMedicamentoAbierto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk18 = New System.Windows.Forms.CheckBox()
        Me.chk17 = New System.Windows.Forms.CheckBox()
        Me.chk16 = New System.Windows.Forms.CheckBox()
        Me.chk15 = New System.Windows.Forms.CheckBox()
        Me.chk14 = New System.Windows.Forms.CheckBox()
        Me.chk13 = New System.Windows.Forms.CheckBox()
        Me.chk12 = New System.Windows.Forms.CheckBox()
        Me.chk11 = New System.Windows.Forms.CheckBox()
        Me.chk10 = New System.Windows.Forms.CheckBox()
        Me.chk08 = New System.Windows.Forms.CheckBox()
        Me.chk07 = New System.Windows.Forms.CheckBox()
        Me.chk06 = New System.Windows.Forms.CheckBox()
        Me.chk04 = New System.Windows.Forms.CheckBox()
        Me.chk02 = New System.Windows.Forms.CheckBox()
        Me.chk01 = New System.Windows.Forms.CheckBox()
        Me.chk05 = New System.Windows.Forms.CheckBox()
        Me.chk09 = New System.Windows.Forms.CheckBox()
        Me.chk03 = New System.Windows.Forms.CheckBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPresentacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIndicaciones = New System.Windows.Forms.TextBox()
        Me.txtDosificacion = New System.Windows.Forms.TextBox()
        Me.botDescartaDatos = New System.Windows.Forms.Button()
        Me.botGuardaCambios = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabMedicamentoAbierto
        '
        Me.LabMedicamentoAbierto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMedicamentoAbierto.ForeColor = System.Drawing.Color.White
        Me.LabMedicamentoAbierto.Image = CType(resources.GetObject("LabMedicamentoAbierto.Image"), System.Drawing.Bitmap)
        Me.LabMedicamentoAbierto.Location = New System.Drawing.Point(88, 8)
        Me.LabMedicamentoAbierto.Name = "LabMedicamentoAbierto"
        Me.LabMedicamentoAbierto.Size = New System.Drawing.Size(440, 23)
        Me.LabMedicamentoAbierto.TabIndex = 1
        Me.LabMedicamentoAbierto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Medicamento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtNombre, Me.Label11, Me.Label3, Me.chk18, Me.chk17, Me.chk16, Me.chk15, Me.chk14, Me.chk13, Me.chk12, Me.chk11, Me.chk10, Me.chk08, Me.chk07, Me.chk06, Me.chk04, Me.chk02, Me.chk01, Me.chk05, Me.chk09, Me.chk03, Me.txtDescripcion, Me.Label2, Me.txtPresentacion, Me.Label10, Me.Label9, Me.Label8, Me.txtCantidad, Me.Label6, Me.Label5, Me.Label4, Me.Label7, Me.txtIndicaciones, Me.txtDosificacion})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 440)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(88, 16)
        Me.txtNombre.MaxLength = 75
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(320, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nombre"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tipo de medicamento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk18
        '
        Me.chk18.Location = New System.Drawing.Point(512, 408)
        Me.chk18.Name = "chk18"
        Me.chk18.Size = New System.Drawing.Size(240, 24)
        Me.chk18.TabIndex = 33
        Me.chk18.Text = "Otros-Varios"
        '
        'chk17
        '
        Me.chk17.Location = New System.Drawing.Point(512, 388)
        Me.chk17.Name = "chk17"
        Me.chk17.Size = New System.Drawing.Size(240, 24)
        Me.chk17.TabIndex = 32
        Me.chk17.Text = "Vitaminas y Oligoelementos"
        '
        'chk16
        '
        Me.chk16.Location = New System.Drawing.Point(512, 368)
        Me.chk16.Name = "chk16"
        Me.chk16.Size = New System.Drawing.Size(240, 24)
        Me.chk16.TabIndex = 31
        Me.chk16.Text = "Utero Inhibidores y Utero Tónicos"
        '
        'chk15
        '
        Me.chk15.Location = New System.Drawing.Point(512, 348)
        Me.chk15.Name = "chk15"
        Me.chk15.Size = New System.Drawing.Size(240, 24)
        Me.chk15.TabIndex = 30
        Me.chk15.Text = "Hormonas"
        '
        'chk14
        '
        Me.chk14.Location = New System.Drawing.Point(512, 328)
        Me.chk14.Name = "chk14"
        Me.chk14.Size = New System.Drawing.Size(240, 24)
        Me.chk14.TabIndex = 29
        Me.chk14.Text = "Hipotensor"
        '
        'chk13
        '
        Me.chk13.Location = New System.Drawing.Point(512, 308)
        Me.chk13.Name = "chk13"
        Me.chk13.Size = New System.Drawing.Size(240, 24)
        Me.chk13.TabIndex = 28
        Me.chk13.Text = "Hemostatico coagulante"
        '
        'chk12
        '
        Me.chk12.Location = New System.Drawing.Point(264, 408)
        Me.chk12.Name = "chk12"
        Me.chk12.Size = New System.Drawing.Size(240, 24)
        Me.chk12.TabIndex = 27
        Me.chk12.Text = "Antitrombótico"
        '
        'chk11
        '
        Me.chk11.Location = New System.Drawing.Point(264, 388)
        Me.chk11.Name = "chk11"
        Me.chk11.Size = New System.Drawing.Size(240, 24)
        Me.chk11.TabIndex = 26
        Me.chk11.Text = "Antiseptico y Analgésico de vías urinarias"
        '
        'chk10
        '
        Me.chk10.Location = New System.Drawing.Point(264, 368)
        Me.chk10.Name = "chk10"
        Me.chk10.Size = New System.Drawing.Size(240, 24)
        Me.chk10.TabIndex = 25
        Me.chk10.Text = "Antiparasitario"
        '
        'chk08
        '
        Me.chk08.Location = New System.Drawing.Point(264, 308)
        Me.chk08.Name = "chk08"
        Me.chk08.Size = New System.Drawing.Size(240, 24)
        Me.chk08.TabIndex = 22
        Me.chk08.Text = "Antibiótico"
        '
        'chk07
        '
        Me.chk07.Location = New System.Drawing.Point(264, 348)
        Me.chk07.Name = "chk07"
        Me.chk07.Size = New System.Drawing.Size(240, 24)
        Me.chk07.TabIndex = 24
        Me.chk07.Text = "Antimicótico"
        '
        'chk06
        '
        Me.chk06.Location = New System.Drawing.Point(16, 408)
        Me.chk06.Name = "chk06"
        Me.chk06.Size = New System.Drawing.Size(240, 24)
        Me.chk06.TabIndex = 21
        Me.chk06.Text = "Antianémico"
        '
        'chk04
        '
        Me.chk04.Location = New System.Drawing.Point(16, 368)
        Me.chk04.Name = "chk04"
        Me.chk04.Size = New System.Drawing.Size(240, 24)
        Me.chk04.TabIndex = 19
        Me.chk04.Text = "Antialérgico"
        '
        'chk02
        '
        Me.chk02.Location = New System.Drawing.Point(16, 328)
        Me.chk02.Name = "chk02"
        Me.chk02.Size = New System.Drawing.Size(240, 24)
        Me.chk02.TabIndex = 17
        Me.chk02.Text = "Afecciones vaginales y uretrales"
        '
        'chk01
        '
        Me.chk01.Location = New System.Drawing.Point(16, 308)
        Me.chk01.Name = "chk01"
        Me.chk01.Size = New System.Drawing.Size(240, 24)
        Me.chk01.TabIndex = 16
        Me.chk01.Text = "Afecciones cutáneas"
        '
        'chk05
        '
        Me.chk05.Location = New System.Drawing.Point(16, 388)
        Me.chk05.Name = "chk05"
        Me.chk05.Size = New System.Drawing.Size(240, 24)
        Me.chk05.TabIndex = 20
        Me.chk05.Text = "Antiácido Antiflatulento"
        '
        'chk09
        '
        Me.chk09.Location = New System.Drawing.Point(264, 328)
        Me.chk09.Name = "chk09"
        Me.chk09.Size = New System.Drawing.Size(240, 24)
        Me.chk09.TabIndex = 23
        Me.chk09.Text = "Antiemético"
        '
        'chk03
        '
        Me.chk03.Location = New System.Drawing.Point(16, 348)
        Me.chk03.Name = "chk03"
        Me.chk03.Size = New System.Drawing.Size(240, 24)
        Me.chk03.TabIndex = 18
        Me.chk03.Text = "Analgésico Antipirético Antiespasmódico"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(8, 216)
        Me.txtDescripcion.MaxLength = 1024
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(752, 68)
        Me.txtDescripcion.TabIndex = 14
        Me.txtDescripcion.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripción del Medicamento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPresentacion
        '
        Me.txtPresentacion.Location = New System.Drawing.Point(8, 72)
        Me.txtPresentacion.MaxLength = 40
        Me.txtPresentacion.Name = "txtPresentacion"
        Me.txtPresentacion.Size = New System.Drawing.Size(184, 20)
        Me.txtPresentacion.TabIndex = 4
        Me.txtPresentacion.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(632, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "p.e: Caja de 20 tabletas"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(344, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "p.e: 500 mg"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(120, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "p.e: Tabletas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(448, 72)
        Me.txtCantidad.MaxLength = 40
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(312, 20)
        Me.txtCantidad.TabIndex = 10
        Me.txtCantidad.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(448, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cantidad x Caja"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(216, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Dosificación x Unidad"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Presentación"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(256, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Indicaciones para la posología al Paciente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIndicaciones
        '
        Me.txtIndicaciones.Location = New System.Drawing.Point(8, 120)
        Me.txtIndicaciones.MaxLength = 1024
        Me.txtIndicaciones.Multiline = True
        Me.txtIndicaciones.Name = "txtIndicaciones"
        Me.txtIndicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIndicaciones.Size = New System.Drawing.Size(752, 68)
        Me.txtIndicaciones.TabIndex = 12
        Me.txtIndicaciones.Text = ""
        '
        'txtDosificacion
        '
        Me.txtDosificacion.Location = New System.Drawing.Point(216, 72)
        Me.txtDosificacion.MaxLength = 40
        Me.txtDosificacion.Name = "txtDosificacion"
        Me.txtDosificacion.Size = New System.Drawing.Size(208, 20)
        Me.txtDosificacion.TabIndex = 7
        Me.txtDosificacion.Text = ""
        '
        'botDescartaDatos
        '
        Me.botDescartaDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botDescartaDatos.Image = CType(resources.GetObject("botDescartaDatos.Image"), System.Drawing.Bitmap)
        Me.botDescartaDatos.Location = New System.Drawing.Point(16, 488)
        Me.botDescartaDatos.Name = "botDescartaDatos"
        Me.botDescartaDatos.Size = New System.Drawing.Size(224, 23)
        Me.botDescartaDatos.TabIndex = 3
        Me.botDescartaDatos.Text = "Salir"
        '
        'botGuardaCambios
        '
        Me.botGuardaCambios.Enabled = False
        Me.botGuardaCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botGuardaCambios.Image = CType(resources.GetObject("botGuardaCambios.Image"), System.Drawing.Bitmap)
        Me.botGuardaCambios.Location = New System.Drawing.Point(560, 488)
        Me.botGuardaCambios.Name = "botGuardaCambios"
        Me.botGuardaCambios.Size = New System.Drawing.Size(224, 23)
        Me.botGuardaCambios.TabIndex = 4
        Me.botGuardaCambios.Text = "Guarda Cambios"
        '
        'FormEditarMedicamento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(794, 520)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.Label1, Me.LabMedicamentoAbierto, Me.botDescartaDatos, Me.botGuardaCambios})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormEditarMedicamento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Introduce o Modifica datos del Fármaco"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FarmacoAbierto As String
    Dim NombreArchivoFarmaco As String

    'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image


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

    Private Sub FormEditarMedicamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        'carga la ventana
        FarmacoAbierto = FormMedicamentos.MedicamentoResaltado
        NombreArchivoFarmaco = FormMedicamentos.NombreArchivoFarmaco
        LabMedicamentoAbierto.Text = FarmacoAbierto
        LeeContenidoArchivo()
        botGuardaCambios.Enabled = False
        botDescartaDatos.Text = "Salir"
    End Sub

    Private Sub EscribeContenidoArchivo()
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim BWsub As BinaryWriter
        Dim FSsub As FileStream
        Dim REnum As IEnumerator
        Dim W As New DatosFarmaco()
        FS = New FileStream(NombreArchivoFarmaco, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        W.Nombre = txtNombre.Text
        W.Presentacion = txtPresentacion.Text
        W.Dosificacion = txtDosificacion.Text
        W.Cantidad = txtCantidad.Text
        W.Indicaciones = txtIndicaciones.Text
        W.Descripcion = txtDescripcion.Text

        If chk01.Checked = True Then
            W.Tipo1 = True
            Console.WriteLine("FarmacoAbierto: " & FarmacoAbierto)
            If FormMedicamentos.Tipo1.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
                Console.WriteLine("consiguio el farmaco en la subhistoria")
            Else
                'si no esta hay que añadirlo
                Console.WriteLine("no consiguio el farmaco en la subhistoria lo añade")
                FormMedicamentos.Tipo1.Add(FarmacoAbierto)
                FormMedicamentos.Tipo1.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo1.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo1.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo1 = False
            If FormMedicamentos.Tipo1.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo1.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo1.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo1.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo1.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk02.Checked = True Then
            W.Tipo2 = True
            If FormMedicamentos.Tipo2.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo2.Add(FarmacoAbierto)
                FormMedicamentos.Tipo2.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo2.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo2.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo2 = False
            If FormMedicamentos.Tipo2.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo2.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo2.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo2.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo2.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk03.Checked = True Then
            W.Tipo3 = True
            If FormMedicamentos.Tipo3.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo3.Add(FarmacoAbierto)
                FormMedicamentos.Tipo3.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo3.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo3.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo3 = False
            If FormMedicamentos.Tipo3.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo3.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo3.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo3.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo3.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk04.Checked = True Then
            W.Tipo4 = True
            If FormMedicamentos.Tipo4.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo4.Add(FarmacoAbierto)
                FormMedicamentos.Tipo4.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo4.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo4.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo4 = False
            If FormMedicamentos.Tipo4.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo4.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo4.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo4.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo4.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk05.Checked = True Then
            W.Tipo5 = True
            If FormMedicamentos.Tipo5.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo5.Add(FarmacoAbierto)
                FormMedicamentos.Tipo5.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo5.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo5.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo5 = False
            If FormMedicamentos.Tipo5.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo5.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo5.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo5.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo5.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk06.Checked = True Then
            W.Tipo6 = True
            If FormMedicamentos.Tipo6.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo6.Add(FarmacoAbierto)
                FormMedicamentos.Tipo6.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo6.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo6.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo6 = False
            If FormMedicamentos.Tipo6.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo6.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo6.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo6.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo6.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk07.Checked = True Then
            W.Tipo7 = True
            If FormMedicamentos.Tipo7.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo7.Add(FarmacoAbierto)
                FormMedicamentos.Tipo7.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo7.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo7.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo7 = False
            If FormMedicamentos.Tipo7.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo7.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo7.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo7.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo7.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk08.Checked = True Then
            W.Tipo8 = True
            If FormMedicamentos.Tipo8.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo8.Add(FarmacoAbierto)
                FormMedicamentos.Tipo8.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo8.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo8.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo8 = False
            If FormMedicamentos.Tipo8.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo8.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo8.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo8.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo8.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk09.Checked = True Then
            W.Tipo9 = True
            If FormMedicamentos.Tipo9.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo9.Add(FarmacoAbierto)
                FormMedicamentos.Tipo9.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo9.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo9.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo9 = False
            If FormMedicamentos.Tipo9.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo9.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo9.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo9.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo9.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk10.Checked = True Then
            W.Tipo10 = True
            If FormMedicamentos.Tipo10.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo10.Add(FarmacoAbierto)
                FormMedicamentos.Tipo10.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo10.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo10.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo10 = False
            If FormMedicamentos.Tipo10.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo10.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo10.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo10.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo10.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk11.Checked = True Then
            W.Tipo11 = True
            If FormMedicamentos.Tipo11.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo11.Add(FarmacoAbierto)
                FormMedicamentos.Tipo11.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo11.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo11.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo11 = False
            If FormMedicamentos.Tipo11.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo11.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo11.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo11.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo11.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk12.Checked = True Then
            W.Tipo12 = True
            If FormMedicamentos.Tipo12.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo12.Add(FarmacoAbierto)
                FormMedicamentos.Tipo12.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo12.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo12.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo12 = False
            If FormMedicamentos.Tipo12.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo12.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo12.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo12.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo12.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk13.Checked = True Then
            W.Tipo13 = True
            If FormMedicamentos.Tipo13.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo13.Add(FarmacoAbierto)
                FormMedicamentos.Tipo13.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo13.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo13.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo13 = False
            If FormMedicamentos.Tipo13.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo13.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo13.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo13.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo13.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk14.Checked = True Then
            W.Tipo14 = True
            If FormMedicamentos.Tipo14.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo14.Add(FarmacoAbierto)
                FormMedicamentos.Tipo14.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo14.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo14.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo14 = False
            If FormMedicamentos.Tipo14.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo14.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo14.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo14.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo14.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk15.Checked = True Then
            W.Tipo15 = True
            If FormMedicamentos.Tipo15.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo15.Add(FarmacoAbierto)
                FormMedicamentos.Tipo15.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo15.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo15.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo15 = False
            If FormMedicamentos.Tipo15.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo15.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo15.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo15.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo15.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk16.Checked = True Then
            W.Tipo16 = True
            If FormMedicamentos.Tipo16.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo16.Add(FarmacoAbierto)
                FormMedicamentos.Tipo16.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo16.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo16.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo16 = False
            If FormMedicamentos.Tipo16.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo16.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo16.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo16.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo16.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk17.Checked = True Then
            W.Tipo17 = True
            If FormMedicamentos.Tipo17.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo17.Add(FarmacoAbierto)
                FormMedicamentos.Tipo17.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo17.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo17.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo17 = False
            If FormMedicamentos.Tipo17.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo17.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo17.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo17.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo17.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        If chk18.Checked = True Then
            W.Tipo18 = True
            If FormMedicamentos.Tipo18.Contains(FarmacoAbierto) Then
                'deja todo igual ya que debe de estar
            Else
                'si no esta hay que añadirlo
                FormMedicamentos.Tipo18.Add(FarmacoAbierto)
                FormMedicamentos.Tipo18.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo18.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo18.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            End If

        Else
            W.Tipo18 = False
            If FormMedicamentos.Tipo18.Contains(FarmacoAbierto) Then
                'si lo contiene hay que borrarlo
                FormMedicamentos.Tipo18.Remove(FarmacoAbierto)
                FormMedicamentos.Tipo18.Sort()
                'pasa el contenido de la array list a la base de datos para actualizarla con el nuevo medicamento
                REnum = FormMedicamentos.Tipo18.GetEnumerator
                Dim R As String
                FSsub = New FileStream(FormMedicamentos.Path & "\Tipo18.bds", FileMode.Create, FileAccess.Write)
                BWsub = New BinaryWriter(FSsub)
                BWsub.BaseStream.Seek(0, SeekOrigin.Begin)
                While REnum.MoveNext
                    R = CType(REnum.Current, String)
                    BWsub.Write(R)
                End While
                FSsub.Close()
                BWsub.Close()
            Else
                'si no lo contiene deja todo igual
            End If
        End If

        BW.Write(W.Nombre)
        BW.Write(W.Presentacion)
        BW.Write(W.Dosificacion)
        BW.Write(W.Cantidad)
        BW.Write(W.Indicaciones)
        BW.Write(W.Descripcion)
        BW.Write(W.Tipo1)
        BW.Write(W.Tipo2)
        BW.Write(W.Tipo3)
        BW.Write(W.Tipo4)
        BW.Write(W.Tipo5)
        BW.Write(W.Tipo6)
        BW.Write(W.Tipo7)
        BW.Write(W.Tipo8)
        BW.Write(W.Tipo9)
        BW.Write(W.Tipo10)
        BW.Write(W.Tipo11)
        BW.Write(W.Tipo12)
        BW.Write(W.Tipo13)
        BW.Write(W.Tipo14)
        BW.Write(W.Tipo15)
        BW.Write(W.Tipo16)
        BW.Write(W.Tipo17)
        BW.Write(W.Tipo18)
        FS.Close()
        BW.Close()
    End Sub

    Private Sub LeeContenidoArchivo()
        Dim BR As BinaryReader
        Dim FS As FileStream
        FS = New FileStream(NombreArchivoFarmaco, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim H As New DatosFarmaco()
        Dim C As Integer

        Console.WriteLine("Private sub LeeContenido. accediendo al archivo: " & NombreArchivoFarmaco)
        C = BR.PeekChar

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

        'Muestra el contenido del archivo del farmaco
        txtNombre.Text = H.Nombre
        txtPresentacion.Text = H.Presentacion
        txtDosificacion.Text = H.Dosificacion
        txtCantidad.Text = H.Cantidad
        txtIndicaciones.Text = H.Indicaciones
        txtDescripcion.Text = H.Descripcion
        If H.Tipo1 = True Then
            chk01.Checked = True
        Else
            chk01.Checked = False
        End If
        If H.Tipo2 = True Then
            chk02.Checked = True
        Else
            chk02.Checked = False
        End If
        If H.Tipo3 = True Then
            chk03.Checked = True
        Else
            chk03.Checked = False
        End If
        If H.Tipo4 = True Then
            chk04.Checked = True
        Else
            chk04.Checked = False
        End If
        If H.Tipo5 = True Then
            chk05.Checked = True
        Else
            chk05.Checked = False
        End If
        If H.Tipo6 = True Then
            chk06.Checked = True
        Else
            chk06.Checked = False
        End If
        If H.Tipo7 = True Then
            chk07.Checked = True
        Else
            chk07.Checked = False
        End If
        If H.Tipo8 = True Then
            chk08.Checked = True
        Else
            chk08.Checked = False
        End If
        If H.Tipo9 = True Then
            chk09.Checked = True
        Else
            chk09.Checked = False
        End If
        If H.Tipo10 = True Then
            chk10.Checked = True
        Else
            chk10.Checked = False
        End If
        If H.Tipo11 = True Then
            chk11.Checked = True
        Else
            chk11.Checked = False
        End If
        If H.Tipo12 = True Then
            chk12.Checked = True
        Else
            chk12.Checked = False
        End If
        If H.Tipo13 = True Then
            chk13.Checked = True
        Else
            chk13.Checked = False
        End If
        If H.Tipo14 = True Then
            chk14.Checked = True
        Else
            chk14.Checked = False
        End If
        If H.Tipo15 = True Then
            chk15.Checked = True
        Else
            chk15.Checked = False
        End If
        If H.Tipo16 = True Then
            chk16.Checked = True
        Else
            chk16.Checked = False
        End If
        If H.Tipo17 = True Then
            chk17.Checked = True
        Else
            chk17.Checked = False
        End If
        If H.Tipo18 = True Then
            chk18.Checked = True
        Else
            chk18.Checked = False
        End If

    End Sub

    Private Sub botDescartaDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botDescartaDatos.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub botGuardaCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botGuardaCambios.Click
        EscribeContenidoArchivo()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub SeHanHechoCambios(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtPresentacion.TextChanged, txtDosificacion.TextChanged, txtCantidad.TextChanged, _
                txtIndicaciones.TextChanged, txtDescripcion.TextChanged, txtNombre.TextChanged

        botDescartaDatos.Text = "Descarta Cambios"
        botGuardaCambios.Enabled = True
    End Sub

    Private Sub SehanhechoCambios2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles chk18.CheckedChanged, chk17.CheckedChanged, chk16.CheckedChanged, chk15.CheckedChanged, _
                chk14.CheckedChanged, chk13.CheckedChanged, chk12.CheckedChanged, chk11.CheckedChanged, _
                chk10.CheckedChanged, chk08.CheckedChanged, chk07.CheckedChanged, chk06.CheckedChanged, _
                chk04.CheckedChanged, chk02.CheckedChanged, chk01.CheckedChanged, chk05.CheckedChanged, _
                chk09.CheckedChanged, chk03.CheckedChanged

        botDescartaDatos.Text = "Descarta Cambios"
        botGuardaCambios.Enabled = True
    End Sub

    'eventos del mouse sobre los botones
    Private Sub botGuardaCambios_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botGuardaCambios.MouseEnter
        botGuardaCambios.Image = BotonOnGrande
    End Sub
    Private Sub botGuardaCambios_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botGuardaCambios.MouseLeave
        botGuardaCambios.Image = BotonOffGrande
    End Sub

    Private Sub botDescartaDatos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botDescartaDatos.MouseEnter
        botDescartaDatos.Image = BotonOnGrande
    End Sub
    Private Sub botDescartaDatos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botDescartaDatos.MouseLeave
        botDescartaDatos.Image = BotonOffGrande
    End Sub

End Class
