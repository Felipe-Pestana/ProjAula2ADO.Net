namespace Models;

public class Insurance
{
    public static readonly string INSERT = "INSERT INTO tb_insurance (description) VALUES(@Description)";
    public static readonly string SELECT = "SELECT id, Description FROM tb_insurance WHERE id = @Id";
    public static readonly string UPDATE = "UPDATE tb_insurance SET Description = @Description WHERE id = @Id";
    public static readonly string DELETE = "DELETE FROM tb_insurance WHERE id = @Id";

    public int Id { get; set; }
    
    public string Description { get; set; }
}