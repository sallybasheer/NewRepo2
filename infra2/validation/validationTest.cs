using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using infra2.model;
namespace infra2.validation
{
   public class validationTest:AbstractValidator<book>

    {
        public validationTest()
        {
            RuleFor(x => x.id)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode("50")
                .GreaterThan(99)
                .WithErrorCode("51")
                .LessThan(5000)
                .WithErrorCode("52");
            RuleFor(e => e.IsExisting)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode("53")
                .Equal(true).WithErrorCode("54");
            RuleFor(p => p.titel)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty()
               .WithErrorCode("55")
               .MaximumLength(20)
               .WithErrorCode("56");
            /*var user = new User(1, "LUCIANO PEREIRA", 33, true);

            var Val = new PostUserValidator().Validate(user);
            Assert.True(Val.IsValid);

            if (Val.IsValid)
            {
                user = new UserRepositories(ctx).post(user);
                Assert.Equal(1, user.id);
            }*/
        }

    }
}
