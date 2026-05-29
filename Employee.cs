using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ScallfoldingCrud.Models
{
    public class Employee
    {

        [DisplayName("Employee ID")]
        public int empid { get; set; }

        [DisplayName("Employee Name")]      
        public string name { get; set; }

        [DisplayName("Gender")]
        public string gender { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime dob { get; set; }

        [DisplayName("Email ID")]
        public string emailid { get; set; }

    }
}
