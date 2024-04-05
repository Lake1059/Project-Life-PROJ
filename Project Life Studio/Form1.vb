
Imports System.ComponentModel
Imports Steamworks
Imports Sunny.UI

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1界面控制.初始化()
        Form1界面控制.绑定动态调整()
        主操作.初始化()

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SteamAPI.Shutdown()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Steam.初始化Steam接口()
    End Sub

    Private Sub 编辑清单基本数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 编辑清单基本数据ToolStripMenuItem.Click
        Dim a As New TabPage With {.Text = "清单基本"}
        a.Controls.Add(New UC_编辑清单_基本 With {.Dock = DockStyle.Fill})
        Me.UiTabControl1.TabPages.Add(a)
    End Sub
End Class
