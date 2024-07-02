using System.Collections.Generic;
using System.Threading.Tasks;
using GrpcServiceExample.Models;

namespace GrpcServiceExample.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
    }
}
