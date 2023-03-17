﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateOddCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateOddCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GameCollector.Presentation.WebAPI.Commands.CreateOddCommand
{
    using GameCollector.Domain.AggregateModels.Competition;
    using GameCollector.Domain.AggregateModels.Competition.Enum;
    using MediatR;

    /// <summary>
    /// <see cref="CreateOddCommand"/>
    /// </summary>
    /// <seealso cref="IRequest{Odd}"/>
    public class CreateOddCommand : IRequest<Odd>
    {
        /// <summary>
        /// Gets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public Guid BookmakerId { get; init; }

        public Guid GameId { get; init; }

        /// <summary>
        /// Gets the team identifier.
        /// </summary>
        /// <value>The team identifier.</value>
        public Guid? TeamId { get; init; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public OddType Type { get; init; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public decimal Value { get; init; }
    }
}