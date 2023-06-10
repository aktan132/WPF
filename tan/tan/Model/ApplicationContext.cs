using System;

using System.Data.Entity;

namespace tan.Model
{
      class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext() : base("DefaultConnection") { }

    }

}
