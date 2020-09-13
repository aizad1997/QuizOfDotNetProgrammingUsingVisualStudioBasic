<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.chk4 = New System.Windows.Forms.CheckBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.lblQues = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
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
        'chk4
        '
        Me.chk4.BackColor = System.Drawing.Color.Transparent
        Me.chk4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk4.Location = New System.Drawing.Point(65, 186)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(238, 22)
        Me.chk4.TabIndex = 20
        Me.chk4.Text = "lblDisplay.ResetText()"
        Me.chk4.UseVisualStyleBackColor = False
        '
        'chk3
        '
        Me.chk3.BackColor = System.Drawing.Color.Transparent
        Me.chk3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk3.Location = New System.Drawing.Point(65, 152)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(226, 29)
        Me.chk3.TabIndex = 19
        Me.chk3.Text = "lblDisplay.Text = """""
        Me.chk3.UseVisualStyleBackColor = False
        '
        'chk2
        '
        Me.chk2.BackColor = System.Drawing.Color.Transparent
        Me.chk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2.Location = New System.Drawing.Point(65, 128)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(226, 29)
        Me.chk2.TabIndex = 18
        Me.chk2.Text = "lblDisplay.Clear()"
        Me.chk2.UseVisualStyleBackColor = False
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.BackColor = System.Drawing.Color.Transparent
        Me.chk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk1.Location = New System.Drawing.Point(65, 104)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(204, 20)
        Me.chk1.TabIndex = 17
        Me.chk1.Text = "lblDisplay.Text = String.Empty"
        Me.chk1.UseVisualStyleBackColor = False
        '
        'lblQues
        '
        Me.lblQues.BackColor = System.Drawing.Color.Transparent
        Me.lblQues.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQues.ForeColor = System.Drawing.Color.Black
        Me.lblQues.Location = New System.Drawing.Point(28, 39)
        Me.lblQues.Name = "lblQues"
        Me.lblQues.Size = New System.Drawing.Size(383, 50)
        Me.lblQues.TabIndex = 16
        Me.lblQues.Text = "5. You are given a label named lblDisplay. Which of the following is the correct " &
    "way to clear the value inside the label ? Choose 3 answers."
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(31, 222)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(102, 33)
        Me.btnCheck.TabIndex = 15
        Me.btnCheck.Text = "Check Answer"
        Me.ToolTip1.SetToolTip(Me.btnCheck, "Click to check your answer")
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(289, 228)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(59, 33)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Click to back question 4")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(352, 228)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(59, 33)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "Finish"
        Me.ToolTip1.SetToolTip(Me.btnNext, "Click to check the result")
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu, Me.mnuQues})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 22
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
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem3.Text = "&1"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem4.Text = "&2"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem5.Text = "&3"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem6.Text = "&4"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.chk4)
        Me.Controls.Add(Me.chk3)
        Me.Controls.Add(Me.chk2)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.lblQues)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Font = New System.Drawing.Font("Symbol", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents lblQues As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuQues As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
