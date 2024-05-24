using task6.Models;
namespace task6.Services;

public interface IWarehouseService<Warehouse>
{
    public void AddProduct(ProductWarehouse productWarehouse);
        
    public List<Warehouse> ReadWarehouses();
}