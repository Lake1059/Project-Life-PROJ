<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form控制台
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        UiTabControl1 = New Sunny.UI.UITabControl()
        TabPage1 = New TabPage()
        UiRichTextBox1 = New Sunny.UI.UIRichTextBox()
        UiTextBox1 = New Sunny.UI.UITextBox()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        UiTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' UiTabControl1
        ' 
        UiTabControl1.Controls.Add(TabPage1)
        UiTabControl1.Controls.Add(TabPage2)
        UiTabControl1.Controls.Add(TabPage3)
        UiTabControl1.Dock = DockStyle.Fill
        UiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        UiTabControl1.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControl1.Font = New Font("微软雅黑", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTabControl1.ItemSize = New Size(150, 40)
        UiTabControl1.Location = New Point(0, 0)
        UiTabControl1.MainPage = ""
        UiTabControl1.Name = "UiTabControl1"
        UiTabControl1.Padding = New Point(0, 0)
        UiTabControl1.SelectedIndex = 0
        UiTabControl1.Size = New Size(1280, 720)
        UiTabControl1.SizeMode = TabSizeMode.Fixed
        UiTabControl1.TabIndex = 0
        UiTabControl1.TabUnSelectedForeColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        UiTabControl1.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage1.Controls.Add(UiRichTextBox1)
        TabPage1.Controls.Add(UiTextBox1)
        TabPage1.Location = New Point(0, 40)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(1280, 680)
        TabPage1.TabIndex = 0
        TabPage1.Text = "输出"
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
        UiRichTextBox1.Size = New Size(1280, 630)
        UiRichTextBox1.TabIndex = 0
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
        UiTextBox1.Location = New Point(0, 630)
        UiTextBox1.Margin = New Padding(4, 5, 4, 5)
        UiTextBox1.MinimumSize = New Size(1, 16)
        UiTextBox1.Name = "UiTextBox1"
        UiTextBox1.Padding = New Padding(5)
        UiTextBox1.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiTextBox1.RectSides = ToolStripStatusLabelBorderSides.Top
        UiTextBox1.ShowText = False
        UiTextBox1.Size = New Size(1280, 50)
        UiTextBox1.TabIndex = 1
        UiTextBox1.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox1.Watermark = "输入 help 来列出所有可用的命令"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage2.Location = New Point(0, 40)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(200, 60)
        TabPage2.TabIndex = 1
        TabPage2.Text = "性能"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage3.Location = New Point(0, 40)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(200, 60)
        TabPage3.TabIndex = 2
        TabPage3.Text = "修改器"
        ' 
        ' Form控制台
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(1280, 720)
        Controls.Add(UiTabControl1)
        Font = New Font("微软雅黑", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MinimumSize = New Size(500, 500)
        Name = "Form控制台"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "控制台"
        UiTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents UiTabControl1 As Sunny.UI.UITabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents UiTextBox1 As Sunny.UI.UITextBox
    Friend WithEvents UiRichTextBox1 As Sunny.UI.UIRichTextBox
End Class
