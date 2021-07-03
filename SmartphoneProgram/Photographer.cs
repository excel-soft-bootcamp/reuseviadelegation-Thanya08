using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneProgram
{
    public class Photographer
    {
        public void Capture(Icameradevice _cameradevice)
        {
            
            _cameradevice.TakePicture();
        }
    }
}

