using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Models
{
    class Course
    {
        private string ID {  get; set; }
        private string CourseName { get; set; }
        private string Description {  get; set; }
        private string Duration { get; set; }
        private string Lecturer { get; set; }
        private double Price { get; set; }
        private string Category { get; set; }
        private DateTime StartDate {  get; set; }

        // Constructor
        public Course() { }

        public Course(string iD, string courseName, string description, string duration, string lecturer, double price, string category, DateTime startDate)
        {
            ID = iD;
            CourseName = courseName;
            Description = description;
            Duration = duration;
            Lecturer = lecturer;
            Price = price;
            Category = category;
            StartDate = startDate;
        }

    }
}
