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
    public partial class createOwners : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);
        
        //static int storageNo,count,listboxDataPblm = 1;
        static int no, assignNo, selectListBoxPblm=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Find number of owners in data table
            conn.Open();
            string checkdata = "select count(No) from storageownerinformation";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            no= (int)cmd.ExecuteScalar();
            conn.Close();
            //Find number of assign owners in data table
            conn.Open();
            checkdata = "select count(No) from assignownerinformation";
            cmd = new SqlCommand(checkdata, conn);
            assignNo = (int)cmd.ExecuteScalar();
            conn.Close();
            
        }
       
        protected void AddButton_Click(object sender, EventArgs e)
        {
            if (selectOwnernametext == 1 && selectAddresstext == 1 && selectUseridtext == 1 && selectPasswordtext == 1)
            {
                conn.Open();
                string insertdata = "insert into storageownerinformation (No,OwnerName,UserId,Password,Address) values (@No,@OwnrName,@UserId,@Password,@Address)";
                SqlCommand cmd = new SqlCommand(insertdata, conn);
                cmd.Parameters.AddWithValue("@No", no);

                cmd.Parameters.AddWithValue("@OwnrName", OwnerNameTextBox.Text);
                cmd.Parameters.AddWithValue("@UserId", UserIdTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                no++;
                cmd.ExecuteNonQuery();
                conn.Close();
                //listboxDataPblm = 1;
                resetAll();
                Response.Redirect("createOwners.aspx");
            }
            else
            {
                if(selectOwnernametext!=1)  ownerNameErrorMsg.Visible=true;
                if(selectAddresstext!=1)    addressErrorMsg.Visible=true;
                if(selectUseridtext!=1)    userIdErrorMsg.Visible=true;
                if (selectPasswordtext != 1)    passwordErrorMsg.Visible = true;
            }
            selectListBoxPblm = 0;
        }
        public void clickDashBoard() {
            //listboxDataPblm = 1;
        }
        string saveOwnerName;
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int l = ListBox1.SelectedIndex;
            saveOwnerName = ListBox1.SelectedValue;
            //Response.Write(saveOwnerName);
            conn.Open();
            string data = "select * from storageownerinformation where No='" + l + "' ";
            SqlCommand cmd = new SqlCommand(data, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                OwnerNameTextBox.Text = reader["OwnerName"].ToString();
                AddressTextBox.Text = reader["Address"].ToString();
                UserIdTextBox.Text = reader["Userid"].ToString();
                PasswordTextBox.Text = reader["Password"].ToString();
            }
            conn.Close();
            selectListBoxPblm = 1;
            errorMsg.Visible = false;
        }
        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            if (selectListBoxPblm == 1)
            {
                conn.Open();
                string update = "update storageownerinformation set OwnerName='" + OwnerNameTextBox.Text + "' , UserId='" + UserIdTextBox.Text + "' , Password='" + PasswordTextBox.Text + "' , Address='" + AddressTextBox.Text + "'  where No='" + ListBox1.SelectedIndex + "'  ";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                string checkdata = "select count(No) from assignownerinformation";
                cmd = new SqlCommand(checkdata, conn);
                int assignNo = (int)cmd.ExecuteScalar();
                conn.Close();
                for (int i = 0; i < assignNo; i++)
                {
                    conn.Open();
                    update = "update assignownerinformation set OwnerName='" + OwnerNameTextBox.Text + "' , UserId='" + UserIdTextBox.Text + "' , Password='" + PasswordTextBox.Text + "'  where No='" + i + "' and OwnerName='" + ListBox1.SelectedValue + "'  ";
                    cmd = new SqlCommand(update, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                //listboxDataPblm = 1;
                resetAll();
                Response.Redirect("createOwners.aspx");
            }
            else errorMsg.Visible = true;
            //selectListBoxPblm = 0;

            //resetAlltextbox();
        }


        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectListBoxPblm == 1)
            {
                conn.Open();
                string deletedata = "delete from storageownerinformation where No='" + ListBox1.SelectedIndex + "' ";
                SqlCommand cmd = new SqlCommand(deletedata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                deletedata = "delete from assignownerinformation where OwnerName='" + ListBox1.SelectedValue + "' ";
                cmd = new SqlCommand(deletedata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                //Sort No in data table
                int newNo = 0;
                for (int i = 0; i < no; i++)
                {
                    conn.Open();
                    string delete = "select No from storageownerinformation where No='" + i + "' ";
                    cmd = new SqlCommand(delete, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        conn.Close();

                        conn.Open();
                        string update = "update storageownerinformation set No='" + newNo + "' where No='" + i + "' ";
                        cmd = new SqlCommand(update, conn);
                        cmd.ExecuteNonQuery();
                        newNo++;
                    }
                    conn.Close();
                }
                int sortAssingNo = 0;
                for (int i = 0; i < assignNo; i++)
                {
                    conn.Open();
                    string delete = "select No from assignownerinformation where No='" + i + "' ";
                    cmd = new SqlCommand(delete, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        conn.Close();

                        conn.Open();
                        string update = "update assignownerinformation set No='" + sortAssingNo + "' where No='" + i + "' ";
                        cmd = new SqlCommand(update, conn);
                        cmd.ExecuteNonQuery();
                        sortAssingNo++;
                    }
                    conn.Close();
                }

                //listboxDataPblm = 1;
                resetAll();
                Response.Redirect("createOwners.aspx");
                //selectListBoxPblm = 0;
                //resetAlltextbox();
            }
            else errorMsg.Visible = true;
        }

        protected void DashBoardLinkButton_Click(object sender, EventArgs e)
        {
            resetAll();
            //selectListBoxPblm = 0;
            Response.Redirect("dashboard.aspx");
        }
        //Reset all variables
        void resetAll()
        {
            selectListBoxPblm = 0;
            selectOwnernametext = 0;
            selectAddresstext = 0;
            selectUseridtext = 0;
            selectPasswordtext = 0;
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            //selectOwnernametext=0
            resetAll();
            Response.Redirect("createOwners.aspx");
            //resetAlltextbox();
        }
        static int selectOwnernametext = 0, selectAddresstext = 0, selectUseridtext = 0, selectPasswordtext = 0;
        protected void OwnerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ownerNameErrorMsg.Visible = false;
            selectOwnernametext = 1;
        }

        protected void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            addressErrorMsg.Visible = false;
            selectAddresstext = 1;
        }

        protected void UserIdTextBox_TextChanged(object sender, EventArgs e)
        {
            userIdErrorMsg.Visible = false;
            selectUseridtext = 1;
        }

        protected void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordErrorMsg.Visible = false;
            selectPasswordtext = 1;
        }
    }
}