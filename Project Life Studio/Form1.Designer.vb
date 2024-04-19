<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        UiTabControl1 = New Sunny.UI.UITabControl()
        暗黑菜单栏控件本体 = New 暗黑菜单栏控件本体()
        模组工程ToolStripMenuItem = New ToolStripMenuItem()
        新建模组项目ToolStripMenuItem = New ToolStripMenuItem()
        加载现有模组ToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        保存ToolStripMenuItem = New ToolStripMenuItem()
        另存为ToolStripMenuItem = New ToolStripMenuItem()
        创意工坊ToolStripMenuItem = New ToolStripMenuItem()
        创建新物品并上传ToolStripMenuItem = New ToolStripMenuItem()
        对已有物品上传更新ToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        查看创意工坊物品页面ToolStripMenuItem = New ToolStripMenuItem()
        订阅此物品ToolStripMenuItem = New ToolStripMenuItem()
        取消订阅此物品ToolStripMenuItem = New ToolStripMenuItem()
        清单数据ToolStripMenuItem = New ToolStripMenuItem()
        编辑清单基本数据ToolStripMenuItem = New ToolStripMenuItem()
        编辑清单依赖项数据ToolStripMenuItem = New ToolStripMenuItem()
        功能数据ToolStripMenuItem = New ToolStripMenuItem()
        游戏脚本ToolStripMenuItem = New ToolStripMenuItem()
        媒体资源ToolStripMenuItem = New ToolStripMenuItem()
        程序插件ToolStripMenuItem = New ToolStripMenuItem()
        编辑器语言ToolStripMenuItem = New ToolStripMenuItem()
        暗黑菜单栏控件本体.SuspendLayout()
        SuspendLayout()
        ' 
        ' UiTabControl1
        ' 
        UiTabControl1.Dock = DockStyle.Fill
        UiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        UiTabControl1.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControl1.Font = New Font("微软雅黑", 9.75F)
        UiTabControl1.ItemSize = New Size(150, 40)
        UiTabControl1.Location = New Point(0, 40)
        UiTabControl1.MainPage = ""
        UiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        UiTabControl1.Name = "UiTabControl1"
        UiTabControl1.Padding = New Point(0, 0)
        UiTabControl1.SelectedIndex = 0
        UiTabControl1.ShowCloseButton = True
        UiTabControl1.Size = New Size(1280, 680)
        UiTabControl1.SizeMode = TabSizeMode.Fixed
        UiTabControl1.TabBackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTabControl1.TabIndex = 0
        UiTabControl1.TabUnSelectedForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        UiTabControl1.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' 暗黑菜单栏控件本体
        ' 
        暗黑菜单栏控件本体.AutoSize = False
        暗黑菜单栏控件本体.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        暗黑菜单栏控件本体.Font = New Font("微软雅黑", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        暗黑菜单栏控件本体.ForeColor = Color.Gainsboro
        暗黑菜单栏控件本体.GripMargin = New Padding(0)
        暗黑菜单栏控件本体.ImageScalingSize = New Size(29, 29)
        暗黑菜单栏控件本体.Items.AddRange(New ToolStripItem() {模组工程ToolStripMenuItem, 创意工坊ToolStripMenuItem, 清单数据ToolStripMenuItem, 功能数据ToolStripMenuItem, 游戏脚本ToolStripMenuItem, 媒体资源ToolStripMenuItem, 程序插件ToolStripMenuItem, 编辑器语言ToolStripMenuItem})
        暗黑菜单栏控件本体.Location = New Point(0, 0)
        暗黑菜单栏控件本体.Name = "暗黑菜单栏控件本体"
        暗黑菜单栏控件本体.Padding = New Padding(0, 1, 1, 1)
        暗黑菜单栏控件本体.Size = New Size(1280, 40)
        暗黑菜单栏控件本体.TabIndex = 1
        暗黑菜单栏控件本体.Text = "暗黑菜单栏控件本体1"
        ' 
        ' 模组工程ToolStripMenuItem
        ' 
        模组工程ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        模组工程ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {新建模组项目ToolStripMenuItem, 加载现有模组ToolStripMenuItem, ToolStripSeparator1, 保存ToolStripMenuItem, 另存为ToolStripMenuItem})
        模组工程ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        模组工程ToolStripMenuItem.Name = "模组工程ToolStripMenuItem"
        模组工程ToolStripMenuItem.Padding = New Padding(10, 0, 10, 0)
        模组工程ToolStripMenuItem.Size = New Size(85, 38)
        模组工程ToolStripMenuItem.Text = "模组工程"
        ' 
        ' 新建模组项目ToolStripMenuItem
        ' 
        新建模组项目ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        新建模组项目ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        新建模组项目ToolStripMenuItem.Image = My.Resources.Resources.添加带圆圈
        新建模组项目ToolStripMenuItem.Name = "新建模组项目ToolStripMenuItem"
        新建模组项目ToolStripMenuItem.Size = New Size(193, 36)
        新建模组项目ToolStripMenuItem.Text = "新建模组项目"
        ' 
        ' 加载现有模组ToolStripMenuItem
        ' 
        加载现有模组ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        加载现有模组ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        加载现有模组ToolStripMenuItem.Image = My.Resources.Resources.代码文件夹
        加载现有模组ToolStripMenuItem.Name = "加载现有模组ToolStripMenuItem"
        加载现有模组ToolStripMenuItem.Size = New Size(193, 36)
        加载现有模组ToolStripMenuItem.Text = "加载现有模组"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        ToolStripSeparator1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ToolStripSeparator1.Margin = New Padding(5)
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(190, 6)
        ' 
        ' 保存ToolStripMenuItem
        ' 
        保存ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        保存ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        保存ToolStripMenuItem.Image = My.Resources.Resources.保存
        保存ToolStripMenuItem.Name = "保存ToolStripMenuItem"
        保存ToolStripMenuItem.Size = New Size(193, 36)
        保存ToolStripMenuItem.Text = "保存"
        ' 
        ' 另存为ToolStripMenuItem
        ' 
        另存为ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        另存为ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        另存为ToolStripMenuItem.Image = My.Resources.Resources.下载文件夹
        另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem"
        另存为ToolStripMenuItem.Size = New Size(193, 36)
        另存为ToolStripMenuItem.Text = "另存为"
        ' 
        ' 创意工坊ToolStripMenuItem
        ' 
        创意工坊ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        创意工坊ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {创建新物品并上传ToolStripMenuItem, 对已有物品上传更新ToolStripMenuItem, ToolStripSeparator2, 查看创意工坊物品页面ToolStripMenuItem, 订阅此物品ToolStripMenuItem, 取消订阅此物品ToolStripMenuItem})
        创意工坊ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        创意工坊ToolStripMenuItem.Name = "创意工坊ToolStripMenuItem"
        创意工坊ToolStripMenuItem.Padding = New Padding(10, 0, 10, 0)
        创意工坊ToolStripMenuItem.Size = New Size(85, 38)
        创意工坊ToolStripMenuItem.Text = "创意工坊"
        ' 
        ' 创建新物品并上传ToolStripMenuItem
        ' 
        创建新物品并上传ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        创建新物品并上传ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        创建新物品并上传ToolStripMenuItem.Image = My.Resources.Resources.上传云
        创建新物品并上传ToolStripMenuItem.Name = "创建新物品并上传ToolStripMenuItem"
        创建新物品并上传ToolStripMenuItem.Size = New Size(221, 36)
        创建新物品并上传ToolStripMenuItem.Text = "创建新物品并上传"
        ' 
        ' 对已有物品上传更新ToolStripMenuItem
        ' 
        对已有物品上传更新ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        对已有物品上传更新ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        对已有物品上传更新ToolStripMenuItem.Image = My.Resources.Resources.上传云
        对已有物品上传更新ToolStripMenuItem.Name = "对已有物品上传更新ToolStripMenuItem"
        对已有物品上传更新ToolStripMenuItem.Size = New Size(221, 36)
        对已有物品上传更新ToolStripMenuItem.Text = "对已有物品上传更新"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        ToolStripSeparator2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ToolStripSeparator2.Margin = New Padding(5)
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(218, 6)
        ' 
        ' 查看创意工坊物品页面ToolStripMenuItem
        ' 
        查看创意工坊物品页面ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        查看创意工坊物品页面ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        查看创意工坊物品页面ToolStripMenuItem.Name = "查看创意工坊物品页面ToolStripMenuItem"
        查看创意工坊物品页面ToolStripMenuItem.Size = New Size(221, 36)
        查看创意工坊物品页面ToolStripMenuItem.Text = "查看创意工坊物品页面"
        ' 
        ' 订阅此物品ToolStripMenuItem
        ' 
        订阅此物品ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        订阅此物品ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        订阅此物品ToolStripMenuItem.Name = "订阅此物品ToolStripMenuItem"
        订阅此物品ToolStripMenuItem.Size = New Size(221, 36)
        订阅此物品ToolStripMenuItem.Text = "订阅此物品"
        ' 
        ' 取消订阅此物品ToolStripMenuItem
        ' 
        取消订阅此物品ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        取消订阅此物品ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        取消订阅此物品ToolStripMenuItem.Name = "取消订阅此物品ToolStripMenuItem"
        取消订阅此物品ToolStripMenuItem.Size = New Size(221, 36)
        取消订阅此物品ToolStripMenuItem.Text = "取消订阅此物品"
        ' 
        ' 清单数据ToolStripMenuItem
        ' 
        清单数据ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        清单数据ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {编辑清单基本数据ToolStripMenuItem, 编辑清单依赖项数据ToolStripMenuItem})
        清单数据ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        清单数据ToolStripMenuItem.Name = "清单数据ToolStripMenuItem"
        清单数据ToolStripMenuItem.Padding = New Padding(10, 0, 10, 0)
        清单数据ToolStripMenuItem.Size = New Size(85, 38)
        清单数据ToolStripMenuItem.Text = "清单数据"
        ' 
        ' 编辑清单基本数据ToolStripMenuItem
        ' 
        编辑清单基本数据ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        编辑清单基本数据ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        编辑清单基本数据ToolStripMenuItem.Image = My.Resources.Resources.试验
        编辑清单基本数据ToolStripMenuItem.Name = "编辑清单基本数据ToolStripMenuItem"
        编辑清单基本数据ToolStripMenuItem.Size = New Size(208, 36)
        编辑清单基本数据ToolStripMenuItem.Text = "编辑清单基本数据"
        ' 
        ' 编辑清单依赖项数据ToolStripMenuItem
        ' 
        编辑清单依赖项数据ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        编辑清单依赖项数据ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        编辑清单依赖项数据ToolStripMenuItem.Image = My.Resources.Resources.试验
        编辑清单依赖项数据ToolStripMenuItem.Name = "编辑清单依赖项数据ToolStripMenuItem"
        编辑清单依赖项数据ToolStripMenuItem.Size = New Size(208, 36)
        编辑清单依赖项数据ToolStripMenuItem.Text = "编辑清单依赖项数据"
        ' 
        ' 功能数据ToolStripMenuItem
        ' 
        功能数据ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        功能数据ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        功能数据ToolStripMenuItem.Name = "功能数据ToolStripMenuItem"
        功能数据ToolStripMenuItem.Padding = New Padding(10, 0, 10, 0)
        功能数据ToolStripMenuItem.Size = New Size(85, 38)
        功能数据ToolStripMenuItem.Text = "功能数据"
        ' 
        ' 游戏脚本ToolStripMenuItem
        ' 
        游戏脚本ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        游戏脚本ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        游戏脚本ToolStripMenuItem.Name = "游戏脚本ToolStripMenuItem"
        游戏脚本ToolStripMenuItem.Padding = New Padding(10, 0, 10, 0)
        游戏脚本ToolStripMenuItem.Size = New Size(85, 38)
        游戏脚本ToolStripMenuItem.Text = "游戏脚本"
        ' 
        ' 媒体资源ToolStripMenuItem
        ' 
        媒体资源ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        媒体资源ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        媒体资源ToolStripMenuItem.Name = "媒体资源ToolStripMenuItem"
        媒体资源ToolStripMenuItem.Padding = New Padding(10, 0, 10, 0)
        媒体资源ToolStripMenuItem.Size = New Size(85, 38)
        媒体资源ToolStripMenuItem.Text = "媒体资源"
        ' 
        ' 程序插件ToolStripMenuItem
        ' 
        程序插件ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        程序插件ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        程序插件ToolStripMenuItem.Name = "程序插件ToolStripMenuItem"
        程序插件ToolStripMenuItem.Padding = New Padding(10, 0, 10, 0)
        程序插件ToolStripMenuItem.Size = New Size(85, 38)
        程序插件ToolStripMenuItem.Text = "程序插件"
        ' 
        ' 编辑器语言ToolStripMenuItem
        ' 
        编辑器语言ToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
        编辑器语言ToolStripMenuItem.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        编辑器语言ToolStripMenuItem.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        编辑器语言ToolStripMenuItem.Name = "编辑器语言ToolStripMenuItem"
        编辑器语言ToolStripMenuItem.Padding = New Padding(10, 0, 10, 0)
        编辑器语言ToolStripMenuItem.Size = New Size(98, 38)
        编辑器语言ToolStripMenuItem.Text = "编辑器语言"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(1280, 720)
        Controls.Add(UiTabControl1)
        Controls.Add(暗黑菜单栏控件本体)
        Font = New Font("微软雅黑", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MainMenuStrip = 暗黑菜单栏控件本体
        MinimumSize = New Size(1296, 759)
        Name = "Form1"
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "Project Life Studio"
        暗黑菜单栏控件本体.ResumeLayout(False)
        暗黑菜单栏控件本体.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents UiTabControl1 As Sunny.UI.UITabControl
    Friend WithEvents 暗黑菜单栏控件本体 As 暗黑菜单栏控件本体
    Friend WithEvents 模组工程ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 创意工坊ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 功能数据ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 游戏脚本ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 媒体资源ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 程序插件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 清单数据ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 编辑器语言ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新建模组项目ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 加载现有模组ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 保存ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 另存为ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 创建新物品并上传ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 对已有物品上传更新ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 查看创意工坊物品页面ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 订阅此物品ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 取消订阅此物品ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 编辑清单基本数据ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 编辑清单依赖项数据ToolStripMenuItem As ToolStripMenuItem

End Class
