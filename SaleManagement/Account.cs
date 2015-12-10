using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement
{
    public class Account
    {
        private readonly string username, lastName, firstName, address, phone;
        private readonly DateTime dateOfBirth;

        public string Username
        {
            get
            {
                return username;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
        }

        public Account(string username, string lastName, string firstName, string address, string phone, DateTime dateOfBirth)
        {
            this.username = username;
            this.lastName = lastName;
            this.firstName = firstName;
            this.address = address;
            this.phone = phone;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
