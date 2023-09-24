using System;
using Laborator11exercitii.Autovehicule.Interfete;

namespace Laborator11exercitii.Autovehicule
{
    class AutovehiculDiesel : Autovehicul, IDiesel
    {

        public AutovehiculDiesel(string name) : base(name)
        {
          
        }

        public void IncarcaDiesel(int litri)
        {
            Console.WriteLine($"Am alimentat {litri} diesel");
        }
    }


}
