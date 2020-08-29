<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.picturebox_main = New System.Windows.Forms.PictureBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.txtbox_velocity = New System.Windows.Forms.TextBox()
        Me.lbl_velocity = New System.Windows.Forms.Label()
        Me.lbl_torque = New System.Windows.Forms.Label()
        Me.txtbox_torque = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_coordinate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timer_anim = New System.Windows.Forms.Timer(Me.components)
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_placecar = New System.Windows.Forms.Button()
        Me.btn_placewaypoint = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        CType(Me.picturebox_main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picturebox_main
        '
        Me.picturebox_main.BackColor = System.Drawing.Color.LightGray
        Me.picturebox_main.Location = New System.Drawing.Point(12, 27)
        Me.picturebox_main.Name = "picturebox_main"
        Me.picturebox_main.Size = New System.Drawing.Size(1061, 579)
        Me.picturebox_main.TabIndex = 0
        Me.picturebox_main.TabStop = False
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.Lime
        Me.btn_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.Location = New System.Drawing.Point(1092, 226)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(101, 36)
        Me.btn_start.TabIndex = 1
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'txtbox_velocity
        '
        Me.txtbox_velocity.Location = New System.Drawing.Point(1092, 57)
        Me.txtbox_velocity.Name = "txtbox_velocity"
        Me.txtbox_velocity.Size = New System.Drawing.Size(123, 22)
        Me.txtbox_velocity.TabIndex = 2
        Me.txtbox_velocity.Text = "0"
        '
        'lbl_velocity
        '
        Me.lbl_velocity.AutoSize = True
        Me.lbl_velocity.Location = New System.Drawing.Point(1092, 29)
        Me.lbl_velocity.Name = "lbl_velocity"
        Me.lbl_velocity.Size = New System.Drawing.Size(57, 17)
        Me.lbl_velocity.TabIndex = 3
        Me.lbl_velocity.Text = "Velocity"
        '
        'lbl_torque
        '
        Me.lbl_torque.AutoSize = True
        Me.lbl_torque.Location = New System.Drawing.Point(1092, 94)
        Me.lbl_torque.Name = "lbl_torque"
        Me.lbl_torque.Size = New System.Drawing.Size(54, 17)
        Me.lbl_torque.TabIndex = 4
        Me.lbl_torque.Text = "Torque"
        '
        'txtbox_torque
        '
        Me.txtbox_torque.Location = New System.Drawing.Point(1092, 128)
        Me.txtbox_torque.Name = "txtbox_torque"
        Me.txtbox_torque.Size = New System.Drawing.Size(123, 22)
        Me.txtbox_torque.TabIndex = 5
        Me.txtbox_torque.Text = "0"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_coordinate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 619)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1255, 25)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_coordinate
        '
        Me.lbl_coordinate.Name = "lbl_coordinate"
        Me.lbl_coordinate.Size = New System.Drawing.Size(47, 20)
        Me.lbl_coordinate.Text = "( X, Y)"
        '
        'timer_anim
        '
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.Cyan
        Me.btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.Location = New System.Drawing.Point(1092, 277)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(101, 36)
        Me.btn_reset.TabIndex = 7
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_placecar
        '
        Me.btn_placecar.BackColor = System.Drawing.Color.Black
        Me.btn_placecar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_placecar.ForeColor = System.Drawing.Color.White
        Me.btn_placecar.Location = New System.Drawing.Point(1092, 506)
        Me.btn_placecar.Name = "btn_placecar"
        Me.btn_placecar.Size = New System.Drawing.Size(101, 36)
        Me.btn_placecar.TabIndex = 8
        Me.btn_placecar.Text = "Place Car"
        Me.btn_placecar.UseVisualStyleBackColor = False
        '
        'btn_placewaypoint
        '
        Me.btn_placewaypoint.BackColor = System.Drawing.Color.Red
        Me.btn_placewaypoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_placewaypoint.Location = New System.Drawing.Point(1092, 419)
        Me.btn_placewaypoint.Name = "btn_placewaypoint"
        Me.btn_placewaypoint.Size = New System.Drawing.Size(101, 70)
        Me.btn_placewaypoint.TabIndex = 9
        Me.btn_placewaypoint.Text = "Place Waypoints"
        Me.btn_placewaypoint.UseVisualStyleBackColor = False
        '
        'btn_stop
        '
        Me.btn_stop.BackColor = System.Drawing.Color.Red
        Me.btn_stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stop.ForeColor = System.Drawing.Color.Black
        Me.btn_stop.Location = New System.Drawing.Point(1092, 328)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(101, 36)
        Me.btn_stop.TabIndex = 10
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 644)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_placewaypoint)
        Me.Controls.Add(Me.btn_placecar)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtbox_torque)
        Me.Controls.Add(Me.lbl_torque)
        Me.Controls.Add(Me.lbl_velocity)
        Me.Controls.Add(Me.txtbox_velocity)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.picturebox_main)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picturebox_main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picturebox_main As PictureBox
    Friend WithEvents btn_start As Button
    Friend WithEvents txtbox_velocity As TextBox
    Friend WithEvents lbl_velocity As Label
    Friend WithEvents lbl_torque As Label
    Friend WithEvents txtbox_torque As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbl_coordinate As ToolStripStatusLabel
    Friend WithEvents timer_anim As Timer
    Friend WithEvents btn_placecar As Button
    Friend WithEvents btn_placewaypoint As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents btn_reset As Button
End Class
