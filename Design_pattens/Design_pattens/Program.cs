using Design_pattens.Observer_pattern;
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
        {  //Singleton Design pattern


            //     Console.WriteLine("Singleton Pattern Demonstration:");

            //    // Accessing the singleton instance
            //    Singleton instance1 = Singleton.Instance;
            //    Singleton instance2 = Singleton.Instance;

            //    // Check if both references point to the same instance
            //    if (instance1 == instance2)
            //    {
            //        Console.WriteLine("Both references point to the same instance.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Different instances exist.");
            //    }

            //    // Call a method on the singleton instance
            //    instance1.DoSomething();

            // ##########################Adapter Structural Design pattern########################################################

            //Console.WriteLine("Adapter Structural Design Patterns");

            //Usplug_Adaptee usplug = new Usplug_Adaptee();

            //ISocket_Target adapter = new Plug_Adapter(usplug);

            //adapter.PlugIn();

            // ##########################observer Behabvioral Design pattern########################################################

            Console.WriteLine("Observer Behavioral Design Pattern");

            StockMarket_subject stockMarket = new StockMarket_subject();
            User_observer user = new User_observer("Alice");

            stockMarket.RegisterObserver(user);
            stockMarket.UpdateStockPrice(150);











        }
    }
}
