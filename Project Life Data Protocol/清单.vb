Imports System.IO
Imports System.Text.Json
Imports System.Drawing

Public Class �嵥

    Public Property ģ������ As String
    Public Property ���� As String
    Public Property UniqueID As String
    Public Property ����ּ� As String
    Public Property �汾�� As String
    Public Property ���ð汾 As List(Of String)
    Public Property �����ǩ As List(Of String)
    Public Property ���� As Byte()
    Public Property ���� As String
    Public Property ������ As List(Of String)
    Public Property ����ǰ As List(Of String)
    Public Property ���ں� As List(Of String)

    Public Property ���⹤��ID As String


    Public Shared Function ����(ʵ�� As �嵥, �ļ�·�� As String) As String
        Try
            FileIO.FileSystem.WriteAllText(�ļ�·��, JsonSerializer.Serialize(ʵ��), False)
            Return Nothing
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function ��ȡ(ByRef ʵ�� As �嵥, �ļ�·�� As String) As String
        Try
            ʵ�� = JsonSerializer.Deserialize(Of �嵥)(FileIO.FileSystem.ReadAllText(�ļ�·��))
            Return Nothing
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function ͼƬתΪBase64(ͼƬ As Image) As Byte()
        Using ms As New MemoryStream()
            ͼƬ.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

End Class
