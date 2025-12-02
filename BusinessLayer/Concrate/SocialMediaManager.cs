using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class SocialMediaManager : ISocialMediaService
{
    private readonly ISocialMediaDal _socialMediaDal;
    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }
    public void TAdd(SocialMedia entity)
    {
        _socialMediaDal.Add(entity);
    }

    public void TUpdate(SocialMedia entity)
    {
        _socialMediaDal.Update(entity);
    }

    public void TDelete(SocialMedia entity)
    {
        _socialMediaDal.Delete(entity);
    }

    public List<SocialMedia> TGetListAll()
    {
        return _socialMediaDal.GetListAll();
    }

    public SocialMedia TGetById(int id)
    {
        return _socialMediaDal.GetById(id);
    }
}