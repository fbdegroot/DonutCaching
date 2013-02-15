using System;

namespace DonutCaching
{
    internal interface IExtendedOutputCacheManager : IOutputCacheManager
    {
        void AddItem(string key, CacheItem cacheItem, DateTime utcExpiry);
        CacheItem GetItem(string key);
    }
}
