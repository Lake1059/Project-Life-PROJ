<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form主菜单
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
        UiButton1 = New Sunny.UI.UIButton()
        UiTabControlMenu1 = New Sunny.UI.UITabControlMenu()
        TabPage游戏 = New TabPage()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        UiRadioButton3 = New Sunny.UI.UIRadioButton()
        UiRadioButton2 = New Sunny.UI.UIRadioButton()
        UiRadioButton1 = New Sunny.UI.UIRadioButton()
        Label7 = New Label()
        UiTextBox2 = New Sunny.UI.UITextBox()
        Label6 = New Label()
        UiButton8 = New Sunny.UI.UIButton()
        Label2 = New Label()
        UiButton7 = New Sunny.UI.UIButton()
        UiButton6 = New Sunny.UI.UIButton()
        UiButton5 = New Sunny.UI.UIButton()
        Panel2 = New Panel()
        ListView2 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        Label3 = New Label()
        TabPage控制台 = New TabPage()
        UiRichTextBox1 = New Sunny.UI.UIRichTextBox()
        UiTextBox1 = New Sunny.UI.UITextBox()
        TabPage设置 = New TabPage()
        UiTabControlMenu2 = New Sunny.UI.UITabControlMenu()
        TabPage7 = New TabPage()
        UiComboBox2 = New Sunny.UI.UIComboBox()
        Label5 = New Label()
        UiComboBox1 = New Sunny.UI.UIComboBox()
        Label4 = New Label()
        TabPage8 = New TabPage()
        TabPage9 = New TabPage()
        TabPage模组 = New TabPage()
        TabPage修改器 = New TabPage()
        TabPage处理器 = New TabPage()
        TabPage教程 = New TabPage()
        TabPage关于 = New TabPage()
        Panel1 = New Panel()
        Label1 = New Label()
        UiTabControlMenu1.SuspendLayout()
        TabPage游戏.SuspendLayout()
        Panel2.SuspendLayout()
        TabPage控制台.SuspendLayout()
        TabPage设置.SuspendLayout()
        UiTabControlMenu2.SuspendLayout()
        TabPage7.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' UiButton1
        ' 
        UiButton1.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButton1.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillColorGradient = True
        UiButton1.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.FillPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton1.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.Font = New Font("Segoe UI", 12F)
        UiButton1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiButton1.ForeDisableColor = Color.Gray
        UiButton1.ForeHoverColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton1.ForePressColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton1.ForeSelectedColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton1.Location = New Point(30, 71)
        UiButton1.Margin = New Padding(30, 20, 0, 0)
        UiButton1.MinimumSize = New Size(1, 1)
        UiButton1.Name = "UiButton1"
        UiButton1.Radius = 10
        UiButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButton1.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.RectPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton1.RectSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.Size = New Size(150, 40)
        UiButton1.Style = Sunny.UI.UIStyle.Custom
        UiButton1.TabIndex = 64
        UiButton1.TabStop = False
        UiButton1.Text = "刷新列表"
        UiButton1.TipsColor = Color.Gray
        UiButton1.TipsFont = New Font("微软雅黑", 9F)
        ' 
        ' UiTabControlMenu1
        ' 
        UiTabControlMenu1.Alignment = TabAlignment.Left
        UiTabControlMenu1.Controls.Add(TabPage游戏)
        UiTabControlMenu1.Controls.Add(TabPage控制台)
        UiTabControlMenu1.Controls.Add(TabPage设置)
        UiTabControlMenu1.Controls.Add(TabPage模组)
        UiTabControlMenu1.Controls.Add(TabPage修改器)
        UiTabControlMenu1.Controls.Add(TabPage处理器)
        UiTabControlMenu1.Controls.Add(TabPage教程)
        UiTabControlMenu1.Controls.Add(TabPage关于)
        UiTabControlMenu1.Dock = DockStyle.Fill
        UiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed
        UiTabControlMenu1.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControlMenu1.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTabControlMenu1.ItemSize = New Size(200, 50)
        UiTabControlMenu1.Location = New Point(0, 50)
        UiTabControlMenu1.Multiline = True
        UiTabControlMenu1.Name = "UiTabControlMenu1"
        UiTabControlMenu1.SelectedIndex = 0
        UiTabControlMenu1.Size = New Size(1280, 670)
        UiTabControlMenu1.SizeMode = TabSizeMode.Fixed
        UiTabControlMenu1.TabIndex = 72
        UiTabControlMenu1.TextAlignment = HorizontalAlignment.Left
        ' 
        ' TabPage游戏
        ' 
        TabPage游戏.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage游戏.Controls.Add(Label10)
        TabPage游戏.Controls.Add(Label9)
        TabPage游戏.Controls.Add(Label8)
        TabPage游戏.Controls.Add(UiRadioButton3)
        TabPage游戏.Controls.Add(UiRadioButton2)
        TabPage游戏.Controls.Add(UiRadioButton1)
        TabPage游戏.Controls.Add(Label7)
        TabPage游戏.Controls.Add(UiTextBox2)
        TabPage游戏.Controls.Add(Label6)
        TabPage游戏.Controls.Add(UiButton8)
        TabPage游戏.Controls.Add(Label2)
        TabPage游戏.Controls.Add(UiButton7)
        TabPage游戏.Controls.Add(UiButton6)
        TabPage游戏.Controls.Add(UiButton5)
        TabPage游戏.Controls.Add(Panel2)
        TabPage游戏.Controls.Add(Label3)
        TabPage游戏.Controls.Add(UiButton1)
        TabPage游戏.Location = New Point(201, 0)
        TabPage游戏.Name = "TabPage游戏"
        TabPage游戏.Size = New Size(1079, 670)
        TabPage游戏.TabIndex = 0
        TabPage游戏.Text = "游戏"
        ' 
        ' Label10
        ' 
        Label10.ForeColor = Color.Gray
        Label10.Location = New Point(710, 547)
        Label10.Margin = New Padding(20, 10, 0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(339, 93)
        Label10.TabIndex = 90
        Label10.Text = "可获得特殊成就，仅限指定模组。高难警告，无法回档，角色死亡即删除，没有挽救的余地"
        ' 
        ' Label9
        ' 
        Label9.ForeColor = Color.Gray
        Label9.Location = New Point(710, 424)
        Label9.Margin = New Padding(20, 10, 0, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(339, 80)
        Label9.TabIndex = 89
        Label9.Text = "大量成就可用，官方剧本整体较容易，有足够的机会挽救损失，可以回档"
        ' 
        ' Label8
        ' 
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(710, 301)
        Label8.Margin = New Padding(20, 10, 0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(339, 80)
        Label8.TabIndex = 88
        Label8.Text = "启用修改器和作弊命令，新手推荐，部分成就可用。不会造成严重损失，剧本杀除外"
        ' 
        ' UiRadioButton3
        ' 
        UiRadioButton3.Font = New Font("微软雅黑", 12F)
        UiRadioButton3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiRadioButton3.Location = New Point(710, 514)
        UiRadioButton3.Margin = New Padding(20, 10, 0, 0)
        UiRadioButton3.MinimumSize = New Size(1, 1)
        UiRadioButton3.Name = "UiRadioButton3"
        UiRadioButton3.RadioButtonColor = Color.Maroon
        UiRadioButton3.RadioButtonSize = 20
        UiRadioButton3.Size = New Size(97, 23)
        UiRadioButton3.Style = Sunny.UI.UIStyle.Custom
        UiRadioButton3.TabIndex = 87
        UiRadioButton3.Text = "极限模式"
        ' 
        ' UiRadioButton2
        ' 
        UiRadioButton2.Font = New Font("微软雅黑", 12F)
        UiRadioButton2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiRadioButton2.Location = New Point(710, 391)
        UiRadioButton2.Margin = New Padding(20, 10, 0, 0)
        UiRadioButton2.MinimumSize = New Size(1, 1)
        UiRadioButton2.Name = "UiRadioButton2"
        UiRadioButton2.RadioButtonSize = 20
        UiRadioButton2.Size = New Size(97, 23)
        UiRadioButton2.Style = Sunny.UI.UIStyle.Custom
        UiRadioButton2.TabIndex = 86
        UiRadioButton2.Text = "生存模式"
        ' 
        ' UiRadioButton1
        ' 
        UiRadioButton1.Font = New Font("微软雅黑", 12F)
        UiRadioButton1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiRadioButton1.Location = New Point(710, 268)
        UiRadioButton1.Margin = New Padding(20, 20, 0, 0)
        UiRadioButton1.MinimumSize = New Size(1, 1)
        UiRadioButton1.Name = "UiRadioButton1"
        UiRadioButton1.RadioButtonColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        UiRadioButton1.RadioButtonSize = 20
        UiRadioButton1.Size = New Size(97, 23)
        UiRadioButton1.Style = Sunny.UI.UIStyle.Custom
        UiRadioButton1.TabIndex = 85
        UiRadioButton1.Text = "自由模式"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(710, 227)
        Label7.Margin = New Padding(20, 20, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 21)
        Label7.TabIndex = 84
        Label7.Text = "游戏模式"
        ' 
        ' UiTextBox2
        ' 
        UiTextBox2.ButtonSymbolOffset = New Point(0, 0)
        UiTextBox2.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBox2.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBox2.FillDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox2.FillReadOnlyColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox2.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiTextBox2.ForeDisableColor = Color.Gray
        UiTextBox2.ForeReadOnlyColor = Color.Gray
        UiTextBox2.Location = New Point(710, 172)
        UiTextBox2.Margin = New Padding(20, 20, 30, 0)
        UiTextBox2.MinimumSize = New Size(1, 16)
        UiTextBox2.Name = "UiTextBox2"
        UiTextBox2.Padding = New Padding(5)
        UiTextBox2.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiTextBox2.RectColor = Color.Gray
        UiTextBox2.RectDisableColor = Color.Gray
        UiTextBox2.RectReadOnlyColor = Color.Gray
        UiTextBox2.RectSides = ToolStripStatusLabelBorderSides.None
        UiTextBox2.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox2.ScrollBarColor = Color.Gray
        UiTextBox2.ScrollBarStyleInherited = False
        UiTextBox2.ShowText = False
        UiTextBox2.Size = New Size(339, 35)
        UiTextBox2.Style = Sunny.UI.UIStyle.Custom
        UiTextBox2.TabIndex = 83
        UiTextBox2.TabStop = False
        UiTextBox2.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox2.Watermark = ""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(710, 131)
        Label6.Margin = New Padding(20, 20, 0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(202, 21)
        Label6.TabIndex = 82
        Label6.Text = "新世界名称（存档文件夹）"
        ' 
        ' UiButton8
        ' 
        UiButton8.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButton8.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton8.FillColorGradient = True
        UiButton8.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton8.FillHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton8.FillPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton8.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton8.Font = New Font("Segoe UI", 12F)
        UiButton8.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiButton8.ForeDisableColor = Color.Gray
        UiButton8.ForeHoverColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton8.ForePressColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton8.ForeSelectedColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton8.Location = New Point(710, 71)
        UiButton8.Margin = New Padding(20, 20, 30, 0)
        UiButton8.MinimumSize = New Size(1, 1)
        UiButton8.Name = "UiButton8"
        UiButton8.Radius = 10
        UiButton8.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButton8.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton8.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton8.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton8.RectPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton8.RectSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton8.Size = New Size(339, 40)
        UiButton8.Style = Sunny.UI.UIStyle.Custom
        UiButton8.TabIndex = 81
        UiButton8.TabStop = False
        UiButton8.Text = "开始新游戏"
        UiButton8.TipsColor = Color.Gray
        UiButton8.TipsFont = New Font("微软雅黑", 9F)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(710, 30)
        Label2.Margin = New Padding(30, 30, 0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 21)
        Label2.TabIndex = 80
        Label2.Text = "新建存档选项"
        ' 
        ' UiButton7
        ' 
        UiButton7.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButton7.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton7.FillColorGradient = True
        UiButton7.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton7.FillHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton7.FillPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton7.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton7.Font = New Font("Segoe UI", 12F)
        UiButton7.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiButton7.ForeDisableColor = Color.Gray
        UiButton7.ForeHoverColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton7.ForePressColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton7.ForeSelectedColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton7.Location = New Point(540, 71)
        UiButton7.Margin = New Padding(20, 20, 0, 0)
        UiButton7.MinimumSize = New Size(1, 1)
        UiButton7.Name = "UiButton7"
        UiButton7.Radius = 10
        UiButton7.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButton7.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton7.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton7.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton7.RectPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton7.RectSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton7.Size = New Size(150, 40)
        UiButton7.Style = Sunny.UI.UIStyle.Custom
        UiButton7.TabIndex = 79
        UiButton7.TabStop = False
        UiButton7.Text = "删除选中"
        UiButton7.TipsColor = Color.Gray
        UiButton7.TipsFont = New Font("微软雅黑", 9F)
        ' 
        ' UiButton6
        ' 
        UiButton6.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButton6.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton6.FillColorGradient = True
        UiButton6.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton6.FillHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton6.FillPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton6.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton6.Font = New Font("Segoe UI", 12F)
        UiButton6.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiButton6.ForeDisableColor = Color.Gray
        UiButton6.ForeHoverColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton6.ForePressColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton6.ForeSelectedColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton6.Location = New Point(370, 71)
        UiButton6.Margin = New Padding(20, 20, 0, 0)
        UiButton6.MinimumSize = New Size(1, 1)
        UiButton6.Name = "UiButton6"
        UiButton6.Radius = 10
        UiButton6.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButton6.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton6.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton6.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton6.RectPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton6.RectSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton6.Size = New Size(150, 40)
        UiButton6.Style = Sunny.UI.UIStyle.Custom
        UiButton6.TabIndex = 78
        UiButton6.TabStop = False
        UiButton6.Text = "备份选中"
        UiButton6.TipsColor = Color.Gray
        UiButton6.TipsFont = New Font("微软雅黑", 9F)
        ' 
        ' UiButton5
        ' 
        UiButton5.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButton5.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton5.FillColorGradient = True
        UiButton5.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton5.FillHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton5.FillPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton5.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton5.Font = New Font("Segoe UI", 12F)
        UiButton5.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiButton5.ForeDisableColor = Color.Gray
        UiButton5.ForeHoverColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton5.ForePressColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton5.ForeSelectedColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton5.Location = New Point(200, 71)
        UiButton5.Margin = New Padding(20, 20, 0, 0)
        UiButton5.MinimumSize = New Size(1, 1)
        UiButton5.Name = "UiButton5"
        UiButton5.Radius = 10
        UiButton5.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiButton5.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton5.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton5.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton5.RectPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton5.RectSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton5.Size = New Size(150, 40)
        UiButton5.Style = Sunny.UI.UIStyle.Custom
        UiButton5.TabIndex = 77
        UiButton5.TabStop = False
        UiButton5.Text = "载入选中"
        UiButton5.TipsColor = Color.Gray
        UiButton5.TipsFont = New Font("微软雅黑", 9F)
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        Panel2.Controls.Add(ListView2)
        Panel2.Location = New Point(30, 131)
        Panel2.Margin = New Padding(30, 20, 0, 30)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(660, 509)
        Panel2.TabIndex = 76
        ' 
        ' ListView2
        ' 
        ListView2.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ListView2.BorderStyle = BorderStyle.None
        ListView2.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        ListView2.Dock = DockStyle.Fill
        ListView2.ForeColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ListView2.FullRowSelect = True
        ListView2.HeaderStyle = ColumnHeaderStyle.None
        ListView2.Location = New Point(10, 10)
        ListView2.Name = "ListView2"
        ListView2.OwnerDraw = True
        ListView2.ShowItemToolTips = True
        ListView2.Size = New Size(640, 489)
        ListView2.TabIndex = 2
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "世界名称"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "殖民地名称"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "模组数量"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "游戏内时间"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "文件夹大小"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 30)
        Label3.Margin = New Padding(30, 30, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 21)
        Label3.TabIndex = 75
        Label3.Text = "存档列表"
        ' 
        ' TabPage控制台
        ' 
        TabPage控制台.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage控制台.Controls.Add(UiRichTextBox1)
        TabPage控制台.Controls.Add(UiTextBox1)
        TabPage控制台.Location = New Point(201, 0)
        TabPage控制台.Name = "TabPage控制台"
        TabPage控制台.Size = New Size(1079, 670)
        TabPage控制台.TabIndex = 1
        TabPage控制台.Text = "控制台"
        ' 
        ' UiRichTextBox1
        ' 
        UiRichTextBox1.Dock = DockStyle.Fill
        UiRichTextBox1.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiRichTextBox1.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiRichTextBox1.FillDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiRichTextBox1.Font = New Font("微软雅黑", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiRichTextBox1.ForeColor = Color.Silver
        UiRichTextBox1.ForeDisableColor = Color.Silver
        UiRichTextBox1.Location = New Point(0, 0)
        UiRichTextBox1.Margin = New Padding(4, 5, 4, 5)
        UiRichTextBox1.MinimumSize = New Size(1, 1)
        UiRichTextBox1.Name = "UiRichTextBox1"
        UiRichTextBox1.Padding = New Padding(10, 10, 2, 10)
        UiRichTextBox1.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiRichTextBox1.RectSides = ToolStripStatusLabelBorderSides.None
        UiRichTextBox1.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiRichTextBox1.ScrollBarColor = Color.Gray
        UiRichTextBox1.ScrollBarStyleInherited = False
        UiRichTextBox1.ShowSelectionMargin = True
        UiRichTextBox1.ShowText = False
        UiRichTextBox1.Size = New Size(1079, 620)
        UiRichTextBox1.TabIndex = 2
        UiRichTextBox1.Text = "UiRichTextBox1"
        UiRichTextBox1.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' UiTextBox1
        ' 
        UiTextBox1.Dock = DockStyle.Bottom
        UiTextBox1.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBox1.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBox1.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBox1.FillReadOnlyColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBox1.Font = New Font("微软雅黑", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox1.ForeColor = Color.Silver
        UiTextBox1.ForeDisableColor = Color.Silver
        UiTextBox1.ForeReadOnlyColor = Color.Silver
        UiTextBox1.Location = New Point(0, 620)
        UiTextBox1.Margin = New Padding(4, 5, 4, 5)
        UiTextBox1.MinimumSize = New Size(1, 16)
        UiTextBox1.Name = "UiTextBox1"
        UiTextBox1.Padding = New Padding(5)
        UiTextBox1.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiTextBox1.RectSides = ToolStripStatusLabelBorderSides.Top
        UiTextBox1.ShowText = False
        UiTextBox1.Size = New Size(1079, 50)
        UiTextBox1.TabIndex = 3
        UiTextBox1.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox1.Watermark = "输入 help 来列出所有可用的命令"
        ' 
        ' TabPage设置
        ' 
        TabPage设置.AutoScroll = True
        TabPage设置.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage设置.Controls.Add(UiTabControlMenu2)
        TabPage设置.Location = New Point(201, 0)
        TabPage设置.Name = "TabPage设置"
        TabPage设置.Size = New Size(1079, 670)
        TabPage设置.TabIndex = 3
        TabPage设置.Text = "设置"
        ' 
        ' UiTabControlMenu2
        ' 
        UiTabControlMenu2.Alignment = TabAlignment.Left
        UiTabControlMenu2.Controls.Add(TabPage7)
        UiTabControlMenu2.Controls.Add(TabPage8)
        UiTabControlMenu2.Controls.Add(TabPage9)
        UiTabControlMenu2.Dock = DockStyle.Fill
        UiTabControlMenu2.DrawMode = TabDrawMode.OwnerDrawFixed
        UiTabControlMenu2.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControlMenu2.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTabControlMenu2.ItemSize = New Size(200, 50)
        UiTabControlMenu2.Location = New Point(0, 0)
        UiTabControlMenu2.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        UiTabControlMenu2.Multiline = True
        UiTabControlMenu2.Name = "UiTabControlMenu2"
        UiTabControlMenu2.SelectedIndex = 0
        UiTabControlMenu2.Size = New Size(1079, 670)
        UiTabControlMenu2.SizeMode = TabSizeMode.Fixed
        UiTabControlMenu2.TabBackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTabControlMenu2.TabIndex = 29
        UiTabControlMenu2.TextAlignment = HorizontalAlignment.Left
        ' 
        ' TabPage7
        ' 
        TabPage7.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage7.Controls.Add(UiComboBox2)
        TabPage7.Controls.Add(Label5)
        TabPage7.Controls.Add(UiComboBox1)
        TabPage7.Controls.Add(Label4)
        TabPage7.Location = New Point(201, 0)
        TabPage7.Name = "TabPage7"
        TabPage7.Size = New Size(878, 670)
        TabPage7.TabIndex = 0
        TabPage7.Text = "显示"
        ' 
        ' UiComboBox2
        ' 
        UiComboBox2.DataSource = Nothing
        UiComboBox2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBox2.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox2.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox2.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox2.Font = New Font("微软雅黑", 9.75F)
        UiComboBox2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiComboBox2.ForeDisableColor = Color.Gray
        UiComboBox2.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox2.ItemForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiComboBox2.ItemHeight = 30
        UiComboBox2.ItemHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBox2.ItemRectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox2.Items.AddRange(New Object() {"Default"})
        UiComboBox2.ItemSelectBackColor = Color.DimGray
        UiComboBox2.ItemSelectForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiComboBox2.Location = New Point(30, 172)
        UiComboBox2.Margin = New Padding(30, 20, 0, 0)
        UiComboBox2.MaxDropDownItems = 10
        UiComboBox2.MinimumSize = New Size(63, 0)
        UiComboBox2.Name = "UiComboBox2"
        UiComboBox2.Padding = New Padding(0, 0, 30, 2)
        UiComboBox2.Radius = 0
        UiComboBox2.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBox2.RectColor = Color.Silver
        UiComboBox2.RectDisableColor = Color.Silver
        UiComboBox2.RectSides = ToolStripStatusLabelBorderSides.None
        UiComboBox2.Size = New Size(300, 30)
        UiComboBox2.Style = Sunny.UI.UIStyle.Custom
        UiComboBox2.SymbolSize = 24
        UiComboBox2.TabIndex = 26
        UiComboBox2.TabStop = False
        UiComboBox2.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBox2.TrimFilter = True
        UiComboBox2.Watermark = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 131)
        Label5.Margin = New Padding(30, 30, 30, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 21)
        Label5.TabIndex = 25
        Label5.Text = "字体"
        ' 
        ' UiComboBox1
        ' 
        UiComboBox1.DataSource = Nothing
        UiComboBox1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBox1.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox1.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox1.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox1.Font = New Font("微软雅黑", 9.75F)
        UiComboBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiComboBox1.ForeDisableColor = Color.Gray
        UiComboBox1.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox1.ItemForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiComboBox1.ItemHeight = 30
        UiComboBox1.ItemHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBox1.ItemRectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox1.Items.AddRange(New Object() {"Default"})
        UiComboBox1.ItemSelectBackColor = Color.DimGray
        UiComboBox1.ItemSelectForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiComboBox1.Location = New Point(30, 71)
        UiComboBox1.Margin = New Padding(30, 20, 0, 0)
        UiComboBox1.MaxDropDownItems = 10
        UiComboBox1.MinimumSize = New Size(63, 0)
        UiComboBox1.Name = "UiComboBox1"
        UiComboBox1.Padding = New Padding(0, 0, 30, 2)
        UiComboBox1.Radius = 0
        UiComboBox1.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiComboBox1.RectColor = Color.Silver
        UiComboBox1.RectDisableColor = Color.Silver
        UiComboBox1.RectSides = ToolStripStatusLabelBorderSides.None
        UiComboBox1.Size = New Size(300, 30)
        UiComboBox1.Style = Sunny.UI.UIStyle.Custom
        UiComboBox1.SymbolSize = 24
        UiComboBox1.TabIndex = 24
        UiComboBox1.TabStop = False
        UiComboBox1.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBox1.TrimFilter = True
        UiComboBox1.Watermark = ""
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 30)
        Label4.Margin = New Padding(30, 30, 30, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 21)
        Label4.TabIndex = 0
        Label4.Text = "语言"
        ' 
        ' TabPage8
        ' 
        TabPage8.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage8.Location = New Point(201, 0)
        TabPage8.Name = "TabPage8"
        TabPage8.Size = New Size(878, 670)
        TabPage8.TabIndex = 1
        TabPage8.Text = "性能"
        ' 
        ' TabPage9
        ' 
        TabPage9.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage9.Location = New Point(201, 0)
        TabPage9.Name = "TabPage9"
        TabPage9.Size = New Size(878, 670)
        TabPage9.TabIndex = 2
        TabPage9.Text = "媒体"
        ' 
        ' TabPage模组
        ' 
        TabPage模组.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage模组.Location = New Point(201, 0)
        TabPage模组.Name = "TabPage模组"
        TabPage模组.Size = New Size(1079, 670)
        TabPage模组.TabIndex = 4
        TabPage模组.Text = "模组"
        ' 
        ' TabPage修改器
        ' 
        TabPage修改器.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage修改器.Location = New Point(201, 0)
        TabPage修改器.Name = "TabPage修改器"
        TabPage修改器.Size = New Size(1079, 670)
        TabPage修改器.TabIndex = 2
        TabPage修改器.Text = "修改器"
        ' 
        ' TabPage处理器
        ' 
        TabPage处理器.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage处理器.Location = New Point(201, 0)
        TabPage处理器.Name = "TabPage处理器"
        TabPage处理器.Size = New Size(1079, 670)
        TabPage处理器.TabIndex = 7
        TabPage处理器.Text = "处理器"
        ' 
        ' TabPage教程
        ' 
        TabPage教程.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage教程.Location = New Point(201, 0)
        TabPage教程.Name = "TabPage教程"
        TabPage教程.Size = New Size(1079, 670)
        TabPage教程.TabIndex = 5
        TabPage教程.Text = "教程"
        ' 
        ' TabPage关于
        ' 
        TabPage关于.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage关于.Location = New Point(201, 0)
        TabPage关于.Name = "TabPage关于"
        TabPage关于.Size = New Size(1079, 670)
        TabPage关于.TabIndex = 6
        TabPage关于.Text = "关于"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1280, 50)
        Panel1.TabIndex = 73
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(15, 0, 0, 0)
        Label1.Size = New Size(1280, 50)
        Label1.TabIndex = 0
        Label1.Text = "PROJECT LIFE GAME"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form主菜单
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(1280, 720)
        Controls.Add(UiTabControlMenu1)
        Controls.Add(Panel1)
        Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MinimumSize = New Size(1296, 759)
        Name = "Form主菜单"
        StartPosition = FormStartPosition.CenterScreen
        Text = "主菜单"
        UiTabControlMenu1.ResumeLayout(False)
        TabPage游戏.ResumeLayout(False)
        TabPage游戏.PerformLayout()
        Panel2.ResumeLayout(False)
        TabPage控制台.ResumeLayout(False)
        TabPage设置.ResumeLayout(False)
        UiTabControlMenu2.ResumeLayout(False)
        TabPage7.ResumeLayout(False)
        TabPage7.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents UiButton1 As Sunny.UI.UIButton
    Friend WithEvents UiButton5 As Sunny.UI.UIButton
    Friend WithEvents UiTabControlMenu1 As Sunny.UI.UITabControlMenu
    Friend WithEvents TabPage游戏 As TabPage
    Friend WithEvents TabPage控制台 As TabPage
    Friend WithEvents TabPage修改器 As TabPage
    Friend WithEvents TabPage设置 As TabPage
    Friend WithEvents TabPage模组 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage教程 As TabPage
    Friend WithEvents UiRichTextBox1 As Sunny.UI.UIRichTextBox
    Friend WithEvents UiTextBox1 As Sunny.UI.UITextBox
    Friend WithEvents UiTabControlMenu2 As Sunny.UI.UITabControlMenu
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents UiComboBox2 As Sunny.UI.UIComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents UiComboBox1 As Sunny.UI.UIComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage关于 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage处理器 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents UiButton8 As Sunny.UI.UIButton
    Friend WithEvents Label2 As Label
    Friend WithEvents UiButton7 As Sunny.UI.UIButton
    Friend WithEvents UiButton6 As Sunny.UI.UIButton
    Friend WithEvents Label6 As Label
    Friend WithEvents UiTextBox2 As Sunny.UI.UITextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents UiRadioButton3 As Sunny.UI.UIRadioButton
    Friend WithEvents UiRadioButton2 As Sunny.UI.UIRadioButton
    Friend WithEvents UiRadioButton1 As Sunny.UI.UIRadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label

End Class
