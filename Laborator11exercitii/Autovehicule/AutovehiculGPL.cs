using Laborator11exercitii.Autovehicule.Interfete;
using System;


namespace Laborator11exercitii.Autovehicule
{
    class AutovehiculGPL : Autovehicul, IGPL
    {

        public AutovehiculGPL(string name) : base(name)
        {

        }

        public void IncarcaGPL(int litri)
        {
            Console.WriteLine($"Am alimentat {litri} GPL");
        }
    }


}
