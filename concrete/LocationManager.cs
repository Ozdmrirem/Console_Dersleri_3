﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class LocationManager : ILocationService
    {
        ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void TDelete(Location t)
        {
            _locationDal.Delete(t);
        }

        public Location TGetById(int id)
        {
            return _locationDal.GetByID(id);
        }

        public List<Location> TGetList()
        {
            return _locationDal.GetList();
        }

        public void TInsert(Location t)
        {
            _locationDal.Insert(t);
        }

        public void TUpdate(Location t)
        {
            _locationDal.Update(t);
        }
    }
}
