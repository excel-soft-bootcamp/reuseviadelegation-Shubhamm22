using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSelectorProgram
{
   public class Camera : ICamera
    {
         public void Click() { Console.WriteLine("camera"); }
    }
}
