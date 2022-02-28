using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingClass.Models
{
    public class Appointment
    {
        public Appointment()
        {
        }

        public Appointment(DateTime dateTime, Driver driver, Learner learner, DateTime start, DateTime end)
        {

            Start = start;
            End = end;

            Driver = driver;

            Learner = learner;
        }


        public int AppointmentId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        [Display(Name = "Driver")]
        public int DriverrId { get; set; }


        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        [Display(Name = "Learner")]
        public int LearnerId { get; set; }

        [ForeignKey("LearnerId")]
        public Learner Learner { get; set; }

    }
}
