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
    public partial class insertstd : System.Web.UI.Page
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
            try
            {
                string username = tbxUsername.Text.Trim();
                UserRepository ar = new UserRepository();
                enter currentUser = ar.FindByUserName(Int64.Parse(username));
                if (currentUser == null)
                {


                    UserRepository ur = new UserRepository();
                    enter newuser = new enter();
                    newuser.Username = Int64.Parse(tbxUsername.Text.Trim());
                    newuser.Pass = Int64.Parse(tbxPassword.Text.Trim());
                    newuser.Status = int.Parse("0");
                    ur.Saveuser(newuser);

                    HadafTools.ShowMessage(lblmessage, "ثبت با موفقیت انجام شد", Color.Red);
                }
                else
                {
                    HadafTools.ShowMessage(lblmessage, "این کاربر تکراری می باشد", Color.Red);
                }
            }
            catch
            {
                HadafTools.ShowMessage(lblmessage, "امکان ثبت وجود ندارد", Color.Red);
            }
        }
    }
}