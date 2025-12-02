using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using SignalRApi.Dal.Entities;

namespace BusinessLayer.Concrate;

public class BookingManager : IBookingService
{
    private readonly IBookingDal _bookingDal;
    public BookingManager(IBookingDal bookingDal)
    {
        _bookingDal = bookingDal;
    }
    public void TAdd(Booking entity)
    {
        _bookingDal.Add(entity);
    }

    public void TUpdate(Booking entity)
    {
        _bookingDal.Update(entity);
    }

    public void TDelete(Booking entity)
    {
        _bookingDal.Delete(entity);
    }

    public List<Booking> TGetListAll()
    {
        return _bookingDal.GetListAll();
    }

    public Booking TGetById(int id)
    {
        return _bookingDal.GetById(id);
    }
}