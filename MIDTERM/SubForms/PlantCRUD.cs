using MIDTERM.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDTERM
{
    public partial class PlantCRUD : Form
    {
        private int id_selected;
        public PlantCRUD()
        {
            InitializeComponent();
        }

        private void gender_lbl_Click(object sender, EventArgs e)
        {

        }

        private void PlantCRUD_Load(object sender, EventArgs e)
        {
            DataSet dataset = LoginForm.database.display_plantAll();
            plant_dataview.DataSource = dataset.Tables["plant"].DefaultView;
            plant_dataview.AutoResizeColumns();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string plant_name = searching_txtBx.Text;
            DataSet dataset = LoginForm.database.display_plantSearch(plant_name);
            plant_dataview.DataSource = dataset.Tables["plant"].DefaultView;
            plant_dataview.AutoResizeColumns();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string plant_name = plantName_txtBox.Text;
                double temperature = Convert.ToDouble(temperature_txtBox.Text),
                       water_level = Convert.ToDouble(water_txtBx.Text),
                       fertilizer_level = Convert.ToDouble(fertilizer_txtBox.Text);

                if (LoginForm.database.add_newPlant(plant_name, temperature,
                                                   water_level, fertilizer_level))
                    MessageBox.Show("New plant with name: " + plant_name + " is added!",
                        "SUCCESS ADDING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Plant already existed!",
                    "ERROR ADDING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Please fill all the information!",
                    "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataSet dataset = LoginForm.database.display_plantAll();
            plant_dataview.DataSource = dataset.Tables["plant"].DefaultView;
            plant_dataview.AutoResizeColumns();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string plant_name = plantName_txtBox.Text;
                double temperature = Convert.ToDouble(temperature_txtBox.Text),
                       water_level = Convert.ToDouble(water_txtBx.Text),
                       fertilizer_level = Convert.ToDouble(fertilizer_txtBox.Text);
                if (LoginForm.database.update_currentPlant(plant_name, temperature,
                                                   water_level, fertilizer_level,
                                                         id_selected))
                    MessageBox.Show("Plant with name: " + plant_name + " is updated!",
                        "SUCCESS UPDATING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Plant is not existed!",
                        "ERROR UPDATING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Please fill all the information!",
                    "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataSet dataset = LoginForm.database.display_plantAll();
            plant_dataview.DataSource = dataset.Tables["plant"].DefaultView;
            plant_dataview.AutoResizeColumns();
        }

        private void plant_dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (plant_dataview.SelectedRows.Count == 1)
                foreach (DataGridViewRow row in plant_dataview.SelectedRows)
                {
                    plantName_txtBox.Text = row.Cells["Plant_Name"].Value.ToString();
                    temperature_txtBox.Text = row.Cells["Temperature"].Value.ToString();
                    water_txtBx.Text = row.Cells["Water_Level"].Value.ToString();
                    fertilizer_txtBox.Text = row.Cells["Fertilizer_Level"].Value.ToString();
                    id_selected = int.Parse(row.Cells["Plant_ID"].Value.ToString());
                }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string plant_name = plantName_txtBox.Text;
                if (LoginForm.database.delete_currentPlant(plant_name))
                    MessageBox.Show("Plant with name: " + plant_name + " is deleted!",
                        "SUCCESS DELETING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Plant is not existed!",
                        "ERROR DELETING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Please fill all the information!",
                    "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataSet dataset = LoginForm.database.display_plantAll();
            plant_dataview.DataSource = dataset.Tables["plant"].DefaultView;
            plant_dataview.AutoResizeColumns();
        }
    }
}
