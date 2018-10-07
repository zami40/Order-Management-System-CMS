using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace OnlineCMSWebsite
{
    public partial class createStore : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);
        //int serialNo=0,saveSrlNo=0;
        public static int count, selectListBoxPblm=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            count = 0;
            string checkdata = "select count(StorageNo) from storageinformation";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            //count means number of storage
            count = (int)cmd.ExecuteScalar();
            conn.Close();
            //Response.Write(count+"   ");
            

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            int l = ListBox1.SelectedIndex;
            //saveOwnerName = ListBox1.SelectedValue;
            string data = "select * from storageinformation where StorageNo='" + l + "'";
            SqlCommand cmd = new SqlCommand(data, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                StorageNameTextBox.Text = reader["StorageName"].ToString();
                TltSzLabel.Text = reader["TotalSize"].ToString();
                Image2.ImageUrl = reader["Icon"].ToString();
            }
            conn.Close();
            selectListBoxPblm = 1; ///Selected
            errorMsg.Visible = false;
        }
        protected void CreateStoreButton_Click(object sender, EventArgs e)
        {
            if(selectStoragenametext==1 && (selectItem5==1 || selectItem10==1 || selectItem15==1) )
            Do(0);
            else
            {
                if(selectStoragenametext!=1) storageNameErrorMsg.Visible=true;
                if (selectItem5 == 1 || selectItem10 == 1 || selectItem15 == 1) checkBoxErrorMsg.Visible = true;

            }
        }
        static int checkedBoxSts = 0;
        void Do(int check)
        {
            string pathname;
            if (ProductIconFileUpload.HasFile)
            {
                string Exception = System.IO.Path.GetExtension(ProductIconFileUpload.FileName);
                if (Exception.ToLower() != ".gif" && Exception.ToLower() != ".png" && Exception.ToLower() != ".jpg" && Exception.ToLower() != ".jpeg")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Invalid image format');", true);
                }
                else
                {
                    int FileSIze = ProductIconFileUpload.PostedFile.ContentLength;
                    if (FileSIze > 1048576)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Maximum file size 1 mb');", true);


                    }
                    else
                    {
                        pathname = "uploadImages/" + Path.GetFileName(ProductIconFileUpload.PostedFile.FileName);

                        ProductIconFileUpload.SaveAs(Server.MapPath("~/uploadImages/" + ProductIconFileUpload.FileName));
                        Do2(check, pathname);
                    }
                }
            }
            else
            {
                pathname = Image2.ImageUrl;

                //ProductIconFileUpload.SaveAs(Server.MapPath("~/uploadImages/" + ProductIconFileUpload.FileName));
                Do2(check, pathname);
            }
        }
        static int TotalSize;
        void Do2(int check,string pathname)
        {
            conn.Open();
            

            string insertdata;
            if (ItemSz5CheckBox.Checked == true)
            {
                ItemSz10CheckBox.Checked = false;
                ItemSz15CheckBox.Checked = false;
                if (check == 0) insertdata = "insert into storageinformation (StorageNo,StorageName,Icon,TotalSize) values (@Strgno,@StrgName,@Icon,@TotalSz)";
                else
                {
                    insertdata = "update storageinformation set StorageNo=@Strgno,StorageName=@StrgName,Icon=@Icon,TotalSize=@TotalSz where StorageNo='" + ListBox1.SelectedIndex + " '";
                    checkedBoxSts = 1;
                } 
                TotalSize = 5;
            }
            else if (ItemSz10CheckBox.Checked == true)
            {

                ItemSz5CheckBox.Checked = false;
                ItemSz15CheckBox.Checked = false;
                if (check == 0) insertdata = "insert into storageinformation (StorageNo,StorageName,Icon,TotalSize) values (@Strgno,@StrgName,@Icon,@TotalSz)";
                else
                {
                    insertdata = "update storageinformation set StorageNo=@Strgno,StorageName=@StrgName,Icon=@Icon,TotalSize=@TotalSz where StorageNo='" + ListBox1.SelectedIndex + "' ";
                    checkedBoxSts = 1;
                }
                TotalSize = 10;
            }
            else if (ItemSz15CheckBox.Checked == true)
            {
                ItemSz5CheckBox.Checked = false;
                ItemSz10CheckBox.Checked = false;
                if (check == 0) insertdata = "insert into storageinformation (StorageNo,StorageName,Icon,TotalSize) values (@Strgno,@StrgName,@Icon,@TotalSz)";
                else
                {
                    insertdata = "update storageinformation set StorageNo=@Strgno,StorageName=@StrgName,Icon=@Icon,TotalSize=@TotalSz where StorageNo='" + ListBox1.SelectedIndex + "' ";
                    checkedBoxSts = 1;
                }
                TotalSize = 15;
            }
            else
            {
                if (check == 0) insertdata = "insert into storageinformation (StorageNo,StorageName,Icon,TotalSize) values (@Strgno,@StrgName,@Icon,@TotalSz)";
                else
                {
                    insertdata = "update storageinformation set StorageNo=@Strgno,StorageName=@StrgName,Icon=@Icon,TotalSize=@TotalSz where StorageNo='" + ListBox1.SelectedIndex + "' ";
                    checkedBoxSts = 0;
                }
            }
            if (check == 1) //if click Update_button 
            {
                if (checkedBoxSts == 0) TotalSize = Convert.ToInt32(TltSzLabel.Text); //total size checked_box jodi select na kore
            }
            SqlCommand cmd = new SqlCommand(insertdata, conn);
            if (check == 0) cmd.Parameters.AddWithValue("@Strgno", count); //if click Create_Store_button 
            else cmd.Parameters.AddWithValue("@Strgno", ListBox1.SelectedIndex); //if click Update_button 
            
            cmd.Parameters.AddWithValue("@StrgName", StorageNameTextBox.Text);
            cmd.Parameters.AddWithValue("@Icon", pathname);
            cmd.Parameters.AddWithValue("@TotalSz", TotalSize);
            cmd.ExecuteNonQuery();
            conn.Close();

            if(check==0)  ProductIconFileUpload.SaveAs(Server.MapPath("~/uploadImages/" + ProductIconFileUpload.FileName));

            
            //For Create Table
            if (check == 0)
            {
                conn.Open();
                string createtable = "CREATE TABLE [dbo].[storeserialno" + count + "] ([ProductId] INT NOT NULL, [ProductName] CHAR (50) NULL, [ProductPrice] CHAR (50) NULL, [Icon] NVARCHAR (50) NULL,[Quantity] INT NULL, PRIMARY KEY CLUSTERED ([ProductId] ASC))";
                cmd = new SqlCommand(createtable, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            ///For update Storage Name in assignownerinformation data table
            if (check == 1) {
                conn.Open();
                string checkdata = "select count(No) from assignownerinformation";
                cmd = new SqlCommand(checkdata, conn);
                int assignNo = (int)cmd.ExecuteScalar();
                //Response.Write(assignNo+"   ");
                conn.Close();

                for (int i = 0; i < assignNo; i++)
                {
                    conn.Open();
                    string checkpassword = "update assignownerinformation set StorageName='" + StorageNameTextBox.Text + "' where No='" + i + "' and StorageNo='" + ListBox1.SelectedIndex + "'  ";
                    SqlCommand cmd2 = new SqlCommand(checkpassword, conn);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        
                    }
                    conn.Close();
                }
            
            }
            ListBox1.Items.Clear();//For clear listbox

            count++;
            selectListBoxPblm = 0;
            resetAll();   
            Response.Redirect("createStore.aspx");   //Reload for seeing listbox with full data
          
        }
        

        protected void EditStoreButton_Click(object sender, EventArgs e)
        {
            if (selectListBoxPblm == 1)
            {
                selectListBoxPblm = 0;
                Do(1);
            }
            else errorMsg.Visible = true;
        }

        protected void DashBoardLinkButton_Click(object sender, EventArgs e)
        {
            selectListBoxPblm = 0;
            Response.Redirect("dashboard.aspx");
        }
        void resetAll() {
            selectStoragenametext = 0;
            selectItem5 = 0;
            selectItem10 = 0;
            selectItem15 = 0;
        }
        static int selectStoragenametext = 0, selectItem5 = 0, selectItem10 = 0, selectItem15 = 0;
        protected void StorageNameTextBox_TextChanged(object sender, EventArgs e)
        {
            storageNameErrorMsg.Visible = false;
            selectStoragenametext = 1;
        }

        protected void ItemSz5CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxErrorMsg.Visible = false;
            selectItem5 = 1;
        }

        protected void ItemSz10CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxErrorMsg.Visible = false;
            selectItem10 = 1;
        }

        protected void ItemSz15CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxErrorMsg.Visible = false;
            selectItem15 = 1;
        }
    }
}