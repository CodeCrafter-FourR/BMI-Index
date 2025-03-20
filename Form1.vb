Public Class Form1
    Private Sub btnBmi_Click(sender As Object, e As EventArgs) Handles btnBmi.Click

        Dim berat As Double
        Dim tinggi As Double
        Dim bmi As Double


        If Double.TryParse(TextBox1.Text, berat) AndAlso Double.TryParse(TextBox2.Text, tinggi) Then

            If tinggi > 100 Then
                tinggi /= 100
            End If

            If tinggi > 0 And berat > 0 Then

                bmi = berat / (tinggi * tinggi)
                TextBox3.Text = Math.Round(bmi, 2).ToString()


                Dim status As String = ""

                If bmi < 18.5 Then
                    status = "Berat Badan Kurang: < 18.5"
                ElseIf bmi >= 18.5 And bmi <= 24.9 Then
                    status = "Normal: antara 18.5 dan 24.9"
                ElseIf bmi >= 25 And bmi <= 29.9 Then
                    status = "Kelebihan Berat Badan: antara 25 dan 29.9"
                Else
                    status = "Obesitas: >= 30"
                End If


                TextBox4.Text = status
                Label5.Text = "BMI Index" & vbCrLf &
                              "Berat Badan Kurang: < 18.5" & vbCrLf &
                              "Normal: antara 18.5 dan 24.9" & vbCrLf &
                              "Kelebihan Berat Badan: antara 25 dan 29.9" & vbCrLf &
                              "Obesitas: >= 30"

            Else
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnexit.Click

        Me.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
