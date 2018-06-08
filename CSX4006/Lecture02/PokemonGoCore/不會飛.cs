using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoCore
{
    public class 不會飛 : 飛行行為
    {
        public override void 飛行()
        {
            Console.WriteLine("我還不能飛喔");
        }
    }
}