Public Class Form1

    Dim angkaPertama As Double
    Dim angkakedua As Double
    Dim operasi As String
    Dim statusoperasi As Boolean = False

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text &= "0"
        statusoperasi = False
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text &= "1"
        statusoperasi = False
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text &= "2"
        statusoperasi = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text &= "3"
        statusoperasi = False
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text &= "4"
        statusoperasi = False
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text &= "5"
        statusoperasi = False
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text &= "6"
        statusoperasi = False
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text &= "7"
        statusoperasi = False
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text &= "8"
        statusoperasi = False
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text &= "9"
        statusoperasi = False
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        angkaPertama = Val(txtDisplay.Text)
        operasi = "+"
        txtDisplay.Text &= " + "
        statusoperasi = True
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        angkaPertama = Val(txtDisplay.Text)
        operasi = "-"
        txtDisplay.Text &= " - "
        statusoperasi = True
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        angkaPertama = Val(txtDisplay.Text)
        operasi = "*"
        txtDisplay.Text &= " x "
        statusoperasi = True
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        angkaPertama = Val(txtDisplay.Text)
        operasi = "/"
        txtDisplay.Text &= " / "
        statusoperasi = True
    End Sub

    Private Sub btnSamaDengan_Click(sender As Object, e As EventArgs) Handles btnSamaDengan.Click

        Dim teks() As String = txtDisplay.Text.Split(" "c)
        angkakedua = Val(teks(teks.Length - 1))

        If operasi = "+" Then
            txtDisplay.Text = angkaPertama + angkakedua

        ElseIf operasi = "-" Then
            txtDisplay.Text = angkaPertama - angkakedua

        ElseIf operasi = "*" Then
            txtDisplay.Text = angkaPertama * angkakedua

        ElseIf operasi = "/" Then

            If angkakedua <> 0 Then
                txtDisplay.Text = angkaPertama / angkakedua
            Else
                txtDisplay.Text = "Error"
            End If

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
        angkaPertama = 0
        angkakedua = 0
        statusoperasi = False
    End Sub

End Class