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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);
        int  numbrofstorage; //Koto gulo storage ase

        protected void Page_Load(object sender, EventArgs e)
        {
            //viewImages();
            numbrofstorage = 0;
            conn.Open();
            string checkdata = "select count(StorageNo) from storageinformation";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            numbrofstorage = (int)cmd.ExecuteScalar();

            //Response.Write(numbrofstorage);
            conn.Close();
            for (int i = 0; i < numbrofstorage; i++)
            {
                conn.Open();
                string forstorage = "select * from storageinformation where StorageNo='"+i+"' ";
                cmd = new SqlCommand(forstorage, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    /// i means StorageNo
                    /// if(i==0) mane jodi 1st Storage thake tahole firstPage a show korbe
                    if (i == 0) {
                        Panel0.Visible = true;
                        SNLinkButton0.Text = reader["StorageName"].ToString();
                        Image0.ImageUrl = reader["Icon"].ToString();
                        
                    }
                    else if (i == 1)
                    {
                        Panel1.Visible = true;
                        SNLinkButton1.Text = reader["StorageName"].ToString();
                        Image1.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 2)
                    {
                        Panel2.Visible = true;
                        SNLinkButton2.Text = reader["StorageName"].ToString();
                        Image2.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 3)
                    {
                        Panel3.Visible = true;
                        SNLinkButton3.Text = reader["StorageName"].ToString();
                        Image3.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 4)
                    {
                        Panel4.Visible = true;
                        SNLinkButton4.Text = reader["StorageName"].ToString();
                        Image4.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 5)
                    {
                        Panel5.Visible = true;
                        SNLinkButton5.Text = reader["StorageName"].ToString();
                        Image5.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 6)
                    {
                        Panel6.Visible = true;
                        SNLinkButton6.Text = reader["StorageName"].ToString();
                        Image6.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 7)
                    {
                        Panel7.Visible = true;
                        SNLinkButton7.Text = reader["StorageName"].ToString();
                        Image7.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 8)
                    {
                        Panel8.Visible = true;
                        SNLinkButton8.Text = reader["StorageName"].ToString();
                        Image8.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 9)
                    {
                        Panel9.Visible = true;
                        SNLinkButton9.Text = reader["StorageName"].ToString();
                        Image9.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 10)
                    {
                        Panel10.Visible = true;
                        SNLinkButton10.Text = reader["StorageName"].ToString();
                        Image10.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 11)
                    {
                        Panel11.Visible = true;
                        SNLinkButton11.Text = reader["StorageName"].ToString();
                        Image11.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 12)
                    {
                        Panel12.Visible = true;
                        SNLinkButton12.Text = reader["StorageName"].ToString();
                        Image12.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 13)
                    {
                        Panel13.Visible = true;
                        SNLinkButton13.Text = reader["StorageName"].ToString();
                        Image13.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 14)
                    {
                        Panel14.Visible = true;
                        SNLinkButton14.Text = reader["StorageName"].ToString();
                        Image14.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 15)
                    {
                        Panel15.Visible = true;
                        SNLinkButton15.Text = reader["StorageName"].ToString();
                        Image15.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 16)
                    {
                        Panel16.Visible = true;
                        SNLinkButton16.Text = reader["StorageName"].ToString();
                        Image16.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 17)
                    {
                        Panel17.Visible = true;
                        SNLinkButton17.Text = reader["StorageName"].ToString();
                        Image17.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 18)
                    {
                        Panel18.Visible = true;
                        SNLinkButton18.Text = reader["StorageName"].ToString();
                        Image18.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 19)
                    {
                        Panel19.Visible = true;
                        SNLinkButton19.Text = reader["StorageName"].ToString();
                        Image19.ImageUrl = reader["Icon"].ToString();
                    }  
                  
                }
                conn.Close();
            }
        }

      
        void loadOrderPage(int srlno) {
            new orderPage().getSrlNo(srlno);
            
            //Response.Write(srlno);
            Response.Redirect("orderPage.aspx");
        }
        

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLogin.aspx");
        }

        ///For going Order Page (By clicking this LinkButtons)
        ///SNLinkButton0 for going Order Page of 1st Storage 
        protected void SNLinkButton0_Click(object sender, EventArgs e)
        {
            loadOrderPage(0);
        }
        ///SNLinkButton0 for going Order Page of 2nd Storage
        protected void SNLinkButton1_Click(object sender, EventArgs e)
        {
            loadOrderPage(1);
        }
        ///SNLinkButton0 for going Order Page of 3rd Storage
        protected void SNLinkButton2_Click(object sender, EventArgs e)
        {
            loadOrderPage(2);
        }
        ///SNLinkButton0 for going Order Page of 4th Storage
        protected void SNLinkButton3_Click(object sender, EventArgs e)
        {
            loadOrderPage(3);
        }
        ///SNLinkButton0 for going Order Page of 5th Storage
        protected void SNLinkButton4_Click(object sender, EventArgs e)
        {
            loadOrderPage(4);
        }
        ///SNLinkButton0 for going Order Page of 6th Storage
        protected void SNLinkButton5_Click(object sender, EventArgs e)
        {
            loadOrderPage(5);
        }
        ///SNLinkButton0 for going Order Page of 7th Storage
        protected void SNLinkButton6_Click(object sender, EventArgs e)
        {
            loadOrderPage(6);
        }
        ///SNLinkButton0 for going Order Page of 8th Storage
        protected void SNLinkButton7_Click(object sender, EventArgs e)
        {
            loadOrderPage(7);
        }
        ///SNLinkButton0 for going Order Page of 9th Storage
        protected void SNLinkButton8_Click(object sender, EventArgs e)
        {
            loadOrderPage(8);
        }
        ///SNLinkButton0 for going Order Page of 10th Storage
        protected void SNLinkButton9_Click(object sender, EventArgs e)
        {
            loadOrderPage(9);
        }
        ///SNLinkButton0 for going Order Page of 11th Storage
        protected void SNLinkButton10_Click(object sender, EventArgs e)
        {
            loadOrderPage(10);
        }
        ///SNLinkButton0 for going Order Page of 12th Storage
        protected void SNLinkButton11_Click(object sender, EventArgs e)
        {
            loadOrderPage(11);
        }
        ///SNLinkButton0 for going Order Page of 13th Storage
        protected void SNLinkButton12_Click(object sender, EventArgs e)
        {
            loadOrderPage(12);
        }
        ///SNLinkButton0 for going Order Page of 14th Storage
        protected void SNLinkButton13_Click(object sender, EventArgs e)
        {
            loadOrderPage(13);
        }
        ///SNLinkButton0 for going Order Page of 15th Storage
        protected void SNLinkButton14_Click(object sender, EventArgs e)
        {
            loadOrderPage(14);
        }
        ///SNLinkButton0 for going Order Page of 16th Storage
        protected void SNLinkButton15_Click(object sender, EventArgs e)
        {
            loadOrderPage(15);
        }
        ///SNLinkButton0 for going Order Page of 17th Storage
        protected void SNLinkButton16_Click(object sender, EventArgs e)
        {
            loadOrderPage(16);
        }
        ///SNLinkButton0 for going Order Page of 18th Storage
        protected void SNLinkButton17_Click(object sender, EventArgs e)
        {
            loadOrderPage(17);
        }
        ///SNLinkButton0 for going Order Page of 19th Storage
        protected void SNLinkButton18_Click(object sender, EventArgs e)
        {
            loadOrderPage(18);
        }
        ///SNLinkButton0 for going Order Page of 20th Storage
        protected void SNLinkButton19_Click(object sender, EventArgs e)
        {
            loadOrderPage(19);
        }
    }
}