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
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.lblPercentageDescriptor = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(225, 15)
        Me.txtCalories.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(63, 20)
        Me.txtCalories.TabIndex = 0
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(225, 50)
        Me.txtFat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(63, 20)
        Me.txtFat.TabIndex = 1
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.Location = New System.Drawing.Point(16, 17)
        Me.lblCalories.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(195, 13)
        Me.lblCalories.TabIndex = 2
        Me.lblCalories.Text = "Enter the number of calories in the food:"
        '
        'lblFat
        '
        Me.lblFat.AutoSize = True
        Me.lblFat.Location = New System.Drawing.Point(9, 53)
        Me.lblFat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(202, 13)
        Me.lblFat.TabIndex = 3
        Me.lblFat.Text = "Enter the number of fat grams in the food:"
        '
        'lblPercentageDescriptor
        '
        Me.lblPercentageDescriptor.AutoSize = True
        Me.lblPercentageDescriptor.Location = New System.Drawing.Point(7, 100)
        Me.lblPercentageDescriptor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPercentageDescriptor.Name = "lblPercentageDescriptor"
        Me.lblPercentageDescriptor.Size = New System.Drawing.Size(204, 13)
        Me.lblPercentageDescriptor.TabIndex = 4
        Me.lblPercentageDescriptor.Text = "Percentage of calories that come from fat:"
        '
        'lblPercent
        '
        Me.lblPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPercent.Location = New System.Drawing.Point(225, 91)
        Me.lblPercent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(62, 27)
        Me.lblPercent.TabIndex = 5
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(27, 143)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(64, 26)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(130, 143)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 26)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(225, 143)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 26)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 180)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblPercentageDescriptor)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.txtCalories)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Fat Percentage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCalories As TextBox
    Friend WithEvents txtFat As TextBox
    Friend WithEvents lblCalories As Label
    Friend WithEvents lblFat As Label
    Friend WithEvents lblPercentageDescriptor As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
