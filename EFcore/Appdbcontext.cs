using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{ 
    public class Appdbcontext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=DESKTOP-SH8J5TV\SQLEXPRESS;Initial Catalog=forfun;Integrated Security=True");
        }

       public DbSet<emplyee> emplyees { get; set; }
    }
}
