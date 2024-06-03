using System.Text;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories;

public class CarRepository
{
    private readonly string _strConn = "Data Source=localhost; Initial Catalog=projAula2; User Id=sa; " +
                                       "Password=SqlServer2019!; TrustServerCertificate=Yes";

    private readonly SqlConnection _conn;

    public CarRepository()
    {
        _conn = new SqlConnection(_strConn);
        _conn.Open();
    }

    public bool InsertCar(Car car)
    {
        bool result = false;
        try
        {
            SqlCommand sqlCommand = new SqlCommand(Car.INSERT, _conn);

            sqlCommand.Parameters.Add(new SqlParameter("@Name", car.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@Color", car.Color));
            sqlCommand.Parameters.Add(new SqlParameter("@Year", car.Year));

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

    public bool UpdateCar(Car car)
    {
        bool result = false;
        try
        {

            SqlCommand sqlCommand = new SqlCommand(Car.UPDATE, _conn);

            sqlCommand.Parameters.Add(new SqlParameter("@Id", car.Id));
            sqlCommand.Parameters.Add(new SqlParameter("@Name", car.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@Color", car.Color));
            sqlCommand.Parameters.Add(new SqlParameter("@Year", car.Year));

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

    public bool DeleteCar(int cId)
    {
        bool result = false;
        try
        {
            SqlCommand sqlCommand = new SqlCommand(Car.DELETE, _conn);

            sqlCommand.Parameters.Add(new SqlParameter("@Id", cId));

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

    public Car FindCarById(int cId)
    {
        return GetCar(cId);
    }

    public List<Car> GetAllCars()
    {
        List<Car> allCars = new List<Car>();

        try
        {
            SqlCommand sqlCommand = new SqlCommand(Car.SELECT, _conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Car car = new();
                car.Id = sqlDataReader.GetInt32(0);
                car.Name = sqlDataReader.GetString(1);
                car.Color = sqlDataReader.GetString(2);
                car.Year = sqlDataReader.GetInt32(3);

                allCars.Add(car);
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

        return allCars;
    }

    public Car GetCar(int cId)
    {
        Car car = new();
        
        try
        {
            SqlCommand sqlCommand = new SqlCommand(Car.SELECT, _conn);
            sqlCommand.Parameters.Add(new SqlParameter("@Id", cId));
            
            
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            car.Id = sqlDataReader.GetInt32(0);
            car.Name = sqlDataReader.GetString(1);
            car.Color = sqlDataReader.GetString(2);
            car.Year = sqlDataReader.GetInt32(3);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            _conn.Close();
        }

        return car;
    }
}