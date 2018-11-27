Public Class FormExamenFisicoGinecologico
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents labTAS As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents labTAD As System.Windows.Forms.Label
    Friend WithEvents tbTAS As System.Windows.Forms.TrackBar
    Friend WithEvents tbTAD As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labPeso As System.Windows.Forms.Label
    Friend WithEvents tbKG As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbGR As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbPULSO As System.Windows.Forms.TrackBar
    Friend WithEvents labPULSO As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbRESP As System.Windows.Forms.TrackBar
    Friend WithEvents labRESP As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbTEMP As System.Windows.Forms.TrackBar
    Friend WithEvents labTEMP As System.Windows.Forms.Label
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbMama01a As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents botGuardarNuevosDatos As System.Windows.Forms.Button
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents cbMama03f As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama03e As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama03d As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama03c As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama03b As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama03a As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama02f As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama02e As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama02d As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama02c As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama02b As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama02a As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama01f As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama01e As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama01d As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama01c As System.Windows.Forms.ComboBox
    Friend WithEvents cbMama01b As System.Windows.Forms.ComboBox
    Friend WithEvents chkboxCar07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxCar06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxCar05 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxCar04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxCar03 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxCar02 As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxCar01 As System.Windows.Forms.CheckBox
    Friend WithEvents radMamaSim02 As System.Windows.Forms.RadioButton
    Friend WithEvents radMamaSim01 As System.Windows.Forms.RadioButton
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtMama As System.Windows.Forms.TextBox
    Friend WithEvents cbSoploArea As System.Windows.Forms.ComboBox
    Friend WithEvents cbSoploTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbCorazonIntensidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbCorazonRitmo As System.Windows.Forms.ComboBox
    Friend WithEvents cbAgregadosArea As System.Windows.Forms.ComboBox
    Friend WithEvents cbAgregados As System.Windows.Forms.ComboBox
    Friend WithEvents cbMurmulloArea As System.Windows.Forms.ComboBox
    Friend WithEvents cbMurmullo As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtCardiopulmonar As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtCsGs As System.Windows.Forms.TextBox
    Friend WithEvents cbDiuresis As System.Windows.Forms.ComboBox
    Friend WithEvents cbViaOral As System.Windows.Forms.ComboBox
    Friend WithEvents cbTemperatura As System.Windows.Forms.ComboBox
    Friend WithEvents cbTez As System.Windows.Forms.ComboBox
    Friend WithEvents cbRespiracion As System.Windows.Forms.ComboBox
    Friend WithEvents cbHidratacion As System.Windows.Forms.ComboBox
    Friend WithEvents cbCsGs As System.Windows.Forms.ComboBox
    Friend WithEvents cbAbdTUsensibilidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbAbdTUadherencias As System.Windows.Forms.ComboBox
    Friend WithEvents cbAbdTUtipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbAbdTUconsistencia As System.Windows.Forms.ComboBox
    Friend WithEvents cbAbdRuidos As System.Windows.Forms.ComboBox
    Friend WithEvents cbAbdSensibilidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbAbdViceromegalias As System.Windows.Forms.ComboBox
    Friend WithEvents cbAbdConformacion As System.Windows.Forms.ComboBox
    Friend WithEvents cbAbdConsistencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtAbdomen As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents tp01 As System.Windows.Forms.TabPage
    Friend WithEvents tp03 As System.Windows.Forms.TabPage
    Friend WithEvents tp02 As System.Windows.Forms.TabPage
    Friend WithEvents tp04 As System.Windows.Forms.TabPage
    Friend WithEvents txtGenitalesExt As System.Windows.Forms.TextBox
    Friend WithEvents tp06 As System.Windows.Forms.TabPage
    Friend WithEvents tp07 As System.Windows.Forms.TabPage
    Friend WithEvents tp08 As System.Windows.Forms.TabPage
    Friend WithEvents tp09 As System.Windows.Forms.TabPage
    Friend WithEvents tp10 As System.Windows.Forms.TabPage
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtEspeculo As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtColposcopia As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtTacto As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtMsIs As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtNeurologico As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents ComboBox11 As System.Windows.Forms.ComboBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents ComboBox12 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox13 As System.Windows.Forms.ComboBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents ComboBox14 As System.Windows.Forms.ComboBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents tp05 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox15 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormExamenFisicoGinecologico))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tp01 = New System.Windows.Forms.TabPage()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtCsGs = New System.Windows.Forms.TextBox()
        Me.cbDiuresis = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cbViaOral = New System.Windows.Forms.ComboBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cbTemperatura = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.cbTez = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.cbRespiracion = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cbHidratacion = New System.Windows.Forms.ComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.cbCsGs = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbTEMP = New System.Windows.Forms.TrackBar()
        Me.labTEMP = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbRESP = New System.Windows.Forms.TrackBar()
        Me.labRESP = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbPULSO = New System.Windows.Forms.TrackBar()
        Me.labPULSO = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbGR = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbKG = New System.Windows.Forms.TrackBar()
        Me.labPeso = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbTAD = New System.Windows.Forms.TrackBar()
        Me.labTAD = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTAS = New System.Windows.Forms.TrackBar()
        Me.labTAS = New System.Windows.Forms.Label()
        Me.tp02 = New System.Windows.Forms.TabPage()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtMama = New System.Windows.Forms.TextBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.cbMama03f = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbMama03e = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbMama03d = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbMama03c = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbMama03b = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbMama03a = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.cbMama02f = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbMama02e = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbMama02d = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbMama02c = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbMama02b = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbMama02a = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.cbMama01f = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbMama01e = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbMama01d = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbMama01c = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbMama01b = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbMama01a = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.chkboxCar07 = New System.Windows.Forms.CheckBox()
        Me.chkboxCar06 = New System.Windows.Forms.CheckBox()
        Me.chkboxCar05 = New System.Windows.Forms.CheckBox()
        Me.chkboxCar04 = New System.Windows.Forms.CheckBox()
        Me.chkboxCar03 = New System.Windows.Forms.CheckBox()
        Me.chkboxCar02 = New System.Windows.Forms.CheckBox()
        Me.chkboxCar01 = New System.Windows.Forms.CheckBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.radMamaSim02 = New System.Windows.Forms.RadioButton()
        Me.radMamaSim01 = New System.Windows.Forms.RadioButton()
        Me.tp03 = New System.Windows.Forms.TabPage()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtCardiopulmonar = New System.Windows.Forms.TextBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.cbAgregadosArea = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cbAgregados = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbMurmulloArea = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbMurmullo = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.cbSoploArea = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cbSoploTipo = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cbCorazonIntensidad = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbCorazonRitmo = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tp04 = New System.Windows.Forms.TabPage()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtAbdomen = New System.Windows.Forms.TextBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.cbAbdTUsensibilidad = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cbAbdTUadherencias = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.cbAbdTUtipo = New System.Windows.Forms.ComboBox()
        Me.cbAbdTUconsistencia = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.cbAbdRuidos = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cbAbdSensibilidad = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cbAbdViceromegalias = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cbAbdConformacion = New System.Windows.Forms.ComboBox()
        Me.cbAbdConsistencia = New System.Windows.Forms.ComboBox()
        Me.tp05 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.ComboBox13 = New System.Windows.Forms.ComboBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.ComboBox14 = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtGenitalesExt = New System.Windows.Forms.TextBox()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.tp06 = New System.Windows.Forms.TabPage()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtEspeculo = New System.Windows.Forms.TextBox()
        Me.tp07 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtColposcopia = New System.Windows.Forms.TextBox()
        Me.tp08 = New System.Windows.Forms.TabPage()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtTacto = New System.Windows.Forms.TextBox()
        Me.tp09 = New System.Windows.Forms.TabPage()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtMsIs = New System.Windows.Forms.TextBox()
        Me.tp10 = New System.Windows.Forms.TabPage()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtNeurologico = New System.Windows.Forms.TextBox()
        Me.botGuardarNuevosDatos = New System.Windows.Forms.Button()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox15 = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.tp01.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.tbTEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.tbRESP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tbPULSO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tbGR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbKG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbTAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp02.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.tp03.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.tp04.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.tp05.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.tp06.SuspendLayout()
        Me.tp07.SuspendLayout()
        Me.tp08.SuspendLayout()
        Me.tp09.SuspendLayout()
        Me.tp10.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tp01, Me.tp02, Me.tp03, Me.tp04, Me.tp05, Me.tp06, Me.tp07, Me.tp08, Me.tp09, Me.tp10})
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(632, 360)
        Me.TabControl1.TabIndex = 0
        '
        'tp01
        '
        Me.tp01.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label45, Me.txtCsGs, Me.cbDiuresis, Me.Label54, Me.cbViaOral, Me.Label53, Me.cbTemperatura, Me.Label52, Me.cbTez, Me.Label51, Me.cbRespiracion, Me.Label50, Me.cbHidratacion, Me.Label49, Me.cbCsGs, Me.Label48, Me.GroupBox5, Me.GroupBox4, Me.GroupBox3, Me.GroupBox2, Me.GroupBox1})
        Me.tp01.Location = New System.Drawing.Point(4, 22)
        Me.tp01.Name = "tp01"
        Me.tp01.Size = New System.Drawing.Size(624, 334)
        Me.tp01.TabIndex = 0
        Me.tp01.Text = "SV y CsGs"
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(0, 260)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(200, 16)
        Me.Label45.TabIndex = 22
        Me.Label45.Text = "Subjetivos y comentarios"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCsGs
        '
        Me.txtCsGs.Location = New System.Drawing.Point(0, 276)
        Me.txtCsGs.MaxLength = 1024
        Me.txtCsGs.Multiline = True
        Me.txtCsGs.Name = "txtCsGs"
        Me.txtCsGs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCsGs.Size = New System.Drawing.Size(416, 56)
        Me.txtCsGs.TabIndex = 21
        Me.txtCsGs.Text = ""
        '
        'cbDiuresis
        '
        Me.cbDiuresis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDiuresis.Items.AddRange(New Object() {"Diuresis conservada", "Oligúrica", "Polaquiúrica", "Disúrica"})
        Me.cbDiuresis.Location = New System.Drawing.Point(424, 296)
        Me.cbDiuresis.Name = "cbDiuresis"
        Me.cbDiuresis.Size = New System.Drawing.Size(192, 21)
        Me.cbDiuresis.TabIndex = 20
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(424, 280)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(176, 16)
        Me.Label54.TabIndex = 19
        Me.Label54.Text = "Diuresis"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cbViaOral
        '
        Me.cbViaOral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbViaOral.Items.AddRange(New Object() {"Tolera la vía oral", "Tolera líquidos", "No tolera vía oral", "Hiperemesis"})
        Me.cbViaOral.Location = New System.Drawing.Point(424, 252)
        Me.cbViaOral.Name = "cbViaOral"
        Me.cbViaOral.Size = New System.Drawing.Size(192, 21)
        Me.cbViaOral.TabIndex = 18
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(424, 236)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(176, 16)
        Me.Label53.TabIndex = 17
        Me.Label53.Text = "Tolerancia a la vía oral"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cbTemperatura
        '
        Me.cbTemperatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTemperatura.Items.AddRange(New Object() {"Normotérmica al tacto", "Hipertérmica al tacto", "Hipotérmica al tacto"})
        Me.cbTemperatura.Location = New System.Drawing.Point(424, 208)
        Me.cbTemperatura.Name = "cbTemperatura"
        Me.cbTemperatura.Size = New System.Drawing.Size(192, 21)
        Me.cbTemperatura.TabIndex = 16
        '
        'Label52
        '
        Me.Label52.Location = New System.Drawing.Point(424, 192)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(176, 16)
        Me.Label52.TabIndex = 15
        Me.Label52.Text = "Temperatura al tacto"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cbTez
        '
        Me.cbTez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTez.Items.AddRange(New Object() {"Normal", "Palidéz de piel y mucosas", "Tinte ictérico de piel y mucosas", "Piel eritematosa", "Piel cianótica"})
        Me.cbTez.Location = New System.Drawing.Point(424, 164)
        Me.cbTez.Name = "cbTez"
        Me.cbTez.Size = New System.Drawing.Size(192, 21)
        Me.cbTez.TabIndex = 14
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(424, 148)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(176, 16)
        Me.Label51.TabIndex = 13
        Me.Label51.Text = "Coloración de piel y mucosas"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cbRespiracion
        '
        Me.cbRespiracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRespiracion.Items.AddRange(New Object() {"Eupnéica", "Disnéica"})
        Me.cbRespiracion.Location = New System.Drawing.Point(424, 120)
        Me.cbRespiracion.Name = "cbRespiracion"
        Me.cbRespiracion.Size = New System.Drawing.Size(192, 21)
        Me.cbRespiracion.TabIndex = 12
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(424, 104)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(176, 16)
        Me.Label50.TabIndex = 11
        Me.Label50.Text = "Esfuerzo respiratorio"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cbHidratacion
        '
        Me.cbHidratacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHidratacion.Items.AddRange(New Object() {"Hidratada", "Deshidratada", "Deshidratación leve", "Deshidratación moderada", "Deshidratación severa"})
        Me.cbHidratacion.Location = New System.Drawing.Point(424, 76)
        Me.cbHidratacion.Name = "cbHidratacion"
        Me.cbHidratacion.Size = New System.Drawing.Size(192, 21)
        Me.cbHidratacion.TabIndex = 10
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(424, 60)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(176, 16)
        Me.Label49.TabIndex = 9
        Me.Label49.Text = "Estado de hidratación"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cbCsGs
        '
        Me.cbCsGs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCsGs.Items.AddRange(New Object() {"Buenas condiciones generales", "Estables condiciones generales", "Regulares condiciones generales", "Malas condiciones generales", "Graves condiciones generales"})
        Me.cbCsGs.Location = New System.Drawing.Point(424, 32)
        Me.cbCsGs.Name = "cbCsGs"
        Me.cbCsGs.Size = New System.Drawing.Size(192, 21)
        Me.cbCsGs.TabIndex = 8
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(424, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(176, 16)
        Me.Label48.TabIndex = 7
        Me.Label48.Text = "Condiciones Generales"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label6, Me.tbTEMP, Me.labTEMP})
        Me.GroupBox5.Location = New System.Drawing.Point(240, 7)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(64, 249)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Temp"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ºC"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbTEMP
        '
        Me.tbTEMP.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbTEMP.Location = New System.Drawing.Point(8, 56)
        Me.tbTEMP.Maximum = 420
        Me.tbTEMP.Minimum = 350
        Me.tbTEMP.Name = "tbTEMP"
        Me.tbTEMP.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbTEMP.Size = New System.Drawing.Size(45, 184)
        Me.tbTEMP.SmallChange = 5
        Me.tbTEMP.TabIndex = 0
        Me.tbTEMP.TickFrequency = 5
        Me.tbTEMP.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbTEMP.Value = 370
        '
        'labTEMP
        '
        Me.labTEMP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labTEMP.Location = New System.Drawing.Point(8, 16)
        Me.labTEMP.Name = "labTEMP"
        Me.labTEMP.Size = New System.Drawing.Size(48, 23)
        Me.labTEMP.TabIndex = 1
        Me.labTEMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.tbRESP, Me.labRESP})
        Me.GroupBox4.Location = New System.Drawing.Point(176, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(64, 248)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resp"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbRESP
        '
        Me.tbRESP.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbRESP.Location = New System.Drawing.Point(8, 56)
        Me.tbRESP.Maximum = 40
        Me.tbRESP.Minimum = 10
        Me.tbRESP.Name = "tbRESP"
        Me.tbRESP.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbRESP.Size = New System.Drawing.Size(45, 184)
        Me.tbRESP.SmallChange = 5
        Me.tbRESP.TabIndex = 0
        Me.tbRESP.TickFrequency = 2
        Me.tbRESP.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbRESP.Value = 20
        '
        'labRESP
        '
        Me.labRESP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRESP.Location = New System.Drawing.Point(8, 16)
        Me.labRESP.Name = "labRESP"
        Me.labRESP.Size = New System.Drawing.Size(48, 23)
        Me.labRESP.TabIndex = 1
        Me.labRESP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.tbPULSO, Me.labPULSO})
        Me.GroupBox3.Location = New System.Drawing.Point(112, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(64, 248)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pulso"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FC"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbPULSO
        '
        Me.tbPULSO.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbPULSO.Location = New System.Drawing.Point(8, 56)
        Me.tbPULSO.Maximum = 140
        Me.tbPULSO.Minimum = 40
        Me.tbPULSO.Name = "tbPULSO"
        Me.tbPULSO.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbPULSO.Size = New System.Drawing.Size(45, 184)
        Me.tbPULSO.SmallChange = 5
        Me.tbPULSO.TabIndex = 0
        Me.tbPULSO.TickFrequency = 5
        Me.tbPULSO.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbPULSO.Value = 60
        '
        'labPULSO
        '
        Me.labPULSO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPULSO.Location = New System.Drawing.Point(8, 16)
        Me.labPULSO.Name = "labPULSO"
        Me.labPULSO.Size = New System.Drawing.Size(48, 23)
        Me.labPULSO.TabIndex = 1
        Me.labPULSO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.tbGR, Me.Label5, Me.tbKG, Me.labPeso})
        Me.GroupBox2.Location = New System.Drawing.Point(304, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 248)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Peso"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "gr"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbGR
        '
        Me.tbGR.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbGR.Location = New System.Drawing.Point(56, 56)
        Me.tbGR.Maximum = 99
        Me.tbGR.Name = "tbGR"
        Me.tbGR.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbGR.Size = New System.Drawing.Size(45, 184)
        Me.tbGR.SmallChange = 5
        Me.tbGR.TabIndex = 3
        Me.tbGR.TickFrequency = 10
        Me.tbGR.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Kg"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbKG
        '
        Me.tbKG.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbKG.Location = New System.Drawing.Point(8, 56)
        Me.tbKG.Maximum = 140
        Me.tbKG.Minimum = 40
        Me.tbKG.Name = "tbKG"
        Me.tbKG.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbKG.Size = New System.Drawing.Size(45, 184)
        Me.tbKG.SmallChange = 5
        Me.tbKG.TabIndex = 0
        Me.tbKG.TickFrequency = 10
        Me.tbKG.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbKG.Value = 70
        '
        'labPeso
        '
        Me.labPeso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labPeso.Location = New System.Drawing.Point(8, 16)
        Me.labPeso.Name = "labPeso"
        Me.labPeso.Size = New System.Drawing.Size(88, 23)
        Me.labPeso.TabIndex = 1
        Me.labPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tbTAD, Me.labTAD, Me.Label2, Me.Label1, Me.tbTAS, Me.labTAS})
        Me.GroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 248)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tensión Arterial"
        '
        'tbTAD
        '
        Me.tbTAD.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbTAD.Location = New System.Drawing.Point(56, 56)
        Me.tbTAD.Maximum = 220
        Me.tbTAD.Name = "tbTAD"
        Me.tbTAD.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbTAD.Size = New System.Drawing.Size(45, 184)
        Me.tbTAD.SmallChange = 5
        Me.tbTAD.TabIndex = 5
        Me.tbTAD.TickFrequency = 10
        Me.tbTAD.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbTAD.Value = 70
        '
        'labTAD
        '
        Me.labTAD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labTAD.Location = New System.Drawing.Point(56, 16)
        Me.labTAD.Name = "labTAD"
        Me.labTAD.Size = New System.Drawing.Size(48, 23)
        Me.labTAD.TabIndex = 4
        Me.labTAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TAD"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbTAS
        '
        Me.tbTAS.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbTAS.Location = New System.Drawing.Point(8, 56)
        Me.tbTAS.Maximum = 220
        Me.tbTAS.Name = "tbTAS"
        Me.tbTAS.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbTAS.Size = New System.Drawing.Size(45, 184)
        Me.tbTAS.SmallChange = 5
        Me.tbTAS.TabIndex = 0
        Me.tbTAS.TickFrequency = 10
        Me.tbTAS.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbTAS.Value = 110
        '
        'labTAS
        '
        Me.labTAS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labTAS.Location = New System.Drawing.Point(8, 16)
        Me.labTAS.Name = "labTAS"
        Me.labTAS.Size = New System.Drawing.Size(48, 23)
        Me.labTAS.TabIndex = 1
        Me.labTAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tp02
        '
        Me.tp02.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label46, Me.txtMama, Me.GroupBox17, Me.GroupBox16, Me.GroupBox15, Me.GroupBox14, Me.GroupBox13})
        Me.tp02.Location = New System.Drawing.Point(4, 22)
        Me.tp02.Name = "tp02"
        Me.tp02.Size = New System.Drawing.Size(624, 334)
        Me.tp02.TabIndex = 2
        Me.tp02.Text = "Mamas"
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(4, 248)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(256, 16)
        Me.Label46.TabIndex = 18
        Me.Label46.Text = "Mama (Notas y Comentarios adicionales)"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtMama
        '
        Me.txtMama.Location = New System.Drawing.Point(4, 264)
        Me.txtMama.MaxLength = 1024
        Me.txtMama.Multiline = True
        Me.txtMama.Name = "txtMama"
        Me.txtMama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMama.Size = New System.Drawing.Size(616, 68)
        Me.txtMama.TabIndex = 17
        Me.txtMama.Text = ""
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbMama03f, Me.Label20, Me.cbMama03e, Me.Label21, Me.cbMama03d, Me.Label22, Me.cbMama03c, Me.Label23, Me.cbMama03b, Me.Label24, Me.cbMama03a, Me.Label25})
        Me.GroupBox17.Location = New System.Drawing.Point(460, 4)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(160, 240)
        Me.GroupBox17.TabIndex = 15
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Lesion 03"
        '
        'cbMama03f
        '
        Me.cbMama03f.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama03f.Items.AddRange(New Object() {"dolorosa", "dolorosa al tacto", "dolorosa a la presión", "indolora"})
        Me.cbMama03f.Location = New System.Drawing.Point(8, 208)
        Me.cbMama03f.Name = "cbMama03f"
        Me.cbMama03f.Size = New System.Drawing.Size(148, 21)
        Me.cbMama03f.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 196)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 16)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Sensibilidad"
        '
        'cbMama03e
        '
        Me.cbMama03e.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama03e.Items.AddRange(New Object() {"móvil", "adherida a plano profundo", "adherida a plano superficial", "adherida a ambos planos"})
        Me.cbMama03e.Location = New System.Drawing.Point(8, 172)
        Me.cbMama03e.Name = "cbMama03e"
        Me.cbMama03e.Size = New System.Drawing.Size(148, 21)
        Me.cbMama03e.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 160)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 16)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Adherencias"
        '
        'cbMama03d
        '
        Me.cbMama03d.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama03d.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "más de 5"})
        Me.cbMama03d.Location = New System.Drawing.Point(8, 136)
        Me.cbMama03d.Name = "cbMama03d"
        Me.cbMama03d.Size = New System.Drawing.Size(148, 21)
        Me.cbMama03d.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 124)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 16)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Tamaño (cm)"
        '
        'cbMama03c
        '
        Me.cbMama03c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama03c.Items.AddRange(New Object() {"Nódulo", "Fibroadenoma", "Quiste", "Retracción cutánea"})
        Me.cbMama03c.Location = New System.Drawing.Point(8, 100)
        Me.cbMama03c.Name = "cbMama03c"
        Me.cbMama03c.Size = New System.Drawing.Size(148, 21)
        Me.cbMama03c.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(92, 16)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Tipo de Lesión"
        '
        'cbMama03b
        '
        Me.cbMama03b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama03b.Items.AddRange(New Object() {"cuadrante superoexterno", "cuadrante superointerno", "cuadrante inferoexterno", "cuadrante inferointerno", "(axila)"})
        Me.cbMama03b.Location = New System.Drawing.Point(8, 64)
        Me.cbMama03b.Name = "cbMama03b"
        Me.cbMama03b.Size = New System.Drawing.Size(148, 21)
        Me.cbMama03b.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(8, 52)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Cuadrante"
        '
        'cbMama03a
        '
        Me.cbMama03a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama03a.Items.AddRange(New Object() {"derecha", "izquierda"})
        Me.cbMama03a.Location = New System.Drawing.Point(8, 28)
        Me.cbMama03a.Name = "cbMama03a"
        Me.cbMama03a.Size = New System.Drawing.Size(148, 21)
        Me.cbMama03a.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Mama"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbMama02f, Me.Label14, Me.cbMama02e, Me.Label15, Me.cbMama02d, Me.Label16, Me.cbMama02c, Me.Label17, Me.cbMama02b, Me.Label18, Me.cbMama02a, Me.Label19})
        Me.GroupBox16.Location = New System.Drawing.Point(296, 4)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(164, 240)
        Me.GroupBox16.TabIndex = 14
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Lesion 02"
        '
        'cbMama02f
        '
        Me.cbMama02f.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama02f.Items.AddRange(New Object() {"dolorosa", "dolorosa al tacto", "dolorosa a la presión", "indolora"})
        Me.cbMama02f.Location = New System.Drawing.Point(8, 208)
        Me.cbMama02f.Name = "cbMama02f"
        Me.cbMama02f.Size = New System.Drawing.Size(152, 21)
        Me.cbMama02f.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 16)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Sensibilidad"
        '
        'cbMama02e
        '
        Me.cbMama02e.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama02e.Items.AddRange(New Object() {"móvil", "adherida a plano profundo", "adherida a plano superficial", "adherida a ambos planos"})
        Me.cbMama02e.Location = New System.Drawing.Point(8, 172)
        Me.cbMama02e.Name = "cbMama02e"
        Me.cbMama02e.Size = New System.Drawing.Size(152, 21)
        Me.cbMama02e.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 16)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Adherencias"
        '
        'cbMama02d
        '
        Me.cbMama02d.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama02d.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "más de 5"})
        Me.cbMama02d.Location = New System.Drawing.Point(8, 136)
        Me.cbMama02d.Name = "cbMama02d"
        Me.cbMama02d.Size = New System.Drawing.Size(152, 21)
        Me.cbMama02d.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 16)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Tamaño (cm)"
        '
        'cbMama02c
        '
        Me.cbMama02c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama02c.Items.AddRange(New Object() {"Nódulo", "Fibroadenoma", "Quiste", "Retracción cutánea"})
        Me.cbMama02c.Location = New System.Drawing.Point(8, 100)
        Me.cbMama02c.Name = "cbMama02c"
        Me.cbMama02c.Size = New System.Drawing.Size(152, 21)
        Me.cbMama02c.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 16)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Tipo de Lesión"
        '
        'cbMama02b
        '
        Me.cbMama02b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama02b.Items.AddRange(New Object() {"cuadrante superoexterno", "cuadrante superointerno", "cuadrante inferoexterno", "cuadrante inferointerno", "(axila)"})
        Me.cbMama02b.Location = New System.Drawing.Point(8, 64)
        Me.cbMama02b.Name = "cbMama02b"
        Me.cbMama02b.Size = New System.Drawing.Size(152, 21)
        Me.cbMama02b.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Cuadrante"
        '
        'cbMama02a
        '
        Me.cbMama02a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama02a.Items.AddRange(New Object() {"derecha", "izquierda"})
        Me.cbMama02a.Location = New System.Drawing.Point(8, 28)
        Me.cbMama02a.Name = "cbMama02a"
        Me.cbMama02a.Size = New System.Drawing.Size(152, 21)
        Me.cbMama02a.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Mama"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbMama01f, Me.Label13, Me.cbMama01e, Me.Label12, Me.cbMama01d, Me.Label11, Me.cbMama01c, Me.Label10, Me.cbMama01b, Me.Label9, Me.cbMama01a, Me.Label8})
        Me.GroupBox15.Location = New System.Drawing.Point(136, 4)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(160, 240)
        Me.GroupBox15.TabIndex = 13
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Lesion 01"
        '
        'cbMama01f
        '
        Me.cbMama01f.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama01f.Items.AddRange(New Object() {"dolorosa", "dolorosa al tacto", "dolorosa a la presión", "indolora"})
        Me.cbMama01f.Location = New System.Drawing.Point(8, 208)
        Me.cbMama01f.Name = "cbMama01f"
        Me.cbMama01f.Size = New System.Drawing.Size(148, 21)
        Me.cbMama01f.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 16)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Sensibilidad"
        '
        'cbMama01e
        '
        Me.cbMama01e.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama01e.Items.AddRange(New Object() {"móvil", "adherida a plano profundo", "adherida a plano superficial", "adherida a ambos planos"})
        Me.cbMama01e.Location = New System.Drawing.Point(8, 172)
        Me.cbMama01e.Name = "cbMama01e"
        Me.cbMama01e.Size = New System.Drawing.Size(148, 21)
        Me.cbMama01e.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Adherencias"
        '
        'cbMama01d
        '
        Me.cbMama01d.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama01d.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "más de 5"})
        Me.cbMama01d.Location = New System.Drawing.Point(8, 136)
        Me.cbMama01d.Name = "cbMama01d"
        Me.cbMama01d.Size = New System.Drawing.Size(148, 21)
        Me.cbMama01d.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Tamaño (cm)"
        '
        'cbMama01c
        '
        Me.cbMama01c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama01c.Items.AddRange(New Object() {"Nódulo", "Fibroadenoma", "Quiste", "Retracción cutánea"})
        Me.cbMama01c.Location = New System.Drawing.Point(8, 100)
        Me.cbMama01c.Name = "cbMama01c"
        Me.cbMama01c.Size = New System.Drawing.Size(148, 21)
        Me.cbMama01c.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Tipo de Lesión"
        '
        'cbMama01b
        '
        Me.cbMama01b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama01b.Items.AddRange(New Object() {"cuadrante superoexterno", "cuadrante superointerno", "cuadrante inferoexterno", "cuadrante inferointerno", "(axila)"})
        Me.cbMama01b.Location = New System.Drawing.Point(8, 64)
        Me.cbMama01b.Name = "cbMama01b"
        Me.cbMama01b.Size = New System.Drawing.Size(148, 21)
        Me.cbMama01b.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cuadrante"
        '
        'cbMama01a
        '
        Me.cbMama01a.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMama01a.Items.AddRange(New Object() {"derecha", "izquierda"})
        Me.cbMama01a.Location = New System.Drawing.Point(8, 28)
        Me.cbMama01a.Name = "cbMama01a"
        Me.cbMama01a.Size = New System.Drawing.Size(148, 21)
        Me.cbMama01a.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Mama"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkboxCar07, Me.chkboxCar06, Me.chkboxCar05, Me.chkboxCar04, Me.chkboxCar03, Me.chkboxCar02, Me.chkboxCar01})
        Me.GroupBox14.Location = New System.Drawing.Point(4, 68)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(130, 176)
        Me.GroupBox14.TabIndex = 12
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Características"
        '
        'chkboxCar07
        '
        Me.chkboxCar07.Location = New System.Drawing.Point(4, 132)
        Me.chkboxCar07.Name = "chkboxCar07"
        Me.chkboxCar07.Size = New System.Drawing.Size(124, 24)
        Me.chkboxCar07.TabIndex = 19
        Me.chkboxCar07.Text = "Cond. Fibroquística"
        '
        'chkboxCar06
        '
        Me.chkboxCar06.Location = New System.Drawing.Point(4, 112)
        Me.chkboxCar06.Name = "chkboxCar06"
        Me.chkboxCar06.TabIndex = 18
        Me.chkboxCar06.Text = "Mastodinia"
        '
        'chkboxCar05
        '
        Me.chkboxCar05.Location = New System.Drawing.Point(4, 92)
        Me.chkboxCar05.Name = "chkboxCar05"
        Me.chkboxCar05.TabIndex = 17
        Me.chkboxCar05.Text = "Mastalgia"
        '
        'chkboxCar04
        '
        Me.chkboxCar04.Location = New System.Drawing.Point(4, 72)
        Me.chkboxCar04.Name = "chkboxCar04"
        Me.chkboxCar04.TabIndex = 16
        Me.chkboxCar04.Text = "Lactantes"
        '
        'chkboxCar03
        '
        Me.chkboxCar03.Location = New System.Drawing.Point(4, 52)
        Me.chkboxCar03.Name = "chkboxCar03"
        Me.chkboxCar03.TabIndex = 15
        Me.chkboxCar03.Text = "Hipotróficas"
        '
        'chkboxCar02
        '
        Me.chkboxCar02.Location = New System.Drawing.Point(4, 32)
        Me.chkboxCar02.Name = "chkboxCar02"
        Me.chkboxCar02.TabIndex = 14
        Me.chkboxCar02.Text = "Péndulas"
        '
        'chkboxCar01
        '
        Me.chkboxCar01.Location = New System.Drawing.Point(4, 12)
        Me.chkboxCar01.Name = "chkboxCar01"
        Me.chkboxCar01.TabIndex = 13
        Me.chkboxCar01.Text = "Turgentes"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.AddRange(New System.Windows.Forms.Control() {Me.radMamaSim02, Me.radMamaSim01})
        Me.GroupBox13.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(130, 64)
        Me.GroupBox13.TabIndex = 11
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Simetría"
        '
        'radMamaSim02
        '
        Me.radMamaSim02.Location = New System.Drawing.Point(8, 36)
        Me.radMamaSim02.Name = "radMamaSim02"
        Me.radMamaSim02.TabIndex = 1
        Me.radMamaSim02.Text = "Asimétricas"
        '
        'radMamaSim01
        '
        Me.radMamaSim01.Location = New System.Drawing.Point(8, 12)
        Me.radMamaSim01.Name = "radMamaSim01"
        Me.radMamaSim01.TabIndex = 0
        Me.radMamaSim01.Text = "Simétricas"
        '
        'tp03
        '
        Me.tp03.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label47, Me.txtCardiopulmonar, Me.GroupBox19, Me.GroupBox18})
        Me.tp03.Location = New System.Drawing.Point(4, 22)
        Me.tp03.Name = "tp03"
        Me.tp03.Size = New System.Drawing.Size(624, 334)
        Me.tp03.TabIndex = 3
        Me.tp03.Text = "Cardiopulmonar"
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(8, 220)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(296, 16)
        Me.Label47.TabIndex = 20
        Me.Label47.Text = "Cardiopulmonar (Notas y Comentarios adicionales)"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCardiopulmonar
        '
        Me.txtCardiopulmonar.Location = New System.Drawing.Point(8, 236)
        Me.txtCardiopulmonar.MaxLength = 1024
        Me.txtCardiopulmonar.Multiline = True
        Me.txtCardiopulmonar.Name = "txtCardiopulmonar"
        Me.txtCardiopulmonar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCardiopulmonar.Size = New System.Drawing.Size(612, 92)
        Me.txtCardiopulmonar.TabIndex = 19
        Me.txtCardiopulmonar.Text = ""
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbAgregadosArea, Me.Label30, Me.cbAgregados, Me.Label31, Me.cbMurmulloArea, Me.Label32, Me.cbMurmullo, Me.Label33})
        Me.GroupBox19.Location = New System.Drawing.Point(6, 120)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(614, 92)
        Me.GroupBox19.TabIndex = 12
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Pulmones"
        '
        'cbAgregadosArea
        '
        Me.cbAgregadosArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAgregadosArea.Items.AddRange(New Object() {"en todas las áreas pulmonares", "en ambos Apex", "en apex Derecho", "en apex Izquierdo", "Bibasales", "en base Derecha", "en base Izquierda", "en tercio Medio Derecho", "en tercio Medio Izquierdo"})
        Me.cbAgregadosArea.Location = New System.Drawing.Point(392, 56)
        Me.cbAgregadosArea.Name = "cbAgregadosArea"
        Me.cbAgregadosArea.Size = New System.Drawing.Size(216, 21)
        Me.cbAgregadosArea.TabIndex = 8
        Me.cbAgregadosArea.Visible = False
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(320, 56)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 24)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "RA. (área)"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label30.Visible = False
        '
        'cbAgregados
        '
        Me.cbAgregados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAgregados.Items.AddRange(New Object() {"Sin agregados", "Crepitantes", "Sibilantes", "Roncus", "Bulosos", "Frote"})
        Me.cbAgregados.Location = New System.Drawing.Point(88, 56)
        Me.cbAgregados.MaxDropDownItems = 10
        Me.cbAgregados.Name = "cbAgregados"
        Me.cbAgregados.Size = New System.Drawing.Size(216, 21)
        Me.cbAgregados.TabIndex = 6
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(8, 56)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 24)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "R. Agregados"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbMurmulloArea
        '
        Me.cbMurmulloArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMurmulloArea.Items.AddRange(New Object() {"todas las áreas pulmonares", "ambos apex pulmonares", "apex pulmonar derecho", "apex pulmonar izquierdo", "ambas bases pulmonares", "base pulmonar derecha", "base pulmonar izquierda", "tercio medio pulmonar derecho", "tercio medio pulmonar izquierdo"})
        Me.cbMurmulloArea.Location = New System.Drawing.Point(392, 16)
        Me.cbMurmulloArea.Name = "cbMurmulloArea"
        Me.cbMurmulloArea.Size = New System.Drawing.Size(216, 21)
        Me.cbMurmulloArea.TabIndex = 4
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(320, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 24)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "MV (área)"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbMurmullo
        '
        Me.cbMurmullo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMurmullo.Items.AddRange(New Object() {"presente", "ausente", "disminuido", "aumentado"})
        Me.cbMurmullo.Location = New System.Drawing.Point(88, 16)
        Me.cbMurmullo.Name = "cbMurmullo"
        Me.cbMurmullo.Size = New System.Drawing.Size(216, 21)
        Me.cbMurmullo.TabIndex = 2
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(16, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 24)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "M. Vesicular"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbSoploArea, Me.Label29, Me.cbSoploTipo, Me.Label28, Me.cbCorazonIntensidad, Me.Label27, Me.cbCorazonRitmo, Me.Label26})
        Me.GroupBox18.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(612, 92)
        Me.GroupBox18.TabIndex = 11
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Corazón"
        '
        'cbSoploArea
        '
        Me.cbSoploArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSoploArea.Items.AddRange(New Object() {"en área mitral", "en área tricuspidea", "en área pulmonar", "en área aórtica", "en área aórtica accesoria"})
        Me.cbSoploArea.Location = New System.Drawing.Point(392, 56)
        Me.cbSoploArea.Name = "cbSoploArea"
        Me.cbSoploArea.Size = New System.Drawing.Size(216, 21)
        Me.cbSoploArea.TabIndex = 8
        Me.cbSoploArea.Visible = False
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(320, 56)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 24)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Soplo (área)"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label29.Visible = False
        '
        'cbSoploTipo
        '
        Me.cbSoploTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSoploTipo.Items.AddRange(New Object() {"Sin soplos", "Soplo sistólico", "Soplo protosistólico", "Soplo telesistólico", "Soplo holosistólico", "Soplo diastólico", "Soplo protoDiastólico", "Soplo telediastólico", "Soplo holodiastólico", "Soplo continuo"})
        Me.cbSoploTipo.Location = New System.Drawing.Point(88, 56)
        Me.cbSoploTipo.MaxDropDownItems = 10
        Me.cbSoploTipo.Name = "cbSoploTipo"
        Me.cbSoploTipo.Size = New System.Drawing.Size(216, 21)
        Me.cbSoploTipo.TabIndex = 6
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(16, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 24)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Soplo (tipos)"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCorazonIntensidad
        '
        Me.cbCorazonIntensidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCorazonIntensidad.Items.AddRange(New Object() {"Normofonéticos", "Hiperfonéticos", "Hipofonéticos"})
        Me.cbCorazonIntensidad.Location = New System.Drawing.Point(392, 16)
        Me.cbCorazonIntensidad.Name = "cbCorazonIntensidad"
        Me.cbCorazonIntensidad.Size = New System.Drawing.Size(216, 21)
        Me.cbCorazonIntensidad.TabIndex = 4
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(320, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 24)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Intensidad"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCorazonRitmo
        '
        Me.cbCorazonRitmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCorazonRitmo.Items.AddRange(New Object() {"Ruidos cardíacos rítmicos", "Ruidos cardíacos arrítmicos"})
        Me.cbCorazonRitmo.Location = New System.Drawing.Point(88, 16)
        Me.cbCorazonRitmo.Name = "cbCorazonRitmo"
        Me.cbCorazonRitmo.Size = New System.Drawing.Size(216, 21)
        Me.cbCorazonRitmo.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(16, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 24)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Ritmo"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tp04
        '
        Me.tp04.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label55, Me.txtAbdomen, Me.GroupBox21, Me.GroupBox20})
        Me.tp04.Location = New System.Drawing.Point(4, 22)
        Me.tp04.Name = "tp04"
        Me.tp04.Size = New System.Drawing.Size(624, 334)
        Me.tp04.TabIndex = 4
        Me.tp04.Text = "Abdomen"
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(8, 220)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(296, 16)
        Me.Label55.TabIndex = 22
        Me.Label55.Text = "Abdomen (Notas y Comentarios adicionales)"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtAbdomen
        '
        Me.txtAbdomen.Location = New System.Drawing.Point(8, 236)
        Me.txtAbdomen.MaxLength = 1024
        Me.txtAbdomen.Multiline = True
        Me.txtAbdomen.Name = "txtAbdomen"
        Me.txtAbdomen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbdomen.Size = New System.Drawing.Size(612, 92)
        Me.txtAbdomen.TabIndex = 21
        Me.txtAbdomen.Text = ""
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbAbdTUsensibilidad, Me.Label41, Me.cbAbdTUadherencias, Me.Label40, Me.cbAbdTUtipo, Me.cbAbdTUconsistencia, Me.Label38, Me.Label37})
        Me.GroupBox21.Location = New System.Drawing.Point(8, 132)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(612, 84)
        Me.GroupBox21.TabIndex = 14
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Tumoraciones"
        '
        'cbAbdTUsensibilidad
        '
        Me.cbAbdTUsensibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAbdTUsensibilidad.Items.AddRange(New Object() {"no doloroso", "doloroso", "doloroso al tacto", "doloroso a la presión", "con signo de defensa", "blumberg positivo"})
        Me.cbAbdTUsensibilidad.Location = New System.Drawing.Point(396, 48)
        Me.cbAbdTUsensibilidad.Name = "cbAbdTUsensibilidad"
        Me.cbAbdTUsensibilidad.Size = New System.Drawing.Size(212, 21)
        Me.cbAbdTUsensibilidad.TabIndex = 16
        Me.cbAbdTUsensibilidad.Visible = False
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(312, 48)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(84, 24)
        Me.Label41.TabIndex = 15
        Me.Label41.Text = "Sensibilidad"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label41.Visible = False
        '
        'cbAbdTUadherencias
        '
        Me.cbAbdTUadherencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAbdTUadherencias.Items.AddRange(New Object() {"no adherido móvil", "adherido a plano profundo", "adherido a plan superficial", "adherido a ambos planos"})
        Me.cbAbdTUadherencias.Location = New System.Drawing.Point(88, 48)
        Me.cbAbdTUadherencias.Name = "cbAbdTUadherencias"
        Me.cbAbdTUadherencias.Size = New System.Drawing.Size(212, 21)
        Me.cbAbdTUadherencias.TabIndex = 14
        Me.cbAbdTUadherencias.Visible = False
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(4, 48)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(84, 24)
        Me.Label40.TabIndex = 13
        Me.Label40.Text = "Adherencias"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label40.Visible = False
        '
        'cbAbdTUtipo
        '
        Me.cbAbdTUtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAbdTUtipo.Items.AddRange(New Object() {"Sin tumoraciones", "TU epigástrico", "TU mesogástrico", "TU hipogástrico", "TU parauterino Derecho", "TU parauterino Izquierdo", "TU en fosa Iliaca Derecha", "TU en fosa Iliaca Izquierda", "TU en hipocondrio Derecho", "TU en hipocondrio Izquierdo", "TU en flanco Derecho", "TU en flanco Izquierdo"})
        Me.cbAbdTUtipo.Location = New System.Drawing.Point(88, 20)
        Me.cbAbdTUtipo.Name = "cbAbdTUtipo"
        Me.cbAbdTUtipo.Size = New System.Drawing.Size(212, 21)
        Me.cbAbdTUtipo.TabIndex = 10
        '
        'cbAbdTUconsistencia
        '
        Me.cbAbdTUconsistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAbdTUconsistencia.Items.AddRange(New Object() {"sólido", "renitente", "quistico", "blando"})
        Me.cbAbdTUconsistencia.Location = New System.Drawing.Point(396, 20)
        Me.cbAbdTUconsistencia.Name = "cbAbdTUconsistencia"
        Me.cbAbdTUconsistencia.Size = New System.Drawing.Size(212, 21)
        Me.cbAbdTUconsistencia.TabIndex = 12
        Me.cbAbdTUconsistencia.Visible = False
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(300, 20)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(96, 24)
        Me.Label38.TabIndex = 11
        Me.Label38.Text = "Tu (Consistencia)"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label38.Visible = False
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(4, 20)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(84, 24)
        Me.Label37.TabIndex = 9
        Me.Label37.Text = "Tumoraciones"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbAbdRuidos, Me.Label42, Me.cbAbdSensibilidad, Me.Label39, Me.cbAbdViceromegalias, Me.Label36, Me.Label35, Me.Label34, Me.cbAbdConformacion, Me.cbAbdConsistencia})
        Me.GroupBox20.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(612, 112)
        Me.GroupBox20.TabIndex = 13
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Características del Abdomen"
        '
        'cbAbdRuidos
        '
        Me.cbAbdRuidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAbdRuidos.Items.AddRange(New Object() {"presentes", "ausentes", "disminuidos", "aumentados"})
        Me.cbAbdRuidos.Location = New System.Drawing.Point(92, 76)
        Me.cbAbdRuidos.Name = "cbAbdRuidos"
        Me.cbAbdRuidos.Size = New System.Drawing.Size(212, 21)
        Me.cbAbdRuidos.TabIndex = 12
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(4, 76)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(88, 24)
        Me.Label42.TabIndex = 11
        Me.Label42.Text = "R. Hidroaereos"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbAbdSensibilidad
        '
        Me.cbAbdSensibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAbdSensibilidad.Items.AddRange(New Object() {"no doloroso", "doloroso", "doloroso al tacto", "doloroso a la presión", "con signo de defensa", "con blumberg positivo"})
        Me.cbAbdSensibilidad.Location = New System.Drawing.Point(392, 48)
        Me.cbAbdSensibilidad.Name = "cbAbdSensibilidad"
        Me.cbAbdSensibilidad.Size = New System.Drawing.Size(216, 21)
        Me.cbAbdSensibilidad.TabIndex = 10
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(308, 48)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(84, 24)
        Me.Label39.TabIndex = 9
        Me.Label39.Text = "Sensibilidad"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbAbdViceromegalias
        '
        Me.cbAbdViceromegalias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAbdViceromegalias.Items.AddRange(New Object() {"No se evidencian visceromegalias", "Útero gestante", "Hepatomegalia", "Esplenomegalia", "Hepatoesplenomegalia"})
        Me.cbAbdViceromegalias.Location = New System.Drawing.Point(92, 48)
        Me.cbAbdViceromegalias.Name = "cbAbdViceromegalias"
        Me.cbAbdViceromegalias.Size = New System.Drawing.Size(212, 21)
        Me.cbAbdViceromegalias.TabIndex = 8
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(4, 48)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(88, 24)
        Me.Label36.TabIndex = 7
        Me.Label36.Text = "Visceromegalias"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(308, 20)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 24)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Conformación"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(4, 20)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(88, 24)
        Me.Label34.TabIndex = 3
        Me.Label34.Text = "Consistencia"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbAbdConformacion
        '
        Me.cbAbdConformacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAbdConformacion.Items.AddRange(New Object() {"normal", "globuloso", "péndulo", "excabado"})
        Me.cbAbdConformacion.Location = New System.Drawing.Point(392, 20)
        Me.cbAbdConformacion.Name = "cbAbdConformacion"
        Me.cbAbdConformacion.Size = New System.Drawing.Size(216, 21)
        Me.cbAbdConformacion.TabIndex = 6
        '
        'cbAbdConsistencia
        '
        Me.cbAbdConsistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAbdConsistencia.Items.AddRange(New Object() {"blando, depresible", "rígido con defensa", "en tabla"})
        Me.cbAbdConsistencia.Location = New System.Drawing.Point(92, 20)
        Me.cbAbdConsistencia.Name = "cbAbdConsistencia"
        Me.cbAbdConsistencia.Size = New System.Drawing.Size(212, 21)
        Me.cbAbdConsistencia.TabIndex = 4
        '
        'tp05
        '
        Me.tp05.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox8, Me.GroupBox7, Me.GroupBox6, Me.Label56, Me.txtGenitalesExt, Me.GroupBox22})
        Me.tp05.Location = New System.Drawing.Point(4, 22)
        Me.tp05.Name = "tp05"
        Me.tp05.Size = New System.Drawing.Size(624, 334)
        Me.tp05.TabIndex = 5
        Me.tp05.Text = "Genitales Ext"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.AddRange(New System.Windows.Forms.Control() {Me.ComboBox15, Me.ComboBox11, Me.Label71, Me.ComboBox12, Me.ComboBox13, Me.Label72, Me.ComboBox14, Me.Label73, Me.Label74, Me.Label75})
        Me.GroupBox8.Location = New System.Drawing.Point(472, 8)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(150, 208)
        Me.GroupBox8.TabIndex = 27
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Lesión 3"
        '
        'ComboBox11
        '
        Me.ComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox11.Items.AddRange(New Object() {"dolorosa", "dolorosa al tacto", "pruriginosa", "indolora"})
        Me.ComboBox11.Location = New System.Drawing.Point(3, 172)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox11.TabIndex = 32
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(4, 16)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(92, 12)
        Me.Label71.TabIndex = 23
        Me.Label71.Text = "Tipo de Lesión"
        '
        'ComboBox12
        '
        Me.ComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox12.Items.AddRange(New Object() {"Condiloma", "Herpes genital", "Chancro sifilítico", "Liquen plano", "Mácula", "Pápula", "Pústula", "Ulcera", "Nevus"})
        Me.ComboBox12.Location = New System.Drawing.Point(4, 28)
        Me.ComboBox12.MaxDropDownItems = 20
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox12.TabIndex = 29
        '
        'ComboBox13
        '
        Me.ComboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox13.Items.AddRange(New Object() {"Lesión única", "Grupo de 2 lesiones", "Grupo de 3 lesiones", "Grupo de 4 lesiones", "Grupo de 5 lesiones", "Múltiples lesiones"})
        Me.ComboBox13.Location = New System.Drawing.Point(4, 64)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox13.TabIndex = 24
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(4, 52)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(92, 12)
        Me.Label72.TabIndex = 28
        Me.Label72.Text = "Disposición"
        '
        'ComboBox14
        '
        Me.ComboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox14.Items.AddRange(New Object() {"1 mm", "2 mm", "3 mm", "4 mm", "5 mm", "10 mm", "15 mm", "20 mm ó más"})
        Me.ComboBox14.Location = New System.Drawing.Point(4, 100)
        Me.ComboBox14.Name = "ComboBox14"
        Me.ComboBox14.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox14.TabIndex = 26
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(4, 88)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(92, 12)
        Me.Label73.TabIndex = 25
        Me.Label73.Text = "Tamaño (mm)"
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(4, 124)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(92, 12)
        Me.Label74.TabIndex = 30
        Me.Label74.Text = "Ubicación"
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(4, 160)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(92, 12)
        Me.Label75.TabIndex = 27
        Me.Label75.Text = "Sensibilidad"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.AddRange(New System.Windows.Forms.Control() {Me.ComboBox5, Me.ComboBox1, Me.Label63, Me.ComboBox4, Me.ComboBox3, Me.Label64, Me.ComboBox2, Me.Label62, Me.Label65, Me.Label61})
        Me.GroupBox7.Location = New System.Drawing.Point(320, 8)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(150, 208)
        Me.GroupBox7.TabIndex = 26
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Lesión 2"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"dolorosa", "dolorosa al tacto", "pruriginosa", "indolora"})
        Me.ComboBox1.Location = New System.Drawing.Point(3, 172)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(4, 16)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(92, 12)
        Me.Label63.TabIndex = 12
        Me.Label63.Text = "Tipo de Lesión"
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Items.AddRange(New Object() {"Condiloma", "Herpes genital", "Chancro sifilítico", "Liquen plano", "Mácula", "Pápula", "Pústula", "Ulcera", "Nevus"})
        Me.ComboBox4.Location = New System.Drawing.Point(4, 28)
        Me.ComboBox4.MaxDropDownItems = 20
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox4.TabIndex = 19
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Items.AddRange(New Object() {"Lesión única", "Grupo de 2 lesiones", "Grupo de 3 lesiones", "Grupo de 4 lesiones", "Grupo de 5 lesiones", "Múltiples lesiones"})
        Me.ComboBox3.Location = New System.Drawing.Point(4, 64)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox3.TabIndex = 13
        '
        'Label64
        '
        Me.Label64.Location = New System.Drawing.Point(4, 52)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(92, 12)
        Me.Label64.TabIndex = 18
        Me.Label64.Text = "Disposición"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Items.AddRange(New Object() {"1 mm", "2 mm", "3 mm", "4 mm", "5 mm", "10 mm", "15 mm", "20 mm ó más"})
        Me.ComboBox2.Location = New System.Drawing.Point(4, 100)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox2.TabIndex = 15
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(4, 88)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(92, 12)
        Me.Label62.TabIndex = 14
        Me.Label62.Text = "Tamaño (mm)"
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(4, 124)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(92, 12)
        Me.Label65.TabIndex = 20
        Me.Label65.Text = "Ubicación"
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(4, 160)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(92, 12)
        Me.Label61.TabIndex = 16
        Me.Label61.Text = "Sensibilidad"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.AddRange(New System.Windows.Forms.Control() {Me.ComboBox6, Me.Label66, Me.ComboBox7, Me.ComboBox8, Me.Label67, Me.ComboBox9, Me.Label68, Me.ComboBox10, Me.Label69, Me.Label70})
        Me.GroupBox6.Location = New System.Drawing.Point(168, 8)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(150, 208)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Lesión 1"
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.Items.AddRange(New Object() {"dolorosa", "dolorosa al tacto", "pruriginosa", "indolora"})
        Me.ComboBox6.Location = New System.Drawing.Point(3, 172)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox6.TabIndex = 32
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(4, 16)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(92, 12)
        Me.Label66.TabIndex = 23
        Me.Label66.Text = "Tipo de Lesión"
        '
        'ComboBox7
        '
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.Items.AddRange(New Object() {"Condiloma", "Herpes genital", "Chancro sifilítico", "Liquen plano", "Mácula", "Pápula", "Pústula", "Ulcera", "Nevus"})
        Me.ComboBox7.Location = New System.Drawing.Point(4, 28)
        Me.ComboBox7.MaxDropDownItems = 20
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox7.TabIndex = 29
        '
        'ComboBox8
        '
        Me.ComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox8.Items.AddRange(New Object() {"Lesión única", "Grupo de 2 lesiones", "Grupo de 3 lesiones", "Grupo de 4 lesiones", "Grupo de 5 lesiones", "Múltiples lesiones"})
        Me.ComboBox8.Location = New System.Drawing.Point(4, 64)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox8.TabIndex = 24
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(4, 52)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(92, 12)
        Me.Label67.TabIndex = 28
        Me.Label67.Text = "Disposición"
        '
        'ComboBox9
        '
        Me.ComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox9.Items.AddRange(New Object() {"1 mm", "2 mm", "3 mm", "4 mm", "5 mm", "10 mm", "15 mm", "20 mm ó más"})
        Me.ComboBox9.Location = New System.Drawing.Point(4, 100)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox9.TabIndex = 26
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(4, 88)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(92, 12)
        Me.Label68.TabIndex = 25
        Me.Label68.Text = "Tamaño (mm)"
        '
        'ComboBox10
        '
        Me.ComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox10.Items.AddRange(New Object() {"Vulva y periné", "Vulva", "Periné", "Labios mayores", "Labio mayor izquierdo", "Labio mayor derecho", "Labios menores", "Labio menor izquierdo", "Labio menor derecho", "Horquilla vulvar", "Clítoris", "Vestíbulo", "Introito vaginal", "Periuretral", "Monte de Venus", "Región perianal", "Pliegue inguinal", "Pliegue intergluteo", "Cara interna de los muslos", "Cara interna del muslo izquierdo", "Cara interna del muslo derecho"})
        Me.ComboBox10.Location = New System.Drawing.Point(4, 136)
        Me.ComboBox10.MaxDropDownItems = 21
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox10.TabIndex = 31
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(4, 124)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(92, 12)
        Me.Label69.TabIndex = 30
        Me.Label69.Text = "Ubicación"
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(4, 160)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(92, 12)
        Me.Label70.TabIndex = 27
        Me.Label70.Text = "Sensibilidad"
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(8, 220)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(296, 16)
        Me.Label56.TabIndex = 24
        Me.Label56.Text = "Genitales externos (Notas y Comentarios Adicionales)"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtGenitalesExt
        '
        Me.txtGenitalesExt.Location = New System.Drawing.Point(8, 236)
        Me.txtGenitalesExt.MaxLength = 1024
        Me.txtGenitalesExt.Multiline = True
        Me.txtGenitalesExt.Name = "txtGenitalesExt"
        Me.txtGenitalesExt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGenitalesExt.Size = New System.Drawing.Size(612, 92)
        Me.txtGenitalesExt.TabIndex = 23
        Me.txtGenitalesExt.Text = ""
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label43})
        Me.GroupBox22.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(160, 208)
        Me.GroupBox22.TabIndex = 13
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Vulva y Periné"
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(4, 16)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(128, 24)
        Me.Label43.TabIndex = 20
        Me.Label43.Text = "Aspecto y Configuración"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tp06
        '
        Me.tp06.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label44, Me.txtEspeculo})
        Me.tp06.Location = New System.Drawing.Point(4, 22)
        Me.tp06.Name = "tp06"
        Me.tp06.Size = New System.Drawing.Size(624, 334)
        Me.tp06.TabIndex = 6
        Me.tp06.Text = "Espéculo"
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(8, 220)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(296, 16)
        Me.Label44.TabIndex = 26
        Me.Label44.Text = "Espéculo (Notas y Comentarios Adicionales)"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtEspeculo
        '
        Me.txtEspeculo.Location = New System.Drawing.Point(8, 236)
        Me.txtEspeculo.MaxLength = 1024
        Me.txtEspeculo.Multiline = True
        Me.txtEspeculo.Name = "txtEspeculo"
        Me.txtEspeculo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEspeculo.Size = New System.Drawing.Size(612, 92)
        Me.txtEspeculo.TabIndex = 25
        Me.txtEspeculo.Text = ""
        '
        'tp07
        '
        Me.tp07.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox1, Me.Label57, Me.txtColposcopia})
        Me.tp07.Location = New System.Drawing.Point(4, 22)
        Me.tp07.Name = "tp07"
        Me.tp07.Size = New System.Drawing.Size(624, 334)
        Me.tp07.TabIndex = 7
        Me.tp07.Text = "Colposcopia"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(8, 220)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(296, 16)
        Me.Label57.TabIndex = 26
        Me.Label57.Text = "Colposcopia (Notas y Comentarios Adicionales)"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtColposcopia
        '
        Me.txtColposcopia.Location = New System.Drawing.Point(8, 236)
        Me.txtColposcopia.MaxLength = 1024
        Me.txtColposcopia.Multiline = True
        Me.txtColposcopia.Name = "txtColposcopia"
        Me.txtColposcopia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtColposcopia.Size = New System.Drawing.Size(612, 92)
        Me.txtColposcopia.TabIndex = 25
        Me.txtColposcopia.Text = ""
        '
        'tp08
        '
        Me.tp08.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label58, Me.txtTacto})
        Me.tp08.Location = New System.Drawing.Point(4, 22)
        Me.tp08.Name = "tp08"
        Me.tp08.Size = New System.Drawing.Size(624, 334)
        Me.tp08.TabIndex = 8
        Me.tp08.Text = "Tacto"
        '
        'Label58
        '
        Me.Label58.Location = New System.Drawing.Point(8, 220)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(296, 16)
        Me.Label58.TabIndex = 26
        Me.Label58.Text = "Tacto (Notas y Comentarios Adicionales)"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtTacto
        '
        Me.txtTacto.Location = New System.Drawing.Point(8, 236)
        Me.txtTacto.MaxLength = 1024
        Me.txtTacto.Multiline = True
        Me.txtTacto.Name = "txtTacto"
        Me.txtTacto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTacto.Size = New System.Drawing.Size(612, 92)
        Me.txtTacto.TabIndex = 25
        Me.txtTacto.Text = ""
        '
        'tp09
        '
        Me.tp09.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label59, Me.txtMsIs})
        Me.tp09.Location = New System.Drawing.Point(4, 22)
        Me.tp09.Name = "tp09"
        Me.tp09.Size = New System.Drawing.Size(624, 334)
        Me.tp09.TabIndex = 9
        Me.tp09.Text = "MsIs"
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(8, 220)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(296, 16)
        Me.Label59.TabIndex = 26
        Me.Label59.Text = "Miembros Inferiores (Notas y Comentarios Adicionales)"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtMsIs
        '
        Me.txtMsIs.Location = New System.Drawing.Point(8, 236)
        Me.txtMsIs.MaxLength = 1024
        Me.txtMsIs.Multiline = True
        Me.txtMsIs.Name = "txtMsIs"
        Me.txtMsIs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsIs.Size = New System.Drawing.Size(612, 92)
        Me.txtMsIs.TabIndex = 25
        Me.txtMsIs.Text = ""
        '
        'tp10
        '
        Me.tp10.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label60, Me.txtNeurologico})
        Me.tp10.Location = New System.Drawing.Point(4, 22)
        Me.tp10.Name = "tp10"
        Me.tp10.Size = New System.Drawing.Size(624, 334)
        Me.tp10.TabIndex = 10
        Me.tp10.Text = "Neurológico"
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(8, 220)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(296, 16)
        Me.Label60.TabIndex = 26
        Me.Label60.Text = "Neurológico (Notas y Comentarios Adicionales)"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtNeurologico
        '
        Me.txtNeurologico.Location = New System.Drawing.Point(8, 236)
        Me.txtNeurologico.MaxLength = 1024
        Me.txtNeurologico.Multiline = True
        Me.txtNeurologico.Name = "txtNeurologico"
        Me.txtNeurologico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNeurologico.Size = New System.Drawing.Size(612, 92)
        Me.txtNeurologico.TabIndex = 25
        Me.txtNeurologico.Text = ""
        '
        'botGuardarNuevosDatos
        '
        Me.botGuardarNuevosDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botGuardarNuevosDatos.Image = CType(resources.GetObject("botGuardarNuevosDatos.Image"), System.Drawing.Bitmap)
        Me.botGuardarNuevosDatos.Location = New System.Drawing.Point(416, 376)
        Me.botGuardarNuevosDatos.Name = "botGuardarNuevosDatos"
        Me.botGuardarNuevosDatos.Size = New System.Drawing.Size(224, 23)
        Me.botGuardarNuevosDatos.TabIndex = 5
        Me.botGuardarNuevosDatos.Text = "Guarda Nuevos Datos"
        '
        'botCancelar
        '
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Bitmap)
        Me.botCancelar.Location = New System.Drawing.Point(8, 376)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(224, 23)
        Me.botCancelar.TabIndex = 6
        Me.botCancelar.Text = "Cancelar"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Items.AddRange(New Object() {"Vulva y periné", "Vulva", "Periné", "Labios mayores", "Labio mayor izquierdo", "Labio mayor derecho", "Labios menores", "Labio menor izquierdo", "Labio menor derecho", "Horquilla vulvar", "Clítoris", "Vestíbulo", "Introito vaginal", "Periuretral", "Monte de Venus", "Región perianal", "Pliegue inguinal", "Pliegue intergluteo", "Cara interna de los muslos", "Cara interna del muslo izquierdo", "Cara interna del muslo derecho"})
        Me.ComboBox5.Location = New System.Drawing.Point(4, 136)
        Me.ComboBox5.MaxDropDownItems = 21
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox5.TabIndex = 32
        '
        'ComboBox15
        '
        Me.ComboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox15.Items.AddRange(New Object() {"Vulva y periné", "Vulva", "Periné", "Labios mayores", "Labio mayor izquierdo", "Labio mayor derecho", "Labios menores", "Labio menor izquierdo", "Labio menor derecho", "Horquilla vulvar", "Clítoris", "Vestíbulo", "Introito vaginal", "Periuretral", "Monte de Venus", "Región perianal", "Pliegue inguinal", "Pliegue intergluteo", "Cara interna de los muslos", "Cara interna del muslo izquierdo", "Cara interna del muslo derecho"})
        Me.ComboBox15.Location = New System.Drawing.Point(3, 136)
        Me.ComboBox15.MaxDropDownItems = 21
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox15.TabIndex = 33
        '
        'FormExamenFisicoGinecologico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(646, 404)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.botCancelar, Me.botGuardarNuevosDatos, Me.TabControl1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormExamenFisicoGinecologico"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examen Físico Ginecológico"
        Me.TabControl1.ResumeLayout(False)
        Me.tp01.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.tbTEMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.tbRESP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.tbPULSO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.tbGR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbKG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.tbTAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp02.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.tp03.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        Me.tp04.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        Me.tp05.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox22.ResumeLayout(False)
        Me.tp06.ResumeLayout(False)
        Me.tp07.ResumeLayout(False)
        Me.tp08.ResumeLayout(False)
        Me.tp09.ResumeLayout(False)
        Me.tp10.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim DatosModificados As Boolean
    Dim AlgoEnLaLinea As Boolean
    Dim AlgoEnElParrafo As Boolean
    Dim AlgoEnLaVentana As Boolean

    Dim SumaBinaria As Integer
    Dim ValorGuardado As Integer
    Dim Resultado As Integer
    Dim Texto As String

    Dim ExFi As String 'para acortar las lineas

    Dim Valor As Integer
    Dim KG As String
    Dim GR As Double
    Dim GRstring As String
    Dim TEMP As String
    Dim PESO As String

    Dim Item(300) As String


    Private Sub FormExamenFisicoGinecologico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'le pone nombre al titulo
        Me.Text = "Examen Físico Ginecológico de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"

        'primero revisa si hay datos en el chorizo
        If Form1.ExamenFisicoCodificado <> " " Then
            'existe algun dato codificado, lo lee
            LeeExamenFisicoCodificado()
            ActualizaPantallaconItems()
        Else
            'no exite nada codificado lo crea
            CreaExamenFisicoCodificado()
        End If

        'inicialmente pone todo sin cambios
        DatosNoModificados()


    End Sub

    Private Sub DatosNoModificados()
        'inicializa botones y opciones
        botCancelar.Enabled = True
        botCancelar.Text = "Salir"
        botGuardarNuevosDatos.Enabled = False
        DatosModificados = False
    End Sub

    Private Sub DatosSeModificaron()
        botCancelar.Text = "Descarta Cambios"
        botGuardarNuevosDatos.Enabled = True
        DatosModificados = True
    End Sub

    Private Sub CreaExamenFisicoCodificado()
        'inicializa todos los items
        Dim tt As Integer
        For tt = 0 To 300
            Item(tt) = "€"
        Next

        'lo siguiente a modo de indice... no hace falta realmente

        '0000000000000000000000000000000000000000000000000
        'ficha signos vitales
        Item(0) = "€" 'TAS
        Item(1) = "€" 'TAD
        Item(2) = "€" 'Pulso
        Item(3) = "€" 'resp
        Item(4) = "€" 'temp
        Item(5) = "€" 'Peso(Kg)
        Item(6) = "€" 'Peso(gr)

        Item(7) = "€" 'adicional porsia
        Item(8) = "€" 'adicional porsia
        Item(9) = "€" 'adicional porsia
        Item(10) = "€" 'adicional porsia

        '00000000000000000000000000000000000000000000
        'ficha condiciones generales
        Item(11) = "€" 'Condiciones generales
        Item(12) = "€" 'Hidratacion
        Item(13) = "€" 'Respiracion
        Item(14) = "€" 'Tez de la piel
        Item(15) = "€" 'temperatura
        Item(16) = "€" 'Via oral
        Item(17) = "€" 'Diuresis
        Item(18) = "€" 'comentarios y subjetivos de CsGs (ojo numeracion)

        Item(19) = "€" 'adicional porsia
        Item(20) = "€" 'adicional porsia
        Item(21) = "€" 'adicional porsia
        Item(22) = "€" 'adicional porsia

        '000000000000000000000000000000000000
        'ficha mama
        Item(23) = "€" 'Simetria mamaria
        Item(24) = "€" 'Caracteristicas de la mama
        Item(25) = "€" 'lesion1 cual mama
        Item(26) = "€" 'lesion1 cual cuadrante
        Item(27) = "€" 'lesion1 tipo de lesion
        Item(28) = "€" 'lesion1 tamaño de la lesion
        Item(29) = "€" 'lesion1 adherencias
        Item(30) = "€" 'lesion1 sensibilidad
        Item(31) = "€" 'lesion2 cual mama
        Item(32) = "€" 'lesion2 cual cuadrante
        Item(33) = "€" 'lesion2 tipo de lesion
        Item(34) = "€" 'lesion2 tamaño de la lesion
        Item(35) = "€" 'lesion2 adherencias
        Item(36) = "€" 'lesion2 sensibilidad
        Item(37) = "€" 'lesion3 cual mama
        Item(38) = "€" 'lesion3 cual cuadrante
        Item(39) = "€" 'lesion3 tipo de lesion
        Item(40) = "€" 'lesion3 tamaño de la lesion
        Item(41) = "€" 'lesion3 adherencias
        Item(42) = "€" 'lesion3 sensibilidad
        Item(43) = "€" 'comentarios adicionales en mama

        Item(44) = "€" 'adicional porsia
        Item(45) = "€" 'adicional porsia
        Item(46) = "€" 'adicional porsia
        Item(47) = "€" 'adicional porsia
        Item(48) = "€" 'adicional porsia
        Item(49) = "€" 'adicional porsia
        Item(50) = "€" 'adicional porsia
        Item(51) = "€" 'adicional porsia

        '000000000000000000000000000000000000000000000
        'ficha Cardiopulmonar
        Item(52) = "€" 'Corazon Ritmo
        Item(53) = "€" 'Corazon Intensidad
        Item(54) = "€" 'Soplo tipo
        Item(55) = "€" 'Soplo area

        Item(56) = "€" 'adicional porsia
        Item(57) = "€" 'adicional porsia
        Item(58) = "€" 'adicional porsia
        Item(59) = "€" 'adicional porsia

        Item(60) = "€" 'Pulmon murmullo
        Item(61) = "€" 'murmullo areas
        Item(62) = "€" 'tipo de agregado
        Item(63) = "€" 'area del agregado

        Item(64) = "€" 'adicional porsia
        Item(65) = "€" 'adicional porsia
        Item(66) = "€" 'adicional porsia
        Item(67) = "€" 'adicional porsia

        Item(68) = "€" 'Comentarios adicionales de cardiopulmonar

        Item(69) = "€" 'adicional porsia
        Item(70) = "€" 'adicional porsia
        Item(71) = "€" 'adicional porsia
        Item(72) = "€" 'adicional porsia

        '00000000000000000000
        'Ficha de abdomen
        Item(73) = "€" 'Consistencia
        Item(74) = "€" 'conformacion del abdomen
        Item(75) = "€" 'viceromegalias
        Item(76) = "€" 'sensibilidad
        Item(77) = "€" 'Ruidos hidroaereos

        Item(78) = "€" 'adicional porsia
        Item(79) = "€" 'adicional porsia
        Item(80) = "€" 'adicional porsia
        Item(81) = "€" 'adicional porsia

        Item(82) = "€" 'TU abdominal tipo
        Item(83) = "€" 'TU abdominal consistencia
        Item(84) = "€" 'Tu abdominal adherencias
        Item(85) = "€" 'TU abdominal sensibilidad

        Item(86) = "€" 'adicional porsia
        Item(87) = "€" 'adicional porsia
        Item(88) = "€" 'adicional porsia
        Item(89) = "€" 'adicional porsia
        Item(90) = "€" 'adicional porsia
        Item(91) = "€" 'adicional porsia
        Item(92) = "€" 'adicional porsia
        Item(93) = "€" 'adicional porsia
        Item(94) = "€" 'adicional porsia
        Item(95) = "€" 'adicional porsia
        Item(96) = "€" 'adicional porsia
        Item(97) = "€" 'adicional porsia

        Item(98) = "€" 'Notas y comentarios adicionales de abdomen

        Item(99) = "€" 'adicional porsia
        Item(100) = "€" 'adicional porsia

        '0000000000000000000000
        'ojo pongo los restantes notas adicionales aca a continuacion
        'uno del otro para no desperdiciar espacio de la matriz
        'y poder programar paulatinamente el resto de los datos
        Item(101) = "€" 'notas adicionales de genitales ext
        Item(102) = "€" 'notas adicionales de especulo
        Item(103) = "€" 'notas adicionales de colposcopia
        Item(104) = "€" 'notas adicionales de tacto
        Item(105) = "€" 'notas adicionales de miembros inf
        Item(106) = "€" 'notas adicionales de neurologico

        Item(107) = "€" 'adicional porsia
        Item(108) = "€" 'adicional porsia
        Item(109) = "€" 'adicional porsia
        Item(110) = "€" 'adicional porsia

    End Sub

    Private Sub LeeExamenFisicoCodificado()
        Item = Form1.ExamenFisicoCodificado.Split("|")
    End Sub

    Private Sub ActualizaPantallaconItems()

        ActualizaSignosVitales()
        ActualizaCondicionesGenerales()
        ActualizaMama()
        ActualizaCardiopulmonar()
        ActualizaAbdomen()
        ActualizaGenitalesExt()
        ActualizaEspeculo()
        ActualizaColposcopia()
        ActualizaTacto()
        ActualizaMsIs()
        ActualizaNeurologico()


    End Sub

    Private Sub ActualizaSignosVitales()
        'Tension arterial
        If Item(0) <> "€" And Item(1) <> "€" Then
            tbTAS.Value = Item(0)
            labTAS.Text = Item(0)

            tbTAD.Value = Item(1)
            labTAD.Text = Item(1)
        End If

        'Pulso
        If Item(2) <> "€" Then
            tbPULSO.Value = Item(2)
            labPULSO.Text = Item(2)
        End If

        'Respiracion
        If Item(3) <> "€" Then
            tbRESP.Value = Item(3)
            labRESP.Text = Item(3)
        End If

        'Temperatura
        If Item(4) <> "€" Then
            Valor = Item(4) * 10
            tbTEMP.Value = Valor
            labTEMP.Text = Item(4)
        End If

        'Peso
        If Item(5) <> "€" Then
            tbKG.Value = Item(5)
            Valor = Item(6) \ 10
            tbGR.Value = Valor
            labPeso.Text = Item(5) & "." & Item(6)
        End If
    End Sub

    Private Sub ActualizaCondicionesGenerales()
        'Condiciones Generales
        If Item(11) <> "€" Then
            ValorGuardado = Item(11)
            cbCsGs.SelectedIndex = ValorGuardado
        End If

        'hidratacion
        If Item(12) <> "€" Then
            ValorGuardado = Item(12)
            cbHidratacion.SelectedIndex = ValorGuardado
        End If

        'Respiracion
        If Item(13) <> "€" Then
            ValorGuardado = Item(13)
            cbRespiracion.SelectedIndex = ValorGuardado
        End If

        'Tez de la piel
        If Item(14) <> "€" Then
            ValorGuardado = Item(14)
            cbTez.SelectedIndex = ValorGuardado
        End If

        'Temperatura
        If Item(15) <> "€" Then
            ValorGuardado = Item(15)
            cbTemperatura.SelectedIndex = ValorGuardado
        End If

        'tolerancia a la via oral
        If Item(16) <> "€" Then
            ValorGuardado = Item(16)
            cbViaOral.SelectedIndex = ValorGuardado
        End If

        'diuresis
        If Item(17) <> "€" Then
            ValorGuardado = Item(17)
            cbDiuresis.SelectedIndex = ValorGuardado
        End If

        'comentarios y subjetivos de las CsGs
        If Item(18) <> "€" Then
            txtCsGs.Text = Item(18)
        End If
    End Sub

    Private Sub ActualizaMama()
        'Simetria mamaria
        If Item(23) <> "€" Then
            If Item(23) = "1" Then
                radMamaSim01.Checked = True
            ElseIf Item(23) = "2" Then
                radMamaSim02.Checked = True
            End If
        End If

        'caracteristicas de la mama
        If Item(24) <> "€" Then

            ValorGuardado = Item(24)

            Resultado = ValorGuardado And 1
            If Resultado = 1 Then
                chkboxCar01.Checked = True
            Else
                chkboxCar01.Checked = False
            End If

            Resultado = ValorGuardado And 2
            If Resultado = 2 Then
                chkboxCar02.Checked = True
            Else
                chkboxCar02.Checked = False
            End If

            Resultado = ValorGuardado And 4
            If Resultado = 4 Then
                chkboxCar03.Checked = True
            Else
                chkboxCar03.Checked = False
            End If

            Resultado = ValorGuardado And 8
            If Resultado = 8 Then
                chkboxCar04.Checked = True
            Else
                chkboxCar04.Checked = False
            End If

            Resultado = ValorGuardado And 16
            If Resultado = 16 Then
                chkboxCar05.Checked = True
            Else
                chkboxCar05.Checked = False
            End If

            Resultado = ValorGuardado And 32
            If Resultado = 32 Then
                chkboxCar06.Checked = True
            Else
                chkboxCar06.Checked = False
            End If

            Resultado = ValorGuardado And 64
            If Resultado = 64 Then
                chkboxCar07.Checked = True
            Else
                chkboxCar07.Checked = False
            End If
        End If

        'lesion01 de mama
        If Item(25) <> "€" Then
            ValorGuardado = Item(25)
            cbMama01a.SelectedIndex = ValorGuardado
            ValorGuardado = Item(26)
            cbMama01b.SelectedIndex = ValorGuardado
            ValorGuardado = Item(27)
            cbMama01c.SelectedIndex = ValorGuardado
            ValorGuardado = Item(28)
            cbMama01d.SelectedIndex = ValorGuardado
            ValorGuardado = Item(29)
            cbMama01e.SelectedIndex = ValorGuardado
            ValorGuardado = Item(30)
            cbMama01f.SelectedIndex = ValorGuardado
        End If

        'lesion02 de mama
        If Item(31) <> "€" Then
            ValorGuardado = Item(31)
            cbMama02a.SelectedIndex = ValorGuardado
            ValorGuardado = Item(32)
            cbMama02b.SelectedIndex = ValorGuardado
            ValorGuardado = Item(33)
            cbMama02c.SelectedIndex = ValorGuardado
            ValorGuardado = Item(34)
            cbMama02d.SelectedIndex = ValorGuardado
            ValorGuardado = Item(35)
            cbMama02e.SelectedIndex = ValorGuardado
            ValorGuardado = Item(36)
            cbMama02f.SelectedIndex = ValorGuardado
        End If

        'lesion03 de mama
        If Item(37) <> "€" Then
            ValorGuardado = Item(37)
            cbMama03a.SelectedIndex = ValorGuardado
            ValorGuardado = Item(38)
            cbMama03b.SelectedIndex = ValorGuardado
            ValorGuardado = Item(39)
            cbMama03c.SelectedIndex = ValorGuardado
            ValorGuardado = Item(40)
            cbMama03d.SelectedIndex = ValorGuardado
            ValorGuardado = Item(41)
            cbMama03e.SelectedIndex = ValorGuardado
            ValorGuardado = Item(42)
            cbMama03f.SelectedIndex = ValorGuardado
        End If

        'comentarios adicionales de mama
        If Item(43) <> "€" Then
            txtMama.Text = Item(43)
        End If
    End Sub

    Private Sub ActualizaCardiopulmonar()
        '0000000000000000000
        'cardiopulmonar

        'Ritmo cardiaco
        If Item(52) <> "€" Then
            ValorGuardado = Item(52)
            cbCorazonRitmo.SelectedIndex = ValorGuardado
        End If

        'intensidad de ruidos cardiacos (53)
        If Item(53) <> "€" Then
            ValorGuardado = Item(53)
            cbCorazonIntensidad.SelectedIndex = ValorGuardado
        End If

        'Soplos tipo y si hay donde (54 y 55)
        If Item(54) <> "€" Then
            ValorGuardado = Item(54)
            cbSoploTipo.SelectedIndex = ValorGuardado
            If ValorGuardado <> 0 Then
                'hay soplo, busca a ver si se dijo donde
                If Item(55) <> "€" Then
                    'se selecciono donde prende la vaina
                    Label29.Visible = True
                    cbSoploArea.Visible = True
                    ValorGuardado = Item(55)
                    cbSoploArea.SelectedIndex = ValorGuardado
                End If
            Else
                'se selecciono que no hay soplos apaga el area
                Label29.Visible = False
                cbSoploArea.Visible = False
            End If
        Else
            'no se selecciono nada apaga la area del soplo
            Label29.Visible = False
            cbSoploArea.Visible = False
        End If

        'Murmullo vesicular
        If Item(60) <> "€" Then
            ValorGuardado = Item(60)
            cbMurmullo.SelectedIndex = ValorGuardado
        End If

        'murmullo vesicular area
        If Item(61) <> "€" Then
            ValorGuardado = Item(61)
            cbMurmulloArea.SelectedIndex = ValorGuardado
        End If

        'tipo de agregados y si hay donde (62 y 63)
        If Item(62) <> "€" Then
            ValorGuardado = Item(62)
            cbAgregados.SelectedIndex = ValorGuardado
            If ValorGuardado <> 0 Then
                'hay agregados, busca a ver si se dijo donde
                If Item(63) <> "€" Then
                    'se selecciono donde, prende la vaina
                    Label30.Visible = True
                    cbAgregadosArea.Visible = True
                    ValorGuardado = Item(63)
                    cbAgregadosArea.SelectedIndex = ValorGuardado
                End If
            Else
                'se selecciono que no hay agregados apaga el area
                Label30.Visible = False
                cbAgregadosArea.Visible = False
            End If
        Else
            'no se selecciono nada apaga la area de agregados
            Label30.Visible = False
            cbAgregadosArea.Visible = False
        End If

        'comentarios adicionales de cardiopulmonar
        If Item(68) <> "€" Then
            txtCardiopulmonar.Text = Item(68)
        End If

    End Sub

    Private Sub ActualizaAbdomen()

        'Consistencia del abdomen
        If Item(73) <> "€" Then
            ValorGuardado = Item(73)
            cbAbdConsistencia.SelectedIndex = ValorGuardado
        End If

        'conformacion del abdomen
        If Item(74) <> "€" Then
            ValorGuardado = Item(74)
            cbAbdConformacion.SelectedIndex = ValorGuardado
        End If

        'Viceromegalias del abdomen
        If Item(75) <> "€" Then
            ValorGuardado = Item(75)
            cbAbdViceromegalias.SelectedIndex = ValorGuardado
        End If

        'Sensibilidad del abdomen
        If Item(76) <> "€" Then
            ValorGuardado = Item(76)
            cbAbdSensibilidad.SelectedIndex = ValorGuardado
        End If

        'Consistencia del abdomen
        If Item(77) <> "€" Then
            ValorGuardado = Item(77)
            cbAbdRuidos.SelectedIndex = ValorGuardado
        End If

        'TU tipo del abdomen (82 y siguientes)
        If Item(82) <> "€" Then
            ValorGuardado = Item(82)
            cbAbdTUtipo.SelectedIndex = ValorGuardado
            If ValorGuardado <> 0 Then
                'hay algun TU, prende los tres items siguientes
                Label38.Visible = True
                Label40.Visible = True
                Label41.Visible = True
                cbAbdTUconsistencia.Visible = True
                cbAbdTUadherencias.Visible = True
                cbAbdTUsensibilidad.Visible = True
                'ahora verifica si se marco algo y lo pone

                'Tu consistencia
                If Item(83) <> "€" Then
                    ValorGuardado = Item(83)
                    cbAbdTUconsistencia.SelectedIndex = ValorGuardado
                End If

                'Tu adherencias
                If Item(84) <> "€" Then
                    ValorGuardado = Item(84)
                    cbAbdTUadherencias.SelectedIndex = ValorGuardado
                End If

                'Tu sensibilidad
                If Item(85) <> "€" Then
                    ValorGuardado = Item(85)
                    cbAbdTUsensibilidad.SelectedIndex = ValorGuardado
                End If

            Else
                'no hay TU. apaga los tres items siguientes
                Label38.Visible = False
                Label40.Visible = False
                Label41.Visible = False
                cbAbdTUconsistencia.Visible = False
                cbAbdTUadherencias.Visible = False
                cbAbdTUsensibilidad.Visible = False
            End If
        Else
            'no se selecciono TU , apaga los tres items siguientes
            Label38.Visible = False
            Label40.Visible = False
            Label41.Visible = False
            cbAbdTUconsistencia.Visible = False
            cbAbdTUadherencias.Visible = False
            cbAbdTUsensibilidad.Visible = False
        End If

        'comentarios adicionales de Abdomen
        If Item(98) <> "€" Then
            txtAbdomen.Text = Item(98)
        End If

    End Sub

    Private Sub ActualizaGenitalesExt()

        'comentarios y subjetivos de GenitalesExt
        If Item(101) <> "€" Then
            txtGenitalesExt.Text = Item(101)
        End If

    End Sub

    Private Sub ActualizaEspeculo()

        'comentarios y subjetivos de Especulo
        If Item(102) <> "€" Then
            txtEspeculo.Text = Item(102)
        End If

    End Sub

    Private Sub ActualizaColposcopia()

        'comentarios y subjetivos de Colposcopia
        If Item(103) <> "€" Then
            txtColposcopia.Text = Item(103)
        End If

    End Sub

    Private Sub ActualizaTacto()

        'comentarios y subjetivos de Tacto
        If Item(104) <> "€" Then
            txtTacto.Text = Item(104)
        End If

    End Sub

    Private Sub ActualizaMsIs()

        'comentarios y subjetivos de MsIs
        If Item(105) <> "€" Then
            txtMsIs.Text = Item(105)
        End If

    End Sub

    Private Sub ActualizaNeurologico()

        'comentarios y subjetivos de Neurologico
        If Item(106) <> "€" Then
            txtNeurologico.Text = Item(106)
        End If

    End Sub

    Private Sub botGuardarNuevosDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botGuardarNuevosDatos.Click
        'revisa que se hayan introducido los datos correctamente
        RevisaComboBoxs()
        ' codifica todo
        CodificaExamenFisico()
        'traduce para el texto de la ventana
        TraduceExamenFisico()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub RevisaComboBoxs()
        'combos de la lesion 1 de mama
        If Item(25) = "€" Or Item(26) = "€" Or Item(27) = "€" Or Item(28) = "€" Or Item(29) = "€" Or Item(30) = "€" Then
            Item(25) = "€"
            Item(26) = "€"
            Item(27) = "€"
            Item(28) = "€"
            Item(29) = "€"
            Item(30) = "€"
        End If

        'combos de la lesion 2 de mama
        If Item(31) = "€" Or Item(32) = "€" Or Item(33) = "€" Or Item(34) = "€" Or Item(35) = "€" Or Item(36) = "€" Then
            Item(31) = "€"
            Item(32) = "€"
            Item(33) = "€"
            Item(34) = "€"
            Item(35) = "€"
            Item(36) = "€"
        End If

        'combos de la lesion 3 de mama
        If Item(37) = "€" Or Item(38) = "€" Or Item(39) = "€" Or Item(40) = "€" Or Item(41) = "€" Or Item(42) = "€" Then
            Item(37) = "€"
            Item(38) = "€"
            Item(39) = "€"
            Item(40) = "€"
            Item(41) = "€"
            Item(42) = "€"
        End If

        'combos de soplo tipo y area
        If Item(54) = "€" Or Item(54) = "0" Then
            'o no se selecciono o se selecciono que no hay, limpia el area
            Item(55) = "€"
        End If

        'combos de murmullo vesicular
        If Item(60) = "€" Then
            'si no se selecciono un tipo de murmullo, no se puede decir donde esta...
            Item(61) = "€"
        Else
            'se selecciono un tipo de murmullo, revisa si se dio el area
            If Item(61) = "€" Then
                'no se selecciono area, limpia a 60
                Item(60) = "€"
            End If
        End If

        'combos de agregados tipo y area
        If Item(62) = "€" Or Item(62) = "0" Then
            'o no se selecciono o se selecciono que no hay, limpia el area
            Item(63) = "€"
        Else
            'se selecciono un tipo de agregado, revisa si se selecciono
            'un area de agregado
            If Item(63) = "€" Then
                'no se selecciono area limpia al 62
                Item(62) = "€"
            End If
        End If

        'combos de TU abdominal
        If Item(82) = "€" Or Item(82) = "0" Then
            'o no se selecciono o se selecciono que no hay, limpia el area
            Item(83) = "€"
            Item(84) = "€"
            Item(85) = "€"
        End If
    End Sub

    Private Sub CodificaExamenFisico()
        Dim tt As Integer

        Form1.ExamenFisicoCodificado = ""
        For tt = 0 To 299
            Form1.ExamenFisicoCodificado += Item(tt) & "|"
        Next
        Form1.ExamenFisicoCodificado += Item(300)
    End Sub

    Private Sub TraduceExamenFisico()

        ExFi = ""
        Form1.ExamenFisicoTraducido = ""
        'inicializa la bandera de algo escrito en la ventana
        AlgoEnLaVentana = False 'aun no se ha escrito nada

        'inicia la traduccion en orden
        TraduceSignosVitales()
        TraduceCondicionesGenerales()
        TraduceMama()
        TraduceCardioPulmonar()
        TraduceAbdomen()
        TraduceGenitalesExt()
        TraduceEspeculo()
        TraduceColposcopio()
        TraduceTacto()
        TraduceMsIs()
        TraduceNeurologico()

        'escribe ExFi a la variable publica para enviar el correo
        Form1.ExamenFisicoTraducido = ExFi

    End Sub

    Private Sub TraduceSignosVitales()

        '00000000000000000000000000000
        'ficha signos vitales
        If (Item(0) <> "€" And Item(1) <> "€") Or Item(2) <> "€" Or Item(3) <> "€" Or Item(4) <> "€" Or Item(5) <> "€" Then
            'hay aunque sea un cambio en esta ficha
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     SIGNOS VITALES:" & vbCrLf
            'vamos con la TA
            If Item(0) <> "€" And Item(1) <> "€" Then
                ExFi += "Tensión arterial: " & Item(0) & "/" & Item(1) & " mmHg" & vbCrLf
            End If
            'el pulso
            If Item(2) <> "€" Then
                ExFi += "Pulso arterial: " & Item(2) & " pulsaciones x minuto" & vbCrLf
            End If
            'respiracion
            If Item(3) <> "€" Then
                ExFi += "Frecuencia respiratoria: " & Item(3) & " respiraciones x minuto" & vbCrLf
            End If
            'temperatura
            If Item(4) <> "€" Then
                ExFi += "Temperatura: " & Item(4) & " ºC" & vbCrLf
            End If
            'peso
            If Item(5) <> "€" Then
                ExFi += "Peso corporal: " & Item(5) & "." & Item(6) & " Kgs" & vbCrLf
            End If
        End If

    End Sub
    Private Sub TraduceCondicionesGenerales()
        '00000000000000000000000000
        'ficha condiciones generales
        If Item(11) <> "€" Or Item(12) <> "€" Or Item(13) <> "€" Or Item(14) <> "€" Or Item(15) <> "€" Or Item(16) <> "€" Or Item(17) <> "€" Or Item(18) <> "€" Then
            'existe algun dato pone encabezamiento
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     CONDICIONES GENERALES:" & vbCrLf

            AlgoEnElParrafo = False 'todavia no se ha escrito nada en el parrafo

            'CsGs
            If Item(11) <> "€" Then
                'hay algo en csgs
                Texto = cbCsGs.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo de CsGs
                    ExFi += ", " 'pone una coma
                    Texto = Texto.ToLower 'lo pone en minusculas
                End If
                AlgoEnElParrafo = True
                ExFi += Texto
            End If

            'Hidratacion
            If Item(12) <> "€" Then
                'hay algo en hidratacion
                Texto = cbHidratacion.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo de CsGs
                    ExFi += ", " 'pone una coma
                    Texto = Texto.ToLower 'lo pone en minusculas
                End If
                AlgoEnElParrafo = True
                ExFi += Texto
            End If

            'Respiracion
            If Item(13) <> "€" Then
                'hay algo en respiracion
                Texto = cbRespiracion.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo de CsGs
                    ExFi += ", " 'pone una coma
                    Texto = Texto.ToLower 'lo pone en minusculas
                End If
                AlgoEnElParrafo = True
                ExFi += Texto
            End If

            'Tez de la piel
            If Item(14) <> "€" And Item(14) <> "0" Then
                'hay algo en Tez
                Texto = cbTez.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo de CsGs
                    ExFi += ", " 'pone una coma
                    Texto = Texto.ToLower 'lo pone en minusculas
                End If
                AlgoEnElParrafo = True
                ExFi += Texto
            End If

            'Temperatura
            If Item(15) <> "€" Then
                'hay algo en temperatura al tacto
                Texto = cbTemperatura.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo de CsGs
                    ExFi += ", " 'pone una coma
                    Texto = Texto.ToLower 'lo pone en minusculas
                End If
                AlgoEnElParrafo = True
                ExFi += Texto
            End If

            'Tolerancia a la VO
            If Item(16) <> "€" Then
                'hay algo en Tolerancia vo
                Texto = cbViaOral.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo de CsGs
                    ExFi += ", " 'pone una coma
                    Texto = Texto.ToLower 'lo pone en minusculas
                End If
                AlgoEnElParrafo = True
                ExFi += Texto
            End If

            'Diuresis
            If Item(17) <> "€" Then
                'hay algo en respiracion
                Texto = cbDiuresis.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo de CsGs
                    ExFi += ", " 'pone una coma
                    Texto = Texto.ToLower 'lo pone en minusculas
                End If
                AlgoEnElParrafo = True
                ExFi += Texto
            End If

            'Comentarios y subjetivos de las CsGs
            If Item(18) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    ExFi += Item(18)
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    'pone un punto y aparte para los subjetivos
                    ExFi += "." & vbCrLf
                    ExFi += Item(18)
                End If

            End If

            'para finalizar el parrafo pone el punto y brinca linea
            ExFi += "." & vbCrLf
        End If

    End Sub
    Private Sub TraduceMama()
        '000000000000000
        'ficha de mama

        If Item(23) <> "€" Or Item(24) <> "€" Or Item(25) <> "€" Or Item(31) <> "€" Or Item(37) <> "€" Then
            'hay algo escrito en la ficha, lo traduce
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     MAMAS:" & vbCrLf

            AlgoEnElParrafo = False 'todavia no se ha escrito nada en el parrafo

            'Simetria mamaria
            If Item(23) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    If Item(23) = "1" Then
                        ExFi += "Mamas simétricas"
                    ElseIf Item(23) = "2" Then
                        ExFi += "Mamas asimétricas"
                    End If
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    If Item(23) = "1" Then
                        ExFi += ", mamas simétricas"
                    ElseIf Item(23) = "2" Then
                        ExFi += ", mamas asimétricas"
                    End If
                End If
            End If

            'caracteristicas generales de mama
            If Item(24) <> "€" Then
                SumaBinaria = Item(24)
                AlgoEnLaLinea = False
                If AlgoEnElParrafo = False Then
                    ExFi += "Mamas"
                Else
                    ExFi += ","
                End If

                If AlgoEnLaLinea = False Then
                    If SumaBinaria And 1 Then
                        ExFi += " turgentes"
                        AlgoEnLaLinea = True
                    End If
                Else
                    If SumaBinaria And 1 Then
                        ExFi += ", turgentes"
                    End If
                End If

                If AlgoEnLaLinea = False Then
                    If SumaBinaria And 2 Then
                        ExFi += " péndulas"
                        AlgoEnLaLinea = True
                    End If
                Else
                    If SumaBinaria And 2 Then
                        ExFi += ", péndulas"
                    End If
                End If

                If AlgoEnLaLinea = False Then
                    If SumaBinaria And 4 Then
                        ExFi += " hipotróficas"
                        AlgoEnLaLinea = True
                    End If
                Else
                    If SumaBinaria And 4 Then
                        ExFi += ", hipotróficas"
                    End If
                End If

                If AlgoEnLaLinea = False Then
                    If SumaBinaria And 8 Then
                        ExFi += " secretando leche materna"
                        AlgoEnLaLinea = True
                    End If
                Else
                    If SumaBinaria And 8 Then
                        ExFi += ", secretando leche materna"
                    End If
                End If

                If AlgoEnLaLinea = False Then
                    If SumaBinaria And 16 Then
                        ExFi += " con mastalgia"
                        AlgoEnLaLinea = True
                    End If
                Else
                    If SumaBinaria And 16 Then
                        ExFi += ", con mastalgia"
                    End If
                End If

                If AlgoEnLaLinea = False Then
                    If SumaBinaria And 32 Then
                        ExFi += " con mastodinia"
                        AlgoEnLaLinea = True
                    End If
                Else
                    If SumaBinaria And 32 Then
                        ExFi += ", con mastodinia"
                    End If
                End If

                If AlgoEnLaLinea = False Then
                    If SumaBinaria And 64 Then
                        ExFi += " presentando condición fibroquística"
                        AlgoEnLaLinea = True
                    End If
                Else
                    If SumaBinaria And 64 Then
                        ExFi += ", presentando condición fibroquística"
                    End If
                End If

            End If 'end caracteristicas de la mama (15)

            'lesion 01 de mama (25 a 30)
            If Item(25) <> "€" Then
                'hay algo en la lesion01
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo de mama
                    ExFi += "." & vbCrLf 'pone un punto y aparte
                End If
                ExFi += cbMama01c.SelectedItem 'tipo
                ExFi += " en mama "
                ExFi += cbMama01a.SelectedItem 'mama
                ExFi += ", "
                ExFi += cbMama01b.SelectedItem 'cuadrante
                ExFi += ", de "
                ExFi += cbMama01d.SelectedItem 'tamaño
                ExFi += " cm, lesión "
                ExFi += cbMama01e.SelectedItem 'adherencias
                ExFi += ", "
                ExFi += cbMama01f.SelectedItem 'sensibilidad
            End If

            'lesion 02 de mama (31 a 36)
            If Item(31) <> "€" Then
                'hay algo en la lesion02
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo de mama
                    ExFi += "." & vbCrLf 'pone un punto y aparte
                End If
                ExFi += cbMama02c.SelectedItem 'tipo
                ExFi += " en mama "
                ExFi += cbMama02a.SelectedItem 'mama
                ExFi += ", "
                ExFi += cbMama02b.SelectedItem 'cuadrante
                ExFi += ", de "
                ExFi += cbMama02d.SelectedItem 'tamaño
                ExFi += " cm, lesión "
                ExFi += cbMama02e.SelectedItem 'adherencias
                ExFi += ", "
                ExFi += cbMama02f.SelectedItem 'sensibilidad
            End If

            'lesion 03 de mama (37 a 42)
            If Item(37) <> "€" Then
                'hay algo en la lesion03
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo de mama
                    ExFi += "." & vbCrLf 'pone un punto y aparte
                End If
                ExFi += cbMama03c.SelectedItem 'tipo
                ExFi += " en mama "
                ExFi += cbMama03a.SelectedItem 'mama
                ExFi += ", "
                ExFi += cbMama03b.SelectedItem 'cuadrante
                ExFi += ", de "
                ExFi += cbMama03d.SelectedItem 'tamaño
                ExFi += " cm, lesión "
                ExFi += cbMama03e.SelectedItem 'adherencias
                ExFi += ", "
                ExFi += cbMama03f.SelectedItem 'sensibilidad
            End If

            'Comentarios adicionales de mama
            If Item(43) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    ExFi += Item(43)
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    'pone un punto y aparte para los subjetivos
                    ExFi += "." & vbCrLf
                    ExFi += Item(43)

                End If

            End If

            'para finalizar el parrafo pone el punto y brinca linea
            ExFi += "." & vbCrLf

        End If 'end ficha de mama 

    End Sub
    Private Sub TraduceCardioPulmonar()
        '000000000000000
        'ficha cardiopulmonar

        If Item(52) <> "€" Or Item(53) <> "€" Or Item(54) <> "€" Or Item(60) <> "€" Or Item(62) <> "€" Then
            'hay algo escrito en la ficha, lo traduce
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     CARDIOPULMONAR:" & vbCrLf

            AlgoEnElParrafo = False 'todavia no se ha escrito nada en el parrafo


            'CORAZON ritmo (52)
            If Item(52) <> "€" Then
                'se selecciono un tipo de ritmo
                Texto = cbCorazonRitmo.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo
                    ExFi += ", "
                    ExFi += Texto.ToLower
                Else
                    ExFi += Texto
                    AlgoEnElParrafo = True
                End If
            End If

            'CORAZON intensidad (53)
            If Item(53) <> "€" Then
                'se selecciono un tipo de intensidad
                Texto = cbCorazonIntensidad.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo
                    ExFi += ", "
                    ExFi += Texto.ToLower
                Else
                    ExFi += "Ruidos cardíacos " & Texto.ToLower
                    AlgoEnElParrafo = True
                End If
            End If

            'Soplo tipo (54)
            If Item(54) <> "€" Then
                'se selecciono un tipo de soplo o q no hay
                Texto = cbSoploTipo.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo
                    ExFi += ", "
                    ExFi += Texto.ToLower
                Else
                    ExFi += Texto
                    AlgoEnElParrafo = True
                End If
            End If

            'soplo area (55)
            If Item(55) <> "€" Then
                'se selecciono un area de soplo
                Texto = cbSoploArea.SelectedItem
                'si se llego aca debe haber un tipo de soplo
                'escrito antes por esto no se pone coma y no se 
                'pregunta si ya hay algo escrito solo pone
                'un espacio para separar
                ExFi += " "
                ExFi += Texto.ToLower
            End If

            If AlgoEnElParrafo = True Then
                'punto y aparte para escribir la parte pulmonar
                ExFi += "." & vbCrLf
            End If

            '0000000000000000000
            'parte pulmonar
            AlgoEnElParrafo = False

            'murmullo vesicular (60)
            If Item(60) <> "€" Then
                'se selecciono un tipo de murmullo
                Texto = cbMurmullo.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo
                    ExFi += ", murmullo vesicular "
                    ExFi += Texto.ToLower
                Else
                    ExFi += "Murmullo vesicular "
                    ExFi += Texto
                    AlgoEnElParrafo = True
                End If
            End If

            'murmullo area (61)
            If Item(61) <> "€" Then
                'se selecciono un area de murmullo
                Texto = cbMurmulloArea.SelectedItem
                ExFi += " en "
                ExFi += Texto.ToLower
            End If

            'agregado tipo (62)
            If Item(62) <> "€" Then
                'se selecciono un tipo de agregados o q no hay
                If Item(62) = "0" Then
                    'se selecciono que no hay agregados
                    If AlgoEnElParrafo = True Then
                        ExFi += ", "
                        Texto = cbAgregados.SelectedItem
                        ExFi += Texto.ToLower
                    Else
                        'si no se ha escrito nada y se puso solo
                        'que no hay agregados mejor no pone nada
                    End If
                Else
                    'se selecciono algun tipo de agregado
                    'primero ve si se selecciono un area...
                    If Item(63) <> "€" Then
                        'se selecciono un area pone todo
                        If AlgoEnElParrafo = True Then
                            ExFi += ", "
                            Texto = cbAgregados.SelectedItem
                            ExFi += Texto.ToLower
                            Texto = cbAgregadosArea.SelectedItem
                            ExFi += " "
                            ExFi += Texto.ToLower
                        Else
                            Texto = cbAgregados.SelectedItem
                            ExFi += Texto
                            Texto = cbAgregadosArea.SelectedItem
                            ExFi += " "
                            ExFi += Texto.ToLower
                            AlgoEnElParrafo = True
                        End If
                    Else
                        'no se selecciono area no pone nada
                    End If
                End If
            End If

            'Comentarios adicionales Cardiopulmonar
            If Item(68) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    ExFi += Item(68)
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    'pone un punto y aparte para los subjetivos
                    ExFi += "." & vbCrLf
                    ExFi += Item(68)
                End If
            End If

            If AlgoEnElParrafo = True Then
                'para finalizar el parrafo pone el punto y brinca linea
                ExFi += "." & vbCrLf
            End If
        End If 'end ficha cardiopulmonar

    End Sub
    Private Sub TraduceAbdomen()
        If Item(73) <> "€" Or Item(74) <> "€" Or Item(75) <> "€" Or Item(76) <> "€" Or Item(77) <> "€" Or Item(82) <> "€" Then
            'hay algo escrito en la ficha, lo traduce
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     ABDOMEN:" & vbCrLf

            AlgoEnElParrafo = False 'todavia no se ha escrito nada en el parrafo

            'aBDOMEN conformacion (74)
            If Item(74) <> "€" And Item(74) <> "0" Then
                'se selecciono una conformacion
                Texto = cbAbdConformacion.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo
                    ExFi += ", "
                    ExFi += Texto.ToLower
                Else
                    ExFi += "Abdomen "
                    ExFi += Texto
                    AlgoEnElParrafo = True
                End If
            End If

            'aBDOMEN CONSISTENCIA (73)
            If Item(73) <> "€" Then
                'se selecciono una consistencia
                Texto = cbAbdConsistencia.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo
                    ExFi += ", "
                    ExFi += Texto.ToLower
                Else
                    ExFi += "Abdomen "
                    ExFi += Texto
                    AlgoEnElParrafo = True
                End If
            End If

            'aBDOMEN sensibilidad (76)
            If Item(76) <> "€" Then
                'se selecciono una sensibilidad
                Texto = cbAbdSensibilidad.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo
                    ExFi += ", "
                    ExFi += Texto
                Else
                    ExFi += "Abdomen "
                    ExFi += Texto
                    AlgoEnElParrafo = True
                End If
            End If

            'aBDOMEN visceromegalias (75)
            If Item(75) <> "€" Then
                'se selecciono algo
                Texto = cbAbdViceromegalias.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo
                    ExFi += ", "
                    ExFi += Texto.ToLower
                Else
                    ExFi += Texto
                    AlgoEnElParrafo = True
                End If
            End If

            'aBDOMEN ruidos (77)
            If Item(77) <> "€" Then
                'se selecciono un  ruidoHs
                Texto = cbAbdRuidos.SelectedItem
                If AlgoEnElParrafo = True Then
                    'ya se escribio algo en el parrfo
                    ExFi += ", ruidos hidroaéreos "
                    ExFi += Texto
                Else
                    ExFi += "Ruidos hidroaéreos "
                    ExFi += Texto
                    AlgoEnElParrafo = True
                End If
            End If

            If AlgoEnElParrafo = True Then
                'punto y aparte para escribir la parte de los TU abd
                ExFi += "." & vbCrLf
                AlgoEnElParrafo = False
            End If

            'TU aBDOMEN tipo (82)
            If Item(82) <> "€" Then
                'se selecciono algo
                If Item(82) = "0" Then
                    'no hay tumoraciones, lo dice
                    If AlgoEnElParrafo = True Then
                        'ya se escribio algo en el parrfo
                        ExFi += ", no se evidencian tumoraciones abdominales"
                    Else
                        ExFi += "No se evidencian tumoraciones abdominales"

                        AlgoEnElParrafo = True
                    End If
                Else
                    'se selecciono un tipo de tu
                    Texto = cbAbdTUtipo.SelectedItem
                    If AlgoEnElParrafo = True Then
                        'ya se escribio algo en el parrfo
                        ExFi += ", "
                        ExFi += Texto.ToLower
                    Else
                        ExFi += Texto
                        AlgoEnElParrafo = True
                    End If

                    'ahora revisa si se dieron detalles
                    If Item(83) <> "€" Then
                        'se selecciono algo
                        Texto = cbAbdTUconsistencia.SelectedItem
                        ExFi += ", "
                        ExFi += Texto.ToLower
                    End If

                    If Item(85) <> "€" Then
                        'se selecciono algo
                        Texto = cbAbdTUsensibilidad.SelectedItem
                        ExFi += ", "
                        ExFi += Texto.ToLower
                    End If

                    If Item(84) <> "€" Then
                        'se selecciono algo
                        Texto = cbAbdTUadherencias.SelectedItem
                        ExFi += ", "
                        ExFi += Texto.ToLower
                    End If
                End If

            End If

            'Comentarios adicionales Abdomen
            If Item(98) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    ExFi += Item(98)
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    'pone un punto y aparte para los subjetivos
                    ExFi += "." & vbCrLf
                    ExFi += Item(98)
                End If
            End If

            If AlgoEnElParrafo = True Then
                'para finalizar el parrafo pone el punto y brinca linea
                ExFi += "." & vbCrLf
            End If


        End If
    End Sub
    Private Sub TraduceGenitalesExt()
        If Item(101) <> "€" Then
            'hay algo escrito en la ficha, lo traduce
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     GENITALES EXTERNOS:" & vbCrLf

            AlgoEnElParrafo = False 'todavia no se ha escrito nada en el parrafo

            'aqui van las diferentes opciones





            'Comentarios adicionales DE gENITALES EXTERNOS
            If Item(101) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    ExFi += Item(101)
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    'pone un punto y aparte para las notas
                    ExFi += "." & vbCrLf
                    ExFi += Item(101)
                End If
            End If

            If AlgoEnElParrafo = True Then
                'para finalizar el parrafo pone el punto y brinca linea
                ExFi += "." & vbCrLf
            End If

        End If
    End Sub
    Private Sub TraduceEspeculo()
        If Item(102) <> "€" Then
            'hay algo escrito en la ficha, lo traduce
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     ESPECULO:" & vbCrLf

            AlgoEnElParrafo = False 'todavia no se ha escrito nada en el parrafo

            'aqui van las diferentes opciones





            'Comentarios adicionales DE ESPECULO
            If Item(102) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    ExFi += Item(102)
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    'pone un punto y aparte para las notas
                    ExFi += "." & vbCrLf
                    ExFi += Item(102)
                End If
            End If

            If AlgoEnElParrafo = True Then
                'para finalizar el parrafo pone el punto y brinca linea
                ExFi += "." & vbCrLf
            End If

        End If
    End Sub
    Private Sub TraduceColposcopio()
        If Item(103) <> "€" Then
            'hay algo escrito en la ficha, lo traduce
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     COLPOSCOPIO:" & vbCrLf

            AlgoEnElParrafo = False 'todavia no se ha escrito nada en el parrafo

            'aqui van las diferentes opciones





            'Comentarios adicionales DE COLPOSCOPIO
            If Item(103) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    ExFi += Item(103)
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    'pone un punto y aparte para las notas
                    ExFi += "." & vbCrLf
                    ExFi += Item(103)
                End If
            End If

            If AlgoEnElParrafo = True Then
                'para finalizar el parrafo pone el punto y brinca linea
                ExFi += "." & vbCrLf
            End If

        End If
    End Sub
    Private Sub TraduceTacto()
        If Item(104) <> "€" Then
            'hay algo escrito en la ficha, lo traduce
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     TACTO:" & vbCrLf

            AlgoEnElParrafo = False 'todavia no se ha escrito nada en el parrafo

            'aqui van las diferentes opciones





            'Comentarios adicionales DE gENITALES EXTERNOS
            If Item(104) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    ExFi += Item(104)
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    'pone un punto y aparte para las notas
                    ExFi += "." & vbCrLf
                    ExFi += Item(104)
                End If
            End If

            If AlgoEnElParrafo = True Then
                'para finalizar el parrafo pone el punto y brinca linea
                ExFi += "." & vbCrLf
            End If

        End If
    End Sub
    Private Sub TraduceMsIs()
        If Item(105) <> "€" Then
            'hay algo escrito en la ficha, lo traduce
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     MIEMBROS INFERIORES:" & vbCrLf

            AlgoEnElParrafo = False 'todavia no se ha escrito nada en el parrafo

            'aqui van las diferentes opciones





            'Comentarios adicionales DE MIEMBROS INFERIORES
            If Item(105) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    ExFi += Item(105)
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    'pone un punto y aparte para las notas
                    ExFi += "." & vbCrLf
                    ExFi += Item(105)
                End If
            End If

            If AlgoEnElParrafo = True Then
                'para finalizar el parrafo pone el punto y brinca linea
                ExFi += "." & vbCrLf
            End If

        End If
    End Sub
    Private Sub TraduceNeurologico()
        If Item(106) <> "€" Then
            'hay algo escrito en la ficha, lo traduce
            If AlgoEnLaVentana = False Then
                'no se ha escrito nada, solo actualiza la bandera
                AlgoEnLaVentana = True
            Else
                'ya se escribio algo baja una linea para separar
                ExFi += vbCrLf
            End If
            ExFi += "     NEUROLOGICO:" & vbCrLf

            AlgoEnElParrafo = False 'todavia no se ha escrito nada en el parrafo

            'aqui van las diferentes opciones





            'Comentarios adicionales DE NEUROLOGICO
            If Item(106) <> "€" Then
                If AlgoEnElParrafo = False Then
                    'no se ha escrito nada
                    ExFi += Item(106)
                    AlgoEnElParrafo = True 'actualiza la bandera
                Else
                    'ya se escribio algo
                    'pone un punto y aparte para las notas
                    ExFi += "." & vbCrLf
                    ExFi += Item(106)
                End If
            End If

            If AlgoEnElParrafo = True Then
                'para finalizar el parrafo pone el punto y brinca linea
                ExFi += "." & vbCrLf
            End If

        End If
    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        Dim Reply As MsgBoxResult

        If DatosModificados = False Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Reply = MsgBox("Se perderán los últimos datos introducidos, para confirmar presiona Aceptar...", MsgBoxStyle.OKCancel)
            If Reply = MsgBoxResult.OK Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                'se cancelo la salida deja todo igual
            End If
        End If
    End Sub

    '00000000000000000000000000000000000000000
    'eventos de interaccion del usuario

    'primero salgo de las notas adicionales de todas las fichas
    Private Sub NOTASadicionales_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtCsGs.KeyPress, txtMama.KeyPress, _
                txtCardiopulmonar.KeyPress, txtAbdomen.KeyPress, _
                txtGenitalesExt.KeyPress, txtEspeculo.KeyPress, _
                txtColposcopia.KeyPress, txtTacto.KeyPress, _
                txtMsIs.KeyPress, txtNeurologico.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                If DatosModificados = False Then
                    DatosSeModificaron()
                End If
            End If

        End If
    End Sub

    'Tension arterial
    Private Sub tbTAS_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTAS.Scroll
        Valor = tbTAS.Value
        Valor = (Valor \ 5) * 5
        labTAS.Text = Valor
        Item(0) = Valor.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub
    Private Sub tbTAD_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTAD.Scroll
        Valor = tbTAD.Value
        Valor = (Valor \ 5) * 5
        labTAD.Text = Valor
        Item(1) = Valor.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    Private Sub tbPULSO_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPULSO.Scroll
        Valor = tbPULSO.Value
        labPULSO.Text = Valor
        Item(2) = Valor.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    Private Sub tbRESP_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRESP.Scroll
        Valor = tbRESP.Value
        labRESP.Text = Valor
        Item(3) = Valor.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    Private Sub tbTEMP_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTEMP.Scroll
        Valor = tbTEMP.Value
        TEMP = (Valor / 10).ToString
        If TEMP.Length = 2 Then
            TEMP += ",0"
        End If
        labTEMP.Text = TEMP
        Item(4) = TEMP
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    Private Sub tbPESO_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tbKG.Scroll, tbGR.Scroll

        KG = tbKG.Value.ToString
        GR = (tbGR.Value) * 10

        If GR = 0 Then
            GRstring = "000"
        ElseIf GR < 100 Then
            GRstring = "0" & GR.ToString
        Else
            GRstring = GR.ToString
        End If
        PESO = KG & "." & GRstring
        labPeso.Text = PESO
        Item(5) = KG
        Item(6) = GRstring
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'condiciones generales (11)
    Private Sub cbCsGs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCsGs.SelectedIndexChanged
        Item(11) = cbCsGs.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'hidratacion (12)
    Private Sub cbHidratacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHidratacion.SelectedIndexChanged
        Item(12) = cbHidratacion.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'respiracion(13)
    Private Sub cbRespiracion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRespiracion.SelectedIndexChanged
        Item(13) = cbRespiracion.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'Tez de la piel(14)
    Private Sub cbTEZ_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTez.SelectedIndexChanged
        Item(14) = cbTez.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'temperatura(15)
    Private Sub cbTemperatura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTemperatura.SelectedIndexChanged
        Item(15) = cbTemperatura.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'via oral(16)
    Private Sub cbViaOral_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbViaOral.SelectedIndexChanged
        Item(16) = cbViaOral.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'diuresis(17)
    Private Sub cbDiuresis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDiuresis.SelectedIndexChanged
        Item(17) = cbDiuresis.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'subjetivos y notas de CsGs (18)
    Private Sub txtCsGs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCsGs.TextChanged
        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtCsGs.Text <> "" Then
            LargoCadena = txtCsGs.Text.Length
            Cadena = txtCsGs.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                Item(18) = Cadena
            Else
                Item(18) = Cadena
            End If
        Else
            Item(18) = "€"
        End If
    End Sub

    '00000000000000000000
    'MAMA

    'simetria mamaria (23)
    Private Sub radMamaSimetria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radMamaSim01.CheckedChanged, radMamaSim02.CheckedChanged
        If radMamaSim01.Checked = True Then
            Item(23) = "1"
        ElseIf radMamaSim02.Checked = True Then
            Item(23) = "2"
        End If
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'caracteristicas de la mama (24)
    Private Sub chkboxCaracteristicas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles chkboxCar01.CheckedChanged, chkboxCar02.CheckedChanged, _
                chkboxCar03.CheckedChanged, chkboxCar04.CheckedChanged, _
                chkboxCar05.CheckedChanged, chkboxCar06.CheckedChanged, _
                chkboxCar07.CheckedChanged
        SumaBinaria = 0
        If chkboxCar01.Checked = True Then
            SumaBinaria += 1
        End If
        If chkboxCar02.Checked = True Then
            SumaBinaria += 2
        End If
        If chkboxCar03.Checked = True Then
            SumaBinaria += 4
        End If
        If chkboxCar04.Checked = True Then
            SumaBinaria += 8
        End If
        If chkboxCar05.Checked = True Then
            SumaBinaria += 16
        End If
        If chkboxCar06.Checked = True Then
            SumaBinaria += 32
        End If
        If chkboxCar07.Checked = True Then
            SumaBinaria += 64
        End If

        Item(24) = SumaBinaria.ToString

        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'Lesiones Mamarias
    'lesion 01 Cual mama (25)
    Private Sub cbMama01a_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama01a.SelectedIndexChanged
        Item(25) = cbMama01a.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 01 Cual cuadrante (26)
    Private Sub cbMama01b_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama01b.SelectedIndexChanged
        Item(26) = cbMama01b.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 01 tipo de lesion (27)
    Private Sub cbMama01c_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama01c.SelectedIndexChanged
        Item(27) = cbMama01c.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 01 tamaño de la lesion (28)
    Private Sub cbMama01d_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama01d.SelectedIndexChanged
        Item(28) = cbMama01d.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 01 adherencias (29)
    Private Sub cbMama01e_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama01e.SelectedIndexChanged
        Item(29) = cbMama01e.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 01 Sensibilidad (30)
    Private Sub cbMama01f_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama01f.SelectedIndexChanged
        Item(30) = cbMama01f.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    '00000000
    'lesion 02 Cual mama (31)
    Private Sub cbMama02a_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama02a.SelectedIndexChanged
        Item(31) = cbMama02a.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 02 Cual cuadrante (32)
    Private Sub cbMama02b_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama02b.SelectedIndexChanged
        Item(32) = cbMama02b.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 02 tipo de lesion (33)
    Private Sub cbMama02c_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama02c.SelectedIndexChanged
        Item(33) = cbMama02c.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 02 tamaño de la lesion (34)
    Private Sub cbMama02d_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama02d.SelectedIndexChanged
        Item(34) = cbMama02d.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 02 adherencias (35)
    Private Sub cbMama02e_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama02e.SelectedIndexChanged
        Item(35) = cbMama02e.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 02 Sensibilidad (36)
    Private Sub cbMama02f_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama02f.SelectedIndexChanged
        Item(36) = cbMama02f.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    '0000000000000000
    'lesion 03 Cual mama (37)
    Private Sub cbMama03a_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama03a.SelectedIndexChanged
        Item(37) = cbMama03a.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 03 Cual cuadrante (38)
    Private Sub cbMama03b_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama03b.SelectedIndexChanged
        Item(38) = cbMama03b.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 03 tipo de lesion (39)
    Private Sub cbMama03c_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama03c.SelectedIndexChanged
        Item(39) = cbMama03c.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 03 tamaño de la lesion (40)
    Private Sub cbMama03d_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama03d.SelectedIndexChanged
        Item(40) = cbMama03d.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 03 adherencias (41)
    Private Sub cbMama03e_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama03e.SelectedIndexChanged
        Item(41) = cbMama03e.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'lesion 03 Sensibilidad (42)
    Private Sub cbMama03f_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cbMama03f.SelectedIndexChanged
        Item(42) = cbMama03f.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'notas adicionales de mama (43)
    Private Sub txtMama_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMama.TextChanged
        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtMama.Text <> "" Then
            LargoCadena = txtMama.Text.Length
            Cadena = txtMama.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                Item(43) = Cadena
            Else
                Item(43) = Cadena
            End If
        Else
            Item(43) = "€"
        End If
    End Sub

    '0000000000000000000000000000000
    'ficha Cardiopulmonar

    'corazon ritmo cardiaco (52)
    Private Sub cbCorazonRitmo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCorazonRitmo.SelectedIndexChanged
        Item(52) = cbCorazonRitmo.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'intensidad de ruidos cardiacos(53)
    Private Sub cbCorazonIntensidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCorazonIntensidad.SelectedIndexChanged
        Item(53) = cbCorazonIntensidad.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'tipo de soplo(54)
    Private Sub cbSoploTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSoploTipo.SelectedIndexChanged
        Item(54) = cbSoploTipo.SelectedIndex.ToString
        If cbSoploTipo.SelectedIndex = 0 Then
            'se seleccionó "sin soplos" apaga la seleccion del area
            Label29.Visible = False
            cbSoploArea.Visible = False
        Else
            Label29.Visible = True
            cbSoploArea.Visible = True
        End If
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'area del soplo (55)
    Private Sub cbSoploArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSoploArea.SelectedIndexChanged
        Item(55) = cbSoploArea.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    '00000000000000000000000
    'pulmones

    'murmullo vesicular (60)
    Private Sub cbMurmullo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMurmullo.SelectedIndexChanged
        Item(60) = cbMurmullo.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'murmullo vesicular area (61)
    Private Sub cbMurmulloAREA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMurmulloArea.SelectedIndexChanged
        Item(61) = cbMurmulloArea.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'tipo de agregado(62)
    Private Sub cbAgregados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAgregados.SelectedIndexChanged
        Item(62) = cbAgregados.SelectedIndex.ToString
        If cbAgregados.SelectedIndex = 0 Then
            'se seleccionó "sin agregados" apaga la seleccion del area
            Label30.Visible = False
            cbAgregadosArea.Visible = False
        Else
            Label30.Visible = True
            cbAgregadosArea.Visible = True
        End If
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'area de los agregados(63)
    Private Sub cbAgregadosArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAgregadosArea.SelectedIndexChanged
        Item(63) = cbAgregadosArea.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'notas adicionales de Cardiopulmonar (68)
    Private Sub txtCardiopulmonar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCardiopulmonar.TextChanged
        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtCardiopulmonar.Text <> "" Then
            LargoCadena = txtCardiopulmonar.Text.Length
            Cadena = txtCardiopulmonar.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                Item(68) = Cadena
            Else
                Item(68) = Cadena
            End If
        Else
            Item(68) = "€"
        End If
    End Sub


    '0000000000000000000000000
    'Abdomen

    'Consistencia del abdomen (73)
    Private Sub cbAbdConsistencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAbdConsistencia.SelectedIndexChanged
        Item(73) = cbAbdConsistencia.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'Conformacion del abdomen (74)
    Private Sub cbAbdConformacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAbdConformacion.SelectedIndexChanged
        Item(74) = cbAbdConformacion.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'Abdomen viceromegalias (75)
    Private Sub cbAbdViceromegalias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAbdViceromegalias.SelectedIndexChanged
        Item(75) = cbAbdViceromegalias.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'abdomen sensibilidad (76)
    Private Sub cbAbdSensibilidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAbdSensibilidad.SelectedIndexChanged
        Item(76) = cbAbdSensibilidad.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'abdomen ruidos hidroaereos (77)
    Private Sub cbAbdRuidos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAbdRuidos.SelectedIndexChanged
        Item(77) = cbAbdRuidos.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'tu abdominal tipo (82)
    Private Sub cbAbdTUtipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAbdTUtipo.SelectedIndexChanged
        Item(82) = cbAbdTUtipo.SelectedIndex.ToString
        If Item(82) = "0" Then
            Label38.Visible = False
            Label40.Visible = False
            Label41.Visible = False
            cbAbdTUconsistencia.Visible = False
            cbAbdTUadherencias.Visible = False
            cbAbdTUsensibilidad.Visible = False
        Else
            Label38.Visible = True
            Label40.Visible = True
            Label41.Visible = True
            cbAbdTUconsistencia.Visible = True
            cbAbdTUadherencias.Visible = True
            cbAbdTUsensibilidad.Visible = True
        End If
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'tu consistencia (83)
    Private Sub cbAbdTUconsistencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAbdTUconsistencia.SelectedIndexChanged
        Item(83) = cbAbdTUconsistencia.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'tu adherencias (84)
    Private Sub cbAbdTUadherencias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAbdTUadherencias.SelectedIndexChanged
        Item(84) = cbAbdTUadherencias.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'tu sensibilidad
    Private Sub cbAbdTUsensibilidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAbdTUsensibilidad.SelectedIndexChanged
        Item(85) = cbAbdTUsensibilidad.SelectedIndex.ToString
        If DatosModificados = False Then
            DatosSeModificaron()
        End If
    End Sub

    'notas adicionales de Abdomen (98)
    Private Sub txtAbdomen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbdomen.TextChanged
        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtAbdomen.Text <> "" Then
            LargoCadena = txtAbdomen.Text.Length
            Cadena = txtAbdomen.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                Item(98) = Cadena
            Else
                Item(98) = Cadena
            End If
        Else
            Item(98) = "€"
        End If
    End Sub


    Private Sub txtGenitalesExt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGenitalesExt.TextChanged
        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtGenitalesExt.Text <> "" Then
            LargoCadena = txtGenitalesExt.Text.Length
            Cadena = txtGenitalesExt.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                Item(101) = Cadena
            Else
                Item(101) = Cadena
            End If
        Else
            Item(101) = "€"
        End If
    End Sub

    Private Sub txtEspeculo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEspeculo.TextChanged
        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtEspeculo.Text <> "" Then
            LargoCadena = txtEspeculo.Text.Length
            Cadena = txtEspeculo.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                Item(102) = Cadena
            Else
                Item(102) = Cadena
            End If
        Else
            Item(102) = "€"
        End If
    End Sub

    Private Sub txtColposcopia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColposcopia.TextChanged
        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtColposcopia.Text <> "" Then
            LargoCadena = txtColposcopia.Text.Length
            Cadena = txtColposcopia.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                Item(103) = Cadena
            Else
                Item(103) = Cadena
            End If
        Else
            Item(103) = "€"
        End If
    End Sub

    Private Sub txtTacto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTacto.TextChanged
        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtTacto.Text <> "" Then
            LargoCadena = txtTacto.Text.Length
            Cadena = txtTacto.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                Item(104) = Cadena
            Else
                Item(104) = Cadena
            End If
        Else
            Item(104) = "€"
        End If
    End Sub

    Private Sub txtMsIs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMsIs.TextChanged
        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtMsIs.Text <> "" Then
            LargoCadena = txtMsIs.Text.Length
            Cadena = txtMsIs.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                Item(105) = Cadena
            Else
                Item(105) = Cadena
            End If
        Else
            Item(105) = "€"
        End If
    End Sub

    Private Sub txtNeurologico_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNeurologico.TextChanged
        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtNeurologico.Text <> "" Then
            LargoCadena = txtNeurologico.Text.Length
            Cadena = txtNeurologico.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                Item(106) = Cadena
            Else
                Item(106) = Cadena
            End If
        Else
            Item(106) = "€"
        End If
    End Sub
End Class
