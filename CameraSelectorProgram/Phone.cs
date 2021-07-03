using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSelectorProgram
{
  public  class Phone:IPhone
    {
        public void Hangup() { Console.WriteLine("Hangup"); }
        public void Release() { Console.WriteLine("Release"); }
    }
}
