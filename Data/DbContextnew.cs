using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleDBConn.Model;

    public class DbContextnew : DbContext
    {
        public DbContextnew (DbContextOptions<DbContextnew> options)
            : base(options)
        {
        }

        public DbSet<SampleDBConn.Model.Employee> Employee { get; set; }

        public DbSet<SampleDBConn.Model.Persons> Persons { get; set; }
    }
