using Services;
using Models;

namespace Controllers;

public class InsuranceController
{
    private InsuranceService _insuranceService;

    public InsuranceController()
    {
        _insuranceService = new InsuranceService();
    }
    public bool InsertInsurance(Insurance insurance)
    {
        Console.WriteLine("Camada Controller");
        return _insuranceService.InsertInsurance(insurance);
    }
    
    public bool UpdateInsurance(Insurance insurance)
    {
        Console.WriteLine("Camada Controller");
        return _insuranceService.UpdateInsurance(insurance);
    }
    
    public bool DeleteInsurance(Insurance insurance)
    {
        Console.WriteLine("Camada Controller");
        return _insuranceService.DeleteInsurance(insurance);
    }

    public List<Insurance> GetAllInsurance()
    {
        Console.WriteLine("Camada Controller");
        return new List<Insurance>();
    }
}