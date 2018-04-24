<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlowLayoutPanel_UC
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Bu_Expand = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AllowDrop = True
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 32)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(263, 188)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Bu_Expand
        '
        Me.Bu_Expand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bu_Expand.Location = New System.Drawing.Point(4, 2)
        Me.Bu_Expand.Margin = New System.Windows.Forms.Padding(4)
        Me.Bu_Expand.Name = "Bu_Expand"
        Me.Bu_Expand.Size = New System.Drawing.Size(263, 28)
        Me.Bu_Expand.TabIndex = 0
        Me.Bu_Expand.Text = ">"
        Me.Bu_Expand.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel_UC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Bu_Expand)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FlowLayoutPanel_UC"
        Me.Size = New System.Drawing.Size(272, 224)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Bu_Expand As Button
End Class
