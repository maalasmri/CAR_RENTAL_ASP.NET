using KFMCproject.App_Code;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KFMCproject
{
    public partial class Rent_invoice : System.Web.UI.Page
    {

        public static string body;

    

        protected void Page_Load(object sender, EventArgs e)
        {
            invcarid.Text = Rent_a_car.invoiceId;
            invCarname.Text = Rent_a_car.invoiceName;
            invCartype.Text = Rent_a_car.invoiceType;
            invModelcar.Text = Rent_a_car.invoiceModel;
            invPD.Text = Rent_a_car.invoicePrice;
            invTP.Text = Rent_a_car.invoiceTotal;
            invpickup.Text = Rent_a_car.invoicePickup;
            invreturn.Text = Rent_a_car.invoiceReturn;
            invdays.Text = Rent_a_car.totaldays.ToString();
            DateTime today = DateTime.Now;
            labledate.Text = today.ToShortDateString();


            rev();
            if (Session["role"].Equals("user"))
            {
                CURD curd = new CURD();
                string mysql = "select * from customer where username='" + Session["username"].ToString() + "'";
                SqlDataReader dr = curd.getDrPassSql(mysql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        invCustomerid.Text = dr.GetValue(0).ToString();
                        invCustomer.Text = dr.GetValue(3).ToString();
                        invPhone.Text = dr.GetValue(4).ToString();
                        invEmail.Text = dr.GetValue(5).ToString();
                    }
                }

            }


        }

        protected void btnRent_click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int num = rnd.Next();

            invbooking.Text = num + " ";
            String pickupdate = invpickup.Text;
            String returndate = invreturn.Text;

            DateTime date = DateTime.Parse(pickupdate);
            DateTime date1 = DateTime.Parse(returndate);


            CURD my = new CURD();
            string mySql = @"insert carrent(bookingid , pickupDateandTime , returnDateandTime , carid , customerid) 
               values (@bookingid, @pickupDateandTime , @returnDateandTime , @carid , @customerid)";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@bookingid", invbooking.Text);
            myPara.Add("@pickupDateandTime", date);
            // myPara.Add("@ddlDep", int.Parse(ddlDep.SelectedValue));
            myPara.Add("@returnDateandTime", date);
            myPara.Add("@carid", invcarid.Text);
            myPara.Add("@customerid", invCustomerid.Text);

            int rtn = my.InsertUpdateDelete(mySql, myPara);  // 1 ok    -1 something wrong
            if (rtn >= 1)
            { Label20.Text = "Sucess";
                // updaterev();
            }
            else
            { Label20.Text = "Failed";


            }

            updaterev();

            mailMgr myMail = new mailMgr();
            myMail.myTo = invEmail.Text;
            myMail.mySubject = "Thank you for your reservation - شكرا لحجزك ‏‏";
            myMail.myBody = "Renting Confirmed" + "\n" +"Your Renting has been finished Mr." + invCustomer.Text + "\n" + "Booking ID : " + invbooking.Text + "\n Pickup Date and Time : " + invpickup.Text + "\n" + " Return Date and Time : " + invreturn.Text + "\n" + "Total Days : " + invdays.Text + "\n" + "Car: " + invCarname.Text + " " + invModelcar.Text;
            myMail.IsBodyHtml = true;
            lbloutemail.Text = myMail.sendEmailViaGmail();
            
        }

        protected void rev()
        {
          


            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["carRentalConnectionString"].ToString();
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Cars where carid = '" + invcarid.Text + "'" , con);

            SqlDataReader srd = cmd.ExecuteReader();

            while (srd.Read())
            {
                invrev.Text = srd.GetValue(3).ToString();

            }
            con.Close();

        }


        protected void updaterev()
        {
           
            string mySql = @"  update Cars
                        set carreserved = 'Yes' where carid = '" + invcarid.Text + "'";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@carreserved", invrev.Text);
            CURD myCrud = new CURD();
            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            if (rtn >= 1)
            { Label20.Text = "success"; }
            else
            { Label20.Text = "failed"; }

        }

       
    }
}