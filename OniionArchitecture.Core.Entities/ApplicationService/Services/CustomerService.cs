using OniionArchitecture.Core.Entities.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OniionArchitecture.Core.Entities.ApplicationService.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }
        public void CreateCustomer(Customer customer)
        {
            _customerRepository.CreateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
        }

        public Customer FindById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.getAllCustomersList().ToList();
        }


       public List<Customer> GetAllCustomers(string name)
        {
            var data = _customerRepository.getAllCustomersList();
            var querlist = data.Where(s => s.firstName.Equals(name));
            querlist.OrderBy(s => s.Id);

            return querlist.ToList();
        }

        public Customer newCustomer(string firstName, string lastName, string address)
        {
            Customer data = new Customer()
            {
                firstName = firstName,
                lastName = lastName,
                customerAddress = address
            };

            return data;
        }

        public Customer update(Customer UpdateCustomer)
        {
            var data = _customerRepository.GetById(UpdateCustomer.Id);
         
            Console.WriteLine("Enter Name");
            data.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            data.lastName = Console.ReadLine();

            Console.WriteLine("Enter Address of the Customer ");
            data.customerAddress = Console.ReadLine();

            return data;
        }
    }
}
