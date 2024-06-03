using Microsoft.Data.SqlClient;
using Models;

namespace Repositories;

public class InsuranceRepository
{
    private readonly string _strConn = "Data Source=localhost; Initial Catalog=projAula2; User Id=sa; " +
                                       "Password=SqlServer2019!; TrustServerCertificate=Yes";

    private readonly SqlConnection _conn;
    public InsuranceRepository()
    {
        _conn = new SqlConnection(_strConn);
        _conn.Open();
    }
    public bool InsertInsurance(Insurance insurance)
    {
        bool result = false;
        try
        {
            SqlCommand sqlCommand = new SqlCommand(Insurance.INSERT, _conn);

            sqlCommand.Parameters.Add(new SqlParameter("@Description", insurance.Description));

            sqlCommand.ExecuteNonQuery();
            result = !result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return result;
        }
        finally
        {
            _conn.Close();
        }

        return result;
    }

    public bool UpdateInsurance(Insurance insurance)
    {
        bool result = false;
        try
        {

            SqlCommand sqlCommand = new SqlCommand(Insurance.UPDATE, _conn);

            sqlCommand.Parameters.Add(new SqlParameter("@Id", insurance.Id));
            sqlCommand.Parameters.Add(new SqlParameter("@Description", insurance.Description));

            sqlCommand.ExecuteNonQuery();
            result = !result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return result;
        }
        finally
        {
            _conn.Close();
        }

        return result;
    }

    public bool DeleteInsurance(int iId)
    {
        bool result = false;
        try
        {
            SqlCommand sqlCommand = new SqlCommand(Insurance.DELETE, _conn);

            sqlCommand.Parameters.Add(new SqlParameter("@Id", iId));

            sqlCommand.ExecuteNonQuery();
            result = !result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return result;
        }
        finally
        {
            _conn.Close();
        }

        return result;
    }

    public Insurance FindInsuranceById(int iId)
    {
        return GetInsurance(iId);
    }

    public List<Insurance> GetAllInsurances()
    {
        List<Insurance> allInsurances = new List<Insurance>();

        try
        {
            SqlCommand sqlCommand = new SqlCommand(Insurance.SELECT, _conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Insurance insurance = new();
                insurance.Id = sqlDataReader.GetInt32(0);
                insurance.Description = sqlDataReader.GetString(1);
                
                allInsurances.Add(insurance);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            _conn.Close();
        }

        return allInsurances;
    }
    public Insurance GetInsurance(int iId)
    {
        Insurance insurance = new();
        
        try
        {
            SqlCommand sqlCommand = new SqlCommand(Insurance.SELECT, _conn);
            sqlCommand.Parameters.Add(new SqlParameter("@Id", iId));
            
            
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            insurance.Id = sqlDataReader.GetInt32(0);
            insurance.Description = sqlDataReader.GetString(1);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            _conn.Close();
        }

        return insurance;
    }
}