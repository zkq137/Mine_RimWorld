using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace Touzi_MineRimWorld
{
    public class MineRimWorld : Verb
    {
        protected override bool TryCastShot()
        {
            // 这里可以实现木剑的攻击逻辑，暂时返回true表示攻击成功
            return true;
        }
    }
}
