using WebAPI.BusinessLogic.Contracts;

namespace WebAPI.DataAccess
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IUserRepository _userRepository;
        private ICourseRepository _courseRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public ICourseRepository Course
        {
            get
            {
                if (_courseRepository == null)
                    _courseRepository = new CourseRepository(_repositoryContext);
                return _courseRepository;
            }
        }
        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_repositoryContext);
                return _userRepository;
            }
        }
        public void Save() => _repositoryContext.SaveChanges();
    }


}
