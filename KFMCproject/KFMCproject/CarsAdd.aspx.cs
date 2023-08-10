using KFMCproject.App_Code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Configuration;
using System.IO;
using System.Web;
using System.Linq;
using System.Data;

namespace KFMCproject
{
    public partial class CarsAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GrdBind();

            }
        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            string strcarid = txtIdAdd.Text;
            string strcarname = txtNameAdd.Text;
            string strprice = txtpriceAdd.Text;

            if (string.IsNullOrEmpty(strcarid) && string.IsNullOrEmpty(strcarname) && string.IsNullOrEmpty(strprice))
            {

                lblOutcarid.Text = "Please enter car ID";
                lblOutcarname.Text = "Please enter car name";
                lblOutprice.Text = "Please enter car price";

                return;

            }

            else
            {
                if (string.IsNullOrEmpty(strcarid))
                {

                    lblOutcarname.Visible = false;
                    lblOutprice.Visible = false;

                    lblOutcarid.Text = "Please enter car ID";

                    return;


                }



                if (string.IsNullOrEmpty(strcarname))
                {

                    lblOutcarid.Visible = false;

                    lblOutprice.Visible = false;

                    lblOutcarname.Text = "Please enter car name";

                    return;


                }
                if (string.IsNullOrEmpty(strprice))
                {

                    lblOutcarid.Visible = false;
                    lblOutcarname.Visible = false;
                    lblOutprice.Text = "Please enter car price";

                    return;


                }
            }
            

            CURD my = new CURD();
            string mySql = @"insert Cars(carid, carname , cartype , carreserved, model , price) 
               values (@carid, @carname , @cartype , @carreserved, @model , @price)";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@carid", txtIdAdd.Text);
            myPara.Add("@carname", txtNameAdd.Text);
            // myPara.Add("@ddlDep", int.Parse(ddlDep.SelectedValue));
            myPara.Add("@cartype", ddltype.SelectedValue);
            myPara.Add("@carreserved", "No");
            myPara.Add("@model", ddlModel.SelectedValue);
            myPara.Add("@price", txtpriceAdd.Text);

            int rtn = my.InsertUpdateDelete(mySql, myPara);  // 1 ok    -1 something wrong
            if (rtn >= 1)
            { lblOuput.Text = "Sucess"; }
            else
            { lblOuput.Text = "Failed"; }
            carsGv();


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
            int carid = int.Parse(txtIdAdd.Text);
            string strCarName = txtNameAdd.Text;
            string carType = ddltype.Text;
            string Model = ddlModel.Text;
            string Price = txtpriceAdd.Text;
            //lblOuput.Text = PK.ToString();

            string mySql = @"  update Cars
                        set carname =@carname, cartype =@cartype,  model =@model,  price =@price
                        where carid=@carid";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@carid", carid);
            myPara.Add("@carname", strCarName);
            myPara.Add("@cartype", carType);
            myPara.Add("@model", Model);
            myPara.Add("@price", Price);
            CURD myCrud = new CURD();
            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            if (rtn >= 1)
            { lblOuput.Text = "success"; }
            else
            { lblOuput.Text = "failed"; }
            carsGv();
        }









        protected void btnDelete_Click(object sender, EventArgs e)
        {
            CURD myCrud = new CURD();
            string mySql = @"delete Cars where carid = @carid";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@carid", int.Parse(txtIdAdd.Text));

            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            if (rtn >= 1)
            { lblOuput.Text = "Sucess"; }
            else
            { lblOuput.Text = "Failed"; }
            carsGv();
        }

        protected void gvCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void GrdBind()
        {
            string strConnString = ConfigurationManager.ConnectionStrings["carRentalConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(strConnString))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Cars"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            gvCars.DataSource = dt;
                            gvCars.DataBind();
                        }
                    }
                }
            }
        }
        public void ExportGridToExcel(GridView grd)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            grd.AllowPaging = false;
            GrdBind();
            grd.RenderControl(hw);
            string style = @"<style> .textmode { mso-number-format:\@; } </style>";
            Response.Write(style);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //required to avoid the run time error "  
            //Control 'GridView1' of type 'Grid View' must be placed inside a form tag with runat=server."  
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCars.PageIndex = e.NewPageIndex;
            this.GrdBind();
        }
        protected void btnExport_Click(object sender, EventArgs e)
        {
            ExportGridToExcel(gvCars);
           
        }
    }
}