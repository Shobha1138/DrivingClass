using System.Collections.Generic;

namespace DrivingClass.Models
{
    public interface IDriverRepository
    {
        IEnumerable<Appointment> AllAppointments { get; }
        IEnumerable<Driver> AllDrivers { get; set; }

        Appointment GetAppointmentsById(int AppointmentId);
    }
}
