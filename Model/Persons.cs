using System;
using System.Collections.Generic;

namespace SampleDBConn.Model
{
    public partial class Persons
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? Age { get; set; }
        public string City { get; set; }
    }
}
