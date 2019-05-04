using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAK.DTO
{
    public class OrderHoaDon
    {
        private string _OrderNo;
        private string _Name;
        private string _PMethod;
        private string _GTotal;

        public OrderHoaDon(string orderno, string name, string pmethod, string gtotal)
        {
            this.OrderNo = orderno;
            this.Name = name;
            this.PMethod = pmethod;
            this.GTotal = gtotal;
        }

        public OrderHoaDon(DataRow row)
        {
            this.OrderNo = row["OrderNo"].ToString();
            this.Name = row["Name"].ToString();
            this.PMethod = row["PMethod"].ToString();
            this.GTotal = row["GTotal"].ToString();
        }

        public string OrderNo { get => _OrderNo; set => _OrderNo = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string PMethod { get => _PMethod; set => _PMethod = value; }
        public string GTotal { get => _GTotal; set => _GTotal = value; }
    }
}
