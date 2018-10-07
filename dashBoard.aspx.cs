using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCMSWebsite
{
    public partial class dashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateStoreButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("createstore.aspx");
        }

        protected void AssignOwnersButton_Click(object sender, EventArgs e)
        {
            if (selectListBoxPblm == 1)
            {
                selectListBoxPblm = 0;
                new assignOwners().getStorageNo(ListBox1.SelectedIndex);
                Response.Redirect("assignOwners.aspx");
            }
            else errorMsg.Visible = true;
        }
        static int selectListBoxPblm = 0;
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectListBoxPblm = 1;
        }

        protected void LogoutLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("FirstPage.aspx");
        }

        protected void btnCreateOwners_Click(object sender, EventArgs e)
        {
            //new createOwners().getStorageNo(ListBox1.SelectedIndex);
            new createOwners().clickDashBoard();
            //Response.Write(ListBox1.SelectedIndex);
            Response.Redirect("createOwners.aspx");
         
        }
    }
}