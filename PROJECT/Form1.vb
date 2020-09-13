Public Class Form1

    'Event procedure for btnStart
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter your name.", "Enter name", MessageBoxButtons.OK)
        Else
            Form2.Show()
            Me.Hide()
        End If
        Form7.lblName.Text = txtName.Text & ","  'to display username at form7
    End Sub
End Class
