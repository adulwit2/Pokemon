using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PokemonLists
{
    internal class Iron_valiant : Pokemon1
    {
        public Iron_valiant()
        {
            Random random = new Random();
            this.name = "Iron_valiant";
            this.hp = random.Next(258,352);
            this.attack = random.Next(238,394);
            this.image = Properties.Resources.iron_valiant;

        }
    }
}
