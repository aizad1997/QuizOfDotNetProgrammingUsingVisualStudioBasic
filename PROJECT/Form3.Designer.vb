<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblQues = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbQues = New System.Windows.Forms.PictureBox()
        Me.radA = New System.Windows.Forms.RadioButton()
        Me.radC = New System.Windows.Forms.RadioButton()
        Me.radB = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQues = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbQues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(343, 222)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(57, 33)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.ToolTip1.SetToolTip(Me.btnNext, "Click to go the next question")
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(282, 222)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(57, 33)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.ToolTip1.SetToolTip(Me.btnBack, "Click to back to question 2")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(51, 202)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(99, 34)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Check Answer"
        Me.ToolTip1.SetToolTip(Me.btnCheck, "Click to check your answer")
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblQues
        '
        Me.lblQues.AutoSize = True
        Me.lblQues.BackColor = System.Drawing.Color.Transparent
        Me.lblQues.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQues.Location = New System.Drawing.Point(36, 44)
        Me.lblQues.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQues.Name = "lblQues"
        Me.lblQues.Size = New System.Drawing.Size(226, 20)
        Me.lblQues.TabIndex = 3
        Me.lblQues.Text = "2. Choose the suitable answer."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 4
        '
        'pbQues
        '
        Me.pbQues.BackgroundImage = CType(resources.GetObject("pbQues.BackgroundImage"), System.Drawing.Image)
        Me.pbQues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbQues.Location = New System.Drawing.Point(51, 78)
        Me.pbQues.Margin = New System.Windows.Forms.Padding(2)
        Me.pbQues.Name = "pbQues"
        Me.pbQues.Size = New System.Drawing.Size(360, 108)
        Me.pbQues.TabIndex = 5
        Me.pbQues.TabStop = False
        '
        'radA
        '
        Me.radA.AutoSize = True
        Me.radA.BackColor = System.Drawing.Color.Transparent
        Me.radA.Location = New System.Drawing.Point(15, 107)
        Me.radA.Margin = New System.Windows.Forms.Padding(2)
        Me.radA.Name = "radA"
        Me.radA.Size = New System.Drawing.Size(32, 17)
        Me.radA.TabIndex = 6
        Me.radA.TabStop = True
        Me.radA.Tag = ""
        Me.radA.Text = "A"
        Me.radA.UseVisualStyleBackColor = False
        '
        'radC
        '
        Me.radC.AutoSize = True
        Me.radC.BackColor = System.Drawing.Color.Transparent
        Me.radC.Location = New System.Drawing.Point(15, 169)
        Me.radC.Margin = New System.Windows.Forms.Padding(2)
        Me.radC.Name = "radC"
        Me.radC.Size = New System.Drawing.Size(32, 17)
        Me.radC.TabIndex = 8
        Me.radC.TabStop = True
        Me.radC.Text = "C"
        Me.radC.UseVisualStyleBackColor = False
        '
        'radB
        '
        Me.radB.AutoSize = True
        Me.radB.BackColor = System.Drawing.Color.Transparent
        Me.radB.Location = New System.Drawing.Point(15, 137)
        Me.radB.Margin = New System.Windows.Forms.Padding(2)
        Me.radB.Name = "radB"
        Me.radB.Size = New System.Drawing.Size(32, 17)
        Me.radB.TabIndex = 9
        Me.radB.TabStop = True
        Me.radB.Text = "B"
        Me.radB.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu, Me.mnuQues})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 10
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
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.radB)
        Me.Controls.Add(Me.radC)
        Me.Controls.Add(Me.radA)
        Me.Controls.Add(Me.pbQues)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQues)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 2"
        CType(Me.pbQues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents lblQues As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pbQues As System.Windows.Forms.PictureBox
    Friend WithEvents radA As System.Windows.Forms.RadioButton
    Friend WithEvents radC As System.Windows.Forms.RadioButton
    Friend WithEvents radB As System.Windows.Forms.RadioButton
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
