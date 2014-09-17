Public Class Form1

    Private Property checkCurso1 As Boolean

    Private Sub curso1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSIMYER.TextChanged, txtADDAIG.TextAlignChanged, txtCALIDAD.TextChanged, txtINGLES.TextChanged, txtPELE.TextChanged, txtRET.TextChanged
        Dim aprobado As Boolean = checkCurso1()

        If aprobado Then
            activateCurso2()
        End If

    End Sub

    Function checkCurso1e()
        Dim horasSusp As Integer = 0
        Dim asignSusp As Integer = 0

        If IsNumeric(txtSIMYER.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtSIMYER.Text = ""
            Return False
        End If
        If IsNumeric(txtADDAIG.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtADDAIG.Text = ""
            Return False
        End If
        If IsNumeric(txtCALIDAD.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtCALIDAD.Text = ""
            Return False
        End If
        If IsNumeric(txtINGLES.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtINGLES.Text = ""
            Return False
        End If
        If IsNumeric(txtPELE.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtPELE.Text = ""
            Return False
        End If
        If IsNumeric(txtRET.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtRET.Text = ""
            Return False
        End If


        If txtSIMYER.Text < 5 Then
            horasSusp = horasSusp + lblHorasSIMYER.Text
            asignSusp = asignSusp + 1
        End If
        If txtADDAIG.Text < 5 Then
            horasSusp = horasSusp + lblHorasADDAIG.Text
            asignSusp = asignSusp + 1
        End If
        If txtCALIDAD.Text < 5 Then
            horasSusp = horasSusp + lblHorasCALIDAD.Text
            asignSusp = asignSusp + 1
        End If
        If txtINGLES.Text < 5 Then
            horasSusp = horasSusp + lblHorasINGLES.Text
            asignSusp = asignSusp + 1
        End If
        If txtPELE.Text < 5 Then
            horasSusp = horasSusp + lblHorasPELE.Text
            asignSusp = asignSusp + 1
        End If
        If txtRET.Text < 5 Then
            horasSusp = horasSusp + lblHorasRET.Text
            asignSusp = asignSusp + 1
        End If

        If asignSusp > 3 Or horasSusp > 300 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub activateCurso2()
        txtDDAEE4G.ReadOnly = False
        txtDYRSP.ReadOnly = False
        txtFOL.ReadOnly = False
    End Sub


    Private Sub curso2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDDAEE4G.TextChanged, txtDYRSP.TextAlignChanged, txtFOL.TextChanged
        Dim aprobado As Boolean = checkCurso2()

        If aprobado Then
            activateCurso2()
        End If

    End Sub

    Private Function checkCurso2() As Boolean
        Dim horasSusp As Integer = 0
        Dim asignSusp As Integer = 0

        If IsNumeric(txtSIMYER.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtSIMYER.Text = ""
            Return False
        End If
        If IsNumeric(txtADDAIG.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtADDAIG.Text = ""
            Return False
        End If
        If IsNumeric(txtCALIDAD.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtCALIDAD.Text = ""
            Return False
        End If
        If IsNumeric(txtINGLES.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtINGLES.Text = ""
            Return False
        End If
        If IsNumeric(txtPELE.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtPELE.Text = ""
            Return False
        End If
        If IsNumeric(txtRET.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtRET.Text = ""
            Return False
        End If


        If txtSIMYER.Text < 5 Then
            Return False
        End If
        If txtADDAIG.Text < 5 Then
            Return False
        End If
        If txtCALIDAD.Text < 5 Then
            Return False
        End If
        If txtINGLES.Text < 5 Then
            Return False
        End If
        If txtPELE.Text < 5 Then
            Return False
        End If
        If txtRET.Text < 5 Then
            Return False
        End If



        If IsNumeric(txtDDAEE4G.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtDDAEE4G.Text = ""
            Return False
        End If
        If IsNumeric(txtDYRSP.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtDYRSP.Text = ""
            Return False
        End If
        If IsNumeric(txtFOL.Text) Then
            MsgBox("No puede introducir una letra como nota")
            txtFOL.Text = ""
            Return False
        End If

        If txtDDAEE4G.Text < 5 Then
            Return False
        End If
        If txtDYRSP.Text < 5 Then
            Return False
        End If
        If txtFOL.Text < 5 Then
            Return False
        End If
    End Function

End Class
