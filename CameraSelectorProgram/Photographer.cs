using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSelectorProgram
{
    public class Photographer : ICamera,ISmartphone
    {
        ICamera _cameraref;
        ISmartphone _smartphoneref;
        public void Capture(ISmartphone smartphoneref) { this._smartphoneref = smartphoneref; }
        public void Click() { this._smartphoneref.Click(); }
        public void Navigate() { this._smartphoneref.Navigate(); }
        public void Hangup() { this._smartphoneref.Hangup(); }
        public void Release() { this._smartphoneref.Release(); }
        public void SetCapture(ICamera cameraref) { this._cameraref = cameraref; }
        void ICamera.Click() { this._cameraref.Click(); }
    }






       
 }
