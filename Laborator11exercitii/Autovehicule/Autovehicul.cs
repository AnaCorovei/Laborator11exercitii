using Laborator11exercitii.Autovehicule.Interfete;
using Laborator11exercitii.Combustibili;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator11exercitii.Autovehicule
{
    abstract class Autovehicul
    {

        private readonly Guid id = Guid.NewGuid(); //instantiem tot timpul un Id nou
        protected Autovehicul(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public override string ToString()
        {
            return $"Autovehiculul {Name} id {id } ";
        }
    }
}
