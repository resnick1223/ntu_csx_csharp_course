using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonGoCore;
using System.Configuration;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager.AppSettings["PokemonName"];
            Pokemon 妙蛙種子 = new Bulbasaur();
            妙蛙種子.飛行();
            妙蛙種子.裝備(new 老鷹果實());
            妙蛙種子.飛行();
            妙蛙種子.脫下裝備();
            妙蛙種子.飛行();
        }
    }
}
