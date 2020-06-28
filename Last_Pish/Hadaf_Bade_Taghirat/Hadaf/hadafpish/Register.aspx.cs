using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using DataAccess;
using System.Drawing;
using DataAccess.Repository;

namespace hadafpish
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



                if (!Page.IsPostBack)
                {
                    //if (Session["username"] == null && Session["password"] == null)
                    //{
                    //    Response.Redirect("default.aspx");
                    //}
                    //else
                    //{
                        string value = Session["value"].ToString();
                        switch (value)
                        {
                            case "1":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllCOMNPList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = "کارشناسی ناپیوسته کامپیوتر";
                                }
                                break;

                            case "2":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllCOMPList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = "کارشناسی پیوسته کامپیوتر";
                                }
                                break;
                            case "3":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllITList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = "IT";
                                }
                                break;
                            case "4":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKardaninarmList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = "کاردانی نرم افزار";
                                }
                                break;
                            case "5":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKarBList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = "  کاردانی پیوسته الکتروتکنیک - برق صنعتی ";
                                }
                                break;
                            case "6":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKarGList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = " کاردانی قدرت ";
                                }
                                break;
                            case "7":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKarNCList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = "کاردانی الکترونیک عمومی  ";
                                }
                                break;
                            case "8":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKarNEList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = " کاردانی ناپیوسته الکترونیک ";
                                }
                                break;
                            case "9":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKarTList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = " کاردانی پیوسته الکتروتکنیک - تاسیسات الکتریکی ";
                                }
                                break;
                            case "10":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKNCList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = " کارشناسی ناپیوسته کنترل ";
                                }
                                break;
                            case "11":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKarNEList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = " کارشناسی ناپیوسته الکترونیک ";
                                }
                                break;
                            case "12":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKNGList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = " کارشناسی ناپیوسته قدرت ";
                                }
                                break;
                            case "13":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKNTList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = "کارشناسی ناپیوسته مهندسی برق - شبکه های انتقال و توزیع  ";
                                }
                                break;
                            case "14":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKPEList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = "کارشناسی پیوسته الکترونیک  ";
                                }
                                break;
                            case "15":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKPGList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = " کارشناسی پیوسته قدرت ";
                                }
                                break;
                            case "16":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllksanayeList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = " کارشناسی پیوسته صنایع ";
                                }
                                break;
                            case "17":
                                {
                                    CoursRepository cir = new CoursRepository();

                                    Session["comnpdata"] = cir.GetAllKarMList();
                                    GridView1.DataSource = Session["comnpdata"];
                                    GridView1.DataBind();
                                    //  Label2.Text = Session["reshte"].ToString();
                                    Label1.Text = Session["stdid"].ToString();
                                    lblreshte.Text = " کاردانی معماری ";
                                }
                                break;

                        }

                    }
  
               // }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            
            UserRepository ar = new UserRepository();
            enter currentUser = ar.FindByUserName(Label1.Text);
            string status = currentUser.Status.ToString();
            if (status == "0")
            {

                //try
                //{
                    int unit = 0;
                    int sum;
                    sum = 0;
                    string succsesfulsave = "";
                    foreach (GridViewRow gvr in GridView1.Rows)
                    {
                        if ((gvr.FindControl("CheckBox1") as CheckBox).Checked == true)
                        {
                            unit = gvr.Cells[2].Text.ToInt();
                            sum = sum + unit;
                        }
                    }
                    Label2.Text = sum.ToString();

                    if ((sum >= 12) && (sum <= 20))
                    {
                        lblmessage.Text = "";
                        foreach (GridViewRow gvr in GridView1.Rows)
                        {
                            if ((gvr.FindControl("CheckBox1") as CheckBox).Checked == true)
                            {
                                try
                                {
                                    CoursRepository air = new CoursRepository();
                                    Counter newAccount = new Counter();
                              //  string reshte=
                                    newAccount.Reshte = Session["value"].ToString();
                                    newAccount.stdid = Label1.Text;
                                    newAccount.CoursUnit = gvr.Cells[2].Text.ToInt();
                                    newAccount.CoursName = gvr.Cells[1].Text;
                                    air.Savecourse(newAccount);


                                    //  HadafTools.ShowMessage(lblmessage, " ثبت با موفقیت انجام شد ", Color.Red);

                                    succsesfulsave = "ok";
                                }
                                catch
                                {
                                    HadafTools.ShowMessage(lblmessage, " ثبت امکانپذیر  نمی باشد ", Color.Red);
                                }

                            }
                        }
                        if (succsesfulsave == "ok")
                        {
                            UserRepository ur = new UserRepository();
                            enter user = ur.FindByUserName(Label1.Text);
                            user.Status = int.Parse("1");
                            ur.Savestatus(user);


                            studentcountRepository str = new studentcountRepository();
                            Student newstd = new Student();
                            newstd.stdid = Label1.Text;
                            newstd.Reshte = Session["value"].ToString();
                            str.Save(newstd);
                            Redirector.Goto(Redirector.PageName.ok);
                         
                        }
                    }

                    else
                    {

                        HadafTools.ShowMessage(lblmessage, " تعداد واحد مجاز نمی باشد ", Color.Red);
                    }
               // }
                //catch
                //{
                //    HadafTools.ShowMessage(lblmessage, " ثبت امکانپذیر  نمی باشد ", Color.Red);
                //}
                    }
            else
            {
                HadafTools.ShowMessage(lblmessage, " پیش ثبت توسط این نام کاربری قبلا انجام شد ", Color.Red);
            }
        }


        }  
}