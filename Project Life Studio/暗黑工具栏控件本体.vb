Public Class 暗黑工具栏控件本体
    Inherits ToolStrip

    Public Sub New()
        MyBase.New
        Renderer = New 暗黑工具栏绘制类
        BackColor = ColorTranslator.FromWin32(RGB(48, 48, 48))
        ForeColor = ColorTranslator.FromWin32(RGB(224, 224, 224))
    End Sub



End Class
