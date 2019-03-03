using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq;

namespace App.Web.Helper
{
    public class Cache
    {
        private readonly IMemoryCache cache;
        private static readonly TimeSpan _defaultCacheDuration = TimeSpan.FromSeconds(30);

        public Cache(IMemoryCache cache)
        {
            this.cache = cache;
        }

        //public T GetValue<T>(string key, Delegate @delegate)
        //{
        //    return cache.GetOrCreate(key, async entry =>
        //    {
        //        entry.SlidingExpiration = _defaultCacheDuration;
        //        return @delegate.DynamicInvoke();
        //    });
        //}

        //public bool Add(string key, object value)
        //{
        //    MemoryCache memoryCache = MemoryCache.Default;
        //    DateTimeOffset absExpiration = DateTimeOffset.UtcNow.AddHours(1);
        //    return memoryCache.Add(key, value, absExpiration);
        //}

        //public void Delete(string key)
        //{
        //    MemoryCache memoryCache = MemoryCache.Default;
        //    if (memoryCache.Contains(key))
        //    {
        //        memoryCache.Remove(key);
        //    }
        //}
    }
}
