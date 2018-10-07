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
    public partial class assignOwners : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);

        static int storageNo, listboxDataPblm = 1, selectListBoxPblm=0,selectdropDownBoxPblm=0, dropdownDataPblm = 1, no, assignNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            ///For Display Storage Name
            PrintStoreName();
            fillDropdownbox();
            fillListbox();
            
        }
        ///For Display Storage Name   
        void PrintStoreName()
        {
            conn.Open();
            string showStorageName = "select StorageName from storageinformation where StorageNo='" + storageNo + "' ";
            SqlCommand cmd2 = new SqlCommand(showStorageName, conn);
            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                StoreNameLabel.Text = reader["StorageName"].ToString(); ///Storage Name(Lable)
                ///
                //Response.Write(totalitemSize);
                
            }
            conn.Close();
        }
        void fillDropdownbox()
        {
            ///Find Number of owners in data table
            conn.Open();
            string checkdata = "select count(No) from storageownerinformation";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            no = (int)cmd.ExecuteScalar();
            conn.Close();
            ///Find Number of Assign owners in data table
            conn.Open();
            checkdata = "select count(No) from assignownerinformation";
            cmd = new SqlCommand(checkdata, conn);
            assignNo= (int)cmd.ExecuteScalar();
            conn.Close();

            if(dropdownDataPblm==1){
                dropdownDataPblm = 0;
                for (int i = 0; i < no; i++)
                {
                    conn.Open();
                    checkdata = "select OwnerName from storageownerinformation where No='" + i + "'";
                    SqlCommand cmd2 = new SqlCommand(checkdata, conn);
                    SqlDataReader reader = cmd2.ExecuteReader();

                    //conn.Close();
                    if (reader.Read())
                    {
                        string NAME = reader["OwnerName"].ToString();
                        conn.Close();
                        if(checkOwnername(NAME))
                            ownersDropDownList.Items.Add(NAME);        ///Storage Name(Lable)
                    }
                }
                conn.Close();
            }
        }
        bool checkOwnername(string name) {
            //conn.Close();
            //Response.Write("N: "+name+"  ");
            for (int i = 0; i < assignNo; i++)
            {
                //conn.Close();
                conn.Open();
                string checkpassword = "select OwnerName from assignownerinformation where No='" + i + "' and StorageNo='" + storageNo + "' ";
                SqlCommand cmd2 = new SqlCommand(checkpassword, conn);
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                {
                    string ownerN=reader["OwnerName"].ToString();
                    //Response.Write("OW:" + ownerN + "  ");
                    //Check OwnerName & AssignOwnerName same ki nahh
                    if (string.Equals(ownerN, name, StringComparison.Ordinal))
                    {
                        conn.Close();
                        //Response.Write("1  ");
                        return false;
                    }
                }
                
                conn.Close();
            }
            
            return true;
        }
        void fillListbox() {
            if (listboxDataPblm == 1)
           {
               for (int i = 0; i < assignNo; i++)
               {
                   conn.Open();
                   string checkpassword = "select OwnerName from assignownerinformation where No='" + i + "' and StorageNo='" + storageNo + "' ";
                   SqlCommand cmd2 = new SqlCommand(checkpassword, conn);
                   SqlDataReader reader = cmd2.ExecuteReader();
                   if (reader.Read())
                   {
                       ownersNameListBox.Items.Add(reader["OwnerName"].ToString());
                   }
                   conn.Close();
                    
               }
               listboxDataPblm = 0;
           }

        }
        //For get Storage No
        public void getStorageNo(int stgNo)
        {
            storageNo = stgNo;
        }

        protected void btnDashboard_Click(object sender, EventArgs e)
        {
            ///For display Listbox data & dropdownBox data
            dropdownDataPblm = 1;
            listboxDataPblm = 1;
            Response.Redirect("dashBoard.aspx");
        }
        //Assign Owner Button
        protected void btnAssign_Click(object sender, EventArgs e)
        {
            /*if (ownersDropDownList.SelectedValue == " ") {
                Response.Write("Cool");
            }*/
            if (selectdropDownBoxPblm == 1)
            {
                conn.Open();
                string assign = "insert into assignownerinformation (No, StorageNo, StorageName ,OwnerName ,UserId , Password) values('" + assignNo + "','" + storageNo + "','" + StoreNameLabel.Text + "','" + ownerName + "','" + userId + "','" + passWord + "') ";
                SqlCommand cmd = new SqlCommand(assign, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                ///For display Listbox data & dropdownBox data
                dropdownDataPblm = 1;
                listboxDataPblm = 1;
                Response.Redirect("assignOwners.aspx");
            }
            else dropDownerrorMsg.Visible = true;
        }
        static string ownerName,userId,passWord;
        protected void ownersDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            ownerName = ownersDropDownList.SelectedValue;
            string data = "select * from storageownerinformation where OwnerName='" + ownerName + "' ";
            SqlCommand cmd = new SqlCommand(data, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                 userId = reader["UserId"].ToString();
                 passWord = reader["Password"].ToString();     
            }
            conn.Close();
            selectdropDownBoxPblm = 1;
            dropDownerrorMsg.Visible = false;
            //Response.Write("Ow=" + ownerName + "  UserId=" + userId + "  Pass=" + passWord);
        }

        protected void ownersNameListBox_Click(object sender, EventArgs e)
        {
            selectListBoxPblm = 1;
            errorMsg.Visible = false;
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            if (selectListBoxPblm == 1)
            {
                conn.Open();
                string data = "delete from assignownerinformation where OwnerName='" + ownersNameListBox.SelectedValue + "' ";
                SqlCommand cmd = new SqlCommand(data, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                int sortAssingNo = 0;
                for (int i = 0; i < assignNo; i++)
                {
                    conn.Open();
                    string sortNo = "select No from assignownerinformation where No='" + i + "' ";
                    cmd = new SqlCommand(sortNo, conn);
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
                ///For display Listbox data & dropdownBox data
                dropdownDataPblm = 1;
                listboxDataPblm = 1;

                Response.Redirect("assignOwners.aspx");
            }
            else errorMsg.Visible = true;
        }
    }
}