using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAK.DTO
{
    public class Items
    {
        private int _ItemID;
        private string _Name;
        private double _Price;

        public Items(DataRow row)
        {
            this.ItemID = int.Parse(row["ItemID"].ToString());
            this.Name = row["Name"].ToString();
            this.Price = double.Parse(row["Price"].ToString());
        }
        public Items(int itemid, string name, double price)
        {
            this.ItemID = itemid;
            this.Name = name;
            this.Price = price;
        }

        public int ItemID { get => _ItemID; set => _ItemID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public double Price { get => _Price; set => _Price = value; }
    }
}
