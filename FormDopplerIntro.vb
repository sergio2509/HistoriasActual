Public Class FormDopplerIntro

    Dim strValor(8) As String
    Dim decValor(8) As Decimal



    Private Sub FormDopplerIntro_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBox0.Focus()
    End Sub

    Private Sub FormDopplerIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = FormDoppler.PS_strMensajeTitulo

        CargaDatos()

        MuestraDatos()

    End Sub



    Private Sub CargaDatos()
        'verifica si vienen datos, si no inicializa
        If FormDoppler.PS_strLineaActual <> "" Then
            strValor = Split(FormDoppler.PS_strLineaActual, "\", 9)
        Else
            For intX = 0 To 8
                strValor(intX) = ""
                decValor(intX) = 0
            Next
        End If
    End Sub

    Private Sub MuestraDatos()
        TextBox0.Text = strValor(0)
        TextBox1.Text = strValor(1)
        TextBox2.Text = strValor(2)
        TextBox3.Text = strValor(3)
        TextBox4.Text = strValor(4)
        TextBox5.Text = strValor(5)
        TextBox6.Text = strValor(6)
        TextBox7.Text = strValor(7)
        TextBox8.Text = strValor(8)

    End Sub

    ' keypress
    Private Sub txtValores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                    Handles TextBox0.KeyPress, TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress,
                            TextBox5.KeyPress, TextBox6.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress


        Dim strEscrito As String = sender.text


        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsControl(c) Or Char.IsDigit(c) Or c = ".") Then
            e.Handled = True
        Else
            If c = "." Then
                If strEscrito.Contains(".") Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    'formateo de salida
    Private Sub TextBoxValores_LostFocus(sender As Object, e As EventArgs) Handles TextBox0.LostFocus, TextBox1.LostFocus, TextBox2.LostFocus, TextBox3.LostFocus,
                                                                                   TextBox4.LostFocus, TextBox5.LostFocus, TextBox6.LostFocus, TextBox7.LostFocus,
                                                                                   TextBox8.LostFocus


        Dim decValorlocal As Decimal

        'si esta en blanco o no se puede convertir a decimal se pone a -100
        Select Case sender.name
            Case "TextBox0"
                If TextBox0.Text <> "" Then
                    If IsNumeric(TextBox0.Text) Then
                        decValorlocal = CType(TextBox0.Text, Decimal)
                    Else
                        TextBox0.Text = TextBox0.Text.Replace(".", ",")
                        If IsNumeric(TextBox0.Text) Then
                            decValorlocal = CType(TextBox0.Text, Decimal)
                        Else
                            decValorlocal = -100
                        End If
                    End If
                Else
                    decValorlocal = -100
                End If
                'formatea el campo de vuelta al textbox
                If decValorlocal <> -100 Then
                    TextBox0.Text = FormatNumber(decValorlocal, 2, TriState.True,,)
                Else
                    TextBox0.Clear()
                End If

            Case "TextBox1"
                If TextBox1.Text <> "" Then
                    If IsNumeric(TextBox1.Text) Then
                        decValorlocal = CType(TextBox1.Text, Decimal)
                    Else
                        TextBox1.Text = TextBox1.Text.Replace(".", ",")
                        If IsNumeric(TextBox1.Text) Then
                            decValorlocal = CType(TextBox1.Text, Decimal)
                        Else
                            decValorlocal = -100
                        End If
                    End If
                Else
                    decValorlocal = -100
                End If
                'formatea el campo de vuelta al textbox
                If decValorlocal <> -100 Then
                    TextBox1.Text = FormatNumber(decValorlocal, 2, TriState.True,,)
                Else
                    TextBox1.Clear()
                End If

            Case "TextBox2"
                If TextBox2.Text <> "" Then
                    If IsNumeric(TextBox2.Text) Then
                        decValorlocal = CType(TextBox2.Text, Decimal)
                    Else
                        TextBox2.Text = TextBox2.Text.Replace(".", ",")
                        If IsNumeric(TextBox2.Text) Then
                            decValorlocal = CType(TextBox2.Text, Decimal)
                        Else
                            decValorlocal = -100
                        End If
                    End If
                Else
                    decValorlocal = -100
                End If
                'formatea el campo de vuelta al textbox
                If decValorlocal <> -100 Then
                    TextBox2.Text = FormatNumber(decValorlocal, 2, TriState.True,,)
                Else
                    TextBox2.Clear()
                End If

            Case "TextBox3"
                If TextBox3.Text <> "" Then
                    If IsNumeric(TextBox3.Text) Then
                        decValorlocal = CType(TextBox3.Text, Decimal)
                    Else
                        TextBox3.Text = TextBox3.Text.Replace(".", ",")
                        If IsNumeric(TextBox3.Text) Then
                            decValorlocal = CType(TextBox3.Text, Decimal)
                        Else
                            decValorlocal = -100
                        End If
                    End If
                Else
                    decValorlocal = -100
                End If
                'formatea el campo de vuelta al textbox
                If decValorlocal <> -100 Then
                    TextBox3.Text = FormatNumber(decValorlocal, 2, TriState.True,,)
                Else
                    TextBox3.Clear()
                End If

            Case "TextBox4"
                If TextBox4.Text <> "" Then
                    If IsNumeric(TextBox4.Text) Then
                        decValorlocal = CType(TextBox4.Text, Decimal)
                    Else
                        TextBox4.Text = TextBox4.Text.Replace(".", ",")
                        If IsNumeric(TextBox4.Text) Then
                            decValorlocal = CType(TextBox4.Text, Decimal)
                        Else
                            decValorlocal = -100
                        End If
                    End If
                Else
                    decValorlocal = -100
                End If
                'formatea el campo de vuelta al textbox
                If decValorlocal <> -100 Then
                    TextBox4.Text = FormatNumber(decValorlocal, 2, TriState.True,,)
                Else
                    TextBox4.Clear()
                End If

            Case "TextBox5"
                If TextBox5.Text <> "" Then
                    If IsNumeric(TextBox5.Text) Then
                        decValorlocal = CType(TextBox5.Text, Decimal)
                    Else
                        TextBox5.Text = TextBox5.Text.Replace(".", ",")
                        If IsNumeric(TextBox5.Text) Then
                            decValorlocal = CType(TextBox5.Text, Decimal)
                        Else
                            decValorlocal = -100
                        End If
                    End If
                Else
                    decValorlocal = -100
                End If
                'formatea el campo de vuelta al textbox
                If decValorlocal <> -100 Then
                    TextBox5.Text = FormatNumber(decValorlocal, 2, TriState.True,,)
                Else
                    TextBox5.Clear()
                End If

            Case "TextBox6"
                If TextBox6.Text <> "" Then
                    If IsNumeric(TextBox6.Text) Then
                        decValorlocal = CType(TextBox6.Text, Decimal)
                    Else
                        TextBox6.Text = TextBox6.Text.Replace(".", ",")
                        If IsNumeric(TextBox6.Text) Then
                            decValorlocal = CType(TextBox6.Text, Decimal)
                        Else
                            decValorlocal = -100
                        End If
                    End If
                Else
                    decValorlocal = -100
                End If
                'formatea el campo de vuelta al textbox
                If decValorlocal <> -100 Then
                    TextBox6.Text = FormatNumber(decValorlocal, 2, TriState.True,,)
                Else
                    TextBox6.Clear()
                End If

            Case "TextBox7"
                If TextBox7.Text <> "" Then
                    If IsNumeric(TextBox7.Text) Then
                        decValorlocal = CType(TextBox7.Text, Decimal)
                    Else
                        TextBox7.Text = TextBox7.Text.Replace(".", ",")
                        If IsNumeric(TextBox7.Text) Then
                            decValorlocal = CType(TextBox7.Text, Decimal)
                        Else
                            decValorlocal = -100
                        End If
                    End If
                Else
                    decValorlocal = -100
                End If
                'formatea el campo de vuelta al textbox
                If decValorlocal <> -100 Then
                    TextBox7.Text = FormatNumber(decValorlocal, 2, TriState.True,,)
                Else
                    TextBox7.Clear()
                End If

            Case "TextBox8"
                If TextBox8.Text <> "" Then
                    If IsNumeric(TextBox8.Text) Then
                        decValorlocal = CType(TextBox8.Text, Decimal)
                    Else
                        TextBox8.Text = TextBox8.Text.Replace(".", ",")
                        If IsNumeric(TextBox8.Text) Then
                            decValorlocal = CType(TextBox8.Text, Decimal)
                        Else
                            decValorlocal = -100
                        End If
                    End If
                Else
                    decValorlocal = -100
                End If
                'formatea el campo de vuelta al textbox
                If decValorlocal <> -100 Then
                    TextBox8.Text = FormatNumber(decValorlocal, 2, TriState.True,,)
                Else
                    TextBox8.Clear()
                End If




        End Select

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'acepto cambios ensambla el chorizo
        FormDoppler.PS_strLineaActual = ""
        FormDoppler.PS_strLineaActual += TextBox0.Text & "\" & TextBox1.Text & "\" & TextBox2.Text & "\" & TextBox3.Text & "\"
        FormDoppler.PS_strLineaActual += TextBox4.Text & "\" & TextBox5.Text & "\" & TextBox6.Text & "\" & TextBox7.Text & "\" & TextBox8.Text

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

End Class