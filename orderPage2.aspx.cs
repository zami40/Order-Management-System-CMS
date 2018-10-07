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
    public partial class orderPage2 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);
        static int srlno;
        void ForStorageName()
        {
            conn.Open();
            string forstoragename = "select StorageName from storageinformation where StorageNo='" + srlno + "' ";
            SqlCommand cmd = new SqlCommand(forstoragename, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                StoreNameLabel.Text = reader["StorageName"].ToString();

            }
            conn.Close();
        }

        void leftItem() 
        {
            for (int i = 0; i < 15; i++)
            {
                conn.Open();
                string checkdata;
                if (i == 0) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel0.Text + "' ";
                else if (i == 1) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel1.Text + "' ";
                else if (i == 2) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel2.Text + "' ";
                else if (i == 3) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel3.Text + "' ";
                else if (i == 4) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel4.Text + "' ";
                else if (i == 5) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel5.Text + "' ";
                else if (i == 6) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel6.Text + "' ";
                else if (i == 7) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel7.Text + "' ";
                else if (i == 8) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel8.Text + "' ";
                else if (i == 9) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel9.Text + "' ";
                else if (i == 10) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel10.Text + "' ";
                else if (i == 11) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel11.Text + "' ";
                else if (i == 12) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel12.Text + "' ";
                else if (i == 13) checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel13.Text + "' ";
                else checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + PNLabel14.Text + "' ";


                SqlCommand cmd = new SqlCommand(checkdata, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (i == 0)
                    {
                        SampleLabel0.Text = reader["Quantity"].ToString();
                        if(SampleLabel0.Text !="0") SampleTextBox0.Visible = true;
                    }
                    else if (i == 1)
                    {
                        SampleLabel1.Text = reader["Quantity"].ToString();
                        if (SampleLabel1.Text != "0") SampleTextBox1.Visible = true;

                    }
                    else if (i == 2)
                    {
                        SampleLabel2.Text = reader["Quantity"].ToString();
                        if (SampleLabel2.Text != "0") SampleTextBox2.Visible = true;
                    }
                    else if (i == 3)
                    {
                        SampleLabel3.Text = reader["Quantity"].ToString();
                        if (SampleLabel3.Text != "0") SampleTextBox3.Visible = true;
                    }
                    else if (i == 4)
                    {
                        SampleLabel4.Text = reader["Quantity"].ToString();
                        if (SampleLabel4.Text != "0") SampleTextBox4.Visible = true;
                    }
                    else if (i == 5)
                    {
                        SampleLabel5.Text = reader["Quantity"].ToString();
                        if (SampleLabel5.Text != "0") SampleTextBox5.Visible = true;
                    }
                    else if (i == 6)
                    {
                        SampleLabel6.Text = reader["Quantity"].ToString();
                        if (SampleLabel6.Text != "0") SampleTextBox6.Visible = true;
                    }
                    else if (i == 7)
                    {
                        SampleLabel7.Text = reader["Quantity"].ToString();
                        if (SampleLabel7.Text != "0") SampleTextBox7.Visible = true;
                    }
                    else if (i == 8)
                    {
                        SampleLabel8.Text = reader["Quantity"].ToString();
                        if (SampleLabel8.Text != "0") SampleTextBox8.Visible = true;
                    }
                    else if (i == 9)
                    {
                        SampleLabel9.Text = reader["Quantity"].ToString();
                        if (SampleLabel9.Text != "0") SampleTextBox9.Visible = true;
                    }
                    else if (i == 10)
                    {
                        SampleLabel10.Text = reader["Quantity"].ToString();
                        if (SampleLabel10.Text != "0") SampleTextBox10.Visible = true;
                    }
                    else if (i == 11)
                    {
                        SampleLabel11.Text = reader["Quantity"].ToString();
                        if(SampleLabel11.Text !="0") SampleTextBox11.Visible = true;
                    }
                    else if (i == 12)
                    {
                        SampleLabel12.Text = reader["Quantity"].ToString();
                        if (SampleLabel12.Text != "0") SampleTextBox12.Visible = true;
                    }
                    else if (i == 13)
                    {
                        SampleLabel13.Text = reader["Quantity"].ToString();
                        if (SampleLabel13.Text != "0") SampleTextBox13.Visible = true;
                    }
                    else
                    {
                        SampleLabel14.Text = reader["Quantity"].ToString();
                        if (SampleLabel14.Text != "0") SampleTextBox14.Visible = true;
                    }
                }
                conn.Close();
            }
        }

        static int numberofproduct = 0;
        public void getNumberOfProduct(int numberofProduct)
        {
            numberofproduct = numberofProduct;
        }
        
        public void getSrlNo(int getsrlno)
        {
            srlno = getsrlno;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ForStorageName();
            GettableSrlNo();
            //Fill ProductName & ProductPrice Lable
            conn.Open();
            string checkdata = "select * from customerinformation where flag='0' ";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                PNLabel0.Text = reader["ProductName1"].ToString();
                PPLabel0.Text = reader["ProductPrice1"].ToString();
                
                PNLabel1.Text = reader["ProductName2"].ToString();
                PPLabel1.Text = reader["ProductPrice2"].ToString();
                
                PNLabel2.Text = reader["ProductName3"].ToString();
                PPLabel2.Text = reader["ProductPrice3"].ToString();
                
                PNLabel3.Text = reader["ProductName4"].ToString();
                PPLabel3.Text = reader["ProductPrice4"].ToString();
                
                PNLabel4.Text = reader["ProductName5"].ToString();
                PPLabel4.Text = reader["ProductPrice5"].ToString();

                PNLabel5.Text = reader["ProductName6"].ToString();
                PPLabel5.Text = reader["ProductPrice6"].ToString();

                PNLabel6.Text = reader["ProductName7"].ToString();
                PPLabel6.Text = reader["ProductPrice7"].ToString();

                PNLabel7.Text = reader["ProductName8"].ToString();
                PPLabel7.Text = reader["ProductPrice8"].ToString();

                PNLabel8.Text = reader["ProductName9"].ToString();
                PPLabel8.Text = reader["ProductPrice9"].ToString();

                PNLabel9.Text = reader["ProductName10"].ToString();
                PPLabel9.Text = reader["ProductPrice10"].ToString();

                PNLabel10.Text = reader["ProductName11"].ToString();
                PPLabel10.Text = reader["ProductPrice11"].ToString();

                PNLabel11.Text = reader["ProductName12"].ToString();
                PPLabel11.Text = reader["ProductPrice12"].ToString();

                PNLabel12.Text = reader["ProductName13"].ToString();
                PPLabel12.Text = reader["ProductPrice13"].ToString();

                PNLabel13.Text = reader["ProductName14"].ToString();
                PPLabel13.Text = reader["ProductPrice14"].ToString();

                PNLabel14.Text = reader["ProductName15"].ToString();
                PPLabel14.Text = reader["ProductPrice15"].ToString();

            }
            conn.Close();
            leftItem();
            //SampleTextBoxVisi_Invisi();
        }
        static int tableSrlNo=0;
        void GettableSrlNo()
        {
            conn.Open();
            string insertdata = "select count(SrlNo) from customerinformation  where StorageNo='" + srlno + "' ";
            SqlCommand cmd = new SqlCommand(insertdata, conn);
            tableSrlNo = (int)cmd.ExecuteScalar();
            tableSrlNo++;
            conn.Close();
        }
        static int cusNo;
        public void getCustomerNo(int cNo) 
        {
            cusNo = cNo;
            
        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertdata = "update customerinformation set SrlNo='"+tableSrlNo+"' , DeliveryStatus='Not Done', Date='" + DateTextBox.Text + "',CustomerName='" + CustomerNameTextBox.Text + "' ,CreditCard='" + CreditCardTextBox.Text + "' ,Address='" + AddressTextBox.Text + "',TotalTaka='"+TotalTakaLabel.Text+"',flag='1' where No='" + cusNo + "' ";
            SqlCommand cmd = new SqlCommand(insertdata, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            
            int sampleLabel=0,sampleText=0;
            if (SampleTextBox0.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel0.Text);
                sampleText = Convert.ToInt32(SampleTextBox0.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel0.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                insertdata = "update customerinformation set Quantity1='" + SampleTextBox0.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox1.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel1.Text);
                sampleText = Convert.ToInt32(SampleTextBox1.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel1.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                insertdata = "update customerinformation set Quantity2='" + SampleTextBox1.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox2.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel2.Text);
                sampleText = Convert.ToInt32(SampleTextBox2.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel2.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                insertdata = "update customerinformation set Quantity3='" + SampleTextBox2.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox3.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel3.Text);
                sampleText = Convert.ToInt32(SampleTextBox3.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel3.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox4.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel4.Text);
                sampleText = Convert.ToInt32(SampleTextBox4.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel4.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox5.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel5.Text);
                sampleText = Convert.ToInt32(SampleTextBox5.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel5.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            } 
            if (SampleTextBox6.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel6.Text);
                sampleText = Convert.ToInt32(SampleTextBox6.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel6.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox7.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel7.Text);
                sampleText = Convert.ToInt32(SampleTextBox7.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel7.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox8.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel8.Text);
                sampleText = Convert.ToInt32(SampleTextBox8.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel8.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox9.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel9.Text);
                sampleText = Convert.ToInt32(SampleTextBox9.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel9.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox10.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel10.Text);
                sampleText = Convert.ToInt32(SampleTextBox10.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel10.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox11.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel11.Text);
                sampleText = Convert.ToInt32(SampleTextBox11.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel11.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox12.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel12.Text);
                sampleText = Convert.ToInt32(SampleTextBox12.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel12.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox13.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel13.Text);
                sampleText = Convert.ToInt32(SampleTextBox13.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel13.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (SampleTextBox14.Visible == true)
            {
                sampleLabel = Convert.ToInt32(SampleLabel14.Text);
                sampleText = Convert.ToInt32(SampleTextBox14.Text);
                sampleLabel = sampleLabel - sampleText;
                conn.Open();
                insertdata = "update storeserialno" + srlno + " set Quantity='" + sampleLabel + "' where ProductName='" + PNLabel14.Text + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            leftItem();
            CompleteLabel.Text = "Completed";
        
        }
        

        protected void HomeLinkButton_Click(object sender, EventArgs e)
        {
            
            orderPage H = new orderPage();
            H.getSrlNo(srlno);
            Response.Redirect("orderPage.aspx");
        }
        public void getQuantitypblm(int v) {
            quantityExceedpblm = v;
        }
        static int quantityExceedpblm = 1; //ok
        protected void TakaButton_Click(object sender, EventArgs e)
        {
            int text=0, label=0,total=0,quantityText=0,quantityLable=0;
            if (SampleTextBox0.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox0.Text);
                quantityLable=Convert.ToInt32(SampleLabel0.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel0.Text);
                    text = Convert.ToInt32(SampleTextBox0.Text);
                    total = total + (text * label);
                    quantityExceedLabel0.Visible = false;

                }
                else
                {
                    quantityExceedLabel0.Visible = true;
                    quantityExceedpblm = 0;
                }
            } 
            if (SampleTextBox1.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox1.Text);
                quantityLable=Convert.ToInt32(SampleLabel1.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel1.Text);
                    text = Convert.ToInt32(SampleTextBox1.Text);
                    total = total + (text * label);

                    quantityExceedLabel1.Visible = false;
                }
                else
                {
                    quantityExceedLabel1.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox2.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox2.Text);
                quantityLable=Convert.ToInt32(SampleLabel2.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel2.Text);
                    text = Convert.ToInt32(SampleTextBox2.Text);
                    total = total + (text * label);
                    quantityExceedLabel2.Visible = false;
                }
                else
                {
                    quantityExceedLabel2.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox3.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox3.Text);
                quantityLable=Convert.ToInt32(SampleLabel3.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel3.Text);
                    text = Convert.ToInt32(SampleTextBox3.Text);
                    total = total + (text * label);
                    quantityExceedLabel3.Visible = false;
                }
                else
                {
                    quantityExceedLabel3.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox4.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox4.Text);
                quantityLable=Convert.ToInt32(SampleLabel4.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel4.Text);
                    text = Convert.ToInt32(SampleTextBox4.Text);
                    total = total + (text * label);
                    quantityExceedLabel4.Visible = false;
                }
                else
                {
                    quantityExceedLabel4.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox5.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox5.Text);
                quantityLable=Convert.ToInt32(SampleLabel5.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel5.Text);
                    text = Convert.ToInt32(SampleTextBox5.Text);
                    total = total + (text * label);
                    quantityExceedLabel5.Visible = false;
                }
                else
                {
                    quantityExceedLabel5.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox6.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox6.Text);
                quantityLable=Convert.ToInt32(SampleLabel6.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel6.Text);
                    text = Convert.ToInt32(SampleTextBox6.Text);
                    total = total + (text * label);
                    quantityExceedLabel6.Visible = false;
                }
                else
                {
                    quantityExceedLabel6.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox7.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox7.Text);
                quantityLable=Convert.ToInt32(SampleLabel7.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel7.Text);
                    text = Convert.ToInt32(SampleTextBox7.Text);
                    total = total + (text * label);
                    quantityExceedLabel7.Visible = false;
                }
                else
                {
                    quantityExceedLabel7.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox8.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox8.Text);
                quantityLable=Convert.ToInt32(SampleLabel8.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel8.Text);
                    text = Convert.ToInt32(SampleTextBox8.Text);
                    total = total + (text * label);
                    quantityExceedLabel8.Visible = false;
                }
                else
                {
                    quantityExceedLabel8.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox9.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox9.Text);
                quantityLable=Convert.ToInt32(SampleLabel9.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel9.Text);
                    text = Convert.ToInt32(SampleTextBox9.Text);
                    total = total + (text * label);
                    quantityExceedLabel9.Visible = false;
                }
                else
                {
                    quantityExceedLabel9.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox10.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox10.Text);
                quantityLable=Convert.ToInt32(SampleLabel10.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel10.Text);
                    text = Convert.ToInt32(SampleTextBox10.Text);
                    total = total + (text * label);
                    quantityExceedLabel10.Visible = false;
                }
                else
                {
                    quantityExceedLabel10.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox11.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox11.Text);
                quantityLable=Convert.ToInt32(SampleLabel11.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel11.Text);
                    text = Convert.ToInt32(SampleTextBox11.Text);
                    total = total + (text * label);
                    quantityExceedLabel11.Visible = false;
                }
                else
                {
                    quantityExceedLabel11.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox12.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox12.Text);
                quantityLable=Convert.ToInt32(SampleLabel12.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel12.Text);
                    text = Convert.ToInt32(SampleTextBox12.Text);
                    total = total + (text * label);
                    quantityExceedLabel2.Visible = false;
                }
                else
                {
                    quantityExceedLabel12.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox13.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox13.Text);
                quantityLable=Convert.ToInt32(SampleLabel13.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel13.Text);
                    text = Convert.ToInt32(SampleTextBox13.Text);
                    total = total + (text * label);
                    quantityExceedLabel13.Visible = false;
                }
                else
                {
                    quantityExceedLabel13.Visible = true;
                    quantityExceedpblm = 0;
                }
            }
            if (SampleTextBox14.Visible == true)
            {
                quantityText=Convert.ToInt32(SampleTextBox14.Text);
                quantityLable=Convert.ToInt32(SampleLabel14.Text);
                if (quantityText <= quantityLable)
                {
                    label = Convert.ToInt32(PPLabel14.Text);
                    text = Convert.ToInt32(SampleTextBox14.Text);
                    total = total + (text * label);
                    quantityExceedLabel14.Visible = false;
                }
                else
                {
                    quantityExceedLabel14.Visible = true;
                    quantityExceedpblm = 0;
                }
            }

            if (quantityExceedpblm == 1) TotalTakaLabel.Text = total.ToString();
            else quantityExceedpblm = 1;
        }


        //public bool sam { get; set; }
    }
}