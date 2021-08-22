using infra2.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace infra2.Repositories
{
    public class bookRepositories
    {
        public MyContext ctx;
        public bookRepositories(MyContext ctx)
        {
            this.ctx = ctx;
        }
        public book post(book book)
        {
            ctx.Add(book);
            ctx.SaveChanges();
            return book;



        }

    }
}
