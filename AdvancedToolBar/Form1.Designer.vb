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
        Me.CMS_Group = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddGroupAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CMS_Button_Property = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_Group.SuspendLayout()
        Me.CMS_Button_Property.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMS_Group
        '
        Me.CMS_Group.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddGroupAreaToolStripMenuItem, Me.RenameGroupToolStripMenuItem, Me.AddButtonToolStripMenuItem})
        Me.CMS_Group.Name = "CMS"
        Me.CMS_Group.Size = New System.Drawing.Size(157, 70)
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
        'MainFlowLayoutPanel
        '
        Me.MainFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainFlowLayoutPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel"
        Me.MainFlowLayoutPanel.Size = New System.Drawing.Size(649, 678)
        Me.MainFlowLayoutPanel.TabIndex = 1
        '
        'CMS_Button_Property
        '
        Me.CMS_Button_Property.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveButtonToolStripMenuItem})
        Me.CMS_Button_Property.Name = "CMS_Button_Property"
        Me.CMS_Button_Property.Size = New System.Drawing.Size(154, 48)
        '
        'RemoveButtonToolStripMenuItem
        '
        Me.RemoveButtonToolStripMenuItem.Name = "RemoveButtonToolStripMenuItem"
        Me.RemoveButtonToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RemoveButtonToolStripMenuItem.Text = "RemoveButton"
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(649, 678)
        Me.Controls.Add(Me.MainFlowLayoutPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.CMS_Group.ResumeLayout(False)
        Me.CMS_Button_Property.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMS_Group As ContextMenuStrip
    Friend WithEvents AddGroupAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameGroupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents CMS_Button_Property As ContextMenuStrip
    Friend WithEvents RemoveButtonToolStripMenuItem As ToolStripMenuItem
End Class
