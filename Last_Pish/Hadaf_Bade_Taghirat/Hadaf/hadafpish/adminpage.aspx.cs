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


namespace hadafpish
{
    public partial class adminpage : System.Web.UI.Page
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
            Redirector.Goto(Redirector.PageName.adminsearch);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Redirector.Goto(Redirector.PageName.insertstd);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Redirector.Goto(Redirector.PageName.stdsearch);

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard/adminlogin.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Redirector.Goto(Redirector.PageName.notregister);
        }
    }
}