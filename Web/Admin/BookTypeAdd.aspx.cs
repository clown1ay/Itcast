using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Web.Admin
{
    public partial class BookTypeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Shop.Model.BookType btModel = new Shop.Model.BookType()
                {
                    TypeTitle = Request["title"],
                    TypeParentId = int.Parse(Request["pid"])
                };

                Shop.BLL.BookType btBll = new Shop.BLL.BookType();
                if (btBll.Add(btModel) > 0)
                {
                    Response.Redirect("BookTypeList.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}