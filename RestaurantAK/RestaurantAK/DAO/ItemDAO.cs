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
            SqlConnection conn = new SqlConnection(Manager.AppSettings.Get("strcon"));
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_ShowItems", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            conn.Close();
            foreach (DataRow item in tb.Rows)
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
    }
}
