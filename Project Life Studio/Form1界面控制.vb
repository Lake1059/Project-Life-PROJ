Public Class Form1界面控制

    Public Shared Sub 初始化()
        界面控制.加载中文语言()
        Form1.UiComboBox1.SelectedIndex = 0

        设置TAG多语言(Form1)

        For i = 0 To Form1.UiTabControlMenu1.TabPages.Count - 1
            Form1.UiTabControlMenu1.TabPages(i).Padding = New Padding(50)
        Next

    End Sub


    Private Shared Sub 设置TAG多语言(parentControl As Control)
        For Each ctrl As Control In parentControl.Controls
            If ctrl.Tag = "" Then Continue For
            If 界面控制.多语言数据.ContainsKey(ctrl.Tag) Then ctrl.Text = 界面控制.多语言数据(ctrl.Tag)
            If ctrl.HasChildren Then 设置TAG多语言(ctrl)
        Next
    End Sub




End Class
