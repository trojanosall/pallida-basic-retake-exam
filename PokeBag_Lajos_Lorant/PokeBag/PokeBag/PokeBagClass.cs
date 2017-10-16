using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBag
{
    public class PokeBagClass
    {
        Random random = new Random();
        public static Pikachu Pikachu = new Pikachu();
        public static Bulbasaur Bulbasaur = new Bulbasaur();
        public static Charmander Charmander = new Charmander();
        public static List<Pokemons> pokemons;

        public PokeBagClass()
        {
            pokemons = new List<Pokemons>();
        }

        public static void Add(Pokemons pokemon)
        {
            pokemons.Add(pokemon);
        }

        public static void Speak(Pokemons pokemon)
        {
            if (pokemon == Pikachu)
            {
                Console.WriteLine("Pika-pika");
            }
            else if (pokemon == Bulbasaur)
            {
                Console.WriteLine("Bulba-saur");
            }
            else
            {
                Console.WriteLine("Char-char");
            }
        }

        public static void GetStrongest()
        {


        }


    }
}
