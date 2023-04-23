using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interfaces;

public interface IAllCars
{
    IEnumerable<Car> Cars { set; get; }
    IEnumerable<Car> GetFavCars { set; get; }
    Car GetObjectCar(int carId);
}