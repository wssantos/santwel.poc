using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace santwel.poc.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<poc.EntityFramework.pocDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "poc";
        }

        protected override void Seed(poc.EntityFramework.pocDbContext context)
  
        {
            IList<Product> products = new List<Product>();

            products.Add(new Product() { Name = "Laptop wsto", Description = "New model faster than Mac!", QtyAvailable = 100, QtyReserverdForSale = 30, UnitPrice = 200 });
            products.Add(new Product() { Name = "Mouse", Description = "New model.", QtyAvailable = 0, QtyReserverdForSale = 0, UnitPrice = 20 });
            products.Add(new Product() { Name = "Keyboard", Description = "Standard", QtyAvailable = 100, QtyReserverdForSale = 30, UnitPrice = 30 });

            context.Products.Add(products[0]);
            context.Products.Add(products[1]);
            context.Products.Add(products[2]);
            base.Seed(context);
        }
    }
}
