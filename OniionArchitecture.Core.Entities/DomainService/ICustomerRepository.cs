using System;
using System.Collections.Generic;
using System.Text;

namespace OniionArchitecture.Core.Entities.DomainService
{
    public interface ICustomerRepository
    {
        //Create
        void CreateCustomer(Customer customer);
        // Read

        Customer GetById(int id);
        // Read List

        IEnumerable<Customer> getAllCustomersList();

        // Update

        Customer UpdateCustomer(Customer customer);

        // Delete

        void DeleteCustomer(int id);

    }
}
