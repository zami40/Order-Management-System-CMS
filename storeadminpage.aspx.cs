using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace OnlineCMSWebsite
{
    public partial class storeadminpage : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);
        static int srlNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            ForStorageName();
            /*conn.Open();
            string checkdata = "select count(No) from customerinformation";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            conn.Close();
             * */
            FillDataGridView();
            //Response.Write(srlNo);
        }
        static int totalSize = 0;
        void ForStorageName()
        {
            //Response.Write(srlno);
            conn.Open();
            string forstoragename = "select * from storageinformation where StorageNo='" + srlNo + "' ";
            SqlCommand cmd = new SqlCommand(forstoragename, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                StoreNameLabel.Text = reader["StorageName"].ToString();
                totalSize = Convert.ToInt32(reader["TotalSize"].ToString());
                //Response.Write(totalSize);
            }
            conn.Close();
        }
        public void getSerialNo(int sr)
        {
            srlNo = sr;
        }
        void FillDataGridView()
        {
            conn.Open();
            string checkdata = "select * from customerinformation where StorageNo='"+srlNo+"' ";
            //SqlCommand cmd = new SqlCommand(checkdata, conn);
            SqlDataAdapter ad = new SqlDataAdapter(checkdata,conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (totalSize == 15)
            {
                GridView1.Visible = true;
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else if (totalSize == 10)
            {
                GridView2.Visible = true;
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
            else
            {
                GridView3.Visible = true;
                GridView3.DataSource = dt;
                GridView3.DataBind();
            }
            conn.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DoneButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string dt = "update customerinformation set DeliveryStatus='Done' where StorageNo='" + srlNo + "' and SrlNo='"+SrlNoTextBox.Text+"' ";
            SqlCommand cmd = new SqlCommand(dt, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("storeadminpage.aspx");
        }

        protected void btnDashboard_Click(object sender, EventArgs e)
        {
            new storeadminDashboard().getListboxDataPblmValue(1);
            Response.Redirect("storeadminDashboard.aspx");
        }
    }
}