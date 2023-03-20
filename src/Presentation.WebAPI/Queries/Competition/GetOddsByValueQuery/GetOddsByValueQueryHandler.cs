// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetOddsByValueQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetOddsByValueQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GameCollector.Presentation.WebAPI.Queries.Competition.GetOddsByValueQuery
{
    using GameCollector.Domain.AggregateModels.Competition;
    using GameCollector.Domain.AggregateModels.Competition.Repository;
    using MediatR;

    /// <summary>
    /// <see cref="GetOddsByValueQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetOddsByValueQuery, IEnumerable{Odd}}"/>
    public class GetOddsByValueQueryHandler : IRequestHandler<GetOddsByValueQuery, IEnumerable<Odd>>
    {
        /// <summary>
        /// The odd repository
        /// </summary>
        private readonly IOddRepository oddRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOddsByValueQueryHandler"/> class.
        /// </summary>
        /// <param name="oddRepository">The odd repository.</param>
        public GetOddsByValueQueryHandler(IOddRepository oddRepository)
        {
            this.oddRepository = oddRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        public async Task<IEnumerable<Odd>> Handle(GetOddsByValueQuery request, CancellationToken cancellationToken)
        {
            decimal startOfRange = request.Value - (request.Value * 0.05m);
            decimal endOfRange = request.Value + (request.Value * 0.05m);

            return await this.oddRepository.GetByValueAsync(startOfRange, endOfRange, cancellationToken);
        }
    }
}