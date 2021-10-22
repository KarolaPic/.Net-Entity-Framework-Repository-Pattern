using BusinessLogic.Domain;
using System.Collections.Generic;

namespace WebAPI.BusinessLogic.Contracts
{
    public interface ICourseRepository
    {
        public List<Course> GetAll();

        public Course addCourse( Course course );
    }
}
