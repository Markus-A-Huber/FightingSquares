using GameTest.Game.GameElements.PlayerStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GameTest.Game.Weapons;
using GameTest.Game.PickUps;


namespace GameTest.Game.GameElements
{
    public class Player : Fighter
    {
        public Dictionary<Keys, PlayerState> KeyBindings { get; set;}
        PlayerState CurrentState;
        public int mouseX { get; set; }
        public int mouseY { get; set; }
        public bool IsFiring { get; private set; }
        bool TemporarilyDead;
        int RespawnTime;
        int CurrentRespawnCycleTime;
        bool autoAim;
        public char Symbol { get; set; }
        

        public Player(int x, int y, char Symbol, Team TeamNumber,bool autoAim, Game g) : base(x,y,TeamNumber,g)
        {
            CurrentState = new IdleState(this);
            KeyBindings = new Dictionary<Keys, PlayerState>();
            IsFiring = true; //always in fire-Mode
            TemporarilyDead = false;
            RespawnTime = 300;
            CurrentRespawnCycleTime = RespawnTime;
            //Shielded = true;
            //give him a shield as a starting bonus 
            CurrentPickup = new ShieldPickup(0,0,TheGame); 
            //player is a bit faster than the others
            speed = 4;
            //and has the best weapon from the start
            CurrentWeapon = new Wings(TheGame, this);//Flamethrower(TheGame, this);
            this.autoAim = autoAim;
            this.Symbol = Symbol;
           
        }

        public override void move()
        {
            if (!TemporarilyDead)
            {
                if (CurrentPickup != null)
                {
                    //change "State" of the Pickup, to implement single use, cooldown and so on
                    CurrentPickup = CurrentPickup.interactWithFighter(this);
                }
                CurrentState.move();
            }
            else
            {
                if(CurrentRespawnCycleTime-- < 0)
                {
                    CurrentRespawnCycleTime = RespawnTime;
                    TemporarilyDead = false;
                    IsFiring = true;
                    CurrentPickup = new ShieldPickup(0, 0, TheGame);
                    HP = 100;
                }
                CurrentState.move();
            }
        }

        public override void draw(Graphics g)
        {
            if (!TemporarilyDead)
            {
                base.draw(g);
                g.DrawRectangle(Pens.Black, X-Width/2, Y-Height/2, Width, Height);
                g.DrawString(Symbol.ToString(), SystemFonts.CaptionFont, Brushes.White, X-10, Y-10);

            }
            else
            {
                g.DrawImage(Images.Ghost, X - Width / 2, Y - Height / 2, Width, Height);
                g.FillRectangle(Brushes.DarkGreen, X, Y -4, (int)(20.0*(double)CurrentRespawnCycleTime / (double)RespawnTime), 4);
            }
        }

        public override void shoot(int X, int Y)
        {
            if (!autoAim)
                base.shoot(X, Y);
            else
            {
                double distance2Enemy = 10000000000;
                double dx = 0;
                double dy = 0;
                double d = 1;
                int Enemyindex = -1;
                for (int i = 0; i < TheGame.GameElements.Count; i++)
                {
                    var element = TheGame.GameElements[i];
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
                if (Enemyindex != -1)
                {
                    var target = TheGame.GameElements[Enemyindex];
                    base.shoot(target.X, target.Y);

                }
            }
        }

        public override bool IsDead
        {
            get
            {
                return false;
            }

            protected set
            {
                ;
            }
        }

        public override void reactToHit(GameObject o)
        {
            if (o is Bullet)
                if (((Bullet)o).Team != this.Team)
                {
                    HP -= ((Bullet)o).damage;
                    if (HP <= 0)
                    {
                        if (!TemporarilyDead)
                            o.Team.addKill();

                        TemporarilyDead = true;
                        IsFiring = false;
                        HP = 100;
                    }
                }

        }


        //Methods for interaction with the Form

        public void reactToKeyDown(object sender, KeyEventArgs e)
        {
            if(KeyBindings.ContainsKey(e.KeyCode))
                CurrentState = CurrentState.changeState(KeyBindings[e.KeyCode]);
        }

        internal void reactToKeyUp(object sender, KeyEventArgs e)
        {
            if (KeyBindings.ContainsKey(e.KeyCode))
                CurrentState = CurrentState.removeState(KeyBindings[e.KeyCode]);
        }
        internal void reactToMouseUp(object sender, MouseEventArgs e)
        {
           // this.IsFiring = false; // Dauerfeuer-Ungeheuer 
        }

        internal void reactToMouseDown(object sender, MouseEventArgs e)
        {
            //this.IsFiring = true;
            //shoot(mouseX, mouseY);
        }

        internal void reactToMouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }
    }
}
