using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantAK.DTO;
using RestaurantAK.DAO;
using Bunifu.Framework.UI;
using System.Drawing.Printing;

namespace RestaurantAK.UserController
{
    public partial class UserControlHoaDon : UserControl
    {
        public long orderid = -1;
        public UserControlHoaDon()
        {
            InitializeComponent();
            try
            {
                LoadTable();
                LoadHoaDon();
            }
            catch
            {
            }
        }
        #region Method
        void LoadHoaDon()
        {
            dtgvOrder.DataSource = OrderItemDAO.Ins.LoadHoaDon();
        }
        void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Items> tableList = ItemDAO.Ins.LoadItems();

            foreach (Items item in tableList)
            {
                BunifuFlatButton btn = new BunifuFlatButton() { Width = 200, Height = 100 };
                //btn.IconVisible = false;
                // Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.Click += btn_Click;
                btn.Tag = item;
                flowLayoutPanel1.Controls.Add(btn);
            }
            
        }

        #endregion
        void LoadTextBoxOrderNo()
        {
            List<Order> orderlist = OrderItemDAO.Ins.LoadTextboxOrderNo(orderid);
            foreach (Order item in orderlist)
            {
                txbHDNew.text = item.OrderNo;
                txbTongTien.Text = item.GTotal.ToString();
                orderid = item.OrderID;
            }
        }
        void LoadTextBoxOrder()
        {
            List<Order> orderlist = OrderItemDAO.Ins.LoadTextboxOrder();
            foreach (Order item in orderlist)
            {
                txbHDNew.text = item.OrderNo;
                txbTongTien.Text = item.GTotal.ToString();
                orderid = item.OrderID;
            }
        }
        void CreateItemOrder(int itemid)
        {
            if (OrderItemDAO.Ins.CreateHDItemNew(itemid, orderid))
            {
                //MessageBox.Show("Tạo item thành công.");
            }
            else
            {
                MessageBox.Show("Tạo item thất bại.");
            }
            
        }
        void LoadOrderItembyID()
        {
            
            int i = 1;
            lvItem.Items.Clear();
            List<OrderItem>  orderItems = OrderItemDAO.Ins.ShowOrderItem(orderid);
            foreach (OrderItem item in orderItems)
            {
                ListViewItem lsvItem = new ListViewItem(i.ToString());
                lsvItem.SubItems.Add(item.Name.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                //lsvItem.ImageIndex = 0;
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Total.ToString());
                lsvItem.SubItems.Add(item.ItemID.ToString());
                lvItem.Items.Add(lsvItem);
                i++;
            }
            lvItem.Columns[5].Width = 0;
          
        }
        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            if(orderid == -1)
            {
                MessageBox.Show("Bạn chưa tạo hóa đơn.");
            }
            else
            {
                int itemID = ((sender as BunifuFlatButton).Tag as Items).ItemID;
                //MessageBox.Show(tableID.ToString());
                CreateItemOrder(itemID);
                OrderItemDAO.Ins.Tongtienhoadon(orderid);
                LoadOrderItembyID();
                LoadHoaDon();
                LoadTextBoxOrderNo();
            }
        }
        private void btnCretaeHDNew_Click(object sender, EventArgs e)
        {
            lvItem.Items.Clear();
            LoadHoaDon();
            if (OrderItemDAO.Ins.CreateHDNew(1))
            {
                //MessageBox.Show("Thành công");
                LoadTextBoxOrder();
                LoadHoaDon();
            }
            else
            {
                MessageBox.Show("Thất bại ");
            }
        }


        #endregion

        private void dtgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            string OrderNo = dtgvOrder.Rows[numrow].Cells[0].Value.ToString();
            txbHDNew.text = OrderNo;
            orderid = long.Parse(OrderNo);
            LoadTextBoxOrderNo();
            //MessageBox.Show(orderid.ToString());
            LoadOrderItembyID();

        }

        private void xóaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvItem.SelectedItems)
            {
                //MessageBox.Show(item.SubItems[5].Text);
                if (OrderItemDAO.Ins.DeleteOrderItem(orderid, int.Parse(item.SubItems[5].Text)))
                {
                    //MessageBox.Show("Xóa thành công");
                    try
                    {
                        LoadOrderItembyID();
                        OrderItemDAO.Ins.Tongtienhoadon(orderid);
                        LoadHoaDon();
                        LoadTextBoxOrderNo();
                    }
                    catch
                    {
                    }
                }

            }
        }

        private void tăngThêm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvItem.SelectedItems)
            {
                //MessageBox.Show(item.SubItems[5].Text);
                if (OrderItemDAO.Ins.CreateHDItemNew(int.Parse(item.SubItems[5].Text), orderid))
                {
                    //MessageBox.Show("Xóa thành công");
                    try
                    {
                        LoadOrderItembyID();
                        OrderItemDAO.Ins.Tongtienhoadon(orderid);
                        LoadHoaDon();
                        LoadTextBoxOrderNo();
                    }
                    catch
                    {
                    }
                }

            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (OrderItemDAO.Ins.ThanhToan(orderid))
            {
                //MessageBox.Show("Thành công");
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                LoadHoaDon();
                lvItem.Items.Clear();
                txbHDNew.text = "";
                txbTongTien.Text = "0";
                orderid = -1;
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Vũ Anh Khoa", this.Font, Brushes.Black, 20, 40);
            e.Graphics.DrawString("Order No: " + txbHDNew.text.Trim(), this.Font, Brushes.Black, 20, 60);
            e.Graphics.DrawString("Date Time: " + DateTime.Now, this.Font, Brushes.Black, 20, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", this.Font, Brushes.Black, 20, 100);
            e.Graphics.DrawString("STT", this.Font, Brushes.Black, 20, 120);
            e.Graphics.DrawString("Name", this.Font, Brushes.Black, 100, 120);
            e.Graphics.DrawString("Price", this.Font, Brushes.Black, 640, 120);
            e.Graphics.DrawString("Quantity", this.Font, Brushes.Black, 700, 120);
            e.Graphics.DrawString("Total", this.Font, Brushes.Black, 760, 120);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", this.Font, Brushes.Black, 20, 140);
            int y = 160;
            try
            {
                int i = 1;
                
                List<OrderItem> orderItems = OrderItemDAO.Ins.ShowOrderItem(orderid);
                foreach (OrderItem item in orderItems)
                {
                    
                    e.Graphics.DrawString(i.ToString(), this.Font, Brushes.Black, 20, y);
                    e.Graphics.DrawString(item.Name.ToString(), this.Font, Brushes.Black, 100, y);
                    e.Graphics.DrawString(item.Price.ToString(), this.Font, Brushes.Black, 640, y);
                    e.Graphics.DrawString(item.Quantity.ToString(), this.Font, Brushes.Black, 700, y);
                    e.Graphics.DrawString(item.Total.ToString(), this.Font, Brushes.Black, 760, y);
                    i++;
                    y += 20;
                }
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", this.Font, Brushes.Black, 20, y);
            }
            catch
            {
            }
            e.Graphics.DrawString("Tổng tiền: " + txbTongTien.Text.ToString(), this.Font, Brushes.Black, 720, y+20);

        }
    }
}
