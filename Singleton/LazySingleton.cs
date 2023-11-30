/**
* Lazy版Singleton產生器
* 支援泛型
* 限制: 使用的類別必須有一個無參數的建構函數
*/
class LazySingleton<T> where T : new()
{
    private LazySingleton() { }

    private static readonly Lazy<T> lazy = new Lazy<T>(() => new T());

    public static T GetInstance()
    {
        return lazy.Value;
    }

}