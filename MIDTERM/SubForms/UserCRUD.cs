using MIDTERM.SubForms;
using MIDTERM.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDTERM
{
    public partial class UserCRUD : Form
    {
        private int id_selected;
        public UserCRUD()
        {
            InitializeComponent();

            dateOfBirth_picker.Format = DateTimePickerFormat.Custom;
            dateOfBirth_picker.CustomFormat = "dd/MM/yyyy"; 
            // Ẩn thứ bằng cách loại bỏ dấu "ddd" ra khỏi chuỗi định dạng tùy chỉnh

        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            DataSet dataset = LoginForm.database.display_userAll();
            user_dataview.DataSource = dataset.Tables["user_system"].DefaultView;
        }
        private void searching_btn_Click(object sender, EventArgs e)
        {
            string national_id_user = searching_txtBx.Text;
            DataSet dataset = LoginForm.database.display_userSearch(national_id_user);
            user_dataview.DataSource = dataset.Tables["user_system"].DefaultView;
        }

        private void user_dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (user_dataview.SelectedRows.Count == 1)
                foreach (DataGridViewRow row in user_dataview.SelectedRows)
                {
                    national_id_txtBx.Text = row.Cells["National_ID"].Value.ToString();
                    username_txtBox.Text = row.Cells["userlogin"].Value.ToString();
                    password_txtBox.Text = row.Cells["passwordlogin"].Value.ToString();
                    fullname_txtBox.Text = row.Cells["FullName"].Value.ToString();
                    gender_comboBx.Text = row.Cells["Gender"].Value.ToString();
                    address_txtBox.Text = row.Cells["AddressUser"].Value.ToString();
                    dateOfBirth_picker.Text = row.Cells["DateOfBirth"].Value.ToString();
                    id_selected = int.Parse(row.Cells["userID"].Value.ToString());
                }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string  national_id = national_id_txtBx.Text,
                        fullname = fullname_txtBox.Text,
                        userlogin = username_txtBox.Text,
                        passwordlogin = password_txtBox.Text,
                        gender = gender_comboBx.Text,
                        address = address_txtBox.Text,
                        dateofbirth = dateOfBirth_picker.Value.Date.ToString("yyyy-MM-dd");
                if (LoginForm.database.add_newUser(national_id, fullname,
                                                   userlogin, passwordlogin,
                                                   gender, address, dateofbirth))
                    MessageBox.Show("New user with ID " + national_id + " is added!",
                        "SUCCESS ADDING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User already existed!",
                    "ERROR ADDING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Please fill all the information!",
                    "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataSet dataset = LoginForm.database.display_userAll();
            user_dataview.DataSource = dataset.Tables["user_system"].DefaultView;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string  national_id = national_id_txtBx.Text,
                        fullname = fullname_txtBox.Text,
                        userlogin = username_txtBox.Text,
                        passwordlogin = password_txtBox.Text,
                        gender = gender_comboBx.Text,
                        address = address_txtBox.Text,
                        dateofbirth = dateOfBirth_picker.Value.Date.ToString("yyyy-MM-dd");
                if (LoginForm.database.update_currentUser(national_id, fullname,
                                                         userlogin, passwordlogin,
                                                         gender, address, dateofbirth,
                                                         id_selected))
                    MessageBox.Show("User with ID " + national_id + " is updated!",
                        "SUCCESS UPDATING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User is not existed!",
                        "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Please fill all the information!",
                    "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataSet dataset = LoginForm.database.display_userAll();
            user_dataview.DataSource = dataset.Tables["user_system"].DefaultView;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string national_id = national_id_txtBx.Text;
                if (LoginForm.database.delete_currentUser(national_id))
                    MessageBox.Show("User with ID " + national_id + " is deleted!",
                        "SUCCESS DELETING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("User is not existed!",
                        "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Please fill all the information!",
                    "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataSet dataset = LoginForm.database.display_userAll();
            user_dataview.DataSource = dataset.Tables["user_system"].DefaultView;
        }
    }
}
