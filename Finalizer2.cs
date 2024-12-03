using System;

namespace oopsProject1
{
    internal class Finalizer2
    {
        string name;

       
        public Finalizer2()
        {
            name = "Default Name"; 
            Console.WriteLine("Constructor called, Name: " + name);
        }

       
        ~Finalizer2()
        {
            Console.WriteLine("Destructor called");
        }

        static void Main(string[] args)
        {
            Finalizer2 obj = new Finalizer2();
            obj.name = "Ed Sheeran";
            Console.WriteLine("Updated Name: " + obj.name);

           
            Console.ReadLine();
        }
    }
}
