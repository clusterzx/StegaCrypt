<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txt_open = New System.Windows.Forms.TextBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.fd_openexe = New System.Windows.Forms.OpenFileDialog()
        Me.fd_openpic = New System.Windows.Forms.OpenFileDialog()
        Me.fd_save = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_debug = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grp_about = New System.Windows.Forms.GroupBox()
        Me.lbl_about = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grp_about.SuspendLayout
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txt_open
        '
        Me.txt_open.AllowDrop = true
        Me.txt_open.BackColor = System.Drawing.Color.Black
        Me.txt_open.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_open.ForeColor = System.Drawing.Color.Cyan
        Me.txt_open.Location = New System.Drawing.Point(53, 193)
        Me.txt_open.Name = "txt_open"
        Me.txt_open.ReadOnly = true
        Me.txt_open.Size = New System.Drawing.Size(272, 20)
        Me.txt_open.TabIndex = 0
        Me.txt_open.Text = "DRAG & DROP FILE HERE"
        Me.txt_open.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_picture
        '
        Me.txt_picture.AllowDrop = true
        Me.txt_picture.BackColor = System.Drawing.Color.Black
        Me.txt_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_picture.ForeColor = System.Drawing.Color.Cyan
        Me.txt_picture.Location = New System.Drawing.Point(53, 238)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.ReadOnly = true
        Me.txt_picture.Size = New System.Drawing.Size(272, 20)
        Me.txt_picture.TabIndex = 2
        Me.txt_picture.Text = "DRAG & DROP FILE HERE"
        Me.txt_picture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fd_openpic
        '
        Me.fd_openpic.FileName = "OpenFileDialog1"
        '
        'fd_save
        '
        Me.fd_save.Filter = "Executables only (*.exe) | *.exe"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(339, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Crypt"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(53, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Image to hide malware"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(53, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Payload"
        '
        'txt_debug
        '
        Me.txt_debug.BackColor = System.Drawing.Color.Black
        Me.txt_debug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_debug.ForeColor = System.Drawing.Color.Cyan
        Me.txt_debug.Location = New System.Drawing.Point(32, 397)
        Me.txt_debug.Multiline = true
        Me.txt_debug.Name = "txt_debug"
        Me.txt_debug.ReadOnly = true
        Me.txt_debug.Size = New System.Drawing.Size(491, 90)
        Me.txt_debug.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(494, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 44)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = false
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(10, 118)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(484, 32)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = false
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(171, 264)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(154, 125)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(53, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Preview Image "
        '
        'grp_about
        '
        Me.grp_about.BackColor = System.Drawing.Color.Transparent
        Me.grp_about.Controls.Add(Me.lbl_about)
        Me.grp_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp_about.ForeColor = System.Drawing.Color.Cyan
        Me.grp_about.Location = New System.Drawing.Point(339, 166)
        Me.grp_about.Name = "grp_about"
        Me.grp_about.Size = New System.Drawing.Size(172, 215)
        Me.grp_about.TabIndex = 11
        Me.grp_about.TabStop = false
        '
        'lbl_about
        '
        Me.lbl_about.Location = New System.Drawing.Point(10, 194)
        Me.lbl_about.Name = "lbl_about"
        Me.lbl_about.Size = New System.Drawing.Size(151, 128)
        Me.lbl_about.TabIndex = 0
        Me.lbl_about.Text = "Coded by: Clusterz"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Language: Visual Basic .NET"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Date: 29.12.2018"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"License: MIT"& _ 
    " - Do what ever u want"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Webpage: https://github.com/clusterzx/"
        Me.lbl_about.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        Me.Timer1.Interval = 25
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(339, 151)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(170, 21)
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = false
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Black
        Me.PictureBox5.Location = New System.Drawing.Point(338, 381)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(171, 13)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = false
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TestCrypter.My.Resources.Resources.StegaCrypt_new_Design3
        Me.ClientSize = New System.Drawing.Size(549, 546)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.grp_about)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_debug)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.txt_open)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "StegaCrypt - *FOR EDUCATIONAL PURPOSE ONLY*"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.grp_about.ResumeLayout(false)
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txt_open As TextBox
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents fd_openexe As OpenFileDialog
    Friend WithEvents fd_openpic As OpenFileDialog
    Friend WithEvents fd_save As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_debug As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grp_about As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_about As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
