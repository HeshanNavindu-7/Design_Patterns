using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattens
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Singleton Pattern Demonstration:");

            // Accessing the singleton instance
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            // Check if both references point to the same instance
            if (instance1 == instance2)
            {
                Console.WriteLine("Both references point to the same instance.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }

            // Call a method on the singleton instance
            instance1.DoSomething();
        }
    }
}
