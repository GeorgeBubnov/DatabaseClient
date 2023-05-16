using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseClient
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        private static Color sea = Color.FromArgb(51, 82, 82);
        private static Color fog = Color.FromArgb(212, 221, 225);
        private static Color rust = Color.FromArgb(170, 75, 65);
        private static Color coal = Color.FromArgb(45, 48, 51);
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
        }




        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = sea;
                    //panelTitleBar.BackColor = color;
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = fog;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }





        private void buttonLessons_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Lessons(), sender);
        }
        private void buttonStudents_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonOffices_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonDrivingSchools_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonApplications_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonReferences_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
