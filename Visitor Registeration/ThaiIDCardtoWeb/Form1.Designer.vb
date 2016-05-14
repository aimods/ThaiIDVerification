<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIDRead
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtCitizenID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtThaiName = New System.Windows.Forms.TextBox()
        Me.RdVerify = New System.Windows.Forms.PictureBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.IDPhoto = New System.Windows.Forms.PictureBox()
        CType(Me.RdVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCitizenID
        '
        Me.txtCitizenID.Location = New System.Drawing.Point(12, 12)
        Me.txtCitizenID.Name = "txtCitizenID"
        Me.txtCitizenID.Size = New System.Drawing.Size(147, 20)
        Me.txtCitizenID.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Read"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtThaiName
        '
        Me.txtThaiName.Location = New System.Drawing.Point(12, 39)
        Me.txtThaiName.Name = "txtThaiName"
        Me.txtThaiName.Size = New System.Drawing.Size(250, 20)
        Me.txtThaiName.TabIndex = 2
        '
        'RdVerify
        '
        Me.RdVerify.Image = Global.ThaiIDCardtoWeb.My.Resources.Resources._2000px_Red_pog_svg
        Me.RdVerify.Location = New System.Drawing.Point(165, 12)
        Me.RdVerify.Name = "RdVerify"
        Me.RdVerify.Size = New System.Drawing.Size(16, 16)
        Me.RdVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RdVerify.TabIndex = 3
        Me.RdVerify.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(12, 65)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(250, 66)
        Me.txtAddress.TabIndex = 4
        '
        'IDPhoto
        '
        Me.IDPhoto.ErrorImage = Nothing
        Me.IDPhoto.Location = New System.Drawing.Point(276, 13)
        Me.IDPhoto.Name = "IDPhoto"
        Me.IDPhoto.Size = New System.Drawing.Size(97, 117)
        Me.IDPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IDPhoto.TabIndex = 5
        Me.IDPhoto.TabStop = False
        '
        'frmIDRead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 144)
        Me.Controls.Add(Me.IDPhoto)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.RdVerify)
        Me.Controls.Add(Me.txtThaiName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCitizenID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmIDRead"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "อ่านข้อมูลบัตรประชาชน"
        CType(Me.RdVerify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCitizenID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtThaiName As TextBox
    Friend WithEvents RdVerify As PictureBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents IDPhoto As PictureBox
End Class
