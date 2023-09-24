using Laborator11exercitii.Autovehicule.Interfete;
using System;

namespace Laborator11exercitii.Statii
{
    partial class StatieHibrida: StatieClasica
    {
        public void AlimenteazaElectric(IElectric autovehiculElectric, int cantitate)
        {
            Console.WriteLine($"Alimentam cu benzina autovehiculul {autovehiculElectric} ");
            autovehiculElectric.IncarcaElectric(cantitate);
        }



    }
}
