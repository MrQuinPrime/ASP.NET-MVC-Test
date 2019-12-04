using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //内置对象      Request       Response      Session        Cookie           Application          Server
            //                请求          响应          会话          客户端数据        当前网站对象         服务器对象

            //Request  服务器接收客户端数据的
            //Request.QueryString     get请求！
            //Request.Form            post请求！
            //Request.MapPath()将虚拟路径转化为物理路径

            return Content($"{Request.QueryString["name"]}-{Request.QueryString["age"]}-{Request.QueryString["id"]}");
        }

        public ActionResult PostData()
        {
            return Content(Request.Form["loginname"]);
        }
        public ActionResult FileData()
        {
            //SaveAs方法需要物理路径
            Request.Files["file"].SaveAs(Request.MapPath("/Uploads/"+Request.Files
                ["file"].FileName));
            return Content("ok");
        }
    }
}