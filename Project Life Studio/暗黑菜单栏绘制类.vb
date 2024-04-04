Public Class 暗黑菜单栏绘制类
    Inherits ToolStripRenderer

    Protected Overrides Sub Initialize(toolStrip As ToolStrip)
        MyBase.Initialize(toolStrip)
        toolStrip.BackColor = ColorTranslator.FromWin32(RGB(48, 48, 48))
        toolStrip.ForeColor = ColorTranslator.FromWin32(RGB(224, 224, 224))
    End Sub

    Protected Overrides Sub InitializeItem(item As ToolStripItem)
        MyBase.InitializeItem(item)

        item.BackColor = ColorTranslator.FromWin32(RGB(48, 48, 48))
        item.ForeColor = ColorTranslator.FromWin32(RGB(224, 224, 224))

        If item.GetType() Is GetType(ToolStripSeparator) Then
            item.Margin = New Padding(5)
        End If
    End Sub

    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
        Dim g = e.Graphics
        Using b = New SolidBrush(ColorTranslator.FromWin32(RGB(48, 48, 48)))
            g.FillRectangle(b, e.AffectedBounds)
        End Using
    End Sub

    Protected Overrides Sub OnRenderImageMargin(e As ToolStripRenderEventArgs)
        Dim g = e.Graphics

        Dim rect = New Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1)

        Using p = New Pen(ColorTranslator.FromWin32(RGB(48, 48, 48)))
            g.DrawRectangle(p, rect)
        End Using
    End Sub

    Protected Overrides Sub OnRenderItemCheck(e As ToolStripItemImageRenderEventArgs)
        Dim g = e.Graphics

        Dim rect = New Rectangle(e.ImageRectangle.Left - 2, e.ImageRectangle.Top - 2,
                                     e.ImageRectangle.Width + 4, e.ImageRectangle.Height + 4)

        Using b = New SolidBrush(ColorTranslator.FromWin32(RGB(80, 80, 80)))
            g.FillRectangle(b, rect)
        End Using

        Using p = New Pen(ColorTranslator.FromWin32(RGB(80, 80, 80)))
            Dim modRect = New Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1)
            g.DrawRectangle(p, modRect)
        End Using

        If e.Item.ImageIndex = -1 AndAlso String.IsNullOrEmpty(e.Item.ImageKey) AndAlso e.Item.Image Is Nothing Then
            g.DrawImageUnscaled(e.Image, New Point(e.ImageRectangle.Left, e.ImageRectangle.Top))
        End If
    End Sub

    Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
        Dim g = e.Graphics

        Dim rect = New Rectangle(1, 3, e.Item.Width, 1)

        Using b = New SolidBrush(ColorTranslator.FromWin32(RGB(80, 80, 80)))
            g.FillRectangle(b, rect)
        End Using
    End Sub

    Protected Overrides Sub OnRenderArrow(e As ToolStripArrowRenderEventArgs)
        e.ArrowColor = ColorTranslator.FromWin32(RGB(224, 224, 224))
        e.ArrowRectangle = New Rectangle(New Point(e.ArrowRectangle.Left, e.ArrowRectangle.Top - 1), e.ArrowRectangle.Size)

        MyBase.OnRenderArrow(e)
    End Sub

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        Dim g = e.Graphics

        e.Item.ForeColor = If(e.Item.Enabled, ColorTranslator.FromWin32(RGB(224, 224, 224)), ColorTranslator.FromWin32(RGB(180, 180, 180)))

        If e.Item.Enabled Then

            Dim bgColor = If(e.Item.Selected, ColorTranslator.FromWin32(RGB(80, 80, 80)), e.Item.BackColor)

            ' Normal item
            Dim rect = New Rectangle(2, 0, e.Item.Width - 3, e.Item.Height)

            Using b = New SolidBrush(bgColor)
                g.FillRectangle(b, rect)
            End Using

            ' Header item on open menu
            If TypeOf e.Item Is ToolStripMenuItem Then
                If CType(e.Item, ToolStripMenuItem).DropDown.Visible AndAlso e.Item.IsOnDropDown = False Then
                    Using b = New SolidBrush(ColorTranslator.FromWin32(RGB(80, 80, 80)))
                        g.FillRectangle(b, rect)
                    End Using
                End If
            End If
        End If
    End Sub

End Class
