using System;
using System.Collections.Generic;

namespace Design_pattens.Observer_pattern
{
    public class StockMarket_subject
    {
        private List<IStockObserver> _observers;
        private decimal _price;

        public StockMarket_subject()
        {
            _observers = new List<IStockObserver>();
        }

        public void RegisterObserver(IStockObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IStockObserver observer)
        {
            _observers.Remove(observer);
        }

        public void UpdateStockPrice(decimal price)
        {
            _price = price;
            NotifyObservers(price);
        }

        private void NotifyObservers(decimal price)
        {
            foreach (var observer in _observers)
            {
                observer.Update(price);
            }
        }
    }
}
