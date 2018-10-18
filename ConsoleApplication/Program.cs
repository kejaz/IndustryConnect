using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ConsoleApplication
{
        class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Mapper.CreateMap<Customer, CustomerViewItem>()
                .ForMember(dest => dest.FN, opt => opt.MapFrom(src => src.FirstName));

            //Mapper.CreateMap<Customer, CustomerViewItem>();
            program.Run();
        }

        private void Run()
        {
            Customer customer = GetCustomerFromDB();

            CustomerViewItem customerViewItem =  Mapper.Map<Customer, CustomerViewItem>(customer);

            ShowCustomerInDataGrid(customerViewItem);
        }

        private void ShowCustomerInDataGrid(
                       CustomerViewItem customerViewItem)
        {
        }

        private Customer GetCustomerFromDB()
        {
            return new Customer()
            {
                DateOfBirth = new DateTime(1987, 11, 2),
                FirstName = "Andriy",
                LastName = "Buday",
                NumberOfOrders = 7
            };
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int NumberOfOrders { get; set; }
    }

    public class CustomerViewItem
    {
        public string FN { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int NumberOfOrders { get; set; }
    }
}
