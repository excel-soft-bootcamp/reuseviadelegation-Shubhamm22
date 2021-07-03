using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSelectorProgram
{
   public class Traveller:Gps
    {
        public void Hike()
        {
            Gps _navigationDevice = new Gps();
            _navigationDevice.Navigate();
           
        }
    }
}
