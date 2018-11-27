<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPagos))
        Me.botSalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Calendario = New System.Windows.Forms.MonthCalendar
        Me.ListBoxPagos = New System.Windows.Forms.ListBox
        Me.labMensaje = New System.Windows.Forms.Label
        Me.labPAGOdelaFecha = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRif = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtRetencionOtras03 = New System.Windows.Forms.TextBox
        Me.txtRetencionOtras02 = New System.Windows.Forms.TextBox
        Me.txtRetencionADM03 = New System.Windows.Forms.TextBox
        Me.txtRetencionADM02 = New System.Windows.Forms.TextBox
        Me.txtFacturero = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.chkIncluidoEnFacturacion = New System.Windows.Forms.CheckBox
        Me.txtNotas = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.labTotalPago = New System.Windows.Forms.Label
        Me.txtMontoNetoPagado = New System.Windows.Forms.TextBox
        Me.txtRetencionOtras01 = New System.Windows.Forms.TextBox
        Me.txtRetencionADM01 = New System.Windows.Forms.TextBox
        Me.txtRetencionISLR = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtFacturaAsociada = New System.Windows.Forms.TextBox
        Me.txtNumeroReferencia = New System.Windows.Forms.TextBox
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.txtMedioDePago = New System.Windows.Forms.TextBox
        Me.txtPagador = New System.Windows.Forms.TextBox
        Me.labFecha = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.botCancelar = New System.Windows.Forms.Button
        Me.botAceptar = New System.Windows.Forms.Button
        Me.botElimina = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'botSalir
        '
        Me.botSalir.BackgroundImage = CType(resources.GetObject("botSalir.BackgroundImage"), System.Drawing.Image)
        Me.botSalir.Location = New System.Drawing.Point(12, 637)
        Me.botSalir.Name = "botSalir"
        Me.botSalir.Size = New System.Drawing.Size(224, 23)
        Me.botSalir.TabIndex = 0
        Me.botSalir.Text = "Salir"
        Me.botSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Fecha del Pago"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Calendario
        '
        Me.Calendario.Location = New System.Drawing.Point(12, 33)
        Me.Calendario.MaxSelectionCount = 1
        Me.Calendario.Name = "Calendario"
        Me.Calendario.ShowToday = False
        Me.Calendario.ShowTodayCircle = False
        Me.Calendario.TabIndex = 33
        Me.Calendario.TabStop = False
        '
        'ListBoxPagos
        '
        Me.ListBoxPagos.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxPagos.ItemHeight = 9
        Me.ListBoxPagos.Location = New System.Drawing.Point(198, 56)
        Me.ListBoxPagos.Name = "ListBoxPagos"
        Me.ListBoxPagos.Size = New System.Drawing.Size(784, 85)
        Me.ListBoxPagos.TabIndex = 35
        '
        'labMensaje
        '
        Me.labMensaje.AutoSize = True
        Me.labMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labMensaje.Location = New System.Drawing.Point(198, 172)
        Me.labMensaje.Name = "labMensaje"
        Me.labMensaje.Size = New System.Drawing.Size(428, 15)
        Me.labMensaje.TabIndex = 37
        Me.labMensaje.Text = "Selecciona la fecha y un registro existente para Modificarlo o Añade un Registro " & _
            "nuevo..."
        Me.labMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labPAGOdelaFecha
        '
        Me.labPAGOdelaFecha.AutoSize = True
        Me.labPAGOdelaFecha.Location = New System.Drawing.Point(195, 151)
        Me.labPAGOdelaFecha.Name = "labPAGOdelaFecha"
        Me.labPAGOdelaFecha.Size = New System.Drawing.Size(73, 13)
        Me.labPAGOdelaFecha.TabIndex = 36
        Me.labPAGOdelaFecha.Text = "Pagos del día"
        Me.labPAGOdelaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRif)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtRetencionOtras03)
        Me.GroupBox1.Controls.Add(Me.txtRetencionOtras02)
        Me.GroupBox1.Controls.Add(Me.txtRetencionADM03)
        Me.GroupBox1.Controls.Add(Me.txtRetencionADM02)
        Me.GroupBox1.Controls.Add(Me.txtFacturero)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.chkIncluidoEnFacturacion)
        Me.GroupBox1.Controls.Add(Me.txtNotas)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.labTotalPago)
        Me.GroupBox1.Controls.Add(Me.txtMontoNetoPagado)
        Me.GroupBox1.Controls.Add(Me.txtRetencionOtras01)
        Me.GroupBox1.Controls.Add(Me.txtRetencionADM01)
        Me.GroupBox1.Controls.Add(Me.txtRetencionISLR)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtFacturaAsociada)
        Me.GroupBox1.Controls.Add(Me.txtNumeroReferencia)
        Me.GroupBox1.Controls.Add(Me.txtBanco)
        Me.GroupBox1.Controls.Add(Me.txtMedioDePago)
        Me.GroupBox1.Controls.Add(Me.txtPagador)
        Me.GroupBox1.Controls.Add(Me.labFecha)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 402)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'txtRif
        '
        Me.txtRif.AutoCompleteCustomSource.AddRange(New String() {"J-07506033-4", "J-30241031-2", "J-30435494-0", "J-07549095-9", "J-07590570-9", "J-30106771-1", "J-30821243-1", "J-30841006-3", "J-29367634-7", "J-30963340-6", "J-31440381-8", "J-07530528-0", "J-30329009-4"})
        Me.txtRif.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtRif.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRif.Location = New System.Drawing.Point(321, 45)
        Me.txtRif.MaxLength = 15
        Me.txtRif.Name = "txtRif"
        Me.txtRif.Size = New System.Drawing.Size(101, 20)
        Me.txtRif.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(318, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 13)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "Rif / CI"
        '
        'txtRetencionOtras03
        '
        Me.txtRetencionOtras03.Location = New System.Drawing.Point(414, 175)
        Me.txtRetencionOtras03.MaxLength = 10
        Me.txtRetencionOtras03.Name = "txtRetencionOtras03"
        Me.txtRetencionOtras03.Size = New System.Drawing.Size(150, 20)
        Me.txtRetencionOtras03.TabIndex = 15
        Me.txtRetencionOtras03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionOtras02
        '
        Me.txtRetencionOtras02.Location = New System.Drawing.Point(414, 149)
        Me.txtRetencionOtras02.MaxLength = 10
        Me.txtRetencionOtras02.Name = "txtRetencionOtras02"
        Me.txtRetencionOtras02.Size = New System.Drawing.Size(150, 20)
        Me.txtRetencionOtras02.TabIndex = 14
        Me.txtRetencionOtras02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionADM03
        '
        Me.txtRetencionADM03.Location = New System.Drawing.Point(258, 175)
        Me.txtRetencionADM03.MaxLength = 10
        Me.txtRetencionADM03.Name = "txtRetencionADM03"
        Me.txtRetencionADM03.Size = New System.Drawing.Size(150, 20)
        Me.txtRetencionADM03.TabIndex = 12
        Me.txtRetencionADM03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionADM02
        '
        Me.txtRetencionADM02.Location = New System.Drawing.Point(258, 149)
        Me.txtRetencionADM02.MaxLength = 10
        Me.txtRetencionADM02.Name = "txtRetencionADM02"
        Me.txtRetencionADM02.Size = New System.Drawing.Size(150, 20)
        Me.txtRetencionADM02.TabIndex = 11
        Me.txtRetencionADM02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFacturero
        '
        Me.txtFacturero.AutoCompleteCustomSource.AddRange(New String() {"Maternidad", "Amauri"})
        Me.txtFacturero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtFacturero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFacturero.Location = New System.Drawing.Point(717, 45)
        Me.txtFacturero.MaxLength = 20
        Me.txtFacturero.Name = "txtFacturero"
        Me.txtFacturero.Size = New System.Drawing.Size(100, 20)
        Me.txtFacturero.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(714, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Facturero"
        '
        'chkIncluidoEnFacturacion
        '
        Me.chkIncluidoEnFacturacion.AutoSize = True
        Me.chkIncluidoEnFacturacion.Location = New System.Drawing.Point(14, 71)
        Me.chkIncluidoEnFacturacion.Name = "chkIncluidoEnFacturacion"
        Me.chkIncluidoEnFacturacion.Size = New System.Drawing.Size(137, 17)
        Me.chkIncluidoEnFacturacion.TabIndex = 8
        Me.chkIncluidoEnFacturacion.Text = "Incluido en Facturación"
        Me.chkIncluidoEnFacturacion.UseVisualStyleBackColor = True
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(14, 220)
        Me.txtNotas.MaxLength = 1000
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotas.Size = New System.Drawing.Size(895, 176)
        Me.txtNotas.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Notas y Observaciones"
        '
        'labTotalPago
        '
        Me.labTotalPago.BackColor = System.Drawing.SystemColors.Info
        Me.labTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labTotalPago.Location = New System.Drawing.Point(760, 123)
        Me.labTotalPago.Name = "labTotalPago"
        Me.labTotalPago.Size = New System.Drawing.Size(150, 20)
        Me.labTotalPago.TabIndex = 22
        Me.labTotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoNetoPagado
        '
        Me.txtMontoNetoPagado.Location = New System.Drawing.Point(570, 123)
        Me.txtMontoNetoPagado.MaxLength = 10
        Me.txtMontoNetoPagado.Name = "txtMontoNetoPagado"
        Me.txtMontoNetoPagado.Size = New System.Drawing.Size(150, 20)
        Me.txtMontoNetoPagado.TabIndex = 16
        Me.txtMontoNetoPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionOtras01
        '
        Me.txtRetencionOtras01.Location = New System.Drawing.Point(414, 123)
        Me.txtRetencionOtras01.MaxLength = 10
        Me.txtRetencionOtras01.Name = "txtRetencionOtras01"
        Me.txtRetencionOtras01.Size = New System.Drawing.Size(150, 20)
        Me.txtRetencionOtras01.TabIndex = 13
        Me.txtRetencionOtras01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionADM01
        '
        Me.txtRetencionADM01.Location = New System.Drawing.Point(258, 123)
        Me.txtRetencionADM01.MaxLength = 10
        Me.txtRetencionADM01.Name = "txtRetencionADM01"
        Me.txtRetencionADM01.Size = New System.Drawing.Size(150, 20)
        Me.txtRetencionADM01.TabIndex = 10
        Me.txtRetencionADM01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetencionISLR
        '
        Me.txtRetencionISLR.Location = New System.Drawing.Point(102, 123)
        Me.txtRetencionISLR.MaxLength = 10
        Me.txtRetencionISLR.Name = "txtRetencionISLR"
        Me.txtRetencionISLR.Size = New System.Drawing.Size(150, 20)
        Me.txtRetencionISLR.TabIndex = 9
        Me.txtRetencionISLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Datos del Pago"
        '
        'txtFacturaAsociada
        '
        Me.txtFacturaAsociada.Location = New System.Drawing.Point(822, 45)
        Me.txtFacturaAsociada.MaxLength = 5
        Me.txtFacturaAsociada.Name = "txtFacturaAsociada"
        Me.txtFacturaAsociada.Size = New System.Drawing.Size(100, 20)
        Me.txtFacturaAsociada.TabIndex = 7
        '
        'txtNumeroReferencia
        '
        Me.txtNumeroReferencia.Location = New System.Drawing.Point(611, 45)
        Me.txtNumeroReferencia.MaxLength = 8
        Me.txtNumeroReferencia.Name = "txtNumeroReferencia"
        Me.txtNumeroReferencia.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroReferencia.TabIndex = 5
        '
        'txtBanco
        '
        Me.txtBanco.AutoCompleteCustomSource.AddRange(New String() {"Mercantil", "BOD", "Banesco", "Provincial", "Venezuela", "BFC", "Exterior", "BNC"})
        Me.txtBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBanco.Location = New System.Drawing.Point(505, 45)
        Me.txtBanco.MaxLength = 15
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 4
        '
        'txtMedioDePago
        '
        Me.txtMedioDePago.AutoCompleteCustomSource.AddRange(New String() {"Efectivo", "Cheque", "Débito", "Depósito Bancario"})
        Me.txtMedioDePago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtMedioDePago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMedioDePago.Location = New System.Drawing.Point(428, 45)
        Me.txtMedioDePago.MaxLength = 15
        Me.txtMedioDePago.Name = "txtMedioDePago"
        Me.txtMedioDePago.Size = New System.Drawing.Size(71, 20)
        Me.txtMedioDePago.TabIndex = 3
        '
        'txtPagador
        '
        Me.txtPagador.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este SA", "Clínica Santa Mónica", "IEQ Los Mangos CA", "Centro Clínico San Rafael CA", "Fundación Clínica La Nacional CA", "CENAG CA", "Centro Médico Sinaí CA", "Centro Médico San Francisco de Asís CA", "Clínica Dr. Amauri Rengel CA", "Maternidad y Centro Pediátrico Santa María", "Centro Clínico La Milagrosa CA", "Células Madre de Venezuela", "Centro Quirúrgico Cardiovascular CA"})
        Me.txtPagador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPagador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPagador.Location = New System.Drawing.Point(102, 45)
        Me.txtPagador.MaxLength = 50
        Me.txtPagador.Name = "txtPagador"
        Me.txtPagador.Size = New System.Drawing.Size(213, 20)
        Me.txtPagador.TabIndex = 1
        '
        'labFecha
        '
        Me.labFecha.BackColor = System.Drawing.SystemColors.Info
        Me.labFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFecha.Location = New System.Drawing.Point(15, 45)
        Me.labFecha.Name = "labFecha"
        Me.labFecha.Size = New System.Drawing.Size(81, 20)
        Me.labFecha.TabIndex = 0
        Me.labFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(502, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Banco"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(819, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Num. Factura"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(820, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Total Devengado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(617, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Monto Neto Pagado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(469, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Otras Retenciones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Retención Administrativa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(169, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Retención ISLR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(608, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "# Referencia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Medio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pagador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha del pago"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(195, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Factura"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(267, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Pagador"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(501, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Modo de Pago"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(606, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "# Ref"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(769, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "ISLR"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(823, 38)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Otras Ret"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(679, 38)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Pago Neto"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(892, 38)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 13)
        Me.Label23.TabIndex = 48
        Me.Label23.Text = "Total Devengado"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botCancelar
        '
        Me.botCancelar.BackgroundImage = CType(resources.GetObject("botCancelar.BackgroundImage"), System.Drawing.Image)
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.ForeColor = System.Drawing.Color.Black
        Me.botCancelar.Location = New System.Drawing.Point(528, 637)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(224, 23)
        Me.botCancelar.TabIndex = 41
        Me.botCancelar.Text = "Cancelar Cambios"
        '
        'botAceptar
        '
        Me.botAceptar.BackgroundImage = CType(resources.GetObject("botAceptar.BackgroundImage"), System.Drawing.Image)
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.ForeColor = System.Drawing.Color.Black
        Me.botAceptar.Location = New System.Drawing.Point(758, 637)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(224, 23)
        Me.botAceptar.TabIndex = 40
        Me.botAceptar.Text = "Guardar Cambios"
        '
        'botElimina
        '
        Me.botElimina.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOffGrande
        Me.botElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botElimina.ForeColor = System.Drawing.Color.Black
        Me.botElimina.Location = New System.Drawing.Point(758, 164)
        Me.botElimina.Name = "botElimina"
        Me.botElimina.Size = New System.Drawing.Size(224, 23)
        Me.botElimina.TabIndex = 38
        Me.botElimina.Text = "Elimina Pago"
        '
        'FormPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ListBoxPagos)
        Me.Controls.Add(Me.labMensaje)
        Me.Controls.Add(Me.labPAGOdelaFecha)
        Me.Controls.Add(Me.botCancelar)
        Me.Controls.Add(Me.botAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.botElimina)
        Me.Controls.Add(Me.botSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormPagos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pagos Recibidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents botSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents botElimina As System.Windows.Forms.Button
    Friend WithEvents ListBoxPagos As System.Windows.Forms.ListBox
    Friend WithEvents labMensaje As System.Windows.Forms.Label
    Friend WithEvents labPAGOdelaFecha As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMedioDePago As System.Windows.Forms.TextBox
    Friend WithEvents txtPagador As System.Windows.Forms.TextBox
    Friend WithEvents labFecha As System.Windows.Forms.Label
    Friend WithEvents txtFacturaAsociada As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroReferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents labTotalPago As System.Windows.Forms.Label
    Friend WithEvents txtMontoNetoPagado As System.Windows.Forms.TextBox
    Friend WithEvents txtRetencionOtras01 As System.Windows.Forms.TextBox
    Friend WithEvents txtRetencionADM01 As System.Windows.Forms.TextBox
    Friend WithEvents txtRetencionISLR As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents txtNotas As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkIncluidoEnFacturacion As System.Windows.Forms.CheckBox
    Friend WithEvents txtFacturero As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtRetencionADM03 As System.Windows.Forms.TextBox
    Friend WithEvents txtRetencionADM02 As System.Windows.Forms.TextBox
    Friend WithEvents txtRetencionOtras03 As System.Windows.Forms.TextBox
    Friend WithEvents txtRetencionOtras02 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtRif As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
