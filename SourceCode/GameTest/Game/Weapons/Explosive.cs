using GameTest.Game.GameElements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.Weapons
{
    class Explosive : Bullet
    {
        public Explosive(int damage, int life, int w, int h, int x, int y, int TargetX, int TargetY, Game g, Team Team, Brush Fill) : base(damage, life, w, h, x, y, TargetX, TargetY, g, Team, Fill)
        {
            SizeEffect = this.MakeItExplode;
            Stoppable = false;
        }

        private int MakeItExplode(int i)
        {
                if (this.lifeTime < 10 && this.lifeTime > 1)
                    return (int)(this.Width * 1.5);
                else
                    return this.Width;
        }

        public override void move()
        {
            base.move();
            /*
            if(this.lifeTime > 10)
            { 
                this.X += speedX;
                this.Y += speedY;
            }

            if (SizeEffect != null)
            {
                Width = SizeEffect(++SizeEffectCounter);
                Height = Width;
            }

            Rectangle self = new Rectangle(X, Y, Width, Height);
            lock (TheGame.GameElementListLock)
                for (int i = 0; i < TheGame.GameElements.Count; i++)
                {
                    var element = TheGame.GameElements[i];
                    if (!(element is Bullet) && element.Team != this.Team)
                        if (self.IntersectsWith(new Rectangle(element.X- element.Width/2, element.Y- element.Height/2, element.Width, element.Height)))
                        {
                            element.reactToHit(this);
                            if (Stoppable)
                                this.IsDead = true;
                        }
                }

            if (lifeTime-- < 0)
                IsDead = true;*/
        }

    }
}
