﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSummary
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
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSummary
        '
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(9, 7)
        Me.lblSummary.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(370, 60)
        Me.lblSummary.TabIndex = 0
        Me.lblSummary.Text = "Summary"
        Me.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSummary
        '
        Me.txtSummary.BackColor = System.Drawing.Color.Green
        Me.txtSummary.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtSummary.ForeColor = System.Drawing.SystemColors.Info
        Me.txtSummary.Location = New System.Drawing.Point(9, 80)
        Me.txtSummary.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSummary.Multiline = True
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.ReadOnly = True
        Me.txtSummary.Size = New System.Drawing.Size(372, 340)
        Me.txtSummary.TabIndex = 3
        '
        'formSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 427)
        Me.Controls.Add(Me.txtSummary)
        Me.Controls.Add(Me.lblSummary)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formSummary"
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents txtSummary As System.Windows.Forms.TextBox
End Class
