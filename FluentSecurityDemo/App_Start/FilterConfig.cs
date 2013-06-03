using FluentSecurity;
using System.Web;
using System.Web.Mvc;

namespace FluentSecurityDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //加入Fluent Security的Attribute，第二個參數為0表示最優先。
            filters.Add(new HandleSecurityAttribute(), 0);

            filters.Add(new HandleErrorAttribute());
        }
    }
}