using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manager = System.Configuration.ConfigurationManager;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace RestaurantAK.UserController
{
    public partial class UserControlReportItem : UserControl
    {
        public UserControlReportItem()
        {
            InitializeComponent();
            LoadTime();
        }

        void LoadTime()
        {
            dtpkStart.Value = DateTime.Now.Date;
            dtpkEnd.Value = DateTime.Now.Date;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Manager.AppSettings.Get("strcon"));
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ReportItems", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DateStart", dtpkStart.Value);
                cmd.Parameters.AddWithValue("@DateEnd", dtpkEnd.Value);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet tb = new DataSet();
                adapter.Fill(tb);
                conn.Close();
                reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = "ReportItem.rdlc";
                if (tb.Tables[0].Rows.Count > 0)
                {
                    //Tạo nguồn dữ liệu cho báo cáo
                    ReportDataSource rds = new ReportDataSource();
                    ReportParameter DayStart = new ReportParameter("DayStart", dtpkStart.Value.ToString("dd/MM/yyyy"));
                    ReportParameter DayEnd = new ReportParameter("DayEnd", dtpkEnd.Value.ToString("dd/MM/yyyy"));
                    
                    rds.Name = "ReportItem";
                    rds.Value = tb.Tables[0];
                    //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                    reportViewer1.LocalReport.SetParameters(DayStart);
                    reportViewer1.LocalReport.SetParameters(DayEnd);
                    reportViewer1.LocalReport.DataSources.Clear();
                    //Add dữ liệu vào báo cáo
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = ZoomMode.Percent;
                    //Refresh lại báo cáo
                    reportViewer1.RefreshReport();
                }
            }
            catch
            {

            }
        }
    }
}
