using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.GameElements.PlayerStates
{
    [Flags]
    enum Direction
    {
        Idle  =  0,
        Up    =  1,
        Down  =  2,
        Left  =  4,
        Right =  8
    }
}
