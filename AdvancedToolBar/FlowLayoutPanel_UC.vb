Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Public Class FlowLayoutPanel_UC
    Private OrginalHeight As Integer = 0
    Private Expand As Boolean = True
    Private Sub Bu_Expand_Click(sender As Object, e As EventArgs) Handles Bu_Expand.Click
        If (Expand) Then
            OrginalHeight = Me.Height
            Me.Height = Bu_Expand.Top + Bu_Expand.Height + 3
            Expand = False
            Me.AutoScroll = False
        Else
            Me.Height = OrginalHeight
            Expand = True
            Me.AutoScroll = True
        End If
    End Sub
    Public Sub Size_(ByVal _Width As Integer, ByVal _height As Integer)
        Me.Size = New Size(_Width, _height)
    End Sub


#Region " Properties "
    'Private _Width As Integer
    ''Private _height As Integer
    'Private _Size As Size
    '''' <summary>
    '''' The text shown as the caption of the <see cref="ExpandableGroupbox" />.
    '''' </summary>
    '<Browsable(True)>
    'Public Property Size_(ByVal _Width As Integer, ByVal _height As Integer) As Size
    '    Get
    '        Return _Size
    '    End Get
    '    Set(ByVal value As Size)
    '        _Size = value
    '        Me.Size = New Size(_Width, _height)
    '    End Set
    'End Property




#End Region
End Class
