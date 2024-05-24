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
    public partial class PlantsOfUser : Form
    {
        private int id_selected;
        public PlantsOfUser()
        {
            InitializeComponent();
        }

        private void gender_lbl_Click(object sender, EventArgs e)
        {

        }

        private void PlantCRUD_Load(object sender, EventArgs e)
        {
            DataSet dataset = LoginForm.database.display_plantUserAll();
            plant_dataview.DataSource = dataset.Tables["user_plant"].DefaultView;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string plant_name = searching_txtBx.Text;
            DataSet dataset = LoginForm.database.display_plantUserSearch(plant_name);
            plant_dataview.DataSource = dataset.Tables["user_plant"].DefaultView;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
                string plant_name = plantAdd_txtBox.Text;
                string plant_id = LoginForm.database.get_plantID(plant_name);
                if (LoginForm.database.add_newUserPlant(plant_name, plant_id) && plant_id != "")
                    MessageBox.Show("New plant name: " + plant_name + " is added!",
                        "SUCCESS ADDING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Plant is not found!",
                    "ERROR ADDING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DataSet dataset = LoginForm.database.display_plantUserAll();
            plant_dataview.DataSource = dataset.Tables["user_plant"].DefaultView;
        }

        private void plant_dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string plant_to_search = "";
            if (plant_dataview.SelectedRows.Count == 1)
                foreach (DataGridViewRow row in plant_dataview.SelectedRows)
                    plant_to_search = row.Cells["plant_name"].Value.ToString();
            string plant_name = ""; 
            decimal temperature, water_level, fertilizer_level;
            (plant_name, temperature, 
             water_level, fertilizer_level) = LoginForm.database.get_txtbox_plantInfo(plant_to_search);
            plantName_txtBox.Text = plant_name;
            temperature_txtBox.Text = temperature.ToString();
            water_txtBx.Text = water_level.ToString();
            fertilizer_txtBox.Text = fertilizer_level.ToString();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string plant_name = plantName_txtBox.Text;
                if (LoginForm.database.delete_currentUserPlant(plant_name))
                    MessageBox.Show("Plant with name: " + plant_name + " is deleted!",
                        "SUCCESS DELETING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Plant is not existed!",
                        "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Please fill all the information!",
                    "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataSet dataset = LoginForm.database.display_plantUserAll();
            plant_dataview.DataSource = dataset.Tables["user_plant"].DefaultView;
        }
    }
}
