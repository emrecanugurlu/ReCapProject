using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {

            if (brand.Name.Length < 2)
            {
                Console.WriteLine("Marka ismi minimum 2 karakterden oluşmalıdır...");
            }
            else
            {
                _brandDal.Add(brand);
            }
        }
    }
}
