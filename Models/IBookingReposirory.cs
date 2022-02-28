using System.Collections.Generic;

namespace DrivingClass.Models
{
     interface IBookingReposirory
    {
        IEnumerable<Appointment> AllBookings { get; }
    }
}
