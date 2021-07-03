using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneProgram
{
    public class SmartPhone:Icameradevice,Igpsdevice,Iphonedevice
    {
        Icameradevice _cameradevice;
        Igpsdevice _gpsdevice;
        Iphonedevice _phonedevice;

        public void SetCamera(Icameradevice _cameradevice)
        {
            this._cameradevice = _cameradevice;
        }
        public void SetGPS(Igpsdevice _gpsdevice)
        {
            this._gpsdevice = _gpsdevice;
        }
        public void SetPhone(Iphonedevice _phonedevice)
        {
            this._phonedevice = _phonedevice;
        }

        public void TakePicture()
        {
            this._cameradevice.TakePicture();
        }
        
        public void Hangup() 
        {
            this._phonedevice.Hangup();
        }
        public void Release()
        {
            this._phonedevice.Release();
        }
        public void Navigate() 
        {
            this._gpsdevice.Navigate();
        }
    }
}
