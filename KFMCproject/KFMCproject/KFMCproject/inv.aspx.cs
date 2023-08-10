using KFMCproject.App_Code;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KFMCproject
{
    public partial class inv : System.Web.UI.Page
    {
        /* Rent_a_car f1;
         public inv(Rent_a_car frm1) {
             InitializeComponent();
             this.f1 = frm1;*/

        //public string aa { get; set; }






        protected void Page_Load(object sender, EventArgs e)
        {
            invcarid.Text = Rent_a_car.invid;
            invCarname.Text = Rent_a_car.invname;
            invCartype.Text = Rent_a_car.invtype;
            invModelcar.Text = Rent_a_car.invmodel;
            invPD.Text = Rent_a_car.invprice;
            invTP.Text = Rent_a_car.invtotal;
            invpickup.Text = Rent_a_car.invpickup;
            invreturn.Text = Rent_a_car.invreturn;

            Random rnd = new Random();
            int num = rnd.Next();

            invbooking.Text = num + " ";
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

        protected void rentclick(object sender, EventArgs e)
        {


            String pickupdate = invpickup.Text;
            String returndate = invreturn.Text;

            DateTime date = DateTime.Parse(pickupdate);
            DateTime date1 = DateTime.Parse(returndate);


            CURD my = new CURD();
            string mySql = @"insert carrent(bookingid , pickupDateandTime , returnDateandTime , carid) 
               values (@bookingid, @pickupDateandTime , @returnDateandTime , @carid)";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@bookingid", invbooking.Text);
            myPara.Add("@pickupDateandTime", date);
            // myPara.Add("@ddlDep", int.Parse(ddlDep.SelectedValue));
            myPara.Add("@returnDateandTime", date);
            myPara.Add("@carid", invcarid.Text);

            int rtn = my.InsertUpdateDelete(mySql, myPara);  // 1 ok    -1 something wrong
            if (rtn >= 1)
            { Label20.Text = "Sucess";
                // updaterev();

            }
            else
            { Label20.Text = "Failed"; }

            updaterev();



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
                        set carreserved = 'Yes'";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@carreserved", invrev.Text);
            CURD myCrud = new CURD();
            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            if (rtn >= 1)
            { Label21.Text = "success"; }
            else
            { Label21.Text = "failed"; }

        }


    }
}