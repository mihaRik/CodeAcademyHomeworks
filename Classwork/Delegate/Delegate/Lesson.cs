using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public interface IP108<T>{
        T Method();
    }
    class Lesson 
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime Birthday { get; set; }

    }

  

    class XLesson:Lesson
    {
      
    }

    class Student<T> where T :Lesson
    {
        public int Id { get; set; }
        public T Person { get; set; }
    }
}
