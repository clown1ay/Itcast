using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Web.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //验证码
                if (Session["ValidateCode"]==null)
                {
                    return;
                }
                if (Request["vcode"].Equals(Session["ValidateCode"].ToString()))
                {
                    //用户名密码
                    Shop.Model.UserManager umModel = new Shop.Model.UserManager()
                    {
                        UserName = Request["uname"],
                        UserPwd = Shop.Common.DEncrypt.MD5Encrypt.EncryptString( Request["upwd"])
                    };

                    Shop.BLL.UserManager umBll = new Shop.BLL.UserManager();
                    int id = 0;
                    if (umBll.Exists(umModel,out id))
                    {
                        Session["ValidateCode"] = null;

                        umModel.UserId = id;

                        //标记登录成功
                        Session["UserModel"] = umModel;

                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        Msg = "用户名或密码错误";
                    }
                }
                else
                {
                    Msg = "验证码错误";
                }
                Session["ValidateCode"] = null;
            }
        }
    }
}