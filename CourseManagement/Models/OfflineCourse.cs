using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Models
{
    class OfflineCourse : Course
    {
        public OfflineCourse()
        {
        }

        public OfflineCourse(
            string iD, 
            string courseName, 
            string description, 
            string duration, 
            string lecturer, 
            double price, 
            string category, 
            DateTime startDate,
            string location,
            string classroom,
            string schedule) : base(iD, courseName, description, duration, lecturer, price, category, startDate)
        {
            this.Location = location;
            this.Classroom = classroom;
            this.Schedule = schedule;
        }

        private string Location {  get; set; }
        private string Classroom { get; set; }
        private string Schedule {  get; set; }

        // Constructor

    }
}
