<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddGroupAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Option_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CMS.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'CMS
        '
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddGroupAreaToolStripMenuItem, Me.RenameGroupToolStripMenuItem, Me.AddButtonToolStripMenuItem, Me.RemoveButtonToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(157, 92)
        '
        'AddGroupAreaToolStripMenuItem
        '
        Me.AddGroupAreaToolStripMenuItem.Name = "AddGroupAreaToolStripMenuItem"
        Me.AddGroupAreaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AddGroupAreaToolStripMenuItem.Text = "Add group area"
        '
        'RenameGroupToolStripMenuItem
        '
        Me.RenameGroupToolStripMenuItem.Name = "RenameGroupToolStripMenuItem"
        Me.RenameGroupToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.RenameGroupToolStripMenuItem.Text = "Rename Group"
        '
        'AddButtonToolStripMenuItem
        '
        Me.AddButtonToolStripMenuItem.Name = "AddButtonToolStripMenuItem"
        Me.AddButtonToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AddButtonToolStripMenuItem.Text = "Add Button"
        '
        'RemoveButtonToolStripMenuItem
        '
        Me.RemoveButtonToolStripMenuItem.Name = "RemoveButtonToolStripMenuItem"
        Me.RemoveButtonToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.RemoveButtonToolStripMenuItem.Text = "Remove Button"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(368, 632)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 34)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 28)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(420, 434)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Option_ToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(449, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Option_ToolStripButton
        '
        Me.Option_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Option_ToolStripButton.Image = CType(resources.GetObject("Option_ToolStripButton.Image"), System.Drawing.Image)
        Me.Option_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Option_ToolStripButton.Name = "Option_ToolStripButton"
        Me.Option_ToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.Option_ToolStripButton.Text = "ToolStripButton1"
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(449, 678)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.CMS.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents CMS As ContextMenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AddGroupAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameGroupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Option_ToolStripButton As ToolStripButton
End Class
