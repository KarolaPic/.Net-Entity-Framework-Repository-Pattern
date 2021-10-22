using System;
using System.Collections.Generic;

namespace BusinessLogic.Domain
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public DTO.Course ToDTO()
        {
            return new DTO.Course()
            {
                CourseId = Id,
                Name = Name
            };
        }
    }

    
}
