using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Pokemon1
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int attack { get; set; }
        public Bitmap image { get; set; }
        public string getName() { return name; }
        public int geHP() { return hp; }
        public int getAttack() { return attack; }
        public Bitmap getIamge() { return image; }
        public void  takeDamage(int damage)
        {
            this.hp= this.hp - damage;
        }
    }
}
