using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using GameTest.Game.GameElements;

namespace GameTest.Game
{
    public class Renderer
    {
        public event EventHandler<ImageDrawnEventArgs> ImageUpdated;

        private Game game;
        private int RenderTime;
       
        public bool IsRunning { get; private set; }

        //Token and Tokensource for cancellation of the Render-Task
        CancellationTokenSource RenderTokenSource;
        CancellationToken RenderCancellationToken;

        public Renderer(Game game, int Rendertime)
        {
            this.game = game;
            this.RenderTime = Rendertime;
            IsRunning = false;
            
        }

        internal void Start()
        {
            //we want to be able to cancel the Task therefore we need a Cancellation-Token
            RenderTokenSource = new CancellationTokenSource();
            RenderCancellationToken = RenderTokenSource.Token;
            
            //Start the task
            Task.Run(() =>
           {
               bool drawStats = game.showStatistics;
               long RenderTimeActual =1;
               Stopwatch stopper = new Stopwatch();
              
               Bitmap[] Frames = new Bitmap[2] {
                                            new Bitmap(game.Width, game.Height),
                                            new Bitmap(game.Width, game.Height)
                                       };
               

               Graphics[] Painter = new Graphics[2] {
                                            Graphics.FromImage(Frames[0]),
                                            Graphics.FromImage(Frames[1])
                                       };
               int jumper = 0;
               Painter[0].SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
               Painter[1].SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
               Graphics currentPainter;
               IsRunning = true;
               while (true)
               {
                   //check if our Task is canceled from outside
                   if (RenderCancellationToken.IsCancellationRequested)
                   {
                       //if our Task was cancelled, end the loop
                       break;
                   }
                   stopper.Start();
                   currentPainter = Painter[jumper];
                   currentPainter.Clear(Color.White);
                   if (drawStats)
                   {
                       currentPainter.DrawString("Renderer: " + RenderTimeActual.ToString() + "ms / Logic: " + game.LogicTimeActual.ToString() + "ms", SystemFonts.DefaultFont, Brushes.Black, game.Width-250, 10);
                   }

                   lock (game.GameElementListLock)
                       for (int i = 0; i < game.GameElements.Count; i++)
                       {
                           game.GameElements[i].draw(currentPainter);
                       }
                   lock (game.PickupListLock)
                       for (int i = 0; i < game.PickupElements.Count; i++)
                       {
                           game.PickupElements[i].draw(currentPainter);
                       }
                   lock (game.BulletListLock)
                       for (int i = 0; i < game.BulletElements.Count; i++)
                       {
                           game.BulletElements[i].draw(currentPainter);
                       }


                   game.PlayMode.drawMenu(currentPainter);

                   if (ImageUpdated != null)
                       ImageUpdated(this, new ImageDrawnEventArgs(Frames[jumper]));

                   jumper = 1 - jumper;
                   stopper.Stop();
                   if (stopper.ElapsedMilliseconds < RenderTime)
                       Thread.Sleep((int)(RenderTime - stopper.ElapsedMilliseconds));

                   RenderTimeActual = stopper.ElapsedMilliseconds;
                   

                   stopper.Reset();
               }
           });
        }

        public void End()
        {
            //end the Render Task
            if(IsRunning)
                RenderTokenSource.Cancel();
        }

        //--------------------------------------------------------------------------------------------
        // everything below is only to guide the player in the beginning of the game
        internal void ShowStartConfig()
        {
            
        }

        internal void ShowFindPlayerDialog()
        {
            Bitmap b = new Bitmap(game.Width, game.Height);
            Graphics g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            lock (game.GameElementListLock)
                for (int i = 0; i < game.GameElements.Count; i++)
                {
                    game.GameElements[i].draw(g);
                }
            lock (game.PickupListLock)
                for (int i = 0; i < game.PickupElements.Count; i++)
                {
                    game.PickupElements[i].draw(g);
                }
            lock (game.BulletListLock)
                for (int i = 0; i < game.BulletElements.Count; i++)
                {
                    game.BulletElements[i].draw(g);
                }

            g.FillEllipse(Brushes.White, game.Width / 2 - 100, game.Height / 2 - 100, 200, 200);
            g.DrawEllipse(Pens.Black, game.Width / 2 - 100, game.Height / 2 - 100, 200, 200);
            g.DrawString("FIND YOUR PLAYER", SystemFonts.CaptionFont, Brushes.Red, game.Width / 2 - 85, game.Height / 2 - 30);
            g.DrawString("All players will", SystemFonts.CaptionFont, Brushes.Black, game.Width / 2 - 65, game.Height / 2);
            g.DrawString("now be highlighted", SystemFonts.CaptionFont, Brushes.Black, game.Width / 2 - 85, game.Height / 2+20);

            if (ImageUpdated != null)
                ImageUpdated(this, new ImageDrawnEventArgs(b));
        }

        internal void HighlightPlayers()
        {
            Bitmap b = new Bitmap(game.Width, game.Height);
            Graphics g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            
            lock (game.PickupListLock)
                for (int i = 0; i < game.PickupElements.Count; i++)
                {
                    game.PickupElements[i].draw(g);
                }
            lock (game.BulletListLock)
                for (int i = 0; i < game.BulletElements.Count; i++)
                {
                    game.BulletElements[i].draw(g);
                }
            lock (game.GameElementListLock)
                for (int i = 0; i < game.GameElements.Count; i++)
                {
                    var element = game.GameElements[i];
                    element.draw(g);
                    if (element is Player)
                    {
                        g.DrawEllipse(new Pen(element.Team.TeamColor, 4), element.X - 30, element.Y - 30, 60, 60);
                    }
                }
            
            

            if (ImageUpdated != null)
                ImageUpdated(this, new ImageDrawnEventArgs(b));
        }

        internal void ShowPlaymodeObjective()
        {
            Bitmap b = new Bitmap(game.Width, game.Height);
            Graphics g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            lock (game.GameElementListLock)
                       for (int i = 0; i < game.GameElements.Count; i++)
                {
                    game.GameElements[i].draw(g);
                }
            lock (game.PickupListLock)
                for (int i = 0; i < game.PickupElements.Count; i++)
                {
                    game.PickupElements[i].draw(g);
                }
            lock (game.BulletListLock)
                for (int i = 0; i < game.BulletElements.Count; i++)
                {
                    game.BulletElements[i].draw(g);
                }

            game.PlayMode.showMissionObjective(g);

            if (ImageUpdated != null)
                ImageUpdated(this, new ImageDrawnEventArgs(b));
        }

        internal void ShowCountdownNumber(int CountdownNumber)
        {
            Bitmap b = new Bitmap(game.Width, game.Height);
            Graphics g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            lock (game.GameElementListLock)
                       for (int i = 0; i < game.GameElements.Count; i++)
                {
                    game.GameElements[i].draw(g);
                }
            lock (game.PickupListLock)
                for (int i = 0; i < game.PickupElements.Count; i++)
                {
                    game.PickupElements[i].draw(g);
                }
            lock (game.BulletListLock)
                for (int i = 0; i < game.BulletElements.Count; i++)
                {
                    game.BulletElements[i].draw(g);
                }

            g.DrawString(CountdownNumber.ToString(), new Font("Arial", 72), new SolidBrush(Color.Red), game.Width/2 - 60, game.Height/2 - 60);

            if (ImageUpdated != null)
                ImageUpdated(this, new ImageDrawnEventArgs(b));
        }
    }
}