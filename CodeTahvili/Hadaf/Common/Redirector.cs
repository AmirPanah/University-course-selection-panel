using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
  public  class Redirector
    {
        public enum PageName
        {
           COMNP,ok,StdUnit,register,adminsearch,adminpage,stdsearch,insertstd,studentunit
      
        };

        public static void Goto(PageName pageName)
        {
            switch (pageName)
            {
                //======================================================================================

                case PageName.COMNP:
                    { HttpContext.Current.Response.Redirect("~/COMNP"); break; }
                case PageName.ok:
                    { HttpContext.Current.Response.Redirect("~/ok"); break; }
                case PageName.StdUnit:
                    { HttpContext.Current.Response.Redirect("~/StdUnit"); break; }
                case PageName.register:
                    { HttpContext.Current.Response.Redirect("~/Register"); break; }
                case PageName.adminsearch:
                    { HttpContext.Current.Response.Redirect("~/adminsearch"); break; }
                case PageName.adminpage:
                    { HttpContext.Current.Response.Redirect("~/adminpage"); break; }
                case PageName.stdsearch:
                    { HttpContext.Current.Response.Redirect("~/stdsearch"); break; }
                case PageName.insertstd:
                    { HttpContext.Current.Response.Redirect("~/insertstd"); break; }
                case PageName.studentunit:
                    { HttpContext.Current.Response.Redirect("~/studentunit"); break; }
            }
        }
    }
}
