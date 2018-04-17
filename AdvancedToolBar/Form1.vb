Imports Shell32
Imports System.Runtime.InteropServices
Public Class MainForm

#Region "Hook"
    'Private WithEvents kbHook As New KeyboardHook

    'Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
    '    Dim mousepos As Rectangle = Screen.PrimaryScreen.WorkingArea
    '    Dim x = MousePosition.X - Screen.PrimaryScreen.Bounds.X
    '    Dim y = MousePosition.Y
    '    If Key = 162 And x >= mousepos.Width - 10 Then
    '        Me.Show()
    '    End If
    'End Sub
#End Region

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMS_Group.Parent = Me.Parent
    End Sub

    'Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    'e.Cancel = True
    '    'Me.Hide()
    'End Sub
    Private Sub MainForm_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub MainForm_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        'Dim fileName() As String = e.Data.GetData(DataFormats.FileDrop)
        'Dim PictureBox_ As New PictureBox
        ''MsgBox(GetLnkTarget(fileName(0)))
        ''Dim myIcon As System.Drawing.Icon = Image.FromFile(fileName(0))
        ''PictureBox1.Image = Image.FromFile(fileName(0))
        'Dim hImgLarge As IntPtr  'The handle to the system image list.
        'Dim shinfo As SHFILEINFO
        'shinfo = New SHFILEINFO()
        'Dim openFileDialog1 As OpenFileDialog
        'openFileDialog1 = New OpenFileDialog()

        'shinfo.szDisplayName = New String(Chr(0), 260)
        'shinfo.szTypeName = New String(Chr(0), 80)

        ''Use this to get the small icon.
        ''hImgSmall = SHGetFileInfo(fName, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)

        ''Use this to get the large icon.
        'hImgLarge = SHGetFileInfo(fileName(0), 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_LARGEICON)

        ''The icon is returned in the hIcon member of the shinfo struct.
        'Dim myIcon As System.Drawing.Icon = System.Drawing.Icon.FromHandle(shinfo.hIcon)
        ''PictureBox1.Image = myIcon.ToBitmap
        ''FlowLayoutPanel1.Controls.Add(PictureBox_)
        ''PictureBox_.Show()
        ''PictureBox_.Size = New Size(30, 30)
        ''PictureBox_.SizeMode = PictureBoxSizeMode.StretchImage
        ''PictureBox_.Location = New Point(0, 0)
        ''PictureBox_.Image = myIcon.ToBitmap
    End Sub
    Private Sub MainForm_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Me.Refresh()
    End Sub

#Region "MainFlowLayoutPanel"
    Private Sub MainFlowLayoutPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles MainFlowLayoutPanel.MouseClick
        If (e.Button = MouseButtons.Right) Then
            CMS_Group.Parent = Me.Parent
            RemoveButtonToolStripMenuItem.Visible = False
            AddButtonToolStripMenuItem.Visible = False
            RenameGroupToolStripMenuItem.Visible = False
            CMS_Group.Show()
            CMS_Group.Location = New Point(e.X + Me.Left, e.Y + Me.Top + 20)
        End If
    End Sub
    Private Sub MainFlowLayoutPanel_SizeChanged(sender As Object, e As EventArgs) Handles MainFlowLayoutPanel.SizeChanged
        For Each x As Control In MainFlowLayoutPanel.Controls
            If (x.Name.Contains("FlP")) Then
                x.Width = MainFlowLayoutPanel.Width - 10
                Dim MinimizeButton_ As Button = CType(x.Controls("B_" & x.Name), Button)
                MinimizeButton_.Width = x.Width - 10
            End If
        Next
    End Sub
#End Region

#Region "ToolStripMenuItem"
    Private Sub AddGroupAreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGroupAreaToolStripMenuItem.Click
        Dim FlP As New FlowLayoutPanel
        Dim MinimizeButton As New Button
        FlP.Name = "FlP" & "_" & FlPCount()
        FlP.Width = MainFlowLayoutPanel.Width - 10
        FlP.BorderStyle = BorderStyle.Fixed3D

        MainFlowLayoutPanel.Controls.Add(FlP)
        Dim Caption_ As String = InputBox("Enter name for Group", "Name Group")
        If Caption_ = "" Then MinimizeButton.Text = ">" Else MinimizeButton.Text = Caption_
        MinimizeButton.Location = New Point(0, 0)
        MinimizeButton.Name = "B_" & FlP.Name
        MinimizeButton.Width = FlP.Width - 10
        FlP.Controls.Add(MinimizeButton)
        AddHandler MinimizeButton.MouseClick, AddressOf MinimizeButton_Click
        AddHandler FlP.MouseClick, AddressOf FlP_MouseClick
        FlP.Show()
        MinimizeButton.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        MainFlowLayoutPanel.AutoScroll = True
        MainFlowLayoutPanel.AutoSize = True
        MainFlowLayoutPanel.Refresh()
        Me.Refresh()
    End Sub
    Private Sub RenameGroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameGroupToolStripMenuItem.Click
        Dim cp = Cursor.Position()
        cp = New Point(PointToClient(cp))
        Dim getControl As FlowLayoutPanel = GetChildAtPoint(cp)
        'FIP_Clicked.BackColor = Color.Red
        Dim MinimizeButton_ As Button = CType(FIP_Clicked.Controls("B_" & FIP_Clicked.Name), Button)
        MinimizeButton_.Text = InputBox("Change the Title of this Group", "", MinimizeButton_.Text)
    End Sub

    Private Sub AddButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddButtonToolStripMenuItem.Click
        Dim newBu As New Button
        newBu.ContextMenuStrip = CMS_Button_Property
        FIP_Clicked.Controls.Add(newBu)
        newBu.Size = New Size(30, 30)
        newBu.Show()
        AddHandler newBu.Click, AddressOf SubButton_Click
    End Sub
#End Region

#Region "SubButton_Click"
    Private Sub SubButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

#End Region

#Region "FlP"
    Dim FIP_Clicked As FlowLayoutPanel
    Private Sub FlP_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            CMS_Group.Parent = Me.Parent
            AddGroupAreaToolStripMenuItem.Visible = True
            RemoveButtonToolStripMenuItem.Visible = True
            AddButtonToolStripMenuItem.Visible = True
            RenameGroupToolStripMenuItem.Visible = True
            CMS_Group.Show()
            CMS_Group.Location = New Point(e.X + Me.Left, e.Y + Me.Top + 20)
            FIP_Clicked = DirectCast(sender, FlowLayoutPanel)
        End If
    End Sub
#End Region

#Region "minimizeButton"
    Private Sub MinimizeButton_Click(sender As Object, e As MouseEventArgs)
        Dim ClickedButton As Button = DirectCast(sender, Button)
        Dim FiP_Parent As FlowLayoutPanel = ClickedButton.Parent
        If (FiP_Parent.Height <> ClickedButton.Height + 15) Then
            FiP_Parent.Height = ClickedButton.Height + 15
            FiP_Parent.Width = MainFlowLayoutPanel.Width - 10
        Else
            FiP_Parent.Height = 100
            FiP_Parent.Width = MainFlowLayoutPanel.Width - 10
        End If
        ClickedButton.Width = FiP_Parent.Width - 10
        MainFlowLayoutPanel.Refresh()
        Me.Refresh()
    End Sub
#End Region
#Region "SubFunctions"
    Private Function FlPCount()
        Dim Count_ As Integer = 0
        For Each x As Control In MainFlowLayoutPanel.Controls
            If (x.Name.Contains("FlP")) Then
                Count_ += 1
            End If
        Next
        Return Count_
    End Function

#End Region

End Class
