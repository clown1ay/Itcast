using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Web.Admin
{
    public partial class UserManagerEdit : MyPageBase//  System.Web.UI.Page
    {
        protected Shop.Model.UserManager UMModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Shop.BLL.UserManager umBll = new Shop.BLL.UserManager();
            if (IsPostBack)
            {
                //修改处理
                bool isPwdEdit = false;
                UMModel = new Shop.Model.UserManager()
                {
                    UserId = int.Parse(Request["uid"]),
                    UserName = Request["uname"],
                };

                //判断密码是否修改
                if (!Request["upwd"].Equals(Request["upwd2"]))
                {
                    isPwdEdit = true;
                    UMModel.UserPwd = Shop.Common.DEncrypt.MD5Encrypt.EncryptString(Request["upwd"]);
                }

                if (umBll.Update(UMModel, isPwdEdit))
                {
                    Response.Redirect("UserManagerList.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
            else
            {
                //修改展示
                int id = int.Parse(Request["id"]);
                
                UMModel = umBll.GetModel(id);
            }
        }
    }
}