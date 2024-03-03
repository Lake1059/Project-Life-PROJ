Public Class 界面控制

    Public Shared Property 多语言数据 As New Dictionary(Of String, String)

    Public Shared Sub 加载中文语言()
        多语言数据.Clear()
        键值对IO操作.读取键值对文本到字典(多语言数据, My.Resources.SimplifiedChinese)
    End Sub

End Class
