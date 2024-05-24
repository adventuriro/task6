using task6.Models;
namespace task6.Services;


public interface IproductService
{
    public List<Product> ReadProducts();

    public HashSet<int> ReadIds();
}

