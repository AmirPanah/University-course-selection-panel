using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace hadafpish
{
    public class Global : System.Web.HttpApplication
    {
        void RegisterRoutes(System.Web.Routing.RouteCollection routes)
        {
            routes.MapPageRoute("R1", "COMNP", "~/COMNP.aspx");
            routes.MapPageRoute("R2", "ok", "~/ok.aspx");
            routes.MapPageRoute("R3", "StdUnit", "~/StdUnit.aspx");
            routes.MapPageRoute("R4", "register", "~/Register.aspx");
            routes.MapPageRoute("R5", "adminsearch", "~/adminsearch.aspx");
            routes.MapPageRoute("R6", "adminpage", "~/adminpage.aspx");
            routes.MapPageRoute("R7", "stdsearch", "~/stdsearch.aspx");
            routes.MapPageRoute("R8", "insertstd", "~/insertstd.aspx");
            routes.MapPageRoute("R9", "studentunit", "~/studentunit.aspx");
            routes.MapPageRoute("R10", "notregister", "~/notregister.aspx");
        }
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(System.Web.Routing.RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}