public class RedisRepository : IRepository
{
    public void Add(object entity) {
        Console.WriteLine("Redis repository added a entity.");
    }
}