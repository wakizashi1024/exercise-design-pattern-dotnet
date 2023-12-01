public class EFCoreRepository : IRepository
{
    public void Add(object entity) {
        Console.WriteLine("EF Core repository added a entity.");
    }
}