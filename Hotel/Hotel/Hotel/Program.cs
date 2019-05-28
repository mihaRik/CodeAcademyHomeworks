using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            TourAgent tourAgent1 = new TourAgent("Next Travel", "next@travel.az", "nexttravel", "next123");
            TourAgent tourAgent2 = new TourAgent("Travel", "travel@gmail.com", "travel", "travel2018");
            TourAgent tourAgent3 = new TourAgent("Baku Travel", "baku@outlook.com", "baku", "baku123");
            SelectCommand();
        }
        public static void SelectCommand()
        {
            Console.WriteLine("***Welcome to hotel!***");
            Console.WriteLine("1-Admin");
            Console.WriteLine("2-Customer");
            Console.WriteLine("3-Tour Agent");
            Console.WriteLine("4-Exit");
            Console.Write("Select Command : ");
            string selectedCommand = Console.ReadLine();
            switch (selectedCommand)
            {
                case "1":
                    AdminCommand();
                    SelectCommand();
                    break;
                case "2":
                    Customer.SignUpCustomer();
                    CustomerCommand();
                    SelectCommand();
                    break;
                case "3":
                    TourAgentCommand();
                    SelectCommand();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Select correct command!");
                    SelectCommand();
                    break;
            }
        }

        static void CustomerCommand()
        {
            Console.WriteLine("a.Show tour agents' list");
            Console.WriteLine("b.Show empty rooms");
            Console.WriteLine("c.Exit");
            Console.Write("Select customers' commands: ");

            string selectedCommand = Console.ReadLine();

            switch (selectedCommand)
            {
                case "a":
                    Customer.ShowTourAgents();
                    CustomerCommand();
                    break;
                case "b":
                    ShowEmptyRooms.ShowEmptyRoom();
                    CustomerCommand();
                    break;
                case "c":
                    break;
                default:
                    Console.WriteLine("Select correct command!");
                    CustomerCommand();
                    break;
            }
        }

        static void AdminCommand()
        {
            Console.WriteLine();
            Console.Write("Please login into system:\nUsername: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (username == "admin" && password == "admin")
            {
                AdminLoggedIn();
            }
            else
            {
                Console.WriteLine("Username or password are incorrect!\nPlease try again.");
                AdminCommand();
            }
        }

        static void AdminLoggedIn()
        {
            Console.WriteLine();
            Console.WriteLine("a.Show empty rooms");
            Console.WriteLine("b.Show customers' information in rooms");
            Console.WriteLine("c.See information of tour agents");
            Console.WriteLine("d.Show information about customers' tour agent");
            Console.WriteLine("e.Show information about tour agents' customers in hotel");
            Console.WriteLine("f.Exit");

            Console.Write("Select admin's commands: ");
            string selectedCommand = Console.ReadLine();

            switch (selectedCommand)
            {
                case "a":
                    ShowEmptyRooms.ShowEmptyRoom();
                    AdminLoggedIn();
                    break;
                case "b":
                    Admin.ShowCustomerInfo();
                    AdminLoggedIn();
                    break;
                case "c":
                    Admin.ShowAgentInfo();
                    AdminLoggedIn();
                    break;
                case "d":
                    Admin.CustomerAgentInfo();
                    AdminLoggedIn();
                    break;
                case "e":
                    Admin.AgentCustomerList();
                    AdminLoggedIn();
                    break;
                case "f":
                    break;
                default:
                    Console.WriteLine("Select correct command!");
                    AdminLoggedIn();
                    break;
            }
        }

        static void TourAgentCommand()
        {
            bool loginFail = false;

            Console.Write("Please login into system:\nUsername: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            foreach (TourAgent tourAgent in Admin.TourAgents)
            {
                if (tourAgent.Username == username && tourAgent.Password == password)
                {
                    TourAgentLoggedIn(tourAgent);
                    loginFail = false;
                    break;
                }
                else
                {
                    loginFail = true;
                }
            }
            if (loginFail)
            {
                Console.WriteLine("Username or password are incorrect!\nPlease try again.");
                TourAgentCommand();
            }
        }

        static void TourAgentLoggedIn(TourAgent _tourAgent)
        {
            Console.WriteLine("a.Register a customer");
            Console.WriteLine("b.Show empty rooms");
            Console.WriteLine("c.Exit");
            Console.Write("Select command: ");
            string selectedCommand = Console.ReadLine();

            switch (selectedCommand)
            {
                case "a":
                    Console.WriteLine("***Customer registration***");
                    _tourAgent.RegisterCustomer();
                    TourAgentLoggedIn(_tourAgent);
                    break;
                case "b":
                    Console.WriteLine("***Empty rooms***");
                    ShowEmptyRooms.ShowEmptyRoom();
                    TourAgentLoggedIn(_tourAgent);
                    break;
                case "c":
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Select correct command!");
                    TourAgentLoggedIn(_tourAgent);
                    break;
            }
        }
    }
}
