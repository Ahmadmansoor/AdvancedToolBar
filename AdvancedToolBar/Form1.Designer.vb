﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExpandableGroupbox1 = New AdvancedToolBar.ExpandableGroupbox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'CMS
        '
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(831, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 54)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ExpandableGroupbox1
        '
        Me.ExpandableGroupbox1.Caption = Nothing
        Me.ExpandableGroupbox1.HeaderClickExpand = True
        Me.ExpandableGroupbox1.Location = New System.Drawing.Point(646, 228)
        Me.ExpandableGroupbox1.Name = "ExpandableGroupbox1"
        Me.ExpandableGroupbox1.Size = New System.Drawing.Size(200, 100)
        Me.ExpandableGroupbox1.TabIndex = 2
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(938, 678)
        Me.Controls.Add(Me.ExpandableGroupbox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents CMS As ContextMenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExpandableGroupbox1 As ExpandableGroupbox
End Class