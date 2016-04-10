using GameTest.Game.GameElements;
using GameTest.Game.PickUps;
using GameTest.Game.Weapons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game
{
    public class Fighter : GameObject, ICanHaveWeapon
    {

        private int hp;
        public bool Shielded
        {
            get;
            set;
        } 
        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                if (value > hp)
                    hp = value;
                else 
                    if (!Shielded)
                        hp = value;
            }
        }
       
        public int Randomness { get; private set; }
        Random Lucky;
        public int speed { get; set; }
        public PickUp CurrentPickup { get; set; }

        public Weapon CurrentWeapon { get; set; }

        public Fighter(int x, int y, Team TeamNumber, Game g) : base(x,y,20,20,g)
        {
            HP = 100;
            Team = TeamNumber;
            CurrentWeapon = new Pistol(TheGame, this);
            Lucky = new Random();
            Randomness = 10;
            speed = 2;
            Shielded = false;
            CurrentPickup = null;
        }

        public override void move()
        {
            if(CurrentPickup != null)
            {
                //change "State" of the Pickup, to implement single use, cooldown and so on
                CurrentPickup = CurrentPickup.interactWithFighter(this);
            }

            GameObject target = null;
            GameObject targetPickup = null;
            double distance2Enemy = 10000000000;
            double dx = 0;
            double dy = 0;
            double d =1;
            int Enemyindex = -1;
            double distance2PickUp = 1000000000000;
            int PickupIndex = -1;
            double dPickup = 1;
            double dxPickup = 0;
            double dyPickup = 0;
            GameObject element;
            lock(TheGame.GameElementListLock)
                for (int i = 0; i < TheGame.GameElements.Count; i++)
                {
                    element = TheGame.GameElements[i];
                    if (element is Fighter)
                    {
                        if (((Fighter)element).Team == this.Team)
                            continue;

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
            lock(TheGame.PickupListLock)
                for(int i = 0; i<TheGame.PickupElements.Count;i++)
                {
                    element = TheGame.PickupElements[i];
                    if (element is PickUp)
                    {
                        dxPickup = element.X - this.X;
                        dyPickup = element.Y - this.Y;
                        dPickup = Math.Sqrt(dx * dx + dy * dy);
                        if (dPickup < distance2PickUp)
                        {
                            distance2PickUp = dPickup;
                            PickupIndex = i;
                        }
                    }
                }
            if (Enemyindex != -1)
            {
                target = TheGame.GameElements[Enemyindex];
                shoot(target.X, target.Y);


                 dx = target.X - this.X;
                 dy = target.Y - this.Y;
                d = Math.Sqrt(dx * dx + dy * dy);
            }
            if(PickupIndex != -1)
            {
                targetPickup = TheGame.PickupElements[PickupIndex];

                dxPickup = targetPickup.X - this.X;
                dyPickup = targetPickup.Y - this.Y;
                dPickup = Math.Sqrt(dxPickup * dxPickup + dyPickup * dyPickup);
            }
            //include Randomness
            /*if(Lucky.Next(0,100) < Randomness)
            {
                
                if (Lucky.Next(0, 10) < 0)
                    this.X += Lucky.Next(-1, 1) * speed;
                else
                    this.Y += Lucky.Next(-1, 1) * speed;
            }
            else
            {*/
                if (distance2PickUp < distance2Enemy)
                {
                    this.X += (int)(dxPickup / dPickup * speed);
                    this.Y += (int)(dyPickup / dPickup * speed);
                }
                else
                {
                    if (HP > 80)
                    {
                        this.X += (int)(dx / d * speed);
                        this.Y += (int)(dy / d * speed);
                    }
                    else
                    {
                        //don't run away, but try to get the pickup
                        //this.X -= (int)(dx / d * speed);
                        //this.Y -= (int)(dy / d * speed);
                        this.X += (int)(dxPickup / dPickup * speed);
                        this.Y += (int)(dyPickup / dPickup * speed);
                    }
                }
           // }
        }

        public virtual void shoot(int X, int Y)
        {
            CurrentWeapon.Shoot(X, Y);
        }

        
        public override void draw(Graphics g)
        {
            g.FillRectangle(this.Team.TeamColorBrush, X-Width/2, Y-Height/2, Width, Height);
            if(HP>1)
                g.FillRectangle(Brushes.Black, X-Width/2, Y-Height/2, Width, (int)((double)Height * ((100.0 - (double)(HP))/ 100.0)));
            if (Shielded)
                g.DrawEllipse(Pens.Blue, X-Width, Y-Height, Width * 2, Height * 2);
        }
        public override void reactToHit(GameObject o)
        {
            if (o is Bullet)
                if (((Bullet)o).Team != this.Team)
                {
                    HP -= ((Bullet)o).damage;
                    if (HP <= 0)
                    {
                        if(!IsDead)
                            o.Team.addKill();

                        IsDead = true;   
                    }
                }
            
        }

        public override void reactToPickUp(PickUp p)
        {
            if (CurrentPickup == null)
                CurrentPickup = p;
            else
                CurrentPickup = CurrentPickup.reactToNewPickup(p);
        }
    }
}
