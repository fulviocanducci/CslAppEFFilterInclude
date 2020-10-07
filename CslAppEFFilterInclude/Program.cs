using CslAppEFFilterInclude.Data;
using CslAppEFFilterInclude.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace CslAppEFFilterInclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            DbContextOptionsBuilder<DatabaseSource> builder = 
                new DbContextOptionsBuilder<DatabaseSource>();
            builder.UseSqlServer("Server=127.0.0.1;Database=DatabaseSource;User Id=sa;Password=123456;");
            DbContextOptions<DatabaseSource> options = builder.Options;
            using (DatabaseSource db = new DatabaseSource(options))
            {
                //db.Database.EnsureCreated();

                //Item item0 = new Item
                //{
                //    Name = "Celular",
                //    Sales = new List<Sales>
                //    {
                //        new Sales
                //        {
                //            Value = 100
                //        },
                //        new Sales
                //        {
                //            Value = 200
                //        },
                //        new Sales
                //        {
                //            Value = 300
                //        },
                //    }
                //};

                //Item item1 = new Item
                //{
                //    Name = "Computador",
                //    Sales = new List<Sales>
                //    {
                //        new Sales
                //        {
                //            Value = 400
                //        },
                //        new Sales
                //        {
                //            Value = 200
                //        },
                //        new Sales
                //        {
                //            Value = 500
                //        },
                //    }
                //};
                //db.AddRange(item0, item1);
                //count = db.SaveChanges();


                //var items = db.Item.Include(x => x.Sales).ToImmutableList();
                var items = db.Item.AsNoTracking()
                    .Include(x => x.Sales.Where(c => c.Value == 200).ToList())
                    .ToImmutableList();

            }
            Console.WriteLine($"Done {count} register(s)");
        }
    }
}
