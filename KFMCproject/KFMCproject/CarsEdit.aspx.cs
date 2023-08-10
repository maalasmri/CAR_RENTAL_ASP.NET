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
            GvcarsEdit.DataSource = dr;
            GvcarsEdit.DataBind();
        }
        public void btnRead_Click(object sender, EventArgs e)
        {
            carsGv();
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int intcarid = int.Parse(txtCarid.Text);
            string strCarName = txtCarname.Text;
            string carType = ddltype.Text;
            string strcarreserved = ddlrev.Text;
            int Model = int.Parse(ddlmodel.Text);
            string Price = txtPrice.Text;
            //lblOuput.Text = PK.ToString();

            string mySql = @"  update Cars
                        set carid=@carid , carname =@carname, cartype =@cartype , carreserved =@carreserved ,model =@model,  price =@price
                        where carid=@carid";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@carid", intcarid);
            myPara.Add("@carname", strCarName);
            myPara.Add("@cartype", carType);
            myPara.Add("@carreserved", strcarreserved);
            myPara.Add("@model", Model);
            myPara.Add("@price", Price);
            CURD myCrud = new CURD();
            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            if (rtn >= 1)
            { lblOuput.Text = "The car has be updated"; }
            else
            { lblOuput.Text = "failed"; }
            carsGv();
        }









        protected void btnDelete_Click(object sender, EventArgs e)
        {
            CURD myCrud = new CURD();
            string mySql = @"delete Cars where carid = @carid and carreserved = 'No'";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@carid", int.Parse(txtCarid.Text));

            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            if (rtn >= 1)
            { lblOuput.Text = "The cars has be deleted"; }
            else
            { lblOuput.Text = "Failed"; }
            carsGv();
        }


        protected void gvCars_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtCarid.Text = GvcarsEdit.SelectedRow.Cells[1].Text;
            txtCarname.Text = GvcarsEdit.SelectedRow.Cells[2].Text;
            ddltype.SelectedValue = GvcarsEdit.SelectedRow.Cells[3].Text;
            ddlrev.SelectedValue = GvcarsEdit.SelectedRow.Cells[4].Text;
            ddlmodel.SelectedValue = GvcarsEdit.SelectedRow.Cells[5].Text;
            txtPrice.Text = GvcarsEdit.SelectedRow.Cells[6].Text;


        }
    }
}