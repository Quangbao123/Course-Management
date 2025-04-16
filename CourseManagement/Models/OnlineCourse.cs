using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Models
{
    class OnlineCourse : Course
    {
        private string Platform {  get; set; }
        private string Recording { get; set; }
        private int ContactNumber {  get; set; }

        public OnlineCourse() { }

        public OnlineCourse(
                string iD, string courseName, string description, 
                string duration, string lecturer, double price, string category, 
                DateTime startDate, string platform, string recording,
                int contactNumber
            ) : base(iD, courseName, description, duration, lecturer, price, category, startDate)
        {
            this.Platform = platform;
            this.Recording = recording;
            this.ContactNumber = contactNumber;
        }

    }
}
