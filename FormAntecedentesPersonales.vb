Imports System.IO

Public Class FormAntecedentesPersonales
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAntPersonales As System.Windows.Forms.TextBox
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAntPersonales = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'botCancelar
        '
        Me.botCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botCancelar.Location = New System.Drawing.Point(12, 637)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(152, 23)
        Me.botCancelar.TabIndex = 26
        Me.botCancelar.Text = "Cancelar"
        '
        'botAceptar
        '
        Me.botAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botAceptar.Location = New System.Drawing.Point(830, 637)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(152, 23)
        Me.botAceptar.TabIndex = 25
        Me.botAceptar.Text = "Aceptar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Resumen de los Antecedentes Personales"
        '
        'txtAntPersonales
        '
        Me.txtAntPersonales.Location = New System.Drawing.Point(15, 28)
        Me.txtAntPersonales.MaxLength = 2000
        Me.txtAntPersonales.Multiline = True
        Me.txtAntPersonales.Name = "txtAntPersonales"
        Me.txtAntPersonales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntPersonales.Size = New System.Drawing.Size(953, 152)
        Me.txtAntPersonales.TabIndex = 28
        '
        'FormAntecedentesPersonales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtAntPersonales)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botCancelar)
        Me.Controls.Add(Me.botAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormAntecedentesPersonales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antecedentes Personales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'VARIABLES DEL PROCEDIMIENTO
    Dim fileAntPersonales As String
 
    Structure TablaDeAntecedentesPersonales

        Dim a01strResumen As String

    End Structure

    Dim AP As TablaDeAntecedentesPersonales
    Dim booDatosModificados As Boolean

    Private Sub FormAntecedentesPersonales_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txtAntPersonales.Focus()
    End Sub

    Private Sub FormAntecedentesPersonales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Form1.PSbooConsultaAntecedentesPersonales = True Then

            'se esta accediendo para consultar los antedentes y regresar con los datos

            Form1.PSbooConsultaAntecedentesPersonales = False 'apaga la bandera

            'primero crea los nombres y pone todo en cero
            Inicializa()

            'ahora revisa si existe un archivo de antecedentes
            If File.Exists(fileAntPersonales) = True Then
                'existe un archivo lo carga y muestra
                'Carga el registro previo de antecedentes familiares
                CargaAntecedentesPersonales()
                'actualiza los Pantalla con la estructura
                ActualizaPantallaConLaEstructura()
                'inicio igual ahora construye con lo q tiene y cierrra 'traduce el texto en pantalla
                ConstruyeAntecedentes()
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else
                'no hay datos responde en blanco
                Form1.PSstrResultadoAntecedentesPersonales = ""
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        Else
            'se esta accediendo normalemente para editar

            'primero crea los nombres y pone todo en cero
            Inicializa()
            'ahora revisa si existe un archivo de antecedentes
            If File.Exists(fileAntPersonales) = True Then
                'existe un archivo lo carga y muestra
                'Carga el registro previo de antecedentes familiares
                CargaAntecedentesPersonales()
                'actualiza los datos numericos con la estructura
                ActualizaPantallaConLaEstructura()
                
            Else
                'se esta creando un archivo nuevo
                'se escribe la estructura en blanco para darle formato
                EscribeAntecedentesPersonalesAlDisco()
                'no hace mas nada porque ya los paneles en pantalla
                'refleja un archivo vacio
            End If

            'dice a la bandera que no se han producido cambios y lo 
            'pone al principo asi
            booDatosModificados = False
            botCancelar.Text = "Salir"
            botAceptar.Enabled = False

        End If

    End Sub

    Private Sub Inicializa()
        'crea el nombre del archivo de antecedentes familiares
        fileAntPersonales = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Personales.dat"

        'le pone nombre al titulo
        Me.Text = "Antecedentes Personales de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"

        'inicializa la variable de respuesta local
        Form1.PSstrResultadoAntecedentesPersonales = ""

        'coloca los valores en pantalla
        txtAntPersonales.Text = ""

        'inicializa la estructura .....
        AP = Nothing
        AP.a01strResumen = ""

    End Sub

    Private Sub CargaAntecedentesPersonales()
        Dim FS As FileStream
        Dim BR As BinaryReader

        FS = New FileStream(fileAntPersonales, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim C As Integer
        C = BR.PeekChar
        While FS.Position < FS.Length
            AP = Nothing
            ' Read fields and populate structure
            AP.a01strResumen = BR.ReadString 

            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub

    Private Sub ActualizaPantallaConLaEstructura()

        txtAntPersonales.Text = AP.a01strResumen

    End Sub

    Private Sub ActualizaEstructuraConLaPantalla()
        AP = Nothing
        AP.a01strResumen = txtAntPersonales.Text

    End Sub

    Private Sub ConstruyeAntecedentes()

        Form1.PSstrResultadoAntecedentesPersonales = txtAntPersonales.Text

    End Sub


    Private Sub EscribeAntecedentesPersonalesAlDisco()

        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(fileAntPersonales, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)

        'ahora lo escribe

        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(AP.a01strResumen)

        BW.Close()
        FS.Close()
    End Sub

    Private Sub SeProdujoUnCambio()
        booDatosModificados = True
        botCancelar.Text = "Descarta Cambios"
        botAceptar.Enabled = True
    End Sub

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        'traduce el texto en pantalla
        ConstruyeAntecedentes()
        'codifica los datos en pantalla en la estructura
        ActualizaEstructuraConLaPantalla()
        'escribe los datos en la estructura al disco
        EscribeAntecedentesPersonalesAlDisco()

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click

        If booDatosModificados = True Then
            'se van a perder los datos, pregunta para confirmar
            Dim reply As MsgBoxResult
            reply = MsgBox("Se perderan las últimas modificaciones realizadas, para confirmar presiona aceptar...", MsgBoxStyle.OkCancel, "Confirmar")

            If reply = MsgBoxResult.Ok Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                'se arrepintio deja abierta la vaina
            End If
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

    End Sub

    Private Sub txtAntPersonales_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAntPersonales.KeyPress
        SeProdujoUnCambio()
    End Sub
End Class
