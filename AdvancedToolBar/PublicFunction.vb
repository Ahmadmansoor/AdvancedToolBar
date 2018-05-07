Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.MyServices

Module PublicFunction
    Public Structure SHFILEINFO
        Public hIcon As IntPtr            ' : icon
        Public iIcon As Integer           ' : icondex
        Public dwAttributes As Integer    ' : SFGAO_ flags
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)>
        Public szTypeName As String
    End Structure

    Public Declare Auto Function SHGetFileInfo Lib "shell32.dll" (ByVal pszPath As String, ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbFileInfo As Integer, ByVal uFlags As Integer) As IntPtr

    Public Const SHGFI_ICON = &H100
    Public Const SHGFI_SMALLICON = &H1
    Public Const SHGFI_LARGEICON = &H0
    Public Function GetLnkTarget(lnkPath As String) As String
        Dim shl = New Shell32.Shell()
        ' Move this to class scope
        lnkPath = System.IO.Path.GetFullPath(lnkPath)
        Dim dir = shl.[NameSpace](System.IO.Path.GetDirectoryName(lnkPath))
        Dim itm = dir.Items().Item(System.IO.Path.GetFileName(lnkPath))
        Dim lnk = DirectCast(itm.GetLink, Shell32.ShellLinkObject)
        Return lnk.Target.Path
    End Function
    Public ClipBoardRet() As rettype
    Public Maxiteams As Integer

    Public Structure rettype
        Dim Type_ As Integer
        Dim FileDropList As System.Collections.Specialized.StringCollection
        Dim Image_ As Image
        Dim Text_ As String
    End Structure
    Public Enum type_
        FileDropList = 1
        Image_ = 2
        Text_ = 3
    End Enum
    Public Sub CheckFillMem()
        If Not (ClipBoardRet) Is Nothing Then
            If ClipBoardRet.Count > 2 Then ClipBoardRet.Reverse(ClipBoardRet) : ReDim Preserve ClipBoardRet(1) : ClipBoardRet.Reverse(ClipBoardRet)
        End If



        If My.Computer.Clipboard.ContainsFileDropList Then
            If Not (ISRepeat(type_.FileDropList)) Then Exit Sub
            addArrayIteam()
            ClipBoardRet(ClipBoardRet.Count - 1).FileDropList = My.Computer.Clipboard.GetFileDropList()
            ClipBoardRet(ClipBoardRet.Count - 1).Type_ = type_.FileDropList
        End If

        If My.Computer.Clipboard.ContainsImage Then
            addArrayIteam()
            ClipBoardRet(ClipBoardRet.Count - 1).Image_ = My.Computer.Clipboard.GetImage
            ClipBoardRet(ClipBoardRet.Count - 1).Type_ = type_.Image_
        End If

        If My.Computer.Clipboard.ContainsText Then
            If Not (ISRepeat(type_.Text_)) Then Exit Sub
            addArrayIteam()
            ClipBoardRet(ClipBoardRet.Count - 1).Text_ = My.Computer.Clipboard.GetText
            ClipBoardRet(ClipBoardRet.Count - 1).Type_ = type_.Text_
        End If
    End Sub
    Private Sub addArrayIteam()
        If ClipBoardRet Is Nothing Then
            ReDim Preserve ClipBoardRet(0)
        ElseIf ClipBoardRet.Count = 1 Then
            ReDim Preserve ClipBoardRet(1)
        ElseIf ClipBoardRet.Count > 1 Then
            ReDim Preserve ClipBoardRet(ClipBoardRet.Count - 1 + 1)
        End If
    End Sub

    Private Function ISRepeat(ByVal typex_ As Integer) As Boolean
        Dim find_ As Boolean = False
        If Not (ClipBoardRet Is Nothing) Then
            Select Case typex_
                Case type_.FileDropList
                    Dim temp = My.Computer.Clipboard.GetFileDropList()
                    For i = 0 To ClipBoardRet.Count - 1
                        If (ClipBoardRet(i).Type_ = typex_) Then
                            If ClipBoardRet(i).FileDropList.Count = temp.Count Then
                                For x = 0 To ClipBoardRet(i).FileDropList.Count - 1
                                    For xx = 0 To temp.Count - 1
                                        If (ClipBoardRet(i).FileDropList(x) = temp(xx)) Then
                                            find_ = True
                                            Exit For
                                        Else
                                            find_ = False
                                        End If
                                    Next
                                Next
                            Else
                                find_ = False
                            End If
                        Else
                            find_ = False
                        End If
                        If find_ = True Then Exit For
                    Next
                Case type_.Image_
                    Dim temp = My.Computer.Clipboard.GetImage
                    For i = 0 To ClipBoardRet.Count - 1
                        If ClipBoardRet(i).Type_ = type_.Text_ Then
                            If System.Drawing.Bitmap.Equals(ClipBoardRet(i).Image_, temp) Then
                                find_ = True
                            Else
                                find_ = False
                            End If

                        End If
                    Next
                Case type_.Text_
                    Dim temp = My.Computer.Clipboard.GetText
                    For i = 0 To ClipBoardRet.Count - 1
                        If ClipBoardRet(i).Type_ = type_.Text_ Then
                            If ClipBoardRet(i).Text_ = temp Then
                                find_ = True
                                Exit For
                            Else
                                find_ = False
                            End If
                        End If
                    Next
            End Select
        Else
            find_ = False
        End If

        If find_ = False Then
            Return True
        Else
            Return False
        End If

    End Function


End Module
