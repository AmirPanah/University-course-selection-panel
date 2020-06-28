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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


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

                    HadafTools.ShowMessage(lblmessage, "نام کاربری یافت نشد", Color.Red);

                    return;
                }

                if (Int64.Parse(tbxPassword.Text) != currentUser.Pass)
                {
                    HadafTools.ShowMessage(lblmessage, "رمز عبور اشتباه است", Color.Red);
                    return;
                }


                //if (DropDownList1.SelectedItem.Value == "1")
                //{
                //    string status = currentUser.Status.ToString();
                //    Session["value"] = "1";
                //    if (status == "0")
                //    {
                //      //  Session["reshte"]="1";
                //    string aa = tbxUsername.Text;
                //    Session["stdid"]=aa;
                //    Redirector.Goto(Redirector.PageName.COMNP);
                //    }
                //    else
                //    {
                //        if (status == "1")
                //        {
                //            string stdid = tbxUsername.Text;
                //            Session["studentid"] = stdid;
                //            Redirector.Goto(Redirector.PageName.StdUnit);
                //        }
                //    }


                //}



                string value = DropDownList1.SelectedItem.Value;
                switch (value)
                {
                    case "1":
                        {
                            Session["value"] = "1";
                        }
                        break;
                    case "2":
                        {
                            Session["value"] = "2";
                        }
                        break;
                    case "3":
                        {
                            Session["value"] = "3";
                        }
                        break;
                    case "4":
                        {
                            Session["value"] = "4";
                        }
                        break;
                    case "5":
                        {
                            Session["value"] = "5";
                        }
                        break;
                    case "6":
                        {
                            Session["value"] = "6";
                        }
                        break;
                    case "7":
                        {
                            Session["value"] = "7";
                        }
                        break;
                    case "8":
                        {
                            Session["value"] = "8";
                        }
                        break;
                    case "9":
                        {
                            Session["value"] = "9";
                        }
                        break;
                    case "10":
                        {
                            Session["value"] = "10";
                        }
                        break;
                    case "11":
                        {
                            Session["value"] = "11";
                        }
                        break;
                    case "12":
                        {
                            Session["value"] = "12";
                        }
                        break;
                    case "13":
                        {
                            Session["value"] = "13";
                        }
                        break;
                    case "14":
                        {
                            Session["value"] = "14";
                        }
                        break;
                    case "15":
                        {
                            Session["value"] = "15";
                        }
                        break;
                }


                string status = currentUser.Status.ToString();

                if (status == "0")
                {
                    //  Session["reshte"]="1";
                    string aa = tbxUsername.Text;
                    Session["stdid"] = aa;
                    Redirector.Goto(Redirector.PageName.register);
                }
                else
                {
                    if (status == "1")
                    {
                        string stdid = tbxUsername.Text;
                        Session["studentid"] = stdid;
                        Redirector.Goto(Redirector.PageName.studentunit);
                    }
                }
            }
            catch
            {
                HadafTools.ShowMessage(lblmessage, "اطلاعات شما نادرست است", Color.Red);
            }


            }//ذفد
        
    }
}