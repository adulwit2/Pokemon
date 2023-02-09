using System.Security.Cryptography;
using WinFormsApp1.PokemonLists;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Pokemon1> pokemon1s = new List<Pokemon1>();
        Pokemon1 selectPokemon;
        Pokemon1 selectBoos;
        int pkm;
        int heart = 4;
        public Form1()
        {
            InitializeComponent();
            pokemon1s.Add(new Miraidon());
            pokemon1s.Add(new Koraidon());
            pokemon1s.Add(new Roaring_moon());
            pokemon1s.Add(new Chi_yu());
            selectBoos = new Iron_valiant();
            this.pictureBox2.Image = selectBoos.getIamge();
            this.label10.Text = selectBoos.getName();
            this.label11.Text = selectBoos.geHP().ToString();
            this.label12.Text = selectBoos.getAttack().ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectPokemon = pokemon1s[0];
            this.pictureBox1.Image = selectPokemon.getIamge();
            this.label4.Text = selectPokemon.getName();
            this.label5.Text = selectPokemon.geHP().ToString();
            this.label6.Text = selectPokemon.getAttack().ToString();
            this.pkm = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectPokemon = pokemon1s[1];
            this.pictureBox1.Image = selectPokemon.getIamge();
            this.label4.Text = selectPokemon.getName();
            this.label5.Text = selectPokemon.geHP().ToString();
            this.label6.Text = selectPokemon.getAttack().ToString();
            this.pkm = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectPokemon = pokemon1s[2];
            this.pictureBox1.Image = selectPokemon.getIamge();
            this.label4.Text = selectPokemon.getName();
            this.label5.Text = selectPokemon.geHP().ToString();
            this.label6.Text = selectPokemon.getAttack().ToString();
            this.pkm = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectPokemon = pokemon1s[3];
            this.pictureBox1.Image = selectPokemon.getIamge();
            this.label4.Text = selectPokemon.getName();
            this.label5.Text = selectPokemon.geHP().ToString();
            this.label6.Text = selectPokemon.getAttack().ToString();
            this.pkm = 4;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            selectBoos.takeDamage(selectPokemon.getAttack());
            this.label11.Text = selectBoos.geHP().ToString();
            await Task.Delay(1500);
            selectPokemon.takeDamage(selectBoos.getAttack());
            if (selectPokemon.geHP() >= 0)
            {
                if (pkm == 1)
                {
                    this.button1.Hide();
                }
                if (pkm == 2) 
                {
                    this.button2.Hide();
                }
                if (pkm == 3)
                {
                    this.button3.Hide();
                }
                if (pkm == 4)
                {
                    this.button4.Hide();
                }
                this.pictureBox1.Image = null;
                this.label4.Text= null;
                this.label5.Text = null;
                this.label6.Text = null;
                this.heart -= 1;
                if (heart == 0)
                {
                    MessageBox.Show("K.O.");
                }
                return;

            }
            if (selectBoos.geHP()<=0)
            {
                MessageBox.Show("You Win");
            }
            this.label4.Text= selectPokemon.geHP().ToString();
        }
    }
}