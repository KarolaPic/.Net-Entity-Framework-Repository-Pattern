using BusinessLogic.Domain;
using System.Collections.Generic;

namespace WebAPI.BusinessLogic.Contracts
{
    public interface IUserRepository
    {
        public List<User> GetAll();

        public User addUser(User user);
    }
}
