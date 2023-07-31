using FluentValidation;
using HotelProject.WebUI.DTOs.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidation
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x=> x.Name).NotEmpty().WithMessage("Name area must not be empty");
            RuleFor(x=> x.Surname).NotEmpty().WithMessage("Surname area must not be empty");
            RuleFor(x=> x.City).NotEmpty().WithMessage("City area must not be empty");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Please enter at least 3 charachters");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Please enter at least 2 charachters");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Please enter at least 3 charachters");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Please enter at most 20 charachters");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Please enter at most 30 charachters");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Please enter at most 20 charachters");
        }
    }
}
