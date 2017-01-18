using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestOfHybrid.Models
{
    public class UserData
    {
    }
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public int? age { get; set; }
        public DateTime lastUpdate { get; set; }
    }

    public class UsersDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
    }
}