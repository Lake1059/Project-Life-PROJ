
Imports System.ComponentModel
Imports PLG

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1界面控制.初始化()
        Form1界面控制.绑定动态调整()
        Steam.初始化Steam接口()
        主操作.初始化()




    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

End Class
