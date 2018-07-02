using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Web.Admin
{
    public partial class BookTypeList : System.Web.UI.Page
    {
        protected string ZTree { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Shop.BLL.BookType btBll = new Shop.BLL.BookType();
            DataTable dt = btBll.GetAllList().Tables[0];

            //{ id: 1, pId: 0, name: "父节点1 - 展开", open: true },
            List<BookTypeTree> list=new List<BookTypeTree>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new BookTypeTree()
                {
                    id = Convert.ToInt32(row["TypeId"]),
                    name = row["TypeTitle"].ToString(),
                    pId = Convert.ToInt32(row["TypeParentId"]),
                    open = true
                    //isParent = true,
                    //click = "PromptDo("+Convert.ToInt32(row["TypeId"])+")"
                });
            }

            JavaScriptSerializer js=new JavaScriptSerializer();
            ZTree = js.Serialize(list);
        }
    }
}