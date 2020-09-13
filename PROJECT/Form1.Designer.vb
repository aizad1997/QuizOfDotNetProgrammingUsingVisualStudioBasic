<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTitle.Location = New System.Drawing.Point(0, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(423, 124)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Quiz of Dot Net    Programming"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Teal
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(155, 204)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(104, 41)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Let's start"
        Me.ToolTip1.SetToolTip(Me.btnStart, "Start the Quiz")
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter your name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(179, 159)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(154, 20)
        Me.txtName.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtName, "Please enter your name")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 266)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
