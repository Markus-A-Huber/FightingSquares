using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.GameElements.PlayerStates
{
    class MoveState : PlayerState
    {
        public Direction CurrentDirection { get; private set; }

        public MoveState(Player p, Direction Dir) : base(p)
        {
            this.CurrentDirection = Dir;
        }

        public MoveState(Player p) : base(p)
        {

        }
        public override PlayerState changeState(PlayerState newState)
        {
            if (newState is MoveState)
            {
                var s = (MoveState)newState;
                if (this.CurrentDirection.HasFlag(s.CurrentDirection))
                    return this;
                else
                {
                    return new MoveState(player,this.CurrentDirection | s.CurrentDirection);
                }
            }
            else
                return newState;
        }

        public override void move()
        {
            base.move();

            double dx = 0;
            double dy = 0;
            double d = 0;

            if (this.CurrentDirection.HasFlag(Direction.Right))
                dx = 1;
            if (this.CurrentDirection.HasFlag(Direction.Left))
                dx -= 1;
            if (this.CurrentDirection.HasFlag(Direction.Up))
                dy = -1;
            if (this.CurrentDirection.HasFlag(Direction.Down))
                dy += 1;

            d = Math.Sqrt(dx * dx + dy * dy);
            player.X += (int)(dx / d * player.speed);
            player.Y += (int)(dy / d * player.speed);
        }

        public override PlayerState removeState(PlayerState newState)
        {
            if (newState is MoveState)
            {
                var s = (MoveState)newState;
                if (this.CurrentDirection.HasFlag(s.CurrentDirection))
                {
                    var TempDir = this.CurrentDirection & ~s.CurrentDirection;
                    if (TempDir == Direction.Idle)
                    {
                        return new IdleState(player);
                    }
                    else
                    {
                        return new MoveState(player,TempDir);
                    }
                }
                else
                {
                    return this;
                }
            }
            else
                return this;
        }
    }
}
