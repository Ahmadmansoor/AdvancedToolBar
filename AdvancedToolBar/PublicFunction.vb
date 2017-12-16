Imports System.Runtime.InteropServices
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
End Module
