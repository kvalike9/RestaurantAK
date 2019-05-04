using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAK.DTO
{
    public class Order
    {
        private int _OrderID;
        private string _OrderNo;
        private double _GTotal;

        public Order(int orderid, string orderno, double gtotal)
        {
            this.OrderID = orderid;
            this.OrderNo = orderno;
            this.GTotal = gtotal;
        }
        public Order(DataRow row)
        {
            this.OrderID = int.Parse(row["OrderID"].ToString());
            this.OrderNo = row["OrderNo"].ToString();
            this.GTotal = double.Parse(row["GTotal"].ToString());
        }

        public int OrderID { get => _OrderID; set => _OrderID = value; }
        public string OrderNo { get => _OrderNo; set => _OrderNo = value; }
        public double GTotal { get => _GTotal; set => _GTotal = value; }
    }
}
