using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public  class CityController
    {
        private CityService cityService;
        public CityController()
        {
            cityService = new CityService();
        }
        public bool Insert(City city)
        {
            return cityService.Insert(city);
        }

        public List<City> GetAll()
        {
            return cityService.GetAll();
        }

        public bool Delete(int id)
        {
            return cityService.Delete(id);
        }

        public bool Update(string newDescription, int id)
        {
            return cityService.Update(newDescription, id);
        }
    }
}
