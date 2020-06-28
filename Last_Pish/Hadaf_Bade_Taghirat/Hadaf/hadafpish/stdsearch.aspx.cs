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
    public partial class stdsearch : System.Web.UI.Page
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

        protected void Button2_Click(object sender, EventArgs e)
        {

            string username = tbxUsername.Text.Trim();
            CounterRepository ar = new CounterRepository();
            Counter currentUser = ar.FindBystdid(username);


            if (currentUser == null)
            {

                HadafTools.ShowMessage(lblmessage, "توسط این کاربر ثبت نامی انجام نشده است", Color.Red);

                return;
            }

            else
            {
string stdid = tbxUsername.Text;
                Session["studentid"] = stdid;
                Redirector.Goto(Redirector.PageName.StdUnit);
            }



            
        }
    }
}