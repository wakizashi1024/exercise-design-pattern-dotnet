Parallel.For(0, 12, (index) =>
{
    var instance = Singleton1.GetInstance();
    Console.WriteLine($"第{index + 1}次: HashCode: {instance.GetHashCode()}");
});

Console.WriteLine($"------------------------------------------------------------------------------");

Parallel.For(0, 12, (index) =>
{
    var instance = Singleton2.GetInstance();
    Console.WriteLine($"第{index + 1}次: HashCode: {instance.GetHashCode()}");
});

Console.WriteLine($"------------------------------------------------------------------------------");

Parallel.For(0, 12, (index) =>
{
    var instance = Singleton3.GetInstance();
    Console.WriteLine($"第{index + 1}次: HashCode: {instance.GetHashCode()}");
});

Console.WriteLine($"------------------------------------------------------------------------------");

Parallel.For(0, 12, (index) =>
{
    // var instance = new MyClass();
    var instance = LazySingleton<MyClass>.GetInstance();
    Console.WriteLine($"第{index + 1}次: HashCode: {instance.GetHashCode()}");
});

Console.WriteLine($"------------------------------------------------------------------------------");

Parallel.For(0, 12, (index) =>
{
    // var instance = new MyClass();
    var instance = LazySingleton<MyClass>.GetInstance();
    Console.WriteLine($"第{index + 1}次: HashCode: {instance.GetHashCode()}");
});

Console.WriteLine($"------------------------------------------------------------------------------");

Parallel.For(0, 12, (index) =>
{
    // var instance = new MyClass();
    var instance = LockSingleton<MyClass>.GetInstance();
    Console.WriteLine($"第{index + 1}次: HashCode: {instance.GetHashCode()}");
});

Console.WriteLine($"------------------------------------------------------------------------------");

Parallel.For(0, 12, (index) =>
{
    // var instance = new MyClass();
    var instance = Singleton<MyClass>.GetInstance(1, 2);
    Console.WriteLine($"第{index + 1}次: HashCode: {instance.GetHashCode()}");
});


// 第一版，併發有機會取到不同的實例
class Singleton1
{
    private Singleton1() { }

    private static Singleton1 _instance;

    public static Singleton1 GetInstance()
    {
        if (_instance is null)
        {
            _instance = new Singleton1();
        }

        return _instance;
    }
}

// lazy版，另一種實現方式
class Singleton2
{
    private Singleton2() { }

    private static readonly Lazy<Singleton2> lazy = new Lazy<Singleton2>(() => new Singleton2());

    public static Singleton2 GetInstance()
    {
        return lazy.Value;
    }
}

// lock版，解決併發問題
class Singleton3
{
    private Singleton3() { }

    private static Singleton3 _instance;

    private static object _lock = new object();

    public static Singleton3 GetInstance()
    {
        if (_instance is null)
        {
            lock (_lock)
            {
                if (_instance is null)
                {
                    _instance = new Singleton3();
                }
            }
        }

        return _instance;
    }
}
