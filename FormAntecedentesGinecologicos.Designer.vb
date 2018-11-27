<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAntecedentesGinecologicos
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
        Me.txtAntGinecologicos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.botAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAntGinecologicos
        '
        Me.txtAntGinecologicos.Location = New System.Drawing.Point(15, 28)
        Me.txtAntGinecologicos.MaxLength = 2000
        Me.txtAntGinecologicos.Multiline = True
        Me.txtAntGinecologicos.Name = "txtAntGinecologicos"
        Me.txtAntGinecologicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAntGinecologicos.Size = New System.Drawing.Size(953, 152)
        Me.txtAntGinecologicos.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Resumen de los Antecedentes Ginecológicos"
        '
        'botCancelar
        '
        Me.botCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botCancelar.Location = New System.Drawing.Point(12, 637)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(152, 23)
        Me.botCancelar.TabIndex = 30
        Me.botCancelar.Text = "Cancelar"
        '
        'botAceptar
        '
        Me.botAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botAceptar.Location = New System.Drawing.Point(830, 637)
        Me.botAceptar.Name = "botAceptar"
        Me.botAceptar.Size = New System.Drawing.Size(152, 23)
        Me.botAceptar.TabIndex = 29
        Me.botAceptar.Text = "Aceptar"
        '
        'FormAntecedentesGinecologicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtAntGinecologicos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botCancelar)
        Me.Controls.Add(Me.botAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormAntecedentesGinecologicos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antecedentes Ginecológicos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAntGinecologicos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents botAceptar As System.Windows.Forms.Button
End Class
