using KFMCproject.App_Code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Configuration;



namespace KFMCproject
{
    public partial class CarsEdit : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      



        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        protected void carsGv()
        {
            CURD myCrud = new CURD();
            string mySql = @"SELECT   Cars.carid, Cars.carname, Cars.cartype, 
                            Cars.carreserved, Cars.model, Cars.price
                FROM  Cars";
            SqlDataReader dr = myCrud.getDrPassSql(mySql);
            gvCars.DataSource = dr;
            gvCars.DataBind();
        }
        public void btnRead_Click(object sender, EventArgs e)
        {
            carsGv();
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int carid = int.Parse(TextBox2.Text);
            string strCarName = TextBox3.Text;
            string carType = DropDownList1.Text;
            String carreserved = DropDownList3.Text;
            string Model = DropDownList2.Text;
            string Price = TextBox1.Text;
            //lblOuput.Text = PK.ToString();

            string mySql = @"  update Cars
                        set carname =@carname, cartype =@cartype, carreserved =@carreserved,  model =@model,  price =@price
                        where carid=@carid";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@carid", carid);
            myPara.Add("@carname", strCarName);
            myPara.Add("@cartype", carType);
            myPara.Add("@carreserved", carreserved);
            myPara.Add("@model", Model);
            myPara.Add("@price", Price);
            CURD myCrud = new CURD();
            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            if (rtn >= 1)
            { Label1.Text = "success"; }
            else
            { Label1.Text = "failed"; }
            carsGv();
        }









        protected void btnDelete_Click(object sender, EventArgs e)
        {
            CURD myCrud = new CURD();
            string mySql = @"delete Cars where carid = @carid";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@carid", int.Parse(TextBox2.Text));

            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            if (rtn >= 1)
            { Label1.Text = "Sucess"; }
            else
            { Label1.Text = "Failed"; }
            carsGv();
        }


        protected void get_Click(object sender, EventArgs e) {
            carsGv();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["carRentalConnectionString"].ToString();
            con.Open();
                
                SqlCommand cmd = new SqlCommand(" select * from Cars where Carid = '" + int.Parse(TextBox2.Text) + "'" , con);

          SqlDataReader srd = cmd.ExecuteReader();

            while (srd.Read())
            {
                TextBox2.Text = srd.GetValue(0).ToString();
                TextBox3.Text = srd.GetValue(1).ToString();
                DropDownList1.SelectedValue = srd.GetValue(2).ToString();
                DropDownList2.SelectedValue = srd.GetValue(4).ToString();
                TextBox1.Text = srd.GetValue(5).ToString();

            }
            con.Close();

        }






    }
}