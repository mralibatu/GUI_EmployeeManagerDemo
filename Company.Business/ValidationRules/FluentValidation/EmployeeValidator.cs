using Company.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("First name can not be empty!");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Last name can not be empty!");
            RuleFor(p => p.WorkPosition).NotEmpty().WithMessage("Work position can not be empty!");
            RuleFor(p => p.Gender).NotEmpty().WithMessage("Gender can not be empty!");

            RuleFor(p => p.FirstName).Must(HasJustCharacter).WithMessage("You must use just alphabetical characters!");
            RuleFor(p => p.LastName).Must(HasJustCharacter).WithMessage("You must use just alphabetical characters!");
        }

        private bool HasJustCharacter(string arg)
        {
            return arg.Replace(" ", "").All(c => Char.IsLetter(c));      //Control every char with Linq
        }
    }
}
