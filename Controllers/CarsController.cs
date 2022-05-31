using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GregsList.Models;
using GregsList.Services;
using Microsoft.AspNetCore.Mvc;

namespace GregsList.Controllers
{
    [ApiController]

    [Route("api/[controller]")]

    public class CarsController : ControllerBase
    {
        private readonly CarsService _cs;

        public CarsController(CarsService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            try
            {
                List<Car> cars = _cs.Get();
                return Ok(cars);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Car> Get(string id)
        {
            try
            {
                Car car = _cs.Get(id);
                return Ok(car);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car CarData)
        {
            try
            {
                Car newCar = _cs.Create(CarData);
                return Ok(newCar);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}