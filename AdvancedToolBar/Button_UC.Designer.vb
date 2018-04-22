<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Button_UC
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Bu_Shell = New System.Windows.Forms.Button()
        Me.TB_FileName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Bu_Shell
        '
        Me.Bu_Shell.Location = New System.Drawing.Point(19, 0)
        Me.Bu_Shell.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Bu_Shell.Name = "Bu_Shell"
        Me.Bu_Shell.Size = New System.Drawing.Size(35, 35)
        Me.Bu_Shell.TabIndex = 0
        Me.Bu_Shell.UseVisualStyleBackColor = True
        '
        'TB_FileName
        '
        Me.TB_FileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_FileName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TB_FileName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_FileName.Enabled = False
        Me.TB_FileName.Location = New System.Drawing.Point(0, 36)
        Me.TB_FileName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TB_FileName.Multiline = True
        Me.TB_FileName.Name = "TB_FileName"
        Me.TB_FileName.Size = New System.Drawing.Size(73, 35)
        Me.TB_FileName.TabIndex = 1
        Me.TB_FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_UC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TB_FileName)
        Me.Controls.Add(Me.Bu_Shell)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Button_UC"
        Me.Size = New System.Drawing.Size(73, 71)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bu_Shell As Button
    Friend WithEvents TB_FileName As TextBox
End Class
