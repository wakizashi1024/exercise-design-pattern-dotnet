/**
* Lock版Singleton產生器
* 支援泛型
* 限制: 使用的類別必須有一個無參數的建構函數
*/
class LockSingleton<T> where T : new()
{
    private static T _instance;

    private static readonly object _lock = new object();

    public static T GetInstance()
    {
        if (_instance is null)
        {
            lock (_lock)
            {
                if (_instance is null)
                {
                    _instance = new T();
                }
            }
        }

        return _instance;
    }
}