using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoCore
{
    public abstract class Pokemon : IComparable<Pokemon>
    {
        public int hp;
        public int cp;
        public int nationalNo;
        public string name;
        public static string sortableKey;
        public 具有飛行能力的介面 可以飛的道具;

        int IComparable<Pokemon>.CompareTo(Pokemon other)
        {
            switch (sortableKey)
            {
                case "HP":
                    return Compare(this.hp, other.hp);
                case "CP":
                    return Compare(this.cp, other.cp);
                case "NO":
                    return Compare(this.nationalNo, other.nationalNo);
                default:
                    return Compare(this.hp, other.hp);
            }
        }


        protected int Compare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        public void 裝備(具有飛行能力的介面 某種可飛的裝備)
        {
            可以飛的道具 = 某種可飛的裝備;
        }

        public void 脫下裝備()
        {
            可以飛的道具 = null;
        }

        public void 飛行()
        {
            if (可以飛的道具 == null)
                可以飛的道具 = new 不會飛();
            可以飛的道具.飛行();
        }

        public override string ToString()
        {
            return string.Format("寶可夢編號:{0}, HP:{1} ",this.name, this.hp);
        }
    }
    
}
