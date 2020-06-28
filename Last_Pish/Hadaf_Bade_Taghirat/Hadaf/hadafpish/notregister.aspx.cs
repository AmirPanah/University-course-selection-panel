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
    public partial class notregister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                UserRepository cr = new UserRepository();

                Session["data"] = cr.Getstatus();
                GridView1.DataSource = Session["data"];
                GridView1.DataBind();

            }

        }
    }
}