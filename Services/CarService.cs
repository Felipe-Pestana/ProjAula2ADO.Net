using Models;
using Repositories;

namespace Services;

public class CarService
{
    private CarRepository _carRepository;
    
    public CarService()
    {
        _carRepository = new CarRepository();
    }
    
    public bool InsertCar(Car car)
    {
        Console.WriteLine("Camada Service");
        return _carRepository.InsertCar(car);
    }
    
    public bool UpdateCar(Car car)
    {
        Console.WriteLine("Camada Service");
        return _carRepository.UpdateCar(car);
    }
    
    public bool DeleteCar(Car car)
    {
        Console.WriteLine("Camada Service");
        return _carRepository.DeleteCar(new int());
    }
    
    public bool FindCar(Car car)
    {
        Console.WriteLine("Camada Service");
        return _carRepository.InsertCar(car);
    }
    
    public Car GetCar(Car car)
    {
        Console.WriteLine("Camada Service");
        return _carRepository.GetCar(new int());
    }
    
    public List<Car> GetAllCars()
    {
        Console.WriteLine("Camada Service");
        return _carRepository.GetAllCars();
    }
    
}