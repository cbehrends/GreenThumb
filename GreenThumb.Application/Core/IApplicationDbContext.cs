using GreenThumb.Application.Features.GreenHouse;
using Microsoft.EntityFrameworkCore;

namespace GreenThumb.Application.Core
{
    public interface IApplicationDbContext
    {
        DbSet<GreenHouse> GreenHouses { get; set; }
    }
}