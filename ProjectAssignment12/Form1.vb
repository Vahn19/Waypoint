Public Class Form1

    Dim x, y, xc, yc, x_c, y_c As Double
    Dim cnt As Integer = 0
    Dim max As Integer
    Dim screen As Graphics
    Dim waypoint = New List(Of Rectangle)
    Dim placement As Boolean = False
    Dim first_placement As Boolean = False
    Dim go As Boolean = True
    Dim v, vx, vy, dx, dy, pos As Double
    Dim a As Double

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        go = False
        a = 1
    End Sub

    Private Sub timer_anim_Tick(sender As Object, e As EventArgs) Handles timer_anim.Tick
        If cnt < waypoint.count Then
            dx = waypoint(cnt).x - xc
            dy = waypoint(cnt).y - yc

            Dim d = Math.Sqrt(dx * dx + dy * dy)
            Dim torq = (vx * dy - vy * dx)
            If torq < 0 Then
                pos -= txtbox_torque.Text
            ElseIf torq > 0 Then
                pos += txtbox_torque.Text
            End If

            If v + 90 > d AndAlso cnt = waypoint.count - 1 Then
                a = 0.8
                go = False
            End If

            start(go)

                vx = v * Math.Cos(pos * (Math.PI / 180))
                vy = v * Math.Sin(pos * (Math.PI / 180))

                screen.DrawEllipse(Pens.LightGray, CInt(xc), CInt(yc), 20, 20)
                screen.FillEllipse(Brushes.LightGray, CInt(xc), CInt(yc), 20, 20)

                xc += vx
                yc += vy

                screen.DrawEllipse(Pens.Black, CInt(xc), CInt(yc), 20, 20)
                screen.FillEllipse(Brushes.Black, CInt(xc), CInt(yc), 20, 20)

                If v > d Then
                    screen.DrawEllipse(Pens.LightGray, waypoint(cnt).x, waypoint(cnt).y, 15, 15)
                    screen.FillEllipse(Brushes.LightGray, waypoint(cnt).x, waypoint(cnt).y, 15, 15)
                    cnt += 1
                End If
            Else
                timer_anim.Enabled = False
        End If
    End Sub

    Function start(stats As Boolean)
        If stats Then
            If v < max Then
                v += a
            End If
        Else
            v -= a
            If v < 0 Then
                v = 0
                timer_anim.Enabled = False
            End If
        End If
    End Function

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        timer_anim.Enabled = False
        cnt = 0
        pos = 0
        xc = 0
        yc = 0

        go = False
        waypoint.clear()
        picturebox_main.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        screen = picturebox_main.CreateGraphics()
        screen.DrawLine(Pens.Red, 50, 50, 400, 400)
    End Sub

    Private Sub btn_placewaypoint_Click(sender As Object, e As EventArgs) Handles btn_placewaypoint.Click
        placement = False
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        If txtbox_velocity.Text = 0 Or txtbox_velocity.Text < 0 Then
            MsgBox("Please input velocity more than 0")
        ElseIf txtbox_torque.Text = 0 Or txtbox_torque.Text < 0 Then
            MsgBox("Please input torque more than 0")
        ElseIf Not first_placement Then
            MsgBox("Please place the car")
        ElseIf waypoint.count = 0 Then
            MsgBox("Please place add waypoints")
        Else
            v = 0
            max = txtbox_velocity.Text
            a = 0.5
            pos = 0

            go = True
            timer_anim.Enabled = True
        End If
    End Sub

    Private Sub picturebox_main_MouseMove(sender As Object, e As MouseEventArgs) Handles picturebox_main.MouseMove
        x = e.X
        y = e.Y
        lbl_coordinate.Text = (x & ", " & y)
    End Sub

    Private Sub btn_placecar_Click(sender As Object, e As EventArgs) Handles btn_placecar.Click
        placement = True
    End Sub

    Private Sub picturebox_main_Click(sender As Object, e As EventArgs) Handles picturebox_main.Click
        If placement = False Then
            Dim set_waypoint = New Rectangle(x, y, 15, 15)
            screen.DrawEllipse(Pens.Red, CInt(x), CInt(y), 15, 15)
            screen.FillEllipse(Brushes.Red, CInt(x), CInt(y), 15, 15)
            waypoint.Add(set_waypoint)
        Else
            If Not first_placement Then
                first_placement = True
            Else
                screen.DrawEllipse(Pens.LightGray, CInt(xc), CInt(yc), 20, 20)
                screen.FillEllipse(Brushes.LightGray, CInt(xc), CInt(yc), 20, 20)
            End If
            x_c = x
            y_c = y
            screen.DrawEllipse(Pens.Black, CInt(x_c), CInt(y_c), 20, 20)
            screen.FillEllipse(Brushes.Black, CInt(x_c), CInt(y_c), 20, 20)

            xc = x
            yc = y
        End If
    End Sub
End Class
