Imports System.IO

Public Class FormDoppler

    Dim strLineaDeDatos(15) As String
    Public Shared PS_strLineaActual As String
    Public Shared PS_strMensajeTitulo As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'acepto cambios ensambla el chorizo
        FormControlObstetrico.PS_strChorizoDeDatosDoppler = ""
        FormControlObstetrico.PS_strChorizoDeDatosDoppler += strLineaDeDatos(0) & "|" & strLineaDeDatos(1) & "|" & strLineaDeDatos(2) & "|" & strLineaDeDatos(3) & "|"
        FormControlObstetrico.PS_strChorizoDeDatosDoppler += strLineaDeDatos(4) & "|" & strLineaDeDatos(5) & "|" & strLineaDeDatos(6) & "|" & strLineaDeDatos(7) & "|"
        FormControlObstetrico.PS_strChorizoDeDatosDoppler += strLineaDeDatos(8) & "|" & strLineaDeDatos(9) & "|" & strLineaDeDatos(10) & "|" & strLineaDeDatos(11) & "|"
        FormControlObstetrico.PS_strChorizoDeDatosDoppler += strLineaDeDatos(12) & "|" & strLineaDeDatos(13) & "|" & strLineaDeDatos(14) & "|" & strLineaDeDatos(15)



        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub




    Private Sub FormDoppler_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargaDatos()
        BorraPantalla()
        EnciendeLineas()
        MuestraDatos()

    End Sub
    Private Sub FormDoppler_Activated(sender As Object, e As EventArgs) Handles Me.Activated



    End Sub


    Private Sub CargaDatos()
        'revisa si vienen datos
        If FormControlObstetrico.PS_strChorizoDeDatosDoppler <> "" Then
            strLineaDeDatos = Split(FormControlObstetrico.PS_strChorizoDeDatosDoppler, "|")
        Else
            For intX = 0 To 15
                strLineaDeDatos(intX) = ""
            Next
        End If
    End Sub

    Private Sub BorraPantalla()
        LabelFecha00.Text = "" : LabelFecha01.Text = "" : LabelFecha02.Text = "" : LabelFecha03.Text = "" : LabelFecha04.Text = "" : LabelFecha05.Text = ""
        LabelFecha06.Text = "" : LabelFecha07.Text = "" : LabelFecha08.Text = "" : LabelFecha09.Text = "" : LabelFecha10.Text = "" : LabelFecha11.Text = ""
        LabelFecha12.Text = "" : LabelFecha13.Text = "" : LabelFecha14.Text = "" : LabelFecha15.Text = ""
        LabelDatos00.Text = "" : LabelDatos01.Text = "" : LabelDatos02.Text = "" : LabelDatos03.Text = "" : LabelDatos04.Text = "" : LabelDatos05.Text = ""
        LabelDatos06.Text = "" : LabelDatos07.Text = "" : LabelDatos08.Text = "" : LabelDatos09.Text = "" : LabelDatos10.Text = "" : LabelDatos11.Text = ""
        LabelDatos12.Text = "" : LabelDatos13.Text = "" : LabelDatos14.Text = "" : LabelDatos15.Text = ""

    End Sub

    Private Sub EnciendeLineas()
        If FormControlObstetrico.PS_arrayFechas(0) <> "   " Then
            LabelFecha00.Text = FormControlObstetrico.PS_arrayFechas(0)
            LabelFecha00.Visible = True
            LabelDatos00.Visible = True
            Button00.Visible = True
        Else
            LabelFecha00.Visible = False
            LabelDatos00.Visible = False
            Button00.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(1) <> "   " Then
            LabelFecha01.Text = FormControlObstetrico.PS_arrayFechas(1)
            LabelFecha01.Visible = True
            LabelDatos01.Visible = True
            Button01.Visible = True
        Else
            LabelFecha01.Visible = False
            LabelDatos01.Visible = False
            Button01.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(2) <> "   " Then
            LabelFecha02.Text = FormControlObstetrico.PS_arrayFechas(2)
            LabelFecha02.Visible = True
            LabelDatos02.Visible = True
            Button02.Visible = True
        Else
            LabelFecha02.Visible = False
            LabelDatos02.Visible = False
            Button02.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(3) <> "   " Then
            LabelFecha03.Text = FormControlObstetrico.PS_arrayFechas(3)
            LabelFecha03.Visible = True
            LabelDatos03.Visible = True
            Button03.Visible = True
        Else
            LabelFecha03.Visible = False
            LabelDatos03.Visible = False
            Button03.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(4) <> "   " Then
            LabelFecha04.Text = FormControlObstetrico.PS_arrayFechas(4)
            LabelFecha04.Visible = True
            LabelDatos04.Visible = True
            Button04.Visible = True
        Else
            LabelFecha04.Visible = False
            LabelDatos04.Visible = False
            Button04.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(5) <> "   " Then
            LabelFecha05.Text = FormControlObstetrico.PS_arrayFechas(5)
            LabelFecha05.Visible = True
            LabelDatos05.Visible = True
            Button05.Visible = True
        Else
            LabelFecha05.Visible = False
            LabelDatos05.Visible = False
            Button05.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(6) <> "   " Then
            LabelFecha06.Text = FormControlObstetrico.PS_arrayFechas(6)
            LabelFecha06.Visible = True
            LabelDatos06.Visible = True
            Button06.Visible = True
        Else
            LabelFecha06.Visible = False
            LabelDatos06.Visible = False
            Button06.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(7) <> "   " Then
            LabelFecha07.Text = FormControlObstetrico.PS_arrayFechas(7)
            LabelFecha07.Visible = True
            LabelDatos07.Visible = True
            Button07.Visible = True
        Else
            LabelFecha07.Visible = False
            LabelDatos07.Visible = False
            Button07.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(8) <> "   " Then
            LabelFecha08.Text = FormControlObstetrico.PS_arrayFechas(8)
            LabelFecha08.Visible = True
            LabelDatos08.Visible = True
            Button08.Visible = True
        Else
            LabelFecha08.Visible = False
            LabelDatos08.Visible = False
            Button08.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(9) <> "   " Then
            LabelFecha09.Text = FormControlObstetrico.PS_arrayFechas(9)
            LabelFecha09.Visible = True
            LabelDatos09.Visible = True
            Button09.Visible = True
        Else
            LabelFecha09.Visible = False
            LabelDatos09.Visible = False
            Button09.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(10) <> "   " Then
            LabelFecha10.Text = FormControlObstetrico.PS_arrayFechas(10)
            LabelFecha10.Visible = True
            LabelDatos10.Visible = True
            Button10.Visible = True
        Else
            LabelFecha10.Visible = False
            LabelDatos10.Visible = False
            Button10.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(11) <> "   " Then
            LabelFecha11.Text = FormControlObstetrico.PS_arrayFechas(11)
            LabelFecha11.Visible = True
            LabelDatos11.Visible = True
            Button11.Visible = True
        Else
            LabelFecha11.Visible = False
            LabelDatos11.Visible = False
            Button11.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(12) <> "   " Then
            LabelFecha12.Text = FormControlObstetrico.PS_arrayFechas(12)
            LabelFecha12.Visible = True
            LabelDatos12.Visible = True
            Button12.Visible = True
        Else
            LabelFecha12.Visible = False
            LabelDatos12.Visible = False
            Button12.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(13) <> "   " Then
            LabelFecha13.Text = FormControlObstetrico.PS_arrayFechas(13)
            LabelFecha13.Visible = True
            LabelDatos13.Visible = True
            Button13.Visible = True
        Else
            LabelFecha13.Visible = False
            LabelDatos13.Visible = False
            Button13.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(14) <> "   " Then
            LabelFecha14.Text = FormControlObstetrico.PS_arrayFechas(14)
            LabelFecha14.Visible = True
            LabelDatos14.Visible = True
            Button14.Visible = True
        Else
            LabelFecha14.Visible = False
            LabelDatos14.Visible = False
            Button14.Visible = False
        End If
        If FormControlObstetrico.PS_arrayFechas(15) <> "   " Then
            LabelFecha15.Text = FormControlObstetrico.PS_arrayFechas(15)
            LabelFecha15.Visible = True
            LabelDatos15.Visible = True
            Button15.Visible = True
        Else
            LabelFecha15.Visible = False
            LabelDatos15.Visible = False
            Button15.Visible = False
        End If


        Dim strMsgLocal_A = "No se realizó ecografía esta fecha"
        Dim strMsgLocal_B = "Edad gestacional menor de 20 semanas"

        'filtro  de botones de edit... si hay eco y si es mayor de 20 semanas


        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(0) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(0) = True Then
            Button00.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(0) = False Then
            Button00.Enabled = False
            LabelDatos00.Text = strMsgLocal_A
        Else
            Button00.Enabled = False
            LabelDatos00.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(1) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(1) = True Then
            Button01.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(1) = False Then
            Button01.Enabled = False
            LabelDatos01.Text = strMsgLocal_A
        Else
            Button01.Enabled = False
            LabelDatos01.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(2) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(2) = True Then
            Button02.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(2) = False Then
            Button02.Enabled = False
            LabelDatos02.Text = strMsgLocal_A
        Else
            Button02.Enabled = False
            LabelDatos02.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(3) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(3) = True Then
            Button03.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(3) = False Then
            Button03.Enabled = False
            LabelDatos03.Text = strMsgLocal_A
        Else
            Button03.Enabled = False
            LabelDatos03.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(4) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(4) = True Then
            Button04.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(4) = False Then
            Button04.Enabled = False
            LabelDatos04.Text = strMsgLocal_A
        Else
            Button04.Enabled = False
            LabelDatos04.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(5) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(5) = True Then
            Button05.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(5) = False Then
            Button05.Enabled = False
            LabelDatos05.Text = strMsgLocal_A
        Else
            Button05.Enabled = False
            LabelDatos05.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(6) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(6) = True Then
            Button06.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(6) = False Then
            Button06.Enabled = False
            LabelDatos06.Text = strMsgLocal_A
        Else
            Button06.Enabled = False
            LabelDatos06.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(7) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(7) = True Then
            Button07.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(7) = False Then
            Button07.Enabled = False
            LabelDatos07.Text = strMsgLocal_A
        Else
            Button07.Enabled = False
            LabelDatos07.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(8) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(8) = True Then
            Button08.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(8) = False Then
            Button08.Enabled = False
            LabelDatos08.Text = strMsgLocal_A
        Else
            Button08.Enabled = False
            LabelDatos08.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(9) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(9) = True Then
            Button09.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(9) = False Then
            Button09.Enabled = False
            LabelDatos09.Text = strMsgLocal_A
        Else
            Button09.Enabled = False
            LabelDatos09.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(10) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(10) = True Then
            Button10.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(10) = False Then
            Button10.Enabled = False
            LabelDatos10.Text = strMsgLocal_A
        Else
            Button10.Enabled = False
            LabelDatos10.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(11) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(11) = True Then
            Button11.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(11) = False Then
            Button11.Enabled = False
            LabelDatos11.Text = strMsgLocal_A
        Else
            Button11.Enabled = False
            LabelDatos11.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(12) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(12) = True Then
            Button12.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(12) = False Then
            Button12.Enabled = False
            LabelDatos12.Text = strMsgLocal_A
        Else
            Button12.Enabled = False
            LabelDatos12.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(13) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(13) = True Then
            Button13.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(13) = False Then
            Button13.Enabled = False
            LabelDatos13.Text = strMsgLocal_A
        Else
            Button13.Enabled = False
            LabelDatos13.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(14) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(14) = True Then
            Button14.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(14) = False Then
            Button14.Enabled = False
            LabelDatos14.Text = strMsgLocal_A
        Else
            Button14.Enabled = False
            LabelDatos14.Text = strMsgLocal_B
        End If

        If FormControlObstetrico.PS_arrayHayEcoEnLaFecha(15) = True And FormControlObstetrico.PS_arrayEGmayorQue20Semanas(15) = True Then
            Button15.Enabled = True
        ElseIf FormControlObstetrico.PS_arrayHayEcoEnLaFecha(15) = False Then
            Button15.Enabled = False
            LabelDatos15.Text = strMsgLocal_A
        Else
            Button15.Enabled = False
            LabelDatos15.Text = strMsgLocal_B
        End If


    End Sub

    Private Sub MuestraDatos()

        If strLineaDeDatos(0) <> "" Then LabelDatos00.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(0))
        If strLineaDeDatos(1) <> "" Then LabelDatos01.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(1))
        If strLineaDeDatos(2) <> "" Then LabelDatos02.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(2))
        If strLineaDeDatos(3) <> "" Then LabelDatos03.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(3))
        If strLineaDeDatos(4) <> "" Then LabelDatos04.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(4))
        If strLineaDeDatos(5) <> "" Then LabelDatos05.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(5))
        If strLineaDeDatos(6) <> "" Then LabelDatos06.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(6))
        If strLineaDeDatos(7) <> "" Then LabelDatos07.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(7))
        If strLineaDeDatos(8) <> "" Then LabelDatos08.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(8))
        If strLineaDeDatos(9) <> "" Then LabelDatos09.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(9))
        If strLineaDeDatos(10) <> "" Then LabelDatos10.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(10))
        If strLineaDeDatos(11) <> "" Then LabelDatos11.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(11))
        If strLineaDeDatos(12) <> "" Then LabelDatos12.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(12))
        If strLineaDeDatos(13) <> "" Then LabelDatos13.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(13))
        If strLineaDeDatos(14) <> "" Then LabelDatos14.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(14))
        If strLineaDeDatos(15) <> "" Then LabelDatos15.Text = FuncionFormateaLineaParaPantalla(strLineaDeDatos(15))

    End Sub

    Function FuncionFormateaLineaParaPantalla(ByVal strChorizo As String) As String
        Dim strValores(9) As String
        Dim strChorizoFormateado As String = " "

        If strChorizo <> "" Then
            strValores = Split(strChorizo, "\", 9)
            For intX = 0 To 8
                If strValores(intX) = "" Then
                    strValores(intX) = "(NA)"
                End If
                strValores(intX) = strValores(intX).PadRight(11, " ")
                strChorizoFormateado += strValores(intX)
            Next
        End If

        Return strChorizoFormateado

    End Function

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles Button00.Click, Button01.Click, Button02.Click, Button03.Click, Button04.Click,
                                                                            Button05.Click, Button06.Click, Button07.Click, Button08.Click, Button09.Click,
                                                                            Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click


        Dim dlg As New FormDopplerIntro

        Select Case sender.name
            Case "Button00"
                PS_strLineaActual = strLineaDeDatos(0)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha00.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(0) = PS_strLineaActual
                    LabelDatos00.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button01"
                PS_strLineaActual = strLineaDeDatos(1)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha01.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(1) = PS_strLineaActual
                    LabelDatos01.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button02"
                PS_strLineaActual = strLineaDeDatos(2)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha02.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(2) = PS_strLineaActual
                    LabelDatos02.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button03"
                PS_strLineaActual = strLineaDeDatos(3)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha03.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(3) = PS_strLineaActual
                    LabelDatos03.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button04"
                PS_strLineaActual = strLineaDeDatos(4)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha04.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(4) = PS_strLineaActual
                    LabelDatos04.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button05"
                PS_strLineaActual = strLineaDeDatos(5)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha05.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(5) = PS_strLineaActual
                    LabelDatos05.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button06"
                PS_strLineaActual = strLineaDeDatos(6)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha06.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(6) = PS_strLineaActual
                    LabelDatos06.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button07"
                PS_strLineaActual = strLineaDeDatos(7)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha07.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(7) = PS_strLineaActual
                    LabelDatos07.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button08"
                PS_strLineaActual = strLineaDeDatos(8)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha08.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(8) = PS_strLineaActual
                    LabelDatos08.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button09"
                PS_strLineaActual = strLineaDeDatos(9)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha09.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(9) = PS_strLineaActual
                    LabelDatos09.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button10"
                PS_strLineaActual = strLineaDeDatos(10)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha10.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(10) = PS_strLineaActual
                    LabelDatos10.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button11"
                PS_strLineaActual = strLineaDeDatos(11)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha11.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(11) = PS_strLineaActual
                    LabelDatos11.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button12"
                PS_strLineaActual = strLineaDeDatos(12)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha12.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(12) = PS_strLineaActual
                    LabelDatos12.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button13"
                PS_strLineaActual = strLineaDeDatos(13)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha13.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(13) = PS_strLineaActual
                    LabelDatos13.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button14"
                PS_strLineaActual = strLineaDeDatos(14)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha14.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(14) = PS_strLineaActual
                    LabelDatos14.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If

            Case "Button15"
                PS_strLineaActual = strLineaDeDatos(15)
                PS_strMensajeTitulo = "Editando datos del " & LabelFecha15.Text
                'arraca el form
                If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strLineaDeDatos(15) = PS_strLineaActual
                    LabelDatos15.Text = FuncionFormateaLineaParaPantalla(PS_strLineaActual)
                End If


        End Select






    End Sub


    Dim strPathControl As String
    Dim strPathAgenda As String
    Dim strSubDirectorio As String
    Dim strArchivoControl As String
    Dim strArchivoAgenda As String
    Dim strArchivoProximo As String


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        strPathAgenda = Form1.PSstrPathAgendaBDH
        strPathControl = Form1.PSstrPathHistoriasSinPrefijo

        'controles propios agd
        For intX = 20 To 200
            strSubDirectorio = strPathControl & "\" & intX.ToString.PadLeft(5, "0")
            For intY = 0 To 9
                strArchivoControl = strSubDirectorio & "\" & intX.ToString.PadLeft(5, "0") & intY.ToString & ".agd"
                If File.Exists(strArchivoControl) Then
                    Me.Text = strArchivoControl
                    Me.Refresh()
                    SubCambiaHonorariosDelControl(strArchivoControl)
                End If
            Next
        Next

        'agenda
        For intX = 2018 To 2019
            strSubDirectorio = strPathAgenda & "\" & intX.ToString
            'primero el anual
            strArchivoAgenda = strSubDirectorio & "\Control-" & intX.ToString & ".agd"
            If File.Exists(strArchivoAgenda) Then
                Me.Text = strArchivoAgenda
                Me.Refresh()
                SubCambiaHonorariosDeLaAgenda(strArchivoAgenda)
            End If
            'ahora los mensuales
            For intY = 1 To 12
                strArchivoAgenda = strSubDirectorio & "\Control-" & intX.ToString & intY.ToString.PadLeft(2, "0") & ".agd"
                If File.Exists(strArchivoAgenda) Then
                    Me.Text = strArchivoAgenda
                    Me.Refresh()
                    SubCambiaHonorariosDeLaAgenda(strArchivoAgenda)
                End If
            Next
            'ahora los diarios incluyendo los proximos
            For intY = 1 To 12

                For intZ = 1 To 31

                    strArchivoAgenda = strSubDirectorio & "\Control-" & intX.ToString & intY.ToString.PadLeft(2, "0") & intZ.ToString.PadLeft(2, "0") & ".agd"
                    If File.Exists(strArchivoAgenda) Then
                        Me.Text = strArchivoAgenda
                        Me.Refresh()
                        SubCambiaHonorariosDeLaAgenda(strArchivoAgenda)
                    End If

                    strArchivoProximo = strSubDirectorio & "\Proximo-" & intX.ToString & intY.ToString.PadLeft(2, "0") & intZ.ToString.PadLeft(2, "0") & ".agd"
                    If File.Exists(strArchivoProximo) Then
                        Me.Text = strArchivoProximo
                        Me.Refresh()
                        SubCambiaHonorariosDelProximo(strArchivoProximo)
                    End If

                Next

            Next

        Next

    End Sub

    Private Sub SubCambiaHonorariosDelProximo(ByVal strArchivo As String)
        Dim BR As BinaryReader
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim C As Integer
        Dim J As Form1.TablaDeArchivosDeProximosControles
        Dim alsControlesExistentes As New ArrayList
        Dim alsControlesListos As New ArrayList
        Dim dateFechaUltimoControl As Date
        Dim intHonorarioViejo, intHonorarioNuevo As Integer
        Dim decHonorarioNuevo As Decimal

        alsControlesExistentes.Clear()
        alsControlesListos.Clear()

        'carga los controles del dia mes o año

        FS = New FileStream(strArchivo, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        C = BR.PeekChar
        While FS.Position < FS.Length
            J = Nothing
            ' Read fields and populate structure
            J.a01NumeroHistoria = BR.ReadString
            J.a02Nombre = BR.ReadString
            J.a03Cedula = BR.ReadString
            J.a04ClinicaUltimoControl = BR.ReadString
            J.a05NotaseIDxUltimoControl = BR.ReadString
            J.a06TratamientoUltimoControl = BR.ReadString
            J.a07Pendiente = BR.ReadString
            J.a08FechaUltimoControl = BR.ReadString
            J.a09HonorariosUltimoControl = BR.ReadString
            J.a10FechaProximoControl = BR.ReadString

            alsControlesExistentes.Add(J)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'cambia el honorario si aplica por la fecha

        For Each est As Form1.TablaDeArchivosDeProximosControles In alsControlesExistentes

            dateFechaUltimoControl = CType(est.a08FechaUltimoControl, Date)

            If dateFechaUltimoControl >= #01-01-2018# Then

                intHonorarioViejo = CType(est.a09HonorariosUltimoControl, Integer)

                If intHonorarioViejo = 0 Then
                    decHonorarioNuevo = 0
                Else
                    intHonorarioNuevo = intHonorarioViejo \ 1000
                    decHonorarioNuevo = intHonorarioNuevo / 100
                End If

                est.a09HonorariosUltimoControl = FormatNumber(decHonorarioNuevo, 2,,,)

            End If

            'pasa el est a los controles listos
            alsControlesListos.Add(est)

        Next

        'guarda el archivo de control a disco

        FS = New FileStream(strArchivo, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)
        For Each est As Form1.TablaDeArchivosDeProximosControles In alsControlesListos
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04ClinicaUltimoControl)
            BW.Write(est.a05NotaseIDxUltimoControl)
            BW.Write(est.a06TratamientoUltimoControl)
            BW.Write(est.a07Pendiente)
            BW.Write(est.a08FechaUltimoControl)
            BW.Write(est.a09HonorariosUltimoControl)
            BW.Write(est.a10FechaProximoControl)
        Next
        FS.Close()
        BW.Close()



    End Sub


    Private Sub SubCambiaHonorariosDeLaAgenda(ByVal strArchivo As String)
        Dim BR As BinaryReader
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim C As Integer
        Dim F As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual
        Dim alsControlesExistentes As New ArrayList
        Dim alsControlesListos As New ArrayList
        Dim intHonorarioViejo, intHonorarioNuevo As Integer
        Dim decHonorarioNuevo As Decimal

        alsControlesExistentes.Clear()
        alsControlesListos.Clear()

        'carga los controles del dia mes o año

        FS = New FileStream(strArchivo, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)

        C = BR.PeekChar
        While FS.Position < FS.Length
            F = Nothing
            ' Read fields and populate structure
            F.a01NumeroHistoria = BR.ReadString
            F.a02Nombre = BR.ReadString
            F.a03Cedula = BR.ReadString
            F.a04Clinica = BR.ReadString
            F.a05NotaseIDx = BR.ReadString
            F.a06Tratamiento = BR.ReadString
            F.a07Pendiente = BR.ReadString
            F.a08ProximaConsulta = BR.ReadString
            F.a09Honorarios = BR.ReadString
            F.a10FechaConsulta = BR.ReadString
            F.a11FacturaAsociada = BR.ReadString
            F.a16Referencia = BR.ReadString
            F.a15Banco = BR.ReadString
            F.a14FormaDePago = BR.ReadString
            F.a13FechaDePago = BR.ReadString
            F.a12Pagador = BR.ReadString

            alsControlesExistentes.Add(F)
            C = BR.PeekChar
        End While
        BR.Close()
        FS.Close()

        'cambia el honorario de todos orq son del 2018

        For Each est As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual In alsControlesExistentes

            intHonorarioViejo = CType(est.a09Honorarios, Integer)

            'If intHonorarioViejo = 0 Then
            '    intHonorarioNuevo = 0
            'Else
            '    intHonorarioNuevo = intHonorarioViejo \ 100000
            'End If

            'est.a09Honorarios = intHonorarioNuevo

            If intHonorarioViejo = 0 Then
                decHonorarioNuevo = 0
            Else
                intHonorarioNuevo = intHonorarioViejo \ 1000
                decHonorarioNuevo = intHonorarioNuevo / 100
            End If

            est.a09Honorarios = FormatNumber(decHonorarioNuevo, 2,,,)

            'pasa el est a los controles listos
            alsControlesListos.Add(est)

        Next

        'guarda el archivo de control a disco

        FS = New FileStream(strArchivo, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeArchivosDeAgendaControlDiarioMensualAnual In alsControlesListos
            BW.Write(est.a01NumeroHistoria)
            BW.Write(est.a02Nombre)
            BW.Write(est.a03Cedula)
            BW.Write(est.a04Clinica)
            BW.Write(est.a05NotaseIDx)
            BW.Write(est.a06Tratamiento)
            BW.Write(est.a07Pendiente)
            BW.Write(est.a08ProximaConsulta)
            BW.Write(est.a09Honorarios)
            BW.Write(est.a10FechaConsulta)
            BW.Write(est.a11FacturaAsociada)
            BW.Write(est.a16Referencia)
            BW.Write(est.a15Banco)
            BW.Write(est.a14FormaDePago)
            BW.Write(est.a13FechaDePago)
            BW.Write(est.a12Pagador)
        Next
        FS.Close()
        BW.Close()



    End Sub

    Private Sub SubCambiaHonorariosDelControl(ByVal strArchivo As String)
        Dim BR As BinaryReader
        Dim BW As BinaryWriter
        Dim FS As FileStream
        Dim T1 As Form1.TablaDeArchivosPropiosDeAgenda
        Dim alsControlesExistentes As New ArrayList
        Dim alsControlesListos As New ArrayList
        Dim intHonorarioViejo, intHonorarioNuevo As Integer
        Dim decHonorarioNuevo As Decimal

        alsControlesExistentes.Clear()
        alsControlesListos.Clear()

        'Carga los controles de la paciente

        FS = New FileStream(strArchivo, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        BR.BaseStream.Seek(0, SeekOrigin.Begin)
        Dim C As Integer
        C = BR.PeekChar
        Dim contador As Integer = 0
        While FS.Position < FS.Length
            T1.a10FechaConsulta = BR.ReadString
            T1.a02Clinica = BR.ReadString
            T1.a03NotaseIDx = BR.ReadString
            T1.a04Tratamiento = BR.ReadString
            T1.a05Pendiente = BR.ReadString
            T1.a06ProximaConsulta = BR.ReadString
            T1.a07Honorarios = BR.ReadString
            T1.a11FacturaAsociada = BR.ReadString
            T1.a16Referencia = BR.ReadString
            T1.a15Banco = BR.ReadString
            T1.a14FormaDePago = BR.ReadString
            T1.a13FechaDePago = BR.ReadString
            T1.a12Pagador = BR.ReadString
            alsControlesExistentes.Add(T1)
            C = BR.PeekChar
            contador += 1
        End While
        BR.Close()
        FS.Close()

        'revisa cuales son del 2018 en adelante y de ser asi cambia el honorario

        For Each est As Form1.TablaDeArchivosPropiosDeAgenda In alsControlesExistentes

            Dim dateFecha = CType(est.a10FechaConsulta, Date).Date
            If dateFecha >= #01-01-2018# = True Then

                'hay q cambiar el honorario
                intHonorarioViejo = CType(est.a07Honorarios, Integer)

                'If intHonorarioViejo = 0 Then
                '    intHonorarioNuevo = 0
                'Else
                '    intHonorarioNuevo = intHonorarioViejo \ 100000
                'End If

                'est.a07Honorarios = intHonorarioNuevo

                If intHonorarioViejo = 0 Then
                    decHonorarioNuevo = 0
                Else
                    intHonorarioNuevo = intHonorarioViejo \ 1000
                    decHonorarioNuevo = intHonorarioNuevo / 100
                End If

                est.a07Honorarios = FormatNumber(decHonorarioNuevo, 2,,,)

            Else

                'se deja igual l honorario no se hace nada con el est

            End If

            'pasa el est a los controles listos, si es despues del 1 de enero de 2018 se habra modificado si no sera igual
            alsControlesListos.Add(est)

        Next

        'guarda el archivo de control a disco

        FS = New FileStream(strArchivo, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        BW.BaseStream.Seek(0, SeekOrigin.Begin)

        For Each est As Form1.TablaDeArchivosPropiosDeAgenda In alsControlesListos
            BW.Write(est.a10FechaConsulta)
            BW.Write(est.a02Clinica)
            BW.Write(est.a03NotaseIDx)
            BW.Write(est.a04Tratamiento)
            BW.Write(est.a05Pendiente)
            BW.Write(est.a06ProximaConsulta)
            BW.Write(est.a07Honorarios)
            BW.Write(est.a11FacturaAsociada)
            BW.Write(est.a16Referencia)
            BW.Write(est.a15Banco)
            BW.Write(est.a14FormaDePago)
            BW.Write(est.a13FechaDePago)
            BW.Write(est.a12Pagador)
        Next
        FS.Close()
        BW.Close()


    End Sub




End Class