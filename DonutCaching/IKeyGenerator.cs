using System.Web.Mvc;

namespace DonutCaching
{
    public interface IKeyGenerator
    {
        string GenerateKey(ControllerContext context, CacheSettings cacheSettings);
    }
}
