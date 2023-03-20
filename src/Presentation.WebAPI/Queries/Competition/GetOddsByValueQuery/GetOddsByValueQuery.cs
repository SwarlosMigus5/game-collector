// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetOddsByValueQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetOddsByValueQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GameCollector.Presentation.WebAPI.Queries.Competition.GetOddsByValueQuery
{
    using GameCollector.Domain.AggregateModels.Competition;
    using MediatR;

    /// <summary>
    /// <see cref="GetOddsByValueQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{IEnumerable{Odd}}"/>
    public class GetOddsByValueQuery : IRequest<IEnumerable<Odd>>
    {
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public decimal Value { get; init; }
    }
}