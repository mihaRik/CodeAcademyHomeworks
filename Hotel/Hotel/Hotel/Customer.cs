using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public TourAgent SelectedTourAgent { get; set; }
        public int SelectedRooms { get; set; }

        public Customer(string _name, string _surname, string _phoneNumber, TourAgent _selectedTourAgent)
        {
            Name = _name;
            Surname = _surname;
            PhoneNumber = _phoneNumber;
            SelectedTourAgent = _selectedTourAgent;
            Admin.Customers.Add(this);
        }
        
        public static void ShowTourAgents()
        {
            Console.WriteLine("***Tour agents list***");
            foreach (TourAgent tourAgent in Admin.TourAgents)
            {
                Console.WriteLine(tourAgent.TourAgentName);
            }
        }

        public static void SignUpCustomer()
        {
            Console.WriteLine("Please sign up!");
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.Write("Your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Your phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Please select tour agent: ");
            ShowTourAgents();
            //Customer newCustomer = new Customer(name, surname, phoneNumber);
        }
    }
}
