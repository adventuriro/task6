using System.ComponentModel.DataAnnotations;

namespace task6.Models;

public class Order

{
    [Required]   public int IdOrder { get; set; }
    [Required]   public int IdProduct { get; set; }
    [Required]   public int Amount { get; set; }
    [Required]   public DateTime CreatedAt { get; set; }
    public DateTime? FulfilledAt { get; set; }
    
    
    public Order(int idOrder, int idProduct, int amount, DateTime createdAt, DateTime? fulfilledAt)
     
    {
        IdOrder = idOrder;
        IdProduct = idProduct;
        Amount = amount;
        CreatedAt = createdAt;
        FulfilledAt = fulfilledAt;
    }

    
}

