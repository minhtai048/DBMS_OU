namespace MIDTERM
{
    partial class UserCRUD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.user_dataview = new System.Windows.Forms.DataGridView();
            this.uSERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qTHCSDL_LAB3DataSet = new MIDTERM.QTHCSDL_LAB3DataSet();
            this.dateOfBirth_picker = new System.Windows.Forms.DateTimePicker();
            this.gender_comboBx = new System.Windows.Forms.ComboBox();
            this.address_txtBox = new System.Windows.Forms.TextBox();
            this.username_txtBox = new System.Windows.Forms.TextBox();
            this.national_id_txtBx = new System.Windows.Forms.TextBox();
            this.dateOfBirth_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.uSERINFOTableAdapter = new MIDTERM.QTHCSDL_LAB3DataSetTableAdapters.USERINFOTableAdapter();
            this.searching_txtBx = new System.Windows.Forms.TextBox();
            this.searchTitle_lbl = new System.Windows.Forms.Label();
            this.searching_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.fullname_txtBox = new System.Windows.Forms.TextBox();
            this.fullname_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTHCSDL_LAB3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // user_dataview
            // 
            this.user_dataview.AllowUserToAddRows = false;
            this.user_dataview.AllowUserToDeleteRows = false;
            this.user_dataview.BackgroundColor = System.Drawing.Color.White;
            this.user_dataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.user_dataview.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.user_dataview.DefaultCellStyle = dataGridViewCellStyle2;
            this.user_dataview.EnableHeadersVisualStyles = false;
            this.user_dataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.user_dataview.Location = new System.Drawing.Point(12, 104);
            this.user_dataview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_dataview.Name = "user_dataview";
            this.user_dataview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_dataview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.user_dataview.RowHeadersVisible = false;
            this.user_dataview.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.user_dataview.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.user_dataview.RowTemplate.Height = 50;
            this.user_dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_dataview.Size = new System.Drawing.Size(807, 524);
            this.user_dataview.TabIndex = 31;
            this.user_dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_dataview_CellContentClick);
            // 
            // uSERINFOBindingSource
            // 
            this.uSERINFOBindingSource.DataMember = "USERINFO";
            this.uSERINFOBindingSource.DataSource = this.qTHCSDL_LAB3DataSet;
            // 
            // qTHCSDL_LAB3DataSet
            // 
            this.qTHCSDL_LAB3DataSet.DataSetName = "QTHCSDL_LAB3DataSet";
            this.qTHCSDL_LAB3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateOfBirth_picker
            // 
            this.dateOfBirth_picker.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth_picker.Location = new System.Drawing.Point(999, 415);
            this.dateOfBirth_picker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateOfBirth_picker.Name = "dateOfBirth_picker";
            this.dateOfBirth_picker.Size = new System.Drawing.Size(182, 42);
            this.dateOfBirth_picker.TabIndex = 30;
            // 
            // gender_comboBx
            // 
            this.gender_comboBx.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_comboBx.FormattingEnabled = true;
            this.gender_comboBx.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_comboBx.Location = new System.Drawing.Point(999, 306);
            this.gender_comboBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gender_comboBx.Name = "gender_comboBx";
            this.gender_comboBx.Size = new System.Drawing.Size(121, 42);
            this.gender_comboBx.TabIndex = 29;
            // 
            // address_txtBox
            // 
            this.address_txtBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_txtBox.Location = new System.Drawing.Point(999, 366);
            this.address_txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_txtBox.Name = "address_txtBox";
            this.address_txtBox.Size = new System.Drawing.Size(100, 32);
            this.address_txtBox.TabIndex = 28;
            // 
            // username_txtBox
            // 
            this.username_txtBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txtBox.Location = new System.Drawing.Point(999, 208);
            this.username_txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_txtBox.Name = "username_txtBox";
            this.username_txtBox.Size = new System.Drawing.Size(100, 32);
            this.username_txtBox.TabIndex = 27;
            // 
            // national_id_txtBx
            // 
            this.national_id_txtBx.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.national_id_txtBx.Location = new System.Drawing.Point(999, 102);
            this.national_id_txtBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.national_id_txtBx.Name = "national_id_txtBx";
            this.national_id_txtBx.Size = new System.Drawing.Size(100, 32);
            this.national_id_txtBx.TabIndex = 26;
            // 
            // dateOfBirth_lbl
            // 
            this.dateOfBirth_lbl.AutoSize = true;
            this.dateOfBirth_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth_lbl.Location = new System.Drawing.Point(826, 421);
            this.dateOfBirth_lbl.Name = "dateOfBirth_lbl";
            this.dateOfBirth_lbl.Size = new System.Drawing.Size(137, 23);
            this.dateOfBirth_lbl.TabIndex = 25;
            this.dateOfBirth_lbl.Text = "Date of birth:";
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lbl.Location = new System.Drawing.Point(826, 372);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(93, 23);
            this.address_lbl.TabIndex = 24;
            this.address_lbl.Text = "Address:";
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lbl.Location = new System.Drawing.Point(826, 312);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(90, 23);
            this.gender_lbl.TabIndex = 23;
            this.gender_lbl.Text = "Gender:";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(826, 211);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(113, 23);
            this.username_lbl.TabIndex = 22;
            this.username_lbl.Text = "Username:";
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(826, 104);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(124, 23);
            this.id_lbl.TabIndex = 21;
            this.id_lbl.Text = "National ID:";
            // 
            // uSERINFOTableAdapter
            // 
            this.uSERINFOTableAdapter.ClearBeforeFill = true;
            // 
            // searching_txtBx
            // 
            this.searching_txtBx.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searching_txtBx.Location = new System.Drawing.Point(12, 38);
            this.searching_txtBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searching_txtBx.Name = "searching_txtBx";
            this.searching_txtBx.Size = new System.Drawing.Size(807, 47);
            this.searching_txtBx.TabIndex = 1;
            // 
            // searchTitle_lbl
            // 
            this.searchTitle_lbl.AutoSize = true;
            this.searchTitle_lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchTitle_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle_lbl.Location = new System.Drawing.Point(0, 0);
            this.searchTitle_lbl.Name = "searchTitle_lbl";
            this.searchTitle_lbl.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.searchTitle_lbl.Size = new System.Drawing.Size(236, 33);
            this.searchTitle_lbl.TabIndex = 0;
            this.searchTitle_lbl.Text = "Search by national ID:";
            // 
            // searching_btn
            // 
            this.searching_btn.AutoSize = true;
            this.searching_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.searching_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searching_btn.ForeColor = System.Drawing.Color.Black;
            this.searching_btn.Location = new System.Drawing.Point(848, 38);
            this.searching_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searching_btn.Name = "searching_btn";
            this.searching_btn.Size = new System.Drawing.Size(115, 40);
            this.searching_btn.TabIndex = 37;
            this.searching_btn.Text = "Search";
            this.searching_btn.UseVisualStyleBackColor = false;
            this.searching_btn.Click += new System.EventHandler(this.searching_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.AutoSize = true;
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.add_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Black;
            this.add_btn.Location = new System.Drawing.Point(881, 499);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(115, 40);
            this.add_btn.TabIndex = 38;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.AutoSize = true;
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.update_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(1019, 499);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(115, 40);
            this.update_btn.TabIndex = 39;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.AutoSize = true;
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.delete_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(944, 570);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(115, 40);
            this.delete_btn.TabIndex = 40;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // password_txtBox
            // 
            this.password_txtBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txtBox.Location = new System.Drawing.Point(999, 258);
            this.password_txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.Size = new System.Drawing.Size(100, 32);
            this.password_txtBox.TabIndex = 42;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(826, 261);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(108, 23);
            this.password_lbl.TabIndex = 41;
            this.password_lbl.Text = "Password:";
            // 
            // fullname_txtBox
            // 
            this.fullname_txtBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname_txtBox.Location = new System.Drawing.Point(999, 155);
            this.fullname_txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullname_txtBox.Name = "fullname_txtBox";
            this.fullname_txtBox.Size = new System.Drawing.Size(100, 32);
            this.fullname_txtBox.TabIndex = 44;
            // 
            // fullname_lbl
            // 
            this.fullname_lbl.AutoSize = true;
            this.fullname_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname_lbl.Location = new System.Drawing.Point(826, 156);
            this.fullname_lbl.Name = "fullname_lbl";
            this.fullname_lbl.Size = new System.Drawing.Size(111, 23);
            this.fullname_lbl.TabIndex = 43;
            this.fullname_lbl.Text = "Full name:";
            // 
            // UserCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 640);
            this.Controls.Add(this.fullname_txtBox);
            this.Controls.Add(this.fullname_lbl);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.searching_btn);
            this.Controls.Add(this.searchTitle_lbl);
            this.Controls.Add(this.searching_txtBx);
            this.Controls.Add(this.user_dataview);
            this.Controls.Add(this.dateOfBirth_picker);
            this.Controls.Add(this.gender_comboBx);
            this.Controls.Add(this.address_txtBox);
            this.Controls.Add(this.username_txtBox);
            this.Controls.Add(this.national_id_txtBx);
            this.Controls.Add(this.dateOfBirth_lbl);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.gender_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.id_lbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserCRUD";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTHCSDL_LAB3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView user_dataview;
        private System.Windows.Forms.DateTimePicker dateOfBirth_picker;
        private System.Windows.Forms.ComboBox gender_comboBx;
        private System.Windows.Forms.TextBox address_txtBox;
        private System.Windows.Forms.TextBox username_txtBox;
        private System.Windows.Forms.TextBox national_id_txtBx;
        private System.Windows.Forms.Label dateOfBirth_lbl;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label id_lbl;
        private QTHCSDL_LAB3DataSet qTHCSDL_LAB3DataSet;
        private System.Windows.Forms.BindingSource uSERINFOBindingSource;
        private QTHCSDL_LAB3DataSetTableAdapters.USERINFOTableAdapter uSERINFOTableAdapter;
        private System.Windows.Forms.TextBox searching_txtBx;
        private System.Windows.Forms.Label searchTitle_lbl;
        private System.Windows.Forms.Button searching_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox fullname_txtBox;
        private System.Windows.Forms.Label fullname_lbl;
    }
}