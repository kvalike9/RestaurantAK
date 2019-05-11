using RestaurantAK.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAK.DAO
{
    public class TypeItemDAO
    {
        private static TypeItemDAO _Ins;

        public static TypeItemDAO Ins
        {
            get { if (_Ins == null) _Ins = new TypeItemDAO(); return TypeItemDAO._Ins; }
            private set { TypeItemDAO.Ins = value; }
        }
        private TypeItemDAO() { }

        public List<TypeItem> LoadItemCombobox()
        {
            List<TypeItem> items = new List<TypeItem>();
            DataTable data = ConnectionDAO.Ins.ExecuteQuery("sp_ShowTypeItem");
            foreach (DataRow item in data.Rows)
            {
                TypeItem typeItem = new TypeItem(item);
                items.Add(typeItem);
            }
            return items;
        }
        public List<TypeItem> LoadItemComboboxAll()
        {
            List<TypeItem> items = new List<TypeItem>();
            DataTable data = ConnectionDAO.Ins.ExecuteQuery("sp_ShowTypeItem");
            DataRow row;
            row = data.NewRow();
            row["TypeItemID"] = 0;
            row["NameType"] = "Tất cả";
            data.Rows.InsertAt(row, 0);
            foreach (DataRow item in data.Rows)
            {
                TypeItem typeItem = new TypeItem(item);
                items.Add(typeItem);
            }
            return items;
        }
    }
}
