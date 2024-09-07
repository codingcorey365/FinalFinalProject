using FinalFinalProject.Models;

namespace FinalFinalProject.Interfaces;

public interface IProductRepository
{
    // CRUD PRODUCTS
    public IEnumerable<Product> GetAllProducts();
    public Product GetProduct(int id);
    void UpdateProduct(Product product);
    public void InsertProduct(Product productToInsert);
    public void DeleteProduct(Product product);

    // CRUD Categories
    public IEnumerable<Category> GetCategories();
    public Product AssignCategory();
}