using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PokemonLists
{
    internal class Chi_yu : Pokemon1
    {
        public Chi_yu()
        {
            Random random = new Random();
            this.name = "Chi_yu";
            this.hp = random.Next(220,314);
            this.attack = random.Next(148,284);
            this.image = Properties.Resources.chi_yu;

        }
    }
}
