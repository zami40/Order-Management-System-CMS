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
    public partial class orderPage : System.Web.UI.Page
    {
        //Label l[5] = new Label();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);
        static int srlno, numbrofproduct,customerno=0;
        static string Storagename;
        void ForStorageName() {
            new orderPage2().getSrlNo(srlno);
            //Response.Write(srlno);
            
            conn.Open();
            string forstoragename = "select StorageName from storageinformation where StorageNo='" + srlno + "' ";
            SqlCommand cmd = new SqlCommand(forstoragename, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                StoreNameLabel.Text = reader["StorageName"].ToString();
                Storagename = reader["StorageName"].ToString();

            }
            conn.Close();
        }
        void goCustomerInformationTable() {
            conn.Open();
            string checkdata = "select count(No) from customerinformation";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            customerno = (int)cmd.ExecuteScalar();
            conn.Close();
            customerno++;

            //Delete All where flag 0
            conn.Open();
            string deletedata = "delete from customerinformation where flag='0' ";
            cmd = new SqlCommand(deletedata, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
       
        
        }
        void NumberofProductinStore() {
            numbrofproduct = 0;
            conn.Open();
            string checkdata = "select count(ProductId) from storeserialno" + srlno + " ";
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            numbrofproduct = (int)cmd.ExecuteScalar();
            conn.Close();
            new orderPage2().getNumberOfProduct(numbrofproduct);

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            //Response.Write(srlno);
            ForStorageName();
            NumberofProductinStore();
            ///Number of Customer in customerinformation database table
            goCustomerInformationTable();
            
            //Response.Write(numbrofproduct);
            conn.Close();

            for (int i = 0; i < numbrofproduct; i++)
            {
                conn.Open();
                string forproduct = "select * from storeserialno" + srlno + " where ProductId='"+i+"' ";
                SqlCommand cmd = new SqlCommand(forproduct, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if(i==0){
                        Panel0.Visible = true;
                        PNLabel0.Text=reader["ProductName"].ToString();
                        PPLabel0.Text = reader["ProductPrice"].ToString();
                        QtyLabel0.Text = reader["Quantity"].ToString();
                        Image0.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 1)
                    {
                        Panel1.Visible = true;
                        PNLabel1.Text = reader["ProductName"].ToString();
                        PPLabel1.Text = reader["ProductPrice"].ToString();
                        QtyLabel1.Text = reader["Quantity"].ToString();
                        Image1.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 2)
                    {
                        Panel2.Visible = true;
                        PNLabel2.Text = reader["ProductName"].ToString();
                        PPLabel2.Text = reader["ProductPrice"].ToString();
                        QtyLabel2.Text = reader["Quantity"].ToString();
                        Image2.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 3)
                    {
                        Panel3.Visible = true;
                        PNLabel3.Text = reader["ProductName"].ToString();
                        PPLabel3.Text = reader["ProductPrice"].ToString();
                        QtyLabel3.Text = reader["Quantity"].ToString();
                        Image3.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 4)
                    {
                        Panel4.Visible = true;
                        PNLabel4.Text = reader["ProductName"].ToString();
                        PPLabel4.Text = reader["ProductPrice"].ToString();
                        QtyLabel4.Text = reader["Quantity"].ToString();
                        Image4.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 5)
                    {
                        Panel5.Visible = true;
                        PNLabel5.Text = reader["ProductName"].ToString();
                        PPLabel5.Text = reader["ProductPrice"].ToString();
                        QtyLabel5.Text = reader["Quantity"].ToString();
                        Image5.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 6)
                    {
                        Panel6.Visible = true;
                        PNLabel6.Text = reader["ProductName"].ToString();
                        PPLabel6.Text = reader["ProductPrice"].ToString();
                        QtyLabel6.Text = reader["Quantity"].ToString();
                        Image6.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 7)
                    {
                        Panel7.Visible = true;
                        PNLabel7.Text = reader["ProductName"].ToString();
                        PPLabel7.Text = reader["ProductPrice"].ToString();
                        QtyLabel7.Text = reader["Quantity"].ToString();
                        Image7.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 8)
                    {
                        Panel8.Visible = true;
                        PNLabel8.Text = reader["ProductName"].ToString();
                        PPLabel8.Text = reader["ProductPrice"].ToString();
                        QtyLabel8.Text = reader["Quantity"].ToString();
                        Image8.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 9)
                    {
                        Panel9.Visible = true;
                        PNLabel9.Text = reader["ProductName"].ToString();
                        PPLabel9.Text = reader["ProductPrice"].ToString();
                        QtyLabel9.Text = reader["Quantity"].ToString();
                        Image9.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 10)
                    {
                        Panel10.Visible = true;
                        PNLabel10.Text = reader["ProductName"].ToString();
                        PPLabel10.Text = reader["ProductPrice"].ToString();
                        QtyLabel10.Text = reader["Quantity"].ToString();
                        Image10.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 11)
                    {
                        Panel11.Visible = true;
                        PNLabel11.Text = reader["ProductName"].ToString();
                        PPLabel11.Text = reader["ProductPrice"].ToString();
                        QtyLabel11.Text = reader["Quantity"].ToString();
                        Image11.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 12)
                    {
                        Panel12.Visible = true;
                        PNLabel12.Text = reader["ProductName"].ToString();
                        PPLabel12.Text = reader["ProductPrice"].ToString();
                        QtyLabel12.Text = reader["Quantity"].ToString();
                        Image12.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 13)
                    {
                        Panel13.Visible = true;
                        PNLabel13.Text = reader["ProductName"].ToString();
                        PPLabel13.Text = reader["ProductPrice"].ToString();
                        QtyLabel13.Text = reader["Quantity"].ToString();
                        Image13.ImageUrl = reader["Icon"].ToString();
                    }
                    else if (i == 14)
                    {
                        Panel14.Visible = true;
                        PNLabel14.Text = reader["ProductName"].ToString();
                        PPLabel14.Text = reader["ProductPrice"].ToString();
                        QtyLabel14.Text = reader["Quantity"].ToString();
                        Image14.ImageUrl = reader["Icon"].ToString();
                    }
                    
                }
                conn.Close();
                
            }
        }
        public void getSrlNo(int getsrlno) {
            srlno = getsrlno;
        }
        int productNamePricecounter = 0,checkNumberOfSample=0;
        void AddCart(string pname,string pprice) {
            
            conn.Open();
            string checkdata = "select Quantity from storeserialno" + srlno + " where ProductName='" + pname + "' and ProductPrice='"+pprice+"' "; ;
            SqlCommand cmd = new SqlCommand(checkdata, conn);
            checkNumberOfSample = (int)cmd.ExecuteScalar();
            conn.Close();
            if (checkNumberOfSample > 0)
            {
                productNamePricecounter++;
                conn.Open();
                string insertdata;
                insertdata = "update customerinformation set ProductName" + productNamePricecounter + "='" + pname + "',ProductPrice" + productNamePricecounter + "='" + pprice + "' where No='" + customerno + "' ";
                cmd = new SqlCommand(insertdata, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        protected void AddCartButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertdata = "insert into customerinformation (No,StorageNo,StorageName) values (@No,@StrgNo,@StrgName)";
            SqlCommand cmd = new SqlCommand(insertdata, conn);
            cmd.Parameters.AddWithValue("@No", customerno);
            cmd.Parameters.AddWithValue("@StrgNo", srlno);
            cmd.Parameters.AddWithValue("@StrgName", Storagename);
            cmd.ExecuteNonQuery();
            conn.Close();

            new orderPage2().getCustomerNo(customerno);
            
            if (CheckBox0.Checked == true) AddCart(PNLabel0.Text,PPLabel0.Text);
            if (CheckBox1.Checked == true) AddCart(PNLabel1.Text, PPLabel1.Text);
            if (CheckBox2.Checked == true) AddCart(PNLabel2.Text, PPLabel2.Text);
            if (CheckBox3.Checked == true) AddCart(PNLabel3.Text, PPLabel3.Text);
            if (CheckBox4.Checked == true) AddCart(PNLabel4.Text, PPLabel4.Text);
            if (CheckBox5.Checked == true) AddCart(PNLabel5.Text, PPLabel5.Text);
            if (CheckBox6.Checked == true) AddCart(PNLabel6.Text, PPLabel6.Text);
            if (CheckBox7.Checked == true) AddCart(PNLabel7.Text, PPLabel7.Text);
            if (CheckBox8.Checked == true) AddCart(PNLabel8.Text, PPLabel8.Text);
            if (CheckBox9.Checked == true) AddCart(PNLabel9.Text, PPLabel9.Text);
            if (CheckBox10.Checked == true) AddCart(PNLabel10.Text, PPLabel10.Text);
            if (CheckBox11.Checked == true) AddCart(PNLabel11.Text, PPLabel11.Text);
            if (CheckBox12.Checked == true) AddCart(PNLabel12.Text, PPLabel12.Text);
            if (CheckBox13.Checked == true) AddCart(PNLabel13.Text, PPLabel13.Text);
            if (CheckBox14.Checked == true) AddCart(PNLabel14.Text, PPLabel14.Text);
            
            //new orderPage2().getQuantitypblm(1);
            
            Response.Redirect("orderPage2.aspx");
            
        }

        protected void BackLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("firstPage.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLogin.aspx");
        }
    }
}


/*#region Change Label Name
                   panels.Clear();
                   panels.Add(Panel1);
                   panels.Add(Panel2);
                   panels.Add(Panel3);
                   panels.Add(Panel4);
                   panels.Add(Panel5);
                   panels.Add(Panel6);
                   panels.Add(Panel7);
                   panels.Add(Panel8);
                   panels.Add(Panel9);
                   panels.Add(Panel10);
                   panels.Add(Panel11);
                   panels.Add(Panel12);


                   //int j = 1;
                   foreach (var p in panels)
                   {
                       if (p is Panel)
                       {
                           for (int i = 0; i < p.Controls.Count; i++)
                           {
                               if (p.Controls[i] is Label)
                               {
                                   (p.Controls[i] as Label).Text = reader["ProductName"].ToString();
                                   i++;
                                   (p.Controls[i] as Label).Text = reader["ProductPrize"].ToString();
                               }
                           }
                       }
                   }
                   #endregion
                   */