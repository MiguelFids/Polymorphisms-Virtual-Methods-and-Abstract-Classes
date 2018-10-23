using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphismVirtualMethodsAbstractClasses
{

    public enum MoveDirection { None, Left, Right, Up, Down };

    abstract class Player
    {
        public virtual MoveDirection MakeMove()
        {
            return MoveDirection.Left;
        }
    }
}
