Imports System.IO

Public Class FormAntecedentesFamiliares
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
    Friend WithEvents TabPageAbuelosMaternos As System.Windows.Forms.TabPage
    Friend WithEvents TabPageAbuelosPaternos As System.Windows.Forms.TabPage
    Friend WithEvents TabPageOtros As System.Windows.Forms.TabPage
    Friend WithEvents GBmadreAntecedentes As System.Windows.Forms.GroupBox
    Friend WithEvents chkMadreOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chkMadre06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMadre05 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMadre04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMadre03 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMadre02 As System.Windows.Forms.CheckBox
    Friend WithEvents chkMadre01 As System.Windows.Forms.CheckBox
    Friend WithEvents radMadreDesconoce As System.Windows.Forms.RadioButton
    Friend WithEvents radMadreMuerta As System.Windows.Forms.RadioButton
    Friend WithEvents radMadreViva As System.Windows.Forms.RadioButton
    Friend WithEvents GBmadreCausaMuerte As System.Windows.Forms.GroupBox
    Friend WithEvents radMadre01 As System.Windows.Forms.RadioButton
    Friend WithEvents chkMadre07 As System.Windows.Forms.CheckBox
    Friend WithEvents radMadreOtrasCausas As System.Windows.Forms.RadioButton
    Friend WithEvents txtMadreOtrasCausas As System.Windows.Forms.TextBox
    Friend WithEvents radMadreDesconoceCausa As System.Windows.Forms.RadioButton
    Friend WithEvents radMadre08 As System.Windows.Forms.RadioButton
    Friend WithEvents radMadre07 As System.Windows.Forms.RadioButton
    Friend WithEvents radMadre06 As System.Windows.Forms.RadioButton
    Friend WithEvents radMadre04 As System.Windows.Forms.RadioButton
    Friend WithEvents radMadre03 As System.Windows.Forms.RadioButton
    Friend WithEvents radMadre05 As System.Windows.Forms.RadioButton
    Friend WithEvents radMadre02 As System.Windows.Forms.RadioButton
    Friend WithEvents txtMadreOtrosAnt As System.Windows.Forms.TextBox
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents radMadreNiega As System.Windows.Forms.RadioButton
    Friend WithEvents radMadreDesconocePatologia As System.Windows.Forms.RadioButton
    Friend WithEvents radMadreTieneAnt As System.Windows.Forms.RadioButton
    Friend WithEvents TabPagePadres As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radPadreMuerta As System.Windows.Forms.RadioButton
    Friend WithEvents radPadreDesconoce As System.Windows.Forms.RadioButton
    Friend WithEvents GBpadreCausaMuerte As System.Windows.Forms.GroupBox
    Friend WithEvents radPadre04 As System.Windows.Forms.RadioButton
    Friend WithEvents radPadre03 As System.Windows.Forms.RadioButton
    Friend WithEvents radPadre02 As System.Windows.Forms.RadioButton
    Friend WithEvents radPadre01 As System.Windows.Forms.RadioButton
    Friend WithEvents GBpadreAntecedentes As System.Windows.Forms.GroupBox
    Friend WithEvents chkPadre06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPadre05 As System.Windows.Forms.CheckBox
    Friend WithEvents radPadreTieneAnt As System.Windows.Forms.RadioButton
    Friend WithEvents chkPadre03 As System.Windows.Forms.CheckBox
    Friend WithEvents radPadreDesconocePatologia As System.Windows.Forms.RadioButton
    Friend WithEvents chkPadre02 As System.Windows.Forms.CheckBox
    Friend WithEvents radPadreNiega As System.Windows.Forms.RadioButton
    Friend WithEvents txtPadreOtrosAnt As System.Windows.Forms.TextBox
    Friend WithEvents chkPadreotros As System.Windows.Forms.CheckBox
    Friend WithEvents chkPadre07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPadre04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPadre01 As System.Windows.Forms.CheckBox
    Friend WithEvents radPadreOtrasCausas As System.Windows.Forms.RadioButton
    Friend WithEvents txtPadreOtrasCausas As System.Windows.Forms.TextBox
    Friend WithEvents radPadreDesconoceCausa As System.Windows.Forms.RadioButton
    Friend WithEvents radPadre08 As System.Windows.Forms.RadioButton
    Friend WithEvents radPadre07 As System.Windows.Forms.RadioButton
    Friend WithEvents radPadre06 As System.Windows.Forms.RadioButton
    Friend WithEvents radPadre05 As System.Windows.Forms.RadioButton
    Friend WithEvents radPadreViva As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GBAbueloMaternoAntecedentes As System.Windows.Forms.GroupBox
    Friend WithEvents chkAbueloMaterno06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbueloMaterno05 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbueloMaternoTieneAnt As System.Windows.Forms.RadioButton
    Friend WithEvents chkAbueloMaterno03 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbueloMaternoDesconocePatologia As System.Windows.Forms.RadioButton
    Friend WithEvents chkAbueloMaterno02 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbueloMaternoNiega As System.Windows.Forms.RadioButton
    Friend WithEvents txtAbueloMaternoOtrosAnt As System.Windows.Forms.TextBox
    Friend WithEvents chkAbueloMaternoOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbueloMaterno07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbueloMaterno04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbueloMaterno01 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbueloMaternoMuerta As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloMaternoDesconoce As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloMaternoViva As System.Windows.Forms.RadioButton
    Friend WithEvents gb2 As System.Windows.Forms.GroupBox
    Friend WithEvents radAbuelaMaternaOtrasCausas As System.Windows.Forms.RadioButton
    Friend WithEvents txtAbuelaMaternaOtrasCausas As System.Windows.Forms.TextBox
    Friend WithEvents radAbuelaMaternaDesconoceCausa As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaMaterna08 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaMaterna07 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaMaterna06 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaMaterna04 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaMaterna03 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaMaterna05 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaMaterna02 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaMaterna01 As System.Windows.Forms.RadioButton
    Friend WithEvents GBAbuelaMaternaAntecedentes As System.Windows.Forms.GroupBox
    Friend WithEvents chkAbuelaMaterna06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbuelaMaterna05 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbuelaMaternaDesconocePatologia As System.Windows.Forms.RadioButton
    Friend WithEvents chkAbuelaMaterna03 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbuelaMaternaTieneAnt As System.Windows.Forms.RadioButton
    Friend WithEvents chkAbuelaMaterna02 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbuelaMaternaNiega As System.Windows.Forms.RadioButton
    Friend WithEvents txtAbuelaMaternaOtrosAnt As System.Windows.Forms.TextBox
    Friend WithEvents chkAbuelaMaternaOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbuelaMaterna07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbuelaMaterna04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbuelaMaterna01 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbuelaMaternaMuerta As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaMaternaDesconoce As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaMaternaViva As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloMaternoOtrasCausas As System.Windows.Forms.RadioButton
    Friend WithEvents txtAbueloMaternoOtrasCausas As System.Windows.Forms.TextBox
    Friend WithEvents radAbueloMaterno08 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloMaterno07 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloMaterno06 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloMaterno04 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloMaterno03 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloMaterno05 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloMaterno02 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloMaterno01 As System.Windows.Forms.RadioButton
    Friend WithEvents GBAbueloMaternoCausaMuerte As System.Windows.Forms.GroupBox
    Friend WithEvents radAbueloMaternoDesconoceCausa As System.Windows.Forms.RadioButton
    Friend WithEvents GBAbuelaMaternaCausaMuerte As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GBAbueloPaternocausaMuerte As System.Windows.Forms.GroupBox
    Friend WithEvents radAbueloPaternoOtrasCausas As System.Windows.Forms.RadioButton
    Friend WithEvents txtAbueloPaternoOtrasCausas As System.Windows.Forms.TextBox
    Friend WithEvents radAbueloPaternoDesconoceCausa As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloPaterno08 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloPaterno07 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloPaterno06 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloPaterno04 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloPaterno03 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloPaterno05 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloPaterno02 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloPaterno01 As System.Windows.Forms.RadioButton
    Friend WithEvents GBAbueloPaternoAntecedentes As System.Windows.Forms.GroupBox
    Friend WithEvents chkAbueloPaterno06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbueloPaterno05 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbueloPaternoTieneAnt As System.Windows.Forms.RadioButton
    Friend WithEvents chkAbueloPaterno03 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbueloPaterno02 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbueloPaternoNiega As System.Windows.Forms.RadioButton
    Friend WithEvents txtAbueloPaternoOtrosAnt As System.Windows.Forms.TextBox
    Friend WithEvents chkAbueloPaternoOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbueloPaterno07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbueloPaterno04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbueloPaterno01 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbueloPaternoMuerta As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloPaternoDesconoce As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GBAbuelaPaternaCausaMuerte As System.Windows.Forms.GroupBox
    Friend WithEvents radAbuelaPaternaOtrasCausas As System.Windows.Forms.RadioButton
    Friend WithEvents txtAbuelaPaternaOtrasCausas As System.Windows.Forms.TextBox
    Friend WithEvents radAbuelaPaternaDesconoceCausa As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaPaterna08 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaPaterna07 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaPaterna06 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaPaterna04 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaPaterna03 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaPaterna05 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaPaterna02 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaPaterna01 As System.Windows.Forms.RadioButton
    Friend WithEvents GBAbuelaPaternaAntecedentes As System.Windows.Forms.GroupBox
    Friend WithEvents chkAbuelaPaterna06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbuelaPaterna05 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbuelaPaternaDesconocePatologia As System.Windows.Forms.RadioButton
    Friend WithEvents chkAbuelaPaterna03 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbuelaPaternaTieneAnt As System.Windows.Forms.RadioButton
    Friend WithEvents chkAbuelaPaterna02 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbuelaPaternaNiega As System.Windows.Forms.RadioButton
    Friend WithEvents txtAbuelaPaternaOtrosAnt As System.Windows.Forms.TextBox
    Friend WithEvents chkAbuelaPaternaOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbuelaPaterna07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbuelaPaterna04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbuelaPaterna01 As System.Windows.Forms.CheckBox
    Friend WithEvents radAbuelaPaternaMuerta As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaPaternaDesconoce As System.Windows.Forms.RadioButton
    Friend WithEvents radAbuelaPaternaViva As System.Windows.Forms.RadioButton
    Friend WithEvents radAbueloPaternoDesconocePatologia As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents chkHermanosMuertos01 As System.Windows.Forms.CheckBox
    Friend WithEvents txtHermanosMuertosOtrasCausas As System.Windows.Forms.TextBox
    Friend WithEvents chkHermanos06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanos05 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanos03 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanos02 As System.Windows.Forms.CheckBox
    Friend WithEvents txtHermanosOtrosAnt As System.Windows.Forms.TextBox
    Friend WithEvents chkHermanos07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanos04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanos01 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanosMuertos02 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanosMuertos03 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanosMuertos04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanosMuertos05 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanosMuertos06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanosMuertos07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanosMuertos08 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTiosMuertos07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTiosMuertos06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTiosMuertos05 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTiosMuertos04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTiosMuertos03 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTiosMuertos02 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTiosMuertos01 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTios06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTios05 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTios03 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTios02 As System.Windows.Forms.CheckBox
    Friend WithEvents txtTiosOtrosAnt As System.Windows.Forms.TextBox
    Friend WithEvents chkTios07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTios04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTios01 As System.Windows.Forms.CheckBox
    Friend WithEvents txtOtrosFamiliares As System.Windows.Forms.TextBox
    Friend WithEvents chkTiosMuertos08 As System.Windows.Forms.CheckBox
    Friend WithEvents txtTiosMuertosOtrasCausas As System.Windows.Forms.TextBox
    Friend WithEvents radAbueloPaternoViva As System.Windows.Forms.RadioButton
    Friend WithEvents chkTiosMuertos09 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTios08 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanosMuertos09 As System.Windows.Forms.CheckBox
    Friend WithEvents chkHermanos08 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAntecedentesFamiliares))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPagePadres = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GBpadreCausaMuerte = New System.Windows.Forms.GroupBox()
        Me.radPadreOtrasCausas = New System.Windows.Forms.RadioButton()
        Me.txtPadreOtrasCausas = New System.Windows.Forms.TextBox()
        Me.radPadreDesconoceCausa = New System.Windows.Forms.RadioButton()
        Me.radPadre08 = New System.Windows.Forms.RadioButton()
        Me.radPadre07 = New System.Windows.Forms.RadioButton()
        Me.radPadre06 = New System.Windows.Forms.RadioButton()
        Me.radPadre04 = New System.Windows.Forms.RadioButton()
        Me.radPadre03 = New System.Windows.Forms.RadioButton()
        Me.radPadre05 = New System.Windows.Forms.RadioButton()
        Me.radPadre02 = New System.Windows.Forms.RadioButton()
        Me.radPadre01 = New System.Windows.Forms.RadioButton()
        Me.GBpadreAntecedentes = New System.Windows.Forms.GroupBox()
        Me.chkPadre06 = New System.Windows.Forms.CheckBox()
        Me.chkPadre05 = New System.Windows.Forms.CheckBox()
        Me.radPadreTieneAnt = New System.Windows.Forms.RadioButton()
        Me.chkPadre03 = New System.Windows.Forms.CheckBox()
        Me.radPadreDesconocePatologia = New System.Windows.Forms.RadioButton()
        Me.chkPadre02 = New System.Windows.Forms.CheckBox()
        Me.radPadreNiega = New System.Windows.Forms.RadioButton()
        Me.txtPadreOtrosAnt = New System.Windows.Forms.TextBox()
        Me.chkPadreotros = New System.Windows.Forms.CheckBox()
        Me.chkPadre07 = New System.Windows.Forms.CheckBox()
        Me.chkPadre04 = New System.Windows.Forms.CheckBox()
        Me.chkPadre01 = New System.Windows.Forms.CheckBox()
        Me.radPadreMuerta = New System.Windows.Forms.RadioButton()
        Me.radPadreDesconoce = New System.Windows.Forms.RadioButton()
        Me.radPadreViva = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GBmadreCausaMuerte = New System.Windows.Forms.GroupBox()
        Me.radMadreOtrasCausas = New System.Windows.Forms.RadioButton()
        Me.txtMadreOtrasCausas = New System.Windows.Forms.TextBox()
        Me.radMadreDesconoceCausa = New System.Windows.Forms.RadioButton()
        Me.radMadre08 = New System.Windows.Forms.RadioButton()
        Me.radMadre07 = New System.Windows.Forms.RadioButton()
        Me.radMadre06 = New System.Windows.Forms.RadioButton()
        Me.radMadre04 = New System.Windows.Forms.RadioButton()
        Me.radMadre03 = New System.Windows.Forms.RadioButton()
        Me.radMadre05 = New System.Windows.Forms.RadioButton()
        Me.radMadre02 = New System.Windows.Forms.RadioButton()
        Me.radMadre01 = New System.Windows.Forms.RadioButton()
        Me.GBmadreAntecedentes = New System.Windows.Forms.GroupBox()
        Me.chkMadre06 = New System.Windows.Forms.CheckBox()
        Me.chkMadre05 = New System.Windows.Forms.CheckBox()
        Me.radMadreDesconocePatologia = New System.Windows.Forms.RadioButton()
        Me.chkMadre03 = New System.Windows.Forms.CheckBox()
        Me.radMadreTieneAnt = New System.Windows.Forms.RadioButton()
        Me.chkMadre02 = New System.Windows.Forms.CheckBox()
        Me.radMadreNiega = New System.Windows.Forms.RadioButton()
        Me.txtMadreOtrosAnt = New System.Windows.Forms.TextBox()
        Me.chkMadreOtros = New System.Windows.Forms.CheckBox()
        Me.chkMadre07 = New System.Windows.Forms.CheckBox()
        Me.chkMadre04 = New System.Windows.Forms.CheckBox()
        Me.chkMadre01 = New System.Windows.Forms.CheckBox()
        Me.radMadreMuerta = New System.Windows.Forms.RadioButton()
        Me.radMadreDesconoce = New System.Windows.Forms.RadioButton()
        Me.radMadreViva = New System.Windows.Forms.RadioButton()
        Me.TabPageAbuelosPaternos = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GBAbueloPaternocausaMuerte = New System.Windows.Forms.GroupBox()
        Me.radAbueloPaternoOtrasCausas = New System.Windows.Forms.RadioButton()
        Me.txtAbueloPaternoOtrasCausas = New System.Windows.Forms.TextBox()
        Me.radAbueloPaternoDesconoceCausa = New System.Windows.Forms.RadioButton()
        Me.radAbueloPaterno08 = New System.Windows.Forms.RadioButton()
        Me.radAbueloPaterno07 = New System.Windows.Forms.RadioButton()
        Me.radAbueloPaterno06 = New System.Windows.Forms.RadioButton()
        Me.radAbueloPaterno04 = New System.Windows.Forms.RadioButton()
        Me.radAbueloPaterno03 = New System.Windows.Forms.RadioButton()
        Me.radAbueloPaterno05 = New System.Windows.Forms.RadioButton()
        Me.radAbueloPaterno02 = New System.Windows.Forms.RadioButton()
        Me.radAbueloPaterno01 = New System.Windows.Forms.RadioButton()
        Me.GBAbueloPaternoAntecedentes = New System.Windows.Forms.GroupBox()
        Me.chkAbueloPaterno06 = New System.Windows.Forms.CheckBox()
        Me.chkAbueloPaterno05 = New System.Windows.Forms.CheckBox()
        Me.radAbueloPaternoTieneAnt = New System.Windows.Forms.RadioButton()
        Me.chkAbueloPaterno03 = New System.Windows.Forms.CheckBox()
        Me.radAbueloPaternoDesconocePatologia = New System.Windows.Forms.RadioButton()
        Me.chkAbueloPaterno02 = New System.Windows.Forms.CheckBox()
        Me.radAbueloPaternoNiega = New System.Windows.Forms.RadioButton()
        Me.txtAbueloPaternoOtrosAnt = New System.Windows.Forms.TextBox()
        Me.chkAbueloPaternoOtros = New System.Windows.Forms.CheckBox()
        Me.chkAbueloPaterno07 = New System.Windows.Forms.CheckBox()
        Me.chkAbueloPaterno04 = New System.Windows.Forms.CheckBox()
        Me.chkAbueloPaterno01 = New System.Windows.Forms.CheckBox()
        Me.radAbueloPaternoMuerta = New System.Windows.Forms.RadioButton()
        Me.radAbueloPaternoDesconoce = New System.Windows.Forms.RadioButton()
        Me.radAbueloPaternoViva = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GBAbuelaPaternaCausaMuerte = New System.Windows.Forms.GroupBox()
        Me.radAbuelaPaternaOtrasCausas = New System.Windows.Forms.RadioButton()
        Me.txtAbuelaPaternaOtrasCausas = New System.Windows.Forms.TextBox()
        Me.radAbuelaPaternaDesconoceCausa = New System.Windows.Forms.RadioButton()
        Me.radAbuelaPaterna08 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaPaterna07 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaPaterna06 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaPaterna04 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaPaterna03 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaPaterna05 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaPaterna02 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaPaterna01 = New System.Windows.Forms.RadioButton()
        Me.GBAbuelaPaternaAntecedentes = New System.Windows.Forms.GroupBox()
        Me.chkAbuelaPaterna06 = New System.Windows.Forms.CheckBox()
        Me.chkAbuelaPaterna05 = New System.Windows.Forms.CheckBox()
        Me.radAbuelaPaternaDesconocePatologia = New System.Windows.Forms.RadioButton()
        Me.chkAbuelaPaterna03 = New System.Windows.Forms.CheckBox()
        Me.radAbuelaPaternaTieneAnt = New System.Windows.Forms.RadioButton()
        Me.chkAbuelaPaterna02 = New System.Windows.Forms.CheckBox()
        Me.radAbuelaPaternaNiega = New System.Windows.Forms.RadioButton()
        Me.txtAbuelaPaternaOtrosAnt = New System.Windows.Forms.TextBox()
        Me.chkAbuelaPaternaOtros = New System.Windows.Forms.CheckBox()
        Me.chkAbuelaPaterna07 = New System.Windows.Forms.CheckBox()
        Me.chkAbuelaPaterna04 = New System.Windows.Forms.CheckBox()
        Me.chkAbuelaPaterna01 = New System.Windows.Forms.CheckBox()
        Me.radAbuelaPaternaMuerta = New System.Windows.Forms.RadioButton()
        Me.radAbuelaPaternaDesconoce = New System.Windows.Forms.RadioButton()
        Me.radAbuelaPaternaViva = New System.Windows.Forms.RadioButton()
        Me.TabPageAbuelosMaternos = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GBAbueloMaternoCausaMuerte = New System.Windows.Forms.GroupBox()
        Me.radAbueloMaternoOtrasCausas = New System.Windows.Forms.RadioButton()
        Me.txtAbueloMaternoOtrasCausas = New System.Windows.Forms.TextBox()
        Me.radAbueloMaternoDesconoceCausa = New System.Windows.Forms.RadioButton()
        Me.radAbueloMaterno08 = New System.Windows.Forms.RadioButton()
        Me.radAbueloMaterno07 = New System.Windows.Forms.RadioButton()
        Me.radAbueloMaterno06 = New System.Windows.Forms.RadioButton()
        Me.radAbueloMaterno04 = New System.Windows.Forms.RadioButton()
        Me.radAbueloMaterno03 = New System.Windows.Forms.RadioButton()
        Me.radAbueloMaterno05 = New System.Windows.Forms.RadioButton()
        Me.radAbueloMaterno02 = New System.Windows.Forms.RadioButton()
        Me.radAbueloMaterno01 = New System.Windows.Forms.RadioButton()
        Me.GBAbueloMaternoAntecedentes = New System.Windows.Forms.GroupBox()
        Me.chkAbueloMaterno06 = New System.Windows.Forms.CheckBox()
        Me.chkAbueloMaterno05 = New System.Windows.Forms.CheckBox()
        Me.radAbueloMaternoTieneAnt = New System.Windows.Forms.RadioButton()
        Me.chkAbueloMaterno03 = New System.Windows.Forms.CheckBox()
        Me.radAbueloMaternoDesconocePatologia = New System.Windows.Forms.RadioButton()
        Me.chkAbueloMaterno02 = New System.Windows.Forms.CheckBox()
        Me.radAbueloMaternoNiega = New System.Windows.Forms.RadioButton()
        Me.txtAbueloMaternoOtrosAnt = New System.Windows.Forms.TextBox()
        Me.chkAbueloMaternoOtros = New System.Windows.Forms.CheckBox()
        Me.chkAbueloMaterno07 = New System.Windows.Forms.CheckBox()
        Me.chkAbueloMaterno04 = New System.Windows.Forms.CheckBox()
        Me.chkAbueloMaterno01 = New System.Windows.Forms.CheckBox()
        Me.radAbueloMaternoMuerta = New System.Windows.Forms.RadioButton()
        Me.radAbueloMaternoDesconoce = New System.Windows.Forms.RadioButton()
        Me.radAbueloMaternoViva = New System.Windows.Forms.RadioButton()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.GBAbuelaMaternaCausaMuerte = New System.Windows.Forms.GroupBox()
        Me.radAbuelaMaternaOtrasCausas = New System.Windows.Forms.RadioButton()
        Me.txtAbuelaMaternaOtrasCausas = New System.Windows.Forms.TextBox()
        Me.radAbuelaMaternaDesconoceCausa = New System.Windows.Forms.RadioButton()
        Me.radAbuelaMaterna08 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaMaterna07 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaMaterna06 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaMaterna04 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaMaterna03 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaMaterna05 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaMaterna02 = New System.Windows.Forms.RadioButton()
        Me.radAbuelaMaterna01 = New System.Windows.Forms.RadioButton()
        Me.GBAbuelaMaternaAntecedentes = New System.Windows.Forms.GroupBox()
        Me.chkAbuelaMaterna06 = New System.Windows.Forms.CheckBox()
        Me.chkAbuelaMaterna05 = New System.Windows.Forms.CheckBox()
        Me.radAbuelaMaternaDesconocePatologia = New System.Windows.Forms.RadioButton()
        Me.chkAbuelaMaterna03 = New System.Windows.Forms.CheckBox()
        Me.radAbuelaMaternaTieneAnt = New System.Windows.Forms.RadioButton()
        Me.chkAbuelaMaterna02 = New System.Windows.Forms.CheckBox()
        Me.radAbuelaMaternaNiega = New System.Windows.Forms.RadioButton()
        Me.txtAbuelaMaternaOtrosAnt = New System.Windows.Forms.TextBox()
        Me.chkAbuelaMaternaOtros = New System.Windows.Forms.CheckBox()
        Me.chkAbuelaMaterna07 = New System.Windows.Forms.CheckBox()
        Me.chkAbuelaMaterna04 = New System.Windows.Forms.CheckBox()
        Me.chkAbuelaMaterna01 = New System.Windows.Forms.CheckBox()
        Me.radAbuelaMaternaMuerta = New System.Windows.Forms.RadioButton()
        Me.radAbuelaMaternaDesconoce = New System.Windows.Forms.RadioButton()
        Me.radAbuelaMaternaViva = New System.Windows.Forms.RadioButton()
        Me.TabPageOtros = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.txtOtrosFamiliares = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.chkTiosMuertos09 = New System.Windows.Forms.CheckBox()
        Me.chkTiosMuertos08 = New System.Windows.Forms.CheckBox()
        Me.chkTiosMuertos07 = New System.Windows.Forms.CheckBox()
        Me.chkTiosMuertos06 = New System.Windows.Forms.CheckBox()
        Me.chkTiosMuertos05 = New System.Windows.Forms.CheckBox()
        Me.chkTiosMuertos04 = New System.Windows.Forms.CheckBox()
        Me.chkTiosMuertos03 = New System.Windows.Forms.CheckBox()
        Me.chkTiosMuertos02 = New System.Windows.Forms.CheckBox()
        Me.chkTiosMuertos01 = New System.Windows.Forms.CheckBox()
        Me.txtTiosMuertosOtrasCausas = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.chkTios06 = New System.Windows.Forms.CheckBox()
        Me.chkTios05 = New System.Windows.Forms.CheckBox()
        Me.chkTios03 = New System.Windows.Forms.CheckBox()
        Me.chkTios02 = New System.Windows.Forms.CheckBox()
        Me.txtTiosOtrosAnt = New System.Windows.Forms.TextBox()
        Me.chkTios08 = New System.Windows.Forms.CheckBox()
        Me.chkTios07 = New System.Windows.Forms.CheckBox()
        Me.chkTios04 = New System.Windows.Forms.CheckBox()
        Me.chkTios01 = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkHermanosMuertos09 = New System.Windows.Forms.CheckBox()
        Me.chkHermanosMuertos08 = New System.Windows.Forms.CheckBox()
        Me.chkHermanosMuertos07 = New System.Windows.Forms.CheckBox()
        Me.chkHermanosMuertos06 = New System.Windows.Forms.CheckBox()
        Me.chkHermanosMuertos05 = New System.Windows.Forms.CheckBox()
        Me.chkHermanosMuertos04 = New System.Windows.Forms.CheckBox()
        Me.chkHermanosMuertos03 = New System.Windows.Forms.CheckBox()
        Me.chkHermanosMuertos02 = New System.Windows.Forms.CheckBox()
        Me.chkHermanosMuertos01 = New System.Windows.Forms.CheckBox()
        Me.txtHermanosMuertosOtrasCausas = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chkHermanos06 = New System.Windows.Forms.CheckBox()
        Me.chkHermanos05 = New System.Windows.Forms.CheckBox()
        Me.chkHermanos03 = New System.Windows.Forms.CheckBox()
        Me.chkHermanos02 = New System.Windows.Forms.CheckBox()
        Me.txtHermanosOtrosAnt = New System.Windows.Forms.TextBox()
        Me.chkHermanos08 = New System.Windows.Forms.CheckBox()
        Me.chkHermanos07 = New System.Windows.Forms.CheckBox()
        Me.chkHermanos04 = New System.Windows.Forms.CheckBox()
        Me.chkHermanos01 = New System.Windows.Forms.CheckBox()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPagePadres.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBpadreCausaMuerte.SuspendLayout()
        Me.GBpadreAntecedentes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBmadreCausaMuerte.SuspendLayout()
        Me.GBmadreAntecedentes.SuspendLayout()
        Me.TabPageAbuelosPaternos.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GBAbueloPaternocausaMuerte.SuspendLayout()
        Me.GBAbueloPaternoAntecedentes.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GBAbuelaPaternaCausaMuerte.SuspendLayout()
        Me.GBAbuelaPaternaAntecedentes.SuspendLayout()
        Me.TabPageAbuelosMaternos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GBAbueloMaternoCausaMuerte.SuspendLayout()
        Me.GBAbueloMaternoAntecedentes.SuspendLayout()
        Me.gb2.SuspendLayout()
        Me.GBAbuelaMaternaCausaMuerte.SuspendLayout()
        Me.GBAbuelaMaternaAntecedentes.SuspendLayout()
        Me.TabPageOtros.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPagePadres)
        Me.TabControl1.Controls.Add(Me.TabPageAbuelosPaternos)
        Me.TabControl1.Controls.Add(Me.TabPageAbuelosMaternos)
        Me.TabControl1.Controls.Add(Me.TabPageOtros)
        Me.TabControl1.Location = New System.Drawing.Point(8, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(974, 475)
        Me.TabControl1.TabIndex = 0
        '
        'TabPagePadres
        '
        Me.TabPagePadres.Controls.Add(Me.GroupBox2)
        Me.TabPagePadres.Controls.Add(Me.GroupBox1)
        Me.TabPagePadres.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePadres.Name = "TabPagePadres"
        Me.TabPagePadres.Size = New System.Drawing.Size(966, 449)
        Me.TabPagePadres.TabIndex = 0
        Me.TabPagePadres.Text = "Padres"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GBpadreCausaMuerte)
        Me.GroupBox2.Controls.Add(Me.GBpadreAntecedentes)
        Me.GroupBox2.Controls.Add(Me.radPadreMuerta)
        Me.GroupBox2.Controls.Add(Me.radPadreDesconoce)
        Me.GroupBox2.Controls.Add(Me.radPadreViva)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(752, 218)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Antecedentes PATERNOS"
        '
        'GBpadreCausaMuerte
        '
        Me.GBpadreCausaMuerte.Controls.Add(Me.radPadreOtrasCausas)
        Me.GBpadreCausaMuerte.Controls.Add(Me.txtPadreOtrasCausas)
        Me.GBpadreCausaMuerte.Controls.Add(Me.radPadreDesconoceCausa)
        Me.GBpadreCausaMuerte.Controls.Add(Me.radPadre08)
        Me.GBpadreCausaMuerte.Controls.Add(Me.radPadre07)
        Me.GBpadreCausaMuerte.Controls.Add(Me.radPadre06)
        Me.GBpadreCausaMuerte.Controls.Add(Me.radPadre04)
        Me.GBpadreCausaMuerte.Controls.Add(Me.radPadre03)
        Me.GBpadreCausaMuerte.Controls.Add(Me.radPadre05)
        Me.GBpadreCausaMuerte.Controls.Add(Me.radPadre02)
        Me.GBpadreCausaMuerte.Controls.Add(Me.radPadre01)
        Me.GBpadreCausaMuerte.Enabled = False
        Me.GBpadreCausaMuerte.Location = New System.Drawing.Point(8, 128)
        Me.GBpadreCausaMuerte.Name = "GBpadreCausaMuerte"
        Me.GBpadreCausaMuerte.Size = New System.Drawing.Size(736, 84)
        Me.GBpadreCausaMuerte.TabIndex = 4
        Me.GBpadreCausaMuerte.TabStop = False
        Me.GBpadreCausaMuerte.Text = "Causa Directa del Fallecimiento"
        '
        'radPadreOtrasCausas
        '
        Me.radPadreOtrasCausas.Location = New System.Drawing.Point(356, 16)
        Me.radPadreOtrasCausas.Name = "radPadreOtrasCausas"
        Me.radPadreOtrasCausas.Size = New System.Drawing.Size(56, 24)
        Me.radPadreOtrasCausas.TabIndex = 11
        Me.radPadreOtrasCausas.Text = "Otra"
        '
        'txtPadreOtrasCausas
        '
        Me.txtPadreOtrasCausas.Enabled = False
        Me.txtPadreOtrasCausas.Location = New System.Drawing.Point(424, 12)
        Me.txtPadreOtrasCausas.MaxLength = 512
        Me.txtPadreOtrasCausas.Multiline = True
        Me.txtPadreOtrasCausas.Name = "txtPadreOtrasCausas"
        Me.txtPadreOtrasCausas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPadreOtrasCausas.Size = New System.Drawing.Size(304, 64)
        Me.txtPadreOtrasCausas.TabIndex = 10
        '
        'radPadreDesconoceCausa
        '
        Me.radPadreDesconoceCausa.Location = New System.Drawing.Point(252, 56)
        Me.radPadreDesconoceCausa.Name = "radPadreDesconoceCausa"
        Me.radPadreDesconoceCausa.Size = New System.Drawing.Size(84, 24)
        Me.radPadreDesconoceCausa.TabIndex = 9
        Me.radPadreDesconoceCausa.Text = "Desconoce"
        '
        'radPadre08
        '
        Me.radPadre08.Location = New System.Drawing.Point(252, 36)
        Me.radPadre08.Name = "radPadre08"
        Me.radPadre08.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radPadre08.Size = New System.Drawing.Size(84, 24)
        Me.radPadre08.TabIndex = 8
        Me.radPadre08.Text = "Natural"
        '
        'radPadre07
        '
        Me.radPadre07.Location = New System.Drawing.Point(252, 16)
        Me.radPadre07.Name = "radPadre07"
        Me.radPadre07.Size = New System.Drawing.Size(84, 24)
        Me.radPadre07.TabIndex = 7
        Me.radPadre07.Text = "Metabólica"
        '
        'radPadre06
        '
        Me.radPadre06.Location = New System.Drawing.Point(160, 56)
        Me.radPadre06.Name = "radPadre06"
        Me.radPadre06.Size = New System.Drawing.Size(84, 24)
        Me.radPadre06.TabIndex = 6
        Me.radPadre06.Text = "Oncológica"
        '
        'radPadre04
        '
        Me.radPadre04.Location = New System.Drawing.Point(160, 16)
        Me.radPadre04.Name = "radPadre04"
        Me.radPadre04.Size = New System.Drawing.Size(84, 24)
        Me.radPadre04.TabIndex = 5
        Me.radPadre04.Text = "Hepatopatía"
        '
        'radPadre03
        '
        Me.radPadre03.Location = New System.Drawing.Point(8, 56)
        Me.radPadre03.Name = "radPadre03"
        Me.radPadre03.Size = New System.Drawing.Size(104, 24)
        Me.radPadre03.TabIndex = 4
        Me.radPadre03.Text = "Nefropatía"
        '
        'radPadre05
        '
        Me.radPadre05.Location = New System.Drawing.Point(160, 36)
        Me.radPadre05.Name = "radPadre05"
        Me.radPadre05.Size = New System.Drawing.Size(84, 24)
        Me.radPadre05.TabIndex = 3
        Me.radPadre05.Text = "Neumopatía"
        '
        'radPadre02
        '
        Me.radPadre02.Location = New System.Drawing.Point(8, 36)
        Me.radPadre02.Name = "radPadre02"
        Me.radPadre02.Size = New System.Drawing.Size(104, 24)
        Me.radPadre02.TabIndex = 2
        Me.radPadre02.Text = "Neuropatía"
        '
        'radPadre01
        '
        Me.radPadre01.Location = New System.Drawing.Point(8, 16)
        Me.radPadre01.Name = "radPadre01"
        Me.radPadre01.Size = New System.Drawing.Size(104, 24)
        Me.radPadre01.TabIndex = 1
        Me.radPadre01.Text = "Cardiopatía"
        '
        'GBpadreAntecedentes
        '
        Me.GBpadreAntecedentes.Controls.Add(Me.chkPadre06)
        Me.GBpadreAntecedentes.Controls.Add(Me.chkPadre05)
        Me.GBpadreAntecedentes.Controls.Add(Me.radPadreTieneAnt)
        Me.GBpadreAntecedentes.Controls.Add(Me.chkPadre03)
        Me.GBpadreAntecedentes.Controls.Add(Me.radPadreDesconocePatologia)
        Me.GBpadreAntecedentes.Controls.Add(Me.chkPadre02)
        Me.GBpadreAntecedentes.Controls.Add(Me.radPadreNiega)
        Me.GBpadreAntecedentes.Controls.Add(Me.txtPadreOtrosAnt)
        Me.GBpadreAntecedentes.Controls.Add(Me.chkPadreotros)
        Me.GBpadreAntecedentes.Controls.Add(Me.chkPadre07)
        Me.GBpadreAntecedentes.Controls.Add(Me.chkPadre04)
        Me.GBpadreAntecedentes.Controls.Add(Me.chkPadre01)
        Me.GBpadreAntecedentes.Location = New System.Drawing.Point(8, 40)
        Me.GBpadreAntecedentes.Name = "GBpadreAntecedentes"
        Me.GBpadreAntecedentes.Size = New System.Drawing.Size(736, 84)
        Me.GBpadreAntecedentes.TabIndex = 3
        Me.GBpadreAntecedentes.TabStop = False
        Me.GBpadreAntecedentes.Text = "Antecedentes de"
        '
        'chkPadre06
        '
        Me.chkPadre06.Location = New System.Drawing.Point(252, 56)
        Me.chkPadre06.Name = "chkPadre06"
        Me.chkPadre06.Size = New System.Drawing.Size(96, 24)
        Me.chkPadre06.TabIndex = 6
        Me.chkPadre06.Text = "Nefrópata"
        '
        'chkPadre05
        '
        Me.chkPadre05.Location = New System.Drawing.Point(252, 36)
        Me.chkPadre05.Name = "chkPadre05"
        Me.chkPadre05.Size = New System.Drawing.Size(96, 24)
        Me.chkPadre05.TabIndex = 5
        Me.chkPadre05.Text = "Epilepsia"
        '
        'radPadreTieneAnt
        '
        Me.radPadreTieneAnt.Location = New System.Drawing.Point(8, 34)
        Me.radPadreTieneAnt.Name = "radPadreTieneAnt"
        Me.radPadreTieneAnt.Size = New System.Drawing.Size(140, 23)
        Me.radPadreTieneAnt.TabIndex = 11
        Me.radPadreTieneAnt.Text = "Tiene Antecedentes"
        '
        'chkPadre03
        '
        Me.chkPadre03.Location = New System.Drawing.Point(160, 56)
        Me.chkPadre03.Name = "chkPadre03"
        Me.chkPadre03.Size = New System.Drawing.Size(56, 24)
        Me.chkPadre03.TabIndex = 3
        Me.chkPadre03.Text = "TBC"
        '
        'radPadreDesconocePatologia
        '
        Me.radPadreDesconocePatologia.Location = New System.Drawing.Point(8, 52)
        Me.radPadreDesconocePatologia.Name = "radPadreDesconocePatologia"
        Me.radPadreDesconocePatologia.Size = New System.Drawing.Size(152, 24)
        Me.radPadreDesconocePatologia.TabIndex = 12
        Me.radPadreDesconocePatologia.Text = "Desconoce Antecedentes"
        '
        'chkPadre02
        '
        Me.chkPadre02.Location = New System.Drawing.Point(160, 36)
        Me.chkPadre02.Name = "chkPadre02"
        Me.chkPadre02.Size = New System.Drawing.Size(56, 24)
        Me.chkPadre02.TabIndex = 2
        Me.chkPadre02.Text = "DM"
        '
        'radPadreNiega
        '
        Me.radPadreNiega.Location = New System.Drawing.Point(8, 16)
        Me.radPadreNiega.Name = "radPadreNiega"
        Me.radPadreNiega.Size = New System.Drawing.Size(128, 24)
        Me.radPadreNiega.TabIndex = 10
        Me.radPadreNiega.Text = "Niega Antecedentes"
        '
        'txtPadreOtrosAnt
        '
        Me.txtPadreOtrosAnt.Enabled = False
        Me.txtPadreOtrosAnt.Location = New System.Drawing.Point(424, 12)
        Me.txtPadreOtrosAnt.MaxLength = 512
        Me.txtPadreOtrosAnt.Multiline = True
        Me.txtPadreOtrosAnt.Name = "txtPadreOtrosAnt"
        Me.txtPadreOtrosAnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPadreOtrosAnt.Size = New System.Drawing.Size(304, 64)
        Me.txtPadreOtrosAnt.TabIndex = 9
        '
        'chkPadreotros
        '
        Me.chkPadreotros.Location = New System.Drawing.Point(356, 36)
        Me.chkPadreotros.Name = "chkPadreotros"
        Me.chkPadreotros.Size = New System.Drawing.Size(64, 24)
        Me.chkPadreotros.TabIndex = 8
        Me.chkPadreotros.Text = "Otros"
        '
        'chkPadre07
        '
        Me.chkPadre07.Location = New System.Drawing.Point(356, 16)
        Me.chkPadre07.Name = "chkPadre07"
        Me.chkPadre07.Size = New System.Drawing.Size(64, 24)
        Me.chkPadre07.TabIndex = 7
        Me.chkPadre07.Text = "Cáncer"
        '
        'chkPadre04
        '
        Me.chkPadre04.Location = New System.Drawing.Point(252, 16)
        Me.chkPadre04.Name = "chkPadre04"
        Me.chkPadre04.Size = New System.Drawing.Size(80, 24)
        Me.chkPadre04.TabIndex = 4
        Me.chkPadre04.Text = "Cardiópata"
        '
        'chkPadre01
        '
        Me.chkPadre01.Location = New System.Drawing.Point(160, 16)
        Me.chkPadre01.Name = "chkPadre01"
        Me.chkPadre01.Size = New System.Drawing.Size(56, 24)
        Me.chkPadre01.TabIndex = 1
        Me.chkPadre01.Text = "HTA"
        '
        'radPadreMuerta
        '
        Me.radPadreMuerta.Location = New System.Drawing.Point(112, 16)
        Me.radPadreMuerta.Name = "radPadreMuerta"
        Me.radPadreMuerta.Size = New System.Drawing.Size(104, 24)
        Me.radPadreMuerta.TabIndex = 1
        Me.radPadreMuerta.Text = "Muerto"
        '
        'radPadreDesconoce
        '
        Me.radPadreDesconoce.Location = New System.Drawing.Point(216, 16)
        Me.radPadreDesconoce.Name = "radPadreDesconoce"
        Me.radPadreDesconoce.Size = New System.Drawing.Size(80, 24)
        Me.radPadreDesconoce.TabIndex = 2
        Me.radPadreDesconoce.Text = "Desconoce"
        '
        'radPadreViva
        '
        Me.radPadreViva.Location = New System.Drawing.Point(8, 16)
        Me.radPadreViva.Name = "radPadreViva"
        Me.radPadreViva.Size = New System.Drawing.Size(72, 24)
        Me.radPadreViva.TabIndex = 0
        Me.radPadreViva.Text = "Vivo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GBmadreCausaMuerte)
        Me.GroupBox1.Controls.Add(Me.GBmadreAntecedentes)
        Me.GroupBox1.Controls.Add(Me.radMadreMuerta)
        Me.GroupBox1.Controls.Add(Me.radMadreDesconoce)
        Me.GroupBox1.Controls.Add(Me.radMadreViva)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 218)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Antecedentes MATERNOS"
        '
        'GBmadreCausaMuerte
        '
        Me.GBmadreCausaMuerte.Controls.Add(Me.radMadreOtrasCausas)
        Me.GBmadreCausaMuerte.Controls.Add(Me.txtMadreOtrasCausas)
        Me.GBmadreCausaMuerte.Controls.Add(Me.radMadreDesconoceCausa)
        Me.GBmadreCausaMuerte.Controls.Add(Me.radMadre08)
        Me.GBmadreCausaMuerte.Controls.Add(Me.radMadre07)
        Me.GBmadreCausaMuerte.Controls.Add(Me.radMadre06)
        Me.GBmadreCausaMuerte.Controls.Add(Me.radMadre04)
        Me.GBmadreCausaMuerte.Controls.Add(Me.radMadre03)
        Me.GBmadreCausaMuerte.Controls.Add(Me.radMadre05)
        Me.GBmadreCausaMuerte.Controls.Add(Me.radMadre02)
        Me.GBmadreCausaMuerte.Controls.Add(Me.radMadre01)
        Me.GBmadreCausaMuerte.Enabled = False
        Me.GBmadreCausaMuerte.Location = New System.Drawing.Point(8, 128)
        Me.GBmadreCausaMuerte.Name = "GBmadreCausaMuerte"
        Me.GBmadreCausaMuerte.Size = New System.Drawing.Size(736, 84)
        Me.GBmadreCausaMuerte.TabIndex = 4
        Me.GBmadreCausaMuerte.TabStop = False
        Me.GBmadreCausaMuerte.Text = "Causa Directa del Fallecimiento"
        '
        'radMadreOtrasCausas
        '
        Me.radMadreOtrasCausas.Location = New System.Drawing.Point(356, 16)
        Me.radMadreOtrasCausas.Name = "radMadreOtrasCausas"
        Me.radMadreOtrasCausas.Size = New System.Drawing.Size(56, 24)
        Me.radMadreOtrasCausas.TabIndex = 11
        Me.radMadreOtrasCausas.Text = "Otra"
        '
        'txtMadreOtrasCausas
        '
        Me.txtMadreOtrasCausas.Enabled = False
        Me.txtMadreOtrasCausas.Location = New System.Drawing.Point(424, 12)
        Me.txtMadreOtrasCausas.MaxLength = 512
        Me.txtMadreOtrasCausas.Multiline = True
        Me.txtMadreOtrasCausas.Name = "txtMadreOtrasCausas"
        Me.txtMadreOtrasCausas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMadreOtrasCausas.Size = New System.Drawing.Size(304, 64)
        Me.txtMadreOtrasCausas.TabIndex = 10
        '
        'radMadreDesconoceCausa
        '
        Me.radMadreDesconoceCausa.Location = New System.Drawing.Point(252, 56)
        Me.radMadreDesconoceCausa.Name = "radMadreDesconoceCausa"
        Me.radMadreDesconoceCausa.Size = New System.Drawing.Size(84, 24)
        Me.radMadreDesconoceCausa.TabIndex = 9
        Me.radMadreDesconoceCausa.Text = "Desconoce"
        '
        'radMadre08
        '
        Me.radMadre08.Location = New System.Drawing.Point(252, 36)
        Me.radMadre08.Name = "radMadre08"
        Me.radMadre08.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radMadre08.Size = New System.Drawing.Size(84, 24)
        Me.radMadre08.TabIndex = 8
        Me.radMadre08.Text = "Natural"
        '
        'radMadre07
        '
        Me.radMadre07.Location = New System.Drawing.Point(252, 16)
        Me.radMadre07.Name = "radMadre07"
        Me.radMadre07.Size = New System.Drawing.Size(84, 24)
        Me.radMadre07.TabIndex = 7
        Me.radMadre07.Text = "Metabólica"
        '
        'radMadre06
        '
        Me.radMadre06.Location = New System.Drawing.Point(160, 56)
        Me.radMadre06.Name = "radMadre06"
        Me.radMadre06.Size = New System.Drawing.Size(84, 24)
        Me.radMadre06.TabIndex = 6
        Me.radMadre06.Text = "Oncológica"
        '
        'radMadre04
        '
        Me.radMadre04.Location = New System.Drawing.Point(160, 16)
        Me.radMadre04.Name = "radMadre04"
        Me.radMadre04.Size = New System.Drawing.Size(84, 24)
        Me.radMadre04.TabIndex = 5
        Me.radMadre04.Text = "Hepatopatía"
        '
        'radMadre03
        '
        Me.radMadre03.Location = New System.Drawing.Point(8, 56)
        Me.radMadre03.Name = "radMadre03"
        Me.radMadre03.Size = New System.Drawing.Size(104, 24)
        Me.radMadre03.TabIndex = 4
        Me.radMadre03.Text = "Nefropatía"
        '
        'radMadre05
        '
        Me.radMadre05.Location = New System.Drawing.Point(160, 36)
        Me.radMadre05.Name = "radMadre05"
        Me.radMadre05.Size = New System.Drawing.Size(84, 24)
        Me.radMadre05.TabIndex = 3
        Me.radMadre05.Text = "Neumopatía"
        '
        'radMadre02
        '
        Me.radMadre02.Location = New System.Drawing.Point(8, 36)
        Me.radMadre02.Name = "radMadre02"
        Me.radMadre02.Size = New System.Drawing.Size(104, 24)
        Me.radMadre02.TabIndex = 2
        Me.radMadre02.Text = "Neuropatía"
        '
        'radMadre01
        '
        Me.radMadre01.Location = New System.Drawing.Point(8, 16)
        Me.radMadre01.Name = "radMadre01"
        Me.radMadre01.Size = New System.Drawing.Size(104, 24)
        Me.radMadre01.TabIndex = 1
        Me.radMadre01.Text = "Cardiopatía"
        '
        'GBmadreAntecedentes
        '
        Me.GBmadreAntecedentes.Controls.Add(Me.chkMadre06)
        Me.GBmadreAntecedentes.Controls.Add(Me.chkMadre05)
        Me.GBmadreAntecedentes.Controls.Add(Me.radMadreDesconocePatologia)
        Me.GBmadreAntecedentes.Controls.Add(Me.chkMadre03)
        Me.GBmadreAntecedentes.Controls.Add(Me.radMadreTieneAnt)
        Me.GBmadreAntecedentes.Controls.Add(Me.chkMadre02)
        Me.GBmadreAntecedentes.Controls.Add(Me.radMadreNiega)
        Me.GBmadreAntecedentes.Controls.Add(Me.txtMadreOtrosAnt)
        Me.GBmadreAntecedentes.Controls.Add(Me.chkMadreOtros)
        Me.GBmadreAntecedentes.Controls.Add(Me.chkMadre07)
        Me.GBmadreAntecedentes.Controls.Add(Me.chkMadre04)
        Me.GBmadreAntecedentes.Controls.Add(Me.chkMadre01)
        Me.GBmadreAntecedentes.Location = New System.Drawing.Point(8, 40)
        Me.GBmadreAntecedentes.Name = "GBmadreAntecedentes"
        Me.GBmadreAntecedentes.Size = New System.Drawing.Size(736, 84)
        Me.GBmadreAntecedentes.TabIndex = 3
        Me.GBmadreAntecedentes.TabStop = False
        Me.GBmadreAntecedentes.Text = "Antecedentes de"
        '
        'chkMadre06
        '
        Me.chkMadre06.Location = New System.Drawing.Point(252, 56)
        Me.chkMadre06.Name = "chkMadre06"
        Me.chkMadre06.Size = New System.Drawing.Size(96, 24)
        Me.chkMadre06.TabIndex = 6
        Me.chkMadre06.Text = "Nefrópata"
        '
        'chkMadre05
        '
        Me.chkMadre05.Location = New System.Drawing.Point(252, 36)
        Me.chkMadre05.Name = "chkMadre05"
        Me.chkMadre05.Size = New System.Drawing.Size(96, 24)
        Me.chkMadre05.TabIndex = 5
        Me.chkMadre05.Text = "Epilepsia"
        '
        'radMadreDesconocePatologia
        '
        Me.radMadreDesconocePatologia.Location = New System.Drawing.Point(8, 56)
        Me.radMadreDesconocePatologia.Name = "radMadreDesconocePatologia"
        Me.radMadreDesconocePatologia.Size = New System.Drawing.Size(152, 24)
        Me.radMadreDesconocePatologia.TabIndex = 11
        Me.radMadreDesconocePatologia.Text = "Desconoce Antecedentes"
        '
        'chkMadre03
        '
        Me.chkMadre03.Location = New System.Drawing.Point(160, 56)
        Me.chkMadre03.Name = "chkMadre03"
        Me.chkMadre03.Size = New System.Drawing.Size(56, 24)
        Me.chkMadre03.TabIndex = 3
        Me.chkMadre03.Text = "TBC"
        '
        'radMadreTieneAnt
        '
        Me.radMadreTieneAnt.Location = New System.Drawing.Point(8, 36)
        Me.radMadreTieneAnt.Name = "radMadreTieneAnt"
        Me.radMadreTieneAnt.Size = New System.Drawing.Size(152, 24)
        Me.radMadreTieneAnt.TabIndex = 12
        Me.radMadreTieneAnt.Text = "Tiene Antecedentes"
        '
        'chkMadre02
        '
        Me.chkMadre02.Location = New System.Drawing.Point(160, 36)
        Me.chkMadre02.Name = "chkMadre02"
        Me.chkMadre02.Size = New System.Drawing.Size(56, 24)
        Me.chkMadre02.TabIndex = 2
        Me.chkMadre02.Text = "DM"
        '
        'radMadreNiega
        '
        Me.radMadreNiega.Location = New System.Drawing.Point(8, 16)
        Me.radMadreNiega.Name = "radMadreNiega"
        Me.radMadreNiega.Size = New System.Drawing.Size(128, 24)
        Me.radMadreNiega.TabIndex = 10
        Me.radMadreNiega.Text = "Niega Antecedentes"
        '
        'txtMadreOtrosAnt
        '
        Me.txtMadreOtrosAnt.Enabled = False
        Me.txtMadreOtrosAnt.Location = New System.Drawing.Point(424, 12)
        Me.txtMadreOtrosAnt.MaxLength = 512
        Me.txtMadreOtrosAnt.Multiline = True
        Me.txtMadreOtrosAnt.Name = "txtMadreOtrosAnt"
        Me.txtMadreOtrosAnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMadreOtrosAnt.Size = New System.Drawing.Size(304, 64)
        Me.txtMadreOtrosAnt.TabIndex = 9
        '
        'chkMadreOtros
        '
        Me.chkMadreOtros.Location = New System.Drawing.Point(356, 36)
        Me.chkMadreOtros.Name = "chkMadreOtros"
        Me.chkMadreOtros.Size = New System.Drawing.Size(64, 24)
        Me.chkMadreOtros.TabIndex = 8
        Me.chkMadreOtros.Text = "Otros"
        '
        'chkMadre07
        '
        Me.chkMadre07.Location = New System.Drawing.Point(356, 16)
        Me.chkMadre07.Name = "chkMadre07"
        Me.chkMadre07.Size = New System.Drawing.Size(64, 24)
        Me.chkMadre07.TabIndex = 7
        Me.chkMadre07.Text = "Cáncer"
        '
        'chkMadre04
        '
        Me.chkMadre04.Location = New System.Drawing.Point(252, 16)
        Me.chkMadre04.Name = "chkMadre04"
        Me.chkMadre04.Size = New System.Drawing.Size(80, 24)
        Me.chkMadre04.TabIndex = 4
        Me.chkMadre04.Text = "Cardiópata"
        '
        'chkMadre01
        '
        Me.chkMadre01.Location = New System.Drawing.Point(160, 16)
        Me.chkMadre01.Name = "chkMadre01"
        Me.chkMadre01.Size = New System.Drawing.Size(56, 24)
        Me.chkMadre01.TabIndex = 1
        Me.chkMadre01.Text = "HTA"
        '
        'radMadreMuerta
        '
        Me.radMadreMuerta.Location = New System.Drawing.Point(112, 16)
        Me.radMadreMuerta.Name = "radMadreMuerta"
        Me.radMadreMuerta.Size = New System.Drawing.Size(104, 24)
        Me.radMadreMuerta.TabIndex = 1
        Me.radMadreMuerta.Text = "Muerta"
        '
        'radMadreDesconoce
        '
        Me.radMadreDesconoce.Location = New System.Drawing.Point(216, 16)
        Me.radMadreDesconoce.Name = "radMadreDesconoce"
        Me.radMadreDesconoce.Size = New System.Drawing.Size(80, 24)
        Me.radMadreDesconoce.TabIndex = 2
        Me.radMadreDesconoce.Text = "Desconoce"
        '
        'radMadreViva
        '
        Me.radMadreViva.Location = New System.Drawing.Point(8, 16)
        Me.radMadreViva.Name = "radMadreViva"
        Me.radMadreViva.Size = New System.Drawing.Size(72, 24)
        Me.radMadreViva.TabIndex = 0
        Me.radMadreViva.Text = "Viva"
        '
        'TabPageAbuelosPaternos
        '
        Me.TabPageAbuelosPaternos.Controls.Add(Me.GroupBox4)
        Me.TabPageAbuelosPaternos.Controls.Add(Me.GroupBox7)
        Me.TabPageAbuelosPaternos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAbuelosPaternos.Name = "TabPageAbuelosPaternos"
        Me.TabPageAbuelosPaternos.Size = New System.Drawing.Size(966, 449)
        Me.TabPageAbuelosPaternos.TabIndex = 3
        Me.TabPageAbuelosPaternos.Text = "Abuelos Paternos"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GBAbueloPaternocausaMuerte)
        Me.GroupBox4.Controls.Add(Me.GBAbueloPaternoAntecedentes)
        Me.GroupBox4.Controls.Add(Me.radAbueloPaternoMuerta)
        Me.GroupBox4.Controls.Add(Me.radAbueloPaternoDesconoce)
        Me.GroupBox4.Controls.Add(Me.radAbueloPaternoViva)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 225)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(752, 218)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ABUELO PATERNO"
        '
        'GBAbueloPaternocausaMuerte
        '
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.radAbueloPaternoOtrasCausas)
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.txtAbueloPaternoOtrasCausas)
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.radAbueloPaternoDesconoceCausa)
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.radAbueloPaterno08)
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.radAbueloPaterno07)
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.radAbueloPaterno06)
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.radAbueloPaterno04)
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.radAbueloPaterno03)
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.radAbueloPaterno05)
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.radAbueloPaterno02)
        Me.GBAbueloPaternocausaMuerte.Controls.Add(Me.radAbueloPaterno01)
        Me.GBAbueloPaternocausaMuerte.Enabled = False
        Me.GBAbueloPaternocausaMuerte.Location = New System.Drawing.Point(8, 128)
        Me.GBAbueloPaternocausaMuerte.Name = "GBAbueloPaternocausaMuerte"
        Me.GBAbueloPaternocausaMuerte.Size = New System.Drawing.Size(736, 84)
        Me.GBAbueloPaternocausaMuerte.TabIndex = 4
        Me.GBAbueloPaternocausaMuerte.TabStop = False
        Me.GBAbueloPaternocausaMuerte.Text = "Causa Directa del Fallecimiento"
        '
        'radAbueloPaternoOtrasCausas
        '
        Me.radAbueloPaternoOtrasCausas.Location = New System.Drawing.Point(356, 16)
        Me.radAbueloPaternoOtrasCausas.Name = "radAbueloPaternoOtrasCausas"
        Me.radAbueloPaternoOtrasCausas.Size = New System.Drawing.Size(56, 24)
        Me.radAbueloPaternoOtrasCausas.TabIndex = 11
        Me.radAbueloPaternoOtrasCausas.Text = "Otra"
        '
        'txtAbueloPaternoOtrasCausas
        '
        Me.txtAbueloPaternoOtrasCausas.Enabled = False
        Me.txtAbueloPaternoOtrasCausas.Location = New System.Drawing.Point(424, 12)
        Me.txtAbueloPaternoOtrasCausas.MaxLength = 512
        Me.txtAbueloPaternoOtrasCausas.Multiline = True
        Me.txtAbueloPaternoOtrasCausas.Name = "txtAbueloPaternoOtrasCausas"
        Me.txtAbueloPaternoOtrasCausas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbueloPaternoOtrasCausas.Size = New System.Drawing.Size(304, 64)
        Me.txtAbueloPaternoOtrasCausas.TabIndex = 10
        '
        'radAbueloPaternoDesconoceCausa
        '
        Me.radAbueloPaternoDesconoceCausa.Location = New System.Drawing.Point(252, 56)
        Me.radAbueloPaternoDesconoceCausa.Name = "radAbueloPaternoDesconoceCausa"
        Me.radAbueloPaternoDesconoceCausa.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloPaternoDesconoceCausa.TabIndex = 9
        Me.radAbueloPaternoDesconoceCausa.Text = "Desconoce"
        '
        'radAbueloPaterno08
        '
        Me.radAbueloPaterno08.Location = New System.Drawing.Point(252, 36)
        Me.radAbueloPaterno08.Name = "radAbueloPaterno08"
        Me.radAbueloPaterno08.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radAbueloPaterno08.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloPaterno08.TabIndex = 8
        Me.radAbueloPaterno08.Text = "Natural"
        '
        'radAbueloPaterno07
        '
        Me.radAbueloPaterno07.Location = New System.Drawing.Point(252, 16)
        Me.radAbueloPaterno07.Name = "radAbueloPaterno07"
        Me.radAbueloPaterno07.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloPaterno07.TabIndex = 7
        Me.radAbueloPaterno07.Text = "Metabólica"
        '
        'radAbueloPaterno06
        '
        Me.radAbueloPaterno06.Location = New System.Drawing.Point(160, 56)
        Me.radAbueloPaterno06.Name = "radAbueloPaterno06"
        Me.radAbueloPaterno06.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloPaterno06.TabIndex = 6
        Me.radAbueloPaterno06.Text = "Oncológica"
        '
        'radAbueloPaterno04
        '
        Me.radAbueloPaterno04.Location = New System.Drawing.Point(160, 16)
        Me.radAbueloPaterno04.Name = "radAbueloPaterno04"
        Me.radAbueloPaterno04.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloPaterno04.TabIndex = 5
        Me.radAbueloPaterno04.Text = "Hepatopatía"
        '
        'radAbueloPaterno03
        '
        Me.radAbueloPaterno03.Location = New System.Drawing.Point(8, 56)
        Me.radAbueloPaterno03.Name = "radAbueloPaterno03"
        Me.radAbueloPaterno03.Size = New System.Drawing.Size(104, 24)
        Me.radAbueloPaterno03.TabIndex = 4
        Me.radAbueloPaterno03.Text = "Nefropatía"
        '
        'radAbueloPaterno05
        '
        Me.radAbueloPaterno05.Location = New System.Drawing.Point(160, 36)
        Me.radAbueloPaterno05.Name = "radAbueloPaterno05"
        Me.radAbueloPaterno05.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloPaterno05.TabIndex = 3
        Me.radAbueloPaterno05.Text = "Neumopatía"
        '
        'radAbueloPaterno02
        '
        Me.radAbueloPaterno02.Location = New System.Drawing.Point(8, 36)
        Me.radAbueloPaterno02.Name = "radAbueloPaterno02"
        Me.radAbueloPaterno02.Size = New System.Drawing.Size(104, 24)
        Me.radAbueloPaterno02.TabIndex = 2
        Me.radAbueloPaterno02.Text = "Neuropatía"
        '
        'radAbueloPaterno01
        '
        Me.radAbueloPaterno01.Location = New System.Drawing.Point(8, 16)
        Me.radAbueloPaterno01.Name = "radAbueloPaterno01"
        Me.radAbueloPaterno01.Size = New System.Drawing.Size(104, 24)
        Me.radAbueloPaterno01.TabIndex = 1
        Me.radAbueloPaterno01.Text = "Cardiopatía"
        '
        'GBAbueloPaternoAntecedentes
        '
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.chkAbueloPaterno06)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.chkAbueloPaterno05)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.radAbueloPaternoTieneAnt)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.chkAbueloPaterno03)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.radAbueloPaternoDesconocePatologia)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.chkAbueloPaterno02)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.radAbueloPaternoNiega)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.txtAbueloPaternoOtrosAnt)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.chkAbueloPaternoOtros)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.chkAbueloPaterno07)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.chkAbueloPaterno04)
        Me.GBAbueloPaternoAntecedentes.Controls.Add(Me.chkAbueloPaterno01)
        Me.GBAbueloPaternoAntecedentes.Location = New System.Drawing.Point(8, 40)
        Me.GBAbueloPaternoAntecedentes.Name = "GBAbueloPaternoAntecedentes"
        Me.GBAbueloPaternoAntecedentes.Size = New System.Drawing.Size(736, 84)
        Me.GBAbueloPaternoAntecedentes.TabIndex = 3
        Me.GBAbueloPaternoAntecedentes.TabStop = False
        Me.GBAbueloPaternoAntecedentes.Text = "Antecedentes de"
        '
        'chkAbueloPaterno06
        '
        Me.chkAbueloPaterno06.Location = New System.Drawing.Point(252, 56)
        Me.chkAbueloPaterno06.Name = "chkAbueloPaterno06"
        Me.chkAbueloPaterno06.Size = New System.Drawing.Size(96, 24)
        Me.chkAbueloPaterno06.TabIndex = 6
        Me.chkAbueloPaterno06.Text = "Nefrópata"
        '
        'chkAbueloPaterno05
        '
        Me.chkAbueloPaterno05.Location = New System.Drawing.Point(252, 36)
        Me.chkAbueloPaterno05.Name = "chkAbueloPaterno05"
        Me.chkAbueloPaterno05.Size = New System.Drawing.Size(96, 24)
        Me.chkAbueloPaterno05.TabIndex = 5
        Me.chkAbueloPaterno05.Text = "Epilepsia"
        '
        'radAbueloPaternoTieneAnt
        '
        Me.radAbueloPaternoTieneAnt.Location = New System.Drawing.Point(8, 34)
        Me.radAbueloPaternoTieneAnt.Name = "radAbueloPaternoTieneAnt"
        Me.radAbueloPaternoTieneAnt.Size = New System.Drawing.Size(152, 24)
        Me.radAbueloPaternoTieneAnt.TabIndex = 11
        Me.radAbueloPaternoTieneAnt.Text = "Tiene Antecedentes"
        '
        'chkAbueloPaterno03
        '
        Me.chkAbueloPaterno03.Location = New System.Drawing.Point(160, 56)
        Me.chkAbueloPaterno03.Name = "chkAbueloPaterno03"
        Me.chkAbueloPaterno03.Size = New System.Drawing.Size(56, 24)
        Me.chkAbueloPaterno03.TabIndex = 3
        Me.chkAbueloPaterno03.Text = "TBC"
        '
        'radAbueloPaternoDesconocePatologia
        '
        Me.radAbueloPaternoDesconocePatologia.Location = New System.Drawing.Point(8, 52)
        Me.radAbueloPaternoDesconocePatologia.Name = "radAbueloPaternoDesconocePatologia"
        Me.radAbueloPaternoDesconocePatologia.Size = New System.Drawing.Size(152, 24)
        Me.radAbueloPaternoDesconocePatologia.TabIndex = 12
        Me.radAbueloPaternoDesconocePatologia.Text = "Desconoce Antecedentes"
        '
        'chkAbueloPaterno02
        '
        Me.chkAbueloPaterno02.Location = New System.Drawing.Point(160, 36)
        Me.chkAbueloPaterno02.Name = "chkAbueloPaterno02"
        Me.chkAbueloPaterno02.Size = New System.Drawing.Size(56, 24)
        Me.chkAbueloPaterno02.TabIndex = 2
        Me.chkAbueloPaterno02.Text = "DM"
        '
        'radAbueloPaternoNiega
        '
        Me.radAbueloPaternoNiega.Location = New System.Drawing.Point(8, 16)
        Me.radAbueloPaternoNiega.Name = "radAbueloPaternoNiega"
        Me.radAbueloPaternoNiega.Size = New System.Drawing.Size(128, 24)
        Me.radAbueloPaternoNiega.TabIndex = 10
        Me.radAbueloPaternoNiega.Text = "Niega Antecedentes"
        '
        'txtAbueloPaternoOtrosAnt
        '
        Me.txtAbueloPaternoOtrosAnt.Enabled = False
        Me.txtAbueloPaternoOtrosAnt.Location = New System.Drawing.Point(424, 12)
        Me.txtAbueloPaternoOtrosAnt.MaxLength = 512
        Me.txtAbueloPaternoOtrosAnt.Multiline = True
        Me.txtAbueloPaternoOtrosAnt.Name = "txtAbueloPaternoOtrosAnt"
        Me.txtAbueloPaternoOtrosAnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbueloPaternoOtrosAnt.Size = New System.Drawing.Size(304, 64)
        Me.txtAbueloPaternoOtrosAnt.TabIndex = 9
        '
        'chkAbueloPaternoOtros
        '
        Me.chkAbueloPaternoOtros.Location = New System.Drawing.Point(356, 36)
        Me.chkAbueloPaternoOtros.Name = "chkAbueloPaternoOtros"
        Me.chkAbueloPaternoOtros.Size = New System.Drawing.Size(64, 24)
        Me.chkAbueloPaternoOtros.TabIndex = 8
        Me.chkAbueloPaternoOtros.Text = "Otros"
        '
        'chkAbueloPaterno07
        '
        Me.chkAbueloPaterno07.Location = New System.Drawing.Point(356, 16)
        Me.chkAbueloPaterno07.Name = "chkAbueloPaterno07"
        Me.chkAbueloPaterno07.Size = New System.Drawing.Size(64, 24)
        Me.chkAbueloPaterno07.TabIndex = 7
        Me.chkAbueloPaterno07.Text = "Cáncer"
        '
        'chkAbueloPaterno04
        '
        Me.chkAbueloPaterno04.Location = New System.Drawing.Point(252, 16)
        Me.chkAbueloPaterno04.Name = "chkAbueloPaterno04"
        Me.chkAbueloPaterno04.Size = New System.Drawing.Size(80, 24)
        Me.chkAbueloPaterno04.TabIndex = 4
        Me.chkAbueloPaterno04.Text = "Cardiópata"
        '
        'chkAbueloPaterno01
        '
        Me.chkAbueloPaterno01.Location = New System.Drawing.Point(160, 16)
        Me.chkAbueloPaterno01.Name = "chkAbueloPaterno01"
        Me.chkAbueloPaterno01.Size = New System.Drawing.Size(56, 24)
        Me.chkAbueloPaterno01.TabIndex = 1
        Me.chkAbueloPaterno01.Text = "HTA"
        '
        'radAbueloPaternoMuerta
        '
        Me.radAbueloPaternoMuerta.Location = New System.Drawing.Point(112, 16)
        Me.radAbueloPaternoMuerta.Name = "radAbueloPaternoMuerta"
        Me.radAbueloPaternoMuerta.Size = New System.Drawing.Size(104, 24)
        Me.radAbueloPaternoMuerta.TabIndex = 1
        Me.radAbueloPaternoMuerta.Text = "Muerto"
        '
        'radAbueloPaternoDesconoce
        '
        Me.radAbueloPaternoDesconoce.Location = New System.Drawing.Point(216, 16)
        Me.radAbueloPaternoDesconoce.Name = "radAbueloPaternoDesconoce"
        Me.radAbueloPaternoDesconoce.Size = New System.Drawing.Size(80, 24)
        Me.radAbueloPaternoDesconoce.TabIndex = 2
        Me.radAbueloPaternoDesconoce.Text = "Desconoce"
        '
        'radAbueloPaternoViva
        '
        Me.radAbueloPaternoViva.Location = New System.Drawing.Point(8, 16)
        Me.radAbueloPaternoViva.Name = "radAbueloPaternoViva"
        Me.radAbueloPaternoViva.Size = New System.Drawing.Size(72, 24)
        Me.radAbueloPaternoViva.TabIndex = 0
        Me.radAbueloPaternoViva.Text = "Vivo"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GBAbuelaPaternaCausaMuerte)
        Me.GroupBox7.Controls.Add(Me.GBAbuelaPaternaAntecedentes)
        Me.GroupBox7.Controls.Add(Me.radAbuelaPaternaMuerta)
        Me.GroupBox7.Controls.Add(Me.radAbuelaPaternaDesconoce)
        Me.GroupBox7.Controls.Add(Me.radAbuelaPaternaViva)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(752, 218)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "ABUELA PATERNA"
        '
        'GBAbuelaPaternaCausaMuerte
        '
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.radAbuelaPaternaOtrasCausas)
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.txtAbuelaPaternaOtrasCausas)
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.radAbuelaPaternaDesconoceCausa)
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.radAbuelaPaterna08)
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.radAbuelaPaterna07)
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.radAbuelaPaterna06)
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.radAbuelaPaterna04)
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.radAbuelaPaterna03)
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.radAbuelaPaterna05)
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.radAbuelaPaterna02)
        Me.GBAbuelaPaternaCausaMuerte.Controls.Add(Me.radAbuelaPaterna01)
        Me.GBAbuelaPaternaCausaMuerte.Enabled = False
        Me.GBAbuelaPaternaCausaMuerte.Location = New System.Drawing.Point(8, 128)
        Me.GBAbuelaPaternaCausaMuerte.Name = "GBAbuelaPaternaCausaMuerte"
        Me.GBAbuelaPaternaCausaMuerte.Size = New System.Drawing.Size(736, 84)
        Me.GBAbuelaPaternaCausaMuerte.TabIndex = 4
        Me.GBAbuelaPaternaCausaMuerte.TabStop = False
        Me.GBAbuelaPaternaCausaMuerte.Text = "Causa Directa del Fallecimiento"
        '
        'radAbuelaPaternaOtrasCausas
        '
        Me.radAbuelaPaternaOtrasCausas.Location = New System.Drawing.Point(356, 16)
        Me.radAbuelaPaternaOtrasCausas.Name = "radAbuelaPaternaOtrasCausas"
        Me.radAbuelaPaternaOtrasCausas.Size = New System.Drawing.Size(56, 24)
        Me.radAbuelaPaternaOtrasCausas.TabIndex = 11
        Me.radAbuelaPaternaOtrasCausas.Text = "Otra"
        '
        'txtAbuelaPaternaOtrasCausas
        '
        Me.txtAbuelaPaternaOtrasCausas.Enabled = False
        Me.txtAbuelaPaternaOtrasCausas.Location = New System.Drawing.Point(424, 12)
        Me.txtAbuelaPaternaOtrasCausas.MaxLength = 512
        Me.txtAbuelaPaternaOtrasCausas.Multiline = True
        Me.txtAbuelaPaternaOtrasCausas.Name = "txtAbuelaPaternaOtrasCausas"
        Me.txtAbuelaPaternaOtrasCausas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbuelaPaternaOtrasCausas.Size = New System.Drawing.Size(304, 64)
        Me.txtAbuelaPaternaOtrasCausas.TabIndex = 10
        '
        'radAbuelaPaternaDesconoceCausa
        '
        Me.radAbuelaPaternaDesconoceCausa.Location = New System.Drawing.Point(252, 56)
        Me.radAbuelaPaternaDesconoceCausa.Name = "radAbuelaPaternaDesconoceCausa"
        Me.radAbuelaPaternaDesconoceCausa.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaPaternaDesconoceCausa.TabIndex = 9
        Me.radAbuelaPaternaDesconoceCausa.Text = "Desconoce"
        '
        'radAbuelaPaterna08
        '
        Me.radAbuelaPaterna08.Location = New System.Drawing.Point(252, 36)
        Me.radAbuelaPaterna08.Name = "radAbuelaPaterna08"
        Me.radAbuelaPaterna08.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radAbuelaPaterna08.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaPaterna08.TabIndex = 8
        Me.radAbuelaPaterna08.Text = "Natural"
        '
        'radAbuelaPaterna07
        '
        Me.radAbuelaPaterna07.Location = New System.Drawing.Point(252, 16)
        Me.radAbuelaPaterna07.Name = "radAbuelaPaterna07"
        Me.radAbuelaPaterna07.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaPaterna07.TabIndex = 7
        Me.radAbuelaPaterna07.Text = "Metabólica"
        '
        'radAbuelaPaterna06
        '
        Me.radAbuelaPaterna06.Location = New System.Drawing.Point(160, 56)
        Me.radAbuelaPaterna06.Name = "radAbuelaPaterna06"
        Me.radAbuelaPaterna06.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaPaterna06.TabIndex = 6
        Me.radAbuelaPaterna06.Text = "Oncológica"
        '
        'radAbuelaPaterna04
        '
        Me.radAbuelaPaterna04.Location = New System.Drawing.Point(160, 16)
        Me.radAbuelaPaterna04.Name = "radAbuelaPaterna04"
        Me.radAbuelaPaterna04.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaPaterna04.TabIndex = 5
        Me.radAbuelaPaterna04.Text = "Hepatopatía"
        '
        'radAbuelaPaterna03
        '
        Me.radAbuelaPaterna03.Location = New System.Drawing.Point(8, 56)
        Me.radAbuelaPaterna03.Name = "radAbuelaPaterna03"
        Me.radAbuelaPaterna03.Size = New System.Drawing.Size(104, 24)
        Me.radAbuelaPaterna03.TabIndex = 4
        Me.radAbuelaPaterna03.Text = "Nefropatía"
        '
        'radAbuelaPaterna05
        '
        Me.radAbuelaPaterna05.Location = New System.Drawing.Point(160, 36)
        Me.radAbuelaPaterna05.Name = "radAbuelaPaterna05"
        Me.radAbuelaPaterna05.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaPaterna05.TabIndex = 3
        Me.radAbuelaPaterna05.Text = "Neumopatía"
        '
        'radAbuelaPaterna02
        '
        Me.radAbuelaPaterna02.Location = New System.Drawing.Point(8, 36)
        Me.radAbuelaPaterna02.Name = "radAbuelaPaterna02"
        Me.radAbuelaPaterna02.Size = New System.Drawing.Size(104, 24)
        Me.radAbuelaPaterna02.TabIndex = 2
        Me.radAbuelaPaterna02.Text = "Neuropatía"
        '
        'radAbuelaPaterna01
        '
        Me.radAbuelaPaterna01.Location = New System.Drawing.Point(8, 16)
        Me.radAbuelaPaterna01.Name = "radAbuelaPaterna01"
        Me.radAbuelaPaterna01.Size = New System.Drawing.Size(104, 24)
        Me.radAbuelaPaterna01.TabIndex = 1
        Me.radAbuelaPaterna01.Text = "Cardiopatía"
        '
        'GBAbuelaPaternaAntecedentes
        '
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.chkAbuelaPaterna06)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.chkAbuelaPaterna05)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.radAbuelaPaternaDesconocePatologia)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.chkAbuelaPaterna03)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.radAbuelaPaternaTieneAnt)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.chkAbuelaPaterna02)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.radAbuelaPaternaNiega)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.txtAbuelaPaternaOtrosAnt)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.chkAbuelaPaternaOtros)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.chkAbuelaPaterna07)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.chkAbuelaPaterna04)
        Me.GBAbuelaPaternaAntecedentes.Controls.Add(Me.chkAbuelaPaterna01)
        Me.GBAbuelaPaternaAntecedentes.Location = New System.Drawing.Point(8, 40)
        Me.GBAbuelaPaternaAntecedentes.Name = "GBAbuelaPaternaAntecedentes"
        Me.GBAbuelaPaternaAntecedentes.Size = New System.Drawing.Size(736, 84)
        Me.GBAbuelaPaternaAntecedentes.TabIndex = 3
        Me.GBAbuelaPaternaAntecedentes.TabStop = False
        Me.GBAbuelaPaternaAntecedentes.Text = "Antecedentes de"
        '
        'chkAbuelaPaterna06
        '
        Me.chkAbuelaPaterna06.Location = New System.Drawing.Point(252, 56)
        Me.chkAbuelaPaterna06.Name = "chkAbuelaPaterna06"
        Me.chkAbuelaPaterna06.Size = New System.Drawing.Size(96, 24)
        Me.chkAbuelaPaterna06.TabIndex = 6
        Me.chkAbuelaPaterna06.Text = "Nefrópata"
        '
        'chkAbuelaPaterna05
        '
        Me.chkAbuelaPaterna05.Location = New System.Drawing.Point(252, 36)
        Me.chkAbuelaPaterna05.Name = "chkAbuelaPaterna05"
        Me.chkAbuelaPaterna05.Size = New System.Drawing.Size(96, 24)
        Me.chkAbuelaPaterna05.TabIndex = 5
        Me.chkAbuelaPaterna05.Text = "Epilepsia"
        '
        'radAbuelaPaternaDesconocePatologia
        '
        Me.radAbuelaPaternaDesconocePatologia.Location = New System.Drawing.Point(8, 56)
        Me.radAbuelaPaternaDesconocePatologia.Name = "radAbuelaPaternaDesconocePatologia"
        Me.radAbuelaPaternaDesconocePatologia.Size = New System.Drawing.Size(152, 24)
        Me.radAbuelaPaternaDesconocePatologia.TabIndex = 11
        Me.radAbuelaPaternaDesconocePatologia.Text = "Desconoce Antecedentes"
        '
        'chkAbuelaPaterna03
        '
        Me.chkAbuelaPaterna03.Location = New System.Drawing.Point(160, 56)
        Me.chkAbuelaPaterna03.Name = "chkAbuelaPaterna03"
        Me.chkAbuelaPaterna03.Size = New System.Drawing.Size(56, 24)
        Me.chkAbuelaPaterna03.TabIndex = 3
        Me.chkAbuelaPaterna03.Text = "TBC"
        '
        'radAbuelaPaternaTieneAnt
        '
        Me.radAbuelaPaternaTieneAnt.Location = New System.Drawing.Point(8, 36)
        Me.radAbuelaPaternaTieneAnt.Name = "radAbuelaPaternaTieneAnt"
        Me.radAbuelaPaternaTieneAnt.Size = New System.Drawing.Size(152, 24)
        Me.radAbuelaPaternaTieneAnt.TabIndex = 12
        Me.radAbuelaPaternaTieneAnt.Text = "Tiene Antecedentes"
        '
        'chkAbuelaPaterna02
        '
        Me.chkAbuelaPaterna02.Location = New System.Drawing.Point(160, 36)
        Me.chkAbuelaPaterna02.Name = "chkAbuelaPaterna02"
        Me.chkAbuelaPaterna02.Size = New System.Drawing.Size(56, 24)
        Me.chkAbuelaPaterna02.TabIndex = 2
        Me.chkAbuelaPaterna02.Text = "DM"
        '
        'radAbuelaPaternaNiega
        '
        Me.radAbuelaPaternaNiega.Location = New System.Drawing.Point(8, 16)
        Me.radAbuelaPaternaNiega.Name = "radAbuelaPaternaNiega"
        Me.radAbuelaPaternaNiega.Size = New System.Drawing.Size(128, 24)
        Me.radAbuelaPaternaNiega.TabIndex = 10
        Me.radAbuelaPaternaNiega.Text = "Niega Antecedentes"
        '
        'txtAbuelaPaternaOtrosAnt
        '
        Me.txtAbuelaPaternaOtrosAnt.Enabled = False
        Me.txtAbuelaPaternaOtrosAnt.Location = New System.Drawing.Point(424, 12)
        Me.txtAbuelaPaternaOtrosAnt.MaxLength = 512
        Me.txtAbuelaPaternaOtrosAnt.Multiline = True
        Me.txtAbuelaPaternaOtrosAnt.Name = "txtAbuelaPaternaOtrosAnt"
        Me.txtAbuelaPaternaOtrosAnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbuelaPaternaOtrosAnt.Size = New System.Drawing.Size(304, 64)
        Me.txtAbuelaPaternaOtrosAnt.TabIndex = 9
        '
        'chkAbuelaPaternaOtros
        '
        Me.chkAbuelaPaternaOtros.Location = New System.Drawing.Point(356, 36)
        Me.chkAbuelaPaternaOtros.Name = "chkAbuelaPaternaOtros"
        Me.chkAbuelaPaternaOtros.Size = New System.Drawing.Size(64, 24)
        Me.chkAbuelaPaternaOtros.TabIndex = 8
        Me.chkAbuelaPaternaOtros.Text = "Otros"
        '
        'chkAbuelaPaterna07
        '
        Me.chkAbuelaPaterna07.Location = New System.Drawing.Point(356, 16)
        Me.chkAbuelaPaterna07.Name = "chkAbuelaPaterna07"
        Me.chkAbuelaPaterna07.Size = New System.Drawing.Size(64, 24)
        Me.chkAbuelaPaterna07.TabIndex = 7
        Me.chkAbuelaPaterna07.Text = "Cáncer"
        '
        'chkAbuelaPaterna04
        '
        Me.chkAbuelaPaterna04.Location = New System.Drawing.Point(252, 16)
        Me.chkAbuelaPaterna04.Name = "chkAbuelaPaterna04"
        Me.chkAbuelaPaterna04.Size = New System.Drawing.Size(80, 24)
        Me.chkAbuelaPaterna04.TabIndex = 4
        Me.chkAbuelaPaterna04.Text = "Cardiópata"
        '
        'chkAbuelaPaterna01
        '
        Me.chkAbuelaPaterna01.Location = New System.Drawing.Point(160, 16)
        Me.chkAbuelaPaterna01.Name = "chkAbuelaPaterna01"
        Me.chkAbuelaPaterna01.Size = New System.Drawing.Size(56, 24)
        Me.chkAbuelaPaterna01.TabIndex = 1
        Me.chkAbuelaPaterna01.Text = "HTA"
        '
        'radAbuelaPaternaMuerta
        '
        Me.radAbuelaPaternaMuerta.Location = New System.Drawing.Point(112, 16)
        Me.radAbuelaPaternaMuerta.Name = "radAbuelaPaternaMuerta"
        Me.radAbuelaPaternaMuerta.Size = New System.Drawing.Size(104, 24)
        Me.radAbuelaPaternaMuerta.TabIndex = 1
        Me.radAbuelaPaternaMuerta.Text = "Muerta"
        '
        'radAbuelaPaternaDesconoce
        '
        Me.radAbuelaPaternaDesconoce.Location = New System.Drawing.Point(216, 16)
        Me.radAbuelaPaternaDesconoce.Name = "radAbuelaPaternaDesconoce"
        Me.radAbuelaPaternaDesconoce.Size = New System.Drawing.Size(80, 24)
        Me.radAbuelaPaternaDesconoce.TabIndex = 2
        Me.radAbuelaPaternaDesconoce.Text = "Desconoce"
        '
        'radAbuelaPaternaViva
        '
        Me.radAbuelaPaternaViva.Location = New System.Drawing.Point(8, 16)
        Me.radAbuelaPaternaViva.Name = "radAbuelaPaternaViva"
        Me.radAbuelaPaternaViva.Size = New System.Drawing.Size(72, 24)
        Me.radAbuelaPaternaViva.TabIndex = 0
        Me.radAbuelaPaternaViva.Text = "Viva"
        '
        'TabPageAbuelosMaternos
        '
        Me.TabPageAbuelosMaternos.Controls.Add(Me.GroupBox3)
        Me.TabPageAbuelosMaternos.Controls.Add(Me.gb2)
        Me.TabPageAbuelosMaternos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAbuelosMaternos.Name = "TabPageAbuelosMaternos"
        Me.TabPageAbuelosMaternos.Size = New System.Drawing.Size(966, 449)
        Me.TabPageAbuelosMaternos.TabIndex = 2
        Me.TabPageAbuelosMaternos.Text = "Abuelos Maternos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GBAbueloMaternoCausaMuerte)
        Me.GroupBox3.Controls.Add(Me.GBAbueloMaternoAntecedentes)
        Me.GroupBox3.Controls.Add(Me.radAbueloMaternoMuerta)
        Me.GroupBox3.Controls.Add(Me.radAbueloMaternoDesconoce)
        Me.GroupBox3.Controls.Add(Me.radAbueloMaternoViva)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(752, 218)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ABUELO MATERNO"
        '
        'GBAbueloMaternoCausaMuerte
        '
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.radAbueloMaternoOtrasCausas)
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.txtAbueloMaternoOtrasCausas)
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.radAbueloMaternoDesconoceCausa)
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.radAbueloMaterno08)
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.radAbueloMaterno07)
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.radAbueloMaterno06)
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.radAbueloMaterno04)
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.radAbueloMaterno03)
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.radAbueloMaterno05)
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.radAbueloMaterno02)
        Me.GBAbueloMaternoCausaMuerte.Controls.Add(Me.radAbueloMaterno01)
        Me.GBAbueloMaternoCausaMuerte.Enabled = False
        Me.GBAbueloMaternoCausaMuerte.Location = New System.Drawing.Point(8, 128)
        Me.GBAbueloMaternoCausaMuerte.Name = "GBAbueloMaternoCausaMuerte"
        Me.GBAbueloMaternoCausaMuerte.Size = New System.Drawing.Size(736, 84)
        Me.GBAbueloMaternoCausaMuerte.TabIndex = 4
        Me.GBAbueloMaternoCausaMuerte.TabStop = False
        Me.GBAbueloMaternoCausaMuerte.Text = "Causa Directa del Fallecimiento"
        '
        'radAbueloMaternoOtrasCausas
        '
        Me.radAbueloMaternoOtrasCausas.Location = New System.Drawing.Point(356, 16)
        Me.radAbueloMaternoOtrasCausas.Name = "radAbueloMaternoOtrasCausas"
        Me.radAbueloMaternoOtrasCausas.Size = New System.Drawing.Size(56, 24)
        Me.radAbueloMaternoOtrasCausas.TabIndex = 11
        Me.radAbueloMaternoOtrasCausas.Text = "Otra"
        '
        'txtAbueloMaternoOtrasCausas
        '
        Me.txtAbueloMaternoOtrasCausas.Enabled = False
        Me.txtAbueloMaternoOtrasCausas.Location = New System.Drawing.Point(424, 12)
        Me.txtAbueloMaternoOtrasCausas.MaxLength = 512
        Me.txtAbueloMaternoOtrasCausas.Multiline = True
        Me.txtAbueloMaternoOtrasCausas.Name = "txtAbueloMaternoOtrasCausas"
        Me.txtAbueloMaternoOtrasCausas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbueloMaternoOtrasCausas.Size = New System.Drawing.Size(304, 64)
        Me.txtAbueloMaternoOtrasCausas.TabIndex = 10
        '
        'radAbueloMaternoDesconoceCausa
        '
        Me.radAbueloMaternoDesconoceCausa.Location = New System.Drawing.Point(252, 56)
        Me.radAbueloMaternoDesconoceCausa.Name = "radAbueloMaternoDesconoceCausa"
        Me.radAbueloMaternoDesconoceCausa.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloMaternoDesconoceCausa.TabIndex = 9
        Me.radAbueloMaternoDesconoceCausa.Text = "Desconoce"
        '
        'radAbueloMaterno08
        '
        Me.radAbueloMaterno08.Location = New System.Drawing.Point(252, 36)
        Me.radAbueloMaterno08.Name = "radAbueloMaterno08"
        Me.radAbueloMaterno08.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radAbueloMaterno08.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloMaterno08.TabIndex = 8
        Me.radAbueloMaterno08.Text = "Natural"
        '
        'radAbueloMaterno07
        '
        Me.radAbueloMaterno07.Location = New System.Drawing.Point(252, 16)
        Me.radAbueloMaterno07.Name = "radAbueloMaterno07"
        Me.radAbueloMaterno07.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloMaterno07.TabIndex = 7
        Me.radAbueloMaterno07.Text = "Metabólica"
        '
        'radAbueloMaterno06
        '
        Me.radAbueloMaterno06.Location = New System.Drawing.Point(160, 56)
        Me.radAbueloMaterno06.Name = "radAbueloMaterno06"
        Me.radAbueloMaterno06.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloMaterno06.TabIndex = 6
        Me.radAbueloMaterno06.Text = "Oncológica"
        '
        'radAbueloMaterno04
        '
        Me.radAbueloMaterno04.Location = New System.Drawing.Point(160, 16)
        Me.radAbueloMaterno04.Name = "radAbueloMaterno04"
        Me.radAbueloMaterno04.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloMaterno04.TabIndex = 5
        Me.radAbueloMaterno04.Text = "Hepatopatía"
        '
        'radAbueloMaterno03
        '
        Me.radAbueloMaterno03.Location = New System.Drawing.Point(8, 56)
        Me.radAbueloMaterno03.Name = "radAbueloMaterno03"
        Me.radAbueloMaterno03.Size = New System.Drawing.Size(104, 24)
        Me.radAbueloMaterno03.TabIndex = 4
        Me.radAbueloMaterno03.Text = "Nefropatía"
        '
        'radAbueloMaterno05
        '
        Me.radAbueloMaterno05.Location = New System.Drawing.Point(160, 36)
        Me.radAbueloMaterno05.Name = "radAbueloMaterno05"
        Me.radAbueloMaterno05.Size = New System.Drawing.Size(84, 24)
        Me.radAbueloMaterno05.TabIndex = 3
        Me.radAbueloMaterno05.Text = "Neumopatía"
        '
        'radAbueloMaterno02
        '
        Me.radAbueloMaterno02.Location = New System.Drawing.Point(8, 36)
        Me.radAbueloMaterno02.Name = "radAbueloMaterno02"
        Me.radAbueloMaterno02.Size = New System.Drawing.Size(104, 24)
        Me.radAbueloMaterno02.TabIndex = 2
        Me.radAbueloMaterno02.Text = "Neuropatía"
        '
        'radAbueloMaterno01
        '
        Me.radAbueloMaterno01.Location = New System.Drawing.Point(8, 16)
        Me.radAbueloMaterno01.Name = "radAbueloMaterno01"
        Me.radAbueloMaterno01.Size = New System.Drawing.Size(104, 24)
        Me.radAbueloMaterno01.TabIndex = 1
        Me.radAbueloMaterno01.Text = "Cardiopatía"
        '
        'GBAbueloMaternoAntecedentes
        '
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.chkAbueloMaterno06)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.chkAbueloMaterno05)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.radAbueloMaternoTieneAnt)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.chkAbueloMaterno03)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.radAbueloMaternoDesconocePatologia)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.chkAbueloMaterno02)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.radAbueloMaternoNiega)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.txtAbueloMaternoOtrosAnt)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.chkAbueloMaternoOtros)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.chkAbueloMaterno07)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.chkAbueloMaterno04)
        Me.GBAbueloMaternoAntecedentes.Controls.Add(Me.chkAbueloMaterno01)
        Me.GBAbueloMaternoAntecedentes.Location = New System.Drawing.Point(8, 40)
        Me.GBAbueloMaternoAntecedentes.Name = "GBAbueloMaternoAntecedentes"
        Me.GBAbueloMaternoAntecedentes.Size = New System.Drawing.Size(736, 84)
        Me.GBAbueloMaternoAntecedentes.TabIndex = 3
        Me.GBAbueloMaternoAntecedentes.TabStop = False
        Me.GBAbueloMaternoAntecedentes.Text = "Antecedentes de"
        '
        'chkAbueloMaterno06
        '
        Me.chkAbueloMaterno06.Location = New System.Drawing.Point(252, 56)
        Me.chkAbueloMaterno06.Name = "chkAbueloMaterno06"
        Me.chkAbueloMaterno06.Size = New System.Drawing.Size(96, 24)
        Me.chkAbueloMaterno06.TabIndex = 6
        Me.chkAbueloMaterno06.Text = "Nefrópata"
        '
        'chkAbueloMaterno05
        '
        Me.chkAbueloMaterno05.Location = New System.Drawing.Point(252, 36)
        Me.chkAbueloMaterno05.Name = "chkAbueloMaterno05"
        Me.chkAbueloMaterno05.Size = New System.Drawing.Size(96, 24)
        Me.chkAbueloMaterno05.TabIndex = 5
        Me.chkAbueloMaterno05.Text = "Epilepsia"
        '
        'radAbueloMaternoTieneAnt
        '
        Me.radAbueloMaternoTieneAnt.Location = New System.Drawing.Point(8, 34)
        Me.radAbueloMaternoTieneAnt.Name = "radAbueloMaternoTieneAnt"
        Me.radAbueloMaternoTieneAnt.Size = New System.Drawing.Size(152, 24)
        Me.radAbueloMaternoTieneAnt.TabIndex = 11
        Me.radAbueloMaternoTieneAnt.Text = "Tiene Antecedentes"
        '
        'chkAbueloMaterno03
        '
        Me.chkAbueloMaterno03.Location = New System.Drawing.Point(160, 56)
        Me.chkAbueloMaterno03.Name = "chkAbueloMaterno03"
        Me.chkAbueloMaterno03.Size = New System.Drawing.Size(56, 24)
        Me.chkAbueloMaterno03.TabIndex = 3
        Me.chkAbueloMaterno03.Text = "TBC"
        '
        'radAbueloMaternoDesconocePatologia
        '
        Me.radAbueloMaternoDesconocePatologia.Location = New System.Drawing.Point(8, 52)
        Me.radAbueloMaternoDesconocePatologia.Name = "radAbueloMaternoDesconocePatologia"
        Me.radAbueloMaternoDesconocePatologia.Size = New System.Drawing.Size(152, 24)
        Me.radAbueloMaternoDesconocePatologia.TabIndex = 12
        Me.radAbueloMaternoDesconocePatologia.Text = "Desconoce Antecedentes"
        '
        'chkAbueloMaterno02
        '
        Me.chkAbueloMaterno02.Location = New System.Drawing.Point(160, 36)
        Me.chkAbueloMaterno02.Name = "chkAbueloMaterno02"
        Me.chkAbueloMaterno02.Size = New System.Drawing.Size(56, 24)
        Me.chkAbueloMaterno02.TabIndex = 2
        Me.chkAbueloMaterno02.Text = "DM"
        '
        'radAbueloMaternoNiega
        '
        Me.radAbueloMaternoNiega.Location = New System.Drawing.Point(8, 16)
        Me.radAbueloMaternoNiega.Name = "radAbueloMaternoNiega"
        Me.radAbueloMaternoNiega.Size = New System.Drawing.Size(128, 24)
        Me.radAbueloMaternoNiega.TabIndex = 10
        Me.radAbueloMaternoNiega.Text = "Niega Antecedentes"
        '
        'txtAbueloMaternoOtrosAnt
        '
        Me.txtAbueloMaternoOtrosAnt.Enabled = False
        Me.txtAbueloMaternoOtrosAnt.Location = New System.Drawing.Point(424, 12)
        Me.txtAbueloMaternoOtrosAnt.MaxLength = 512
        Me.txtAbueloMaternoOtrosAnt.Multiline = True
        Me.txtAbueloMaternoOtrosAnt.Name = "txtAbueloMaternoOtrosAnt"
        Me.txtAbueloMaternoOtrosAnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbueloMaternoOtrosAnt.Size = New System.Drawing.Size(304, 64)
        Me.txtAbueloMaternoOtrosAnt.TabIndex = 9
        '
        'chkAbueloMaternoOtros
        '
        Me.chkAbueloMaternoOtros.Location = New System.Drawing.Point(356, 36)
        Me.chkAbueloMaternoOtros.Name = "chkAbueloMaternoOtros"
        Me.chkAbueloMaternoOtros.Size = New System.Drawing.Size(64, 24)
        Me.chkAbueloMaternoOtros.TabIndex = 8
        Me.chkAbueloMaternoOtros.Text = "Otros"
        '
        'chkAbueloMaterno07
        '
        Me.chkAbueloMaterno07.Location = New System.Drawing.Point(356, 16)
        Me.chkAbueloMaterno07.Name = "chkAbueloMaterno07"
        Me.chkAbueloMaterno07.Size = New System.Drawing.Size(64, 24)
        Me.chkAbueloMaterno07.TabIndex = 7
        Me.chkAbueloMaterno07.Text = "Cáncer"
        '
        'chkAbueloMaterno04
        '
        Me.chkAbueloMaterno04.Location = New System.Drawing.Point(252, 16)
        Me.chkAbueloMaterno04.Name = "chkAbueloMaterno04"
        Me.chkAbueloMaterno04.Size = New System.Drawing.Size(80, 24)
        Me.chkAbueloMaterno04.TabIndex = 4
        Me.chkAbueloMaterno04.Text = "Cardiópata"
        '
        'chkAbueloMaterno01
        '
        Me.chkAbueloMaterno01.Location = New System.Drawing.Point(160, 16)
        Me.chkAbueloMaterno01.Name = "chkAbueloMaterno01"
        Me.chkAbueloMaterno01.Size = New System.Drawing.Size(56, 24)
        Me.chkAbueloMaterno01.TabIndex = 1
        Me.chkAbueloMaterno01.Text = "HTA"
        '
        'radAbueloMaternoMuerta
        '
        Me.radAbueloMaternoMuerta.Location = New System.Drawing.Point(112, 16)
        Me.radAbueloMaternoMuerta.Name = "radAbueloMaternoMuerta"
        Me.radAbueloMaternoMuerta.Size = New System.Drawing.Size(104, 24)
        Me.radAbueloMaternoMuerta.TabIndex = 1
        Me.radAbueloMaternoMuerta.Text = "Muerto"
        '
        'radAbueloMaternoDesconoce
        '
        Me.radAbueloMaternoDesconoce.Location = New System.Drawing.Point(216, 16)
        Me.radAbueloMaternoDesconoce.Name = "radAbueloMaternoDesconoce"
        Me.radAbueloMaternoDesconoce.Size = New System.Drawing.Size(80, 24)
        Me.radAbueloMaternoDesconoce.TabIndex = 2
        Me.radAbueloMaternoDesconoce.Text = "Desconoce"
        '
        'radAbueloMaternoViva
        '
        Me.radAbueloMaternoViva.Location = New System.Drawing.Point(8, 16)
        Me.radAbueloMaternoViva.Name = "radAbueloMaternoViva"
        Me.radAbueloMaternoViva.Size = New System.Drawing.Size(72, 24)
        Me.radAbueloMaternoViva.TabIndex = 0
        Me.radAbueloMaternoViva.Text = "Vivo"
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.GBAbuelaMaternaCausaMuerte)
        Me.gb2.Controls.Add(Me.GBAbuelaMaternaAntecedentes)
        Me.gb2.Controls.Add(Me.radAbuelaMaternaMuerta)
        Me.gb2.Controls.Add(Me.radAbuelaMaternaDesconoce)
        Me.gb2.Controls.Add(Me.radAbuelaMaternaViva)
        Me.gb2.Location = New System.Drawing.Point(8, 5)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(752, 218)
        Me.gb2.TabIndex = 7
        Me.gb2.TabStop = False
        Me.gb2.Text = "ABUELA  MATERNA"
        '
        'GBAbuelaMaternaCausaMuerte
        '
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.radAbuelaMaternaOtrasCausas)
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.txtAbuelaMaternaOtrasCausas)
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.radAbuelaMaternaDesconoceCausa)
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.radAbuelaMaterna08)
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.radAbuelaMaterna07)
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.radAbuelaMaterna06)
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.radAbuelaMaterna04)
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.radAbuelaMaterna03)
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.radAbuelaMaterna05)
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.radAbuelaMaterna02)
        Me.GBAbuelaMaternaCausaMuerte.Controls.Add(Me.radAbuelaMaterna01)
        Me.GBAbuelaMaternaCausaMuerte.Enabled = False
        Me.GBAbuelaMaternaCausaMuerte.Location = New System.Drawing.Point(8, 128)
        Me.GBAbuelaMaternaCausaMuerte.Name = "GBAbuelaMaternaCausaMuerte"
        Me.GBAbuelaMaternaCausaMuerte.Size = New System.Drawing.Size(736, 84)
        Me.GBAbuelaMaternaCausaMuerte.TabIndex = 4
        Me.GBAbuelaMaternaCausaMuerte.TabStop = False
        Me.GBAbuelaMaternaCausaMuerte.Text = "Causa Directa del Fallecimiento"
        '
        'radAbuelaMaternaOtrasCausas
        '
        Me.radAbuelaMaternaOtrasCausas.Location = New System.Drawing.Point(356, 16)
        Me.radAbuelaMaternaOtrasCausas.Name = "radAbuelaMaternaOtrasCausas"
        Me.radAbuelaMaternaOtrasCausas.Size = New System.Drawing.Size(56, 24)
        Me.radAbuelaMaternaOtrasCausas.TabIndex = 11
        Me.radAbuelaMaternaOtrasCausas.Text = "Otra"
        '
        'txtAbuelaMaternaOtrasCausas
        '
        Me.txtAbuelaMaternaOtrasCausas.Enabled = False
        Me.txtAbuelaMaternaOtrasCausas.Location = New System.Drawing.Point(424, 12)
        Me.txtAbuelaMaternaOtrasCausas.MaxLength = 512
        Me.txtAbuelaMaternaOtrasCausas.Multiline = True
        Me.txtAbuelaMaternaOtrasCausas.Name = "txtAbuelaMaternaOtrasCausas"
        Me.txtAbuelaMaternaOtrasCausas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbuelaMaternaOtrasCausas.Size = New System.Drawing.Size(304, 64)
        Me.txtAbuelaMaternaOtrasCausas.TabIndex = 10
        '
        'radAbuelaMaternaDesconoceCausa
        '
        Me.radAbuelaMaternaDesconoceCausa.Location = New System.Drawing.Point(252, 56)
        Me.radAbuelaMaternaDesconoceCausa.Name = "radAbuelaMaternaDesconoceCausa"
        Me.radAbuelaMaternaDesconoceCausa.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaMaternaDesconoceCausa.TabIndex = 9
        Me.radAbuelaMaternaDesconoceCausa.Text = "Desconoce"
        '
        'radAbuelaMaterna08
        '
        Me.radAbuelaMaterna08.Location = New System.Drawing.Point(252, 36)
        Me.radAbuelaMaterna08.Name = "radAbuelaMaterna08"
        Me.radAbuelaMaterna08.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radAbuelaMaterna08.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaMaterna08.TabIndex = 8
        Me.radAbuelaMaterna08.Text = "Natural"
        '
        'radAbuelaMaterna07
        '
        Me.radAbuelaMaterna07.Location = New System.Drawing.Point(252, 16)
        Me.radAbuelaMaterna07.Name = "radAbuelaMaterna07"
        Me.radAbuelaMaterna07.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaMaterna07.TabIndex = 7
        Me.radAbuelaMaterna07.Text = "Metabólica"
        '
        'radAbuelaMaterna06
        '
        Me.radAbuelaMaterna06.Location = New System.Drawing.Point(160, 56)
        Me.radAbuelaMaterna06.Name = "radAbuelaMaterna06"
        Me.radAbuelaMaterna06.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaMaterna06.TabIndex = 6
        Me.radAbuelaMaterna06.Text = "Oncológica"
        '
        'radAbuelaMaterna04
        '
        Me.radAbuelaMaterna04.Location = New System.Drawing.Point(160, 16)
        Me.radAbuelaMaterna04.Name = "radAbuelaMaterna04"
        Me.radAbuelaMaterna04.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaMaterna04.TabIndex = 5
        Me.radAbuelaMaterna04.Text = "Hepatopatía"
        '
        'radAbuelaMaterna03
        '
        Me.radAbuelaMaterna03.Location = New System.Drawing.Point(8, 56)
        Me.radAbuelaMaterna03.Name = "radAbuelaMaterna03"
        Me.radAbuelaMaterna03.Size = New System.Drawing.Size(104, 24)
        Me.radAbuelaMaterna03.TabIndex = 4
        Me.radAbuelaMaterna03.Text = "Nefropatía"
        '
        'radAbuelaMaterna05
        '
        Me.radAbuelaMaterna05.Location = New System.Drawing.Point(160, 36)
        Me.radAbuelaMaterna05.Name = "radAbuelaMaterna05"
        Me.radAbuelaMaterna05.Size = New System.Drawing.Size(84, 24)
        Me.radAbuelaMaterna05.TabIndex = 3
        Me.radAbuelaMaterna05.Text = "Neumopatía"
        '
        'radAbuelaMaterna02
        '
        Me.radAbuelaMaterna02.Location = New System.Drawing.Point(8, 36)
        Me.radAbuelaMaterna02.Name = "radAbuelaMaterna02"
        Me.radAbuelaMaterna02.Size = New System.Drawing.Size(104, 24)
        Me.radAbuelaMaterna02.TabIndex = 2
        Me.radAbuelaMaterna02.Text = "Neuropatía"
        '
        'radAbuelaMaterna01
        '
        Me.radAbuelaMaterna01.Location = New System.Drawing.Point(8, 16)
        Me.radAbuelaMaterna01.Name = "radAbuelaMaterna01"
        Me.radAbuelaMaterna01.Size = New System.Drawing.Size(104, 24)
        Me.radAbuelaMaterna01.TabIndex = 1
        Me.radAbuelaMaterna01.Text = "Cardiopatía"
        '
        'GBAbuelaMaternaAntecedentes
        '
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.chkAbuelaMaterna06)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.chkAbuelaMaterna05)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.radAbuelaMaternaDesconocePatologia)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.chkAbuelaMaterna03)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.radAbuelaMaternaTieneAnt)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.chkAbuelaMaterna02)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.radAbuelaMaternaNiega)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.txtAbuelaMaternaOtrosAnt)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.chkAbuelaMaternaOtros)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.chkAbuelaMaterna07)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.chkAbuelaMaterna04)
        Me.GBAbuelaMaternaAntecedentes.Controls.Add(Me.chkAbuelaMaterna01)
        Me.GBAbuelaMaternaAntecedentes.Location = New System.Drawing.Point(8, 40)
        Me.GBAbuelaMaternaAntecedentes.Name = "GBAbuelaMaternaAntecedentes"
        Me.GBAbuelaMaternaAntecedentes.Size = New System.Drawing.Size(736, 84)
        Me.GBAbuelaMaternaAntecedentes.TabIndex = 3
        Me.GBAbuelaMaternaAntecedentes.TabStop = False
        Me.GBAbuelaMaternaAntecedentes.Text = "Antecedentes de"
        '
        'chkAbuelaMaterna06
        '
        Me.chkAbuelaMaterna06.Location = New System.Drawing.Point(252, 56)
        Me.chkAbuelaMaterna06.Name = "chkAbuelaMaterna06"
        Me.chkAbuelaMaterna06.Size = New System.Drawing.Size(96, 24)
        Me.chkAbuelaMaterna06.TabIndex = 6
        Me.chkAbuelaMaterna06.Text = "Nefrópata"
        '
        'chkAbuelaMaterna05
        '
        Me.chkAbuelaMaterna05.Location = New System.Drawing.Point(252, 36)
        Me.chkAbuelaMaterna05.Name = "chkAbuelaMaterna05"
        Me.chkAbuelaMaterna05.Size = New System.Drawing.Size(96, 24)
        Me.chkAbuelaMaterna05.TabIndex = 5
        Me.chkAbuelaMaterna05.Text = "Epilepsia"
        '
        'radAbuelaMaternaDesconocePatologia
        '
        Me.radAbuelaMaternaDesconocePatologia.Location = New System.Drawing.Point(8, 56)
        Me.radAbuelaMaternaDesconocePatologia.Name = "radAbuelaMaternaDesconocePatologia"
        Me.radAbuelaMaternaDesconocePatologia.Size = New System.Drawing.Size(152, 24)
        Me.radAbuelaMaternaDesconocePatologia.TabIndex = 11
        Me.radAbuelaMaternaDesconocePatologia.Text = "Desconoce Antecedentes"
        '
        'chkAbuelaMaterna03
        '
        Me.chkAbuelaMaterna03.Location = New System.Drawing.Point(160, 56)
        Me.chkAbuelaMaterna03.Name = "chkAbuelaMaterna03"
        Me.chkAbuelaMaterna03.Size = New System.Drawing.Size(56, 24)
        Me.chkAbuelaMaterna03.TabIndex = 3
        Me.chkAbuelaMaterna03.Text = "TBC"
        '
        'radAbuelaMaternaTieneAnt
        '
        Me.radAbuelaMaternaTieneAnt.Location = New System.Drawing.Point(8, 36)
        Me.radAbuelaMaternaTieneAnt.Name = "radAbuelaMaternaTieneAnt"
        Me.radAbuelaMaternaTieneAnt.Size = New System.Drawing.Size(152, 24)
        Me.radAbuelaMaternaTieneAnt.TabIndex = 12
        Me.radAbuelaMaternaTieneAnt.Text = "Tiene Antecedentes"
        '
        'chkAbuelaMaterna02
        '
        Me.chkAbuelaMaterna02.Location = New System.Drawing.Point(160, 36)
        Me.chkAbuelaMaterna02.Name = "chkAbuelaMaterna02"
        Me.chkAbuelaMaterna02.Size = New System.Drawing.Size(56, 24)
        Me.chkAbuelaMaterna02.TabIndex = 2
        Me.chkAbuelaMaterna02.Text = "DM"
        '
        'radAbuelaMaternaNiega
        '
        Me.radAbuelaMaternaNiega.Location = New System.Drawing.Point(8, 16)
        Me.radAbuelaMaternaNiega.Name = "radAbuelaMaternaNiega"
        Me.radAbuelaMaternaNiega.Size = New System.Drawing.Size(128, 24)
        Me.radAbuelaMaternaNiega.TabIndex = 10
        Me.radAbuelaMaternaNiega.Text = "Niega Antecedentes"
        '
        'txtAbuelaMaternaOtrosAnt
        '
        Me.txtAbuelaMaternaOtrosAnt.Enabled = False
        Me.txtAbuelaMaternaOtrosAnt.Location = New System.Drawing.Point(424, 12)
        Me.txtAbuelaMaternaOtrosAnt.MaxLength = 512
        Me.txtAbuelaMaternaOtrosAnt.Multiline = True
        Me.txtAbuelaMaternaOtrosAnt.Name = "txtAbuelaMaternaOtrosAnt"
        Me.txtAbuelaMaternaOtrosAnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbuelaMaternaOtrosAnt.Size = New System.Drawing.Size(304, 64)
        Me.txtAbuelaMaternaOtrosAnt.TabIndex = 9
        '
        'chkAbuelaMaternaOtros
        '
        Me.chkAbuelaMaternaOtros.Location = New System.Drawing.Point(356, 36)
        Me.chkAbuelaMaternaOtros.Name = "chkAbuelaMaternaOtros"
        Me.chkAbuelaMaternaOtros.Size = New System.Drawing.Size(64, 24)
        Me.chkAbuelaMaternaOtros.TabIndex = 8
        Me.chkAbuelaMaternaOtros.Text = "Otros"
        '
        'chkAbuelaMaterna07
        '
        Me.chkAbuelaMaterna07.Location = New System.Drawing.Point(356, 16)
        Me.chkAbuelaMaterna07.Name = "chkAbuelaMaterna07"
        Me.chkAbuelaMaterna07.Size = New System.Drawing.Size(64, 24)
        Me.chkAbuelaMaterna07.TabIndex = 7
        Me.chkAbuelaMaterna07.Text = "Cáncer"
        '
        'chkAbuelaMaterna04
        '
        Me.chkAbuelaMaterna04.Location = New System.Drawing.Point(252, 16)
        Me.chkAbuelaMaterna04.Name = "chkAbuelaMaterna04"
        Me.chkAbuelaMaterna04.Size = New System.Drawing.Size(80, 24)
        Me.chkAbuelaMaterna04.TabIndex = 4
        Me.chkAbuelaMaterna04.Text = "Cardiópata"
        '
        'chkAbuelaMaterna01
        '
        Me.chkAbuelaMaterna01.Location = New System.Drawing.Point(160, 16)
        Me.chkAbuelaMaterna01.Name = "chkAbuelaMaterna01"
        Me.chkAbuelaMaterna01.Size = New System.Drawing.Size(56, 24)
        Me.chkAbuelaMaterna01.TabIndex = 1
        Me.chkAbuelaMaterna01.Text = "HTA"
        '
        'radAbuelaMaternaMuerta
        '
        Me.radAbuelaMaternaMuerta.Location = New System.Drawing.Point(112, 16)
        Me.radAbuelaMaternaMuerta.Name = "radAbuelaMaternaMuerta"
        Me.radAbuelaMaternaMuerta.Size = New System.Drawing.Size(104, 24)
        Me.radAbuelaMaternaMuerta.TabIndex = 1
        Me.radAbuelaMaternaMuerta.Text = "Muerta"
        '
        'radAbuelaMaternaDesconoce
        '
        Me.radAbuelaMaternaDesconoce.Location = New System.Drawing.Point(216, 16)
        Me.radAbuelaMaternaDesconoce.Name = "radAbuelaMaternaDesconoce"
        Me.radAbuelaMaternaDesconoce.Size = New System.Drawing.Size(80, 24)
        Me.radAbuelaMaternaDesconoce.TabIndex = 2
        Me.radAbuelaMaternaDesconoce.Text = "Desconoce"
        '
        'radAbuelaMaternaViva
        '
        Me.radAbuelaMaternaViva.Location = New System.Drawing.Point(8, 16)
        Me.radAbuelaMaternaViva.Name = "radAbuelaMaternaViva"
        Me.radAbuelaMaternaViva.Size = New System.Drawing.Size(72, 24)
        Me.radAbuelaMaternaViva.TabIndex = 0
        Me.radAbuelaMaternaViva.Text = "Viva"
        '
        'TabPageOtros
        '
        Me.TabPageOtros.Controls.Add(Me.GroupBox12)
        Me.TabPageOtros.Controls.Add(Me.GroupBox9)
        Me.TabPageOtros.Controls.Add(Me.GroupBox5)
        Me.TabPageOtros.Location = New System.Drawing.Point(4, 22)
        Me.TabPageOtros.Name = "TabPageOtros"
        Me.TabPageOtros.Size = New System.Drawing.Size(966, 449)
        Me.TabPageOtros.TabIndex = 6
        Me.TabPageOtros.Text = "Hermanos Tíos y Otros Familiares"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.txtOtrosFamiliares)
        Me.GroupBox12.Location = New System.Drawing.Point(8, 392)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(752, 51)
        Me.GroupBox12.TabIndex = 12
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "OTROS"
        '
        'txtOtrosFamiliares
        '
        Me.txtOtrosFamiliares.Location = New System.Drawing.Point(12, 16)
        Me.txtOtrosFamiliares.MaxLength = 512
        Me.txtOtrosFamiliares.Multiline = True
        Me.txtOtrosFamiliares.Name = "txtOtrosFamiliares"
        Me.txtOtrosFamiliares.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOtrosFamiliares.Size = New System.Drawing.Size(728, 28)
        Me.txtOtrosFamiliares.TabIndex = 10
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Controls.Add(Me.GroupBox11)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(752, 192)
        Me.GroupBox9.TabIndex = 11
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "TIOS"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.chkTiosMuertos09)
        Me.GroupBox10.Controls.Add(Me.chkTiosMuertos08)
        Me.GroupBox10.Controls.Add(Me.chkTiosMuertos07)
        Me.GroupBox10.Controls.Add(Me.chkTiosMuertos06)
        Me.GroupBox10.Controls.Add(Me.chkTiosMuertos05)
        Me.GroupBox10.Controls.Add(Me.chkTiosMuertos04)
        Me.GroupBox10.Controls.Add(Me.chkTiosMuertos03)
        Me.GroupBox10.Controls.Add(Me.chkTiosMuertos02)
        Me.GroupBox10.Controls.Add(Me.chkTiosMuertos01)
        Me.GroupBox10.Controls.Add(Me.txtTiosMuertosOtrasCausas)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(736, 84)
        Me.GroupBox10.TabIndex = 4
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Tíos Fallecidos por"
        '
        'chkTiosMuertos09
        '
        Me.chkTiosMuertos09.Location = New System.Drawing.Point(264, 56)
        Me.chkTiosMuertos09.Name = "chkTiosMuertos09"
        Me.chkTiosMuertos09.Size = New System.Drawing.Size(104, 24)
        Me.chkTiosMuertos09.TabIndex = 20
        Me.chkTiosMuertos09.Text = "Otras causas"
        '
        'chkTiosMuertos08
        '
        Me.chkTiosMuertos08.Location = New System.Drawing.Point(264, 36)
        Me.chkTiosMuertos08.Name = "chkTiosMuertos08"
        Me.chkTiosMuertos08.Size = New System.Drawing.Size(104, 24)
        Me.chkTiosMuertos08.TabIndex = 19
        Me.chkTiosMuertos08.Text = "Natural"
        '
        'chkTiosMuertos07
        '
        Me.chkTiosMuertos07.Location = New System.Drawing.Point(264, 16)
        Me.chkTiosMuertos07.Name = "chkTiosMuertos07"
        Me.chkTiosMuertos07.Size = New System.Drawing.Size(104, 24)
        Me.chkTiosMuertos07.TabIndex = 18
        Me.chkTiosMuertos07.Text = "Metabólica"
        '
        'chkTiosMuertos06
        '
        Me.chkTiosMuertos06.Location = New System.Drawing.Point(160, 56)
        Me.chkTiosMuertos06.Name = "chkTiosMuertos06"
        Me.chkTiosMuertos06.Size = New System.Drawing.Size(104, 24)
        Me.chkTiosMuertos06.TabIndex = 17
        Me.chkTiosMuertos06.Text = "Cáncer"
        '
        'chkTiosMuertos05
        '
        Me.chkTiosMuertos05.Location = New System.Drawing.Point(160, 36)
        Me.chkTiosMuertos05.Name = "chkTiosMuertos05"
        Me.chkTiosMuertos05.Size = New System.Drawing.Size(104, 24)
        Me.chkTiosMuertos05.TabIndex = 16
        Me.chkTiosMuertos05.Text = "Neumopatía"
        '
        'chkTiosMuertos04
        '
        Me.chkTiosMuertos04.Location = New System.Drawing.Point(160, 16)
        Me.chkTiosMuertos04.Name = "chkTiosMuertos04"
        Me.chkTiosMuertos04.Size = New System.Drawing.Size(104, 24)
        Me.chkTiosMuertos04.TabIndex = 15
        Me.chkTiosMuertos04.Text = "Hepatopatía"
        '
        'chkTiosMuertos03
        '
        Me.chkTiosMuertos03.Location = New System.Drawing.Point(8, 56)
        Me.chkTiosMuertos03.Name = "chkTiosMuertos03"
        Me.chkTiosMuertos03.Size = New System.Drawing.Size(104, 24)
        Me.chkTiosMuertos03.TabIndex = 14
        Me.chkTiosMuertos03.Text = "Nefropatía"
        '
        'chkTiosMuertos02
        '
        Me.chkTiosMuertos02.Location = New System.Drawing.Point(8, 36)
        Me.chkTiosMuertos02.Name = "chkTiosMuertos02"
        Me.chkTiosMuertos02.Size = New System.Drawing.Size(104, 24)
        Me.chkTiosMuertos02.TabIndex = 13
        Me.chkTiosMuertos02.Text = "Neuropatía"
        '
        'chkTiosMuertos01
        '
        Me.chkTiosMuertos01.Location = New System.Drawing.Point(8, 16)
        Me.chkTiosMuertos01.Name = "chkTiosMuertos01"
        Me.chkTiosMuertos01.Size = New System.Drawing.Size(104, 24)
        Me.chkTiosMuertos01.TabIndex = 12
        Me.chkTiosMuertos01.Text = "Cardiopatía"
        '
        'txtTiosMuertosOtrasCausas
        '
        Me.txtTiosMuertosOtrasCausas.Enabled = False
        Me.txtTiosMuertosOtrasCausas.Location = New System.Drawing.Point(392, 12)
        Me.txtTiosMuertosOtrasCausas.MaxLength = 512
        Me.txtTiosMuertosOtrasCausas.Multiline = True
        Me.txtTiosMuertosOtrasCausas.Name = "txtTiosMuertosOtrasCausas"
        Me.txtTiosMuertosOtrasCausas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTiosMuertosOtrasCausas.Size = New System.Drawing.Size(336, 64)
        Me.txtTiosMuertosOtrasCausas.TabIndex = 10
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.chkTios06)
        Me.GroupBox11.Controls.Add(Me.chkTios05)
        Me.GroupBox11.Controls.Add(Me.chkTios03)
        Me.GroupBox11.Controls.Add(Me.chkTios02)
        Me.GroupBox11.Controls.Add(Me.txtTiosOtrosAnt)
        Me.GroupBox11.Controls.Add(Me.chkTios08)
        Me.GroupBox11.Controls.Add(Me.chkTios07)
        Me.GroupBox11.Controls.Add(Me.chkTios04)
        Me.GroupBox11.Controls.Add(Me.chkTios01)
        Me.GroupBox11.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(736, 84)
        Me.GroupBox11.TabIndex = 3
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Tíos con Antecedentes de"
        '
        'chkTios06
        '
        Me.chkTios06.Location = New System.Drawing.Point(160, 56)
        Me.chkTios06.Name = "chkTios06"
        Me.chkTios06.Size = New System.Drawing.Size(96, 24)
        Me.chkTios06.TabIndex = 6
        Me.chkTios06.Text = "Nefrópata"
        '
        'chkTios05
        '
        Me.chkTios05.Location = New System.Drawing.Point(160, 36)
        Me.chkTios05.Name = "chkTios05"
        Me.chkTios05.Size = New System.Drawing.Size(96, 24)
        Me.chkTios05.TabIndex = 5
        Me.chkTios05.Text = "Epilepsia"
        '
        'chkTios03
        '
        Me.chkTios03.Location = New System.Drawing.Point(8, 56)
        Me.chkTios03.Name = "chkTios03"
        Me.chkTios03.Size = New System.Drawing.Size(56, 24)
        Me.chkTios03.TabIndex = 3
        Me.chkTios03.Text = "TBC"
        '
        'chkTios02
        '
        Me.chkTios02.Location = New System.Drawing.Point(8, 36)
        Me.chkTios02.Name = "chkTios02"
        Me.chkTios02.Size = New System.Drawing.Size(56, 24)
        Me.chkTios02.TabIndex = 2
        Me.chkTios02.Text = "DM"
        '
        'txtTiosOtrosAnt
        '
        Me.txtTiosOtrosAnt.Enabled = False
        Me.txtTiosOtrosAnt.Location = New System.Drawing.Point(392, 12)
        Me.txtTiosOtrosAnt.MaxLength = 512
        Me.txtTiosOtrosAnt.Multiline = True
        Me.txtTiosOtrosAnt.Name = "txtTiosOtrosAnt"
        Me.txtTiosOtrosAnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTiosOtrosAnt.Size = New System.Drawing.Size(336, 64)
        Me.txtTiosOtrosAnt.TabIndex = 9
        '
        'chkTios08
        '
        Me.chkTios08.Location = New System.Drawing.Point(264, 36)
        Me.chkTios08.Name = "chkTios08"
        Me.chkTios08.Size = New System.Drawing.Size(124, 24)
        Me.chkTios08.TabIndex = 8
        Me.chkTios08.Text = "Otros antecedentes"
        '
        'chkTios07
        '
        Me.chkTios07.Location = New System.Drawing.Point(264, 16)
        Me.chkTios07.Name = "chkTios07"
        Me.chkTios07.Size = New System.Drawing.Size(64, 24)
        Me.chkTios07.TabIndex = 7
        Me.chkTios07.Text = "Cáncer"
        '
        'chkTios04
        '
        Me.chkTios04.Location = New System.Drawing.Point(160, 16)
        Me.chkTios04.Name = "chkTios04"
        Me.chkTios04.Size = New System.Drawing.Size(80, 24)
        Me.chkTios04.TabIndex = 4
        Me.chkTios04.Text = "Cardiópata"
        '
        'chkTios01
        '
        Me.chkTios01.Location = New System.Drawing.Point(8, 16)
        Me.chkTios01.Name = "chkTios01"
        Me.chkTios01.Size = New System.Drawing.Size(56, 24)
        Me.chkTios01.TabIndex = 1
        Me.chkTios01.Text = "HTA"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(752, 192)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "HERMANOS"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkHermanosMuertos09)
        Me.GroupBox6.Controls.Add(Me.chkHermanosMuertos08)
        Me.GroupBox6.Controls.Add(Me.chkHermanosMuertos07)
        Me.GroupBox6.Controls.Add(Me.chkHermanosMuertos06)
        Me.GroupBox6.Controls.Add(Me.chkHermanosMuertos05)
        Me.GroupBox6.Controls.Add(Me.chkHermanosMuertos04)
        Me.GroupBox6.Controls.Add(Me.chkHermanosMuertos03)
        Me.GroupBox6.Controls.Add(Me.chkHermanosMuertos02)
        Me.GroupBox6.Controls.Add(Me.chkHermanosMuertos01)
        Me.GroupBox6.Controls.Add(Me.txtHermanosMuertosOtrasCausas)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(736, 84)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Hermanos Fallecidos por"
        '
        'chkHermanosMuertos09
        '
        Me.chkHermanosMuertos09.Location = New System.Drawing.Point(264, 56)
        Me.chkHermanosMuertos09.Name = "chkHermanosMuertos09"
        Me.chkHermanosMuertos09.Size = New System.Drawing.Size(104, 24)
        Me.chkHermanosMuertos09.TabIndex = 20
        Me.chkHermanosMuertos09.Text = "Otras causas"
        '
        'chkHermanosMuertos08
        '
        Me.chkHermanosMuertos08.Location = New System.Drawing.Point(264, 36)
        Me.chkHermanosMuertos08.Name = "chkHermanosMuertos08"
        Me.chkHermanosMuertos08.Size = New System.Drawing.Size(104, 24)
        Me.chkHermanosMuertos08.TabIndex = 19
        Me.chkHermanosMuertos08.Text = "Natural"
        '
        'chkHermanosMuertos07
        '
        Me.chkHermanosMuertos07.Location = New System.Drawing.Point(264, 16)
        Me.chkHermanosMuertos07.Name = "chkHermanosMuertos07"
        Me.chkHermanosMuertos07.Size = New System.Drawing.Size(104, 24)
        Me.chkHermanosMuertos07.TabIndex = 18
        Me.chkHermanosMuertos07.Text = "Metabólica"
        '
        'chkHermanosMuertos06
        '
        Me.chkHermanosMuertos06.Location = New System.Drawing.Point(160, 56)
        Me.chkHermanosMuertos06.Name = "chkHermanosMuertos06"
        Me.chkHermanosMuertos06.Size = New System.Drawing.Size(104, 24)
        Me.chkHermanosMuertos06.TabIndex = 17
        Me.chkHermanosMuertos06.Text = "Cáncer"
        '
        'chkHermanosMuertos05
        '
        Me.chkHermanosMuertos05.Location = New System.Drawing.Point(160, 36)
        Me.chkHermanosMuertos05.Name = "chkHermanosMuertos05"
        Me.chkHermanosMuertos05.Size = New System.Drawing.Size(104, 24)
        Me.chkHermanosMuertos05.TabIndex = 16
        Me.chkHermanosMuertos05.Text = "Neumopatía"
        '
        'chkHermanosMuertos04
        '
        Me.chkHermanosMuertos04.Location = New System.Drawing.Point(160, 16)
        Me.chkHermanosMuertos04.Name = "chkHermanosMuertos04"
        Me.chkHermanosMuertos04.Size = New System.Drawing.Size(104, 24)
        Me.chkHermanosMuertos04.TabIndex = 15
        Me.chkHermanosMuertos04.Text = "Hepatopatía"
        '
        'chkHermanosMuertos03
        '
        Me.chkHermanosMuertos03.Location = New System.Drawing.Point(8, 56)
        Me.chkHermanosMuertos03.Name = "chkHermanosMuertos03"
        Me.chkHermanosMuertos03.Size = New System.Drawing.Size(104, 24)
        Me.chkHermanosMuertos03.TabIndex = 14
        Me.chkHermanosMuertos03.Text = "Nefropatía"
        '
        'chkHermanosMuertos02
        '
        Me.chkHermanosMuertos02.Location = New System.Drawing.Point(8, 36)
        Me.chkHermanosMuertos02.Name = "chkHermanosMuertos02"
        Me.chkHermanosMuertos02.Size = New System.Drawing.Size(104, 24)
        Me.chkHermanosMuertos02.TabIndex = 13
        Me.chkHermanosMuertos02.Text = "Neuropatía"
        '
        'chkHermanosMuertos01
        '
        Me.chkHermanosMuertos01.Location = New System.Drawing.Point(8, 16)
        Me.chkHermanosMuertos01.Name = "chkHermanosMuertos01"
        Me.chkHermanosMuertos01.Size = New System.Drawing.Size(104, 24)
        Me.chkHermanosMuertos01.TabIndex = 12
        Me.chkHermanosMuertos01.Text = "Cardiopatía"
        '
        'txtHermanosMuertosOtrasCausas
        '
        Me.txtHermanosMuertosOtrasCausas.Enabled = False
        Me.txtHermanosMuertosOtrasCausas.Location = New System.Drawing.Point(392, 12)
        Me.txtHermanosMuertosOtrasCausas.MaxLength = 512
        Me.txtHermanosMuertosOtrasCausas.Multiline = True
        Me.txtHermanosMuertosOtrasCausas.Name = "txtHermanosMuertosOtrasCausas"
        Me.txtHermanosMuertosOtrasCausas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHermanosMuertosOtrasCausas.Size = New System.Drawing.Size(336, 64)
        Me.txtHermanosMuertosOtrasCausas.TabIndex = 10
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chkHermanos06)
        Me.GroupBox8.Controls.Add(Me.chkHermanos05)
        Me.GroupBox8.Controls.Add(Me.chkHermanos03)
        Me.GroupBox8.Controls.Add(Me.chkHermanos02)
        Me.GroupBox8.Controls.Add(Me.txtHermanosOtrosAnt)
        Me.GroupBox8.Controls.Add(Me.chkHermanos08)
        Me.GroupBox8.Controls.Add(Me.chkHermanos07)
        Me.GroupBox8.Controls.Add(Me.chkHermanos04)
        Me.GroupBox8.Controls.Add(Me.chkHermanos01)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(736, 84)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Hermanos con Antecedentes de"
        '
        'chkHermanos06
        '
        Me.chkHermanos06.Location = New System.Drawing.Point(160, 56)
        Me.chkHermanos06.Name = "chkHermanos06"
        Me.chkHermanos06.Size = New System.Drawing.Size(96, 24)
        Me.chkHermanos06.TabIndex = 6
        Me.chkHermanos06.Text = "Nefrópata"
        '
        'chkHermanos05
        '
        Me.chkHermanos05.Location = New System.Drawing.Point(160, 36)
        Me.chkHermanos05.Name = "chkHermanos05"
        Me.chkHermanos05.Size = New System.Drawing.Size(96, 24)
        Me.chkHermanos05.TabIndex = 5
        Me.chkHermanos05.Text = "Epilepsia"
        '
        'chkHermanos03
        '
        Me.chkHermanos03.Location = New System.Drawing.Point(8, 56)
        Me.chkHermanos03.Name = "chkHermanos03"
        Me.chkHermanos03.Size = New System.Drawing.Size(56, 24)
        Me.chkHermanos03.TabIndex = 3
        Me.chkHermanos03.Text = "TBC"
        '
        'chkHermanos02
        '
        Me.chkHermanos02.Location = New System.Drawing.Point(8, 36)
        Me.chkHermanos02.Name = "chkHermanos02"
        Me.chkHermanos02.Size = New System.Drawing.Size(56, 24)
        Me.chkHermanos02.TabIndex = 2
        Me.chkHermanos02.Text = "DM"
        '
        'txtHermanosOtrosAnt
        '
        Me.txtHermanosOtrosAnt.Enabled = False
        Me.txtHermanosOtrosAnt.Location = New System.Drawing.Point(392, 12)
        Me.txtHermanosOtrosAnt.MaxLength = 512
        Me.txtHermanosOtrosAnt.Multiline = True
        Me.txtHermanosOtrosAnt.Name = "txtHermanosOtrosAnt"
        Me.txtHermanosOtrosAnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHermanosOtrosAnt.Size = New System.Drawing.Size(336, 64)
        Me.txtHermanosOtrosAnt.TabIndex = 9
        '
        'chkHermanos08
        '
        Me.chkHermanos08.Location = New System.Drawing.Point(260, 36)
        Me.chkHermanos08.Name = "chkHermanos08"
        Me.chkHermanos08.Size = New System.Drawing.Size(128, 24)
        Me.chkHermanos08.TabIndex = 8
        Me.chkHermanos08.Text = "Otros antecedentes"
        '
        'chkHermanos07
        '
        Me.chkHermanos07.Location = New System.Drawing.Point(260, 16)
        Me.chkHermanos07.Name = "chkHermanos07"
        Me.chkHermanos07.Size = New System.Drawing.Size(64, 24)
        Me.chkHermanos07.TabIndex = 7
        Me.chkHermanos07.Text = "Cáncer"
        '
        'chkHermanos04
        '
        Me.chkHermanos04.Location = New System.Drawing.Point(160, 16)
        Me.chkHermanos04.Name = "chkHermanos04"
        Me.chkHermanos04.Size = New System.Drawing.Size(80, 24)
        Me.chkHermanos04.TabIndex = 4
        Me.chkHermanos04.Text = "Cardiópata"
        '
        'chkHermanos01
        '
        Me.chkHermanos01.Location = New System.Drawing.Point(8, 16)
        Me.chkHermanos01.Name = "chkHermanos01"
        Me.chkHermanos01.Size = New System.Drawing.Size(56, 24)
        Me.chkHermanos01.TabIndex = 1
        Me.chkHermanos01.Text = "HTA"
        '
        'botCancelar
        '
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Image)
        Me.botCancelar.Location = New System.Drawing.Point(8, 637)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(224, 23)
        Me.botCancelar.TabIndex = 8
        Me.botCancelar.Text = "Salir"
        '
        'botAceptar
        '
        Me.botAceptar.Enabled = False
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.Image = CType(resources.GetObject("botAceptar.Image"), System.Drawing.Image)
        Me.botAceptar.Location = New System.Drawing.Point(758, 637)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(224, 23)
        Me.botAceptar.TabIndex = 7
        Me.botAceptar.Text = "Aceptar"
        '
        'FormAntecedentesFamiliares
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.botCancelar)
        Me.Controls.Add(Me.botAceptar)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormAntecedentesFamiliares"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antecedentes Familiares"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPagePadres.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GBpadreCausaMuerte.ResumeLayout(False)
        Me.GBpadreCausaMuerte.PerformLayout()
        Me.GBpadreAntecedentes.ResumeLayout(False)
        Me.GBpadreAntecedentes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GBmadreCausaMuerte.ResumeLayout(False)
        Me.GBmadreCausaMuerte.PerformLayout()
        Me.GBmadreAntecedentes.ResumeLayout(False)
        Me.GBmadreAntecedentes.PerformLayout()
        Me.TabPageAbuelosPaternos.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GBAbueloPaternocausaMuerte.ResumeLayout(False)
        Me.GBAbueloPaternocausaMuerte.PerformLayout()
        Me.GBAbueloPaternoAntecedentes.ResumeLayout(False)
        Me.GBAbueloPaternoAntecedentes.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GBAbuelaPaternaCausaMuerte.ResumeLayout(False)
        Me.GBAbuelaPaternaCausaMuerte.PerformLayout()
        Me.GBAbuelaPaternaAntecedentes.ResumeLayout(False)
        Me.GBAbuelaPaternaAntecedentes.PerformLayout()
        Me.TabPageAbuelosMaternos.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GBAbueloMaternoCausaMuerte.ResumeLayout(False)
        Me.GBAbueloMaternoCausaMuerte.PerformLayout()
        Me.GBAbueloMaternoAntecedentes.ResumeLayout(False)
        Me.GBAbueloMaternoAntecedentes.PerformLayout()
        Me.gb2.ResumeLayout(False)
        Me.GBAbuelaMaternaCausaMuerte.ResumeLayout(False)
        Me.GBAbuelaMaternaCausaMuerte.PerformLayout()
        Me.GBAbuelaMaternaAntecedentes.ResumeLayout(False)
        Me.GBAbuelaMaternaAntecedentes.PerformLayout()
        Me.TabPageOtros.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'variable publica de resultado a form1
    'public Shared ResultadoAntecedentesFamiliares As String
    Dim ANT As String 'es un temporal para no escribir tanto....

    'variables de los graficos
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image

    'VARIABLES DEL PROCEDIMIENTO
    Dim fileAntFamiliares As String
    Dim fileAntFamiliaresRES As String
    Dim SePoducieronCambios As Boolean

    'estructura de los antecedentes familiares
    Structure EstructuraAntFamiliares
        'MADRE
        Dim MadreVivaMuertaDesconoce As String
        Dim MadreNiegaTieneDesconoceAnt As String
        Dim MadreCHK01 As String
        Dim MadreCHK02 As String
        Dim MadreCHK03 As String
        Dim MadreCHK04 As String
        Dim MadreCHK05 As String
        Dim MadreCHK06 As String
        Dim MadreCHK07 As String
        Dim MadreCHK08 As String
        Dim MadreOtrosAntecedentes As String
        Dim MadreCausaDeMuerte As String
        Dim MadreOtrasCausasMuerte As String
        'PADRE
        Dim PadreVivaMuertaDesconoce As String
        Dim PadreNiegaTieneDesconoceAnt As String
        Dim PadreCHK01 As String
        Dim PadreCHK02 As String
        Dim PadreCHK03 As String
        Dim PadreCHK04 As String
        Dim PadreCHK05 As String
        Dim PadreCHK06 As String
        Dim PadreCHK07 As String
        Dim PadreCHK08 As String
        Dim PadreOtrosAntecedentes As String
        Dim PadreCausaDeMuerte As String
        Dim PadreOtrasCausasMuerte As String
        'AbuelaPaterna
        Dim AbuelaPaternaVivaMuertaDesconoce As String
        Dim AbuelaPaternaNiegaTieneDesconoceAnt As String
        Dim AbuelaPaternaCHK01 As String
        Dim AbuelaPaternaCHK02 As String
        Dim AbuelaPaternaCHK03 As String
        Dim AbuelaPaternaCHK04 As String
        Dim AbuelaPaternaCHK05 As String
        Dim AbuelaPaternaCHK06 As String
        Dim AbuelaPaternaCHK07 As String
        Dim AbuelaPaternaCHK08 As String
        Dim AbuelaPaternaOtrosAntecedentes As String
        Dim AbuelaPaternaCausaDeMuerte As String
        Dim AbuelaPaternaOtrasCausasMuerte As String
        'Abuelopaterno
        Dim AbuelopaternoVivaMuertaDesconoce As String
        Dim AbuelopaternoNiegaTieneDesconoceAnt As String
        Dim AbuelopaternoCHK01 As String
        Dim AbuelopaternoCHK02 As String
        Dim AbuelopaternoCHK03 As String
        Dim AbuelopaternoCHK04 As String
        Dim AbuelopaternoCHK05 As String
        Dim AbuelopaternoCHK06 As String
        Dim AbuelopaternoCHK07 As String
        Dim AbuelopaternoCHK08 As String
        Dim AbuelopaternoOtrosAntecedentes As String
        Dim AbuelopaternoCausaDeMuerte As String
        Dim AbuelopaternoOtrasCausasMuerte As String
        'AbuelaMaterna
        Dim AbuelaMaternaVivaMuertaDesconoce As String
        Dim AbuelaMaternaNiegaTieneDesconoceAnt As String
        Dim AbuelaMaternaCHK01 As String
        Dim AbuelaMaternaCHK02 As String
        Dim AbuelaMaternaCHK03 As String
        Dim AbuelaMaternaCHK04 As String
        Dim AbuelaMaternaCHK05 As String
        Dim AbuelaMaternaCHK06 As String
        Dim AbuelaMaternaCHK07 As String
        Dim AbuelaMaternaCHK08 As String
        Dim AbuelaMaternaOtrosAntecedentes As String
        Dim AbuelaMaternaCausaDeMuerte As String
        Dim AbuelaMaternaOtrasCausasMuerte As String
        'AbueloMaterno
        Dim AbueloMaternoVivaMuertaDesconoce As String
        Dim AbueloMaternoNiegaTieneDesconoceAnt As String
        Dim AbueloMaternoCHK01 As String
        Dim AbueloMaternoCHK02 As String
        Dim AbueloMaternoCHK03 As String
        Dim AbueloMaternoCHK04 As String
        Dim AbueloMaternoCHK05 As String
        Dim AbueloMaternoCHK06 As String
        Dim AbueloMaternoCHK07 As String
        Dim AbueloMaternoCHK08 As String
        Dim AbueloMaternoOtrosAntecedentes As String
        Dim AbueloMaternoCausaDeMuerte As String
        Dim AbueloMaternoOtrasCausasMuerte As String
        'HERMANOS
        Dim HermanosCHK01 As String
        Dim HermanosCHK02 As String
        Dim HermanosCHK03 As String
        Dim HermanosCHK04 As String
        Dim HermanosCHK05 As String
        Dim HermanosCHK06 As String
        Dim HermanosCHK07 As String
        Dim HermanosCHK08 As String
        Dim HermanosOtrosAntecedentes As String
        Dim HermanosMuertosCHK01 As String
        Dim HermanosMuertosCHK02 As String
        Dim HermanosMuertosCHK03 As String
        Dim HermanosMuertosCHK04 As String
        Dim HermanosMuertosCHK05 As String
        Dim HermanosMuertosCHK06 As String
        Dim HermanosMuertosCHK07 As String
        Dim HermanosMuertosCHK08 As String
        Dim HermanosMuertosCHK09 As String
        Dim HermanosOtrasCausasMuerte As String
        'Tios
        Dim tiosCHK01 As String
        Dim tiosCHK02 As String
        Dim tiosCHK03 As String
        Dim tiosCHK04 As String
        Dim tiosCHK05 As String
        Dim tiosCHK06 As String
        Dim tiosCHK07 As String
        Dim tiosCHK08 As String
        Dim tiosOtrosAntecedentes As String
        Dim tiosMuertosCHK01 As String
        Dim tiosMuertosCHK02 As String
        Dim tiosMuertosCHK03 As String
        Dim tiosMuertosCHK04 As String
        Dim tiosMuertosCHK05 As String
        Dim tiosMuertosCHK06 As String
        Dim tiosMuertosCHK07 As String
        Dim tiosMuertosCHK08 As String
        Dim tiosMuertosCHK09 As String
        Dim tiosOtrasCausasMuerte As String
        'otros familiares
        Dim OtrosFamiliares As String
    End Structure

    Dim AF As EstructuraAntFamiliares

    Private Sub FormAntecedentesFamiliares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CreaNombres()

        If Form1.PSbooConsultaAntecedentesFamiliares = True Then
            'modo de consulta con carga de datos en var publicas y cierre automatico
            Form1.PSbooConsultaAntecedentesFamiliares = False 'apaga bandera

            If File.Exists(fileAntFamiliares) = True Then
                'primero pone la pantalla en cero
                InicializaConfiguracion()
                'Carga el registro previo de antecedentes familiares
                CargaAntecedentesFamiliares()
                'actualiza la pantalla con los datos del regitro
                ActualizaLaPantallaConLaEstructura()
                'construye el dialogo
                ConstruyeDialogo()
                'cierra la ventana y vuelve a la de los datos personales
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else
                'no existe registro previo
                Form1.PSstrResultadoAntecedentesFamiliares = ""
                'cierra la ventana y vuelve a la de los datos familiares
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Else
            'modo normal de edicion de ant personales

            If File.Exists(fileAntFamiliares) = True Then
                'primero pone la pantalla en cero
                InicializaConfiguracion()
                'Carga el registro previo de antecedentes familiares
                CargaAntecedentesFamiliares()
                'actualiza la pantalla con los datos del regitro
                ActualizaLaPantallaConLaEstructura()
                'dice a la bandera que no se han producido cambios
                NoHayCambios()
            Else
                'no existe registro previo
                InicializaConfiguracion()
                InicializaEstructura()
                NoHayCambios()
            End If
        End If


    End Sub

    Private Sub CreaNombres()
        'crea el nombre del archivo de antecedentes familiares
        fileAntFamiliares = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Familiares.dat"
        fileAntFamiliaresRES = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Familiares.res"

        'le pone nombre al titulo
        Me.Text = "Antecedentes Familiares de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"

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
    End Sub

    Private Sub InicializaConfiguracion()
        MadreBorraAntecedentes()
        MadreApagaAntecedentes()
        GBmadreAntecedentes.Enabled = False

        PadreBorraAntecedentes()
        PadreApagaAntecedentes()
        GBpadreAntecedentes.Enabled = False

        AbuelaPaternaBorraAntecedentes()
        AbuelaPaternaApagaAntecedentes()
        GBAbuelaPaternaAntecedentes.Enabled = False

        AbueloPaternoBorraAntecedentes()
        AbueloPaternoApagaAntecedentes()
        GBAbueloPaternoAntecedentes.Enabled = False

        AbuelaMaternaBorraAntecedentes()
        AbuelaMaternaApagaAntecedentes()
        GBAbuelaMaternaAntecedentes.Enabled = False

        AbueloMaternoBorraAntecedentes()
        AbueloMaternoApagaAntecedentes()
        GBAbueloMaternoAntecedentes.Enabled = False

        HermanosBorraAntecedentes()
        HermanosBorraCausas()

        TiosBorraAntecedentes()
        TiosBorraCausas()

        txtOtrosFamiliares.Clear()

    End Sub

    Private Sub InicializaEstructura()
        'MADRE
        AF.MadreVivaMuertaDesconoce = "0"
        AF.MadreNiegaTieneDesconoceAnt = "0"
        AF.MadreCHK01 = "0"
        AF.MadreCHK02 = "0"
        AF.MadreCHK03 = "0"
        AF.MadreCHK04 = "0"
        AF.MadreCHK05 = "0"
        AF.MadreCHK06 = "0"
        AF.MadreCHK07 = "0"
        AF.MadreCHK08 = "0"
        AF.MadreOtrosAntecedentes = ""
        AF.MadreCausaDeMuerte = "0"
        AF.MadreOtrasCausasMuerte = ""
        'PADRE
        AF.PadreVivaMuertaDesconoce = "0"
        AF.PadreNiegaTieneDesconoceAnt = "0"
        AF.PadreCHK01 = "0"
        AF.PadreCHK02 = "0"
        AF.PadreCHK03 = "0"
        AF.PadreCHK04 = "0"
        AF.PadreCHK05 = "0"
        AF.PadreCHK06 = "0"
        AF.PadreCHK07 = "0"
        AF.PadreCHK08 = "0"
        AF.PadreOtrosAntecedentes = ""
        AF.PadreCausaDeMuerte = "0"
        AF.PadreOtrasCausasMuerte = ""
        'AbuelaPaterna
        AF.AbuelaPaternaVivaMuertaDesconoce = "0"
        AF.AbuelaPaternaNiegaTieneDesconoceAnt = "0"
        AF.AbuelaPaternaCHK01 = "0"
        AF.AbuelaPaternaCHK02 = "0"
        AF.AbuelaPaternaCHK03 = "0"
        AF.AbuelaPaternaCHK04 = "0"
        AF.AbuelaPaternaCHK05 = "0"
        AF.AbuelaPaternaCHK06 = "0"
        AF.AbuelaPaternaCHK07 = "0"
        AF.AbuelaPaternaCHK08 = "0"
        AF.AbuelaPaternaOtrosAntecedentes = ""
        AF.AbuelaPaternaCausaDeMuerte = "0"
        AF.AbuelaPaternaOtrasCausasMuerte = ""
        'AbueloPaterno
        AF.AbuelopaternoVivaMuertaDesconoce = "0"
        AF.AbuelopaternoNiegaTieneDesconoceAnt = "0"
        AF.AbuelopaternoCHK01 = "0"
        AF.AbuelopaternoCHK02 = "0"
        AF.AbuelopaternoCHK03 = "0"
        AF.AbuelopaternoCHK04 = "0"
        AF.AbuelopaternoCHK05 = "0"
        AF.AbuelopaternoCHK06 = "0"
        AF.AbuelopaternoCHK07 = "0"
        AF.AbuelopaternoCHK08 = "0"
        AF.AbuelopaternoOtrosAntecedentes = ""
        AF.AbuelopaternoCausaDeMuerte = "0"
        AF.AbuelopaternoOtrasCausasMuerte = ""
        'AbuelaMaterna
        AF.AbuelaMaternaVivaMuertaDesconoce = "0"
        AF.AbuelaMaternaNiegaTieneDesconoceAnt = "0"
        AF.AbuelaMaternaCHK01 = "0"
        AF.AbuelaMaternaCHK02 = "0"
        AF.AbuelaMaternaCHK03 = "0"
        AF.AbuelaMaternaCHK04 = "0"
        AF.AbuelaMaternaCHK05 = "0"
        AF.AbuelaMaternaCHK06 = "0"
        AF.AbuelaMaternaCHK07 = "0"
        AF.AbuelaMaternaCHK08 = "0"
        AF.AbuelaMaternaOtrosAntecedentes = ""
        AF.AbuelaMaternaCausaDeMuerte = "0"
        AF.AbuelaMaternaOtrasCausasMuerte = ""
        'AbueloMaterno
        AF.AbueloMaternoVivaMuertaDesconoce = "0"
        AF.AbueloMaternoNiegaTieneDesconoceAnt = "0"
        AF.AbueloMaternoCHK01 = "0"
        AF.AbueloMaternoCHK02 = "0"
        AF.AbueloMaternoCHK03 = "0"
        AF.AbueloMaternoCHK04 = "0"
        AF.AbueloMaternoCHK05 = "0"
        AF.AbueloMaternoCHK06 = "0"
        AF.AbueloMaternoCHK07 = "0"
        AF.AbueloMaternoCHK08 = "0"
        AF.AbueloMaternoOtrosAntecedentes = ""
        AF.AbueloMaternoCausaDeMuerte = "0"
        AF.AbueloMaternoOtrasCausasMuerte = ""
        'Hermanos
        AF.HermanosCHK01 = "0"
        AF.HermanosCHK02 = "0"
        AF.HermanosCHK03 = "0"
        AF.HermanosCHK04 = "0"
        AF.HermanosCHK05 = "0"
        AF.HermanosCHK06 = "0"
        AF.HermanosCHK07 = "0"
        AF.HermanosCHK08 = "0"
        AF.HermanosOtrosAntecedentes = ""
        AF.HermanosMuertosCHK01 = "0"
        AF.HermanosMuertosCHK02 = "0"
        AF.HermanosMuertosCHK03 = "0"
        AF.HermanosMuertosCHK04 = "0"
        AF.HermanosMuertosCHK05 = "0"
        AF.HermanosMuertosCHK06 = "0"
        AF.HermanosMuertosCHK07 = "0"
        AF.HermanosMuertosCHK08 = "0"
        AF.HermanosMuertosCHK09 = "0"
        AF.HermanosOtrasCausasMuerte = ""
        'tios
        AF.tiosCHK01 = "0"
        AF.tiosCHK02 = "0"
        AF.tiosCHK03 = "0"
        AF.tiosCHK04 = "0"
        AF.tiosCHK05 = "0"
        AF.tiosCHK06 = "0"
        AF.tiosCHK07 = "0"
        AF.tiosCHK08 = "0"
        AF.tiosOtrosAntecedentes = ""
        AF.tiosMuertosCHK01 = "0"
        AF.tiosMuertosCHK02 = "0"
        AF.tiosMuertosCHK03 = "0"
        AF.tiosMuertosCHK04 = "0"
        AF.tiosMuertosCHK05 = "0"
        AF.tiosMuertosCHK06 = "0"
        AF.tiosMuertosCHK07 = "0"
        AF.tiosMuertosCHK08 = "0"
        AF.tiosMuertosCHK09 = "0"
        AF.tiosOtrasCausasMuerte = ""
        'otros familiares
        AF.OtrosFamiliares = ""

    End Sub

    'subrutina para cuando se producen cambios
    Private Sub SeProdujoUnCambio()
        SePoducieronCambios = True
        botCancelar.Text = "Descarta Cambios"
        botAceptar.Enabled = True
    End Sub

    Private Sub NoHayCambios()
        SePoducieronCambios = False
        botCancelar.Text = "Salir"
        botAceptar.Enabled = False
    End Sub

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        'construye el dialogo
        ConstruyeDialogo()
        'crea o actualiza el archivo de ant familiares
        CreaAntecedentesFamiliares()
        'cierra la ventana y vuelve a la de los datos personales
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ConstruyeDialogo()

        'inicializa estructura
        InicializaEstructura()

        'inicializa la variable de recoleccion
        ANT = ""

        'Madre
        ConstruyeDialogoMadre()
        'Padre
        ConstruyeDialogoPadre()
        'Abuela paterna
        ConstruyeDialogoAbuelaPaterna()
        'Abuelo paterno
        ConstruyeDialogoAbueloPaterno()
        'Abuela materna
        ConstruyeDialogoAbuelaMaterna()
        'Abuelo materno
        ConstruyeDialogoAbueloMaterno()
        'Hermanos
        ConstruyeDialogoHermanos()
        'Tios
        ConstruyeDialogoTios()
        'Otros familiares y comentarios adicionales
        ConstruyeDialogoOtros()

        '00000000000000000
        'entrega los datos finales a la variable publica
        Form1.PSstrResultadoAntecedentesFamiliares = ANT

    End Sub

    Private Sub ConstruyeDialogoMadre()
        'PARTE DE LA MADRE

        Dim HastaAhoraNada As Boolean
        Dim NecesitaPunto As Boolean
        Dim NadaEnElParrafo As Boolean

        'inicializa bandera
        NadaEnElParrafo = True
        NecesitaPunto = False

        If radMadreViva.Checked = True Then
            ANT += "Madre viva"
            AF.MadreVivaMuertaDesconoce = "1"
            NadaEnElParrafo = False
            NecesitaPunto = True
        End If

        If radMadreMuerta.Checked = True Then
            ANT += "Madre falleció"
            AF.MadreVivaMuertaDesconoce = "2"
            NadaEnElParrafo = False
            NecesitaPunto = True
        End If



        If radMadreNiega.Checked = True Then
            ANT += ", niega antecedentes patológicos."
            AF.MadreNiegaTieneDesconoceAnt = "1"
            NecesitaPunto = False
        ElseIf radMadreDesconocePatologia.Checked = True Then
            ANT += ", desconoce antecedentes patológicos."
            AF.MadreNiegaTieneDesconoceAnt = "3"
            NecesitaPunto = False
        ElseIf radMadreTieneAnt.Checked = True Then
            AF.MadreNiegaTieneDesconoceAnt = "2"

            HastaAhoraNada = True
            If chkMadre01.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "HTA"
                AF.MadreCHK01 = "1"
                NecesitaPunto = True
            Else
                AF.MadreCHK01 = "0"
            End If
            If chkMadre02.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "DM"
                NecesitaPunto = True
                AF.MadreCHK02 = "1"
            Else
                AF.MadreCHK02 = "0"
            End If
            If chkMadre03.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "TBC"
                NecesitaPunto = True
                AF.MadreCHK03 = "1"
            Else
                AF.MadreCHK03 = "0"
            End If
            If chkMadre04.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "cardiopatía"
                NecesitaPunto = True
                AF.MadreCHK04 = "1"
            Else
                AF.MadreCHK04 = "0"
            End If
            If chkMadre05.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "epilepsia"
                NecesitaPunto = True
                AF.MadreCHK05 = "1"
            Else
                AF.MadreCHK05 = "0"
            End If
            If chkMadre06.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "nefropatía"
                NecesitaPunto = True
                AF.MadreCHK06 = "1"
            Else
                AF.MadreCHK06 = "0"
            End If
            If chkMadre07.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "CA"
                NecesitaPunto = True
                AF.MadreCHK07 = "1"
            Else
                AF.MadreCHK07 = "0"
            End If
            If chkMadreOtros.Checked = True And txtMadreOtrosAnt.Text <> "" Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += txtMadreOtrosAnt.Text.ToLower
                'ojo el text otro debe salir sin punto al final
                NecesitaPunto = True
                AF.MadreCHK08 = "1"
                AF.MadreOtrosAntecedentes = txtMadreOtrosAnt.Text.ToLower
            Else
                AF.MadreCHK08 = "0"
                AF.MadreOtrosAntecedentes = ""
            End If
        Else
            'no esta presionado ningun rad porq desconoce todo
            'borra todo de los antecedentes y no dice ni pio
            AF.MadreNiegaTieneDesconoceAnt = "0"
            AF.MadreCHK01 = "0"
            AF.MadreCHK02 = "0"
            AF.MadreCHK03 = "0"
            AF.MadreCHK04 = "0"
            AF.MadreCHK05 = "0"
            AF.MadreCHK06 = "0"
            AF.MadreCHK07 = "0"
            AF.MadreCHK08 = "0"
            AF.MadreOtrosAntecedentes = ""
        End If

        'verifica si se necesita punto para el siguiente parrafo
        If NecesitaPunto = True Then
            ANT += "."
            NecesitaPunto = False
        End If

        'madre causas de muerte
        If radMadre01.Checked = True Then
            ANT += " Muerte debida a cardiopatía."
            AF.MadreCausaDeMuerte = "1"
            NecesitaPunto = False
        End If
        If radMadre02.Checked = True Then
            ANT += " Muerte debida a neuropatía."
            AF.MadreCausaDeMuerte = "2"
            NecesitaPunto = False
        End If
        If radMadre03.Checked = True Then
            ANT += " Muerte debida a nefropatía."
            AF.MadreCausaDeMuerte = "3"
            NecesitaPunto = False
        End If
        If radMadre04.Checked = True Then
            ANT += " Muerte debida a hepatopatía."
            AF.MadreCausaDeMuerte = "4"
            NecesitaPunto = False
        End If
        If radMadre05.Checked = True Then
            ANT += " Muerte debida a neumopatia."
            AF.MadreCausaDeMuerte = "5"
            NecesitaPunto = False
        End If
        If radMadre06.Checked = True Then
            ANT += " Muerte debida a cáncer."
            AF.MadreCausaDeMuerte = "6"
            NecesitaPunto = False
        End If
        If radMadre07.Checked = True Then
            ANT += " Muerte debida a desequilibrio metabólico."
            AF.MadreCausaDeMuerte = "7"
            NecesitaPunto = False
        End If
        If radMadre08.Checked = True Then
            ANT += " Muerte debida a causas naturales."
            AF.MadreCausaDeMuerte = "8"
            NecesitaPunto = False
        End If
        If radMadreDesconoceCausa.Checked = True Then
            ANT += " Desconoce la causa de muerte."
            AF.MadreCausaDeMuerte = "9"
            NecesitaPunto = False
        End If
        If radMadreOtrasCausas.Checked = True Then
            If txtMadreOtrasCausas.Text = "" Then
                'caja de texto vacia se toma como que desconoce
                ANT += " Desconoce la causa de muerte."
                AF.MadreCausaDeMuerte = "9"
                NecesitaPunto = False
            Else
                'se puso algo en el texto
                ANT += " Muerte debida a " & txtMadreOtrasCausas.Text.ToLower
                AF.MadreCausaDeMuerte = "10"
                AF.MadreOtrasCausasMuerte = txtMadreOtrasCausas.Text.ToLower
                NecesitaPunto = True
            End If
        End If

        If radMadreDesconoce.Checked = True Then
            ANT += "Desconoce datos de su madre."
            AF.MadreVivaMuertaDesconoce = "3"
            NadaEnElParrafo = False
            NecesitaPunto = False
        End If

        'revisa si hace falta punto
        If NecesitaPunto = True Then
            ANT += "."
        End If

        'pasa el parrafo si se escribio algo
        If NadaEnElParrafo = False Then
            ANT += "  "
        End If

    End Sub
    Private Sub ConstruyeDialogoPadre()
        'PARTE DEL Padre

        Dim HastaAhoraNada As Boolean
        Dim NecesitaPunto As Boolean
        Dim booParrafoVacio As Boolean
        'Dim SeEscribioAlgo As Boolean

        'inicializa bandera
        booParrafoVacio = True
        NecesitaPunto = False

        If radPadreViva.Checked = True Then
            ANT += "Padre vivo"
            AF.PadreVivaMuertaDesconoce = "1"
            booParrafoVacio = False
            NecesitaPunto = True
        End If

        If radPadreMuerta.Checked = True Then
            ANT += "Padre falleció"
            AF.PadreVivaMuertaDesconoce = "2"
            booParrafoVacio = False
            NecesitaPunto = True
        End If



        If radPadreNiega.Checked = True Then
            ANT += ", niega antecedentes patológicos."
            AF.PadreNiegaTieneDesconoceAnt = "1"
            NecesitaPunto = False
        ElseIf radPadreDesconocePatologia.Checked = True Then
            ANT += ", desconoce antecedentes patológicos."
            AF.PadreNiegaTieneDesconoceAnt = "3"
            NecesitaPunto = False
        ElseIf radPadreTieneAnt.Checked = True Then
            AF.PadreNiegaTieneDesconoceAnt = "2"

            HastaAhoraNada = True
            If chkPadre01.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "HTA"
                AF.PadreCHK01 = "1"
                NecesitaPunto = True
            Else
                AF.PadreCHK01 = "0"
            End If
            If chkPadre02.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "DM"
                NecesitaPunto = True
                AF.PadreCHK02 = "1"
            Else
                AF.PadreCHK02 = "0"
            End If
            If chkPadre03.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "TBC"
                NecesitaPunto = True
                AF.PadreCHK03 = "1"
            Else
                AF.PadreCHK03 = "0"
            End If
            If chkPadre04.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "cardiopatía"
                NecesitaPunto = True
                AF.PadreCHK04 = "1"
            Else
                AF.PadreCHK04 = "0"
            End If
            If chkPadre05.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "epilepsia"
                NecesitaPunto = True
                AF.PadreCHK05 = "1"
            Else
                AF.PadreCHK05 = "0"
            End If
            If chkPadre06.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "nefropatía"
                NecesitaPunto = True
                AF.PadreCHK06 = "1"
            Else
                AF.PadreCHK06 = "0"
            End If
            If chkPadre07.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "CA"
                NecesitaPunto = True
                AF.PadreCHK07 = "1"
            Else
                AF.PadreCHK07 = "0"
            End If
            If chkPadreotros.Checked = True And txtPadreOtrosAnt.Text <> "" Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += txtPadreOtrosAnt.Text.ToLower
                'ojo el text otro debe salir sin punto al final
                NecesitaPunto = True
                AF.PadreCHK08 = "1"
                AF.PadreOtrosAntecedentes = txtPadreOtrosAnt.Text.ToLower
            Else
                AF.PadreCHK08 = "0"
                AF.PadreOtrosAntecedentes = ""
            End If
        Else
            'no esta presionado ningun rad porq desconoce todo
            'borra todo de los antecedentes y no dice ni pio
            AF.PadreNiegaTieneDesconoceAnt = "0"
            AF.PadreCHK01 = "0"
            AF.PadreCHK02 = "0"
            AF.PadreCHK03 = "0"
            AF.PadreCHK04 = "0"
            AF.PadreCHK05 = "0"
            AF.PadreCHK06 = "0"
            AF.PadreCHK07 = "0"
            AF.PadreCHK08 = "0"
            AF.PadreOtrosAntecedentes = ""
        End If

        'verifica si se necesita punto para el siguiente parrafo
        If NecesitaPunto = True Then
            ANT += "."
            NecesitaPunto = False
        End If

        'Padre causas de muerte
        If radPadre01.Checked = True Then
            ANT += " Muerte debida a cardiopatía."
            AF.PadreCausaDeMuerte = "1"
            NecesitaPunto = False
        End If
        If radPadre02.Checked = True Then
            ANT += " Muerte debida a neuropatía."
            AF.PadreCausaDeMuerte = "2"
            NecesitaPunto = False
        End If
        If radPadre03.Checked = True Then
            ANT += " Muerte debida a nefropatía."
            AF.PadreCausaDeMuerte = "3"
            NecesitaPunto = False
        End If
        If radPadre04.Checked = True Then
            ANT += " Muerte debida a hepatopatía."
            AF.PadreCausaDeMuerte = "4"
            NecesitaPunto = False
        End If
        If radPadre05.Checked = True Then
            ANT += " Muerte debida a neumopatia."
            AF.PadreCausaDeMuerte = "5"
            NecesitaPunto = False
        End If
        If radPadre06.Checked = True Then
            ANT += " Muerte debida a cáncer."
            AF.PadreCausaDeMuerte = "6"
            NecesitaPunto = False
        End If
        If radPadre07.Checked = True Then
            ANT += " Muerte debida a desequilibrio metabólico."
            AF.PadreCausaDeMuerte = "7"
            NecesitaPunto = False
        End If
        If radPadre08.Checked = True Then
            ANT += " Muerte debida a causas naturales."
            AF.PadreCausaDeMuerte = "8"
            NecesitaPunto = False
        End If
        If radPadreDesconoceCausa.Checked = True Then
            ANT += " Desconoce la causa de muerte."
            AF.PadreCausaDeMuerte = "9"
            NecesitaPunto = False
        End If
        If radPadreOtrasCausas.Checked = True Then
            If txtPadreOtrasCausas.Text = "" Then
                'caja de texto vacia se toma como que desconoce
                ANT += " Desconoce la causa de muerte."
                AF.PadreCausaDeMuerte = "9"
                NecesitaPunto = False
            Else
                'se puso algo en el texto
                ANT += " Muerte debida a " & txtPadreOtrasCausas.Text.ToLower
                AF.PadreCausaDeMuerte = "10"
                AF.PadreOtrasCausasMuerte = txtPadreOtrasCausas.Text.ToLower
                NecesitaPunto = True
            End If
        End If

        If radPadreDesconoce.Checked = True Then
            ANT += "Desconoce datos de su Padre."
            AF.PadreVivaMuertaDesconoce = "3"
            booParrafoVacio = False
            NecesitaPunto = False
        End If

        'revisa si hace falta punto
        If NecesitaPunto = True Then
            ANT += "."
        End If

        'pasa el parrafo si se escribio algo
        If booParrafoVacio = False Then
            ANT += "  "
        End If
    End Sub
    Private Sub ConstruyeDialogoAbuelaPaterna()
        Dim HastaAhoraNada As Boolean
        Dim NecesitaPunto As Boolean
        Dim NadaEnElParrafo As Boolean
        'Dim SeEscribioAlgo As Boolean

        'PARTE DE LA Abuela Paterna

        'inicializa bandera
        NadaEnElParrafo = True
        NecesitaPunto = False

        If radAbuelaPaternaViva.Checked = True Then
            ANT += "Abuela paterna viva"
            AF.AbuelaPaternaVivaMuertaDesconoce = "1"
            NadaEnElParrafo = False
            NecesitaPunto = True
        End If

        If radAbuelaPaternaMuerta.Checked = True Then
            ANT += "Abuela paterna falleció"
            AF.AbuelaPaternaVivaMuertaDesconoce = "2"
            NadaEnElParrafo = False
            NecesitaPunto = True
        End If



        If radAbuelaPaternaNiega.Checked = True Then
            ANT += ", niega antecedentes patológicos."
            AF.AbuelaPaternaNiegaTieneDesconoceAnt = "1"
            NecesitaPunto = False
        ElseIf radAbuelaPaternaDesconocePatologia.Checked = True Then
            ANT += ", desconoce antecedentes patológicos."
            AF.AbuelaPaternaNiegaTieneDesconoceAnt = "3"
            NecesitaPunto = False
        ElseIf radAbuelaPaternaTieneAnt.Checked = True Then
            AF.AbuelaPaternaNiegaTieneDesconoceAnt = "2"

            HastaAhoraNada = True
            If chkAbuelaPaterna01.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "HTA"
                AF.AbuelaPaternaCHK01 = "1"
                NecesitaPunto = True
            Else
                AF.AbuelaPaternaCHK01 = "0"
            End If
            If chkAbuelaPaterna02.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "DM"
                NecesitaPunto = True
                AF.AbuelaPaternaCHK02 = "1"
            Else
                AF.AbuelaPaternaCHK02 = "0"
            End If
            If chkAbuelaPaterna03.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "TBC"
                NecesitaPunto = True
                AF.AbuelaPaternaCHK03 = "1"
            Else
                AF.AbuelaPaternaCHK03 = "0"
            End If
            If chkAbuelaPaterna04.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "cardiopatía"
                NecesitaPunto = True
                AF.AbuelaPaternaCHK04 = "1"
            Else
                AF.AbuelaPaternaCHK04 = "0"
            End If
            If chkAbuelaPaterna05.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "epilepsia"
                NecesitaPunto = True
                AF.AbuelaPaternaCHK05 = "1"
            Else
                AF.AbuelaPaternaCHK05 = "0"
            End If
            If chkAbuelaPaterna06.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "nefropatía"
                NecesitaPunto = True
                AF.AbuelaPaternaCHK06 = "1"
            Else
                AF.AbuelaPaternaCHK06 = "0"
            End If
            If chkAbuelaPaterna07.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "CA"
                NecesitaPunto = True
                AF.AbuelaPaternaCHK07 = "1"
            Else
                AF.AbuelaPaternaCHK07 = "0"
            End If
            If chkAbuelaPaternaOtros.Checked = True And txtAbuelaPaternaOtrosAnt.Text <> "" Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += txtAbuelaPaternaOtrosAnt.Text.ToLower
                'ojo el text otro debe salir sin punto al final
                NecesitaPunto = True
                AF.AbuelaPaternaCHK08 = "1"
                AF.AbuelaPaternaOtrosAntecedentes = txtAbuelaPaternaOtrosAnt.Text.ToLower
            Else
                AF.AbuelaPaternaCHK08 = "0"
                AF.AbuelaPaternaOtrosAntecedentes = ""
            End If
        Else
            'no esta presionado ningun rad porq desconoce todo
            'borra todo de los antecedentes y no dice ni pio
            AF.AbuelaPaternaNiegaTieneDesconoceAnt = "0"
            AF.AbuelaPaternaCHK01 = "0"
            AF.AbuelaPaternaCHK02 = "0"
            AF.AbuelaPaternaCHK03 = "0"
            AF.AbuelaPaternaCHK04 = "0"
            AF.AbuelaPaternaCHK05 = "0"
            AF.AbuelaPaternaCHK06 = "0"
            AF.AbuelaPaternaCHK07 = "0"
            AF.AbuelaPaternaCHK08 = "0"
            AF.AbuelaPaternaOtrosAntecedentes = ""
        End If

        'verifica si se necesita punto para el siguiente parrafo
        If NecesitaPunto = True Then
            ANT += "."
            NecesitaPunto = False
        End If

        'AbuelaPaterna causas de muerte
        If radAbuelaPaterna01.Checked = True Then
            ANT += " Muerte debida a cardiopatía."
            AF.AbuelaPaternaCausaDeMuerte = "1"
            NecesitaPunto = False
        End If
        If radAbuelaPaterna02.Checked = True Then
            ANT += " Muerte debida a neuropatía."
            AF.AbuelaPaternaCausaDeMuerte = "2"
            NecesitaPunto = False
        End If
        If radAbuelaPaterna03.Checked = True Then
            ANT += " Muerte debida a nefropatía."
            AF.AbuelaPaternaCausaDeMuerte = "3"
            NecesitaPunto = False
        End If
        If radAbuelaPaterna04.Checked = True Then
            ANT += " Muerte debida a hepatopatía."
            AF.AbuelaPaternaCausaDeMuerte = "4"
            NecesitaPunto = False
        End If
        If radAbuelaPaterna05.Checked = True Then
            ANT += " Muerte debida a neumopatia."
            AF.AbuelaPaternaCausaDeMuerte = "5"
            NecesitaPunto = False
        End If
        If radAbuelaPaterna06.Checked = True Then
            ANT += " Muerte debida a cáncer."
            AF.AbuelaPaternaCausaDeMuerte = "6"
            NecesitaPunto = False
        End If
        If radAbuelaPaterna07.Checked = True Then
            ANT += " Muerte debida a desequilibrio metabólico."
            AF.AbuelaPaternaCausaDeMuerte = "7"
            NecesitaPunto = False
        End If
        If radAbuelaPaterna08.Checked = True Then
            ANT += " Muerte debida a causas naturales."
            AF.AbuelaPaternaCausaDeMuerte = "8"
            NecesitaPunto = False
        End If
        If radAbuelaPaternaDesconoceCausa.Checked = True Then
            ANT += " Desconoce la causa de muerte."
            AF.AbuelaPaternaCausaDeMuerte = "9"
            NecesitaPunto = False
        End If
        If radAbuelaPaternaOtrasCausas.Checked = True Then
            If txtAbuelaPaternaOtrasCausas.Text = "" Then
                'caja de texto vacia se toma como que desconoce
                ANT += " Desconoce la causa de muerte."
                AF.AbuelaPaternaCausaDeMuerte = "9"
                NecesitaPunto = False
            Else
                'se puso algo en el texto
                ANT += " Muerte debida a " & txtAbuelaPaternaOtrasCausas.Text.ToLower
                AF.AbuelaPaternaCausaDeMuerte = "10"
                AF.AbuelaPaternaOtrasCausasMuerte = txtAbuelaPaternaOtrasCausas.Text.ToLower
                NecesitaPunto = True
            End If
        End If

        If radAbuelaPaternaDesconoce.Checked = True Then
            ANT += "Desconoce datos de su Abuela paterna."
            AF.AbuelaPaternaVivaMuertaDesconoce = "3"
            NadaEnElParrafo = False
            NecesitaPunto = False
        End If

        'revisa si hace falta punto
        If NecesitaPunto = True Then
            ANT += "."
        End If

        'pasa el parrafo si se escribio algo
        If NadaEnElParrafo = False Then
            ANT += "  "
        End If
    End Sub
    Private Sub ConstruyeDialogoAbueloPaterno()
        'PARTE DEL Abuelo Paterno

        Dim HastaAhoraNada As Boolean
        Dim NecesitaPunto As Boolean
        Dim NadaEnElParrafo As Boolean
        'Dim SeEscribioAlgo As Boolean

        'inicializa bandera
        NadaEnElParrafo = True
        NecesitaPunto = False

        If radAbueloPaternoViva.Checked = True Then
            ANT += "Abuelo paterno vivo"
            AF.AbuelopaternoVivaMuertaDesconoce = "1"
            NadaEnElParrafo = False
            NecesitaPunto = True
        End If

        If radAbueloPaternoMuerta.Checked = True Then
            ANT += "Abuelo paterno falleció"
            AF.AbuelopaternoVivaMuertaDesconoce = "2"
            NadaEnElParrafo = False
            NecesitaPunto = True
        End If



        If radAbueloPaternoNiega.Checked = True Then
            ANT += ", niega antecedentes patológicos."
            AF.AbuelopaternoNiegaTieneDesconoceAnt = "1"
            NecesitaPunto = False
        ElseIf radAbueloPaternoDesconocePatologia.Checked = True Then
            ANT += ", desconoce antecedentes patológicos."
            AF.AbuelopaternoNiegaTieneDesconoceAnt = "3"
            NecesitaPunto = False
        ElseIf radAbueloPaternoTieneAnt.Checked = True Then
            AF.AbuelopaternoNiegaTieneDesconoceAnt = "2"

            HastaAhoraNada = True
            If chkAbueloPaterno01.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "HTA"
                AF.AbuelopaternoCHK01 = "1"
                NecesitaPunto = True
            Else
                AF.AbuelopaternoCHK01 = "0"
            End If
            If chkAbueloPaterno02.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "DM"
                NecesitaPunto = True
                AF.AbuelopaternoCHK02 = "1"
            Else
                AF.AbuelopaternoCHK02 = "0"
            End If
            If chkAbueloPaterno03.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "TBC"
                NecesitaPunto = True
                AF.AbuelopaternoCHK03 = "1"
            Else
                AF.AbuelopaternoCHK03 = "0"
            End If
            If chkAbueloPaterno04.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "cardiopatía"
                NecesitaPunto = True
                AF.AbuelopaternoCHK04 = "1"
            Else
                AF.AbuelopaternoCHK04 = "0"
            End If
            If chkAbueloPaterno05.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "epilepsia"
                NecesitaPunto = True
                AF.AbuelopaternoCHK05 = "1"
            Else
                AF.AbuelopaternoCHK05 = "0"
            End If
            If chkAbueloPaterno06.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "nefropatía"
                NecesitaPunto = True
                AF.AbuelopaternoCHK06 = "1"
            Else
                AF.AbuelopaternoCHK06 = "0"
            End If
            If chkAbueloPaterno07.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "CA"
                NecesitaPunto = True
                AF.AbuelopaternoCHK07 = "1"
            Else
                AF.AbuelopaternoCHK07 = "0"
            End If
            If chkAbueloPaternoOtros.Checked = True And txtAbueloPaternoOtrosAnt.Text <> "" Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += txtAbueloPaternoOtrosAnt.Text.ToLower
                'ojo el text otro debe salir sin punto al final
                NecesitaPunto = True
                AF.AbuelopaternoCHK08 = "1"
                AF.AbuelopaternoOtrosAntecedentes = txtAbueloPaternoOtrosAnt.Text.ToLower
            Else
                AF.AbuelopaternoCHK08 = "0"
                AF.AbuelopaternoOtrosAntecedentes = ""
            End If
        Else
            'no esta presionado ningun rad porq desconoce todo
            'borra todo de los antecedentes y no dice ni pio
            AF.AbuelopaternoNiegaTieneDesconoceAnt = "0"
            AF.AbuelopaternoCHK01 = "0"
            AF.AbuelopaternoCHK02 = "0"
            AF.AbuelopaternoCHK03 = "0"
            AF.AbuelopaternoCHK04 = "0"
            AF.AbuelopaternoCHK05 = "0"
            AF.AbuelopaternoCHK06 = "0"
            AF.AbuelopaternoCHK07 = "0"
            AF.AbuelopaternoCHK08 = "0"
            AF.AbuelopaternoOtrosAntecedentes = ""
        End If

        'verifica si se necesita punto para el siguiente parrafo
        If NecesitaPunto = True Then
            ANT += "."
            NecesitaPunto = False
        End If

        'AbueloPaterno causas de muerte
        If radAbueloPaterno01.Checked = True Then
            ANT += " Muerte debida a cardiopatía."
            AF.AbuelopaternoCausaDeMuerte = "1"
            NecesitaPunto = False
        End If
        If radAbueloPaterno02.Checked = True Then
            ANT += " Muerte debida a neuropatía."
            AF.AbuelopaternoCausaDeMuerte = "2"
            NecesitaPunto = False
        End If
        If radAbueloPaterno03.Checked = True Then
            ANT += " Muerte debida a nefropatía."
            AF.AbuelopaternoCausaDeMuerte = "3"
            NecesitaPunto = False
        End If
        If radAbueloPaterno04.Checked = True Then
            ANT += " Muerte debida a hepatopatía."
            AF.AbuelopaternoCausaDeMuerte = "4"
            NecesitaPunto = False
        End If
        If radAbueloPaterno05.Checked = True Then
            ANT += " Muerte debida a neumopatia."
            AF.AbuelopaternoCausaDeMuerte = "5"
            NecesitaPunto = False
        End If
        If radAbueloPaterno06.Checked = True Then
            ANT += " Muerte debida a cáncer."
            AF.AbuelopaternoCausaDeMuerte = "6"
            NecesitaPunto = False
        End If
        If radAbueloPaterno07.Checked = True Then
            ANT += " Muerte debida a desequilibrio metabólico."
            AF.AbuelopaternoCausaDeMuerte = "7"
            NecesitaPunto = False
        End If
        If radAbueloPaterno08.Checked = True Then
            ANT += " Muerte debida a causas naturales."
            AF.AbuelopaternoCausaDeMuerte = "8"
            NecesitaPunto = False
        End If
        If radAbueloPaternoDesconoceCausa.Checked = True Then
            ANT += " Desconoce la causa de muerte."
            AF.AbuelopaternoCausaDeMuerte = "9"
            NecesitaPunto = False
        End If
        If radAbueloPaternoOtrasCausas.Checked = True Then
            If txtAbueloPaternoOtrasCausas.Text = "" Then
                'caja de texto vacia se toma como que desconoce
                ANT += " Desconoce la causa de muerte."
                AF.AbuelopaternoCausaDeMuerte = "9"
                NecesitaPunto = False
            Else
                'se puso algo en el texto
                ANT += " Muerte debida a " & txtAbueloPaternoOtrasCausas.Text.ToLower
                AF.AbuelopaternoCausaDeMuerte = "10"
                AF.AbuelopaternoOtrasCausasMuerte = txtAbueloPaternoOtrasCausas.Text.ToLower
                NecesitaPunto = True
            End If
        End If

        If radAbueloPaternoDesconoce.Checked = True Then
            ANT += "Desconoce datos de su Abuelo paterno."
            AF.AbuelopaternoVivaMuertaDesconoce = "3"
            NadaEnElParrafo = False
            NecesitaPunto = False
        End If

        'revisa si hace falta punto
        If NecesitaPunto = True Then
            ANT += "."
        End If

        'pasa el parrafo si se escribio algo
        If NadaEnElParrafo = False Then
            ANT += "  "
        End If
    End Sub
    Private Sub ConstruyeDialogoAbuelaMaterna()
        Dim HastaAhoraNada As Boolean
        Dim NecesitaPunto As Boolean
        Dim NadaEnElParrafo As Boolean
        'Dim SeEscribioAlgo As Boolean

        'inicializa bandera
        NadaEnElParrafo = True
        NecesitaPunto = False

        If radAbuelaMaternaViva.Checked = True Then
            ANT += "Abuela materna viva"
            AF.AbuelaMaternaVivaMuertaDesconoce = "1"
            NadaEnElParrafo = False
            NecesitaPunto = True
        End If

        If radAbuelaMaternaMuerta.Checked = True Then
            ANT += "Abuela materna falleció"
            AF.AbuelaMaternaVivaMuertaDesconoce = "2"
            NadaEnElParrafo = False
            NecesitaPunto = True
        End If



        If radAbuelaMaternaNiega.Checked = True Then
            ANT += ", niega antecedentes patológicos."
            AF.AbuelaMaternaNiegaTieneDesconoceAnt = "1"
            NecesitaPunto = False
        ElseIf radAbuelaMaternaDesconocePatologia.Checked = True Then
            ANT += ", desconoce antecedentes patológicos."
            AF.AbuelaMaternaNiegaTieneDesconoceAnt = "3"
            NecesitaPunto = False
        ElseIf radAbuelaMaternaTieneAnt.Checked = True Then
            AF.AbuelaMaternaNiegaTieneDesconoceAnt = "2"

            HastaAhoraNada = True
            If chkAbuelaMaterna01.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "HTA"
                AF.AbuelaMaternaCHK01 = "1"
                NecesitaPunto = True
            Else
                AF.AbuelaMaternaCHK01 = "0"
            End If
            If chkAbuelaMaterna02.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "DM"
                NecesitaPunto = True
                AF.AbuelaMaternaCHK02 = "1"
            Else
                AF.AbuelaMaternaCHK02 = "0"
            End If
            If chkAbuelaMaterna03.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "TBC"
                NecesitaPunto = True
                AF.AbuelaMaternaCHK03 = "1"
            Else
                AF.AbuelaMaternaCHK03 = "0"
            End If
            If chkAbuelaMaterna04.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "cardiopatía"
                NecesitaPunto = True
                AF.AbuelaMaternaCHK04 = "1"
            Else
                AF.AbuelaMaternaCHK04 = "0"
            End If
            If chkAbuelaMaterna05.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "epilepsia"
                NecesitaPunto = True
                AF.AbuelaMaternaCHK05 = "1"
            Else
                AF.AbuelaMaternaCHK05 = "0"
            End If
            If chkAbuelaMaterna06.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "nefropatía"
                NecesitaPunto = True
                AF.AbuelaMaternaCHK06 = "1"
            Else
                AF.AbuelaMaternaCHK06 = "0"
            End If
            If chkAbuelaMaterna07.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "CA"
                NecesitaPunto = True
                AF.AbuelaMaternaCHK07 = "1"
            Else
                AF.AbuelaMaternaCHK07 = "0"
            End If
            If chkAbuelaMaternaOtros.Checked = True And txtAbuelaMaternaOtrosAnt.Text <> "" Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += txtAbuelaMaternaOtrosAnt.Text.ToLower
                'ojo el text otro debe salir sin punto al final
                NecesitaPunto = True
                AF.AbuelaMaternaCHK08 = "1"
                AF.AbuelaMaternaOtrosAntecedentes = txtAbuelaMaternaOtrosAnt.Text.ToLower
            Else
                AF.AbuelaMaternaCHK08 = "0"
                AF.AbuelaMaternaOtrosAntecedentes = ""
            End If
        Else
            'no esta presionado ningun rad porq desconoce todo
            'borra todo de los antecedentes y no dice ni pio
            AF.AbuelaMaternaNiegaTieneDesconoceAnt = "0"
            AF.AbuelaMaternaCHK01 = "0"
            AF.AbuelaMaternaCHK02 = "0"
            AF.AbuelaMaternaCHK03 = "0"
            AF.AbuelaMaternaCHK04 = "0"
            AF.AbuelaMaternaCHK05 = "0"
            AF.AbuelaMaternaCHK06 = "0"
            AF.AbuelaMaternaCHK07 = "0"
            AF.AbuelaMaternaCHK08 = "0"
            AF.AbuelaMaternaOtrosAntecedentes = ""
        End If

        'verifica si se necesita punto para el siguiente parrafo
        If NecesitaPunto = True Then
            ANT += "."
            NecesitaPunto = False
        End If

        'AbuelaMaterna causas de muerte
        If radAbuelaMaterna01.Checked = True Then
            ANT += " Muerte debida a cardiopatía."
            AF.AbuelaMaternaCausaDeMuerte = "1"
            NecesitaPunto = False
        End If
        If radAbuelaMaterna02.Checked = True Then
            ANT += " Muerte debida a neuropatía."
            AF.AbuelaMaternaCausaDeMuerte = "2"
            NecesitaPunto = False
        End If
        If radAbuelaMaterna03.Checked = True Then
            ANT += " Muerte debida a nefropatía."
            AF.AbuelaMaternaCausaDeMuerte = "3"
            NecesitaPunto = False
        End If
        If radAbuelaMaterna04.Checked = True Then
            ANT += " Muerte debida a hepatopatía."
            AF.AbuelaMaternaCausaDeMuerte = "4"
            NecesitaPunto = False
        End If
        If radAbuelaMaterna05.Checked = True Then
            ANT += " Muerte debida a neumopatia."
            AF.AbuelaMaternaCausaDeMuerte = "5"
            NecesitaPunto = False
        End If
        If radAbuelaMaterna06.Checked = True Then
            ANT += " Muerte debida a cáncer."
            AF.AbuelaMaternaCausaDeMuerte = "6"
            NecesitaPunto = False
        End If
        If radAbuelaMaterna07.Checked = True Then
            ANT += " Muerte debida a desequilibrio metabólico."
            AF.AbuelaMaternaCausaDeMuerte = "7"
            NecesitaPunto = False
        End If
        If radAbuelaMaterna08.Checked = True Then
            ANT += " Muerte debida a causas naturales."
            AF.AbuelaMaternaCausaDeMuerte = "8"
            NecesitaPunto = False
        End If
        If radAbuelaMaternaDesconoceCausa.Checked = True Then
            ANT += " Desconoce la causa de muerte."
            AF.AbuelaMaternaCausaDeMuerte = "9"
            NecesitaPunto = False
        End If
        If radAbuelaMaternaOtrasCausas.Checked = True Then
            If txtAbuelaMaternaOtrasCausas.Text = "" Then
                'caja de texto vacia se toma como que desconoce
                ANT += " Desconoce la causa de muerte."
                AF.AbuelaMaternaCausaDeMuerte = "9"
                NecesitaPunto = False
            Else
                'se puso algo en el texto
                ANT += " Muerte debida a " & txtAbuelaMaternaOtrasCausas.Text.ToLower
                AF.AbuelaMaternaCausaDeMuerte = "10"
                AF.AbuelaMaternaOtrasCausasMuerte = txtAbuelaMaternaOtrasCausas.Text.ToLower
                NecesitaPunto = True
            End If
        End If

        If radAbuelaMaternaDesconoce.Checked = True Then
            ANT += "Desconoce datos de su Abuela materna."
            AF.AbuelaMaternaVivaMuertaDesconoce = "3"
            NadaEnElParrafo = False
            NecesitaPunto = False
        End If

        'revisa si hace falta punto
        If NecesitaPunto = True Then
            ANT += "."
        End If

        'pasa el parrafo si se escribio algo
        If NadaEnElParrafo = False Then
            ANT += "  "
        End If
    End Sub
    Private Sub ConstruyeDialogoAbueloMaterno()
        'PARTE DEL Abuelo Materno

        Dim HastaAhoraNada As Boolean
        Dim NecesitaPunto As Boolean
        Dim NadaEnElParrafo As Boolean
        'Dim SeEscribioAlgo As Boolean

        'inicializa bandera
        NadaEnElParrafo = True
        NecesitaPunto = False

        If radAbueloMaternoViva.Checked = True Then
            ANT += "Abuelo materno vivo"
            AF.AbueloMaternoVivaMuertaDesconoce = "1"
            NadaEnElParrafo = False
            NecesitaPunto = True
        End If

        If radAbueloMaternoMuerta.Checked = True Then
            ANT += "Abuelo materno falleció"
            AF.AbueloMaternoVivaMuertaDesconoce = "2"
            NadaEnElParrafo = False
            NecesitaPunto = True
        End If



        If radAbueloMaternoNiega.Checked = True Then
            ANT += ", niega antecedentes patológicos."
            AF.AbueloMaternoNiegaTieneDesconoceAnt = "1"
            NecesitaPunto = False
        ElseIf radAbueloMaternoDesconocePatologia.Checked = True Then
            ANT += ", desconoce antecedentes patológicos."
            AF.AbueloMaternoNiegaTieneDesconoceAnt = "3"
            NecesitaPunto = False
        ElseIf radAbueloMaternoTieneAnt.Checked = True Then
            AF.AbueloMaternoNiegaTieneDesconoceAnt = "2"

            HastaAhoraNada = True
            If chkAbueloMaterno01.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "HTA"
                AF.AbueloMaternoCHK01 = "1"
                NecesitaPunto = True
            Else
                AF.AbueloMaternoCHK01 = "0"
            End If
            If chkAbueloMaterno02.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "DM"
                NecesitaPunto = True
                AF.AbueloMaternoCHK02 = "1"
            Else
                AF.AbueloMaternoCHK02 = "0"
            End If
            If chkAbueloMaterno03.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "TBC"
                NecesitaPunto = True
                AF.AbueloMaternoCHK03 = "1"
            Else
                AF.AbueloMaternoCHK03 = "0"
            End If
            If chkAbueloMaterno04.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "cardiopatía"
                NecesitaPunto = True
                AF.AbueloMaternoCHK04 = "1"
            Else
                AF.AbueloMaternoCHK04 = "0"
            End If
            If chkAbueloMaterno05.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "epilepsia"
                NecesitaPunto = True
                AF.AbueloMaternoCHK05 = "1"
            Else
                AF.AbueloMaternoCHK05 = "0"
            End If
            If chkAbueloMaterno06.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "nefropatía"
                NecesitaPunto = True
                AF.AbueloMaternoCHK06 = "1"
            Else
                AF.AbueloMaternoCHK06 = "0"
            End If
            If chkAbueloMaterno07.Checked = True Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += "CA"
                NecesitaPunto = True
                AF.AbueloMaternoCHK07 = "1"
            Else
                AF.AbueloMaternoCHK07 = "0"
            End If
            If chkAbueloMaternoOtros.Checked = True And txtAbueloMaternoOtrosAnt.Text <> "" Then
                If HastaAhoraNada = True Then
                    ANT += ", antecedentes de "
                    HastaAhoraNada = False
                Else
                    ANT += ", "
                End If
                ANT += txtAbueloMaternoOtrosAnt.Text.ToLower
                'ojo el text otro debe salir sin punto al final
                NecesitaPunto = True
                AF.AbueloMaternoCHK08 = "1"
                AF.AbueloMaternoOtrosAntecedentes = txtAbueloMaternoOtrosAnt.Text.ToLower
            Else
                AF.AbueloMaternoCHK08 = "0"
                AF.AbueloMaternoOtrosAntecedentes = ""
            End If
        Else
            'no esta presionado ningun rad porq desconoce todo
            'borra todo de los antecedentes y no dice ni pio
            AF.AbueloMaternoNiegaTieneDesconoceAnt = "0"
            AF.AbueloMaternoCHK01 = "0"
            AF.AbueloMaternoCHK02 = "0"
            AF.AbueloMaternoCHK03 = "0"
            AF.AbueloMaternoCHK04 = "0"
            AF.AbueloMaternoCHK05 = "0"
            AF.AbueloMaternoCHK06 = "0"
            AF.AbueloMaternoCHK07 = "0"
            AF.AbueloMaternoCHK08 = "0"
            AF.AbueloMaternoOtrosAntecedentes = ""
        End If

        'verifica si se necesita punto para el siguiente parrafo
        If NecesitaPunto = True Then
            ANT += "."
            NecesitaPunto = False
        End If

        'AbueloMaterno causas de muerte
        If radAbueloMaterno01.Checked = True Then
            ANT += " Muerte debida a cardiopatía."
            AF.AbueloMaternoCausaDeMuerte = "1"
            NecesitaPunto = False
        End If
        If radAbueloMaterno02.Checked = True Then
            ANT += " Muerte debida a neuropatía."
            AF.AbueloMaternoCausaDeMuerte = "2"
            NecesitaPunto = False
        End If
        If radAbueloMaterno03.Checked = True Then
            ANT += " Muerte debida a nefropatía."
            AF.AbueloMaternoCausaDeMuerte = "3"
            NecesitaPunto = False
        End If
        If radAbueloMaterno04.Checked = True Then
            ANT += " Muerte debida a hepatopatía."
            AF.AbueloMaternoCausaDeMuerte = "4"
            NecesitaPunto = False
        End If
        If radAbueloMaterno05.Checked = True Then
            ANT += " Muerte debida a neumopatia."
            AF.AbueloMaternoCausaDeMuerte = "5"
            NecesitaPunto = False
        End If
        If radAbueloMaterno06.Checked = True Then
            ANT += " Muerte debida a cáncer."
            AF.AbueloMaternoCausaDeMuerte = "6"
            NecesitaPunto = False
        End If
        If radAbueloMaterno07.Checked = True Then
            ANT += " Muerte debida a desequilibrio metabólico."
            AF.AbueloMaternoCausaDeMuerte = "7"
            NecesitaPunto = False
        End If
        If radAbueloMaterno08.Checked = True Then
            ANT += " Muerte debida a causas naturales."
            AF.AbueloMaternoCausaDeMuerte = "8"
            NecesitaPunto = False
        End If
        If radAbueloMaternoDesconoceCausa.Checked = True Then
            ANT += " Desconoce la causa de muerte."
            AF.AbueloMaternoCausaDeMuerte = "9"
            NecesitaPunto = False
        End If
        If radAbueloMaternoOtrasCausas.Checked = True Then
            If txtAbueloMaternoOtrasCausas.Text = "" Then
                'caja de texto vacia se toma como que desconoce
                ANT += " Desconoce la causa de muerte."
                AF.AbueloMaternoCausaDeMuerte = "9"
                NecesitaPunto = False
            Else
                'se puso algo en el texto
                ANT += " Muerte debida a " & txtAbueloMaternoOtrasCausas.Text.ToLower
                AF.AbueloMaternoCausaDeMuerte = "10"
                AF.AbueloMaternoOtrasCausasMuerte = txtAbueloMaternoOtrasCausas.Text.ToLower
                NecesitaPunto = True
            End If
        End If

        If radAbueloMaternoDesconoce.Checked = True Then
            ANT += "Desconoce datos de su Abuelo materno."
            AF.AbueloMaternoVivaMuertaDesconoce = "3"
            NadaEnElParrafo = False
            NecesitaPunto = False
        End If

        'revisa si hace falta punto
        If NecesitaPunto = True Then
            ANT += "."
        End If

        'pasa el parrafo si se escribio algo
        If NadaEnElParrafo = False Then
            ANT += "  "
        End If
    End Sub
    Private Sub ConstruyeDialogoHermanos()
        'hermanos
        '000000000000000000

        Dim HastaAhoraNada As Boolean
        'Dim NecesitaPunto As Boolean
        'Dim NadaEnElParrafo As Boolean
        Dim SeEscribioAlgo As Boolean

        SeEscribioAlgo = False

        'PARTE DE Los hermanos
        HastaAhoraNada = True
        If chkHermanos01.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "HTA"
            AF.HermanosCHK01 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosCHK01 = "0"
        End If
        If chkHermanos02.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "DM"
            AF.HermanosCHK02 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosCHK02 = "0"
        End If
        If chkHermanos03.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "TBC"
            AF.HermanosCHK03 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosCHK03 = "0"
        End If
        If chkHermanos04.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "cardiopatía"
            AF.HermanosCHK04 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosCHK04 = "0"
        End If
        If chkHermanos05.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "epilepsia"
            AF.HermanosCHK05 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosCHK05 = "0"
        End If
        If chkHermanos06.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "nefropatía"
            AF.HermanosCHK06 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosCHK06 = "0"
        End If
        If chkHermanos07.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "CA"
            AF.HermanosCHK07 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosCHK07 = "0"
        End If
        If chkHermanos08.Checked = True And txtHermanosOtrosAnt.Text <> "" Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += txtHermanosOtrosAnt.Text.ToLower
            AF.HermanosCHK08 = "1"
            AF.HermanosOtrosAntecedentes = txtHermanosOtrosAnt.Text.ToLower
            SeEscribioAlgo = True
        Else
            AF.HermanosCHK08 = "0"
            AF.HermanosOtrosAntecedentes = ""
        End If

        If SeEscribioAlgo = True Then
            'pone el punto despues del primer parrafo
            ANT += "." & vbCrLf
            SeEscribioAlgo = False
        End If

        'Hermanos causas de muerte
        HastaAhoraNada = True
        If chkHermanosMuertos01.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " cardiopatía"
            AF.HermanosMuertosCHK01 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosMuertosCHK01 = "0"
        End If

        If chkHermanosMuertos02.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " neuropatía"
            AF.HermanosMuertosCHK02 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosMuertosCHK02 = "0"
        End If

        If chkHermanosMuertos03.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " nefropatía"
            AF.HermanosMuertosCHK03 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosMuertosCHK03 = "0"
        End If

        If chkHermanosMuertos04.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " hepatopatía"
            AF.HermanosMuertosCHK04 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosMuertosCHK04 = "0"
        End If

        If chkHermanosMuertos05.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " neumopatía"
            AF.HermanosMuertosCHK05 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosMuertosCHK05 = "0"
        End If

        If chkHermanosMuertos06.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " cáncer"
            AF.HermanosMuertosCHK06 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosMuertosCHK06 = "0"
        End If

        If chkHermanosMuertos07.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " desequilibrio metabolíco"
            AF.HermanosMuertosCHK07 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosMuertosCHK07 = "0"
        End If

        If chkHermanosMuertos08.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " causas naturales"
            AF.HermanosMuertosCHK08 = "1"
            SeEscribioAlgo = True
        Else
            AF.HermanosMuertosCHK08 = "0"
        End If

        If chkHermanosMuertos09.Checked = True And txtHermanosMuertosOtrasCausas.Text <> "" Then
            If HastaAhoraNada = True Then
                ANT += "Refiere hermanos fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += txtHermanosMuertosOtrasCausas.Text.ToLower
            AF.HermanosMuertosCHK09 = "1"
            AF.HermanosOtrasCausasMuerte = txtHermanosMuertosOtrasCausas.Text.ToLower
            SeEscribioAlgo = True
        Else
            AF.HermanosMuertosCHK09 = "0"
            AF.HermanosOtrasCausasMuerte = ""

        End If

        If SeEscribioAlgo = True Then
            ANT += "." & "  "
        End If

    End Sub
    Private Sub ConstruyeDialogoTios()
        'PARTE DE Los tios
        Dim HastaAhoraNada As Boolean
        'Dim NecesitaPunto As Boolean
        'Dim NadaEnElParrafo As Boolean
        Dim SeEscribioAlgo As Boolean

        '00000000000000000
        SeEscribioAlgo = False

        HastaAhoraNada = True
        If chkTios01.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "HTA"
            AF.tiosCHK01 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosCHK01 = "0"
        End If
        If chkTios02.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "DM"
            AF.tiosCHK02 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosCHK02 = "0"
        End If
        If chkTios03.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "TBC"
            AF.tiosCHK03 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosCHK03 = "0"
        End If
        If chkTios04.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "cardiopatía"
            AF.tiosCHK04 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosCHK04 = "0"
        End If
        If chkTios05.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "epilepsia"
            AF.tiosCHK05 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosCHK05 = "0"
        End If
        If chkTios06.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "nefropatía"
            AF.tiosCHK06 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosCHK06 = "0"
        End If
        If chkTios07.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += "CA"
            AF.tiosCHK07 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosCHK07 = "0"
        End If
        If chkTios08.Checked = True And txtTiosOtrosAnt.Text <> "" Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios con antecedentes de "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += txtTiosOtrosAnt.Text.ToLower
            AF.tiosCHK08 = "1"
            AF.tiosOtrosAntecedentes = txtTiosOtrosAnt.Text.ToLower
            SeEscribioAlgo = True
        Else
            AF.tiosCHK08 = "0"
            AF.tiosOtrosAntecedentes = ""
        End If

        If SeEscribioAlgo = True Then
            'pone el punto despues del primer parrafo
            ANT += "." & " "
            SeEscribioAlgo = False
        End If

        'tios causas de muerte
        HastaAhoraNada = True
        If chkTiosMuertos01.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " cardiopatía"
            AF.tiosMuertosCHK01 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosMuertosCHK01 = "0"
        End If

        If chkTiosMuertos02.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " neuropatía"
            AF.tiosMuertosCHK02 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosMuertosCHK02 = "0"
        End If

        If chkTiosMuertos03.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " nefropatía"
            AF.tiosMuertosCHK03 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosMuertosCHK03 = "0"
        End If

        If chkTiosMuertos04.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " hepatopatía"
            AF.tiosMuertosCHK04 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosMuertosCHK04 = "0"
        End If

        If chkTiosMuertos05.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " neumopatía"
            AF.tiosMuertosCHK05 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosMuertosCHK05 = "0"
        End If

        If chkTiosMuertos06.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " cáncer"
            AF.tiosMuertosCHK06 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosMuertosCHK06 = "0"
        End If

        If chkTiosMuertos07.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " desequilibrio metabolíco"
            AF.tiosMuertosCHK07 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosMuertosCHK07 = "0"
        End If

        If chkTiosMuertos08.Checked = True Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += " causas naturales"
            AF.tiosMuertosCHK08 = "1"
            SeEscribioAlgo = True
        Else
            AF.tiosMuertosCHK08 = "0"
        End If

        If chkTiosMuertos09.Checked = True And txtTiosMuertosOtrasCausas.Text <> "" Then
            If HastaAhoraNada = True Then
                ANT += "Refiere tios fallecidos por "
                HastaAhoraNada = False
            Else
                ANT += ", "
            End If
            ANT += txtTiosMuertosOtrasCausas.Text.ToLower
            AF.tiosMuertosCHK09 = "1"
            AF.tiosOtrasCausasMuerte = txtTiosMuertosOtrasCausas.Text.ToLower
            SeEscribioAlgo = True
        Else
            AF.tiosMuertosCHK09 = "0"
            AF.tiosOtrasCausasMuerte = ""
        End If

        If SeEscribioAlgo = True Then
            ANT += "." & " "
        End If

    End Sub
    Private Sub ConstruyeDialogoOtros()
        'Otros familiares
        If txtOtrosFamiliares.Text <> "" Then
            ANT += txtOtrosFamiliares.Text & "." & " "
            AF.OtrosFamiliares = txtOtrosFamiliares.Text
        Else
            AF.OtrosFamiliares = ""
        End If
    End Sub

    Private Sub CreaAntecedentesFamiliares()

        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(fileAntFamiliares, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)

        'ahora lo escribe

        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        'MADRE
        BW.Write(AF.MadreVivaMuertaDesconoce)
        BW.Write(AF.MadreNiegaTieneDesconoceAnt)
        BW.Write(AF.MadreCHK01)
        BW.Write(AF.MadreCHK02)
        BW.Write(AF.MadreCHK03)
        BW.Write(AF.MadreCHK04)
        BW.Write(AF.MadreCHK05)
        BW.Write(AF.MadreCHK06)
        BW.Write(AF.MadreCHK07)
        BW.Write(AF.MadreCHK08)
        BW.Write(AF.MadreOtrosAntecedentes)
        BW.Write(AF.MadreCausaDeMuerte)
        BW.Write(AF.MadreOtrasCausasMuerte)
        'Padre
        BW.Write(AF.PadreVivaMuertaDesconoce)
        BW.Write(AF.PadreNiegaTieneDesconoceAnt)
        BW.Write(AF.PadreCHK01)
        BW.Write(AF.PadreCHK02)
        BW.Write(AF.PadreCHK03)
        BW.Write(AF.PadreCHK04)
        BW.Write(AF.PadreCHK05)
        BW.Write(AF.PadreCHK06)
        BW.Write(AF.PadreCHK07)
        BW.Write(AF.PadreCHK08)
        BW.Write(AF.PadreOtrosAntecedentes)
        BW.Write(AF.PadreCausaDeMuerte)
        BW.Write(AF.PadreOtrasCausasMuerte)

        'AbuelaPaterna
        BW.Write(AF.AbuelaPaternaVivaMuertaDesconoce)
        BW.Write(AF.AbuelaPaternaNiegaTieneDesconoceAnt)
        BW.Write(AF.AbuelaPaternaCHK01)
        BW.Write(AF.AbuelaPaternaCHK02)
        BW.Write(AF.AbuelaPaternaCHK03)
        BW.Write(AF.AbuelaPaternaCHK04)
        BW.Write(AF.AbuelaPaternaCHK05)
        BW.Write(AF.AbuelaPaternaCHK06)
        BW.Write(AF.AbuelaPaternaCHK07)
        BW.Write(AF.AbuelaPaternaCHK08)
        BW.Write(AF.AbuelaPaternaOtrosAntecedentes)
        BW.Write(AF.AbuelaPaternaCausaDeMuerte)
        BW.Write(AF.AbuelaPaternaOtrasCausasMuerte)

        'AbueloPaterno
        BW.Write(AF.AbuelopaternoVivaMuertaDesconoce)
        BW.Write(AF.AbuelopaternoNiegaTieneDesconoceAnt)
        BW.Write(AF.AbuelopaternoCHK01)
        BW.Write(AF.AbuelopaternoCHK02)
        BW.Write(AF.AbuelopaternoCHK03)
        BW.Write(AF.AbuelopaternoCHK04)
        BW.Write(AF.AbuelopaternoCHK05)
        BW.Write(AF.AbuelopaternoCHK06)
        BW.Write(AF.AbuelopaternoCHK07)
        BW.Write(AF.AbuelopaternoCHK08)
        BW.Write(AF.AbuelopaternoOtrosAntecedentes)
        BW.Write(AF.AbuelopaternoCausaDeMuerte)
        BW.Write(AF.AbuelopaternoOtrasCausasMuerte)

        'AbuelaMaterna
        BW.Write(AF.AbuelaMaternaVivaMuertaDesconoce)
        BW.Write(AF.AbuelaMaternaNiegaTieneDesconoceAnt)
        BW.Write(AF.AbuelaMaternaCHK01)
        BW.Write(AF.AbuelaMaternaCHK02)
        BW.Write(AF.AbuelaMaternaCHK03)
        BW.Write(AF.AbuelaMaternaCHK04)
        BW.Write(AF.AbuelaMaternaCHK05)
        BW.Write(AF.AbuelaMaternaCHK06)
        BW.Write(AF.AbuelaMaternaCHK07)
        BW.Write(AF.AbuelaMaternaCHK08)
        BW.Write(AF.AbuelaMaternaOtrosAntecedentes)
        BW.Write(AF.AbuelaMaternaCausaDeMuerte)
        BW.Write(AF.AbuelaMaternaOtrasCausasMuerte)

        'AbueloMaterno
        BW.Write(AF.AbueloMaternoVivaMuertaDesconoce)
        BW.Write(AF.AbueloMaternoNiegaTieneDesconoceAnt)
        BW.Write(AF.AbueloMaternoCHK01)
        BW.Write(AF.AbueloMaternoCHK02)
        BW.Write(AF.AbueloMaternoCHK03)
        BW.Write(AF.AbueloMaternoCHK04)
        BW.Write(AF.AbueloMaternoCHK05)
        BW.Write(AF.AbueloMaternoCHK06)
        BW.Write(AF.AbueloMaternoCHK07)
        BW.Write(AF.AbueloMaternoCHK08)
        BW.Write(AF.AbueloMaternoOtrosAntecedentes)
        BW.Write(AF.AbueloMaternoCausaDeMuerte)
        BW.Write(AF.AbueloMaternoOtrasCausasMuerte)
        'hermanos
        BW.Write(AF.HermanosCHK01)
        BW.Write(AF.HermanosCHK02)
        BW.Write(AF.HermanosCHK03)
        BW.Write(AF.HermanosCHK04)
        BW.Write(AF.HermanosCHK05)
        BW.Write(AF.HermanosCHK06)
        BW.Write(AF.HermanosCHK07)
        BW.Write(AF.HermanosCHK08)
        BW.Write(AF.HermanosOtrosAntecedentes)
        BW.Write(AF.HermanosMuertosCHK01)
        BW.Write(AF.HermanosMuertosCHK02)
        BW.Write(AF.HermanosMuertosCHK03)
        BW.Write(AF.HermanosMuertosCHK04)
        BW.Write(AF.HermanosMuertosCHK05)
        BW.Write(AF.HermanosMuertosCHK06)
        BW.Write(AF.HermanosMuertosCHK07)
        BW.Write(AF.HermanosMuertosCHK08)
        BW.Write(AF.HermanosMuertosCHK09)
        BW.Write(AF.HermanosOtrasCausasMuerte)
        'tios
        BW.Write(AF.tiosCHK01)
        BW.Write(AF.tiosCHK02)
        BW.Write(AF.tiosCHK03)
        BW.Write(AF.tiosCHK04)
        BW.Write(AF.tiosCHK05)
        BW.Write(AF.tiosCHK06)
        BW.Write(AF.tiosCHK07)
        BW.Write(AF.tiosCHK08)
        BW.Write(AF.tiosOtrosAntecedentes)
        BW.Write(AF.tiosMuertosCHK01)
        BW.Write(AF.tiosMuertosCHK02)
        BW.Write(AF.tiosMuertosCHK03)
        BW.Write(AF.tiosMuertosCHK04)
        BW.Write(AF.tiosMuertosCHK05)
        BW.Write(AF.tiosMuertosCHK06)
        BW.Write(AF.tiosMuertosCHK07)
        BW.Write(AF.tiosMuertosCHK08)
        BW.Write(AF.tiosMuertosCHK09)
        BW.Write(AF.tiosOtrasCausasMuerte)
        'otros familiares
        BW.Write(AF.OtrosFamiliares)

        BW.Close()
        FS.Close()
    End Sub

    Private Sub CargaAntecedentesFamiliares()
        Dim FS As FileStream
        Dim BR As BinaryReader

        FS = New FileStream(fileAntFamiliares, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim C As Integer
        C = BR.PeekChar
        While FS.Position < FS.Length
            AF = Nothing
            ' Read fields and populate structure
            'MADRE
            AF.MadreVivaMuertaDesconoce = BR.ReadString
            AF.MadreNiegaTieneDesconoceAnt = BR.ReadString
            AF.MadreCHK01 = BR.ReadString
            AF.MadreCHK02 = BR.ReadString
            AF.MadreCHK03 = BR.ReadString
            AF.MadreCHK04 = BR.ReadString
            AF.MadreCHK05 = BR.ReadString
            AF.MadreCHK06 = BR.ReadString
            AF.MadreCHK07 = BR.ReadString
            AF.MadreCHK08 = BR.ReadString
            AF.MadreOtrosAntecedentes = BR.ReadString
            AF.MadreCausaDeMuerte = BR.ReadString
            AF.MadreOtrasCausasMuerte = BR.ReadString
            'Padre
            AF.PadreVivaMuertaDesconoce = BR.ReadString
            AF.PadreNiegaTieneDesconoceAnt = BR.ReadString
            AF.PadreCHK01 = BR.ReadString
            AF.PadreCHK02 = BR.ReadString
            AF.PadreCHK03 = BR.ReadString
            AF.PadreCHK04 = BR.ReadString
            AF.PadreCHK05 = BR.ReadString
            AF.PadreCHK06 = BR.ReadString
            AF.PadreCHK07 = BR.ReadString
            AF.PadreCHK08 = BR.ReadString
            AF.PadreOtrosAntecedentes = BR.ReadString
            AF.PadreCausaDeMuerte = BR.ReadString
            AF.PadreOtrasCausasMuerte = BR.ReadString
            'AbuelaPaterna
            AF.AbuelaPaternaVivaMuertaDesconoce = BR.ReadString
            AF.AbuelaPaternaNiegaTieneDesconoceAnt = BR.ReadString
            AF.AbuelaPaternaCHK01 = BR.ReadString
            AF.AbuelaPaternaCHK02 = BR.ReadString
            AF.AbuelaPaternaCHK03 = BR.ReadString
            AF.AbuelaPaternaCHK04 = BR.ReadString
            AF.AbuelaPaternaCHK05 = BR.ReadString
            AF.AbuelaPaternaCHK06 = BR.ReadString
            AF.AbuelaPaternaCHK07 = BR.ReadString
            AF.AbuelaPaternaCHK08 = BR.ReadString
            AF.AbuelaPaternaOtrosAntecedentes = BR.ReadString
            AF.AbuelaPaternaCausaDeMuerte = BR.ReadString
            AF.AbuelaPaternaOtrasCausasMuerte = BR.ReadString
            'AbueloPaterno
            AF.AbuelopaternoVivaMuertaDesconoce = BR.ReadString
            AF.AbuelopaternoNiegaTieneDesconoceAnt = BR.ReadString
            AF.AbuelopaternoCHK01 = BR.ReadString
            AF.AbuelopaternoCHK02 = BR.ReadString
            AF.AbuelopaternoCHK03 = BR.ReadString
            AF.AbuelopaternoCHK04 = BR.ReadString
            AF.AbuelopaternoCHK05 = BR.ReadString
            AF.AbuelopaternoCHK06 = BR.ReadString
            AF.AbuelopaternoCHK07 = BR.ReadString
            AF.AbuelopaternoCHK08 = BR.ReadString
            AF.AbuelopaternoOtrosAntecedentes = BR.ReadString
            AF.AbuelopaternoCausaDeMuerte = BR.ReadString
            AF.AbuelopaternoOtrasCausasMuerte = BR.ReadString
            'AbuelaMaterna
            AF.AbuelaMaternaVivaMuertaDesconoce = BR.ReadString
            AF.AbuelaMaternaNiegaTieneDesconoceAnt = BR.ReadString
            AF.AbuelaMaternaCHK01 = BR.ReadString
            AF.AbuelaMaternaCHK02 = BR.ReadString
            AF.AbuelaMaternaCHK03 = BR.ReadString
            AF.AbuelaMaternaCHK04 = BR.ReadString
            AF.AbuelaMaternaCHK05 = BR.ReadString
            AF.AbuelaMaternaCHK06 = BR.ReadString
            AF.AbuelaMaternaCHK07 = BR.ReadString
            AF.AbuelaMaternaCHK08 = BR.ReadString
            AF.AbuelaMaternaOtrosAntecedentes = BR.ReadString
            AF.AbuelaMaternaCausaDeMuerte = BR.ReadString
            AF.AbuelaMaternaOtrasCausasMuerte = BR.ReadString
            'AbueloMaterno
            AF.AbueloMaternoVivaMuertaDesconoce = BR.ReadString
            AF.AbueloMaternoNiegaTieneDesconoceAnt = BR.ReadString
            AF.AbueloMaternoCHK01 = BR.ReadString
            AF.AbueloMaternoCHK02 = BR.ReadString
            AF.AbueloMaternoCHK03 = BR.ReadString
            AF.AbueloMaternoCHK04 = BR.ReadString
            AF.AbueloMaternoCHK05 = BR.ReadString
            AF.AbueloMaternoCHK06 = BR.ReadString
            AF.AbueloMaternoCHK07 = BR.ReadString
            AF.AbueloMaternoCHK08 = BR.ReadString
            AF.AbueloMaternoOtrosAntecedentes = BR.ReadString
            AF.AbueloMaternoCausaDeMuerte = BR.ReadString
            AF.AbueloMaternoOtrasCausasMuerte = BR.ReadString
            'hermanos
            AF.HermanosCHK01 = BR.ReadString
            AF.HermanosCHK02 = BR.ReadString
            AF.HermanosCHK03 = BR.ReadString
            AF.HermanosCHK04 = BR.ReadString
            AF.HermanosCHK05 = BR.ReadString
            AF.HermanosCHK06 = BR.ReadString
            AF.HermanosCHK07 = BR.ReadString
            AF.HermanosCHK08 = BR.ReadString
            AF.HermanosOtrosAntecedentes = BR.ReadString
            AF.HermanosMuertosCHK01 = BR.ReadString
            AF.HermanosMuertosCHK02 = BR.ReadString
            AF.HermanosMuertosCHK03 = BR.ReadString
            AF.HermanosMuertosCHK04 = BR.ReadString
            AF.HermanosMuertosCHK05 = BR.ReadString
            AF.HermanosMuertosCHK06 = BR.ReadString
            AF.HermanosMuertosCHK07 = BR.ReadString
            AF.HermanosMuertosCHK08 = BR.ReadString
            AF.HermanosMuertosCHK09 = BR.ReadString
            AF.HermanosOtrasCausasMuerte = BR.ReadString
            'Tios
            AF.tiosCHK01 = BR.ReadString
            AF.tiosCHK02 = BR.ReadString
            AF.tiosCHK03 = BR.ReadString
            AF.tiosCHK04 = BR.ReadString
            AF.tiosCHK05 = BR.ReadString
            AF.tiosCHK06 = BR.ReadString
            AF.tiosCHK07 = BR.ReadString
            AF.tiosCHK08 = BR.ReadString
            AF.tiosOtrosAntecedentes = BR.ReadString
            AF.tiosMuertosCHK01 = BR.ReadString
            AF.tiosMuertosCHK02 = BR.ReadString
            AF.tiosMuertosCHK03 = BR.ReadString
            AF.tiosMuertosCHK04 = BR.ReadString
            AF.tiosMuertosCHK05 = BR.ReadString
            AF.tiosMuertosCHK06 = BR.ReadString
            AF.tiosMuertosCHK07 = BR.ReadString
            AF.tiosMuertosCHK08 = BR.ReadString
            AF.tiosMuertosCHK09 = BR.ReadString
            AF.tiosOtrasCausasMuerte = BR.ReadString
            'otros familiares
            AF.OtrosFamiliares = BR.ReadString

            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub

    Private Sub ActualizaLaPantallaConLaEstructura()
        'MADRE       0000000000000000000
        'Madre viva, muerta o desconoce
        If AF.MadreVivaMuertaDesconoce = "1" Then
            radMadreViva.Checked = True
        ElseIf AF.MadreVivaMuertaDesconoce = "2" Then
            radMadreMuerta.Checked = True
        ElseIf AF.MadreVivaMuertaDesconoce = "3" Then
            radMadreDesconoce.Checked = True
        End If

        'madre antecedentes niega, tiene o desconoce
        If AF.MadreNiegaTieneDesconoceAnt = "1" Then
            radMadreNiega.Checked = True
        ElseIf AF.MadreNiegaTieneDesconoceAnt = "3" Then
            radMadreDesconocePatologia.Checked = True
        ElseIf AF.MadreNiegaTieneDesconoceAnt = "2" Then
            radMadreTieneAnt.Checked = True
        End If

        'Madre diferentes patologias de antecedentes
        If AF.MadreCHK01 = "1" Then
            chkMadre01.Checked = True
        Else
            chkMadre01.Checked = False
        End If
        If AF.MadreCHK02 = "1" Then
            chkMadre02.Checked = True
        Else
            chkMadre02.Checked = False
        End If
        If AF.MadreCHK03 = "1" Then
            chkMadre03.Checked = True
        Else
            chkMadre03.Checked = False
        End If
        If AF.MadreCHK04 = "1" Then
            chkMadre04.Checked = True
        Else
            chkMadre04.Checked = False
        End If
        If AF.MadreCHK05 = "1" Then
            chkMadre05.Checked = True
        Else
            chkMadre05.Checked = False
        End If
        If AF.MadreCHK06 = "1" Then
            chkMadre06.Checked = True
        Else
            chkMadre06.Checked = False
        End If
        If AF.MadreCHK07 = "1" Then
            chkMadre07.Checked = True
        Else
            chkMadre07.Checked = False
        End If
        If AF.MadreCHK08 = "1" Then
            chkMadreOtros.Checked = True
        Else
            chkMadreOtros.Checked = False
        End If
        If AF.MadreOtrosAntecedentes <> "" Then
            txtMadreOtrosAnt.Text = AF.MadreOtrosAntecedentes
        End If


        'madre causa de muerte
        If AF.MadreCausaDeMuerte = "1" Then
            radMadre01.Checked = True
        ElseIf AF.MadreCausaDeMuerte = "2" Then
            radMadre02.Checked = True
        ElseIf AF.MadreCausaDeMuerte = "3" Then
            radMadre03.Checked = True
        ElseIf AF.MadreCausaDeMuerte = "4" Then
            radMadre04.Checked = True
        ElseIf AF.MadreCausaDeMuerte = "5" Then
            radMadre05.Checked = True
        ElseIf AF.MadreCausaDeMuerte = "6" Then
            radMadre06.Checked = True
        ElseIf AF.MadreCausaDeMuerte = "7" Then
            radMadre07.Checked = True
        ElseIf AF.MadreCausaDeMuerte = "8" Then
            radMadre08.Checked = True
        ElseIf AF.MadreCausaDeMuerte = "9" Then
            radMadreDesconoceCausa.Checked = True
        ElseIf AF.MadreCausaDeMuerte = "10" Then
            radMadreOtrasCausas.Checked = True
        End If
        If AF.MadreOtrasCausasMuerte <> "" Then
            txtMadreOtrasCausas.Text = AF.MadreOtrasCausasMuerte
        End If

        'Padre       0000000000000000000
        'Padre viva, muerta o desconoce
        If AF.PadreVivaMuertaDesconoce = "1" Then
            radPadreViva.Checked = True
        ElseIf AF.PadreVivaMuertaDesconoce = "2" Then
            radPadreMuerta.Checked = True
        ElseIf AF.PadreVivaMuertaDesconoce = "3" Then
            radPadreDesconoce.Checked = True
        End If

        'Padre antecedentes niega, tiene o desconoce
        If AF.PadreNiegaTieneDesconoceAnt = "1" Then
            radPadreNiega.Checked = True
        ElseIf AF.PadreNiegaTieneDesconoceAnt = "3" Then
            radPadreDesconocePatologia.Checked = True
        ElseIf AF.PadreNiegaTieneDesconoceAnt = "2" Then
            radPadreTieneAnt.Checked = True
        End If

        'Padre diferentes patologias de antecedentes
        If AF.PadreCHK01 = "1" Then
            chkPadre01.Checked = True
        Else
            chkPadre01.Checked = False
        End If
        If AF.PadreCHK02 = "1" Then
            chkPadre02.Checked = True
        Else
            chkPadre02.Checked = False
        End If
        If AF.PadreCHK03 = "1" Then
            chkPadre03.Checked = True
        Else
            chkPadre03.Checked = False
        End If
        If AF.PadreCHK04 = "1" Then
            chkPadre04.Checked = True
        Else
            chkPadre04.Checked = False
        End If
        If AF.PadreCHK05 = "1" Then
            chkPadre05.Checked = True
        Else
            chkPadre05.Checked = False
        End If
        If AF.PadreCHK06 = "1" Then
            chkPadre06.Checked = True
        Else
            chkPadre06.Checked = False
        End If
        If AF.PadreCHK07 = "1" Then
            chkPadre07.Checked = True
        Else
            chkPadre07.Checked = False
        End If
        If AF.PadreCHK08 = "1" Then
            chkPadreotros.Checked = True
        Else
            chkPadreotros.Checked = False
        End If
        If AF.PadreOtrosAntecedentes <> "" Then
            txtPadreOtrosAnt.Text = AF.PadreOtrosAntecedentes
        End If

        'Padre causa de muerte
        If AF.PadreCausaDeMuerte = "1" Then
            radPadre01.Checked = True
        ElseIf AF.PadreCausaDeMuerte = "2" Then
            radPadre02.Checked = True
        ElseIf AF.PadreCausaDeMuerte = "3" Then
            radPadre03.Checked = True
        ElseIf AF.PadreCausaDeMuerte = "4" Then
            radPadre04.Checked = True
        ElseIf AF.PadreCausaDeMuerte = "5" Then
            radPadre05.Checked = True
        ElseIf AF.PadreCausaDeMuerte = "6" Then
            radPadre06.Checked = True
        ElseIf AF.PadreCausaDeMuerte = "7" Then
            radPadre07.Checked = True
        ElseIf AF.PadreCausaDeMuerte = "8" Then
            radPadre08.Checked = True
        ElseIf AF.PadreCausaDeMuerte = "9" Then
            radPadreDesconoceCausa.Checked = True
        ElseIf AF.PadreCausaDeMuerte = "10" Then
            radPadreOtrasCausas.Checked = True
        End If
        If AF.PadreOtrasCausasMuerte <> "" Then
            txtPadreOtrasCausas.Text = AF.PadreOtrasCausasMuerte
        End If

        'AbuelaPaterna       0000000000000000000
        'AbuelaPaterna viva, muerta o desconoce
        If AF.AbuelaPaternaVivaMuertaDesconoce = "1" Then
            radAbuelaPaternaViva.Checked = True
        ElseIf AF.AbuelaPaternaVivaMuertaDesconoce = "2" Then
            radAbuelaPaternaMuerta.Checked = True
        ElseIf AF.AbuelaPaternaVivaMuertaDesconoce = "3" Then
            radAbuelaPaternaDesconoce.Checked = True
        End If

        'AbuelaPaterna antecedentes niega, tiene o desconoce
        If AF.AbuelaPaternaNiegaTieneDesconoceAnt = "1" Then
            radAbuelaPaternaNiega.Checked = True
        ElseIf AF.AbuelaPaternaNiegaTieneDesconoceAnt = "3" Then
            radAbuelaPaternaDesconocePatologia.Checked = True
        ElseIf AF.AbuelaPaternaNiegaTieneDesconoceAnt = "2" Then
            radAbuelaPaternaTieneAnt.Checked = True
        End If

        'AbuelaPaterna diferentes patologias de antecedentes
        If AF.AbuelaPaternaCHK01 = "1" Then
            chkAbuelaPaterna01.Checked = True
        Else
            chkAbuelaPaterna01.Checked = False
        End If
        If AF.AbuelaPaternaCHK02 = "1" Then
            chkAbuelaPaterna02.Checked = True
        Else
            chkAbuelaPaterna02.Checked = False
        End If
        If AF.AbuelaPaternaCHK03 = "1" Then
            chkAbuelaPaterna03.Checked = True
        Else
            chkAbuelaPaterna03.Checked = False
        End If
        If AF.AbuelaPaternaCHK04 = "1" Then
            chkAbuelaPaterna04.Checked = True
        Else
            chkAbuelaPaterna04.Checked = False
        End If
        If AF.AbuelaPaternaCHK05 = "1" Then
            chkAbuelaPaterna05.Checked = True
        Else
            chkAbuelaPaterna05.Checked = False
        End If
        If AF.AbuelaPaternaCHK06 = "1" Then
            chkAbuelaPaterna06.Checked = True
        Else
            chkAbuelaPaterna06.Checked = False
        End If
        If AF.AbuelaPaternaCHK07 = "1" Then
            chkAbuelaPaterna07.Checked = True
        Else
            chkAbuelaPaterna07.Checked = False
        End If
        If AF.AbuelaPaternaCHK08 = "1" Then
            chkAbuelaPaternaOtros.Checked = True
        Else
            chkAbuelaPaternaOtros.Checked = False
        End If
        If AF.AbuelaPaternaOtrosAntecedentes <> "" Then
            txtAbuelaPaternaOtrosAnt.Text = AF.AbuelaPaternaOtrosAntecedentes
        End If

        'AbuelaPaterna causa de muerte
        If AF.AbuelaPaternaCausaDeMuerte = "1" Then
            radAbuelaPaterna01.Checked = True
        ElseIf AF.AbuelaPaternaCausaDeMuerte = "2" Then
            radAbuelaPaterna02.Checked = True
        ElseIf AF.AbuelaPaternaCausaDeMuerte = "3" Then
            radAbuelaPaterna03.Checked = True
        ElseIf AF.AbuelaPaternaCausaDeMuerte = "4" Then
            radAbuelaPaterna04.Checked = True
        ElseIf AF.AbuelaPaternaCausaDeMuerte = "5" Then
            radAbuelaPaterna05.Checked = True
        ElseIf AF.AbuelaPaternaCausaDeMuerte = "6" Then
            radAbuelaPaterna06.Checked = True
        ElseIf AF.AbuelaPaternaCausaDeMuerte = "7" Then
            radAbuelaPaterna07.Checked = True
        ElseIf AF.AbuelaPaternaCausaDeMuerte = "8" Then
            radAbuelaPaterna08.Checked = True
        ElseIf AF.AbuelaPaternaCausaDeMuerte = "9" Then
            radAbuelaPaternaDesconoceCausa.Checked = True
        ElseIf AF.AbuelaPaternaCausaDeMuerte = "10" Then
            radAbuelaPaternaOtrasCausas.Checked = True
        End If
        If AF.AbuelaPaternaOtrasCausasMuerte <> "" Then
            txtAbuelaPaternaOtrasCausas.Text = AF.AbuelaPaternaOtrasCausasMuerte
        End If

        '0000000000

        'AbueloPaterno       0000000000000000000
        'AbueloPaterno viva, muerta o desconoce
        If AF.AbuelopaternoVivaMuertaDesconoce = "1" Then
            radAbueloPaternoViva.Checked = True
        ElseIf AF.AbuelopaternoVivaMuertaDesconoce = "2" Then
            radAbueloPaternoMuerta.Checked = True
        ElseIf AF.AbuelopaternoVivaMuertaDesconoce = "3" Then
            radAbueloPaternoDesconoce.Checked = True
        End If

        'AbueloPaterno antecedentes niega, tiene o desconoce
        If AF.AbuelopaternoNiegaTieneDesconoceAnt = "1" Then
            radAbueloPaternoNiega.Checked = True
        ElseIf AF.AbuelopaternoNiegaTieneDesconoceAnt = "3" Then
            radAbueloPaternoDesconocePatologia.Checked = True
        ElseIf AF.AbuelopaternoNiegaTieneDesconoceAnt = "2" Then
            radAbueloPaternoTieneAnt.Checked = True
        End If

        'AbueloPaterno diferentes patologias de antecedentes
        If AF.AbuelopaternoCHK01 = "1" Then
            chkAbueloPaterno01.Checked = True
        Else
            chkAbueloPaterno01.Checked = False
        End If
        If AF.AbuelopaternoCHK02 = "1" Then
            chkAbueloPaterno02.Checked = True
        Else
            chkAbueloPaterno02.Checked = False
        End If
        If AF.AbuelopaternoCHK03 = "1" Then
            chkAbueloPaterno03.Checked = True
        Else
            chkAbueloPaterno03.Checked = False
        End If
        If AF.AbuelopaternoCHK04 = "1" Then
            chkAbueloPaterno04.Checked = True
        Else
            chkAbueloPaterno04.Checked = False
        End If
        If AF.AbuelopaternoCHK05 = "1" Then
            chkAbueloPaterno05.Checked = True
        Else
            chkAbueloPaterno05.Checked = False
        End If
        If AF.AbuelopaternoCHK06 = "1" Then
            chkAbueloPaterno06.Checked = True
        Else
            chkAbueloPaterno06.Checked = False
        End If
        If AF.AbuelopaternoCHK07 = "1" Then
            chkAbueloPaterno07.Checked = True
        Else
            chkAbueloPaterno07.Checked = False
        End If
        If AF.AbuelopaternoCHK08 = "1" Then
            chkAbueloPaternoOtros.Checked = True
        Else
            chkAbueloPaternoOtros.Checked = False
        End If
        If AF.AbuelopaternoOtrosAntecedentes <> "" Then
            txtAbueloPaternoOtrosAnt.Text = AF.AbuelopaternoOtrosAntecedentes
        End If

        'AbueloPaterno causa de muerte
        If AF.AbuelopaternoCausaDeMuerte = "1" Then
            radAbueloPaterno01.Checked = True
        ElseIf AF.AbuelopaternoCausaDeMuerte = "2" Then
            radAbueloPaterno02.Checked = True
        ElseIf AF.AbuelopaternoCausaDeMuerte = "3" Then
            radAbueloPaterno03.Checked = True
        ElseIf AF.AbuelopaternoCausaDeMuerte = "4" Then
            radAbueloPaterno04.Checked = True
        ElseIf AF.AbuelopaternoCausaDeMuerte = "5" Then
            radAbueloPaterno05.Checked = True
        ElseIf AF.AbuelopaternoCausaDeMuerte = "6" Then
            radAbueloPaterno06.Checked = True
        ElseIf AF.AbuelopaternoCausaDeMuerte = "7" Then
            radAbueloPaterno07.Checked = True
        ElseIf AF.AbuelopaternoCausaDeMuerte = "8" Then
            radAbueloPaterno08.Checked = True
        ElseIf AF.AbuelopaternoCausaDeMuerte = "9" Then
            radAbueloPaternoDesconoceCausa.Checked = True
        ElseIf AF.AbuelopaternoCausaDeMuerte = "10" Then
            radAbueloPaternoOtrasCausas.Checked = True
        End If
        If AF.AbuelopaternoOtrasCausasMuerte <> "" Then
            txtAbueloPaternoOtrasCausas.Text = AF.AbuelopaternoOtrasCausasMuerte
        End If


        '0000000000

        'AbuelaMaterna       0000000000000000000
        'AbuelaMaterna viva, muerta o desconoce
        If AF.AbuelaMaternaVivaMuertaDesconoce = "1" Then
            radAbuelaMaternaViva.Checked = True
        ElseIf AF.AbuelaMaternaVivaMuertaDesconoce = "2" Then
            radAbuelaMaternaMuerta.Checked = True
        ElseIf AF.AbuelaMaternaVivaMuertaDesconoce = "3" Then
            radAbuelaMaternaDesconoce.Checked = True
        End If

        'AbuelaMaterna antecedentes niega, tiene o desconoce
        If AF.AbuelaMaternaNiegaTieneDesconoceAnt = "1" Then
            radAbuelaMaternaNiega.Checked = True
        ElseIf AF.AbuelaMaternaNiegaTieneDesconoceAnt = "3" Then
            radAbuelaMaternaDesconocePatologia.Checked = True
        ElseIf AF.AbuelaMaternaNiegaTieneDesconoceAnt = "2" Then
            radAbuelaMaternaTieneAnt.Checked = True
        End If

        'AbuelaMaterna diferentes patologias de antecedentes
        If AF.AbuelaMaternaCHK01 = "1" Then
            chkAbuelaMaterna01.Checked = True
        Else
            chkAbuelaMaterna01.Checked = False
        End If
        If AF.AbuelaMaternaCHK02 = "1" Then
            chkAbuelaMaterna02.Checked = True
        Else
            chkAbuelaMaterna02.Checked = False
        End If
        If AF.AbuelaMaternaCHK03 = "1" Then
            chkAbuelaMaterna03.Checked = True
        Else
            chkAbuelaMaterna03.Checked = False
        End If
        If AF.AbuelaMaternaCHK04 = "1" Then
            chkAbuelaMaterna04.Checked = True
        Else
            chkAbuelaMaterna04.Checked = False
        End If
        If AF.AbuelaMaternaCHK05 = "1" Then
            chkAbuelaMaterna05.Checked = True
        Else
            chkAbuelaMaterna05.Checked = False
        End If
        If AF.AbuelaMaternaCHK06 = "1" Then
            chkAbuelaMaterna06.Checked = True
        Else
            chkAbuelaMaterna06.Checked = False
        End If
        If AF.AbuelaMaternaCHK07 = "1" Then
            chkAbuelaMaterna07.Checked = True
        Else
            chkAbuelaMaterna07.Checked = False
        End If
        If AF.AbuelaMaternaCHK08 = "1" Then
            chkAbuelaMaternaOtros.Checked = True
        Else
            chkAbuelaMaternaOtros.Checked = False
        End If
        If AF.AbuelaMaternaOtrosAntecedentes <> "" Then
            txtAbuelaMaternaOtrosAnt.Text = AF.AbuelaMaternaOtrosAntecedentes
        End If

        'AbuelaMaterna causa de muerte
        If AF.AbuelaMaternaCausaDeMuerte = "1" Then
            radAbuelaMaterna01.Checked = True
        ElseIf AF.AbuelaMaternaCausaDeMuerte = "2" Then
            radAbuelaMaterna02.Checked = True
        ElseIf AF.AbuelaMaternaCausaDeMuerte = "3" Then
            radAbuelaMaterna03.Checked = True
        ElseIf AF.AbuelaMaternaCausaDeMuerte = "4" Then
            radAbuelaMaterna04.Checked = True
        ElseIf AF.AbuelaMaternaCausaDeMuerte = "5" Then
            radAbuelaMaterna05.Checked = True
        ElseIf AF.AbuelaMaternaCausaDeMuerte = "6" Then
            radAbuelaMaterna06.Checked = True
        ElseIf AF.AbuelaMaternaCausaDeMuerte = "7" Then
            radAbuelaMaterna07.Checked = True
        ElseIf AF.AbuelaMaternaCausaDeMuerte = "8" Then
            radAbuelaMaterna08.Checked = True
        ElseIf AF.AbuelaMaternaCausaDeMuerte = "9" Then
            radAbuelaMaternaDesconoceCausa.Checked = True
        ElseIf AF.AbuelaMaternaCausaDeMuerte = "10" Then
            radAbuelaMaternaOtrasCausas.Checked = True
        End If
        If AF.AbuelaMaternaOtrasCausasMuerte <> "" Then
            txtAbuelaMaternaOtrasCausas.Text = AF.AbuelaMaternaOtrasCausasMuerte
        End If

        '0000000000

        'AbueloMaterno       0000000000000000000
        'AbueloMaterno viva, muerta o desconoce
        If AF.AbueloMaternoVivaMuertaDesconoce = "1" Then
            radAbueloMaternoViva.Checked = True
        ElseIf AF.AbueloMaternoVivaMuertaDesconoce = "2" Then
            radAbueloMaternoMuerta.Checked = True
        ElseIf AF.AbueloMaternoVivaMuertaDesconoce = "3" Then
            radAbueloMaternoDesconoce.Checked = True
        End If

        'AbueloMaterno antecedentes niega, tiene o desconoce
        If AF.AbueloMaternoNiegaTieneDesconoceAnt = "1" Then
            radAbueloMaternoNiega.Checked = True
        ElseIf AF.AbueloMaternoNiegaTieneDesconoceAnt = "3" Then
            radAbueloMaternoDesconocePatologia.Checked = True
        ElseIf AF.AbueloMaternoNiegaTieneDesconoceAnt = "2" Then
            radAbueloMaternoTieneAnt.Checked = True
        End If

        'AbueloMaterno diferentes patologias de antecedentes
        If AF.AbueloMaternoCHK01 = "1" Then
            chkAbueloMaterno01.Checked = True
        Else
            chkAbueloMaterno01.Checked = False
        End If
        If AF.AbueloMaternoCHK02 = "1" Then
            chkAbueloMaterno02.Checked = True
        Else
            chkAbueloMaterno02.Checked = False
        End If
        If AF.AbueloMaternoCHK03 = "1" Then
            chkAbueloMaterno03.Checked = True
        Else
            chkAbueloMaterno03.Checked = False
        End If
        If AF.AbueloMaternoCHK04 = "1" Then
            chkAbueloMaterno04.Checked = True
        Else
            chkAbueloMaterno04.Checked = False
        End If
        If AF.AbueloMaternoCHK05 = "1" Then
            chkAbueloMaterno05.Checked = True
        Else
            chkAbueloMaterno05.Checked = False
        End If
        If AF.AbueloMaternoCHK06 = "1" Then
            chkAbueloMaterno06.Checked = True
        Else
            chkAbueloMaterno06.Checked = False
        End If
        If AF.AbueloMaternoCHK07 = "1" Then
            chkAbueloMaterno07.Checked = True
        Else
            chkAbueloMaterno07.Checked = False
        End If
        If AF.AbueloMaternoCHK08 = "1" Then
            chkAbueloMaternoOtros.Checked = True
        Else
            chkAbueloMaternoOtros.Checked = False
        End If
        If AF.AbueloMaternoOtrosAntecedentes <> "" Then
            txtAbueloMaternoOtrosAnt.Text = AF.AbueloMaternoOtrosAntecedentes
        End If

        'AbueloMaterno causa de muerte
        If AF.AbueloMaternoCausaDeMuerte = "1" Then
            radAbueloMaterno01.Checked = True
        ElseIf AF.AbueloMaternoCausaDeMuerte = "2" Then
            radAbueloMaterno02.Checked = True
        ElseIf AF.AbueloMaternoCausaDeMuerte = "3" Then
            radAbueloMaterno03.Checked = True
        ElseIf AF.AbueloMaternoCausaDeMuerte = "4" Then
            radAbueloMaterno04.Checked = True
        ElseIf AF.AbueloMaternoCausaDeMuerte = "5" Then
            radAbueloMaterno05.Checked = True
        ElseIf AF.AbueloMaternoCausaDeMuerte = "6" Then
            radAbueloMaterno06.Checked = True
        ElseIf AF.AbueloMaternoCausaDeMuerte = "7" Then
            radAbueloMaterno07.Checked = True
        ElseIf AF.AbueloMaternoCausaDeMuerte = "8" Then
            radAbueloMaterno08.Checked = True
        ElseIf AF.AbueloMaternoCausaDeMuerte = "9" Then
            radAbueloMaternoDesconoceCausa.Checked = True
        ElseIf AF.AbueloMaternoCausaDeMuerte = "10" Then
            radAbueloMaternoOtrasCausas.Checked = True
        End If
        If AF.AbueloMaternoOtrasCausasMuerte <> "" Then
            txtAbueloMaternoOtrasCausas.Text = AF.AbueloMaternoOtrasCausasMuerte
        End If

        '0000000000

        'Hermanos       0000000000000000000

        'Hermanos diferentes patologias de antecedentes
        If AF.HermanosCHK01 = "1" Then
            chkHermanos01.Checked = True
        Else
            chkHermanos01.Checked = False
        End If
        If AF.HermanosCHK02 = "1" Then
            chkHermanos02.Checked = True
        Else
            chkHermanos02.Checked = False
        End If
        If AF.HermanosCHK03 = "1" Then
            chkHermanos03.Checked = True
        Else
            chkHermanos03.Checked = False
        End If
        If AF.HermanosCHK04 = "1" Then
            chkHermanos04.Checked = True
        Else
            chkHermanos04.Checked = False
        End If
        If AF.HermanosCHK05 = "1" Then
            chkHermanos05.Checked = True
        Else
            chkHermanos05.Checked = False
        End If
        If AF.HermanosCHK06 = "1" Then
            chkHermanos06.Checked = True
        Else
            chkHermanos06.Checked = False
        End If
        If AF.HermanosCHK07 = "1" Then
            chkHermanos07.Checked = True
        Else
            chkHermanos07.Checked = False
        End If
        If AF.HermanosCHK08 = "1" Then
            chkHermanos08.Checked = True
        Else
            chkHermanos08.Checked = False
        End If
        If AF.HermanosOtrosAntecedentes <> "" Then
            txtHermanosOtrosAnt.Text = AF.HermanosOtrosAntecedentes
        End If

        'Hermanos causa de muerte
        If AF.HermanosMuertosCHK01 = "1" Then
            chkHermanosMuertos01.Checked = True
        Else
            chkHermanosMuertos01.Checked = False
        End If
        If AF.HermanosMuertosCHK02 = "1" Then
            chkHermanosMuertos02.Checked = True
        Else
            chkHermanosMuertos02.Checked = False
        End If
        If AF.HermanosMuertosCHK03 = "1" Then
            chkHermanosMuertos03.Checked = True
        Else
            chkHermanosMuertos03.Checked = False
        End If
        If AF.HermanosMuertosCHK04 = "1" Then
            chkHermanosMuertos04.Checked = True
        Else
            chkHermanosMuertos04.Checked = False
        End If
        If AF.HermanosMuertosCHK05 = "1" Then
            chkHermanosMuertos05.Checked = True
        Else
            chkHermanosMuertos05.Checked = False
        End If
        If AF.HermanosMuertosCHK06 = "1" Then
            chkHermanosMuertos06.Checked = True
        Else
            chkHermanosMuertos06.Checked = False
        End If
        If AF.HermanosMuertosCHK07 = "1" Then
            chkHermanosMuertos07.Checked = True
        Else
            chkHermanosMuertos07.Checked = False
        End If
        If AF.HermanosMuertosCHK08 = "1" Then
            chkHermanosMuertos08.Checked = True
        Else
            chkHermanosMuertos08.Checked = False
        End If
        If AF.HermanosMuertosCHK09 = "1" Then
            chkHermanosMuertos09.Checked = True
        Else
            chkHermanosMuertos09.Checked = False
        End If
        If AF.HermanosOtrasCausasMuerte <> "" Then
            txtHermanosMuertosOtrasCausas.Text = AF.HermanosOtrasCausasMuerte
        End If

        '0000000000000
        'Tios       0000000000000000000

        'Tios diferentes patologias de antecedentes
        If AF.tiosCHK01 = "1" Then
            chkTios01.Checked = True
        Else
            chkTios01.Checked = False
        End If
        If AF.tiosCHK02 = "1" Then
            chkTios02.Checked = True
        Else
            chkTios02.Checked = False
        End If
        If AF.tiosCHK03 = "1" Then
            chkTios03.Checked = True
        Else
            chkTios03.Checked = False
        End If
        If AF.tiosCHK04 = "1" Then
            chkTios04.Checked = True
        Else
            chkTios04.Checked = False
        End If
        If AF.tiosCHK05 = "1" Then
            chkTios05.Checked = True
        Else
            chkTios05.Checked = False
        End If
        If AF.tiosCHK06 = "1" Then
            chkTios06.Checked = True
        Else
            chkTios06.Checked = False
        End If
        If AF.tiosCHK07 = "1" Then
            chkTios07.Checked = True
        Else
            chkTios07.Checked = False
        End If
        If AF.tiosCHK08 = "1" Then
            chkTios08.Checked = True
        Else
            chkTios08.Checked = False
        End If
        If AF.tiosOtrosAntecedentes <> "" Then
            txtTiosOtrosAnt.Text = AF.tiosOtrosAntecedentes
        End If

        'Tios causa de muerte
        If AF.tiosMuertosCHK01 = "1" Then
            chkTiosMuertos01.Checked = True
        Else
            chkTiosMuertos01.Checked = False
        End If
        If AF.tiosMuertosCHK02 = "1" Then
            chkTiosMuertos02.Checked = True
        Else
            chkTiosMuertos02.Checked = False
        End If
        If AF.tiosMuertosCHK03 = "1" Then
            chkTiosMuertos03.Checked = True
        Else
            chkTiosMuertos03.Checked = False
        End If
        If AF.tiosMuertosCHK04 = "1" Then
            chkTiosMuertos04.Checked = True
        Else
            chkTiosMuertos04.Checked = False
        End If
        If AF.tiosMuertosCHK05 = "1" Then
            chkTiosMuertos05.Checked = True
        Else
            chkTiosMuertos05.Checked = False
        End If
        If AF.tiosMuertosCHK06 = "1" Then
            chkTiosMuertos06.Checked = True
        Else
            chkTiosMuertos06.Checked = False
        End If
        If AF.tiosMuertosCHK07 = "1" Then
            chkTiosMuertos07.Checked = True
        Else
            chkTiosMuertos07.Checked = False
        End If
        If AF.tiosMuertosCHK08 = "1" Then
            chkTiosMuertos08.Checked = True
        Else
            chkTiosMuertos08.Checked = False
        End If
        If AF.tiosMuertosCHK09 = "1" Then
            chkTiosMuertos09.Checked = True
        Else
            chkTiosMuertos09.Checked = False
        End If
        If AF.tiosOtrasCausasMuerte <> "" Then
            txtTiosMuertosOtrasCausas.Text = AF.tiosOtrasCausasMuerte
        End If

        'otros familiares
        If AF.OtrosFamiliares <> "" Then
            txtOtrosFamiliares.Text = AF.OtrosFamiliares
        End If


    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        If SePoducieronCambios = True Then
            Dim reply As MsgBoxResult

            reply = MsgBox("¿Realmente deseas descartar los datos?", MsgBoxStyle.YesNo, "Confirma descartar los nuevos datos")
            If reply = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    'PARTE DE LA MADRE
    Private Sub MadreBorraAntecedentes()
        'borra chkbox
        chkMadre01.Checked = False
        chkMadre02.Checked = False
        chkMadre03.Checked = False
        chkMadre04.Checked = False
        chkMadre05.Checked = False
        chkMadre06.Checked = False
        chkMadre07.Checked = False
        chkMadreOtros.Checked = False
        txtMadreOtrosAnt.Clear()
        'borra estructura
        'Antecedentes.MadreCHK01 = "0"
        'Antecedentes.MadreCHK02 = "0"
        'Antecedentes.MadreCHK03 = "0"
        'Antecedentes.MadreCHK04 = "0"
        'Antecedentes.MadreCHK05 = "0"
        'Antecedentes.MadreCHK06 = "0"
        'Antecedentes.MadreCHK07 = "0"
        'Antecedentes.MadreCHK08 = "0"
        'Antecedentes.MadreOtrosAntecedentes = ""
    End Sub

    Private Sub MadreApagaAntecedentes()
        chkMadre01.Enabled = False
        chkMadre02.Enabled = False
        chkMadre03.Enabled = False
        chkMadre04.Enabled = False
        chkMadre05.Enabled = False
        chkMadre06.Enabled = False
        chkMadre07.Enabled = False
        chkMadreOtros.Enabled = False
        txtMadreOtrosAnt.Enabled = False
    End Sub

    Private Sub MadreEnciendeAntecedentes()
        chkMadre01.Enabled = True
        chkMadre02.Enabled = True
        chkMadre03.Enabled = True
        chkMadre04.Enabled = True
        chkMadre05.Enabled = True
        chkMadre06.Enabled = True
        chkMadre07.Enabled = True
        chkMadreOtros.Enabled = True
    End Sub

    Private Sub MadreBorraCausas()
        radMadre01.Checked = False
        radMadre02.Checked = False
        radMadre03.Checked = False
        radMadre04.Checked = False
        radMadre05.Checked = False
        radMadre06.Checked = False
        radMadre07.Checked = False
        radMadre08.Checked = False
        radMadreDesconoceCausa.Checked = False
        radMadreOtrasCausas.Checked = False
        txtMadreOtrasCausas.Clear()
    End Sub

    Private Sub radMadreVivaMuertaoDesconoce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radMadreViva.CheckedChanged, radMadreMuerta.CheckedChanged, _
                radMadreDesconoce.CheckedChanged
        If radMadreViva.Checked = True Then
            'borra y despues apaga la parte de fallecimiento
            MadreBorraCausas()
            GBmadreCausaMuerte.Enabled = False
            'borra y enciende el GBox de antecedentes
            GBmadreAntecedentes.Enabled = True
            MadreApagaAntecedentes()
            'pone inicialmente negando antecedentes
            'radMadreNiega.Checked = True
        End If

        If radMadreMuerta.Checked = True Then
            'borra y enciende el GBox de antecedentes
            GBmadreAntecedentes.Enabled = True
            MadreApagaAntecedentes()
            'radMadreTieneAnt.Checked = True
            'efectos sobre las causas de muerte
            MadreBorraCausas()
            GBmadreCausaMuerte.Enabled = True
            'radMadreDesconoceCausa.Checked = True
        End If

        If radMadreDesconoce.Checked = True Then
            MadreBorraAntecedentes()
            MadreApagaAntecedentes()
            MadreBorraCausas()
            GBmadreAntecedentes.Enabled = False
            GBmadreCausaMuerte.Enabled = False
            'borra los rad buttons
            radMadreNiega.Checked = False
            radMadreTieneAnt.Checked = False
            radMadreDesconocePatologia.Checked = False
        End If

        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If

    End Sub

    'activa o no el cuadro de otros antecedentes
    Private Sub chkMadreOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMadreOtros.CheckedChanged
        If chkMadreOtros.Checked = True Then
            txtMadreOtrosAnt.Enabled = True
            txtMadreOtrosAnt.Focus()
        Else
            txtMadreOtrosAnt.Clear()
            txtMadreOtrosAnt.Enabled = False
        End If

        'revisa si se produjo un cambio
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radMadreNiegaoDesconoceANT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radMadreNiega.CheckedChanged, radMadreDesconocePatologia.CheckedChanged

        If radMadreNiega.Checked = True Or radMadreDesconocePatologia.Checked = True Then
            MadreBorraAntecedentes()
            MadreApagaAntecedentes()
        End If

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radMadreTieneAnt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMadreTieneAnt.CheckedChanged
        If radMadreTieneAnt.Checked = True Then
            MadreEnciendeAntecedentes()
        End If
    End Sub

    Private Sub radMadreOtrasCausas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMadreOtrasCausas.CheckedChanged
        If radMadreOtrasCausas.Checked = True Then
            txtMadreOtrasCausas.Enabled = True
            txtMadreOtrasCausas.Focus()
        Else
            txtMadreOtrasCausas.Clear()
            txtMadreOtrasCausas.Enabled = False
        End If
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkAntecedentesMadre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles chkMadre01.CheckedChanged, chkMadre02.CheckedChanged, _
                chkMadre03.CheckedChanged, chkMadre04.CheckedChanged, _
                chkMadre05.CheckedChanged, chkMadre06.CheckedChanged, _
                chkMadre07.CheckedChanged
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub txtMadreTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtMadreOtrosAnt.KeyPress, txtMadreOtrasCausas.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'revisa si se produjo un cambio por primera vez
                If SePoducieronCambios = False Then
                    SeProdujoUnCambio()
                End If
            End If

        End If
    End Sub

    Private Sub txtMadreOtrasCausas_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtMadreOtrasCausas.Leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtMadreOtrasCausas.Text <> "" Then
            LargoCadena = txtMadreOtrasCausas.Text.Length
            Cadena = txtMadreOtrasCausas.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtMadreOtrasCausas.Text = Cadena
            Else
                txtMadreOtrasCausas.Text = Cadena
            End If
        Else
            txtMadreOtrasCausas.Text = ""
        End If
    End Sub

    Private Sub txtMadreOtrosAnt_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtMadreOtrosAnt.leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtMadreOtrosAnt.Text <> "" Then
            LargoCadena = txtMadreOtrosAnt.Text.Length
            Cadena = txtMadreOtrosAnt.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtMadreOtrosAnt.Text = Cadena
            Else
                txtMadreOtrosAnt.Text = Cadena
            End If
        Else
            txtMadreOtrosAnt.Text = ""
        End If
    End Sub

    Private Sub radMuerteMadre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radMadre01.CheckedChanged, radMadre02.CheckedChanged, _
                radMadre03.CheckedChanged, radMadre04.CheckedChanged, _
                radMadre05.CheckedChanged, radMadre06.CheckedChanged, _
                radMadre07.CheckedChanged, radMadre08.CheckedChanged, _
                radMadreDesconoceCausa.CheckedChanged

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub


    'PARTE DE LA Padre
    Private Sub PadreBorraAntecedentes()
        'borra chkbox
        chkPadre01.Checked = False
        chkPadre02.Checked = False
        chkPadre03.Checked = False
        chkPadre04.Checked = False
        chkPadre05.Checked = False
        chkPadre06.Checked = False
        chkPadre07.Checked = False
        chkPadreotros.Checked = False
        txtPadreOtrosAnt.Clear()
        'borra estructura
        'Antecedentes.PadreCHK01 = "0"
        'Antecedentes.PadreCHK02 = "0"
        'Antecedentes.PadreCHK03 = "0"
        'Antecedentes.PadreCHK04 = "0"
        'Antecedentes.PadreCHK05 = "0"
        'Antecedentes.PadreCHK06 = "0"
        'Antecedentes.PadreCHK07 = "0"
        'Antecedentes.PadreCHK08 = "0"
        'Antecedentes.PadreOtrosAntecedentes = ""
    End Sub

    Private Sub PadreApagaAntecedentes()
        chkPadre01.Enabled = False
        chkPadre02.Enabled = False
        chkPadre03.Enabled = False
        chkPadre04.Enabled = False
        chkPadre05.Enabled = False
        chkPadre06.Enabled = False
        chkPadre07.Enabled = False
        chkPadreotros.Enabled = False
        txtPadreOtrosAnt.Enabled = False
    End Sub

    Private Sub PadreEnciendeAntecedentes()
        chkPadre01.Enabled = True
        chkPadre02.Enabled = True
        chkPadre03.Enabled = True
        chkPadre04.Enabled = True
        chkPadre05.Enabled = True
        chkPadre06.Enabled = True
        chkPadre07.Enabled = True
        chkPadreotros.Enabled = True
    End Sub

    Private Sub PadreBorraCausas()
        radPadre01.Checked = False
        radPadre02.Checked = False
        radPadre03.Checked = False
        radPadre04.Checked = False
        radPadre05.Checked = False
        radPadre06.Checked = False
        radPadre07.Checked = False
        radPadre08.Checked = False
        radPadreDesconoceCausa.Checked = False
        radPadreOtrasCausas.Checked = False
        txtPadreOtrasCausas.Clear()
    End Sub

    Private Sub radPadreVivaMuertaoDesconoce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radPadreViva.CheckedChanged, radPadreMuerta.CheckedChanged, _
                radPadreDesconoce.CheckedChanged
        If radPadreViva.Checked = True Then
            'borra y despues apaga la parte de fallecimiento
            PadreBorraCausas()
            GBpadreCausaMuerte.Enabled = False
            'borra y enciende el GBox de antecedentes
            GBpadreAntecedentes.Enabled = True
            PadreApagaAntecedentes()
            'pone inicialmente negando antecedentes
            'radPadreNiega.Checked = True
        End If

        If radPadreMuerta.Checked = True Then
            'borra y enciende el GBox de antecedentes
            PadreApagaAntecedentes()
            GBpadreAntecedentes.Enabled = True
            'radPadreTieneAnt.Checked = True
            'efectos sobre las causas de muerte
            PadreBorraCausas()
            GBpadreCausaMuerte.Enabled = True
            'radPadreDesconoceCausa.Checked = True
        End If

        If radPadreDesconoce.Checked = True Then
            PadreBorraAntecedentes()
            PadreApagaAntecedentes()
            PadreBorraCausas()
            GBpadreAntecedentes.Enabled = False
            GBpadreCausaMuerte.Enabled = False
            'borra los rad buttons
            radPadreNiega.Checked = False
            radPadreTieneAnt.Checked = False
            radPadreDesconocePatologia.Checked = False
        End If

        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If

    End Sub

    'activa o no el cuadro de otros antecedentes
    Private Sub chkPadreOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPadreotros.CheckedChanged
        If chkPadreotros.Checked = True Then
            txtPadreOtrosAnt.Enabled = True
            txtPadreOtrosAnt.Focus()
        Else
            txtPadreOtrosAnt.Clear()
            txtPadreOtrosAnt.Enabled = False
        End If

        'revisa si se produjo un cambio
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radPadreNiegaoDesconoceANT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radPadreNiega.CheckedChanged, radPadreDesconocePatologia.CheckedChanged

        If radPadreNiega.Checked = True Or radPadreDesconocePatologia.Checked = True Then
            PadreBorraAntecedentes()
            PadreApagaAntecedentes()
        End If

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radPadreTieneAnt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPadreTieneAnt.CheckedChanged
        If radPadreTieneAnt.Checked = True Then
            PadreEnciendeAntecedentes()
        End If
    End Sub

    Private Sub radPadreOtrasCausas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPadreOtrasCausas.CheckedChanged
        If radPadreOtrasCausas.Checked = True Then
            txtPadreOtrasCausas.Enabled = True
            txtPadreOtrasCausas.Focus()
        Else
            txtPadreOtrasCausas.Clear()
            txtPadreOtrasCausas.Enabled = False
        End If
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkAntecedentesPadre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles chkPadre01.CheckedChanged, chkPadre02.CheckedChanged, _
                chkPadre03.CheckedChanged, chkPadre04.CheckedChanged, _
                chkPadre05.CheckedChanged, chkPadre06.CheckedChanged, _
                chkPadre07.CheckedChanged
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub txtPadreTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtPadreOtrosAnt.KeyPress, txtPadreOtrasCausas.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'revisa si se produjo un cambio por primera vez
                If SePoducieronCambios = False Then
                    SeProdujoUnCambio()
                End If
            End If

        End If
    End Sub

    Private Sub txtPadreOtrasCausas_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtPadreOtrasCausas.leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtPadreOtrasCausas.Text <> "" Then
            LargoCadena = txtPadreOtrasCausas.Text.Length
            Cadena = txtPadreOtrasCausas.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtPadreOtrasCausas.Text = Cadena
            Else
                txtPadreOtrasCausas.Text = Cadena
            End If
        Else
            txtPadreOtrasCausas.Text = ""
        End If
    End Sub

    Private Sub txtPadreOtrosAnt_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtPadreOtrosAnt.Leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtPadreOtrosAnt.Text <> "" Then
            LargoCadena = txtPadreOtrosAnt.Text.Length
            Cadena = txtPadreOtrosAnt.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtPadreOtrosAnt.Text = Cadena
            Else
                txtPadreOtrosAnt.Text = Cadena
            End If
        Else
            txtPadreOtrosAnt.Text = ""
        End If
    End Sub

    Private Sub radMuertePadre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radPadre01.CheckedChanged, radPadre02.CheckedChanged, _
                radPadre03.CheckedChanged, radPadre04.CheckedChanged, _
                radPadre05.CheckedChanged, radPadre06.CheckedChanged, _
                radPadre07.CheckedChanged, radPadre08.CheckedChanged, _
                radPadreDesconoceCausa.CheckedChanged

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub


    '0000000000000000000000000

    'PARTE DE LA AbuelaPaterna
    Private Sub AbuelaPaternaBorraAntecedentes()
        'borra chkbox
        chkAbuelaPaterna01.Checked = False
        chkAbuelaPaterna02.Checked = False
        chkAbuelaPaterna03.Checked = False
        chkAbuelaPaterna04.Checked = False
        chkAbuelaPaterna05.Checked = False
        chkAbuelaPaterna06.Checked = False
        chkAbuelaPaterna07.Checked = False
        chkAbuelaPaternaOtros.Checked = False
        txtAbuelaPaternaOtrosAnt.Clear()
        'borra estructura
        'Antecedentes.AbuelaPaternaCHK01 = "0"
        'Antecedentes.AbuelaPaternaCHK02 = "0"
        'Antecedentes.AbuelaPaternaCHK03 = "0"
        'Antecedentes.AbuelaPaternaCHK04 = "0"
        'Antecedentes.AbuelaPaternaCHK05 = "0"
        'Antecedentes.AbuelaPaternaCHK06 = "0"
        'Antecedentes.AbuelaPaternaCHK07 = "0"
        'Antecedentes.AbuelaPaternaCHK08 = "0"
        'Antecedentes.AbuelaPaternaOtrosAntecedentes = ""
    End Sub

    Private Sub AbuelaPaternaApagaAntecedentes()
        chkAbuelaPaterna01.Enabled = False
        chkAbuelaPaterna02.Enabled = False
        chkAbuelaPaterna03.Enabled = False
        chkAbuelaPaterna04.Enabled = False
        chkAbuelaPaterna05.Enabled = False
        chkAbuelaPaterna06.Enabled = False
        chkAbuelaPaterna07.Enabled = False
        chkAbuelaPaternaOtros.Enabled = False
        txtAbuelaPaternaOtrosAnt.Enabled = False
    End Sub

    Private Sub AbuelaPaternaEnciendeAntecedentes()
        chkAbuelaPaterna01.Enabled = True
        chkAbuelaPaterna02.Enabled = True
        chkAbuelaPaterna03.Enabled = True
        chkAbuelaPaterna04.Enabled = True
        chkAbuelaPaterna05.Enabled = True
        chkAbuelaPaterna06.Enabled = True
        chkAbuelaPaterna07.Enabled = True
        chkAbuelaPaternaOtros.Enabled = True
    End Sub

    Private Sub AbuelaPaternaBorraCausas()
        radAbuelaPaterna01.Checked = False
        radAbuelaPaterna02.Checked = False
        radAbuelaPaterna03.Checked = False
        radAbuelaPaterna04.Checked = False
        radAbuelaPaterna05.Checked = False
        radAbuelaPaterna06.Checked = False
        radAbuelaPaterna07.Checked = False
        radAbuelaPaterna08.Checked = False
        radAbuelaPaternaDesconoceCausa.Checked = False
        radAbuelaPaternaOtrasCausas.Checked = False
        txtAbuelaPaternaOtrasCausas.Clear()
    End Sub

    Private Sub radAbuelaPaternaVivaMuertaoDesconoce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbuelaPaternaViva.CheckedChanged, radAbuelaPaternaMuerta.CheckedChanged, _
                radAbuelaPaternaDesconoce.CheckedChanged
        If radAbuelaPaternaViva.Checked = True Then
            'borra y despues apaga la parte de fallecimiento
            AbuelaPaternaBorraCausas()
            GBAbuelaPaternaCausaMuerte.Enabled = False
            'borra y enciende el GBox de antecedentes
            GBAbuelaPaternaAntecedentes.Enabled = True
            AbuelaPaternaApagaAntecedentes()
            'pone inicialmente negando antecedentes
            'radAbuelaPaternaTieneAnt.Checked = True
        End If

        If radAbuelaPaternaMuerta.Checked = True Then
            'borra y enciende el GBox de antecedentes
            AbuelaPaternaApagaAntecedentes()
            GBAbuelaPaternaAntecedentes.Enabled = True
            'radAbuelaPaternaTieneAnt.Checked = True
            'efectos sobre las causas de muerte
            AbuelaPaternaBorraCausas()
            GBAbuelaPaternaCausaMuerte.Enabled = True
            'radAbuelaPaternaDesconoceCausa.Checked = True
        End If

        If radAbuelaPaternaDesconoce.Checked = True Then
            AbuelaPaternaBorraAntecedentes()
            AbuelaPaternaApagaAntecedentes()
            AbuelaPaternaBorraCausas()
            GBAbuelaPaternaAntecedentes.Enabled = False
            GBAbuelaPaternaCausaMuerte.Enabled = False
            'borra los rad buttons
            radAbuelaPaternaNiega.Checked = False
            radAbuelaPaternaTieneAnt.Checked = False
            radAbuelaPaternaDesconocePatologia.Checked = False
        End If

        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If

    End Sub

    'activa o no el cuadro de otros antecedentes
    Private Sub chkAbuelaPaternaOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAbuelaPaternaOtros.CheckedChanged
        If chkAbuelaPaternaOtros.Checked = True Then
            txtAbuelaPaternaOtrosAnt.Enabled = True
            txtAbuelaPaternaOtrosAnt.Focus()
        Else
            txtAbuelaPaternaOtrosAnt.Clear()
            txtAbuelaPaternaOtrosAnt.Enabled = False
        End If

        'revisa si se produjo un cambio
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radAbuelaPaternaNiegaoDesconoceANT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbuelaPaternaNiega.CheckedChanged, radAbuelaPaternaDesconocePatologia.CheckedChanged

        If radAbuelaPaternaNiega.Checked = True Or radAbuelaPaternaDesconocePatologia.Checked = True Then
            AbuelaPaternaBorraAntecedentes()
            AbuelaPaternaApagaAntecedentes()
        End If

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radAbuelaPaternaTieneAnt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAbuelaPaternaTieneAnt.CheckedChanged
        If radAbuelaPaternaTieneAnt.Checked = True Then
            AbuelaPaternaEnciendeAntecedentes()
        End If
    End Sub

    Private Sub radAbuelaPaternaOtrasCausas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAbuelaPaternaOtrasCausas.CheckedChanged
        If radAbuelaPaternaOtrasCausas.Checked = True Then
            txtAbuelaPaternaOtrasCausas.Enabled = True
            txtAbuelaPaternaOtrasCausas.Focus()
        Else
            txtAbuelaPaternaOtrasCausas.Clear()
            txtAbuelaPaternaOtrasCausas.Enabled = False
        End If
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkAntecedentesAbuelaPaterna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles chkAbuelaPaterna01.CheckedChanged, chkAbuelaPaterna02.CheckedChanged, _
                chkAbuelaPaterna03.CheckedChanged, chkAbuelaPaterna04.CheckedChanged, _
                chkAbuelaPaterna05.CheckedChanged, chkAbuelaPaterna06.CheckedChanged, _
                chkAbuelaPaterna07.CheckedChanged
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub txtAbuelaPaternaTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtAbuelaPaternaOtrosAnt.KeyPress, txtAbuelaPaternaOtrasCausas.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'revisa si se produjo un cambio por primera vez
                If SePoducieronCambios = False Then
                    SeProdujoUnCambio()
                End If
            End If

        End If
    End Sub

    Private Sub txtAbuelaPaternaOtrasCausas_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtAbuelaPaternaOtrasCausas.Leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtAbuelaPaternaOtrasCausas.Text <> "" Then
            LargoCadena = txtAbuelaPaternaOtrasCausas.Text.Length
            Cadena = txtAbuelaPaternaOtrasCausas.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtAbuelaPaternaOtrasCausas.Text = Cadena
            Else
                txtAbuelaPaternaOtrasCausas.Text = Cadena
            End If
        Else
            txtAbuelaPaternaOtrasCausas.Text = ""
        End If
    End Sub

    Private Sub txtAbuelaPaternaOtrosAnt_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtAbuelaPaternaOtrosAnt.Leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtAbuelaPaternaOtrosAnt.Text <> "" Then
            LargoCadena = txtAbuelaPaternaOtrosAnt.Text.Length
            Cadena = txtAbuelaPaternaOtrosAnt.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtAbuelaPaternaOtrosAnt.Text = Cadena
            Else
                txtAbuelaPaternaOtrosAnt.Text = Cadena
            End If
        Else
            txtAbuelaPaternaOtrosAnt.Text = ""
        End If
    End Sub

    Private Sub radMuerteAbuelaPaterna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbuelaPaterna01.CheckedChanged, radAbuelaPaterna02.CheckedChanged, _
                radAbuelaPaterna03.CheckedChanged, radAbuelaPaterna04.CheckedChanged, _
                radAbuelaPaterna05.CheckedChanged, radAbuelaPaterna06.CheckedChanged, _
                radAbuelaPaterna07.CheckedChanged, radAbuelaPaterna08.CheckedChanged, _
                radAbuelaPaternaDesconoceCausa.CheckedChanged

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub


    '0000000000000000

    '0000000000000000000000000

    'PARTE DE LA AbueloPaterno
    Private Sub AbueloPaternoBorraAntecedentes()
        'borra chkbox
        chkAbueloPaterno01.Checked = False
        chkAbueloPaterno02.Checked = False
        chkAbueloPaterno03.Checked = False
        chkAbueloPaterno04.Checked = False
        chkAbueloPaterno05.Checked = False
        chkAbueloPaterno06.Checked = False
        chkAbueloPaterno07.Checked = False
        chkAbueloPaternoOtros.Checked = False
        txtAbueloPaternoOtrosAnt.Clear()
        'borra estructura
        'Antecedentes.AbuelopaternoCHK01 = "0"
        'Antecedentes.AbuelopaternoCHK02 = "0"
        'Antecedentes.AbuelopaternoCHK03 = "0"
        'Antecedentes.AbuelopaternoCHK04 = "0"
        'Antecedentes.AbuelopaternoCHK05 = "0"
        'Antecedentes.AbuelopaternoCHK06 = "0"
        'Antecedentes.AbuelopaternoCHK07 = "0"
        'Antecedentes.AbuelopaternoCHK08 = "0"
        'Antecedentes.AbuelopaternoOtrosAntecedentes = ""
    End Sub

    Private Sub AbueloPaternoApagaAntecedentes()
        chkAbueloPaterno01.Enabled = False
        chkAbueloPaterno02.Enabled = False
        chkAbueloPaterno03.Enabled = False
        chkAbueloPaterno04.Enabled = False
        chkAbueloPaterno05.Enabled = False
        chkAbueloPaterno06.Enabled = False
        chkAbueloPaterno07.Enabled = False
        chkAbueloPaternoOtros.Enabled = False
        txtAbueloPaternoOtrosAnt.Enabled = False
    End Sub

    Private Sub AbueloPaternoEnciendeAntecedentes()
        chkAbueloPaterno01.Enabled = True
        chkAbueloPaterno02.Enabled = True
        chkAbueloPaterno03.Enabled = True
        chkAbueloPaterno04.Enabled = True
        chkAbueloPaterno05.Enabled = True
        chkAbueloPaterno06.Enabled = True
        chkAbueloPaterno07.Enabled = True
        chkAbueloPaternoOtros.Enabled = True
    End Sub

    Private Sub AbueloPaternoBorraCausas()
        radAbueloPaterno01.Checked = False
        radAbueloPaterno02.Checked = False
        radAbueloPaterno03.Checked = False
        radAbueloPaterno04.Checked = False
        radAbueloPaterno05.Checked = False
        radAbueloPaterno06.Checked = False
        radAbueloPaterno07.Checked = False
        radAbueloPaterno08.Checked = False
        radAbueloPaternoDesconoceCausa.Checked = False
        radAbueloPaternoOtrasCausas.Checked = False
        txtAbueloPaternoOtrasCausas.Clear()
    End Sub

    Private Sub radAbueloPaternoVivaMuertaoDesconoce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbueloPaternoViva.CheckedChanged, radAbueloPaternoMuerta.CheckedChanged, _
                radAbueloPaternoDesconoce.CheckedChanged
        If radAbueloPaternoViva.Checked = True Then
            'borra y despues apaga la parte de fallecimiento
            AbueloPaternoBorraCausas()
            GBAbueloPaternocausaMuerte.Enabled = False
            'borra y enciende el GBox de antecedentes
            GBAbueloPaternoAntecedentes.Enabled = True
            AbueloPaternoApagaAntecedentes()
            'pone inicialmente negando antecedentes
            'radAbueloPaternoTieneAnt.Checked = True
        End If

        If radAbueloPaternoMuerta.Checked = True Then
            'borra y enciende el GBox de antecedentes
            AbueloPaternoApagaAntecedentes()
            GBAbueloPaternoAntecedentes.Enabled = True
            'radAbueloPaternoTieneAnt.Checked = True
            'efectos sobre las causas de muerte
            AbueloPaternoBorraCausas()
            GBAbueloPaternocausaMuerte.Enabled = True
            'radAbueloPaternoDesconoceCausa.Checked = True
        End If

        If radAbueloPaternoDesconoce.Checked = True Then
            AbueloPaternoBorraAntecedentes()
            AbueloPaternoApagaAntecedentes()
            AbueloPaternoBorraCausas()
            GBAbueloPaternoAntecedentes.Enabled = False
            GBAbueloPaternocausaMuerte.Enabled = False
            'borra los rad buttons
            radAbueloPaternoNiega.Checked = False
            radAbueloPaternoTieneAnt.Checked = False
            radAbueloPaternoDesconocePatologia.Checked = False
        End If

        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If

    End Sub

    'activa o no el cuadro de otros antecedentes
    Private Sub chkAbueloPaternoOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAbueloPaternoOtros.CheckedChanged
        If chkAbueloPaternoOtros.Checked = True Then
            txtAbueloPaternoOtrosAnt.Enabled = True
            txtAbueloPaternoOtrosAnt.Focus()
        Else
            txtAbueloPaternoOtrosAnt.Clear()
            txtAbueloPaternoOtrosAnt.Enabled = False
        End If

        'revisa si se produjo un cambio
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radAbueloPaternoNiegaoDesconoceANT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbueloPaternoNiega.CheckedChanged, radAbueloPaternoDesconocePatologia.CheckedChanged

        If radAbueloPaternoNiega.Checked = True Or radAbueloPaternoDesconocePatologia.Checked = True Then
            AbueloPaternoBorraAntecedentes()
            AbueloPaternoApagaAntecedentes()
        End If

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radAbueloPaternoTieneAnt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAbueloPaternoTieneAnt.CheckedChanged
        If radAbueloPaternoTieneAnt.Checked = True Then
            AbueloPaternoEnciendeAntecedentes()
        End If
    End Sub

    Private Sub radAbueloPaternoOtrasCausas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAbueloPaternoOtrasCausas.CheckedChanged
        If radAbueloPaternoOtrasCausas.Checked = True Then
            txtAbueloPaternoOtrasCausas.Enabled = True
            txtAbueloPaternoOtrasCausas.Focus()
        Else
            txtAbueloPaternoOtrasCausas.Clear()
            txtAbueloPaternoOtrasCausas.Enabled = False
        End If
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkAntecedentesAbueloPaterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles chkAbueloPaterno01.CheckedChanged, chkAbueloPaterno02.CheckedChanged, _
                chkAbueloPaterno03.CheckedChanged, chkAbueloPaterno04.CheckedChanged, _
                chkAbueloPaterno05.CheckedChanged, chkAbueloPaterno06.CheckedChanged, _
                chkAbueloPaterno07.CheckedChanged
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub txtAbueloPaternoTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
         Handles txtAbueloPaternoOtrosAnt.KeyPress, txtAbueloPaternoOtrasCausas.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'revisa si se produjo un cambio por primera vez
                If SePoducieronCambios = False Then
                    SeProdujoUnCambio()
                End If
            End If

        End If
    End Sub

    Private Sub txtAbueloPaternoOtrasCausas_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtAbueloPaternoOtrasCausas.Leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtAbueloPaternoOtrasCausas.Text <> "" Then
            LargoCadena = txtAbueloPaternoOtrasCausas.Text.Length
            Cadena = txtAbueloPaternoOtrasCausas.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtAbueloPaternoOtrasCausas.Text = Cadena
            Else
                txtAbueloPaternoOtrasCausas.Text = Cadena
            End If
        Else
            txtAbueloPaternoOtrasCausas.Text = ""
        End If
    End Sub

    Private Sub txtAbueloPaternoOtrosAnt_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtAbueloPaternoOtrosAnt.Leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtAbueloPaternoOtrosAnt.Text <> "" Then
            LargoCadena = txtAbueloPaternoOtrosAnt.Text.Length
            Cadena = txtAbueloPaternoOtrosAnt.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtAbueloPaternoOtrosAnt.Text = Cadena
            Else
                txtAbueloPaternoOtrosAnt.Text = Cadena
            End If
        Else
            txtAbueloPaternoOtrosAnt.Text = ""
        End If
    End Sub

    Private Sub radMuerteAbueloPaterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbueloPaterno01.CheckedChanged, radAbueloPaterno02.CheckedChanged, _
                radAbueloPaterno03.CheckedChanged, radAbueloPaterno04.CheckedChanged, _
                radAbueloPaterno05.CheckedChanged, radAbueloPaterno06.CheckedChanged, _
                radAbueloPaterno07.CheckedChanged, radAbueloPaterno08.CheckedChanged, _
                radAbueloPaternoDesconoceCausa.CheckedChanged

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    '00000000000000000
    'PARTE DE LA AbuelaMaterna
    Private Sub AbuelaMaternaBorraAntecedentes()
        'borra chkbox
        chkAbuelaMaterna01.Checked = False
        chkAbuelaMaterna02.Checked = False
        chkAbuelaMaterna03.Checked = False
        chkAbuelaMaterna04.Checked = False
        chkAbuelaMaterna05.Checked = False
        chkAbuelaMaterna06.Checked = False
        chkAbuelaMaterna07.Checked = False
        chkAbuelaMaternaOtros.Checked = False
        txtAbuelaMaternaOtrosAnt.Clear()
        'borra estructura
        'Antecedentes.AbuelaMaternaCHK01 = "0"
        'Antecedentes.AbuelaMaternaCHK02 = "0"
        'Antecedentes.AbuelaMaternaCHK03 = "0"
        'Antecedentes.AbuelaMaternaCHK04 = "0"
        'Antecedentes.AbuelaMaternaCHK05 = "0"
        'Antecedentes.AbuelaMaternaCHK06 = "0"
        'Antecedentes.AbuelaMaternaCHK07 = "0"
        'Antecedentes.AbuelaMaternaCHK08 = "0"
        'Antecedentes.AbuelaMaternaOtrosAntecedentes = ""
    End Sub

    Private Sub AbuelaMaternaApagaAntecedentes()
        chkAbuelaMaterna01.Enabled = False
        chkAbuelaMaterna02.Enabled = False
        chkAbuelaMaterna03.Enabled = False
        chkAbuelaMaterna04.Enabled = False
        chkAbuelaMaterna05.Enabled = False
        chkAbuelaMaterna06.Enabled = False
        chkAbuelaMaterna07.Enabled = False
        chkAbuelaMaternaOtros.Enabled = False
        txtAbuelaMaternaOtrosAnt.Enabled = False
    End Sub

    Private Sub AbuelaMaternaEnciendeAntecedentes()
        chkAbuelaMaterna01.Enabled = True
        chkAbuelaMaterna02.Enabled = True
        chkAbuelaMaterna03.Enabled = True
        chkAbuelaMaterna04.Enabled = True
        chkAbuelaMaterna05.Enabled = True
        chkAbuelaMaterna06.Enabled = True
        chkAbuelaMaterna07.Enabled = True
        chkAbuelaMaternaOtros.Enabled = True
    End Sub

    Private Sub AbuelaMaternaBorraCausas()
        radAbuelaMaterna01.Checked = False
        radAbuelaMaterna02.Checked = False
        radAbuelaMaterna03.Checked = False
        radAbuelaMaterna04.Checked = False
        radAbuelaMaterna05.Checked = False
        radAbuelaMaterna06.Checked = False
        radAbuelaMaterna07.Checked = False
        radAbuelaMaterna08.Checked = False
        radAbuelaMaternaDesconoceCausa.Checked = False
        radAbuelaMaternaOtrasCausas.Checked = False
        txtAbuelaMaternaOtrasCausas.Clear()
    End Sub

    Private Sub radAbuelaMaternaVivaMuertaoDesconoce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbuelaMaternaViva.CheckedChanged, radAbuelaMaternaMuerta.CheckedChanged, _
                radAbuelaMaternaDesconoce.CheckedChanged
        If radAbuelaMaternaViva.Checked = True Then
            'borra y despues apaga la parte de fallecimiento
            AbuelaMaternaBorraCausas()
            GBAbuelaMaternaCausaMuerte.Enabled = False
            'borra y enciende el GBox de antecedentes
            GBAbuelaMaternaAntecedentes.Enabled = True
            AbuelaMaternaApagaAntecedentes()
            'pone inicialmente negando antecedentes
            'radAbuelaMaternaTieneAnt.Checked = True
        End If

        If radAbuelaMaternaMuerta.Checked = True Then
            'borra y enciende el GBox de antecedentes
            AbuelaMaternaApagaAntecedentes()
            GBAbuelaMaternaAntecedentes.Enabled = True
            'radAbuelaMaternaTieneAnt.Checked = True
            'efectos sobre las causas de muerte
            AbuelaMaternaBorraCausas()
            GBAbuelaMaternaCausaMuerte.Enabled = True
            'radAbuelaMaternaDesconoceCausa.Checked = True
        End If

        If radAbuelaMaternaDesconoce.Checked = True Then
            AbuelaMaternaBorraAntecedentes()
            AbuelaMaternaApagaAntecedentes()
            AbuelaMaternaBorraCausas()
            GBAbuelaMaternaAntecedentes.Enabled = False
            GBAbuelaMaternaCausaMuerte.Enabled = False
            'borra los rad buttons
            radAbuelaMaternaNiega.Checked = False
            radAbuelaMaternaTieneAnt.Checked = False
            radAbuelaMaternaDesconocePatologia.Checked = False
        End If

        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If

    End Sub

    'activa o no el cuadro de otros antecedentes
    Private Sub chkAbuelaMaternaOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAbuelaMaternaOtros.CheckedChanged
        If chkAbuelaMaternaOtros.Checked = True Then
            txtAbuelaMaternaOtrosAnt.Enabled = True
            txtAbuelaMaternaOtrosAnt.Focus()
        Else
            txtAbuelaMaternaOtrosAnt.Clear()
            txtAbuelaMaternaOtrosAnt.Enabled = False
        End If

        'revisa si se produjo un cambio
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radAbuelaMaternaNiegaoDesconoceANT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbuelaMaternaNiega.CheckedChanged, radAbuelaMaternaDesconocePatologia.CheckedChanged

        If radAbuelaMaternaNiega.Checked = True Or radAbuelaMaternaDesconocePatologia.Checked = True Then
            AbuelaMaternaBorraAntecedentes()
            AbuelaMaternaApagaAntecedentes()
        End If

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radAbuelaMaternaTieneAnt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAbuelaMaternaTieneAnt.CheckedChanged
        If radAbuelaMaternaTieneAnt.Checked = True Then
            AbuelaMaternaEnciendeAntecedentes()
        End If
    End Sub

    Private Sub radAbuelaMaternaOtrasCausas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAbuelaMaternaOtrasCausas.CheckedChanged
        If radAbuelaMaternaOtrasCausas.Checked = True Then
            txtAbuelaMaternaOtrasCausas.Enabled = True
            txtAbuelaMaternaOtrasCausas.Focus()
        Else
            txtAbuelaMaternaOtrasCausas.Clear()
            txtAbuelaMaternaOtrasCausas.Enabled = False
        End If
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkAntecedentesAbuelaMaterna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles chkAbuelaMaterna01.CheckedChanged, chkAbuelaMaterna02.CheckedChanged, _
                chkAbuelaMaterna03.CheckedChanged, chkAbuelaMaterna04.CheckedChanged, _
                chkAbuelaMaterna05.CheckedChanged, chkAbuelaMaterna06.CheckedChanged, _
                chkAbuelaMaterna07.CheckedChanged
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub txtAbuelaMaternaTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtAbuelaMaternaOtrosAnt.KeyPress, txtAbuelaMaternaOtrasCausas.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'revisa si se produjo un cambio por primera vez
                If SePoducieronCambios = False Then
                    SeProdujoUnCambio()
                End If
            End If

        End If
    End Sub

    Private Sub txtAbuelaMaternaOtrasCausas_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtAbuelaMaternaOtrasCausas.leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtAbuelaMaternaOtrasCausas.Text <> "" Then
            LargoCadena = txtAbuelaMaternaOtrasCausas.Text.Length
            Cadena = txtAbuelaMaternaOtrasCausas.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtAbuelaMaternaOtrasCausas.Text = Cadena
            Else
                txtAbuelaMaternaOtrasCausas.Text = Cadena
            End If
        Else
            txtAbuelaMaternaOtrasCausas.Text = ""
        End If
    End Sub

    Private Sub txtAbuelaMaternaOtrosAnt_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtAbuelaMaternaOtrosAnt.leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtAbuelaMaternaOtrosAnt.Text <> "" Then
            LargoCadena = txtAbuelaMaternaOtrosAnt.Text.Length
            Cadena = txtAbuelaMaternaOtrosAnt.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtAbuelaMaternaOtrosAnt.Text = Cadena
            Else
                txtAbuelaMaternaOtrosAnt.Text = Cadena
            End If
        Else
            txtAbuelaMaternaOtrosAnt.Text = ""
        End If
    End Sub

    Private Sub radMuerteAbuelaMaterna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbuelaMaterna01.CheckedChanged, radAbuelaMaterna02.CheckedChanged, _
                radAbuelaMaterna03.CheckedChanged, radAbuelaMaterna04.CheckedChanged, _
                radAbuelaMaterna05.CheckedChanged, radAbuelaMaterna06.CheckedChanged, _
                radAbuelaMaterna07.CheckedChanged, radAbuelaMaterna08.CheckedChanged, _
                radAbuelaMaternaDesconoceCausa.CheckedChanged

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub


    '0000000000000000

    'PARTE DE LA AbueloMaterno
    Private Sub AbueloMaternoBorraAntecedentes()
        'borra chkbox
        chkAbueloMaterno01.Checked = False
        chkAbueloMaterno02.Checked = False
        chkAbueloMaterno03.Checked = False
        chkAbueloMaterno04.Checked = False
        chkAbueloMaterno05.Checked = False
        chkAbueloMaterno06.Checked = False
        chkAbueloMaterno07.Checked = False
        chkAbueloMaternoOtros.Checked = False
        txtAbueloMaternoOtrosAnt.Clear()
        'borra estructura
        'Antecedentes.AbueloMaternoCHK01 = "0"
        'Antecedentes.AbueloMaternoCHK02 = "0"
        'Antecedentes.AbueloMaternoCHK03 = "0"
        'Antecedentes.AbueloMaternoCHK04 = "0"
        'Antecedentes.AbueloMaternoCHK05 = "0"
        'Antecedentes.AbueloMaternoCHK06 = "0"
        'Antecedentes.AbueloMaternoCHK07 = "0"
        'Antecedentes.AbueloMaternoCHK08 = "0"
        'Antecedentes.AbueloMaternoOtrosAntecedentes = ""
    End Sub

    Private Sub AbueloMaternoApagaAntecedentes()
        chkAbueloMaterno01.Enabled = False
        chkAbueloMaterno02.Enabled = False
        chkAbueloMaterno03.Enabled = False
        chkAbueloMaterno04.Enabled = False
        chkAbueloMaterno05.Enabled = False
        chkAbueloMaterno06.Enabled = False
        chkAbueloMaterno07.Enabled = False
        chkAbueloMaternoOtros.Enabled = False
        txtAbueloMaternoOtrosAnt.Enabled = False
    End Sub

    Private Sub AbueloMaternoEnciendeAntecedentes()
        chkAbueloMaterno01.Enabled = True
        chkAbueloMaterno02.Enabled = True
        chkAbueloMaterno03.Enabled = True
        chkAbueloMaterno04.Enabled = True
        chkAbueloMaterno05.Enabled = True
        chkAbueloMaterno06.Enabled = True
        chkAbueloMaterno07.Enabled = True
        chkAbueloMaternoOtros.Enabled = True
    End Sub

    Private Sub AbueloMaternoBorraCausas()
        radAbueloMaterno01.Checked = False
        radAbueloMaterno02.Checked = False
        radAbueloMaterno03.Checked = False
        radAbueloMaterno04.Checked = False
        radAbueloMaterno05.Checked = False
        radAbueloMaterno06.Checked = False
        radAbueloMaterno07.Checked = False
        radAbueloMaterno08.Checked = False
        radAbueloMaternoDesconoceCausa.Checked = False
        radAbueloMaternoOtrasCausas.Checked = False
        txtAbueloMaternoOtrasCausas.Clear()
    End Sub

    Private Sub radAbueloMaternoVivaMuertaoDesconoce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbueloMaternoViva.CheckedChanged, radAbueloMaternoMuerta.CheckedChanged, _
                radAbueloMaternoDesconoce.CheckedChanged
        If radAbueloMaternoViva.Checked = True Then
            'borra y despues apaga la parte de fallecimiento
            AbueloMaternoBorraCausas()
            GBAbueloMaternoCausaMuerte.Enabled = False
            'borra y enciende el GBox de antecedentes
            GBAbueloMaternoAntecedentes.Enabled = True
            AbueloMaternoApagaAntecedentes()
            'pone inicialmente negando antecedentes
            'radAbueloMaternoTieneAnt.Checked = True
        End If

        If radAbueloMaternoMuerta.Checked = True Then
            'borra y enciende el GBox de antecedentes
            AbueloMaternoApagaAntecedentes()
            GBAbueloMaternoAntecedentes.Enabled = True
            'radAbueloMaternoTieneAnt.Checked = True
            'efectos sobre las causas de muerte
            AbueloMaternoBorraCausas()
            GBAbueloMaternoCausaMuerte.Enabled = True
            'radAbueloMaternoDesconoceCausa.Checked = True
        End If

        If radAbueloMaternoDesconoce.Checked = True Then
            AbueloMaternoBorraAntecedentes()
            AbueloMaternoApagaAntecedentes()
            AbueloMaternoBorraCausas()
            GBAbueloMaternoAntecedentes.Enabled = False
            GBAbueloMaternoCausaMuerte.Enabled = False
            'borra los rad buttons
            radAbueloMaternoNiega.Checked = False
            radAbueloMaternoTieneAnt.Checked = False
            radAbueloMaternoDesconocePatologia.Checked = False
        End If

        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If

    End Sub

    'activa o no el cuadro de otros antecedentes
    Private Sub chkAbueloMaternoOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAbueloMaternoOtros.CheckedChanged
        If chkAbueloMaternoOtros.Checked = True Then
            txtAbueloMaternoOtrosAnt.Enabled = True
            txtAbueloMaternoOtrosAnt.Focus()
        Else
            txtAbueloMaternoOtrosAnt.Clear()
            txtAbueloMaternoOtrosAnt.Enabled = False
        End If

        'revisa si se produjo un cambio
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radAbueloMaternoNiegaoDesconoceANT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbueloMaternoNiega.CheckedChanged, radAbueloMaternoDesconocePatologia.CheckedChanged

        If radAbueloMaternoNiega.Checked = True Or radAbueloMaternoDesconocePatologia.Checked = True Then
            AbueloMaternoBorraAntecedentes()
            AbueloMaternoApagaAntecedentes()
        End If

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub radAbueloMaternoTieneAnt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAbueloMaternoTieneAnt.CheckedChanged
        If radAbueloMaternoTieneAnt.Checked = True Then
            AbueloMaternoEnciendeAntecedentes()
        End If
    End Sub

    Private Sub radAbueloMaternoOtrasCausas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAbueloMaternoOtrasCausas.CheckedChanged
        If radAbueloMaternoOtrasCausas.Checked = True Then
            txtAbueloMaternoOtrasCausas.Enabled = True
            txtAbueloMaternoOtrasCausas.Focus()
        Else
            txtAbueloMaternoOtrasCausas.Clear()
            txtAbueloMaternoOtrasCausas.Enabled = False
        End If
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkAntecedentesAbueloMaterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles chkAbueloMaterno01.CheckedChanged, chkAbueloMaterno02.CheckedChanged, _
                chkAbueloMaterno03.CheckedChanged, chkAbueloMaterno04.CheckedChanged, _
                chkAbueloMaterno05.CheckedChanged, chkAbueloMaterno06.CheckedChanged, _
                chkAbueloMaterno07.CheckedChanged
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub txtAbueloMaternoTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txtAbueloMaternoOtrosAnt.KeyPress, txtAbueloMaternoOtrasCausas.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'revisa si se produjo un cambio por primera vez
                If SePoducieronCambios = False Then
                    SeProdujoUnCambio()
                End If
            End If

        End If
    End Sub

    Private Sub txtAbueloMaternoOtrasCausas_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtAbueloMaternoOtrasCausas.leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtAbueloMaternoOtrasCausas.Text <> "" Then
            LargoCadena = txtAbueloMaternoOtrasCausas.Text.Length
            Cadena = txtAbueloMaternoOtrasCausas.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtAbueloMaternoOtrasCausas.Text = Cadena
            Else
                txtAbueloMaternoOtrasCausas.Text = Cadena
            End If
        Else
            txtAbueloMaternoOtrasCausas.Text = ""
        End If
    End Sub

    Private Sub txtAbueloMaternoOtrosAnt_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtAbueloMaternoOtrosAnt.Leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtAbueloMaternoOtrosAnt.Text <> "" Then
            LargoCadena = txtAbueloMaternoOtrosAnt.Text.Length
            Cadena = txtAbueloMaternoOtrosAnt.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtAbueloMaternoOtrosAnt.Text = Cadena
            Else
                txtAbueloMaternoOtrosAnt.Text = Cadena
            End If
        Else
            txtAbueloMaternoOtrosAnt.Text = ""
        End If
    End Sub

    Private Sub radMuerteAbueloMaterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radAbueloMaterno01.CheckedChanged, radAbueloMaterno02.CheckedChanged, _
                radAbueloMaterno03.CheckedChanged, radAbueloMaterno04.CheckedChanged, _
                radAbueloMaterno05.CheckedChanged, radAbueloMaterno06.CheckedChanged, _
                radAbueloMaterno07.CheckedChanged, radAbueloMaterno08.CheckedChanged, _
                radAbueloPaternoDesconoceCausa.CheckedChanged

        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    '000000000000000000000000000000000

    'PARTE DE Los hermanos
    Private Sub HermanosBorraAntecedentes()
        'borra chkbox
        chkHermanos01.Checked = False
        chkHermanos02.Checked = False
        chkHermanos03.Checked = False
        chkHermanos04.Checked = False
        chkHermanos05.Checked = False
        chkHermanos06.Checked = False
        chkHermanos07.Checked = False
        chkHermanos08.Checked = False
        txtHermanosOtrosAnt.Clear()
        'borra estructura
        'Antecedentes.HermanosCHK01 = "0"
        'Antecedentes.HermanosCHK02 = "0"
        'Antecedentes.HermanosCHK03 = "0"
        'Antecedentes.HermanosCHK04 = "0"
        'Antecedentes.HermanosCHK05 = "0"
        'Antecedentes.HermanosCHK06 = "0"
        'Antecedentes.HermanosCHK07 = "0"
        'Antecedentes.HermanosCHK08 = "0"
        'Antecedentes.HermanosOtrosAntecedentes = ""
    End Sub

    Private Sub HermanosBorraCausas()
        chkHermanosMuertos01.Checked = False
        chkHermanosMuertos02.Checked = False
        chkHermanosMuertos03.Checked = False
        chkHermanosMuertos04.Checked = False
        chkHermanosMuertos05.Checked = False
        chkHermanosMuertos06.Checked = False
        chkHermanosMuertos07.Checked = False
        chkHermanosMuertos08.Checked = False
        chkHermanosMuertos09.Checked = False
        txtHermanosMuertosOtrasCausas.Clear()
        'borra estructura
        'Antecedentes.HermanosMuertosCHK01 = "0"
        'Antecedentes.HermanosMuertosCHK02 = "0"
        'Antecedentes.HermanosMuertosCHK03 = "0"
        'Antecedentes.HermanosMuertosCHK04 = "0"
        'Antecedentes.HermanosMuertosCHK05 = "0"
        'Antecedentes.HermanosMuertosCHK06 = "0"
        'Antecedentes.HermanosMuertosCHK07 = "0"
        'Antecedentes.HermanosMuertosCHK08 = "0"
        'Antecedentes.HermanosOtrasCausasMuerte = ""
    End Sub

    Private Sub chkAntecedentesHermanos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles chkHermanos01.CheckedChanged, chkHermanos02.CheckedChanged, _
              chkHermanos03.CheckedChanged, chkHermanos04.CheckedChanged, _
              chkHermanos05.CheckedChanged, chkHermanos06.CheckedChanged, _
              chkHermanos07.CheckedChanged
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkOtrosAntecedentesHermanos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles chkHermanos08.CheckedChanged
        If chkHermanos08.Checked = True Then
            txtHermanosOtrosAnt.Enabled = True
        Else
            txtHermanosOtrosAnt.Enabled = False
            txtHermanosOtrosAnt.Clear()
        End If
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkMuertesHermanos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles chkHermanosMuertos01.CheckedChanged, chkHermanosMuertos02.CheckedChanged, _
              chkHermanosMuertos03.CheckedChanged, chkHermanosMuertos04.CheckedChanged, _
              chkHermanosMuertos05.CheckedChanged, chkHermanosMuertos06.CheckedChanged, _
              chkHermanosMuertos07.CheckedChanged, chkHermanosMuertos08.CheckedChanged
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkOtrasMuertesHermanos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles chkHermanosMuertos08.CheckedChanged
        If chkHermanosMuertos08.Checked = True Then
            txtHermanosMuertosOtrasCausas.Enabled = True
        Else
            txtHermanosMuertosOtrasCausas.Enabled = False
            txtHermanosMuertosOtrasCausas.Clear()
        End If
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub txtHermanosTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
           Handles txtHermanosOtrosAnt.KeyPress, txtHermanosMuertosOtrasCausas.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'revisa si se produjo un cambio por primera vez
                If SePoducieronCambios = False Then
                    SeProdujoUnCambio()
                End If
            End If

        End If
    End Sub

    Private Sub txtHermanosOtrasCausas_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtHermanosMuertosOtrasCausas.leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtHermanosMuertosOtrasCausas.Text <> "" Then
            LargoCadena = txtHermanosMuertosOtrasCausas.Text.Length
            Cadena = txtHermanosMuertosOtrasCausas.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtHermanosMuertosOtrasCausas.Text = Cadena
            Else
                txtHermanosMuertosOtrasCausas.Text = Cadena
            End If
        Else
            txtHermanosMuertosOtrasCausas.Text = ""
        End If
    End Sub

    Private Sub txtHermanosOtrosAnt_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtHermanosOtrosAnt.Leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtHermanosOtrosAnt.Text <> "" Then
            LargoCadena = txtHermanosOtrosAnt.Text.Length
            Cadena = txtHermanosOtrosAnt.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtHermanosOtrosAnt.Text = Cadena
            Else
                txtHermanosOtrosAnt.Text = Cadena
            End If
        Else
            txtHermanosOtrosAnt.Text = ""
        End If
    End Sub

    '000000000000000000000000000000000

    'PARTE DE Los Tios
    Private Sub TiosBorraAntecedentes()
        'borra chkbox
        chkTios01.Checked = False
        chkTios02.Checked = False
        chkTios03.Checked = False
        chkTios04.Checked = False
        chkTios05.Checked = False
        chkTios06.Checked = False
        chkTios07.Checked = False
        chkTios08.Checked = False
        txtTiosOtrosAnt.Clear()
    End Sub

    Private Sub TiosBorraCausas()
        chkTiosMuertos01.Checked = False
        chkTiosMuertos02.Checked = False
        chkTiosMuertos03.Checked = False
        chkTiosMuertos04.Checked = False
        chkTiosMuertos05.Checked = False
        chkTiosMuertos06.Checked = False
        chkTiosMuertos07.Checked = False
        chkTiosMuertos08.Checked = False
        chkTiosMuertos09.Checked = False
        txtTiosMuertosOtrasCausas.Clear()
    End Sub

    Private Sub chkAntecedentesTios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles chkTios01.CheckedChanged, chkTios02.CheckedChanged, _
              chkTios03.CheckedChanged, chkTios04.CheckedChanged, _
              chkTios05.CheckedChanged, chkTios06.CheckedChanged, _
              chkTios07.CheckedChanged
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkOtrosAntecedentesTios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles chkTios08.CheckedChanged
        If chkTios08.Checked = True Then
            txtTiosOtrosAnt.Enabled = True
        Else
            txtTiosOtrosAnt.Enabled = False
            txtTiosOtrosAnt.Clear()
        End If
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkMuertesTios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles chkTiosMuertos01.CheckedChanged, chkTiosMuertos02.CheckedChanged, _
              chkTiosMuertos03.CheckedChanged, chkTiosMuertos04.CheckedChanged, _
              chkTiosMuertos05.CheckedChanged, chkTiosMuertos06.CheckedChanged, _
              chkTiosMuertos07.CheckedChanged, chkTiosMuertos08.CheckedChanged
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub chkOtrasMuertesTios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles chkTiosMuertos08.CheckedChanged
        If chkTiosMuertos08.Checked = True Then
            txtTiosMuertosOtrasCausas.Enabled = True
        Else
            txtTiosMuertosOtrasCausas.Enabled = False
            txtTiosMuertosOtrasCausas.Clear()
        End If
        'revisa si se produjo un cambio por primera vez
        If SePoducieronCambios = False Then
            SeProdujoUnCambio()
        End If
    End Sub

    Private Sub txtTiosTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
          Handles txtTiosOtrosAnt.KeyPress, txtTiosMuertosOtrasCausas.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'revisa si se produjo un cambio por primera vez
                If SePoducieronCambios = False Then
                    SeProdujoUnCambio()
                End If
            End If

        End If
    End Sub

    Private Sub txtTiosOtrasCausas_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtTiosMuertosOtrasCausas.leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtTiosMuertosOtrasCausas.Text <> "" Then
            LargoCadena = txtTiosMuertosOtrasCausas.Text.Length
            Cadena = txtTiosMuertosOtrasCausas.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtTiosMuertosOtrasCausas.Text = Cadena
            Else
                txtTiosMuertosOtrasCausas.Text = Cadena
            End If
        Else
            txtTiosMuertosOtrasCausas.Text = ""
        End If
    End Sub

    Private Sub txtTiosOtrosAnt_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtTiosOtrosAnt.Leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtTiosOtrosAnt.Text <> "" Then
            LargoCadena = txtTiosOtrosAnt.Text.Length
            Cadena = txtTiosOtrosAnt.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtTiosOtrosAnt.Text = Cadena
            Else
                txtTiosOtrosAnt.Text = Cadena
            End If
        Else
            txtTiosOtrosAnt.Text = ""
        End If
    End Sub

    '000000000000000
    'otros familiares

    Private Sub txtOtrosFamiliaresTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
      Handles txtOtrosFamiliares.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsPunctuation(c) Or Char.IsSymbol(c) Or c = " ") Then
            e.Handled = True
        Else
            If c = "|" Or c = "@" Or c = "€" Then
                e.Handled = True
            Else
                'revisa si se produjo un cambio por primera vez
                If SePoducieronCambios = False Then
                    SeProdujoUnCambio()
                End If
            End If

        End If
    End Sub

    Private Sub txtOtrosFamiliares_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtOtrosFamiliares.leave

        Dim UltimoCaracter As Char
        Dim LargoCadena As Integer
        Dim Cadena As String

        If txtOtrosFamiliares.Text <> "" Then
            LargoCadena = txtOtrosFamiliares.Text.Length
            Cadena = txtOtrosFamiliares.Text
            UltimoCaracter = Cadena.Chars(LargoCadena - 1)
            If UltimoCaracter = "." Then
                Cadena = Cadena.Remove(LargoCadena - 1, 1)
                txtOtrosFamiliares.Text = Cadena
            Else
                txtOtrosFamiliares.Text = Cadena
            End If
        Else
            txtOtrosFamiliares.Text = ""
        End If
    End Sub




    'EVENTOS DE LOS BOTONES CON EL MOUSE
    Private Sub botACEPTAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseEnter
        botAceptar.Image = BotonOnGrande
    End Sub
    Private Sub botACEPTAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botAceptar.MouseLeave
        botAceptar.Image = BotonOffGrande
    End Sub

    Private Sub botCANCELAR_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseEnter
        botCancelar.Image = BotonOnGrande
    End Sub
    Private Sub botCANCELAR_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botCancelar.MouseLeave
        botCancelar.Image = BotonOffGrande
    End Sub










End Class
