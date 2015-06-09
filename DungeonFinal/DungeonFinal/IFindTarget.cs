using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public interface IFindTarget
    {
        Hero FindTarget(Party p);
    }
}
