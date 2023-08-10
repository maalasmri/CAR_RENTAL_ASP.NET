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
        public static string invtype;
        public static string invpickup;
        public static string invreturn;
        public static string invid;
        public static string invname;
        public static string invprice;
        public static string invtotal;
        public static string invmodel;
        // public static string invcarrev;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"]=="admin" || Session["role"]=="user")
                {
                    TextBox1.ReadOnly = true;
                    TextBox1.Enabled = false;
                    TextBox2.ReadOnly = true;
                    TextBox2.Enabled = false;
                    Button1.Enabled = false;
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

            /*   CURD my = new CURD();
               string mySql = @"insert carrent(pickupDateandTime , returnDateandTime , cartype , price , location) 
                  values (@pickupDateandTime  , @returnDateandTime , @cartype , @price)";
               String pickupdate = TextBox1.Text;
               String returndate = TextBox1.Text;

               DateTime date = DateTime.Parse(pickupdate);
               DateTime date1 = DateTime.Parse(returndate);

               Dictionary<string, object> myPara = new Dictionary<string, object>();

               myPara.Add("@pickupDateandTime", date);
               myPara.Add("@returnDateandTime", date);

               int rtn = my.InsertUpdateDelete(mySql, myPara);  // 1 ok    -1 something wrong
               if (rtn >= 1)
               { Lab.Text = "Sucess"; }
               else
               { Lab.Text = "Failed"; }*/




           /* CURD my = new CURD();
            string mySql = @"SELECT * FROM [dbo].[Cars] where cartype = '" + DropDown.Text + "'";

            SqlDataReader dr = my.getDrPassSql(mySql);
            DataTable dt = new DataTable();
            grcars.DataSource = dr;
            grcars.DataBind();*/
            carsGv();


        }

        



       // float selectcarprice; 
        protected void diffclick(object sender, EventArgs e)
        {


            String pickupdate = TextBox1.Text;
            String returndate = TextBox2.Text;
            DateTime date = DateTime.Parse(pickupdate);
            DateTime date1 = DateTime.Parse(returndate);


            TimeSpan differnec = date1 - date;
            Label9.Text = differnec.TotalDays.ToString();

            float a = Math.Abs(differnec.Days) * (float)Convert.ToDouble(TextBox4.Text);
            totalprice.Text = a + " ";

            invtype = gridviewtype.Text;
            invpickup = TextBox1.Text;
            invreturn = TextBox2.Text;
            invid = TextBox3.Text;
            invname = gridviewCarname.Text;
            invprice = TextBox4.Text;
            invtotal = totalprice.Text;
            invmodel = gridviewModel.Text;



 inv f2 = new inv();
            Response.Redirect("inv.aspx");

        }

        protected void sch(object sender, EventArgs e)
        {

            /*   CURD my = new CURD();
               string mySql = @"insert carrent(pickupDateandTime, returnDateandTime , carname ,cartype , model ,price) 
                  values (@pickupDateandTime, @returnDateandTime , @carname , @cartype  , @model, @price)";

               String pickupdate = TextBox1.Text;
               String returndate = TextBox2.Text;

               DateTime date = DateTime.Parse(pickupdate);
               DateTime date1 = DateTime.Parse(returndate);

               Dictionary<string, object> myPara = new Dictionary<string, object>();
               myPara.Add("@pickupDateandTime", date);
               myPara.Add("@returnDateandTime", date);
               myPara.Add("@carname", carnameT.Text);
               myPara.Add("@cartype", CartypeT.Text);
               myPara.Add("@model", modelT.Text);
               myPara.Add("@price", priceT.Text);

               int rtn = my.InsertUpdateDelete(mySql, myPara);  // 1 ok    -1 something wrong
               if (rtn >= 1)
               { Label1.Text = "Sucess"; }
               else
               { Label1.Text = "Failed"; }


           }*/





            /*   int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                          Button cb = (Button)gvCars.Rows[rowind].FindControl("ok");

                          carnameT.Text = gvCars.Rows[rowind].Cells[1].Text;
                          CartypeT.Text = gvCars.Rows[rowind].Cells[2].Text;
                          modelT.Text = gvCars.Rows[rowind].Cells[3].Text;

             // CartypeT.Text = gr.Cells[5].Text;
              //modelT.Text = gr.Cells[6].Text;
              //priceT.Text = gr.Cells[7].Text;*/



        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


               
                TextBox3.Text = grcars.SelectedRow.Cells[1].Text;
                // selectcarprice = float.Parse(grcars.SelectedRow.Cells[6].Text);
                gridviewCarname.Text = grcars.SelectedRow.Cells[2].Text;
                gridviewtype.Text = grcars.SelectedRow.Cells[3].Text;
            gridviewModel.Text = grcars.SelectedRow.Cells[4].Text;
                   
                TextBox4.Text = grcars.SelectedRow.Cells[5].Text;

                 

            TextBox1.ReadOnly = false;
            TextBox1.Enabled = true;
            TextBox2.ReadOnly = false;
            TextBox2.Enabled = true;
            Button1.Enabled = true;


        }
        /* protected void Rentclick(object sender, EventArgs e)
         {

             //           Response.Redirect("inv.aspx");


         } */


        protected void carsGv()
        {
            CURD myCrud = new CURD();
            string mySql = @"SELECT   Cars.carid, Cars.carname, Cars.cartype, 
                            Cars.carreserved, Cars.model, Cars.price
                FROM  Cars where cartype = '" + DropDown.Text + "' and carreserved = 'No'";
            SqlDataReader dr = myCrud.getDrPassSql(mySql);
            grcars.DataSource = dr;
            grcars.DataBind();
        }


    }
}
