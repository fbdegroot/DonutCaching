using System.Web.Configuration;

namespace DonutCaching
{
    public interface ICacheSettingsManager
    {
        string RetrieveOutputCacheProviderType();
        OutputCacheProfile RetrieveOutputCacheProfile(string cacheProfileName);

        bool IsCachingEnabledGlobally { get; }
    }
}
