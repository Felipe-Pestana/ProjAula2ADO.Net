using Models;
using Services;

namespace Controllers;

public class CarController
{
    private CarService _carService;

    public CarController()
    {
        _carService = new CarService();
    }
    public bool InsertCar(Car car)
    {
        Console.WriteLine("Camada Controller");
        return _carService.InsertCar(car);
    }
    
    public bool UpdateCar(Car car)
    {
        Console.WriteLine("Camada Controller");
        return _carService.UpdateCar(car);
    }
    
    public bool DeleteCar(Car car)
    {
        Console.WriteLine("Camada Controller");
        return _carService.DeleteCar(car);
    }

    public List<Car> GetAllCars()
    {
        Console.WriteLine("Camada Controller");
        return new List<Car>();
    }
}