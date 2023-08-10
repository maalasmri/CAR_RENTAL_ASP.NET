using KFMCproject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KFMCproject
{
    public partial class Create_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void btnCreate_Click(object sender, EventArgs e)
        {

            string strusername = txtUsrrname.Text;
            string srtpassword = txtpass.Text;
            string strconform = txtconfpass.Text;


            if (string.IsNullOrEmpty(strusername) && string.IsNullOrEmpty(srtpassword) && string.IsNullOrEmpty(strconform))
            {

                lblOutUsername.Text = "Please enter your user name";
                lblOutpass.Text = "Please enter your password";
                lblOutconform.Text = "Please renter password";

                return;

            }

            else {

                if (string.IsNullOrEmpty(strusername))
                {
                    lblOutpass.Visible = false;
                    lblOutconform.Visible = false;
                    lblOutUsername.Text = "Please enter your user name";

                    return;


                }

                if (string.IsNullOrEmpty(srtpassword))
                {
                    lblOutUsername.Visible = false;
                    lblOutconform.Visible = false;
                    lblOutpass.Text = "Please enter your password";

                    return;


                }


                if (string.IsNullOrEmpty(strconform))
                {
                    lblOutpass.Visible = false;
                    lblOutUsername.Visible = false;
                    lblOutconform.Text = "Please renter password";

                    return;


                }

            }

            // username , password , email
            string email = Session["email"].ToString();
            CURD my = new CURD();

            string mySql = @"  update Customer 
                        set username =@username,password = @password
                        where email = '" + email + "'";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@username", txtUsrrname.Text);
            myPara.Add("@password", txtpass.Text);
            //  myPara.Add("@ddlDep", int.Parse(ddlDep.SelectedValue));


            int rtn = my.InsertUpdateDelete(mySql, myPara);
            // 1 ok    -1 something wrong
            if (rtn >= 1)
            {
                lblOuput.Text = "Sucess";
            }
            else
            {
                lblOuput.Text = "Failed";


            }


        }

    }
}