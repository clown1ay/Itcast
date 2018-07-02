using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Web.Admin
{
    /// <summary>
    /// UserManagerRemove 的摘要说明
    /// </summary>
    public class UserManagerRemove : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            int id = int.Parse(context.Request["id"]);

            Shop.BLL.UserManager umBll = new Shop.BLL.UserManager();
            if (umBll.Delete(id))
            {
                context.Response.Write(1);
            }
            else
            {
                context.Response.Write(0);
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}