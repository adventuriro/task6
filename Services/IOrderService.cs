using task6.Models;
namespace task6.Services;

public interface IOrderService
{ 
    
 public bool FindOrder(int idProduct, int amount, DateTime createdAt);
}