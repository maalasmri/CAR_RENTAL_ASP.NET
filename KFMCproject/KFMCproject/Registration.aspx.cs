using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KFMCproject.App_Code;


namespace KFMCproject
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Button12.Visible = false;
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }


        protected void btnregistration_Click(object sender, EventArgs e)
        {

            string strfullname = txtfullname.Text;
            string strnatid = txtnatID.Text;
            string strphone = txtPhone.Text;
            string strremail = txtemail.Text;

            if (string.IsNullOrEmpty(strfullname) && string.IsNullOrEmpty(strnatid) && string.IsNullOrEmpty(strphone) && string.IsNullOrEmpty(strremail))
            {

                lblOutfname.Text = "Please enter your full name";
                lblOutnatid.Text = "Please enter your National ID";
                lblOutphone.Text = "Please enter your Phone Number";
                lblOutemail.Text = "Please enter your Email";

                return;

            }
            else
            {
                if (string.IsNullOrEmpty(strfullname))
                {
                    lblOutnatid.Visible = false;
                    lblOutphone.Visible = false;
                    lblOutemail.Visible = false;

                    lblOutfname.Text = "Please enter your full name";

                    return;


                }



                if (string.IsNullOrEmpty(strnatid))
                {

                    lblOutfname.Visible = false;
                    lblOutphone.Visible = false;
                    lblOutemail.Visible = false;

                    lblOutnatid.Text = "Please enter your National ID";

                    return;


                }

                if (string.IsNullOrEmpty(strphone))
                {
                    lblOutfname.Visible = false;
                    lblOutnatid.Visible = false;
                    lblOutemail.Visible = false;

                    lblOutphone.Text = "Please enter your Phone Number";

                    return;


                }

                if (string.IsNullOrEmpty(strremail))
                {

                    lblOutfname.Visible = false;
                    lblOutnatid.Visible = false;
                    lblOutphone.Visible = false;

                    lblOutemail.Text = "Please enter your Email";

                    return;


                }
            }


        


            CURD my = new CURD();
            string mySql = @"insert Customer(natid, customername , phonenumber , email) 
               values (@natid, @customername , @phonenumber , @email)";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@natid", txtnatID.Text);
            myPara.Add("@customername", txtfullname.Text);
            //  myPara.Add("@ddlDep", int.Parse(ddlDep.SelectedValue));
            myPara.Add("@phonenumber", txtPhone.Text);
            myPara.Add("@email", txtemail.Text);

            int rtn = my.InsertUpdateDelete(mySql, myPara);  // 1 ok    -1 something wrong
            if (rtn >= 1)
            {
                lblOuput.Text = "Sucess";
                Button12.Visible = true;
                registrationButton.Visible = false;

            }
            else
            {
                lblOuput.Text = "Failed";


            }


        }


        protected void btnCreatepass_Click(object sender, EventArgs e)
        {
            CURD myCurd = new CURD();
            string mySql = "select * from Customer where email='" + txtemail.Text + "'";
            Session["email"] = txtemail.Text;
            Response.Redirect("Create_Password.aspx");
        }




    }
}