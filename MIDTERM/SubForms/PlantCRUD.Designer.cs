﻿namespace MIDTERM
{
    partial class PlantCRUD
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.searchTitle_lbl = new System.Windows.Forms.Label();
            this.uSERINFOTableAdapter = new MIDTERM.QTHCSDL_LAB3DataSetTableAdapters.USERINFOTableAdapter();
            this.update_btn = new System.Windows.Forms.Button();
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
            this.delete_btn.Location = new System.Drawing.Point(844, 445);
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
            this.add_btn.Location = new System.Drawing.Point(788, 388);
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
            this.searchTitle_lbl.Size = new System.Drawing.Size(81, 29);
            this.searchTitle_lbl.TabIndex = 41;
            this.searchTitle_lbl.Text = "Search:";
            // 
            // uSERINFOTableAdapter
            // 
            this.uSERINFOTableAdapter.ClearBeforeFill = true;
            // 
            // update_btn
            // 
            this.update_btn.AutoSize = true;
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(910, 388);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(102, 32);
            this.update_btn.TabIndex = 56;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
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
            this.plantName_txtBox.Size = new System.Drawing.Size(142, 28);
            this.plantName_txtBox.TabIndex = 49;
            // 
            // water_lbl
            // 
            this.water_lbl.AutoSize = true;
            this.water_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water_lbl.Location = new System.Drawing.Point(739, 233);
            this.water_lbl.Name = "water_lbl";
            this.water_lbl.Size = new System.Drawing.Size(116, 21);
            this.water_lbl.TabIndex = 46;
            this.water_lbl.Text = "Water Level:";
            // 
            // temperature_lbl
            // 
            this.temperature_lbl.AutoSize = true;
            this.temperature_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature_lbl.Location = new System.Drawing.Point(739, 176);
            this.temperature_lbl.Name = "temperature_lbl";
            this.temperature_lbl.Size = new System.Drawing.Size(122, 21);
            this.temperature_lbl.TabIndex = 45;
            this.temperature_lbl.Text = "Temperature:";
            this.temperature_lbl.Click += new System.EventHandler(this.gender_lbl_Click);
            // 
            // plantName_lbl
            // 
            this.plantName_lbl.AutoSize = true;
            this.plantName_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantName_lbl.Location = new System.Drawing.Point(739, 111);
            this.plantName_lbl.Name = "plantName_lbl";
            this.plantName_lbl.Size = new System.Drawing.Size(123, 21);
            this.plantName_lbl.TabIndex = 44;
            this.plantName_lbl.Text = "Plant\'s Name:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plant_dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.plant_dataview.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.plant_dataview.DefaultCellStyle = dataGridViewCellStyle2;
            this.plant_dataview.EnableHeadersVisualStyles = false;
            this.plant_dataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.plant_dataview.Location = new System.Drawing.Point(16, 88);
            this.plant_dataview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plant_dataview.Name = "plant_dataview";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.plant_dataview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.plant_dataview.RowHeadersVisible = false;
            this.plant_dataview.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.plant_dataview.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.plant_dataview.RowTemplate.Height = 50;
            this.plant_dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plant_dataview.Size = new System.Drawing.Size(717, 419);
            this.plant_dataview.TabIndex = 53;
            this.plant_dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plant_dataview_CellContentClick);
            // 
            // water_txtBx
            // 
            this.water_txtBx.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water_txtBx.Location = new System.Drawing.Point(892, 228);
            this.water_txtBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.water_txtBx.Name = "water_txtBx";
            this.water_txtBx.Size = new System.Drawing.Size(89, 28);
            this.water_txtBx.TabIndex = 50;
            // 
            // fertilizer_lbl
            // 
            this.fertilizer_lbl.AutoSize = true;
            this.fertilizer_lbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fertilizer_lbl.Location = new System.Drawing.Point(739, 289);
            this.fertilizer_lbl.Name = "fertilizer_lbl";
            this.fertilizer_lbl.Size = new System.Drawing.Size(127, 21);
            this.fertilizer_lbl.TabIndex = 47;
            this.fertilizer_lbl.Text = "Fertilizer Level:";
            // 
            // fertilizer_txtBox
            // 
            this.fertilizer_txtBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fertilizer_txtBox.Location = new System.Drawing.Point(892, 282);
            this.fertilizer_txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fertilizer_txtBox.Name = "fertilizer_txtBox";
            this.fertilizer_txtBox.Size = new System.Drawing.Size(89, 28);
            this.fertilizer_txtBox.TabIndex = 58;
            // 
            // temperature_txtBox
            // 
            this.temperature_txtBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature_txtBox.Location = new System.Drawing.Point(892, 169);
            this.temperature_txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.temperature_txtBox.Name = "temperature_txtBox";
            this.temperature_txtBox.Size = new System.Drawing.Size(89, 28);
            this.temperature_txtBox.TabIndex = 59;
            // 
            // PlantCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 512);
            this.Controls.Add(this.temperature_txtBox);
            this.Controls.Add(this.fertilizer_txtBox);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.searchTitle_lbl);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.searching_txtBx);
            this.Controls.Add(this.plantName_txtBox);
            this.Controls.Add(this.water_lbl);
            this.Controls.Add(this.temperature_lbl);
            this.Controls.Add(this.plantName_lbl);
            this.Controls.Add(this.plant_dataview);
            this.Controls.Add(this.water_txtBx);
            this.Controls.Add(this.fertilizer_lbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlantCRUD";
            this.Text = "PlantForm";
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
        private System.Windows.Forms.Button update_btn;
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
    }
}