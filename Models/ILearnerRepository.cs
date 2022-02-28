using System.Collections.Generic;

namespace DrivingClass.Models
{
     interface ILearnerRepository
    {
        IEnumerable<Driver> AllDrivers { get; }
    }
}
