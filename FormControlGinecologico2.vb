Imports System.IO

Public Class FormControlGinecologico2
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
    Friend WithEvents TabPageIndice As System.Windows.Forms.TabPage
    Friend WithEvents PictureImpresora As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents botElimina As System.Windows.Forms.Button
    Friend WithEvents botNuevo As System.Windows.Forms.Button
    Friend WithEvents botSelecciona As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPageControles As System.Windows.Forms.TabPage
    Friend WithEvents txtFechaInicioControl As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageEvolucion As System.Windows.Forms.TabPage
    Friend WithEvents TabPageLaboratorio1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents TabPageLaboratorio2 As System.Windows.Forms.TabPage
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents TabPageInforme As System.Windows.Forms.TabPage
    Friend WithEvents botImprimeInforme As System.Windows.Forms.Button
    Friend WithEvents botCreaRestableceInforme As System.Windows.Forms.Button
    Friend WithEvents txtInforme As System.Windows.Forms.TextBox
    Friend WithEvents TabPageDatosPersonales As System.Windows.Forms.TabPage
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtAntFamiliares As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtAntPersonales As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtAntGinecologicos As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtAntObstetricos As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents txtAntQuirurgicos As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtProfesion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtFechaNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtNombrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPageInicio As System.Windows.Forms.TabPage
    Friend WithEvents botSalirSinGuardar As System.Windows.Forms.Button
    Friend WithEvents botGuardarNuevosDatos As System.Windows.Forms.Button
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents Tab2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tab3 As System.Windows.Forms.TabPage
    Friend WithEvents Tab4 As System.Windows.Forms.TabPage
    Friend WithEvents Tab5 As System.Windows.Forms.TabPage
    Friend WithEvents Tab6 As System.Windows.Forms.TabPage
    Friend WithEvents Tab7 As System.Windows.Forms.TabPage
    Friend WithEvents Tab8 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Tab9 As System.Windows.Forms.TabPage
    Friend WithEvents Tab10 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents txt02g As System.Windows.Forms.TextBox
    Friend WithEvents txt02c As System.Windows.Forms.TextBox
    Friend WithEvents txt02a As System.Windows.Forms.TextBox
    Friend WithEvents txt02b As System.Windows.Forms.TextBox
    Friend WithEvents txt02d As System.Windows.Forms.TextBox
    Friend WithEvents txt02e As System.Windows.Forms.TextBox
    Friend WithEvents txt02f As System.Windows.Forms.TextBox
    Friend WithEvents txt01g As System.Windows.Forms.TextBox
    Friend WithEvents txt01f As System.Windows.Forms.TextBox
    Friend WithEvents txt01e As System.Windows.Forms.TextBox
    Friend WithEvents txt01b As System.Windows.Forms.TextBox
    Friend WithEvents txt01a As System.Windows.Forms.TextBox
    Friend WithEvents txt01h As System.Windows.Forms.TextBox
    Friend WithEvents txt01d As System.Windows.Forms.TextBox
    Friend WithEvents txt01c As System.Windows.Forms.TextBox
    Friend WithEvents txt03f As System.Windows.Forms.TextBox
    Friend WithEvents txt03e As System.Windows.Forms.TextBox
    Friend WithEvents txt03d As System.Windows.Forms.TextBox
    Friend WithEvents txt03b As System.Windows.Forms.TextBox
    Friend WithEvents txt03a As System.Windows.Forms.TextBox
    Friend WithEvents txt03g As System.Windows.Forms.TextBox
    Friend WithEvents txt03c As System.Windows.Forms.TextBox
    Friend WithEvents txt04f As System.Windows.Forms.TextBox
    Friend WithEvents txt04e As System.Windows.Forms.TextBox
    Friend WithEvents txt04d As System.Windows.Forms.TextBox
    Friend WithEvents txt04b As System.Windows.Forms.TextBox
    Friend WithEvents txt04a As System.Windows.Forms.TextBox
    Friend WithEvents txt04g As System.Windows.Forms.TextBox
    Friend WithEvents txt04c As System.Windows.Forms.TextBox
    Friend WithEvents txt05f As System.Windows.Forms.TextBox
    Friend WithEvents txt05e As System.Windows.Forms.TextBox
    Friend WithEvents txt05d As System.Windows.Forms.TextBox
    Friend WithEvents txt05b As System.Windows.Forms.TextBox
    Friend WithEvents txt05a As System.Windows.Forms.TextBox
    Friend WithEvents txt05g As System.Windows.Forms.TextBox
    Friend WithEvents txt05c As System.Windows.Forms.TextBox
    Friend WithEvents txt06f As System.Windows.Forms.TextBox
    Friend WithEvents txt06e As System.Windows.Forms.TextBox
    Friend WithEvents txt06d As System.Windows.Forms.TextBox
    Friend WithEvents txt06b As System.Windows.Forms.TextBox
    Friend WithEvents txt06a As System.Windows.Forms.TextBox
    Friend WithEvents txt06g As System.Windows.Forms.TextBox
    Friend WithEvents txt06c As System.Windows.Forms.TextBox
    Friend WithEvents txt07f As System.Windows.Forms.TextBox
    Friend WithEvents txt07e As System.Windows.Forms.TextBox
    Friend WithEvents txt07d As System.Windows.Forms.TextBox
    Friend WithEvents txt07b As System.Windows.Forms.TextBox
    Friend WithEvents txt07a As System.Windows.Forms.TextBox
    Friend WithEvents txt07g As System.Windows.Forms.TextBox
    Friend WithEvents txt07c As System.Windows.Forms.TextBox
    Friend WithEvents txt08f As System.Windows.Forms.TextBox
    Friend WithEvents txt08e As System.Windows.Forms.TextBox
    Friend WithEvents txt08d As System.Windows.Forms.TextBox
    Friend WithEvents txt08b As System.Windows.Forms.TextBox
    Friend WithEvents txt08a As System.Windows.Forms.TextBox
    Friend WithEvents txt08g As System.Windows.Forms.TextBox
    Friend WithEvents txt08c As System.Windows.Forms.TextBox
    Friend WithEvents txt09a As System.Windows.Forms.TextBox
    Friend WithEvents botEF01 As System.Windows.Forms.Button
    Friend WithEvents botEF02 As System.Windows.Forms.Button
    Friend WithEvents botEF03 As System.Windows.Forms.Button
    Friend WithEvents botEF04 As System.Windows.Forms.Button
    Friend WithEvents botEF05 As System.Windows.Forms.Button
    Friend WithEvents botEF06 As System.Windows.Forms.Button
    Friend WithEvents botEF07 As System.Windows.Forms.Button
    Friend WithEvents botEF08 As System.Windows.Forms.Button
    Friend WithEvents txt09f As System.Windows.Forms.TextBox
    Friend WithEvents txt09e As System.Windows.Forms.TextBox
    Friend WithEvents txt09d As System.Windows.Forms.TextBox
    Friend WithEvents txt09b As System.Windows.Forms.TextBox
    Friend WithEvents txt09g As System.Windows.Forms.TextBox
    Friend WithEvents txt09c As System.Windows.Forms.TextBox
    Friend WithEvents botEF09 As System.Windows.Forms.Button
    Friend WithEvents txt10f As System.Windows.Forms.TextBox
    Friend WithEvents txt10e As System.Windows.Forms.TextBox
    Friend WithEvents txt10d As System.Windows.Forms.TextBox
    Friend WithEvents txt10b As System.Windows.Forms.TextBox
    Friend WithEvents txt10a As System.Windows.Forms.TextBox
    Friend WithEvents txt10g As System.Windows.Forms.TextBox
    Friend WithEvents txt10c As System.Windows.Forms.TextBox
    Friend WithEvents botEF10 As System.Windows.Forms.Button
    Friend WithEvents txtEX01h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX01g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX01f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX01e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX01d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX01c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX01b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX01a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX20h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX20g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX20f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX20e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX20d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX20c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX20b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX20a As System.Windows.Forms.TextBox
    Friend WithEvents txtOtroEx03 As System.Windows.Forms.TextBox
    Friend WithEvents txtEX19h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX19g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX19f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX19e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX19d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX19c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX19b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX19a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX18h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX18g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX18f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX18e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX18d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX18c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX18b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX18a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX17h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX17g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX17f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX17e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX17d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX17c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX17b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX17a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX16h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX16g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX16f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX16e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX16d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX16c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX16b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX16a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX15h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX15g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX15f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX15e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX15d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX15c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX15b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX15a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX14h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX14g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX14f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX14e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX14d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX14c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX14b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX14a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX13h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX13g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX13f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX13e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX13d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX13c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX13b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX13a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX12h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX12g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX12f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX12e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX12d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX12c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX12b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX12a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX11h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX11g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX11f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX11e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX11d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX11c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX11b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX11a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX10h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX10g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX10f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX10e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX10d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX10c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX10b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX10a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX09h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX09g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX09f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX09e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX09d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX09c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX09b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX09a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX08h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX08g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX08f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX08e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX08d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX08c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX08b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX08a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX07h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX07g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX07f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX07e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX07d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX07c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX07b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX07a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX06h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX06g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX06f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX06e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX06d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX06c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX06b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX06a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX05h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX05g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX05f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX05e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX05d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX05c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX05b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX05a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX04h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX04g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX04f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX04e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX04d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX04c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX04b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX04a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX03h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX03g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX03f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX03e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX03d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX03c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX03b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX03a As System.Windows.Forms.TextBox
    Friend WithEvents txtEX02h As System.Windows.Forms.TextBox
    Friend WithEvents txtEX02g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX02f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX02e As System.Windows.Forms.TextBox
    Friend WithEvents txtEX02d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX02c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX02b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX02a As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaLabH As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaLabG As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaLabF As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaLabE As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaLabD As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaLabC As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaLabB As System.Windows.Forms.TextBox
    Friend WithEvents txtOtroEx02 As System.Windows.Forms.TextBox
    Friend WithEvents txtOtroEx01 As System.Windows.Forms.TextBox
    Friend WithEvents txtEX21l As System.Windows.Forms.TextBox
    Friend WithEvents txtOtroEx08 As System.Windows.Forms.TextBox
    Friend WithEvents txtEX21k As System.Windows.Forms.TextBox
    Friend WithEvents txtOtroEx07 As System.Windows.Forms.TextBox
    Friend WithEvents txtEX21j As System.Windows.Forms.TextBox
    Friend WithEvents txtOtroEx06 As System.Windows.Forms.TextBox
    Friend WithEvents txtEX21i As System.Windows.Forms.TextBox
    Friend WithEvents txtOtroEx05 As System.Windows.Forms.TextBox
    Friend WithEvents txtEX21c As System.Windows.Forms.TextBox
    Friend WithEvents txtEX21b As System.Windows.Forms.TextBox
    Friend WithEvents txtEX21a As System.Windows.Forms.TextBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents txtEX21d As System.Windows.Forms.TextBox
    Friend WithEvents txtEX21h As System.Windows.Forms.TextBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents txtEX21g As System.Windows.Forms.TextBox
    Friend WithEvents txtEX21f As System.Windows.Forms.TextBox
    Friend WithEvents txtEX21e As System.Windows.Forms.TextBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents txtOtroEx04 As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxSeries As System.Windows.Forms.ListBox
    Friend WithEvents labPatologia As System.Windows.Forms.Label
    Friend WithEvents botRenombraSerie As System.Windows.Forms.Button
    Friend WithEvents botFUR01 As System.Windows.Forms.Button
    Friend WithEvents txtDC01 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDC02 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents botFUR02 As System.Windows.Forms.Button
    Friend WithEvents botFecha02 As System.Windows.Forms.Button
    Friend WithEvents botFecha03 As System.Windows.Forms.Button
    Friend WithEvents txtDC03 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents botFUR03 As System.Windows.Forms.Button
    Friend WithEvents botFecha04 As System.Windows.Forms.Button
    Friend WithEvents txtDC04 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents botFUR04 As System.Windows.Forms.Button
    Friend WithEvents botFecha05 As System.Windows.Forms.Button
    Friend WithEvents txtDC05 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents botFUR05 As System.Windows.Forms.Button
    Friend WithEvents botFecha06 As System.Windows.Forms.Button
    Friend WithEvents txtDC06 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents botFUR06 As System.Windows.Forms.Button
    Friend WithEvents botFecha07 As System.Windows.Forms.Button
    Friend WithEvents txtDC07 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents botFUR07 As System.Windows.Forms.Button
    Friend WithEvents botFecha08 As System.Windows.Forms.Button
    Friend WithEvents txtDC08 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents botFUR08 As System.Windows.Forms.Button
    Friend WithEvents botFecha09 As System.Windows.Forms.Button
    Friend WithEvents txtDC09 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents botFUR09 As System.Windows.Forms.Button
    Friend WithEvents botFecha10 As System.Windows.Forms.Button
    Friend WithEvents txtDC10 As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents botFUR10 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtOtroEx09 As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtFechaLabA As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menuCalculoEGconECO As System.Windows.Forms.MenuItem
    Friend WithEvents menuCalculoEGconFUR As System.Windows.Forms.MenuItem
    Friend WithEvents menuCalculoDCconFUR As System.Windows.Forms.MenuItem
    Friend WithEvents labTab02 As System.Windows.Forms.Label
    Friend WithEvents labTab03 As System.Windows.Forms.Label
    Friend WithEvents labTab04 As System.Windows.Forms.Label
    Friend WithEvents labTab05 As System.Windows.Forms.Label
    Friend WithEvents labTab06 As System.Windows.Forms.Label
    Friend WithEvents labTab07 As System.Windows.Forms.Label
    Friend WithEvents labTab08 As System.Windows.Forms.Label
    Friend WithEvents labTab09 As System.Windows.Forms.Label
    Friend WithEvents labTab10 As System.Windows.Forms.Label
    Friend WithEvents botPersonaliza As System.Windows.Forms.Button
    Friend WithEvents menuCaluloEGconBiometria As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormControlGinecologico2))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageIndice = New System.Windows.Forms.TabPage()
        Me.botRenombraSerie = New System.Windows.Forms.Button()
        Me.PictureImpresora = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.botElimina = New System.Windows.Forms.Button()
        Me.botNuevo = New System.Windows.Forms.Button()
        Me.botSelecciona = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxSeries = New System.Windows.Forms.ListBox()
        Me.TabPageControles = New System.Windows.Forms.TabPage()
        Me.txtFechaInicioControl = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPageInicio = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDC01 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botFUR01 = New System.Windows.Forms.Button()
        Me.txt01c = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt01g = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt01f = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt01e = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt01b = New System.Windows.Forms.TextBox()
        Me.txt01a = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt01h = New System.Windows.Forms.TextBox()
        Me.txt01d = New System.Windows.Forms.TextBox()
        Me.botEF01 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPageEvolucion = New System.Windows.Forms.TabPage()
        Me.labTab10 = New System.Windows.Forms.Label()
        Me.labTab09 = New System.Windows.Forms.Label()
        Me.labTab08 = New System.Windows.Forms.Label()
        Me.labTab07 = New System.Windows.Forms.Label()
        Me.labTab06 = New System.Windows.Forms.Label()
        Me.labTab05 = New System.Windows.Forms.Label()
        Me.labTab04 = New System.Windows.Forms.Label()
        Me.labTab03 = New System.Windows.Forms.Label()
        Me.labTab02 = New System.Windows.Forms.Label()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.botFecha02 = New System.Windows.Forms.Button()
        Me.txtDC02 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.botFUR02 = New System.Windows.Forms.Button()
        Me.txt02f = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt02e = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt02d = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt02b = New System.Windows.Forms.TextBox()
        Me.txt02a = New System.Windows.Forms.TextBox()
        Me.txt02g = New System.Windows.Forms.TextBox()
        Me.txt02c = New System.Windows.Forms.TextBox()
        Me.botEF02 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tab3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.botFecha03 = New System.Windows.Forms.Button()
        Me.txtDC03 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.botFUR03 = New System.Windows.Forms.Button()
        Me.txt03f = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt03e = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt03d = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt03b = New System.Windows.Forms.TextBox()
        Me.txt03a = New System.Windows.Forms.TextBox()
        Me.txt03g = New System.Windows.Forms.TextBox()
        Me.txt03c = New System.Windows.Forms.TextBox()
        Me.botEF03 = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Tab4 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.botFecha04 = New System.Windows.Forms.Button()
        Me.txtDC04 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.botFUR04 = New System.Windows.Forms.Button()
        Me.txt04f = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt04e = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt04d = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txt04b = New System.Windows.Forms.TextBox()
        Me.txt04a = New System.Windows.Forms.TextBox()
        Me.txt04g = New System.Windows.Forms.TextBox()
        Me.txt04c = New System.Windows.Forms.TextBox()
        Me.botEF04 = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Tab5 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.botFecha05 = New System.Windows.Forms.Button()
        Me.txtDC05 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.botFUR05 = New System.Windows.Forms.Button()
        Me.txt05f = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt05e = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt05d = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt05b = New System.Windows.Forms.TextBox()
        Me.txt05a = New System.Windows.Forms.TextBox()
        Me.txt05g = New System.Windows.Forms.TextBox()
        Me.txt05c = New System.Windows.Forms.TextBox()
        Me.botEF05 = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Tab6 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.botFecha06 = New System.Windows.Forms.Button()
        Me.txtDC06 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.botFUR06 = New System.Windows.Forms.Button()
        Me.txt06f = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txt06e = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txt06d = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txt06b = New System.Windows.Forms.TextBox()
        Me.txt06a = New System.Windows.Forms.TextBox()
        Me.txt06g = New System.Windows.Forms.TextBox()
        Me.txt06c = New System.Windows.Forms.TextBox()
        Me.botEF06 = New System.Windows.Forms.Button()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Tab7 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.botFecha07 = New System.Windows.Forms.Button()
        Me.txtDC07 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.botFUR07 = New System.Windows.Forms.Button()
        Me.txt07f = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txt07e = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txt07d = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txt07b = New System.Windows.Forms.TextBox()
        Me.txt07a = New System.Windows.Forms.TextBox()
        Me.txt07g = New System.Windows.Forms.TextBox()
        Me.txt07c = New System.Windows.Forms.TextBox()
        Me.botEF07 = New System.Windows.Forms.Button()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Tab8 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.botFecha08 = New System.Windows.Forms.Button()
        Me.txtDC08 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.botFUR08 = New System.Windows.Forms.Button()
        Me.txt08f = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txt08e = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txt08d = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txt08b = New System.Windows.Forms.TextBox()
        Me.txt08a = New System.Windows.Forms.TextBox()
        Me.txt08g = New System.Windows.Forms.TextBox()
        Me.txt08c = New System.Windows.Forms.TextBox()
        Me.botEF08 = New System.Windows.Forms.Button()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Tab9 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.botFecha09 = New System.Windows.Forms.Button()
        Me.txtDC09 = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.botFUR09 = New System.Windows.Forms.Button()
        Me.txt09f = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txt09e = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txt09d = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.txt09b = New System.Windows.Forms.TextBox()
        Me.txt09a = New System.Windows.Forms.TextBox()
        Me.txt09g = New System.Windows.Forms.TextBox()
        Me.txt09c = New System.Windows.Forms.TextBox()
        Me.botEF09 = New System.Windows.Forms.Button()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Tab10 = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.botFecha10 = New System.Windows.Forms.Button()
        Me.txtDC10 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.botFUR10 = New System.Windows.Forms.Button()
        Me.txt10f = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.txt10e = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.txt10d = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.txt10b = New System.Windows.Forms.TextBox()
        Me.txt10a = New System.Windows.Forms.TextBox()
        Me.txt10g = New System.Windows.Forms.TextBox()
        Me.txt10c = New System.Windows.Forms.TextBox()
        Me.botEF10 = New System.Windows.Forms.Button()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.TabPageLaboratorio1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtEX20h = New System.Windows.Forms.TextBox()
        Me.txtEX20g = New System.Windows.Forms.TextBox()
        Me.txtEX20f = New System.Windows.Forms.TextBox()
        Me.txtEX20e = New System.Windows.Forms.TextBox()
        Me.txtEX20d = New System.Windows.Forms.TextBox()
        Me.txtEX20c = New System.Windows.Forms.TextBox()
        Me.txtEX20b = New System.Windows.Forms.TextBox()
        Me.txtEX20a = New System.Windows.Forms.TextBox()
        Me.txtOtroEx03 = New System.Windows.Forms.TextBox()
        Me.txtEX19h = New System.Windows.Forms.TextBox()
        Me.txtEX19g = New System.Windows.Forms.TextBox()
        Me.txtEX19f = New System.Windows.Forms.TextBox()
        Me.txtEX19e = New System.Windows.Forms.TextBox()
        Me.txtEX19d = New System.Windows.Forms.TextBox()
        Me.txtEX19c = New System.Windows.Forms.TextBox()
        Me.txtEX19b = New System.Windows.Forms.TextBox()
        Me.txtEX19a = New System.Windows.Forms.TextBox()
        Me.txtEX18h = New System.Windows.Forms.TextBox()
        Me.txtEX18g = New System.Windows.Forms.TextBox()
        Me.txtEX18f = New System.Windows.Forms.TextBox()
        Me.txtEX18e = New System.Windows.Forms.TextBox()
        Me.txtEX18d = New System.Windows.Forms.TextBox()
        Me.txtEX18c = New System.Windows.Forms.TextBox()
        Me.txtEX18b = New System.Windows.Forms.TextBox()
        Me.txtEX18a = New System.Windows.Forms.TextBox()
        Me.txtEX17h = New System.Windows.Forms.TextBox()
        Me.txtEX17g = New System.Windows.Forms.TextBox()
        Me.txtEX17f = New System.Windows.Forms.TextBox()
        Me.txtEX17e = New System.Windows.Forms.TextBox()
        Me.txtEX17d = New System.Windows.Forms.TextBox()
        Me.txtEX17c = New System.Windows.Forms.TextBox()
        Me.txtEX17b = New System.Windows.Forms.TextBox()
        Me.txtEX17a = New System.Windows.Forms.TextBox()
        Me.txtEX16h = New System.Windows.Forms.TextBox()
        Me.txtEX16g = New System.Windows.Forms.TextBox()
        Me.txtEX16f = New System.Windows.Forms.TextBox()
        Me.txtEX16e = New System.Windows.Forms.TextBox()
        Me.txtEX16d = New System.Windows.Forms.TextBox()
        Me.txtEX16c = New System.Windows.Forms.TextBox()
        Me.txtEX16b = New System.Windows.Forms.TextBox()
        Me.txtEX16a = New System.Windows.Forms.TextBox()
        Me.txtEX15h = New System.Windows.Forms.TextBox()
        Me.txtEX15g = New System.Windows.Forms.TextBox()
        Me.txtEX15f = New System.Windows.Forms.TextBox()
        Me.txtEX15e = New System.Windows.Forms.TextBox()
        Me.txtEX15d = New System.Windows.Forms.TextBox()
        Me.txtEX15c = New System.Windows.Forms.TextBox()
        Me.txtEX15b = New System.Windows.Forms.TextBox()
        Me.txtEX15a = New System.Windows.Forms.TextBox()
        Me.txtEX14h = New System.Windows.Forms.TextBox()
        Me.txtEX14g = New System.Windows.Forms.TextBox()
        Me.txtEX14f = New System.Windows.Forms.TextBox()
        Me.txtEX14e = New System.Windows.Forms.TextBox()
        Me.txtEX14d = New System.Windows.Forms.TextBox()
        Me.txtEX14c = New System.Windows.Forms.TextBox()
        Me.txtEX14b = New System.Windows.Forms.TextBox()
        Me.txtEX14a = New System.Windows.Forms.TextBox()
        Me.txtEX13h = New System.Windows.Forms.TextBox()
        Me.txtEX13g = New System.Windows.Forms.TextBox()
        Me.txtEX13f = New System.Windows.Forms.TextBox()
        Me.txtEX13e = New System.Windows.Forms.TextBox()
        Me.txtEX13d = New System.Windows.Forms.TextBox()
        Me.txtEX13c = New System.Windows.Forms.TextBox()
        Me.txtEX13b = New System.Windows.Forms.TextBox()
        Me.txtEX13a = New System.Windows.Forms.TextBox()
        Me.txtEX12h = New System.Windows.Forms.TextBox()
        Me.txtEX12g = New System.Windows.Forms.TextBox()
        Me.txtEX12f = New System.Windows.Forms.TextBox()
        Me.txtEX12e = New System.Windows.Forms.TextBox()
        Me.txtEX12d = New System.Windows.Forms.TextBox()
        Me.txtEX12c = New System.Windows.Forms.TextBox()
        Me.txtEX12b = New System.Windows.Forms.TextBox()
        Me.txtEX12a = New System.Windows.Forms.TextBox()
        Me.txtEX11h = New System.Windows.Forms.TextBox()
        Me.txtEX11g = New System.Windows.Forms.TextBox()
        Me.txtEX11f = New System.Windows.Forms.TextBox()
        Me.txtEX11e = New System.Windows.Forms.TextBox()
        Me.txtEX11d = New System.Windows.Forms.TextBox()
        Me.txtEX11c = New System.Windows.Forms.TextBox()
        Me.txtEX11b = New System.Windows.Forms.TextBox()
        Me.txtEX11a = New System.Windows.Forms.TextBox()
        Me.txtEX10h = New System.Windows.Forms.TextBox()
        Me.txtEX10g = New System.Windows.Forms.TextBox()
        Me.txtEX10f = New System.Windows.Forms.TextBox()
        Me.txtEX10e = New System.Windows.Forms.TextBox()
        Me.txtEX10d = New System.Windows.Forms.TextBox()
        Me.txtEX10c = New System.Windows.Forms.TextBox()
        Me.txtEX10b = New System.Windows.Forms.TextBox()
        Me.txtEX10a = New System.Windows.Forms.TextBox()
        Me.txtEX09h = New System.Windows.Forms.TextBox()
        Me.txtEX09g = New System.Windows.Forms.TextBox()
        Me.txtEX09f = New System.Windows.Forms.TextBox()
        Me.txtEX09e = New System.Windows.Forms.TextBox()
        Me.txtEX09d = New System.Windows.Forms.TextBox()
        Me.txtEX09c = New System.Windows.Forms.TextBox()
        Me.txtEX09b = New System.Windows.Forms.TextBox()
        Me.txtEX09a = New System.Windows.Forms.TextBox()
        Me.txtEX08h = New System.Windows.Forms.TextBox()
        Me.txtEX08g = New System.Windows.Forms.TextBox()
        Me.txtEX08f = New System.Windows.Forms.TextBox()
        Me.txtEX08e = New System.Windows.Forms.TextBox()
        Me.txtEX08d = New System.Windows.Forms.TextBox()
        Me.txtEX08c = New System.Windows.Forms.TextBox()
        Me.txtEX08b = New System.Windows.Forms.TextBox()
        Me.txtEX08a = New System.Windows.Forms.TextBox()
        Me.txtEX07h = New System.Windows.Forms.TextBox()
        Me.txtEX07g = New System.Windows.Forms.TextBox()
        Me.txtEX07f = New System.Windows.Forms.TextBox()
        Me.txtEX07e = New System.Windows.Forms.TextBox()
        Me.txtEX07d = New System.Windows.Forms.TextBox()
        Me.txtEX07c = New System.Windows.Forms.TextBox()
        Me.txtEX07b = New System.Windows.Forms.TextBox()
        Me.txtEX07a = New System.Windows.Forms.TextBox()
        Me.txtEX06h = New System.Windows.Forms.TextBox()
        Me.txtEX06g = New System.Windows.Forms.TextBox()
        Me.txtEX06f = New System.Windows.Forms.TextBox()
        Me.txtEX06e = New System.Windows.Forms.TextBox()
        Me.txtEX06d = New System.Windows.Forms.TextBox()
        Me.txtEX06c = New System.Windows.Forms.TextBox()
        Me.txtEX06b = New System.Windows.Forms.TextBox()
        Me.txtEX06a = New System.Windows.Forms.TextBox()
        Me.txtEX05h = New System.Windows.Forms.TextBox()
        Me.txtEX05g = New System.Windows.Forms.TextBox()
        Me.txtEX05f = New System.Windows.Forms.TextBox()
        Me.txtEX05e = New System.Windows.Forms.TextBox()
        Me.txtEX05d = New System.Windows.Forms.TextBox()
        Me.txtEX05c = New System.Windows.Forms.TextBox()
        Me.txtEX05b = New System.Windows.Forms.TextBox()
        Me.txtEX05a = New System.Windows.Forms.TextBox()
        Me.txtEX04h = New System.Windows.Forms.TextBox()
        Me.txtEX04g = New System.Windows.Forms.TextBox()
        Me.txtEX04f = New System.Windows.Forms.TextBox()
        Me.txtEX04e = New System.Windows.Forms.TextBox()
        Me.txtEX04d = New System.Windows.Forms.TextBox()
        Me.txtEX04c = New System.Windows.Forms.TextBox()
        Me.txtEX04b = New System.Windows.Forms.TextBox()
        Me.txtEX04a = New System.Windows.Forms.TextBox()
        Me.txtEX03h = New System.Windows.Forms.TextBox()
        Me.txtEX03g = New System.Windows.Forms.TextBox()
        Me.txtEX03f = New System.Windows.Forms.TextBox()
        Me.txtEX03e = New System.Windows.Forms.TextBox()
        Me.txtEX03d = New System.Windows.Forms.TextBox()
        Me.txtEX03c = New System.Windows.Forms.TextBox()
        Me.txtEX03b = New System.Windows.Forms.TextBox()
        Me.txtEX03a = New System.Windows.Forms.TextBox()
        Me.txtEX02h = New System.Windows.Forms.TextBox()
        Me.txtEX02g = New System.Windows.Forms.TextBox()
        Me.txtEX02f = New System.Windows.Forms.TextBox()
        Me.txtEX02e = New System.Windows.Forms.TextBox()
        Me.txtEX02d = New System.Windows.Forms.TextBox()
        Me.txtEX02c = New System.Windows.Forms.TextBox()
        Me.txtEX02b = New System.Windows.Forms.TextBox()
        Me.txtEX02a = New System.Windows.Forms.TextBox()
        Me.txtEX01h = New System.Windows.Forms.TextBox()
        Me.txtEX01g = New System.Windows.Forms.TextBox()
        Me.txtEX01f = New System.Windows.Forms.TextBox()
        Me.txtEX01e = New System.Windows.Forms.TextBox()
        Me.txtEX01d = New System.Windows.Forms.TextBox()
        Me.txtEX01c = New System.Windows.Forms.TextBox()
        Me.txtEX01b = New System.Windows.Forms.TextBox()
        Me.txtEX01a = New System.Windows.Forms.TextBox()
        Me.txtFechaLabH = New System.Windows.Forms.TextBox()
        Me.txtFechaLabG = New System.Windows.Forms.TextBox()
        Me.txtFechaLabF = New System.Windows.Forms.TextBox()
        Me.txtFechaLabE = New System.Windows.Forms.TextBox()
        Me.txtFechaLabD = New System.Windows.Forms.TextBox()
        Me.txtFechaLabC = New System.Windows.Forms.TextBox()
        Me.txtFechaLabB = New System.Windows.Forms.TextBox()
        Me.txtFechaLabA = New System.Windows.Forms.TextBox()
        Me.txtOtroEx02 = New System.Windows.Forms.TextBox()
        Me.txtOtroEx01 = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TabPageLaboratorio2 = New System.Windows.Forms.TabPage()
        Me.txtOtroEx09 = New System.Windows.Forms.TextBox()
        Me.txtOtroEx04 = New System.Windows.Forms.TextBox()
        Me.txtEX21h = New System.Windows.Forms.TextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txtEX21g = New System.Windows.Forms.TextBox()
        Me.txtEX21f = New System.Windows.Forms.TextBox()
        Me.txtEX21e = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.txtEX21d = New System.Windows.Forms.TextBox()
        Me.txtEX21l = New System.Windows.Forms.TextBox()
        Me.txtOtroEx08 = New System.Windows.Forms.TextBox()
        Me.txtEX21k = New System.Windows.Forms.TextBox()
        Me.txtOtroEx07 = New System.Windows.Forms.TextBox()
        Me.txtEX21j = New System.Windows.Forms.TextBox()
        Me.txtOtroEx06 = New System.Windows.Forms.TextBox()
        Me.txtEX21i = New System.Windows.Forms.TextBox()
        Me.txtOtroEx05 = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.txtEX21c = New System.Windows.Forms.TextBox()
        Me.txtEX21b = New System.Windows.Forms.TextBox()
        Me.txtEX21a = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.TabPageInforme = New System.Windows.Forms.TabPage()
        Me.botPersonaliza = New System.Windows.Forms.Button()
        Me.botImprimeInforme = New System.Windows.Forms.Button()
        Me.botCreaRestableceInforme = New System.Windows.Forms.Button()
        Me.txtInforme = New System.Windows.Forms.TextBox()
        Me.labPatologia = New System.Windows.Forms.Label()
        Me.TabPageDatosPersonales = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtAntFamiliares = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtAntPersonales = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtAntGinecologicos = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtAntObstetricos = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txtAntQuirurgicos = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtProfesion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.botSalirSinGuardar = New System.Windows.Forms.Button()
        Me.botGuardarNuevosDatos = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuCalculoEGconECO = New System.Windows.Forms.MenuItem()
        Me.menuCalculoEGconFUR = New System.Windows.Forms.MenuItem()
        Me.menuCalculoDCconFUR = New System.Windows.Forms.MenuItem()
        Me.menuCaluloEGconBiometria = New System.Windows.Forms.MenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPageIndice.SuspendLayout()
        CType(Me.PictureImpresora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageControles.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPageInicio.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPageEvolucion.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Tab3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Tab4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Tab5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Tab6.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Tab7.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Tab8.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Tab9.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.Tab10.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabPageLaboratorio1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPageLaboratorio2.SuspendLayout()
        Me.TabPageInforme.SuspendLayout()
        Me.TabPageDatosPersonales.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageIndice)
        Me.TabControl1.Controls.Add(Me.TabPageControles)
        Me.TabControl1.Controls.Add(Me.TabPageDatosPersonales)
        Me.TabControl1.Location = New System.Drawing.Point(0, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 480)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageIndice
        '
        Me.TabPageIndice.AutoScroll = True
        Me.TabPageIndice.Controls.Add(Me.botRenombraSerie)
        Me.TabPageIndice.Controls.Add(Me.PictureImpresora)
        Me.TabPageIndice.Controls.Add(Me.PictureBox1)
        Me.TabPageIndice.Controls.Add(Me.botElimina)
        Me.TabPageIndice.Controls.Add(Me.botNuevo)
        Me.TabPageIndice.Controls.Add(Me.botSelecciona)
        Me.TabPageIndice.Controls.Add(Me.Label2)
        Me.TabPageIndice.Controls.Add(Me.ListBoxSeries)
        Me.TabPageIndice.Location = New System.Drawing.Point(4, 22)
        Me.TabPageIndice.Name = "TabPageIndice"
        Me.TabPageIndice.Size = New System.Drawing.Size(784, 454)
        Me.TabPageIndice.TabIndex = 2
        Me.TabPageIndice.Text = "Indice"
        '
        'botRenombraSerie
        '
        Me.botRenombraSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRenombraSerie.Image = CType(resources.GetObject("botRenombraSerie.Image"), System.Drawing.Image)
        Me.botRenombraSerie.Location = New System.Drawing.Point(16, 368)
        Me.botRenombraSerie.Name = "botRenombraSerie"
        Me.botRenombraSerie.Size = New System.Drawing.Size(224, 23)
        Me.botRenombraSerie.TabIndex = 20
        Me.botRenombraSerie.Text = "Renombra la Serie Seleccionada"
        '
        'PictureImpresora
        '
        Me.PictureImpresora.Image = CType(resources.GetObject("PictureImpresora.Image"), System.Drawing.Image)
        Me.PictureImpresora.Location = New System.Drawing.Point(472, 344)
        Me.PictureImpresora.Name = "PictureImpresora"
        Me.PictureImpresora.Size = New System.Drawing.Size(48, 80)
        Me.PictureImpresora.TabIndex = 19
        Me.PictureImpresora.TabStop = False
        Me.PictureImpresora.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(668, 272)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'botElimina
        '
        Me.botElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botElimina.Image = CType(resources.GetObject("botElimina.Image"), System.Drawing.Image)
        Me.botElimina.Location = New System.Drawing.Point(16, 400)
        Me.botElimina.Name = "botElimina"
        Me.botElimina.Size = New System.Drawing.Size(224, 23)
        Me.botElimina.TabIndex = 4
        Me.botElimina.Text = "Elimina Serie de Consultas Seleccionada"
        '
        'botNuevo
        '
        Me.botNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botNuevo.Image = CType(resources.GetObject("botNuevo.Image"), System.Drawing.Image)
        Me.botNuevo.Location = New System.Drawing.Point(16, 304)
        Me.botNuevo.Name = "botNuevo"
        Me.botNuevo.Size = New System.Drawing.Size(224, 23)
        Me.botNuevo.TabIndex = 2
        Me.botNuevo.Text = "Crea Nueva Serie de Consultas"
        '
        'botSelecciona
        '
        Me.botSelecciona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSelecciona.Image = CType(resources.GetObject("botSelecciona.Image"), System.Drawing.Image)
        Me.botSelecciona.Location = New System.Drawing.Point(16, 336)
        Me.botSelecciona.Name = "botSelecciona"
        Me.botSelecciona.Size = New System.Drawing.Size(224, 23)
        Me.botSelecciona.TabIndex = 3
        Me.botSelecciona.Text = "Abre Serie de Consultas Seleccionada"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Series de Consultas Incluidas en la Historia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBoxSeries
        '
        Me.ListBoxSeries.Location = New System.Drawing.Point(16, 40)
        Me.ListBoxSeries.Name = "ListBoxSeries"
        Me.ListBoxSeries.Size = New System.Drawing.Size(752, 225)
        Me.ListBoxSeries.TabIndex = 1
        '
        'TabPageControles
        '
        Me.TabPageControles.AutoScroll = True
        Me.TabPageControles.Controls.Add(Me.txtFechaInicioControl)
        Me.TabPageControles.Controls.Add(Me.Label35)
        Me.TabPageControles.Controls.Add(Me.TabControl3)
        Me.TabPageControles.Controls.Add(Me.labPatologia)
        Me.TabPageControles.Location = New System.Drawing.Point(4, 22)
        Me.TabPageControles.Name = "TabPageControles"
        Me.TabPageControles.Size = New System.Drawing.Size(784, 454)
        Me.TabPageControles.TabIndex = 1
        Me.TabPageControles.Text = "Control Ginecológico"
        Me.TabPageControles.Visible = False
        '
        'txtFechaInicioControl
        '
        Me.txtFechaInicioControl.BackColor = System.Drawing.SystemColors.Info
        Me.txtFechaInicioControl.Location = New System.Drawing.Point(536, 8)
        Me.txtFechaInicioControl.Name = "txtFechaInicioControl"
        Me.txtFechaInicioControl.ReadOnly = True
        Me.txtFechaInicioControl.Size = New System.Drawing.Size(240, 20)
        Me.txtFechaInicioControl.TabIndex = 2
        Me.txtFechaInicioControl.TabStop = False
        Me.txtFechaInicioControl.Text = "Ninguno"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(372, 8)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(168, 23)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "Serie de Consultas Iniciadas el :"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPageInicio)
        Me.TabControl3.Controls.Add(Me.TabPageEvolucion)
        Me.TabControl3.Controls.Add(Me.TabPageLaboratorio1)
        Me.TabControl3.Controls.Add(Me.TabPageLaboratorio2)
        Me.TabControl3.Controls.Add(Me.TabPageInforme)
        Me.TabControl3.Location = New System.Drawing.Point(0, 32)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(784, 420)
        Me.TabControl3.TabIndex = 3
        '
        'TabPageInicio
        '
        Me.TabPageInicio.Controls.Add(Me.GroupBox2)
        Me.TabPageInicio.Location = New System.Drawing.Point(4, 22)
        Me.TabPageInicio.Name = "TabPageInicio"
        Me.TabPageInicio.Size = New System.Drawing.Size(776, 394)
        Me.TabPageInicio.TabIndex = 0
        Me.TabPageInicio.Text = "Consulta de Inicio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDC01)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.botFUR01)
        Me.GroupBox2.Controls.Add(Me.txt01c)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt01g)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt01f)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt01e)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt01b)
        Me.GroupBox2.Controls.Add(Me.txt01a)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txt01h)
        Me.GroupBox2.Controls.Add(Me.txt01d)
        Me.GroupBox2.Controls.Add(Me.botEF01)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 392)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txtDC01
        '
        Me.txtDC01.BackColor = System.Drawing.SystemColors.Info
        Me.txtDC01.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC01.Location = New System.Drawing.Point(248, 40)
        Me.txtDC01.MaxLength = 255
        Me.txtDC01.Multiline = True
        Me.txtDC01.Name = "txtDC01"
        Me.txtDC01.ReadOnly = True
        Me.txtDC01.Size = New System.Drawing.Size(120, 23)
        Me.txtDC01.TabIndex = 5
        Me.txtDC01.TabStop = False
        Me.txtDC01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(248, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Día del Ciclo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botFUR01
        '
        Me.botFUR01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR01.Image = CType(resources.GetObject("botFUR01.Image"), System.Drawing.Image)
        Me.botFUR01.Location = New System.Drawing.Point(128, 16)
        Me.botFUR01.Name = "botFUR01"
        Me.botFUR01.Size = New System.Drawing.Size(120, 23)
        Me.botFUR01.TabIndex = 1
        Me.botFUR01.TabStop = False
        Me.botFUR01.Text = "FUR"
        '
        'txt01c
        '
        Me.txt01c.Location = New System.Drawing.Point(8, 84)
        Me.txt01c.MaxLength = 2048
        Me.txt01c.Multiline = True
        Me.txt01c.Name = "txt01c"
        Me.txt01c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt01c.Size = New System.Drawing.Size(360, 32)
        Me.txt01c.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(192, 16)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Motivo de Consulta :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt01g
        '
        Me.txt01g.Location = New System.Drawing.Point(8, 340)
        Me.txt01g.MaxLength = 2048
        Me.txt01g.Multiline = True
        Me.txt01g.Name = "txt01g"
        Me.txt01g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt01g.Size = New System.Drawing.Size(360, 48)
        Me.txt01g.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Pendiente para la Próxima Consulta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt01f
        '
        Me.txt01f.Location = New System.Drawing.Point(8, 276)
        Me.txt01f.MaxLength = 2048
        Me.txt01f.Multiline = True
        Me.txt01f.Name = "txt01f"
        Me.txt01f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt01f.Size = New System.Drawing.Size(360, 48)
        Me.txt01f.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tratamientos Indicados en la Consulta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt01e
        '
        Me.txt01e.Location = New System.Drawing.Point(8, 212)
        Me.txt01e.MaxLength = 2048
        Me.txt01e.Multiline = True
        Me.txt01e.Name = "txt01e"
        Me.txt01e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt01e.Size = New System.Drawing.Size(360, 48)
        Me.txt01e.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Procedimientos Realizados en la Consulta:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt01b
        '
        Me.txt01b.BackColor = System.Drawing.SystemColors.Window
        Me.txt01b.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt01b.Location = New System.Drawing.Point(128, 40)
        Me.txt01b.MaxLength = 255
        Me.txt01b.Multiline = True
        Me.txt01b.Name = "txt01b"
        Me.txt01b.ReadOnly = True
        Me.txt01b.Size = New System.Drawing.Size(120, 23)
        Me.txt01b.TabIndex = 4
        Me.txt01b.TabStop = False
        Me.txt01b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt01b, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt01a
        '
        Me.txt01a.BackColor = System.Drawing.SystemColors.Info
        Me.txt01a.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt01a.Location = New System.Drawing.Point(8, 40)
        Me.txt01a.MaxLength = 255
        Me.txt01a.Multiline = True
        Me.txt01a.Name = "txt01a"
        Me.txt01a.ReadOnly = True
        Me.txt01a.Size = New System.Drawing.Size(120, 23)
        Me.txt01a.TabIndex = 3
        Me.txt01a.TabStop = False
        Me.txt01a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt01a, "Esta fecha no se puede cambiar es determinada por el inicio del control")
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(8, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 23)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Fecha del Control"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt01h
        '
        Me.txt01h.BackColor = System.Drawing.SystemColors.Info
        Me.txt01h.Location = New System.Drawing.Point(376, 44)
        Me.txt01h.MaxLength = 4096
        Me.txt01h.Multiline = True
        Me.txt01h.Name = "txt01h"
        Me.txt01h.ReadOnly = True
        Me.txt01h.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt01h.Size = New System.Drawing.Size(396, 344)
        Me.txt01h.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txt01h, "Para modificar el texto presiona el botón de arriba")
        '
        'txt01d
        '
        Me.txt01d.Location = New System.Drawing.Point(8, 132)
        Me.txt01d.MaxLength = 2048
        Me.txt01d.Multiline = True
        Me.txt01d.Name = "txt01d"
        Me.txt01d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt01d.Size = New System.Drawing.Size(360, 64)
        Me.txt01d.TabIndex = 9
        '
        'botEF01
        '
        Me.botEF01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEF01.Image = CType(resources.GetObject("botEF01.Image"), System.Drawing.Image)
        Me.botEF01.Location = New System.Drawing.Point(452, 16)
        Me.botEF01.Name = "botEF01"
        Me.botEF01.Size = New System.Drawing.Size(228, 23)
        Me.botEF01.TabIndex = 16
        Me.botEF01.Text = "Examen Físico de la Consulta"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(192, 16)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Enfermedad Actual :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPageEvolucion
        '
        Me.TabPageEvolucion.Controls.Add(Me.labTab10)
        Me.TabPageEvolucion.Controls.Add(Me.labTab09)
        Me.TabPageEvolucion.Controls.Add(Me.labTab08)
        Me.TabPageEvolucion.Controls.Add(Me.labTab07)
        Me.TabPageEvolucion.Controls.Add(Me.labTab06)
        Me.TabPageEvolucion.Controls.Add(Me.labTab05)
        Me.TabPageEvolucion.Controls.Add(Me.labTab04)
        Me.TabPageEvolucion.Controls.Add(Me.labTab03)
        Me.TabPageEvolucion.Controls.Add(Me.labTab02)
        Me.TabPageEvolucion.Controls.Add(Me.TabControl4)
        Me.TabPageEvolucion.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEvolucion.Name = "TabPageEvolucion"
        Me.TabPageEvolucion.Size = New System.Drawing.Size(776, 394)
        Me.TabPageEvolucion.TabIndex = 3
        Me.TabPageEvolucion.Text = "Consultas Sucesivas"
        Me.TabPageEvolucion.Visible = False
        '
        'labTab10
        '
        Me.labTab10.BackColor = System.Drawing.Color.Gold
        Me.labTab10.Location = New System.Drawing.Point(336, 0)
        Me.labTab10.Name = "labTab10"
        Me.labTab10.Size = New System.Drawing.Size(44, 4)
        Me.labTab10.TabIndex = 9
        '
        'labTab09
        '
        Me.labTab09.BackColor = System.Drawing.Color.Gold
        Me.labTab09.Location = New System.Drawing.Point(296, 0)
        Me.labTab09.Name = "labTab09"
        Me.labTab09.Size = New System.Drawing.Size(40, 4)
        Me.labTab09.TabIndex = 8
        '
        'labTab08
        '
        Me.labTab08.BackColor = System.Drawing.Color.Gold
        Me.labTab08.Location = New System.Drawing.Point(252, 0)
        Me.labTab08.Name = "labTab08"
        Me.labTab08.Size = New System.Drawing.Size(44, 4)
        Me.labTab08.TabIndex = 7
        '
        'labTab07
        '
        Me.labTab07.BackColor = System.Drawing.Color.Gold
        Me.labTab07.Location = New System.Drawing.Point(212, 0)
        Me.labTab07.Name = "labTab07"
        Me.labTab07.Size = New System.Drawing.Size(40, 4)
        Me.labTab07.TabIndex = 6
        '
        'labTab06
        '
        Me.labTab06.BackColor = System.Drawing.Color.Gold
        Me.labTab06.Location = New System.Drawing.Point(168, 0)
        Me.labTab06.Name = "labTab06"
        Me.labTab06.Size = New System.Drawing.Size(44, 4)
        Me.labTab06.TabIndex = 5
        '
        'labTab05
        '
        Me.labTab05.BackColor = System.Drawing.Color.Gold
        Me.labTab05.Location = New System.Drawing.Point(128, 0)
        Me.labTab05.Name = "labTab05"
        Me.labTab05.Size = New System.Drawing.Size(40, 4)
        Me.labTab05.TabIndex = 4
        '
        'labTab04
        '
        Me.labTab04.BackColor = System.Drawing.Color.Gold
        Me.labTab04.Location = New System.Drawing.Point(84, 0)
        Me.labTab04.Name = "labTab04"
        Me.labTab04.Size = New System.Drawing.Size(44, 4)
        Me.labTab04.TabIndex = 3
        '
        'labTab03
        '
        Me.labTab03.BackColor = System.Drawing.Color.Gold
        Me.labTab03.Location = New System.Drawing.Point(44, 0)
        Me.labTab03.Name = "labTab03"
        Me.labTab03.Size = New System.Drawing.Size(40, 4)
        Me.labTab03.TabIndex = 2
        '
        'labTab02
        '
        Me.labTab02.BackColor = System.Drawing.Color.Gold
        Me.labTab02.Location = New System.Drawing.Point(4, 0)
        Me.labTab02.Name = "labTab02"
        Me.labTab02.Size = New System.Drawing.Size(40, 4)
        Me.labTab02.TabIndex = 1
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.Tab2)
        Me.TabControl4.Controls.Add(Me.Tab3)
        Me.TabControl4.Controls.Add(Me.Tab4)
        Me.TabControl4.Controls.Add(Me.Tab5)
        Me.TabControl4.Controls.Add(Me.Tab6)
        Me.TabControl4.Controls.Add(Me.Tab7)
        Me.TabControl4.Controls.Add(Me.Tab8)
        Me.TabControl4.Controls.Add(Me.Tab9)
        Me.TabControl4.Controls.Add(Me.Tab10)
        Me.TabControl4.Location = New System.Drawing.Point(0, 4)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(772, 388)
        Me.TabControl4.TabIndex = 0
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.GroupBox1)
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Size = New System.Drawing.Size(764, 362)
        Me.Tab2.TabIndex = 0
        Me.Tab2.Text = "2ª"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.botFecha02)
        Me.GroupBox1.Controls.Add(Me.txtDC02)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.botFUR02)
        Me.GroupBox1.Controls.Add(Me.txt02f)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt02e)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt02d)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt02b)
        Me.GroupBox1.Controls.Add(Me.txt02a)
        Me.GroupBox1.Controls.Add(Me.txt02g)
        Me.GroupBox1.Controls.Add(Me.txt02c)
        Me.GroupBox1.Controls.Add(Me.botEF02)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 360)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "2da Consulta"
        '
        'botFecha02
        '
        Me.botFecha02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFecha02.Image = CType(resources.GetObject("botFecha02.Image"), System.Drawing.Image)
        Me.botFecha02.Location = New System.Drawing.Point(8, 16)
        Me.botFecha02.Name = "botFecha02"
        Me.botFecha02.Size = New System.Drawing.Size(120, 23)
        Me.botFecha02.TabIndex = 0
        Me.botFecha02.TabStop = False
        Me.botFecha02.Text = "Fecha del Control"
        '
        'txtDC02
        '
        Me.txtDC02.BackColor = System.Drawing.SystemColors.Info
        Me.txtDC02.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC02.Location = New System.Drawing.Point(248, 40)
        Me.txtDC02.MaxLength = 255
        Me.txtDC02.Name = "txtDC02"
        Me.txtDC02.ReadOnly = True
        Me.txtDC02.Size = New System.Drawing.Size(120, 20)
        Me.txtDC02.TabIndex = 5
        Me.txtDC02.TabStop = False
        Me.txtDC02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(248, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Día del Ciclo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botFUR02
        '
        Me.botFUR02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR02.Image = CType(resources.GetObject("botFUR02.Image"), System.Drawing.Image)
        Me.botFUR02.Location = New System.Drawing.Point(128, 16)
        Me.botFUR02.Name = "botFUR02"
        Me.botFUR02.Size = New System.Drawing.Size(120, 23)
        Me.botFUR02.TabIndex = 1
        Me.botFUR02.TabStop = False
        Me.botFUR02.Text = "FUR"
        '
        'txt02f
        '
        Me.txt02f.Location = New System.Drawing.Point(8, 308)
        Me.txt02f.MaxLength = 2048
        Me.txt02f.Multiline = True
        Me.txt02f.Name = "txt02f"
        Me.txt02f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt02f.Size = New System.Drawing.Size(352, 48)
        Me.txt02f.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 292)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(220, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Pendiente para la Próxima Consulta:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt02e
        '
        Me.txt02e.Location = New System.Drawing.Point(8, 244)
        Me.txt02e.MaxLength = 2048
        Me.txt02e.Multiline = True
        Me.txt02e.Name = "txt02e"
        Me.txt02e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt02e.Size = New System.Drawing.Size(352, 48)
        Me.txt02e.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(220, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Tratamientos Indicados en la Consulta:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt02d
        '
        Me.txt02d.Location = New System.Drawing.Point(8, 180)
        Me.txt02d.MaxLength = 2048
        Me.txt02d.Multiline = True
        Me.txt02d.Name = "txt02d"
        Me.txt02d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt02d.Size = New System.Drawing.Size(352, 48)
        Me.txt02d.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Procedimientos Realizados en la Consulta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt02b
        '
        Me.txt02b.BackColor = System.Drawing.SystemColors.Window
        Me.txt02b.Location = New System.Drawing.Point(128, 40)
        Me.txt02b.MaxLength = 255
        Me.txt02b.Name = "txt02b"
        Me.txt02b.ReadOnly = True
        Me.txt02b.Size = New System.Drawing.Size(120, 20)
        Me.txt02b.TabIndex = 4
        Me.txt02b.TabStop = False
        Me.txt02b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt02b, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt02a
        '
        Me.txt02a.BackColor = System.Drawing.SystemColors.Window
        Me.txt02a.Location = New System.Drawing.Point(8, 40)
        Me.txt02a.MaxLength = 255
        Me.txt02a.Name = "txt02a"
        Me.txt02a.ReadOnly = True
        Me.txt02a.Size = New System.Drawing.Size(120, 20)
        Me.txt02a.TabIndex = 3
        Me.txt02a.TabStop = False
        Me.txt02a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt02a, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt02g
        '
        Me.txt02g.BackColor = System.Drawing.SystemColors.Info
        Me.txt02g.Location = New System.Drawing.Point(376, 44)
        Me.txt02g.MaxLength = 4096
        Me.txt02g.Multiline = True
        Me.txt02g.Name = "txt02g"
        Me.txt02g.ReadOnly = True
        Me.txt02g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt02g.Size = New System.Drawing.Size(384, 312)
        Me.txt02g.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txt02g, "Para modificar el texto presiona el botón de arriba")
        '
        'txt02c
        '
        Me.txt02c.Location = New System.Drawing.Point(8, 84)
        Me.txt02c.MaxLength = 2048
        Me.txt02c.Multiline = True
        Me.txt02c.Name = "txt02c"
        Me.txt02c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt02c.Size = New System.Drawing.Size(352, 80)
        Me.txt02c.TabIndex = 7
        '
        'botEF02
        '
        Me.botEF02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEF02.Image = CType(resources.GetObject("botEF02.Image"), System.Drawing.Image)
        Me.botEF02.Location = New System.Drawing.Point(456, 16)
        Me.botEF02.Name = "botEF02"
        Me.botEF02.Size = New System.Drawing.Size(224, 23)
        Me.botEF02.TabIndex = 14
        Me.botEF02.Text = "Examen Físico de la Consulta"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Evolución de la Enfermedad Actual :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab3
        '
        Me.Tab3.Controls.Add(Me.GroupBox3)
        Me.Tab3.Location = New System.Drawing.Point(4, 22)
        Me.Tab3.Name = "Tab3"
        Me.Tab3.Size = New System.Drawing.Size(764, 362)
        Me.Tab3.TabIndex = 1
        Me.Tab3.Text = "3ª"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.botFecha03)
        Me.GroupBox3.Controls.Add(Me.txtDC03)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.botFUR03)
        Me.GroupBox3.Controls.Add(Me.txt03f)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.txt03e)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.txt03d)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.txt03b)
        Me.GroupBox3.Controls.Add(Me.txt03a)
        Me.GroupBox3.Controls.Add(Me.txt03g)
        Me.GroupBox3.Controls.Add(Me.txt03c)
        Me.GroupBox3.Controls.Add(Me.botEF03)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(764, 360)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "3ra Consulta"
        '
        'botFecha03
        '
        Me.botFecha03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFecha03.Image = CType(resources.GetObject("botFecha03.Image"), System.Drawing.Image)
        Me.botFecha03.Location = New System.Drawing.Point(8, 16)
        Me.botFecha03.Name = "botFecha03"
        Me.botFecha03.Size = New System.Drawing.Size(120, 23)
        Me.botFecha03.TabIndex = 0
        Me.botFecha03.TabStop = False
        Me.botFecha03.Text = "Fecha del Control"
        '
        'txtDC03
        '
        Me.txtDC03.BackColor = System.Drawing.SystemColors.Info
        Me.txtDC03.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC03.Location = New System.Drawing.Point(248, 40)
        Me.txtDC03.MaxLength = 255
        Me.txtDC03.Name = "txtDC03"
        Me.txtDC03.ReadOnly = True
        Me.txtDC03.Size = New System.Drawing.Size(120, 20)
        Me.txtDC03.TabIndex = 5
        Me.txtDC03.TabStop = False
        Me.txtDC03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(248, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Día del Ciclo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botFUR03
        '
        Me.botFUR03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR03.Image = CType(resources.GetObject("botFUR03.Image"), System.Drawing.Image)
        Me.botFUR03.Location = New System.Drawing.Point(128, 16)
        Me.botFUR03.Name = "botFUR03"
        Me.botFUR03.Size = New System.Drawing.Size(120, 23)
        Me.botFUR03.TabIndex = 1
        Me.botFUR03.TabStop = False
        Me.botFUR03.Text = "FUR"
        '
        'txt03f
        '
        Me.txt03f.Location = New System.Drawing.Point(8, 308)
        Me.txt03f.MaxLength = 2048
        Me.txt03f.Multiline = True
        Me.txt03f.Name = "txt03f"
        Me.txt03f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt03f.Size = New System.Drawing.Size(352, 48)
        Me.txt03f.TabIndex = 13
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 292)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(220, 16)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Pendiente para la Próxima Consulta:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt03e
        '
        Me.txt03e.Location = New System.Drawing.Point(8, 244)
        Me.txt03e.MaxLength = 2048
        Me.txt03e.Multiline = True
        Me.txt03e.Name = "txt03e"
        Me.txt03e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt03e.Size = New System.Drawing.Size(352, 48)
        Me.txt03e.TabIndex = 11
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(8, 228)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(220, 16)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Tratamientos Indicados en la Consulta:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt03d
        '
        Me.txt03d.Location = New System.Drawing.Point(8, 180)
        Me.txt03d.MaxLength = 2048
        Me.txt03d.Multiline = True
        Me.txt03d.Name = "txt03d"
        Me.txt03d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt03d.Size = New System.Drawing.Size(352, 48)
        Me.txt03d.TabIndex = 9
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(8, 164)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(220, 16)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Procedimientos Realizados en la Consulta:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt03b
        '
        Me.txt03b.BackColor = System.Drawing.SystemColors.Window
        Me.txt03b.Location = New System.Drawing.Point(128, 40)
        Me.txt03b.MaxLength = 255
        Me.txt03b.Name = "txt03b"
        Me.txt03b.ReadOnly = True
        Me.txt03b.Size = New System.Drawing.Size(120, 20)
        Me.txt03b.TabIndex = 4
        Me.txt03b.TabStop = False
        Me.txt03b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt03b, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt03a
        '
        Me.txt03a.BackColor = System.Drawing.SystemColors.Window
        Me.txt03a.Location = New System.Drawing.Point(8, 40)
        Me.txt03a.MaxLength = 255
        Me.txt03a.Name = "txt03a"
        Me.txt03a.ReadOnly = True
        Me.txt03a.Size = New System.Drawing.Size(120, 20)
        Me.txt03a.TabIndex = 3
        Me.txt03a.TabStop = False
        Me.txt03a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt03a, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt03g
        '
        Me.txt03g.BackColor = System.Drawing.SystemColors.Info
        Me.txt03g.Location = New System.Drawing.Point(376, 44)
        Me.txt03g.MaxLength = 4096
        Me.txt03g.Multiline = True
        Me.txt03g.Name = "txt03g"
        Me.txt03g.ReadOnly = True
        Me.txt03g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt03g.Size = New System.Drawing.Size(384, 312)
        Me.txt03g.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txt03g, "Para modificar el texto presiona el botón de arriba")
        '
        'txt03c
        '
        Me.txt03c.Location = New System.Drawing.Point(8, 84)
        Me.txt03c.MaxLength = 2048
        Me.txt03c.Multiline = True
        Me.txt03c.Name = "txt03c"
        Me.txt03c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt03c.Size = New System.Drawing.Size(352, 80)
        Me.txt03c.TabIndex = 7
        '
        'botEF03
        '
        Me.botEF03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEF03.Image = CType(resources.GetObject("botEF03.Image"), System.Drawing.Image)
        Me.botEF03.Location = New System.Drawing.Point(456, 16)
        Me.botEF03.Name = "botEF03"
        Me.botEF03.Size = New System.Drawing.Size(224, 23)
        Me.botEF03.TabIndex = 14
        Me.botEF03.Text = "Examen Físico de la Consulta"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(8, 68)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(192, 16)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Evolución de la Enfermedad Actual :"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab4
        '
        Me.Tab4.Controls.Add(Me.GroupBox4)
        Me.Tab4.Location = New System.Drawing.Point(4, 22)
        Me.Tab4.Name = "Tab4"
        Me.Tab4.Size = New System.Drawing.Size(764, 362)
        Me.Tab4.TabIndex = 2
        Me.Tab4.Text = "4ª"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.botFecha04)
        Me.GroupBox4.Controls.Add(Me.txtDC04)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.botFUR04)
        Me.GroupBox4.Controls.Add(Me.txt04f)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.txt04e)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.txt04d)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.txt04b)
        Me.GroupBox4.Controls.Add(Me.txt04a)
        Me.GroupBox4.Controls.Add(Me.txt04g)
        Me.GroupBox4.Controls.Add(Me.txt04c)
        Me.GroupBox4.Controls.Add(Me.botEF04)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(764, 360)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "4ta Consulta"
        '
        'botFecha04
        '
        Me.botFecha04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFecha04.Image = CType(resources.GetObject("botFecha04.Image"), System.Drawing.Image)
        Me.botFecha04.Location = New System.Drawing.Point(8, 16)
        Me.botFecha04.Name = "botFecha04"
        Me.botFecha04.Size = New System.Drawing.Size(120, 23)
        Me.botFecha04.TabIndex = 0
        Me.botFecha04.TabStop = False
        Me.botFecha04.Text = "Fecha del Control"
        '
        'txtDC04
        '
        Me.txtDC04.BackColor = System.Drawing.SystemColors.Info
        Me.txtDC04.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC04.Location = New System.Drawing.Point(248, 40)
        Me.txtDC04.MaxLength = 255
        Me.txtDC04.Name = "txtDC04"
        Me.txtDC04.ReadOnly = True
        Me.txtDC04.Size = New System.Drawing.Size(120, 20)
        Me.txtDC04.TabIndex = 5
        Me.txtDC04.TabStop = False
        Me.txtDC04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(248, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 23)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Día del Ciclo"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botFUR04
        '
        Me.botFUR04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR04.Image = CType(resources.GetObject("botFUR04.Image"), System.Drawing.Image)
        Me.botFUR04.Location = New System.Drawing.Point(128, 16)
        Me.botFUR04.Name = "botFUR04"
        Me.botFUR04.Size = New System.Drawing.Size(120, 23)
        Me.botFUR04.TabIndex = 1
        Me.botFUR04.TabStop = False
        Me.botFUR04.Text = "FUR"
        '
        'txt04f
        '
        Me.txt04f.Location = New System.Drawing.Point(8, 308)
        Me.txt04f.MaxLength = 2048
        Me.txt04f.Multiline = True
        Me.txt04f.Name = "txt04f"
        Me.txt04f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt04f.Size = New System.Drawing.Size(352, 48)
        Me.txt04f.TabIndex = 13
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(8, 292)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(220, 16)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "Pendiente para la Próxima Consulta:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt04e
        '
        Me.txt04e.Location = New System.Drawing.Point(8, 244)
        Me.txt04e.MaxLength = 2048
        Me.txt04e.Multiline = True
        Me.txt04e.Name = "txt04e"
        Me.txt04e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt04e.Size = New System.Drawing.Size(352, 48)
        Me.txt04e.TabIndex = 11
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(8, 228)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(220, 16)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Tratamientos Indicados en la Consulta:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt04d
        '
        Me.txt04d.Location = New System.Drawing.Point(8, 180)
        Me.txt04d.MaxLength = 2048
        Me.txt04d.Multiline = True
        Me.txt04d.Name = "txt04d"
        Me.txt04d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt04d.Size = New System.Drawing.Size(352, 48)
        Me.txt04d.TabIndex = 9
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(8, 164)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(220, 16)
        Me.Label33.TabIndex = 8
        Me.Label33.Text = "Procedimientos Realizados en la Consulta:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt04b
        '
        Me.txt04b.BackColor = System.Drawing.SystemColors.Window
        Me.txt04b.Location = New System.Drawing.Point(128, 40)
        Me.txt04b.MaxLength = 255
        Me.txt04b.Name = "txt04b"
        Me.txt04b.ReadOnly = True
        Me.txt04b.Size = New System.Drawing.Size(120, 20)
        Me.txt04b.TabIndex = 4
        Me.txt04b.TabStop = False
        Me.txt04b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt04b, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt04a
        '
        Me.txt04a.BackColor = System.Drawing.SystemColors.Window
        Me.txt04a.Location = New System.Drawing.Point(8, 40)
        Me.txt04a.MaxLength = 255
        Me.txt04a.Name = "txt04a"
        Me.txt04a.ReadOnly = True
        Me.txt04a.Size = New System.Drawing.Size(120, 20)
        Me.txt04a.TabIndex = 3
        Me.txt04a.TabStop = False
        Me.txt04a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt04a, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt04g
        '
        Me.txt04g.BackColor = System.Drawing.SystemColors.Info
        Me.txt04g.Location = New System.Drawing.Point(376, 44)
        Me.txt04g.MaxLength = 4096
        Me.txt04g.Multiline = True
        Me.txt04g.Name = "txt04g"
        Me.txt04g.ReadOnly = True
        Me.txt04g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt04g.Size = New System.Drawing.Size(384, 312)
        Me.txt04g.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txt04g, "Para modificar el texto presiona el botón de arriba")
        '
        'txt04c
        '
        Me.txt04c.Location = New System.Drawing.Point(8, 84)
        Me.txt04c.MaxLength = 2048
        Me.txt04c.Multiline = True
        Me.txt04c.Name = "txt04c"
        Me.txt04c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt04c.Size = New System.Drawing.Size(352, 80)
        Me.txt04c.TabIndex = 7
        '
        'botEF04
        '
        Me.botEF04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEF04.Image = CType(resources.GetObject("botEF04.Image"), System.Drawing.Image)
        Me.botEF04.Location = New System.Drawing.Point(456, 16)
        Me.botEF04.Name = "botEF04"
        Me.botEF04.Size = New System.Drawing.Size(224, 23)
        Me.botEF04.TabIndex = 14
        Me.botEF04.Text = "Examen Físico de la Consulta"
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(8, 68)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(192, 16)
        Me.Label37.TabIndex = 6
        Me.Label37.Text = "Evolución de la Enfermedad Actual :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab5
        '
        Me.Tab5.Controls.Add(Me.GroupBox5)
        Me.Tab5.Location = New System.Drawing.Point(4, 22)
        Me.Tab5.Name = "Tab5"
        Me.Tab5.Size = New System.Drawing.Size(764, 362)
        Me.Tab5.TabIndex = 3
        Me.Tab5.Text = "5ª"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.botFecha05)
        Me.GroupBox5.Controls.Add(Me.txtDC05)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.botFUR05)
        Me.GroupBox5.Controls.Add(Me.txt05f)
        Me.GroupBox5.Controls.Add(Me.Label38)
        Me.GroupBox5.Controls.Add(Me.txt05e)
        Me.GroupBox5.Controls.Add(Me.Label39)
        Me.GroupBox5.Controls.Add(Me.txt05d)
        Me.GroupBox5.Controls.Add(Me.Label40)
        Me.GroupBox5.Controls.Add(Me.txt05b)
        Me.GroupBox5.Controls.Add(Me.txt05a)
        Me.GroupBox5.Controls.Add(Me.txt05g)
        Me.GroupBox5.Controls.Add(Me.txt05c)
        Me.GroupBox5.Controls.Add(Me.botEF05)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(764, 360)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "5ta Consulta"
        '
        'botFecha05
        '
        Me.botFecha05.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFecha05.Image = CType(resources.GetObject("botFecha05.Image"), System.Drawing.Image)
        Me.botFecha05.Location = New System.Drawing.Point(8, 16)
        Me.botFecha05.Name = "botFecha05"
        Me.botFecha05.Size = New System.Drawing.Size(120, 23)
        Me.botFecha05.TabIndex = 0
        Me.botFecha05.TabStop = False
        Me.botFecha05.Text = "Fecha del Control"
        '
        'txtDC05
        '
        Me.txtDC05.BackColor = System.Drawing.SystemColors.Info
        Me.txtDC05.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC05.Location = New System.Drawing.Point(248, 40)
        Me.txtDC05.MaxLength = 255
        Me.txtDC05.Name = "txtDC05"
        Me.txtDC05.ReadOnly = True
        Me.txtDC05.Size = New System.Drawing.Size(120, 20)
        Me.txtDC05.TabIndex = 5
        Me.txtDC05.TabStop = False
        Me.txtDC05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Image = CType(resources.GetObject("Label28.Image"), System.Drawing.Image)
        Me.Label28.Location = New System.Drawing.Point(248, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(120, 23)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Día del Ciclo"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botFUR05
        '
        Me.botFUR05.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR05.Image = CType(resources.GetObject("botFUR05.Image"), System.Drawing.Image)
        Me.botFUR05.Location = New System.Drawing.Point(128, 16)
        Me.botFUR05.Name = "botFUR05"
        Me.botFUR05.Size = New System.Drawing.Size(120, 23)
        Me.botFUR05.TabIndex = 1
        Me.botFUR05.TabStop = False
        Me.botFUR05.Text = "FUR"
        '
        'txt05f
        '
        Me.txt05f.Location = New System.Drawing.Point(8, 308)
        Me.txt05f.MaxLength = 2048
        Me.txt05f.Multiline = True
        Me.txt05f.Name = "txt05f"
        Me.txt05f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt05f.Size = New System.Drawing.Size(352, 48)
        Me.txt05f.TabIndex = 13
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(8, 292)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(220, 16)
        Me.Label38.TabIndex = 12
        Me.Label38.Text = "Pendiente para la Próxima Consulta:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt05e
        '
        Me.txt05e.Location = New System.Drawing.Point(8, 244)
        Me.txt05e.MaxLength = 2048
        Me.txt05e.Multiline = True
        Me.txt05e.Name = "txt05e"
        Me.txt05e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt05e.Size = New System.Drawing.Size(352, 48)
        Me.txt05e.TabIndex = 11
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(8, 228)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(220, 16)
        Me.Label39.TabIndex = 10
        Me.Label39.Text = "Tratamientos Indicados en la Consulta:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt05d
        '
        Me.txt05d.Location = New System.Drawing.Point(8, 180)
        Me.txt05d.MaxLength = 2048
        Me.txt05d.Multiline = True
        Me.txt05d.Name = "txt05d"
        Me.txt05d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt05d.Size = New System.Drawing.Size(352, 48)
        Me.txt05d.TabIndex = 9
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(8, 164)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(220, 16)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Procedimientos Realizados en la Consulta:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt05b
        '
        Me.txt05b.BackColor = System.Drawing.SystemColors.Window
        Me.txt05b.Location = New System.Drawing.Point(128, 40)
        Me.txt05b.MaxLength = 255
        Me.txt05b.Name = "txt05b"
        Me.txt05b.ReadOnly = True
        Me.txt05b.Size = New System.Drawing.Size(120, 20)
        Me.txt05b.TabIndex = 4
        Me.txt05b.TabStop = False
        Me.txt05b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt05b, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt05a
        '
        Me.txt05a.BackColor = System.Drawing.SystemColors.Window
        Me.txt05a.Location = New System.Drawing.Point(8, 40)
        Me.txt05a.MaxLength = 255
        Me.txt05a.Name = "txt05a"
        Me.txt05a.ReadOnly = True
        Me.txt05a.Size = New System.Drawing.Size(120, 20)
        Me.txt05a.TabIndex = 3
        Me.txt05a.TabStop = False
        Me.txt05a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt05a, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt05g
        '
        Me.txt05g.BackColor = System.Drawing.SystemColors.Info
        Me.txt05g.Location = New System.Drawing.Point(376, 44)
        Me.txt05g.MaxLength = 4096
        Me.txt05g.Multiline = True
        Me.txt05g.Name = "txt05g"
        Me.txt05g.ReadOnly = True
        Me.txt05g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt05g.Size = New System.Drawing.Size(384, 312)
        Me.txt05g.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txt05g, "Para modificar el texto presiona el botón de arriba")
        '
        'txt05c
        '
        Me.txt05c.Location = New System.Drawing.Point(8, 84)
        Me.txt05c.MaxLength = 2048
        Me.txt05c.Multiline = True
        Me.txt05c.Name = "txt05c"
        Me.txt05c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt05c.Size = New System.Drawing.Size(352, 80)
        Me.txt05c.TabIndex = 7
        '
        'botEF05
        '
        Me.botEF05.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEF05.Image = CType(resources.GetObject("botEF05.Image"), System.Drawing.Image)
        Me.botEF05.Location = New System.Drawing.Point(456, 16)
        Me.botEF05.Name = "botEF05"
        Me.botEF05.Size = New System.Drawing.Size(224, 23)
        Me.botEF05.TabIndex = 14
        Me.botEF05.Text = "Examen Físico de la Consulta"
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(8, 68)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(192, 16)
        Me.Label44.TabIndex = 6
        Me.Label44.Text = "Evolución de la Enfermedad Actual :"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab6
        '
        Me.Tab6.Controls.Add(Me.GroupBox6)
        Me.Tab6.Location = New System.Drawing.Point(4, 22)
        Me.Tab6.Name = "Tab6"
        Me.Tab6.Size = New System.Drawing.Size(764, 362)
        Me.Tab6.TabIndex = 4
        Me.Tab6.Text = "6ª"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.botFecha06)
        Me.GroupBox6.Controls.Add(Me.txtDC06)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.botFUR06)
        Me.GroupBox6.Controls.Add(Me.txt06f)
        Me.GroupBox6.Controls.Add(Me.Label45)
        Me.GroupBox6.Controls.Add(Me.txt06e)
        Me.GroupBox6.Controls.Add(Me.Label46)
        Me.GroupBox6.Controls.Add(Me.txt06d)
        Me.GroupBox6.Controls.Add(Me.Label47)
        Me.GroupBox6.Controls.Add(Me.txt06b)
        Me.GroupBox6.Controls.Add(Me.txt06a)
        Me.GroupBox6.Controls.Add(Me.txt06g)
        Me.GroupBox6.Controls.Add(Me.txt06c)
        Me.GroupBox6.Controls.Add(Me.botEF06)
        Me.GroupBox6.Controls.Add(Me.Label50)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(764, 360)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "6ta Consulta"
        '
        'botFecha06
        '
        Me.botFecha06.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFecha06.Image = CType(resources.GetObject("botFecha06.Image"), System.Drawing.Image)
        Me.botFecha06.Location = New System.Drawing.Point(8, 16)
        Me.botFecha06.Name = "botFecha06"
        Me.botFecha06.Size = New System.Drawing.Size(120, 23)
        Me.botFecha06.TabIndex = 0
        Me.botFecha06.TabStop = False
        Me.botFecha06.Text = "Fecha del Control"
        '
        'txtDC06
        '
        Me.txtDC06.BackColor = System.Drawing.SystemColors.Info
        Me.txtDC06.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC06.Location = New System.Drawing.Point(248, 40)
        Me.txtDC06.MaxLength = 255
        Me.txtDC06.Name = "txtDC06"
        Me.txtDC06.ReadOnly = True
        Me.txtDC06.Size = New System.Drawing.Size(120, 20)
        Me.txtDC06.TabIndex = 5
        Me.txtDC06.TabStop = False
        Me.txtDC06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Image = CType(resources.GetObject("Label29.Image"), System.Drawing.Image)
        Me.Label29.Location = New System.Drawing.Point(248, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 23)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Día del Ciclo"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botFUR06
        '
        Me.botFUR06.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR06.Image = CType(resources.GetObject("botFUR06.Image"), System.Drawing.Image)
        Me.botFUR06.Location = New System.Drawing.Point(128, 16)
        Me.botFUR06.Name = "botFUR06"
        Me.botFUR06.Size = New System.Drawing.Size(120, 23)
        Me.botFUR06.TabIndex = 1
        Me.botFUR06.TabStop = False
        Me.botFUR06.Text = "FUR"
        '
        'txt06f
        '
        Me.txt06f.Location = New System.Drawing.Point(8, 308)
        Me.txt06f.MaxLength = 2048
        Me.txt06f.Multiline = True
        Me.txt06f.Name = "txt06f"
        Me.txt06f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt06f.Size = New System.Drawing.Size(352, 48)
        Me.txt06f.TabIndex = 13
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(8, 292)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(220, 16)
        Me.Label45.TabIndex = 12
        Me.Label45.Text = "Pendiente para la Próxima Consulta:"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt06e
        '
        Me.txt06e.Location = New System.Drawing.Point(8, 244)
        Me.txt06e.MaxLength = 2048
        Me.txt06e.Multiline = True
        Me.txt06e.Name = "txt06e"
        Me.txt06e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt06e.Size = New System.Drawing.Size(352, 48)
        Me.txt06e.TabIndex = 11
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(8, 228)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(220, 16)
        Me.Label46.TabIndex = 10
        Me.Label46.Text = "Tratamientos Indicados en la Consulta:"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt06d
        '
        Me.txt06d.Location = New System.Drawing.Point(8, 180)
        Me.txt06d.MaxLength = 2048
        Me.txt06d.Multiline = True
        Me.txt06d.Name = "txt06d"
        Me.txt06d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt06d.Size = New System.Drawing.Size(352, 48)
        Me.txt06d.TabIndex = 9
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(8, 164)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(220, 16)
        Me.Label47.TabIndex = 8
        Me.Label47.Text = "Procedimientos Realizados en la Consulta:"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt06b
        '
        Me.txt06b.BackColor = System.Drawing.SystemColors.Window
        Me.txt06b.Location = New System.Drawing.Point(128, 40)
        Me.txt06b.MaxLength = 255
        Me.txt06b.Name = "txt06b"
        Me.txt06b.ReadOnly = True
        Me.txt06b.Size = New System.Drawing.Size(120, 20)
        Me.txt06b.TabIndex = 4
        Me.txt06b.TabStop = False
        Me.txt06b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt06b, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt06a
        '
        Me.txt06a.BackColor = System.Drawing.SystemColors.Window
        Me.txt06a.Location = New System.Drawing.Point(8, 40)
        Me.txt06a.MaxLength = 255
        Me.txt06a.Name = "txt06a"
        Me.txt06a.ReadOnly = True
        Me.txt06a.Size = New System.Drawing.Size(120, 20)
        Me.txt06a.TabIndex = 3
        Me.txt06a.TabStop = False
        Me.txt06a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt06a, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt06g
        '
        Me.txt06g.BackColor = System.Drawing.SystemColors.Info
        Me.txt06g.Location = New System.Drawing.Point(376, 44)
        Me.txt06g.MaxLength = 4096
        Me.txt06g.Multiline = True
        Me.txt06g.Name = "txt06g"
        Me.txt06g.ReadOnly = True
        Me.txt06g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt06g.Size = New System.Drawing.Size(384, 312)
        Me.txt06g.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txt06g, "Para modificar el texto presiona el botón de arriba")
        '
        'txt06c
        '
        Me.txt06c.Location = New System.Drawing.Point(8, 84)
        Me.txt06c.MaxLength = 2048
        Me.txt06c.Multiline = True
        Me.txt06c.Name = "txt06c"
        Me.txt06c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt06c.Size = New System.Drawing.Size(352, 80)
        Me.txt06c.TabIndex = 7
        '
        'botEF06
        '
        Me.botEF06.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEF06.Image = CType(resources.GetObject("botEF06.Image"), System.Drawing.Image)
        Me.botEF06.Location = New System.Drawing.Point(456, 16)
        Me.botEF06.Name = "botEF06"
        Me.botEF06.Size = New System.Drawing.Size(224, 23)
        Me.botEF06.TabIndex = 14
        Me.botEF06.Text = "Examen Físico de la Consulta"
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(8, 68)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(192, 16)
        Me.Label50.TabIndex = 6
        Me.Label50.Text = "Evolución de la Enfermedad Actual :"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab7
        '
        Me.Tab7.Controls.Add(Me.GroupBox7)
        Me.Tab7.Location = New System.Drawing.Point(4, 22)
        Me.Tab7.Name = "Tab7"
        Me.Tab7.Size = New System.Drawing.Size(764, 362)
        Me.Tab7.TabIndex = 5
        Me.Tab7.Text = "7ª"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.botFecha07)
        Me.GroupBox7.Controls.Add(Me.txtDC07)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.botFUR07)
        Me.GroupBox7.Controls.Add(Me.txt07f)
        Me.GroupBox7.Controls.Add(Me.Label71)
        Me.GroupBox7.Controls.Add(Me.txt07e)
        Me.GroupBox7.Controls.Add(Me.Label72)
        Me.GroupBox7.Controls.Add(Me.txt07d)
        Me.GroupBox7.Controls.Add(Me.Label73)
        Me.GroupBox7.Controls.Add(Me.txt07b)
        Me.GroupBox7.Controls.Add(Me.txt07a)
        Me.GroupBox7.Controls.Add(Me.txt07g)
        Me.GroupBox7.Controls.Add(Me.txt07c)
        Me.GroupBox7.Controls.Add(Me.botEF07)
        Me.GroupBox7.Controls.Add(Me.Label76)
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(764, 360)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "7ma Consulta"
        '
        'botFecha07
        '
        Me.botFecha07.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFecha07.Image = CType(resources.GetObject("botFecha07.Image"), System.Drawing.Image)
        Me.botFecha07.Location = New System.Drawing.Point(8, 16)
        Me.botFecha07.Name = "botFecha07"
        Me.botFecha07.Size = New System.Drawing.Size(120, 23)
        Me.botFecha07.TabIndex = 0
        Me.botFecha07.TabStop = False
        Me.botFecha07.Text = "Fecha del Control"
        '
        'txtDC07
        '
        Me.txtDC07.BackColor = System.Drawing.SystemColors.Info
        Me.txtDC07.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC07.Location = New System.Drawing.Point(248, 40)
        Me.txtDC07.MaxLength = 255
        Me.txtDC07.Name = "txtDC07"
        Me.txtDC07.ReadOnly = True
        Me.txtDC07.Size = New System.Drawing.Size(120, 20)
        Me.txtDC07.TabIndex = 5
        Me.txtDC07.TabStop = False
        Me.txtDC07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Image = CType(resources.GetObject("Label34.Image"), System.Drawing.Image)
        Me.Label34.Location = New System.Drawing.Point(248, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(120, 23)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Día del Ciclo"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botFUR07
        '
        Me.botFUR07.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR07.Image = CType(resources.GetObject("botFUR07.Image"), System.Drawing.Image)
        Me.botFUR07.Location = New System.Drawing.Point(128, 16)
        Me.botFUR07.Name = "botFUR07"
        Me.botFUR07.Size = New System.Drawing.Size(120, 23)
        Me.botFUR07.TabIndex = 1
        Me.botFUR07.TabStop = False
        Me.botFUR07.Text = "FUR"
        '
        'txt07f
        '
        Me.txt07f.Location = New System.Drawing.Point(8, 308)
        Me.txt07f.MaxLength = 2048
        Me.txt07f.Multiline = True
        Me.txt07f.Name = "txt07f"
        Me.txt07f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt07f.Size = New System.Drawing.Size(352, 48)
        Me.txt07f.TabIndex = 13
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(8, 292)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(220, 16)
        Me.Label71.TabIndex = 12
        Me.Label71.Text = "Pendiente para la Próxima Consulta:"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt07e
        '
        Me.txt07e.Location = New System.Drawing.Point(8, 244)
        Me.txt07e.MaxLength = 2048
        Me.txt07e.Multiline = True
        Me.txt07e.Name = "txt07e"
        Me.txt07e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt07e.Size = New System.Drawing.Size(352, 48)
        Me.txt07e.TabIndex = 11
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(8, 228)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(220, 16)
        Me.Label72.TabIndex = 10
        Me.Label72.Text = "Tratamientos Indicados en la Consulta:"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt07d
        '
        Me.txt07d.Location = New System.Drawing.Point(8, 180)
        Me.txt07d.MaxLength = 2048
        Me.txt07d.Multiline = True
        Me.txt07d.Name = "txt07d"
        Me.txt07d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt07d.Size = New System.Drawing.Size(352, 48)
        Me.txt07d.TabIndex = 9
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(8, 164)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(220, 16)
        Me.Label73.TabIndex = 8
        Me.Label73.Text = "Procedimientos Realizados en la Consulta:"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt07b
        '
        Me.txt07b.BackColor = System.Drawing.SystemColors.Window
        Me.txt07b.Location = New System.Drawing.Point(128, 40)
        Me.txt07b.MaxLength = 255
        Me.txt07b.Name = "txt07b"
        Me.txt07b.ReadOnly = True
        Me.txt07b.Size = New System.Drawing.Size(120, 20)
        Me.txt07b.TabIndex = 4
        Me.txt07b.TabStop = False
        Me.txt07b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt07b, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt07a
        '
        Me.txt07a.BackColor = System.Drawing.SystemColors.Window
        Me.txt07a.Location = New System.Drawing.Point(8, 40)
        Me.txt07a.MaxLength = 255
        Me.txt07a.Name = "txt07a"
        Me.txt07a.ReadOnly = True
        Me.txt07a.Size = New System.Drawing.Size(120, 20)
        Me.txt07a.TabIndex = 3
        Me.txt07a.TabStop = False
        Me.txt07a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt07a, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt07g
        '
        Me.txt07g.BackColor = System.Drawing.SystemColors.Info
        Me.txt07g.Location = New System.Drawing.Point(376, 44)
        Me.txt07g.MaxLength = 4096
        Me.txt07g.Multiline = True
        Me.txt07g.Name = "txt07g"
        Me.txt07g.ReadOnly = True
        Me.txt07g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt07g.Size = New System.Drawing.Size(384, 312)
        Me.txt07g.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txt07g, "Para modificar el texto presiona el botón de arriba")
        '
        'txt07c
        '
        Me.txt07c.Location = New System.Drawing.Point(8, 84)
        Me.txt07c.MaxLength = 2048
        Me.txt07c.Multiline = True
        Me.txt07c.Name = "txt07c"
        Me.txt07c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt07c.Size = New System.Drawing.Size(352, 80)
        Me.txt07c.TabIndex = 7
        '
        'botEF07
        '
        Me.botEF07.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEF07.Image = CType(resources.GetObject("botEF07.Image"), System.Drawing.Image)
        Me.botEF07.Location = New System.Drawing.Point(456, 16)
        Me.botEF07.Name = "botEF07"
        Me.botEF07.Size = New System.Drawing.Size(224, 23)
        Me.botEF07.TabIndex = 14
        Me.botEF07.Text = "Examen Físico de la Consulta"
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(8, 68)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(192, 16)
        Me.Label76.TabIndex = 6
        Me.Label76.Text = "Evolución de la Enfermedad Actual :"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab8
        '
        Me.Tab8.Controls.Add(Me.GroupBox8)
        Me.Tab8.Location = New System.Drawing.Point(4, 22)
        Me.Tab8.Name = "Tab8"
        Me.Tab8.Size = New System.Drawing.Size(764, 362)
        Me.Tab8.TabIndex = 6
        Me.Tab8.Text = "8ª"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.botFecha08)
        Me.GroupBox8.Controls.Add(Me.txtDC08)
        Me.GroupBox8.Controls.Add(Me.Label36)
        Me.GroupBox8.Controls.Add(Me.botFUR08)
        Me.GroupBox8.Controls.Add(Me.txt08f)
        Me.GroupBox8.Controls.Add(Me.Label77)
        Me.GroupBox8.Controls.Add(Me.txt08e)
        Me.GroupBox8.Controls.Add(Me.Label78)
        Me.GroupBox8.Controls.Add(Me.txt08d)
        Me.GroupBox8.Controls.Add(Me.Label79)
        Me.GroupBox8.Controls.Add(Me.txt08b)
        Me.GroupBox8.Controls.Add(Me.txt08a)
        Me.GroupBox8.Controls.Add(Me.txt08g)
        Me.GroupBox8.Controls.Add(Me.txt08c)
        Me.GroupBox8.Controls.Add(Me.botEF08)
        Me.GroupBox8.Controls.Add(Me.Label82)
        Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(764, 360)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "8va Consulta"
        '
        'botFecha08
        '
        Me.botFecha08.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFecha08.Image = CType(resources.GetObject("botFecha08.Image"), System.Drawing.Image)
        Me.botFecha08.Location = New System.Drawing.Point(8, 16)
        Me.botFecha08.Name = "botFecha08"
        Me.botFecha08.Size = New System.Drawing.Size(120, 23)
        Me.botFecha08.TabIndex = 0
        Me.botFecha08.TabStop = False
        Me.botFecha08.Text = "Fecha del Control"
        '
        'txtDC08
        '
        Me.txtDC08.BackColor = System.Drawing.SystemColors.Info
        Me.txtDC08.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC08.Location = New System.Drawing.Point(248, 40)
        Me.txtDC08.MaxLength = 255
        Me.txtDC08.Name = "txtDC08"
        Me.txtDC08.ReadOnly = True
        Me.txtDC08.Size = New System.Drawing.Size(120, 20)
        Me.txtDC08.TabIndex = 5
        Me.txtDC08.TabStop = False
        Me.txtDC08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.Image = CType(resources.GetObject("Label36.Image"), System.Drawing.Image)
        Me.Label36.Location = New System.Drawing.Point(248, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(120, 23)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "Día del Ciclo"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botFUR08
        '
        Me.botFUR08.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR08.Image = CType(resources.GetObject("botFUR08.Image"), System.Drawing.Image)
        Me.botFUR08.Location = New System.Drawing.Point(128, 16)
        Me.botFUR08.Name = "botFUR08"
        Me.botFUR08.Size = New System.Drawing.Size(120, 23)
        Me.botFUR08.TabIndex = 1
        Me.botFUR08.TabStop = False
        Me.botFUR08.Text = "FUR"
        '
        'txt08f
        '
        Me.txt08f.Location = New System.Drawing.Point(8, 308)
        Me.txt08f.MaxLength = 2048
        Me.txt08f.Multiline = True
        Me.txt08f.Name = "txt08f"
        Me.txt08f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt08f.Size = New System.Drawing.Size(352, 48)
        Me.txt08f.TabIndex = 13
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(8, 292)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(220, 16)
        Me.Label77.TabIndex = 12
        Me.Label77.Text = "Pendiente para la Próxima Consulta:"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt08e
        '
        Me.txt08e.Location = New System.Drawing.Point(8, 244)
        Me.txt08e.MaxLength = 2048
        Me.txt08e.Multiline = True
        Me.txt08e.Name = "txt08e"
        Me.txt08e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt08e.Size = New System.Drawing.Size(352, 48)
        Me.txt08e.TabIndex = 11
        '
        'Label78
        '
        Me.Label78.Location = New System.Drawing.Point(8, 228)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(220, 16)
        Me.Label78.TabIndex = 10
        Me.Label78.Text = "Tratamientos Indicados en la Consulta:"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt08d
        '
        Me.txt08d.Location = New System.Drawing.Point(8, 180)
        Me.txt08d.MaxLength = 2048
        Me.txt08d.Multiline = True
        Me.txt08d.Name = "txt08d"
        Me.txt08d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt08d.Size = New System.Drawing.Size(352, 48)
        Me.txt08d.TabIndex = 9
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(8, 164)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(220, 16)
        Me.Label79.TabIndex = 8
        Me.Label79.Text = "Procedimientos Realizados en la Consulta:"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt08b
        '
        Me.txt08b.BackColor = System.Drawing.SystemColors.Window
        Me.txt08b.Location = New System.Drawing.Point(128, 40)
        Me.txt08b.MaxLength = 255
        Me.txt08b.Name = "txt08b"
        Me.txt08b.ReadOnly = True
        Me.txt08b.Size = New System.Drawing.Size(120, 20)
        Me.txt08b.TabIndex = 4
        Me.txt08b.TabStop = False
        Me.txt08b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt08b, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt08a
        '
        Me.txt08a.BackColor = System.Drawing.SystemColors.Window
        Me.txt08a.Location = New System.Drawing.Point(8, 40)
        Me.txt08a.MaxLength = 255
        Me.txt08a.Name = "txt08a"
        Me.txt08a.ReadOnly = True
        Me.txt08a.Size = New System.Drawing.Size(120, 20)
        Me.txt08a.TabIndex = 3
        Me.txt08a.TabStop = False
        Me.txt08a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt08a, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt08g
        '
        Me.txt08g.BackColor = System.Drawing.SystemColors.Info
        Me.txt08g.Location = New System.Drawing.Point(376, 44)
        Me.txt08g.MaxLength = 4096
        Me.txt08g.Multiline = True
        Me.txt08g.Name = "txt08g"
        Me.txt08g.ReadOnly = True
        Me.txt08g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt08g.Size = New System.Drawing.Size(384, 312)
        Me.txt08g.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txt08g, "Para modificar el texto presiona el botón de arriba")
        '
        'txt08c
        '
        Me.txt08c.Location = New System.Drawing.Point(8, 84)
        Me.txt08c.MaxLength = 2048
        Me.txt08c.Multiline = True
        Me.txt08c.Name = "txt08c"
        Me.txt08c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt08c.Size = New System.Drawing.Size(352, 80)
        Me.txt08c.TabIndex = 7
        '
        'botEF08
        '
        Me.botEF08.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEF08.Image = CType(resources.GetObject("botEF08.Image"), System.Drawing.Image)
        Me.botEF08.Location = New System.Drawing.Point(456, 16)
        Me.botEF08.Name = "botEF08"
        Me.botEF08.Size = New System.Drawing.Size(224, 23)
        Me.botEF08.TabIndex = 14
        Me.botEF08.Text = "Examen Físico de la Consulta"
        '
        'Label82
        '
        Me.Label82.Location = New System.Drawing.Point(8, 68)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(192, 16)
        Me.Label82.TabIndex = 6
        Me.Label82.Text = "Evolución de la Enfermedad Actual :"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab9
        '
        Me.Tab9.Controls.Add(Me.GroupBox9)
        Me.Tab9.Location = New System.Drawing.Point(4, 22)
        Me.Tab9.Name = "Tab9"
        Me.Tab9.Size = New System.Drawing.Size(764, 362)
        Me.Tab9.TabIndex = 7
        Me.Tab9.Text = "9ª"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.botFecha09)
        Me.GroupBox9.Controls.Add(Me.txtDC09)
        Me.GroupBox9.Controls.Add(Me.Label41)
        Me.GroupBox9.Controls.Add(Me.botFUR09)
        Me.GroupBox9.Controls.Add(Me.txt09f)
        Me.GroupBox9.Controls.Add(Me.Label83)
        Me.GroupBox9.Controls.Add(Me.txt09e)
        Me.GroupBox9.Controls.Add(Me.Label84)
        Me.GroupBox9.Controls.Add(Me.txt09d)
        Me.GroupBox9.Controls.Add(Me.Label85)
        Me.GroupBox9.Controls.Add(Me.txt09b)
        Me.GroupBox9.Controls.Add(Me.txt09a)
        Me.GroupBox9.Controls.Add(Me.txt09g)
        Me.GroupBox9.Controls.Add(Me.txt09c)
        Me.GroupBox9.Controls.Add(Me.botEF09)
        Me.GroupBox9.Controls.Add(Me.Label88)
        Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(764, 360)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "9na Consulta"
        '
        'botFecha09
        '
        Me.botFecha09.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFecha09.Image = CType(resources.GetObject("botFecha09.Image"), System.Drawing.Image)
        Me.botFecha09.Location = New System.Drawing.Point(8, 16)
        Me.botFecha09.Name = "botFecha09"
        Me.botFecha09.Size = New System.Drawing.Size(120, 23)
        Me.botFecha09.TabIndex = 0
        Me.botFecha09.TabStop = False
        Me.botFecha09.Text = "Fecha del Control"
        '
        'txtDC09
        '
        Me.txtDC09.BackColor = System.Drawing.SystemColors.Info
        Me.txtDC09.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC09.Location = New System.Drawing.Point(248, 40)
        Me.txtDC09.MaxLength = 255
        Me.txtDC09.Name = "txtDC09"
        Me.txtDC09.ReadOnly = True
        Me.txtDC09.Size = New System.Drawing.Size(120, 20)
        Me.txtDC09.TabIndex = 5
        Me.txtDC09.TabStop = False
        Me.txtDC09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Image = CType(resources.GetObject("Label41.Image"), System.Drawing.Image)
        Me.Label41.Location = New System.Drawing.Point(248, 16)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(120, 23)
        Me.Label41.TabIndex = 2
        Me.Label41.Text = "Día del Ciclo"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botFUR09
        '
        Me.botFUR09.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR09.Image = CType(resources.GetObject("botFUR09.Image"), System.Drawing.Image)
        Me.botFUR09.Location = New System.Drawing.Point(128, 16)
        Me.botFUR09.Name = "botFUR09"
        Me.botFUR09.Size = New System.Drawing.Size(120, 23)
        Me.botFUR09.TabIndex = 1
        Me.botFUR09.TabStop = False
        Me.botFUR09.Text = "FUR"
        '
        'txt09f
        '
        Me.txt09f.Location = New System.Drawing.Point(8, 308)
        Me.txt09f.MaxLength = 2048
        Me.txt09f.Multiline = True
        Me.txt09f.Name = "txt09f"
        Me.txt09f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt09f.Size = New System.Drawing.Size(352, 48)
        Me.txt09f.TabIndex = 13
        '
        'Label83
        '
        Me.Label83.Location = New System.Drawing.Point(8, 292)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(220, 16)
        Me.Label83.TabIndex = 12
        Me.Label83.Text = "Pendiente para la Próxima Consulta:"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt09e
        '
        Me.txt09e.Location = New System.Drawing.Point(8, 244)
        Me.txt09e.MaxLength = 2048
        Me.txt09e.Multiline = True
        Me.txt09e.Name = "txt09e"
        Me.txt09e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt09e.Size = New System.Drawing.Size(352, 48)
        Me.txt09e.TabIndex = 11
        '
        'Label84
        '
        Me.Label84.Location = New System.Drawing.Point(8, 228)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(220, 16)
        Me.Label84.TabIndex = 10
        Me.Label84.Text = "Tratamientos Indicados en la Consulta:"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt09d
        '
        Me.txt09d.Location = New System.Drawing.Point(8, 180)
        Me.txt09d.MaxLength = 2048
        Me.txt09d.Multiline = True
        Me.txt09d.Name = "txt09d"
        Me.txt09d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt09d.Size = New System.Drawing.Size(352, 48)
        Me.txt09d.TabIndex = 9
        '
        'Label85
        '
        Me.Label85.Location = New System.Drawing.Point(8, 164)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(220, 16)
        Me.Label85.TabIndex = 8
        Me.Label85.Text = "Procedimientos Realizados en la Consulta:"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt09b
        '
        Me.txt09b.BackColor = System.Drawing.SystemColors.Window
        Me.txt09b.Location = New System.Drawing.Point(128, 40)
        Me.txt09b.MaxLength = 255
        Me.txt09b.Name = "txt09b"
        Me.txt09b.ReadOnly = True
        Me.txt09b.Size = New System.Drawing.Size(120, 20)
        Me.txt09b.TabIndex = 4
        Me.txt09b.TabStop = False
        Me.txt09b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt09b, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt09a
        '
        Me.txt09a.BackColor = System.Drawing.SystemColors.Window
        Me.txt09a.Location = New System.Drawing.Point(8, 40)
        Me.txt09a.MaxLength = 255
        Me.txt09a.Name = "txt09a"
        Me.txt09a.ReadOnly = True
        Me.txt09a.Size = New System.Drawing.Size(120, 20)
        Me.txt09a.TabIndex = 3
        Me.txt09a.TabStop = False
        Me.txt09a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt09a, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt09g
        '
        Me.txt09g.BackColor = System.Drawing.SystemColors.Info
        Me.txt09g.Location = New System.Drawing.Point(376, 44)
        Me.txt09g.MaxLength = 4096
        Me.txt09g.Multiline = True
        Me.txt09g.Name = "txt09g"
        Me.txt09g.ReadOnly = True
        Me.txt09g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt09g.Size = New System.Drawing.Size(384, 312)
        Me.txt09g.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txt09g, "Para modificar el texto presiona el botón de arriba")
        '
        'txt09c
        '
        Me.txt09c.Location = New System.Drawing.Point(8, 84)
        Me.txt09c.MaxLength = 2048
        Me.txt09c.Multiline = True
        Me.txt09c.Name = "txt09c"
        Me.txt09c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt09c.Size = New System.Drawing.Size(352, 80)
        Me.txt09c.TabIndex = 7
        '
        'botEF09
        '
        Me.botEF09.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEF09.Image = CType(resources.GetObject("botEF09.Image"), System.Drawing.Image)
        Me.botEF09.Location = New System.Drawing.Point(456, 16)
        Me.botEF09.Name = "botEF09"
        Me.botEF09.Size = New System.Drawing.Size(224, 23)
        Me.botEF09.TabIndex = 14
        Me.botEF09.Text = "Examen Físico de la Consulta"
        '
        'Label88
        '
        Me.Label88.Location = New System.Drawing.Point(8, 68)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(192, 16)
        Me.Label88.TabIndex = 6
        Me.Label88.Text = "Evolución de la Enfermedad Actual :"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab10
        '
        Me.Tab10.Controls.Add(Me.GroupBox10)
        Me.Tab10.Location = New System.Drawing.Point(4, 22)
        Me.Tab10.Name = "Tab10"
        Me.Tab10.Size = New System.Drawing.Size(764, 362)
        Me.Tab10.TabIndex = 8
        Me.Tab10.Text = "10ª"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.botFecha10)
        Me.GroupBox10.Controls.Add(Me.txtDC10)
        Me.GroupBox10.Controls.Add(Me.Label43)
        Me.GroupBox10.Controls.Add(Me.botFUR10)
        Me.GroupBox10.Controls.Add(Me.txt10f)
        Me.GroupBox10.Controls.Add(Me.Label89)
        Me.GroupBox10.Controls.Add(Me.txt10e)
        Me.GroupBox10.Controls.Add(Me.Label90)
        Me.GroupBox10.Controls.Add(Me.txt10d)
        Me.GroupBox10.Controls.Add(Me.Label91)
        Me.GroupBox10.Controls.Add(Me.txt10b)
        Me.GroupBox10.Controls.Add(Me.txt10a)
        Me.GroupBox10.Controls.Add(Me.txt10g)
        Me.GroupBox10.Controls.Add(Me.txt10c)
        Me.GroupBox10.Controls.Add(Me.botEF10)
        Me.GroupBox10.Controls.Add(Me.Label94)
        Me.GroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(764, 360)
        Me.GroupBox10.TabIndex = 2
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "10ma Consulta"
        '
        'botFecha10
        '
        Me.botFecha10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFecha10.Image = CType(resources.GetObject("botFecha10.Image"), System.Drawing.Image)
        Me.botFecha10.Location = New System.Drawing.Point(8, 16)
        Me.botFecha10.Name = "botFecha10"
        Me.botFecha10.Size = New System.Drawing.Size(120, 23)
        Me.botFecha10.TabIndex = 0
        Me.botFecha10.TabStop = False
        Me.botFecha10.Text = "Fecha del Control"
        '
        'txtDC10
        '
        Me.txtDC10.BackColor = System.Drawing.SystemColors.Info
        Me.txtDC10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDC10.Location = New System.Drawing.Point(248, 40)
        Me.txtDC10.MaxLength = 255
        Me.txtDC10.Name = "txtDC10"
        Me.txtDC10.ReadOnly = True
        Me.txtDC10.Size = New System.Drawing.Size(120, 20)
        Me.txtDC10.TabIndex = 5
        Me.txtDC10.TabStop = False
        Me.txtDC10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label43
        '
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Image = CType(resources.GetObject("Label43.Image"), System.Drawing.Image)
        Me.Label43.Location = New System.Drawing.Point(248, 16)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(120, 23)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "Día del Ciclo"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'botFUR10
        '
        Me.botFUR10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFUR10.Image = CType(resources.GetObject("botFUR10.Image"), System.Drawing.Image)
        Me.botFUR10.Location = New System.Drawing.Point(128, 16)
        Me.botFUR10.Name = "botFUR10"
        Me.botFUR10.Size = New System.Drawing.Size(120, 23)
        Me.botFUR10.TabIndex = 1
        Me.botFUR10.TabStop = False
        Me.botFUR10.Text = "FUR"
        '
        'txt10f
        '
        Me.txt10f.Location = New System.Drawing.Point(8, 308)
        Me.txt10f.MaxLength = 2048
        Me.txt10f.Multiline = True
        Me.txt10f.Name = "txt10f"
        Me.txt10f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt10f.Size = New System.Drawing.Size(352, 48)
        Me.txt10f.TabIndex = 13
        '
        'Label89
        '
        Me.Label89.Location = New System.Drawing.Point(8, 292)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(220, 16)
        Me.Label89.TabIndex = 12
        Me.Label89.Text = "Pendiente para la Próxima Consulta:"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt10e
        '
        Me.txt10e.Location = New System.Drawing.Point(8, 244)
        Me.txt10e.MaxLength = 2048
        Me.txt10e.Multiline = True
        Me.txt10e.Name = "txt10e"
        Me.txt10e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt10e.Size = New System.Drawing.Size(352, 48)
        Me.txt10e.TabIndex = 11
        '
        'Label90
        '
        Me.Label90.Location = New System.Drawing.Point(8, 228)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(220, 16)
        Me.Label90.TabIndex = 10
        Me.Label90.Text = "Tratamientos Indicados en la Consulta:"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt10d
        '
        Me.txt10d.Location = New System.Drawing.Point(8, 180)
        Me.txt10d.MaxLength = 2048
        Me.txt10d.Multiline = True
        Me.txt10d.Name = "txt10d"
        Me.txt10d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt10d.Size = New System.Drawing.Size(352, 48)
        Me.txt10d.TabIndex = 9
        '
        'Label91
        '
        Me.Label91.Location = New System.Drawing.Point(8, 164)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(220, 16)
        Me.Label91.TabIndex = 8
        Me.Label91.Text = "Procedimientos Realizados en la Consulta:"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt10b
        '
        Me.txt10b.BackColor = System.Drawing.SystemColors.Window
        Me.txt10b.Location = New System.Drawing.Point(128, 40)
        Me.txt10b.MaxLength = 255
        Me.txt10b.Name = "txt10b"
        Me.txt10b.ReadOnly = True
        Me.txt10b.Size = New System.Drawing.Size(120, 20)
        Me.txt10b.TabIndex = 4
        Me.txt10b.TabStop = False
        Me.txt10b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt10b, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt10a
        '
        Me.txt10a.BackColor = System.Drawing.SystemColors.Window
        Me.txt10a.Location = New System.Drawing.Point(8, 40)
        Me.txt10a.MaxLength = 255
        Me.txt10a.Name = "txt10a"
        Me.txt10a.ReadOnly = True
        Me.txt10a.Size = New System.Drawing.Size(120, 20)
        Me.txt10a.TabIndex = 3
        Me.txt10a.TabStop = False
        Me.txt10a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt10a, "Para cambiar la fecha presiona el botón arriba...")
        '
        'txt10g
        '
        Me.txt10g.BackColor = System.Drawing.SystemColors.Info
        Me.txt10g.Location = New System.Drawing.Point(376, 44)
        Me.txt10g.MaxLength = 4096
        Me.txt10g.Multiline = True
        Me.txt10g.Name = "txt10g"
        Me.txt10g.ReadOnly = True
        Me.txt10g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt10g.Size = New System.Drawing.Size(384, 312)
        Me.txt10g.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txt10g, "Para modificar el texto presiona el botón de arriba")
        '
        'txt10c
        '
        Me.txt10c.Location = New System.Drawing.Point(8, 84)
        Me.txt10c.MaxLength = 2048
        Me.txt10c.Multiline = True
        Me.txt10c.Name = "txt10c"
        Me.txt10c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt10c.Size = New System.Drawing.Size(352, 80)
        Me.txt10c.TabIndex = 7
        '
        'botEF10
        '
        Me.botEF10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botEF10.Image = CType(resources.GetObject("botEF10.Image"), System.Drawing.Image)
        Me.botEF10.Location = New System.Drawing.Point(456, 16)
        Me.botEF10.Name = "botEF10"
        Me.botEF10.Size = New System.Drawing.Size(224, 23)
        Me.botEF10.TabIndex = 14
        Me.botEF10.Text = "Examen Físico de la Consulta"
        '
        'Label94
        '
        Me.Label94.Location = New System.Drawing.Point(8, 68)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(192, 16)
        Me.Label94.TabIndex = 6
        Me.Label94.Text = "Evolución de la Enfermedad Actual :"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPageLaboratorio1
        '
        Me.TabPageLaboratorio1.AutoScroll = True
        Me.TabPageLaboratorio1.Controls.Add(Me.Panel2)
        Me.TabPageLaboratorio1.Location = New System.Drawing.Point(4, 22)
        Me.TabPageLaboratorio1.Name = "TabPageLaboratorio1"
        Me.TabPageLaboratorio1.Size = New System.Drawing.Size(776, 394)
        Me.TabPageLaboratorio1.TabIndex = 2
        Me.TabPageLaboratorio1.Text = "Laboratorio #1"
        Me.TabPageLaboratorio1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label51)
        Me.Panel2.Controls.Add(Me.Label48)
        Me.Panel2.Controls.Add(Me.txtEX20h)
        Me.Panel2.Controls.Add(Me.txtEX20g)
        Me.Panel2.Controls.Add(Me.txtEX20f)
        Me.Panel2.Controls.Add(Me.txtEX20e)
        Me.Panel2.Controls.Add(Me.txtEX20d)
        Me.Panel2.Controls.Add(Me.txtEX20c)
        Me.Panel2.Controls.Add(Me.txtEX20b)
        Me.Panel2.Controls.Add(Me.txtEX20a)
        Me.Panel2.Controls.Add(Me.txtOtroEx03)
        Me.Panel2.Controls.Add(Me.txtEX19h)
        Me.Panel2.Controls.Add(Me.txtEX19g)
        Me.Panel2.Controls.Add(Me.txtEX19f)
        Me.Panel2.Controls.Add(Me.txtEX19e)
        Me.Panel2.Controls.Add(Me.txtEX19d)
        Me.Panel2.Controls.Add(Me.txtEX19c)
        Me.Panel2.Controls.Add(Me.txtEX19b)
        Me.Panel2.Controls.Add(Me.txtEX19a)
        Me.Panel2.Controls.Add(Me.txtEX18h)
        Me.Panel2.Controls.Add(Me.txtEX18g)
        Me.Panel2.Controls.Add(Me.txtEX18f)
        Me.Panel2.Controls.Add(Me.txtEX18e)
        Me.Panel2.Controls.Add(Me.txtEX18d)
        Me.Panel2.Controls.Add(Me.txtEX18c)
        Me.Panel2.Controls.Add(Me.txtEX18b)
        Me.Panel2.Controls.Add(Me.txtEX18a)
        Me.Panel2.Controls.Add(Me.txtEX17h)
        Me.Panel2.Controls.Add(Me.txtEX17g)
        Me.Panel2.Controls.Add(Me.txtEX17f)
        Me.Panel2.Controls.Add(Me.txtEX17e)
        Me.Panel2.Controls.Add(Me.txtEX17d)
        Me.Panel2.Controls.Add(Me.txtEX17c)
        Me.Panel2.Controls.Add(Me.txtEX17b)
        Me.Panel2.Controls.Add(Me.txtEX17a)
        Me.Panel2.Controls.Add(Me.txtEX16h)
        Me.Panel2.Controls.Add(Me.txtEX16g)
        Me.Panel2.Controls.Add(Me.txtEX16f)
        Me.Panel2.Controls.Add(Me.txtEX16e)
        Me.Panel2.Controls.Add(Me.txtEX16d)
        Me.Panel2.Controls.Add(Me.txtEX16c)
        Me.Panel2.Controls.Add(Me.txtEX16b)
        Me.Panel2.Controls.Add(Me.txtEX16a)
        Me.Panel2.Controls.Add(Me.txtEX15h)
        Me.Panel2.Controls.Add(Me.txtEX15g)
        Me.Panel2.Controls.Add(Me.txtEX15f)
        Me.Panel2.Controls.Add(Me.txtEX15e)
        Me.Panel2.Controls.Add(Me.txtEX15d)
        Me.Panel2.Controls.Add(Me.txtEX15c)
        Me.Panel2.Controls.Add(Me.txtEX15b)
        Me.Panel2.Controls.Add(Me.txtEX15a)
        Me.Panel2.Controls.Add(Me.txtEX14h)
        Me.Panel2.Controls.Add(Me.txtEX14g)
        Me.Panel2.Controls.Add(Me.txtEX14f)
        Me.Panel2.Controls.Add(Me.txtEX14e)
        Me.Panel2.Controls.Add(Me.txtEX14d)
        Me.Panel2.Controls.Add(Me.txtEX14c)
        Me.Panel2.Controls.Add(Me.txtEX14b)
        Me.Panel2.Controls.Add(Me.txtEX14a)
        Me.Panel2.Controls.Add(Me.txtEX13h)
        Me.Panel2.Controls.Add(Me.txtEX13g)
        Me.Panel2.Controls.Add(Me.txtEX13f)
        Me.Panel2.Controls.Add(Me.txtEX13e)
        Me.Panel2.Controls.Add(Me.txtEX13d)
        Me.Panel2.Controls.Add(Me.txtEX13c)
        Me.Panel2.Controls.Add(Me.txtEX13b)
        Me.Panel2.Controls.Add(Me.txtEX13a)
        Me.Panel2.Controls.Add(Me.txtEX12h)
        Me.Panel2.Controls.Add(Me.txtEX12g)
        Me.Panel2.Controls.Add(Me.txtEX12f)
        Me.Panel2.Controls.Add(Me.txtEX12e)
        Me.Panel2.Controls.Add(Me.txtEX12d)
        Me.Panel2.Controls.Add(Me.txtEX12c)
        Me.Panel2.Controls.Add(Me.txtEX12b)
        Me.Panel2.Controls.Add(Me.txtEX12a)
        Me.Panel2.Controls.Add(Me.txtEX11h)
        Me.Panel2.Controls.Add(Me.txtEX11g)
        Me.Panel2.Controls.Add(Me.txtEX11f)
        Me.Panel2.Controls.Add(Me.txtEX11e)
        Me.Panel2.Controls.Add(Me.txtEX11d)
        Me.Panel2.Controls.Add(Me.txtEX11c)
        Me.Panel2.Controls.Add(Me.txtEX11b)
        Me.Panel2.Controls.Add(Me.txtEX11a)
        Me.Panel2.Controls.Add(Me.txtEX10h)
        Me.Panel2.Controls.Add(Me.txtEX10g)
        Me.Panel2.Controls.Add(Me.txtEX10f)
        Me.Panel2.Controls.Add(Me.txtEX10e)
        Me.Panel2.Controls.Add(Me.txtEX10d)
        Me.Panel2.Controls.Add(Me.txtEX10c)
        Me.Panel2.Controls.Add(Me.txtEX10b)
        Me.Panel2.Controls.Add(Me.txtEX10a)
        Me.Panel2.Controls.Add(Me.txtEX09h)
        Me.Panel2.Controls.Add(Me.txtEX09g)
        Me.Panel2.Controls.Add(Me.txtEX09f)
        Me.Panel2.Controls.Add(Me.txtEX09e)
        Me.Panel2.Controls.Add(Me.txtEX09d)
        Me.Panel2.Controls.Add(Me.txtEX09c)
        Me.Panel2.Controls.Add(Me.txtEX09b)
        Me.Panel2.Controls.Add(Me.txtEX09a)
        Me.Panel2.Controls.Add(Me.txtEX08h)
        Me.Panel2.Controls.Add(Me.txtEX08g)
        Me.Panel2.Controls.Add(Me.txtEX08f)
        Me.Panel2.Controls.Add(Me.txtEX08e)
        Me.Panel2.Controls.Add(Me.txtEX08d)
        Me.Panel2.Controls.Add(Me.txtEX08c)
        Me.Panel2.Controls.Add(Me.txtEX08b)
        Me.Panel2.Controls.Add(Me.txtEX08a)
        Me.Panel2.Controls.Add(Me.txtEX07h)
        Me.Panel2.Controls.Add(Me.txtEX07g)
        Me.Panel2.Controls.Add(Me.txtEX07f)
        Me.Panel2.Controls.Add(Me.txtEX07e)
        Me.Panel2.Controls.Add(Me.txtEX07d)
        Me.Panel2.Controls.Add(Me.txtEX07c)
        Me.Panel2.Controls.Add(Me.txtEX07b)
        Me.Panel2.Controls.Add(Me.txtEX07a)
        Me.Panel2.Controls.Add(Me.txtEX06h)
        Me.Panel2.Controls.Add(Me.txtEX06g)
        Me.Panel2.Controls.Add(Me.txtEX06f)
        Me.Panel2.Controls.Add(Me.txtEX06e)
        Me.Panel2.Controls.Add(Me.txtEX06d)
        Me.Panel2.Controls.Add(Me.txtEX06c)
        Me.Panel2.Controls.Add(Me.txtEX06b)
        Me.Panel2.Controls.Add(Me.txtEX06a)
        Me.Panel2.Controls.Add(Me.txtEX05h)
        Me.Panel2.Controls.Add(Me.txtEX05g)
        Me.Panel2.Controls.Add(Me.txtEX05f)
        Me.Panel2.Controls.Add(Me.txtEX05e)
        Me.Panel2.Controls.Add(Me.txtEX05d)
        Me.Panel2.Controls.Add(Me.txtEX05c)
        Me.Panel2.Controls.Add(Me.txtEX05b)
        Me.Panel2.Controls.Add(Me.txtEX05a)
        Me.Panel2.Controls.Add(Me.txtEX04h)
        Me.Panel2.Controls.Add(Me.txtEX04g)
        Me.Panel2.Controls.Add(Me.txtEX04f)
        Me.Panel2.Controls.Add(Me.txtEX04e)
        Me.Panel2.Controls.Add(Me.txtEX04d)
        Me.Panel2.Controls.Add(Me.txtEX04c)
        Me.Panel2.Controls.Add(Me.txtEX04b)
        Me.Panel2.Controls.Add(Me.txtEX04a)
        Me.Panel2.Controls.Add(Me.txtEX03h)
        Me.Panel2.Controls.Add(Me.txtEX03g)
        Me.Panel2.Controls.Add(Me.txtEX03f)
        Me.Panel2.Controls.Add(Me.txtEX03e)
        Me.Panel2.Controls.Add(Me.txtEX03d)
        Me.Panel2.Controls.Add(Me.txtEX03c)
        Me.Panel2.Controls.Add(Me.txtEX03b)
        Me.Panel2.Controls.Add(Me.txtEX03a)
        Me.Panel2.Controls.Add(Me.txtEX02h)
        Me.Panel2.Controls.Add(Me.txtEX02g)
        Me.Panel2.Controls.Add(Me.txtEX02f)
        Me.Panel2.Controls.Add(Me.txtEX02e)
        Me.Panel2.Controls.Add(Me.txtEX02d)
        Me.Panel2.Controls.Add(Me.txtEX02c)
        Me.Panel2.Controls.Add(Me.txtEX02b)
        Me.Panel2.Controls.Add(Me.txtEX02a)
        Me.Panel2.Controls.Add(Me.txtEX01h)
        Me.Panel2.Controls.Add(Me.txtEX01g)
        Me.Panel2.Controls.Add(Me.txtEX01f)
        Me.Panel2.Controls.Add(Me.txtEX01e)
        Me.Panel2.Controls.Add(Me.txtEX01d)
        Me.Panel2.Controls.Add(Me.txtEX01c)
        Me.Panel2.Controls.Add(Me.txtEX01b)
        Me.Panel2.Controls.Add(Me.txtEX01a)
        Me.Panel2.Controls.Add(Me.txtFechaLabH)
        Me.Panel2.Controls.Add(Me.txtFechaLabG)
        Me.Panel2.Controls.Add(Me.txtFechaLabF)
        Me.Panel2.Controls.Add(Me.txtFechaLabE)
        Me.Panel2.Controls.Add(Me.txtFechaLabD)
        Me.Panel2.Controls.Add(Me.txtFechaLabC)
        Me.Panel2.Controls.Add(Me.txtFechaLabB)
        Me.Panel2.Controls.Add(Me.txtFechaLabA)
        Me.Panel2.Controls.Add(Me.txtOtroEx02)
        Me.Panel2.Controls.Add(Me.txtOtroEx01)
        Me.Panel2.Controls.Add(Me.Label68)
        Me.Panel2.Controls.Add(Me.Label67)
        Me.Panel2.Controls.Add(Me.Label66)
        Me.Panel2.Controls.Add(Me.Label65)
        Me.Panel2.Controls.Add(Me.Label64)
        Me.Panel2.Controls.Add(Me.Label62)
        Me.Panel2.Controls.Add(Me.Label61)
        Me.Panel2.Controls.Add(Me.Label60)
        Me.Panel2.Controls.Add(Me.Label59)
        Me.Panel2.Controls.Add(Me.Label58)
        Me.Panel2.Controls.Add(Me.Label57)
        Me.Panel2.Controls.Add(Me.Label56)
        Me.Panel2.Controls.Add(Me.Label55)
        Me.Panel2.Controls.Add(Me.Label54)
        Me.Panel2.Controls.Add(Me.Label53)
        Me.Panel2.Controls.Add(Me.Label52)
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Location = New System.Drawing.Point(28, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(716, 360)
        Me.Panel2.TabIndex = 0
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label51.Location = New System.Drawing.Point(0, 40)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(136, 13)
        Me.Label51.TabIndex = 2
        Me.Label51.Text = "Hb"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label48.Location = New System.Drawing.Point(0, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(136, 40)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Exámenes"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEX20h
        '
        Me.txtEX20h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX20h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX20h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX20h.Location = New System.Drawing.Point(640, 344)
        Me.txtEX20h.MaxLength = 12
        Me.txtEX20h.Name = "txtEX20h"
        Me.txtEX20h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX20h.TabIndex = 189
        Me.txtEX20h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX20g
        '
        Me.txtEX20g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX20g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX20g.Location = New System.Drawing.Point(568, 344)
        Me.txtEX20g.MaxLength = 12
        Me.txtEX20g.Name = "txtEX20g"
        Me.txtEX20g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX20g.TabIndex = 168
        Me.txtEX20g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX20f
        '
        Me.txtEX20f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX20f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX20f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX20f.Location = New System.Drawing.Point(496, 344)
        Me.txtEX20f.MaxLength = 12
        Me.txtEX20f.Name = "txtEX20f"
        Me.txtEX20f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX20f.TabIndex = 147
        Me.txtEX20f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX20e
        '
        Me.txtEX20e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX20e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX20e.Location = New System.Drawing.Point(424, 344)
        Me.txtEX20e.MaxLength = 12
        Me.txtEX20e.Name = "txtEX20e"
        Me.txtEX20e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX20e.TabIndex = 126
        Me.txtEX20e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX20d
        '
        Me.txtEX20d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX20d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX20d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX20d.Location = New System.Drawing.Point(352, 344)
        Me.txtEX20d.MaxLength = 12
        Me.txtEX20d.Name = "txtEX20d"
        Me.txtEX20d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX20d.TabIndex = 105
        Me.txtEX20d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX20c
        '
        Me.txtEX20c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX20c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX20c.Location = New System.Drawing.Point(280, 344)
        Me.txtEX20c.MaxLength = 12
        Me.txtEX20c.Name = "txtEX20c"
        Me.txtEX20c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX20c.TabIndex = 84
        Me.txtEX20c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX20b
        '
        Me.txtEX20b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX20b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX20b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX20b.Location = New System.Drawing.Point(208, 344)
        Me.txtEX20b.MaxLength = 12
        Me.txtEX20b.Name = "txtEX20b"
        Me.txtEX20b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX20b.TabIndex = 63
        Me.txtEX20b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX20a
        '
        Me.txtEX20a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX20a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX20a.Location = New System.Drawing.Point(136, 344)
        Me.txtEX20a.MaxLength = 12
        Me.txtEX20a.Name = "txtEX20a"
        Me.txtEX20a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX20a.TabIndex = 42
        Me.txtEX20a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOtroEx03
        '
        Me.txtOtroEx03.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtOtroEx03.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtroEx03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtroEx03.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOtroEx03.Location = New System.Drawing.Point(0, 344)
        Me.txtOtroEx03.MaxLength = 18
        Me.txtOtroEx03.Name = "txtOtroEx03"
        Me.txtOtroEx03.Size = New System.Drawing.Size(136, 13)
        Me.txtOtroEx03.TabIndex = 21
        Me.txtOtroEx03.Text = "Otro"
        Me.txtOtroEx03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX19h
        '
        Me.txtEX19h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX19h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX19h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX19h.Location = New System.Drawing.Point(640, 328)
        Me.txtEX19h.MaxLength = 12
        Me.txtEX19h.Name = "txtEX19h"
        Me.txtEX19h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX19h.TabIndex = 188
        Me.txtEX19h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX19g
        '
        Me.txtEX19g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX19g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX19g.Location = New System.Drawing.Point(568, 328)
        Me.txtEX19g.MaxLength = 12
        Me.txtEX19g.Name = "txtEX19g"
        Me.txtEX19g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX19g.TabIndex = 167
        Me.txtEX19g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX19f
        '
        Me.txtEX19f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX19f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX19f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX19f.Location = New System.Drawing.Point(496, 328)
        Me.txtEX19f.MaxLength = 12
        Me.txtEX19f.Name = "txtEX19f"
        Me.txtEX19f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX19f.TabIndex = 146
        Me.txtEX19f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX19e
        '
        Me.txtEX19e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX19e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX19e.Location = New System.Drawing.Point(424, 328)
        Me.txtEX19e.MaxLength = 12
        Me.txtEX19e.Name = "txtEX19e"
        Me.txtEX19e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX19e.TabIndex = 125
        Me.txtEX19e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX19d
        '
        Me.txtEX19d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX19d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX19d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX19d.Location = New System.Drawing.Point(352, 328)
        Me.txtEX19d.MaxLength = 12
        Me.txtEX19d.Name = "txtEX19d"
        Me.txtEX19d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX19d.TabIndex = 104
        Me.txtEX19d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX19c
        '
        Me.txtEX19c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX19c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX19c.Location = New System.Drawing.Point(280, 328)
        Me.txtEX19c.MaxLength = 12
        Me.txtEX19c.Name = "txtEX19c"
        Me.txtEX19c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX19c.TabIndex = 83
        Me.txtEX19c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX19b
        '
        Me.txtEX19b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX19b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX19b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX19b.Location = New System.Drawing.Point(208, 328)
        Me.txtEX19b.MaxLength = 12
        Me.txtEX19b.Name = "txtEX19b"
        Me.txtEX19b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX19b.TabIndex = 62
        Me.txtEX19b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX19a
        '
        Me.txtEX19a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX19a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX19a.Location = New System.Drawing.Point(136, 328)
        Me.txtEX19a.MaxLength = 12
        Me.txtEX19a.Name = "txtEX19a"
        Me.txtEX19a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX19a.TabIndex = 41
        Me.txtEX19a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX18h
        '
        Me.txtEX18h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX18h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX18h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX18h.Location = New System.Drawing.Point(640, 312)
        Me.txtEX18h.MaxLength = 12
        Me.txtEX18h.Name = "txtEX18h"
        Me.txtEX18h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX18h.TabIndex = 187
        Me.txtEX18h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX18g
        '
        Me.txtEX18g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX18g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX18g.Location = New System.Drawing.Point(568, 312)
        Me.txtEX18g.MaxLength = 12
        Me.txtEX18g.Name = "txtEX18g"
        Me.txtEX18g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX18g.TabIndex = 166
        Me.txtEX18g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX18f
        '
        Me.txtEX18f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX18f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX18f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX18f.Location = New System.Drawing.Point(496, 312)
        Me.txtEX18f.MaxLength = 12
        Me.txtEX18f.Name = "txtEX18f"
        Me.txtEX18f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX18f.TabIndex = 145
        Me.txtEX18f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX18e
        '
        Me.txtEX18e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX18e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX18e.Location = New System.Drawing.Point(424, 312)
        Me.txtEX18e.MaxLength = 12
        Me.txtEX18e.Name = "txtEX18e"
        Me.txtEX18e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX18e.TabIndex = 124
        Me.txtEX18e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX18d
        '
        Me.txtEX18d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX18d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX18d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX18d.Location = New System.Drawing.Point(352, 312)
        Me.txtEX18d.MaxLength = 12
        Me.txtEX18d.Name = "txtEX18d"
        Me.txtEX18d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX18d.TabIndex = 103
        Me.txtEX18d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX18c
        '
        Me.txtEX18c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX18c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX18c.Location = New System.Drawing.Point(280, 312)
        Me.txtEX18c.MaxLength = 12
        Me.txtEX18c.Name = "txtEX18c"
        Me.txtEX18c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX18c.TabIndex = 82
        Me.txtEX18c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX18b
        '
        Me.txtEX18b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX18b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX18b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX18b.Location = New System.Drawing.Point(208, 312)
        Me.txtEX18b.MaxLength = 12
        Me.txtEX18b.Name = "txtEX18b"
        Me.txtEX18b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX18b.TabIndex = 61
        Me.txtEX18b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX18a
        '
        Me.txtEX18a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX18a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX18a.Location = New System.Drawing.Point(136, 312)
        Me.txtEX18a.MaxLength = 12
        Me.txtEX18a.Name = "txtEX18a"
        Me.txtEX18a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX18a.TabIndex = 40
        Me.txtEX18a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX17h
        '
        Me.txtEX17h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX17h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX17h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX17h.Location = New System.Drawing.Point(640, 296)
        Me.txtEX17h.MaxLength = 12
        Me.txtEX17h.Name = "txtEX17h"
        Me.txtEX17h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX17h.TabIndex = 186
        Me.txtEX17h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX17g
        '
        Me.txtEX17g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX17g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX17g.Location = New System.Drawing.Point(568, 296)
        Me.txtEX17g.MaxLength = 12
        Me.txtEX17g.Name = "txtEX17g"
        Me.txtEX17g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX17g.TabIndex = 165
        Me.txtEX17g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX17f
        '
        Me.txtEX17f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX17f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX17f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX17f.Location = New System.Drawing.Point(496, 296)
        Me.txtEX17f.MaxLength = 12
        Me.txtEX17f.Name = "txtEX17f"
        Me.txtEX17f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX17f.TabIndex = 144
        Me.txtEX17f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX17e
        '
        Me.txtEX17e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX17e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX17e.Location = New System.Drawing.Point(424, 296)
        Me.txtEX17e.MaxLength = 12
        Me.txtEX17e.Name = "txtEX17e"
        Me.txtEX17e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX17e.TabIndex = 123
        Me.txtEX17e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX17d
        '
        Me.txtEX17d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX17d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX17d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX17d.Location = New System.Drawing.Point(352, 296)
        Me.txtEX17d.MaxLength = 12
        Me.txtEX17d.Name = "txtEX17d"
        Me.txtEX17d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX17d.TabIndex = 102
        Me.txtEX17d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX17c
        '
        Me.txtEX17c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX17c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX17c.Location = New System.Drawing.Point(280, 296)
        Me.txtEX17c.MaxLength = 12
        Me.txtEX17c.Name = "txtEX17c"
        Me.txtEX17c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX17c.TabIndex = 81
        Me.txtEX17c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX17b
        '
        Me.txtEX17b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX17b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX17b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX17b.Location = New System.Drawing.Point(208, 296)
        Me.txtEX17b.MaxLength = 12
        Me.txtEX17b.Name = "txtEX17b"
        Me.txtEX17b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX17b.TabIndex = 60
        Me.txtEX17b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX17a
        '
        Me.txtEX17a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX17a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX17a.Location = New System.Drawing.Point(136, 296)
        Me.txtEX17a.MaxLength = 12
        Me.txtEX17a.Name = "txtEX17a"
        Me.txtEX17a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX17a.TabIndex = 39
        Me.txtEX17a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX16h
        '
        Me.txtEX16h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX16h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX16h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX16h.Location = New System.Drawing.Point(640, 280)
        Me.txtEX16h.MaxLength = 12
        Me.txtEX16h.Name = "txtEX16h"
        Me.txtEX16h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX16h.TabIndex = 185
        Me.txtEX16h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX16g
        '
        Me.txtEX16g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX16g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX16g.Location = New System.Drawing.Point(568, 280)
        Me.txtEX16g.MaxLength = 12
        Me.txtEX16g.Name = "txtEX16g"
        Me.txtEX16g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX16g.TabIndex = 164
        Me.txtEX16g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX16f
        '
        Me.txtEX16f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX16f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX16f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX16f.Location = New System.Drawing.Point(496, 280)
        Me.txtEX16f.MaxLength = 12
        Me.txtEX16f.Name = "txtEX16f"
        Me.txtEX16f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX16f.TabIndex = 143
        Me.txtEX16f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX16e
        '
        Me.txtEX16e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX16e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX16e.Location = New System.Drawing.Point(424, 280)
        Me.txtEX16e.MaxLength = 12
        Me.txtEX16e.Name = "txtEX16e"
        Me.txtEX16e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX16e.TabIndex = 122
        Me.txtEX16e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX16d
        '
        Me.txtEX16d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX16d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX16d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX16d.Location = New System.Drawing.Point(352, 280)
        Me.txtEX16d.MaxLength = 12
        Me.txtEX16d.Name = "txtEX16d"
        Me.txtEX16d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX16d.TabIndex = 101
        Me.txtEX16d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX16c
        '
        Me.txtEX16c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX16c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX16c.Location = New System.Drawing.Point(280, 280)
        Me.txtEX16c.MaxLength = 12
        Me.txtEX16c.Name = "txtEX16c"
        Me.txtEX16c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX16c.TabIndex = 80
        Me.txtEX16c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX16b
        '
        Me.txtEX16b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX16b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX16b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX16b.Location = New System.Drawing.Point(208, 280)
        Me.txtEX16b.MaxLength = 12
        Me.txtEX16b.Name = "txtEX16b"
        Me.txtEX16b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX16b.TabIndex = 59
        Me.txtEX16b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX16a
        '
        Me.txtEX16a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX16a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX16a.Location = New System.Drawing.Point(136, 280)
        Me.txtEX16a.MaxLength = 12
        Me.txtEX16a.Name = "txtEX16a"
        Me.txtEX16a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX16a.TabIndex = 38
        Me.txtEX16a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX15h
        '
        Me.txtEX15h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX15h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX15h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX15h.Location = New System.Drawing.Point(640, 264)
        Me.txtEX15h.MaxLength = 12
        Me.txtEX15h.Name = "txtEX15h"
        Me.txtEX15h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX15h.TabIndex = 184
        Me.txtEX15h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX15g
        '
        Me.txtEX15g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX15g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX15g.Location = New System.Drawing.Point(568, 264)
        Me.txtEX15g.MaxLength = 12
        Me.txtEX15g.Name = "txtEX15g"
        Me.txtEX15g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX15g.TabIndex = 163
        Me.txtEX15g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX15f
        '
        Me.txtEX15f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX15f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX15f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX15f.Location = New System.Drawing.Point(496, 264)
        Me.txtEX15f.MaxLength = 12
        Me.txtEX15f.Name = "txtEX15f"
        Me.txtEX15f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX15f.TabIndex = 142
        Me.txtEX15f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX15e
        '
        Me.txtEX15e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX15e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX15e.Location = New System.Drawing.Point(424, 264)
        Me.txtEX15e.MaxLength = 12
        Me.txtEX15e.Name = "txtEX15e"
        Me.txtEX15e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX15e.TabIndex = 121
        Me.txtEX15e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX15d
        '
        Me.txtEX15d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX15d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX15d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX15d.Location = New System.Drawing.Point(352, 264)
        Me.txtEX15d.MaxLength = 12
        Me.txtEX15d.Name = "txtEX15d"
        Me.txtEX15d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX15d.TabIndex = 100
        Me.txtEX15d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX15c
        '
        Me.txtEX15c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX15c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX15c.Location = New System.Drawing.Point(280, 264)
        Me.txtEX15c.MaxLength = 12
        Me.txtEX15c.Name = "txtEX15c"
        Me.txtEX15c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX15c.TabIndex = 79
        Me.txtEX15c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX15b
        '
        Me.txtEX15b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX15b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX15b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX15b.Location = New System.Drawing.Point(208, 264)
        Me.txtEX15b.MaxLength = 12
        Me.txtEX15b.Name = "txtEX15b"
        Me.txtEX15b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX15b.TabIndex = 58
        Me.txtEX15b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX15a
        '
        Me.txtEX15a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX15a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX15a.Location = New System.Drawing.Point(136, 264)
        Me.txtEX15a.MaxLength = 12
        Me.txtEX15a.Name = "txtEX15a"
        Me.txtEX15a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX15a.TabIndex = 37
        Me.txtEX15a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX14h
        '
        Me.txtEX14h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX14h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX14h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX14h.Location = New System.Drawing.Point(640, 248)
        Me.txtEX14h.MaxLength = 12
        Me.txtEX14h.Name = "txtEX14h"
        Me.txtEX14h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX14h.TabIndex = 183
        Me.txtEX14h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX14g
        '
        Me.txtEX14g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX14g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX14g.Location = New System.Drawing.Point(568, 248)
        Me.txtEX14g.MaxLength = 12
        Me.txtEX14g.Name = "txtEX14g"
        Me.txtEX14g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX14g.TabIndex = 162
        Me.txtEX14g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX14f
        '
        Me.txtEX14f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX14f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX14f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX14f.Location = New System.Drawing.Point(496, 248)
        Me.txtEX14f.MaxLength = 12
        Me.txtEX14f.Name = "txtEX14f"
        Me.txtEX14f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX14f.TabIndex = 141
        Me.txtEX14f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX14e
        '
        Me.txtEX14e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX14e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX14e.Location = New System.Drawing.Point(424, 248)
        Me.txtEX14e.MaxLength = 12
        Me.txtEX14e.Name = "txtEX14e"
        Me.txtEX14e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX14e.TabIndex = 120
        Me.txtEX14e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX14d
        '
        Me.txtEX14d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX14d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX14d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX14d.Location = New System.Drawing.Point(352, 248)
        Me.txtEX14d.MaxLength = 12
        Me.txtEX14d.Name = "txtEX14d"
        Me.txtEX14d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX14d.TabIndex = 99
        Me.txtEX14d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX14c
        '
        Me.txtEX14c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX14c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX14c.Location = New System.Drawing.Point(280, 248)
        Me.txtEX14c.MaxLength = 12
        Me.txtEX14c.Name = "txtEX14c"
        Me.txtEX14c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX14c.TabIndex = 78
        Me.txtEX14c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX14b
        '
        Me.txtEX14b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX14b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX14b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX14b.Location = New System.Drawing.Point(208, 248)
        Me.txtEX14b.MaxLength = 12
        Me.txtEX14b.Name = "txtEX14b"
        Me.txtEX14b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX14b.TabIndex = 57
        Me.txtEX14b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX14a
        '
        Me.txtEX14a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX14a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX14a.Location = New System.Drawing.Point(136, 248)
        Me.txtEX14a.MaxLength = 12
        Me.txtEX14a.Name = "txtEX14a"
        Me.txtEX14a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX14a.TabIndex = 36
        Me.txtEX14a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX13h
        '
        Me.txtEX13h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX13h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX13h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX13h.Location = New System.Drawing.Point(640, 232)
        Me.txtEX13h.MaxLength = 12
        Me.txtEX13h.Name = "txtEX13h"
        Me.txtEX13h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX13h.TabIndex = 182
        Me.txtEX13h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX13g
        '
        Me.txtEX13g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX13g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX13g.Location = New System.Drawing.Point(568, 232)
        Me.txtEX13g.MaxLength = 12
        Me.txtEX13g.Name = "txtEX13g"
        Me.txtEX13g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX13g.TabIndex = 161
        Me.txtEX13g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX13f
        '
        Me.txtEX13f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX13f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX13f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX13f.Location = New System.Drawing.Point(496, 232)
        Me.txtEX13f.MaxLength = 12
        Me.txtEX13f.Name = "txtEX13f"
        Me.txtEX13f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX13f.TabIndex = 140
        Me.txtEX13f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX13e
        '
        Me.txtEX13e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX13e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX13e.Location = New System.Drawing.Point(424, 232)
        Me.txtEX13e.MaxLength = 12
        Me.txtEX13e.Name = "txtEX13e"
        Me.txtEX13e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX13e.TabIndex = 119
        Me.txtEX13e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX13d
        '
        Me.txtEX13d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX13d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX13d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX13d.Location = New System.Drawing.Point(352, 232)
        Me.txtEX13d.MaxLength = 12
        Me.txtEX13d.Name = "txtEX13d"
        Me.txtEX13d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX13d.TabIndex = 98
        Me.txtEX13d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX13c
        '
        Me.txtEX13c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX13c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX13c.Location = New System.Drawing.Point(280, 232)
        Me.txtEX13c.MaxLength = 12
        Me.txtEX13c.Name = "txtEX13c"
        Me.txtEX13c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX13c.TabIndex = 77
        Me.txtEX13c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX13b
        '
        Me.txtEX13b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX13b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX13b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX13b.Location = New System.Drawing.Point(208, 232)
        Me.txtEX13b.MaxLength = 12
        Me.txtEX13b.Name = "txtEX13b"
        Me.txtEX13b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX13b.TabIndex = 56
        Me.txtEX13b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX13a
        '
        Me.txtEX13a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX13a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX13a.Location = New System.Drawing.Point(136, 232)
        Me.txtEX13a.MaxLength = 12
        Me.txtEX13a.Name = "txtEX13a"
        Me.txtEX13a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX13a.TabIndex = 35
        Me.txtEX13a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX12h
        '
        Me.txtEX12h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX12h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX12h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX12h.Location = New System.Drawing.Point(640, 216)
        Me.txtEX12h.MaxLength = 12
        Me.txtEX12h.Name = "txtEX12h"
        Me.txtEX12h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX12h.TabIndex = 181
        Me.txtEX12h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX12g
        '
        Me.txtEX12g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX12g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX12g.Location = New System.Drawing.Point(568, 216)
        Me.txtEX12g.MaxLength = 12
        Me.txtEX12g.Name = "txtEX12g"
        Me.txtEX12g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX12g.TabIndex = 160
        Me.txtEX12g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX12f
        '
        Me.txtEX12f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX12f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX12f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX12f.Location = New System.Drawing.Point(496, 216)
        Me.txtEX12f.MaxLength = 12
        Me.txtEX12f.Name = "txtEX12f"
        Me.txtEX12f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX12f.TabIndex = 139
        Me.txtEX12f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX12e
        '
        Me.txtEX12e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX12e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX12e.Location = New System.Drawing.Point(424, 216)
        Me.txtEX12e.MaxLength = 12
        Me.txtEX12e.Name = "txtEX12e"
        Me.txtEX12e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX12e.TabIndex = 118
        Me.txtEX12e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX12d
        '
        Me.txtEX12d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX12d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX12d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX12d.Location = New System.Drawing.Point(352, 216)
        Me.txtEX12d.MaxLength = 12
        Me.txtEX12d.Name = "txtEX12d"
        Me.txtEX12d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX12d.TabIndex = 97
        Me.txtEX12d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX12c
        '
        Me.txtEX12c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX12c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX12c.Location = New System.Drawing.Point(280, 216)
        Me.txtEX12c.MaxLength = 12
        Me.txtEX12c.Name = "txtEX12c"
        Me.txtEX12c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX12c.TabIndex = 76
        Me.txtEX12c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX12b
        '
        Me.txtEX12b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX12b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX12b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX12b.Location = New System.Drawing.Point(208, 216)
        Me.txtEX12b.MaxLength = 12
        Me.txtEX12b.Name = "txtEX12b"
        Me.txtEX12b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX12b.TabIndex = 55
        Me.txtEX12b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX12a
        '
        Me.txtEX12a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX12a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX12a.Location = New System.Drawing.Point(136, 216)
        Me.txtEX12a.MaxLength = 12
        Me.txtEX12a.Name = "txtEX12a"
        Me.txtEX12a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX12a.TabIndex = 34
        Me.txtEX12a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX11h
        '
        Me.txtEX11h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX11h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX11h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX11h.Location = New System.Drawing.Point(640, 200)
        Me.txtEX11h.MaxLength = 12
        Me.txtEX11h.Name = "txtEX11h"
        Me.txtEX11h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX11h.TabIndex = 180
        Me.txtEX11h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX11g
        '
        Me.txtEX11g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX11g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX11g.Location = New System.Drawing.Point(568, 200)
        Me.txtEX11g.MaxLength = 12
        Me.txtEX11g.Name = "txtEX11g"
        Me.txtEX11g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX11g.TabIndex = 159
        Me.txtEX11g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX11f
        '
        Me.txtEX11f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX11f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX11f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX11f.Location = New System.Drawing.Point(496, 200)
        Me.txtEX11f.MaxLength = 12
        Me.txtEX11f.Name = "txtEX11f"
        Me.txtEX11f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX11f.TabIndex = 138
        Me.txtEX11f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX11e
        '
        Me.txtEX11e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX11e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX11e.Location = New System.Drawing.Point(424, 200)
        Me.txtEX11e.MaxLength = 12
        Me.txtEX11e.Name = "txtEX11e"
        Me.txtEX11e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX11e.TabIndex = 117
        Me.txtEX11e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX11d
        '
        Me.txtEX11d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX11d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX11d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX11d.Location = New System.Drawing.Point(352, 200)
        Me.txtEX11d.MaxLength = 12
        Me.txtEX11d.Name = "txtEX11d"
        Me.txtEX11d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX11d.TabIndex = 96
        Me.txtEX11d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX11c
        '
        Me.txtEX11c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX11c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX11c.Location = New System.Drawing.Point(280, 200)
        Me.txtEX11c.MaxLength = 12
        Me.txtEX11c.Name = "txtEX11c"
        Me.txtEX11c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX11c.TabIndex = 75
        Me.txtEX11c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX11b
        '
        Me.txtEX11b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX11b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX11b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX11b.Location = New System.Drawing.Point(208, 200)
        Me.txtEX11b.MaxLength = 12
        Me.txtEX11b.Name = "txtEX11b"
        Me.txtEX11b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX11b.TabIndex = 54
        Me.txtEX11b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX11a
        '
        Me.txtEX11a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX11a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX11a.Location = New System.Drawing.Point(136, 200)
        Me.txtEX11a.MaxLength = 12
        Me.txtEX11a.Name = "txtEX11a"
        Me.txtEX11a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX11a.TabIndex = 33
        Me.txtEX11a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX10h
        '
        Me.txtEX10h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX10h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX10h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX10h.Location = New System.Drawing.Point(640, 184)
        Me.txtEX10h.MaxLength = 12
        Me.txtEX10h.Name = "txtEX10h"
        Me.txtEX10h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX10h.TabIndex = 179
        Me.txtEX10h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX10g
        '
        Me.txtEX10g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX10g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX10g.Location = New System.Drawing.Point(568, 184)
        Me.txtEX10g.MaxLength = 12
        Me.txtEX10g.Name = "txtEX10g"
        Me.txtEX10g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX10g.TabIndex = 158
        Me.txtEX10g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX10f
        '
        Me.txtEX10f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX10f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX10f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX10f.Location = New System.Drawing.Point(496, 184)
        Me.txtEX10f.MaxLength = 12
        Me.txtEX10f.Name = "txtEX10f"
        Me.txtEX10f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX10f.TabIndex = 137
        Me.txtEX10f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX10e
        '
        Me.txtEX10e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX10e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX10e.Location = New System.Drawing.Point(424, 184)
        Me.txtEX10e.MaxLength = 12
        Me.txtEX10e.Name = "txtEX10e"
        Me.txtEX10e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX10e.TabIndex = 116
        Me.txtEX10e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX10d
        '
        Me.txtEX10d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX10d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX10d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX10d.Location = New System.Drawing.Point(352, 184)
        Me.txtEX10d.MaxLength = 12
        Me.txtEX10d.Name = "txtEX10d"
        Me.txtEX10d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX10d.TabIndex = 95
        Me.txtEX10d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX10c
        '
        Me.txtEX10c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX10c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX10c.Location = New System.Drawing.Point(280, 184)
        Me.txtEX10c.MaxLength = 12
        Me.txtEX10c.Name = "txtEX10c"
        Me.txtEX10c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX10c.TabIndex = 74
        Me.txtEX10c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX10b
        '
        Me.txtEX10b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX10b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX10b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX10b.Location = New System.Drawing.Point(208, 184)
        Me.txtEX10b.MaxLength = 12
        Me.txtEX10b.Name = "txtEX10b"
        Me.txtEX10b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX10b.TabIndex = 53
        Me.txtEX10b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX10a
        '
        Me.txtEX10a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX10a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX10a.Location = New System.Drawing.Point(136, 184)
        Me.txtEX10a.MaxLength = 12
        Me.txtEX10a.Name = "txtEX10a"
        Me.txtEX10a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX10a.TabIndex = 32
        Me.txtEX10a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX09h
        '
        Me.txtEX09h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX09h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX09h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX09h.Location = New System.Drawing.Point(640, 168)
        Me.txtEX09h.MaxLength = 12
        Me.txtEX09h.Name = "txtEX09h"
        Me.txtEX09h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX09h.TabIndex = 178
        Me.txtEX09h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX09g
        '
        Me.txtEX09g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX09g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX09g.Location = New System.Drawing.Point(568, 168)
        Me.txtEX09g.MaxLength = 12
        Me.txtEX09g.Name = "txtEX09g"
        Me.txtEX09g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX09g.TabIndex = 157
        Me.txtEX09g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX09f
        '
        Me.txtEX09f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX09f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX09f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX09f.Location = New System.Drawing.Point(496, 168)
        Me.txtEX09f.MaxLength = 12
        Me.txtEX09f.Name = "txtEX09f"
        Me.txtEX09f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX09f.TabIndex = 136
        Me.txtEX09f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX09e
        '
        Me.txtEX09e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX09e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX09e.Location = New System.Drawing.Point(424, 168)
        Me.txtEX09e.MaxLength = 12
        Me.txtEX09e.Name = "txtEX09e"
        Me.txtEX09e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX09e.TabIndex = 115
        Me.txtEX09e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX09d
        '
        Me.txtEX09d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX09d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX09d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX09d.Location = New System.Drawing.Point(352, 168)
        Me.txtEX09d.MaxLength = 12
        Me.txtEX09d.Name = "txtEX09d"
        Me.txtEX09d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX09d.TabIndex = 94
        Me.txtEX09d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX09c
        '
        Me.txtEX09c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX09c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX09c.Location = New System.Drawing.Point(280, 168)
        Me.txtEX09c.MaxLength = 12
        Me.txtEX09c.Name = "txtEX09c"
        Me.txtEX09c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX09c.TabIndex = 73
        Me.txtEX09c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX09b
        '
        Me.txtEX09b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX09b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX09b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX09b.Location = New System.Drawing.Point(208, 168)
        Me.txtEX09b.MaxLength = 12
        Me.txtEX09b.Name = "txtEX09b"
        Me.txtEX09b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX09b.TabIndex = 52
        Me.txtEX09b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX09a
        '
        Me.txtEX09a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX09a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX09a.Location = New System.Drawing.Point(136, 168)
        Me.txtEX09a.MaxLength = 12
        Me.txtEX09a.Name = "txtEX09a"
        Me.txtEX09a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX09a.TabIndex = 31
        Me.txtEX09a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX08h
        '
        Me.txtEX08h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX08h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX08h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX08h.Location = New System.Drawing.Point(640, 152)
        Me.txtEX08h.MaxLength = 12
        Me.txtEX08h.Name = "txtEX08h"
        Me.txtEX08h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX08h.TabIndex = 177
        Me.txtEX08h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX08g
        '
        Me.txtEX08g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX08g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX08g.Location = New System.Drawing.Point(568, 152)
        Me.txtEX08g.MaxLength = 12
        Me.txtEX08g.Name = "txtEX08g"
        Me.txtEX08g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX08g.TabIndex = 156
        Me.txtEX08g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX08f
        '
        Me.txtEX08f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX08f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX08f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX08f.Location = New System.Drawing.Point(496, 152)
        Me.txtEX08f.MaxLength = 12
        Me.txtEX08f.Name = "txtEX08f"
        Me.txtEX08f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX08f.TabIndex = 135
        Me.txtEX08f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX08e
        '
        Me.txtEX08e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX08e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX08e.Location = New System.Drawing.Point(424, 152)
        Me.txtEX08e.MaxLength = 12
        Me.txtEX08e.Name = "txtEX08e"
        Me.txtEX08e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX08e.TabIndex = 114
        Me.txtEX08e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX08d
        '
        Me.txtEX08d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX08d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX08d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX08d.Location = New System.Drawing.Point(352, 152)
        Me.txtEX08d.MaxLength = 12
        Me.txtEX08d.Name = "txtEX08d"
        Me.txtEX08d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX08d.TabIndex = 93
        Me.txtEX08d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX08c
        '
        Me.txtEX08c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX08c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX08c.Location = New System.Drawing.Point(280, 152)
        Me.txtEX08c.MaxLength = 12
        Me.txtEX08c.Name = "txtEX08c"
        Me.txtEX08c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX08c.TabIndex = 72
        Me.txtEX08c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX08b
        '
        Me.txtEX08b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX08b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX08b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX08b.Location = New System.Drawing.Point(208, 152)
        Me.txtEX08b.MaxLength = 12
        Me.txtEX08b.Name = "txtEX08b"
        Me.txtEX08b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX08b.TabIndex = 51
        Me.txtEX08b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX08a
        '
        Me.txtEX08a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX08a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX08a.Location = New System.Drawing.Point(136, 152)
        Me.txtEX08a.MaxLength = 12
        Me.txtEX08a.Name = "txtEX08a"
        Me.txtEX08a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX08a.TabIndex = 30
        Me.txtEX08a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX07h
        '
        Me.txtEX07h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX07h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX07h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX07h.Location = New System.Drawing.Point(640, 136)
        Me.txtEX07h.MaxLength = 12
        Me.txtEX07h.Name = "txtEX07h"
        Me.txtEX07h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX07h.TabIndex = 176
        Me.txtEX07h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX07g
        '
        Me.txtEX07g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX07g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX07g.Location = New System.Drawing.Point(568, 136)
        Me.txtEX07g.MaxLength = 12
        Me.txtEX07g.Name = "txtEX07g"
        Me.txtEX07g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX07g.TabIndex = 155
        Me.txtEX07g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX07f
        '
        Me.txtEX07f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX07f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX07f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX07f.Location = New System.Drawing.Point(496, 136)
        Me.txtEX07f.MaxLength = 12
        Me.txtEX07f.Name = "txtEX07f"
        Me.txtEX07f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX07f.TabIndex = 134
        Me.txtEX07f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX07e
        '
        Me.txtEX07e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX07e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX07e.Location = New System.Drawing.Point(424, 136)
        Me.txtEX07e.MaxLength = 12
        Me.txtEX07e.Name = "txtEX07e"
        Me.txtEX07e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX07e.TabIndex = 113
        Me.txtEX07e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX07d
        '
        Me.txtEX07d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX07d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX07d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX07d.Location = New System.Drawing.Point(352, 136)
        Me.txtEX07d.MaxLength = 12
        Me.txtEX07d.Name = "txtEX07d"
        Me.txtEX07d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX07d.TabIndex = 92
        Me.txtEX07d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX07c
        '
        Me.txtEX07c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX07c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX07c.Location = New System.Drawing.Point(280, 136)
        Me.txtEX07c.MaxLength = 12
        Me.txtEX07c.Name = "txtEX07c"
        Me.txtEX07c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX07c.TabIndex = 71
        Me.txtEX07c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX07b
        '
        Me.txtEX07b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX07b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX07b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX07b.Location = New System.Drawing.Point(208, 136)
        Me.txtEX07b.MaxLength = 12
        Me.txtEX07b.Name = "txtEX07b"
        Me.txtEX07b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX07b.TabIndex = 50
        Me.txtEX07b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX07a
        '
        Me.txtEX07a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX07a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX07a.Location = New System.Drawing.Point(136, 136)
        Me.txtEX07a.MaxLength = 12
        Me.txtEX07a.Name = "txtEX07a"
        Me.txtEX07a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX07a.TabIndex = 29
        Me.txtEX07a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX06h
        '
        Me.txtEX06h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX06h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX06h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX06h.Location = New System.Drawing.Point(640, 120)
        Me.txtEX06h.MaxLength = 12
        Me.txtEX06h.Name = "txtEX06h"
        Me.txtEX06h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX06h.TabIndex = 175
        Me.txtEX06h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX06g
        '
        Me.txtEX06g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX06g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX06g.Location = New System.Drawing.Point(568, 120)
        Me.txtEX06g.MaxLength = 12
        Me.txtEX06g.Name = "txtEX06g"
        Me.txtEX06g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX06g.TabIndex = 154
        Me.txtEX06g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX06f
        '
        Me.txtEX06f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX06f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX06f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX06f.Location = New System.Drawing.Point(496, 120)
        Me.txtEX06f.MaxLength = 12
        Me.txtEX06f.Name = "txtEX06f"
        Me.txtEX06f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX06f.TabIndex = 133
        Me.txtEX06f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX06e
        '
        Me.txtEX06e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX06e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX06e.Location = New System.Drawing.Point(424, 120)
        Me.txtEX06e.MaxLength = 12
        Me.txtEX06e.Name = "txtEX06e"
        Me.txtEX06e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX06e.TabIndex = 112
        Me.txtEX06e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX06d
        '
        Me.txtEX06d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX06d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX06d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX06d.Location = New System.Drawing.Point(352, 120)
        Me.txtEX06d.MaxLength = 12
        Me.txtEX06d.Name = "txtEX06d"
        Me.txtEX06d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX06d.TabIndex = 91
        Me.txtEX06d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX06c
        '
        Me.txtEX06c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX06c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX06c.Location = New System.Drawing.Point(280, 120)
        Me.txtEX06c.MaxLength = 12
        Me.txtEX06c.Name = "txtEX06c"
        Me.txtEX06c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX06c.TabIndex = 70
        Me.txtEX06c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX06b
        '
        Me.txtEX06b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX06b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX06b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX06b.Location = New System.Drawing.Point(208, 120)
        Me.txtEX06b.MaxLength = 12
        Me.txtEX06b.Name = "txtEX06b"
        Me.txtEX06b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX06b.TabIndex = 49
        Me.txtEX06b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX06a
        '
        Me.txtEX06a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX06a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX06a.Location = New System.Drawing.Point(136, 120)
        Me.txtEX06a.MaxLength = 12
        Me.txtEX06a.Name = "txtEX06a"
        Me.txtEX06a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX06a.TabIndex = 28
        Me.txtEX06a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX05h
        '
        Me.txtEX05h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX05h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX05h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX05h.Location = New System.Drawing.Point(640, 104)
        Me.txtEX05h.MaxLength = 12
        Me.txtEX05h.Name = "txtEX05h"
        Me.txtEX05h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX05h.TabIndex = 174
        Me.txtEX05h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX05g
        '
        Me.txtEX05g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX05g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX05g.Location = New System.Drawing.Point(568, 104)
        Me.txtEX05g.MaxLength = 12
        Me.txtEX05g.Name = "txtEX05g"
        Me.txtEX05g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX05g.TabIndex = 153
        Me.txtEX05g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX05f
        '
        Me.txtEX05f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX05f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX05f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX05f.Location = New System.Drawing.Point(496, 104)
        Me.txtEX05f.MaxLength = 12
        Me.txtEX05f.Name = "txtEX05f"
        Me.txtEX05f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX05f.TabIndex = 132
        Me.txtEX05f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX05e
        '
        Me.txtEX05e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX05e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX05e.Location = New System.Drawing.Point(424, 104)
        Me.txtEX05e.MaxLength = 12
        Me.txtEX05e.Name = "txtEX05e"
        Me.txtEX05e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX05e.TabIndex = 111
        Me.txtEX05e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX05d
        '
        Me.txtEX05d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX05d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX05d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX05d.Location = New System.Drawing.Point(352, 104)
        Me.txtEX05d.MaxLength = 12
        Me.txtEX05d.Name = "txtEX05d"
        Me.txtEX05d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX05d.TabIndex = 90
        Me.txtEX05d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX05c
        '
        Me.txtEX05c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX05c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX05c.Location = New System.Drawing.Point(280, 104)
        Me.txtEX05c.MaxLength = 12
        Me.txtEX05c.Name = "txtEX05c"
        Me.txtEX05c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX05c.TabIndex = 69
        Me.txtEX05c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX05b
        '
        Me.txtEX05b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX05b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX05b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX05b.Location = New System.Drawing.Point(208, 104)
        Me.txtEX05b.MaxLength = 12
        Me.txtEX05b.Name = "txtEX05b"
        Me.txtEX05b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX05b.TabIndex = 48
        Me.txtEX05b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX05a
        '
        Me.txtEX05a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX05a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX05a.Location = New System.Drawing.Point(136, 104)
        Me.txtEX05a.MaxLength = 12
        Me.txtEX05a.Name = "txtEX05a"
        Me.txtEX05a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX05a.TabIndex = 27
        Me.txtEX05a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX04h
        '
        Me.txtEX04h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX04h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX04h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX04h.Location = New System.Drawing.Point(640, 88)
        Me.txtEX04h.MaxLength = 12
        Me.txtEX04h.Name = "txtEX04h"
        Me.txtEX04h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX04h.TabIndex = 173
        Me.txtEX04h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX04g
        '
        Me.txtEX04g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX04g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX04g.Location = New System.Drawing.Point(568, 88)
        Me.txtEX04g.MaxLength = 12
        Me.txtEX04g.Name = "txtEX04g"
        Me.txtEX04g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX04g.TabIndex = 152
        Me.txtEX04g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX04f
        '
        Me.txtEX04f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX04f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX04f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX04f.Location = New System.Drawing.Point(496, 88)
        Me.txtEX04f.MaxLength = 12
        Me.txtEX04f.Name = "txtEX04f"
        Me.txtEX04f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX04f.TabIndex = 131
        Me.txtEX04f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX04e
        '
        Me.txtEX04e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX04e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX04e.Location = New System.Drawing.Point(424, 88)
        Me.txtEX04e.MaxLength = 12
        Me.txtEX04e.Name = "txtEX04e"
        Me.txtEX04e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX04e.TabIndex = 110
        Me.txtEX04e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX04d
        '
        Me.txtEX04d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX04d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX04d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX04d.Location = New System.Drawing.Point(352, 88)
        Me.txtEX04d.MaxLength = 12
        Me.txtEX04d.Name = "txtEX04d"
        Me.txtEX04d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX04d.TabIndex = 89
        Me.txtEX04d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX04c
        '
        Me.txtEX04c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX04c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX04c.Location = New System.Drawing.Point(280, 88)
        Me.txtEX04c.MaxLength = 12
        Me.txtEX04c.Name = "txtEX04c"
        Me.txtEX04c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX04c.TabIndex = 68
        Me.txtEX04c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX04b
        '
        Me.txtEX04b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX04b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX04b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX04b.Location = New System.Drawing.Point(208, 88)
        Me.txtEX04b.MaxLength = 12
        Me.txtEX04b.Name = "txtEX04b"
        Me.txtEX04b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX04b.TabIndex = 47
        Me.txtEX04b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX04a
        '
        Me.txtEX04a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX04a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX04a.Location = New System.Drawing.Point(136, 88)
        Me.txtEX04a.MaxLength = 12
        Me.txtEX04a.Name = "txtEX04a"
        Me.txtEX04a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX04a.TabIndex = 26
        Me.txtEX04a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX03h
        '
        Me.txtEX03h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX03h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX03h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX03h.Location = New System.Drawing.Point(640, 72)
        Me.txtEX03h.MaxLength = 12
        Me.txtEX03h.Name = "txtEX03h"
        Me.txtEX03h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX03h.TabIndex = 172
        Me.txtEX03h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX03g
        '
        Me.txtEX03g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX03g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX03g.Location = New System.Drawing.Point(568, 72)
        Me.txtEX03g.MaxLength = 12
        Me.txtEX03g.Name = "txtEX03g"
        Me.txtEX03g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX03g.TabIndex = 151
        Me.txtEX03g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX03f
        '
        Me.txtEX03f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX03f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX03f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX03f.Location = New System.Drawing.Point(496, 72)
        Me.txtEX03f.MaxLength = 12
        Me.txtEX03f.Name = "txtEX03f"
        Me.txtEX03f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX03f.TabIndex = 130
        Me.txtEX03f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX03e
        '
        Me.txtEX03e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX03e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX03e.Location = New System.Drawing.Point(424, 72)
        Me.txtEX03e.MaxLength = 12
        Me.txtEX03e.Name = "txtEX03e"
        Me.txtEX03e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX03e.TabIndex = 109
        Me.txtEX03e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX03d
        '
        Me.txtEX03d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX03d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX03d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX03d.Location = New System.Drawing.Point(352, 72)
        Me.txtEX03d.MaxLength = 12
        Me.txtEX03d.Name = "txtEX03d"
        Me.txtEX03d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX03d.TabIndex = 88
        Me.txtEX03d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX03c
        '
        Me.txtEX03c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX03c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX03c.Location = New System.Drawing.Point(280, 72)
        Me.txtEX03c.MaxLength = 12
        Me.txtEX03c.Name = "txtEX03c"
        Me.txtEX03c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX03c.TabIndex = 67
        Me.txtEX03c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX03b
        '
        Me.txtEX03b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX03b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX03b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX03b.Location = New System.Drawing.Point(208, 72)
        Me.txtEX03b.MaxLength = 12
        Me.txtEX03b.Name = "txtEX03b"
        Me.txtEX03b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX03b.TabIndex = 46
        Me.txtEX03b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX03a
        '
        Me.txtEX03a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX03a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX03a.Location = New System.Drawing.Point(136, 72)
        Me.txtEX03a.MaxLength = 12
        Me.txtEX03a.Name = "txtEX03a"
        Me.txtEX03a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX03a.TabIndex = 25
        Me.txtEX03a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX02h
        '
        Me.txtEX02h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX02h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX02h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX02h.Location = New System.Drawing.Point(640, 56)
        Me.txtEX02h.MaxLength = 12
        Me.txtEX02h.Name = "txtEX02h"
        Me.txtEX02h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX02h.TabIndex = 171
        Me.txtEX02h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX02g
        '
        Me.txtEX02g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX02g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX02g.Location = New System.Drawing.Point(568, 56)
        Me.txtEX02g.MaxLength = 12
        Me.txtEX02g.Name = "txtEX02g"
        Me.txtEX02g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX02g.TabIndex = 150
        Me.txtEX02g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX02f
        '
        Me.txtEX02f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX02f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX02f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX02f.Location = New System.Drawing.Point(496, 56)
        Me.txtEX02f.MaxLength = 12
        Me.txtEX02f.Name = "txtEX02f"
        Me.txtEX02f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX02f.TabIndex = 129
        Me.txtEX02f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX02e
        '
        Me.txtEX02e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX02e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX02e.Location = New System.Drawing.Point(424, 56)
        Me.txtEX02e.MaxLength = 12
        Me.txtEX02e.Name = "txtEX02e"
        Me.txtEX02e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX02e.TabIndex = 108
        Me.txtEX02e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX02d
        '
        Me.txtEX02d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX02d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX02d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX02d.Location = New System.Drawing.Point(352, 56)
        Me.txtEX02d.MaxLength = 12
        Me.txtEX02d.Name = "txtEX02d"
        Me.txtEX02d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX02d.TabIndex = 87
        Me.txtEX02d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX02c
        '
        Me.txtEX02c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX02c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX02c.Location = New System.Drawing.Point(280, 56)
        Me.txtEX02c.MaxLength = 12
        Me.txtEX02c.Name = "txtEX02c"
        Me.txtEX02c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX02c.TabIndex = 66
        Me.txtEX02c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX02b
        '
        Me.txtEX02b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX02b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX02b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX02b.Location = New System.Drawing.Point(208, 56)
        Me.txtEX02b.MaxLength = 12
        Me.txtEX02b.Name = "txtEX02b"
        Me.txtEX02b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX02b.TabIndex = 45
        Me.txtEX02b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX02a
        '
        Me.txtEX02a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX02a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX02a.Location = New System.Drawing.Point(136, 56)
        Me.txtEX02a.MaxLength = 12
        Me.txtEX02a.Name = "txtEX02a"
        Me.txtEX02a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX02a.TabIndex = 24
        Me.txtEX02a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX01h
        '
        Me.txtEX01h.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX01h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX01h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX01h.Location = New System.Drawing.Point(640, 40)
        Me.txtEX01h.MaxLength = 12
        Me.txtEX01h.Name = "txtEX01h"
        Me.txtEX01h.Size = New System.Drawing.Size(72, 13)
        Me.txtEX01h.TabIndex = 170
        Me.txtEX01h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX01g
        '
        Me.txtEX01g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX01g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX01g.Location = New System.Drawing.Point(568, 40)
        Me.txtEX01g.MaxLength = 12
        Me.txtEX01g.Name = "txtEX01g"
        Me.txtEX01g.Size = New System.Drawing.Size(72, 13)
        Me.txtEX01g.TabIndex = 149
        Me.txtEX01g.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX01f
        '
        Me.txtEX01f.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX01f.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX01f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX01f.Location = New System.Drawing.Point(496, 40)
        Me.txtEX01f.MaxLength = 12
        Me.txtEX01f.Name = "txtEX01f"
        Me.txtEX01f.Size = New System.Drawing.Size(72, 13)
        Me.txtEX01f.TabIndex = 128
        Me.txtEX01f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX01e
        '
        Me.txtEX01e.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX01e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX01e.Location = New System.Drawing.Point(424, 40)
        Me.txtEX01e.MaxLength = 12
        Me.txtEX01e.Name = "txtEX01e"
        Me.txtEX01e.Size = New System.Drawing.Size(72, 13)
        Me.txtEX01e.TabIndex = 107
        Me.txtEX01e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX01d
        '
        Me.txtEX01d.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX01d.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX01d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX01d.Location = New System.Drawing.Point(352, 40)
        Me.txtEX01d.MaxLength = 12
        Me.txtEX01d.Name = "txtEX01d"
        Me.txtEX01d.Size = New System.Drawing.Size(72, 13)
        Me.txtEX01d.TabIndex = 86
        Me.txtEX01d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX01c
        '
        Me.txtEX01c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX01c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX01c.Location = New System.Drawing.Point(280, 40)
        Me.txtEX01c.MaxLength = 12
        Me.txtEX01c.Name = "txtEX01c"
        Me.txtEX01c.Size = New System.Drawing.Size(72, 13)
        Me.txtEX01c.TabIndex = 65
        Me.txtEX01c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX01b
        '
        Me.txtEX01b.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtEX01b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX01b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX01b.Location = New System.Drawing.Point(208, 40)
        Me.txtEX01b.MaxLength = 12
        Me.txtEX01b.Name = "txtEX01b"
        Me.txtEX01b.Size = New System.Drawing.Size(72, 13)
        Me.txtEX01b.TabIndex = 44
        Me.txtEX01b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX01a
        '
        Me.txtEX01a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEX01a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX01a.Location = New System.Drawing.Point(136, 40)
        Me.txtEX01a.MaxLength = 12
        Me.txtEX01a.Name = "txtEX01a"
        Me.txtEX01a.Size = New System.Drawing.Size(72, 13)
        Me.txtEX01a.TabIndex = 23
        Me.txtEX01a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaLabH
        '
        Me.txtFechaLabH.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtFechaLabH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaLabH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaLabH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaLabH.Location = New System.Drawing.Point(640, 20)
        Me.txtFechaLabH.MaxLength = 10
        Me.txtFechaLabH.Name = "txtFechaLabH"
        Me.txtFechaLabH.ReadOnly = True
        Me.txtFechaLabH.Size = New System.Drawing.Size(72, 20)
        Me.txtFechaLabH.TabIndex = 169
        Me.txtFechaLabH.TabStop = False
        Me.txtFechaLabH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtFechaLabH, "Para seleccionar la fecha haz doble click")
        '
        'txtFechaLabG
        '
        Me.txtFechaLabG.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtFechaLabG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaLabG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaLabG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaLabG.Location = New System.Drawing.Point(568, 20)
        Me.txtFechaLabG.MaxLength = 10
        Me.txtFechaLabG.Name = "txtFechaLabG"
        Me.txtFechaLabG.ReadOnly = True
        Me.txtFechaLabG.Size = New System.Drawing.Size(72, 20)
        Me.txtFechaLabG.TabIndex = 148
        Me.txtFechaLabG.TabStop = False
        Me.txtFechaLabG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtFechaLabG, "Para seleccionar la fecha haz doble click")
        '
        'txtFechaLabF
        '
        Me.txtFechaLabF.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtFechaLabF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaLabF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaLabF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaLabF.Location = New System.Drawing.Point(496, 20)
        Me.txtFechaLabF.MaxLength = 10
        Me.txtFechaLabF.Name = "txtFechaLabF"
        Me.txtFechaLabF.ReadOnly = True
        Me.txtFechaLabF.Size = New System.Drawing.Size(72, 20)
        Me.txtFechaLabF.TabIndex = 127
        Me.txtFechaLabF.TabStop = False
        Me.txtFechaLabF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtFechaLabF, "Para seleccionar la fecha haz doble click")
        '
        'txtFechaLabE
        '
        Me.txtFechaLabE.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtFechaLabE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaLabE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaLabE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaLabE.Location = New System.Drawing.Point(424, 20)
        Me.txtFechaLabE.MaxLength = 10
        Me.txtFechaLabE.Name = "txtFechaLabE"
        Me.txtFechaLabE.ReadOnly = True
        Me.txtFechaLabE.Size = New System.Drawing.Size(72, 20)
        Me.txtFechaLabE.TabIndex = 106
        Me.txtFechaLabE.TabStop = False
        Me.txtFechaLabE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtFechaLabE, "Para seleccionar la fecha haz doble click")
        '
        'txtFechaLabD
        '
        Me.txtFechaLabD.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtFechaLabD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaLabD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaLabD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaLabD.Location = New System.Drawing.Point(352, 20)
        Me.txtFechaLabD.MaxLength = 10
        Me.txtFechaLabD.Name = "txtFechaLabD"
        Me.txtFechaLabD.ReadOnly = True
        Me.txtFechaLabD.Size = New System.Drawing.Size(72, 20)
        Me.txtFechaLabD.TabIndex = 85
        Me.txtFechaLabD.TabStop = False
        Me.txtFechaLabD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtFechaLabD, "Para seleccionar la fecha haz doble click")
        '
        'txtFechaLabC
        '
        Me.txtFechaLabC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtFechaLabC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaLabC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaLabC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaLabC.Location = New System.Drawing.Point(280, 20)
        Me.txtFechaLabC.MaxLength = 10
        Me.txtFechaLabC.Name = "txtFechaLabC"
        Me.txtFechaLabC.ReadOnly = True
        Me.txtFechaLabC.Size = New System.Drawing.Size(72, 20)
        Me.txtFechaLabC.TabIndex = 64
        Me.txtFechaLabC.TabStop = False
        Me.txtFechaLabC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtFechaLabC, "Para seleccionar la fecha haz doble click")
        '
        'txtFechaLabB
        '
        Me.txtFechaLabB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtFechaLabB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaLabB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaLabB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaLabB.Location = New System.Drawing.Point(208, 20)
        Me.txtFechaLabB.MaxLength = 10
        Me.txtFechaLabB.Name = "txtFechaLabB"
        Me.txtFechaLabB.ReadOnly = True
        Me.txtFechaLabB.Size = New System.Drawing.Size(72, 20)
        Me.txtFechaLabB.TabIndex = 43
        Me.txtFechaLabB.TabStop = False
        Me.txtFechaLabB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtFechaLabB, "Para seleccionar la fecha haz doble click")
        '
        'txtFechaLabA
        '
        Me.txtFechaLabA.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtFechaLabA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaLabA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaLabA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaLabA.Location = New System.Drawing.Point(136, 20)
        Me.txtFechaLabA.MaxLength = 10
        Me.txtFechaLabA.Name = "txtFechaLabA"
        Me.txtFechaLabA.ReadOnly = True
        Me.txtFechaLabA.Size = New System.Drawing.Size(72, 20)
        Me.txtFechaLabA.TabIndex = 22
        Me.txtFechaLabA.TabStop = False
        Me.txtFechaLabA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtFechaLabA, "Para seleccionar la fecha haz doble click")
        '
        'txtOtroEx02
        '
        Me.txtOtroEx02.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtOtroEx02.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtroEx02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtroEx02.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOtroEx02.Location = New System.Drawing.Point(0, 328)
        Me.txtOtroEx02.MaxLength = 18
        Me.txtOtroEx02.Name = "txtOtroEx02"
        Me.txtOtroEx02.Size = New System.Drawing.Size(136, 13)
        Me.txtOtroEx02.TabIndex = 20
        Me.txtOtroEx02.Text = "Otro"
        Me.txtOtroEx02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOtroEx01
        '
        Me.txtOtroEx01.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtOtroEx01.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtroEx01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtroEx01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOtroEx01.Location = New System.Drawing.Point(0, 312)
        Me.txtOtroEx01.MaxLength = 18
        Me.txtOtroEx01.Name = "txtOtroEx01"
        Me.txtOtroEx01.Size = New System.Drawing.Size(136, 13)
        Me.txtOtroEx01.TabIndex = 19
        Me.txtOtroEx01.Text = "Otro"
        Me.txtOtroEx01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label68
        '
        Me.Label68.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label68.Location = New System.Drawing.Point(0, 168)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(136, 13)
        Me.Label68.TabIndex = 10
        Me.Label68.Text = "PTT"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label67.Location = New System.Drawing.Point(0, 152)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(136, 13)
        Me.Label67.TabIndex = 9
        Me.Label67.Text = "PT"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label66.Location = New System.Drawing.Point(0, 296)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(136, 13)
        Me.Label66.TabIndex = 18
        Me.Label66.Text = "Progesterona"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label65.Location = New System.Drawing.Point(0, 280)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(136, 13)
        Me.Label65.TabIndex = 17
        Me.Label65.Text = "Estradiol"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label64.Location = New System.Drawing.Point(0, 264)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(136, 13)
        Me.Label64.TabIndex = 16
        Me.Label64.Text = "LH"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label62.Location = New System.Drawing.Point(0, 248)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(136, 13)
        Me.Label62.TabIndex = 15
        Me.Label62.Text = "FSH"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label61.Location = New System.Drawing.Point(0, 232)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(136, 13)
        Me.Label61.TabIndex = 14
        Me.Label61.Text = "HIV"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label60.Location = New System.Drawing.Point(0, 216)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(136, 13)
        Me.Label60.TabIndex = 13
        Me.Label60.Text = "VDRL"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label59.Location = New System.Drawing.Point(0, 200)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(136, 13)
        Me.Label59.TabIndex = 12
        Me.Label59.Text = "Creatinina"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label58.Location = New System.Drawing.Point(0, 184)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(136, 13)
        Me.Label58.TabIndex = 11
        Me.Label58.Text = "Glicemia"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label57.Location = New System.Drawing.Point(0, 136)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(136, 13)
        Me.Label57.TabIndex = 8
        Me.Label57.Text = "Plaquetas"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label56.Location = New System.Drawing.Point(0, 120)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(136, 13)
        Me.Label56.TabIndex = 7
        Me.Label56.Text = "Mon"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label55.Location = New System.Drawing.Point(0, 104)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(136, 13)
        Me.Label55.TabIndex = 6
        Me.Label55.Text = "Lin"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label54.Location = New System.Drawing.Point(0, 88)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(136, 13)
        Me.Label54.TabIndex = 5
        Me.Label54.Text = "Seg"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label53.Location = New System.Drawing.Point(0, 72)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(136, 13)
        Me.Label53.TabIndex = 4
        Me.Label53.Text = "GB"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label52.Location = New System.Drawing.Point(0, 56)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(136, 13)
        Me.Label52.TabIndex = 3
        Me.Label52.Text = "Hto"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label42.Location = New System.Drawing.Point(136, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(576, 23)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "Fechas de los Examenes de Laboratorio"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPageLaboratorio2
        '
        Me.TabPageLaboratorio2.Controls.Add(Me.txtOtroEx09)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtOtroEx04)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21h)
        Me.TabPageLaboratorio2.Controls.Add(Me.Label98)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21g)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21f)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21e)
        Me.TabPageLaboratorio2.Controls.Add(Me.Label99)
        Me.TabPageLaboratorio2.Controls.Add(Me.Label95)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21d)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21l)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtOtroEx08)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21k)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtOtroEx07)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21j)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtOtroEx06)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21i)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtOtroEx05)
        Me.TabPageLaboratorio2.Controls.Add(Me.Label70)
        Me.TabPageLaboratorio2.Controls.Add(Me.Label69)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21c)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21b)
        Me.TabPageLaboratorio2.Controls.Add(Me.txtEX21a)
        Me.TabPageLaboratorio2.Controls.Add(Me.Label63)
        Me.TabPageLaboratorio2.Location = New System.Drawing.Point(4, 22)
        Me.TabPageLaboratorio2.Name = "TabPageLaboratorio2"
        Me.TabPageLaboratorio2.Size = New System.Drawing.Size(776, 394)
        Me.TabPageLaboratorio2.TabIndex = 4
        Me.TabPageLaboratorio2.Text = "Laboratorio #2"
        Me.TabPageLaboratorio2.Visible = False
        '
        'txtOtroEx09
        '
        Me.txtOtroEx09.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtOtroEx09.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtroEx09.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtroEx09.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOtroEx09.Location = New System.Drawing.Point(592, 264)
        Me.txtOtroEx09.MaxLength = 50
        Me.txtOtroEx09.Name = "txtOtroEx09"
        Me.txtOtroEx09.Size = New System.Drawing.Size(180, 13)
        Me.txtOtroEx09.TabIndex = 22
        Me.txtOtroEx09.Text = "Otro"
        Me.txtOtroEx09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOtroEx04
        '
        Me.txtOtroEx04.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtOtroEx04.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtroEx04.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtroEx04.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOtroEx04.Location = New System.Drawing.Point(396, 136)
        Me.txtOtroEx04.MaxLength = 50
        Me.txtOtroEx04.Name = "txtOtroEx04"
        Me.txtOtroEx04.Size = New System.Drawing.Size(190, 13)
        Me.txtOtroEx04.TabIndex = 12
        Me.txtOtroEx04.Text = "Otro"
        Me.txtOtroEx04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX21h
        '
        Me.txtEX21h.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21h.Location = New System.Drawing.Point(592, 152)
        Me.txtEX21h.MaxLength = 4096
        Me.txtEX21h.Multiline = True
        Me.txtEX21h.Name = "txtEX21h"
        Me.txtEX21h.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21h.Size = New System.Drawing.Size(180, 108)
        Me.txtEX21h.TabIndex = 15
        '
        'Label98
        '
        Me.Label98.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label98.Location = New System.Drawing.Point(200, 136)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(190, 13)
        Me.Label98.TabIndex = 10
        Me.Label98.Text = "Tipificación VPH"
        Me.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEX21g
        '
        Me.txtEX21g.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21g.Location = New System.Drawing.Point(396, 152)
        Me.txtEX21g.MaxLength = 4096
        Me.txtEX21g.Multiline = True
        Me.txtEX21g.Name = "txtEX21g"
        Me.txtEX21g.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21g.Size = New System.Drawing.Size(190, 108)
        Me.txtEX21g.TabIndex = 13
        '
        'txtEX21f
        '
        Me.txtEX21f.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21f.Location = New System.Drawing.Point(200, 152)
        Me.txtEX21f.MaxLength = 4096
        Me.txtEX21f.Multiline = True
        Me.txtEX21f.Name = "txtEX21f"
        Me.txtEX21f.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21f.Size = New System.Drawing.Size(190, 108)
        Me.txtEX21f.TabIndex = 11
        '
        'txtEX21e
        '
        Me.txtEX21e.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21e.Location = New System.Drawing.Point(4, 152)
        Me.txtEX21e.MaxLength = 4096
        Me.txtEX21e.Multiline = True
        Me.txtEX21e.Name = "txtEX21e"
        Me.txtEX21e.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21e.Size = New System.Drawing.Size(190, 108)
        Me.txtEX21e.TabIndex = 9
        '
        'Label99
        '
        Me.Label99.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label99.Location = New System.Drawing.Point(4, 136)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(190, 13)
        Me.Label99.TabIndex = 8
        Me.Label99.Text = "Citología"
        Me.Label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label95
        '
        Me.Label95.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label95.Location = New System.Drawing.Point(592, 8)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(180, 13)
        Me.Label95.TabIndex = 6
        Me.Label95.Text = "Coprocultivo"
        Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEX21d
        '
        Me.txtEX21d.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21d.Location = New System.Drawing.Point(592, 24)
        Me.txtEX21d.MaxLength = 4096
        Me.txtEX21d.Multiline = True
        Me.txtEX21d.Name = "txtEX21d"
        Me.txtEX21d.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21d.Size = New System.Drawing.Size(180, 108)
        Me.txtEX21d.TabIndex = 7
        '
        'txtEX21l
        '
        Me.txtEX21l.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21l.Location = New System.Drawing.Point(592, 280)
        Me.txtEX21l.MaxLength = 4096
        Me.txtEX21l.Multiline = True
        Me.txtEX21l.Name = "txtEX21l"
        Me.txtEX21l.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21l.Size = New System.Drawing.Size(180, 108)
        Me.txtEX21l.TabIndex = 23
        '
        'txtOtroEx08
        '
        Me.txtOtroEx08.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtOtroEx08.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtroEx08.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtroEx08.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOtroEx08.Location = New System.Drawing.Point(396, 264)
        Me.txtOtroEx08.MaxLength = 50
        Me.txtOtroEx08.Name = "txtOtroEx08"
        Me.txtOtroEx08.Size = New System.Drawing.Size(188, 13)
        Me.txtOtroEx08.TabIndex = 20
        Me.txtOtroEx08.Text = "Otro"
        Me.txtOtroEx08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX21k
        '
        Me.txtEX21k.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21k.Location = New System.Drawing.Point(396, 280)
        Me.txtEX21k.MaxLength = 4096
        Me.txtEX21k.Multiline = True
        Me.txtEX21k.Name = "txtEX21k"
        Me.txtEX21k.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21k.Size = New System.Drawing.Size(190, 108)
        Me.txtEX21k.TabIndex = 21
        '
        'txtOtroEx07
        '
        Me.txtOtroEx07.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtOtroEx07.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtroEx07.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtroEx07.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOtroEx07.Location = New System.Drawing.Point(200, 264)
        Me.txtOtroEx07.MaxLength = 50
        Me.txtOtroEx07.Name = "txtOtroEx07"
        Me.txtOtroEx07.Size = New System.Drawing.Size(190, 13)
        Me.txtOtroEx07.TabIndex = 18
        Me.txtOtroEx07.Text = "Otro"
        Me.txtOtroEx07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX21j
        '
        Me.txtEX21j.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21j.Location = New System.Drawing.Point(200, 280)
        Me.txtEX21j.MaxLength = 4096
        Me.txtEX21j.Multiline = True
        Me.txtEX21j.Name = "txtEX21j"
        Me.txtEX21j.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21j.Size = New System.Drawing.Size(190, 108)
        Me.txtEX21j.TabIndex = 19
        '
        'txtOtroEx06
        '
        Me.txtOtroEx06.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtOtroEx06.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtroEx06.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtroEx06.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOtroEx06.Location = New System.Drawing.Point(4, 264)
        Me.txtOtroEx06.MaxLength = 50
        Me.txtOtroEx06.Name = "txtOtroEx06"
        Me.txtOtroEx06.Size = New System.Drawing.Size(190, 13)
        Me.txtOtroEx06.TabIndex = 16
        Me.txtOtroEx06.Text = "Otro"
        Me.txtOtroEx06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEX21i
        '
        Me.txtEX21i.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21i.Location = New System.Drawing.Point(4, 280)
        Me.txtEX21i.MaxLength = 4096
        Me.txtEX21i.Multiline = True
        Me.txtEX21i.Name = "txtEX21i"
        Me.txtEX21i.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21i.Size = New System.Drawing.Size(190, 108)
        Me.txtEX21i.TabIndex = 17
        '
        'txtOtroEx05
        '
        Me.txtOtroEx05.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtOtroEx05.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtroEx05.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtroEx05.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOtroEx05.Location = New System.Drawing.Point(592, 136)
        Me.txtOtroEx05.MaxLength = 50
        Me.txtOtroEx05.Name = "txtOtroEx05"
        Me.txtOtroEx05.Size = New System.Drawing.Size(180, 13)
        Me.txtOtroEx05.TabIndex = 14
        Me.txtOtroEx05.Text = "Otro"
        Me.txtOtroEx05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label70.Location = New System.Drawing.Point(396, 8)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(190, 13)
        Me.Label70.TabIndex = 4
        Me.Label70.Text = "Heces"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label69.Location = New System.Drawing.Point(200, 8)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(190, 13)
        Me.Label69.TabIndex = 2
        Me.Label69.Text = "Urocultivo y Antibiograma"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEX21c
        '
        Me.txtEX21c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21c.Location = New System.Drawing.Point(396, 24)
        Me.txtEX21c.MaxLength = 4096
        Me.txtEX21c.Multiline = True
        Me.txtEX21c.Name = "txtEX21c"
        Me.txtEX21c.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21c.Size = New System.Drawing.Size(190, 108)
        Me.txtEX21c.TabIndex = 5
        '
        'txtEX21b
        '
        Me.txtEX21b.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21b.Location = New System.Drawing.Point(200, 24)
        Me.txtEX21b.MaxLength = 4096
        Me.txtEX21b.Multiline = True
        Me.txtEX21b.Name = "txtEX21b"
        Me.txtEX21b.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21b.Size = New System.Drawing.Size(190, 108)
        Me.txtEX21b.TabIndex = 3
        '
        'txtEX21a
        '
        Me.txtEX21a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEX21a.Location = New System.Drawing.Point(4, 24)
        Me.txtEX21a.MaxLength = 4096
        Me.txtEX21a.Multiline = True
        Me.txtEX21a.Name = "txtEX21a"
        Me.txtEX21a.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEX21a.Size = New System.Drawing.Size(190, 108)
        Me.txtEX21a.TabIndex = 1
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label63.Location = New System.Drawing.Point(4, 8)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(190, 13)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "Orina"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPageInforme
        '
        Me.TabPageInforme.Controls.Add(Me.botPersonaliza)
        Me.TabPageInforme.Controls.Add(Me.botImprimeInforme)
        Me.TabPageInforme.Controls.Add(Me.botCreaRestableceInforme)
        Me.TabPageInforme.Controls.Add(Me.txtInforme)
        Me.TabPageInforme.Location = New System.Drawing.Point(4, 22)
        Me.TabPageInforme.Name = "TabPageInforme"
        Me.TabPageInforme.Size = New System.Drawing.Size(776, 394)
        Me.TabPageInforme.TabIndex = 6
        Me.TabPageInforme.Text = "Informe Ginecológico"
        Me.TabPageInforme.Visible = False
        '
        'botPersonaliza
        '
        Me.botPersonaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botPersonaliza.Image = CType(resources.GetObject("botPersonaliza.Image"), System.Drawing.Image)
        Me.botPersonaliza.Location = New System.Drawing.Point(400, 368)
        Me.botPersonaliza.Name = "botPersonaliza"
        Me.botPersonaliza.Size = New System.Drawing.Size(120, 23)
        Me.botPersonaliza.TabIndex = 10
        Me.botPersonaliza.Text = "Personaliza Informe"
        '
        'botImprimeInforme
        '
        Me.botImprimeInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botImprimeInforme.Image = CType(resources.GetObject("botImprimeInforme.Image"), System.Drawing.Image)
        Me.botImprimeInforme.Location = New System.Drawing.Point(524, 368)
        Me.botImprimeInforme.Name = "botImprimeInforme"
        Me.botImprimeInforme.Size = New System.Drawing.Size(124, 23)
        Me.botImprimeInforme.TabIndex = 1
        Me.botImprimeInforme.Text = "Imprime Informe"
        '
        'botCreaRestableceInforme
        '
        Me.botCreaRestableceInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCreaRestableceInforme.Image = CType(resources.GetObject("botCreaRestableceInforme.Image"), System.Drawing.Image)
        Me.botCreaRestableceInforme.Location = New System.Drawing.Point(652, 368)
        Me.botCreaRestableceInforme.Name = "botCreaRestableceInforme"
        Me.botCreaRestableceInforme.Size = New System.Drawing.Size(124, 23)
        Me.botCreaRestableceInforme.TabIndex = 2
        Me.botCreaRestableceInforme.Text = "Crear Informe"
        '
        'txtInforme
        '
        Me.txtInforme.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInforme.Location = New System.Drawing.Point(0, 8)
        Me.txtInforme.MaxLength = 24576
        Me.txtInforme.Multiline = True
        Me.txtInforme.Name = "txtInforme"
        Me.txtInforme.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInforme.Size = New System.Drawing.Size(773, 356)
        Me.txtInforme.TabIndex = 0
        Me.txtInforme.WordWrap = False
        '
        'labPatologia
        '
        Me.labPatologia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labPatologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPatologia.Image = CType(resources.GetObject("labPatologia.Image"), System.Drawing.Image)
        Me.labPatologia.Location = New System.Drawing.Point(8, 8)
        Me.labPatologia.Name = "labPatologia"
        Me.labPatologia.Size = New System.Drawing.Size(360, 23)
        Me.labPatologia.TabIndex = 0
        Me.labPatologia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPageDatosPersonales
        '
        Me.TabPageDatosPersonales.Controls.Add(Me.Label24)
        Me.TabPageDatosPersonales.Controls.Add(Me.TabControl2)
        Me.TabPageDatosPersonales.Controls.Add(Me.Panel3)
        Me.TabPageDatosPersonales.Controls.Add(Me.Label12)
        Me.TabPageDatosPersonales.Controls.Add(Me.Label11)
        Me.TabPageDatosPersonales.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDatosPersonales.Name = "TabPageDatosPersonales"
        Me.TabPageDatosPersonales.Size = New System.Drawing.Size(784, 454)
        Me.TabPageDatosPersonales.TabIndex = 0
        Me.TabPageDatosPersonales.Text = "Datos Personales"
        Me.TabPageDatosPersonales.Visible = False
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(4, 112)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(192, 23)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Antecedentes"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(0, 136)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(784, 264)
        Me.TabControl2.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtAntFamiliares)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(776, 238)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Familiares"
        '
        'txtAntFamiliares
        '
        Me.txtAntFamiliares.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntFamiliares.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntFamiliares.Location = New System.Drawing.Point(4, 8)
        Me.txtAntFamiliares.Multiline = True
        Me.txtAntFamiliares.Name = "txtAntFamiliares"
        Me.txtAntFamiliares.ReadOnly = True
        Me.txtAntFamiliares.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntFamiliares.Size = New System.Drawing.Size(772, 224)
        Me.txtAntFamiliares.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtAntPersonales)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(776, 238)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Personales"
        Me.TabPage2.Visible = False
        '
        'txtAntPersonales
        '
        Me.txtAntPersonales.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntPersonales.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntPersonales.Location = New System.Drawing.Point(4, 7)
        Me.txtAntPersonales.Multiline = True
        Me.txtAntPersonales.Name = "txtAntPersonales"
        Me.txtAntPersonales.ReadOnly = True
        Me.txtAntPersonales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntPersonales.Size = New System.Drawing.Size(772, 224)
        Me.txtAntPersonales.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtAntGinecologicos)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(776, 238)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ginecológicos"
        Me.TabPage3.Visible = False
        '
        'txtAntGinecologicos
        '
        Me.txtAntGinecologicos.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntGinecologicos.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntGinecologicos.Location = New System.Drawing.Point(4, 7)
        Me.txtAntGinecologicos.Multiline = True
        Me.txtAntGinecologicos.Name = "txtAntGinecologicos"
        Me.txtAntGinecologicos.ReadOnly = True
        Me.txtAntGinecologicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntGinecologicos.Size = New System.Drawing.Size(772, 224)
        Me.txtAntGinecologicos.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtAntObstetricos)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(776, 238)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Obstétricos"
        Me.TabPage4.Visible = False
        '
        'txtAntObstetricos
        '
        Me.txtAntObstetricos.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntObstetricos.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntObstetricos.Location = New System.Drawing.Point(4, 7)
        Me.txtAntObstetricos.Multiline = True
        Me.txtAntObstetricos.Name = "txtAntObstetricos"
        Me.txtAntObstetricos.ReadOnly = True
        Me.txtAntObstetricos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntObstetricos.Size = New System.Drawing.Size(772, 224)
        Me.txtAntObstetricos.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtAntQuirurgicos)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(776, 238)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Quirúrgicos"
        Me.TabPage5.Visible = False
        '
        'txtAntQuirurgicos
        '
        Me.txtAntQuirurgicos.BackColor = System.Drawing.SystemColors.Info
        Me.txtAntQuirurgicos.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntQuirurgicos.Location = New System.Drawing.Point(4, 7)
        Me.txtAntQuirurgicos.Multiline = True
        Me.txtAntQuirurgicos.Name = "txtAntQuirurgicos"
        Me.txtAntQuirurgicos.ReadOnly = True
        Me.txtAntQuirurgicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntQuirurgicos.Size = New System.Drawing.Size(772, 224)
        Me.txtAntQuirurgicos.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtTelefono)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.txtProfesion)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.txtCedula)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.txtEdad)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.txtFechaNacimiento)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.txtNombrePaciente)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Location = New System.Drawing.Point(4, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(776, 72)
        Me.Panel3.TabIndex = 1
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.Info
        Me.txtTelefono.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(636, 40)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(128, 18)
        Me.txtTelefono.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(580, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 23)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Telefono"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProfesion
        '
        Me.txtProfesion.BackColor = System.Drawing.SystemColors.Info
        Me.txtProfesion.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfesion.Location = New System.Drawing.Point(320, 40)
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.ReadOnly = True
        Me.txtProfesion.Size = New System.Drawing.Size(212, 18)
        Me.txtProfesion.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(264, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 23)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Profesión"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(104, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 23)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Cédula"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 23)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Edad"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.BackColor = System.Drawing.SystemColors.Info
        Me.txtFechaNacimiento.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(636, 8)
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.ReadOnly = True
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(128, 18)
        Me.txtFechaNacimiento.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(540, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 23)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Fecha Nacimiento"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombrePaciente.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePaciente.Location = New System.Drawing.Point(56, 8)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.ReadOnly = True
        Me.txtNombrePaciente.Size = New System.Drawing.Size(476, 18)
        Me.txtNombrePaciente.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 8)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 23)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Nombre"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(16, 412)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(752, 23)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Para modificar o agregar datos selecciona Datos Personales de la lista de element" & _
    "os de la Historia... "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(4, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Datos Personales"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'botSalirSinGuardar
        '
        Me.botSalirSinGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botSalirSinGuardar.Image = CType(resources.GetObject("botSalirSinGuardar.Image"), System.Drawing.Image)
        Me.botSalirSinGuardar.Location = New System.Drawing.Point(4, 492)
        Me.botSalirSinGuardar.Name = "botSalirSinGuardar"
        Me.botSalirSinGuardar.Size = New System.Drawing.Size(224, 23)
        Me.botSalirSinGuardar.TabIndex = 1
        Me.botSalirSinGuardar.Text = "Salir"
        '
        'botGuardarNuevosDatos
        '
        Me.botGuardarNuevosDatos.Enabled = False
        Me.botGuardarNuevosDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botGuardarNuevosDatos.Image = CType(resources.GetObject("botGuardarNuevosDatos.Image"), System.Drawing.Image)
        Me.botGuardarNuevosDatos.Location = New System.Drawing.Point(564, 492)
        Me.botGuardarNuevosDatos.Name = "botGuardarNuevosDatos"
        Me.botGuardarNuevosDatos.Size = New System.Drawing.Size(224, 23)
        Me.botGuardarNuevosDatos.TabIndex = 2
        Me.botGuardarNuevosDatos.Text = "Guarda Nuevos Datos"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
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
        'PrintDocument1
        '
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuCalculoEGconECO, Me.menuCalculoEGconFUR, Me.menuCalculoDCconFUR, Me.menuCaluloEGconBiometria})
        Me.MenuItem1.Text = "Herramientas"
        '
        'menuCalculoEGconECO
        '
        Me.menuCalculoEGconECO.Index = 0
        Me.menuCalculoEGconECO.Text = "Cálculo de EG con un ECO"
        '
        'menuCalculoEGconFUR
        '
        Me.menuCalculoEGconFUR.Index = 1
        Me.menuCalculoEGconFUR.Text = "Cálculo de EG con la FUR"
        '
        'menuCalculoDCconFUR
        '
        Me.menuCalculoDCconFUR.Index = 2
        Me.menuCalculoDCconFUR.Text = "Cálculo del Día del Ciclo con la FUR"
        '
        'menuCaluloEGconBiometria
        '
        Me.menuCaluloEGconBiometria.Index = 3
        Me.menuCaluloEGconBiometria.Text = "Cálculo de la EG y Peso con Biometría"
        '
        'FormControlGinecologico2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 651)
        Me.ControlBox = False
        Me.Controls.Add(Me.botSalirSinGuardar)
        Me.Controls.Add(Me.botGuardarNuevosDatos)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Menu = Me.MainMenu1
        Me.Name = "FormControlGinecologico2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control Ginecológico"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageIndice.ResumeLayout(False)
        CType(Me.PictureImpresora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageControles.ResumeLayout(False)
        Me.TabPageControles.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPageInicio.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPageEvolucion.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
        Me.Tab2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Tab3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Tab4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Tab5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Tab6.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Tab7.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Tab8.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.Tab9.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.Tab10.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabPageLaboratorio1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPageLaboratorio2.ResumeLayout(False)
        Me.TabPageLaboratorio2.PerformLayout()
        Me.TabPageInforme.ResumeLayout(False)
        Me.TabPageInforme.PerformLayout()
        Me.TabPageDatosPersonales.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Structure EstructuraDatosGinecologicos
        Dim FechaInicioControl As String
        Dim PatologiaControl As String
        'primera consulta
        Dim txt01a As String : Dim txt01b As String : Dim txt01c As String
        Dim txt01d As String : Dim txt01e As String : Dim txt01f As String
        Dim txt01g As String
        Dim txt01h As String 'ojo 01 es el unico que tiene h

        'consultas sucesivas de la 2 a la 10
        Dim txt02a As String : Dim txt02b As String : Dim txt02c As String
        Dim txt02d As String : Dim txt02e As String : Dim txt02f As String
        Dim txt02g As String

        Dim txt03a As String : Dim txt03b As String : Dim txt03c As String
        Dim txt03d As String : Dim txt03e As String : Dim txt03f As String
        Dim txt03g As String

        Dim txt04a As String : Dim txt04b As String : Dim txt04c As String
        Dim txt04d As String : Dim txt04e As String : Dim txt04f As String
        Dim txt04g As String
        Dim txt05a As String : Dim txt05b As String : Dim txt05c As String
        Dim txt05d As String : Dim txt05e As String : Dim txt05f As String
        Dim txt05g As String
        Dim txt06a As String : Dim txt06b As String : Dim txt06c As String
        Dim txt06d As String : Dim txt06e As String : Dim txt06f As String
        Dim txt06g As String
        Dim txt07a As String : Dim txt07b As String : Dim txt07c As String
        Dim txt07d As String : Dim txt07e As String : Dim txt07f As String
        Dim txt07g As String
        Dim txt08a As String : Dim txt08b As String : Dim txt08c As String
        Dim txt08d As String : Dim txt08e As String : Dim txt08f As String
        Dim txt08g As String
        Dim txt09a As String : Dim txt09b As String : Dim txt09c As String
        Dim txt09d As String : Dim txt09e As String : Dim txt09f As String
        Dim txt09g As String
        Dim txt10a As String : Dim txt10b As String : Dim txt10c As String
        Dim txt10d As String : Dim txt10e As String : Dim txt10f As String
        Dim txt10g As String

        'fechas de los laboratorios
        Dim txtFechaLabA As String : Dim txtFechaLabB As String
        Dim txtFechaLabC As String : Dim txtFechaLabD As String
        Dim txtFechaLabE As String : Dim txtFechaLabF As String
        Dim txtFechaLabG As String : Dim txtFechaLabH As String

        'laboratorios del 01 al 20
        Dim txtEX01a As String : Dim txtEX01b As String
        Dim txtEX01c As String : Dim txtEX01d As String
        Dim txtEX01e As String : Dim txtEX01f As String
        Dim txtEX01g As String : Dim txtEX01h As String
        Dim txtEX02a As String : Dim txtEX02b As String
        Dim txtEX02c As String : Dim txtEX02d As String
        Dim txtEX02e As String : Dim txtEX02f As String
        Dim txtEX02g As String : Dim txtEX02h As String
        Dim txtEX03a As String : Dim txtEX03b As String
        Dim txtEX03c As String : Dim txtEX03d As String
        Dim txtEX03e As String : Dim txtEX03f As String
        Dim txtEX03g As String : Dim txtEX03h As String
        Dim txtEX04a As String : Dim txtEX04b As String
        Dim txtEX04c As String : Dim txtEX04d As String
        Dim txtEX04e As String : Dim txtEX04f As String
        Dim txtEX04g As String : Dim txtEX04h As String
        Dim txtEX05a As String : Dim txtEX05b As String
        Dim txtEX05c As String : Dim txtEX05d As String
        Dim txtEX05e As String : Dim txtEX05f As String
        Dim txtEX05g As String : Dim txtEX05h As String
        Dim txtEX06a As String : Dim txtEX06b As String
        Dim txtEX06c As String : Dim txtEX06d As String
        Dim txtEX06e As String : Dim txtEX06f As String
        Dim txtEX06g As String : Dim txtEX06h As String
        Dim txtEX07a As String : Dim txtEX07b As String
        Dim txtEX07c As String : Dim txtEX07d As String
        Dim txtEX07e As String : Dim txtEX07f As String
        Dim txtEX07g As String : Dim txtEX07h As String
        Dim txtEX08a As String : Dim txtEX08b As String
        Dim txtEX08c As String : Dim txtEX08d As String
        Dim txtEX08e As String : Dim txtEX08f As String
        Dim txtEX08g As String : Dim txtEX08h As String
        Dim txtEX09a As String : Dim txtEX09b As String
        Dim txtEX09c As String : Dim txtEX09d As String
        Dim txtEX09e As String : Dim txtEX09f As String
        Dim txtEX09g As String : Dim txtEX09h As String
        Dim txtEX10a As String : Dim txtEX10b As String
        Dim txtEX10c As String : Dim txtEX10d As String
        Dim txtEX10e As String : Dim txtEX10f As String
        Dim txtEX10g As String : Dim txtEX10h As String
        Dim txtEX11a As String : Dim txtEX11b As String
        Dim txtEX11c As String : Dim txtEX11d As String
        Dim txtEX11e As String : Dim txtEX11f As String
        Dim txtEX11g As String : Dim txtEX11h As String
        Dim txtEX12a As String : Dim txtEX12b As String
        Dim txtEX12c As String : Dim txtEX12d As String
        Dim txtEX12e As String : Dim txtEX12f As String
        Dim txtEX12g As String : Dim txtEX12h As String
        Dim txtEX13a As String : Dim txtEX13b As String
        Dim txtEX13c As String : Dim txtEX13d As String
        Dim txtEX13e As String : Dim txtEX13f As String
        Dim txtEX13g As String : Dim txtEX13h As String
        Dim txtEX14a As String : Dim txtEX14b As String
        Dim txtEX14c As String : Dim txtEX14d As String
        Dim txtEX14e As String : Dim txtEX14f As String
        Dim txtEX14g As String : Dim txtEX14h As String
        Dim txtEX15a As String : Dim txtEX15b As String
        Dim txtEX15c As String : Dim txtEX15d As String
        Dim txtEX15e As String : Dim txtEX15f As String
        Dim txtEX15g As String : Dim txtEX15h As String
        Dim txtEX16a As String : Dim txtEX16b As String
        Dim txtEX16c As String : Dim txtEX16d As String
        Dim txtEX16e As String : Dim txtEX16f As String
        Dim txtEX16g As String : Dim txtEX16h As String
        Dim txtEX17a As String : Dim txtEX17b As String
        Dim txtEX17c As String : Dim txtEX17d As String
        Dim txtEX17e As String : Dim txtEX17f As String
        Dim txtEX17g As String : Dim txtEX17h As String
        Dim txtEX18a As String : Dim txtEX18b As String
        Dim txtEX18c As String : Dim txtEX18d As String
        Dim txtEX18e As String : Dim txtEX18f As String
        Dim txtEX18g As String : Dim txtEX18h As String
        Dim txtEX19a As String : Dim txtEX19b As String
        Dim txtEX19c As String : Dim txtEX19d As String
        Dim txtEX19e As String : Dim txtEX19f As String
        Dim txtEX19g As String : Dim txtEX19h As String
        Dim txtEX20a As String : Dim txtEX20b As String
        Dim txtEX20c As String : Dim txtEX20d As String
        Dim txtEX20e As String : Dim txtEX20f As String
        Dim txtEX20g As String : Dim txtEX20h As String
        'casillas de titulo de los otros examenes
        Dim txtOtroEx01 As String : Dim txtOtroEx02 As String
        Dim txtOtroEx03 As String : Dim txtOtroEx04 As String
        Dim txtOtroEx05 As String : Dim txtOtroEx06 As String
        Dim txtOtroEx07 As String : Dim txtOtroEx08 As String
        'texto de los laboratorios de la segunda ficha
        Dim txtEX21a As String : Dim txtEX21b As String
        Dim txtEX21c As String : Dim txtEX21d As String
        Dim txtEX21e As String : Dim txtEX21f As String
        Dim txtEX21g As String : Dim txtEX21h As String
        Dim txtEX21i As String : Dim txtEX21j As String
        Dim txtEX21k As String : Dim txtEX21l As String
        'espacio adicional porsia
        Dim Adicional01 As String : Dim Adicional02 As String
        Dim Adicional03 As String : Dim Adicional04 As String

    End Structure

    Dim R As New EstructuraDatosGinecologicos()

    'en esta array list guardamos el contenido del archivo para su manipulacion y posteriormente lo usamos para escribir el
    'contenido de nuevo al archivo
    Dim SerieControles As New ArrayList()

    'variable para la lista ordenada de fechas
    Dim ArraydeFechasOrdenadas As New ArrayList()

    'esta variable guarda el nombre de la historia #his.his actualmente usada
    Dim NombreHistoria As String

    'esta guarda el nombredel control ginecologico actual
    Dim NombreControlGinecologico As String

    'aca el nombre del archivo de los datos personales
    Dim NombreDatosPersonales As String

    'se hace una copia de la estructura para hacer mas comodo el acceso a los datos peronales
    Structure xDatosPersonales
        Dim Nombre As String
        Dim FechaNacimiento As String
        Dim Edad As String
        Dim Cedula As String
        Dim Profesion As String
        Dim Telefono As String
        Dim AntecedentesFamiliares As String
        Dim AntecedentesPersonales As String
        Dim AntecedentesGinecologicos As String
        Dim AntecedentesObstetricos As String
        Dim AntecedentesQuirurgicos As String
    End Structure

    Dim DatosModificados As Boolean = False

    'NuevaSerie es una variable para saber cuando se esta creando un control para una serie de controles nueva
    Dim NuevaSerie As Boolean = False

    Dim FechaInicioControl As Date
    Dim ControlSeleccionado As String
    Dim Patologia As String

    'variables del calculo del dia del ciclo
    Dim FechaParaVerificar As Date
    Dim FechaFURparaCalculo As Date
    Dim DiaDelCiclo As String


    'variables de los graficos de botones
    Dim BotonOn, BotonOff As Image
    Dim BotonOnGrande, BotonOffGrande As Image
    Dim BarraSinMensaje As Image
    Dim FlechaIzqOff, FlechaIzqOn As Image
    Dim FlechaDerOff, FlechaDerOn As Image

    'variables de cadenas del informe
    Dim CadenaTratada As String
    Dim LargoDeseado As Integer
    Dim LargoCadena As Integer

    'variables para el examen fisico de las diferentes fichas y general
    Dim EF(10) As String
    Dim EFcompleto As String

    'variables para el intercambio de texto local de procedure
    Dim TextoEnVentana As String
    Dim TituloEnVentana As String


    'variables para la impresion (la mayoria en el procedimiento)
    Dim HojaconMembrete As Boolean
    Dim LineasPorPagina As Integer
    Dim NumerodePaginas As Integer
    Dim IniciodeRecipeX, IniciodeRecipeY As Integer
    Dim FindeRecipeX, FindeRecipeY As Integer
    Dim AnchodeRecipe, AltodeRecipe As Integer
    Dim LineaImpresa(1000) As String
    Dim altoenPixels As Integer

    Private Sub FormControlGinecologico2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConstruyeNombresArchivos()   'Contruye los nombre q se usaran en los FS
        InicializaDatos()            'carga los datos predeterminados de la ventana de edicion
        MuestraDatosPersonales()     'este si debe haber a juro, lo muestra...
        CargaControlGinecologico() 'si acaso lo hay
        DatosModificados = False
        NuevaSerie = False
    End Sub

    Private Sub ConstruyeNombresArchivos()
        'construye el nombre de la historia actual
        NombreHistoria = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & ".his"
        'construye el nombre del control ginecologico acual
        NombreControlGinecologico = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Control Ginecológico.dat"
        'contruye el nombre del archivo con los datos personales
        NombreDatosPersonales = Form1.PSstrPathHistoriasConPrefijo & "\" & Form1.PSstrNumeroHistoriaSeleccionada & "-Datos Personales.dat"

        'le pone nombre al titulo
        Me.Text = "Control Ginecológico de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"

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

    Private Sub InicializaDatos()
        BorraTextBoxes()
        BorraEstructura()
        BlanqueaTabSucesivos()
        botSelecciona.Enabled = False
        botElimina.Enabled = False
        botRenombraSerie.Enabled = False
        botNuevo.Enabled = True
        botGuardarNuevosDatos.Enabled = False
        botSalirSinGuardar.Enabled = True
        TabControl3.Visible = False
    End Sub

    Private Sub BorraTextBoxes()
        txt01a.Text = "" : txt01b.Text = "" : txt01c.Text = ""
        txt01d.Text = "" : txt01e.Text = "" : txt01f.Text = ""
        txt01g.Text = "" : txt01h.Text = " "

        txt02a.Text = "" : txt02b.Text = "" : txt02c.Text = ""
        txt02d.Text = "" : txt02e.Text = "" : txt02f.Text = ""
        txt02g.Text = ""

        txt03a.Text = "" : txt03b.Text = "" : txt03c.Text = ""
        txt03d.Text = "" : txt03e.Text = "" : txt03f.Text = ""
        txt03g.Text = ""

        txt04a.Text = "" : txt04b.Text = "" : txt04c.Text = ""
        txt04d.Text = "" : txt04e.Text = "" : txt04f.Text = ""
        txt04g.Text = ""

        txt05a.Text = "" : txt05b.Text = "" : txt05c.Text = ""
        txt05d.Text = "" : txt05e.Text = "" : txt05f.Text = ""
        txt05g.Text = ""
        txt06a.Text = "" : txt06b.Text = "" : txt06c.Text = ""
        txt06d.Text = "" : txt06e.Text = "" : txt06f.Text = ""
        txt06g.Text = ""

        txt07a.Text = "" : txt07b.Text = "" : txt07c.Text = ""
        txt07d.Text = "" : txt07e.Text = "" : txt07f.Text = ""
        txt07g.Text = ""

        txt08a.Text = "" : txt08b.Text = "" : txt08c.Text = ""
        txt08d.Text = "" : txt08e.Text = "" : txt08f.Text = ""
        txt08g.Text = ""

        txt09a.Text = "" : txt09b.Text = "" : txt09c.Text = ""
        txt09d.Text = "" : txt09e.Text = "" : txt09f.Text = ""
        txt09g.Text = ""

        txt10a.Text = "" : txt10b.Text = "" : txt10c.Text = ""
        txt10d.Text = "" : txt10e.Text = "" : txt10f.Text = ""
        txt10g.Text = ""

        'inicializa las variables del chorizo de EF
        Dim tt As Integer
        EFcompleto = ""
        For tt = 0 To 9
            EF(tt) = " "
            EFcompleto += EF(tt) & "@"
        Next
        EF(10) = " "
        EFcompleto += EF(10)


        txtFechaLabA.Text = "" : txtFechaLabB.Text = ""
        txtFechaLabC.Text = "" : txtFechaLabD.Text = ""
        txtFechaLabE.Text = "" : txtFechaLabF.Text = ""
        txtFechaLabG.Text = "" : txtFechaLabH.Text = ""



        txtEX01a.Text = "" : txtEX01b.Text = "" : txtEX01c.Text = ""
        txtEX01d.Text = "" : txtEX01e.Text = "" : txtEX01f.Text = ""
        txtEX01g.Text = "" : txtEX01h.Text = ""
        txtEX02a.Text = "" : txtEX02b.Text = "" : txtEX02c.Text = ""
        txtEX02d.Text = "" : txtEX02e.Text = "" : txtEX02f.Text = ""
        txtEX02g.Text = "" : txtEX02h.Text = ""
        txtEX03a.Text = "" : txtEX03b.Text = "" : txtEX03c.Text = ""
        txtEX03d.Text = "" : txtEX03e.Text = "" : txtEX03f.Text = ""
        txtEX03g.Text = "" : txtEX03h.Text = ""
        txtEX04a.Text = "" : txtEX04b.Text = "" : txtEX04c.Text = ""
        txtEX04d.Text = "" : txtEX04e.Text = "" : txtEX04f.Text = ""
        txtEX04g.Text = "" : txtEX04h.Text = ""
        txtEX05a.Text = "" : txtEX05b.Text = "" : txtEX05c.Text = ""
        txtEX05d.Text = "" : txtEX05e.Text = "" : txtEX05f.Text = ""
        txtEX05g.Text = "" : txtEX05h.Text = ""
        txtEX06a.Text = "" : txtEX06b.Text = "" : txtEX06c.Text = ""
        txtEX06d.Text = "" : txtEX06e.Text = "" : txtEX06f.Text = ""
        txtEX06g.Text = "" : txtEX06h.Text = ""
        txtEX07a.Text = "" : txtEX07b.Text = "" : txtEX07c.Text = ""
        txtEX07d.Text = "" : txtEX07e.Text = "" : txtEX07f.Text = ""
        txtEX07g.Text = "" : txtEX07h.Text = ""
        txtEX08a.Text = "" : txtEX08b.Text = "" : txtEX08c.Text = ""
        txtEX08d.Text = "" : txtEX08e.Text = "" : txtEX08f.Text = ""
        txtEX08g.Text = "" : txtEX08h.Text = ""
        txtEX09a.Text = "" : txtEX09b.Text = "" : txtEX09c.Text = ""
        txtEX09d.Text = "" : txtEX09e.Text = "" : txtEX09f.Text = ""
        txtEX09g.Text = "" : txtEX09h.Text = ""
        txtEX10a.Text = "" : txtEX10b.Text = "" : txtEX10c.Text = ""
        txtEX10d.Text = "" : txtEX10e.Text = "" : txtEX10f.Text = ""
        txtEX10g.Text = "" : txtEX10h.Text = ""
        txtEX11a.Text = "" : txtEX11b.Text = "" : txtEX11c.Text = ""
        txtEX11d.Text = "" : txtEX11e.Text = "" : txtEX11f.Text = ""
        txtEX11g.Text = "" : txtEX11h.Text = ""
        txtEX12a.Text = "" : txtEX12b.Text = "" : txtEX12c.Text = ""
        txtEX12d.Text = "" : txtEX12e.Text = "" : txtEX12f.Text = ""
        txtEX12g.Text = "" : txtEX12h.Text = ""
        txtEX13a.Text = "" : txtEX13b.Text = "" : txtEX13c.Text = ""
        txtEX13d.Text = "" : txtEX13e.Text = "" : txtEX13f.Text = ""
        txtEX13g.Text = "" : txtEX13h.Text = ""
        txtEX14a.Text = "" : txtEX14b.Text = "" : txtEX14c.Text = ""
        txtEX14d.Text = "" : txtEX14e.Text = "" : txtEX14f.Text = ""
        txtEX14g.Text = "" : txtEX14h.Text = ""
        txtEX15a.Text = "" : txtEX15b.Text = "" : txtEX15c.Text = ""
        txtEX15d.Text = "" : txtEX15e.Text = "" : txtEX15f.Text = ""
        txtEX15g.Text = "" : txtEX15h.Text = ""
        txtEX16a.Text = "" : txtEX16b.Text = "" : txtEX16c.Text = ""
        txtEX16d.Text = "" : txtEX16e.Text = "" : txtEX16f.Text = ""
        txtEX16g.Text = "" : txtEX16h.Text = ""
        txtEX17a.Text = "" : txtEX17b.Text = "" : txtEX17c.Text = ""
        txtEX17d.Text = "" : txtEX17e.Text = "" : txtEX17f.Text = ""
        txtEX17g.Text = "" : txtEX17h.Text = ""
        txtEX18a.Text = "" : txtEX18b.Text = "" : txtEX18c.Text = ""
        txtEX18d.Text = "" : txtEX18e.Text = "" : txtEX18f.Text = ""
        txtEX18g.Text = "" : txtEX18h.Text = ""
        txtEX19a.Text = "" : txtEX19b.Text = "" : txtEX19c.Text = ""
        txtEX19d.Text = "" : txtEX19e.Text = "" : txtEX19f.Text = ""
        txtEX19g.Text = "" : txtEX19h.Text = ""
        txtEX20a.Text = "" : txtEX20b.Text = "" : txtEX20c.Text = ""
        txtEX20d.Text = "" : txtEX20e.Text = "" : txtEX20f.Text = ""
        txtEX20g.Text = "" : txtEX20h.Text = ""

        txtOtroEx01.Text = "Otro" : txtOtroEx02.Text = "Otro"
        txtOtroEx03.Text = "Otro" : txtOtroEx04.Text = "Otro"
        txtOtroEx05.Text = "Otro" : txtOtroEx06.Text = "Otro"
        txtOtroEx07.Text = "Otro" : txtOtroEx08.Text = "Otro"
        txtOtroEx09.Text = "Otro"

        txtEX21a.Text = "" : txtEX21b.Text = "" : txtEX21c.Text = ""
        txtEX21d.Text = "" : txtEX21e.Text = "" : txtEX21f.Text = ""
        txtEX21g.Text = "" : txtEX21h.Text = "" : txtEX21i.Text = ""
        txtEX21j.Text = "" : txtEX21k.Text = "" : txtEX21l.Text = ""

    End Sub
    Private Sub BorraEstructura()
        R.FechaInicioControl = ""
        R.PatologiaControl = ""

        R.txt01a = "" : R.txt01b = "" : R.txt01c = ""
        R.txt01d = "" : R.txt01e = "" : R.txt01f = ""
        R.txt01g = "" : R.txt01h = ""

        R.txt02a = "" : R.txt02b = "" : R.txt02c = ""
        R.txt02d = "" : R.txt02e = "" : R.txt02f = ""
        R.txt02g = ""

        R.txt03a = "" : R.txt03b = "" : R.txt03c = ""
        R.txt03d = "" : R.txt03e = "" : R.txt03f = ""
        R.txt03g = ""

        R.txt04a = "" : R.txt04b = "" : R.txt04c = ""
        R.txt04d = "" : R.txt04e = "" : R.txt04f = ""
        R.txt04g = ""

        R.txt05a = "" : R.txt05b = "" : R.txt05c = ""
        R.txt05d = "" : R.txt05e = "" : R.txt05f = ""
        R.txt05g = ""

        R.txt06a = "" : R.txt06b = "" : R.txt06c = ""
        R.txt06d = "" : R.txt06e = "" : R.txt06f = ""
        R.txt06g = ""

        R.txt07a = "" : R.txt07b = "" : R.txt07c = ""
        R.txt07d = "" : R.txt07e = "" : R.txt07f = ""
        R.txt07g = ""

        R.txt08a = "" : R.txt08b = "" : R.txt08c = ""
        R.txt08d = "" : R.txt08e = "" : R.txt08f = ""
        R.txt08g = ""

        R.txt09a = "" : R.txt09b = "" : R.txt09c = ""
        R.txt09d = "" : R.txt09e = "" : R.txt09f = ""
        R.txt09g = ""

        R.txt10a = "" : R.txt10b = "" : R.txt10c = ""
        R.txt10d = "" : R.txt10e = "" : R.txt10f = ""
        R.txt10g = ""

        R.txtFechaLabA = "" : R.txtFechaLabB = ""
        R.txtFechaLabC = "" : R.txtFechaLabD = ""
        R.txtFechaLabE = "" : R.txtFechaLabF = ""
        R.txtFechaLabG = "" : R.txtFechaLabH = ""

        R.txtEX01a = "" : R.txtEX01b = "" : R.txtEX01c = ""
        R.txtEX01d = "" : R.txtEX01e = "" : R.txtEX01f = ""
        R.txtEX01g = "" : R.txtEX01h = ""
        R.txtEX02a = "" : R.txtEX02b = "" : R.txtEX02c = ""
        R.txtEX02d = "" : R.txtEX02e = "" : R.txtEX02f = ""
        R.txtEX02g = "" : R.txtEX02h = ""
        R.txtEX03a = "" : R.txtEX03b = "" : R.txtEX03c = ""
        R.txtEX03d = "" : R.txtEX03e = "" : R.txtEX03f = ""
        R.txtEX03g = "" : R.txtEX03h = ""
        R.txtEX04a = "" : R.txtEX04b = "" : R.txtEX04c = ""
        R.txtEX04d = "" : R.txtEX04e = "" : R.txtEX04f = ""
        R.txtEX04g = "" : R.txtEX04h = ""
        R.txtEX05a = "" : R.txtEX05b = "" : R.txtEX05c = ""
        R.txtEX05d = "" : R.txtEX05e = "" : R.txtEX05f = ""
        R.txtEX05g = "" : R.txtEX05h = ""
        R.txtEX06a = "" : R.txtEX06b = "" : R.txtEX06c = ""
        R.txtEX06d = "" : R.txtEX06e = "" : R.txtEX06f = ""
        R.txtEX06g = "" : R.txtEX06h = ""
        R.txtEX07a = "" : R.txtEX07b = "" : R.txtEX07c = ""
        R.txtEX07d = "" : R.txtEX07e = "" : R.txtEX07f = ""
        R.txtEX07g = "" : R.txtEX07h = ""
        R.txtEX08a = "" : R.txtEX08b = "" : R.txtEX08c = ""
        R.txtEX08d = "" : R.txtEX08e = "" : R.txtEX08f = ""
        R.txtEX08g = "" : R.txtEX08h = ""
        R.txtEX09a = "" : R.txtEX09b = "" : R.txtEX09c = ""
        R.txtEX09d = "" : R.txtEX09e = "" : R.txtEX09f = ""
        R.txtEX09g = "" : R.txtEX09h = ""
        R.txtEX10a = "" : R.txtEX10b = "" : R.txtEX10c = ""
        R.txtEX10d = "" : R.txtEX10e = "" : R.txtEX10f = ""
        R.txtEX10g = "" : R.txtEX10h = ""
        R.txtEX11a = "" : R.txtEX11b = "" : R.txtEX11c = ""
        R.txtEX11d = "" : R.txtEX11e = "" : R.txtEX11f = ""
        R.txtEX11g = "" : R.txtEX11h = ""
        R.txtEX12a = "" : R.txtEX12b = "" : R.txtEX12c = ""
        R.txtEX12d = "" : R.txtEX12e = "" : R.txtEX12f = ""
        R.txtEX12g = "" : R.txtEX12h = ""
        R.txtEX13a = "" : R.txtEX13b = "" : R.txtEX13c = ""
        R.txtEX13d = "" : R.txtEX13e = "" : R.txtEX13f = ""
        R.txtEX13g = "" : R.txtEX13h = ""
        R.txtEX14a = "" : R.txtEX14b = "" : R.txtEX14c = ""
        R.txtEX14d = "" : R.txtEX14e = "" : R.txtEX14f = ""
        R.txtEX14g = "" : R.txtEX14h = ""
        R.txtEX15a = "" : R.txtEX15b = "" : R.txtEX15c = ""
        R.txtEX15d = "" : R.txtEX15e = "" : R.txtEX15f = ""
        R.txtEX15g = "" : R.txtEX15h = ""
        R.txtEX16a = "" : R.txtEX16b = "" : R.txtEX16c = ""
        R.txtEX16d = "" : R.txtEX16e = "" : R.txtEX16f = ""
        R.txtEX16g = "" : R.txtEX16h = ""
        R.txtEX17a = "" : R.txtEX17b = "" : R.txtEX17c = ""
        R.txtEX17d = "" : R.txtEX17e = "" : R.txtEX17f = ""
        R.txtEX17g = "" : R.txtEX17h = ""
        R.txtEX18a = "" : R.txtEX18b = "" : R.txtEX18c = ""
        R.txtEX18d = "" : R.txtEX18e = "" : R.txtEX18f = ""
        R.txtEX18g = "" : R.txtEX18h = ""
        R.txtEX19a = "" : R.txtEX19b = "" : R.txtEX19c = ""
        R.txtEX19d = "" : R.txtEX19e = "" : R.txtEX19f = ""
        R.txtEX19g = "" : R.txtEX19h = ""
        R.txtEX20a = "" : R.txtEX20b = "" : R.txtEX20c = ""
        R.txtEX20d = "" : R.txtEX20e = "" : R.txtEX20f = ""
        R.txtEX20g = "" : R.txtEX20h = ""

        R.txtOtroEx01 = "Otro" : R.txtOtroEx02 = "Otro"
        R.txtOtroEx03 = "Otro" : R.txtOtroEx04 = "Otro"
        R.txtOtroEx05 = "Otro" : R.txtOtroEx06 = "Otro"
        R.txtOtroEx07 = "Otro" : R.txtOtroEx08 = "Otro"

        R.txtEX21a = "" : R.txtEX21b = "" : R.txtEX21c = ""
        R.txtEX21d = "" : R.txtEX21e = "" : R.txtEX21f = ""
        R.txtEX21g = "" : R.txtEX21h = "" : R.txtEX21i = ""
        R.txtEX21j = "" : R.txtEX21k = "" : R.txtEX21l = ""

        R.Adicional01 = " @ @ @ @ @ @ @ @ @ @ "
        R.Adicional02 = "Otro" 'ojo es el examen otro ultimo
        R.Adicional03 = ""
        R.Adicional04 = ""

    End Sub

    Private Sub BlanqueaTabSucesivos()
        labTab02.BackColor = Color.LightGray
        labTab03.BackColor = Color.LightGray
        labTab04.BackColor = Color.LightGray
        labTab05.BackColor = Color.LightGray
        labTab06.BackColor = Color.LightGray
        labTab07.BackColor = Color.LightGray
        labTab08.BackColor = Color.LightGray
        labTab09.BackColor = Color.LightGray
        labTab10.BackColor = Color.LightGray
    End Sub

    Private Sub BorraDiasDeCiclo()
        txtDC01.Text = ""
        txtDC02.Text = ""
        txtDC03.Text = ""
        txtDC04.Text = ""
        txtDC05.Text = ""
        txtDC06.Text = ""
        txtDC07.Text = ""
        txtDC08.Text = ""
        txtDC09.Text = ""
        txtDC10.Text = ""
    End Sub

    Private Sub ActualizaEstructura01ConElTexto()
        R.txt01a = txt01a.Text : R.txt01b = txt01b.Text
        R.txt01c = txt01c.Text : R.txt01d = txt01d.Text
        R.txt01e = txt01e.Text : R.txt01f = txt01f.Text
        R.txt01g = txt01g.Text : R.txt01h = txt01h.Text
    End Sub
    Private Sub ActualizaEstructura02ConElTexto()
        R.txt02a = txt02a.Text : R.txt02b = txt02b.Text
        R.txt02c = txt02c.Text : R.txt02d = txt02d.Text
        R.txt02e = txt02e.Text : R.txt02f = txt02f.Text
        R.txt02g = txt02g.Text
    End Sub
    Private Sub ActualizaEstructura03ConElTexto()
        R.txt03a = txt03a.Text : R.txt03b = txt03b.Text
        R.txt03c = txt03c.Text : R.txt03d = txt03d.Text
        R.txt03e = txt03e.Text : R.txt03f = txt03f.Text
        R.txt03g = txt03g.Text
    End Sub
    Private Sub ActualizaEstructura04ConElTexto()
        R.txt04a = txt04a.Text : R.txt04b = txt04b.Text
        R.txt04c = txt04c.Text : R.txt04d = txt04d.Text
        R.txt04e = txt04e.Text : R.txt04f = txt04f.Text
        R.txt04g = txt04g.Text
    End Sub
    Private Sub ActualizaEstructura05ConElTexto()
        R.txt05a = txt05a.Text : R.txt05b = txt05b.Text
        R.txt05c = txt05c.Text : R.txt05d = txt05d.Text
        R.txt05e = txt05e.Text : R.txt05f = txt05f.Text
        R.txt05g = txt05g.Text
    End Sub
    Private Sub ActualizaEstructura06ConElTexto()
        R.txt06a = txt06a.Text : R.txt06b = txt06b.Text
        R.txt06c = txt06c.Text : R.txt06d = txt06d.Text
        R.txt06e = txt06e.Text : R.txt06f = txt06f.Text
        R.txt06g = txt06g.Text
    End Sub
    Private Sub ActualizaEstructura07ConElTexto()
        R.txt07a = txt07a.Text : R.txt07b = txt07b.Text
        R.txt07c = txt07c.Text : R.txt07d = txt07d.Text
        R.txt07e = txt07e.Text : R.txt07f = txt07f.Text
        R.txt07g = txt07g.Text
    End Sub
    Private Sub ActualizaEstructura08ConElTexto()
        R.txt08a = txt08a.Text : R.txt08b = txt08b.Text
        R.txt08c = txt08c.Text : R.txt08d = txt08d.Text
        R.txt08e = txt08e.Text : R.txt08f = txt08f.Text
        R.txt08g = txt08g.Text
    End Sub
    Private Sub ActualizaEstructura09ConElTexto()
        R.txt09a = txt09a.Text : R.txt09b = txt09b.Text
        R.txt09c = txt09c.Text : R.txt09d = txt09d.Text
        R.txt09e = txt09e.Text : R.txt09f = txt09f.Text
        R.txt09g = txt09g.Text
    End Sub
    Private Sub ActualizaEstructura10ConElTexto()
        R.txt10a = txt10a.Text : R.txt10b = txt10b.Text
        R.txt10c = txt10c.Text : R.txt10d = txt10d.Text
        R.txt10e = txt10e.Text : R.txt10f = txt10f.Text
        R.txt10g = txt10g.Text
    End Sub

    Private Sub ActualizaEstructurafechalabConElTexto()
        R.txtFechaLabA = txtFechaLabA.Text : R.txtFechaLabB = txtFechaLabB.Text
        R.txtFechaLabC = txtFechaLabC.Text : R.txtFechaLabD = txtFechaLabD.Text
        R.txtFechaLabE = txtFechaLabE.Text : R.txtFechaLabF = txtFechaLabF.Text
        R.txtFechaLabG = txtFechaLabG.Text : R.txtFechaLabH = txtFechaLabH.Text
    End Sub

    Private Sub ActualizaEstructuraEX01ConElTexto()
        R.txtEX01a = txtEX01a.Text : R.txtEX01b = txtEX01b.Text
        R.txtEX01c = txtEX01c.Text : R.txtEX01d = txtEX01d.Text
        R.txtEX01e = txtEX01e.Text : R.txtEX01f = txtEX01f.Text
        R.txtEX01g = txtEX01g.Text : R.txtEX01h = txtEX01h.Text
    End Sub
    Private Sub ActualizaEstructuraEX02ConElTexto()
        R.txtEX02a = txtEX02a.Text : R.txtEX02b = txtEX02b.Text
        R.txtEX02c = txtEX02c.Text : R.txtEX02d = txtEX02d.Text
        R.txtEX02e = txtEX02e.Text : R.txtEX02f = txtEX02f.Text
        R.txtEX02g = txtEX02g.Text : R.txtEX02h = txtEX02h.Text
    End Sub
    Private Sub ActualizaEstructuraEX03ConElTexto()
        R.txtEX03a = txtEX03a.Text : R.txtEX03b = txtEX03b.Text
        R.txtEX03c = txtEX03c.Text : R.txtEX03d = txtEX03d.Text
        R.txtEX03e = txtEX03e.Text : R.txtEX03f = txtEX03f.Text
        R.txtEX03g = txtEX03g.Text : R.txtEX03h = txtEX03h.Text
    End Sub
    Private Sub ActualizaEstructuraEX04ConElTexto()
        R.txtEX04a = txtEX04a.Text : R.txtEX04b = txtEX04b.Text
        R.txtEX04c = txtEX04c.Text : R.txtEX04d = txtEX04d.Text
        R.txtEX04e = txtEX04e.Text : R.txtEX04f = txtEX04f.Text
        R.txtEX04g = txtEX04g.Text : R.txtEX04h = txtEX04h.Text
    End Sub
    Private Sub ActualizaEstructuraEX05ConElTexto()
        R.txtEX05a = txtEX05a.Text : R.txtEX05b = txtEX05b.Text
        R.txtEX05c = txtEX05c.Text : R.txtEX05d = txtEX05d.Text
        R.txtEX05e = txtEX05e.Text : R.txtEX05f = txtEX05f.Text
        R.txtEX05g = txtEX05g.Text : R.txtEX05h = txtEX05h.Text
    End Sub
    Private Sub ActualizaEstructuraEX06ConElTexto()
        R.txtEX06a = txtEX06a.Text : R.txtEX06b = txtEX06b.Text
        R.txtEX06c = txtEX06c.Text : R.txtEX06d = txtEX06d.Text
        R.txtEX06e = txtEX06e.Text : R.txtEX06f = txtEX06f.Text
        R.txtEX06g = txtEX06g.Text : R.txtEX06h = txtEX06h.Text
    End Sub
    Private Sub ActualizaEstructuraEX07ConElTexto()
        R.txtEX07a = txtEX07a.Text : R.txtEX07b = txtEX07b.Text
        R.txtEX07c = txtEX07c.Text : R.txtEX07d = txtEX07d.Text
        R.txtEX07e = txtEX07e.Text : R.txtEX07f = txtEX07f.Text
        R.txtEX07g = txtEX07g.Text : R.txtEX07h = txtEX07h.Text
    End Sub
    Private Sub ActualizaEstructuraEX08ConElTexto()
        R.txtEX08a = txtEX08a.Text : R.txtEX08b = txtEX08b.Text
        R.txtEX08c = txtEX08c.Text : R.txtEX08d = txtEX08d.Text
        R.txtEX08e = txtEX08e.Text : R.txtEX08f = txtEX08f.Text
        R.txtEX08g = txtEX08g.Text : R.txtEX08h = txtEX08h.Text
    End Sub
    Private Sub ActualizaEstructuraEX09ConElTexto()
        R.txtEX09a = txtEX09a.Text : R.txtEX09b = txtEX09b.Text
        R.txtEX09c = txtEX09c.Text : R.txtEX09d = txtEX09d.Text
        R.txtEX09e = txtEX09e.Text : R.txtEX09f = txtEX09f.Text
        R.txtEX09g = txtEX09g.Text : R.txtEX09h = txtEX09h.Text
    End Sub
    Private Sub ActualizaEstructuraEX10ConElTexto()
        R.txtEX10a = txtEX10a.Text : R.txtEX10b = txtEX10b.Text
        R.txtEX10c = txtEX10c.Text : R.txtEX10d = txtEX10d.Text
        R.txtEX10e = txtEX10e.Text : R.txtEX10f = txtEX10f.Text
        R.txtEX10g = txtEX10g.Text : R.txtEX10h = txtEX10h.Text
    End Sub
    Private Sub ActualizaEstructuraEX11ConElTexto()
        R.txtEX11a = txtEX11a.Text : R.txtEX11b = txtEX11b.Text
        R.txtEX11c = txtEX11c.Text : R.txtEX11d = txtEX11d.Text
        R.txtEX11e = txtEX11e.Text : R.txtEX11f = txtEX11f.Text
        R.txtEX11g = txtEX11g.Text : R.txtEX11h = txtEX11h.Text
    End Sub
    Private Sub ActualizaEstructuraEX12ConElTexto()
        R.txtEX12a = txtEX12a.Text : R.txtEX12b = txtEX12b.Text
        R.txtEX12c = txtEX12c.Text : R.txtEX12d = txtEX12d.Text
        R.txtEX12e = txtEX12e.Text : R.txtEX12f = txtEX12f.Text
        R.txtEX12g = txtEX12g.Text : R.txtEX12h = txtEX12h.Text
    End Sub
    Private Sub ActualizaEstructuraEX13ConElTexto()
        R.txtEX13a = txtEX13a.Text : R.txtEX13b = txtEX13b.Text
        R.txtEX13c = txtEX13c.Text : R.txtEX13d = txtEX13d.Text
        R.txtEX13e = txtEX13e.Text : R.txtEX13f = txtEX13f.Text
        R.txtEX13g = txtEX13g.Text : R.txtEX13h = txtEX13h.Text
    End Sub
    Private Sub ActualizaEstructuraEX14ConElTexto()
        R.txtEX14a = txtEX14a.Text : R.txtEX14b = txtEX14b.Text
        R.txtEX14c = txtEX14c.Text : R.txtEX14d = txtEX14d.Text
        R.txtEX14e = txtEX14e.Text : R.txtEX14f = txtEX14f.Text
        R.txtEX14g = txtEX14g.Text : R.txtEX14h = txtEX14h.Text
    End Sub
    Private Sub ActualizaEstructuraEX15ConElTexto()
        R.txtEX15a = txtEX15a.Text : R.txtEX15b = txtEX15b.Text
        R.txtEX15c = txtEX15c.Text : R.txtEX15d = txtEX15d.Text
        R.txtEX15e = txtEX15e.Text : R.txtEX15f = txtEX15f.Text
        R.txtEX15g = txtEX15g.Text : R.txtEX15h = txtEX15h.Text
    End Sub
    Private Sub ActualizaEstructuraEX16ConElTexto()
        R.txtEX16a = txtEX16a.Text : R.txtEX16b = txtEX16b.Text
        R.txtEX16c = txtEX16c.Text : R.txtEX16d = txtEX16d.Text
        R.txtEX16e = txtEX16e.Text : R.txtEX16f = txtEX16f.Text
        R.txtEX16g = txtEX16g.Text : R.txtEX16h = txtEX16h.Text
    End Sub
    Private Sub ActualizaEstructuraEX17ConElTexto()
        R.txtEX17a = txtEX17a.Text : R.txtEX17b = txtEX17b.Text
        R.txtEX17c = txtEX17c.Text : R.txtEX17d = txtEX17d.Text
        R.txtEX17e = txtEX17e.Text : R.txtEX17f = txtEX17f.Text
        R.txtEX17g = txtEX17g.Text : R.txtEX17h = txtEX17h.Text
    End Sub
    Private Sub ActualizaEstructuraEX18ConElTexto()
        R.txtEX18a = txtEX18a.Text : R.txtEX18b = txtEX18b.Text
        R.txtEX18c = txtEX18c.Text : R.txtEX18d = txtEX18d.Text
        R.txtEX18e = txtEX18e.Text : R.txtEX18f = txtEX18f.Text
        R.txtEX18g = txtEX18g.Text : R.txtEX18h = txtEX18h.Text
    End Sub
    Private Sub ActualizaEstructuraEX19ConElTexto()
        R.txtEX19a = txtEX19a.Text : R.txtEX19b = txtEX19b.Text
        R.txtEX19c = txtEX19c.Text : R.txtEX19d = txtEX19d.Text
        R.txtEX19e = txtEX19e.Text : R.txtEX19f = txtEX19f.Text
        R.txtEX19g = txtEX19g.Text : R.txtEX19h = txtEX19h.Text
    End Sub
    Private Sub ActualizaEstructuraEX20ConElTexto()
        R.txtEX20a = txtEX20a.Text : R.txtEX20b = txtEX20b.Text
        R.txtEX20c = txtEX20c.Text : R.txtEX20d = txtEX20d.Text
        R.txtEX20e = txtEX20e.Text : R.txtEX20f = txtEX20f.Text
        R.txtEX20g = txtEX20g.Text : R.txtEX20h = txtEX20h.Text
    End Sub

    Private Sub ActualizaEstructuraOTROSEXConElTexto()
        R.txtOtroEx01 = txtOtroEx01.Text : R.txtOtroEx02 = txtOtroEx02.Text
        R.txtOtroEx03 = txtOtroEx03.Text : R.txtOtroEx04 = txtOtroEx04.Text
        R.txtOtroEx05 = txtOtroEx05.Text : R.txtOtroEx06 = txtOtroEx06.Text
        R.txtOtroEx07 = txtOtroEx07.Text : R.txtOtroEx08 = txtOtroEx08.Text
        R.Adicional02 = txtOtroEx09.Text
    End Sub

    Private Sub ActualizaEstructuraEX21ConElTexto()
        R.txtEX21a = txtEX21a.Text : R.txtEX21b = txtEX21b.Text
        R.txtEX21c = txtEX21c.Text : R.txtEX21d = txtEX21d.Text
        R.txtEX21e = txtEX21e.Text : R.txtEX21f = txtEX21f.Text
        R.txtEX21g = txtEX21g.Text : R.txtEX21h = txtEX21h.Text
        R.txtEX21i = txtEX21i.Text : R.txtEX21j = txtEX21j.Text
        R.txtEX21k = txtEX21k.Text : R.txtEX21l = txtEX21l.Text
    End Sub

    Private Sub ActualizaEstructuraAdicional1conelExFisico()

        Dim tt As Integer
        R.Adicional01 = ""
        For tt = 0 To 9
            R.Adicional01 += EF(tt) & "@"
        Next
        R.Adicional01 += EF(10)
    End Sub

    Private Sub ActualizaTextoConLaEstructura()
        'la fecha inicial de control no esta actualizandose 
        'aqui porque lo hace en el procedimiento que llama
        txt01a.Text = R.txt01a : txt01b.Text = R.txt01b
        txt01c.Text = R.txt01c : txt01d.Text = R.txt01d
        txt01e.Text = R.txt01e : txt01f.Text = R.txt01f
        txt01g.Text = R.txt01g : txt01h.Text = R.txt01h

        txt02a.Text = R.txt02a : txt02b.Text = R.txt02b
        txt02c.Text = R.txt02c : txt02d.Text = R.txt02d
        txt02e.Text = R.txt02e : txt02f.Text = R.txt02f
        txt02g.Text = R.txt02g
        If txt02a.Text <> "" Then
            labTab02.BackColor = Color.Gold
        End If

        txt03a.Text = R.txt03a : txt03b.Text = R.txt03b
        txt03c.Text = R.txt03c : txt03d.Text = R.txt03d
        txt03e.Text = R.txt03e : txt03f.Text = R.txt03f
        txt03g.Text = R.txt03g
        If txt03a.Text <> "" Then
            labTab03.BackColor = Color.Gold
        End If

        txt04a.Text = R.txt04a : txt04b.Text = R.txt04b
        txt04c.Text = R.txt04c : txt04d.Text = R.txt04d
        txt04e.Text = R.txt04e : txt04f.Text = R.txt04f
        txt04g.Text = R.txt04g
        If txt04a.Text <> "" Then
            labTab04.BackColor = Color.Gold
        End If

        txt05a.Text = R.txt05a : txt05b.Text = R.txt05b
        txt05c.Text = R.txt05c : txt05d.Text = R.txt05d
        txt05e.Text = R.txt05e : txt05f.Text = R.txt05f
        txt05g.Text = R.txt05g
        If txt05a.Text <> "" Then
            labTab05.BackColor = Color.Gold
        End If

        txt06a.Text = R.txt06a : txt06b.Text = R.txt06b
        txt06c.Text = R.txt06c : txt06d.Text = R.txt06d
        txt06e.Text = R.txt06e : txt06f.Text = R.txt06f
        txt06g.Text = R.txt06g
        If txt06a.Text <> "" Then
            labTab06.BackColor = Color.Gold
        End If

        txt07a.Text = R.txt07a : txt07b.Text = R.txt07b
        txt07c.Text = R.txt07c : txt07d.Text = R.txt07d
        txt07e.Text = R.txt07e : txt07f.Text = R.txt07f
        txt07g.Text = R.txt07g
        If txt07a.Text <> "" Then
            labTab07.BackColor = Color.Gold
        End If

        txt08a.Text = R.txt08a : txt08b.Text = R.txt08b
        txt08c.Text = R.txt08c : txt08d.Text = R.txt08d
        txt08e.Text = R.txt08e : txt08f.Text = R.txt08f
        txt08g.Text = R.txt08g
        If txt08a.Text <> "" Then
            labTab08.BackColor = Color.Gold
        End If

        txt09a.Text = R.txt09a : txt09b.Text = R.txt09b
        txt09c.Text = R.txt09c : txt09d.Text = R.txt09d
        txt09e.Text = R.txt09e : txt09f.Text = R.txt09f
        txt09g.Text = R.txt09g
        If txt09a.Text <> "" Then
            labTab09.BackColor = Color.Gold
        End If

        txt10a.Text = R.txt10a : txt10b.Text = R.txt10b
        txt10c.Text = R.txt10c : txt10d.Text = R.txt10d
        txt10e.Text = R.txt10e : txt10f.Text = R.txt10f
        txt10g.Text = R.txt10g
        If txt10a.Text <> "" Then
            labTab10.BackColor = Color.Gold
        End If

        txtFechaLabA.Text = R.txtFechaLabA : txtFechaLabB.Text = R.txtFechaLabB
        txtFechaLabC.Text = R.txtFechaLabC : txtFechaLabD.Text = R.txtFechaLabD
        txtFechaLabE.Text = R.txtFechaLabE : txtFechaLabF.Text = R.txtFechaLabF
        txtFechaLabG.Text = R.txtFechaLabG : txtFechaLabH.Text = R.txtFechaLabH

        txtEX01a.Text = R.txtEX01a : txtEX01b.Text = R.txtEX01b
        txtEX01c.Text = R.txtEX01c : txtEX01d.Text = R.txtEX01d
        txtEX01e.Text = R.txtEX01e : txtEX01f.Text = R.txtEX01f
        txtEX01g.Text = R.txtEX01g : txtEX01h.Text = R.txtEX01h
        txtEX02a.Text = R.txtEX02a : txtEX02b.Text = R.txtEX02b
        txtEX02c.Text = R.txtEX02c : txtEX02d.Text = R.txtEX02d
        txtEX02e.Text = R.txtEX02e : txtEX02f.Text = R.txtEX02f
        txtEX02g.Text = R.txtEX02g : txtEX02h.Text = R.txtEX02h
        txtEX03a.Text = R.txtEX03a : txtEX03b.Text = R.txtEX03b
        txtEX03c.Text = R.txtEX03c : txtEX03d.Text = R.txtEX03d
        txtEX03e.Text = R.txtEX03e : txtEX03f.Text = R.txtEX03f
        txtEX03g.Text = R.txtEX03g : txtEX03h.Text = R.txtEX03h
        txtEX04a.Text = R.txtEX04a : txtEX04b.Text = R.txtEX04b
        txtEX04c.Text = R.txtEX04c : txtEX04d.Text = R.txtEX04d
        txtEX04e.Text = R.txtEX04e : txtEX04f.Text = R.txtEX04f
        txtEX04g.Text = R.txtEX04g : txtEX04h.Text = R.txtEX04h
        txtEX05a.Text = R.txtEX05a : txtEX05b.Text = R.txtEX05b
        txtEX05c.Text = R.txtEX05c : txtEX05d.Text = R.txtEX05d
        txtEX05e.Text = R.txtEX05e : txtEX05f.Text = R.txtEX05f
        txtEX05g.Text = R.txtEX05g : txtEX05h.Text = R.txtEX05h
        txtEX06a.Text = R.txtEX06a : txtEX06b.Text = R.txtEX06b
        txtEX06c.Text = R.txtEX06c : txtEX06d.Text = R.txtEX06d
        txtEX06e.Text = R.txtEX06e : txtEX06f.Text = R.txtEX06f
        txtEX06g.Text = R.txtEX06g : txtEX06h.Text = R.txtEX06h
        txtEX07a.Text = R.txtEX07a : txtEX07b.Text = R.txtEX07b
        txtEX07c.Text = R.txtEX07c : txtEX07d.Text = R.txtEX07d
        txtEX07e.Text = R.txtEX07e : txtEX07f.Text = R.txtEX07f
        txtEX07g.Text = R.txtEX07g : txtEX07h.Text = R.txtEX07h
        txtEX08a.Text = R.txtEX08a : txtEX08b.Text = R.txtEX08b
        txtEX08c.Text = R.txtEX08c : txtEX08d.Text = R.txtEX08d
        txtEX08e.Text = R.txtEX08e : txtEX08f.Text = R.txtEX08f
        txtEX08g.Text = R.txtEX08g : txtEX08h.Text = R.txtEX08h
        txtEX09a.Text = R.txtEX09a : txtEX09b.Text = R.txtEX09b
        txtEX09c.Text = R.txtEX09c : txtEX09d.Text = R.txtEX09d
        txtEX09e.Text = R.txtEX09e : txtEX09f.Text = R.txtEX09f
        txtEX09g.Text = R.txtEX09g : txtEX09h.Text = R.txtEX09h
        txtEX10a.Text = R.txtEX10a : txtEX10b.Text = R.txtEX10b
        txtEX10c.Text = R.txtEX10c : txtEX10d.Text = R.txtEX10d
        txtEX10e.Text = R.txtEX10e : txtEX10f.Text = R.txtEX10f
        txtEX10g.Text = R.txtEX10g : txtEX10h.Text = R.txtEX10h
        txtEX11a.Text = R.txtEX11a : txtEX11b.Text = R.txtEX11b
        txtEX11c.Text = R.txtEX11c : txtEX11d.Text = R.txtEX11d
        txtEX11e.Text = R.txtEX11e : txtEX11f.Text = R.txtEX11f
        txtEX11g.Text = R.txtEX11g : txtEX11h.Text = R.txtEX11h
        txtEX12a.Text = R.txtEX12a : txtEX12b.Text = R.txtEX12b
        txtEX12c.Text = R.txtEX12c : txtEX12d.Text = R.txtEX12d
        txtEX12e.Text = R.txtEX12e : txtEX12f.Text = R.txtEX12f
        txtEX12g.Text = R.txtEX12g : txtEX12h.Text = R.txtEX12h
        txtEX13a.Text = R.txtEX13a : txtEX13b.Text = R.txtEX13b
        txtEX13c.Text = R.txtEX13c : txtEX13d.Text = R.txtEX13d
        txtEX13e.Text = R.txtEX13e : txtEX13f.Text = R.txtEX13f
        txtEX13g.Text = R.txtEX13g : txtEX13h.Text = R.txtEX13h
        txtEX14a.Text = R.txtEX14a : txtEX14b.Text = R.txtEX14b
        txtEX14c.Text = R.txtEX14c : txtEX14d.Text = R.txtEX14d
        txtEX14e.Text = R.txtEX14e : txtEX14f.Text = R.txtEX14f
        txtEX14g.Text = R.txtEX14g : txtEX14h.Text = R.txtEX14h
        txtEX15a.Text = R.txtEX15a : txtEX15b.Text = R.txtEX15b
        txtEX15c.Text = R.txtEX15c : txtEX15d.Text = R.txtEX15d
        txtEX15e.Text = R.txtEX15e : txtEX15f.Text = R.txtEX15f
        txtEX15g.Text = R.txtEX15g : txtEX15h.Text = R.txtEX15h
        txtEX16a.Text = R.txtEX16a : txtEX16b.Text = R.txtEX16b
        txtEX16c.Text = R.txtEX16c : txtEX16d.Text = R.txtEX16d
        txtEX16e.Text = R.txtEX16e : txtEX16f.Text = R.txtEX16f
        txtEX16g.Text = R.txtEX16g : txtEX16h.Text = R.txtEX16h
        txtEX17a.Text = R.txtEX17a : txtEX17b.Text = R.txtEX17b
        txtEX17c.Text = R.txtEX17c : txtEX17d.Text = R.txtEX17d
        txtEX17e.Text = R.txtEX17e : txtEX17f.Text = R.txtEX17f
        txtEX17g.Text = R.txtEX17g : txtEX17h.Text = R.txtEX17h
        txtEX18a.Text = R.txtEX18a : txtEX18b.Text = R.txtEX18b
        txtEX18c.Text = R.txtEX18c : txtEX18d.Text = R.txtEX18d
        txtEX18e.Text = R.txtEX18e : txtEX18f.Text = R.txtEX18f
        txtEX18g.Text = R.txtEX18g : txtEX18h.Text = R.txtEX18h
        txtEX19a.Text = R.txtEX19a : txtEX19b.Text = R.txtEX19b
        txtEX19c.Text = R.txtEX19c : txtEX19d.Text = R.txtEX19d
        txtEX19e.Text = R.txtEX19e : txtEX19f.Text = R.txtEX19f
        txtEX19g.Text = R.txtEX19g : txtEX19h.Text = R.txtEX19h
        txtEX20a.Text = R.txtEX20a : txtEX20b.Text = R.txtEX20b
        txtEX20c.Text = R.txtEX20c : txtEX20d.Text = R.txtEX20d
        txtEX20e.Text = R.txtEX20e : txtEX20f.Text = R.txtEX20f
        txtEX20g.Text = R.txtEX20g : txtEX20h.Text = R.txtEX20h

        txtOtroEx01.Text = R.txtOtroEx01 : txtOtroEx02.Text = R.txtOtroEx02
        txtOtroEx03.Text = R.txtOtroEx03 : txtOtroEx04.Text = R.txtOtroEx04
        txtOtroEx05.Text = R.txtOtroEx05 : txtOtroEx06.Text = R.txtOtroEx06
        txtOtroEx07.Text = R.txtOtroEx07 : txtOtroEx08.Text = R.txtOtroEx08
        txtOtroEx09.Text = R.Adicional02

        txtEX21a.Text = R.txtEX21a : txtEX21b.Text = R.txtEX21b
        txtEX21c.Text = R.txtEX21c : txtEX21d.Text = R.txtEX21d
        txtEX21e.Text = R.txtEX21e : txtEX21f.Text = R.txtEX21f
        txtEX21g.Text = R.txtEX21g : txtEX21h.Text = R.txtEX21h
        txtEX21i.Text = R.txtEX21i : txtEX21j.Text = R.txtEX21j
        txtEX21k.Text = R.txtEX21k : txtEX21l.Text = R.txtEX21l

        'aca se carga el chorizo de todos los ex.fisicos separados por la arroba
        EFcompleto = R.Adicional01
        'y se hace split arroba PARA ponerlos en el array ef de 1 a 10
        EF = EFcompleto.Split("@")

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
            Edad = (DateDiff(DateInterval.Day, fechaNacimiento, Now())) + 1
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

    Private Sub CargaControlGinecologico()
        'revisa que haya un control ginecologico previo y lo carga si es el caso
        If Form1.ExisteControlGinecologico2 = True Then
            'existe un control se empieza a cargar
            LeeContenidoControlGinecologico()
        End If
    End Sub

    Private Sub LeeContenidoControlGinecologico()

        Dim FS As FileStream
        Dim BR As BinaryReader

        FS = New FileStream(NombreControlGinecologico, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)


        Dim C As Integer
        SerieControles.Clear()
        ArraydeFechasOrdenadas.Clear()
        ListBoxSeries.Items.Clear()

        Dim DiaParaElListBox As Date
        Dim contador As Integer = 0
        C = BR.PeekChar
        While FS.Position < FS.Length
            R = Nothing
            ' Read fields and populate structure

            R.FechaInicioControl = BR.ReadString
            R.PatologiaControl = BR.ReadString
            R.txt01a = BR.ReadString : R.txt01b = BR.ReadString
            R.txt01c = BR.ReadString : R.txt01d = BR.ReadString
            R.txt01e = BR.ReadString : R.txt01f = BR.ReadString
            R.txt01g = BR.ReadString : R.txt01h = BR.ReadString
            R.txt02a = BR.ReadString : R.txt02b = BR.ReadString
            R.txt02c = BR.ReadString : R.txt02d = BR.ReadString
            R.txt02e = BR.ReadString : R.txt02f = BR.ReadString
            R.txt02g = BR.ReadString
            R.txt03a = BR.ReadString : R.txt03b = BR.ReadString
            R.txt03c = BR.ReadString : R.txt03d = BR.ReadString
            R.txt03e = BR.ReadString : R.txt03f = BR.ReadString
            R.txt03g = BR.ReadString
            R.txt04a = BR.ReadString : R.txt04b = BR.ReadString
            R.txt04c = BR.ReadString : R.txt04d = BR.ReadString
            R.txt04e = BR.ReadString : R.txt04f = BR.ReadString
            R.txt04g = BR.ReadString
            R.txt05a = BR.ReadString : R.txt05b = BR.ReadString
            R.txt05c = BR.ReadString : R.txt05d = BR.ReadString
            R.txt05e = BR.ReadString : R.txt05f = BR.ReadString
            R.txt05g = BR.ReadString
            R.txt06a = BR.ReadString : R.txt06b = BR.ReadString
            R.txt06c = BR.ReadString : R.txt06d = BR.ReadString
            R.txt06e = BR.ReadString : R.txt06f = BR.ReadString
            R.txt06g = BR.ReadString
            R.txt07a = BR.ReadString : R.txt07b = BR.ReadString
            R.txt07c = BR.ReadString : R.txt07d = BR.ReadString
            R.txt07e = BR.ReadString : R.txt07f = BR.ReadString
            R.txt07g = BR.ReadString
            R.txt08a = BR.ReadString : R.txt08b = BR.ReadString
            R.txt08c = BR.ReadString : R.txt08d = BR.ReadString
            R.txt08e = BR.ReadString : R.txt08f = BR.ReadString
            R.txt08g = BR.ReadString
            R.txt09a = BR.ReadString : R.txt09b = BR.ReadString
            R.txt09c = BR.ReadString : R.txt09d = BR.ReadString
            R.txt09e = BR.ReadString : R.txt09f = BR.ReadString
            R.txt09g = BR.ReadString
            R.txt10a = BR.ReadString : R.txt10b = BR.ReadString
            R.txt10c = BR.ReadString : R.txt10d = BR.ReadString
            R.txt10e = BR.ReadString : R.txt10f = BR.ReadString
            R.txt10g = BR.ReadString

            R.txtFechaLabA = BR.ReadString : R.txtFechaLabB = BR.ReadString
            R.txtFechaLabC = BR.ReadString : R.txtFechaLabD = BR.ReadString
            R.txtFechaLabE = BR.ReadString : R.txtFechaLabF = BR.ReadString
            R.txtFechaLabG = BR.ReadString : R.txtFechaLabH = BR.ReadString

            R.txtEX01a = BR.ReadString : R.txtEX01b = BR.ReadString
            R.txtEX01c = BR.ReadString : R.txtEX01d = BR.ReadString
            R.txtEX01e = BR.ReadString : R.txtEX01f = BR.ReadString
            R.txtEX01g = BR.ReadString : R.txtEX01h = BR.ReadString

            R.txtEX02a = BR.ReadString : R.txtEX02b = BR.ReadString
            R.txtEX02c = BR.ReadString : R.txtEX02d = BR.ReadString
            R.txtEX02e = BR.ReadString : R.txtEX02f = BR.ReadString
            R.txtEX02g = BR.ReadString : R.txtEX02h = BR.ReadString

            R.txtEX03a = BR.ReadString : R.txtEX03b = BR.ReadString
            R.txtEX03c = BR.ReadString : R.txtEX03d = BR.ReadString
            R.txtEX03e = BR.ReadString : R.txtEX03f = BR.ReadString
            R.txtEX03g = BR.ReadString : R.txtEX03h = BR.ReadString

            R.txtEX04a = BR.ReadString : R.txtEX04b = BR.ReadString
            R.txtEX04c = BR.ReadString : R.txtEX04d = BR.ReadString
            R.txtEX04e = BR.ReadString : R.txtEX04f = BR.ReadString
            R.txtEX04g = BR.ReadString : R.txtEX04h = BR.ReadString

            R.txtEX05a = BR.ReadString : R.txtEX05b = BR.ReadString
            R.txtEX05c = BR.ReadString : R.txtEX05d = BR.ReadString
            R.txtEX05e = BR.ReadString : R.txtEX05f = BR.ReadString
            R.txtEX05g = BR.ReadString : R.txtEX05h = BR.ReadString

            R.txtEX06a = BR.ReadString : R.txtEX06b = BR.ReadString
            R.txtEX06c = BR.ReadString : R.txtEX06d = BR.ReadString
            R.txtEX06e = BR.ReadString : R.txtEX06f = BR.ReadString
            R.txtEX06g = BR.ReadString : R.txtEX06h = BR.ReadString

            R.txtEX07a = BR.ReadString : R.txtEX07b = BR.ReadString
            R.txtEX07c = BR.ReadString : R.txtEX07d = BR.ReadString
            R.txtEX07e = BR.ReadString : R.txtEX07f = BR.ReadString
            R.txtEX07g = BR.ReadString : R.txtEX07h = BR.ReadString

            R.txtEX08a = BR.ReadString : R.txtEX08b = BR.ReadString
            R.txtEX08c = BR.ReadString : R.txtEX08d = BR.ReadString
            R.txtEX08e = BR.ReadString : R.txtEX08f = BR.ReadString
            R.txtEX08g = BR.ReadString : R.txtEX08h = BR.ReadString

            R.txtEX09a = BR.ReadString : R.txtEX09b = BR.ReadString
            R.txtEX09c = BR.ReadString : R.txtEX09d = BR.ReadString
            R.txtEX09e = BR.ReadString : R.txtEX09f = BR.ReadString
            R.txtEX09g = BR.ReadString : R.txtEX09h = BR.ReadString

            R.txtEX10a = BR.ReadString : R.txtEX10b = BR.ReadString
            R.txtEX10c = BR.ReadString : R.txtEX10d = BR.ReadString
            R.txtEX10e = BR.ReadString : R.txtEX10f = BR.ReadString
            R.txtEX10g = BR.ReadString : R.txtEX10h = BR.ReadString

            R.txtEX11a = BR.ReadString : R.txtEX11b = BR.ReadString
            R.txtEX11c = BR.ReadString : R.txtEX11d = BR.ReadString
            R.txtEX11e = BR.ReadString : R.txtEX11f = BR.ReadString
            R.txtEX11g = BR.ReadString : R.txtEX11h = BR.ReadString

            R.txtEX12a = BR.ReadString : R.txtEX12b = BR.ReadString
            R.txtEX12c = BR.ReadString : R.txtEX12d = BR.ReadString
            R.txtEX12e = BR.ReadString : R.txtEX12f = BR.ReadString
            R.txtEX12g = BR.ReadString : R.txtEX12h = BR.ReadString

            R.txtEX13a = BR.ReadString : R.txtEX13b = BR.ReadString
            R.txtEX13c = BR.ReadString : R.txtEX13d = BR.ReadString
            R.txtEX13e = BR.ReadString : R.txtEX13f = BR.ReadString
            R.txtEX13g = BR.ReadString : R.txtEX13h = BR.ReadString

            R.txtEX14a = BR.ReadString : R.txtEX14b = BR.ReadString
            R.txtEX14c = BR.ReadString : R.txtEX14d = BR.ReadString
            R.txtEX14e = BR.ReadString : R.txtEX14f = BR.ReadString
            R.txtEX14g = BR.ReadString : R.txtEX14h = BR.ReadString

            R.txtEX15a = BR.ReadString : R.txtEX15b = BR.ReadString
            R.txtEX15c = BR.ReadString : R.txtEX15d = BR.ReadString
            R.txtEX15e = BR.ReadString : R.txtEX15f = BR.ReadString
            R.txtEX15g = BR.ReadString : R.txtEX15h = BR.ReadString

            R.txtEX16a = BR.ReadString : R.txtEX16b = BR.ReadString
            R.txtEX16c = BR.ReadString : R.txtEX16d = BR.ReadString
            R.txtEX16e = BR.ReadString : R.txtEX16f = BR.ReadString
            R.txtEX16g = BR.ReadString : R.txtEX16h = BR.ReadString

            R.txtEX17a = BR.ReadString : R.txtEX17b = BR.ReadString
            R.txtEX17c = BR.ReadString : R.txtEX17d = BR.ReadString
            R.txtEX17e = BR.ReadString : R.txtEX17f = BR.ReadString
            R.txtEX17g = BR.ReadString : R.txtEX17h = BR.ReadString

            R.txtEX18a = BR.ReadString : R.txtEX18b = BR.ReadString
            R.txtEX18c = BR.ReadString : R.txtEX18d = BR.ReadString
            R.txtEX18e = BR.ReadString : R.txtEX18f = BR.ReadString
            R.txtEX18g = BR.ReadString : R.txtEX18h = BR.ReadString

            R.txtEX19a = BR.ReadString : R.txtEX19b = BR.ReadString
            R.txtEX19c = BR.ReadString : R.txtEX19d = BR.ReadString
            R.txtEX19e = BR.ReadString : R.txtEX19f = BR.ReadString
            R.txtEX19g = BR.ReadString : R.txtEX19h = BR.ReadString

            R.txtEX20a = BR.ReadString : R.txtEX20b = BR.ReadString
            R.txtEX20c = BR.ReadString : R.txtEX20d = BR.ReadString
            R.txtEX20e = BR.ReadString : R.txtEX20f = BR.ReadString
            R.txtEX20g = BR.ReadString : R.txtEX20h = BR.ReadString

            R.txtOtroEx01 = BR.ReadString : R.txtOtroEx02 = BR.ReadString
            R.txtOtroEx03 = BR.ReadString : R.txtOtroEx04 = BR.ReadString
            R.txtOtroEx05 = BR.ReadString : R.txtOtroEx06 = BR.ReadString
            R.txtOtroEx07 = BR.ReadString : R.txtOtroEx08 = BR.ReadString

            R.txtEX21a = BR.ReadString : R.txtEX21b = BR.ReadString
            R.txtEX21c = BR.ReadString : R.txtEX21d = BR.ReadString
            R.txtEX21e = BR.ReadString : R.txtEX21f = BR.ReadString
            R.txtEX21g = BR.ReadString : R.txtEX21h = BR.ReadString
            R.txtEX21i = BR.ReadString : R.txtEX21j = BR.ReadString
            R.txtEX21k = BR.ReadString : R.txtEX21l = BR.ReadString

            R.Adicional01 = BR.ReadString  'aca se guarda el chorizo de los 10 examenes fisicos codificado
            R.Adicional02 = BR.ReadString : R.Adicional03 = BR.ReadString
            R.Adicional04 = BR.ReadString

            SerieControles.Add(R)
            contador += 1

            'inicia llenado del array de fechas de controles anteriores para despues ordenarlas
            DiaParaElListBox = R.FechaInicioControl
            ArraydeFechasOrdenadas.Add(DiaParaElListBox.ToString("s") & "|" & R.PatologiaControl)

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
            ListBoxSeries.Items.Add(DiaParaElListBox.ToShortDateString & "|" & Partes(1))
        End While

    End Sub

    'eventos posibles en la ficha de indice

    Private Sub ListBoxSeries_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxSeries.DoubleClick
        If ListBoxSeries.SelectedItem <> "" Then
            botSelecciona.Enabled = True
            botElimina.Enabled = True
            botRenombraSerie.Enabled = True
            AbreElcontrolSeleccionado()
        End If

    End Sub

    Private Sub ListBoxSeries_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxSeries.SelectedIndexChanged
        botSelecciona.Enabled = True
        botElimina.Enabled = True
        botRenombraSerie.Enabled = True
    End Sub

    Private Sub botSelecciona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSelecciona.Click
        AbreElcontrolSeleccionado()
    End Sub

    Private Sub AbreElcontrolSeleccionado()
        Dim FechacomoDate As Date
        'Dim FechaparaelFUR As Date
        Dim FechaComoShortDateString As String
        Dim REnum As IEnumerator
        Dim contador As Integer = 0
        Dim Partes(5) As String
        Dim Encabezado As String

        If DatosModificados = False Then
            REnum = SerieControles.GetEnumerator
            Encabezado = ListBoxSeries.SelectedItem
            Partes = Split(Encabezado, "|")

            ControlSeleccionado = Partes(0)
            While REnum.MoveNext
                R = Nothing
                R = CType(REnum.Current, EstructuraDatosGinecologicos)
                FechacomoDate = R.FechaInicioControl
                FechaComoShortDateString = FechacomoDate.ToShortDateString
                If FechaComoShortDateString = ControlSeleccionado Then

                    FechaInicioControl = FechacomoDate
                    txtFechaInicioControl.Text = FechacomoDate.ToLongDateString
                    labPatologia.Text = R.PatologiaControl
                    'ahora actualiza el texto con la estructura
                    ActualizaTextoConLaEstructura()

                    'borra los text boxes de los dias de ciclo
                    BorraDiasDeCiclo()

                    'calcula si se puede los dias de ciclo
                    ProcesaFUR01()
                    ProcesaFUR02()
                    ProcesaFUR03()
                    ProcesaFUR04()
                    ProcesaFUR05()
                    ProcesaFUR06()
                    ProcesaFUR07()
                    ProcesaFUR08()
                    ProcesaFUR09()
                    ProcesaFUR10()

                    DatosNoModificados() 'hago esto para poner los botones al inicio porque aun no se ha cambiado nada
                    Exit While
                End If
            End While
            NuevaSerie = False 'no se esta creando un nuevo control para otro embarazo
            'pone visibles las diferentes tabs de los datos
            TabControl3.Visible = True
            TabControl1.SelectedIndex = 1
            TabControl3.SelectedIndex = 0
        Else 'en caso de que se hayan modificado los datos debe anunciarlo para confirmar
            Dim Reply As MsgBoxResult
            Reply = MsgBox("Si abres otro control se perderán los datos nuevos no salvados. Deseas abrirlo de todas formas?", MsgBoxStyle.YesNo, "Selecciona otra Serie de Controles")
            If Reply = MsgBoxResult.Yes Then
                REnum = SerieControles.GetEnumerator
                Encabezado = ListBoxSeries.SelectedItem
                Partes = Split(Encabezado, "|")

                ControlSeleccionado = Partes(0)
                While REnum.MoveNext
                    R = Nothing
                    R = CType(REnum.Current, EstructuraDatosGinecologicos)
                    FechacomoDate = R.FechaInicioControl
                    FechaComoShortDateString = FechacomoDate.ToShortDateString

                    If FechaComoShortDateString = ControlSeleccionado Then
                        FechaInicioControl = FechacomoDate
                        txtFechaInicioControl.Text = FechacomoDate.ToLongDateString
                        labPatologia.Text = R.PatologiaControl
                        'ahora actualiza el texto con la estructura
                        ActualizaTextoConLaEstructura()

                        'borra los text boxes de los dias de ciclo
                        BorraDiasDeCiclo()

                        'calcula si se puede los dias de ciclo
                        ProcesaFUR01()
                        ProcesaFUR02()
                        ProcesaFUR03()
                        ProcesaFUR04()
                        ProcesaFUR05()
                        ProcesaFUR06()
                        ProcesaFUR07()
                        ProcesaFUR08()
                        ProcesaFUR09()
                        ProcesaFUR10()

                        DatosNoModificados()
                        Exit While
                    End If
                End While
                NuevaSerie = False 'no se esta creando un nuevo control para otro embarazo
                'pone visibles las diferentes tabs de los datos
                TabControl3.Visible = True
                TabControl1.SelectedIndex = 1
                TabControl3.SelectedIndex = 0
            Else 'si se responde que no, entonces no se hace nada

            End If

        End If
    End Sub

    Private Sub botRenombraSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botRenombraSerie.Click
        'Dim Reply As MsgBoxResult
        Dim Partes(5) As String
        Dim Encabezado As String
        Dim DLG As New FormNuevaSerie()


        Encabezado = ListBoxSeries.SelectedItem
        Partes = Split(Encabezado, "|")

        ControlSeleccionado = Partes(0)

        Form1.NombreElegidoMensaje = "¿Deseas cambiar el nombre de la Serie de Controles iniciados el día: " & ControlSeleccionado & ", (actualmente: " & Partes(1) & "?" & vbCrLf
        Form1.NombreElegidoMensaje += "Introduce el nuevo nombre en la casilla y luego presiona aceptar..."
        Form1.NombreElegidoTitulo = "Renombra la Serie de Controles"

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            RenombraControlAnterior()
        End If

    End Sub

    Private Sub RenombraControlAnterior()
        Dim FechacomoDate As Date
        Dim FechaComoShortDateString As String

        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(NombreControlGinecologico, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim REnum As IEnumerator
        REnum = SerieControles.GetEnumerator

        'Dim Fecha As Date

        While REnum.MoveNext
            R = Nothing
            R = CType(REnum.Current, EstructuraDatosGinecologicos)

            FechacomoDate = R.FechaInicioControl
            FechaComoShortDateString = FechacomoDate.ToShortDateString

            BW.Write(R.FechaInicioControl)
            If FechaComoShortDateString = ControlSeleccionado Then
                'si es el control seleccionado le pone el nombre nuevo
                R.PatologiaControl = Form1.NombreElegido
            End If
            BW.Write(R.PatologiaControl)
            BW.Write(R.txt01a) : BW.Write(R.txt01b)
            BW.Write(R.txt01c) : BW.Write(R.txt01d)
            BW.Write(R.txt01e) : BW.Write(R.txt01f)
            BW.Write(R.txt01g) : BW.Write(R.txt01h)
            BW.Write(R.txt02a) : BW.Write(R.txt02b)
            BW.Write(R.txt02c) : BW.Write(R.txt02d)
            BW.Write(R.txt02e) : BW.Write(R.txt02f)
            BW.Write(R.txt02g)
            BW.Write(R.txt03a) : BW.Write(R.txt03b)
            BW.Write(R.txt03c) : BW.Write(R.txt03d)
            BW.Write(R.txt03e) : BW.Write(R.txt03f)
            BW.Write(R.txt03g)
            BW.Write(R.txt04a) : BW.Write(R.txt04b)
            BW.Write(R.txt04c) : BW.Write(R.txt04d)
            BW.Write(R.txt04e) : BW.Write(R.txt04f)
            BW.Write(R.txt04g)
            BW.Write(R.txt05a) : BW.Write(R.txt05b)
            BW.Write(R.txt05c) : BW.Write(R.txt05d)
            BW.Write(R.txt05e) : BW.Write(R.txt05f)
            BW.Write(R.txt05g)
            BW.Write(R.txt06a) : BW.Write(R.txt06b)
            BW.Write(R.txt06c) : BW.Write(R.txt06d)
            BW.Write(R.txt06e) : BW.Write(R.txt06f)
            BW.Write(R.txt06g)
            BW.Write(R.txt07a) : BW.Write(R.txt07b)
            BW.Write(R.txt07c) : BW.Write(R.txt07d)
            BW.Write(R.txt07e) : BW.Write(R.txt07f)
            BW.Write(R.txt07g)
            BW.Write(R.txt08a) : BW.Write(R.txt08b)
            BW.Write(R.txt08c) : BW.Write(R.txt08d)
            BW.Write(R.txt08e) : BW.Write(R.txt08f)
            BW.Write(R.txt08g)
            BW.Write(R.txt09a) : BW.Write(R.txt09b)
            BW.Write(R.txt09c) : BW.Write(R.txt09d)
            BW.Write(R.txt09e) : BW.Write(R.txt09f)
            BW.Write(R.txt09g)
            BW.Write(R.txt10a) : BW.Write(R.txt10b)
            BW.Write(R.txt10c) : BW.Write(R.txt10d)
            BW.Write(R.txt10e) : BW.Write(R.txt10f)
            BW.Write(R.txt10g)

            BW.Write(R.txtFechaLabA) : BW.Write(R.txtFechaLabB)
            BW.Write(R.txtFechaLabC) : BW.Write(R.txtFechaLabD)
            BW.Write(R.txtFechaLabE) : BW.Write(R.txtFechaLabF)
            BW.Write(R.txtFechaLabG) : BW.Write(R.txtFechaLabH)

            BW.Write(R.txtEX01a) : BW.Write(R.txtEX01b)
            BW.Write(R.txtEX01c) : BW.Write(R.txtEX01d)
            BW.Write(R.txtEX01e) : BW.Write(R.txtEX01f)
            BW.Write(R.txtEX01g) : BW.Write(R.txtEX01h)
            BW.Write(R.txtEX02a) : BW.Write(R.txtEX02b)
            BW.Write(R.txtEX02c) : BW.Write(R.txtEX02d)
            BW.Write(R.txtEX02e) : BW.Write(R.txtEX02f)
            BW.Write(R.txtEX02g) : BW.Write(R.txtEX02h)
            BW.Write(R.txtEX03a) : BW.Write(R.txtEX03b)
            BW.Write(R.txtEX03c) : BW.Write(R.txtEX03d)
            BW.Write(R.txtEX03e) : BW.Write(R.txtEX03f)
            BW.Write(R.txtEX03g) : BW.Write(R.txtEX03h)
            BW.Write(R.txtEX04a) : BW.Write(R.txtEX04b)
            BW.Write(R.txtEX04c) : BW.Write(R.txtEX04d)
            BW.Write(R.txtEX04e) : BW.Write(R.txtEX04f)
            BW.Write(R.txtEX04g) : BW.Write(R.txtEX04h)
            BW.Write(R.txtEX05a) : BW.Write(R.txtEX05b)
            BW.Write(R.txtEX05c) : BW.Write(R.txtEX05d)
            BW.Write(R.txtEX05e) : BW.Write(R.txtEX05f)
            BW.Write(R.txtEX05g) : BW.Write(R.txtEX05h)
            BW.Write(R.txtEX06a) : BW.Write(R.txtEX06b)
            BW.Write(R.txtEX06c) : BW.Write(R.txtEX06d)
            BW.Write(R.txtEX06e) : BW.Write(R.txtEX06f)
            BW.Write(R.txtEX06g) : BW.Write(R.txtEX06h)
            BW.Write(R.txtEX07a) : BW.Write(R.txtEX07b)
            BW.Write(R.txtEX07c) : BW.Write(R.txtEX07d)
            BW.Write(R.txtEX07e) : BW.Write(R.txtEX07f)
            BW.Write(R.txtEX07g) : BW.Write(R.txtEX07h)
            BW.Write(R.txtEX08a) : BW.Write(R.txtEX08b)
            BW.Write(R.txtEX08c) : BW.Write(R.txtEX08d)
            BW.Write(R.txtEX08e) : BW.Write(R.txtEX08f)
            BW.Write(R.txtEX08g) : BW.Write(R.txtEX08h)
            BW.Write(R.txtEX09a) : BW.Write(R.txtEX09b)
            BW.Write(R.txtEX09c) : BW.Write(R.txtEX09d)
            BW.Write(R.txtEX09e) : BW.Write(R.txtEX09f)
            BW.Write(R.txtEX09g) : BW.Write(R.txtEX09h)
            BW.Write(R.txtEX10a) : BW.Write(R.txtEX10b)
            BW.Write(R.txtEX10c) : BW.Write(R.txtEX10d)
            BW.Write(R.txtEX10e) : BW.Write(R.txtEX10f)
            BW.Write(R.txtEX10g) : BW.Write(R.txtEX10h)
            BW.Write(R.txtEX11a) : BW.Write(R.txtEX11b)
            BW.Write(R.txtEX11c) : BW.Write(R.txtEX11d)
            BW.Write(R.txtEX11e) : BW.Write(R.txtEX11f)
            BW.Write(R.txtEX11g) : BW.Write(R.txtEX11h)
            BW.Write(R.txtEX12a) : BW.Write(R.txtEX12b)
            BW.Write(R.txtEX12c) : BW.Write(R.txtEX12d)
            BW.Write(R.txtEX12e) : BW.Write(R.txtEX12f)
            BW.Write(R.txtEX12g) : BW.Write(R.txtEX12h)
            BW.Write(R.txtEX13a) : BW.Write(R.txtEX13b)
            BW.Write(R.txtEX13c) : BW.Write(R.txtEX13d)
            BW.Write(R.txtEX13e) : BW.Write(R.txtEX13f)
            BW.Write(R.txtEX13g) : BW.Write(R.txtEX13h)
            BW.Write(R.txtEX14a) : BW.Write(R.txtEX14b)
            BW.Write(R.txtEX14c) : BW.Write(R.txtEX14d)
            BW.Write(R.txtEX14e) : BW.Write(R.txtEX14f)
            BW.Write(R.txtEX14g) : BW.Write(R.txtEX14h)
            BW.Write(R.txtEX15a) : BW.Write(R.txtEX15b)
            BW.Write(R.txtEX15c) : BW.Write(R.txtEX15d)
            BW.Write(R.txtEX15e) : BW.Write(R.txtEX15f)
            BW.Write(R.txtEX15g) : BW.Write(R.txtEX15h)
            BW.Write(R.txtEX16a) : BW.Write(R.txtEX16b)
            BW.Write(R.txtEX16c) : BW.Write(R.txtEX16d)
            BW.Write(R.txtEX16e) : BW.Write(R.txtEX16f)
            BW.Write(R.txtEX16g) : BW.Write(R.txtEX16h)
            BW.Write(R.txtEX17a) : BW.Write(R.txtEX17b)
            BW.Write(R.txtEX17c) : BW.Write(R.txtEX17d)
            BW.Write(R.txtEX17e) : BW.Write(R.txtEX17f)
            BW.Write(R.txtEX17g) : BW.Write(R.txtEX17h)
            BW.Write(R.txtEX18a) : BW.Write(R.txtEX18b)
            BW.Write(R.txtEX18c) : BW.Write(R.txtEX18d)
            BW.Write(R.txtEX18e) : BW.Write(R.txtEX18f)
            BW.Write(R.txtEX18g) : BW.Write(R.txtEX18h)
            BW.Write(R.txtEX19a) : BW.Write(R.txtEX19b)
            BW.Write(R.txtEX19c) : BW.Write(R.txtEX19d)
            BW.Write(R.txtEX19e) : BW.Write(R.txtEX19f)
            BW.Write(R.txtEX19g) : BW.Write(R.txtEX19h)
            BW.Write(R.txtEX20a) : BW.Write(R.txtEX20b)
            BW.Write(R.txtEX20c) : BW.Write(R.txtEX20d)
            BW.Write(R.txtEX20e) : BW.Write(R.txtEX20f)
            BW.Write(R.txtEX20g) : BW.Write(R.txtEX20h)

            BW.Write(R.txtOtroEx01) : BW.Write(R.txtOtroEx02)
            BW.Write(R.txtOtroEx03) : BW.Write(R.txtOtroEx04)
            BW.Write(R.txtOtroEx05) : BW.Write(R.txtOtroEx06)
            BW.Write(R.txtOtroEx07) : BW.Write(R.txtOtroEx08)

            BW.Write(R.txtEX21a) : BW.Write(R.txtEX21b)
            BW.Write(R.txtEX21c) : BW.Write(R.txtEX21d)
            BW.Write(R.txtEX21e) : BW.Write(R.txtEX21f)
            BW.Write(R.txtEX21g) : BW.Write(R.txtEX21h)
            BW.Write(R.txtEX21i) : BW.Write(R.txtEX21j)
            BW.Write(R.txtEX21k) : BW.Write(R.txtEX21l)

            BW.Write(R.Adicional01) : BW.Write(R.Adicional02)
            BW.Write(R.Adicional03) : BW.Write(R.Adicional04)
        End While
        BW.Close()
        FS.Close()
        MsgBox("Se Renombró la Serie de Controles seleccionada", MsgBoxStyle.Information)

        LeeContenidoControlGinecologico()

        'borra el contenido de la ventana pone todo como debe ser al principio
        botSelecciona.Enabled = False
        botElimina.Enabled = False
        botRenombraSerie.Enabled = False
        TabControl3.Visible = False
        txtFechaInicioControl.Text = "Ninguno"
        labPatologia.Text = ""
    End Sub

    Private Sub botElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botElimina.Click

        Dim Reply As MsgBoxResult
        Dim Partes(5) As String
        Dim Encabezado As String

        Encabezado = ListBoxSeries.SelectedItem
        Partes = Split(Encabezado, "|")

        ControlSeleccionado = Partes(0)

        Reply = MsgBox("Deseas eliminar la Serie de Controles iniciados el día: " & ControlSeleccionado & vbCrLf & Partes(1), MsgBoxStyle.OKCancel)
        If Reply = MsgBoxResult.OK Then
            EliminaControlAnterior()
            'modificacion para el respaldo de archivos
            Form1.SeModificaronDatos = True
        End If
    End Sub

    Private Sub EliminaControlAnterior()
        Dim FechacomoDate As Date
        Dim FechaComoShortDateString As String

        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(NombreControlGinecologico, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        Dim REnum As IEnumerator
        REnum = SerieControles.GetEnumerator
        'Dim H As New EstructuraDatosGinecologicos()
        'Dim Fecha As Date

        Dim contador As Integer = 0
        While REnum.MoveNext
            R = Nothing
            R = CType(REnum.Current, EstructuraDatosGinecologicos)

            FechacomoDate = R.FechaInicioControl
            FechaComoShortDateString = FechacomoDate.ToShortDateString

            If FechaComoShortDateString = ControlSeleccionado Then
                'si el control examinado es el que se quiere eliminar no lo escribe

            Else
                'si es distinto al seleccionado lo escribe al fichero
                BW.Write(R.FechaInicioControl)
                BW.Write(R.PatologiaControl)
                BW.Write(R.txt01a) : BW.Write(R.txt01b)
                BW.Write(R.txt01c) : BW.Write(R.txt01d)
                BW.Write(R.txt01e) : BW.Write(R.txt01f)
                BW.Write(R.txt01g) : BW.Write(R.txt01h)
                BW.Write(R.txt02a) : BW.Write(R.txt02b)
                BW.Write(R.txt02c) : BW.Write(R.txt02d)
                BW.Write(R.txt02e) : BW.Write(R.txt02f)
                BW.Write(R.txt02g)
                BW.Write(R.txt03a) : BW.Write(R.txt03b)
                BW.Write(R.txt03c) : BW.Write(R.txt03d)
                BW.Write(R.txt03e) : BW.Write(R.txt03f)
                BW.Write(R.txt03g)
                BW.Write(R.txt04a) : BW.Write(R.txt04b)
                BW.Write(R.txt04c) : BW.Write(R.txt04d)
                BW.Write(R.txt04e) : BW.Write(R.txt04f)
                BW.Write(R.txt04g)
                BW.Write(R.txt05a) : BW.Write(R.txt05b)
                BW.Write(R.txt05c) : BW.Write(R.txt05d)
                BW.Write(R.txt05e) : BW.Write(R.txt05f)
                BW.Write(R.txt05g)
                BW.Write(R.txt06a) : BW.Write(R.txt06b)
                BW.Write(R.txt06c) : BW.Write(R.txt06d)
                BW.Write(R.txt06e) : BW.Write(R.txt06f)
                BW.Write(R.txt06g)
                BW.Write(R.txt07a) : BW.Write(R.txt07b)
                BW.Write(R.txt07c) : BW.Write(R.txt07d)
                BW.Write(R.txt07e) : BW.Write(R.txt07f)
                BW.Write(R.txt07g)
                BW.Write(R.txt08a) : BW.Write(R.txt08b)
                BW.Write(R.txt08c) : BW.Write(R.txt08d)
                BW.Write(R.txt08e) : BW.Write(R.txt08f)
                BW.Write(R.txt08g)
                BW.Write(R.txt09a) : BW.Write(R.txt09b)
                BW.Write(R.txt09c) : BW.Write(R.txt09d)
                BW.Write(R.txt09e) : BW.Write(R.txt09f)
                BW.Write(R.txt09g)
                BW.Write(R.txt10a) : BW.Write(R.txt10b)
                BW.Write(R.txt10c) : BW.Write(R.txt10d)
                BW.Write(R.txt10e) : BW.Write(R.txt10f)
                BW.Write(R.txt10g)

                BW.Write(R.txtFechaLabA) : BW.Write(R.txtFechaLabB)
                BW.Write(R.txtFechaLabC) : BW.Write(R.txtFechaLabD)
                BW.Write(R.txtFechaLabE) : BW.Write(R.txtFechaLabF)
                BW.Write(R.txtFechaLabG) : BW.Write(R.txtFechaLabH)

                BW.Write(R.txtEX01a) : BW.Write(R.txtEX01b)
                BW.Write(R.txtEX01c) : BW.Write(R.txtEX01d)
                BW.Write(R.txtEX01e) : BW.Write(R.txtEX01f)
                BW.Write(R.txtEX01g) : BW.Write(R.txtEX01h)
                BW.Write(R.txtEX02a) : BW.Write(R.txtEX02b)
                BW.Write(R.txtEX02c) : BW.Write(R.txtEX02d)
                BW.Write(R.txtEX02e) : BW.Write(R.txtEX02f)
                BW.Write(R.txtEX02g) : BW.Write(R.txtEX02h)
                BW.Write(R.txtEX03a) : BW.Write(R.txtEX03b)
                BW.Write(R.txtEX03c) : BW.Write(R.txtEX03d)
                BW.Write(R.txtEX03e) : BW.Write(R.txtEX03f)
                BW.Write(R.txtEX03g) : BW.Write(R.txtEX03h)
                BW.Write(R.txtEX04a) : BW.Write(R.txtEX04b)
                BW.Write(R.txtEX04c) : BW.Write(R.txtEX04d)
                BW.Write(R.txtEX04e) : BW.Write(R.txtEX04f)
                BW.Write(R.txtEX04g) : BW.Write(R.txtEX04h)
                BW.Write(R.txtEX05a) : BW.Write(R.txtEX05b)
                BW.Write(R.txtEX05c) : BW.Write(R.txtEX05d)
                BW.Write(R.txtEX05e) : BW.Write(R.txtEX05f)
                BW.Write(R.txtEX05g) : BW.Write(R.txtEX05h)
                BW.Write(R.txtEX06a) : BW.Write(R.txtEX06b)
                BW.Write(R.txtEX06c) : BW.Write(R.txtEX06d)
                BW.Write(R.txtEX06e) : BW.Write(R.txtEX06f)
                BW.Write(R.txtEX06g) : BW.Write(R.txtEX06h)
                BW.Write(R.txtEX07a) : BW.Write(R.txtEX07b)
                BW.Write(R.txtEX07c) : BW.Write(R.txtEX07d)
                BW.Write(R.txtEX07e) : BW.Write(R.txtEX07f)
                BW.Write(R.txtEX07g) : BW.Write(R.txtEX07h)
                BW.Write(R.txtEX08a) : BW.Write(R.txtEX08b)
                BW.Write(R.txtEX08c) : BW.Write(R.txtEX08d)
                BW.Write(R.txtEX08e) : BW.Write(R.txtEX08f)
                BW.Write(R.txtEX08g) : BW.Write(R.txtEX08h)
                BW.Write(R.txtEX09a) : BW.Write(R.txtEX09b)
                BW.Write(R.txtEX09c) : BW.Write(R.txtEX09d)
                BW.Write(R.txtEX09e) : BW.Write(R.txtEX09f)
                BW.Write(R.txtEX09g) : BW.Write(R.txtEX09h)
                BW.Write(R.txtEX10a) : BW.Write(R.txtEX10b)
                BW.Write(R.txtEX10c) : BW.Write(R.txtEX10d)
                BW.Write(R.txtEX10e) : BW.Write(R.txtEX10f)
                BW.Write(R.txtEX10g) : BW.Write(R.txtEX10h)
                BW.Write(R.txtEX11a) : BW.Write(R.txtEX11b)
                BW.Write(R.txtEX11c) : BW.Write(R.txtEX11d)
                BW.Write(R.txtEX11e) : BW.Write(R.txtEX11f)
                BW.Write(R.txtEX11g) : BW.Write(R.txtEX11h)
                BW.Write(R.txtEX12a) : BW.Write(R.txtEX12b)
                BW.Write(R.txtEX12c) : BW.Write(R.txtEX12d)
                BW.Write(R.txtEX12e) : BW.Write(R.txtEX12f)
                BW.Write(R.txtEX12g) : BW.Write(R.txtEX12h)
                BW.Write(R.txtEX13a) : BW.Write(R.txtEX13b)
                BW.Write(R.txtEX13c) : BW.Write(R.txtEX13d)
                BW.Write(R.txtEX13e) : BW.Write(R.txtEX13f)
                BW.Write(R.txtEX13g) : BW.Write(R.txtEX13h)
                BW.Write(R.txtEX14a) : BW.Write(R.txtEX14b)
                BW.Write(R.txtEX14c) : BW.Write(R.txtEX14d)
                BW.Write(R.txtEX14e) : BW.Write(R.txtEX14f)
                BW.Write(R.txtEX14g) : BW.Write(R.txtEX14h)
                BW.Write(R.txtEX15a) : BW.Write(R.txtEX15b)
                BW.Write(R.txtEX15c) : BW.Write(R.txtEX15d)
                BW.Write(R.txtEX15e) : BW.Write(R.txtEX15f)
                BW.Write(R.txtEX15g) : BW.Write(R.txtEX15h)
                BW.Write(R.txtEX16a) : BW.Write(R.txtEX16b)
                BW.Write(R.txtEX16c) : BW.Write(R.txtEX16d)
                BW.Write(R.txtEX16e) : BW.Write(R.txtEX16f)
                BW.Write(R.txtEX16g) : BW.Write(R.txtEX16h)
                BW.Write(R.txtEX17a) : BW.Write(R.txtEX17b)
                BW.Write(R.txtEX17c) : BW.Write(R.txtEX17d)
                BW.Write(R.txtEX17e) : BW.Write(R.txtEX17f)
                BW.Write(R.txtEX17g) : BW.Write(R.txtEX17h)
                BW.Write(R.txtEX18a) : BW.Write(R.txtEX18b)
                BW.Write(R.txtEX18c) : BW.Write(R.txtEX18d)
                BW.Write(R.txtEX18e) : BW.Write(R.txtEX18f)
                BW.Write(R.txtEX18g) : BW.Write(R.txtEX18h)
                BW.Write(R.txtEX19a) : BW.Write(R.txtEX19b)
                BW.Write(R.txtEX19c) : BW.Write(R.txtEX19d)
                BW.Write(R.txtEX19e) : BW.Write(R.txtEX19f)
                BW.Write(R.txtEX19g) : BW.Write(R.txtEX19h)
                BW.Write(R.txtEX20a) : BW.Write(R.txtEX20b)
                BW.Write(R.txtEX20c) : BW.Write(R.txtEX20d)
                BW.Write(R.txtEX20e) : BW.Write(R.txtEX20f)
                BW.Write(R.txtEX20g) : BW.Write(R.txtEX20h)

                BW.Write(R.txtOtroEx01) : BW.Write(R.txtOtroEx02)
                BW.Write(R.txtOtroEx03) : BW.Write(R.txtOtroEx04)
                BW.Write(R.txtOtroEx05) : BW.Write(R.txtOtroEx06)
                BW.Write(R.txtOtroEx07) : BW.Write(R.txtOtroEx08)

                BW.Write(R.txtEX21a) : BW.Write(R.txtEX21b)
                BW.Write(R.txtEX21c) : BW.Write(R.txtEX21d)
                BW.Write(R.txtEX21e) : BW.Write(R.txtEX21f)
                BW.Write(R.txtEX21g) : BW.Write(R.txtEX21h)
                BW.Write(R.txtEX21i) : BW.Write(R.txtEX21j)
                BW.Write(R.txtEX21k) : BW.Write(R.txtEX21l)

                BW.Write(R.Adicional01) : BW.Write(R.Adicional02)
                BW.Write(R.Adicional03) : BW.Write(R.Adicional04)

                contador += 1

            End If
        End While
        BW.Close()
        FS.Close()
        MsgBox("Se Eliminó la Serie de Controles seleccionada", MsgBoxStyle.Information)

        If contador = 0 Then
            'se elimino hasta el ultimo control se debe actualizar el contenido de la historia borrando la linea datos
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
                If LineaDatos = Form1.PSstrNumeroHistoriaSeleccionada & "-Control Ginecológico" Then
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
            File.Delete(NombreControlGinecologico)
            'por ultimo pone la variable de existe control ginecologico a false
            Form1.ExisteControlGinecologico2 = False

        End If
        'si aun existe alguna  serie de controles ginecologico lo muestra en el listbox
        If Form1.ExisteControlGinecologico2 = True Then
            LeeContenidoControlGinecologico()
        Else
            ListBoxSeries.Items.Clear()
        End If

        'borra el contenido de la ventana pone todo como debe ser al principio
        botSelecciona.Enabled = False
        botElimina.Enabled = False
        botRenombraSerie.Enabled = False
        TabControl3.Visible = False
        txtFechaInicioControl.Text = "Ninguno"
        labPatologia.Text = ""

    End Sub

    Private Sub botNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botNuevo.Click
        Dim DLG As New FormEligeFecha()
        Dim DLG2 As New FormNuevaSerie()
        Dim PeriodoInterSeries As Integer 'dias desde el control revisado
        Dim PeriodoInterSeriesDefinitivo As Integer 'dias desde el ultimo control
        Dim ValorAbsPIS, ValorAbsPISDef As Integer
        Dim ContinuaInicioDeControlGinecologico As Boolean

        Dim FechaExistente As Date
        Dim Indice As Integer
        Dim Elementos As Integer

        Dim Encabezado As String
        Dim Partes(5) As String

        Dim Reply As MsgBoxResult

        Form1.FechaSeleccionadaMensaje = "Selecciona la fecha inicial de la Serie de Controles Ginecológicos en el Calendario..."

        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'se acepto una fecha
            FechaInicioControl = Form1.FechaSeleccionada

            If FechaInicioControl > Today Then
                MsgBox("La fecha de la nueva Serie de Controles Ginecológicos no puede estar en el futuro...", MsgBoxStyle.Information, "Fecha inválida")
                Exit Sub
            End If

            Elementos = ListBoxSeries.Items.Count - 1
            PeriodoInterSeriesDefinitivo = 300 ' al principio 300 para que no haya problemas

            For Indice = 0 To Elementos
                Encabezado = ListBoxSeries.Items(Indice)
                Partes = Split(Encabezado, "|")

                FechaExistente = Partes(0)
                If FechaExistente = FechaInicioControl Then
                    'hay una coincidencia, no permite la creacion de otra consulta aca, dice q debe ser
                    'modificar la existente, no sea bruto...!
                    MsgBox("Ya se inició una Serie de Controles Ginecológicos este día, para modificarla selecciónala de la lista...", MsgBoxStyle.Information, "Fecha de Inicio ya existe")
                    Exit Sub
                Else
                    PeriodoInterSeries = (DateDiff(DateInterval.Day, FechaExistente, FechaInicioControl))
                    ValorAbsPIS = Math.Abs(PeriodoInterSeries)
                    ValorAbsPISDef = Math.Abs(PeriodoInterSeriesDefinitivo)
                    If ValorAbsPIS < ValorAbsPISDef Then
                        PeriodoInterSeriesDefinitivo = PeriodoInterSeries
                    End If
                End If
            Next

            'ahora que sabes cual es per intergenesico segun el inicio de los controles pregunta
            ContinuaInicioDeControlGinecologico = True
            If PeriodoInterSeriesDefinitivo > 0 And PeriodoInterSeriesDefinitivo < 30 Then
                'imposible se encuentra a menos de 30 dias del inicio de otro control...
                MsgBox("Ya se ha iniciado una Serie de Controles Ginecológicos el día " & FechaInicioControl.AddDays(-PeriodoInterSeriesDefinitivo) & ", para modificarla selecciónala de la lista...", MsgBoxStyle.Information, "Control Ginecológico ya existe")
                ContinuaInicioDeControlGinecologico = False
            ElseIf PeriodoInterSeriesDefinitivo > -30 And PeriodoInterSeriesDefinitivo < 0 Then
                'imposible se encuentra a menos de 30 dias del inicio de otro control...
                MsgBox("Ya se ha iniciado una Serie de Controles Ginecológicos el día " & FechaInicioControl.AddDays(-PeriodoInterSeriesDefinitivo) & ", para modificarla selecciónala de la lista...", MsgBoxStyle.Information, "Control Ginecológico ya existe")
                ContinuaInicioDeControlGinecologico = False
            ElseIf PeriodoInterSeriesDefinitivo >= 30 And PeriodoInterSeriesDefinitivo < 90 Then
                'esta en un rango posible por ejemplo o un control tardio 
                Reply = MsgBox("Existe una Serie de Controles Ginecológicos iniciada a menos de 3 meses de esta fecha (Exactamente: " & PeriodoInterSeriesDefinitivo & " días), Si esta Serie de Controles ya finalizó y deseas crear una Serie NUEVA para el " & FechaInicioControl & " presiona ACEPTAR...", MsgBoxStyle.OkCancel, "Nueva Serie de Controles Ginecológicos")
                If Reply = MsgBoxResult.Ok Then
                    ContinuaInicioDeControlGinecologico = True
                Else
                    ContinuaInicioDeControlGinecologico = False
                End If
            ElseIf PeriodoInterSeriesDefinitivo > -90 And PeriodoInterSeriesDefinitivo <= -30 Then
                'esta en un rango posible  
                Reply = MsgBox("Existe una Serie de Controles Ginecológicos iniciada menos de 3 meses en el futuro de esta fecha (Exactamente: " & Math.Abs(PeriodoInterSeriesDefinitivo) & " días), Si aún deseas crear una Serie NUEVA para el " & FechaInicioControl & " presiona ACEPTAR...", MsgBoxStyle.OkCancel, "Nueva Serie de Controles Ginecológicos")
                If Reply = MsgBoxResult.Ok Then
                    ContinuaInicioDeControlGinecologico = True
                Else
                    ContinuaInicioDeControlGinecologico = False
                End If
            ElseIf PeriodoInterSeriesDefinitivo >= 90 Or PeriodoInterSeriesDefinitivo <= -90 Then
                ContinuaInicioDeControlGinecologico = True
            End If

            If ContinuaInicioDeControlGinecologico = True Then
                'se inicia la posible creacion del nuevo control

                'pregunta el encabezado o como se denominara la serie
                Form1.NombreElegidoMensaje = "¿Con qué nombre deseas llamar a esta Serie de Controles? Puedes utilizar por ejemplo la patología que presenta la paciente o si es un control por ejemplo CONTROL GINECOLOGICO ANUAL..."
                Form1.NombreElegidoTitulo = "Nombre de la Serie de Controles"
                If DLG2.ShowDialog = Windows.Forms.DialogResult.OK Then

                    NuevaSerie = True 'se esta creando un nuevo control para otro embarazo

                    BorraEstructura()
                    ControlSeleccionado = FechaInicioControl.ToString("s")
                    R.FechaInicioControl = FechaInicioControl.ToString("s") ' formatea la fecha para el fichero

                    R.PatologiaControl = Form1.NombreElegido


                    BorraTextBoxes()
                    'borra los text boxes de los dias de ciclo
                    BorraDiasDeCiclo()

                    txtFechaInicioControl.Text = FechaInicioControl.ToLongDateString 'formatea lo que sale en pantalla
                    labPatologia.Text = R.PatologiaControl
                    txt01a.Text = FechaInicioControl.ToShortDateString


                    DatosNoModificados()

                    'pone visibles las diferentes tabs de los datos
                    TabControl3.Visible = True
                    TabControl1.SelectedIndex = 1
                    TabControl3.SelectedIndex = 0

                Else
                    'se cancelo
                End If
            End If
        Else
            'se canceló
        End If

    End Sub

    Private Sub SeModificaronLosDatos()
        DatosModificados = True
        botGuardarNuevosDatos.Enabled = True
        botSalirSinGuardar.Text = "Descarta Cambios"
    End Sub
    Private Sub DatosNoModificados()
        DatosModificados = False
        botGuardarNuevosDatos.Enabled = False
        botSalirSinGuardar.Text = "Salir"
    End Sub

    Private Sub botGuardarNuevosDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botGuardarNuevosDatos.Click

        If Form1.ExisteControlGinecologico2 = False Then
            'no existe un control se debe crear uno nuevo y luego actualizar el contenido de la historia
            CreaControlGinecologico()
            ActualizaContenidoHistoria()
            MsgBox("Se creó una nueva Serie de Controles Ginecológicos", MsgBoxStyle.Information)
            Form1.ExisteControlGinecologico2 = True
            LeeContenidoControlGinecologico()
            NuevaSerie = False
            DatosNoModificados()
            'Me.DialogResult = DialogResult.OK

            botSelecciona.Enabled = False
            botElimina.Enabled = False
            botNuevo.Enabled = True
            botGuardarNuevosDatos.Enabled = False
            botSalirSinGuardar.Enabled = True
            TabControl3.Visible = False
            TabControl1.SelectedIndex = 0
            txtFechaInicioControl.Text = "Ninguno"
            labPatologia.Text = ""

            'modificacion para el respaldo de archivos
            Form1.SeModificaronDatos = True
        Else
            'ya existe al menos un control ginecologico
            Dim FechacomoDate As Date
            Dim FechaComoShortDateString As String

            Dim FS As FileStream
            Dim BW As BinaryWriter

            FS = New FileStream(NombreControlGinecologico, FileMode.Create, FileAccess.ReadWrite)
            BW = New BinaryWriter(FS)
            BW.BaseStream.Seek(0, SeekOrigin.Begin)

            Dim renum As IEnumerator
            renum = SerieControles.GetEnumerator
            Dim Contador As Integer = 0

            If NuevaSerie = False Then

                'si no se esta creando un control nuevo entonces actualiza el control actual
                While renum.MoveNext
                    R = Nothing
                    R = CType(renum.Current, EstructuraDatosGinecologicos)
                    FechacomoDate = R.FechaInicioControl
                    FechaComoShortDateString = FechacomoDate.ToShortDateString
                    If FechaComoShortDateString = ControlSeleccionado Then
                        'si el control examinado es el editado sustituye los datos por lo que esta en pantalla

                        ActualizaEstructura01ConElTexto()
                        ActualizaEstructura02ConElTexto()
                        ActualizaEstructura03ConElTexto()
                        ActualizaEstructura04ConElTexto()
                        ActualizaEstructura05ConElTexto()
                        ActualizaEstructura06ConElTexto()
                        ActualizaEstructura07ConElTexto()
                        ActualizaEstructura08ConElTexto()
                        ActualizaEstructura09ConElTexto()
                        ActualizaEstructura10ConElTexto()

                        ActualizaEstructurafechalabConElTexto()

                        ActualizaEstructuraEX01ConElTexto()
                        ActualizaEstructuraEX02ConElTexto()
                        ActualizaEstructuraEX03ConElTexto()
                        ActualizaEstructuraEX04ConElTexto()
                        ActualizaEstructuraEX05ConElTexto()
                        ActualizaEstructuraEX06ConElTexto()
                        ActualizaEstructuraEX07ConElTexto()
                        ActualizaEstructuraEX08ConElTexto()
                        ActualizaEstructuraEX09ConElTexto()
                        ActualizaEstructuraEX10ConElTexto()
                        ActualizaEstructuraEX11ConElTexto()
                        ActualizaEstructuraEX12ConElTexto()
                        ActualizaEstructuraEX13ConElTexto()
                        ActualizaEstructuraEX14ConElTexto()
                        ActualizaEstructuraEX15ConElTexto()
                        ActualizaEstructuraEX16ConElTexto()
                        ActualizaEstructuraEX17ConElTexto()
                        ActualizaEstructuraEX18ConElTexto()
                        ActualizaEstructuraEX19ConElTexto()
                        ActualizaEstructuraEX20ConElTexto()

                        ActualizaEstructuraOTROSEXConElTexto()

                        ActualizaEstructuraEX21ConElTexto()

                        ActualizaEstructuraAdicional1conelExFisico()
                    End If

                    BW.Write(R.FechaInicioControl)
                    BW.Write(R.PatologiaControl)
                    BW.Write(R.txt01a) : BW.Write(R.txt01b)
                    BW.Write(R.txt01c) : BW.Write(R.txt01d)
                    BW.Write(R.txt01e) : BW.Write(R.txt01f)
                    BW.Write(R.txt01g) : BW.Write(R.txt01h)
                    BW.Write(R.txt02a) : BW.Write(R.txt02b)
                    BW.Write(R.txt02c) : BW.Write(R.txt02d)
                    BW.Write(R.txt02e) : BW.Write(R.txt02f)
                    BW.Write(R.txt02g)
                    BW.Write(R.txt03a) : BW.Write(R.txt03b)
                    BW.Write(R.txt03c) : BW.Write(R.txt03d)
                    BW.Write(R.txt03e) : BW.Write(R.txt03f)
                    BW.Write(R.txt03g)
                    BW.Write(R.txt04a) : BW.Write(R.txt04b)
                    BW.Write(R.txt04c) : BW.Write(R.txt04d)
                    BW.Write(R.txt04e) : BW.Write(R.txt04f)
                    BW.Write(R.txt04g)
                    BW.Write(R.txt05a) : BW.Write(R.txt05b)
                    BW.Write(R.txt05c) : BW.Write(R.txt05d)
                    BW.Write(R.txt05e) : BW.Write(R.txt05f)
                    BW.Write(R.txt05g)
                    BW.Write(R.txt06a) : BW.Write(R.txt06b)
                    BW.Write(R.txt06c) : BW.Write(R.txt06d)
                    BW.Write(R.txt06e) : BW.Write(R.txt06f)
                    BW.Write(R.txt06g)
                    BW.Write(R.txt07a) : BW.Write(R.txt07b)
                    BW.Write(R.txt07c) : BW.Write(R.txt07d)
                    BW.Write(R.txt07e) : BW.Write(R.txt07f)
                    BW.Write(R.txt07g)
                    BW.Write(R.txt08a) : BW.Write(R.txt08b)
                    BW.Write(R.txt08c) : BW.Write(R.txt08d)
                    BW.Write(R.txt08e) : BW.Write(R.txt08f)
                    BW.Write(R.txt08g)
                    BW.Write(R.txt09a) : BW.Write(R.txt09b)
                    BW.Write(R.txt09c) : BW.Write(R.txt09d)
                    BW.Write(R.txt09e) : BW.Write(R.txt09f)
                    BW.Write(R.txt09g)
                    BW.Write(R.txt10a) : BW.Write(R.txt10b)
                    BW.Write(R.txt10c) : BW.Write(R.txt10d)
                    BW.Write(R.txt10e) : BW.Write(R.txt10f)
                    BW.Write(R.txt10g)

                    BW.Write(R.txtFechaLabA) : BW.Write(R.txtFechaLabB)
                    BW.Write(R.txtFechaLabC) : BW.Write(R.txtFechaLabD)
                    BW.Write(R.txtFechaLabE) : BW.Write(R.txtFechaLabF)
                    BW.Write(R.txtFechaLabG) : BW.Write(R.txtFechaLabH)

                    BW.Write(R.txtEX01a) : BW.Write(R.txtEX01b)
                    BW.Write(R.txtEX01c) : BW.Write(R.txtEX01d)
                    BW.Write(R.txtEX01e) : BW.Write(R.txtEX01f)
                    BW.Write(R.txtEX01g) : BW.Write(R.txtEX01h)
                    BW.Write(R.txtEX02a) : BW.Write(R.txtEX02b)
                    BW.Write(R.txtEX02c) : BW.Write(R.txtEX02d)
                    BW.Write(R.txtEX02e) : BW.Write(R.txtEX02f)
                    BW.Write(R.txtEX02g) : BW.Write(R.txtEX02h)
                    BW.Write(R.txtEX03a) : BW.Write(R.txtEX03b)
                    BW.Write(R.txtEX03c) : BW.Write(R.txtEX03d)
                    BW.Write(R.txtEX03e) : BW.Write(R.txtEX03f)
                    BW.Write(R.txtEX03g) : BW.Write(R.txtEX03h)
                    BW.Write(R.txtEX04a) : BW.Write(R.txtEX04b)
                    BW.Write(R.txtEX04c) : BW.Write(R.txtEX04d)
                    BW.Write(R.txtEX04e) : BW.Write(R.txtEX04f)
                    BW.Write(R.txtEX04g) : BW.Write(R.txtEX04h)
                    BW.Write(R.txtEX05a) : BW.Write(R.txtEX05b)
                    BW.Write(R.txtEX05c) : BW.Write(R.txtEX05d)
                    BW.Write(R.txtEX05e) : BW.Write(R.txtEX05f)
                    BW.Write(R.txtEX05g) : BW.Write(R.txtEX05h)
                    BW.Write(R.txtEX06a) : BW.Write(R.txtEX06b)
                    BW.Write(R.txtEX06c) : BW.Write(R.txtEX06d)
                    BW.Write(R.txtEX06e) : BW.Write(R.txtEX06f)
                    BW.Write(R.txtEX06g) : BW.Write(R.txtEX06h)
                    BW.Write(R.txtEX07a) : BW.Write(R.txtEX07b)
                    BW.Write(R.txtEX07c) : BW.Write(R.txtEX07d)
                    BW.Write(R.txtEX07e) : BW.Write(R.txtEX07f)
                    BW.Write(R.txtEX07g) : BW.Write(R.txtEX07h)
                    BW.Write(R.txtEX08a) : BW.Write(R.txtEX08b)
                    BW.Write(R.txtEX08c) : BW.Write(R.txtEX08d)
                    BW.Write(R.txtEX08e) : BW.Write(R.txtEX08f)
                    BW.Write(R.txtEX08g) : BW.Write(R.txtEX08h)
                    BW.Write(R.txtEX09a) : BW.Write(R.txtEX09b)
                    BW.Write(R.txtEX09c) : BW.Write(R.txtEX09d)
                    BW.Write(R.txtEX09e) : BW.Write(R.txtEX09f)
                    BW.Write(R.txtEX09g) : BW.Write(R.txtEX09h)
                    BW.Write(R.txtEX10a) : BW.Write(R.txtEX10b)
                    BW.Write(R.txtEX10c) : BW.Write(R.txtEX10d)
                    BW.Write(R.txtEX10e) : BW.Write(R.txtEX10f)
                    BW.Write(R.txtEX10g) : BW.Write(R.txtEX10h)
                    BW.Write(R.txtEX11a) : BW.Write(R.txtEX11b)
                    BW.Write(R.txtEX11c) : BW.Write(R.txtEX11d)
                    BW.Write(R.txtEX11e) : BW.Write(R.txtEX11f)
                    BW.Write(R.txtEX11g) : BW.Write(R.txtEX11h)
                    BW.Write(R.txtEX12a) : BW.Write(R.txtEX12b)
                    BW.Write(R.txtEX12c) : BW.Write(R.txtEX12d)
                    BW.Write(R.txtEX12e) : BW.Write(R.txtEX12f)
                    BW.Write(R.txtEX12g) : BW.Write(R.txtEX12h)
                    BW.Write(R.txtEX13a) : BW.Write(R.txtEX13b)
                    BW.Write(R.txtEX13c) : BW.Write(R.txtEX13d)
                    BW.Write(R.txtEX13e) : BW.Write(R.txtEX13f)
                    BW.Write(R.txtEX13g) : BW.Write(R.txtEX13h)
                    BW.Write(R.txtEX14a) : BW.Write(R.txtEX14b)
                    BW.Write(R.txtEX14c) : BW.Write(R.txtEX14d)
                    BW.Write(R.txtEX14e) : BW.Write(R.txtEX14f)
                    BW.Write(R.txtEX14g) : BW.Write(R.txtEX14h)
                    BW.Write(R.txtEX15a) : BW.Write(R.txtEX15b)
                    BW.Write(R.txtEX15c) : BW.Write(R.txtEX15d)
                    BW.Write(R.txtEX15e) : BW.Write(R.txtEX15f)
                    BW.Write(R.txtEX15g) : BW.Write(R.txtEX15h)
                    BW.Write(R.txtEX16a) : BW.Write(R.txtEX16b)
                    BW.Write(R.txtEX16c) : BW.Write(R.txtEX16d)
                    BW.Write(R.txtEX16e) : BW.Write(R.txtEX16f)
                    BW.Write(R.txtEX16g) : BW.Write(R.txtEX16h)
                    BW.Write(R.txtEX17a) : BW.Write(R.txtEX17b)
                    BW.Write(R.txtEX17c) : BW.Write(R.txtEX17d)
                    BW.Write(R.txtEX17e) : BW.Write(R.txtEX17f)
                    BW.Write(R.txtEX17g) : BW.Write(R.txtEX17h)
                    BW.Write(R.txtEX18a) : BW.Write(R.txtEX18b)
                    BW.Write(R.txtEX18c) : BW.Write(R.txtEX18d)
                    BW.Write(R.txtEX18e) : BW.Write(R.txtEX18f)
                    BW.Write(R.txtEX18g) : BW.Write(R.txtEX18h)
                    BW.Write(R.txtEX19a) : BW.Write(R.txtEX19b)
                    BW.Write(R.txtEX19c) : BW.Write(R.txtEX19d)
                    BW.Write(R.txtEX19e) : BW.Write(R.txtEX19f)
                    BW.Write(R.txtEX19g) : BW.Write(R.txtEX19h)
                    BW.Write(R.txtEX20a) : BW.Write(R.txtEX20b)
                    BW.Write(R.txtEX20c) : BW.Write(R.txtEX20d)
                    BW.Write(R.txtEX20e) : BW.Write(R.txtEX20f)
                    BW.Write(R.txtEX20g) : BW.Write(R.txtEX20h)

                    BW.Write(R.txtOtroEx01) : BW.Write(R.txtOtroEx02)
                    BW.Write(R.txtOtroEx03) : BW.Write(R.txtOtroEx04)
                    BW.Write(R.txtOtroEx05) : BW.Write(R.txtOtroEx06)
                    BW.Write(R.txtOtroEx07) : BW.Write(R.txtOtroEx08)

                    BW.Write(R.txtEX21a) : BW.Write(R.txtEX21b)
                    BW.Write(R.txtEX21c) : BW.Write(R.txtEX21d)
                    BW.Write(R.txtEX21e) : BW.Write(R.txtEX21f)
                    BW.Write(R.txtEX21g) : BW.Write(R.txtEX21h)
                    BW.Write(R.txtEX21i) : BW.Write(R.txtEX21j)
                    BW.Write(R.txtEX21k) : BW.Write(R.txtEX21l)

                    BW.Write(R.Adicional01) : BW.Write(R.Adicional02)
                    BW.Write(R.Adicional03) : BW.Write(R.Adicional04)

                    Contador += 1

                End While
                BW.Close()
                FS.Close()
                MsgBox("Se modificó la Serie de Controles Ginecológicos seleccionada", MsgBoxStyle.Information)

                'modificacion para el respaldo de archivos
                Form1.SeModificaronDatos = True

            Else 'se esta añadiendo un nuevo control de embarazo...
                'primero añado todos los controles en el array embarazos al archivo y despues añado
                'lo que esta en pantalla al final del archivo
                While renum.MoveNext
                    R = Nothing
                    R = CType(renum.Current, EstructuraDatosGinecologicos)
                    BW.Write(R.FechaInicioControl)
                    BW.Write(R.PatologiaControl)
                    BW.Write(R.txt01a) : BW.Write(R.txt01b)
                    BW.Write(R.txt01c) : BW.Write(R.txt01d)
                    BW.Write(R.txt01e) : BW.Write(R.txt01f)
                    BW.Write(R.txt01g) : BW.Write(R.txt01h)
                    BW.Write(R.txt02a) : BW.Write(R.txt02b)
                    BW.Write(R.txt02c) : BW.Write(R.txt02d)
                    BW.Write(R.txt02e) : BW.Write(R.txt02f)
                    BW.Write(R.txt02g)

                    BW.Write(R.txt03a) : BW.Write(R.txt03b)
                    BW.Write(R.txt03c) : BW.Write(R.txt03d)
                    BW.Write(R.txt03e) : BW.Write(R.txt03f)
                    BW.Write(R.txt03g)

                    BW.Write(R.txt04a) : BW.Write(R.txt04b)
                    BW.Write(R.txt04c) : BW.Write(R.txt04d)
                    BW.Write(R.txt04e) : BW.Write(R.txt04f)
                    BW.Write(R.txt04g)
                    BW.Write(R.txt05a) : BW.Write(R.txt05b)
                    BW.Write(R.txt05c) : BW.Write(R.txt05d)
                    BW.Write(R.txt05e) : BW.Write(R.txt05f)
                    BW.Write(R.txt05g)
                    BW.Write(R.txt06a) : BW.Write(R.txt06b)
                    BW.Write(R.txt06c) : BW.Write(R.txt06d)
                    BW.Write(R.txt06e) : BW.Write(R.txt06f)
                    BW.Write(R.txt06g)
                    BW.Write(R.txt07a) : BW.Write(R.txt07b)
                    BW.Write(R.txt07c) : BW.Write(R.txt07d)
                    BW.Write(R.txt07e) : BW.Write(R.txt07f)
                    BW.Write(R.txt07g)
                    BW.Write(R.txt08a) : BW.Write(R.txt08b)
                    BW.Write(R.txt08c) : BW.Write(R.txt08d)
                    BW.Write(R.txt08e) : BW.Write(R.txt08f)
                    BW.Write(R.txt08g)
                    BW.Write(R.txt09a) : BW.Write(R.txt09b)
                    BW.Write(R.txt09c) : BW.Write(R.txt09d)
                    BW.Write(R.txt09e) : BW.Write(R.txt09f)
                    BW.Write(R.txt09g)
                    BW.Write(R.txt10a) : BW.Write(R.txt10b)
                    BW.Write(R.txt10c) : BW.Write(R.txt10d)
                    BW.Write(R.txt10e) : BW.Write(R.txt10f)
                    BW.Write(R.txt10g)

                    BW.Write(R.txtFechaLabA) : BW.Write(R.txtFechaLabB)
                    BW.Write(R.txtFechaLabC) : BW.Write(R.txtFechaLabD)
                    BW.Write(R.txtFechaLabE) : BW.Write(R.txtFechaLabF)
                    BW.Write(R.txtFechaLabG) : BW.Write(R.txtFechaLabH)

                    BW.Write(R.txtEX01a) : BW.Write(R.txtEX01b)
                    BW.Write(R.txtEX01c) : BW.Write(R.txtEX01d)
                    BW.Write(R.txtEX01e) : BW.Write(R.txtEX01f)
                    BW.Write(R.txtEX01g) : BW.Write(R.txtEX01h)

                    BW.Write(R.txtEX02a) : BW.Write(R.txtEX02b)
                    BW.Write(R.txtEX02c) : BW.Write(R.txtEX02d)
                    BW.Write(R.txtEX02e) : BW.Write(R.txtEX02f)
                    BW.Write(R.txtEX02g) : BW.Write(R.txtEX02h)

                    BW.Write(R.txtEX03a) : BW.Write(R.txtEX03b)
                    BW.Write(R.txtEX03c) : BW.Write(R.txtEX03d)
                    BW.Write(R.txtEX03e) : BW.Write(R.txtEX03f)
                    BW.Write(R.txtEX03g) : BW.Write(R.txtEX03h)

                    BW.Write(R.txtEX04a) : BW.Write(R.txtEX04b)
                    BW.Write(R.txtEX04c) : BW.Write(R.txtEX04d)
                    BW.Write(R.txtEX04e) : BW.Write(R.txtEX04f)
                    BW.Write(R.txtEX04g) : BW.Write(R.txtEX04h)

                    BW.Write(R.txtEX05a) : BW.Write(R.txtEX05b)
                    BW.Write(R.txtEX05c) : BW.Write(R.txtEX05d)
                    BW.Write(R.txtEX05e) : BW.Write(R.txtEX05f)
                    BW.Write(R.txtEX05g) : BW.Write(R.txtEX05h)

                    BW.Write(R.txtEX06a) : BW.Write(R.txtEX06b)
                    BW.Write(R.txtEX06c) : BW.Write(R.txtEX06d)
                    BW.Write(R.txtEX06e) : BW.Write(R.txtEX06f)
                    BW.Write(R.txtEX06g) : BW.Write(R.txtEX06h)

                    BW.Write(R.txtEX07a) : BW.Write(R.txtEX07b)
                    BW.Write(R.txtEX07c) : BW.Write(R.txtEX07d)
                    BW.Write(R.txtEX07e) : BW.Write(R.txtEX07f)
                    BW.Write(R.txtEX07g) : BW.Write(R.txtEX07h)

                    BW.Write(R.txtEX08a) : BW.Write(R.txtEX08b)
                    BW.Write(R.txtEX08c) : BW.Write(R.txtEX08d)
                    BW.Write(R.txtEX08e) : BW.Write(R.txtEX08f)
                    BW.Write(R.txtEX08g) : BW.Write(R.txtEX08h)
                    BW.Write(R.txtEX09a) : BW.Write(R.txtEX09b)
                    BW.Write(R.txtEX09c) : BW.Write(R.txtEX09d)
                    BW.Write(R.txtEX09e) : BW.Write(R.txtEX09f)
                    BW.Write(R.txtEX09g) : BW.Write(R.txtEX09h)
                    BW.Write(R.txtEX10a) : BW.Write(R.txtEX10b)
                    BW.Write(R.txtEX10c) : BW.Write(R.txtEX10d)
                    BW.Write(R.txtEX10e) : BW.Write(R.txtEX10f)
                    BW.Write(R.txtEX10g) : BW.Write(R.txtEX10h)
                    BW.Write(R.txtEX11a) : BW.Write(R.txtEX11b)
                    BW.Write(R.txtEX11c) : BW.Write(R.txtEX11d)
                    BW.Write(R.txtEX11e) : BW.Write(R.txtEX11f)
                    BW.Write(R.txtEX11g) : BW.Write(R.txtEX11h)
                    BW.Write(R.txtEX12a) : BW.Write(R.txtEX12b)
                    BW.Write(R.txtEX12c) : BW.Write(R.txtEX12d)
                    BW.Write(R.txtEX12e) : BW.Write(R.txtEX12f)
                    BW.Write(R.txtEX12g) : BW.Write(R.txtEX12h)
                    BW.Write(R.txtEX13a) : BW.Write(R.txtEX13b)
                    BW.Write(R.txtEX13c) : BW.Write(R.txtEX13d)
                    BW.Write(R.txtEX13e) : BW.Write(R.txtEX13f)
                    BW.Write(R.txtEX13g) : BW.Write(R.txtEX13h)
                    BW.Write(R.txtEX14a) : BW.Write(R.txtEX14b)
                    BW.Write(R.txtEX14c) : BW.Write(R.txtEX14d)
                    BW.Write(R.txtEX14e) : BW.Write(R.txtEX14f)
                    BW.Write(R.txtEX14g) : BW.Write(R.txtEX14h)
                    BW.Write(R.txtEX15a) : BW.Write(R.txtEX15b)
                    BW.Write(R.txtEX15c) : BW.Write(R.txtEX15d)
                    BW.Write(R.txtEX15e) : BW.Write(R.txtEX15f)
                    BW.Write(R.txtEX15g) : BW.Write(R.txtEX15h)
                    BW.Write(R.txtEX16a) : BW.Write(R.txtEX16b)
                    BW.Write(R.txtEX16c) : BW.Write(R.txtEX16d)
                    BW.Write(R.txtEX16e) : BW.Write(R.txtEX16f)
                    BW.Write(R.txtEX16g) : BW.Write(R.txtEX16h)
                    BW.Write(R.txtEX17a) : BW.Write(R.txtEX17b)
                    BW.Write(R.txtEX17c) : BW.Write(R.txtEX17d)
                    BW.Write(R.txtEX17e) : BW.Write(R.txtEX17f)
                    BW.Write(R.txtEX17g) : BW.Write(R.txtEX17h)
                    BW.Write(R.txtEX18a) : BW.Write(R.txtEX18b)
                    BW.Write(R.txtEX18c) : BW.Write(R.txtEX18d)
                    BW.Write(R.txtEX18e) : BW.Write(R.txtEX18f)
                    BW.Write(R.txtEX18g) : BW.Write(R.txtEX18h)
                    BW.Write(R.txtEX19a) : BW.Write(R.txtEX19b)
                    BW.Write(R.txtEX19c) : BW.Write(R.txtEX19d)
                    BW.Write(R.txtEX19e) : BW.Write(R.txtEX19f)
                    BW.Write(R.txtEX19g) : BW.Write(R.txtEX19h)
                    BW.Write(R.txtEX20a) : BW.Write(R.txtEX20b)
                    BW.Write(R.txtEX20c) : BW.Write(R.txtEX20d)
                    BW.Write(R.txtEX20e) : BW.Write(R.txtEX20f)
                    BW.Write(R.txtEX20g) : BW.Write(R.txtEX20h)

                    BW.Write(R.txtOtroEx01) : BW.Write(R.txtOtroEx02)
                    BW.Write(R.txtOtroEx03) : BW.Write(R.txtOtroEx04)
                    BW.Write(R.txtOtroEx05) : BW.Write(R.txtOtroEx06)
                    BW.Write(R.txtOtroEx07) : BW.Write(R.txtOtroEx08)

                    BW.Write(R.txtEX21a) : BW.Write(R.txtEX21b)
                    BW.Write(R.txtEX21c) : BW.Write(R.txtEX21d)
                    BW.Write(R.txtEX21e) : BW.Write(R.txtEX21f)
                    BW.Write(R.txtEX21g) : BW.Write(R.txtEX21h)
                    BW.Write(R.txtEX21i) : BW.Write(R.txtEX21j)
                    BW.Write(R.txtEX21k) : BW.Write(R.txtEX21l)

                    BW.Write(R.Adicional01) : BW.Write(R.Adicional02)
                    BW.Write(R.Adicional03) : BW.Write(R.Adicional04)


                End While
                'ahora que ya se escribieron los datos viejos al fichero incluye los que estan en pantalla al final

                R.FechaInicioControl = FechaInicioControl.ToString("s") ' formatea la fecha para el fichero
                R.PatologiaControl = labPatologia.Text

                ActualizaEstructura01ConElTexto()
                ActualizaEstructura02ConElTexto()
                ActualizaEstructura03ConElTexto()
                ActualizaEstructura04ConElTexto()
                ActualizaEstructura05ConElTexto()
                ActualizaEstructura06ConElTexto()
                ActualizaEstructura07ConElTexto()
                ActualizaEstructura08ConElTexto()
                ActualizaEstructura09ConElTexto()
                ActualizaEstructura10ConElTexto()

                ActualizaEstructurafechalabConElTexto()

                ActualizaEstructuraEX01ConElTexto()
                ActualizaEstructuraEX02ConElTexto()
                ActualizaEstructuraEX03ConElTexto()
                ActualizaEstructuraEX04ConElTexto()
                ActualizaEstructuraEX05ConElTexto()
                ActualizaEstructuraEX06ConElTexto()
                ActualizaEstructuraEX07ConElTexto()
                ActualizaEstructuraEX08ConElTexto()
                ActualizaEstructuraEX09ConElTexto()
                ActualizaEstructuraEX10ConElTexto()
                ActualizaEstructuraEX11ConElTexto()
                ActualizaEstructuraEX12ConElTexto()
                ActualizaEstructuraEX13ConElTexto()
                ActualizaEstructuraEX14ConElTexto()
                ActualizaEstructuraEX15ConElTexto()
                ActualizaEstructuraEX16ConElTexto()
                ActualizaEstructuraEX17ConElTexto()
                ActualizaEstructuraEX18ConElTexto()
                ActualizaEstructuraEX19ConElTexto()
                ActualizaEstructuraEX20ConElTexto()

                ActualizaEstructuraOTROSEXConElTexto()

                ActualizaEstructuraEX21ConElTexto()

                ActualizaEstructuraAdicional1conelExFisico()

                'ahora que ya se actualizo R con los datos en pantalla los escribo al disco
                BW.Write(R.FechaInicioControl)
                BW.Write(R.PatologiaControl)
                BW.Write(R.txt01a) : BW.Write(R.txt01b)
                BW.Write(R.txt01c) : BW.Write(R.txt01d)
                BW.Write(R.txt01e) : BW.Write(R.txt01f)
                BW.Write(R.txt01g) : BW.Write(R.txt01h)
                BW.Write(R.txt02a) : BW.Write(R.txt02b)
                BW.Write(R.txt02c) : BW.Write(R.txt02d)
                BW.Write(R.txt02e) : BW.Write(R.txt02f)
                BW.Write(R.txt02g)
                BW.Write(R.txt03a) : BW.Write(R.txt03b)
                BW.Write(R.txt03c) : BW.Write(R.txt03d)
                BW.Write(R.txt03e) : BW.Write(R.txt03f)
                BW.Write(R.txt03g)
                BW.Write(R.txt04a) : BW.Write(R.txt04b)
                BW.Write(R.txt04c) : BW.Write(R.txt04d)
                BW.Write(R.txt04e) : BW.Write(R.txt04f)
                BW.Write(R.txt04g)
                BW.Write(R.txt05a) : BW.Write(R.txt05b)
                BW.Write(R.txt05c) : BW.Write(R.txt05d)
                BW.Write(R.txt05e) : BW.Write(R.txt05f)
                BW.Write(R.txt05g)
                BW.Write(R.txt06a) : BW.Write(R.txt06b)
                BW.Write(R.txt06c) : BW.Write(R.txt06d)
                BW.Write(R.txt06e) : BW.Write(R.txt06f)
                BW.Write(R.txt06g)
                BW.Write(R.txt07a) : BW.Write(R.txt07b)
                BW.Write(R.txt07c) : BW.Write(R.txt07d)
                BW.Write(R.txt07e) : BW.Write(R.txt07f)
                BW.Write(R.txt07g)
                BW.Write(R.txt08a) : BW.Write(R.txt08b)
                BW.Write(R.txt08c) : BW.Write(R.txt08d)
                BW.Write(R.txt08e) : BW.Write(R.txt08f)
                BW.Write(R.txt08g)
                BW.Write(R.txt09a) : BW.Write(R.txt09b)
                BW.Write(R.txt09c) : BW.Write(R.txt09d)
                BW.Write(R.txt09e) : BW.Write(R.txt09f)
                BW.Write(R.txt09g)
                BW.Write(R.txt10a) : BW.Write(R.txt10b)
                BW.Write(R.txt10c) : BW.Write(R.txt10d)
                BW.Write(R.txt10e) : BW.Write(R.txt10f)
                BW.Write(R.txt10g)

                BW.Write(R.txtFechaLabA) : BW.Write(R.txtFechaLabB)
                BW.Write(R.txtFechaLabC) : BW.Write(R.txtFechaLabD)
                BW.Write(R.txtFechaLabE) : BW.Write(R.txtFechaLabF)
                BW.Write(R.txtFechaLabG) : BW.Write(R.txtFechaLabH)

                BW.Write(R.txtEX01a) : BW.Write(R.txtEX01b)
                BW.Write(R.txtEX01c) : BW.Write(R.txtEX01d)
                BW.Write(R.txtEX01e) : BW.Write(R.txtEX01f)
                BW.Write(R.txtEX01g) : BW.Write(R.txtEX01h)
                BW.Write(R.txtEX02a) : BW.Write(R.txtEX02b)
                BW.Write(R.txtEX02c) : BW.Write(R.txtEX02d)
                BW.Write(R.txtEX02e) : BW.Write(R.txtEX02f)
                BW.Write(R.txtEX02g) : BW.Write(R.txtEX02h)
                BW.Write(R.txtEX03a) : BW.Write(R.txtEX03b)
                BW.Write(R.txtEX03c) : BW.Write(R.txtEX03d)
                BW.Write(R.txtEX03e) : BW.Write(R.txtEX03f)
                BW.Write(R.txtEX03g) : BW.Write(R.txtEX03h)
                BW.Write(R.txtEX04a) : BW.Write(R.txtEX04b)
                BW.Write(R.txtEX04c) : BW.Write(R.txtEX04d)
                BW.Write(R.txtEX04e) : BW.Write(R.txtEX04f)
                BW.Write(R.txtEX04g) : BW.Write(R.txtEX04h)
                BW.Write(R.txtEX05a) : BW.Write(R.txtEX05b)
                BW.Write(R.txtEX05c) : BW.Write(R.txtEX05d)
                BW.Write(R.txtEX05e) : BW.Write(R.txtEX05f)
                BW.Write(R.txtEX05g) : BW.Write(R.txtEX05h)
                BW.Write(R.txtEX06a) : BW.Write(R.txtEX06b)
                BW.Write(R.txtEX06c) : BW.Write(R.txtEX06d)
                BW.Write(R.txtEX06e) : BW.Write(R.txtEX06f)
                BW.Write(R.txtEX06g) : BW.Write(R.txtEX06h)
                BW.Write(R.txtEX07a) : BW.Write(R.txtEX07b)
                BW.Write(R.txtEX07c) : BW.Write(R.txtEX07d)
                BW.Write(R.txtEX07e) : BW.Write(R.txtEX07f)
                BW.Write(R.txtEX07g) : BW.Write(R.txtEX07h)
                BW.Write(R.txtEX08a) : BW.Write(R.txtEX08b)
                BW.Write(R.txtEX08c) : BW.Write(R.txtEX08d)
                BW.Write(R.txtEX08e) : BW.Write(R.txtEX08f)
                BW.Write(R.txtEX08g) : BW.Write(R.txtEX08h)
                BW.Write(R.txtEX09a) : BW.Write(R.txtEX09b)
                BW.Write(R.txtEX09c) : BW.Write(R.txtEX09d)
                BW.Write(R.txtEX09e) : BW.Write(R.txtEX09f)
                BW.Write(R.txtEX09g) : BW.Write(R.txtEX09h)
                BW.Write(R.txtEX10a) : BW.Write(R.txtEX10b)
                BW.Write(R.txtEX10c) : BW.Write(R.txtEX10d)
                BW.Write(R.txtEX10e) : BW.Write(R.txtEX10f)
                BW.Write(R.txtEX10g) : BW.Write(R.txtEX10h)
                BW.Write(R.txtEX11a) : BW.Write(R.txtEX11b)
                BW.Write(R.txtEX11c) : BW.Write(R.txtEX11d)
                BW.Write(R.txtEX11e) : BW.Write(R.txtEX11f)
                BW.Write(R.txtEX11g) : BW.Write(R.txtEX11h)
                BW.Write(R.txtEX12a) : BW.Write(R.txtEX12b)
                BW.Write(R.txtEX12c) : BW.Write(R.txtEX12d)
                BW.Write(R.txtEX12e) : BW.Write(R.txtEX12f)
                BW.Write(R.txtEX12g) : BW.Write(R.txtEX12h)
                BW.Write(R.txtEX13a) : BW.Write(R.txtEX13b)
                BW.Write(R.txtEX13c) : BW.Write(R.txtEX13d)
                BW.Write(R.txtEX13e) : BW.Write(R.txtEX13f)
                BW.Write(R.txtEX13g) : BW.Write(R.txtEX13h)
                BW.Write(R.txtEX14a) : BW.Write(R.txtEX14b)
                BW.Write(R.txtEX14c) : BW.Write(R.txtEX14d)
                BW.Write(R.txtEX14e) : BW.Write(R.txtEX14f)
                BW.Write(R.txtEX14g) : BW.Write(R.txtEX14h)
                BW.Write(R.txtEX15a) : BW.Write(R.txtEX15b)
                BW.Write(R.txtEX15c) : BW.Write(R.txtEX15d)
                BW.Write(R.txtEX15e) : BW.Write(R.txtEX15f)
                BW.Write(R.txtEX15g) : BW.Write(R.txtEX15h)
                BW.Write(R.txtEX16a) : BW.Write(R.txtEX16b)
                BW.Write(R.txtEX16c) : BW.Write(R.txtEX16d)
                BW.Write(R.txtEX16e) : BW.Write(R.txtEX16f)
                BW.Write(R.txtEX16g) : BW.Write(R.txtEX16h)
                BW.Write(R.txtEX17a) : BW.Write(R.txtEX17b)
                BW.Write(R.txtEX17c) : BW.Write(R.txtEX17d)
                BW.Write(R.txtEX17e) : BW.Write(R.txtEX17f)
                BW.Write(R.txtEX17g) : BW.Write(R.txtEX17h)
                BW.Write(R.txtEX18a) : BW.Write(R.txtEX18b)
                BW.Write(R.txtEX18c) : BW.Write(R.txtEX18d)
                BW.Write(R.txtEX18e) : BW.Write(R.txtEX18f)
                BW.Write(R.txtEX18g) : BW.Write(R.txtEX18h)
                BW.Write(R.txtEX19a) : BW.Write(R.txtEX19b)
                BW.Write(R.txtEX19c) : BW.Write(R.txtEX19d)
                BW.Write(R.txtEX19e) : BW.Write(R.txtEX19f)
                BW.Write(R.txtEX19g) : BW.Write(R.txtEX19h)
                BW.Write(R.txtEX20a) : BW.Write(R.txtEX20b)
                BW.Write(R.txtEX20c) : BW.Write(R.txtEX20d)
                BW.Write(R.txtEX20e) : BW.Write(R.txtEX20f)
                BW.Write(R.txtEX20g) : BW.Write(R.txtEX20h)

                BW.Write(R.txtOtroEx01) : BW.Write(R.txtOtroEx02)
                BW.Write(R.txtOtroEx03) : BW.Write(R.txtOtroEx04)
                BW.Write(R.txtOtroEx05) : BW.Write(R.txtOtroEx06)
                BW.Write(R.txtOtroEx07) : BW.Write(R.txtOtroEx08)

                BW.Write(R.txtEX21a) : BW.Write(R.txtEX21b)
                BW.Write(R.txtEX21c) : BW.Write(R.txtEX21d)
                BW.Write(R.txtEX21e) : BW.Write(R.txtEX21f)
                BW.Write(R.txtEX21g) : BW.Write(R.txtEX21h)
                BW.Write(R.txtEX21i) : BW.Write(R.txtEX21j)
                BW.Write(R.txtEX21k) : BW.Write(R.txtEX21l)

                BW.Write(R.Adicional01) : BW.Write(R.Adicional02)
                BW.Write(R.Adicional03) : BW.Write(R.Adicional04)

                Contador += 1

                BW.Close()
                FS.Close()
                MsgBox("Se añadió una Serie de Controles Ginecológicos", MsgBoxStyle.Information)
                'modificacion para el respaldo de archivos
                Form1.SeModificaronDatos = True
            End If

            LeeContenidoControlGinecologico()
            NuevaSerie = False
            DatosNoModificados()
            'Me.DialogResult = DialogResult.OK

            botSelecciona.Enabled = False
            botElimina.Enabled = False
            botRenombraSerie.Enabled = False
            botNuevo.Enabled = True
            botGuardarNuevosDatos.Enabled = False
            botSalirSinGuardar.Enabled = True
            TabControl3.Visible = False
            TabControl1.SelectedIndex = 0
            txtFechaInicioControl.Text = "Ninguno"
            labPatologia.Text = ""
        End If
    End Sub

    Private Sub CreaControlGinecologico()

        Dim FS As FileStream
        Dim BW As BinaryWriter

        FS = New FileStream(NombreControlGinecologico, FileMode.Create, FileAccess.ReadWrite)
        BW = New BinaryWriter(FS)

        'actualiza la estructura con el contenido del texto
        ActualizaEstructura01ConElTexto()
        ActualizaEstructura02ConElTexto()
        ActualizaEstructura03ConElTexto()
        ActualizaEstructura04ConElTexto()
        ActualizaEstructura05ConElTexto()
        ActualizaEstructura06ConElTexto()
        ActualizaEstructura07ConElTexto()
        ActualizaEstructura08ConElTexto()
        ActualizaEstructura09ConElTexto()
        ActualizaEstructura10ConElTexto()

        ActualizaEstructurafechalabConElTexto()

        ActualizaEstructuraEX01ConElTexto()
        ActualizaEstructuraEX02ConElTexto()
        ActualizaEstructuraEX03ConElTexto()
        ActualizaEstructuraEX04ConElTexto()
        ActualizaEstructuraEX05ConElTexto()
        ActualizaEstructuraEX06ConElTexto()
        ActualizaEstructuraEX07ConElTexto()
        ActualizaEstructuraEX08ConElTexto()
        ActualizaEstructuraEX09ConElTexto()
        ActualizaEstructuraEX10ConElTexto()
        ActualizaEstructuraEX11ConElTexto()
        ActualizaEstructuraEX12ConElTexto()
        ActualizaEstructuraEX13ConElTexto()
        ActualizaEstructuraEX14ConElTexto()
        ActualizaEstructuraEX15ConElTexto()
        ActualizaEstructuraEX16ConElTexto()
        ActualizaEstructuraEX17ConElTexto()
        ActualizaEstructuraEX18ConElTexto()
        ActualizaEstructuraEX19ConElTexto()
        ActualizaEstructuraEX20ConElTexto()

        ActualizaEstructuraOTROSEXConElTexto()

        ActualizaEstructuraEX21ConElTexto()

        ActualizaEstructuraAdicional1conelExFisico()


        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        BW.Write(R.FechaInicioControl)
        BW.Write(R.PatologiaControl)
        BW.Write(R.txt01a) : BW.Write(R.txt01b)
        BW.Write(R.txt01c) : BW.Write(R.txt01d)
        BW.Write(R.txt01e) : BW.Write(R.txt01f)
        BW.Write(R.txt01g) : BW.Write(R.txt01h)
        BW.Write(R.txt02a) : BW.Write(R.txt02b)
        BW.Write(R.txt02c) : BW.Write(R.txt02d)
        BW.Write(R.txt02e) : BW.Write(R.txt02f)
        BW.Write(R.txt02g)
        BW.Write(R.txt03a) : BW.Write(R.txt03b)
        BW.Write(R.txt03c) : BW.Write(R.txt03d)
        BW.Write(R.txt03e) : BW.Write(R.txt03f)
        BW.Write(R.txt03g)
        BW.Write(R.txt04a) : BW.Write(R.txt04b)
        BW.Write(R.txt04c) : BW.Write(R.txt04d)
        BW.Write(R.txt04e) : BW.Write(R.txt04f)
        BW.Write(R.txt04g)
        BW.Write(R.txt05a) : BW.Write(R.txt05b)
        BW.Write(R.txt05c) : BW.Write(R.txt05d)
        BW.Write(R.txt05e) : BW.Write(R.txt05f)
        BW.Write(R.txt05g)
        BW.Write(R.txt06a) : BW.Write(R.txt06b)
        BW.Write(R.txt06c) : BW.Write(R.txt06d)
        BW.Write(R.txt06e) : BW.Write(R.txt06f)
        BW.Write(R.txt06g)
        BW.Write(R.txt07a) : BW.Write(R.txt07b)
        BW.Write(R.txt07c) : BW.Write(R.txt07d)
        BW.Write(R.txt07e) : BW.Write(R.txt07f)
        BW.Write(R.txt07g)
        BW.Write(R.txt08a) : BW.Write(R.txt08b)
        BW.Write(R.txt08c) : BW.Write(R.txt08d)
        BW.Write(R.txt08e) : BW.Write(R.txt08f)
        BW.Write(R.txt08g)
        BW.Write(R.txt09a) : BW.Write(R.txt09b)
        BW.Write(R.txt09c) : BW.Write(R.txt09d)
        BW.Write(R.txt09e) : BW.Write(R.txt09f)
        BW.Write(R.txt09g)
        BW.Write(R.txt10a) : BW.Write(R.txt10b)
        BW.Write(R.txt10c) : BW.Write(R.txt10d)
        BW.Write(R.txt10e) : BW.Write(R.txt10f)
        BW.Write(R.txt10g)

        BW.Write(R.txtFechaLabA) : BW.Write(R.txtFechaLabB)
        BW.Write(R.txtFechaLabC) : BW.Write(R.txtFechaLabD)
        BW.Write(R.txtFechaLabE) : BW.Write(R.txtFechaLabF)
        BW.Write(R.txtFechaLabG) : BW.Write(R.txtFechaLabH)

        BW.Write(R.txtEX01a) : BW.Write(R.txtEX01b)
        BW.Write(R.txtEX01c) : BW.Write(R.txtEX01d)
        BW.Write(R.txtEX01e) : BW.Write(R.txtEX01f)
        BW.Write(R.txtEX01g) : BW.Write(R.txtEX01h)
        BW.Write(R.txtEX02a) : BW.Write(R.txtEX02b)
        BW.Write(R.txtEX02c) : BW.Write(R.txtEX02d)
        BW.Write(R.txtEX02e) : BW.Write(R.txtEX02f)
        BW.Write(R.txtEX02g) : BW.Write(R.txtEX02h)
        BW.Write(R.txtEX03a) : BW.Write(R.txtEX03b)
        BW.Write(R.txtEX03c) : BW.Write(R.txtEX03d)
        BW.Write(R.txtEX03e) : BW.Write(R.txtEX03f)
        BW.Write(R.txtEX03g) : BW.Write(R.txtEX03h)
        BW.Write(R.txtEX04a) : BW.Write(R.txtEX04b)
        BW.Write(R.txtEX04c) : BW.Write(R.txtEX04d)
        BW.Write(R.txtEX04e) : BW.Write(R.txtEX04f)
        BW.Write(R.txtEX04g) : BW.Write(R.txtEX04h)
        BW.Write(R.txtEX05a) : BW.Write(R.txtEX05b)
        BW.Write(R.txtEX05c) : BW.Write(R.txtEX05d)
        BW.Write(R.txtEX05e) : BW.Write(R.txtEX05f)
        BW.Write(R.txtEX05g) : BW.Write(R.txtEX05h)
        BW.Write(R.txtEX06a) : BW.Write(R.txtEX06b)
        BW.Write(R.txtEX06c) : BW.Write(R.txtEX06d)
        BW.Write(R.txtEX06e) : BW.Write(R.txtEX06f)
        BW.Write(R.txtEX06g) : BW.Write(R.txtEX06h)
        BW.Write(R.txtEX07a) : BW.Write(R.txtEX07b)
        BW.Write(R.txtEX07c) : BW.Write(R.txtEX07d)
        BW.Write(R.txtEX07e) : BW.Write(R.txtEX07f)
        BW.Write(R.txtEX07g) : BW.Write(R.txtEX07h)
        BW.Write(R.txtEX08a) : BW.Write(R.txtEX08b)
        BW.Write(R.txtEX08c) : BW.Write(R.txtEX08d)
        BW.Write(R.txtEX08e) : BW.Write(R.txtEX08f)
        BW.Write(R.txtEX08g) : BW.Write(R.txtEX08h)
        BW.Write(R.txtEX09a) : BW.Write(R.txtEX09b)
        BW.Write(R.txtEX09c) : BW.Write(R.txtEX09d)
        BW.Write(R.txtEX09e) : BW.Write(R.txtEX09f)
        BW.Write(R.txtEX09g) : BW.Write(R.txtEX09h)
        BW.Write(R.txtEX10a) : BW.Write(R.txtEX10b)
        BW.Write(R.txtEX10c) : BW.Write(R.txtEX10d)
        BW.Write(R.txtEX10e) : BW.Write(R.txtEX10f)
        BW.Write(R.txtEX10g) : BW.Write(R.txtEX10h)
        BW.Write(R.txtEX11a) : BW.Write(R.txtEX11b)
        BW.Write(R.txtEX11c) : BW.Write(R.txtEX11d)
        BW.Write(R.txtEX11e) : BW.Write(R.txtEX11f)
        BW.Write(R.txtEX11g) : BW.Write(R.txtEX11h)
        BW.Write(R.txtEX12a) : BW.Write(R.txtEX12b)
        BW.Write(R.txtEX12c) : BW.Write(R.txtEX12d)
        BW.Write(R.txtEX12e) : BW.Write(R.txtEX12f)
        BW.Write(R.txtEX12g) : BW.Write(R.txtEX12h)
        BW.Write(R.txtEX13a) : BW.Write(R.txtEX13b)
        BW.Write(R.txtEX13c) : BW.Write(R.txtEX13d)
        BW.Write(R.txtEX13e) : BW.Write(R.txtEX13f)
        BW.Write(R.txtEX13g) : BW.Write(R.txtEX13h)
        BW.Write(R.txtEX14a) : BW.Write(R.txtEX14b)
        BW.Write(R.txtEX14c) : BW.Write(R.txtEX14d)
        BW.Write(R.txtEX14e) : BW.Write(R.txtEX14f)
        BW.Write(R.txtEX14g) : BW.Write(R.txtEX14h)
        BW.Write(R.txtEX15a) : BW.Write(R.txtEX15b)
        BW.Write(R.txtEX15c) : BW.Write(R.txtEX15d)
        BW.Write(R.txtEX15e) : BW.Write(R.txtEX15f)
        BW.Write(R.txtEX15g) : BW.Write(R.txtEX15h)
        BW.Write(R.txtEX16a) : BW.Write(R.txtEX16b)
        BW.Write(R.txtEX16c) : BW.Write(R.txtEX16d)
        BW.Write(R.txtEX16e) : BW.Write(R.txtEX16f)
        BW.Write(R.txtEX16g) : BW.Write(R.txtEX16h)
        BW.Write(R.txtEX17a) : BW.Write(R.txtEX17b)
        BW.Write(R.txtEX17c) : BW.Write(R.txtEX17d)
        BW.Write(R.txtEX17e) : BW.Write(R.txtEX17f)
        BW.Write(R.txtEX17g) : BW.Write(R.txtEX17h)
        BW.Write(R.txtEX18a) : BW.Write(R.txtEX18b)
        BW.Write(R.txtEX18c) : BW.Write(R.txtEX18d)
        BW.Write(R.txtEX18e) : BW.Write(R.txtEX18f)
        BW.Write(R.txtEX18g) : BW.Write(R.txtEX18h)
        BW.Write(R.txtEX19a) : BW.Write(R.txtEX19b)
        BW.Write(R.txtEX19c) : BW.Write(R.txtEX19d)
        BW.Write(R.txtEX19e) : BW.Write(R.txtEX19f)
        BW.Write(R.txtEX19g) : BW.Write(R.txtEX19h)
        BW.Write(R.txtEX20a) : BW.Write(R.txtEX20b)
        BW.Write(R.txtEX20c) : BW.Write(R.txtEX20d)
        BW.Write(R.txtEX20e) : BW.Write(R.txtEX20f)
        BW.Write(R.txtEX20g) : BW.Write(R.txtEX20h)

        BW.Write(R.txtOtroEx01) : BW.Write(R.txtOtroEx02)
        BW.Write(R.txtOtroEx03) : BW.Write(R.txtOtroEx04)
        BW.Write(R.txtOtroEx05) : BW.Write(R.txtOtroEx06)
        BW.Write(R.txtOtroEx07) : BW.Write(R.txtOtroEx08)

        BW.Write(R.txtEX21a) : BW.Write(R.txtEX21b)
        BW.Write(R.txtEX21c) : BW.Write(R.txtEX21d)
        BW.Write(R.txtEX21e) : BW.Write(R.txtEX21f)
        BW.Write(R.txtEX21g) : BW.Write(R.txtEX21h)
        BW.Write(R.txtEX21i) : BW.Write(R.txtEX21j)
        BW.Write(R.txtEX21k) : BW.Write(R.txtEX21l)

        BW.Write(R.Adicional01) : BW.Write(R.Adicional02)
        BW.Write(R.Adicional03) : BW.Write(R.Adicional04)


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

        LineaDatos = Form1.PSstrNumeroHistoriaSeleccionada & "-Control Ginecológico"
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


    Private Sub botSalirSinGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botSalirSinGuardar.Click
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

    'eventos de interaccion del usuario
    Private Sub CalculaEGdeFecha()
        Dim EG As Integer
        'Dim Semanas, Dias As Integer
        'Dim Calculo As Double
        Dim FUR, Fecha As Date

        'si las dos fechas son correctas
        FUR = FechaFURparaCalculo
        Fecha = FechaParaVerificar
        EG = (DateDiff(DateInterval.Day, FUR, Fecha)) + 1
        If EG <= 0 Then
            DiaDelCiclo = "??"
        ElseIf EG > 365 Then
            DiaDelCiclo = "Menopausia"
        Else
            DiaDelCiclo = EG
        End If

    End Sub

    Private Sub botFUR01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR01.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de la Ultima Regla..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt01b.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR01()
    End Sub

    Private Sub ProcesaFUR01()
        If IsDate(txt01a.Text) = True And IsDate(txt01b.Text) = True Then
            'si las dos fechas son validas...
            FechaParaVerificar = txt01a.Text
            FechaFURparaCalculo = txt01b.Text
            'calcula la diferencia
            CalculaEGdeFecha()
            'obtuvo la variable dia del ciclo que tiene el dato
            txtDC01.Text = DiaDelCiclo
        Else
            'si alguna no es valida
            txtDC01.Text = ""
        End If
    End Sub

    Private Sub botFecha02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFecha02.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha del Control..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt02a.Text = Form1.FechaSeleccionada
            labTab02.BackColor = Color.Gold
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR02()
    End Sub

    Private Sub botFUR02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR02.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de la Ultima Regla..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt02b.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR02()
    End Sub

    Private Sub ProcesaFUR02()
        If IsDate(txt02a.Text) = True And IsDate(txt02b.Text) = True Then
            'si las dos fechas son validas...
            FechaParaVerificar = txt02a.Text
            FechaFURparaCalculo = txt02b.Text
            'calcula la diferencia
            CalculaEGdeFecha()
            'obtuvo la variable dia del ciclo que tiene el dato
            txtDC02.Text = DiaDelCiclo
        Else
            'si alguna no es valida
            txtDC02.Text = ""
        End If
    End Sub

    'FUR03
    Private Sub botFecha03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFecha03.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha del Control..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt03a.Text = Form1.FechaSeleccionada
            labTab03.BackColor = Color.Gold
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR03()
    End Sub

    Private Sub botFUR03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR03.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de la Ultima Regla..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt03b.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR03()
    End Sub

    Private Sub ProcesaFUR03()
        If IsDate(txt03a.Text) = True And IsDate(txt03b.Text) = True Then
            'si las dos fechas son validas...
            FechaParaVerificar = txt03a.Text
            FechaFURparaCalculo = txt03b.Text
            'calcula la diferencia
            CalculaEGdeFecha()
            'obtuvo la variable dia del ciclo que tiene el dato
            txtDC03.Text = DiaDelCiclo
        Else
            'si alguna no es valida
            txtDC03.Text = ""
        End If
    End Sub

    'FUR04
    Private Sub botFecha04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFecha04.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha del Control..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt04a.Text = Form1.FechaSeleccionada
            labTab04.BackColor = Color.Gold
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR04()
    End Sub

    Private Sub botFUR04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR04.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de la Ultima Regla..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt04b.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR04()
    End Sub

    Private Sub ProcesaFUR04()
        If IsDate(txt04a.Text) = True And IsDate(txt04b.Text) = True Then
            'si las dos fechas son validas...
            FechaParaVerificar = txt04a.Text
            FechaFURparaCalculo = txt04b.Text
            'calcula la diferencia
            CalculaEGdeFecha()
            'obtuvo la variable dia del ciclo que tiene el dato
            txtDC04.Text = DiaDelCiclo
        Else
            'si alguna no es valida
            txtDC04.Text = ""
        End If
    End Sub

    'FUR05
    Private Sub botFecha05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFecha05.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha del Control..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt05a.Text = Form1.FechaSeleccionada
            labTab05.BackColor = Color.Gold
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR05()
    End Sub

    Private Sub botFUR05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR05.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de la Ultima Regla..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt05b.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR05()
    End Sub

    Private Sub ProcesaFUR05()
        If IsDate(txt05a.Text) = True And IsDate(txt05b.Text) = True Then
            'si las dos fechas son validas...
            FechaParaVerificar = txt05a.Text
            FechaFURparaCalculo = txt05b.Text
            'calcula la diferencia
            CalculaEGdeFecha()
            'obtuvo la variable dia del ciclo que tiene el dato
            txtDC05.Text = DiaDelCiclo
        Else
            'si alguna no es valida
            txtDC05.Text = ""
        End If
    End Sub

    'FUR06
    Private Sub botFecha06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFecha06.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha del Control..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt06a.Text = Form1.FechaSeleccionada
            labTab06.BackColor = Color.Gold
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR06()
    End Sub

    Private Sub botFUR06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR06.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de la Ultima Regla..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt06b.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR06()
    End Sub

    Private Sub ProcesaFUR06()
        If IsDate(txt06a.Text) = True And IsDate(txt06b.Text) = True Then
            'si las dos fechas son validas...
            FechaParaVerificar = txt06a.Text
            FechaFURparaCalculo = txt06b.Text
            'calcula la diferencia
            CalculaEGdeFecha()
            'obtuvo la variable dia del ciclo que tiene el dato
            txtDC06.Text = DiaDelCiclo
        Else
            'si alguna no es valida
            txtDC06.Text = ""
        End If
    End Sub

    'FUR07
    Private Sub botFecha07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFecha07.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha del Control..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt07a.Text = Form1.FechaSeleccionada
            labTab07.BackColor = Color.Gold
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR07()
    End Sub

    Private Sub botFUR07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR07.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de la Ultima Regla..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt07b.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR07()
    End Sub

    Private Sub ProcesaFUR07()
        If IsDate(txt07a.Text) = True And IsDate(txt07b.Text) = True Then
            'si las dos fechas son validas...
            FechaParaVerificar = txt07a.Text
            FechaFURparaCalculo = txt07b.Text
            'calcula la diferencia
            CalculaEGdeFecha()
            'obtuvo la variable dia del ciclo que tiene el dato
            txtDC07.Text = DiaDelCiclo
        Else
            'si alguna no es valida
            txtDC07.Text = ""
        End If
    End Sub

    'FUR08
    Private Sub botFecha08_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFecha08.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha del Control..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt08a.Text = Form1.FechaSeleccionada
            labTab08.BackColor = Color.Gold
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR08()
    End Sub

    Private Sub botFUR08_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR08.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de la Ultima Regla..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt08b.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR08()
    End Sub

    Private Sub ProcesaFUR08()
        If IsDate(txt08a.Text) = True And IsDate(txt08b.Text) = True Then
            'si las dos fechas son validas...
            FechaParaVerificar = txt08a.Text
            FechaFURparaCalculo = txt08b.Text
            'calcula la diferencia
            CalculaEGdeFecha()
            'obtuvo la variable dia del ciclo que tiene el dato
            txtDC08.Text = DiaDelCiclo
        Else
            'si alguna no es valida
            txtDC08.Text = ""
        End If
    End Sub

    'FUR09
    Private Sub botFecha09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFecha09.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha del Control..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt09a.Text = Form1.FechaSeleccionada
            labTab09.BackColor = Color.Gold
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR09()
    End Sub

    Private Sub botFUR09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR09.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de la Ultima Regla..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt09b.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR09()
    End Sub

    Private Sub ProcesaFUR09()
        If IsDate(txt09a.Text) = True And IsDate(txt09b.Text) = True Then
            'si las dos fechas son validas...
            FechaParaVerificar = txt09a.Text
            FechaFURparaCalculo = txt09b.Text
            'calcula la diferencia
            CalculaEGdeFecha()
            'obtuvo la variable dia del ciclo que tiene el dato
            txtDC09.Text = DiaDelCiclo
        Else
            'si alguna no es valida
            txtDC09.Text = ""
        End If
    End Sub

    'FUR10
    Private Sub botFecha10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFecha10.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha del Control..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt10a.Text = Form1.FechaSeleccionada
            labTab10.BackColor = Color.Gold
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR10()
    End Sub

    Private Sub botFUR10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFUR10.Click
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de la Ultima Regla..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt10b.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'ahora procesa la fur con los nuevos datos (o los viejos...)
        ProcesaFUR10()
    End Sub

    Private Sub ProcesaFUR10()
        If IsDate(txt10a.Text) = True And IsDate(txt10b.Text) = True Then
            'si las dos fechas son validas...
            FechaParaVerificar = txt10a.Text
            FechaFURparaCalculo = txt10b.Text
            'calcula la diferencia
            CalculaEGdeFecha()
            'obtuvo la variable dia del ciclo que tiene el dato
            txtDC10.Text = DiaDelCiclo
        Else
            'si alguna no es valida
            txtDC10.Text = ""
        End If
    End Sub

    'botones de examen fisico
    Private Sub botEF01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEF01.Click
        Dim DLG As New FormExamenFisicoGinecologico()
        Form1.ExamenFisicoCodificado = EF(1)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'actualiza el chorizo de datos
            EF(1) = Form1.ExamenFisicoCodificado
            'presenta datos en la ventana de examen fisico
            txt01h.Text = Form1.ExamenFisicoTraducido
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub botEF02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEF02.Click
        Dim DLG As New FormExamenFisicoGinecologico()
        Form1.ExamenFisicoCodificado = EF(2)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'actualiza el chorizo de datos
            EF(2) = Form1.ExamenFisicoCodificado
            'presenta datos en la ventana de examen fisico
            txt02g.Text = Form1.ExamenFisicoTraducido
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub botEF03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEF03.Click
        Dim DLG As New FormExamenFisicoGinecologico()
        Form1.ExamenFisicoCodificado = EF(3)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            EF(3) = Form1.ExamenFisicoCodificado
            'presenta datos en la ventana de examen fisico
            txt03g.Text = Form1.ExamenFisicoTraducido
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub botEF04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEF04.Click
        Dim DLG As New FormExamenFisicoGinecologico()
        Form1.ExamenFisicoCodificado = EF(4)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            EF(4) = Form1.ExamenFisicoCodificado
            'presenta datos en la ventana de examen fisico
            txt04g.Text = Form1.ExamenFisicoTraducido
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub botEF05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEF05.Click
        Dim DLG As New FormExamenFisicoGinecologico()
        Form1.ExamenFisicoCodificado = EF(5)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            EF(5) = Form1.ExamenFisicoCodificado
            'presenta datos en la ventana de examen fisico
            txt05g.Text = Form1.ExamenFisicoTraducido
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub botEF06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEF06.Click
        Dim DLG As New FormExamenFisicoGinecologico()
        Form1.ExamenFisicoCodificado = EF(6)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            EF(6) = Form1.ExamenFisicoCodificado
            'presenta datos en la ventana de examen fisico
            txt06g.Text = Form1.ExamenFisicoTraducido
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub botEF07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEF07.Click
        Dim DLG As New FormExamenFisicoGinecologico()
        Form1.ExamenFisicoCodificado = EF(7)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            EF(7) = Form1.ExamenFisicoCodificado
            'presenta datos en la ventana de examen fisico
            txt07g.Text = Form1.ExamenFisicoTraducido
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub botEF08_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEF08.Click
        Dim DLG As New FormExamenFisicoGinecologico()
        Form1.ExamenFisicoCodificado = EF(8)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            EF(8) = Form1.ExamenFisicoCodificado
            'presenta datos en la ventana de examen fisico
            txt08g.Text = Form1.ExamenFisicoTraducido
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub botEF09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEF09.Click
        Dim DLG As New FormExamenFisicoGinecologico()
        Form1.ExamenFisicoCodificado = EF(9)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            EF(9) = Form1.ExamenFisicoCodificado
            'presenta datos en la ventana de examen fisico
            txt09g.Text = Form1.ExamenFisicoTraducido
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub botEF10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botEF10.Click
        Dim DLG As New FormExamenFisicoGinecologico()
        Form1.ExamenFisicoCodificado = EF(10)
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            EF(10) = Form1.ExamenFisicoCodificado
            'presenta datos en la ventana de examen fisico
            txt10g.Text = Form1.ExamenFisicoTraducido
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'eventos graficos de los botones

    Private Sub botNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botNuevo.MouseEnter
        botNuevo.Image = BotonOnGrande
    End Sub
    Private Sub botNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botNuevo.MouseLeave
        botNuevo.Image = BotonOffGrande
    End Sub

    Private Sub botRenombra_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRenombraSerie.MouseEnter
        botRenombraSerie.Image = BotonOnGrande
    End Sub
    Private Sub botRenombra_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botRenombraSerie.MouseLeave
        botRenombraSerie.Image = BotonOffGrande
    End Sub

    Private Sub botElimina_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botElimina.MouseEnter
        botElimina.Image = BotonOnGrande
    End Sub
    Private Sub botElimina_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botElimina.MouseLeave
        botElimina.Image = BotonOffGrande
    End Sub

    Private Sub botSelecciona_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSelecciona.MouseEnter
        botSelecciona.Image = BotonOnGrande
    End Sub
    Private Sub botSelecciona_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSelecciona.MouseLeave
        botSelecciona.Image = BotonOffGrande
    End Sub

    Private Sub botSalirSinGuardar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSalirSinGuardar.MouseEnter
        botSalirSinGuardar.Image = BotonOnGrande
    End Sub
    Private Sub botSalirSinGuardar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botSalirSinGuardar.MouseLeave
        botSalirSinGuardar.Image = BotonOffGrande
    End Sub

    Private Sub botGuardarNuevosDatos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botGuardarNuevosDatos.MouseEnter
        botGuardarNuevosDatos.Image = BotonOnGrande
    End Sub
    Private Sub botGuardarNuevosDatos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botGuardarNuevosDatos.MouseLeave
        botGuardarNuevosDatos.Image = BotonOffGrande
    End Sub

    Private Sub botEF01_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF01.MouseEnter
        botEF01.Image = BotonOnGrande
    End Sub
    Private Sub botEF01_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF01.MouseLeave
        botEF01.Image = BotonOffGrande
    End Sub
    Private Sub botEF02_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF02.MouseEnter
        botEF02.Image = BotonOnGrande
    End Sub
    Private Sub botEF02_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF02.MouseLeave
        botEF02.Image = BotonOffGrande
    End Sub
    Private Sub botEF03_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF03.MouseEnter
        botEF03.Image = BotonOnGrande
    End Sub
    Private Sub botEF03_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF03.MouseLeave
        botEF03.Image = BotonOffGrande
    End Sub
    Private Sub botEF04_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF04.MouseEnter
        botEF04.Image = BotonOnGrande
    End Sub
    Private Sub botEF04_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF04.MouseLeave
        botEF04.Image = BotonOffGrande
    End Sub
    Private Sub botEF05_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF05.MouseEnter
        botEF05.Image = BotonOnGrande
    End Sub
    Private Sub botEF05_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF05.MouseLeave
        botEF05.Image = BotonOffGrande
    End Sub
    Private Sub botEF06_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF06.MouseEnter
        botEF06.Image = BotonOnGrande
    End Sub
    Private Sub botEF06_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF06.MouseLeave
        botEF06.Image = BotonOffGrande
    End Sub
    Private Sub botEF07_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF07.MouseEnter
        botEF07.Image = BotonOnGrande
    End Sub
    Private Sub botEF07_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF07.MouseLeave
        botEF07.Image = BotonOffGrande
    End Sub
    Private Sub botEF08_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF08.MouseEnter
        botEF08.Image = BotonOnGrande
    End Sub
    Private Sub botEF08_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF08.MouseLeave
        botEF08.Image = BotonOffGrande
    End Sub
    Private Sub botEF09_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF09.MouseEnter
        botEF09.Image = BotonOnGrande
    End Sub
    Private Sub botEF09_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF09.MouseLeave
        botEF09.Image = BotonOffGrande
    End Sub
    Private Sub botEF10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF10.MouseEnter
        botEF10.Image = BotonOnGrande
    End Sub
    Private Sub botEF10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botEF10.MouseLeave
        botEF10.Image = BotonOffGrande
    End Sub

    Private Sub botFUR01_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR01.MouseEnter
        botFUR01.Image = BotonOn
    End Sub
    Private Sub botFUR01_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR01.MouseLeave
        botFUR01.Image = BotonOff
    End Sub

    Private Sub botFUR02_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR02.MouseEnter
        botFUR02.Image = BotonOn
    End Sub
    Private Sub botFUR02_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR02.MouseLeave
        botFUR02.Image = BotonOff
    End Sub
    Private Sub botFecha02_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha02.MouseEnter
        botFecha02.Image = BotonOn
    End Sub
    Private Sub botFecha02_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha02.MouseLeave
        botFecha02.Image = BotonOff
    End Sub

    Private Sub botFUR03_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR03.MouseEnter
        botFUR03.Image = BotonOn
    End Sub
    Private Sub botFUR03_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR03.MouseLeave
        botFUR03.Image = BotonOff
    End Sub
    Private Sub botFecha03_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha03.MouseEnter
        botFecha03.Image = BotonOn
    End Sub
    Private Sub botFecha03_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha03.MouseLeave
        botFecha03.Image = BotonOff
    End Sub

    Private Sub botFUR04_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR04.MouseEnter
        botFUR04.Image = BotonOn
    End Sub
    Private Sub botFUR04_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR04.MouseLeave
        botFUR04.Image = BotonOff
    End Sub
    Private Sub botFecha04_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha04.MouseEnter
        botFecha04.Image = BotonOn
    End Sub
    Private Sub botFecha04_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha04.MouseLeave
        botFecha04.Image = BotonOff
    End Sub

    Private Sub botFUR05_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR05.MouseEnter
        botFUR05.Image = BotonOn
    End Sub
    Private Sub botFUR05_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR05.MouseLeave
        botFUR05.Image = BotonOff
    End Sub
    Private Sub botFecha05_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha05.MouseEnter
        botFecha05.Image = BotonOn
    End Sub
    Private Sub botFecha05_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha05.MouseLeave
        botFecha05.Image = BotonOff
    End Sub

    Private Sub botFUR06_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR06.MouseEnter
        botFUR06.Image = BotonOn
    End Sub
    Private Sub botFUR06_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR06.MouseLeave
        botFUR06.Image = BotonOff
    End Sub
    Private Sub botFecha06_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha06.MouseEnter
        botFecha06.Image = BotonOn
    End Sub
    Private Sub botFecha06_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha06.MouseLeave
        botFecha06.Image = BotonOff
    End Sub

    Private Sub botFUR07_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR07.MouseEnter
        botFUR07.Image = BotonOn
    End Sub
    Private Sub botFUR07_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR07.MouseLeave
        botFUR07.Image = BotonOff
    End Sub
    Private Sub botFecha07_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha07.MouseEnter
        botFecha07.Image = BotonOn
    End Sub
    Private Sub botFecha07_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha07.MouseLeave
        botFecha07.Image = BotonOff
    End Sub

    Private Sub botFUR08_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR08.MouseEnter
        botFUR08.Image = BotonOn
    End Sub
    Private Sub botFUR08_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR08.MouseLeave
        botFUR08.Image = BotonOff
    End Sub
    Private Sub botFecha08_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha08.MouseEnter
        botFecha08.Image = BotonOn
    End Sub
    Private Sub botFecha08_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha08.MouseLeave
        botFecha08.Image = BotonOff
    End Sub

    Private Sub botFUR09_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR09.MouseEnter
        botFUR09.Image = BotonOn
    End Sub
    Private Sub botFUR09_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR09.MouseLeave
        botFUR09.Image = BotonOff
    End Sub
    Private Sub botFecha09_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha09.MouseEnter
        botFecha09.Image = BotonOn
    End Sub
    Private Sub botFecha09_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha09.MouseLeave
        botFecha09.Image = BotonOff
    End Sub

    Private Sub botFUR10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR10.MouseEnter
        botFUR10.Image = BotonOn
    End Sub
    Private Sub botFUR10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFUR10.MouseLeave
        botFUR10.Image = BotonOff
    End Sub
    Private Sub botFecha10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha10.MouseEnter
        botFecha10.Image = BotonOn
    End Sub
    Private Sub botFecha10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles botFecha10.MouseLeave
        botFecha10.Image = BotonOff
    End Sub

    Private Sub botCreaRestablecInforme_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCreaRestableceInforme.MouseEnter
        botCreaRestableceInforme.Image = BotonOn
    End Sub
    Private Sub botCreaRestablecInforme_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCreaRestableceInforme.MouseLeave
        botCreaRestableceInforme.Image = BotonOff
    End Sub
    Private Sub botImprimeInforme_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImprimeInforme.MouseEnter
        botImprimeInforme.Image = BotonOn
    End Sub
    Private Sub botImprimeInforme_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImprimeInforme.MouseLeave
        botImprimeInforme.Image = BotonOff
    End Sub



    Private Sub botpersonaliza_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.MouseEnter
        botPersonaliza.Image = BotonOn
    End Sub
    Private Sub botPersonaliza_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botPersonaliza.MouseLeave
        botPersonaliza.Image = BotonOff
    End Sub

    'personalizacion de informes
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

    '00000000000000000000000000000
    'eventos de cambio en las diferentes casillas


    'texto
    Private Sub txtTexto01_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt01c.KeyPress, txt01d.KeyPress, txt01e.KeyPress, _
                txt01f.KeyPress, txt01g.KeyPress
        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If
    End Sub

    'texto
    Private Sub txtTexto02_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt02c.KeyPress, txt02d.KeyPress, txt02e.KeyPress, _
                txt02f.KeyPress
        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If
    End Sub

    'texto
    Private Sub txtTexto03_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt03c.KeyPress, txt03d.KeyPress, txt03e.KeyPress, _
                txt03f.KeyPress
        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If
    End Sub

    'texto
    Private Sub txtTexto04_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt04c.KeyPress, txt04d.KeyPress, txt04e.KeyPress, _
                txt04f.KeyPress
        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If
    End Sub

    'texto
    Private Sub txtTexto05_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt05c.KeyPress, txt05d.KeyPress, txt05e.KeyPress, _
                txt05f.KeyPress
        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If
    End Sub

    'texto
    Private Sub txtTexto06_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt06c.KeyPress, txt06d.KeyPress, txt06e.KeyPress, _
                txt06f.KeyPress
        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If
    End Sub

    'texto
    Private Sub txtTexto07_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt07c.KeyPress, txt07d.KeyPress, txt07e.KeyPress, _
                txt07f.KeyPress
        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If
    End Sub

    'texto
    Private Sub txtTexto08_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt08c.KeyPress, txt08d.KeyPress, txt08e.KeyPress, _
                txt08f.KeyPress
        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If
    End Sub

    'texto
    Private Sub txtTexto09_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt09c.KeyPress, txt09d.KeyPress, txt09e.KeyPress, _
                txt09f.KeyPress
        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If
    End Sub

    'texto
    Private Sub txtTexto10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles txt10c.KeyPress, txt10d.KeyPress, txt10e.KeyPress, _
                txt10f.KeyPress
        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If
    End Sub

    'hemoglobina: digitos y punto la g y la r y esp y %
    Private Sub txtEX01_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX01a.KeyPress, txtEX01b.KeyPress, txtEX01c.KeyPress, _
               txtEX01d.KeyPress, txtEX01e.KeyPress, txtEX01f.KeyPress, _
               txtEX01g.KeyPress, txtEX01h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "g" Or c = "r" Or c = " " Or c = "%") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Hematocrito: digitos , punto y el % y esp
    Private Sub txtEX02_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX02a.KeyPress, txtEX02b.KeyPress, txtEX02c.KeyPress, _
               txtEX02d.KeyPress, txtEX02e.KeyPress, txtEX02f.KeyPress, _
               txtEX02g.KeyPress, txtEX02h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "%" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Globulos blanco: digitos y punto 
    Private Sub txtEX03_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX03a.KeyPress, txtEX03b.KeyPress, txtEX03c.KeyPress, _
               txtEX03d.KeyPress, txtEX03e.KeyPress, txtEX03f.KeyPress, _
               txtEX03g.KeyPress, txtEX03h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = ".") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Neutrofilos: digitos , punto y % y esp
    Private Sub txtEX04_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX04a.KeyPress, txtEX04b.KeyPress, txtEX04c.KeyPress, _
               txtEX04d.KeyPress, txtEX04e.KeyPress, txtEX04f.KeyPress, _
               txtEX04g.KeyPress, txtEX04h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "%" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Linfocitos: digitos , punto y % y esp
    Private Sub txtEX05_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX05a.KeyPress, txtEX05b.KeyPress, txtEX05c.KeyPress, _
               txtEX05d.KeyPress, txtEX05e.KeyPress, txtEX05f.KeyPress, _
               txtEX05g.KeyPress, txtEX05h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "%" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Monocitos: digitos , punto y % y esp
    Private Sub txtEX06_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX06a.KeyPress, txtEX06b.KeyPress, txtEX06c.KeyPress, _
               txtEX06d.KeyPress, txtEX06e.KeyPress, txtEX06f.KeyPress, _
               txtEX06g.KeyPress, txtEX06h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "%" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Plaquetas: digitos y punto
    Private Sub txtEX07_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX07a.KeyPress, txtEX07b.KeyPress, txtEX07c.KeyPress, _
               txtEX07d.KeyPress, txtEX07e.KeyPress, txtEX07f.KeyPress, _
               txtEX07g.KeyPress, txtEX07h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = ".") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'PT: digitos , punto, ' , c , : , / y esp
    Private Sub txtEX08_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX08a.KeyPress, txtEX08b.KeyPress, txtEX08c.KeyPress, _
               txtEX08d.KeyPress, txtEX08e.KeyPress, txtEX08f.KeyPress, _
               txtEX08g.KeyPress, txtEX08h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "'" Or c = "c" Or c = ":" Or c = "/" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'PTT: digitos , punto, ' , c , : , / y esp
    Private Sub txtEX09_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX09a.KeyPress, txtEX09b.KeyPress, txtEX09c.KeyPress, _
               txtEX09d.KeyPress, txtEX09e.KeyPress, txtEX09f.KeyPress, _
               txtEX09g.KeyPress, txtEX09h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "'" Or c = "c" Or c = ":" Or c = "/" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Glicemia: digitos , punto, m , g , % y esp
    Private Sub txtEX10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX10a.KeyPress, txtEX10b.KeyPress, txtEX10c.KeyPress, _
               txtEX10d.KeyPress, txtEX10e.KeyPress, txtEX10f.KeyPress, _
               txtEX10g.KeyPress, txtEX10h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "m" Or c = "g" Or c = "%" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Creatinina: digitos , punto, m , g , % y esp
    Private Sub txtEX11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX11a.KeyPress, txtEX11b.KeyPress, txtEX11c.KeyPress, _
               txtEX11d.KeyPress, txtEX11e.KeyPress, txtEX11f.KeyPress, _
               txtEX11g.KeyPress, txtEX11h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "m" Or c = "g" Or c = "%" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'VDRL: + , -
    Private Sub txtEX12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX12a.KeyPress, txtEX12b.KeyPress, txtEX12c.KeyPress, _
               txtEX12d.KeyPress, txtEX12e.KeyPress, txtEX12f.KeyPress, _
               txtEX12g.KeyPress, txtEX12h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or c = "+" Or c = "-") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'HIV: + , -
    Private Sub txtEX13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX13a.KeyPress, txtEX13b.KeyPress, txtEX13c.KeyPress, _
               txtEX13d.KeyPress, txtEX13e.KeyPress, txtEX13f.KeyPress, _
               txtEX13g.KeyPress, txtEX13h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or c = "+" Or c = "-") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'FSH: digitos , punto, m , c , g , % y esp
    Private Sub txtEX14_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX14a.KeyPress, txtEX14b.KeyPress, txtEX14c.KeyPress, _
               txtEX14d.KeyPress, txtEX14e.KeyPress, txtEX14f.KeyPress, _
               txtEX14g.KeyPress, txtEX14h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "m" Or c = "c" Or c = "g" Or c = "%" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'LH: digitos , punto, m , c , g , % y esp
    Private Sub txtEX15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX15a.KeyPress, txtEX15b.KeyPress, txtEX15c.KeyPress, _
               txtEX15d.KeyPress, txtEX15e.KeyPress, txtEX15f.KeyPress, _
               txtEX15g.KeyPress, txtEX15h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "m" Or c = "c" Or c = "g" Or c = "%" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Estradiol: digitos , punto, m , c , g , % y esp
    Private Sub txtEX16_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX16a.KeyPress, txtEX16b.KeyPress, txtEX16c.KeyPress, _
               txtEX16d.KeyPress, txtEX16e.KeyPress, txtEX16f.KeyPress, _
               txtEX16g.KeyPress, txtEX16h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "m" Or c = "c" Or c = "g" Or c = "%" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Progesterona: digitos , punto, m , c , g , % y esp
    Private Sub txtEX17_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX17a.KeyPress, txtEX17b.KeyPress, txtEX17c.KeyPress, _
               txtEX17d.KeyPress, txtEX17e.KeyPress, txtEX17f.KeyPress, _
               txtEX17g.KeyPress, txtEX17h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = "." Or c = "m" Or c = "c" Or c = "g" Or c = "%" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Otros01: digitos , punto, ' , m , g , c , : , / , % , + , - , esp
    Private Sub txtEX18_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX18a.KeyPress, txtEX18b.KeyPress, txtEX18c.KeyPress, _
               txtEX18d.KeyPress, txtEX18e.KeyPress, txtEX18f.KeyPress, _
               txtEX18g.KeyPress, txtEX18h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or c = "." Or c = "m" Or c = "c" Or c = "g" Or c = "r" Or c = "'" Or c = ":" Or c = "/" Or c = "%" Or c = "+" Or c = "-" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Otros02: digitos , punto, ' , m , g , c , : , / , % , + , - , esp
    Private Sub txtEX19_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX19a.KeyPress, txtEX19b.KeyPress, txtEX19c.KeyPress, _
               txtEX19d.KeyPress, txtEX19e.KeyPress, txtEX19f.KeyPress, _
               txtEX19g.KeyPress, txtEX19h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or c = "." Or c = "m" Or c = "c" Or c = "g" Or c = "r" Or c = "'" Or c = ":" Or c = "/" Or c = "%" Or c = "+" Or c = "-" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Otros03: digitos , punto, ' , m , g , c , : , / , % , + , - , esp
    Private Sub txtEX20_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX20a.KeyPress, txtEX20b.KeyPress, txtEX20c.KeyPress, _
               txtEX20d.KeyPress, txtEX20e.KeyPress, txtEX20f.KeyPress, _
               txtEX20g.KeyPress, txtEX20h.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or c = "." Or c = "m" Or c = "c" Or c = "g" Or c = "r" Or c = "'" Or c = ":" Or c = "/" Or c = "%" Or c = "+" Or c = "-" Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'TXTOtrosEX: letras, digitos , espacio
    Private Sub txtOtrosEX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtOtroEx01.KeyPress, txtOtroEx02.KeyPress, txtOtroEx03.KeyPress, _
               txtOtroEx04.KeyPress, txtOtroEx05.KeyPress, txtOtroEx06.KeyPress, _
               txtOtroEx07.KeyPress, txtOtroEx08.KeyPress, txtOtroEx09.KeyPress

        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsLetterOrDigit(c) Or c = " ") Then
            e.Handled = True
        Else
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    'Examenes Largos (2ª ficha)
    Private Sub txtEX21_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
       Handles txtEX21a.KeyPress, txtEX21b.KeyPress, txtEX21c.KeyPress, _
               txtEX21d.KeyPress, txtEX21e.KeyPress, txtEX21f.KeyPress, _
               txtEX21g.KeyPress, txtEX21h.KeyPress, txtEX21i.KeyPress, _
               txtEX21j.KeyPress, txtEX21k.KeyPress, txtEX21l.KeyPress

        If DatosModificados = False Then
            SeModificaronLosDatos()
        End If

    End Sub


    'eventos doble click de los examenes largos (ventana de texto)
    Private Sub txtEXAMENESLARGOS_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtEX21a.DoubleClick, txtEX21b.DoubleClick, _
                txtEX21c.DoubleClick, txtEX21d.DoubleClick, _
                txtEX21e.DoubleClick, txtEX21f.DoubleClick, _
                txtEX21g.DoubleClick, txtEX21h.DoubleClick, _
                txtEX21i.DoubleClick, txtEX21j.DoubleClick, _
                txtEX21k.DoubleClick, txtEX21l.DoubleClick


        Dim DLG As New FormVentanaLectura()
        Dim Presionado As String
        Dim Largo As Integer

        'mira que texto se doblecliquio
        Presionado = sender.name

        'mira quien fue seleccionado y actualiza las variables locales
        If Presionado = "txtEX21a" Then
            TextoEnVentana = txtEX21a.Text
            TituloEnVentana = "EXAMENES de ORINA de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21b" Then
            TextoEnVentana = txtEX21b.Text
            TituloEnVentana = "UROCULTIVOS Y ANTIBIOGRAMAS de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21c" Then
            TextoEnVentana = txtEX21c.Text
            TituloEnVentana = "EXAMENES DE HECES de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21d" Then
            TextoEnVentana = txtEX21d.Text
            TituloEnVentana = "COPROCULTIVOS de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21e" Then
            TextoEnVentana = txtEX21e.Text
            TituloEnVentana = "CITOLOGIAS de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21f" Then
            TextoEnVentana = txtEX21f.Text
            TituloEnVentana = "TIPIFICACION VPH de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21g" Then
            TextoEnVentana = txtEX21g.Text
            'txtOtroEx04 guarda el nombre de este examen
            TituloEnVentana = txtOtroEx04.Text.ToUpper & " de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21h" Then
            TextoEnVentana = txtEX21h.Text
            'txtOtroEx05 guarda el nombre de este examen
            TituloEnVentana = txtOtroEx05.Text.ToUpper & " de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21i" Then
            TextoEnVentana = txtEX21i.Text
            'txtOtroEx06 guarda el nombre de este examen
            TituloEnVentana = txtOtroEx06.Text.ToUpper & " de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21j" Then
            TextoEnVentana = txtEX21j.Text
            'txtOtroEx07 guarda el nombre de este examen
            TituloEnVentana = txtOtroEx07.Text.ToUpper & " de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21k" Then
            TextoEnVentana = txtEX21k.Text
            'txtOtroEx08 guarda el nombre de este examen
            TituloEnVentana = txtOtroEx08.Text.ToUpper & " de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        ElseIf Presionado = "txtEX21l" Then
            TextoEnVentana = txtEX21l.Text
            'txtOtroEx09 guarda el nombre de este examen
            TituloEnVentana = txtOtroEx09.Text.ToUpper & " de " & Form1.PSstrPacienteSeleccionadaNombre & " - (Historia #" & Form1.NumeroDeHistoriaCompleto & ")"
        End If

        'inicializa las variables de intercambio publicas
        If TextoEnVentana <> "" Then
            Form1.TextoIntercambio = TextoEnVentana
        Else
            Form1.TextoIntercambio = ""
        End If
        Form1.TituloVentanaDeTexto = TituloEnVentana

        'muestra la ventana de texto
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            'si aceptas actualiza variable de texto local
            TextoEnVentana = Form1.TextoIntercambio

            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
        'apunta al ultimo caracter no importa lo que tenga
        Largo = TextoEnVentana.Length

        'actualiza el texto en pantalla con la variable local
        If Presionado = "txtEX21a" Then
            txtEX21a.Text = TextoEnVentana
            txtEX21a.SelectionStart = Largo
            txtEX21a.ScrollToCaret()
        ElseIf Presionado = "txtEX21b" Then
            txtEX21b.Text = TextoEnVentana
            txtEX21b.SelectionStart = Largo
            txtEX21b.ScrollToCaret()
        ElseIf Presionado = "txtEX21c" Then
            txtEX21c.Text = TextoEnVentana
            txtEX21c.SelectionStart = Largo
            txtEX21c.ScrollToCaret()
        ElseIf Presionado = "txtEX21d" Then
            txtEX21d.Text = TextoEnVentana
            txtEX21d.SelectionStart = Largo
            txtEX21d.ScrollToCaret()
        ElseIf Presionado = "txtEX21e" Then
            txtEX21e.Text = TextoEnVentana
            txtEX21e.SelectionStart = Largo
            txtEX21e.ScrollToCaret()
        ElseIf Presionado = "txtEX21f" Then
            txtEX21f.Text = TextoEnVentana
            txtEX21f.SelectionStart = Largo
            txtEX21f.ScrollToCaret()
        ElseIf Presionado = "txtEX21g" Then
            txtEX21g.Text = TextoEnVentana
            txtEX21g.SelectionStart = Largo
            txtEX21g.ScrollToCaret()
        ElseIf Presionado = "txtEX21h" Then
            txtEX21h.Text = TextoEnVentana
            txtEX21h.SelectionStart = Largo
            txtEX21h.ScrollToCaret()
        ElseIf Presionado = "txtEX21i" Then
            txtEX21i.Text = TextoEnVentana
            txtEX21i.SelectionStart = Largo
            txtEX21i.ScrollToCaret()
        ElseIf Presionado = "txtEX21j" Then
            txtEX21j.Text = TextoEnVentana
            txtEX21j.SelectionStart = Largo
            txtEX21j.ScrollToCaret()
        ElseIf Presionado = "txtEX21k" Then
            txtEX21k.Text = TextoEnVentana
            txtEX21k.SelectionStart = Largo
            txtEX21k.ScrollToCaret()
        ElseIf Presionado = "txtEX21l" Then
            txtEX21l.Text = TextoEnVentana
            txtEX21l.SelectionStart = Largo
            txtEX21l.ScrollToCaret()
        End If

    End Sub

    'eventos de doble click de las fechas de los examenes
    Private Sub txtFechaLabA_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtFechaLabA.DoubleClick
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de el o los Exámenes..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFechaLabA.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub txtFechaLabB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtFechaLabB.DoubleClick
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de el o los Exámenes..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFechaLabB.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub txtFechaLabC_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtFechaLabC.DoubleClick
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de el o los Exámenes..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFechaLabC.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub txtFechaLabD_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtFechaLabD.DoubleClick
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de el o los Exámenes..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFechaLabD.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub txtFechaLabE_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtFechaLabE.DoubleClick
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de el o los Exámenes..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFechaLabE.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub txtFechaLabF_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtFechaLabF.DoubleClick
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de el o los Exámenes..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFechaLabF.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub txtFechaLabG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtFechaLabG.DoubleClick
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de el o los Exámenes..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFechaLabG.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    Private Sub txtFechaLabH_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
       Handles txtFechaLabH.DoubleClick
        Dim DLG As New FormEligeFecha()
        Form1.FechaSeleccionadaMensaje = "Selecciona la Fecha de el o los Exámenes..."
        If DLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFechaLabH.Text = Form1.FechaSeleccionada
            If DatosModificados = False Then
                SeModificaronLosDatos()
            End If
        End If
    End Sub

    '000000000000000000000000000
    'parte del informe ginecologico


    Private Sub botCreaRestableceInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCreaRestableceInforme.Click
        ActualizaInforme()
    End Sub


    Private Sub ActualizaInforme()

        txtInforme.Clear()
        txtInforme.Text += "                                     C O N T R O L    G I N E C O L O G I C O" & vbCrLf
        txtInforme.Text += "                                     =============    =======================" & vbCrLf & vbCrLf

        txtInforme.Text += "     DATOS PERSONALES:" & vbCrLf
        'el nombre:
        txtInforme.Text += "Nombre: " & txtNombrePaciente.Text
        'la edad
        txtInforme.Text += "   Edad: " & txtEdad.Text & vbCrLf
        'la cedula
        txtInforme.Text += "Cédula: " & txtCedula.Text
        'la profesion
        txtInforme.Text += "   Profesión: " & txtProfesion.Text
        'el telefono
        txtInforme.Text += "   Teléfono: " & txtTelefono.Text & vbCrLf & vbCrLf

        'los antecedentes 
        txtInforme.Text += "     ANTECEDENTES FAMILIARES:" & vbCrLf
        txtInforme.Text += txtAntFamiliares.Text & vbCrLf & vbCrLf
        txtInforme.Text += "     ANTECEDENTES PERSONALES:" & vbCrLf
        txtInforme.Text += txtAntPersonales.Text & vbCrLf
        txtInforme.Text += "     ANTECEDENTES GINECOLOGICOS:" & vbCrLf
        txtInforme.Text += txtAntGinecologicos.Text & vbCrLf & vbCrLf
        txtInforme.Text += "     ANTECEDENTES OBSTETRICOS:" & vbCrLf
        txtInforme.Text += txtAntObstetricos.Text & vbCrLf & vbCrLf
        txtInforme.Text += "     ANTECEDENTES QUIRURGICOS:" & vbCrLf
        txtInforme.Text += txtAntQuirurgicos.Text & vbCrLf & vbCrLf

        'el control propiamente dicho
        txtInforme.Text += "CONSULTA DE INICIO        Fecha del Control: " & txt01a.Text & vbCrLf
        txtInforme.Text += "======== == ======                      FUR: " & txt01b.Text & vbCrLf
        txtInforme.Text += "                              Día del Ciclo: " & txtDC01.Text & vbCrLf & vbCrLf

        txtInforme.Text += "     MOTIVO DE CONSULTA:" & vbCrLf
        txtInforme.Text += txt01c.Text & vbCrLf & vbCrLf

        txtInforme.Text += "     ENFERMEDAD ACTUAL:" & vbCrLf
        txtInforme.Text += txt01d.Text & vbCrLf & vbCrLf

        txtInforme.Text += "     EXAMEN FISICO" & vbCrLf
        txtInforme.Text += "     ------ ------" & vbCrLf
        txtInforme.Text += txt01h.Text & vbCrLf & vbCrLf

        txtInforme.Text += "     PROCEDIMIENTOS REALIZADOS EN LA CONSULTA:" & vbCrLf
        txtInforme.Text += txt01e.Text & vbCrLf & vbCrLf

        txtInforme.Text += "     TRATAMIENTOS INDICADOS:" & vbCrLf
        txtInforme.Text += txt01f.Text & vbCrLf & vbCrLf

        'REVISA QUE HAYA AUNQUE SEA UN DATO
        If txt02a.Text <> "" Or txt03a.Text <> "" Or _
            txt04a.Text <> "" Or txt05a.Text <> "" Or _
            txt06a.Text <> "" Or txt07a.Text <> "" Or _
            txt08a.Text <> "" Or txt09a.Text <> "" Or _
            txt10a.Text <> "" Then

            'ahora revisa cual o cuales tienen datos

            'REVISA EL 02
            If txt02a.Text <> "" Then
                'existe algo en el 2do lo muestra
                txtInforme.Text += "SEGUNDA CONSULTA          Fecha del Control: " & txt02a.Text & vbCrLf
                txtInforme.Text += "======= ========                        FUR: " & txt02b.Text & vbCrLf
                txtInforme.Text += "                              Día del Ciclo: " & txtDC02.Text & vbCrLf & vbCrLf

                If txt02c.Text <> "" Then
                    txtInforme.Text += "     ENFERMEDAD ACTUAL:" & vbCrLf
                    txtInforme.Text += txt02c.Text & vbCrLf & vbCrLf
                End If

                If txt02g.Text <> "" Then
                    txtInforme.Text += "     EXAMEN FISICO" & vbCrLf
                    txtInforme.Text += "     ------ ------" & vbCrLf
                    txtInforme.Text += txt02g.Text & vbCrLf & vbCrLf
                End If

                If txt02d.Text <> "" Then
                    txtInforme.Text += "     PROCEDIMIENTOS REALIZADOS EN LA CONSULTA:" & vbCrLf
                    txtInforme.Text += txt02d.Text & vbCrLf & vbCrLf
                End If

                If txt02e.Text <> "" Then
                    txtInforme.Text += "     TRATAMIENTOS INDICADOS:" & vbCrLf
                    txtInforme.Text += txt02e.Text & vbCrLf & vbCrLf
                End If
            End If

            'REVISA EL 03
            If txt03a.Text <> "" Then
                'existe algo en el 2do lo muestra
                txtInforme.Text += "TERCERA CONSULTA          Fecha del Control: " & txt03a.Text & vbCrLf
                txtInforme.Text += "======= ========                        FUR: " & txt03b.Text & vbCrLf
                txtInforme.Text += "                              Día del Ciclo: " & txtDC03.Text & vbCrLf & vbCrLf

                If txt03c.Text <> "" Then
                    txtInforme.Text += "     ENFERMEDAD ACTUAL:" & vbCrLf
                    txtInforme.Text += txt03c.Text & vbCrLf & vbCrLf
                End If

                If txt03g.Text <> "" Then
                    txtInforme.Text += "     EXAMEN FISICO" & vbCrLf
                    txtInforme.Text += "     ------ ------" & vbCrLf
                    txtInforme.Text += txt03g.Text & vbCrLf & vbCrLf
                End If

                If txt03d.Text <> "" Then
                    txtInforme.Text += "     PROCEDIMIENTOS REALIZADOS EN LA CONSULTA:" & vbCrLf
                    txtInforme.Text += txt03d.Text & vbCrLf & vbCrLf
                End If

                If txt03e.Text <> "" Then
                    txtInforme.Text += "     TRATAMIENTOS INDICADOS:" & vbCrLf
                    txtInforme.Text += txt03e.Text & vbCrLf & vbCrLf
                End If
            End If

            'REVISA EL 04
            If txt04a.Text <> "" Then
                'existe algo en el 2do lo muestra
                txtInforme.Text += "CUARTA CONSULTA          Fecha del Control: " & txt04a.Text & vbCrLf
                txtInforme.Text += "====== ========                        FUR: " & txt04b.Text & vbCrLf
                txtInforme.Text += "                              Día del Ciclo: " & txtDC04.Text & vbCrLf & vbCrLf

                If txt04c.Text <> "" Then
                    txtInforme.Text += "     ENFERMEDAD ACTUAL:" & vbCrLf
                    txtInforme.Text += txt04c.Text & vbCrLf & vbCrLf
                End If

                If txt04g.Text <> "" Then
                    txtInforme.Text += "     EXAMEN FISICO" & vbCrLf
                    txtInforme.Text += "     ------ ------" & vbCrLf
                    txtInforme.Text += txt04g.Text & vbCrLf & vbCrLf
                End If

                If txt04d.Text <> "" Then
                    txtInforme.Text += "     PROCEDIMIENTOS REALIZADOS EN LA CONSULTA:" & vbCrLf
                    txtInforme.Text += txt04d.Text & vbCrLf & vbCrLf
                End If

                If txt04e.Text <> "" Then
                    txtInforme.Text += "     TRATAMIENTOS INDICADOS:" & vbCrLf
                    txtInforme.Text += txt04e.Text & vbCrLf & vbCrLf
                End If
            End If

            'REVISA EL 05
            If txt05a.Text <> "" Then
                'existe algo en el 2do lo muestra
                txtInforme.Text += "QUINTA CONSULTA          Fecha del Control: " & txt05a.Text & vbCrLf
                txtInforme.Text += "====== ========                        FUR: " & txt05b.Text & vbCrLf
                txtInforme.Text += "                              Día del Ciclo: " & txtDC05.Text & vbCrLf & vbCrLf

                If txt05c.Text <> "" Then
                    txtInforme.Text += "     ENFERMEDAD ACTUAL:" & vbCrLf
                    txtInforme.Text += txt05c.Text & vbCrLf & vbCrLf
                End If

                If txt05g.Text <> "" Then
                    txtInforme.Text += "     EXAMEN FISICO" & vbCrLf
                    txtInforme.Text += "     ------ ------" & vbCrLf
                    txtInforme.Text += txt05g.Text & vbCrLf & vbCrLf
                End If

                If txt05d.Text <> "" Then
                    txtInforme.Text += "     PROCEDIMIENTOS REALIZADOS EN LA CONSULTA:" & vbCrLf
                    txtInforme.Text += txt05d.Text & vbCrLf & vbCrLf
                End If

                If txt05e.Text <> "" Then
                    txtInforme.Text += "     TRATAMIENTOS INDICADOS:" & vbCrLf
                    txtInforme.Text += txt05e.Text & vbCrLf & vbCrLf
                End If
            End If

            'REVISA EL 06
            If txt06a.Text <> "" Then
                'existe algo en el 2do lo muestra
                txtInforme.Text += "SEXTA CONSULTA          Fecha del Control: " & txt06a.Text & vbCrLf
                txtInforme.Text += "===== ========                        FUR: " & txt06b.Text & vbCrLf
                txtInforme.Text += "                              Día del Ciclo: " & txtDC06.Text & vbCrLf & vbCrLf

                If txt06c.Text <> "" Then
                    txtInforme.Text += "     ENFERMEDAD ACTUAL:" & vbCrLf
                    txtInforme.Text += txt06c.Text & vbCrLf & vbCrLf
                End If

                If txt06g.Text <> "" Then
                    txtInforme.Text += "     EXAMEN FISICO" & vbCrLf
                    txtInforme.Text += "     ------ ------" & vbCrLf
                    txtInforme.Text += txt06g.Text & vbCrLf & vbCrLf
                End If

                If txt06d.Text <> "" Then
                    txtInforme.Text += "     PROCEDIMIENTOS REALIZADOS EN LA CONSULTA:" & vbCrLf
                    txtInforme.Text += txt06d.Text & vbCrLf & vbCrLf
                End If

                If txt06e.Text <> "" Then
                    txtInforme.Text += "     TRATAMIENTOS INDICADOS:" & vbCrLf
                    txtInforme.Text += txt06e.Text & vbCrLf & vbCrLf
                End If
            End If

            'REVISA EL 07
            If txt07a.Text <> "" Then
                'existe algo en el 2do lo muestra
                txtInforme.Text += "SEPTIMA CONSULTA          Fecha del Control: " & txt07a.Text & vbCrLf
                txtInforme.Text += "======= ========                        FUR: " & txt07b.Text & vbCrLf
                txtInforme.Text += "                              Día del Ciclo: " & txtDC07.Text & vbCrLf & vbCrLf

                If txt07c.Text <> "" Then
                    txtInforme.Text += "     ENFERMEDAD ACTUAL:" & vbCrLf
                    txtInforme.Text += txt07c.Text & vbCrLf & vbCrLf
                End If

                If txt07g.Text <> "" Then
                    txtInforme.Text += "     EXAMEN FISICO" & vbCrLf
                    txtInforme.Text += "     ------ ------" & vbCrLf
                    txtInforme.Text += txt07g.Text & vbCrLf & vbCrLf
                End If

                If txt07d.Text <> "" Then
                    txtInforme.Text += "     PROCEDIMIENTOS REALIZADOS EN LA CONSULTA:" & vbCrLf
                    txtInforme.Text += txt07d.Text & vbCrLf & vbCrLf
                End If

                If txt07e.Text <> "" Then
                    txtInforme.Text += "     TRATAMIENTOS INDICADOS:" & vbCrLf
                    txtInforme.Text += txt07e.Text & vbCrLf & vbCrLf
                End If
            End If

            'REVISA EL 08
            If txt08a.Text <> "" Then
                'existe algo en el 2do lo muestra
                txtInforme.Text += "OCTAVA CONSULTA          Fecha del Control: " & txt08a.Text & vbCrLf
                txtInforme.Text += "======= ========                        FUR: " & txt08b.Text & vbCrLf
                txtInforme.Text += "                              Día del Ciclo: " & txtDC08.Text & vbCrLf & vbCrLf

                If txt08c.Text <> "" Then
                    txtInforme.Text += "     ENFERMEDAD ACTUAL:" & vbCrLf
                    txtInforme.Text += txt08c.Text & vbCrLf & vbCrLf
                End If

                If txt08g.Text <> "" Then
                    txtInforme.Text += "     EXAMEN FISICO" & vbCrLf
                    txtInforme.Text += "     ------ ------" & vbCrLf
                    txtInforme.Text += txt08g.Text & vbCrLf & vbCrLf
                End If

                If txt08d.Text <> "" Then
                    txtInforme.Text += "     PROCEDIMIENTOS REALIZADOS EN LA CONSULTA:" & vbCrLf
                    txtInforme.Text += txt08d.Text & vbCrLf & vbCrLf
                End If

                If txt08e.Text <> "" Then
                    txtInforme.Text += "     TRATAMIENTOS INDICADOS:" & vbCrLf
                    txtInforme.Text += txt08e.Text & vbCrLf & vbCrLf
                End If
            End If

            'REVISA EL 09
            If txt09a.Text <> "" Then
                'existe algo en el 2do lo muestra
                txtInforme.Text += "NOVENA CONSULTA          Fecha del Control: " & txt09a.Text & vbCrLf
                txtInforme.Text += "====== ========                        FUR: " & txt09b.Text & vbCrLf
                txtInforme.Text += "                              Día del Ciclo: " & txtDC09.Text & vbCrLf & vbCrLf

                If txt09c.Text <> "" Then
                    txtInforme.Text += "     ENFERMEDAD ACTUAL:" & vbCrLf
                    txtInforme.Text += txt09c.Text & vbCrLf & vbCrLf
                End If

                If txt09g.Text <> "" Then
                    txtInforme.Text += "     EXAMEN FISICO" & vbCrLf
                    txtInforme.Text += "     ------ ------" & vbCrLf
                    txtInforme.Text += txt09g.Text & vbCrLf & vbCrLf
                End If

                If txt09d.Text <> "" Then
                    txtInforme.Text += "     PROCEDIMIENTOS REALIZADOS EN LA CONSULTA:" & vbCrLf
                    txtInforme.Text += txt09d.Text & vbCrLf & vbCrLf
                End If

                If txt09e.Text <> "" Then
                    txtInforme.Text += "     TRATAMIENTOS INDICADOS:" & vbCrLf
                    txtInforme.Text += txt09e.Text & vbCrLf & vbCrLf
                End If
            End If

            'REVISA EL 10
            If txt10a.Text <> "" Then
                'existe algo en el 2do lo muestra
                txtInforme.Text += "DECIMA CONSULTA          Fecha del Control: " & txt10a.Text & vbCrLf
                txtInforme.Text += "====== ========                        FUR: " & txt10b.Text & vbCrLf
                txtInforme.Text += "                              Día del Ciclo: " & txtDC10.Text & vbCrLf & vbCrLf

                If txt10c.Text <> "" Then
                    txtInforme.Text += "     ENFERMEDAD ACTUAL:" & vbCrLf
                    txtInforme.Text += txt10c.Text & vbCrLf & vbCrLf
                End If

                If txt10g.Text <> "" Then
                    txtInforme.Text += "     EXAMEN FISICO" & vbCrLf
                    txtInforme.Text += "     ------ ------" & vbCrLf
                    txtInforme.Text += txt10g.Text & vbCrLf & vbCrLf
                End If

                If txt10d.Text <> "" Then
                    txtInforme.Text += "     PROCEDIMIENTOS REALIZADOS EN LA CONSULTA:" & vbCrLf
                    txtInforme.Text += txt10d.Text & vbCrLf & vbCrLf
                End If

                If txt10e.Text <> "" Then
                    txtInforme.Text += "     TRATAMIENTOS INDICADOS:" & vbCrLf
                    txtInforme.Text += txt10e.Text & vbCrLf & vbCrLf
                End If
            End If


        End If

        txtInforme.Text += "EXÁMENES DE LABORATORIO:" & vbCrLf & vbCrLf
        'las fechas
        txtInforme.Text += "===========================================================================================================================" & vbCrLf
        txtInforme.Text += "            FECHAS|"
        CadenaTratada = txtFechaLabA.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtFechaLabB.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtFechaLabC.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtFechaLabD.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtFechaLabE.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtFechaLabF.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtFechaLabG.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtFechaLabH.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        txtInforme.Text += "EXAMEN            |            |            |            |            |            |            |            |            |" & vbCrLf
        txtInforme.Text += "===========================================================================================================================" & vbCrLf
        'la hemoglobina
        txtInforme.Text += "HEMOGLOBINA       |"
        CadenaTratada = txtEX01a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX01b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX01c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX01d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX01e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX01f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX01g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX01h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'EL HEMATOCRITO
        txtInforme.Text += "HEMATOCRITO       |"
        CadenaTratada = txtEX02a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX02b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX02c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX02d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX02e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX02f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX02g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX02h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'GLOBULOS BLANCOS
        txtInforme.Text += "GLOBULOS BLANCOS  |"
        CadenaTratada = txtEX03a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX03b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX03c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX03d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX03e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX03f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX03g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX03h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'SEGMENTADOS
        txtInforme.Text += "SEGMENTADOS       |"
        CadenaTratada = txtEX04a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX04b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX04c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX04d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX04e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX04f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX04g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX04h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'LINFOCITOS
        txtInforme.Text += "LINFOCITOS        |"
        CadenaTratada = txtEX05a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX05b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX05c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX05d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX05e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX05f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX05g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX05h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'MONOCITOS
        txtInforme.Text += "MONOCITOS         |"
        CadenaTratada = txtEX06a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX06b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX06c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX06d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX06e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX06f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX06g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX06h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'PLAQUETAS
        txtInforme.Text += "PLAQUETAS         |"
        CadenaTratada = txtEX07a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX07b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX07c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX07d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX07e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX07f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX07g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX07h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'PT
        txtInforme.Text += "PT                |"
        CadenaTratada = txtEX08a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX08b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX08c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX08d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX08e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX08f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX08g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX08h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'PTT
        txtInforme.Text += "PTT               |"
        CadenaTratada = txtEX09a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX09b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX09c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX09d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX09e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX09f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX09g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX09h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'GLICEMIA
        txtInforme.Text += "GLICEMIA          |"
        CadenaTratada = txtEX10a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX10b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX10c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX10d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX10e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX10f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX10g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX10h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'CREATININA
        txtInforme.Text += "CREATININA        |"
        CadenaTratada = txtEX11a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX11b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX11c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX11d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX11e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX11f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX11g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX11h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'VDRL
        txtInforme.Text += "VDRL              |"
        CadenaTratada = txtEX12a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX12b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX12c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX12d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX12e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX12f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX12g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX12h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'HIV
        txtInforme.Text += "HIV               |"
        CadenaTratada = txtEX13a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX13b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX13c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX13d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX13e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX13f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX13g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX13h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'fsh
        txtInforme.Text += "FSH               |"
        CadenaTratada = txtEX14a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX14b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX14c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX14d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX14e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX14f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX14g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX14h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'lh
        txtInforme.Text += "LH                |"
        CadenaTratada = txtEX15a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX15b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX15c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX15d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX15e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX15f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX15g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX15h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'ESTRADIOl
        txtInforme.Text += "ESTRADIOL         |"
        CadenaTratada = txtEX16a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX16b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX16c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX16d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX16e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX16f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX16g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX16h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'PROGESTERONA
        txtInforme.Text += "PROGESTERONA      |"
        CadenaTratada = txtEX17a.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX17b.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX17c.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX17d.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX17e.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX17f.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX17g.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|"

        CadenaTratada = txtEX17h.Text
        LargoDeseado = 12
        FormateaCadena()
        txtInforme.Text += CadenaTratada & "|" & vbCrLf

        'OTRO EX 01
        If txtOtroEx01.Text <> "Otro" Then
            CadenaTratada = txtOtroEx01.Text.ToUpper
            LargoDeseado = 18
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX18a.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX18b.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX18c.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX18d.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX18e.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX18f.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX18g.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX18h.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|" & vbCrLf
        End If


        'otro ex 02
        If txtOtroEx02.Text <> "Otro" Then
            CadenaTratada = txtOtroEx02.Text.ToUpper
            LargoDeseado = 18
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX19a.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX19b.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX19c.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX19d.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX19e.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX19f.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX19g.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX19h.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|" & vbCrLf
        End If

        'otro ex 03
        If txtOtroEx03.Text <> "Otro" Then
            CadenaTratada = txtOtroEx03.Text.ToUpper
            LargoDeseado = 18
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX20a.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX20b.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX20c.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX20d.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX20e.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX20f.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX20g.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|"

            CadenaTratada = txtEX20h.Text
            LargoDeseado = 12
            FormateaCadena()
            txtInforme.Text += CadenaTratada & "|" & vbCrLf
        End If
        txtInforme.Text += "===========================================================================================================================" & vbCrLf
        txtInforme.Text += vbCrLf

        'orina
        If txtEX21a.Text <> "" Then
            txtInforme.Text += "ORINA:" & vbCrLf
            txtInforme.Text += txtEX21a.Text & vbCrLf & vbCrLf
        End If

        'urocultivo
        If txtEX21b.Text <> "" Then
            txtInforme.Text += "UROCULTIVO:" & vbCrLf
            txtInforme.Text += txtEX21b.Text & vbCrLf & vbCrLf
        End If

        'HECES
        If txtEX21c.Text <> "" Then
            txtInforme.Text += "HECES:" & vbCrLf
            txtInforme.Text += txtEX21c.Text & vbCrLf & vbCrLf
        End If

        'COPROCULTIVO
        If txtEX21d.Text <> "" Then
            txtInforme.Text += "COPROCULTIVO:" & vbCrLf
            txtInforme.Text += txtEX21d.Text & vbCrLf & vbCrLf
        End If

        'CITOLOGIA
        If txtEX21e.Text <> "" Then
            txtInforme.Text += "CITOLOGIA:" & vbCrLf
            txtInforme.Text += txtEX21e.Text & vbCrLf & vbCrLf
        End If

        'TIPIFICACION VPH
        If txtEX21f.Text <> "" Then
            txtInforme.Text += "TIPIFICACION DE VPH:" & vbCrLf
            txtInforme.Text += txtEX21f.Text & vbCrLf & vbCrLf
        End If




        'OTROS 1
        If txtEX21g.Text <> "" Then
            txtInforme.Text += txtOtroEx04.Text & vbCrLf
            txtInforme.Text += txtEX21g.Text & vbCrLf & vbCrLf
        End If

        'OTROS 2
        If txtEX21h.Text <> "" Then
            txtInforme.Text += txtOtroEx05.Text & vbCrLf
            txtInforme.Text += txtEX21h.Text & vbCrLf & vbCrLf
        End If

        'OTROS 3
        If txtEX21i.Text <> "" Then
            txtInforme.Text += txtOtroEx06.Text & vbCrLf
            txtInforme.Text += txtEX21i.Text & vbCrLf & vbCrLf
        End If

        'OTROS4
        If txtEX21j.Text <> "" Then
            txtInforme.Text += txtOtroEx07.Text & vbCrLf
            txtInforme.Text += txtEX21j.Text & vbCrLf & vbCrLf
        End If

        'OTROS5
        If txtEX21k.Text <> "" Then
            txtInforme.Text += txtOtroEx08.Text & vbCrLf
            txtInforme.Text += txtEX21k.Text & vbCrLf & vbCrLf
        End If

        'OTROS6
        If txtEX21l.Text <> "" Then
            txtInforme.Text += txtOtroEx09.Text & vbCrLf
            txtInforme.Text += txtEX21l.Text & vbCrLf & vbCrLf
        End If



        'ESPACIO PARA LA IMPRESION DIAGNOSTICA Y RECOMENDACIONES
        txtInforme.Text += "IMPRESIÓN DIAGNÓSTICA:" & vbCrLf
        txtInforme.Text += "1." & vbCrLf
        txtInforme.Text += "2." & vbCrLf
        txtInforme.Text += "3." & vbCrLf
        txtInforme.Text += "4." & vbCrLf & vbCrLf
        txtInforme.Text += "RECOMENDACIONES" & vbCrLf
        txtInforme.Text += "1." & vbCrLf
        txtInforme.Text += "2." & vbCrLf
    End Sub

    Private Sub FormateaCadena()
        LargoCadena = CadenaTratada.Length
        If LargoCadena > LargoDeseado Then
            CadenaTratada = CadenaTratada.Remove(LargoDeseado, LargoCadena - LargoDeseado)
        ElseIf LargoCadena < LargoDeseado Then
            CadenaTratada = CadenaTratada.PadRight(LargoDeseado)
        Else
            'la cadena tiene los caracteres exactos deseados
        End If
    End Sub

    Private Sub botImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botImprimeInforme.Click

        If txtInforme.Text = "" Then
            MsgBox("Primero crea el Informe...", MsgBoxStyle.Information, "Control Ecográfico")
            Exit Sub
        End If

        PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings
        PageSetupDialog1.PageSettings.Margins.Left = 100
        PageSetupDialog1.PageSettings.Margins.Right = 120
        PageSetupDialog1.PageSettings.Margins.Top = 200
        PageSetupDialog1.PageSettings.Margins.Bottom = 250
        If PageSetupDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
        End If

        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Respuesta As MsgBoxResult
            Respuesta = MsgBox("¿Estas imprimiendo en hojas con Membrete?", MsgBoxStyle.YesNo, "Selección de Hojas")
            If Respuesta = MsgBoxResult.Yes Then
                HojaconMembrete = True
            Else
                HojaconMembrete = False
            End If
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings

            If Form1.booExistenDatosDelUsuario = False And HojaconMembrete = False Then
                'no hay datos Y SE quieren personalizar lo dice
                MsgBox("No se han intoducido los Datos del Usuario, para personalizar los Informes se deben introducir estos Datos primero...", MsgBoxStyle.Information, "Faltan Datos del Usuario")
            End If

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
     Handles PrintDocument1.PrintPage
        Dim Linea As Integer

        Dim pFont As Font
        Dim nombreFont As Font
        Dim otrosFont As Font
        Dim direccionFont As Font
        Dim fechaFont As Font
        Dim RecipeFont As Font
        Dim IndicacionesFont As Font
        Dim variableFont As Font
        Dim T As Integer

        'variables de prepararecipe
        '============================================
        Dim iLine As Integer
        Dim LineaProcesandose As String
        Dim PalabraActual As String
        Dim LineaActual As String

        '=============================
        Dim anchoenPixels As Integer
        Dim NumerodeParrafos As Integer
        Dim LineaParrafo(1000) As String
        Dim NumerodeLineas As Integer

        Dim C As Integer
        Dim Caracter As Char
        'Dim largoActual As Integer
        Dim anchoActual As Integer
        Dim NumerodeCaracteres As Integer
        'Dim LineasdelParrafo As Integer

        Static Z As Integer ' contador de paginas
        Dim Y As Integer    'contador de lineas por pagina

        pFont = New Font("Lucida Console", 7)
        nombreFont = New Font("Times New Roman", 16, FontStyle.Italic)
        otrosFont = New Font("Times New Roman", 8)
        direccionFont = New Font("Times New Roman", 6)
        fechaFont = New Font("Times New Roman", 10, FontStyle.Italic)
        RecipeFont = New Font("Lucida Console", 10)
        IndicacionesFont = New Font("Times New Roman", 10, FontStyle.Italic)

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
            'Dim Temporal As Integer
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

        Dim R As Rectangle
        Dim P As Pen
        P = New Pen(Color.Black, 1)
        R = New Rectangle(IniciodeRecipeX, Tmargin, AnchodeRecipe, PrintHeight)
        'e.Graphics.DrawRectangle(Pens.Blue, R)

        anchoenPixels = AnchodeRecipe
        NumerodeParrafos = txtInforme.Lines.GetUpperBound(0)
        For T = 0 To 1000
            LineaParrafo(T) = ""
        Next
        'nota: si hay mas de 1000 lineas solo toma las primeras 1000 
        If NumerodeParrafos > 1000 Then NumerodeParrafos = 1000

        For T = 0 To NumerodeParrafos
            LineaParrafo(T) = txtInforme.Lines(T)
        Next
        'ahora carga el tipo de letra que se va a usar
        variableFont = pFont

        '=====================================
        For T = 0 To 1000
            LineaImpresa(T) = ""
        Next

        NumerodeLineas = 1
        LineaActual = ""
        PalabraActual = ""

        For iLine = 0 To NumerodeParrafos
            LineaProcesandose = LineaParrafo(iLine)
            'calcula el numero de caracteres del parrafo actual
            NumerodeCaracteres = LineaProcesandose.Length

            For C = 0 To NumerodeCaracteres - 1
                Caracter = LineaProcesandose.Chars(C)
                If Caracter <> " " Then
                    PalabraActual += Caracter
                Else
                    PalabraActual += Caracter
                    'largoActual = LineaActual.Length + PalabraActual.Length
                    anchoActual = e.Graphics.MeasureString(LineaActual & PalabraActual, variableFont).Width

                    If anchoActual <= anchoenPixels Then
                        'la palabra cabe en esta linea
                        LineaActual += PalabraActual
                        PalabraActual = ""
                    Else
                        'la palabra no cabe
                        LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                        LineaActual = PalabraActual
                        PalabraActual = ""
                        NumerodeLineas += 1
                    End If
                End If
            Next
            'se acabo el parrafo, calcula el largo de la linea actual
            'largoActual = LineaActual.Length + PalabraActual.Length
            anchoActual = e.Graphics.MeasureString(LineaActual & PalabraActual, variableFont).Width

            If anchoActual <= anchoenPixels Then
                'la palabra cabe en esta linea
                LineaActual += PalabraActual
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            Else
                'la palabra no cabe pone la linea sin esa palabra, pasa a otra linea
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                'hace la nueva linea solamente con la palabra actual que no cupo arriba
                LineaActual = PalabraActual
                NumerodeLineas += 1
                LineaImpresa(NumerodeLineas) = LineaActual & vbCrLf
                PalabraActual = ""
                LineaActual = ""
                NumerodeLineas += 1
            End If
        Next

        '=====================================================
        'PreparaRecipe()
        Dim Encabezado(4) As String
        Dim InicioCentradoRecipe As Integer
        Dim strAncho, strAlto As Integer
        Dim FechayFirma As String
        Dim iniciodeFechayFirmaY As Integer
        Dim AnchodeRaya As Integer
        Dim Tumb As Image
        Dim Origen As Integer

        altoenPixels = ((e.Graphics.MeasureString(LineaImpresa(1), variableFont).Height) - 2)
        LineasPorPagina = AltodeRecipe \ altoenPixels

        If NumerodeLineas <= LineasPorPagina Then
            NumerodePaginas = 0
            'hay menos lineas de las que caben en una pagina se imprime todo aqui
            For Linea = 1 To NumerodeLineas - 1
                e.Graphics.DrawString(LineaImpresa(Linea), variableFont, Brushes.Black, IniciodeRecipeX, IniciodeRecipeY + altoenPixels * Linea)
            Next

        Else
            'ojo se le quitan 3 al numero de lineas porque la numera cion empieza en cero
            'y se añade un vbcrlf al final lo que da un total de 2 mas, si se pone en menos 2
            'cuando se imprime un numero exacto de lineas en cada pagina es decir si caben 52
            'y el numerodelineas-2 es 104 el numero de pagina daria 2 (es decir 3 paginas)
            'aunque la ultima pagina no tendria nada que poner porque ya las 104 lineas con
            'informacion ya se escribieron, restando tres en cambio daria 103/52 y daria 
            'una fraccion de 1 y picote que al redondear seria igua a 1 (es decir solo 2 paginas)
            NumerodePaginas = Math.Floor((NumerodeLineas - 3) / LineasPorPagina)

            Dim LineasEscritas As Integer

            'ojo empieza en 0 por lo que hay una pagina mas de lo que diga
            If Z < NumerodePaginas Then
                For Y = 1 To LineasPorPagina
                    Linea = (Z * LineasPorPagina) + Y
                    e.Graphics.DrawString(LineaImpresa(Linea), variableFont, Brushes.Black, IniciodeRecipeX, IniciodeRecipeY + altoenPixels * Y)
                Next
                Z = Z + 1
            Else
                LineasEscritas = NumerodePaginas * LineasPorPagina
                Console.WriteLine("Lineas escritas + 1: " & LineasEscritas + 1)
                Console.WriteLine("Numero de lineas - 2: " & NumerodeLineas - 2)
                For Linea = LineasEscritas + 1 To NumerodeLineas - 1
                    Dim LineaImprimiendose As Integer
                    LineaImprimiendose = Linea - LineasEscritas
                    e.Graphics.DrawString(LineaImpresa(Linea), variableFont, Brushes.Black, IniciodeRecipeX, IniciodeRecipeY + altoenPixels * LineaImprimiendose)
                Next
                Z = Z + 1

            End If

            If Z <= NumerodePaginas Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                Z = 0
            End If
        End If

        If HojaconMembrete = True Then
            Exit Sub
        End If

        If Form1.booExistenDatosDelUsuario = False Then
            'no hay datos
            Exit Sub
        End If

        Encabezado(0) = Form1.UsuarioEspecialidad
        Encabezado(1) = Form1.UsuarioNombre
        Encabezado(2) = Form1.UsuarioDir01
        Encabezado(3) = Form1.UsuarioDir02

        strAlto = e.Graphics.MeasureString(Encabezado(0), otrosFont).Height
        AnchodeRaya = AnchodeRecipe - (60) '60 es el ancho de la imagen de la embarazada

        strAncho = e.Graphics.MeasureString(Encabezado(0), otrosFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        e.Graphics.DrawString(Encabezado(0), otrosFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 0)

        strAncho = e.Graphics.MeasureString(Encabezado(1), nombreFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        e.Graphics.DrawString(Encabezado(1), nombreFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 20)

        strAncho = e.Graphics.MeasureString(Encabezado(2), direccionFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        e.Graphics.DrawString(Encabezado(2), direccionFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 50)

        strAncho = e.Graphics.MeasureString(Encabezado(3), direccionFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28
        e.Graphics.DrawString(Encabezado(3), direccionFont, Brushes.Black, Lmargin + InicioCentradoRecipe, Tmargin + 60)

        'grafico del logo del usuario
        Tumb = Form1.imagenLogoDelUsuario

        Dim AltoDelDibujo, AnchoDelDibujo As Integer

        If Tumb.Height > Tumb.Width Then
            'es mas alta que ancha
            '48x80
            AltoDelDibujo = 80
            AnchoDelDibujo = Int(Tumb.Width * 80) \ Tumb.Height

            'situa en el recipe
            Origen = (IniciodeRecipeX + 24) - (AnchoDelDibujo \ 2)
            R = New Rectangle(Origen, Tmargin, AnchoDelDibujo, AltoDelDibujo)
            e.Graphics.DrawImage(Tumb, R)
        Else
            'es mas ancha que alta
            AnchoDelDibujo = 48
            AltoDelDibujo = Int(Tumb.Height * 48) \ Tumb.Width
            'situa en el recipe
            Origen = (Tmargin + 40) - (AltoDelDibujo \ 2)
            R = New Rectangle(IniciodeRecipeX, Origen, AnchoDelDibujo, AltoDelDibujo)
            e.Graphics.DrawImage(Tumb, R)
        End If

        'fecha y firma 
        FechayFirma = "Fecha:         /        /                                           Firma y Sello."
        iniciodeFechayFirmaY = pageHeight - Bmargin
        strAncho = e.Graphics.MeasureString(FechayFirma, fechaFont).Width
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + Lmargin
        e.Graphics.DrawString(FechayFirma, fechaFont, Brushes.Black, InicioCentradoRecipe, iniciodeFechayFirmaY)

        'pone lineas arriba y abajo
        strAncho = AnchodeRaya
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2))) + 28

        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, Tmargin + 15, Lmargin + InicioCentradoRecipe + strAncho, Tmargin + 15)
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, Tmargin + 48, Lmargin + InicioCentradoRecipe + strAncho, Tmargin + 48)
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, Tmargin + 70, Lmargin + InicioCentradoRecipe + strAncho, Tmargin + 70)

        'linea de abajo 
        Dim RayaFinalY As Integer
        RayaFinalY = pageHeight - (Bmargin + 35)
        strAncho = AnchodeRecipe
        InicioCentradoRecipe = (((AnchodeRecipe \ 2) - (strAncho \ 2)))
        e.Graphics.DrawLine(P, Lmargin + InicioCentradoRecipe, RayaFinalY, Lmargin + InicioCentradoRecipe + strAncho, RayaFinalY)

        'grafico de la embarazada
        'R = New Rectangle(IniciodeRecipeX, Tmargin, 48, 80)
        'e.Graphics.DrawImage(PictureImpresora.Image, R)
    End Sub

    Private Sub menuCalculoEGconECO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculoEGconECO.Click
        Dim dlg As New FormEGxECO()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub menuCalculoEGconFUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculoEGconFUR.Click
        Dim dlg As New FormEGxFUR()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub menuCalculoDCconFUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCalculoDCconFUR.Click
        Dim dlg As New FormDCxFUR()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub menuCaluloEGconBiometria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCaluloEGconBiometria.Click
        Dim dlg As New FormCalculosBiometricos()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub
End Class
