using GrpcServiceLibrary.Models;
using GrpcServiceLibrary.Repositories;
using System;
using System.Threading.Tasks;

namespace TestNuGetPackage
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ICustomerRepository repository = new CustomerRepository();
            var customers = await repository.GetCustomersAsync();

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer ID: {customer.Id}, Name: {customer.Name}");
            }
        }
    }
}
