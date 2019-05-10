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
        int ItemId = -1;
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
            dtgvItem.MouseClick += new MouseEventHandler(dtgvItem_MouseClick);
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

        private void dtgvItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //MessageBox.Show("Left");
            }
            else
            {
                ContextMenuStrip menuStrip = new ContextMenuStrip();
                int positon = dtgvItem.HitTest(e.X, e.Y).RowIndex;
                ItemId = int.Parse(dtgvItem.Rows[positon].Cells[0].Value.ToString());
                //MessageBox.Show("Right");
                //MessageBox.Show(ItemId.ToString());
                if (positon >= 0)
                {
                    menuStrip.Items.Add("Xóa").Name = "Xóa";
                }
                menuStrip.Show(dtgvItem, new Point(e.X, e.Y));
                menuStrip.ItemClicked += new ToolStripItemClickedEventHandler(menuStrip_ItemClicked);
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //MessageBox.Show(e.ClickedItem.Name.ToString());
            switch (e.ClickedItem.Name.ToString())
            {
                case "Xóa":
                    if (ItemDAO.Ins.DeleteItem(ItemId))
                    {
                        MessageBox.Show("Thành công");
                        ItemId = -1;
                        LoadDATA();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
