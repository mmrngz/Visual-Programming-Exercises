using FluentValidation;

namespace MvcProject.MODEL.Models.FluentValidators
{
    public class BookValidator:AbstractValidator<Book>  
    {
        public BookValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Zorunlu Alan");
            When(x => x.Name == "Deneme", () =>
            {
                RuleFor(x => x.PageCount).Must(y => y =="50" ).WithMessage("Kitabin Ismi Deneme ise PageCount 50 Olmali");
            });
            RuleFor(x => x.PageCount).Must(y => int.TryParse(y, out int value)).WithMessage("Lutfen Sayi Girin");
        }  


    }
}
