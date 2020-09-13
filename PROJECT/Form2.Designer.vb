<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblQues = New System.Windows.Forms.Label()
        Me.lblQues2 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQues = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(334, 222)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(67, 33)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.ToolTip1.SetToolTip(Me.btnNext, "Click to go the next question")
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(52, 194)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(99, 33)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Check Answer"
        Me.ToolTip1.SetToolTip(Me.btnCheck, "Click to check your answer")
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblQues
        '
        Me.lblQues.BackColor = System.Drawing.Color.Transparent
        Me.lblQues.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQues.Location = New System.Drawing.Point(23, 55)
        Me.lblQues.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQues.Name = "lblQues"
        Me.lblQues.Size = New System.Drawing.Size(331, 23)
        Me.lblQues.TabIndex = 3
        Me.lblQues.Text = "1. Make a declaration for following situation."
        '
        'lblQues2
        '
        Me.lblQues2.AutoSize = True
        Me.lblQues2.BackColor = System.Drawing.Color.Transparent
        Me.lblQues2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQues2.Location = New System.Drawing.Point(48, 98)
        Me.lblQues2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQues2.Name = "lblQues2"
        Me.lblQues2.Size = New System.Drawing.Size(353, 20)
        Me.lblQues2.TabIndex = 4
        Me.lblQues2.Text = "Number of hours, which can hold a decimal point."
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(52, 142)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(275, 21)
        Me.txtAnswer.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtAnswer, "Write your answer here")
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(156, 194)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 33)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click to reset")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu, Me.mnuQues})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(50, 20)
        Me.mnuMenu.Text = "Menu"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MainMenuToolStripMenuItem.Text = "&Main Page"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'mnuQues
        '
        Me.mnuQues.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.mnuQues.Name = "mnuQues"
        Me.mnuQues.Size = New System.Drawing.Size(67, 20)
        Me.mnuQues.Text = "Question"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem3.Text = "&2"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem4.Text = "&3"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem5.Text = "&4"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem6.Text = "&5"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 266)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblQues2)
        Me.Controls.Add(Me.lblQues)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents lblQues As System.Windows.Forms.Label
    Friend WithEvents lblQues2 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuQues As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
End Class
