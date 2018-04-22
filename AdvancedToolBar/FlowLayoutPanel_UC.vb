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

#Region " Properties "
    'Private _Caption As String
    '''' <summary>
    '''' The text shown as the caption of the <see cref="ExpandableGroupbox" />.
    '''' </summary>
    '<Browsable(True)>
    'Public Property Caption() As String
    '    Get
    '        Return _Caption
    '    End Get
    '    Set(ByVal value As String)
    '        _Caption = value
    '        Me.Bu_Expand.Text = value
    '    End Set
    'End Property




#End Region
End Class
