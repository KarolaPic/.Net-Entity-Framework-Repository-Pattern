using DataAccess.Extensions;
using System.Collections.Generic;
using System.Linq;
using WebAPI.BusinessLogic.Contracts;
using WebAPI.DataAccess.Models;
using Domain = BusinessLogic.Domain;

namespace WebAPI.DataAccess
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public List<Domain.User> GetAll()
        {
            var dbUsers = FindAll(false).ToList();
            return dbUsers.Select(x => x.ToDomainModel()).ToList();
        }

        public Domain.User addUser(Domain.User user)
        {
            var dbUsers = FindAll(false).ToList();

            var userAux = new User
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };

            dbUsers.Add(userAux);
            return user;
        }
    }
}
