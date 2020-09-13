Public Class Form7
    'event handling for btnMain - go to mainPage
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Form1.Show()
        Me.Hide()

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
    'event handling for menu question3
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Form4.Show()
        Me.Hide()
    End Sub
    'event handling for menu question4
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Form5.Show()
        Me.Hide()
    End Sub
    'event handling for menu question5
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Form6.Show()
        Me.Hide()

    End Sub
    'event handling for btnExit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As Integer = MessageBox.Show("Are you sure want to close the program ?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Show()
        ElseIf result = DialogResult.Yes Then
            End
        End If
    End Sub

End Class