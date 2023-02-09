using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PokemonLists
{
    internal class Miraidon :Pokemon1
    {
        public Miraidon() 
        { 
            Random random= new Random();
            this.name = "Miraidon";
            this.hp = random.Next(310,404);
            this.attack= random.Next(157,295);
            this.image = Properties.Resources.miraidon;

        }
    }
}
