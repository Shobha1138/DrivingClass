using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingClass.Models
{
    public class Driver
    {
        public Driver()
        {
        }

        //public Driver(string driverName, string vechicalType, string fileName, byte[] file, IFormFile fileForm)
        //{
        //    DriverName = driverName;
        //    VechicalType = vechicalType;
        //    FileName = fileName;
        //    File = file;
        //    FileForm = fileForm;
        //}

        //public Driver(string drivername, string vechicaltype, string filename /*byte[] file*/)
        //{
        //    Drivername = drivername;
        //    Vechicaltype = vechicaltype;
        //    Filename = filename;
        //    //file = file;
        //}

        //public driver(string drivername, string vechicaltype, /*string imageurl*/string filename, byte[] file)
        //{

        //    drivername = drivername;
        //    vechicaltype = vechicaltype;
        //    //imageurl = imageurl;
        //    filename = filename;
        //    file = file;

        //}
        [Key]
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string VechicalType { get; set; }

        //public string ImageUrl { get; set; }

        public string FileName { get; set; } 
        public byte[] File { get; set; }  

        [NotMapped]
        public IFormFile FileForm { get; set; }
        public List<Learner> Learners { get; set; }
    }
}
