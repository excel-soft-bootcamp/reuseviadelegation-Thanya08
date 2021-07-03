using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Camera _cameradevice = new Camera();
            GPS _gpsdevice = new GPS();
            Phone _phonedevice = new Phone();

            SmartPhone _smartPhone = new SmartPhone();
            _smartPhone.SetCamera(_cameradevice);
            _smartPhone.SetPhone(_phonedevice);
            _smartPhone.SetGPS(_gpsdevice);

            Photographer _photoGrapher = new Photographer();
            _photoGrapher.Capture(_cameradevice);
            _photoGrapher.Capture(_smartPhone);

            Traveller _traveller = new Traveller();
            _traveller.Hike(_gpsdevice);
            _traveller.Hike(_smartPhone);

            Person _person = new Person();
            _person.Communicate(_phonedevice);
            _person.Communicate(_smartPhone);
        }
    }
}
