using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrate;

public class ContactManager : IContactService
{
    private readonly IContactDal _contactDal;
    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }
    public void TAdd(Contact entity)
    {
        _contactDal.Add(entity);
    }

    public void TUpdate(Contact entity)
    {
        _contactDal.Update(entity);
    }

    public void TDelete(Contact entity)
    {
        _contactDal.Delete(entity);
    }

    public List<Contact> TGetListAll()
    {
        return _contactDal.GetListAll();
    }

    public Contact TGetById(int id)
    {
        return _contactDal.GetById(id);
    }
}