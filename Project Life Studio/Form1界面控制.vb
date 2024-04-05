Imports Sunny.UI

Public Class Form1界面控制

    Public Shared Sub 初始化()
        界面控制.加载中文语言()


        窗口尺寸变化事件()


    End Sub

    Public Shared Sub 绑定动态调整()
        AddHandler Form1.SizeChanged, AddressOf 窗口尺寸变化事件




    End Sub

    Public Shared Sub 窗口尺寸变化事件()
        If Form1.WindowState = FormWindowState.Minimized Then Exit Sub


    End Sub


End Class
