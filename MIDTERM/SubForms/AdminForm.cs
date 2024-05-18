using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MIDTERM.SubForms;
using MIDTERM.utils;

namespace MIDTERM
{
    public partial class AdminForm : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentForm;

        public AdminForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 72);
            panelMenu.Controls.Add(leftBorderBtn);



            //Form
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Thiết lập sự kiện Tick cho Timer
            timer1.Tick += timer1_Tick;

            // Bắt đầu Timer
            timer1.Start();

            // Gọi một lần khi Form khởi tạo để hiển thị thời gian ngay lập tức
            UpdateTimeLabel();

        }

        private void User_Load(object sender, EventArgs e)
        {
        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                home_picBox.IconChar = currentBtn.IconChar;
                home_picBox.IconColor = color;
                home_picBox.BackColor = Color.FromArgb(26, 25, 62);
                title_lbl.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign= ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openSubForm(new UserCRUD());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            openSubForm(new Profile());

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            openSubForm(new PlantCRUD());

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            home_picBox.IconChar = IconChar.HomeUser;
            home_picBox.IconColor = Color.FromArgb(172, 126, 241);
            home_picBox.BackColor = Color.FromArgb(26, 25, 62);
            title_lbl.Text = "Home";
            if (currentForm != null)
            {
                currentForm.Close();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
           if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            } 
           else
            {
                this.WindowState = FormWindowState.Normal;
            }    
           
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openSubForm(Form subForm)
        {
            if(currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = subForm;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            subForm_panel.Controls.Add(subForm);
            subForm_panel.Tag = subForm;
            subForm.BringToFront();
            subForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Gọi hàm cập nhật thời gian mỗi lần Timer được kích hoạt
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            // Lấy ngày giờ hiện tại của hệ thống
            DateTime currentTime = DateTime.Now;

            // Hiển thị ngày giờ trong Label
            currentTime_lbl.Text = currentTime.ToString("HH:mm:ss");
            currentDate_lbl.Text = currentTime.ToString("dddd, MMMM dd, yyyy");
        }

        private void currentDate_lbl_Click(object sender, EventArgs e)
        {

        }

        private void user_btn_MouseEnter(object sender, EventArgs e)
        {
            user_btn.BackColor = Color.FromArgb(50, 6, 104);
        }

        private void admin_btn_MouseEnter(object sender, EventArgs e)
        {
            admin_btn.BackColor = Color.FromArgb(50, 6, 104);
        }

        private void plant_btn_MouseEnter(object sender, EventArgs e)
        {
            plant_btn.BackColor = Color.FromArgb(50, 6, 104);
        }

        private void user_btn_MouseLeave(object sender, EventArgs e)
        {
            user_btn.BackColor = Color.FromArgb(31, 30, 68);
        }
        private void admin_btn_MouseLeave(object sender, EventArgs e)
        {
            admin_btn.BackColor = Color.FromArgb(31, 30, 68);
        }
        private void plant_btn_MouseLeave(object sender, EventArgs e)
        {
            plant_btn.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void subForm_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openSubForm(new UserCRUD());
        }

        private void plant_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            openSubForm(new PlantCRUD());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            this.Visible = false;
            LoginForm login_form = new LoginForm();
            login_form.Visible = true;
        }
    }
}
