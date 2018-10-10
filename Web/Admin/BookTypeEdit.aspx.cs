using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Web.Admin
{
    public partial class BookTypeEdit : System.Web.UI.Page
    {
        protected Shop.Model.BookType BtModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Shop.BLL.BookType btBll = new Shop.BLL.BookType();
            if (!IsPostBack)//初次加载请求
            {
                int id = int.Parse(Request["id"]);

                BtModel = btBll.GetModel(id);
            }
            else
            {
                //回传，进行修改处理
                BtModel = new Shop.Model.BookType()
                {
                    TypeId = int.Parse(Request["tid"]),
                    TypeTitle = Request["tTitle"],
                    TypeParentId = int.Parse(Request["tPid"])
                };

                if (btBll.Update(BtModel))
                {
                    Response.Redirect("BookTypeList.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}