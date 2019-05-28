using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Admin
    {
        public static Customer[] Rooms = new Customer[10];
        public static List<TourAgent> TourAgents = new List<TourAgent>();
        public static List<Customer> Customers = new List<Customer>();

        public static void ShowCustomerInfo()
        {
            Console.WriteLine();
            Console.WriteLine("***Information about customers in rooms***");
            bool test = false;
            foreach (Customer customer in Admin.Rooms)
            {
                if (customer != null)
                {
                    test = true;
                    Console.WriteLine($"Customer in room number {customer.SelectedRooms + 1} fullname is {customer.Name} {customer.Surname} and phone number is {customer.PhoneNumber}");
                }
            }
            if (!test)
            {
                Console.WriteLine("There are no customers in rooms!");
            }

            Console.WriteLine();
        }

        public static void ShowAgentInfo()
        {
            Console.WriteLine();
            Console.WriteLine("***Agents information***");
            foreach (TourAgent tourAgent in TourAgents)
            {
                Console.WriteLine();
                Console.WriteLine($"Tour agent's name: {tourAgent.TourAgentName} and email: {tourAgent.Email}\nThis tour agent customer list:");
                bool test = false;
                foreach (Customer customer in tourAgent.CustomersList)
                {
                    Console.WriteLine($"{customer.Name} {customer.Surname}");
                    test = true;
                }
                if (!test)
                {
                    Console.WriteLine("This tour agent doesn't have a customer.");
                }
            }
            Console.WriteLine();
        }

        public static void CustomerAgentInfo()
        {
            Console.WriteLine();
            bool checkCustomer = false;
            foreach (Customer customer in Admin.Rooms)
            {
                if (customer != null)
                {
                    checkCustomer = true;
                    Console.WriteLine($"{customer.Name} {customer.Surname} reserved by {customer.SelectedTourAgent.TourAgentName} tour agent");
                }
            }
            if (!checkCustomer)
            {
                Console.WriteLine("There is no customers in hotel!");
            }
            Console.WriteLine();
        }

        public static void AgentCustomerList()
        {
            ShowAgentInfo();
            Console.Write("Please select tour agent(1,2,3): ");
            string selectedTourAgent = Console.ReadLine();
            switch (selectedTourAgent)
            {
                case "1":
                    AgentsCustomerList(Admin.TourAgents[0]);
                    break;
                case "2":
                    AgentsCustomerList(Admin.TourAgents[1]);
                    break;
                case "3":
                    AgentsCustomerList(Admin.TourAgents[2]);
                    break;
                default:
                    Console.WriteLine("Please select correct command!");
                    AgentCustomerList();
                    break;
            }
            void AgentsCustomerList(TourAgent _tourAgent)
            {
                bool customerExist = false;
                Console.WriteLine($"{_tourAgent.TourAgentName}'s customer list: ");
                foreach (Customer customer in _tourAgent.CustomersList)
                {
                    if (customer != null)
                    {
                        customerExist = true;
                        Console.WriteLine($"{customer.Name} {customer.Surname} in {customer.SelectedRooms} room.");
                    }
                }
                if (!customerExist)
                {
                    Console.WriteLine("This tour agent doesn't have a customer!");
                }
            }
        }
    }
}
