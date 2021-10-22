using System.Collections.Generic;
using WebAPI.BusinessLogic.Contracts;
using System.Linq;

namespace WebAPI.Services
{
    public class CourseService
    {
        private readonly IRepositoryManager _repository;

        public CourseService(IRepositoryManager repositoryManager)
        {
            _repository = repositoryManager;
        }

        public List<DTO.Course> GetCourses()
        {
            var courses = _repository.Course.GetAll();


            return courses.Select(x => x.ToDTO())
                .ToList();
        }

        public DTO.Course SetCourse(DTO.Course course)
        {
            _repository.Save();
            return course;
        }
    }
}
