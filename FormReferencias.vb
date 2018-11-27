Imports System.IO

Public Class FormReferencias


    Dim booSeModificaronDatos As Boolean = False
    Dim strFiltro As String = ""
    Dim alsPacientesFiltradas As New ArrayList
    Dim alsOtrosRef As New ArrayList
    Dim alsOtrosRefFiltrados As New ArrayList

    'variables publicas de lo seleccionado
    Dim estPacienteReferidoraSel As Form1.BaseDatosIndiceHistorias
    Dim estOtroRefSel As Form1.TablaDeOtrosReferidores
    Dim intIndice As Integer
    Dim strArchivoDeReferenciaPtes As String = ""
    Dim strArchivoDeReferenciaPtesAntigua As String = ""
    Dim strArchivoDeReferenciaOtros As String = ""
    Dim strArchivoDeReferenciaOtrosAntigua As String = ""
    Dim strArchivoIndiceDeOtrosReferidores As String = ""
    Dim alsOtrasReferidasPorPte As New ArrayList
    Dim alsOtrasReferidasPorPteAntigua As New ArrayList
    Dim alsOtrasReferidasPorOtroRef As New ArrayList
    Dim alsOtrasReferidasPorOtroRefAntigua As New ArrayList

    Dim booSeDebeActualizarPteReferidoraAntigua As Boolean
    Dim booSeDebeActualizarOtroReferidorAntigua As Boolean

    Dim strPteDesdeSDS As String = ""




#Region "       ***** CARGA DEL FORM Y SELECCION INICIAL *****"

    Private Sub FormReferencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'los situa en su sitio pero ocultos
        Me.GroupBoxACTUALIZAR.Location = New System.Drawing.Point(12, 12)

        'primero que nada carga el archivo indice de otros referidores es dinamico y se le pueden añadir nuevos elementos q deben ser guardados si se altera
        subCargaArchivoDeOtrosRef() 'ya tengo la alsOtrosRef vacia si esta nueva o con datos

        If Form1.strTipoDeReferidor = "" Then
            subReferenciaNueva()
        Else
            subActualizarReferencia()
        End If
    End Sub

    Private Sub subCargaArchivoDeOtrosRef()
        Dim FS As FileStream
        Dim BR As BinaryReader
        Dim Ot As Form1.TablaDeOtrosReferidores
        Dim C As Integer

        strArchivoIndiceDeOtrosReferidores = Form1.PSstrPathHistoriasSinPrefijo & "\OtrosReferidores\Indice.dat"
        If File.Exists(strArchivoIndiceDeOtrosReferidores) Then
            'existe lo carga
            FS = New FileStream(strArchivoIndiceDeOtrosReferidores, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            ' Read todo
            C = BR.PeekChar
            While FS.Position < FS.Length
                Ot = Nothing
                Ot.a01NumeroID = BR.ReadString
                Ot.a02Nombre = BR.ReadString
                Ot.b01 = BR.ReadString
                Ot.b02 = BR.ReadString
                Ot.b03 = BR.ReadString

                'incluye en la als de otros referidores (completa)
                alsOtrosRef.Add(Ot)
            End While

            'cierra la vaina
            BR.Close()
            FS.Close()
        Else
            'no existe es primera vez se debe crear el dir si no existe y el archivo en blanco
            If Directory.Exists(Form1.PSstrPathHistoriasSinPrefijo & "\OtrosReferidores") Then
                'existe el directorio pero el archivo no debe haber sido borrado manualmente lo crea en blanco
                FS = New FileStream(strArchivoIndiceDeOtrosReferidores, FileMode.Create, FileAccess.ReadWrite)
                FS.Close()
                'como esta vacio la als q lo guarda tambien debe estarlo no?
                alsOtrosRef.Clear()
            Else
                'no existe tampoco lo debe crear primero el directorio
                Directory.CreateDirectory(Form1.PSstrPathHistoriasSinPrefijo & "\OtrosReferidores")
                'y ahora el archivo de indice
                FS = New FileStream(strArchivoIndiceDeOtrosReferidores, FileMode.Create, FileAccess.ReadWrite)
                FS.Close()
                'como esta vacio la als q lo guarda tambien debe estarlo no?
                alsOtrosRef.Clear()
            End If
        End If
    End Sub

    Private Sub subReferenciaNueva()
        Me.Text = "Incluyendo Nuevo REFERIDOR de la Paciente: " & Form1.TituloVentanaDeTexto
        GroupBoxNUEVA.Visible = True
        GroupBoxACTUALIZAR.Visible = False
        radNUEVAacudioSola.Checked = True
    End Sub

    Private Sub subActualizarReferencia()
        Me.Text = "Actualizando el REFERIDOR de la Paciente: " & Form1.TituloVentanaDeTexto
        GroupBoxNUEVA.Visible = False
        GroupBoxACTUALIZAR.Visible = True

        'se debe ahora quitar del archivo de referencia a la pte referidora o al otro referidor original si vino sola no hay q hacer nada
        subQuitarDatosDeReferenciaViejos() 'al regresar tengo la alsOtrasReferidasPorPteAntigua o la alsOtrasReferidasPorOtroRefAntigua, ademas de la boo de quien debe ser actualizado
        subACTUALIZASeleccionaLoQueHabiaAntes()

    End Sub

    Private Sub subQuitarDatosDeReferenciaViejos()
        If Form1.strTipoDeReferidor = "Sola" Then
            'no hay que quitar nada
        ElseIf Form1.strTipoDeReferidor = "Pte" Then
            ' y que quitarle esta paciente a la als de ese pte referidor
            Dim strNumeroHistoria = (Form1.strNumeroDelReferidor.PadLeft(6, "0"c))
            strArchivoDeReferenciaPtesAntigua = Form1.PSstrPathHistoriasSinPrefijo & "\" & strNumeroHistoria.Substring(0, 5) & "\" & strNumeroHistoria & "-Referidas.dat"

            'revisa si existe... deberia verdad
            If File.Exists(strArchivoDeReferenciaPtesAntigua) Then
                'existe lo lee y añade a la als solo las otras referidas (si tiene) podria quedar en blanco pero no la borra
                Dim BR As BinaryReader
                Dim FS As FileStream
                Dim REF As Form1.TablaDeReferidas
                Dim C As Integer

                'inicializa la als de otras pacientes referidas
                alsOtrasReferidasPorPteAntigua.Clear()

                'ya esta comprobado q existe
                FS = New FileStream(strArchivoDeReferenciaPtesAntigua, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)

                ' Read todo
                C = BR.PeekChar
                While FS.Position < FS.Length
                    REF = Nothing
                    REF.a01NumeroHistoria = BR.ReadString
                    REF.a02Nombre = BR.ReadString
                    REF.a03Cedula = BR.ReadString
                    REF.a04FechaDeReferenciaSDS = BR.ReadString
                    REF.b01 = BR.ReadString
                    REF.b02 = BR.ReadString


                    'las incluye en la lista de referidas de la pte antigua menos la que estoy eliminando
                    If Form1.PSstrPacienteSeleccionadaNombre <> REF.a02Nombre Then
                        alsOtrasReferidasPorPteAntigua.Add(REF)
                    End If

                End While

                'cierra la vaina
                BR.Close()
                FS.Close()
                'al final prende la bandera de q se debe actualizar el archivo de la pte referidora antigua
                booSeDebeActualizarPteReferidoraAntigua = True
            Else
                'no existe, raro no... pero bueno pone la als en blanco
                alsOtrasReferidasPorPteAntigua.Clear()
                'al final prende la bandera de q se debe actualizar el archivo de la pte referidora antigua
                booSeDebeActualizarPteReferidoraAntigua = True
            End If



        ElseIf Form1.strTipoDeReferidor = "Otro" Then

            ' quitarle esta pte a la als de ese otro referidor
            Dim strNumeroID = (Form1.strNumeroDelReferidor)
            strArchivoDeReferenciaOtrosAntigua = Form1.PSstrPathHistoriasSinPrefijo & "\OtrosReferidores\" & strNumeroID.PadLeft(4, "0"c) & "-Referidas.dat"

            'revisa si existe... deberia verdad
            If File.Exists(strArchivoDeReferenciaOtrosAntigua) Then
                'existe lo lee y añade a la als solo las otras referidas (si tiene) podria quedar en blanco pero no la borra
                Dim BR As BinaryReader
                Dim FS As FileStream
                Dim REF As Form1.TablaDeReferidas
                Dim C As Integer

                'inicializa la als de otras pacientes referidas
                alsOtrasReferidasPorOtroRefAntigua.Clear()

                'ya esta comprobado q existe
                FS = New FileStream(strArchivoDeReferenciaOtrosAntigua, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)

                ' Read todo
                C = BR.PeekChar
                While FS.Position < FS.Length
                    REF = Nothing
                    REF.a01NumeroHistoria = BR.ReadString
                    REF.a02Nombre = BR.ReadString
                    REF.a03Cedula = BR.ReadString
                    REF.a04FechaDeReferenciaSDS = BR.ReadString
                    REF.b01 = BR.ReadString
                    REF.b02 = BR.ReadString


                    'las incluye en la lista de referidas del otro ref antigua menos la que estoy eliminando
                    If Form1.PSstrPacienteSeleccionadaNombre <> REF.a02Nombre Then
                        alsOtrasReferidasPorOtroRefAntigua.Add(REF)
                    End If

                End While

                'cierra la vaina
                BR.Close()
                FS.Close()

                'al final prende la bandera de q se debe actualizar el archivo del otro referidor antiguo
                booSeDebeActualizarOtroReferidorAntigua = True

            Else
                'no existe, raro no... pero bueno pone la als en blanco
                alsOtrasReferidasPorOtroRefAntigua.Clear()
                'al final prende la bandera de q se debe actualizar el archivo del otro referidor antiguo
                booSeDebeActualizarOtroReferidorAntigua = True
            End If



        End If
    End Sub

    Private Sub subACTUALIZASeleccionaLoQueHabiaAntes()
        If Form1.strTipoDeReferidor = "Sola" Then
            'solo hay q seleccionar que vino sola el prg hace el resto
            radACTUALIZAacudioSola.Checked = True

        ElseIf Form1.strTipoDeReferidor = "Pte" Then
            'fue una paciente 1ro muestra el listado
            radACTUALIZAreferidaPorPaciente.Checked = True
            'ahora q estan todas mostradas selecciona la referidora
            Dim intContador = 0
            For Each est As Form1.BaseDatosIndiceHistorias In alsPacientesFiltradas
                If est.NumeroHistoria = Form1.strNumeroDelReferidor Then
                    'esta es la que es selecciona este indice en el listbox
                    ListBoxACTUALIZApacientes.SelectedIndex = intContador
                    Exit For
                End If
                intContador += 1
            Next

        ElseIf Form1.strTipoDeReferidor = "Otro" Then
            'fue otro ref 1ro muestra el listado
            radACTUALIZAreferidaPorOtro.Checked = True
            'ahora q estan todos mostrados selecciona el referidor
            Dim intContador = 0
            For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRefFiltrados
                If est.a01NumeroID = Form1.strNumeroDelReferidor Then
                    'esta es la que es selecciona este indice en el listbox
                    ListBoxACTUALIZAotros.SelectedIndex = intContador
                    Exit For
                End If
                intContador += 1
            Next


        End If
    End Sub

    Private Sub radNUEVAseleccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radNUEVAacudioSola.CheckedChanged, radNUEVAreferidaPorPaciente.CheckedChanged, radNUEVAreferidaPorOtro.CheckedChanged

        If radNUEVAacudioSola.Checked = True Then
            subNUEVAseleccionAcudioSola()
        ElseIf radNUEVAreferidaPorPaciente.Checked = True Then
            subNUEVAseleccionReferidaPorPaciente()
        ElseIf radNUEVAreferidaPorOtro.Checked = True Then
            subNUEVAseleccionReferidaPorOtro()
        End If

    End Sub

    Private Sub radACTUALIZAseleccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles radACTUALIZAacudioSola.CheckedChanged, radACTUALIZAreferidaPorPaciente.CheckedChanged, radACTUALIZAreferidaPorOtro.CheckedChanged

        If radACTUALIZAacudioSola.Checked = True Then
            subACTUALIZAseleccionAcudioSola()
        ElseIf radACTUALIZAreferidaPorPaciente.Checked = True Then
            subACTUALIZAseleccionReferidaPorPaciente()
        ElseIf radACTUALIZAreferidaPorOtro.Checked = True Then
            subACTUALIZAseleccionReferidaPorOtro()
        End If

    End Sub

#End Region


#Region "       ***** NUEVA REFERENCIA ACUDIO SOLA *****"

    Private Sub subNUEVAseleccionAcudioSola()
        'apaga y limpia los datos en los paneles
        subLIMPIApanelNUEVAreferidaPorPaciente()
        subLIMPIApanelNUEVAreferidaPorOtro()
        PanelNUEVAreferidaPorPaciente.Enabled = False
        PanelNUEVAreferidaPorOtro.Enabled = False
        'carga las variables publicas con los datos
        Form1.strTipoDeReferidor = "Sola"
        Form1.strReferidor = "Acudió expontáneamente"
        Form1.strNumeroDelReferidor = ""
        'prende el boton de aceptar
        botAceptar.Enabled = True
    End Sub

#End Region


#Region "       ***** NUEVA REFENCIA FUE REFERIDA X UNA Pte *****"

    Private Sub subNUEVAseleccionReferidaPorPaciente()

        'apaga y limpia los datos en el panel otros
        subLIMPIApanelNUEVAreferidaPorOtro()
        PanelNUEVAreferidaPorOtro.Enabled = False
        'limpia y prende el panel de seleccion por paciente
        subLIMPIApanelNUEVAreferidaPorPaciente() 'aca el filto se pona en blanco
        PanelNUEVAreferidaPorPaciente.Enabled = True

        'muestra la lista de paciente, como el filtro esta en blanco se mostraran todas
        subNUEVAMuestraListaDePacientes()

    End Sub

    Private Sub subLIMPIApanelNUEVAreferidaPorPaciente()


        ListBoxNUEVApacientes.Items.Clear()
        labNUEVAlistadoPacientes.Text = "Listado de Pacientes: (0)"
        labNUEVApacienteSeleccionada.Text = ""
        ListBoxNUEVAreferidasPorPaciente.Items.Clear()
        strFiltro = ""
        txtNUEVApacientesFiltro.Clear() 'esto dispara el muestra lista de pates si esta seleccionado....

    End Sub

    Private Sub subNUEVAMuestraListaDePacientes()

        'limpia el list box para actualizar lista
        ListBoxNUEVApacientes.Items.Clear()
        alsPacientesFiltradas.Clear()


        If strFiltro = "" Then
            'los muestra todos
            For Each est As Form1.BaseDatosIndiceHistorias In Form1.Historias
                'OK LA CADENA ESTA ACA LA muestra
                ListBoxNUEVApacientes.Items.Add(est.NombrePaciente)
                alsPacientesFiltradas.Add(est)
            Next
        Else
            'se muestran las q concuerden
            strFiltro = strFiltro.ToUpper
            For Each est As Form1.BaseDatosIndiceHistorias In Form1.Historias
                If est.NombrePaciente.ToUpper.Contains(strFiltro) Then
                    'OK LA CADENA ESTA ACA LA muestra
                    ListBoxNUEVApacientes.Items.Add(est.NombrePaciente)
                    alsPacientesFiltradas.Add(est)
                End If
            Next
        End If

        'muestra cuantos llegaron luego del filtro
        labNUEVAlistadoPacientes.Text = "Listado de Pacientes: (" & alsPacientesFiltradas.Count.ToString & ")"

        'apaga el boton aceptar espera que se seleccione a la paciente para luego prender el boton aceptar
        botAceptar.Enabled = False

        'le da foco al filtro
        txtNUEVApacientesFiltro.Focus()

    End Sub

    Private Sub txtNUEVApacientesFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNUEVApacientesFiltro.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNUEVApacientesFiltro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNUEVApacientesFiltro.TextChanged
        'filtra la lista de las pacientes si esta seleccionado
        If radNUEVAreferidaPorPaciente.Checked = True Then
            strFiltro = txtNUEVApacientesFiltro.Text
            subNUEVAMuestraListaDePacientes()
        End If
    End Sub

    Private Sub ListBoxNUEVApacientes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxNUEVApacientes.SelectedIndexChanged
        If ListBoxNUEVApacientes.SelectedIndex > -1 Then


            'busca el indice y carga el est en memoria
            intIndice = ListBoxNUEVApacientes.SelectedIndex
            estPacienteReferidoraSel = alsPacientesFiltradas(intIndice)

            'revisa q no haya seleccionado asimisma
            If Form1.PSstrNumeroHistoriaSeleccionada = estPacienteReferidoraSel.NumeroHistoria Then
                MsgBox("No puedes seleccionar a la misma paciente como referidora...", MsgBoxStyle.Information, "Referencia Inválida")
                subLIMPIApanelNUEVAreferidaPorPaciente()
                subNUEVAMuestraListaDePacientes()
                Exit Sub
            End If

            'si llego aca esta bien prende el boton aceptar

            'muestra la paciente en el label
            labNUEVApacienteSeleccionada.Text = estPacienteReferidoraSel.NombrePaciente
            'busca el archivo de referencias de esta paciente para obtener la als con las otras ptes referidas de esta referidora (si las jay)
            subNUEVABuscaArchivoDeReferenciasPtes()
            'ahora no importa si esta vacia o con algunas referidas previas añado esta paciente como referida
            subNUEVAAñadeLaPacienteActualComoReferidaDeEstaPacienteRef()
            'queda lista la als para ser grabada si se acepta

            'carga las variables publicas con los datos
            Form1.strTipoDeReferidor = "Pte"
            Form1.strReferidor = estPacienteReferidoraSel.NombrePaciente
            Form1.strNumeroDelReferidor = estPacienteReferidoraSel.NumeroHistoria
            'prende el boton de aceptar
            botAceptar.Enabled = True

        End If
    End Sub

    Private Sub subNUEVABuscaArchivoDeReferenciasPtes()
        'construye el nombre del archivo segun se selecciono
        strArchivoDeReferenciaPtes = Form1.PSstrPathHistoriasSinPrefijo & "\" & estPacienteReferidoraSel.NumeroHistoria.Substring(0, 5) & "\" & estPacienteReferidoraSel.NumeroHistoria & "-Referidas.dat"

        'comprueba si existe
        If File.Exists(strArchivoDeReferenciaPtes) Then
            'existe lo lee y carga los datos en la alsOtrasReferidasPorPte
            subNUEVAleeArchivoDeReferenciasPtes()
        Else
            'no existe lo muestra de una vez en el listbox de otras referidas
            ListBoxNUEVAreferidasPorPaciente.Items.Clear()
            ListBoxNUEVAreferidasPorPaciente.Items.Add("No ha referido a nadie más")
            'limpia la als dependiente
            alsOtrasReferidasPorPte.Clear()
        End If

    End Sub

    Private Sub subNUEVAleeArchivoDeReferenciasPtes()
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim REF As Form1.TablaDeReferidas
        Dim C As Integer

        'inicializa la als de otras pacientes referidas
        alsOtrasReferidasPorPte.Clear()

        'ya esta comprobado q existe
        FS = New FileStream(strArchivoDeReferenciaPtes, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        ' Read todo
        C = BR.PeekChar
        While FS.Position < FS.Length
            REF = Nothing
            REF.a01NumeroHistoria = BR.ReadString
            REF.a02Nombre = BR.ReadString
            REF.a03Cedula = BR.ReadString
            REF.a04FechaDeReferenciaSDS = BR.ReadString
            REF.b01 = BR.ReadString
            REF.b02 = BR.ReadString


            'las incluye en la lista de otras referidas
            alsOtrasReferidasPorPte.Add(REF)

        End While

        'cierra la vaina
        BR.Close()
        FS.Close()

        'ahora muestra los datos en el list box
        If alsOtrasReferidasPorPte.Count > 0 Then
            'ok hay datos los muestra
            ListBoxNUEVAreferidasPorPaciente.Items.Clear()
            'ordena la lista por fecha de referencia
            Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorPte _
                                       Order By CType(est.a04FechaDeReferenciaSDS, Date) _
                                       Select est
            'las muestra ordenadas en el list box
            For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                ListBoxNUEVAreferidasPorPaciente.Items.Add("El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre)
            Next
        Else
            'el archivo existe pero esta vacio lo dice
            ListBoxNUEVAreferidasPorPaciente.Items.Clear()
            ListBoxNUEVAreferidasPorPaciente.Items.Add("No ha referido a nadie más")
            'limpia la als dependiente
            alsOtrasReferidasPorPte.Clear()
        End If


    End Sub

    Private Sub subNUEVAAñadeLaPacienteActualComoReferidaDeEstaPacienteRef()

        'la als ya tiene los datos hasta aca, puede estar en blano y esta ser su 1ra o ya haber otras ptes ref
        Dim est As Form1.TablaDeReferidas
        est = Nothing

        'cargo los datos de la pte actual en la est para añadirla a las referidas de esta pte ref
        est.a01NumeroHistoria = Form1.PSstrNumeroHistoriaSeleccionada
        est.a02Nombre = Form1.PSstrPacienteSeleccionadaNombre
        est.a03Cedula = Form1.PSstrPacienteSeleccionadaCedula
        'debe revisar desde cuando es pte si no hay agenda propia entonces la pone a hoy
        subAveriguaDesdeCuandoEsPte()
        est.a04FechaDeReferenciaSDS = strPteDesdeSDS
        est.b01 = ""
        est.b02 = ""

        'la añade
        alsOtrasReferidasPorPte.Add(est)

        'queda lista para ser guardada si se acepta....

    End Sub

    Private Sub subAveriguaDesdeCuandoEsPte()
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim Con As Form1.TablaDeArchivosPropiosDeAgenda
        Dim C As Integer
        Dim alsConsultasDeLaPte As New ArrayList

        'construye el nombre del archivo de la agenda buscado
        Dim strArchivoPropioDeAgenda = Form1.PSstrPathHistoriasSinPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada.Substring(0, 5) & "\" & Form1.PSstrNumeroHistoriaSeleccionada & ".agd"

        If File.Exists(strArchivoPropioDeAgenda) Then
            'existe lo lee inicializa la als
            alsConsultasDeLaPte.Clear()


            FS = New FileStream(strArchivoPropioDeAgenda, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            ' Read todo
            C = BR.PeekChar
            While FS.Position < FS.Length
                Con = Nothing
                Con.a10FechaConsulta = BR.ReadString
                Con.a02Clinica = BR.ReadString
                Con.a03NotaseIDx = BR.ReadString
                Con.a04Tratamiento = BR.ReadString
                Con.a05Pendiente = BR.ReadString
                Con.a06ProximaConsulta = BR.ReadString
                Con.a07Honorarios = BR.ReadString
                Con.a11FacturaAsociada = BR.ReadString
                Con.a16Referencia = BR.ReadString
                Con.a15Banco = BR.ReadString
                Con.a14FormaDePago = BR.ReadString
                Con.a13FechaDePago = BR.ReadString
                Con.a12Pagador = BR.ReadString

                'las incluye en la als
                alsConsultasDeLaPte.Add(Con)
            End While

            'cierra la vaina
            BR.Close()
            FS.Close()

            'ahora ordena la vaina
            Dim alsConsultasOrdenadasDeLaPte = From est As Form1.TablaDeArchivosPropiosDeAgenda In alsConsultasDeLaPte _
                                               Order By CType(est.a10FechaConsulta, Date) _
                                               Select est

            'ya esta ordenado saca desde cuando es pte
            strPteDesdeSDS = CType(alsConsultasOrdenadasDeLaPte(0).a10FechaConsulta, Date).ToShortDateString
        Else
            'no existe pone que la conoce desde hoy
            strPteDesdeSDS = Today.ToShortDateString

        End If

    End Sub

    Private Sub subNUEVAGuardaArchivoDeReferidasPorEstaPteRef()
        'variables de control de IO
        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(strArchivoDeReferenciaPtes, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeReferidas In alsOtrasReferidasPorPte
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04FechaDeReferenciaSDS)
            BW.Write(est.b01)
            BW.Write(est.b02)
        Next
        FS.Close()
        BW.Close()
    End Sub


#End Region


#Region "       ***** NUEVA REFENCIA FUE REFERIDA X OTROS *****"

    Private Sub subNUEVAseleccionReferidaPorOtro()
        'apaga y limpia los datos en el panel pacientes
        subLIMPIApanelNUEVAreferidaPorPaciente()
        PanelNUEVAreferidaPorPaciente.Enabled = False
        'limpia y prende el panel de seleccion por paciente
        subLIMPIApanelNUEVAreferidaPorOtro()
        PanelNUEVAreferidaPorOtro.Enabled = True

        'muestra la lista de otros referidores, como el filtro esta en blanco se mostraran todos
        subNUEVAMuestraListaDeOtrosRef()

    End Sub

    Private Sub subLIMPIApanelNUEVAreferidaPorOtro()
        ListBoxNUEVAotros.Items.Clear()
        labNUEVAListadoOtros.Text = "Listado de Otros Referidores (0)"
        labNUEVAotroSeleccionada.Text = ""
        ListBoxNUEVAreferidasPorOtro.Items.Clear()
        txtNUEVAotrosFiltro.Clear()
        strFiltro = ""
    End Sub

    Private Sub subNUEVAMuestraListaDeOtrosRef()

        'limpia el list box para actualizar lista
        ListBoxNUEVAotros.Items.Clear()
        alsOtrosRefFiltrados.Clear()


        If strFiltro = "" Then
            'los muestra todos
            For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRef
                ListBoxNUEVAotros.Items.Add(est.a02Nombre)
                alsOtrosRefFiltrados.Add(est)
            Next
        Else
            'se muestran las q concuerden
            strFiltro = strFiltro.ToUpper
            For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRef
                If est.a02Nombre.ToUpper.Contains(strFiltro) Then
                    'OK LA CADENA ESTA ACA LA muestra
                    ListBoxNUEVAotros.Items.Add(est.a02Nombre)
                    alsOtrosRefFiltrados.Add(est)
                End If
            Next
        End If

        'muestra cuantos llegaron luego del filtro
        labNUEVAListadoOtros.Text = "Listado de Otros Referidores: (" & alsOtrosRefFiltrados.Count.ToString & ")"

        'apaga el boton aceptar espera que se seleccione a la paciente para luego prender el boton aceptar
        botAceptar.Enabled = False
        botNUEVAeditaReferidor.Enabled = False

        'le da foco al filtro
        txtNUEVAotrosFiltro.Focus()

    End Sub

    Private Sub txtNUEVAotrosFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNUEVAotrosFiltro.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNUEVAotrosFiltro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNUEVAotrosFiltro.TextChanged
        'filtra la lista de otros referidores si esta seleccionado
        If radNUEVAreferidaPorOtro.Checked = True Then
            strFiltro = txtNUEVAotrosFiltro.Text
            subNUEVAMuestraListaDeOtrosRef()
        End If
    End Sub

    Private Sub ListBoxNUEVAotros_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxNUEVAotros.SelectedIndexChanged
        If ListBoxNUEVAotros.SelectedIndex > -1 Then


            'busca el indice y carga el est en memoria
            intIndice = ListBoxNUEVAotros.SelectedIndex
            estOtroRefSel = alsOtrosRefFiltrados(intIndice)

            'muestra la paciente en el label
            labNUEVAotroSeleccionada.Text = estOtroRefSel.a02Nombre
            'busca el archivo de referencias de esta paciente para obtener la als con las otras ptes referidas de esta referidora (si las jay)
            subNUEVABuscaArchivoDeReferenciasOtros()
            'ahora no importa si esta vacia o con algunas referidas previas añado esta paciente como referida
            subNUEVAAñadeLaPacienteActualComoReferidaDeEsteOtroRef()
            'queda lista la als para ser grabada si se acepta

            'carga las variables publicas con los datos
            Form1.strTipoDeReferidor = "Otro"
            Form1.strReferidor = estOtroRefSel.a02Nombre
            Form1.strNumeroDelReferidor = estOtroRefSel.a01NumeroID
            'prende el boton de aceptar y editar
            botNUEVAeditaReferidor.Enabled = True
            botAceptar.Enabled = True

        End If
    End Sub

    Private Sub subNUEVABuscaArchivoDeReferenciasOtros()
        'construye el nombre del archivo segun se selecciono
        strArchivoDeReferenciaOtros = Form1.PSstrPathHistoriasSinPrefijo & "\OtrosReferidores\" & estOtroRefSel.a01NumeroID.PadLeft(4, "0"c) & "-Referidas.dat"

        'comprueba si existe
        If File.Exists(strArchivoDeReferenciaOtros) Then
            'existe lo lee y carga los datos en la als
            subNUEVALeeArchivoDeReferenciasOtros()
        Else
            'no existe lo muestra de una vez en el listbox de otras referidas
            ListBoxNUEVAreferidasPorOtro.Items.Clear()
            ListBoxNUEVAreferidasPorOtro.Items.Add("No ha referido a nadie más")
            'limpia la als dependiente
            alsOtrasReferidasPorOtroRef.Clear()
        End If

    End Sub

    Private Sub subNUEVALeeArchivoDeReferenciasOtros()
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim REF As Form1.TablaDeReferidas
        Dim C As Integer

        'inicializa la als de otras pacientes referidas
        alsOtrasReferidasPorOtroRef.Clear()

        'ya esta comprobado q existe
        FS = New FileStream(strArchivoDeReferenciaOtros, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        ' Read todo
        C = BR.PeekChar
        While FS.Position < FS.Length
            REF = Nothing
            REF.a01NumeroHistoria = BR.ReadString
            REF.a02Nombre = BR.ReadString
            REF.a03Cedula = BR.ReadString
            REF.a04FechaDeReferenciaSDS = BR.ReadString
            REF.b01 = BR.ReadString
            REF.b02 = BR.ReadString


            'las incluye en la lista de otras referidas
            alsOtrasReferidasPorOtroRef.Add(REF)

        End While

        'cierra la vaina
        BR.Close()
        FS.Close()

        'ahora muestra los datos en el list box
        If alsOtrasReferidasPorOtroRef.Count > 0 Then
            'hay datos los muestra
            ListBoxNUEVAreferidasPorOtro.Items.Clear()
            'ordena la lista por fecha de referencia
            Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorOtroRef _
                                       Order By CType(est.a04FechaDeReferenciaSDS, Date) _
                                       Select est
            'las muestra ordenadas en el list box
            For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                ListBoxNUEVAreferidasPorOtro.Items.Add("El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre)
            Next
        Else
            'el archivo existe pero esta vacio lo dice
            ListBoxNUEVAreferidasPorOtro.Items.Clear()
            ListBoxNUEVAreferidasPorOtro.Items.Add("No ha referido a nadie más")
            'limpia la als dependiente
            alsOtrasReferidasPorOtroRef.Clear()
        End If




    End Sub

    Private Sub subNUEVAAñadeLaPacienteActualComoReferidaDeEsteOtroRef()

        'la als ya tiene los datos hasta aca, puede estar en blano y esta ser su 1ra o ya haber otras ptes ref
        Dim est As Form1.TablaDeReferidas
        est = Nothing

        'cargo los datos de la pte actual en la est para añadirla a las referidas de esta pte ref
        est.a01NumeroHistoria = Form1.PSstrNumeroHistoriaSeleccionada
        est.a02Nombre = Form1.PSstrPacienteSeleccionadaNombre
        est.a03Cedula = Form1.PSstrPacienteSeleccionadaCedula
        subAveriguaDesdeCuandoEsPte()
        est.a04FechaDeReferenciaSDS = strPteDesdeSDS
        est.b01 = ""
        est.b02 = ""

        'la añade
        alsOtrasReferidasPorOtroRef.Add(est)

        'queda lista para ser guardada si se acepta....

    End Sub

    Private Sub subNUEVAGuardaArchivoDeReferidasPorEsteOtroRef()
        'variables de control de IO
        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(strArchivoDeReferenciaOtros, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeReferidas In alsOtrasReferidasPorOtroRef
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04FechaDeReferenciaSDS)
            BW.Write(est.b01)
            BW.Write(est.b02)
        Next
        FS.Close()
        BW.Close()
    End Sub

    Private Sub botNUEVAnuevoReferidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNUEVAnuevoReferidor.Click
        Dim FS As FileStream
        Dim BW As BinaryWriter

        'consigue el nomnbre nuevo
        Dim strNombreNuevoRef = InputBox("Intoduce el Nombre y Apellido del Referidor...", "Incluyendo un nuevo Referidor")

        'revisa q no este en la als para q no este duplicado
        For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRef
            If est.a02Nombre = strNombreNuevoRef Then
                'esta incluido ya
                MsgBox("Este referidor ya se encuentra incluido en la Base de Datos, selecciónalo de la lista...", MsgBoxStyle.Information, "Referidor ya incluido...")
                subNUEVAMuestraListaDeOtrosRef()
                Exit Sub
            End If
        Next

        'si llego hasta aca es q se puede incluir carga la est y la añade a la als
        Dim Ot As Form1.TablaDeOtrosReferidores
        Ot = Nothing
        Ot.a01NumeroID = alsOtrosRef.Count.ToString
        Ot.a02Nombre = strNombreNuevoRef
        Ot.b01 = ""
        Ot.b02 = ""
        Ot.b03 = ""
        alsOtrosRef.Add(Ot)

        'ahora guarda de una vez la als modificada
        FS = New FileStream(strArchivoIndiceDeOtrosReferidores, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRef
            BW.Write(est.a01NumeroID)
            BW.Write(est.a02Nombre)
            BW.Write(est.b01)
            BW.Write(est.b02)
            BW.Write(est.b03)
        Next
        FS.Close()
        BW.Close()

        'borra el filtro y muestra todo
        subLIMPIApanelNUEVAreferidaPorOtro()
        subNUEVAMuestraListaDeOtrosRef()


    End Sub

    Private Sub botNUEVAeditaReferidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNUEVAeditaReferidor.Click
        Dim FS As FileStream
        Dim BW As BinaryWriter

        'primero identifica al otro referidor seleccionado...
        Dim intIndiceLocal = ListBoxNUEVAotros.SelectedIndex
        Dim estOtroReflocal As Form1.TablaDeOtrosReferidores = alsOtrosRefFiltrados(intIndice)

        'obtiene su ID
        Dim intIDdelOtroRefLocal = CType(estOtroReflocal.a01NumeroID, Integer) 'ya tengo la posicion en la als completa del elemento q debe ser cambiado

        'crea el mensaje
        Dim strMensaje = "Introduce el nuevo nombre para identificar a este Referidor..." & vbCrLf & "Actualmente: " & estOtroReflocal.a02Nombre & vbCrLf

        Dim strNuevoNombreDelReferidor = InputBox(strMensaje, "Edición de Referidores...")

        If strNuevoNombreDelReferidor <> "" Then
            'se introdujo algo
            estOtroReflocal.a02Nombre = strNuevoNombreDelReferidor 'sustituye el nombre. lo demas queda igual

            alsOtrosRef.RemoveAt(intIDdelOtroRefLocal) 'remueve los datos viejos de la als principal
            alsOtrosRef.Insert(intIDdelOtroRefLocal, estOtroReflocal) 'incluye el est con los datos nuevos

            'ahora guarda de una vez la als modificada
            FS = New FileStream(strArchivoIndiceDeOtrosReferidores, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRef
                BW.Write(est.a01NumeroID)
                BW.Write(est.a02Nombre)
                BW.Write(est.b01)
                BW.Write(est.b02)
                BW.Write(est.b03)
            Next
            FS.Close()
            BW.Close()

            'borra el filtro y muestra todo
            subLIMPIApanelNUEVAreferidaPorOtro()
            subNUEVAMuestraListaDeOtrosRef()
        Else
            'no escribio nada
            MsgBox("No se realizaron cvambios, no se recibió ningún dato", MsgBoxStyle.Information, "No hubo Datos")
            'borra el filtro y muestra todo
            subLIMPIApanelNUEVAreferidaPorOtro()
            subNUEVAMuestraListaDeOtrosRef()

        End If

    End Sub

#End Region


    Private Sub subACTUALIZAseleccionAcudioSola()
        'apaga y limpia los datos en los paneles
        subLIMPIApanelACTUALIZAreferidaPorPaciente()
        subLIMPIApanelACTUALIZAreferidaPorOtro()
        PanelACTUALIZAreferidaPorPaciente.Enabled = False
        PanelACTUALIZAreferidaPorOtro.Enabled = False
        'carga las variables publicas con los datos
        Form1.strTipoDeReferidor = "Sola"
        Form1.strReferidor = "Acudió expontáneamente"
        Form1.strNumeroDelReferidor = ""
        'prende el boton de aceptar
        botAceptar.Enabled = True
    End Sub



    Private Sub subACTUALIZAseleccionReferidaPorPaciente()

        'apaga y limpia los datos en el panel otros
        subLIMPIApanelACTUALIZAreferidaPorOtro()
        PanelACTUALIZAreferidaPorOtro.Enabled = False
        'limpia y prende el panel de seleccion por paciente
        subLIMPIApanelACTUALIZAreferidaPorPaciente() 'aca el filto se pona en blanco
        PanelACTUALIZAreferidaPorPaciente.Enabled = True

        'muestra la lista de paciente, como el filtro esta en blanco se mostraran todas
        subACTUALIZAMuestraListaDePacientes()

    End Sub

    Private Sub subLIMPIApanelACTUALIZAreferidaPorPaciente()


        ListBoxACTUALIZApacientes.Items.Clear()
        labACTUALIZAlistadoPacientes.Text = "Listado de Pacientes: (0)"
        labACTUALIZApacienteSeleccionada.Text = ""
        ListBoxACTUALIZAreferidasPorPaciente.Items.Clear()
        strFiltro = ""
        txtACTUALIZApacientesFiltro.Clear() 'esto dispara el muestra lista de pates si esta seleccionado....

    End Sub

    Private Sub subACTUALIZAMuestraListaDePacientes()

        'limpia el list box para actualizar lista
        ListBoxACTUALIZApacientes.Items.Clear()
        alsPacientesFiltradas.Clear()


        If strFiltro = "" Then
            'los muestra todos
            For Each est As Form1.BaseDatosIndiceHistorias In Form1.Historias
                'OK LA CADENA ESTA ACA LA muestra
                ListBoxACTUALIZApacientes.Items.Add(est.NombrePaciente)
                alsPacientesFiltradas.Add(est)
            Next
        Else
            'se muestran las q concuerden
            strFiltro = strFiltro.ToUpper
            For Each est As Form1.BaseDatosIndiceHistorias In Form1.Historias
                If est.NombrePaciente.ToUpper.Contains(strFiltro) Then
                    'OK LA CADENA ESTA ACA LA muestra
                    ListBoxACTUALIZApacientes.Items.Add(est.NombrePaciente)
                    alsPacientesFiltradas.Add(est)
                End If
            Next
        End If

        'muestra cuantos llegaron luego del filtro
        labACTUALIZAlistadoPacientes.Text = "Listado de Pacientes: (" & alsPacientesFiltradas.Count.ToString & ")"

        'apaga el boton aceptar espera que se seleccione a la paciente para luego prender el boton aceptar
        botAceptar.Enabled = False

        'le da foco al filtro
        txtACTUALIZApacientesFiltro.Focus()

    End Sub

    Private Sub txtACTUALIZApacientesFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtACTUALIZApacientesFiltro.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtACTUALIZApacientesFiltro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtACTUALIZApacientesFiltro.TextChanged
        'filtra la lista de las pacientes si esta seleccionado
        If radACTUALIZAreferidaPorPaciente.Checked = True Then
            strFiltro = txtACTUALIZApacientesFiltro.Text
            subACTUALIZAMuestraListaDePacientes()
        End If
    End Sub

    Private Sub ListBoxACTUALIZApacientes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxACTUALIZApacientes.SelectedIndexChanged
        If ListBoxACTUALIZApacientes.SelectedIndex > -1 Then


            'busca el indice y carga el est en memoria
            intIndice = ListBoxACTUALIZApacientes.SelectedIndex
            estPacienteReferidoraSel = alsPacientesFiltradas(intIndice)

            'revisa q no haya seleccionado asimisma
            If Form1.PSstrNumeroHistoriaSeleccionada = estPacienteReferidoraSel.NumeroHistoria Then
                MsgBox("No puedes seleccionar a la misma paciente como referidora...", MsgBoxStyle.Information, "Referencia Inválida")
                subLIMPIApanelACTUALIZAreferidaPorPaciente()
                subACTUALIZAMuestraListaDePacientes()
                Exit Sub
            End If

            'si llego aca esta bien prende el boton aceptar

            'muestra la paciente en el label
            labACTUALIZApacienteSeleccionada.Text = estPacienteReferidoraSel.NombrePaciente
            'busca el archivo de referencias de esta paciente para obtener la als con las otras ptes referidas de esta referidora (si las jay)
            subACTUALIZAbuscaArchivoDeReferenciasPtes()
            'ahora no importa si esta vacia o con algunas referidas previas añado esta paciente como referida
            subACTUALIZAañadeLaPacienteActualComoReferidaDeEstaPacienteRef()
            'queda lista la als para ser grabada si se acepta

            'carga las variables publicas con los datos
            Form1.strTipoDeReferidor = "Pte"
            Form1.strReferidor = estPacienteReferidoraSel.NombrePaciente
            Form1.strNumeroDelReferidor = estPacienteReferidoraSel.NumeroHistoria
            'prende el boton de aceptar
            botAceptar.Enabled = True

        End If
    End Sub

    Private Sub subACTUALIZAbuscaArchivoDeReferenciasPtes()
        'construye el nombre del archivo segun se selecciono
        strArchivoDeReferenciaPtes = Form1.PSstrPathHistoriasSinPrefijo & "\" & estPacienteReferidoraSel.NumeroHistoria.Substring(0, 5) & "\" & estPacienteReferidoraSel.NumeroHistoria & "-Referidas.dat"

        'comprueba si existe
        If File.Exists(strArchivoDeReferenciaPtes) Then
            'existe lo lee y carga los datos en la alsOtrasReferidasPorPte
            subACTUALIZAleeArchivoDeReferenciasPtes()
        Else
            'no existe lo muestra de una vez en el listbox de otras referidas
            ListBoxACTUALIZAreferidasPorPaciente.Items.Clear()
            ListBoxACTUALIZAreferidasPorPaciente.Items.Add("No ha referido a nadie más")
            'limpia la als dependiente
            alsOtrasReferidasPorPte.Clear()
        End If

    End Sub

    Private Sub subACTUALIZAleeArchivoDeReferenciasPtes()
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim REF As Form1.TablaDeReferidas
        Dim C As Integer

        'inicializa la als de otras pacientes referidas
        alsOtrasReferidasPorPte.Clear()

        'ya esta comprobado q existe
        FS = New FileStream(strArchivoDeReferenciaPtes, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        ' Read todo
        C = BR.PeekChar
        While FS.Position < FS.Length
            REF = Nothing
            REF.a01NumeroHistoria = BR.ReadString
            REF.a02Nombre = BR.ReadString
            REF.a03Cedula = BR.ReadString
            REF.a04FechaDeReferenciaSDS = BR.ReadString
            REF.b01 = BR.ReadString
            REF.b02 = BR.ReadString


            ''las incluye en la lista de otras referidas
            'alsOtrasReferidasPorPte.Add(REF)

            'las incluye en la lista de otras referidas siempre q no esten ya...
            If Form1.PSstrPacienteSeleccionadaNombre <> REF.a02Nombre Then
                alsOtrasReferidasPorPte.Add(REF)
            End If

        End While

        'cierra la vaina
        BR.Close()
        FS.Close()

        'ahora muestra los datos en el list box
        If alsOtrasReferidasPorPte.Count > 0 Then
            'ok el archivo contiene alguna referida la muestra
            ListBoxACTUALIZAreferidasPorPaciente.Items.Clear()
            'ordena la lista por fecha de referencia
            Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorPte _
                                       Order By CType(est.a04FechaDeReferenciaSDS, Date) _
                                       Select est
            'las muestra ordenadas en el list box
            For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                ListBoxACTUALIZAreferidasPorPaciente.Items.Add("El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre)
            Next
        Else
            'el archivo existe pero esta vacio se debe haber actualizado qu7itandosele su unica referida en ese momento se dice en el listbox
            ListBoxACTUALIZAreferidasPorPaciente.Items.Clear()
            ListBoxACTUALIZAreferidasPorPaciente.Items.Add("No ha referido a nadie más")
            'limpia la als dependiente
            alsOtrasReferidasPorPte.Clear()
        End If


    End Sub

    Private Sub subACTUALIZAañadeLaPacienteActualComoReferidaDeEstaPacienteRef()

        'la als ya tiene los datos hasta aca, puede estar en blano y esta ser su 1ra o ya haber otras ptes ref
        Dim est As Form1.TablaDeReferidas
        est = Nothing

        'cargo los datos de la pte actual en la est para añadirla a las referidas de esta pte ref
        est.a01NumeroHistoria = Form1.PSstrNumeroHistoriaSeleccionada
        est.a02Nombre = Form1.PSstrPacienteSeleccionadaNombre
        est.a03Cedula = Form1.PSstrPacienteSeleccionadaCedula
        'debe revisar desde cuando es pte si no hay agenda propia entonces la pone a hoy
        subAveriguaDesdeCuandoEsPte()
        est.a04FechaDeReferenciaSDS = strPteDesdeSDS
        est.b01 = ""
        est.b02 = ""

        'la añade
        alsOtrasReferidasPorPte.Add(est)

        'queda lista para ser guardada si se acepta....

    End Sub

    Private Sub subACTUALIZAGuardaArchivoDeReferidasPorEstaPteRef()
        'variables de control de IO
        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(strArchivoDeReferenciaPtes, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeReferidas In alsOtrasReferidasPorPte
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04FechaDeReferenciaSDS)
            BW.Write(est.b01)
            BW.Write(est.b02)
        Next
        FS.Close()
        BW.Close()
    End Sub






    Private Sub subACTUALIZAseleccionReferidaPorOtro()
        'apaga y limpia los datos en el panel pacientes
        subLIMPIApanelACTUALIZAreferidaPorPaciente()
        PanelACTUALIZAreferidaPorPaciente.Enabled = False
        'limpia y prende el panel de seleccion por paciente
        subLIMPIApanelACTUALIZAreferidaPorOtro()
        PanelACTUALIZAreferidaPorOtro.Enabled = True

        'muestra la lista de otros referidores, como el filtro esta en blanco se mostraran todos
        subACTUALIZAMuestraListaDeOtrosRef()

    End Sub

    Private Sub subLIMPIApanelACTUALIZAreferidaPorOtro()
        ListBoxACTUALIZAotros.Items.Clear()
        labACTUALIZAListadoOtros.Text = "Listado de Otros Referidores: (0)"
        labACTUALIZAotroSeleccionada.Text = ""
        ListBoxACTUALIZAreferidasPorOtro.Items.Clear()
        txtACTUALIZAotrosFiltro.Clear()
        strFiltro = ""
    End Sub

    Private Sub subACTUALIZAMuestraListaDeOtrosRef()

        'limpia el list box para actualizar lista
        ListBoxACTUALIZAotros.Items.Clear()
        alsOtrosRefFiltrados.Clear()


        If strFiltro = "" Then
            'los muestra todos
            For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRef
                ListBoxACTUALIZAotros.Items.Add(est.a02Nombre)
                alsOtrosRefFiltrados.Add(est)
            Next
        Else
            'se muestran las q concuerden
            strFiltro = strFiltro.ToUpper
            For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRef
                If est.a02Nombre.ToUpper.Contains(strFiltro) Then
                    'OK LA CADENA ESTA ACA LA muestra
                    ListBoxACTUALIZAotros.Items.Add(est.a02Nombre)
                    alsOtrosRefFiltrados.Add(est)
                End If
            Next
        End If

        'muestra cuantos llegaron luego del filtro
        labACTUALIZAListadoOtros.Text = "Listado de Otros Referidores: (" & alsOtrosRefFiltrados.Count.ToString & ")"

        'apaga el boton aceptar espera que se seleccione a la paciente para luego prender el boton aceptar
        botAceptar.Enabled = False
        botACTUALIZAeditaReferidor.Enabled = False

        'le da foco al filtro
        txtACTUALIZAotrosFiltro.Focus()

    End Sub

    Private Sub txtACTUALIZAotrosFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtACTUALIZAotrosFiltro.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or Char.IsWhiteSpace(c)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtACTUALIZAotrosFiltro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtACTUALIZAotrosFiltro.TextChanged
        'filtra la lista de las pacientes si esta seleccionado
        If radACTUALIZAreferidaPorOtro.Checked = True Then
            strFiltro = txtACTUALIZAotrosFiltro.Text
            subACTUALIZAMuestraListaDeOtrosRef()
        End If
    End Sub

    Private Sub ListBoxACTUALIZAotros_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxACTUALIZAotros.SelectedIndexChanged
        If ListBoxACTUALIZAotros.SelectedIndex > -1 Then


            'busca el indice y carga el est en memoria
            intIndice = ListBoxACTUALIZAotros.SelectedIndex
            estOtroRefSel = alsOtrosRefFiltrados(intIndice)

            'muestra la paciente en el label
            labACTUALIZAotroSeleccionada.Text = estOtroRefSel.a02Nombre
            'busca el archivo de referencias de estE REFERIDOR para obtener la als con las otras ptes referidas de esta referidora (si las jay)
            subACTUALIZABuscaArchivoDeReferenciasOtros()
            'ahora no importa si esta vacia o con algunas referidas previas añado esta paciente como referida
            subACTUALIZAAñadeLaPacienteActualComoReferidaDeEsteOtroRef()
            'queda lista la als para ser grabada si se acepta

            'carga las variables publicas con los datos
            Form1.strTipoDeReferidor = "Otro"
            Form1.strReferidor = estOtroRefSel.a02Nombre
            Form1.strNumeroDelReferidor = estOtroRefSel.a01NumeroID
            'prende el boton de aceptar
            botAceptar.Enabled = True
            botACTUALIZAeditaReferidor.Enabled = True

        End If
    End Sub

    Private Sub subACTUALIZABuscaArchivoDeReferenciasOtros()
        'construye el nombre del archivo segun se selecciono
        strArchivoDeReferenciaOtros = Form1.PSstrPathHistoriasSinPrefijo & "\OtrosReferidores\" & estOtroRefSel.a01NumeroID.PadLeft(4, "0"c) & "-Referidas.dat"

        'comprueba si existe
        If File.Exists(strArchivoDeReferenciaOtros) Then
            'existe lo lee y carga los datos en la als
            subACTUALIZALeeArchivoDeReferenciasOtros()
        Else
            'no existe lo muestra de una vez en el listbox de otras referidas
            ListBoxACTUALIZAreferidasPorOtro.Items.Clear()
            ListBoxACTUALIZAreferidasPorOtro.Items.Add("No ha referido a nadie más")
            'limpia la als dependiente
            alsOtrasReferidasPorOtroRef.Clear()
        End If

    End Sub

    Private Sub subACTUALIZALeeArchivoDeReferenciasOtros()
        Dim BR As BinaryReader
        Dim FS As FileStream
        Dim REF As Form1.TablaDeReferidas
        Dim C As Integer

        'inicializa la als de otras pacientes referidas
        alsOtrasReferidasPorOtroRef.Clear()

        'ya esta comprobado q existe
        FS = New FileStream(strArchivoDeReferenciaOtros, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        ' Read todo
        C = BR.PeekChar
        While FS.Position < FS.Length
            REF = Nothing
            REF.a01NumeroHistoria = BR.ReadString
            REF.a02Nombre = BR.ReadString
            REF.a03Cedula = BR.ReadString
            REF.a04FechaDeReferenciaSDS = BR.ReadString
            REF.b01 = BR.ReadString
            REF.b02 = BR.ReadString

            'las incluye en la lista de otras referidas siempre q no esten ya...
            If Form1.PSstrPacienteSeleccionadaNombre <> REF.a02Nombre Then
                alsOtrasReferidasPorOtroRef.Add(REF)
            End If

        End While

        'cierra la vaina
        BR.Close()
        FS.Close()

        'ahora muestra los datos en el list box
        If alsOtrasReferidasPorOtroRef.Count > 0 Then
            'el archivo no estaba vacio muestra las referidas
            ListBoxACTUALIZAreferidasPorOtro.Items.Clear()
            'ordena la lista por fecha de referencia
            Dim alsReferidasPorFecha = From est As Form1.TablaDeReferidas In alsOtrasReferidasPorOtroRef _
                                       Order By CType(est.a04FechaDeReferenciaSDS, Date) _
                                       Select est
            'las muestra ordenadas en el list box
            For Each est As Form1.TablaDeReferidas In alsReferidasPorFecha
                ListBoxACTUALIZAreferidasPorOtro.Items.Add("El " & est.a04FechaDeReferenciaSDS & " a " & est.a02Nombre)
            Next
        Else
            'el archivo existe pero ta vacio se debe haber actualizado quitandosele su referida lo dice en el listbox
            ListBoxACTUALIZAreferidasPorOtro.Items.Clear()
            ListBoxACTUALIZAreferidasPorOtro.Items.Add("No ha referido a nadie más")
            'limpia la als dependiente
            alsOtrasReferidasPorOtroRef.Clear()
        End If




    End Sub

    Private Sub subACTUALIZAAñadeLaPacienteActualComoReferidaDeEsteOtroRef()

        'la als ya tiene los datos hasta aca, puede estar en blano y esta ser su 1ra o ya haber otras ptes ref
        Dim est As Form1.TablaDeReferidas
        est = Nothing

        'cargo los datos de la pte actual en la est para añadirla a las referidas de estE OTRO REF
        est.a01NumeroHistoria = Form1.PSstrNumeroHistoriaSeleccionada
        est.a02Nombre = Form1.PSstrPacienteSeleccionadaNombre
        est.a03Cedula = Form1.PSstrPacienteSeleccionadaCedula
        subAveriguaDesdeCuandoEsPte()
        est.a04FechaDeReferenciaSDS = strPteDesdeSDS
        est.b01 = ""
        est.b02 = ""

        'la añade
        alsOtrasReferidasPorOtroRef.Add(est)

        'queda lista para ser guardada si se acepta....

    End Sub

    Private Sub subACTUALIZAGuardaArchivoDeReferidasPorEsteOtroRef()
        'variables de control de IO
        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(strArchivoDeReferenciaOtros, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeReferidas In alsOtrasReferidasPorOtroRef
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04FechaDeReferenciaSDS)
            BW.Write(est.b01)
            BW.Write(est.b02)
        Next
        FS.Close()
        BW.Close()
    End Sub

    Private Sub botACTUALIZAnuevoReferidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botACTUALIZAnuevoReferidor.Click
        Dim FS As FileStream
        Dim BW As BinaryWriter

        'consigue el nomnbre nuevo
        Dim strNombreNuevoRef = InputBox("Intoduce el Nombre y Apellido del Referidor...", "Incluyendo un nuevo Referidor")

        'revisa q no este en la als para q no este duplicado
        For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRef
            If est.a02Nombre = strNombreNuevoRef Then
                'esta incluido ya
                MsgBox("Este referidor ya se encuentra incluido en la Base de Datos, selecciónalo de la lista...", MsgBoxStyle.Information, "Referidor ya incluido...")
                subACTUALIZAMuestraListaDeOtrosRef()
                Exit Sub
            End If
        Next

        'si llego hasta aca es q se puede incluir carga la est y la añade a la als
        Dim Ot As Form1.TablaDeOtrosReferidores
        Ot = Nothing
        Ot.a01NumeroID = alsOtrosRef.Count.ToString
        Ot.a02Nombre = strNombreNuevoRef
        Ot.b01 = ""
        Ot.b02 = ""
        Ot.b03 = ""
        alsOtrosRef.Add(Ot)

        'ahora guarda de una vez la als modificada
        FS = New FileStream(strArchivoIndiceDeOtrosReferidores, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRef
            BW.Write(est.a01NumeroID)
            BW.Write(est.a02Nombre)
            BW.Write(est.b01)
            BW.Write(est.b02)
            BW.Write(est.b03)
        Next
        FS.Close()
        BW.Close()

        'borra el filtro y muestra todo
        subLIMPIApanelACTUALIZAreferidaPorOtro()
        subACTUALIZAMuestraListaDeOtrosRef()


    End Sub

    Private Sub botACTUALIZAeditaReferidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botACTUALIZAeditaReferidor.Click
        Dim FS As FileStream
        Dim BW As BinaryWriter

        'primero identifica al otro referidor seleccionado...
        Dim intIndiceLocal = ListBoxACTUALIZAotros.SelectedIndex
        Dim estOtroReflocal As Form1.TablaDeOtrosReferidores = alsOtrosRefFiltrados(intIndice)

        'obtiene su ID
        Dim intIDdelOtroRefLocal = CType(estOtroReflocal.a01NumeroID, Integer) 'ya tengo la posicion en la als completa del elemento q debe ser cambiado

        'crea el mensaje
        Dim strMensaje = "Introduce el nuevo nombre para identificar a este Referidor..." & vbCrLf & "Actualmente: (" & estOtroReflocal.a02Nombre & ")" & vbCrLf

        Dim strNuevoNombreDelReferidor = InputBox(strMensaje, "Edición de Referidores...")

        If strNuevoNombreDelReferidor <> "" Then
            'se introdujo algo
            estOtroReflocal.a02Nombre = strNuevoNombreDelReferidor 'sustituye el nombre. lo demas queda igual

            alsOtrosRef.RemoveAt(intIDdelOtroRefLocal) 'remueve los datos viejos de la als principal
            alsOtrosRef.Insert(intIDdelOtroRefLocal, estOtroReflocal) 'incluye el est con los datos nuevos

            'ahora guarda de una vez la als modificada
            FS = New FileStream(strArchivoIndiceDeOtrosReferidores, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            For Each est As Form1.TablaDeOtrosReferidores In alsOtrosRef
                BW.Write(est.a01NumeroID)
                BW.Write(est.a02Nombre)
                BW.Write(est.b01)
                BW.Write(est.b02)
                BW.Write(est.b03)
            Next
            FS.Close()
            BW.Close()

            'borra el filtro y muestra todo
            subLIMPIApanelACTUALIZAreferidaPorOtro()
            subACTUALIZAMuestraListaDeOtrosRef()
        Else
            'no escribio nada
            MsgBox("No se realizaron cvambios, no se recibió ningún dato", MsgBoxStyle.Information, "No hubo Datos")
            'borra el filtro y muestra todo
            subLIMPIApanelACTUALIZAreferidaPorOtro()
            subACTUALIZAMuestraListaDeOtrosRef()

        End If

    End Sub



    Private Sub botSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalir.Click
        If booSeModificaronDatos = True Then
            'se han hecho cambios que no se han guardado
            Dim Reply = MsgBox("Se han realizado cambios que no han sido guardados, para confirmar salida presiona ACEPTAR...", MsgBoxStyle.OkCancel, "Confirma salida...")
            If Reply = Windows.Forms.DialogResult.OK Then
                'se confirmo sale pal coño
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Else
            'no se han realizado cambios
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click

        If radNUEVAacudioSola.Checked = True Then
            'acudio sola no hay q hacer nada mas
            Me.DialogResult = Windows.Forms.DialogResult.OK

        ElseIf radNUEVAreferidaPorPaciente.Checked = True Then
            'se le debe guardar el archivo de las ptes referidas por esta pte ref
            subNUEVAGuardaArchivoDeReferidasPorEstaPteRef()
            Me.DialogResult = Windows.Forms.DialogResult.OK

        ElseIf radNUEVAreferidaPorOtro.Checked = True Then
            'se le debe guardar el archivo de las ptes referidas por este otro ref
            subNUEVAGuardaArchivoDeReferidasPorEsteOtroRef()
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Else
            ' SE PRESIONO UN RAD DE ACTUALIZAR, REVISA PRIMERO SI SE DEBE GRABAR UNA ALS RECORTADA PORQ ALGUIEN DEJO DE REFERIR A LA PTE
            If booSeDebeActualizarPteReferidoraAntigua = True Then
                'se debe actualizar a una pte referidora anigua q dejo de serlo de esta pte.
                subGuardarArchivoDeReferenciaPtesAntigua()
            ElseIf booSeDebeActualizarOtroReferidorAntigua = True Then
                'se debe actualizar a un otro ref antiguo q dejo de ser referidor de esta pte
                subGuardarArchivoDeReferenciaOtrosAntigua()
            End If

            'ahora q ya se elimino lo antigua añado lo nuevo
            If radACTUALIZAacudioSola.Checked = True Then
                'acudio sola no hay q añadirle nada a nadie
                Me.DialogResult = Windows.Forms.DialogResult.OK

            ElseIf radACTUALIZAreferidaPorPaciente.Checked = True Then
                'se le debe guardar el archivo de las ptes referidas por esta pte referidora
                subACTUALIZAGuardaArchivoDeReferidasPorEstaPteRef()
                Me.DialogResult = Windows.Forms.DialogResult.OK

            ElseIf radACTUALIZAreferidaPorOtro.Checked = True Then
                'se le debe guardar el archivo de las ptes referidas por este otro referidor
                subactualizaGuardaArchivoDeReferidasPorEsteOtroRef()
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        End If


    End Sub

    Private Sub subGuardarArchivoDeReferenciaPtesAntigua()
        'variables de control de IO
        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(strArchivoDeReferenciaPtesAntigua, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeReferidas In alsOtrasReferidasPorPteAntigua
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04FechaDeReferenciaSDS)
            BW.Write(est.b01)
            BW.Write(est.b02)
        Next
        FS.Close()
        BW.Close()

    End Sub

    Private Sub subGuardarArchivoDeReferenciaOtrosAntigua()
        'variables de control de IO
        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(strArchivoDeReferenciaOtrosAntigua, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeReferidas In alsOtrasReferidasPorOtroRefAntigua
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04FechaDeReferenciaSDS)
            BW.Write(est.b01)
            BW.Write(est.b02)
        Next
        FS.Close()
        BW.Close()
    End Sub








   
End Class