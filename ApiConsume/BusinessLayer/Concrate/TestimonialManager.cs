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
    public class TestimonialManager : ITestimonialServices
    {
        private readonly ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }
        public void TDelete(Testimonialcs t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonialcs TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonialcs> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TInsert(Testimonialcs t)
        {
            _testimonialDal.Insert(t);
        }

        public void TUpdate(Testimonialcs t)
        {
            _testimonialDal.Update(t);
        }
    }
}
