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
    public class ReportDAO
    {
        private static ReportDAO _Ins;

        public static ReportDAO Ins
        {
            get { if (_Ins == null) _Ins = new ReportDAO(); return ReportDAO.Ins; }
            private set { ReportDAO._Ins = value; }
        }
        private ReportDAO() { }
        public DataTable ReportItems(DateTime dateTimeStart, DateTime dateTimeEnd)
        {

            //DataTable data = ConnectionDAO.Ins.ExecuteQuery("sp_ReportItems @DateStart , @DateEnd", new object[] { dateTimeStart, dateTimeEnd });
            //List<ReportItem> itemslist = new List<ReportItem>();
            //foreach (DataRow item in data.Rows)
            //{
            //    ReportItem items = new ReportItem(item);
            //    itemslist.Add(items);
            //}
            //return ConnectionDAO.Ins.ExecuteQuery("sp_ReportItems @DateStart , @DateEnd", new object[] { dateTimeStart, dateTimeEnd });

            SqlConnection conn = new SqlConnection(Manager.AppSettings.Get("strcon"));
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_ReportItems", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DateStart", dateTimeStart);
            cmd.Parameters.AddWithValue("@DateEnd", dateTimeEnd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            conn.Close();
            return tb;
        }
    }
}
