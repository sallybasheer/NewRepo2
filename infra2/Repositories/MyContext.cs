using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Unity;
using Microsoft.CodeAnalysis.Options;
using infra2.model;

namespace infra2.Repositories
{
    public class MyContext : DbContext

    {
        DbSet<book> book { set; get; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<book>(e =>
            {
                e.ToTable("book").HasKey(k => k.id);
                e.Property(p => p.id).ValueGeneratedOnAdd();
            });



        }



    }

}








