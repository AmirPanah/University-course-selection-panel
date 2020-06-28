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

namespace hadafpish
{
    public partial class studentunit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {


                CounterRepository cr = new CounterRepository();
                string studentid;
                studentid = Session["studentid"].ToString();
                Label2.Text = studentid;
                Session["data"] = cr.GetLinkUrl(Int64.Parse(Label2.Text));
                GridView1.DataSource = Session["data"];
                GridView1.DataBind();

            }
        }
    }
}