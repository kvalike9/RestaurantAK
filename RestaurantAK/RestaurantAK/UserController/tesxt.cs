using Bunifu.Framework.UI;
using RestaurantAK.DAO;
using RestaurantAK.DTO;
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
    public partial class tesxt : Form
    {
        public tesxt()
        {
            InitializeComponent();
            LoadTable();
        }
        #region Method
        void LoadTable()
        {
            List<Items> tableList = ItemDAO.Ins.LoadItems();

            foreach (Items item in tableList)
            {
                BunifuFlatButton btn = new BunifuFlatButton() { Width = 200, Height = 100 };
                //btn.IconVisible = false;
               // Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.Click += btn_Click;
                btn.Tag = item;

                //switch (item.Status)
                //{
                //    case "Trống":
                //        btn.BackColor = Color.Aqua;
                //        break;
                //    default:
                //        btn.BackColor = Color.LightPink;
                //        break;
                //}

                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        #endregion
        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as BunifuFlatButton).Tag as Items).ItemID;
            MessageBox.Show(tableID.ToString());
        }
        #endregion

    }
}
