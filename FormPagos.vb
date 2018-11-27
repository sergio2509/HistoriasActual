Imports System.IO

Public Class FormPagos

    'variables del entorno
    Dim booSeModificaronDatos As Boolean = False
    Dim datFechaSeleccionada As Date
    Dim intAnoSeleccionado As Integer
    Dim intMesSeleccionado As Integer
    Dim intDiaSeleccionado As Integer
    Dim booEsUnNuevoPago As Boolean

    'variables de la tabla
    Dim strIndice As String
    Dim datFecha As Date
    Dim strPagador As String
    Dim strMedioDePago As String
    Dim strBanco As String
    Dim strNumeroReferencia As String
    Dim strFacturero As String
    Dim strFactura As String
    Dim decRetencionISLR As Decimal
    Dim decRetencionADM As Decimal
    Dim decRetAdm01, decRetAdm02, decRetAdm03 As Decimal
    Dim decRetencionOTROS As Decimal
    Dim decRetOtras01, decRetOtras02, decRetOtras03 As Decimal
    Dim decMontoNetoPagado As Decimal
    Dim decTotalPago As Decimal
    Dim booIncluidoEnFacturacion As Boolean
    Dim strNotas As String
    Dim strRif As String

    Dim intNumerodePagos As Integer
    Dim strEncabezadoNombre As String
    Dim strEncabezadoTipoPago As String

    Dim strFechaOriginal As String
    Dim strPagadorOriginal As String
    Dim strMontoNetoPagadoOriginal As String
    Dim strNumeroReferenciaOriginal As String

   

    'variables de Nombres de archivo
    Dim strArchivoPagoDia As String
    Dim strArchivoPagoMes As String
    Dim strArchivoPagoAño As String

    'variables de directorios y paths
    Dim strPathPago As String
    Dim strPathPagosub As String
    Dim booExistePathPago As Boolean
    Dim booExistePathPagosub As Boolean

    'variables de tabla
    Dim estPago As Form1.TablaDePagos
    Dim alsPagosMes As New ArrayList
    Dim alsPagosDia As New ArrayList
    Dim alsPagosAno As New ArrayList

    'variables de control de IO
    Dim FS As FileStream
    Dim BW As BinaryWriter
    Dim BR As BinaryReader
  
    Dim C As Integer


    Private Sub FormIntervenciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'inicializa nombre de variables y valores
        Inicializa()
        'construye nombres
        ConstruyeNombres()
        'borra todo
        LimpiaTodo()
        'verifica la fecha
        VerificaFecha()
    End Sub

    Private Sub Inicializa()

        'situa el calendario en la fecha de hoy
        Calendario.SelectionStart = Today
        datFechaSeleccionada = Calendario.SelectionStart

        'verifica la existencia de la carpeta principal si no existe la crea
        strPathPago = Form1.PathPago
        If Directory.Exists(strPathPago) = False Then
            Directory.CreateDirectory(strPathPago)
        End If

    End Sub

    Private Sub ConstruyeNombres()
        intAnoSeleccionado = datFechaSeleccionada.Year
        intMesSeleccionado = datFechaSeleccionada.Month
        intDiaSeleccionado = datFechaSeleccionada.Day

        strPathPagosub = strPathPago & "\" & intAnoSeleccionado.ToString
        If Directory.Exists(strPathPagosub) = True Then
            booExistePathPagosub = True
        Else
            booExistePathPagosub = False
        End If

        strArchivoPagoDia = strPathPagosub & "\Pagos-" & intAnoSeleccionado.ToString & intMesSeleccionado.ToString.PadLeft(2, "0"c) & intDiaSeleccionado.ToString.PadLeft(2, "0"c) & ".dat"
        strArchivoPagoMes = strPathPagosub & "\Pagos-" & intAnoSeleccionado.ToString & intMesSeleccionado.ToString.PadLeft(2, "0"c) & ".dat"
        strArchivoPagoAño = strPathPagosub & "\Pagos-" & intAnoSeleccionado.ToString & ".dat"
    End Sub

    Private Sub LimpiaTodo()

        'limpia labs
        labFecha.Text = ""
        labTotalPago.Text = ""

        'Limpia los text boxes
        txtBanco.Clear()
        txtFacturaAsociada.Clear()
        txtFacturero.Clear()
        txtMedioDePago.Clear()
        txtMontoNetoPagado.Clear()
        txtNotas.Clear()
        txtNumeroReferencia.Clear()
        txtPagador.Clear()
        txtRif.Clear()
        txtRetencionADM01.Clear()
        txtRetencionADM02.clear()
        txtRetencionADM03.clear()
        txtRetencionISLR.Clear()
        txtRetencionOtras01.Clear()
        txtRetencionOtras02.clear()
        txtRetencionOtras03.clear()

        'chklist
        chkIncluidoEnFacturacion.Checked = False


        'borra el list box 
        ListBoxPagos.Items.Clear()

        'pon la variable de se modifico la vaina a false
        booSeModificaronDatos = False

        'acomoda los botones de salida y aceptar
        botSalir.Text = "Salir"
        botAceptar.Enabled = False
        botCancelar.Enabled = False

        GroupBox1.Enabled = False
        botElimina.Enabled = False

    End Sub

    Private Sub LimpiaSoloTextBoxes()
        'limpia labs
        labFecha.Text = ""
        labTotalPago.Text = ""

        'Limpia los text boxes
        txtBanco.Clear()
        txtFacturaAsociada.Clear()
        txtFacturero.Clear()
        txtMedioDePago.Clear()
        txtMontoNetoPagado.Clear()
        txtNotas.Clear()
        txtNumeroReferencia.Clear()
        txtPagador.Clear()
        txtRif.Clear()
        txtRetencionADM01.Clear()
        txtRetencionADM02.Clear()
        txtRetencionADM03.Clear()
        txtRetencionISLR.Clear()
        txtRetencionOtras01.Clear()
        txtRetencionOtras02.Clear()
        txtRetencionOtras03.Clear()

        'chklist
        chkIncluidoEnFacturacion.Checked = False
    End Sub

    Private Sub Calendario_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateSelected
        If Calendario.SelectionStart > Today Then
            MsgBox("La fecha seleccionada se encuentra en el Futuro, se seleccionará automáticamente la fecha actual...", MsgBoxStyle.Information, "Registro de Pagos")
            Calendario.SelectionStart = Today
        End If
        'actualiza la fecha seleccionada
        datFechaSeleccionada = Calendario.SelectionStart
        'construye los nombres de archivo segun el dia seleccionado
        ConstruyeNombres()
        'ahora borra todos los datos metios
        LimpiaTodo()
        'verifica la fecha seleccionada y actua en consecuencia
        VerificaFecha()
    End Sub

    Private Sub Calendario_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Calendario.MouseDown

        'actualiza la fecha seleccionada
        datFechaSeleccionada = Calendario.SelectionStart
        'construye los nombres de archivo segun el dia seleccionado
        ConstruyeNombres()
        'ahora borra todos los datos metios
        LimpiaTodo()
        'verifica la fecha seleccionada y actua en consecuencia
        VerificaFecha()
    End Sub



    Private Sub VerificaFecha()
        'verifica la existencia de un archivo de intervenciones el dia seleccionado
        If File.Exists(strArchivoPagoDia) = True Then
            'existe el archivo, lo lee y muestra su encabezado en el list box
            LeeArchivoPAGOdia()

            'ahora muestra los encabezados en el list box
            For Each est As Form1.TablaDePagos In alsPagosDia
                Dim decPago = CType(est.a10decMontoNetoPagado, Decimal)
                Dim decTotal = CType(est.a11decTotalPago, Decimal)
                Dim decISLRret = CType(est.a07decRetencionISLR, Decimal)
                Dim decOtrasRet As Decimal
                decOtrasRet = CType(est.a08decRetencionADM, Decimal) + CType(est.a09decRetencionOTROS, Decimal)

                Dim strFact As String
                Dim strRef As String
                Dim linea As String

                If est.a06intFacturaAsociada = "-1" Or est.a06intFacturaAsociada = "" Then
                    strFact = "     "
                Else
                    strFact = est.a06intFacturaAsociada
                End If

                If est.a05strNumeroReferencia = "" Then
                    strRef = "        "
                Else
                    strRef = est.a05strNumeroReferencia
                End If

                linea = "#" & strFact.PadLeft(5, "0"c) & "       " & est.a02strPagador.PadRight(45, " "c) & "       "
                linea += est.a03strMedioDePago.PadRight(10, " "c) & "     #" & strRef.PadRight(8, "0"c) & "     "
                linea += FormatNumber(decPago, 2, , , TriState.True).PadLeft(11, " "c) & "   "
                linea += FormatNumber(decISLRret, 2, , , TriState.True).PadLeft(11, " "c) & "   "
                linea += FormatNumber(decOtrasRet, 2, , , TriState.True).PadLeft(11, " "c) & "     "
                linea += FormatNumber(decTotal, 2, , , TriState.True).PadLeft(11, " "c)

                If est.a12booIncluidoEnFacturacion = True Then
                    linea += " (I)"
                End If

                ListBoxPagos.Items.Add(linea)
            Next

            'acomoda el label del list box
            labPAGOdelaFecha.Text = "Pagos del día " & datFechaSeleccionada.ToLongDateString & ": (" & intNumerodePagos & ")"
            'añade finalmente la opcion de meter otra IQ
            ListBoxPagos.Items.Add("Anota un Pago nuevo...")
        Else
            'no existe el archivo, lo dice en el listbox 
            labPAGOdelaFecha.Text = "Pagos del día " & datFechaSeleccionada.ToLongDateString & ": No se ha registrado ninguno..."
            ListBoxPagos.Items.Add("Anota un Pago nuevo...")
        End If


        '000000000000000000000000000000000000000000000
        'parte de las fechas que tienen Pagos 

        Dim U As New ArrayList() 'FechasConConsultaMes
        Dim Fecha As Date
        Dim Fechas() As Date

        U.Clear()

        If File.Exists(strArchivoPagoMes) = True Then
            'existe un archivo de control de mes, lo lee
            FS = New FileStream(strArchivoPagoMes, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim Contador As Integer = -1
            C = BR.PeekChar
            While FS.Position < FS.Length
                estPago = Nothing
                ' Read fields and populate structure
                estPago.a00strIndice = BR.ReadString
                estPago.a01datFecha = BR.ReadString
                estPago.a02strPagador = BR.ReadString
                estPago.a03strMedioDePago = BR.ReadString
                estPago.a04strBanco = BR.ReadString
                estPago.a05strNumeroReferencia = BR.ReadString
                estPago.a06intFacturaAsociada = BR.ReadString
                estPago.a06bStrFacturero = BR.ReadString
                estPago.a07decRetencionISLR = BR.ReadString
                estPago.a08decRetencionADM = BR.ReadString
                estPago.a09decRetencionOTROS = BR.ReadString
                estPago.a10decMontoNetoPagado = BR.ReadString
                estPago.a11decTotalPago = BR.ReadString
                estPago.a12booIncluidoEnFacturacion = BR.ReadString
                estPago.a13strNotas = BR.ReadString
                estPago.a14Rif = BR.ReadString
                estPago.b01 = BR.ReadString
                estPago.b02 = BR.ReadString
                estPago.b03 = BR.ReadString
                estPago.b04 = BR.ReadString


                '0000000000000000000000000
                If IsDate(estPago.a01datFecha) Then
                    Fecha = CType(estPago.a01datFecha, Date)
                    U.Add(Fecha)
                End If

                Contador += 1
                C = BR.PeekChar
                '00000000000000000000000000000000000
            End While
            BR.Close()
            FS.Close()

            ReDim Fechas(Contador)
            'pone el array de fechas en negrita en el calendario
            Contador = -1
            For Each F As Date In U
                Contador += 1
                Fechas(Contador) = F
            Next

            Me.Calendario.BoldedDates = Fechas
            Me.Calendario.UpdateBoldedDates()
        End If

    End Sub

    Private Sub LeeArchivoPAGOdia()
        FS = New FileStream(strArchivoPagoDia, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim C As Integer
        alsPagosDia.Clear()
        intNumerodePagos = 0
        C = BR.PeekChar
        While FS.Position < FS.Length
            estPago = Nothing
            ' Read fields and populate structure
            estPago.a00strIndice = BR.ReadString
            estPago.a01datFecha = BR.ReadString
            estPago.a02strPagador = BR.ReadString
            estPago.a03strMedioDePago = BR.ReadString
            estPago.a04strBanco = BR.ReadString
            estPago.a05strNumeroReferencia = BR.ReadString
            estPago.a06intFacturaAsociada = BR.ReadString
            estPago.a06bStrFacturero = BR.ReadString
            estPago.a07decRetencionISLR = BR.ReadString
            estPago.a08decRetencionADM = BR.ReadString
            estPago.a09decRetencionOTROS = BR.ReadString
            estPago.a10decMontoNetoPagado = BR.ReadString
            estPago.a11decTotalPago = BR.ReadString
            estPago.a12booIncluidoEnFacturacion = BR.ReadString
            estPago.a13strNotas = BR.ReadString
            estPago.a14Rif = BR.ReadString
            estPago.b01 = BR.ReadString
            estPago.b02 = BR.ReadString
            estPago.b03 = BR.ReadString
            estPago.b04 = BR.ReadString


            alsPagosDia.Add(estPago)
            intNumerodePagos += 1
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub

    Private Sub LeeArchivoPAGOmes()
        FS = New FileStream(strArchivoPagoMes, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim C As Integer
        alsPagosMes.Clear()
        intNumerodePagos = 0
        C = BR.PeekChar
        While FS.Position < FS.Length
            estPago = Nothing
            ' Read fields and populate structure
            estPago.a00strIndice = BR.ReadString
            estPago.a01datFecha = BR.ReadString
            estPago.a02strPagador = BR.ReadString
            estPago.a03strMedioDePago = BR.ReadString
            estPago.a04strBanco = BR.ReadString
            estPago.a05strNumeroReferencia = BR.ReadString
            estPago.a06intFacturaAsociada = BR.ReadString
            estPago.a06bStrFacturero = BR.ReadString
            estPago.a07decRetencionISLR = BR.ReadString
            estPago.a08decRetencionADM = BR.ReadString
            estPago.a09decRetencionOTROS = BR.ReadString
            estPago.a10decMontoNetoPagado = BR.ReadString
            estPago.a11decTotalPago = BR.ReadString
            estPago.a12booIncluidoEnFacturacion = BR.ReadString
            estPago.a13strNotas = BR.ReadString
            estPago.a14Rif = BR.ReadString
            estPago.b01 = BR.ReadString
            estPago.b02 = BR.ReadString
            estPago.b03 = BR.ReadString
            estPago.b04 = BR.ReadString


            alsPagosMes.Add(estPago)
            intNumerodePagos += 1
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub

    Private Sub LeeArchivoPAGOaño()
        FS = New FileStream(strArchivoPagoAño, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim C As Integer
        alsPagosAno.Clear()
        intNumerodePagos = 0
        C = BR.PeekChar
        While FS.Position < FS.Length
            estPago = Nothing
            ' Read fields and populate structure
            estPago.a00strIndice = BR.ReadString
            estPago.a01datFecha = BR.ReadString
            estPago.a02strPagador = BR.ReadString
            estPago.a03strMedioDePago = BR.ReadString
            estPago.a04strBanco = BR.ReadString
            estPago.a05strNumeroReferencia = BR.ReadString
            estPago.a06intFacturaAsociada = BR.ReadString
            estPago.a06bStrFacturero = BR.ReadString
            estPago.a07decRetencionISLR = BR.ReadString
            estPago.a08decRetencionADM = BR.ReadString
            estPago.a09decRetencionOTROS = BR.ReadString
            estPago.a10decMontoNetoPagado = BR.ReadString
            estPago.a11decTotalPago = BR.ReadString
            estPago.a12booIncluidoEnFacturacion = BR.ReadString
            estPago.a13strNotas = BR.ReadString
            estPago.a14Rif = BR.ReadString
            estPago.b01 = BR.ReadString
            estPago.b02 = BR.ReadString
            estPago.b03 = BR.ReadString
            estPago.b04 = BR.ReadString


            alsPagosAno.Add(estPago)
            intNumerodePagos += 1
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub

    Private Sub EscribeArchivoPAGOdia()

        FS = New FileStream(strArchivoPagoDia, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDePagos In alsPagosDia
            BW.Write(est.a00strIndice)
            BW.Write(est.a01datFecha)
            BW.Write(est.a02strPagador)
            BW.Write(est.a03strMedioDePago)
            BW.Write(est.a04strBanco)
            BW.Write(est.a05strNumeroReferencia)
            BW.Write(est.a06intFacturaAsociada)
            BW.Write(est.a06bStrFacturero)
            BW.Write(est.a07decRetencionISLR)
            BW.Write(est.a08decRetencionADM)
            BW.Write(est.a09decRetencionOTROS)
            BW.Write(est.a10decMontoNetoPagado)
            BW.Write(est.a11decTotalPago)
            BW.Write(est.a12booIncluidoEnFacturacion)
            BW.Write(est.a13strNotas)
            BW.Write(est.a14Rif)
            BW.Write(est.b01)
            BW.Write(est.b02)
            BW.Write(est.b03)
            BW.Write(est.b04)

        Next
        FS.Close()
        BW.Close()
    End Sub

    Private Sub EscribeArchivoPAGOmes()

        FS = New FileStream(strArchivoPagoMes, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDePagos In alsPagosMes
            BW.Write(est.a00strIndice)
            BW.Write(est.a01datFecha)
            BW.Write(est.a02strPagador)
            BW.Write(est.a03strMedioDePago)
            BW.Write(est.a04strBanco)
            BW.Write(est.a05strNumeroReferencia)
            BW.Write(est.a06intFacturaAsociada)
            BW.Write(est.a06bStrFacturero)
            BW.Write(est.a07decRetencionISLR)
            BW.Write(est.a08decRetencionADM)
            BW.Write(est.a09decRetencionOTROS)
            BW.Write(est.a10decMontoNetoPagado)
            BW.Write(est.a11decTotalPago)
            BW.Write(est.a12booIncluidoEnFacturacion)
            BW.Write(est.a13strNotas)
            BW.Write(est.a14Rif)
            BW.Write(est.b01)
            BW.Write(est.b02)
            BW.Write(est.b03)
            BW.Write(est.b04)

        Next
        FS.Close()
        BW.Close()
    End Sub

    Private Sub EscribeArchivoPAGOaño()

        FS = New FileStream(strArchivoPagoAño, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDePagos In alsPagosAno
            BW.Write(est.a00strIndice)
            BW.Write(est.a01datFecha)
            BW.Write(est.a02strPagador)
            BW.Write(est.a03strMedioDePago)
            BW.Write(est.a04strBanco)
            BW.Write(est.a05strNumeroReferencia)
            BW.Write(est.a06intFacturaAsociada)
            BW.Write(est.a06bStrFacturero)
            BW.Write(est.a07decRetencionISLR)
            BW.Write(est.a08decRetencionADM)
            BW.Write(est.a09decRetencionOTROS)
            BW.Write(est.a10decMontoNetoPagado)
            BW.Write(est.a11decTotalPago)
            BW.Write(est.a12booIncluidoEnFacturacion)
            BW.Write(est.a13strNotas)
            BW.Write(est.a14Rif)
            BW.Write(est.b01)
            BW.Write(est.b02)
            BW.Write(est.b03)
            BW.Write(est.b04)

        Next
        FS.Close()
        BW.Close()
    End Sub

    Private Sub ListBoxPagos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxPagos.SelectedIndexChanged
        'una vez seleccionado añadir uno nuevo o modificar uno existente, apaga las partes de desplazamiento
        'apaga el list box para que no se pueda seleccionar otra IQ
        ListBoxPagos.Enabled = False
        'apaga el calendario para que no se pueda cambiar el dia
        Calendario.Enabled = False
        Calendario.ForeColor = System.Drawing.SystemColors.GrayText
        Calendario.TitleForeColor = System.Drawing.SystemColors.GrayText


        'ahora ve que fue lo que se escogio
        If ListBoxPagos.SelectedItem = "Anota un Pago nuevo..." Then
            'se va a añadir una intervencion a este dia (si se acepta claro...)
            booEsUnNuevoPago = True
            'pone un mensaje de orientacion
            labMensaje.Text = "Introduce los datos conocidos, después podrás añadir otros o modificarlos..."
            'limpia los text boxes
            LimpiaSoloTextBoxes()
            'prende el group box
            GroupBox1.Enabled = True
            'inicializa las variables
            strIndice = Now.ToShortDateString & "  " & Now.ToLongTimeString
            datFecha = datFechaSeleccionada
            strPagador = ""
            strMedioDePago = ""
            strBanco = ""
            strNumeroReferencia = ""
            strFactura = ""
            strFacturero = ""
            decRetencionISLR = 0
            decRetencionADM = 0
            decRetAdm01 = 0
            decRetAdm02 = 0
            decRetAdm03 = 0
            decRetencionOTROS = 0
            decRetOtras01 = 0
            decRetOtras02 = 0
            decRetOtras03 = 0
            decMontoNetoPagado = 0
            decTotalPago = 0
            booIncluidoEnFacturacion = False
            strNotas = ""
            strRif = ""


            'inicializa los chkbox
            chkIncluidoEnFacturacion.Checked = False

            'formatea la fecha
            labFecha.Text = datFecha.ToShortDateString

            'formatea los montos de efectivo a 0
            txtRetencionADM01.Text = FormatNumber(0, , , , TriState.True)
            txtRetencionADM02.Text = FormatNumber(0, , , , TriState.True)
            txtRetencionADM03.Text = FormatNumber(0, , , , TriState.True)
            txtRetencionISLR.Text = FormatNumber(0, , , , TriState.True)
            txtRetencionOtras01.Text = FormatNumber(0, , , , TriState.True)
            txtRetencionOtras02.Text = FormatNumber(0, , , , TriState.True)
            txtRetencionOtras03.Text = FormatNumber(0, , , , TriState.True)
            txtMontoNetoPagado.Text = FormatNumber(0, , , , TriState.True)
            labTotalPago.Text = FormatNumber(0, , , , TriState.True)

            'le da el foco al text box del pagador
            txtPagador.Focus()

            'acomoda los botones de salida y aceptar
            botSalir.Text = "Salir"
            botAceptar.Enabled = False
            booSeModificaronDatos = False
            'prende el boton cancelar para salir de la edicion
            botCancelar.Enabled = True


        Else
            'se esta seleccionando una intervencion existente, la lee y muestra...
            booEsUnNuevoPago = False
            'pone un mensaje de orientacion
            labMensaje.Text = "Modifica o añade nuevos datos o Elimina el Registro seleccionado..."
            'prende el boton de eliminar
            botElimina.Enabled = True

            Dim Indice As Integer
            Indice = ListBoxPagos.SelectedIndex
            estPago = alsPagosDia(Indice)

            'limpia los text boxes
            LimpiaSoloTextBoxes()

            'prende el group box
            GroupBox1.Enabled = True

            'inicializa las variables
            strIndice = estPago.a00strIndice
            datFecha = CType(estPago.a01datFecha, Date)
            strPagador = estPago.a02strPagador
            strMedioDePago = estPago.a03strMedioDePago
            strBanco = estPago.a04strBanco
            strNumeroReferencia = estPago.a05strNumeroReferencia
            strFactura = estPago.a06intFacturaAsociada
            strFacturero = estPago.a06bStrFacturero
            decRetencionISLR = CType(estPago.a07decRetencionISLR, Decimal)
            decRetencionADM = CType(estPago.a08decRetencionADM, Decimal)
            decRetAdm01 = decRetencionADM
            decRetAdm02 = 0
            decRetAdm03 = 0
            decRetencionOTROS = CType(estPago.a09decRetencionOTROS, Decimal)
            decRetOtras01 = decRetencionOTROS
            decRetOtras02 = 0
            decRetOtras03 = 0
            decMontoNetoPagado = CType(estPago.a10decMontoNetoPagado, Decimal)
            decTotalPago = CType(estPago.a11decTotalPago, Decimal)
            booIncluidoEnFacturacion = CType(estPago.a12booIncluidoEnFacturacion, Boolean)
            strNotas = estPago.a13strNotas
            strRif = estPago.a14Rif

            'muestra los datos en pantalla
            labFecha.Text = datFecha.ToShortDateString
            txtPagador.Text = strPagador
            txtRif.Text = strRif
            txtMedioDePago.Text = strMedioDePago
            txtBanco.Text = strBanco
            txtNumeroReferencia.Text = strNumeroReferencia
            txtFacturero.Text = strFacturero
            If strFactura <> "" Then
                txtFacturaAsociada.Text = strFactura.PadLeft(5, "0"c)
            End If

            If booIncluidoEnFacturacion = True Then
                chkIncluidoEnFacturacion.Checked = True
            Else
                chkIncluidoEnFacturacion.Checked = False
            End If

            'formatea los montos de efectivo
            txtRetencionADM01.Text = FormatNumber(decRetAdm01, , , , TriState.True)
            txtRetencionADM02.Text = FormatNumber(0, , , , TriState.True) 'cuando se selecciona de la lista siempre son 0 estos valores
            txtRetencionADM03.Text = FormatNumber(0, , , , TriState.True) 'solo sirven para no tener q subtotalizar cuando hay variso items
            txtRetencionISLR.Text = FormatNumber(decRetencionISLR, , , , TriState.True) ' se puedan poner cada uno en su linea y se suman automaticamente al final
            txtRetencionOtras01.Text = FormatNumber(decRetOtras01, , , , TriState.True) 'pero cuando se graban quedan totalizados en la 1ra casillita
            txtRetencionOtras02.Text = FormatNumber(0, , , , TriState.True) 'por eso los pongo a "0"
            txtRetencionOtras03.Text = FormatNumber(0, , , , TriState.True)
            txtMontoNetoPagado.Text = FormatNumber(decMontoNetoPagado, , , , TriState.True)
            labTotalPago.Text = FormatNumber(decTotalPago, , , , TriState.True)

            txtNotas.Text = strNotas

            'le da el foco al text box del nombre
            txtPagador.Focus()

            'acomoda los botones de salida y aceptar
            botSalir.Text = "Salir"
            botAceptar.Enabled = False
            booSeModificaronDatos = False

            'prende el boton cancelar para salir de la edicion
            botCancelar.Enabled = True
        End If
    End Sub

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click

        'procesa lo q esta en pantalla y carga los valores en la variables
        datFecha = datFechaSeleccionada
        strPagador = txtPagador.Text
        strRif = txtRif.Text
        strMedioDePago = txtMedioDePago.Text
        strBanco = txtBanco.Text
        strNumeroReferencia = txtNumeroReferencia.Text
        strFacturero = txtFacturero.Text
        strFactura = txtFacturaAsociada.Text

        'el chk
        If chkIncluidoEnFacturacion.Checked = True Then
            booIncluidoEnFacturacion = True
        Else
            booIncluidoEnFacturacion = False
        End If

        'los montos ya estan calculados desde q se inicio o se modifico

        'las notas
        strNotas = txtNotas.Text



        'revisa si es una nueva o se modifica una vieja
        If booEsUnNuevoPago = True Then
            'se esta creando una nueva entrada
            If booExistePathPagosub = False Then
                ' no existe el directorio lo crea
                Directory.CreateDirectory(strPathPagosub)
            End If

            '000000000000000000primero el archivo de dias
            If File.Exists(strArchivoPagoDia) = True Then
                'existe un archivo se le añade esta IQ al final
                LeeArchivoPAGOdia()

                'revisa que no haya una entrada igualita en el mismo dia porsiaaaaa
                For Each est As Form1.TablaDePagos In alsPagosDia
                    If est.a02strPagador = strPagador And est.a10decMontoNetoPagado = decMontoNetoPagado And est.a05strNumeroReferencia = strNumeroReferencia Then
                        'si todo eso se da hay un registro este dia que tiene los mismos datos que lo que esta en pantalla, al menos los datos q se usan para diferenciar no lo permite ingresar
                        MsgBox("Ya existe un Pago en este dìa con el mismo Pagador, Monto neto y numero de referencia, si no es un error de duplicaciòn colocale un numero de referencia distinto para poder ingresarlo...", MsgBoxStyle.Information, "Pago Duplicado?")
                        Exit Sub
                    End If
                Next

                'ahora añade la IQ actual si llego aca es q todo anda bien
                estPago = Nothing
                estPago.a00strIndice = strIndice
                estPago.a01datFecha = datFechaSeleccionada.ToShortDateString
                estPago.a02strPagador = strPagador
                estPago.a03strMedioDePago = strMedioDePago
                estPago.a04strBanco = strBanco
                estPago.a05strNumeroReferencia = strNumeroReferencia
                estPago.a06intFacturaAsociada = strFactura
                estPago.a06bStrFacturero = strFacturero
                estPago.a07decRetencionISLR = decRetencionISLR.ToString
                estPago.a08decRetencionADM = decRetencionADM.ToString
                estPago.a09decRetencionOTROS = decRetencionOTROS.ToString
                estPago.a10decMontoNetoPagado = decMontoNetoPagado.ToString
                estPago.a11decTotalPago = decTotalPago.ToString
                estPago.a12booIncluidoEnFacturacion = booIncluidoEnFacturacion.ToString
                estPago.a13strNotas = strNotas
                estPago.a14Rif = strRif
                estPago.b01 = ""
                estPago.b02 = ""
                estPago.b03 = ""
                estPago.b04 = ""


                'añade la estructura de los datos nuevos a las existentes en elarray
                alsPagosDia.Add(estPago)
                'escribe los datos desde el array de vuelta al archivo
                EscribeArchivoPAGOdia()
                'MsgBox("Se añadió un registro de la Intervención a las de este día...")

            Else
                'no existe lo crea y luego le añade el iq
                FS = New FileStream(strArchivoPagoDia, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                'escribe directo de las variables al archivo
                BW.Write(strIndice)
                BW.Write(datFechaSeleccionada.ToShortDateString)
                BW.Write(strPagador)
                BW.Write(strMedioDePago)
                BW.Write(strBanco)
                BW.Write(strNumeroReferencia)
                BW.Write(strFactura)
                BW.Write(strFacturero)
                BW.Write(decRetencionISLR.ToString)
                BW.Write(decRetencionADM.ToString)
                BW.Write(decRetencionOTROS.ToString)
                BW.Write(decMontoNetoPagado.ToString)
                BW.Write(decTotalPago.ToString)
                BW.Write(booIncluidoEnFacturacion.ToString)
                BW.Write(strNotas)
                BW.Write(strRif)
                BW.Write("")
                BW.Write("")
                BW.Write("")
                BW.Write("")

                BW.Close()
                FS.Close()
                'MsgBox("Se creo un registro de la Intervención en este día...")
            End If

            '0000000000000 ahora el archivo de meses
            If File.Exists(strArchivoPagoMes) = True Then
                'existe un archivo se le añade esta IQ al final
                LeeArchivoPAGOmes()
                'ahora añade la IQ actual
                estPago = Nothing
                estPago.a00strIndice = strIndice
                estPago.a01datFecha = datFechaSeleccionada.ToShortDateString
                estPago.a02strPagador = strPagador
                estPago.a03strMedioDePago = strMedioDePago
                estPago.a04strBanco = strBanco
                estPago.a05strNumeroReferencia = strNumeroReferencia
                estPago.a06intFacturaAsociada = strFactura
                estPago.a06bStrFacturero = strFacturero
                estPago.a07decRetencionISLR = decRetencionISLR.ToString
                estPago.a08decRetencionADM = decRetencionADM.ToString
                estPago.a09decRetencionOTROS = decRetencionOTROS.ToString
                estPago.a10decMontoNetoPagado = decMontoNetoPagado.ToString
                estPago.a11decTotalPago = decTotalPago.ToString
                estPago.a12booIncluidoEnFacturacion = booIncluidoEnFacturacion.ToString
                estPago.a13strNotas = strNotas
                estPago.a14Rif = strRif
                estPago.b01 = ""
                estPago.b02 = ""
                estPago.b03 = ""
                estPago.b04 = ""


                'añade la estructura de los datos nuevos a las existentes en elarray
                alsPagosMes.Add(estPago)
                'escribe los datos desde el array de vuelta al archivo
                EscribeArchivoPAGOmes()
                'MsgBox("Se añadió un registro 
            Else
                'no existe lo crea y luego le añade el iq
                FS = New FileStream(strArchivoPagoMes, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                'escribe directo de las variables al archivo
                BW.Write(strIndice)
                BW.Write(datFechaSeleccionada.ToShortDateString)
                BW.Write(strPagador)
                BW.Write(strMedioDePago)
                BW.Write(strBanco)
                BW.Write(strNumeroReferencia)
                BW.Write(strFactura)
                BW.Write(strFacturero)
                BW.Write(decRetencionISLR.ToString)
                BW.Write(decRetencionADM.ToString)
                BW.Write(decRetencionOTROS.ToString)
                BW.Write(decMontoNetoPagado.ToString)
                BW.Write(decTotalPago.ToString)
                BW.Write(booIncluidoEnFacturacion.ToString)
                BW.Write(strNotas)
                BW.Write(strRif)
                BW.Write("")
                BW.Write("")
                BW.Write("")
                BW.Write("")

                BW.Close()
                FS.Close()
            End If

            '0000000000000 ahora el archivo de años
            If File.Exists(strArchivoPagoAño) = True Then
                'existe un archivo se le añade esta IQ al final
                LeeArchivoPAGOaño()
                'ahora añade la IQ actual
                estPago = Nothing
                estPago.a00strIndice = strIndice
                estPago.a01datFecha = datFechaSeleccionada.ToShortDateString
                estPago.a02strPagador = strPagador
                estPago.a03strMedioDePago = strMedioDePago
                estPago.a04strBanco = strBanco
                estPago.a05strNumeroReferencia = strNumeroReferencia
                estPago.a06intFacturaAsociada = strFactura
                estPago.a06bStrFacturero = strFacturero
                estPago.a07decRetencionISLR = decRetencionISLR.ToString
                estPago.a08decRetencionADM = decRetencionADM.ToString
                estPago.a09decRetencionOTROS = decRetencionOTROS.ToString
                estPago.a10decMontoNetoPagado = decMontoNetoPagado.ToString
                estPago.a11decTotalPago = decTotalPago.ToString
                estPago.a12booIncluidoEnFacturacion = booIncluidoEnFacturacion.ToString
                estPago.a13strNotas = strNotas
                estPago.a14Rif = strRif
                estPago.b01 = ""
                estPago.b02 = ""
                estPago.b03 = ""
                estPago.b04 = ""


                'añade la estructura de los datos nuevos a las existentes en elarray
                alsPagosAno.Add(estPago)
                'escribe los datos desde el array de vuelta al archivo
                EscribeArchivoPAGOaño()
                'MsgBox("Se añadió un registro 
            Else
                'no existe lo crea y luego le añade el iq
                FS = New FileStream(strArchivoPagoAño, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                'escribe directo de las variables al archivo
                BW.Write(strIndice)
                BW.Write(datFechaSeleccionada.ToShortDateString)
                BW.Write(strPagador)
                BW.Write(strMedioDePago)
                BW.Write(strBanco)
                BW.Write(strNumeroReferencia)
                BW.Write(strFactura)
                BW.Write(strFacturero)
                BW.Write(decRetencionISLR.ToString)
                BW.Write(decRetencionADM.ToString)
                BW.Write(decRetencionOTROS.ToString)
                BW.Write(decMontoNetoPagado.ToString)
                BW.Write(decTotalPago.ToString)
                BW.Write(booIncluidoEnFacturacion.ToString)
                BW.Write(strNotas)
                BW.Write(strRif)
                BW.Write("")
                BW.Write("")
                BW.Write("")
                BW.Write("")

                BW.Close()
                FS.Close()
            End If


        Else
            'se esta editando una intervencion antigua 

            '0000000000000000archivo de dias
            LeeArchivoPAGOdia()

            'revisa q no se este n introduciendo un pago igualito en sus elementos distitivos el mismo dia
            For Each est As Form1.TablaDePagos In alsPagosDia
                If est.a02strPagador = strPagador And est.a10decMontoNetoPagado = decMontoNetoPagado And est.a05strNumeroReferencia = strNumeroReferencia Then
                    'todo igual, revisa si es el mismo q se esta modificando
                    If est.a00strIndice = strIndice Then
                        'es el mismo q se le acomodo otra parte no hay problema
                    Else
                        'es otro el q se esta poniendo igualito lo dice
                        MsgBox("Ya existe un Pago en este dìa con el mismo Pagador, Monto neto y numero de referencia, si no es un error de duplicaciòn colocale un numero de referencia distinto para poder ingresarlo...", MsgBoxStyle.Information, "Pago Duplicado?")
                        Exit Sub
                    End If
                End If
            Next

            FS = New FileStream(strArchivoPagoDia, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            For Each estPago As Form1.TablaDePagos In alsPagosDia
                If estPago.a00strIndice = strIndice Then
                    'este es el q hay q sustituir con los datos en pantalla
                    estPago = Nothing
                    estPago.a00strIndice = strIndice
                    estPago.a01datFecha = datFechaSeleccionada.ToShortDateString
                    estPago.a02strPagador = strPagador
                    estPago.a03strMedioDePago = strMedioDePago
                    estPago.a04strBanco = strBanco
                    estPago.a05strNumeroReferencia = strNumeroReferencia
                    estPago.a06intFacturaAsociada = strFactura
                    estPago.a06bStrFacturero = strFacturero
                    estPago.a07decRetencionISLR = decRetencionISLR.ToString
                    estPago.a08decRetencionADM = decRetencionADM.ToString
                    estPago.a09decRetencionOTROS = decRetencionOTROS.ToString
                    estPago.a10decMontoNetoPagado = decMontoNetoPagado.ToString
                    estPago.a11decTotalPago = decTotalPago.ToString
                    estPago.a12booIncluidoEnFacturacion = booIncluidoEnFacturacion.ToString
                    estPago.a13strNotas = strNotas
                    estPago.a14Rif = strRif
                    estPago.b01 = ""
                    estPago.b02 = ""
                    estPago.b03 = ""
                    estPago.b04 = ""

                End If

                'igualito va a escribir el q esta o el q se sustituyo
                BW.Write(estPago.a00strIndice)
                BW.Write(estPago.a01datFecha)
                BW.Write(estPago.a02strPagador)
                BW.Write(estPago.a03strMedioDePago)
                BW.Write(estPago.a04strBanco)
                BW.Write(estPago.a05strNumeroReferencia)
                BW.Write(estPago.a06intFacturaAsociada)
                BW.Write(estPago.a06bStrFacturero)
                BW.Write(estPago.a07decRetencionISLR)
                BW.Write(estPago.a08decRetencionADM)
                BW.Write(estPago.a09decRetencionOTROS)
                BW.Write(estPago.a10decMontoNetoPagado)
                BW.Write(estPago.a11decTotalPago)
                BW.Write(estPago.a12booIncluidoEnFacturacion)
                BW.Write(estPago.a13strNotas)
                BW.Write(estPago.a14Rif)
                BW.Write(estPago.b01)
                BW.Write(estPago.b02)
                BW.Write(estPago.b03)
                BW.Write(estPago.b04)

            Next

            'cierra el archivo al terminar
            BW.Close()
            FS.Close()


            '000000000000000 ahora los de meses
            LeeArchivoPAGOmes()

            'abre archivos
            FS = New FileStream(strArchivoPagoMes, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            'ahora recorre el array con los datos para buscar el que se va a modificar
            For Each estPago As Form1.TablaDePagos In alsPagosMes

                If strIndice = estPago.a00strIndice Then
                    estPago = Nothing
                    estPago.a00strIndice = strIndice
                    estPago.a01datFecha = datFechaSeleccionada.ToShortDateString
                    estPago.a02strPagador = strPagador
                    estPago.a03strMedioDePago = strMedioDePago
                    estPago.a04strBanco = strBanco
                    estPago.a05strNumeroReferencia = strNumeroReferencia
                    estPago.a06intFacturaAsociada = strFactura
                    estPago.a06bStrFacturero = strFacturero
                    estPago.a07decRetencionISLR = decRetencionISLR.ToString
                    estPago.a08decRetencionADM = decRetencionADM.ToString
                    estPago.a09decRetencionOTROS = decRetencionOTROS.ToString
                    estPago.a10decMontoNetoPagado = decMontoNetoPagado.ToString
                    estPago.a11decTotalPago = decTotalPago.ToString
                    estPago.a12booIncluidoEnFacturacion = booIncluidoEnFacturacion.ToString
                    estPago.a13strNotas = strNotas
                    estPago.a14Rif = strRif
                    estPago.b01 = ""
                    estPago.b02 = ""
                    estPago.b03 = ""
                    estPago.b04 = ""

                End If

                'escribe los datos al archivo sea los q no se alteraron o el q se altero igualito
                BW.Write(estPago.a00strIndice)
                BW.Write(estPago.a01datFecha)
                BW.Write(estPago.a02strPagador)
                BW.Write(estPago.a03strMedioDePago)
                BW.Write(estPago.a04strBanco)
                BW.Write(estPago.a05strNumeroReferencia)
                BW.Write(estPago.a06intFacturaAsociada)
                BW.Write(estPago.a06bStrFacturero)
                BW.Write(estPago.a07decRetencionISLR)
                BW.Write(estPago.a08decRetencionADM)
                BW.Write(estPago.a09decRetencionOTROS)
                BW.Write(estPago.a10decMontoNetoPagado)
                BW.Write(estPago.a11decTotalPago)
                BW.Write(estPago.a12booIncluidoEnFacturacion)
                BW.Write(estPago.a13strNotas)
                BW.Write(estPago.a14Rif)
                BW.Write(estPago.b01)
                BW.Write(estPago.b02)
                BW.Write(estPago.b03)
                BW.Write(estPago.b04)



            Next

            FS.Close()
            BW.Close()

            '000000000000000 ahora los de años
            LeeArchivoPAGOaño()

            'abre los archivos
            FS = New FileStream(strArchivoPagoAño, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            'ahora recorre el array con los datos para buscar el que se va a modificar
            For Each estPago As Form1.TablaDePagos In alsPagosAno

                If strIndice = estPago.a00strIndice Then
                    estPago = Nothing
                    estPago.a00strIndice = strIndice
                    estPago.a01datFecha = datFechaSeleccionada.ToShortDateString
                    estPago.a02strPagador = strPagador
                    estPago.a03strMedioDePago = strMedioDePago
                    estPago.a04strBanco = strBanco
                    estPago.a05strNumeroReferencia = strNumeroReferencia
                    estPago.a06intFacturaAsociada = strFactura
                    estPago.a06bStrFacturero = strFacturero
                    estPago.a07decRetencionISLR = decRetencionISLR.ToString
                    estPago.a08decRetencionADM = decRetencionADM.ToString
                    estPago.a09decRetencionOTROS = decRetencionOTROS.ToString
                    estPago.a10decMontoNetoPagado = decMontoNetoPagado.ToString
                    estPago.a11decTotalPago = decTotalPago.ToString
                    estPago.a12booIncluidoEnFacturacion = booIncluidoEnFacturacion.ToString
                    estPago.a13strNotas = strNotas
                    estPago.a14Rif = strRif
                    estPago.b01 = ""
                    estPago.b02 = ""
                    estPago.b03 = ""
                    estPago.b04 = ""

                End If

                'escribe los datos al archivo
                BW.Write(estPago.a00strIndice)
                BW.Write(estPago.a01datFecha)
                BW.Write(estPago.a02strPagador)
                BW.Write(estPago.a03strMedioDePago)
                BW.Write(estPago.a04strBanco)
                BW.Write(estPago.a05strNumeroReferencia)
                BW.Write(estPago.a06intFacturaAsociada)
                BW.Write(estPago.a06bStrFacturero)
                BW.Write(estPago.a07decRetencionISLR)
                BW.Write(estPago.a08decRetencionADM)
                BW.Write(estPago.a09decRetencionOTROS)
                BW.Write(estPago.a10decMontoNetoPagado)
                BW.Write(estPago.a11decTotalPago)
                BW.Write(estPago.a12booIncluidoEnFacturacion)
                BW.Write(estPago.a13strNotas)
                BW.Write(estPago.a14Rif)
                BW.Write(estPago.b01)
                BW.Write(estPago.b02)
                BW.Write(estPago.b03)
                BW.Write(estPago.b04)



            Next

            FS.Close()
            BW.Close()

        End If



        'prende el list box otra vez
        ListBoxPagos.Enabled = True
        'prende el calendario otra vez
        Calendario.Enabled = True
        Calendario.ForeColor = System.Drawing.SystemColors.WindowText
        Calendario.TitleForeColor = System.Drawing.SystemColors.ActiveCaptionText

        'borra todo
        LimpiaTodo()
        'verifica la fecha
        VerificaFecha()

    End Sub

    Private Sub botElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botElimina.Click
        Dim reply As MsgBoxResult
        reply = MsgBox("Para eliminar el registro del Pago seleccionado presiona ACEPTAR...", MsgBoxStyle.OkCancel, "Confirmación de Eliminación")
        If reply = MsgBoxResult.Ok Then

            '0000000000000000archivo de dias
            LeeArchivoPAGOdia()

            'abre para escribir
            FS = New FileStream(strArchivoPagoDia, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            'recorre buscando el indice adecuado
            For Each est As Form1.TablaDePagos In alsPagosDia
                If strIndice = est.a00strIndice Then
                    'este es el que se esta eliminando, no lo escribe no hace nada

                Else
                    'este no se esta eliminando lo escribe
                    BW.Write(est.a00strIndice)
                    BW.Write(est.a01datFecha)
                    BW.Write(est.a02strPagador)
                    BW.Write(est.a03strMedioDePago)
                    BW.Write(est.a04strBanco)
                    BW.Write(est.a05strNumeroReferencia)
                    BW.Write(est.a06intFacturaAsociada)
                    BW.Write(est.a06bStrFacturero)
                    BW.Write(est.a07decRetencionISLR)
                    BW.Write(est.a08decRetencionADM)
                    BW.Write(est.a09decRetencionOTROS)
                    BW.Write(est.a10decMontoNetoPagado)
                    BW.Write(est.a11decTotalPago)
                    BW.Write(est.a12booIncluidoEnFacturacion)
                    BW.Write(est.a13strNotas)
                    BW.Write(est.a14Rif)
                    BW.Write(est.b01)
                    BW.Write(est.b02)
                    BW.Write(est.b03)
                    BW.Write(est.b04)


                End If
            Next

            FS.Close()
            BW.Close()

            '000000000000000 ahora los de meses
            LeeArchivoPAGOmes()

            'abre  el archivo en modo escritura
            FS = New FileStream(strArchivoPagoMes, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            'ahora recorre el array con los datos para buscar el que se va a eliminar
            For Each est As Form1.TablaDePagos In alsPagosMes
                If strIndice = est.a00strIndice Then
                    'este es el que quier eliminar no hago nada
                Else
                    'este no es por lo q si se escribe
                    BW.Write(est.a00strIndice)
                    BW.Write(est.a01datFecha)
                    BW.Write(est.a02strPagador)
                    BW.Write(est.a03strMedioDePago)
                    BW.Write(est.a04strBanco)
                    BW.Write(est.a05strNumeroReferencia)
                    BW.Write(est.a06intFacturaAsociada)
                    BW.Write(est.a06bStrFacturero)
                    BW.Write(est.a07decRetencionISLR)
                    BW.Write(est.a08decRetencionADM)
                    BW.Write(est.a09decRetencionOTROS)
                    BW.Write(est.a10decMontoNetoPagado)
                    BW.Write(est.a11decTotalPago)
                    BW.Write(est.a12booIncluidoEnFacturacion)
                    BW.Write(est.a13strNotas)
                    BW.Write(est.a14Rif)
                    BW.Write(est.b01)
                    BW.Write(est.b02)
                    BW.Write(est.b03)
                    BW.Write(est.b04)


                End If

            Next

            FS.Close()
            BW.Close()

            '000000000000000 ahora los de años
            LeeArchivoPAGOaño()

            'abro en escritura
            FS = New FileStream(strArchivoPagoAño, FileMode.Create, FileAccess.Write)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            'ahora recorre el array con los datos para buscar el que se va a eliminar
            For Each est As Form1.TablaDePagos In alsPagosAno
                If strIndice = est.a00strIndice Then
                    'este es el que quier eliminar no hago nada
                Else
                    'este no es por lo q si se escribe
                    BW.Write(est.a00strIndice)
                    BW.Write(est.a01datFecha)
                    BW.Write(est.a02strPagador)
                    BW.Write(est.a03strMedioDePago)
                    BW.Write(est.a04strBanco)
                    BW.Write(est.a05strNumeroReferencia)
                    BW.Write(est.a06intFacturaAsociada)
                    BW.Write(est.a06bStrFacturero)
                    BW.Write(est.a07decRetencionISLR)
                    BW.Write(est.a08decRetencionADM)
                    BW.Write(est.a09decRetencionOTROS)
                    BW.Write(est.a10decMontoNetoPagado)
                    BW.Write(est.a11decTotalPago)
                    BW.Write(est.a12booIncluidoEnFacturacion)
                    BW.Write(est.a13strNotas)
                    BW.Write(est.a14Rif)
                    BW.Write(est.b01)
                    BW.Write(est.b02)
                    BW.Write(est.b03)
                    BW.Write(est.b04)

                End If
            Next

            FS.Close()
            BW.Close()

            'MsgBox("Se eliminó el registro de la Intervención seleccionada", MsgBoxStyle.Information)
        Else
            'no se acepto eliminar, lo dice
            MsgBox("No se realizaron cambios al registro de intervenciones del día", MsgBoxStyle.Information)
        End If

        'prende el list box otra vez
        ListBoxPagos.Enabled = True
        'prende el calendario otra vez
        Calendario.Enabled = True
        Calendario.ForeColor = System.Drawing.SystemColors.WindowText
        Calendario.TitleForeColor = System.Drawing.SystemColors.ActiveCaptionText

        'borra todo
        LimpiaTodo()
        'verifica la fecha
        VerificaFecha()

    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        'prende el list box otra vez
        ListBoxPagos.Enabled = True
        'prende el calendario otra vez
        Calendario.Enabled = True
        Calendario.ForeColor = System.Drawing.SystemColors.WindowText
        Calendario.TitleForeColor = System.Drawing.SystemColors.ActiveCaptionText

        'borra todo
        LimpiaTodo()
        'verifica la fecha
        VerificaFecha()
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

    'verifica cualquier cambio
    Private Sub txtCUALQUIERTEXTO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtPagador.TextChanged, txtMedioDePago.TextChanged, txtBanco.TextChanged, txtNumeroReferencia.TextChanged, _
                txtFacturaAsociada.TextChanged, txtRetencionADM01.TextChanged, txtRetencionADM02.TabIndexChanged, txtRetencionADM03.TextChanged, _
                txtRetencionISLR.TextChanged, txtRetencionOtras01.TextChanged, txtRetencionOtras02.TextChanged, txtRetencionOtras03.TextChanged, _
                txtMontoNetoPagado.TextChanged, txtNotas.TextChanged, txtRif.TextChanged

        If booSeModificaronDatos = False Then
            'se produjo un cambio, prende el boton y acomoda la vaina
            booSeModificaronDatos = True
            botAceptar.Enabled = True
            botSalir.Text = "Descarta Cambios"
        End If

    End Sub

    'keypresses solo numeros
    Private Sub txtNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtFacturaAsociada.KeyPress, txtNumeroReferencia.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        End If
    End Sub

    'keypress de numeros y coma para decimales
    Private Sub txtNumerosYdecimales_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtRetencionADM01.KeyPress, txtRetencionADM01.KeyPress, txtRetencionADM03.KeyPress, _
                txtRetencionOtras01.KeyPress, txtRetencionOtras02.KeyPress, txtRetencionOtras03.KeyPress, txtMontoNetoPagado.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "."c) Then
            e.Handled = True
        End If
    End Sub

    'keypres del rif
    Private Sub txtRif_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtRif.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "V"c Or c = "v"c Or c = "J"c Or c = "j"c Or c = "G"c Or c = "g"c Or c = "-"c) Then
            e.Handled = True
        End If
    End Sub

    'las ret Adm leave
    Private Sub txtRetencionAdm01_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetencionADM01.Leave
        If txtRetencionADM01.Text = "" Then
            decRetAdm01 = 0 'si esta vacio se pone a cero
        ElseIf IsNumeric(txtRetencionADM01.Text) Then
            decRetAdm01 = CType(txtRetencionADM01.Text, Decimal) 'si es numerico se agarra el dato
        Else
            decRetAdm01 = 0 'si es otra cosa se pone a 0
        End If
        'totaliza las cantidades
        TotalizaPagos()
    End Sub
    Private Sub txtRetencionAdm02_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetencionADM02.Leave
        If txtRetencionADM02.Text = "" Then
            decRetAdm02 = 0 'si esta vacio se pone a cero
        ElseIf IsNumeric(txtRetencionADM02.Text) Then
            decRetAdm02 = CType(txtRetencionADM02.Text, Decimal) 'si es numerico se agarra el dato
        Else
            decRetAdm02 = 0 'si es otra cosa se pone a 0
        End If
        'totaliza las cantidades
        TotalizaPagos()
    End Sub
    Private Sub txtRetencionAdm03_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetencionADM03.Leave
        If txtRetencionADM03.Text = "" Then
            decRetAdm03 = 0 'si esta vacio se pone a cero
        ElseIf IsNumeric(txtRetencionADM03.Text) Then
            decRetAdm03 = CType(txtRetencionADM03.Text, Decimal) 'si es numerico se agarra el dato
        Else
            decRetAdm03 = 0 'si es otra cosa se pone a 0
        End If
        'totaliza las cantidades
        TotalizaPagos()
    End Sub

    'las otras ret leave
    Private Sub txtRetencionOtras01_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetencionOtras01.Leave
        If txtRetencionOtras01.Text = "" Then
            decRetOtras01 = 0 'si esta vacio se pone a cero
        ElseIf IsNumeric(txtRetencionOtras01.Text) Then
            decRetOtras01 = CType(txtRetencionOtras01.Text, Decimal) 'si es numerico se agarra el dato
        Else
            decRetOtras01 = 0 'si es otra cosa se pone a 0
        End If
        'totaliza las cantidades
        TotalizaPagos()
    End Sub
    Private Sub txtRetencionOtras02_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetencionOtras02.Leave
        If txtRetencionOtras02.Text = "" Then
            decRetOtras02 = 0 'si esta vacio se pone a cero
        ElseIf IsNumeric(txtRetencionOtras02.Text) Then
            decRetOtras02 = CType(txtRetencionOtras02.Text, Decimal) 'si es numerico se agarra el dato
        Else
            decRetOtras02 = 0 'si es otra cosa se pone a 0
        End If
        'totaliza las cantidades
        TotalizaPagos()
    End Sub
    Private Sub txtRetencionOtras03_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetencionOtras03.Leave
        If txtRetencionOtras03.Text = "" Then
            decRetOtras03 = 0 'si esta vacio se pone a cero
        ElseIf IsNumeric(txtRetencionOtras03.Text) Then
            decRetOtras03 = CType(txtRetencionOtras03.Text, Decimal) 'si es numerico se agarra el dato
        Else
            decRetOtras03 = 0 'si es otra cosa se pone a 0
        End If
        'totaliza las cantidades
        TotalizaPagos()
    End Sub

    'el islr leave
    Private Sub txtRetencionISLR_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetencionISLR.Leave
        If txtRetencionISLR.Text = "" Then
            decRetencionISLR = 0 'si esta vacio se pone a cero
        ElseIf IsNumeric(txtRetencionISLR.Text) Then
            decRetencionISLR = CType(txtRetencionISLR.Text, Decimal) 'si es numerico se agarra el dato
        Else
            decRetencionISLR = 0 'si es otra cosa se pone a 0
        End If
        'totaliza las cantidades
        TotalizaPagos()
    End Sub

    'el monto neto pagado leave
    Private Sub txtMontoNetoPagado_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoNetoPagado.Leave
        If txtMontoNetoPagado.Text = "" Then
            decMontoNetoPagado = 0
        ElseIf IsNumeric(txtMontoNetoPagado.Text) Then
            decMontoNetoPagado = CType(txtMontoNetoPagado.Text, Decimal)
        Else
            decMontoNetoPagado = 0
        End If
        'totaliza las cantidades
        TotalizaPagos()
    End Sub

    'totalizar el sub total y total de las cantidades
    Private Sub TotalizaPagos()
        'ya tengo todos los sub totales adm y de otras ret los sub totalizo
        decRetencionADM = decRetAdm01 + decRetAdm02 + decRetAdm03
        decRetencionOTROS = decRetOtras01 + decRetOtras02 + decRetOtras03
        'ahora totalizo el pago total
        decTotalPago = decRetencionADM + decRetencionISLR + decRetencionOTROS + decMontoNetoPagado

        'finalmente formatea los datos para mostrarlos en pantalla
        txtRetencionADM01.Text = FormatNumber(decRetAdm01, 2, , , TriState.True)
        txtRetencionADM02.Text = FormatNumber(decRetAdm02, 2, , , TriState.True)
        txtRetencionADM03.Text = FormatNumber(decRetAdm03, 2, , , TriState.True)
        txtRetencionOtras01.Text = FormatNumber(decRetOtras01, 2, , , TriState.True)
        txtRetencionOtras02.Text = FormatNumber(decRetOtras02, 2, , , TriState.True)
        txtRetencionOtras03.Text = FormatNumber(decRetOtras03, 2, , , TriState.True)
        txtRetencionISLR.Text = FormatNumber(decRetencionISLR, 2, , , TriState.True)
        txtMontoNetoPagado.Text = FormatNumber(decMontoNetoPagado, 2, , , TriState.True)
        labTotalPago.Text = FormatNumber(decTotalPago, 2, , , TriState.True)

    End Sub

    'Pagador leave
    Private Sub txtPagador_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPagador.Leave
        If txtPagador.Text.ToUpper = "MATERNIDAD DEL ESTE SA" Then
            txtRif.Text = "J-07506033-4"
        ElseIf txtPagador.Text.ToUpper = "IEQ LOS MANGOS CA" Then
            txtRif.Text = "J-30435494-0"
        ElseIf txtPagador.Text.ToUpper = "CENAG CA" Then
            txtRif.Text = "J-30329009-4"
        ElseIf txtPagador.Text.ToUpper = "CLÍNICA SANTA MÓNICA" Then
            txtRif.Text = "J-30241031-2"
        ElseIf txtPagador.Text.ToUpper = "MATERNIDAD Y CENTRO PEDIÁTRICO SANTA MARÍA" Then
            txtRif.Text = "J-07530528-0"
        ElseIf txtPagador.Text.ToUpper = "CENTRO CLÍNICO LA MILAGROSA CA" Then
            txtRif.Text = "J-30106771-1"
        ElseIf txtPagador.Text.ToUpper = "CENTRO CLÍNICO SAN RAFAEL CA" Then
            txtRif.Text = "J-07549095-9"
        ElseIf txtPagador.Text.ToUpper = "CENTRO MÉDICO SAN FRANCISCO DE ASÍS CA" Then
            txtRif.Text = "J-31440381-8"
        ElseIf txtPagador.Text.ToUpper = "CLÍNICA DR. AMAURI RENGEL CA" Then
            txtRif.Text = "J-07590570-9"
        ElseIf txtPagador.Text.ToUpper = "FUNDACIÓN CLÍNICA LA NACIONAL CA" Then
            txtRif.Text = "J-30963340-6"
        ElseIf txtPagador.Text.ToUpper = "CÉLULAS MADRE DE VENEZUELA" Then
            txtRif.Text = "J-29367634-7"
        ElseIf txtPagador.Text.ToUpper = "CENTRO QUIRÚRGICO CARDIOVASCULAR CA" Then
            txtRif.Text = "J-30821243-1"
        ElseIf txtPagador.Text.ToUpper = "CENTRO MÉDICO SINAÍ CA" Then
            txtRif.Text = "J-30841006-3"
        Else
            txtRif.Clear()
        End If
    End Sub

    'seleccion de Pagador
    Private Sub txtPagador_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPagador.Enter
        txtPagador.SelectAll()
    End Sub
    Private Sub txtPagador_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPagador.Click
        txtPagador.SelectAll()
    End Sub

    'seleccion de Rif
    Private Sub txtRif_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRif.Enter
        txtRif.SelectAll()
    End Sub
    Private Sub txtRif_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRif.Click
        txtRif.SelectAll()
    End Sub

    'seleccion de MedioDePago
    Private Sub txtMedioDePago_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMedioDePago.Enter
        txtMedioDePago.SelectAll()
    End Sub
    Private Sub txtMedioDePago_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMedioDePago.Click
        txtMedioDePago.SelectAll()
    End Sub

    'seleccion de Banco
    Private Sub txtBanco_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBanco.Enter
        txtBanco.SelectAll()
    End Sub
    Private Sub txtBanco_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBanco.Click
        txtBanco.SelectAll()
    End Sub

    'seleccion de NumeroReferencia
    Private Sub txtNumeroReferencia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroReferencia.Enter
        txtNumeroReferencia.SelectAll()
    End Sub
    Private Sub txtNumeroReferencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroReferencia.Click
        txtNumeroReferencia.SelectAll()
    End Sub

    'seleccion de Facturero
    Private Sub txtFacturero_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFacturero.Enter
        txtFacturero.SelectAll()
    End Sub
    Private Sub txtFacturero_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFacturero.Click
        txtFacturero.SelectAll()
    End Sub

    'seleccion de FacturaAsociada
    Private Sub txtFacturaAsociada_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFacturaAsociada.Enter
        txtFacturaAsociada.SelectAll()
    End Sub
    Private Sub txtFacturaAsociada_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFacturaAsociada.Click
        txtFacturaAsociada.SelectAll()
    End Sub

   
   
End Class