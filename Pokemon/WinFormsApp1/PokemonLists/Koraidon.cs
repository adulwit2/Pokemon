using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PokemonLists
{
    internal class Koraidon : Pokemon1
    {
        public Koraidon()
        {
            Random random = new Random();
            this.name = "Koraidon";
            this.hp = random.Next(310,404);
            this.attack = random.Next(247,405);
            this.image = Properties.Resources.koraidon;

        }
    }
}
