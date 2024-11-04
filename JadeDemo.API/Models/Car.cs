namespace JadeDemo.API.Models
{
#nullable disable
    public class Car
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Brand { get; set; }
        public string Year { get; set; }

        public void AddCar(Car car)
        {

        }
    }
}
