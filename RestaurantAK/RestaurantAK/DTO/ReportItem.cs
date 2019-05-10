using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAK.DTO
{
    public class ReportItem
    {
        private int _Stt;
        private string _Name;
        private double _Price;
        private int _Tong;
        private double _Total;

        public ReportItem(DataRow row)
        {
            this.Stt = int.Parse(row["ItemID"].ToString());
            this.Name = row["Name"].ToString();
            this.Price = double.Parse(row["Price"].ToString());
            this.Tong = int.Parse(row["Quantity"].ToString());
            this.Total = double.Parse(row["Total"].ToString());
        }

        public int Stt { get => _Stt; set => _Stt = value; }
        public string Name { get => _Name; set => _Name = value; }
        public double Price { get => _Price; set => _Price = value; }
        public int Tong { get => _Tong; set => _Tong = value; }
        public double Total { get => _Total; set => _Total = value; }
    }
}
