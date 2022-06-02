using GreenThumb.Application.Core;
using GreenThumb.Application.Features.GreenHouse;
using Microsoft.EntityFrameworkCore;

namespace GreenThumb.Infrastructure.Data
{
    public class GreenThumbContext: DbContext, IApplicationDbContext
    {
        public DbSet<GreenHouse> GreenHouses { get; set; }
    }
}