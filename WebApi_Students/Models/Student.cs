using System;

namespace WebApi_lesson2.Models
{
    public class Student
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Group { get; set; }
    }
}
