using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantAK.DAO;
using RestaurantAK.DTO;

namespace RestaurantAK.UserController
{
    public partial class UserControlSanPham : UserControl
    {
        public UserControlSanPham()
        {
            InitializeComponent();
            try
            {
                LoadDATA();
            }
            catch
            {

            }
           
        }
        #region Method
        public void LoadDATA()
        {
            //lvItem.Items.Clear();
            //lvItem.GridLines = true;
            //lvItem.FullRowSelect = true;
            //lvItem.View = View.Details;
            //List<Items> sinhvienlist = ItemDAO.Ins.LoadItems();
            //foreach (Items item in sinhvienlist)
            //{
            //    ListViewItem lsvItem = new ListViewItem(item.ItemID.ToString());
            //    lsvItem.SubItems.Add(item.Name.ToString());
            //    lsvItem.SubItems.Add(item.Price.ToString());
            //    lvItem.Items.Add(lsvItem);
            //}
            dtgvItem.DataSource = ItemDAO.Ins.LoadItems();
        }
        #endregion

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (pnAddUpdateItem.Visible)
            {
                pnAddUpdateItem.Visible = false;
            }
            else
            {
                pnAddUpdateItem.Visible = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (ItemDAO.Ins.AddItem(txbName.Text, double.Parse(nbPrice.Value.ToString())))
            {
                try
                {
                    LoadDATA();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
