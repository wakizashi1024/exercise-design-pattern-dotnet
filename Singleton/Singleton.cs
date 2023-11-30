/**
* Lock版Singleton產生器改良版
* 支援泛型
* 使用反射後，支援多種任意數量建構子
*/
class Singleton<T> where T : class
{
    private static T _instance;

    private static readonly object _lock = new object();

    public static T GetInstance(params object[] args)
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    Type type = typeof(T);
                    _instance = (T)Activator.CreateInstance(type, args);
                }
            }
        }

        return _instance;
    }
}