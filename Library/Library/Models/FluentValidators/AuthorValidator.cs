using FluentValidation;

namespace Library.Models.FluentValidators
{
    public class AuthorValidator:AbstractValidator<Author>  
    {
        public AuthorValidator() 
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Zorunlu Alan");
            
           
        }    
    }
}
