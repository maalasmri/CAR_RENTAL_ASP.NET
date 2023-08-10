using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KFMCproject.App_Code;

namespace KFMCproject
{
    public partial class Rent_a_car : System.Web.UI.Page
    {
        public static string invoiceType;
        public static string invoicePickup;
        public static string invoiceReturn;
        public static string invoiceId;
        public static string invoiceName;
        public static string invoicePrice;
        public static string invoiceTotal;
        public static string invoiceModel;
        public static int totaldays;


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"]=="admin" || Session["role"]=="user")
                {
                    txtPickup.ReadOnly = true;
                    txtPickup.Enabled = false;
                    txtReturn.ReadOnly = true;
                    txtReturn.Enabled = false;
                    btnChooseCar.Enabled = false;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('please login first');window.location ='login.aspx?ReturnURL="+HttpContext.Current.Request.Url.AbsoluteUri+"';", true);
                }
            }
            catch (Exception) { }
            } 

        protected void revClick(object sender, EventArgs e)
        {

            carsGv();


        }

        



       // float selectcarprice; 
        protected void btnChooseCar_Click(object sender, EventArgs e)
        {

            string strselectCar = ddltype.Text;
            string strPick = txtPickup.Text;
            string strReturn = txtReturn.Text;


            if (string.IsNullOrEmpty(strselectCar) && string.IsNullOrEmpty(strPick) && string.IsNullOrEmpty(strReturn))
            {



                lblOselectCar.Text = "Please Select a Car";
                lblOutPick.Text = "Please Select Pick date";
                lblOutreturn.Text = "Please  Select Return date";

                return;

            }

            if (string.IsNullOrEmpty(strselectCar))
            {


                lblOutPick.Visible = false;
                lblOutreturn.Visible = false;
                lblOselectCar.Text = "Please Select a Car";
                return;


            }

            if (string.IsNullOrEmpty(strPick))
            {

                lblOselectCar.Visible = false;
                lblOutreturn.Visible = false;
                lblOutPick.Text = "Please Select Pick date";
                return;


            }

            if (string.IsNullOrEmpty(strReturn))
            {


                lblOselectCar.Visible = false;
                lblOutPick.Visible = false;
                lblOutreturn.Text = "Please  Select Return date";
                return;


            }
            String pickupdate = txtPickup.Text;
            String returndate = txtReturn.Text;
            DateTime date = DateTime.Parse(pickupdate);
            DateTime date1 = DateTime.Parse(returndate);


            TimeSpan differnec = date1 - date;
            lblOuput.Text = differnec.TotalDays.ToString();

            float a = Math.Abs(differnec.Days) * (float)Convert.ToDouble(txtgridPrice.Text);
            txttotalprice.Text = a + " ";
       
            invoiceType = txtgridType.Text;
            invoicePickup = txtPickup.Text;
            invoiceReturn = txtReturn.Text;
            invoiceId = txtGridID.Text;
            invoiceName = txtGridCarname.Text;
            invoicePrice = txtgridPrice.Text;
            invoiceTotal = txttotalprice.Text;
            invoiceModel = txtGridModel.Text;
            totaldays = int.Parse(lblOuput.Text);


            Rent_invoice f2 = new Rent_invoice();
            Response.Redirect("Rent_invoice.aspx");

        }

      

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


               
                txtGridID.Text = grcars.SelectedRow.Cells[1].Text;
                // selectcarprice = float.Parse(grcars.SelectedRow.Cells[6].Text);
                txtGridCarname.Text = grcars.SelectedRow.Cells[2].Text;
            txtgridType.Text = grcars.SelectedRow.Cells[3].Text;
            txtGridModel.Text = grcars.SelectedRow.Cells[4].Text;
                   
                txtgridPrice.Text = grcars.SelectedRow.Cells[5].Text;

                 

            txtPickup.ReadOnly = false;
            txtPickup.Enabled = true;
            txtReturn.ReadOnly = false;
            txtReturn.Enabled = true;
            btnChooseCar.Enabled = true;


        }
      

        protected void carsGv()
        {
            CURD myCrud = new CURD();
            string mySql = @"SELECT   Cars.carid, Cars.carname, Cars.cartype, 
                            Cars.carreserved, Cars.model, Cars.price
                FROM  Cars where cartype = '" + ddltype.Text + "' and carreserved = 'No'";
            SqlDataReader dr = myCrud.getDrPassSql(mySql);
            grcars.DataSource = dr;
            grcars.DataBind();
        }


    }
}
