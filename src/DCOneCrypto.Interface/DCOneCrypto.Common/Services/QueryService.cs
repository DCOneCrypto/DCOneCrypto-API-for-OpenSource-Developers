namespace DCOneCrypto.Common.Services;

public class QueryService
{
    private readonly Dictionary<string, Task> ResultCache = new Dictionary<string, Task>();

    public Task<T> Query<T>(string key, Func<Task<T>> handler)
    {
        if (ResultCache.ContainsKey(key) &&
            ResultCache[key] is not null)
        {
            return (ResultCache[key] as Task<T>) ?? throw new NullReferenceException("Couldn't execute task or invalid.");
        }
        else
        {
            Task t = handler();
            ResultCache.Add(key, t);
            return (t as Task<T>) ?? throw new NullReferenceException("Couldn't execute task or invalid.");
        }
    }

    public void Invalidate()
    {
        ResultCache.Clear();
    }
}