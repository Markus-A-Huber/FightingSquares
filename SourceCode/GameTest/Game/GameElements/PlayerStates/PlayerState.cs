using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.GameElements.PlayerStates
{
    public abstract class PlayerState
    {
        protected Player player;
        public PlayerState(Player p)
        {
            player = p;
        }
       
        public virtual void move()
        {
            if (player.CurrentPickup != null)
            {
                //change "State" of the Pickup, to implement single use, cooldown and so on
                player.CurrentPickup = player.CurrentPickup.interactWithFighter(player);
            }
            if (player.IsFiring)
                player.shoot(player.mouseX, player.mouseY);
        }
        public abstract PlayerState changeState(PlayerState newState);

        public abstract PlayerState removeState(PlayerState newState);
    }
}
