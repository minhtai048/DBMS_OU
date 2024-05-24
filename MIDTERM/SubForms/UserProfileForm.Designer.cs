﻿namespace MIDTERM
{
    partial class UserProfileForm
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
            this.userFullName_lbl = new System.Windows.Forms.Label();
            this.client_lbl = new System.Windows.Forms.Label();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.nationalID_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.dateOfBirth_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.numPlants_lbl = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nationIDValue_lbl = new System.Windows.Forms.Label();
            this.phoneValue_lbl = new System.Windows.Forms.Label();
            this.numPlantValue_lbl = new System.Windows.Forms.Label();
            this.dateOfBirthValue_lbl = new System.Windows.Forms.Label();
            this.genderValue_lbl = new System.Windows.Forms.Label();
            this.addressValue_lbl = new System.Windows.Forms.Label();
            this.userNamePanel.SuspendLayout();
            this.userInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarPanel
            // 
            this.avatarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.avatarPanel.Location = new System.Drawing.Point(0, 0);
            this.avatarPanel.Name = "avatarPanel";
            this.avatarPanel.Size = new System.Drawing.Size(236, 640);
            this.avatarPanel.TabIndex = 0;
            this.avatarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.avatarPanel_Paint);
            // 
            // userNamePanel
            // 
            this.userNamePanel.Controls.Add(this.client_lbl);
            this.userNamePanel.Controls.Add(this.userFullName_lbl);
            this.userNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userNamePanel.Location = new System.Drawing.Point(236, 0);
            this.userNamePanel.Name = "userNamePanel";
            this.userNamePanel.Size = new System.Drawing.Size(956, 193);
            this.userNamePanel.TabIndex = 1;
            // 
            // userFullName_lbl
            // 
            this.userFullName_lbl.AutoSize = true;
            this.userFullName_lbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFullName_lbl.Location = new System.Drawing.Point(19, 120);
            this.userFullName_lbl.Name = "userFullName_lbl";
            this.userFullName_lbl.Size = new System.Drawing.Size(244, 38);
            this.userFullName_lbl.TabIndex = 0;
            this.userFullName_lbl.Text = "User Full Name";
            // 
            // client_lbl
            // 
            this.client_lbl.AutoSize = true;
            this.client_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_lbl.Location = new System.Drawing.Point(256, 144);
            this.client_lbl.Name = "client_lbl";
            this.client_lbl.Size = new System.Drawing.Size(66, 23);
            this.client_lbl.TabIndex = 1;
            this.client_lbl.Text = "Client";
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.Controls.Add(this.addressValue_lbl);
            this.userInfoPanel.Controls.Add(this.genderValue_lbl);
            this.userInfoPanel.Controls.Add(this.dateOfBirthValue_lbl);
            this.userInfoPanel.Controls.Add(this.numPlantValue_lbl);
            this.userInfoPanel.Controls.Add(this.phoneValue_lbl);
            this.userInfoPanel.Controls.Add(this.nationIDValue_lbl);
            this.userInfoPanel.Controls.Add(this.iconPictureBox6);
            this.userInfoPanel.Controls.Add(this.iconPictureBox5);
            this.userInfoPanel.Controls.Add(this.iconPictureBox4);
            this.userInfoPanel.Controls.Add(this.iconPictureBox3);
            this.userInfoPanel.Controls.Add(this.iconPictureBox2);
            this.userInfoPanel.Controls.Add(this.iconPictureBox1);
            this.userInfoPanel.Controls.Add(this.numPlants_lbl);
            this.userInfoPanel.Controls.Add(this.address_lbl);
            this.userInfoPanel.Controls.Add(this.gender_lbl);
            this.userInfoPanel.Controls.Add(this.dateOfBirth_lbl);
            this.userInfoPanel.Controls.Add(this.phone_lbl);
            this.userInfoPanel.Controls.Add(this.label2);
            this.userInfoPanel.Controls.Add(this.nationalID_lbl);
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userInfoPanel.Location = new System.Drawing.Point(236, 213);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(956, 427);
            this.userInfoPanel.TabIndex = 2;
            this.userInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nationalID_lbl
            // 
            this.nationalID_lbl.AutoSize = true;
            this.nationalID_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalID_lbl.Location = new System.Drawing.Point(86, 69);
            this.nationalID_lbl.Name = "nationalID_lbl";
            this.nationalID_lbl.Size = new System.Drawing.Size(118, 23);
            this.nationalID_lbl.TabIndex = 2;
            this.nationalID_lbl.Text = "National ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 3;
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lbl.Location = new System.Drawing.Point(86, 153);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(71, 23);
            this.phone_lbl.TabIndex = 4;
            this.phone_lbl.Text = "Phone";
            // 
            // dateOfBirth_lbl
            // 
            this.dateOfBirth_lbl.AutoSize = true;
            this.dateOfBirth_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth_lbl.Location = new System.Drawing.Point(527, 69);
            this.dateOfBirth_lbl.Name = "dateOfBirth_lbl";
            this.dateOfBirth_lbl.Size = new System.Drawing.Size(133, 23);
            this.dateOfBirth_lbl.TabIndex = 5;
            this.dateOfBirth_lbl.Text = "Date-of-birth";
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lbl.Location = new System.Drawing.Point(527, 153);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(84, 23);
            this.gender_lbl.TabIndex = 6;
            this.gender_lbl.Text = "Gender";
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lbl.Location = new System.Drawing.Point(527, 238);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(88, 23);
            this.address_lbl.TabIndex = 7;
            this.address_lbl.Text = "Address";
            // 
            // numPlants_lbl
            // 
            this.numPlants_lbl.AutoSize = true;
            this.numPlants_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPlants_lbl.Location = new System.Drawing.Point(86, 238);
            this.numPlants_lbl.Name = "numPlants_lbl";
            this.numPlants_lbl.Size = new System.Drawing.Size(177, 23);
            this.numPlants_lbl.TabIndex = 8;
            this.numPlants_lbl.Text = "Number of plants";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(42, 58);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(44, 44);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconPictureBox2.IconColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 44;
            this.iconPictureBox2.Location = new System.Drawing.Point(42, 141);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(44, 44);
            this.iconPictureBox2.TabIndex = 10;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PlantWilt;
            this.iconPictureBox3.IconColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 44;
            this.iconPictureBox3.Location = new System.Drawing.Point(42, 227);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(44, 44);
            this.iconPictureBox3.TabIndex = 11;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Atom;
            this.iconPictureBox4.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 44;
            this.iconPictureBox4.Location = new System.Drawing.Point(483, 58);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(44, 44);
            this.iconPictureBox4.TabIndex = 12;
            this.iconPictureBox4.TabStop = false;
            this.iconPictureBox4.Click += new System.EventHandler(this.iconPictureBox4_Click);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.SandyBrown;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Genderless;
            this.iconPictureBox5.IconColor = System.Drawing.Color.SandyBrown;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 44;
            this.iconPictureBox5.Location = new System.Drawing.Point(483, 141);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(44, 44);
            this.iconPictureBox5.TabIndex = 13;
            this.iconPictureBox5.TabStop = false;
            this.iconPictureBox5.Click += new System.EventHandler(this.iconPictureBox5_Click);
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox6.ForeColor = System.Drawing.Color.Teal;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Archway;
            this.iconPictureBox6.IconColor = System.Drawing.Color.Teal;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 44;
            this.iconPictureBox6.Location = new System.Drawing.Point(483, 227);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(44, 44);
            this.iconPictureBox6.TabIndex = 14;
            this.iconPictureBox6.TabStop = false;
            this.iconPictureBox6.Click += new System.EventHandler(this.iconPictureBox6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(236, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 20);
            this.panel2.TabIndex = 3;
            // 
            // nationIDValue_lbl
            // 
            this.nationIDValue_lbl.AutoSize = true;
            this.nationIDValue_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationIDValue_lbl.Location = new System.Drawing.Point(226, 69);
            this.nationIDValue_lbl.Name = "nationIDValue_lbl";
            this.nationIDValue_lbl.Size = new System.Drawing.Size(54, 23);
            this.nationIDValue_lbl.TabIndex = 2;
            this.nationIDValue_lbl.Text = "1234";
            // 
            // phoneValue_lbl
            // 
            this.phoneValue_lbl.AutoSize = true;
            this.phoneValue_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneValue_lbl.Location = new System.Drawing.Point(176, 153);
            this.phoneValue_lbl.Name = "phoneValue_lbl";
            this.phoneValue_lbl.Size = new System.Drawing.Size(54, 23);
            this.phoneValue_lbl.TabIndex = 15;
            this.phoneValue_lbl.Text = "4321";
            // 
            // numPlantValue_lbl
            // 
            this.numPlantValue_lbl.AutoSize = true;
            this.numPlantValue_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPlantValue_lbl.Location = new System.Drawing.Point(278, 238);
            this.numPlantValue_lbl.Name = "numPlantValue_lbl";
            this.numPlantValue_lbl.Size = new System.Drawing.Size(32, 23);
            this.numPlantValue_lbl.TabIndex = 16;
            this.numPlantValue_lbl.Text = "12";
            // 
            // dateOfBirthValue_lbl
            // 
            this.dateOfBirthValue_lbl.AutoSize = true;
            this.dateOfBirthValue_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthValue_lbl.Location = new System.Drawing.Point(675, 69);
            this.dateOfBirthValue_lbl.Name = "dateOfBirthValue_lbl";
            this.dateOfBirthValue_lbl.Size = new System.Drawing.Size(116, 23);
            this.dateOfBirthValue_lbl.TabIndex = 17;
            this.dateOfBirthValue_lbl.Text = "11/11/2011";
            // 
            // genderValue_lbl
            // 
            this.genderValue_lbl.AutoSize = true;
            this.genderValue_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderValue_lbl.Location = new System.Drawing.Point(631, 153);
            this.genderValue_lbl.Name = "genderValue_lbl";
            this.genderValue_lbl.Size = new System.Drawing.Size(59, 23);
            this.genderValue_lbl.TabIndex = 18;
            this.genderValue_lbl.Text = "Male";
            // 
            // addressValue_lbl
            // 
            this.addressValue_lbl.AutoSize = true;
            this.addressValue_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressValue_lbl.Location = new System.Drawing.Point(631, 238);
            this.addressValue_lbl.Name = "addressValue_lbl";
            this.addressValue_lbl.Size = new System.Drawing.Size(91, 23);
            this.addressValue_lbl.TabIndex = 19;
            this.addressValue_lbl.Text = "123 NVK";
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.userInfoPanel);
            this.Controls.Add(this.userNamePanel);
            this.Controls.Add(this.avatarPanel);
            this.Name = "UserProfileForm";
            this.Text = "UserProfileForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.userNamePanel.ResumeLayout(false);
            this.userNamePanel.PerformLayout();
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
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
        private System.Windows.Forms.Label nationalID_lbl;
        private System.Windows.Forms.Label numPlants_lbl;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label addressValue_lbl;
        private System.Windows.Forms.Label genderValue_lbl;
        private System.Windows.Forms.Label dateOfBirthValue_lbl;
        private System.Windows.Forms.Label numPlantValue_lbl;
        private System.Windows.Forms.Label phoneValue_lbl;
        private System.Windows.Forms.Label nationIDValue_lbl;
    }
}