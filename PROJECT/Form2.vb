Public Class Form2

    'Sub procedure to check answer
    Private Sub checkAnswer()
        If txtAnswer.Text = "" Then
            MessageBox.Show("Please answer the question.", "Answer empty", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtAnswer.Text = "dim hours as decimal" Or txtAnswer.Text = "Dim hours As Decimal" Then
            txtAnswer.BackColor = Color.Green
            MessageBox.Show("Your answer is correct.", "Answer Correct", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form7.lblQuestion1.Text = "1/1"
        Else
            MessageBox.Show(" Answer : Dim hours As Decimal", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    'event handling for btnCheck 
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Form7.lblQuestion1.Text = "0/1"  'display 0/1 at form7 at lblQuestion1
        Call checkAnswer()

    End Sub

    'event handling for btnNext
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form3.Show()
        Me.Hide()

    End Sub
    'event handling for btnClear
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAnswer.Text = ""
        txtAnswer.BackColor = SystemColors.ScrollBar
    End Sub

    'event hndling to exit the program using menustrip
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure want to close the program?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Show()
        ElseIf result = DialogResult.Yes Then
            End
        End If
    End Sub
    'event handling for menu MainPage
    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()

    End Sub
    'event handling for menu question2
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Form3.Show()
        Me.Hide()
    End Sub
    'event handling for menu question3
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Form4.Show()
        Me.Hide()
    End Sub
    'event handling for menu question4
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Form5.Show()
        Me.Hide()
    End Sub
    'event handling for menu question5
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Form6.Show()
        Me.Hide()
    End Sub

End Class