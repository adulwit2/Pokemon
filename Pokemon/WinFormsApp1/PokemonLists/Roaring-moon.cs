using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PokemonLists
{
    internal class Roaring_moon : Pokemon1
    {
        public Roaring_moon()
        {
            Random random = new Random();
            this.name = "Roaring_moon";
            this.hp = random.Next(320,414);
            this.attack = random.Next(254,414);
            this.image = Properties.Resources.roaring_moon;

        }
    }
}
