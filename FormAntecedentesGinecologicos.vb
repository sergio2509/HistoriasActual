Imports System.IO

Public Class FormAntecedentesGinecologicos

    'VARIABLES DEL PROCEDIMIENTO
    Dim fileAntGinecologicos As String

    Structure TablaDeAntecedentesGinecologicos

        Dim a01strResumen As String

    End Structure

    Dim AG As TablaDeAntecedentesGinecologicos

    Dim booDatosModificados As Boolean

    Private Sub FormAntecedentesGinecologicos_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txtAntGinecologicos.Focus()
    End Sub

    Private Sub FormAntecedentesGinecologicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Form1.PSbooConsultaAntecedentesGinecologicos = True Then

            'se esta accediendo para consultar los antedentes y regresar con los datos

            Form1.PSbooConsultaAntecedentesGinecologicos = False 'apaga la bandera

            'primero crea los nombres y pone todo en cero
            Inicializa()

            'ahora revisa si existe un archivo de antecedentes
            If File.Exists(fileAntGinecologicos) = True Then
                'existe un archivo lo carga y muestra
                'Carga el registro previo de antecedentes 
                CargaAntecedentesGinecologicos()
                'actualiza los Pantalla con la estructura
                ActualizaPantallaConLaEstructura()
                'inicio igual ahora construye con lo q tiene y cierrra 'traduce el texto en pantalla
                ConstruyeAntecedentes()
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else
                'no hay datos responde en blanco
                Form1.PSstrResultadoAntecedentesGinecologicos = ""
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        Else
            'se esta accediendo normalemente para editar

            'primero crea los nombres y pone todo en cero
            Inicializa()
            'ahora revisa si existe un archivo de antecedentes
            If File.Exists(fileAntGinecologicos) = True Then
                'existe un archivo lo carga y muestra
                'Carga el registro previo de antecedentes familiares
                CargaAntecedentesGinecologicos()
                'actualiza los datos numericos con la estructura
                ActualizaPantallaConLaEstructura()

            Else
                'se esta creando un archivo nuevo
                'se escribe la estructura en blanco para darle formato
                EscribeAntecedentesGinecologicosAlDisco()
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
        'crea el nombre del archivo de antecedentes 
        fileAntGinecologicos = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Ginecologicos.dat"

        'le pone nombre al titulo
        Me.Text = "Antecedentes Ginecológicos de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"

        'inicializa la variable de respuesta local
        Form1.PSstrResultadoAntecedentesGinecologicos = ""

        'coloca los valores en pantalla
        txtAntGinecologicos.Text = ""

        'inicializa la estructura .....
        AG = Nothing
        AG.a01strResumen = ""

    End Sub

    Private Sub CargaAntecedentesGinecologicos()
        Dim FS As FileStream
        Dim BR As BinaryReader

        FS = New FileStream(fileAntGinecologicos, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim C As Integer
        C = BR.PeekChar
        While FS.Position < FS.Length
            AG = Nothing
            ' Read fields and populate structure
            AG.a01strResumen = BR.ReadString

            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub

    Private Sub ActualizaPantallaConLaEstructura()

        txtAntGinecologicos.Text = AG.a01strResumen

    End Sub

    Private Sub ActualizaEstructuraConLaPantalla()
        AG = Nothing
        AG.a01strResumen = txtAntGinecologicos.Text

    End Sub

    Private Sub ConstruyeAntecedentes()

        Form1.PSstrResultadoAntecedentesGinecologicos = txtAntGinecologicos.Text

    End Sub


    Private Sub EscribeAntecedentesGinecologicosAlDisco()

        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(fileAntGinecologicos, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)

        'ahora lo escribe

        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(AG.a01strResumen)

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
        EscribeAntecedentesGinecologicosAlDisco()

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

    Private Sub txtAntGinecologicos_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAntGinecologicos.KeyPress
        SeProdujoUnCambio()
    End Sub
End Class