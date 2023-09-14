using PokeApiNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.CONTROLADOR
{
    public class Ctl_pokemon
    {

        PokeApiClient pokeapi;

        public Ctl_pokemon() {

            pokeapi = new PokeApiClient();

        }


        public async Task<Pokemon> get_pokemonAsync(string nombre)
        {

            return await pokeapi.GetResourceAsync<Pokemon>(nombre);

        }


        public async Task<Pokemon> get_pokemonAsync(int id)
        {

            return await pokeapi.GetResourceAsync<Pokemon>(id);

        }

    }
}
