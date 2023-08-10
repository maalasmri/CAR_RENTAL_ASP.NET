using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KFMCproject
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                crudop.Visible = false;
                if (Session["role"].Equals("user"))
                {
                    logout.Visible = true;
                    user.Visible = true;
                    login.Visible = false;
                    user.InnerText = "Greetings " + Session["username"].ToString();
                }
                else if (Session["role"].Equals("admin"))
                {
                    crudop.Visible = true;
                    logout.Visible = true;
                    user.Visible = true;
                    login.Visible = false;
                    user.InnerText = "Greetings Admin"; //+ Session["username"].ToString();
                }
                
               
                
            }
            catch (Exception )
            {

            }
        }
    }
}
        