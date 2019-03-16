<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAverageShipped
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
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.LblUnits = New System.Windows.Forms.Label()
        Me.ToolTipInputBox = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtDisplay = New System.Windows.Forms.TextBox()
        Me.LblOutput = New System.Windows.Forms.Label()
        Me.LblDay = New System.Windows.Forms.Label()
        Me.TxtDisplay2 = New System.Windows.Forms.TextBox()
        Me.TxtDisplay3 = New System.Windows.Forms.TextBox()
        Me.LblOutput2 = New System.Windows.Forms.Label()
        Me.LblOutput3 = New System.Windows.Forms.Label()
        Me.LblEmp1 = New System.Windows.Forms.Label()
        Me.LblEmp2 = New System.Windows.Forms.Label()
        Me.LblEmp3 = New System.Windows.Forms.Label()
        Me.LblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(59, 41)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(77, 22)
        Me.TxtInput.TabIndex = 0
        Me.ToolTipInputBox.SetToolTip(Me.TxtInput, "Input Units Here")
        '
        'LblUnits
        '
        Me.LblUnits.AutoSize = True
        Me.LblUnits.Location = New System.Drawing.Point(9, 41)
        Me.LblUnits.Name = "LblUnits"
        Me.LblUnits.Size = New System.Drawing.Size(44, 17)
        Me.LblUnits.TabIndex = 1
        Me.LblUnits.Text = "Units:"
        '
        'BtnEnter
        '
        Me.BtnEnter.Location = New System.Drawing.Point(41, 438)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(200, 35)
        Me.BtnEnter.TabIndex = 1
        Me.BtnEnter.Text = "Enter"
        Me.ToolTipInputBox.SetToolTip(Me.BtnEnter, "Enter Data into the Application to Calculate Average")
        Me.BtnEnter.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(308, 438)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(204, 35)
        Me.BtnReset.TabIndex = 2
        Me.BtnReset.Text = "Reset"
        Me.ToolTipInputBox.SetToolTip(Me.BtnReset, "Reset Application and Erase Previous Data")
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.Location = New System.Drawing.Point(580, 437)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(213, 36)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.ToolTipInputBox.SetToolTip(Me.BtnExit, "Close the Application")
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TxtDisplay
        '
        Me.TxtDisplay.Location = New System.Drawing.Point(41, 119)
        Me.TxtDisplay.MaximumSize = New System.Drawing.Size(300, 300)
        Me.TxtDisplay.MinimumSize = New System.Drawing.Size(200, 200)
        Me.TxtDisplay.Multiline = True
        Me.TxtDisplay.Name = "TxtDisplay"
        Me.TxtDisplay.ReadOnly = True
        Me.TxtDisplay.Size = New System.Drawing.Size(200, 200)
        Me.TxtDisplay.TabIndex = 100
        Me.TxtDisplay.TabStop = False
        '
        'LblOutput
        '
        Me.LblOutput.AutoSize = True
        Me.LblOutput.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblOutput.Location = New System.Drawing.Point(41, 338)
        Me.LblOutput.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LblOutput.MaximumSize = New System.Drawing.Size(100, 100)
        Me.LblOutput.MinimumSize = New System.Drawing.Size(200, 40)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(200, 40)
        Me.LblOutput.TabIndex = 0
        '
        'LblDay
        '
        Me.LblDay.AutoSize = True
        Me.LblDay.Location = New System.Drawing.Point(12, 9)
        Me.LblDay.Name = "LblDay"
        Me.LblDay.Size = New System.Drawing.Size(45, 17)
        Me.LblDay.TabIndex = 7
        Me.LblDay.Text = "Day 1"
        '
        'TxtDisplay2
        '
        Me.TxtDisplay2.Location = New System.Drawing.Point(308, 119)
        Me.TxtDisplay2.MaximumSize = New System.Drawing.Size(300, 300)
        Me.TxtDisplay2.MinimumSize = New System.Drawing.Size(200, 200)
        Me.TxtDisplay2.Multiline = True
        Me.TxtDisplay2.Name = "TxtDisplay2"
        Me.TxtDisplay2.ReadOnly = True
        Me.TxtDisplay2.Size = New System.Drawing.Size(200, 200)
        Me.TxtDisplay2.TabIndex = 102
        Me.TxtDisplay2.TabStop = False
        '
        'TxtDisplay3
        '
        Me.TxtDisplay3.Location = New System.Drawing.Point(580, 119)
        Me.TxtDisplay3.MaximumSize = New System.Drawing.Size(300, 300)
        Me.TxtDisplay3.MinimumSize = New System.Drawing.Size(200, 200)
        Me.TxtDisplay3.Multiline = True
        Me.TxtDisplay3.Name = "TxtDisplay3"
        Me.TxtDisplay3.ReadOnly = True
        Me.TxtDisplay3.Size = New System.Drawing.Size(200, 200)
        Me.TxtDisplay3.TabIndex = 103
        Me.TxtDisplay3.TabStop = False
        '
        'LblOutput2
        '
        Me.LblOutput2.AutoSize = True
        Me.LblOutput2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblOutput2.Location = New System.Drawing.Point(308, 338)
        Me.LblOutput2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LblOutput2.MaximumSize = New System.Drawing.Size(100, 100)
        Me.LblOutput2.MinimumSize = New System.Drawing.Size(200, 40)
        Me.LblOutput2.Name = "LblOutput2"
        Me.LblOutput2.Size = New System.Drawing.Size(200, 40)
        Me.LblOutput2.TabIndex = 104
        '
        'LblOutput3
        '
        Me.LblOutput3.AutoSize = True
        Me.LblOutput3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblOutput3.Location = New System.Drawing.Point(580, 338)
        Me.LblOutput3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LblOutput3.MaximumSize = New System.Drawing.Size(100, 100)
        Me.LblOutput3.MinimumSize = New System.Drawing.Size(200, 40)
        Me.LblOutput3.Name = "LblOutput3"
        Me.LblOutput3.Size = New System.Drawing.Size(200, 40)
        Me.LblOutput3.TabIndex = 105
        '
        'LblEmp1
        '
        Me.LblEmp1.AutoSize = True
        Me.LblEmp1.Location = New System.Drawing.Point(96, 84)
        Me.LblEmp1.Name = "LblEmp1"
        Me.LblEmp1.Size = New System.Drawing.Size(82, 17)
        Me.LblEmp1.TabIndex = 106
        Me.LblEmp1.Text = "Employee 1"
        '
        'LblEmp2
        '
        Me.LblEmp2.AutoSize = True
        Me.LblEmp2.Location = New System.Drawing.Point(364, 84)
        Me.LblEmp2.Name = "LblEmp2"
        Me.LblEmp2.Size = New System.Drawing.Size(82, 17)
        Me.LblEmp2.TabIndex = 107
        Me.LblEmp2.Text = "Employee 2"
        '
        'LblEmp3
        '
        Me.LblEmp3.AutoSize = True
        Me.LblEmp3.Location = New System.Drawing.Point(645, 84)
        Me.LblEmp3.Name = "LblEmp3"
        Me.LblEmp3.Size = New System.Drawing.Size(82, 17)
        Me.LblEmp3.TabIndex = 108
        Me.LblEmp3.Text = "Employee 3"
        '
        'LblAverage
        '
        Me.LblAverage.AutoSize = True
        Me.LblAverage.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAverage.Location = New System.Drawing.Point(99, 394)
        Me.LblAverage.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LblAverage.MaximumSize = New System.Drawing.Size(100, 100)
        Me.LblAverage.MinimumSize = New System.Drawing.Size(600, 40)
        Me.LblAverage.Name = "LblAverage"
        Me.LblAverage.Size = New System.Drawing.Size(600, 40)
        Me.LblAverage.TabIndex = 109
        '
        'FrmAverageShipped
        '
        Me.AcceptButton = Me.BtnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnExit
        Me.ClientSize = New System.Drawing.Size(823, 492)
        Me.Controls.Add(Me.LblAverage)
        Me.Controls.Add(Me.LblEmp3)
        Me.Controls.Add(Me.LblEmp2)
        Me.Controls.Add(Me.LblEmp1)
        Me.Controls.Add(Me.LblOutput3)
        Me.Controls.Add(Me.LblOutput2)
        Me.Controls.Add(Me.TxtDisplay3)
        Me.Controls.Add(Me.TxtDisplay2)
        Me.Controls.Add(Me.LblDay)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.TxtDisplay)
        Me.Controls.Add(Me.LblUnits)
        Me.Controls.Add(Me.TxtInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAverageShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped by Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtInput As TextBox
    Friend WithEvents LblUnits As Label
    Friend WithEvents ToolTipInputBox As ToolTip
    Friend WithEvents TxtDisplay As TextBox
    Friend WithEvents BtnEnter As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblOutput As Label
    Friend WithEvents LblDay As Label
    Friend WithEvents TxtDisplay2 As TextBox
    Friend WithEvents TxtDisplay3 As TextBox
    Friend WithEvents LblOutput2 As Label
    Friend WithEvents LblOutput3 As Label
    Friend WithEvents LblEmp1 As Label
    Friend WithEvents LblEmp2 As Label
    Friend WithEvents LblEmp3 As Label
    Friend WithEvents LblAverage As Label
End Class
