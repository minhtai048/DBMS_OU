﻿using MIDTERM.SubForms;
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
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
            OvalPictureBox ovalPictureBox = new OvalPictureBox
            {
                Width = 200,
                Height = 200,
                BorderStyle = BorderStyle.None,
                Top = 5,
                Left = 5,
                Image = LoadEmbeddedImage("MIDTERM.Resources.avatar_2.png"),
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            string national_id = "", fullname = "", addressuser = "", gender = "";
            DateTime dateofbirth;
            (national_id, fullname, dateofbirth, addressuser, gender) = LoginForm.database.get_txtbox_userInfor();
            nationIDValue_lbl.Text = national_id;
            dateOfBirthValue_lbl.Text = dateofbirth.ToString("dd/MM/yyyy");
            nameValue_lbl.Text = fullname;
            genderValue_lbl.Text = gender;
            addressValue_lbl.Text = addressuser;
            numPlantValue_lbl.Text = LoginForm.database.get_totalUserPlant();
            userFullName_lbl.Text = fullname;
        }
    }
}
