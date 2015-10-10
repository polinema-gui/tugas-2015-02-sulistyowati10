Public Class Form1
    Dim input As Integer
    Dim hasil As Byte

    Private Function hasilNya()
        If (TextBox1.Text.Equals("0") Or Me.hasil > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If (hasilNya()) Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text &= "0"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (hasilNya()) Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (hasilNya()) Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (hasilNya()) Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (hasilNya()) Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (hasilNya()) Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (hasilNya()) Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (hasilNya()) Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (hasilNya()) Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (hasilNya()) Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    

    Private Sub Buttonhapus_Click(sender As Object, e As EventArgs) Handles Buttonhapus.Click
        TextBox1.Text = "0"
        Me.input = 0
        Me.hasil = 0
    End Sub

    Private Sub Buttonkurang_Click(sender As Object, e As EventArgs) Handles Buttonkurang.Click
        If (Me.input = 0 Or Me.hasil = 2) Then
            Me.input += Convert.ToInt32(TextBox1.Text)
        Else
            Me.input -= Convert.ToInt32(TextBox1.Text)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (Me.hasil = 1) Then
            Me.input -= Convert.ToInt32(TextBox1.Text)
        Else
            Me.input += Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.input.ToString
        Me.hasil = 2
    End Sub

    Private Sub Buttonsamadengan_Click(sender As Object, e As EventArgs) Handles Buttonsamadengan.Click
        Select Case Me.hasil
            Case 1
                TextBox1.Text = Convert.ToString(Me.input - Convert.ToInt32(TextBox1.Text))
            Case 2
                TextBox1.Text = Convert.ToString(Me.input + Convert.ToInt32(TextBox1.Text))
        End Select
        Me.input = 0
    End Sub
End Class
