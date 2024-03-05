Imports System.Text.Json

Namespace 模组数据.单片

    <Serializable>
    Public Class 清单
        Public Property 模组名称 As String
        Public Property 作者 As String
        Public Property UniqueID As String
        Public Property 年龄分级 As 年龄分级_枚举
        Public Property 版本号 As String
        Public Property 适用版本 As List(Of String)
        Public Property 分类标签 As List(Of String)
        Public Property 描述 As String
        Public Property 依赖项 As List(Of String)
        Public Property 排在前 As List(Of String)
        Public Property 排在后 As List(Of String)
        Public Property 创意工坊ID As String

        Enum 年龄分级_枚举
            大众级 = 1
            家长指导级 = 2
            成人级 = 3
        End Enum

        Public Shared Function 保存(对象 As 清单, 文件 As String) As String
            Try
                FileIO.FileSystem.WriteAllText(文件, JsonSerializer.Serialize(对象), False)
                Return ""
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function

        Public Shared Function 读取(ByRef 对象 As 清单, 文件 As String) As String
            Try
                对象 = JsonSerializer.Deserialize(Of 清单)(FileIO.FileSystem.ReadAllText(文件))
                Return ""
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function

    End Class

End Namespace