using Models;
using Repositories;

namespace Services;

public class InsuranceService
{
    private InsuranceRepository _insuranceRepository;
    
    public InsuranceService()
    {
        _insuranceRepository = new InsuranceRepository();
    }
    
    public bool InsertInsurance(Insurance insurance)
    {
        Console.WriteLine("Camada Service");
        return _insuranceRepository.InsertInsurance(insurance);
    }
    
    public bool UpdateInsurance(Insurance insurance)
    {
        Console.WriteLine("Camada Service");
        return _insuranceRepository.UpdateInsurance(insurance);
    }
    
    public bool DeleteInsurance(Insurance insurance)
    {
        Console.WriteLine("Camada Service");
        return _insuranceRepository.DeleteInsurance(new int());
    }
    
    public bool FindInsurance(Insurance insurance)
    {
        Console.WriteLine("Camada Service");
        return _insuranceRepository.InsertInsurance(insurance);
    }
    
    public Insurance GetInsurance(Insurance insurance)
    {
        Console.WriteLine("Camada Service");
        return _insuranceRepository.GetInsurance(new int());
    }
    
    public List<Insurance> GetAllInsurance()
    {
        Console.WriteLine("Camada Service");
        return _insuranceRepository.GetAllInsurances();
    }
}