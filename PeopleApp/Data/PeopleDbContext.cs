using PeopleApp.Models.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;

namespace PeopleApp.Data
{
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options)
        { }
        public DbSet<Person>? Persons { get; set; }
    }
}
