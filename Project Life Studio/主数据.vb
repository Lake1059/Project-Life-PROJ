Imports System.IO
Imports Sunny.UI

Public Class 主数据

    Public Shared Sub 全部重置()
        当前模组路径 = ""
        另存模组路径 = ""
        清单 = New PLG.单片.清单

    End Sub

    Public Shared Sub 读取数据()
        PLG.单片.清单.读取(清单, Path.Combine(当前模组路径, "manifest"))
        Form1.UiTextBox2.Text = 清单.模组名称
        Form1.UiTextBox1.Text = 清单.作者
        Form1.UiTextBox3.Text = 清单.UniqueID
        Form1.UiComboBox4.SelectedIndex = 清单.年龄分级 - 1
        Form1.UiTextBox4.Text = 清单.版本号
        Form1.UiTextBox7.Text = 清单.描述
        If 清单.适用版本 IsNot Nothing Then Form1.UiTextBox5.Text = String.Join(", ", 清单.适用版本)
        If 清单.分类标签 IsNot Nothing Then Form1.UiTextBox6.Text = String.Join(", ", 清单.分类标签)
        If FileIO.FileSystem.FileExists(Path.Combine(当前模组路径, "preview.jpg")) Then
            Using fs As New IO.FileStream(Path.Combine(当前模组路径, "preview.jpg"), IO.FileMode.Open, IO.FileAccess.Read)
                Form1.PictureBox3.Image = Image.FromStream(fs)
                fs.Close()
            End Using
        End If

    End Sub

    Public Shared Sub 保存数据()
        清单.模组名称 = Form1.UiTextBox2.Text
        清单.作者 = Form1.UiTextBox1.Text
        清单.UniqueID = Form1.UiTextBox3.Text
        清单.年龄分级 = Form1.UiComboBox4.SelectedIndex + 1
        清单.版本号 = Form1.UiTextBox4.Text
        清单.描述 = Form1.UiTextBox7.Text
        PLG.单片.清单.保存(清单, Path.Combine(当前模组路径, "manifest"))

    End Sub

    Public Shared Sub 另存数据()
        If FileIO.FileSystem.FileExists(Path.Combine(当前模组路径, "preview.jpg")) Then
            FileIO.FileSystem.CopyFile(Path.Combine(当前模组路径, "preview.jpg"), Path.Combine(另存模组路径, "preview.jpg"), True)
        End If
        当前模组路径 = 另存模组路径
        另存模组路径 = ""
        保存数据()

    End Sub

    Public Shared Property 当前模组路径 As String
    Public Shared Property 另存模组路径 As String
    Public Shared Property 清单 As New PLG.单片.清单




End Class
