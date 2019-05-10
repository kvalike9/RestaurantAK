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
    public class ItemDAO
    {
        private static ItemDAO _Ins;

        public static ItemDAO Ins
        {
            get {if(_Ins == null) _Ins = new ItemDAO(); return ItemDAO._Ins; }
            private set {ItemDAO.Ins = value; }
        }
        private ItemDAO() { }
        public List<Items> LoadItems()
        {
            List<Items> itemslist = new List<Items>();
            DataTable data = ConnectionDAO.Ins.ExecuteQuery("sp_ShowItems");
            foreach (DataRow item in data.Rows)
            {
                Items items = new Items(item);
                itemslist.Add(items);
            }
            return itemslist;
        }
        public bool AddItem(string Name, double Price)
        {
            int re = ConnectionDAO.Ins.ExecuteNonQuery("sp_AddItem @OrderID , @ItemID", new object[] { Name, Price });
            return re > 0;
        }
        public bool DeleteItem(int ItemID, int Status)
        {
            int re = ConnectionDAO.Ins.ExecuteNonQuery("sp_DeleteUpdteItem @ItemID , @Status", new object[] { ItemID, Status });
            return re > 0;
        }
        public List<Items> ShowItemStatus(int Status)
        {
            List<Items> itemslist = new List<Items>();
            DataTable data = ConnectionDAO.Ins.ExecuteQuery("sp_ShowItemStatus @Status", new object[] { Status });
            foreach (DataRow item in data.Rows)
            {
                Items items = new Items(item);
                itemslist.Add(items);
            }
            return itemslist;
        }
    }
}
