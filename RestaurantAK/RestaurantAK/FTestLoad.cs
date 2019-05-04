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
    public partial class FTestLoad : Form
    {
        public FTestLoad()
        {
            InitializeComponent();
            timer1.Start();
        }
        void LoadDB()
        {
            //bunifuCustomDataGrid1.DataSource=OrderDAO.Ins.LoadHoaDon();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void FTestLoad_Load(object sender, EventArgs e)
        {

            
        }
    }
}
