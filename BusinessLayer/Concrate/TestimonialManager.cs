using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialDal _testimonialDal;
    public TestimonialManager(ITestimonialDal testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }
    public void TAdd(Testimonial entity)
    {
        _testimonialDal.Add(entity);
    }

    public void TUpdate(Testimonial entity)
    {
        _testimonialDal.Update(entity);
    }

    public void TDelete(Testimonial entity)
    {
        _testimonialDal.Delete(entity);
    }

    public List<Testimonial> TGetListAll()
    {
        return _testimonialDal.GetListAll();
    }

    public Testimonial TGetById(int id)
    {
        return _testimonialDal.GetById(id);
    }
}