Imports System.ComponentModel

Public Class Button_UC


    Private Sub ShellTarget()

    End Sub

#Region " Properties "
    Private FilePath As String = String.Empty
    ''' <summary>
    ''' The text shown as the caption of the <see cref="ExpandableGroupbox" />.
    ''' </summary>
    <Browsable(True)>
    Public Property _FilePath() As String
        Get
            Return FilePath
        End Get
        Set(ByVal value As String)
            FilePath = value
        End Set
    End Property

    Private Sub Bu_Shell_Click(sender As Object, e As EventArgs) Handles Bu_Shell.Click
        If (FilePath = "") Then
            MsgBox("Not defined Target")
        Else
            Try
                Process.Start(FilePath)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End If
    End Sub




#End Region

End Class
