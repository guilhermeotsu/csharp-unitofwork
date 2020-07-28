using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Data;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Controllers
{
  [ApiController]
  [Route("api/orders")]
  public class OrderController : ControllerBase
  {
    [HttpPost("")]
    public Order Post(
      [FromServices] ICustomerRepository customerRepository,
      [FromServices] IOrderRepository orderRepository,
      [FromServices] IUnitOfWork unitOfWork
    )
    {
      try
      {
        var customer = new Customer { Name = "Guilherme Otsu" };
        var order = new Order { Number = "12345", Customer = customer };

        customerRepository.Save(customer);
        orderRepository.Save(order);

        unitOfWork.Commit();

        return order;

      }
      catch
      {
        unitOfWork.Rollback();
        return null;
      }
    }
  }
}