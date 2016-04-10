using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.GameElements.PlayerStates
{
    class IdleState : PlayerState
    {
        public IdleState(Player p) : base(p)
        {
            player = p;
        }
        public override PlayerState changeState(PlayerState newState)
        {
            return newState;
        }

        public override PlayerState removeState(PlayerState newState)
        {
            return this;
        }
    }
}
