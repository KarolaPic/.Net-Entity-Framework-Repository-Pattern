using System.Collections.Generic;
using WebAPI.BusinessLogic.Contracts;
using System.Linq;

namespace WebAPI.Services
{
    public class UserService
    {
        private readonly IRepositoryManager _repository;

        public UserService(IRepositoryManager repositoryManager)
        {
            _repository = repositoryManager;
        }

        public List<DTO.User> GetUsers()
        {
            var users = _repository.User.GetAll();
            
            
            return users.Select(x => x.ToDTO())
                .ToList();
        }
        public DTO.User SetUser(DTO.User user)
        {
            _repository.Save();
            return user;
        }
    }
}
