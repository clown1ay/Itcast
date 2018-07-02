using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Web.Admin
{
    public partial class UserManagerAdd : MyPageBase// System.Web.UI.Page
    {
        protected string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request["uname"]))
            {
                Shop.Model.UserManager umModel = new Shop.Model.UserManager()
                {
                    UserName = Request["uname"],
                    UserPwd = Shop.Common.DEncrypt.MD5Encrypt.EncryptString(Request["upwd"])
                };

                Shop.BLL.UserManager umBll = new Shop.BLL.UserManager();
                if (umBll.Add(umModel) > 0)
                {
                    Response.Redirect("UserManagerList.aspx");
                }
                else
                {
                    Msg = "添加失败，请稍候重试";
                }
            }
        }
    }
}