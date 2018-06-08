using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoCore
{
    public abstract class 飛行道具 : 加強裝備系統, 具有飛行能力的介面
    {
        public abstract void 飛行();
    }
}