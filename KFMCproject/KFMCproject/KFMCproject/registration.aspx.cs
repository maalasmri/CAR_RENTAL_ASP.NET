using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KFMCproject.App_Code;


namespace KFMCproject
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Button12.Visible = false;
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }


        protected void RegClick(object sender, EventArgs e)
        {

            CURD my = new CURD();
            string mySql = @"insert Customer(natid, customername , phonenumber , email) 
               values (@natid, @customername , @phonenumber , @email)";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@natid", TextBox5.Text);
            myPara.Add("@customername", TextBox4.Text);
            //  myPara.Add("@ddlDep", int.Parse(ddlDep.SelectedValue));
            myPara.Add("@phonenumber", TextBox6.Text);
            myPara.Add("@email", TextBox2.Text);

            int rtn = my.InsertUpdateDelete(mySql, myPara);  // 1 ok    -1 something wrong
            if (rtn >= 1)
            { Label9.Text = "Sucess" ;
                Button12.Visible = true;
                registrationButton.Visible = false;

            }
            else
            {
                Label9.Text = "Failed";


            }


        }


        protected void button_Click(object sender, EventArgs e)
        {
            CURD myCurd = new CURD();
            string mySql = "select * from Customer where email='"+TextBox2.Text+"'";
            Session["email"] = TextBox2.Text;
            Response.Redirect("createpassword.aspx");
        }


        
    }
}