using System;
using System.Collections.Generic;

namespace WebAPI.DataAccess.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Course> Courses { get; set; }
    }
}
