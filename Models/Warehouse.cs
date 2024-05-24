using System.ComponentModel.DataAnnotations;
namespace task6.Models;
public class Warehouse
{
    public int IdWarehouse { get; set; }
    [Required] [MaxLength(200)] public string Name { get; set; }
    [Required] [MaxLength(200)] public string Address { get; set; }

    public Warehouse(int idWarehouse, string name, string address)
    {
        idWarehouse = idWarehouse;
        Name = name;
        Address = address;
    }
}