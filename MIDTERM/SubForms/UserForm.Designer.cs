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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.user_dataview = new System.Windows.Forms.DataGridView();
            this.uSERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qTHCSDL_LAB3DataSet = new MIDTERM.QTHCSDL_LAB3DataSet();
            this.dateOfBirth_picker = new System.Windows.Forms.DateTimePicker();
            this.gender_comboBx = new System.Windows.Forms.ComboBox();
            this.phoneNumber_txtBx = new System.Windows.Forms.TextBox();
            this.name_txtBox = new System.Windows.Forms.TextBox();
            this.id_txtBx = new System.Windows.Forms.TextBox();
            this.dateOfBirth_lbl = new System.Windows.Forms.Label();
            this.phoneNumber_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.uSERINFOTableAdapter = new MIDTERM.QTHCSDL_LAB3DataSetTableAdapters.USERINFOTableAdapter();
            this.searching_txtBx = new System.Windows.Forms.TextBox();
            this.searchTitle_lbl = new System.Windows.Forms.Label();
            this.searching_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTHCSDL_LAB3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(697, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 40);
            this.button5.TabIndex = 36;
            this.button5.Text = "Previous";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(572, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 40);
            this.button4.TabIndex = 35;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(427, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 34;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 33;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // user_dataview
            // 
            this.user_dataview.BackgroundColor = System.Drawing.Color.White;
            this.user_dataview.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.user_dataview.Location = new System.Drawing.Point(4, 83);
            this.user_dataview.Name = "user_dataview";
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
            this.user_dataview.Size = new System.Drawing.Size(1176, 690);
            this.user_dataview.TabIndex = 31;
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
            this.dateOfBirth_picker.Location = new System.Drawing.Point(753, 471);
            this.dateOfBirth_picker.Name = "dateOfBirth_picker";
            this.dateOfBirth_picker.Size = new System.Drawing.Size(182, 26);
            this.dateOfBirth_picker.TabIndex = 30;
            this.dateOfBirth_picker.Visible = false;
            // 
            // gender_comboBx
            // 
            this.gender_comboBx.FormattingEnabled = true;
            this.gender_comboBx.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_comboBx.Location = new System.Drawing.Point(261, 535);
            this.gender_comboBx.Name = "gender_comboBx";
            this.gender_comboBx.Size = new System.Drawing.Size(121, 28);
            this.gender_comboBx.TabIndex = 29;
            this.gender_comboBx.Visible = false;
            // 
            // phoneNumber_txtBx
            // 
            this.phoneNumber_txtBx.Location = new System.Drawing.Point(753, 396);
            this.phoneNumber_txtBx.Name = "phoneNumber_txtBx";
            this.phoneNumber_txtBx.Size = new System.Drawing.Size(100, 26);
            this.phoneNumber_txtBx.TabIndex = 28;
            this.phoneNumber_txtBx.Visible = false;
            // 
            // name_txtBox
            // 
            this.name_txtBox.Location = new System.Drawing.Point(261, 460);
            this.name_txtBox.Name = "name_txtBox";
            this.name_txtBox.Size = new System.Drawing.Size(100, 26);
            this.name_txtBox.TabIndex = 27;
            this.name_txtBox.Visible = false;
            // 
            // id_txtBx
            // 
            this.id_txtBx.Location = new System.Drawing.Point(261, 390);
            this.id_txtBx.Name = "id_txtBx";
            this.id_txtBx.Size = new System.Drawing.Size(100, 26);
            this.id_txtBx.TabIndex = 26;
            this.id_txtBx.Visible = false;
            // 
            // dateOfBirth_lbl
            // 
            this.dateOfBirth_lbl.AutoSize = true;
            this.dateOfBirth_lbl.Location = new System.Drawing.Point(434, 460);
            this.dateOfBirth_lbl.Name = "dateOfBirth_lbl";
            this.dateOfBirth_lbl.Size = new System.Drawing.Size(101, 20);
            this.dateOfBirth_lbl.TabIndex = 25;
            this.dateOfBirth_lbl.Text = "Date of birth:";
            this.dateOfBirth_lbl.Visible = false;
            // 
            // phoneNumber_lbl
            // 
            this.phoneNumber_lbl.AutoSize = true;
            this.phoneNumber_lbl.Location = new System.Drawing.Point(434, 390);
            this.phoneNumber_lbl.Name = "phoneNumber_lbl";
            this.phoneNumber_lbl.Size = new System.Drawing.Size(117, 20);
            this.phoneNumber_lbl.TabIndex = 24;
            this.phoneNumber_lbl.Text = "Phone number:";
            this.phoneNumber_lbl.Visible = false;
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Location = new System.Drawing.Point(141, 541);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(67, 20);
            this.gender_lbl.TabIndex = 23;
            this.gender_lbl.Text = "Gender:";
            this.gender_lbl.Visible = false;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(141, 460);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(55, 20);
            this.name_lbl.TabIndex = 22;
            this.name_lbl.Text = "Name:";
            this.name_lbl.Visible = false;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(141, 390);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(30, 20);
            this.id_lbl.TabIndex = 21;
            this.id_lbl.Text = "ID:";
            this.id_lbl.Visible = false;
            // 
            // uSERINFOTableAdapter
            // 
            this.uSERINFOTableAdapter.ClearBeforeFill = true;
            // 
            // searching_txtBx
            // 
            this.searching_txtBx.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searching_txtBx.Location = new System.Drawing.Point(12, 37);
            this.searching_txtBx.Name = "searching_txtBx";
            this.searching_txtBx.Size = new System.Drawing.Size(894, 47);
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
            this.searchTitle_lbl.Size = new System.Drawing.Size(93, 33);
            this.searchTitle_lbl.TabIndex = 0;
            this.searchTitle_lbl.Text = "Search:";
            this.searchTitle_lbl.Click += new System.EventHandler(this.searchTitle_lbl_Click);
            // 
            // searching_btn
            // 
            this.searching_btn.AutoSize = true;
            this.searching_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.searching_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searching_btn.ForeColor = System.Drawing.Color.Black;
            this.searching_btn.Location = new System.Drawing.Point(927, 37);
            this.searching_btn.Name = "searching_btn";
            this.searching_btn.Size = new System.Drawing.Size(115, 40);
            this.searching_btn.TabIndex = 37;
            this.searching_btn.Text = "Search";
            this.searching_btn.UseVisualStyleBackColor = false;
            this.searching_btn.Click += new System.EventHandler(this.searching_btn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 640);
            this.Controls.Add(this.searching_btn);
            this.Controls.Add(this.searchTitle_lbl);
            this.Controls.Add(this.searching_txtBx);
            this.Controls.Add(this.user_dataview);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateOfBirth_picker);
            this.Controls.Add(this.gender_comboBx);
            this.Controls.Add(this.phoneNumber_txtBx);
            this.Controls.Add(this.name_txtBox);
            this.Controls.Add(this.id_txtBx);
            this.Controls.Add(this.dateOfBirth_lbl);
            this.Controls.Add(this.phoneNumber_lbl);
            this.Controls.Add(this.gender_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.id_lbl);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qTHCSDL_LAB3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView user_dataview;
        private System.Windows.Forms.DateTimePicker dateOfBirth_picker;
        private System.Windows.Forms.ComboBox gender_comboBx;
        private System.Windows.Forms.TextBox phoneNumber_txtBx;
        private System.Windows.Forms.TextBox name_txtBox;
        private System.Windows.Forms.TextBox id_txtBx;
        private System.Windows.Forms.Label dateOfBirth_lbl;
        private System.Windows.Forms.Label phoneNumber_lbl;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label id_lbl;
        private QTHCSDL_LAB3DataSet qTHCSDL_LAB3DataSet;
        private System.Windows.Forms.BindingSource uSERINFOBindingSource;
        private QTHCSDL_LAB3DataSetTableAdapters.USERINFOTableAdapter uSERINFOTableAdapter;
        private System.Windows.Forms.TextBox searching_txtBx;
        private System.Windows.Forms.Label searchTitle_lbl;
        private System.Windows.Forms.Button searching_btn;
    }
}