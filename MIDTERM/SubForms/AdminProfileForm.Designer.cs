namespace MIDTERM
{
    partial class AdminProfileForm
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
            this.avatarPanel = new System.Windows.Forms.Panel();
            this.userNamePanel = new System.Windows.Forms.Panel();
            this.client_lbl = new System.Windows.Forms.Label();
            this.userFullName_lbl = new System.Windows.Forms.Label();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.addressValue_lbl = new System.Windows.Forms.Label();
            this.genderValue_lbl = new System.Windows.Forms.Label();
            this.dateOfBirthValue_lbl = new System.Windows.Forms.Label();
            this.phoneValue_lbl = new System.Windows.Forms.Label();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.address_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.dateOfBirth_lbl = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userNamePanel.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarPanel
            // 
            this.avatarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.avatarPanel.Location = new System.Drawing.Point(0, 0);
            this.avatarPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avatarPanel.Name = "avatarPanel";
            this.avatarPanel.Size = new System.Drawing.Size(158, 416);
            this.avatarPanel.TabIndex = 0;
            this.avatarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.avatarPanel_Paint);
            // 
            // userNamePanel
            // 
            this.userNamePanel.Controls.Add(this.client_lbl);
            this.userNamePanel.Controls.Add(this.userFullName_lbl);
            this.userNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userNamePanel.Location = new System.Drawing.Point(158, 0);
            this.userNamePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userNamePanel.Name = "userNamePanel";
            this.userNamePanel.Size = new System.Drawing.Size(637, 125);
            this.userNamePanel.TabIndex = 1;
            // 
            // client_lbl
            // 
            this.client_lbl.AutoSize = true;
            this.client_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_lbl.Location = new System.Drawing.Point(195, 97);
            this.client_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.client_lbl.Name = "client_lbl";
            this.client_lbl.Size = new System.Drawing.Size(47, 17);
            this.client_lbl.TabIndex = 1;
            this.client_lbl.Text = "Admin";
            // 
            // userFullName_lbl
            // 
            this.userFullName_lbl.AutoSize = true;
            this.userFullName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFullName_lbl.Location = new System.Drawing.Point(13, 78);
            this.userFullName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userFullName_lbl.Name = "userFullName_lbl";
            this.userFullName_lbl.Size = new System.Drawing.Size(196, 26);
            this.userFullName_lbl.TabIndex = 0;
            this.userFullName_lbl.Text = "Admin Full Name";
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.Controls.Add(this.addressValue_lbl);
            this.userInfoPanel.Controls.Add(this.genderValue_lbl);
            this.userInfoPanel.Controls.Add(this.dateOfBirthValue_lbl);
            this.userInfoPanel.Controls.Add(this.phoneValue_lbl);
            this.userInfoPanel.Controls.Add(this.iconPictureBox6);
            this.userInfoPanel.Controls.Add(this.iconPictureBox5);
            this.userInfoPanel.Controls.Add(this.iconPictureBox4);
            this.userInfoPanel.Controls.Add(this.iconPictureBox2);
            this.userInfoPanel.Controls.Add(this.address_lbl);
            this.userInfoPanel.Controls.Add(this.gender_lbl);
            this.userInfoPanel.Controls.Add(this.dateOfBirth_lbl);
            this.userInfoPanel.Controls.Add(this.phone_lbl);
            this.userInfoPanel.Controls.Add(this.label2);
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userInfoPanel.Location = new System.Drawing.Point(158, 138);
            this.userInfoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(637, 278);
            this.userInfoPanel.TabIndex = 2;
            this.userInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addressValue_lbl
            // 
            this.addressValue_lbl.AutoSize = true;
            this.addressValue_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressValue_lbl.Location = new System.Drawing.Point(127, 99);
            this.addressValue_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressValue_lbl.Name = "addressValue_lbl";
            this.addressValue_lbl.Size = new System.Drawing.Size(64, 17);
            this.addressValue_lbl.TabIndex = 19;
            this.addressValue_lbl.Text = "123 NVK";
            // 
            // genderValue_lbl
            // 
            this.genderValue_lbl.AutoSize = true;
            this.genderValue_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderValue_lbl.Location = new System.Drawing.Point(421, 99);
            this.genderValue_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderValue_lbl.Name = "genderValue_lbl";
            this.genderValue_lbl.Size = new System.Drawing.Size(38, 17);
            this.genderValue_lbl.TabIndex = 18;
            this.genderValue_lbl.Text = "Male";
            // 
            // dateOfBirthValue_lbl
            // 
            this.dateOfBirthValue_lbl.AutoSize = true;
            this.dateOfBirthValue_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthValue_lbl.Location = new System.Drawing.Point(450, 45);
            this.dateOfBirthValue_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOfBirthValue_lbl.Name = "dateOfBirthValue_lbl";
            this.dateOfBirthValue_lbl.Size = new System.Drawing.Size(80, 17);
            this.dateOfBirthValue_lbl.TabIndex = 17;
            this.dateOfBirthValue_lbl.Text = "11/11/2011";
            // 
            // phoneValue_lbl
            // 
            this.phoneValue_lbl.AutoSize = true;
            this.phoneValue_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneValue_lbl.Location = new System.Drawing.Point(117, 45);
            this.phoneValue_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneValue_lbl.Name = "phoneValue_lbl";
            this.phoneValue_lbl.Size = new System.Drawing.Size(40, 17);
            this.phoneValue_lbl.TabIndex = 15;
            this.phoneValue_lbl.Text = "4321";
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox6.ForeColor = System.Drawing.Color.Teal;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Archway;
            this.iconPictureBox6.IconColor = System.Drawing.Color.Teal;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 28;
            this.iconPictureBox6.Location = new System.Drawing.Point(28, 93);
            this.iconPictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(29, 28);
            this.iconPictureBox6.TabIndex = 14;
            this.iconPictureBox6.TabStop = false;
            this.iconPictureBox6.Click += new System.EventHandler(this.iconPictureBox6_Click);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.SandyBrown;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Genderless;
            this.iconPictureBox5.IconColor = System.Drawing.Color.SandyBrown;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 28;
            this.iconPictureBox5.Location = new System.Drawing.Point(322, 92);
            this.iconPictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(29, 28);
            this.iconPictureBox5.TabIndex = 13;
            this.iconPictureBox5.TabStop = false;
            this.iconPictureBox5.Click += new System.EventHandler(this.iconPictureBox5_Click);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Atom;
            this.iconPictureBox4.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 28;
            this.iconPictureBox4.Location = new System.Drawing.Point(322, 37);
            this.iconPictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(29, 28);
            this.iconPictureBox4.TabIndex = 12;
            this.iconPictureBox4.TabStop = false;
            this.iconPictureBox4.Click += new System.EventHandler(this.iconPictureBox4_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconPictureBox2.IconColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 28;
            this.iconPictureBox2.Location = new System.Drawing.Point(28, 37);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(29, 28);
            this.iconPictureBox2.TabIndex = 10;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lbl.Location = new System.Drawing.Point(57, 99);
            this.address_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(76, 17);
            this.address_lbl.TabIndex = 7;
            this.address_lbl.Text = "Admin_ID";
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lbl.Location = new System.Drawing.Point(351, 99);
            this.gender_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(62, 17);
            this.gender_lbl.TabIndex = 6;
            this.gender_lbl.Text = "Gender";
            // 
            // dateOfBirth_lbl
            // 
            this.dateOfBirth_lbl.AutoSize = true;
            this.dateOfBirth_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth_lbl.Location = new System.Drawing.Point(351, 45);
            this.dateOfBirth_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOfBirth_lbl.Name = "dateOfBirth_lbl";
            this.dateOfBirth_lbl.Size = new System.Drawing.Size(101, 17);
            this.dateOfBirth_lbl.TabIndex = 5;
            this.dateOfBirth_lbl.Text = "Date-of-birth";
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lbl.Location = new System.Drawing.Point(57, 45);
            this.phone_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(49, 17);
            this.phone_lbl.TabIndex = 4;
            this.phone_lbl.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(158, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 13);
            this.panel2.TabIndex = 3;
            // 
            // AdminProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 416);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.userInfoPanel);
            this.Controls.Add(this.userNamePanel);
            this.Controls.Add(this.avatarPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminProfileForm";
            this.Text = "AdminProfileForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.userNamePanel.ResumeLayout(false);
            this.userNamePanel.PerformLayout();
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel avatarPanel;
        private System.Windows.Forms.Panel userNamePanel;
        private System.Windows.Forms.Label client_lbl;
        private System.Windows.Forms.Label userFullName_lbl;
        private System.Windows.Forms.Panel userInfoPanel;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Label dateOfBirth_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label addressValue_lbl;
        private System.Windows.Forms.Label genderValue_lbl;
        private System.Windows.Forms.Label dateOfBirthValue_lbl;
        private System.Windows.Forms.Label phoneValue_lbl;
    }
}