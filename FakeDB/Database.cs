using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GregsList.Models;

namespace GregsList.FakeDB
{
    public static class Database
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car("ThanosCar", 3030),
            new Car("BeanCar", 2025),
            new Car("SpleenCar", 300)

        };
    }
}