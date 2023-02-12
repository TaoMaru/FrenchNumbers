<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumbers
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
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblFrench = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOne
        '
        Me.btnOne.BackColor = System.Drawing.Color.LightGray
        Me.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOne.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.Location = New System.Drawing.Point(18, 86)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(55, 28)
        Me.btnOne.TabIndex = 0
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = False
        '
        'btnTwo
        '
        Me.btnTwo.BackColor = System.Drawing.Color.LightGray
        Me.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTwo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(93, 86)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(55, 28)
        Me.btnTwo.TabIndex = 1
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = False
        '
        'btnThree
        '
        Me.btnThree.BackColor = System.Drawing.Color.LightGray
        Me.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThree.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.Location = New System.Drawing.Point(168, 86)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(55, 28)
        Me.btnThree.TabIndex = 2
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = False
        '
        'btnFour
        '
        Me.btnFour.BackColor = System.Drawing.Color.LightGray
        Me.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFour.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.Location = New System.Drawing.Point(243, 86)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(55, 28)
        Me.btnFour.TabIndex = 3
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = False
        '
        'btnFive
        '
        Me.btnFive.BackColor = System.Drawing.Color.LightGray
        Me.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFive.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.Location = New System.Drawing.Point(318, 86)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(55, 28)
        Me.btnFive.TabIndex = 4
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGray
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(168, 178)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(10, 10)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(370, 70)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Do you know the French words for the numbers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 through 5?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the buttons bel" &
    "ow to see them."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFrench
        '
        Me.lblFrench.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrench.Location = New System.Drawing.Point(168, 133)
        Me.lblFrench.Name = "lblFrench"
        Me.lblFrench.Size = New System.Drawing.Size(55, 28)
        Me.lblFrench.TabIndex = 7
        Me.lblFrench.Text = "Label2"
        Me.lblFrench.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFrench.Visible = False
        '
        'frmNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(392, 213)
        Me.Controls.Add(Me.lblFrench)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Name = "frmNumbers"
        Me.Text = "French Numbers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblFrench As Label
End Class
