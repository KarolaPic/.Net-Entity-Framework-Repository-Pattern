using DataAccess.Extensions;
using System.Collections.Generic;
using System.Linq;
using WebAPI.BusinessLogic.Contracts;
using WebAPI.DataAccess.Models;
using Domain = BusinessLogic.Domain;
namespace WebAPI.DataAccess
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public List<Domain.Course> GetAll()
        {
            var dbCourses = FindAll(false).ToList();
            return dbCourses.Select(x => x.ToDomainModel()).ToList();
        }

        public Domain.Course addCourse(Domain.Course course)
        {
            var dbCourses = FindAll(false).ToList();

            var courseAux = new Course
            {
                Id = course.Id,
                Name = course.Name
            };

            dbCourses.Add(courseAux);
            return course;
        }

    }
}
