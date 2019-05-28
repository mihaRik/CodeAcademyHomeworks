using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_November_2018_TeacherTask
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string _name, string _surname, int _age)
        {
            Name = _name;
            Surname = _surname;
            Age = _age;
        }

        public void Method(string _name)
        {
            Console.WriteLine("efefefef");
        }

        //public IEnumerator Current()
        //{
        //    position++;
        //    return (IEnumerator)this;
        //}

        //public IEnumerator GetEnumerator()
        //{

        //}

        //public bool MoveNext()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Reset()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
