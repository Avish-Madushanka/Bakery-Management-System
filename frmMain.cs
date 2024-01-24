using RM.Model;
using RM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //for accessing frm main
        static frmMain _obj;
        public static frmMain Instance
        {
            get { if (_obj == null) { _obj = new frmMain(); } return _obj; }

        }
        //method to add control in form
        public void AddControls(Form f)
        {
            ControlPanel.Controls.Clear();
            f.Dock= DockStyle.Fill;
            f.TopLevel = false;
            ControlPanel.Controls.Add(f);
            f.Show();

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

     
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.USER;
            _obj = this;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new frmstaffView());
        }

       

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.Show();
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            AddControls(new frmCounterView());
        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaControlBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Properties.Settings.Default.WindowMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                Properties.Settings.Default.WindowMaximized = true;
            }
            Properties.Settings.Default.Save();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WindowMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            AddControls(new frmDashboard());
        }
    }
}
