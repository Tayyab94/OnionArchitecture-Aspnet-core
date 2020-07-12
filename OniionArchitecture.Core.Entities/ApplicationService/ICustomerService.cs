using System;
using System.Collections.Generic;
using System.Text;

namespace OniionArchitecture.Core.Entities.ApplicationService
{
    public interface ICustomerService
    {
        Customer newCustomer(string firstName, string lastName, string address);

        void CreateCustomer(Customer customer);

        Customer FindById(int id);

        List<Customer> GetAllCustomers();
        List<Customer> GetAllCustomers(string name);

        Customer update(Customer UpdateCustomer);

        void DeleteCustomer(int id);
    }
}
