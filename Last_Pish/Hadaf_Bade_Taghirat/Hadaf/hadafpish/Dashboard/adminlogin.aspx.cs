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

namespace hadafpish.Dashboard
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "admin" && tbxPassword.Text == "adminhadaf")
            {
                Session["username"] = tbxUsername.Text.Trim();
                Session["password"] = tbxPassword.Text.Trim();
                Redirector.Goto(Redirector.PageName.adminpage);
            }
            else
            {
                HadafTools.ShowMessage(lblmessage, "نام کاربری یافت نشد", Color.Red);
            }
        }
    }
}