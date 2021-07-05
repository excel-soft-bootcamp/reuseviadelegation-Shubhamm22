using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSelectorProgram
{
    public class Photographer
    {
        public void Capture(ICamera camera)
        {
            camera.Click();
        }
    } 
}


       
 
