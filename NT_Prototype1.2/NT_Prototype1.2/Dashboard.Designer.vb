<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RealDate = New System.Windows.Forms.Label()
        Me.Realtime = New System.Windows.Forms.Label()
        Me.Si_o = New System.Windows.Forms.Panel()
        Me.Exit_Sys = New System.Windows.Forms.LinkLabel()
        Me.SignOut_Si = New System.Windows.Forms.LinkLabel()
        Me.Admin_Si = New System.Windows.Forms.LinkLabel()
        Me.Yearly_BP = New System.Windows.Forms.Panel()
        Me.Monthly_BP = New System.Windows.Forms.Panel()
        Me.Weekly_BP = New System.Windows.Forms.Panel()
        Me.Daily_BP = New System.Windows.Forms.Panel()
        Me.Services_BP = New System.Windows.Forms.Panel()
        Me.Position_ID = New System.Windows.Forms.Label()
        Me.Position = New System.Windows.Forms.Label()
        Me.Yearly_D = New System.Windows.Forms.Label()
        Me.Monthly_D = New System.Windows.Forms.Label()
        Me.Weekly_D = New System.Windows.Forms.Label()
        Me.Daily_D = New System.Windows.Forms.Label()
        Me.Services_D = New System.Windows.Forms.Label()
        Me.U_name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Si_o.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.RealDate)
        Me.Panel1.Controls.Add(Me.Realtime)
        Me.Panel1.Controls.Add(Me.Si_o)
        Me.Panel1.Controls.Add(Me.Yearly_BP)
        Me.Panel1.Controls.Add(Me.Monthly_BP)
        Me.Panel1.Controls.Add(Me.Weekly_BP)
        Me.Panel1.Controls.Add(Me.Daily_BP)
        Me.Panel1.Controls.Add(Me.Services_BP)
        Me.Panel1.Controls.Add(Me.Position_ID)
        Me.Panel1.Controls.Add(Me.Position)
        Me.Panel1.Controls.Add(Me.Yearly_D)
        Me.Panel1.Controls.Add(Me.Monthly_D)
        Me.Panel1.Controls.Add(Me.Weekly_D)
        Me.Panel1.Controls.Add(Me.Daily_D)
        Me.Panel1.Controls.Add(Me.Services_D)
        Me.Panel1.Controls.Add(Me.U_name)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 110)
        Me.Panel1.TabIndex = 0
        '
        'RealDate
        '
        Me.RealDate.AutoSize = True
        Me.RealDate.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RealDate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RealDate.Location = New System.Drawing.Point(621, 84)
        Me.RealDate.Name = "RealDate"
        Me.RealDate.Size = New System.Drawing.Size(73, 17)
        Me.RealDate.TabIndex = 11
        Me.RealDate.Text = "M: D: Year"
        '
        'Realtime
        '
        Me.Realtime.AutoSize = True
        Me.Realtime.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Realtime.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Realtime.Location = New System.Drawing.Point(973, 85)
        Me.Realtime.Name = "Realtime"
        Me.Realtime.Size = New System.Drawing.Size(56, 17)
        Me.Realtime.TabIndex = 10
        Me.Realtime.Text = "hh: mm"
        '
        'Si_o
        '
        Me.Si_o.BackColor = System.Drawing.Color.SteelBlue
        Me.Si_o.Controls.Add(Me.Exit_Sys)
        Me.Si_o.Controls.Add(Me.SignOut_Si)
        Me.Si_o.Controls.Add(Me.Admin_Si)
        Me.Si_o.Location = New System.Drawing.Point(76, 3)
        Me.Si_o.Name = "Si_o"
        Me.Si_o.Size = New System.Drawing.Size(5, 70)
        Me.Si_o.TabIndex = 9
        '
        'Exit_Sys
        '
        Me.Exit_Sys.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.Exit_Sys.AutoSize = True
        Me.Exit_Sys.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Sys.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.Exit_Sys.Location = New System.Drawing.Point(11, 39)
        Me.Exit_Sys.Name = "Exit_Sys"
        Me.Exit_Sys.Size = New System.Drawing.Size(26, 16)
        Me.Exit_Sys.TabIndex = 1
        Me.Exit_Sys.TabStop = True
        Me.Exit_Sys.Text = "Exit"
        Me.Exit_Sys.Visible = False
        '
        'SignOut_Si
        '
        Me.SignOut_Si.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.SignOut_Si.AutoSize = True
        Me.SignOut_Si.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignOut_Si.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.SignOut_Si.Location = New System.Drawing.Point(12, 24)
        Me.SignOut_Si.Name = "SignOut_Si"
        Me.SignOut_Si.Size = New System.Drawing.Size(54, 16)
        Me.SignOut_Si.TabIndex = 1
        Me.SignOut_Si.TabStop = True
        Me.SignOut_Si.Text = "Sign Out"
        Me.SignOut_Si.Visible = False
        '
        'Admin_Si
        '
        Me.Admin_Si.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.Admin_Si.AutoSize = True
        Me.Admin_Si.Font = New System.Drawing.Font("Gadugi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin_Si.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.Admin_Si.Location = New System.Drawing.Point(12, 9)
        Me.Admin_Si.Name = "Admin_Si"
        Me.Admin_Si.Size = New System.Drawing.Size(44, 16)
        Me.Admin_Si.TabIndex = 0
        Me.Admin_Si.TabStop = True
        Me.Admin_Si.Text = "Admin"
        Me.Admin_Si.Visible = False
        '
        'Yearly_BP
        '
        Me.Yearly_BP.BackColor = System.Drawing.Color.Gainsboro
        Me.Yearly_BP.Location = New System.Drawing.Point(346, 105)
        Me.Yearly_BP.Name = "Yearly_BP"
        Me.Yearly_BP.Size = New System.Drawing.Size(20, 2)
        Me.Yearly_BP.TabIndex = 2
        '
        'Monthly_BP
        '
        Me.Monthly_BP.BackColor = System.Drawing.Color.Gainsboro
        Me.Monthly_BP.Location = New System.Drawing.Point(268, 105)
        Me.Monthly_BP.Name = "Monthly_BP"
        Me.Monthly_BP.Size = New System.Drawing.Size(20, 2)
        Me.Monthly_BP.TabIndex = 2
        '
        'Weekly_BP
        '
        Me.Weekly_BP.BackColor = System.Drawing.Color.Gainsboro
        Me.Weekly_BP.Location = New System.Drawing.Point(192, 105)
        Me.Weekly_BP.Name = "Weekly_BP"
        Me.Weekly_BP.Size = New System.Drawing.Size(20, 2)
        Me.Weekly_BP.TabIndex = 2
        '
        'Daily_BP
        '
        Me.Daily_BP.BackColor = System.Drawing.Color.Gainsboro
        Me.Daily_BP.Location = New System.Drawing.Point(116, 105)
        Me.Daily_BP.Name = "Daily_BP"
        Me.Daily_BP.Size = New System.Drawing.Size(20, 2)
        Me.Daily_BP.TabIndex = 2
        '
        'Services_BP
        '
        Me.Services_BP.BackColor = System.Drawing.Color.Gainsboro
        Me.Services_BP.Location = New System.Drawing.Point(41, 105)
        Me.Services_BP.Name = "Services_BP"
        Me.Services_BP.Size = New System.Drawing.Size(20, 2)
        Me.Services_BP.TabIndex = 1
        '
        'Position_ID
        '
        Me.Position_ID.AutoSize = True
        Me.Position_ID.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Position_ID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Position_ID.Location = New System.Drawing.Point(83, 44)
        Me.Position_ID.Name = "Position_ID"
        Me.Position_ID.Size = New System.Drawing.Size(63, 14)
        Me.Position_ID.TabIndex = 8
        Me.Position_ID.Text = "Position ID"
        '
        'Position
        '
        Me.Position.AutoSize = True
        Me.Position.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Position.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Position.Location = New System.Drawing.Point(83, 29)
        Me.Position.Name = "Position"
        Me.Position.Size = New System.Drawing.Size(49, 14)
        Me.Position.TabIndex = 7
        Me.Position.Text = "Position"
        '
        'Yearly_D
        '
        Me.Yearly_D.AutoSize = True
        Me.Yearly_D.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yearly_D.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Yearly_D.Location = New System.Drawing.Point(334, 85)
        Me.Yearly_D.Name = "Yearly_D"
        Me.Yearly_D.Size = New System.Drawing.Size(46, 17)
        Me.Yearly_D.TabIndex = 6
        Me.Yearly_D.Text = "Yearly"
        '
        'Monthly_D
        '
        Me.Monthly_D.AutoSize = True
        Me.Monthly_D.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monthly_D.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Monthly_D.Location = New System.Drawing.Point(253, 85)
        Me.Monthly_D.Name = "Monthly_D"
        Me.Monthly_D.Size = New System.Drawing.Size(60, 17)
        Me.Monthly_D.TabIndex = 5
        Me.Monthly_D.Text = "Monthly"
        '
        'Weekly_D
        '
        Me.Weekly_D.AutoSize = True
        Me.Weekly_D.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weekly_D.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Weekly_D.Location = New System.Drawing.Point(178, 85)
        Me.Weekly_D.Name = "Weekly_D"
        Me.Weekly_D.Size = New System.Drawing.Size(53, 17)
        Me.Weekly_D.TabIndex = 4
        Me.Weekly_D.Text = "Weekly"
        '
        'Daily_D
        '
        Me.Daily_D.AutoSize = True
        Me.Daily_D.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Daily_D.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Daily_D.Location = New System.Drawing.Point(108, 85)
        Me.Daily_D.Name = "Daily_D"
        Me.Daily_D.Size = New System.Drawing.Size(40, 17)
        Me.Daily_D.TabIndex = 3
        Me.Daily_D.Text = "Daily"
        '
        'Services_D
        '
        Me.Services_D.AutoSize = True
        Me.Services_D.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Services_D.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Services_D.Location = New System.Drawing.Point(25, 85)
        Me.Services_D.Name = "Services_D"
        Me.Services_D.Size = New System.Drawing.Size(57, 17)
        Me.Services_D.TabIndex = 2
        Me.Services_D.Text = "Services"
        '
        'U_name
        '
        Me.U_name.AutoSize = True
        Me.U_name.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_name.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.U_name.Location = New System.Drawing.Point(82, 11)
        Me.U_name.Name = "U_name"
        Me.U_name.Size = New System.Drawing.Size(69, 17)
        Me.U_name.TabIndex = 1
        Me.U_name.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NT_Prototype1._2.My.Resources.Resources.icon1
        Me.PictureBox1.Location = New System.Drawing.Point(29, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me
        '
        'Timer1
        '
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1061, 746)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Si_o.ResumeLayout(False)
        Me.Si_o.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents U_name As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Yearly_BP As Panel
    Friend WithEvents Monthly_BP As Panel
    Friend WithEvents Weekly_BP As Panel
    Friend WithEvents Daily_BP As Panel
    Friend WithEvents Services_BP As Panel
    Friend WithEvents Position_ID As Label
    Friend WithEvents Position As Label
    Friend WithEvents Yearly_D As Label
    Friend WithEvents Monthly_D As Label
    Friend WithEvents Weekly_D As Label
    Friend WithEvents Daily_D As Label
    Friend WithEvents Services_D As Label
    Friend WithEvents Si_o As Panel
    Friend WithEvents Exit_Sys As LinkLabel
    Friend WithEvents SignOut_Si As LinkLabel
    Friend WithEvents Admin_Si As LinkLabel
    Friend WithEvents RealDate As Label
    Friend WithEvents Realtime As Label
    Friend WithEvents Timer1 As Timer
End Class
