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
    public partial class store : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);
        static int storageNo;
        static int NumberOfitem, totalitemSize, listboxDataPblm = 1, selectListBoxPblm=0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(listboxDataPblm+"  ");
            conn.Open();
            NumberOfitem = 0;
            string checkdata = "select count(ProductId) from storeserialno" + storageNo + " ";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            NumberOfitem = (int)cmd.ExecuteScalar();
            conn.Close();

            //Response.Write(NumberOfitem+"  ");
            conn.Open();
            string getitemsize = "select * from storageinformation where StorageNo='" + storageNo + "' ";
            SqlCommand cmd2 = new SqlCommand(getitemsize, conn);
            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                StoreNameLabel.Text = reader["StorageName"].ToString(); ///Storage Name(Lable)
                                                                        ///
                totalitemSize = Convert.ToInt32(reader["TotalSize"].ToString());
                //Response.Write("T Size "+totalitemSize);
            
            }
            conn.Close();
            //if (showitemPblm == 0) NumberOfitem = NumberOfitem + 1;
            int saveNumberOfitem = NumberOfitem;
            if (listboxDataPblm == 1)
            {
                if (NumberOfitem <= totalitemSize)
                {
                    //Response.Write("Done  ");
                    for (int i = 0; i <= saveNumberOfitem; i++)
                    {
                        conn.Open();
                        string checkpassword = "select ProductName from storeserialno" + storageNo + "  where ProductId='" + i + "' ";
                        cmd2 = new SqlCommand(checkpassword, conn);
                        reader = cmd2.ExecuteReader();
                        if (reader.Read())
                        {
                            ListBox1.Items.Add(reader["ProductName"].ToString());
                            //productNo++;

                        }
                        conn.Close();
                    }
                }
                listboxDataPblm = 0;
            }
            //if (NumberOfitem == totalitemSize) showitemPblm = 0;
            //Response.Write(productNo);
            
        }
        
        public void getSerialNumberANDlistboxPblm(int srlNo,int value) {
            storageNo = srlNo;
            listboxDataPblm = value;
        }
        string saveOwnerName;
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListBox1.Items.Clear();
            
            conn.Open();
            int l = ListBox1.SelectedIndex;
            saveOwnerName = ListBox1.SelectedValue;
            string data = "select * from storeserialno" + storageNo + " where ProductId='"+l+"'";
            SqlCommand cmd = new SqlCommand(data, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ProductNameTextBox.Text = reader["ProductName"].ToString();
                ProductPriceTextBox.Text = reader["ProductPrice"].ToString();
                iconImage.ImageUrl=reader["Icon"].ToString();
                QuantityTextBox.Text = reader["Quantity"].ToString();
            }
            conn.Close();
            errorMsg.Visible = false;
            selectListBoxPblm = 1;
        }
        protected void UpdateItemButton_Click(object sender, EventArgs e)
        {
            string pathname;
            if (ProductIconFileUpload.HasFile)
            {
                pathname = "uploadImages/" + Path.GetFileName(ProductIconFileUpload.PostedFile.FileName);
                ProductIconFileUpload.SaveAs(Server.MapPath("~/uploadImages/" + ProductIconFileUpload.FileName));

            }
            else pathname = iconImage.ImageUrl; 
            if (selectListBoxPblm == 1)
            {
                selectListBoxPblm = 0;
                conn.Open();
                string update = "update storeserialno" + storageNo + " set ProductName='" + ProductNameTextBox.Text + "' , ProductPrice='" + ProductPriceTextBox.Text + "', Icon='"+pathname+"' , Quantity='" + QuantityTextBox.Text + "'  where ProductId='" + ListBox1.SelectedIndex + "' ";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                listboxDataPblm = 1;
                Response.Redirect("store.aspx");
            }
            else errorMsg.Visible = true;

            resetAlltextbox();
        }

        
        //static int checkitemsize = 0; 
        protected void AddItemButton_Click(object sender, EventArgs e)
        {
            if (selectProductnametext == 1 && selectProductpricetext == 1 && selectQuantitytext == 1)
            {
                if (NumberOfitem < totalitemSize)
                {
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
                                string pathname = "uploadImages/" + Path.GetFileName(ProductIconFileUpload.PostedFile.FileName);

                                conn.Open();
                                string insertproduct = "insert into storeserialno" + storageNo + " (ProductId,ProductName,ProductPrice,Icon,Quantity) values (@Ptid,@Ptname,@Ptpz,@Icon,@Qty)";
                                SqlCommand cmd = new SqlCommand(insertproduct, conn);

                                cmd.Parameters.AddWithValue("@Ptid", NumberOfitem);
                                cmd.Parameters.AddWithValue("@Ptname", ProductNameTextBox.Text);
                                cmd.Parameters.AddWithValue("@Ptpz", ProductPriceTextBox.Text);
                                cmd.Parameters.AddWithValue("@Icon", pathname);
                                cmd.Parameters.AddWithValue("@Qty", QuantityTextBox.Text);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                ProductIconFileUpload.SaveAs(Server.MapPath("~/uploadImages/" + ProductIconFileUpload.FileName));

                                NumberOfitem++;
                                ListBox1.Items.Clear();//For clear listbox
                                //Image1.ImageUrl = "~/uploadImages/" + ProductIconFileUpload.FileName;
                                //ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('File upload..||');", true);
                                listboxDataPblm = 1;
                                Response.Redirect("store.aspx");
                            }
                        }

                    }// First If
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Please select a file to upload');", true);
                    }
                }
                else
                {
                    //listboxDataPblm = 1;
                    ItemsizeLabel.Text = "Item Numbers Exceed";
                }
            }
            else
            {
                if (selectProductnametext != 1) productNameErrorMsg.Visible = true;
                if (selectProductpricetext != 1) productPriceErrorMsg.Visible = true;
                if (selectQuantitytext != 1) quantityErrorMsg.Visible = true;
            }
            selectListBoxPblm = 0;
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectListBoxPblm == 1)
            {
                selectListBoxPblm = 0;
                conn.Open();
                string deletedata = "delete from storeserialno" + storageNo + " where ProductId='" + ListBox1.SelectedIndex + "' ";
                SqlCommand cmd = new SqlCommand(deletedata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                ///data table No sort (ascending order)
                int newPdctId = 0;
                for (int i = 0; i < NumberOfitem; i++)
                {
                    conn.Open();
                    string delete = "select ProductId from storeserialno" + storageNo + " where ProductId='" + i + "' ";
                    cmd = new SqlCommand(delete, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        conn.Close();

                        conn.Open();
                        string update = "update storeserialno" + storageNo + " set ProductId='" + newPdctId + "' where ProductId='" + i + "' ";
                        cmd = new SqlCommand(update, conn);
                        cmd.ExecuteNonQuery();
                        newPdctId++;
                    }
                    conn.Close();
                }
                listboxDataPblm = 1;
                Response.Redirect("store.aspx");
            }
            else errorMsg.Visible = true;
            resetAlltextbox();
            
        }
        protected void btnDashboard_Click(object sender, EventArgs e)
        {

            selectListBoxPblm = 0;
            new storeadminDashboard().getListboxDataPblmValue(1);
            Response.Redirect("storeadminDashboard.aspx");
        }
        void resetAlltextbox() {
            ProductNameTextBox.Text = "";
            ProductPriceTextBox.Text = "";
            QuantityTextBox.Text = "";
        }
        /// <summary>
        /// Error protector
        /// </summary>
        static int selectProductnametext = 0, selectProductpricetext = 0, selectQuantitytext=0;
        protected void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            productNameErrorMsg.Visible = false;
            selectProductnametext = 1;
        }

        protected void ProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            productPriceErrorMsg.Visible = false;
            selectProductpricetext = 1;
        }

        protected void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            quantityErrorMsg.Visible = false;
            selectQuantitytext = 1;
        } 
    }
}