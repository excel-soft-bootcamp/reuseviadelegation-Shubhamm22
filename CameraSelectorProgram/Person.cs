using System;
using System.Collections.Generic;
using System.Text;

namespace CameraSelectorProgram
{
    public class Person :Phone
    {
        public void Communicate()
        {
            Phone _phone = new Phone();
            _phone.Hangup();
            _phone.Release();
        }
    }
}
