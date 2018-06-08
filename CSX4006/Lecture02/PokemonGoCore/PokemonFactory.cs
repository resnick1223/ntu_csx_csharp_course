using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoCore
{
    public class PokemonFactory
    {
        public static Pokemon Create(int nationalNo)
        {
            switch (nationalNo)
            {
                case 1:
                    return new Bulbasaur();
                case 2:
                    return new Ivysaur();
                case 3:
                    return new Venusaur();
                default:
                    return new Bulbasaur();
            }
        }
    }
}
