using PokeApiNet;
using pokemon.OBJETO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.CONTROLADOR
{
    public class Ctl_pokemon
    {

        private PokeApiClient pokeapi;
        private int total;
        private Random random;

        public Ctl_pokemon() {

            pokeapi = new PokeApiClient();
            total = 1008;
            random = new Random();
        }


        public async Task<Pokemon> get_pokemon(int id)
        {

            return await pokeapi.GetResourceAsync<Pokemon>(id);

        }

        public async Task<Pokemon[]> get_ale_pokemon()
        {

            int[] ids = Numeros_aleatorios();

            Pokemon[] pk = new Pokemon[ids.Length];

            for (int i = 0; i < ids.Length; i++)
            {
                pk[i] = await get_pokemon(ids[i]);
            }

            return pk;

        }


        public int[] Numeros_aleatorios()
        {
            
            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                int aleatorio = random.Next(1, total);

                while (numeros.Contains(aleatorio))
                {

                    aleatorio = random.Next(1, total);

                }

                numeros[i] = aleatorio;

            }

            return numeros;

        }


    }
}
