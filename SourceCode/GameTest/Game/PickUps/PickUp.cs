using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.PickUps
{
    public abstract class PickUp : GameObject
    {
        protected readonly Random Lucky = new Random();
        public PickUp(int x, int y, int w, int h, Game g) : base(x,y,w,h,g)
        {
        }

        public override void move()
        {
            Rectangle self = new Rectangle(X-Width/2, Y-Height/2, Width, Height);
            lock (TheGame.GameElementListLock)
                for (int i = 0; i < TheGame.GameElements.Count; i++)
                {
                    var element = TheGame.GameElements[i];
                    if (self.IntersectsWith(new Rectangle(element.X - element.Width / 2, element.Y - element.Height / 2, element.Width, element.Height)))
                    {
                        if (element is Fighter)
                        {
                            element.reactToPickUp(this);
                            IsDead = true;
                        }
                    }
                }
        }

        public abstract PickUp interactWithFighter(Fighter f);

        public virtual PickUp reactToNewPickup(PickUp p)
        {
            return p;
        }
        
    }
}
