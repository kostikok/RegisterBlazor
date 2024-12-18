namespace werver.Models
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        Task Save();
    }
}
