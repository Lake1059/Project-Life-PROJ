Public Class Form1界面控制

    Public Shared Sub 初始化()
        界面控制.加载中文语言()
        Form1.UiComboBox1.SelectedIndex = 0
        For i = 0 To Form1.UiTabControlMenu1.TabPages.Count - 1
            Form1.UiTabControlMenu1.TabPages(i).Padding = New Padding(50)
        Next
        窗口尺寸变化事件()


    End Sub

    Public Shared Sub 绑定动态调整()
        AddHandler Form1.SizeChanged, AddressOf 窗口尺寸变化事件




    End Sub

    Public Shared Sub 窗口尺寸变化事件()
        If Form1.WindowState = FormWindowState.Minimized Then Exit Sub
        For i = 0 To Form1.Panel8.Controls.Count - 1
            Form1.Panel8.Controls(i).Width = Form1.Panel8.Width / Form1.Panel8.Controls.Count
        Next
        For i = 0 To Form1.Panel9.Controls.Count - 1
            Form1.Panel9.Controls(i).Width = Form1.Panel9.Width / Form1.Panel9.Controls.Count
        Next
        For i = 0 To Form1.Panel10.Controls.Count - 1
            Form1.Panel10.Controls(i).Width = Form1.Panel10.Width / Form1.Panel10.Controls.Count
        Next
        For i = 0 To Form1.Panel11.Controls.Count - 1
            Form1.Panel11.Controls(i).Width = Form1.Panel11.Width / Form1.Panel11.Controls.Count
        Next
        For i = 0 To Form1.Panel12.Controls.Count - 1
            Form1.Panel12.Controls(i).Width = Form1.Panel12.Width / Form1.Panel12.Controls.Count
        Next
        For i = 0 To Form1.Panel13.Controls.Count - 1
            Form1.Panel13.Controls(i).Width = Form1.Panel13.Width / Form1.Panel13.Controls.Count
        Next



    End Sub


End Class
