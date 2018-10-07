using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineCMSWebsite
{
    public partial class Admin : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);
        static int assignNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            string checkdata = "select count(No) from assignownerinformation";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            assignNo = (int)cmd.ExecuteScalar();
            conn.Close();
            //Response.Write("NO="+no);

        }
        int sendserialNumber;
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (SuperAdminCheckBox.Checked == true)
            {
                if (UserNameTextBox.Text == "admin")
                {
                    if (PasswordTextBox.Text == "admin")
                    {
                        Response.Redirect("dashBoard.aspx");
                    }
                    else UserPasswordLabel.Text = "Wrong Password !";
                }

                else UserPasswordLabel.Text = "Wrong User Name !";
            }
            else if (StorageAdminCheckBox.Checked == true) 
            {
                for (int i = 0; i < assignNo; i++)
                {
                    conn.Open();
                    string serialNo = "select * from assignownerinformation where UserId='" + this.UserNameTextBox.Text + "' and No='" + i + "' ";
                    SqlCommand cmd = new SqlCommand(serialNo, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                   
                    if (reader.Read())
                    {
                        sendserialNumber = Convert.ToInt32(reader["StorageNo"].ToString());
                        //Response.Write(sendserialNumber);
                        conn.Close();
                        conn.Open();
                        string checkpassword = "select Password from assignownerinformation where UserId='" + this.UserNameTextBox.Text + "' and No='" + i + "' ";
                        cmd = new SqlCommand(checkpassword, conn);
                        string pass = cmd.ExecuteScalar().ToString().Replace(" ", ""); ;
                        if (pass == this.PasswordTextBox.Text)
                        {   
                            ///send UserId,Password
                            new storeadminDashboard().getUsrPass(UserNameTextBox.Text,PasswordTextBox.Text);
                            ///set listBoxDataPblm value 1
                            //new storeadminDashboard().getListboxDataPblmValue(1);
                            Response.Redirect("storeadminDashboard.aspx");
                            break;
                        }
                        
                    }
                    conn.Close();
                }
                        
            }
            else UserPasswordLabel.Text = "Select Admin !";

            }

        }
       
}
