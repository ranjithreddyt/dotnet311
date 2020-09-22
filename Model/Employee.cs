using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SampleDBConn.Model
{
    public  class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpLastName { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpOrganization { get; set; }
        public string EmpCity { get; set; }
    }
}

