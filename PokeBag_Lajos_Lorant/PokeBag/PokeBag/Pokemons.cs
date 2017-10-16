using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBag
{
    public class Pokemons
    {
        protected int strength;
        Random random = new Random();

        public Pokemons()
        {

        }

        public int GetStrenght()
        {
            strength = random.Next(0, 10);
            return strength;
        }
    }
}
