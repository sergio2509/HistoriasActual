Imports System.IO

Public Class FormControlEcografico2
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
    Friend WithEvents PanelNuevoControl1erT As System.Windows.Forms.Panel
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txt1erTidx01 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Rad1erTActCardiaca2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad1erTActCardiaca1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Rad1erTMovimientos2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad1erTMovimientos1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Rad1erTEmbrion2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad1erTEmbrion1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Rad1erTImplantacion4 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad1erTImplantacion3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad1erTImplantacion2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad1erTImplantacion1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents labFUR1erT As System.Windows.Forms.Label
    Friend WithEvents txtParidad1erT As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents labNombre1erT As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents labFechaControl1erT As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lab1ertEGxFUR01 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents labFPP1erT As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lab1erEGxLCC As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt1erLCC As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lab1erEGxSG As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lab1erSGprom As System.Windows.Forms.Label
    Friend WithEvents txt1erSGtrans As System.Windows.Forms.TextBox
    Friend WithEvents txt1erSGantPost As System.Windows.Forms.TextBox
    Friend WithEvents txt1erSGlong As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelNuevoControl2y3erT As System.Windows.Forms.Panel
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAnatomicos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents radExtremidades2 As System.Windows.Forms.RadioButton
    Friend WithEvents radExtremidades1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents radRiñones2 As System.Windows.Forms.RadioButton
    Friend WithEvents radRiñones1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents radAbdomen2 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbdomen1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents radCorazon2 As System.Windows.Forms.RadioButton
    Friend WithEvents radCorazon1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents radTorax2 As System.Windows.Forms.RadioButton
    Friend WithEvents radTorax1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents radColumna2 As System.Windows.Forms.RadioButton
    Friend WithEvents radColumna1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents radVentriculo2 As System.Windows.Forms.RadioButton
    Friend WithEvents radVentriculo1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents radCabeza2 As System.Windows.Forms.RadioButton
    Friend WithEvents radCabeza1 As System.Windows.Forms.RadioButton
    Friend WithEvents TabPageBiometricos As System.Windows.Forms.TabPage
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txtTransAbdomen As System.Windows.Forms.TextBox
    Friend WithEvents txtFemur As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtSacro As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtAorta As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtAPC As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtAPT As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtDOF As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtDBP As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TabPageFuncionales As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox30 As System.Windows.Forms.GroupBox
    Friend WithEvents radVejiga2 As System.Windows.Forms.RadioButton
    Friend WithEvents radVejiga1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox31 As System.Windows.Forms.GroupBox
    Friend WithEvents radIntestino2 As System.Windows.Forms.RadioButton
    Friend WithEvents radIntestino1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox32 As System.Windows.Forms.GroupBox
    Friend WithEvents radCamaraGastrica2 As System.Windows.Forms.RadioButton
    Friend WithEvents radCamaraGastrica1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox27 As System.Windows.Forms.GroupBox
    Friend WithEvents radAortoCava2 As System.Windows.Forms.RadioButton
    Friend WithEvents radAortoCava1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox28 As System.Windows.Forms.GroupBox
    Friend WithEvents radMovimientosRespiratorios2 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovimientosRespiratorios1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox29 As System.Windows.Forms.GroupBox
    Friend WithEvents radActividadCardiaca2 As System.Windows.Forms.RadioButton
    Friend WithEvents radActividadCardiaca1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox26 As System.Windows.Forms.GroupBox
    Friend WithEvents radMovimientosFetales2 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovimientosFetales1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox25 As System.Windows.Forms.GroupBox
    Friend WithEvents radTono2 As System.Windows.Forms.RadioButton
    Friend WithEvents radTono1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents radActitud2 As System.Windows.Forms.RadioButton
    Friend WithEvents radActitud1 As System.Windows.Forms.RadioButton
    Friend WithEvents TabPagePlacentarios As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox37 As System.Windows.Forms.GroupBox
    Friend WithEvents radCordon2 As System.Windows.Forms.RadioButton
    Friend WithEvents radCordon1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox36 As System.Windows.Forms.GroupBox
    Friend WithEvents txtILA As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents radLiquidoAmniotico2 As System.Windows.Forms.RadioButton
    Friend WithEvents radLiquidoAmniotico1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox35 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPlacentaGrosor As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents GroupBox34 As System.Windows.Forms.GroupBox
    Friend WithEvents radPlacenta7 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacenta6 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacenta5 As System.Windows.Forms.RadioButton
    Friend WithEvents radplacenta4 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacenta3 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacenta2 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacenta1 As System.Windows.Forms.RadioButton
    Friend WithEvents TabPageIDx As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox43 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents labFUR2y3erT As System.Windows.Forms.Label
    Friend WithEvents txtParidad2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents labNombre2y3erT As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents labFechaControl2y3erT As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents labEGxFUR2y3erT As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents labFPP2y3erT As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents PanelNuevoControlGinecologico As System.Windows.Forms.Panel
    Friend WithEvents GroupBox49 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox47 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOvarioIzquierdoFoliculo4 As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioIzquierdoFoliculo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioIzquierdoFoliculo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioIzquierdoFoliculo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioDerechoFoliculo4 As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioDerechoFoliculo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioDerechoFoliculo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioDerechoFoliculo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents GroupBox46 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOvarioIzquierdoTransverso As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioDerechoTransverso As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioIzquierdoAnteroPosterior As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioDerechoAnteroPosterior As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioIzquierdoLongitudinal As System.Windows.Forms.TextBox
    Friend WithEvents txtOvarioDerechoLongitudinal As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents GroupBox45 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUteroEndometrio As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents txtUteroTransverso As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents txtUteroAnteroPosterior As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents txtUteroLongitudinal As System.Windows.Forms.TextBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents GroupBox44 As System.Windows.Forms.GroupBox
    Friend WithEvents labFURginecologico As System.Windows.Forms.Label
    Friend WithEvents txtParidadGinecologico As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents labEdadGinecologico As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents labNombreGinecologico As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents labFechaControlGinecologico As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents labDiaCicloGinecologico As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents TP02 As System.Windows.Forms.TabPage
    Friend WithEvents TP01 As System.Windows.Forms.TabPage
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtAntFamiliares As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents txtAntPersonales As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents txtAntGinecologicos As System.Windows.Forms.TextBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents txtAntObstetricos As System.Windows.Forms.TextBox
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents txtAntQuirurgicos As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents txtProfesion As System.Windows.Forms.TextBox
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents txtFechaNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents txtNombrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents botSalirSinGuardar As System.Windows.Forms.Button
    Friend WithEvents botGuardarNuevosDatos As System.Windows.Forms.Button
    Friend WithEvents botRenombra As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents botElimina As System.Windows.Forms.Button
    Friend WithEvents botNuevo As System.Windows.Forms.Button
    Friend WithEvents botSelecciona As System.Windows.Forms.Button
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents ListBoxInformes As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxImagenes As System.Windows.Forms.ListBox
    Friend WithEvents botRenombraImagen As System.Windows.Forms.Button
    Friend WithEvents botEliminaImagen As System.Windows.Forms.Button
    Friend WithEvents botNuevaImagen As System.Windows.Forms.Button
    Friend WithEvents botAbreImagen As System.Windows.Forms.Button
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents txtFechaInicioControl As System.Windows.Forms.TextBox
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents labInforme As System.Windows.Forms.Label
    Friend WithEvents TP04 As System.Windows.Forms.TabPage
    Friend WithEvents TP03 As System.Windows.Forms.TabPage
    Friend WithEvents PanelImpresion As System.Windows.Forms.Panel
    Friend WithEvents txtFechaInicioControl2 As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents labInforme2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents botCreaImpresion As System.Windows.Forms.Button
    Friend WithEvents txtInforme As System.Windows.Forms.TextBox
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents botIMPRIME As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menuCalculaEGconECO As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu2 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu3 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu4 As System.Windows.Forms.MainMenu
    Friend WithEvents MainMenu5 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents menuCalculaEGconFUR As System.Windows.Forms.MenuItem
    Friend WithEvents menuCalculaDCconFUR As System.Windows.Forms.MenuItem
    Friend WithEvents TabPageObstetricos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents radPosicion4 As System.Windows.Forms.RadioButton
    Friend WithEvents radPosicion3 As System.Windows.Forms.RadioButton
    Friend WithEvents radPosicion2 As System.Windows.Forms.RadioButton
    Friend WithEvents radPosicion1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents radSituacion3 As System.Windows.Forms.RadioButton
    Friend WithEvents radSituacion2 As System.Windows.Forms.RadioButton
    Friend WithEvents radSituacion1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents radpresentacion3 As System.Windows.Forms.RadioButton
    Friend WithEvents radPresentacion2 As System.Windows.Forms.RadioButton
    Friend WithEvents radPresentacion1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox50 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox51 As System.Windows.Forms.GroupBox
    Friend WithEvents radFeto02 As System.Windows.Forms.RadioButton
    Friend WithEvents radFeto01 As System.Windows.Forms.RadioButton
    Friend WithEvents radEmbarazo02 As System.Windows.Forms.RadioButton
    Friend WithEvents radEmbarazo01 As System.Windows.Forms.RadioButton
    Friend WithEvents radPosicion8 As System.Windows.Forms.RadioButton
    Friend WithEvents radPosicion7 As System.Windows.Forms.RadioButton
    Friend WithEvents radPosicion6 As System.Windows.Forms.RadioButton
    Friend WithEvents radPosicion5 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAtrio As System.Windows.Forms.TextBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents txtTCer As System.Windows.Forms.TextBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents txtPN As System.Windows.Forms.TextBox
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents txtIOI As System.Windows.Forms.TextBox
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents txtIOE As System.Windows.Forms.TextBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents txtNODF As System.Windows.Forms.TextBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents txtUlna As System.Windows.Forms.TextBox
    Friend WithEvents txtNOPT As System.Windows.Forms.TextBox
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents txtHumero As System.Windows.Forms.TextBox
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtCA As System.Windows.Forms.TextBox
    Friend WithEvents txtTibia As System.Windows.Forms.TextBox
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents txtTalla As System.Windows.Forms.TextBox
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents txtBPF As System.Windows.Forms.TextBox
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents txtNOPH As System.Windows.Forms.TextBox
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents GroupBox52 As System.Windows.Forms.GroupBox
    Friend WithEvents radRostro2 As System.Windows.Forms.RadioButton
    Friend WithEvents radRostro1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox53 As System.Windows.Forms.GroupBox
    Friend WithEvents radSexo2 As System.Windows.Forms.RadioButton
    Friend WithEvents radSexo1 As System.Windows.Forms.RadioButton
    Friend WithEvents radIntestino5 As System.Windows.Forms.RadioButton
    Friend WithEvents radIntestino4 As System.Windows.Forms.RadioButton
    Friend WithEvents radIntestino3 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacentaGrado1 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacentaGrado2 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacenta8 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacentaGrado7 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacentaGrado6 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacentaGrado5 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacentaGrado4 As System.Windows.Forms.RadioButton
    Friend WithEvents radPlacentaGrado3 As System.Windows.Forms.RadioButton
    Friend WithEvents txtEdad2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSug01del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents txtSug02del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents txtIdx05del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtIdx01del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents txtIdx02del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txtIdx04del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtIdx03del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents botCalculaEG As System.Windows.Forms.Button
    Friend WithEvents botCalculaEcopuntaje As System.Windows.Forms.Button
    Friend WithEvents botCalculaPerfil As System.Windows.Forms.Button
    Friend WithEvents botCalculaPercentil As System.Windows.Forms.Button
    Friend WithEvents TabPageNotas As System.Windows.Forms.TabPage
    Friend WithEvents txtNotas02del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents txtNotas01del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtNotas03del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents txtIDx07del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents txtIDx06del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents txtIDx08del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents txtSug03del2y3erT As System.Windows.Forms.TextBox
    Friend WithEvents botCalculaCC As System.Windows.Forms.Button
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents txtEdad1erT As System.Windows.Forms.TextBox
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rad1erTestudioTV As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTEstudioAbd As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rad1erTfrec75 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTfrec50 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTfrec35 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents rad1erTVitelina02 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTVitelina01 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox33 As System.Windows.Forms.GroupBox
    Friend WithEvents rad1erTVejiga02 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTVejiga01 As System.Windows.Forms.RadioButton
    Friend WithEvents txt1erVVantPost As System.Windows.Forms.TextBox
    Friend WithEvents txt1erVVlong As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txt1erTComentarios01 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox38 As System.Windows.Forms.GroupBox
    Friend WithEvents rad1erTlocalizacionEmbarazo02 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTLocalizacionEmbarazo01 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox39 As System.Windows.Forms.GroupBox
    Friend WithEvents rad1erTtranslucencia02 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTtranslucencia01 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox40 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox42 As System.Windows.Forms.GroupBox
    Friend WithEvents rad1erTductusVenoso02 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTductusVenoso01 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox41 As System.Windows.Forms.GroupBox
    Friend WithEvents rad1erThuesosNasales02 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erThuesosNasales01 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox54 As System.Windows.Forms.GroupBox
    Friend WithEvents rad1erTanguloFM02 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTanguloFM01 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox55 As System.Windows.Forms.GroupBox
    Friend WithEvents rad1erTtipoEmbarazo02 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTtipoEmbarazo01 As System.Windows.Forms.RadioButton
    Friend WithEvents botResetRadButtons1erT As System.Windows.Forms.Button
    Friend WithEvents GroupBox56 As System.Windows.Forms.GroupBox
    Friend WithEvents rad1erTsacoGestacional02 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1erTsacoGestacional01 As System.Windows.Forms.RadioButton
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lab1ertEGxFUR02 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txt1erTidx03 As System.Windows.Forms.TextBox
    Friend WithEvents txt1erTidx02 As System.Windows.Forms.TextBox
    Friend WithEvents txt1erTcomentarios05 As System.Windows.Forms.TextBox
    Friend WithEvents txt1erTcomentarios04 As System.Windows.Forms.TextBox
    Friend WithEvents txt1erTcomentarios03 As System.Windows.Forms.TextBox
    Friend WithEvents txt1erTcomentarios02 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl5 As System.Windows.Forms.TabControl
    Friend WithEvents TabGinBiometricos As System.Windows.Forms.TabPage
    Friend WithEvents TabGinUtero As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents radTipoEstudioGinecologico1 As System.Windows.Forms.RadioButton
    Friend WithEvents radTipoEstudioGinecologico2 As System.Windows.Forms.RadioButton
    Friend WithEvents TabIDxGin As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents radGINfrec75 As System.Windows.Forms.RadioButton
    Friend WithEvents radGINfrec50 As System.Windows.Forms.RadioButton
    Friend WithEvents radGINfrec35 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroPosicion2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroPosicion1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroEcopatron1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroEcopatron2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroInclinacion3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroInclinacion1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroInclinacion2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroPosicion3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroEndometrio5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroEndometrio4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroEndometrio3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroEndometrio1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroEndometrio2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroBordes1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroBordes2 As System.Windows.Forms.RadioButton
    Friend WithEvents TabGinVejiga As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox62 As System.Windows.Forms.GroupBox
    Friend WithEvents RadGinVejigaVolumen1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinVejigaVolumen2 As System.Windows.Forms.RadioButton
    Friend WithEvents TabGinOvarios As System.Windows.Forms.TabPage
    Friend WithEvents TabGinOtros As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox59 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGinVejigaObservaciones2 As System.Windows.Forms.TextBox
    Friend WithEvents txtGinVejigaObservaciones1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox58 As System.Windows.Forms.GroupBox
    Friend WithEvents RadGinVejigaParedes2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinVejigaParedes1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox57 As System.Windows.Forms.GroupBox
    Friend WithEvents RadGinVejigaAdecuada2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinVejigaAdecuada1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinVejigaVolumen3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox63 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox60 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox66 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox65 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox64 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox67 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGinUteroObservaciones2 As System.Windows.Forms.TextBox
    Friend WithEvents txtGinUteroObservaciones1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox61 As System.Windows.Forms.GroupBox
    Friend WithEvents RadGinUteroCavidad5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroCavidad1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroCavidad4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroCavidad2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinUteroCavidad3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox68 As System.Windows.Forms.GroupBox
    Friend WithEvents RadGinOvarioDerechoTamano3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinOvarioDerechoTamano1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinOvarioDerechoTamano2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox70 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox71 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGinOvarioIzquierdoObservaciones4 As System.Windows.Forms.TextBox
    Friend WithEvents txtGinOvarioIzquierdoObservaciones3 As System.Windows.Forms.TextBox
    Friend WithEvents txtGinOvarioIzquierdoObservaciones2 As System.Windows.Forms.TextBox
    Friend WithEvents txtGinOvarioIzquierdoObservaciones1 As System.Windows.Forms.TextBox
    Friend WithEvents RadGinOvarioIzquierdoTamano3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinOvarioIzquierdoTamano1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinOvarioIzquierdoTamano2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox69 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGinOvarioDerechoObservaciones4 As System.Windows.Forms.TextBox
    Friend WithEvents txtGinOvarioDerechoObservaciones3 As System.Windows.Forms.TextBox
    Friend WithEvents txtGinOvarioDerechoObservaciones2 As System.Windows.Forms.TextBox
    Friend WithEvents txtGinOvarioDerechoObservaciones1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox73 As System.Windows.Forms.GroupBox
    Friend WithEvents RadGinDouglas1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinDouglas2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox72 As System.Windows.Forms.GroupBox
    Friend WithEvents RadGinTrompas4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinTrompas3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinTrompas1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinTrompas2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtGinOtrosObservaciones2 As System.Windows.Forms.TextBox
    Friend WithEvents txtGinOtrosObservaciones1 As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtGinIDx4 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtGinIDx3 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtGinIDx2 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtGinIDx1 As System.Windows.Forms.TextBox
    Friend WithEvents lab2y3egxDBP As System.Windows.Forms.Label
    Friend WithEvents lab2y3egxFem As System.Windows.Forms.Label
    Friend WithEvents lab2y3egxCA As System.Windows.Forms.Label
    Friend WithEvents lab2y3egxCC As System.Windows.Forms.Label
    Friend WithEvents lab1erEGxFemur As System.Windows.Forms.Label
    Friend WithEvents txt1erFemur As System.Windows.Forms.TextBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents lab1erEGxCA As System.Windows.Forms.Label
    Friend WithEvents txt1erCA As System.Windows.Forms.TextBox
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents lab1erEGxCC As System.Windows.Forms.Label
    Friend WithEvents txt1erCC As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents lab1erEGxDBP As System.Windows.Forms.Label
    Friend WithEvents txt1erDBP As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txt1erTN As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txt1erEGxECO As System.Windows.Forms.TextBox
    Friend WithEvents botGuardarYsalir As System.Windows.Forms.Button
    Friend WithEvents labCambios As System.Windows.Forms.Label
    Friend WithEvents chkImprimeMembrete As CheckBox
    Friend WithEvents chkMedidasUsuales As CheckBox
    Friend WithEvents botPersonaliza As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormControlEcografico2))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TP01 = New System.Windows.Forms.TabPage()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.botRenombraImagen = New System.Windows.Forms.Button()
        Me.botEliminaImagen = New System.Windows.Forms.Button()
        Me.botNuevaImagen = New System.Windows.Forms.Button()
        Me.botAbreImagen = New System.Windows.Forms.Button()
        Me.ListBoxImagenes = New System.Windows.Forms.ListBox()
        Me.botRenombra = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.botElimina = New System.Windows.Forms.Button()
        Me.botNuevo = New System.Windows.Forms.Button()
        Me.botSelecciona = New System.Windows.Forms.Button()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.ListBoxInformes = New System.Windows.Forms.ListBox()
        Me.TP02 = New System.Windows.Forms.TabPage()
        Me.PanelNuevoControl1erT = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt1erTN = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.lab1erEGxFemur = New System.Windows.Forms.Label()
        Me.txt1erFemur = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.lab1erEGxCA = New System.Windows.Forms.Label()
        Me.txt1erCA = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.lab1erEGxCC = New System.Windows.Forms.Label()
        Me.txt1erCC = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.lab1erEGxDBP = New System.Windows.Forms.Label()
        Me.txt1erDBP = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txt1erVVantPost = New System.Windows.Forms.TextBox()
        Me.txt1erVVlong = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rad1erTfrec75 = New System.Windows.Forms.RadioButton()
        Me.rad1erTfrec50 = New System.Windows.Forms.RadioButton()
        Me.rad1erTfrec35 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rad1erTestudioTV = New System.Windows.Forms.RadioButton()
        Me.rad1erTEstudioAbd = New System.Windows.Forms.RadioButton()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lab1erEGxLCC = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt1erLCC = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lab1erEGxSG = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lab1erSGprom = New System.Windows.Forms.Label()
        Me.txt1erSGtrans = New System.Windows.Forms.TextBox()
        Me.txt1erSGantPost = New System.Windows.Forms.TextBox()
        Me.txt1erSGlong = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox56 = New System.Windows.Forms.GroupBox()
        Me.rad1erTsacoGestacional02 = New System.Windows.Forms.RadioButton()
        Me.rad1erTsacoGestacional01 = New System.Windows.Forms.RadioButton()
        Me.botResetRadButtons1erT = New System.Windows.Forms.Button()
        Me.GroupBox55 = New System.Windows.Forms.GroupBox()
        Me.rad1erTtipoEmbarazo02 = New System.Windows.Forms.RadioButton()
        Me.rad1erTtipoEmbarazo01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox40 = New System.Windows.Forms.GroupBox()
        Me.GroupBox54 = New System.Windows.Forms.GroupBox()
        Me.rad1erTanguloFM02 = New System.Windows.Forms.RadioButton()
        Me.rad1erTanguloFM01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox42 = New System.Windows.Forms.GroupBox()
        Me.rad1erTductusVenoso02 = New System.Windows.Forms.RadioButton()
        Me.rad1erTductusVenoso01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox41 = New System.Windows.Forms.GroupBox()
        Me.rad1erThuesosNasales02 = New System.Windows.Forms.RadioButton()
        Me.rad1erThuesosNasales01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox39 = New System.Windows.Forms.GroupBox()
        Me.rad1erTtranslucencia02 = New System.Windows.Forms.RadioButton()
        Me.rad1erTtranslucencia01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox38 = New System.Windows.Forms.GroupBox()
        Me.rad1erTlocalizacionEmbarazo02 = New System.Windows.Forms.RadioButton()
        Me.rad1erTLocalizacionEmbarazo01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox33 = New System.Windows.Forms.GroupBox()
        Me.rad1erTVejiga02 = New System.Windows.Forms.RadioButton()
        Me.rad1erTVejiga01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.rad1erTVitelina02 = New System.Windows.Forms.RadioButton()
        Me.rad1erTVitelina01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Rad1erTActCardiaca2 = New System.Windows.Forms.RadioButton()
        Me.Rad1erTActCardiaca1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Rad1erTMovimientos2 = New System.Windows.Forms.RadioButton()
        Me.Rad1erTMovimientos1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Rad1erTEmbrion2 = New System.Windows.Forms.RadioButton()
        Me.Rad1erTEmbrion1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Rad1erTImplantacion4 = New System.Windows.Forms.RadioButton()
        Me.Rad1erTImplantacion3 = New System.Windows.Forms.RadioButton()
        Me.Rad1erTImplantacion2 = New System.Windows.Forms.RadioButton()
        Me.Rad1erTImplantacion1 = New System.Windows.Forms.RadioButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txt1erTcomentarios05 = New System.Windows.Forms.TextBox()
        Me.txt1erTcomentarios04 = New System.Windows.Forms.TextBox()
        Me.txt1erTcomentarios03 = New System.Windows.Forms.TextBox()
        Me.txt1erTcomentarios02 = New System.Windows.Forms.TextBox()
        Me.txt1erTComentarios01 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txt1erEGxECO = New System.Windows.Forms.TextBox()
        Me.txt1erTidx03 = New System.Windows.Forms.TextBox()
        Me.txt1erTidx02 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lab1ertEGxFUR02 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt1erTidx01 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEdad1erT = New System.Windows.Forms.TextBox()
        Me.labFUR1erT = New System.Windows.Forms.Label()
        Me.txtParidad1erT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.labNombre1erT = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labFechaControl1erT = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lab1ertEGxFUR01 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labFPP1erT = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaInicioControl = New System.Windows.Forms.TextBox()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.PanelNuevoControlGinecologico = New System.Windows.Forms.Panel()
        Me.TabControl5 = New System.Windows.Forms.TabControl()
        Me.TabGinBiometricos = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.radGINfrec75 = New System.Windows.Forms.RadioButton()
        Me.radGINfrec50 = New System.Windows.Forms.RadioButton()
        Me.radGINfrec35 = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.radTipoEstudioGinecologico1 = New System.Windows.Forms.RadioButton()
        Me.radTipoEstudioGinecologico2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox47 = New System.Windows.Forms.GroupBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.txtOvarioIzquierdoFoliculo4 = New System.Windows.Forms.TextBox()
        Me.txtOvarioIzquierdoFoliculo3 = New System.Windows.Forms.TextBox()
        Me.txtOvarioIzquierdoFoliculo2 = New System.Windows.Forms.TextBox()
        Me.txtOvarioIzquierdoFoliculo1 = New System.Windows.Forms.TextBox()
        Me.txtOvarioDerechoFoliculo4 = New System.Windows.Forms.TextBox()
        Me.txtOvarioDerechoFoliculo3 = New System.Windows.Forms.TextBox()
        Me.txtOvarioDerechoFoliculo2 = New System.Windows.Forms.TextBox()
        Me.txtOvarioDerechoFoliculo1 = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.GroupBox45 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUteroEndometrio = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.txtUteroTransverso = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txtUteroAnteroPosterior = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txtUteroLongitudinal = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.GroupBox46 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtOvarioIzquierdoTransverso = New System.Windows.Forms.TextBox()
        Me.txtOvarioDerechoTransverso = New System.Windows.Forms.TextBox()
        Me.txtOvarioIzquierdoAnteroPosterior = New System.Windows.Forms.TextBox()
        Me.txtOvarioDerechoAnteroPosterior = New System.Windows.Forms.TextBox()
        Me.txtOvarioIzquierdoLongitudinal = New System.Windows.Forms.TextBox()
        Me.txtOvarioDerechoLongitudinal = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.TabGinVejiga = New System.Windows.Forms.TabPage()
        Me.GroupBox59 = New System.Windows.Forms.GroupBox()
        Me.txtGinVejigaObservaciones2 = New System.Windows.Forms.TextBox()
        Me.txtGinVejigaObservaciones1 = New System.Windows.Forms.TextBox()
        Me.GroupBox58 = New System.Windows.Forms.GroupBox()
        Me.RadGinVejigaParedes2 = New System.Windows.Forms.RadioButton()
        Me.RadGinVejigaParedes1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox57 = New System.Windows.Forms.GroupBox()
        Me.RadGinVejigaAdecuada2 = New System.Windows.Forms.RadioButton()
        Me.RadGinVejigaAdecuada1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox62 = New System.Windows.Forms.GroupBox()
        Me.RadGinVejigaVolumen3 = New System.Windows.Forms.RadioButton()
        Me.RadGinVejigaVolumen2 = New System.Windows.Forms.RadioButton()
        Me.RadGinVejigaVolumen1 = New System.Windows.Forms.RadioButton()
        Me.TabGinUtero = New System.Windows.Forms.TabPage()
        Me.GroupBox67 = New System.Windows.Forms.GroupBox()
        Me.txtGinUteroObservaciones2 = New System.Windows.Forms.TextBox()
        Me.txtGinUteroObservaciones1 = New System.Windows.Forms.TextBox()
        Me.GroupBox61 = New System.Windows.Forms.GroupBox()
        Me.RadGinUteroCavidad5 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroCavidad1 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroCavidad4 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroCavidad2 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroCavidad3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox66 = New System.Windows.Forms.GroupBox()
        Me.RadGinUteroEndometrio5 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroEndometrio1 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroEndometrio4 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroEndometrio2 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroEndometrio3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox65 = New System.Windows.Forms.GroupBox()
        Me.RadGinUteroBordes1 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroBordes2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox64 = New System.Windows.Forms.GroupBox()
        Me.RadGinUteroEcopatron1 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroEcopatron2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox63 = New System.Windows.Forms.GroupBox()
        Me.RadGinUteroInclinacion3 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroInclinacion1 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroInclinacion2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox60 = New System.Windows.Forms.GroupBox()
        Me.RadGinUteroPosicion3 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroPosicion1 = New System.Windows.Forms.RadioButton()
        Me.RadGinUteroPosicion2 = New System.Windows.Forms.RadioButton()
        Me.TabGinOvarios = New System.Windows.Forms.TabPage()
        Me.GroupBox70 = New System.Windows.Forms.GroupBox()
        Me.GroupBox71 = New System.Windows.Forms.GroupBox()
        Me.txtGinOvarioIzquierdoObservaciones4 = New System.Windows.Forms.TextBox()
        Me.txtGinOvarioIzquierdoObservaciones3 = New System.Windows.Forms.TextBox()
        Me.txtGinOvarioIzquierdoObservaciones2 = New System.Windows.Forms.TextBox()
        Me.txtGinOvarioIzquierdoObservaciones1 = New System.Windows.Forms.TextBox()
        Me.RadGinOvarioIzquierdoTamano3 = New System.Windows.Forms.RadioButton()
        Me.RadGinOvarioIzquierdoTamano1 = New System.Windows.Forms.RadioButton()
        Me.RadGinOvarioIzquierdoTamano2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox68 = New System.Windows.Forms.GroupBox()
        Me.GroupBox69 = New System.Windows.Forms.GroupBox()
        Me.txtGinOvarioDerechoObservaciones4 = New System.Windows.Forms.TextBox()
        Me.txtGinOvarioDerechoObservaciones3 = New System.Windows.Forms.TextBox()
        Me.txtGinOvarioDerechoObservaciones2 = New System.Windows.Forms.TextBox()
        Me.txtGinOvarioDerechoObservaciones1 = New System.Windows.Forms.TextBox()
        Me.RadGinOvarioDerechoTamano3 = New System.Windows.Forms.RadioButton()
        Me.RadGinOvarioDerechoTamano1 = New System.Windows.Forms.RadioButton()
        Me.RadGinOvarioDerechoTamano2 = New System.Windows.Forms.RadioButton()
        Me.TabGinOtros = New System.Windows.Forms.TabPage()
        Me.GroupBox73 = New System.Windows.Forms.GroupBox()
        Me.txtGinOtrosObservaciones2 = New System.Windows.Forms.TextBox()
        Me.RadGinDouglas1 = New System.Windows.Forms.RadioButton()
        Me.RadGinDouglas2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox72 = New System.Windows.Forms.GroupBox()
        Me.RadGinTrompas4 = New System.Windows.Forms.RadioButton()
        Me.txtGinOtrosObservaciones1 = New System.Windows.Forms.TextBox()
        Me.RadGinTrompas3 = New System.Windows.Forms.RadioButton()
        Me.RadGinTrompas1 = New System.Windows.Forms.RadioButton()
        Me.RadGinTrompas2 = New System.Windows.Forms.RadioButton()
        Me.TabIDxGin = New System.Windows.Forms.TabPage()
        Me.GroupBox49 = New System.Windows.Forms.GroupBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtGinIDx4 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtGinIDx3 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtGinIDx2 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtGinIDx1 = New System.Windows.Forms.TextBox()
        Me.GroupBox44 = New System.Windows.Forms.GroupBox()
        Me.labFURginecologico = New System.Windows.Forms.Label()
        Me.txtParidadGinecologico = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.labEdadGinecologico = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.labNombreGinecologico = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.labFechaControlGinecologico = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.labDiaCicloGinecologico = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.PanelNuevoControl2y3erT = New System.Windows.Forms.Panel()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPageObstetricos = New System.Windows.Forms.TabPage()
        Me.GroupBox51 = New System.Windows.Forms.GroupBox()
        Me.radFeto02 = New System.Windows.Forms.RadioButton()
        Me.radFeto01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox50 = New System.Windows.Forms.GroupBox()
        Me.radEmbarazo02 = New System.Windows.Forms.RadioButton()
        Me.radEmbarazo01 = New System.Windows.Forms.RadioButton()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.radPosicion8 = New System.Windows.Forms.RadioButton()
        Me.radPosicion7 = New System.Windows.Forms.RadioButton()
        Me.radPosicion6 = New System.Windows.Forms.RadioButton()
        Me.radPosicion5 = New System.Windows.Forms.RadioButton()
        Me.radPosicion4 = New System.Windows.Forms.RadioButton()
        Me.radPosicion3 = New System.Windows.Forms.RadioButton()
        Me.radPosicion2 = New System.Windows.Forms.RadioButton()
        Me.radPosicion1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.radSituacion3 = New System.Windows.Forms.RadioButton()
        Me.radSituacion2 = New System.Windows.Forms.RadioButton()
        Me.radSituacion1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.radpresentacion3 = New System.Windows.Forms.RadioButton()
        Me.radPresentacion2 = New System.Windows.Forms.RadioButton()
        Me.radPresentacion1 = New System.Windows.Forms.RadioButton()
        Me.TabPageBiometricos = New System.Windows.Forms.TabPage()
        Me.lab2y3egxFem = New System.Windows.Forms.Label()
        Me.lab2y3egxCA = New System.Windows.Forms.Label()
        Me.lab2y3egxCC = New System.Windows.Forms.Label()
        Me.lab2y3egxDBP = New System.Windows.Forms.Label()
        Me.botCalculaCC = New System.Windows.Forms.Button()
        Me.txtTalla = New System.Windows.Forms.TextBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.txtBPF = New System.Windows.Forms.TextBox()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.txtNOPH = New System.Windows.Forms.TextBox()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.txtNODF = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.txtUlna = New System.Windows.Forms.TextBox()
        Me.txtNOPT = New System.Windows.Forms.TextBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.txtHumero = New System.Windows.Forms.TextBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtCA = New System.Windows.Forms.TextBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.txtTibia = New System.Windows.Forms.TextBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.txtPN = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.txtIOI = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.txtIOE = New System.Windows.Forms.TextBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.txtAtrio = New System.Windows.Forms.TextBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.txtTCer = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtTransAbdomen = New System.Windows.Forms.TextBox()
        Me.txtFemur = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtSacro = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtAorta = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtAPC = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtAPT = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtDOF = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtDBP = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TabPageAnatomicos = New System.Windows.Forms.TabPage()
        Me.GroupBox53 = New System.Windows.Forms.GroupBox()
        Me.radSexo2 = New System.Windows.Forms.RadioButton()
        Me.radSexo1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.radTorax2 = New System.Windows.Forms.RadioButton()
        Me.radTorax1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox52 = New System.Windows.Forms.GroupBox()
        Me.radRostro2 = New System.Windows.Forms.RadioButton()
        Me.radRostro1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.radExtremidades2 = New System.Windows.Forms.RadioButton()
        Me.radExtremidades1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.radRiñones2 = New System.Windows.Forms.RadioButton()
        Me.radRiñones1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.radAbdomen2 = New System.Windows.Forms.RadioButton()
        Me.radAbdomen1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.radCorazon2 = New System.Windows.Forms.RadioButton()
        Me.radCorazon1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.radColumna2 = New System.Windows.Forms.RadioButton()
        Me.radColumna1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.radVentriculo2 = New System.Windows.Forms.RadioButton()
        Me.radVentriculo1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.radCabeza2 = New System.Windows.Forms.RadioButton()
        Me.radCabeza1 = New System.Windows.Forms.RadioButton()
        Me.TabPageFuncionales = New System.Windows.Forms.TabPage()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.radVejiga2 = New System.Windows.Forms.RadioButton()
        Me.radVejiga1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox31 = New System.Windows.Forms.GroupBox()
        Me.radIntestino5 = New System.Windows.Forms.RadioButton()
        Me.radIntestino4 = New System.Windows.Forms.RadioButton()
        Me.radIntestino3 = New System.Windows.Forms.RadioButton()
        Me.radIntestino2 = New System.Windows.Forms.RadioButton()
        Me.radIntestino1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox32 = New System.Windows.Forms.GroupBox()
        Me.radCamaraGastrica2 = New System.Windows.Forms.RadioButton()
        Me.radCamaraGastrica1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.radAortoCava2 = New System.Windows.Forms.RadioButton()
        Me.radAortoCava1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox28 = New System.Windows.Forms.GroupBox()
        Me.radMovimientosRespiratorios2 = New System.Windows.Forms.RadioButton()
        Me.radMovimientosRespiratorios1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.radActividadCardiaca2 = New System.Windows.Forms.RadioButton()
        Me.radActividadCardiaca1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.radMovimientosFetales2 = New System.Windows.Forms.RadioButton()
        Me.radMovimientosFetales1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.radTono2 = New System.Windows.Forms.RadioButton()
        Me.radTono1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.radActitud2 = New System.Windows.Forms.RadioButton()
        Me.radActitud1 = New System.Windows.Forms.RadioButton()
        Me.TabPagePlacentarios = New System.Windows.Forms.TabPage()
        Me.GroupBox37 = New System.Windows.Forms.GroupBox()
        Me.radCordon2 = New System.Windows.Forms.RadioButton()
        Me.radCordon1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox36 = New System.Windows.Forms.GroupBox()
        Me.txtILA = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.radLiquidoAmniotico2 = New System.Windows.Forms.RadioButton()
        Me.radLiquidoAmniotico1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox35 = New System.Windows.Forms.GroupBox()
        Me.radPlacentaGrado7 = New System.Windows.Forms.RadioButton()
        Me.radPlacentaGrado6 = New System.Windows.Forms.RadioButton()
        Me.radPlacentaGrado5 = New System.Windows.Forms.RadioButton()
        Me.radPlacentaGrado4 = New System.Windows.Forms.RadioButton()
        Me.radPlacentaGrado3 = New System.Windows.Forms.RadioButton()
        Me.radPlacentaGrado2 = New System.Windows.Forms.RadioButton()
        Me.radPlacentaGrado1 = New System.Windows.Forms.RadioButton()
        Me.txtPlacentaGrosor = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.GroupBox34 = New System.Windows.Forms.GroupBox()
        Me.radPlacenta8 = New System.Windows.Forms.RadioButton()
        Me.radPlacenta7 = New System.Windows.Forms.RadioButton()
        Me.radPlacenta6 = New System.Windows.Forms.RadioButton()
        Me.radPlacenta5 = New System.Windows.Forms.RadioButton()
        Me.radplacenta4 = New System.Windows.Forms.RadioButton()
        Me.radPlacenta3 = New System.Windows.Forms.RadioButton()
        Me.radPlacenta2 = New System.Windows.Forms.RadioButton()
        Me.radPlacenta1 = New System.Windows.Forms.RadioButton()
        Me.TabPageNotas = New System.Windows.Forms.TabPage()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtNotas03del2y3erT = New System.Windows.Forms.TextBox()
        Me.txtNotas02del2y3erT = New System.Windows.Forms.TextBox()
        Me.txtNotas01del2y3erT = New System.Windows.Forms.TextBox()
        Me.TabPageIDx = New System.Windows.Forms.TabPage()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtSug03del2y3erT = New System.Windows.Forms.TextBox()
        Me.txtSug02del2y3erT = New System.Windows.Forms.TextBox()
        Me.txtSug01del2y3erT = New System.Windows.Forms.TextBox()
        Me.GroupBox43 = New System.Windows.Forms.GroupBox()
        Me.txtIDx08del2y3erT = New System.Windows.Forms.TextBox()
        Me.txtIDx07del2y3erT = New System.Windows.Forms.TextBox()
        Me.txtIDx06del2y3erT = New System.Windows.Forms.TextBox()
        Me.botCalculaEcopuntaje = New System.Windows.Forms.Button()
        Me.botCalculaPerfil = New System.Windows.Forms.Button()
        Me.botCalculaPercentil = New System.Windows.Forms.Button()
        Me.botCalculaEG = New System.Windows.Forms.Button()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txtIdx04del2y3erT = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtIdx03del2y3erT = New System.Windows.Forms.TextBox()
        Me.txtIdx02del2y3erT = New System.Windows.Forms.TextBox()
        Me.txtIdx01del2y3erT = New System.Windows.Forms.TextBox()
        Me.txtIdx05del2y3erT = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtEdad2y3erT = New System.Windows.Forms.TextBox()
        Me.labFUR2y3erT = New System.Windows.Forms.Label()
        Me.txtParidad2y3erT = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.labNombre2y3erT = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.labFechaControl2y3erT = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.labEGxFUR2y3erT = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.labFPP2y3erT = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.labInforme = New System.Windows.Forms.Label()
        Me.TP03 = New System.Windows.Forms.TabPage()
        Me.txtFechaInicioControl2 = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.PanelImpresion = New System.Windows.Forms.Panel()
        Me.chkImprimeMembrete = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.botPersonaliza = New System.Windows.Forms.Button()
        Me.botIMPRIME = New System.Windows.Forms.Button()
        Me.txtInforme = New System.Windows.Forms.TextBox()
        Me.botCreaImpresion = New System.Windows.Forms.Button()
        Me.labInforme2 = New System.Windows.Forms.Label()
        Me.TP04 = New System.Windows.Forms.TabPage()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.txtProfesion = New System.Windows.Forms.TextBox()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.txtFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtAntFamiliares = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txtAntPersonales = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.txtAntGinecologicos = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.txtAntObstetricos = New System.Windows.Forms.TextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.txtAntQuirurgicos = New System.Windows.Forms.TextBox()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuCalculaEGconECO = New System.Windows.Forms.MenuItem()
        Me.menuCalculaEGconFUR = New System.Windows.Forms.MenuItem()
        Me.menuCalculaDCconFUR = New System.Windows.Forms.MenuItem()
        Me.MainMenu2 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MainMenu3 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MainMenu4 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MainMenu5 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.botSalirSinGuardar = New System.Windows.Forms.Button()
        Me.botGuardarNuevosDatos = New System.Windows.Forms.Button()
        Me.botGuardarYsalir = New System.Windows.Forms.Button()
        Me.labCambios = New System.Windows.Forms.Label()
        Me.chkMedidasUsuales = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TP01.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP02.SuspendLayout()
        Me.PanelNuevoControl1erT.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox56.SuspendLayout()
        Me.GroupBox55.SuspendLayout()
        Me.GroupBox40.SuspendLayout()
        Me.GroupBox54.SuspendLayout()
        Me.GroupBox42.SuspendLayout()
        Me.GroupBox41.SuspendLayout()
        Me.GroupBox39.SuspendLayout()
        Me.GroupBox38.SuspendLayout()
        Me.GroupBox33.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelNuevoControlGinecologico.SuspendLayout()
        Me.TabControl5.SuspendLayout()
        Me.TabGinBiometricos.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox47.SuspendLayout()
        Me.GroupBox45.SuspendLayout()
        Me.GroupBox46.SuspendLayout()
        Me.TabGinVejiga.SuspendLayout()
        Me.GroupBox59.SuspendLayout()
        Me.GroupBox58.SuspendLayout()
        Me.GroupBox57.SuspendLayout()
        Me.GroupBox62.SuspendLayout()
        Me.TabGinUtero.SuspendLayout()
        Me.GroupBox67.SuspendLayout()
        Me.GroupBox61.SuspendLayout()
        Me.GroupBox66.SuspendLayout()
        Me.GroupBox65.SuspendLayout()
        Me.GroupBox64.SuspendLayout()
        Me.GroupBox63.SuspendLayout()
        Me.GroupBox60.SuspendLayout()
        Me.TabGinOvarios.SuspendLayout()
        Me.GroupBox70.SuspendLayout()
        Me.GroupBox71.SuspendLayout()
        Me.GroupBox68.SuspendLayout()
        Me.GroupBox69.SuspendLayout()
        Me.TabGinOtros.SuspendLayout()
        Me.GroupBox73.SuspendLayout()
        Me.GroupBox72.SuspendLayout()
        Me.TabIDxGin.SuspendLayout()
        Me.GroupBox49.SuspendLayout()
        Me.GroupBox44.SuspendLayout()
        Me.PanelNuevoControl2y3erT.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPageObstetricos.SuspendLayout()
        Me.GroupBox51.SuspendLayout()
        Me.GroupBox50.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.TabPageBiometricos.SuspendLayout()
        Me.TabPageAnatomicos.SuspendLayout()
        Me.GroupBox53.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox52.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.TabPageFuncionales.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        Me.GroupBox31.SuspendLayout()
        Me.GroupBox32.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        Me.GroupBox28.SuspendLayout()
        Me.GroupBox29.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.TabPagePlacentarios.SuspendLayout()
        Me.GroupBox37.SuspendLayout()
        Me.GroupBox36.SuspendLayout()
        Me.GroupBox35.SuspendLayout()
        Me.GroupBox34.SuspendLayout()
        Me.TabPageNotas.SuspendLayout()
        Me.TabPageIDx.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox43.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TP03.SuspendLayout()
        Me.PanelImpresion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP04.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TP01)
        Me.TabControl1.Controls.Add(Me.TP02)
        Me.TabControl1.Controls.Add(Me.TP03)
        Me.TabControl1.Controls.Add(Me.TP04)
        Me.TabControl1.Location = New System.Drawing.Point(4, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(974, 590)
        Me.TabControl1.TabIndex = 0
        '
        'TP01
        '
        Me.TP01.Controls.Add(Me.Label127)
        Me.TP01.Controls.Add(Me.botRenombraImagen)
        Me.TP01.Controls.Add(Me.botEliminaImagen)
        Me.TP01.Controls.Add(Me.botNuevaImagen)
        Me.TP01.Controls.Add(Me.botAbreImagen)
        Me.TP01.Controls.Add(Me.ListBoxImagenes)
        Me.TP01.Controls.Add(Me.botRenombra)
        Me.TP01.Controls.Add(Me.PictureBox1)
        Me.TP01.Controls.Add(Me.botElimina)
        Me.TP01.Controls.Add(Me.botNuevo)
        Me.TP01.Controls.Add(Me.botSelecciona)
        Me.TP01.Controls.Add(Me.Label126)
        Me.TP01.Controls.Add(Me.ListBoxInformes)
        Me.TP01.Location = New System.Drawing.Point(4, 22)
        Me.TP01.Name = "TP01"
        Me.TP01.Size = New System.Drawing.Size(966, 564)
        Me.TP01.TabIndex = 1
        Me.TP01.Text = "Indice"
        '
        'Label127
        '
        Me.Label127.Location = New System.Drawing.Point(400, 8)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(256, 23)
        Me.Label127.TabIndex = 34
        Me.Label127.Text = "Imágenes Ecográficas Incluidas en la Historia"
        Me.Label127.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botRenombraImagen
        '
        Me.botRenombraImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRenombraImagen.Image = CType(resources.GetObject("botRenombraImagen.Image"), System.Drawing.Image)
        Me.botRenombraImagen.Location = New System.Drawing.Point(400, 360)
        Me.botRenombraImagen.Name = "botRenombraImagen"
        Me.botRenombraImagen.Size = New System.Drawing.Size(224, 23)
        Me.botRenombraImagen.TabIndex = 33
        Me.botRenombraImagen.Text = "Renombra la Imagen Seleccionada"
        '
        'botEliminaImagen
        '
        Me.botEliminaImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEliminaImagen.Image = CType(resources.GetObject("botEliminaImagen.Image"), System.Drawing.Image)
        Me.botEliminaImagen.Location = New System.Drawing.Point(400, 392)
        Me.botEliminaImagen.Name = "botEliminaImagen"
        Me.botEliminaImagen.Size = New System.Drawing.Size(224, 23)
        Me.botEliminaImagen.TabIndex = 32
        Me.botEliminaImagen.Text = "Elimina la Imagen Seleccionada"
        '
        'botNuevaImagen
        '
        Me.botNuevaImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botNuevaImagen.Image = CType(resources.GetObject("botNuevaImagen.Image"), System.Drawing.Image)
        Me.botNuevaImagen.Location = New System.Drawing.Point(400, 296)
        Me.botNuevaImagen.Name = "botNuevaImagen"
        Me.botNuevaImagen.Size = New System.Drawing.Size(224, 23)
        Me.botNuevaImagen.TabIndex = 30
        Me.botNuevaImagen.Text = "Añade una Nueva Imagen Ecográfica"
        '
        'botAbreImagen
        '
        Me.botAbreImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAbreImagen.Image = CType(resources.GetObject("botAbreImagen.Image"), System.Drawing.Image)
        Me.botAbreImagen.Location = New System.Drawing.Point(400, 328)
        Me.botAbreImagen.Name = "botAbreImagen"
        Me.botAbreImagen.Size = New System.Drawing.Size(224, 23)
        Me.botAbreImagen.TabIndex = 31
        Me.botAbreImagen.Text = "Abre la Imagen Seleccionada"
        '
        'ListBoxImagenes
        '
        Me.ListBoxImagenes.Location = New System.Drawing.Point(400, 32)
        Me.ListBoxImagenes.Name = "ListBoxImagenes"
        Me.ListBoxImagenes.Size = New System.Drawing.Size(376, 225)
        Me.ListBoxImagenes.TabIndex = 29
        '
        'botRenombra
        '
        Me.botRenombra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRenombra.Image = CType(resources.GetObject("botRenombra.Image"), System.Drawing.Image)
        Me.botRenombra.Location = New System.Drawing.Point(14, 361)
        Me.botRenombra.Name = "botRenombra"
        Me.botRenombra.Size = New System.Drawing.Size(224, 23)
        Me.botRenombra.TabIndex = 28
        Me.botRenombra.Text = "Renombra el Informe Seleccionado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(688, 265)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'botElimina
        '
        Me.botElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botElimina.Image = CType(resources.GetObject("botElimina.Image"), System.Drawing.Image)
        Me.botElimina.Location = New System.Drawing.Point(14, 393)
        Me.botElimina.Name = "botElimina"
        Me.botElimina.Size = New System.Drawing.Size(224, 23)
        Me.botElimina.TabIndex = 25
        Me.botElimina.Text = "Elimina Informe Ecográfico Seleccionado"
        '
        'botNuevo
        '
        Me.botNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botNuevo.Image = CType(resources.GetObject("botNuevo.Image"), System.Drawing.Image)
        Me.botNuevo.Location = New System.Drawing.Point(14, 297)
        Me.botNuevo.Name = "botNuevo"
        Me.botNuevo.Size = New System.Drawing.Size(224, 23)
        Me.botNuevo.TabIndex = 23
        Me.botNuevo.Text = "Crea Nuevo Informe Ecográfico"
        '
        'botSelecciona
        '
        Me.botSelecciona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSelecciona.Image = CType(resources.GetObject("botSelecciona.Image"), System.Drawing.Image)
        Me.botSelecciona.Location = New System.Drawing.Point(14, 329)
        Me.botSelecciona.Name = "botSelecciona"
        Me.botSelecciona.Size = New System.Drawing.Size(224, 23)
        Me.botSelecciona.TabIndex = 24
        Me.botSelecciona.Text = "Abre Informe Ecográfico Seleccionado"
        '
        'Label126
        '
        Me.Label126.Location = New System.Drawing.Point(14, 9)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(256, 23)
        Me.Label126.TabIndex = 21
        Me.Label126.Text = "Informes Ecográficos Incluidos en la Historia"
        Me.Label126.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBoxInformes
        '
        Me.ListBoxInformes.Location = New System.Drawing.Point(14, 33)
        Me.ListBoxInformes.Name = "ListBoxInformes"
        Me.ListBoxInformes.Size = New System.Drawing.Size(378, 225)
        Me.ListBoxInformes.TabIndex = 22
        '
        'TP02
        '
        Me.TP02.AutoScroll = True
        Me.TP02.Controls.Add(Me.PanelNuevoControl1erT)
        Me.TP02.Controls.Add(Me.txtFechaInicioControl)
        Me.TP02.Controls.Add(Me.Label108)
        Me.TP02.Controls.Add(Me.PanelNuevoControlGinecologico)
        Me.TP02.Controls.Add(Me.PanelNuevoControl2y3erT)
        Me.TP02.Controls.Add(Me.labInforme)
        Me.TP02.Location = New System.Drawing.Point(4, 22)
        Me.TP02.Name = "TP02"
        Me.TP02.Size = New System.Drawing.Size(966, 564)
        Me.TP02.TabIndex = 0
        Me.TP02.Text = "Edita Informe Ecográfico"
        '
        'PanelNuevoControl1erT
        '
        Me.PanelNuevoControl1erT.AutoScroll = True
        Me.PanelNuevoControl1erT.Controls.Add(Me.TabControl3)
        Me.PanelNuevoControl1erT.Controls.Add(Me.GroupBox2)
        Me.PanelNuevoControl1erT.Controls.Add(Me.Label2)
        Me.PanelNuevoControl1erT.Location = New System.Drawing.Point(4, 30)
        Me.PanelNuevoControl1erT.Name = "PanelNuevoControl1erT"
        Me.PanelNuevoControl1erT.Size = New System.Drawing.Size(929, 494)
        Me.PanelNuevoControl1erT.TabIndex = 2
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage1)
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Location = New System.Drawing.Point(8, 107)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(908, 384)
        Me.TabControl3.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(900, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Biométricos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txt1erTN)
        Me.GroupBox1.Controls.Add(Me.Label65)
        Me.GroupBox1.Controls.Add(Me.lab1erEGxFemur)
        Me.GroupBox1.Controls.Add(Me.txt1erFemur)
        Me.GroupBox1.Controls.Add(Me.Label89)
        Me.GroupBox1.Controls.Add(Me.lab1erEGxCA)
        Me.GroupBox1.Controls.Add(Me.txt1erCA)
        Me.GroupBox1.Controls.Add(Me.Label88)
        Me.GroupBox1.Controls.Add(Me.lab1erEGxCC)
        Me.GroupBox1.Controls.Add(Me.txt1erCC)
        Me.GroupBox1.Controls.Add(Me.Label76)
        Me.GroupBox1.Controls.Add(Me.lab1erEGxDBP)
        Me.GroupBox1.Controls.Add(Me.txt1erDBP)
        Me.GroupBox1.Controls.Add(Me.Label72)
        Me.GroupBox1.Controls.Add(Me.txt1erVVantPost)
        Me.GroupBox1.Controls.Add(Me.txt1erVVlong)
        Me.GroupBox1.Controls.Add(Me.Label50)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.lab1erEGxLCC)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txt1erLCC)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.lab1erEGxSG)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.lab1erSGprom)
        Me.GroupBox1.Controls.Add(Me.txt1erSGtrans)
        Me.GroupBox1.Controls.Add(Me.txt1erSGantPost)
        Me.GroupBox1.Controls.Add(Me.txt1erSGlong)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(875, 346)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt1erTN
        '
        Me.txt1erTN.Location = New System.Drawing.Point(409, 183)
        Me.txt1erTN.MaxLength = 3
        Me.txt1erTN.Name = "txt1erTN"
        Me.txt1erTN.Size = New System.Drawing.Size(32, 20)
        Me.txt1erTN.TabIndex = 89
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(279, 181)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(128, 23)
        Me.Label65.TabIndex = 88
        Me.Label65.Text = "Traslucencia Nucal(mm)"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab1erEGxFemur
        '
        Me.lab1erEGxFemur.BackColor = System.Drawing.SystemColors.Info
        Me.lab1erEGxFemur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab1erEGxFemur.Location = New System.Drawing.Point(447, 158)
        Me.lab1erEGxFemur.Name = "lab1erEGxFemur"
        Me.lab1erEGxFemur.Size = New System.Drawing.Size(50, 18)
        Me.lab1erEGxFemur.TabIndex = 87
        Me.lab1erEGxFemur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt1erFemur
        '
        Me.txt1erFemur.Location = New System.Drawing.Point(409, 158)
        Me.txt1erFemur.MaxLength = 3
        Me.txt1erFemur.Name = "txt1erFemur"
        Me.txt1erFemur.Size = New System.Drawing.Size(32, 20)
        Me.txt1erFemur.TabIndex = 86
        '
        'Label89
        '
        Me.Label89.Location = New System.Drawing.Point(307, 156)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(100, 23)
        Me.Label89.TabIndex = 85
        Me.Label89.Text = "Fémur(mm)"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab1erEGxCA
        '
        Me.lab1erEGxCA.BackColor = System.Drawing.SystemColors.Info
        Me.lab1erEGxCA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab1erEGxCA.Location = New System.Drawing.Point(447, 133)
        Me.lab1erEGxCA.Name = "lab1erEGxCA"
        Me.lab1erEGxCA.Size = New System.Drawing.Size(50, 18)
        Me.lab1erEGxCA.TabIndex = 84
        Me.lab1erEGxCA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt1erCA
        '
        Me.txt1erCA.Location = New System.Drawing.Point(409, 133)
        Me.txt1erCA.MaxLength = 3
        Me.txt1erCA.Name = "txt1erCA"
        Me.txt1erCA.Size = New System.Drawing.Size(32, 20)
        Me.txt1erCA.TabIndex = 83
        '
        'Label88
        '
        Me.Label88.Location = New System.Drawing.Point(289, 131)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(118, 23)
        Me.Label88.TabIndex = 82
        Me.Label88.Text = "Circ. Abdominal(mm)"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab1erEGxCC
        '
        Me.lab1erEGxCC.BackColor = System.Drawing.SystemColors.Info
        Me.lab1erEGxCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab1erEGxCC.Location = New System.Drawing.Point(447, 108)
        Me.lab1erEGxCC.Name = "lab1erEGxCC"
        Me.lab1erEGxCC.Size = New System.Drawing.Size(50, 18)
        Me.lab1erEGxCC.TabIndex = 81
        Me.lab1erEGxCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt1erCC
        '
        Me.txt1erCC.Location = New System.Drawing.Point(409, 108)
        Me.txt1erCC.MaxLength = 3
        Me.txt1erCC.Name = "txt1erCC"
        Me.txt1erCC.Size = New System.Drawing.Size(32, 20)
        Me.txt1erCC.TabIndex = 80
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(307, 106)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(100, 23)
        Me.Label76.TabIndex = 79
        Me.Label76.Text = "Circ. Cefálica(mm)"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab1erEGxDBP
        '
        Me.lab1erEGxDBP.BackColor = System.Drawing.SystemColors.Info
        Me.lab1erEGxDBP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab1erEGxDBP.Location = New System.Drawing.Point(447, 83)
        Me.lab1erEGxDBP.Name = "lab1erEGxDBP"
        Me.lab1erEGxDBP.Size = New System.Drawing.Size(50, 18)
        Me.lab1erEGxDBP.TabIndex = 78
        Me.lab1erEGxDBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt1erDBP
        '
        Me.txt1erDBP.Location = New System.Drawing.Point(409, 83)
        Me.txt1erDBP.MaxLength = 3
        Me.txt1erDBP.Name = "txt1erDBP"
        Me.txt1erDBP.Size = New System.Drawing.Size(32, 20)
        Me.txt1erDBP.TabIndex = 77
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(307, 81)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(100, 23)
        Me.Label72.TabIndex = 76
        Me.Label72.Text = "Biparietal(mm)"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt1erVVantPost
        '
        Me.txt1erVVantPost.Location = New System.Drawing.Point(78, 207)
        Me.txt1erVVantPost.MaxLength = 3
        Me.txt1erVVantPost.Name = "txt1erVVantPost"
        Me.txt1erVVantPost.Size = New System.Drawing.Size(32, 20)
        Me.txt1erVVantPost.TabIndex = 15
        '
        'txt1erVVlong
        '
        Me.txt1erVVlong.Location = New System.Drawing.Point(78, 187)
        Me.txt1erVVlong.MaxLength = 3
        Me.txt1erVVlong.Name = "txt1erVVlong"
        Me.txt1erVVlong.Size = New System.Drawing.Size(32, 20)
        Me.txt1erVVlong.TabIndex = 13
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(6, 187)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(72, 23)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "Longitudinal:"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(6, 207)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(72, 23)
        Me.Label51.TabIndex = 14
        Me.Label51.Text = "Antero/Post:"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rad1erTfrec75)
        Me.Panel4.Controls.Add(Me.rad1erTfrec50)
        Me.Panel4.Controls.Add(Me.rad1erTfrec35)
        Me.Panel4.Location = New System.Drawing.Point(216, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(340, 39)
        Me.Panel4.TabIndex = 20
        '
        'rad1erTfrec75
        '
        Me.rad1erTfrec75.AutoSize = True
        Me.rad1erTfrec75.Location = New System.Drawing.Point(187, 4)
        Me.rad1erTfrec75.Name = "rad1erTfrec75"
        Me.rad1erTfrec75.Size = New System.Drawing.Size(65, 17)
        Me.rad1erTfrec75.TabIndex = 2
        Me.rad1erTfrec75.TabStop = True
        Me.rad1erTfrec75.Text = "7.5 MHz"
        Me.rad1erTfrec75.UseVisualStyleBackColor = True
        '
        'rad1erTfrec50
        '
        Me.rad1erTfrec50.AutoSize = True
        Me.rad1erTfrec50.Location = New System.Drawing.Point(102, 4)
        Me.rad1erTfrec50.Name = "rad1erTfrec50"
        Me.rad1erTfrec50.Size = New System.Drawing.Size(65, 17)
        Me.rad1erTfrec50.TabIndex = 1
        Me.rad1erTfrec50.TabStop = True
        Me.rad1erTfrec50.Text = "5.0 MHz"
        Me.rad1erTfrec50.UseVisualStyleBackColor = True
        '
        'rad1erTfrec35
        '
        Me.rad1erTfrec35.AutoSize = True
        Me.rad1erTfrec35.Location = New System.Drawing.Point(6, 4)
        Me.rad1erTfrec35.Name = "rad1erTfrec35"
        Me.rad1erTfrec35.Size = New System.Drawing.Size(65, 17)
        Me.rad1erTfrec35.TabIndex = 0
        Me.rad1erTfrec35.TabStop = True
        Me.rad1erTfrec35.Text = "3.5 MHz"
        Me.rad1erTfrec35.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rad1erTestudioTV)
        Me.Panel2.Controls.Add(Me.rad1erTEstudioAbd)
        Me.Panel2.Location = New System.Drawing.Point(8, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 39)
        Me.Panel2.TabIndex = 19
        '
        'rad1erTestudioTV
        '
        Me.rad1erTestudioTV.AutoSize = True
        Me.rad1erTestudioTV.Location = New System.Drawing.Point(102, 4)
        Me.rad1erTestudioTV.Name = "rad1erTestudioTV"
        Me.rad1erTestudioTV.Size = New System.Drawing.Size(86, 17)
        Me.rad1erTestudioTV.TabIndex = 1
        Me.rad1erTestudioTV.TabStop = True
        Me.rad1erTestudioTV.Text = "Transvaginal"
        Me.rad1erTestudioTV.UseVisualStyleBackColor = True
        '
        'rad1erTEstudioAbd
        '
        Me.rad1erTEstudioAbd.AutoSize = True
        Me.rad1erTEstudioAbd.Location = New System.Drawing.Point(6, 4)
        Me.rad1erTEstudioAbd.Name = "rad1erTEstudioAbd"
        Me.rad1erTEstudioAbd.Size = New System.Drawing.Size(74, 17)
        Me.rad1erTEstudioAbd.TabIndex = 0
        Me.rad1erTEstudioAbd.TabStop = True
        Me.rad1erTEstudioAbd.Text = "Abdominal"
        Me.rad1erTEstudioAbd.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(6, 164)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(152, 23)
        Me.Label40.TabIndex = 11
        Me.Label40.Text = "Vesícula Vitelina"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab1erEGxLCC
        '
        Me.lab1erEGxLCC.BackColor = System.Drawing.SystemColors.Info
        Me.lab1erEGxLCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab1erEGxLCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab1erEGxLCC.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lab1erEGxLCC.Location = New System.Drawing.Point(134, 264)
        Me.lab1erEGxLCC.Name = "lab1erEGxLCC"
        Me.lab1erEGxLCC.Size = New System.Drawing.Size(50, 23)
        Me.lab1erEGxLCC.TabIndex = 20
        Me.lab1erEGxLCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(118, 264)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(8, 23)
        Me.Label30.TabIndex = 19
        Me.Label30.Text = "="
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt1erLCC
        '
        Me.txt1erLCC.Location = New System.Drawing.Point(78, 264)
        Me.txt1erLCC.MaxLength = 3
        Me.txt1erLCC.Name = "txt1erLCC"
        Me.txt1erLCC.Size = New System.Drawing.Size(32, 20)
        Me.txt1erLCC.TabIndex = 18
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(6, 264)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 23)
        Me.Label28.TabIndex = 17
        Me.Label28.Text = "Longitudinal:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab1erEGxSG
        '
        Me.lab1erEGxSG.BackColor = System.Drawing.SystemColors.Info
        Me.lab1erEGxSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab1erEGxSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab1erEGxSG.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lab1erEGxSG.Location = New System.Drawing.Point(134, 141)
        Me.lab1erEGxSG.Name = "lab1erEGxSG"
        Me.lab1erEGxSG.Size = New System.Drawing.Size(50, 23)
        Me.lab1erEGxSG.TabIndex = 10
        Me.lab1erEGxSG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(118, 141)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(8, 23)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "="
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab1erSGprom
        '
        Me.lab1erSGprom.BackColor = System.Drawing.SystemColors.Info
        Me.lab1erSGprom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab1erSGprom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lab1erSGprom.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lab1erSGprom.Location = New System.Drawing.Point(78, 141)
        Me.lab1erSGprom.Name = "lab1erSGprom"
        Me.lab1erSGprom.Size = New System.Drawing.Size(32, 23)
        Me.lab1erSGprom.TabIndex = 8
        Me.lab1erSGprom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt1erSGtrans
        '
        Me.txt1erSGtrans.Location = New System.Drawing.Point(78, 121)
        Me.txt1erSGtrans.MaxLength = 3
        Me.txt1erSGtrans.Name = "txt1erSGtrans"
        Me.txt1erSGtrans.Size = New System.Drawing.Size(32, 20)
        Me.txt1erSGtrans.TabIndex = 6
        '
        'txt1erSGantPost
        '
        Me.txt1erSGantPost.Location = New System.Drawing.Point(78, 101)
        Me.txt1erSGantPost.MaxLength = 3
        Me.txt1erSGantPost.Name = "txt1erSGantPost"
        Me.txt1erSGantPost.Size = New System.Drawing.Size(32, 20)
        Me.txt1erSGantPost.TabIndex = 4
        '
        'txt1erSGlong
        '
        Me.txt1erSGlong.Location = New System.Drawing.Point(78, 81)
        Me.txt1erSGlong.MaxLength = 3
        Me.txt1erSGlong.Name = "txt1erSGlong"
        Me.txt1erSGlong.Size = New System.Drawing.Size(32, 20)
        Me.txt1erSGlong.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label25.Location = New System.Drawing.Point(6, 141)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 23)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Promedio:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(6, 121)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 23)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Transversal:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(6, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 23)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Longitudinal:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(6, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 23)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Antero/Post:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Longitud Craneo Caudal"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Saco Gestacional"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(900, 358)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos anatómicos y Funcionales"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox56)
        Me.GroupBox3.Controls.Add(Me.botResetRadButtons1erT)
        Me.GroupBox3.Controls.Add(Me.GroupBox55)
        Me.GroupBox3.Controls.Add(Me.GroupBox40)
        Me.GroupBox3.Controls.Add(Me.GroupBox38)
        Me.GroupBox3.Controls.Add(Me.GroupBox33)
        Me.GroupBox3.Controls.Add(Me.GroupBox23)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(719, 236)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Anatómicos y Funcionales"
        '
        'GroupBox56
        '
        Me.GroupBox56.Controls.Add(Me.rad1erTsacoGestacional02)
        Me.GroupBox56.Controls.Add(Me.rad1erTsacoGestacional01)
        Me.GroupBox56.Location = New System.Drawing.Point(231, 20)
        Me.GroupBox56.Name = "GroupBox56"
        Me.GroupBox56.Size = New System.Drawing.Size(116, 64)
        Me.GroupBox56.TabIndex = 11
        Me.GroupBox56.TabStop = False
        Me.GroupBox56.Text = "Saco Gestacional"
        '
        'rad1erTsacoGestacional02
        '
        Me.rad1erTsacoGestacional02.Location = New System.Drawing.Point(8, 36)
        Me.rad1erTsacoGestacional02.Name = "rad1erTsacoGestacional02"
        Me.rad1erTsacoGestacional02.Size = New System.Drawing.Size(80, 24)
        Me.rad1erTsacoGestacional02.TabIndex = 2
        Me.rad1erTsacoGestacional02.Text = "No Visible"
        '
        'rad1erTsacoGestacional01
        '
        Me.rad1erTsacoGestacional01.Location = New System.Drawing.Point(8, 16)
        Me.rad1erTsacoGestacional01.Name = "rad1erTsacoGestacional01"
        Me.rad1erTsacoGestacional01.Size = New System.Drawing.Size(64, 24)
        Me.rad1erTsacoGestacional01.TabIndex = 1
        Me.rad1erTsacoGestacional01.Text = "Visible"
        '
        'botResetRadButtons1erT
        '
        Me.botResetRadButtons1erT.Location = New System.Drawing.Point(564, 190)
        Me.botResetRadButtons1erT.Name = "botResetRadButtons1erT"
        Me.botResetRadButtons1erT.Size = New System.Drawing.Size(75, 23)
        Me.botResetRadButtons1erT.TabIndex = 10
        Me.botResetRadButtons1erT.Text = "Reset"
        Me.botResetRadButtons1erT.UseVisualStyleBackColor = True
        '
        'GroupBox55
        '
        Me.GroupBox55.Controls.Add(Me.rad1erTtipoEmbarazo02)
        Me.GroupBox55.Controls.Add(Me.rad1erTtipoEmbarazo01)
        Me.GroupBox55.Location = New System.Drawing.Point(6, 126)
        Me.GroupBox55.Name = "GroupBox55"
        Me.GroupBox55.Size = New System.Drawing.Size(98, 100)
        Me.GroupBox55.TabIndex = 9
        Me.GroupBox55.TabStop = False
        Me.GroupBox55.Text = "Tipo Embarazo"
        '
        'rad1erTtipoEmbarazo02
        '
        Me.rad1erTtipoEmbarazo02.Location = New System.Drawing.Point(6, 34)
        Me.rad1erTtipoEmbarazo02.Name = "rad1erTtipoEmbarazo02"
        Me.rad1erTtipoEmbarazo02.Size = New System.Drawing.Size(80, 24)
        Me.rad1erTtipoEmbarazo02.TabIndex = 2
        Me.rad1erTtipoEmbarazo02.Text = "Gemelar"
        '
        'rad1erTtipoEmbarazo01
        '
        Me.rad1erTtipoEmbarazo01.Location = New System.Drawing.Point(6, 14)
        Me.rad1erTtipoEmbarazo01.Name = "rad1erTtipoEmbarazo01"
        Me.rad1erTtipoEmbarazo01.Size = New System.Drawing.Size(72, 24)
        Me.rad1erTtipoEmbarazo01.TabIndex = 1
        Me.rad1erTtipoEmbarazo01.Text = "Simple"
        '
        'GroupBox40
        '
        Me.GroupBox40.Controls.Add(Me.GroupBox54)
        Me.GroupBox40.Controls.Add(Me.GroupBox42)
        Me.GroupBox40.Controls.Add(Me.GroupBox41)
        Me.GroupBox40.Controls.Add(Me.GroupBox39)
        Me.GroupBox40.Location = New System.Drawing.Point(475, 20)
        Me.GroupBox40.Name = "GroupBox40"
        Me.GroupBox40.Size = New System.Drawing.Size(226, 164)
        Me.GroupBox40.TabIndex = 8
        Me.GroupBox40.TabStop = False
        Me.GroupBox40.Text = "Perinatales"
        '
        'GroupBox54
        '
        Me.GroupBox54.Controls.Add(Me.rad1erTanguloFM02)
        Me.GroupBox54.Controls.Add(Me.rad1erTanguloFM01)
        Me.GroupBox54.Location = New System.Drawing.Point(120, 89)
        Me.GroupBox54.Name = "GroupBox54"
        Me.GroupBox54.Size = New System.Drawing.Size(98, 64)
        Me.GroupBox54.TabIndex = 10
        Me.GroupBox54.TabStop = False
        Me.GroupBox54.Text = "Angulo F-M"
        '
        'rad1erTanguloFM02
        '
        Me.rad1erTanguloFM02.Location = New System.Drawing.Point(6, 34)
        Me.rad1erTanguloFM02.Name = "rad1erTanguloFM02"
        Me.rad1erTanguloFM02.Size = New System.Drawing.Size(80, 24)
        Me.rad1erTanguloFM02.TabIndex = 2
        Me.rad1erTanguloFM02.Text = "Anormal"
        '
        'rad1erTanguloFM01
        '
        Me.rad1erTanguloFM01.Location = New System.Drawing.Point(6, 14)
        Me.rad1erTanguloFM01.Name = "rad1erTanguloFM01"
        Me.rad1erTanguloFM01.Size = New System.Drawing.Size(72, 24)
        Me.rad1erTanguloFM01.TabIndex = 1
        Me.rad1erTanguloFM01.Text = "Normal"
        '
        'GroupBox42
        '
        Me.GroupBox42.Controls.Add(Me.rad1erTductusVenoso02)
        Me.GroupBox42.Controls.Add(Me.rad1erTductusVenoso01)
        Me.GroupBox42.Location = New System.Drawing.Point(120, 19)
        Me.GroupBox42.Name = "GroupBox42"
        Me.GroupBox42.Size = New System.Drawing.Size(98, 64)
        Me.GroupBox42.TabIndex = 9
        Me.GroupBox42.TabStop = False
        Me.GroupBox42.Text = "Ductus Venoso"
        '
        'rad1erTductusVenoso02
        '
        Me.rad1erTductusVenoso02.Location = New System.Drawing.Point(6, 34)
        Me.rad1erTductusVenoso02.Name = "rad1erTductusVenoso02"
        Me.rad1erTductusVenoso02.Size = New System.Drawing.Size(80, 24)
        Me.rad1erTductusVenoso02.TabIndex = 2
        Me.rad1erTductusVenoso02.Text = "Anormal"
        '
        'rad1erTductusVenoso01
        '
        Me.rad1erTductusVenoso01.Location = New System.Drawing.Point(6, 14)
        Me.rad1erTductusVenoso01.Name = "rad1erTductusVenoso01"
        Me.rad1erTductusVenoso01.Size = New System.Drawing.Size(72, 24)
        Me.rad1erTductusVenoso01.TabIndex = 1
        Me.rad1erTductusVenoso01.Text = "Normal"
        '
        'GroupBox41
        '
        Me.GroupBox41.Controls.Add(Me.rad1erThuesosNasales02)
        Me.GroupBox41.Controls.Add(Me.rad1erThuesosNasales01)
        Me.GroupBox41.Location = New System.Drawing.Point(9, 89)
        Me.GroupBox41.Name = "GroupBox41"
        Me.GroupBox41.Size = New System.Drawing.Size(105, 64)
        Me.GroupBox41.TabIndex = 8
        Me.GroupBox41.TabStop = False
        Me.GroupBox41.Text = "H. Nasales"
        '
        'rad1erThuesosNasales02
        '
        Me.rad1erThuesosNasales02.Location = New System.Drawing.Point(6, 34)
        Me.rad1erThuesosNasales02.Name = "rad1erThuesosNasales02"
        Me.rad1erThuesosNasales02.Size = New System.Drawing.Size(80, 24)
        Me.rad1erThuesosNasales02.TabIndex = 2
        Me.rad1erThuesosNasales02.Text = "Ausentes"
        '
        'rad1erThuesosNasales01
        '
        Me.rad1erThuesosNasales01.Location = New System.Drawing.Point(6, 14)
        Me.rad1erThuesosNasales01.Name = "rad1erThuesosNasales01"
        Me.rad1erThuesosNasales01.Size = New System.Drawing.Size(93, 24)
        Me.rad1erThuesosNasales01.TabIndex = 1
        Me.rad1erThuesosNasales01.Text = "Presentes"
        '
        'GroupBox39
        '
        Me.GroupBox39.Controls.Add(Me.rad1erTtranslucencia02)
        Me.GroupBox39.Controls.Add(Me.rad1erTtranslucencia01)
        Me.GroupBox39.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox39.Name = "GroupBox39"
        Me.GroupBox39.Size = New System.Drawing.Size(105, 64)
        Me.GroupBox39.TabIndex = 7
        Me.GroupBox39.TabStop = False
        Me.GroupBox39.Text = "Transl. Nucal"
        '
        'rad1erTtranslucencia02
        '
        Me.rad1erTtranslucencia02.Location = New System.Drawing.Point(6, 34)
        Me.rad1erTtranslucencia02.Name = "rad1erTtranslucencia02"
        Me.rad1erTtranslucencia02.Size = New System.Drawing.Size(80, 24)
        Me.rad1erTtranslucencia02.TabIndex = 2
        Me.rad1erTtranslucencia02.Text = "Anormal"
        '
        'rad1erTtranslucencia01
        '
        Me.rad1erTtranslucencia01.Location = New System.Drawing.Point(6, 14)
        Me.rad1erTtranslucencia01.Name = "rad1erTtranslucencia01"
        Me.rad1erTtranslucencia01.Size = New System.Drawing.Size(72, 24)
        Me.rad1erTtranslucencia01.TabIndex = 1
        Me.rad1erTtranslucencia01.Text = "Normal"
        '
        'GroupBox38
        '
        Me.GroupBox38.Controls.Add(Me.rad1erTlocalizacionEmbarazo02)
        Me.GroupBox38.Controls.Add(Me.rad1erTLocalizacionEmbarazo01)
        Me.GroupBox38.Location = New System.Drawing.Point(110, 20)
        Me.GroupBox38.Name = "GroupBox38"
        Me.GroupBox38.Size = New System.Drawing.Size(115, 100)
        Me.GroupBox38.TabIndex = 6
        Me.GroupBox38.TabStop = False
        Me.GroupBox38.Text = "Loc. Embarazo"
        '
        'rad1erTlocalizacionEmbarazo02
        '
        Me.rad1erTlocalizacionEmbarazo02.Location = New System.Drawing.Point(6, 34)
        Me.rad1erTlocalizacionEmbarazo02.Name = "rad1erTlocalizacionEmbarazo02"
        Me.rad1erTlocalizacionEmbarazo02.Size = New System.Drawing.Size(103, 24)
        Me.rad1erTlocalizacionEmbarazo02.TabIndex = 2
        Me.rad1erTlocalizacionEmbarazo02.Text = "Extrauterino"
        '
        'rad1erTLocalizacionEmbarazo01
        '
        Me.rad1erTLocalizacionEmbarazo01.Location = New System.Drawing.Point(6, 14)
        Me.rad1erTLocalizacionEmbarazo01.Name = "rad1erTLocalizacionEmbarazo01"
        Me.rad1erTLocalizacionEmbarazo01.Size = New System.Drawing.Size(89, 24)
        Me.rad1erTLocalizacionEmbarazo01.TabIndex = 1
        Me.rad1erTLocalizacionEmbarazo01.Text = "Intrauterino"
        '
        'GroupBox33
        '
        Me.GroupBox33.Controls.Add(Me.rad1erTVejiga02)
        Me.GroupBox33.Controls.Add(Me.rad1erTVejiga01)
        Me.GroupBox33.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox33.Name = "GroupBox33"
        Me.GroupBox33.Size = New System.Drawing.Size(98, 100)
        Me.GroupBox33.TabIndex = 5
        Me.GroupBox33.TabStop = False
        Me.GroupBox33.Text = "Vejiga"
        '
        'rad1erTVejiga02
        '
        Me.rad1erTVejiga02.Location = New System.Drawing.Point(6, 34)
        Me.rad1erTVejiga02.Name = "rad1erTVejiga02"
        Me.rad1erTVejiga02.Size = New System.Drawing.Size(80, 24)
        Me.rad1erTVejiga02.TabIndex = 2
        Me.rad1erTVejiga02.Text = "Vacía"
        '
        'rad1erTVejiga01
        '
        Me.rad1erTVejiga01.Location = New System.Drawing.Point(6, 14)
        Me.rad1erTVejiga01.Name = "rad1erTVejiga01"
        Me.rad1erTVejiga01.Size = New System.Drawing.Size(72, 24)
        Me.rad1erTVejiga01.TabIndex = 1
        Me.rad1erTVejiga01.Text = "Llena"
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.rad1erTVitelina02)
        Me.GroupBox23.Controls.Add(Me.rad1erTVitelina01)
        Me.GroupBox23.Location = New System.Drawing.Point(231, 92)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(116, 64)
        Me.GroupBox23.TabIndex = 4
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "V. Vitelina"
        '
        'rad1erTVitelina02
        '
        Me.rad1erTVitelina02.Location = New System.Drawing.Point(6, 36)
        Me.rad1erTVitelina02.Name = "rad1erTVitelina02"
        Me.rad1erTVitelina02.Size = New System.Drawing.Size(105, 24)
        Me.rad1erTVitelina02.TabIndex = 2
        Me.rad1erTVitelina02.Text = "No Visible"
        '
        'rad1erTVitelina01
        '
        Me.rad1erTVitelina01.Location = New System.Drawing.Point(6, 16)
        Me.rad1erTVitelina01.Name = "rad1erTVitelina01"
        Me.rad1erTVitelina01.Size = New System.Drawing.Size(100, 24)
        Me.rad1erTVitelina01.TabIndex = 1
        Me.rad1erTVitelina01.Text = "Visible Normal"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Rad1erTActCardiaca2)
        Me.GroupBox7.Controls.Add(Me.Rad1erTActCardiaca1)
        Me.GroupBox7.Location = New System.Drawing.Point(353, 126)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(116, 100)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Act. Cardíaca"
        '
        'Rad1erTActCardiaca2
        '
        Me.Rad1erTActCardiaca2.Location = New System.Drawing.Point(6, 36)
        Me.Rad1erTActCardiaca2.Name = "Rad1erTActCardiaca2"
        Me.Rad1erTActCardiaca2.Size = New System.Drawing.Size(80, 24)
        Me.Rad1erTActCardiaca2.TabIndex = 2
        Me.Rad1erTActCardiaca2.Text = "No Visible"
        '
        'Rad1erTActCardiaca1
        '
        Me.Rad1erTActCardiaca1.Location = New System.Drawing.Point(6, 16)
        Me.Rad1erTActCardiaca1.Name = "Rad1erTActCardiaca1"
        Me.Rad1erTActCardiaca1.Size = New System.Drawing.Size(72, 24)
        Me.Rad1erTActCardiaca1.TabIndex = 1
        Me.Rad1erTActCardiaca1.Text = "Visible"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Rad1erTMovimientos2)
        Me.GroupBox6.Controls.Add(Me.Rad1erTMovimientos1)
        Me.GroupBox6.Location = New System.Drawing.Point(353, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(116, 100)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Movimientos"
        '
        'Rad1erTMovimientos2
        '
        Me.Rad1erTMovimientos2.Location = New System.Drawing.Point(6, 36)
        Me.Rad1erTMovimientos2.Name = "Rad1erTMovimientos2"
        Me.Rad1erTMovimientos2.Size = New System.Drawing.Size(80, 24)
        Me.Rad1erTMovimientos2.TabIndex = 2
        Me.Rad1erTMovimientos2.Text = "No Visibles"
        '
        'Rad1erTMovimientos1
        '
        Me.Rad1erTMovimientos1.Location = New System.Drawing.Point(6, 16)
        Me.Rad1erTMovimientos1.Name = "Rad1erTMovimientos1"
        Me.Rad1erTMovimientos1.Size = New System.Drawing.Size(72, 24)
        Me.Rad1erTMovimientos1.TabIndex = 1
        Me.Rad1erTMovimientos1.Text = "Visibles"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Rad1erTEmbrion2)
        Me.GroupBox5.Controls.Add(Me.Rad1erTEmbrion1)
        Me.GroupBox5.Location = New System.Drawing.Point(231, 162)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(116, 64)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Embrión"
        '
        'Rad1erTEmbrion2
        '
        Me.Rad1erTEmbrion2.Location = New System.Drawing.Point(8, 36)
        Me.Rad1erTEmbrion2.Name = "Rad1erTEmbrion2"
        Me.Rad1erTEmbrion2.Size = New System.Drawing.Size(80, 24)
        Me.Rad1erTEmbrion2.TabIndex = 2
        Me.Rad1erTEmbrion2.Text = "No Visible"
        '
        'Rad1erTEmbrion1
        '
        Me.Rad1erTEmbrion1.Location = New System.Drawing.Point(8, 16)
        Me.Rad1erTEmbrion1.Name = "Rad1erTEmbrion1"
        Me.Rad1erTEmbrion1.Size = New System.Drawing.Size(64, 24)
        Me.Rad1erTEmbrion1.TabIndex = 1
        Me.Rad1erTEmbrion1.Text = "Visible"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Rad1erTImplantacion4)
        Me.GroupBox4.Controls.Add(Me.Rad1erTImplantacion3)
        Me.GroupBox4.Controls.Add(Me.Rad1erTImplantacion2)
        Me.GroupBox4.Controls.Add(Me.Rad1erTImplantacion1)
        Me.GroupBox4.Location = New System.Drawing.Point(109, 126)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(116, 100)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Implantación"
        '
        'Rad1erTImplantacion4
        '
        Me.Rad1erTImplantacion4.Location = New System.Drawing.Point(6, 74)
        Me.Rad1erTImplantacion4.Name = "Rad1erTImplantacion4"
        Me.Rad1erTImplantacion4.Size = New System.Drawing.Size(64, 24)
        Me.Rad1erTImplantacion4.TabIndex = 4
        Me.Rad1erTImplantacion4.Text = "Baja"
        '
        'Rad1erTImplantacion3
        '
        Me.Rad1erTImplantacion3.Location = New System.Drawing.Point(6, 54)
        Me.Rad1erTImplantacion3.Name = "Rad1erTImplantacion3"
        Me.Rad1erTImplantacion3.Size = New System.Drawing.Size(102, 24)
        Me.Rad1erTImplantacion3.TabIndex = 3
        Me.Rad1erTImplantacion3.Text = "Fúndica"
        '
        'Rad1erTImplantacion2
        '
        Me.Rad1erTImplantacion2.Location = New System.Drawing.Point(6, 34)
        Me.Rad1erTImplantacion2.Name = "Rad1erTImplantacion2"
        Me.Rad1erTImplantacion2.Size = New System.Drawing.Size(72, 24)
        Me.Rad1erTImplantacion2.TabIndex = 2
        Me.Rad1erTImplantacion2.Text = "Posterior"
        '
        'Rad1erTImplantacion1
        '
        Me.Rad1erTImplantacion1.Location = New System.Drawing.Point(6, 14)
        Me.Rad1erTImplantacion1.Name = "Rad1erTImplantacion1"
        Me.Rad1erTImplantacion1.Size = New System.Drawing.Size(64, 24)
        Me.Rad1erTImplantacion1.TabIndex = 1
        Me.Rad1erTImplantacion1.Text = "Anterior"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Controls.Add(Me.GroupBox9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(900, 358)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Impresión Diagnóstica"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txt1erTcomentarios05)
        Me.GroupBox8.Controls.Add(Me.txt1erTcomentarios04)
        Me.GroupBox8.Controls.Add(Me.txt1erTcomentarios03)
        Me.GroupBox8.Controls.Add(Me.txt1erTcomentarios02)
        Me.GroupBox8.Controls.Add(Me.txt1erTComentarios01)
        Me.GroupBox8.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(721, 129)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Observaciones"
        '
        'txt1erTcomentarios05
        '
        Me.txt1erTcomentarios05.Location = New System.Drawing.Point(9, 105)
        Me.txt1erTcomentarios05.MaxLength = 100
        Me.txt1erTcomentarios05.Name = "txt1erTcomentarios05"
        Me.txt1erTcomentarios05.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt1erTcomentarios05.Size = New System.Drawing.Size(706, 20)
        Me.txt1erTcomentarios05.TabIndex = 4
        '
        'txt1erTcomentarios04
        '
        Me.txt1erTcomentarios04.Location = New System.Drawing.Point(9, 82)
        Me.txt1erTcomentarios04.MaxLength = 100
        Me.txt1erTcomentarios04.Name = "txt1erTcomentarios04"
        Me.txt1erTcomentarios04.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt1erTcomentarios04.Size = New System.Drawing.Size(706, 20)
        Me.txt1erTcomentarios04.TabIndex = 3
        '
        'txt1erTcomentarios03
        '
        Me.txt1erTcomentarios03.Location = New System.Drawing.Point(9, 59)
        Me.txt1erTcomentarios03.MaxLength = 100
        Me.txt1erTcomentarios03.Name = "txt1erTcomentarios03"
        Me.txt1erTcomentarios03.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt1erTcomentarios03.Size = New System.Drawing.Size(706, 20)
        Me.txt1erTcomentarios03.TabIndex = 2
        '
        'txt1erTcomentarios02
        '
        Me.txt1erTcomentarios02.Location = New System.Drawing.Point(9, 37)
        Me.txt1erTcomentarios02.MaxLength = 100
        Me.txt1erTcomentarios02.Name = "txt1erTcomentarios02"
        Me.txt1erTcomentarios02.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt1erTcomentarios02.Size = New System.Drawing.Size(706, 20)
        Me.txt1erTcomentarios02.TabIndex = 1
        '
        'txt1erTComentarios01
        '
        Me.txt1erTComentarios01.Location = New System.Drawing.Point(9, 15)
        Me.txt1erTComentarios01.MaxLength = 100
        Me.txt1erTComentarios01.Name = "txt1erTComentarios01"
        Me.txt1erTComentarios01.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt1erTComentarios01.Size = New System.Drawing.Size(706, 20)
        Me.txt1erTComentarios01.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txt1erEGxECO)
        Me.GroupBox9.Controls.Add(Me.txt1erTidx03)
        Me.GroupBox9.Controls.Add(Me.txt1erTidx02)
        Me.GroupBox9.Controls.Add(Me.Label29)
        Me.GroupBox9.Controls.Add(Me.lab1ertEGxFUR02)
        Me.GroupBox9.Controls.Add(Me.Label27)
        Me.GroupBox9.Controls.Add(Me.txt1erTidx01)
        Me.GroupBox9.Location = New System.Drawing.Point(7, 137)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(721, 204)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Impresión Diagnóstica"
        '
        'txt1erEGxECO
        '
        Me.txt1erEGxECO.Location = New System.Drawing.Point(142, 43)
        Me.txt1erEGxECO.Name = "txt1erEGxECO"
        Me.txt1erEGxECO.Size = New System.Drawing.Size(184, 20)
        Me.txt1erEGxECO.TabIndex = 19
        '
        'txt1erTidx03
        '
        Me.txt1erTidx03.Location = New System.Drawing.Point(9, 115)
        Me.txt1erTidx03.MaxLength = 100
        Me.txt1erTidx03.Name = "txt1erTidx03"
        Me.txt1erTidx03.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt1erTidx03.Size = New System.Drawing.Size(706, 20)
        Me.txt1erTidx03.TabIndex = 18
        '
        'txt1erTidx02
        '
        Me.txt1erTidx02.Location = New System.Drawing.Point(9, 92)
        Me.txt1erTidx02.MaxLength = 100
        Me.txt1erTidx02.Name = "txt1erTidx02"
        Me.txt1erTidx02.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt1erTidx02.Size = New System.Drawing.Size(706, 20)
        Me.txt1erTidx02.TabIndex = 17
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(9, 46)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(127, 13)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "Edad Gestacional x ECO:"
        '
        'lab1ertEGxFUR02
        '
        Me.lab1ertEGxFUR02.BackColor = System.Drawing.SystemColors.Info
        Me.lab1ertEGxFUR02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab1ertEGxFUR02.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lab1ertEGxFUR02.Location = New System.Drawing.Point(142, 13)
        Me.lab1ertEGxFUR02.Name = "lab1ertEGxFUR02"
        Me.lab1ertEGxFUR02.Size = New System.Drawing.Size(184, 20)
        Me.lab1ertEGxFUR02.TabIndex = 14
        Me.lab1ertEGxFUR02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(127, 13)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Edad Gestacional x FUR:"
        '
        'txt1erTidx01
        '
        Me.txt1erTidx01.Location = New System.Drawing.Point(9, 69)
        Me.txt1erTidx01.MaxLength = 100
        Me.txt1erTidx01.Name = "txt1erTidx01"
        Me.txt1erTidx01.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt1erTidx01.Size = New System.Drawing.Size(706, 20)
        Me.txt1erTidx01.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEdad1erT)
        Me.GroupBox2.Controls.Add(Me.labFUR1erT)
        Me.GroupBox2.Controls.Add(Me.txtParidad1erT)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.labNombre1erT)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.labFechaControl1erT)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lab1ertEGxFUR01)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.labFPP1erT)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(748, 76)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Identificación"
        '
        'txtEdad1erT
        '
        Me.txtEdad1erT.Location = New System.Drawing.Point(374, 18)
        Me.txtEdad1erT.MaxLength = 2
        Me.txtEdad1erT.Name = "txtEdad1erT"
        Me.txtEdad1erT.Size = New System.Drawing.Size(32, 20)
        Me.txtEdad1erT.TabIndex = 15
        '
        'labFUR1erT
        '
        Me.labFUR1erT.BackColor = System.Drawing.SystemColors.Info
        Me.labFUR1erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFUR1erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFUR1erT.Location = New System.Drawing.Point(218, 45)
        Me.labFUR1erT.Name = "labFUR1erT"
        Me.labFUR1erT.Size = New System.Drawing.Size(72, 20)
        Me.labFUR1erT.TabIndex = 9
        Me.labFUR1erT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtParidad1erT
        '
        Me.txtParidad1erT.Location = New System.Drawing.Point(464, 18)
        Me.txtParidad1erT.MaxLength = 30
        Me.txtParidad1erT.Name = "txtParidad1erT"
        Me.txtParidad1erT.Size = New System.Drawing.Size(224, 20)
        Me.txtParidad1erT.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(416, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 23)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Paridad:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(328, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 23)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Edad:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labNombre1erT
        '
        Me.labNombre1erT.BackColor = System.Drawing.SystemColors.Info
        Me.labNombre1erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombre1erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombre1erT.Location = New System.Drawing.Point(58, 17)
        Me.labNombre1erT.Name = "labNombre1erT"
        Me.labNombre1erT.Size = New System.Drawing.Size(264, 20)
        Me.labNombre1erT.TabIndex = 1
        Me.labNombre1erT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nombre:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fecha Control"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labFechaControl1erT
        '
        Me.labFechaControl1erT.BackColor = System.Drawing.SystemColors.Info
        Me.labFechaControl1erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFechaControl1erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFechaControl1erT.Location = New System.Drawing.Point(94, 45)
        Me.labFechaControl1erT.Name = "labFechaControl1erT"
        Me.labFechaControl1erT.Size = New System.Drawing.Size(72, 20)
        Me.labFechaControl1erT.TabIndex = 7
        Me.labFechaControl1erT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(442, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "EG x FUR"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(306, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "FPP"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lab1ertEGxFUR01
        '
        Me.lab1ertEGxFUR01.BackColor = System.Drawing.SystemColors.Info
        Me.lab1ertEGxFUR01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab1ertEGxFUR01.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lab1ertEGxFUR01.Location = New System.Drawing.Point(504, 45)
        Me.lab1ertEGxFUR01.Name = "lab1ertEGxFUR01"
        Me.lab1ertEGxFUR01.Size = New System.Drawing.Size(184, 20)
        Me.lab1ertEGxFUR01.TabIndex = 13
        Me.lab1ertEGxFUR01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(180, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "FUR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labFPP1erT
        '
        Me.labFPP1erT.BackColor = System.Drawing.SystemColors.Info
        Me.labFPP1erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFPP1erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFPP1erT.Location = New System.Drawing.Point(352, 45)
        Me.labFPP1erT.Name = "labFPP1erT"
        Me.labFPP1erT.Size = New System.Drawing.Size(72, 20)
        Me.labFPP1erT.TabIndex = 11
        Me.labFPP1erT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ecografía Obstétrica del 1er Trimestre."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaInicioControl
        '
        Me.txtFechaInicioControl.BackColor = System.Drawing.SystemColors.Info
        Me.txtFechaInicioControl.Location = New System.Drawing.Point(520, 4)
        Me.txtFechaInicioControl.Name = "txtFechaInicioControl"
        Me.txtFechaInicioControl.ReadOnly = True
        Me.txtFechaInicioControl.Size = New System.Drawing.Size(240, 20)
        Me.txtFechaInicioControl.TabIndex = 7
        Me.txtFechaInicioControl.TabStop = False
        Me.txtFechaInicioControl.Text = "Ninguno"
        '
        'Label108
        '
        Me.Label108.Location = New System.Drawing.Point(372, 4)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(128, 23)
        Me.Label108.TabIndex = 6
        Me.Label108.Text = "Informe realizado el día :"
        Me.Label108.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelNuevoControlGinecologico
        '
        Me.PanelNuevoControlGinecologico.Controls.Add(Me.TabControl5)
        Me.PanelNuevoControlGinecologico.Controls.Add(Me.GroupBox44)
        Me.PanelNuevoControlGinecologico.Controls.Add(Me.Label77)
        Me.PanelNuevoControlGinecologico.Location = New System.Drawing.Point(3, 1023)
        Me.PanelNuevoControlGinecologico.Name = "PanelNuevoControlGinecologico"
        Me.PanelNuevoControlGinecologico.Size = New System.Drawing.Size(933, 384)
        Me.PanelNuevoControlGinecologico.TabIndex = 4
        '
        'TabControl5
        '
        Me.TabControl5.Controls.Add(Me.TabGinBiometricos)
        Me.TabControl5.Controls.Add(Me.TabGinVejiga)
        Me.TabControl5.Controls.Add(Me.TabGinUtero)
        Me.TabControl5.Controls.Add(Me.TabGinOvarios)
        Me.TabControl5.Controls.Add(Me.TabGinOtros)
        Me.TabControl5.Controls.Add(Me.TabIDxGin)
        Me.TabControl5.Location = New System.Drawing.Point(8, 106)
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(736, 275)
        Me.TabControl5.TabIndex = 21
        '
        'TabGinBiometricos
        '
        Me.TabGinBiometricos.BackColor = System.Drawing.SystemColors.Control
        Me.TabGinBiometricos.Controls.Add(Me.Panel6)
        Me.TabGinBiometricos.Controls.Add(Me.Panel5)
        Me.TabGinBiometricos.Controls.Add(Me.GroupBox47)
        Me.TabGinBiometricos.Controls.Add(Me.GroupBox45)
        Me.TabGinBiometricos.Controls.Add(Me.GroupBox46)
        Me.TabGinBiometricos.Location = New System.Drawing.Point(4, 22)
        Me.TabGinBiometricos.Name = "TabGinBiometricos"
        Me.TabGinBiometricos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGinBiometricos.Size = New System.Drawing.Size(728, 249)
        Me.TabGinBiometricos.TabIndex = 0
        Me.TabGinBiometricos.Text = "Biométricos"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.radGINfrec75)
        Me.Panel6.Controls.Add(Me.radGINfrec50)
        Me.Panel6.Controls.Add(Me.radGINfrec35)
        Me.Panel6.Location = New System.Drawing.Point(242, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(340, 28)
        Me.Panel6.TabIndex = 21
        '
        'radGINfrec75
        '
        Me.radGINfrec75.AutoSize = True
        Me.radGINfrec75.Location = New System.Drawing.Point(187, 4)
        Me.radGINfrec75.Name = "radGINfrec75"
        Me.radGINfrec75.Size = New System.Drawing.Size(65, 17)
        Me.radGINfrec75.TabIndex = 2
        Me.radGINfrec75.TabStop = True
        Me.radGINfrec75.Text = "7.5 MHz"
        Me.radGINfrec75.UseVisualStyleBackColor = True
        '
        'radGINfrec50
        '
        Me.radGINfrec50.AutoSize = True
        Me.radGINfrec50.Location = New System.Drawing.Point(102, 4)
        Me.radGINfrec50.Name = "radGINfrec50"
        Me.radGINfrec50.Size = New System.Drawing.Size(65, 17)
        Me.radGINfrec50.TabIndex = 1
        Me.radGINfrec50.TabStop = True
        Me.radGINfrec50.Text = "5.0 MHz"
        Me.radGINfrec50.UseVisualStyleBackColor = True
        '
        'radGINfrec35
        '
        Me.radGINfrec35.AutoSize = True
        Me.radGINfrec35.Location = New System.Drawing.Point(6, 4)
        Me.radGINfrec35.Name = "radGINfrec35"
        Me.radGINfrec35.Size = New System.Drawing.Size(65, 17)
        Me.radGINfrec35.TabIndex = 0
        Me.radGINfrec35.TabStop = True
        Me.radGINfrec35.Text = "3.5 MHz"
        Me.radGINfrec35.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.radTipoEstudioGinecologico1)
        Me.Panel5.Controls.Add(Me.radTipoEstudioGinecologico2)
        Me.Panel5.Location = New System.Drawing.Point(8, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 28)
        Me.Panel5.TabIndex = 20
        '
        'radTipoEstudioGinecologico1
        '
        Me.radTipoEstudioGinecologico1.AutoSize = True
        Me.radTipoEstudioGinecologico1.Location = New System.Drawing.Point(4, 4)
        Me.radTipoEstudioGinecologico1.Name = "radTipoEstudioGinecologico1"
        Me.radTipoEstudioGinecologico1.Size = New System.Drawing.Size(86, 17)
        Me.radTipoEstudioGinecologico1.TabIndex = 1
        Me.radTipoEstudioGinecologico1.TabStop = True
        Me.radTipoEstudioGinecologico1.Text = "Transvaginal"
        Me.radTipoEstudioGinecologico1.UseVisualStyleBackColor = True
        '
        'radTipoEstudioGinecologico2
        '
        Me.radTipoEstudioGinecologico2.AutoSize = True
        Me.radTipoEstudioGinecologico2.Location = New System.Drawing.Point(109, 4)
        Me.radTipoEstudioGinecologico2.Name = "radTipoEstudioGinecologico2"
        Me.radTipoEstudioGinecologico2.Size = New System.Drawing.Size(74, 17)
        Me.radTipoEstudioGinecologico2.TabIndex = 0
        Me.radTipoEstudioGinecologico2.TabStop = True
        Me.radTipoEstudioGinecologico2.Text = "Abdominal"
        Me.radTipoEstudioGinecologico2.UseVisualStyleBackColor = True
        '
        'GroupBox47
        '
        Me.GroupBox47.Controls.Add(Me.Label115)
        Me.GroupBox47.Controls.Add(Me.Label116)
        Me.GroupBox47.Controls.Add(Me.Label113)
        Me.GroupBox47.Controls.Add(Me.Label114)
        Me.GroupBox47.Controls.Add(Me.Label35)
        Me.GroupBox47.Controls.Add(Me.Label112)
        Me.GroupBox47.Controls.Add(Me.Label64)
        Me.GroupBox47.Controls.Add(Me.Label111)
        Me.GroupBox47.Controls.Add(Me.txtOvarioIzquierdoFoliculo4)
        Me.GroupBox47.Controls.Add(Me.txtOvarioIzquierdoFoliculo3)
        Me.GroupBox47.Controls.Add(Me.txtOvarioIzquierdoFoliculo2)
        Me.GroupBox47.Controls.Add(Me.txtOvarioIzquierdoFoliculo1)
        Me.GroupBox47.Controls.Add(Me.txtOvarioDerechoFoliculo4)
        Me.GroupBox47.Controls.Add(Me.txtOvarioDerechoFoliculo3)
        Me.GroupBox47.Controls.Add(Me.txtOvarioDerechoFoliculo2)
        Me.GroupBox47.Controls.Add(Me.txtOvarioDerechoFoliculo1)
        Me.GroupBox47.Controls.Add(Me.Label86)
        Me.GroupBox47.Controls.Add(Me.Label87)
        Me.GroupBox47.Location = New System.Drawing.Point(498, 41)
        Me.GroupBox47.Name = "GroupBox47"
        Me.GroupBox47.Size = New System.Drawing.Size(222, 182)
        Me.GroupBox47.TabIndex = 7
        Me.GroupBox47.TabStop = False
        Me.GroupBox47.Text = "Folículos Dominantes"
        '
        'Label115
        '
        Me.Label115.Location = New System.Drawing.Point(160, 114)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(24, 23)
        Me.Label115.TabIndex = 21
        Me.Label115.Text = "mm"
        Me.Label115.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label116
        '
        Me.Label116.Location = New System.Drawing.Point(160, 62)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(24, 23)
        Me.Label116.TabIndex = 20
        Me.Label116.Text = "mm"
        Me.Label116.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label113
        '
        Me.Label113.Location = New System.Drawing.Point(159, 88)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(24, 23)
        Me.Label113.TabIndex = 19
        Me.Label113.Text = "mm"
        Me.Label113.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label114
        '
        Me.Label114.Location = New System.Drawing.Point(160, 36)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(24, 23)
        Me.Label114.TabIndex = 18
        Me.Label114.Text = "mm"
        Me.Label114.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(52, 114)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(24, 23)
        Me.Label35.TabIndex = 17
        Me.Label35.Text = "mm"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label112
        '
        Me.Label112.Location = New System.Drawing.Point(52, 62)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(24, 23)
        Me.Label112.TabIndex = 16
        Me.Label112.Text = "mm"
        Me.Label112.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.Location = New System.Drawing.Point(52, 88)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(24, 23)
        Me.Label64.TabIndex = 15
        Me.Label64.Text = "mm"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label111
        '
        Me.Label111.Location = New System.Drawing.Point(52, 36)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(24, 23)
        Me.Label111.TabIndex = 14
        Me.Label111.Text = "mm"
        Me.Label111.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOvarioIzquierdoFoliculo4
        '
        Me.txtOvarioIzquierdoFoliculo4.Location = New System.Drawing.Point(126, 116)
        Me.txtOvarioIzquierdoFoliculo4.MaxLength = 3
        Me.txtOvarioIzquierdoFoliculo4.Name = "txtOvarioIzquierdoFoliculo4"
        Me.txtOvarioIzquierdoFoliculo4.Size = New System.Drawing.Size(28, 20)
        Me.txtOvarioIzquierdoFoliculo4.TabIndex = 9
        '
        'txtOvarioIzquierdoFoliculo3
        '
        Me.txtOvarioIzquierdoFoliculo3.Location = New System.Drawing.Point(126, 90)
        Me.txtOvarioIzquierdoFoliculo3.MaxLength = 3
        Me.txtOvarioIzquierdoFoliculo3.Name = "txtOvarioIzquierdoFoliculo3"
        Me.txtOvarioIzquierdoFoliculo3.Size = New System.Drawing.Size(28, 20)
        Me.txtOvarioIzquierdoFoliculo3.TabIndex = 8
        '
        'txtOvarioIzquierdoFoliculo2
        '
        Me.txtOvarioIzquierdoFoliculo2.Location = New System.Drawing.Point(126, 64)
        Me.txtOvarioIzquierdoFoliculo2.MaxLength = 3
        Me.txtOvarioIzquierdoFoliculo2.Name = "txtOvarioIzquierdoFoliculo2"
        Me.txtOvarioIzquierdoFoliculo2.Size = New System.Drawing.Size(28, 20)
        Me.txtOvarioIzquierdoFoliculo2.TabIndex = 7
        '
        'txtOvarioIzquierdoFoliculo1
        '
        Me.txtOvarioIzquierdoFoliculo1.Location = New System.Drawing.Point(126, 38)
        Me.txtOvarioIzquierdoFoliculo1.MaxLength = 3
        Me.txtOvarioIzquierdoFoliculo1.Name = "txtOvarioIzquierdoFoliculo1"
        Me.txtOvarioIzquierdoFoliculo1.Size = New System.Drawing.Size(28, 20)
        Me.txtOvarioIzquierdoFoliculo1.TabIndex = 6
        '
        'txtOvarioDerechoFoliculo4
        '
        Me.txtOvarioDerechoFoliculo4.Location = New System.Drawing.Point(18, 116)
        Me.txtOvarioDerechoFoliculo4.MaxLength = 3
        Me.txtOvarioDerechoFoliculo4.Name = "txtOvarioDerechoFoliculo4"
        Me.txtOvarioDerechoFoliculo4.Size = New System.Drawing.Size(28, 20)
        Me.txtOvarioDerechoFoliculo4.TabIndex = 4
        '
        'txtOvarioDerechoFoliculo3
        '
        Me.txtOvarioDerechoFoliculo3.Location = New System.Drawing.Point(18, 90)
        Me.txtOvarioDerechoFoliculo3.MaxLength = 3
        Me.txtOvarioDerechoFoliculo3.Name = "txtOvarioDerechoFoliculo3"
        Me.txtOvarioDerechoFoliculo3.Size = New System.Drawing.Size(28, 20)
        Me.txtOvarioDerechoFoliculo3.TabIndex = 3
        '
        'txtOvarioDerechoFoliculo2
        '
        Me.txtOvarioDerechoFoliculo2.Location = New System.Drawing.Point(18, 64)
        Me.txtOvarioDerechoFoliculo2.MaxLength = 3
        Me.txtOvarioDerechoFoliculo2.Name = "txtOvarioDerechoFoliculo2"
        Me.txtOvarioDerechoFoliculo2.Size = New System.Drawing.Size(28, 20)
        Me.txtOvarioDerechoFoliculo2.TabIndex = 2
        '
        'txtOvarioDerechoFoliculo1
        '
        Me.txtOvarioDerechoFoliculo1.Location = New System.Drawing.Point(18, 38)
        Me.txtOvarioDerechoFoliculo1.MaxLength = 3
        Me.txtOvarioDerechoFoliculo1.Name = "txtOvarioDerechoFoliculo1"
        Me.txtOvarioDerechoFoliculo1.Size = New System.Drawing.Size(28, 20)
        Me.txtOvarioDerechoFoliculo1.TabIndex = 1
        '
        'Label86
        '
        Me.Label86.Location = New System.Drawing.Point(119, 16)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(95, 23)
        Me.Label86.TabIndex = 5
        Me.Label86.Text = "Ovario Izquierdo"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label87
        '
        Me.Label87.Location = New System.Drawing.Point(11, 16)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(104, 23)
        Me.Label87.TabIndex = 0
        Me.Label87.Text = "Ovario Derecho"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox45
        '
        Me.GroupBox45.Controls.Add(Me.Label18)
        Me.GroupBox45.Controls.Add(Me.Label12)
        Me.GroupBox45.Controls.Add(Me.Label11)
        Me.GroupBox45.Controls.Add(Me.Label1)
        Me.GroupBox45.Controls.Add(Me.txtUteroEndometrio)
        Me.GroupBox45.Controls.Add(Me.Label80)
        Me.GroupBox45.Controls.Add(Me.txtUteroTransverso)
        Me.GroupBox45.Controls.Add(Me.Label79)
        Me.GroupBox45.Controls.Add(Me.txtUteroAnteroPosterior)
        Me.GroupBox45.Controls.Add(Me.Label78)
        Me.GroupBox45.Controls.Add(Me.txtUteroLongitudinal)
        Me.GroupBox45.Controls.Add(Me.Label74)
        Me.GroupBox45.Location = New System.Drawing.Point(8, 41)
        Me.GroupBox45.Name = "GroupBox45"
        Me.GroupBox45.Size = New System.Drawing.Size(228, 182)
        Me.GroupBox45.TabIndex = 5
        Me.GroupBox45.TabStop = False
        Me.GroupBox45.Text = "Utero"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(180, 114)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 23)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "mm"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(180, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 23)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "mm"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(180, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 23)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "mm"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(180, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "mm"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUteroEndometrio
        '
        Me.txtUteroEndometrio.Location = New System.Drawing.Point(122, 116)
        Me.txtUteroEndometrio.MaxLength = 2
        Me.txtUteroEndometrio.Name = "txtUteroEndometrio"
        Me.txtUteroEndometrio.Size = New System.Drawing.Size(52, 20)
        Me.txtUteroEndometrio.TabIndex = 3
        '
        'Label80
        '
        Me.Label80.Location = New System.Drawing.Point(9, 114)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(104, 23)
        Me.Label80.TabIndex = 6
        Me.Label80.Text = "Endometrio :"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUteroTransverso
        '
        Me.txtUteroTransverso.Location = New System.Drawing.Point(122, 90)
        Me.txtUteroTransverso.MaxLength = 3
        Me.txtUteroTransverso.Name = "txtUteroTransverso"
        Me.txtUteroTransverso.Size = New System.Drawing.Size(52, 20)
        Me.txtUteroTransverso.TabIndex = 2
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(9, 88)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(104, 23)
        Me.Label79.TabIndex = 4
        Me.Label79.Text = "Transverso :"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUteroAnteroPosterior
        '
        Me.txtUteroAnteroPosterior.Location = New System.Drawing.Point(122, 64)
        Me.txtUteroAnteroPosterior.MaxLength = 3
        Me.txtUteroAnteroPosterior.Name = "txtUteroAnteroPosterior"
        Me.txtUteroAnteroPosterior.Size = New System.Drawing.Size(52, 20)
        Me.txtUteroAnteroPosterior.TabIndex = 1
        '
        'Label78
        '
        Me.Label78.Location = New System.Drawing.Point(9, 62)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(104, 23)
        Me.Label78.TabIndex = 2
        Me.Label78.Text = "Antero Posterior :"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUteroLongitudinal
        '
        Me.txtUteroLongitudinal.Location = New System.Drawing.Point(122, 38)
        Me.txtUteroLongitudinal.MaxLength = 3
        Me.txtUteroLongitudinal.Name = "txtUteroLongitudinal"
        Me.txtUteroLongitudinal.Size = New System.Drawing.Size(52, 20)
        Me.txtUteroLongitudinal.TabIndex = 0
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(9, 36)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(104, 23)
        Me.Label74.TabIndex = 0
        Me.Label74.Text = "Longitudinal :"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox46
        '
        Me.GroupBox46.Controls.Add(Me.Label22)
        Me.GroupBox46.Controls.Add(Me.Label23)
        Me.GroupBox46.Controls.Add(Me.Label24)
        Me.GroupBox46.Controls.Add(Me.Label21)
        Me.GroupBox46.Controls.Add(Me.Label20)
        Me.GroupBox46.Controls.Add(Me.Label19)
        Me.GroupBox46.Controls.Add(Me.txtOvarioIzquierdoTransverso)
        Me.GroupBox46.Controls.Add(Me.txtOvarioDerechoTransverso)
        Me.GroupBox46.Controls.Add(Me.txtOvarioIzquierdoAnteroPosterior)
        Me.GroupBox46.Controls.Add(Me.txtOvarioDerechoAnteroPosterior)
        Me.GroupBox46.Controls.Add(Me.txtOvarioIzquierdoLongitudinal)
        Me.GroupBox46.Controls.Add(Me.txtOvarioDerechoLongitudinal)
        Me.GroupBox46.Controls.Add(Me.Label85)
        Me.GroupBox46.Controls.Add(Me.Label84)
        Me.GroupBox46.Controls.Add(Me.Label81)
        Me.GroupBox46.Controls.Add(Me.Label82)
        Me.GroupBox46.Controls.Add(Me.Label83)
        Me.GroupBox46.Location = New System.Drawing.Point(242, 41)
        Me.GroupBox46.Name = "GroupBox46"
        Me.GroupBox46.Size = New System.Drawing.Size(250, 182)
        Me.GroupBox46.TabIndex = 6
        Me.GroupBox46.TabStop = False
        Me.GroupBox46.Text = "Ovarios"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(219, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 23)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "mm"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(219, 62)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(24, 23)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "mm"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(219, 36)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(24, 23)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "mm"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(150, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(24, 23)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "mm"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(150, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 23)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "mm"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(150, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 23)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "mm"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOvarioIzquierdoTransverso
        '
        Me.txtOvarioIzquierdoTransverso.Location = New System.Drawing.Point(181, 90)
        Me.txtOvarioIzquierdoTransverso.MaxLength = 3
        Me.txtOvarioIzquierdoTransverso.Name = "txtOvarioIzquierdoTransverso"
        Me.txtOvarioIzquierdoTransverso.Size = New System.Drawing.Size(32, 20)
        Me.txtOvarioIzquierdoTransverso.TabIndex = 10
        '
        'txtOvarioDerechoTransverso
        '
        Me.txtOvarioDerechoTransverso.Location = New System.Drawing.Point(112, 90)
        Me.txtOvarioDerechoTransverso.MaxLength = 3
        Me.txtOvarioDerechoTransverso.Name = "txtOvarioDerechoTransverso"
        Me.txtOvarioDerechoTransverso.Size = New System.Drawing.Size(32, 20)
        Me.txtOvarioDerechoTransverso.TabIndex = 2
        '
        'txtOvarioIzquierdoAnteroPosterior
        '
        Me.txtOvarioIzquierdoAnteroPosterior.Location = New System.Drawing.Point(181, 64)
        Me.txtOvarioIzquierdoAnteroPosterior.MaxLength = 3
        Me.txtOvarioIzquierdoAnteroPosterior.Name = "txtOvarioIzquierdoAnteroPosterior"
        Me.txtOvarioIzquierdoAnteroPosterior.Size = New System.Drawing.Size(32, 20)
        Me.txtOvarioIzquierdoAnteroPosterior.TabIndex = 9
        '
        'txtOvarioDerechoAnteroPosterior
        '
        Me.txtOvarioDerechoAnteroPosterior.Location = New System.Drawing.Point(112, 64)
        Me.txtOvarioDerechoAnteroPosterior.MaxLength = 3
        Me.txtOvarioDerechoAnteroPosterior.Name = "txtOvarioDerechoAnteroPosterior"
        Me.txtOvarioDerechoAnteroPosterior.Size = New System.Drawing.Size(32, 20)
        Me.txtOvarioDerechoAnteroPosterior.TabIndex = 1
        '
        'txtOvarioIzquierdoLongitudinal
        '
        Me.txtOvarioIzquierdoLongitudinal.Location = New System.Drawing.Point(181, 38)
        Me.txtOvarioIzquierdoLongitudinal.MaxLength = 3
        Me.txtOvarioIzquierdoLongitudinal.Name = "txtOvarioIzquierdoLongitudinal"
        Me.txtOvarioIzquierdoLongitudinal.Size = New System.Drawing.Size(32, 20)
        Me.txtOvarioIzquierdoLongitudinal.TabIndex = 8
        '
        'txtOvarioDerechoLongitudinal
        '
        Me.txtOvarioDerechoLongitudinal.Location = New System.Drawing.Point(112, 38)
        Me.txtOvarioDerechoLongitudinal.MaxLength = 3
        Me.txtOvarioDerechoLongitudinal.Name = "txtOvarioDerechoLongitudinal"
        Me.txtOvarioDerechoLongitudinal.Size = New System.Drawing.Size(32, 20)
        Me.txtOvarioDerechoLongitudinal.TabIndex = 0
        '
        'Label85
        '
        Me.Label85.Location = New System.Drawing.Point(170, 16)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(56, 23)
        Me.Label85.TabIndex = 1
        Me.Label85.Text = "Izquierdo"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label84
        '
        Me.Label84.Location = New System.Drawing.Point(106, 16)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(48, 23)
        Me.Label84.TabIndex = 0
        Me.Label84.Text = "Derecho"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label81
        '
        Me.Label81.Location = New System.Drawing.Point(6, 88)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(92, 23)
        Me.Label81.TabIndex = 6
        Me.Label81.Text = "Transverso :"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label82
        '
        Me.Label82.Location = New System.Drawing.Point(8, 62)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(92, 23)
        Me.Label82.TabIndex = 4
        Me.Label82.Text = "Antero Posterior :"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label83
        '
        Me.Label83.Location = New System.Drawing.Point(8, 36)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(92, 23)
        Me.Label83.TabIndex = 2
        Me.Label83.Text = "Longitudinal :"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabGinVejiga
        '
        Me.TabGinVejiga.BackColor = System.Drawing.SystemColors.Control
        Me.TabGinVejiga.Controls.Add(Me.GroupBox59)
        Me.TabGinVejiga.Controls.Add(Me.GroupBox58)
        Me.TabGinVejiga.Controls.Add(Me.GroupBox57)
        Me.TabGinVejiga.Controls.Add(Me.GroupBox62)
        Me.TabGinVejiga.Location = New System.Drawing.Point(4, 22)
        Me.TabGinVejiga.Name = "TabGinVejiga"
        Me.TabGinVejiga.Size = New System.Drawing.Size(728, 249)
        Me.TabGinVejiga.TabIndex = 3
        Me.TabGinVejiga.Text = "Vejiga"
        '
        'GroupBox59
        '
        Me.GroupBox59.Controls.Add(Me.txtGinVejigaObservaciones2)
        Me.GroupBox59.Controls.Add(Me.txtGinVejigaObservaciones1)
        Me.GroupBox59.Location = New System.Drawing.Point(8, 119)
        Me.GroupBox59.Name = "GroupBox59"
        Me.GroupBox59.Size = New System.Drawing.Size(712, 71)
        Me.GroupBox59.TabIndex = 10
        Me.GroupBox59.TabStop = False
        Me.GroupBox59.Text = "Observaciones"
        '
        'txtGinVejigaObservaciones2
        '
        Me.txtGinVejigaObservaciones2.Location = New System.Drawing.Point(6, 45)
        Me.txtGinVejigaObservaciones2.MaxLength = 100
        Me.txtGinVejigaObservaciones2.Name = "txtGinVejigaObservaciones2"
        Me.txtGinVejigaObservaciones2.Size = New System.Drawing.Size(700, 20)
        Me.txtGinVejigaObservaciones2.TabIndex = 1
        '
        'txtGinVejigaObservaciones1
        '
        Me.txtGinVejigaObservaciones1.Location = New System.Drawing.Point(6, 19)
        Me.txtGinVejigaObservaciones1.MaxLength = 100
        Me.txtGinVejigaObservaciones1.Name = "txtGinVejigaObservaciones1"
        Me.txtGinVejigaObservaciones1.Size = New System.Drawing.Size(700, 20)
        Me.txtGinVejigaObservaciones1.TabIndex = 0
        '
        'GroupBox58
        '
        Me.GroupBox58.Controls.Add(Me.RadGinVejigaParedes2)
        Me.GroupBox58.Controls.Add(Me.RadGinVejigaParedes1)
        Me.GroupBox58.Location = New System.Drawing.Point(420, 13)
        Me.GroupBox58.Name = "GroupBox58"
        Me.GroupBox58.Size = New System.Drawing.Size(300, 100)
        Me.GroupBox58.TabIndex = 9
        Me.GroupBox58.TabStop = False
        Me.GroupBox58.Text = "Paredes"
        '
        'RadGinVejigaParedes2
        '
        Me.RadGinVejigaParedes2.Location = New System.Drawing.Point(6, 42)
        Me.RadGinVejigaParedes2.Name = "RadGinVejigaParedes2"
        Me.RadGinVejigaParedes2.Size = New System.Drawing.Size(173, 17)
        Me.RadGinVejigaParedes2.TabIndex = 4
        Me.RadGinVejigaParedes2.Text = "Irregulares"
        '
        'RadGinVejigaParedes1
        '
        Me.RadGinVejigaParedes1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinVejigaParedes1.Name = "RadGinVejigaParedes1"
        Me.RadGinVejigaParedes1.Size = New System.Drawing.Size(281, 17)
        Me.RadGinVejigaParedes1.TabIndex = 3
        Me.RadGinVejigaParedes1.Text = "Regulares sin lesiones en su interior"
        '
        'GroupBox57
        '
        Me.GroupBox57.Controls.Add(Me.RadGinVejigaAdecuada2)
        Me.GroupBox57.Controls.Add(Me.RadGinVejigaAdecuada1)
        Me.GroupBox57.Location = New System.Drawing.Point(214, 13)
        Me.GroupBox57.Name = "GroupBox57"
        Me.GroupBox57.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox57.TabIndex = 8
        Me.GroupBox57.TabStop = False
        Me.GroupBox57.Text = "Adecuación"
        '
        'RadGinVejigaAdecuada2
        '
        Me.RadGinVejigaAdecuada2.Location = New System.Drawing.Point(6, 42)
        Me.RadGinVejigaAdecuada2.Name = "RadGinVejigaAdecuada2"
        Me.RadGinVejigaAdecuada2.Size = New System.Drawing.Size(173, 17)
        Me.RadGinVejigaAdecuada2.TabIndex = 4
        Me.RadGinVejigaAdecuada2.Text = "No Adecuada para el Estudio"
        '
        'RadGinVejigaAdecuada1
        '
        Me.RadGinVejigaAdecuada1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinVejigaAdecuada1.Name = "RadGinVejigaAdecuada1"
        Me.RadGinVejigaAdecuada1.Size = New System.Drawing.Size(173, 17)
        Me.RadGinVejigaAdecuada1.TabIndex = 3
        Me.RadGinVejigaAdecuada1.Text = "Adecuada para el Estudio"
        '
        'GroupBox62
        '
        Me.GroupBox62.Controls.Add(Me.RadGinVejigaVolumen3)
        Me.GroupBox62.Controls.Add(Me.RadGinVejigaVolumen2)
        Me.GroupBox62.Controls.Add(Me.RadGinVejigaVolumen1)
        Me.GroupBox62.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox62.Name = "GroupBox62"
        Me.GroupBox62.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox62.TabIndex = 7
        Me.GroupBox62.TabStop = False
        Me.GroupBox62.Text = "Contenido"
        '
        'RadGinVejigaVolumen3
        '
        Me.RadGinVejigaVolumen3.Location = New System.Drawing.Point(6, 65)
        Me.RadGinVejigaVolumen3.Name = "RadGinVejigaVolumen3"
        Me.RadGinVejigaVolumen3.Size = New System.Drawing.Size(118, 17)
        Me.RadGinVejigaVolumen3.TabIndex = 2
        Me.RadGinVejigaVolumen3.Text = "Parcialmente llena"
        '
        'RadGinVejigaVolumen2
        '
        Me.RadGinVejigaVolumen2.Location = New System.Drawing.Point(6, 42)
        Me.RadGinVejigaVolumen2.Name = "RadGinVejigaVolumen2"
        Me.RadGinVejigaVolumen2.Size = New System.Drawing.Size(64, 17)
        Me.RadGinVejigaVolumen2.TabIndex = 1
        Me.RadGinVejigaVolumen2.Text = "Vacia"
        '
        'RadGinVejigaVolumen1
        '
        Me.RadGinVejigaVolumen1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinVejigaVolumen1.Name = "RadGinVejigaVolumen1"
        Me.RadGinVejigaVolumen1.Size = New System.Drawing.Size(64, 17)
        Me.RadGinVejigaVolumen1.TabIndex = 0
        Me.RadGinVejigaVolumen1.Text = "Llena"
        '
        'TabGinUtero
        '
        Me.TabGinUtero.BackColor = System.Drawing.SystemColors.Control
        Me.TabGinUtero.Controls.Add(Me.GroupBox67)
        Me.TabGinUtero.Controls.Add(Me.GroupBox61)
        Me.TabGinUtero.Controls.Add(Me.GroupBox66)
        Me.TabGinUtero.Controls.Add(Me.GroupBox65)
        Me.TabGinUtero.Controls.Add(Me.GroupBox64)
        Me.TabGinUtero.Controls.Add(Me.GroupBox63)
        Me.TabGinUtero.Controls.Add(Me.GroupBox60)
        Me.TabGinUtero.Location = New System.Drawing.Point(4, 22)
        Me.TabGinUtero.Name = "TabGinUtero"
        Me.TabGinUtero.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGinUtero.Size = New System.Drawing.Size(728, 249)
        Me.TabGinUtero.TabIndex = 1
        Me.TabGinUtero.Text = "Utero"
        '
        'GroupBox67
        '
        Me.GroupBox67.Controls.Add(Me.txtGinUteroObservaciones2)
        Me.GroupBox67.Controls.Add(Me.txtGinUteroObservaciones1)
        Me.GroupBox67.Location = New System.Drawing.Point(8, 172)
        Me.GroupBox67.Name = "GroupBox67"
        Me.GroupBox67.Size = New System.Drawing.Size(714, 71)
        Me.GroupBox67.TabIndex = 14
        Me.GroupBox67.TabStop = False
        Me.GroupBox67.Text = "Observaciones"
        '
        'txtGinUteroObservaciones2
        '
        Me.txtGinUteroObservaciones2.Location = New System.Drawing.Point(6, 45)
        Me.txtGinUteroObservaciones2.MaxLength = 100
        Me.txtGinUteroObservaciones2.Name = "txtGinUteroObservaciones2"
        Me.txtGinUteroObservaciones2.Size = New System.Drawing.Size(700, 20)
        Me.txtGinUteroObservaciones2.TabIndex = 1
        '
        'txtGinUteroObservaciones1
        '
        Me.txtGinUteroObservaciones1.Location = New System.Drawing.Point(6, 19)
        Me.txtGinUteroObservaciones1.MaxLength = 100
        Me.txtGinUteroObservaciones1.Name = "txtGinUteroObservaciones1"
        Me.txtGinUteroObservaciones1.Size = New System.Drawing.Size(700, 20)
        Me.txtGinUteroObservaciones1.TabIndex = 0
        '
        'GroupBox61
        '
        Me.GroupBox61.Controls.Add(Me.RadGinUteroCavidad5)
        Me.GroupBox61.Controls.Add(Me.RadGinUteroCavidad1)
        Me.GroupBox61.Controls.Add(Me.RadGinUteroCavidad4)
        Me.GroupBox61.Controls.Add(Me.RadGinUteroCavidad2)
        Me.GroupBox61.Controls.Add(Me.RadGinUteroCavidad3)
        Me.GroupBox61.Location = New System.Drawing.Point(556, 6)
        Me.GroupBox61.Name = "GroupBox61"
        Me.GroupBox61.Size = New System.Drawing.Size(166, 160)
        Me.GroupBox61.TabIndex = 13
        Me.GroupBox61.TabStop = False
        Me.GroupBox61.Text = "Cavidad Uterina"
        '
        'RadGinUteroCavidad5
        '
        Me.RadGinUteroCavidad5.Location = New System.Drawing.Point(6, 129)
        Me.RadGinUteroCavidad5.Name = "RadGinUteroCavidad5"
        Me.RadGinUteroCavidad5.Size = New System.Drawing.Size(118, 16)
        Me.RadGinUteroCavidad5.TabIndex = 4
        Me.RadGinUteroCavidad5.Text = "Mioma Submucoso"
        '
        'RadGinUteroCavidad1
        '
        Me.RadGinUteroCavidad1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinUteroCavidad1.Name = "RadGinUteroCavidad1"
        Me.RadGinUteroCavidad1.Size = New System.Drawing.Size(118, 16)
        Me.RadGinUteroCavidad1.TabIndex = 0
        Me.RadGinUteroCavidad1.Text = "Vacía"
        '
        'RadGinUteroCavidad4
        '
        Me.RadGinUteroCavidad4.Location = New System.Drawing.Point(6, 107)
        Me.RadGinUteroCavidad4.Name = "RadGinUteroCavidad4"
        Me.RadGinUteroCavidad4.Size = New System.Drawing.Size(118, 16)
        Me.RadGinUteroCavidad4.TabIndex = 3
        Me.RadGinUteroCavidad4.Text = "Pólipo"
        '
        'RadGinUteroCavidad2
        '
        Me.RadGinUteroCavidad2.Location = New System.Drawing.Point(6, 41)
        Me.RadGinUteroCavidad2.Name = "RadGinUteroCavidad2"
        Me.RadGinUteroCavidad2.Size = New System.Drawing.Size(151, 38)
        Me.RadGinUteroCavidad2.TabIndex = 1
        Me.RadGinUteroCavidad2.Text = "Contenido de Ecopatrón Heterogéneo"
        '
        'RadGinUteroCavidad3
        '
        Me.RadGinUteroCavidad3.Location = New System.Drawing.Point(6, 85)
        Me.RadGinUteroCavidad3.Name = "RadGinUteroCavidad3"
        Me.RadGinUteroCavidad3.Size = New System.Drawing.Size(118, 16)
        Me.RadGinUteroCavidad3.TabIndex = 2
        Me.RadGinUteroCavidad3.Text = "Hemato/Piometra"
        '
        'GroupBox66
        '
        Me.GroupBox66.Controls.Add(Me.RadGinUteroEndometrio5)
        Me.GroupBox66.Controls.Add(Me.RadGinUteroEndometrio1)
        Me.GroupBox66.Controls.Add(Me.RadGinUteroEndometrio4)
        Me.GroupBox66.Controls.Add(Me.RadGinUteroEndometrio2)
        Me.GroupBox66.Controls.Add(Me.RadGinUteroEndometrio3)
        Me.GroupBox66.Location = New System.Drawing.Point(384, 6)
        Me.GroupBox66.Name = "GroupBox66"
        Me.GroupBox66.Size = New System.Drawing.Size(166, 160)
        Me.GroupBox66.TabIndex = 12
        Me.GroupBox66.TabStop = False
        Me.GroupBox66.Text = "Endometrio"
        '
        'RadGinUteroEndometrio5
        '
        Me.RadGinUteroEndometrio5.Location = New System.Drawing.Point(6, 107)
        Me.RadGinUteroEndometrio5.Name = "RadGinUteroEndometrio5"
        Me.RadGinUteroEndometrio5.Size = New System.Drawing.Size(118, 16)
        Me.RadGinUteroEndometrio5.TabIndex = 4
        Me.RadGinUteroEndometrio5.Text = "Menstrual"
        '
        'RadGinUteroEndometrio1
        '
        Me.RadGinUteroEndometrio1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinUteroEndometrio1.Name = "RadGinUteroEndometrio1"
        Me.RadGinUteroEndometrio1.Size = New System.Drawing.Size(118, 16)
        Me.RadGinUteroEndometrio1.TabIndex = 0
        Me.RadGinUteroEndometrio1.Text = "Lineal"
        '
        'RadGinUteroEndometrio4
        '
        Me.RadGinUteroEndometrio4.Location = New System.Drawing.Point(6, 85)
        Me.RadGinUteroEndometrio4.Name = "RadGinUteroEndometrio4"
        Me.RadGinUteroEndometrio4.Size = New System.Drawing.Size(118, 16)
        Me.RadGinUteroEndometrio4.TabIndex = 3
        Me.RadGinUteroEndometrio4.Text = "Secretor"
        '
        'RadGinUteroEndometrio2
        '
        Me.RadGinUteroEndometrio2.Location = New System.Drawing.Point(6, 41)
        Me.RadGinUteroEndometrio2.Name = "RadGinUteroEndometrio2"
        Me.RadGinUteroEndometrio2.Size = New System.Drawing.Size(118, 16)
        Me.RadGinUteroEndometrio2.TabIndex = 1
        Me.RadGinUteroEndometrio2.Text = "Proliferativo Inicial"
        '
        'RadGinUteroEndometrio3
        '
        Me.RadGinUteroEndometrio3.Location = New System.Drawing.Point(6, 63)
        Me.RadGinUteroEndometrio3.Name = "RadGinUteroEndometrio3"
        Me.RadGinUteroEndometrio3.Size = New System.Drawing.Size(118, 16)
        Me.RadGinUteroEndometrio3.TabIndex = 2
        Me.RadGinUteroEndometrio3.Text = "Proliferativo Tardío"
        '
        'GroupBox65
        '
        Me.GroupBox65.Controls.Add(Me.RadGinUteroBordes1)
        Me.GroupBox65.Controls.Add(Me.RadGinUteroBordes2)
        Me.GroupBox65.Location = New System.Drawing.Point(195, 102)
        Me.GroupBox65.Name = "GroupBox65"
        Me.GroupBox65.Size = New System.Drawing.Size(183, 64)
        Me.GroupBox65.TabIndex = 11
        Me.GroupBox65.TabStop = False
        Me.GroupBox65.Text = "Bordes"
        '
        'RadGinUteroBordes1
        '
        Me.RadGinUteroBordes1.Location = New System.Drawing.Point(5, 19)
        Me.RadGinUteroBordes1.Name = "RadGinUteroBordes1"
        Me.RadGinUteroBordes1.Size = New System.Drawing.Size(140, 17)
        Me.RadGinUteroBordes1.TabIndex = 0
        Me.RadGinUteroBordes1.Text = "Bordes Regulares"
        '
        'RadGinUteroBordes2
        '
        Me.RadGinUteroBordes2.Location = New System.Drawing.Point(5, 41)
        Me.RadGinUteroBordes2.Name = "RadGinUteroBordes2"
        Me.RadGinUteroBordes2.Size = New System.Drawing.Size(140, 17)
        Me.RadGinUteroBordes2.TabIndex = 1
        Me.RadGinUteroBordes2.Text = "Bordes Irregulares"
        '
        'GroupBox64
        '
        Me.GroupBox64.Controls.Add(Me.RadGinUteroEcopatron1)
        Me.GroupBox64.Controls.Add(Me.RadGinUteroEcopatron2)
        Me.GroupBox64.Location = New System.Drawing.Point(8, 102)
        Me.GroupBox64.Name = "GroupBox64"
        Me.GroupBox64.Size = New System.Drawing.Size(181, 64)
        Me.GroupBox64.TabIndex = 10
        Me.GroupBox64.TabStop = False
        Me.GroupBox64.Text = "Tipo de Ecopatrón"
        '
        'RadGinUteroEcopatron1
        '
        Me.RadGinUteroEcopatron1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinUteroEcopatron1.Name = "RadGinUteroEcopatron1"
        Me.RadGinUteroEcopatron1.Size = New System.Drawing.Size(169, 17)
        Me.RadGinUteroEcopatron1.TabIndex = 0
        Me.RadGinUteroEcopatron1.Text = "Ecopatrón Homogéneo"
        '
        'RadGinUteroEcopatron2
        '
        Me.RadGinUteroEcopatron2.Location = New System.Drawing.Point(6, 41)
        Me.RadGinUteroEcopatron2.Name = "RadGinUteroEcopatron2"
        Me.RadGinUteroEcopatron2.Size = New System.Drawing.Size(169, 17)
        Me.RadGinUteroEcopatron2.TabIndex = 1
        Me.RadGinUteroEcopatron2.Text = "Ecopatrón Heterogeneo"
        '
        'GroupBox63
        '
        Me.GroupBox63.Controls.Add(Me.RadGinUteroInclinacion3)
        Me.GroupBox63.Controls.Add(Me.RadGinUteroInclinacion1)
        Me.GroupBox63.Controls.Add(Me.RadGinUteroInclinacion2)
        Me.GroupBox63.Location = New System.Drawing.Point(195, 6)
        Me.GroupBox63.Name = "GroupBox63"
        Me.GroupBox63.Size = New System.Drawing.Size(183, 87)
        Me.GroupBox63.TabIndex = 9
        Me.GroupBox63.TabStop = False
        Me.GroupBox63.Text = "Posición Lateral"
        '
        'RadGinUteroInclinacion3
        '
        Me.RadGinUteroInclinacion3.Location = New System.Drawing.Point(7, 63)
        Me.RadGinUteroInclinacion3.Name = "RadGinUteroInclinacion3"
        Me.RadGinUteroInclinacion3.Size = New System.Drawing.Size(170, 17)
        Me.RadGinUteroInclinacion3.TabIndex = 2
        Me.RadGinUteroInclinacion3.Text = "Lateralizado a la Derecha"
        '
        'RadGinUteroInclinacion1
        '
        Me.RadGinUteroInclinacion1.Location = New System.Drawing.Point(7, 19)
        Me.RadGinUteroInclinacion1.Name = "RadGinUteroInclinacion1"
        Me.RadGinUteroInclinacion1.Size = New System.Drawing.Size(170, 17)
        Me.RadGinUteroInclinacion1.TabIndex = 0
        Me.RadGinUteroInclinacion1.Text = "Lateralizado a la Izquierda"
        '
        'RadGinUteroInclinacion2
        '
        Me.RadGinUteroInclinacion2.Location = New System.Drawing.Point(7, 41)
        Me.RadGinUteroInclinacion2.Name = "RadGinUteroInclinacion2"
        Me.RadGinUteroInclinacion2.Size = New System.Drawing.Size(97, 16)
        Me.RadGinUteroInclinacion2.TabIndex = 1
        Me.RadGinUteroInclinacion2.Text = "Central"
        '
        'GroupBox60
        '
        Me.GroupBox60.Controls.Add(Me.RadGinUteroPosicion3)
        Me.GroupBox60.Controls.Add(Me.RadGinUteroPosicion1)
        Me.GroupBox60.Controls.Add(Me.RadGinUteroPosicion2)
        Me.GroupBox60.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox60.Name = "GroupBox60"
        Me.GroupBox60.Size = New System.Drawing.Size(181, 90)
        Me.GroupBox60.TabIndex = 8
        Me.GroupBox60.TabStop = False
        Me.GroupBox60.Text = "Posición Longitudinal"
        '
        'RadGinUteroPosicion3
        '
        Me.RadGinUteroPosicion3.Location = New System.Drawing.Point(6, 63)
        Me.RadGinUteroPosicion3.Name = "RadGinUteroPosicion3"
        Me.RadGinUteroPosicion3.Size = New System.Drawing.Size(97, 16)
        Me.RadGinUteroPosicion3.TabIndex = 2
        Me.RadGinUteroPosicion3.Text = "RVF"
        '
        'RadGinUteroPosicion1
        '
        Me.RadGinUteroPosicion1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinUteroPosicion1.Name = "RadGinUteroPosicion1"
        Me.RadGinUteroPosicion1.Size = New System.Drawing.Size(97, 16)
        Me.RadGinUteroPosicion1.TabIndex = 0
        Me.RadGinUteroPosicion1.Text = "AVF"
        '
        'RadGinUteroPosicion2
        '
        Me.RadGinUteroPosicion2.Location = New System.Drawing.Point(6, 41)
        Me.RadGinUteroPosicion2.Name = "RadGinUteroPosicion2"
        Me.RadGinUteroPosicion2.Size = New System.Drawing.Size(97, 16)
        Me.RadGinUteroPosicion2.TabIndex = 1
        Me.RadGinUteroPosicion2.Text = "Indiferente"
        '
        'TabGinOvarios
        '
        Me.TabGinOvarios.BackColor = System.Drawing.SystemColors.Control
        Me.TabGinOvarios.Controls.Add(Me.GroupBox70)
        Me.TabGinOvarios.Controls.Add(Me.GroupBox68)
        Me.TabGinOvarios.Location = New System.Drawing.Point(4, 22)
        Me.TabGinOvarios.Name = "TabGinOvarios"
        Me.TabGinOvarios.Size = New System.Drawing.Size(728, 249)
        Me.TabGinOvarios.TabIndex = 4
        Me.TabGinOvarios.Text = "Ovarios"
        '
        'GroupBox70
        '
        Me.GroupBox70.Controls.Add(Me.GroupBox71)
        Me.GroupBox70.Controls.Add(Me.RadGinOvarioIzquierdoTamano3)
        Me.GroupBox70.Controls.Add(Me.RadGinOvarioIzquierdoTamano1)
        Me.GroupBox70.Controls.Add(Me.RadGinOvarioIzquierdoTamano2)
        Me.GroupBox70.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox70.Name = "GroupBox70"
        Me.GroupBox70.Size = New System.Drawing.Size(354, 240)
        Me.GroupBox70.TabIndex = 10
        Me.GroupBox70.TabStop = False
        Me.GroupBox70.Text = "Ovario Izquierdo"
        '
        'GroupBox71
        '
        Me.GroupBox71.Controls.Add(Me.txtGinOvarioIzquierdoObservaciones4)
        Me.GroupBox71.Controls.Add(Me.txtGinOvarioIzquierdoObservaciones3)
        Me.GroupBox71.Controls.Add(Me.txtGinOvarioIzquierdoObservaciones2)
        Me.GroupBox71.Controls.Add(Me.txtGinOvarioIzquierdoObservaciones1)
        Me.GroupBox71.Location = New System.Drawing.Point(6, 97)
        Me.GroupBox71.Name = "GroupBox71"
        Me.GroupBox71.Size = New System.Drawing.Size(339, 137)
        Me.GroupBox71.TabIndex = 11
        Me.GroupBox71.TabStop = False
        Me.GroupBox71.Text = "Observaciones"
        '
        'txtGinOvarioIzquierdoObservaciones4
        '
        Me.txtGinOvarioIzquierdoObservaciones4.Location = New System.Drawing.Point(6, 97)
        Me.txtGinOvarioIzquierdoObservaciones4.MaxLength = 50
        Me.txtGinOvarioIzquierdoObservaciones4.Name = "txtGinOvarioIzquierdoObservaciones4"
        Me.txtGinOvarioIzquierdoObservaciones4.Size = New System.Drawing.Size(320, 20)
        Me.txtGinOvarioIzquierdoObservaciones4.TabIndex = 3
        '
        'txtGinOvarioIzquierdoObservaciones3
        '
        Me.txtGinOvarioIzquierdoObservaciones3.Location = New System.Drawing.Point(6, 71)
        Me.txtGinOvarioIzquierdoObservaciones3.MaxLength = 50
        Me.txtGinOvarioIzquierdoObservaciones3.Name = "txtGinOvarioIzquierdoObservaciones3"
        Me.txtGinOvarioIzquierdoObservaciones3.Size = New System.Drawing.Size(320, 20)
        Me.txtGinOvarioIzquierdoObservaciones3.TabIndex = 2
        '
        'txtGinOvarioIzquierdoObservaciones2
        '
        Me.txtGinOvarioIzquierdoObservaciones2.AcceptsReturn = True
        Me.txtGinOvarioIzquierdoObservaciones2.Location = New System.Drawing.Point(6, 45)
        Me.txtGinOvarioIzquierdoObservaciones2.MaxLength = 50
        Me.txtGinOvarioIzquierdoObservaciones2.Name = "txtGinOvarioIzquierdoObservaciones2"
        Me.txtGinOvarioIzquierdoObservaciones2.Size = New System.Drawing.Size(320, 20)
        Me.txtGinOvarioIzquierdoObservaciones2.TabIndex = 1
        '
        'txtGinOvarioIzquierdoObservaciones1
        '
        Me.txtGinOvarioIzquierdoObservaciones1.Location = New System.Drawing.Point(6, 19)
        Me.txtGinOvarioIzquierdoObservaciones1.MaxLength = 50
        Me.txtGinOvarioIzquierdoObservaciones1.Name = "txtGinOvarioIzquierdoObservaciones1"
        Me.txtGinOvarioIzquierdoObservaciones1.Size = New System.Drawing.Size(320, 20)
        Me.txtGinOvarioIzquierdoObservaciones1.TabIndex = 0
        '
        'RadGinOvarioIzquierdoTamano3
        '
        Me.RadGinOvarioIzquierdoTamano3.Location = New System.Drawing.Point(6, 65)
        Me.RadGinOvarioIzquierdoTamano3.Name = "RadGinOvarioIzquierdoTamano3"
        Me.RadGinOvarioIzquierdoTamano3.Size = New System.Drawing.Size(218, 17)
        Me.RadGinOvarioIzquierdoTamano3.TabIndex = 2
        Me.RadGinOvarioIzquierdoTamano3.Text = "Hipotrófico"
        '
        'RadGinOvarioIzquierdoTamano1
        '
        Me.RadGinOvarioIzquierdoTamano1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinOvarioIzquierdoTamano1.Name = "RadGinOvarioIzquierdoTamano1"
        Me.RadGinOvarioIzquierdoTamano1.Size = New System.Drawing.Size(164, 17)
        Me.RadGinOvarioIzquierdoTamano1.TabIndex = 0
        Me.RadGinOvarioIzquierdoTamano1.Text = "Forma y Tamaño Normal"
        '
        'RadGinOvarioIzquierdoTamano2
        '
        Me.RadGinOvarioIzquierdoTamano2.Location = New System.Drawing.Point(6, 42)
        Me.RadGinOvarioIzquierdoTamano2.Name = "RadGinOvarioIzquierdoTamano2"
        Me.RadGinOvarioIzquierdoTamano2.Size = New System.Drawing.Size(214, 17)
        Me.RadGinOvarioIzquierdoTamano2.TabIndex = 1
        Me.RadGinOvarioIzquierdoTamano2.Text = "Aumentado de Volumen"
        '
        'GroupBox68
        '
        Me.GroupBox68.Controls.Add(Me.GroupBox69)
        Me.GroupBox68.Controls.Add(Me.RadGinOvarioDerechoTamano3)
        Me.GroupBox68.Controls.Add(Me.RadGinOvarioDerechoTamano1)
        Me.GroupBox68.Controls.Add(Me.RadGinOvarioDerechoTamano2)
        Me.GroupBox68.Location = New System.Drawing.Point(372, 4)
        Me.GroupBox68.Name = "GroupBox68"
        Me.GroupBox68.Size = New System.Drawing.Size(348, 240)
        Me.GroupBox68.TabIndex = 9
        Me.GroupBox68.TabStop = False
        Me.GroupBox68.Text = "Ovario Derecho"
        '
        'GroupBox69
        '
        Me.GroupBox69.Controls.Add(Me.txtGinOvarioDerechoObservaciones4)
        Me.GroupBox69.Controls.Add(Me.txtGinOvarioDerechoObservaciones3)
        Me.GroupBox69.Controls.Add(Me.txtGinOvarioDerechoObservaciones2)
        Me.GroupBox69.Controls.Add(Me.txtGinOvarioDerechoObservaciones1)
        Me.GroupBox69.Location = New System.Drawing.Point(6, 97)
        Me.GroupBox69.Name = "GroupBox69"
        Me.GroupBox69.Size = New System.Drawing.Size(334, 137)
        Me.GroupBox69.TabIndex = 11
        Me.GroupBox69.TabStop = False
        Me.GroupBox69.Text = "Observaciones"
        '
        'txtGinOvarioDerechoObservaciones4
        '
        Me.txtGinOvarioDerechoObservaciones4.Location = New System.Drawing.Point(6, 97)
        Me.txtGinOvarioDerechoObservaciones4.MaxLength = 50
        Me.txtGinOvarioDerechoObservaciones4.Name = "txtGinOvarioDerechoObservaciones4"
        Me.txtGinOvarioDerechoObservaciones4.Size = New System.Drawing.Size(320, 20)
        Me.txtGinOvarioDerechoObservaciones4.TabIndex = 3
        '
        'txtGinOvarioDerechoObservaciones3
        '
        Me.txtGinOvarioDerechoObservaciones3.Location = New System.Drawing.Point(6, 71)
        Me.txtGinOvarioDerechoObservaciones3.MaxLength = 50
        Me.txtGinOvarioDerechoObservaciones3.Name = "txtGinOvarioDerechoObservaciones3"
        Me.txtGinOvarioDerechoObservaciones3.Size = New System.Drawing.Size(320, 20)
        Me.txtGinOvarioDerechoObservaciones3.TabIndex = 2
        '
        'txtGinOvarioDerechoObservaciones2
        '
        Me.txtGinOvarioDerechoObservaciones2.Location = New System.Drawing.Point(6, 45)
        Me.txtGinOvarioDerechoObservaciones2.MaxLength = 50
        Me.txtGinOvarioDerechoObservaciones2.Name = "txtGinOvarioDerechoObservaciones2"
        Me.txtGinOvarioDerechoObservaciones2.Size = New System.Drawing.Size(320, 20)
        Me.txtGinOvarioDerechoObservaciones2.TabIndex = 1
        '
        'txtGinOvarioDerechoObservaciones1
        '
        Me.txtGinOvarioDerechoObservaciones1.Location = New System.Drawing.Point(6, 19)
        Me.txtGinOvarioDerechoObservaciones1.MaxLength = 50
        Me.txtGinOvarioDerechoObservaciones1.Name = "txtGinOvarioDerechoObservaciones1"
        Me.txtGinOvarioDerechoObservaciones1.Size = New System.Drawing.Size(320, 20)
        Me.txtGinOvarioDerechoObservaciones1.TabIndex = 0
        '
        'RadGinOvarioDerechoTamano3
        '
        Me.RadGinOvarioDerechoTamano3.Location = New System.Drawing.Point(6, 65)
        Me.RadGinOvarioDerechoTamano3.Name = "RadGinOvarioDerechoTamano3"
        Me.RadGinOvarioDerechoTamano3.Size = New System.Drawing.Size(218, 17)
        Me.RadGinOvarioDerechoTamano3.TabIndex = 2
        Me.RadGinOvarioDerechoTamano3.Text = "Hipotrófico"
        '
        'RadGinOvarioDerechoTamano1
        '
        Me.RadGinOvarioDerechoTamano1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinOvarioDerechoTamano1.Name = "RadGinOvarioDerechoTamano1"
        Me.RadGinOvarioDerechoTamano1.Size = New System.Drawing.Size(164, 17)
        Me.RadGinOvarioDerechoTamano1.TabIndex = 0
        Me.RadGinOvarioDerechoTamano1.Text = "Forma y Tamaño Normal"
        '
        'RadGinOvarioDerechoTamano2
        '
        Me.RadGinOvarioDerechoTamano2.Location = New System.Drawing.Point(6, 42)
        Me.RadGinOvarioDerechoTamano2.Name = "RadGinOvarioDerechoTamano2"
        Me.RadGinOvarioDerechoTamano2.Size = New System.Drawing.Size(214, 17)
        Me.RadGinOvarioDerechoTamano2.TabIndex = 1
        Me.RadGinOvarioDerechoTamano2.Text = "Aumentado de Volumen"
        '
        'TabGinOtros
        '
        Me.TabGinOtros.BackColor = System.Drawing.SystemColors.Control
        Me.TabGinOtros.Controls.Add(Me.GroupBox73)
        Me.TabGinOtros.Controls.Add(Me.GroupBox72)
        Me.TabGinOtros.Location = New System.Drawing.Point(4, 22)
        Me.TabGinOtros.Name = "TabGinOtros"
        Me.TabGinOtros.Size = New System.Drawing.Size(728, 249)
        Me.TabGinOtros.TabIndex = 5
        Me.TabGinOtros.Text = "Otros"
        '
        'GroupBox73
        '
        Me.GroupBox73.Controls.Add(Me.txtGinOtrosObservaciones2)
        Me.GroupBox73.Controls.Add(Me.RadGinDouglas1)
        Me.GroupBox73.Controls.Add(Me.RadGinDouglas2)
        Me.GroupBox73.Location = New System.Drawing.Point(8, 147)
        Me.GroupBox73.Name = "GroupBox73"
        Me.GroupBox73.Size = New System.Drawing.Size(712, 99)
        Me.GroupBox73.TabIndex = 1
        Me.GroupBox73.TabStop = False
        Me.GroupBox73.Text = "Fondo de Saco de Douglas"
        '
        'txtGinOtrosObservaciones2
        '
        Me.txtGinOtrosObservaciones2.Location = New System.Drawing.Point(6, 65)
        Me.txtGinOtrosObservaciones2.MaxLength = 100
        Me.txtGinOtrosObservaciones2.Name = "txtGinOtrosObservaciones2"
        Me.txtGinOtrosObservaciones2.Size = New System.Drawing.Size(700, 20)
        Me.txtGinOtrosObservaciones2.TabIndex = 1
        '
        'RadGinDouglas1
        '
        Me.RadGinDouglas1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinDouglas1.Name = "RadGinDouglas1"
        Me.RadGinDouglas1.Size = New System.Drawing.Size(164, 17)
        Me.RadGinDouglas1.TabIndex = 3
        Me.RadGinDouglas1.Text = "Libre"
        '
        'RadGinDouglas2
        '
        Me.RadGinDouglas2.Location = New System.Drawing.Point(6, 42)
        Me.RadGinDouglas2.Name = "RadGinDouglas2"
        Me.RadGinDouglas2.Size = New System.Drawing.Size(214, 17)
        Me.RadGinDouglas2.TabIndex = 4
        Me.RadGinDouglas2.Text = "Nivel Líquido"
        '
        'GroupBox72
        '
        Me.GroupBox72.Controls.Add(Me.RadGinTrompas4)
        Me.GroupBox72.Controls.Add(Me.txtGinOtrosObservaciones1)
        Me.GroupBox72.Controls.Add(Me.RadGinTrompas3)
        Me.GroupBox72.Controls.Add(Me.RadGinTrompas1)
        Me.GroupBox72.Controls.Add(Me.RadGinTrompas2)
        Me.GroupBox72.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox72.Name = "GroupBox72"
        Me.GroupBox72.Size = New System.Drawing.Size(713, 138)
        Me.GroupBox72.TabIndex = 0
        Me.GroupBox72.TabStop = False
        Me.GroupBox72.Text = "Trompas Uterinas"
        '
        'RadGinTrompas4
        '
        Me.RadGinTrompas4.Location = New System.Drawing.Point(6, 88)
        Me.RadGinTrompas4.Name = "RadGinTrompas4"
        Me.RadGinTrompas4.Size = New System.Drawing.Size(218, 17)
        Me.RadGinTrompas4.TabIndex = 6
        Me.RadGinTrompas4.Text = "Trompas Distendidas Bilateralmente"
        '
        'txtGinOtrosObservaciones1
        '
        Me.txtGinOtrosObservaciones1.Location = New System.Drawing.Point(6, 111)
        Me.txtGinOtrosObservaciones1.MaxLength = 100
        Me.txtGinOtrosObservaciones1.Name = "txtGinOtrosObservaciones1"
        Me.txtGinOtrosObservaciones1.Size = New System.Drawing.Size(700, 20)
        Me.txtGinOtrosObservaciones1.TabIndex = 0
        '
        'RadGinTrompas3
        '
        Me.RadGinTrompas3.Location = New System.Drawing.Point(6, 65)
        Me.RadGinTrompas3.Name = "RadGinTrompas3"
        Me.RadGinTrompas3.Size = New System.Drawing.Size(218, 17)
        Me.RadGinTrompas3.TabIndex = 5
        Me.RadGinTrompas3.Text = "Trompa Derecha Distendida"
        '
        'RadGinTrompas1
        '
        Me.RadGinTrompas1.Location = New System.Drawing.Point(6, 19)
        Me.RadGinTrompas1.Name = "RadGinTrompas1"
        Me.RadGinTrompas1.Size = New System.Drawing.Size(164, 17)
        Me.RadGinTrompas1.TabIndex = 3
        Me.RadGinTrompas1.Text = "No visualizables (normal)"
        '
        'RadGinTrompas2
        '
        Me.RadGinTrompas2.Location = New System.Drawing.Point(6, 42)
        Me.RadGinTrompas2.Name = "RadGinTrompas2"
        Me.RadGinTrompas2.Size = New System.Drawing.Size(214, 17)
        Me.RadGinTrompas2.TabIndex = 4
        Me.RadGinTrompas2.Text = "Trompa Izquierda Distendida"
        '
        'TabIDxGin
        '
        Me.TabIDxGin.BackColor = System.Drawing.SystemColors.Control
        Me.TabIDxGin.Controls.Add(Me.GroupBox49)
        Me.TabIDxGin.Location = New System.Drawing.Point(4, 22)
        Me.TabIDxGin.Name = "TabIDxGin"
        Me.TabIDxGin.Size = New System.Drawing.Size(728, 249)
        Me.TabIDxGin.TabIndex = 2
        Me.TabIDxGin.Text = "Diagnósticos"
        '
        'GroupBox49
        '
        Me.GroupBox49.Controls.Add(Me.Label47)
        Me.GroupBox49.Controls.Add(Me.txtGinIDx4)
        Me.GroupBox49.Controls.Add(Me.Label45)
        Me.GroupBox49.Controls.Add(Me.txtGinIDx3)
        Me.GroupBox49.Controls.Add(Me.Label33)
        Me.GroupBox49.Controls.Add(Me.txtGinIDx2)
        Me.GroupBox49.Controls.Add(Me.Label32)
        Me.GroupBox49.Controls.Add(Me.txtGinIDx1)
        Me.GroupBox49.Location = New System.Drawing.Point(7, 13)
        Me.GroupBox49.Name = "GroupBox49"
        Me.GroupBox49.Size = New System.Drawing.Size(696, 184)
        Me.GroupBox49.TabIndex = 9
        Me.GroupBox49.TabStop = False
        Me.GroupBox49.Text = "Impresión Diagnóstica"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(6, 100)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(19, 13)
        Me.Label47.TabIndex = 8
        Me.Label47.Text = "4.-"
        '
        'txtGinIDx4
        '
        Me.txtGinIDx4.Location = New System.Drawing.Point(32, 97)
        Me.txtGinIDx4.MaxLength = 100
        Me.txtGinIDx4.Name = "txtGinIDx4"
        Me.txtGinIDx4.Size = New System.Drawing.Size(658, 20)
        Me.txtGinIDx4.TabIndex = 7
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(6, 74)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(19, 13)
        Me.Label45.TabIndex = 6
        Me.Label45.Text = "3.-"
        '
        'txtGinIDx3
        '
        Me.txtGinIDx3.Location = New System.Drawing.Point(32, 71)
        Me.txtGinIDx3.MaxLength = 100
        Me.txtGinIDx3.Name = "txtGinIDx3"
        Me.txtGinIDx3.Size = New System.Drawing.Size(658, 20)
        Me.txtGinIDx3.TabIndex = 5
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 48)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(19, 13)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "2.-"
        '
        'txtGinIDx2
        '
        Me.txtGinIDx2.Location = New System.Drawing.Point(32, 45)
        Me.txtGinIDx2.MaxLength = 100
        Me.txtGinIDx2.Name = "txtGinIDx2"
        Me.txtGinIDx2.Size = New System.Drawing.Size(658, 20)
        Me.txtGinIDx2.TabIndex = 3
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 22)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(19, 13)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "1.-"
        '
        'txtGinIDx1
        '
        Me.txtGinIDx1.AutoCompleteCustomSource.AddRange(New String() {"Estudio Ecosonográfico Ginecológico Normal"})
        Me.txtGinIDx1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtGinIDx1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtGinIDx1.Location = New System.Drawing.Point(32, 19)
        Me.txtGinIDx1.MaxLength = 100
        Me.txtGinIDx1.Name = "txtGinIDx1"
        Me.txtGinIDx1.Size = New System.Drawing.Size(658, 20)
        Me.txtGinIDx1.TabIndex = 1
        '
        'GroupBox44
        '
        Me.GroupBox44.Controls.Add(Me.labFURginecologico)
        Me.GroupBox44.Controls.Add(Me.txtParidadGinecologico)
        Me.GroupBox44.Controls.Add(Me.Label60)
        Me.GroupBox44.Controls.Add(Me.labEdadGinecologico)
        Me.GroupBox44.Controls.Add(Me.Label66)
        Me.GroupBox44.Controls.Add(Me.labNombreGinecologico)
        Me.GroupBox44.Controls.Add(Me.Label69)
        Me.GroupBox44.Controls.Add(Me.Label70)
        Me.GroupBox44.Controls.Add(Me.labFechaControlGinecologico)
        Me.GroupBox44.Controls.Add(Me.Label73)
        Me.GroupBox44.Controls.Add(Me.Label75)
        Me.GroupBox44.Controls.Add(Me.labDiaCicloGinecologico)
        Me.GroupBox44.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox44.Name = "GroupBox44"
        Me.GroupBox44.Size = New System.Drawing.Size(748, 76)
        Me.GroupBox44.TabIndex = 1
        Me.GroupBox44.TabStop = False
        Me.GroupBox44.Text = "Identificación"
        '
        'labFURginecologico
        '
        Me.labFURginecologico.BackColor = System.Drawing.SystemColors.Info
        Me.labFURginecologico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFURginecologico.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFURginecologico.Location = New System.Drawing.Point(368, 44)
        Me.labFURginecologico.Name = "labFURginecologico"
        Me.labFURginecologico.Size = New System.Drawing.Size(84, 23)
        Me.labFURginecologico.TabIndex = 9
        Me.labFURginecologico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtParidadGinecologico
        '
        Me.txtParidadGinecologico.Location = New System.Drawing.Point(464, 16)
        Me.txtParidadGinecologico.MaxLength = 30
        Me.txtParidadGinecologico.Name = "txtParidadGinecologico"
        Me.txtParidadGinecologico.Size = New System.Drawing.Size(272, 20)
        Me.txtParidadGinecologico.TabIndex = 5
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(416, 16)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(48, 23)
        Me.Label60.TabIndex = 4
        Me.Label60.Text = "Paridad:"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labEdadGinecologico
        '
        Me.labEdadGinecologico.BackColor = System.Drawing.SystemColors.Info
        Me.labEdadGinecologico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEdadGinecologico.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEdadGinecologico.Location = New System.Drawing.Point(368, 16)
        Me.labEdadGinecologico.Name = "labEdadGinecologico"
        Me.labEdadGinecologico.Size = New System.Drawing.Size(32, 23)
        Me.labEdadGinecologico.TabIndex = 3
        Me.labEdadGinecologico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(328, 16)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(40, 23)
        Me.Label66.TabIndex = 2
        Me.Label66.Text = "Edad:"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labNombreGinecologico
        '
        Me.labNombreGinecologico.BackColor = System.Drawing.SystemColors.Info
        Me.labNombreGinecologico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombreGinecologico.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombreGinecologico.Location = New System.Drawing.Point(56, 16)
        Me.labNombreGinecologico.Name = "labNombreGinecologico"
        Me.labNombreGinecologico.Size = New System.Drawing.Size(264, 23)
        Me.labNombreGinecologico.TabIndex = 1
        Me.labNombreGinecologico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(8, 16)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(48, 23)
        Me.Label69.TabIndex = 0
        Me.Label69.Text = "Nombre:"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(8, 44)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(80, 23)
        Me.Label70.TabIndex = 6
        Me.Label70.Text = "Fecha Control"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labFechaControlGinecologico
        '
        Me.labFechaControlGinecologico.BackColor = System.Drawing.SystemColors.Info
        Me.labFechaControlGinecologico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFechaControlGinecologico.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFechaControlGinecologico.Location = New System.Drawing.Point(92, 44)
        Me.labFechaControlGinecologico.Name = "labFechaControlGinecologico"
        Me.labFechaControlGinecologico.Size = New System.Drawing.Size(84, 23)
        Me.labFechaControlGinecologico.TabIndex = 7
        Me.labFechaControlGinecologico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(576, 48)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(88, 16)
        Me.Label73.TabIndex = 10
        Me.Label73.Text = "Día del Ciclo No."
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(328, 44)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(32, 23)
        Me.Label75.TabIndex = 8
        Me.Label75.Text = "FUR"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labDiaCicloGinecologico
        '
        Me.labDiaCicloGinecologico.BackColor = System.Drawing.SystemColors.Info
        Me.labDiaCicloGinecologico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labDiaCicloGinecologico.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labDiaCicloGinecologico.Location = New System.Drawing.Point(664, 44)
        Me.labDiaCicloGinecologico.Name = "labDiaCicloGinecologico"
        Me.labDiaCicloGinecologico.Size = New System.Drawing.Size(72, 23)
        Me.labDiaCicloGinecologico.TabIndex = 11
        Me.labDiaCicloGinecologico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(8, 4)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(240, 16)
        Me.Label77.TabIndex = 0
        Me.Label77.Text = "Ecografía Ginecológica"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelNuevoControl2y3erT
        '
        Me.PanelNuevoControl2y3erT.AutoScroll = True
        Me.PanelNuevoControl2y3erT.Controls.Add(Me.TabControl4)
        Me.PanelNuevoControl2y3erT.Controls.Add(Me.GroupBox10)
        Me.PanelNuevoControl2y3erT.Controls.Add(Me.Label46)
        Me.PanelNuevoControl2y3erT.Location = New System.Drawing.Point(4, 605)
        Me.PanelNuevoControl2y3erT.Name = "PanelNuevoControl2y3erT"
        Me.PanelNuevoControl2y3erT.Size = New System.Drawing.Size(933, 384)
        Me.PanelNuevoControl2y3erT.TabIndex = 3
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TabPageObstetricos)
        Me.TabControl4.Controls.Add(Me.TabPageBiometricos)
        Me.TabControl4.Controls.Add(Me.TabPageAnatomicos)
        Me.TabControl4.Controls.Add(Me.TabPageFuncionales)
        Me.TabControl4.Controls.Add(Me.TabPagePlacentarios)
        Me.TabControl4.Controls.Add(Me.TabPageNotas)
        Me.TabControl4.Controls.Add(Me.TabPageIDx)
        Me.TabControl4.Location = New System.Drawing.Point(32, 104)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(888, 260)
        Me.TabControl4.TabIndex = 2
        '
        'TabPageObstetricos
        '
        Me.TabPageObstetricos.Controls.Add(Me.GroupBox51)
        Me.TabPageObstetricos.Controls.Add(Me.GroupBox50)
        Me.TabPageObstetricos.Controls.Add(Me.GroupBox14)
        Me.TabPageObstetricos.Controls.Add(Me.GroupBox13)
        Me.TabPageObstetricos.Controls.Add(Me.GroupBox12)
        Me.TabPageObstetricos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageObstetricos.Name = "TabPageObstetricos"
        Me.TabPageObstetricos.Size = New System.Drawing.Size(880, 234)
        Me.TabPageObstetricos.TabIndex = 5
        Me.TabPageObstetricos.Text = "Datos Obstetricos"
        Me.TabPageObstetricos.UseVisualStyleBackColor = True
        '
        'GroupBox51
        '
        Me.GroupBox51.Controls.Add(Me.radFeto02)
        Me.GroupBox51.Controls.Add(Me.radFeto01)
        Me.GroupBox51.Location = New System.Drawing.Point(194, 3)
        Me.GroupBox51.Name = "GroupBox51"
        Me.GroupBox51.Size = New System.Drawing.Size(174, 64)
        Me.GroupBox51.TabIndex = 2
        Me.GroupBox51.TabStop = False
        Me.GroupBox51.Text = "Feto"
        '
        'radFeto02
        '
        Me.radFeto02.AutoSize = True
        Me.radFeto02.Location = New System.Drawing.Point(6, 44)
        Me.radFeto02.Name = "radFeto02"
        Me.radFeto02.Size = New System.Drawing.Size(64, 17)
        Me.radFeto02.TabIndex = 1
        Me.radFeto02.TabStop = True
        Me.radFeto02.Text = "Gemelar"
        Me.radFeto02.UseVisualStyleBackColor = True
        '
        'radFeto01
        '
        Me.radFeto01.AutoSize = True
        Me.radFeto01.Location = New System.Drawing.Point(6, 20)
        Me.radFeto01.Name = "radFeto01"
        Me.radFeto01.Size = New System.Drawing.Size(53, 17)
        Me.radFeto01.TabIndex = 0
        Me.radFeto01.TabStop = True
        Me.radFeto01.Text = "Unico"
        Me.radFeto01.UseVisualStyleBackColor = True
        '
        'GroupBox50
        '
        Me.GroupBox50.Controls.Add(Me.radEmbarazo02)
        Me.GroupBox50.Controls.Add(Me.radEmbarazo01)
        Me.GroupBox50.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox50.Name = "GroupBox50"
        Me.GroupBox50.Size = New System.Drawing.Size(184, 64)
        Me.GroupBox50.TabIndex = 0
        Me.GroupBox50.TabStop = False
        Me.GroupBox50.Text = "Embarazo"
        '
        'radEmbarazo02
        '
        Me.radEmbarazo02.AutoSize = True
        Me.radEmbarazo02.Location = New System.Drawing.Point(6, 44)
        Me.radEmbarazo02.Name = "radEmbarazo02"
        Me.radEmbarazo02.Size = New System.Drawing.Size(81, 17)
        Me.radEmbarazo02.TabIndex = 1
        Me.radEmbarazo02.TabStop = True
        Me.radEmbarazo02.Text = "Extrauterino"
        Me.radEmbarazo02.UseVisualStyleBackColor = True
        '
        'radEmbarazo01
        '
        Me.radEmbarazo01.AutoSize = True
        Me.radEmbarazo01.Location = New System.Drawing.Point(6, 20)
        Me.radEmbarazo01.Name = "radEmbarazo01"
        Me.radEmbarazo01.Size = New System.Drawing.Size(78, 17)
        Me.radEmbarazo01.TabIndex = 0
        Me.radEmbarazo01.TabStop = True
        Me.radEmbarazo01.Text = "Intrauterino"
        Me.radEmbarazo01.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.radPosicion8)
        Me.GroupBox14.Controls.Add(Me.radPosicion7)
        Me.GroupBox14.Controls.Add(Me.radPosicion6)
        Me.GroupBox14.Controls.Add(Me.radPosicion5)
        Me.GroupBox14.Controls.Add(Me.radPosicion4)
        Me.GroupBox14.Controls.Add(Me.radPosicion3)
        Me.GroupBox14.Controls.Add(Me.radPosicion2)
        Me.GroupBox14.Controls.Add(Me.radPosicion1)
        Me.GroupBox14.Location = New System.Drawing.Point(374, 3)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(310, 161)
        Me.GroupBox14.TabIndex = 4
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Posición"
        '
        'radPosicion8
        '
        Me.radPosicion8.AutoSize = True
        Me.radPosicion8.Location = New System.Drawing.Point(158, 94)
        Me.radPosicion8.Name = "radPosicion8"
        Me.radPosicion8.Size = New System.Drawing.Size(110, 17)
        Me.radPosicion8.TabIndex = 7
        Me.radPosicion8.TabStop = True
        Me.radPosicion8.Text = "Derecha Posterior"
        Me.radPosicion8.UseVisualStyleBackColor = True
        '
        'radPosicion7
        '
        Me.radPosicion7.AutoSize = True
        Me.radPosicion7.Location = New System.Drawing.Point(158, 68)
        Me.radPosicion7.Name = "radPosicion7"
        Me.radPosicion7.Size = New System.Drawing.Size(122, 17)
        Me.radPosicion7.TabIndex = 6
        Me.radPosicion7.TabStop = True
        Me.radPosicion7.Text = "Derecha Transversa"
        Me.radPosicion7.UseVisualStyleBackColor = True
        '
        'radPosicion6
        '
        Me.radPosicion6.AutoSize = True
        Me.radPosicion6.Location = New System.Drawing.Point(8, 94)
        Me.radPosicion6.Name = "radPosicion6"
        Me.radPosicion6.Size = New System.Drawing.Size(112, 17)
        Me.radPosicion6.TabIndex = 3
        Me.radPosicion6.TabStop = True
        Me.radPosicion6.Text = "Izquierda Posterior"
        Me.radPosicion6.UseVisualStyleBackColor = True
        '
        'radPosicion5
        '
        Me.radPosicion5.AutoSize = True
        Me.radPosicion5.Location = New System.Drawing.Point(8, 68)
        Me.radPosicion5.Name = "radPosicion5"
        Me.radPosicion5.Size = New System.Drawing.Size(124, 17)
        Me.radPosicion5.TabIndex = 2
        Me.radPosicion5.TabStop = True
        Me.radPosicion5.Text = "Izquierda Transversa"
        Me.radPosicion5.UseVisualStyleBackColor = True
        '
        'radPosicion4
        '
        Me.radPosicion4.Location = New System.Drawing.Point(8, 40)
        Me.radPosicion4.Name = "radPosicion4"
        Me.radPosicion4.Size = New System.Drawing.Size(128, 24)
        Me.radPosicion4.TabIndex = 1
        Me.radPosicion4.Text = "Izquierda Anterior"
        '
        'radPosicion3
        '
        Me.radPosicion3.Location = New System.Drawing.Point(158, 40)
        Me.radPosicion3.Name = "radPosicion3"
        Me.radPosicion3.Size = New System.Drawing.Size(128, 24)
        Me.radPosicion3.TabIndex = 5
        Me.radPosicion3.Text = "Derecha Anterior"
        '
        'radPosicion2
        '
        Me.radPosicion2.Location = New System.Drawing.Point(158, 16)
        Me.radPosicion2.Name = "radPosicion2"
        Me.radPosicion2.Size = New System.Drawing.Size(104, 24)
        Me.radPosicion2.TabIndex = 4
        Me.radPosicion2.Text = "Dorso Posterior"
        '
        'radPosicion1
        '
        Me.radPosicion1.Location = New System.Drawing.Point(8, 16)
        Me.radPosicion1.Name = "radPosicion1"
        Me.radPosicion1.Size = New System.Drawing.Size(104, 24)
        Me.radPosicion1.TabIndex = 0
        Me.radPosicion1.Text = "Dorso Anterior"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.radSituacion3)
        Me.GroupBox13.Controls.Add(Me.radSituacion2)
        Me.GroupBox13.Controls.Add(Me.radSituacion1)
        Me.GroupBox13.Location = New System.Drawing.Point(4, 73)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(184, 91)
        Me.GroupBox13.TabIndex = 1
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Situación"
        '
        'radSituacion3
        '
        Me.radSituacion3.Location = New System.Drawing.Point(8, 64)
        Me.radSituacion3.Name = "radSituacion3"
        Me.radSituacion3.Size = New System.Drawing.Size(144, 24)
        Me.radSituacion3.TabIndex = 2
        Me.radSituacion3.Text = "Transversa"
        '
        'radSituacion2
        '
        Me.radSituacion2.Location = New System.Drawing.Point(8, 40)
        Me.radSituacion2.Name = "radSituacion2"
        Me.radSituacion2.Size = New System.Drawing.Size(104, 24)
        Me.radSituacion2.TabIndex = 1
        Me.radSituacion2.Text = "Oblícua"
        '
        'radSituacion1
        '
        Me.radSituacion1.Location = New System.Drawing.Point(8, 16)
        Me.radSituacion1.Name = "radSituacion1"
        Me.radSituacion1.Size = New System.Drawing.Size(104, 24)
        Me.radSituacion1.TabIndex = 0
        Me.radSituacion1.Text = "Longitudinal"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.radpresentacion3)
        Me.GroupBox12.Controls.Add(Me.radPresentacion2)
        Me.GroupBox12.Controls.Add(Me.radPresentacion1)
        Me.GroupBox12.Location = New System.Drawing.Point(194, 73)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(174, 91)
        Me.GroupBox12.TabIndex = 3
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Presentación"
        '
        'radpresentacion3
        '
        Me.radpresentacion3.Location = New System.Drawing.Point(8, 64)
        Me.radpresentacion3.Name = "radpresentacion3"
        Me.radpresentacion3.Size = New System.Drawing.Size(144, 24)
        Me.radpresentacion3.TabIndex = 2
        Me.radpresentacion3.Text = "No tiene Sit.Transversa"
        '
        'radPresentacion2
        '
        Me.radPresentacion2.Location = New System.Drawing.Point(8, 40)
        Me.radPresentacion2.Name = "radPresentacion2"
        Me.radPresentacion2.Size = New System.Drawing.Size(104, 24)
        Me.radPresentacion2.TabIndex = 1
        Me.radPresentacion2.Text = "Podálica"
        '
        'radPresentacion1
        '
        Me.radPresentacion1.Location = New System.Drawing.Point(8, 16)
        Me.radPresentacion1.Name = "radPresentacion1"
        Me.radPresentacion1.Size = New System.Drawing.Size(104, 24)
        Me.radPresentacion1.TabIndex = 0
        Me.radPresentacion1.Text = "Cefálica"
        '
        'TabPageBiometricos
        '
        Me.TabPageBiometricos.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageBiometricos.Controls.Add(Me.chkMedidasUsuales)
        Me.TabPageBiometricos.Controls.Add(Me.lab2y3egxFem)
        Me.TabPageBiometricos.Controls.Add(Me.lab2y3egxCA)
        Me.TabPageBiometricos.Controls.Add(Me.lab2y3egxCC)
        Me.TabPageBiometricos.Controls.Add(Me.lab2y3egxDBP)
        Me.TabPageBiometricos.Controls.Add(Me.botCalculaCC)
        Me.TabPageBiometricos.Controls.Add(Me.txtTalla)
        Me.TabPageBiometricos.Controls.Add(Me.Label128)
        Me.TabPageBiometricos.Controls.Add(Me.Label129)
        Me.TabPageBiometricos.Controls.Add(Me.txtBPF)
        Me.TabPageBiometricos.Controls.Add(Me.Label130)
        Me.TabPageBiometricos.Controls.Add(Me.txtNOPH)
        Me.TabPageBiometricos.Controls.Add(Me.Label131)
        Me.TabPageBiometricos.Controls.Add(Me.txtNODF)
        Me.TabPageBiometricos.Controls.Add(Me.Label98)
        Me.TabPageBiometricos.Controls.Add(Me.Label99)
        Me.TabPageBiometricos.Controls.Add(Me.txtUlna)
        Me.TabPageBiometricos.Controls.Add(Me.txtNOPT)
        Me.TabPageBiometricos.Controls.Add(Me.Label109)
        Me.TabPageBiometricos.Controls.Add(Me.txtHumero)
        Me.TabPageBiometricos.Controls.Add(Me.Label110)
        Me.TabPageBiometricos.Controls.Add(Me.txtPeso)
        Me.TabPageBiometricos.Controls.Add(Me.txtCA)
        Me.TabPageBiometricos.Controls.Add(Me.Label96)
        Me.TabPageBiometricos.Controls.Add(Me.txtTibia)
        Me.TabPageBiometricos.Controls.Add(Me.Label97)
        Me.TabPageBiometricos.Controls.Add(Me.txtPN)
        Me.TabPageBiometricos.Controls.Add(Me.Label93)
        Me.TabPageBiometricos.Controls.Add(Me.txtIOI)
        Me.TabPageBiometricos.Controls.Add(Me.Label94)
        Me.TabPageBiometricos.Controls.Add(Me.txtIOE)
        Me.TabPageBiometricos.Controls.Add(Me.Label95)
        Me.TabPageBiometricos.Controls.Add(Me.txtAtrio)
        Me.TabPageBiometricos.Controls.Add(Me.Label92)
        Me.TabPageBiometricos.Controls.Add(Me.txtTCer)
        Me.TabPageBiometricos.Controls.Add(Me.Label91)
        Me.TabPageBiometricos.Controls.Add(Me.txtCC)
        Me.TabPageBiometricos.Controls.Add(Me.Label71)
        Me.TabPageBiometricos.Controls.Add(Me.txtTransAbdomen)
        Me.TabPageBiometricos.Controls.Add(Me.txtFemur)
        Me.TabPageBiometricos.Controls.Add(Me.Label56)
        Me.TabPageBiometricos.Controls.Add(Me.txtSacro)
        Me.TabPageBiometricos.Controls.Add(Me.Label55)
        Me.TabPageBiometricos.Controls.Add(Me.txtAorta)
        Me.TabPageBiometricos.Controls.Add(Me.Label53)
        Me.TabPageBiometricos.Controls.Add(Me.txtAPC)
        Me.TabPageBiometricos.Controls.Add(Me.Label49)
        Me.TabPageBiometricos.Controls.Add(Me.txtAPT)
        Me.TabPageBiometricos.Controls.Add(Me.Label48)
        Me.TabPageBiometricos.Controls.Add(Me.txtDOF)
        Me.TabPageBiometricos.Controls.Add(Me.Label37)
        Me.TabPageBiometricos.Controls.Add(Me.txtDBP)
        Me.TabPageBiometricos.Controls.Add(Me.Label34)
        Me.TabPageBiometricos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageBiometricos.Name = "TabPageBiometricos"
        Me.TabPageBiometricos.Size = New System.Drawing.Size(880, 234)
        Me.TabPageBiometricos.TabIndex = 1
        Me.TabPageBiometricos.Text = "Datos Biométricos"
        Me.TabPageBiometricos.Visible = False
        '
        'lab2y3egxFem
        '
        Me.lab2y3egxFem.BackColor = System.Drawing.SystemColors.Info
        Me.lab2y3egxFem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab2y3egxFem.Location = New System.Drawing.Point(518, 88)
        Me.lab2y3egxFem.Name = "lab2y3egxFem"
        Me.lab2y3egxFem.Size = New System.Drawing.Size(50, 18)
        Me.lab2y3egxFem.TabIndex = 78
        Me.lab2y3egxFem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab2y3egxCA
        '
        Me.lab2y3egxCA.BackColor = System.Drawing.SystemColors.Info
        Me.lab2y3egxCA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab2y3egxCA.Location = New System.Drawing.Point(518, 62)
        Me.lab2y3egxCA.Name = "lab2y3egxCA"
        Me.lab2y3egxCA.Size = New System.Drawing.Size(50, 18)
        Me.lab2y3egxCA.TabIndex = 77
        Me.lab2y3egxCA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab2y3egxCC
        '
        Me.lab2y3egxCC.BackColor = System.Drawing.SystemColors.Info
        Me.lab2y3egxCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab2y3egxCC.Location = New System.Drawing.Point(146, 60)
        Me.lab2y3egxCC.Name = "lab2y3egxCC"
        Me.lab2y3egxCC.Size = New System.Drawing.Size(50, 18)
        Me.lab2y3egxCC.TabIndex = 76
        Me.lab2y3egxCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab2y3egxDBP
        '
        Me.lab2y3egxDBP.BackColor = System.Drawing.SystemColors.Info
        Me.lab2y3egxDBP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lab2y3egxDBP.Location = New System.Drawing.Point(146, 8)
        Me.lab2y3egxDBP.Name = "lab2y3egxDBP"
        Me.lab2y3egxDBP.Size = New System.Drawing.Size(50, 18)
        Me.lab2y3egxDBP.TabIndex = 75
        Me.lab2y3egxDBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botCalculaCC
        '
        Me.botCalculaCC.Location = New System.Drawing.Point(9, 58)
        Me.botCalculaCC.Name = "botCalculaCC"
        Me.botCalculaCC.Size = New System.Drawing.Size(97, 23)
        Me.botCalculaCC.TabIndex = 74
        Me.botCalculaCC.Text = "C.Cefálica(mm)"
        Me.botCalculaCC.UseVisualStyleBackColor = True
        '
        'txtTalla
        '
        Me.txtTalla.BackColor = System.Drawing.SystemColors.Info
        Me.txtTalla.Location = New System.Drawing.Point(835, 87)
        Me.txtTalla.MaxLength = 2
        Me.txtTalla.Name = "txtTalla"
        Me.txtTalla.ReadOnly = True
        Me.txtTalla.Size = New System.Drawing.Size(32, 20)
        Me.txtTalla.TabIndex = 24
        Me.txtTalla.TabStop = False
        '
        'Label128
        '
        Me.Label128.Location = New System.Drawing.Point(735, 59)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(98, 23)
        Me.Label128.TabIndex = 70
        Me.Label128.Text = "Peso(gr)"
        Me.Label128.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label129
        '
        Me.Label129.Location = New System.Drawing.Point(736, 33)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(97, 23)
        Me.Label129.TabIndex = 64
        Me.Label129.Text = "BPF(mm)"
        Me.Label129.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBPF
        '
        Me.txtBPF.BackColor = System.Drawing.SystemColors.Info
        Me.txtBPF.Location = New System.Drawing.Point(835, 35)
        Me.txtBPF.MaxLength = 3
        Me.txtBPF.Name = "txtBPF"
        Me.txtBPF.ReadOnly = True
        Me.txtBPF.Size = New System.Drawing.Size(32, 20)
        Me.txtBPF.TabIndex = 22
        Me.txtBPF.TabStop = False
        '
        'Label130
        '
        Me.Label130.Location = New System.Drawing.Point(736, 85)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(97, 23)
        Me.Label130.TabIndex = 68
        Me.Label130.Text = "Talla(cm)"
        Me.Label130.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNOPH
        '
        Me.txtNOPH.Location = New System.Drawing.Point(835, 9)
        Me.txtNOPH.MaxLength = 3
        Me.txtNOPH.Name = "txtNOPH"
        Me.txtNOPH.Size = New System.Drawing.Size(32, 20)
        Me.txtNOPH.TabIndex = 21
        '
        'Label131
        '
        Me.Label131.Location = New System.Drawing.Point(733, 7)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(100, 23)
        Me.Label131.TabIndex = 66
        Me.Label131.Text = "NOP.Húmero(mm)"
        Me.Label131.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNODF
        '
        Me.txtNODF.Location = New System.Drawing.Point(684, 86)
        Me.txtNODF.MaxLength = 3
        Me.txtNODF.Name = "txtNODF"
        Me.txtNODF.Size = New System.Drawing.Size(32, 20)
        Me.txtNODF.TabIndex = 18
        '
        'Label98
        '
        Me.Label98.Location = New System.Drawing.Point(584, 84)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(98, 23)
        Me.Label98.TabIndex = 62
        Me.Label98.Text = "NOD.Fémur(mm)"
        Me.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label99
        '
        Me.Label99.Location = New System.Drawing.Point(578, 32)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(104, 23)
        Me.Label99.TabIndex = 56
        Me.Label99.Text = "Ulna(mm)"
        Me.Label99.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUlna
        '
        Me.txtUlna.Location = New System.Drawing.Point(684, 34)
        Me.txtUlna.MaxLength = 3
        Me.txtUlna.Name = "txtUlna"
        Me.txtUlna.Size = New System.Drawing.Size(32, 20)
        Me.txtUlna.TabIndex = 16
        '
        'txtNOPT
        '
        Me.txtNOPT.Location = New System.Drawing.Point(684, 112)
        Me.txtNOPT.MaxLength = 3
        Me.txtNOPT.Name = "txtNOPT"
        Me.txtNOPT.Size = New System.Drawing.Size(32, 20)
        Me.txtNOPT.TabIndex = 19
        '
        'Label109
        '
        Me.Label109.Location = New System.Drawing.Point(578, 110)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(104, 23)
        Me.Label109.TabIndex = 60
        Me.Label109.Text = "NOP.Tibia(mm)"
        Me.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHumero
        '
        Me.txtHumero.Location = New System.Drawing.Point(684, 8)
        Me.txtHumero.MaxLength = 3
        Me.txtHumero.Name = "txtHumero"
        Me.txtHumero.Size = New System.Drawing.Size(32, 20)
        Me.txtHumero.TabIndex = 15
        '
        'Label110
        '
        Me.Label110.Location = New System.Drawing.Point(582, 6)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(100, 23)
        Me.Label110.TabIndex = 58
        Me.Label110.Text = "Húmero(mm)"
        Me.Label110.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.SystemColors.Info
        Me.txtPeso.Location = New System.Drawing.Point(835, 61)
        Me.txtPeso.MaxLength = 4
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.ReadOnly = True
        Me.txtPeso.Size = New System.Drawing.Size(32, 20)
        Me.txtPeso.TabIndex = 23
        Me.txtPeso.TabStop = False
        '
        'txtCA
        '
        Me.txtCA.Location = New System.Drawing.Point(480, 62)
        Me.txtCA.MaxLength = 3
        Me.txtCA.Name = "txtCA"
        Me.txtCA.Size = New System.Drawing.Size(32, 20)
        Me.txtCA.TabIndex = 12
        '
        'Label96
        '
        Me.Label96.Location = New System.Drawing.Point(377, 60)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(101, 23)
        Me.Label96.TabIndex = 53
        Me.Label96.Text = "C.Abdominal(mm)"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTibia
        '
        Me.txtTibia.Location = New System.Drawing.Point(480, 114)
        Me.txtTibia.MaxLength = 3
        Me.txtTibia.Name = "txtTibia"
        Me.txtTibia.Size = New System.Drawing.Size(32, 20)
        Me.txtTibia.TabIndex = 14
        '
        'Label97
        '
        Me.Label97.Location = New System.Drawing.Point(380, 86)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(98, 23)
        Me.Label97.TabIndex = 51
        Me.Label97.Text = "Fémur(mm)"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPN
        '
        Me.txtPN.Location = New System.Drawing.Point(305, 59)
        Me.txtPN.MaxLength = 3
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(32, 20)
        Me.txtPN.TabIndex = 7
        '
        'Label93
        '
        Me.Label93.Location = New System.Drawing.Point(206, 57)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(97, 23)
        Me.Label93.TabIndex = 49
        Me.Label93.Text = "P.Nucal(mm)"
        Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIOI
        '
        Me.txtIOI.Location = New System.Drawing.Point(305, 33)
        Me.txtIOI.MaxLength = 3
        Me.txtIOI.Name = "txtIOI"
        Me.txtIOI.Size = New System.Drawing.Size(32, 20)
        Me.txtIOI.TabIndex = 6
        '
        'Label94
        '
        Me.Label94.Location = New System.Drawing.Point(208, 31)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(95, 23)
        Me.Label94.TabIndex = 47
        Me.Label94.Text = "IO.Interno(mm)"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIOE
        '
        Me.txtIOE.Location = New System.Drawing.Point(305, 7)
        Me.txtIOE.MaxLength = 3
        Me.txtIOE.Name = "txtIOE"
        Me.txtIOE.Size = New System.Drawing.Size(32, 20)
        Me.txtIOE.TabIndex = 5
        '
        'Label95
        '
        Me.Label95.Location = New System.Drawing.Point(203, 5)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(100, 23)
        Me.Label95.TabIndex = 45
        Me.Label95.Text = "IO.Externo(mm)"
        Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAtrio
        '
        Me.txtAtrio.Location = New System.Drawing.Point(108, 112)
        Me.txtAtrio.MaxLength = 3
        Me.txtAtrio.Name = "txtAtrio"
        Me.txtAtrio.Size = New System.Drawing.Size(32, 20)
        Me.txtAtrio.TabIndex = 4
        '
        'Label92
        '
        Me.Label92.Location = New System.Drawing.Point(3, 110)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(103, 23)
        Me.Label92.TabIndex = 43
        Me.Label92.Text = "Atrio(mm)"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTCer
        '
        Me.txtTCer.Location = New System.Drawing.Point(108, 86)
        Me.txtTCer.MaxLength = 3
        Me.txtTCer.Name = "txtTCer"
        Me.txtTCer.Size = New System.Drawing.Size(32, 20)
        Me.txtTCer.TabIndex = 3
        '
        'Label91
        '
        Me.Label91.Location = New System.Drawing.Point(3, 84)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(103, 23)
        Me.Label91.TabIndex = 41
        Me.Label91.Text = "T.Cerebelo(mm)"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(108, 60)
        Me.txtCC.MaxLength = 3
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(32, 20)
        Me.txtCC.TabIndex = 2
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(374, 34)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(104, 23)
        Me.Label71.TabIndex = 10
        Me.Label71.Text = "T. Abdomen(mm)"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransAbdomen
        '
        Me.txtTransAbdomen.Location = New System.Drawing.Point(480, 36)
        Me.txtTransAbdomen.MaxLength = 3
        Me.txtTransAbdomen.Name = "txtTransAbdomen"
        Me.txtTransAbdomen.Size = New System.Drawing.Size(32, 20)
        Me.txtTransAbdomen.TabIndex = 11
        '
        'txtFemur
        '
        Me.txtFemur.Location = New System.Drawing.Point(480, 88)
        Me.txtFemur.MaxLength = 3
        Me.txtFemur.Name = "txtFemur"
        Me.txtFemur.Size = New System.Drawing.Size(32, 20)
        Me.txtFemur.TabIndex = 13
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(374, 112)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(104, 23)
        Me.Label56.TabIndex = 18
        Me.Label56.Text = "Tibia(mm)"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSacro
        '
        Me.txtSacro.Location = New System.Drawing.Point(684, 60)
        Me.txtSacro.MaxLength = 3
        Me.txtSacro.Name = "txtSacro"
        Me.txtSacro.Size = New System.Drawing.Size(32, 20)
        Me.txtSacro.TabIndex = 17
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(579, 58)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(103, 23)
        Me.Label55.TabIndex = 16
        Me.Label55.Text = "Sacro(mm)"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAorta
        '
        Me.txtAorta.Location = New System.Drawing.Point(480, 10)
        Me.txtAorta.MaxLength = 3
        Me.txtAorta.Name = "txtAorta"
        Me.txtAorta.Size = New System.Drawing.Size(32, 20)
        Me.txtAorta.TabIndex = 10
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(378, 8)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(100, 23)
        Me.Label53.TabIndex = 12
        Me.Label53.Text = "Aorta(mm)"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAPC
        '
        Me.txtAPC.Location = New System.Drawing.Point(305, 85)
        Me.txtAPC.MaxLength = 3
        Me.txtAPC.Name = "txtAPC"
        Me.txtAPC.Size = New System.Drawing.Size(32, 20)
        Me.txtAPC.TabIndex = 8
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(200, 83)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(103, 23)
        Me.Label49.TabIndex = 6
        Me.Label49.Text = "AP.Cardíaco(mm)"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAPT
        '
        Me.txtAPT.Location = New System.Drawing.Point(305, 111)
        Me.txtAPT.MaxLength = 3
        Me.txtAPT.Name = "txtAPT"
        Me.txtAPT.Size = New System.Drawing.Size(32, 20)
        Me.txtAPT.TabIndex = 9
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(205, 109)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(98, 23)
        Me.Label48.TabIndex = 4
        Me.Label48.Text = "AP.Tórax(mm)"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDOF
        '
        Me.txtDOF.Location = New System.Drawing.Point(108, 34)
        Me.txtDOF.MaxLength = 3
        Me.txtDOF.Name = "txtDOF"
        Me.txtDOF.Size = New System.Drawing.Size(32, 20)
        Me.txtDOF.TabIndex = 1
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(0, 32)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(106, 23)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "O.Frontal(mm)"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDBP
        '
        Me.txtDBP.Location = New System.Drawing.Point(108, 8)
        Me.txtDBP.MaxLength = 3
        Me.txtDBP.Name = "txtDBP"
        Me.txtDBP.Size = New System.Drawing.Size(32, 20)
        Me.txtDBP.TabIndex = 0
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(6, 6)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(100, 23)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Biparietal(mm)"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPageAnatomicos
        '
        Me.TabPageAnatomicos.Controls.Add(Me.GroupBox53)
        Me.TabPageAnatomicos.Controls.Add(Me.GroupBox18)
        Me.TabPageAnatomicos.Controls.Add(Me.GroupBox52)
        Me.TabPageAnatomicos.Controls.Add(Me.GroupBox22)
        Me.TabPageAnatomicos.Controls.Add(Me.GroupBox21)
        Me.TabPageAnatomicos.Controls.Add(Me.GroupBox20)
        Me.TabPageAnatomicos.Controls.Add(Me.GroupBox19)
        Me.TabPageAnatomicos.Controls.Add(Me.GroupBox16)
        Me.TabPageAnatomicos.Controls.Add(Me.GroupBox15)
        Me.TabPageAnatomicos.Controls.Add(Me.GroupBox17)
        Me.TabPageAnatomicos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAnatomicos.Name = "TabPageAnatomicos"
        Me.TabPageAnatomicos.Size = New System.Drawing.Size(880, 234)
        Me.TabPageAnatomicos.TabIndex = 0
        Me.TabPageAnatomicos.Text = "Datos Anatómicos"
        Me.TabPageAnatomicos.UseVisualStyleBackColor = True
        '
        'GroupBox53
        '
        Me.GroupBox53.Controls.Add(Me.radSexo2)
        Me.GroupBox53.Controls.Add(Me.radSexo1)
        Me.GroupBox53.Location = New System.Drawing.Point(547, 90)
        Me.GroupBox53.Name = "GroupBox53"
        Me.GroupBox53.Size = New System.Drawing.Size(130, 80)
        Me.GroupBox53.TabIndex = 9
        Me.GroupBox53.TabStop = False
        Me.GroupBox53.Text = "Sexo"
        '
        'radSexo2
        '
        Me.radSexo2.Location = New System.Drawing.Point(5, 40)
        Me.radSexo2.Name = "radSexo2"
        Me.radSexo2.Size = New System.Drawing.Size(112, 16)
        Me.radSexo2.TabIndex = 1
        Me.radSexo2.Text = "Femenino"
        '
        'radSexo1
        '
        Me.radSexo1.Location = New System.Drawing.Point(5, 20)
        Me.radSexo1.Name = "radSexo1"
        Me.radSexo1.Size = New System.Drawing.Size(112, 16)
        Me.radSexo1.TabIndex = 0
        Me.radSexo1.Text = "Masculino"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.radTorax2)
        Me.GroupBox18.Controls.Add(Me.radTorax1)
        Me.GroupBox18.Location = New System.Drawing.Point(275, 90)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(130, 80)
        Me.GroupBox18.TabIndex = 5
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Tórax"
        '
        'radTorax2
        '
        Me.radTorax2.Location = New System.Drawing.Point(5, 40)
        Me.radTorax2.Name = "radTorax2"
        Me.radTorax2.Size = New System.Drawing.Size(64, 16)
        Me.radTorax2.TabIndex = 1
        Me.radTorax2.Text = "Anormal"
        '
        'radTorax1
        '
        Me.radTorax1.Location = New System.Drawing.Point(5, 20)
        Me.radTorax1.Name = "radTorax1"
        Me.radTorax1.Size = New System.Drawing.Size(64, 16)
        Me.radTorax1.TabIndex = 0
        Me.radTorax1.Text = "Normal"
        '
        'GroupBox52
        '
        Me.GroupBox52.Controls.Add(Me.radRostro2)
        Me.GroupBox52.Controls.Add(Me.radRostro1)
        Me.GroupBox52.Location = New System.Drawing.Point(139, 4)
        Me.GroupBox52.Name = "GroupBox52"
        Me.GroupBox52.Size = New System.Drawing.Size(130, 80)
        Me.GroupBox52.TabIndex = 2
        Me.GroupBox52.TabStop = False
        Me.GroupBox52.Text = "Rostro"
        '
        'radRostro2
        '
        Me.radRostro2.Location = New System.Drawing.Point(5, 40)
        Me.radRostro2.Name = "radRostro2"
        Me.radRostro2.Size = New System.Drawing.Size(112, 16)
        Me.radRostro2.TabIndex = 1
        Me.radRostro2.Text = "Anormal"
        '
        'radRostro1
        '
        Me.radRostro1.Location = New System.Drawing.Point(5, 20)
        Me.radRostro1.Name = "radRostro1"
        Me.radRostro1.Size = New System.Drawing.Size(112, 16)
        Me.radRostro1.TabIndex = 0
        Me.radRostro1.Text = "Sin Fisuras"
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.radExtremidades2)
        Me.GroupBox22.Controls.Add(Me.radExtremidades1)
        Me.GroupBox22.Location = New System.Drawing.Point(275, 4)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(130, 80)
        Me.GroupBox22.TabIndex = 4
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Extremidades"
        '
        'radExtremidades2
        '
        Me.radExtremidades2.Location = New System.Drawing.Point(5, 40)
        Me.radExtremidades2.Name = "radExtremidades2"
        Me.radExtremidades2.Size = New System.Drawing.Size(96, 16)
        Me.radExtremidades2.TabIndex = 1
        Me.radExtremidades2.Text = "Anormales"
        '
        'radExtremidades1
        '
        Me.radExtremidades1.Location = New System.Drawing.Point(5, 20)
        Me.radExtremidades1.Name = "radExtremidades1"
        Me.radExtremidades1.Size = New System.Drawing.Size(112, 16)
        Me.radExtremidades1.TabIndex = 0
        Me.radExtremidades1.Text = "Completas"
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.radRiñones2)
        Me.GroupBox21.Controls.Add(Me.radRiñones1)
        Me.GroupBox21.Location = New System.Drawing.Point(547, 4)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(130, 80)
        Me.GroupBox21.TabIndex = 8
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Riñones"
        '
        'radRiñones2
        '
        Me.radRiñones2.Location = New System.Drawing.Point(5, 40)
        Me.radRiñones2.Name = "radRiñones2"
        Me.radRiñones2.Size = New System.Drawing.Size(93, 16)
        Me.radRiñones2.TabIndex = 1
        Me.radRiñones2.Text = "Anormales"
        '
        'radRiñones1
        '
        Me.radRiñones1.Location = New System.Drawing.Point(5, 20)
        Me.radRiñones1.Name = "radRiñones1"
        Me.radRiñones1.Size = New System.Drawing.Size(103, 16)
        Me.radRiñones1.TabIndex = 0
        Me.radRiñones1.Text = "Normales"
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.radAbdomen2)
        Me.GroupBox20.Controls.Add(Me.radAbdomen1)
        Me.GroupBox20.Location = New System.Drawing.Point(411, 90)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(130, 80)
        Me.GroupBox20.TabIndex = 7
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Abdomen"
        '
        'radAbdomen2
        '
        Me.radAbdomen2.Location = New System.Drawing.Point(5, 40)
        Me.radAbdomen2.Name = "radAbdomen2"
        Me.radAbdomen2.Size = New System.Drawing.Size(64, 16)
        Me.radAbdomen2.TabIndex = 1
        Me.radAbdomen2.Text = "Anormal"
        '
        'radAbdomen1
        '
        Me.radAbdomen1.Location = New System.Drawing.Point(5, 20)
        Me.radAbdomen1.Name = "radAbdomen1"
        Me.radAbdomen1.Size = New System.Drawing.Size(64, 16)
        Me.radAbdomen1.TabIndex = 0
        Me.radAbdomen1.Text = "Normal"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.radCorazon2)
        Me.GroupBox19.Controls.Add(Me.radCorazon1)
        Me.GroupBox19.Location = New System.Drawing.Point(411, 4)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(130, 80)
        Me.GroupBox19.TabIndex = 6
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Corazón"
        '
        'radCorazon2
        '
        Me.radCorazon2.Location = New System.Drawing.Point(5, 40)
        Me.radCorazon2.Name = "radCorazon2"
        Me.radCorazon2.Size = New System.Drawing.Size(64, 16)
        Me.radCorazon2.TabIndex = 1
        Me.radCorazon2.Text = "Anormal"
        '
        'radCorazon1
        '
        Me.radCorazon1.Location = New System.Drawing.Point(5, 20)
        Me.radCorazon1.Name = "radCorazon1"
        Me.radCorazon1.Size = New System.Drawing.Size(64, 16)
        Me.radCorazon1.TabIndex = 0
        Me.radCorazon1.Text = "Normal"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.radColumna2)
        Me.GroupBox16.Controls.Add(Me.radColumna1)
        Me.GroupBox16.Location = New System.Drawing.Point(139, 90)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(130, 80)
        Me.GroupBox16.TabIndex = 3
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Columna Vertebral"
        '
        'radColumna2
        '
        Me.radColumna2.Location = New System.Drawing.Point(5, 40)
        Me.radColumna2.Name = "radColumna2"
        Me.radColumna2.Size = New System.Drawing.Size(64, 16)
        Me.radColumna2.TabIndex = 1
        Me.radColumna2.Text = "Anormal"
        '
        'radColumna1
        '
        Me.radColumna1.Location = New System.Drawing.Point(5, 20)
        Me.radColumna1.Name = "radColumna1"
        Me.radColumna1.Size = New System.Drawing.Size(64, 16)
        Me.radColumna1.TabIndex = 0
        Me.radColumna1.Text = "Normal"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.radVentriculo2)
        Me.GroupBox15.Controls.Add(Me.radVentriculo1)
        Me.GroupBox15.Location = New System.Drawing.Point(3, 90)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(130, 80)
        Me.GroupBox15.TabIndex = 1
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Vent. Cerebrales"
        '
        'radVentriculo2
        '
        Me.radVentriculo2.Location = New System.Drawing.Point(5, 40)
        Me.radVentriculo2.Name = "radVentriculo2"
        Me.radVentriculo2.Size = New System.Drawing.Size(112, 16)
        Me.radVentriculo2.TabIndex = 1
        Me.radVentriculo2.Text = "Anormales"
        '
        'radVentriculo1
        '
        Me.radVentriculo1.Location = New System.Drawing.Point(5, 20)
        Me.radVentriculo1.Name = "radVentriculo1"
        Me.radVentriculo1.Size = New System.Drawing.Size(112, 16)
        Me.radVentriculo1.TabIndex = 0
        Me.radVentriculo1.Text = "Normales"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.radCabeza2)
        Me.GroupBox17.Controls.Add(Me.radCabeza1)
        Me.GroupBox17.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(130, 80)
        Me.GroupBox17.TabIndex = 0
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Polo Cefálico"
        '
        'radCabeza2
        '
        Me.radCabeza2.Location = New System.Drawing.Point(5, 40)
        Me.radCabeza2.Name = "radCabeza2"
        Me.radCabeza2.Size = New System.Drawing.Size(64, 16)
        Me.radCabeza2.TabIndex = 1
        Me.radCabeza2.Text = "Anormal"
        '
        'radCabeza1
        '
        Me.radCabeza1.Location = New System.Drawing.Point(5, 20)
        Me.radCabeza1.Name = "radCabeza1"
        Me.radCabeza1.Size = New System.Drawing.Size(64, 16)
        Me.radCabeza1.TabIndex = 0
        Me.radCabeza1.Text = "Normal"
        '
        'TabPageFuncionales
        '
        Me.TabPageFuncionales.Controls.Add(Me.GroupBox30)
        Me.TabPageFuncionales.Controls.Add(Me.GroupBox31)
        Me.TabPageFuncionales.Controls.Add(Me.GroupBox32)
        Me.TabPageFuncionales.Controls.Add(Me.GroupBox27)
        Me.TabPageFuncionales.Controls.Add(Me.GroupBox28)
        Me.TabPageFuncionales.Controls.Add(Me.GroupBox29)
        Me.TabPageFuncionales.Controls.Add(Me.GroupBox26)
        Me.TabPageFuncionales.Controls.Add(Me.GroupBox25)
        Me.TabPageFuncionales.Controls.Add(Me.GroupBox24)
        Me.TabPageFuncionales.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFuncionales.Name = "TabPageFuncionales"
        Me.TabPageFuncionales.Size = New System.Drawing.Size(880, 234)
        Me.TabPageFuncionales.TabIndex = 2
        Me.TabPageFuncionales.Text = "Datos Funcionales"
        Me.TabPageFuncionales.UseVisualStyleBackColor = True
        Me.TabPageFuncionales.Visible = False
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.radVejiga2)
        Me.GroupBox30.Controls.Add(Me.radVejiga1)
        Me.GroupBox30.Location = New System.Drawing.Point(456, 92)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(208, 41)
        Me.GroupBox30.TabIndex = 21
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "Vejiga"
        '
        'radVejiga2
        '
        Me.radVejiga2.Location = New System.Drawing.Point(96, 16)
        Me.radVejiga2.Name = "radVejiga2"
        Me.radVejiga2.Size = New System.Drawing.Size(64, 16)
        Me.radVejiga2.TabIndex = 1
        Me.radVejiga2.Text = "Vacía"
        '
        'radVejiga1
        '
        Me.radVejiga1.Location = New System.Drawing.Point(8, 16)
        Me.radVejiga1.Name = "radVejiga1"
        Me.radVejiga1.Size = New System.Drawing.Size(64, 16)
        Me.radVejiga1.TabIndex = 0
        Me.radVejiga1.Text = "Llena"
        '
        'GroupBox31
        '
        Me.GroupBox31.Controls.Add(Me.radIntestino5)
        Me.GroupBox31.Controls.Add(Me.radIntestino4)
        Me.GroupBox31.Controls.Add(Me.radIntestino3)
        Me.GroupBox31.Controls.Add(Me.radIntestino2)
        Me.GroupBox31.Controls.Add(Me.radIntestino1)
        Me.GroupBox31.Location = New System.Drawing.Point(240, 92)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(208, 41)
        Me.GroupBox31.TabIndex = 20
        Me.GroupBox31.TabStop = False
        Me.GroupBox31.Text = "Intestino (Tipo)"
        '
        'radIntestino5
        '
        Me.radIntestino5.Location = New System.Drawing.Point(171, 16)
        Me.radIntestino5.Name = "radIntestino5"
        Me.radIntestino5.Size = New System.Drawing.Size(35, 16)
        Me.radIntestino5.TabIndex = 4
        Me.radIntestino5.Text = "4"
        '
        'radIntestino4
        '
        Me.radIntestino4.Location = New System.Drawing.Point(130, 16)
        Me.radIntestino4.Name = "radIntestino4"
        Me.radIntestino4.Size = New System.Drawing.Size(35, 16)
        Me.radIntestino4.TabIndex = 3
        Me.radIntestino4.Text = "3"
        '
        'radIntestino3
        '
        Me.radIntestino3.Location = New System.Drawing.Point(89, 16)
        Me.radIntestino3.Name = "radIntestino3"
        Me.radIntestino3.Size = New System.Drawing.Size(35, 16)
        Me.radIntestino3.TabIndex = 2
        Me.radIntestino3.Text = "2"
        '
        'radIntestino2
        '
        Me.radIntestino2.Location = New System.Drawing.Point(48, 16)
        Me.radIntestino2.Name = "radIntestino2"
        Me.radIntestino2.Size = New System.Drawing.Size(35, 16)
        Me.radIntestino2.TabIndex = 1
        Me.radIntestino2.Text = "1"
        '
        'radIntestino1
        '
        Me.radIntestino1.Location = New System.Drawing.Point(7, 16)
        Me.radIntestino1.Name = "radIntestino1"
        Me.radIntestino1.Size = New System.Drawing.Size(35, 16)
        Me.radIntestino1.TabIndex = 0
        Me.radIntestino1.Text = "0"
        '
        'GroupBox32
        '
        Me.GroupBox32.Controls.Add(Me.radCamaraGastrica2)
        Me.GroupBox32.Controls.Add(Me.radCamaraGastrica1)
        Me.GroupBox32.Location = New System.Drawing.Point(24, 92)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Size = New System.Drawing.Size(208, 41)
        Me.GroupBox32.TabIndex = 19
        Me.GroupBox32.TabStop = False
        Me.GroupBox32.Text = "Cámara Gástrica"
        '
        'radCamaraGastrica2
        '
        Me.radCamaraGastrica2.Location = New System.Drawing.Point(96, 16)
        Me.radCamaraGastrica2.Name = "radCamaraGastrica2"
        Me.radCamaraGastrica2.Size = New System.Drawing.Size(88, 16)
        Me.radCamaraGastrica2.TabIndex = 1
        Me.radCamaraGastrica2.Text = "Vacía"
        '
        'radCamaraGastrica1
        '
        Me.radCamaraGastrica1.Location = New System.Drawing.Point(8, 16)
        Me.radCamaraGastrica1.Name = "radCamaraGastrica1"
        Me.radCamaraGastrica1.Size = New System.Drawing.Size(64, 16)
        Me.radCamaraGastrica1.TabIndex = 0
        Me.radCamaraGastrica1.Text = "Llena"
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.radAortoCava2)
        Me.GroupBox27.Controls.Add(Me.radAortoCava1)
        Me.GroupBox27.Location = New System.Drawing.Point(456, 48)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(208, 41)
        Me.GroupBox27.TabIndex = 18
        Me.GroupBox27.TabStop = False
        Me.GroupBox27.Text = "Relación Aorto-Cava"
        '
        'radAortoCava2
        '
        Me.radAortoCava2.Location = New System.Drawing.Point(96, 16)
        Me.radAortoCava2.Name = "radAortoCava2"
        Me.radAortoCava2.Size = New System.Drawing.Size(64, 16)
        Me.radAortoCava2.TabIndex = 1
        Me.radAortoCava2.Text = "Anormal"
        '
        'radAortoCava1
        '
        Me.radAortoCava1.Location = New System.Drawing.Point(8, 16)
        Me.radAortoCava1.Name = "radAortoCava1"
        Me.radAortoCava1.Size = New System.Drawing.Size(64, 16)
        Me.radAortoCava1.TabIndex = 0
        Me.radAortoCava1.Text = "Normal"
        '
        'GroupBox28
        '
        Me.GroupBox28.Controls.Add(Me.radMovimientosRespiratorios2)
        Me.GroupBox28.Controls.Add(Me.radMovimientosRespiratorios1)
        Me.GroupBox28.Location = New System.Drawing.Point(240, 48)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(208, 41)
        Me.GroupBox28.TabIndex = 17
        Me.GroupBox28.TabStop = False
        Me.GroupBox28.Text = "Movimientos Respiratorios"
        '
        'radMovimientosRespiratorios2
        '
        Me.radMovimientosRespiratorios2.Location = New System.Drawing.Point(96, 16)
        Me.radMovimientosRespiratorios2.Name = "radMovimientosRespiratorios2"
        Me.radMovimientosRespiratorios2.Size = New System.Drawing.Size(80, 16)
        Me.radMovimientosRespiratorios2.TabIndex = 1
        Me.radMovimientosRespiratorios2.Text = "Ausentes"
        '
        'radMovimientosRespiratorios1
        '
        Me.radMovimientosRespiratorios1.Location = New System.Drawing.Point(8, 16)
        Me.radMovimientosRespiratorios1.Name = "radMovimientosRespiratorios1"
        Me.radMovimientosRespiratorios1.Size = New System.Drawing.Size(80, 16)
        Me.radMovimientosRespiratorios1.TabIndex = 0
        Me.radMovimientosRespiratorios1.Text = "Presentes"
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Me.radActividadCardiaca2)
        Me.GroupBox29.Controls.Add(Me.radActividadCardiaca1)
        Me.GroupBox29.Location = New System.Drawing.Point(24, 48)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(208, 41)
        Me.GroupBox29.TabIndex = 16
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "Actividad Cardíaca"
        '
        'radActividadCardiaca2
        '
        Me.radActividadCardiaca2.Location = New System.Drawing.Point(96, 16)
        Me.radActividadCardiaca2.Name = "radActividadCardiaca2"
        Me.radActividadCardiaca2.Size = New System.Drawing.Size(88, 16)
        Me.radActividadCardiaca2.TabIndex = 1
        Me.radActividadCardiaca2.Text = "Ausente"
        '
        'radActividadCardiaca1
        '
        Me.radActividadCardiaca1.Location = New System.Drawing.Point(8, 16)
        Me.radActividadCardiaca1.Name = "radActividadCardiaca1"
        Me.radActividadCardiaca1.Size = New System.Drawing.Size(82, 16)
        Me.radActividadCardiaca1.TabIndex = 0
        Me.radActividadCardiaca1.Text = "Presente"
        '
        'GroupBox26
        '
        Me.GroupBox26.Controls.Add(Me.radMovimientosFetales2)
        Me.GroupBox26.Controls.Add(Me.radMovimientosFetales1)
        Me.GroupBox26.Location = New System.Drawing.Point(456, 4)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(208, 41)
        Me.GroupBox26.TabIndex = 15
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Text = "Movimientos Fetales"
        '
        'radMovimientosFetales2
        '
        Me.radMovimientosFetales2.Location = New System.Drawing.Point(96, 16)
        Me.radMovimientosFetales2.Name = "radMovimientosFetales2"
        Me.radMovimientosFetales2.Size = New System.Drawing.Size(72, 16)
        Me.radMovimientosFetales2.TabIndex = 1
        Me.radMovimientosFetales2.Text = "Ausentes"
        '
        'radMovimientosFetales1
        '
        Me.radMovimientosFetales1.Location = New System.Drawing.Point(8, 16)
        Me.radMovimientosFetales1.Name = "radMovimientosFetales1"
        Me.radMovimientosFetales1.Size = New System.Drawing.Size(80, 16)
        Me.radMovimientosFetales1.TabIndex = 0
        Me.radMovimientosFetales1.Text = "Presentes"
        '
        'GroupBox25
        '
        Me.GroupBox25.Controls.Add(Me.radTono2)
        Me.GroupBox25.Controls.Add(Me.radTono1)
        Me.GroupBox25.Location = New System.Drawing.Point(240, 4)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(208, 41)
        Me.GroupBox25.TabIndex = 14
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Tono"
        '
        'radTono2
        '
        Me.radTono2.Location = New System.Drawing.Point(96, 16)
        Me.radTono2.Name = "radTono2"
        Me.radTono2.Size = New System.Drawing.Size(64, 16)
        Me.radTono2.TabIndex = 1
        Me.radTono2.Text = "Anormal"
        '
        'radTono1
        '
        Me.radTono1.Location = New System.Drawing.Point(8, 16)
        Me.radTono1.Name = "radTono1"
        Me.radTono1.Size = New System.Drawing.Size(64, 16)
        Me.radTono1.TabIndex = 0
        Me.radTono1.Text = "Normal"
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.radActitud2)
        Me.GroupBox24.Controls.Add(Me.radActitud1)
        Me.GroupBox24.Location = New System.Drawing.Point(24, 4)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(208, 41)
        Me.GroupBox24.TabIndex = 13
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Actitud Global"
        '
        'radActitud2
        '
        Me.radActitud2.Location = New System.Drawing.Point(96, 16)
        Me.radActitud2.Name = "radActitud2"
        Me.radActitud2.Size = New System.Drawing.Size(92, 16)
        Me.radActitud2.TabIndex = 1
        Me.radActitud2.Text = "Extensión"
        '
        'radActitud1
        '
        Me.radActitud1.Location = New System.Drawing.Point(8, 16)
        Me.radActitud1.Name = "radActitud1"
        Me.radActitud1.Size = New System.Drawing.Size(64, 16)
        Me.radActitud1.TabIndex = 0
        Me.radActitud1.Text = "Flexión"
        '
        'TabPagePlacentarios
        '
        Me.TabPagePlacentarios.Controls.Add(Me.GroupBox37)
        Me.TabPagePlacentarios.Controls.Add(Me.GroupBox36)
        Me.TabPagePlacentarios.Controls.Add(Me.GroupBox35)
        Me.TabPagePlacentarios.Controls.Add(Me.GroupBox34)
        Me.TabPagePlacentarios.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePlacentarios.Name = "TabPagePlacentarios"
        Me.TabPagePlacentarios.Size = New System.Drawing.Size(880, 234)
        Me.TabPagePlacentarios.TabIndex = 3
        Me.TabPagePlacentarios.Text = "Datos Placentarios y L.A."
        Me.TabPagePlacentarios.UseVisualStyleBackColor = True
        Me.TabPagePlacentarios.Visible = False
        '
        'GroupBox37
        '
        Me.GroupBox37.Controls.Add(Me.radCordon2)
        Me.GroupBox37.Controls.Add(Me.radCordon1)
        Me.GroupBox37.Location = New System.Drawing.Point(557, 4)
        Me.GroupBox37.Name = "GroupBox37"
        Me.GroupBox37.Size = New System.Drawing.Size(120, 143)
        Me.GroupBox37.TabIndex = 3
        Me.GroupBox37.TabStop = False
        Me.GroupBox37.Text = "Cordón Umbilical"
        '
        'radCordon2
        '
        Me.radCordon2.Location = New System.Drawing.Point(12, 40)
        Me.radCordon2.Name = "radCordon2"
        Me.radCordon2.Size = New System.Drawing.Size(100, 24)
        Me.radCordon2.TabIndex = 1
        Me.radCordon2.Text = "Anormal"
        '
        'radCordon1
        '
        Me.radCordon1.Location = New System.Drawing.Point(12, 16)
        Me.radCordon1.Name = "radCordon1"
        Me.radCordon1.Size = New System.Drawing.Size(91, 24)
        Me.radCordon1.TabIndex = 0
        Me.radCordon1.Text = "3 Elementos"
        '
        'GroupBox36
        '
        Me.GroupBox36.Controls.Add(Me.txtILA)
        Me.GroupBox36.Controls.Add(Me.Label52)
        Me.GroupBox36.Controls.Add(Me.radLiquidoAmniotico2)
        Me.GroupBox36.Controls.Add(Me.radLiquidoAmniotico1)
        Me.GroupBox36.Location = New System.Drawing.Point(435, 4)
        Me.GroupBox36.Name = "GroupBox36"
        Me.GroupBox36.Size = New System.Drawing.Size(120, 143)
        Me.GroupBox36.TabIndex = 2
        Me.GroupBox36.TabStop = False
        Me.GroupBox36.Text = "Líquido Amniótico"
        '
        'txtILA
        '
        Me.txtILA.Location = New System.Drawing.Point(65, 70)
        Me.txtILA.MaxLength = 2
        Me.txtILA.Name = "txtILA"
        Me.txtILA.Size = New System.Drawing.Size(32, 20)
        Me.txtILA.TabIndex = 3
        '
        'Label52
        '
        Me.Label52.Location = New System.Drawing.Point(7, 68)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(54, 23)
        Me.Label52.TabIndex = 2
        Me.Label52.Text = "ILA(cm):"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radLiquidoAmniotico2
        '
        Me.radLiquidoAmniotico2.Location = New System.Drawing.Point(16, 40)
        Me.radLiquidoAmniotico2.Name = "radLiquidoAmniotico2"
        Me.radLiquidoAmniotico2.Size = New System.Drawing.Size(76, 24)
        Me.radLiquidoAmniotico2.TabIndex = 1
        Me.radLiquidoAmniotico2.Text = "Anormal"
        '
        'radLiquidoAmniotico1
        '
        Me.radLiquidoAmniotico1.Location = New System.Drawing.Point(16, 16)
        Me.radLiquidoAmniotico1.Name = "radLiquidoAmniotico1"
        Me.radLiquidoAmniotico1.Size = New System.Drawing.Size(76, 24)
        Me.radLiquidoAmniotico1.TabIndex = 0
        Me.radLiquidoAmniotico1.Text = "Normal"
        '
        'GroupBox35
        '
        Me.GroupBox35.Controls.Add(Me.radPlacentaGrado7)
        Me.GroupBox35.Controls.Add(Me.radPlacentaGrado6)
        Me.GroupBox35.Controls.Add(Me.radPlacentaGrado5)
        Me.GroupBox35.Controls.Add(Me.radPlacentaGrado4)
        Me.GroupBox35.Controls.Add(Me.radPlacentaGrado3)
        Me.GroupBox35.Controls.Add(Me.radPlacentaGrado2)
        Me.GroupBox35.Controls.Add(Me.radPlacentaGrado1)
        Me.GroupBox35.Controls.Add(Me.txtPlacentaGrosor)
        Me.GroupBox35.Controls.Add(Me.Label43)
        Me.GroupBox35.Location = New System.Drawing.Point(261, 4)
        Me.GroupBox35.Name = "GroupBox35"
        Me.GroupBox35.Size = New System.Drawing.Size(172, 143)
        Me.GroupBox35.TabIndex = 1
        Me.GroupBox35.TabStop = False
        Me.GroupBox35.Text = "Placenta Grado Madurez"
        '
        'radPlacentaGrado7
        '
        Me.radPlacentaGrado7.AutoSize = True
        Me.radPlacentaGrado7.Location = New System.Drawing.Point(92, 68)
        Me.radPlacentaGrado7.Name = "radPlacentaGrado7"
        Me.radPlacentaGrado7.Size = New System.Drawing.Size(63, 17)
        Me.radPlacentaGrado7.TabIndex = 6
        Me.radPlacentaGrado7.TabStop = True
        Me.radPlacentaGrado7.Text = "Grado 3"
        Me.radPlacentaGrado7.UseVisualStyleBackColor = True
        '
        'radPlacentaGrado6
        '
        Me.radPlacentaGrado6.AutoSize = True
        Me.radPlacentaGrado6.Location = New System.Drawing.Point(92, 44)
        Me.radPlacentaGrado6.Name = "radPlacentaGrado6"
        Me.radPlacentaGrado6.Size = New System.Drawing.Size(72, 17)
        Me.radPlacentaGrado6.TabIndex = 5
        Me.radPlacentaGrado6.TabStop = True
        Me.radPlacentaGrado6.Text = "Grado 2-3"
        Me.radPlacentaGrado6.UseVisualStyleBackColor = True
        '
        'radPlacentaGrado5
        '
        Me.radPlacentaGrado5.AutoSize = True
        Me.radPlacentaGrado5.Location = New System.Drawing.Point(92, 20)
        Me.radPlacentaGrado5.Name = "radPlacentaGrado5"
        Me.radPlacentaGrado5.Size = New System.Drawing.Size(63, 17)
        Me.radPlacentaGrado5.TabIndex = 4
        Me.radPlacentaGrado5.TabStop = True
        Me.radPlacentaGrado5.Text = "Grado 2"
        Me.radPlacentaGrado5.UseVisualStyleBackColor = True
        '
        'radPlacentaGrado4
        '
        Me.radPlacentaGrado4.AutoSize = True
        Me.radPlacentaGrado4.Location = New System.Drawing.Point(12, 91)
        Me.radPlacentaGrado4.Name = "radPlacentaGrado4"
        Me.radPlacentaGrado4.Size = New System.Drawing.Size(72, 17)
        Me.radPlacentaGrado4.TabIndex = 3
        Me.radPlacentaGrado4.TabStop = True
        Me.radPlacentaGrado4.Text = "Grado 1-2"
        Me.radPlacentaGrado4.UseVisualStyleBackColor = True
        '
        'radPlacentaGrado3
        '
        Me.radPlacentaGrado3.AutoSize = True
        Me.radPlacentaGrado3.Location = New System.Drawing.Point(12, 68)
        Me.radPlacentaGrado3.Name = "radPlacentaGrado3"
        Me.radPlacentaGrado3.Size = New System.Drawing.Size(63, 17)
        Me.radPlacentaGrado3.TabIndex = 2
        Me.radPlacentaGrado3.TabStop = True
        Me.radPlacentaGrado3.Text = "Grado 1"
        Me.radPlacentaGrado3.UseVisualStyleBackColor = True
        '
        'radPlacentaGrado2
        '
        Me.radPlacentaGrado2.AutoSize = True
        Me.radPlacentaGrado2.Location = New System.Drawing.Point(12, 44)
        Me.radPlacentaGrado2.Name = "radPlacentaGrado2"
        Me.radPlacentaGrado2.Size = New System.Drawing.Size(72, 17)
        Me.radPlacentaGrado2.TabIndex = 1
        Me.radPlacentaGrado2.TabStop = True
        Me.radPlacentaGrado2.Text = "Grado 0-1"
        Me.radPlacentaGrado2.UseVisualStyleBackColor = True
        '
        'radPlacentaGrado1
        '
        Me.radPlacentaGrado1.AutoSize = True
        Me.radPlacentaGrado1.Location = New System.Drawing.Point(12, 20)
        Me.radPlacentaGrado1.Name = "radPlacentaGrado1"
        Me.radPlacentaGrado1.Size = New System.Drawing.Size(63, 17)
        Me.radPlacentaGrado1.TabIndex = 0
        Me.radPlacentaGrado1.TabStop = True
        Me.radPlacentaGrado1.Text = "Grado 0"
        Me.radPlacentaGrado1.UseVisualStyleBackColor = True
        '
        'txtPlacentaGrosor
        '
        Me.txtPlacentaGrosor.Location = New System.Drawing.Point(76, 117)
        Me.txtPlacentaGrosor.MaxLength = 2
        Me.txtPlacentaGrosor.Name = "txtPlacentaGrosor"
        Me.txtPlacentaGrosor.Size = New System.Drawing.Size(40, 20)
        Me.txtPlacentaGrosor.TabIndex = 8
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(9, 115)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(67, 23)
        Me.Label43.TabIndex = 7
        Me.Label43.Text = "Grosor(mm): "
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox34
        '
        Me.GroupBox34.Controls.Add(Me.radPlacenta8)
        Me.GroupBox34.Controls.Add(Me.radPlacenta7)
        Me.GroupBox34.Controls.Add(Me.radPlacenta6)
        Me.GroupBox34.Controls.Add(Me.radPlacenta5)
        Me.GroupBox34.Controls.Add(Me.radplacenta4)
        Me.GroupBox34.Controls.Add(Me.radPlacenta3)
        Me.GroupBox34.Controls.Add(Me.radPlacenta2)
        Me.GroupBox34.Controls.Add(Me.radPlacenta1)
        Me.GroupBox34.Location = New System.Drawing.Point(11, 4)
        Me.GroupBox34.Name = "GroupBox34"
        Me.GroupBox34.Size = New System.Drawing.Size(248, 143)
        Me.GroupBox34.TabIndex = 0
        Me.GroupBox34.TabStop = False
        Me.GroupBox34.Text = "Placenta - Localización"
        '
        'radPlacenta8
        '
        Me.radPlacenta8.Location = New System.Drawing.Point(122, 64)
        Me.radPlacenta8.Name = "radPlacenta8"
        Me.radPlacenta8.Size = New System.Drawing.Size(120, 24)
        Me.radPlacenta8.TabIndex = 5
        Me.radPlacenta8.Text = "Inserción Baja"
        '
        'radPlacenta7
        '
        Me.radPlacenta7.Location = New System.Drawing.Point(122, 87)
        Me.radPlacenta7.Name = "radPlacenta7"
        Me.radPlacenta7.Size = New System.Drawing.Size(104, 24)
        Me.radPlacenta7.TabIndex = 7
        Me.radPlacenta7.Text = "Previa Total"
        '
        'radPlacenta6
        '
        Me.radPlacenta6.Location = New System.Drawing.Point(8, 87)
        Me.radPlacenta6.Name = "radPlacenta6"
        Me.radPlacenta6.Size = New System.Drawing.Size(120, 24)
        Me.radPlacenta6.TabIndex = 6
        Me.radPlacenta6.Text = "Previa Parcial"
        '
        'radPlacenta5
        '
        Me.radPlacenta5.Location = New System.Drawing.Point(8, 64)
        Me.radPlacenta5.Name = "radPlacenta5"
        Me.radPlacenta5.Size = New System.Drawing.Size(104, 24)
        Me.radPlacenta5.TabIndex = 4
        Me.radPlacenta5.Text = "Fúndica"
        '
        'radplacenta4
        '
        Me.radplacenta4.Location = New System.Drawing.Point(122, 40)
        Me.radplacenta4.Name = "radplacenta4"
        Me.radplacenta4.Size = New System.Drawing.Size(120, 24)
        Me.radplacenta4.TabIndex = 3
        Me.radplacenta4.Text = "Posterior y Fúndica"
        '
        'radPlacenta3
        '
        Me.radPlacenta3.Location = New System.Drawing.Point(8, 40)
        Me.radPlacenta3.Name = "radPlacenta3"
        Me.radPlacenta3.Size = New System.Drawing.Size(122, 24)
        Me.radPlacenta3.TabIndex = 2
        Me.radPlacenta3.Text = "Anterior y Fúndica"
        '
        'radPlacenta2
        '
        Me.radPlacenta2.Location = New System.Drawing.Point(122, 16)
        Me.radPlacenta2.Name = "radPlacenta2"
        Me.radPlacenta2.Size = New System.Drawing.Size(80, 24)
        Me.radPlacenta2.TabIndex = 1
        Me.radPlacenta2.Text = "Posterior"
        '
        'radPlacenta1
        '
        Me.radPlacenta1.Location = New System.Drawing.Point(8, 16)
        Me.radPlacenta1.Name = "radPlacenta1"
        Me.radPlacenta1.Size = New System.Drawing.Size(104, 24)
        Me.radPlacenta1.TabIndex = 0
        Me.radPlacenta1.Text = "Anterior"
        '
        'TabPageNotas
        '
        Me.TabPageNotas.Controls.Add(Me.Label67)
        Me.TabPageNotas.Controls.Add(Me.txtNotas03del2y3erT)
        Me.TabPageNotas.Controls.Add(Me.txtNotas02del2y3erT)
        Me.TabPageNotas.Controls.Add(Me.txtNotas01del2y3erT)
        Me.TabPageNotas.Location = New System.Drawing.Point(4, 22)
        Me.TabPageNotas.Name = "TabPageNotas"
        Me.TabPageNotas.Size = New System.Drawing.Size(880, 234)
        Me.TabPageNotas.TabIndex = 6
        Me.TabPageNotas.Text = "Notas"
        Me.TabPageNotas.UseVisualStyleBackColor = True
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(17, 31)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(35, 13)
        Me.Label67.TabIndex = 4
        Me.Label67.Text = "Notas"
        '
        'txtNotas03del2y3erT
        '
        Me.txtNotas03del2y3erT.Location = New System.Drawing.Point(20, 103)
        Me.txtNotas03del2y3erT.MaxLength = 100
        Me.txtNotas03del2y3erT.Name = "txtNotas03del2y3erT"
        Me.txtNotas03del2y3erT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotas03del2y3erT.Size = New System.Drawing.Size(648, 20)
        Me.txtNotas03del2y3erT.TabIndex = 3
        '
        'txtNotas02del2y3erT
        '
        Me.txtNotas02del2y3erT.Location = New System.Drawing.Point(20, 77)
        Me.txtNotas02del2y3erT.MaxLength = 100
        Me.txtNotas02del2y3erT.Name = "txtNotas02del2y3erT"
        Me.txtNotas02del2y3erT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotas02del2y3erT.Size = New System.Drawing.Size(648, 20)
        Me.txtNotas02del2y3erT.TabIndex = 2
        '
        'txtNotas01del2y3erT
        '
        Me.txtNotas01del2y3erT.Location = New System.Drawing.Point(20, 51)
        Me.txtNotas01del2y3erT.MaxLength = 100
        Me.txtNotas01del2y3erT.Name = "txtNotas01del2y3erT"
        Me.txtNotas01del2y3erT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotas01del2y3erT.Size = New System.Drawing.Size(648, 20)
        Me.txtNotas01del2y3erT.TabIndex = 1
        '
        'TabPageIDx
        '
        Me.TabPageIDx.Controls.Add(Me.GroupBox11)
        Me.TabPageIDx.Controls.Add(Me.GroupBox43)
        Me.TabPageIDx.Location = New System.Drawing.Point(4, 22)
        Me.TabPageIDx.Name = "TabPageIDx"
        Me.TabPageIDx.Size = New System.Drawing.Size(880, 234)
        Me.TabPageIDx.TabIndex = 4
        Me.TabPageIDx.Text = "Impresión Diagnóstica"
        Me.TabPageIDx.UseVisualStyleBackColor = True
        Me.TabPageIDx.Visible = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtSug03del2y3erT)
        Me.GroupBox11.Controls.Add(Me.txtSug02del2y3erT)
        Me.GroupBox11.Controls.Add(Me.txtSug01del2y3erT)
        Me.GroupBox11.Location = New System.Drawing.Point(362, 3)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(323, 228)
        Me.GroupBox11.TabIndex = 82
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Sugerencias"
        '
        'txtSug03del2y3erT
        '
        Me.txtSug03del2y3erT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSug03del2y3erT.Location = New System.Drawing.Point(8, 68)
        Me.txtSug03del2y3erT.MaxLength = 50
        Me.txtSug03del2y3erT.Name = "txtSug03del2y3erT"
        Me.txtSug03del2y3erT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSug03del2y3erT.Size = New System.Drawing.Size(309, 20)
        Me.txtSug03del2y3erT.TabIndex = 2
        '
        'txtSug02del2y3erT
        '
        Me.txtSug02del2y3erT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSug02del2y3erT.Location = New System.Drawing.Point(8, 42)
        Me.txtSug02del2y3erT.MaxLength = 50
        Me.txtSug02del2y3erT.Name = "txtSug02del2y3erT"
        Me.txtSug02del2y3erT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSug02del2y3erT.Size = New System.Drawing.Size(309, 20)
        Me.txtSug02del2y3erT.TabIndex = 1
        '
        'txtSug01del2y3erT
        '
        Me.txtSug01del2y3erT.Location = New System.Drawing.Point(8, 16)
        Me.txtSug01del2y3erT.MaxLength = 50
        Me.txtSug01del2y3erT.Name = "txtSug01del2y3erT"
        Me.txtSug01del2y3erT.Size = New System.Drawing.Size(309, 20)
        Me.txtSug01del2y3erT.TabIndex = 0
        '
        'GroupBox43
        '
        Me.GroupBox43.Controls.Add(Me.txtIDx08del2y3erT)
        Me.GroupBox43.Controls.Add(Me.txtIDx07del2y3erT)
        Me.GroupBox43.Controls.Add(Me.txtIDx06del2y3erT)
        Me.GroupBox43.Controls.Add(Me.botCalculaEcopuntaje)
        Me.GroupBox43.Controls.Add(Me.botCalculaPerfil)
        Me.GroupBox43.Controls.Add(Me.botCalculaPercentil)
        Me.GroupBox43.Controls.Add(Me.botCalculaEG)
        Me.GroupBox43.Controls.Add(Me.Label62)
        Me.GroupBox43.Controls.Add(Me.Label63)
        Me.GroupBox43.Controls.Add(Me.txtIdx04del2y3erT)
        Me.GroupBox43.Controls.Add(Me.Label61)
        Me.GroupBox43.Controls.Add(Me.Label54)
        Me.GroupBox43.Controls.Add(Me.txtIdx03del2y3erT)
        Me.GroupBox43.Controls.Add(Me.txtIdx02del2y3erT)
        Me.GroupBox43.Controls.Add(Me.txtIdx01del2y3erT)
        Me.GroupBox43.Controls.Add(Me.txtIdx05del2y3erT)
        Me.GroupBox43.Controls.Add(Me.Label57)
        Me.GroupBox43.Controls.Add(Me.Label58)
        Me.GroupBox43.Controls.Add(Me.Label59)
        Me.GroupBox43.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox43.Name = "GroupBox43"
        Me.GroupBox43.Size = New System.Drawing.Size(353, 228)
        Me.GroupBox43.TabIndex = 81
        Me.GroupBox43.TabStop = False
        Me.GroupBox43.Text = "Impresión Diagnóstica"
        '
        'txtIDx08del2y3erT
        '
        Me.txtIDx08del2y3erT.Location = New System.Drawing.Point(9, 198)
        Me.txtIDx08del2y3erT.MaxLength = 50
        Me.txtIDx08del2y3erT.Name = "txtIDx08del2y3erT"
        Me.txtIDx08del2y3erT.Size = New System.Drawing.Size(338, 20)
        Me.txtIDx08del2y3erT.TabIndex = 7
        '
        'txtIDx07del2y3erT
        '
        Me.txtIDx07del2y3erT.Location = New System.Drawing.Point(9, 172)
        Me.txtIDx07del2y3erT.MaxLength = 50
        Me.txtIDx07del2y3erT.Name = "txtIDx07del2y3erT"
        Me.txtIDx07del2y3erT.Size = New System.Drawing.Size(338, 20)
        Me.txtIDx07del2y3erT.TabIndex = 6
        '
        'txtIDx06del2y3erT
        '
        Me.txtIDx06del2y3erT.Location = New System.Drawing.Point(9, 146)
        Me.txtIDx06del2y3erT.MaxLength = 50
        Me.txtIDx06del2y3erT.Name = "txtIDx06del2y3erT"
        Me.txtIDx06del2y3erT.Size = New System.Drawing.Size(338, 20)
        Me.txtIDx06del2y3erT.TabIndex = 5
        '
        'botCalculaEcopuntaje
        '
        Me.botCalculaEcopuntaje.Location = New System.Drawing.Point(292, 92)
        Me.botCalculaEcopuntaje.Name = "botCalculaEcopuntaje"
        Me.botCalculaEcopuntaje.Size = New System.Drawing.Size(55, 23)
        Me.botCalculaEcopuntaje.TabIndex = 11
        Me.botCalculaEcopuntaje.Text = "Calcula"
        Me.botCalculaEcopuntaje.UseVisualStyleBackColor = True
        '
        'botCalculaPerfil
        '
        Me.botCalculaPerfil.Location = New System.Drawing.Point(292, 66)
        Me.botCalculaPerfil.Name = "botCalculaPerfil"
        Me.botCalculaPerfil.Size = New System.Drawing.Size(55, 23)
        Me.botCalculaPerfil.TabIndex = 10
        Me.botCalculaPerfil.Text = "Calcula"
        Me.botCalculaPerfil.UseVisualStyleBackColor = True
        '
        'botCalculaPercentil
        '
        Me.botCalculaPercentil.Location = New System.Drawing.Point(292, 40)
        Me.botCalculaPercentil.Name = "botCalculaPercentil"
        Me.botCalculaPercentil.Size = New System.Drawing.Size(55, 23)
        Me.botCalculaPercentil.TabIndex = 9
        Me.botCalculaPercentil.Text = "Calcula"
        Me.botCalculaPercentil.UseVisualStyleBackColor = True
        '
        'botCalculaEG
        '
        Me.botCalculaEG.Location = New System.Drawing.Point(292, 14)
        Me.botCalculaEG.Name = "botCalculaEG"
        Me.botCalculaEG.Size = New System.Drawing.Size(55, 23)
        Me.botCalculaEG.TabIndex = 8
        Me.botCalculaEG.Text = "Calcula"
        Me.botCalculaEG.UseVisualStyleBackColor = True
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(174, 97)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(99, 13)
        Me.Label62.TabIndex = 16
        Me.Label62.Text = "puntos (Normal < 2)"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(6, 97)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(110, 13)
        Me.Label63.TabIndex = 15
        Me.Label63.Text = "Ecopuntaje Genético:"
        '
        'txtIdx04del2y3erT
        '
        Me.txtIdx04del2y3erT.Location = New System.Drawing.Point(130, 94)
        Me.txtIdx04del2y3erT.MaxLength = 1
        Me.txtIdx04del2y3erT.Name = "txtIdx04del2y3erT"
        Me.txtIdx04del2y3erT.Size = New System.Drawing.Size(38, 20)
        Me.txtIdx04del2y3erT.TabIndex = 3
        Me.txtIdx04del2y3erT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(198, 71)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(42, 13)
        Me.Label61.TabIndex = 13
        Me.Label61.Text = "sobre 8"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(6, 71)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(131, 13)
        Me.Label54.TabIndex = 12
        Me.Label54.Text = "Perfil Biofísico Ecográfico "
        '
        'txtIdx03del2y3erT
        '
        Me.txtIdx03del2y3erT.Location = New System.Drawing.Point(154, 68)
        Me.txtIdx03del2y3erT.MaxLength = 1
        Me.txtIdx03del2y3erT.Name = "txtIdx03del2y3erT"
        Me.txtIdx03del2y3erT.Size = New System.Drawing.Size(38, 20)
        Me.txtIdx03del2y3erT.TabIndex = 2
        Me.txtIdx03del2y3erT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIdx02del2y3erT
        '
        Me.txtIdx02del2y3erT.Location = New System.Drawing.Point(171, 42)
        Me.txtIdx02del2y3erT.MaxLength = 2
        Me.txtIdx02del2y3erT.Name = "txtIdx02del2y3erT"
        Me.txtIdx02del2y3erT.Size = New System.Drawing.Size(38, 20)
        Me.txtIdx02del2y3erT.TabIndex = 1
        Me.txtIdx02del2y3erT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIdx01del2y3erT
        '
        Me.txtIdx01del2y3erT.Location = New System.Drawing.Point(93, 16)
        Me.txtIdx01del2y3erT.MaxLength = 20
        Me.txtIdx01del2y3erT.Name = "txtIdx01del2y3erT"
        Me.txtIdx01del2y3erT.Size = New System.Drawing.Size(140, 20)
        Me.txtIdx01del2y3erT.TabIndex = 0
        '
        'txtIdx05del2y3erT
        '
        Me.txtIdx05del2y3erT.Location = New System.Drawing.Point(84, 120)
        Me.txtIdx05del2y3erT.MaxLength = 20
        Me.txtIdx05del2y3erT.Name = "txtIdx05del2y3erT"
        Me.txtIdx05del2y3erT.Size = New System.Drawing.Size(138, 20)
        Me.txtIdx05del2y3erT.TabIndex = 4
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(6, 123)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(63, 13)
        Me.Label57.TabIndex = 7
        Me.Label57.Text = "Salud Fetal "
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(6, 45)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(150, 13)
        Me.Label58.TabIndex = 6
        Me.Label58.Text = "Crecimiento Fetal en Percentil "
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(6, 19)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(72, 13)
        Me.Label59.TabIndex = 5
        Me.Label59.Text = "Embarazo de "
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtEdad2y3erT)
        Me.GroupBox10.Controls.Add(Me.labFUR2y3erT)
        Me.GroupBox10.Controls.Add(Me.txtParidad2y3erT)
        Me.GroupBox10.Controls.Add(Me.Label13)
        Me.GroupBox10.Controls.Add(Me.Label36)
        Me.GroupBox10.Controls.Add(Me.labNombre2y3erT)
        Me.GroupBox10.Controls.Add(Me.Label38)
        Me.GroupBox10.Controls.Add(Me.Label39)
        Me.GroupBox10.Controls.Add(Me.labFechaControl2y3erT)
        Me.GroupBox10.Controls.Add(Me.Label41)
        Me.GroupBox10.Controls.Add(Me.Label42)
        Me.GroupBox10.Controls.Add(Me.labEGxFUR2y3erT)
        Me.GroupBox10.Controls.Add(Me.Label44)
        Me.GroupBox10.Controls.Add(Me.labFPP2y3erT)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(744, 76)
        Me.GroupBox10.TabIndex = 1
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Identificación"
        '
        'txtEdad2y3erT
        '
        Me.txtEdad2y3erT.Location = New System.Drawing.Point(368, 18)
        Me.txtEdad2y3erT.MaxLength = 2
        Me.txtEdad2y3erT.Name = "txtEdad2y3erT"
        Me.txtEdad2y3erT.Size = New System.Drawing.Size(32, 20)
        Me.txtEdad2y3erT.TabIndex = 14
        '
        'labFUR2y3erT
        '
        Me.labFUR2y3erT.BackColor = System.Drawing.SystemColors.Info
        Me.labFUR2y3erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFUR2y3erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFUR2y3erT.Location = New System.Drawing.Point(224, 44)
        Me.labFUR2y3erT.Name = "labFUR2y3erT"
        Me.labFUR2y3erT.Size = New System.Drawing.Size(72, 23)
        Me.labFUR2y3erT.TabIndex = 9
        Me.labFUR2y3erT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtParidad2y3erT
        '
        Me.txtParidad2y3erT.Location = New System.Drawing.Point(464, 18)
        Me.txtParidad2y3erT.MaxLength = 30
        Me.txtParidad2y3erT.Name = "txtParidad2y3erT"
        Me.txtParidad2y3erT.Size = New System.Drawing.Size(224, 20)
        Me.txtParidad2y3erT.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(417, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 23)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Paridad:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(328, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(40, 23)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Edad:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labNombre2y3erT
        '
        Me.labNombre2y3erT.BackColor = System.Drawing.SystemColors.Info
        Me.labNombre2y3erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labNombre2y3erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labNombre2y3erT.Location = New System.Drawing.Point(56, 16)
        Me.labNombre2y3erT.Name = "labNombre2y3erT"
        Me.labNombre2y3erT.Size = New System.Drawing.Size(264, 23)
        Me.labNombre2y3erT.TabIndex = 1
        Me.labNombre2y3erT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(8, 16)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(48, 23)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Nombre:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(8, 44)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(80, 23)
        Me.Label39.TabIndex = 6
        Me.Label39.Text = "Fecha Control"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labFechaControl2y3erT
        '
        Me.labFechaControl2y3erT.BackColor = System.Drawing.SystemColors.Info
        Me.labFechaControl2y3erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFechaControl2y3erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFechaControl2y3erT.Location = New System.Drawing.Point(88, 44)
        Me.labFechaControl2y3erT.Name = "labFechaControl2y3erT"
        Me.labFechaControl2y3erT.Size = New System.Drawing.Size(72, 23)
        Me.labFechaControl2y3erT.TabIndex = 7
        Me.labFechaControl2y3erT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(440, 44)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(56, 23)
        Me.Label41.TabIndex = 12
        Me.Label41.Text = "EG x FUR"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(304, 44)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(40, 23)
        Me.Label42.TabIndex = 10
        Me.Label42.Text = "FPP"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labEGxFUR2y3erT
        '
        Me.labEGxFUR2y3erT.BackColor = System.Drawing.SystemColors.Info
        Me.labEGxFUR2y3erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labEGxFUR2y3erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labEGxFUR2y3erT.Location = New System.Drawing.Point(504, 44)
        Me.labEGxFUR2y3erT.Name = "labEGxFUR2y3erT"
        Me.labEGxFUR2y3erT.Size = New System.Drawing.Size(184, 23)
        Me.labEGxFUR2y3erT.TabIndex = 13
        Me.labEGxFUR2y3erT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(176, 44)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(32, 23)
        Me.Label44.TabIndex = 8
        Me.Label44.Text = "FUR"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labFPP2y3erT
        '
        Me.labFPP2y3erT.BackColor = System.Drawing.SystemColors.Info
        Me.labFPP2y3erT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labFPP2y3erT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.labFPP2y3erT.Location = New System.Drawing.Point(352, 44)
        Me.labFPP2y3erT.Name = "labFPP2y3erT"
        Me.labFPP2y3erT.Size = New System.Drawing.Size(72, 23)
        Me.labFPP2y3erT.TabIndex = 11
        Me.labFPP2y3erT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(8, 4)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(352, 16)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "Ecografía Obstétrica del 2do y 3er Trimestre."
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labInforme
        '
        Me.labInforme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labInforme.Image = CType(resources.GetObject("labInforme.Image"), System.Drawing.Image)
        Me.labInforme.Location = New System.Drawing.Point(0, 4)
        Me.labInforme.Name = "labInforme"
        Me.labInforme.Size = New System.Drawing.Size(360, 23)
        Me.labInforme.TabIndex = 5
        Me.labInforme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TP03
        '
        Me.TP03.Controls.Add(Me.txtFechaInicioControl2)
        Me.TP03.Controls.Add(Me.Label68)
        Me.TP03.Controls.Add(Me.PanelImpresion)
        Me.TP03.Controls.Add(Me.labInforme2)
        Me.TP03.Location = New System.Drawing.Point(4, 22)
        Me.TP03.Name = "TP03"
        Me.TP03.Size = New System.Drawing.Size(966, 564)
        Me.TP03.TabIndex = 3
        Me.TP03.Text = "Imprime Informe Ecográfico"
        '
        'txtFechaInicioControl2
        '
        Me.txtFechaInicioControl2.BackColor = System.Drawing.SystemColors.Info
        Me.txtFechaInicioControl2.Location = New System.Drawing.Point(520, 4)
        Me.txtFechaInicioControl2.Name = "txtFechaInicioControl2"
        Me.txtFechaInicioControl2.ReadOnly = True
        Me.txtFechaInicioControl2.Size = New System.Drawing.Size(240, 20)
        Me.txtFechaInicioControl2.TabIndex = 10
        Me.txtFechaInicioControl2.TabStop = False
        Me.txtFechaInicioControl2.Text = "Ninguno"
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(372, 4)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(128, 23)
        Me.Label68.TabIndex = 9
        Me.Label68.Text = "Informe realizado el día :"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelImpresion
        '
        Me.PanelImpresion.Controls.Add(Me.chkImprimeMembrete)
        Me.PanelImpresion.Controls.Add(Me.Panel1)
        Me.PanelImpresion.Controls.Add(Me.botPersonaliza)
        Me.PanelImpresion.Controls.Add(Me.botIMPRIME)
        Me.PanelImpresion.Controls.Add(Me.txtInforme)
        Me.PanelImpresion.Controls.Add(Me.botCreaImpresion)
        Me.PanelImpresion.Location = New System.Drawing.Point(0, 36)
        Me.PanelImpresion.Name = "PanelImpresion"
        Me.PanelImpresion.Size = New System.Drawing.Size(780, 416)
        Me.PanelImpresion.TabIndex = 0
        '
        'chkImprimeMembrete
        '
        Me.chkImprimeMembrete.AutoSize = True
        Me.chkImprimeMembrete.Location = New System.Drawing.Point(587, 385)
        Me.chkImprimeMembrete.Name = "chkImprimeMembrete"
        Me.chkImprimeMembrete.Size = New System.Drawing.Size(112, 17)
        Me.chkImprimeMembrete.TabIndex = 23
        Me.chkImprimeMembrete.Text = "Imprime Membrete"
        Me.chkImprimeMembrete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(20, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 317)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(14, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(690, 925)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'botPersonaliza
        '
        Me.botPersonaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botPersonaliza.Image = CType(resources.GetObject("botPersonaliza.Image"), System.Drawing.Image)
        Me.botPersonaliza.Location = New System.Drawing.Point(328, 356)
        Me.botPersonaliza.Name = "botPersonaliza"
        Me.botPersonaliza.Size = New System.Drawing.Size(120, 23)
        Me.botPersonaliza.TabIndex = 9
        Me.botPersonaliza.Text = "Personaliza Informe"
        '
        'botIMPRIME
        '
        Me.botIMPRIME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botIMPRIME.Image = CType(resources.GetObject("botIMPRIME.Image"), System.Drawing.Image)
        Me.botIMPRIME.Location = New System.Drawing.Point(536, 356)
        Me.botIMPRIME.Name = "botIMPRIME"
        Me.botIMPRIME.Size = New System.Drawing.Size(224, 23)
        Me.botIMPRIME.TabIndex = 2
        Me.botIMPRIME.Text = "Imprime Informe"
        '
        'txtInforme
        '
        Me.txtInforme.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInforme.Location = New System.Drawing.Point(20, 326)
        Me.txtInforme.MaxLength = 16000
        Me.txtInforme.Multiline = True
        Me.txtInforme.Name = "txtInforme"
        Me.txtInforme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInforme.Size = New System.Drawing.Size(736, 26)
        Me.txtInforme.TabIndex = 1
        Me.txtInforme.Visible = False
        '
        'botCreaImpresion
        '
        Me.botCreaImpresion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCreaImpresion.Image = CType(resources.GetObject("botCreaImpresion.Image"), System.Drawing.Image)
        Me.botCreaImpresion.Location = New System.Drawing.Point(20, 356)
        Me.botCreaImpresion.Name = "botCreaImpresion"
        Me.botCreaImpresion.Size = New System.Drawing.Size(224, 23)
        Me.botCreaImpresion.TabIndex = 0
        Me.botCreaImpresion.Text = "Crea o Actualiza Informe Impreso"
        '
        'labInforme2
        '
        Me.labInforme2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labInforme2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labInforme2.Image = CType(resources.GetObject("labInforme2.Image"), System.Drawing.Image)
        Me.labInforme2.Location = New System.Drawing.Point(0, 4)
        Me.labInforme2.Name = "labInforme2"
        Me.labInforme2.Size = New System.Drawing.Size(360, 23)
        Me.labInforme2.TabIndex = 8
        Me.labInforme2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TP04
        '
        Me.TP04.Controls.Add(Me.Label117)
        Me.TP04.Controls.Add(Me.Panel3)
        Me.TP04.Controls.Add(Me.Label125)
        Me.TP04.Controls.Add(Me.TabControl2)
        Me.TP04.Controls.Add(Me.Label124)
        Me.TP04.Location = New System.Drawing.Point(4, 22)
        Me.TP04.Name = "TP04"
        Me.TP04.Size = New System.Drawing.Size(966, 564)
        Me.TP04.TabIndex = 2
        Me.TP04.Text = "Datos Personales"
        '
        'Label117
        '
        Me.Label117.Location = New System.Drawing.Point(8, 109)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(192, 23)
        Me.Label117.TabIndex = 7
        Me.Label117.Text = "Antecedentes"
        Me.Label117.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtTelefono)
        Me.Panel3.Controls.Add(Me.Label118)
        Me.Panel3.Controls.Add(Me.txtProfesion)
        Me.Panel3.Controls.Add(Me.Label119)
        Me.Panel3.Controls.Add(Me.txtCedula)
        Me.Panel3.Controls.Add(Me.Label120)
        Me.Panel3.Controls.Add(Me.txtEdad)
        Me.Panel3.Controls.Add(Me.Label121)
        Me.Panel3.Controls.Add(Me.txtFechaNacimiento)
        Me.Panel3.Controls.Add(Me.Label122)
        Me.Panel3.Controls.Add(Me.txtNombrePaciente)
        Me.Panel3.Controls.Add(Me.Label123)
        Me.Panel3.Location = New System.Drawing.Point(4, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(736, 72)
        Me.Panel3.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.Info
        Me.txtTelefono.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(592, 40)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(128, 18)
        Me.txtTelefono.TabIndex = 11
        '
        'Label118
        '
        Me.Label118.Location = New System.Drawing.Point(536, 36)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(56, 23)
        Me.Label118.TabIndex = 10
        Me.Label118.Text = "Telefono"
        Me.Label118.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProfesion
        '
        Me.txtProfesion.BackColor = System.Drawing.SystemColors.Info
        Me.txtProfesion.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfesion.Location = New System.Drawing.Point(320, 40)
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.ReadOnly = True
        Me.txtProfesion.Size = New System.Drawing.Size(168, 18)
        Me.txtProfesion.TabIndex = 9
        '
        'Label119
        '
        Me.Label119.Location = New System.Drawing.Point(258, 36)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(56, 23)
        Me.Label119.TabIndex = 8
        Me.Label119.Text = "Profesión"
        Me.Label119.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.SystemColors.Info
        Me.txtCedula.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(152, 40)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(96, 18)
        Me.txtCedula.TabIndex = 7
        '
        'Label120
        '
        Me.Label120.Location = New System.Drawing.Point(102, 36)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(48, 23)
        Me.Label120.TabIndex = 6
        Me.Label120.Text = "Cédula"
        Me.Label120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.SystemColors.Info
        Me.txtEdad.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(56, 40)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(40, 18)
        Me.txtEdad.TabIndex = 5
        '
        'Label121
        '
        Me.Label121.Location = New System.Drawing.Point(12, 36)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(40, 23)
        Me.Label121.TabIndex = 4
        Me.Label121.Text = "Edad"
        Me.Label121.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.BackColor = System.Drawing.SystemColors.Info
        Me.txtFechaNacimiento.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(592, 8)
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.ReadOnly = True
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(128, 18)
        Me.txtFechaNacimiento.TabIndex = 3
        '
        'Label122
        '
        Me.Label122.Location = New System.Drawing.Point(496, 4)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(96, 23)
        Me.Label122.TabIndex = 2
        Me.Label122.Text = "Fecha Nacimiento"
        Me.Label122.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombrePaciente.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePaciente.Location = New System.Drawing.Point(56, 8)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.ReadOnly = True
        Me.txtNombrePaciente.Size = New System.Drawing.Size(432, 18)
        Me.txtNombrePaciente.TabIndex = 1
        '
        'Label123
        '
        Me.Label123.Location = New System.Drawing.Point(12, 4)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(48, 23)
        Me.Label123.TabIndex = 0
        Me.Label123.Text = "Nombre"
        Me.Label123.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label125
        '
        Me.Label125.Location = New System.Drawing.Point(4, 5)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(192, 23)
        Me.Label125.TabIndex = 5
        Me.Label125.Text = "Datos Personales"
        Me.Label125.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Location = New System.Drawing.Point(4, 133)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(776, 264)
        Me.TabControl2.TabIndex = 8
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtAntFamiliares)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(768, 238)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Familiares"
        '
        'txtAntFamiliares
        '
        Me.txtAntFamiliares.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntFamiliares.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntFamiliares.Location = New System.Drawing.Point(0, 8)
        Me.txtAntFamiliares.Multiline = True
        Me.txtAntFamiliares.Name = "txtAntFamiliares"
        Me.txtAntFamiliares.ReadOnly = True
        Me.txtAntFamiliares.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntFamiliares.Size = New System.Drawing.Size(772, 224)
        Me.txtAntFamiliares.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtAntPersonales)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(768, 238)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Personales"
        Me.TabPage5.Visible = False
        '
        'txtAntPersonales
        '
        Me.txtAntPersonales.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntPersonales.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntPersonales.Location = New System.Drawing.Point(0, 7)
        Me.txtAntPersonales.Multiline = True
        Me.txtAntPersonales.Name = "txtAntPersonales"
        Me.txtAntPersonales.ReadOnly = True
        Me.txtAntPersonales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntPersonales.Size = New System.Drawing.Size(772, 224)
        Me.txtAntPersonales.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.txtAntGinecologicos)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(768, 238)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Ginecológicos"
        Me.TabPage6.Visible = False
        '
        'txtAntGinecologicos
        '
        Me.txtAntGinecologicos.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntGinecologicos.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntGinecologicos.Location = New System.Drawing.Point(0, 7)
        Me.txtAntGinecologicos.Multiline = True
        Me.txtAntGinecologicos.Name = "txtAntGinecologicos"
        Me.txtAntGinecologicos.ReadOnly = True
        Me.txtAntGinecologicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntGinecologicos.Size = New System.Drawing.Size(772, 224)
        Me.txtAntGinecologicos.TabIndex = 1
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.txtAntObstetricos)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(768, 238)
        Me.TabPage7.TabIndex = 3
        Me.TabPage7.Text = "Obstétricos"
        Me.TabPage7.Visible = False
        '
        'txtAntObstetricos
        '
        Me.txtAntObstetricos.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntObstetricos.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntObstetricos.Location = New System.Drawing.Point(0, 7)
        Me.txtAntObstetricos.Multiline = True
        Me.txtAntObstetricos.Name = "txtAntObstetricos"
        Me.txtAntObstetricos.ReadOnly = True
        Me.txtAntObstetricos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntObstetricos.Size = New System.Drawing.Size(772, 224)
        Me.txtAntObstetricos.TabIndex = 1
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.txtAntQuirurgicos)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(768, 238)
        Me.TabPage8.TabIndex = 4
        Me.TabPage8.Text = "Quirúrgicos"
        Me.TabPage8.Visible = False
        '
        'txtAntQuirurgicos
        '
        Me.txtAntQuirurgicos.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntQuirurgicos.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntQuirurgicos.Location = New System.Drawing.Point(0, 7)
        Me.txtAntQuirurgicos.Multiline = True
        Me.txtAntQuirurgicos.Name = "txtAntQuirurgicos"
        Me.txtAntQuirurgicos.ReadOnly = True
        Me.txtAntQuirurgicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntQuirurgicos.Size = New System.Drawing.Size(772, 224)
        Me.txtAntQuirurgicos.TabIndex = 1
        '
        'Label124
        '
        Me.Label124.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label124.Image = CType(resources.GetObject("Label124.Image"), System.Drawing.Image)
        Me.Label124.Location = New System.Drawing.Point(24, 405)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(728, 24)
        Me.Label124.TabIndex = 9
        Me.Label124.Text = "Para modificar o agregar datos selecciona Datos Personales de la lista de element" &
    "os de la Historia... "
        Me.Label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDocument1
        '
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
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuCalculaEGconECO, Me.menuCalculaEGconFUR, Me.menuCalculaDCconFUR})
        Me.MenuItem1.Text = "Herramientas"
        '
        'menuCalculaEGconECO
        '
        Me.menuCalculaEGconECO.Index = 0
        Me.menuCalculaEGconECO.Text = "Cálculo de EG en Base a un ECO"
        '
        'menuCalculaEGconFUR
        '
        Me.menuCalculaEGconFUR.Index = 1
        Me.menuCalculaEGconFUR.Text = "Cálculo de EG en Base a la FUR"
        '
        'menuCalculaDCconFUR
        '
        Me.menuCalculaDCconFUR.Index = 2
        Me.menuCalculaDCconFUR.Text = "Cálculo del Día del Ciclo en Base a la FUR"
        '
        'MainMenu2
        '
        Me.MainMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Herramientas"
        '
        'MainMenu3
        '
        Me.MainMenu3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3})
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Herramientas"
        '
        'MainMenu5
        '
        Me.MainMenu5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4})
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5})
        Me.MenuItem4.Text = "Herramientas"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Calcula"
        '
        'botSalirSinGuardar
        '
        Me.botSalirSinGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSalirSinGuardar.Image = CType(resources.GetObject("botSalirSinGuardar.Image"), System.Drawing.Image)
        Me.botSalirSinGuardar.Location = New System.Drawing.Point(12, 612)
        Me.botSalirSinGuardar.Name = "botSalirSinGuardar"
        Me.botSalirSinGuardar.Size = New System.Drawing.Size(224, 23)
        Me.botSalirSinGuardar.TabIndex = 5
        Me.botSalirSinGuardar.Text = "Salir"
        '
        'botGuardarNuevosDatos
        '
        Me.botGuardarNuevosDatos.Enabled = False
        Me.botGuardarNuevosDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botGuardarNuevosDatos.Image = CType(resources.GetObject("botGuardarNuevosDatos.Image"), System.Drawing.Image)
        Me.botGuardarNuevosDatos.Location = New System.Drawing.Point(754, 612)
        Me.botGuardarNuevosDatos.Name = "botGuardarNuevosDatos"
        Me.botGuardarNuevosDatos.Size = New System.Drawing.Size(224, 23)
        Me.botGuardarNuevosDatos.TabIndex = 6
        Me.botGuardarNuevosDatos.Text = "Guardar Datos y Continúar Editando"
        '
        'botGuardarYsalir
        '
        Me.botGuardarYsalir.Enabled = False
        Me.botGuardarYsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botGuardarYsalir.Image = CType(resources.GetObject("botGuardarYsalir.Image"), System.Drawing.Image)
        Me.botGuardarYsalir.Location = New System.Drawing.Point(524, 612)
        Me.botGuardarYsalir.Name = "botGuardarYsalir"
        Me.botGuardarYsalir.Size = New System.Drawing.Size(224, 23)
        Me.botGuardarYsalir.TabIndex = 7
        Me.botGuardarYsalir.Text = "Guardar Datos y Salir"
        '
        'labCambios
        '
        Me.labCambios.BackColor = System.Drawing.Color.LightGreen
        Me.labCambios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labCambios.ForeColor = System.Drawing.Color.Black
        Me.labCambios.Location = New System.Drawing.Point(242, 612)
        Me.labCambios.Name = "labCambios"
        Me.labCambios.Size = New System.Drawing.Size(276, 23)
        Me.labCambios.TabIndex = 8
        Me.labCambios.Text = "Cambios Guardados"
        Me.labCambios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkMedidasUsuales
        '
        Me.chkMedidasUsuales.AutoSize = True
        Me.chkMedidasUsuales.Location = New System.Drawing.Point(20, 203)
        Me.chkMedidasUsuales.Name = "chkMedidasUsuales"
        Me.chkMedidasUsuales.Size = New System.Drawing.Size(179, 17)
        Me.chkMedidasUsuales.TabIndex = 79
        Me.chkMedidasUsuales.Text = "Incluye solo las medidas usuales"
        Me.chkMedidasUsuales.UseVisualStyleBackColor = True
        '
        'FormControlEcografico2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(990, 647)
        Me.Controls.Add(Me.labCambios)
        Me.Controls.Add(Me.botGuardarYsalir)
        Me.Controls.Add(Me.botSalirSinGuardar)
        Me.Controls.Add(Me.botGuardarNuevosDatos)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "FormControlEcografico2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes Ecográficos"
        Me.TabControl1.ResumeLayout(False)
        Me.TP01.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP02.ResumeLayout(False)
        Me.TP02.PerformLayout()
        Me.PanelNuevoControl1erT.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox56.ResumeLayout(False)
        Me.GroupBox55.ResumeLayout(False)
        Me.GroupBox40.ResumeLayout(False)
        Me.GroupBox54.ResumeLayout(False)
        Me.GroupBox42.ResumeLayout(False)
        Me.GroupBox41.ResumeLayout(False)
        Me.GroupBox39.ResumeLayout(False)
        Me.GroupBox38.ResumeLayout(False)
        Me.GroupBox33.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelNuevoControlGinecologico.ResumeLayout(False)
        Me.TabControl5.ResumeLayout(False)
        Me.TabGinBiometricos.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox47.ResumeLayout(False)
        Me.GroupBox47.PerformLayout()
        Me.GroupBox45.ResumeLayout(False)
        Me.GroupBox45.PerformLayout()
        Me.GroupBox46.ResumeLayout(False)
        Me.GroupBox46.PerformLayout()
        Me.TabGinVejiga.ResumeLayout(False)
        Me.GroupBox59.ResumeLayout(False)
        Me.GroupBox59.PerformLayout()
        Me.GroupBox58.ResumeLayout(False)
        Me.GroupBox57.ResumeLayout(False)
        Me.GroupBox62.ResumeLayout(False)
        Me.TabGinUtero.ResumeLayout(False)
        Me.GroupBox67.ResumeLayout(False)
        Me.GroupBox67.PerformLayout()
        Me.GroupBox61.ResumeLayout(False)
        Me.GroupBox66.ResumeLayout(False)
        Me.GroupBox65.ResumeLayout(False)
        Me.GroupBox64.ResumeLayout(False)
        Me.GroupBox63.ResumeLayout(False)
        Me.GroupBox60.ResumeLayout(False)
        Me.TabGinOvarios.ResumeLayout(False)
        Me.GroupBox70.ResumeLayout(False)
        Me.GroupBox71.ResumeLayout(False)
        Me.GroupBox71.PerformLayout()
        Me.GroupBox68.ResumeLayout(False)
        Me.GroupBox69.ResumeLayout(False)
        Me.GroupBox69.PerformLayout()
        Me.TabGinOtros.ResumeLayout(False)
        Me.GroupBox73.ResumeLayout(False)
        Me.GroupBox73.PerformLayout()
        Me.GroupBox72.ResumeLayout(False)
        Me.GroupBox72.PerformLayout()
        Me.TabIDxGin.ResumeLayout(False)
        Me.GroupBox49.ResumeLayout(False)
        Me.GroupBox49.PerformLayout()
        Me.GroupBox44.ResumeLayout(False)
        Me.GroupBox44.PerformLayout()
        Me.PanelNuevoControl2y3erT.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
        Me.TabPageObstetricos.ResumeLayout(False)
        Me.GroupBox51.ResumeLayout(False)
        Me.GroupBox51.PerformLayout()
        Me.GroupBox50.ResumeLayout(False)
        Me.GroupBox50.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.TabPageBiometricos.ResumeLayout(False)
        Me.TabPageBiometricos.PerformLayout()
        Me.TabPageAnatomicos.ResumeLayout(False)
        Me.GroupBox53.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox52.ResumeLayout(False)
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.TabPageFuncionales.ResumeLayout(False)
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox31.ResumeLayout(False)
        Me.GroupBox32.ResumeLayout(False)
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox26.ResumeLayout(False)
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        Me.TabPagePlacentarios.ResumeLayout(False)
        Me.GroupBox37.ResumeLayout(False)
        Me.GroupBox36.ResumeLayout(False)
        Me.GroupBox36.PerformLayout()
        Me.GroupBox35.ResumeLayout(False)
        Me.GroupBox35.PerformLayout()
        Me.GroupBox34.ResumeLayout(False)
        Me.TabPageNotas.ResumeLayout(False)
        Me.TabPageNotas.PerformLayout()
        Me.TabPageIDx.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox43.ResumeLayout(False)
        Me.GroupBox43.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TP03.ResumeLayout(False)
        Me.TP03.PerformLayout()
        Me.PanelImpresion.ResumeLayout(False)
        Me.PanelImpresion.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP04.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    'variables para el chorizo de datos biometricos adicionales
    Dim ParteDelChorizo(15) As String 'es una coleccion donde se guardaran los 16 datos del 0 al 15
    Dim ChorizoBiometrico As String     'es el chorizo constituido

    Dim Cont As Integer 'contador para las partes del chorizo

    Dim ParteDelChorizoDX(10) As String  'cada uina de lkas partes del chorizo dx
    Dim ChorizoDiagnostico As String 'strin constituido por todos los idx y sg encadenados

    Dim ParteChorizo1erT(15) As String 'adicionales del 1er trimestre son menos pero puse 15
    Dim ParteChorizoB1erT(15) As String 'partes del 2do chorizo
    Dim Chorizo1erT As String 'chorizo constituido del adicionales del 1er t
    Dim ChorizoB1erT As String '2do chorizo constituido

    Dim ParteChorizoDX1erT(15) As String  'partes del chorizo dx del 1er t
    Dim ChorizoDX1erT As String  'chorizo dx constituido del 1ert

    Dim ParteChorizoGIN(35) As String  'partes del chorizo adicional ginecologico
    Dim ChorizoGIN As String 'chorizo ginecologico adicional constituido en una sola cadena

    Dim R As New Form1.TablaDeDatosEcograficos()
    Dim arrayEcosDelPacienteSeleccionado As New ArrayList() ' aqui guardare las R's
    'variable para la lista ordenada de fechas
    Dim ArraydeFechasOrdenadas As New ArrayList()
    'esta variable guarda el nombre de la historia #his.his actualmente usada
    Dim NombreHistoria As String
    'esta guarda el nombredel control ecografico actual
    Dim NombreControlEcografico As String
    'aca el nombre del archivo de los datos personales
    Dim NombreDatosPersonales As String

    Dim DatosModificados As Boolean = False
    'NuevoEco es una variable para saber cuando se esta creando un nuevo control para un nuevo embarazo
    Dim NuevoEco As Boolean = False

    Structure strImagenesEcograficas
        Dim FechaEcografia As String
        Dim Descripcion As String
        'porsia vamos a dejarle un recovequito
        Dim x1 As String
        Dim x2 As String
        Dim x3 As String
    End Structure

    Dim I As New strImagenesEcograficas()
    Dim arraylistImagenes As New ArrayList()

    'Dim FUR As Date
    Dim dateFechaInicioInformeSeleccionado As Date
    Dim strFechaInicioInformeSeleccionadoSDS As String
    Dim strFechaInicioInformeSeleccionadoSystemDate As String
    Dim NombreInforme As String
    Dim MSG As MsgBoxResult
    Dim Mensaje As String

    'estas las utilizo en las cosas del 1er trimestre
    Dim EGxSGenDias As Integer
    Dim EGxLCCenDias As Integer
    Dim EGxECO1erTenDias As Integer

    'estas son del 2 y 3er trimestre
    Dim EGxDBPenDias As Integer
    'Dim EGxDBPcenDias As Integer
    Dim EGxCCenDias As Integer
    Dim EGxCAenDias As Integer
    Dim EGxFEMURenDias As Integer
    Dim EGxTIBIAenDias As Integer
    Dim EGxHUMEROenDias As Integer

    Dim EGxECO2y3erTenDias As Integer


    'estas tres variables las uso como funcion para devolver semanas y dias de un numero de dias
    Dim NumeroDiasEG As Integer
    Dim TextoDeEGenSemanasyDiasLargo As String
    Dim TextoDeEGenSemanasyDiasCorto As String
    Dim TextoDeFPP As String

    'esta variable es para saber cual es el texto que se utiliza para calcular las EG de los controles sucesivos
    Dim FechaParaVerificar As String
    Dim ResultadoEG As String
    Dim RespaldodeFUR As String

    Dim TablaSG(70) As Integer
    Dim TablaLCC(100) As Integer
    Dim TablaDBP(120) As Integer
    Dim TablaCC(80) As Integer
    Dim TablaCA(80) As Integer
    Dim TablaFemur(100) As Integer
    Dim TablaTibia(75) As Integer
    Dim TablaHumero(75) As Integer
    Dim TablaUlna(75) As Integer
    Dim TablaLongitudFetaL(100) As Integer

    'variables para las fotos de ecografias
    Dim NombreBaseFotos As String
    Dim NombreBaseFotosInicio As String
    Dim NumerodeFotosNuevas As Integer
    Public Shared NombreImagen As String
    Public Shared MSGdescripcion As String
    Public Shared MSGfechaImagen As String
    Dim ArchivoFotoOrigen As String

    'variables para el proceso de impresion en bitmap
    Dim Fondo As Graphics
    Dim BMP As Bitmap
    Dim BMP2 As Bitmap
    Dim Gr As Graphics

    'variables para la impresion (la mayoria en el procedimiento)
    Dim booImprimeMembrete As Boolean
    Dim LineasPorPagina As Integer
    Dim NumerodePaginas As Integer
    Dim IniciodeRecipeX, IniciodeRecipeY As Integer
    Dim FindeRecipeX, FindeRecipeY As Integer
    Dim AnchodeRecipe, AltodeRecipe As Integer
    Dim LineaImpresa(1000) As String
    Dim altoenPixels As Integer

    'variables de imagen para los botones
    Dim BotonOn As Image
    Dim BotonOff As Image
    Dim BotonOnGrande As Image
    Dim BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim BarraMensajeBien As Image
    Dim BarraMensajeMal As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image
    Dim BotoncitoOn As Image
    Dim BotoncitoOFF As Image
    Dim FlechitaArribaOFF, FlechitaArribaON As Image
    Dim FlechitaAbajoOFF, FlechitaAbajoON As Image




    Private Sub FormControlEcografico2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ConstruyeNombresArchivos()
        InicializaDatos()
        MuestraDatosPersonales()
        MuestraControlEcografico()
        MuestraImagenesEcograficas()

        DepuraCarpetaDeImagenes()

        'para los ecos automaticos desde control obstetrico
        If Form1.booSeCargoDesdeControlObs = True Then

            AbreEdicionDeInformeAutomaticamente()

        End If 'si se carga desde control obs


    End Sub

    Private Sub ConstruyeNombresArchivos()
        'construye el nombre de la historia actual
        NombreHistoria = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & ".his"
        'construye el nombre del control ecografico acual
        NombreControlEcografico = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Control Ecográfico.dat"
        'contruye el nombre del archivo con los datos personales
        NombreDatosPersonales = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Datos Personales.dat"
        'construye el nombre base de las fotos para la historia seleccionada
        NombreBaseFotosInicio = Form1.PathImagenes & "\" & Form1.PSstrNumeroHistoriaSeleccionada
        'construye el nombre del indice de las imagenes
        NombreBaseFotos = Form1.PathImagenes & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Imágenes.dat"

        'pone tamaño de la ventana
        Me.Size = New System.Drawing.Size(1000, 700)
        'le pone nombre al titulo
        Me.Text = "Informes Ecográficos de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"

        'crea el directorio de destino si no existe
        If Directory.Exists(Form1.PathImagenes) = False Then
            Directory.CreateDirectory(Form1.PathImagenes)
        End If

        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff

    End Sub

    Private Sub InicializaDatos()
        BorraDatosEnPantalla()
        BorraEstructura()
        CargaTablas()

        botNuevo.Enabled = True
        botSelecciona.Enabled = False
        botRenombra.Enabled = False
        botElimina.Enabled = False
        ListBoxInformes.Enabled = True

        botNuevaImagen.Enabled = True
        botAbreImagen.Enabled = False
        botRenombraImagen.Enabled = False
        botEliminaImagen.Enabled = False

        DatosModificados = False
        botGuardarNuevosDatos.Enabled = False
        botGuardarYsalir.Enabled = False
        botSalirSinGuardar.Enabled = True
        botSalirSinGuardar.Text = "Salir"

        labCambios.Text = "Cambios Guardados"
        labCambios.BackColor = Color.LightGreen

        'inicialmente coloca q se imprima el mebrete
        chkImprimeMembrete.Checked = True
        'inicialmente coloca q se incluyan solo los datos usuales en la biometria
        chkMedidasUsuales.Checked = True


        NuevoEco = False

        'borra controles anteriores
        ListBoxInformes.Items.Clear()

        'oculta los paneles de nuevos datos
        PanelNuevoControl1erT.Visible = False
        PanelNuevoControl2y3erT.Visible = False
        PanelNuevoControlGinecologico.Visible = False
        PanelImpresion.Visible = False

        'los situa en su sitio pero ocultos
        Me.PanelNuevoControl1erT.Location = New System.Drawing.Point(0, 32)
        Me.PanelNuevoControl2y3erT.Location = New System.Drawing.Point(0, 32)
        Me.PanelNuevoControlGinecologico.Location = New System.Drawing.Point(0, 32)
        'con la linea apagada de abajo le podría cambiar el tamaño si hace falta
        'Me.PanelNuevoControl1erT.Size = New System.Drawing.Size(720, 424)
    End Sub
    Private Sub BorraDatosEnPantalla()
        'los datos principales de arriba
        labInforme.Text = ""
        txtFechaInicioControl.Text = ""
        labInforme2.Text = ""
        txtFechaInicioControl2.Text = ""
        '===============================
        '= los datos del 1er trimestre =
        '===============================
        'Identificacion
        labNombre1erT.Text = ""
        txtEdad1erT.Text = ""
        txtParidad1erT.Clear()
        labFechaControl1erT.Text = ""
        labFUR1erT.Text = ""
        labFPP1erT.Text = ""
        lab1ertEGxFUR01.Text = ""
        'Biometria
        txt1erSGlong.Clear()
        txt1erSGantPost.Clear()
        txt1erSGtrans.Clear()
        txt1erVVlong.Clear()
        txt1erVVantPost.Clear()
        lab1erSGprom.Text = ""
        lab1erEGxSG.Text = ""
        txt1erLCC.Clear()
        lab1erEGxLCC.Text = ""
        txt1erDBP.Clear()
        txt1erCC.Clear()
        txt1erCA.Clear()
        txt1erFemur.Clear()
        txt1erTN.Clear()
        lab1erEGxDBP.Text = ""
        lab1erEGxCC.Text = ""
        lab1erEGxCA.Text = ""
        lab1erEGxFemur.Text = ""
        'resetea los radiobuttons Anatomicos y funcionales
        rad1erTVejiga01.Checked = False
        rad1erTVejiga02.Checked = False
        rad1erTtipoEmbarazo01.Checked = False
        rad1erTtipoEmbarazo02.Checked = False
        rad1erTLocalizacionEmbarazo01.Checked = False
        rad1erTlocalizacionEmbarazo02.Checked = False
        Rad1erTImplantacion1.Checked = False
        Rad1erTImplantacion2.Checked = False
        Rad1erTImplantacion3.Checked = False
        Rad1erTImplantacion4.Checked = False
        rad1erTsacoGestacional01.Checked = False
        rad1erTsacoGestacional02.Checked = False
        rad1erTVitelina01.Checked = False
        rad1erTVitelina02.Checked = False
        Rad1erTEmbrion1.Checked = False
        Rad1erTEmbrion2.Checked = False
        Rad1erTMovimientos1.Checked = False
        Rad1erTMovimientos2.Checked = False
        Rad1erTActCardiaca1.Checked = False
        Rad1erTActCardiaca2.Checked = False
        'perinatales
        rad1erTtranslucencia01.Checked = False
        rad1erTtranslucencia02.Checked = False
        rad1erThuesosNasales01.Checked = False
        rad1erThuesosNasales02.Checked = False
        rad1erTductusVenoso01.Checked = False
        rad1erTductusVenoso02.Checked = False
        rad1erTanguloFM01.Checked = False
        rad1erTanguloFM02.Checked = False
        'comentarios y diagnosticos
        lab1ertEGxFUR02.Text = ""
        txt1erEGxECO.Text = ""
        txt1erTComentarios01.Clear()
        txt1erTcomentarios02.Clear()
        txt1erTcomentarios03.Clear()
        txt1erTcomentarios04.Clear()
        txt1erTcomentarios05.Clear()
        txt1erTidx01.Clear()
        txt1erTidx02.Clear()
        txt1erTidx03.Clear()
        '=====================================
        '= los datos del 2do y 3er trimestre =
        '=====================================
        'Identificacion
        labNombre2y3erT.Text = ""
        txtEdad2y3erT.Text = ""
        txtParidad2y3erT.Clear()
        labFechaControl2y3erT.Text = ""
        labFUR2y3erT.Text = ""
        labFPP2y3erT.Text = ""
        labEGxFUR2y3erT.Text = ""
        'obstetricos
        radEmbarazo01.Checked = True
        radFeto01.Checked = True
        radPresentacion1.Checked = True
        radPosicion1.Checked = True
        radSituacion1.Checked = True
        'anatomicos
        radCabeza1.Checked = True
        radVentriculo1.Checked = True
        radRostro1.Checked = True
        radColumna1.Checked = True
        radExtremidades1.Checked = True
        radTorax1.Checked = True
        radCorazon1.Checked = True
        radAbdomen1.Checked = True
        radRiñones1.Checked = True
        radSexo1.Checked = False
        radSexo2.Checked = False
        'biometricas
        txtDBP.Clear()
        txtDOF.Clear()
        txtCC.Clear()
        txtTCer.Clear()
        txtAtrio.Clear()
        txtIOE.Clear()
        txtIOI.Clear()
        txtPN.Clear()
        txtAPT.Clear()
        txtAPC.Clear()
        txtAorta.Clear()
        txtTransAbdomen.Clear()
        txtCA.Clear()
        txtFemur.Clear()
        txtTibia.Clear()
        txtHumero.Clear()
        txtUlna.Clear()
        txtSacro.Clear()
        txtNODF.Clear()
        txtNOPT.Clear()
        txtNOPH.Clear()
        txtBPF.Clear()
        txtPeso.Clear()
        txtTalla.Clear()
        lab2y3egxDBP.Text = ""
        lab2y3egxCC.Text = ""
        lab2y3egxCA.Text = ""
        lab2y3egxFem.Text = ""

        'funcionales
        radActitud1.Checked = True
        radTono1.Checked = True
        radMovimientosFetales1.Checked = True
        radActividadCardiaca1.Checked = True
        radMovimientosRespiratorios1.Checked = True
        radAortoCava1.Checked = True
        radCamaraGastrica1.Checked = True
        radIntestino1.Checked = False
        radIntestino2.Checked = False
        radIntestino3.Checked = False
        radIntestino4.Checked = False
        radIntestino5.Checked = False
        radVejiga1.Checked = True
        'placentarias
        radPlacenta1.Checked = False
        radPlacenta2.Checked = False
        radPlacenta3.Checked = False
        radplacenta4.Checked = False
        radPlacenta5.Checked = False
        radPlacenta6.Checked = False
        radPlacenta7.Checked = False
        radPlacenta8.Checked = False
        txtPlacentaGrosor.Clear()
        radPlacentaGrado1.Checked = False
        radPlacentaGrado2.Checked = False
        radPlacentaGrado3.Checked = False
        radPlacentaGrado4.Checked = False
        radPlacentaGrado5.Checked = False
        radPlacentaGrado6.Checked = False
        radPlacentaGrado7.Checked = False
        radLiquidoAmniotico1.Checked = True
        txtILA.Clear()
        radCordon1.Checked = True
        'Notas
        txtNotas01del2y3erT.Clear()
        txtNotas02del2y3erT.Clear()
        txtNotas03del2y3erT.Clear()
        'impresion diagnostica
        txtIdx01del2y3erT.Clear()
        txtIdx02del2y3erT.Clear()
        txtIdx03del2y3erT.Clear()
        txtIdx04del2y3erT.Clear()
        txtIdx05del2y3erT.Clear()
        txtIDx06del2y3erT.Clear()
        txtIDx07del2y3erT.Clear()
        txtIDx08del2y3erT.Clear()
        txtSug01del2y3erT.Clear()
        txtSug02del2y3erT.Clear()
        txtSug03del2y3erT.Clear()

        '=======================
        '= Datos Ginecologicos =
        '=======================
        'Identificacion
        labNombreGinecologico.Text = ""
        labEdadGinecologico.Text = ""
        txtParidadGinecologico.Clear()
        labFechaControlGinecologico.Text = ""
        labFURginecologico.Text = ""
        labDiaCicloGinecologico.Text = ""

        'medidas
        radTipoEstudioGinecologico1.Checked = True
        txtUteroLongitudinal.Clear()
        txtUteroAnteroPosterior.Clear()
        txtUteroTransverso.Clear()
        txtUteroEndometrio.Clear()
        txtOvarioDerechoLongitudinal.Clear()
        txtOvarioDerechoAnteroPosterior.Clear()
        txtOvarioDerechoTransverso.Clear()
        txtOvarioIzquierdoLongitudinal.Clear()
        txtOvarioIzquierdoAnteroPosterior.Clear()
        txtOvarioIzquierdoTransverso.Clear()
        txtOvarioDerechoFoliculo1.Clear()
        txtOvarioDerechoFoliculo2.Clear()
        txtOvarioDerechoFoliculo3.Clear()
        txtOvarioDerechoFoliculo4.Clear()
        txtOvarioIzquierdoFoliculo1.Clear()
        txtOvarioIzquierdoFoliculo2.Clear()
        txtOvarioIzquierdoFoliculo3.Clear()
        txtOvarioIzquierdoFoliculo4.Clear()

        'Adicionales de la modificacion de agosto 2008
        RadGinVejigaVolumen1.Checked = False
        RadGinVejigaVolumen2.Checked = False
        RadGinVejigaVolumen3.Checked = False
        RadGinVejigaAdecuada1.Checked = False
        RadGinVejigaAdecuada2.Checked = False
        RadGinVejigaParedes1.Checked = False
        RadGinVejigaParedes2.Checked = False
        txtGinVejigaObservaciones1.Clear()
        txtGinVejigaObservaciones2.Clear()
        RadGinUteroPosicion1.Checked = False
        RadGinUteroPosicion2.Checked = False
        RadGinUteroPosicion3.Checked = False
        RadGinUteroInclinacion1.Checked = False
        RadGinUteroInclinacion2.Checked = False
        RadGinUteroInclinacion3.Checked = False
        RadGinUteroEcopatron1.Checked = False
        RadGinUteroEcopatron2.Checked = False
        RadGinUteroBordes1.Checked = False
        RadGinUteroBordes2.Checked = False
        RadGinUteroEndometrio1.Checked = False
        RadGinUteroEndometrio2.Checked = False
        RadGinUteroEndometrio3.Checked = False
        RadGinUteroEndometrio4.Checked = False
        RadGinUteroEndometrio5.Checked = False
        RadGinUteroCavidad1.Checked = False
        RadGinUteroCavidad2.Checked = False
        RadGinUteroCavidad3.Checked = False
        RadGinUteroCavidad4.Checked = False
        RadGinUteroCavidad5.Checked = False
        txtGinUteroObservaciones1.Clear()
        txtGinUteroObservaciones2.Clear()
        RadGinOvarioDerechoTamano1.Checked = False
        RadGinOvarioDerechoTamano2.Checked = False
        RadGinOvarioDerechoTamano3.Checked = False
        RadGinOvarioIzquierdoTamano1.Checked = False
        RadGinOvarioIzquierdoTamano2.Checked = False
        RadGinOvarioIzquierdoTamano3.Checked = False
        txtGinOvarioDerechoObservaciones1.Clear()
        txtGinOvarioDerechoObservaciones2.Clear()
        txtGinOvarioDerechoObservaciones3.Clear()
        txtGinOvarioDerechoObservaciones4.Clear()
        txtGinOvarioIzquierdoObservaciones1.Clear()
        txtGinOvarioIzquierdoObservaciones2.Clear()
        txtGinOvarioIzquierdoObservaciones3.Clear()
        txtGinOvarioIzquierdoObservaciones4.Clear()
        RadGinTrompas1.Checked = False
        RadGinTrompas2.Checked = False
        RadGinTrompas3.Checked = False
        RadGinTrompas4.Checked = False
        RadGinDouglas1.Checked = False
        RadGinDouglas2.Checked = False
        txtGinOtrosObservaciones1.Clear()
        txtGinOtrosObservaciones2.Clear()
        txtGinIDx1.Clear()
        txtGinIDx2.Clear()
        txtGinIDx3.Clear()
        txtGinIDx4.Clear()
        radGINfrec35.Checked = False
        radGINfrec50.Checked = False
        radGINfrec75.Checked = False
        '-------------------
        'fin
    End Sub
    Private Sub BorraEstructura()
        'comunes
        R.c00TipoDeEstudio = ""
        R.c01FechaControl = ""
        R.c02Paridad = ""
        R.c03FUR = ""
        R.c04FPP = ""
        R.c05EGxFUR = ""
        R.c06IDx = ""
        R.c07Nombre = ""
        R.c08Edad = ""
        '1er trimestre
        R.d01SGlongitudinal = ""
        R.d02SGanteroposterior = ""
        R.d03SGtransversal = ""
        R.d04LCC = ""
        R.d05ImplatacionSG = ""
        R.d06EmbrionVisible = ""
        R.d07MovimientosPresentes = ""
        R.d08ActividadCardiaca = ""
        R.d09Comentarios1erT = ""
        R.d10OtroA = ""
        R.d11AdicionalesB1erT = "@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@"
        R.d12IDxAdicionales1erT = "@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@"
        R.d13Adicionales1erT = "@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@"
        'calculos del 1er trimestre
        R.r01SGPromedio = ""
        R.r02EGxSG = ""
        R.r03EGxLCC = ""
        R.r04EG1erT = ""
        '2y3 er trimestre
        R.e01Presentacion = "1"
        R.e02Situacion = "1"
        R.e03Posicion = "1"
        R.e04Cabeza = "1"
        R.e05Ventriculos = "1"
        R.e06Columna = "1"
        R.e07Torax = "1"
        R.e08Corazon = "1"
        R.e09Abdomen = "1"
        R.e10Riñones = "1"
        R.e11Extremidades = "1"
        R.e12Notas01del2y3erT = ""
        R.e13DiametroBiParietal = ""
        R.e14DiametroOccipitoFrontal = ""
        R.e15DiametroAnteroPosteriorTorax = ""
        R.e16DiametroAnteroPosteriorCorazon = ""
        R.e17aDiametroAnteroPosteriorAbdomen = ""
        R.e17bDiametroTransversoAbdomen = ""
        R.e18Aorta = ""
        R.e19VenaCava = ""
        R.e20LongitudSacro = ""
        R.e21LongitudFemur = ""
        R.e22Actitud = "1"
        R.e23Tono = "1"
        R.e24MovimientosFetales = "1"
        R.e25ActividadCardiaca = "1"
        R.e26MovimientosRespiratorios = "1"
        R.e27RelacionAortoCava = "1"
        R.e28CamaraGastrica = "1"
        R.e29Intestino = "1"
        R.e30Vejiga = "1"
        R.e31Notas02del2y3erT = ""
        R.e32LocalizacionPlacenta = "1"
        R.e33GrosorPlacenta = ""
        R.e34GradoPlacenta = ""
        R.e35LiquidoAmniotico = "1"
        R.e36ILA = ""
        R.e37CordonUmbilical = "1"
        R.e38Notas03del2y3erT = ""
        R.e39Embarazo = "1"
        R.e40Feto = "1"
        R.e41BiometricosAdicionales = "@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@"
        R.e42Rostro = "1"
        R.e43Sexo = ""
        'calculos del 2y3 er trimestre
        R.r05DBPc = ""
        R.r06CirCef = ""
        R.r07IndCef = ""
        R.r08CirAbd = ""
        R.r09DBF = ""
        R.r10EGxDBP = ""
        R.r11EGxDBPc = ""
        R.r12EGxCC = ""
        R.r13EGxCA = ""
        R.r14EGxFemur = ""
        R.r15PesoEstimado = ""
        R.r16PesoenBaseA = "Peso Fetal Estimado (Faltan Datos)"
        R.r17EG2y3erT = ""
        'ginecologicos
        R.f01Menopausia = ""
        R.f02EstudioPorVia = "1"
        R.f03UteroLongitudinal = ""
        R.f04UteroAnteroposterior = ""
        R.f05UteroTransverso = ""
        R.f06OvarioDerechoLongitudinal = ""
        R.f07OvarioDerechoTransverso = ""
        R.f08OvarioDerechoAnteroPosterior = ""
        R.f09OvarioIzquierdoLongitudinal = ""
        R.f10OvarioIzquierdoTransverso = ""
        R.f11OvarioIzquierdoAnteroPosterior = ""
        R.f12FoliculoDerecho01 = ""
        R.f13FoliculoDerecho02 = ""
        R.f14FoliculoDerecho03 = ""
        R.f15FoliculoDerecho04 = ""
        R.f16FoliculoIzquierdo01 = ""
        R.f17FoliculoIzquierdo02 = ""
        R.f18FoliculoIzquierdo03 = ""
        R.f19FoliculoIzquierdo04 = ""
        R.f20EndometrioGrosor = ""
        R.f21ObsGinecologicas = ""
        R.f22OtrosA = ""
        R.f23OtrosB = ""
        R.f24OtrosC = ""
        R.f25AdicionalesGin = "@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@|@"
        'calculos ginecologicos
        R.r18DiaCiclo = ""
        'calculos adicionales porsia
        R.r19OtroA = ""
        R.r20OtroB = ""
        R.r21OtroC = ""
        R.e44ChorizoDiagnostico = "@|@|@|@|@|@|@|@|@|@|@"
        'adicionales usados
        R.c09NombreInforme = ""
    End Sub
    Private Sub CargaTablas()
        'variables locales
        Dim t As Integer

        'Tabla de Saco Gestacional -------------------------------------------
        For t = 0 To 70
            TablaSG(t) = 0
        Next
        TablaSG(10) = 33 : TablaSG(11) = 34 : TablaSG(12) = 35 : TablaSG(13) = 36
        TablaSG(14) = 37 : TablaSG(15) = 38 : TablaSG(16) = 39 : TablaSG(17) = 40
        TablaSG(18) = 41 : TablaSG(19) = 42 : TablaSG(20) = 43 : TablaSG(21) = 44
        TablaSG(22) = 45 : TablaSG(23) = 46 : TablaSG(24) = 47 : TablaSG(25) = 48
        TablaSG(26) = 49 : TablaSG(27) = 50 : TablaSG(28) = 51 : TablaSG(29) = 52
        TablaSG(30) = 53 : TablaSG(31) = 54 : TablaSG(32) = 55 : TablaSG(33) = 56
        TablaSG(34) = 57 : TablaSG(35) = 58 : TablaSG(36) = 58 : TablaSG(37) = 59
        TablaSG(38) = 60 : TablaSG(39) = 61 : TablaSG(40) = 62 : TablaSG(41) = 63
        TablaSG(42) = 64 : TablaSG(43) = 65 : TablaSG(44) = 66 : TablaSG(45) = 67
        TablaSG(46) = 68 : TablaSG(47) = 69 : TablaSG(48) = 70 : TablaSG(49) = 71
        TablaSG(50) = 72 : TablaSG(51) = 73 : TablaSG(52) = 74 : TablaSG(53) = 75
        TablaSG(54) = 76 : TablaSG(55) = 77 : TablaSG(56) = 78 : TablaSG(57) = 79
        TablaSG(58) = 80 : TablaSG(59) = 81 : TablaSG(60) = 82 : TablaSG(61) = 83
        TablaSG(62) = 84 : TablaSG(63) = 85 : TablaSG(64) = 86 : TablaSG(65) = 87

        'Tabla de longitus craneo caudal
        For t = 0 To 100
            TablaLCC(t) = 0
        Next
        TablaLCC(2) = 40 : TablaLCC(3) = 41 : TablaLCC(4) = 43 : TablaLCC(5) = 43
        TablaLCC(6) = 45 : TablaLCC(7) = 46 : TablaLCC(8) = 47 : TablaLCC(9) = 48
        TablaLCC(10) = 50 : TablaLCC(11) = 50 : TablaLCC(12) = 52 : TablaLCC(13) = 53
        TablaLCC(14) = 54 : TablaLCC(15) = 55 : TablaLCC(16) = 56 : TablaLCC(17) = 57
        TablaLCC(18) = 58 : TablaLCC(19) = 59 : TablaLCC(20) = 60 : TablaLCC(21) = 61
        TablaLCC(22) = 62 : TablaLCC(23) = 63 : TablaLCC(24) = 64 : TablaLCC(25) = 64
        TablaLCC(26) = 66 : TablaLCC(27) = 67 : TablaLCC(28) = 67 : TablaLCC(29) = 68
        TablaLCC(30) = 69 : TablaLCC(31) = 70 : TablaLCC(32) = 71 : TablaLCC(33) = 71
        TablaLCC(34) = 72 : TablaLCC(35) = 73 : TablaLCC(36) = 74 : TablaLCC(37) = 74
        TablaLCC(38) = 75 : TablaLCC(39) = 76 : TablaLCC(40) = 76 : TablaLCC(41) = 77
        TablaLCC(42) = 78 : TablaLCC(43) = 78 : TablaLCC(44) = 78 : TablaLCC(45) = 79
        TablaLCC(46) = 80 : TablaLCC(47) = 81 : TablaLCC(48) = 81 : TablaLCC(49) = 82
        TablaLCC(50) = 82 : TablaLCC(51) = 83 : TablaLCC(52) = 83 : TablaLCC(53) = 84
        TablaLCC(54) = 84 : TablaLCC(55) = 85 : TablaLCC(56) = 85 : TablaLCC(57) = 86
        TablaLCC(58) = 86 : TablaLCC(59) = 87 : TablaLCC(60) = 88 : TablaLCC(61) = 88
        TablaLCC(62) = 88 : TablaLCC(63) = 89 : TablaLCC(64) = 90 : TablaLCC(65) = 90
        TablaLCC(66) = 90 : TablaLCC(67) = 91 : TablaLCC(68) = 92 : TablaLCC(69) = 92
        TablaLCC(70) = 92 : TablaLCC(71) = 93 : TablaLCC(72) = 94 : TablaLCC(73) = 94
        TablaLCC(74) = 95 : TablaLCC(75) = 95 : TablaLCC(76) = 96 : TablaLCC(77) = 97
        TablaLCC(78) = 97 : TablaLCC(79) = 97 : TablaLCC(80) = 98

        'tabla dbp hadlock usa
        For t = 0 To 120
            TablaDBP(t) = 0
        Next
        TablaDBP(14) = 83 : TablaDBP(15) = 84 : TablaDBP(16) = 86 : TablaDBP(17) = 87
        TablaDBP(18) = 89 : TablaDBP(19) = 90 : TablaDBP(20) = 92 : TablaDBP(21) = 93
        TablaDBP(22) = 95 : TablaDBP(23) = 96 : TablaDBP(24) = 98 : TablaDBP(25) = 100
        TablaDBP(26) = 101 : TablaDBP(27) = 103 : TablaDBP(28) = 105 : TablaDBP(29) = 106
        TablaDBP(30) = 108 : TablaDBP(31) = 110 : TablaDBP(32) = 112 : TablaDBP(33) = 113
        TablaDBP(34) = 115 : TablaDBP(35) = 117 : TablaDBP(36) = 119 : TablaDBP(37) = 121
        TablaDBP(38) = 123 : TablaDBP(39) = 125 : TablaDBP(40) = 127 : TablaDBP(41) = 129
        TablaDBP(42) = 131 : TablaDBP(43) = 133 : TablaDBP(44) = 135 : TablaDBP(45) = 137
        TablaDBP(46) = 139 : TablaDBP(47) = 141 : TablaDBP(48) = 143 : TablaDBP(49) = 145
        TablaDBP(50) = 147 : TablaDBP(51) = 150 : TablaDBP(52) = 152 : TablaDBP(53) = 154
        TablaDBP(54) = 157 : TablaDBP(55) = 159 : TablaDBP(56) = 161 : TablaDBP(57) = 164
        TablaDBP(58) = 166 : TablaDBP(59) = 168 : TablaDBP(60) = 171 : TablaDBP(61) = 173
        TablaDBP(62) = 176 : TablaDBP(63) = 178 : TablaDBP(64) = 181 : TablaDBP(65) = 183
        TablaDBP(66) = 186 : TablaDBP(67) = 188 : TablaDBP(68) = 191 : TablaDBP(69) = 194
        TablaDBP(70) = 196 : TablaDBP(71) = 199 : TablaDBP(72) = 202 : TablaDBP(73) = 205
        TablaDBP(74) = 207 : TablaDBP(75) = 210 : TablaDBP(76) = 213 : TablaDBP(77) = 216
        TablaDBP(78) = 219 : TablaDBP(79) = 221 : TablaDBP(80) = 224 : TablaDBP(81) = 227
        TablaDBP(82) = 230 : TablaDBP(83) = 233 : TablaDBP(84) = 236 : TablaDBP(85) = 239
        TablaDBP(86) = 242 : TablaDBP(87) = 245 : TablaDBP(88) = 248 : TablaDBP(89) = 252
        TablaDBP(90) = 255 : TablaDBP(91) = 258 : TablaDBP(92) = 261 : TablaDBP(93) = 264
        TablaDBP(94) = 267 : TablaDBP(95) = 271 : TablaDBP(96) = 274 : TablaDBP(97) = 277
        TablaDBP(98) = 281 : TablaDBP(99) = 284 : TablaDBP(100) = 287 : TablaDBP(101) = 291
        TablaDBP(102) = 294 : TablaDBP(103) = 298

        'Tabla CC hadlock 1984 usa
        For t = 0 To 80
            TablaCC(t) = 0
        Next
        'ojo el numero entre parentesis es mm/5 porq la tabla tiene una precision de cada 5mm

        TablaCC(11) = 83 : TablaCC(12) = 85 : TablaCC(13) = 87 : TablaCC(14) = 89
        TablaCC(15) = 91 : TablaCC(16) = 94 : TablaCC(17) = 96 : TablaCC(18) = 98
        TablaCC(19) = 100 : TablaCC(20) = 102 : TablaCC(21) = 104 : TablaCC(22) = 107
        TablaCC(23) = 109 : TablaCC(24) = 111 : TablaCC(25) = 114 : TablaCC(26) = 116
        TablaCC(27) = 118 : TablaCC(28) = 121 : TablaCC(29) = 123 : TablaCC(30) = 126
        TablaCC(31) = 129 : TablaCC(32) = 131 : TablaCC(33) = 134 : TablaCC(34) = 137
        TablaCC(35) = 140 : TablaCC(36) = 143 : TablaCC(37) = 145 : TablaCC(38) = 148
        TablaCC(39) = 151 : TablaCC(40) = 155 : TablaCC(41) = 158 : TablaCC(42) = 161
        TablaCC(43) = 164 : TablaCC(44) = 168 : TablaCC(45) = 171 : TablaCC(46) = 175
        TablaCC(47) = 178 : TablaCC(48) = 182 : TablaCC(49) = 186 : TablaCC(50) = 190
        TablaCC(51) = 193 : TablaCC(52) = 197 : TablaCC(53) = 201 : TablaCC(54) = 206
        TablaCC(55) = 210 : TablaCC(56) = 214 : TablaCC(57) = 219 : TablaCC(58) = 223
        TablaCC(59) = 228 : TablaCC(60) = 232 : TablaCC(61) = 237 : TablaCC(62) = 242
        TablaCC(63) = 247 : TablaCC(64) = 252 : TablaCC(65) = 257 : TablaCC(66) = 262
        TablaCC(67) = 268 : TablaCC(68) = 273 : TablaCC(69) = 279 : TablaCC(70) = 285
        TablaCC(71) = 290 : TablaCC(72) = 296


        'tabla CA hadlock usa (lo mismo las unidades son mm/5
        For t = 0 To 80
            TablaCA(t) = 0
        Next
        TablaCA(10) = 84
        TablaCA(11) = 86 : TablaCA(12) = 89 : TablaCA(13) = 92 : TablaCA(14) = 95
        TablaCA(15) = 97 : TablaCA(16) = 100 : TablaCA(17) = 103 : TablaCA(18) = 106
        TablaCA(19) = 109 : TablaCA(20) = 112 : TablaCA(21) = 115 : TablaCA(22) = 118
        TablaCA(23) = 120 : TablaCA(24) = 123 : TablaCA(25) = 126 : TablaCA(26) = 129
        TablaCA(27) = 132 : TablaCA(28) = 135 : TablaCA(29) = 138 : TablaCA(30) = 141
        TablaCA(31) = 144 : TablaCA(32) = 147 : TablaCA(33) = 150 : TablaCA(34) = 153
        TablaCA(35) = 156 : TablaCA(36) = 160 : TablaCA(37) = 163 : TablaCA(38) = 166
        TablaCA(39) = 169 : TablaCA(40) = 172 : TablaCA(41) = 175 : TablaCA(42) = 178
        TablaCA(43) = 181 : TablaCA(44) = 185 : TablaCA(45) = 188 : TablaCA(46) = 191
        TablaCA(47) = 194 : TablaCA(48) = 198 : TablaCA(49) = 201 : TablaCA(50) = 204
        TablaCA(51) = 207 : TablaCA(52) = 211 : TablaCA(53) = 214 : TablaCA(54) = 217
        TablaCA(55) = 220 : TablaCA(56) = 224 : TablaCA(57) = 227 : TablaCA(58) = 231
        TablaCA(59) = 234 : TablaCA(60) = 237 : TablaCA(61) = 241 : TablaCA(62) = 244
        TablaCA(63) = 248 : TablaCA(64) = 251 : TablaCA(65) = 254 : TablaCA(66) = 258
        TablaCA(67) = 261 : TablaCA(68) = 265 : TablaCA(69) = 268 : TablaCA(70) = 272
        TablaCA(71) = 275 : TablaCA(72) = 279 : TablaCA(73) = 282 : TablaCA(74) = 286
        TablaCA(75) = 290 : TablaCA(76) = 293 : TablaCA(77) = 297

        'tabla Femur hadlock
        For t = 0 To 100
            TablaFemur(t) = 0
        Next

        TablaFemur(6) = 83 : TablaFemur(7) = 85 : TablaFemur(8) = 87 : TablaFemur(9) = 88
        TablaFemur(10) = 90 : TablaFemur(11) = 92 : TablaFemur(12) = 94 : TablaFemur(13) = 96
        TablaFemur(14) = 98 : TablaFemur(15) = 100 : TablaFemur(16) = 103 : TablaFemur(17) = 105
        TablaFemur(18) = 107 : TablaFemur(19) = 109 : TablaFemur(20) = 111 : TablaFemur(21) = 113
        TablaFemur(22) = 116 : TablaFemur(23) = 118 : TablaFemur(24) = 120 : TablaFemur(25) = 122
        TablaFemur(26) = 125 : TablaFemur(27) = 127 : TablaFemur(28) = 129 : TablaFemur(29) = 132
        TablaFemur(30) = 134 : TablaFemur(31) = 137 : TablaFemur(32) = 139 : TablaFemur(33) = 142
        TablaFemur(34) = 144 : TablaFemur(35) = 147 : TablaFemur(36) = 149 : TablaFemur(37) = 152
        TablaFemur(38) = 155 : TablaFemur(39) = 157 : TablaFemur(40) = 160 : TablaFemur(41) = 163
        TablaFemur(42) = 165 : TablaFemur(43) = 168 : TablaFemur(44) = 171 : TablaFemur(45) = 174
        TablaFemur(46) = 176 : TablaFemur(47) = 179 : TablaFemur(48) = 182 : TablaFemur(49) = 185
        TablaFemur(50) = 188 : TablaFemur(51) = 191 : TablaFemur(52) = 194 : TablaFemur(53) = 197
        TablaFemur(54) = 200 : TablaFemur(55) = 203 : TablaFemur(56) = 206 : TablaFemur(57) = 209
        TablaFemur(58) = 212 : TablaFemur(59) = 215 : TablaFemur(60) = 218 : TablaFemur(61) = 221
        TablaFemur(62) = 224 : TablaFemur(63) = 228 : TablaFemur(64) = 231 : TablaFemur(65) = 234
        TablaFemur(66) = 237 : TablaFemur(67) = 241 : TablaFemur(68) = 244 : TablaFemur(69) = 247
        TablaFemur(70) = 251 : TablaFemur(71) = 254 : TablaFemur(72) = 258 : TablaFemur(73) = 261
        TablaFemur(74) = 265 : TablaFemur(75) = 268 : TablaFemur(76) = 272 : TablaFemur(77) = 275
        TablaFemur(78) = 279 : TablaFemur(79) = 282 : TablaFemur(80) = 286 : TablaFemur(81) = 290
        TablaFemur(82) = 293 : TablaFemur(83) = 297

        'tabla Tibia hadlock
        For t = 0 To 75
            TablaTibia(t) = 0
        Next

        TablaTibia(12) = 98 : TablaTibia(13) = 100
        TablaTibia(14) = 103 : TablaTibia(15) = 105 : TablaTibia(16) = 108 : TablaTibia(17) = 112
        TablaTibia(18) = 114 : TablaTibia(19) = 117 : TablaTibia(20) = 119 : TablaTibia(21) = 122
        TablaTibia(22) = 126 : TablaTibia(23) = 128 : TablaTibia(24) = 131 : TablaTibia(25) = 133
        TablaTibia(26) = 136 : TablaTibia(27) = 140 : TablaTibia(28) = 142 : TablaTibia(29) = 145
        TablaTibia(30) = 147 : TablaTibia(31) = 150 : TablaTibia(32) = 154 : TablaTibia(33) = 156
        TablaTibia(34) = 159 : TablaTibia(35) = 161 : TablaTibia(36) = 164 : TablaTibia(37) = 168
        TablaTibia(38) = 170 : TablaTibia(39) = 173 : TablaTibia(40) = 175 : TablaTibia(41) = 178
        TablaTibia(42) = 182 : TablaTibia(43) = 185 : TablaTibia(44) = 189 : TablaTibia(45) = 192
        TablaTibia(46) = 196 : TablaTibia(47) = 199 : TablaTibia(48) = 203 : TablaTibia(49) = 206
        TablaTibia(50) = 210 : TablaTibia(51) = 213 : TablaTibia(52) = 217 : TablaTibia(53) = 220
        TablaTibia(54) = 224 : TablaTibia(55) = 231 : TablaTibia(56) = 234 : TablaTibia(57) = 238
        TablaTibia(58) = 245 : TablaTibia(59) = 248 : TablaTibia(60) = 252 : TablaTibia(61) = 259
        TablaTibia(62) = 262 : TablaTibia(63) = 266 : TablaTibia(64) = 273 : TablaTibia(65) = 276
        TablaTibia(66) = 280 : TablaTibia(67) = 287 : TablaTibia(68) = 294

        'tabla humero hadlock
        For t = 0 To 75
            TablaHumero(t) = 0
        Next

        TablaHumero(11) = 91 : TablaHumero(12) = 93 : TablaHumero(13) = 95
        TablaHumero(14) = 98 : TablaHumero(15) = 100 : TablaHumero(16) = 102 : TablaHumero(17) = 105
        TablaHumero(18) = 107 : TablaHumero(19) = 109 : TablaHumero(20) = 112 : TablaHumero(21) = 115
        TablaHumero(22) = 119 : TablaHumero(23) = 121 : TablaHumero(24) = 123 : TablaHumero(25) = 126
        TablaHumero(26) = 128 : TablaHumero(27) = 130 : TablaHumero(28) = 133 : TablaHumero(29) = 136
        TablaHumero(30) = 140 : TablaHumero(31) = 142 : TablaHumero(32) = 144 : TablaHumero(33) = 147
        TablaHumero(34) = 150 : TablaHumero(35) = 154 : TablaHumero(36) = 156 : TablaHumero(37) = 159
        TablaHumero(38) = 161 : TablaHumero(39) = 164 : TablaHumero(40) = 168 : TablaHumero(41) = 171
        TablaHumero(42) = 175 : TablaHumero(43) = 178 : TablaHumero(44) = 182 : TablaHumero(45) = 185
        TablaHumero(46) = 189 : TablaHumero(47) = 192 : TablaHumero(48) = 196 : TablaHumero(49) = 199
        TablaHumero(50) = 203 : TablaHumero(51) = 210 : TablaHumero(52) = 214 : TablaHumero(53) = 217
        TablaHumero(54) = 220 : TablaHumero(55) = 224 : TablaHumero(56) = 231 : TablaHumero(57) = 234
        TablaHumero(58) = 238 : TablaHumero(59) = 245 : TablaHumero(60) = 248 : TablaHumero(61) = 252
        TablaHumero(62) = 259 : TablaHumero(63) = 266 : TablaHumero(64) = 269 : TablaHumero(65) = 273
        TablaHumero(66) = 280 : TablaHumero(67) = 287 : TablaHumero(68) = 294

        'tabla longitudfetal hadlock (mm de femur)-> mm de talla
        For t = 0 To 100
            TablaLongitudFetaL(t) = 0
        Next

        TablaLongitudFetaL(10) = 144 : TablaLongitudFetaL(11) = 149 : TablaLongitudFetaL(12) = 155 : TablaLongitudFetaL(13) = 161
        TablaLongitudFetaL(14) = 167 : TablaLongitudFetaL(15) = 173 : TablaLongitudFetaL(16) = 179 : TablaLongitudFetaL(17) = 185
        TablaLongitudFetaL(18) = 191 : TablaLongitudFetaL(19) = 197 : TablaLongitudFetaL(20) = 203 : TablaLongitudFetaL(21) = 208
        TablaLongitudFetaL(22) = 214 : TablaLongitudFetaL(23) = 220 : TablaLongitudFetaL(24) = 226 : TablaLongitudFetaL(25) = 232
        TablaLongitudFetaL(26) = 238 : TablaLongitudFetaL(27) = 243 : TablaLongitudFetaL(28) = 251 : TablaLongitudFetaL(29) = 256
        TablaLongitudFetaL(30) = 261 : TablaLongitudFetaL(31) = 269 : TablaLongitudFetaL(32) = 274 : TablaLongitudFetaL(33) = 279
        TablaLongitudFetaL(34) = 287 : TablaLongitudFetaL(35) = 292 : TablaLongitudFetaL(36) = 304 : TablaLongitudFetaL(37) = 309
        TablaLongitudFetaL(38) = 315 : TablaLongitudFetaL(39) = 320 : TablaLongitudFetaL(40) = 327 : TablaLongitudFetaL(41) = 332
        TablaLongitudFetaL(42) = 337 : TablaLongitudFetaL(43) = 345 : TablaLongitudFetaL(44) = 350 : TablaLongitudFetaL(45) = 358
        TablaLongitudFetaL(46) = 363 : TablaLongitudFetaL(47) = 368 : TablaLongitudFetaL(48) = 375 : TablaLongitudFetaL(49) = 381
        TablaLongitudFetaL(50) = 386 : TablaLongitudFetaL(51) = 391 : TablaLongitudFetaL(52) = 398 : TablaLongitudFetaL(53) = 403
        TablaLongitudFetaL(54) = 408 : TablaLongitudFetaL(55) = 416 : TablaLongitudFetaL(56) = 421 : TablaLongitudFetaL(57) = 429
        TablaLongitudFetaL(58) = 434 : TablaLongitudFetaL(59) = 436 : TablaLongitudFetaL(60) = 439 : TablaLongitudFetaL(61) = 444
        TablaLongitudFetaL(62) = 452 : TablaLongitudFetaL(63) = 457 : TablaLongitudFetaL(64) = 462 : TablaLongitudFetaL(65) = 469
        TablaLongitudFetaL(66) = 475 : TablaLongitudFetaL(67) = 480 : TablaLongitudFetaL(68) = 487 : TablaLongitudFetaL(69) = 492
        TablaLongitudFetaL(70) = 497 : TablaLongitudFetaL(71) = 502 : TablaLongitudFetaL(72) = 510 : TablaLongitudFetaL(73) = 515
        TablaLongitudFetaL(74) = 523 : TablaLongitudFetaL(75) = 528 : TablaLongitudFetaL(76) = 533 : TablaLongitudFetaL(77) = 541
        TablaLongitudFetaL(78) = 546 : TablaLongitudFetaL(79) = 551 : TablaLongitudFetaL(80) = 556 : TablaLongitudFetaL(81) = 563
        TablaLongitudFetaL(82) = 569 : TablaLongitudFetaL(83) = 572
    End Sub

    Private Sub MuestraDatosPersonales()
        Dim FS As FileStream
        Dim BR As BinaryReader

        'carga los datos personales almacenados
        FS = New FileStream(NombreDatosPersonales, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim H As New Form1.DatosPersonales()

        H = Nothing
        ' Read fields and populate structure
        H.a01Nombre = BR.ReadString
        H.FechaNacimiento = BR.ReadString
        H.Edad = BR.ReadString
        H.Cedula = BR.ReadString
        H.Profesion = BR.ReadString
        H.Telefono = BR.ReadString
        H.AntecedentesFamiliares = BR.ReadString
        H.AntecedentesPersonales = BR.ReadString
        H.AntecedentesGinecologicos = BR.ReadString
        H.AntecedentesObstetricos = BR.ReadString
        H.AntecedentesQuirurgicos = BR.ReadString
        H.x01DireccionDeHabitacion = BR.ReadString
        H.x02GradoDeInstruccion = BR.ReadString
        H.x03Religion = BR.ReadString
        H.x04CiaDeSeguros = BR.ReadString
        H.x05FamiliarNombre = BR.ReadString
        H.x06FamiliarParentesco = BR.ReadString
        H.x07FamiliarCelular = BR.ReadString
        H.x08FamiliarOcupacion = BR.ReadString
        H.z01 = BR.ReadString
        H.z02 = BR.ReadString
        H.z03 = BR.ReadString
        H.z04 = BR.ReadString
        H.z05 = BR.ReadString
        H.z06 = BR.ReadString
        H.z07 = BR.ReadString
        H.z08 = BR.ReadString
        H.z09 = BR.ReadString
        H.z10 = BR.ReadString

        BR.Close()
        FS.Close()

        'calcula la edad actual a partir de la fecha de nacimiento almacenada en disco
        Dim Edad As Integer
        Dim fechaNacimiento As Date
        Dim EdadSalida As String
        If IsDate(H.FechaNacimiento) Then
            fechaNacimiento = H.FechaNacimiento
            Edad = (DateDiff(DateInterval.Day, fechaNacimiento, Today()))
            Edad = Edad * 100 \ 36525
            EdadSalida = Edad.ToString
        Else
            EdadSalida = "??"
        End If
        txtNombrePaciente.Text = H.a01Nombre
        txtFechaNacimiento.Text = H.FechaNacimiento
        txtEdad.Text = EdadSalida
        txtCedula.Text = H.Cedula
        txtProfesion.Text = H.Profesion
        txtTelefono.Text = H.Telefono
        txtAntFamiliares.Text = H.AntecedentesFamiliares
        txtAntPersonales.Text = H.AntecedentesPersonales
        txtAntGinecologicos.Text = H.AntecedentesGinecologicos
        txtAntObstetricos.Text = H.AntecedentesObstetricos
        txtAntQuirurgicos.Text = H.AntecedentesQuirurgicos
    End Sub


    Private Sub MuestraControlEcografico()
        If Form1.ExisteControlEcografico = True Then
            'Cargar y mostrar el control ginecologico previo
            LeeContenidoControlEcografico()
        End If
    End Sub
    Private Sub LeeContenidoControlEcografico()
        Dim FS As FileStream
        Dim BR As BinaryReader

        'comprobacion adicional de existencia de archivo
        If File.Exists(NombreControlEcografico) = False Then
            'no se encuentra el archivo
            MsgBox("El archivo de Informes Ecograficos al que se hace mención no existe, probable corrupción de datos, si posees un respaldo copia el archivo:" & vbCrLf & NombreControlEcografico)
            Exit Sub
        End If

        'si todo esta bien continua
        FS = New FileStream(NombreControlEcografico, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim H As New Form1.TablaDeDatosEcograficos()
        Dim C As Integer
        arrayEcosDelPacienteSeleccionado.Clear()
        ArraydeFechasOrdenadas.Clear()
        ListBoxInformes.Items.Clear()

        Dim DiaParaElListBox As Date
        Dim contador As Integer = 0

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

            arrayEcosDelPacienteSeleccionado.Add(H)
            contador += 1

            'inicia llenado del array de fechas de controles anteriores para despues ordenarlas
            DiaParaElListBox = H.c01FechaControl
            ArraydeFechasOrdenadas.Add(DiaParaElListBox.ToString("s") & "|" & H.c09NombreInforme)

            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'ahora ordena y llena el list box con las fechas en orden
        ArraydeFechasOrdenadas.Sort()
        Dim REnum As IEnumerator
        Dim Encabezado As String
        Dim Partes(5) As String

        REnum = ArraydeFechasOrdenadas.GetEnumerator
        While REnum.MoveNext
            Encabezado = CType(REnum.Current, String)

            Partes = Split(Encabezado, "|")

            DiaParaElListBox = Partes(0)
            ListBoxInformes.Items.Add(DiaParaElListBox.ToShortDateString & "|" & Partes(1))
        End While

    End Sub

    Private Sub MuestraImagenesEcograficas()
        If Form1.ExistenImagenesEcograficas = True Then
            'Cargar y mostrar el control ginecologico previo
            LeeContenidoImagenesEcograficas()
        End If
    End Sub
    Private Sub LeeContenidoImagenesEcograficas()
        Dim FS As FileStream
        Dim BR As BinaryReader

        'comprobacion adicional de existencia de archivo
        If File.Exists(NombreBaseFotos) = False Then
            'no se encuentra el archivo
            MsgBox("El archivo Indice de Imágenes Ecográficas al que se hace mención no existe, probable corrupción de datos, si posees un respaldo copia el archivo:" & vbCrLf & NombreBaseFotos)
            Exit Sub
        End If

        'si todo esta bien continua
        FS = New FileStream(NombreBaseFotos, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)


        Dim C As Integer
        arraylistImagenes.Clear()
        ArraydeFechasOrdenadas.Clear()
        ListBoxImagenes.Items.Clear()

        Dim DiaParaElListBox As Date
        Dim contador As Integer = 0

        C = BR.PeekChar
        While FS.Position < FS.Length
            I = Nothing
            ' Read fields and populate structure
            I.FechaEcografia = BR.ReadString
            I.Descripcion = BR.ReadString
            I.x1 = BR.ReadString
            I.x2 = BR.ReadString
            I.x3 = BR.ReadString


            arraylistImagenes.Add(I)
            contador += 1

            'inicia llenado del array de fechas de controles anteriores para despues ordenarlas
            DiaParaElListBox = I.FechaEcografia
            ArraydeFechasOrdenadas.Add(DiaParaElListBox.ToString("s") & "|" & I.Descripcion)

            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'ahora ordena y llena el list box con las fechas en orden
        ArraydeFechasOrdenadas.Sort()
        Dim REnum As IEnumerator
        Dim Encabezado As String
        Dim Partes(5) As String
        Dim FechaFormateada As String
        Dim Descripcion As String

        REnum = ArraydeFechasOrdenadas.GetEnumerator
        While REnum.MoveNext
            Encabezado = CType(REnum.Current, String)

            Partes = Split(Encabezado, "|")

            DiaParaElListBox = Partes(0)
            Descripcion = Partes(1)

            'construye la fecha formateada
            FechaFormateada = DiaParaElListBox.ToString("s")
            FechaFormateada = FechaFormateada.Remove(10, 9) 'le quita el tiempo
            Partes = Split(FechaFormateada, "-")
            FechaFormateada = Partes(2) & "-" & Partes(1) & "-" & Partes(0)

            ListBoxImagenes.Items.Add(FechaFormateada & "|" & Descripcion)
        End While

    End Sub


    Private Sub DepuraCarpetaDeImagenes()
        Dim Archivos() As String
        Dim Numero As Integer
        Dim NumeroArchivosEnLaCarpeta As Integer
        Dim ArchivosEncontrados As Integer
        Dim ImagenesDeEstaHistoria As New ArrayList()
        Dim CadenaBuscada As String
        Dim Cadena As String

        If Form1.SeBorraronImagenes = False Then
            'MsgBox("No se han borrado imagenes en esta apertura del programa Historias.exe")

            ImagenesDeEstaHistoria.Clear()

            'carga los archivos en la array general
            If Directory.Exists(Form1.PathImagenes) Then
                Archivos = Directory.GetFiles(Form1.PathImagenes)
                NumeroArchivosEnLaCarpeta = Archivos.GetLength(0) - 1

                If NumeroArchivosEnLaCarpeta = -1 Then
                    'la carpeta esta vacia sal de una vez
                    Exit Sub
                End If

                'determina la cadena que se busca
                CadenaBuscada = NombreBaseFotosInicio.ToUpper

                ArchivosEncontrados = -1
                For Numero = 0 To NumeroArchivosEnLaCarpeta
                    Cadena = Archivos(Numero).ToUpper
                    'MsgBox(Cadena)
                    If Cadena.StartsWith(CadenaBuscada) = True Then
                        'este archivo  pertenece al numero de la historia, lo añade al array list
                        If Cadena = NombreBaseFotos.ToUpper Then
                            'no lo añade porque consiguio el indice, no es una imagen
                            'MsgBox("Este es el indice, tampoco lo añade")
                        Else
                            ImagenesDeEstaHistoria.Add(Cadena)
                            ArchivosEncontrados += 1
                            'MsgBox("Es de esta historia")
                        End If
                    Else
                        'no es de la historia
                        'MsgBox("No es, no se añade")
                    End If
                Next

                If ArchivosEncontrados = -1 Then
                    'no se encontro ningun archivo de esta historia sal de una vez
                    Exit Sub
                End If


                Dim REnum As IEnumerator
                Dim Encabezado As String
                Dim Partes(5) As String
                Dim T As Integer
                Dim SeencontroElArchivo As Boolean

                'revisa el array de todos los archivos de la historia desde el 1ro
                REnum = ImagenesDeEstaHistoria.GetEnumerator

                While REnum.MoveNext
                    'asigna el nombre de archivo a confirmar
                    Cadena = CType(REnum.Current, String)
                    Cadena = Cadena.ToUpper

                    'inicializa bandera de encuentro
                    SeencontroElArchivo = False

                    'recorre el listbox en cada ciclo
                    For T = 0 To ListBoxImagenes.Items.Count - 1
                        'reconstruye el nombre a partir del list box imagenes
                        Encabezado = ListBoxImagenes.Items(T)
                        Partes = Split(Encabezado, "|")
                        CadenaBuscada = NombreBaseFotosInicio & "-" & Partes(0) & "-" & Partes(1) & ".jpg"
                        CadenaBuscada = CadenaBuscada.ToUpper

                        If CadenaBuscada = Cadena Then
                            SeencontroElArchivo = True
                        End If
                    Next

                    If SeencontroElArchivo = False Then
                        'MsgBox("El archivo " & Cadena & " esta de más")
                        File.Delete(Cadena)
                    End If

                End While

            Else
                'no existe el path a las historias falta el directorio no hace nada

            End If

        Else
            'MsgBox("Se han borrado imagenes en esta apertura del programa Historias.exe")
        End If
    End Sub

    Private Sub AbreEdicionDeInformeAutomaticamente()
        'averigua si se va a crear un informe nuevo o si se va a editar uno existente
        If Form1.booEsUnEcoNuevo = True Then
            'es un eco nuevo
            NuevoEco = True 'acomoda la bandera local
            'inicializa la pantalla y la estructura
            BorraEstructura()
            BorraDatosEnPantalla()

            'Inicializa los graficos
            Fondo = Me.CreateGraphics
            BMP = New Bitmap(PictureBox2.Width, PictureBox2.Height)
            PictureBox2.Image = BMP
            Fondo.Clear(PictureBox2.BackColor)
            Gr = Graphics.FromImage(BMP)

            'acomoda la fecha de inicio del informe y sus relacionados
            dateFechaInicioInformeSeleccionado = Form1.dateFechaInicioInformeSeleccionado 'esta guardado en la var publica se seteo cuando se presiono el boton eco
            strFechaInicioInformeSeleccionadoSystemDate = dateFechaInicioInformeSeleccionado.ToString("s")
            strFechaInicioInformeSeleccionadoSDS = dateFechaInicioInformeSeleccionado.ToShortDateString

            'comienza a llenar la estructura con los datos invariables
            R.c01FechaControl = strFechaInicioInformeSeleccionadoSystemDate ' formatea la fecha a system para el fichero
            R.c09NombreInforme = "  (" & Form1.Informe01TipoInforme & ") " & Form1.Informe06Nombre
            'refleja los cambios de la estructura en pantalla
            txtFechaInicioControl.Text = dateFechaInicioInformeSeleccionado.ToLongDateString
            txtFechaInicioControl2.Text = dateFechaInicioInformeSeleccionado.ToLongDateString
            labInforme.Text = R.c09NombreInforme
            labInforme2.Text = R.c09NombreInforme

            'la paridad la pone en los 2 textboxes de una
            R.c02Paridad = Form1.labDCparidad.Text
            txtParidad1erT.Text = R.c02Paridad
            txtParidad2y3erT.Text = R.c02Paridad

            'enciende el panel de impresion
            PanelImpresion.Visible = True


            'solo se muestran los obs aca primero revisa si fue manual
            If Form1.Informe03ConoceFUR = False Then
                'fue seleccionada manualmente ve cual trimestre se eligio
                If Form1.Informe05Trimestre = "1er" Then
                    'se selecciono manualmente el 1er T
                    PanelNuevoControlGinecologico.Visible = False
                    PanelNuevoControl1erT.Visible = True
                    PanelNuevoControl2y3erT.Visible = False

                    'inicia el llenado de la estructura con los valores fijos
                    R.c00TipoDeEstudio = 1
                    R.c03FUR = "Incierta"
                    R.c07Nombre = txtNombrePaciente.Text '(lo saca de la ficha de datos personales)

                    'pone los mismos datos en pantalla
                    labFechaControl1erT.Text = dateFechaInicioInformeSeleccionado.ToShortDateString
                    labNombre1erT.Text = txtNombrePaciente.Text

                    'la edad al momento del informe no se modifica con el tiempo
                    If IsNumeric(txtEdad.Text) Then
                        txtEdad1erT.Text = txtEdad.Text
                    Else
                        txtEdad1erT.Text = ""
                    End If
                    R.c08Edad = txtEdad1erT.Text

                    labFUR1erT.Text = "Incierta"
                    labFPP1erT.Text = "Incierta"
                    lab1ertEGxFUR01.Text = "Incierta"
                    lab1ertEGxFUR02.Text = "Incierta"

                    'pasa los valores calculados a la estructura
                    R.c04FPP = "Incierta"
                    R.c05EGxFUR = "Incierta"

                    'Calcula para blanquear todo
                    CalculaEGxSG()
                    CalculaEGxLCC()
                    CalculaEG1erTxECO()

                    TabControl1.SelectedIndex = 1
                    TabControl3.SelectedIndex = 0
                    'evita q se cambie o añada otro eco solo permite la edicion del seleccionado
                    ListBoxInformes.Enabled = False
                    ListBoxImagenes.Enabled = False
                    botNuevaImagen.Enabled = False
                    botNuevo.Enabled = False

                ElseIf Form1.Informe05Trimestre = "2y3er" Then
                    'se selecciono manualmente el 2y3er T
                    PanelNuevoControlGinecologico.Visible = False
                    PanelNuevoControl1erT.Visible = False
                    PanelNuevoControl2y3erT.Visible = True

                    'inicia el llenado de la estructura con los valores fijos
                    R.c00TipoDeEstudio = 2
                    R.c03FUR = "Incierta"
                    R.c07Nombre = txtNombrePaciente.Text


                    'pone los mismos datos en pantalla
                    labFechaControl2y3erT.Text = dateFechaInicioInformeSeleccionado.ToShortDateString
                    labNombre2y3erT.Text = txtNombrePaciente.Text

                    'la edad al momento del informe no se modifica con el tiempo
                    If IsNumeric(txtEdad.Text) Then
                        txtEdad2y3erT.Text = txtEdad.Text
                    Else
                        txtEdad2y3erT.Text = ""
                    End If
                    R.c08Edad = txtEdad2y3erT.Text

                    labFUR2y3erT.Text = "Incierta"
                    labFPP2y3erT.Text = "Incierta"
                    labEGxFUR2y3erT.Text = "Incierta"


                    'pasa los valores calculados a la estructura
                    R.c04FPP = "Incierta"
                    R.c05EGxFUR = "Incierta"

                    TabControl1.SelectedIndex = 1
                    TabControl4.SelectedIndex = 0
                    'evita q se cambie o añada otro eco solo permite la edicion del seleccionado
                    ListBoxInformes.Enabled = False
                    ListBoxImagenes.Enabled = False
                    botNuevaImagen.Enabled = False
                    botNuevo.Enabled = False


                End If 'si es del 1er o del 2y3er trim


            ElseIf Form1.Informe03ConoceFUR = True Then
                'la paciente conoce la fur saca cuentas para ver cual se muestra

                If IsDate(Form1.Informe04FUR) Then

                    Dim FURinicio = Form1.Informe04FUR
                    Dim EG = (DateDiff(DateInterval.Day, FURinicio, dateFechaInicioInformeSeleccionado))

                    If EG < 91 Then
                        'en el primer trimestre

                        'visualiza el panel adecuado
                        PanelNuevoControlGinecologico.Visible = False
                        PanelNuevoControl1erT.Visible = True
                        PanelNuevoControl2y3erT.Visible = False

                        'inicia el llenado de la estructura con los valores fijos
                        R.c00TipoDeEstudio = 1

                        R.c03FUR = FURinicio.ToString("dd/MM/yyyy")
                        labFUR1erT.Text = FURinicio.ToString("dd/MM/yyyy")

                        R.c07Nombre = txtNombrePaciente.Text
                        labNombre1erT.Text = txtNombrePaciente.Text
                        labFechaControl1erT.Text = dateFechaInicioInformeSeleccionado.ToString("dd/MM/yyyy")

                        'la edad al momento del informe no se modifica con el tiempo
                        If IsNumeric(txtEdad.Text) Then
                            txtEdad1erT.Text = txtEdad.Text
                        Else
                            txtEdad1erT.Text = ""
                        End If
                        R.c08Edad = txtEdad1erT.Text

                        ''si trae paridad automatica la coloca en pantalla y en la estructura
                        'If FormNuevoInformeEcografico.strParidad <> "" Then
                        '    'tiene datos los muestra y pone en la estructura
                        '    txtParidad1erT.Text = FormNuevoInformeEcografico.strParidad
                        '    R.c02Paridad = FormNuevoInformeEcografico.strParidad
                        'End If

                        'calcula el texto de la eg en semanas y dias 'y la FPP

                        NumeroDiasEG = EG
                        ProcesaDiasEnSemanasMasDias()
                        labFPP1erT.Text = TextoDeFPP
                        lab1ertEGxFUR01.Text = TextoDeEGenSemanasyDiasLargo
                        lab1ertEGxFUR02.Text = TextoDeEGenSemanasyDiasLargo

                        'pasa los valores calculados a la estructura
                        R.c04FPP = TextoDeFPP
                        R.c05EGxFUR = TextoDeEGenSemanasyDiasLargo

                        'Calcula para blanquear todo
                        CalculaEGxSG()
                        CalculaEGxLCC()
                        CalculaEG1erTxECO()

                        TabControl1.SelectedIndex = 1
                        TabControl3.SelectedIndex = 0
                        'evita q se cambie o añada otro eco solo permite la edicion del seleccionado
                        ListBoxInformes.Enabled = False
                        ListBoxImagenes.Enabled = False
                        botNuevaImagen.Enabled = False
                        botNuevo.Enabled = False

                    ElseIf EG >= 91 And EG < 302 Then

                        'visualiza el panel adecuado
                        PanelNuevoControlGinecologico.Visible = False
                        PanelNuevoControl1erT.Visible = False
                        PanelNuevoControl2y3erT.Visible = True

                        'inicia el llenado de la estructura con los valores fijos
                        R.c00TipoDeEstudio = 2
                        R.c03FUR = (FURinicio.ToString("dd/MM/yyyy"))
                        R.c07Nombre = txtNombrePaciente.Text
                        'revisa la edad
                        If IsNumeric(txtEdad.Text) Then
                            txtEdad2y3erT.Text = txtEdad.Text
                        Else
                            txtEdad2y3erT.Text = ""
                        End If
                        R.c08Edad = txtEdad2y3erT.Text

                        ''si trae paridad automatica la coloca en pantalla y en la estructura
                        'If FormNuevoInformeEcografico.strParidad <> "" Then
                        '    'tiene datos los muestra y pone en la estructura
                        '    txtParidad2y3erT.Text = FormNuevoInformeEcografico.strParidad
                        '    R.c02Paridad = FormNuevoInformeEcografico.strParidad
                        'End If

                        'pone los mismos datos en pantalla
                        labFechaControl2y3erT.Text = dateFechaInicioInformeSeleccionado.ToString("dd/MM/yyyy")
                        labNombre2y3erT.Text = txtNombrePaciente.Text
                        labFUR2y3erT.Text = (FURinicio.ToString("dd/MM/yyyy"))


                        'calcula el texto de la eg en semanas y dias
                        'y la FPP
                        NumeroDiasEG = EG
                        ProcesaDiasEnSemanasMasDias()
                        labFPP2y3erT.Text = TextoDeFPP
                        labEGxFUR2y3erT.Text = TextoDeEGenSemanasyDiasLargo

                        R.c04FPP = TextoDeFPP
                        R.c05EGxFUR = TextoDeEGenSemanasyDiasLargo

                        'calcula para blanquear todo
                        'CalculaEGconDBP()
                        'CalculaDBF()
                        'CalculaCC_DBPc_IC()
                        'CalculaCA()
                        'CalculaEGxFemur()
                        'CalculaPesoEstimado()
                        'CalculaEG2y3erTxECO()

                        TabControl1.SelectedIndex = 1
                        TabControl4.SelectedIndex = 0
                        'evita q se cambie o añada otro eco solo permite la edicion del seleccionado
                        ListBoxInformes.Enabled = False
                        ListBoxImagenes.Enabled = False
                        botNuevaImagen.Enabled = False
                        botNuevo.Enabled = False

                    ElseIf EG >= 302 Then
                        'el embarazo ya deberia haber terminado 'no se como puede pasar esto pero...

                        MsgBox("Error. Según la FUR introducida el embarazo ya ha debido terminar" & vbCrLf & "Sugerencia: Selecciona manualmente un embarazo del 2do y 3er trimestre" & vbCrLf & "señalando que la paciente desconoce la FUR", MsgBoxStyle.Information, "Error")
                        PanelNuevoControlGinecologico.Visible = False
                        PanelNuevoControl1erT.Visible = False
                        PanelNuevoControl2y3erT.Visible = False
                        PanelImpresion.Visible = False
                        'pone los datos sin cambios, estan en cero
                        DatosSinCambios()
                        'pone visible el tab del informe
                        TabControl1.SelectedIndex = 0

                        'borracualquier cosa en memoria y pantalla
                        BorraEstructura()
                        BorraDatosEnPantalla()

                        'sal del sub
                        Exit Sub
                    End If
                Else
                    'no se recupero una fur valida error'no se como puede pasar esto pero...

                    MsgBox("Error. No se seleccionó una FUR válida...", MsgBoxStyle.Information, "Error")
                    PanelNuevoControlGinecologico.Visible = False
                    PanelNuevoControl1erT.Visible = False
                    PanelNuevoControl2y3erT.Visible = False
                    PanelImpresion.Visible = False
                    'pone los datos sin cambios, estan en cero
                    DatosSinCambios()
                    'pone visible el tab del informe
                    TabControl1.SelectedIndex = 0

                    'borracualquier cosa en memoria y pantalla
                    BorraEstructura()
                    BorraDatosEnPantalla()

                    'sal del sub
                    Exit Sub
                End If
            End If






        Else 'es un eco existente solo se va a editar


            'primero borra todos los datos antes de rellenar los nuevos
            BorraDatosEnPantalla()

            strFechaInicioInformeSeleccionadoSDS = Form1.dateFechaInicioInformeSeleccionado.ToShortDateString

            For Each est As Form1.TablaDeDatosEcograficos In arrayEcosDelPacienteSeleccionado
                Dim dateFechaParaComparar = CType(est.c01FechaControl, Date)
                Dim strFechaParaCompararSDS = dateFechaParaComparar.ToShortDateString
                If strFechaParaCompararSDS = strFechaInicioInformeSeleccionadoSDS Then

                    'este es asiga est a R
                    R = est
                    'ahora lavariables publicas
                    dateFechaInicioInformeSeleccionado = dateFechaParaComparar
                    'strFechaInicioInformeSeleccionadoSDS = dateFechaInicioInformeSeleccionado.ToShortDateString (ya se habia colocado)

                    'ahora actualiza el texto con la estructura
                    ActualizaTextoConLaEstructura()
                    'no se esta creando un nuevo control 
                    NuevoEco = False
                    'evita q se cambie o añada otro eco solo permite la edicion del seleccionado
                    ListBoxInformes.Enabled = False
                    ListBoxImagenes.Enabled = False
                    botNuevaImagen.Enabled = False
                    botNuevo.Enabled = False
                    'pone visible el tab del informe
                    TabControl1.SelectedIndex = 1
                    PanelImpresion.Visible = True

                    Exit For

                End If
            Next

        End If 'si es nuevo o se va a editar uno existente
    End Sub

    '00000000000000000000000000000000000000
    '0
    '0   EVENTOS DE INTERACION DEL USUARIO CON ENTORNO
    '0
    '0000000000000000000000000000000000000000000000000

    'selecciona solo las medidas usuales
    Private Sub chkMedidasUsuales_CheckedChanged(sender As Object, e As EventArgs) Handles chkMedidasUsuales.CheckedChanged
        If chkMedidasUsuales.Checked = True Then
            txtDOF.Enabled = False
            txtTCer.Enabled = False
            txtAtrio.Enabled = False
            txtIOE.Enabled = False
            txtIOI.Enabled = False
            txtPN.Enabled = False
            txtAPC.Enabled = False
            txtAPT.Enabled = False
            txtAorta.Enabled = False
            txtTransAbdomen.Enabled = False
            txtTibia.Enabled = False
            txtHumero.Enabled = False
            txtUlna.Enabled = False
            txtSacro.Enabled = False
            txtNODF.Enabled = False
            txtNOPT.Enabled = False
            txtNOPH.Enabled = False
            botCalculaCC.Enabled = False
        Else
            txtDOF.Enabled = True
            txtTCer.Enabled = True
            txtAtrio.Enabled = True
            txtIOE.Enabled = True
            txtIOI.Enabled = True
            txtPN.Enabled = True
            txtAPC.Enabled = True
            txtAPT.Enabled = True
            txtAorta.Enabled = True
            txtTransAbdomen.Enabled = True
            txtTibia.Enabled = True
            txtHumero.Enabled = True
            txtUlna.Enabled = True
            txtSacro.Enabled = True
            txtNODF.Enabled = True
            txtNOPT.Enabled = True
            txtNOPH.Enabled = True
            botCalculaCC.Enabled = True
        End If
    End Sub


    Private Sub botSalirSinGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalirSinGuardar.Click
        Dim Reply As MsgBoxResult

        If DatosModificados = False Then
            'revisa si se cargo desde control obs para apagar la bandera publica
            If Form1.booSeCargoDesdeControlObs = True Then
                'apaga la bandera
                Form1.booSeCargoDesdeControlObs = False
            End If
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Reply = MsgBox("Se perderán los últimos datos introducidos, para confirmar presiona Aceptar...", MsgBoxStyle.OkCancel, "Cancelar Nuevos Datos")
            If Reply = MsgBoxResult.Ok Then
                'antes de salir revisa si se cargo desde control obs para apagar la bandera publica
                If Form1.booSeCargoDesdeControlObs = True Then
                    'apaga la bandera
                    Form1.booSeCargoDesdeControlObs = False
                End If
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                'se cancelo la salida deja todo igual
            End If
        End If
    End Sub

    Private Sub botNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNuevo.Click
        Dim DLG As New FormEligeFecha()
        Dim DLG2 As New FormNuevoInformeEcografico()

        Dim dateFechaConControlEcografico As Date
        Dim Indice As Integer
        Dim Elementos As Integer

        Dim Encabezado As String
        Dim Partes(5) As String

        Dim EG As Integer
        Dim FURinicio As Date

        Dim Reply As MsgBoxResult


        If DatosModificados = True Then
            Reply = MsgBox("Se perderán los últimos datos introducidos, para confirmar presiona Aceptar...", MsgBoxStyle.OkCancel, "Existen Nuevos Datos No Grabados")
            If Reply = MsgBoxResult.Cancel Then
                Exit Sub
            End If
        End If

        Form1.FechaSeleccionadaMensaje = "Selecciona la fecha del Informe Ecográfico en el Calendario..."

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'se acepto una fecha
            dateFechaInicioInformeSeleccionado = Form1.FechaSeleccionada

            If dateFechaInicioInformeSeleccionado > Today Then
                MsgBox("La fecha del Informe Ecográfico no puede estar en el futuro...", MsgBoxStyle.Information, "Fecha inválida")
                dateFechaInicioInformeSeleccionado = Nothing
                Exit Sub
            End If

            Elementos = ListBoxInformes.Items.Count - 1

            For Indice = 0 To Elementos
                Encabezado = ListBoxInformes.Items(Indice)
                Partes = Split(Encabezado, "|")

                dateFechaConControlEcografico = CType(Partes(0), Date)

                If dateFechaConControlEcografico = dateFechaInicioInformeSeleccionado Then
                    'hay una coincidencia, no permite la creacion de otro informe aca, dice q debe ser
                    'modificar el existente, no sea bruto...!
                    MsgBox("Ya se incluyó en la Historia un Informe Ecográfico este día, para modificarlo selecciónalo de la lista...", MsgBoxStyle.Information, "Fecha ya existe")
                    Exit Sub
                End If
            Next

            'se inicia la posible creacion del nuevo informe

            If DLG2.ShowDialog = Windows.Forms.DialogResult.OK Then
                'efectivamente se esta creando un informe nuevo

                NuevoEco = True 'se esta creando un nuevo control para otro embarazo

                BorraEstructura()
                BorraDatosEnPantalla()
                'borra el informe que estuviera ahi
                Fondo = Me.CreateGraphics
                BMP = New Bitmap(PictureBox2.Width, PictureBox2.Height)
                PictureBox2.Image = BMP
                Fondo.Clear(PictureBox2.BackColor)
                Gr = Graphics.FromImage(BMP)
                strFechaInicioInformeSeleccionadoSystemDate = dateFechaInicioInformeSeleccionado.ToString("s")
                strFechaInicioInformeSeleccionadoSDS = dateFechaInicioInformeSeleccionado.ToShortDateString
                R.c01FechaControl = strFechaInicioInformeSeleccionadoSystemDate ' formatea la fecha para el fichero
                R.c09NombreInforme = "  (" & Form1.Informe01TipoInforme & ") " & Form1.Informe06Nombre


                txtFechaInicioControl.Text = dateFechaInicioInformeSeleccionado.ToLongDateString 'formatea lo que sale en pantalla
                labInforme.Text = R.c09NombreInforme
                txtFechaInicioControl2.Text = dateFechaInicioInformeSeleccionado.ToLongDateString 'formatea lo que sale en pantalla
                labInforme2.Text = R.c09NombreInforme
                PanelImpresion.Visible = True

                'revisa cual panel se mostrara
                If Form1.Informe01TipoInforme = "GIN" Then
                    'se muestra el ginecologico
                    PanelNuevoControlGinecologico.Visible = True
                    PanelNuevoControl1erT.Visible = False
                    PanelNuevoControl2y3erT.Visible = False

                    If Form1.Informe02VeReglas = True Then
                        'la paciete ve reglas revisa si esta bien
                        If IsDate(Form1.Informe04FUR) Then
                            'calcula los dias del ciclo
                            FURinicio = Form1.Informe04FUR
                            EG = (DateDiff(DateInterval.Day, FURinicio, dateFechaInicioInformeSeleccionado))

                            If EG <= 0 Then
                                'esta en el futuro error
                                MsgBox("Error. Se seleccionó una FUR ubicada en el futuro del día del informe...", MsgBoxStyle.Information, "Error")
                                PanelNuevoControlGinecologico.Visible = False
                                PanelNuevoControl1erT.Visible = False
                                PanelNuevoControl2y3erT.Visible = False
                                PanelImpresion.Visible = False
                            ElseIf EG < 366 Then
                                'esta comprendida entre 1 dia y un año

                                R.c00TipoDeEstudio = 3
                                R.c03FUR = FURinicio.ToShortDateString
                                R.c07Nombre = txtNombrePaciente.Text
                                R.c08Edad = txtEdad.Text
                                R.r18DiaCiclo = EG
                                R.f01Menopausia = "No"

                                'pone los mismos datos en pantalla
                                labFechaControlGinecologico.Text = dateFechaInicioInformeSeleccionado.ToString("dd/MM/yyyy")
                                labNombreGinecologico.Text = txtNombrePaciente.Text
                                labEdadGinecologico.Text = txtEdad.Text
                                labFURginecologico.Text = FURinicio.ToShortDateString
                                labDiaCicloGinecologico.Text = EG


                            ElseIf EG >= 366 Then
                                'es mayor de un año esta menopausica

                                R.c00TipoDeEstudio = 3
                                R.c03FUR = "Menopausia"
                                R.c07Nombre = txtNombrePaciente.Text
                                R.c08Edad = txtEdad.Text
                                R.r18DiaCiclo = "+ 1 año"
                                R.f01Menopausia = "Si"

                                'pone los mismos datos en pantalla
                                labFechaControlGinecologico.Text = dateFechaInicioInformeSeleccionado.ToString("dd/MM/yyyy")
                                labNombreGinecologico.Text = txtNombrePaciente.Text
                                labEdadGinecologico.Text = txtEdad.Text
                                labFURginecologico.Text = "Menopausia"
                                labDiaCicloGinecologico.Text = "+ 1 año"

                            End If

                        Else
                            'error no hay una fur valida
                            MsgBox("Error. No se seleccionó una FUR válida...", MsgBoxStyle.Information, "Error")
                            PanelNuevoControlGinecologico.Visible = False
                            PanelNuevoControl1erT.Visible = False
                            PanelNuevoControl2y3erT.Visible = False
                            PanelImpresion.Visible = False
                        End If

                    ElseIf Form1.Informe02VeReglas = False Then
                        'la paciente no ve reglas
                        'inicia el llenado de la estructura con los valores fijos
                        R.c00TipoDeEstudio = 3
                        R.c03FUR = "Menopausia"
                        R.c07Nombre = txtNombrePaciente.Text
                        R.c08Edad = txtEdad.Text
                        R.r18DiaCiclo = "N/A"
                        R.f01Menopausia = "Si"

                        'pone los mismos datos en pantalla
                        labFechaControlGinecologico.Text = dateFechaInicioInformeSeleccionado.ToString("dd/MM/yyyy")
                        labNombreGinecologico.Text = txtNombrePaciente.Text
                        labEdadGinecologico.Text = txtEdad.Text
                        labFURginecologico.Text = "Menopausia"
                        labDiaCicloGinecologico.Text = "N/A"

                    Else
                        'error no se selecciono si la paciente ve o no ve reglas
                        'no se como puede pasar esto pero...
                        MsgBox("Error. No se seleccionó Si la Paciente presenta o no Menstruaciones...", MsgBoxStyle.Information, "Error")
                        PanelNuevoControlGinecologico.Visible = False
                        PanelNuevoControl1erT.Visible = False
                        PanelNuevoControl2y3erT.Visible = False
                        PanelImpresion.Visible = False
                    End If

                ElseIf Form1.Informe01TipoInforme = "OBS" Then
                    'se debe mostrar uno de los obstetricos
                    'revisa si fue manual
                    If Form1.Informe03ConoceFUR = False Then
                        'fue seleccionada manualmente
                        've cual trimestre se eligio
                        If Form1.Informe05Trimestre = "1er" Then
                            'se selecciono manualmente el 1er T
                            PanelNuevoControlGinecologico.Visible = False
                            PanelNuevoControl1erT.Visible = True
                            PanelNuevoControl2y3erT.Visible = False

                            'inicia el llenado de la estructura con los valores fijos
                            R.c00TipoDeEstudio = 1
                            R.c03FUR = "Incierta"
                            R.c07Nombre = txtNombrePaciente.Text
                            R.c08Edad = txtEdad.Text

                            'pone los mismos datos en pantalla
                            labFechaControl1erT.Text = dateFechaInicioInformeSeleccionado.ToString("dd/MM/yyyy")
                            labNombre1erT.Text = txtNombrePaciente.Text
                            txtEdad1erT.Text = txtEdad.Text
                            labFUR1erT.Text = "Incierta"

                            labFPP1erT.Text = "Incierta"
                            lab1ertEGxFUR01.Text = "Incierta"
                            lab1ertEGxFUR02.Text = "Incierta"

                            'pasa los valores calculados a la estructura
                            R.c04FPP = "Incierta"
                            R.c05EGxFUR = "Incierta"

                            'Calcula para blanquear todo
                            CalculaEGxSG()
                            CalculaEGxLCC()
                            CalculaEG1erTxECO()


                        ElseIf Form1.Informe05Trimestre = "2y3er" Then
                            'se selecciono manualmente el 2y3er T
                            PanelNuevoControlGinecologico.Visible = False
                            PanelNuevoControl1erT.Visible = False
                            PanelNuevoControl2y3erT.Visible = True

                            'inicia el llenado de la estructura con los valores fijos
                            R.c00TipoDeEstudio = 2
                            R.c03FUR = "Incierta"
                            R.c07Nombre = txtNombrePaciente.Text


                            'pone los mismos datos en pantalla
                            labFechaControl2y3erT.Text = dateFechaInicioInformeSeleccionado.ToString("dd/MM/yyyy")
                            labNombre2y3erT.Text = txtNombrePaciente.Text
                            If IsNumeric(txtEdad.Text) Then
                                txtEdad2y3erT.Text = txtEdad.Text
                            Else
                                txtEdad2y3erT.Text = ""
                            End If
                            R.c08Edad = txtEdad2y3erT.Text

                            labFUR2y3erT.Text = "Incierta"
                            labFPP2y3erT.Text = "Incierta"
                            labEGxFUR2y3erT.Text = "Incierta"


                            'pasa los valores calculados a la estructura
                            R.c04FPP = "Incierta"
                            R.c05EGxFUR = "Incierta"

                            'calcula para blanquear todo
                            'CalculaEGconDBP()
                            'CalculaDBF()
                            'CalculaCC_DBPc_IC()
                            'CalculaCA()
                            'CalculaEGxFemur()
                            'CalculaPesoEstimado()
                            'CalculaEG2y3erTxECO()

                            TabControl4.SelectedIndex = 0

                        Else
                            'no se selecciono un trimestre
                            'no se como puede pasar esto pero...
                            MsgBox("Error. No se seleccionó un Trimestre...", MsgBoxStyle.Information, "Error")
                            PanelNuevoControlGinecologico.Visible = False
                            PanelNuevoControl1erT.Visible = False
                            PanelNuevoControl2y3erT.Visible = False
                            PanelImpresion.Visible = False
                        End If
                    ElseIf Form1.Informe03ConoceFUR = True Then
                        'la paciente conoce la fur saca cuentas
                        'para ver cual se muestra
                        If IsDate(Form1.Informe04FUR) Then

                            FURinicio = Form1.Informe04FUR
                            EG = (DateDiff(DateInterval.Day, FURinicio, dateFechaInicioInformeSeleccionado))
                            If EG <= 0 Then
                                'en el futuro

                            ElseIf EG < 92 Then
                                'en el primer trimestre

                                'visualiza el panel adecuado
                                PanelNuevoControlGinecologico.Visible = False
                                PanelNuevoControl1erT.Visible = True
                                PanelNuevoControl2y3erT.Visible = False

                                'inicia el llenado de la estructura con los valores fijos
                                R.c00TipoDeEstudio = 1
                                R.c03FUR = FURinicio.ToString("dd/MM/yyyy")
                                R.c07Nombre = txtNombrePaciente.Text
                                R.c08Edad = txtEdad.Text

                                'si trae paridad automatica la coloca en pantalla y en la estructura
                                If FormNuevoInformeEcografico.strParidad <> "" Then
                                    'tiene datos los muestra y pone en la estructura
                                    txtParidad1erT.Text = FormNuevoInformeEcografico.strParidad
                                    R.c02Paridad = FormNuevoInformeEcografico.strParidad
                                End If

                                'pone los mismos datos en pantalla
                                labFechaControl1erT.Text = dateFechaInicioInformeSeleccionado.ToString("dd/MM/yyyy")
                                labNombre1erT.Text = txtNombrePaciente.Text
                                txtEdad1erT.Text = txtEdad.Text
                                labFUR1erT.Text = FURinicio.ToString("dd/MM/yyyy")

                                'calcula el texto de la eg en semanas y dias
                                'y la FPP
                                NumeroDiasEG = EG
                                ProcesaDiasEnSemanasMasDias()
                                labFPP1erT.Text = TextoDeFPP
                                lab1ertEGxFUR01.Text = TextoDeEGenSemanasyDiasLargo
                                lab1ertEGxFUR02.Text = TextoDeEGenSemanasyDiasLargo

                                'pasa los valores calculados a la estructura
                                R.c04FPP = TextoDeFPP
                                R.c05EGxFUR = TextoDeEGenSemanasyDiasLargo

                                'Calcula para blanquear todo
                                CalculaEGxSG()
                                CalculaEGxLCC()
                                CalculaEG1erTxECO()

                            ElseIf EG < 302 Then

                                'visualiza el panel adecuado
                                PanelNuevoControlGinecologico.Visible = False
                                PanelNuevoControl1erT.Visible = False
                                PanelNuevoControl2y3erT.Visible = True

                                'inicia el llenado de la estructura con los valores fijos
                                R.c00TipoDeEstudio = 2
                                R.c03FUR = (FURinicio.ToString("dd/MM/yyyy"))
                                R.c07Nombre = txtNombrePaciente.Text
                                'revisa la edad
                                If IsNumeric(txtEdad.Text) Then
                                    txtEdad2y3erT.Text = txtEdad.Text
                                Else
                                    txtEdad2y3erT.Text = ""
                                End If
                                R.c08Edad = txtEdad2y3erT.Text

                                'si trae paridad automatica la coloca en pantalla y en la estructura
                                If FormNuevoInformeEcografico.strParidad <> "" Then
                                    'tiene datos los muestra y pone en la estructura
                                    txtParidad2y3erT.Text = FormNuevoInformeEcografico.strParidad
                                    R.c02Paridad = FormNuevoInformeEcografico.strParidad
                                End If

                                'pone los mismos datos en pantalla
                                labFechaControl2y3erT.Text = dateFechaInicioInformeSeleccionado.ToString("dd/MM/yyyy")
                                labNombre2y3erT.Text = txtNombrePaciente.Text
                                labFUR2y3erT.Text = (FURinicio.ToString("dd/MM/yyyy"))


                                'calcula el texto de la eg en semanas y dias
                                'y la FPP
                                NumeroDiasEG = EG
                                ProcesaDiasEnSemanasMasDias()
                                labFPP2y3erT.Text = TextoDeFPP
                                labEGxFUR2y3erT.Text = TextoDeEGenSemanasyDiasLargo

                                R.c04FPP = TextoDeFPP
                                R.c05EGxFUR = TextoDeEGenSemanasyDiasLargo

                                'calcula para blanquear todo
                                'CalculaEGconDBP()
                                'CalculaDBF()
                                'CalculaCC_DBPc_IC()
                                'CalculaCA()
                                'CalculaEGxFemur()
                                'CalculaPesoEstimado()
                                'CalculaEG2y3erTxECO()

                                TabControl4.SelectedIndex = 0

                            ElseIf EG >= 302 Then
                                'el embarazo ya deberia haber terminado
                                'no se como puede pasar esto pero...
                                MsgBox("Error. Según la FUR introducida el embarazo ya ha debido terminar" & vbCrLf & "Sugerencia: Selecciona manualmente un embarazo del 2do y 3er trimestre" & vbCrLf & "señalando que la paciente desconoce la FUR", MsgBoxStyle.Information, "Error")
                                PanelNuevoControlGinecologico.Visible = False
                                PanelNuevoControl1erT.Visible = False
                                PanelNuevoControl2y3erT.Visible = False
                                PanelImpresion.Visible = False
                                'pone los datos sin cambios, estan en cero
                                DatosSinCambios()
                                'pone visible el tab del informe
                                TabControl1.SelectedIndex = 0

                                'borracualquier cosa en memoria y pantalla
                                BorraEstructura()
                                BorraDatosEnPantalla()

                                'sal del sub
                                Exit Sub
                            End If
                        Else
                            'no se recupero una fur valida error
                            'no se como puede pasar esto pero...
                            MsgBox("Error. No se seleccionó una FUR válida...", MsgBoxStyle.Information, "Error")
                            PanelNuevoControlGinecologico.Visible = False
                            PanelNuevoControl1erT.Visible = False
                            PanelNuevoControl2y3erT.Visible = False
                            PanelImpresion.Visible = False
                        End If
                    End If
                Else
                    'no es de tipo OBS ni GIN, algun error hay
                    'no se como puede pasar esto pero...
                    MsgBox("Error. No se seleccionó un Tipo de Informe...", MsgBoxStyle.Information, "Error")
                    PanelNuevoControlGinecologico.Visible = False
                    PanelNuevoControl1erT.Visible = False
                    PanelNuevoControl2y3erT.Visible = False
                    PanelImpresion.Visible = False
                End If

                'pone los datos sin cambios, estan en cero
                DatosSinCambios()
                'pone visible el tab del informe
                TabControl1.SelectedIndex = 1
            Else
                'se cancelo
            End If
        Else
            'se canceló
        End If

    End Sub

    Private Sub botGuardarNuevosDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botGuardarNuevosDatos.Click
        If Form1.ExisteControlEcografico = False Then
            CreaControlEcografico() 'crea el control con los datos introducidos
            ActualizaContenidoHistoria() ' actualiza el contenido de #historia.his añadiendo el control ginecologico
            'MsgBox("Se creó el Control Ecográfico", MsgBoxStyle.Information)
            'modificacion para el respaldo de archivos
            Form1.SeModificaronDatos = True
        Else
            'si existe un control ecografico previo
            'revisa si es un eco nuevo o se esta modificando uno
            If NuevoEco = True Then
                'se esta añadiendo uno nuevo al final
                LeeContenidoControlEcografico()
                arrayEcosDelPacienteSeleccionado.Add(R) 'añade el control actual
                EscribeContenidoControlEcografico()
                'MsgBox("Se añadió un Control Ecografico", MsgBoxStyle.Information)
                'modificacion para el respaldo de archivos
                Form1.SeModificaronDatos = True
            Else
                'se esta modificando uno se debe realizar la
                'busqueda para ver cual es el que hay que sustituir
                SustituyeElInformeSeleccionado()
                'MsgBox("Se modificó el Informe seleccionado...")
            End If
        End If
        'prende la bandera de que si existe un control
        Form1.ExisteControlEcografico = True

        'GrabaDatosySigue y sigue editando
        GrabaDatosySigue()
        MuestraControlEcografico()

    End Sub

    Private Sub botGuardarYsalir_Click(sender As System.Object, e As System.EventArgs) Handles botGuardarYsalir.Click
        If Form1.ExisteControlEcografico = False Then
            CreaControlEcografico() 'crea el control con los datos introducidos
            ActualizaContenidoHistoria() ' actualiza el contenido de #historia.his añadiendo el control ginecologico
            'MsgBox("Se creó el Control Ecográfico", MsgBoxStyle.Information)
            'modificacion para el respaldo de archivos
            Form1.SeModificaronDatos = True
        Else 'si existe un control ecografico previo
            'revisa si es un eco nuevo o se esta modificando uno
            If NuevoEco = True Then
                'se esta añadiendo uno nuevo al final
                LeeContenidoControlEcografico()
                arrayEcosDelPacienteSeleccionado.Add(R) 'añade el control actual
                EscribeContenidoControlEcografico()
                'MsgBox("Se añadió un Control Ecografico", MsgBoxStyle.Information)
                'modificacion para el respaldo de archivos
                Form1.SeModificaronDatos = True
            Else 'se esta modificando uno se debe realizar la 'busqueda para ver cual es el que hay que sustituir
                SustituyeElInformeSeleccionado()
                'MsgBox("Se modificó el Informe seleccionado...")
            End If
        End If

        'prende la bandera de que si existe un control
        Form1.ExisteControlEcografico = True

        ''revisa si se cargo desde control obs para apagar la bandera publica
        If Form1.booSeCargoDesdeControlObs = True Then
            'se cargo desde control obs de forma automatica sale entonces en ok apaga primero la bandera
            Form1.booSeCargoDesdeControlObs = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            'se cargo normalmente desde form1 solo sale y ya no apaga nada porq no hay nada prendido
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub CreaControlEcografico()

        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(NombreControlEcografico, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)

        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        BW.Write(R.c00TipoDeEstudio)
        BW.Write(R.c01FechaControl)
        BW.Write(R.c02Paridad)
        BW.Write(R.c03FUR)
        BW.Write(R.c04FPP)
        BW.Write(R.c05EGxFUR)
        BW.Write(R.c06IDx)
        BW.Write(R.c07Nombre)
        BW.Write(R.c08Edad)
        BW.Write(R.d01SGlongitudinal)
        BW.Write(R.d02SGanteroposterior)
        BW.Write(R.d03SGtransversal)
        BW.Write(R.d04LCC)
        BW.Write(R.d05ImplatacionSG)
        BW.Write(R.d06EmbrionVisible)
        BW.Write(R.d07MovimientosPresentes)
        BW.Write(R.d08ActividadCardiaca)
        BW.Write(R.d09Comentarios1erT)
        BW.Write(R.d10OtroA)
        BW.Write(R.d11AdicionalesB1erT)
        BW.Write(R.d12IDxAdicionales1erT)
        BW.Write(R.d13Adicionales1erT)
        BW.Write(R.e01Presentacion)
        BW.Write(R.e02Situacion)
        BW.Write(R.e03Posicion)
        BW.Write(R.e04Cabeza)
        BW.Write(R.e05Ventriculos)
        BW.Write(R.e06Columna)
        BW.Write(R.e07Torax)
        BW.Write(R.e08Corazon)
        BW.Write(R.e09Abdomen)
        BW.Write(R.e10Riñones)
        BW.Write(R.e11Extremidades)
        BW.Write(R.e12Notas01del2y3erT)
        BW.Write(R.e13DiametroBiParietal)
        BW.Write(R.e14DiametroOccipitoFrontal)
        BW.Write(R.e15DiametroAnteroPosteriorTorax)
        BW.Write(R.e16DiametroAnteroPosteriorCorazon)
        BW.Write(R.e17aDiametroAnteroPosteriorAbdomen)
        BW.Write(R.e17bDiametroTransversoAbdomen)
        BW.Write(R.e18Aorta)
        BW.Write(R.e19VenaCava)
        BW.Write(R.e20LongitudSacro)
        BW.Write(R.e21LongitudFemur)
        BW.Write(R.e22Actitud)
        BW.Write(R.e23Tono)
        BW.Write(R.e24MovimientosFetales)
        BW.Write(R.e25ActividadCardiaca)
        BW.Write(R.e26MovimientosRespiratorios)
        BW.Write(R.e27RelacionAortoCava)
        BW.Write(R.e28CamaraGastrica)
        BW.Write(R.e29Intestino)
        BW.Write(R.e30Vejiga)
        BW.Write(R.e31Notas02del2y3erT)
        BW.Write(R.e32LocalizacionPlacenta)
        BW.Write(R.e33GrosorPlacenta)
        BW.Write(R.e34GradoPlacenta)
        BW.Write(R.e35LiquidoAmniotico)
        BW.Write(R.e36ILA)
        BW.Write(R.e37CordonUmbilical)
        BW.Write(R.e38Notas03del2y3erT)
        BW.Write(R.e39Embarazo)
        BW.Write(R.e40Feto)
        BW.Write(R.e41BiometricosAdicionales)
        BW.Write(R.e42Rostro)
        BW.Write(R.e43Sexo)
        BW.Write(R.f01Menopausia)
        BW.Write(R.f02EstudioPorVia)
        BW.Write(R.f03UteroLongitudinal)
        BW.Write(R.f04UteroAnteroposterior)
        BW.Write(R.f05UteroTransverso)
        BW.Write(R.f06OvarioDerechoLongitudinal)
        BW.Write(R.f07OvarioDerechoTransverso)
        BW.Write(R.f08OvarioDerechoAnteroPosterior)
        BW.Write(R.f09OvarioIzquierdoLongitudinal)
        BW.Write(R.f10OvarioIzquierdoTransverso)
        BW.Write(R.f11OvarioIzquierdoAnteroPosterior)
        BW.Write(R.f12FoliculoDerecho01)
        BW.Write(R.f13FoliculoDerecho02)
        BW.Write(R.f14FoliculoDerecho03)
        BW.Write(R.f15FoliculoDerecho04)
        BW.Write(R.f16FoliculoIzquierdo01)
        BW.Write(R.f17FoliculoIzquierdo02)
        BW.Write(R.f18FoliculoIzquierdo03)
        BW.Write(R.f19FoliculoIzquierdo04)
        BW.Write(R.f20EndometrioGrosor)
        BW.Write(R.f21ObsGinecologicas)
        BW.Write(R.f22OtrosA)
        BW.Write(R.f23OtrosB)
        BW.Write(R.f24OtrosC)
        BW.Write(R.f25AdicionalesGin)
        BW.Write(R.r01SGPromedio)
        BW.Write(R.r02EGxSG)
        BW.Write(R.r03EGxLCC)
        BW.Write(R.r04EG1erT)
        BW.Write(R.r05DBPc)
        BW.Write(R.r06CirCef)
        BW.Write(R.r07IndCef)
        BW.Write(R.r08CirAbd)
        BW.Write(R.r09DBF)
        BW.Write(R.r10EGxDBP)
        BW.Write(R.r11EGxDBPc)
        BW.Write(R.r12EGxCC)
        BW.Write(R.r13EGxCA)
        BW.Write(R.r14EGxFemur)
        BW.Write(R.r15PesoEstimado)
        BW.Write(R.r16PesoenBaseA)
        BW.Write(R.r17EG2y3erT)
        BW.Write(R.r18DiaCiclo)
        BW.Write(R.r19OtroA)
        BW.Write(R.r20OtroB)
        BW.Write(R.r21OtroC)
        BW.Write(R.e44ChorizoDiagnostico)
        BW.Write(R.c09NombreInforme)

        BW.Close()
        FS.Close()

        'parte en que se graban las fotos de este control
        ' If NumerodeFotosNuevas >= 0 Then
        '    Dim T As Integer 'contador de las fotos
        'Dim Fechaformateada As String
        'Dim NombreNuevo As String 'nombre del archivo receptor de la foto

        'crea el directorio de destino si no existe
        'If Directory.Exists(Form1.PathImagenes) = False Then
        '    Directory.CreateDirectory(Form1.PathImagenes)
        ' End If

        'construye parte del nombre del archivo destino solo falta el numero final
        'Fechaformateada = FechaInicioControl.ToString("s")
        'Fechaformateada = Fechaformateada.Remove(13, 1) 'le quita el primer igual a de la hora
        'Fechaformateada = Fechaformateada.Remove(15, 1) 'le quita el segundo igual a de la hora

        'For T = 0 To NumerodeFotosNuevas
        ' If T < 10 Then
        'construye el nombre completo del archivo nuevo le pone un 0 si tiene menos de 2 cifras
        '   NombreNuevo = NombreBaseFotos & "-" & Fechaformateada & "-0" & T & ".bmp"
        ' Else
        '     NombreNuevo = NombreBaseFotos & "-" & Fechaformateada & "-" & T & ".bmp"
        ' End If
        ' File.Copy(ArchivoFotoOrigen(T), NombreNuevo)
        'Next
        ' End If

    End Sub




    Private Sub EscribeContenidoControlEcografico()
        Dim FS As FileStream
        Dim BW As BinaryWriter


        FS = New FileStream(NombreControlEcografico, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim REnum As IEnumerator
        REnum = arrayEcosDelPacienteSeleccionado.GetEnumerator
        Dim H As New Form1.TablaDeDatosEcograficos()

        Dim contador As Integer = 0
        While REnum.MoveNext
            H = Nothing
            H = CType(REnum.Current, Form1.TablaDeDatosEcograficos)
            BW.Write(H.c00TipoDeEstudio)
            BW.Write(H.c01FechaControl)
            BW.Write(H.c02Paridad)
            BW.Write(H.c03FUR)
            BW.Write(H.c04FPP)
            BW.Write(H.c05EGxFUR)
            BW.Write(H.c06IDx)
            BW.Write(H.c07Nombre)
            BW.Write(H.c08Edad)
            BW.Write(H.d01SGlongitudinal)
            BW.Write(H.d02SGanteroposterior)
            BW.Write(H.d03SGtransversal)
            BW.Write(H.d04LCC)
            BW.Write(H.d05ImplatacionSG)
            BW.Write(H.d06EmbrionVisible)
            BW.Write(H.d07MovimientosPresentes)
            BW.Write(H.d08ActividadCardiaca)
            BW.Write(H.d09Comentarios1erT)
            BW.Write(H.d10OtroA)
            BW.Write(H.d11AdicionalesB1erT)
            BW.Write(H.d12IDxAdicionales1erT)
            BW.Write(H.d13Adicionales1erT)
            BW.Write(H.e01Presentacion)
            BW.Write(H.e02Situacion)
            BW.Write(H.e03Posicion)
            BW.Write(H.e04Cabeza)
            BW.Write(H.e05Ventriculos)
            BW.Write(H.e06Columna)
            BW.Write(H.e07Torax)
            BW.Write(H.e08Corazon)
            BW.Write(H.e09Abdomen)
            BW.Write(H.e10Riñones)
            BW.Write(H.e11Extremidades)
            BW.Write(H.e12Notas01del2y3erT)
            BW.Write(H.e13DiametroBiParietal)
            BW.Write(H.e14DiametroOccipitoFrontal)
            BW.Write(H.e15DiametroAnteroPosteriorTorax)
            BW.Write(H.e16DiametroAnteroPosteriorCorazon)
            BW.Write(H.e17aDiametroAnteroPosteriorAbdomen)
            BW.Write(H.e17bDiametroTransversoAbdomen)
            BW.Write(H.e18Aorta)
            BW.Write(H.e19VenaCava)
            BW.Write(H.e20LongitudSacro)
            BW.Write(H.e21LongitudFemur)
            BW.Write(H.e22Actitud)
            BW.Write(H.e23Tono)
            BW.Write(H.e24MovimientosFetales)
            BW.Write(H.e25ActividadCardiaca)
            BW.Write(H.e26MovimientosRespiratorios)
            BW.Write(H.e27RelacionAortoCava)
            BW.Write(H.e28CamaraGastrica)
            BW.Write(H.e29Intestino)
            BW.Write(H.e30Vejiga)
            BW.Write(H.e31Notas02del2y3erT)
            BW.Write(H.e32LocalizacionPlacenta)
            BW.Write(H.e33GrosorPlacenta)
            BW.Write(H.e34GradoPlacenta)
            BW.Write(H.e35LiquidoAmniotico)
            BW.Write(H.e36ILA)
            BW.Write(H.e37CordonUmbilical)
            BW.Write(H.e38Notas03del2y3erT)
            BW.Write(H.e39Embarazo)
            BW.Write(H.e40Feto)
            BW.Write(H.e41BiometricosAdicionales)
            BW.Write(H.e42Rostro)
            BW.Write(H.e43Sexo)
            BW.Write(H.f01Menopausia)
            BW.Write(H.f02EstudioPorVia)
            BW.Write(H.f03UteroLongitudinal)
            BW.Write(H.f04UteroAnteroposterior)
            BW.Write(H.f05UteroTransverso)
            BW.Write(H.f06OvarioDerechoLongitudinal)
            BW.Write(H.f07OvarioDerechoTransverso)
            BW.Write(H.f08OvarioDerechoAnteroPosterior)
            BW.Write(H.f09OvarioIzquierdoLongitudinal)
            BW.Write(H.f10OvarioIzquierdoTransverso)
            BW.Write(H.f11OvarioIzquierdoAnteroPosterior)
            BW.Write(H.f12FoliculoDerecho01)
            BW.Write(H.f13FoliculoDerecho02)
            BW.Write(H.f14FoliculoDerecho03)
            BW.Write(H.f15FoliculoDerecho04)
            BW.Write(H.f16FoliculoIzquierdo01)
            BW.Write(H.f17FoliculoIzquierdo02)
            BW.Write(H.f18FoliculoIzquierdo03)
            BW.Write(H.f19FoliculoIzquierdo04)
            BW.Write(H.f20EndometrioGrosor)
            BW.Write(H.f21ObsGinecologicas)
            BW.Write(H.f22OtrosA)
            BW.Write(H.f23OtrosB)
            BW.Write(H.f24OtrosC)
            BW.Write(H.f25AdicionalesGin)
            BW.Write(H.r01SGPromedio)
            BW.Write(H.r02EGxSG)
            BW.Write(H.r03EGxLCC)
            BW.Write(H.r04EG1erT)
            BW.Write(H.r05DBPc)
            BW.Write(H.r06CirCef)
            BW.Write(H.r07IndCef)
            BW.Write(H.r08CirAbd)
            BW.Write(H.r09DBF)
            BW.Write(H.r10EGxDBP)
            BW.Write(H.r11EGxDBPc)
            BW.Write(H.r12EGxCC)
            BW.Write(H.r13EGxCA)
            BW.Write(H.r14EGxFemur)
            BW.Write(H.r15PesoEstimado)
            BW.Write(H.r16PesoenBaseA)
            BW.Write(H.r17EG2y3erT)
            BW.Write(H.r18DiaCiclo)
            BW.Write(H.r19OtroA)
            BW.Write(H.r20OtroB)
            BW.Write(H.r21OtroC)
            BW.Write(H.e44ChorizoDiagnostico)
            BW.Write(H.c09NombreInforme)
            contador += 1
        End While
        BW.Close()
        FS.Close()

        'parte en que se graban las fotos de este control
        'If NumerodeFotosNuevas >= 0 Then
        'Dim T As Integer 'contador de las fotos
        'Dim Fechaformateada As String
        'Dim NombreNuevo As String 'nombre del archivo receptor de la foto

        'crea el directorio de destino si no existe
        'If Directory.Exists(Form1.PathImagenes) = False Then
        'Directory.CreateDirectory(Form1.PathImagenes)
        'End If

        'construye parte del nombre del archivo destino solo falta el numero final
        'Fechaformateada = FechaInicioControl.ToString("s")
        'Fechaformateada = Fechaformateada.Remove(13, 1) 'le quita el primer igual a de la hora
        'Fechaformateada = Fechaformateada.Remove(15, 1) 'le quita el segundo igual a de la hora

        'For T = 0 To NumerodeFotosNuevas
        'If T Then ' < 10 Then
        'construye el nombre completo del archivo nuevo le pone un 0 si tiene menos de 2 cifras
        'NombreNuevo = NombreBaseFotos & "-" & Fechaformateada & "-0" & T & ".bmp"
        'Else
        'NombreNuevo = NombreBaseFotos & "-" & Fechaformateada & "-" & T & ".bmp"
        'End If
        'File.Copy(ArchivoFotoOrigen(T), NombreNuevo)
        'Next
        'End If

    End Sub

    Private Sub SustituyeElInformeSeleccionado()
        Dim FS As FileStream
        Dim BW As BinaryWriter

        Dim FechacomoDate As Date
        'dim FechaparaelFUR As Date
        Dim FechaComoShortDateString As String
        Dim H As New Form1.TablaDeDatosEcograficos()
        Dim REnum As IEnumerator
        Dim contador As Integer = 0

        FS = New FileStream(NombreControlEcografico, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        REnum = arrayEcosDelPacienteSeleccionado.GetEnumerator

        'primero asigna el informe seleccionado a la variable
        'este informe se guard a en la estructura "R" ojo
        FechacomoDate = R.c01FechaControl
        strFechaInicioInformeSeleccionadoSDS = FechacomoDate.ToShortDateString

        While REnum.MoveNext
            H = Nothing
            H = CType(REnum.Current, Form1.TablaDeDatosEcograficos)

            FechacomoDate = H.c01FechaControl
            FechaComoShortDateString = FechacomoDate.ToShortDateString

            If FechaComoShortDateString = strFechaInicioInformeSeleccionadoSDS Then
                'este es el informe que se desea sustituir, utiliza la
                'estructura "R" en vez de la H que es donde esta lo del disco
                BW.Write(R.c00TipoDeEstudio)
                BW.Write(R.c01FechaControl)
                BW.Write(R.c02Paridad)
                BW.Write(R.c03FUR)
                BW.Write(R.c04FPP)
                BW.Write(R.c05EGxFUR)
                BW.Write(R.c06IDx)
                BW.Write(R.c07Nombre)
                BW.Write(R.c08Edad)
                BW.Write(R.d01SGlongitudinal)
                BW.Write(R.d02SGanteroposterior)
                BW.Write(R.d03SGtransversal)
                BW.Write(R.d04LCC)
                BW.Write(R.d05ImplatacionSG)
                BW.Write(R.d06EmbrionVisible)
                BW.Write(R.d07MovimientosPresentes)
                BW.Write(R.d08ActividadCardiaca)
                BW.Write(R.d09Comentarios1erT)
                BW.Write(R.d10OtroA)
                BW.Write(R.d11AdicionalesB1erT)
                BW.Write(R.d12IDxAdicionales1erT)
                BW.Write(R.d13Adicionales1erT)
                BW.Write(R.e01Presentacion)
                BW.Write(R.e02Situacion)
                BW.Write(R.e03Posicion)
                BW.Write(R.e04Cabeza)
                BW.Write(R.e05Ventriculos)
                BW.Write(R.e06Columna)
                BW.Write(R.e07Torax)
                BW.Write(R.e08Corazon)
                BW.Write(R.e09Abdomen)
                BW.Write(R.e10Riñones)
                BW.Write(R.e11Extremidades)
                BW.Write(R.e12Notas01del2y3erT)
                BW.Write(R.e13DiametroBiParietal)
                BW.Write(R.e14DiametroOccipitoFrontal)
                BW.Write(R.e15DiametroAnteroPosteriorTorax)
                BW.Write(R.e16DiametroAnteroPosteriorCorazon)
                BW.Write(R.e17aDiametroAnteroPosteriorAbdomen)
                BW.Write(R.e17bDiametroTransversoAbdomen)
                BW.Write(R.e18Aorta)
                BW.Write(R.e19VenaCava)
                BW.Write(R.e20LongitudSacro)
                BW.Write(R.e21LongitudFemur)
                BW.Write(R.e22Actitud)
                BW.Write(R.e23Tono)
                BW.Write(R.e24MovimientosFetales)
                BW.Write(R.e25ActividadCardiaca)
                BW.Write(R.e26MovimientosRespiratorios)
                BW.Write(R.e27RelacionAortoCava)
                BW.Write(R.e28CamaraGastrica)
                BW.Write(R.e29Intestino)
                BW.Write(R.e30Vejiga)
                BW.Write(R.e31Notas02del2y3erT)
                BW.Write(R.e32LocalizacionPlacenta)
                BW.Write(R.e33GrosorPlacenta)
                BW.Write(R.e34GradoPlacenta)
                BW.Write(R.e35LiquidoAmniotico)
                BW.Write(R.e36ILA)
                BW.Write(R.e37CordonUmbilical)
                BW.Write(R.e38Notas03del2y3erT)
                BW.Write(R.e39Embarazo)
                BW.Write(R.e40Feto)
                BW.Write(R.e41BiometricosAdicionales)
                BW.Write(R.e42Rostro)
                BW.Write(R.e43Sexo)
                BW.Write(R.f01Menopausia)
                BW.Write(R.f02EstudioPorVia)
                BW.Write(R.f03UteroLongitudinal)
                BW.Write(R.f04UteroAnteroposterior)
                BW.Write(R.f05UteroTransverso)
                BW.Write(R.f06OvarioDerechoLongitudinal)
                BW.Write(R.f07OvarioDerechoTransverso)
                BW.Write(R.f08OvarioDerechoAnteroPosterior)
                BW.Write(R.f09OvarioIzquierdoLongitudinal)
                BW.Write(R.f10OvarioIzquierdoTransverso)
                BW.Write(R.f11OvarioIzquierdoAnteroPosterior)
                BW.Write(R.f12FoliculoDerecho01)
                BW.Write(R.f13FoliculoDerecho02)
                BW.Write(R.f14FoliculoDerecho03)
                BW.Write(R.f15FoliculoDerecho04)
                BW.Write(R.f16FoliculoIzquierdo01)
                BW.Write(R.f17FoliculoIzquierdo02)
                BW.Write(R.f18FoliculoIzquierdo03)
                BW.Write(R.f19FoliculoIzquierdo04)
                BW.Write(R.f20EndometrioGrosor)
                BW.Write(R.f21ObsGinecologicas)
                BW.Write(R.f22OtrosA)
                BW.Write(R.f23OtrosB)
                BW.Write(R.f24OtrosC)
                BW.Write(R.f25AdicionalesGin)
                BW.Write(R.r01SGPromedio)
                BW.Write(R.r02EGxSG)
                BW.Write(R.r03EGxLCC)
                BW.Write(R.r04EG1erT)
                BW.Write(R.r05DBPc)
                BW.Write(R.r06CirCef)
                BW.Write(R.r07IndCef)
                BW.Write(R.r08CirAbd)
                BW.Write(R.r09DBF)
                BW.Write(R.r10EGxDBP)
                BW.Write(R.r11EGxDBPc)
                BW.Write(R.r12EGxCC)
                BW.Write(R.r13EGxCA)
                BW.Write(R.r14EGxFemur)
                BW.Write(R.r15PesoEstimado)
                BW.Write(R.r16PesoenBaseA)
                BW.Write(R.r17EG2y3erT)
                BW.Write(R.r18DiaCiclo)
                BW.Write(R.r19OtroA)
                BW.Write(R.r20OtroB)
                BW.Write(R.r21OtroC)
                BW.Write(R.e44ChorizoDiagnostico)
                BW.Write(R.c09NombreInforme)
                contador += 1
            Else
                'este no es el informe a sustituir se vuelve a 
                'escribir lo mismo "H"
                BW.Write(H.c00TipoDeEstudio)
                BW.Write(H.c01FechaControl)
                BW.Write(H.c02Paridad)
                BW.Write(H.c03FUR)
                BW.Write(H.c04FPP)
                BW.Write(H.c05EGxFUR)
                BW.Write(H.c06IDx)
                BW.Write(H.c07Nombre)
                BW.Write(H.c08Edad)
                BW.Write(H.d01SGlongitudinal)
                BW.Write(H.d02SGanteroposterior)
                BW.Write(H.d03SGtransversal)
                BW.Write(H.d04LCC)
                BW.Write(H.d05ImplatacionSG)
                BW.Write(H.d06EmbrionVisible)
                BW.Write(H.d07MovimientosPresentes)
                BW.Write(H.d08ActividadCardiaca)
                BW.Write(H.d09Comentarios1erT)
                BW.Write(H.d10OtroA)
                BW.Write(H.d11AdicionalesB1erT)
                BW.Write(H.d12IDxAdicionales1erT)
                BW.Write(H.d13Adicionales1erT)
                BW.Write(H.e01Presentacion)
                BW.Write(H.e02Situacion)
                BW.Write(H.e03Posicion)
                BW.Write(H.e04Cabeza)
                BW.Write(H.e05Ventriculos)
                BW.Write(H.e06Columna)
                BW.Write(H.e07Torax)
                BW.Write(H.e08Corazon)
                BW.Write(H.e09Abdomen)
                BW.Write(H.e10Riñones)
                BW.Write(H.e11Extremidades)
                BW.Write(H.e12Notas01del2y3erT)
                BW.Write(H.e13DiametroBiParietal)
                BW.Write(H.e14DiametroOccipitoFrontal)
                BW.Write(H.e15DiametroAnteroPosteriorTorax)
                BW.Write(H.e16DiametroAnteroPosteriorCorazon)
                BW.Write(H.e17aDiametroAnteroPosteriorAbdomen)
                BW.Write(H.e17bDiametroTransversoAbdomen)
                BW.Write(H.e18Aorta)
                BW.Write(H.e19VenaCava)
                BW.Write(H.e20LongitudSacro)
                BW.Write(H.e21LongitudFemur)
                BW.Write(H.e22Actitud)
                BW.Write(H.e23Tono)
                BW.Write(H.e24MovimientosFetales)
                BW.Write(H.e25ActividadCardiaca)
                BW.Write(H.e26MovimientosRespiratorios)
                BW.Write(H.e27RelacionAortoCava)
                BW.Write(H.e28CamaraGastrica)
                BW.Write(H.e29Intestino)
                BW.Write(H.e30Vejiga)
                BW.Write(H.e31Notas02del2y3erT)
                BW.Write(H.e32LocalizacionPlacenta)
                BW.Write(H.e33GrosorPlacenta)
                BW.Write(H.e34GradoPlacenta)
                BW.Write(H.e35LiquidoAmniotico)
                BW.Write(H.e36ILA)
                BW.Write(H.e37CordonUmbilical)
                BW.Write(H.e38Notas03del2y3erT)
                BW.Write(H.e39Embarazo)
                BW.Write(H.e40Feto)
                BW.Write(H.e41BiometricosAdicionales)
                BW.Write(H.e42Rostro)
                BW.Write(H.e43Sexo)
                BW.Write(H.f01Menopausia)
                BW.Write(H.f02EstudioPorVia)
                BW.Write(H.f03UteroLongitudinal)
                BW.Write(H.f04UteroAnteroposterior)
                BW.Write(H.f05UteroTransverso)
                BW.Write(H.f06OvarioDerechoLongitudinal)
                BW.Write(H.f07OvarioDerechoTransverso)
                BW.Write(H.f08OvarioDerechoAnteroPosterior)
                BW.Write(H.f09OvarioIzquierdoLongitudinal)
                BW.Write(H.f10OvarioIzquierdoTransverso)
                BW.Write(H.f11OvarioIzquierdoAnteroPosterior)
                BW.Write(H.f12FoliculoDerecho01)
                BW.Write(H.f13FoliculoDerecho02)
                BW.Write(H.f14FoliculoDerecho03)
                BW.Write(H.f15FoliculoDerecho04)
                BW.Write(H.f16FoliculoIzquierdo01)
                BW.Write(H.f17FoliculoIzquierdo02)
                BW.Write(H.f18FoliculoIzquierdo03)
                BW.Write(H.f19FoliculoIzquierdo04)
                BW.Write(H.f20EndometrioGrosor)
                BW.Write(H.f21ObsGinecologicas)
                BW.Write(H.f22OtrosA)
                BW.Write(H.f23OtrosB)
                BW.Write(H.f24OtrosC)
                BW.Write(H.f25AdicionalesGin)
                BW.Write(H.r01SGPromedio)
                BW.Write(H.r02EGxSG)
                BW.Write(H.r03EGxLCC)
                BW.Write(H.r04EG1erT)
                BW.Write(H.r05DBPc)
                BW.Write(H.r06CirCef)
                BW.Write(H.r07IndCef)
                BW.Write(H.r08CirAbd)
                BW.Write(H.r09DBF)
                BW.Write(H.r10EGxDBP)
                BW.Write(H.r11EGxDBPc)
                BW.Write(H.r12EGxCC)
                BW.Write(H.r13EGxCA)
                BW.Write(H.r14EGxFemur)
                BW.Write(H.r15PesoEstimado)
                BW.Write(H.r16PesoenBaseA)
                BW.Write(H.r17EG2y3erT)
                BW.Write(H.r18DiaCiclo)
                BW.Write(H.r19OtroA)
                BW.Write(H.r20OtroB)
                BW.Write(H.r21OtroC)
                BW.Write(H.e44ChorizoDiagnostico)
                BW.Write(H.c09NombreInforme)
                contador += 1
            End If
        End While
        BW.Close()
        FS.Close()
    End Sub

    Private Sub ActualizaContenidoHistoria()
        Dim FS As FileStream
        Dim BW As BinaryWriter
        Dim BR As BinaryReader
        Dim LineaDatos As String

        FS = New FileStream(NombreHistoria, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)

        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim C As Integer
        Form1.ElementosHistoria.Clear()
        C = BR.PeekChar
        Dim contador As Integer = 0
        While FS.Position < FS.Length
            LineaDatos = BR.ReadString
            Form1.ElementosHistoria.Add(LineaDatos)
            C = BR.PeekChar
            contador += 1
        End While
        BR.Close()
        FS.Close()

        LineaDatos = Form1.PSstrNumeroHistoriaSeleccionada & "-Control Ecográfico"
        Form1.ElementosHistoria.Add(LineaDatos)

        'ahora actualiza la historia seleccionada con los datos nuevos crea el nexo

        FS = New FileStream(NombreHistoria, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)

        'ubica al principio el contenido de la subhistoria
        Dim REnum As IEnumerator
        REnum = Form1.ElementosHistoria.GetEnumerator
        'pone el archivo al inicio
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        contador = 0
        While REnum.MoveNext
            LineaDatos = CType(REnum.Current, String)
            BW.Write(LineaDatos)
            contador += 1
        End While
        'cierra todo
        FS.Close()
        BW.Close()
    End Sub

    Private Sub ActualizaContenidoHistoriaConLasImagenes()
        Dim FS As FileStream
        Dim BW As BinaryWriter
        Dim BR As BinaryReader
        Dim LineaDatos As String

        FS = New FileStream(NombreHistoria, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)

        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim C As Integer
        Form1.ElementosHistoria.Clear()
        C = BR.PeekChar
        Dim contador As Integer = 0
        While FS.Position < FS.Length
            LineaDatos = BR.ReadString
            Form1.ElementosHistoria.Add(LineaDatos)
            C = BR.PeekChar
            contador += 1
        End While
        BR.Close()
        FS.Close()

        LineaDatos = Form1.PSstrNumeroHistoriaSeleccionada & "-Imágenes Ecográficas"
        Form1.ElementosHistoria.Add(LineaDatos)

        'ahora actualiza la historia seleccionada con los datos nuevos crea el nexo

        FS = New FileStream(NombreHistoria, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)

        'ubica al principio el contenido de la subhistoria
        Dim REnum As IEnumerator
        REnum = Form1.ElementosHistoria.GetEnumerator
        'pone el archivo al inicio
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        contador = 0
        While REnum.MoveNext
            LineaDatos = CType(REnum.Current, String)
            BW.Write(LineaDatos)
            contador += 1
        End While
        'cierra todo
        FS.Close()
        BW.Close()
    End Sub

    Private Sub ListBoxINFORMES_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxInformes.DoubleClick
        If ListBoxInformes.SelectedItem <> "" Then
            AbreElcontrolSeleccionado()
        End If

    End Sub

    Private Sub ListBoxINFORMES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxInformes.SelectedIndexChanged
        botSelecciona.Enabled = True
        botElimina.Enabled = True
        botRenombra.Enabled = True
    End Sub

    Private Sub botSelecciona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSelecciona.Click
        AbreElcontrolSeleccionado()
    End Sub

    Private Sub AbreElcontrolSeleccionado()
        Dim dateFechaParaComparar As Date
        Dim strFechaParaCompararSDS As String

        Dim Partes() As String
        Dim Encabezado As String

        'comprobacion de descarte de datos modificados
        If DatosModificados = True Then
            Dim Reply As MsgBoxResult
            Reply = MsgBox("Si abres otro Informe se perderán los datos nuevos no salvados. Deseas abrirlo de todas formas?", MsgBoxStyle.YesNo, "Selecciona otro Informe Ecográfico")
            If Reply = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        'primero borra todos los datos antes de rellenar los nuevos
        BorraDatosEnPantalla()

        Encabezado = ListBoxInformes.SelectedItem
        Partes = Split(Encabezado, "|")
        strFechaInicioInformeSeleccionadoSDS = Partes(0)

        For Each est As Form1.TablaDeDatosEcograficos In arrayEcosDelPacienteSeleccionado
            dateFechaParaComparar = CType(est.c01FechaControl, Date)
            strFechaParaCompararSDS = dateFechaParaComparar.ToShortDateString
            If strFechaParaCompararSDS = strFechaInicioInformeSeleccionadoSDS Then

                'este es asiga est a R
                R = est
                'ahora lavariables publicas
                dateFechaInicioInformeSeleccionado = dateFechaParaComparar
                strFechaInicioInformeSeleccionadoSDS = dateFechaInicioInformeSeleccionado.ToShortDateString

                'ahora actualiza el texto con la estructura
                ActualizaTextoConLaEstructura()
                'no se esta creando un nuevo control 
                NuevoEco = False
                'pone visible el tab del informe
                TabControl1.SelectedIndex = 1
                PanelImpresion.Visible = True

                Exit For

            End If
        Next

    End Sub

    Private Sub ActualizaTextoConLaEstructura()
        'Dim dateFecha As Date
        'èsta var es para saber si me encuentro con un eco viejo q no tenga chorizo biometrico
        Dim booEcoEsViejo As Boolean = False
        'Dim booEcoNoTeniaAdicionales1erT As Boolean = False
        'Dim booEcoNoTeniaAdicionalesB1erT As Boolean = False
        'Dim booEcoNoTeniaIDX1erT As Boolean = False
        'Dim booEcoNoTeniaAdicionalesGIN As Boolean = False

        'dateFechaInicioInformeSeleccionado = R.c01FechaControl (ya fue seteada en el sub que llama e este)

        If R.c00TipoDeEstudio = "1" Then
            'es un estudio obs del 1erT

            'llena los labels de arriba
            txtFechaInicioControl.Text = dateFechaInicioInformeSeleccionado.ToLongDateString
            labInforme.Text = R.c09NombreInforme
            txtFechaInicioControl2.Text = dateFechaInicioInformeSeleccionado.ToLongDateString
            labInforme2.Text = R.c09NombreInforme

            'visualiza el panel adecuado
            PanelNuevoControlGinecologico.Visible = False
            PanelNuevoControl1erT.Visible = True
            PanelNuevoControl2y3erT.Visible = False

            labNombre1erT.Text = R.c07Nombre
            txtEdad1erT.Text = R.c08Edad
            txtParidad1erT.Text = R.c02Paridad
            labFechaControl1erT.Text = dateFechaInicioInformeSeleccionado.ToShortDateString
            labFUR1erT.Text = R.c03FUR
            labFPP1erT.Text = R.c04FPP
            lab1ertEGxFUR01.Text = R.c05EGxFUR
            lab1ertEGxFUR02.Text = R.c05EGxFUR
            txt1erSGlong.Text = R.d01SGlongitudinal
            txt1erSGantPost.Text = R.d02SGanteroposterior
            txt1erSGtrans.Text = R.d03SGtransversal
            txt1erLCC.Text = R.d04LCC

            'estas dos lineas siguiente se actualizan con los adicionales de comen e IDx del 1erT
            'txt1erTComentarios01.Text = R.d09Comentarios1erT
            'txt1erTidx01.Text = R.c06IDx

            'primero borra todos los radbuttons
            BorraRADbuttons1erT()

            Select Case R.d05ImplatacionSG
                Case "1"
                    Rad1erTImplantacion1.Checked = True
                Case "2"
                    Rad1erTImplantacion2.Checked = True
                Case "3"
                    Rad1erTImplantacion3.Checked = True
                Case "4"
                    Rad1erTImplantacion4.Checked = True
                Case Else
                    'si no se marco ninguno se deja asi
                    'Rad1erTImplantacion1.Checked = True
            End Select

            Select Case R.d06EmbrionVisible
                Case "1"
                    Rad1erTEmbrion1.Checked = True
                Case "2"
                    Rad1erTEmbrion2.Checked = True
                Case Else
                    'si no se marco ninguno se deja igual
                    'Rad1erTEmbrion1.Checked = True
            End Select

            Select Case R.d07MovimientosPresentes
                Case "1"
                    Rad1erTMovimientos1.Checked = True
                Case "2"
                    Rad1erTMovimientos2.Checked = True
                Case Else
                    'si no se marco ninguno se deja igual
                    'Rad1erTMovimientos1.Checked = True
            End Select

            Select Case R.d08ActividadCardiaca
                Case "1"
                    Rad1erTActCardiaca1.Checked = True
                Case "2"
                    Rad1erTActCardiaca2.Checked = True
                Case Else
                    'si no se marco ninguno se deja igual
                    'Rad1erTActCardiaca1.Checked = True
            End Select
            '---------------------------------------------------------

            'ahora los datos adicionales del 1er trimestre
            If R.d13Adicionales1erT = "" Then 'si esta vacio...
                'si esta vacio inicializa el chorizo para convertir los ecos viejos en nuevos
                For Me.Cont = 0 To 15
                    ParteChorizo1erT(Cont) = "@" 'inicializa las parte con una arroba
                Next
                'ahora crea el chorizo con las partes arrobadas...
                Chorizo1erT = ""
                For Me.Cont = 0 To 14
                    Chorizo1erT += ParteChorizo1erT(Cont) & "|"
                Next
                Chorizo1erT += ParteChorizo1erT(15)    'la ultima pa no ponerle el palito al final
                'actualiza la estructura pa dejar la vaina ya transformada pues
                R.d13Adicionales1erT = Chorizo1erT
                'como se encontro un eco viejo sin datos adicionales del 1er t pone la bandera a true
                booEcoEsViejo = True

                'finalmente pone en blanco todas las casillas dependientes no...
                txt1erVVlong.Clear()
                txt1erVVantPost.Clear()
                rad1erTEstudioAbd.Checked = False
                rad1erTestudioTV.Checked = False
                rad1erTfrec35.Checked = False
                rad1erTfrec50.Checked = False
                rad1erTfrec75.Checked = False
                rad1erTsacoGestacional01.Checked = False
                rad1erTsacoGestacional02.Checked = False
                rad1erTVitelina01.Checked = False
                rad1erTVitelina02.Checked = False
                rad1erTVejiga01.Checked = False
                rad1erTVejiga02.Checked = False

            Else 'si no esta vacio entonces ya existe un chorizo con o sin datos pero existe
                'primero traduce el chorizo en sus partes
                'EcoEsViejo = False esta variable ya se inicializo a false solo si hay un chorizo nuevo se pondra a true
                Chorizo1erT = R.d13Adicionales1erT 'carga el chorizo
                ParteChorizo1erT = Chorizo1erT.Split("|") 'pasa las partes a su receptor

                'inicia el recorrido

                'parte (0) tipo de estudio abdominal o trasvaginal
                If ParteChorizo1erT(0) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erTEstudioAbd.Checked = False
                    rad1erTestudioTV.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(0) = "1" Then
                        rad1erTEstudioAbd.Checked = True
                    ElseIf ParteChorizo1erT(0) = "2" Then
                        rad1erTestudioTV.Checked = True
                    End If
                End If

                'parte (1) frecuencia del trasductor
                If ParteChorizo1erT(1) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erTfrec35.Checked = False
                    rad1erTfrec50.Checked = False
                    rad1erTfrec75.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(1) = "1" Then
                        rad1erTfrec35.Checked = True
                    ElseIf ParteChorizo1erT(1) = "2" Then
                        rad1erTfrec50.Checked = True
                    ElseIf ParteChorizo1erT(1) = "3" Then
                        rad1erTfrec75.Checked = True
                    End If
                End If

                'parte (2) vesicula vitelina longitudinal
                If ParteChorizo1erT(2) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erVVlong.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erVVlong.Text = ParteChorizo1erT(2)
                End If

                'parte (3) vesicula vitelina anteroposterior
                If ParteChorizo1erT(3) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erVVantPost.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erVVantPost.Text = ParteChorizo1erT(3)
                End If

                'parte (4) vesicula vitelina anatomicos
                If ParteChorizo1erT(4) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erTVitelina01.Checked = False
                    rad1erTVitelina02.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(4) = "1" Then
                        rad1erTVitelina01.Checked = True
                    ElseIf ParteChorizo1erT(4) = "2" Then
                        rad1erTVitelina02.Checked = True
                    End If
                End If

                'parte (5) vejiga anatomicos
                If ParteChorizo1erT(5) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erTVejiga01.Checked = False
                    rad1erTVejiga02.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(5) = "1" Then
                        rad1erTVejiga01.Checked = True
                    ElseIf ParteChorizo1erT(5) = "2" Then
                        rad1erTVejiga02.Checked = True
                    End If
                End If

                'parte (6) del chorizo 1er localizacion de embarazo intrauterino o ectopico
                If ParteChorizo1erT(6) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erTLocalizacionEmbarazo01.Checked = False
                    rad1erTlocalizacionEmbarazo02.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(6) = "1" Then
                        rad1erTLocalizacionEmbarazo01.Checked = True
                    ElseIf ParteChorizo1erT(6) = "2" Then
                        rad1erTlocalizacionEmbarazo02.Checked = True
                    End If
                End If

                'parte (7) del chorizo 1er t. tipo de embarazo simple o gemelar
                If ParteChorizo1erT(7) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erTtipoEmbarazo01.Checked = False
                    rad1erTtipoEmbarazo02.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(7) = "1" Then
                        rad1erTtipoEmbarazo01.Checked = True
                    ElseIf ParteChorizo1erT(7) = "2" Then
                        rad1erTtipoEmbarazo02.Checked = True
                    End If
                End If

                'parte (8) del chorizo 1er t. translucencia
                If ParteChorizo1erT(8) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erTtranslucencia01.Checked = False
                    rad1erTtranslucencia02.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(8) = "1" Then
                        rad1erTtranslucencia01.Checked = True
                    ElseIf ParteChorizo1erT(8) = "2" Then
                        rad1erTtranslucencia02.Checked = True
                    End If
                End If

                'parte (9) del chorizo 1er t. huesos nasales
                If ParteChorizo1erT(9) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erThuesosNasales01.Checked = False
                    rad1erThuesosNasales02.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(9) = "1" Then
                        rad1erThuesosNasales01.Checked = True
                    ElseIf ParteChorizo1erT(9) = "2" Then
                        rad1erThuesosNasales02.Checked = True
                    End If
                End If

                'parte (10) del chorizo 1er t. ductus venoso
                If ParteChorizo1erT(10) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erTductusVenoso01.Checked = False
                    rad1erTductusVenoso02.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(10) = "1" Then
                        rad1erTductusVenoso01.Checked = True
                    ElseIf ParteChorizo1erT(10) = "2" Then
                        rad1erTductusVenoso02.Checked = True
                    End If
                End If

                'parte (11) del chorizo 1er t. anguloFrontomaxilar
                If ParteChorizo1erT(11) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erTanguloFM01.Checked = False
                    rad1erTanguloFM02.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(11) = "1" Then
                        rad1erTanguloFM01.Checked = True
                    ElseIf ParteChorizo1erT(11) = "2" Then
                        rad1erTanguloFM02.Checked = True
                    End If
                End If

                'parte (12) del chorizo 1er t. Saco Gestacional
                If ParteChorizo1erT(12) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    rad1erTsacoGestacional01.Checked = False
                    rad1erTsacoGestacional02.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizo1erT(12) = "1" Then
                        rad1erTsacoGestacional01.Checked = True
                    ElseIf ParteChorizo1erT(12) = "2" Then
                        rad1erTsacoGestacional02.Checked = True
                    End If
                End If
            End If

            'ahora los segundos adicionales del 1er trimestre

            If R.d11AdicionalesB1erT = "" Then 'si esta vacio...
                'si esta vacio inicializa el chorizo para convertir los ecos viejos en nuevos
                For intXX = 0 To 15
                    ParteChorizoB1erT(intXX) = "@" 'inicializa las parte con una arroba
                Next
                'ahora crea el chorizo con las partes arrobadas...
                ChorizoB1erT = ""
                For intXX = 0 To 14
                    ChorizoB1erT += ParteChorizoB1erT(intXX) & "|"
                Next
                ChorizoB1erT += ParteChorizoB1erT(15)    'la ultima pa no ponerle el palito al final
                'actualiza la estructura pa dejar la vaina ya transformada pues
                R.d11AdicionalesB1erT = ChorizoB1erT
                'como se encontro un eco viejo sin datos adicionales del 1er t pone la bandera a true
                booEcoEsViejo = True

                'finalmente pone en blanco todas las casillas dependientes no...
                txt1erDBP.Clear()
                txt1erCC.Clear()
                txt1erCA.Clear()
                txt1erFemur.Clear()
                txt1erTN.Clear()


            Else 'si no esta vacio entonces ya existe un chorizo con o sin datos pero existe
                'primero traduce el chorizo en sus partes
                'EcoEsViejo = False esta variable ya se inicializo a false solo si hay un chorizo nuevo se pondra a true
                ChorizoB1erT = R.d11AdicionalesB1erT 'carga el chorizo
                ParteChorizoB1erT = ChorizoB1erT.Split("|") 'pasa las partes a su receptor

                'inicia el recorrido

                'parte (0) dbp del 1er trim
                If ParteChorizoB1erT(0) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erDBP.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erDBP.Text = ParteChorizoB1erT(0)



                    If txt1erDBP.Text <> "" Then
                        'existe un dato, calcula la EGxDBP, 
                        Dim Valor = CType(txt1erDBP.Text, Integer)
                        If Valor <> 0 Then
                            EGxDBPenDias = CType(((9.54 + (0.1482 * Valor) + (0.001676 * Valor ^ 2)) * 7), Integer)
                        Else
                            'la casilla tiene valor de 0
                            EGxDBPenDias = 0
                        End If

                    Else
                        'la casilla esta vacia
                        EGxDBPenDias = 0
                    End If

                    'muestra la eg x dbp en el label de al lado
                    NumeroDiasEG = EGxDBPenDias
                    ProcesaDiasEnSemanasMasDias()
                    lab1erEGxDBP.Text = TextoDeEGenSemanasyDiasCorto

                End If

                'parte (1) cc del 1er trim
                If ParteChorizoB1erT(1) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erCC.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erCC.Text = ParteChorizoB1erT(1)

                    If txt1erCC.Text <> "" Then
                        'existe un dato, calcula la EGxcc, 
                        Dim Valor = CType(txt1erCC.Text, Integer)
                        If Valor <> 0 Then
                            EGxCCenDias = CType(((8.96 + (0.054 * Valor) + (0.0000003 * Valor ^ 3)) * 7), Integer)
                        Else
                            'la casilla tiene valor de 0
                            EGxCCenDias = 0
                        End If

                    Else
                        'la casilla esta vacia
                        EGxCCenDias = 0
                    End If

                    'muestra la eg x cc en el label de al lado
                    NumeroDiasEG = EGxCCenDias
                    ProcesaDiasEnSemanasMasDias()
                    lab1erEGxCC.Text = TextoDeEGenSemanasyDiasCorto

                End If

                'parte (2) ca del 1er trim
                If ParteChorizoB1erT(2) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erCA.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erCA.Text = ParteChorizoB1erT(2)

                    If txt1erCA.Text <> "" Then
                        'existe un dato, calcula la EGxca, 
                        Dim Valor = CType(txt1erCA.Text, Integer)
                        If Valor <> 0 Then
                            EGxCAenDias = CType(((8.14 + (0.0753 * Valor) + (0.000036 * Valor ^ 2)) * 7), Integer)
                        Else
                            'la casilla tiene valor de 0
                            EGxCAenDias = 0
                        End If

                    Else
                        'la casilla esta vacia
                        EGxCAenDias = 0
                    End If

                    'muestra la eg x ca en el label de al lado
                    NumeroDiasEG = EGxCAenDias
                    ProcesaDiasEnSemanasMasDias()
                    lab1erEGxCA.Text = TextoDeEGenSemanasyDiasCorto

                End If

                'parte (3) femur del 1er trim
                If ParteChorizoB1erT(3) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erFemur.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erFemur.Text = ParteChorizoB1erT(3)

                    If txt1erFemur.Text <> "" Then
                        'existe un dato, calcula la EGxfemur, 
                        Dim Valor = CType(txt1erFemur.Text, Integer)
                        If Valor <> 0 Then
                            EGxFEMURenDias = CType(((10.35 + (0.246 * Valor) + (0.0017 * Valor ^ 2)) * 7), Integer)
                        Else
                            'la casilla tiene valor de 0
                            EGxFEMURenDias = 0
                        End If

                    Else
                        'la casilla esta vacia
                        EGxFEMURenDias = 0
                    End If

                    'muestra la eg x femur en el label de al lado
                    NumeroDiasEG = EGxFEMURenDias
                    ProcesaDiasEnSemanasMasDias()
                    lab1erEGxFemur.Text = TextoDeEGenSemanasyDiasCorto

                End If

                'parte (4) traslucencia nucal
                If ParteChorizoB1erT(4) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erTN.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erTN.Text = ParteChorizoB1erT(4)
                End If

                'ojo quedan de la parte 5 a la 15 libres porsia

            End If

            'Calcula si puede los resultados con lo que tiene
            CalculaEGxSG()
            CalculaEGxLCC()
            CalculaEG1erTxECO()

            'ahora las IDx y Comentarios adicionales del 1er trimestre
            If R.d12IDxAdicionales1erT = "" Then 'si esta vacio...
                'si esta vacio inicializa el chorizo para convertir los ecos viejos en nuevos
                For Me.Cont = 0 To 15
                    ParteChorizoDX1erT(Cont) = "@" 'inicializa las parte con una arroba
                Next
                'ahora crea el chorizo con las partes arrobadas...
                ChorizoDX1erT = ""
                For Me.Cont = 0 To 14
                    ChorizoDX1erT += ParteChorizoDX1erT(Cont) & "|"
                Next
                ChorizoDX1erT += ParteChorizoDX1erT(15)    'la ultima pa no ponerle el palito al final
                'actualiza la estructura pa dejar la vaina ya transformada pues
                R.d12IDxAdicionales1erT = ChorizoDX1erT
                'como se encontro un eco viejo sin datos adicionales del 1er t pone la bandera a true
                booEcoEsViejo = True

                'finalmente pone en blanco todas las casillas dependientes no...
                txt1erTComentarios01.Clear()
                txt1erTcomentarios02.Clear()
                txt1erTcomentarios03.Clear()
                txt1erTcomentarios04.Clear()
                txt1erTcomentarios05.Clear()
                txt1erTidx01.Clear()
                txt1erTidx02.Clear()
                txt1erTidx03.Clear()

            Else 'si no esta vacio entonces ya existe un chorizo con o sin datos pero existe
                'primero traduce el chorizo en sus partes
                ChorizoDX1erT = R.d12IDxAdicionales1erT 'carga el chorizo
                ParteChorizoDX1erT = ChorizoDX1erT.Split("|") 'pasa las partes a su receptor

                'inicia el recorrido

                'parte (0) 1ra linea de comentarios 
                If ParteChorizoDX1erT(0) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erTComentarios01.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erTComentarios01.Text = ParteChorizoDX1erT(0)
                End If

                'parte (1) 2da linea de comentarios 
                If ParteChorizoDX1erT(1) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erTcomentarios02.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erTcomentarios02.Text = ParteChorizoDX1erT(1)
                End If

                'parte (2) 3ra linea de comentarios 
                If ParteChorizoDX1erT(2) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erTcomentarios03.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erTcomentarios03.Text = ParteChorizoDX1erT(2)
                End If

                'parte (3) 4ta linea de comentarios 
                If ParteChorizoDX1erT(3) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erTcomentarios04.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erTcomentarios04.Text = ParteChorizoDX1erT(3)
                End If

                'parte (4) 5ta linea de comentarios 
                If ParteChorizoDX1erT(4) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erTcomentarios05.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erTcomentarios05.Text = ParteChorizoDX1erT(4)
                End If

                'ojo quedan de la parte (5) a la parte (7) vacios porsia

                'parte (8) 1ra linea de diagnosticos 
                If ParteChorizoDX1erT(8) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erTidx01.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erTidx01.Text = ParteChorizoDX1erT(8)
                End If

                'parte (9) 2da linea de diagnosticos 
                If ParteChorizoDX1erT(9) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erTidx02.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erTidx02.Text = ParteChorizoDX1erT(9)
                End If

                'parte (10) 3ra linea de diagnosticos 
                If ParteChorizoDX1erT(10) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txt1erTidx03.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txt1erTidx03.Text = ParteChorizoDX1erT(10)
                End If

                'ojo quedo de la parte 11 a la parte 15 vacias porsia se le añaden mas idx despues

            End If


        ElseIf R.c00TipoDeEstudio = "2" Then
            'es un estudio obs del 2y3erT

            'llena los labels de arriba
            txtFechaInicioControl.Text = dateFechaInicioInformeSeleccionado.ToLongDateString
            labInforme.Text = R.c09NombreInforme
            txtFechaInicioControl2.Text = dateFechaInicioInformeSeleccionado.ToLongDateString
            labInforme2.Text = R.c09NombreInforme

            'visualiza el panel adecuado
            PanelNuevoControlGinecologico.Visible = False
            PanelNuevoControl1erT.Visible = False
            PanelNuevoControl2y3erT.Visible = True

            'datos 
            labNombre2y3erT.Text = R.c07Nombre
            txtEdad2y3erT.Text = R.c08Edad
            txtParidad2y3erT.Text = R.c02Paridad
            labFechaControl2y3erT.Text = dateFechaInicioInformeSeleccionado.ToShortDateString
            labFUR2y3erT.Text = R.c03FUR
            labFPP2y3erT.Text = R.c04FPP
            labEGxFUR2y3erT.Text = R.c05EGxFUR

            'ficha obstetricos
            Select Case R.e39Embarazo
                Case "1"
                    radEmbarazo01.Checked = True
                Case "2"
                    radEmbarazo02.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radEmbarazo01.Checked = True
            End Select

            Select Case R.e40Feto
                Case "1"
                    radFeto01.Checked = True
                Case "2"
                    radFeto02.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radFeto01.Checked = True
            End Select

            Select Case R.e01Presentacion
                Case "1"
                    radPresentacion1.Checked = True
                Case "2"
                    radPresentacion2.Checked = True
                Case "3"
                    radpresentacion3.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radPresentacion1.Checked = True
            End Select

            Select Case R.e02Situacion
                Case "1"
                    radSituacion1.Checked = True
                Case "2"
                    radSituacion2.Checked = True
                Case "3"
                    radSituacion3.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radSituacion1.Checked = True
            End Select

            Select Case R.e03Posicion
                Case "1"
                    radPosicion1.Checked = True
                Case "2"
                    radPosicion2.Checked = True
                Case "3"
                    radPosicion3.Checked = True
                Case "4"
                    radPosicion4.Checked = True
                Case "5"
                    radPosicion5.Checked = True
                Case "6"
                    radPosicion6.Checked = True
                Case "7"
                    radPosicion7.Checked = True
                Case "8"
                    radPosicion8.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radPosicion1.Checked = True
            End Select

            'ficha anatomicos
            Select Case R.e04Cabeza
                Case "1"
                    radCabeza1.Checked = True
                Case "2"
                    radCabeza2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radCabeza1.Checked = True
            End Select

            Select Case R.e05Ventriculos
                Case "1"
                    radVentriculo1.Checked = True
                Case "2"
                    radVentriculo2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radVentriculo1.Checked = True
            End Select

            Select Case R.e42Rostro
                Case "1"
                    radRostro1.Checked = True
                Case "2"
                    radRostro2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radRostro1.Checked = True
            End Select

            Select Case R.e06Columna
                Case "1"
                    radColumna1.Checked = True
                Case "2"
                    radColumna2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radColumna1.Checked = True
            End Select

            Select Case R.e11Extremidades
                Case "1"
                    radExtremidades1.Checked = True
                Case "2"
                    radExtremidades2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radExtremidades1.Checked = True
            End Select

            Select Case R.e07Torax
                Case "1"
                    radTorax1.Checked = True
                Case "2"
                    radTorax2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radTorax1.Checked = True
            End Select

            Select Case R.e08Corazon
                Case "1"
                    radCorazon1.Checked = True
                Case "2"
                    radCorazon2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radCorazon1.Checked = True
            End Select

            Select Case R.e09Abdomen
                Case "1"
                    radAbdomen1.Checked = True
                Case "2"
                    radAbdomen2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radAbdomen1.Checked = True
            End Select

            Select Case R.e10Riñones
                Case "1"
                    radRiñones1.Checked = True
                Case "2"
                    radRiñones2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radRiñones1.Checked = True
            End Select

            Select Case R.e43Sexo
                Case "1"
                    radSexo1.Checked = True
                Case "2"
                    radSexo2.Checked = True
                Case Else
                    'si no se marco ninguno se limpian ambos
                    radSexo1.Checked = False
                    radSexo2.Checked = False
            End Select


            'ficha Biometrica
            txtDBP.Text = R.e13DiametroBiParietal
            txtDOF.Text = R.e14DiametroOccipitoFrontal
            txtAPT.Text = R.e15DiametroAnteroPosteriorTorax
            txtAPC.Text = R.e16DiametroAnteroPosteriorCorazon
            'txtAPA.Text = R.e17aDiametroAnteroPosteriorAbdomen         ya no se usa
            txtTransAbdomen.Text = R.e17bDiametroTransversoAbdomen
            txtAorta.Text = R.e18Aorta
            'txtCava.Text = R.e19VenaCava                               ya no se usa
            txtSacro.Text = R.e20LongitudSacro
            txtFemur.Text = R.e21LongitudFemur

            'ahora los del chorizo biometrico de los datos adicionalkes de la modificacion
            If R.e41BiometricosAdicionales = "" Then 'si esta vacio...
                'si esta vacio inicializa el chorizo para convertir los ecos viejos en nuevos
                For Me.Cont = 0 To 15
                    ParteDelChorizo(Cont) = "@" 'inicializa las parte con una arroba
                Next
                'ahora crea el chorizo con las partes arrobadas...
                ChorizoBiometrico = ""
                For Me.Cont = 0 To 14
                    ChorizoBiometrico += ParteDelChorizo(Cont) & "|"
                Next
                ChorizoBiometrico += ParteDelChorizo(15)    'la ultima pa no ponerle el palito al final
                'actualiza la estructura pa dejar la vaina ya transformada pues
                R.e41BiometricosAdicionales = ChorizoBiometrico
                'como se encontro un eco viejo sin chorizo biometrico pone la bandera a true
                booEcoEsViejo = True

                'finalmente pone en blaco todas las casillas dependientes no...
                txtCC.Clear()
                txtTCer.Clear()
                txtAtrio.Clear()
                txtIOE.Clear()
                txtIOI.Clear()
                txtPN.Clear()
                txtCA.Clear()
                txtTibia.Clear()
                txtHumero.Clear()
                txtUlna.Clear()
                txtNODF.Clear()
                txtNOPT.Clear()
                txtNOPH.Clear()
                txtBPF.Clear()
                txtPeso.Clear()
                txtTalla.Clear()

            Else 'si no esta vacio entonces ya existe un chorizo con o sin datos pero existe
                'primero traduce el chorizo en sus partes
                'EcoEsViejo = False esta variable ya se inicializo a false solo si hay un chorizo nuevo se pondra a true
                ChorizoBiometrico = R.e41BiometricosAdicionales 'carga el chorizo
                ParteDelChorizo = ChorizoBiometrico.Split("|") 'pasa las partes a su receptor

                'inicia el recorrido

                'parte (0) circunferecia cefalica
                If ParteDelChorizo(0) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtCC.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtCC.Text = ParteDelChorizo(0)
                End If
                'parte (1) Trasv. del cerebelo
                If ParteDelChorizo(1) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtTCer.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtTCer.Text = ParteDelChorizo(1)
                End If
                'parte (2) Atrio
                If ParteDelChorizo(2) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtAtrio.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtAtrio.Text = ParteDelChorizo(2)
                End If
                'parte (3) IO externo
                If ParteDelChorizo(3) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtIOE.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtIOE.Text = ParteDelChorizo(3)
                End If
                'parte (4) IO Interno
                If ParteDelChorizo(4) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtIOI.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtIOI.Text = ParteDelChorizo(4)
                End If
                'parte (5) Pliegue Nucal
                If ParteDelChorizo(5) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtPN.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtPN.Text = ParteDelChorizo(5)
                End If
                'parte (6) Cirf. Abdominal
                If ParteDelChorizo(6) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtCA.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtCA.Text = ParteDelChorizo(6)
                End If
                'parte (7) tibia
                If ParteDelChorizo(7) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtTibia.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtTibia.Text = ParteDelChorizo(7)
                End If
                'parte (8) humero
                If ParteDelChorizo(8) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtHumero.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtHumero.Text = ParteDelChorizo(8)
                End If
                'parte (9) ulna
                If ParteDelChorizo(9) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtUlna.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtUlna.Text = ParteDelChorizo(9)
                End If
                'parte (10) NODistal del femur
                If ParteDelChorizo(10) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtNODF.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtNODF.Text = ParteDelChorizo(10)
                End If
                'parte (11) NOPtibia
                If ParteDelChorizo(11) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtNOPT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtNOPT.Text = ParteDelChorizo(11)
                End If
                'parte (12) NOPHumero
                If ParteDelChorizo(12) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtNOPH.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtNOPH.Text = ParteDelChorizo(12)
                End If
                'parte (13) Biparietofemoral
                If ParteDelChorizo(13) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtBPF.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtBPF.Text = ParteDelChorizo(13)
                End If
                'parte (14) Peso
                If ParteDelChorizo(14) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtPeso.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtPeso.Text = ParteDelChorizo(14)
                End If
                'parte (15) Talla
                If ParteDelChorizo(15) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtTalla.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtTalla.Text = ParteDelChorizo(15)
                End If

            End If

            'se debe tratar de calcular las eg de los datos recopilados
            If IsNumeric(txtDBP.Text) Then
                CalculaEGconDBP()
            End If

            If IsNumeric(txtCC.Text) Then
                CalculaEGconCC()
            End If

            If IsNumeric(txtCA.Text) Then
                CalculaEGconCA()
            End If

            If IsNumeric(txtFemur.Text) Then
                CalculaEGconFemur()
            End If


            'ficha funcional
            Select Case R.e22Actitud
                Case "1"
                    radActitud1.Checked = True
                Case "2"
                    radActitud2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radActitud1.Checked = True
            End Select

            Select Case R.e23Tono
                Case "1"
                    radTono1.Checked = True
                Case "2"
                    radTono2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radTono1.Checked = True
            End Select

            Select Case R.e24MovimientosFetales
                Case "1"
                    radMovimientosFetales1.Checked = True
                Case "2"
                    radMovimientosFetales2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radMovimientosFetales1.Checked = True
            End Select

            Select Case R.e25ActividadCardiaca
                Case "1"
                    radActividadCardiaca1.Checked = True
                Case "2"
                    radActividadCardiaca2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radActividadCardiaca1.Checked = True
            End Select

            Select Case R.e26MovimientosRespiratorios
                Case "1"
                    radMovimientosRespiratorios1.Checked = True
                Case "2"
                    radMovimientosRespiratorios2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radMovimientosRespiratorios1.Checked = True
            End Select

            Select Case R.e27RelacionAortoCava
                Case "1"
                    radAortoCava1.Checked = True
                Case "2"
                    radAortoCava2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radAortoCava1.Checked = True
            End Select

            Select Case R.e28CamaraGastrica
                Case "1"
                    radCamaraGastrica1.Checked = True
                Case "2"
                    radCamaraGastrica2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radCamaraGastrica1.Checked = True
            End Select

            Select Case R.e29Intestino
                Case "1"
                    radIntestino1.Checked = True
                Case "2"
                    radIntestino2.Checked = True
                Case "3"
                    radIntestino3.Checked = True
                Case "4"
                    radIntestino4.Checked = True
                Case "5"
                    radIntestino5.Checked = True
                Case Else
                    'si no se marco ninguno se ponen todos apagados porsia que alguno prendido no se como pero...
                    radIntestino1.Checked = False
                    radIntestino2.Checked = False
                    radIntestino3.Checked = False
                    radIntestino4.Checked = False
                    radIntestino5.Checked = False
            End Select

            Select Case R.e30Vejiga
                Case "1"
                    radVejiga1.Checked = True
                Case "2"
                    radVejiga2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radVejiga1.Checked = True
            End Select

            'ficha de placenta
            Select Case R.e32LocalizacionPlacenta
                Case "1"
                    radPlacenta1.Checked = True
                Case "2"
                    radPlacenta2.Checked = True
                Case "3"
                    radPlacenta3.Checked = True
                Case "4"
                    radplacenta4.Checked = True
                Case "5"
                    radPlacenta5.Checked = True
                Case "6"
                    radPlacenta6.Checked = True
                Case "7"
                    radPlacenta7.Checked = True
                Case "8"
                    radPlacenta8.Checked = True
                Case Else
                    'si no se marco ninguno se ponen en blanco todos
                    radPlacenta1.Checked = False
                    radPlacenta2.Checked = False
                    radPlacenta3.Checked = False
                    radplacenta4.Checked = False
                    radPlacenta5.Checked = False
                    radPlacenta6.Checked = False
                    radPlacenta7.Checked = False
                    radPlacenta8.Checked = False
            End Select

            txtPlacentaGrosor.Text = R.e33GrosorPlacenta

            Select Case R.e34GradoPlacenta
                Case "1"
                    radPlacentaGrado1.Checked = True
                Case "2"
                    radPlacentaGrado2.Checked = True
                Case "3"
                    radPlacentaGrado3.Checked = True
                Case "4"
                    radPlacentaGrado4.Checked = True
                Case "5"
                    radPlacentaGrado5.Checked = True
                Case "6"
                    radPlacentaGrado6.Checked = True
                Case "7"
                    radPlacentaGrado7.Checked = True
                Case Else
                    'si no se marco ninguno o hay otro dato metido se ponen todos en blanco
                    'y se blanquea la estructura por si hay algun dato de antes embarrando todo
                    radPlacentaGrado1.Checked = False
                    radPlacentaGrado2.Checked = False
                    radPlacentaGrado3.Checked = False
                    radPlacentaGrado4.Checked = False
                    radPlacentaGrado5.Checked = False
                    radPlacentaGrado6.Checked = False
                    radPlacentaGrado7.Checked = False
                    R.e34GradoPlacenta = ""
            End Select

            Select Case R.e35LiquidoAmniotico
                Case "1"
                    radLiquidoAmniotico1.Checked = True
                Case "2"
                    radLiquidoAmniotico2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radLiquidoAmniotico1.Checked = True
            End Select

            txtILA.Text = R.e36ILA

            Select Case R.e37CordonUmbilical
                Case "1"
                    radCordon1.Checked = True
                Case "2"
                    radCordon2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radCordon1.Checked = True
            End Select

            'ficha Notas
            'se asegura de no poner mas de 100 caracteres en esta lineas
            If R.e12Notas01del2y3erT.Length <= 100 Then
                txtNotas01del2y3erT.Text = R.e12Notas01del2y3erT
            Else
                'la cadena tenia mas de 100 caracteres 
                txtNotas01del2y3erT.Text = R.e12Notas01del2y3erT.Substring(0, 100)
            End If
            If R.e31Notas02del2y3erT.Length <= 100 Then
                txtNotas02del2y3erT.Text = R.e31Notas02del2y3erT
            Else
                'la cadena tenia mas de 100 caracteres 
                txtNotas02del2y3erT.Text = R.e31Notas02del2y3erT.Substring(0, 100)
            End If
            If R.e38Notas03del2y3erT.Length <= 100 Then
                txtNotas03del2y3erT.Text = R.e38Notas03del2y3erT
            Else
                'la cadena tenia mas de 100 caracteres 
                txtNotas03del2y3erT.Text = R.e38Notas03del2y3erT.Substring(0, 100)
            End If

            'ficha IDx
            'txtIDx2y3erT.Text = R.c06IDx 'ya no se usa

            'Chorizo DIAGNOSTICO de los datos adicionalkes de la modificacion
            If R.e44ChorizoDiagnostico = "" Then 'si esta vacio...
                'si esta vacio inicializa el chorizo para convertir los ecos viejos en nuevos
                For Me.Cont = 0 To 10
                    ParteDelChorizoDX(Cont) = "@" 'inicializa las parte con una arroba
                Next
                'ahora crea el chorizo con las partes arrobadas...
                ChorizoDiagnostico = ""
                For Me.Cont = 0 To 9
                    ChorizoDiagnostico += ParteDelChorizoDX(Cont) & "|"
                Next
                ChorizoDiagnostico += ParteDelChorizoDX(10)    'la ultima pa no ponerle el palito al final
                'actualiza la estructura pa dejar la vaina ya transformada pues
                R.e44ChorizoDiagnostico = ChorizoDiagnostico
                'como se encontro un eco viejo sin chorizo diagnostico pone la bandera a true
                booEcoEsViejo = True

                'finalmente pone en blaco todas las casillas dependientes no...
                txtIdx01del2y3erT.Clear()
                txtIdx02del2y3erT.Clear()
                txtIdx03del2y3erT.Clear()
                txtIdx04del2y3erT.Clear()
                txtIdx05del2y3erT.Clear()
                txtIDx06del2y3erT.Clear()
                txtIDx07del2y3erT.Clear()
                txtIDx08del2y3erT.Clear()
                txtSug01del2y3erT.Clear()
                txtSug02del2y3erT.Clear()
                txtSug03del2y3erT.Clear()

            Else 'si no esta vacio entonces ya existe un chorizo con o sin datos pero existe
                'primero traduce el chorizo en sus partes
                'EcoEsViejo = False esta variable ya se inicializo a false solo si hay un chorizo nuevo se pondra a true
                ChorizoDiagnostico = R.e44ChorizoDiagnostico 'carga el chorizo
                ParteDelChorizoDX = ChorizoDiagnostico.Split("|") 'pasa las partes a su receptor

                'inicia el recorrido

                'parte (0) embarazo de tantas semanas
                If ParteDelChorizoDX(0) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtIdx01del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtIdx01del2y3erT.Text = ParteDelChorizoDX(0)
                End If

                'parte (1) percentil
                If ParteDelChorizoDX(1) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtIdx02del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtIdx02del2y3erT.Text = ParteDelChorizoDX(1)
                End If

                'parte (2) perfil biofisico
                If ParteDelChorizoDX(2) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtIdx03del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtIdx03del2y3erT.Text = ParteDelChorizoDX(2)
                End If

                'parte (3) ecopuntaje genetico
                If ParteDelChorizoDX(3) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtIdx04del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtIdx04del2y3erT.Text = ParteDelChorizoDX(3)
                End If

                'parte (4) salud fetal
                If ParteDelChorizoDX(4) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtIdx05del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtIdx05del2y3erT.Text = ParteDelChorizoDX(4)
                End If

                'parte (5) otro dx a
                If ParteDelChorizoDX(5) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtIDx06del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtIDx06del2y3erT.Text = ParteDelChorizoDX(5)
                End If

                'parte (6) otro dx b
                If ParteDelChorizoDX(6) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtIDx07del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtIDx07del2y3erT.Text = ParteDelChorizoDX(6)
                End If
                'parte (7) otro dx c
                If ParteDelChorizoDX(7) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtIDx08del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtIDx08del2y3erT.Text = ParteDelChorizoDX(7)
                End If

                'ahora la sugerencias
                'parte (8) otro dx a
                If ParteDelChorizoDX(8) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtSug01del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtSug01del2y3erT.Text = ParteDelChorizoDX(8)
                End If

                'parte (9) otro dx a
                If ParteDelChorizoDX(9) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtSug02del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtSug02del2y3erT.Text = ParteDelChorizoDX(9)
                End If

                'parte (10) otro dx a
                If ParteDelChorizoDX(10) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    txtSug03del2y3erT.Clear()
                Else
                    'contiene un dato lo pone en su sitio
                    txtSug03del2y3erT.Text = ParteDelChorizoDX(10)
                End If
            End If

            'selecciona la ficha inicial a mostrar 
            TabControl4.SelectedIndex = 0


        ElseIf R.c00TipoDeEstudio = "3" Then
            'es un estudio ginecologico

            'llena los labels de arriba
            txtFechaInicioControl.Text = dateFechaInicioInformeSeleccionado.ToLongDateString
            labInforme.Text = R.c09NombreInforme
            txtFechaInicioControl2.Text = dateFechaInicioInformeSeleccionado.ToLongDateString
            labInforme2.Text = R.c09NombreInforme

            'visualiza el panel adecuado
            PanelNuevoControlGinecologico.Visible = True
            PanelNuevoControl1erT.Visible = False
            PanelNuevoControl2y3erT.Visible = False

            'datos 
            labNombreGinecologico.Text = R.c07Nombre
            labEdadGinecologico.Text = R.c08Edad
            txtParidadGinecologico.Text = R.c02Paridad
            labFechaControlGinecologico.Text = dateFechaInicioInformeSeleccionado.ToShortDateString
            labFURginecologico.Text = R.c03FUR
            labDiaCicloGinecologico.Text = R.r18DiaCiclo

            'ficha general

            Select Case R.f02EstudioPorVia
                Case "1"
                    radTipoEstudioGinecologico1.Checked = True
                Case "2"
                    radTipoEstudioGinecologico2.Checked = True
                Case Else
                    'si no se marco ninguno se pone el primero
                    radTipoEstudioGinecologico1.Checked = True
            End Select

            txtUteroLongitudinal.Text = R.f03UteroLongitudinal
            txtUteroAnteroPosterior.Text = R.f04UteroAnteroposterior
            txtUteroTransverso.Text = R.f05UteroTransverso
            txtUteroEndometrio.Text = R.f20EndometrioGrosor

            txtOvarioDerechoLongitudinal.Text = R.f06OvarioDerechoLongitudinal
            txtOvarioDerechoTransverso.Text = R.f07OvarioDerechoTransverso
            txtOvarioDerechoAnteroPosterior.Text = R.f08OvarioDerechoAnteroPosterior

            txtOvarioIzquierdoLongitudinal.Text = R.f09OvarioIzquierdoLongitudinal
            txtOvarioIzquierdoTransverso.Text = R.f10OvarioIzquierdoTransverso
            txtOvarioIzquierdoAnteroPosterior.Text = R.f11OvarioIzquierdoAnteroPosterior

            txtOvarioDerechoFoliculo1.Text = R.f12FoliculoDerecho01
            txtOvarioDerechoFoliculo2.Text = R.f13FoliculoDerecho02
            txtOvarioDerechoFoliculo3.Text = R.f14FoliculoDerecho03
            txtOvarioDerechoFoliculo4.Text = R.f15FoliculoDerecho04

            txtOvarioIzquierdoFoliculo1.Text = R.f16FoliculoIzquierdo01
            txtOvarioIzquierdoFoliculo2.Text = R.f17FoliculoIzquierdo02
            txtOvarioIzquierdoFoliculo3.Text = R.f18FoliculoIzquierdo03
            txtOvarioIzquierdoFoliculo4.Text = R.f19FoliculoIzquierdo04

            'parte nueva de la modif de agosto de 2008

            'ahora los datos adicionales del GIN
            If R.f25AdicionalesGin = "" Then 'si esta vacio...
                'si esta vacio inicializa el chorizo para convertir los ecos viejos en nuevos
                For Me.Cont = 0 To 35
                    ParteChorizoGIN(Cont) = "@" 'inicializa las parte con una arroba
                Next
                'ahora crea el chorizo con las partes arrobadas...
                ChorizoGIN = ""
                For Me.Cont = 0 To 34
                    ChorizoGIN += ParteChorizoGIN(Cont) & "|"
                Next
                ChorizoGIN += ParteChorizoGIN(35)    'la ultima pa no ponerle el palito al final
                'actualiza la estructura pa dejar la vaina ya transformada pues
                R.f25AdicionalesGin = ChorizoGIN
                'como se encontro un eco viejo sin datos adicionales del gin pone la bandera a true
                booEcoEsViejo = True

                'finalmente pone en blanco todas las casillas dependientes no...
                BorraRADButtonsyTXTGIN()

            Else 'si no esta vacio entonces ya existe un chorizo con o sin datos pero existe
                'primero traduce el chorizo en sus partes
                'EcoEsViejo = False esta variable ya se inicializo a false solo si hay un chorizo nuevo se pondra a true
                ChorizoGIN = R.f25AdicionalesGin 'carga el chorizo
                ParteChorizoGIN = ChorizoGIN.Split("|") 'pasa las partes a su receptor

                'inicia el recorrido

                'parte (0) Vejiga volumen
                If ParteChorizoGIN(0) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinVejigaVolumen1.Checked = False
                    RadGinVejigaVolumen2.Checked = False
                    RadGinVejigaVolumen3.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(0) = "1" Then
                        RadGinVejigaVolumen1.Checked = True
                    ElseIf ParteChorizoGIN(0) = "2" Then
                        RadGinVejigaVolumen2.Checked = True
                    ElseIf ParteChorizoGIN(0) = "3" Then
                        RadGinVejigaVolumen3.Checked = True
                    End If
                End If

                'parte (1) Vejiga adecuacion
                If ParteChorizoGIN(1) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinVejigaAdecuada1.Checked = False
                    RadGinVejigaAdecuada2.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(1) = "1" Then
                        RadGinVejigaAdecuada1.Checked = True
                    ElseIf ParteChorizoGIN(1) = "2" Then
                        RadGinVejigaAdecuada2.Checked = True
                    End If
                End If

                'parte (2) Vejiga Paredes
                If ParteChorizoGIN(2) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinVejigaParedes1.Checked = False
                    RadGinVejigaParedes2.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(2) = "1" Then
                        RadGinVejigaParedes1.Checked = True
                    ElseIf ParteChorizoGIN(2) = "2" Then
                        RadGinVejigaParedes2.Checked = True
                    End If
                End If

                'parte (3) vejiga obs 1
                If ParteChorizoGIN(3) = "@" Then
                    'la parte esta vacia
                    txtGinVejigaObservaciones1.Clear()
                Else
                    txtGinVejigaObservaciones1.Text = ParteChorizoGIN(3)
                End If

                'parte (4) vejiga obs 2
                If ParteChorizoGIN(4) = "@" Then
                    'la parte esta vacia
                    txtGinVejigaObservaciones2.Clear()
                Else
                    txtGinVejigaObservaciones2.Text = ParteChorizoGIN(4)
                End If

                'parte (5) utero posicion long
                If ParteChorizoGIN(5) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinUteroPosicion1.Checked = False
                    RadGinUteroPosicion2.Checked = False
                    RadGinUteroPosicion3.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(5) = "1" Then
                        RadGinUteroPosicion1.Checked = True
                    ElseIf ParteChorizoGIN(5) = "2" Then
                        RadGinUteroPosicion2.Checked = True
                    ElseIf ParteChorizoGIN(5) = "3" Then
                        RadGinUteroPosicion3.Checked = True
                    End If
                End If

                'parte (6) utero inclinacion
                If ParteChorizoGIN(6) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinUteroInclinacion1.Checked = False
                    RadGinUteroInclinacion2.Checked = False
                    RadGinUteroInclinacion3.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(6) = "1" Then
                        RadGinUteroInclinacion1.Checked = True
                    ElseIf ParteChorizoGIN(6) = "2" Then
                        RadGinUteroInclinacion2.Checked = True
                    ElseIf ParteChorizoGIN(6) = "3" Then
                        RadGinUteroInclinacion3.Checked = True
                    End If
                End If

                'parte (7) utero ecopatron
                If ParteChorizoGIN(7) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinUteroEcopatron1.Checked = False
                    RadGinUteroEcopatron2.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(7) = "1" Then
                        RadGinUteroEcopatron1.Checked = True
                    ElseIf ParteChorizoGIN(7) = "2" Then
                        RadGinUteroEcopatron2.Checked = True
                    End If
                End If

                'parte (8) utero bordes
                If ParteChorizoGIN(8) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinUteroBordes1.Checked = False
                    RadGinUteroBordes2.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(8) = "1" Then
                        RadGinUteroBordes1.Checked = True
                    ElseIf ParteChorizoGIN(8) = "2" Then
                        RadGinUteroBordes2.Checked = True
                    End If
                End If

                'parte (9) utero endometrio
                If ParteChorizoGIN(9) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinUteroEndometrio1.Checked = False
                    RadGinUteroEndometrio2.Checked = False
                    RadGinUteroEndometrio3.Checked = False
                    RadGinUteroEndometrio4.Checked = False
                    RadGinUteroEndometrio5.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(9) = "1" Then
                        RadGinUteroEndometrio1.Checked = True
                    ElseIf ParteChorizoGIN(9) = "2" Then
                        RadGinUteroEndometrio2.Checked = True
                    ElseIf ParteChorizoGIN(9) = "3" Then
                        RadGinUteroEndometrio3.Checked = True
                    ElseIf ParteChorizoGIN(9) = "4" Then
                        RadGinUteroEndometrio4.Checked = True
                    ElseIf ParteChorizoGIN(9) = "5" Then
                        RadGinUteroEndometrio5.Checked = True
                    End If
                End If

                'parte (10) utero cavidad
                If ParteChorizoGIN(10) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinUteroCavidad1.Checked = False
                    RadGinUteroCavidad2.Checked = False
                    RadGinUteroCavidad3.Checked = False
                    RadGinUteroCavidad4.Checked = False
                    RadGinUteroCavidad5.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(10) = "1" Then
                        RadGinUteroCavidad1.Checked = True
                    ElseIf ParteChorizoGIN(10) = "2" Then
                        RadGinUteroCavidad2.Checked = True
                    ElseIf ParteChorizoGIN(10) = "3" Then
                        RadGinUteroCavidad3.Checked = True
                    ElseIf ParteChorizoGIN(10) = "4" Then
                        RadGinUteroCavidad4.Checked = True
                    ElseIf ParteChorizoGIN(10) = "5" Then
                        RadGinUteroCavidad5.Checked = True
                    End If
                End If

                'parte (11) utero obs 1
                If ParteChorizoGIN(11) = "@" Then
                    'la parte esta vacia
                    txtGinUteroObservaciones1.Clear()
                Else
                    txtGinUteroObservaciones1.Text = ParteChorizoGIN(11)
                End If

                'parte (12) utero obs 2
                If ParteChorizoGIN(12) = "@" Then
                    'la parte esta vacia
                    txtGinUteroObservaciones2.Clear()
                Else
                    txtGinUteroObservaciones2.Text = ParteChorizoGIN(12)
                End If

                'parte (13) ovarioderecho tamano
                If ParteChorizoGIN(13) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinOvarioDerechoTamano1.Checked = False
                    RadGinOvarioDerechoTamano2.Checked = False
                    RadGinOvarioDerechoTamano3.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(13) = "1" Then
                        RadGinOvarioDerechoTamano1.Checked = True
                    ElseIf ParteChorizoGIN(13) = "2" Then
                        RadGinOvarioDerechoTamano2.Checked = True
                    ElseIf ParteChorizoGIN(13) = "3" Then
                        RadGinOvarioDerechoTamano3.Checked = True
                    End If
                End If

                'parte (14) ovarioizquierdo tamano
                If ParteChorizoGIN(14) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinOvarioIzquierdoTamano1.Checked = False
                    RadGinOvarioIzquierdoTamano2.Checked = False
                    RadGinOvarioIzquierdoTamano3.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(14) = "1" Then
                        RadGinOvarioIzquierdoTamano1.Checked = True
                    ElseIf ParteChorizoGIN(14) = "2" Then
                        RadGinOvarioIzquierdoTamano2.Checked = True
                    ElseIf ParteChorizoGIN(14) = "3" Then
                        RadGinOvarioIzquierdoTamano3.Checked = True
                    End If
                End If

                'parte (15) ovarioderecho obs 1
                If ParteChorizoGIN(15) = "@" Then
                    'la parte esta vacia
                    txtGinOvarioDerechoObservaciones1.Clear()
                Else
                    txtGinOvarioDerechoObservaciones1.Text = ParteChorizoGIN(15)
                End If

                'parte (16) ovarioderecho obs 2
                If ParteChorizoGIN(16) = "@" Then
                    'la parte esta vacia
                    txtGinOvarioDerechoObservaciones2.Clear()
                Else
                    txtGinOvarioDerechoObservaciones2.Text = ParteChorizoGIN(16)
                End If

                'parte (17) ovarioderecho obs 3
                If ParteChorizoGIN(17) = "@" Then
                    'la parte esta vacia
                    txtGinOvarioDerechoObservaciones3.Clear()
                Else
                    txtGinOvarioDerechoObservaciones3.Text = ParteChorizoGIN(17)
                End If

                'parte (18) ovarioderecho obs 4
                If ParteChorizoGIN(18) = "@" Then
                    'la parte esta vacia
                    txtGinOvarioDerechoObservaciones4.Clear()
                Else
                    txtGinOvarioDerechoObservaciones4.Text = ParteChorizoGIN(18)
                End If

                'parte (19) ovarioizquierdo obs 1
                If ParteChorizoGIN(19) = "@" Then
                    'la parte esta vacia
                    txtGinOvarioIzquierdoObservaciones1.Clear()
                Else
                    txtGinOvarioIzquierdoObservaciones1.Text = ParteChorizoGIN(19)
                End If

                'parte (20) ovarioizquierdo obs 2
                If ParteChorizoGIN(20) = "@" Then
                    'la parte esta vacia
                    txtGinOvarioIzquierdoObservaciones2.Clear()
                Else
                    txtGinOvarioIzquierdoObservaciones2.Text = ParteChorizoGIN(20)
                End If

                'parte (21) ovarioizquierdo obs 3
                If ParteChorizoGIN(21) = "@" Then
                    'la parte esta vacia
                    txtGinOvarioIzquierdoObservaciones3.Clear()
                Else
                    txtGinOvarioIzquierdoObservaciones3.Text = ParteChorizoGIN(21)
                End If

                'parte (22) ovarioizquierdo obs 4
                If ParteChorizoGIN(22) = "@" Then
                    'la parte esta vacia
                    txtGinOvarioIzquierdoObservaciones4.Clear()
                Else
                    txtGinOvarioIzquierdoObservaciones4.Text = ParteChorizoGIN(22)
                End If

                'parte (23) trompas
                If ParteChorizoGIN(23) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinTrompas1.Checked = False
                    RadGinTrompas2.Checked = False
                    RadGinTrompas3.Checked = False
                    RadGinTrompas4.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(23) = "1" Then
                        RadGinTrompas1.Checked = True
                    ElseIf ParteChorizoGIN(23) = "2" Then
                        RadGinTrompas2.Checked = True
                    ElseIf ParteChorizoGIN(23) = "3" Then
                        RadGinTrompas3.Checked = True
                    ElseIf ParteChorizoGIN(23) = "4" Then
                        RadGinTrompas4.Checked = True
                    End If
                End If

                'parte (24) douglas
                If ParteChorizoGIN(24) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    RadGinDouglas1.Checked = False
                    RadGinDouglas2.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(24) = "1" Then
                        RadGinDouglas1.Checked = True
                    ElseIf ParteChorizoGIN(24) = "2" Then
                        RadGinDouglas2.Checked = True
                    End If
                End If

                'parte (25) otros obs 1
                If ParteChorizoGIN(25) = "@" Then
                    'la parte esta vacia
                    txtGinOtrosObservaciones1.Clear()
                Else
                    txtGinOtrosObservaciones1.Text = ParteChorizoGIN(25)
                End If

                'parte (26) otros obs 2
                If ParteChorizoGIN(26) = "@" Then
                    'la parte esta vacia
                    txtGinOtrosObservaciones2.Clear()
                Else
                    txtGinOtrosObservaciones2.Text = ParteChorizoGIN(26)
                End If

                'parte (27) IDx 1
                If ParteChorizoGIN(27) = "@" Then
                    'la parte esta vacia
                    txtGinIDx1.Clear()
                Else
                    txtGinIDx1.Text = ParteChorizoGIN(27)
                End If

                'parte (28) idx 2
                If ParteChorizoGIN(28) = "@" Then
                    'la parte esta vacia
                    txtGinIDx2.Clear()
                Else
                    txtGinIDx2.Text = ParteChorizoGIN(28)
                End If

                'parte (29) idx 3
                If ParteChorizoGIN(29) = "@" Then
                    'la parte esta vacia
                    txtGinIDx3.Clear()
                Else
                    txtGinIDx3.Text = ParteChorizoGIN(29)
                End If

                'parte (30) idx 4
                If ParteChorizoGIN(30) = "@" Then
                    'la parte esta vacia
                    txtGinIDx4.Clear()
                Else
                    txtGinIDx4.Text = ParteChorizoGIN(30)
                End If

                'parte (31) frec del trasductor
                If ParteChorizoGIN(31) = "@" Then
                    'la parte esta vacia actualiza el campo o borra lo q este ahi
                    radGINfrec35.Checked = False
                    radGINfrec50.Checked = False
                    radGINfrec75.Checked = False
                Else
                    'contiene un dato lo pone en su sitio
                    If ParteChorizoGIN(31) = "1" Then
                        radGINfrec35.Checked = True
                    ElseIf ParteChorizoGIN(31) = "2" Then
                        radGINfrec50.Checked = True
                    ElseIf ParteChorizoGIN(31) = "3" Then
                        radGINfrec75.Checked = True
                    End If
                End If

            End If 'este es el end if del tipo de estudio gin

        Else
            'error no se dijo que tipo de estudio era...
            'probable corrupcion de datos...
            MsgBox("Error. No se especificó que tipo de Informe era el seleccionado. Probablemente exista una corrupción en los datos. Si posees un respaldo sustituye el archivo:" & vbCrLf & NombreControlEcografico)
        End If

        'ya al final revisa si la bandera de eco viejo esta a true para dejar todo igual o poner el modo de datos cambiados
        If booEcoEsViejo = True Then
            SeRealizoUnCambio()
        Else
            DatosSinCambios()
        End If

        'finalmente actualiza la imagen de impresion con los datos recien cargados
        ActualizaImagenParaImprimir()


    End Sub

    Private Sub botRenombraINFORME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRenombra.Click
        Dim Reply As MsgBoxResult
        Dim Partes(5) As String
        Dim Encabezado As String
        Dim DLG As New FormNuevaSerie()

        If DatosModificados = True Then
            Reply = MsgBox("Si Renombras el Informe se perderán los datos nuevos no salvados. Deseas Renombrarlo de todas formas?", MsgBoxStyle.YesNo, "Renombra Informe Ecográfico")
            If Reply = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        'inicializa partes porsia
        Partes(0) = ""
        Partes(1) = ""


        Encabezado = ListBoxInformes.SelectedItem
        Partes = Split(Encabezado, "|")

        strFechaInicioInformeSeleccionadoSDS = Partes(0)

        Form1.NombreElegidoMensaje = "¿Deseas cambiar el nombre del Informe Ecográfico del día: " & strFechaInicioInformeSeleccionadoSDS & ", (actualmente: " & Partes(1) & "?" & vbCrLf
        Form1.NombreElegidoMensaje += "Introduce el nuevo nombre en la casilla y luego presiona aceptar..."
        Form1.NombreElegidoTitulo = "Renombra el Informe Ecográfico"

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            RenombraInformeAnterior()
        End If

    End Sub

    Private Sub RenombraInformeAnterior()
        Dim FechacomoDate As Date
        Dim FechaComoShortDateString As String
        Dim H As New Form1.TablaDeDatosEcograficos()
        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(NombreControlEcografico, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim REnum As IEnumerator
        REnum = arrayEcosDelPacienteSeleccionado.GetEnumerator

        'Dim Fecha As Date

        While REnum.MoveNext
            H = Nothing
            H = CType(REnum.Current, Form1.TablaDeDatosEcograficos)

            FechacomoDate = H.c01FechaControl
            FechaComoShortDateString = FechacomoDate.ToShortDateString

            '000000000000000000000000
            BW.Write(H.c00TipoDeEstudio)
            BW.Write(H.c01FechaControl)
            BW.Write(H.c02Paridad)
            BW.Write(H.c03FUR)
            BW.Write(H.c04FPP)
            BW.Write(H.c05EGxFUR)
            BW.Write(H.c06IDx)
            BW.Write(H.c07Nombre)
            BW.Write(H.c08Edad)
            BW.Write(H.d01SGlongitudinal)
            BW.Write(H.d02SGanteroposterior)
            BW.Write(H.d03SGtransversal)
            BW.Write(H.d04LCC)
            BW.Write(H.d05ImplatacionSG)
            BW.Write(H.d06EmbrionVisible)
            BW.Write(H.d07MovimientosPresentes)
            BW.Write(H.d08ActividadCardiaca)
            BW.Write(H.d09Comentarios1erT)
            BW.Write(H.d10OtroA)
            BW.Write(H.d11AdicionalesB1erT)
            BW.Write(H.d12IDxAdicionales1erT)
            BW.Write(H.d13Adicionales1erT)
            BW.Write(H.e01Presentacion)
            BW.Write(H.e02Situacion)
            BW.Write(H.e03Posicion)
            BW.Write(H.e04Cabeza)
            BW.Write(H.e05Ventriculos)
            BW.Write(H.e06Columna)
            BW.Write(H.e07Torax)
            BW.Write(H.e08Corazon)
            BW.Write(H.e09Abdomen)
            BW.Write(H.e10Riñones)
            BW.Write(H.e11Extremidades)
            BW.Write(H.e12Notas01del2y3erT)
            BW.Write(H.e13DiametroBiParietal)
            BW.Write(H.e14DiametroOccipitoFrontal)
            BW.Write(H.e15DiametroAnteroPosteriorTorax)
            BW.Write(H.e16DiametroAnteroPosteriorCorazon)
            BW.Write(H.e17aDiametroAnteroPosteriorAbdomen)
            BW.Write(H.e17bDiametroTransversoAbdomen)
            BW.Write(H.e18Aorta)
            BW.Write(H.e19VenaCava)
            BW.Write(H.e20LongitudSacro)
            BW.Write(H.e21LongitudFemur)
            BW.Write(H.e22Actitud)
            BW.Write(H.e23Tono)
            BW.Write(H.e24MovimientosFetales)
            BW.Write(H.e25ActividadCardiaca)
            BW.Write(H.e26MovimientosRespiratorios)
            BW.Write(H.e27RelacionAortoCava)
            BW.Write(H.e28CamaraGastrica)
            BW.Write(H.e29Intestino)
            BW.Write(H.e30Vejiga)
            BW.Write(H.e31Notas02del2y3erT)
            BW.Write(H.e32LocalizacionPlacenta)
            BW.Write(H.e33GrosorPlacenta)
            BW.Write(H.e34GradoPlacenta)
            BW.Write(H.e35LiquidoAmniotico)
            BW.Write(H.e36ILA)
            BW.Write(H.e37CordonUmbilical)
            BW.Write(H.e38Notas03del2y3erT)
            BW.Write(H.e39Embarazo)
            BW.Write(H.e40Feto)
            BW.Write(H.e41BiometricosAdicionales)
            BW.Write(H.e42Rostro)
            BW.Write(H.e43Sexo)
            BW.Write(H.f01Menopausia)
            BW.Write(H.f02EstudioPorVia)
            BW.Write(H.f03UteroLongitudinal)
            BW.Write(H.f04UteroAnteroposterior)
            BW.Write(H.f05UteroTransverso)
            BW.Write(H.f06OvarioDerechoLongitudinal)
            BW.Write(H.f07OvarioDerechoTransverso)
            BW.Write(H.f08OvarioDerechoAnteroPosterior)
            BW.Write(H.f09OvarioIzquierdoLongitudinal)
            BW.Write(H.f10OvarioIzquierdoTransverso)
            BW.Write(H.f11OvarioIzquierdoAnteroPosterior)
            BW.Write(H.f12FoliculoDerecho01)
            BW.Write(H.f13FoliculoDerecho02)
            BW.Write(H.f14FoliculoDerecho03)
            BW.Write(H.f15FoliculoDerecho04)
            BW.Write(H.f16FoliculoIzquierdo01)
            BW.Write(H.f17FoliculoIzquierdo02)
            BW.Write(H.f18FoliculoIzquierdo03)
            BW.Write(H.f19FoliculoIzquierdo04)
            BW.Write(H.f20EndometrioGrosor)
            BW.Write(H.f21ObsGinecologicas)
            BW.Write(H.f22OtrosA)
            BW.Write(H.f23OtrosB)
            BW.Write(H.f24OtrosC)
            BW.Write(H.f25AdicionalesGin)
            BW.Write(H.r01SGPromedio)
            BW.Write(H.r02EGxSG)
            BW.Write(H.r03EGxLCC)
            BW.Write(H.r04EG1erT)
            BW.Write(H.r05DBPc)
            BW.Write(H.r06CirCef)
            BW.Write(H.r07IndCef)
            BW.Write(H.r08CirAbd)
            BW.Write(H.r09DBF)
            BW.Write(H.r10EGxDBP)
            BW.Write(H.r11EGxDBPc)
            BW.Write(H.r12EGxCC)
            BW.Write(H.r13EGxCA)
            BW.Write(H.r14EGxFemur)
            BW.Write(H.r15PesoEstimado)
            BW.Write(H.r16PesoenBaseA)
            BW.Write(H.r17EG2y3erT)
            BW.Write(H.r18DiaCiclo)
            BW.Write(H.r19OtroA)
            BW.Write(H.r20OtroB)
            BW.Write(H.r21OtroC)
            BW.Write(H.e44ChorizoDiagnostico)
            If FechaComoShortDateString = strFechaInicioInformeSeleccionadoSDS Then
                'si es el informe seleccionado le pone el nombre nuevo
                H.c09NombreInforme = Form1.NombreElegido
            End If
            BW.Write(H.c09NombreInforme)
            '000000000000000000000000
        End While
        BW.Close()
        FS.Close()
        MsgBox("Se Renombró el Informe Ecográfico seleccionado", MsgBoxStyle.Information)

        LeeContenidoControlEcografico()

        'borra el contenido de la ventana pone todo como debe ser al principio
        'botSelecciona.Enabled = False
        'botElimina.Enabled = False
        'botRenombra.Enabled = False
        'txtFechaInicioControl.Text = ""
        'labInforme.Text = ""
        'txtFechaInicioControl2.Text = ""
        'labInforme2.Text = ""
        'PanelImpresion.Visible = False

        InicializaDatos()
        'GrabaDatosySigue()
        MuestraControlEcografico()
        'borra el informe que estuviera en el panel de impresion
        BorraPanelImpresion()
        'pone visible el tab del informe
        TabControl1.SelectedIndex = 0

    End Sub

    Private Sub botElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botElimina.Click
        Dim Reply As MsgBoxResult
        Dim Partes(5) As String
        Dim Encabezado As String
        Dim DLG As New FormNuevaSerie()

        If DatosModificados = True Then
            Reply = MsgBox("Si eliminas este Informe se perderán los datos nuevos no salvados en el actual. Deseas eliminarlo de todas formas?", MsgBoxStyle.YesNo, "Elimina un Informe Ecográfico")
            If Reply = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        'inicializa partes porsia
        Partes(0) = ""
        Partes(1) = ""

        Encabezado = ListBoxInformes.SelectedItem
        Partes = Split(Encabezado, "|")

        strFechaInicioInformeSeleccionadoSDS = Partes(0)

        Reply = MsgBox("Deseas Eliminar el Informe: " & strFechaInicioInformeSeleccionadoSDS & "|" & Partes(1) & "?", MsgBoxStyle.YesNo, "Elimina Informe Ecográfico")
        If Reply = MsgBoxResult.No Then
            Exit Sub
        End If

        EliminaInformeSeleccionado()

    End Sub

    Private Sub EliminaInformeSeleccionado()
        Dim FechacomoDate As Date
        Dim FechaComoShortDateString As String

        Dim H As New Form1.TablaDeDatosEcograficos()
        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(NombreControlEcografico, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim REnum As IEnumerator
        REnum = arrayEcosDelPacienteSeleccionado.GetEnumerator

        'Dim Fecha As Date

        Dim contador As Integer = 0
        While REnum.MoveNext
            H = Nothing
            H = CType(REnum.Current, Form1.TablaDeDatosEcograficos)

            FechacomoDate = H.c01FechaControl
            FechaComoShortDateString = FechacomoDate.ToShortDateString

            If FechaComoShortDateString = strFechaInicioInformeSeleccionadoSDS Then
                'si el control examinado es el que se quiere
                'eliminar no lo escribe
            Else
                BW.Write(H.c00TipoDeEstudio)
                BW.Write(H.c01FechaControl)
                BW.Write(H.c02Paridad)
                BW.Write(H.c03FUR)
                BW.Write(H.c04FPP)
                BW.Write(H.c05EGxFUR)
                BW.Write(H.c06IDx)
                BW.Write(H.c07Nombre)
                BW.Write(H.c08Edad)
                BW.Write(H.d01SGlongitudinal)
                BW.Write(H.d02SGanteroposterior)
                BW.Write(H.d03SGtransversal)
                BW.Write(H.d04LCC)
                BW.Write(H.d05ImplatacionSG)
                BW.Write(H.d06EmbrionVisible)
                BW.Write(H.d07MovimientosPresentes)
                BW.Write(H.d08ActividadCardiaca)
                BW.Write(H.d09Comentarios1erT)
                BW.Write(H.d10OtroA)
                BW.Write(H.d11AdicionalesB1erT)
                BW.Write(H.d12IDxAdicionales1erT)
                BW.Write(H.d13Adicionales1erT)
                BW.Write(H.e01Presentacion)
                BW.Write(H.e02Situacion)
                BW.Write(H.e03Posicion)
                BW.Write(H.e04Cabeza)
                BW.Write(H.e05Ventriculos)
                BW.Write(H.e06Columna)
                BW.Write(H.e07Torax)
                BW.Write(H.e08Corazon)
                BW.Write(H.e09Abdomen)
                BW.Write(H.e10Riñones)
                BW.Write(H.e11Extremidades)
                BW.Write(H.e12Notas01del2y3erT)
                BW.Write(H.e13DiametroBiParietal)
                BW.Write(H.e14DiametroOccipitoFrontal)
                BW.Write(H.e15DiametroAnteroPosteriorTorax)
                BW.Write(H.e16DiametroAnteroPosteriorCorazon)
                BW.Write(H.e17aDiametroAnteroPosteriorAbdomen)
                BW.Write(H.e17bDiametroTransversoAbdomen)
                BW.Write(H.e18Aorta)
                BW.Write(H.e19VenaCava)
                BW.Write(H.e20LongitudSacro)
                BW.Write(H.e21LongitudFemur)
                BW.Write(H.e22Actitud)
                BW.Write(H.e23Tono)
                BW.Write(H.e24MovimientosFetales)
                BW.Write(H.e25ActividadCardiaca)
                BW.Write(H.e26MovimientosRespiratorios)
                BW.Write(H.e27RelacionAortoCava)
                BW.Write(H.e28CamaraGastrica)
                BW.Write(H.e29Intestino)
                BW.Write(H.e30Vejiga)
                BW.Write(H.e31Notas02del2y3erT)
                BW.Write(H.e32LocalizacionPlacenta)
                BW.Write(H.e33GrosorPlacenta)
                BW.Write(H.e34GradoPlacenta)
                BW.Write(H.e35LiquidoAmniotico)
                BW.Write(H.e36ILA)
                BW.Write(H.e37CordonUmbilical)
                BW.Write(H.e38Notas03del2y3erT)
                BW.Write(H.e39Embarazo)
                BW.Write(H.e40Feto)
                BW.Write(H.e41BiometricosAdicionales)
                BW.Write(H.e42Rostro)
                BW.Write(H.e43Sexo)
                BW.Write(H.f01Menopausia)
                BW.Write(H.f02EstudioPorVia)
                BW.Write(H.f03UteroLongitudinal)
                BW.Write(H.f04UteroAnteroposterior)
                BW.Write(H.f05UteroTransverso)
                BW.Write(H.f06OvarioDerechoLongitudinal)
                BW.Write(H.f07OvarioDerechoTransverso)
                BW.Write(H.f08OvarioDerechoAnteroPosterior)
                BW.Write(H.f09OvarioIzquierdoLongitudinal)
                BW.Write(H.f10OvarioIzquierdoTransverso)
                BW.Write(H.f11OvarioIzquierdoAnteroPosterior)
                BW.Write(H.f12FoliculoDerecho01)
                BW.Write(H.f13FoliculoDerecho02)
                BW.Write(H.f14FoliculoDerecho03)
                BW.Write(H.f15FoliculoDerecho04)
                BW.Write(H.f16FoliculoIzquierdo01)
                BW.Write(H.f17FoliculoIzquierdo02)
                BW.Write(H.f18FoliculoIzquierdo03)
                BW.Write(H.f19FoliculoIzquierdo04)
                BW.Write(H.f20EndometrioGrosor)
                BW.Write(H.f21ObsGinecologicas)
                BW.Write(H.f22OtrosA)
                BW.Write(H.f23OtrosB)
                BW.Write(H.f24OtrosC)
                BW.Write(H.f25AdicionalesGin)
                BW.Write(H.r01SGPromedio)
                BW.Write(H.r02EGxSG)
                BW.Write(H.r03EGxLCC)
                BW.Write(H.r04EG1erT)
                BW.Write(H.r05DBPc)
                BW.Write(H.r06CirCef)
                BW.Write(H.r07IndCef)
                BW.Write(H.r08CirAbd)
                BW.Write(H.r09DBF)
                BW.Write(H.r10EGxDBP)
                BW.Write(H.r11EGxDBPc)
                BW.Write(H.r12EGxCC)
                BW.Write(H.r13EGxCA)
                BW.Write(H.r14EGxFemur)
                BW.Write(H.r15PesoEstimado)
                BW.Write(H.r16PesoenBaseA)
                BW.Write(H.r17EG2y3erT)
                BW.Write(H.r18DiaCiclo)
                BW.Write(H.r19OtroA)
                BW.Write(H.r20OtroB)
                BW.Write(H.r21OtroC)
                BW.Write(H.e44ChorizoDiagnostico)
                BW.Write(H.c09NombreInforme)

                contador += 1
            End If
            '000000000000000000000000
        End While
        BW.Close()
        FS.Close()
        MsgBox("Se Elimino el Informe Ecográfico seleccionado", MsgBoxStyle.Information)


        If contador = 0 Then
            'se elimino hasta el ultimo informe se debe actualizar el contenido de la historia borrando la linea datos
            'del control ginecologico
            Dim FSsub As FileStream
            Dim BWsub As BinaryWriter
            Dim LineaDatos As String

            FSsub = New FileStream(NombreHistoria, FileMode.Create, FileAccess.Write)
            BWsub = New BinaryWriter(FSsub)

            'ubica al principio el contenido de la subhistoria
            Dim REnumSub As IEnumerator
            REnumSub = Form1.ElementosHistoria.GetEnumerator
            'pone el archivo al inicio
            BWsub.BaseStream.Seek(0, SeekOrigin.Begin)

            While REnumSub.MoveNext
                LineaDatos = CType(REnumSub.Current, String)
                If LineaDatos = Form1.PSstrNumeroHistoriaSeleccionada & "-Control Ecográfico" Then
                    'si es la linea del control ginecologico no la escribe
                Else
                    'escribe las otras lineas
                    BWsub.Write(LineaDatos)
                End If

            End While

            'cierra todo
            FSsub.Close()
            BWsub.Close()
            'borra el archivo del disco ya que esta vacio
            File.Delete(NombreControlEcografico)
            'por ultimo pone la variable de existe control ginecologico a false
            Form1.ExisteControlEcografico = False

        End If

        'si aun existe algun  Informe lo muestra en el listbox
        If Form1.ExisteControlEcografico = True Then
            LeeContenidoControlEcografico()
        Else
            ListBoxInformes.Items.Clear()
        End If

        'borra el contenido de la ventana pone todo como debe ser al principio
        'botSelecciona.Enabled = False
        'botElimina.Enabled = False
        'botRenombra.Enabled = False
        'txtFechaInicioControl.Text = ""
        'labInforme.Text = ""
        'txtFechaInicioControl2.Text = ""
        'labInforme2.Text = ""
        'PanelImpresion.Visible = False

        InicializaDatos()
        'GrabaDatosySigue()
        MuestraControlEcografico()
        'borra el informe que estuviera en el panel de impresion
        BorraPanelImpresion()
        'pone visible el tab del informe
        TabControl1.SelectedIndex = 0

    End Sub







    Private Sub GrabaDatosySigue()
        botNuevo.Enabled = True
        botSelecciona.Enabled = False
        botRenombra.Enabled = False
        botElimina.Enabled = False
        ListBoxInformes.Enabled = True

        botNuevaImagen.Enabled = True
        botAbreImagen.Enabled = False
        botRenombraImagen.Enabled = False
        botEliminaImagen.Enabled = False

        DatosModificados = False
        botGuardarNuevosDatos.Enabled = False
        botGuardarYsalir.Enabled = False
        botSalirSinGuardar.Enabled = True
        botSalirSinGuardar.Text = "Salir"

        labCambios.Text = "Cambios Guardados"
        labCambios.BackColor = Color.LightGreen

        NuevoEco = False
    End Sub


    Private Sub BorraRADbuttons1erT()

        'Anatomicos y funcionales
        rad1erTVejiga01.Checked = False
        rad1erTVejiga02.Checked = False
        rad1erTtipoEmbarazo01.Checked = False
        rad1erTtipoEmbarazo02.Checked = False
        rad1erTLocalizacionEmbarazo01.Checked = False
        rad1erTlocalizacionEmbarazo02.Checked = False
        Rad1erTImplantacion1.Checked = False
        Rad1erTImplantacion2.Checked = False
        Rad1erTImplantacion3.Checked = False
        Rad1erTImplantacion4.Checked = False
        rad1erTsacoGestacional01.Checked = False
        rad1erTsacoGestacional02.Checked = False
        rad1erTVitelina01.Checked = False
        rad1erTVitelina02.Checked = False
        Rad1erTEmbrion1.Checked = False
        Rad1erTEmbrion2.Checked = False
        Rad1erTMovimientos1.Checked = False
        Rad1erTMovimientos2.Checked = False
        Rad1erTActCardiaca1.Checked = False
        Rad1erTActCardiaca2.Checked = False
        'perinatales
        rad1erTtranslucencia01.Checked = False
        rad1erTtranslucencia02.Checked = False
        rad1erThuesosNasales01.Checked = False
        rad1erThuesosNasales02.Checked = False
        rad1erTductusVenoso01.Checked = False
        rad1erTductusVenoso02.Checked = False
        rad1erTanguloFM01.Checked = False
        rad1erTanguloFM02.Checked = False

    End Sub

    Private Sub BorraRADButtonsyTXTGIN()
        RadGinVejigaVolumen1.Checked = False
        RadGinVejigaVolumen2.Checked = False
        RadGinVejigaVolumen3.Checked = False
        RadGinVejigaAdecuada1.Checked = False
        RadGinVejigaAdecuada2.Checked = False
        RadGinVejigaParedes1.Checked = False
        RadGinVejigaParedes2.Checked = False
        txtGinVejigaObservaciones1.Clear()
        txtGinVejigaObservaciones2.Clear()
        RadGinUteroPosicion1.Checked = False
        RadGinUteroPosicion2.Checked = False
        RadGinUteroPosicion3.Checked = False
        RadGinUteroInclinacion1.Checked = False
        RadGinUteroInclinacion2.Checked = False
        RadGinUteroInclinacion3.Checked = False
        RadGinUteroEcopatron1.Checked = False
        RadGinUteroEcopatron2.Checked = False
        RadGinUteroBordes1.Checked = False
        RadGinUteroBordes2.Checked = False
        RadGinUteroEndometrio1.Checked = False
        RadGinUteroEndometrio2.Checked = False
        RadGinUteroEndometrio3.Checked = False
        RadGinUteroEndometrio4.Checked = False
        RadGinUteroEndometrio5.Checked = False
        RadGinUteroCavidad1.Checked = False
        RadGinUteroCavidad2.Checked = False
        RadGinUteroCavidad3.Checked = False
        RadGinUteroCavidad4.Checked = False
        RadGinUteroCavidad5.Checked = False
        txtGinUteroObservaciones1.Clear()
        txtGinUteroObservaciones2.Clear()
        RadGinOvarioDerechoTamano1.Checked = False
        RadGinOvarioDerechoTamano2.Checked = False
        RadGinOvarioDerechoTamano3.Checked = False
        RadGinOvarioIzquierdoTamano1.Checked = False
        RadGinOvarioIzquierdoTamano2.Checked = False
        RadGinOvarioIzquierdoTamano3.Checked = False
        txtGinOvarioDerechoObservaciones1.Clear()
        txtGinOvarioDerechoObservaciones2.Clear()
        txtGinOvarioDerechoObservaciones3.Clear()
        txtGinOvarioDerechoObservaciones4.Clear()
        txtGinOvarioIzquierdoObservaciones1.Clear()
        txtGinOvarioIzquierdoObservaciones2.Clear()
        txtGinOvarioIzquierdoObservaciones3.Clear()
        txtGinOvarioIzquierdoObservaciones4.Clear()
        RadGinTrompas1.Checked = False
        RadGinTrompas2.Checked = False
        RadGinTrompas3.Checked = False
        RadGinTrompas4.Checked = False
        RadGinDouglas1.Checked = False
        RadGinDouglas2.Checked = False
        txtGinOtrosObservaciones1.Clear()
        txtGinOtrosObservaciones2.Clear()
        txtGinIDx1.Clear()
        txtGinIDx2.Clear()
        txtGinIDx3.Clear()
        txtGinIDx4.Clear()
        radGINfrec35.Checked = False
        radGINfrec50.Checked = False
        radGINfrec75.Checked = False
    End Sub

    Private Sub BorraEstructuraRelacionadaConLosRadButtons1erT()
        'AHORA sincroniza la estructura con los cambios de pantalla
        ParteChorizo1erT(4) = "@"  'saco vitelino
        ParteChorizo1erT(5) = "@"  'vejiga llena o vacia
        ParteChorizo1erT(6) = "@"  'localizacion del embarazo
        ParteChorizo1erT(7) = "@"  'tipo de embarazo unico o multiple
        ParteChorizo1erT(8) = "@"  'translucencia nucal
        ParteChorizo1erT(9) = "@"  'huesos nasales
        ParteChorizo1erT(10) = "@" 'ductus venoso
        ParteChorizo1erT(11) = "@" 'angulo fronto maxilar
        ParteChorizo1erT(12) = "@" 'saco gestacional
        'actualiza el chorizo constituido y grabalo a la estructura en el adicional del 1erT
        ActualizaChorizo1erT()
        'actualiza los datos directos que se ponen individuales en la estructura q son afectados
        R.d05ImplatacionSG = ""
        R.d06EmbrionVisible = ""
        R.d07MovimientosPresentes = ""
        R.d08ActividadCardiaca = ""
    End Sub

    Private Sub BorraPanelImpresion()
        'borra el informe que estuviera en el panel de impresion
        Fondo = Me.CreateGraphics
        BMP = New Bitmap(PictureBox2.Width, PictureBox2.Height)
        PictureBox2.Image = BMP
        Fondo.Clear(PictureBox2.BackColor)
        Gr = Graphics.FromImage(BMP)
    End Sub



    Private Sub SeRealizoUnCambio()
        DatosModificados = True
        botSalirSinGuardar.Text = "Cancelar Cambios"
        botGuardarNuevosDatos.Enabled = True
        botGuardarYsalir.Enabled = True
        labCambios.Text = "Cambios por Guardar..."
        labCambios.BackColor = Color.LightPink
    End Sub

    Private Sub DatosSinCambios()
        DatosModificados = False
        botSalirSinGuardar.Text = "Salir"
        botGuardarNuevosDatos.Enabled = False
        botGuardarYsalir.Enabled = False
        labCambios.Text = "Cambios Guardados"
        labCambios.BackColor = Color.LightGreen
    End Sub

    '---------------------------------------------------------------------
    '= parte de los calculos biometricos
    '---------------------------------------------------------------------
    Private Sub CalculaPesoEstimado()
        If txtCA.Text <> "" And txtCC.Text <> "" And txtFemur.Text <> "" Then
            'tengo todos los datos agarra la formula completa cc ca femur
            Formula2()
            Exit Sub
        End If

        If txtCA.Text <> "" And txtCC.Text <> "" And txtFemur.Text = "" Then
            'tengo todos menos el femur
            Formula5()
            Exit Sub
        End If

        If txtCA.Text <> "" And txtCC.Text = "" And txtFemur.Text <> "" Then
            ''tengo todos menos la cc
            Formula3()
            Exit Sub
        End If

        If txtCA.Text <> "" And txtCC.Text = "" And txtFemur.Text = "" And txtDBP.Text <> "" Then
            'solo tengo ca y dbp
            Formula1()
            Exit Sub
        End If

        If txtCA.Text <> "" And txtCC.Text = "" And txtFemur.Text = "" And txtDBP.Text = "" Then
            ''solo tengo cs
            Formula4()
            Exit Sub
        End If

        'si llego hasta aqui es que no puede calcular el peso
        txtPeso.Text = ""
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(14) = "@"
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura

    End Sub

    Private Sub Formula1() '"Peso Fetal Estimado (por CA y DBP)"
        Dim Valor, Exponente As Double
        Dim Peso As Int64
        Dim CA, DBP As Double
        CA = CType(txtCA.Text, Double)
        CA = CA / 10
        DBP = CType(txtDBP.Text, Double)
        DBP = DBP / 10
        Exponente = (0.166 * DBP) + (0.046 * CA) - (0.002646 * CA * DBP) - 1.7492
        Valor = 1000 * (10 ^ Exponente)
        Peso = Math.Abs(Valor)
        txtPeso.Text = Peso.ToString
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(14) = txtPeso.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
    End Sub
    Private Sub Formula2() '"Peso Fetal Estimado (por CC, CA y LF)"
        Dim Valor, Exponente As Double
        Dim Peso As Int64
        Dim CA, CC, LF As Double
        CA = CType(txtCA.Text, Double)
        CA = CA / 10
        CC = CType(txtCC.Text, Double)
        CC = CC / 10
        LF = CType(txtFemur.Text, Double)
        LF = LF / 10
        Exponente = 1.5662 - (0.0108 * CC) + (0.0468 * CA) + (0.171 * LF) + (0.00034 * (CC ^ 2)) - (0.003685 * CA * LF)
        Valor = 10 ^ Exponente
        Peso = Math.Abs(Valor)
        txtPeso.Text = Peso.ToString
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(14) = txtPeso.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
    End Sub
    Private Sub Formula3() '"Peso Fetal Estimado (por CA y LF)"
        Dim Valor, Exponente As Double
        Dim Peso As Int64
        Dim CA, LF As Double
        CA = CType(txtCA.Text, Double)
        CA = CA / 10
        LF = CType(txtFemur.Text, Double)
        LF = LF / 10
        Exponente = 1.304 + (0.05281 * CA) + (0.1938 * LF) - (0.004 * CA * LF)
        Valor = 10 ^ Exponente
        Peso = Math.Abs(Valor)
        txtPeso.Text = Peso.ToString
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(14) = txtPeso.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
    End Sub
    Private Sub Formula4() 'peso fetal Estimado (por CA)"
        Dim Valor As Double
        Dim Peso As Int64
        Dim CA As Double
        CA = CType(txtCA.Text, Double)
        CA = CA / 10
        Valor = (CA ^ 3) * 0.0816
        Peso = Math.Abs(Valor)
        txtPeso.Text = Peso.ToString
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(14) = txtPeso.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
    End Sub
    Private Sub Formula5() '"Peso Fetal Estimado (por CC y CA)"
        Dim Valor, Exponente As Double
        Dim Peso As Int64
        Dim CA, CC As Double
        CA = CType(txtCA.Text, Double)
        CA = CA / 10
        CC = CType(txtCC.Text, Double)
        CC = CC / 10
        Exponente = 1.6575 + (0.04035 * CC) + (0.01285 * CA)
        Valor = 10 ^ Exponente
        Peso = Math.Abs(Valor)
        txtPeso.Text = Peso.ToString
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(14) = txtPeso.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
    End Sub

    'Boton Calcula Circunferencia Cefalica
    Private Sub botCalculaCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCalculaCC.Click
        If txtDBP.Text <> "" And txtDOF.Text <> "" Then
            CalculaCircunfernciaCefalica()
        Else
            MsgBox("Faltan datos para calcular la circunferencia cefálica, por favor revisa el DBP y el DOF.", MsgBoxStyle.Information, "Faltan Datos.")
        End If
        'al final actualiza la parte de la edad gestaciona sisi o sino porq se puede alterar de lo que habia
        CalculaEGconCC()
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub CalculaCircunfernciaCefalica()
        Dim DBP, DOF As Double
        Dim CC As Double
        Dim Valor As Integer

        DBP = CType(txtDBP.Text, Double)
        DOF = CType(txtDOF.Text, Double)

        CC = Math.Round(1.57 * (DBP + DOF))

        Valor = CC \ 5  'la tablaCC esta basada en segmentos de 5 cm

        'verifica que valor este entre el rango de la tabla
        If Valor < 11 Then
            'esta fuera del rango
            ''labCirCef.Text = "F/R"
            ''labEGxCC.Text = "Por debajo del rango"
            ''EGxCCenDias = 0
            txtCC.Text = ""
            'actualiza la parte del chorizo modificada
            ParteDelChorizo(0) = "@"
            ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
            MsgBox("con los datos de DBP y DOF el resultado de la C.Cef está fuera del rango de cálculos de la Tabla de Hadlock", MsgBoxStyle.Information, "Circunferencia Cefálica fuera de rango")
        ElseIf Valor > 72 Then
            'valor por encima de la tabla lo pone a 43 semanas
            ''labCirCef.Text = CC
            ''labEGxCC.Text = "Más de 43 semanas"
            ''EGxCCenDias = 301
            txtCC.Text = ""
            'actualiza la parte del chorizo modificada
            ParteDelChorizo(0) = "@"
            ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
            MsgBox("con los datos de DBP y DOF el resultado de la C.Cef está fuera del rango de cálculos de la Tabla de Hadlock", MsgBoxStyle.Information, "Circunferencia Cefálica fuera de rango")
        Else
            'esta dentro del rango, calcula la CC
            ''EGxCCenDias = TablaCC(Valor)
            ''NumeroDiasEG = EGxCCenDias
            ''ProcesaDiasEnSemanasMasDias()
            txtCC.Text = CC.ToString
            'actualiza la parte del chorizo modificada
            ParteDelChorizo(0) = txtCC.Text
            ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
            CalculaPesoEstimado()

            ''labEGxCC.Text = TextoDeEGenSemanasyDias
        End If

    End Sub

    Private Sub CalculaBPF()
        Dim DBPlocal As Integer = 0
        Dim FemurLocal As Integer = 0
        Dim BPFlocal As Integer = 0

        If IsNumeric(txtDBP.Text) And IsNumeric(txtFemur.Text) Then
            'ambos datos introducidos y validos procede al calculo

            DBPlocal = CType(txtDBP.Text, Integer)
            FemurLocal = CType(txtFemur.Text, Integer)
            BPFlocal = DBPlocal + FemurLocal
            txtBPF.Text = BPFlocal.ToString

            'actualiza la parte del chorizo modificada
            ParteDelChorizo(13) = txtBPF.Text
            ActualizaChorizoBiometrico()
            'ActualizaImagenParaImprimir()
        Else
            'alguno de los dos datos necesarios no esta listo
            txtBPF.Text = ""
            ParteDelChorizo(13) = "@"
            ActualizaChorizoBiometrico()
            'ActualizaImagenParaImprimir()
        End If
    End Sub

    Private Sub CalculaTallaFetal()

        Dim FemurLocal As Integer = 0
        Dim TallaLocal As Decimal

        If IsNumeric(txtFemur.Text) Then
            'datos del femur introducidos y validos procede al calculo


            FemurLocal = CType(txtFemur.Text, Integer)
            If FemurLocal > 9 And FemurLocal < 84 Then
                TallaLocal = TablaLongitudFetaL(FemurLocal) / 10
                txtTalla.Text = TallaLocal
                'actualiza la parte del chorizo modificada
                ParteDelChorizo(15) = TallaLocal.ToString

            Else
                'el valor del femur esta fuera de rango
                txtTalla.Text = "f/r"
                ParteDelChorizo(15) = "f/r"
            End If
            ActualizaChorizoBiometrico()
            'ActualizaImagenParaImprimir()
        Else
            'alguno de los datos necesarios no esta listo

        End If
    End Sub

    Private Sub CalculaEGconDBP()
        Dim Valor As Integer
        'Dim Promedio As Integer

        If txtDBP.Text <> "" Then
            'existe un dato, calcula la EGxDBP, 
            Valor = CType(txtDBP.Text, Integer)
            If Valor <> 0 Then
                EGxDBPenDias = CType(((9.54 + (0.1482 * Valor) + (0.001676 * Valor ^ 2)) * 7), Integer)
            Else
                'la casilla tiene valor de 0
                EGxDBPenDias = 0
            End If

        Else
            'la casilla esta vacia
            EGxDBPenDias = 0
        End If

        'muestra la eg x dbp en el label de al lado
        NumeroDiasEG = EGxDBPenDias
        ProcesaDiasEnSemanasMasDias()
        lab2y3egxDBP.Text = TextoDeEGenSemanasyDiasCorto

        ''ahora trata de calcular la general
        'CalculaEGxECO()
    End Sub

    Private Sub CalculaEGconCA()
        Dim valor As Integer = 0

        If txtCA.Text <> "" Then
            'existe el dato saca cuentas
            valor = CType(txtCA.Text, Integer)

            If valor <> 0 Then
                EGxCAenDias = CType(((8.14 + (0.0753 * valor) + (0.000036 * valor ^ 2)) * 7), Integer)
            Else
                'tiene valor de 0
                EGxCAenDias = 0
            End If
        Else
            'no existe dato 
            EGxCAenDias = 0
        End If

        'muestra la eg x ca en el label de al lado
        NumeroDiasEG = EGxCAenDias
        ProcesaDiasEnSemanasMasDias()
        lab2y3egxCA.Text = TextoDeEGenSemanasyDiasCorto

        ''ahora trata de calcular la general
        'CalculaEGxECO()
    End Sub

    Private Sub CalculaEGconCC()
        Dim valor As Integer = 0

        If txtCC.Text <> "" Then
            'existe el dato saca cuentas
            valor = CType(txtCC.Text, Integer)
            If valor <> 0 Then
                EGxCCenDias = CType(((8.96 + (0.054 * valor) + (0.0000003 * valor ^ 3)) * 7), Integer)
            Else
                'tiene valor de 0
                EGxCCenDias = 0
            End If
        Else
            'no existe dato 
            EGxCCenDias = 0
        End If

        'muestra la eg x cc en el label de al lado
        NumeroDiasEG = EGxCCenDias
        ProcesaDiasEnSemanasMasDias()
        lab2y3egxCC.Text = TextoDeEGenSemanasyDiasCorto

        ''ahora trata de calcular la general
        'CalculaEGxECO()
    End Sub

    Private Sub CalculaEGconFemur()
        Dim valor As Integer = 0

        If txtFemur.Text <> "" Then
            'existe el dato saca cuentas
            valor = CType(txtFemur.Text, Integer)
            If valor <> 0 Then
                EGxFEMURenDias = CType(((10.35 + (0.246 * valor) + (0.0017 * valor ^ 2)) * 7), Integer)
            Else
                'tiene valor de 0
                EGxFEMURenDias = 0
            End If
        Else
            'no existe dato 
            EGxFEMURenDias = 0
        End If

        'muestra la eg x femur en el label de al lado
        NumeroDiasEG = EGxFEMURenDias
        ProcesaDiasEnSemanasMasDias()
        lab2y3egxFem.Text = TextoDeEGenSemanasyDiasCorto

        ''ahora trata de calcular la general
        'CalculaEGxECO()
    End Sub

    Private Sub CalculaEGconTibia()
        Dim valor As Integer = 0

        If txtTibia.Text <> "" Then
            'existe el dato saca cuentas
            valor = CType(txtTibia.Text, Integer)
            'verifica que el valor este dentro de los rangos de la tabla
            If valor < 12 Then
                'por debajo del nivel minimo
                EGxTIBIAenDias = 0
            ElseIf valor > 68 Then
                'fuera del rango por poco pone al valor maximo
                EGxTIBIAenDias = 301
            Else
                'dentro del rango normal hace los calculos
                EGxTIBIAenDias = TablaTibia(valor)
            End If
        Else
            'no existe dato 
            EGxTIBIAenDias = 0
        End If
        'ahora trata de calcular la general
        CalculaEGxECO()
    End Sub

    Private Sub CalculaEGconHumero()
        Dim valor As Integer = 0

        If txtHumero.Text <> "" Then
            'existe el dato saca cuentas
            valor = CType(txtHumero.Text, Integer)
            'verifica que el valor este dentro de los rangos de la tabla
            If valor < 11 Then
                'por debajo del nivel minimo
                EGxHUMEROenDias = 0
            ElseIf valor > 68 Then
                'fuera del rango por poco pone al valor maximo
                EGxHUMEROenDias = 301
            Else
                'dentro del rango normal hace los calculos
                EGxHUMEROenDias = TablaHumero(valor)
            End If
        Else
            'no existe dato 
            EGxHUMEROenDias = 0
        End If
        'ahora trata de calcular la general
        CalculaEGxECO()
    End Sub

    'calculo de la Edad gestacional definitiva x eco
    Private Sub CalculaEGxECO()
        Dim DatosValidos As Integer = 0
        Dim TotalDeDias As Integer = 0

        'dbp
        If EGxDBPenDias <> 0 Then
            DatosValidos += 1
            TotalDeDias += EGxDBPenDias
        End If
        'cc
        If EGxCCenDias <> 0 Then
            DatosValidos += 1
            TotalDeDias += EGxCCenDias
        End If
        'ca
        If EGxCAenDias <> 0 Then
            DatosValidos += 1
            TotalDeDias += EGxCAenDias
        End If
        'femur
        If EGxFEMURenDias <> 0 Then
            DatosValidos += 1
            TotalDeDias += EGxFEMURenDias
        End If
        'tibia
        If EGxTIBIAenDias <> 0 Then
            DatosValidos += 1
            TotalDeDias += EGxTIBIAenDias
        End If
        'humero
        If EGxHUMEROenDias <> 0 Then
            DatosValidos += 1
            TotalDeDias += EGxHUMEROenDias
        End If

        'áhora ve si hay datos validos
        If DatosValidos <> 0 Then
            EGxECO2y3erTenDias = TotalDeDias \ DatosValidos
            'carga el valor en la variable publica para calcular el texto
            NumeroDiasEG = EGxECO2y3erTenDias
            'manda los datos para obtener el texto de la edad gestacional
            ProcesaDiasEnSemanasMasDias()
            'regresa con el dato
            txtIdx01del2y3erT.Text = TextoDeEGenSemanasyDiasLargo
            'actualiza la parte del chorizo modificada
            ParteDelChorizoDX(0) = txtIdx01del2y3erT.Text
            ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        Else
            txtIdx01del2y3erT.Text = "Faltan datos."
            'actualiza la parte del chorizo modificada
            ParteDelChorizoDX(0) = txtIdx01del2y3erT.Text
            ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        End If

    End Sub

    '---------------------------------------------------------------------
    '= Procesamiento de EG en dias a EG en Semanas + Dias                =
    '= necesita NumeroDiasEG as integer desde donde se llama y...        =
    '= Calcula: TextoDeEGenSemanasyDias as string y TextodeFPP as string =
    '---------------------------------------------------------------------
    Private Sub ProcesaDiasEnSemanasMasDias()
        Dim EG As Integer
        Dim Semanas, Dias As Integer
        Dim Calculo As Double
        Dim FPP As Date
        'Dim Hoy As Date
        Dim TextoSemana, TextoDia As String
        Dim TextoSemanaCorto, TextoDiaCorto As String
        Dim FURinicio As Date

        'inicializa vars
        TextoDia = ""
        TextoSemana = ""
        TextoDiaCorto = ""
        TextoSemanaCorto = ""

        EG = NumeroDiasEG
        FURinicio = Form1.Informe04FUR
        FPP = FURinicio.AddDays(280)

        If EG < 1 Then
            'valor invalido
            'vamos a ver que le pongo
            TextoDeEGenSemanasyDiasLargo = ""
            TextoDeEGenSemanasyDiasCorto = ""
            TextoDeFPP = FPP.ToString("dd/MM/yyyy")
        ElseIf EG > 300 Then
            'la eg da 43 semanas o mas, lo dice
            TextoDeEGenSemanasyDiasLargo = "Más de 43 semanas"
            TextoDeEGenSemanasyDiasCorto = "+43s"
            TextoDeFPP = FPP.ToString("dd/MM/yyyy")
        Else
            'esta en el rango de calculo lo hace
            Semanas = EG \ 7
            Calculo = (EG / 7) - Semanas
            If Calculo = 0 Then
                Dias = 0
            Else
                Dias = CInt(Calculo * 7)
            End If
            'parte de las semanas largo
            If Semanas = 1 Then
                TextoSemana = "1 Semana"
            Else
                TextoSemana = Semanas & " Semanas"
            End If
            'parte de las semanas corto
            TextoSemanaCorto = Semanas & "s"
            'parte de los dias largo
            If Dias = 0 And Semanas = 1 Then
                TextoDia = " Exacta."
            ElseIf Dias = 0 And Semanas <> 1 Then
                TextoDia = " Exactas."
            ElseIf Dias = 1 Then
                TextoDia = " y 1 día."
            ElseIf Dias > 1 Then
                TextoDia = " y " & Dias & " días."
            End If
            'parte de los dias corto
            TextoDiaCorto = Dias & "d"

            TextoDeEGenSemanasyDiasLargo = TextoSemana & TextoDia
            TextoDeEGenSemanasyDiasCorto = TextoSemanaCorto & TextoDiaCorto
            TextoDeFPP = FPP.ToString("dd/MM/yyyy")
        End If

    End Sub

    '----------------------------------------------------------
    '= Eventos de captacion de datos
    '----------------------------------------------------

    'R.c02Paridad de los tres casos...
    Private Sub txtParidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtParidad1erT.KeyPress, txtParidad2y3erT.KeyPress, txtParidadGinecologico.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetter(c) Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If

    End Sub

    Private Sub txtParidad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtParidad1erT.Leave, txtParidad2y3erT.Leave, txtParidadGinecologico.Leave

        If R.c00TipoDeEstudio = 1 Then
            R.c02Paridad = txtParidad1erT.Text
        ElseIf R.c00TipoDeEstudio = 2 Then
            R.c02Paridad = txtParidad2y3erT.Text
        ElseIf R.c00TipoDeEstudio = 3 Then
            R.c02Paridad = txtParidadGinecologico.Text
        End If
        ActualizaImagenParaImprimir()
    End Sub

    'Parte del 1er trimestre

    'R.d01SGlongitudinal, R.d02SGAnteroPosterior y R.d03SGTransversal
    Private Sub txtSG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt1erSGlong.KeyPress, txt1erSGantPost.KeyPress, txt1erSGtrans.KeyPress
        Dim c As Char
        c = e.KeyChar

        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub

    Private Sub txtSacoGestacional_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erSGlong.Leave, txt1erSGantPost.Leave, txt1erSGtrans.Leave

        CalculaEGxSG()

        ActualizaImagenParaImprimir()

    End Sub

    Private Sub CalculaEGxSG()
        Dim Promedio As Integer
        Dim NumerodeValores As Integer = 0
        Dim V1, V2, V3 As Integer

        If txt1erSGlong.Text <> "" Then
            R.d01SGlongitudinal = txt1erSGlong.Text
            V1 = CType(txt1erSGlong.Text, Integer)
            NumerodeValores += 1
        Else
            R.d01SGlongitudinal = ""
            V1 = 0
        End If

        If txt1erSGantPost.Text <> "" Then
            R.d02SGanteroposterior = CType(txt1erSGantPost.Text, Integer)
            V2 = txt1erSGantPost.Text
            NumerodeValores += 1
        Else
            R.d02SGanteroposterior = ""
            V2 = 0
        End If

        If txt1erSGtrans.Text <> "" Then
            R.d03SGtransversal = CType(txt1erSGtrans.Text, Integer)
            V3 = txt1erSGtrans.Text
            NumerodeValores += 1
        Else
            R.d03SGtransversal = ""
            V3 = 0
        End If

        If NumerodeValores > 0 Then
            Promedio = (V1 + V2 + V3) \ NumerodeValores
            lab1erSGprom.Text = Promedio.ToString
            R.r01SGPromedio = lab1erSGprom.Text

            'existe el dato saca cuentas
            Dim valor = Promedio

            If valor <> 0 Then
                EGxSGenDias = CType(((4.299 + (0.132 * valor)) * 7), Integer)
            Else
                'tiene valor de 0
                EGxSGenDias = 0
            End If

            'muestra la eg x sg en el label de al lado
            NumeroDiasEG = EGxSGenDias
            ProcesaDiasEnSemanasMasDias()
            lab1erEGxSG.Text = TextoDeEGenSemanasyDiasCorto
            R.r02EGxSG = lab1erEGxSG.Text
            'despues de que calcule esto trata de calcular el definitivo
            CalculaEG1erTxECO()
        Else
            lab1erSGprom.Text = ""
            R.r01SGPromedio = ""
            lab1erEGxSG.Text = ""
            R.r02EGxSG = ""
            EGxSGenDias = 0
            'despues de que calcule esto trata de calcular el definitivo
            CalculaEG1erTxECO()
        End If
    End Sub

    'R.d04LCC
    Private Sub txtLCC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1erLCC.KeyPress
        Dim c As Char
        c = e.KeyChar

        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If

    End Sub

    Private Sub txtLCC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erLCC.Leave
        CalculaEGxLCC()
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub CalculaEGxLCC()

        If txt1erLCC.Text <> "" Then

            R.d04LCC = txt1erLCC.Text

            'existe el dato saca cuentas
            Dim valor = CType(txt1erLCC.Text, Integer)

            If valor <> 0 Then
                EGxLCCenDias = CType(((23.73 + (8.052 * valor ^ 0.5)) * 1), Integer)
            Else
                'tiene valor de 0
                EGxLCCenDias = 0
            End If

            'muestra la eg x lcc en el label de al lado
            NumeroDiasEG = EGxLCCenDias
            ProcesaDiasEnSemanasMasDias()
            lab1erEGxLCC.Text = TextoDeEGenSemanasyDiasCorto
            R.r03EGxLCC = lab1erEGxLCC.Text

            'despues de que calcule esto trata de calcular el definitivo
            CalculaEG1erTxECO()

        Else
            R.d04LCC = ""
            lab1erEGxLCC.Text = ""
            R.r03EGxLCC = ""
            EGxLCCenDias = 0
            CalculaEG1erTxECO()
        End If
    End Sub

    'parte biometrica del 2do chorizo del 1er trimestre
    Private Sub txtOtrasBiometricasDel1erT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt1erDBP.KeyPress, txt1erCC.KeyPress, txt1erCA.KeyPress, txt1erFemur.KeyPress, txt1erTN.KeyPress

        Dim c As Char
        c = e.KeyChar

        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If

    End Sub

    'este sub se usa en todas las txt dependiente de las adicionales de r.d11
    Private Sub ActualizaChorizoB1erT()
        ChorizoB1erT = "" 'inicializa el chorizo
        For Me.Cont = 0 To 14 'ahora codifica cada parte una a una incluida la modificasda claro
            ChorizoB1erT += ParteChorizoB1erT(Cont) & "|"
        Next
        ChorizoB1erT += ParteChorizoB1erT(15)    'la ultima pa no ponerle el palito al final
        'actualiza la estructura pa dejar la vaina ya transformada pues
        R.d11AdicionalesB1erT = ChorizoB1erT

        ActualizaImagenParaImprimir()
    End Sub

    'parte(0) del 2do chorizo del 1er trimestre dbp
    Private Sub txt1erdbp_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txt1erDBP.Leave


        If txt1erDBP.Text <> "" Then
            'existe un dato, calcula la EGxDBP, 
            Dim Valor = CType(txt1erDBP.Text, Integer)
            If Valor <> 0 Then
                EGxDBPenDias = CType(((9.54 + (0.1482 * Valor) + (0.001676 * Valor ^ 2)) * 7), Integer)
            Else
                'la casilla tiene valor de 0
                EGxDBPenDias = 0
            End If

        Else
            'la casilla esta vacia
            EGxDBPenDias = 0
        End If

        'muestra la eg x dbp en el label de al lado
        NumeroDiasEG = EGxDBPenDias
        ProcesaDiasEnSemanasMasDias()
        lab1erEGxDBP.Text = TextoDeEGenSemanasyDiasCorto

        'despues de que calcule esto trata de calcular el definitivo
        CalculaEG1erTxECO()

        'actualiza el chorizo
        ParteChorizoB1erT(0) = txt1erDBP.Text
        ActualizaChorizoB1erT()
    End Sub

    'parte(1) del 2do chorizo del 1er trimestre cc
    Private Sub txt1ercc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txt1erCC.Leave


        If txt1erCC.Text <> "" Then
            'existe un dato, calcula la EGxcc, 
            Dim Valor = CType(txt1erCC.Text, Integer)
            If Valor <> 0 Then
                EGxCCenDias = CType(((8.96 + (0.054 * Valor) + (0.0000003 * Valor ^ 3)) * 7), Integer)
            Else
                'la casilla tiene valor de 0
                EGxCCenDias = 0
            End If

        Else
            'la casilla esta vacia
            EGxCCenDias = 0
        End If

        'muestra la eg x cc en el label de al lado
        NumeroDiasEG = EGxCCenDias
        ProcesaDiasEnSemanasMasDias()
        lab1erEGxCC.Text = TextoDeEGenSemanasyDiasCorto

        'despues de que calcule esto trata de calcular el definitivo
        CalculaEG1erTxECO()

        'actualiza el chorizo
        ParteChorizoB1erT(1) = txt1erCC.Text
        ActualizaChorizoB1erT()
    End Sub

    'parte(2) del 2do chorizo del 1er trimestre ca
    Private Sub txt1erca_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txt1erCA.Leave


        If txt1erCA.Text <> "" Then
            'existe un dato, calcula la EGxca, 
            Dim Valor = CType(txt1erCA.Text, Integer)
            If Valor <> 0 Then
                EGxCAenDias = CType(((8.14 + (0.0753 * Valor) + (0.000036 * Valor ^ 2)) * 7), Integer)
            Else
                'la casilla tiene valor de 0
                EGxCAenDias = 0
            End If

        Else
            'la casilla esta vacia
            EGxCAenDias = 0
        End If

        'muestra la eg x ca en el label de al lado
        NumeroDiasEG = EGxCAenDias
        ProcesaDiasEnSemanasMasDias()
        lab1erEGxCA.Text = TextoDeEGenSemanasyDiasCorto

        'despues de que calcule esto trata de calcular el definitivo
        CalculaEG1erTxECO()

        'actualiza el chorizo
        ParteChorizoB1erT(2) = txt1erCA.Text
        ActualizaChorizoB1erT()

    End Sub

    'parte(3) del 2do chorizo del 1er trimestre femur
    Private Sub txt1erfemur_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txt1erFemur.Leave


        If txt1erFemur.Text <> "" Then
            'existe un dato, calcula la EGxfemur, 
            Dim Valor = CType(txt1erFemur.Text, Integer)
            If Valor <> 0 Then
                EGxFEMURenDias = CType(((10.35 + (0.246 * Valor) + (0.0017 * Valor ^ 2)) * 7), Integer)
            Else
                'la casilla tiene valor de 0
                EGxFEMURenDias = 0
            End If

        Else
            'la casilla esta vacia
            EGxFEMURenDias = 0
        End If

        'muestra la eg x femur en el label de al lado
        NumeroDiasEG = EGxFEMURenDias
        ProcesaDiasEnSemanasMasDias()
        lab1erEGxFemur.Text = TextoDeEGenSemanasyDiasCorto

        'despues de que calcule esto trata de calcular el definitivo
        CalculaEG1erTxECO()

        'actualiza el chorizo
        ParteChorizoB1erT(3) = txt1erFemur.Text
        ActualizaChorizoB1erT()

    End Sub

    'parte(4) del 2do chorizo del 1er trimestre tn
    Private Sub txt1ertn_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txt1erTN.Leave

        'actualiza el chorizo
        ParteChorizoB1erT(4) = txt1erTN.Text
        ActualizaChorizoB1erT()

    End Sub

    'Calcula la edad ecografica del 1er trimestre
    Private Sub CalculaEG1erTxECO()
        Dim NumeroValores As Integer = 0
        If EGxSGenDias <> 0 Then
            NumeroValores += 1
        End If
        If EGxLCCenDias <> 0 Then
            NumeroValores += 1
        End If
        If EGxDBPenDias <> 0 Then
            NumeroValores += 1
        End If
        If EGxCCenDias <> 0 Then
            NumeroValores += 1
        End If
        If EGxCAenDias <> 0 Then
            NumeroValores += 1
        End If
        If EGxFEMURenDias <> 0 Then
            NumeroValores += 1
        End If

        If NumeroValores = 0 Then
            txt1erEGxECO.Text = "Faltan Datos"
            R.r04EG1erT = txt1erEGxECO.Text
        Else
            EGxECO1erTenDias = (EGxSGenDias + EGxLCCenDias + EGxDBPenDias + EGxCCenDias + EGxCAenDias + EGxFEMURenDias) \ NumeroValores
            NumeroDiasEG = EGxECO1erTenDias
            ProcesaDiasEnSemanasMasDias()
            txt1erEGxECO.Text = TextoDeEGenSemanasyDiasLargo
            R.r04EG1erT = txt1erEGxECO.Text
        End If

        ActualizaImagenParaImprimir()
    End Sub

    'este sub se usa en todas las txt dependiente de las adicionales de r.d13
    Private Sub ActualizaChorizo1erT()
        Chorizo1erT = "" 'inicializa el chorizo
        For Me.Cont = 0 To 14 'ahora codifica cada parte una a una incluida la modificasda claro
            Chorizo1erT += ParteChorizo1erT(Cont) & "|"
        Next
        Chorizo1erT += ParteChorizo1erT(15)    'la ultima pa no ponerle el palito al final
        'actualiza la estructura pa dejar la vaina ya transformada pues
        R.d13Adicionales1erT = Chorizo1erT

        ActualizaImagenParaImprimir()
    End Sub

    'parte (0) del chorizo 1er t tipo de estudio abd o transvag
    Private Sub rad1erTtipoEstudio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles rad1erTEstudioAbd.CheckedChanged, rad1erTestudioTV.CheckedChanged
        If rad1erTEstudioAbd.Checked = True Then
            ParteChorizo1erT(0) = "1"
        ElseIf rad1erTestudioTV.Checked = True Then
            ParteChorizo1erT(0) = "2"
        Else
            ParteChorizo1erT(0) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'parte (1) del chorizo 1er t. tipo de frecuencia
    Private Sub rad1erTFrecuenciaEstudio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rad1erTfrec35.CheckedChanged, rad1erTfrec50.CheckedChanged, rad1erTfrec75.CheckedChanged
        If rad1erTfrec35.Checked = True Then
            ParteChorizo1erT(1) = "1"
        ElseIf rad1erTfrec50.Checked = True Then
            ParteChorizo1erT(1) = "2"
        ElseIf rad1erTfrec75.Checked = True Then
            ParteChorizo1erT(1) = "3"
        Else
            ParteChorizo1erT(1) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'parte (2) del chorizo 1er t. vesicula vitelina longitudial
    Private Sub txtVVlongitudinal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erVVlong.Leave
        If txt1erVVlong.Text <> "" Then
            ParteChorizo1erT(2) = txt1erVVlong.Text
        Else
            ParteChorizo1erT(2) = "@"
        End If
        ActualizaChorizo1erT()
    End Sub
    'parte (3) del chorizo 1er t. vesicula vitelina anteroposterior
    Private Sub txtVVanteroposterior_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erVVantPost.Leave
        If txt1erVVantPost.Text <> "" Then
            ParteChorizo1erT(3) = txt1erVVantPost.Text
        Else
            ParteChorizo1erT(3) = "@"
        End If
        ActualizaChorizo1erT()
    End Sub
    'parte (4) del chorizo 1er t. anatomia del saco vitelino
    Private Sub rad1erTAnatomiaVV_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rad1erTVitelina01.CheckedChanged, rad1erTVitelina02.CheckedChanged
        If rad1erTVitelina01.Checked = True Then
            ParteChorizo1erT(4) = "1"
        ElseIf rad1erTVitelina02.Checked = True Then
            ParteChorizo1erT(4) = "2"
        Else
            ParteChorizo1erT(4) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'parte (5) del chorizo 1er t. anatomia de la vejiga
    Private Sub rad1erTAnatomiaVejiga_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rad1erTVejiga01.CheckedChanged, rad1erTVejiga02.CheckedChanged
        If rad1erTVejiga01.Checked = True Then
            ParteChorizo1erT(5) = "1"
        ElseIf rad1erTVejiga02.Checked = True Then
            ParteChorizo1erT(5) = "2"
        Else
            ParteChorizo1erT(5) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'parte (6) del chorizo 1er localizacion de embarazo intrauterino o ectopico
    Private Sub rad1erTembarazoLoc_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rad1erTLocalizacionEmbarazo01.CheckedChanged, rad1erTlocalizacionEmbarazo02.CheckedChanged
        If rad1erTLocalizacionEmbarazo01.Checked = True Then
            ParteChorizo1erT(6) = "1"
        ElseIf rad1erTlocalizacionEmbarazo02.Checked = True Then
            ParteChorizo1erT(6) = "2"
        Else
            ParteChorizo1erT(6) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'parte (7) del chorizo 1er t. tipo de embarazo simple o gemelar
    Private Sub rad1erTEmbarazoSimpleoGemelar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rad1erTtipoEmbarazo01.CheckedChanged, rad1erTtipoEmbarazo02.CheckedChanged
        If rad1erTtipoEmbarazo01.Checked = True Then
            ParteChorizo1erT(7) = "1"
        ElseIf rad1erTtipoEmbarazo02.Checked = True Then
            ParteChorizo1erT(7) = "2"
        Else
            ParteChorizo1erT(7) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'parte (8) del chorizo 1er t. translucencia
    Private Sub rad1erTtraslucenciaNucal_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rad1erTtranslucencia01.CheckedChanged, rad1erTtranslucencia02.CheckedChanged
        If rad1erTtranslucencia01.Checked = True Then
            ParteChorizo1erT(8) = "1"
        ElseIf rad1erTtranslucencia02.Checked = True Then
            ParteChorizo1erT(8) = "2"
        Else
            ParteChorizo1erT(8) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'parte (9) del chorizo 1er t. huesos nasales
    Private Sub rad1erThuesosNasales_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rad1erThuesosNasales01.CheckedChanged, rad1erThuesosNasales02.CheckedChanged
        If rad1erThuesosNasales01.Checked = True Then
            ParteChorizo1erT(9) = "1"
        ElseIf rad1erThuesosNasales02.Checked = True Then
            ParteChorizo1erT(9) = "2"
        Else
            ParteChorizo1erT(9) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'parte (10) del chorizo 1er t. ductus venoso
    Private Sub rad1erTductusVenoso_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rad1erTductusVenoso02.CheckedChanged, rad1erTductusVenoso01.CheckedChanged
        If rad1erTductusVenoso01.Checked = True Then
            ParteChorizo1erT(10) = "1"
        ElseIf rad1erTductusVenoso02.Checked = True Then
            ParteChorizo1erT(10) = "2"
        Else
            ParteChorizo1erT(10) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'parte (11) del chorizo 1er t. anguloFrontomaxilar
    Private Sub rad1erTanguloFrontomaxilar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rad1erTanguloFM01.CheckedChanged, rad1erTanguloFM02.CheckedChanged
        If rad1erTanguloFM01.Checked = True Then
            ParteChorizo1erT(11) = "1"
        ElseIf rad1erTanguloFM02.Checked = True Then
            ParteChorizo1erT(11) = "2"
        Else
            ParteChorizo1erT(11) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'parte (12) del chorizo 1er t. saco gestacional
    Private Sub rad1erTSacoGestacional_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles rad1erTsacoGestacional01.CheckedChanged, rad1erTsacoGestacional02.CheckedChanged
        If rad1erTsacoGestacional01.Checked = True Then
            ParteChorizo1erT(12) = "1"
        ElseIf rad1erTsacoGestacional02.Checked = True Then
            ParteChorizo1erT(12) = "2"
        Else
            ParteChorizo1erT(12) = "@"
        End If
        ActualizaChorizo1erT()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub
    'keypresses del adicional del 1er trimestre
    Private Sub txtVV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txt1erVVlong.KeyPress, txt1erVVantPost.KeyPress
        Dim c As Char
        c = e.KeyChar

        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub
    'boton reset los rad buttons
    Private Sub botResetRadButtons1erT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botResetRadButtons1erT.Click
        'primero limpia todos los rad buttons de la pantalla ANATOMICA
        BorraRADbuttons1erT()
        'ahora sincroniza la estructura dependiente
        BorraEstructuraRelacionadaConLosRadButtons1erT()
        'actualiza la pantalla de impresion
        ActualizaImagenParaImprimir()

    End Sub

    'R.d05 Implantacion
    Private Sub RadImplantacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Rad1erTImplantacion1.CheckedChanged, Rad1erTImplantacion2.CheckedChanged, Rad1erTImplantacion3.CheckedChanged, Rad1erTImplantacion4.CheckedChanged
        If Rad1erTImplantacion1.Checked = True Then
            R.d05ImplatacionSG = "1"
        ElseIf Rad1erTImplantacion2.Checked = True Then
            R.d05ImplatacionSG = "2"
        ElseIf Rad1erTImplantacion3.Checked = True Then
            R.d05ImplatacionSG = "3"
        ElseIf Rad1erTImplantacion4.Checked = True Then
            R.d05ImplatacionSG = "4"
        Else
            R.d05ImplatacionSG = ""
        End If
        'verifica modificacion de datos
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If

        ActualizaImagenParaImprimir()

    End Sub
    'R.d06 Embrion Visible
    Private Sub RadEmbrion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Rad1erTEmbrion1.CheckedChanged, Rad1erTEmbrion2.CheckedChanged
        If Rad1erTEmbrion1.Checked = True Then
            R.d06EmbrionVisible = "1"
        ElseIf Rad1erTEmbrion2.Checked = True Then
            R.d06EmbrionVisible = "2"
        Else
            R.d06EmbrionVisible = ""
        End If
        'verifica modificacion de datos
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If

        ActualizaImagenParaImprimir()
    End Sub
    'Rd07 Movimientos Fetales
    Private Sub RadMovimientos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Rad1erTMovimientos1.CheckedChanged, Rad1erTMovimientos2.CheckedChanged
        If Rad1erTMovimientos1.Checked = True Then
            R.d07MovimientosPresentes = "1"
        ElseIf Rad1erTMovimientos2.Checked = True Then
            R.d07MovimientosPresentes = "2"
        Else
            R.d07MovimientosPresentes = ""
        End If
        'verifica modificacion de datos
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If

        ActualizaImagenParaImprimir()
    End Sub
    'R.d08 Actividad Cardiaca
    Private Sub RadActCardiaca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Rad1erTActCardiaca1.CheckedChanged, Rad1erTActCardiaca2.CheckedChanged
        If Rad1erTActCardiaca1.Checked = True Then
            R.d08ActividadCardiaca = "1"
        ElseIf Rad1erTActCardiaca2.Checked = True Then
            R.d08ActividadCardiaca = "2"
        Else
            R.d08ActividadCardiaca = ""
        End If
        'verifica modificacion de datos
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If

        ActualizaImagenParaImprimir()
    End Sub

    'este sub se usa en todas las txt dependientes de las IDX adicionales de r.d12
    Private Sub ActualizaChorizoDX1erT()
        ChorizoDX1erT = "" 'inicializa el chorizo
        For Me.Cont = 0 To 14 'ahora codifica cada parte una a una incluida la modificasda claro
            ChorizoDX1erT += ParteChorizoDX1erT(Cont) & "|"
        Next
        ChorizoDX1erT += ParteChorizoDX1erT(15)    'la ultima pa no ponerle el palito al final
        'actualiza la estructura pa dejar la vaina ya transformada pues
        R.d12IDxAdicionales1erT = ChorizoDX1erT

        ActualizaImagenParaImprimir()
    End Sub

    'parte (0) del chorizo DX del 1er t. 1ra linea de comentarios
    Private Sub txt1erTcomentarios01_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erTComentarios01.Leave
        If txt1erTComentarios01.Text <> "" Then
            ParteChorizoDX1erT(0) = txt1erTComentarios01.Text
        Else
            ParteChorizoDX1erT(0) = "@"
        End If
        ActualizaChorizoDX1erT()
    End Sub

    'parte (1) del chorizo DX del 1er t. 2da linea de comentarios
    Private Sub txt1erTcomentarios02_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erTcomentarios02.Leave
        If txt1erTcomentarios02.Text <> "" Then
            ParteChorizoDX1erT(1) = txt1erTcomentarios02.Text
        Else
            ParteChorizoDX1erT(1) = "@"
        End If
        ActualizaChorizoDX1erT()
    End Sub

    'parte (2) del chorizo DX del 1er t. 3ra linea de comentarios
    Private Sub txt1erTcomentarios03_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erTcomentarios03.Leave
        If txt1erTcomentarios03.Text <> "" Then
            ParteChorizoDX1erT(2) = txt1erTcomentarios03.Text
        Else
            ParteChorizoDX1erT(2) = "@"
        End If
        ActualizaChorizoDX1erT()
    End Sub

    'parte (3) del chorizo DX del 1er t. 4ta linea de comentarios
    Private Sub txt1erTcomentarios04_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erTcomentarios04.Leave
        If txt1erTcomentarios04.Text <> "" Then
            ParteChorizoDX1erT(3) = txt1erTcomentarios04.Text
        Else
            ParteChorizoDX1erT(3) = "@"
        End If
        ActualizaChorizoDX1erT()
    End Sub

    'parte (4) del chorizo DX del 1er t. 5ta linea de comentarios
    Private Sub txt1erTcomentarios05_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erTcomentarios05.Leave
        If txt1erTcomentarios05.Text <> "" Then
            ParteChorizoDX1erT(4) = txt1erTcomentarios05.Text
        Else
            ParteChorizoDX1erT(4) = "@"
        End If
        ActualizaChorizoDX1erT()
    End Sub

    'ojo partes de la 5 a la 7 libres porsia

    'parte (8) del chorizo DX del 1er t. 1ra linea de IDx
    Private Sub txt1erTidx01_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erTidx01.Leave
        If txt1erTidx01.Text <> "" Then
            ParteChorizoDX1erT(8) = txt1erTidx01.Text
        Else
            ParteChorizoDX1erT(8) = "@"
        End If
        ActualizaChorizoDX1erT()
    End Sub

    'parte (9) del chorizo DX del 1er t. 2da linea de IDx
    Private Sub txt1erTidx02_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erTidx02.Leave
        If txt1erTidx02.Text <> "" Then
            ParteChorizoDX1erT(9) = txt1erTidx02.Text
        Else
            ParteChorizoDX1erT(9) = "@"
        End If
        ActualizaChorizoDX1erT()
    End Sub

    'parte (10) del chorizo DX del 1er t. 3ra linea de IDx
    Private Sub txt1erTidx03_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txt1erTidx03.Leave
        If txt1erTidx03.Text <> "" Then
            ParteChorizoDX1erT(10) = txt1erTidx03.Text
        Else
            ParteChorizoDX1erT(10) = "@"
        End If
        ActualizaChorizoDX1erT()
    End Sub

    'Comentarios1erT adicionales Keypreses
    Private Sub txtComentarios1erT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt1erTComentarios01.KeyPress, txt1erTcomentarios02.KeyPress, txt1erTcomentarios03.KeyPress, txt1erTcomentarios04.KeyPress, txt1erTcomentarios05.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) _
                Or Char.IsSeparator(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub

    'IDx 1erT adicionales keypresess
    Private Sub txtIDx1erT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt1erTidx01.KeyPress, txt1erTidx02.KeyPress, txt1erTidx03.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) _
                Or Char.IsSeparator(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub


    '=====================================
    '= 2 y 3 er trimestre                =
    '=====================================
    'inicial solo la edad es un txt box
    Private Sub txtEdaden2y3ertrimestre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtEdad2y3erT.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub

    'edad de la pte leave
    Private Sub txtEdadenel2y3ertrimestre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtEdad2y3erT.Leave
        R.c08Edad = txtEdad2y3erT.Text
        ActualizaImagenParaImprimir()
    End Sub
    '
    '-------------------------------------
    '= Parte obstetrica                  =
    '-------------------------------------
    Private Sub radEmbarazo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radEmbarazo01.CheckedChanged, radEmbarazo02.CheckedChanged
        If radEmbarazo01.Checked = True Then
            R.e39Embarazo = "1"
        ElseIf radEmbarazo02.Checked = True Then
            R.e39Embarazo = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub
    Private Sub radFeto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radFeto01.CheckedChanged, radFeto02.CheckedChanged
        If radFeto01.Checked = True Then
            R.e40Feto = "1"
        ElseIf radFeto02.Checked = True Then
            R.e40Feto = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radPresentacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radPresentacion1.CheckedChanged, radPresentacion2.CheckedChanged, radpresentacion3.CheckedChanged
        If radPresentacion1.Checked = True Then
            R.e01Presentacion = "1"
        ElseIf radPresentacion2.Checked = True Then
            R.e01Presentacion = "2"
        ElseIf radpresentacion3.Checked = True Then
            R.e01Presentacion = "3"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radSituacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radSituacion1.CheckedChanged, radSituacion2.CheckedChanged, radSituacion3.CheckedChanged
        If radSituacion1.Checked = True Then
            R.e02Situacion = "1"
        ElseIf radSituacion2.Checked = True Then
            R.e02Situacion = "2"
        ElseIf radSituacion3.Checked = True Then
            R.e02Situacion = "3"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radPosicion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radPosicion1.CheckedChanged, radPosicion2.CheckedChanged, radPosicion3.CheckedChanged, radPosicion4.CheckedChanged, radPosicion5.CheckedChanged, radPosicion6.CheckedChanged, radPosicion7.CheckedChanged, radPosicion8.CheckedChanged
        If radPosicion1.Checked = True Then
            R.e03Posicion = "1"
        ElseIf radPosicion2.Checked = True Then
            R.e03Posicion = "2"
        ElseIf radPosicion3.Checked = True Then
            R.e03Posicion = "3"
        ElseIf radPosicion4.Checked = True Then
            R.e03Posicion = "4"
        ElseIf radPosicion5.Checked = True Then
            R.e03Posicion = "5"
        ElseIf radPosicion6.Checked = True Then
            R.e03Posicion = "6"
        ElseIf radPosicion7.Checked = True Then
            R.e03Posicion = "7"
        ElseIf radPosicion8.Checked = True Then
            R.e03Posicion = "8"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    '-------------------------------------
    '= Parte anatomica                   =
    '-------------------------------------
    Private Sub radCabeza_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radCabeza1.CheckedChanged, radCabeza2.CheckedChanged
        If radCabeza1.Checked = True Then
            R.e04Cabeza = "1"
        ElseIf radCabeza2.Checked = True Then
            R.e04Cabeza = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radVentriculos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radVentriculo1.CheckedChanged, radVentriculo2.CheckedChanged
        If radVentriculo1.Checked = True Then
            R.e05Ventriculos = "1"
        ElseIf radVentriculo2.Checked = True Then
            R.e05Ventriculos = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radRostro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radRostro1.CheckedChanged, radRostro2.CheckedChanged
        If radRostro1.Checked = True Then
            R.e42Rostro = "1"
        ElseIf radRostro2.Checked = True Then
            R.e42Rostro = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radColumna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radColumna1.CheckedChanged, radColumna2.CheckedChanged
        If radColumna1.Checked = True Then
            R.e06Columna = "1"
        ElseIf radColumna2.Checked = True Then
            R.e06Columna = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radExtremidades_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
       Handles radExtremidades1.CheckedChanged, radExtremidades2.CheckedChanged
        If radExtremidades1.Checked = True Then
            R.e11Extremidades = "1"
        ElseIf radExtremidades2.Checked = True Then
            R.e11Extremidades = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radTorax_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radTorax1.CheckedChanged, radTorax2.CheckedChanged
        If radTorax1.Checked = True Then
            R.e07Torax = "1"
        ElseIf radTorax2.Checked = True Then
            R.e07Torax = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radCorazon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radCorazon1.CheckedChanged, radCorazon2.CheckedChanged
        If radCorazon1.Checked = True Then
            R.e08Corazon = "1"
        ElseIf radCorazon2.Checked = True Then
            R.e08Corazon = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radAbdomen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbdomen1.CheckedChanged, radAbdomen2.CheckedChanged
        If radAbdomen1.Checked = True Then
            R.e09Abdomen = "1"
        ElseIf radAbdomen2.Checked = True Then
            R.e09Abdomen = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radRiñones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radRiñones1.CheckedChanged, radRiñones2.CheckedChanged
        If radRiñones1.Checked = True Then
            R.e10Riñones = "1"
        ElseIf radRiñones2.Checked = True Then
            R.e10Riñones = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub radSexo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radSexo1.CheckedChanged, radSexo2.CheckedChanged
        If radSexo1.Checked = True Then
            R.e43Sexo = "1"
        ElseIf radSexo2.Checked = True Then
            R.e43Sexo = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    '2 y 3er trimestre BIOMETRICAS
    'Todos los keypress
    Private Sub txtBiometricasTodas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtDBP.KeyPress, txtDOF.KeyPress, txtCC.KeyPress, txtTCer.KeyPress, txtAtrio.KeyPress, txtIOE.KeyPress, txtIOI.KeyPress, txtPN.KeyPress, txtAPC.KeyPress, txtAPT.KeyPress, txtAorta.KeyPress, txtTransAbdomen.KeyPress, txtCA.KeyPress, txtFemur.KeyPress, txtTibia.KeyPress, txtHumero.KeyPress, txtUlna.KeyPress, txtSacro.KeyPress, txtNODF.KeyPress, txtNOPT.KeyPress, txtNOPH.KeyPress, txtBPF.KeyPress, txtPeso.KeyPress, txtTalla.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub

    'r.e13 = txtDBP
    Private Sub txtDBP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDBP.Leave
        R.e13DiametroBiParietal = txtDBP.Text

        CalculaBPF() 'en este pro se actualiza la estruc 
        CalculaPesoEstimado()
        CalculaEGconDBP()
        CalculaEGxECO()
        ActualizaImagenParaImprimir()
    End Sub

    'r.e14 = txtDOF
    Private Sub txtDOF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDOF.Leave
        R.e14DiametroOccipitoFrontal = txtDOF.Text
        ActualizaImagenParaImprimir()
    End Sub

    'este sub se usa en todas las txt dependiente de las biometricas 41
    Private Sub ActualizaChorizoBiometrico()
        ChorizoBiometrico = "" 'inicializa el chorizo
        For Me.Cont = 0 To 14 'ahora codifica cada parte una a una incluida la modificasda claro
            ChorizoBiometrico += ParteDelChorizo(Cont) & "|"
        Next
        ChorizoBiometrico += ParteDelChorizo(15)    'la ultima pa no ponerle el palito al final
        'actualiza la estructura pa dejar la vaina ya transformada pues
        R.e41BiometricosAdicionales = ChorizoBiometrico
        'ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtCC esta es la parte 00 de 15 del chorizo de biometricas adicionales
    Private Sub txtCC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCC.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(0) = txtCC.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        CalculaPesoEstimado()
        CalculaEGconCC()
        CalculaEGxECO()
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtTCer esta es la parte 01 de 15 del chorizo de biometricas adicionales
    Private Sub txtTCer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTCer.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(1) = txtTCer.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtAtrio esta es la parte 02 de 15 del chorizo de biometricas adicionales
    Private Sub txtAtrio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAtrio.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(2) = txtAtrio.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtIOE esta es la parte 03 de 15 del chorizo de biometricas adicionales
    Private Sub txtIOE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIOE.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(3) = txtIOE.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtIOI esta es la parte 04 de 15 del chorizo de biometricas adicionales
    Private Sub txtIOI_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIOI.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(4) = txtIOI.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtPN esta es la parte 05 de 15 del chorizo de biometricas adicionales
    Private Sub txtPN_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPN.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(5) = txtPN.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtCAbd esta es la parte 06 de 15 del chorizo de biometricas adicionales
    Private Sub txtCA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCA.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(6) = txtCA.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        CalculaPesoEstimado()
        CalculaEGconCA()
        CalculaEGxECO()
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtTibia esta es la parte 07 de 15 del chorizo de biometricas adicionales
    Private Sub txtTibia_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTibia.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(7) = txtTibia.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ''calcula EG
        'CalculaEGconTibia()
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtHumero esta es la parte 08 de 15 del chorizo de biometricas adicionales
    Private Sub txtHumero_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHumero.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(8) = txtHumero.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ''calcula EG
        'CalculaEGconHumero()
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtUlna esta es la parte 09 de 15 del chorizo de biometricas adicionales
    Private Sub txtUlna_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUlna.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(9) = txtUlna.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtNODFemur esta es la parte 10 de 15 del chorizo de biometricas adicionales
    Private Sub txtNODF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNODF.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(10) = txtNODF.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtNOPTibia esta es la parte 11 de 15 del chorizo de biometricas adicionales
    Private Sub txtNOPT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNOPT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(11) = txtNOPT.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtNOPHumero esta es la parte 12 de 15 del chorizo de biometricas adicionales
    Private Sub txtNOPH_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNOPH.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizo(12) = txtNOPH.Text
        ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtBPF esta es la parte 13 de 15 del chorizo de biometricas adicionales
    Private Sub txtBPF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBPF.Leave
        'esta casilla de texto es de read only

        'actualiza la parte del chorizo modificada
        'ParteDelChorizo(13) = txtBPF.Text
        'ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        'ActualizaImagenParaImprimir()
    End Sub

    'r.e41 = txtPeso esta es la parte 14 de 15 del chorizo de biometricas adicionales
    Private Sub txtPeso_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPeso.Leave
        'esta casilla de texto es de read only

        'actualiza la parte del chorizo modificada
        ''ParteDelChorizo(14) = txtPeso.Text
        'ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
    End Sub

    'r.e41 = txtTalla esta es la parte 15 de 15 del chorizo de biometricas adicionales
    Private Sub txtTalla_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTalla.Leave
        'esta casilla de texto es de read only

        'actualiza la parte del chorizo modificada
        'ParteDelChorizo(15) = txtTalla.Text
        'ActualizaChorizoBiometrico() 'esto actualiza el chorizo y a e41 tambien en la estructura
    End Sub

    'r.e15 = txtAPT
    Private Sub txtAPT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAPT.Leave
        R.e15DiametroAnteroPosteriorTorax = txtAPT.Text
        ActualizaImagenParaImprimir()
    End Sub

    'r.e16 = txtAPC
    Private Sub txtAPC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAPC.Leave
        R.e16DiametroAnteroPosteriorCorazon = txtAPC.Text
        ActualizaImagenParaImprimir()
    End Sub

    'r.e17a = txtAPA OJO la Anteroposterior del Abdome ya no la usare mas....

    'r.e17b = txttransAbd 
    Private Sub txtTransAbdomen_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTransAbdomen.Leave
        R.e17bDiametroTransversoAbdomen = txtTransAbdomen.Text
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub txtAorta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAorta.Leave
        R.e18Aorta = txtAorta.Text
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub txtSacro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSacro.Leave
        R.e20LongitudSacro = txtSacro.Text
        ActualizaImagenParaImprimir()
    End Sub

    Private Sub txtFemur_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFemur.Leave
        R.e21LongitudFemur = txtFemur.Text

        CalculaPesoEstimado()
        'trata de calcular el BPF si estan los datos necesarios
        CalculaBPF()
        'calcula la talla
        CalculaTallaFetal()
        'calcula EG
        CalculaEGconFemur()
        CalculaEGxECO()

        ActualizaImagenParaImprimir()

    End Sub

    'Funcionales 2 y 3er trimestre
    '=========================================

    'r.e22 actitud
    Private Sub radActitud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radActitud1.CheckedChanged, radActitud2.CheckedChanged
        If radActitud1.Checked = True Then
            R.e22Actitud = "1"
        ElseIf radActitud2.Checked = True Then
            R.e22Actitud = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()

    End Sub
    'r.e23 tono
    Private Sub radTono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radTono1.CheckedChanged, radTono2.CheckedChanged
        If radTono1.Checked = True Then
            R.e23Tono = "1"
        ElseIf radTono2.Checked = True Then
            R.e23Tono = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()

    End Sub
    'r.e24 movimientos fetales
    Private Sub radMovimientosFetales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radMovimientosFetales1.CheckedChanged, radMovimientosFetales2.CheckedChanged
        If radMovimientosFetales1.Checked = True Then
            R.e24MovimientosFetales = "1"
        ElseIf radMovimientosFetales2.Checked = True Then
            R.e24MovimientosFetales = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub
    'r.e25 actividad cardiaca
    Private Sub radActividadCardiaca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radActividadCardiaca2.CheckedChanged, radActividadCardiaca1.CheckedChanged
        If radActividadCardiaca1.Checked = True Then
            R.e25ActividadCardiaca = "1"
        ElseIf radActividadCardiaca2.Checked = True Then
            R.e25ActividadCardiaca = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub
    'r.e26 movimientos respiratorios
    Private Sub radMovimientosRespiratorios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radMovimientosRespiratorios1.CheckedChanged, radMovimientosRespiratorios2.CheckedChanged
        If radMovimientosRespiratorios1.Checked = True Then
            R.e26MovimientosRespiratorios = "1"
        ElseIf radMovimientosRespiratorios2.Checked = True Then
            R.e26MovimientosRespiratorios = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub
    'r.e27 rel aorto cava
    Private Sub radAortoCava_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAortoCava1.CheckedChanged, radAortoCava2.CheckedChanged
        If radAortoCava1.Checked = True Then
            R.e27RelacionAortoCava = "1"
        ElseIf radAortoCava2.Checked = True Then
            R.e27RelacionAortoCava = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub
    'r.e28 camara gastrica
    Private Sub radCamaraGastrica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radCamaraGastrica1.CheckedChanged, radCamaraGastrica2.CheckedChanged
        If radCamaraGastrica1.Checked = True Then
            R.e28CamaraGastrica = "1"
        ElseIf radCamaraGastrica2.Checked = True Then
            R.e28CamaraGastrica = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub
    'r.e29 intestino
    Private Sub radIntestino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radIntestino1.CheckedChanged, radIntestino2.CheckedChanged, radIntestino3.CheckedChanged, radIntestino4.CheckedChanged, radIntestino5.CheckedChanged

        If radIntestino1.Checked = True Then
            R.e29Intestino = "1"
        ElseIf radIntestino2.Checked = True Then
            R.e29Intestino = "2"
        ElseIf radIntestino3.Checked = True Then
            R.e29Intestino = "3"
        ElseIf radIntestino4.Checked = True Then
            R.e29Intestino = "4"
        ElseIf radIntestino5.Checked = True Then
            R.e29Intestino = "5"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub
    'r.e30 vejiga
    Private Sub radVejiga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radVejiga1.CheckedChanged, radVejiga2.CheckedChanged
        If radVejiga1.Checked = True Then
            R.e30Vejiga = "1"
        ElseIf radVejiga2.Checked = True Then
            R.e30Vejiga = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    ' Placentarias del 2 y 3 er trimestre

    'r.e32 placenta localizacion
    Private Sub radPlacenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radPlacenta1.CheckedChanged, radPlacenta2.CheckedChanged, radPlacenta3.CheckedChanged, radplacenta4.CheckedChanged, radPlacenta5.CheckedChanged, radPlacenta6.CheckedChanged, radPlacenta7.CheckedChanged, radPlacenta8.CheckedChanged
        If radPlacenta1.Checked = True Then
            R.e32LocalizacionPlacenta = "1"
        ElseIf radPlacenta2.Checked = True Then
            R.e32LocalizacionPlacenta = "2"
        ElseIf radPlacenta3.Checked = True Then
            R.e32LocalizacionPlacenta = "3"
        ElseIf radplacenta4.Checked = True Then
            R.e32LocalizacionPlacenta = "4"
        ElseIf radPlacenta5.Checked = True Then
            R.e32LocalizacionPlacenta = "5"
        ElseIf radPlacenta6.Checked = True Then
            R.e32LocalizacionPlacenta = "6"
        ElseIf radPlacenta7.Checked = True Then
            R.e32LocalizacionPlacenta = "7"
        ElseIf radPlacenta8.Checked = True Then
            R.e32LocalizacionPlacenta = "8"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    'r.e33 placenta grosor
    Private Sub txtPlacentagrosor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtPlacentaGrosor.Leave
        R.e33GrosorPlacenta = txtPlacentaGrosor.Text
        ActualizaImagenParaImprimir()
    End Sub
    'r.e34 placenta grado
    Private Sub radPlacentaGrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radPlacentaGrado1.CheckedChanged, radPlacentaGrado2.CheckedChanged, radPlacentaGrado3.CheckedChanged, radPlacentaGrado4.CheckedChanged, radPlacentaGrado5.CheckedChanged, radPlacentaGrado6.CheckedChanged, radPlacentaGrado7.CheckedChanged

        If radPlacentaGrado1.Checked = True Then
            R.e34GradoPlacenta = "1"
        ElseIf radPlacentaGrado2.Checked = True Then
            R.e34GradoPlacenta = "2"
        ElseIf radPlacentaGrado3.Checked = True Then
            R.e34GradoPlacenta = "3"
        ElseIf radPlacentaGrado4.Checked = True Then
            R.e34GradoPlacenta = "4"
        ElseIf radPlacentaGrado5.Checked = True Then
            R.e34GradoPlacenta = "5"
        ElseIf radPlacentaGrado6.Checked = True Then
            R.e34GradoPlacenta = "6"
        ElseIf radPlacentaGrado7.Checked = True Then
            R.e34GradoPlacenta = "7"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    'keypress de placenta ila keypress
    Private Sub txtPlacentariasGrosoreILA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtPlacentaGrosor.KeyPress, txtILA.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub
    'r.e35 liquido amnoiotico
    Private Sub radLiquidoAmniotico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radLiquidoAmniotico1.CheckedChanged, radLiquidoAmniotico2.CheckedChanged
        If radLiquidoAmniotico1.Checked = True Then
            R.e35LiquidoAmniotico = "1"
        ElseIf radLiquidoAmniotico2.Checked = True Then
            R.e35LiquidoAmniotico = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()
    End Sub

    'r.e36 ILA
    Private Sub txtILA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtILA.Leave
        R.e36ILA = txtILA.Text
        ActualizaImagenParaImprimir()
    End Sub

    'r.e37 cordon umbilical
    Private Sub radCordon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radCordon1.CheckedChanged, radCordon2.CheckedChanged
        If radCordon1.Checked = True Then
            R.e37CordonUmbilical = "1"
        ElseIf radCordon2.Checked = True Then
            R.e37CordonUmbilical = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
        ActualizaImagenParaImprimir()

    End Sub

    'observaciones mas bien notas del 2 y 3er trimestre
    'ojo aqui agarro todas las notas de 2 y 3 er trimestre
    Private Sub txtObservacionesTodas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtNotas01del2y3erT.KeyPress, txtNotas02del2y3erT.KeyPress, txtNotas03del2y3erT.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) _
                Or Char.IsSeparator(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub

    'parejas de observaciones 1 y 2
    'notas 01 eran las anatomicas
    Private Sub txtNotas01del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNotas01del2y3erT.Leave
        R.e12Notas01del2y3erT = txtNotas01del2y3erT.Text
        ActualizaImagenParaImprimir()
    End Sub
    'notas 02 eran las funcionales
    Private Sub txtNotas02del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNotas02del2y3erT.Leave
        R.e31Notas02del2y3erT = txtNotas02del2y3erT.Text
        ActualizaImagenParaImprimir()
    End Sub
    'notas 03 eran las placentarias
    Private Sub txtNotas03del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNotas03del2y3erT.Leave
        R.e38Notas03del2y3erT = txtNotas03del2y3erT.Text
        ActualizaImagenParaImprimir()
    End Sub


    '      IDxs 1,5,6,7,8 letras numeros espacios y punto (en este caso del 2y3er trimestre
    '      Sugerencia 1 2 y 3
    Private Sub txtIDx0105060708del2y3erT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtIdx01del2y3erT.KeyPress, txtIdx05del2y3erT.KeyPress, txtIDx06del2y3erT.KeyPress, txtIDx07del2y3erT.KeyPress, txtIDx08del2y3erT.KeyPress, txtSug02del2y3erT.KeyPress, txtSug03del2y3erT.KeyPress, txtSug01del2y3erT.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) _
                Or Char.IsSeparator(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub

    '      IDxs 02 03 04 numeros solamente (en este caso del 2y3er trimestre
    Private Sub txtIDx020304del2y3erT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtIdx02del2y3erT.KeyPress, txtIdx03del2y3erT.KeyPress, txtIdx04del2y3erT.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub

    'este sub se usa en todas las txt dependiente de las diagnosticas 44
    Private Sub ActualizaChorizoDiagnostico()
        ChorizoDiagnostico = "" 'inicializa el chorizo
        For Me.Cont = 0 To 9 'ahora codifica cada parte una a una incluida la modificasda claro
            ChorizoDiagnostico += ParteDelChorizoDX(Cont) & "|"
        Next
        ChorizoDiagnostico += ParteDelChorizoDX(10)    'la ultima pa no ponerle el palito al final
        'actualiza la estructura pa dejar la vaina ya transformada pues
        R.e44ChorizoDiagnostico = ChorizoDiagnostico
        'ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 00 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtIDx01del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtIdx01del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(0) = txtIdx01del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 01 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtIDx02del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtIdx02del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(1) = txtIdx02del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 02 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtIDx03del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtIdx03del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(2) = txtIdx03del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 03 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtIDx04del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtIdx04del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(3) = txtIdx04del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 04 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtIDx05del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtIdx05del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(4) = txtIdx05del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 05 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtIDx06del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtIDx06del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(5) = txtIDx06del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 06 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtIDx07del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtIDx07del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(6) = txtIDx07del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 07 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtIDx08del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtIDx08del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(7) = txtIDx08del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 08 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtSug01del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtSug01del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(8) = txtSug01del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 09 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtSug02del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtSug02del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(9) = txtSug02del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    'r.e44 = esta es la parte 10 de 10 del chorizo de diagnosticos adicionales
    Private Sub txtSug03del2y3erT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtSug03del2y3erT.Leave
        'actualiza la parte del chorizo modificada
        ParteDelChorizoDX(10) = txtSug03del2y3erT.Text
        ActualizaChorizoDiagnostico() 'esto actualiza el chorizo y a e41 tambien en la estructura
        ActualizaImagenParaImprimir()
    End Sub

    '===================================
    'parte ginecologica

    '------------------------------------
    'todos los keypress
    Private Sub txtGinecologicos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtUteroLongitudinal.KeyPress, txtUteroAnteroPosterior.KeyPress, txtUteroTransverso.KeyPress, txtUteroEndometrio.KeyPress, txtOvarioDerechoLongitudinal.KeyPress, txtOvarioDerechoAnteroPosterior.KeyPress, txtOvarioDerechoTransverso.KeyPress, txtOvarioIzquierdoLongitudinal.KeyPress, txtOvarioIzquierdoAnteroPosterior.KeyPress, txtOvarioIzquierdoTransverso.KeyPress, txtOvarioDerechoFoliculo1.KeyPress, txtOvarioDerechoFoliculo2.KeyPress, txtOvarioDerechoFoliculo3.KeyPress, txtOvarioDerechoFoliculo4.KeyPress, txtOvarioIzquierdoFoliculo1.KeyPress, txtOvarioIzquierdoFoliculo2.KeyPress, txtOvarioIzquierdoFoliculo3.KeyPress, txtOvarioIzquierdoFoliculo4.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c)) Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub

    'e.f01 menopausia se calcula cuando se selecciona el estudio ginecologico

    'e.f02 tipo de estudio
    Private Sub radTipoEstudio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If radTipoEstudioGinecologico1.Checked = True Then
            R.f02EstudioPorVia = "1"
        ElseIf radTipoEstudioGinecologico2.Checked = True Then
            R.f02EstudioPorVia = "2"
        End If
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If

        ActualizaImagenParaImprimir()
    End Sub

    'e.f03 utero longitudinal
    Private Sub txtUteroLongitudinal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtUteroLongitudinal.Leave
        R.f03UteroLongitudinal = txtUteroLongitudinal.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f04 utero anteroposterior
    Private Sub txtUteroAP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtUteroAnteroPosterior.Leave
        R.f04UteroAnteroposterior = txtUteroAnteroPosterior.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f05 utero transverso
    Private Sub txtUteroT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtUteroTransverso.Leave
        R.f05UteroTransverso = txtUteroTransverso.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f06 ovarioderecho long
    Private Sub txtOvarioDerLong_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioDerechoLongitudinal.Leave
        R.f06OvarioDerechoLongitudinal = txtOvarioDerechoLongitudinal.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f07 ovariotransverso
    Private Sub txtOvarioDerTrans_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioDerechoTransverso.Leave
        R.f07OvarioDerechoTransverso = txtOvarioDerechoTransverso.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f08 ovarioDer AP
    Private Sub txtOvarioDerAP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioDerechoAnteroPosterior.Leave
        R.f08OvarioDerechoAnteroPosterior = txtOvarioDerechoAnteroPosterior.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f09 ovarioIzq long
    Private Sub txtOvarioIzqLong_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioIzquierdoLongitudinal.Leave
        R.f09OvarioIzquierdoLongitudinal = txtOvarioIzquierdoLongitudinal.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f10 ovarioIzq transverso
    Private Sub txtOvarioIzqTrans_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioIzquierdoTransverso.Leave
        R.f10OvarioIzquierdoTransverso = txtOvarioIzquierdoTransverso.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f11 ovarioIzq AP
    Private Sub txtOvarioIzqAP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioIzquierdoAnteroPosterior.Leave
        R.f11OvarioIzquierdoAnteroPosterior = txtOvarioIzquierdoAnteroPosterior.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f12 FolDerecho1
    Private Sub txtFolDerecho1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioDerechoFoliculo1.Leave
        R.f12FoliculoDerecho01 = txtOvarioDerechoFoliculo1.Text
        ActualizaImagenParaImprimir()
    End Sub
    'e.f13 FolDerecho2
    Private Sub txtFolDerecho2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioDerechoFoliculo2.Leave
        R.f13FoliculoDerecho02 = txtOvarioDerechoFoliculo2.Text
        ActualizaImagenParaImprimir()
    End Sub
    'e.f14 FolDerecho3
    Private Sub txtFolDerecho3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioDerechoFoliculo3.Leave
        R.f14FoliculoDerecho03 = txtOvarioDerechoFoliculo3.Text
        ActualizaImagenParaImprimir()
    End Sub
    'e.f15 FolDerecho4
    Private Sub txtFolDerecho4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioDerechoFoliculo4.Leave
        R.f15FoliculoDerecho04 = txtOvarioDerechoFoliculo4.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f16 Folizquierdo1
    Private Sub txtFolizquierdo1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioIzquierdoFoliculo1.Leave
        R.f16FoliculoIzquierdo01 = txtOvarioIzquierdoFoliculo1.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f17 Folizquierdo2
    Private Sub txtFolizquierdo2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioIzquierdoFoliculo2.Leave
        R.f17FoliculoIzquierdo02 = txtOvarioIzquierdoFoliculo2.Text
        ActualizaImagenParaImprimir()
    End Sub
    'e.f18 Folizquierdo3
    Private Sub txtFolizquierdo3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioIzquierdoFoliculo3.Leave
        R.f18FoliculoIzquierdo03 = txtOvarioIzquierdoFoliculo3.Text
        ActualizaImagenParaImprimir()
    End Sub
    'e.f19 Folizquierdo4
    Private Sub txtFolizquierdo4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtOvarioIzquierdoFoliculo4.Leave
        R.f19FoliculoIzquierdo04 = txtOvarioIzquierdoFoliculo4.Text
        ActualizaImagenParaImprimir()
    End Sub

    'e.f20 utero endometrio
    Private Sub txtUteroEndometrio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
           Handles txtUteroEndometrio.Leave
        R.f20EndometrioGrosor = txtUteroEndometrio.Text
        ActualizaImagenParaImprimir()
    End Sub

    'este sub se usa en todas las partes dependientes del chorizo Gin adicional
    Private Sub ActualizaChorizoGIN()
        ChorizoGIN = "" 'inicializa el chorizo
        For Me.Cont = 0 To 34 'ahora codifica cada parte una a una incluida la modificasda claro
            ChorizoGIN += ParteChorizoGIN(Cont) & "|"
        Next
        ChorizoGIN += ParteChorizoGIN(35)    'la ultima pa no ponerle el palito al final
        'actualiza la estructura pa dejar la vaina ya transformada pues
        R.f25AdicionalesGin = ChorizoGIN
        ActualizaImagenParaImprimir()
    End Sub

    'parte (0) del chorizo Gin Vejiga volumen
    Private Sub radGINvejigaVolumen_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinVejigaVolumen1.CheckedChanged, RadGinVejigaVolumen2.CheckedChanged, RadGinVejigaVolumen3.CheckedChanged

        If RadGinVejigaVolumen1.Checked = True Then
            ParteChorizoGIN(0) = "1"
        ElseIf RadGinVejigaVolumen2.Checked = True Then
            ParteChorizoGIN(0) = "2"
        ElseIf RadGinVejigaVolumen3.Checked = True Then
            ParteChorizoGIN(0) = "3"
        Else
            ParteChorizoGIN(0) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (1) del chorizo Gin Vejiga Adecuacion
    Private Sub radGINvejigaAdecuacion_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinVejigaAdecuada1.CheckedChanged, RadGinVejigaAdecuada2.CheckedChanged

        If RadGinVejigaAdecuada1.Checked = True Then
            ParteChorizoGIN(1) = "1"
        ElseIf RadGinVejigaAdecuada2.Checked = True Then
            ParteChorizoGIN(1) = "2"
        Else
            ParteChorizoGIN(1) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (2) del chorizo Gin Vejiga Paredes
    Private Sub radGINvejigaParedes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinVejigaParedes1.CheckedChanged, RadGinVejigaParedes2.CheckedChanged

        If RadGinVejigaParedes1.Checked = True Then
            ParteChorizoGIN(2) = "1"
        ElseIf RadGinVejigaParedes2.Checked = True Then
            ParteChorizoGIN(2) = "2"
        Else
            ParteChorizoGIN(2) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub


    'parte (3) y (4) deL chorizo Gin Vejiga oBServaciones
    Private Sub txtGinVejigaObs_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtGinVejigaObservaciones1.Leave, txtGinVejigaObservaciones2.Leave
        'actualiza la parte del chorizo modificada
        ParteChorizoGIN(3) = txtGinVejigaObservaciones1.Text
        ParteChorizoGIN(4) = txtGinVejigaObservaciones2.Text
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (5) del chorizo Gin Utero Posicion
    Private Sub radGINUteroPosicion_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinUteroPosicion1.CheckedChanged, RadGinUteroPosicion2.CheckedChanged, RadGinUteroPosicion3.CheckedChanged

        If RadGinUteroPosicion1.Checked = True Then
            ParteChorizoGIN(5) = "1"
        ElseIf RadGinUteroPosicion2.Checked = True Then
            ParteChorizoGIN(5) = "2"
        ElseIf RadGinUteroPosicion3.Checked = True Then
            ParteChorizoGIN(5) = "3"
        Else
            ParteChorizoGIN(5) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (6) del chorizo Gin Utero Inclinacion
    Private Sub radGINUteroInclinacion_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinUteroInclinacion1.CheckedChanged, RadGinUteroInclinacion2.CheckedChanged, RadGinUteroInclinacion3.CheckedChanged

        If RadGinUteroInclinacion1.Checked = True Then
            ParteChorizoGIN(6) = "1"
        ElseIf RadGinUteroInclinacion2.Checked = True Then
            ParteChorizoGIN(6) = "2"
        ElseIf RadGinUteroInclinacion3.Checked = True Then
            ParteChorizoGIN(6) = "3"
        Else
            ParteChorizoGIN(6) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (7) del chorizo Gin Utero Ecopatron
    Private Sub radGINUteroecopatron_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinUteroEcopatron1.CheckedChanged, RadGinUteroEcopatron2.CheckedChanged

        If RadGinUteroEcopatron1.Checked = True Then
            ParteChorizoGIN(7) = "1"
        ElseIf RadGinUteroEcopatron2.Checked = True Then
            ParteChorizoGIN(7) = "2"
        Else
            ParteChorizoGIN(7) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (8) del chorizo Gin Utero bordes
    Private Sub radGINUterobordes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinUteroBordes1.CheckedChanged, RadGinUteroBordes2.CheckedChanged

        If RadGinUteroBordes1.Checked = True Then
            ParteChorizoGIN(8) = "1"
        ElseIf RadGinUteroBordes2.Checked = True Then
            ParteChorizoGIN(8) = "2"
        Else
            ParteChorizoGIN(8) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (9) del chorizo Gin Utero endometrio
    Private Sub radGINUteroendometrio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinUteroEndometrio1.CheckedChanged, RadGinUteroEndometrio2.CheckedChanged, RadGinUteroEndometrio3.CheckedChanged, RadGinUteroEndometrio4.CheckedChanged, RadGinUteroEndometrio5.CheckedChanged

        If RadGinUteroEndometrio1.Checked = True Then
            ParteChorizoGIN(9) = "1"
        ElseIf RadGinUteroEndometrio2.Checked = True Then
            ParteChorizoGIN(9) = "2"
        ElseIf RadGinUteroEndometrio3.Checked = True Then
            ParteChorizoGIN(9) = "3"
        ElseIf RadGinUteroEndometrio4.Checked = True Then
            ParteChorizoGIN(9) = "4"
        ElseIf RadGinUteroEndometrio5.Checked = True Then
            ParteChorizoGIN(9) = "5"
        Else
            ParteChorizoGIN(9) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (10) del chorizo Gin Utero cavidad
    Private Sub radGINUterocavidad_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinUteroCavidad1.CheckedChanged, RadGinUteroCavidad2.CheckedChanged, RadGinUteroCavidad3.CheckedChanged, RadGinUteroCavidad4.CheckedChanged, RadGinUteroCavidad5.CheckedChanged

        If RadGinUteroCavidad1.Checked = True Then
            ParteChorizoGIN(10) = "1"
        ElseIf RadGinUteroCavidad2.Checked = True Then
            ParteChorizoGIN(10) = "2"
        ElseIf RadGinUteroCavidad3.Checked = True Then
            ParteChorizoGIN(10) = "3"
        ElseIf RadGinUteroCavidad4.Checked = True Then
            ParteChorizoGIN(10) = "4"
        ElseIf RadGinUteroCavidad5.Checked = True Then
            ParteChorizoGIN(10) = "5"
        Else
            ParteChorizoGIN(10) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (11) y (12) deL chorizo Gin Utero oBServaciones
    Private Sub txtGinUteroObs_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtGinUteroObservaciones1.Leave, txtGinUteroObservaciones2.Leave
        'actualiza la parte del chorizo modificada
        ParteChorizoGIN(11) = txtGinUteroObservaciones1.Text
        ParteChorizoGIN(12) = txtGinUteroObservaciones2.Text
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (13) del chorizo Gin ovarioderecho tamano
    Private Sub radGINOvarioDerechotamano_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinOvarioDerechoTamano1.CheckedChanged, RadGinOvarioDerechoTamano2.CheckedChanged, RadGinOvarioDerechoTamano3.CheckedChanged

        If RadGinOvarioDerechoTamano1.Checked = True Then
            ParteChorizoGIN(13) = "1"
        ElseIf RadGinOvarioDerechoTamano2.Checked = True Then
            ParteChorizoGIN(13) = "2"
        ElseIf RadGinOvarioDerechoTamano3.Checked = True Then
            ParteChorizoGIN(13) = "3"
        Else
            ParteChorizoGIN(13) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (14) del chorizo Gin ovarioizquierdo tamano
    Private Sub radGINOvarioizquierdotamano_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinOvarioIzquierdoTamano1.CheckedChanged, RadGinOvarioIzquierdoTamano2.CheckedChanged, RadGinOvarioIzquierdoTamano3.CheckedChanged

        If RadGinOvarioIzquierdoTamano1.Checked = True Then
            ParteChorizoGIN(14) = "1"
        ElseIf RadGinOvarioIzquierdoTamano2.Checked = True Then
            ParteChorizoGIN(14) = "2"
        ElseIf RadGinOvarioIzquierdoTamano3.Checked = True Then
            ParteChorizoGIN(14) = "3"
        Else
            ParteChorizoGIN(14) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (15) y (16) (17) y (18) deL chorizo Gin Ovario derecho oBServaciones
    Private Sub txtGinOvarioderechoObs_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtGinOvarioDerechoObservaciones1.Leave, txtGinOvarioDerechoObservaciones2.Leave, txtGinOvarioDerechoObservaciones3.Leave, txtGinOvarioDerechoObservaciones4.Leave
        'actualiza la parte del chorizo modificada
        ParteChorizoGIN(15) = txtGinOvarioDerechoObservaciones1.Text
        ParteChorizoGIN(16) = txtGinOvarioDerechoObservaciones2.Text
        ParteChorizoGIN(17) = txtGinOvarioDerechoObservaciones3.Text
        ParteChorizoGIN(18) = txtGinOvarioDerechoObservaciones4.Text
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (19) y (20) (21) y (22) deL chorizo Gin Ovario izquierdo oBServaciones
    Private Sub txtGinOvarioizquierdoObs_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtGinOvarioIzquierdoObservaciones1.Leave, txtGinOvarioIzquierdoObservaciones2.Leave, txtGinOvarioIzquierdoObservaciones3.Leave, txtGinOvarioIzquierdoObservaciones4.Leave
        'actualiza la parte del chorizo modificada
        ParteChorizoGIN(19) = txtGinOvarioIzquierdoObservaciones1.Text
        ParteChorizoGIN(20) = txtGinOvarioIzquierdoObservaciones2.Text
        ParteChorizoGIN(21) = txtGinOvarioIzquierdoObservaciones3.Text
        ParteChorizoGIN(22) = txtGinOvarioIzquierdoObservaciones4.Text
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (23) del chorizo Gin Tropas
    Private Sub radGINtrompas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinTrompas1.CheckedChanged, RadGinTrompas2.CheckedChanged, RadGinTrompas3.CheckedChanged, RadGinTrompas4.CheckedChanged

        If RadGinTrompas1.Checked = True Then
            ParteChorizoGIN(23) = "1"
        ElseIf RadGinTrompas2.Checked = True Then
            ParteChorizoGIN(23) = "2"
        ElseIf RadGinTrompas3.Checked = True Then
            ParteChorizoGIN(23) = "3"
        ElseIf RadGinTrompas4.Checked = True Then
            ParteChorizoGIN(23) = "4"
        Else
            ParteChorizoGIN(23) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (24) del chorizo Gin Douglas
    Private Sub radGINdouglas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles RadGinDouglas1.CheckedChanged, RadGinDouglas2.CheckedChanged

        If RadGinDouglas1.Checked = True Then
            ParteChorizoGIN(24) = "1"
        ElseIf RadGinDouglas2.Checked = True Then
            ParteChorizoGIN(24) = "2"
        Else
            ParteChorizoGIN(24) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (25) y (26) deL chorizo Gin Otros oBServaciones
    Private Sub txtGinotrosObs_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtGinOtrosObservaciones1.Leave, txtGinOtrosObservaciones2.Leave
        'actualiza la parte del chorizo modificada
        ParteChorizoGIN(25) = txtGinOtrosObservaciones1.Text
        ParteChorizoGIN(26) = txtGinOtrosObservaciones2.Text
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (27) y (28) (29) y (30) deL chorizo Gin IDx ginecologica
    Private Sub txtGinidxObs_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtGinIDx1.Leave, txtGinIDx2.Leave, txtGinIDx3.Leave, txtGinIDx4.Leave
        'actualiza la parte del chorizo modificada
        ParteChorizoGIN(27) = txtGinIDx1.Text
        ParteChorizoGIN(28) = txtGinIDx2.Text
        ParteChorizoGIN(29) = txtGinIDx3.Text
        ParteChorizoGIN(30) = txtGinIDx4.Text
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'parte (31) del chorizo Gin fecuencia del trasductor
    Private Sub radGINfrecTrasductor_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles radGINfrec35.CheckedChanged, radGINfrec50.CheckedChanged, radGINfrec75.CheckedChanged

        If radGINfrec35.Checked = True Then
            ParteChorizoGIN(31) = "1"
        ElseIf radGINfrec50.Checked = True Then
            ParteChorizoGIN(31) = "2"
        ElseIf radGINfrec75.Checked = True Then
            ParteChorizoGIN(31) = "3"
        Else
            ParteChorizoGIN(31) = "@"
        End If
        ActualizaChorizoGIN()
        'áctualiza lo de si se produjo un cambio
        If DatosModificados = False Then
            SeRealizoUnCambio()
        End If
    End Sub

    'OJO QUEDAN DE LA PARTE 32 A LA 35 LIBRES PORSIA

    'keypresses de las cosas nuevas

    Private Sub txtObsYIdxGIN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtGinVejigaObservaciones1.KeyPress, txtGinVejigaObservaciones2.KeyPress, txtGinUteroObservaciones1.KeyPress, txtGinUteroObservaciones2.KeyPress, txtGinOvarioDerechoObservaciones1.KeyPress, txtGinOvarioDerechoObservaciones2.KeyPress, txtGinOvarioDerechoObservaciones3.KeyPress, txtGinOvarioDerechoObservaciones4.KeyPress, txtGinOvarioIzquierdoObservaciones1.KeyPress, txtGinOvarioIzquierdoObservaciones2.KeyPress, txtGinOvarioIzquierdoObservaciones3.KeyPress, txtGinOvarioIzquierdoObservaciones4.KeyPress, txtGinOtrosObservaciones1.KeyPress, txtGinOtrosObservaciones2.KeyPress, txtGinIDx1.KeyPress, txtGinIDx2.KeyPress, txtGinIDx3.KeyPress, txtGinIDx4.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) _
                Or Char.IsSeparator(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeRealizoUnCambio()
            End If
        End If
    End Sub


    '0000000000000000000000000000
    'PARTE DE LAS FOTOS

    Private Sub botNuevaImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNuevaImagen.Click
        'Dim Largo As Integer
        Dim FechaFormateada As String
        'Dim T As Integer 'contador

        Dim DLG As New FormEligeFecha()
        Dim DLG2 As New FormNuevaSerie()

        Dim FechaDeLaEcografia As Date
        'Dim FechaExistente As Date
        Dim Indice As Integer
        Dim Elementos As Integer

        Dim NombreNuevo As String
        Dim Descripcion As String
        Dim Linea As String


        Dim Encabezado As String
        Dim Partes(5) As String


        'Dim Reply As MsgBoxResult

        Dim FS As FileStream
        Dim BW As BinaryWriter


        'pregunta por la foto
        OpenFileDialog1.DefaultExt = ".JPG"
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.Filter = "Imagen JPG (*.jpg) |*.jpg"
        'openFileDialog1.Filter = "All Image Formats (*.bmp;*.jpg;*.jpeg;*.gif;*.tif)|" & _
        '               "*.bmp;*.jpg;*.jpeg;*.gif;*.tif|Bitmaps (*.bmp)|*.bmp|" & _
        '               "GIFs (*.gif)|*.gif|JPEGs (*.jpg)|*.jpg;*.jpeg|TIFs (*.tif)|*.tif"
        'OpenFileDialog1.FilterIndex = 1

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'se seleccionó un archivo jpg
            ArchivoFotoOrigen = OpenFileDialog1.FileName

            'crea el directorio de destino si no existe
            If Directory.Exists(Form1.PathImagenes) = False Then
                Directory.CreateDirectory(Form1.PathImagenes)
            End If

            'mensaje para la ventana emergente
            Form1.FechaSeleccionadaMensaje = "Selecciona la fecha en que se tomó la Imagen Ecográfica en el Calendario..."

            'busca la fecha en que se hizo el eco...
            If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
                'se seleccionó una fecha, ahora revisa q no este en el futuro
                FechaDeLaEcografia = Form1.FechaSeleccionada

                If FechaDeLaEcografia > Today Then
                    MsgBox("La fecha de la Ecografia no puede estar en el futuro...", MsgBoxStyle.Information, "Fecha inválida")
                    Exit Sub
                End If

                'ahora pregunta por la descripcion del eco
                Form1.NombreElegidoTitulo = "Descripción de la Ecografía"
                Form1.NombreElegidoMensaje = "Introduce una descripción corta para la Imagen Ecográfica seleccionada"
                If DLG2.ShowDialog = Windows.Forms.DialogResult.OK Then
                    'ok ya tenemos todo, ahora revisa que no exista esa combinación en el list box
                    Descripcion = Form1.NombreElegido

                    'construye la fecha formateada
                    FechaFormateada = FechaDeLaEcografia.ToString("s")
                    FechaFormateada = FechaFormateada.Remove(10, 9) 'le quita el tiempo
                    Partes = Split(FechaFormateada, "-")
                    FechaFormateada = Partes(2) & "-" & Partes(1) & "-" & Partes(0)

                    'construye la linea tal como se mostrara
                    Linea = FechaFormateada & "|" & Descripcion

                    'busca la combinación en el list box
                    Elementos = ListBoxImagenes.Items.Count - 1

                    For Indice = 0 To Elementos
                        Encabezado = ListBoxImagenes.Items(Indice)

                        If Linea = Encabezado Then
                            'hay una coincidencia, no permite la creacion de otra imagen con esa descripcion
                            MsgBox("Ya se incluyó en la Historia una Ecografía con esa descripción este día, por favor elige otra descripción o inicia una numeración manual de las imágenes...", MsgBoxStyle.Information, "La Descripción ya existe")
                            Exit Sub
                        End If
                    Next

                    'construye parte del nombre del archivo destino 
                    NombreNuevo = NombreBaseFotosInicio & "-" & FechaFormateada & "-" & Descripcion & ".jpg"


                    'revisa que no exista ese nombre ya...
                    If File.Exists(NombreNuevo) = True Then
                        MsgBox("Ya existe en esta carpeta un archivo con este nombre, al no salir listado no está en uso y puedes eliminalo manualmente sin problemas, tambien puedes cambiar el nombre nuevo..." & vbCrLf & "Archivo de imagen abandonado: " & NombreNuevo, MsgBoxStyle.Information, "El archivo ya existe")
                        Exit Sub
                    End If

                    'si todo salio bien hasta aqui sigue derecho
                    File.Copy(ArchivoFotoOrigen, NombreNuevo)

                    'pasa los datos a la estructura
                    I.FechaEcografia = FechaFormateada
                    I.Descripcion = Descripcion
                    I.x1 = ""
                    I.x2 = ""
                    I.x3 = ""
                    'ahora añade la I al Array list
                    arraylistImagenes.Add(I)
                    'escribe el array al disco

                    'escribe el array list al disco con los datos nuevos...
                    FS = New FileStream(NombreBaseFotos, FileMode.Create, FileAccess.Write)
                    BW = New BinaryWriter(FS)
                    BW.BaseStream.Seek(0, SeekOrigin.Begin)

                    Dim REnum As IEnumerator
                    REnum = arraylistImagenes.GetEnumerator

                    While REnum.MoveNext
                        I = Nothing
                        I = CType(REnum.Current, strImagenesEcograficas)
                        BW.Write(I.FechaEcografia)
                        BW.Write(I.Descripcion)
                        BW.Write(I.x1)
                        BW.Write(I.x2)
                        BW.Write(I.x3)
                    End While
                    BW.Close()
                    FS.Close()

                    'muestra el list box actualizado
                    MuestraImagenesEcograficas()
                    botAbreImagen.Enabled = False
                    botRenombraImagen.Enabled = False
                    botEliminaImagen.Enabled = False

                    'actualiza el contenido de la historia
                    If Form1.ExistenImagenesEcograficas = False Then
                        ActualizaContenidoHistoriaConLasImagenes()
                    End If

                    'prende las banderas
                    Form1.ExistenImagenesEcograficas = True
                    'actualiza el list box
                    LeeContenidoImagenesEcograficas()
                    'pone los botones en neutro
                    botAbreImagen.Enabled = False
                    botRenombraImagen.Enabled = False
                    botEliminaImagen.Enabled = False

                Else
                    'no se le puso descripcion, no hace nada
                End If
            Else
                'no se seleccionó fecha, no hace nada
            End If
        Else
            'no se selecciono archivo jpg, no hace nada
        End If

    End Sub

    Private Sub ListBoxIMAGENES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxImagenes.SelectedIndexChanged
        botAbreImagen.Enabled = True
        botEliminaImagen.Enabled = True
        botRenombraImagen.Enabled = True
    End Sub

    Private Sub ListBoxIMAGENES_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxImagenes.DoubleClick
        If ListBoxImagenes.SelectedItem <> "" Then
            AbreLaImagenSeleccionada()
        End If
    End Sub

    Private Sub botAbreImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAbreImagen.Click
        AbreLaImagenSeleccionada()
    End Sub

    Private Sub AbreLaImagenSeleccionada()
        Dim DLG As New FormImagenesEcograficas()

        Dim FechaFormateada As String
        Dim Descripcion As String
        Dim Linea As String
        Dim REnum As IEnumerator
        Dim Encabezado As String


        REnum = arraylistImagenes.GetEnumerator
        Encabezado = ListBoxImagenes.SelectedItem

        While REnum.MoveNext
            I = Nothing
            I = CType(REnum.Current, strImagenesEcograficas)
            Linea = I.FechaEcografia & "|" & I.Descripcion

            If Encabezado = Linea Then
                'esta es la que hay que abrir construye el nombre
                FechaFormateada = I.FechaEcografia
                Descripcion = I.Descripcion

                'nombra las variables publicas
                MSGdescripcion = Descripcion
                MSGfechaImagen = FechaFormateada
                NombreImagen = NombreBaseFotosInicio & "-" & FechaFormateada & "-" & Descripcion & ".jpg"

                'muestra la imagen
                If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

                End If

                Exit While
            End If
        End While
    End Sub

    Private Sub botRenombraImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRenombraImagen.Click
        Dim DLG As New FormEligeFecha()
        Dim DLG2 As New FormNuevaSerie()

        Dim FechaFormateada As String
        Dim Descripcion As String
        Dim Linea As String
        Dim REnum As IEnumerator
        Dim Encabezado As String

        Dim FechaNueva As Date
        Dim DescripcionNueva As String = ""
        Dim FechaFormateadaNueva As String = ""
        Dim Partes(5) As String
        Dim LineaNueva As String = ""
        Dim NombreImagenNuevo As String


        Dim Elementos As Integer
        Dim Indice As Integer

        REnum = arraylistImagenes.GetEnumerator
        Encabezado = ListBoxImagenes.SelectedItem

        Dim FS As FileStream
        Dim BW As BinaryWriter


        While REnum.MoveNext
            I = Nothing
            I = CType(REnum.Current, strImagenesEcograficas)
            Linea = I.FechaEcografia & "|" & I.Descripcion

            If Encabezado = Linea Then
                'esta es la que hay que renombrar construye el nombre viejo
                FechaFormateada = I.FechaEcografia
                Descripcion = I.Descripcion

                'crea el nombre viejo
                NombreImagen = NombreBaseFotosInicio & "-" & FechaFormateada & "-" & Descripcion & ".jpg"

                'pide nueva fecha
                'mensaje para la ventana emergente
                Form1.FechaSeleccionadaMensaje = "Selecciona la fecha en que se tomó la Imagen Ecográfica en el Calendario..."

                'busca la fecha en que se hizo el eco...
                If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
                    'se seleccionó una fecha, ahora revisa q no este en el futuro
                    FechaNueva = Form1.FechaSeleccionada

                    If FechaNueva > Today Then
                        MsgBox("La fecha de la Ecografia no puede estar en el futuro...", MsgBoxStyle.Information, "Fecha inválida")
                        Exit Sub
                    End If

                    'ahora pregunta por la descripcion del eco
                    Form1.NombreElegidoTitulo = "Descripción de la Ecografía"
                    Form1.NombreElegidoMensaje = "Introduce una descripción corta para la Imagen Ecográfica seleccionada"
                    If DLG2.ShowDialog = Windows.Forms.DialogResult.OK Then

                        DescripcionNueva = Form1.NombreElegido
                        'construye la fecha formateada
                        FechaFormateadaNueva = FechaNueva.ToString("s")
                        FechaFormateadaNueva = FechaFormateadaNueva.Remove(10, 9) 'le quita el tiempo
                        Partes = Split(FechaFormateadaNueva, "-")
                        FechaFormateadaNueva = Partes(2) & "-" & Partes(1) & "-" & Partes(0)

                        'construye la linea tal como se mostrara
                        LineaNueva = FechaFormateadaNueva & "|" & DescripcionNueva
                    Else
                        'no se selecciono una descripcion sal del sub
                        Exit Sub
                    End If
                Else
                    'no se selecciono fecha sal del sub
                    Exit Sub
                End If
                'sal del primer loop
                Exit While
            End If
        End While

        'ahora revisa que lo nuevo no exista ya en la lista actual...
        'busca la combinación en el list box

        Elementos = ListBoxImagenes.Items.Count - 1

        For Indice = 0 To Elementos
            Encabezado = ListBoxImagenes.Items(Indice)

            If LineaNueva = Encabezado Then
                'hay una coincidencia, no permite la creacion de otra imagen con esa descripcion
                MsgBox("Ya se incluyó en la Historia una Ecografía con esa descripción este día, por favor elige otra descripción o inicia una numeración manual de las imágenes...", MsgBoxStyle.Information, "La Descripción ya existe")
                Exit Sub
            End If
        Next

        'crea el nombre nuevo
        NombreImagenNuevo = NombreBaseFotosInicio & "-" & FechaFormateadaNueva & "-" & DescripcionNueva & ".jpg"

        'revisa porsia existe... quien sabe?
        If File.Exists(NombreImagenNuevo) = True Then
            MsgBox("Ya existe en esta carpeta un archivo con este nombre, eliminalo manualmente o cambia el nombre nuevo...", MsgBoxStyle.Information, "El archivo ya existe")
            Exit Sub
        End If

        'si todo fue bien hace el cambio

        'sustituye la estructura
        REnum = arraylistImagenes.GetEnumerator
        Encabezado = ListBoxImagenes.SelectedItem

        FS = New FileStream(NombreBaseFotos, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        While REnum.MoveNext
            I = Nothing
            I = CType(REnum.Current, strImagenesEcograficas)
            Linea = I.FechaEcografia & "|" & I.Descripcion

            If Encabezado = Linea Then
                'esta es la que hay que renombrar sustituye los valores
                I.FechaEcografia = FechaFormateadaNueva
                I.Descripcion = DescripcionNueva
            End If

            'escribe los datos si o si
            BW.Write(I.FechaEcografia)
            BW.Write(I.Descripcion)
            BW.Write(I.x1)
            BW.Write(I.x2)
            BW.Write(I.x3)

        End While

        BW.Close()
        FS.Close()

        'renombra el archivo
        File.Copy(NombreImagen, NombreImagenNuevo)
        'File.Delete(NombreImagen)

        'prende la bandera de eliminacion de imagenes
        Form1.SeBorraronImagenes = True

        'actualiza la lista con los datos nuevos
        MuestraImagenesEcograficas()
        botAbreImagen.Enabled = False
        botRenombraImagen.Enabled = False
        botEliminaImagen.Enabled = False


    End Sub

    Private Sub botEliminaImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEliminaImagen.Click
        Dim FechaFormateada As String
        Dim Descripcion As String
        Dim Linea As String
        Dim REnum As IEnumerator
        Dim Encabezado As String
        Dim FS As FileStream
        Dim BW As BinaryWriter
        Dim reply As MsgBoxResult
        Dim Contador As Integer

        'Dim NombreNuevo As String

        REnum = arraylistImagenes.GetEnumerator
        Encabezado = ListBoxImagenes.SelectedItem

        FS = New FileStream(NombreBaseFotos, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        Contador = 0
        While REnum.MoveNext
            I = Nothing
            I = CType(REnum.Current, strImagenesEcograficas)
            Linea = I.FechaEcografia & "|" & I.Descripcion

            If Encabezado = Linea Then
                'esta es la que hay que eliminar construye el nombre viejo
                FechaFormateada = I.FechaEcografia
                Descripcion = I.Descripcion

                'crea el nombre para eliminar
                NombreImagen = NombreBaseFotosInicio & "-" & FechaFormateada & "-" & Descripcion & ".jpg"

                reply = MsgBox("Estas seguro de eliminar la imagen ecográfica seleccionada?", MsgBoxStyle.YesNo, "Confirmación")
                If reply = MsgBoxResult.Yes Then
                    'elimina el archivo
                    'File.Delete(NombreImagen)

                    'prende la bandera de eliminacion de imagenes
                    Form1.SeBorraronImagenes = True
                Else
                    'escribe la vaina otra vez al disco 
                    BW.Write(I.FechaEcografia)
                    BW.Write(I.Descripcion)
                    BW.Write(I.x1)
                    BW.Write(I.x2)
                    BW.Write(I.x3)
                    Contador += 1
                End If

            Else
                'este no es el que hay que eliminar, lo escribe tal cual
                BW.Write(I.FechaEcografia)
                BW.Write(I.Descripcion)
                BW.Write(I.x1)
                BW.Write(I.x2)
                BW.Write(I.x3)
                Contador += 1
            End If

        End While

        BW.Close()
        FS.Close()

        If Contador = 0 Then
            'se elimino hasta la ultima imagen se debe actualizar el contenido de la historia borrando la linea datos
            'del control ginecologico
            Dim FSsub As FileStream
            Dim BWsub As BinaryWriter
            Dim LineaDatos As String

            FSsub = New FileStream(NombreHistoria, FileMode.Create, FileAccess.Write)
            BWsub = New BinaryWriter(FSsub)

            'ubica al principio el contenido de la subhistoria
            Dim REnumSub As IEnumerator
            REnumSub = Form1.ElementosHistoria.GetEnumerator
            'pone el archivo al inicio
            BWsub.BaseStream.Seek(0, SeekOrigin.Begin)

            While REnumSub.MoveNext
                LineaDatos = CType(REnumSub.Current, String)
                If LineaDatos = Form1.PSstrNumeroHistoriaSeleccionada & "-Imágenes Ecográficas" Then
                    'si es la linea de las imagenes no la escribe
                Else
                    'escribe las otras lineas
                    BWsub.Write(LineaDatos)
                End If

            End While

            'cierra todo
            FSsub.Close()
            BWsub.Close()
            'borra el archivo del disco ya que esta vacio
            File.Delete(NombreBaseFotos)
            'por ultimo pone la variable de existe control ginecologico a false
            Form1.ExistenImagenesEcograficas = False

        End If

        'si aun existe algun  Informe lo muestra en el listbox
        If Form1.ExistenImagenesEcograficas = True Then
            LeeContenidoImagenesEcograficas()
        Else
            ListBoxImagenes.Items.Clear()
        End If

        'borra el contenido de la ventana pone todo como debe ser al principio
        botAbreImagen.Enabled = False
        botRenombraImagen.Enabled = False
        botEliminaImagen.Enabled = False

    End Sub

    '000000000000000000000000000000000
    'PARTE DE LA IMPRESION

    Private Sub botCreaImpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCreaImpresion.Click

        'mira el tipo de informe que se esta imprimiendo
        If R.c00TipoDeEstudio = "1" Then
            Informe1erTrimestre()
        ElseIf R.c00TipoDeEstudio = "2" Then
            Informe2y3erTrimestre()
        ElseIf R.c00TipoDeEstudio = "3" Then
            InformeGinecologico()
        Else
            'no hace nada, no hay nada seleccionado
        End If

    End Sub

    Private Sub ActualizaImagenParaImprimir()
        'mira el tipo de informe que se esta imprimiendo
        If R.c00TipoDeEstudio = "1" Then
            Informe1erTrimestre()
        ElseIf R.c00TipoDeEstudio = "2" Then
            Informe2y3erTrimestre()
        ElseIf R.c00TipoDeEstudio = "3" Then
            InformeGinecologico()
        Else
            'no hace nada, no hay nada seleccionado
        End If
    End Sub

    Private Sub Informe1erTrimestre()

        'variables para los elementos graficos 
        Dim PenNegro As New Pen(Color.Black, 1)
        Dim PenNegro2 As New Pen(Color.Black, 2)
        Dim PenGris As New Pen(Color.Gray, 1)
        Dim Blanco As New SolidBrush(Color.White)
        Dim Clarito As New SolidBrush(Color.Snow)
        Dim Negro As New SolidBrush(Color.Black)
        Dim Naranja As New SolidBrush(Color.Orange)
        Dim Caqui As New SolidBrush(Color.Khaki)
        Dim Rojo As New SolidBrush(Color.Red)
        Dim Rojito As New SolidBrush(Color.MistyRose)
        Dim Azul As New SolidBrush(Color.Blue)
        Dim Azulito As New SolidBrush(Color.Lavender)
        Dim RectanguloTodo As New Rectangle(0, 0, 690, 925)
        Dim RectanguloGrafico As New Rectangle(50, 25, 400, 250)
        Dim SmallFont As New Font("Microsoft Sans Serif", 7)
        Dim TextoFont As New Font("Microsoft Sans Serif", 8)
        Dim SubtituloFont As New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
        Dim TituloFont As New Font("times new roman", 10, FontStyle.Bold)


        Dim AnchoX As Single
        Dim InicioX, InicioY As Single
        Dim RefX As Integer
        Dim RefY As Integer
        Dim Frase As String
        Dim Fuente As Font = TextoFont
        Dim Valor As Integer = 0 'esta var es para chequear anormalidades en los datos biometricos


        'crea el marco grafico y le asigna el vinculo para dibujar en el
        Fondo = Me.CreateGraphics
        BMP = New Bitmap(PictureBox2.Width, PictureBox2.Height)
        BMP2 = New Bitmap(PictureBox2.Width, PictureBox2.Height)
        PictureBox2.Image = BMP
        Fondo.Clear(PictureBox2.BackColor)
        Gr = Graphics.FromImage(BMP)

        'crea una apariencia de hoja blanca en el fondo
        Gr.FillRectangle(Blanco, RectanguloTodo)

        'emcabezado
        'titulo
        InicioX = 0
        InicioY = 0

        Gr.DrawLine(PenNegro2, InicioX, InicioY + 1, InicioX + 690, InicioY + 1)
        Frase = "ESTUDIO ULTRASONOGRAFICO DEL 1er TRIMESTRE"
        AnchoX = Gr.MeasureString(Frase, TituloFont).Width
        RefX = InicioX + 345 - (AnchoX \ 2)
        Gr.DrawString(Frase, TituloFont, Negro, RefX, InicioY + 5)
        Gr.DrawLine(PenNegro2, InicioX, InicioY + 25, InicioX + 690, InicioY + 25)

        'fecha
        Frase = "Fecha del Estudio: " & txtFechaInicioControl.Text
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        RefX = InicioX + 690 - (AnchoX)
        Gr.DrawString(Frase, TextoFont, Negro, RefX, InicioY + 30)

        'nombre de la pte
        Frase = "Nombre: " & txtNombrePaciente.Text.ToUpper & ". "
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY + 45)
        'edad si se sabe
        If IsNumeric(txtEdad1erT.Text) Then
            Frase = " " & txtEdad1erT.Text & " años. "
            RefX = InicioX + AnchoX  'este es el ancho del nombre para iniciar la edad
            Gr.DrawString(Frase, SubtituloFont, Negro, RefX, InicioY + 45)
            AnchoX = RefX + Gr.MeasureString(Frase, SubtituloFont).Width
        End If
        'paridad si la tiene
        If txtParidad1erT.Text <> "" Then
            Frase = txtParidad1erT.Text & "."
            RefX = InicioX + AnchoX
            Gr.DrawString(Frase, SubtituloFont, Negro, RefX, InicioY + 45)
        End If

        'fur y fpp
        Frase = "Fecha de última regla: " & labFUR1erT.Text & "."
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 60)
        Frase = "Fecha probable de parto x FUR: " & labFPP1erT.Text & "."
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 75)
        Frase = "Edad Gestacional x FUR: " & lab1ertEGxFUR01.Text & "."
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 90)

        'tipo de estudio y frecuencia
        Frase = "Estudio Ecográfico realizado con trasductor "
        If rad1erTestudioTV.Checked = True Then
            Frase += "Trasvaginal "
        ElseIf rad1erTEstudioAbd.Checked = True Then
            Frase += "Transabdominal "
        End If
        Frase += "con una frecuencia de "
        If rad1erTfrec35.Checked = True Then
            Frase += "3.5 MHz."
        ElseIf rad1erTfrec50.Checked = True Then
            Frase += "5.0 MHz."
        ElseIf rad1erTfrec75.Checked = True Then
            Frase += "7.5 MHz."
        End If
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 105)

        'datos anatomicos
        InicioY = 130
        Frase = "DATOS ANATOMICOS."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        '1ra linea: anatomia de la vejiga
        If rad1erTVejiga01.Checked = True Then
            InicioY += 15
            Frase = "VEJIGA: llena, adecuada para el estudio."
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        ElseIf rad1erTVejiga02.Checked = True Then
            InicioY += 15
            Frase = "VEJIGA: vacía, adecuada para el estudio."
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If

        '2da linea....>
        AnchoX = 0
        'Tipo de embarazo simple o gemelar
        If rad1erTtipoEmbarazo01.Checked = True Then
            InicioY += 15
            Frase = "EMBARAZO: Simple"
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf rad1erTtipoEmbarazo02.Checked = True Then
            InicioY += 15
            Frase = "EMBARAZO: Gemelar"
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'localizacion del embarazo
        If rad1erTLocalizacionEmbarazo01.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase = ", intrauterino."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "EMBARAZO: Intrauterino."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            End If
        ElseIf rad1erTlocalizacionEmbarazo02.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase = ", extratrauterino."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "EMBARAZO: Extrauterino."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            End If
        Else
            If AnchoX > 0 Then
                Frase = "."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            End If
        End If

        '3ra linea posible
        AnchoX = 0
        'saco gestacional
        If rad1erTsacoGestacional01.Checked = True Then
            InicioY += 15
            Frase = "SACO GESTACIONAL: Visible"
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf rad1erTsacoGestacional02.Checked = True Then
            InicioY += 15
            Frase = "SACO GESTACIONAL: NO Visible."
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'implantacion
        If Rad1erTImplantacion1.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en la linea
                Frase = ", IMPLANTACION: anterior."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            Else  'no se escribio nada aun en la linea
                InicioY += 15
                Frase = "IMPLANTACION: anterior."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            End If
        ElseIf Rad1erTImplantacion2.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en la linea
                Frase = ", IMPLANTACION: posterior."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            Else  'no se escribio nada aun en la linea
                InicioY += 15
                Frase = "IMPLANTACION: posterior."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            End If
        ElseIf Rad1erTImplantacion3.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en la linea
                Frase = ", IMPLANTACION: fúndica."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            Else  'no se escribio nada aun en la linea
                InicioY += 15
                Frase = "IMPLANTACION: fúndica."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            End If
        ElseIf Rad1erTImplantacion4.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en la linea
                Frase = ", IMPLANTACION: baja."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            Else  'no se escribio nada aun en la linea
                InicioY += 15
                Frase = "IMPLANTACION: baja."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            End If
        Else
            If AnchoX > 0 Then 'se escribio algo en la linea
                Frase = "."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            End If
        End If

        '4ta linea posible
        AnchoX = 0
        'vesicula vitelina
        If rad1erTVitelina01.Checked = True Then
            InicioY += 15
            Frase = "VESICULA VITELINA: Visible."
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf rad1erTVitelina02.Checked = True Then
            InicioY += 15
            Frase = "VESICULA VITELINA: NO Visible."
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'EMBRION
        If Rad1erTEmbrion1.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en la linea
                Frase = " EMBRION: Visible."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            Else 'no se escribio nada en la linea
                InicioY += 15
                Frase = "EMBRION: Visible."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            End If
        ElseIf Rad1erTEmbrion2.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo la linea
                Frase = " EMBRION: NO Visible"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "EMBRION: NO Visible."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            End If
            'no le pongo el else del punto porque ambos tienen su punto ya puesto...
        End If

        '5ta linea posible
        AnchoX = 0
        'movimientos corporales
        If Rad1erTMovimientos1.Checked = True Then
            InicioY += 15
            Frase = "MOVIMIENTOS CORPORALES: Visibles."
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf Rad1erTMovimientos2.Checked = True Then
            InicioY += 15
            Frase = "MOVIMIENTOS CORPORALES: NO Visibles."
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'actividad cardiaca
        If Rad1erTActCardiaca1.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en la linea
                Frase = " ACTIVIDAD CARDIACA: Visible."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            Else 'no se escribio nada en la linea
                InicioY += 15
                Frase = "ACTIVIDAD CARDIACA: Visible."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            End If
        ElseIf Rad1erTActCardiaca2.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo la linea
                Frase = " ACTIVIDAD CARDIACA: NO Visible"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "ACTIVIDAD CARDIACA: NO Visible."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            End If
            'no le pongo el else del punto porque ambos tienen su punto ya puesto...
        End If

        'PARTE DE LOS PERINATOLOGICOS
        Dim SePusoElTituloYa As Boolean = False
        AnchoX = 0
        If rad1erTtranslucencia01.Checked = True Or rad1erTtranslucencia02.Checked = True Then
            'se puso algo en la translucencia
            InicioY += 25
            Frase = "ECOPATRON GENETICO."
            AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
            Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
            Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)
            SePusoElTituloYa = True
            InicioY += 15
            If rad1erTtranslucencia01.Checked = True Then
                Frase = "TRANSLUCENCIA NUCAL: Normal ( < 3mm )."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            ElseIf rad1erTtranslucencia02.Checked = True Then
                Frase = "TRANSLUCENCIA NUCAL: Anormal ( > 3mm )."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            End If

        End If

        AnchoX = 0
        If rad1erThuesosNasales01.Checked = True Or rad1erThuesosNasales02.Checked = True Then
            'se puso algo en los huesos nasales
            If SePusoElTituloYa = False Then 'no se ha puesto el titulo, lo pone
                InicioY += 25
                Frase = "ECOPATRON GENETICO."
                AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
                Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
                Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)
                SePusoElTituloYa = True
            End If
            InicioY += 15
            If rad1erThuesosNasales01.Checked = True Then
                Frase = "HUESOS NASALES: Presentes ( Normal )."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            ElseIf rad1erThuesosNasales02.Checked = True Then
                Frase = "HUESOS NASALES: No visibles ( Anormal )."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            End If

        End If

        AnchoX = 0
        If rad1erTanguloFM01.Checked = True Or rad1erTanguloFM02.Checked = True Then
            'se puso algo en el angulo frontomaxilar
            If SePusoElTituloYa = False Then 'no se ha puesto el titulo, lo pone
                InicioY += 25
                Frase = "ECOPATRON GENETICO."
                AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
                Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
                Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)
                SePusoElTituloYa = True
            End If
            InicioY += 15
            If rad1erTanguloFM01.Checked = True Then
                Frase = "ANGULO FRONTO-MAXILAR: Normal ( < 95 grados )."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            ElseIf rad1erTanguloFM02.Checked = True Then
                Frase = "ANGULO FRONTO-MAXILAR: Anormal ( > 95 grados )."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            End If
        End If

        AnchoX = 0
        If rad1erTductusVenoso01.Checked = True Or rad1erTductusVenoso02.Checked = True Then
            'se puso algo en el ductus venoso
            If SePusoElTituloYa = False Then 'no se ha puesto el titulo, lo pone
                InicioY += 25
                Frase = "ECOPATRON GENETICO."
                AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
                Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
                Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)
                SePusoElTituloYa = True
            End If
            InicioY += 15
            If rad1erTductusVenoso01.Checked = True Then
                Frase = "DUCTUS VENOSO: Normal."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            ElseIf rad1erTductusVenoso02.Checked = True Then
                Frase = "DUCTUS VENOSOS: Anormal."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            End If
        End If

        'DATOS BIOMETRICOS
        InicioY += 25
        Frase = "DATOS BIOMETRICOS."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        'referencias de inicio de la tabla de biometria

        RefX = InicioX
        RefY = InicioY + 20


        'lineas de la tabla horizontales
        Gr.DrawLine(PenNegro2, RefX, RefY + 0, RefX + 552, RefY + 0)
        Gr.DrawLine(PenNegro, RefX, RefY + 20, RefX + 552, RefY + 20)
        Gr.DrawLine(PenNegro, RefX, RefY + 40, RefX + 552, RefY + 40)
        Gr.DrawLine(PenNegro, RefX, RefY + 60, RefX + 552, RefY + 60)
        Gr.DrawLine(PenNegro, RefX, RefY + 80, RefX + 552, RefY + 80)
        Gr.DrawLine(PenNegro, RefX, RefY + 100, RefX + 552, RefY + 100)
        Gr.DrawLine(PenNegro2, RefX, RefY + 120, RefX + 552, RefY + 120)

        'lineas verticales de la tabla
        Gr.DrawLine(PenNegro2, RefX + 1, RefY + 0, RefX + 1, RefY + 120)
        Gr.DrawLine(PenNegro, RefX + 238, RefY + 0, RefX + 238, RefY + 120)
        Gr.DrawLine(PenNegro2, RefX + 276, RefY + 0, RefX + 276, RefY + 120)
        Gr.DrawLine(PenNegro, RefX + 514, RefY + 0, RefX + 514, RefY + 120)
        Gr.DrawLine(PenNegro2, RefX + 552, RefY + 0, RefX + 552, RefY + 120)

        'encabezados de tabla 1ra columna
        Gr.DrawString("Saco Gestacional Longitudinal(mm)", TextoFont, Negro, RefX + 2, RefY + 5)
        Gr.DrawString("Saco Gestacional Anteroposterior(mm)", TextoFont, Negro, RefX + 2, RefY + 25)
        Gr.DrawString("Saco Gestacional Transversal(mm)", TextoFont, Negro, RefX + 2, RefY + 45)
        Gr.DrawString("Vesícula Vitelina Longitudinal(mm)", TextoFont, Negro, RefX + 2, RefY + 65)
        Gr.DrawString("Vesícula Vitelina Anteroposterior(mm)", TextoFont, Negro, RefX + 2, RefY + 85)
        Gr.DrawString("Longitud Craneo-Caudal(mm)", TextoFont, Negro, RefX + 2, RefY + 105)

        'encabezados 2da columna
        Gr.DrawString("Diámetro Biparietal(mm)", TextoFont, Negro, RefX + 278, RefY + 5)
        Gr.DrawString("Circunferencia Cefálica(mm)", TextoFont, Negro, RefX + 278, RefY + 25)
        Gr.DrawString("Circunferencia Abdominal(mm)", TextoFont, Negro, RefX + 278, RefY + 45)
        Gr.DrawString("Fémur(mm)", TextoFont, Negro, RefX + 278, RefY + 65)
        Gr.DrawString("Translucencia Nucal(mm)", TextoFont, Negro, RefX + 278, RefY + 85)

        'partes de datos en la primera columna
        Gr.DrawString(txt1erSGlong.Text, TextoFont, Negro, RefX + 240, RefY + 5)
        Gr.DrawString(txt1erSGantPost.Text, TextoFont, Negro, RefX + 240, RefY + 25)
        Gr.DrawString(txt1erSGtrans.Text, TextoFont, Negro, RefX + 240, RefY + 45)
        Gr.DrawString(txt1erVVlong.Text, TextoFont, Negro, RefX + 240, RefY + 65)
        Gr.DrawString(txt1erVVantPost.Text, TextoFont, Negro, RefX + 240, RefY + 85)
        Gr.DrawString(txt1erLCC.Text, TextoFont, Negro, RefX + 240, RefY + 105)

        'partes de datos en la segunda columna
        Gr.DrawString(txt1erDBP.Text, TextoFont, Negro, RefX + 516, RefY + 5)
        Gr.DrawString(txt1erCC.Text, TextoFont, Negro, RefX + 516, RefY + 25)
        Gr.DrawString(txt1erCA.Text, TextoFont, Negro, RefX + 516, RefY + 45)
        Gr.DrawString(txt1erFemur.Text, TextoFont, Negro, RefX + 516, RefY + 65)
        Gr.DrawString(txt1erTN.Text, TextoFont, Negro, RefX + 516, RefY + 85)

        'Observaciones
        InicioY += 160
        Frase = "OBSERVACIONES."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
        InicioY += 10
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY, InicioX + 690, InicioY)

        '1ra linea
        If txt1erTComentarios01.Text <> "" Then 'hay algo escrito en la linea
            InicioY += 15
            Frase = txt1erTComentarios01.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If
        '2da linea
        If txt1erTcomentarios02.Text <> "" Then 'hay algo escrito en la linea
            InicioY += 15
            Frase = txt1erTcomentarios02.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If
        '3ra linea
        If txt1erTcomentarios03.Text <> "" Then 'hay algo escrito en la linea
            InicioY += 15
            Frase = txt1erTcomentarios03.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If
        '4ta linea
        If txt1erTcomentarios04.Text <> "" Then 'hay algo escrito en la linea
            InicioY += 15
            Frase = txt1erTcomentarios04.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If
        '5ta linea
        If txt1erTcomentarios05.Text <> "" Then 'hay algo escrito en la linea
            InicioY += 15
            Frase = txt1erTcomentarios05.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If

        'IDx
        InicioY += 25
        Frase = "IMPRESION DIAGNOSTICA."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
        InicioY += 10
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY, InicioX + 690, InicioY)

        '1RA LINEA
        InicioY += 15
        Frase = "EDAD GESTACIONAL x FUR: " & lab1ertEGxFUR02.Text
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)

        '2DA LINEA
        InicioY += 15
        Frase = "EDAD GESTACIONAL x ECO: " & txt1erEGxECO.Text
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)

        '3ra linea
        If txt1erTidx01.Text <> "" Then 'hay algo escrito en la linea
            InicioY += 15
            Frase = txt1erTidx01.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If
        '4ta linea
        If txt1erTidx02.Text <> "" Then 'hay algo escrito en la linea
            InicioY += 15
            Frase = txt1erTidx02.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If
        '5ta linea
        If txt1erTidx03.Text <> "" Then 'hay algo escrito en la linea
            InicioY += 15
            Frase = txt1erTidx03.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If

        'mensaje final
        InicioX = 0
        InicioY = 715
        Gr.DrawLine(PenNegro, InicioX, InicioY, InicioX + 689, InicioY)
        Gr.DrawLine(PenNegro, InicioX, InicioY + 40, InicioX + 689, InicioY + 40)
        Gr.DrawLine(PenNegro, InicioX, InicioY, InicioX, InicioY + 40)
        Gr.DrawLine(PenNegro, InicioX + 689, InicioY, InicioX + 689, InicioY + 40)

        Frase = "ADVERTENCIA: En ausencia de marcadores, el ultrasonido posee muy poca sensibilidad diagnóstica para alteraciones cromosómicas"
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 5)
        Frase = "y la integridad anatómica del feto no excluye la existencia de alguna de ellas."
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 20)


        txtInforme.Text = " "




    End Sub

    Private Sub Informe2y3erTrimestre()
        'variables para los elementos graficos 
        Dim PenNegro As New Pen(Color.Black, 1)
        Dim PenNegro2 As New Pen(Color.Black, 2)
        Dim PenGris As New Pen(Color.Gray, 1)
        Dim Blanco As New SolidBrush(Color.White)
        Dim Clarito As New SolidBrush(Color.Snow)
        Dim Negro As New SolidBrush(Color.Black)
        Dim Naranja As New SolidBrush(Color.Orange)
        Dim Caqui As New SolidBrush(Color.Khaki)
        Dim Rojo As New SolidBrush(Color.Red)
        Dim Rojito As New SolidBrush(Color.MistyRose)
        Dim Azul As New SolidBrush(Color.Blue)
        Dim Azulito As New SolidBrush(Color.Lavender)
        Dim RectanguloTodo As New Rectangle(0, 0, 690, 925)
        Dim RectanguloGrafico As New Rectangle(50, 25, 400, 250)
        Dim SmallFont As New Font("Microsoft Sans Serif", 7)
        Dim TextoFont As New Font("Microsoft Sans Serif", 8)
        Dim SubtituloFont As New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
        Dim TituloFont As New Font("times new roman", 10, FontStyle.Bold)


        Dim AnchoX As Single
        Dim InicioX, InicioY As Single
        Dim RefX, RefY As Integer
        Dim Frase As String
        Dim Fuente As Font = TextoFont
        Dim Valor As Integer = 0 'esta var es para chequear anormalidades en los datos biometricos


        'crea el marco grafico y le asigna el vinculo para dibujar en el
        Fondo = Me.CreateGraphics
        BMP = New Bitmap(PictureBox2.Width, PictureBox2.Height)
        BMP2 = New Bitmap(PictureBox2.Width, PictureBox2.Height)
        PictureBox2.Image = BMP
        Fondo.Clear(PictureBox2.BackColor)
        Gr = Graphics.FromImage(BMP)

        'crea una apariencia de hoja blanca en el fondo
        Gr.FillRectangle(Blanco, RectanguloTodo)

        'emcabezado
        'titulo
        InicioX = 0
        InicioY = 0

        Gr.DrawLine(PenNegro2, InicioX, InicioY + 1, InicioX + 690, InicioY + 1)
        Frase = "ESTUDIO ULTRASONOGRAFICO DEL 2do Y 3er TRIMESTRE"
        AnchoX = Gr.MeasureString(Frase, TituloFont).Width
        RefX = InicioX + 345 - (AnchoX \ 2)
        Gr.DrawString(Frase, TituloFont, Negro, RefX, InicioY + 5)
        Gr.DrawLine(PenNegro2, InicioX, InicioY + 25, InicioX + 690, InicioY + 25)

        'fecha
        Frase = "Fecha del Estudio: " & txtFechaInicioControl.Text
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        RefX = InicioX + 690 - (AnchoX)
        Gr.DrawString(Frase, TextoFont, Negro, RefX, InicioY + 30)

        'nombre de la pte
        Frase = "Nombre: " & txtNombrePaciente.Text.ToUpper & ". "
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY + 45)
        'edad si se sabe
        If IsNumeric(txtEdad2y3erT.Text) Then
            Frase = " " & txtEdad2y3erT.Text & " años. "
            RefX = InicioX + AnchoX  'este es el ancho del nombre para iniciar la edad
            Gr.DrawString(Frase, SubtituloFont, Negro, RefX, InicioY + 45)
            AnchoX = RefX + Gr.MeasureString(Frase, SubtituloFont).Width
        End If
        'paridad si la tiene
        If txtParidad2y3erT.Text <> "" Then
            Frase = txtParidad2y3erT.Text & "."
            RefX = InicioX + AnchoX
            Gr.DrawString(Frase, SubtituloFont, Negro, RefX, InicioY + 45)
        End If

        'fur y fpp
        Frase = "FUR: " & labFUR2y3erT.Text & ". FPP: " & labFPP2y3erT.Text & ". EG x FUR: " & labEGxFUR2y3erT.Text
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY + 60)



        'datos Obstetricos
        Frase = "Datos Obstétricos"
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        InicioX = 0
        InicioY = 75
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX + 10, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        'EMBARAZO INTRA O EXTRAUTERINO
        Frase = "Embarazo "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 5, InicioY + 15) 'solo la palabra embarazo
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radEmbarazo01.Checked = True Then
            Frase = "INTRAUTERINO"
            Fuente = TextoFont
        ElseIf radEmbarazo02.Checked = True Then
            Frase = "EXTRAUTERINO"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + 5 + AnchoX, InicioY + 15)

        'FETO UNICO O GEMELAR
        Frase = "Feto "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 5, InicioY + 30) 'solo la palabra feto
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radFeto01.Checked = True Then
            Frase = "UNICO"
            Fuente = TextoFont
        ElseIf radFeto02.Checked = True Then
            Frase = "GEMELAR"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + 5 + AnchoX, InicioY + 30)

        'SITUACION
        Frase = "Situación "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 230, InicioY + 15) 'solo la palabra situacion
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radSituacion1.Checked = True Then
            Frase = "LONGITUDINAL"
            Fuente = TextoFont
        ElseIf radSituacion2.Checked = True Then
            Frase = "OBLICUA"
            Fuente = SubtituloFont
        ElseIf radSituacion3.Checked = True Then
            Frase = "TRANSVERSA"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + 230 + AnchoX, InicioY + 15)

        'PRESENTACION
        Frase = "Presentación "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 230, InicioY + 30) 'solo la palabra presentación
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radPresentacion1.Checked = True Then
            Frase = "CEFALICA"
            Fuente = TextoFont
        ElseIf radPresentacion2.Checked = True Then
            Frase = "PODALICA"
            Fuente = SubtituloFont
        ElseIf radpresentacion3.Checked = True Then
            Frase = "N/A"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + 230 + AnchoX, InicioY + 30) 'pone el otro pedazo normal o negrita

        'Posicion
        If radPosicion1.Checked = True Then
            Frase = "Posición ANTERIOR"
        ElseIf radPosicion2.Checked = True Then
            Frase = "Posición POSTERIOR"
        ElseIf radPosicion3.Checked = True Then
            Frase = "Posición DERECHA ANTERIOR"
        ElseIf radPosicion4.Checked = True Then
            Frase = "Posición IZQUIERDA ANTERIOR"
        ElseIf radPosicion5.Checked = True Then
            Frase = "Posición IZQUIERDA TRANSVERSA"
        ElseIf radPosicion6.Checked = True Then
            Frase = "Posición IZQUIERDA POSTERIOR"
        ElseIf radPosicion7.Checked = True Then
            Frase = "Posición DERECHA TRANSVERSA"
        ElseIf radPosicion8.Checked = True Then
            Frase = "Posición DERECHA POSTERIOR"
        End If
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 460, InicioY + 15)

        'datos biometricos
        Frase = "Datos Biométricos"
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        InicioX = 0
        InicioY = 125
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX + 10, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        'referencias de inicio de la tabla de biometria

        RefX = InicioX
        RefY = InicioY + 20


        'lineas de la tabla horizontales
        Gr.DrawLine(PenNegro2, RefX, RefY + 0, RefX + 690, RefY + 0)
        Gr.DrawLine(PenNegro, RefX, RefY + 20, RefX + 690, RefY + 20)
        Gr.DrawLine(PenNegro, RefX, RefY + 40, RefX + 690, RefY + 40)
        Gr.DrawLine(PenNegro, RefX, RefY + 60, RefX + 690, RefY + 60)
        Gr.DrawLine(PenNegro, RefX, RefY + 80, RefX + 690, RefY + 80)
        Gr.DrawLine(PenNegro2, RefX, RefY + 100, RefX + 690, RefY + 100)
        'lineas verticales de la tabla
        Gr.DrawLine(PenNegro2, RefX + 1, RefY + 0, RefX + 1, RefY + 100)
        Gr.DrawLine(PenNegro, RefX + 100, RefY + 0, RefX + 100, RefY + 100)
        Gr.DrawLine(PenNegro2, RefX + 138, RefY + 0, RefX + 138, RefY + 100)
        Gr.DrawLine(PenNegro, RefX + 238, RefY + 0, RefX + 238, RefY + 100)
        Gr.DrawLine(PenNegro2, RefX + 276, RefY + 0, RefX + 276, RefY + 100)
        Gr.DrawLine(PenNegro, RefX + 376, RefY + 0, RefX + 376, RefY + 100)
        Gr.DrawLine(PenNegro2, RefX + 414, RefY + 0, RefX + 414, RefY + 100)
        Gr.DrawLine(PenNegro, RefX + 514, RefY + 0, RefX + 514, RefY + 100)
        Gr.DrawLine(PenNegro2, RefX + 552, RefY + 0, RefX + 552, RefY + 100)
        Gr.DrawLine(PenNegro, RefX + 652, RefY + 0, RefX + 652, RefY + 100)
        Gr.DrawLine(PenNegro2, RefX + 689, RefY + 0, RefX + 689, RefY + 100)

        'encabezados de tabla 1ra columna
        Gr.DrawString("Biparietal(mm)", TextoFont, Negro, RefX + 2, RefY + 5)
        Gr.DrawString("O.Frontal(mm)", TextoFont, Negro, RefX + 2, RefY + 25)
        Gr.DrawString("C.Cefálica(mm)", TextoFont, Negro, RefX + 2, RefY + 45)
        Gr.DrawString("T.Cerebelo(mm)", TextoFont, Negro, RefX + 2, RefY + 65)
        Gr.DrawString("Atrio (mm)", TextoFont, Negro, RefX + 2, RefY + 85)
        'encabezados 2da columna
        Gr.DrawString("IO.Externo(mm)", TextoFont, Negro, RefX + 140, RefY + 5)
        Gr.DrawString("IO.Interno(mm)", TextoFont, Negro, RefX + 140, RefY + 25)
        Gr.DrawString("PliegueNucal(mm)", TextoFont, Negro, RefX + 140, RefY + 45)
        Gr.DrawString("AP.Cardíaco(mm)", TextoFont, Negro, RefX + 140, RefY + 65)
        Gr.DrawString("AP.Tórax(mm)", TextoFont, Negro, RefX + 140, RefY + 85)
        'encabezados 3ra columna
        Gr.DrawString("Aorta(mm)", TextoFont, Negro, RefX + 278, RefY + 5)
        Gr.DrawString("T.Abdomen(mm)", TextoFont, Negro, RefX + 278, RefY + 25)
        Gr.DrawString("C.Abdominal(mm)", TextoFont, Negro, RefX + 278, RefY + 45)
        Gr.DrawString("Fémur(mm)", TextoFont, Negro, RefX + 278, RefY + 65)
        Gr.DrawString("Tibia(mm)", TextoFont, Negro, RefX + 278, RefY + 85)
        'encabezados 4ta columna
        Gr.DrawString("Húmero(mm)", TextoFont, Negro, RefX + 416, RefY + 5)
        Gr.DrawString("Ulna(mm)", TextoFont, Negro, RefX + 416, RefY + 25)
        Gr.DrawString("Sacro(mm)", TextoFont, Negro, RefX + 416, RefY + 45)
        Gr.DrawString("NOD.Fémur(mm)", TextoFont, Negro, RefX + 416, RefY + 65)
        Gr.DrawString("NOP.Tibia(mm)", TextoFont, Negro, RefX + 416, RefY + 85)
        'encabezados 5ta columna
        Gr.DrawString("NOP.Húmero(mm)", TextoFont, Negro, RefX + 554, RefY + 5)
        Gr.DrawString("BPF(mm)", TextoFont, Negro, RefX + 554, RefY + 25)
        Gr.DrawString("Peso(gr)", TextoFont, Negro, RefX + 554, RefY + 45)
        Gr.DrawString("Talla(cm)", TextoFont, Negro, RefX + 554, RefY + 65)
        Gr.DrawString("", TextoFont, Negro, RefX + 554, RefY + 85)

        'rellena los datos existentes 1ra columna
        Gr.DrawString(txtDBP.Text, TextoFont, Negro, RefX + 102, RefY + 5)
        Gr.DrawString(txtDOF.Text, TextoFont, Negro, RefX + 102, RefY + 25)
        Gr.DrawString(txtCC.Text, TextoFont, Negro, RefX + 102, RefY + 45)
        Gr.DrawString(txtTCer.Text, TextoFont, Negro, RefX + 102, RefY + 65)
        If IsNumeric(txtAtrio.Text) Then
            Valor = CType(txtAtrio.Text, Integer)
            If Valor >= 10 Then
                Fuente = TituloFont
            Else
                Fuente = TextoFont
            End If
            Gr.DrawString(txtAtrio.Text, Fuente, Negro, RefX + 102, RefY + 85)
        End If
        'rellena los datos existentes 2da columna
        Gr.DrawString(txtIOE.Text, TextoFont, Negro, RefX + 240, RefY + 5)
        Gr.DrawString(txtIOI.Text, TextoFont, Negro, RefX + 240, RefY + 25)
        If IsNumeric(txtPN.Text) Then
            Valor = CType(txtPN.Text, Integer)
            If Valor >= 6 Then
                Fuente = TituloFont
            Else
                Fuente = TextoFont
            End If
            Gr.DrawString(txtPN.Text, Fuente, Negro, RefX + 240, RefY + 45)
        End If
        Gr.DrawString(txtAPC.Text, TextoFont, Negro, RefX + 240, RefY + 65)
        Gr.DrawString(txtAPT.Text, TextoFont, Negro, RefX + 240, RefY + 85)
        'rellena los datos existentes 3ra columna
        Gr.DrawString(txtAorta.Text, TextoFont, Negro, RefX + 378, RefY + 5)
        Gr.DrawString(txtTransAbdomen.Text, TextoFont, Negro, RefX + 378, RefY + 25)
        Gr.DrawString(txtCA.Text, TextoFont, Negro, RefX + 378, RefY + 45)
        Gr.DrawString(txtFemur.Text, TextoFont, Negro, RefX + 378, RefY + 65)
        Gr.DrawString(txtTibia.Text, TextoFont, Negro, RefX + 378, RefY + 85)
        'rellena los datos existentes 4ta columna
        Gr.DrawString(txtHumero.Text, TextoFont, Negro, RefX + 516, RefY + 5)
        Gr.DrawString(txtUlna.Text, TextoFont, Negro, RefX + 516, RefY + 25)
        Gr.DrawString(txtSacro.Text, TextoFont, Negro, RefX + 516, RefY + 45)
        Gr.DrawString(txtNODF.Text, TextoFont, Negro, RefX + 516, RefY + 65)
        Gr.DrawString(txtNOPT.Text, TextoFont, Negro, RefX + 516, RefY + 85)
        'rellena los datos existentes 5ta columna
        Gr.DrawString(txtNOPH.Text, TextoFont, Negro, RefX + 654, RefY + 5)
        Gr.DrawString(txtBPF.Text, TextoFont, Negro, RefX + 654, RefY + 25)
        Gr.DrawString(txtPeso.Text, TextoFont, Negro, RefX + 654, RefY + 45)
        Gr.DrawString(txtTalla.Text, TextoFont, Negro, RefX + 654, RefY + 65)

        'DATOS ANATOMICOS
        Frase = "Datos Anatómicos"
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        InicioX = 0
        InicioY = 255
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX + 10, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        'POLO CEFALICO
        Frase = "Polo Cefálico "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 15)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radCabeza1.Checked = True Then
            Frase = "NORMAL"
            Fuente = TextoFont
        ElseIf radCabeza2.Checked = True Then
            Frase = "ANORMAL"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX, InicioY + 15)

        'VENTRICULOS CEREBRALES
        Frase = "Ventrículos Cerebrales "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 30)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radVentriculo1.Checked = True Then
            Frase = "NORMALES"
            Fuente = TextoFont
        ElseIf radVentriculo2.Checked = True Then
            Frase = "ANORMALES"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX, InicioY + 30)

        'ROSTRO
        Frase = "Rostro "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 45)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radRostro1.Checked = True Then
            Frase = "SIN FISURAS"
            Fuente = TextoFont
        ElseIf radRostro2.Checked = True Then
            Frase = "ANORMAL"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX, InicioY + 45)

        'COLUMNA VERTEBRAL
        Frase = "Columna Vertebral "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 60)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radColumna1.Checked = True Then
            Frase = "NORMAL"
            Fuente = TextoFont
        ElseIf radColumna2.Checked = True Then
            Frase = "ANORMAL"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX, InicioY + 60)

        'EXTREMIDADES
        Frase = "Extremidades "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 225, InicioY + 15)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radExtremidades1.Checked = True Then
            Frase = "COMPLETAS"
            Fuente = TextoFont
        ElseIf radExtremidades2.Checked = True Then
            Frase = "ANORMALES"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 225, InicioY + 15)

        'TORAX

        Frase = "Tórax "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 225, InicioY + 30)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radTorax1.Checked = True Then
            Frase = "NORMAL"
            Fuente = TextoFont
        ElseIf radTorax2.Checked = True Then
            Frase = "ANORMAL"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 225, InicioY + 30)

        'CORAZON
        Frase = "Corazón "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 225, InicioY + 45)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radCorazon1.Checked = True Then
            Frase = "NORMAL"
            Fuente = TextoFont
        ElseIf radCorazon2.Checked = True Then
            Frase = "ANORMAL"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 225, InicioY + 45)

        'ABDOMEN
        Frase = "Abdomen "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 225, InicioY + 60)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radAbdomen1.Checked = True Then
            Frase = "NORMAL"
            Fuente = TextoFont
        ElseIf radAbdomen2.Checked = True Then
            Frase = "ANORMAL"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 225, InicioY + 60)

        'RIÑONES
        Frase = "Riñones "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 455, InicioY + 15)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radRiñones1.Checked = True Then
            Frase = "NORMALES"
            Fuente = TextoFont
        ElseIf radRiñones2.Checked = True Then
            Frase = "ANORMALES"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 455, InicioY + 15)

        'SEXO
        Frase = "Sexo "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 455, InicioY + 30)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radSexo1.Checked = True Then
            Frase = "MASCULINO"
            Fuente = TextoFont
        ElseIf radSexo2.Checked = True Then
            Frase = "FEMENINO"
            Fuente = TextoFont
        Else
            Frase = "NO ACCESIBLE"
            Fuente = TextoFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 455, InicioY + 30)

        'datos FUNCIONALES
        Frase = "Datos Funcionales"
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        InicioX = 0
        InicioY = 335
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX + 10, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        'ACTITUD GLOBAL
        Frase = "Actitud Global "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 15)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radActitud1.Checked = True Then
            Frase = "FLEXION"
            Fuente = TextoFont
        ElseIf radActitud2.Checked = True Then
            Frase = "EXTENSION"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX, InicioY + 15)

        'ACTIVIDAD CARDIACA
        Frase = "Actividad Cardíaca "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 30)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radActividadCardiaca1.Checked = True Then
            Frase = "PRESENTE"
            Fuente = TextoFont
        ElseIf radActividadCardiaca2.Checked = True Then
            Frase = "AUSENTE"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX, InicioY + 30)

        'CAMARA GASTRICA
        Frase = "Cámara Gástrica "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 45)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radCamaraGastrica1.Checked = True Then
            Frase = "LLENA"
            Fuente = TextoFont
        ElseIf radCamaraGastrica2.Checked = True Then
            Frase = "VACIA"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX, InicioY + 45)

        'TONO
        Frase = "Tono "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 225, InicioY + 15)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radTono1.Checked = True Then
            Frase = "NORMAL"
            Fuente = TextoFont
        ElseIf radTono2.Checked = True Then
            Frase = "ANORMAL"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 225, InicioY + 15)

        'MOV RESPIRATORIOS
        Frase = "Movimientos Respiratorios "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 225, InicioY + 30)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radMovimientosRespiratorios1.Checked = True Then
            Frase = "PRESENTES"
            Fuente = TextoFont
        ElseIf radMovimientosRespiratorios2.Checked = True Then
            Frase = "AUSENTES"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 225, InicioY + 30)

        'INTESTINO TIPO
        Frase = "Intestino Tipo "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 225, InicioY + 45)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radIntestino1.Checked = True Then
            Frase = "0/4"
            Fuente = TextoFont
        ElseIf radIntestino2.Checked = True Then
            Frase = "1/4"
            Fuente = TextoFont
        ElseIf radIntestino3.Checked = True Then
            Frase = "2/4"
            Fuente = TextoFont
        ElseIf radIntestino4.Checked = True Then
            Frase = "3/4"
            Fuente = TextoFont
        ElseIf radIntestino5.Checked = True Then
            Frase = "4/4"
            Fuente = TextoFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 225, InicioY + 45)

        'MOV FETALES
        Frase = "Movimientos Fetales "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 455, InicioY + 15)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radMovimientosFetales1.Checked = True Then
            Frase = "PRESENTES"
            Fuente = TextoFont
        ElseIf radMovimientosFetales2.Checked = True Then
            Frase = "AUSENTES"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 455, InicioY + 15)

        'RELACION AORTO-CAVA
        Frase = "Relación Aorto-Cava "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 455, InicioY + 30)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radAortoCava1.Checked = True Then
            Frase = "NORMAL"
            Fuente = TextoFont
        ElseIf radAortoCava2.Checked = True Then
            Frase = "ANORMAL"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 455, InicioY + 30)

        'VEJIGA
        Frase = "Vejiga "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 455, InicioY + 45)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radVejiga1.Checked = True Then
            Frase = "LLENA"
            Fuente = TextoFont
        ElseIf radVejiga2.Checked = True Then
            Frase = "VACIA"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + 455 + AnchoX, InicioY + 45)


        'datos placentarios
        Frase = "Datos Placentarios "
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        InicioX = 0
        InicioY = 400
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX + 10, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        'LOCALIZACION PLACENTA
        Frase = "Implantación "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 15)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radPlacenta1.Checked = True Then
            Frase = "ANTERIOR"
            Fuente = TextoFont
        ElseIf radPlacenta2.Checked = True Then
            Frase = "POSTERIOR"
            Fuente = TextoFont
        ElseIf radPlacenta3.Checked = True Then
            Frase = "ANTERIOR y FUNDICA"
            Fuente = TextoFont
        ElseIf radplacenta4.Checked = True Then
            Frase = "POSTERIOR y FUNDICA"
            Fuente = TextoFont
        ElseIf radPlacenta5.Checked = True Then
            Frase = "FUNDICA"
            Fuente = TextoFont
        ElseIf radPlacenta6.Checked = True Then
            Frase = "PREVIA PARCIAL"
            Fuente = SubtituloFont
        ElseIf radPlacenta7.Checked = True Then
            Frase = "PREVIA TOTAL"
            Fuente = SubtituloFont
        ElseIf radPlacenta8.Checked = True Then
            Frase = "de INSERCION BAJA"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX, InicioY + 15)

        'GRADO DE MADUREZ
        Frase = "Grado de Madurez "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 30)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radPlacentaGrado1.Checked = True Then
            Frase = "0/3"
            Fuente = TextoFont
        ElseIf radPlacentaGrado2.Checked = True Then
            Frase = "0-1/3"
            Fuente = TextoFont
        ElseIf radPlacentaGrado3.Checked = True Then
            Frase = "1/3"
            Fuente = TextoFont
        ElseIf radPlacentaGrado4.Checked = True Then
            Frase = "1-2/3"
            Fuente = TextoFont
        ElseIf radPlacentaGrado5.Checked = True Then
            Frase = "2/3"
            Fuente = TextoFont
        ElseIf radPlacentaGrado6.Checked = True Then
            Frase = "2-3/3"
            Fuente = TextoFont
        ElseIf radPlacentaGrado7.Checked = True Then
            Frase = "3/3"
            Fuente = TextoFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX, InicioY + 30)

        'placenta grosor
        Frase = "Grosor(mm) " & txtPlacentaGrosor.Text
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 45)

        'cordon umbilical
        Frase = "Cordón Umbilical "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 225, InicioY + 15)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radCordon1.Checked = True Then
            Frase = "con 3 ELEMENTOS VASCULARES"
            Fuente = TextoFont
        ElseIf radCordon2.Checked = True Then
            Frase = "ANORMAL"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 225, InicioY + 15)

        'lIQ AMNIOTICO
        Frase = "Líquido Amniótico "
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 225, InicioY + 30)
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        If radLiquidoAmniotico1.Checked = True Then
            Frase = "NORMAL"
            Fuente = TextoFont
        ElseIf radLiquidoAmniotico2.Checked = True Then
            Frase = "ANORMAL"
            Fuente = SubtituloFont
        End If
        Gr.DrawString(Frase, Fuente, Negro, InicioX + AnchoX + 225, InicioY + 30)

        'ila
        Frase = "ILA (cm) " & txtILA.Text
        Gr.DrawString(Frase, TextoFont, Negro, InicioX + 225, InicioY + 45)

        'notas
        Frase = "Notas y Observaciones "
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        InicioX = 0
        InicioY = 465
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX + 10, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        'nota01
        Frase = txtNotas01del2y3erT.Text
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 15)
        'nota02
        Frase = txtNotas02del2y3erT.Text
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 30)
        'nota03
        Frase = txtNotas03del2y3erT.Text
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 45)

        'IDx
        Frase = "Impresión Diagnóstica "
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        InicioX = 0
        InicioY = 530
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX + 10, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        'Idx
        Frase = "EMBARAZO DE " & txtIdx01del2y3erT.Text & ". CRECIMIENTO FETAL EN PERCENTIL " & txtIdx02del2y3erT.Text
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY + 15)
        Frase = "PERFIL BIOFISICO ECOGRAFICO: " & txtIdx03del2y3erT.Text & "/8.  ECOPUNTAJE GENETICO: " & txtIdx04del2y3erT.Text & " (NORMAL < 2)"
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY + 30)
        Frase = "SALUD FETAL " & txtIdx05del2y3erT.Text
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY + 45)
        If txtIDx06del2y3erT.Text <> "" Then
            Frase = txtIDx06del2y3erT.Text
            Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY + 60)
        End If
        If txtIDx07del2y3erT.Text <> "" Then
            Frase = txtIDx07del2y3erT.Text
            Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY + 75)
        End If
        If txtIDx08del2y3erT.Text <> "" Then
            Frase = txtIDx08del2y3erT.Text
            Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY + 90)
        End If

        'sugerencias titulo
        Frase = "Sugerencias "
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        InicioX = 0
        InicioY = 640
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX + 10, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        'sugerencias
        If txtSug01del2y3erT.Text <> "" Then
            Frase = txtSug01del2y3erT.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 15)
        End If
        If txtSug02del2y3erT.Text <> "" Then
            Frase = txtSug02del2y3erT.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 30)
        End If
        If txtSug03del2y3erT.Text <> "" Then
            Frase = txtSug03del2y3erT.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 45)
        End If

        'mensaje final
        InicioX = 0
        InicioY = 715
        Gr.DrawLine(PenNegro, InicioX, InicioY, InicioX + 689, InicioY)
        Gr.DrawLine(PenNegro, InicioX, InicioY + 40, InicioX + 689, InicioY + 40)
        Gr.DrawLine(PenNegro, InicioX, InicioY, InicioX, InicioY + 40)
        Gr.DrawLine(PenNegro, InicioX + 689, InicioY, InicioX + 689, InicioY + 40)

        Frase = "ADVERTENCIA: En ausencia de marcadores, el ultrasonido posee muy poca sensibilidad diagnóstica para alteraciones cromosómicas"
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 5)
        Frase = "y la integridad anatómica del feto no excluye la existencia de alguna de ellas."
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 20)


        txtInforme.Text = " "

        'fin de la modificacion en caso de incendio rompa el vidrio

    End Sub

    Private Sub InformeGinecologico()

        'variables para los elementos graficos 
        Dim PenNegro As New Pen(Color.Black, 1)
        Dim PenNegro2 As New Pen(Color.Black, 2)
        Dim PenGris As New Pen(Color.Gray, 1)
        Dim Blanco As New SolidBrush(Color.White)
        Dim Clarito As New SolidBrush(Color.Snow)
        Dim Negro As New SolidBrush(Color.Black)
        Dim Naranja As New SolidBrush(Color.Orange)
        Dim Caqui As New SolidBrush(Color.Khaki)
        Dim Rojo As New SolidBrush(Color.Red)
        Dim Rojito As New SolidBrush(Color.MistyRose)
        Dim Azul As New SolidBrush(Color.Blue)
        Dim Azulito As New SolidBrush(Color.Lavender)
        Dim RectanguloTodo As New Rectangle(0, 0, 690, 925)
        Dim RectanguloGrafico As New Rectangle(50, 25, 400, 250)
        Dim SmallFont As New Font("Microsoft Sans Serif", 7)
        Dim TextoFont As New Font("Microsoft Sans Serif", 8)
        Dim SubtituloFont As New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
        Dim TituloFont As New Font("times new roman", 10, FontStyle.Bold)


        Dim AnchoX As Single
        Dim InicioX, InicioY As Single
        Dim RefX As Integer
        'Dim RefY As Integer
        Dim Frase As String
        Dim Fuente As Font = TextoFont
        Dim Valor As Integer = 0 'esta var es para chequear anormalidades en los datos biometricos


        'crea el marco grafico y le asigna el vinculo para dibujar en el
        Fondo = Me.CreateGraphics
        BMP = New Bitmap(PictureBox2.Width, PictureBox2.Height)
        BMP2 = New Bitmap(PictureBox2.Width, PictureBox2.Height)
        PictureBox2.Image = BMP
        Fondo.Clear(PictureBox2.BackColor)
        Gr = Graphics.FromImage(BMP)

        'crea una apariencia de hoja blanca en el fondo
        Gr.FillRectangle(Blanco, RectanguloTodo)

        'emcabezado
        'titulo
        InicioX = 0
        InicioY = 0

        Gr.DrawLine(PenNegro2, InicioX, InicioY + 1, InicioX + 690, InicioY + 1)
        Frase = "ESTUDIO ULTRASONOGRAFICO GINECOLÓGICO"
        AnchoX = Gr.MeasureString(Frase, TituloFont).Width
        RefX = InicioX + 345 - (AnchoX \ 2)
        Gr.DrawString(Frase, TituloFont, Negro, RefX, InicioY + 5)
        Gr.DrawLine(PenNegro2, InicioX, InicioY + 25, InicioX + 690, InicioY + 25)

        'fecha
        Frase = "Fecha del Estudio: " & txtFechaInicioControl.Text
        AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        RefX = InicioX + 690 - (AnchoX)
        Gr.DrawString(Frase, TextoFont, Negro, RefX, InicioY + 30)

        'nombre de la pte
        Frase = "Nombre: " & txtNombrePaciente.Text.ToUpper & ". "
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY + 45)
        'edad si se sabe
        If IsNumeric(labEdadGinecologico.Text) Then
            Frase = " " & labEdadGinecologico.Text & " años. "
            RefX = InicioX + AnchoX  'este es el ancho del nombre para iniciar la edad
            Gr.DrawString(Frase, SubtituloFont, Negro, RefX, InicioY + 45)
            AnchoX = RefX + Gr.MeasureString(Frase, SubtituloFont).Width
        End If
        'paridad si la tiene
        If txtParidadGinecologico.Text <> "" Then
            Frase = txtParidadGinecologico.Text & "."
            RefX = InicioX + AnchoX
            Gr.DrawString(Frase, SubtituloFont, Negro, RefX, InicioY + 45)
        End If

        'fur y dia del ciclo
        Frase = "Fecha de última regla: " & labFURginecologico.Text & "."
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 60)
        Frase = "Día del Ciclo: " & labDiaCicloGinecologico.Text & "."
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 75)
        'Frase = "Edad Gestacional x FUR: " & lab1ertEGxFUR01.Text & "."
        'Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 90)

        'tipo de estudio y frecuencia
        Frase = "Estudio Ecográfico realizado con trasductor "
        If radTipoEstudioGinecologico1.Checked = True Then
            Frase += "Trasvaginal "
        ElseIf radTipoEstudioGinecologico2.Checked = True Then
            Frase += "Transabdominal "
        End If
        Frase += "con una frecuencia de "
        If radGINfrec35.Checked = True Then
            Frase += "3.5 MHz."
        ElseIf radGINfrec50.Checked = True Then
            Frase += "5.0 MHz."
        ElseIf radGINfrec75.Checked = True Then
            Frase += "7.5 MHz."
        End If
        Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY + 90)

        'VEJIGA
        InicioY = 115
        Frase = "VEJIGA."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        '1ra linea: anatomia de la vejiga
        AnchoX = 0
        If RadGinVejigaVolumen1.Checked = True Then
            InicioY += 15
            Frase = "Llena"
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinVejigaVolumen2.Checked = True Then
            InicioY += 15
            Frase = "Vacía"
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinVejigaVolumen3.Checked = True Then
            InicioY += 15
            Frase = "Parcialmente llena"
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'adecuacion de la vejiga
        If RadGinVejigaAdecuada1.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase = ", adecuada para el estudio"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
                AnchoX += Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Adecuada para el estudio"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX += Gr.MeasureString(Frase, TextoFont).Width
            End If
        ElseIf RadGinVejigaAdecuada2.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase = ", NO adecuada para el estudio"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
                AnchoX += Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "NO adecuada para el estudio"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX += Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        'paredes de la vejiga
        If RadGinVejigaParedes1.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase = ", paredes regulares sin lesiones en su interior."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Paredes regulares sin lesiones en su interior."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        ElseIf RadGinVejigaParedes2.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase = ", paredes irregulares."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "Paredes irregulares."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        Else
            If AnchoX > 0 Then
                Frase = "."
                Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
            End If
        End If

        'segunda linea posible obs de vejiga 1
        If txtGinVejigaObservaciones1.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinVejigaObservaciones1.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If

        'tercera linea posible obs de vejiga 2
        If txtGinVejigaObservaciones2.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinVejigaObservaciones2.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If



        'UTERO
        InicioY += 25
        Frase = "UTERO."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        '1ra linea de utero: posicion inclinacion ecopatron y bordes
        AnchoX = 0
        Frase = ""
        If RadGinUteroPosicion1.Checked = True Then
            InicioY += 15
            Frase = "En anteroversoflexión"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinUteroPosicion2.Checked = True Then
            InicioY += 15
            Frase = "Indiferente"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinUteroPosicion3.Checked = True Then
            InicioY += 15
            Frase = "En retroversoflexión"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'inclinacion del utero
        If RadGinUteroInclinacion1.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", lateralizado a la izquierda"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Lateralizado a la izquierda"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        ElseIf RadGinUteroInclinacion2.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", central"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "Central"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        ElseIf RadGinUteroInclinacion3.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", lateralizado a la derecha"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "Lateralizado a la derecha"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        'ecopatron del utero
        If RadGinUteroEcopatron1.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", ecopatrón homogéneo"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Ecopatrón homogéneo"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        ElseIf RadGinUteroEcopatron2.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", ecopatrón heterogéneo"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "Ecopatrón heterogéneo"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        'bordes del utero
        If RadGinUteroBordes1.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", bordes lisos y regulares"
                'Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Bordes lisos y regulares"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        ElseIf RadGinUteroBordes2.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", bordes irregulares"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "Bordes irregulares"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        'escribe la linea lista de una sola vez si tiene algo q poner
        If AnchoX > 0 Then
            'se escribio algo lo pone
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If



        '2da linea de utero: cavidad y endometrio
        AnchoX = 0
        Frase = ""
        If RadGinUteroEndometrio1.Checked = True Then
            InicioY += 15
            Frase = "Endometrio lineal"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinUteroEndometrio2.Checked = True Then
            InicioY += 15
            Frase = "Endometrio en fase proliferativa inicial"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinUteroEndometrio3.Checked = True Then
            InicioY += 15
            Frase = "Endometrio en fase proliferativa tardía (trilaminar)"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinUteroEndometrio4.Checked = True Then
            InicioY += 15
            Frase = "Endometrio en fase secretora"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinUteroEndometrio5.Checked = True Then
            InicioY += 15
            Frase = "Endometrio en fase menstrual"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'cavidad uterina
        If RadGinUteroCavidad1.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", cavidad uterina vacía"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Cavidad uterina vacía"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        ElseIf RadGinUteroCavidad2.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", cavidad uterina con contenido de ecopatrón heterogéneo"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "Cavidad uterina con contenido de ecopatrón heterogéneo"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        ElseIf RadGinUteroCavidad3.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", cavidad uterina con contenido sugestivo de hematometra o piometra"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "cavidad uterina con contenido sugestivo de hematometra o piometra"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        ElseIf RadGinUteroCavidad4.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", cavidad uterina con imágen sugestiva de pólipo"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "Cavidad uterina con imágen sugestiva de pólipo"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        ElseIf RadGinUteroCavidad5.Checked = True Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", cavidad uterina con imágen sugestiva de mioma submucoso"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en tipo de embarazo
                InicioY += 15
                Frase = "Cavidad uterina con imágen sugestiva de mioma submucoso"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        'escribe la linea lista de una sola vez si tiene algo q poner
        If AnchoX > 0 Then
            'se escribio algo lo pone
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If

        '3ra linea de utero: medidas
        AnchoX = 0
        Frase = ""

        If txtUteroLongitudinal.Text <> "" Then
            InicioY += 15
            Frase = "Medidas: Longitudinal " & txtUteroLongitudinal.Text & "mm"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        If txtUteroAnteroPosterior.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", anteroposterior " & txtUteroAnteroPosterior.Text & "mm"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Medidas: Anteroposterior " & txtUteroAnteroPosterior.Text & "mm"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        If txtUteroTransverso.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", transverso " & txtUteroTransverso.Text & "mm"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Medidas: Transverso " & txtUteroTransverso.Text & "mm"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        If txtUteroEndometrio.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                Frase += ", Endometrio " & txtUteroEndometrio.Text & "mm"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Medidas: Endometrio " & txtUteroEndometrio.Text & "mm"
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        'escribe la 3ra linea lista de una sola vez si tiene algo q poner
        If AnchoX > 0 Then
            'se escribio algo lo pone
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If

        'escribe la 4ta linea lista de una sola vez si tiene algo q poner
        If txtGinUteroObservaciones1.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinUteroObservaciones1.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If

        'escribe la 5ta linea lista de una sola vez si tiene algo q poner
        If txtGinUteroObservaciones2.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinUteroObservaciones2.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If


        'OVARIO IZQUIERDO
        InicioY += 25

        Dim TemporalY As Integer 'esta variable es para iniciar el ovario derecho a la misma altura
        TemporalY = InicioY 'temporalY se usara en el ovario derecho
        'al final se ve cual es mayor y ese se tomara como inicioY para el resto de la hoja

        Frase = "OVARIO IZQUIERDO."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 320, InicioY + 10)

        '1ra linea de OVARIO IZQUIERDO: TAMANO
        AnchoX = 0
        Frase = ""
        If RadGinOvarioIzquierdoTamano1.Checked = True Then
            InicioY += 15
            Frase = "De forma y volumen normal"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinOvarioIzquierdoTamano2.Checked = True Then
            InicioY += 15
            Frase = "Aumentado de volumen"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinOvarioIzquierdoTamano3.Checked = True Then
            InicioY += 15
            Frase = "Hipotrófico"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'escribe la 1ra linea de ovario izq lista de una sola vez si tiene algo q poner
        If AnchoX > 0 Then
            'se escribio algo lo pone
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If

        '2da linea de ovario izq: medidas
        AnchoX = 0
        Frase = ""

        If txtOvarioIzquierdoLongitudinal.Text <> "" Then
            InicioY += 15
            Frase = "Medidas: "
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            InicioY += 15
            Frase = "          Longitudinal " & txtOvarioIzquierdoLongitudinal.Text & "mm"
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        If txtOvarioIzquierdoAnteroPosterior.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                InicioY += 15
                Frase = "          Anteroposterior " & txtOvarioIzquierdoAnteroPosterior.Text & "mm"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Medidas: "
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                InicioY += 15
                Frase = "          Anteroposterior " & txtOvarioIzquierdoAnteroPosterior.Text & "mm"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        If txtOvarioIzquierdoTransverso.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                InicioY += 15
                Frase = "          Transverso " & txtOvarioIzquierdoTransverso.Text & "mm"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Medidas: "
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                InicioY += 15
                Frase = "          Transverso " & txtOvarioIzquierdoTransverso.Text & "mm"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        '3ra linea de ovario izq: foliculos
        AnchoX = 0
        Frase = ""

        If txtOvarioIzquierdoFoliculo1.Text <> "" Then
            InicioY += 15
            Frase = "Folículos dominantes: "
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            InicioY += 15
            Frase = "          folículo de " & txtOvarioIzquierdoFoliculo1.Text & "mm de diámetro"
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        If txtOvarioIzquierdoFoliculo2.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                InicioY += 15
                Frase = "          folículo de " & txtOvarioIzquierdoFoliculo2.Text & "mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Folículos dominantes "
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                InicioY += 15
                Frase = "          folículo de " & txtOvarioIzquierdoFoliculo2.Text & "mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        If txtOvarioIzquierdoFoliculo3.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                InicioY += 15
                Frase = "          folículo de " & txtOvarioIzquierdoFoliculo3.Text & "mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Folículos dominantes "
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                InicioY += 15
                Frase = "          folículo de " & txtOvarioIzquierdoFoliculo3.Text & "mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        If txtOvarioIzquierdoFoliculo4.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                InicioY += 15
                Frase = "          folículo de " & txtOvarioIzquierdoFoliculo4.Text & "mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                InicioY += 15
                Frase = "Folículos dominantes "
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                InicioY += 15
                Frase = "          folículo de " & txtOvarioIzquierdoFoliculo4.Text & "mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        'escribe las lineas de obs de ovario izquierdo si las hay
        If txtGinOvarioIzquierdoObservaciones1.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinOvarioIzquierdoObservaciones1.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If

        If txtGinOvarioIzquierdoObservaciones2.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinOvarioIzquierdoObservaciones2.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If

        If txtGinOvarioIzquierdoObservaciones3.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinOvarioIzquierdoObservaciones3.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If

        If txtGinOvarioIzquierdoObservaciones4.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinOvarioIzquierdoObservaciones4.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If


        'Ovario derecho se pondra a partir de 340 en medio de la hoja
        InicioX = 340
        Frase = "OVARIO DERECHO."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        'ya temporalY fue inicializado para que empiecen igual ambos ovarios
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, TemporalY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, TemporalY + 10, InicioX + 690, TemporalY + 10)

        '1ra linea de OVARIO DERECHO: TAMANO
        AnchoX = 0
        Frase = ""
        If RadGinOvarioDerechoTamano1.Checked = True Then
            TemporalY += 15
            Frase = "De forma y volumen normal"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinOvarioDerechoTamano2.Checked = True Then
            TemporalY += 15
            Frase = "Aumentado de volumen"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinOvarioDerechoTamano3.Checked = True Then
            TemporalY += 15
            Frase = "Hipotrófico"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'escribe la 1ra linea de ovario DER lista de una sola vez si tiene algo q poner
        If AnchoX > 0 Then
            'se escribio algo lo pone
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
        End If

        '2da linea de ovario DER: medidas
        AnchoX = 0
        Frase = ""

        If txtOvarioDerechoLongitudinal.Text <> "" Then
            TemporalY += 15
            Frase = "Medidas: "
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
            TemporalY += 15
            Frase = "          Longitudinal " & txtOvarioDerechoLongitudinal.Text & " mm"
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        If txtOvarioDerechoAnteroPosterior.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                TemporalY += 15
                Frase = "          Anteroposterior " & txtOvarioDerechoAnteroPosterior.Text & " mm"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                TemporalY += 15
                Frase = "Medidas: "
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                TemporalY += 15
                Frase = "          Anteroposterior " & txtOvarioDerechoAnteroPosterior.Text & " mm"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        If txtOvarioDerechoTransverso.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                TemporalY += 15
                Frase = "          Transverso " & txtOvarioDerechoTransverso.Text & " mm"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                TemporalY += 15
                Frase = "Medidas: "
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                TemporalY += 15
                Frase = "          Transverso " & txtOvarioDerechoTransverso.Text & " mm"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        '3ra linea de ovario DER: foliculos
        AnchoX = 0
        Frase = ""

        If txtOvarioDerechoFoliculo1.Text <> "" Then
            TemporalY += 15
            Frase = "Folículos dominantes: "
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
            TemporalY += 15
            Frase = "          folículo de " & txtOvarioDerechoFoliculo1.Text & " mm de diámetro"
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        If txtOvarioDerechoFoliculo2.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                TemporalY += 15
                Frase = "          folículo de " & txtOvarioDerechoFoliculo2.Text & " mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                TemporalY += 15
                Frase = "Folículos dominantes "
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                TemporalY += 15
                Frase = "          folículo de " & txtOvarioDerechoFoliculo2.Text & " mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        If txtOvarioDerechoFoliculo3.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                TemporalY += 15
                Frase = "          folículo de " & txtOvarioDerechoFoliculo3.Text & " mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                TemporalY += 15
                Frase = "Folículos dominantes "
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                TemporalY += 15
                Frase = "          folículo de " & txtOvarioDerechoFoliculo3.Text & " mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        If txtOvarioDerechoFoliculo4.Text <> "" Then
            If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                TemporalY += 15
                Frase = "          folículo de " & txtOvarioDerechoFoliculo4.Text & " mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            Else 'no se escribio nada en la parte anterior se debe empezar
                TemporalY += 15
                Frase = "Folículos dominantes "
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                TemporalY += 15
                Frase = "          folículo de " & txtOvarioDerechoFoliculo4.Text & " mm de diámetro"
                Gr.DrawString(Frase, TextoFont, Negro, InicioX, TemporalY)
                AnchoX = Gr.MeasureString(Frase, TextoFont).Width
            End If
        End If

        'escribe las lineas de obs de ovario DERECHO si las hay
        If txtGinOvarioDerechoObservaciones1.Text <> "" Then
            'hay algo escrito lo pone
            TemporalY += 15
            AnchoX = 0
            Frase = txtGinOvarioDerechoObservaciones1.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, TemporalY)
        End If

        If txtGinOvarioDerechoObservaciones2.Text <> "" Then
            'hay algo escrito lo pone
            TemporalY += 15
            AnchoX = 0
            Frase = txtGinOvarioDerechoObservaciones2.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, TemporalY)
        End If

        If txtGinOvarioDerechoObservaciones3.Text <> "" Then
            'hay algo escrito lo pone
            TemporalY += 15
            AnchoX = 0
            Frase = txtGinOvarioDerechoObservaciones3.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, TemporalY)
        End If

        If txtGinOvarioDerechoObservaciones4.Text <> "" Then
            'hay algo escrito lo pone
            TemporalY += 15
            AnchoX = 0
            Frase = txtGinOvarioDerechoObservaciones4.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, TemporalY)
        End If

        'ahora ve cual de las dos Y es mayor y la fija a inicio Y
        If InicioY < TemporalY Then
            'si se da el caso es q en el ovario der se escribio mas q en el izq y 
            'se toma el valor temporal como el nuevo inicio Y
            InicioY = TemporalY
        Else
            'si es mayor o igual inicio Y se deja igual
        End If

        'TROMPAS
        InicioY += 25
        InicioX = 0
        Frase = "TROMPAS UTERINAS."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        '1ra linea de TROMPAS: 
        AnchoX = 0
        Frase = ""
        If RadGinTrompas1.Checked = True Then
            InicioY += 15
            Frase = "No visualizables (NORMAL)"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinTrompas2.Checked = True Then
            InicioY += 15
            Frase = "Trompa izquierda distendida"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinTrompas3.Checked = True Then
            InicioY += 15
            Frase = "Trompa derecha distendida"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinTrompas4.Checked = True Then
            InicioY += 15
            Frase = "Trompas distendidas bilateralmente"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'escribe la linea lista de una sola vez si tiene algo q poner
        If AnchoX > 0 Then
            'se escribio algo lo pone
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If

        'escribe las lineas de obs de trompas si las hay
        If txtGinOtrosObservaciones1.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinOtrosObservaciones1.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If

        'DOUGLAS
        InicioY += 25
        Frase = "FONDO DE SACO DE DOUGLAS."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        '1ra linea de DOUGLAS: 
        AnchoX = 0
        Frase = ""
        If RadGinDouglas1.Checked = True Then
            InicioY += 15
            Frase = "Libre sin colecciones líquidas"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        ElseIf RadGinDouglas2.Checked = True Then
            InicioY += 15
            Frase = "Se visualiza nivel líquido"
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width
        End If

        'escribe la linea lista de una sola vez si tiene algo q poner
        If AnchoX > 0 Then
            'se escribio algo lo pone
            Gr.DrawString(Frase, TextoFont, Negro, InicioX, InicioY)
        End If

        'escribe las lineas de obs de trompas si las hay
        If txtGinOtrosObservaciones2.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinOtrosObservaciones2.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If


        'diagnostico
        InicioY += 25
        Frase = "IMPRESION DIAGNÓSTICA."
        AnchoX = Gr.MeasureString(Frase, SubtituloFont).Width
        Gr.DrawString(Frase, SubtituloFont, Negro, InicioX, InicioY)
        Gr.DrawLine(PenNegro, InicioX + AnchoX + 15, InicioY + 10, InicioX + 690, InicioY + 10)

        'escribe las lineas de idX si las hay
        If txtGinIDx1.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinIDx1.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If

        'escribe las lineas de idX si las hay
        If txtGinIDx2.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinIDx2.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If

        'escribe las lineas de idX si las hay
        If txtGinIDx3.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinIDx3.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If

        'escribe las lineas de idX si las hay
        If txtGinIDx4.Text <> "" Then
            'hay algo escrito lo pone
            InicioY += 15
            AnchoX = 0
            Frase = txtGinIDx4.Text
            Gr.DrawString(Frase, TextoFont, Negro, InicioX + AnchoX, InicioY)
        End If

    End Sub

    Private Sub botIMPRIME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botIMPRIME.Click

        'ajuste de pagina
        PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings
        PageSetupDialog1.PageSettings.Margins.Left = 200
        PageSetupDialog1.PageSettings.Margins.Right = 200
        PageSetupDialog1.PageSettings.Margins.Top = 200
        PageSetupDialog1.PageSettings.Margins.Bottom = 250
        If PageSetupDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
        Else
            Exit Sub
        End If

        'ajuste de impresora
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        Else
            Exit Sub
        End If

        'seleccion de membrete
        If chkImprimeMembrete.Checked = True Then
            booImprimeMembrete = True
            'comprueba q existan los datos del medico para poder imprimir el membrete
            If Form1.booExistenDatosDelUsuario = False Then
                'no hay datos 
                MsgBox("No se han intoducido los Datos del Usuario, para imprimir el membrete personalizado primero introduce los datos, El Informe saldrá sin Membrete...", MsgBoxStyle.Information, "Faltan Datos del Usuario")
            End If
        Else
            booImprimeMembrete = False
        End If

        'imprime el informe
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
    Handles PrintDocument1.PrintPage

        '=====================================
        Dim PenNegro As New Pen(Color.Black, 1)
        Dim PenNegro2 As New Pen(Color.Black, 2)
        Dim PenGris As New Pen(Color.Gray, 1)
        Dim Blanco As New SolidBrush(Color.White)
        Dim Clarito As New SolidBrush(Color.Snow)
        Dim Negro As New SolidBrush(Color.Black)
        Dim Naranja As New SolidBrush(Color.Orange)
        Dim Caqui As New SolidBrush(Color.Khaki)
        Dim Rojo As New SolidBrush(Color.Red)
        Dim Rojito As New SolidBrush(Color.MistyRose)
        Dim Azul As New SolidBrush(Color.Blue)
        Dim Azulito As New SolidBrush(Color.Lavender)
        Dim RectanguloTodo As New Rectangle(0, 0, 690, 925)
        Dim RectanguloGrafico As New Rectangle(50, 25, 400, 250)
        Dim SmallFont As New Font("Microsoft Sans Serif", 7)
        Dim TextoFont As New Font("Microsoft Sans Serif", 8)
        Dim SubtituloFont As New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
        Dim TituloFont As New Font("times new roman", 10, FontStyle.Bold)


        Dim AnchoX As Single
        Dim InicioX, InicioY As Single
        Dim RefX As Integer
        Dim RefY As Integer
        Dim Frase As String
        Dim Fuente As Font = TextoFont
        Dim Valor As Integer = 0 'esta var es para chequear anormalidades en los datos biometricos


        '====================================

        Dim pFont As Font
        Dim nombreFont As Font
        Dim otrosFont As Font
        Dim direccionFont As Font

        pFont = New Font("Lucida Console", 8)
        nombreFont = New Font("Times New Roman", 12, FontStyle.Italic)
        otrosFont = New Font("Times New Roman", 10, FontStyle.Italic)
        direccionFont = New Font("Times New Roman", 8, FontStyle.Italic)

        Dim Lmargin, Rmargin, Tmargin, Bmargin, pageHeight, pageWidth As Integer
        With PrintDocument1.DefaultPageSettings.Margins
            Lmargin = .Left
            Rmargin = .Right
            Tmargin = .Top
            Bmargin = .Bottom
        End With
        Dim PrintWidth, PrintHeight As Integer
        With PrintDocument1.DefaultPageSettings.PaperSize
            PrintWidth = .Width - Lmargin - Rmargin
            PrintHeight = .Height - Tmargin - Bmargin
            pageHeight = .Height
            pageWidth = .Width
        End With

        If PrintDocument1.DefaultPageSettings.Landscape = True Then
            With PrintDocument1.DefaultPageSettings.PaperSize
                PrintWidth = .Height - Rmargin - Lmargin
                PrintHeight = .Width - Tmargin - Bmargin
                Lmargin = PrintDocument1.DefaultPageSettings.Margins.Left
                Rmargin = PrintDocument1.DefaultPageSettings.Margins.Right
                Tmargin = PrintDocument1.DefaultPageSettings.Margins.Top
                Bmargin = PrintDocument1.DefaultPageSettings.Margins.Bottom
                pageHeight = .Width
                pageWidth = .Height
            End With
        End If

        IniciodeRecipeX = Lmargin
        IniciodeRecipeY = Tmargin + 100  'Deja lineas en blanco arriba para el encabezado del recipe
        AnchodeRecipe = PrintWidth
        FindeRecipeX = Lmargin + AnchodeRecipe
        FindeRecipeY = pageHeight - Bmargin - 50
        AltodeRecipe = FindeRecipeY - IniciodeRecipeY

        'inicializa el origen de los graficos en general
        InicioX = Lmargin
        InicioY = Tmargin

        '=====================================================
        'Coloca la imagen creada en la parte anterior que se va a imprimir tal cual
        'la linea siguiente ubica el bit map que genera elk sub sistema de graficos en la pag a imprimir
        'e.Graphics.DrawImage(BMP, Lmargin, Tmargin + 120)


        'aca deberia ir la parte de seleccion de los tres informes y crear la parte impresa

        'mira el tipo de informe que se esta imprimiendo
        If R.c00TipoDeEstudio = "1" Then                                            'Informe1erTrimestre()

            'titulo
            RefX = InicioX
            RefY = InicioY + 105
            e.Graphics.DrawLine(PenNegro2, RefX, RefY, 769, RefY)


            Frase = "ESTUDIO ULTRASONOGRAFICO DEL 1er TRIMESTRE"
            AnchoX = e.Graphics.MeasureString(Frase, TituloFont).Width
            RefX = 425 - (AnchoX \ 2)
            RefY += 5
            e.Graphics.DrawString(Frase, TituloFont, Negro, RefX, RefY)

            RefX = InicioX
            RefY += 15
            e.Graphics.DrawLine(PenNegro2, RefX, RefY, 769, RefY)

            'fecha

            Frase = "Fecha del Estudio: " & txtFechaInicioControl.Text
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            RefX = 769 - (AnchoX)
            RefY += 15
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            'nombre de la pte
            Frase = "Nombre: " & txtNombrePaciente.Text.ToUpper & ". "
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            RefX = InicioX
            RefY += 20
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            'edad si se sabe
            If IsNumeric(txtEdad1erT.Text) Then
                Frase = txtEdad1erT.Text & " años. "
                RefX = RefX + AnchoX  'este es el ancho del nombre para iniciar la edad
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            End If
            'paridad si la tiene
            If txtParidad1erT.Text <> "" Then
                Frase = txtParidad1erT.Text & "."
                RefX = RefX + AnchoX
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            End If

            'fur y fpp
            RefX = InicioX
            RefY += 15
            Frase = "Fecha de última regla: " & labFUR1erT.Text & "."
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            RefX = InicioX
            RefY += 15
            Frase = "Fecha probable de parto x FUR: " & labFPP1erT.Text & "."
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            RefX = InicioX
            RefY += 15
            Frase = "Edad Gestacional x FUR: " & lab1ertEGxFUR01.Text
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            'tipo de estudio y frecuencia
            RefX = InicioX
            RefY += 15
            Frase = "Estudio Ecográfico realizado con trasductor "
            If rad1erTestudioTV.Checked = True Then
                Frase += "Trasvaginal "
            ElseIf rad1erTEstudioAbd.Checked = True Then
                Frase += "Transabdominal "
            End If
            Frase += "con una frecuencia de "
            If rad1erTfrec35.Checked = True Then
                Frase += "3.5 MHz."
            ElseIf rad1erTfrec50.Checked = True Then
                Frase += "5.0 MHz."
            ElseIf rad1erTfrec75.Checked = True Then
                Frase += "7.5 MHz."
            End If
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            'datos anatomicos
            RefX = InicioX
            RefY += 20
            Frase = "DATOS ANATOMICOS."
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            'liniecita sin alterar referencias
            e.Graphics.DrawLine(PenNegro, RefX + AnchoX + 10, RefY + 11, 769, RefY + 11)

            '1ra linea: anatomia de la vejiga
            If rad1erTVejiga01.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "VEJIGA: llena, adecuada para el estudio."
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            ElseIf rad1erTVejiga02.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "VEJIGA: vacía, adecuada para el estudio."
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            '2da linea....>
            AnchoX = 0
            'Tipo de embarazo simple o gemelar
            If rad1erTtipoEmbarazo01.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "EMBARAZO: Simple"
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            ElseIf rad1erTtipoEmbarazo02.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "EMBARAZO: Gemelar"
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            End If

            'localizacion del embarazo
            If rad1erTLocalizacionEmbarazo01.Checked = True Then
                If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                    Frase = ", intrauterino."
                    RefX += AnchoX
                    'refY es igual...
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                Else 'no se escribio nada en tipo de embarazo
                    Frase = "EMBARAZO: Intrauterino."
                    RefX = InicioX
                    RefY += 15
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            ElseIf rad1erTlocalizacionEmbarazo02.Checked = True Then
                If AnchoX > 0 Then 'se escribio algo en tipo de embarazo
                    Frase = ", extratrauterino."
                    RefX = InicioX + AnchoX
                    'RefY=igual
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                Else 'no se escribio nada en tipo de embarazo
                    Frase = "EMBARAZO: Extrauterino."
                    RefX = InicioX
                    RefY += 15
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            Else
                If AnchoX > 0 Then
                    'se escribio algo en la primera parte y nada aca le pone punto si no no hace nada
                    Frase = "."
                    RefX = InicioX + AnchoX
                    'refy es igual
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            End If

            '3ra linea posible
            AnchoX = 0
            'saco gestacional
            If rad1erTsacoGestacional01.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "SACO GESTACIONAL: Visible"
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            ElseIf rad1erTsacoGestacional02.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "SACO GESTACIONAL: NO Visible."
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            End If

            'implantacion
            If Rad1erTImplantacion1.Checked = True Then
                If AnchoX > 0 Then 'se escribio algo en la linea
                    Frase = ", IMPLANTACION: anterior."
                    RefX += AnchoX
                    'refy es igual
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                Else  'no se escribio nada aun en la linea
                    RefX = InicioX
                    RefY += 15
                    Frase = "IMPLANTACION: anterior."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            ElseIf Rad1erTImplantacion2.Checked = True Then
                If AnchoX > 0 Then 'se escribio algo en la linea
                    Frase = ", IMPLANTACION: posterior."
                    RefX += AnchoX
                    'refy es igual
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                Else  'no se escribio nada aun en la linea
                    RefX = InicioX
                    RefY += 15
                    Frase = "IMPLANTACION: posterior."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            ElseIf Rad1erTImplantacion3.Checked = True Then
                If AnchoX > 0 Then 'se escribio algo en la linea
                    Frase = ", IMPLANTACION: fúndica."
                    RefX += AnchoX
                    'refy es igual
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                Else  'no se escribio nada aun en la linea
                    RefX = InicioX
                    RefY += 15
                    Frase = "IMPLANTACION: fúndica."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            ElseIf Rad1erTImplantacion4.Checked = True Then
                If AnchoX > 0 Then 'se escribio algo en la linea
                    Frase = ", IMPLANTACION: baja."
                    RefX += AnchoX
                    'refy es igual
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                Else  'no se escribio nada aun en la linea
                    RefX = InicioX
                    RefY += 15
                    Frase = "IMPLANTACION: baja."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            Else
                If AnchoX > 0 Then 'se escribio algo en la linea
                    Frase = "."
                    RefX += AnchoX
                    'refy es igual
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            End If

            '4ta linea posible
            AnchoX = 0
            'vesicula vitelina
            If rad1erTVitelina01.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "VESICULA VITELINA: Visible."
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            ElseIf rad1erTVitelina02.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "VESICULA VITELINA: No visible."
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            End If

            'EMBRION
            If Rad1erTEmbrion1.Checked = True Then
                If AnchoX > 0 Then 'se escribio algo en la linea
                    RefX += AnchoX 'refy es igual
                    Frase = " EMBRION: Visible."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                Else 'no se escribio nada en la linea
                    RefX = InicioX
                    RefY += 15
                    Frase = "EMBRION: Visible."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            ElseIf Rad1erTEmbrion2.Checked = True Then
                If AnchoX > 0 Then 'se escribio algo en la linea
                    RefX += AnchoX 'refy es igual
                    Frase = " EMBRION: No visible."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                Else 'no se escribio nada en la linea
                    RefX = InicioX
                    RefY += 15
                    Frase = "EMBRION: No visible."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
                'no le pongo el else del punto porque ambos tienen su punto ya puesto...
            End If

            '5ta linea posible
            AnchoX = 0
            'movimientos corporales
            If Rad1erTMovimientos1.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "MOVIMIENTOS CORPORALES: Visibles."
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            ElseIf Rad1erTMovimientos2.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "MOVIMIENTOS CORPORALES: No visibles."
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            End If

            'actividad cardiaca
            If Rad1erTActCardiaca1.Checked = True Then
                If AnchoX > 0 Then 'se escribio algo en la linea
                    RefX += AnchoX 'refy es igual
                    Frase = " ACTIVIDAD CARDIACA: Visible."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                Else 'no se escribio nada en la linea
                    RefX = InicioX
                    RefY += 15
                    Frase = "ACTIVIDAD CARDIACA: Visible."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            ElseIf Rad1erTActCardiaca2.Checked = True Then
                If AnchoX > 0 Then 'se escribio algo en la linea
                    RefX += AnchoX 'refy es igual
                    Frase = " ACTIVIDAD CARDIACA: No visible."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                Else 'no se escribio nada en la linea
                    RefX = InicioX
                    RefY += 15
                    Frase = "ACTIVIDAD CARDIACA: No visible."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
                'no le pongo el else del punto porque ambos tienen su punto ya puesto...
            End If

            'PARTE DE LOS PERINATOLOGICOS
            Dim SePusoElTituloYa As Boolean = False
            AnchoX = 0
            If rad1erTtranslucencia01.Checked = True Or rad1erTtranslucencia02.Checked = True Then

                'se puso algo en la translucencia pone el titulo de la seccion
                RefY += 20
                RefX = InicioX
                Frase = "ECOPATRON GENETICO."
                AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

                'la linea de separacion ojo no altero refy para no traslocar las lineas se lo añado directo en la linea de escritura
                RefX += AnchoX + 10
                e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)
                SePusoElTituloYa = True

                'la traslucencia
                RefX = InicioX
                RefY += 15
                If rad1erTtranslucencia01.Checked = True Then
                    Frase = "TRANSLUCENCIA NUCAL: Normal ( < 3mm )."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                ElseIf rad1erTtranslucencia02.Checked = True Then
                    Frase = "TRANSLUCENCIA NUCAL: Anormal ( > 3mm )."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If

            End If

            AnchoX = 0
            If rad1erThuesosNasales01.Checked = True Or rad1erThuesosNasales02.Checked = True Then
                'se puso algo en los huesos nasales
                If SePusoElTituloYa = False Then 'no se ha puesto el titulo, lo pone
                    RefY += 20
                    RefX = InicioX
                    Frase = "ECOPATRON GENETICO."
                    AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
                    e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

                    'la linea de separacion ojo no altero refy para no traslocar las lineas se lo añado directo en la linea de escritura
                    RefX += AnchoX + 10
                    e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)
                    SePusoElTituloYa = True

                End If

                'los huesos nasales
                RefY += 15
                RefX = InicioX
                If rad1erThuesosNasales01.Checked = True Then
                    Frase = "HUESOS NASALES: Presentes ( Normal )."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                ElseIf rad1erThuesosNasales02.Checked = True Then
                    Frase = "HUESOS NASALES: No visibles ( Anormal )."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If

            End If

            AnchoX = 0
            If rad1erTanguloFM01.Checked = True Or rad1erTanguloFM02.Checked = True Then
                'se puso algo en el angulo frontomaxilar
                If SePusoElTituloYa = False Then 'no se ha puesto el titulo, lo pone
                    RefY += 20
                    RefX = InicioX
                    Frase = "ECOPATRON GENETICO."
                    AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
                    e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

                    'la linea de separacion ojo no altero refy para no traslocar las lineas se lo añado directo en la linea de escritura
                    RefX += AnchoX + 10
                    e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)
                    SePusoElTituloYa = True
                End If

                'fronto maxilar
                RefY += 15
                RefX = InicioX
                If rad1erTanguloFM01.Checked = True Then
                    Frase = "ANGULO FRONTO-MAXILAR: Normal ( < 95 grados )."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                ElseIf rad1erTanguloFM02.Checked = True Then
                    Frase = "ANGULO FRONTO-MAXILAR: Anormal ( > 95 grados )."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            End If

            AnchoX = 0
            If rad1erTductusVenoso01.Checked = True Or rad1erTductusVenoso02.Checked = True Then
                'se puso algo en el ductus venoso
                If SePusoElTituloYa = False Then 'no se ha puesto el titulo, lo pone
                    RefY += 20
                    RefX = InicioX
                    Frase = "ECOPATRON GENETICO."
                    AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
                    e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

                    'la linea de separacion ojo no altero refy para no traslocar las lineas se lo añado directo en la linea de escritura
                    RefX += AnchoX + 10
                    e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)
                    SePusoElTituloYa = True
                End If

                'ductus (hasta q no compre el doppler no tiene sentido aca)
                RefX = InicioX
                RefY += 15
                If rad1erTductusVenoso01.Checked = True Then
                    Frase = "DUCTUS VENOSO: Normal."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                ElseIf rad1erTductusVenoso02.Checked = True Then
                    Frase = "DUCTUS VENOSO: Anormal."
                    e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                End If
            End If

            'DATOS BIOMETRICOS
            RefY += 20
            RefX = InicioX
            Frase = "DATOS BIOMETRICOS."
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            'linea de separacion
            RefX += AnchoX + 10 'la ref y no la altero la pongo directo en absoluto en la linea
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            'referencias de inicio de la tabla de biometria
            RefX = InicioX
            RefY += 20

            'lineas de la tabla horizontales
            e.Graphics.DrawLine(PenNegro2, RefX, RefY + 0, RefX + 552, RefY + 0)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 20, RefX + 552, RefY + 20)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 40, RefX + 552, RefY + 40)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 60, RefX + 552, RefY + 60)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 80, RefX + 552, RefY + 80)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 100, RefX + 552, RefY + 100)
            e.Graphics.DrawLine(PenNegro2, RefX, RefY + 120, RefX + 552, RefY + 120)

            'lineas verticales de la tabla
            e.Graphics.DrawLine(PenNegro2, RefX + 1, RefY + 0, RefX + 1, RefY + 120)
            e.Graphics.DrawLine(PenNegro, RefX + 238, RefY + 0, RefX + 238, RefY + 120)
            e.Graphics.DrawLine(PenNegro2, RefX + 276, RefY + 0, RefX + 276, RefY + 120)
            e.Graphics.DrawLine(PenNegro, RefX + 514, RefY + 0, RefX + 514, RefY + 120)
            e.Graphics.DrawLine(PenNegro2, RefX + 552, RefY + 0, RefX + 552, RefY + 120)

            'encabezados de tabla 1ra columna
            e.Graphics.DrawString("Saco Gestacional Longitudinal(mm)", TextoFont, Negro, RefX + 2, RefY + 5)
            e.Graphics.DrawString("Saco Gestacional Anteroposterior(mm)", TextoFont, Negro, RefX + 2, RefY + 25)
            e.Graphics.DrawString("Saco Gestacional Transversal(mm)", TextoFont, Negro, RefX + 2, RefY + 45)
            e.Graphics.DrawString("Vesícula Vitelina Longitudinal(mm)", TextoFont, Negro, RefX + 2, RefY + 65)
            e.Graphics.DrawString("Vesícula Vitelina Anteroposterior(mm)", TextoFont, Negro, RefX + 2, RefY + 85)
            e.Graphics.DrawString("Longitud Craneo-Caudal(mm)", TextoFont, Negro, RefX + 2, RefY + 105)

            'encabezados 2da columna
            e.Graphics.DrawString("Diámetro Biparietal(mm)", TextoFont, Negro, RefX + 278, RefY + 5)
            e.Graphics.DrawString("Circunferencia Cefálica(mm)", TextoFont, Negro, RefX + 278, RefY + 25)
            e.Graphics.DrawString("Circunferencia Abdominal(mm)", TextoFont, Negro, RefX + 278, RefY + 45)
            e.Graphics.DrawString("Fémur(mm)", TextoFont, Negro, RefX + 278, RefY + 65)
            e.Graphics.DrawString("Translucencia Nucal(mm)", TextoFont, Negro, RefX + 278, RefY + 85)

            'partes de datos en la primera columna
            e.Graphics.DrawString(txt1erSGlong.Text, TextoFont, Negro, RefX + 240, RefY + 5)
            e.Graphics.DrawString(txt1erSGantPost.Text, TextoFont, Negro, RefX + 240, RefY + 25)
            e.Graphics.DrawString(txt1erSGtrans.Text, TextoFont, Negro, RefX + 240, RefY + 45)
            e.Graphics.DrawString(txt1erVVlong.Text, TextoFont, Negro, RefX + 240, RefY + 65)
            e.Graphics.DrawString(txt1erVVantPost.Text, TextoFont, Negro, RefX + 240, RefY + 85)
            e.Graphics.DrawString(txt1erLCC.Text, TextoFont, Negro, RefX + 240, RefY + 105)

            'partes de datos en la segunda columna
            e.Graphics.DrawString(txt1erDBP.Text, TextoFont, Negro, RefX + 516, RefY + 5)
            e.Graphics.DrawString(txt1erCC.Text, TextoFont, Negro, RefX + 516, RefY + 25)
            e.Graphics.DrawString(txt1erCA.Text, TextoFont, Negro, RefX + 516, RefY + 45)
            e.Graphics.DrawString(txt1erFemur.Text, TextoFont, Negro, RefX + 516, RefY + 65)
            e.Graphics.DrawString(txt1erTN.Text, TextoFont, Negro, RefX + 516, RefY + 85)

            'variable local para saber si se escribieron observaciones...
            Dim booHayObservaciones As Boolean = False

            'Observaciones
            If txt1erTComentarios01.Text <> "" Or txt1erTcomentarios02.Text <> "" Or txt1erTcomentarios03.Text <> "" Or txt1erTcomentarios04.Text <> "" Or txt1erTcomentarios05.Text <> "" Then

                RefY += 140
                RefX = InicioX
                Frase = "OBSERVACIONES."
                AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
                'linea de separacion
                RefX += AnchoX + 10
                e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

                'prende la bandera
                booHayObservaciones = True

            End If

            '1ra linea
            If txt1erTComentarios01.Text <> "" Then 'hay algo escrito en la linea
                RefY += 15
                RefX = InicioX
                Frase = txt1erTComentarios01.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If
            '2da linea
            If txt1erTcomentarios02.Text <> "" Then 'hay algo escrito en la linea
                RefY += 15
                RefX = InicioX
                Frase = txt1erTcomentarios02.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If
            '3ra linea
            If txt1erTcomentarios03.Text <> "" Then 'hay algo escrito en la linea
                RefY += 15
                RefX = InicioX
                Frase = txt1erTcomentarios03.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If
            '4ta linea
            If txt1erTcomentarios04.Text <> "" Then 'hay algo escrito en la linea
                RefY += 15
                RefX = InicioX
                Frase = txt1erTcomentarios04.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If
            '5ta linea
            If txt1erTcomentarios05.Text <> "" Then 'hay algo escrito en la linea
                RefY += 15
                RefX = InicioX
                Frase = txt1erTcomentarios05.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If


            'IDx

            If booHayObservaciones = True Then
                'se puso algo en observaciones solo baja 20
                RefY += 20
                RefX = InicioX
                Frase = "IMPRESION DIAGNOSTICA."
                AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

                RefX += AnchoX + 10
                e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            Else
                'no se pusieron observaciones hay q baja 90
                RefY += 140
                RefX = InicioX
                Frase = "IMPRESION DIAGNOSTICA."
                AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

                RefX += AnchoX + 10
                e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            End If


            '1RA LINEA
            RefY += 15
            RefX = InicioX
            Frase = "EDAD GESTACIONAL x FUR: " & lab1ertEGxFUR02.Text
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            '2DA LINEA
            RefY += 15
            RefX = InicioX
            Frase = "EDAD GESTACIONAL x ECO: " & txt1erEGxECO.Text
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            '3ra linea
            If txt1erTidx01.Text <> "" Then 'hay algo escrito en la linea
                RefY += 15
                RefX = InicioX
                Frase = txt1erTidx01.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If
            '4ta linea
            If txt1erTidx02.Text <> "" Then 'hay algo escrito en la linea
                RefY += 15
                RefX = InicioX
                Frase = txt1erTidx02.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If
            '5ta linea
            If txt1erTidx03.Text <> "" Then 'hay algo escrito en la linea
                RefY += 15
                RefX = InicioX
                Frase = txt1erTidx03.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'mensaje final
            RefX = InicioX
            RefY = 981
            e.Graphics.DrawLine(PenNegro, RefX, RefY, 769, RefY)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 40, 769, RefY + 40)
            e.Graphics.DrawLine(PenNegro, RefX, RefY, RefX, RefY + 40)
            e.Graphics.DrawLine(PenNegro, 769, RefY, 769, RefY + 40)

            Frase = "ADVERTENCIA: En ausencia de marcadores, el ultrasonido posee muy poca sensibilidad diagnóstica para alteraciones cromosómicas"
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX + 1, RefY + 5)
            Frase = "y la integridad anatómica del feto no excluye la existencia de alguna de ellas."
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX + 1, RefY + 20)



        ElseIf R.c00TipoDeEstudio = "2" Then                               'Informe2y3erTrimestre()

            'titulo
            RefX = InicioX
            RefY = InicioY + 105
            e.Graphics.DrawLine(PenNegro2, RefX, RefY, 769, RefY)


            Frase = "ESTUDIO ULTRASONOGRAFICO DEL 2do y 3er TRIMESTRE"
            AnchoX = e.Graphics.MeasureString(Frase, TituloFont).Width
            RefX = 425 - (AnchoX \ 2)
            RefY += 5
            e.Graphics.DrawString(Frase, TituloFont, Negro, RefX, RefY)

            RefX = InicioX
            RefY += 15
            e.Graphics.DrawLine(PenNegro2, RefX, RefY, 769, RefY)

            'fecha

            Frase = "Fecha del Estudio: " & txtFechaInicioControl.Text
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            RefX = 769 - (AnchoX)
            RefY += 15
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            'nombre de la pte
            Frase = "Nombre: " & txtNombrePaciente.Text.ToUpper & ". "
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            RefX = InicioX
            RefY += 20
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            'edad si se sabe
            If IsNumeric(txtEdad2y3erT.Text) Then
                Frase = txtEdad2y3erT.Text & " años. "
                RefX = RefX + AnchoX  'este es el ancho del nombre para iniciar la edad
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            End If
            'paridad si la tiene
            If txtParidad2y3erT.Text <> "" Then
                Frase = txtParidad2y3erT.Text & "."
                RefX = RefX + AnchoX
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            End If


            'fur y fpp
            RefX = InicioX
            RefY += 15
            Frase = "FUR: " & labFUR2y3erT.Text & ".   Fecha probable de parto x FUR: " & labFPP2y3erT.Text & ".   EG x FUR: " & labEGxFUR2y3erT.Text
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)


            'datos Obstetricos
            RefX = InicioX
            RefY += 20
            Frase = "Datos Obstétricos"
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'no altero la refy para no traslocar las lineas le pongo directo...
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            'EMBARAZO INTRA O EXTRAUTERINO
            RefX = InicioX
            RefY += 15
            Frase = "Embarazo "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY) 'solo la palabra embarazo
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            If radEmbarazo01.Checked = True Then
                Frase = "INTRAUTERINO"
                Fuente = TextoFont
            ElseIf radEmbarazo02.Checked = True Then
                Frase = "EXTRAUTERINO"
                Fuente = SubtituloFont
            End If
            RefX += AnchoX 'la misma refy
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'SITUACION
            RefX = InicioX + 230 'la misma refy
            Frase = "Situación "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY) 'solo la palabra situacion
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            If radSituacion1.Checked = True Then
                Frase = "LONGITUDINAL"
                Fuente = TextoFont
            ElseIf radSituacion2.Checked = True Then
                Frase = "OBLICUA"
                Fuente = SubtituloFont
            ElseIf radSituacion3.Checked = True Then
                Frase = "TRANSVERSA"
                Fuente = SubtituloFont
            End If
            RefX += AnchoX 'la misma refy
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'Posicion
            RefX = InicioX + 460 'la misma refy
            If radPosicion1.Checked = True Then
                Frase = "Posición ANTERIOR"
            ElseIf radPosicion2.Checked = True Then
                Frase = "Posición POSTERIOR"
            ElseIf radPosicion3.Checked = True Then
                Frase = "Posición DERECHA ANTERIOR"
            ElseIf radPosicion4.Checked = True Then
                Frase = "Posición IZQUIERDA ANTERIOR"
            ElseIf radPosicion5.Checked = True Then
                Frase = "Posición IZQUIERDA TRANSVERSA"
            ElseIf radPosicion6.Checked = True Then
                Frase = "Posición IZQUIERDA POSTERIOR"
            ElseIf radPosicion7.Checked = True Then
                Frase = "Posición DERECHA TRANSVERSA"
            ElseIf radPosicion8.Checked = True Then
                Frase = "Posición DERECHA POSTERIOR"
            End If
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            'FETO UNICO O GEMELAR
            RefX = InicioX
            RefY += 15
            Frase = "Feto "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY) 'solo la palabra feto
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            If radFeto01.Checked = True Then
                Frase = "UNICO"
                Fuente = TextoFont
            ElseIf radFeto02.Checked = True Then
                Frase = "GEMELAR"
                Fuente = SubtituloFont
            End If
            RefX += AnchoX 'la misma refy
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'PRESENTACION
            RefX = InicioX + 230 'la misma refy
            Frase = "Presentación "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY) 'solo la palabra presentación
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            If radPresentacion1.Checked = True Then
                Frase = "CEFALICA"
                Fuente = TextoFont
            ElseIf radPresentacion2.Checked = True Then
                Frase = "PODALICA"
                Fuente = SubtituloFont
            ElseIf radpresentacion3.Checked = True Then
                Frase = "N/A"
                Fuente = SubtituloFont
            End If
            RefX += AnchoX 'la misma refy
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY) 'pone el otro pedazo normal o negrita

            'datos Biometricos
            RefX = InicioX
            RefY += 20
            Frase = "Datos Biométricos"
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'no altero la refy para no traslocar las lineas le pongo directo...
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)


            'referencias de inicio de la tabla de biometria
            RefX = InicioX
            RefY += 20

            'lineas de la tabla horizontales
            e.Graphics.DrawLine(PenNegro2, RefX, RefY + 0, RefX + 690, RefY + 0)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 20, RefX + 690, RefY + 20)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 40, RefX + 690, RefY + 40)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 60, RefX + 690, RefY + 60)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 80, RefX + 690, RefY + 80)
            e.Graphics.DrawLine(PenNegro2, RefX, RefY + 100, RefX + 690, RefY + 100)
            'lineas verticales de la tabla
            e.Graphics.DrawLine(PenNegro2, RefX + 1, RefY + 0, RefX + 1, RefY + 100)
            e.Graphics.DrawLine(PenNegro, RefX + 100, RefY + 0, RefX + 100, RefY + 100)
            e.Graphics.DrawLine(PenNegro2, RefX + 138, RefY + 0, RefX + 138, RefY + 100)
            e.Graphics.DrawLine(PenNegro, RefX + 238, RefY + 0, RefX + 238, RefY + 100)
            e.Graphics.DrawLine(PenNegro2, RefX + 276, RefY + 0, RefX + 276, RefY + 100)
            e.Graphics.DrawLine(PenNegro, RefX + 376, RefY + 0, RefX + 376, RefY + 100)
            e.Graphics.DrawLine(PenNegro2, RefX + 414, RefY + 0, RefX + 414, RefY + 100)
            e.Graphics.DrawLine(PenNegro, RefX + 514, RefY + 0, RefX + 514, RefY + 100)
            e.Graphics.DrawLine(PenNegro2, RefX + 552, RefY + 0, RefX + 552, RefY + 100)
            e.Graphics.DrawLine(PenNegro, RefX + 652, RefY + 0, RefX + 652, RefY + 100)
            e.Graphics.DrawLine(PenNegro2, RefX + 689, RefY + 0, RefX + 689, RefY + 100)

            'encabezados de tabla 1ra columna
            e.Graphics.DrawString("Biparietal(mm)", TextoFont, Negro, RefX + 2, RefY + 5)
            e.Graphics.DrawString("O.Frontal(mm)", TextoFont, Negro, RefX + 2, RefY + 25)
            e.Graphics.DrawString("C.Cefálica(mm)", TextoFont, Negro, RefX + 2, RefY + 45)
            e.Graphics.DrawString("T.Cerebelo(mm)", TextoFont, Negro, RefX + 2, RefY + 65)
            e.Graphics.DrawString("Atrio (mm)", TextoFont, Negro, RefX + 2, RefY + 85)
            'encabezados 2da columna
            e.Graphics.DrawString("IO.Externo(mm)", TextoFont, Negro, RefX + 140, RefY + 5)
            e.Graphics.DrawString("IO.Interno(mm)", TextoFont, Negro, RefX + 140, RefY + 25)
            e.Graphics.DrawString("PliegueNucal(mm)", TextoFont, Negro, RefX + 140, RefY + 45)
            e.Graphics.DrawString("AP.Cardíaco(mm)", TextoFont, Negro, RefX + 140, RefY + 65)
            e.Graphics.DrawString("AP.Tórax(mm)", TextoFont, Negro, RefX + 140, RefY + 85)
            'encabezados 3ra columna
            e.Graphics.DrawString("Aorta(mm)", TextoFont, Negro, RefX + 278, RefY + 5)
            e.Graphics.DrawString("T.Abdomen(mm)", TextoFont, Negro, RefX + 278, RefY + 25)
            e.Graphics.DrawString("C.Abdominal(mm)", TextoFont, Negro, RefX + 278, RefY + 45)
            e.Graphics.DrawString("Fémur(mm)", TextoFont, Negro, RefX + 278, RefY + 65)
            e.Graphics.DrawString("Tibia(mm)", TextoFont, Negro, RefX + 278, RefY + 85)
            'encabezados 4ta columna
            e.Graphics.DrawString("Húmero(mm)", TextoFont, Negro, RefX + 416, RefY + 5)
            e.Graphics.DrawString("Ulna(mm)", TextoFont, Negro, RefX + 416, RefY + 25)
            e.Graphics.DrawString("Sacro(mm)", TextoFont, Negro, RefX + 416, RefY + 45)
            e.Graphics.DrawString("NOD.Fémur(mm)", TextoFont, Negro, RefX + 416, RefY + 65)
            e.Graphics.DrawString("NOP.Tibia(mm)", TextoFont, Negro, RefX + 416, RefY + 85)
            'encabezados 5ta columna
            e.Graphics.DrawString("NOP.Húmero(mm)", TextoFont, Negro, RefX + 554, RefY + 5)
            e.Graphics.DrawString("BPF(mm)", TextoFont, Negro, RefX + 554, RefY + 25)
            e.Graphics.DrawString("Peso(gr)", TextoFont, Negro, RefX + 554, RefY + 45)
            e.Graphics.DrawString("Talla(cm)", TextoFont, Negro, RefX + 554, RefY + 65)
            e.Graphics.DrawString("", TextoFont, Negro, RefX + 554, RefY + 85)

            'rellena los datos existentes 1ra columna
            e.Graphics.DrawString(txtDBP.Text, TextoFont, Negro, RefX + 102, RefY + 5)
            e.Graphics.DrawString(txtDOF.Text, TextoFont, Negro, RefX + 102, RefY + 25)
            e.Graphics.DrawString(txtCC.Text, TextoFont, Negro, RefX + 102, RefY + 45)
            e.Graphics.DrawString(txtTCer.Text, TextoFont, Negro, RefX + 102, RefY + 65)
            If IsNumeric(txtAtrio.Text) Then
                Valor = CType(txtAtrio.Text, Integer)
                If Valor >= 10 Then
                    Fuente = TituloFont
                Else
                    Fuente = TextoFont
                End If
                e.Graphics.DrawString(txtAtrio.Text, Fuente, Negro, RefX + 102, RefY + 85)
            End If
            'rellena los datos existentes 2da columna
            e.Graphics.DrawString(txtIOE.Text, TextoFont, Negro, RefX + 240, RefY + 5)
            e.Graphics.DrawString(txtIOI.Text, TextoFont, Negro, RefX + 240, RefY + 25)
            If IsNumeric(txtPN.Text) Then
                Valor = CType(txtPN.Text, Integer)
                If Valor >= 6 Then
                    Fuente = TituloFont
                Else
                    Fuente = TextoFont
                End If
                e.Graphics.DrawString(txtPN.Text, Fuente, Negro, RefX + 240, RefY + 45)
            End If
            e.Graphics.DrawString(txtAPC.Text, TextoFont, Negro, RefX + 240, RefY + 65)
            e.Graphics.DrawString(txtAPT.Text, TextoFont, Negro, RefX + 240, RefY + 85)
            'rellena los datos existentes 3ra columna
            e.Graphics.DrawString(txtAorta.Text, TextoFont, Negro, RefX + 378, RefY + 5)
            e.Graphics.DrawString(txtTransAbdomen.Text, TextoFont, Negro, RefX + 378, RefY + 25)
            e.Graphics.DrawString(txtCA.Text, TextoFont, Negro, RefX + 378, RefY + 45)
            e.Graphics.DrawString(txtFemur.Text, TextoFont, Negro, RefX + 378, RefY + 65)
            e.Graphics.DrawString(txtTibia.Text, TextoFont, Negro, RefX + 378, RefY + 85)
            'rellena los datos existentes 4ta columna
            e.Graphics.DrawString(txtHumero.Text, TextoFont, Negro, RefX + 516, RefY + 5)
            e.Graphics.DrawString(txtUlna.Text, TextoFont, Negro, RefX + 516, RefY + 25)
            e.Graphics.DrawString(txtSacro.Text, TextoFont, Negro, RefX + 516, RefY + 45)
            e.Graphics.DrawString(txtNODF.Text, TextoFont, Negro, RefX + 516, RefY + 65)
            e.Graphics.DrawString(txtNOPT.Text, TextoFont, Negro, RefX + 516, RefY + 85)
            'rellena los datos existentes 5ta columna
            e.Graphics.DrawString(txtNOPH.Text, TextoFont, Negro, RefX + 654, RefY + 5)
            e.Graphics.DrawString(txtBPF.Text, TextoFont, Negro, RefX + 654, RefY + 25)
            e.Graphics.DrawString(txtPeso.Text, TextoFont, Negro, RefX + 654, RefY + 45)
            e.Graphics.DrawString(txtTalla.Text, TextoFont, Negro, RefX + 654, RefY + 65)

            'datos anatomicos
            RefX = InicioX
            RefY += 110
            Frase = "Datos Anatómicos"
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'no altero la refy para no traslocar las lineas le pongo directo...
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            'POLO CEFALICO
            RefX = InicioX
            RefY += 15
            Frase = "Polo Cefálico "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX 'la misma y
            If radCabeza1.Checked = True Then
                Frase = "NORMAL"
                Fuente = TextoFont
            ElseIf radCabeza2.Checked = True Then
                Frase = "ANORMAL"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'EXTREMIDADES
            RefX = InicioX + 225 'la misma y
            Frase = "Extremidades "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX 'la misma y
            If radExtremidades1.Checked = True Then
                Frase = "COMPLETAS"
                Fuente = TextoFont
            ElseIf radExtremidades2.Checked = True Then
                Frase = "ANORMALES"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'RIÑONES
            RefX = InicioX + 455 'la misma y
            Frase = "Riñones "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX 'la misma y
            If radRiñones1.Checked = True Then
                Frase = "NORMALES"
                Fuente = TextoFont
            ElseIf radRiñones2.Checked = True Then
                Frase = "ANORMALES"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)


            'VENTRICULOS CEREBRALES
            RefX = InicioX
            RefY += 15
            Frase = "Ventrículos Cerebrales "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX 'la misma y
            If radVentriculo1.Checked = True Then
                Frase = "NORMALES"
                Fuente = TextoFont
            ElseIf radVentriculo2.Checked = True Then
                Frase = "ANORMALES"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'TORAX
            RefX = InicioX + 225 'la misma y
            Frase = "Tórax "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX 'la misma y
            If radTorax1.Checked = True Then
                Frase = "NORMAL"
                Fuente = TextoFont
            ElseIf radTorax2.Checked = True Then
                Frase = "ANORMAL"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'SEXO
            RefX = InicioX + 455 'la misma y
            Frase = "Sexo "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX 'la misma y
            If radSexo1.Checked = True Then
                Frase = "MASCULINO"
                Fuente = TextoFont
            ElseIf radSexo2.Checked = True Then
                Frase = "FEMENINO"
                Fuente = TextoFont
            Else
                Frase = "NO ACCESIBLE"
                Fuente = TextoFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'ROSTRO
            RefX = InicioX
            RefY += 15
            Frase = "Rostro "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = Gr.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radRostro1.Checked = True Then
                Frase = "SIN FISURAS"
                Fuente = TextoFont
            ElseIf radRostro2.Checked = True Then
                Frase = "ANORMAL"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'CORAZON
            RefX = InicioX + 225 'la misma y
            Frase = "Corazón "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radCorazon1.Checked = True Then
                Frase = "NORMAL"
                Fuente = TextoFont
            ElseIf radCorazon2.Checked = True Then
                Frase = "ANORMAL"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'COLUMNA VERTEBRAL
            RefX = InicioX
            RefY += 15
            Frase = "Columna Vertebral "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX 'la misma y
            If radColumna1.Checked = True Then
                Frase = "NORMAL"
                Fuente = TextoFont
            ElseIf radColumna2.Checked = True Then
                Frase = "ANORMAL"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'ABDOMEN
            RefX = InicioX + 225 'la misma y
            Frase = "Abdomen "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX 'la misma y
            If radAbdomen1.Checked = True Then
                Frase = "NORMAL"
                Fuente = TextoFont
            ElseIf radAbdomen2.Checked = True Then
                Frase = "ANORMAL"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)


            'datos funcionales
            RefX = InicioX
            RefY += 20
            Frase = "Datos Funcionales"
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'no altero la refy para no traslocar las lineas le pongo directo...
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)


            'ACTITUD GLOBAL
            RefX = InicioX
            RefY += 15
            Frase = "Actitud Global  "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radActitud1.Checked = True Then
                Frase = "FLEXION"
                Fuente = TextoFont
            ElseIf radActitud2.Checked = True Then
                Frase = "EXTENSION"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'TONO
            RefX = InicioX + 225
            Frase = "Tono  "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radTono1.Checked = True Then
                Frase = "NORMAL"
                Fuente = TextoFont
            ElseIf radTono2.Checked = True Then
                Frase = "ANORMAL"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'MOV FETALES
            RefX = InicioX + 455
            Frase = "Movimientos Fetales  "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radMovimientosFetales1.Checked = True Then
                Frase = "PRESENTES"
                Fuente = TextoFont
            ElseIf radMovimientosFetales2.Checked = True Then
                Frase = "AUSENTES"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'ACTIVIDAD CARDIACA comienzo linea y+15
            RefX = InicioX
            RefY += 15
            Frase = "Actividad Cardíaca  "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radActividadCardiaca1.Checked = True Then
                Frase = "PRESENTE"
                Fuente = TextoFont
            ElseIf radActividadCardiaca2.Checked = True Then
                Frase = "AUSENTE"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'MOV RESPIRATORIOS
            RefX = InicioX + 225
            Frase = "Movimientos Respiratorios  "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radMovimientosRespiratorios1.Checked = True Then
                Frase = "PRESENTES"
                Fuente = TextoFont
            ElseIf radMovimientosRespiratorios2.Checked = True Then
                Frase = "AUSENTES"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'RELACION AORTO-CAVA
            RefX = InicioX + 455
            Frase = "Relación Aorto-Cava  "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radAortoCava1.Checked = True Then
                Frase = "NORMAL"
                Fuente = TextoFont
            ElseIf radAortoCava2.Checked = True Then
                Frase = "ANORMAL"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'CAMARA GASTRICA  'inicio linea y+15
            RefX = InicioX
            RefY += 15
            Frase = "Cámara Gástrica  "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radCamaraGastrica1.Checked = True Then
                Frase = "LLENA"
                Fuente = TextoFont
            ElseIf radCamaraGastrica2.Checked = True Then
                Frase = "VACIA"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'INTESTINO TIPO
            RefX = InicioX + 225
            Frase = "Intestino Tipo  "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radIntestino1.Checked = True Then
                Frase = "0/4"
                Fuente = TextoFont
            ElseIf radIntestino2.Checked = True Then
                Frase = "1/4"
                Fuente = TextoFont
            ElseIf radIntestino3.Checked = True Then
                Frase = "2/4"
                Fuente = TextoFont
            ElseIf radIntestino4.Checked = True Then
                Frase = "3/4"
                Fuente = TextoFont
            ElseIf radIntestino5.Checked = True Then
                Frase = "4/4"
                Fuente = TextoFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'VEJIGA
            RefX = InicioX + 455
            Frase = "Vejiga  "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radVejiga1.Checked = True Then
                Frase = "LLENA"
                Fuente = TextoFont
            ElseIf radVejiga2.Checked = True Then
                Frase = "VACIA"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'datos placentarios
            RefX = InicioX
            RefY += 20
            Frase = "Datos Placentarios"
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'no altero la refy para no traslocar las lineas le pongo directo...
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            'LOCALIZACION PLACENTA
            RefX = InicioX
            RefY += 15
            Frase = "Implantación "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radPlacenta1.Checked = True Then
                Frase = "ANTERIOR"
                Fuente = TextoFont
            ElseIf radPlacenta2.Checked = True Then
                Frase = "POSTERIOR"
                Fuente = TextoFont
            ElseIf radPlacenta3.Checked = True Then
                Frase = "ANTERIOR y FUNDICA"
                Fuente = TextoFont
            ElseIf radplacenta4.Checked = True Then
                Frase = "POSTERIOR y FUNDICA"
                Fuente = TextoFont
            ElseIf radPlacenta5.Checked = True Then
                Frase = "FUNDICA"
                Fuente = TextoFont
            ElseIf radPlacenta6.Checked = True Then
                Frase = "PREVIA PARCIAL"
                Fuente = SubtituloFont
            ElseIf radPlacenta7.Checked = True Then
                Frase = "PREVIA TOTAL"
                Fuente = SubtituloFont
            ElseIf radPlacenta8.Checked = True Then
                Frase = "de INSERCION BAJA"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'cordon umbilical
            RefX = InicioX + 225
            Frase = "Cordón Umbilical "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width

            RefX += AnchoX
            If radCordon1.Checked = True Then
                Frase = "con 3 ELEMENTOS VASCULARES"
                Fuente = TextoFont
            ElseIf radCordon2.Checked = True Then
                Frase = "ANORMAL"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)


            'GRADO DE MADUREZ
            RefX = InicioX
            RefY += 15
            Frase = "Grado de Madurez "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            RefX += AnchoX
            If radPlacentaGrado1.Checked = True Then
                Frase = "0/3"
                Fuente = TextoFont
            ElseIf radPlacentaGrado2.Checked = True Then
                Frase = "0-1/3"
                Fuente = TextoFont
            ElseIf radPlacentaGrado3.Checked = True Then
                Frase = "1/3"
                Fuente = TextoFont
            ElseIf radPlacentaGrado4.Checked = True Then
                Frase = "1-2/3"
                Fuente = TextoFont
            ElseIf radPlacentaGrado5.Checked = True Then
                Frase = "2/3"
                Fuente = TextoFont
            ElseIf radPlacentaGrado6.Checked = True Then
                Frase = "2-3/3"
                Fuente = TextoFont
            ElseIf radPlacentaGrado7.Checked = True Then
                Frase = "3/3"
                Fuente = TextoFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'lIQ AMNIOTICO
            RefX = InicioX + 225
            Frase = "Líquido Amniótico "
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            RefX += AnchoX
            If radLiquidoAmniotico1.Checked = True Then
                Frase = "NORMAL"
                Fuente = TextoFont
            ElseIf radLiquidoAmniotico2.Checked = True Then
                Frase = "ANORMAL"
                Fuente = SubtituloFont
            End If
            e.Graphics.DrawString(Frase, Fuente, Negro, RefX, RefY)

            'placenta grosor
            RefX = InicioX
            RefY += 15
            Frase = "Grosor(mm) " & txtPlacentaGrosor.Text
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            'ila
            RefX = InicioX + 225
            Frase = "ILA (cm) " & txtILA.Text
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            'Observaciones
            RefX = InicioX
            RefY += 20
            Frase = "Notas y Observaciones"
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'no altero la refy para no traslocar las lineas le pongo directo...
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)



            'nota01
            RefX = InicioX
            RefY += 15
            Frase = txtNotas01del2y3erT.Text
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            'nota02
            RefY += 15 'la misma x
            Frase = txtNotas02del2y3erT.Text
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            'nota03
            RefY += 15 ' la misma x
            Frase = txtNotas03del2y3erT.Text
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            'IDx
            RefX = InicioX
            RefY += 20
            Frase = "Impresión Diagnóstica"
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'no altero la refy para no traslocar las lineas le pongo directo...
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            'Idx
            RefX = InicioX
            RefY += 15
            Frase = "EMBARAZO DE " & txtIdx01del2y3erT.Text & ". CRECIMIENTO FETAL EN PERCENTIL " & txtIdx02del2y3erT.Text
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            RefY += 15 'la misma x
            Frase = "PERFIL BIOFISICO ECOGRAFICO: " & txtIdx03del2y3erT.Text & "/8.  ECOPUNTAJE GENETICO: " & txtIdx04del2y3erT.Text & " (NORMAL < 2)"
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            RefY += 15 'la misma x
            Frase = "SALUD FETAL " & txtIdx05del2y3erT.Text
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            If txtIDx06del2y3erT.Text <> "" Then
                RefY += 15 ' la misma x
                Frase = txtIDx06del2y3erT.Text
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            End If
            If txtIDx07del2y3erT.Text <> "" Then
                RefY += 15 ' la misma x
                Frase = txtIDx07del2y3erT.Text
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            End If
            If txtIDx08del2y3erT.Text <> "" Then
                RefY += 15 ' la misma x
                Frase = txtIDx08del2y3erT.Text
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            End If

            'sugerencias titulo
            RefX = InicioX
            RefY += 20
            Frase = "Sugerencias"
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'no altero la refy para no traslocar las lineas le pongo directo...
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            'sugerencias
            If txtSug01del2y3erT.Text <> "" Then
                RefY += 15 ' la misma x
                Frase = txtSug01del2y3erT.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If
            If txtSug02del2y3erT.Text <> "" Then
                RefY += 15 ' la misma x
                Frase = txtSug02del2y3erT.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If
            If txtSug03del2y3erT.Text <> "" Then
                RefY += 15 ' la misma x
                Frase = txtSug03del2y3erT.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'mensaje final
            RefX = InicioX
            RefY = 981
            e.Graphics.DrawLine(PenNegro, RefX, RefY, 769, RefY)
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 40, 769, RefY + 40)
            e.Graphics.DrawLine(PenNegro, RefX, RefY, RefX, RefY + 40)
            e.Graphics.DrawLine(PenNegro, 769, RefY, 769, RefY + 40)

            Frase = "ADVERTENCIA: En ausencia de marcadores, el ultrasonido posee muy poca sensibilidad diagnóstica para alteraciones cromosómicas"
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX + 1, RefY + 5)
            Frase = "y la integridad anatómica del feto no excluye la existencia de alguna de ellas."
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX + 1, RefY + 20)





        ElseIf R.c00TipoDeEstudio = "3" Then
            'InformeGinecologico()


            'titulo
            RefX = InicioX
            RefY = InicioY + 105
            e.Graphics.DrawLine(PenNegro2, RefX, RefY, 769, RefY)


            Frase = "ESTUDIO ULTRASONOGRAFICO GINECOLOGICO"
            AnchoX = e.Graphics.MeasureString(Frase, TituloFont).Width
            RefX = 425 - (AnchoX \ 2)
            RefY += 5
            e.Graphics.DrawString(Frase, TituloFont, Negro, RefX, RefY)

            RefX = InicioX
            RefY += 15
            e.Graphics.DrawLine(PenNegro2, RefX, RefY, 769, RefY)

            'fecha
            Frase = "Fecha del Estudio: " & txtFechaInicioControl.Text
            AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            RefX = 769 - (AnchoX)
            RefY += 15
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)


            'nombre de la pte
            RefX = InicioX
            RefY += 20
            Frase = "Nombre: " & txtNombrePaciente.Text.ToUpper & ". "
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            'edad si se sabe
            If IsNumeric(labEdadGinecologico.Text) Then
                Frase = " " & labEdadGinecologico.Text & " años. "
                RefX += AnchoX  'este es el ancho del nombre para iniciar la edad
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            End If
            'paridad si la tiene
            If txtParidadGinecologico.Text <> "" Then
                Frase = " Paridad: " & txtParidadGinecologico.Text & "."
                RefX += AnchoX
                e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)
            End If

            'fur y dia del ciclo
            RefX = InicioX
            RefY += 15
            Frase = "Fecha de última regla: " & labFURginecologico.Text & "."
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            RefY += 15 'la misma x
            Frase = "Día del Ciclo: " & labDiaCicloGinecologico.Text & "."
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            'tipo de estudio y frecuencia
            RefX = InicioX
            RefY += 15
            Frase = "Estudio Ecográfico realizado con trasductor "
            If radTipoEstudioGinecologico1.Checked = True Then
                Frase += "trasvaginal "
            ElseIf radTipoEstudioGinecologico2.Checked = True Then
                Frase += "transabdominal "
            Else
                Frase += "               "
            End If
            Frase += "con una frecuencia de "
            If radGINfrec35.Checked = True Then
                Frase += "3.5 MHz."
            ElseIf radGINfrec50.Checked = True Then
                Frase += "5.0 MHz."
            ElseIf radGINfrec75.Checked = True Then
                Frase += "7.5 MHz."
            End If
            e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)

            'VEJIGA
            RefX = InicioX
            RefY += 20
            Frase = "VEJIGA."
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'sin alterar refy para no empantanar
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            '1ra linea: anatomia de la vejiga
            If RadGinVejigaVolumen1.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "Vejiga llena.  "
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            ElseIf RadGinVejigaVolumen2.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "Vejiga vacía.  "
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            ElseIf RadGinVejigaVolumen3.Checked = True Then
                RefX = InicioX
                RefY += 15
                Frase = "Vejiga parcialmente llena.  "
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            Else
                AnchoX = 0
            End If

            'adecuacion de la vejiga
            If RadGinVejigaAdecuada1.Checked = True Then
                RefX += AnchoX 'la misma y
                Frase = "Adecuada para el estudio.  "
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            ElseIf RadGinVejigaAdecuada2.Checked = True Then
                RefX += AnchoX 'la misma y
                Frase = "No adecuada para el estudio.  "
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
                AnchoX = e.Graphics.MeasureString(Frase, TextoFont).Width
            Else
                AnchoX = 0
            End If

            'paredes de la vejiga
            If RadGinVejigaParedes1.Checked = True Then
                RefX += AnchoX 'la misma y
                Frase = "Paredes regulares sin lesiones en su interior."
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            ElseIf RadGinVejigaParedes2.Checked = True Then
                RefX += AnchoX 'la misma y
                Frase = "Paredes irregulares."
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            Else

            End If

            'segunda linea posible obs de vejiga 1
            If txtGinVejigaObservaciones1.Text <> "" Then
                'hay algo escrito lo pone
                RefX = InicioX
                RefY += 15
                Frase = txtGinVejigaObservaciones1.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'tercera linea posible obs de vejiga 2
            If txtGinVejigaObservaciones2.Text <> "" Then
                'hay algo escrito lo pone
                'hay algo escrito lo pone
                RefX = InicioX
                RefY += 15
                Frase = txtGinVejigaObservaciones2.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'UTERO
            RefX = InicioX
            RefY += 20
            Frase = "UTERO."
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'sin alterar refy para no empantanar
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            '1ra linea de utero: posicion inclinacion ecopatron y bordes
            Frase = ""
            If RadGinUteroPosicion1.Checked = True Then
                Frase = "Utero en anteroversoflexión.  "
            ElseIf RadGinUteroPosicion2.Checked = True Then
                Frase = "Utero indiferente.  "
            ElseIf RadGinUteroPosicion3.Checked = True Then
                Frase = "Utero en retroversoflexión.  "
            End If

            'inclinacion del utero
            If RadGinUteroInclinacion1.Checked = True Then
                Frase += "Lateralizado a la izquierda.  "
            ElseIf RadGinUteroInclinacion2.Checked = True Then
                Frase += "Central.  "
            ElseIf RadGinUteroInclinacion3.Checked = True Then
                Frase += "Lateralizado a la derecha.  "
            End If

            'ecopatron del utero
            If RadGinUteroEcopatron1.Checked = True Then
                Frase += "Ecopatrón homogéneo.  "
            ElseIf RadGinUteroEcopatron2.Checked = True Then
                Frase += "Ecopatrón heterogéneo.  "
            End If

            'bordes del utero
            If RadGinUteroBordes1.Checked = True Then
                Frase += "Bordes lisos y regulares."
            ElseIf RadGinUteroBordes2.Checked = True Then
                Frase += "Bordes irregulares."
            End If

            'escribe la linea lista de una sola vez si tiene algo q poner
            If Frase.Length > 0 Then
                'se escribio algo lo pone
                RefX = InicioX
                RefY += 15
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If



            '2da linea de utero: cavidad y endometrio
            Frase = ""
            If RadGinUteroEndometrio1.Checked = True Then
                Frase = "Endometrio lineal.  "
            ElseIf RadGinUteroEndometrio2.Checked = True Then
                Frase = "Endometrio en fase proliferativa inicial.  "
            ElseIf RadGinUteroEndometrio3.Checked = True Then
                Frase = "Endometrio en fase proliferativa tardía (trilaminar).  "
            ElseIf RadGinUteroEndometrio4.Checked = True Then
                Frase = "Endometrio en fase secretora.  "
            ElseIf RadGinUteroEndometrio5.Checked = True Then
                Frase = "Endometrio en fase menstrual.  "
            End If

            'cavidad uterina
            If RadGinUteroCavidad1.Checked = True Then
                Frase += "Cavidad uterina vacía."
            ElseIf RadGinUteroCavidad2.Checked = True Then
                Frase += "Cavidad uterina con contenido de ecopatrón heterogéneo."
            ElseIf RadGinUteroCavidad3.Checked = True Then
                Frase += "cavidad uterina con contenido sugestivo de hematometra o piometra."
            ElseIf RadGinUteroCavidad4.Checked = True Then
                Frase += "Cavidad uterina con imágen sugestiva de pólipo."
            ElseIf RadGinUteroCavidad5.Checked = True Then
                Frase += "Cavidad uterina con imágen sugestiva de mioma submucoso."
            End If

            'escribe la linea lista de una sola vez si tiene algo q poner
            If Frase.Length > 0 Then
                'se escribio algo lo pone
                RefX = InicioX
                RefY += 15
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            '3ra linea de utero: medidas
            Frase = ""
            If txtUteroLongitudinal.Text <> "" Then
                Frase = "Diametro longitudinal " & txtUteroLongitudinal.Text & "mm.  "
            End If

            If txtUteroAnteroPosterior.Text <> "" Then
                Frase += "Diámetro anteroposterior " & txtUteroAnteroPosterior.Text & "mm.  "
            End If

            If txtUteroTransverso.Text <> "" Then
                Frase += "Diámetro transverso " & txtUteroTransverso.Text & "mm.  "
            End If

            If txtUteroEndometrio.Text <> "" Then
                Frase += "Espesor del endometrio " & txtUteroEndometrio.Text & "mm."
            End If

            'escribe la 3ra linea lista de una sola vez si tiene algo q poner
            If Frase.Length > 0 Then
                'se escribio algo lo pone
                RefX = InicioX
                RefY += 15
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'escribe la 4ta linea lista de una sola vez si tiene algo q poner
            If txtGinUteroObservaciones1.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinUteroObservaciones1.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'escribe la 5ta linea lista de una sola vez si tiene algo q poner
            If txtGinUteroObservaciones2.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinUteroObservaciones2.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If


            'OVARIO IZQUIERDO
            RefX = InicioX
            RefY += 20
            Frase = "OVARIO IZQUIERDO."
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'sin alterar refy para no empantanar
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            '1ra linea de OVARIO IZQUIERDO: TAMANO
            Frase = ""
            If RadGinOvarioIzquierdoTamano1.Checked = True Then
                Frase = "De forma y volumen normal"
            ElseIf RadGinOvarioIzquierdoTamano2.Checked = True Then
                Frase = "Aumentado de volumen"
            ElseIf RadGinOvarioIzquierdoTamano3.Checked = True Then
                Frase = "Hipotrófico"
            End If

            'escribe la 1ra linea de ovario izq lista de una sola vez si tiene algo q poner
            If Frase.Length > 0 Then
                'se escribio algo lo pone
                RefY += 15
                RefX = InicioX
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            '2da linea de ovario izq: medidas
            Frase = ""
            If txtOvarioIzquierdoLongitudinal.Text <> "" Then
                Frase += "Diámetro Longitudinal " & txtOvarioIzquierdoLongitudinal.Text & "mm.  "
            End If

            If txtOvarioIzquierdoAnteroPosterior.Text <> "" Then
                Frase += "Diámetro Anteroposterior " & txtOvarioIzquierdoAnteroPosterior.Text & "mm.  "
            End If

            If txtOvarioIzquierdoTransverso.Text <> "" Then
                Frase += "Diámetro Transverso " & txtOvarioIzquierdoTransverso.Text & "mm."
            End If

            If Frase.Length > 0 Then
                RefX = InicioX
                RefY += 15
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If


            '3ra linea de ovario izq: foliculos
            Frase = ""
            If txtOvarioIzquierdoFoliculo1.Text <> "" Then
                Frase += "Folículos dominantes:  " & txtOvarioIzquierdoFoliculo1.Text & "mm.  "
            End If

            If txtOvarioIzquierdoFoliculo2.Text <> "" Then
                If Frase.Length > 0 Then 'se escribio algo 
                    Frase += txtOvarioIzquierdoFoliculo2.Text & "mm.  "
                Else 'no se escribio nada en la parte anterior se debe empezar
                    Frase += "Folículos dominantes:  " & txtOvarioIzquierdoFoliculo2.Text & "mm.  "
                End If
            End If

            If txtOvarioIzquierdoFoliculo3.Text <> "" Then
                If Frase.Length > 0 Then 'se escribio algo 
                    Frase += txtOvarioIzquierdoFoliculo3.Text & "mm.  "
                Else 'no se escribio nada en la parte anterior se debe empezar
                    Frase += "Folículos dominantes:  " & txtOvarioIzquierdoFoliculo3.Text & "mm.  "
                End If
            End If

            If txtOvarioIzquierdoFoliculo4.Text <> "" Then
                If Frase.Length > 0 Then 'se escribio algo 
                    Frase += txtOvarioIzquierdoFoliculo4.Text & "mm.  "
                Else 'no se escribio nada en la parte anterior se debe empezar
                    Frase += "Folículos dominantes:  " & txtOvarioIzquierdoFoliculo4.Text & "mm.  "
                End If
            End If

            'verifica si se metieron medidas de foliculos
            If Frase.Length > 0 Then
                RefX = InicioX
                RefY += 15
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'escribe las lineas de obs de ovario izquierdo si las hay
            If txtGinOvarioIzquierdoObservaciones1.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinOvarioIzquierdoObservaciones1.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            If txtGinOvarioIzquierdoObservaciones2.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinOvarioIzquierdoObservaciones2.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            If txtGinOvarioIzquierdoObservaciones3.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinOvarioIzquierdoObservaciones3.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            If txtGinOvarioIzquierdoObservaciones4.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinOvarioIzquierdoObservaciones4.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If


            RefX = InicioX
            RefY += 20
            Frase = "OVARIO DERECHO."
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'sin alterar refy para no empantanar
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            '1ra linea de OVARIO DERECHO: TAMANO
            Frase = ""
            If RadGinOvarioDerechoTamano1.Checked = True Then
                Frase = "De forma y volumen normal"
            ElseIf RadGinOvarioDerechoTamano2.Checked = True Then
                Frase = "Aumentado de volumen"
            ElseIf RadGinOvarioDerechoTamano3.Checked = True Then
                Frase = "Hipotrófico"
            End If

            'escribe la 1ra linea de ovario der lista de una sola vez si tiene algo q poner
            If Frase.Length > 0 Then
                'se escribio algo lo pone
                RefY += 15
                RefX = InicioX
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            '2da linea de ovario der: medidas
            Frase = ""
            If txtOvarioDerechoLongitudinal.Text <> "" Then
                Frase += "Diámetro Longitudinal " & txtOvarioDerechoLongitudinal.Text & "mm.  "
            End If

            If txtOvarioDerechoAnteroPosterior.Text <> "" Then
                Frase += "Diámetro Anteroposterior " & txtOvarioDerechoAnteroPosterior.Text & "mm.  "
            End If

            If txtOvarioDerechoTransverso.Text <> "" Then
                Frase += "Diámetro Transverso " & txtOvarioDerechoTransverso.Text & "mm."
            End If

            If Frase.Length > 0 Then
                RefX = InicioX
                RefY += 15
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If


            '3ra linea de ovario der: foliculos
            Frase = ""
            If txtOvarioDerechoFoliculo1.Text <> "" Then
                Frase += "Folículos dominantes:  " & txtOvarioDerechoFoliculo1.Text & "mm.  "
            End If

            If txtOvarioDerechoFoliculo2.Text <> "" Then
                If Frase.Length > 0 Then 'se escribio algo 
                    Frase += txtOvarioDerechoFoliculo2.Text & "mm.  "
                Else 'no se escribio nada en la parte anterior se debe empezar
                    Frase += "Folículos dominantes:  " & txtOvarioDerechoFoliculo2.Text & "mm.  "
                End If
            End If

            If txtOvarioDerechoFoliculo3.Text <> "" Then
                If Frase.Length > 0 Then 'se escribio algo 
                    Frase += txtOvarioDerechoFoliculo3.Text & "mm.  "
                Else 'no se escribio nada en la parte anterior se debe empezar
                    Frase += "Folículos dominantes:  " & txtOvarioDerechoFoliculo3.Text & "mm.  "
                End If
            End If

            If txtOvarioDerechoFoliculo4.Text <> "" Then
                If Frase.Length > 0 Then 'se escribio algo 
                    Frase += txtOvarioDerechoFoliculo4.Text & "mm.  "
                Else 'no se escribio nada en la parte anterior se debe empezar
                    Frase += "Folículos dominantes:  " & txtOvarioDerechoFoliculo4.Text & "mm.  "
                End If
            End If

            'verifica si se metieron medidas de foliculos
            If Frase.Length > 0 Then
                RefX = InicioX
                RefY += 15
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'escribe las lineas de obs de ovario der si las hay
            If txtGinOvarioDerechoObservaciones1.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinOvarioDerechoObservaciones1.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            If txtGinOvarioDerechoObservaciones2.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinOvarioDerechoObservaciones2.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            If txtGinOvarioDerechoObservaciones3.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinOvarioDerechoObservaciones3.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            If txtGinOvarioDerechoObservaciones4.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinOvarioDerechoObservaciones4.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            RefX = InicioX
            RefY += 20
            Frase = "TROMPAS UTERINAS."
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'sin alterar refy para no empantanar
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            '1ra linea de TROMPAS: 
            Frase = ""
            If RadGinTrompas1.Checked = True Then
                Frase = "No visualizables (NORMAL)"
            ElseIf RadGinTrompas2.Checked = True Then
                Frase = "Trompa izquierda distendida"
            ElseIf RadGinTrompas3.Checked = True Then
                Frase = "Trompa derecha distendida"
            ElseIf RadGinTrompas4.Checked = True Then
                Frase = "Trompas distendidas bilateralmente"
            End If

            'escribe la linea lista de una sola vez si tiene algo q poner
            If Frase.Length > 0 Then
                'se escribio algo lo pone
                RefX = InicioX
                RefY += 15
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'escribe las lineas de obs de trompas si las hay
            If txtGinOtrosObservaciones1.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinOtrosObservaciones1.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            RefX = InicioX
            RefY += 20
            Frase = "FONDO DE SACO DE DOUGLAS."
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'sin alterar refy para no empantanar
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)

            '1ra linea de DOUGLAS: 
            Frase = ""
            If RadGinDouglas1.Checked = True Then
                Frase = "Libre sin colecciones líquidas"
            ElseIf RadGinDouglas2.Checked = True Then
                Frase = "Se visualiza nivel líquido"
            End If

            'escribe la linea lista de una sola vez si tiene algo q poner
            If Frase.Length > 0 Then
                'se escribio algo lo pone
                RefY += 15
                RefX = InicioX
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'escribe las lineas de obs de trompas si las hay
            If txtGinOtrosObservaciones2.Text <> "" Then
                'hay algo escrito lo pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinOtrosObservaciones2.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If


            RefX = InicioX
            RefY += 50
            Frase = "IMPRESION DIAGNOSTICA."
            AnchoX = e.Graphics.MeasureString(Frase, SubtituloFont).Width
            e.Graphics.DrawString(Frase, SubtituloFont, Negro, RefX, RefY)

            RefX += AnchoX + 10 'sin alterar refy para no empantanar
            e.Graphics.DrawLine(PenNegro, RefX, RefY + 11, 769, RefY + 11)


            'escribe las lineas de idX si las hay
            If txtGinIDx1.Text <> "" Then
                'hay algo escrito lo   pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinIDx1.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'escribe las lineas de idX si las hay
            If txtGinIDx2.Text <> "" Then
                'hay algo escrito lo   pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinIDx2.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'escribe las lineas de idX si las hay
            If txtGinIDx3.Text <> "" Then
                'hay algo escrito lo   pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinIDx3.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If

            'escribe las lineas de idX si las hay
            If txtGinIDx4.Text <> "" Then
                'hay algo escrito lo   pone
                RefY += 15
                RefX = InicioX
                Frase = txtGinIDx4.Text
                e.Graphics.DrawString(Frase, TextoFont, Negro, RefX, RefY)
            End If




        Else
            'no hace nada, no hay nada seleccionado
        End If






        'verifica si se escribe encabezado y si hay datos personales

        If booImprimeMembrete = False Then
            Exit Sub
        End If

        If Form1.booExistenDatosDelUsuario = False Then
            'no hay datos
            Exit Sub
        End If

        'variables para el encabezado
        Dim Encabezado(4) As String
        Dim Tumb As Image
        Dim Origen As Integer

        'carga y ubica las lines del encabezado

        Encabezado(0) = Form1.UsuarioNombre
        Encabezado(1) = Form1.UsuarioEspecialidad
        Encabezado(2) = Form1.UsuarioDir01
        Encabezado(3) = Form1.UsuarioDir02

        ' el nombre del usuario
        AnchoX = e.Graphics.MeasureString(Encabezado(0), nombreFont).Width
        RefX = (850 \ 2) - (AnchoX \ 2) + 24
        RefY = InicioY + 3
        e.Graphics.DrawString(Encabezado(0), nombreFont, Brushes.Black, RefX, RefY)

        ' especialidad
        AnchoX = e.Graphics.MeasureString(Encabezado(1), otrosFont).Width
        RefX = (850 \ 2) - (AnchoX \ 2) + 24
        RefY += 25
        e.Graphics.DrawString(Encabezado(1), otrosFont, Brushes.Black, RefX, RefY)

        ' direccion primera linea
        AnchoX = e.Graphics.MeasureString(Encabezado(2), direccionFont).Width
        RefX = (850 \ 2) - (AnchoX \ 2) + 24
        RefY += 20
        e.Graphics.DrawString(Encabezado(2), direccionFont, Brushes.Black, RefX, RefY)

        ' direccion segunda linea
        AnchoX = e.Graphics.MeasureString(Encabezado(3), direccionFont).Width
        RefX = (850 \ 2) - (AnchoX \ 2) + 24
        RefY += 15
        e.Graphics.DrawString(Encabezado(3), direccionFont, Brushes.Black, RefX, RefY)



        'grafico del logo del usuario
        Tumb = Form1.imagenLogoDelUsuario
        '--------------------------------------------

        Dim Rectangulo As Rectangle
        Dim P As Pen
        P = New Pen(Color.Black, 1)
        Rectangulo = New Rectangle(IniciodeRecipeX, Tmargin, AnchodeRecipe, PrintHeight)

        Dim AltoDelDibujo, AnchoDelDibujo As Integer

        If Tumb.Height > Tumb.Width Then
            'es mas alta que ancha
            '48x80
            AltoDelDibujo = 80
            AnchoDelDibujo = Int(Tumb.Width * 80) \ Tumb.Height

            'situa en el recipe
            Origen = (IniciodeRecipeX + 24) - (AnchoDelDibujo \ 2)
            Rectangulo = New Rectangle(Origen, Tmargin, AnchoDelDibujo, AltoDelDibujo)
            e.Graphics.DrawImage(Tumb, Rectangulo)
        Else
            'es mas ancha que alta
            AnchoDelDibujo = 48
            AltoDelDibujo = Int(Tumb.Height * 48) \ Tumb.Width
            'situa en el recipe
            Origen = (Tmargin + 40) - (AltoDelDibujo \ 2)
            Rectangulo = New Rectangle(IniciodeRecipeX, Origen, AnchoDelDibujo, AltoDelDibujo)
            e.Graphics.DrawImage(Tumb, Rectangulo)
        End If

        'pone las lineas del encabezado

        RefX = InicioX + 48
        RefY = InicioY + 2
        e.Graphics.DrawLine(PenNegro2, RefX, RefY, 768, RefY)

        RefY += 25
        e.Graphics.DrawLine(PenNegro, RefX, RefY, 768, RefY)

        RefY += 20
        e.Graphics.DrawLine(PenNegro, RefX, RefY, 768, RefY)

        RefY += 32
        e.Graphics.DrawLine(PenNegro2, RefX, RefY, 768, RefY)



    End Sub


    '000000000000000000000000000000000
    'EVENTOS GRAFICOS DE LOS BOTONES

    Private Sub botNUEVOINFORME_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNuevo.MouseEnter
        botNuevo.Image = BotonOnGrande
    End Sub
    Private Sub botNUEVOINFORME_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNuevo.MouseLeave
        botNuevo.Image = BotonOffGrande
    End Sub

    Private Sub botSELECCIONA_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSelecciona.MouseEnter
        botSelecciona.Image = BotonOnGrande
    End Sub
    Private Sub botSELECCIONA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSelecciona.MouseLeave
        botSelecciona.Image = BotonOffGrande
    End Sub

    Private Sub botRENOMBRA_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRenombra.MouseEnter
        botRenombra.Image = BotonOnGrande
    End Sub
    Private Sub botRENOMBRA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRenombra.MouseLeave
        botRenombra.Image = BotonOffGrande
    End Sub

    Private Sub botELIMINA_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botElimina.MouseEnter
        botElimina.Image = BotonOnGrande
    End Sub
    Private Sub botELIMINA_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botElimina.MouseLeave
        botElimina.Image = BotonOffGrande
    End Sub

    Private Sub botNUEVAIMAGEN_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNuevaImagen.MouseEnter
        botNuevaImagen.Image = BotonOnGrande
    End Sub
    Private Sub botNUEVAIMAGEN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNuevaImagen.MouseLeave
        botNuevaImagen.Image = BotonOffGrande
    End Sub

    Private Sub botABREIMAGEN_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAbreImagen.MouseEnter
        botAbreImagen.Image = BotonOnGrande
    End Sub
    Private Sub botABREIMAGEN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAbreImagen.MouseLeave
        botAbreImagen.Image = BotonOffGrande
    End Sub

    Private Sub botRENOMBRAIMAGEN_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRenombraImagen.MouseEnter
        botRenombraImagen.Image = BotonOnGrande
    End Sub
    Private Sub botRENOMBRAIMAGEN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRenombraImagen.MouseLeave
        botRenombraImagen.Image = BotonOffGrande
    End Sub

    Private Sub botELIMINAIMAGEN_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEliminaImagen.MouseEnter
        botEliminaImagen.Image = BotonOnGrande
    End Sub
    Private Sub botELIMINAIMAGEN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEliminaImagen.MouseLeave
        botEliminaImagen.Image = BotonOffGrande
    End Sub

    Private Sub botGUARDARNUEVOSDATOS_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botGuardarNuevosDatos.MouseEnter
        botGuardarNuevosDatos.Image = BotonOnGrande
    End Sub
    Private Sub botGUARDARNUEVOSDATOS_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botGuardarNuevosDatos.MouseLeave
        botGuardarNuevosDatos.Image = BotonOffGrande
    End Sub

    Private Sub botSALIRSINGUARDAR_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalirSinGuardar.MouseEnter
        botSalirSinGuardar.Image = BotonOnGrande
    End Sub
    Private Sub botSALIRSINGUARDAR_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalirSinGuardar.MouseLeave
        botSalirSinGuardar.Image = BotonOffGrande
    End Sub

    Private Sub botCREAIMPRESION_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCreaImpresion.MouseEnter
        botCreaImpresion.Image = BotonOnGrande
    End Sub
    Private Sub botCREAIMPRESION_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCreaImpresion.MouseLeave
        botCreaImpresion.Image = BotonOffGrande
    End Sub

    Private Sub botIMPRESION_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botIMPRIME.MouseEnter
        botIMPRIME.Image = BotonOnGrande
    End Sub
    Private Sub botIMPRESION_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botIMPRIME.MouseLeave
        botIMPRIME.Image = BotonOffGrande
    End Sub

    Private Sub botpersonaliza_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.MouseEnter
        botPersonaliza.Image = BotonOn
    End Sub



    Private Sub botPersonaliza_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.MouseLeave
        botPersonaliza.Image = BotonOff
    End Sub


    Private Sub menuCalculaEGconECO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculaEGconECO.Click
        Dim dlg As New FormEGxECO()

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub menuCalculaEGconFUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculaEGconFUR.Click
        Dim DLG As New FormEGxFUR()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub menuCalculoDCconFUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculaDCconFUR.Click
        Dim dlg As New FormDCxFUR()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub botPersonaliza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.Click
        MuestraVentanaDeDatosDelUsuario()
    End Sub

    Private Sub MuestraVentanaDeDatosDelUsuario()
        Dim DLG As New FormDatosDelUsuario()

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'se acepto lo que se metio

            ''revisa si se cambio la imagen
            'If FormDatosDelUsuario.SeCambioLaImagen = True Then
            '    'si se cambio la sustituye
            '    File.Copy(FormDatosDelUsuario.pathImagenNuevaSeleccionada, Form1.UsuarioImagen, True)
            'End If
            Form1.booExistenDatosDelUsuario = True
        End If
    End Sub


    Private Sub PictureBox2_dobleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.DoubleClick
        'variables para los elementos graficos 
        Dim PenNegro As New Pen(Color.Black, 1)
        Dim PenNegro2 As New Pen(Color.Black, 2)
        Dim PenGris As New Pen(Color.Gray, 1)
        Dim Blanco As New SolidBrush(Color.White)
        Dim Clarito As New SolidBrush(Color.Snow)
        Dim Negro As New SolidBrush(Color.Black)
        Dim Naranja As New SolidBrush(Color.Orange)
        Dim Caqui As New SolidBrush(Color.Khaki)
        Dim Rojo As New SolidBrush(Color.Red)
        Dim Rojito As New SolidBrush(Color.MistyRose)
        Dim Azul As New SolidBrush(Color.Blue)
        Dim Azulito As New SolidBrush(Color.Lavender)
        Dim RectanguloTodo As New Rectangle(0, 0, 690, 925)
        Dim RectanguloGrafico As New Rectangle(50, 25, 400, 250)
        Dim SmallFont As New Font("Microsoft Sans Serif", 7)
        Dim TextoFont As New Font("Microsoft Sans Serif", 8)
        Dim SubtituloFont As New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
        Dim TituloFont As New Font("times new roman", 10, FontStyle.Bold)




        'crea el marco grafico y le asigna el vinculo para dibujar en el
        Fondo = Me.CreateGraphics
        BMP = New Bitmap(PictureBox2.Width, PictureBox2.Height)
        BMP2 = New Bitmap(PictureBox2.Width, PictureBox2.Height)
        PictureBox2.Image = BMP2
        Fondo.Clear(PictureBox2.BackColor)
        Gr = Graphics.FromImage(BMP2)

        'crea una apariencia de hoja blanca en el fondo
        Gr.FillRectangle(Rojo, RectanguloTodo)

    End Sub











   
   
   
    
End Class
