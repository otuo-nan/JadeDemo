using JadeDemo.API.Models;

namespace JadeDemo.API.Data
{
    public static class Database
    {
        public static List<Car> Cars { get; set; } = new List<Car>() 
        { 
           new Car{ Brand = "BMW", Year = "2020"},
           new Car{Brand = "Vw", Year = "2021"},
           new Car{Brand = "Toyota", Year = "1990"},
           new Car{Brand = "Volvo", Year = "2012"},
           new Car{Brand = "Benz", Year = "2024"},
        };
    }
}
