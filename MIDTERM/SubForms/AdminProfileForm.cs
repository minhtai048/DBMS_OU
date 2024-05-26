using MIDTERM.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDTERM
{
    public partial class AdminProfileForm : Form
    {
        public AdminProfileForm()
        {
            InitializeComponent();
            OvalPictureBox ovalPictureBox = new OvalPictureBox
            {
                Width = 200,
                Height = 200,
                BorderStyle = BorderStyle.None,
                Top = 5,
                Left = 5,
                Image = LoadEmbeddedImage("MIDTERM.Resources.avatar.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            avatarPanel.Controls.Add(ovalPictureBox);

        }

        private Image LoadEmbeddedImage(string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    return Image.FromStream(stream);
                }
                else
                {
                    throw new Exception($"Resource '{resourceName}' not found.");
                }
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            int Admin_ID;
            string fullname = "", gender = "";
            DateTime dateofbirth;
            (Admin_ID, fullname, gender, dateofbirth) = LoginForm.database.get_txtbox_adminInfor();
            addressValue_lbl.Text = Admin_ID.ToString();
            phoneValue_lbl.Text = fullname;
            dateOfBirthValue_lbl.Text = dateofbirth.ToString("dd/MM/yyyy");
            genderValue_lbl.Text = gender;
            userFullName_lbl.Text = fullname;
            
        }

        private void avatarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
