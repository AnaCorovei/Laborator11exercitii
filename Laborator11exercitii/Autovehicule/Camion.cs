using Laborator11exercitii.Autovehicule.Interfete;
using Laborator11exercitii.Combustibili;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator11exercitii.Autovehicule
{
    class Camion : AutovehiculDiesel
    {
        public Camion(string nume) : base(nume)
        {
            Cisterna = new Cisterna();
        }

        public Cisterna Cisterna { get; private set; }
    }

    class Cisterna : IBenzina, IDiesel
    {
        private int stoc = 0;
        private Combustibil tipCombustibilStoc = Combustibil.Benzina;

        public override string ToString()
        {
            return $"Cisterna Combustibil {tipCombustibilStoc} cantitate {stoc}";
        }
        public void IncarcaBenzina(int litri)
        {
            IncarcaCombustibil(litri, Combustibil.Benzina);
        }

        public void IncarcaDiesel(int litri)
        {
            IncarcaCombustibil(litri, Combustibil.Diesel);
        }

        private void IncarcaCombustibil(int litri, Combustibil combustibilIncarcat)
        {
            if (this.tipCombustibilStoc != combustibilIncarcat && this.stoc != 0)
            {
                Console.WriteLine("Combustibil incompatibil");
            }
            else
            {
                this.stoc += litri;
                this.tipCombustibilStoc = combustibilIncarcat;
            }

        }

        public void AlimenteazaBenzina(IBenzina autovehiculBenzina, int cantitate)
        {

            if (PoateFiAlimentat(Combustibil.Benzina, cantitate))
            {
                Console.WriteLine($"Alimentam cu Benzina autovehiculul {autovehiculBenzina} ");
                autovehiculBenzina.IncarcaBenzina(cantitate);
                this.stoc -= cantitate;
            }
        }

        public void AlimenteazaDiesel(IDiesel autovehiculDiesel, int cantitate)
        {
            if (PoateFiAlimentat(Combustibil.Diesel, cantitate))
            {
                Console.WriteLine($"Alimentam cu Diesel autovehiculul {autovehiculDiesel} ");
                autovehiculDiesel.IncarcaDiesel(cantitate);
                this.stoc -= cantitate;
            }
        }

        private bool PoateFiAlimentat(Combustibil combustibilulDorit, int cantitateaDorita)
        {
            if (this.tipCombustibilStoc != combustibilulDorit)
            {
                Console.WriteLine("Cisterna nu are combustibilul dorit in stoc. nu putem alimenta");
                return false;
            }
            if (this.stoc < cantitateaDorita)
            {
                Console.WriteLine("Cisterna nu are destul combustibil in stoc");
                return false;
            }
            return true;

        }
    }


}
