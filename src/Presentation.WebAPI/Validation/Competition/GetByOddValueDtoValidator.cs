// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByOddValueDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetByOddValueDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GameCollector.Presentation.WebAPI.Validation.Competition
{
    using FluentValidation;
    using GameCollector.Presentation.WebAPI.Dtos.Input.Competition;

    /// <summary>
    /// <see cref="GetByOddValueDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetByOddValueDto}"/>
    public class GetByOddValueDtoValidator : AbstractValidator<GetByOddValueDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetByOddValueDtoValidator"/> class.
        /// </summary>
        public GetByOddValueDtoValidator()
        {
            this.RuleFor(x => x.Value)
                .GreaterThan(1)
                    .WithMessage("The odd Value shouldn't be lower than 1.");
        }
    }
}