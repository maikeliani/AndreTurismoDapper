﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;

namespace Services
{
    public  class CityService
    {
        private ICityRepository cityRepository;

        public CityService()
        {
            cityRepository = new CityRepository();
        }

        public bool Insert(City city)
        {
            return cityRepository.Insert(city);
        }

        public bool Delete(int id)
        {
            return cityRepository.Delete(id);
        }

        public List<City> GetAll()
        {
            return cityRepository.GetAll();
        }

        public bool Update(string newDescription, int id)
        {
            return cityRepository.Update(newDescription, id);
        }



    }
}
