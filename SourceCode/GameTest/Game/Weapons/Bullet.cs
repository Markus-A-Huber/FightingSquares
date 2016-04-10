using GameTest.Game.GameElements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameTest.Game.Weapons
{
    public class Bullet : GameObject, ICanHaveWeapon
    {
        public int speed { get; set; }
        protected int speedX, speedY;
        protected int lifeTime = 50;
        Brush FillColor;
        protected Func<int, int> SizeEffect;
        public bool Stoppable { get; set; }
        protected int SizeEffectCounter;
        public int damage { get; private set; }
        private Weapon weaponCeption; //every Bullet can have a weapon to mix several Weapons together
        public Weapon CurrentWeapon
        {
            get
            {
                return weaponCeption;
            }
            set
            {
                weaponCeption = value;
            }
        }
        public Bullet(int x, int y, int TargetX, int TargetY, Game g, Team _Team, Brush FillColor) : base(x, y, 5, 5, g)
        {
            speed = 5;
            double dx = TargetX - this.X;
            double dy = TargetY - this.Y;
            double d = Math.Sqrt(dx * dx + dy * dy);
            speedX = (int)(dx / d * speed);
            speedY = (int)(dy / d * speed);
            this.Team = _Team;
            damage = 1;
            this.FillColor = FillColor;
            SizeEffect = null;
            SizeEffectCounter = 1;
            Stoppable = true;
            weaponCeption = null;
        }

        public Bullet(int damage, int life, int w, int h, int x, int y, int TargetX, int TargetY, Game g, Team Team, Brush Fill) : this(x, y, TargetX, TargetY, g, Team, Fill)
        {
            this.damage = damage;
            lifeTime = life;
            Width = w;
            Height = h;
        }
        public Bullet(Func<int,int> SizeEffect, int damage, int life, int w, int h, int x, int y, int TargetX, int TargetY, Game g, Team Team, Brush Fill) : this(damage, life, w, h, x, y, TargetX, TargetY, g, Team, Fill)
        {
            this.SizeEffect = SizeEffect;
        }

            
        public override void move()
        { 
            this.X += speedX;
            this.Y += speedY;

            if(SizeEffect != null)
            {
                Width = SizeEffect(SizeEffectCounter++);
                Height = Width;
            }

            double distance2Enemy = 100000000000000000;
            double dx, dy, d;
            int Enemyindex = -1;

            Rectangle self = new Rectangle(X-Width/2, Y-Height/2, Width, Height);

            lock (TheGame.GameElementListLock)
                for (int i = 0; i < TheGame.GameElements.Count; i++)
                {
                    var element = TheGame.GameElements[i];
                    //Weaponception - the bullet shots with its own weapon onto the neares enemy
                    if (!IsDead && element.Team != this.Team)
                    {
                        if (self.IntersectsWith(new Rectangle(element.X - element.Width / 2, element.Y - element.Height / 2, element.Width, element.Height)))
                        {
                            element.reactToHit(this);
                            if (Stoppable)
                            {
                                this.IsDead = true;
                                //break;
                            }
                        }
                        if (weaponCeption != null && element is Fighter)
                        {
                            dx = element.X - this.X;
                            dy = element.Y - this.Y;
                            d = Math.Sqrt(dx * dx + dy * dy);
                            if (d < distance2Enemy)
                            {
                                distance2Enemy = d;
                                Enemyindex = i;
                            }
                        }  
                    }
                }
            if (Enemyindex != -1)
            {
                var target = TheGame.GameElements[Enemyindex];
                shoot(target.X, target.Y);
            }

            if (lifeTime-- < 0)
                IsDead = true;
        }

        private void shoot(int x, int y)
        {
            if (weaponCeption != null)
                weaponCeption.Shoot(x, y);
        }

        public override void draw(Graphics g)
        {
            g.FillEllipse(FillColor, X-Width/2, Y-Height/2, Width, Height);
        }
    }
}
