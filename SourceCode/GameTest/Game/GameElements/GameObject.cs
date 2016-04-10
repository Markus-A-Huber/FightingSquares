using GameTest.Game.GameElements;
using GameTest.Game.PickUps;
using System.Drawing;

namespace GameTest.Game
{
    public class GameObject
    {
        public Team Team { get; protected set; }
        protected Game TheGame;
        public virtual bool IsDead { get; protected set; }
        int border = 10;
        int x;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > border && value < TheGame.Width-border)
                    x = value;

                /* //periodic boundary conditions
                if (value < 10)
                    x = TheGame.Width-10;
                else
                if (value > TheGame.Width-10)
                    x = 11;
                else
                    x = value;*/
            }
        }
        private int y;
        public int Y 
        {
            get
            {
                return y;
            }
            set
            {
                if (value > border && value < TheGame.Height-border)
                    y = value;
                /* //periodic boundary conditions
                if (value < 10)
                    y = TheGame.Height-10;
                else
                if (value > TheGame.Height-10)
                    y = 11;
                else
                    y = value;*/
            }
        }
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public GameObject(int x, int y, int w, int h, Game game)
        {
            TheGame = game;
            this.x = x;
            this.y = y;
            Width = w;
            Height = h;
            IsDead = false;
        }
        public virtual void draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, X-Width/2,Y-Height/2,Width,Height);
        }
        public virtual void move()
        {

        }
        public virtual void reactToHit(GameObject o)
        {

        }
        public virtual void reactToPickUp(PickUp p)
        {

        }
    }
}