using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineCMSWebsite
{
    public partial class storeadminDashboard : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);

        static int storageNo, assignNo = 0, listboxDataPblm = 1, selectListBoxPblm = 0;
        static string userN, passW, storageName;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            string checkdata = "select count(No) from assignownerinformation";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            assignNo = (int)cmd.ExecuteScalar();
            //Response.Write(no);
            //Response.Write("  U="+userN+"  P="+passW+"  ");
            conn.Close();
            if (listboxDataPblm == 1)
            {
                for (int i = 0; i < assignNo; i++)
                {
                    conn.Open();
                    string checkpassword = "select StorageName from assignownerinformation where No='" + i + "' and UserId='" + userN + "' and Password='" + passW + "' ";
                    SqlCommand cmd2 = new SqlCommand(checkpassword, conn);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        //Response.Write("OK2");
                        StorageNameListBox.Items.Add(reader["StorageName"].ToString());
                    }
                    conn.Close();
                }
                listboxDataPblm = 0;
            }
        }
        public void getUsrPass(string usr, string pass)
        {
            userN = usr;
            passW = pass;
        }
        public void getListboxDataPblmValue(int lBox)
        {
            listboxDataPblm = lBox;
        }
        protected void StorageNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            storageName = StorageNameListBox.SelectedValue;
            conn.Open();
            string checkdata = "select StorageNo from storageinformation where StorageName='" + storageName + "' ";
            SqlCommand cmd2 = new SqlCommand(checkdata, conn);
            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                storageNo = Convert.ToInt32(reader["StorageNo"].ToString());
            }
            conn.Close();
            //Response.Write(storageName+"   No="+storageNo);
            //If Select This then selectListBoxPblm=1
            errorMsg.Visible = false;
            selectListBoxPblm = 1;
        }
        protected void btnEditStore_Click(object sender, EventArgs e)
        {

            if (selectListBoxPblm == 1)
            {
                selectListBoxPblm = 0; //listbox selected nai
                listboxDataPblm = 1;  //All data display korbe
                new store().getSerialNumberANDlistboxPblm(storageNo,1);
                Response.Redirect("store.aspx");
            }
            else errorMsg.Visible = true;
        }


        protected void btnShowOrders_Click(object sender, EventArgs e)
        {

            if (selectListBoxPblm == 1)
            {
                selectListBoxPblm = 0;
                listboxDataPblm = 1;
                new storeadminpage().getSerialNo(storageNo);
                Response.Redirect("storeadminpage.aspx");
            }
            else errorMsg.Visible = true;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            selectListBoxPblm = 0; //listbox selected nai
            listboxDataPblm = 1;  //All data display korbe
                
            Response.Redirect("firstPage.aspx");
        }
    }
}