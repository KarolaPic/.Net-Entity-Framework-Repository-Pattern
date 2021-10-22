using WebAPI.DataAccess.Models;
using Domain = BusinessLogic.Domain;

namespace DataAccess.Extensions
{
    public static class UserExtension
    {
        public static Domain.User ToDomainModel(this User u)
        {
            return new Domain.User
            {
                Id = u.Id.ToString(),
                Email = u.Email,
                FirstName = u.FirstName,
                LastName = u.LastName
            };
        }
    }
}
