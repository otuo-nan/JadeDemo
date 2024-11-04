using JadeDemo.API.Data;
using JadeDemo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace JadeDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCars()
        {
            var cars = Database.Cars;

            return Ok(cars);
        }

        [HttpGet("car")]
        public IActionResult GetCar(Guid id)
        {
            var car = Database.Cars.Where(c => c.Id == id).First();

            return Ok(car);
        }
        
        [HttpDelete]
        public IActionResult RemoveCar(Guid id)
        {
            Database.Cars.RemoveAll(c => c.Id == id);

            return Ok(Database.Cars);
        }


        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            var cars = Database.Cars;
            cars.Add(car);

            return Ok(cars);
        }

        [HttpPost("add-cars")]
        public IActionResult AddCars(Car car)
        {
            var cars = Database.Cars;
            cars.Add(car);

            return Ok(cars);
        }
    }
}
