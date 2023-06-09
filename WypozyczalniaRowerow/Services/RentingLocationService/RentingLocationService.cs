using System;
using System.Linq;
using System.Linq.Expressions;
using WypozyczalniaRowerow.Areas.Identity.Data;
using WypozyczalniaRowerow.Models;

namespace WypozyczalniaRowerow.Services.RentingLocationService;

public class RentingLocationService : RepositoryService<RentingLocation>, IRentingLocationService
{
    public RentingLocationService(ApplicationDbContext context) : base(context)
    {
    }
}