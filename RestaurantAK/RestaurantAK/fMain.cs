using RestaurantAK.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAK
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            LoadB();
        }
        public void LoadB()
        {
            userControlHoaDon1.BringToFront();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnmmu_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 80)
            {
                pnMenu.Width = 210;
                pnKEdoc.Visible = true;
            }
            else
	        {
                pnMenu.Width = 80;
                pnKEdoc.Visible = false;
            }
           
            //if (pnMenu.Visible)
            //{
            //    bunifuTransition1.HideSync(pnMenu);
            //    bunifuTransition1.ShowSync(lbLogo);
            //    bunifuTransition1.ShowSync(lblogo2);
            //}
            //else
            //{
            //    bunifuTransition1.ShowSync(pnMenu);
            //    bunifuTransition1.HideSync(lbLogo);
            //    bunifuTransition1.HideSync(lblogo2);
            //}
            
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            userControlHoaDon1.BringToFront();
        }
        private void btnItems_Click(object sender, EventArgs e)
        {
            userControlSanPham1.BringToFront();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            userControlReportItem1.BringToFront();
        }

        private void btnMiMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
