using System;
using System.Linq;
using System.Linq.Expressions;
using WypozyczalniaRowerow.Areas.Identity.Data;
using WypozyczalniaRowerow.Models;

namespace WypozyczalniaRowerow.Services.VehicleService;

public class VehicleService : RepositoryService<Vehicle>, IVehicleService
{
    public VehicleService(ApplicationDbContext context) : base(context)
    {
    }
}