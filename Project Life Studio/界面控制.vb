Imports System.Reflection

Public Class 界面控制

    Public Shared Property 多语言数据 As New Dictionary(Of String, String)

    Public Shared Sub 加载中文语言()
        多语言数据.Clear()
        键值对IO操作.读取键值对文本到字典(多语言数据, My.Resources.SimplifiedChinese)
        设置TAG多语言(Form1)
    End Sub

    Public Shared Sub 设置TAG多语言(parentControl As Control)
        For Each ctrl As Control In parentControl.Controls
            If ctrl.Tag Is Nothing Then
                If ctrl.HasChildren Then 设置TAG多语言(ctrl)
                Continue For
            End If
            If 多语言数据.ContainsKey(ctrl.Tag) Then 设置TAG多语言_检查属性(ctrl)
            If ctrl.HasChildren Then 设置TAG多语言(ctrl)
        Next
    End Sub

    Private Shared Sub 设置TAG多语言_检查属性(control As Control)
        Dim controlType As Type = control.GetType()
        Dim propInfo As PropertyInfo = controlType.GetProperty("Text")
        If propInfo IsNot Nothing Then control.Text = 多语言数据(control.Tag).Replace("<br>", vbCrLf)
    End Sub


    Public Shared Sub 显示模式窗体(哪个窗口 As Form, 以谁为基准显示 As Form)
        哪个窗口.Left = (以谁为基准显示.Width - 哪个窗口.Width) * 0.5 + 以谁为基准显示.Left
        哪个窗口.Top = (以谁为基准显示.Height - 哪个窗口.Height) * 0.5 + 以谁为基准显示.Top
        哪个窗口.ShowDialog(以谁为基准显示)
    End Sub

    Public Shared Sub 显示窗体(哪个窗口 As Form, 以谁为基准显示 As Form)
        If 哪个窗口.Visible = True Then
            哪个窗口.Focus()
            哪个窗口.Left = (以谁为基准显示.Width - 哪个窗口.Width) * 0.5 + 以谁为基准显示.Left
            哪个窗口.Top = (以谁为基准显示.Height - 哪个窗口.Height) * 0.5 + 以谁为基准显示.Top
        Else
            哪个窗口.Left = (以谁为基准显示.Width - 哪个窗口.Width) * 0.5 + 以谁为基准显示.Left
            哪个窗口.Top = (以谁为基准显示.Height - 哪个窗口.Height) * 0.5 + 以谁为基准显示.Top
            哪个窗口.Show(以谁为基准显示)
        End If
    End Sub

End Class
