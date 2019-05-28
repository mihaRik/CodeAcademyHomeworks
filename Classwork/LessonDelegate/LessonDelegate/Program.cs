using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LessonDelegate
{
    public delegate void Task(string sms);
    class Program
    {
        static void Main(string[] args)
        {
            MessageSender sender = new MessageSender();
            MessageREceiver receiver = new MessageREceiver();
            Task task = new Task(receiver.SmsReceiver);
            string sms = Console.ReadLine();
            sender.SmsSender(task,sms);

        }

        static void Method(int a, int b)
        {
            if (a != b)
            {
                Console.WriteLine("a-nin deyeri deyisilib");
            }
            else
            {
                Console.WriteLine("zor");
            }
        }
    }
}
