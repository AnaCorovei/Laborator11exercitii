using System;
using Laborator11exercitii.Autovehicule.Interfete;

namespace Laborator11exercitii.Autovehicule
{
    class AutovehiculElectric : Autovehicul, IElectric
    {

        public AutovehiculElectric(string name) : base(name)
        {

        }

        public void IncarcaElectric(int kwh)
        {
            Console.WriteLine($"Am alimentat {kwh} pe h");
        }
    }


}
