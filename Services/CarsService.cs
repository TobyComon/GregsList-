using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GregsList.FakeDB;
using GregsList.Models;

namespace GregsList.Services
{
    public class CarsService
    {
        internal List<Car> Get()
        {
            return Database.Cars;
        }

        internal Car Get(string id)
        {
            Car car = Database.Cars.Find(c => c.Id == id);
            if (car == null)
            {
                throw new Exception("Invalid Car ID");
            }
            return car;
        }

        internal Car Create(Car carData)
        {
            Database.Cars.Add(carData);
            return carData;
        }

    }
}