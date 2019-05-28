using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _15_November_2018_TeacherTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Person rehim = new Person("Rahim", "Teymurov", 22);
            PropertyInfo[] properties = rehim.GetType().GetProperties();
            MethodInfo[] methods = rehim.GetType().GetMethods();
            foreach (MethodInfo method in methods)
            {
                ParameterInfo[] parameters = method.GetParameters();
                foreach (ParameterInfo parameter in parameters)
                {
                    Console.WriteLine($"Method name: {method.Name}\nThis methods' parametrs name: {parameter.Name}");
                    Console.WriteLine();
                }
            }
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name+": "+ property.GetValue(rehim));
            }
        }
    }
}
