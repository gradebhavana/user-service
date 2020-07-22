namespace UserMicroService.Repository
{
    public interface IGenericRepository<T>where T:class
    {
        T GetById(long id);
    }
}
