using System;
using Laborator11exercitii.Autovehicule.Interfete;

namespace Laborator11exercitii.Autovehicule
{
    class AutovehiculHibrid : AutovehiculBenzina, IElectric
    {

        public AutovehiculHibrid(string name) : base(name)
        {

        }

        public void IncarcaElectric(int kwh)
        {
            Console.WriteLine($"Am alimentat {kwh} pe h");
        }
    }


}
