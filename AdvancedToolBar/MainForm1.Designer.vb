<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm1))
        Me.CMS_Group = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddGroupAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackGroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CMS_Button_Property = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TargetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TB_Search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bu_End = New System.Windows.Forms.Button()
        Me.CMS_Group.SuspendLayout()
        Me.CMS_Button_Property.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMS_Group
        '
        Me.CMS_Group.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddGroupAreaToolStripMenuItem, Me.RenameGroupToolStripMenuItem, Me.AddButtonToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.SizeToolStripMenuItem, Me.BackGroundToolStripMenuItem})
        Me.CMS_Group.Name = "CMS"
        Me.CMS_Group.Size = New System.Drawing.Size(157, 136)
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
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove Group"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SizeToolStripMenuItem.Text = "Size"
        '
        'BackGroundToolStripMenuItem
        '
        Me.BackGroundToolStripMenuItem.Name = "BackGroundToolStripMenuItem"
        Me.BackGroundToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BackGroundToolStripMenuItem.Text = "BackGround"
        '
        'MainFlowLayoutPanel
        '
        Me.MainFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainFlowLayoutPanel.AutoScroll = True
        Me.MainFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MainFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainFlowLayoutPanel.ContextMenuStrip = Me.CMS_Group
        Me.MainFlowLayoutPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainFlowLayoutPanel.Location = New System.Drawing.Point(0, 27)
        Me.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel"
        Me.MainFlowLayoutPanel.Size = New System.Drawing.Size(357, 651)
        Me.MainFlowLayoutPanel.TabIndex = 1
        '
        'CMS_Button_Property
        '
        Me.CMS_Button_Property.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveButtonToolStripMenuItem, Me.TargetToolStripMenuItem})
        Me.CMS_Button_Property.Name = "CMS_Button_Property"
        Me.CMS_Button_Property.Size = New System.Drawing.Size(154, 48)
        '
        'RemoveButtonToolStripMenuItem
        '
        Me.RemoveButtonToolStripMenuItem.Name = "RemoveButtonToolStripMenuItem"
        Me.RemoveButtonToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RemoveButtonToolStripMenuItem.Text = "RemoveButton"
        '
        'TargetToolStripMenuItem
        '
        Me.TargetToolStripMenuItem.Name = "TargetToolStripMenuItem"
        Me.TargetToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.TargetToolStripMenuItem.Text = "Target"
        '
        'TB_Search
        '
        Me.TB_Search.Location = New System.Drawing.Point(70, 4)
        Me.TB_Search.Name = "TB_Search"
        Me.TB_Search.Size = New System.Drawing.Size(132, 20)
        Me.TB_Search.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search"
        '
        'Bu_End
        '
        Me.Bu_End.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bu_End.Location = New System.Drawing.Point(279, 3)
        Me.Bu_End.Name = "Bu_End"
        Me.Bu_End.Size = New System.Drawing.Size(71, 20)
        Me.Bu_End.TabIndex = 4
        Me.Bu_End.Text = "End"
        Me.Bu_End.UseVisualStyleBackColor = True
        '
        'MainForm1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(357, 678)
        Me.Controls.Add(Me.Bu_End)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_Search)
        Me.Controls.Add(Me.MainFlowLayoutPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm1"
        Me.Text = "Advanced Tool Bar ver1.0"
        Me.CMS_Group.ResumeLayout(False)
        Me.CMS_Button_Property.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMS_Group As ContextMenuStrip
    Friend WithEvents AddGroupAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameGroupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents CMS_Button_Property As ContextMenuStrip
    Friend WithEvents RemoveButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TargetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackGroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TB_Search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Bu_End As Button
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
End Class
