using FluentValidation;
using SampleFluentValidations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFluentValidations.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty()
                .WithMessage("{PropertyName} should not be Empty.NEVER!")
                .MinimumLength(5)
                .WithMessage("{PropertyName} should not be less than 5 Characters.NEVER!")
                .Length(2, 50);

            RuleFor(x => x.MiddleName).NotEmpty()
                .WithMessage("{PropertyName} should be not Empty.NEVER!")
                .MinimumLength(5)
                .WithMessage("{PropertyName} should not be less than 5 Characters.NEVER!")
                .Length(2, 50);

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("{PropertyName} should not be Empty.NEVER!")
                .MinimumLength(5)
                .WithMessage("{PropertyName} should not be less than 5 Characters.NEVER!")
                .Length(2, 50);

            RuleFor(x => x.PhoneNumber)
                .LessThanOrEqualTo(10)
                .WithMessage("{PropertyName} should not be less than 10 Characters.NEVER!");

            RuleFor(x => x.EmailAddress)
               .EmailAddress()
               .WithMessage("{PropertyName} should be a valid Email Address.NEVER!");
        }
    }
}
