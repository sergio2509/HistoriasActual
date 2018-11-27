<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGuardias
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
        Me.Calendario1 = New System.Windows.Forms.MonthCalendar
        Me.botAceptar = New System.Windows.Forms.Button
        Me.botElimina = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDescripcion3 = New System.Windows.Forms.TextBox
        Me.txtLugar3 = New System.Windows.Forms.TextBox
        Me.txtDescripcion2 = New System.Windows.Forms.TextBox
        Me.txtLugar2 = New System.Windows.Forms.TextBox
        Me.botCancelar = New System.Windows.Forms.Button
        Me.txtDescripcion1 = New System.Windows.Forms.TextBox
        Me.txtLugar1 = New System.Windows.Forms.TextBox
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.botEdicion = New System.Windows.Forms.Button
        Me.botFinalizar = New System.Windows.Forms.Button
        Me.botDescartar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Calendario1
        '
        Me.Calendario1.CalendarDimensions = New System.Drawing.Size(4, 1)
        Me.Calendario1.Location = New System.Drawing.Point(51, 7)
        Me.Calendario1.Name = "Calendario1"
        Me.Calendario1.ShowToday = False
        Me.Calendario1.ShowTodayCircle = False
        Me.Calendario1.TabIndex = 0
        '
        'botAceptar
        '
        Me.botAceptar.Location = New System.Drawing.Point(6, 150)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(218, 23)
        Me.botAceptar.TabIndex = 10
        Me.botAceptar.Text = "Aceptar"
        Me.botAceptar.UseVisualStyleBackColor = True
        '
        'botElimina
        '
        Me.botElimina.Location = New System.Drawing.Point(558, 181)
        Me.botElimina.Name = "botElimina"
        Me.botElimina.Size = New System.Drawing.Size(218, 23)
        Me.botElimina.TabIndex = 2
        Me.botElimina.Text = "Elimina Evento"
        Me.botElimina.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescripcion3)
        Me.GroupBox1.Controls.Add(Me.txtLugar3)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion2)
        Me.GroupBox1.Controls.Add(Me.txtLugar2)
        Me.GroupBox1.Controls.Add(Me.botCancelar)
        Me.GroupBox1.Controls.Add(Me.botAceptar)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion1)
        Me.GroupBox1.Controls.Add(Me.txtLugar1)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 180)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Evento"
        '
        'txtDescripcion3
        '
        Me.txtDescripcion3.Location = New System.Drawing.Point(245, 124)
        Me.txtDescripcion3.MaxLength = 60
        Me.txtDescripcion3.Name = "txtDescripcion3"
        Me.txtDescripcion3.Size = New System.Drawing.Size(519, 20)
        Me.txtDescripcion3.TabIndex = 9
        '
        'txtLugar3
        '
        Me.txtLugar3.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Maternidad Sta María", "Clínica Sinaí", "Amauri Rengel", "Sinaí", "Clinica Amauri Rengel", "Cruz Roja", "Centro Quirurgico"})
        Me.txtLugar3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtLugar3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLugar3.Location = New System.Drawing.Point(6, 124)
        Me.txtLugar3.MaxLength = 60
        Me.txtLugar3.Name = "txtLugar3"
        Me.txtLugar3.Size = New System.Drawing.Size(218, 20)
        Me.txtLugar3.TabIndex = 8
        '
        'txtDescripcion2
        '
        Me.txtDescripcion2.Location = New System.Drawing.Point(245, 97)
        Me.txtDescripcion2.MaxLength = 60
        Me.txtDescripcion2.Name = "txtDescripcion2"
        Me.txtDescripcion2.Size = New System.Drawing.Size(519, 20)
        Me.txtDescripcion2.TabIndex = 7
        '
        'txtLugar2
        '
        Me.txtLugar2.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Maternidad Sta María", "Clínica Sinaí", "Amauri Rengel", "Sinaí", "Clinica Amauri Rengel", "Cruz Roja", "Centro Quirurgico"})
        Me.txtLugar2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtLugar2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLugar2.Location = New System.Drawing.Point(6, 97)
        Me.txtLugar2.MaxLength = 60
        Me.txtLugar2.Name = "txtLugar2"
        Me.txtLugar2.Size = New System.Drawing.Size(218, 20)
        Me.txtLugar2.TabIndex = 6
        '
        'botCancelar
        '
        Me.botCancelar.Location = New System.Drawing.Point(546, 150)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(218, 23)
        Me.botCancelar.TabIndex = 11
        Me.botCancelar.Text = "Cancelar"
        Me.botCancelar.UseVisualStyleBackColor = True
        '
        'txtDescripcion1
        '
        Me.txtDescripcion1.Location = New System.Drawing.Point(245, 71)
        Me.txtDescripcion1.MaxLength = 60
        Me.txtDescripcion1.Name = "txtDescripcion1"
        Me.txtDescripcion1.Size = New System.Drawing.Size(519, 20)
        Me.txtDescripcion1.TabIndex = 5
        '
        'txtLugar1
        '
        Me.txtLugar1.AutoCompleteCustomSource.AddRange(New String() {"Maternidad del Este", "Maternidad Sta María", "Clínica Sinaí", "Amauri Rengel", "Sinaí", "Clinica Amauri Rengel", "Cruz Roja", "Centro Quirurgico"})
        Me.txtLugar1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtLugar1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLugar1.Location = New System.Drawing.Point(6, 71)
        Me.txtLugar1.MaxLength = 60
        Me.txtLugar1.Name = "txtLugar1"
        Me.txtLugar1.Size = New System.Drawing.Size(218, 20)
        Me.txtLugar1.TabIndex = 4
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(6, 32)
        Me.txtFecha.MaxLength = 30
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(218, 20)
        Me.txtFecha.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lugar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha"
        '
        'botEdicion
        '
        Me.botEdicion.Location = New System.Drawing.Point(18, 185)
        Me.botEdicion.Name = "botEdicion"
        Me.botEdicion.Size = New System.Drawing.Size(218, 23)
        Me.botEdicion.TabIndex = 1
        Me.botEdicion.Text = "Edición de Fecha"
        Me.botEdicion.UseVisualStyleBackColor = True
        '
        'botFinalizar
        '
        Me.botFinalizar.Location = New System.Drawing.Point(290, 423)
        Me.botFinalizar.Name = "botFinalizar"
        Me.botFinalizar.Size = New System.Drawing.Size(218, 23)
        Me.botFinalizar.TabIndex = 4
        Me.botFinalizar.Text = "No se han producido cambios"
        Me.botFinalizar.UseVisualStyleBackColor = True
        '
        'botDescartar
        '
        Me.botDescartar.Location = New System.Drawing.Point(290, 452)
        Me.botDescartar.Name = "botDescartar"
        Me.botDescartar.Size = New System.Drawing.Size(218, 23)
        Me.botDescartar.TabIndex = 5
        Me.botDescartar.Text = "Salir"
        Me.botDescartar.UseVisualStyleBackColor = True
        '
        'FormGuardias
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(794, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.botDescartar)
        Me.Controls.Add(Me.botFinalizar)
        Me.Controls.Add(Me.botEdicion)
        Me.Controls.Add(Me.botElimina)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Calendario1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormGuardias"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eventos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Calendario1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents botAceptar As System.Windows.Forms.Button
    Friend WithEvents botElimina As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion1 As System.Windows.Forms.TextBox
    Friend WithEvents txtLugar1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents botEdicion As System.Windows.Forms.Button
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion3 As System.Windows.Forms.TextBox
    Friend WithEvents txtLugar3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion2 As System.Windows.Forms.TextBox
    Friend WithEvents txtLugar2 As System.Windows.Forms.TextBox
    Friend WithEvents botFinalizar As System.Windows.Forms.Button
    Friend WithEvents botDescartar As System.Windows.Forms.Button
End Class
