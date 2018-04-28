Imports Shell32
Imports System.Runtime.InteropServices
Public Class MainForm1

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

#Region "Form"

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim co As Color = MainFlowLayoutPanel.BackColor
        'MainFlowLayoutPanel.BackColor = Color.SteelBlue
        'Me.TransparencyKey = Color.SteelBlue
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, 0)


    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'e.Cancel = True
        'Me.Hide()
    End Sub
    'Private Sub MainForm_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
    '    If e.Data.GetDataPresent(DataFormats.FileDrop) Then
    '        e.Effect = DragDropEffects.Copy
    '    End If
    'End Sub
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

#End Region
#Region "MainFlowLayoutPanel"
    Private Sub MainFlowLayoutPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles MainFlowLayoutPanel.MouseDown
        If (e.Button = MouseButtons.Right) Then
            RemoveButtonToolStripMenuItem.Visible = False
            AddButtonToolStripMenuItem.Visible = False
            RenameGroupToolStripMenuItem.Visible = False
            SizeToolStripMenuItem.Visible = False
            BackGroundToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub MainFlowLayoutPanel_SizeChanged(sender As Object, e As EventArgs) Handles MainFlowLayoutPanel.SizeChanged
        'For Each x As FlowLayoutPanel In MainFlowLayoutPanel.Controls
        '    If (x.Name.Contains("FlP")) Then
        '        'x.AutoSize = False
        '        x.Width = MainFlowLayoutPanel.Width - 10
        '        Dim MinimizeButton_ As Button = CType(x.Controls("B_" & x.Name), Button)
        '        MinimizeButton_.Width = x.Width - 10
        '        'x.AutoSize = True
        '    End If
        'Next
    End Sub
#End Region

#Region "CMS_Group_ToolStripMenuItem"
    Private Sub AddGroupAreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGroupAreaToolStripMenuItem.Click
        Dim FlP_UC As New FlowLayoutPanel_UC
        FlP_UC.Name = "FlP" & "_" & FlPCount()
        'FlP_UC.Width = MainFlowLayoutPanel.Width - 10
        FlP_UC.Width = 250
        FlP_UC.BorderStyle = BorderStyle.Fixed3D
        FlP_UC.ContextMenuStrip = CMS_Group
        MainFlowLayoutPanel.Controls.Add(FlP_UC)
        Dim Caption_ As String = InputBox("Enter name for Group", "Name Group")
        If Caption_ = "" Then FlP_UC.Bu_Expand.Text = ">" Else FlP_UC.Bu_Expand.Text = Caption_
        AddHandler FlP_UC.FlowLayoutPanel1.MouseDown, AddressOf FlP_MouseDown ' we use MouseDown because we use ContextMenuStrip property so we need to set the ContextMenu befor it appear 
        AddHandler FlP_UC.FlowLayoutPanel1.DragEnter, AddressOf FlP_DragEnter
        AddHandler FlP_UC.FlowLayoutPanel1.DragDrop, AddressOf FlP_DragDrop
        FlP_UC.Show()
        MainFlowLayoutPanel.Refresh()
        Me.Refresh()
    End Sub
    Private Sub RenameGroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameGroupToolStripMenuItem.Click
        Dim FlP_parent As FlowLayoutPanel_UC = FIP_Clicked.Parent
        Dim temp As String = InputBox("Change the Title of this Group", "", FlP_parent.Bu_Expand.Text)
        If temp <> "" Then FlP_parent.Bu_Expand.Text = temp
    End Sub

    Private Sub AddButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddButtonToolStripMenuItem.Click
        Dim newBu As New Button_UC
        newBu.ContextMenuStrip = CMS_Button_Property
        FIP_Clicked.Controls.Add(newBu)
        'FIP_Clicked.AutoScroll = True
        'FIP_Clicked.AutoSize = True
        'newBu.Size = New Size(30, 30)
        newBu.Name = "Button_" & ButtonCount(FIP_Clicked) & "_" & FIP_Clicked.Name
        newBu.Show()
        FIP_Clicked.Refresh()
        AddHandler newBu.Bu_Shell.MouseDown, AddressOf SubButton_MouseDown
    End Sub
    Private Sub BackGroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackGroundToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog
        openFileDialog1.Filter = "*.jpg|jpg file|*.png|png file|All Files|*.*"
        openFileDialog1.ShowDialog()

        If (openFileDialog1.FileName = "" ) Then Exit Sub
        FIP_Clicked.BackgroundImage = Image.FromFile(openFileDialog1.FileName)
        FIP_Clicked.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
#End Region

#Region "SubButton_Click"
    Dim SubButton_Clicked As Button
    Dim SubButton_UC_Clicked As Button_UC
    Private Sub SubButton_MouseDown(sender As Object, e As MouseEventArgs)
        SubButton_Clicked = DirectCast(sender, Button)
        SubButton_UC_Clicked = SubButton_Clicked.Parent
        FIP_Clicked = SubButton_UC_Clicked.Parent
    End Sub
#End Region

#Region "FlP"
    Dim FIP_Clicked As FlowLayoutPanel
    Dim FIP_UC_Clicked As FlowLayoutPanel_UC
    Private Sub FlP_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            AddGroupAreaToolStripMenuItem.Visible = True
            RemoveButtonToolStripMenuItem.Visible = True
            AddButtonToolStripMenuItem.Visible = True
            RenameGroupToolStripMenuItem.Visible = True
            SizeToolStripMenuItem.Visible = True
            BackGroundToolStripMenuItem.Visible = True
        End If
        FIP_Clicked = DirectCast(sender, FlowLayoutPanel)
        FIP_UC_Clicked = FIP_Clicked.Parent
        FIP_Clicked.Focus()
    End Sub
    Private Sub FlP_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub FlP_DragDrop(sender As Object, e As DragEventArgs)
        Dim fileName() As String = e.Data.GetData(DataFormats.FileDrop)
        For i = 0 To fileName.Count - 1
            Dim NewButton As New Button_UC
            'MsgBox(GetLnkTarget(fileName(0)))
            'Dim myIcon As System.Drawing.Icon = Image.FromFile(fileName(0))
            'PictureBox1.Image = Image.FromFile(fileName(0))
            Dim hImgLarge As IntPtr  'The handle to the system image list.
            Dim shinfo As SHFILEINFO
            shinfo = New SHFILEINFO()
            Dim openFileDialog1 As OpenFileDialog
            openFileDialog1 = New OpenFileDialog()

            shinfo.szDisplayName = New String(Chr(0), 260)
            shinfo.szTypeName = New String(Chr(0), 80)
            'Use this to get the small icon.
            'hImgSmall = SHGetFileInfo(fName, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)
            'Use this to get the large icon.
            hImgLarge = SHGetFileInfo(fileName(i), 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_LARGEICON)

            'The icon is returned in the hIcon member of the shinfo struct.
            Dim myIcon As System.Drawing.Icon = System.Drawing.Icon.FromHandle(shinfo.hIcon)
            NewButton.Bu_Shell.Image = myIcon.ToBitmap
            NewButton.TB_FileName.Text = My.Computer.FileSystem.GetName(fileName(i))
            Dim FLP_UC_Sub As FlowLayoutPanel = DirectCast(sender, FlowLayoutPanel)
            NewButton.Name = "Button_" & ButtonCount(FLP_UC_Sub) & "_" & FLP_UC_Sub.Name
            NewButton.ContextMenuStrip = CMS_Button_Property
            FLP_UC_Sub.Controls.Add(NewButton)
            NewButton._FilePath = fileName(i)
            NewButton.Show()
            AddHandler NewButton.Bu_Shell.MouseDown, AddressOf SubButton_MouseDown
        Next
    End Sub
#End Region

    '#Region "minimizeButton"
    '    Private Sub MinimizeButton_Click(sender As Object, e As MouseEventArgs)
    '        Dim ClickedButton As Button = DirectCast(sender, Button)
    '        Dim FiP_Parent As FlowLayoutPanel = ClickedButton.Parent
    '        If (FiP_Parent.Height <> ClickedButton.Height + 15) Then
    '            FiP_Parent.AutoScroll = False
    '            FiP_Parent.Height = ClickedButton.Height + 15
    '            FiP_Parent.Width = MainFlowLayoutPanel.Width - 10
    '        Else
    '            FiP_Parent.Height = 100
    '            FiP_Parent.AutoScroll = True
    '            FiP_Parent.Width = MainFlowLayoutPanel.Width - 10
    '        End If
    '        ClickedButton.Width = FiP_Parent.Width - 10
    '        MainFlowLayoutPanel.Refresh()
    '        Me.Refresh()
    '    End Sub
    '#End Region

#Region "CMS_Button_Property"
    'Private Sub SizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizeToolStripMenuItem.Click
    '    Dim NewSize As String = InputBox("Enter new size ", "New Size", SubButton_Clicked.Width & "," & SubButton_Clicked.Height)
    '    'For Each x As Control In FIP_Clicked

    '    'Next
    'End Sub
    Private Sub SizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SizeToolStripMenuItem.Click
        Dim NewWidth As String = InputBox("Enter new width ", "New Size", FIP_Clicked.Width)
        Dim Newheight As String = InputBox("Enter new height ", "New Size", FIP_Clicked.Height)
        If (NewWidth = "" Or Newheight = "") Then Exit Sub
        'FIP_Clicked.Size = New Size(NewWidth, Newheight)
        FIP_UC_Clicked.Size_(NewWidth, Newheight)
        MainFlowLayoutPanel.Refresh()
        FIP_Clicked.Refresh()
        Me.Refresh()

    End Sub
    Private Sub RemoveButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveButtonToolStripMenuItem.Click
        Dim Bu_parant As Button_UC = SubButton_Clicked.Parent
        FIP_Clicked.Controls.Remove(Bu_parant)
        MainFlowLayoutPanel.Refresh()
        Me.Refresh()
    End Sub
    Private Sub TargetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TargetToolStripMenuItem.Click
        Dim dial As New OpenFileDialog
        dial.ShowDialog()
        Dim hImgLarge As IntPtr  'The handle to the system image list.
        Dim shinfo As SHFILEINFO
        shinfo = New SHFILEINFO()
        Dim openFileDialog1 As OpenFileDialog
        openFileDialog1 = New OpenFileDialog()

        shinfo.szDisplayName = New String(Chr(0), 260)
        shinfo.szTypeName = New String(Chr(0), 80)
        'Use this to get the small icon.
        'hImgSmall = SHGetFileInfo(fName, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_SMALLICON)
        'Use this to get the large icon.
        hImgLarge = SHGetFileInfo(dial.FileName, 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_LARGEICON)

        'The icon is returned in the hIcon member of the shinfo struct.
        Dim myIcon As System.Drawing.Icon = System.Drawing.Icon.FromHandle(shinfo.hIcon)
        SubButton_Clicked.Image = myIcon.ToBitmap
        SubButton_UC_Clicked.TB_FileName.Text = My.Computer.FileSystem.GetName(dial.FileName)
        SubButton_UC_Clicked._FilePath = dial.FileName
        'SubButton_Clicked.TB_FileName.Text = My.Computer.FileSystem.GetName(dial.FileName)
        'Dim FLP_UC_Sub As FlowLayoutPanel = DirectCast(sender, FlowLayoutPanel)
        'FLP_UC_Sub.Controls.Add(NewButton)
        'SubButton_Clicked._FilePath = dial.FileName


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
    Private Function ButtonCount(ByVal FIP_ As FlowLayoutPanel)
        Dim Count_ As Integer = 0
        For Each x As Control In FIP_.Controls
            If (x.Name.Contains("Button_")) Then
                Count_ += 1
            End If
        Next
        Return Count_
    End Function

    Private Sub TB_Search_TextChanged(sender As Object, e As EventArgs) Handles TB_Search.TextChanged
        For Each ss As Control In MainFlowLayoutPanel.Controls
            If (ss.Name.Contains("FlP")) Then
                For Each sss As Control In ss.Controls
                    If (sss.Name.Contains("FlowLayoutPanel")) Then
                        For Each x In sss.Controls
                            If (x.Name.Contains("Button_")) Then
                                Dim Bu_ As Button_UC = DirectCast(x, Button_UC)
                                If (Bu_.TB_FileName.Text.ToLower.Contains(TB_Search.Text.ToLower)) Then
                                    'Bu_.Focus()
                                    sss.Controls.SetChildIndex(Bu_, 0)
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Bu_End_Click(sender As Object, e As EventArgs) Handles Bu_End.Click
        End
    End Sub






#End Region

End Class
