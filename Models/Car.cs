using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GregsList.Models
{
    public class Car
    {
        public string Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Year { get; set; }
        public Car(string name, int year)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Year = year;

        }
    }
}