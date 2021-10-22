namespace WebAPI.BusinessLogic.Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        ICourseRepository Course { get; }
        void Save();
    }

}
