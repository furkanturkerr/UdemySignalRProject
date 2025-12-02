using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework;

public class EfAaboutDal : GenericRepository<About>, IAboutDal
{
    public EfAaboutDal(SignalRContext context) : base(context)
    {
    }
}