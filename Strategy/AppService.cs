class AppService
{
    private readonly IRepository _repository;

    public AppService(IRepository repository)
    {
        _repository = repository;
    }

    public void Create(object entity)
    {
        _repository.Add(entity);
    }
}