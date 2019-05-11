using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAK.DTO
{
    public class TypeItem
    {
        private int _TypeItemID;
        private string _NameType;

        public TypeItem(int typeitemid, string nametype)
        {
            this.TypeItemID = typeitemid;
            this.NameType = nametype;
        }

        public TypeItem(DataRow row)
        {
            this.TypeItemID = int.Parse(row["TypeItemID"].ToString());
            this.NameType = row["NameType"].ToString();
        }

        public int TypeItemID { get => _TypeItemID; set => _TypeItemID = value; }
        public string NameType { get => _NameType; set => _NameType = value; }
    }
}
