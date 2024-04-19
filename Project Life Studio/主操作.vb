
Imports System.IO
Imports Sunny.UI

Public Class 主操作

    Public Shared Sub 初始化()
        'AddHandler Form1.UiButton创建新模组.Click, AddressOf 创建新模组
        'AddHandler Form1.UiButton加载现有模组.Click, AddressOf 加载现有模组
        'AddHandler Form1.UiButton另存新位置.Click, AddressOf 另存新位置
        'AddHandler Form1.UiButton保存所有改动.Click, AddressOf 保存所有改动
        'AddHandler Form1.UiButton创建新物品.Click, AddressOf 创建新物品
        'AddHandler Form1.UiButton上传更新.Click, AddressOf 上传更新
        'AddHandler Form1.UiButton9.Click, AddressOf 选择适用版本
        'AddHandler Form1.UiButton10.Click, AddressOf 选择标签
        'AddHandler Form1.UiButton11.Click, AddressOf 选择预览图

        重置显示和数据()
    End Sub


    Public Shared Sub 重置显示和数据()
        Form1.Text = Application.ProductName
        'Form1.Label16.Text = 界面控制.多语言数据("当前没有载入模组")
        'Form1.UiRadioButton1.Checked = False
        'Form1.UiRadioButton2.Checked = False
        'Form1.UiTextBox2.Text = ""
        'Form1.UiTextBox1.Text = ""
        'Form1.UiTextBox3.Text = ""
        'Form1.UiComboBox4.SelectedIndex = -1
        'Form1.UiTextBox4.Text = ""
        'Form1.UiTextBox5.Text = ""
        'Form1.UiTextBox6.Text = ""
        'Form1.UiTextBox7.Text = ""
        'Form1.PictureBox3.Image = Nothing

    End Sub


    Public Shared Sub 创建新模组()
        If 主数据.当前模组路径 <> "" Then
            If MsgBox(界面控制.多语言数据("未保存的工作将丢失"), MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        Dim str1 As String = ""
        If DirEx.SelectDirEx(界面控制.多语言数据("选择新模组保存位置"), str1) Then
            重置显示和数据()
            主数据.当前模组路径 = str1
            'Form1.Label16.Text = str1
        End If
    End Sub

    Public Shared Sub 加载现有模组()
        If 主数据.当前模组路径 <> "" Then
            If MsgBox(界面控制.多语言数据("未保存的工作将丢失"), MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        Dim str1 As String = ""
        If DirEx.SelectDirEx(Nothing, str1) Then
            If Not FileIO.FileSystem.FileExists(Path.Combine(str1, "manifest")) Then
                MsgBox(界面控制.多语言数据("所选的模组不包含清单"))
                Exit Sub
            End If
            主数据.当前模组路径 = str1
            'Form1.Label16.Text = str1
            主数据.读取数据()
        End If
    End Sub

    Public Shared Sub 另存新位置()
        If 主数据.当前模组路径 = "" Then Exit Sub
        Dim str1 As String = ""
        If DirEx.SelectDirEx(界面控制.多语言数据("选择新模组保存位置"), str1) Then
            主数据.另存模组路径 = str1
            'Form1.Label16.Text = str1
            主数据.另存数据()
            MsgBox(界面控制.多语言数据("已保存数据"))
        End If
    End Sub

    Public Shared Sub 保存所有改动()
        If 主数据.当前模组路径 = "" Then Exit Sub
        If FileIO.FileSystem.DirectoryExists(主数据.当前模组路径) Then
            主数据.保存数据()
            MsgBox(界面控制.多语言数据("已保存数据"))
        End If
    End Sub

    Public Shared Sub 创建新物品()
        If Not FileIO.FileSystem.FileExists(Path.Combine(主数据.当前模组路径, "manifest")) Then Exit Sub
        If MsgBox(界面控制.多语言数据("确保已经保存到硬盘"), MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Dim a As New PLG.单片.清单
        PLG.单片.清单.读取(a, Path.Combine(主数据.当前模组路径, "manifest"))
        If a.创意工坊ID <> "" Then
            MsgBox(界面控制.多语言数据("已有创意工坊ID请使用上传更新功能"), MsgBoxStyle.Critical)
            Exit Sub
        End If
        If a.模组名称 = "" Then
            MsgBox(界面控制.多语言数据("模组名称未设置"), MsgBoxStyle.Critical) : Exit Sub
        End If
        If a.UniqueID = "" Then
            MsgBox(界面控制.多语言数据("UniqueID 未设置"), MsgBoxStyle.Critical) : Exit Sub
        End If
        If a.年龄分级 = Nothing Then
            MsgBox(界面控制.多语言数据("分级未设置"), MsgBoxStyle.Critical) : Exit Sub
        End If
        If a.适用版本 Is Nothing Then
            MsgBox(界面控制.多语言数据("适用版本未设置"), MsgBoxStyle.Critical) : Exit Sub
        End If
        If a.分类标签 Is Nothing Then
            MsgBox(界面控制.多语言数据("标签未设置"), MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim b As New Steam
        Dim 用于上传的标签数据 As List(Of String) = a.分类标签
        Select Case a.年龄分级
            Case PLG.单片.清单.年龄分级_枚举.大众级
                用于上传的标签数据.Add("Everyone")
            Case PLG.单片.清单.年龄分级_枚举.家长指导级
                用于上传的标签数据.Add("Parent Guide")
            Case PLG.单片.清单.年龄分级_枚举.成人级
                用于上传的标签数据.Add("Aldult")
        End Select
        For i = 0 To a.适用版本.Count - 1
            用于上传的标签数据.Add(a.适用版本(i))
        Next
        Dim 预览图路径 As String = ""
        If FileIO.FileSystem.FileExists(Path.Combine(主数据.当前模组路径, "preview.jpg")) Then
            预览图路径 = Path.Combine(主数据.当前模组路径, "preview.jpg")
        End If
        Dim 发布可见性 As Steamworks.ERemoteStoragePublishedFileVisibility
        'If Form1.UiRadioButton1.Checked Then
        '    发布可见性 = Steamworks.ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic
        'ElseIf Form1.UiRadioButton2.Checked Then
        '    发布可见性 = Steamworks.ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPrivate
        'End If

        b.创建新的创意工坊物品并上传(a.模组名称, a.描述, 主数据.当前模组路径, 用于上传的标签数据, 预览图路径, 发布可见性)

    End Sub

    Public Shared Sub 上传更新()
        If Not FileIO.FileSystem.FileExists(Path.Combine(主数据.当前模组路径, "manifest")) Then Exit Sub
        If MsgBox(界面控制.多语言数据("确保已经保存到硬盘"), MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        Dim a As New PLG.单片.清单
        PLG.单片.清单.读取(a, Path.Combine(主数据.当前模组路径, "manifest"))
        If a.模组名称 = "" Then
            MsgBox(界面控制.多语言数据("模组名称未设置"), MsgBoxStyle.Critical) : Exit Sub
        End If
        If a.UniqueID = "" Then
            MsgBox(界面控制.多语言数据("UniqueID 未设置"), MsgBoxStyle.Critical) : Exit Sub
        End If
        If a.年龄分级 = Nothing Then
            MsgBox(界面控制.多语言数据("分级未设置"), MsgBoxStyle.Critical) : Exit Sub
        End If
        If a.适用版本 Is Nothing Then
            MsgBox(界面控制.多语言数据("适用版本未设置"), MsgBoxStyle.Critical) : Exit Sub
        End If
        If a.分类标签 Is Nothing Then
            MsgBox(界面控制.多语言数据("标签未设置"), MsgBoxStyle.Critical) : Exit Sub
        End If

        Dim b As New Steam
        Dim 用于上传的标签数据 As List(Of String) = a.分类标签
        Select Case a.年龄分级
            Case PLG.单片.清单.年龄分级_枚举.大众级
                用于上传的标签数据.Add("Everyone")
            Case PLG.单片.清单.年龄分级_枚举.家长指导级
                用于上传的标签数据.Add("Parent Guide")
            Case PLG.单片.清单.年龄分级_枚举.成人级
                用于上传的标签数据.Add("Aldult")
        End Select
        For i = 0 To a.适用版本.Count - 1
            用于上传的标签数据.Add(a.适用版本(i))
        Next
        Dim 预览图路径 As String = ""
        If FileIO.FileSystem.FileExists(Path.Combine(主数据.当前模组路径, "preview.jpg")) Then
            预览图路径 = Path.Combine(主数据.当前模组路径, "preview.jpg")
        End If
        Dim 发布可见性 As Steamworks.ERemoteStoragePublishedFileVisibility
        'If Form1.UiRadioButton1.Checked Then
        '    发布可见性 = Steamworks.ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic
        'ElseIf Form1.UiRadioButton2.Checked Then
        '    发布可见性 = Steamworks.ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPrivate
        'End If

        b.更新创意工坊物品并上传(a.创意工坊ID, a.模组名称, 主数据.当前模组路径, 用于上传的标签数据, 预览图路径, 发布可见性)

    End Sub


    Public Shared Sub 选择适用版本()
        If 主数据.当前模组路径 = "" Then Exit Sub
        Using a As New Form选择适用版本
            If 主数据.清单.适用版本 IsNot Nothing Then
                For i = 0 To 主数据.清单.适用版本.Count - 1
                    For i3 = 0 To a.UiCheckBoxGroup1.Items.Count - 1
                        If a.UiCheckBoxGroup1.Items(i3).ToString = 主数据.清单.适用版本(i) Then
                            a.UiCheckBoxGroup1.SelectedIndexes.Add(i3)
                        End If
                    Next
                Next
            End If
            界面控制.显示模式窗体(a, Form1)
            主数据.清单.适用版本 = a.UiCheckBoxGroup1.SelectedItems.OfType(Of String)().ToList()
            'Form1.UiTextBox5.Text = String.Join(", ", a.UiCheckBoxGroup1.SelectedItems)
        End Using
    End Sub

    Public Shared Sub 选择标签()
        If 主数据.当前模组路径 = "" Then Exit Sub
        Using a As New Form选择标签
            If 主数据.清单.分类标签 IsNot Nothing Then
                For i = 0 To 主数据.清单.分类标签.Count - 1
                    For i3 = 0 To a.UiCheckBoxGroup1.Items.Count - 1
                        If a.UiCheckBoxGroup1.Items(i3).ToString = 主数据.清单.分类标签(i) Then
                            a.UiCheckBoxGroup1.SelectedIndexes.Add(i3)
                        End If
                    Next
                Next
            End If
            界面控制.显示模式窗体(a, Form1)
            主数据.清单.分类标签 = a.UiCheckBoxGroup1.SelectedItems.OfType(Of String)().ToList()
            'Form1.UiTextBox6.Text = String.Join(", ", a.UiCheckBoxGroup1.SelectedItems)
        End Using
    End Sub

    Public Shared Sub 选择预览图()
        If 主数据.当前模组路径 = "" Then Exit Sub
        Using a As New OpenFileDialog With {.Multiselect = False, .Filter = "JPG|*.jpg"}
            a.ShowDialog()
            If a.FileName = "" Then Exit Sub
            FileIO.FileSystem.CopyFile(a.FileName, Path.Combine(主数据.当前模组路径, "preview.jpg"), True)
            Using fs As New IO.FileStream(a.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                'Form1.PictureBox3.Image = Image.FromStream(fs)
                fs.Close()
            End Using
        End Using
    End Sub



End Class
