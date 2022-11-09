using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using YazilimPark.Models;

namespace YazilimPark.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<RandomQuotations> RandomQuotations { get; set; }

        public DbSet<YazilimPark.Models.ToDoList> ToDoList { get; set; }


    }
}
