Imports Shell32
Imports System.Runtime.InteropServices
Public Class Form1
    Dim rc As ResizeableControl
    Private Structure gbCountHieght_
        Dim count As Integer
        Dim Hieght As Integer
    End Structure
    Dim gbCountHieght As New gbCountHieght_

    'Private WithEvents kbHook As New KeyboardHook

    'Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
    '    Dim mousepos As Rectangle = Screen.PrimaryScreen.WorkingArea
    '    Dim x = MousePosition.X - Screen.PrimaryScreen.Bounds.X
    '    Dim y = MousePosition.Y
    '    If Key = 162 And x >= mousepos.Width - 10 Then
    '        Me.Show()
    '    End If
    'End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Timer1.Stop()
        Timer1.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMS.Parent = Me.Parent
        rc = New ResizeableControl(ExpandableGroupbox1)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'e.Cancel = True
        'Me.Hide()
    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim fileName() As String = e.Data.GetData(DataFormats.FileDrop)
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
        hImgLarge = SHGetFileInfo(fileName(0), 0, shinfo, Marshal.SizeOf(shinfo), SHGFI_ICON Or SHGFI_LARGEICON)

        'The icon is returned in the hIcon member of the shinfo struct.
        Dim myIcon As System.Drawing.Icon = System.Drawing.Icon.FromHandle(shinfo.hIcon)
        PictureBox1.Image = myIcon.ToBitmap

    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick

        If (e.Button = MouseButtons.Right) Then
            CMS.Items.Clear()
            CMS.Items.Add("Add group area")
            'CMS.Items.Add("test1")
            CMS.Show()
            CMS.Location = New Point(e.X + Me.Left, e.Y + Me.Top + 20)
            AddHandler CMS.MouseClick, AddressOf checkCMS
        End If

    End Sub
    Sub checkCMS()
        If CMS.Items.Item(0).Selected Then
            Dim gb As New ExpandableGroupbox
            Getgbcount()
            Me.Controls.Add(gb)
            gb.Location = New Point(0, gbCountHieght.Hieght)
            'gb.Size = New Size(20, 20)
            gb.Show()
            Me.Refresh()
        End If
        'If CMS.Items.Item(1).Selected Then MsgBox("test1")
    End Sub

    ''' <summary>
    ''' to get how many ExpandableGroupbox in the form so we can calculate the hieght and
    ''' add the new control next to last one of controls
    ''' </summary>
    Sub Getgbcount()
        Dim count = 0, hieght As Integer = 0
        For Each con As Control In Me.Controls
            If TypeOf con Is ExpandableGroupbox Then
                count += 1
                hieght = count * con.Height
            End If
        Next

        gbCountHieght.count = count
        gbCountHieght.Hieght = hieght
    End Sub

    Private Sub ExpandableGroupbox1_MouseDown(sender As Object, e As MouseEventArgs) Handles ExpandableGroupbox1.MouseDown
        'If (e.Y + Me.Top = ExpandableGroupbox1.Location.Y) Then
        ExpandableGroupbox1.Height += e.Y - ExpandableGroupbox1.Top
        Me.Refresh()
        ' End If
    End Sub
End Class
