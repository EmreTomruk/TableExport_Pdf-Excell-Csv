using System.Web;
using System.Web.Mvc;

namespace TableExport_Pdf_Mvc_Word
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
