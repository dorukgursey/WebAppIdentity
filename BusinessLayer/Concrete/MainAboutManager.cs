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
    public class MainAboutManager : IMainAboutService
    {
        IMainAboutDAL _mainAboutDAL;

        public MainAboutManager(IMainAboutDAL mainAboutDAL)
        {
            _mainAboutDAL = mainAboutDAL;
        }
        public void TAdd(MainAbout t)
        {
            _mainAboutDAL.Insert(t);
        }

        public void TDelete(MainAbout t)
        {
            _mainAboutDAL.Delete(t);
        }

        public MainAbout TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MainAbout> TGetList()
        {
            return _mainAboutDAL.GetList();
        }

        public void TUpdate(MainAbout t)
        {
            _mainAboutDAL.Update(t);
        }
    }
}
