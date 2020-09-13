Public Class Form5
    'sub procedure for check answer for question4
    Private Sub checkAnswer()

        Dim counter As Integer = 0, counterWrong As Integer = 0

        If chk1.CheckState = CheckState.Checked Then
            counterWrong = counterWrong + 1
            chk1.BackColor = Color.Red

        End If

        If chk2.CheckState = CheckState.Checked Then
            chk2.BackColor = Color.Green
            counter = counter + 1
        End If

        If chk3.CheckState = CheckState.Checked Then
            counterWrong = counterWrong + 1
            chk3.BackColor = Color.Red
        End If

        If chk4.CheckState = CheckState.Checked Then
            counter = counter + 1
            chk4.BackColor = Color.Green

        End If


        If counter = 0 Then
            MessageBox.Show("Your answer is incorrect.", "Incorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Form7.lblQuestion4.Text = "0/3"

        ElseIf counter > 0 And counter < 2 Then
            MessageBox.Show("You answer " & counter & " correct and " & counterWrong & " wrong.", "Correct Answer",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form7.lblQuestion4.Text = counter & "/3"

        ElseIf counterWrong > 0 Then
            MessageBox.Show("You answer " & counter & " correct and " & counterWrong & " wrong.", "Correct Answer",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form7.lblQuestion4.Text = counter & "/2"

        ElseIf counter = 2 And counterWrong = 0 Then
            MessageBox.Show("Well done! Your answer is all correct.", "Correct Answer",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form7.lblQuestion4.Text = counter & "/2"
        End If

    End Sub
    'sub procedure for validation when user do not answer the question but click the checkAnswer btn
    Private Sub check()
        If chk1.CheckState = CheckState.Unchecked And chk2.CheckState = CheckState.Unchecked And
            chk3.CheckState = CheckState.Unchecked And chk4.CheckState = CheckState.Unchecked Then
            MessageBox.Show("Please answer the question.", "Answer empty", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        ElseIf chk1.CheckState = CheckState.Checked And chk2.CheckState = CheckState.Checked And
            chk3.CheckState = CheckState.Checked And chk4.CheckState = CheckState.Checked Then
            MessageBox.Show("Please check 2 only.", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'event handling for btnCheck answer
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        If chk1.CheckState = CheckState.Unchecked And chk2.CheckState = CheckState.Unchecked _
            And chk3.CheckState = CheckState.Unchecked And chk4.CheckState = CheckState.Unchecked Then
            Call check()

        ElseIf chk1.CheckState = CheckState.Checked And chk2.CheckState = CheckState.Checked _
            And chk3.CheckState = CheckState.Checked And chk4.CheckState = CheckState.Checked Then
            Call check()
        Else
            Call checkAnswer()
        End If

    End Sub
    'event handling for btnBack
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form4.Show()
        Me.Hide()
    End Sub
    'event handling for btnNext
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form6.Show()
        Me.Hide()

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
    'event handling for menu question3
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Form4.Show()
        Me.Hide()
    End Sub
    'event handling for menu question5
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Form6.Show()
        Me.Hide()
    End Sub
    'event handling for exit using menuStrip
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Dim result As Integer = MessageBox.Show("Are you sure want to close the program ?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Show()
        ElseIf result = DialogResult.Yes Then
            End
        End If

    End Sub

    'event handling checkbox1
    Private Sub chk1_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged
        Call check()
    End Sub
    'event handling checkbox1
    Private Sub chk2_CheckedChanged(sender As Object, e As EventArgs) Handles chk2.CheckedChanged
        Call check()
    End Sub
    'event handling checkbox1
    Private Sub chk3_CheckedChanged(sender As Object, e As EventArgs) Handles chk3.CheckedChanged
        Call check()
    End Sub
    'event handling checkbox1
    Private Sub chk4_CheckedChanged(sender As Object, e As EventArgs) Handles chk4.CheckedChanged
        Call check()
    End Sub
End Class