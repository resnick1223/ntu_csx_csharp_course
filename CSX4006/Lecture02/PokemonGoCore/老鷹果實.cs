using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoCore
{
    public class 老鷹果實 : 動物系果實, 具有飛行能力的介面
    {
        public void 飛行()
        {
            Console.WriteLine("我用老鷹果實飛");
        }
    }
}