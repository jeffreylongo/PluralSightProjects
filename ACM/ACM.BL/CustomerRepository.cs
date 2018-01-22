using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        public bool Save()
        {
            //code that saves the defined customer
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            //code that retrieves the defined customer

            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            //code that retrieves a list of customers  
            return new List<Customer>();
        }
    }
}
