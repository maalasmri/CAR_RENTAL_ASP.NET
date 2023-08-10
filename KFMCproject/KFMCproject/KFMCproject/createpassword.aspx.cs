using KFMCproject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KFMCproject
{
    public partial class createpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void cerClick(object sender, EventArgs e)
        {

            // username , password , email
            string email = Session["email"].ToString();
            CURD my = new CURD();

            string mySql = @"  update Customer 
                        set username =@username,password = @password
                        where email = '" + email + "'";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@username", usernametext.Text);
            myPara.Add("@password", passwordtext.Text);
            //  myPara.Add("@ddlDep", int.Parse(ddlDep.SelectedValue));


            int rtn = my.InsertUpdateDelete(mySql, myPara);
            // 1 ok    -1 something wrong
            if (rtn >= 1)
            {
                Label10.Text = "Sucess";
            }
            else
            {
                Label10.Text = "Failed";


            }


        }
    }
}