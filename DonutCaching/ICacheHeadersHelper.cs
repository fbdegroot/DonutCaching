using System.Web;

namespace DonutCaching
{
	public interface ICacheHeadersHelper
	{
		void SetCacheHeaders(HttpResponseBase response, CacheSettings settings);
	}
}