using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DrivingClass.Models
{
    public class Learner
    {
        public Learner()
        {

        }

        public Learner(string learnerName, int age, List<Driver> drivers, DateTime start, DateTime end,  string email)
        {

            LearnerName = learnerName;
            Age = age;
            Drivers = drivers;
            Start = start;
            End = end;
            //DriverName = driverName;
            Email = email;
        }
        [Key]
        public int LearnerId { get; set; }
        public string LearnerName { get; set; }
        public int Age { get; set; }
        public IEnumerable<Driver> Drivers { get; set; }




        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        //public string DriverName { get; set; }
        public string Email { get; set; }
    }
}
