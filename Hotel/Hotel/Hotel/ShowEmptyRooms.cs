using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    abstract class ShowEmptyRooms
    {
        public static void ShowEmptyRoom()
        {
            Console.WriteLine();
            Console.WriteLine("These rooms are empty: ");
            for (int i = 0; i < Admin.Rooms.Length; i++)
            {
                if (Admin.Rooms[i] == null)
                {
                    Console.Write($"{i + 1} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
