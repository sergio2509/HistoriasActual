Imports System.IO

Public Class FormRecipes
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
    Friend WithEvents txtBuscaMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents LabNombreBaseDatos As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BotAbreBaseDatos As System.Windows.Forms.Button
    Friend WithEvents ListBoxSalida As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton13 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton14 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton15 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton16 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton17 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton18 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents botVistaPrevia As System.Windows.Forms.Button
    Friend WithEvents labMensaje As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RadioButton19 As System.Windows.Forms.RadioButton
    Friend WithEvents botSuma01 As System.Windows.Forms.Button
    Friend WithEvents botResta01 As System.Windows.Forms.Button
    Friend WithEvents labRecipe01 As System.Windows.Forms.Label
    Friend WithEvents labRecipe02 As System.Windows.Forms.Label
    Friend WithEvents labRecipe03 As System.Windows.Forms.Label
    Friend WithEvents labRecipe04 As System.Windows.Forms.Label
    Friend WithEvents botSuma02 As System.Windows.Forms.Button
    Friend WithEvents botSuma03 As System.Windows.Forms.Button
    Friend WithEvents botSuma04 As System.Windows.Forms.Button
    Friend WithEvents botResta02 As System.Windows.Forms.Button
    Friend WithEvents botResta03 As System.Windows.Forms.Button
    Friend WithEvents botResta04 As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageRecipes As System.Windows.Forms.TabPage
    Friend WithEvents TabPageConstancias As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents botImpConstAsist As System.Windows.Forms.Button
    Friend WithEvents txtNombre01 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes01 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño01 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI01 As System.Windows.Forms.TextBox
    Friend WithEvents txtDia01 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNombre02 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes02 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAño02 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI02 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDia02 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtIDx01 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtDiasReposo As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtMesInicio01 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAñoInicio01 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtDiaInicio01 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents botImpConstReposo As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents botImpReposoPre As System.Windows.Forms.Button
    Friend WithEvents txtMesInicio02 As System.Windows.Forms.TextBox
    Friend WithEvents txtAñoInicio02 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaInicio02 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre03 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes03 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño03 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI03 As System.Windows.Forms.TextBox
    Friend WithEvents txtDia03 As System.Windows.Forms.TextBox
    Friend WithEvents txtMesFUR As System.Windows.Forms.TextBox
    Friend WithEvents txtAñoFUR As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaFUR As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtCiudad02 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtMesInicio03 As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtAñoInicio03 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtDiaInicio03 As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtNombre04 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes04 As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtAño04 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI04 As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtDia04 As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents radCesarea As System.Windows.Forms.RadioButton
    Friend WithEvents radParto As System.Windows.Forms.RadioButton
    Friend WithEvents botImpReposoPost As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TabIndicaciones As System.Windows.Forms.TabPage
    Friend WithEvents TabLaboratorio As System.Windows.Forms.TabPage
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents labLaboratorioPrenatal As System.Windows.Forms.Label
    Friend WithEvents labLaboratorioPrenatal2 As System.Windows.Forms.Label
    Friend WithEvents botLabPrenatal As System.Windows.Forms.Button
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents botCalculaInicioReposo As System.Windows.Forms.Button
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents botImpInformeCesarea As System.Windows.Forms.Button
    Friend WithEvents txtNombre05 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes05 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño05 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI05 As System.Windows.Forms.TextBox
    Friend WithEvents txtDia05 As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctor01 As System.Windows.Forms.TextBox
    Friend WithEvents txtDrCI01 As System.Windows.Forms.TextBox
    Friend WithEvents txtSemanas01 As System.Windows.Forms.TextBox
    Friend WithEvents txtDx01a As System.Windows.Forms.TextBox
    Friend WithEvents txtDx01b As System.Windows.Forms.TextBox
    Friend WithEvents txtDx01c As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents txtDx02c As System.Windows.Forms.TextBox
    Friend WithEvents txtDx02b As System.Windows.Forms.TextBox
    Friend WithEvents txtDx02a As System.Windows.Forms.TextBox
    Friend WithEvents txtSemanas02 As System.Windows.Forms.TextBox
    Friend WithEvents txtDrCI02 As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctor02 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre06 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes06 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño06 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI06 As System.Windows.Forms.TextBox
    Friend WithEvents txtDia06 As System.Windows.Forms.TextBox
    Friend WithEvents botImpInformeParto As System.Windows.Forms.Button
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents Label133 As System.Windows.Forms.Label
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents Label135 As System.Windows.Forms.Label
    Friend WithEvents Label136 As System.Windows.Forms.Label
    Friend WithEvents Label137 As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents Label140 As System.Windows.Forms.Label
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents Label142 As System.Windows.Forms.Label
    Friend WithEvents Label143 As System.Windows.Forms.Label
    Friend WithEvents Label144 As System.Windows.Forms.Label
    Friend WithEvents Label145 As System.Windows.Forms.Label
    Friend WithEvents Label146 As System.Windows.Forms.Label
    Friend WithEvents Label147 As System.Windows.Forms.Label
    Friend WithEvents Label148 As System.Windows.Forms.Label
    Friend WithEvents Label149 As System.Windows.Forms.Label
    Friend WithEvents Label150 As System.Windows.Forms.Label
    Friend WithEvents Label151 As System.Windows.Forms.Label
    Friend WithEvents Label152 As System.Windows.Forms.Label
    Friend WithEvents Label153 As System.Windows.Forms.Label
    Friend WithEvents Label154 As System.Windows.Forms.Label
    Friend WithEvents Label155 As System.Windows.Forms.Label
    Friend WithEvents Label156 As System.Windows.Forms.Label
    Friend WithEvents txtSemanas07 As System.Windows.Forms.TextBox
    Friend WithEvents txtParidad07 As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad07 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre07 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes07 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño07 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI07 As System.Windows.Forms.TextBox
    Friend WithEvents txtDia07 As System.Windows.Forms.TextBox
    Friend WithEvents txtSemanas08 As System.Windows.Forms.TextBox
    Friend WithEvents txtParidad08 As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad08 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre08 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes08 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño08 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI08 As System.Windows.Forms.TextBox
    Friend WithEvents txtDia08 As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraProp10 As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaProp10 As System.Windows.Forms.TextBox
    Friend WithEvents txtOp10 As System.Windows.Forms.TextBox
    Friend WithEvents txtSemanas10 As System.Windows.Forms.TextBox
    Friend WithEvents txtParidad10 As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad10 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre10 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes10 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño10 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI10 As System.Windows.Forms.TextBox
    Friend WithEvents txtDia10 As System.Windows.Forms.TextBox
    Friend WithEvents txtOp09 As System.Windows.Forms.TextBox
    Friend WithEvents txtIdx09c As System.Windows.Forms.TextBox
    Friend WithEvents txtIdx09b As System.Windows.Forms.TextBox
    Friend WithEvents txtIdx09a As System.Windows.Forms.TextBox
    Friend WithEvents txtSemanas09 As System.Windows.Forms.TextBox
    Friend WithEvents txtParidad09 As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad09 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre09 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes09 As System.Windows.Forms.TextBox
    Friend WithEvents txtAño09 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI09 As System.Windows.Forms.TextBox
    Friend WithEvents txtDia09 As System.Windows.Forms.TextBox
    Friend WithEvents botTripleta As System.Windows.Forms.Button
    Friend WithEvents botEcoPerinatal As System.Windows.Forms.Button
    Friend WithEvents botPreoperatorio As System.Windows.Forms.Button
    Friend WithEvents radIndPrenatal As System.Windows.Forms.RadioButton
    Friend WithEvents botImprimeIndicaciones As System.Windows.Forms.Button
    Friend WithEvents radIndCandidiasisNE As System.Windows.Forms.RadioButton
    Friend WithEvents radINDCandidiasisE As System.Windows.Forms.RadioButton
    Friend WithEvents Label138 As System.Windows.Forms.Label
    Friend WithEvents Label157 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radIndVaginosisNEeco As System.Windows.Forms.RadioButton
    Friend WithEvents radINDvaginosisNEok As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label158 As System.Windows.Forms.Label
    Friend WithEvents Label159 As System.Windows.Forms.Label
    Friend WithEvents Label160 As System.Windows.Forms.Label
    Friend WithEvents Label164 As System.Windows.Forms.Label
    Friend WithEvents txtDx11c As System.Windows.Forms.TextBox
    Friend WithEvents txtDx11b As System.Windows.Forms.TextBox
    Friend WithEvents txtDx11a As System.Windows.Forms.TextBox
    Friend WithEvents Label168 As System.Windows.Forms.Label
    Friend WithEvents txtDrCI11 As System.Windows.Forms.TextBox
    Friend WithEvents Label169 As System.Windows.Forms.Label
    Friend WithEvents txtDoctor11 As System.Windows.Forms.TextBox
    Friend WithEvents Label170 As System.Windows.Forms.Label
    Friend WithEvents Label171 As System.Windows.Forms.Label
    Friend WithEvents Label172 As System.Windows.Forms.Label
    Friend WithEvents txtNombre11 As System.Windows.Forms.TextBox
    Friend WithEvents txtMes11 As System.Windows.Forms.TextBox
    Friend WithEvents Label173 As System.Windows.Forms.Label
    Friend WithEvents txtAño11 As System.Windows.Forms.TextBox
    Friend WithEvents txtCI11 As System.Windows.Forms.TextBox
    Friend WithEvents Label174 As System.Windows.Forms.Label
    Friend WithEvents txtDia11 As System.Windows.Forms.TextBox
    Friend WithEvents Label175 As System.Windows.Forms.Label
    Friend WithEvents Label176 As System.Windows.Forms.Label
    Friend WithEvents botImpInformeConsulta As System.Windows.Forms.Button
    Friend WithEvents txtFUR08 As System.Windows.Forms.TextBox
    Friend WithEvents Label177 As System.Windows.Forms.Label
    Friend WithEvents txtExa11 As System.Windows.Forms.TextBox
    Friend WithEvents Label161 As System.Windows.Forms.Label
    Friend WithEvents txtTto11 As System.Windows.Forms.TextBox
    Friend WithEvents txtExcesoReposo04 As System.Windows.Forms.TextBox
    Friend WithEvents txtFUR04 As System.Windows.Forms.TextBox
    Friend WithEvents txtEG04 As System.Windows.Forms.TextBox
    Friend WithEvents Label163 As System.Windows.Forms.Label
    Friend WithEvents Label162 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label165 As System.Windows.Forms.Label
    Friend WithEvents radINDvaginosisMixtaNE As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecipes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscaMedicamento = New System.Windows.Forms.TextBox()
        Me.LabNombreBaseDatos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BotAbreBaseDatos = New System.Windows.Forms.Button()
        Me.ListBoxSalida = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labMensaje = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.botSuma01 = New System.Windows.Forms.Button()
        Me.botResta01 = New System.Windows.Forms.Button()
        Me.botVistaPrevia = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.labRecipe01 = New System.Windows.Forms.Label()
        Me.labRecipe02 = New System.Windows.Forms.Label()
        Me.labRecipe03 = New System.Windows.Forms.Label()
        Me.labRecipe04 = New System.Windows.Forms.Label()
        Me.botSuma02 = New System.Windows.Forms.Button()
        Me.botSuma03 = New System.Windows.Forms.Button()
        Me.botSuma04 = New System.Windows.Forms.Button()
        Me.botResta02 = New System.Windows.Forms.Button()
        Me.botResta03 = New System.Windows.Forms.Button()
        Me.botResta04 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageRecipes = New System.Windows.Forms.TabPage()
        Me.TabPageConstancias = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.botImpConstAsist = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre01 = New System.Windows.Forms.TextBox()
        Me.txtMes01 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAño01 = New System.Windows.Forms.TextBox()
        Me.txtCI01 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDia01 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.botImpConstReposo = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtMesInicio01 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtAñoInicio01 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtDiaInicio01 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDiasReposo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtIDx01 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombre02 = New System.Windows.Forms.TextBox()
        Me.txtMes02 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAño02 = New System.Windows.Forms.TextBox()
        Me.txtCI02 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDia02 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.botCalculaInicioReposo = New System.Windows.Forms.Button()
        Me.botImpReposoPre = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtMesFUR = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtAñoFUR = New System.Windows.Forms.TextBox()
        Me.txtDiaFUR = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtMesInicio02 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtAñoInicio02 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtDiaInicio02 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtNombre03 = New System.Windows.Forms.TextBox()
        Me.txtMes03 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtAño03 = New System.Windows.Forms.TextBox()
        Me.txtCI03 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtDia03 = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.botImpReposoPost = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label165 = New System.Windows.Forms.Label()
        Me.txtExcesoReposo04 = New System.Windows.Forms.TextBox()
        Me.txtFUR04 = New System.Windows.Forms.TextBox()
        Me.txtEG04 = New System.Windows.Forms.TextBox()
        Me.Label163 = New System.Windows.Forms.Label()
        Me.Label162 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.radParto = New System.Windows.Forms.RadioButton()
        Me.radCesarea = New System.Windows.Forms.RadioButton()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtCiudad02 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtMesInicio03 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtAñoInicio03 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtDiaInicio03 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtNombre04 = New System.Windows.Forms.TextBox()
        Me.txtMes04 = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtAño04 = New System.Windows.Forms.TextBox()
        Me.txtCI04 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtDia04 = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.botImpInformeCesarea = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtDx01c = New System.Windows.Forms.TextBox()
        Me.txtDx01b = New System.Windows.Forms.TextBox()
        Me.txtDx01a = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txtSemanas01 = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.txtDrCI01 = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txtDoctor01 = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtNombre05 = New System.Windows.Forms.TextBox()
        Me.txtMes05 = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtAño05 = New System.Windows.Forms.TextBox()
        Me.txtCI05 = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.txtDia05 = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.botImpInformeParto = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.txtDx02c = New System.Windows.Forms.TextBox()
        Me.txtDx02b = New System.Windows.Forms.TextBox()
        Me.txtDx02a = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.txtSemanas02 = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.txtDrCI02 = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.txtDoctor02 = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.txtNombre06 = New System.Windows.Forms.TextBox()
        Me.txtMes06 = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.txtAño06 = New System.Windows.Forms.TextBox()
        Me.txtCI06 = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.txtDia06 = New System.Windows.Forms.TextBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.botImpInformeConsulta = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtExa11 = New System.Windows.Forms.TextBox()
        Me.Label161 = New System.Windows.Forms.Label()
        Me.txtTto11 = New System.Windows.Forms.TextBox()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.Label159 = New System.Windows.Forms.Label()
        Me.Label160 = New System.Windows.Forms.Label()
        Me.Label164 = New System.Windows.Forms.Label()
        Me.txtDx11c = New System.Windows.Forms.TextBox()
        Me.txtDx11b = New System.Windows.Forms.TextBox()
        Me.txtDx11a = New System.Windows.Forms.TextBox()
        Me.Label168 = New System.Windows.Forms.Label()
        Me.txtDrCI11 = New System.Windows.Forms.TextBox()
        Me.Label169 = New System.Windows.Forms.Label()
        Me.txtDoctor11 = New System.Windows.Forms.TextBox()
        Me.Label170 = New System.Windows.Forms.Label()
        Me.Label171 = New System.Windows.Forms.Label()
        Me.Label172 = New System.Windows.Forms.Label()
        Me.txtNombre11 = New System.Windows.Forms.TextBox()
        Me.txtMes11 = New System.Windows.Forms.TextBox()
        Me.Label173 = New System.Windows.Forms.Label()
        Me.txtAño11 = New System.Windows.Forms.TextBox()
        Me.txtCI11 = New System.Windows.Forms.TextBox()
        Me.Label174 = New System.Windows.Forms.Label()
        Me.txtDia11 = New System.Windows.Forms.TextBox()
        Me.Label175 = New System.Windows.Forms.Label()
        Me.Label176 = New System.Windows.Forms.Label()
        Me.TabIndicaciones = New System.Windows.Forms.TabPage()
        Me.radINDvaginosisMixtaNE = New System.Windows.Forms.RadioButton()
        Me.radINDvaginosisNEok = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label157 = New System.Windows.Forms.Label()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.botImprimeIndicaciones = New System.Windows.Forms.Button()
        Me.radIndVaginosisNEeco = New System.Windows.Forms.RadioButton()
        Me.radIndCandidiasisNE = New System.Windows.Forms.RadioButton()
        Me.radIndPrenatal = New System.Windows.Forms.RadioButton()
        Me.radINDCandidiasisE = New System.Windows.Forms.RadioButton()
        Me.TabLaboratorio = New System.Windows.Forms.TabPage()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.labLaboratorioPrenatal2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.labLaboratorioPrenatal = New System.Windows.Forms.Label()
        Me.botLabPrenatal = New System.Windows.Forms.Button()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.botTripleta = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.txtSemanas07 = New System.Windows.Forms.TextBox()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.txtParidad07 = New System.Windows.Forms.TextBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.txtEdad07 = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.txtNombre07 = New System.Windows.Forms.TextBox()
        Me.txtMes07 = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.txtAño07 = New System.Windows.Forms.TextBox()
        Me.txtCI07 = New System.Windows.Forms.TextBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.txtDia07 = New System.Windows.Forms.TextBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.botEcoPerinatal = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.txtFUR08 = New System.Windows.Forms.TextBox()
        Me.Label177 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.txtSemanas08 = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.txtParidad08 = New System.Windows.Forms.TextBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.txtEdad08 = New System.Windows.Forms.TextBox()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.txtNombre08 = New System.Windows.Forms.TextBox()
        Me.txtMes08 = New System.Windows.Forms.TextBox()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.txtAño08 = New System.Windows.Forms.TextBox()
        Me.txtCI08 = New System.Windows.Forms.TextBox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.txtDia08 = New System.Windows.Forms.TextBox()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.botPreoperatorio = New System.Windows.Forms.Button()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.txtHoraProp10 = New System.Windows.Forms.TextBox()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.txtFechaProp10 = New System.Windows.Forms.TextBox()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.txtOp10 = New System.Windows.Forms.TextBox()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.Label143 = New System.Windows.Forms.Label()
        Me.txtSemanas10 = New System.Windows.Forms.TextBox()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.txtParidad10 = New System.Windows.Forms.TextBox()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.Label146 = New System.Windows.Forms.Label()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.txtEdad10 = New System.Windows.Forms.TextBox()
        Me.Label148 = New System.Windows.Forms.Label()
        Me.Label149 = New System.Windows.Forms.Label()
        Me.txtNombre10 = New System.Windows.Forms.TextBox()
        Me.txtMes10 = New System.Windows.Forms.TextBox()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.txtAño10 = New System.Windows.Forms.TextBox()
        Me.txtCI10 = New System.Windows.Forms.TextBox()
        Me.Label151 = New System.Windows.Forms.Label()
        Me.Label152 = New System.Windows.Forms.Label()
        Me.txtDia10 = New System.Windows.Forms.TextBox()
        Me.Label153 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.txtOp09 = New System.Windows.Forms.TextBox()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.txtIdx09c = New System.Windows.Forms.TextBox()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.txtIdx09b = New System.Windows.Forms.TextBox()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.txtIdx09a = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.txtSemanas09 = New System.Windows.Forms.TextBox()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.txtParidad09 = New System.Windows.Forms.TextBox()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.txtEdad09 = New System.Windows.Forms.TextBox()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.txtNombre09 = New System.Windows.Forms.TextBox()
        Me.txtMes09 = New System.Windows.Forms.TextBox()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.txtAño09 = New System.Windows.Forms.TextBox()
        Me.txtCI09 = New System.Windows.Forms.TextBox()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.txtDia09 = New System.Windows.Forms.TextBox()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageRecipes.SuspendLayout()
        Me.TabPageConstancias.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabIndicaciones.SuspendLayout()
        Me.TabLaboratorio.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Introduce las primeras letras del fármaco para filtrar la lista"
        '
        'txtBuscaMedicamento
        '
        Me.txtBuscaMedicamento.Location = New System.Drawing.Point(16, 80)
        Me.txtBuscaMedicamento.Name = "txtBuscaMedicamento"
        Me.txtBuscaMedicamento.Size = New System.Drawing.Size(352, 20)
        Me.txtBuscaMedicamento.TabIndex = 4
        '
        'LabNombreBaseDatos
        '
        Me.LabNombreBaseDatos.BackColor = System.Drawing.SystemColors.Control
        Me.LabNombreBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNombreBaseDatos.ForeColor = System.Drawing.Color.White
        Me.LabNombreBaseDatos.Image = CType(resources.GetObject("LabNombreBaseDatos.Image"), System.Drawing.Image)
        Me.LabNombreBaseDatos.Location = New System.Drawing.Point(136, 32)
        Me.LabNombreBaseDatos.Name = "LabNombreBaseDatos"
        Me.LabNombreBaseDatos.Size = New System.Drawing.Size(624, 23)
        Me.LabNombreBaseDatos.TabIndex = 2
        Me.LabNombreBaseDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Base de Datos Actual"
        '
        'BotAbreBaseDatos
        '
        Me.BotAbreBaseDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotAbreBaseDatos.Image = CType(resources.GetObject("BotAbreBaseDatos.Image"), System.Drawing.Image)
        Me.BotAbreBaseDatos.Location = New System.Drawing.Point(16, 4)
        Me.BotAbreBaseDatos.Name = "BotAbreBaseDatos"
        Me.BotAbreBaseDatos.Size = New System.Drawing.Size(224, 23)
        Me.BotAbreBaseDatos.TabIndex = 0
        Me.BotAbreBaseDatos.Text = "Selecciona Base de Datos"
        '
        'ListBoxSalida
        '
        Me.ListBoxSalida.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxSalida.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxSalida.Location = New System.Drawing.Point(16, 104)
        Me.ListBoxSalida.Name = "ListBoxSalida"
        Me.ListBoxSalida.Size = New System.Drawing.Size(352, 160)
        Me.ListBoxSalida.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton19)
        Me.Panel1.Controls.Add(Me.RadioButton14)
        Me.Panel1.Controls.Add(Me.RadioButton18)
        Me.Panel1.Controls.Add(Me.RadioButton17)
        Me.Panel1.Controls.Add(Me.RadioButton16)
        Me.Panel1.Controls.Add(Me.RadioButton15)
        Me.Panel1.Controls.Add(Me.RadioButton13)
        Me.Panel1.Controls.Add(Me.RadioButton12)
        Me.Panel1.Controls.Add(Me.RadioButton11)
        Me.Panel1.Controls.Add(Me.RadioButton10)
        Me.Panel1.Controls.Add(Me.RadioButton9)
        Me.Panel1.Controls.Add(Me.RadioButton8)
        Me.Panel1.Controls.Add(Me.RadioButton7)
        Me.Panel1.Controls.Add(Me.RadioButton6)
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(376, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 208)
        Me.Panel1.TabIndex = 22
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(8, 64)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(136, 24)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Antialérgicos"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(8, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(136, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Afecciones Vaginales"
        '
        'RadioButton19
        '
        Me.RadioButton19.Location = New System.Drawing.Point(208, 184)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton19.TabIndex = 18
        Me.RadioButton19.Text = "Muestra Todos"
        '
        'RadioButton14
        '
        Me.RadioButton14.Location = New System.Drawing.Point(208, 84)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton14.TabIndex = 13
        Me.RadioButton14.Text = "Hipotensores"
        '
        'RadioButton18
        '
        Me.RadioButton18.Location = New System.Drawing.Point(208, 144)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton18.TabIndex = 17
        Me.RadioButton18.Text = "Otros - Varios"
        '
        'RadioButton17
        '
        Me.RadioButton17.Location = New System.Drawing.Point(208, 124)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(160, 24)
        Me.RadioButton17.TabIndex = 16
        Me.RadioButton17.Text = "Vitaminas Oligoelementos"
        '
        'RadioButton16
        '
        Me.RadioButton16.Location = New System.Drawing.Point(208, 104)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(184, 24)
        Me.RadioButton16.TabIndex = 15
        Me.RadioButton16.Text = "Uterotónicos y Uteroinhibidores"
        '
        'RadioButton15
        '
        Me.RadioButton15.Location = New System.Drawing.Point(208, 64)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton15.TabIndex = 14
        Me.RadioButton15.Text = "Hormonas"
        '
        'RadioButton13
        '
        Me.RadioButton13.Location = New System.Drawing.Point(208, 44)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton13.TabIndex = 12
        Me.RadioButton13.Text = "Hemostáticos"
        '
        'RadioButton12
        '
        Me.RadioButton12.Location = New System.Drawing.Point(208, 24)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton12.TabIndex = 11
        Me.RadioButton12.Text = "Antitrombóticos"
        '
        'RadioButton11
        '
        Me.RadioButton11.Location = New System.Drawing.Point(208, 4)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(168, 24)
        Me.RadioButton11.TabIndex = 10
        Me.RadioButton11.Text = "Antisép y Analg V. Urinarias"
        '
        'RadioButton10
        '
        Me.RadioButton10.Location = New System.Drawing.Point(8, 184)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton10.TabIndex = 9
        Me.RadioButton10.Text = "Antiparasitarios"
        '
        'RadioButton9
        '
        Me.RadioButton9.Location = New System.Drawing.Point(8, 144)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton9.TabIndex = 8
        Me.RadioButton9.Text = "Antieméticos"
        '
        'RadioButton8
        '
        Me.RadioButton8.Location = New System.Drawing.Point(8, 124)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton8.TabIndex = 7
        Me.RadioButton8.Text = "Antibióticos"
        '
        'RadioButton7
        '
        Me.RadioButton7.Location = New System.Drawing.Point(8, 164)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Text = "Antimicóticos"
        '
        'RadioButton6
        '
        Me.RadioButton6.Location = New System.Drawing.Point(8, 104)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "Antianémicos"
        '
        'RadioButton5
        '
        Me.RadioButton5.Location = New System.Drawing.Point(8, 84)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(144, 24)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "Antiácidos Antiflatulento"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(8, 44)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(184, 24)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Analg. Antipirét. Antiespasm."
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(8, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(136, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Afecciones Cutáneas"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(376, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Filtra la lista según el tipo de fármaco"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labMensaje
        '
        Me.labMensaje.BackColor = System.Drawing.SystemColors.Control
        Me.labMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labMensaje.Image = CType(resources.GetObject("labMensaje.Image"), System.Drawing.Image)
        Me.labMensaje.Location = New System.Drawing.Point(16, 448)
        Me.labMensaje.Name = "labMensaje"
        Me.labMensaje.Size = New System.Drawing.Size(744, 23)
        Me.labMensaje.TabIndex = 23
        Me.labMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(424, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fármacos actualmente en el Récipe (Máximo 4 x récipe)"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtDescripcion.Location = New System.Drawing.Point(16, 272)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(352, 168)
        Me.txtDescripcion.TabIndex = 20
        '
        'botSuma01
        '
        Me.botSuma01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSuma01.Image = CType(resources.GetObject("botSuma01.Image"), System.Drawing.Image)
        Me.botSuma01.Location = New System.Drawing.Point(400, 80)
        Me.botSuma01.Name = "botSuma01"
        Me.botSuma01.Size = New System.Drawing.Size(24, 24)
        Me.botSuma01.TabIndex = 8
        '
        'botResta01
        '
        Me.botResta01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botResta01.Image = CType(resources.GetObject("botResta01.Image"), System.Drawing.Image)
        Me.botResta01.Location = New System.Drawing.Point(376, 80)
        Me.botResta01.Name = "botResta01"
        Me.botResta01.Size = New System.Drawing.Size(24, 24)
        Me.botResta01.TabIndex = 7
        '
        'botVistaPrevia
        '
        Me.botVistaPrevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botVistaPrevia.Image = CType(resources.GetObject("botVistaPrevia.Image"), System.Drawing.Image)
        Me.botVistaPrevia.Location = New System.Drawing.Point(480, 180)
        Me.botVistaPrevia.Name = "botVistaPrevia"
        Me.botVistaPrevia.Size = New System.Drawing.Size(224, 23)
        Me.botVistaPrevia.TabIndex = 19
        Me.botVistaPrevia.Text = "Previsualización del Récipe"
        '
        'labRecipe01
        '
        Me.labRecipe01.BackColor = System.Drawing.SystemColors.Info
        Me.labRecipe01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRecipe01.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labRecipe01.Location = New System.Drawing.Point(424, 80)
        Me.labRecipe01.Name = "labRecipe01"
        Me.labRecipe01.Size = New System.Drawing.Size(336, 23)
        Me.labRecipe01.TabIndex = 9
        Me.labRecipe01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRecipe02
        '
        Me.labRecipe02.BackColor = System.Drawing.SystemColors.Info
        Me.labRecipe02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRecipe02.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labRecipe02.Location = New System.Drawing.Point(424, 104)
        Me.labRecipe02.Name = "labRecipe02"
        Me.labRecipe02.Size = New System.Drawing.Size(336, 23)
        Me.labRecipe02.TabIndex = 12
        Me.labRecipe02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRecipe03
        '
        Me.labRecipe03.BackColor = System.Drawing.SystemColors.Info
        Me.labRecipe03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRecipe03.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labRecipe03.Location = New System.Drawing.Point(424, 128)
        Me.labRecipe03.Name = "labRecipe03"
        Me.labRecipe03.Size = New System.Drawing.Size(336, 24)
        Me.labRecipe03.TabIndex = 15
        Me.labRecipe03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labRecipe04
        '
        Me.labRecipe04.BackColor = System.Drawing.SystemColors.Info
        Me.labRecipe04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labRecipe04.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labRecipe04.Location = New System.Drawing.Point(424, 152)
        Me.labRecipe04.Name = "labRecipe04"
        Me.labRecipe04.Size = New System.Drawing.Size(336, 23)
        Me.labRecipe04.TabIndex = 18
        Me.labRecipe04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botSuma02
        '
        Me.botSuma02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSuma02.Image = CType(resources.GetObject("botSuma02.Image"), System.Drawing.Image)
        Me.botSuma02.Location = New System.Drawing.Point(400, 104)
        Me.botSuma02.Name = "botSuma02"
        Me.botSuma02.Size = New System.Drawing.Size(24, 24)
        Me.botSuma02.TabIndex = 11
        '
        'botSuma03
        '
        Me.botSuma03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSuma03.Image = CType(resources.GetObject("botSuma03.Image"), System.Drawing.Image)
        Me.botSuma03.Location = New System.Drawing.Point(400, 128)
        Me.botSuma03.Name = "botSuma03"
        Me.botSuma03.Size = New System.Drawing.Size(24, 24)
        Me.botSuma03.TabIndex = 14
        '
        'botSuma04
        '
        Me.botSuma04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSuma04.Image = CType(resources.GetObject("botSuma04.Image"), System.Drawing.Image)
        Me.botSuma04.Location = New System.Drawing.Point(400, 152)
        Me.botSuma04.Name = "botSuma04"
        Me.botSuma04.Size = New System.Drawing.Size(24, 24)
        Me.botSuma04.TabIndex = 17
        '
        'botResta02
        '
        Me.botResta02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botResta02.Image = CType(resources.GetObject("botResta02.Image"), System.Drawing.Image)
        Me.botResta02.Location = New System.Drawing.Point(376, 104)
        Me.botResta02.Name = "botResta02"
        Me.botResta02.Size = New System.Drawing.Size(24, 24)
        Me.botResta02.TabIndex = 10
        '
        'botResta03
        '
        Me.botResta03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botResta03.Image = CType(resources.GetObject("botResta03.Image"), System.Drawing.Image)
        Me.botResta03.Location = New System.Drawing.Point(376, 128)
        Me.botResta03.Name = "botResta03"
        Me.botResta03.Size = New System.Drawing.Size(24, 24)
        Me.botResta03.TabIndex = 13
        '
        'botResta04
        '
        Me.botResta04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botResta04.Image = CType(resources.GetObject("botResta04.Image"), System.Drawing.Image)
        Me.botResta04.Location = New System.Drawing.Point(376, 152)
        Me.botResta04.Name = "botResta04"
        Me.botResta04.Size = New System.Drawing.Size(24, 24)
        Me.botResta04.TabIndex = 16
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageRecipes)
        Me.TabControl1.Controls.Add(Me.TabPageConstancias)
        Me.TabControl1.Controls.Add(Me.TabIndicaciones)
        Me.TabControl1.Controls.Add(Me.TabLaboratorio)
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 504)
        Me.TabControl1.TabIndex = 24
        '
        'TabPageRecipes
        '
        Me.TabPageRecipes.Controls.Add(Me.Label1)
        Me.TabPageRecipes.Controls.Add(Me.txtBuscaMedicamento)
        Me.TabPageRecipes.Controls.Add(Me.ListBoxSalida)
        Me.TabPageRecipes.Controls.Add(Me.txtDescripcion)
        Me.TabPageRecipes.Controls.Add(Me.labMensaje)
        Me.TabPageRecipes.Controls.Add(Me.labRecipe01)
        Me.TabPageRecipes.Controls.Add(Me.botResta01)
        Me.TabPageRecipes.Controls.Add(Me.botResta03)
        Me.TabPageRecipes.Controls.Add(Me.botSuma02)
        Me.TabPageRecipes.Controls.Add(Me.botVistaPrevia)
        Me.TabPageRecipes.Controls.Add(Me.Label3)
        Me.TabPageRecipes.Controls.Add(Me.botResta02)
        Me.TabPageRecipes.Controls.Add(Me.labRecipe04)
        Me.TabPageRecipes.Controls.Add(Me.Label2)
        Me.TabPageRecipes.Controls.Add(Me.botSuma04)
        Me.TabPageRecipes.Controls.Add(Me.botResta04)
        Me.TabPageRecipes.Controls.Add(Me.labRecipe03)
        Me.TabPageRecipes.Controls.Add(Me.botSuma01)
        Me.TabPageRecipes.Controls.Add(Me.botSuma03)
        Me.TabPageRecipes.Controls.Add(Me.labRecipe02)
        Me.TabPageRecipes.Controls.Add(Me.Panel1)
        Me.TabPageRecipes.Controls.Add(Me.BotAbreBaseDatos)
        Me.TabPageRecipes.Controls.Add(Me.Label7)
        Me.TabPageRecipes.Controls.Add(Me.LabNombreBaseDatos)
        Me.TabPageRecipes.Location = New System.Drawing.Point(4, 22)
        Me.TabPageRecipes.Name = "TabPageRecipes"
        Me.TabPageRecipes.Size = New System.Drawing.Size(768, 478)
        Me.TabPageRecipes.TabIndex = 0
        Me.TabPageRecipes.Text = "Récipes"
        '
        'TabPageConstancias
        '
        Me.TabPageConstancias.Controls.Add(Me.TabControl2)
        Me.TabPageConstancias.Location = New System.Drawing.Point(4, 22)
        Me.TabPageConstancias.Name = "TabPageConstancias"
        Me.TabPageConstancias.Size = New System.Drawing.Size(768, 478)
        Me.TabPageConstancias.TabIndex = 1
        Me.TabPageConstancias.Text = "Constancias, Informes y Reposos"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(16, 8)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(744, 408)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.botImpConstAsist)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(736, 382)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Asistencia"
        '
        'botImpConstAsist
        '
        Me.botImpConstAsist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImpConstAsist.Image = CType(resources.GetObject("botImpConstAsist.Image"), System.Drawing.Image)
        Me.botImpConstAsist.Location = New System.Drawing.Point(392, 352)
        Me.botImpConstAsist.Name = "botImpConstAsist"
        Me.botImpConstAsist.Size = New System.Drawing.Size(224, 23)
        Me.botImpConstAsist.TabIndex = 1
        Me.botImpConstAsist.Text = "Prepara la Impresión"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtNombre01)
        Me.Panel2.Controls.Add(Me.txtMes01)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtAño01)
        Me.Panel2.Controls.Add(Me.txtCI01)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtDia01)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(112, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(504, 336)
        Me.Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CONSTANCIA DE ASISTENCIA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre01
        '
        Me.txtNombre01.BackColor = System.Drawing.Color.White
        Me.txtNombre01.Location = New System.Drawing.Point(67, 170)
        Me.txtNombre01.MaxLength = 45
        Me.txtNombre01.Name = "txtNombre01"
        Me.txtNombre01.Size = New System.Drawing.Size(256, 20)
        Me.txtNombre01.TabIndex = 3
        '
        'txtMes01
        '
        Me.txtMes01.BackColor = System.Drawing.Color.White
        Me.txtMes01.Location = New System.Drawing.Point(248, 204)
        Me.txtMes01.MaxLength = 10
        Me.txtMes01.Name = "txtMes01"
        Me.txtMes01.Size = New System.Drawing.Size(88, 20)
        Me.txtMes01.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(336, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 23)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "de"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño01
        '
        Me.txtAño01.BackColor = System.Drawing.Color.White
        Me.txtAño01.Location = New System.Drawing.Point(360, 204)
        Me.txtAño01.MaxLength = 4
        Me.txtAño01.Name = "txtAño01"
        Me.txtAño01.Size = New System.Drawing.Size(80, 20)
        Me.txtAño01.TabIndex = 11
        '
        'txtCI01
        '
        Me.txtCI01.BackColor = System.Drawing.Color.White
        Me.txtCI01.Location = New System.Drawing.Point(360, 170)
        Me.txtCI01.MaxLength = 10
        Me.txtCI01.Name = "txtCI01"
        Me.txtCI01.Size = New System.Drawing.Size(80, 20)
        Me.txtCI01.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(64, 232)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(392, 23)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Constancia que se expide a solicitud de la parte interesada."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(64, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Asistió a consulta hoy "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(320, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = ",  C.I. :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(64, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(392, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Quien suscribe, Médico en ejercicio hace constar por medio de la presente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia01
        '
        Me.txtDia01.BackColor = System.Drawing.Color.White
        Me.txtDia01.Location = New System.Drawing.Point(184, 204)
        Me.txtDia01.MaxLength = 2
        Me.txtDia01.Name = "txtDia01"
        Me.txtDia01.Size = New System.Drawing.Size(32, 20)
        Me.txtDia01.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(64, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(392, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "que la paciente:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(222, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 23)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "de"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.botImpConstReposo)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(736, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reposo Médico"
        '
        'botImpConstReposo
        '
        Me.botImpConstReposo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImpConstReposo.Image = CType(resources.GetObject("botImpConstReposo.Image"), System.Drawing.Image)
        Me.botImpConstReposo.Location = New System.Drawing.Point(392, 352)
        Me.botImpConstReposo.Name = "botImpConstReposo"
        Me.botImpConstReposo.Size = New System.Drawing.Size(224, 23)
        Me.botImpConstReposo.TabIndex = 1
        Me.botImpConstReposo.Text = "Prepara la Impresión"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.txtMesInicio01)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.txtAñoInicio01)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.txtDiaInicio01)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.txtDiasReposo)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.txtIDx01)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtNombre02)
        Me.Panel3.Controls.Add(Me.txtMes02)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.txtAño02)
        Me.Panel3.Controls.Add(Me.txtCI02)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.txtDia02)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Location = New System.Drawing.Point(112, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(504, 336)
        Me.Panel3.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(400, 254)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 23)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "(inclusive)"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMesInicio01
        '
        Me.txtMesInicio01.BackColor = System.Drawing.Color.White
        Me.txtMesInicio01.Location = New System.Drawing.Point(192, 256)
        Me.txtMesInicio01.MaxLength = 10
        Me.txtMesInicio01.Name = "txtMesInicio01"
        Me.txtMesInicio01.Size = New System.Drawing.Size(88, 20)
        Me.txtMesInicio01.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(284, 252)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(24, 23)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "de"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAñoInicio01
        '
        Me.txtAñoInicio01.BackColor = System.Drawing.Color.White
        Me.txtAñoInicio01.Location = New System.Drawing.Point(314, 254)
        Me.txtAñoInicio01.MaxLength = 4
        Me.txtAñoInicio01.Name = "txtAñoInicio01"
        Me.txtAñoInicio01.Size = New System.Drawing.Size(80, 20)
        Me.txtAñoInicio01.TabIndex = 22
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(64, 252)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 23)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "A partir del"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiaInicio01
        '
        Me.txtDiaInicio01.BackColor = System.Drawing.Color.White
        Me.txtDiaInicio01.Location = New System.Drawing.Point(134, 254)
        Me.txtDiaInicio01.MaxLength = 2
        Me.txtDiaInicio01.Name = "txtDiaInicio01"
        Me.txtDiaInicio01.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaInicio01.TabIndex = 18
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(172, 252)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(24, 23)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "de"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(284, 224)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 23)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "días."
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiasReposo
        '
        Me.txtDiasReposo.BackColor = System.Drawing.Color.White
        Me.txtDiasReposo.Location = New System.Drawing.Point(248, 226)
        Me.txtDiasReposo.MaxLength = 2
        Me.txtDiasReposo.Name = "txtDiasReposo"
        Me.txtDiasReposo.Size = New System.Drawing.Size(32, 20)
        Me.txtDiasReposo.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(64, 224)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(184, 23)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Ameritando REPOSO MÉDICO por"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIDx01
        '
        Me.txtIDx01.BackColor = System.Drawing.Color.White
        Me.txtIDx01.Location = New System.Drawing.Point(64, 200)
        Me.txtIDx01.MaxLength = 100
        Me.txtIDx01.Name = "txtIDx01"
        Me.txtIDx01.Size = New System.Drawing.Size(376, 20)
        Me.txtIDx01.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(64, 172)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(392, 23)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Presentando impresión diagnóstica de:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(132, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(220, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "REPOSO  MEDICO"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre02
        '
        Me.txtNombre02.BackColor = System.Drawing.Color.White
        Me.txtNombre02.Location = New System.Drawing.Point(64, 118)
        Me.txtNombre02.MaxLength = 45
        Me.txtNombre02.Name = "txtNombre02"
        Me.txtNombre02.Size = New System.Drawing.Size(256, 20)
        Me.txtNombre02.TabIndex = 3
        '
        'txtMes02
        '
        Me.txtMes02.BackColor = System.Drawing.Color.White
        Me.txtMes02.Location = New System.Drawing.Point(248, 148)
        Me.txtMes02.MaxLength = 10
        Me.txtMes02.Name = "txtMes02"
        Me.txtMes02.Size = New System.Drawing.Size(88, 20)
        Me.txtMes02.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(336, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 23)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "de"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño02
        '
        Me.txtAño02.BackColor = System.Drawing.Color.White
        Me.txtAño02.Location = New System.Drawing.Point(360, 148)
        Me.txtAño02.MaxLength = 4
        Me.txtAño02.Name = "txtAño02"
        Me.txtAño02.Size = New System.Drawing.Size(80, 20)
        Me.txtAño02.TabIndex = 11
        '
        'txtCI02
        '
        Me.txtCI02.BackColor = System.Drawing.Color.White
        Me.txtCI02.Location = New System.Drawing.Point(360, 118)
        Me.txtCI02.MaxLength = 10
        Me.txtCI02.Name = "txtCI02"
        Me.txtCI02.Size = New System.Drawing.Size(80, 20)
        Me.txtCI02.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(64, 280)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(392, 23)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Atentamente"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(64, 146)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 23)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Asistió a consulta hoy "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(320, 116)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 23)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = ",  C.I. :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(64, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(392, 23)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Quien suscribe, Médico en ejercicio hace constar por medio de la presente"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia02
        '
        Me.txtDia02.BackColor = System.Drawing.Color.White
        Me.txtDia02.Location = New System.Drawing.Point(184, 148)
        Me.txtDia02.MaxLength = 2
        Me.txtDia02.Name = "txtDia02"
        Me.txtDia02.Size = New System.Drawing.Size(32, 20)
        Me.txtDia02.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(64, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(392, 23)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "que la paciente:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(224, 146)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 23)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "de"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Label47)
        Me.TabPage3.Controls.Add(Me.botCalculaInicioReposo)
        Me.TabPage3.Controls.Add(Me.botImpReposoPre)
        Me.TabPage3.Controls.Add(Me.Panel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(736, 382)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Reposo Prenatal"
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(624, 176)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(100, 64)
        Me.Label47.TabIndex = 3
        Me.Label47.Text = "Introduce la FUR y luego presiona el botón para calcular el día del inicio del re" &
    "poso prenatal"
        '
        'botCalculaInicioReposo
        '
        Me.botCalculaInicioReposo.BackgroundImage = CType(resources.GetObject("botCalculaInicioReposo.BackgroundImage"), System.Drawing.Image)
        Me.botCalculaInicioReposo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCalculaInicioReposo.Location = New System.Drawing.Point(632, 248)
        Me.botCalculaInicioReposo.Name = "botCalculaInicioReposo"
        Me.botCalculaInicioReposo.Size = New System.Drawing.Size(96, 23)
        Me.botCalculaInicioReposo.TabIndex = 2
        Me.botCalculaInicioReposo.Text = "Calcula"
        '
        'botImpReposoPre
        '
        Me.botImpReposoPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImpReposoPre.Image = CType(resources.GetObject("botImpReposoPre.Image"), System.Drawing.Image)
        Me.botImpReposoPre.Location = New System.Drawing.Point(392, 352)
        Me.botImpReposoPre.Name = "botImpReposoPre"
        Me.botImpReposoPre.Size = New System.Drawing.Size(224, 23)
        Me.botImpReposoPre.TabIndex = 1
        Me.botImpReposoPre.Text = "Prepara la Impresión"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.txtCiudad)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.txtMesFUR)
        Me.Panel4.Controls.Add(Me.Label40)
        Me.Panel4.Controls.Add(Me.txtAñoFUR)
        Me.Panel4.Controls.Add(Me.txtDiaFUR)
        Me.Panel4.Controls.Add(Me.Label43)
        Me.Panel4.Controls.Add(Me.txtMesInicio02)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.txtAñoInicio02)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.txtDiaInicio02)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.Label34)
        Me.Panel4.Controls.Add(Me.Label35)
        Me.Panel4.Controls.Add(Me.txtNombre03)
        Me.Panel4.Controls.Add(Me.txtMes03)
        Me.Panel4.Controls.Add(Me.Label36)
        Me.Panel4.Controls.Add(Me.txtAño03)
        Me.Panel4.Controls.Add(Me.txtCI03)
        Me.Panel4.Controls.Add(Me.Label37)
        Me.Panel4.Controls.Add(Me.Label38)
        Me.Panel4.Controls.Add(Me.Label39)
        Me.Panel4.Controls.Add(Me.txtDia03)
        Me.Panel4.Controls.Add(Me.Label41)
        Me.Panel4.Controls.Add(Me.Label42)
        Me.Panel4.Location = New System.Drawing.Point(112, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(504, 336)
        Me.Panel4.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(64, 288)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(392, 23)
        Me.Label32.TabIndex = 27
        Me.Label32.Text = "Atentamente."
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCiudad
        '
        Me.txtCiudad.BackColor = System.Drawing.Color.White
        Me.txtCiudad.Location = New System.Drawing.Point(116, 68)
        Me.txtCiudad.MaxLength = 45
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(268, 20)
        Me.txtCiudad.TabIndex = 2
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(64, 94)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(52, 23)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Fecha :"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMesFUR
        '
        Me.txtMesFUR.BackColor = System.Drawing.Color.White
        Me.txtMesFUR.Location = New System.Drawing.Point(248, 208)
        Me.txtMesFUR.MaxLength = 10
        Me.txtMesFUR.Name = "txtMesFUR"
        Me.txtMesFUR.Size = New System.Drawing.Size(88, 20)
        Me.txtMesFUR.TabIndex = 17
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(336, 206)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(24, 23)
        Me.Label40.TabIndex = 18
        Me.Label40.Text = "de"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAñoFUR
        '
        Me.txtAñoFUR.BackColor = System.Drawing.Color.White
        Me.txtAñoFUR.Location = New System.Drawing.Point(360, 208)
        Me.txtAñoFUR.MaxLength = 4
        Me.txtAñoFUR.Name = "txtAñoFUR"
        Me.txtAñoFUR.Size = New System.Drawing.Size(80, 20)
        Me.txtAñoFUR.TabIndex = 19
        '
        'txtDiaFUR
        '
        Me.txtDiaFUR.BackColor = System.Drawing.Color.White
        Me.txtDiaFUR.Location = New System.Drawing.Point(184, 208)
        Me.txtDiaFUR.MaxLength = 2
        Me.txtDiaFUR.Name = "txtDiaFUR"
        Me.txtDiaFUR.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaFUR.TabIndex = 15
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(224, 206)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(24, 23)
        Me.Label43.TabIndex = 16
        Me.Label43.Text = "de"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMesInicio02
        '
        Me.txtMesInicio02.BackColor = System.Drawing.Color.White
        Me.txtMesInicio02.Location = New System.Drawing.Point(248, 236)
        Me.txtMesInicio02.MaxLength = 10
        Me.txtMesInicio02.Name = "txtMesInicio02"
        Me.txtMesInicio02.Size = New System.Drawing.Size(88, 20)
        Me.txtMesInicio02.TabIndex = 23
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(336, 234)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(24, 23)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "de"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAñoInicio02
        '
        Me.txtAñoInicio02.BackColor = System.Drawing.Color.White
        Me.txtAñoInicio02.Location = New System.Drawing.Point(360, 236)
        Me.txtAñoInicio02.MaxLength = 4
        Me.txtAñoInicio02.Name = "txtAñoInicio02"
        Me.txtAñoInicio02.Size = New System.Drawing.Size(80, 20)
        Me.txtAñoInicio02.TabIndex = 25
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(66, 234)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(112, 23)
        Me.Label30.TabIndex = 20
        Me.Label30.Text = "Reposo a partir del"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiaInicio02
        '
        Me.txtDiaInicio02.BackColor = System.Drawing.Color.White
        Me.txtDiaInicio02.Location = New System.Drawing.Point(184, 236)
        Me.txtDiaInicio02.MaxLength = 2
        Me.txtDiaInicio02.Name = "txtDiaInicio02"
        Me.txtDiaInicio02.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaInicio02.TabIndex = 21
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(224, 234)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(24, 23)
        Me.Label31.TabIndex = 22
        Me.Label31.Text = "de"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(64, 206)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(124, 23)
        Me.Label33.TabIndex = 14
        Me.Label33.Text = "Fecha de última regla: "
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(64, 124)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(392, 23)
        Me.Label34.TabIndex = 9
        Me.Label34.Text = "AGRADEZCO CONCEDER  REPOSO PRENATAL DE LEY"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(132, 28)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(220, 23)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "REPOSO PRENATAL"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre03
        '
        Me.txtNombre03.BackColor = System.Drawing.Color.White
        Me.txtNombre03.Location = New System.Drawing.Point(64, 180)
        Me.txtNombre03.MaxLength = 45
        Me.txtNombre03.Name = "txtNombre03"
        Me.txtNombre03.Size = New System.Drawing.Size(256, 20)
        Me.txtNombre03.TabIndex = 11
        '
        'txtMes03
        '
        Me.txtMes03.BackColor = System.Drawing.Color.White
        Me.txtMes03.Location = New System.Drawing.Point(180, 96)
        Me.txtMes03.MaxLength = 10
        Me.txtMes03.Name = "txtMes03"
        Me.txtMes03.Size = New System.Drawing.Size(88, 20)
        Me.txtMes03.TabIndex = 6
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(274, 94)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(24, 23)
        Me.Label36.TabIndex = 7
        Me.Label36.Text = "de"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño03
        '
        Me.txtAño03.BackColor = System.Drawing.Color.White
        Me.txtAño03.Location = New System.Drawing.Point(304, 96)
        Me.txtAño03.MaxLength = 4
        Me.txtAño03.Name = "txtAño03"
        Me.txtAño03.Size = New System.Drawing.Size(80, 20)
        Me.txtAño03.TabIndex = 8
        '
        'txtCI03
        '
        Me.txtCI03.BackColor = System.Drawing.Color.White
        Me.txtCI03.Location = New System.Drawing.Point(360, 180)
        Me.txtCI03.MaxLength = 10
        Me.txtCI03.Name = "txtCI03"
        Me.txtCI03.Size = New System.Drawing.Size(80, 20)
        Me.txtCI03.TabIndex = 13
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(64, 260)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(392, 23)
        Me.Label37.TabIndex = 26
        Me.Label37.Text = "día en el cual la paciente cumple las 34 semanas de embarazo."
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(64, 66)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(48, 23)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "Ciudad :"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(320, 178)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(40, 23)
        Me.Label39.TabIndex = 12
        Me.Label39.Text = ",  C.I. :"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia03
        '
        Me.txtDia03.BackColor = System.Drawing.Color.White
        Me.txtDia03.Location = New System.Drawing.Point(116, 96)
        Me.txtDia03.MaxLength = 2
        Me.txtDia03.Name = "txtDia03"
        Me.txtDia03.Size = New System.Drawing.Size(32, 20)
        Me.txtDia03.TabIndex = 4
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(64, 152)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(392, 23)
        Me.Label41.TabIndex = 10
        Me.Label41.Text = "A la Paciente:"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(154, 94)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(24, 23)
        Me.Label42.TabIndex = 5
        Me.Label42.Text = "de"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.botImpReposoPost)
        Me.TabPage4.Controls.Add(Me.Panel5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(736, 382)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Reposo Postnatal"
        '
        'botImpReposoPost
        '
        Me.botImpReposoPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImpReposoPost.Image = CType(resources.GetObject("botImpReposoPost.Image"), System.Drawing.Image)
        Me.botImpReposoPost.Location = New System.Drawing.Point(392, 352)
        Me.botImpReposoPost.Name = "botImpReposoPost"
        Me.botImpReposoPost.Size = New System.Drawing.Size(224, 23)
        Me.botImpReposoPost.TabIndex = 2
        Me.botImpReposoPost.Text = "Prepara la Impresión"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label165)
        Me.Panel5.Controls.Add(Me.txtExcesoReposo04)
        Me.Panel5.Controls.Add(Me.txtFUR04)
        Me.Panel5.Controls.Add(Me.txtEG04)
        Me.Panel5.Controls.Add(Me.Label163)
        Me.Panel5.Controls.Add(Me.Label162)
        Me.Panel5.Controls.Add(Me.Label58)
        Me.Panel5.Controls.Add(Me.Label46)
        Me.Panel5.Controls.Add(Me.radParto)
        Me.Panel5.Controls.Add(Me.radCesarea)
        Me.Panel5.Controls.Add(Me.Label44)
        Me.Panel5.Controls.Add(Me.txtCiudad02)
        Me.Panel5.Controls.Add(Me.Label45)
        Me.Panel5.Controls.Add(Me.txtMesInicio03)
        Me.Panel5.Controls.Add(Me.Label48)
        Me.Panel5.Controls.Add(Me.txtAñoInicio03)
        Me.Panel5.Controls.Add(Me.Label49)
        Me.Panel5.Controls.Add(Me.txtDiaInicio03)
        Me.Panel5.Controls.Add(Me.Label50)
        Me.Panel5.Controls.Add(Me.Label52)
        Me.Panel5.Controls.Add(Me.Label53)
        Me.Panel5.Controls.Add(Me.txtNombre04)
        Me.Panel5.Controls.Add(Me.txtMes04)
        Me.Panel5.Controls.Add(Me.Label54)
        Me.Panel5.Controls.Add(Me.txtAño04)
        Me.Panel5.Controls.Add(Me.txtCI04)
        Me.Panel5.Controls.Add(Me.Label55)
        Me.Panel5.Controls.Add(Me.Label56)
        Me.Panel5.Controls.Add(Me.Label57)
        Me.Panel5.Controls.Add(Me.txtDia04)
        Me.Panel5.Controls.Add(Me.Label59)
        Me.Panel5.Location = New System.Drawing.Point(112, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(504, 336)
        Me.Panel5.TabIndex = 0
        '
        'Label165
        '
        Me.Label165.AutoSize = True
        Me.Label165.Location = New System.Drawing.Point(39, 313)
        Me.Label165.Name = "Label165"
        Me.Label165.Size = New System.Drawing.Size(67, 13)
        Me.Label165.TabIndex = 30
        Me.Label165.Text = "Atentamente"
        Me.Label165.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExcesoReposo04
        '
        Me.txtExcesoReposo04.BackColor = System.Drawing.Color.White
        Me.txtExcesoReposo04.Location = New System.Drawing.Point(105, 263)
        Me.txtExcesoReposo04.MaxLength = 2
        Me.txtExcesoReposo04.Name = "txtExcesoReposo04"
        Me.txtExcesoReposo04.Size = New System.Drawing.Size(45, 20)
        Me.txtExcesoReposo04.TabIndex = 27
        '
        'txtFUR04
        '
        Me.txtFUR04.BackColor = System.Drawing.Color.White
        Me.txtFUR04.Location = New System.Drawing.Point(120, 238)
        Me.txtFUR04.MaxLength = 10
        Me.txtFUR04.Name = "txtFUR04"
        Me.txtFUR04.Size = New System.Drawing.Size(98, 20)
        Me.txtFUR04.TabIndex = 25
        '
        'txtEG04
        '
        Me.txtEG04.BackColor = System.Drawing.Color.White
        Me.txtEG04.Location = New System.Drawing.Point(199, 215)
        Me.txtEG04.MaxLength = 20
        Me.txtEG04.Name = "txtEG04"
        Me.txtEG04.Size = New System.Drawing.Size(93, 20)
        Me.txtEG04.TabIndex = 23
        '
        'Label163
        '
        Me.Label163.AutoSize = True
        Me.Label163.Location = New System.Drawing.Point(161, 266)
        Me.Label163.Name = "Label163"
        Me.Label163.Size = New System.Drawing.Size(295, 13)
        Me.Label163.TabIndex = 28
        Me.Label163.Text = "días adicionales de REPOSO PRENATAL no disfrutado que "
        Me.Label163.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label162
        '
        Me.Label162.AutoSize = True
        Me.Label162.Location = New System.Drawing.Point(36, 266)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(63, 13)
        Me.Label162.TabIndex = 26
        Me.Label162.Text = "Ameritando "
        Me.Label162.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(36, 241)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(78, 13)
        Me.Label58.TabIndex = 24
        Me.Label58.Text = "según FUR del"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(36, 166)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(160, 23)
        Me.Label46.TabIndex = 13
        Me.Label46.Text = "A quien se le atendió"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'radParto
        '
        Me.radParto.Location = New System.Drawing.Point(308, 166)
        Me.radParto.Name = "radParto"
        Me.radParto.Size = New System.Drawing.Size(104, 24)
        Me.radParto.TabIndex = 15
        Me.radParto.Text = "Parto Normal"
        '
        'radCesarea
        '
        Me.radCesarea.Checked = True
        Me.radCesarea.Location = New System.Drawing.Point(204, 166)
        Me.radCesarea.Name = "radCesarea"
        Me.radCesarea.Size = New System.Drawing.Size(104, 24)
        Me.radCesarea.TabIndex = 14
        Me.radCesarea.TabStop = True
        Me.radCesarea.Text = "Cesárea"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(36, 286)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(223, 13)
        Me.Label44.TabIndex = 29
        Me.Label44.Text = "se deben sumar a su REPOSO POSTNATAL."
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCiudad02
        '
        Me.txtCiudad02.BackColor = System.Drawing.Color.White
        Me.txtCiudad02.Location = New System.Drawing.Point(88, 68)
        Me.txtCiudad02.MaxLength = 45
        Me.txtCiudad02.Name = "txtCiudad02"
        Me.txtCiudad02.Size = New System.Drawing.Size(252, 20)
        Me.txtCiudad02.TabIndex = 2
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(33, 94)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(52, 23)
        Me.Label45.TabIndex = 3
        Me.Label45.Text = "Fecha :"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMesInicio03
        '
        Me.txtMesInicio03.BackColor = System.Drawing.Color.White
        Me.txtMesInicio03.Location = New System.Drawing.Point(156, 191)
        Me.txtMesInicio03.MaxLength = 10
        Me.txtMesInicio03.Name = "txtMesInicio03"
        Me.txtMesInicio03.Size = New System.Drawing.Size(88, 20)
        Me.txtMesInicio03.TabIndex = 19
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(244, 189)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(24, 23)
        Me.Label48.TabIndex = 20
        Me.Label48.Text = "de"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAñoInicio03
        '
        Me.txtAñoInicio03.BackColor = System.Drawing.Color.White
        Me.txtAñoInicio03.Location = New System.Drawing.Point(268, 191)
        Me.txtAñoInicio03.MaxLength = 4
        Me.txtAñoInicio03.Name = "txtAñoInicio03"
        Me.txtAñoInicio03.Size = New System.Drawing.Size(80, 20)
        Me.txtAñoInicio03.TabIndex = 21
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(36, 189)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(44, 23)
        Me.Label49.TabIndex = 16
        Me.Label49.Text = "El día :"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiaInicio03
        '
        Me.txtDiaInicio03.BackColor = System.Drawing.Color.White
        Me.txtDiaInicio03.Location = New System.Drawing.Point(92, 191)
        Me.txtDiaInicio03.MaxLength = 2
        Me.txtDiaInicio03.Name = "txtDiaInicio03"
        Me.txtDiaInicio03.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaInicio03.TabIndex = 17
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(130, 189)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(24, 23)
        Me.Label50.TabIndex = 18
        Me.Label50.Text = "de"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(36, 124)
        Me.Label52.Name = "Label52"
        Me.Label52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label52.Size = New System.Drawing.Size(361, 13)
        Me.Label52.TabIndex = 9
        Me.Label52.Text = "AGRADEZCO CONCEDER  REPOSO POSTNATAL DE LEY a la Paciente"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(136, 28)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(220, 23)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "REPOSO POSTNATAL"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre04
        '
        Me.txtNombre04.BackColor = System.Drawing.Color.White
        Me.txtNombre04.Location = New System.Drawing.Point(36, 144)
        Me.txtNombre04.MaxLength = 45
        Me.txtNombre04.Name = "txtNombre04"
        Me.txtNombre04.Size = New System.Drawing.Size(256, 20)
        Me.txtNombre04.TabIndex = 10
        '
        'txtMes04
        '
        Me.txtMes04.BackColor = System.Drawing.Color.White
        Me.txtMes04.Location = New System.Drawing.Point(152, 96)
        Me.txtMes04.MaxLength = 10
        Me.txtMes04.Name = "txtMes04"
        Me.txtMes04.Size = New System.Drawing.Size(88, 20)
        Me.txtMes04.TabIndex = 6
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(244, 94)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(24, 23)
        Me.Label54.TabIndex = 7
        Me.Label54.Text = "de"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño04
        '
        Me.txtAño04.BackColor = System.Drawing.Color.White
        Me.txtAño04.Location = New System.Drawing.Point(271, 96)
        Me.txtAño04.MaxLength = 4
        Me.txtAño04.Name = "txtAño04"
        Me.txtAño04.Size = New System.Drawing.Size(80, 20)
        Me.txtAño04.TabIndex = 8
        '
        'txtCI04
        '
        Me.txtCI04.BackColor = System.Drawing.Color.White
        Me.txtCI04.Location = New System.Drawing.Point(344, 144)
        Me.txtCI04.MaxLength = 10
        Me.txtCI04.Name = "txtCI04"
        Me.txtCI04.Size = New System.Drawing.Size(80, 20)
        Me.txtCI04.TabIndex = 12
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(36, 218)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(157, 13)
        Me.Label55.TabIndex = 22
        Me.Label55.Text = "Edag gestacional al nacimiento:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(33, 66)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(48, 23)
        Me.Label56.TabIndex = 1
        Me.Label56.Text = "Ciudad :"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(298, 142)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(40, 23)
        Me.Label57.TabIndex = 11
        Me.Label57.Text = ",  C.I. :"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia04
        '
        Me.txtDia04.BackColor = System.Drawing.Color.White
        Me.txtDia04.Location = New System.Drawing.Point(88, 96)
        Me.txtDia04.MaxLength = 2
        Me.txtDia04.Name = "txtDia04"
        Me.txtDia04.Size = New System.Drawing.Size(32, 20)
        Me.txtDia04.TabIndex = 4
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(126, 94)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(24, 23)
        Me.Label59.TabIndex = 5
        Me.Label59.Text = "de"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage8.Controls.Add(Me.botImpInformeCesarea)
        Me.TabPage8.Controls.Add(Me.Panel12)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(736, 382)
        Me.TabPage8.TabIndex = 4
        Me.TabPage8.Text = "Informe Cesárea"
        '
        'botImpInformeCesarea
        '
        Me.botImpInformeCesarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImpInformeCesarea.Image = CType(resources.GetObject("botImpInformeCesarea.Image"), System.Drawing.Image)
        Me.botImpInformeCesarea.Location = New System.Drawing.Point(392, 352)
        Me.botImpInformeCesarea.Name = "botImpInformeCesarea"
        Me.botImpInformeCesarea.Size = New System.Drawing.Size(224, 23)
        Me.botImpInformeCesarea.TabIndex = 3
        Me.botImpInformeCesarea.Text = "Prepara la Impresión"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Label77)
        Me.Panel12.Controls.Add(Me.Label69)
        Me.Panel12.Controls.Add(Me.Label68)
        Me.Panel12.Controls.Add(Me.Label64)
        Me.Panel12.Controls.Add(Me.Label63)
        Me.Panel12.Controls.Add(Me.Label62)
        Me.Panel12.Controls.Add(Me.Label60)
        Me.Panel12.Controls.Add(Me.Label51)
        Me.Panel12.Controls.Add(Me.txtDx01c)
        Me.Panel12.Controls.Add(Me.txtDx01b)
        Me.Panel12.Controls.Add(Me.txtDx01a)
        Me.Panel12.Controls.Add(Me.Label76)
        Me.Panel12.Controls.Add(Me.Label75)
        Me.Panel12.Controls.Add(Me.txtSemanas01)
        Me.Panel12.Controls.Add(Me.Label74)
        Me.Panel12.Controls.Add(Me.txtDrCI01)
        Me.Panel12.Controls.Add(Me.Label73)
        Me.Panel12.Controls.Add(Me.txtDoctor01)
        Me.Panel12.Controls.Add(Me.Label61)
        Me.Panel12.Controls.Add(Me.Label65)
        Me.Panel12.Controls.Add(Me.Label66)
        Me.Panel12.Controls.Add(Me.txtNombre05)
        Me.Panel12.Controls.Add(Me.txtMes05)
        Me.Panel12.Controls.Add(Me.Label67)
        Me.Panel12.Controls.Add(Me.txtAño05)
        Me.Panel12.Controls.Add(Me.txtCI05)
        Me.Panel12.Controls.Add(Me.Label70)
        Me.Panel12.Controls.Add(Me.txtDia05)
        Me.Panel12.Controls.Add(Me.Label71)
        Me.Panel12.Controls.Add(Me.Label72)
        Me.Panel12.Location = New System.Drawing.Point(112, 8)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(504, 336)
        Me.Panel12.TabIndex = 2
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(32, 190)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(20, 23)
        Me.Label77.TabIndex = 48
        Me.Label77.Text = "3.-"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(32, 166)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(20, 23)
        Me.Label69.TabIndex = 47
        Me.Label69.Text = "2.-"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(32, 142)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(20, 23)
        Me.Label68.TabIndex = 46
        Me.Label68.Text = "1.-"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.Location = New System.Drawing.Point(32, 306)
        Me.Label64.Name = "Label64"
        Me.Label64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label64.Size = New System.Drawing.Size(364, 16)
        Me.Label64.TabIndex = 45
        Me.Label64.Text = "Indicada por los diagnósticos expuestos."
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(32, 288)
        Me.Label63.Name = "Label63"
        Me.Label63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label63.Size = New System.Drawing.Size(187, 16)
        Me.Label63.TabIndex = 44
        Me.Label63.Text = "1. Cesárea Segmentaria."
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(32, 259)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label62.Size = New System.Drawing.Size(428, 28)
        Me.Label62.TabIndex = 43
        Me.Label62.Text = "Sirva este informe para el procesamiento de la carta aval de la CIA de Seguros co" &
    "n la siguiente conducta:"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(32, 228)
        Me.Label60.Name = "Label60"
        Me.Label60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label60.Size = New System.Drawing.Size(428, 33)
        Me.Label60.TabIndex = 42
        Me.Label60.Text = "Actualmente se encuentra en control semanal con test de reactividad fetal y ecogr" &
    "afía, en espera de alcanzar el término de  la gestación."
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(32, 214)
        Me.Label51.Name = "Label51"
        Me.Label51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label51.Size = New System.Drawing.Size(428, 16)
        Me.Label51.TabIndex = 41
        Me.Label51.Text = "La paciente recibió inductores para la maduración pulmonar fetal."
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDx01c
        '
        Me.txtDx01c.BackColor = System.Drawing.Color.White
        Me.txtDx01c.Location = New System.Drawing.Point(56, 192)
        Me.txtDx01c.MaxLength = 45
        Me.txtDx01c.Name = "txtDx01c"
        Me.txtDx01c.Size = New System.Drawing.Size(408, 20)
        Me.txtDx01c.TabIndex = 40
        '
        'txtDx01b
        '
        Me.txtDx01b.BackColor = System.Drawing.Color.White
        Me.txtDx01b.Location = New System.Drawing.Point(56, 168)
        Me.txtDx01b.MaxLength = 45
        Me.txtDx01b.Name = "txtDx01b"
        Me.txtDx01b.Size = New System.Drawing.Size(408, 20)
        Me.txtDx01b.TabIndex = 39
        '
        'txtDx01a
        '
        Me.txtDx01a.BackColor = System.Drawing.Color.White
        Me.txtDx01a.Location = New System.Drawing.Point(56, 144)
        Me.txtDx01a.MaxLength = 45
        Me.txtDx01a.Name = "txtDx01a"
        Me.txtDx01a.Size = New System.Drawing.Size(408, 20)
        Me.txtDx01a.TabIndex = 38
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(32, 124)
        Me.Label76.Name = "Label76"
        Me.Label76.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label76.Size = New System.Drawing.Size(336, 16)
        Me.Label76.TabIndex = 37
        Me.Label76.Text = "y presenta los siguientes diagnósticos:"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(400, 104)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(64, 16)
        Me.Label75.TabIndex = 36
        Me.Label75.Text = "semanas"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSemanas01
        '
        Me.txtSemanas01.BackColor = System.Drawing.Color.White
        Me.txtSemanas01.Location = New System.Drawing.Point(360, 103)
        Me.txtSemanas01.MaxLength = 10
        Me.txtSemanas01.Name = "txtSemanas01"
        Me.txtSemanas01.Size = New System.Drawing.Size(32, 20)
        Me.txtSemanas01.TabIndex = 35
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(32, 104)
        Me.Label74.Name = "Label74"
        Me.Label74.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label74.Size = New System.Drawing.Size(336, 16)
        Me.Label74.TabIndex = 34
        Me.Label74.Text = "hace constar que la paciente cursa actualmente con embarazo de"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDrCI01
        '
        Me.txtDrCI01.BackColor = System.Drawing.Color.White
        Me.txtDrCI01.Location = New System.Drawing.Point(384, 80)
        Me.txtDrCI01.MaxLength = 10
        Me.txtDrCI01.Name = "txtDrCI01"
        Me.txtDrCI01.Size = New System.Drawing.Size(80, 20)
        Me.txtDrCI01.TabIndex = 33
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(344, 78)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(40, 23)
        Me.Label73.TabIndex = 32
        Me.Label73.Text = ",  C.I. :"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDoctor01
        '
        Me.txtDoctor01.BackColor = System.Drawing.Color.White
        Me.txtDoctor01.Location = New System.Drawing.Point(116, 80)
        Me.txtDoctor01.MaxLength = 45
        Me.txtDoctor01.Name = "txtDoctor01"
        Me.txtDoctor01.Size = New System.Drawing.Size(228, 20)
        Me.txtDoctor01.TabIndex = 31
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(32, 30)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(48, 23)
        Me.Label61.TabIndex = 3
        Me.Label61.Text = "Fecha :"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(32, 81)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label65.Size = New System.Drawing.Size(84, 16)
        Me.Label65.TabIndex = 9
        Me.Label65.Text = "Quien suscribe,"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(132, 4)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(220, 23)
        Me.Label66.TabIndex = 0
        Me.Label66.Text = "INFORME MEDICO"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre05
        '
        Me.txtNombre05.BackColor = System.Drawing.Color.White
        Me.txtNombre05.Location = New System.Drawing.Point(88, 56)
        Me.txtNombre05.MaxLength = 45
        Me.txtNombre05.Name = "txtNombre05"
        Me.txtNombre05.Size = New System.Drawing.Size(256, 20)
        Me.txtNombre05.TabIndex = 11
        '
        'txtMes05
        '
        Me.txtMes05.BackColor = System.Drawing.Color.White
        Me.txtMes05.Location = New System.Drawing.Point(140, 32)
        Me.txtMes05.MaxLength = 10
        Me.txtMes05.Name = "txtMes05"
        Me.txtMes05.Size = New System.Drawing.Size(88, 20)
        Me.txtMes05.TabIndex = 6
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(231, 30)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(24, 23)
        Me.Label67.TabIndex = 7
        Me.Label67.Text = "de"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño05
        '
        Me.txtAño05.BackColor = System.Drawing.Color.White
        Me.txtAño05.Location = New System.Drawing.Point(257, 32)
        Me.txtAño05.MaxLength = 4
        Me.txtAño05.Name = "txtAño05"
        Me.txtAño05.Size = New System.Drawing.Size(80, 20)
        Me.txtAño05.TabIndex = 8
        '
        'txtCI05
        '
        Me.txtCI05.BackColor = System.Drawing.Color.White
        Me.txtCI05.Location = New System.Drawing.Point(384, 56)
        Me.txtCI05.MaxLength = 10
        Me.txtCI05.Name = "txtCI05"
        Me.txtCI05.Size = New System.Drawing.Size(80, 20)
        Me.txtCI05.TabIndex = 13
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(344, 54)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(40, 23)
        Me.Label70.TabIndex = 12
        Me.Label70.Text = ",  C.I. :"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia05
        '
        Me.txtDia05.BackColor = System.Drawing.Color.White
        Me.txtDia05.Location = New System.Drawing.Point(84, 32)
        Me.txtDia05.MaxLength = 2
        Me.txtDia05.Name = "txtDia05"
        Me.txtDia05.Size = New System.Drawing.Size(32, 20)
        Me.txtDia05.TabIndex = 4
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(32, 54)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(52, 23)
        Me.Label71.TabIndex = 10
        Me.Label71.Text = "Paciente:"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(118, 30)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(24, 23)
        Me.Label72.TabIndex = 5
        Me.Label72.Text = "de"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage9.Controls.Add(Me.botImpInformeParto)
        Me.TabPage9.Controls.Add(Me.Panel13)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(736, 382)
        Me.TabPage9.TabIndex = 5
        Me.TabPage9.Text = "Informe Parto"
        '
        'botImpInformeParto
        '
        Me.botImpInformeParto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImpInformeParto.Image = CType(resources.GetObject("botImpInformeParto.Image"), System.Drawing.Image)
        Me.botImpInformeParto.Location = New System.Drawing.Point(392, 352)
        Me.botImpInformeParto.Name = "botImpInformeParto"
        Me.botImpInformeParto.Size = New System.Drawing.Size(224, 23)
        Me.botImpInformeParto.TabIndex = 4
        Me.botImpInformeParto.Text = "Prepara la Impresión"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.Label78)
        Me.Panel13.Controls.Add(Me.Label79)
        Me.Panel13.Controls.Add(Me.Label80)
        Me.Panel13.Controls.Add(Me.Label81)
        Me.Panel13.Controls.Add(Me.Label82)
        Me.Panel13.Controls.Add(Me.Label83)
        Me.Panel13.Controls.Add(Me.Label84)
        Me.Panel13.Controls.Add(Me.Label85)
        Me.Panel13.Controls.Add(Me.txtDx02c)
        Me.Panel13.Controls.Add(Me.txtDx02b)
        Me.Panel13.Controls.Add(Me.txtDx02a)
        Me.Panel13.Controls.Add(Me.Label86)
        Me.Panel13.Controls.Add(Me.Label87)
        Me.Panel13.Controls.Add(Me.txtSemanas02)
        Me.Panel13.Controls.Add(Me.Label88)
        Me.Panel13.Controls.Add(Me.txtDrCI02)
        Me.Panel13.Controls.Add(Me.Label89)
        Me.Panel13.Controls.Add(Me.txtDoctor02)
        Me.Panel13.Controls.Add(Me.Label90)
        Me.Panel13.Controls.Add(Me.Label91)
        Me.Panel13.Controls.Add(Me.Label92)
        Me.Panel13.Controls.Add(Me.txtNombre06)
        Me.Panel13.Controls.Add(Me.txtMes06)
        Me.Panel13.Controls.Add(Me.Label93)
        Me.Panel13.Controls.Add(Me.txtAño06)
        Me.Panel13.Controls.Add(Me.txtCI06)
        Me.Panel13.Controls.Add(Me.Label94)
        Me.Panel13.Controls.Add(Me.txtDia06)
        Me.Panel13.Controls.Add(Me.Label95)
        Me.Panel13.Controls.Add(Me.Label96)
        Me.Panel13.Location = New System.Drawing.Point(112, 8)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(504, 336)
        Me.Panel13.TabIndex = 3
        '
        'Label78
        '
        Me.Label78.Location = New System.Drawing.Point(32, 190)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(20, 23)
        Me.Label78.TabIndex = 48
        Me.Label78.Text = "3.-"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(32, 166)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(20, 23)
        Me.Label79.TabIndex = 47
        Me.Label79.Text = "2.-"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label80
        '
        Me.Label80.Location = New System.Drawing.Point(32, 142)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(20, 23)
        Me.Label80.TabIndex = 46
        Me.Label80.Text = "1.-"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label81
        '
        Me.Label81.Location = New System.Drawing.Point(32, 304)
        Me.Label81.Name = "Label81"
        Me.Label81.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label81.Size = New System.Drawing.Size(424, 30)
        Me.Label81.TabIndex = 45
        Me.Label81.Text = "2. No descartándose realizar Cesárea Segmentaria en caso de emergencia en pro de " &
    "la salud tanto del feto como de la madre."
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label82
        '
        Me.Label82.Location = New System.Drawing.Point(32, 288)
        Me.Label82.Name = "Label82"
        Me.Label82.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label82.Size = New System.Drawing.Size(187, 16)
        Me.Label82.TabIndex = 44
        Me.Label82.Text = "1. Parto Normal."
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label83
        '
        Me.Label83.Location = New System.Drawing.Point(32, 261)
        Me.Label83.Name = "Label83"
        Me.Label83.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label83.Size = New System.Drawing.Size(428, 27)
        Me.Label83.TabIndex = 43
        Me.Label83.Text = "Sirva este informe para el procesamiento de la carta aval de la CIA de Seguros co" &
    "n  las siguientes posibles conductas:"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label84
        '
        Me.Label84.Location = New System.Drawing.Point(32, 231)
        Me.Label84.Name = "Label84"
        Me.Label84.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label84.Size = New System.Drawing.Size(428, 30)
        Me.Label84.TabIndex = 42
        Me.Label84.Text = "Actualmente se encuentra en control semanal con test de reactividad fetal y ecogr" &
    "afía, en espera de alcanzar el término de  la gestación."
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label85
        '
        Me.Label85.Location = New System.Drawing.Point(32, 215)
        Me.Label85.Name = "Label85"
        Me.Label85.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label85.Size = New System.Drawing.Size(428, 16)
        Me.Label85.TabIndex = 41
        Me.Label85.Text = "La paciente recibió inductores para la maduración pulmonar fetal."
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDx02c
        '
        Me.txtDx02c.BackColor = System.Drawing.Color.White
        Me.txtDx02c.Location = New System.Drawing.Point(56, 192)
        Me.txtDx02c.MaxLength = 45
        Me.txtDx02c.Name = "txtDx02c"
        Me.txtDx02c.Size = New System.Drawing.Size(408, 20)
        Me.txtDx02c.TabIndex = 40
        '
        'txtDx02b
        '
        Me.txtDx02b.BackColor = System.Drawing.Color.White
        Me.txtDx02b.Location = New System.Drawing.Point(56, 168)
        Me.txtDx02b.MaxLength = 45
        Me.txtDx02b.Name = "txtDx02b"
        Me.txtDx02b.Size = New System.Drawing.Size(408, 20)
        Me.txtDx02b.TabIndex = 39
        '
        'txtDx02a
        '
        Me.txtDx02a.BackColor = System.Drawing.Color.White
        Me.txtDx02a.Location = New System.Drawing.Point(56, 144)
        Me.txtDx02a.MaxLength = 45
        Me.txtDx02a.Name = "txtDx02a"
        Me.txtDx02a.Size = New System.Drawing.Size(408, 20)
        Me.txtDx02a.TabIndex = 38
        '
        'Label86
        '
        Me.Label86.Location = New System.Drawing.Point(32, 124)
        Me.Label86.Name = "Label86"
        Me.Label86.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label86.Size = New System.Drawing.Size(336, 16)
        Me.Label86.TabIndex = 37
        Me.Label86.Text = "y presenta los siguientes diagnósticos:"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label87
        '
        Me.Label87.Location = New System.Drawing.Point(400, 104)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(64, 16)
        Me.Label87.TabIndex = 36
        Me.Label87.Text = "semanas"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSemanas02
        '
        Me.txtSemanas02.BackColor = System.Drawing.Color.White
        Me.txtSemanas02.Location = New System.Drawing.Point(360, 103)
        Me.txtSemanas02.MaxLength = 10
        Me.txtSemanas02.Name = "txtSemanas02"
        Me.txtSemanas02.Size = New System.Drawing.Size(32, 20)
        Me.txtSemanas02.TabIndex = 35
        '
        'Label88
        '
        Me.Label88.Location = New System.Drawing.Point(32, 104)
        Me.Label88.Name = "Label88"
        Me.Label88.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label88.Size = New System.Drawing.Size(336, 16)
        Me.Label88.TabIndex = 34
        Me.Label88.Text = "hace constar que la paciente cursa actualmente con embarazo de"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDrCI02
        '
        Me.txtDrCI02.BackColor = System.Drawing.Color.White
        Me.txtDrCI02.Location = New System.Drawing.Point(384, 80)
        Me.txtDrCI02.MaxLength = 10
        Me.txtDrCI02.Name = "txtDrCI02"
        Me.txtDrCI02.Size = New System.Drawing.Size(80, 20)
        Me.txtDrCI02.TabIndex = 33
        '
        'Label89
        '
        Me.Label89.Location = New System.Drawing.Point(344, 78)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(40, 23)
        Me.Label89.TabIndex = 32
        Me.Label89.Text = ",  C.I. :"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDoctor02
        '
        Me.txtDoctor02.BackColor = System.Drawing.Color.White
        Me.txtDoctor02.Location = New System.Drawing.Point(116, 80)
        Me.txtDoctor02.MaxLength = 45
        Me.txtDoctor02.Name = "txtDoctor02"
        Me.txtDoctor02.Size = New System.Drawing.Size(228, 20)
        Me.txtDoctor02.TabIndex = 31
        '
        'Label90
        '
        Me.Label90.Location = New System.Drawing.Point(32, 30)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(48, 23)
        Me.Label90.TabIndex = 3
        Me.Label90.Text = "Fecha :"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label91
        '
        Me.Label91.Location = New System.Drawing.Point(32, 81)
        Me.Label91.Name = "Label91"
        Me.Label91.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label91.Size = New System.Drawing.Size(84, 16)
        Me.Label91.TabIndex = 9
        Me.Label91.Text = "Quien suscribe,"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label92
        '
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(132, 4)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(220, 23)
        Me.Label92.TabIndex = 0
        Me.Label92.Text = "INFORME MEDICO"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre06
        '
        Me.txtNombre06.BackColor = System.Drawing.Color.White
        Me.txtNombre06.Location = New System.Drawing.Point(88, 56)
        Me.txtNombre06.MaxLength = 45
        Me.txtNombre06.Name = "txtNombre06"
        Me.txtNombre06.Size = New System.Drawing.Size(256, 20)
        Me.txtNombre06.TabIndex = 11
        '
        'txtMes06
        '
        Me.txtMes06.BackColor = System.Drawing.Color.White
        Me.txtMes06.Location = New System.Drawing.Point(140, 32)
        Me.txtMes06.MaxLength = 10
        Me.txtMes06.Name = "txtMes06"
        Me.txtMes06.Size = New System.Drawing.Size(88, 20)
        Me.txtMes06.TabIndex = 6
        '
        'Label93
        '
        Me.Label93.Location = New System.Drawing.Point(231, 30)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(24, 23)
        Me.Label93.TabIndex = 7
        Me.Label93.Text = "de"
        Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño06
        '
        Me.txtAño06.BackColor = System.Drawing.Color.White
        Me.txtAño06.Location = New System.Drawing.Point(257, 32)
        Me.txtAño06.MaxLength = 4
        Me.txtAño06.Name = "txtAño06"
        Me.txtAño06.Size = New System.Drawing.Size(80, 20)
        Me.txtAño06.TabIndex = 8
        '
        'txtCI06
        '
        Me.txtCI06.BackColor = System.Drawing.Color.White
        Me.txtCI06.Location = New System.Drawing.Point(384, 56)
        Me.txtCI06.MaxLength = 10
        Me.txtCI06.Name = "txtCI06"
        Me.txtCI06.Size = New System.Drawing.Size(80, 20)
        Me.txtCI06.TabIndex = 13
        '
        'Label94
        '
        Me.Label94.Location = New System.Drawing.Point(344, 54)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(40, 23)
        Me.Label94.TabIndex = 12
        Me.Label94.Text = ",  C.I. :"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia06
        '
        Me.txtDia06.BackColor = System.Drawing.Color.White
        Me.txtDia06.Location = New System.Drawing.Point(84, 32)
        Me.txtDia06.MaxLength = 2
        Me.txtDia06.Name = "txtDia06"
        Me.txtDia06.Size = New System.Drawing.Size(32, 20)
        Me.txtDia06.TabIndex = 4
        '
        'Label95
        '
        Me.Label95.Location = New System.Drawing.Point(32, 54)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(52, 23)
        Me.Label95.TabIndex = 10
        Me.Label95.Text = "Paciente:"
        Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label96
        '
        Me.Label96.Location = New System.Drawing.Point(118, 30)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(24, 23)
        Me.Label96.TabIndex = 5
        Me.Label96.Text = "de"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.botImpInformeConsulta)
        Me.TabPage5.Controls.Add(Me.Panel6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(736, 382)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Informe de Consulta"
        '
        'botImpInformeConsulta
        '
        Me.botImpInformeConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImpInformeConsulta.Image = CType(resources.GetObject("botImpInformeConsulta.Image"), System.Drawing.Image)
        Me.botImpInformeConsulta.Location = New System.Drawing.Point(392, 352)
        Me.botImpInformeConsulta.Name = "botImpInformeConsulta"
        Me.botImpInformeConsulta.Size = New System.Drawing.Size(224, 23)
        Me.botImpInformeConsulta.TabIndex = 5
        Me.botImpInformeConsulta.Text = "Prepara la Impresión"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtExa11)
        Me.Panel6.Controls.Add(Me.Label161)
        Me.Panel6.Controls.Add(Me.txtTto11)
        Me.Panel6.Controls.Add(Me.Label158)
        Me.Panel6.Controls.Add(Me.Label159)
        Me.Panel6.Controls.Add(Me.Label160)
        Me.Panel6.Controls.Add(Me.Label164)
        Me.Panel6.Controls.Add(Me.txtDx11c)
        Me.Panel6.Controls.Add(Me.txtDx11b)
        Me.Panel6.Controls.Add(Me.txtDx11a)
        Me.Panel6.Controls.Add(Me.Label168)
        Me.Panel6.Controls.Add(Me.txtDrCI11)
        Me.Panel6.Controls.Add(Me.Label169)
        Me.Panel6.Controls.Add(Me.txtDoctor11)
        Me.Panel6.Controls.Add(Me.Label170)
        Me.Panel6.Controls.Add(Me.Label171)
        Me.Panel6.Controls.Add(Me.Label172)
        Me.Panel6.Controls.Add(Me.txtNombre11)
        Me.Panel6.Controls.Add(Me.txtMes11)
        Me.Panel6.Controls.Add(Me.Label173)
        Me.Panel6.Controls.Add(Me.txtAño11)
        Me.Panel6.Controls.Add(Me.txtCI11)
        Me.Panel6.Controls.Add(Me.Label174)
        Me.Panel6.Controls.Add(Me.txtDia11)
        Me.Panel6.Controls.Add(Me.Label175)
        Me.Panel6.Controls.Add(Me.Label176)
        Me.Panel6.Location = New System.Drawing.Point(112, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(504, 336)
        Me.Panel6.TabIndex = 3
        '
        'txtExa11
        '
        Me.txtExa11.BackColor = System.Drawing.Color.White
        Me.txtExa11.Location = New System.Drawing.Point(56, 276)
        Me.txtExa11.MaxLength = 45
        Me.txtExa11.Name = "txtExa11"
        Me.txtExa11.Size = New System.Drawing.Size(408, 20)
        Me.txtExa11.TabIndex = 51
        '
        'Label161
        '
        Me.Label161.AutoSize = True
        Me.Label161.Location = New System.Drawing.Point(32, 260)
        Me.Label161.Name = "Label161"
        Me.Label161.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label161.Size = New System.Drawing.Size(258, 13)
        Me.Label161.TabIndex = 50
        Me.Label161.Text = "Se le indicaron los siguientes exámenes paraclínicos:"
        '
        'txtTto11
        '
        Me.txtTto11.BackColor = System.Drawing.Color.White
        Me.txtTto11.Location = New System.Drawing.Point(56, 234)
        Me.txtTto11.MaxLength = 45
        Me.txtTto11.Name = "txtTto11"
        Me.txtTto11.Size = New System.Drawing.Size(408, 20)
        Me.txtTto11.TabIndex = 49
        '
        'Label158
        '
        Me.Label158.Location = New System.Drawing.Point(32, 190)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(20, 23)
        Me.Label158.TabIndex = 48
        Me.Label158.Text = "3.-"
        Me.Label158.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label159
        '
        Me.Label159.Location = New System.Drawing.Point(32, 166)
        Me.Label159.Name = "Label159"
        Me.Label159.Size = New System.Drawing.Size(20, 23)
        Me.Label159.TabIndex = 47
        Me.Label159.Text = "2.-"
        Me.Label159.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label160
        '
        Me.Label160.Location = New System.Drawing.Point(32, 142)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(20, 23)
        Me.Label160.TabIndex = 46
        Me.Label160.Text = "1.-"
        Me.Label160.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label164
        '
        Me.Label164.AutoSize = True
        Me.Label164.Location = New System.Drawing.Point(32, 218)
        Me.Label164.Name = "Label164"
        Me.Label164.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label164.Size = New System.Drawing.Size(233, 13)
        Me.Label164.TabIndex = 42
        Me.Label164.Text = "Se le indicó el siguiente tratamiento ambulatorio:"
        '
        'txtDx11c
        '
        Me.txtDx11c.BackColor = System.Drawing.Color.White
        Me.txtDx11c.Location = New System.Drawing.Point(56, 192)
        Me.txtDx11c.MaxLength = 45
        Me.txtDx11c.Name = "txtDx11c"
        Me.txtDx11c.Size = New System.Drawing.Size(408, 20)
        Me.txtDx11c.TabIndex = 40
        '
        'txtDx11b
        '
        Me.txtDx11b.BackColor = System.Drawing.Color.White
        Me.txtDx11b.Location = New System.Drawing.Point(56, 168)
        Me.txtDx11b.MaxLength = 45
        Me.txtDx11b.Name = "txtDx11b"
        Me.txtDx11b.Size = New System.Drawing.Size(408, 20)
        Me.txtDx11b.TabIndex = 39
        '
        'txtDx11a
        '
        Me.txtDx11a.BackColor = System.Drawing.Color.White
        Me.txtDx11a.Location = New System.Drawing.Point(56, 144)
        Me.txtDx11a.MaxLength = 45
        Me.txtDx11a.Name = "txtDx11a"
        Me.txtDx11a.Size = New System.Drawing.Size(408, 20)
        Me.txtDx11a.TabIndex = 38
        '
        'Label168
        '
        Me.Label168.Location = New System.Drawing.Point(32, 104)
        Me.Label168.Name = "Label168"
        Me.Label168.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label168.Size = New System.Drawing.Size(432, 37)
        Me.Label168.TabIndex = 34
        Me.Label168.Text = "hace constar que la paciente acudió hoy a la consulta  presentando los siguientes" &
    " diagnósticos"
        Me.Label168.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDrCI11
        '
        Me.txtDrCI11.BackColor = System.Drawing.Color.White
        Me.txtDrCI11.Location = New System.Drawing.Point(384, 80)
        Me.txtDrCI11.MaxLength = 10
        Me.txtDrCI11.Name = "txtDrCI11"
        Me.txtDrCI11.Size = New System.Drawing.Size(80, 20)
        Me.txtDrCI11.TabIndex = 33
        '
        'Label169
        '
        Me.Label169.Location = New System.Drawing.Point(344, 78)
        Me.Label169.Name = "Label169"
        Me.Label169.Size = New System.Drawing.Size(40, 23)
        Me.Label169.TabIndex = 32
        Me.Label169.Text = ",  C.I. :"
        Me.Label169.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDoctor11
        '
        Me.txtDoctor11.BackColor = System.Drawing.Color.White
        Me.txtDoctor11.Location = New System.Drawing.Point(116, 80)
        Me.txtDoctor11.MaxLength = 45
        Me.txtDoctor11.Name = "txtDoctor11"
        Me.txtDoctor11.Size = New System.Drawing.Size(228, 20)
        Me.txtDoctor11.TabIndex = 31
        '
        'Label170
        '
        Me.Label170.Location = New System.Drawing.Point(32, 30)
        Me.Label170.Name = "Label170"
        Me.Label170.Size = New System.Drawing.Size(48, 23)
        Me.Label170.TabIndex = 3
        Me.Label170.Text = "Fecha :"
        Me.Label170.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label171
        '
        Me.Label171.Location = New System.Drawing.Point(32, 81)
        Me.Label171.Name = "Label171"
        Me.Label171.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label171.Size = New System.Drawing.Size(84, 16)
        Me.Label171.TabIndex = 9
        Me.Label171.Text = "Quien suscribe,"
        Me.Label171.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label172
        '
        Me.Label172.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label172.Location = New System.Drawing.Point(132, 4)
        Me.Label172.Name = "Label172"
        Me.Label172.Size = New System.Drawing.Size(220, 23)
        Me.Label172.TabIndex = 0
        Me.Label172.Text = "INFORME MEDICO"
        Me.Label172.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre11
        '
        Me.txtNombre11.BackColor = System.Drawing.Color.White
        Me.txtNombre11.Location = New System.Drawing.Point(88, 56)
        Me.txtNombre11.MaxLength = 45
        Me.txtNombre11.Name = "txtNombre11"
        Me.txtNombre11.Size = New System.Drawing.Size(256, 20)
        Me.txtNombre11.TabIndex = 11
        '
        'txtMes11
        '
        Me.txtMes11.BackColor = System.Drawing.Color.White
        Me.txtMes11.Location = New System.Drawing.Point(140, 32)
        Me.txtMes11.MaxLength = 10
        Me.txtMes11.Name = "txtMes11"
        Me.txtMes11.Size = New System.Drawing.Size(88, 20)
        Me.txtMes11.TabIndex = 6
        '
        'Label173
        '
        Me.Label173.Location = New System.Drawing.Point(231, 30)
        Me.Label173.Name = "Label173"
        Me.Label173.Size = New System.Drawing.Size(24, 23)
        Me.Label173.TabIndex = 7
        Me.Label173.Text = "de"
        Me.Label173.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño11
        '
        Me.txtAño11.BackColor = System.Drawing.Color.White
        Me.txtAño11.Location = New System.Drawing.Point(257, 32)
        Me.txtAño11.MaxLength = 4
        Me.txtAño11.Name = "txtAño11"
        Me.txtAño11.Size = New System.Drawing.Size(80, 20)
        Me.txtAño11.TabIndex = 8
        '
        'txtCI11
        '
        Me.txtCI11.BackColor = System.Drawing.Color.White
        Me.txtCI11.Location = New System.Drawing.Point(384, 56)
        Me.txtCI11.MaxLength = 10
        Me.txtCI11.Name = "txtCI11"
        Me.txtCI11.Size = New System.Drawing.Size(80, 20)
        Me.txtCI11.TabIndex = 13
        '
        'Label174
        '
        Me.Label174.Location = New System.Drawing.Point(344, 54)
        Me.Label174.Name = "Label174"
        Me.Label174.Size = New System.Drawing.Size(40, 23)
        Me.Label174.TabIndex = 12
        Me.Label174.Text = ",  C.I. :"
        Me.Label174.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia11
        '
        Me.txtDia11.BackColor = System.Drawing.Color.White
        Me.txtDia11.Location = New System.Drawing.Point(84, 32)
        Me.txtDia11.MaxLength = 2
        Me.txtDia11.Name = "txtDia11"
        Me.txtDia11.Size = New System.Drawing.Size(32, 20)
        Me.txtDia11.TabIndex = 4
        '
        'Label175
        '
        Me.Label175.Location = New System.Drawing.Point(32, 54)
        Me.Label175.Name = "Label175"
        Me.Label175.Size = New System.Drawing.Size(52, 23)
        Me.Label175.TabIndex = 10
        Me.Label175.Text = "Paciente:"
        Me.Label175.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label176
        '
        Me.Label176.Location = New System.Drawing.Point(118, 30)
        Me.Label176.Name = "Label176"
        Me.Label176.Size = New System.Drawing.Size(24, 23)
        Me.Label176.TabIndex = 5
        Me.Label176.Text = "de"
        Me.Label176.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabIndicaciones
        '
        Me.TabIndicaciones.Controls.Add(Me.radINDvaginosisMixtaNE)
        Me.TabIndicaciones.Controls.Add(Me.radINDvaginosisNEok)
        Me.TabIndicaciones.Controls.Add(Me.GroupBox1)
        Me.TabIndicaciones.Controls.Add(Me.Label157)
        Me.TabIndicaciones.Controls.Add(Me.Label138)
        Me.TabIndicaciones.Controls.Add(Me.botImprimeIndicaciones)
        Me.TabIndicaciones.Controls.Add(Me.radIndVaginosisNEeco)
        Me.TabIndicaciones.Controls.Add(Me.radIndCandidiasisNE)
        Me.TabIndicaciones.Controls.Add(Me.radIndPrenatal)
        Me.TabIndicaciones.Controls.Add(Me.radINDCandidiasisE)
        Me.TabIndicaciones.Location = New System.Drawing.Point(4, 22)
        Me.TabIndicaciones.Name = "TabIndicaciones"
        Me.TabIndicaciones.Size = New System.Drawing.Size(768, 478)
        Me.TabIndicaciones.TabIndex = 2
        Me.TabIndicaciones.Text = "Indicaciones Frecuentes"
        '
        'radINDvaginosisMixtaNE
        '
        Me.radINDvaginosisMixtaNE.Enabled = False
        Me.radINDvaginosisMixtaNE.Location = New System.Drawing.Point(8, 104)
        Me.radINDvaginosisMixtaNE.Name = "radINDvaginosisMixtaNE"
        Me.radINDvaginosisMixtaNE.Size = New System.Drawing.Size(360, 24)
        Me.radINDvaginosisMixtaNE.TabIndex = 15
        Me.radINDvaginosisMixtaNE.Text = "Infección Vaginal Mixta"
        '
        'radINDvaginosisNEok
        '
        Me.radINDvaginosisNEok.Location = New System.Drawing.Point(8, 80)
        Me.radINDvaginosisNEok.Name = "radINDvaginosisNEok"
        Me.radINDvaginosisNEok.Size = New System.Drawing.Size(360, 24)
        Me.radINDvaginosisNEok.TabIndex = 14
        Me.radINDvaginosisNEok.Text = "Vaginosis Bacteriana Gardnerella y Tricomoniasis (OK)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(376, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(8, 432)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label157
        '
        Me.Label157.Location = New System.Drawing.Point(392, 8)
        Me.Label157.Name = "Label157"
        Me.Label157.Size = New System.Drawing.Size(224, 23)
        Me.Label157.TabIndex = 12
        Me.Label157.Text = "E M B A R A Z A D A S"
        '
        'Label138
        '
        Me.Label138.Location = New System.Drawing.Point(16, 8)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(224, 23)
        Me.Label138.TabIndex = 11
        Me.Label138.Text = "N O    E M B A R A Z A D A S"
        '
        'botImprimeIndicaciones
        '
        Me.botImprimeIndicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImprimeIndicaciones.Image = CType(resources.GetObject("botImprimeIndicaciones.Image"), System.Drawing.Image)
        Me.botImprimeIndicaciones.Location = New System.Drawing.Point(536, 440)
        Me.botImprimeIndicaciones.Name = "botImprimeIndicaciones"
        Me.botImprimeIndicaciones.Size = New System.Drawing.Size(224, 23)
        Me.botImprimeIndicaciones.TabIndex = 7
        Me.botImprimeIndicaciones.Text = "Prepara la Impresión"
        '
        'radIndVaginosisNEeco
        '
        Me.radIndVaginosisNEeco.Location = New System.Drawing.Point(8, 56)
        Me.radIndVaginosisNEeco.Name = "radIndVaginosisNEeco"
        Me.radIndVaginosisNEeco.Size = New System.Drawing.Size(360, 24)
        Me.radIndVaginosisNEeco.TabIndex = 10
        Me.radIndVaginosisNEeco.Text = "Vaginosis Bacteriana Gardnerella y Tricomoniasis (Económica)"
        '
        'radIndCandidiasisNE
        '
        Me.radIndCandidiasisNE.Location = New System.Drawing.Point(8, 32)
        Me.radIndCandidiasisNE.Name = "radIndCandidiasisNE"
        Me.radIndCandidiasisNE.Size = New System.Drawing.Size(352, 24)
        Me.radIndCandidiasisNE.TabIndex = 8
        Me.radIndCandidiasisNE.Text = "Candidiasis"
        '
        'radIndPrenatal
        '
        Me.radIndPrenatal.Checked = True
        Me.radIndPrenatal.Location = New System.Drawing.Point(392, 32)
        Me.radIndPrenatal.Name = "radIndPrenatal"
        Me.radIndPrenatal.Size = New System.Drawing.Size(360, 24)
        Me.radIndPrenatal.TabIndex = 0
        Me.radIndPrenatal.TabStop = True
        Me.radIndPrenatal.Text = "Rutina Prenatal"
        '
        'radINDCandidiasisE
        '
        Me.radINDCandidiasisE.Location = New System.Drawing.Point(392, 56)
        Me.radINDCandidiasisE.Name = "radINDCandidiasisE"
        Me.radINDCandidiasisE.Size = New System.Drawing.Size(360, 24)
        Me.radINDCandidiasisE.TabIndex = 9
        Me.radINDCandidiasisE.Text = "Candidiasis (2º y 3º trimestres del Embarazo)"
        '
        'TabLaboratorio
        '
        Me.TabLaboratorio.Controls.Add(Me.TabControl4)
        Me.TabLaboratorio.Location = New System.Drawing.Point(4, 22)
        Me.TabLaboratorio.Name = "TabLaboratorio"
        Me.TabLaboratorio.Size = New System.Drawing.Size(768, 478)
        Me.TabLaboratorio.TabIndex = 3
        Me.TabLaboratorio.Text = "Laboratorios y Estudios Frecuentes"
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TabPage6)
        Me.TabControl4.Controls.Add(Me.TabPage10)
        Me.TabControl4.Controls.Add(Me.TabPage11)
        Me.TabControl4.Controls.Add(Me.TabPage12)
        Me.TabControl4.Location = New System.Drawing.Point(8, 8)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(752, 464)
        Me.TabControl4.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Panel8)
        Me.TabPage6.Controls.Add(Me.Panel9)
        Me.TabPage6.Controls.Add(Me.botLabPrenatal)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(744, 438)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Rutina Prenatal"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.labLaboratorioPrenatal2)
        Me.Panel8.Location = New System.Drawing.Point(376, 8)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(360, 392)
        Me.Panel8.TabIndex = 8
        '
        'labLaboratorioPrenatal2
        '
        Me.labLaboratorioPrenatal2.Location = New System.Drawing.Point(7, 7)
        Me.labLaboratorioPrenatal2.Name = "labLaboratorioPrenatal2"
        Me.labLaboratorioPrenatal2.Size = New System.Drawing.Size(344, 376)
        Me.labLaboratorioPrenatal2.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.labLaboratorioPrenatal)
        Me.Panel9.Location = New System.Drawing.Point(8, 8)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(360, 392)
        Me.Panel9.TabIndex = 7
        '
        'labLaboratorioPrenatal
        '
        Me.labLaboratorioPrenatal.Location = New System.Drawing.Point(8, 8)
        Me.labLaboratorioPrenatal.Name = "labLaboratorioPrenatal"
        Me.labLaboratorioPrenatal.Size = New System.Drawing.Size(344, 376)
        Me.labLaboratorioPrenatal.TabIndex = 0
        '
        'botLabPrenatal
        '
        Me.botLabPrenatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botLabPrenatal.Image = CType(resources.GetObject("botLabPrenatal.Image"), System.Drawing.Image)
        Me.botLabPrenatal.Location = New System.Drawing.Point(513, 408)
        Me.botLabPrenatal.Name = "botLabPrenatal"
        Me.botLabPrenatal.Size = New System.Drawing.Size(224, 23)
        Me.botLabPrenatal.TabIndex = 6
        Me.botLabPrenatal.Text = "Prepara la Impresión"
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.botTripleta)
        Me.TabPage10.Controls.Add(Me.Panel14)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(744, 438)
        Me.TabPage10.TabIndex = 1
        Me.TabPage10.Text = "Tripleta"
        '
        'botTripleta
        '
        Me.botTripleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botTripleta.Image = CType(resources.GetObject("botTripleta.Image"), System.Drawing.Image)
        Me.botTripleta.Location = New System.Drawing.Point(512, 408)
        Me.botTripleta.Name = "botTripleta"
        Me.botTripleta.Size = New System.Drawing.Size(224, 23)
        Me.botTripleta.TabIndex = 7
        Me.botTripleta.Text = "Prepara la Impresión"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Label97)
        Me.Panel14.Controls.Add(Me.Label114)
        Me.Panel14.Controls.Add(Me.Label113)
        Me.Panel14.Controls.Add(Me.Label112)
        Me.Panel14.Controls.Add(Me.txtSemanas07)
        Me.Panel14.Controls.Add(Me.Label111)
        Me.Panel14.Controls.Add(Me.txtParidad07)
        Me.Panel14.Controls.Add(Me.Label107)
        Me.Panel14.Controls.Add(Me.Label99)
        Me.Panel14.Controls.Add(Me.Label101)
        Me.Panel14.Controls.Add(Me.txtEdad07)
        Me.Panel14.Controls.Add(Me.Label103)
        Me.Panel14.Controls.Add(Me.Label104)
        Me.Panel14.Controls.Add(Me.txtNombre07)
        Me.Panel14.Controls.Add(Me.txtMes07)
        Me.Panel14.Controls.Add(Me.Label105)
        Me.Panel14.Controls.Add(Me.txtAño07)
        Me.Panel14.Controls.Add(Me.txtCI07)
        Me.Panel14.Controls.Add(Me.Label106)
        Me.Panel14.Controls.Add(Me.Label108)
        Me.Panel14.Controls.Add(Me.txtDia07)
        Me.Panel14.Controls.Add(Me.Label109)
        Me.Panel14.Controls.Add(Me.Label110)
        Me.Panel14.Location = New System.Drawing.Point(120, 8)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(504, 336)
        Me.Panel14.TabIndex = 2
        '
        'Label97
        '
        Me.Label97.Location = New System.Drawing.Point(52, 253)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(184, 23)
        Me.Label97.TabIndex = 38
        Me.Label97.Text = "3.-  Estradiol no conjugado"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label114
        '
        Me.Label114.Location = New System.Drawing.Point(52, 229)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(184, 23)
        Me.Label114.TabIndex = 37
        Me.Label114.Text = "2.-  Gonadotropina"
        Me.Label114.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label113
        '
        Me.Label113.Location = New System.Drawing.Point(162, 123)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(52, 23)
        Me.Label113.TabIndex = 36
        Me.Label113.Text = "semanas"
        Me.Label113.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label112
        '
        Me.Label112.Location = New System.Drawing.Point(32, 123)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(100, 23)
        Me.Label112.TabIndex = 34
        Me.Label112.Text = "Edad Gestacional: "
        Me.Label112.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSemanas07
        '
        Me.txtSemanas07.BackColor = System.Drawing.Color.White
        Me.txtSemanas07.Location = New System.Drawing.Point(132, 123)
        Me.txtSemanas07.MaxLength = 2
        Me.txtSemanas07.Name = "txtSemanas07"
        Me.txtSemanas07.Size = New System.Drawing.Size(24, 20)
        Me.txtSemanas07.TabIndex = 35
        '
        'Label111
        '
        Me.Label111.Location = New System.Drawing.Point(128, 100)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(48, 23)
        Me.Label111.TabIndex = 32
        Me.Label111.Text = "Paridad: "
        Me.Label111.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtParidad07
        '
        Me.txtParidad07.BackColor = System.Drawing.Color.White
        Me.txtParidad07.Location = New System.Drawing.Point(180, 100)
        Me.txtParidad07.MaxLength = 30
        Me.txtParidad07.Name = "txtParidad07"
        Me.txtParidad07.Size = New System.Drawing.Size(180, 20)
        Me.txtParidad07.TabIndex = 33
        '
        'Label107
        '
        Me.Label107.Location = New System.Drawing.Point(32, 76)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(56, 23)
        Me.Label107.TabIndex = 31
        Me.Label107.Text = "Paciente:"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label99
        '
        Me.Label99.Location = New System.Drawing.Point(32, 52)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(52, 23)
        Me.Label99.TabIndex = 3
        Me.Label99.Text = "Fecha :"
        Me.Label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label101
        '
        Me.Label101.Location = New System.Drawing.Point(32, 100)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(44, 23)
        Me.Label101.TabIndex = 20
        Me.Label101.Text = "Edad: "
        Me.Label101.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEdad07
        '
        Me.txtEdad07.BackColor = System.Drawing.Color.White
        Me.txtEdad07.Location = New System.Drawing.Point(88, 100)
        Me.txtEdad07.MaxLength = 2
        Me.txtEdad07.Name = "txtEdad07"
        Me.txtEdad07.Size = New System.Drawing.Size(32, 20)
        Me.txtEdad07.TabIndex = 21
        '
        'Label103
        '
        Me.Label103.Location = New System.Drawing.Point(32, 177)
        Me.Label103.Name = "Label103"
        Me.Label103.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label103.Size = New System.Drawing.Size(392, 23)
        Me.Label103.TabIndex = 9
        Me.Label103.Text = "Se agradece realizar examen de tripleta bioquímica:"
        Me.Label103.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label104
        '
        Me.Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(136, 8)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(220, 23)
        Me.Label104.TabIndex = 0
        Me.Label104.Text = "LABORATORIO  ESPECIAL"
        Me.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre07
        '
        Me.txtNombre07.BackColor = System.Drawing.Color.White
        Me.txtNombre07.Location = New System.Drawing.Point(88, 76)
        Me.txtNombre07.MaxLength = 45
        Me.txtNombre07.Name = "txtNombre07"
        Me.txtNombre07.Size = New System.Drawing.Size(272, 20)
        Me.txtNombre07.TabIndex = 11
        '
        'txtMes07
        '
        Me.txtMes07.BackColor = System.Drawing.Color.White
        Me.txtMes07.Location = New System.Drawing.Point(152, 52)
        Me.txtMes07.MaxLength = 10
        Me.txtMes07.Name = "txtMes07"
        Me.txtMes07.Size = New System.Drawing.Size(88, 20)
        Me.txtMes07.TabIndex = 6
        '
        'Label105
        '
        Me.Label105.Location = New System.Drawing.Point(240, 48)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(24, 23)
        Me.Label105.TabIndex = 7
        Me.Label105.Text = "de"
        Me.Label105.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño07
        '
        Me.txtAño07.BackColor = System.Drawing.Color.White
        Me.txtAño07.Location = New System.Drawing.Point(264, 52)
        Me.txtAño07.MaxLength = 4
        Me.txtAño07.Name = "txtAño07"
        Me.txtAño07.Size = New System.Drawing.Size(80, 20)
        Me.txtAño07.TabIndex = 8
        '
        'txtCI07
        '
        Me.txtCI07.BackColor = System.Drawing.Color.White
        Me.txtCI07.Location = New System.Drawing.Point(404, 76)
        Me.txtCI07.MaxLength = 10
        Me.txtCI07.Name = "txtCI07"
        Me.txtCI07.Size = New System.Drawing.Size(80, 20)
        Me.txtCI07.TabIndex = 13
        '
        'Label106
        '
        Me.Label106.Location = New System.Drawing.Point(32, 297)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(444, 23)
        Me.Label106.TabIndex = 26
        Me.Label106.Text = "Atentamente."
        Me.Label106.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label108
        '
        Me.Label108.Location = New System.Drawing.Point(364, 76)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(40, 23)
        Me.Label108.TabIndex = 12
        Me.Label108.Text = ",  C.I. :"
        Me.Label108.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia07
        '
        Me.txtDia07.BackColor = System.Drawing.Color.White
        Me.txtDia07.Location = New System.Drawing.Point(88, 52)
        Me.txtDia07.MaxLength = 2
        Me.txtDia07.Name = "txtDia07"
        Me.txtDia07.Size = New System.Drawing.Size(32, 20)
        Me.txtDia07.TabIndex = 4
        '
        'Label109
        '
        Me.Label109.Location = New System.Drawing.Point(52, 205)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(184, 23)
        Me.Label109.TabIndex = 10
        Me.Label109.Text = "1.-  Alfa fetoproteína."
        Me.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label110
        '
        Me.Label110.Location = New System.Drawing.Point(128, 48)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(24, 23)
        Me.Label110.TabIndex = 5
        Me.Label110.Text = "de"
        Me.Label110.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.botEcoPerinatal)
        Me.TabPage11.Controls.Add(Me.Panel15)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(744, 438)
        Me.TabPage11.TabIndex = 2
        Me.TabPage11.Text = "Eco Perinatológico"
        '
        'botEcoPerinatal
        '
        Me.botEcoPerinatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEcoPerinatal.Image = CType(resources.GetObject("botEcoPerinatal.Image"), System.Drawing.Image)
        Me.botEcoPerinatal.Location = New System.Drawing.Point(512, 408)
        Me.botEcoPerinatal.Name = "botEcoPerinatal"
        Me.botEcoPerinatal.Size = New System.Drawing.Size(224, 23)
        Me.botEcoPerinatal.TabIndex = 7
        Me.botEcoPerinatal.Text = "Prepara la Impresión"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.txtFUR08)
        Me.Panel15.Controls.Add(Me.Label177)
        Me.Panel15.Controls.Add(Me.Label102)
        Me.Panel15.Controls.Add(Me.Label115)
        Me.Panel15.Controls.Add(Me.txtSemanas08)
        Me.Panel15.Controls.Add(Me.Label116)
        Me.Panel15.Controls.Add(Me.txtParidad08)
        Me.Panel15.Controls.Add(Me.Label117)
        Me.Panel15.Controls.Add(Me.Label118)
        Me.Panel15.Controls.Add(Me.Label119)
        Me.Panel15.Controls.Add(Me.txtEdad08)
        Me.Panel15.Controls.Add(Me.Label120)
        Me.Panel15.Controls.Add(Me.Label121)
        Me.Panel15.Controls.Add(Me.txtNombre08)
        Me.Panel15.Controls.Add(Me.txtMes08)
        Me.Panel15.Controls.Add(Me.Label122)
        Me.Panel15.Controls.Add(Me.txtAño08)
        Me.Panel15.Controls.Add(Me.txtCI08)
        Me.Panel15.Controls.Add(Me.Label123)
        Me.Panel15.Controls.Add(Me.Label124)
        Me.Panel15.Controls.Add(Me.txtDia08)
        Me.Panel15.Controls.Add(Me.Label126)
        Me.Panel15.Location = New System.Drawing.Point(120, 8)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(504, 336)
        Me.Panel15.TabIndex = 3
        '
        'txtFUR08
        '
        Me.txtFUR08.BackColor = System.Drawing.Color.White
        Me.txtFUR08.Location = New System.Drawing.Point(124, 148)
        Me.txtFUR08.MaxLength = 10
        Me.txtFUR08.Name = "txtFUR08"
        Me.txtFUR08.Size = New System.Drawing.Size(88, 20)
        Me.txtFUR08.TabIndex = 38
        '
        'Label177
        '
        Me.Label177.Location = New System.Drawing.Point(32, 146)
        Me.Label177.Name = "Label177"
        Me.Label177.Size = New System.Drawing.Size(88, 23)
        Me.Label177.TabIndex = 37
        Me.Label177.Text = "Según FUR del:"
        Me.Label177.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label102
        '
        Me.Label102.Location = New System.Drawing.Point(160, 123)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(52, 23)
        Me.Label102.TabIndex = 36
        Me.Label102.Text = "semanas"
        Me.Label102.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label115
        '
        Me.Label115.Location = New System.Drawing.Point(32, 123)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(100, 23)
        Me.Label115.TabIndex = 34
        Me.Label115.Text = "Edad Gestacional: "
        Me.Label115.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSemanas08
        '
        Me.txtSemanas08.BackColor = System.Drawing.Color.White
        Me.txtSemanas08.Location = New System.Drawing.Point(132, 123)
        Me.txtSemanas08.MaxLength = 2
        Me.txtSemanas08.Name = "txtSemanas08"
        Me.txtSemanas08.Size = New System.Drawing.Size(24, 20)
        Me.txtSemanas08.TabIndex = 35
        '
        'Label116
        '
        Me.Label116.Location = New System.Drawing.Point(128, 100)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(48, 23)
        Me.Label116.TabIndex = 32
        Me.Label116.Text = "Paridad: "
        Me.Label116.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtParidad08
        '
        Me.txtParidad08.BackColor = System.Drawing.Color.White
        Me.txtParidad08.Location = New System.Drawing.Point(180, 100)
        Me.txtParidad08.MaxLength = 30
        Me.txtParidad08.Name = "txtParidad08"
        Me.txtParidad08.Size = New System.Drawing.Size(180, 20)
        Me.txtParidad08.TabIndex = 33
        '
        'Label117
        '
        Me.Label117.Location = New System.Drawing.Point(32, 76)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(56, 23)
        Me.Label117.TabIndex = 31
        Me.Label117.Text = "Paciente:"
        Me.Label117.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label118
        '
        Me.Label118.Location = New System.Drawing.Point(32, 52)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(52, 23)
        Me.Label118.TabIndex = 3
        Me.Label118.Text = "Fecha :"
        Me.Label118.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label119
        '
        Me.Label119.Location = New System.Drawing.Point(32, 100)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(44, 23)
        Me.Label119.TabIndex = 20
        Me.Label119.Text = "Edad: "
        Me.Label119.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEdad08
        '
        Me.txtEdad08.BackColor = System.Drawing.Color.White
        Me.txtEdad08.Location = New System.Drawing.Point(88, 100)
        Me.txtEdad08.MaxLength = 2
        Me.txtEdad08.Name = "txtEdad08"
        Me.txtEdad08.Size = New System.Drawing.Size(32, 20)
        Me.txtEdad08.TabIndex = 21
        '
        'Label120
        '
        Me.Label120.Location = New System.Drawing.Point(32, 195)
        Me.Label120.Name = "Label120"
        Me.Label120.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label120.Size = New System.Drawing.Size(392, 23)
        Me.Label120.TabIndex = 9
        Me.Label120.Text = "Se agradece realizar ESTUDIO ECOGRAFICO PERINATOLOGICO."
        Me.Label120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label121
        '
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.Location = New System.Drawing.Point(136, 8)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(220, 23)
        Me.Label121.TabIndex = 0
        Me.Label121.Text = "ECOGRAFIA  PERINATOLOGICA"
        Me.Label121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre08
        '
        Me.txtNombre08.BackColor = System.Drawing.Color.White
        Me.txtNombre08.Location = New System.Drawing.Point(88, 76)
        Me.txtNombre08.MaxLength = 45
        Me.txtNombre08.Name = "txtNombre08"
        Me.txtNombre08.Size = New System.Drawing.Size(272, 20)
        Me.txtNombre08.TabIndex = 11
        '
        'txtMes08
        '
        Me.txtMes08.BackColor = System.Drawing.Color.White
        Me.txtMes08.Location = New System.Drawing.Point(152, 52)
        Me.txtMes08.MaxLength = 10
        Me.txtMes08.Name = "txtMes08"
        Me.txtMes08.Size = New System.Drawing.Size(88, 20)
        Me.txtMes08.TabIndex = 6
        '
        'Label122
        '
        Me.Label122.Location = New System.Drawing.Point(240, 48)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(24, 23)
        Me.Label122.TabIndex = 7
        Me.Label122.Text = "de"
        Me.Label122.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño08
        '
        Me.txtAño08.BackColor = System.Drawing.Color.White
        Me.txtAño08.Location = New System.Drawing.Point(264, 52)
        Me.txtAño08.MaxLength = 4
        Me.txtAño08.Name = "txtAño08"
        Me.txtAño08.Size = New System.Drawing.Size(80, 20)
        Me.txtAño08.TabIndex = 8
        '
        'txtCI08
        '
        Me.txtCI08.BackColor = System.Drawing.Color.White
        Me.txtCI08.Location = New System.Drawing.Point(404, 76)
        Me.txtCI08.MaxLength = 10
        Me.txtCI08.Name = "txtCI08"
        Me.txtCI08.Size = New System.Drawing.Size(80, 20)
        Me.txtCI08.TabIndex = 13
        '
        'Label123
        '
        Me.Label123.Location = New System.Drawing.Point(32, 235)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(444, 23)
        Me.Label123.TabIndex = 26
        Me.Label123.Text = "Atentamente."
        Me.Label123.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label124
        '
        Me.Label124.Location = New System.Drawing.Point(364, 76)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(40, 23)
        Me.Label124.TabIndex = 12
        Me.Label124.Text = ",  C.I. :"
        Me.Label124.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia08
        '
        Me.txtDia08.BackColor = System.Drawing.Color.White
        Me.txtDia08.Location = New System.Drawing.Point(88, 52)
        Me.txtDia08.MaxLength = 2
        Me.txtDia08.Name = "txtDia08"
        Me.txtDia08.Size = New System.Drawing.Size(32, 20)
        Me.txtDia08.TabIndex = 4
        '
        'Label126
        '
        Me.Label126.Location = New System.Drawing.Point(128, 48)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(24, 23)
        Me.Label126.TabIndex = 5
        Me.Label126.Text = "de"
        Me.Label126.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.botPreoperatorio)
        Me.TabPage12.Controls.Add(Me.Panel17)
        Me.TabPage12.Controls.Add(Me.Panel16)
        Me.TabPage12.Location = New System.Drawing.Point(4, 22)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(744, 438)
        Me.TabPage12.TabIndex = 3
        Me.TabPage12.Text = "Evaluaciones Preoperatorias"
        '
        'botPreoperatorio
        '
        Me.botPreoperatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botPreoperatorio.Image = CType(resources.GetObject("botPreoperatorio.Image"), System.Drawing.Image)
        Me.botPreoperatorio.Location = New System.Drawing.Point(512, 408)
        Me.botPreoperatorio.Name = "botPreoperatorio"
        Me.botPreoperatorio.Size = New System.Drawing.Size(224, 23)
        Me.botPreoperatorio.TabIndex = 7
        Me.botPreoperatorio.Text = "Prepara la Impresión"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Controls.Add(Me.txtHoraProp10)
        Me.Panel17.Controls.Add(Me.Label139)
        Me.Panel17.Controls.Add(Me.txtFechaProp10)
        Me.Panel17.Controls.Add(Me.Label140)
        Me.Panel17.Controls.Add(Me.Label141)
        Me.Panel17.Controls.Add(Me.txtOp10)
        Me.Panel17.Controls.Add(Me.Label142)
        Me.Panel17.Controls.Add(Me.Label143)
        Me.Panel17.Controls.Add(Me.txtSemanas10)
        Me.Panel17.Controls.Add(Me.Label144)
        Me.Panel17.Controls.Add(Me.txtParidad10)
        Me.Panel17.Controls.Add(Me.Label145)
        Me.Panel17.Controls.Add(Me.Label146)
        Me.Panel17.Controls.Add(Me.Label147)
        Me.Panel17.Controls.Add(Me.txtEdad10)
        Me.Panel17.Controls.Add(Me.Label148)
        Me.Panel17.Controls.Add(Me.Label149)
        Me.Panel17.Controls.Add(Me.txtNombre10)
        Me.Panel17.Controls.Add(Me.txtMes10)
        Me.Panel17.Controls.Add(Me.Label150)
        Me.Panel17.Controls.Add(Me.txtAño10)
        Me.Panel17.Controls.Add(Me.txtCI10)
        Me.Panel17.Controls.Add(Me.Label151)
        Me.Panel17.Controls.Add(Me.Label152)
        Me.Panel17.Controls.Add(Me.txtDia10)
        Me.Panel17.Controls.Add(Me.Label153)
        Me.Panel17.Location = New System.Drawing.Point(376, 8)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(360, 392)
        Me.Panel17.TabIndex = 5
        '
        'txtHoraProp10
        '
        Me.txtHoraProp10.BackColor = System.Drawing.Color.White
        Me.txtHoraProp10.Location = New System.Drawing.Point(136, 300)
        Me.txtHoraProp10.MaxLength = 10
        Me.txtHoraProp10.Name = "txtHoraProp10"
        Me.txtHoraProp10.Size = New System.Drawing.Size(80, 20)
        Me.txtHoraProp10.TabIndex = 42
        '
        'Label139
        '
        Me.Label139.Location = New System.Drawing.Point(12, 300)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(124, 23)
        Me.Label139.TabIndex = 41
        Me.Label139.Text = "Hora Propuesta: "
        Me.Label139.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaProp10
        '
        Me.txtFechaProp10.BackColor = System.Drawing.Color.White
        Me.txtFechaProp10.Location = New System.Drawing.Point(136, 272)
        Me.txtFechaProp10.MaxLength = 10
        Me.txtFechaProp10.Name = "txtFechaProp10"
        Me.txtFechaProp10.Size = New System.Drawing.Size(152, 20)
        Me.txtFechaProp10.TabIndex = 40
        '
        'Label140
        '
        Me.Label140.Location = New System.Drawing.Point(12, 272)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(124, 23)
        Me.Label140.TabIndex = 39
        Me.Label140.Text = "Fecha Propuesta: "
        Me.Label140.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label141
        '
        Me.Label141.Location = New System.Drawing.Point(8, 212)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(124, 23)
        Me.Label141.TabIndex = 38
        Me.Label141.Text = "Intervención Propuesta: "
        Me.Label141.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOp10
        '
        Me.txtOp10.BackColor = System.Drawing.Color.White
        Me.txtOp10.Location = New System.Drawing.Point(8, 236)
        Me.txtOp10.MaxLength = 45
        Me.txtOp10.Name = "txtOp10"
        Me.txtOp10.Size = New System.Drawing.Size(344, 20)
        Me.txtOp10.TabIndex = 37
        '
        'Label142
        '
        Me.Label142.Location = New System.Drawing.Point(136, 144)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(52, 23)
        Me.Label142.TabIndex = 36
        Me.Label142.Text = "semanas"
        Me.Label142.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label143
        '
        Me.Label143.Location = New System.Drawing.Point(8, 144)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(100, 23)
        Me.Label143.TabIndex = 34
        Me.Label143.Text = "Edad Gestacional: "
        Me.Label143.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSemanas10
        '
        Me.txtSemanas10.BackColor = System.Drawing.Color.White
        Me.txtSemanas10.Location = New System.Drawing.Point(108, 144)
        Me.txtSemanas10.MaxLength = 2
        Me.txtSemanas10.Name = "txtSemanas10"
        Me.txtSemanas10.Size = New System.Drawing.Size(24, 20)
        Me.txtSemanas10.TabIndex = 35
        '
        'Label144
        '
        Me.Label144.Location = New System.Drawing.Point(8, 120)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(48, 23)
        Me.Label144.TabIndex = 32
        Me.Label144.Text = "Paridad: "
        Me.Label144.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtParidad10
        '
        Me.txtParidad10.BackColor = System.Drawing.Color.White
        Me.txtParidad10.Location = New System.Drawing.Point(64, 120)
        Me.txtParidad10.MaxLength = 30
        Me.txtParidad10.Name = "txtParidad10"
        Me.txtParidad10.Size = New System.Drawing.Size(180, 20)
        Me.txtParidad10.TabIndex = 33
        '
        'Label145
        '
        Me.Label145.Location = New System.Drawing.Point(8, 72)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(56, 23)
        Me.Label145.TabIndex = 31
        Me.Label145.Text = "Paciente:"
        Me.Label145.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label146
        '
        Me.Label146.Location = New System.Drawing.Point(8, 48)
        Me.Label146.Name = "Label146"
        Me.Label146.Size = New System.Drawing.Size(52, 23)
        Me.Label146.TabIndex = 3
        Me.Label146.Text = "Fecha :"
        Me.Label146.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label147
        '
        Me.Label147.Location = New System.Drawing.Point(156, 96)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(44, 23)
        Me.Label147.TabIndex = 20
        Me.Label147.Text = "Edad: "
        Me.Label147.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEdad10
        '
        Me.txtEdad10.BackColor = System.Drawing.Color.White
        Me.txtEdad10.Location = New System.Drawing.Point(212, 96)
        Me.txtEdad10.MaxLength = 2
        Me.txtEdad10.Name = "txtEdad10"
        Me.txtEdad10.Size = New System.Drawing.Size(32, 20)
        Me.txtEdad10.TabIndex = 21
        '
        'Label148
        '
        Me.Label148.Location = New System.Drawing.Point(8, 180)
        Me.Label148.Name = "Label148"
        Me.Label148.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label148.Size = New System.Drawing.Size(348, 24)
        Me.Label148.TabIndex = 9
        Me.Label148.Text = "Se agradece realizar EVALUACION ANESTESICA PREOPERATORIA."
        Me.Label148.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label149
        '
        Me.Label149.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label149.Location = New System.Drawing.Point(8, 8)
        Me.Label149.Name = "Label149"
        Me.Label149.Size = New System.Drawing.Size(348, 23)
        Me.Label149.TabIndex = 0
        Me.Label149.Text = "EVALUACION ANESTESICA PREOPERATORIA"
        Me.Label149.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre10
        '
        Me.txtNombre10.BackColor = System.Drawing.Color.White
        Me.txtNombre10.Location = New System.Drawing.Point(64, 72)
        Me.txtNombre10.MaxLength = 45
        Me.txtNombre10.Name = "txtNombre10"
        Me.txtNombre10.Size = New System.Drawing.Size(272, 20)
        Me.txtNombre10.TabIndex = 11
        '
        'txtMes10
        '
        Me.txtMes10.BackColor = System.Drawing.Color.White
        Me.txtMes10.Location = New System.Drawing.Point(128, 48)
        Me.txtMes10.MaxLength = 10
        Me.txtMes10.Name = "txtMes10"
        Me.txtMes10.Size = New System.Drawing.Size(88, 20)
        Me.txtMes10.TabIndex = 6
        '
        'Label150
        '
        Me.Label150.Location = New System.Drawing.Point(216, 44)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(24, 23)
        Me.Label150.TabIndex = 7
        Me.Label150.Text = "de"
        Me.Label150.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño10
        '
        Me.txtAño10.BackColor = System.Drawing.Color.White
        Me.txtAño10.Location = New System.Drawing.Point(240, 48)
        Me.txtAño10.MaxLength = 4
        Me.txtAño10.Name = "txtAño10"
        Me.txtAño10.Size = New System.Drawing.Size(80, 20)
        Me.txtAño10.TabIndex = 8
        '
        'txtCI10
        '
        Me.txtCI10.BackColor = System.Drawing.Color.White
        Me.txtCI10.Location = New System.Drawing.Point(64, 96)
        Me.txtCI10.MaxLength = 10
        Me.txtCI10.Name = "txtCI10"
        Me.txtCI10.Size = New System.Drawing.Size(80, 20)
        Me.txtCI10.TabIndex = 13
        '
        'Label151
        '
        Me.Label151.Location = New System.Drawing.Point(20, 364)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(260, 23)
        Me.Label151.TabIndex = 26
        Me.Label151.Text = "Atentamente."
        Me.Label151.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label152
        '
        Me.Label152.Location = New System.Drawing.Point(8, 96)
        Me.Label152.Name = "Label152"
        Me.Label152.Size = New System.Drawing.Size(40, 23)
        Me.Label152.TabIndex = 12
        Me.Label152.Text = "C.I. :"
        Me.Label152.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia10
        '
        Me.txtDia10.BackColor = System.Drawing.Color.White
        Me.txtDia10.Location = New System.Drawing.Point(64, 48)
        Me.txtDia10.MaxLength = 2
        Me.txtDia10.Name = "txtDia10"
        Me.txtDia10.Size = New System.Drawing.Size(32, 20)
        Me.txtDia10.TabIndex = 4
        '
        'Label153
        '
        Me.Label153.Location = New System.Drawing.Point(104, 44)
        Me.Label153.Name = "Label153"
        Me.Label153.Size = New System.Drawing.Size(24, 23)
        Me.Label153.TabIndex = 5
        Me.Label153.Text = "de"
        Me.Label153.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.txtOp09)
        Me.Panel16.Controls.Add(Me.Label156)
        Me.Panel16.Controls.Add(Me.txtIdx09c)
        Me.Panel16.Controls.Add(Me.Label155)
        Me.Panel16.Controls.Add(Me.txtIdx09b)
        Me.Panel16.Controls.Add(Me.Label154)
        Me.Panel16.Controls.Add(Me.Label137)
        Me.Panel16.Controls.Add(Me.Label136)
        Me.Panel16.Controls.Add(Me.txtIdx09a)
        Me.Panel16.Controls.Add(Me.Label98)
        Me.Panel16.Controls.Add(Me.Label100)
        Me.Panel16.Controls.Add(Me.txtSemanas09)
        Me.Panel16.Controls.Add(Me.Label125)
        Me.Panel16.Controls.Add(Me.txtParidad09)
        Me.Panel16.Controls.Add(Me.Label127)
        Me.Panel16.Controls.Add(Me.Label128)
        Me.Panel16.Controls.Add(Me.Label129)
        Me.Panel16.Controls.Add(Me.txtEdad09)
        Me.Panel16.Controls.Add(Me.Label130)
        Me.Panel16.Controls.Add(Me.Label131)
        Me.Panel16.Controls.Add(Me.txtNombre09)
        Me.Panel16.Controls.Add(Me.txtMes09)
        Me.Panel16.Controls.Add(Me.Label132)
        Me.Panel16.Controls.Add(Me.txtAño09)
        Me.Panel16.Controls.Add(Me.txtCI09)
        Me.Panel16.Controls.Add(Me.Label133)
        Me.Panel16.Controls.Add(Me.Label134)
        Me.Panel16.Controls.Add(Me.txtDia09)
        Me.Panel16.Controls.Add(Me.Label135)
        Me.Panel16.Location = New System.Drawing.Point(8, 8)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(360, 392)
        Me.Panel16.TabIndex = 4
        '
        'txtOp09
        '
        Me.txtOp09.BackColor = System.Drawing.Color.White
        Me.txtOp09.Location = New System.Drawing.Point(8, 336)
        Me.txtOp09.MaxLength = 45
        Me.txtOp09.Name = "txtOp09"
        Me.txtOp09.Size = New System.Drawing.Size(344, 20)
        Me.txtOp09.TabIndex = 47
        '
        'Label156
        '
        Me.Label156.Location = New System.Drawing.Point(9, 284)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(24, 23)
        Me.Label156.TabIndex = 46
        Me.Label156.Text = "3.-"
        Me.Label156.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdx09c
        '
        Me.txtIdx09c.BackColor = System.Drawing.Color.White
        Me.txtIdx09c.Location = New System.Drawing.Point(33, 284)
        Me.txtIdx09c.MaxLength = 45
        Me.txtIdx09c.Name = "txtIdx09c"
        Me.txtIdx09c.Size = New System.Drawing.Size(316, 20)
        Me.txtIdx09c.TabIndex = 45
        '
        'Label155
        '
        Me.Label155.Location = New System.Drawing.Point(9, 260)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(24, 23)
        Me.Label155.TabIndex = 44
        Me.Label155.Text = "2.-"
        Me.Label155.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdx09b
        '
        Me.txtIdx09b.BackColor = System.Drawing.Color.White
        Me.txtIdx09b.Location = New System.Drawing.Point(33, 260)
        Me.txtIdx09b.MaxLength = 45
        Me.txtIdx09b.Name = "txtIdx09b"
        Me.txtIdx09b.Size = New System.Drawing.Size(316, 20)
        Me.txtIdx09b.TabIndex = 43
        '
        'Label154
        '
        Me.Label154.Location = New System.Drawing.Point(8, 236)
        Me.Label154.Name = "Label154"
        Me.Label154.Size = New System.Drawing.Size(24, 23)
        Me.Label154.TabIndex = 42
        Me.Label154.Text = "1.-"
        Me.Label154.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label137
        '
        Me.Label137.Location = New System.Drawing.Point(8, 208)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(124, 23)
        Me.Label137.TabIndex = 39
        Me.Label137.Text = "Impresión Diagnóstica:"
        Me.Label137.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label136
        '
        Me.Label136.Location = New System.Drawing.Point(8, 312)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(124, 23)
        Me.Label136.TabIndex = 38
        Me.Label136.Text = "Intervención Propuesta: "
        Me.Label136.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdx09a
        '
        Me.txtIdx09a.BackColor = System.Drawing.Color.White
        Me.txtIdx09a.Location = New System.Drawing.Point(32, 236)
        Me.txtIdx09a.MaxLength = 45
        Me.txtIdx09a.Name = "txtIdx09a"
        Me.txtIdx09a.Size = New System.Drawing.Size(316, 20)
        Me.txtIdx09a.TabIndex = 37
        '
        'Label98
        '
        Me.Label98.Location = New System.Drawing.Point(136, 144)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(52, 23)
        Me.Label98.TabIndex = 36
        Me.Label98.Text = "semanas"
        Me.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label100
        '
        Me.Label100.Location = New System.Drawing.Point(8, 144)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(100, 23)
        Me.Label100.TabIndex = 34
        Me.Label100.Text = "Edad Gestacional: "
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSemanas09
        '
        Me.txtSemanas09.BackColor = System.Drawing.Color.White
        Me.txtSemanas09.Location = New System.Drawing.Point(108, 144)
        Me.txtSemanas09.MaxLength = 2
        Me.txtSemanas09.Name = "txtSemanas09"
        Me.txtSemanas09.Size = New System.Drawing.Size(24, 20)
        Me.txtSemanas09.TabIndex = 35
        '
        'Label125
        '
        Me.Label125.Location = New System.Drawing.Point(8, 120)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(48, 23)
        Me.Label125.TabIndex = 32
        Me.Label125.Text = "Paridad: "
        Me.Label125.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtParidad09
        '
        Me.txtParidad09.BackColor = System.Drawing.Color.White
        Me.txtParidad09.Location = New System.Drawing.Point(64, 120)
        Me.txtParidad09.MaxLength = 30
        Me.txtParidad09.Name = "txtParidad09"
        Me.txtParidad09.Size = New System.Drawing.Size(180, 20)
        Me.txtParidad09.TabIndex = 33
        '
        'Label127
        '
        Me.Label127.Location = New System.Drawing.Point(8, 72)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(56, 23)
        Me.Label127.TabIndex = 31
        Me.Label127.Text = "Paciente:"
        Me.Label127.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label128
        '
        Me.Label128.Location = New System.Drawing.Point(8, 48)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(52, 23)
        Me.Label128.TabIndex = 3
        Me.Label128.Text = "Fecha :"
        Me.Label128.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label129
        '
        Me.Label129.Location = New System.Drawing.Point(156, 96)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(44, 23)
        Me.Label129.TabIndex = 20
        Me.Label129.Text = "Edad: "
        Me.Label129.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEdad09
        '
        Me.txtEdad09.BackColor = System.Drawing.Color.White
        Me.txtEdad09.Location = New System.Drawing.Point(212, 96)
        Me.txtEdad09.MaxLength = 2
        Me.txtEdad09.Name = "txtEdad09"
        Me.txtEdad09.Size = New System.Drawing.Size(32, 20)
        Me.txtEdad09.TabIndex = 21
        '
        'Label130
        '
        Me.Label130.Location = New System.Drawing.Point(8, 180)
        Me.Label130.Name = "Label130"
        Me.Label130.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label130.Size = New System.Drawing.Size(340, 24)
        Me.Label130.TabIndex = 9
        Me.Label130.Text = "Se agradece realizar EVALUACION CARDIOVASCULAR PREOPERATORIA."
        Me.Label130.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label131
        '
        Me.Label131.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.Location = New System.Drawing.Point(4, 8)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(348, 23)
        Me.Label131.TabIndex = 0
        Me.Label131.Text = "EVALUACION CARDIOVASCULAR PREOPERATORIA"
        Me.Label131.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre09
        '
        Me.txtNombre09.BackColor = System.Drawing.Color.White
        Me.txtNombre09.Location = New System.Drawing.Point(64, 72)
        Me.txtNombre09.MaxLength = 45
        Me.txtNombre09.Name = "txtNombre09"
        Me.txtNombre09.Size = New System.Drawing.Size(272, 20)
        Me.txtNombre09.TabIndex = 11
        '
        'txtMes09
        '
        Me.txtMes09.BackColor = System.Drawing.Color.White
        Me.txtMes09.Location = New System.Drawing.Point(128, 48)
        Me.txtMes09.MaxLength = 10
        Me.txtMes09.Name = "txtMes09"
        Me.txtMes09.Size = New System.Drawing.Size(88, 20)
        Me.txtMes09.TabIndex = 6
        '
        'Label132
        '
        Me.Label132.Location = New System.Drawing.Point(216, 44)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(24, 23)
        Me.Label132.TabIndex = 7
        Me.Label132.Text = "de"
        Me.Label132.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAño09
        '
        Me.txtAño09.BackColor = System.Drawing.Color.White
        Me.txtAño09.Location = New System.Drawing.Point(240, 48)
        Me.txtAño09.MaxLength = 4
        Me.txtAño09.Name = "txtAño09"
        Me.txtAño09.Size = New System.Drawing.Size(80, 20)
        Me.txtAño09.TabIndex = 8
        '
        'txtCI09
        '
        Me.txtCI09.BackColor = System.Drawing.Color.White
        Me.txtCI09.Location = New System.Drawing.Point(64, 96)
        Me.txtCI09.MaxLength = 10
        Me.txtCI09.Name = "txtCI09"
        Me.txtCI09.Size = New System.Drawing.Size(80, 20)
        Me.txtCI09.TabIndex = 13
        '
        'Label133
        '
        Me.Label133.Location = New System.Drawing.Point(20, 364)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(260, 23)
        Me.Label133.TabIndex = 26
        Me.Label133.Text = "Atentamente."
        Me.Label133.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label134
        '
        Me.Label134.Location = New System.Drawing.Point(8, 96)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(40, 23)
        Me.Label134.TabIndex = 12
        Me.Label134.Text = "C.I. :"
        Me.Label134.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia09
        '
        Me.txtDia09.BackColor = System.Drawing.Color.White
        Me.txtDia09.Location = New System.Drawing.Point(64, 48)
        Me.txtDia09.MaxLength = 2
        Me.txtDia09.Name = "txtDia09"
        Me.txtDia09.Size = New System.Drawing.Size(32, 20)
        Me.txtDia09.TabIndex = 4
        '
        'Label135
        '
        Me.Label135.Location = New System.Drawing.Point(104, 44)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(24, 23)
        Me.Label135.TabIndex = 5
        Me.Label135.Text = "de"
        Me.Label135.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormRecipes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(790, 548)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormRecipes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Récipes y Papelería"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageRecipes.ResumeLayout(False)
        Me.TabPageRecipes.PerformLayout()
        Me.TabPageConstancias.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabIndicaciones.ResumeLayout(False)
        Me.TabLaboratorio.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.TabPage12.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image

    Dim NombreBaseDatosMedicamentos As String
    Public Shared Path As String
    Dim Farmacos As New ArrayList()
    Dim Tipo1 As New ArrayList()
    Dim Tipo2 As New ArrayList()
    Dim Tipo3 As New ArrayList()
    Dim Tipo4 As New ArrayList()
    Dim Tipo5 As New ArrayList()
    Dim Tipo6 As New ArrayList()
    Dim Tipo7 As New ArrayList()
    Dim Tipo8 As New ArrayList()
    Dim Tipo9 As New ArrayList()
    Dim Tipo10 As New ArrayList()
    Dim Tipo11 As New ArrayList()
    Dim Tipo12 As New ArrayList()
    Dim Tipo13 As New ArrayList()
    Dim Tipo14 As New ArrayList()
    Dim Tipo15 As New ArrayList()
    Dim Tipo16 As New ArrayList()
    Dim Tipo17 As New ArrayList()
    Dim Tipo18 As New ArrayList()

    Dim MensajeDeBaseSinDatos As String
    Dim MensajeDeNoPasoFiltro As String

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


    Dim PasoporlaDeselecciondelRecipe As Boolean

    Public Shared NumerodeMedicamentosEnElRecipe As Integer
    Public Shared MedicamentosEnElRecipe(3) As String

    'variables de los recipes fijos
    Dim varRPPrenatal As String
    Dim varINDPrenatales As String
    Dim varRPCandidiasisNE As String
    Dim varINDCandidiasisNE As String
    Dim varRPCandidiasisE As String
    Dim varINDCandidiasisE As String
    Dim varRPvaginosisNEeco As String
    Dim varINDvaginosisNEeco As String
    Dim varRPvaginosisNEok As String
    Dim varINDvaginosisNEok As String
    Dim varRPvaginosisMixtaNE As String
    Dim varINDvaginosisMixtaNE As String








    Dim Filtro As Boolean
    Dim TipoFarmaco As Integer

    'variables de la parte de la papeleria
    Dim Texto As String

    Private Sub FormRecipes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated


        If Form1.estPacienteAbierta.a01strNombre = "" Then
            Me.Text = "Récipes y Papelería - No se ha seleccionado una historia."
            LimpiaCasillas()
        Else
            RellenaCasillasConDatos()
        End If
    End Sub

    Private Sub FormRecipes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Form1.RecipesAbierto = True
        ConfiguracionBaseDatosNoCargada()
        PasoporlaDeselecciondelRecipe = False

        'carga las indicaciones fijas 
        CargaRecipesFijos()

    End Sub

    Private Sub RellenaCasillasConDatos()
        Dim strNombreActual As String
        Dim strCedulaActual As String
        Dim strEdadActual As String
        Dim strParidadActual As String
        Dim Hoy As String = ""
        Dim Mes As String = ""
        Dim Año As String = ""

        Hoy = Today.Day.ToString
        Mes = Today.Month.ToString
        Select Case Mes
            Case "1"
                Mes = "Enero"
            Case "2"
                Mes = "Febrero"
            Case "3"
                Mes = "Marzo"
            Case "4"
                Mes = "Abril"
            Case "5"
                Mes = "Mayo"
            Case "6"
                Mes = "Junio"
            Case "7"
                Mes = "Julio"
            Case "8"
                Mes = "Agosto"
            Case "9"
                Mes = "Septiembre"
            Case "10"
                Mes = "Octubre"
            Case "11"
                Mes = "Noviembre"
            Case "12"
                Mes = "Diciembre"
            Case Else
                'creo q no puede pasar pero...
                Mes = "Otro mes"
        End Select
        'Mes = Today.Month.ToString
        Año = Today.Year.ToString

        'carga las variables locales con las publicas en la estructura de form1
        strNombreActual = Form1.estPacienteAbierta.a01strNombre
        strCedulaActual = Form1.estPacienteAbierta.a02strCedula
        If Form1.estPacienteAbierta.a04intEdadActual <> -1 Then
            strEdadActual = Form1.estPacienteAbierta.a04intEdadActual.ToString
        Else
            strEdadActual = ""
        End If
        strParidadActual = Form1.estPacienteAbierta.a05strParidad

        'los nombres (son 10)
        txtNombre01.Text = strNombreActual
        txtNombre02.Text = strNombreActual
        txtNombre03.Text = strNombreActual
        txtNombre04.Text = strNombreActual
        txtNombre05.Text = strNombreActual
        txtNombre06.Text = strNombreActual
        txtNombre07.Text = strNombreActual
        txtNombre08.Text = strNombreActual
        txtNombre09.Text = strNombreActual
        txtNombre10.Text = strNombreActual
        txtNombre11.Text = strNombreActual
        'las edades (son 4)
        If strEdadActual <> "" Then
            txtEdad07.Text = strEdadActual
            txtEdad08.Text = strEdadActual
            txtEdad09.Text = strEdadActual
            txtEdad10.Text = strEdadActual
        Else
            txtEdad07.Text = "n/a"
            txtEdad08.Text = "n/a"
            txtEdad09.Text = "n/a"
            txtEdad10.Text = "n/a"
        End If

        'las Cedulas
        strCedulaActual = strCedulaActual.Substring(0, 2) & "." & strCedulaActual.Substring(2, 3) & "." & strCedulaActual.Substring(5, 3)
        If strCedulaActual(0) = "0" Then
            strCedulaActual = strCedulaActual.Remove(0, 1)
        End If
        txtCI01.Text = strCedulaActual
        txtCI02.Text = strCedulaActual
        txtCI03.Text = strCedulaActual
        txtCI04.Text = strCedulaActual
        txtCI05.Text = strCedulaActual
        txtCI06.Text = strCedulaActual
        txtCI07.Text = strCedulaActual
        txtCI08.Text = strCedulaActual
        txtCI09.Text = strCedulaActual
        txtCI10.Text = strCedulaActual
        txtCI11.Text = strCedulaActual
        'la paridad (son 4)
        txtParidad07.Text = strParidadActual
        txtParidad08.Text = strParidadActual
        txtParidad09.Text = strParidadActual
        txtParidad10.Text = strParidadActual
        'las fechas
        txtDia01.Text = Hoy
        txtMes01.Text = Mes
        txtAño01.Text = Año
        txtDia02.Text = Hoy
        txtMes02.Text = Mes
        txtAño02.Text = Año
        txtDia03.Text = Hoy
        txtMes03.Text = Mes
        txtAño03.Text = Año
        txtDia04.Text = Hoy
        txtMes04.Text = Mes
        txtAño04.Text = Año
        txtDia05.Text = Hoy
        txtMes05.Text = Mes
        txtAño05.Text = Año
        txtDia06.Text = Hoy
        txtMes06.Text = Mes
        txtAño06.Text = Año
        txtDia07.Text = Hoy
        txtMes07.Text = Mes
        txtAño07.Text = Año
        txtDia08.Text = Hoy
        txtMes08.Text = Mes
        txtAño08.Text = Año
        txtDia09.Text = Hoy
        txtMes09.Text = Mes
        txtAño09.Text = Año
        txtDia10.Text = Hoy
        txtMes10.Text = Mes
        txtAño10.Text = Año
        txtDia11.Text = Hoy
        txtMes11.Text = Mes
        txtAño11.Text = Año

        'la ciudad
        txtCiudad.Text = "Valencia"
        txtCiudad02.Text = "Valencia"

        'el medico
        txtDoctor01.Text = Form1.UsuarioNombre
        txtDoctor02.Text = Form1.UsuarioNombre
        txtDoctor11.Text = Form1.UsuarioNombre

        'la cedula del medico (es absoluta porq no se registra en los datos de esta version del prog)
        txtDrCI01.Text = "9.440.392"
        txtDrCI02.Text = "9.440.392"
        txtDrCI11.Text = "9.440.392"

        'barra de titulo con datos...
        Me.Text = "Récipes y Papelería - Historia Seleccionada: " & strNombreActual & " CI: " & strCedulaActual
        If strEdadActual <> "" Then
            Me.Text += " - Edad: " & strEdadActual & " años"
        End If
    End Sub

    Private Sub LimpiaCasillas()
        txtNombre01.Clear()
        txtNombre02.Clear()
        txtNombre03.Clear()
        txtNombre04.Clear()
        txtNombre05.Clear()
        txtNombre06.Clear()
        txtNombre07.Clear()
        txtNombre08.Clear()
        txtNombre09.Clear()
        txtNombre10.Clear()
        txtNombre11.Clear()
        txtEdad07.Clear()
        txtEdad08.Clear()
        txtEdad09.Clear()
        txtEdad10.Clear()
        txtCI01.Clear()
        txtCI02.Clear()
        txtCI03.Clear()
        txtCI04.Clear()
        txtCI05.Clear()
        txtCI06.Clear()
        txtCI07.Clear()
        txtCI08.Clear()
        txtCI09.Clear()
        txtCI10.Clear()
        txtCI11.Clear()
        txtParidad07.Clear()
        txtParidad08.Clear()
        txtParidad09.Clear()
        txtParidad10.Clear()
        txtDia01.Clear()
        txtMes01.Clear()
        txtAño01.Clear()
        txtDia02.Clear()
        txtMes02.Clear()
        txtAño02.Clear()
        txtDia03.Clear()
        txtMes03.Clear()
        txtAño03.Clear()
        txtDia04.Clear()
        txtMes04.Clear()
        txtAño04.Clear()
        txtDia05.Clear()
        txtMes05.Clear()
        txtAño05.Clear()
        txtDia06.Clear()
        txtMes06.Clear()
        txtAño06.Clear()
        txtDia07.Clear()
        txtMes07.Clear()
        txtAño07.Clear()
        txtDia08.Clear()
        txtMes08.Clear()
        txtAño08.Clear()
        txtDia09.Clear()
        txtMes09.Clear()
        txtAño09.Clear()
        txtDia10.Clear()
        txtMes10.Clear()
        txtAño10.Clear()
        txtDia11.Clear()
        txtMes11.Clear()
        txtAño11.Clear()

    End Sub

    Private Sub FormularioClose(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Form1.RecipesAbierto = False

        'Dim reply As MsgBoxResult
        'reply = MsgBox("¿Deseas cerrar la ventana de récipes?" & vbCrLf & _
        '"también puedes minimizarla y seguir trabajando sin cerrarla..." & vbCrLf & _
        '"Presiona Aceptar para confirmar salida.", MsgBoxStyle.OkCancel, "Récipes")
        'If reply = MsgBoxResult.Cancel Then
        '    e.Cancel = True
        'Else
        '    Form1.RecipesAbierto = False

        'End If

    End Sub

    Private Sub ConfiguracionBaseDatosNoCargada()
        ListBoxSalida.Items.Clear()
        labRecipe01.Text = ""
        labRecipe02.Text = ""
        labRecipe03.Text = ""
        labRecipe04.Text = ""
        txtDescripcion.Clear()
        BotAbreBaseDatos.Enabled = True
        LabNombreBaseDatos.Text = "Ninguna"
        txtBuscaMedicamento.Text = ""
        txtBuscaMedicamento.Enabled = False
        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False
        botResta01.Enabled = False
        botResta02.Enabled = False
        botResta03.Enabled = False
        botResta04.Enabled = False
        botVistaPrevia.Enabled = False
        Filtro = False
        ApagaBotonesdeTipodeFarmaco()
        Panel1.Enabled = False
        labMensaje.Text = "Primero Selecciona una Base de Datos..."
    End Sub

    Private Sub ApagaBotonesdeTipodeFarmaco()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
        RadioButton13.Checked = False
        RadioButton14.Checked = False
        RadioButton15.Checked = False
        RadioButton16.Checked = False
        RadioButton17.Checked = False
        RadioButton18.Checked = False
        RadioButton19.Checked = False
    End Sub

    Private Sub ConfiguracionBaseDatosVacia()
        BotAbreBaseDatos.Enabled = True
        LabNombreBaseDatos.Text = NombreBaseDatosMedicamentos
        labMensaje.Text = "Esta Base de Datos está vacía. Primero añade los fármacos a la misma"
    End Sub

    Private Sub ConfiguracionBaseDatosNoVacia()

        BotAbreBaseDatos.Enabled = True
        LabNombreBaseDatos.Text = NombreBaseDatosMedicamentos
        txtBuscaMedicamento.Enabled = True
        Panel1.Enabled = True
        labMensaje.Text = "Selecciona un medicamento de la lista y añádelo al récipe"
    End Sub

    Private Sub BotAbreBaseDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotAbreBaseDatos.Click
        Dim Largo As Integer
        OpenFileDialog1.DefaultExt = ".BDM"
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.Filter = "Bases de Datos de Medicamentos (*.bdm) |*.bdm"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ConfiguracionBaseDatosNoCargada()
            NombreBaseDatosMedicamentos = OpenFileDialog1.FileName
            Path = NombreBaseDatosMedicamentos
            Largo = Path.Length
            Path = Path.Remove(Largo - 4, 4) & "-Contenido"
            LeeContenidoBaseDatos()
            MuestraContenidoBaseDatos()
        Else
            'ConfiguracionBaseDatosNoCargada()
        End If
    End Sub

    Private Sub LeeContenidoBaseDatos()
        Dim BR As BinaryReader
        Dim FS As FileStream

        'lee el indice general donde estan todos los medicamentos
        FS = New FileStream(NombreBaseDatosMedicamentos, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim H As String
        Dim C As Integer
        Farmacos.Clear()
        C = BR.PeekChar
        While FS.Position < FS.Length
            H = Nothing
            H = BR.ReadString
            Farmacos.Add(H)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'variables unicamente para la contruccion de la cadena
        Dim x As Integer
        Dim Cadena As String

        'lee los 18 sub indices segun el tipo de farmaco y los guarda en sus respectivas arrays lists
        For x = 1 To 18
            Cadena = Path & "\Tipo" & x.ToString & ".bds"
            FS = New FileStream(Cadena, FileMode.Open, FileAccess.Read)
            BR = New BinaryReader(FS)
            BR.BaseStream.Seek(0, SeekOrigin.Begin)
            Select Case x
                Case 1 : Tipo1.Clear()
                Case 2 : Tipo2.Clear()
                Case 3 : Tipo3.Clear()
                Case 4 : Tipo4.Clear()
                Case 5 : Tipo5.Clear()
                Case 6 : Tipo6.Clear()
                Case 7 : Tipo7.Clear()
                Case 8 : Tipo8.Clear()
                Case 9 : Tipo9.Clear()
                Case 10 : Tipo10.Clear()
                Case 11 : Tipo11.Clear()
                Case 12 : Tipo12.Clear()
                Case 13 : Tipo13.Clear()
                Case 14 : Tipo14.Clear()
                Case 15 : Tipo15.Clear()
                Case 16 : Tipo16.Clear()
                Case 17 : Tipo17.Clear()
                Case 18 : Tipo18.Clear()
            End Select
            C = BR.PeekChar
            While FS.Position < FS.Length
                H = Nothing
                H = BR.ReadString
                Select Case x
                    Case 1 : Tipo1.Add(H)
                    Case 2 : Tipo2.Add(H)
                    Case 3 : Tipo3.Add(H)
                    Case 4 : Tipo4.Add(H)
                    Case 5 : Tipo5.Add(H)
                    Case 6 : Tipo6.Add(H)
                    Case 7 : Tipo7.Add(H)
                    Case 8 : Tipo8.Add(H)
                    Case 9 : Tipo9.Add(H)
                    Case 10 : Tipo10.Add(H)
                    Case 11 : Tipo11.Add(H)
                    Case 12 : Tipo12.Add(H)
                    Case 13 : Tipo13.Add(H)
                    Case 14 : Tipo14.Add(H)
                    Case 15 : Tipo15.Add(H)
                    Case 16 : Tipo16.Add(H)
                    Case 17 : Tipo17.Add(H)
                    Case 18 : Tipo18.Add(H)
                End Select
                C = BR.PeekChar
            End While
            BR.Close()
            FS.Close()
        Next

        'prende el chk19 que es muestra todos y pone el tipo de farmaco en 19
        RadioButton19.Checked = True
        TipoFarmaco = 19
    End Sub

    Private Sub MuestraContenidoBaseDatos()
        Dim REnum As IEnumerator

        Dim Medicamento As String
        Dim CaracteresIntroducidos(50) As Char
        Dim LargoNuevo, LargoViejo As Integer
        Dim CaracteresExistentes(50) As Char
        Dim Similares, Iguales As Boolean
        Dim t As Integer

        ListBoxSalida.Items.Clear()
        txtDescripcion.Clear()

        Dim ContadorPasoFiltro As Integer = 0
        Dim Contador As Integer = 0

        LargoNuevo = txtBuscaMedicamento.Text.Length

        'inicializa primero a ver todos (como si fuera tipo 19)
        REnum = Farmacos.GetEnumerator
        'el tipo 19 es mostrar todos

        'aqui pone el renum dirigido a cada sub indice de array que contiene los medicamentos de ese tipo
        Select Case TipoFarmaco
            Case 19
                REnum = Farmacos.GetEnumerator
                MensajeDeBaseSinDatos = "Base de Datos vacía. Primero introduce los datos en la ventana de VADEMECUM"
                MensajeDeNoPasoFiltro = "No existen medicamentos en la Base de Datos con esa combinación de letras..."
            Case 1
                REnum = Tipo1.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 2
                REnum = Tipo2.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 3
                REnum = Tipo3.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 4
                REnum = Tipo4.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 5
                REnum = Tipo5.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 6
                REnum = Tipo6.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 7
                REnum = Tipo7.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 8
                REnum = Tipo8.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 9
                REnum = Tipo9.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 10
                REnum = Tipo10.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 11
                REnum = Tipo11.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 12
                REnum = Tipo12.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 13
                REnum = Tipo13.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 14
                REnum = Tipo14.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 15
                REnum = Tipo15.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 16
                REnum = Tipo16.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 17
                REnum = Tipo17.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
            Case 18
                REnum = Tipo18.GetEnumerator
                MensajeDeBaseSinDatos = "No existen medicamentos de este tipo en la Base de Datos..."
                MensajeDeNoPasoFiltro = "No existen medicamentos de este tipo con esa combinación de letras en la Base de Datos..."
        End Select


        If Filtro = True Then
            'aqui va la parte de filtro
            For t = 0 To LargoNuevo - 1
                CaracteresIntroducidos(t) = txtBuscaMedicamento.Text.Chars(t)
            Next

            Iguales = False

            While REnum.MoveNext
                Contador += 1
                Medicamento = CType(REnum.Current, String)
                If txtBuscaMedicamento.Text.ToUpper = Medicamento.ToUpper Then
                    ContadorPasoFiltro += 1
                    ListBoxSalida.Items.Add(Medicamento)
                    Iguales = True
                End If

                LargoViejo = Medicamento.Length
                If LargoNuevo > LargoViejo Then
                    Similares = True
                    For t = 0 To LargoViejo - 1
                        CaracteresExistentes(t) = Medicamento.Chars(t)
                        If Char.ToUpper(CaracteresIntroducidos(t)) <> Char.ToUpper(CaracteresExistentes(t)) Then
                            Similares = False
                            Exit For
                        End If
                    Next
                    If Similares = True And LargoNuevo > 0 And Iguales = False Then
                        ContadorPasoFiltro += 1
                        ListBoxSalida.Items.Add(Medicamento)
                    End If
                Else 'entonces largoviejo es mayor que el largonuevo
                    Similares = True
                    For t = 0 To LargoNuevo - 1
                        CaracteresExistentes(t) = Medicamento.Chars(t)
                        If Char.ToUpper(CaracteresIntroducidos(t)) <> Char.ToUpper(CaracteresExistentes(t)) Then
                            Similares = False
                            Exit For
                        End If
                    Next
                    If Similares = True And LargoNuevo > 0 And Iguales = False Then
                        ContadorPasoFiltro += 1
                        ListBoxSalida.Items.Add(Medicamento)
                    End If
                End If
            End While
            If Contador = 0 Then
                ConfiguracionBaseDatosVacia()
                labMensaje.Text = MensajeDeBaseSinDatos

            Else
                If ContadorPasoFiltro = 0 Then
                    ConfiguracionBaseDatosVacia()
                    labMensaje.Text = MensajeDeNoPasoFiltro
                Else
                    ConfiguracionBaseDatosNoVacia()
                    If ContadorPasoFiltro = 1 Then
                        labMensaje.Text += " (Mostrando: 1 medicamento)"
                    Else
                        labMensaje.Text += " (Mostrando: " & ContadorPasoFiltro & " medicamentos)"
                    End If
                End If

            End If
        Else
            While REnum.MoveNext
                Contador += 1
                Medicamento = CType(REnum.Current, String)
                ListBoxSalida.Items.Add(Medicamento)
            End While
            If Contador = 0 Then
                ConfiguracionBaseDatosVacia()
                labMensaje.Text = MensajeDeBaseSinDatos
            Else
                ConfiguracionBaseDatosNoVacia()
                If Contador = 1 Then
                    labMensaje.Text += " (Mostrando: 1 medicamento)"
                Else
                    labMensaje.Text += " (Mostrando: " & Contador & " medicamentos)"
                End If
            End If
        End If

    End Sub

    Private Sub txtBuscaMedicamento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscaMedicamento.TextChanged
        If txtBuscaMedicamento.Text = "" Then
            Filtro = False
        Else
            Filtro = True
        End If
        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False
        MuestraContenidoBaseDatos()
    End Sub


    Private Sub RadioButtons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged, RadioButton7.CheckedChanged, RadioButton8.CheckedChanged, RadioButton9.CheckedChanged, RadioButton10.CheckedChanged, RadioButton11.CheckedChanged, RadioButton12.CheckedChanged, RadioButton13.CheckedChanged, RadioButton14.CheckedChanged, RadioButton15.CheckedChanged, RadioButton16.CheckedChanged, RadioButton17.CheckedChanged, RadioButton18.CheckedChanged

        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False

        If RadioButton1.Checked = True Then
            TipoFarmaco = 1
        End If
        If RadioButton2.Checked = True Then
            TipoFarmaco = 2
        End If
        If RadioButton3.Checked = True Then
            TipoFarmaco = 3
        End If
        If RadioButton4.Checked = True Then
            TipoFarmaco = 4
        End If
        If RadioButton5.Checked = True Then
            TipoFarmaco = 5
        End If
        If RadioButton6.Checked = True Then
            TipoFarmaco = 6
        End If
        If RadioButton7.Checked = True Then
            TipoFarmaco = 7
        End If
        If RadioButton8.Checked = True Then
            TipoFarmaco = 8
        End If
        If RadioButton9.Checked = True Then
            TipoFarmaco = 9
        End If
        If RadioButton10.Checked = True Then
            TipoFarmaco = 10
        End If
        If RadioButton11.Checked = True Then
            TipoFarmaco = 11
        End If
        If RadioButton12.Checked = True Then
            TipoFarmaco = 12
        End If
        If RadioButton13.Checked = True Then
            TipoFarmaco = 13
        End If
        If RadioButton14.Checked = True Then
            TipoFarmaco = 14
        End If
        If RadioButton15.Checked = True Then
            TipoFarmaco = 15
        End If
        If RadioButton16.Checked = True Then
            TipoFarmaco = 16
        End If
        If RadioButton17.Checked = True Then
            TipoFarmaco = 17
        End If
        If RadioButton18.Checked = True Then
            TipoFarmaco = 18
        End If
        If RadioButton19.Checked = True Then
            TipoFarmaco = 19
        End If

        MuestraContenidoBaseDatos()

    End Sub

    Private Sub ListBoxSalida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxSalida.SelectedIndexChanged
        Dim MedicamentoSeleccionado As String
        Dim NombreArchivoFarmaco As String
        Dim CasillaLibre As Boolean = False

        MedicamentoSeleccionado = ListBoxSalida.SelectedItem
        If MedicamentoSeleccionado = Nothing Then
            Exit Sub
        End If

        Dim Z As String = MedicamentoSeleccionado
        If labRecipe01.Text = Z Or labRecipe02.Text = Z Or labRecipe03.Text = Z Or labRecipe04.Text = Z Then
            botSuma01.Enabled = False
            botSuma02.Enabled = False
            botSuma03.Enabled = False
            botSuma04.Enabled = False
            labMensaje.Text = "Este medicamento ya fue incluido en el recipe actual..."
        Else
            If labRecipe01.Text = "" Then
                botSuma01.Enabled = True
                CasillaLibre = True
            Else
                botSuma01.Enabled = False
            End If
            If labRecipe02.Text = "" Then
                botSuma02.Enabled = True
                CasillaLibre = True
            Else
                botSuma02.Enabled = False
            End If
            If labRecipe03.Text = "" Then
                botSuma03.Enabled = True
                CasillaLibre = True
            Else
                botSuma03.Enabled = False
            End If
            If labRecipe04.Text = "" Then
                botSuma04.Enabled = True
                CasillaLibre = True
            Else
                botSuma04.Enabled = False
            End If
            If CasillaLibre = True Then
                labMensaje.Text = "Puedes añadir este medicamento al récipe actual..."
            Else
                labMensaje.Text = "Existen 4 medicamentos en el récipe actual, elimina un medicamento o crea un nuevo récipe..."
            End If

        End If
        txtDescripcion.Clear()

        'accede a los datos del medicamento y los muestra en la descripcion
        NombreArchivoFarmaco = Path & "\" & MedicamentoSeleccionado & ".far"
        Dim BR As BinaryReader
        Dim FS As FileStream
        FS = New FileStream(NombreArchivoFarmaco, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim H As New DatosFarmaco()
        Dim C As Integer

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
        txtDescripcion.Text += H.Nombre & vbCrLf
        txtDescripcion.Text += "___________________________________________" & vbCrLf
        txtDescripcion.Text += H.Presentacion & " - " & H.Dosificacion & vbCrLf
        txtDescripcion.Text += H.Cantidad & vbCrLf
        txtDescripcion.Text += vbCrLf
        txtDescripcion.Text += "Posología: " & H.Indicaciones & vbCrLf
        txtDescripcion.Text += vbCrLf
        txtDescripcion.Text += "Descripción: " & H.Descripcion & vbCrLf

    End Sub

    Private Sub botSuma01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSuma01.Click
        Dim MedicamentoAdicionado As String
        MedicamentoAdicionado = ListBoxSalida.SelectedItem
        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False
        botResta01.Enabled = True
        labRecipe01.Text = MedicamentoAdicionado
        labMensaje.Text = "Se añadió el medicamento " & MedicamentoAdicionado & " al récipe actual..."
        botVistaPrevia.Enabled = True
        botVistaPrevia.Focus()
    End Sub

    Private Sub botSuma02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSuma02.Click
        Dim MedicamentoAdicionado As String
        MedicamentoAdicionado = ListBoxSalida.SelectedItem
        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False
        botResta02.Enabled = True
        labRecipe02.Text = MedicamentoAdicionado
        labMensaje.Text = "Se añadió el medicamento " & MedicamentoAdicionado & " al récipe actual..."
        botVistaPrevia.Enabled = True
        botVistaPrevia.Focus()
    End Sub

    Private Sub botSuma03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSuma03.Click
        Dim MedicamentoAdicionado As String
        MedicamentoAdicionado = ListBoxSalida.SelectedItem
        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False
        botResta03.Enabled = True
        labRecipe03.Text = MedicamentoAdicionado
        labMensaje.Text = "Se añadió el medicamento " & MedicamentoAdicionado & " al récipe actual..."
        botVistaPrevia.Enabled = True
        botVistaPrevia.Focus()
    End Sub

    Private Sub botSuma04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSuma04.Click
        Dim MedicamentoAdicionado As String
        MedicamentoAdicionado = ListBoxSalida.SelectedItem
        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False
        botResta04.Enabled = True
        labRecipe04.Text = MedicamentoAdicionado
        labMensaje.Text = "Se añadió el medicamento " & MedicamentoAdicionado & " al récipe actual..."
        botVistaPrevia.Enabled = True
        botVistaPrevia.Focus()
    End Sub


    Private Sub botResta01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botResta01.Click
        Dim MedicamentoEliminado As String
        MedicamentoEliminado = labRecipe01.Text
        labRecipe01.Text = ""
        botResta01.Enabled = False
        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False
        MuestraContenidoBaseDatos()
        labMensaje.Text = "Se eliminó el medicamento: " & MedicamentoEliminado & " del récipe actual..."
        If labRecipe01.Text = "" And labRecipe02.Text = "" And labRecipe03.Text = "" And labRecipe04.Text = "" Then
            botVistaPrevia.Enabled = False
        End If
    End Sub
    Private Sub botResta02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botResta02.Click
        Dim MedicamentoEliminado As String
        MedicamentoEliminado = labRecipe02.Text
        labRecipe02.Text = ""
        botResta02.Enabled = False
        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False
        MuestraContenidoBaseDatos()
        labMensaje.Text = "Se eliminó el medicamento: " & MedicamentoEliminado & " del récipe actual..."
        If labRecipe01.Text = "" And labRecipe02.Text = "" And labRecipe03.Text = "" And labRecipe04.Text = "" Then
            botVistaPrevia.Enabled = False
        End If
    End Sub
    Private Sub botResta03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botResta03.Click
        Dim MedicamentoEliminado As String
        MedicamentoEliminado = labRecipe03.Text
        labRecipe03.Text = ""
        botResta03.Enabled = False
        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False
        MuestraContenidoBaseDatos()
        labMensaje.Text = "Se eliminó el medicamento: " & MedicamentoEliminado & " del récipe actual..."
        If labRecipe01.Text = "" And labRecipe02.Text = "" And labRecipe03.Text = "" And labRecipe04.Text = "" Then
            botVistaPrevia.Enabled = False
        End If
    End Sub
    Private Sub botResta04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botResta04.Click
        Dim MedicamentoEliminado As String
        MedicamentoEliminado = labRecipe04.Text
        labRecipe04.Text = ""
        botResta04.Enabled = False
        botSuma01.Enabled = False
        botSuma02.Enabled = False
        botSuma03.Enabled = False
        botSuma04.Enabled = False
        MuestraContenidoBaseDatos()
        labMensaje.Text = "Se eliminó el medicamento: " & MedicamentoEliminado & " del récipe actual..."
        If labRecipe01.Text = "" And labRecipe02.Text = "" And labRecipe03.Text = "" And labRecipe04.Text = "" Then
            botVistaPrevia.Enabled = False
        End If
    End Sub

    Private Sub botVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botVistaPrevia.Click
        Dim numero As Integer

        numero = 0
        If labRecipe01.Text <> "" Then
            MedicamentosEnElRecipe(numero) = labRecipe01.Text
            numero += 1
        End If
        If labRecipe02.Text <> "" Then
            MedicamentosEnElRecipe(numero) = labRecipe02.Text
            numero += 1
        End If
        If labRecipe03.Text <> "" Then
            MedicamentosEnElRecipe(numero) = labRecipe03.Text
            numero += 1
        End If
        If labRecipe04.Text <> "" Then
            MedicamentosEnElRecipe(numero) = labRecipe04.Text
            numero += 1
        End If
        NumerodeMedicamentosEnElRecipe = numero

        Dim DLG As New FormImprimeRecipe()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

    End Sub

    Private Sub botImpConstAsist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImpConstAsist.Click

        'prepara el texto de intercambio

        Texto = ""

        Texto += "                           CONSTANCIA DE ASISTENCIA" & vbCrLf & vbCrLf & vbCrLf
        Texto += "Quien suscribe, Médico en ejercicio, hace constar por medio de la presente que la paciente: " & vbCrLf & vbCrLf
        Texto += txtNombre01.Text & vbCrLf
        Texto += "Cédula de Identidad: " & txtCI01.Text & vbCrLf & vbCrLf
        Texto += "Asistió a consulta hoy " & txtDia01.Text & " de " & txtMes01.Text & " de " & txtAño01.Text & "." & vbCrLf & vbCrLf
        Texto += "Constancia que se expide a solicitud de la parte interesada."

        Form1.TextoIntercambio = Texto
        Form1.TextoIntercambio2 = ""
        Form1.EsUnRecipe = False

        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

    End Sub

    Private Sub botImpConstReposo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImpConstReposo.Click
        'prepara el texto de intercambio

        Texto = ""

        Texto += "                                REPOSO  MÉDICO" & vbCrLf & vbCrLf & vbCrLf
        Texto += "Quien suscribe, Médico en ejercicio, hace constar por medio de la presente que la paciente: " & vbCrLf & vbCrLf
        Texto += txtNombre02.Text & vbCrLf
        Texto += "Cédula de Identidad: " & txtCI02.Text & vbCrLf & vbCrLf
        Texto += "Asistió a consulta hoy " & txtDia02.Text & " de " & txtMes02.Text & " de " & txtAño02.Text & "." & vbCrLf & vbCrLf
        Texto += "Presentando Impresión Diagnóstica de: " & vbCrLf & vbCrLf
        Texto += txtIDx01.Text & vbCrLf & vbCrLf
        Texto += "Ameritando REPOSO MÉDICO por " & txtDiasReposo.Text & " días." & vbCrLf
        Texto += "A partir del " & txtDiaInicio01.Text & " de " & txtMesInicio01.Text & " de " & txtAñoInicio01.Text & " (inclusive)" & vbCrLf & vbCrLf
        Texto += "Atentamente."

        Form1.TextoIntercambio = Texto
        Form1.TextoIntercambio2 = ""
        Form1.EsUnRecipe = False

        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub botImpReposoPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImpReposoPre.Click
        'prepara el texto de intercambio

        Texto = ""

        Texto += "                                REPOSO  PRENATAL" & vbCrLf & vbCrLf & vbCrLf
        Texto += txtCiudad.Text & ", " & txtDia03.Text & " de " & txtMes03.Text & " de " & txtAño03.Text & "." & vbCrLf & vbCrLf
        Texto += "AGRADEZCO CONCEDER  REPOSO PRENATAL DE LEY a la paciente:" & vbCrLf & vbCrLf
        Texto += txtNombre03.Text & vbCrLf
        Texto += "Cédula de Identidad: " & txtCI03.Text & vbCrLf & vbCrLf

        Texto += "Fecha de última regla: " & txtDiaFUR.Text & " de " & txtMesFUR.Text & " de " & txtAñoFUR.Text & "." & vbCrLf & vbCrLf
        Texto += "Reposo a partir del " & txtDiaInicio02.Text & " de " & txtMesInicio02.Text & " de " & txtAñoInicio02.Text & " (inclusive)" & vbCrLf & vbCrLf
        Texto += "día en que la paciente cumple las 34 semanas de gestación." & vbCrLf & vbCrLf
        Texto += "Atentamente."

        Form1.TextoIntercambio = Texto
        Form1.TextoIntercambio2 = ""
        Form1.EsUnRecipe = False

        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub botImpReposoPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImpReposoPost.Click
        'prepara el texto de intercambio

        Texto = ""

        Texto += "                                REPOSO  POSTNATAL" & vbCrLf & vbCrLf & vbCrLf
        Texto += txtCiudad02.Text & ", " & txtDia04.Text & " de " & txtMes04.Text & " de " & txtAño04.Text & "." & vbCrLf & vbCrLf
        Texto += "AGRADEZCO CONCEDER  REPOSO POSTNATAL DE LEY a la paciente:" & vbCrLf & vbCrLf
        Texto += txtNombre04.Text & vbCrLf
        Texto += "Cédula de Identidad: " & txtCI04.Text & vbCrLf & vbCrLf

        If radCesarea.Checked = True Then
            Texto += "A quien se le practicó CESÁREA SEGMENTARIA el día: "
        Else
            Texto += "A quien se le atendió PARTO NORMAL el día: "
        End If

        Texto += txtDiaInicio03.Text & " de " & txtMesInicio03.Text & " de " & txtAñoInicio03.Text & vbCrLf & vbCrLf
        Texto += "Edad gestacional al nacimiento: " & txtEG04.Text & vbCrLf & vbCrLf
        Texto += "Según FUR del: " & txtFUR04.Text & vbCrLf & vbCrLf
        Texto += "Ameritando " & txtExcesoReposo04.Text & " días adicionales de REPOSO PRENATAL no disfrutado que se deben sumar a su REPOSO POSTNATAL." & vbCrLf & vbCrLf
        Texto += "Atentamente."

        Form1.TextoIntercambio = Texto
        Form1.TextoIntercambio2 = ""
        Form1.EsUnRecipe = False


        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If


    End Sub

    'Imprime informe de cesarea
    Private Sub botImpInformeCesarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImpInformeCesarea.Click
        Texto = ""
        Texto += "                                     INFORME MEDICO" & vbCrLf & vbCrLf
        Texto += "Fecha:    " & txtDia05.Text & " de " & txtMes05.Text & " de " & txtAño05.Text & vbCrLf
        Texto += "Paciente: " & txtNombre05.Text & vbCrLf
        Texto += "Cédula:   " & txtCI05.Text & vbCrLf & vbCrLf
        Texto += "Quien suscribe, " & txtDoctor01.Text & ", cédula de identidad: " & txtDrCI01.Text & ", hace constar que la paciente cursa con embarazo de "
        Texto += txtSemanas01.Text & " semanas y presenta los siguientes diagnósticos:" & vbCrLf & vbCrLf
        Texto += "1.- " & txtDx01a.Text & vbCrLf
        Texto += "2.- " & txtDx01b.Text & vbCrLf
        Texto += "3.- " & txtDx01c.Text & vbCrLf & vbCrLf
        Texto += "La paciente recibió inductores para la maduración pulmonar fetal." & vbCrLf
        Texto += "Actualmente se encuentra en control semanal con test de reactividad fetal y ecografía, en espera de alcanzar el término de  la gestación." & vbCrLf
        Texto += "Sirva este informe para el procesamiento de la carta aval de la CIA de Seguros con la siguiente conducta:" & vbCrLf & vbCrLf
        Texto += "1.- CESAREA SEGMENTARIA." & vbCrLf & vbCrLf
        Texto += "Indicada por los diagnósticos expuestos."




        Form1.TextoIntercambio = Texto
        Form1.TextoIntercambio2 = ""
        Form1.EsUnRecipe = False


        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

    End Sub

    'Imprime informe de Parto
    Private Sub botImpInformeParto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImpInformeParto.Click
        Texto = ""
        Texto += "                                     INFORME MEDICO" & vbCrLf & vbCrLf
        Texto += "Fecha:    " & txtDia06.Text & " de " & txtMes06.Text & " de " & txtAño06.Text & vbCrLf
        Texto += "Paciente: " & txtNombre06.Text & vbCrLf
        Texto += "Cédula:   " & txtCI06.Text & vbCrLf & vbCrLf
        Texto += "Quien suscribe, " & txtDoctor02.Text & ", cédula de identidad: " & txtDrCI02.Text & ", hace constar que la paciente cursa con embarazo de "
        Texto += txtSemanas02.Text & " semanas y presenta los siguientes diagnósticos:" & vbCrLf & vbCrLf
        Texto += "1.- " & txtDx02a.Text & vbCrLf
        Texto += "2.- " & txtDx02b.Text & vbCrLf
        Texto += "3.- " & txtDx02c.Text & vbCrLf & vbCrLf
        Texto += "La paciente recibió inductores para la maduración pulmonar fetal." & vbCrLf
        Texto += "Actualmente se encuentra en control semanal con test de reactividad fetal y ecografía, en espera de alcanzar el término de  la gestación." & vbCrLf
        Texto += "Sirva este informe para el procesamiento de la carta aval de la CIA de Seguros con  las siguientes posibles conductas:" & vbCrLf & vbCrLf
        Texto += "1.- PARTO NORMAL." & vbCrLf & vbCrLf
        Texto += "2.- No descartándose realizar CESAREA SEGMENTARIA en caso de emergencia en pro de la salud tanto del feto como de la madre."

        Form1.TextoIntercambio = Texto
        Form1.TextoIntercambio2 = ""
        Form1.EsUnRecipe = False

        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

    End Sub

    'imprime informe de consulta
    Private Sub botImpInformeConsulta_Click(sender As Object, e As EventArgs) Handles botImpInformeConsulta.Click
        Texto = ""
        Texto += "                                     INFORME MEDICO" & vbCrLf & vbCrLf
        Texto += "Fecha:    " & txtDia11.Text & " de " & txtMes11.Text & " de " & txtAño11.Text & vbCrLf
        Texto += "Paciente: " & txtNombre11.Text & vbCrLf
        Texto += "Cédula:   " & txtCI11.Text & vbCrLf & vbCrLf
        Texto += "Quien suscribe, " & txtDoctor11.Text & ", cédula de identidad: " & txtDrCI11.Text & ", hace constar que la paciente "
        Texto += "acudió hoy " & txtDia11.Text & " de " & txtMes11.Text & " de " & txtAño11.Text & " a la consulta  presentando los siguientes diagnósticos :" & vbCrLf & vbCrLf
        Texto += "1.- " & txtDx11a.Text & vbCrLf
        Texto += "2.- " & txtDx11b.Text & vbCrLf
        Texto += "3.- " & txtDx11c.Text & vbCrLf & vbCrLf
        Texto += "Se le indicó el siguiente tratamiento ambulatorio:" & vbCrLf
        Texto += txtTto11.Text & vbCrLf & vbCrLf
        Texto += "Se le indicaron los siguientes exámenes paraclínicos:" & vbCrLf
        Texto += txtExa11.Text 

        Form1.TextoIntercambio = Texto
        Form1.TextoIntercambio2 = ""
        Form1.EsUnRecipe = False

        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    'parte de los recipe frcuentes
    Private Sub CargaRecipesFijos()

        'RECIPE PRENATAL
        Texto = ""
        Texto += "1.- FERGANIC Caps o FUMARATO FERROSO Tabs" & vbCrLf & vbCrLf
        Texto += "2.- ACIDO FOLICO Tab 5 mg" & vbCrLf & vbCrLf
        Texto += "3.- PRENAVIT o MATERNAVIT o CENTRUM o PHARMATON Tab" & vbCrLf & vbCrLf
        Texto += "4.- ATAMEL o TEMPRA o TACHIPIRIN Tab 500 mg" & vbCrLf & vbCrLf
        Texto += "5.- BUSCAPINA SIMPLE Grag 10mg" & vbCrLf & vbCrLf
        Texto += "6.- SULCRALFATO Susp 1gr/5cc o Tabs 1gr" & vbCrLf & vbCrLf
        Texto += "7.- IRTOPAN Tab 10mg" & vbCrLf & vbCrLf
        Texto += "8.- ANTIFON grag 40mg o FLATORIL caps 125mg" & vbCrLf & vbCrLf
        Texto += "9.- MILAX Polvo para solución oral"
        varRPPrenatal = Texto

        'INDICACIONES PRENATALES
        Texto = ""
        Texto += "1.- FERGANIC o FUMARATO FERROSO" & vbCrLf
        Texto += "Tomar 1 cápsula o tableta diaria 1 hora antes del almuerzo." & vbCrLf
        Texto += "2.- ACIDO FOLICO" & vbCrLf
        Texto += "Tomar una tableta diaria." & vbCrLf
        Texto += "3.- PRENAVIT o MATERNAVIT o CENTRUM o PHARMATON Tab" & vbCrLf
        Texto += "Tomar una tableta diaria." & vbCrLf
        Texto += "4.- ATAMEL o TEMPRA o TACHIPIRIN" & vbCrLf
        Texto += "Tomar 1 tableta y media cada 8 horas si tiene dolor de cabeza, fiebre o malestar." & vbCrLf
        Texto += "5.- BUSCAPINA SIMPLE" & vbCrLf
        Texto += "Tomar 1 tableta cada 6 horas si tiene dolor de vientre o cólicos." & vbCrLf
        Texto += "6.- SULCRALFATO" & vbCrLf
        Texto += "Tomar una cucharada o tableta una hora antes de cada comida si tiene acidez estomacal." & vbCrLf
        Texto += "7.- IRTOPAN" & vbCrLf
        Texto += "Tomar una tableta cada 8 horas si tiene nauseas o vómitos." & vbCrLf
        Texto += "8.- ANTIFON" & vbCrLf
        Texto += "Tomar 1 GRAGEA 1 hora después de cada comida si tiene gases o mala digestión." & vbCrLf
        Texto += "9.- MILAX" & vbCrLf
        Texto += "Diluir una medida en un vaso de agua, tomar una o dos veces al dia si tiene estreñimiento."
        varINDPrenatales = Texto

        'RP CANDIDIASIS NO EMBARAZADA
        Texto = ""
        Texto += "1.- FLUCONAZOL" & vbCrLf
        Texto += "         Cápsulas 150mg" & vbCrLf
        Texto += "         Caja de 2 cápsulas." & vbCrLf & vbCrLf
        Texto += "2.- GYNOCANESTEN" & vbCrLf
        Texto += "         Comprimidos vaginales de 100mg" & vbCrLf
        Texto += "         Envase de 6 comprimidos vaginales." & vbCrLf & vbCrLf
        Texto += "3.- CANESTEN" & vbCrLf
        Texto += "         Spray" & vbCrLf
        Texto += "         Frasco de 25ml al 1%." & vbCrLf & vbCrLf
        varRPCandidiasisNE = Texto

        'IND CANDIDIASIS NO EMBARAZADAS
        Texto = ""
        Texto += "1.- FLUCONAZOL. (también debe tomarlo la pareja)" & vbCrLf
        Texto += "Tomar una cápsula al inicio del tratamiento y otra a los 7 días." & vbCrLf & vbCrLf
        Texto += "2.- GYNOCANESTEN" & vbCrLf
        Texto += "Colocar un comprimido diario en el fondo de la vagina durante 6 días consecutivos." & vbCrLf & vbCrLf
        Texto += "3.- CANESTEN (solo la pareja)" & vbCrLf
        Texto += "Aplicar el Spray dos veces al día (mañana y noche) durante 15 días."
        varINDCandidiasisNE = Texto

        'RP VAGINOSIS Y TRICOMONIASIS NO EMBARAZADA economico
        Texto = ""
        Texto += "1.- SECNIDAZOL" & vbCrLf
        Texto += "         Comprimidos 500mg" & vbCrLf
        Texto += "         Estuche de 4 comprimidos." & vbCrLf & vbCrLf
        Texto += "2.- METROVAX" & vbCrLf
        Texto += "         Ovulos vaginales de 500mg" & vbCrLf
        Texto += "         Caja de 10 óvulos vaginales." & vbCrLf & vbCrLf
        varRPvaginosisNEeco = Texto

        'IND VAGINOSIS Y TRICOMONIASIS NO EMBARAZADAS economico
        Texto = ""
        Texto += "1.- SECNIDAZOL  (también debe tomarlo la pareja)" & vbCrLf
        Texto += "Tomar 1 comprimido cada 12 horas por 2 dias." & vbCrLf & vbCrLf
        Texto += "2.- METROVAX" & vbCrLf
        Texto += "Colocar 1 óvulo vaginal diario en la noche durante 10 días consecutivos."
        varINDvaginosisNEeco = Texto

        'RP VAGINOSIS Y TRICOMONIASIS NO EMBARAZADA OK
        Texto = ""
        Texto += "1.- SPORASEC" & vbCrLf
        Texto += "         Cápsulas - 33mg/166 mg" & vbCrLf
        Texto += "         Caja de 12 cápsulas." & vbCrLf & vbCrLf
        Texto += "2.- METROVAX" & vbCrLf
        Texto += "         Ovulos vaginales de 500mg" & vbCrLf
        Texto += "         Caja de 10 óvulos vaginales." & vbCrLf & vbCrLf
        varRPvaginosisNEok = Texto

        'IND VAGINOSIS Y TRICOMONIASIS NO EMBARAZADAS OK
        Texto = ""
        Texto += "1.- SPORASEC  (también debe tomarlo la pareja)" & vbCrLf
        Texto += "Tomar 2 cápsulas en la mañana y 2 cápsulas en la noche durante 3 días consecutivos" & vbCrLf & vbCrLf
        Texto += "2.- METROVAX" & vbCrLf
        Texto += "Colocar 1 óvulo vaginal diario en la noche durante 10 días consecutivos."
        varINDvaginosisNEok = Texto



        'RP CANDIDIASIS EMBARAZADA
        Texto = ""
        Texto += "1.- GYNOCANESTEN" & vbCrLf
        Texto += "         Comprimidos vaginales de 100mg" & vbCrLf
        Texto += "         Envase de 6 comprimidos vaginales." & vbCrLf & vbCrLf
        Texto += "2.- FLUCONAZOL  (SOLO PARA LA PAREJA)" & vbCrLf
        Texto += "         Cápsulas 150mg" & vbCrLf
        Texto += "         Caja de 2 cápsulas." & vbCrLf & vbCrLf
        Texto += "3.- CANESTEN (SOLO PARA LA PAREJA)" & vbCrLf
        Texto += "         Spray" & vbCrLf
        Texto += "         Frasco de 25ml al 1%." & vbCrLf & vbCrLf
        varRPCandidiasisE = Texto

        'IND CANDIDIASIS EMBARAZADAS
        Texto = ""
        Texto += "1.- GYNOCANESTEN" & vbCrLf
        Texto += "Colocar un comprimido diario en el fondo de la vagina durante 6 días consecutivos." & vbCrLf & vbCrLf
        Texto += "2.- FLUCONAZOL. (OJO: SOLO DEBE TOMARLO LA PAREJA)" & vbCrLf
        Texto += "Tomar una cápsula al inicio del tratamiento y otra a los 7 días." & vbCrLf & vbCrLf
        Texto += "3.- CANESTEN. (OJO: SOLO APLICARLO LA PAREJA)" & vbCrLf
        Texto += "Aplicar el Spray dos veces al día (mañana y noche) durante 15 días."
        varINDCandidiasisE = Texto



        'LABORATORIO RUTINA PRENATAL 1ra hoja
        Texto = ""
        Texto += "                                   L A B O R A T O R I O" & vbCrLf & vbCrLf & vbCrLf
        Texto += "1.- Hematología Completa (Incluso Plaquetas)" & vbCrLf & vbCrLf
        Texto += "2.- Glicemia en Ayunas" & vbCrLf & vbCrLf
        Texto += "3.- Creatinina" & vbCrLf & vbCrLf
        Texto += "4.- Orina y Gram de Orina sin centrifugar." & vbCrLf & vbCrLf
        Texto += "5.- V.D.R.L." & vbCrLf & vbCrLf
        Texto += "6.- Toxoplasmosis IGM" & vbCrLf & vbCrLf
        Texto += "7.- HIV" & vbCrLf & vbCrLf
        Texto += "8.- Tipiaje Sanguineo y Rh (También del Esposo)" & vbCrLf & vbCrLf
        labLaboratorioPrenatal.Text = Texto

        'LABORATORIO RUTINA PRENATAL 2da hoja
        Texto = ""
        Texto += "                                 R E C O M E N D A C I O N E S" & vbCrLf & vbCrLf & vbCrLf
        Texto += "GLICEMIA EN AYUNAS" & vbCrLf
        Texto += "Realizar el examen de glicemia a primera hora de la mañana sin haber consumido ningun tipo de alimento ni bebida." & vbCrLf & vbCrLf
        Texto += "EXAMEN DE ORINA" & vbCrLf
        Texto += "Tomar la muestra de orina a primera hora de la mañana después de haber realizado un lavado de la zona genital con abundante agua y jabón." & vbCrLf
        Texto += "Desechar el primer chorro de orina e inmediatamente tomar la muestra del chorro del medio." & vbCrLf
        Texto += "Utilizar un envase desechable esteril para la recolección." & vbCrLf
        Texto += "Trasladar al laboratorio en menos de 1 hora desde el momento de la recolección" & vbCrLf
        Texto += "Puede utilizarse hielo ALREDEDOR del envase durante su traslado" & vbCrLf & vbCrLf
        Texto += "TIPIAJE SANGUINEO Y RH" & vbCrLf
        Texto += "Es Imprescindible que su pareja se realice el examen de Tipiaje Sanguineo y Rh para descartar incompatibilidades sanguineas." & vbCrLf & vbCrLf
        labLaboratorioPrenatal2.Text = Texto
    End Sub

    Private Sub botImprimeIndicaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImprimeIndicaciones.Click

        If radIndPrenatal.Checked = True Then
            'se seleccionaron las indicaciones prenatales
            Form1.TextoIntercambio = varRPPrenatal
            Form1.TextoIntercambio2 = varINDPrenatales
            Form1.EsUnRecipe = True
            Dim DLG As New FormImprimePapeleria()
            If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            End If
        End If

        If radIndCandidiasisNE.Checked = True Then
            'se seleccionaron las indicaciones CANDIDIASIS EN NO EMBARAZADAS
            Form1.TextoIntercambio = varRPCandidiasisNE
            Form1.TextoIntercambio2 = varINDCandidiasisNE
            Form1.EsUnRecipe = True
            Dim DLG As New FormImprimePapeleria()
            If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            End If
        End If

        If radIndVaginosisNEeco.Checked = True Then
            'se seleccionaron las indicaciones VAGINOSIS Y TRICO EN NO EMBARAZADAS ECONOMICA
            Form1.TextoIntercambio = varRPvaginosisNEeco
            Form1.TextoIntercambio2 = varINDvaginosisNEeco
            Form1.EsUnRecipe = True
            Dim DLG As New FormImprimePapeleria()
            If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            End If
        End If

        If radINDvaginosisNEok.Checked = True Then
            'se seleccionaron las indicaciones VAGINOSIS Y TRICO EN NO EMBARAZADAS OK
            Form1.TextoIntercambio = varRPvaginosisNEok
            Form1.TextoIntercambio2 = varINDvaginosisNEok
            Form1.EsUnRecipe = True
            Dim DLG As New FormImprimePapeleria()
            If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            End If
        End If



        'EMBARAZADAS

        If radINDCandidiasisE.Checked = True Then
            'se seleccionaron las indicaciones CANDIDIASIS EN EMBARAZADA
            Form1.TextoIntercambio = varRPCandidiasisE
            Form1.TextoIntercambio2 = varINDCandidiasisE
            Form1.EsUnRecipe = True
            Dim DLG As New FormImprimePapeleria()
            If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            End If
        End If
    End Sub

    Private Sub botImpLabPrenatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botLabPrenatal.Click
        'prepara el texto de intercambio

        Form1.TextoIntercambio = labLaboratorioPrenatal.Text
        Form1.TextoIntercambio2 = labLaboratorioPrenatal2.Text
        Form1.EsUnRecipe = False

        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub botTripleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botTripleta.Click
        'prepara el texto de intercambio

        Texto = ""

        Texto += "                              LABORATORIO ESPECIAL" & vbCrLf & vbCrLf & vbCrLf
        Texto += "FECHA: " & txtDia07.Text & " de " & txtMes07.Text & " de " & txtAño07.Text & "." & vbCrLf & vbCrLf
        Texto += "PACIENTE: " & txtNombre07.Text & vbCrLf
        Texto += "C.I.: " & txtCI07.Text & vbCrLf
        Texto += "EDAD: " & txtEdad07.Text & vbCrLf
        Texto += "PARIDAD: " & txtParidad07.Text & vbCrLf
        Texto += "EDAD GESTACIONAL: " & txtSemanas07.Text & " semanas." & vbCrLf & vbCrLf & vbCrLf
        Texto += "Se agradece realizar examen de tripleta bioquímica:" & vbCrLf & vbCrLf
        Texto += "1.-  Alfa fetoproteína." & vbCrLf
        Texto += "2.-  Gonadotropina" & vbCrLf
        Texto += "3.-  Estradiol no conjugado" & vbCrLf & vbCrLf
        Texto += "Atentamente."

        Form1.TextoIntercambio = Texto
        Form1.TextoIntercambio2 = ""
        Form1.EsUnRecipe = False

        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub botEcoPerinatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEcoPerinatal.Click
        'prepara el texto de intercambio

        Texto = ""

        Texto += "                              ECOGRAFIA PERINATOLOGICA" & vbCrLf & vbCrLf & vbCrLf
        Texto += "FECHA: " & txtDia08.Text & " de " & txtMes08.Text & " de " & txtAño08.Text & "." & vbCrLf & vbCrLf
        Texto += "PACIENTE: " & txtNombre08.Text & vbCrLf
        Texto += "C.I.: " & txtCI08.Text & vbCrLf
        Texto += "EDAD: " & txtEdad08.Text & vbCrLf
        Texto += "PARIDAD: " & txtParidad08.Text & vbCrLf
        Texto += "EDAD GESTACIONAL: " & txtSemanas08.Text & " semanas. " & vbCrLf
        Texto += "SEGUN FUR DEL: " & txtFUR08.Text & vbCrLf & vbCrLf
        Texto += "Se agradece realizar ESTUDIO ECOGRAFICO PERINATOLOGICO." & vbCrLf & vbCrLf
        Texto += "Atentamente."

        Form1.TextoIntercambio = Texto
        Form1.TextoIntercambio2 = ""
        Form1.EsUnRecipe = False

        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub botPreoperatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPreoperatorio.Click
        'prepara el texto de intercambio

        Texto = ""

        Texto += "          EVALUACION CARDIOVASCULAR PREOPERATORIA" & vbCrLf & vbCrLf & vbCrLf
        Texto += "FECHA: " & txtDia09.Text & " de " & txtMes09.Text & " de " & txtAño09.Text & "." & vbCrLf & vbCrLf
        Texto += "PACIENTE: " & txtNombre09.Text & vbCrLf
        Texto += "C.I.: " & txtCI09.Text & vbCrLf
        Texto += "EDAD: " & txtEdad09.Text & vbCrLf
        Texto += "PARIDAD: " & txtParidad09.Text & vbCrLf
        Texto += "EDAD GESTACIONAL: " & txtSemanas09.Text & " semanas. " & vbCrLf & vbCrLf & vbCrLf

        Texto += "Se agradece realizar EVALUACION CARDIOVASCULAR PREOPERATORIA." & vbCrLf & vbCrLf
        Texto += "Impresión Diagnóstica:" & vbCrLf & vbCrLf
        Texto += "1.- " & txtIdx09a.Text & vbCrLf
        Texto += "2.- " & txtIdx09b.Text & vbCrLf
        Texto += "3.- " & txtIdx09c.Text & vbCrLf & vbCrLf
        Texto += "Intervención Propuesta: " & txtOp09.Text & vbCrLf & vbCrLf
        Texto += "Atentamente."

        Form1.TextoIntercambio = Texto

        Texto = ""
        Texto += "                EVALUACION ANESTESICA PREOPERATORIA" & vbCrLf & vbCrLf & vbCrLf
        Texto += "FECHA: " & txtDia10.Text & " de " & txtMes10.Text & " de " & txtAño10.Text & "." & vbCrLf & vbCrLf
        Texto += "PACIENTE: " & txtNombre10.Text & vbCrLf
        Texto += "C.I.: " & txtCI10.Text & vbCrLf
        Texto += "EDAD: " & txtEdad10.Text & vbCrLf
        Texto += "PARIDAD: " & txtParidad10.Text & vbCrLf
        Texto += "EDAD GESTACIONAL: " & txtSemanas10.Text & " semanas. " & vbCrLf & vbCrLf & vbCrLf

        Texto += "Se agradece realizar EVALUACION ANESTESICA PREOPERATORIA." & vbCrLf & vbCrLf
        Texto += "Intervención Propuesta: " & txtOp10.Text & vbCrLf & vbCrLf
        Texto += "Fecha Propuesta: " & txtFechaProp10.Text & vbCrLf
        Texto += "Hora Propuesta: " & txtHoraProp10.Text & vbCrLf & vbCrLf

        Texto += "Atentamente."

        Form1.TextoIntercambio2 = Texto
        Form1.EsUnRecipe = False

        Dim DLG As New FormImprimePapeleria()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    'eventos de sincronizacion de los nombres de los informes y constancias

    Private Sub txtNombre01_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre01.Leave
        subActualizaNombres(txtNombre01.Text)
    End Sub
    Private Sub txtNombre02_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre02.Leave
        subActualizaNombres(txtNombre02.Text)
    End Sub
    Private Sub txtNombre03_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre03.Leave
        subActualizaNombres(txtNombre03.Text)
    End Sub
    Private Sub txtNombre04_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre04.Leave
        subActualizaNombres(txtNombre04.Text)
    End Sub
    Private Sub txtNombre05_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre05.Leave
        subActualizaNombres(txtNombre05.Text)
    End Sub
    Private Sub txtNombre06_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre06.Leave
        subActualizaNombres(txtNombre06.Text)
    End Sub
    Private Sub txtNombre07_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre07.Leave
        subActualizaNombres(txtNombre07.Text)
    End Sub
    Private Sub txtNombre08_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre08.Leave
        subActualizaNombres(txtNombre08.Text)
    End Sub
    Private Sub txtNombre09_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre09.Leave
        subActualizaNombres(txtNombre09.Text)
    End Sub
    Private Sub txtNombre10_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre10.Leave
        subActualizaNombres(txtNombre10.Text)
    End Sub
    Private Sub txtNombre11_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre11.Leave
        subActualizaNombres(txtNombre11.Text)
    End Sub

    Private Sub subActualizaNombres(ByVal txtNombre As String)

        txtNombre01.Text = txtNombre
        txtNombre02.Text = txtNombre
        txtNombre03.Text = txtNombre
        txtNombre04.Text = txtNombre
        txtNombre05.Text = txtNombre
        txtNombre06.Text = txtNombre
        txtNombre07.Text = txtNombre
        txtNombre08.Text = txtNombre
        txtNombre09.Text = txtNombre
        txtNombre10.Text = txtNombre
        txtNombre11.Text = txtNombre

    End Sub

    'eventos de sincronizacion de cedulas de informes y constancias
    Private Sub txtCI01_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI01.Leave
        subActualizaCedulas(txtCI01.Text)
    End Sub
    Private Sub txtCI02_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI02.Leave
        subActualizaCedulas(txtCI02.Text)
    End Sub
    Private Sub txtCI03_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI03.Leave
        subActualizaCedulas(txtCI03.Text)
    End Sub
    Private Sub txtCI04_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI04.Leave
        subActualizaCedulas(txtCI04.Text)
    End Sub
    Private Sub txtCI05_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI05.Leave
        subActualizaCedulas(txtCI05.Text)
    End Sub
    Private Sub txtCI06_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI06.Leave
        subActualizaCedulas(txtCI06.Text)
    End Sub
    Private Sub txtCI07_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI07.Leave
        subActualizaCedulas(txtCI07.Text)
    End Sub
    Private Sub txtCI08_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI08.Leave
        subActualizaCedulas(txtCI08.Text)
    End Sub
    Private Sub txtCI09_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI09.Leave
        subActualizaCedulas(txtCI09.Text)
    End Sub
    Private Sub txtCI10_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI10.Leave
        subActualizaCedulas(txtCI10.Text)
    End Sub
    Private Sub txtCI11_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCI11.Leave
        subActualizaCedulas(txtCI11.Text)
    End Sub


    Private Sub subActualizaCedulas(ByVal txtCedula As String)

        txtCI01.Text = txtCedula
        txtCI02.Text = txtCedula
        txtCI03.Text = txtCedula
        txtCI04.Text = txtCedula
        txtCI05.Text = txtCedula
        txtCI06.Text = txtCedula
        txtCI07.Text = txtCedula
        txtCI08.Text = txtCedula
        txtCI09.Text = txtCedula
        txtCI10.Text = txtCedula
        txtCI11.Text = txtCedula

    End Sub

    'eventos de sincronizacion de dias de asistencia
    Private Sub txtDia01_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia01.Leave
        subActualizaDia(txtDia01.Text)
    End Sub
    Private Sub txtDia02_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia02.Leave
        subActualizaDia(txtDia02.Text)
    End Sub
    Private Sub txtDia03_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia03.Leave
        subActualizaDia(txtDia03.Text)
    End Sub
    Private Sub txtDia04_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia04.Leave
        subActualizaDia(txtDia04.Text)
    End Sub
    Private Sub txtDia05_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia05.Leave
        subActualizaDia(txtDia05.Text)
    End Sub
    Private Sub txtDia06_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia06.Leave
        subActualizaDia(txtDia06.Text)
    End Sub
    Private Sub txtDia07_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia07.Leave
        subActualizaDia(txtDia07.Text)
    End Sub
    Private Sub txtDia08_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia08.Leave
        subActualizaDia(txtDia08.Text)
    End Sub
    Private Sub txtDia09_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia09.Leave
        subActualizaDia(txtDia09.Text)
    End Sub
    Private Sub txtDia10_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia10.Leave
        subActualizaDia(txtDia10.Text)
    End Sub
    Private Sub txtDia11_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia11.Leave
        subActualizaDia(txtDia11.Text)
    End Sub


    Private Sub subActualizaDia(ByVal txtDia As String)

        txtDia01.Text = txtDia
        txtDia02.Text = txtDia
        txtDia03.Text = txtDia
        txtDia04.Text = txtDia
        txtDia05.Text = txtDia
        txtDia06.Text = txtDia
        txtDia07.Text = txtDia
        txtDia08.Text = txtDia
        txtDia09.Text = txtDia
        txtDia10.Text = txtDia
        txtDia11.Text = txtDia

    End Sub




    'eventos de sincronizacion de mes de asistencia
    Private Sub txtMes01_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes01.Leave
        subActualizaMes(txtMes01.Text)
    End Sub
    Private Sub txtMes02_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes02.Leave
        subActualizaMes(txtMes02.Text)
    End Sub
    Private Sub txtMes03_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes03.Leave
        subActualizaMes(txtMes03.Text)
    End Sub
    Private Sub txtMes04_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes04.Leave
        subActualizaMes(txtMes04.Text)
    End Sub
    Private Sub txtMes05_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes05.Leave
        subActualizaMes(txtMes05.Text)
    End Sub
    Private Sub txtMes06_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes06.Leave
        subActualizaMes(txtMes06.Text)
    End Sub
    Private Sub txtMes07_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes07.Leave
        subActualizaMes(txtMes07.Text)
    End Sub
    Private Sub txtMes08_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes08.Leave
        subActualizaMes(txtMes08.Text)
    End Sub
    Private Sub txtMes09_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes09.Leave
        subActualizaMes(txtMes09.Text)
    End Sub
    Private Sub txtMes10_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes10.Leave
        subActualizaMes(txtMes10.Text)
    End Sub
    Private Sub txtMes11_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes11.Leave
        subActualizaMes(txtMes11.Text)
    End Sub


    Private Sub subActualizaMes(ByVal txtMes As String)

        txtMes01.Text = txtMes
        txtMes02.Text = txtMes
        txtMes03.Text = txtMes
        txtMes04.Text = txtMes
        txtMes05.Text = txtMes
        txtMes06.Text = txtMes
        txtMes07.Text = txtMes
        txtMes08.Text = txtMes
        txtMes09.Text = txtMes
        txtMes10.Text = txtMes
        txtMes11.Text = txtMes

    End Sub

    'eventos de sincronizacion de Año de asistencia
    Private Sub txtAño01_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño01.Leave
        subActualizaAño(txtAño01.Text)
    End Sub
    Private Sub txtAño02_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño02.Leave
        subActualizaAño(txtAño02.Text)
    End Sub
    Private Sub txtAño03_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño03.Leave
        subActualizaAño(txtAño03.Text)
    End Sub
    Private Sub txtAño04_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño04.Leave
        subActualizaAño(txtAño04.Text)
    End Sub
    Private Sub txtAño05_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño05.Leave
        subActualizaAño(txtAño05.Text)
    End Sub
    Private Sub txtAño06_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño06.Leave
        subActualizaAño(txtAño06.Text)
    End Sub
    Private Sub txtAño07_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño07.Leave
        subActualizaAño(txtAño07.Text)
    End Sub
    Private Sub txtAño08_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño08.Leave
        subActualizaAño(txtAño08.Text)
    End Sub
    Private Sub txtAño09_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño09.Leave
        subActualizaAño(txtAño09.Text)
    End Sub
    Private Sub txtAño10_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño10.Leave
        subActualizaAño(txtAño10.Text)
    End Sub
    Private Sub txtAño11_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAño11.Leave
        subActualizaAño(txtAño11.Text)
    End Sub


    Private Sub subActualizaAño(ByVal txtAño As String)

        txtAño01.Text = txtAño
        txtAño02.Text = txtAño
        txtAño03.Text = txtAño
        txtAño04.Text = txtAño
        txtAño05.Text = txtAño
        txtAño06.Text = txtAño
        txtAño07.Text = txtAño
        txtAño08.Text = txtAño
        txtAño09.Text = txtAño
        txtAño10.Text = txtAño
        txtAño11.Text = txtAño

    End Sub

    'sincronizacion de Edad de estudios y examenes

    Private Sub txtEdad07_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEdad07.Leave
        'se salio de cuadro de Edad 07, se actualizan los demas
        txtEdad08.Text = txtEdad07.Text
        txtEdad09.Text = txtEdad07.Text
        txtEdad10.Text = txtEdad07.Text
        'txtEdad05.Text = txtEdad01.Text
        'txtEdad06.Text = txtEdad01.Text
    End Sub
    Private Sub txtEdad08_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEdad08.Leave
        'se salio de cuadro de Edad 08, se actualizan los demas
        txtEdad07.Text = txtEdad08.Text
        txtEdad09.Text = txtEdad08.Text
        txtEdad10.Text = txtEdad08.Text
        'txtEdad05.Text = txtEdad02.Text
        'txtEdad06.Text = txtEdad02.Text
    End Sub
    Private Sub txtEdad09_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEdad09.Leave
        'se salio de cuadro de Edad 09, se actualizan los demas
        txtEdad07.Text = txtEdad09.Text
        txtEdad08.Text = txtEdad09.Text
        txtEdad10.Text = txtEdad09.Text
        'txtEdad05.Text = txtEdad03.Text
        'txtEdad06.Text = txtEdad03.Text
    End Sub
    Private Sub txtEdad10_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEdad10.Leave
        'se salio de cuadro de Edad 10, se actualizan los demas
        txtEdad07.Text = txtEdad10.Text
        txtEdad08.Text = txtEdad10.Text
        txtEdad09.Text = txtEdad10.Text
        'txtEdad05.Text = txtEdad04.Text
        'txtEdad06.Text = txtEdad04.Text
    End Sub

    'sincronizacion de Paridad de estudios y examenes

    Private Sub txtParidad07_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtParidad07.Leave
        'se salio de cuadro de Paridad 07, se actualizan los demas
        txtParidad08.Text = txtParidad07.Text
        txtParidad09.Text = txtParidad07.Text
        txtParidad10.Text = txtParidad07.Text
        'txtParidad05.Text = txtParidad01.Text
        'txtParidad06.Text = txtParidad01.Text
    End Sub
    Private Sub txtParidad08_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtParidad08.Leave
        'se salio de cuadro de Paridad 08, se actualizan los demas
        txtParidad07.Text = txtParidad08.Text
        txtParidad09.Text = txtParidad08.Text
        txtParidad10.Text = txtParidad08.Text
        'txtParidad05.Text = txtParidad02.Text
        'txtParidad06.Text = txtParidad02.Text
    End Sub
    Private Sub txtParidad09_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtParidad09.Leave
        'se salio de cuadro de Paridad 09, se actualizan los demas
        txtParidad07.Text = txtParidad09.Text
        txtParidad08.Text = txtParidad09.Text
        txtParidad10.Text = txtParidad09.Text
        'txtParidad05.Text = txtParidad03.Text
        'txtParidad06.Text = txtParidad03.Text
    End Sub
    Private Sub txtParidad10_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtParidad10.Leave
        'se salio de cuadro de Paridad 10, se actualizan los demas
        txtParidad07.Text = txtParidad10.Text
        txtParidad08.Text = txtParidad10.Text
        txtParidad09.Text = txtParidad10.Text
        'txtParidad05.Text = txtParidad04.Text
        'txtParidad06.Text = txtParidad04.Text
    End Sub

    'sincronizacion de Semanas de estudios y examenes

    Private Sub txtSemanas07_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSemanas07.Leave
        'se salio de cuadro de Semanas 07, se actualizan los demas
        txtSemanas08.Text = txtSemanas07.Text
        txtSemanas09.Text = txtSemanas07.Text
        txtSemanas10.Text = txtSemanas07.Text
        'txtSemanas05.Text = txtSemanas01.Text
        'txtSemanas06.Text = txtSemanas01.Text
    End Sub
    Private Sub txtSemanas08_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSemanas08.Leave
        'se salio de cuadro de Semanas 08, se actualizan los demas
        txtSemanas07.Text = txtSemanas08.Text
        txtSemanas09.Text = txtSemanas08.Text
        txtSemanas10.Text = txtSemanas08.Text
        'txtSemanas05.Text = txtSemanas02.Text
        'txtSemanas06.Text = txtSemanas02.Text
    End Sub
    Private Sub txtSemanas09_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSemanas09.Leave
        'se salio de cuadro de Semanas 09, se actualizan los demas
        txtSemanas07.Text = txtSemanas09.Text
        txtSemanas08.Text = txtSemanas09.Text
        txtSemanas10.Text = txtSemanas09.Text
        'txtSemanas05.Text = txtSemanas03.Text
        'txtSemanas06.Text = txtSemanas03.Text
    End Sub
    Private Sub txtSemanas10_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSemanas10.Leave
        'se salio de cuadro de Semanas 10, se actualizan los demas
        txtSemanas07.Text = txtSemanas10.Text
        txtSemanas08.Text = txtSemanas10.Text
        txtSemanas09.Text = txtSemanas10.Text
        'txtSemanas05.Text = txtSemanas04.Text
        'txtSemanas06.Text = txtSemanas04.Text
    End Sub

    'sincronizacion de Op de estudios y examenes

    Private Sub txtOp09_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOp09.Leave
        'se salio de cuadro de Op 07, se actualizan los demas
        txtOp10.Text = txtOp09.Text
    End Sub
    Private Sub txtOp10_Salida(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOp10.Leave
        'se salio de cuadro de Op 08, se actualizan los demas
        txtOp09.Text = txtOp10.Text
    End Sub



    Private Sub botCalculaInicioReposo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCalculaInicioReposo.Click
        Dim fur As Date
        Dim furTXT As String
        Dim fpp As Date

        Dim furDia As Integer
        Dim furMes As Integer
        Dim furAño As Integer

        If txtDiaFUR.Text <> "" And txtMesFUR.Text <> "" And txtAñoFUR.Text <> "" Then
            'se introdujo la fur, espero que este bien

            'prime contruimos la fecha de verdad:
            If IsNumeric(txtDiaFUR.Text) Then
                'si se introdujo un numero ahora ve si es menor de 31
                furDia = txtDiaFUR.Text
                If furDia > 0 And furDia < 32 Then
                    'esta en el limite bueno no hace nada aun pero continua el sub
                Else
                    'esta fuera del rango de 31 dias
                    MsgBox("Por favor corrige el día de la FUR...", MsgBoxStyle.Information)
                    txtDiaInicio02.Clear()
                    txtMesInicio02.Clear()
                    txtAñoInicio02.Clear()
                    Exit Sub
                End If
            Else
                'no se introdujo un numero en la fecha
                MsgBox("Por favor corrige el día de la FUR...", MsgBoxStyle.Information)
                txtDiaInicio02.Clear()
                txtMesInicio02.Clear()
                txtAñoInicio02.Clear()
                Exit Sub
            End If

            'ahora vamos con el mes

            Dim Mes As String
            Mes = txtMesFUR.Text
            Mes = Mes.ToLower


            If Mes = "enero" Or Mes = "01" Or Mes = "1" Then
                furMes = 1
            ElseIf Mes = "febrero" Or Mes = "02" Or Mes = "2" Then
                furMes = 2
            ElseIf Mes = "marzo" Or Mes = "03" Or Mes = "3" Then
                furMes = 3
            ElseIf Mes = "abril" Or Mes = "04" Or Mes = "4" Then
                furMes = 4
            ElseIf Mes = "mayo" Or Mes = "05" Or Mes = "5" Then
                furMes = 5
            ElseIf Mes = "junio" Or Mes = "06" Or Mes = "6" Then
                furMes = 6
            ElseIf Mes = "julio" Or Mes = "07" Or Mes = "7" Then
                furMes = 7
            ElseIf Mes = "agosto" Or Mes = "08" Or Mes = "8" Then
                furMes = 8
            ElseIf Mes = "septiembre" Or Mes = "09" Or Mes = "9" Then
                furMes = 9
            ElseIf Mes = "octubre" Or Mes = "10" Then
                furMes = 10
            ElseIf Mes = "noviembre" Or Mes = "11" Then
                furMes = 11
            ElseIf Mes = "diciembre" Or Mes = "12" Then
                furMes = 12
            Else
                'no se introdujo adecuadamente el mes
                MsgBox("Por favor corrige el mes de la FUR...", MsgBoxStyle.Information)
                txtDiaInicio02.Clear()
                txtMesInicio02.Clear()
                txtAñoInicio02.Clear()
                Exit Sub
            End If

            'ahora el año
            If IsNumeric(txtAñoFUR.Text) Then

                Dim Año As String
                Año = txtAñoFUR.Text
                If Año.Length = 1 Then
                    'no se introdujo adecuadamente el año
                    MsgBox("Por favor corrige el año de la FUR...", MsgBoxStyle.Information)
                    txtDiaInicio02.Clear()
                    txtMesInicio02.Clear()
                    txtAñoInicio02.Clear()
                    Exit Sub
                ElseIf Año.Length = 2 Then
                    Año = "20" & Año
                    txtAñoFUR.Text = Año
                ElseIf Año.Length = 3 Then
                    'no se introdujo adecuadamente el año
                    MsgBox("Por favor corrige el año de la FUR...", MsgBoxStyle.Information)
                    txtDiaInicio02.Clear()
                    txtMesInicio02.Clear()
                    txtAñoInicio02.Clear()
                    Exit Sub
                ElseIf Año.Length = 4 Then
                    'ok no hace nada solo lo saca aca para q siga
                Else
                    'es mas de 4 esta mal
                    MsgBox("Por favor corrige el año de la FUR...", MsgBoxStyle.Information)
                    txtDiaInicio02.Clear()
                    txtMesInicio02.Clear()
                    txtAñoInicio02.Clear()
                    Exit Sub
                End If
                furAño = Año
            Else
                'no se introdujo adecuadamente el año
                MsgBox("Por favor corrige el año de la FUR...", MsgBoxStyle.Information)
                txtDiaInicio02.Clear()
                txtMesInicio02.Clear()
                txtAñoInicio02.Clear()
                Exit Sub
            End If

            'si llega hasta aqui es que todo esta bien
            furTXT = furDia & "/" & furMes & "/" & furAño

            If IsDate(furTXT) Then
                'al fin tenemos una fecha valida procesa la vaina
                fur = furTXT
                'calcula la fpp
                fpp = fur.AddDays(238)

                'pone el dia
                txtDiaInicio02.Text = fpp.Day.ToString
                If txtDiaInicio02.Text.Length = 1 Then
                    txtDiaInicio02.Text = "0" & txtDiaInicio02.Text
                End If

                'pone el mes
                Dim inicioMes As Integer

                inicioMes = fpp.Month
                If inicioMes = 1 Then
                    txtMesInicio02.Text = "Enero"
                ElseIf inicioMes = 2 Then
                    txtMesInicio02.Text = "Febrero"
                ElseIf inicioMes = 3 Then
                    txtMesInicio02.Text = "Marzo"
                ElseIf inicioMes = 4 Then
                    txtMesInicio02.Text = "Abril"
                ElseIf inicioMes = 5 Then
                    txtMesInicio02.Text = "Mayo"
                ElseIf inicioMes = 6 Then
                    txtMesInicio02.Text = "Junio"
                ElseIf inicioMes = 7 Then
                    txtMesInicio02.Text = "Julio"
                ElseIf inicioMes = 8 Then
                    txtMesInicio02.Text = "Agosto"
                ElseIf inicioMes = 9 Then
                    txtMesInicio02.Text = "Septiembre"
                ElseIf inicioMes = 10 Then
                    txtMesInicio02.Text = "Octubre"
                ElseIf inicioMes = 11 Then
                    txtMesInicio02.Text = "Noviembre"
                ElseIf inicioMes = 12 Then
                    txtMesInicio02.Text = "Diciembre"
                End If

                'pone el año
                txtAñoInicio02.Text = fpp.Year.ToString

            Else
                'la fecha no existe pued ser por ejemplo 30 de febrero...
                MsgBox("Por favor corrige la FUR, introduciste una fecha inválida", MsgBoxStyle.Information)
                txtDiaInicio02.Clear()
                txtMesInicio02.Clear()
                txtAñoInicio02.Clear()
                Exit Sub
            End If
        Else
            'falta al menos un dato
            MsgBox("Primero introduce la Fecha de Ultima Regla", MsgBoxStyle.Information)
            txtDiaInicio02.Clear()
            txtMesInicio02.Clear()
            txtAñoInicio02.Clear()
        End If
    End Sub


    'eventos del mouse sobre los botones
    Private Sub botAbreBaseDatos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotAbreBaseDatos.MouseEnter
        BotAbreBaseDatos.Image = BotonOnGrande
    End Sub
    Private Sub botAbreBaseDatos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BotAbreBaseDatos.MouseLeave
        BotAbreBaseDatos.Image = BotonOffGrande
    End Sub

    Private Sub botVistaPrevia_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botVistaPrevia.MouseEnter
        botVistaPrevia.Image = BotonOnGrande
    End Sub
    Private Sub botVistaPrevia_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botVistaPrevia.MouseLeave
        botVistaPrevia.Image = BotonOffGrande
    End Sub

    Private Sub botSuma01_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSuma01.MouseEnter
        botSuma01.Image = FlechaDerOn
    End Sub
    Private Sub botSuma01_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSuma01.MouseLeave
        botSuma01.Image = FlechaDerOff
    End Sub
    Private Sub botSuma02_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSuma02.MouseEnter
        botSuma02.Image = FlechaDerOn
    End Sub
    Private Sub botSuma02_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSuma02.MouseLeave
        botSuma02.Image = FlechaDerOff
    End Sub
    Private Sub botSuma03_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSuma03.MouseEnter
        botSuma03.Image = FlechaDerOn
    End Sub
    Private Sub botSuma03_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSuma03.MouseLeave
        botSuma03.Image = FlechaDerOff
    End Sub
    Private Sub botSuma04_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSuma04.MouseEnter
        botSuma04.Image = FlechaDerOn
    End Sub
    Private Sub botSuma04_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSuma04.MouseLeave
        botSuma04.Image = FlechaDerOff
    End Sub

    Private Sub botResta01_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botResta01.MouseEnter
        botResta01.Image = FlechaIzqOn
    End Sub
    Private Sub botResta01_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botResta01.MouseLeave
        botResta01.Image = FlechaIzqOff
    End Sub
    Private Sub botResta02_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botResta02.MouseEnter
        botResta02.Image = FlechaIzqOn
    End Sub
    Private Sub botResta02_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botResta02.MouseLeave
        botResta02.Image = FlechaIzqOff
    End Sub
    Private Sub botResta03_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botResta03.MouseEnter
        botResta03.Image = FlechaIzqOn
    End Sub
    Private Sub botResta03_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botResta03.MouseLeave
        botResta03.Image = FlechaIzqOff
    End Sub
    Private Sub botResta04_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botResta04.MouseEnter
        botResta04.Image = FlechaIzqOn
    End Sub
    Private Sub botResta04_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botResta04.MouseLeave
        botResta04.Image = FlechaIzqOff
    End Sub











    
  
   
End Class
