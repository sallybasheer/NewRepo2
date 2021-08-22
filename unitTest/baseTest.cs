using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using infra2.model;
using infra2.Repositories;
using System.Linq;
using infra2.validation;
namespace unitTest
{
    public class baseTest : testing
    {
        [Fact]
        public void fact_booktest()
        {

            var book = new book(100, "green", true);
            book = new bookRepositories(ctx).post(book);

        }
        [Fact]
        public void fact_validate()
        {
            var book = new book(100, "green", true);
            var val = new validationTest().Validate(book);
            Assert.True(val.IsValid);



        }
        [Theory]
        [InlineData(null, 50)]
        [InlineData(99, 51)]
        [InlineData(5000, 52)]
        public void thory_booktestId(int id, int error)
        {
            var book = new book() { id = id };

            var res = new validationTest().Validate(book);
            Assert.False(res.IsValid);
        }
        [Theory]
        [InlineData(null,53)]
        
        [InlineData(false,54)]
        public void thory_booktestISexsisting(bool isExisting,int error) {
            var book = new book() { IsExisting = isExisting };
            var res = new validationTest().Validate(book);
            Assert.False(res.IsValid);

        }
        [Theory]
        [InlineData(" ",55)]
        [InlineData("tytgsgssygshshsjkjjmj", 56)]
        public void thory_booktestTitel(string titel,int error) {
            var book = new book() { titel = titel };
            var res = new validationTest().Validate(book);
            Assert.False(res.IsValid);
        
        }
    }
        
}
