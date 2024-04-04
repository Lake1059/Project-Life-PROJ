Imports System.IO
Imports Steamworks

Public Class Steam

    Public Shared Property Steam是否完成了初始化 As Boolean = False
    Public Shared Property 运行回调的定时器 As New Timer With {.Interval = 1000}

    Public Shared Sub 初始化Steam接口()
        Steam是否完成了初始化 = SteamAPI.Init
        If Steam是否完成了初始化 Then
            AddHandler 运行回调的定时器.Tick,
                  Sub(sender, e)
                      SteamAPI.RunCallbacks()
                  End Sub
            运行回调的定时器.Enabled = True
            Form1.Text = Application.ProductName & " - " & 界面控制.多语言数据("Steamworks已连接").Replace("{0}", SteamFriends.GetPersonaName())
        Else
            Form1.Text = Application.ProductName & " - " & 界面控制.多语言数据("Steamworks未连接")
            Form1.Panel6.Enabled = False
        End If
    End Sub

    Structure SteamWorkshopItem
        Public ContentFolderPath As String
        Public Description As String
        Public PreviewImagePath As String
        Public Tags As List(Of String)
        Public Title As String
        Public Visibility As ERemoteStoragePublishedFileVisibility
    End Structure

    Public 改动说明 As String = ""
    Public 当前创意工坊物品对象 As SteamWorkshopItem
    Public 当前创意工坊物品ID对象 As PublishedFileId_t

    Public Shared Function 获取已订阅物品的安装路径() As List(Of String)
        Dim subscribedCount = SteamUGC.GetNumSubscribedItems()
        Dim subscribedFiles As PublishedFileId_t() = New PublishedFileId_t(subscribedCount - 1) {}
        SteamUGC.GetSubscribedItems(subscribedFiles, subscribedFiles.Length)
        Dim installLocation As String = String.Empty
        Return subscribedFiles.Select(Function(file)
                                          SteamUGC.GetItemInstallInfo(file, 0UL, installLocation, 1024, 0)
                                          Return installLocation
                                      End Function).ToList()
    End Function

    Public Sub 创建新的创意工坊物品并上传(物品标题 As String, 物品描述 As String, 包含内容的文件夹 As String, 标签 As List(Of String), 预览图路径 As String, 可见性 As ERemoteStoragePublishedFileVisibility)
        当前创意工坊物品对象 = New SteamWorkshopItem With {
            .Title = 物品标题,
            .Description = 物品描述,
            .ContentFolderPath = 包含内容的文件夹,
            .Tags = 标签,
            .PreviewImagePath = 预览图路径,
            .Visibility = 可见性
        }
        CreateItem()
    End Sub

    Public Sub 更新创意工坊物品并上传(创意工坊物品ID As ULong, 物品标题 As String, 包含内容的文件夹 As String, 标签 As List(Of String), 预览图路径 As String, 可见性 As ERemoteStoragePublishedFileVisibility)
        当前创意工坊物品对象 = New SteamWorkshopItem With {
            .Title = 物品标题,
            .ContentFolderPath = 包含内容的文件夹,
            .Tags = 标签,
            .PreviewImagePath = 预览图路径,
            .Visibility = 可见性
        }
        当前创意工坊物品ID对象 = New PublishedFileId_t With {.m_PublishedFileId = 创意工坊物品ID}
        UpdateItem()
    End Sub

    Private Sub CreateItem()
        Form1.Text = Application.ProductName & " - " & 界面控制.多语言数据("Steamworks开始创建物品")
        Dim steamAPICall = SteamUGC.CreateItem(SteamUtils.GetAppID(), EWorkshopFileType.k_EWorkshopFileTypeCommunity)
        Dim steamAPICallResult = CallResult(Of CreateItemResult_t).Create()
        steamAPICallResult.Set(steamAPICall, AddressOf CreateItemResult)
    End Sub

    Private Sub CreateItemResult(param As CreateItemResult_t, bIOFailure As Boolean)
        If param.m_eResult = EResult.k_EResultOK Then
            当前创意工坊物品ID对象 = param.m_nPublishedFileId
            Form1.Text = Application.ProductName & " - " & 界面控制.多语言数据("Steamworks已创建物品").Replace("{0}", param.m_nPublishedFileId.m_PublishedFileId)
重试写入ID:
            Try
                Dim a As New PLG.单片.清单
                Dim b1 As String = PLG.单片.清单.读取(a, Path.Combine(当前创意工坊物品对象.ContentFolderPath, "manifest"))
                If b1 <> "" Then Err.Raise(1059,, b1)
                a.创意工坊ID = param.m_nPublishedFileId.m_PublishedFileId
                Dim b2 As String = PLG.单片.清单.保存(a, Path.Combine(当前创意工坊物品对象.ContentFolderPath, "manifest"))
                If b2 <> "" Then Err.Raise(1059,, b2)
            Catch ex As Exception
                If MsgBox(界面控制.多语言数据("Steamworks已创建物品").Replace("{0}", ex.Message).Replace("{1}", 当前创意工坊物品ID对象.m_PublishedFileId), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then GoTo 重试写入ID
                Exit Sub
            End Try

            RaiseEvent 创建物品成功事件(当前创意工坊物品ID对象.m_PublishedFileId)
            Application.DoEvents()
            UpdateItem()
        Else
            Form1.Text = Application.ProductName & " - " & 界面控制.多语言数据("Steamworks创建物品失败").Replace("{0}", param.m_eResult.ToString)
            RaiseEvent 创建物品失败事件(param.m_eResult)
        End If
    End Sub

    Public Event 创建物品成功事件(物品ID As ULong)
    Public Event 创建物品失败事件(失败类型 As EResult)

    Private Sub UpdateItem()
        Dim updateHandle = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), 当前创意工坊物品ID对象)
        SteamUGC.SetItemTitle(updateHandle, 当前创意工坊物品对象.Title)
        If 当前创意工坊物品对象.Description <> "" Then SteamUGC.SetItemDescription(updateHandle, 当前创意工坊物品对象.Description)
        SteamUGC.SetItemContent(updateHandle, 当前创意工坊物品对象.ContentFolderPath)
        SteamUGC.SetItemTags(updateHandle, 当前创意工坊物品对象.Tags)
        SteamUGC.SetItemPreview(updateHandle, 当前创意工坊物品对象.PreviewImagePath)
        SteamUGC.SetItemVisibility(updateHandle, 当前创意工坊物品对象.Visibility)
        Form1.Text = Application.ProductName & " - " & 界面控制.多语言数据("Steamworks物品信息已更新").Replace("{0}", 当前创意工坊物品对象.Title)
        Dim steamAPICall = SteamUGC.SubmitItemUpdate(updateHandle, 改动说明)
        Dim steamAPICallResult = CallResult(Of SubmitItemUpdateResult_t).Create()
        steamAPICallResult.[Set](steamAPICall, AddressOf UpdateItemResult)
    End Sub

    Private Sub UpdateItemResult(param As SubmitItemUpdateResult_t, bIOFailure As Boolean)
        If param.m_eResult = EResult.k_EResultOK Then
            Form1.Text = Application.ProductName & " - " & 界面控制.多语言数据("Steamworks上传成功").Replace("{0}", 当前创意工坊物品ID对象.m_PublishedFileId)
            RaiseEvent 上传成功事件(当前创意工坊物品ID对象.m_PublishedFileId)
        Else
            Form1.Text = Application.ProductName & " - " & 界面控制.多语言数据("Steamworks上传失败").Replace("{0}", param.m_eResult.ToString)
            RaiseEvent 上传失败事件(param.m_eResult)
        End If
    End Sub

    Public Event 上传成功事件(物品ID As ULong)
    Public Event 上传失败事件(失败类型 As EResult)

    Public Shared Sub 取消订阅创意工坊物品(itemID As ULong)
        Dim PFT As New PublishedFileId_t With {.m_PublishedFileId = itemID}
        Dim result As EResult = SteamUGC.UnsubscribeItem(PFT)
        If result = EResult.k_EResultOK Then
            Form1.Text = Application.ProductName & " - " & 界面控制.多语言数据("Steamworks取消订阅成功").Replace("{0}", itemID)
        Else
            Form1.Text = Application.ProductName & " - " & 界面控制.多语言数据("Steamworks取消订阅失败").Replace("{0}", result.ToString())
        End If
    End Sub





End Class
