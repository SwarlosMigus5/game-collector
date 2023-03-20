// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOddRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IOddRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GameCollector.Domain.AggregateModels.Competition.Repository
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using GameCollector.Domain.SeedWork;

    /// <summary>
    /// <see cref="IOddRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Odd}"/>
    public interface IOddRepository : IRepository<Odd>
    {
        /// <summary>
        /// Gets the by value asynchronous.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<List<Odd>> GetByValueAsync(decimal startOfRange, decimal endOfRange, CancellationToken cancellationToken);
    }
}