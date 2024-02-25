Imports Sunny.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 功能显示名称
    Inherits UIPage

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
        Label1 = New Label()
        UiTextBox7 = New UITextBox()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        Panel1 = New Panel()
        UiButton1 = New UIButton()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("微软雅黑", 12F)
        Label1.Location = New Point(20, 20)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 21)
        Label1.TabIndex = 2
        Label1.Text = "设置这些功能在游戏内的显示名称"
        ' 
        ' UiTextBox7
        ' 
        UiTextBox7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        UiTextBox7.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTextBox7.ButtonSymbolOffset = New Point(0, 0)
        UiTextBox7.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.Font = New Font("微软雅黑", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox7.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiTextBox7.ForeDisableColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiTextBox7.ForeReadOnlyColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiTextBox7.Location = New Point(659, 116)
        UiTextBox7.Margin = New Padding(20, 0, 0, 0)
        UiTextBox7.MinimumSize = New Size(1, 16)
        UiTextBox7.Multiline = True
        UiTextBox7.Name = "UiTextBox7"
        UiTextBox7.RadiusSides = UICornerRadiusSides.None
        UiTextBox7.RectColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.RectDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.RectReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.RectSides = ToolStripStatusLabelBorderSides.None
        UiTextBox7.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox7.ScrollBarColor = Color.Gray
        UiTextBox7.ScrollBarStyleInherited = False
        UiTextBox7.ShowScrollBar = True
        UiTextBox7.ShowText = False
        UiTextBox7.Size = New Size(400, 544)
        UiTextBox7.Style = UIStyle.Custom
        UiTextBox7.TabIndex = 63
        UiTextBox7.TabStop = False
        UiTextBox7.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox7.Watermark = ""
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        ListView1.Dock = DockStyle.Fill
        ListView1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.Location = New Point(10, 10)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(599, 579)
        ListView1.TabIndex = 64
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Width = 300
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel1.Controls.Add(ListView1)
        Panel1.Location = New Point(20, 61)
        Panel1.Margin = New Padding(0, 20, 0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(619, 599)
        Panel1.TabIndex = 65
        ' 
        ' UiButton1
        ' 
        UiButton1.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.FillPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton1.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.Font = New Font("微软雅黑", 9.75F)
        UiButton1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiButton1.ForeDisableColor = Color.Gray
        UiButton1.ForeHoverColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton1.ForePressColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton1.ForeSelectedColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        UiButton1.Location = New Point(659, 61)
        UiButton1.Margin = New Padding(20, 20, 0, 20)
        UiButton1.MinimumSize = New Size(1, 1)
        UiButton1.Name = "UiButton1"
        UiButton1.Radius = 10
        UiButton1.RadiusSides = UICornerRadiusSides.None
        UiButton1.RectColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.RectPressColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiButton1.RectSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.Size = New Size(150, 35)
        UiButton1.Style = UIStyle.Custom
        UiButton1.TabIndex = 66
        UiButton1.TabStop = False
        UiButton1.Text = "确认"
        UiButton1.TipsColor = Color.Gray
        UiButton1.TipsFont = New Font("微软雅黑", 9F)
        ' 
        ' 功能显示名称
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(1079, 680)
        Controls.Add(UiButton1)
        Controls.Add(Panel1)
        Controls.Add(UiTextBox7)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MinimumSize = New Size(1079, 680)
        Name = "功能显示名称"
        Padding = New Padding(20)
        Text = "功能显示名称"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UiTextBox7 As UITextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UiButton1 As UIButton
End Class
