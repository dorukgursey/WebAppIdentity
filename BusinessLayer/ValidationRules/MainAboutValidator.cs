using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MainAboutValidator : AbstractValidator<MainAbout>
    {
        public MainAboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description field cannot be empty!");
            RuleFor(x => x.FirstImage).NotEmpty().WithMessage("Please select an image!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Please Enter at least 50 character description!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Description field cannot be more than 1500 characters!");
        }
    }
}
