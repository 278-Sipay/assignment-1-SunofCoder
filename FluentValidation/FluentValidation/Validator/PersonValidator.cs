using FluentValidation;
using System;

namespace FluentValidation.Validator
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(_ => _.Name)
                 .

            RuleFor(x => x.Name)
                .MinimumLength(5)
                .MaximumLength(100)
                .WithMessage("Name field must contain a minimum of 3 characters and a maximum of 100 characters."); ;


            RuleFor(x => x.LastName).
                NotEmpty().
                WithMessage("LastName cannot be empty");

            RuleFor(x => x.LastName).
                MinimumLength(5).
                MaximumLength(100).
                WithMessage("Lastname length can be at least 5 and up to 100");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("Phone cannot be empty");


            RuleFor(x => x.AccessLevel)
                .NotEmpty()
                .WithMessage("AccessLevel cannot be empty");

            RuleFor(x => x.AccessLevel)
                .InclusiveBetween(1, 5)
                .WithMessage("AccessLevel should be between 1 and 5");


            RuleFor(x => x.Salary)
                .NotEmpty()
                .WithMessage("Salary cannot be empty");

            RuleFor(x => x.Salary)
                .InclusiveBetween(5000, 50000)
                .WithMessage("Salary should be between 5000 and 50000");


        }
        private bool Salary(int AccessLevel, decimal salary)
        {
            switch (AccessLevel)
            {
                case 1:
                    return salary <= 1000;
                case 2:
                    return salary <= 2000;
                case 3:
                    return salary <= 3000;
                case 4:
                    return salary <= 4000;
                default:
                    return false;
            }



        }
    }
}
