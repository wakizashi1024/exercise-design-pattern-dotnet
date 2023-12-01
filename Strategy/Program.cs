using Microsoft.Extensions.DependencyInjection;

// 策略模式
var shoppingCart = new List<Product>();
shoppingCart.Add(new Product("Cookie", 4.99M, new NoDiscountStragegy()));
shoppingCart.Add(new Product("Cake", 7.99M, new TenPercentDiscountStrategy()));

foreach(var product in shoppingCart)
{
    Console.WriteLine($"{product.Name} final price: {product.GetPrice()}");
}

// 策略模式 + DI/IOC
var services = new ServiceCollection();
services.AddScoped<IRepository, EFCoreRepository>();
// services.AddScoped<IRepository, RedisRepository>();
services.AddScoped<AppService>();

var builder = services.BuildServiceProvider();
var appService = builder.GetRequiredService<AppService>();
appService.Create(null);