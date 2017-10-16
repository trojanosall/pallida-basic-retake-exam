using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBag
{
    public class PokeBagClass
    {
        public static List<Pokemons> Pokemons;

        public PokeBagClass()
        {
            Pokemons = new List<Pokemons>();
        }

        public static void Add(Pokemons pokemon)
        {
            Pokemons.Add(pokemon);
        }
    }
}
