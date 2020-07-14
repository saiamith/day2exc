using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlinesite
{
    class customer
    {
        int customerID;
        string name;
        string phonenumber;
        string address;
        string password;
        DateTime dob;
        string gender;

        internal void Register(int customerID, string name, string phonenumber, string address, string
            password, DateTime dob, string gender)
        {
            this.customerID = customerID;
            this.name = name;
            this.phonenumber = phonenumber;
            this.password = password;
            this.address = address;
            this.dob = dob;
            this.gender = gender;
        }
        internal void Display()
        {
            Console.WriteLine($"ID: {customerID} Name : {name} Phone number : {phonenumber} Address :{address} Date of Birth: {dob}");
        }
    }
}
