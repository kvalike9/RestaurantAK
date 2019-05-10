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
        public void LoadItemKD()
        {
            try
            {
                dtgvItem.DataSource = ItemDAO.Ins.ShowItemStatus(1);
                dtgvItem.MouseClick += new MouseEventHandler(dtgvItem_MouseClick);
            }
            catch
            {
            }
        }
        public void LoadItemNKD()
        {
            try
            {
                dtgvItem.DataSource = ItemDAO.Ins.ShowItemStatus(0);
                dtgvItem.MouseClick += new MouseEventHandler(dtgvItem_MouseClick);
            }
            catch
            {
            }
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
                LoadItemKD();
            }
        }

        private void dtgvItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menuStrip = new ContextMenuStrip();
                int positon = dtgvItem.HitTest(e.X, e.Y).RowIndex;
                ItemId = int.Parse(dtgvItem.Rows[positon].Cells[0].Value.ToString());
                //MessageBox.Show("Right");
                //MessageBox.Show(ItemId.ToString());
                if (positon >= 0)
                {
                    menuStrip.Items.Clear();
                    if (chbKD.Checked == true)
                    {
                        menuStrip.Items.Add("Ngừng kinh doanh").Name = "Ngừng kinh doanh";
                    }
                    if (chbNKD.Checked == true)
                    {
                        menuStrip.Items.Add("Kinh doanh").Name = "Kinh doanh";
                    }
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
                case "Ngừng kinh doanh":
                    if (ItemDAO.Ins.DeleteItem(ItemId, 0))
                    {
                        MessageBox.Show("Thành công");
                        ItemId = -1;
                        LoadItemKD();
                    }
                    break;
                case "Kinh doanh":
                    if (ItemDAO.Ins.DeleteItem(ItemId, 1))
                    {
                        MessageBox.Show("Thành công");
                        ItemId = -1;
                        LoadItemNKD();
                    }
                    break;
                default:
                    break;
            }
        }

        private void chbAll_OnChange(object sender, EventArgs e)
        {
            if (chbAll.Checked == true)
            {
                chbKD.Checked = false;
                chbNKD.Checked = false;
                try
                {
                    LoadDATA();
                }
                catch
                {

                }
            }
            if (chbKD.Checked == false && chbNKD.Checked == false)
            {
                chbAll.Checked = true;
            }
        }

        private void chbKD_OnChange(object sender, EventArgs e)
        {
            if (chbKD.Checked == true)
            {
                chbAll.Checked = false;
                chbNKD.Checked = false;
                LoadItemKD();
            }
            if (chbAll.Checked == false && chbNKD.Checked == false)
            {
                chbKD.Checked = true;
            }
        }

        private void chbNKD_OnChange(object sender, EventArgs e)
        {
            if (chbNKD.Checked == true)
            {
                chbAll.Checked = false;
                chbKD.Checked = false;
                LoadItemNKD();
            }
            if (chbAll.Checked == false && chbKD.Checked == false)
            {
                chbNKD.Checked = true;
            }
        }
    }
}
