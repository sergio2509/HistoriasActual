Imports System.IO

Public Class FormGuardias

    'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image

    'variables de archivos
    Dim PathAgenda As String
    Dim ArchivoIndice As String
    Dim ArchivoIndiceProximos As String
    Dim ArchivoControlDiario As String
    Dim ArchivoControlMensual As String
    Dim ArchivoControlAnual As String
    Dim ArchivoPropioAGD As String

    'variables de fechas
    Dim FechaConsultadaDia As Date
    Dim MesConsultado As Date
    Dim AñoConsultado As Date

    'variables de control de archivos
    Dim FS As FileStream
    Dim BW As BinaryWriter
    Dim BR As BinaryReader
    Dim REnum As IEnumerator
    Dim C As Integer

    'variables del entorno
    Dim Iniciando As Boolean
    Dim MesSeleccionadoCadena As String
    Dim MesSeleccionadoNumero As Integer
    Dim AñoseleccionadoFecha As Date
    Dim AñoSeleccionadoNumerodeAño As Integer 'exclusivo para calculo de años
    Dim AñoSeleccionadoNumerodeMes As Integer 'exclusivo para calulo de meses

    Dim ArchivoControlMensualdelDia As String 'para verificar las fechas donde hay consultas

    '============================ propias de este form ================================

    Dim NombreDeArchivoDeGuardias As String

    Dim GU As New Form1.EstructuraGuardias
    Dim arrayGuardias As New ArrayList

    Dim Contador As Integer = 0
    Dim T As Integer = 0

    Dim RespaldoLugar, RespaldoDescripcion As String

    Dim SeEncontroCoincidencia As Boolean = False

    Dim IndiceSeleccionado As Integer = 0 'guarda el indice del array que fue seleccionado

    Dim SeRealizaronModificaciones As Boolean = False



    Private Sub FormGuardias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'verifica que haya agenda
        If Form1.PSstrPathAgendaBDH = "" Then
            'no se ha creado path agenda...
            MsgBox("Esta Base de Datos aún no ha creado una agenda de consultas, inicia una y luego podrás usar este servicio", MsgBoxStyle.Information, "No existe Agenda")
            Me.Close()
        End If

        'nombre del archivo de guardias
        NombreDeArchivoDeGuardias = Form1.PSstrPathAgendaBDH & "\Guardias.agd"

        'inicializa la variable de cambios
        SeRealizaronModificaciones = False

        'carga archivo de guardia y pasa el contenido al arraylist 
        CargaGuardias() 'trae el numero de eventos en la var contador

        'apunta EL CALENDArio al dia actual
        Calendario1.SelectionRange.Start = Today
        'revisa si hay algo ese día
        VerificaDia()

        'marca eventos en el calendario
        MarcaEventos()

        If SeRealizaronModificaciones = True Then
            botFinalizar.Enabled = True
            botFinalizar.Text = "Guarda Modificaciones Realizadas"
            botDescartar.Text = "Descarta Modificaciones Realizadas"
            MsgBox("Al menos un evento incluido en la Agenda estaba ubicado en el pasado por lo que este fue automaticamente eliminado", MsgBoxStyle.Information)
            Me.AcceptButton = botFinalizar
        Else
            botFinalizar.Enabled = False
            Me.AcceptButton = botDescartar

        End If



    End Sub

    Private Sub CargaGuardias()

        Dim fecha As Date

        If File.Exists(NombreDeArchivoDeGuardias) Then
            'el archivo existe lo carga
            'ya existe un archivo propio lo lee
            FS = New FileStream(NombreDeArchivoDeGuardias, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            Contador = 0

            While FS.Position < FS.Length
                GU = Nothing
                ' Read fields and populate structure
                GU.a01Fecha = BR.ReadString
                GU.a02Lugar1 = BR.ReadString
                GU.a03Descripcion1 = BR.ReadString
                GU.a04Lugar2 = BR.ReadString
                GU.a05Descripcion2 = BR.ReadString
                GU.a06Lugar3 = BR.ReadString
                GU.a07Descripcion3 = BR.ReadString
                GU.a08 = BR.ReadString
                GU.a09 = BR.ReadString
                GU.a10 = BR.ReadString

                'verifica que no este caducada
                fecha = CType(GU.a01Fecha, Date)
                If fecha < Today Then
                    'es un evento caduco no lo mete al array
                    SeRealizaronModificaciones = True
                Else
                    'ta bien lo mete
                    arrayGuardias.Add(GU)
                    Contador += 1
                End If
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        Else
            'el archivo no existe lo crea
            FS = New FileStream(NombreDeArchivoDeGuardias, FileMode.Create, FileAccess.ReadWrite)
            FS.Close()
            Contador = 0
        End If

    End Sub

    Private Sub MarcaEventos()

        If Contador > 0 Then
            'hay alguna fecha con eventos
            Dim Fecha As Date
            Dim Año As Integer
            Dim Mes As Integer
            Dim Dia As Integer
            Dim Fechas() As Date

            ReDim Fechas(Contador)

            For Me.T = 0 To Contador - 1
                GU = arrayGuardias(T)
                Fecha = CType(GU.a01Fecha, Date)
                Año = Fecha.Year
                Mes = Fecha.Month
                Dia = Fecha.Day
                Fechas(T) = New Date(Año, Mes, Dia)
            Next

            Me.Calendario1.BoldedDates = Fechas
            Me.Calendario1.UpdateBoldedDates()
        Else
            'no hace nada porq no hay fechas ocupadas
        End If
    End Sub

    Private Sub Calendario1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario1.DateSelected
        VerificaDia()
    End Sub

    Private Sub VerificaDia()
        Dim FechaSeleccionada As Date
        Dim FechaVerificada As Date
        Dim strFechaSeleccionada As String
        Dim strFechaVerificada As String



        FechaSeleccionada = Calendario1.SelectionRange.Start 'carga la fecha seleccionada
        strFechaSeleccionada = FechaSeleccionada.ToString("d") 'formatea la fecha seleccionada a short date

        'inicializa las text box
        txtFecha.Text = strFechaSeleccionada
        txtLugar1.Clear()
        txtDescripcion1.Clear()
        txtLugar2.Clear()
        txtDescripcion2.Clear()
        txtLugar3.Clear()
        txtDescripcion3.Clear()

        If FechaSeleccionada < Today Then
            botEdicion.Enabled = False
        Else
            botEdicion.Enabled = True
        End If

        'revisa si la fecha seleccionada tiene un evento o esta libre
        If Contador = 0 Then
            'la base de datos de guardias esta vacia
            botEdicion.Text = "Añade Evento"
            botElimina.Enabled = False
        Else
            'existe algun dato verifica que este dia haya algun evento fijado
            SeEncontroCoincidencia = False 'inicializa la bandera
            For Me.T = 0 To Contador - 1
                GU = arrayGuardias(T)
                FechaVerificada = CType(GU.a01Fecha, Date)
                strFechaVerificada = FechaVerificada.ToString("d") 'formatea a short date

                If strFechaSeleccionada = strFechaVerificada Then
                    'la fecha seleccionada tiene un evento lo muestra
                    SeEncontroCoincidencia = True
                    IndiceSeleccionado = T 'recuerda cual fue el indice selecionado
                    txtLugar1.Text = GU.a02Lugar1
                    txtDescripcion1.Text = GU.a03Descripcion1
                    txtLugar2.Text = GU.a04Lugar2
                    txtDescripcion2.Text = GU.a05Descripcion2
                    txtLugar3.Text = GU.a06Lugar3
                    txtDescripcion3.Text = GU.a07Descripcion3
                    Exit For
                Else
                    'sin coincidencia sigue revisando hasta el fin
                End If
            Next

            'revisa si se encontro el dia seleccionado
            If SeEncontroCoincidencia = True Then
                'se encontro
                botEdicion.Text = "Modifica Evento"
                botElimina.Enabled = True


            Else
                'no se encontro

                botEdicion.Text = "Añade Evento"
                botElimina.Enabled = False

            End If

        End If
    End Sub

    Private Sub botEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEdicion.Click




        'permite la edicion de los eventos
        GroupBox1.Enabled = True
        Calendario1.Enabled = False
        botEdicion.Enabled = False
        botElimina.Enabled = False
        botFinalizar.Enabled = False

        've como quedan los botones de abajo
        If SeEncontroCoincidencia = True Then
            'se encontro
            botAceptar.Text = "Aceptar Modificación"
            botCancelar.Text = "Cancela Cambios"


        Else
            'no se encontro
            botAceptar.Text = "Añade Nuevo Evento"
            botCancelar.Text = "Cancelar"


        End If

        'pone el foco en texto1
        txtLugar1.Focus()
        Me.AcceptButton = botAceptar


    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        'txtLugar.Text = RespaldoLugar
        'txtDescripcion.Text = RespaldoDescripcion
        GroupBox1.Enabled = False
        Calendario1.Enabled = True
        botEdicion.Enabled = True
        botFinalizar.Enabled = True

        botAceptar.Text = "Aceptar"
        botCancelar.Text = "Cancelar"

        VerificaDia()


    End Sub

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        If Calendario1.SelectionRange.Start < Today Then
            'Pasado no deja que se fije

            MsgBox("Se seleccionó en el pasado, corrige la selección", MsgBoxStyle.Critical)

            GroupBox1.Enabled = False
            Calendario1.Enabled = True
            botEdicion.Enabled = True
            botFinalizar.Enabled = True


            botAceptar.Text = "Aceptar"
            botCancelar.Text = "Cancelar"

            VerificaDia()

            'marca eventos en el calendario
            MarcaEventos()


        Else
            'hoy o en el futuro
            If SeEncontroCoincidencia = True Then
                'se esta modificando un evento previo
                GU.a01Fecha = Calendario1.SelectionRange.Start.ToString("s")
                GU.a02Lugar1 = txtLugar1.Text
                GU.a03Descripcion1 = txtDescripcion1.Text
                GU.a04Lugar2 = txtLugar2.Text
                GU.a05Descripcion2 = txtDescripcion2.Text
                GU.a06Lugar3 = txtLugar3.Text
                GU.a07Descripcion3 = txtDescripcion3.Text
                GU.a08 = ""
                GU.a09 = ""
                GU.a10 = ""

                arrayGuardias.Item(IndiceSeleccionado) = GU

            Else
                'se esta introduciendo un evento nuevo
                GU.a01Fecha = Calendario1.SelectionRange.Start.ToString("s")
                GU.a02Lugar1 = txtLugar1.Text
                GU.a03Descripcion1 = txtDescripcion1.Text
                GU.a04Lugar2 = txtLugar2.Text
                GU.a05Descripcion2 = txtDescripcion2.Text
                GU.a06Lugar3 = txtLugar3.Text
                GU.a07Descripcion3 = txtDescripcion3.Text
                GU.a08 = ""
                GU.a09 = ""
                GU.a10 = ""

                arrayGuardias.Add(GU)
                Contador += 1
            End If

            GroupBox1.Enabled = False
            Calendario1.Enabled = True
            botEdicion.Enabled = True
            botFinalizar.Enabled = True
            botAceptar.Text = "Aceptar"
            botCancelar.Text = "Cancelar"

            

            VerificaDia()

            'marca eventos en el calendario
            MarcaEventos()

            SeRealizaronModificaciones = True
            botDescartar.Text = "Descarta Modificaciones Realizadas"
            botFinalizar.Text = "Guarda Modificaciones Realizadas"
            Me.AcceptButton = botFinalizar

        End If

    End Sub

   
  
    Private Sub botElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botElimina.Click

        arrayGuardias.RemoveAt(IndiceSeleccionado)
        Contador -= 1

        GroupBox1.Enabled = False
        Calendario1.Enabled = True
      
        botAceptar.Text = "Aceptar"
        botCancelar.Text = "Cancelar"

        SeRealizaronModificaciones = True
        botFinalizar.Enabled = True
        botFinalizar.Text = "Guarda Modificaciones Realizadas"
        botDescartar.Text = "Descarta Modificaciones Realizadas"

        VerificaDia()

        'marca eventos en el calendario
        MarcaEventos()

        
    End Sub

    Private Sub botFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFinalizar.Click

        'pasa el contenido de la array list al archivo

        If Contador > 0 Then
            'hay algo que escribir pasa la array al archivo
            FS = New FileStream(NombreDeArchivoDeGuardias, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)
            For Me.T = 0 To Contador - 1
                GU = arrayGuardias(T)
                BW.Write(GU.a01Fecha)
                BW.Write(GU.a02Lugar1)
                BW.Write(GU.a03Descripcion1)
                BW.Write(GU.a04Lugar2)
                BW.Write(GU.a05Descripcion2)
                BW.Write(GU.a06Lugar3)
                BW.Write(GU.a07Descripcion3)
                BW.Write(GU.a08)
                BW.Write(GU.a09)
                BW.Write(GU.a10)
            Next

            FS.Close()
            BW.Close()

        Else
            'se borro todo se inicializa en blanco el archivo
            FS = New FileStream(NombreDeArchivoDeGuardias, FileMode.Create, FileAccess.ReadWrite)
            FS.Close()
        End If

        Me.Close()
    End Sub

    Private Sub botDescartar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botDescartar.Click
        If SeRealizaronModificaciones = True Then
            Dim reply As MsgBoxResult
            reply = MsgBox("¿Realmente deseas descartar todos los cambios realizados?", MsgBoxStyle.YesNo)
            If reply = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            'no se habian realizado cambios sale sin preguntar nada
            Me.Close()
        End If



    End Sub


End Class