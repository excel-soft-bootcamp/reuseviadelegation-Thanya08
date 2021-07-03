using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneProgram
{
    public class Person
    {
        public void Communicate(Iphonedevice _phonedevice)
        {
           
            _phonedevice.Hangup();
            _phonedevice.Release();
        }
    }
}
