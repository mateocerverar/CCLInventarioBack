using FluentValidation;
using WebAPI.DTOs;

namespace WebAPI.Validator
{
    public class MovimientoValidator : AbstractValidator<MovimientoDTO>
    {
        public MovimientoValidator()
        {
            RuleFor(x => x.IdProducto).GreaterThan(0);
            RuleFor(x => x.Tipo).Must(t => t == "entrada" || t == "salida");
            RuleFor(x => x.Cantidad).GreaterThan(0);
        }
    }
}
