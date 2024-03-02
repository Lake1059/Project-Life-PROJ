Public Class Form1界面控制

    Public Shared Sub 初始化()
        For i = 0 To Form1.UiTabControlMenu1.TabPages.Count - 1
            Form1.UiTabControlMenu1.TabPages(i).Padding = New Padding(50)
        Next
    End Sub

End Class
