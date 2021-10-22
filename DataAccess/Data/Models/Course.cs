using System;
using System.Collections.Generic;

namespace WebAPI.DataAccess.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
