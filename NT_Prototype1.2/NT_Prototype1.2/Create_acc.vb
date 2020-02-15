Public Class Create_acc
    Dim X, Y As Integer
    Dim NewPoint As New System.Drawing.Point

    Private Sub CreateAccount()
        Try
            Sql = "INSERT INTO EmployeeInfo(Email, DateCreated, HomeAddress, ContactNumber, Religion, FirstName, MiddleName, LastName, DateOfBirth, CivilStatus) VALUES('" & c_Email.Text & "', '" & c_CurrentDate.Text & "', '" & c_HomeAddress.Text & "', '" & c_ContactNumber.Text & "', '" & c_Religion.Text & "', '" & c_Fname.Text & "', '" & c_Mname.Text & "', '" & c_Lname.Text & "', '" & c_DateOfBirth.Text & "', '" & c_CivilStatus.Text & "')"
            Cmd = New OleDb.OleDbCommand(Sql, Con)
            Dim i As Integer
            ConnectDb()
            i = Cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Employee Information Added.", MsgBoxStyle.Information, "Congratulations!")
            Else
                MsgBox("Inaccurate Information.", MsgBoxStyle.Critical, "Error!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cmd.Dispose()
            Con.Close()
        End Try
    End Sub

    Private Sub UserLogin()
        Try
            Sql = "INSERT INTO UserLogin([Position], PositionID, Username, Password) VALUES ('" & c_Position.Text & "', '" & c_PositionID.Text & "', '" & c_Username.Text & "', '" & c_Password.Text & "')"
            Cmd = New OleDb.OleDbCommand(Sql, Con)
            Dim ppup As Integer
            ConnectDb()
            ppup = Cmd.ExecuteNonQuery
            If ppup > 0 Then
                MsgBox("Username and Password Acquired!", MsgBoxStyle.Information, "Welcome!")
            Else
                MsgBox("Inaccurate Username and Password!", MsgBoxStyle.AbortRetryIgnore, "Error!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cmd.Dispose()
        Con.Close()
    End Sub
    Private Sub Create_acc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub Create_acc_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        c_CurrentDate.Text = DateTime.Now.ToShortDateString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateAccount()
        UserLogin()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If c_Password.UseSystemPasswordChar = True Then
            c_Password.UseSystemPasswordChar = False
        Else
            c_Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Create_acc_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub
End Class