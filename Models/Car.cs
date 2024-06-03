namespace Models;

public class Car
{
    public static readonly string INSERT = "INSERT INTO tb_car (name, color, year) VALUES(@Name, @Color, @Year)";
    public static readonly string SELECT = "SELECT id, name, color, year FROM tb_car WHERE id = @Id";
    public static readonly string UPDATE = "UPDATE tb_car SET name = @Name, color = @Color, year = @Year WHERE id = @Id";
    public static readonly string DELETE = "DELETE FROM tb_car WHERE id = @Id";
    public int Id { get; set; } = new int();
    public string Name { get; set; } = String.Empty;
    public string Color { get; set; } = String.Empty;
    public int Year { get; set; } = new int();

    public override string ToString()
    {
        return $"Id: {Id}\nNome: {Name}\nCor: {Color}\nAno: {Year}";
    }
}