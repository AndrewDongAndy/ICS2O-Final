<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMulti
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
        Me.picLeftKey0 = New System.Windows.Forms.PictureBox()
        Me.lblLeftScore = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblRightScore = New System.Windows.Forms.Label()
        Me.picLeftKey1 = New System.Windows.Forms.PictureBox()
        Me.picLeftKey2 = New System.Windows.Forms.PictureBox()
        Me.picLeftKey3 = New System.Windows.Forms.PictureBox()
        Me.picRightKey3 = New System.Windows.Forms.PictureBox()
        Me.picRightKey2 = New System.Windows.Forms.PictureBox()
        Me.picRightKey1 = New System.Windows.Forms.PictureBox()
        Me.picRightKey0 = New System.Windows.Forms.PictureBox()
        Me.timerCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblOption1 = New System.Windows.Forms.Label()
        Me.lblOption2 = New System.Windows.Forms.Label()
        Me.lblOption3 = New System.Windows.Forms.Label()
        Me.lblOption0 = New System.Windows.Forms.Label()
        CType(Me.picLeftKey0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftKey1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftKey2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftKey3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightKey3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightKey2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightKey1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightKey0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLeftKey0
        '
        Me.picLeftKey0.Location = New System.Drawing.Point(37, 167)
        Me.picLeftKey0.Name = "picLeftKey0"
        Me.picLeftKey0.Size = New System.Drawing.Size(30, 30)
        Me.picLeftKey0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLeftKey0.TabIndex = 2
        Me.picLeftKey0.TabStop = False
        '
        'lblLeftScore
        '
        Me.lblLeftScore.AutoSize = True
        Me.lblLeftScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeftScore.Location = New System.Drawing.Point(34, 391)
        Me.lblLeftScore.Name = "lblLeftScore"
        Me.lblLeftScore.Size = New System.Drawing.Size(61, 17)
        Me.lblLeftScore.TabIndex = 17
        Me.lblLeftScore.Text = "Score: 0"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(157, 334)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 37)
        Me.btnStart.TabIndex = 16
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(33, 23)
        Me.lblQuestion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(342, 96)
        Me.lblQuestion.TabIndex = 12
        Me.lblQuestion.Text = "Question"
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(33, 135)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(64, 20)
        Me.lblOptions.TabIndex = 18
        Me.lblOptions.Text = "Options"
        '
        'lblRightScore
        '
        Me.lblRightScore.AutoSize = True
        Me.lblRightScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRightScore.Location = New System.Drawing.Point(314, 391)
        Me.lblRightScore.Name = "lblRightScore"
        Me.lblRightScore.Size = New System.Drawing.Size(61, 17)
        Me.lblRightScore.TabIndex = 19
        Me.lblRightScore.Text = "Score: 0"
        '
        'picLeftKey1
        '
        Me.picLeftKey1.Location = New System.Drawing.Point(37, 203)
        Me.picLeftKey1.Name = "picLeftKey1"
        Me.picLeftKey1.Size = New System.Drawing.Size(30, 30)
        Me.picLeftKey1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLeftKey1.TabIndex = 20
        Me.picLeftKey1.TabStop = False
        '
        'picLeftKey2
        '
        Me.picLeftKey2.Location = New System.Drawing.Point(37, 239)
        Me.picLeftKey2.Name = "picLeftKey2"
        Me.picLeftKey2.Size = New System.Drawing.Size(30, 30)
        Me.picLeftKey2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLeftKey2.TabIndex = 21
        Me.picLeftKey2.TabStop = False
        '
        'picLeftKey3
        '
        Me.picLeftKey3.Location = New System.Drawing.Point(37, 275)
        Me.picLeftKey3.Name = "picLeftKey3"
        Me.picLeftKey3.Size = New System.Drawing.Size(30, 30)
        Me.picLeftKey3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLeftKey3.TabIndex = 22
        Me.picLeftKey3.TabStop = False
        '
        'picRightKey3
        '
        Me.picRightKey3.Location = New System.Drawing.Point(345, 275)
        Me.picRightKey3.Name = "picRightKey3"
        Me.picRightKey3.Size = New System.Drawing.Size(30, 30)
        Me.picRightKey3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRightKey3.TabIndex = 26
        Me.picRightKey3.TabStop = False
        '
        'picRightKey2
        '
        Me.picRightKey2.Location = New System.Drawing.Point(345, 239)
        Me.picRightKey2.Name = "picRightKey2"
        Me.picRightKey2.Size = New System.Drawing.Size(30, 30)
        Me.picRightKey2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRightKey2.TabIndex = 25
        Me.picRightKey2.TabStop = False
        '
        'picRightKey1
        '
        Me.picRightKey1.Location = New System.Drawing.Point(345, 203)
        Me.picRightKey1.Name = "picRightKey1"
        Me.picRightKey1.Size = New System.Drawing.Size(30, 30)
        Me.picRightKey1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRightKey1.TabIndex = 24
        Me.picRightKey1.TabStop = False
        '
        'picRightKey0
        '
        Me.picRightKey0.Location = New System.Drawing.Point(345, 167)
        Me.picRightKey0.Name = "picRightKey0"
        Me.picRightKey0.Size = New System.Drawing.Size(30, 30)
        Me.picRightKey0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRightKey0.TabIndex = 23
        Me.picRightKey0.TabStop = False
        '
        'timerCountdown
        '
        Me.timerCountdown.Interval = 1000
        '
        'lblOption1
        '
        Me.lblOption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOption1.Location = New System.Drawing.Point(86, 203)
        Me.lblOption1.Name = "lblOption1"
        Me.lblOption1.Size = New System.Drawing.Size(241, 30)
        Me.lblOption1.TabIndex = 28
        Me.lblOption1.Text = "Option 1"
        Me.lblOption1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOption2
        '
        Me.lblOption2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOption2.Location = New System.Drawing.Point(86, 239)
        Me.lblOption2.Name = "lblOption2"
        Me.lblOption2.Size = New System.Drawing.Size(241, 30)
        Me.lblOption2.TabIndex = 29
        Me.lblOption2.Text = "Option 2"
        Me.lblOption2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOption3
        '
        Me.lblOption3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOption3.Location = New System.Drawing.Point(86, 275)
        Me.lblOption3.Name = "lblOption3"
        Me.lblOption3.Size = New System.Drawing.Size(241, 30)
        Me.lblOption3.TabIndex = 30
        Me.lblOption3.Text = "Option 3"
        Me.lblOption3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOption0
        '
        Me.lblOption0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOption0.Location = New System.Drawing.Point(86, 167)
        Me.lblOption0.Name = "lblOption0"
        Me.lblOption0.Size = New System.Drawing.Size(241, 30)
        Me.lblOption0.TabIndex = 31
        Me.lblOption0.Text = "Option 0"
        Me.lblOption0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 429)
        Me.Controls.Add(Me.lblOption0)
        Me.Controls.Add(Me.lblOption3)
        Me.Controls.Add(Me.lblOption2)
        Me.Controls.Add(Me.lblOption1)
        Me.Controls.Add(Me.picRightKey3)
        Me.Controls.Add(Me.picRightKey2)
        Me.Controls.Add(Me.picRightKey1)
        Me.Controls.Add(Me.picRightKey0)
        Me.Controls.Add(Me.picLeftKey3)
        Me.Controls.Add(Me.picLeftKey2)
        Me.Controls.Add(Me.picLeftKey1)
        Me.Controls.Add(Me.lblRightScore)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.lblLeftScore)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.picLeftKey0)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formMulti"
        Me.Text = "Multiplayer"
        CType(Me.picLeftKey0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftKey1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftKey2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftKey3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightKey3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightKey2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightKey1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightKey0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLeftKey0 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLeftScore As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents lblRightScore As System.Windows.Forms.Label
    Friend WithEvents picLeftKey1 As System.Windows.Forms.PictureBox
    Friend WithEvents picLeftKey2 As System.Windows.Forms.PictureBox
    Friend WithEvents picLeftKey3 As System.Windows.Forms.PictureBox
    Friend WithEvents picRightKey3 As System.Windows.Forms.PictureBox
    Friend WithEvents picRightKey2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRightKey1 As System.Windows.Forms.PictureBox
    Friend WithEvents picRightKey0 As System.Windows.Forms.PictureBox
    Friend WithEvents timerCountdown As System.Windows.Forms.Timer
    Friend WithEvents lblOption1 As System.Windows.Forms.Label
    Friend WithEvents lblOption2 As System.Windows.Forms.Label
    Friend WithEvents lblOption3 As System.Windows.Forms.Label
    Friend WithEvents lblOption0 As System.Windows.Forms.Label
End Class
