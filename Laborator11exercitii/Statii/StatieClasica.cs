using Laborator11exercitii.Autovehicule.Interfete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator11exercitii.Statii
{
    partial class StatieClasica
    {
        public void AlimenteazaBenzina(IBenzina autovehiculBenzina, int cantitate)
        {
            Console.WriteLine($"Alimentam cu benzina autovehiculul {autovehiculBenzina} ");
            autovehiculBenzina.IncarcaBenzina(cantitate);
        }

        public void AlimenteazaDiesel(IDiesel autovehiculDiesel, int cantitate)
        {
            Console.WriteLine($"Alimentam cu diesel autovehiculul {autovehiculDiesel} ");
            autovehiculDiesel.IncarcaDiesel(cantitate);
        }

        public void AlimenteazaGPL(IGPL autovehiculGPL, int cantitate)
        {
            Console.WriteLine($"Alimentam cu GPL autovehiculul {autovehiculGPL} ");
            autovehiculGPL.IncarcaGPL(cantitate);
        }

    }
}
