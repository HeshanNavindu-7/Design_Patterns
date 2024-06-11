using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattens
{
    public class Plug_Adapter : ISocket_Target
    {
        private readonly Usplug_Adaptee _usplug;

       

        public Plug_Adapter(Usplug_Adaptee usplug)
        {
            _usplug=usplug;
        }

        public void PlugIn()
        {
            _usplug.connect();
        }
    }

    public interface ISocket_Target
    {
        void PlugIn();
    }
}
