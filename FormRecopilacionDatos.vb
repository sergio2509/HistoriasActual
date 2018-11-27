Public Class FormRecopilacionDatos
    Private Sub FormRecopilacionDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'muestra mensaje de los datos
        Select Case Form1.PS_strTipoDeDatoMostrado
            Case "DatosDoppler"
                Me.Text = "Recopilación de datos doppler"
                TextBox1.Text = Form1.PS_strRecopilacionDatos

            Case "ResumenControl"
                Me.Text = "Resumen del Control Prenatal de la Pte. " & Form1.PSstrPacienteSeleccionadaNombre
                TextBox1.Text = Form1.PS_strResumenDelControl

        End Select






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
    End Sub

End Class