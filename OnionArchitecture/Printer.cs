using OniionArchitecture.Core.Entities;
using OniionArchitecture.Core.Entities.ApplicationService;
using OniionArchitecture.Core.Entities.DomainService;
using OnionArchitecture.Infrastructure.Static.Data.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture
{
   public class Printer :IPrinter
    {
        //private ICustomerRepository customerRepository;

        private ICustomerService customerService;
        public Printer(ICustomerService customerService)
        {
            //customerRepository = new CustomerRepository();

            this.customerService = customerService;
            // Initialize data
            InitData();

            // UI
          //  UI();
        }

        void InitData()
        {

            var cus1 = new Customer
            {
                firstName = "Tayyab",
                lastName = "Bhatti",
                customerAddress = "Pakitn"
            };

            customerService.CreateCustomer(cus1);

        }

        public void UI()
        {


            string[] meneItem =
            {
                "List fo all customers",
                "Add Customers",
                "Find by Id",
                "Edit Customer",
                "Delete Customer",
                "Exist"
            };
            var select = showMenu(meneItem);
            while (select != 5)
            {
                switch (select)
                {
                    case 1:
                        customerService.GetAllCustomers();
                        break;
                    case 2:
                        string first = AskQuestion("Enter your Name");
                        string last = AskQuestion("Enter your Last Name");
                        string address = AskQuestion("Enter your Address");
                        var data = new Customer
                        {
                            firstName = first,
                            lastName = last,
                            customerAddress = address
                        };
                       customerService.CreateCustomer(data);
                     //   SaveCustomre(cus);
                        break;
                    case 3:
                       
                        Console.WriteLine("Enter id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        customerService.FindById(id);
                        break;
                    case 4:

                        break;
                    default:
                        break;
                }
                select = showMenu(meneItem);
            }
            Console.WriteLine("Bye Bye");
            Console.ReadKey();
        }
        //void EditCUstomer()
        //{
        //    var id = PrintNFintCustomer();
        //    Customer data = FindCustomerById(id);
        //    Console.WriteLine("Enter Name");
        //    data.firstName = Console.ReadLine();

        //    Console.WriteLine("Enter Last Name");
        //    data.lastName = Console.ReadLine();

        //    Console.WriteLine("Enter Address of the Customer ");
        //    data.customerAddress = Console.ReadLine();

        //}


        //int PrintNFintCustomer()
        //{

        //    Console.WriteLine("Enter Id of the Customer ");
        //    int id = Convert.ToInt32(Console.ReadLine());

        //    return id;
        //}
        // Customer FindCustomerById(int id)
        //{

        //    return customerRepository.GetById(id);
        //}

        // void Delete()
        //{
        //    var id = PrintNFintCustomer();

        //    customerRepository.DeleteCustomer(id);
        //}

        string AskQuestion(string question)
        {
            string ans = string.Empty;
            Console.WriteLine(question);
            ans = Console.ReadLine();

            return ans;
        }

        // Customer CreateCUstomer(string firstName, string lastName,string address)
        //{
        //    Customer data = new Customer()
        //    {
        //        firstName = firstName,
        //        lastName = lastName,
        //        customerAddress = address
        //    };

        //    return data;

        //}
        //void SaveCustomre(Customer data)
        //{
        //    customerRepository.CreateCustomer(data);

        //}


        //void listCustomers()
        //{
        //    Console.WriteLine("list  of the Customers...");

        //    foreach (var item in customerRepository.getAllCustomersList())
        //    {
        //        Console.WriteLine($"Id {item.Id} - Name {item.firstName} -  Last Name  {item.lastName}" +
        //            $" - Address {item.customerAddress}");
        //    }

        //    Console.WriteLine("\n");
        //}


        int showMenu(string[] menuItems)
        {

            Console.WriteLine("Select the Option you want ?");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($" {(i + 1)}: {menuItems[i]}");
            }

            int selection;

            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 5)
            {
                Console.WriteLine("Please select Option between 1-5");
            }

            return selection;
        }

    }
}
