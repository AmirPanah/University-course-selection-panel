using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using DataAccess;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace hadafpish
{
    public partial class adminsearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

                if (!Page.IsPostBack)
                {
                    if (Session["username"] == null && Session["password"] == null)
                    {
                        Response.Redirect("Dashboard/adminlogin.aspx");
                    }
                }

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
      

            string sqlconnection = " data source=ITAPP;initial catalog=hadafDB;integrated security=True";

            SqlConnection scon = new SqlConnection(sqlconnection);
            scon.Open();
            string selectstr = "select count(id) as dd,CoursName from Counter where Reshte='" + DropDownList1.SelectedItem.Value + "' group by CoursName";
        
            SqlDataAdapter sda = new SqlDataAdapter(selectstr, scon);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            scon.Close();


            studentcountRepository cir = new studentcountRepository();

            Session["comnpdata"] = cir.GetStdList(DropDownList1.SelectedItem.Value);
            GridView3.DataSource = Session["comnpdata"];
            GridView3.DataBind();
            //  Label2.Text = Session["reshte"].ToString();
         //  Label1.Text = Session["stdid"].ToString();


           
           
           
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}