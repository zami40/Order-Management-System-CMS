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
    public partial class login2 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);
        static int srlno,no;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            string checkdata = "select count(No) from storageownerinformation ";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            no = (int)cmd.ExecuteScalar();
            conn.Close();
            Response.Write(no);
        }
        int sendserialNumber;
        public void getSrlNo(int getsrlno)
        {
            srlno = getsrlno;
        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            new storeadminpage().getSerialNo(srlno);
            for (int i = 0; i < no; i++)
            {
                conn.Open();
                string serialNo = "select * from storageownerinformation where UserId='" + this.UserNameTextBox.Text + "' and No='" + i + "' ";
                SqlCommand cmd = new SqlCommand(serialNo, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    sendserialNumber = Convert.ToInt32(reader["StorageNo"].ToString());
                    //Response.Write(sendserialNumber);
                    conn.Close();
                    conn.Open();
                    string checkpassword = "select Password from storageownerinformation where UserId='" + this.UserNameTextBox.Text + "' and No='" + i + "' ";
                    cmd = new SqlCommand(checkpassword, conn);
                    string pass = cmd.ExecuteScalar().ToString().Replace(" ", "");
                    if (pass == this.PasswordTextBox.Text)
                    {
                        //Response.Write("DONE");
                        store Store = new store();
                        Store.getSerialNumberANDlistboxPblm(sendserialNumber,1);
                        //new store().clickAdminPanel();
                        Response.Redirect("storeadminpage.aspx");

                    }
                    else UserPasswordLabel.Text = "Wrong Password !";

                }
                else UserPasswordLabel.Text = "Wrong UserName !";
                conn.Close();
            }
        }
    }
}