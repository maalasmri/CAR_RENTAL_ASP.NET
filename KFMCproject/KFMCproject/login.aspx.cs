using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KFMCproject.App_Code;

namespace KFMCproject
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {




        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string strEmail = txtEmail.Text;
            string strpassword = txtPassword.Text;

            if (string.IsNullOrEmpty(strEmail) && string.IsNullOrEmpty(strpassword))
            {

                lblOut.Text = "Please enter your email";
                lblOut1.Text = "Please enter your password";

                return;

            }

            if (string.IsNullOrEmpty(strEmail))
            {
                lblOut1.Visible = false;
                lblOut.Text = "Please enter your email";

                return;


            }

            if (string.IsNullOrEmpty(strpassword))
            { 
                   lblOut.Visible = false;
                   lblOut1.Text = "Please enter your password";

                return;


            }


            CURD curd = new CURD();
            
            String mySQL = "with temptable as (select * from Customer union select * from Admin) select * from temptable WHERE email='" + txtEmail.Text.Trim()+"' AND password='"+txtPassword.Text.Trim()+"'";
            SqlDataReader dr = curd.getDrPassSql(mySQL);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr.GetValue(7).ToString().Equals("user"))
                    {
                        Session["username"] = dr.GetValue(1).ToString();
                        Session["role"] = "user";
                        if(Request.QueryString["ReturnURL"] != null)
                            Response.Redirect(Request.QueryString["ReturnURL"]);
                        else
                            Response.Redirect("About.aspx"); //should be homepage
                    }
                    else if (dr.GetValue(7).ToString().Equals("admin"))
                    {
                        Session["username"] = dr.GetValue(1).ToString();
                        Session["role"] = "admin";
                        if (Request.QueryString["ReturnURL"] != null)
                            Response.Redirect(Request.QueryString["ReturnURL"]);
                        else
                            Response.Redirect("About.aspx"); //should be homepage
                    }
                    else { Response.Write("Error"); }
                }

            }
            else
            {

                lblError.Visible = true;
                lblError.Text = "Incorrect email or password.";

            }
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("registration.aspx");
        }
    }
}