using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattens.Observer_pattern
{
    public class User_observer : IStockObserver
    {
        private string _name;

        public User_observer(string name)
        {
            _name = name;
        }   

        public void Update(decimal price)
        {
            Console.WriteLine($"{_name}recived update ,price : {price} ");

        }
    }

    public interface IStockObserver
    {
        void Update(decimal price);
    }
}
