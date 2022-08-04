using FluentValidation;

namespace Validators;

public class RequestValidator : AbstractValidator<ParamsRequest>
{
    public RequestValidator()
    {
        RuleFor(v => v.Name).NotNull();
    }
}