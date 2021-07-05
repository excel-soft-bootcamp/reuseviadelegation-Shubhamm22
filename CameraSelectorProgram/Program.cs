using System;

namespace CameraSelectorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera _cameraref = new Camera();
            Gps _gpsref = new Gps();
            Phone _phoneref = new Phone();

            SmartPhone _smartphone = new SmartPhone();
            _smartphone.SetCamera(_cameraref);
            _smartphone.SetGps(_gpsref);
            _smartphone.SetPhone(_phoneref);

            Photographer _photoGrapher = new Photographer();
            _photoGrapher.Capture(_cameraref);
            _photoGrapher.Capture(_smartphone);

            Traveller _travellerref = new Traveller();
            _travellerref.Hike(_smartphone);

            Person _personref = new Person();
            _personref.Communicate(_smartphone);

        }
    }
}
