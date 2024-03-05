<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form选择标签
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form选择标签))
        UiCheckBoxGroup1 = New Sunny.UI.UICheckBoxGroup()
        SuspendLayout()
        ' 
        ' UiCheckBoxGroup1
        ' 
        UiCheckBoxGroup1.ColumnCount = 2
        UiCheckBoxGroup1.Dock = DockStyle.Fill
        UiCheckBoxGroup1.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiCheckBoxGroup1.FillColor2 = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiCheckBoxGroup1.FillDisableColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiCheckBoxGroup1.Font = New Font("微软雅黑", 9.75F)
        UiCheckBoxGroup1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UiCheckBoxGroup1.HoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiCheckBoxGroup1.Items.AddRange(New Object() {"Map", "Event", "Colony", "Building", "Item", "Character", "Vehicle", "NPC", "Crop", "Animal", "Fish", "Recipe", "Excavate", "Shop", "Enemy", "Image", "Audio", "Video"})
        UiCheckBoxGroup1.ItemSize = New Size(200, 30)
        UiCheckBoxGroup1.Location = New Point(10, 10)
        UiCheckBoxGroup1.Margin = New Padding(4, 5, 4, 5)
        UiCheckBoxGroup1.MinimumSize = New Size(1, 1)
        UiCheckBoxGroup1.Name = "UiCheckBoxGroup1"
        UiCheckBoxGroup1.Padding = New Padding(0, 32, 0, 0)
        UiCheckBoxGroup1.RadiusSides = Sunny.UI.UICornerRadiusSides.None
        UiCheckBoxGroup1.RectSides = ToolStripStatusLabelBorderSides.None
        UiCheckBoxGroup1.SelectedIndexes = CType(resources.GetObject("UiCheckBoxGroup1.SelectedIndexes"), List(Of Integer))
        UiCheckBoxGroup1.Size = New Size(464, 341)
        UiCheckBoxGroup1.StartPos = New Point(0, 0)
        UiCheckBoxGroup1.Style = Sunny.UI.UIStyle.Custom
        UiCheckBoxGroup1.TabIndex = 36
        UiCheckBoxGroup1.TabStop = False
        UiCheckBoxGroup1.Text = Nothing
        UiCheckBoxGroup1.TextAlignment = ContentAlignment.MiddleCenter
        UiCheckBoxGroup1.TitleInterval = 0
        UiCheckBoxGroup1.TitleTop = 0
        ' 
        ' Form选择标签
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ClientSize = New Size(484, 361)
        Controls.Add(UiCheckBoxGroup1)
        Font = New Font("微软雅黑", 9.75F)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(500, 400)
        Name = "Form选择标签"
        Padding = New Padding(10)
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        Text = "选择标签"
        ResumeLayout(False)
    End Sub

    Friend WithEvents UiCheckBoxGroup1 As Sunny.UI.UICheckBoxGroup
End Class
