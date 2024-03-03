Imports System.IO
Imports System.Text.Json
Imports System.Drawing

Public Class 清单

    Public Property 模组名称 As String
    Public Property 作者 As String
    Public Property UniqueID As String
    Public Property 年龄分级 As String
    Public Property 版本号 As String
    Public Property 适用版本 As List(Of String)
    Public Property 分类标签 As List(Of String)
    Public Property 封面 As Byte()
    Public Property 描述 As String
    Public Property 依赖项 As List(Of String)
    Public Property 排在前 As List(Of String)
    Public Property 排在后 As List(Of String)

    Public Property 创意工坊ID As String


    Public Shared Function 保存(实例 As 清单, 文件路径 As String) As String
        Try
            FileIO.FileSystem.WriteAllText(文件路径, JsonSerializer.Serialize(实例), False)
            Return Nothing
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function 读取(ByRef 实例 As 清单, 文件路径 As String) As String
        Try
            实例 = JsonSerializer.Deserialize(Of 清单)(FileIO.FileSystem.ReadAllText(文件路径))
            Return Nothing
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function 图片转为Base64(图片 As Image) As Byte()
        Using ms As New MemoryStream()
            图片.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

End Class
