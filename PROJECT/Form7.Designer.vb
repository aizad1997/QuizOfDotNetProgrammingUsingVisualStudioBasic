<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.lblQuestion3 = New System.Windows.Forms.Label()
        Me.lblQuestion4 = New System.Windows.Forms.Label()
        Me.lblQuestion5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQues = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpResult = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion1.Location = New System.Drawing.Point(186, 17)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(111, 20)
        Me.lblQuestion1.TabIndex = 0
        Me.lblQuestion1.Text = "Check Answer"
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion2.Location = New System.Drawing.Point(186, 43)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(111, 20)
        Me.lblQuestion2.TabIndex = 1
        Me.lblQuestion2.Text = "Check Answer"
        '
        'lblQuestion3
        '
        Me.lblQuestion3.AutoSize = True
        Me.lblQuestion3.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion3.Location = New System.Drawing.Point(186, 68)
        Me.lblQuestion3.Name = "lblQuestion3"
        Me.lblQuestion3.Size = New System.Drawing.Size(111, 20)
        Me.lblQuestion3.TabIndex = 2
        Me.lblQuestion3.Text = "Check Answer"
        '
        'lblQuestion4
        '
        Me.lblQuestion4.AutoSize = True
        Me.lblQuestion4.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion4.Location = New System.Drawing.Point(186, 93)
        Me.lblQuestion4.Name = "lblQuestion4"
        Me.lblQuestion4.Size = New System.Drawing.Size(111, 20)
        Me.lblQuestion4.TabIndex = 3
        Me.lblQuestion4.Text = "Check Answer"
        '
        'lblQuestion5
        '
        Me.lblQuestion5.AutoSize = True
        Me.lblQuestion5.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion5.Location = New System.Drawing.Point(186, 115)
        Me.lblQuestion5.Name = "lblQuestion5"
        Me.lblQuestion5.Size = New System.Drawing.Size(111, 20)
        Me.lblQuestion5.TabIndex = 4
        Me.lblQuestion5.Text = "Check Answer"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(340, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(61, 32)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to close the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.Location = New System.Drawing.Point(252, 222)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(82, 32)
        Me.btnMain.TabIndex = 6
        Me.btnMain.Text = "Main Page"
        Me.ToolTip1.SetToolTip(Me.btnMain, "Click to go the Main Page")
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu, Me.mnuQues})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 23
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
        Me.mnuQues.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem2})
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
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem2.Text = "&5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(90, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Question 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(90, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Question 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(90, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Question 3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(90, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Question 4:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(90, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Question 5:"
        '
        'grpResult
        '
        Me.grpResult.BackColor = System.Drawing.Color.Transparent
        Me.grpResult.Controls.Add(Me.lblQuestion3)
        Me.grpResult.Controls.Add(Me.Label1)
        Me.grpResult.Controls.Add(Me.Label2)
        Me.grpResult.Controls.Add(Me.Label3)
        Me.grpResult.Controls.Add(Me.Label4)
        Me.grpResult.Controls.Add(Me.Label5)
        Me.grpResult.Controls.Add(Me.lblQuestion1)
        Me.grpResult.Controls.Add(Me.lblQuestion2)
        Me.grpResult.Controls.Add(Me.lblQuestion4)
        Me.grpResult.Controls.Add(Me.lblQuestion5)
        Me.grpResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResult.Location = New System.Drawing.Point(36, 57)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Size = New System.Drawing.Size(365, 148)
        Me.grpResult.TabIndex = 29
        Me.grpResult.TabStop = False
        Me.grpResult.Text = "Your result"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(23, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 20)
        Me.lblName.TabIndex = 30
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 266)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.grpResult)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpResult.ResumeLayout(False)
        Me.grpResult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents lblQuestion3 As Label
    Friend WithEvents lblQuestion4 As Label
    Friend WithEvents lblQuestion5 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMain As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuQues As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents grpResult As GroupBox
    Friend WithEvents lblName As Label
End Class
