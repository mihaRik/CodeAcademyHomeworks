using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class TourAgent
    {
        public string TourAgentName { get; set; }
        public List<Customer> CustomersList = new List<Customer>();
        public string Email { get; set; }
        private string username;
        public string Username { get { return username; } }
        private string password;
        public string Password { get { return password; } }

        public TourAgent(string _tourAgentName, string _email, string _username, string _password)
        {
            TourAgentName = _tourAgentName;
            Email = _email;
            username = _username;
            password = _password;
            Admin.TourAgents.Add(this);
        }

        public void RegisterCustomer()
        {
            Console.Write("Customer name: ");
            string name = Console.ReadLine();
            Console.Write("Customer surname: ");
            string surname = Console.ReadLine();
            Console.Write("Customer phone number: ");
            string phoneNumber = Console.ReadLine();
            Customer newCustomer = new Customer(name, surname, phoneNumber, this);
            CustomersList.Add(newCustomer);
            ShowEmptyRooms.ShowEmptyRoom();
            ReserveRoom(newCustomer);
        }

        //public void MultipleRoomSelect(Customer _newCustomer)
        //{
        //    Console.Write("Please select how many rooms do you wanna reserve: ");
        //    string roomCount = Console.ReadLine();
        //    for (int i = 0; i < Convert.ToInt32(roomCount); i++)
        //    {
        //        ReserveRoom(_newCustomer);
        //    }
        //}

        public void ReserveRoom(Customer _newCustomer)
        {
            Console.Write("Please select a room: ");
            string selectedRoom = Console.ReadLine();
            if (int.TryParse(selectedRoom, out int tryParse) && tryParse > 0 && tryParse <= 10)
            {
                _newCustomer.SelectedRooms = Convert.ToInt32(selectedRoom) - 1;
                if (Admin.Rooms[_newCustomer.SelectedRooms] == null)
                {
                    Admin.Rooms[_newCustomer.SelectedRooms] = _newCustomer;
                }
                else
                {
                    Console.WriteLine("This room already reserved.");
                    ReserveRoom(_newCustomer);
                }
            }
            else
            {
                Console.WriteLine("The input data is incorrect!");
                ReserveRoom(_newCustomer);
            }
        }
    }
}
