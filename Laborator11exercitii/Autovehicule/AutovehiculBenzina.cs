using Laborator11exercitii.Autovehicule.Interfete;
using System;


namespace Laborator11exercitii.Autovehicule
{
    class AutovehiculBenzina : Autovehicul, IBenzina
    {

        public AutovehiculBenzina(string name): base(name)
        {

        }

        public void IncarcaBenzina(int litri)
        {
           Console.WriteLine($"Am alimentat {litri} benzina");
        }
    }


}
