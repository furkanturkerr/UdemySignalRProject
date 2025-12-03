using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfBookingDal : GenericRepository<Booking>, IBookingDal
{
    public EfBookingDal(SignalRContext context) : base(context)
    {
    }
}