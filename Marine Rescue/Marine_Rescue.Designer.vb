<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Marine_Rescue
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
        Me.ms_option_menu = New System.Windows.Forms.MenuStrip()
        Me.tsmi_start = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_newgame = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Instructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_txt_points = New System.Windows.Forms.ToolStripTextBox()
        Me.ts_lbl_level = New System.Windows.Forms.ToolStripLabel()
        Me.ts_txt_level = New System.Windows.Forms.ToolStripTextBox()
        Me.ts_lbl_lifes = New System.Windows.Forms.ToolStripLabel()
        Me.ts_txt_lifes = New System.Windows.Forms.ToolStripTextBox()
        Me.ts_lbl_seating = New System.Windows.Forms.ToolStripLabel()
        Me.ts_txt_seating = New System.Windows.Forms.ToolStripTextBox()
        Me.ts_ui = New System.Windows.Forms.ToolStrip()
        Me.ts_lbl_points = New System.Windows.Forms.ToolStripLabel()
        Me.ts_lbl_fuel = New System.Windows.Forms.ToolStripLabel()
        Me.ts_txt_fuel = New System.Windows.Forms.ToolStripTextBox()
        Me.ts_lbl_velocimeter = New System.Windows.Forms.ToolStripLabel()
        Me.ts_txt_velocimeter = New System.Windows.Forms.ToolStripTextBox()
        Me.timer_time = New System.Windows.Forms.Timer(Me.components)
        Me.txt_time = New System.Windows.Forms.TextBox()
        Me.pan_sea = New System.Windows.Forms.Panel()
        Me.pic_cg_ship = New System.Windows.Forms.PictureBox()
        Me.timer_cg_ship = New System.Windows.Forms.Timer(Me.components)
        Me.ms_option_menu.SuspendLayout()
        Me.ts_ui.SuspendLayout()
        Me.pan_sea.SuspendLayout()
        CType(Me.pic_cg_ship, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ms_option_menu
        '
        Me.ms_option_menu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ms_option_menu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.ms_option_menu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ms_option_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_start, Me.tsmi_newgame, Me.tsmi_about, Me.tsmi_Instructions, Me.ToolStripMenuItem4})
        Me.ms_option_menu.Location = New System.Drawing.Point(0, 0)
        Me.ms_option_menu.Name = "ms_option_menu"
        Me.ms_option_menu.Size = New System.Drawing.Size(1864, 54)
        Me.ms_option_menu.TabIndex = 2
        Me.ms_option_menu.Text = "Opciones"
        '
        'tsmi_start
        '
        Me.tsmi_start.Font = New System.Drawing.Font("Showcard Gothic", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmi_start.Name = "tsmi_start"
        Me.tsmi_start.Size = New System.Drawing.Size(159, 50)
        Me.tsmi_start.Text = "Inicio"
        '
        'tsmi_newgame
        '
        Me.tsmi_newgame.Font = New System.Drawing.Font("Showcard Gothic", 13.875!, System.Drawing.FontStyle.Bold)
        Me.tsmi_newgame.Name = "tsmi_newgame"
        Me.tsmi_newgame.Size = New System.Drawing.Size(293, 50)
        Me.tsmi_newgame.Text = "Nuevo Juego"
        '
        'tsmi_about
        '
        Me.tsmi_about.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsmi_about.Font = New System.Drawing.Font("Showcard Gothic", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmi_about.Name = "tsmi_about"
        Me.tsmi_about.Size = New System.Drawing.Size(239, 50)
        Me.tsmi_about.Text = "Acerca de"
        '
        'tsmi_Instructions
        '
        Me.tsmi_Instructions.Font = New System.Drawing.Font("Showcard Gothic", 13.875!, System.Drawing.FontStyle.Bold)
        Me.tsmi_Instructions.Name = "tsmi_Instructions"
        Me.tsmi_Instructions.Size = New System.Drawing.Size(330, 50)
        Me.tsmi_Instructions.Text = "Instrucciones"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Showcard Gothic", 13.875!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(221, 50)
        Me.ToolStripMenuItem4.Text = "Historia"
        '
        'ts_txt_points
        '
        Me.ts_txt_points.BackColor = System.Drawing.SystemColors.Control
        Me.ts_txt_points.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ts_txt_points.Name = "ts_txt_points"
        Me.ts_txt_points.ReadOnly = True
        Me.ts_txt_points.Size = New System.Drawing.Size(128, 52)
        '
        'ts_lbl_level
        '
        Me.ts_lbl_level.Font = New System.Drawing.Font("Showcard Gothic", 13.875!, System.Drawing.FontStyle.Bold)
        Me.ts_lbl_level.Name = "ts_lbl_level"
        Me.ts_lbl_level.Size = New System.Drawing.Size(127, 46)
        Me.ts_lbl_level.Text = "Nivel"
        '
        'ts_txt_level
        '
        Me.ts_txt_level.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ts_txt_level.Name = "ts_txt_level"
        Me.ts_txt_level.ReadOnly = True
        Me.ts_txt_level.Size = New System.Drawing.Size(128, 52)
        '
        'ts_lbl_lifes
        '
        Me.ts_lbl_lifes.Name = "ts_lbl_lifes"
        Me.ts_lbl_lifes.Size = New System.Drawing.Size(131, 46)
        Me.ts_lbl_lifes.Text = "Vidas"
        '
        'ts_txt_lifes
        '
        Me.ts_txt_lifes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ts_txt_lifes.Name = "ts_txt_lifes"
        Me.ts_txt_lifes.ReadOnly = True
        Me.ts_txt_lifes.Size = New System.Drawing.Size(128, 52)
        '
        'ts_lbl_seating
        '
        Me.ts_lbl_seating.Name = "ts_lbl_seating"
        Me.ts_lbl_seating.Size = New System.Drawing.Size(437, 46)
        Me.ts_lbl_seating.Text = "Puestos Disponibles"
        '
        'ts_txt_seating
        '
        Me.ts_txt_seating.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ts_txt_seating.Name = "ts_txt_seating"
        Me.ts_txt_seating.ReadOnly = True
        Me.ts_txt_seating.Size = New System.Drawing.Size(128, 52)
        '
        'ts_ui
        '
        Me.ts_ui.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ts_ui.Font = New System.Drawing.Font("Showcard Gothic", 13.875!, System.Drawing.FontStyle.Bold)
        Me.ts_ui.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts_ui.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ts_ui.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_lbl_points, Me.ts_txt_points, Me.ts_lbl_level, Me.ts_txt_level, Me.ts_lbl_lifes, Me.ts_txt_lifes, Me.ts_lbl_seating, Me.ts_txt_seating, Me.ts_lbl_fuel, Me.ts_txt_fuel, Me.ts_lbl_velocimeter, Me.ts_txt_velocimeter})
        Me.ts_ui.Location = New System.Drawing.Point(0, 54)
        Me.ts_ui.Name = "ts_ui"
        Me.ts_ui.Size = New System.Drawing.Size(1864, 52)
        Me.ts_ui.TabIndex = 1
        Me.ts_ui.Text = "Marcadores"
        '
        'ts_lbl_points
        '
        Me.ts_lbl_points.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ts_lbl_points.Font = New System.Drawing.Font("Showcard Gothic", 13.875!, System.Drawing.FontStyle.Bold)
        Me.ts_lbl_points.Name = "ts_lbl_points"
        Me.ts_lbl_points.Size = New System.Drawing.Size(168, 46)
        Me.ts_lbl_points.Text = "Puntos"
        '
        'ts_lbl_fuel
        '
        Me.ts_lbl_fuel.Name = "ts_lbl_fuel"
        Me.ts_lbl_fuel.Size = New System.Drawing.Size(283, 46)
        Me.ts_lbl_fuel.Text = "Combustible"
        '
        'ts_txt_fuel
        '
        Me.ts_txt_fuel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ts_txt_fuel.Name = "ts_txt_fuel"
        Me.ts_txt_fuel.ReadOnly = True
        Me.ts_txt_fuel.Size = New System.Drawing.Size(128, 52)
        '
        'ts_lbl_velocimeter
        '
        Me.ts_lbl_velocimeter.Name = "ts_lbl_velocimeter"
        Me.ts_lbl_velocimeter.Size = New System.Drawing.Size(284, 46)
        Me.ts_lbl_velocimeter.Text = "Velocímetro"
        '
        'ts_txt_velocimeter
        '
        Me.ts_txt_velocimeter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ts_txt_velocimeter.Name = "ts_txt_velocimeter"
        Me.ts_txt_velocimeter.ReadOnly = True
        Me.ts_txt_velocimeter.Size = New System.Drawing.Size(80, 39)
        '
        'timer_time
        '
        Me.timer_time.Interval = 1000
        '
        'txt_time
        '
        Me.txt_time.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_time.Location = New System.Drawing.Point(3200, 1162)
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(100, 31)
        Me.txt_time.TabIndex = 3
        '
        'pan_sea
        '
        Me.pan_sea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pan_sea.BackColor = System.Drawing.SystemColors.Highlight
        Me.pan_sea.BackgroundImage = Global.Marine_Rescue.My.Resources.Resources.Sea
        Me.pan_sea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pan_sea.Controls.Add(Me.pic_cg_ship)
        Me.pan_sea.Location = New System.Drawing.Point(0, 104)
        Me.pan_sea.Name = "pan_sea"
        Me.pan_sea.Size = New System.Drawing.Size(1864, 766)
        Me.pan_sea.TabIndex = 4
        Me.pan_sea.Visible = False
        '
        'pic_cg_ship
        '
        Me.pic_cg_ship.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_cg_ship.BackColor = System.Drawing.Color.Transparent
        Me.pic_cg_ship.Location = New System.Drawing.Point(1526, 572)
        Me.pic_cg_ship.Name = "pic_cg_ship"
        Me.pic_cg_ship.Size = New System.Drawing.Size(335, 194)
        Me.pic_cg_ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_cg_ship.TabIndex = 0
        Me.pic_cg_ship.TabStop = False
        Me.pic_cg_ship.Visible = False
        '
        'timer_cg_ship
        '
        Me.timer_cg_ship.Interval = 1
        '
        'Marine_Rescue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1864, 868)
        Me.Controls.Add(Me.pan_sea)
        Me.Controls.Add(Me.txt_time)
        Me.Controls.Add(Me.ts_ui)
        Me.Controls.Add(Me.ms_option_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.ms_option_menu
        Me.Name = "Marine_Rescue"
        Me.Text = "Marine Rescue"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ms_option_menu.ResumeLayout(False)
        Me.ms_option_menu.PerformLayout()
        Me.ts_ui.ResumeLayout(False)
        Me.ts_ui.PerformLayout()
        Me.pan_sea.ResumeLayout(False)
        CType(Me.pic_cg_ship, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ms_option_menu As MenuStrip
    Friend WithEvents tsmi_start As ToolStripMenuItem
    Friend WithEvents tsmi_newgame As ToolStripMenuItem
    Friend WithEvents tsmi_about As ToolStripMenuItem
    Friend WithEvents ts_txt_points As ToolStripTextBox
    Friend WithEvents ts_lbl_level As ToolStripLabel
    Friend WithEvents ts_txt_level As ToolStripTextBox
    Friend WithEvents ts_lbl_lifes As ToolStripLabel
    Friend WithEvents ts_txt_lifes As ToolStripTextBox
    Friend WithEvents ts_lbl_seating As ToolStripLabel
    Friend WithEvents ts_txt_seating As ToolStripTextBox
    Friend WithEvents ts_ui As ToolStrip
    Friend WithEvents ts_lbl_fuel As ToolStripLabel
    Friend WithEvents ts_txt_fuel As ToolStripTextBox
    Friend WithEvents ts_lbl_velocimeter As ToolStripLabel
    Friend WithEvents ts_txt_velocimeter As ToolStripTextBox
    Friend WithEvents tsmi_Instructions As ToolStripMenuItem
    Friend WithEvents timer_time As Timer
    Friend WithEvents txt_time As TextBox
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents pan_sea As Panel
    Friend WithEvents pic_cg_ship As PictureBox
    Friend WithEvents timer_cg_ship As Timer
    Friend WithEvents ts_lbl_points As ToolStripLabel
End Class
