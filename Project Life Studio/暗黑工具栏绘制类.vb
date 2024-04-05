Public Class 暗黑工具栏绘制类
    Inherits 暗黑菜单栏绘制类

    Protected Overrides Sub InitializeItem(item As ToolStripItem)
        MyBase.InitializeItem(item)

        If item.GetType() = GetType(ToolStripSeparator) Then
            Dim castItem As ToolStripSeparator = DirectCast(item, ToolStripSeparator)
            If Not castItem.IsOnDropDown Then
                item.Margin = New Padding(0, 0, 2, 0)
            End If
        End If

        If item.GetType() = GetType(ToolStripButton) Then
            item.AutoSize = False
            item.Size = New Size(24, 24)
        End If
    End Sub

    Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
        MyBase.OnRenderToolStripBackground(e)

        Dim g As Graphics = e.Graphics

        If e.ToolStrip.GetType() = GetType(ToolStripOverflow) Then
            Using p As New Pen(ColorTranslator.FromWin32(RGB(48, 48, 48)))
                Dim rect As New Rectangle(e.AffectedBounds.Left, e.AffectedBounds.Top, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1)
                g.DrawRectangle(p, rect)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        If e.ToolStrip.GetType() <> GetType(ToolStrip) Then
            MyBase.OnRenderToolStripBorder(e)
        End If
    End Sub

    Protected Overrides Sub OnRenderButtonBackground(e As ToolStripItemRenderEventArgs)
        Dim g As Graphics = e.Graphics

        Dim rect As New Rectangle(0, 1, e.Item.Width, e.Item.Height - 2)

        If e.Item.Selected OrElse e.Item.Pressed Then
            Using b As New SolidBrush(ColorTranslator.FromWin32(RGB(80, 80, 80)))
                g.FillRectangle(b, rect)
            End Using
        End If

        If e.Item.GetType() = GetType(ToolStripButton) Then
            Dim castItem As ToolStripButton = DirectCast(e.Item, ToolStripButton)

            If castItem.Checked Then
                Using b As New SolidBrush(ColorTranslator.FromWin32(RGB(80, 80, 80)))
                    g.FillRectangle(b, rect)
                End Using
            End If

            If castItem.Checked AndAlso castItem.Selected Then
                Dim modRect As New Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1)
                Using p As New Pen(ColorTranslator.FromWin32(RGB(80, 80, 80)))
                    g.DrawRectangle(p, modRect)
                End Using
            End If
        End If
    End Sub

    Protected Overrides Sub OnRenderDropDownButtonBackground(e As ToolStripItemRenderEventArgs)
        Dim g As Graphics = e.Graphics

        Dim rect As New Rectangle(0, 1, e.Item.Width, e.Item.Height - 2)

        If e.Item.Selected OrElse e.Item.Pressed Then
            Using b As New SolidBrush(ColorTranslator.FromWin32(RGB(80, 80, 80)))
                g.FillRectangle(b, rect)
            End Using
        End If
    End Sub

    'Protected Overrides Sub OnRenderGrip(e As ToolStripGripRenderEventArgs)
    '    If e.GripStyle = ToolStripGripStyle.Hidden Then
    '        Return
    '    End If

    '    Dim g As Graphics = e.Graphics

    '    Using img As Image = MenuIcons.grip.SetColor(Colors.LightBorder)
    '        g.DrawImageUnscaled(img, New Point(e.AffectedBounds.Left, e.AffectedBounds.Top))
    '    End Using
    'End Sub

    Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
        Dim g As Graphics = e.Graphics

        Dim castItem As ToolStripSeparator = DirectCast(e.Item, ToolStripSeparator)
        If castItem.IsOnDropDown Then
            MyBase.OnRenderSeparator(e)
            Return
        End If

        Dim rect As New Rectangle(3, 3, 2, e.Item.Height - 4)

        Using p As New Pen(ColorTranslator.FromWin32(RGB(80, 80, 80)))
            g.DrawLine(p, rect.Left, rect.Top, rect.Left, rect.Height)
        End Using

        Using p As New Pen(ColorTranslator.FromWin32(RGB(80, 80, 80)))
            g.DrawLine(p, rect.Left + 1, rect.Top, rect.Left + 1, rect.Height)
        End Using
    End Sub

    Protected Overrides Sub OnRenderItemImage(e As ToolStripItemImageRenderEventArgs)
        Dim g As Graphics = e.Graphics

        If e.Image Is Nothing Then
            Return
        End If

        If e.Item.Enabled Then
            g.DrawImageUnscaled(e.Image, New Point(e.ImageRectangle.Left, e.ImageRectangle.Top))
        Else
            ControlPaint.DrawImageDisabled(g, e.Image, e.ImageRectangle.Left, e.ImageRectangle.Top, Color.Transparent)
        End If
    End Sub



End Class
