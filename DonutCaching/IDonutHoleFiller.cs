using System.Web.Mvc;

namespace DonutCaching
{
    public interface IDonutHoleFiller
    {
        string RemoveDonutHoleWrappers(string content, ControllerContext filterContext);
        string ReplaceDonutHoleContent(string content, ControllerContext filterContext);
    }
}
