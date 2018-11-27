Public Class FormAntQuirurgicos
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
    Friend WithEvents chkApendicectomia As System.Windows.Forms.CheckBox
    Friend WithEvents txtApendicectomia As System.Windows.Forms.TextBox
    Friend WithEvents chkCesarea As System.Windows.Forms.CheckBox
    Friend WithEvents txtCesarea As System.Windows.Forms.TextBox
    Friend WithEvents chkHisterectomia As System.Windows.Forms.CheckBox
    Friend WithEvents txtHisterectomia As System.Windows.Forms.TextBox
    Friend WithEvents chkProlapso As System.Windows.Forms.CheckBox
    Friend WithEvents txtProlapso As System.Windows.Forms.TextBox
    Friend WithEvents txtEsterilizacion As System.Windows.Forms.TextBox
    Friend WithEvents chkConizacion As System.Windows.Forms.CheckBox
    Friend WithEvents txtConizacion As System.Windows.Forms.TextBox
    Friend WithEvents chkLaparotomia As System.Windows.Forms.CheckBox
    Friend WithEvents txtLaparotomia As System.Windows.Forms.TextBox
    Friend WithEvents chkNoduloMamario As System.Windows.Forms.CheckBox
    Friend WithEvents txtNoduloMamario As System.Windows.Forms.TextBox
    Friend WithEvents chkOtros As System.Windows.Forms.CheckBox
    Friend WithEvents txtOtros As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkEsplenectomia As System.Windows.Forms.CheckBox
    Friend WithEvents txtEsplenectomia As System.Windows.Forms.TextBox
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents chkEsterilizacion As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkApendicectomia = New System.Windows.Forms.CheckBox()
        Me.txtApendicectomia = New System.Windows.Forms.TextBox()
        Me.chkCesarea = New System.Windows.Forms.CheckBox()
        Me.txtCesarea = New System.Windows.Forms.TextBox()
        Me.chkHisterectomia = New System.Windows.Forms.CheckBox()
        Me.txtHisterectomia = New System.Windows.Forms.TextBox()
        Me.chkProlapso = New System.Windows.Forms.CheckBox()
        Me.txtProlapso = New System.Windows.Forms.TextBox()
        Me.chkEsterilizacion = New System.Windows.Forms.CheckBox()
        Me.txtEsterilizacion = New System.Windows.Forms.TextBox()
        Me.chkConizacion = New System.Windows.Forms.CheckBox()
        Me.txtConizacion = New System.Windows.Forms.TextBox()
        Me.chkLaparotomia = New System.Windows.Forms.CheckBox()
        Me.txtLaparotomia = New System.Windows.Forms.TextBox()
        Me.chkNoduloMamario = New System.Windows.Forms.CheckBox()
        Me.txtNoduloMamario = New System.Windows.Forms.TextBox()
        Me.chkOtros = New System.Windows.Forms.CheckBox()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkEsplenectomia = New System.Windows.Forms.CheckBox()
        Me.txtEsplenectomia = New System.Windows.Forms.TextBox()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkApendicectomia
        '
        Me.chkApendicectomia.Location = New System.Drawing.Point(8, 32)
        Me.chkApendicectomia.Name = "chkApendicectomia"
        Me.chkApendicectomia.TabIndex = 1
        Me.chkApendicectomia.Text = "Apendicectomía"
        '
        'txtApendicectomia
        '
        Me.txtApendicectomia.Enabled = False
        Me.txtApendicectomia.Location = New System.Drawing.Point(120, 32)
        Me.txtApendicectomia.Name = "txtApendicectomia"
        Me.txtApendicectomia.Size = New System.Drawing.Size(368, 20)
        Me.txtApendicectomia.TabIndex = 2
        Me.txtApendicectomia.Text = ""
        '
        'chkCesarea
        '
        Me.chkCesarea.Location = New System.Drawing.Point(8, 56)
        Me.chkCesarea.Name = "chkCesarea"
        Me.chkCesarea.TabIndex = 3
        Me.chkCesarea.Text = "Cesárea(s)"
        '
        'txtCesarea
        '
        Me.txtCesarea.Enabled = False
        Me.txtCesarea.Location = New System.Drawing.Point(120, 56)
        Me.txtCesarea.Name = "txtCesarea"
        Me.txtCesarea.Size = New System.Drawing.Size(368, 20)
        Me.txtCesarea.TabIndex = 4
        Me.txtCesarea.Text = ""
        '
        'chkHisterectomia
        '
        Me.chkHisterectomia.Location = New System.Drawing.Point(8, 104)
        Me.chkHisterectomia.Name = "chkHisterectomia"
        Me.chkHisterectomia.TabIndex = 7
        Me.chkHisterectomia.Text = "Histerectomía"
        '
        'txtHisterectomia
        '
        Me.txtHisterectomia.Enabled = False
        Me.txtHisterectomia.Location = New System.Drawing.Point(120, 104)
        Me.txtHisterectomia.Name = "txtHisterectomia"
        Me.txtHisterectomia.Size = New System.Drawing.Size(368, 20)
        Me.txtHisterectomia.TabIndex = 8
        Me.txtHisterectomia.Text = ""
        '
        'chkProlapso
        '
        Me.chkProlapso.Location = New System.Drawing.Point(8, 128)
        Me.chkProlapso.Name = "chkProlapso"
        Me.chkProlapso.TabIndex = 9
        Me.chkProlapso.Text = "Cura Prolapso"
        '
        'txtProlapso
        '
        Me.txtProlapso.Enabled = False
        Me.txtProlapso.Location = New System.Drawing.Point(120, 128)
        Me.txtProlapso.Name = "txtProlapso"
        Me.txtProlapso.Size = New System.Drawing.Size(368, 20)
        Me.txtProlapso.TabIndex = 10
        Me.txtProlapso.Text = ""
        '
        'chkEsterilizacion
        '
        Me.chkEsterilizacion.Location = New System.Drawing.Point(8, 152)
        Me.chkEsterilizacion.Name = "chkEsterilizacion"
        Me.chkEsterilizacion.TabIndex = 11
        Me.chkEsterilizacion.Text = "Esterilización"
        '
        'txtEsterilizacion
        '
        Me.txtEsterilizacion.Enabled = False
        Me.txtEsterilizacion.Location = New System.Drawing.Point(120, 152)
        Me.txtEsterilizacion.Name = "txtEsterilizacion"
        Me.txtEsterilizacion.Size = New System.Drawing.Size(368, 20)
        Me.txtEsterilizacion.TabIndex = 12
        Me.txtEsterilizacion.Text = ""
        '
        'chkConizacion
        '
        Me.chkConizacion.Location = New System.Drawing.Point(8, 176)
        Me.chkConizacion.Name = "chkConizacion"
        Me.chkConizacion.TabIndex = 13
        Me.chkConizacion.Text = "Conización"
        '
        'txtConizacion
        '
        Me.txtConizacion.Enabled = False
        Me.txtConizacion.Location = New System.Drawing.Point(120, 176)
        Me.txtConizacion.Name = "txtConizacion"
        Me.txtConizacion.Size = New System.Drawing.Size(368, 20)
        Me.txtConizacion.TabIndex = 14
        Me.txtConizacion.Text = ""
        '
        'chkLaparotomia
        '
        Me.chkLaparotomia.Location = New System.Drawing.Point(8, 200)
        Me.chkLaparotomia.Name = "chkLaparotomia"
        Me.chkLaparotomia.TabIndex = 15
        Me.chkLaparotomia.Text = "Laparotomía"
        '
        'txtLaparotomia
        '
        Me.txtLaparotomia.Enabled = False
        Me.txtLaparotomia.Location = New System.Drawing.Point(120, 200)
        Me.txtLaparotomia.Name = "txtLaparotomia"
        Me.txtLaparotomia.Size = New System.Drawing.Size(368, 20)
        Me.txtLaparotomia.TabIndex = 16
        Me.txtLaparotomia.Text = ""
        '
        'chkNoduloMamario
        '
        Me.chkNoduloMamario.Location = New System.Drawing.Point(8, 224)
        Me.chkNoduloMamario.Name = "chkNoduloMamario"
        Me.chkNoduloMamario.Size = New System.Drawing.Size(112, 24)
        Me.chkNoduloMamario.TabIndex = 17
        Me.chkNoduloMamario.Text = "Nódulo Mamario"
        '
        'txtNoduloMamario
        '
        Me.txtNoduloMamario.Enabled = False
        Me.txtNoduloMamario.Location = New System.Drawing.Point(120, 224)
        Me.txtNoduloMamario.Name = "txtNoduloMamario"
        Me.txtNoduloMamario.Size = New System.Drawing.Size(368, 20)
        Me.txtNoduloMamario.TabIndex = 18
        Me.txtNoduloMamario.Text = ""
        '
        'chkOtros
        '
        Me.chkOtros.Location = New System.Drawing.Point(8, 248)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(112, 24)
        Me.chkOtros.TabIndex = 19
        Me.chkOtros.Text = "Otros"
        '
        'txtOtros
        '
        Me.txtOtros.Enabled = False
        Me.txtOtros.Location = New System.Drawing.Point(120, 248)
        Me.txtOtros.Multiline = True
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOtros.Size = New System.Drawing.Size(368, 64)
        Me.txtOtros.TabIndex = 20
        Me.txtOtros.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(128, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año de la(s) Operación(es)"
        '
        'chkEsplenectomia
        '
        Me.chkEsplenectomia.Location = New System.Drawing.Point(8, 80)
        Me.chkEsplenectomia.Name = "chkEsplenectomia"
        Me.chkEsplenectomia.TabIndex = 5
        Me.chkEsplenectomia.Text = "Esplenectomía"
        '
        'txtEsplenectomia
        '
        Me.txtEsplenectomia.Enabled = False
        Me.txtEsplenectomia.Location = New System.Drawing.Point(120, 80)
        Me.txtEsplenectomia.Name = "txtEsplenectomia"
        Me.txtEsplenectomia.Size = New System.Drawing.Size(368, 20)
        Me.txtEsplenectomia.TabIndex = 6
        Me.txtEsplenectomia.Text = ""
        '
        'botCancelar
        '
        Me.botCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botCancelar.Location = New System.Drawing.Point(48, 328)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(120, 23)
        Me.botCancelar.TabIndex = 21
        Me.botCancelar.Text = "Cancelar"
        '
        'botAceptar
        '
        Me.botAceptar.Location = New System.Drawing.Point(336, 328)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(120, 23)
        Me.botAceptar.TabIndex = 22
        Me.botAceptar.Text = "Aceptar"
        '
        'FormAntQuirurgicos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 360)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.botAceptar, Me.botCancelar, Me.txtEsplenectomia, Me.chkEsplenectomia, Me.Label1, Me.txtOtros, Me.chkOtros, Me.txtNoduloMamario, Me.chkNoduloMamario, Me.txtLaparotomia, Me.chkLaparotomia, Me.txtConizacion, Me.chkConizacion, Me.txtEsterilizacion, Me.chkEsterilizacion, Me.txtProlapso, Me.chkProlapso, Me.txtHisterectomia, Me.chkHisterectomia, Me.txtCesarea, Me.chkCesarea, Me.txtApendicectomia, Me.chkApendicectomia})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormAntQuirurgicos"
        Me.ShowInTaskbar = False
        Me.Text = "Antecedentes Quirúrgicos"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared ResultadoAntecedentesQuirurgicos As String = ""

    Private Sub botAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botAceptar.Click
        ConstruyeAntecedentes()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub chkApendicectomia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApendicectomia.CheckedChanged
        If chkApendicectomia.Checked = True Then
            txtApendicectomia.Enabled = True
            txtApendicectomia.Focus()
        Else
            txtApendicectomia.Enabled = False
            txtApendicectomia.Clear()
        End If
    End Sub

    Private Sub chkCesarea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCesarea.CheckedChanged
        If chkCesarea.Checked = True Then
            txtCesarea.Enabled = True
            txtCesarea.Focus()
        Else
            txtCesarea.Clear()
            txtCesarea.Enabled = False
        End If
    End Sub

    Private Sub chkEsplenectomia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEsplenectomia.CheckedChanged
        If chkEsplenectomia.Checked = True Then
            txtEsplenectomia.Enabled = True
            txtEsplenectomia.Focus()
        Else
            txtEsplenectomia.Clear()
            txtEsplenectomia.Enabled = False
        End If
    End Sub

    Private Sub chkHisterectomia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHisterectomia.CheckedChanged
        If chkHisterectomia.Checked = True Then
            txtHisterectomia.Enabled = True
            txtHisterectomia.Focus()
        Else
            txtHisterectomia.Clear()
            txtHisterectomia.Enabled = False
        End If
    End Sub

    Private Sub chkProlapso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProlapso.CheckedChanged
        If chkProlapso.Checked = True Then
            txtProlapso.Enabled = True
            txtProlapso.Focus()
        Else
            txtProlapso.Clear()
            txtProlapso.Enabled = False
        End If
    End Sub

    Private Sub chkEsterilizacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEsterilizacion.CheckedChanged
        If chkEsterilizacion.Checked = True Then
            txtEsterilizacion.Enabled = True
            txtEsterilizacion.Focus()
        Else
            txtEsterilizacion.Clear()
            txtEsterilizacion.Enabled = False
        End If
    End Sub

    Private Sub chkConizacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConizacion.CheckedChanged
        If chkConizacion.Checked = True Then
            txtConizacion.Enabled = True
            txtConizacion.Focus()
        Else
            txtConizacion.Clear()
            txtConizacion.Enabled = False
        End If
    End Sub

    Private Sub chkLaparotomia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLaparotomia.CheckedChanged
        If chkLaparotomia.Checked = True Then
            txtLaparotomia.Enabled = True
            txtLaparotomia.Focus()
        Else
            txtLaparotomia.Clear()
            txtLaparotomia.Enabled = False
        End If
    End Sub

    Private Sub chkNoduloMamario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoduloMamario.CheckedChanged
        If chkNoduloMamario.Checked = True Then
            txtNoduloMamario.Enabled = True
            txtNoduloMamario.Focus()
        Else
            txtNoduloMamario.Clear()
            txtNoduloMamario.Enabled = False
        End If
    End Sub

    Private Sub chkOtros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOtros.CheckedChanged
        If chkOtros.Checked = True Then
            txtOtros.Enabled = True
            txtOtros.Focus()
        Else
            txtOtros.Clear()
            txtOtros.Enabled = False
        End If
    End Sub

    Private Sub ConstruyeAntecedentes()
        Dim Antecedentes As String
        Dim ExisteunAntecedente As Boolean

        Antecedentes = ""
        ExisteunAntecedente = False

        If chkApendicectomia.Checked = True Then
            Antecedentes += "Apendicectomía " & txtApendicectomia.Text & vbCrLf
            ExisteunAntecedente = True
        End If
        If chkCesarea.Checked = True Then
            Antecedentes += "Cesarea(s) " & txtCesarea.Text & vbCrLf
            ExisteunAntecedente = True
        End If
        If chkEsplenectomia.Checked = True Then
            Antecedentes += "Esplenectomía " & txtEsplenectomia.Text & vbCrLf
            ExisteunAntecedente = True
        End If
        If chkHisterectomia.Checked = True Then
            Antecedentes += "Histerectomía " & txtHisterectomia.Text & vbCrLf
            ExisteunAntecedente = True
        End If
        If chkProlapso.Checked = True Then
            Antecedentes += "Cura de Prolapso " & txtProlapso.Text & vbCrLf
            ExisteunAntecedente = True
        End If
        If chkEsterilizacion.Checked Then
            Antecedentes += "Esterilización " & txtEsterilizacion.Text & vbCrLf
            ExisteunAntecedente = True
        End If
        If chkConizacion.Checked = True Then
            Antecedentes += "Conización " & txtConizacion.Text & vbCrLf
            ExisteunAntecedente = True
        End If
        If chkLaparotomia.Checked = True Then
            Antecedentes += "Laparotomía " & txtLaparotomia.Text & vbCrLf
            ExisteunAntecedente = True
        End If
        If chkNoduloMamario.Checked = True Then
            Antecedentes += "Nódulo Mamario " & txtNoduloMamario.Text & vbCrLf
            ExisteunAntecedente = True
        End If
        If chkOtros.Checked = True Then
            Antecedentes += txtOtros.Text & vbCrLf
            ExisteunAntecedente = True
        End If
        If ExisteunAntecedente = False Then
            Antecedentes = "Niega antecedentes quirúrgicos." & vbCrLf
        End If

        ResultadoAntecedentesQuirurgicos = Antecedentes

    End Sub

    Private Sub botCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
