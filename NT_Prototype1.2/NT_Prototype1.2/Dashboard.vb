Public Class Dashboard
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Services_BP.Visible = False
        Daily_BP.Visible = False
        Weekly_BP.Visible = False
        Monthly_BP.Visible = False
        Yearly_BP.Visible = False
    End Sub

    Private Sub Dashboard_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Dashboard_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Services_BP_Paint(sender As Object, e As PaintEventArgs) Handles Services_BP.Paint

    End Sub

    Private Sub Services_D_Click(sender As Object, e As EventArgs) Handles Services_D.Click
        Services_BP.Visible = True
        Daily_BP.Visible = False
        Weekly_BP.Visible = False
        Monthly_BP.Visible = False
        Yearly_BP.Visible = False
    End Sub

    Private Sub Daily_D_Click(sender As Object, e As EventArgs) Handles Daily_D.Click
        Services_BP.Visible = False
        Daily_BP.Visible = True
        Weekly_BP.Visible = False
        Monthly_BP.Visible = False
        Yearly_BP.Visible = False
    End Sub

    Private Sub Weekly_D_Click(sender As Object, e As EventArgs) Handles Weekly_D.Click
        Services_BP.Visible = False
        Daily_BP.Visible = False
        Weekly_BP.Visible = True
        Monthly_BP.Visible = False
        Yearly_BP.Visible = False
    End Sub

    Private Sub Monthly_D_Click(sender As Object, e As EventArgs) Handles Monthly_D.Click
        Services_BP.Visible = False
        Daily_BP.Visible = False
        Weekly_BP.Visible = False
        Monthly_BP.Visible = True
        Yearly_BP.Visible = False
    End Sub

    Private Sub Yearly_D_Click(sender As Object, e As EventArgs) Handles Yearly_D.Click
        Services_BP.Visible = False
        Daily_BP.Visible = False
        Weekly_BP.Visible = False
        Monthly_BP.Visible = False
        Yearly_BP.Visible = True
    End Sub



    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub SignOut_Si_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignOut_Si.LinkClicked
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Exit_Sys_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Exit_Sys.LinkClicked
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Realtime.Text = TimeOfDay.ToString("h:mm tt")
        RealDate.Text = DateTime.Now.ToLongDateString

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Si_o.Width = 5 Then
            Do While Si_o.Width < 115
                Si_o.Width = Si_o.Width + 1
            Loop
            Admin_Si.Visible = True
            SignOut_Si.Visible = True
            Exit_Sys.Visible = True
        ElseIf Si_o.Width = 115 Then
            Do While Si_o.Width > 5
                Si_o.Width = Si_o.Width - 1
            Loop
            Admin_Si.Visible = False
            SignOut_Si.Visible = False
            Exit_Sys.Visible = False
        End If
    End Sub
End Class