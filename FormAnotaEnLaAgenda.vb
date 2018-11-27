Imports System.IO

Public Class FormAnotaEnLaAgenda
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents labFecha As System.Windows.Forms.Label
    Friend WithEvents labNumero As System.Windows.Forms.Label
    Friend WithEvents labNombre As System.Windows.Forms.Label
    Friend WithEvents labCedula As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIDx As System.Windows.Forms.TextBox
    Friend WithEvents txtTto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPendiente As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Calendario1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents labProximaConsulta As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLugar As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxProxima As System.Windows.Forms.CheckBox
    Friend WithEvents ListBoxProximas As System.Windows.Forms.ListBox
    Friend WithEvents botOK As System.Windows.Forms.Button
    Friend WithEvents botCancel As System.Windows.Forms.Button
    Friend WithEvents PanelProximaConsulta As System.Windows.Forms.Panel
    Friend WithEvents txtAutoGenerado As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtPagador As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents radCanceladoElMismoDia As System.Windows.Forms.RadioButton
    Friend WithEvents radCancaladoOtroDia As System.Windows.Forms.RadioButton
    Friend WithEvents radPagoPendiente As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents panelEligeFechaDePago2 As System.Windows.Forms.Panel
    Friend WithEvents labValidacionDeFecha As System.Windows.Forms.Label
    Friend WithEvents labFechaDePago As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents panelEligeFechaDePago1 As System.Windows.Forms.Panel
    Friend WithEvents txtFormaDePago As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents labListbox As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.labFecha = New System.Windows.Forms.Label()
        Me.labNumero = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.labCedula = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIDx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPendiente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Calendario1 = New System.Windows.Forms.MonthCalendar()
        Me.labProximaConsulta = New System.Windows.Forms.Label()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBoxProxima = New System.Windows.Forms.CheckBox()
        Me.ListBoxProximas = New System.Windows.Forms.ListBox()
        Me.labListbox = New System.Windows.Forms.Label()
        Me.PanelProximaConsulta = New System.Windows.Forms.Panel()
        Me.txtAutoGenerado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.botCancel = New System.Windows.Forms.Button()
        Me.botOK = New System.Windows.Forms.Button()
        Me.txtPagador = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.radCanceladoElMismoDia = New System.Windows.Forms.RadioButton()
        Me.radCancaladoOtroDia = New System.Windows.Forms.RadioButton()
        Me.radPagoPendiente = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.panelEligeFechaDePago2 = New System.Windows.Forms.Panel()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.labValidacionDeFecha = New System.Windows.Forms.Label()
        Me.labFechaDePago = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.panelEligeFechaDePago1 = New System.Windows.Forms.Panel()
        Me.txtFormaDePago = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PanelProximaConsulta.SuspendLayout()
        Me.panelEligeFechaDePago2.SuspendLayout()
        Me.panelEligeFechaDePago1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de la Consulta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Número de Historia:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de la Paciente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(368, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cédula de Identidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labFecha
        '
        Me.labFecha.BackColor = System.Drawing.SystemColors.Info
        Me.labFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFecha.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFecha.Location = New System.Drawing.Point(119, 8)
        Me.labFecha.Name = "labFecha"
        Me.labFecha.Size = New System.Drawing.Size(220, 20)
        Me.labFecha.TabIndex = 1
        Me.labFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNumero
        '
        Me.labNumero.BackColor = System.Drawing.SystemColors.Info
        Me.labNumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNumero.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNumero.Location = New System.Drawing.Point(119, 32)
        Me.labNumero.Name = "labNumero"
        Me.labNumero.Size = New System.Drawing.Size(110, 20)
        Me.labNumero.TabIndex = 5
        Me.labNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labNombre
        '
        Me.labNombre.BackColor = System.Drawing.SystemColors.Info
        Me.labNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombre.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombre.Location = New System.Drawing.Point(479, 8)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(263, 20)
        Me.labNombre.TabIndex = 3
        Me.labNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labCedula
        '
        Me.labCedula.BackColor = System.Drawing.SystemColors.Info
        Me.labCedula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCedula.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labCedula.Location = New System.Drawing.Point(479, 32)
        Me.labCedula.Name = "labCedula"
        Me.labCedula.Size = New System.Drawing.Size(108, 20)
        Me.labCedula.TabIndex = 7
        Me.labCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Signos Subjetivos y Datos Manuales"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIDx
        '
        Me.txtIDx.Location = New System.Drawing.Point(6, 273)
        Me.txtIDx.MaxLength = 1000
        Me.txtIDx.Multiline = True
        Me.txtIDx.Name = "txtIDx"
        Me.txtIDx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDx.Size = New System.Drawing.Size(280, 135)
        Me.txtIDx.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tratamiento Indicado"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTto
        '
        Me.txtTto.Location = New System.Drawing.Point(292, 77)
        Me.txtTto.MaxLength = 1000
        Me.txtTto.Multiline = True
        Me.txtTto.Name = "txtTto"
        Me.txtTto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTto.Size = New System.Drawing.Size(295, 167)
        Me.txtTto.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(295, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Pendiente en la Próxima Consulta"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPendiente
        '
        Me.txtPendiente.Location = New System.Drawing.Point(292, 273)
        Me.txtPendiente.MaxLength = 1000
        Me.txtPendiente.Multiline = True
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPendiente.Size = New System.Drawing.Size(295, 135)
        Me.txtPendiente.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(593, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Honorarios de la Consulta"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(768, 77)
        Me.txtMonto.MaxLength = 8
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(122, 20)
        Me.txtMonto.TabIndex = 17
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Calendario1
        '
        Me.Calendario1.CalendarDimensions = New System.Drawing.Size(2, 1)
        Me.Calendario1.Location = New System.Drawing.Point(5, 55)
        Me.Calendario1.MaxSelectionCount = 1
        Me.Calendario1.Name = "Calendario1"
        Me.Calendario1.ShowToday = False
        Me.Calendario1.TabIndex = 2
        '
        'labProximaConsulta
        '
        Me.labProximaConsulta.BackColor = System.Drawing.SystemColors.Window
        Me.labProximaConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labProximaConsulta.Location = New System.Drawing.Point(5, 26)
        Me.labProximaConsulta.Name = "labProximaConsulta"
        Me.labProximaConsulta.Size = New System.Drawing.Size(280, 20)
        Me.labProximaConsulta.TabIndex = 1
        Me.labProximaConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLugar
        '
        Me.txtLugar.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Amauri Rengel"})
        Me.txtLugar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtLugar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLugar.Location = New System.Drawing.Point(768, 100)
        Me.txtLugar.MaxLength = 30
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(214, 20)
        Me.txtLugar.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(593, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Lugar de la Consulta"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBoxProxima
        '
        Me.CheckBoxProxima.AutoSize = True
        Me.CheckBoxProxima.Location = New System.Drawing.Point(5, 6)
        Me.CheckBoxProxima.Name = "CheckBoxProxima"
        Me.CheckBoxProxima.Size = New System.Drawing.Size(107, 17)
        Me.CheckBoxProxima.TabIndex = 0
        Me.CheckBoxProxima.Text = "Próxima Consulta"
        '
        'ListBoxProximas
        '
        Me.ListBoxProximas.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxProximas.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxProximas.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxProximas.ItemHeight = 11
        Me.ListBoxProximas.Location = New System.Drawing.Point(447, 26)
        Me.ListBoxProximas.Name = "ListBoxProximas"
        Me.ListBoxProximas.Size = New System.Drawing.Size(529, 191)
        Me.ListBoxProximas.TabIndex = 4
        '
        'labListbox
        '
        Me.labListbox.AutoSize = True
        Me.labListbox.Location = New System.Drawing.Point(444, 7)
        Me.labListbox.Name = "labListbox"
        Me.labListbox.Size = New System.Drawing.Size(209, 13)
        Me.labListbox.TabIndex = 3
        Me.labListbox.Text = "Eventos y Pacientes citadas para la fecha:"
        Me.labListbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelProximaConsulta
        '
        Me.PanelProximaConsulta.Controls.Add(Me.CheckBoxProxima)
        Me.PanelProximaConsulta.Controls.Add(Me.labListbox)
        Me.PanelProximaConsulta.Controls.Add(Me.Calendario1)
        Me.PanelProximaConsulta.Controls.Add(Me.ListBoxProximas)
        Me.PanelProximaConsulta.Controls.Add(Me.labProximaConsulta)
        Me.PanelProximaConsulta.Location = New System.Drawing.Point(6, 414)
        Me.PanelProximaConsulta.Name = "PanelProximaConsulta"
        Me.PanelProximaConsulta.Size = New System.Drawing.Size(982, 225)
        Me.PanelProximaConsulta.TabIndex = 34
        '
        'txtAutoGenerado
        '
        Me.txtAutoGenerado.BackColor = System.Drawing.SystemColors.Info
        Me.txtAutoGenerado.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAutoGenerado.Location = New System.Drawing.Point(6, 77)
        Me.txtAutoGenerado.MaxLength = 5000
        Me.txtAutoGenerado.Multiline = True
        Me.txtAutoGenerado.Name = "txtAutoGenerado"
        Me.txtAutoGenerado.ReadOnly = True
        Me.txtAutoGenerado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAutoGenerado.Size = New System.Drawing.Size(280, 167)
        Me.txtAutoGenerado.TabIndex = 9
        Me.txtAutoGenerado.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Signos Objetivos y Datos Autogenerados"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(604, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Factura Asociada"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(768, 339)
        Me.txtFactura.MaxLength = 5
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(98, 20)
        Me.txtFactura.TabIndex = 33
        '
        'botCancel
        '
        Me.botCancel.BackColor = System.Drawing.SystemColors.Control
        Me.botCancel.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancel.Location = New System.Drawing.Point(6, 645)
        Me.botCancel.Name = "botCancel"
        Me.botCancel.Size = New System.Drawing.Size(120, 23)
        Me.botCancel.TabIndex = 35
        Me.botCancel.Text = "Cancelar"
        Me.botCancel.UseVisualStyleBackColor = False
        '
        'botOK
        '
        Me.botOK.BackColor = System.Drawing.SystemColors.Control
        Me.botOK.BackgroundImage = Global.Historias.My.Resources.Resources.BotonOFF
        Me.botOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botOK.Location = New System.Drawing.Point(868, 645)
        Me.botOK.Name = "botOK"
        Me.botOK.Size = New System.Drawing.Size(120, 23)
        Me.botOK.TabIndex = 36
        Me.botOK.Text = "Ok"
        Me.botOK.UseVisualStyleBackColor = False
        '
        'txtPagador
        '
        Me.txtPagador.Location = New System.Drawing.Point(768, 313)
        Me.txtPagador.MaxLength = 30
        Me.txtPagador.Name = "txtPagador"
        Me.txtPagador.Size = New System.Drawing.Size(214, 20)
        Me.txtPagador.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(642, 316)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Pagador"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radCanceladoElMismoDia
        '
        Me.radCanceladoElMismoDia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radCanceladoElMismoDia.Location = New System.Drawing.Point(3, 8)
        Me.radCanceladoElMismoDia.Name = "radCanceladoElMismoDia"
        Me.radCanceladoElMismoDia.Size = New System.Drawing.Size(146, 17)
        Me.radCanceladoElMismoDia.TabIndex = 0
        Me.radCanceladoElMismoDia.TabStop = True
        Me.radCanceladoElMismoDia.Text = "Cancelado el mismo día"
        Me.radCanceladoElMismoDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radCanceladoElMismoDia.UseVisualStyleBackColor = True
        '
        'radCancaladoOtroDia
        '
        Me.radCancaladoOtroDia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radCancaladoOtroDia.Location = New System.Drawing.Point(3, 31)
        Me.radCancaladoOtroDia.Name = "radCancaladoOtroDia"
        Me.radCancaladoOtroDia.Size = New System.Drawing.Size(146, 17)
        Me.radCancaladoOtroDia.TabIndex = 1
        Me.radCancaladoOtroDia.TabStop = True
        Me.radCancaladoOtroDia.Text = "Cancelado otro día"
        Me.radCancaladoOtroDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radCancaladoOtroDia.UseVisualStyleBackColor = True
        '
        'radPagoPendiente
        '
        Me.radPagoPendiente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radPagoPendiente.Location = New System.Drawing.Point(3, 54)
        Me.radPagoPendiente.Name = "radPagoPendiente"
        Me.radPagoPendiente.Size = New System.Drawing.Size(146, 17)
        Me.radPagoPendiente.TabIndex = 2
        Me.radPagoPendiente.TabStop = True
        Me.radPagoPendiente.Text = "Pago pendiente"
        Me.radPagoPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.radPagoPendiente.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Día"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(55, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Mes"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(97, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Año"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelEligeFechaDePago2
        '
        Me.panelEligeFechaDePago2.Controls.Add(Me.txtAño)
        Me.panelEligeFechaDePago2.Controls.Add(Me.txtMes)
        Me.panelEligeFechaDePago2.Controls.Add(Me.txtDia)
        Me.panelEligeFechaDePago2.Controls.Add(Me.labValidacionDeFecha)
        Me.panelEligeFechaDePago2.Controls.Add(Me.Label13)
        Me.panelEligeFechaDePago2.Controls.Add(Me.Label15)
        Me.panelEligeFechaDePago2.Controls.Add(Me.Label14)
        Me.panelEligeFechaDePago2.Location = New System.Drawing.Point(755, 133)
        Me.panelEligeFechaDePago2.Name = "panelEligeFechaDePago2"
        Me.panelEligeFechaDePago2.Size = New System.Drawing.Size(234, 66)
        Me.panelEligeFechaDePago2.TabIndex = 21
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(100, 19)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(35, 20)
        Me.txtAño.TabIndex = 5
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(58, 19)
        Me.txtMes.MaxLength = 2
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(35, 20)
        Me.txtMes.TabIndex = 3
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(13, 19)
        Me.txtDia.MaxLength = 2
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(35, 20)
        Me.txtDia.TabIndex = 1
        '
        'labValidacionDeFecha
        '
        Me.labValidacionDeFecha.BackColor = System.Drawing.Color.LightGreen
        Me.labValidacionDeFecha.Location = New System.Drawing.Point(13, 45)
        Me.labValidacionDeFecha.Name = "labValidacionDeFecha"
        Me.labValidacionDeFecha.Size = New System.Drawing.Size(138, 13)
        Me.labValidacionDeFecha.TabIndex = 6
        Me.labValidacionDeFecha.Text = "Fecha Válida"
        Me.labValidacionDeFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labFechaDePago
        '
        Me.labFechaDePago.BackColor = System.Drawing.SystemColors.Info
        Me.labFechaDePago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFechaDePago.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFechaDePago.Location = New System.Drawing.Point(768, 209)
        Me.labFechaDePago.Name = "labFechaDePago"
        Me.labFechaDePago.Size = New System.Drawing.Size(82, 20)
        Me.labFechaDePago.TabIndex = 23
        Me.labFechaDePago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(614, 213)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Fecha de Pago"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelEligeFechaDePago1
        '
        Me.panelEligeFechaDePago1.Controls.Add(Me.radCancaladoOtroDia)
        Me.panelEligeFechaDePago1.Controls.Add(Me.radCanceladoElMismoDia)
        Me.panelEligeFechaDePago1.Controls.Add(Me.radPagoPendiente)
        Me.panelEligeFechaDePago1.Location = New System.Drawing.Point(593, 126)
        Me.panelEligeFechaDePago1.Name = "panelEligeFechaDePago1"
        Me.panelEligeFechaDePago1.Size = New System.Drawing.Size(156, 77)
        Me.panelEligeFechaDePago1.TabIndex = 20
        '
        'txtFormaDePago
        '
        Me.txtFormaDePago.AutoCompleteCustomSource.AddRange(New String() {"Efectivo", "Cheque", "Transferencia Elec", "Deposito Bancario", "Movil Pago"})
        Me.txtFormaDePago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtFormaDePago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFormaDePago.Location = New System.Drawing.Point(768, 235)
        Me.txtFormaDePago.MaxLength = 30
        Me.txtFormaDePago.Name = "txtFormaDePago"
        Me.txtFormaDePago.Size = New System.Drawing.Size(214, 20)
        Me.txtFormaDePago.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(617, 238)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Forma de Pago"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(663, 264)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Banco"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(768, 261)
        Me.txtBanco.MaxLength = 30
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(214, 20)
        Me.txtBanco.TabIndex = 27
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(768, 287)
        Me.txtReferencia.MaxLength = 8
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(214, 20)
        Me.txtReferencia.TabIndex = 29
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(642, 290)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Referencia"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormAnotaEnLaAgenda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtBanco)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtFormaDePago)
        Me.Controls.Add(Me.panelEligeFechaDePago1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.labFechaDePago)
        Me.Controls.Add(Me.panelEligeFechaDePago2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPagador)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAutoGenerado)
        Me.Controls.Add(Me.PanelProximaConsulta)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPendiente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.botCancel)
        Me.Controls.Add(Me.txtTto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIDx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.botOK)
        Me.Controls.Add(Me.labCedula)
        Me.Controls.Add(Me.labNombre)
        Me.Controls.Add(Me.labNumero)
        Me.Controls.Add(Me.labFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormAnotaEnLaAgenda"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edición de Agenda"
        Me.PanelProximaConsulta.ResumeLayout(False)
        Me.PanelProximaConsulta.PerformLayout()
        Me.panelEligeFechaDePago2.ResumeLayout(False)
        Me.panelEligeFechaDePago2.PerformLayout()
        Me.panelEligeFechaDePago1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image

    'datos de pantalla
    Dim FechaConsulta As Date
    Dim Nombre As String
    Dim Cedula As String
    Dim NumeroHistoria As String
    Dim NumeroCompleto As String
    Dim IDX As String
    Dim Tto As String
    Dim Pendiente As String
    Dim ProximaConsulta As String
    Dim LugardeConsulta As String
    Dim Monto As String
    'nuevas
    Dim FormaDePago As String
    Dim Banco As String
    Dim Referencia As String
    Dim FechaDePago As Date
    Dim Factura As String
    Dim Pagador As String



    'Variables del entorno

    Dim ExisteEsteControl As Boolean 'para saber si se esta modificando o creando un control para este dia
    Dim PendienteConsulta As Boolean 'para saber si se esta pagando una consulta proxima
    Dim ArchivosProximosRespaldados As Boolean ' para saber si se respaldaron datos proximos
    Dim ArchivosControlesRespaldados As Boolean 'para saber si se respaldaron
    Dim RefrescarProximos As Boolean 'bandera para saber si hay que refrescar ventana de prox citas

    'variables de archivo
    Dim ArchivoPropioAGD As String
    Dim ArchivoIndice As String
    Dim ArchivoIndiceProximos As String
    Dim ArchivoControlDiario As String
    Dim ArchivoControlMensual As String
    Dim ArchivoControlAnual As String

    'variables de Respaldo de archivos
    Dim ArchivoPropioAgdBAK As String
    Dim ArchivoIndiceBAK As String
    Dim ArchivoIndiceProximosBAK As String
    Dim ArchivoControlDiarioBAK As String
    Dim ArchivoControlMensualBAK As String
    Dim ArchivoControlAnualBAK As String

    Dim ArchivoProximaCita As String
    Dim ArchivoProximaCitaBAK As String

    Dim ArchivoDeGuardias As String

    'variables de structura y array correspondientes nuevas en pantalla
    Dim Tipo01 As Form1.TablaDeArchivosPropiosDeAgenda
    Dim Tipo02 As Form1.TablaDeArchivosIndiceControlesAGD
    Dim Tipo03 As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual
    Dim Tipo04 As Form1.TablaDeArchivosDeProximosControles
    Dim Tipo05 As Form1.TablaDeArchivosDeIndiceDeProximosControles

    Dim Array01 As New ArrayList()
    Dim Array02 As New ArrayList()
    Dim Array03 As New ArrayList()
    Dim Array04 As New ArrayList()
    Dim Array05 As New ArrayList()

    Dim NumeroControlesEnIndice As Integer
    Dim NumeroControlesEnElPropio As Integer
    Dim NumeroProximosControlesEnIndice As Integer
    Dim FechaPendienteProximaConsulta As Date





    Private Sub BotCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancel.Click
        If ExisteEsteControl = False Then
            'es un control nuevo del dia se recuperan solo los proximos
            If ArchivosProximosRespaldados = True Then
                'se cancela procedimiento de anotar en la agenda regresa los cambios efectuados
                'primero borra los archivos agd modificados
                File.Delete(ArchivoIndiceProximos)
                If File.Exists(ArchivoProximaCita) Then
                    File.Delete(ArchivoProximaCita)
                End If

                'ahora saca el respaldo y los regresa
                File.Copy(ArchivoIndiceProximosBAK, ArchivoIndiceProximos)
                If File.Exists(ArchivoProximaCitaBAK) = True Then
                    File.Copy(ArchivoProximaCitaBAK, ArchivoProximaCita)
                End If

                'ahora borra los bak
                File.Delete(ArchivoIndiceProximosBAK)
                If File.Exists(ArchivoProximaCitaBAK) = True Then
                    File.Delete(ArchivoProximaCitaBAK)
                End If
            End If
        Else
            'es un control que se esta modificando
            'recupera todo porq se cancelo el proceso y se dejo todo como al principio
            If ArchivosProximosRespaldados = True Then
                'se cancela procedimiento de anotar en la agenda regresa los cambios efectuados
                'primero borra los archivos agd modificados
                File.Delete(ArchivoIndiceProximos)
                If File.Exists(ArchivoProximaCita) Then
                    File.Delete(ArchivoProximaCita)
                End If

                'ahora saca el respaldo y los regresa
                File.Copy(ArchivoIndiceProximosBAK, ArchivoIndiceProximos)
                If File.Exists(ArchivoProximaCitaBAK) = True Then
                    File.Copy(ArchivoProximaCitaBAK, ArchivoProximaCita)
                End If

                'ahora borra los bak
                File.Delete(ArchivoIndiceProximosBAK)
                If File.Exists(ArchivoProximaCitaBAK) = True Then
                    File.Delete(ArchivoProximaCitaBAK)
                End If
            End If
            If ArchivosControlesRespaldados = True Then
                'primero borra los archivos agd modificados
                File.Delete(ArchivoIndice)
                If File.Exists(ArchivoPropioAGD) = True Then
                    File.Delete(ArchivoPropioAGD)
                End If
                If File.Exists(ArchivoControlDiario) = True Then
                    File.Delete(ArchivoControlDiario)
                End If
                If File.Exists(ArchivoControlMensual) = True Then
                    File.Delete(ArchivoControlMensual)
                End If
                If File.Exists(ArchivoControlAnual) = True Then
                    File.Delete(ArchivoControlAnual)
                End If

                'ahora saca el respaldo y los regresa
                File.Copy(ArchivoIndiceBAK, ArchivoIndice)
                File.Copy(ArchivoPropioAgdBAK, ArchivoPropioAGD)
                File.Copy(ArchivoControlDiarioBAK, ArchivoControlDiario)
                File.Copy(ArchivoControlMensualBAK, ArchivoControlMensual)
                File.Copy(ArchivoControlAnualBAK, ArchivoControlAnual)
                'ahora borra los bak
                File.Delete(ArchivoIndiceBAK)
                File.Delete(ArchivoPropioAgdBAK)
                File.Delete(ArchivoControlDiarioBAK)
                File.Delete(ArchivoControlMensualBAK)
                File.Delete(ArchivoControlAnualBAK)
            End If
        End If
        'sal de la ventana
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub FormAnotaEnLaAgenda_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        If Form1.PSbooEdicionRapidaDeLaConsulta = True Then
            'se esta editando desde la vista de agenda seguro para acomodar o añadir el # de factura
            Form1.PSbooEdicionRapidaDeLaConsulta = False 'apaga la bandera
            txtFactura.Focus() 'da el foco
        Else
            'se esta abriendo normal apunta al inicio
            txtIDx.Focus()
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento de inicio: recupera nombres y cargaindicesControles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub FormAnotaEnLaAgenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RecuperaNombres()
        CargaIndiceDeControles()
        CargaGuardias()



        'dicotomiza para los q se van a escribir o editar y los q se van a borrar
        If Form1.AnotaTrueBorraFalseEnLaAgenda = True Then 'se va a anotar o editar
            If ExisteEsteControl = False Then
                'se esta introduciendo un control nuevo a la agenda
                InicializaEstructuraEnBlanco()
                'solo respalda los archivos proximos ya que los otros son nuevos del dia
                RespaldaProximos()
            Else
                'se esta modificando un control existente puede o no ser el ultimo
                InicializaEstructuraLlena()
                'MsgBox("Se está modificando un control existente, se muestra el contenido de lo introducido previamente...", MsgBoxStyle.Information, "Agenda")
                'se debe respaldar todo ya que no solo los proximos pueden cambiar sino lo que se acaba de introducir en los archivos de control
                RespaldaProximos()
                'ahora se respaldan los controles entrados el mismo dia hace un momento
                RespaldaControles()
                'parte de refresco de la ventana de prox citas
                If RefrescarProximos = True Then
                    BuscaCitasProximas()
                End If

            End If

            GeneraNotasAutomaticas()

        Else
            'se va a borrar la fecha seleccionada... veremos como hago
            Dim reply As MsgBoxResult

            reply = MsgBox("Estas seguro de querer eliminar la Consulta del día " & FechaConsulta.ToLongDateString & " de la Agenda?", MsgBoxStyle.YesNo, "Eliminar Consulta de la Agenda...")
            If reply = MsgBoxResult.Yes Then
                EliminaConsultaSeleccionada()

                'INFORMA LO HECHO
                MsgBox("se ha eliminado satisfactoriamente de la Agenda la Consulta del día: " & FechaConsulta.ToShortDateString, MsgBoxStyle.Information, "Consulta Eliminada")
                'sal de la ventana
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                'sal de la ventana
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If


        End If

    End Sub

    Private Sub RecuperaNombres()

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

        'recupera datos varios de form1
        FechaConsulta = Form1.PSdateFechaDeArraqueDeAgenda
        Nombre = Form1.PSstrPacienteSeleccionadaNombre
        Cedula = Form1.PSstrPacienteSeleccionadaCedula
        NumeroHistoria = Form1.PSstrNumeroHistoriaSeleccionada
        NumeroCompleto = Form1.NumeroDeHistoriaCompleto

        'recupera de form1 nombres de archivos relacionados
        ArchivoPropioAGD = Form1.ArchivoPropioAGD
        ArchivoIndice = Form1.ArchivoIndice
        ArchivoIndiceProximos = Form1.ArchivoIndiceProximos
        ArchivoControlDiario = Form1.ArchivoControlDiario
        ArchivoControlMensual = Form1.ArchivoControlMensual
        ArchivoControlAnual = Form1.ArchivoControlAnual
        'el archivo de proxima cita diario se debe calcular cuando se seleccione la fecha en cuestion...

        'recupera nombre .BAK
        ArchivoPropioAgdBAK = Form1.ArchivoPropioAgdBAK
        ArchivoIndiceBAK = Form1.ArchivoIndiceBAK
        ArchivoIndiceProximosBAK = Form1.ArchivoIndiceProximosBAK
        ArchivoControlDiarioBAK = Form1.ArchivoControlDiarioBAK
        ArchivoControlMensualBAK = Form1.ArchivoControlMensualBAK
        ArchivoControlAnualBAK = Form1.ArchivoControlAnualBAK

        'nombre del archivo de guardias
        ArchivoDeGuardias = Form1.PSstrPathAgendaBDH & "\Guardias.agd"

    End Sub

    Private Sub CargaIndiceDeControles()
        Dim FS As FileStream
        Dim BR As BinaryReader

        ExisteEsteControl = False
        RefrescarProximos = False
        'PendienteConsulta = False   porque se saca de form1
        NumeroControlesEnIndice = 0
        NumeroProximosControlesEnIndice = 0



        If File.Exists(ArchivoIndice) = True Then
            'existe un indice, lo carga

            FS = New FileStream(ArchivoIndice, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim H As New Form1.TablaDeArchivosIndiceControlesAGD()
            Dim C As Integer
            Array02.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                H = Nothing
                ' Read fields and populate structure
                H.a01Fecha = BR.ReadString
                H.a02NumeroHistoria = BR.ReadString
                H.a03Nombre = BR.ReadString
                Array02.Add(H)
                NumeroControlesEnIndice += 1
                C = BR.PeekChar
            End While

            BR.Close()
            FS.Close()

            'revisa si la base de datos esta o no vacia 
            If NumeroControlesEnIndice > 0 Then

                'la agenda contiene al menos un dato , revisa si esta consulta ya existe en el indice

                Dim RA As New Form1.TablaDeArchivosIndiceControlesAGD
                Dim FechaParaComparar As Date
                Dim NumeroParaComparar As String = ""
                Dim Indice As Integer = 0


                For Indice = 0 To Array02.Count - 1
                    RA = Array02(Indice) 'carga en RA el dato del indice actual del for next
                    FechaParaComparar = CType(RA.a01Fecha, Date) 'se saca la fecha del array(indice)
                    If FechaConsulta = FechaParaComparar Then 'si la fecha es igual a la seleccionada para anotar...
                        'revisa el numero de historia eliminando en num prefijo "STGR-"
                        If Form1.NumPrefijo <> "" Then
                            NumeroParaComparar = RA.a02NumeroHistoria.Replace(Form1.NumPrefijo, "")
                            NumeroParaComparar = NumeroParaComparar.Substring(0, 6)
                        Else
                            NumeroParaComparar = RA.a02NumeroHistoria.Substring(0, 6)
                        End If

                        If NumeroHistoria = NumeroParaComparar Then
                            'este control existe en la agenda
                            ExisteEsteControl = True
                            Exit For
                        End If
                    End If


                Next
            Else
                'la agenda esta vacia , ExisteEsteControl sigue = false
            End If

            'ahora revisa los indices de proximas consultas
            'recupera datos de proximas consultas
            PendienteConsulta = Form1.PendienteConsulta
            If PendienteConsulta = True Then
                FechaPendienteProximaConsulta = Form1.FechaPendienteProximaConsulta
            Else
                'no hay una consulta pendiente
            End If

        Else
            'no existe un indice general, se debe estar empezando a usar la agenda
            'crea el directorio de la agenda si no existe
            If Directory.Exists(Form1.PSstrPathAgendaBDH) = False Then
                Directory.CreateDirectory(Form1.PSstrPathAgendaBDH)
            End If
            'crea un indice de controles en blanco
            FS = New FileStream(ArchivoIndice, FileMode.Create, FileAccess.ReadWrite)
            FS.Close()
            'crea un indice de proximos controles en blanco
            FS = New FileStream(ArchivoIndiceProximos, FileMode.Create, FileAccess.ReadWrite)
            FS.Close()
        End If
    End Sub

    Private Sub CargaGuardias()
        '000000000000000000000000000000000000000000000
        'parte de las fechas que tienen guardias

        Dim U As New ArrayList() 'FechasConConsultaMes
        Dim GU As New Form1.EstructuraGuardias
        Dim Fecha As Date

        Dim arrFechas() As Date


        U.Clear()

        If File.Exists(ArchivoDeGuardias) = True Then
            'existe un archivo de control de mes, lo lee
            FS = New FileStream(ArchivoDeGuardias, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'Dim Contador As Integer = -1
            C = BR.PeekChar
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
                'añade la fecha a la arraylist
                Fecha = CType(GU.a01Fecha, Date)
                U.Add(Fecha)
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            ReDim arrFechas(U.Count)
            'pone el array de fechas en negrita en el calendario
            Dim intContador As Integer = 0
            For Each est As Date In U
                arrFechas(intContador) = est
                intContador += 1
            Next

            Me.Calendario1.BoldedDates = arrFechas
            Me.Calendario1.UpdateBoldedDates()
        End If
    End Sub


    'inicializa los autogenerados
    Dim strAutoGeneradoControlObs As String = ""
    Dim strAutoGeneradoEco As String = ""

    'esta guarda el nombredel control obstetrico actual
    Dim strArchivoControlObsDelPteSeleccionado As String
    Dim arrEmbarazosDeLaPteSeleccionada As New ArrayList
    Dim R As New Form1.TablaDeDatosObstetricos
    'el archivo de ecos personales
    Dim strArchivoControlEcoDelPteSeleccionado As String
    Dim arrEcosDelPacienteActual As New ArrayList
    Dim H As New Form1.TablaDeDatosEcograficos()

    Dim O As New FormControlObstetrico.TablaDeDatosRescatadosDelControlObs
    Dim D As New FormControlObstetrico.TablaDeDatosRescatadosDelEco

    Dim FS As FileStream
    Dim BR As BinaryReader
    Dim C As Integer

    Dim strFUR As String = ""
    Dim dateFUR As Date = Nothing
    Dim dateFecha As Date = Nothing

    Private Sub GeneraNotasAutomaticas()

        'carga controles obstetricos
        subCargaControlesObstetricosDeLaPteSeleccionada()
        'Busca los datos adecuados segun fecha seleccionada
        subBuscaDatosObstetricosDeLaFechaSeleccionada()
        'Genera las notas obs automaticas
        subGeneraNotasObstetricasAutomaticas()

        'carga controles ecograficos
        subCargaEcografiasDeLaPteSeleccionada()
        'Busca los datos adecuados segun fecha seleccionada
        subBuscaDatosEcograficosDeLaFechaSeleccionada()
        'Genera las notas eco automaticas
        subGeneraNotasEcograficasAutomaticas()

        'muestra las Notas automaticas en su textbox
        txtAutoGenerado.Text = strAutoGeneradoControlObs & vbCrLf & strAutoGeneradoEco

    End Sub

    Private Sub subCargaControlesObstetricosDeLaPteSeleccionada()
        'carga los controles obstetricos de la pte seleccionada
        strArchivoControlObsDelPteSeleccionado = Form1.strArchivoControlObstetricoDelPteSeleccionado
        If File.Exists(strArchivoControlObsDelPteSeleccionado) Then
            'si existe lo lee
            FS = New FileStream(strArchivoControlObsDelPteSeleccionado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            arrEmbarazosDeLaPteSeleccionada.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                R = Nothing
                ' Read fields and populate structure

                R.FechaInicioControl = BR.ReadString
                R.ObservacionesIniciales = BR.ReadString
                R.FUR = BR.ReadString
                R.ParidadInicial = BR.ReadString
                R.TerminoGestacion = BR.ReadString
                R.ControlTerminoEn = BR.ReadString
                R.PesoInicial = BR.ReadString
                R.IDx = BR.ReadString
                R.ObservacionesPrivadas = BR.ReadString
                R.Fecha00 = BR.ReadString : R.Fecha01 = BR.ReadString : R.Fecha02 = BR.ReadString : R.Fecha03 = BR.ReadString : R.Fecha04 = BR.ReadString : R.Fecha05 = BR.ReadString
                R.Fecha06 = BR.ReadString : R.Fecha07 = BR.ReadString : R.Fecha08 = BR.ReadString : R.Fecha09 = BR.ReadString : R.Fecha10 = BR.ReadString
                R.Fecha11 = BR.ReadString : R.Fecha12 = BR.ReadString : R.Fecha13 = BR.ReadString : R.Fecha14 = BR.ReadString : R.Fecha15 = BR.ReadString
                R.Fecha16 = BR.ReadString
                R.Peso00 = BR.ReadString : R.Peso01 = BR.ReadString : R.Peso02 = BR.ReadString : R.Peso03 = BR.ReadString : R.Peso04 = BR.ReadString : R.Peso05 = BR.ReadString
                R.Peso06 = BR.ReadString : R.Peso07 = BR.ReadString : R.Peso08 = BR.ReadString : R.Peso09 = BR.ReadString : R.Peso10 = BR.ReadString
                R.Peso11 = BR.ReadString : R.Peso12 = BR.ReadString : R.Peso13 = BR.ReadString : R.Peso14 = BR.ReadString : R.Peso15 = BR.ReadString
                R.Peso16 = BR.ReadString
                R.TAS00 = BR.ReadString : R.TAS01 = BR.ReadString : R.TAS02 = BR.ReadString : R.TAS03 = BR.ReadString : R.TAS04 = BR.ReadString : R.TAS05 = BR.ReadString
                R.TAS06 = BR.ReadString : R.TAS07 = BR.ReadString : R.TAS08 = BR.ReadString : R.TAS09 = BR.ReadString : R.TAS10 = BR.ReadString
                R.TAS11 = BR.ReadString : R.TAS12 = BR.ReadString : R.TAS13 = BR.ReadString : R.TAS14 = BR.ReadString : R.TAS15 = BR.ReadString
                R.TAS16 = BR.ReadString
                R.TAD00 = BR.ReadString : R.TAD01 = BR.ReadString : R.TAD02 = BR.ReadString : R.TAD03 = BR.ReadString : R.TAD04 = BR.ReadString : R.TAD05 = BR.ReadString
                R.TAD06 = BR.ReadString : R.TAD07 = BR.ReadString : R.TAD08 = BR.ReadString : R.TAD09 = BR.ReadString : R.TAD10 = BR.ReadString
                R.TAD11 = BR.ReadString : R.TAD12 = BR.ReadString : R.TAD13 = BR.ReadString : R.TAD14 = BR.ReadString : R.TAD15 = BR.ReadString
                R.TAD16 = BR.ReadString
                R.Edema00 = BR.ReadString : R.Edema01 = BR.ReadString : R.Edema02 = BR.ReadString : R.Edema03 = BR.ReadString : R.Edema04 = BR.ReadString : R.Edema05 = BR.ReadString
                R.Edema06 = BR.ReadString : R.Edema07 = BR.ReadString : R.Edema08 = BR.ReadString : R.Edema09 = BR.ReadString : R.Edema10 = BR.ReadString
                R.Edema11 = BR.ReadString : R.Edema12 = BR.ReadString : R.Edema13 = BR.ReadString : R.Edema14 = BR.ReadString : R.Edema15 = BR.ReadString
                R.Edema16 = BR.ReadString
                R.AU00 = BR.ReadString : R.AU01 = BR.ReadString : R.AU02 = BR.ReadString : R.AU03 = BR.ReadString : R.AU04 = BR.ReadString : R.AU05 = BR.ReadString
                R.AU06 = BR.ReadString : R.AU07 = BR.ReadString : R.AU08 = BR.ReadString : R.AU09 = BR.ReadString : R.AU10 = BR.ReadString
                R.AU11 = BR.ReadString : R.AU12 = BR.ReadString : R.AU13 = BR.ReadString : R.AU14 = BR.ReadString : R.AU15 = BR.ReadString
                R.AU16 = BR.ReadString
                R.Pres00 = BR.ReadString : R.Pres01 = BR.ReadString : R.Pres02 = BR.ReadString : R.Pres03 = BR.ReadString : R.Pres04 = BR.ReadString : R.Pres05 = BR.ReadString
                R.Pres06 = BR.ReadString : R.Pres07 = BR.ReadString : R.Pres08 = BR.ReadString : R.Pres09 = BR.ReadString : R.Pres10 = BR.ReadString
                R.Pres11 = BR.ReadString : R.Pres12 = BR.ReadString : R.Pres13 = BR.ReadString : R.Pres14 = BR.ReadString : R.Pres15 = BR.ReadString
                R.Pres16 = BR.ReadString
                R.Sit00 = BR.ReadString : R.Sit01 = BR.ReadString : R.Sit02 = BR.ReadString : R.Sit03 = BR.ReadString : R.Sit04 = BR.ReadString : R.Sit05 = BR.ReadString
                R.Sit06 = BR.ReadString : R.Sit07 = BR.ReadString : R.Sit08 = BR.ReadString : R.Sit09 = BR.ReadString : R.Sit10 = BR.ReadString
                R.Sit11 = BR.ReadString : R.Sit12 = BR.ReadString : R.Sit13 = BR.ReadString : R.Sit14 = BR.ReadString : R.Sit15 = BR.ReadString
                R.Sit16 = BR.ReadString
                R.MF00 = BR.ReadString : R.MF01 = BR.ReadString : R.MF02 = BR.ReadString : R.MF03 = BR.ReadString : R.MF04 = BR.ReadString : R.MF05 = BR.ReadString
                R.MF06 = BR.ReadString : R.MF07 = BR.ReadString : R.MF08 = BR.ReadString : R.MF09 = BR.ReadString : R.MF10 = BR.ReadString
                R.MF11 = BR.ReadString : R.MF12 = BR.ReadString : R.MF13 = BR.ReadString : R.MF14 = BR.ReadString : R.MF15 = BR.ReadString
                R.MF16 = BR.ReadString
                R.FF00 = BR.ReadString : R.FF01 = BR.ReadString : R.FF02 = BR.ReadString : R.FF03 = BR.ReadString : R.FF04 = BR.ReadString : R.FF05 = BR.ReadString
                R.FF06 = BR.ReadString : R.FF07 = BR.ReadString : R.FF08 = BR.ReadString : R.FF09 = BR.ReadString : R.FF10 = BR.ReadString
                R.FF11 = BR.ReadString : R.FF12 = BR.ReadString : R.FF13 = BR.ReadString : R.FF14 = BR.ReadString : R.FF15 = BR.ReadString
                R.FF16 = BR.ReadString
                R.Obs00 = BR.ReadString : R.Obs01 = BR.ReadString : R.Obs02 = BR.ReadString : R.Obs03 = BR.ReadString : R.Obs04 = BR.ReadString : R.Obs05 = BR.ReadString
                R.Obs06 = BR.ReadString : R.Obs07 = BR.ReadString : R.Obs08 = BR.ReadString : R.Obs09 = BR.ReadString : R.Obs10 = BR.ReadString
                R.Obs11 = BR.ReadString : R.Obs12 = BR.ReadString : R.Obs13 = BR.ReadString : R.Obs14 = BR.ReadString : R.Obs15 = BR.ReadString
                R.Obs16 = BR.ReadString
                R.Comentarios = BR.ReadString

                R.FechaLab00 = BR.ReadString : R.FechaLab01 = BR.ReadString : R.FechaLab02 = BR.ReadString : R.FechaLab03 = BR.ReadString : R.FechaLab04 = BR.ReadString : R.FechaLab05 = BR.ReadString
                R.FechaLab06 = BR.ReadString : R.FechaLab07 = BR.ReadString
                R.Hb00 = BR.ReadString : R.Hb01 = BR.ReadString : R.Hb02 = BR.ReadString : R.Hb03 = BR.ReadString : R.Hb04 = BR.ReadString : R.Hb05 = BR.ReadString
                R.Hb06 = BR.ReadString : R.Hb07 = BR.ReadString
                R.Hto00 = BR.ReadString : R.Hto01 = BR.ReadString : R.Hto02 = BR.ReadString : R.Hto03 = BR.ReadString : R.Hto04 = BR.ReadString : R.Hto05 = BR.ReadString
                R.Hto06 = BR.ReadString : R.Hto07 = BR.ReadString
                R.GB00 = BR.ReadString : R.GB01 = BR.ReadString : R.GB02 = BR.ReadString : R.GB03 = BR.ReadString : R.GB04 = BR.ReadString : R.GB05 = BR.ReadString
                R.GB06 = BR.ReadString : R.GB07 = BR.ReadString
                R.Seg00 = BR.ReadString : R.Seg01 = BR.ReadString : R.Seg02 = BR.ReadString : R.Seg03 = BR.ReadString : R.Seg04 = BR.ReadString : R.Seg05 = BR.ReadString
                R.Seg06 = BR.ReadString : R.Seg07 = BR.ReadString
                R.Lin00 = BR.ReadString : R.Lin01 = BR.ReadString : R.Lin02 = BR.ReadString : R.Lin03 = BR.ReadString : R.Lin04 = BR.ReadString : R.Lin05 = BR.ReadString
                R.Lin06 = BR.ReadString : R.Lin07 = BR.ReadString
                R.Mon00 = BR.ReadString : R.Mon01 = BR.ReadString : R.Mon02 = BR.ReadString : R.Mon03 = BR.ReadString : R.Mon04 = BR.ReadString : R.Mon05 = BR.ReadString
                R.Mon06 = BR.ReadString : R.Mon07 = BR.ReadString
                R.Plaq00 = BR.ReadString : R.Plaq01 = BR.ReadString : R.Plaq02 = BR.ReadString : R.Plaq03 = BR.ReadString : R.Plaq04 = BR.ReadString : R.Plaq05 = BR.ReadString
                R.Plaq06 = BR.ReadString : R.Plaq07 = BR.ReadString
                R.PT00 = BR.ReadString : R.PT01 = BR.ReadString : R.PT02 = BR.ReadString : R.PT03 = BR.ReadString : R.PT04 = BR.ReadString : R.PT05 = BR.ReadString
                R.PT06 = BR.ReadString : R.PT07 = BR.ReadString
                R.PTT00 = BR.ReadString : R.PTT01 = BR.ReadString : R.PTT02 = BR.ReadString : R.PTT03 = BR.ReadString : R.PTT04 = BR.ReadString : R.PTT05 = BR.ReadString
                R.PTT06 = BR.ReadString : R.PTT07 = BR.ReadString
                R.Gli00 = BR.ReadString : R.Gli01 = BR.ReadString : R.Gli02 = BR.ReadString : R.Gli03 = BR.ReadString : R.Gli04 = BR.ReadString : R.Gli05 = BR.ReadString
                R.Gli06 = BR.ReadString : R.Gli07 = BR.ReadString
                R.Crea00 = BR.ReadString : R.Crea01 = BR.ReadString : R.Crea02 = BR.ReadString : R.Crea03 = BR.ReadString : R.Crea04 = BR.ReadString : R.Crea05 = BR.ReadString
                R.Crea06 = BR.ReadString : R.Crea07 = BR.ReadString
                R.VDRL00 = BR.ReadString : R.VDRL01 = BR.ReadString : R.VDRL02 = BR.ReadString : R.VDRL03 = BR.ReadString : R.VDRL04 = BR.ReadString : R.VDRL05 = BR.ReadString
                R.VDRL06 = BR.ReadString : R.VDRL07 = BR.ReadString
                R.HIV00 = BR.ReadString : R.HIV01 = BR.ReadString : R.HIV02 = BR.ReadString : R.HIV03 = BR.ReadString : R.HIV04 = BR.ReadString : R.HIV05 = BR.ReadString
                R.HIV06 = BR.ReadString : R.HIV07 = BR.ReadString
                R.Tox00 = BR.ReadString : R.Tox01 = BR.ReadString : R.Tox02 = BR.ReadString : R.Tox03 = BR.ReadString : R.Tox04 = BR.ReadString : R.Tox05 = BR.ReadString
                R.Tox06 = BR.ReadString : R.Tox07 = BR.ReadString
                R.Tipiaje00 = BR.ReadString : R.Tipiaje01 = BR.ReadString : R.Tipiaje02 = BR.ReadString : R.Tipiaje03 = BR.ReadString : R.Tipiaje04 = BR.ReadString : R.Tipiaje05 = BR.ReadString
                R.Tipiaje06 = BR.ReadString : R.Tipiaje07 = BR.ReadString
                R.Coombs00 = BR.ReadString : R.Coombs01 = BR.ReadString : R.Coombs02 = BR.ReadString : R.Coombs03 = BR.ReadString : R.Coombs04 = BR.ReadString : R.Coombs05 = BR.ReadString
                R.Coombs06 = BR.ReadString : R.Coombs07 = BR.ReadString
                R.TipiajeEsp00 = BR.ReadString : R.TipiajeEsp01 = BR.ReadString : R.TipiajeEsp02 = BR.ReadString : R.TipiajeEsp03 = BR.ReadString : R.TipiajeEsp04 = BR.ReadString : R.TipiajeEsp05 = BR.ReadString
                R.TipiajeEsp06 = BR.ReadString : R.TipiajeEsp07 = BR.ReadString
                R.OtroExA = BR.ReadString
                R.OtroExA00 = BR.ReadString : R.OtroExA01 = BR.ReadString : R.OtroExA02 = BR.ReadString : R.OtroExA03 = BR.ReadString : R.OtroExA04 = BR.ReadString : R.OtroExA05 = BR.ReadString
                R.OtroExA06 = BR.ReadString : R.OtroExA07 = BR.ReadString
                R.OtroExB = BR.ReadString
                R.OtroExB00 = BR.ReadString : R.OtroExB01 = BR.ReadString : R.OtroExB02 = BR.ReadString : R.OtroExB03 = BR.ReadString : R.OtroExB04 = BR.ReadString : R.OtroExB05 = BR.ReadString
                R.OtroExB06 = BR.ReadString : R.OtroExB07 = BR.ReadString
                R.OtroExC = BR.ReadString
                R.OtroExC00 = BR.ReadString : R.OtroExC01 = BR.ReadString : R.OtroExC02 = BR.ReadString : R.OtroExC03 = BR.ReadString : R.OtroExC04 = BR.ReadString
                R.NombreDelControl = BR.ReadString
                R.Adicional01 = BR.ReadString
                R.ImpresionDx = BR.ReadString
                R.Orina = BR.ReadString
                R.Urocultivo = BR.ReadString
                R.Heces = BR.ReadString

                arrEmbarazosDeLaPteSeleccionada.Add(R)

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()


        Else 'no existe el archivo

            'no hay datos obstetricos para el paciente inicializa la arrray en blanco
            arrEmbarazosDeLaPteSeleccionada.Clear()

        End If

    End Sub
    Private Sub subBuscaDatosObstetricosDeLaFechaSeleccionada()
        'busca datos de la fecha seleccionada si existen
        Dim strFechaBuscadaSDS = Form1.PSdateFechaDeArraqueDeAgenda.ToShortDateString

        'inicializa a O
        O = Nothing

        'busca datos del control obs
        For Each est As Form1.TablaDeDatosObstetricos In arrEmbarazosDeLaPteSeleccionada

            'obtiene la FUR del embarazo revisado actual
            strFUR = est.FUR

            'revisa las fechas del control actual para ver cual coincide y sacar los datos de ahi
            If strFechaBuscadaSDS = est.Fecha00 Then
                'saca los datos de la linea 00
                dateFecha = CType(est.Fecha00, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso00 : O.a03TAS = est.TAS00 : O.a04TAD = est.TAD00
                O.a05Ede = est.Edema00 : O.a06AU = est.AU00 : O.a07MF = est.MF00 : O.a08FF = est.FF00
                O.a09Obs = est.Obs00
            ElseIf strFechaBuscadaSDS = est.Fecha01 Then
                'saca los datos de la linea 01
                dateFecha = CType(est.Fecha01, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso01 : O.a03TAS = est.TAS01 : O.a04TAD = est.TAD01
                O.a05Ede = est.Edema01 : O.a06AU = est.AU01 : O.a07MF = est.MF01 : O.a08FF = est.FF01
                O.a09Obs = est.Obs01
            ElseIf strFechaBuscadaSDS = est.Fecha02 Then
                'saca los datos de la linea 02
                dateFecha = CType(est.Fecha02, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso02 : O.a03TAS = est.TAS02 : O.a04TAD = est.TAD02
                O.a05Ede = est.Edema02 : O.a06AU = est.AU02 : O.a07MF = est.MF02 : O.a08FF = est.FF02
                O.a09Obs = est.Obs02
            ElseIf strFechaBuscadaSDS = est.Fecha03 Then
                'saca los datos de la linea 03
                dateFecha = CType(est.Fecha03, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso03 : O.a03TAS = est.TAS03 : O.a04TAD = est.TAD03
                O.a05Ede = est.Edema03 : O.a06AU = est.AU03 : O.a07MF = est.MF03 : O.a08FF = est.FF03
                O.a09Obs = est.Obs03
            ElseIf strFechaBuscadaSDS = est.Fecha04 Then
                'saca los datos de la linea 04
                dateFecha = CType(est.Fecha04, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso04 : O.a03TAS = est.TAS04 : O.a04TAD = est.TAD04
                O.a05Ede = est.Edema04 : O.a06AU = est.AU04 : O.a07MF = est.MF04 : O.a08FF = est.FF04
                O.a09Obs = est.Obs04
            ElseIf strFechaBuscadaSDS = est.Fecha05 Then
                'saca los datos de la linea 05
                dateFecha = CType(est.Fecha05, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso05 : O.a03TAS = est.TAS05 : O.a04TAD = est.TAD05
                O.a05Ede = est.Edema05 : O.a06AU = est.AU05 : O.a07MF = est.MF05 : O.a08FF = est.FF05
                O.a09Obs = est.Obs05
            ElseIf strFechaBuscadaSDS = est.Fecha06 Then
                'saca los datos de la linea 06
                dateFecha = CType(est.Fecha06, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso06 : O.a03TAS = est.TAS06 : O.a04TAD = est.TAD06
                O.a05Ede = est.Edema06 : O.a06AU = est.AU06 : O.a07MF = est.MF06 : O.a08FF = est.FF06
                O.a09Obs = est.Obs06
            ElseIf strFechaBuscadaSDS = est.Fecha07 Then
                'saca los datos de la linea 07
                dateFecha = CType(est.Fecha07, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso07 : O.a03TAS = est.TAS07 : O.a04TAD = est.TAD07
                O.a05Ede = est.Edema07 : O.a06AU = est.AU07 : O.a07MF = est.MF07 : O.a08FF = est.FF07
                O.a09Obs = est.Obs07
            ElseIf strFechaBuscadaSDS = est.Fecha08 Then
                'saca los datos de la linea 08
                dateFecha = CType(est.Fecha08, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso08 : O.a03TAS = est.TAS08 : O.a04TAD = est.TAD08
                O.a05Ede = est.Edema08 : O.a06AU = est.AU08 : O.a07MF = est.MF08 : O.a08FF = est.FF08
                O.a09Obs = est.Obs08
            ElseIf strFechaBuscadaSDS = est.Fecha09 Then
                'saca los datos de la linea 09
                dateFecha = CType(est.Fecha09, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso09 : O.a03TAS = est.TAS09 : O.a04TAD = est.TAD09
                O.a05Ede = est.Edema09 : O.a06AU = est.AU09 : O.a07MF = est.MF09 : O.a08FF = est.FF09
                O.a09Obs = est.Obs09
            ElseIf strFechaBuscadaSDS = est.Fecha10 Then
                'saca los datos de la linea 10
                dateFecha = CType(est.Fecha10, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso10 : O.a03TAS = est.TAS10 : O.a04TAD = est.TAD10
                O.a05Ede = est.Edema10 : O.a06AU = est.AU10 : O.a07MF = est.MF10 : O.a08FF = est.FF10
                O.a09Obs = est.Obs10
            ElseIf strFechaBuscadaSDS = est.Fecha11 Then
                'saca los datos de la linea 11
                dateFecha = CType(est.Fecha11, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso11 : O.a03TAS = est.TAS11 : O.a04TAD = est.TAD11
                O.a05Ede = est.Edema11 : O.a06AU = est.AU11 : O.a07MF = est.MF11 : O.a08FF = est.FF11
                O.a09Obs = est.Obs11
            ElseIf strFechaBuscadaSDS = est.Fecha12 Then
                'saca los datos de la linea 12
                dateFecha = CType(est.Fecha12, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso12 : O.a03TAS = est.TAS12 : O.a04TAD = est.TAD12
                O.a05Ede = est.Edema12 : O.a06AU = est.AU12 : O.a07MF = est.MF12 : O.a08FF = est.FF12
                O.a09Obs = est.Obs12
            ElseIf strFechaBuscadaSDS = est.Fecha13 Then
                'saca los datos de la linea 13
                dateFecha = CType(est.Fecha13, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso13 : O.a03TAS = est.TAS13 : O.a04TAD = est.TAD13
                O.a05Ede = est.Edema13 : O.a06AU = est.AU13 : O.a07MF = est.MF13 : O.a08FF = est.FF13
                O.a09Obs = est.Obs13
            ElseIf strFechaBuscadaSDS = est.Fecha14 Then
                'saca los datos de la linea 14
                dateFecha = CType(est.Fecha14, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso14 : O.a03TAS = est.TAS14 : O.a04TAD = est.TAD14
                O.a05Ede = est.Edema14 : O.a06AU = est.AU14 : O.a07MF = est.MF14 : O.a08FF = est.FF14
                O.a09Obs = est.Obs14
            ElseIf strFechaBuscadaSDS = est.Fecha15 Then
                'saca los datos de la linea 15
                dateFecha = CType(est.Fecha15, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso15 : O.a03TAS = est.TAS15 : O.a04TAD = est.TAD15
                O.a05Ede = est.Edema15 : O.a06AU = est.AU15 : O.a07MF = est.MF15 : O.a08FF = est.FF15
                O.a09Obs = est.Obs15
            ElseIf strFechaBuscadaSDS = est.Fecha16 Then
                'saca los datos de la linea 16
                dateFecha = CType(est.Fecha16, Date)
                O.a01EG = funcionCalculaEGretornaStringXXsXXd(dateFecha)
                O.a02Peso = est.Peso16 : O.a03TAS = est.TAS16 : O.a04TAD = est.TAD16
                O.a05Ede = est.Edema16 : O.a06AU = est.AU16 : O.a07MF = est.MF16 : O.a08FF = est.FF16
                O.a09Obs = est.Obs16
            End If


        Next
    End Sub
    Function funcionCalculaEGretornaStringXXsXXd(ByVal dateFechaConsulta As Date) As String

        Dim Semanas As Long = 0
        Dim Calculo As Double
        Dim Dias As Integer
        Dim EG As Long

        If IsDate(strFUR) Then
            dateFUR = CType(strFUR, Date)
        Else
            Return "FUR ??"
        End If

        EG = (DateDiff(DateInterval.Day, dateFUR, dateFechaConsulta))
        If EG <= 0 Then
            Return "??"
        ElseIf EG > 294 Then
            Return "+42s"
        Else
            Semanas = EG \ 7
            Calculo = (EG / 7) - Semanas
            If Calculo = 0 Then
                Dias = 0
            Else
                Dias = CInt(Calculo * 7)
            End If
            Return Semanas & "s" & " " & Dias & "d"
        End If
    End Function
    Private Sub subGeneraNotasObstetricasAutomaticas()

        'revisa si hay consulta obstetrica en esta fecha
        If O.a01EG = Nothing Then
            strAutoGeneradoControlObs += "No Hay Datos Obstétricos en esta fecha..." & vbCrLf
            Exit Sub 'sal prematuramente no hay datos
        End If

        'si llega aca hay algo lo genera
        Dim booEcribioAlgoEnLaLinea As Boolean = False

        strAutoGeneradoControlObs = "DATOS DEL CONTROL OBSTETRICO" & vbCrLf


        '1ra linea
        strAutoGeneradoControlObs += "Edad Gestacional x FUR: " & O.a01EG & ". " & vbCrLf

        '2da linea
        booEcribioAlgoEnLaLinea = False
        If IsNumeric(O.a02Peso) Then
            strAutoGeneradoControlObs += "Peso: " & O.a02Peso & " Kg. "
            booEcribioAlgoEnLaLinea = True
        End If
        If IsNumeric(O.a03TAS) And IsNumeric(O.a04TAD) Then
            strAutoGeneradoControlObs += "TA: " & O.a03TAS & "/" & O.a04TAD & " mmHg."
            booEcribioAlgoEnLaLinea = True
        End If
        'revisa si escribio algo
        If booEcribioAlgoEnLaLinea = True Then
            strAutoGeneradoControlObs += vbCrLf
        End If

        '3ra linea
        booEcribioAlgoEnLaLinea = False
        If O.a05Ede <> "" Then
            strAutoGeneradoControlObs += "Edema: " & O.a05Ede & "  "
            booEcribioAlgoEnLaLinea = True
        End If
        If IsNumeric(O.a06AU) Then
            strAutoGeneradoControlObs += "AU: " & O.a06AU & " cm. "
            booEcribioAlgoEnLaLinea = True
        End If
        If O.a07MF <> "" Then
            strAutoGeneradoControlObs += "MF: " & O.a07MF & "  "
            booEcribioAlgoEnLaLinea = True
        End If
        If O.a08FF <> "" Then
            If O.a08FF.IndexOf("+"c) > -1 Or O.a08FF.IndexOf("-"c) > -1 Then
                strAutoGeneradoControlObs += "FF: " & O.a08FF
                booEcribioAlgoEnLaLinea = True
            ElseIf IsNumeric(O.a08FF) Then
                strAutoGeneradoControlObs += "FF: " & O.a08FF & " lpm."
                booEcribioAlgoEnLaLinea = True
            End If
        End If
        'revisa si escribio algo
        If booEcribioAlgoEnLaLinea = True Then
            strAutoGeneradoControlObs += vbCrLf
        End If

        '4ta linea
        If O.a09Obs <> "" Then
            strAutoGeneradoControlObs += "Observaciones: " & O.a09Obs & vbCrLf
        End If
    End Sub

    Private Sub subCargaEcografiasDeLaPteSeleccionada()
        'carga el archivo de ecos personal
        strArchivoControlEcoDelPteSeleccionado = Form1.strArchivoControlEcograficoDelPteSeleccionado

        If File.Exists(strArchivoControlEcoDelPteSeleccionado) = True Then

            'existe el archivo lo lee
            FS = New FileStream(strArchivoControlEcoDelPteSeleccionado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)


            arrEcosDelPacienteActual.Clear()

            C = BR.PeekChar
            While FS.Position < FS.Length
                H = Nothing
                ' Read fields and populate structure
                H.c00TipoDeEstudio = BR.ReadString
                H.c01FechaControl = BR.ReadString
                H.c02Paridad = BR.ReadString
                H.c03FUR = BR.ReadString
                H.c04FPP = BR.ReadString
                H.c05EGxFUR = BR.ReadString
                H.c06IDx = BR.ReadString
                H.c07Nombre = BR.ReadString
                H.c08Edad = BR.ReadString
                H.d01SGlongitudinal = BR.ReadString
                H.d02SGanteroposterior = BR.ReadString
                H.d03SGtransversal = BR.ReadString
                H.d04LCC = BR.ReadString
                H.d05ImplatacionSG = BR.ReadString
                H.d06EmbrionVisible = BR.ReadString
                H.d07MovimientosPresentes = BR.ReadString
                H.d08ActividadCardiaca = BR.ReadString
                H.d09Comentarios1erT = BR.ReadString
                H.d10OtroA = BR.ReadString
                H.d11AdicionalesB1erT = BR.ReadString
                H.d12IDxAdicionales1erT = BR.ReadString
                H.d13Adicionales1erT = BR.ReadString
                H.e01Presentacion = BR.ReadString
                H.e02Situacion = BR.ReadString
                H.e03Posicion = BR.ReadString
                H.e04Cabeza = BR.ReadString
                H.e05Ventriculos = BR.ReadString
                H.e06Columna = BR.ReadString
                H.e07Torax = BR.ReadString
                H.e08Corazon = BR.ReadString
                H.e09Abdomen = BR.ReadString
                H.e10Riñones = BR.ReadString
                H.e11Extremidades = BR.ReadString
                H.e12Notas01del2y3erT = BR.ReadString
                H.e13DiametroBiParietal = BR.ReadString
                H.e14DiametroOccipitoFrontal = BR.ReadString
                H.e15DiametroAnteroPosteriorTorax = BR.ReadString
                H.e16DiametroAnteroPosteriorCorazon = BR.ReadString
                H.e17aDiametroAnteroPosteriorAbdomen = BR.ReadString
                H.e17bDiametroTransversoAbdomen = BR.ReadString
                H.e18Aorta = BR.ReadString
                H.e19VenaCava = BR.ReadString
                H.e20LongitudSacro = BR.ReadString
                H.e21LongitudFemur = BR.ReadString
                H.e22Actitud = BR.ReadString
                H.e23Tono = BR.ReadString
                H.e24MovimientosFetales = BR.ReadString
                H.e25ActividadCardiaca = BR.ReadString
                H.e26MovimientosRespiratorios = BR.ReadString
                H.e27RelacionAortoCava = BR.ReadString
                H.e28CamaraGastrica = BR.ReadString
                H.e29Intestino = BR.ReadString
                H.e30Vejiga = BR.ReadString
                H.e31Notas02del2y3erT = BR.ReadString
                H.e32LocalizacionPlacenta = BR.ReadString
                H.e33GrosorPlacenta = BR.ReadString
                H.e34GradoPlacenta = BR.ReadString
                H.e35LiquidoAmniotico = BR.ReadString
                H.e36ILA = BR.ReadString
                H.e37CordonUmbilical = BR.ReadString
                H.e38Notas03del2y3erT = BR.ReadString
                H.e39Embarazo = BR.ReadString
                H.e40Feto = BR.ReadString
                H.e41BiometricosAdicionales = BR.ReadString
                H.e42Rostro = BR.ReadString
                H.e43Sexo = BR.ReadString
                H.f01Menopausia = BR.ReadString
                H.f02EstudioPorVia = BR.ReadString
                H.f03UteroLongitudinal = BR.ReadString
                H.f04UteroAnteroposterior = BR.ReadString
                H.f05UteroTransverso = BR.ReadString
                H.f06OvarioDerechoLongitudinal = BR.ReadString
                H.f07OvarioDerechoTransverso = BR.ReadString
                H.f08OvarioDerechoAnteroPosterior = BR.ReadString
                H.f09OvarioIzquierdoLongitudinal = BR.ReadString
                H.f10OvarioIzquierdoTransverso = BR.ReadString
                H.f11OvarioIzquierdoAnteroPosterior = BR.ReadString
                H.f12FoliculoDerecho01 = BR.ReadString
                H.f13FoliculoDerecho02 = BR.ReadString
                H.f14FoliculoDerecho03 = BR.ReadString
                H.f15FoliculoDerecho04 = BR.ReadString
                H.f16FoliculoIzquierdo01 = BR.ReadString
                H.f17FoliculoIzquierdo02 = BR.ReadString
                H.f18FoliculoIzquierdo03 = BR.ReadString
                H.f19FoliculoIzquierdo04 = BR.ReadString
                H.f20EndometrioGrosor = BR.ReadString
                H.f21ObsGinecologicas = BR.ReadString
                H.f22OtrosA = BR.ReadString
                H.f23OtrosB = BR.ReadString
                H.f24OtrosC = BR.ReadString
                H.f25AdicionalesGin = BR.ReadString
                H.r01SGPromedio = BR.ReadString
                H.r02EGxSG = BR.ReadString
                H.r03EGxLCC = BR.ReadString
                H.r04EG1erT = BR.ReadString
                H.r05DBPc = BR.ReadString
                H.r06CirCef = BR.ReadString
                H.r07IndCef = BR.ReadString
                H.r08CirAbd = BR.ReadString
                H.r09DBF = BR.ReadString
                H.r10EGxDBP = BR.ReadString
                H.r11EGxDBPc = BR.ReadString
                H.r12EGxCC = BR.ReadString
                H.r13EGxCA = BR.ReadString
                H.r14EGxFemur = BR.ReadString
                H.r15PesoEstimado = BR.ReadString
                H.r16PesoenBaseA = BR.ReadString
                H.r17EG2y3erT = BR.ReadString
                H.r18DiaCiclo = BR.ReadString
                H.r19OtroA = BR.ReadString
                H.r20OtroB = BR.ReadString
                H.r21OtroC = BR.ReadString
                H.e44ChorizoDiagnostico = BR.ReadString
                H.c09NombreInforme = BR.ReadString

                arrEcosDelPacienteActual.Add(H)

                'inicia llenado del array de fechas de controles anteriores para despues ordenarlas

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

        Else
            'no hay datos ecograficos para el paciente inicializa la arrray en blanco
            arrEcosDelPacienteActual.Clear()
        End If

    End Sub
    Private Sub subBuscaDatosEcograficosDeLaFechaSeleccionada()
        'busca datos de la fecha seleccionada si existen
        Dim strFechaBuscadaSDS = Form1.PSdateFechaDeArraqueDeAgenda.ToShortDateString


        D = Nothing

        For Each est As Form1.TablaDeDatosEcograficos In arrEcosDelPacienteActual
            Dim dateFechaComparada As Date = CType(est.c01FechaControl, Date)
            Dim strFechaComparadaSDS As String = dateFechaComparada.ToShortDateString

            If strFechaBuscadaSDS = strFechaComparadaSDS Then
                'este es el hombre. primero saca todos los datos directos


                'ahora verifica que tipo de eco es
                If est.c00TipoDeEstudio = "1" Then
                    'es del 1er trim
                    D.a00TipoDeEstudio = "1erTrim"
                    If est.d04LCC <> "" Then
                        D.a01DCN = est.d04LCC
                    Else
                        D.a01DCN = "-"
                    End If

                    'saca los de chorizo biometrico 2 del 1er trimestre
                    If est.d11AdicionalesB1erT <> "" Then 'revisa q ya este convertido
                        Dim arrPartesBiometricasAdicionales1erT() = est.d11AdicionalesB1erT.Split("|"c)

                        'verifica si tienen datos numericos validos
                        If IsNumeric(arrPartesBiometricasAdicionales1erT(0)) Then 'dbp 1er t
                            D.a02DBP = arrPartesBiometricasAdicionales1erT(0)
                        Else
                            D.a02DBP = "-"
                        End If

                        If IsNumeric(arrPartesBiometricasAdicionales1erT(1)) Then 'cc del 1er t
                            D.a03CC = arrPartesBiometricasAdicionales1erT(1)
                        Else
                            D.a03CC = "-"
                        End If

                        If IsNumeric(arrPartesBiometricasAdicionales1erT(2)) Then 'ca del 1er t
                            D.a04CA = arrPartesBiometricasAdicionales1erT(2)
                        Else
                            D.a04CA = "-"
                        End If

                        If IsNumeric(arrPartesBiometricasAdicionales1erT(3)) Then
                            D.a05FEM = arrPartesBiometricasAdicionales1erT(3)
                        Else
                            D.a05FEM = "-"
                        End If
                    Else
                        'es viejo y no tiene 2do chorizo del 1er trim todo a guioncito
                        D.a02DBP = "-"
                        D.a03CC = "-"
                        D.a04CA = "-"
                        D.a05FEM = "-"
                    End If

                    D.a06PesoEst = "-"
                    D.a07Talla = "-"

                    'saca la edad gestacional del 1er trim
                    If est.r04EG1erT <> "Faltan Datos" And est.r04EG1erT <> "" Then
                        Dim strEG1erTrimLong As String = est.r04EG1erT
                        If strEG1erTrimLong.IndexOf("Exactas.") > -1 Then
                            'es de terminacion exacta, sustiutuye toda las letras x S
                            D.a08EGxEco = strEG1erTrimLong.Replace(" Semanas Exactas.", "s 0d")
                        ElseIf strEG1erTrimLong.IndexOf("días.") > -1 Then
                            'se temina en distinto de 1 dia
                            D.a08EGxEco = strEG1erTrimLong.Replace(" Semanas y", "s")
                            D.a08EGxEco = D.a08EGxEco.Replace(" días.", "d")
                        Else
                            'se tiene q haber terminado en 1 dia
                            D.a08EGxEco = strEG1erTrimLong.Replace(" Semanas y", "s")
                            D.a08EGxEco = D.a08EGxEco.Replace(" día.", "d")
                        End If
                    Else
                        D.a08EGxEco = "N/A"
                    End If

                    D.a09Percen = "-"

                    'el saco gestacional
                    Dim intTotal As Integer = 0
                    Dim intCuenta As Integer = 0
                    'verifica datos validos
                    If IsNumeric(est.d01SGlongitudinal) Then
                        intTotal += est.d01SGlongitudinal
                        intCuenta += 1
                    End If
                    If IsNumeric(est.d02SGanteroposterior) Then
                        intTotal += est.d02SGanteroposterior
                        intCuenta += 1
                    End If
                    If IsNumeric(est.d03SGtransversal) Then
                        intTotal += est.d03SGtransversal
                        intCuenta += 1
                    End If
                    'saca promedio si puede y lo coloca en la estructurita
                    If intCuenta > 0 Then
                        'hay datos los calcula
                        D.a10SG = intTotal \ intCuenta
                    Else
                        D.a10SG = "-"
                    End If

                    'la presentacion y situacion
                    D.a11Pres = "-"
                    D.a12Sit = "-"

                ElseIf est.c00TipoDeEstudio = "2" Then

                    'es del 2y3 trim
                    D.a00TipoDeEstudio = "2doy3erTrim"
                    D.a01DCN = "-"
                    If IsNumeric(est.e13DiametroBiParietal) Then
                        D.a02DBP = est.e13DiametroBiParietal
                    Else
                        D.a02DBP = "-"
                    End If
                    If IsNumeric(est.e21LongitudFemur) Then
                        D.a05FEM = est.e21LongitudFemur
                    Else
                        D.a05FEM = "-"
                    End If

                    'saca los de chorizo biometrico
                    If est.e41BiometricosAdicionales <> "" Then 'revisa q ya este convertido
                        Dim arrPartesBiometricas() = est.e41BiometricosAdicionales.Split("|"c)

                        'verifica si tienen datos numericos validos
                        If IsNumeric(arrPartesBiometricas(0)) Then
                            D.a03CC = arrPartesBiometricas(0)
                        Else
                            D.a03CC = "-"
                        End If

                        If IsNumeric(arrPartesBiometricas(6)) Then
                            D.a04CA = arrPartesBiometricas(6)
                        Else
                            D.a04CA = "-"
                        End If

                        If IsNumeric(arrPartesBiometricas(14)) Then
                            D.a06PesoEst = arrPartesBiometricas(14)
                        Else
                            D.a06PesoEst = "-"
                        End If

                        If IsNumeric(arrPartesBiometricas(15)) Then
                            D.a07Talla = arrPartesBiometricas(15)
                        Else
                            D.a07Talla = "-"
                        End If
                    Else
                        'es viejo y no tiene chorizo biometrico todo a guioncito
                        D.a03CC = "-"
                        D.a04CA = "-"
                        D.a06PesoEst = "-"
                        D.a07Talla = "-"
                    End If


                    'ahora revisa el chorizodx del 2y3er trim
                    If est.e44ChorizoDiagnostico <> "" Then
                        Dim arrPartesDxDel2y3erTrim() = est.e44ChorizoDiagnostico.Split("|"c)

                        'saca la edad gestacional del 2y3er trim
                        If arrPartesDxDel2y3erTrim(0) <> "@" And arrPartesDxDel2y3erTrim(0) <> "Faltan datos." Then
                            Dim strEG2y3erTrimLong As String = arrPartesDxDel2y3erTrim(0)
                            If strEG2y3erTrimLong.IndexOf("Exactas.") > -1 Then
                                'es de terminacion exacta, sustiutuye toda las letras x S
                                D.a08EGxEco = strEG2y3erTrimLong.Replace(" Semanas Exactas.", "s 0d")
                            ElseIf strEG2y3erTrimLong.IndexOf("días.") > -1 Then
                                'se temina en distinto de 1 dia
                                D.a08EGxEco = strEG2y3erTrimLong.Replace(" Semanas y", "s")
                                D.a08EGxEco = D.a08EGxEco.Replace(" días.", "d")
                            Else
                                'se tiene q haber terminado en 1 dia
                                D.a08EGxEco = strEG2y3erTrimLong.Replace(" Semanas y", "s")
                                D.a08EGxEco = D.a08EGxEco.Replace(" día.", "d")
                            End If
                        Else
                            D.a08EGxEco = "N/A"
                        End If


                        'el percentil
                        If IsNumeric(arrPartesDxDel2y3erTrim(1)) Then
                            D.a09Percen = arrPartesDxDel2y3erTrim(1)
                        Else
                            D.a09Percen = "-"
                        End If

                    Else
                        'no tiene datos en el chorizo dx
                        D.a08EGxEco = "N/A"
                        D.a09Percen = "-"
                    End If


                    'el saco gestacional
                    D.a10SG = "-"

                    'la pres 
                    If est.e01Presentacion = "1" Then
                        D.a11Pres = "Cef"
                    ElseIf est.e01Presentacion = "2" Then
                        D.a11Pres = "Pod"
                    Else
                        D.a11Pres = "-"
                    End If

                    'la situacion
                    If est.e02Situacion = "1" Then
                        D.a12Sit = "Long"
                    ElseIf est.e02Situacion = "2" Then
                        D.a12Sit = "Obli"
                    Else
                        D.a12Sit = "Tras"
                    End If

                Else
                    'es un eco ginecologico aca en la agenda debe decir algo


                End If


                Exit For
            End If
        Next


    End Sub
    Private Sub subGeneraNotasEcograficasAutomaticas()

        'inicializa autogenerado
        strAutoGeneradoEco = ""

        If D.a00TipoDeEstudio = Nothing Then
            'no hay eco asociado en esta fecha
            strAutoGeneradoEco += "No se ha realizado ECOGRAFIA en este día."
        ElseIf D.a00TipoDeEstudio = "1erTrim" Then
            'es del 1er trimestre
            strAutoGeneradoEco += "DATOS ECOGRAFICOS (1er Trimestre)" & vbCrLf
            If D.a10SG <> "-" Then
                strAutoGeneradoEco += "SG: " & D.a10SG & "mm. "
            End If
            If D.a01DCN <> "-" Then
                strAutoGeneradoEco += "DCN: " & D.a01DCN & "mm. "
            End If
            If D.a02DBP <> "-" Then
                strAutoGeneradoEco += "DBP: " & D.a02DBP & "mm. "
            End If
            If D.a03CC <> "-" Then
                strAutoGeneradoEco += "CC: " & D.a03CC & "mm. "
            End If
            If D.a04CA <> "-" Then
                strAutoGeneradoEco += "CA: " & D.a04CA & "mm. "
            End If
            If D.a05FEM <> "-" Then
                strAutoGeneradoEco += "Fem: " & D.a05FEM & "mm."
            End If

            If D.a10SG <> "-" Or D.a01DCN <> "-" Or D.a02DBP <> "-" Or D.a03CC <> "-" Or D.a04CA <> "-" Or D.a05FEM <> "-" Then
                'si se escribio algo entonces baja la linea
                strAutoGeneradoEco += vbCrLf
            End If
            strAutoGeneradoEco += "Edad Gestacional x Eco: " & D.a08EGxEco & vbCrLf

        ElseIf D.a00TipoDeEstudio = "2doy3erTrim" Then
            'es del 2do y 3er trimestre
            strAutoGeneradoEco += "DATOS ECOGRAFICOS (2do y 3er Trimestre)" & vbCrLf
            If D.a11Pres <> "-" Then
                strAutoGeneradoEco += "Presentación: " & D.a11Pres & ", Situación: " & D.a12Sit & "." & vbCrLf
            Else
                strAutoGeneradoEco += "Presentación: n/a, Situación: " & D.a12Sit & "." & vbCrLf
            End If

            'linea de los biometricos
            If D.a02DBP <> "-" Then
                strAutoGeneradoEco += "DBP: " & D.a02DBP & "mm. "
            End If
            If D.a03CC <> "-" Then
                strAutoGeneradoEco += "CC: " & D.a03CC & "mm. "
            End If
            If D.a04CA <> "-" Then
                strAutoGeneradoEco += "CA: " & D.a04CA & "mm. "
            End If
            If D.a05FEM <> "-" Then
                strAutoGeneradoEco += "Fem: " & D.a05FEM & "mm. "
            End If
            'revisa si se escribio algo
            If D.a02DBP <> "-" Or D.a03CC <> "-" Or D.a04CA <> "-" Or D.a05FEM <> "-" Then
                strAutoGeneradoEco += vbCrLf 'se escribio algo baja la linea
            End If

            'linea de peso , talla y percentil
            If D.a06PesoEst <> "-" Then
                strAutoGeneradoEco += "Peso estimado: " & D.a06PesoEst & "gr. "
            End If
            If D.a07Talla <> "-" Then
                strAutoGeneradoEco += "Talla: " & D.a07Talla & "cm. "
            End If
            If D.a09Percen <> "-" Then
                strAutoGeneradoEco += "Percentil: " & D.a09Percen & "."
            End If
            'revisa si escribio algo
            If D.a06PesoEst <> "-" Or D.a07Talla <> "-" Or D.a09Percen <> "-" Then
                strAutoGeneradoEco += vbCrLf 'se escribio algo baja la linea
            End If

            'linea de la edad ges x eco
            If D.a08EGxEco <> "-" Then
                strAutoGeneradoEco += "Edad Gestacional x Eco: " & D.a08EGxEco & vbCrLf
            End If

            'sustituciones finales
            strAutoGeneradoEco = strAutoGeneradoEco.Replace("Cef", "Cefálica")
            strAutoGeneradoEco = strAutoGeneradoEco.Replace("Pod", "Podálica")
            strAutoGeneradoEco = strAutoGeneradoEco.Replace("Long", "Longitudinal")
            strAutoGeneradoEco = strAutoGeneradoEco.Replace("Obli", "Oblícua")
            strAutoGeneradoEco = strAutoGeneradoEco.Replace("Tras", "Trasversa")

        Else
            'es ginecologico

        End If
    End Sub

    Private Sub InicializaEstructuraEnBlanco()
        'lo de la pantalla
        labFecha.Text = FechaConsulta.ToLongDateString
        labNombre.Text = Nombre
        labCedula.Text = Cedula
        labNumero.Text = NumeroCompleto

        txtAutoGenerado.Clear()
        txtIDx.Clear()
        txtTto.Clear()
        txtPendiente.Clear()
        txtMonto.Clear()
        txtLugar.Clear()

        txtFactura.Clear()
        txtPagador.Clear()
        txtBanco.Clear()
        txtReferencia.Clear()


        'Valores q se colocan inicialmente a un valor predeterminado
        FechaDePago = FechaConsulta.Date
        'labFechaDePago.Text = FechaConsulta.ToShortDateString   '  se pone automaricamente al cambiar el rad de arriba
        radCanceladoElMismoDia.Checked = True
        txtFormaDePago.Text = "Efectivo"

        'proxima cita
        CheckBoxProxima.Checked = False
        labProximaConsulta.Text = ""
        ListBoxProximas.Items.Clear()
        labListbox.Text = ""
        Calendario1.Visible = False
        labProximaConsulta.Visible = False
        ListBoxProximas.Visible = False
        labListbox.Visible = False

        'la estructura para que coincida con la pantalla
        Tipo01.a10FechaConsulta = FechaConsulta.ToString("s")
        Tipo01.a02Clinica = ""
        Tipo01.a03NotaseIDx = ""
        Tipo01.a04Tratamiento = ""
        Tipo01.a05Pendiente = ""
        Tipo01.a06ProximaConsulta = ""
        Tipo01.a07Honorarios = ""
        Tipo01.a11FacturaAsociada = ""
        Tipo01.a16Referencia = ""
        Tipo01.a15Banco = ""
        Tipo01.a14FormaDePago = txtFormaDePago.Text
        Tipo01.a13FechaDePago = FechaDePago.ToString("s")
        Tipo01.a12Pagador = ""


        'si no es la ultima consulta ni siquiera muestra la parte de proximas
        If Form1.EsLaUltimaConsultaLaSeleccionada = False Then
            PanelProximaConsulta.Visible = False
        End If
    End Sub
    Private Sub InicializaEstructuraLlena()
        Dim R As New Form1.TablaDeArchivosPropiosDeAgenda()
        Dim FS As FileStream
        Dim BR As BinaryReader
        Dim FechaProximaCita As Date
        Dim FechaComparadaDate As Date


        'carga los datos desde el archivo propio agd
        FS = New FileStream(ArchivoPropioAGD, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim C As Integer
        Array01.Clear()

        C = BR.PeekChar
        While FS.Position < FS.Length
            R = Nothing
            ' Read fields and populate structure
            R.a10FechaConsulta = BR.ReadString
            R.a02Clinica = BR.ReadString
            R.a03NotaseIDx = BR.ReadString
            R.a04Tratamiento = BR.ReadString
            R.a05Pendiente = BR.ReadString
            R.a06ProximaConsulta = BR.ReadString
            R.a07Honorarios = BR.ReadString
            R.a11FacturaAsociada = BR.ReadString
            R.a16Referencia = BR.ReadString
            R.a15Banco = BR.ReadString
            R.a14FormaDePago = BR.ReadString
            R.a13FechaDePago = BR.ReadString
            R.a12Pagador = BR.ReadString

            C = BR.PeekChar
            If IsDate(R.a10FechaConsulta) Then 'si es una fecha la compara
                FechaComparadaDate = CType(R.a10FechaConsulta, Date) 'carga la fecha del loop
                If FechaConsulta = FechaComparadaDate Then 'compara las fechas
                    Exit While 'esta es la que estoy buscando salgo del loop aqui con los datos cargados en R
                End If
            End If
        End While
        BR.Close()
        FS.Close()

        'lo de la pantalla por la historia
        labFecha.Text = FechaConsulta.ToLongDateString
        labNombre.Text = Nombre
        labCedula.Text = Cedula
        labNumero.Text = NumeroCompleto

        'lo directo segun la agenda
        txtIDx.Text = R.a03NotaseIDx
        txtTto.Text = R.a04Tratamiento
        txtPendiente.Text = R.a05Pendiente
        If R.a07Honorarios <> "" Then
            If IsNumeric(R.a07Honorarios) Then
                Dim decHonorarios = CType(R.a07Honorarios, Decimal)
                txtMonto.Text = FormatNumber(decHonorarios, 2,,, TriState.True)
            Else
                If R.a07Honorarios.Contains(",") Then
                    Dim strHonMod = R.a07Honorarios.Replace(",", ".")
                    If IsNumeric(strHonMod) Then
                        Dim decHonorarios = CType(strHonMod, Decimal)
                        txtMonto.Text = FormatNumber(decHonorarios, 2,,, TriState.True)
                    Else
                        txtMonto.Text = FormatNumber(0, 2,,, TriState.True)
                    End If

                ElseIf R.a07Honorarios.Contains(".") Then

                    Dim strHonMod = R.a07Honorarios.Replace(".", ",")
                    If IsNumeric(strHonMod) Then
                        Dim decHonorarios = CType(strHonMod, Decimal)
                        txtMonto.Text = FormatNumber(decHonorarios, 2,,, TriState.True)
                    Else
                        txtMonto.Text = FormatNumber(0, 2,,, TriState.True)
                    End If

                End If
            End If

        Else
            txtMonto.Text = FormatNumber(0, 2,,, TriState.True)
        End If

        txtLugar.Text = R.a02Clinica

        'parte nueva
        txtFactura.Text = R.a11FacturaAsociada
        txtPagador.Text = R.a12Pagador

        'la forma de pago si esta en blanco se considerara en efectivo
        If R.a14FormaDePago = "" Then
            txtFormaDePago.Text = "Efectivo"
            txtBanco.Text = ""
            txtReferencia.Text = ""
        Else
            'hay algo en los datos lo pone igualito
            txtFormaDePago.Text = R.a14FormaDePago
            txtBanco.Text = R.a15Banco
            txtReferencia.Text = R.a16Referencia
        End If

        'la fecha de pago si tiene programacion revisa que hay
        If R.a13FechaDePago = "" Then
            'ok esta en blanco es vieja se guardo asi se debe colocar por defecto al mismo dia, luego se debe incluir el cambio en lo guardado para que ya se actualice
            radCanceladoElMismoDia.Checked = True 'este cambio generara q se arregle solito lo demas
            'acomoda la fecha de pago
            FechaDePago = FechaConsulta.Date

        Else
            'debe haber una fecha, primero agarrala bien y dejala en la variable persistente date
            FechaDePago = CType(R.a13FechaDePago, Date).Date
            'ahora comparalas
            If FechaDePago = FechaConsulta.Date Then
                'ya se habia convertido al nuevo formato y fue pagada el mismo dia
                radCanceladoElMismoDia.Checked = True
            ElseIf FechaDePago = Nothing Then
                'el pago esta pendiente
                radPagoPendiente.Checked = True
            Else
                'se cancelo otro dia debe mostrar la ventanita de seleccionar fecha de pago
                radCancaladoOtroDia.Checked = True
            End If
        End If


        'el calendai depende de si hay o no prox cita
        If PendienteConsulta = True And Form1.EsLaUltimaConsultaLaSeleccionada = True Then
            'existe una proxima cita y se esta editando la ultima consulta
            CheckBoxProxima.Checked = True
            Calendario1.Visible = True
            labProximaConsulta.Visible = True
            ListBoxProximas.Visible = True
            labListbox.Visible = True

            FechaProximaCita = FechaPendienteProximaConsulta 'sale de form1 al agarrar los datos ojo...
            labProximaConsulta.Text = FechaProximaCita.ToLongDateString
            Calendario1.SelectionStart = FechaProximaCita
            'revisa que citas existen para ese dia pero sin esta misma 
            'es decir despues de respaldar, activa una bandera para refrescar datos proximos
            RefrescarProximos = True
            'BuscaCitasProximas()
        Else
            'no existe proxima cita
            labProximaConsulta.Text = R.a06ProximaConsulta
            CheckBoxProxima.Checked = False
            ListBoxProximas.Items.Clear()

            Calendario1.Visible = False
            labProximaConsulta.Visible = False
            ListBoxProximas.Visible = False
            labListbox.Visible = False
        End If

        'prende inicialmente el boton ok
        'botOK.Enabled = True

        'la estructura para que coincida con la pantalla
        Tipo01.a10FechaConsulta = FechaConsulta.ToString("s")
        Tipo01.a02Clinica = txtLugar.Text
        Tipo01.a03NotaseIDx = txtIDx.Text
        Tipo01.a04Tratamiento = txtTto.Text
        Tipo01.a05Pendiente = txtPendiente.Text
        Tipo01.a06ProximaConsulta = labProximaConsulta.Text
        Tipo01.a07Honorarios = txtMonto.Text
        Tipo01.a11FacturaAsociada = txtFactura.Text
        Tipo01.a16Referencia = txtReferencia.Text
        Tipo01.a15Banco = txtBanco.Text
        Tipo01.a14FormaDePago = txtFormaDePago.Text
        Tipo01.a13FechaDePago = FechaDePago.ToString("s")
        Tipo01.a12Pagador = txtPagador.Text

        'si no es la ultima consulta ni siquiera muestra la parte de proximas
        If Form1.EsLaUltimaConsultaLaSeleccionada = False Then
            PanelProximaConsulta.Visible = False
        End If
    End Sub

   
    Private Sub RespaldaProximos()
        Dim FS As FileStream
        Dim BW As BinaryWriter
        Dim BR As BinaryReader
        Dim REnum As IEnumerator
        Dim J As New Form1.TablaDeArchivosDeProximosControles()
        Dim K As New Form1.TablaDeArchivosDeIndiceDeProximosControles()

        ArchivosProximosRespaldados = False 'hasta ahora no se ha respaldado nada
        If PendienteConsulta = True And Form1.EsLaUltimaConsultaLaSeleccionada = True Then
            'hay una consulta proxima pendiente y se selecciono modificar la ultima 
            'q es la q tiene esos datos se debe respaldar porq se van a modificar
            'en caso de cancelar se debe restituir los archivos originales
            'si se acepta se deja asi con los datos nuevos

            'respalda archivos que pueden cambiar el indice de proximos y el proximo del dia
            'primero revisa si no se quedo un bak por ahi...
            If File.Exists(ArchivoIndiceProximosBAK) Then
                File.Delete(ArchivoIndiceProximosBAK) 'lo borra porque es viejo, no se como se quedo pero porsia
            End If
            'ahora q se que no puede haber un bak viejo hago el respaldo del actual
            File.Copy(ArchivoIndiceProximos, ArchivoIndiceProximosBAK)

            'ahora debo respaldar el archivo proximo del dia que esta en FechaPendienteProximaConsulta
            'construyo el nombre del archivo prox cita y su bak
            Dim FechaProxima As Date
            Dim Temporal, fechade8 As String
            Dim largo As Integer
            'Dim TextoAñadido As String
            Dim Año As String

            FechaProxima = FechaPendienteProximaConsulta ' esta fecha la saque de CargaIndiceDeControles q se lo copia de form1

            Temporal = FechaProxima.ToString("s")
            largo = Temporal.Length
            fechade8 = Temporal.Remove(largo - 9, 9)
            fechade8 = fechade8.Remove(4, 1)
            fechade8 = fechade8.Remove(6, 1)

            Año = FechaProxima.Year

            ArchivoProximaCita = Form1.PSstrPathAgendaBDH & "\" & Año & "\Proximo-" & fechade8 & ".agd"
            ArchivoProximaCitaBAK = Form1.PSstrPathAgendaBDH & "\" & Año & "\Proximo-" & fechade8 & ".bak"
            'ahora reviso q no haya un bak descarriado y luego respaldo
            If File.Exists(ArchivoProximaCitaBAK) Then
                File.Delete(ArchivoProximaCitaBAK) 'lo borra porque es viejo, no se como se quedo pero porsia
            End If
            'ahora q se que no puede haber un bak viejo hago el respaldo del actual si existe...
            If File.Exists(ArchivoProximaCita) Then
                File.Copy(ArchivoProximaCita, ArchivoProximaCitaBAK)
            End If


            'ya estan respaldados los dos archivos suceptibles de cambio prende la bandera
            ArchivosProximosRespaldados = True


            'ahora se deben modificar los archivos que se respaldaron
            'primero el del indice, lo lee
            FS = New FileStream(ArchivoIndiceProximos, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Dim C As Integer
            Array05.Clear()
            C = BR.PeekChar

            While FS.Position < FS.Length
                K = Nothing
                ' Read fields and populate structure
                K.a01FechaProximocontrol = BR.ReadString
                K.a02NumeroHistoria = BR.ReadString
                K.a03Nombre = BR.ReadString

                'acomoda fechas
                K.a01FechaProximocontrol = (CType(K.a01FechaProximocontrol, Date)).ToString("s")

                Array05.Add(K)


                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            Dim alsProximasConsultasOrdenadasSinLaDeLaPteActual As New ArrayList

            'recorta el array y ordena por fecha
            If Form1.NumPrefijo <> "" Then
                'hay prefijo ladilla de numero de historia
                Dim alsProximasRecortada = From est As Form1.TablaDeArchivosDeIndiceDeProximosControles In Array05 _
                                           Where NumeroHistoria <> (est.a02NumeroHistoria.Replace(Form1.NumPrefijo, "")).Substring(0, 6) _
                                           Order By est.a03Nombre _
                                           Select est
                For Each est As Form1.TablaDeArchivosDeIndiceDeProximosControles In alsProximasRecortada
                    alsProximasConsultasOrdenadasSinLaDeLaPteActual.Add(est)
                Next

            Else
                'no hay prefijo ladilla
                Dim alsProximasRecortada = From est As Form1.TablaDeArchivosDeIndiceDeProximosControles In Array05 _
                                           Where NumeroHistoria <> est.a02NumeroHistoria.Substring(0, 6) _
                                           Order By est.a01FechaProximocontrol _
                                           Select est
                For Each est As Form1.TablaDeArchivosDeIndiceDeProximosControles In alsProximasRecortada
                    alsProximasConsultasOrdenadasSinLaDeLaPteActual.Add(est)
                Next
            End If

            'ahora que tengo la array recortada veo si aun hay algun dato si es asi lo
            'escribo en el archivo, si contador es 0 entonces borro el archivo ya q
            'estaria vacio

            If alsProximasConsultasOrdenadasSinLaDeLaPteActual.Count > 0 Then
                FS = New FileStream(ArchivoIndiceProximos, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                For Each est As Form1.TablaDeArchivosDeIndiceDeProximosControles In alsProximasConsultasOrdenadasSinLaDeLaPteActual
                    BW.Write(est.a01FechaProximocontrol)
                    BW.Write(est.a02NumeroHistoria)
                    BW.Write(est.a03Nombre)
                Next
                FS.Close()
                BW.Close()

            Else
                'el archivo se quedara vacio no lo borro pero lo inicializo en blanco
                FS = New FileStream(ArchivoIndiceProximos, FileMode.Create, FileAccess.ReadWrite)
                FS.Close()
            End If

            'ahora el del archivo proximo cita diario
            'lee el achivo
            If File.Exists(ArchivoProximaCita) = True Then
                FS = New FileStream(ArchivoProximaCita, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)
                'ya se definio antes Dim C As Integer
                C = BR.PeekChar
                Array04.Clear()

                While FS.Position < FS.Length
                    J = Nothing
                    ' Read fields and populate structure
                    J.a01NumeroHistoria = BR.ReadString
                    J.a02Nombre = BR.ReadString
                    J.a03Cedula = BR.ReadString
                    J.a04ClinicaUltimoControl = BR.ReadString
                    J.a05NotaseIDxUltimoControl = BR.ReadString
                    J.a06TratamientoUltimoControl = BR.ReadString
                    J.a07Pendiente = BR.ReadString
                    J.a08FechaUltimoControl = BR.ReadString
                    J.a09HonorariosUltimoControl = BR.ReadString
                    J.a10FechaProximoControl = BR.ReadString

                    'si el que se lee no es el que se busca lo copia si no lo salta
                    Dim NumeroPaComparar As String = ""
                    If Form1.NumPrefijo <> "" Then
                        NumeroPaComparar = J.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")
                        NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                    Else
                        NumeroPaComparar = J.a01NumeroHistoria.Substring(0, 6)
                    End If

                    If NumeroPaComparar <> NumeroHistoria Then
                        Array04.Add(J) 'no era el que buscaba lo añado
                    Else
                        'este es el que busco no lo añado a la array
                    End If
                    C = BR.PeekChar
                End While
                BR.Close()
                FS.Close()

                'ahora que tengo la array recortada veo si aun hay algun dato si es asi lo
                'escribo en el archivo, si contador es 0 entonces borro el archivo ya q
                'estaria vacio
                If Array04.Count > 0 Then
                    'hay algun dato paso el array modificado de vuelta al archivo
                    REnum = Array04.GetEnumerator
                    FS = New FileStream(ArchivoProximaCita, FileMode.Create, FileAccess.Write)
                    BW = New BinaryWriter(FS)
                    BW.BaseStream.Seek(0, SeekOrigin.Begin)
                    While REnum.MoveNext
                        J = CType(REnum.Current, Form1.TablaDeArchivosDeProximosControles)
                        BW.Write(J.a01NumeroHistoria)
                        BW.Write(J.a02Nombre)
                        BW.Write(J.a03Cedula)
                        BW.Write(J.a04ClinicaUltimoControl)
                        BW.Write(J.a05NotaseIDxUltimoControl)
                        BW.Write(J.a06TratamientoUltimoControl)
                        BW.Write(J.a07Pendiente)
                        BW.Write(J.a08FechaUltimoControl)
                        BW.Write(J.a09HonorariosUltimoControl)
                        BW.Write(J.a10FechaProximoControl)
                    End While
                    FS.Close()
                    BW.Close()
                Else
                    'el archivo se quedara vacio mejor lo borro
                    File.Delete(ArchivoProximaCita)
                End If
            End If

        Else
            'no hay consultas pendientes o no se selecciono el ultimo control, no respalda nada
        End If

    End Sub


    Private Sub RespaldaControles()
        Dim FS As FileStream
        Dim BW As BinaryWriter
        Dim BR As BinaryReader
        Dim REnum As IEnumerator
        Dim R As New Form1.TablaDeArchivosPropiosDeAgenda()
        Dim H As New Form1.TablaDeArchivosIndiceControlesAGD()
        Dim F As New Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual()
        Dim C As Integer
        Dim ZZ As Integer ' contador
        Dim FechaComparadaDate As Date
        Dim EscribeDato As Boolean 'para saber si se escribe o no el dato

        ArchivosControlesRespaldados = False 'aun no se respalda nada

        'iniciamos con el archivo de indices de controles, se debe eliminar la ultima entrada
        'primero borra cualquier bak que haya quedado por ahi descarriado
        If File.Exists(ArchivoIndiceBAK) = True Then
            File.Delete(ArchivoIndiceBAK)
        End If
        'ahora copia el original al respaldo
        File.Copy(ArchivoIndice, ArchivoIndiceBAK)

        'respaldamos ahora los demas, el archivo propio agd
        If File.Exists(ArchivoPropioAgdBAK) = True Then
            File.Delete(ArchivoPropioAgdBAK)
        End If
        'ahora copia el original al respaldo
        File.Copy(ArchivoPropioAGD, ArchivoPropioAgdBAK)

        'el control diario
        If File.Exists(ArchivoControlDiarioBAK) = True Then
            File.Delete(ArchivoControlDiarioBAK)
        End If
        'ahora copia el original al respaldo
        File.Copy(ArchivoControlDiario, ArchivoControlDiarioBAK)

        'el control mensual
        If File.Exists(ArchivoControlMensualBAK) = True Then
            File.Delete(ArchivoControlMensualBAK)
        End If
        'ahora copia el original al respaldo
        File.Copy(ArchivoControlMensual, ArchivoControlMensualBAK)

        'el control anual
        If File.Exists(ArchivoControlAnualBAK) = True Then
            File.Delete(ArchivoControlAnualBAK)
        End If
        'ahora copia el original al respaldo
        File.Copy(ArchivoControlAnual, ArchivoControlAnualBAK)

        ArchivosControlesRespaldados = True 'ya se respaldo todo

        'ahora a modificar los archivos quitando el dato que se va a modificar

        'primero el del archivo indice, lo lee
        FS = New FileStream(ArchivoIndice, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Array02.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H.a01Fecha = BR.ReadString
            H.a02NumeroHistoria = BR.ReadString
            H.a03Nombre = BR.ReadString
            FechaComparadaDate = CType(H.a01Fecha, Date)
            If FechaConsulta = FechaComparadaDate Then 'si es la fecha entonces
                Dim NumeroPaComparar As String = ""
                If Form1.NumPrefijo <> "" Then
                    NumeroPaComparar = H.a02NumeroHistoria.Replace(Form1.NumPrefijo, "")
                    NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                Else
                    NumeroPaComparar = H.a02NumeroHistoria.Substring(0, 6)
                End If
                If NumeroHistoria <> NumeroPaComparar Then 'revisa el #de historia y si es entonces
                    'es distinto lo escribe
                    Array02.Add(H)
                End If
            Else
                'es distinto lo escribe
                Array02.Add(H)
            End If
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'ahora los datos estan en el array recortado, escribe la array al disco
        REnum = Array02.GetEnumerator
        FS = New FileStream(ArchivoIndice, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        While REnum.MoveNext
            EscribeDato = True 'en un principio empieza escribiendo
            H = CType(REnum.Current, Form1.TablaDeArchivosIndiceControlesAGD)
            'escribe el dato
            BW.Write(H.a01Fecha)
            BW.Write(H.a02NumeroHistoria)
            BW.Write(H.a03Nombre)
        End While
        FS.Close()
        BW.Close()
        'aunque quede vacio el indice de controles, no se borra

        'vamos ahora con los archivos propios
        FS = New FileStream(ArchivoPropioAGD, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Array01.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            R = Nothing
            ' Read fields and populate structure
            R.a10FechaConsulta = BR.ReadString
            R.a02Clinica = BR.ReadString
            R.a03NotaseIDx = BR.ReadString
            R.a04Tratamiento = BR.ReadString
            R.a05Pendiente = BR.ReadString
            R.a06ProximaConsulta = BR.ReadString
            R.a07Honorarios = BR.ReadString
            R.a11FacturaAsociada = BR.ReadString
            R.a16Referencia = BR.ReadString
            R.a15Banco = BR.ReadString
            R.a14FormaDePago = BR.ReadString
            R.a13FechaDePago = BR.ReadString
            R.a12Pagador = BR.ReadString

            FechaComparadaDate = CType(R.a10FechaConsulta, Date)
            If FechaConsulta <> FechaComparadaDate Then 'si es la fecha entonces
                'es distinto lo escribe
                Array01.Add(R)
            End If
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'ahora los datos estan en el array recortado, lo escribe al disco
        REnum = Array01.GetEnumerator
        FS = New FileStream(ArchivoPropioAGD, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        ZZ = 0
        While REnum.MoveNext
            R = CType(REnum.Current, Form1.TablaDeArchivosPropiosDeAgenda)
            'escribe el dato
            BW.Write(R.a10FechaConsulta)
            BW.Write(R.a02Clinica)
            BW.Write(R.a03NotaseIDx)
            BW.Write(R.a04Tratamiento)
            BW.Write(R.a05Pendiente)
            BW.Write(R.a06ProximaConsulta)
            BW.Write(R.a07Honorarios)
            BW.Write(R.a11FacturaAsociada)
            BW.Write(R.a16Referencia)
            BW.Write(R.a15Banco)
            BW.Write(R.a14FormaDePago)
            BW.Write(R.a13FechaDePago)
            BW.Write(R.a12Pagador)
            ZZ += 1
        End While
        FS.Close()
        BW.Close()
        'si no se escribio ninguno, borra el archivo ya q esta vacio
        If ZZ = 0 Then
            File.Delete(ArchivoPropioAGD)
        Else
            'no borra el archivo porq tiene datos aun....
        End If

        '000000000000000000000000000000000000000000
        'vamos ahora con los archivos control diario
        FS = New FileStream(ArchivoControlDiario, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Array03.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            F = Nothing
            ' Read fields and populate structure
            F.a01NumeroHistoria = BR.ReadString
            F.a02Nombre = BR.ReadString
            F.a03Cedula = BR.ReadString
            F.a04Clinica = BR.ReadString
            F.a05NotaseIDx = BR.ReadString
            F.a06Tratamiento = BR.ReadString
            F.a07Pendiente = BR.ReadString
            F.a08ProximaConsulta = BR.ReadString
            F.a09Honorarios = BR.ReadString
            F.a10FechaConsulta = BR.ReadString
            F.a11FacturaAsociada = BR.ReadString
            F.a16Referencia = BR.ReadString
            F.a15Banco = BR.ReadString
            F.a14FormaDePago = BR.ReadString
            F.a13FechaDePago = BR.ReadString
            F.a12Pagador = BR.ReadString

            FechaComparadaDate = CType(F.a10FechaConsulta, Date)
            If FechaConsulta = FechaComparadaDate Then 'si es la fecha entonces
                Dim NumeroPaComparar As String = ""
                If Form1.NumPrefijo <> "" Then
                    NumeroPaComparar = F.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")
                    NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                Else
                    NumeroPaComparar = F.a01NumeroHistoria.Substring(0, 6)
                End If
                If NumeroHistoria <> NumeroPaComparar Then 'revisa la historia
                    'es distinto lo escribe
                    Array03.Add(F)
                End If
            Else
                'es distinto lo escribe
                Array03.Add(F)
            End If
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'ahora los datos estan en el array recortado, lo escribe al disco
        REnum = Array03.GetEnumerator
        FS = New FileStream(ArchivoControlDiario, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        ZZ = 0
        While REnum.MoveNext
            F = CType(REnum.Current, Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual)
            'escribe el dato
            BW.Write(F.a01NumeroHistoria)
            BW.Write(F.a02Nombre)
            BW.Write(F.a03Cedula)
            BW.Write(F.a04Clinica)
            BW.Write(F.a05NotaseIDx)
            BW.Write(F.a06Tratamiento)
            BW.Write(F.a07Pendiente)
            BW.Write(F.a08ProximaConsulta)
            BW.Write(F.a09Honorarios)
            BW.Write(F.a10FechaConsulta)
            BW.Write(F.a11FacturaAsociada)
            BW.Write(F.a16Referencia)
            BW.Write(F.a15Banco)
            BW.Write(F.a14FormaDePago)
            BW.Write(F.a13FechaDePago)
            BW.Write(F.a12Pagador)
            ZZ += 1
        End While
        FS.Close()
        BW.Close()
        'si no se escribio ninguno, borra el archivo ya q esta vacio
        If ZZ = 0 Then
            File.Delete(ArchivoControlDiario)
        Else
            'no borra el archivo porq tiene datos aun....
        End If

        '0000000000000000000000000000000000000000
        'vamos ahora con los archivos control mensual
        FS = New FileStream(ArchivoControlMensual, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Array03.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            F = Nothing
            ' Read fields and populate structure
            F.a01NumeroHistoria = BR.ReadString
            F.a02Nombre = BR.ReadString
            F.a03Cedula = BR.ReadString
            F.a04Clinica = BR.ReadString
            F.a05NotaseIDx = BR.ReadString
            F.a06Tratamiento = BR.ReadString
            F.a07Pendiente = BR.ReadString
            F.a08ProximaConsulta = BR.ReadString
            F.a09Honorarios = BR.ReadString
            F.a10FechaConsulta = BR.ReadString
            F.a11FacturaAsociada = BR.ReadString
            F.a16Referencia = BR.ReadString
            F.a15Banco = BR.ReadString
            F.a14FormaDePago = BR.ReadString
            F.a13FechaDePago = BR.ReadString
            F.a12Pagador = BR.ReadString

            FechaComparadaDate = CType(F.a10FechaConsulta, Date)
            If FechaConsulta = FechaComparadaDate Then 'si es la fecha entonces
                Dim NumeroPaComparar As String = ""
                If Form1.NumPrefijo <> "" Then
                    NumeroPaComparar = F.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")
                    NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                Else
                    NumeroPaComparar = F.a01NumeroHistoria.Substring(0, 6)
                End If
                If NumeroHistoria <> NumeroPaComparar Then 'revisa la historia
                    'es distinto lo escribe
                    Array03.Add(F)
                End If
            Else
                'es distinto lo escribe
                Array03.Add(F)
            End If
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'ahora los datos estan en el array recortado, lo escribe al disco
        REnum = Array03.GetEnumerator
        FS = New FileStream(ArchivoControlMensual, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        ZZ = 0
        While REnum.MoveNext
            F = CType(REnum.Current, Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual)
            'escribe el dato
            BW.Write(F.a01NumeroHistoria)
            BW.Write(F.a02Nombre)
            BW.Write(F.a03Cedula)
            BW.Write(F.a04Clinica)
            BW.Write(F.a05NotaseIDx)
            BW.Write(F.a06Tratamiento)
            BW.Write(F.a07Pendiente)
            BW.Write(F.a08ProximaConsulta)
            BW.Write(F.a09Honorarios)
            BW.Write(F.a10FechaConsulta)
            BW.Write(F.a11FacturaAsociada)
            BW.Write(F.a16Referencia)
            BW.Write(F.a15Banco)
            BW.Write(F.a14FormaDePago)
            BW.Write(F.a13FechaDePago)
            BW.Write(F.a12Pagador)
            ZZ += 1
        End While
        FS.Close()
        BW.Close()
        'si no se escribio ninguno, borra el archivo ya q esta vacio
        If ZZ = 0 Then
            File.Delete(ArchivoControlMensual)
        Else
            'no borra el archivo porq tiene datos aun....
        End If

        '00000000000000000000000000000000000000
        'vamos ahora con los archivos control anual
        FS = New FileStream(ArchivoControlAnual, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Array03.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            F = Nothing
            ' Read fields and populate structure
            F.a01NumeroHistoria = BR.ReadString
            F.a02Nombre = BR.ReadString
            F.a03Cedula = BR.ReadString
            F.a04Clinica = BR.ReadString
            F.a05NotaseIDx = BR.ReadString
            F.a06Tratamiento = BR.ReadString
            F.a07Pendiente = BR.ReadString
            F.a08ProximaConsulta = BR.ReadString
            F.a09Honorarios = BR.ReadString
            F.a10FechaConsulta = BR.ReadString
            F.a11FacturaAsociada = BR.ReadString
            F.a16Referencia = BR.ReadString
            F.a15Banco = BR.ReadString
            F.a14FormaDePago = BR.ReadString
            F.a13FechaDePago = BR.ReadString
            F.a12Pagador = BR.ReadString

            FechaComparadaDate = CType(F.a10FechaConsulta, Date)
            If FechaConsulta = FechaComparadaDate Then 'si es la fecha entonces
                Dim NumeroPaComparar As String = ""
                If Form1.NumPrefijo <> "" Then
                    NumeroPaComparar = F.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")
                    NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                Else
                    NumeroPaComparar = F.a01NumeroHistoria.Substring(0, 6)
                End If
                If NumeroHistoria <> NumeroPaComparar Then 'revisa la historia
                    'es distinto
                    Array03.Add(F)
                End If
            Else
                'es distinto lo escribe
                Array03.Add(F)
            End If
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'ahora los datos estan en el array recortado, lo escribe al disco
        REnum = Array03.GetEnumerator
        FS = New FileStream(ArchivoControlAnual, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        ZZ = 0
        While REnum.MoveNext
            F = CType(REnum.Current, Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual)
            'escribe el dato
            BW.Write(F.a01NumeroHistoria)
            BW.Write(F.a02Nombre)
            BW.Write(F.a03Cedula)
            BW.Write(F.a04Clinica)
            BW.Write(F.a05NotaseIDx)
            BW.Write(F.a06Tratamiento)
            BW.Write(F.a07Pendiente)
            BW.Write(F.a08ProximaConsulta)
            BW.Write(F.a09Honorarios)
            BW.Write(F.a10FechaConsulta)
            BW.Write(F.a11FacturaAsociada)
            BW.Write(F.a16Referencia)
            BW.Write(F.a15Banco)
            BW.Write(F.a14FormaDePago)
            BW.Write(F.a13FechaDePago)
            BW.Write(F.a12Pagador)
            ZZ += 1
        End While
        FS.Close()
        BW.Close()
        'si no se escribio ninguno, borra el archivo ya q esta vacio
        If ZZ = 0 Then
            File.Delete(ArchivoControlAnual)
        Else
            'no borra el archivo porq tiene datos aun....
        End If


    End Sub


    Private Sub EliminaConsultaSeleccionada()
        Dim FS As FileStream
        Dim BW As BinaryWriter
        Dim BR As BinaryReader
        Dim REnum As IEnumerator
        Dim J As New Form1.TablaDeArchivosDeProximosControles()
        Dim K As New Form1.TablaDeArchivosDeIndiceDeProximosControles()
        Dim R As New Form1.TablaDeArchivosPropiosDeAgenda()
        Dim H As New Form1.TablaDeArchivosIndiceControlesAGD()
        Dim F As New Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual()
        Dim C As Integer
        Dim ZZ As Integer ' contador
        Dim FechaComparadaDate As Date
        Dim EscribeDato As Boolean 'para saber si se escribe o no el dato

        Dim FechaProxima As Date
        Dim Temporal, fechade8 As String
        Dim largo As Integer
        Dim Año As String

        Dim contador As Integer = 0

        If PendienteConsulta = True Then
            'existe una consulta pendiente se deben procesar los proximos

            'ojo solo los debe borrar si se esta eliminando la ultima consulta 
            If Form1.EsLaUltimaConsultaLaSeleccionada = True Then
                'se deben modificar los archivos 
                'verifica que exista sino no hace nada (que coño va a modificar sino
                If File.Exists(ArchivoIndiceProximos) Then
                    'primero el del indice, lo lee
                    FS = New FileStream(ArchivoIndiceProximos, FileMode.Open, FileAccess.Read)
                    BR = New BinaryReader(FS)
                    BR.BaseStream.Seek(0, SeekOrigin.Begin)
                    Array05.Clear()
                    C = BR.PeekChar
                    contador = 0
                    While FS.Position < FS.Length
                        K = Nothing
                        ' Read fields and populate structure
                        K.a01FechaProximocontrol = BR.ReadString
                        K.a02NumeroHistoria = BR.ReadString
                        K.a03Nombre = BR.ReadString
                        'si el que se lee no es el que se busca lo copia si no lo salta

                        Dim NumeroPaComparar As String = ""
                        If Form1.NumPrefijo <> "" Then
                            NumeroPaComparar = K.a02NumeroHistoria.Replace(Form1.NumPrefijo, "")
                            NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                        Else
                            NumeroPaComparar = K.a02NumeroHistoria.Substring(0, 6)
                        End If

                        If NumeroPaComparar <> NumeroHistoria Then
                            Array05.Add(K) 'no era el que buscaba lo añado
                            contador += 1
                        Else
                            'este es el que busco no lo añado a la estructura
                        End If
                        C = BR.PeekChar
                    End While
                    BR.Close()
                    FS.Close()

                    'ahora que tengo la array recortada veo si aun hay algun dato si es asi lo
                    'escribo en el archivo, si contador es 0 entonces borro el archivo ya q
                    'estaria vacio
                    If contador > 0 Then
                        'hay algun dato paso el array modificado de vuelta al archivo
                        REnum = Array05.GetEnumerator
                        FS = New FileStream(ArchivoIndiceProximos, FileMode.Create, FileAccess.Write)
                        BW = New BinaryWriter(FS)
                        BW.BaseStream.Seek(0, SeekOrigin.Begin)
                        While REnum.MoveNext
                            K = CType(REnum.Current, Form1.TablaDeArchivosDeIndiceDeProximosControles)
                            BW.Write(K.a01FechaProximocontrol)
                            BW.Write(K.a02NumeroHistoria)
                            BW.Write(K.a03Nombre)
                        End While
                        FS.Close()
                        BW.Close()
                    Else
                        'el archivo se quedara vacio no lo borro pero lo inicializo en blanco
                        FS = New FileStream(ArchivoIndiceProximos, FileMode.Create, FileAccess.ReadWrite)
                        FS.Close()
                    End If
                End If


                'ahora el del archivo proximo cita diario

                'primero crea los nombre de los archivos proximos q faltan (ArchivoProximaCita)
                FechaProxima = FechaPendienteProximaConsulta ' esta fecha la saque de CargaIndiceDeControles q se lo copia de form1
                Temporal = FechaProxima.ToString("s")
                largo = Temporal.Length
                fechade8 = Temporal.Remove(largo - 9, 9)
                fechade8 = fechade8.Remove(4, 1)
                fechade8 = fechade8.Remove(6, 1)
                Año = FechaProxima.Year
                ArchivoProximaCita = Form1.PSstrPathAgendaBDH & "\" & Año & "\Proximo-" & fechade8 & ".agd"

                'lee el achivo
                If File.Exists(ArchivoProximaCita) = True Then
                    FS = New FileStream(ArchivoProximaCita, FileMode.Open, FileAccess.Read)
                    BR = New BinaryReader(FS)
                    BR.BaseStream.Seek(0, SeekOrigin.Begin)
                    'ya se definio antes Dim C As Integer
                    C = BR.PeekChar
                    Array04.Clear()
                    contador = 0
                    While FS.Position < FS.Length
                        J = Nothing
                        ' Read fields and populate structure
                        J.a01NumeroHistoria = BR.ReadString
                        J.a02Nombre = BR.ReadString
                        J.a03Cedula = BR.ReadString
                        J.a04ClinicaUltimoControl = BR.ReadString
                        J.a05NotaseIDxUltimoControl = BR.ReadString
                        J.a06TratamientoUltimoControl = BR.ReadString
                        J.a07Pendiente = BR.ReadString
                        J.a08FechaUltimoControl = BR.ReadString
                        J.a09HonorariosUltimoControl = BR.ReadString
                        J.a10FechaProximoControl = BR.ReadString

                        'si el que se lee no es el que se busca lo copia si no lo salta
                        Dim NumeroPaComparar As String = ""
                        If Form1.NumPrefijo <> "" Then
                            NumeroPaComparar = J.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")
                            NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                        Else
                            NumeroPaComparar = J.a01NumeroHistoria.Substring(0, 6)
                        End If

                        If NumeroPaComparar <> NumeroHistoria Then
                            Array04.Add(J) 'no era el que buscaba lo añado
                            contador += 1
                        Else
                            'este es el que busco no lo añado a la estructura
                        End If
                        C = BR.PeekChar
                    End While
                    BR.Close()
                    FS.Close()

                    'ahora que tengo la array recortada veo si aun hay algun dato si es asi lo
                    'escribo en el archivo, si contador es 0 entonces borro el archivo ya q
                    'estaria vacio
                    If contador > 0 Then
                        'hay algun dato paso el array modificado de vuelta al archivo
                        REnum = Array04.GetEnumerator
                        FS = New FileStream(ArchivoProximaCita, FileMode.Create, FileAccess.Write)
                        BW = New BinaryWriter(FS)
                        BW.BaseStream.Seek(0, SeekOrigin.Begin)
                        While REnum.MoveNext
                            J = CType(REnum.Current, Form1.TablaDeArchivosDeProximosControles)
                            BW.Write(J.a01NumeroHistoria)
                            BW.Write(J.a02Nombre)
                            BW.Write(J.a03Cedula)
                            BW.Write(J.a04ClinicaUltimoControl)
                            BW.Write(J.a05NotaseIDxUltimoControl)
                            BW.Write(J.a06TratamientoUltimoControl)
                            BW.Write(J.a07Pendiente)
                            BW.Write(J.a08FechaUltimoControl)
                            BW.Write(J.a09HonorariosUltimoControl)
                            BW.Write(J.a10FechaProximoControl)
                        End While
                        FS.Close()
                        BW.Close()
                    Else
                        'el archivo se quedara vacio mejor lo borro
                        File.Delete(ArchivoProximaCita)
                    End If
                End If
            End If
        End If


        'ahora a modificar los archivos quitando el dato que se va a modificar

        'primero el del archivo indice, lo lee
        FS = New FileStream(ArchivoIndice, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Array02.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H.a01Fecha = BR.ReadString
            H.a02NumeroHistoria = BR.ReadString
            H.a03Nombre = BR.ReadString
            FechaComparadaDate = CType(H.a01Fecha, Date)
            If FechaConsulta = FechaComparadaDate Then 'si es la fecha entonces
                Dim NumeroPaComparar As String = ""
                If Form1.NumPrefijo <> "" Then
                    NumeroPaComparar = H.a02NumeroHistoria.Replace(Form1.NumPrefijo, "")
                    NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                Else
                    NumeroPaComparar = H.a02NumeroHistoria.Substring(0, 6)
                End If

                If NumeroHistoria <> NumeroPaComparar Then 'revisa el #de historia y si es entonces
                    'es distinto lo escribo
                    Array02.Add(H)
                End If
            Else
                'es distinto lo escribo
                Array02.Add(H)
            End If
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
        'ahora los datos estan en el array recortado, escribe la array al disco
        REnum = Array02.GetEnumerator
        FS = New FileStream(ArchivoIndice, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        While REnum.MoveNext
            EscribeDato = True 'en un principio empieza escribiendo
            H = CType(REnum.Current, Form1.TablaDeArchivosIndiceControlesAGD)
            'escribe el dato
            BW.Write(H.a01Fecha)
            BW.Write(H.a02NumeroHistoria)
            BW.Write(H.a03Nombre)
        End While
        FS.Close()
        BW.Close()
        'aunque quede vacio el indice de controles, no se borra

        'vamos ahora con los archivos propios
        FS = New FileStream(ArchivoPropioAGD, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Array01.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            R = Nothing
            ' Read fields and populate structure
            R.a10FechaConsulta = BR.ReadString
            R.a02Clinica = BR.ReadString
            R.a03NotaseIDx = BR.ReadString
            R.a04Tratamiento = BR.ReadString
            R.a05Pendiente = BR.ReadString
            R.a06ProximaConsulta = BR.ReadString
            R.a07Honorarios = BR.ReadString
            R.a11FacturaAsociada = BR.ReadString
            R.a16Referencia = BR.ReadString
            R.a15Banco = BR.ReadString
            R.a14FormaDePago = BR.ReadString
            R.a13FechaDePago = BR.ReadString
            R.a12Pagador = BR.ReadString

            FechaComparadaDate = CType(R.a10FechaConsulta, Date)
            If FechaConsulta <> FechaComparadaDate Then
                'es distinta la escribo
                Array01.Add(R)
            End If
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
        'ahora los datos estan en el array recortado, lo escribe al disco
        REnum = Array01.GetEnumerator
        FS = New FileStream(ArchivoPropioAGD, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        ZZ = 0
        While REnum.MoveNext
            R = CType(REnum.Current, Form1.TablaDeArchivosPropiosDeAgenda)
            'escribe el dato
            BW.Write(R.a10FechaConsulta)
            BW.Write(R.a02Clinica)
            BW.Write(R.a03NotaseIDx)
            BW.Write(R.a04Tratamiento)
            BW.Write(R.a05Pendiente)
            BW.Write(R.a06ProximaConsulta)
            BW.Write(R.a07Honorarios)
            BW.Write(R.a11FacturaAsociada)
            BW.Write(R.a16Referencia)
            BW.Write(R.a15Banco)
            BW.Write(R.a14FormaDePago)
            BW.Write(R.a13FechaDePago)
            BW.Write(R.a12Pagador)
            ZZ += 1
        End While
        FS.Close()
        BW.Close()
        'si no se escribio ninguno, borra el archivo ya q esta vacio
        If ZZ = 0 Then
            File.Delete(ArchivoPropioAGD)
        Else
            'no borra el archivo porq tiene datos aun....
        End If

        '000000000000000000000000000000000000000000
        'vamos ahora con los archivos control diario
        FS = New FileStream(ArchivoControlDiario, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Array03.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            F = Nothing
            ' Read fields and populate structure
            F.a01NumeroHistoria = BR.ReadString
            F.a02Nombre = BR.ReadString
            F.a03Cedula = BR.ReadString
            F.a04Clinica = BR.ReadString
            F.a05NotaseIDx = BR.ReadString
            F.a06Tratamiento = BR.ReadString
            F.a07Pendiente = BR.ReadString
            F.a08ProximaConsulta = BR.ReadString
            F.a09Honorarios = BR.ReadString
            F.a10FechaConsulta = BR.ReadString
            F.a11FacturaAsociada = BR.ReadString
            F.a16Referencia = BR.ReadString
            F.a15Banco = BR.ReadString
            F.a14FormaDePago = BR.ReadString
            F.a13FechaDePago = BR.ReadString
            F.a12Pagador = BR.ReadString

            FechaComparadaDate = CType(F.a10FechaConsulta, Date)
            If FechaConsulta = FechaComparadaDate Then 'si es la fecha entonces
                Dim NumeroPaComparar As String = ""
                If Form1.NumPrefijo <> "" Then
                    NumeroPaComparar = F.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")
                    NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                Else
                    NumeroPaComparar = F.a01NumeroHistoria.Substring(0, 6)
                End If

                If NumeroHistoria <> NumeroPaComparar Then 'si es distinta la añade
                    Array03.Add(F)
                End If
            Else
                Array03.Add(F)
            End If
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'ahora los datos estan en el array recortado, lo escribe al disco
        REnum = Array03.GetEnumerator
        FS = New FileStream(ArchivoControlDiario, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        ZZ = 0
        While REnum.MoveNext
            F = CType(REnum.Current, Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual)
            'escribe el dato
            BW.Write(F.a01NumeroHistoria)
            BW.Write(F.a02Nombre)
            BW.Write(F.a03Cedula)
            BW.Write(F.a04Clinica)
            BW.Write(F.a05NotaseIDx)
            BW.Write(F.a06Tratamiento)
            BW.Write(F.a07Pendiente)
            BW.Write(F.a08ProximaConsulta)
            BW.Write(F.a09Honorarios)
            BW.Write(F.a10FechaConsulta)
            BW.Write(F.a11FacturaAsociada)
            BW.Write(F.a16Referencia)
            BW.Write(F.a15Banco)
            BW.Write(F.a14FormaDePago)
            BW.Write(F.a13FechaDePago)
            BW.Write(F.a12Pagador)
            ZZ += 1
        End While
        FS.Close()
        BW.Close()
        'si no se escribio ninguno, borra el archivo ya q esta vacio
        If ZZ = 0 Then
            File.Delete(ArchivoControlDiario)
        Else
            'no borra el archivo porq tiene datos aun....
        End If

        '0000000000000000000000000000000000000000
        'vamos ahora con los archivos control mensual
        FS = New FileStream(ArchivoControlMensual, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Array03.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            F = Nothing
            ' Read fields and populate structure
            F.a01NumeroHistoria = BR.ReadString
            F.a02Nombre = BR.ReadString
            F.a03Cedula = BR.ReadString
            F.a04Clinica = BR.ReadString
            F.a05NotaseIDx = BR.ReadString
            F.a06Tratamiento = BR.ReadString
            F.a07Pendiente = BR.ReadString
            F.a08ProximaConsulta = BR.ReadString
            F.a09Honorarios = BR.ReadString
            F.a10FechaConsulta = BR.ReadString
            F.a11FacturaAsociada = BR.ReadString
            F.a16Referencia = BR.ReadString
            F.a15Banco = BR.ReadString
            F.a14FormaDePago = BR.ReadString
            F.a13FechaDePago = BR.ReadString
            F.a12Pagador = BR.ReadString

            FechaComparadaDate = CType(F.a10FechaConsulta, Date)
            If FechaConsulta = FechaComparadaDate Then 'si es la fecha entonces
                Dim NumeroPaComparar As String = ""
                If Form1.NumPrefijo <> "" Then
                    NumeroPaComparar = F.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")
                    NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                Else
                    NumeroPaComparar = F.a01NumeroHistoria.Substring(0, 6)
                End If

                If NumeroHistoria <> NumeroPaComparar Then
                    Array03.Add(F)
                End If
            Else
                Array03.Add(F)
            End If
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'ahora los datos estan en el array recortado, lo escribe al disco
        REnum = Array03.GetEnumerator
        FS = New FileStream(ArchivoControlMensual, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        ZZ = 0
        While REnum.MoveNext
            F = CType(REnum.Current, Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual)
            'escribe el dato
            BW.Write(F.a01NumeroHistoria)
            BW.Write(F.a02Nombre)
            BW.Write(F.a03Cedula)
            BW.Write(F.a04Clinica)
            BW.Write(F.a05NotaseIDx)
            BW.Write(F.a06Tratamiento)
            BW.Write(F.a07Pendiente)
            BW.Write(F.a08ProximaConsulta)
            BW.Write(F.a09Honorarios)
            BW.Write(F.a10FechaConsulta)
            BW.Write(F.a11FacturaAsociada)
            BW.Write(F.a16Referencia)
            BW.Write(F.a15Banco)
            BW.Write(F.a14FormaDePago)
            BW.Write(F.a13FechaDePago)
            BW.Write(F.a12Pagador)
            ZZ += 1
        End While
        FS.Close()
        BW.Close()
        'si no se escribio ninguno, borra el archivo ya q esta vacio
        If ZZ = 0 Then
            File.Delete(ArchivoControlMensual)
        Else
            'no borra el archivo porq tiene datos aun....
        End If

        '00000000000000000000000000000000000000
        'vamos ahora con los archivos control anual
        FS = New FileStream(ArchivoControlAnual, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Array03.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            F = Nothing
            ' Read fields and populate structure
            F.a01NumeroHistoria = BR.ReadString
            F.a02Nombre = BR.ReadString
            F.a03Cedula = BR.ReadString
            F.a04Clinica = BR.ReadString
            F.a05NotaseIDx = BR.ReadString
            F.a06Tratamiento = BR.ReadString
            F.a07Pendiente = BR.ReadString
            F.a08ProximaConsulta = BR.ReadString
            F.a09Honorarios = BR.ReadString
            F.a10FechaConsulta = BR.ReadString
            F.a11FacturaAsociada = BR.ReadString
            F.a16Referencia = BR.ReadString
            F.a15Banco = BR.ReadString
            F.a14FormaDePago = BR.ReadString
            F.a13FechaDePago = BR.ReadString
            F.a12Pagador = BR.ReadString

            FechaComparadaDate = CType(F.a10FechaConsulta, Date)
            If FechaConsulta = FechaComparadaDate Then 'si es la fecha entonces
                Dim NumeroPaComparar As String = ""
                If Form1.NumPrefijo <> "" Then
                    NumeroPaComparar = F.a01NumeroHistoria.Replace(Form1.NumPrefijo, "")
                    NumeroPaComparar = NumeroPaComparar.Substring(0, 6)
                Else
                    NumeroPaComparar = F.a01NumeroHistoria.Substring(0, 6)
                End If
                If NumeroHistoria <> NumeroPaComparar Then
                    Array03.Add(F)
                End If
            Else
                Array03.Add(F)
            End If
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'ahora los datos estan en el array recortado, lo escribe al disco
        REnum = Array03.GetEnumerator
        FS = New FileStream(ArchivoControlAnual, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        ZZ = 0
        While REnum.MoveNext
            F = CType(REnum.Current, Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual)
            'escribe el dato
            BW.Write(F.a01NumeroHistoria)
            BW.Write(F.a02Nombre)
            BW.Write(F.a03Cedula)
            BW.Write(F.a04Clinica)
            BW.Write(F.a05NotaseIDx)
            BW.Write(F.a06Tratamiento)
            BW.Write(F.a07Pendiente)
            BW.Write(F.a08ProximaConsulta)
            BW.Write(F.a09Honorarios)
            BW.Write(F.a10FechaConsulta)
            BW.Write(F.a11FacturaAsociada)
            BW.Write(F.a16Referencia)
            BW.Write(F.a15Banco)
            BW.Write(F.a14FormaDePago)
            BW.Write(F.a13FechaDePago)
            BW.Write(F.a12Pagador)
            ZZ += 1
        End While
        FS.Close()
        BW.Close()
        'si no se escribio ninguno, borra el archivo ya q esta vacio
        If ZZ = 0 Then
            File.Delete(ArchivoControlAnual)
        Else
            'no borra el archivo porq tiene datos aun....
        End If

    End Sub

    'control de eventos del usuario
#Region " Eventos de Interacción del Usuario"

    Private Sub radFechaDeCancelacion_CheckedChanged(sender As Object, e As EventArgs) Handles radCanceladoElMismoDia.CheckedChanged, radCancaladoOtroDia.CheckedChanged, radPagoPendiente.CheckedChanged

        If radCanceladoElMismoDia.Checked = True Then
            'fue cancelado el mismo dia de la consulta acomoda todo
            FechaDePago = FechaConsulta.Date
            labFechaDePago.Text = FechaDePago.ToShortDateString
            'apaga el panel de seleccionar fecha
            panelEligeFechaDePago2.Visible = False

        ElseIf radPagoPendiente.Checked = True Then
            'el pago esta pendiente
            labFechaDePago.Text = "Pendiente"
            FechaDePago = Nothing
            'apaga el panel de seleccionar fecha
            panelEligeFechaDePago2.Visible = False

        Else
            'el pago se hizo otro dia revisa q no este en nothing si se selecciono pendiente anteriormente, si no esta a nothing la deja igual ya solo se debe cambiar con el boton acepta fecha de pago nueva
            If FechaDePago = Nothing Then
                'esta en nothing para evitar el error la inicialia a la misma fecha de la consulta por el momento
                FechaDePago = FechaConsulta.Date
            End If

            'labFechaDePago.Text = FechaDePago.ToShortDateString
            'prende el panel
            panelEligeFechaDePago2.Visible = True

            'acomoda el panel este cambio inicial no hara q se valide porq no hubo mouse click
            txtDia.Text = FechaDePago.Day
            txtMes.Text = FechaDePago.Month
            txtAño.Text = FechaDePago.Year

            'valida para que ponga todo ok
            ValidaFechaDepago()

            'le da el foco al dia
            txtDia.Focus()

        End If

    End Sub

    Private Sub txtDiaMesAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDia.KeyPress, txtMes.KeyPress, txtAño.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else

            'pasa el caracter y evalua


        End If


    End Sub
    Private Sub txtDiaMesAño_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDia.KeyUp, txtMes.KeyUp, txtAño.KeyUp

        ValidaFechaDepago()

    End Sub
    Private Sub ValidaFechaDepago()
        Dim strFechaConstuida As String = txtDia.Text.PadLeft(2, "0"c) & "/" & txtMes.Text.PadLeft(2, "0"c) & "/" & txtAño.Text.ToString.PadLeft(4, "0"c)

        'ok valida la fecha constuida
        If IsDate(strFechaConstuida) Then
            'ok es fecha valida
            labValidacionDeFecha.Text = "Fecha Válida"
            labValidacionDeFecha.BackColor = Color.LightGreen
            FechaDePago = CType(strFechaConstuida, Date).Date
        Else
            'la fecha no valida
            labValidacionDeFecha.Text = "Fecha Inválida"
            labValidacionDeFecha.BackColor = Color.DeepPink
            'como es invalida la pone a la fecha de consulta 
            FechaDePago = FechaConsulta.Date
        End If

        'muestra la fecha constuida o la de consulta
        labFechaDePago.Text = FechaDePago.ToShortDateString
    End Sub


    Private Sub CheckBoxProxima_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxProxima.CheckedChanged
        If CheckBoxProxima.Checked = True Then
            Calendario1.Visible = True
            ListBoxProximas.Visible = True
            labProximaConsulta.Visible = True
            labListbox.Visible = True

            Calendario1.SelectionStart = Today.AddDays(28)
            labProximaConsulta.Text = Calendario1.SelectionStart.ToLongDateString
            BuscaCitasProximas()
        Else
            Calendario1.Visible = False
            ListBoxProximas.Visible = False
            labProximaConsulta.Visible = False
            labListbox.Visible = False

            labProximaConsulta.Text = ""
            ListBoxProximas.Items.Clear()
            'pone la etiqueta adecuada a la fecha
            labListbox.Text = ""
        End If
    End Sub

    Private Sub Calendario1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario1.DateSelected
        If Calendario1.SelectionStart <= Form1.PSdateFechaDeArraqueDeAgenda Then
            MsgBox("La fecha del proximo control debe situarse despuès del dìa de la consulta", MsgBoxStyle.Information, "Corrige Fecha")
            CheckBoxProxima.Checked = False
        Else
            labProximaConsulta.Text = Calendario1.SelectionStart.ToLongDateString
            'chequea citas para el dia seleccionado (por programar)
            BuscaCitasProximas()
        End If

    End Sub

    Private Sub BuscaCitasProximas()
        Dim J As New Form1.TablaDeArchivosDeProximosControles()
        Dim FS As FileStream
        Dim BR As BinaryReader
        Dim FechaProxima As Date
        Dim Temporal, fechade8 As String
        Dim largo As Integer
        Dim TextoAñadido As String
        Dim ArchivoExplorado As String
        Dim Año As String

        '==========================
        'variables nuevas importadas
        'Dim NombreDeArchivoDeGuardias As String

        Dim GU As New Form1.EstructuraGuardias

        Dim T As Integer = 0
        Dim C As Integer

        Dim SeEncontroCoincidencia As Boolean = False

        Dim IndiceSeleccionado As Integer = 0 'guarda el indice del array que fue seleccionado

        Dim FechaSeleccionada As Date
        Dim FechaVerificada As Date
        Dim strFechaSeleccionada As String
        Dim strFechaVerificada As String

        Dim Texto As String


        '========================
        'borra el list box sea lo que sea
        ListBoxProximas.Items.Clear()

        If File.Exists(ArchivoDeGuardias) Then
            'el archivo existe lo carga pero primero hace lo de la fecha seleccionada para comparar
            FechaSeleccionada = Calendario1.SelectionRange.Start
            strFechaSeleccionada = FechaSeleccionada.ToString("d")
            'ahora si carga el archivo y lo revisa de una vez
            FS = New FileStream(ArchivoDeGuardias, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar

            Dim booHayCoincidencia As Boolean = False

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

                FechaVerificada = CType(GU.a01Fecha, Date)
                strFechaVerificada = FechaVerificada.ToString("d")

                If strFechaSeleccionada = strFechaVerificada Then
                    'prende la bandera
                    booHayCoincidencia = True

                    'se encontro una coincidencia se debe escribir al list box
                    Texto = "    COINCIDENCIAS CON EVENTOS"
                    ListBoxProximas.Items.Add(Texto)
                    'Texto = "    ------------- --- -------"
                    'ListBoxProximas.Items.Add(Texto)

                    If GU.a02Lugar1 <> "" Then
                        Texto = "- " & GU.a03Descripcion1 & " en " & GU.a02Lugar1
                        ListBoxProximas.Items.Add(Texto)
                    End If
                    If GU.a04Lugar2 <> "" Then
                        Texto = "- " & GU.a05Descripcion2 & " en " & GU.a04Lugar2
                        ListBoxProximas.Items.Add(Texto)
                    End If
                    If GU.a06Lugar3 <> "" Then
                        Texto = "- " & GU.a07Descripcion3 & " en " & GU.a06Lugar3
                        ListBoxProximas.Items.Add(Texto)
                    End If
                    Texto = " "
                    ListBoxProximas.Items.Add(Texto)

                End If

                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()

            'ya pasaron todos si no hubo coincidencias titula
            If booHayCoincidencia = False Then
                Texto = "    COINCIDENCIAS CON EVENTOS"
                ListBoxProximas.Items.Add(Texto)
                'Texto = "    ------------- --- -------"
                'ListBoxProximas.Items.Add(Texto)
                Texto = "- (NINGUNA, FECHA LIBRE)"
                ListBoxProximas.Items.Add(Texto)
                Texto = " "
                ListBoxProximas.Items.Add(Texto)
            End If

        Else
            'no hay archivo de guardias DECLARA LIBRE LA FECHA
            Texto = "    COINCIDENCIAS CON EVENTOS"
            ListBoxProximas.Items.Add(Texto)
            'Texto = "    ------------- --- -------"
            'ListBoxProximas.Items.Add(Texto)
            Texto = "- (NINGUNA, FECHA LIBRE)"
            ListBoxProximas.Items.Add(Texto)
            Texto = " "
            ListBoxProximas.Items.Add(Texto)
        End If

        'ahora vamos con la citas
        FechaProxima = Calendario1.SelectionRange.Start

        Temporal = FechaProxima.ToString("s")
        largo = Temporal.Length
        fechade8 = Temporal.Remove(largo - 9, 9)
        fechade8 = fechade8.Remove(4, 1)
        fechade8 = fechade8.Remove(6, 1)

        Año = FechaProxima.Year


        ArchivoExplorado = Form1.PSstrPathAgendaBDH & "\" & Año & "\Proximo-" & fechade8 & ".agd"


        If File.Exists(ArchivoExplorado) = True Then
            'existe un archivo de proximas citas ese dia lo carga
            FS = New FileStream(ArchivoExplorado, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar

            Texto = "    CONSULTAS PROGRAMADAS PARA LA FECHA"
            ListBoxProximas.Items.Add(Texto)
            'Texto = "    --------- ----------- ---- -- -----"""
            'ListBoxProximas.Items.Add(Texto)

            While FS.Position < FS.Length
                J = Nothing
                ' Read fields and populate structure
                J.a01NumeroHistoria = BR.ReadString
                J.a02Nombre = BR.ReadString
                J.a03Cedula = BR.ReadString
                J.a04ClinicaUltimoControl = BR.ReadString
                J.a05NotaseIDxUltimoControl = BR.ReadString
                J.a06TratamientoUltimoControl = BR.ReadString
                J.a07Pendiente = BR.ReadString
                J.a08FechaUltimoControl = BR.ReadString
                J.a09HonorariosUltimoControl = BR.ReadString
                J.a10FechaProximoControl = BR.ReadString

                'ahora va mostrando las proximas citas del dia en el list box
                Dim strFechaSDS = (CType(J.a08FechaUltimoControl, Date)).ToShortDateString
                If J.a04ClinicaUltimoControl <> "" Then
                    TextoAñadido = "- " & J.a02Nombre & " vista en " & J.a04ClinicaUltimoControl & " el " & strFechaSDS
                Else
                    TextoAñadido = "- " & J.a02Nombre & " vista el " & strFechaSDS
                End If
                ListBoxProximas.Items.Add(TextoAñadido)
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
            'pone la etiqueta adecuada a la fecha
            labListbox.Text = "Programación del día " & FechaProxima
        Else
            'no existe archivo de prox citas ese dia 
            Texto = "    CONSULTAS PROGRAMADAS PARA LA FECHA"
            ListBoxProximas.Items.Add(Texto)
            'Texto = "    --------- ----------- ---- -- -----"
            'ListBoxProximas.Items.Add(Texto)
            ListBoxProximas.Items.Add("Ninguna.")
            'pone la etiqueta adecuada a la fecha
            labListbox.Text = "Programación del día " & FechaProxima
        End If

    End Sub

    Private Sub txtIDx_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
     Handles txtIDx.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Or c = "¬" Then
                e.Handled = True
            Else
                'pasa el caracter al texto
            End If

        End If
    End Sub
    Private Sub txtTToKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtTto.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'pasa el caracter al texto
            End If

        End If
    End Sub
    Private Sub txtPendiente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtPendiente.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'pasa el caracter al texto
            End If

        End If
    End Sub
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = ".") Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtLugar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtLugar.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'pasa el caracter al texto
            End If

        End If
    End Sub
    Private Sub txtFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtFactura.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        End If

    End Sub
    Private Sub txtPagador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtPagador.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'pasa el caracter al texto
            End If

        End If
    End Sub
    Private Sub txtReferencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtReferencia.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtMonto_GotFocus(sender As Object, e As EventArgs) Handles txtMonto.GotFocus
        If txtMonto.Text = "" Then
            Exit Sub
        End If
        'si sigue aca entonces quita formato
        txtMonto.Text = FormatNumber(txtMonto.Text, 2,,, TriState.False)
        txtMonto.SelectAll()
    End Sub

    Private Sub txtMonto_LostFocus(sender As Object, e As EventArgs) Handles txtMonto.LostFocus
        If txtMonto.Text = "" Then
            Exit Sub
        End If


        ''si sigue aca entonces aplica formato
        If IsNumeric(txtMonto.Text) Then
            Dim decMontoNumerico = CType(txtMonto.Text, Decimal)
            txtMonto.Text = FormatNumber(decMontoNumerico, 2,,, TriState.True)

        Else
            MsgBox("Corrige los honorarios de la consulta, el formato no es válido, redondea o cambia el signo de decimal...", MsgBoxStyle.Information)
            txtMonto.Clear()
            txtMonto.Focus()
            Exit Sub

        End If


    End Sub

    Private Sub BotOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botOK.Click
        Dim H As New Form1.TablaDeArchivosIndiceControlesAGD()
        Dim R As New Form1.TablaDeArchivosPropiosDeAgenda()
        Dim F As New Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual()
        Dim J As New Form1.TablaDeArchivosDeProximosControles()
        Dim K As New Form1.TablaDeArchivosDeIndiceDeProximosControles()

        Dim FS As FileStream
        Dim BW As BinaryWriter
        Dim BR As BinaryReader

        Dim dateFechaTemporal As Date = Nothing

        Dim C As Integer

        'inicializa las est donde se guardaran los datos
        Tipo01 = Nothing 'para los propios de agenda
        Tipo03 = Nothing 'para los de controles diarios, mensuales y anuales

        '0000000000000000000000000000000000000000
        'chequea que datos han sido introducidos si estan en blaco inicializa adecuadamente


        If txtLugar.Text = "" Then
            Tipo01.a02Clinica = "No incluido."
            Tipo03.a04Clinica = "No incluido."
        Else
            Tipo01.a02Clinica = txtLugar.Text
            Tipo03.a04Clinica = txtLugar.Text
        End If

        If txtIDx.Text = "" Then
            'no se ha introducido la idx????
            Tipo01.a03NotaseIDx = "No fue incluido."
            Tipo03.a05NotaseIDx = "No fue incluido."
        Else
            Tipo01.a03NotaseIDx = txtIDx.Text
            Tipo03.a05NotaseIDx = txtIDx.Text
        End If

        If txtTto.Text = "" Then
            Tipo01.a04Tratamiento = "No fue incluido."
            Tipo03.a06Tratamiento = "No fue incluido."
        Else
            Tipo01.a04Tratamiento = txtTto.Text
            Tipo03.a06Tratamiento = txtTto.Text
        End If

        If txtPendiente.Text = "" Then
            Tipo01.a05Pendiente = "No fue incluido."
            Tipo03.a07Pendiente = "No fue incluido."
        Else
            Tipo01.a05Pendiente = txtPendiente.Text
            Tipo03.a07Pendiente = txtPendiente.Text
        End If

        'la fecha de proxima consulta depende...
        If CheckBoxProxima.Checked = True Then
            'ok se selecciono una cita proxima
            Tipo01.a06ProximaConsulta = Calendario1.SelectionStart.Date.ToString("s")
            Tipo03.a08ProximaConsulta = Calendario1.SelectionStart.Date.ToString("s")
        Else
            'no tiene cita proxima
            Tipo01.a06ProximaConsulta = ""
            Tipo03.a08ProximaConsulta = ""
        End If

        If txtMonto.Text = "" Then
            Tipo01.a07Honorarios = FormatNumber(0, 2,,, TriState.False)
            Tipo03.a09Honorarios = FormatNumber(0, 2,,, TriState.False)
        Else
            If IsNumeric(txtMonto.Text) Then
                Dim decMontoNumerico = CType(txtMonto.Text, Decimal)
                Dim txtMontoNumerico = FormatNumber(decMontoNumerico, 2,,, TriState.False)
                Tipo01.a07Honorarios = txtMontoNumerico
                Tipo03.a09Honorarios = txtMontoNumerico
            Else
                MsgBox("Corrige el monto de la consulta, el formato no es válido, redondea o cambia el signo de decimal...", MsgBoxStyle.Information)
                Exit Sub

            End If


        End If

        'la fecha de consulta
        Tipo01.a10FechaConsulta = CType(FechaConsulta, Date).Date.ToString("s")
        Tipo03.a10FechaConsulta = CType(FechaConsulta, Date).Date.ToString("s")

        'los siguientes si estan en blanco se dejan en blanco
        Tipo01.a11FacturaAsociada = txtFactura.Text
        Tipo01.a12Pagador = txtPagador.Text
        Tipo01.a14FormaDePago = txtFormaDePago.Text
        Tipo01.a15Banco = txtBanco.Text
        Tipo01.a16Referencia = txtReferencia.Text
        Tipo03.a11FacturaAsociada = txtFactura.Text
        Tipo03.a12Pagador = txtPagador.Text
        Tipo03.a14FormaDePago = txtFormaDePago.Text
        Tipo03.a15Banco = txtBanco.Text
        Tipo03.a16Referencia = txtReferencia.Text

        'la fecha de pago esta en su variable, puede ser la misma fecha de la consulta, otra fecha o nothing si esta pendiente de pago
        Tipo01.a13FechaDePago = FechaDePago.ToString("s")
        Tipo03.a13FechaDePago = FechaDePago.ToString("s")

        'estos tres ultimos solo los lleva la est Tipo03 y son la id del paciente en los controles por fecha
        Tipo03.a01NumeroHistoria = NumeroCompleto
        Tipo03.a02Nombre = Nombre
        Tipo03.a03Cedula = Cedula


        '0000000000000000000000000000000000000000
        ' procesa el archivo indice de controles
        'primero lee el archivo de indice de controles que este
        FS = New FileStream(ArchivoIndice, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Array02.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            ' Read fields and populate structure
            H.a01Fecha = BR.ReadString
            H.a02NumeroHistoria = BR.ReadString
            H.a03Nombre = BR.ReadString

            '0000estandariza los datos adecuadamente000000000000000000000000000
            dateFechaTemporal = CType(H.a01Fecha, Date) 'caga como fecha
            H.a01Fecha = dateFechaTemporal.ToString("s") 'la formatea adecuadamente
            '00000000000000000000000000000000

            Array02.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'asigna los nuevos datos a la array list de los indices de controles
        Tipo02 = Nothing
        Tipo02.a01Fecha = FechaConsulta.ToString("s")
        Tipo02.a02NumeroHistoria = NumeroCompleto
        Tipo02.a03Nombre = Nombre
        Array02.Add(Tipo02)
        '0000000000000  ordena y escribe la array 00000000000000

        Dim alsOrdenaIndiceControlesPorFecha = From est As Form1.TablaDeArchivosIndiceControlesAGD In Array02 _
                                  Order By est.a01Fecha, est.a02NumeroHistoria _
                                  Select est

        FS = New FileStream(ArchivoIndice, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeArchivosIndiceControlesAGD In alsOrdenaIndiceControlesPorFecha
            BW.Write(est.a01Fecha)
            BW.Write(est.a02NumeroHistoria)
            BW.Write(est.a03Nombre)
        Next
        FS.Close()
        BW.Close()

        '00000000000000000000000000000000000000000000000
        'ahora procesa el archivo propio .agd
        NumeroControlesEnElPropio = 0 'dice cuantos controles archivados en el agd propio hay
        Array01.Clear()
        If File.Exists(ArchivoPropioAGD) = True Then
            'ya existe un archivo propio lo lee
            FS = New FileStream(ArchivoPropioAGD, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)

            C = BR.PeekChar
            While FS.Position < FS.Length
                R = Nothing
                ' Read fields and populate structure
                R.a10FechaConsulta = BR.ReadString
                R.a02Clinica = BR.ReadString
                R.a03NotaseIDx = BR.ReadString
                R.a04Tratamiento = BR.ReadString
                R.a05Pendiente = BR.ReadString
                R.a06ProximaConsulta = BR.ReadString
                R.a07Honorarios = BR.ReadString
                R.a11FacturaAsociada = BR.ReadString
                R.a16Referencia = BR.ReadString
                R.a15Banco = BR.ReadString
                R.a14FormaDePago = BR.ReadString
                R.a13FechaDePago = BR.ReadString
                R.a12Pagador = BR.ReadString

                'estandariza fechas-----------
                dateFechaTemporal = CType(R.a10FechaConsulta, Date)
                R.a10FechaConsulta = dateFechaTemporal.ToString("s")
                If IsDate(R.a06ProximaConsulta) Then
                    dateFechaTemporal = CType(R.a06ProximaConsulta, Date)
                    R.a06ProximaConsulta = dateFechaTemporal.ToString("s")
                Else
                    R.a06ProximaConsulta = ""
                End If

                Array01.Add(R)
                NumeroControlesEnElPropio += 1
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
        Else
            'no existe un archivo propio, lo crea
            FS = New FileStream(ArchivoPropioAGD, FileMode.Create, FileAccess.ReadWrite)
            FS.Close()
        End If

        'añade datos nuevos en la est Tipo01 (ya acomodadita arriba) al archivo propio de agenda
        'modifica al cambiar los campos de texto de la pantalla
        Array01.Add(Tipo01)
        NumeroControlesEnElPropio += 1

        '0000000000000  ordena y escribe la array 00000000000000

        Dim alsOrdenaAGDpropioPorFecha = From est As Form1.TablaDeArchivosPropiosDeAgenda In Array01 _
                                  Order By est.a10FechaConsulta _
                                  Select est

        FS = New FileStream(ArchivoPropioAGD, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeArchivosPropiosDeAgenda In alsOrdenaAGDpropioPorFecha
            BW.Write(est.a10FechaConsulta)
            BW.Write(est.a02Clinica)
            BW.Write(est.a03NotaseIDx)
            BW.Write(est.a04Tratamiento)
            BW.Write(est.a05Pendiente)
            BW.Write(est.a06ProximaConsulta)
            BW.Write(est.a07Honorarios)
            BW.Write(est.a11FacturaAsociada)
            BW.Write(est.a16Referencia)
            BW.Write(est.a15Banco)
            BW.Write(est.a14FormaDePago)
            BW.Write(est.a13FechaDePago)
            BW.Write(est.a12Pagador)
        Next
        FS.Close()
        BW.Close()

        '000000000000000000000000000000000000000000000000000000000000000
        'ahora procesa los achivos de controles diarios
        Array03.Clear()
        If File.Exists(ArchivoControlDiario) = True Then
            'existen controles en ese dia carga los controles
            FS = New FileStream(ArchivoControlDiario, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'ya fue declarada antes Dim C As Integer

            C = BR.PeekChar
            While FS.Position < FS.Length
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                dateFechaTemporal = CType(F.a10FechaConsulta, Date)
                F.a10FechaConsulta = dateFechaTemporal.ToString("s")
                If IsDate(F.a08ProximaConsulta) Then
                    dateFechaTemporal = CType(F.a08ProximaConsulta, Date)
                    F.a08ProximaConsulta = dateFechaTemporal.ToString("s")
                Else
                    F.a08ProximaConsulta = ""
                End If

                Array03.Add(F)
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
        Else
            'no existen controles este dia , averigua si existe el directorio
            If Directory.Exists(Form1.PathAgendaControlesActual) = False Then
                'no existe el directorio de año, debe ser enero entonces....
                Directory.CreateDirectory(Form1.PathAgendaControlesActual) 'lo crea
            End If
            'ahora que seguro existe el directorio crea el archivo y lurego añade los datos
            FS = New FileStream(ArchivoControlDiario, FileMode.Create, FileAccess.ReadWrite)
            FS.Close()
        End If
        'añade datos nuevos (acomodaditos arriba en la est Tipo03) al archivo de control diario 
        Array03.Add(Tipo03)

        '0000000000000  ordena y escribe la array 00000000000000

        Dim alsOrdenaDiaPorFecha = From est As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual In Array03 _
                                  Order By est.a10FechaConsulta, est.a01NumeroHistoria _
                                  Select est

        FS = New FileStream(ArchivoControlDiario, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual In alsOrdenaDiaPorFecha
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04Clinica)
            BW.Write(est.a05NotaseIDx)
            BW.Write(est.a06Tratamiento)
            BW.Write(est.a07Pendiente)
            BW.Write(est.a08ProximaConsulta)
            BW.Write(est.a09Honorarios)
            BW.Write(est.a10FechaConsulta)
            BW.Write(est.a11FacturaAsociada)
            BW.Write(est.a16Referencia)
            BW.Write(est.a15Banco)
            BW.Write(est.a14FormaDePago)
            BW.Write(est.a13FechaDePago)
            BW.Write(est.a12Pagador)
        Next
        FS.Close()
        BW.Close()

        '00000000000000000000000000000000000000000
        'ahora procesa los achivos de controles mensuales
        Array03.Clear()
        If File.Exists(ArchivoControlMensual) = True Then
            'existen controles en ese mes carga los controles
            FS = New FileStream(ArchivoControlMensual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'ya fue declarada antes Dim C As Integer

            C = BR.PeekChar
            While FS.Position < FS.Length
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                dateFechaTemporal = CType(F.a10FechaConsulta, Date)
                F.a10FechaConsulta = dateFechaTemporal.ToString("s")
                If IsDate(F.a08ProximaConsulta) Then
                    dateFechaTemporal = CType(F.a08ProximaConsulta, Date)
                    F.a08ProximaConsulta = dateFechaTemporal.ToString("s")
                Else
                    F.a08ProximaConsulta = ""
                End If

                Array03.Add(F)
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
        Else
            'no existen controles este dia crea el archivo y lurego añade los datos
            'ojo no pregunta por el directorio porq en todo caso ya fue creado cuando
            'se cre el control diario una lineas arriba
            FS = New FileStream(ArchivoControlMensual, FileMode.Create, FileAccess.ReadWrite)
            FS.Close()
        End If

        'añade datos nuevos al archivo de control mensual estos datos estan en el array tipo 03 
        Array03.Add(Tipo03)

        '0000000000000  ordena y escribe la array 00000000000000

        Dim alsOrdenaMesPorFecha = From est As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual In Array03 _
                                  Order By est.a10FechaConsulta, est.a01NumeroHistoria _
                                  Select est

        FS = New FileStream(ArchivoControlMensual, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual In alsOrdenaMesPorFecha
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04Clinica)
            BW.Write(est.a05NotaseIDx)
            BW.Write(est.a06Tratamiento)
            BW.Write(est.a07Pendiente)
            BW.Write(est.a08ProximaConsulta)
            BW.Write(est.a09Honorarios)
            BW.Write(est.a10FechaConsulta)
            BW.Write(est.a11FacturaAsociada)
            BW.Write(est.a16Referencia)
            BW.Write(est.a15Banco)
            BW.Write(est.a14FormaDePago)
            BW.Write(est.a13FechaDePago)
            BW.Write(est.a12Pagador)
        Next
        FS.Close()
        BW.Close()

        '00000000000000000000000000000000000000000
        'ahora procesa los achivos de controles anuales

        Array03.Clear()
        If File.Exists(ArchivoControlAnual) = True Then
            'existen controles en ese año carga los controles
            FS = New FileStream(ArchivoControlAnual, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            'ya fue declarada antes Dim C As Integer

            C = BR.PeekChar
            While FS.Position < FS.Length
                F = Nothing
                ' Read fields and populate structure
                F.a01NumeroHistoria = BR.ReadString
                F.a02Nombre = BR.ReadString
                F.a03Cedula = BR.ReadString
                F.a04Clinica = BR.ReadString
                F.a05NotaseIDx = BR.ReadString
                F.a06Tratamiento = BR.ReadString
                F.a07Pendiente = BR.ReadString
                F.a08ProximaConsulta = BR.ReadString
                F.a09Honorarios = BR.ReadString
                F.a10FechaConsulta = BR.ReadString
                F.a11FacturaAsociada = BR.ReadString
                F.a16Referencia = BR.ReadString
                F.a15Banco = BR.ReadString
                F.a14FormaDePago = BR.ReadString
                F.a13FechaDePago = BR.ReadString
                F.a12Pagador = BR.ReadString

                dateFechaTemporal = CType(F.a10FechaConsulta, Date)
                F.a10FechaConsulta = dateFechaTemporal.ToString("s")
                If IsDate(F.a08ProximaConsulta) Then
                    dateFechaTemporal = CType(F.a08ProximaConsulta, Date)
                    F.a08ProximaConsulta = dateFechaTemporal.ToString("s")
                Else
                    F.a08ProximaConsulta = ""
                End If

                Array03.Add(F)
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
        Else
            'no existen controles este año crea el archivo y lurego añade los datos
            FS = New FileStream(ArchivoControlAnual, FileMode.Create, FileAccess.ReadWrite)
            FS.Close()
        End If
        'añade datos nuevos al archivo de control anual estos datos estan en el array tipo 03 
        Array03.Add(Tipo03)

        '0000000000000  ordena y escribe la array 00000000000000

        Dim alsOrdenaAnoPorFecha = From est As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual In Array03 _
                                  Order By est.a10FechaConsulta, est.a01NumeroHistoria _
                                  Select est

        FS = New FileStream(ArchivoControlAnual, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual In alsOrdenaAnoPorFecha
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04Clinica)
            BW.Write(est.a05NotaseIDx)
            BW.Write(est.a06Tratamiento)
            BW.Write(est.a07Pendiente)
            BW.Write(est.a08ProximaConsulta)
            BW.Write(est.a09Honorarios)
            BW.Write(est.a10FechaConsulta)
            BW.Write(est.a11FacturaAsociada)
            BW.Write(est.a16Referencia)
            BW.Write(est.a15Banco)
            BW.Write(est.a14FormaDePago)
            BW.Write(est.a13FechaDePago)
            BW.Write(est.a12Pagador)
        Next
        FS.Close()
        BW.Close()

        '00000000000000000000000000000000000000000
        'ahora procesa el achivo de indice de controles proximos
        'asigna los nuevos datos a la array list de los indices de controles proximos

        If Form1.EsLaUltimaConsultaLaSeleccionada = True Then 'si se esta editando o creando la mas reciente consulta...
            If labProximaConsulta.Text <> "" Then
                'hay una fecha de proximo control, primero lee el indice

                FS = New FileStream(ArchivoIndiceProximos, FileMode.Open, FileAccess.Read)
                BR = New BinaryReader(FS)
                BR.BaseStream.Seek(0, SeekOrigin.Begin)
                'ya fue declarada antes Dim C As Integer
                Array05.Clear()
                C = BR.PeekChar
                While FS.Position < FS.Length
                    K = Nothing
                    ' Read fields and populate structure
                    K.a01FechaProximocontrol = BR.ReadString
                    K.a02NumeroHistoria = BR.ReadString
                    K.a03Nombre = BR.ReadString

                    'repara
                    dateFechaTemporal = CType(K.a01FechaProximocontrol, Date)
                    K.a01FechaProximocontrol = dateFechaTemporal.ToString("s")

                    Array05.Add(K)
                    C = BR.PeekChar
                End While

                BR.Close()
                FS.Close()

                'ahora añade el nuevo dato
                dateFechaTemporal = CType(labProximaConsulta.Text, Date)
                Tipo05.a01FechaProximocontrol = dateFechaTemporal.ToString("s")

                Tipo05.a02NumeroHistoria = NumeroCompleto
                Tipo05.a03Nombre = Nombre
                Array05.Add(Tipo05)

                'ordena y escribe el array
                Dim alsOrdenaProxControlesPorFecha = From est As Form1.TablaDeArchivosDeIndiceDeProximosControles In Array05 _
                                                     Order By est.a01FechaProximocontrol Descending _
                                                     Select est

                FS = New FileStream(ArchivoIndiceProximos, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)

                For Each est As Form1.TablaDeArchivosDeIndiceDeProximosControles In alsOrdenaProxControlesPorFecha
                    BW.Write(est.a01FechaProximocontrol)
                    BW.Write(est.a02NumeroHistoria)
                    BW.Write(est.a03Nombre)
                Next

                FS.Close()
                BW.Close()

                '00000000000000000000000000000000000000000
                'ahora procesa el achivo de controles proximos diarios
                Dim FechaProxima As Date
                Dim Temporal, fechade8 As String
                Dim largo As Integer
                Dim Año As String
                Dim DirectoriodeAño As String

                FechaProxima = CType(labProximaConsulta.Text, Date)

                Temporal = FechaProxima.ToString("s")
                largo = Temporal.Length
                fechade8 = Temporal.Remove(largo - 9, 9)
                fechade8 = fechade8.Remove(4, 1)
                fechade8 = fechade8.Remove(6, 1)

                Año = FechaProxima.Year
                DirectoriodeAño = Form1.PSstrPathAgendaBDH & "\" & Año

                ArchivoProximaCita = DirectoriodeAño & "\Proximo-" & fechade8 & ".agd"

                If File.Exists(ArchivoProximaCita) = True Then
                    'existe un archivo de proximas citas ese dia lo carga
                    FS = New FileStream(ArchivoProximaCita, FileMode.Open, FileAccess.Read)
                    BR = New BinaryReader(FS)
                    BR.BaseStream.Seek(0, SeekOrigin.Begin)
                    'ya Dim C se definio un poco arriba por eso falta aca
                    C = BR.PeekChar
                    Array04.Clear()
                    While FS.Position < FS.Length
                        J = Nothing
                        ' Read fields and populate structure
                        J.a01NumeroHistoria = BR.ReadString
                        J.a02Nombre = BR.ReadString
                        J.a03Cedula = BR.ReadString
                        J.a04ClinicaUltimoControl = BR.ReadString
                        J.a05NotaseIDxUltimoControl = BR.ReadString
                        J.a06TratamientoUltimoControl = BR.ReadString
                        J.a07Pendiente = BR.ReadString
                        J.a08FechaUltimoControl = BR.ReadString
                        J.a09HonorariosUltimoControl = BR.ReadString
                        J.a10FechaProximoControl = BR.ReadString

                        'acomoda fechas recien leidas
                        dateFechaTemporal = CType(J.a08FechaUltimoControl, Date)
                        J.a08FechaUltimoControl = dateFechaTemporal.ToString("s")
                        dateFechaTemporal = CType(J.a10FechaProximoControl, Date)
                        J.a10FechaProximoControl = dateFechaTemporal.ToString("s")

                        Array04.Add(J)
                        C = BR.PeekChar
                    End While
                    BR.Close()
                    FS.Close()
                Else
                    'no existe archivo de prox citas ese dia 
                    'verifica si existe el directorio de año dentro de la agenda
                    If Directory.Exists(DirectoriodeAño) = False Then
                        Directory.CreateDirectory(DirectoriodeAño)
                    End If
                    'ahora si q se sabe q existe el directorio crea el archivo
                    FS = New FileStream(ArchivoProximaCita, FileMode.Create, FileAccess.ReadWrite)
                    FS.Close()
                    'inicializa el array en blanco
                    Array04.Clear()
                End If

                'añade datos nuevos al archivo de prox citas diario 
                Tipo04 = Nothing
                Tipo04.a01NumeroHistoria = NumeroCompleto
                Tipo04.a02Nombre = Nombre
                Tipo04.a03Cedula = Cedula
                Tipo04.a04ClinicaUltimoControl = txtLugar.Text
                If txtIDx.Text = "" Then
                    Tipo04.a05NotaseIDxUltimoControl = "No refiere"
                Else
                    Tipo04.a05NotaseIDxUltimoControl = txtIDx.Text
                End If
                Tipo04.a06TratamientoUltimoControl = txtTto.Text
                Tipo04.a07Pendiente = txtPendiente.Text
                Tipo04.a08FechaUltimoControl = FechaConsulta.ToString("s")
                Tipo04.a09HonorariosUltimoControl = txtMonto.Text
                dateFechaTemporal = CType(labProximaConsulta.Text, Date)
                Tipo04.a10FechaProximoControl = dateFechaTemporal.ToString("s")

                Array04.Add(Tipo04)

                '00000000000000000  ordena y graba el array
                Dim alsOrdenaProximasCitasDiariaPorFecha = From est As Form1.TablaDeArchivosDeProximosControles In Array04 _
                                                           Order By est.a08FechaUltimoControl, est.a01NumeroHistoria _
                                                           Select est

                FS = New FileStream(ArchivoProximaCita, FileMode.Create, FileAccess.Write)
                BW = New BinaryWriter(FS)
                BW.BaseStream.Seek(0, SeekOrigin.Begin)
                For Each est As Form1.TablaDeArchivosDeProximosControles In alsOrdenaProximasCitasDiariaPorFecha
                    BW.Write(est.a01NumeroHistoria)
                    BW.Write(est.a02Nombre)
                    BW.Write(est.a03Cedula)
                    BW.Write(est.a04ClinicaUltimoControl)
                    BW.Write(est.a05NotaseIDxUltimoControl)
                    BW.Write(est.a06TratamientoUltimoControl)
                    BW.Write(est.a07Pendiente)
                    BW.Write(est.a08FechaUltimoControl)
                    BW.Write(est.a09HonorariosUltimoControl)
                    BW.Write(est.a10FechaProximoControl)
                Next
                FS.Close()
                BW.Close()

            Else
                'no se va a pedir cita proxima a esta paciente deja todo igual

            End If

        End If


        If ExisteEsteControl = False Then
            'se trata de un control nuevo de este dia para esta historia
            'despues de modificar todo realmente se aceptaron los cambios entonces si se 
            'respaldaron los datos de proximas citas se pagaron se deben borrar los bak
            If ArchivosProximosRespaldados = True Then
                'ahora borra los bak
                File.Delete(ArchivoIndiceProximosBAK)
                File.Delete(ArchivoProximaCitaBAK)
            End If
        Else
            'se trata de una modificacion de un control 
            'se aceptaron los cambios se borran todos los backups
            If ArchivosProximosRespaldados = True Then
                'ahora borra los bak
                File.Delete(ArchivoIndiceProximosBAK)
                File.Delete(ArchivoProximaCitaBAK)
            End If

            If ArchivosControlesRespaldados = True Then
                'ahora borra los bak
                File.Delete(ArchivoIndiceBAK)
                File.Delete(ArchivoPropioAgdBAK)
                File.Delete(ArchivoControlDiarioBAK)
                File.Delete(ArchivoControlMensualBAK)
                File.Delete(ArchivoControlAnualBAK)
            End If
        End If
        'sal de la ventana
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

#End Region

    'eventos de entrada de mouse a botones
    Private Sub botCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancel.MouseEnter
        botCancel.Image = BotonOn
    End Sub
    Private Sub botCancel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancel.MouseLeave
        botCancel.Image = BotonOff
    End Sub
    Private Sub botOk_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botOK.MouseEnter
        botOK.Image = BotonOn
    End Sub
    Private Sub botOk_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botOK.MouseLeave
        botOK.Image = BotonOff
    End Sub


End Class
