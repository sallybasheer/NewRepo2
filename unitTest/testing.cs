using System;
using System.Collections.Generic;
using System.Text;
using infra2.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Xunit;
namespace unitTest
{
    public class testing
    {
        public MyContext ctx;
        IServiceProvider serviceProvider;
        public testing(MyContext ctx=null) { this.ctx = ctx ?? GetINmemorydbcontext(); }
        protected MyContext GetINmemorydbcontext() {
            var service = new ServiceCollection().AddEntityFrameworkInMemoryDatabase().BuildServiceProvider();
            var builder = new DbContextOptionsBuilder<MyContext>();
            var option = builder.UseInMemoryDatabase("testing").UseInternalServiceProvider(serviceProvider).Options;
            MyContext dbcontex = new MyContext(option);
            dbcontex.Database.EnsureDeleted();
            dbcontex.Database.EnsureCreated();
            return dbcontex;
        
        }
    }
   
}
