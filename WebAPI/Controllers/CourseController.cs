using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CourseService _courseService;

        public CourseController(CourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public List<DTO.Course> Get()
        {
            return _courseService.GetCourses();
        }

        [HttpPost]
        public ActionResult<DTO.Course> Post(DTO.Course course)
        {
            _courseService.SetCourse(course);
            return CreatedAtAction("SetCourse", new { id = course.CourseId }, course);
        }

    }
}
