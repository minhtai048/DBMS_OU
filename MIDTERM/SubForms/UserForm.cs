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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();

            dateOfBirth_picker.Format = DateTimePickerFormat.Custom;
            dateOfBirth_picker.CustomFormat = "dd/MM/yyyy"; // Ẩn thứ bằng cách loại bỏ dấu "ddd" ra khỏi chuỗi định dạng tùy chỉnh

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void searchTitle_lbl_Click(object sender, EventArgs e)
        {
        }

        private void searching_btn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
