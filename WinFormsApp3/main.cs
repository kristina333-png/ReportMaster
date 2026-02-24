using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class main : Form
    {
        private Form activeForms = null;
        public void openForm(Form childformd)
        {
            if (activeForms != null)
                activeForms.Close();
            activeForms = childformd;
            childformd.TopLevel = false;
            childformd.FormBorderStyle = FormBorderStyle.None;
            childformd.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.Controls.Add(childformd);
            activeForms.Tag = childformd;
            activeForms.Show();
        }
        public main()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openForm(new information());
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            openForm(new Income());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            openForm(new Wastes());
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
