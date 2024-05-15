using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MIDTERM.utils;

namespace MIDTERM.SubForms
{
    public partial class LoginForm : Form
    {
        
        public static Database database = new Database();
        AdminForm admin_form = new AdminForm();
        UserForm user_form = new UserForm();
        public LoginForm()
        {
            InitializeComponent();

            //Form
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_picBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_picBox_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimize_picBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string get_login = login.Text,
                   get_password = password.Text,
                   get_loginType = login_type.Text;
            if (login.Text == "" || password.Text == "" || login_type.Text == "")
                MessageBox.Show("username or password cannot be empty",
                    "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (database.check_login(get_login, get_password, get_loginType))
            {
                MessageBox.Show("Redirecting...", "SUCCESS LOGIN",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                if (get_loginType == "Admin")
                    admin_form.Visible = true;
                else
                    user_form.Visible = true;
            }
            else
                MessageBox.Show("username or password is wrong",
                    "ERROR LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
