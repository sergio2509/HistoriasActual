Imports System.IO

Public Class FormNuevoInformeEcografico
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
    Friend WithEvents txtFechaInicioControl As System.Windows.Forms.TextBox
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFUR01 As System.Windows.Forms.TextBox
    Friend WithEvents botFUR01 As System.Windows.Forms.Button
    Friend WithEvents radMenopausia As System.Windows.Forms.RadioButton
    Friend WithEvents radVeReglas As System.Windows.Forms.RadioButton
    Friend WithEvents txtFUR02 As System.Windows.Forms.TextBox
    Friend WithEvents botFUR02 As System.Windows.Forms.Button
    Friend WithEvents radDesconoceFUR As System.Windows.Forms.RadioButton
    Friend WithEvents radConoceFUR As System.Windows.Forms.RadioButton
    Friend WithEvents radObstetrico As System.Windows.Forms.RadioButton
    Friend WithEvents radGinecologico As System.Windows.Forms.RadioButton
    Friend WithEvents radECO2y3erT As System.Windows.Forms.RadioButton
    Friend WithEvents radECO1erT As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents labEjemplo As System.Windows.Forms.Label
    Friend WithEvents GBginecologico As System.Windows.Forms.GroupBox
    Friend WithEvents GBobstetrico As System.Windows.Forms.GroupBox
    Friend WithEvents PanelTrimestre As System.Windows.Forms.Panel
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormNuevoInformeEcografico))
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.txtFechaInicioControl = New System.Windows.Forms.TextBox()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.GBginecologico = New System.Windows.Forms.GroupBox()
        Me.txtFUR01 = New System.Windows.Forms.TextBox()
        Me.botFUR01 = New System.Windows.Forms.Button()
        Me.radMenopausia = New System.Windows.Forms.RadioButton()
        Me.radVeReglas = New System.Windows.Forms.RadioButton()
        Me.GBobstetrico = New System.Windows.Forms.GroupBox()
        Me.PanelTrimestre = New System.Windows.Forms.Panel()
        Me.radECO2y3erT = New System.Windows.Forms.RadioButton()
        Me.radECO1erT = New System.Windows.Forms.RadioButton()
        Me.txtFUR02 = New System.Windows.Forms.TextBox()
        Me.botFUR02 = New System.Windows.Forms.Button()
        Me.radDesconoceFUR = New System.Windows.Forms.RadioButton()
        Me.radConoceFUR = New System.Windows.Forms.RadioButton()
        Me.radObstetrico = New System.Windows.Forms.RadioButton()
        Me.radGinecologico = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.labEjemplo = New System.Windows.Forms.Label()
        Me.GBginecologico.SuspendLayout()
        Me.GBobstetrico.SuspendLayout()
        Me.PanelTrimestre.SuspendLayout()
        Me.SuspendLayout()
        '
        'botCancelar
        '
        Me.botCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Bitmap)
        Me.botCancelar.Location = New System.Drawing.Point(8, 252)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(224, 23)
        Me.botCancelar.TabIndex = 3
        Me.botCancelar.Text = "Cancelar"
        '
        'botAceptar
        '
        Me.botAceptar.Enabled = False
        Me.botAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botAceptar.Image = CType(resources.GetObject("botAceptar.Image"), System.Drawing.Bitmap)
        Me.botAceptar.Location = New System.Drawing.Point(264, 252)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(224, 23)
        Me.botAceptar.TabIndex = 4
        Me.botAceptar.Text = "Aceptar"
        '
        'txtFechaInicioControl
        '
        Me.txtFechaInicioControl.BackColor = System.Drawing.SystemColors.Info
        Me.txtFechaInicioControl.Location = New System.Drawing.Point(252, 8)
        Me.txtFechaInicioControl.Name = "txtFechaInicioControl"
        Me.txtFechaInicioControl.ReadOnly = True
        Me.txtFechaInicioControl.Size = New System.Drawing.Size(240, 20)
        Me.txtFechaInicioControl.TabIndex = 9
        Me.txtFechaInicioControl.TabStop = False
        Me.txtFechaInicioControl.Text = ""
        '
        'Label108
        '
        Me.Label108.Location = New System.Drawing.Point(4, 8)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(244, 23)
        Me.Label108.TabIndex = 8
        Me.Label108.Text = "Día seleccionado para la Creación del Informe :"
        Me.Label108.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GBginecologico
        '
        Me.GBginecologico.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtFUR01, Me.botFUR01, Me.radMenopausia, Me.radVeReglas})
        Me.GBginecologico.Location = New System.Drawing.Point(4, 56)
        Me.GBginecologico.Name = "GBginecologico"
        Me.GBginecologico.Size = New System.Drawing.Size(244, 136)
        Me.GBginecologico.TabIndex = 10
        Me.GBginecologico.TabStop = False
        '
        'txtFUR01
        '
        Me.txtFUR01.BackColor = System.Drawing.SystemColors.Info
        Me.txtFUR01.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtFUR01.Location = New System.Drawing.Point(8, 72)
        Me.txtFUR01.Name = "txtFUR01"
        Me.txtFUR01.ReadOnly = True
        Me.txtFUR01.Size = New System.Drawing.Size(224, 20)
        Me.txtFUR01.TabIndex = 3
        Me.txtFUR01.Text = ""
        '
        'botFUR01
        '
        Me.botFUR01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR01.Image = CType(resources.GetObject("botFUR01.Image"), System.Drawing.Bitmap)
        Me.botFUR01.Location = New System.Drawing.Point(8, 48)
        Me.botFUR01.Name = "botFUR01"
        Me.botFUR01.Size = New System.Drawing.Size(224, 23)
        Me.botFUR01.TabIndex = 2
        Me.botFUR01.Text = "FUR"
        '
        'radMenopausia
        '
        Me.radMenopausia.Location = New System.Drawing.Point(132, 16)
        Me.radMenopausia.Name = "radMenopausia"
        Me.radMenopausia.TabIndex = 1
        Me.radMenopausia.Text = "Menopáusica"
        '
        'radVeReglas
        '
        Me.radVeReglas.Location = New System.Drawing.Point(8, 16)
        Me.radVeReglas.Name = "radVeReglas"
        Me.radVeReglas.TabIndex = 0
        Me.radVeReglas.Text = "Ve Reglas"
        '
        'GBobstetrico
        '
        Me.GBobstetrico.Controls.AddRange(New System.Windows.Forms.Control() {Me.PanelTrimestre, Me.txtFUR02, Me.botFUR02, Me.radDesconoceFUR, Me.radConoceFUR})
        Me.GBobstetrico.Location = New System.Drawing.Point(248, 56)
        Me.GBobstetrico.Name = "GBobstetrico"
        Me.GBobstetrico.Size = New System.Drawing.Size(244, 136)
        Me.GBobstetrico.TabIndex = 11
        Me.GBobstetrico.TabStop = False
        '
        'PanelTrimestre
        '
        Me.PanelTrimestre.Controls.AddRange(New System.Windows.Forms.Control() {Me.radECO2y3erT, Me.radECO1erT})
        Me.PanelTrimestre.Location = New System.Drawing.Point(4, 96)
        Me.PanelTrimestre.Name = "PanelTrimestre"
        Me.PanelTrimestre.Size = New System.Drawing.Size(236, 32)
        Me.PanelTrimestre.TabIndex = 8
        '
        'radECO2y3erT
        '
        Me.radECO2y3erT.Location = New System.Drawing.Point(104, 4)
        Me.radECO2y3erT.Name = "radECO2y3erT"
        Me.radECO2y3erT.Size = New System.Drawing.Size(124, 24)
        Me.radECO2y3erT.TabIndex = 8
        Me.radECO2y3erT.Text = "ECO 2do y 3er Trim"
        '
        'radECO1erT
        '
        Me.radECO1erT.Location = New System.Drawing.Point(8, 4)
        Me.radECO1erT.Name = "radECO1erT"
        Me.radECO1erT.Size = New System.Drawing.Size(92, 24)
        Me.radECO1erT.TabIndex = 7
        Me.radECO1erT.Text = "ECO 1er Trim"
        '
        'txtFUR02
        '
        Me.txtFUR02.BackColor = System.Drawing.SystemColors.Info
        Me.txtFUR02.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtFUR02.Location = New System.Drawing.Point(8, 72)
        Me.txtFUR02.Name = "txtFUR02"
        Me.txtFUR02.ReadOnly = True
        Me.txtFUR02.Size = New System.Drawing.Size(224, 20)
        Me.txtFUR02.TabIndex = 7
        Me.txtFUR02.Text = ""
        '
        'botFUR02
        '
        Me.botFUR02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR02.Image = CType(resources.GetObject("botFUR02.Image"), System.Drawing.Bitmap)
        Me.botFUR02.Location = New System.Drawing.Point(8, 48)
        Me.botFUR02.Name = "botFUR02"
        Me.botFUR02.Size = New System.Drawing.Size(224, 23)
        Me.botFUR02.TabIndex = 6
        Me.botFUR02.Text = "FUR"
        '
        'radDesconoceFUR
        '
        Me.radDesconoceFUR.Location = New System.Drawing.Point(132, 16)
        Me.radDesconoceFUR.Name = "radDesconoceFUR"
        Me.radDesconoceFUR.TabIndex = 5
        Me.radDesconoceFUR.Text = "Desconce FUR"
        '
        'radConoceFUR
        '
        Me.radConoceFUR.Location = New System.Drawing.Point(8, 16)
        Me.radConoceFUR.Name = "radConoceFUR"
        Me.radConoceFUR.TabIndex = 4
        Me.radConoceFUR.Text = "Conoce FUR"
        '
        'radObstetrico
        '
        Me.radObstetrico.Location = New System.Drawing.Point(252, 36)
        Me.radObstetrico.Name = "radObstetrico"
        Me.radObstetrico.Size = New System.Drawing.Size(144, 24)
        Me.radObstetrico.TabIndex = 12
        Me.radObstetrico.Text = "Informe Obstétrico"
        '
        'radGinecologico
        '
        Me.radGinecologico.Location = New System.Drawing.Point(12, 36)
        Me.radGinecologico.Name = "radGinecologico"
        Me.radGinecologico.Size = New System.Drawing.Size(144, 24)
        Me.radGinecologico.TabIndex = 13
        Me.radGinecologico.Text = "Informe Ginecológico"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre descriptivo del Informe :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(204, 196)
        Me.txtNombre.MaxLength = 35
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(244, 20)
        Me.txtNombre.TabIndex = 15
        Me.txtNombre.Text = ""
        '
        'labEjemplo
        '
        Me.labEjemplo.Image = CType(resources.GetObject("labEjemplo.Image"), System.Drawing.Bitmap)
        Me.labEjemplo.Location = New System.Drawing.Point(4, 224)
        Me.labEjemplo.Name = "labEjemplo"
        Me.labEjemplo.Size = New System.Drawing.Size(488, 23)
        Me.labEjemplo.TabIndex = 16
        Me.labEjemplo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormNuevoInformeEcografico
        '
        Me.AcceptButton = Me.botAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.botCancelar
        Me.ClientSize = New System.Drawing.Size(498, 280)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.labEjemplo, Me.txtNombre, Me.Label1, Me.radGinecologico, Me.radObstetrico, Me.GBobstetrico, Me.GBginecologico, Me.txtFechaInicioControl, Me.Label108, Me.botCancelar, Me.botAceptar})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormNuevoInformeEcografico"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Informe Ecográfico"
        Me.GBginecologico.ResumeLayout(False)
        Me.GBobstetrico.ResumeLayout(False)
        Me.PanelTrimestre.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim FechaDelInforme As Date
    Dim FURcheck As Date

    Dim TipoInf As String
    Dim VeReglas As Boolean
    Dim ConoceFUR As Boolean
    Dim FUR As Date
    Dim Trimestre As String
    Dim Nombre As String

    'variables de imagen para los botones
    Dim BotonOn As Image
    Dim BotonOff As Image
    Dim BotonOnGrande As Image
    Dim BotonOffGrande As Image

    'para la parte de cargar ant obs
    Dim fileAntObstetricos As String

    Dim R As Form1.TablaDeAntecedentesObstetricos

    Dim NumeroGestaciones As Integer = 0
    Dim NumeroAbortos As Integer = 0
    Dim NumeroPartos As Integer = 0
    Dim NumeroCesareas As Integer = 0
    Dim NumeroEctopicos As Integer = 0

    Dim strGesta As String = ""
    Dim strPara As String = ""
    Dim strCesa As String = ""
    Dim strAbo As String = ""
    Dim strEcto As String = ""

    Dim intSemanas As Integer = 0
    Dim strSemanas As String = ""

    Public Shared strParidad As String = ""




    Private Sub FormNuevoInformeEcografico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BotonOnGrande = Form1.BotonOnGrande
        BotonOffGrande = Form1.BotonOffGrande
        BotonOn = Form1.BotonOn
        BotonOff = Form1.BotonOff

        FechaDelInforme = Form1.FechaSeleccionada
        txtFechaInicioControl.Text = FechaDelInforme.ToLongDateString
        txtNombre.Enabled = False
        ApagaObstetrico()
        ApagaGinecologico()
        ProcesaEjemplo()
    End Sub


    Private Sub botCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub EnciendeGinecologico()
        GBginecologico.Enabled = True
    End Sub

    Private Sub EnciendeObstetrico()
        GBobstetrico.Enabled = True
    End Sub

    Private Sub ApagaGinecologico()
        GBginecologico.Enabled = False
        radVeReglas.Checked = False
        radMenopausia.Checked = False
        botFUR01.Enabled = False
        txtFUR01.Clear()
    End Sub

    Private Sub ApagaObstetrico()
        GBobstetrico.Enabled = False
        radConoceFUR.Checked = False
        radDesconoceFUR.Checked = False
        botFUR02.Enabled = False
        txtFUR02.Clear()
        PanelTrimestre.Enabled = False
        radECO1erT.Checked = False
        radECO2y3erT.Checked = False
    End Sub


    Private Sub radTIPOdeINFORME_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radGinecologico.CheckedChanged, radObstetrico.CheckedChanged

        If radGinecologico.Checked = True Then
            EnciendeGinecologico()
            ApagaObstetrico()
            TipoInf = "GIN"
        End If

        If radObstetrico.Checked = True Then
            EnciendeObstetrico()
            ApagaGinecologico()
            TipoInf = "OBS"
        End If

        ProcesaEjemplo()

    End Sub

    Private Sub radREGLA_si_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radVeReglas.CheckedChanged, radMenopausia.CheckedChanged

        'inicializa
        VeReglas = False

        If radVeReglas.Checked = True Then
            botFUR01.Enabled = True
            VeReglas = True
        End If

        If radMenopausia.Checked = True Then
            botFUR01.Enabled = False
            txtFUR01.Clear()
            VeReglas = False
        End If

        ProcesaEjemplo()
    End Sub

    Private Sub radCONOCE_FUR_si_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radConoceFUR.CheckedChanged, radDesconoceFUR.CheckedChanged

        'inicializa
        ConoceFUR = False

        If radConoceFUR.Checked = True Then
            botFUR02.Enabled = True
            PanelTrimestre.Enabled = False
            radECO1erT.Checked = False
            radECO2y3erT.Checked = False
            ConoceFUR = True
        End If

        If radDesconoceFUR.Checked = True Then
            botFUR02.Enabled = False
            txtFUR02.Clear()
            PanelTrimestre.Enabled = True
            ConoceFUR = False
        End If

        ProcesaEjemplo()

    End Sub

    Private Sub radECOdelTrimestre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radECO1erT.CheckedChanged, radECO2y3erT.CheckedChanged

        'inicializa
        Trimestre = ""

        If radECO1erT.Checked = True Then
            ProcesaEjemplo()
            Trimestre = "1er"
        End If

        If radECO2y3erT.Checked = True Then
            ProcesaEjemplo()
            Trimestre = "2y3er"
        End If

    End Sub

    Private Sub botFUR01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR01.Click
        Dim DLG As New FormEligeFecha()

        'inicializa()
        FUR = Nothing

        Form1.FechaSeleccionadaMensaje = "Selecciona la fecha de la última regla del Calendario..."

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            FURcheck = Form1.FechaSeleccionada

            If FURcheck > FechaDelInforme Then
                MsgBox("Seleccionaste una FUR que está después de la fecha seleccionada para el Informe", MsgBoxStyle.Information, "FUR invalida")
                txtFUR01.Clear()
            Else
                FUR = FURcheck
                txtFUR01.Text = FUR.ToLongDateString
            End If

        End If

        ProcesaEjemplo()

    End Sub

    Private Sub botFUR02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR02.Click
        Dim DLG As New FormEligeFecha()

        'inicializa()
        FUR = Nothing

        Form1.FechaSeleccionadaMensaje = "Selecciona la fecha de la última regla del Calendario..."

        Form1.booSeleccionandoFechaParaControlEcografico = True

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then

            FURcheck = Form1.FechaSeleccionada

            If FURcheck > FechaDelInforme Then
                MsgBox("Seleccionaste una FUR que está después de la fecha seleccionada para el Informe", MsgBoxStyle.Information, "FUR invalida")
                txtFUR02.Clear()
            Else
                FUR = FURcheck
                txtFUR02.Text = FUR.ToLongDateString
            End If

        End If

        'antes de pasar a procesar el ejemplo trata de tomar la paridad de los datos personales y pasarlo al text del nombre de informe
        fileAntObstetricos = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Ant Obstetricos.dat"

        'inicializa la cadena de paridad
        strParidad = ""
        Dim datFechaLimite As Date
        datFechaLimite = Today.AddDays(-315)

        If File.Exists(fileAntObstetricos) Then
            If File.GetLastWriteTime(fileAntObstetricos) < FUR Or FUR < datFechaLimite Then
                'la paridad no se ha modificado en el transcurso de este embarazo, no debe esta actualizada
                MsgBox("Los datos de paridad están desactualizados, actualízalos para generar automáticamente el nombre del informe de forma correcta...", MsgBoxStyle.Information, "Antecedentes Obstétricos Desactualizados")
                'deja en blanco el txt
            Else
                'los datos estan actualizados los carga
                CargaAntecedentesObstetricos()
                ActualizaDatosNumericosConLaEstructura()
                ConvierteDecimalParaRomano()

                'crea el string con los datos recopilados



                If strGesta <> "" Then
                    'tiene gestaciones
                    strParidad += strGesta & "G "
                    'ahora verifica los demas
                    If strPara <> "" Then
                        strParidad += strPara & "P "
                    End If
                    If strCesa <> "" Then
                        strParidad += strCesa & "C "
                    End If
                    If strAbo <> "" Then
                        strParidad += strAbo & "Ab "
                    End If
                    If strEcto <> "" Then
                        strParidad += strEcto & "Ec "
                    End If

                    'ahora saca la cuenta de las semanas de embarazo segun fur
                    Dim TiempoDeEmbarazo As TimeSpan

                    TiempoDeEmbarazo = FechaDelInforme - FUR

                    intSemanas = (TiempoDeEmbarazo.TotalDays \ 7)
                    strSemanas = " Embarazo de " & intSemanas.ToString & " semanas"

                    'finalmente muestra lo sugerido como nombre
                    txtNombre.Text = strParidad & strSemanas

                Else
                    'no tiene embarazo se debe haber actualizado pero no se metio el embarazo actual ? no hace na
                    MsgBox("La Paciente " & Form1.LabNombreSeleccionado.Text & " aparece como nuligesta según los antecedentes leídos. Verifícalos.", MsgBoxStyle.Information, "Verifica Antecedentes")
                End If


            End If

        Else
            'no tiene ant obstetricos lo dice
            MsgBox("La Paciente " & Form1.LabNombreSeleccionado.Text & " no tiene Antecedentes Obstétricos, introdúcelos cuando puedas...", MsgBoxStyle.Information, "Falta Antecedentes Obstétricos")
            'no hace nada sigue asi nada mas
        End If



        ProcesaEjemplo()


    End Sub

    Private Sub CargaAntecedentesObstetricos()
        Dim FS As FileStream
        Dim BR As BinaryReader

        FS = New FileStream(fileAntObstetricos, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim C As Integer
        C = BR.PeekChar
        While FS.Position < FS.Length
            R = Nothing
            ' Read fields and populate structure
            R.a01Gestas = BR.ReadString : R.a02Paras = BR.ReadString : R.a03Cesareas = BR.ReadString
            R.a04Abortos = BR.ReadString : R.a05Ectopicos = BR.ReadString : R.a06strNotas = BR.ReadString
            R.Dato006 = BR.ReadString : R.Dato007 = BR.ReadString : R.Dato008 = BR.ReadString
            R.Dato009 = BR.ReadString

            R.Dato010 = BR.ReadString : R.Dato011 = BR.ReadString : R.Dato012 = BR.ReadString
            R.Dato013 = BR.ReadString : R.Dato014 = BR.ReadString : R.Dato015 = BR.ReadString
            R.Dato016 = BR.ReadString : R.Dato017 = BR.ReadString : R.Dato018 = BR.ReadString
            R.Dato019 = BR.ReadString

            R.Dato020 = BR.ReadString : R.Dato021 = BR.ReadString : R.Dato022 = BR.ReadString
            R.Dato023 = BR.ReadString : R.Dato024 = BR.ReadString : R.Dato025 = BR.ReadString
            R.Dato026 = BR.ReadString : R.Dato027 = BR.ReadString : R.Dato028 = BR.ReadString
            R.Dato029 = BR.ReadString

            R.Dato030 = BR.ReadString : R.Dato031 = BR.ReadString : R.Dato032 = BR.ReadString
            R.Dato033 = BR.ReadString : R.Dato034 = BR.ReadString : R.Dato035 = BR.ReadString
            R.Dato036 = BR.ReadString : R.Dato037 = BR.ReadString : R.Dato038 = BR.ReadString
            R.Dato039 = BR.ReadString

            R.Dato040 = BR.ReadString : R.Dato041 = BR.ReadString : R.Dato042 = BR.ReadString
            R.Dato043 = BR.ReadString : R.Dato044peso01 = BR.ReadString : R.Dato045 = BR.ReadString
            R.Dato046 = BR.ReadString : R.Dato047 = BR.ReadString : R.Dato048 = BR.ReadString
            R.Dato049 = BR.ReadString

            R.Dato050 = BR.ReadString : R.Dato051 = BR.ReadString : R.Dato052 = BR.ReadString
            R.Dato053 = BR.ReadString : R.Dato054peso02 = BR.ReadString : R.Dato055 = BR.ReadString
            R.Dato056 = BR.ReadString : R.Dato057 = BR.ReadString : R.Dato058 = BR.ReadString
            R.Dato059 = BR.ReadString

            R.Dato060 = BR.ReadString : R.Dato061 = BR.ReadString : R.Dato062 = BR.ReadString
            R.Dato063 = BR.ReadString : R.Dato064peso03 = BR.ReadString : R.Dato065 = BR.ReadString
            R.Dato066 = BR.ReadString : R.Dato067 = BR.ReadString : R.Dato068 = BR.ReadString
            R.Dato069 = BR.ReadString

            R.Dato070 = BR.ReadString : R.Dato071 = BR.ReadString : R.Dato072 = BR.ReadString
            R.Dato073 = BR.ReadString : R.Dato074peso04 = BR.ReadString : R.Dato075 = BR.ReadString
            R.Dato076 = BR.ReadString : R.Dato077 = BR.ReadString : R.Dato078 = BR.ReadString
            R.Dato079 = BR.ReadString

            R.Dato080 = BR.ReadString : R.Dato081 = BR.ReadString : R.Dato082 = BR.ReadString
            R.Dato083 = BR.ReadString : R.Dato084peso05 = BR.ReadString : R.Dato085 = BR.ReadString
            R.Dato086 = BR.ReadString : R.Dato087 = BR.ReadString : R.Dato088 = BR.ReadString
            R.Dato089 = BR.ReadString

            R.Dato090 = BR.ReadString : R.Dato091 = BR.ReadString : R.Dato092 = BR.ReadString
            R.Dato093 = BR.ReadString : R.Dato094peso06 = BR.ReadString : R.Dato095 = BR.ReadString
            R.Dato096 = BR.ReadString : R.Dato097 = BR.ReadString : R.Dato098 = BR.ReadString
            R.Dato099 = BR.ReadString

            R.Dato100 = BR.ReadString : R.Dato101 = BR.ReadString : R.Dato102 = BR.ReadString
            R.Dato103 = BR.ReadString : R.Dato104peso07 = BR.ReadString : R.Dato105 = BR.ReadString
            R.Dato106 = BR.ReadString : R.Dato107 = BR.ReadString : R.Dato108 = BR.ReadString
            R.Dato109 = BR.ReadString

            R.Dato110 = BR.ReadString : R.Dato111 = BR.ReadString : R.Dato112 = BR.ReadString
            R.Dato113 = BR.ReadString : R.Dato114peso08 = BR.ReadString : R.Dato115 = BR.ReadString
            R.Dato116 = BR.ReadString : R.Dato117 = BR.ReadString : R.Dato118 = BR.ReadString
            R.Dato119 = BR.ReadString

            R.Dato120 = BR.ReadString : R.Dato121 = BR.ReadString : R.Dato122 = BR.ReadString
            R.Dato123 = BR.ReadString : R.Dato124peso09 = BR.ReadString : R.Dato125 = BR.ReadString
            R.Dato126 = BR.ReadString : R.Dato127 = BR.ReadString : R.Dato128 = BR.ReadString
            R.Dato129 = BR.ReadString

            R.Dato130 = BR.ReadString : R.Dato131 = BR.ReadString : R.Dato132 = BR.ReadString
            R.Dato133 = BR.ReadString : R.Dato134peso10 = BR.ReadString : R.Dato135 = BR.ReadString
            R.Dato136 = BR.ReadString : R.Dato137 = BR.ReadString : R.Dato138 = BR.ReadString
            R.Dato139 = BR.ReadString

            R.Dato140 = BR.ReadString : R.Dato141 = BR.ReadString : R.Dato142 = BR.ReadString
            R.Dato143 = BR.ReadString : R.Dato144 = BR.ReadString : R.Dato145 = BR.ReadString
            R.Dato146 = BR.ReadString : R.Dato147 = BR.ReadString : R.Dato148 = BR.ReadString
            R.Dato149 = BR.ReadString

            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()
    End Sub
    Private Sub ActualizaDatosNumericosConLaEstructura()
        'Panel Superior Izquierdo
        If R.a01Gestas = "" Then
            NumeroGestaciones = 0
        Else
            NumeroGestaciones = R.a01Gestas
        End If

        If R.a02Paras = "" Then
            NumeroPartos = 0
        Else
            NumeroPartos = R.a02Paras
        End If

        If R.a03Cesareas = "" Then
            NumeroCesareas = 0
        Else
            NumeroCesareas = R.a03Cesareas
        End If

        If R.a04Abortos = "" Then
            NumeroAbortos = 0
        Else
            NumeroAbortos = R.a04Abortos
        End If

        If R.a05Ectopicos = "" Then
            NumeroEctopicos = 0
        Else
            NumeroEctopicos = R.a05Ectopicos
        End If


    End Sub
    Private Sub ConvierteDecimalParaRomano()
        'panel superior derecho
        Select Case NumeroGestaciones
            Case 0
                strGesta = ""
            Case 1
                strGesta = "I"
            Case 2
                strGesta = "II"
            Case 3
                strGesta = "III"
            Case 4
                strGesta = "IV"
            Case 5
                strGesta = "V"
            Case 6
                strGesta = "VI"
            Case 7
                strGesta = "VII"
            Case 8
                strGesta = "VIII"
            Case 9
                strGesta = "IX"
            Case 10
                strGesta = "X"
        End Select

        Select Case NumeroPartos
            Case 0
                strPara = ""
            Case 1
                strPara = "I"
            Case 2
                strPara = "II"
            Case 3
                strPara = "III"
            Case 4
                strPara = "IV"
            Case 5
                strPara = "V"
            Case 6
                strPara = "VI"
            Case 7
                strPara = "VII"
            Case 8
                strPara = "VIII"
            Case 9
                strPara = "IX"
            Case 10
                strPara = "X"
        End Select

        Select Case NumeroCesareas
            Case 0
                strCesa = ""
            Case 1
                strCesa = "I"
            Case 2
                strCesa = "II"
            Case 3
                strCesa = "III"
            Case 4
                strCesa = "IV"
            Case 5
                strCesa = "V"
            Case 6
                strCesa = "VI"
            Case 7
                strCesa = "VII"
            Case 8
                strCesa = "VIII"
            Case 9
                strCesa = "IX"
            Case 10
                strCesa = "X"
        End Select

        Select Case NumeroAbortos
            Case 0
                strAbo = ""
            Case 1
                strAbo = "I"
            Case 2
                strAbo = "II"
            Case 3
                strAbo = "III"
            Case 4
                strAbo = "IV"
            Case 5
                strAbo = "V"
            Case 6
                strAbo = "VI"
            Case 7
                strAbo = "VII"
            Case 8
                strAbo = "VIII"
            Case 9
                strAbo = "IX"
            Case 10
                strAbo = "X"
        End Select

        Select Case NumeroEctopicos
            Case 0
                strEcto = ""
            Case 1
                strEcto = "I"
            Case 2
                strEcto = "II"
            Case 3
                strEcto = "III"
            Case 4
                strEcto = "IV"
            Case 5
                strEcto = "V"
            Case 6
                strEcto = "VI"
            Case 7
                strEcto = "VII"
            Case 8
                strEcto = "VIII"
            Case 9
                strEcto = "IX"
            Case 10
                strEcto = "X"
        End Select



    End Sub




    Private Sub txtNOMBRE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtNombre.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or Char.IsWhiteSpace(c) Or c = "+" Or c = "-" Or c = "/" Or c = "," Or c = "." Or c = "¿" Or c = "?" Or c = "(" Or c = ")") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        Nombre = txtNombre.Text
        ProcesaEjemplo()
    End Sub

    Private Sub ProcesaEjemplo()

        If radGinecologico.Checked = False And radObstetrico.Checked = False Then
            'se esta iniciando el procedimiento no se ha seleccionado el tipo de estudio
            labEjemplo.Text = "Selecciona el tipo de Informe Ecográfico..."
            txtNombre.Enabled = False
            txtNombre.Clear()
            botAceptar.Enabled = False

        ElseIf radGinecologico.Checked = True Then
            'se selecciono informe ginecologico
            If radVeReglas.Checked = False And radMenopausia.Checked = False Then
                'no se ha seleccionado si ve o no reglas
                labEjemplo.Text = "Señala si la Paciente ve reglas o está menopáusica..."
                txtNombre.Enabled = False
                txtNombre.Clear()
                botAceptar.Enabled = False
            ElseIf radVeReglas.Checked = True Then
                'la pte ve reglas, ve si ya se introdujo la FUR
                If txtFUR01.Text = "" Then
                    'no se ha seleccionado una fur, la pide
                    labEjemplo.Text = "Selecciona una FUR válida, presiona el Botón FUR..."
                    txtNombre.Enabled = False
                    txtNombre.Clear()
                    botAceptar.Enabled = False
                Else
                    'ya se selecciono una fur, prende el cuadro de nombre
                    'y revisa la descripcion introducida
                    txtNombre.Enabled = True
                    txtNombre.Focus()
                    If txtNombre.Text = "" Then
                        labEjemplo.Text = "Introduce una descripción del informe Ecográfico..."
                        botAceptar.Enabled = False
                    Else
                        labEjemplo.Text = "Actualmente: " & FechaDelInforme.ToShortDateString & "| (GIN) " & txtNombre.Text
                        botAceptar.Enabled = True
                    End If
                End If
            ElseIf radMenopausia.Checked = True Then
                'la paciente esta menopausica
                FUR = Nothing
                'revisa la descripcion
                txtNombre.Enabled = True
                txtNombre.Focus()
                If txtNombre.Text = "" Then
                    labEjemplo.Text = "Introduce una descripción del informe Ecográfico..."
                    botAceptar.Enabled = False
                Else
                    labEjemplo.Text = "Actualmente: " & FechaDelInforme.ToShortDateString & "| (GIN) " & txtNombre.Text
                    botAceptar.Enabled = True
                End If
            End If

        ElseIf radObstetrico.Checked = True Then
            'se selecciono un informe obstetrico
            'revisa si se sabe o no la fur
            If radConoceFUR.Checked = False And radDesconoceFUR.Checked = False Then
                'no se ha dicho si conoce o no la fur
                labEjemplo.Text = "Señala si la Paciente cononoce o no su FUR..."
                txtNombre.Enabled = False
                txtNombre.Clear()
                botAceptar.Enabled = False

            ElseIf radConoceFUR.Checked = True Then
                'la paciente conoce la fur
                If txtFUR02.Text = "" Then
                    FUR = Nothing
                    'no se ha seleccionado una fur, la pide
                    labEjemplo.Text = "Selecciona una FUR válida, presiona el Botón FUR..."
                    txtNombre.Enabled = False
                    txtNombre.Clear()
                    botAceptar.Enabled = False
                Else
                    'ya se selecciono una fur, prende el cuadro de nombre
                    'y revisa la descripcion introducida
                    txtNombre.Enabled = True
                    txtNombre.Focus()
                    If txtNombre.Text = "" Then
                        labEjemplo.Text = "Introduce una descripción del informe Ecográfico..."
                        botAceptar.Enabled = False
                    Else
                        labEjemplo.Text = "Actualmente: " & FechaDelInforme.ToShortDateString & "| (OBS) " & txtNombre.Text
                        botAceptar.Enabled = True
                    End If
                End If

            ElseIf radDesconoceFUR.Checked = True Then
                'la pte desconoce la fur
                FUR = Nothing
                If radECO1erT.Checked = False And radECO2y3erT.Checked = False Then
                    'no se ha seleccionado el trimestre manualmente
                    labEjemplo.Text = "Selecciona el Trimestre en que se encuentra clinicamente..."
                    txtNombre.Enabled = False
                    txtNombre.Clear()
                    botAceptar.Enabled = False
                ElseIf radECO1erT.Checked = True Then

                    'se selecciono el 1er trimestre manualmente
                    txtNombre.Enabled = True
                    txtNombre.Focus()
                    If txtNombre.Text = "" Then
                        labEjemplo.Text = "Introduce una descripción del informe Ecográfico..."
                        botAceptar.Enabled = False
                    Else
                        labEjemplo.Text = "Actualmente: " & FechaDelInforme.ToShortDateString & "| (OBS) " & txtNombre.Text
                        botAceptar.Enabled = True
                    End If

                ElseIf radECO2y3erT.Checked = True Then

                    'se selecciono el 2 y 3 er trimestre manualmente
                    txtNombre.Enabled = True
                    txtNombre.Focus()
                    If txtNombre.Text = "" Then
                        labEjemplo.Text = "Introduce una descripción del informe Ecográfico..."
                        botAceptar.Enabled = False
                    Else
                        labEjemplo.Text = "Actualmente: " & FechaDelInforme.ToShortDateString & "| (OBS) " & txtNombre.Text
                        botAceptar.Enabled = True
                    End If

                End If

            End If

        End If
    End Sub


    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        Form1.Informe01TipoInforme = TipoInf
        Form1.Informe02VeReglas = VeReglas
        Form1.Informe03ConoceFUR = ConoceFUR
        Form1.Informe04FUR = FUR
        Form1.Informe05Trimestre = Trimestre
        Form1.Informe06Nombre = Nombre
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub botAceptar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.MouseEnter
        botAceptar.Image = BotonOnGrande
    End Sub
    Private Sub botAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.MouseLeave
        botAceptar.Image = BotonOffGrande
    End Sub
    Private Sub botCancelar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.MouseEnter
        botCancelar.Image = BotonOnGrande
    End Sub
    Private Sub botCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.MouseLeave
        botCancelar.Image = BotonOffGrande
    End Sub
    Private Sub botFUR01_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR01.MouseEnter
        botFUR01.Image = BotonOnGrande
    End Sub
    Private Sub botFUR01_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR01.MouseLeave
        botFUR01.Image = BotonOffGrande
    End Sub
    Private Sub botFUR02_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR02.MouseEnter
        botFUR02.Image = BotonOnGrande
    End Sub
    Private Sub botFUR02_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR02.MouseLeave
        botFUR02.Image = BotonOffGrande
    End Sub




End Class
