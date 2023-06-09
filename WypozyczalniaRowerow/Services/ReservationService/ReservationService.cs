using System;
using System.Linq;
using System.Linq.Expressions;
using WypozyczalniaRowerow.Areas.Identity.Data;
using WypozyczalniaRowerow.Models;

namespace WypozyczalniaRowerow.Services.ReservationService;

public class ReservationService : RepositoryService<Reservation>, IReservationService
{
    public ReservationService(ApplicationDbContext context) : base(context)
    {
    }
}