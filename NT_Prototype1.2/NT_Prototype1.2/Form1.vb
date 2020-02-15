Imports System.Windows.Forms

Public Class Start_UPForm
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point

    Private Sub Start_UPForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For at = 0.0 To 1.1 Step 0.1
            Me.Opacity = at
            Refresh()
            Threading.Thread.Sleep(100)
        Next

        StartUP_Timer1.Interval = 3000
        If Not StartUP_Timer1.Enabled Then
            StartUP_Timer1.Start()
        End If

    End Sub

    Private Sub Start_UPForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Start_UPForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub StartUP_Timer1_Tick(sender As Object, e As EventArgs) Handles StartUP_Timer1.Tick
        Static info As Integer = 0
        Dim arr() As String = {"Is to create and manage an Authentic Thai Massage Center to cater the old and young 
working class to relieve them of stress and live a healthful life and to address the 
needs in the field of relaxation in order to cope up a daily challenging environment...",
"                                             Production reports of customer...",
"                                                    Graphic analysis of sales...",
"                                                                Opening..."}

        If info < arr.Length Then
            Label1.Text = arr(info)
            info += 1
        Else
            StartUP_Timer1.Stop()
            info = 0
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub
End Class
