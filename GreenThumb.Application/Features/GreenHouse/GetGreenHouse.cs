using System;
using System.Threading;
using System.Threading.Tasks;
using GreenThumb.Application.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GreenThumb.Application.Features.GreenHouse
{
    public static class GetGreenHouse
    {

        public record Query(int Id) : IRequest<GreenHouse>
        {
        }

        public class Handler : IRequestHandler<Query, GreenHouse>
        {
            private readonly IApplicationDbContext _dbContext;

            public Handler(IApplicationDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<GreenHouse> Handle(Query request, CancellationToken cancellationToken)
            {
                return await 
                    _dbContext.GreenHouses
                        .SingleAsync(house => house.Id == request.Id, cancellationToken: cancellationToken);
            }
        }
    }
}