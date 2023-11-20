using System;
using System.Reflection;

namespace csharp10tut
{
    internal class Reflection
    {

        static void Main()
        {
            //Type T = Type.GetType("csharp10tut.Student");
            Type T = typeof(Customer);
            Console.WriteLine(T.Name);
            PropertyInfo[] properties = T.GetProperties();
            MethodInfo[] methods = T.GetMethods();

            ConstructorInfo[] constructors = T.GetConstructors();

            Console.WriteLine("Constructors");
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.MethodHandle);
            }

            Console.WriteLine("Properties");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine("Methods");

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }

    class Student
    {
        private int _id;
        private string _name;


        public Student()
        {
            this._id = -1;
            this._name = string.Empty;
        }

        public Student(int Id,string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
      }

        public void PrintID()
        {
            Console.WriteLine("ID : {0}",this._id);
        }

        public void printName()
        {
            Console.WriteLine("NAME : {0}",this._name);
        }

    }
}
