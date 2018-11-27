Public Class FormPresentacion
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
    Friend WithEvents Label1 As System.Windows.Forms.Label

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(200, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "© Sergio González. Versión 20180716"
        '
        'FormPresentacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Historias.My.Resources.Resources.Splash20180305
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormPresentacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region





    Private Sub FormPresentacion_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub FormPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormPresentacion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim segundos As TimeSpan
        Dim instantedecarga = Now

        Me.Refresh()

        segundos = TimeSpan.FromSeconds(5)


        While Now - instantedecarga < segundos



        End While

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class
