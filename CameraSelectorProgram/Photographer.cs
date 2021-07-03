using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSelectorProgram
{
    public class Photographer : ICamera
    {
        ICamera _cameraref;
       
       
        void ICamera.Click() { this._cameraref.Click(); }
    }






       
 }
