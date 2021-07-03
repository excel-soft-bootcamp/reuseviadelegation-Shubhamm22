using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSelectorProgram
{
    public class SmartPhone: ICamera,IGps,IPhone
    {
        ICamera _cameraref;
        IGps _gpsref;
        IPhone _phoneref;

        public void SetCamera(ICamera cameraref) { this._cameraref = cameraref; }
        public void SetGps(IGps gpsref) { this._gpsref = gpsref; }
        public void SetPhone(IPhone phoneref) { this._phoneref = phoneref; }
        
        public void Click() { this._cameraref.Click(); }
        public void Hangup() { this._phoneref.Hangup(); }
        public void Release() { this._phoneref.Release(); }
        public void Navigate() { this._gpsref.Navigate(); }
    }
}
