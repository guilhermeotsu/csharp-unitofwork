using RepositoryPattern.Data;
using RepositoryPattern.Models;

namespace RepositoryPattern.Repositories
{
  public interface ICustomerRepository
  {
    void Save(Customer customer);
  }

  public class CustomerRepository : ICustomerRepository
  {
    // Gerando dependencia da classe de Contexto para transacionar informaçoes
    private readonly DataContext _context;
    public CustomerRepository(DataContext context)
    {
      _context = context;
    }
    public void Save(Customer customer)
    {
      _context.Customer.Add(customer);
    }
  }
}