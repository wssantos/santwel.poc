using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;

namespace santwel.poc.EntityFramework
{
    public class pocDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public virtual IDbSet<Order> Orders { get; set; }
        public virtual IDbSet<Item> Items { get; set; }

        public virtual IDbSet<Product> Products { get; set; }
       // public virtual IDbSet<Task> Tasks { get; set; }
        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public pocDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in pocDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of pocDbContext since ABP automatically handles it.
         */
        public pocDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public pocDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public pocDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().ToTable("Products").HasKey(k=>k.Id);

            modelBuilder.Entity<Order>().ToTable("Orders").HasKey(k => k.Id);
            modelBuilder.Entity<Order>().ToTable("Orders").HasMany<Item>(i=> i.Items);

            modelBuilder.Entity<Item>().ToTable("Items").HasKey(k => k.Id);
            modelBuilder.Entity<Item>().ToTable("Items").HasRequired<Order>(s => s.Order)
            .WithMany(g => g.Items)
            .HasForeignKey(s => s.OrderId);


        }
       
    }
}
