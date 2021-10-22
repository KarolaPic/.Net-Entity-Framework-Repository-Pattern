using WebAPI.DataAccess.Models;
using Domain = BusinessLogic.Domain;

namespace DataAccess.Extensions
{
    public static class CourseExtension
    {
        public static Domain.Course ToDomainModel(this Course c)
        {
            return new Domain.Course
            {
                Id = c.Id.ToString(),
                Name = c.Name
            };
        }
    }
}
