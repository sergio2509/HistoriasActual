Imports System.IO

Public Class formRespaldo
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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LabHoraAcceso As System.Windows.Forms.Label
    Friend WithEvents labDir As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents labBase As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents botRespaldar As System.Windows.Forms.Button
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.labDir = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LabHoraAcceso = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labBase = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.botRespaldar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'botCancelar
        '
        Me.botCancelar.Location = New System.Drawing.Point(672, 432)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(96, 23)
        Me.botCancelar.TabIndex = 0
        Me.botCancelar.Text = "Cancelar"
        '
        'labDir
        '
        Me.labDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDir.Location = New System.Drawing.Point(104, 48)
        Me.labDir.Name = "labDir"
        Me.labDir.Size = New System.Drawing.Size(464, 23)
        Me.labDir.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(16, 112)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(648, 342)
        Me.ListBox1.TabIndex = 2
        '
        'LabHoraAcceso
        '
        Me.LabHoraAcceso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabHoraAcceso.Location = New System.Drawing.Point(672, 16)
        Me.LabHoraAcceso.Name = "LabHoraAcceso"
        Me.LabHoraAcceso.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Directorio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Base de Datos:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labBase
        '
        Me.labBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labBase.Location = New System.Drawing.Point(104, 16)
        Me.labBase.Name = "labBase"
        Me.labBase.Size = New System.Drawing.Size(464, 23)
        Me.labBase.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(576, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hora de Acceso:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Archivos y Directorios Creados o Modificados:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botRespaldar
        '
        Me.botRespaldar.Location = New System.Drawing.Point(672, 400)
        Me.botRespaldar.Name = "botRespaldar"
        Me.botRespaldar.Size = New System.Drawing.Size(96, 23)
        Me.botRespaldar.TabIndex = 11
        Me.botRespaldar.Text = "Respaldar Datos"
        '
        'formRespaldo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(778, 472)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.botRespaldar, Me.Label4, Me.Label1, Me.labBase, Me.Label3, Me.Label2, Me.LabHoraAcceso, Me.ListBox1, Me.labDir, Me.botCancelar})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "formRespaldo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Respaldo de Datos a Disco a:"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim SubDir() As String
    Dim Archivos() As String
    Dim NumerodeSubdirectorios As Integer
    Dim NumerodeArchivos As Integer
    Dim x, y As Integer
    Dim UltimaEscritura As Date

    '´nuevas variables para los directorios a crear
    Dim NombrePrincipal As String
    Dim DirectorioPrincipal As String
    Dim ArraydeSubDirDeNumero As New ArrayList()
    Dim ArraydeArchivos As New ArrayList()
    Dim NumerodeLetras As Integer
    Dim LargoNombre As Integer

    Structure DirectoriosaCopiar
        Dim DirectorioViejo As String
        Dim DirectorioNuevo As String
    End Structure
    Dim ParejaDirectorios As DirectoriosaCopiar

    Structure ArchivosaCopiar
        Dim ArchivoViejo As String
        Dim ArchivoNuevo As String
    End Structure
    Dim ParejaArchivos As ArchivosaCopiar

    Dim Cadena As String
    Dim ContadorDirectorios As Integer
    Dim ContadorArchivos As Integer
    Dim CambioArchivoHIS As Boolean

    Dim t As Integer
    Dim C As Char

    Private Sub formRespaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        'ListBox2.Items.Clear()
        ArraydeArchivos.Clear()
        ArraydeSubDirDeNumero.Clear()
        ContadorDirectorios = -1
        ContadorArchivos = -1
        CambioArchivoHIS = False

        'basemodificada y dirbasemodificada se construyen cuando se crea o se abre una base de datos en su evento click
        'horadeaccesoalabase se calcula tambien en ese momento en form1

        'crea el nombre principal del respaldo de la base en a:
        labBase.Text = Form1.BaseModificada
        NumerodeLetras = labBase.Text.Length
        LargoNombre = 0
        For Me.t = (NumerodeLetras - 1) To 0 Step -1
            C = labBase.Text.Chars(t)
            If C <> "\" Then
                LargoNombre += 1
            Else
                Exit For 'repite hasta que se encuentra un \ y ve cuantos caracteres son
            End If
        Next
        NombrePrincipal = "a:\" & labBase.Text.Remove(0, NumerodeLetras - LargoNombre)

        'contruye el nombre del directorio principal en A:
        labDir.Text = Form1.DirBaseModificada
        NumerodeLetras = labDir.Text.Length
        LargoNombre = 0
        For Me.t = (NumerodeLetras - 1) To 0 Step -1
            C = labDir.Text.Chars(t)
            If C <> "\" Then
                LargoNombre += 1
            Else
                Exit For
            End If
        Next
        DirectorioPrincipal = "a:\" & labDir.Text.Remove(0, NumerodeLetras - LargoNombre)

        'obtiene la hora de acceso a la base de datos para comparar modificaciones
        LabHoraAcceso.Text = Form1.HoraDeAccesoaLaBase.ToLongTimeString

        'revisa si lo que cambio fue el archivo principal de la base de datos
        UltimaEscritura = File.GetLastWriteTime(Form1.BaseModificada)
        If UltimaEscritura > Form1.HoraDeAccesoaLaBase Then
            CambioArchivoHIS = True
        End If

        'obtiene los subdirectorios y verifica cuales cambiaron
        NumerodeSubdirectorios = (Directory.GetDirectories(Form1.DirBaseModificada).GetLength(0)) - 1
        ReDim SubDir(NumerodeSubdirectorios)
        SubDir = Directory.GetDirectories(Form1.DirBaseModificada)

        Dim SeAñadioSubDir As Boolean
        SeAñadioSubDir = False
        For Me.x = 0 To NumerodeSubdirectorios
            UltimaEscritura = Directory.GetLastWriteTime(SubDir(x))
            If UltimaEscritura > Form1.HoraDeAccesoaLaBase Then
                NumerodeLetras = SubDir(x).Length
                LargoNombre = 0
                For Me.t = (NumerodeLetras - 1) To 0 Step -1
                    C = SubDir(x).Chars(t)
                    If C <> "\" Then
                        LargoNombre += 1
                    Else
                        Exit For
                    End If
                Next
                Cadena = DirectorioPrincipal & "\" & SubDir(x).Remove(0, NumerodeLetras - LargoNombre)
                ParejaDirectorios = Nothing
                ParejaDirectorios.DirectorioViejo = SubDir(x)
                ParejaDirectorios.DirectorioNuevo = Cadena
                ArraydeSubDirDeNumero.Add(ParejaDirectorios)
                ContadorDirectorios += 1
                SeAñadioSubDir = True
            End If

            NumerodeArchivos = ((Directory.GetFiles(SubDir(x))).GetLength(0)) - 1
            ReDim Archivos(NumerodeArchivos)
            Archivos = Directory.GetFiles(SubDir(x))
            For Me.y = 0 To NumerodeArchivos
                UltimaEscritura = Directory.GetLastWriteTime(Archivos(y))
                If UltimaEscritura > Form1.HoraDeAccesoaLaBase Then
                    'verifica si ya se añadio el subdir donde esta este archivo
                    If SeAñadioSubDir = False Then
                        'si no se ha añadido, aunque no haya cambiado hay que ponerlo para poder escribir
                        'el archivo modificado, lo añade
                        NumerodeLetras = SubDir(x).Length
                        LargoNombre = 0
                        For Me.t = (NumerodeLetras - 1) To 0 Step -1
                            C = SubDir(x).Chars(t)
                            If C <> "\" Then
                                LargoNombre += 1
                            Else
                                Exit For
                            End If
                        Next
                        Cadena = DirectorioPrincipal & "\" & SubDir(x).Remove(0, NumerodeLetras - LargoNombre)
                        ParejaDirectorios = Nothing
                        ParejaDirectorios.DirectorioViejo = SubDir(x)
                        ParejaDirectorios.DirectorioNuevo = Cadena
                        ArraydeSubDirDeNumero.Add(ParejaDirectorios)
                        ContadorDirectorios += 1
                        SeAñadioSubDir = True
                    End If
                    'despues de añadir el directorio donde esta en caso de que no haya caqmbiado se añade el
                    'archivo propiamente dicho
                    NumerodeLetras = Archivos(y).Length
                    LargoNombre = 0
                    For Me.t = (NumerodeLetras - 1) To 0 Step -1
                        C = Archivos(y).Chars(t)
                        If C <> "\" Then
                            LargoNombre += 1
                        Else
                            Exit For
                        End If
                    Next
                    Dim nombrearchivo As String
                    nombrearchivo = Cadena & "\" & Archivos(y).Remove(0, NumerodeLetras - LargoNombre)

                    ParejaArchivos = Nothing
                    ParejaArchivos.ArchivoViejo = Archivos(y)
                    ParejaArchivos.ArchivoNuevo = nombrearchivo
                    ArraydeArchivos.Add(ParejaArchivos)
                    ContadorArchivos += 1
                End If

            Next
        Next

        'si no hay nada que respaldar apaga el boton correspondiente y lo informa
        If CambioArchivoHIS = False And ContadorArchivos = -1 And ContadorDirectorios = -1 Then
            ListBox1.Items.Add("Actualmente no se ha MODIFICADO ni CREADO ningún Archivo o directorio...")
            botRespaldar.Enabled = False
            Exit Sub
        End If

        'Visualizacion de datos a modificar

        'Nombre de la base a respaldar
        If CambioArchivoHIS = True Then
            ListBox1.Items.Add("Archivo Principal de la Base de datos:")
            ListBox1.Items.Add("======================================")
            ListBox1.Items.Add(Form1.BaseModificada)
        End If

        'Directorio principal y Subdirectorios de la base de datos a respaldar
        If ContadorDirectorios >= 0 Then

            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("Directorio Principal de la Base de datos:")
            ListBox1.Items.Add("======================================")
            ListBox1.Items.Add(Form1.DirBaseModificada)

            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("Sub Directorios de la Base de datos:")
            ListBox1.Items.Add("======================================")
            For Me.t = 0 To ContadorDirectorios
                ParejaDirectorios = Nothing
                ParejaDirectorios = ArraydeSubDirDeNumero(t)
                ListBox1.Items.Add(ParejaDirectorios.DirectorioViejo)
            Next
        End If

        'muestra los archivos modificados
        If ContadorArchivos >= 0 Then
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("Archivos de Datos de Pacientes:")
            ListBox1.Items.Add("======================================")
            For Me.t = 0 To ContadorArchivos
                ParejaArchivos = Nothing
                ParejaArchivos = ArraydeArchivos(t)
                ListBox1.Items.Add(ParejaArchivos.ArchivoViejo)
            Next
        End If



    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub botRespaldar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRespaldar.Click

        Dim ExistenDirectorios, ExistenArchivos As Boolean
        'Dim Respuesta As MsgBoxResult

        If Directory.Exists("a:\") Then
            NumerodeSubdirectorios = (Directory.GetDirectories("a:\").GetLength(0)) - 1
            If NumerodeSubdirectorios >= 0 Then
                ExistenDirectorios = True
                'ReDim SubDir(NumerodeSubdirectorios)
                'SubDir = Directory.GetDirectories("a:\")
                'For t = 0 To NumerodeSubdirectorios
                'ListBox1.Items.Add(SubDir(t))
                'Next
            Else
                'no hay subdirectorios en a:
                ExistenDirectorios = False
            End If

            NumerodeArchivos = (Directory.GetFiles("a:\").GetLength(0)) - 1
            If NumerodeArchivos >= 0 Then
                ExistenArchivos = True
                'ReDim Archivos(NumerodeArchivos)
                'Archivos = Directory.GetFiles("a:\")
                'For t = 0 To NumerodeArchivos
                'ListBox1.Items.Add(Archivos(t))
                'Next
            Else
                'no hay archivos
                ExistenArchivos = False
            End If

            If ExistenDirectorios = False And ExistenArchivos = False Then
                'el disco esta vacio y formateado, respalda sin problemas
                File.Copy(Form1.BaseModificada, NombrePrincipal)
                Directory.CreateDirectory(DirectorioPrincipal)

                For Me.t = 0 To ContadorDirectorios
                    ParejaDirectorios = Nothing
                    ParejaDirectorios = ArraydeSubDirDeNumero(t)
                    Directory.CreateDirectory(ParejaDirectorios.DirectorioNuevo)
                Next

                For Me.t = 0 To ContadorArchivos
                    ParejaArchivos = Nothing
                    ParejaArchivos = ArraydeArchivos(t)
                    File.Copy(ParejaArchivos.ArchivoViejo, ParejaArchivos.ArchivoNuevo)
                Next
                'pone en falso la bandera de se modificaron los datos ya que se respaldaron
                Form1.SeModificaronDatos = False
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else

                MsgBox("El disco introducido no está vacío. Elimina todos los Archivos primero...", MsgBoxStyle.Exclamation)
                Exit Sub
                'If Respuesta = MsgBoxResult.Yes Then
                'borra los archivos
                'If ExistenArchivos Then
                '    For t = 0 To NumerodeArchivos
                'File.Delete(Archivos(t))
                '    Next
                'End If
                'If ExistenDirectorios Then
                'For t = 0 To NumerodeSubdirectorios
                '     Directory.Delete(SubDir(t), True)
                ' Next
                'End If
                'respalda los datos 

                'Me.DialogResult = DialogResult.OK
                'Else
                'se cancelo el respaldo sale del procedimiento
                'Me.DialogResult = DialogResult.Abort
                'End If
            End If

        Else
            MsgBox("Por favor introduce un Diskette formateado y vacío en A:", MsgBoxStyle.Information)
        End If
    End Sub
End Class
