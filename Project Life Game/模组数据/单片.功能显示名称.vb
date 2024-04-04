
Imports System.Text.Json

Namespace 单片

    <Serializable>
    Public Class 功能显示名称

        Public Property 殖民地 As Dictionary(Of String, String)
        Public Property 人口 As Dictionary(Of String, String)
        Public Property 物品仓库 As Dictionary(Of String, String)
        Public Property 角色 As Dictionary(Of String, String)
        Public Property 武器 As Dictionary(Of String, String)
        Public Property 圣遗物 As Dictionary(Of String, String)
        Public Property 技能 As Dictionary(Of String, String)
        Public Property 天赋 As Dictionary(Of String, String)
        Public Property 故事 As Dictionary(Of String, String)
        Public Property 载具 As Dictionary(Of String, String)
        Public Property 部件 As Dictionary(Of String, String)
        Public Property 农田 As Dictionary(Of String, String)
        Public Property 牧场 As Dictionary(Of String, String)
        Public Property 鱼塘 As Dictionary(Of String, String)
        Public Property 池塘 As Dictionary(Of String, String)








        Public Shared Function 保存(对象 As 功能显示名称, 文件 As String) As String
            Try
                FileIO.FileSystem.WriteAllText(文件, JsonSerializer.Serialize(对象), False)
                Return ""
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function

        Public Shared Function 读取(ByRef 对象 As 功能显示名称, 文件 As String) As String
            Try
                对象 = JsonSerializer.Deserialize(Of 功能显示名称)(FileIO.FileSystem.ReadAllText(文件))
                Return ""
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
    End Class

End Namespace