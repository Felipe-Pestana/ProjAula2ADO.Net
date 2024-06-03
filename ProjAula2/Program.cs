// See https://aka.ms/new-console-template for more information

using Controllers;
using Models;

Console.WriteLine("Hello, Carros!");

Car car = new Car
{
    Id = 1,
    Name = "Carro Legal",
    Color = "Azul",
    Year = 2024
};

Car car2 = new Car
{
    Id = 2,
    Name = "Carro Sumpimpa",
    Color = "Vermelho",
    Year = 2022
};

Car car3 = new Car
{
    Id = 3,
    Name = "Carro Jóia",
    Color = "Verde",
    Year = 1954
};

//Console.WriteLine(car);

// if (new CarController().InsertCar(car))
//     Console.WriteLine("Registro Inserido!");

// Console.WriteLine(new CarController().InsertCar(car) ? "Registro Inserido!" : "Erro ao Inserir Registro!");
// Console.WriteLine(new CarController().InsertCar(car2) ? "Registro Inserido!" : "Erro ao Inserir Registro!");
// Console.WriteLine(new CarController().InsertCar(car3) ? "Registro Inserido!" : "Erro ao Inserir Registro!");

Console.WriteLine(new CarController().UpdateCar(car) ? "Registro Atualizado!" : "Erro ao Atualizar Registro!");
Console.WriteLine(new CarController().DeleteCar(car2) ? "Registro Excluído!" : "Erro ao Excluir Registro!");
