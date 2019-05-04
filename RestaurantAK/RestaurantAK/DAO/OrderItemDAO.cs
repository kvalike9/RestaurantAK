using RestaurantAK.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager = System.Configuration.ConfigurationManager;

namespace RestaurantAK.DAO
{
    public class OrderItemDAO
    {
        private static OrderItemDAO _Ins;

        public static OrderItemDAO Ins
        {
            get { if (_Ins == null) _Ins = new OrderItemDAO(); return OrderItemDAO._Ins; }
            private set { OrderItemDAO.Ins = value; }
        }

        private OrderItemDAO() { }

        public List<OrderItem> ShowOrderItem(long orderid)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            DataTable data = ConnectionDAO.Ins.ExecuteQuery("sp_ShowOrderItems @orderid", new object[] { orderid });
            foreach (DataRow item in data.Rows)
            {
                OrderItem orderItem = new OrderItem(item);
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        public List<Order> LoadTextboxOrderNo(long orderid)
        {
            List<Order> orderItems = new List<Order>();
            DataTable data = ConnectionDAO.Ins.ExecuteQuery("sp_showorderno @orderid", new object[] { orderid });
            foreach (DataRow item in data.Rows)
            {
                Order orderItem = new Order(item);
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        public List<Order> LoadTextboxOrder()
        {
            List<Order> orderItems = new List<Order>();
            DataTable data = ConnectionDAO.Ins.ExecuteQuery("sp_showorder");
            foreach (DataRow item in data.Rows)
            {
                Order orderItem = new Order(item);
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        public List<OrderHoaDon> LoadHoaDon()
        {
            List<OrderHoaDon> orderItems = new List<OrderHoaDon>();
            DataTable data = ConnectionDAO.Ins.ExecuteQuery("sp_ShowHoaDon");
            foreach (DataRow item in data.Rows)
            {
                OrderHoaDon orderItem = new OrderHoaDon(item);
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        public bool DeleteOrderItem(long OrderID, int ItemID)
        {
            int re = ConnectionDAO.Ins.ExecuteNonQuery("sp_DeleteOrderItem @OrderID , @ItemID", new object[] { OrderID, ItemID });
            return re > 0;
        }
        public bool CreateHDItemNew(int itemid, long orderid)
        {
            int re = ConnectionDAO.Ins.ExecuteNonQuery("sp_CreateOrderItem @orderid , @itemid", new object[] { orderid, itemid });
            return re > 0;
        }
        public bool ThanhToan(long orderid)
        {
            int re = ConnectionDAO.Ins.ExecuteNonQuery("sp_ThanhToan @OrderID", new object[] { orderid });
            return re > 0;
        }
        public bool CreateHDNew(int customerid)
        {
            int re = ConnectionDAO.Ins.ExecuteNonQuery("sp_CreateOrderNew @customerid", new object[] { customerid });
            return re > 0;
        }
        public bool Tongtienhoadon(long orderid)
        {
            int re = ConnectionDAO.Ins.ExecuteNonQuery("sp_CreateTotal @orderid", new object[] { orderid });
            return re > 0;
        }
       
    }
   
}
