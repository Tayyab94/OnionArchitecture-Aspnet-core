using OniionArchitecture.Core.Entities;
using OniionArchitecture.Core.Entities.DomainService;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Infrastructure.Static.Data.Repository.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        static int i = 1;

        private List<Customer> _customers = new List<Customer>();
        public void CreateCustomer(Customer customer)
        {
            customer.Id = i++;

            _customers.Add(customer);
        }

        public void DeleteCustomer(int id)
        {
            var data = this.GetById(id);
            if(data!=null)
            {
                _customers.Remove(data);
            }
        }

        public IEnumerable<Customer> getAllCustomersList()
        {
            return _customers;
        }

        public Customer GetById(int id)
        {
            foreach (var item in _customers)
            {
                if(item.Id==id)
                {
                    return item;
                }
            }

            return null;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var model = this.GetById(customer.Id);
            if(model!=null)
            {
                model.firstName = customer.firstName;
                model.lastName = customer.lastName;
                model.customerAddress = customer.customerAddress;
            }

            return model;
        }
    }
}
