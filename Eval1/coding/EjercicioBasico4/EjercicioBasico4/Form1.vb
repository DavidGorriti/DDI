Public Class Form1

    Private Sub curso1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSIMYER.TextChanged, txtADDAIG.TextAlignChanged, txtCALIDAD.TextChanged, txtINGLES.TextChanged, txtPELE.TextChanged, txtRET.TextChanged
        Dim aprobado As Boolean = checkCurso1()

        If aprobado Then
            activateCurso2()
            checkCoursePassed()
        Else
            deactivateCurso2()
        End If

    End Sub

    Private Sub curso2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDDAEE4G.TextChanged, txtDYRSP.TextAlignChanged, txtFOL.TextChanged
        Dim aprobado As Boolean = checkCurso2()

        If aprobado Then
            checkCoursePassed()
        End If

    End Sub

    Function checkCurso1()
        Dim horasSusp As Integer = 0
        Dim asignSusp As Integer = 0

        If Not IsNumeric(txtSIMYER.Text) And txtSIMYER.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtSIMYER.Text = ""
            Return False
        End If
        If Not IsNumeric(txtADDAIG.Text) And txtADDAIG.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtADDAIG.Text = ""
            Return False
        End If
        If Not IsNumeric(txtCALIDAD.Text) And txtCALIDAD.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtCALIDAD.Text = ""
            Return False
        End If
        If Not IsNumeric(txtINGLES.Text) And txtINGLES.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtINGLES.Text = ""
            Return False
        End If
        If Not IsNumeric(txtPELE.Text) And txtPELE.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtPELE.Text = ""
            Return False
        End If
        If Not IsNumeric(txtRET.Text) And txtRET.Text <> "" Then
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


    

    Private Function checkCurso2() As Boolean
        Dim horasSusp As Integer = 0
        Dim asignSusp As Integer = 0

        If Not IsNumeric(txtSIMYER.Text) And txtSIMYER.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtSIMYER.Text = ""
            Return False
        End If
        If Not IsNumeric(txtADDAIG.Text) And txtADDAIG.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtADDAIG.Text = ""
            Return False
        End If
        If Not IsNumeric(txtCALIDAD.Text) And txtCALIDAD.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtCALIDAD.Text = ""
            Return False
        End If
        If Not IsNumeric(txtINGLES.Text) And txtINGLES.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtINGLES.Text = ""
            Return False
        End If
        If Not IsNumeric(txtPELE.Text) And txtPELE.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtPELE.Text = ""
            Return False
        End If
        If Not IsNumeric(txtRET.Text) And txtRET.Text <> "" Then
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



        If Not IsNumeric(txtDDAEE4G.Text) And txtDDAEE4G.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtDDAEE4G.Text = ""
            Return False
        End If
        If Not IsNumeric(txtDYRSP.Text) And txtDYRSP.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtDYRSP.Text = ""
            Return False
        End If
        If Not IsNumeric(txtFOL.Text) And txtFOL.Text <> "" Then
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
        Return True
    End Function

    Private Function checkCoursePassed() As Boolean
        Dim horasSusp As Integer = 0
        Dim asignSusp As Integer = 0

        If Not IsNumeric(txtSIMYER.Text) And txtSIMYER.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtSIMYER.Text = ""
            Return False
        End If
        If Not IsNumeric(txtADDAIG.Text) And txtADDAIG.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtADDAIG.Text = ""
            Return False
        End If
        If Not IsNumeric(txtCALIDAD.Text) And txtCALIDAD.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtCALIDAD.Text = ""
            Return False
        End If
        If Not IsNumeric(txtINGLES.Text) And txtINGLES.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtINGLES.Text = ""
            Return False
        End If
        If Not IsNumeric(txtPELE.Text) And txtPELE.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtPELE.Text = ""
            Return False
        End If
        If Not IsNumeric(txtRET.Text) And txtRET.Text <> "" Then
            MsgBox("No puede introducir una letra como nota")
            txtRET.Text = ""
            Return False
        End If


        If txtSIMYER.Text < 5 Then

            asignSusp = asignSusp + 1
        End If
        If txtADDAIG.Text < 5 Then
            asignSusp = asignSusp + 1
        End If
        If txtCALIDAD.Text < 5 Then
            asignSusp = asignSusp + 1
        End If
        If txtINGLES.Text < 5 Then
            asignSusp = asignSusp + 1
        End If
        If txtPELE.Text < 5 Then
            asignSusp = asignSusp + 1
        End If
        If txtRET.Text < 5 Then
            asignSusp = asignSusp + 1
        End If

        If asignSusp > 0 Then
            Return False
        Else
            If checkCurso2() Then
                txtFCT.ReadOnly = False

            End If
        End If

        
    End Function

    Private Sub deactivateCurso2()
        txtDDAEE4G.ReadOnly = True
        txtDYRSP.ReadOnly = True
        txtFOL.ReadOnly = True
        txtFCT.ReadOnly = True
    End Sub

End Class
