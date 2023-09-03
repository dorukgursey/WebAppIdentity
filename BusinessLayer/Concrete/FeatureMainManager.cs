using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureMainManager:IFeatureMainService
    {
        IFeatureMainDAL _featureMainDal;

        public FeatureMainManager(IFeatureMainDAL featureMainDAL)
        {
            _featureMainDal = featureMainDAL;
        }

        public void TAdd(FeatureMain t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(FeatureMain t)
        {
            throw new NotImplementedException();
        }

        public FeatureMain TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<FeatureMain> TGetList()
        {
            return _featureMainDal.GetList();
        }

        public void TUpdate(FeatureMain t)
        {
            throw new NotImplementedException();
        }
    }
}
