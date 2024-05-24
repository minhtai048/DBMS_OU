namespace MIDTERM
{
    partial class PlantsOfUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.searchTitle_lbl = new System.Windows.Forms.Label();
            this.uSERINFOTableAdapter = new MIDTERM.QTHCSDL_LAB3DataSetTableAdapters.USERINFOTableAdapter();
            this.searching_txtBx = new System.Windows.Forms.TextBox();
            this.plantName_txtBox = new System.Windows.Forms.TextBox();
            this.water_lbl = new System.Windows.Forms.Label();
            this.temperature_lbl = new System.Windows.Forms.Label();
            this.plantName_lbl = new System.Windows.Forms.Label();
            this.qTHCSDL_LAB3DataSet = new MIDTERM.QTHCSDL_LAB3DataSet();
            this.uSERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plant_dataview = new System.Windows.Forms.DataGridView();
            this.water_txtBx = new System.Windows.Forms.TextBox();
            this.fertilizer_lbl = new System.Windows.Forms.Label();
            this.fertilizer_txtBox = new System.Windows.Forms.TextBox();
            this.temperature_txtBox = new System.Windows.Forms.TextBox();
            this.plantAdd_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qTHCSDL_LAB3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plant_dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.AutoSize = true;
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(1010, 341);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(102, 32);
            this.delete_btn.TabIndex = 57;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.AutoSize = true;
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Black;
            this.add_btn.Location = new System.Drawing.Point(1010, 469);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(102, 32);
            this.add_btn.TabIndex = 55;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.AutoSize = true;
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Location = new System.Drawing.Point(759, 34);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(102, 32);
            this.search_btn.TabIndex = 54;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // searchTitle_lbl
            // 
            this.searchTitle_lbl.AutoSize = true;
            this.searchTitle_lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchTitle_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle_lbl.Location = new System.Drawing.Point(0, 0);
            this.searchTitle_lbl.Name = "searchTitle_lbl";
            this.searchTitle_lbl.Padding = new System.Windows.Forms.Padding(9, 8, 0, 0);
            this.searchTitle_lbl.Size = new System.Drawing.Size(208, 29);
            this.searchTitle_lbl.TabIndex = 41;
            this.searchTitle_lbl.Text = "Search by plant name:";
            // 
            // uSERINFOTableAdapter
            // 
            this.uSERINFOTableAdapter.ClearBeforeFill = true;
            // 
            // searching_txtBx
            // 
            this.searching_txtBx.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searching_txtBx.Location = new System.Drawing.Point(16, 34);
            this.searching_txtBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searching_txtBx.Name = "searching_txtBx";
            this.searching_txtBx.Size = new System.Drawing.Size(718, 40);
            this.searching_txtBx.TabIndex = 42;
            // 
            // plantName_txtBox
            // 
            this.plantName_txtBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantName_txtBox.Location = new System.Drawing.Point(892, 108);
            this.plantName_txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plantName_txtBox.Name = "plantName_txtBox";
            this.plantName_txtBox.ReadOnly = true;
            this.plantName_txtBox.Size = new System.Drawing.Size(220, 28);
            this.plantName_txtBox.TabIndex = 49;
            // 
            // water_lbl
            // 
            this.water_lbl.AutoSize = true;
            this.water_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water_lbl.Location = new System.Drawing.Point(739, 233);
            this.water_lbl.Name = "water_lbl";
            this.water_lbl.Size = new System.Drawing.Size(242, 21);
            this.water_lbl.TabIndex = 46;
            this.water_lbl.Text = "Recommended water level:";
            // 
            // temperature_lbl
            // 
            this.temperature_lbl.AutoSize = true;
            this.temperature_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature_lbl.Location = new System.Drawing.Point(739, 176);
            this.temperature_lbl.Name = "temperature_lbl";
            this.temperature_lbl.Size = new System.Drawing.Size(255, 21);
            this.temperature_lbl.TabIndex = 45;
            this.temperature_lbl.Text = "Recommended temperature:";
            this.temperature_lbl.Click += new System.EventHandler(this.gender_lbl_Click);
            // 
            // plantName_lbl
            // 
            this.plantName_lbl.AutoSize = true;
            this.plantName_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantName_lbl.Location = new System.Drawing.Point(739, 111);
            this.plantName_lbl.Name = "plantName_lbl";
            this.plantName_lbl.Size = new System.Drawing.Size(113, 21);
            this.plantName_lbl.TabIndex = 44;
            this.plantName_lbl.Text = "Plant Name:";
            // 
            // qTHCSDL_LAB3DataSet
            // 
            this.qTHCSDL_LAB3DataSet.DataSetName = "QTHCSDL_LAB3DataSet";
            this.qTHCSDL_LAB3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERINFOBindingSource
            // 
            this.uSERINFOBindingSource.DataMember = "USERINFO";
            this.uSERINFOBindingSource.DataSource = this.qTHCSDL_LAB3DataSet;
            // 
            // plant_dataview
            // 
            this.plant_dataview.BackgroundColor = System.Drawing.Color.White;
            this.plant_dataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plant_dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.plant_dataview.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.plant_dataview.DefaultCellStyle = dataGridViewCellStyle6;
            this.plant_dataview.EnableHeadersVisualStyles = false;
            this.plant_dataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.plant_dataview.Location = new System.Drawing.Point(16, 88);
            this.plant_dataview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plant_dataview.Name = "plant_dataview";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plant_dataview.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.plant_dataview.RowHeadersVisible = false;
            this.plant_dataview.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.plant_dataview.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.plant_dataview.RowTemplate.Height = 50;
            this.plant_dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plant_dataview.Size = new System.Drawing.Size(717, 419);
            this.plant_dataview.TabIndex = 53;
            this.plant_dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plant_dataview_CellContentClick);
            // 
            // water_txtBx
            // 
            this.water_txtBx.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water_txtBx.Location = new System.Drawing.Point(1023, 230);
            this.water_txtBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.water_txtBx.Name = "water_txtBx";
            this.water_txtBx.ReadOnly = true;
            this.water_txtBx.Size = new System.Drawing.Size(89, 28);
            this.water_txtBx.TabIndex = 50;
            // 
            // fertilizer_lbl
            // 
            this.fertilizer_lbl.AutoSize = true;
            this.fertilizer_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fertilizer_lbl.Location = new System.Drawing.Point(739, 289);
            this.fertilizer_lbl.Name = "fertilizer_lbl";
            this.fertilizer_lbl.Size = new System.Drawing.Size(258, 21);
            this.fertilizer_lbl.TabIndex = 47;
            this.fertilizer_lbl.Text = "Recommended fertilizer Level:";
            // 
            // fertilizer_txtBox
            // 
            this.fertilizer_txtBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fertilizer_txtBox.Location = new System.Drawing.Point(1023, 282);
            this.fertilizer_txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fertilizer_txtBox.Name = "fertilizer_txtBox";
            this.fertilizer_txtBox.ReadOnly = true;
            this.fertilizer_txtBox.Size = new System.Drawing.Size(89, 28);
            this.fertilizer_txtBox.TabIndex = 58;
            // 
            // temperature_txtBox
            // 
            this.temperature_txtBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature_txtBox.Location = new System.Drawing.Point(1023, 173);
            this.temperature_txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.temperature_txtBox.Name = "temperature_txtBox";
            this.temperature_txtBox.ReadOnly = true;
            this.temperature_txtBox.Size = new System.Drawing.Size(89, 28);
            this.temperature_txtBox.TabIndex = 59;
            // 
            // plantAdd_txtBox
            // 
            this.plantAdd_txtBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantAdd_txtBox.Location = new System.Drawing.Point(892, 416);
            this.plantAdd_txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plantAdd_txtBox.Name = "plantAdd_txtBox";
            this.plantAdd_txtBox.Size = new System.Drawing.Size(220, 28);
            this.plantAdd_txtBox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(739, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Plant Name:";
            // 
            // PlantsOfUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 512);
            this.Controls.Add(this.plantAdd_txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.temperature_txtBox);
            this.Controls.Add(this.fertilizer_txtBox);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.searchTitle_lbl);
            this.Controls.Add(this.searching_txtBx);
            this.Controls.Add(this.plantName_txtBox);
            this.Controls.Add(this.water_lbl);
            this.Controls.Add(this.temperature_lbl);
            this.Controls.Add(this.plantName_lbl);
            this.Controls.Add(this.plant_dataview);
            this.Controls.Add(this.water_txtBx);
            this.Controls.Add(this.fertilizer_lbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlantsOfUser";
            this.Text = "PlantsOfUser";
            this.Load += new System.EventHandler(this.PlantCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qTHCSDL_LAB3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plant_dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label searchTitle_lbl;
        private QTHCSDL_LAB3DataSetTableAdapters.USERINFOTableAdapter uSERINFOTableAdapter;
        private System.Windows.Forms.TextBox searching_txtBx;
        private System.Windows.Forms.TextBox plantName_txtBox;
        private System.Windows.Forms.Label water_lbl;
        private System.Windows.Forms.Label temperature_lbl;
        private System.Windows.Forms.Label plantName_lbl;
        private QTHCSDL_LAB3DataSet qTHCSDL_LAB3DataSet;
        private System.Windows.Forms.BindingSource uSERINFOBindingSource;
        private System.Windows.Forms.DataGridView plant_dataview;
        private System.Windows.Forms.TextBox water_txtBx;
        private System.Windows.Forms.Label fertilizer_lbl;
        private System.Windows.Forms.TextBox fertilizer_txtBox;
        private System.Windows.Forms.TextBox temperature_txtBox;
        private System.Windows.Forms.TextBox plantAdd_txtBox;
        private System.Windows.Forms.Label label1;
    }
}