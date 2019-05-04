using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAK.DTO
{
    public class OrderItem
    {
        private int _ItemID;
        private string _Name;
        private double _Price;
        private int _Quantity;
        private double _Total;

        public OrderItem(int itemid, string name, double price, int quantity, double total)
        {
            this.ItemID = itemid;
            this.Name = name;
            this.Price = Price;
            this.Quantity = quantity;
            this.Total = total;
        }
        public OrderItem(DataRow row)
        {
            this.ItemID = int.Parse(row["ItemID"].ToString());
            this.Name = row["Name"].ToString();
            this.Price = double.Parse(row["Price"].ToString());
            this.Quantity = int.Parse(row["Quantity"].ToString());
            this.Total = double.Parse(row["Total"].ToString());
        }

        public string Name { get => _Name; set => _Name = value; }
        public double Price { get => _Price; set => _Price = value; }
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public double Total { get => _Total; set => _Total = value; }
        public int ItemID { get => _ItemID; set => _ItemID = value; }
    }
}
