namespace MIDTERM
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.plant_btn = new FontAwesome.Sharp.IconButton();
            this.user_btn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logo_picBox = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize_picBox = new FontAwesome.Sharp.IconPictureBox();
            this.maximize_picBox = new FontAwesome.Sharp.IconPictureBox();
            this.exit_picBox = new FontAwesome.Sharp.IconPictureBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.home_picBox = new FontAwesome.Sharp.IconPictureBox();
            this.shadow_panel = new System.Windows.Forms.Panel();
            this.subForm_panel = new System.Windows.Forms.Panel();
            this.currentDate_lbl = new System.Windows.Forms.Label();
            this.currentTime_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_picBox)).BeginInit();
            this.subForm_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.plant_btn);
            this.panelMenu.Controls.Add(this.user_btn);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(264, 794);
            this.panelMenu.TabIndex = 21;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // plant_btn
            // 
            this.plant_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.plant_btn.FlatAppearance.BorderSize = 0;
            this.plant_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plant_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plant_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.plant_btn.IconChar = FontAwesome.Sharp.IconChar.Tree;
            this.plant_btn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.plant_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.plant_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plant_btn.Location = new System.Drawing.Point(0, 210);
            this.plant_btn.Name = "plant_btn";
            this.plant_btn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.plant_btn.Size = new System.Drawing.Size(264, 72);
            this.plant_btn.TabIndex = 4;
            this.plant_btn.Text = "Plants";
            this.plant_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plant_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.plant_btn.UseVisualStyleBackColor = true;
            this.plant_btn.Click += new System.EventHandler(this.iconButton3_Click);
            this.plant_btn.MouseEnter += new System.EventHandler(this.plant_btn_MouseEnter);
            this.plant_btn.MouseLeave += new System.EventHandler(this.plant_btn_MouseLeave);
            // 
            // user_btn
            // 
            this.user_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_btn.FlatAppearance.BorderSize = 0;
            this.user_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.user_btn.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.user_btn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.user_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.user_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_btn.Location = new System.Drawing.Point(0, 138);
            this.user_btn.Name = "user_btn";
            this.user_btn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.user_btn.Size = new System.Drawing.Size(264, 72);
            this.user_btn.TabIndex = 2;
            this.user_btn.Text = "User";
            this.user_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.user_btn.UseVisualStyleBackColor = true;
            this.user_btn.Click += new System.EventHandler(this.iconButton1_Click);
            this.user_btn.MouseEnter += new System.EventHandler(this.user_btn_MouseEnter);
            this.user_btn.MouseLeave += new System.EventHandler(this.user_btn_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.logo_picBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 138);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // logo_picBox
            // 
            this.logo_picBox.Image = global::MIDTERM.Properties.Resources.Logo;
            this.logo_picBox.Location = new System.Drawing.Point(-16, -8);
            this.logo_picBox.Name = "logo_picBox";
            this.logo_picBox.Size = new System.Drawing.Size(277, 157);
            this.logo_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_picBox.TabIndex = 0;
            this.logo_picBox.TabStop = false;
            this.logo_picBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.minimize_picBox);
            this.panel1.Controls.Add(this.maximize_picBox);
            this.panel1.Controls.Add(this.exit_picBox);
            this.panel1.Controls.Add(this.title_lbl);
            this.panel1.Controls.Add(this.home_picBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(264, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 80);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // minimize_picBox
            // 
            this.minimize_picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_picBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.minimize_picBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.minimize_picBox.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimize_picBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.minimize_picBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize_picBox.IconSize = 28;
            this.minimize_picBox.Location = new System.Drawing.Point(1113, 12);
            this.minimize_picBox.Name = "minimize_picBox";
            this.minimize_picBox.Size = new System.Drawing.Size(28, 42);
            this.minimize_picBox.TabIndex = 4;
            this.minimize_picBox.TabStop = false;
            this.minimize_picBox.Click += new System.EventHandler(this.iconPictureBox4_Click);
            // 
            // maximize_picBox
            // 
            this.maximize_picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_picBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.maximize_picBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.maximize_picBox.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.maximize_picBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.maximize_picBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximize_picBox.IconSize = 28;
            this.maximize_picBox.Location = new System.Drawing.Point(1147, 12);
            this.maximize_picBox.Name = "maximize_picBox";
            this.maximize_picBox.Size = new System.Drawing.Size(28, 42);
            this.maximize_picBox.TabIndex = 3;
            this.maximize_picBox.TabStop = false;
            this.maximize_picBox.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // exit_picBox
            // 
            this.exit_picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_picBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.exit_picBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.exit_picBox.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.exit_picBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.exit_picBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit_picBox.IconSize = 28;
            this.exit_picBox.Location = new System.Drawing.Point(1181, 12);
            this.exit_picBox.Name = "exit_picBox";
            this.exit_picBox.Size = new System.Drawing.Size(28, 42);
            this.exit_picBox.TabIndex = 2;
            this.exit_picBox.TabStop = false;
            this.exit_picBox.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.title_lbl.Location = new System.Drawing.Point(70, 33);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(63, 21);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Home";
            // 
            // home_picBox
            // 
            this.home_picBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.home_picBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.home_picBox.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.home_picBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.home_picBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home_picBox.IconSize = 40;
            this.home_picBox.Location = new System.Drawing.Point(24, 21);
            this.home_picBox.Name = "home_picBox";
            this.home_picBox.Size = new System.Drawing.Size(40, 45);
            this.home_picBox.TabIndex = 0;
            this.home_picBox.TabStop = false;
            // 
            // shadow_panel
            // 
            this.shadow_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shadow_panel.Location = new System.Drawing.Point(264, 80);
            this.shadow_panel.Name = "shadow_panel";
            this.shadow_panel.Size = new System.Drawing.Size(1214, 18);
            this.shadow_panel.TabIndex = 23;
            // 
            // subForm_panel
            // 
            this.subForm_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subForm_panel.Controls.Add(this.currentDate_lbl);
            this.subForm_panel.Controls.Add(this.currentTime_lbl);
            this.subForm_panel.Controls.Add(this.pictureBox1);
            this.subForm_panel.Location = new System.Drawing.Point(264, 98);
            this.subForm_panel.Name = "subForm_panel";
            this.subForm_panel.Size = new System.Drawing.Size(1214, 696);
            this.subForm_panel.TabIndex = 24;
            this.subForm_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.subForm_panel_Paint);
            // 
            // currentDate_lbl
            // 
            this.currentDate_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentDate_lbl.AutoSize = true;
            this.currentDate_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(141)))), ((int)(((byte)(177)))));
            this.currentDate_lbl.Location = new System.Drawing.Point(449, 420);
            this.currentDate_lbl.Name = "currentDate_lbl";
            this.currentDate_lbl.Size = new System.Drawing.Size(162, 30);
            this.currentDate_lbl.TabIndex = 3;
            this.currentDate_lbl.Text = "current Date";
            this.currentDate_lbl.Click += new System.EventHandler(this.currentDate_lbl_Click);
            // 
            // currentTime_lbl
            // 
            this.currentTime_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentTime_lbl.AutoSize = true;
            this.currentTime_lbl.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(43)))), ((int)(((byte)(203)))));
            this.currentTime_lbl.Location = new System.Drawing.Point(468, 354);
            this.currentTime_lbl.Name = "currentTime_lbl";
            this.currentTime_lbl.Size = new System.Drawing.Size(371, 66);
            this.currentTime_lbl.TabIndex = 2;
            this.currentTime_lbl.Text = "Current Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MIDTERM.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(176, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserForm_2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1478, 794);
            this.ControlBox = false;
            this.Controls.Add(this.subForm_panel);
            this.Controls.Add(this.shadow_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserForm_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.User_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_picBox)).EndInit();
            this.subForm_panel.ResumeLayout(false);
            this.subForm_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton user_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton plant_btn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox home_picBox;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox logo_picBox;
        private FontAwesome.Sharp.IconPictureBox minimize_picBox;
        private FontAwesome.Sharp.IconPictureBox maximize_picBox;
        private FontAwesome.Sharp.IconPictureBox exit_picBox;
        private System.Windows.Forms.Panel subForm_panel;
        private System.Windows.Forms.Panel shadow_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label currentTime_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currentDate_lbl;
    }
}

