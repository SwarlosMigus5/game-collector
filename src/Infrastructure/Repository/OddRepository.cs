// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OddRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// OddRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GameCollector.Infrastructure.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using GameCollector.Domain.AggregateModels.Competition;
    using GameCollector.Domain.AggregateModels.Competition.Repository;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// <see cref="OddRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Odd}"/>
    /// <seealso cref="IOddRepository"/>
    internal class OddRepository : GenericRepository<Odd>, IOddRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OddRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public OddRepository(GameCollectorDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets the by value asynchronous.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<List<Odd>> GetByValueAsync(decimal startOfRange, decimal endOfRange, CancellationToken cancellationToken)
        {
            return await this.Entities
                .Where(x =>
                    x.Value <= endOfRange &&
                    x.Value >= startOfRange)
                .ToListAsync();
        }
    }
}