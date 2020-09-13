Public Class Form4
    'sub procedure for check answer for question3
    Private Sub checkAnswer()
        If radB.Checked = True Then
            radA.BackColor = Color.Green
            lblA.BackColor = Color.Green
            radB.BackColor = Color.Red
            lblB.BackColor = Color.Red
            radC.BackColor = Color.Transparent
            lblC.BackColor = Color.Transparent
            Form7.lblQuestion3.Text = "0/1"
            MessageBox.Show("Your answer is incorrect.", "Incorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf radC.Checked = True Then

            radB.BackColor = Color.Transparent
            lblB.BackColor = Color.Transparent
            lblA.BackColor = Color.Green
            radA.BackColor = Color.Green
            radC.BackColor = Color.Red
            lblC.BackColor = Color.Red
            Form7.lblQuestion3.Text = "0/1"
            MessageBox.Show("Your answer is incorrect.", "Incorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf radA.Checked = True Then
            radA.BackColor = Color.Green
            lblA.BackColor = Color.Green
            radB.BackColor = Color.Transparent
            lblB.BackColor = Color.Transparent
            radC.BackColor = Color.Transparent
            lblC.BackColor = Color.Transparent
            Form7.lblQuestion3.Text = "1/1"
            MessageBox.Show("Your answer is correct.", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    'sub procedure for check whether user answer the question
    Private Sub Check()
        If radA.Checked = False And radB.Checked = False And radC.Checked = False Then
            MessageBox.Show("Please answer the question.", "Answer empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'event handling for btnBack
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form3.Show()
        Me.Hide()
    End Sub
    'event handling for btnNext
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form5.Show()
        Me.Hide()
    End Sub
    'Event handling for btnCheck
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Call Check()

        Call checkAnswer()
    End Sub
    'event handling for exit using menustrip
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure want to close the program ?", "Exit", MessageBoxButtons.YesNo)
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
    'event handling for menu question1
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Form2.Show()
        Me.Hide()
    End Sub
    'event handling for menu question2
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Form3.Show()
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