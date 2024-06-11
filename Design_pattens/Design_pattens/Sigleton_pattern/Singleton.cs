using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattens
{
    public class Singleton
    {
        private static Singleton _instance;
        private Singleton() {
        
        }
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
       public void DoSomething()
        {
            Console.WriteLine("Singleton instance is Work");
        }

    }
}
