using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TDelete(AboutUs t)
        {
            _aboutDal.Delete(t);
        }

        public AboutUs TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public List<AboutUs> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TInsert(AboutUs t)
        {
            _aboutDal.Insert(t);
        }

        public void TUpdate(AboutUs t)
        {
            _aboutDal.Update(t);
        }
    }
}
    

