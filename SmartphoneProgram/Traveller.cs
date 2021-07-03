using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneProgram
{
    public class Traveller
    {
        public void Hike(Igpsdevice _gpsdevice)
        {
           
            _gpsdevice.Navigate();
        }
    }
}
