using FluentValidation;

namespace ReceipeApp.Shared;

public class ReceipeValidator : AbstractValidator<Receipe>
{
    public ReceipeValidator()
    {
        RuleFor(_ => _.Name)
            .NotEmpty().WithMessage("نام باید مقدار داشته باشد.")
            .Length(5, 50)
            .WithMessage("طول نام باید بین 5 تا 50 کاراکتر باشد.");

        RuleFor(_ => _.Description)
            .NotEmpty().WithMessage("توضیحات باید مقدار داشته باشد.")
            .Length(10, 500).WithMessage("طول توضیحات باید بین 10 تا 500 کاراکتر باشد.");

        RuleFor(_ => _.Detail)
            .NotEmpty().WithMessage("دستور پخت باید مقدار داشته باشد.")
            .Length(5, 250).WithMessage("طول دستور پخت باید بین 5 تا 250 کاراکتر باشد.");

        RuleForEach(_ => _.Ingredients).SetValidator(new IngredientValidator());
    }
}

public class IngredientValidator : AbstractValidator<Ingredient>
{
    public IngredientValidator()
    {
        RuleFor(_ => _.Name)
            .NotEmpty().WithMessage("نام ماده تشکیل دهنده باید مقدار داشته باشد.")
            .Length(5, 50)
            .WithMessage("طول نام ماده تشکیل دهنده باید بین 5 تا 50 کاراکتر باشد.");

        RuleFor(_ => _.Value)
            .NotEmpty().WithMessage("مقدار ماده تشکیل دهنده باید مقدار داشته باشد.")
            .Length(5, 50)
            .WithMessage("طول مقدار ماده تشکیل دهنده باید بین 5 تا 50 کاراکتر باشد.");
    }
}