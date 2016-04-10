using GameTest.Game.GameElements;
using GameTest.Game.MainFrame;
using GameTest.Game.MainFrame.GameModes;
using GameTest.Game.PickUps;
using GameTest.Game.Weapons;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameTest.Game
{
    public class Game
    {
        //public 
        public int Width { get; set; }
        public int Height { get; set; }
        public object GameElementListLock { get; set; } 
        public object BulletListLock { get; set; }
        public object PickupListLock { get; set; }    
        public List<Player> UserControlledPlayers { get; set; }
        public List<Fighter> InitialBots { get; set; }
        public List<Team> Teams { get;  set; }
        public GameMode PlayMode { get; set; }
     
        //public get; private set;
        public long LogicTimeActual {get; private set; }
        public bool showStatistics { get; private set; }
        public Renderer Render { get; private set; }
        public List<GameObject> GameElements { get; private set; }
        public List<Bullet> BulletElements { get; private set; }
        public List<PickUp> PickupElements { get; private set; }
        public PickupFactory PickupManager { get; private set; }
        public bool  WeaponCeptionOn       { get; private set; }
        //private 
        private Random Lucky;
        private int RenderTime;
        private int LogicTime;
        private int RespawnCounterSave;
        private int PickupCounterSave;
        private bool Escape_Current_Intro;
        
        //Token and Tokensource for cancellation of the Gameloop-Task
        private CancellationTokenSource GameLoopTokenSource;
        private CancellationToken GameLoopCancellationToken;

        public Game(int RenderTime, int LogicTime, int RespawnRate, int PickupRate, bool statistics, bool allPickups) //:this()
        {
            Render = new Renderer(this, RenderTime);
            GameElements = new List<GameObject>();
            BulletElements = new List<Bullet>();
            PickupElements = new List<PickUp>();
            changeStartParameters(RenderTime, LogicTime, RespawnRate, PickupRate,true, statistics);
            GameElementListLock = new object();
            PickupListLock = new object();
            BulletListLock = new object();
            Lucky = new Random();
            Teams = new List<Team>();
            UserControlledPlayers = new List<Player>();
            InitialBots = new List<Fighter>();
            PlayMode = new FreeGame(this);
            PickupManager = PickupFactory.createFactory(this);
            Escape_Current_Intro = false;
            if (allPickups)
                PickupManager.InitiateAllPickups();
        }

        public Game(int RenderTime, int LogicTime, int RespawnRate, int PickupRate, bool statistics, bool allPickups, bool Weaponception) : 
            this( RenderTime,  LogicTime,  RespawnRate,  PickupRate,  statistics,  allPickups)
        {
            WeaponCeptionOn = Weaponception;
        }

        internal void changeStartParameters(int RenderTime, int LogicTime, int RespawnRate, int PickupRate,bool WeaponCeption, bool statistics)
        {
            this.RenderTime = RenderTime;
            this.LogicTime = LogicTime;
            RespawnCounterSave = RespawnRate;
            PickupCounterSave = PickupRate;
            showStatistics = statistics;
            WeaponCeptionOn = WeaponCeption;
        }

        public void Start()
        {
            //add players to the game
            if(UserControlledPlayers.Count>0)
                GameElements.AddRange(UserControlledPlayers);

            if (InitialBots.Count > 0)
                GameElements.AddRange(InitialBots);

            //start the Renderer to draw all elements on the screen
            //Render.Start(); //moved inside Logic Loop to show objective and players
          
            //we want to be able to cancel the Task therefore we need a Cancellation-Token
            GameLoopTokenSource = new CancellationTokenSource();
            GameLoopCancellationToken = GameLoopTokenSource.Token;
            
            //Start the Logic Loop
            Task.Run(() =>
           {
               GameObject CurrentPickup;
               int RespawnCounter = RespawnCounterSave;
               int PickupCounter = PickupCounterSave;
               int RespawnTeam = 1;
               Stopwatch stopper = new Stopwatch();
               List<int> IndicesToRemove = new List<int>();
               List<int> BulletIndicesToRemove = new List<int>();
               List<int> PickupIndicesToRemove = new List<int>();
               Team WinningTeam = null;

               
               Render.ShowStartConfig();
               if (UserControlledPlayers.Count > 0)
               {
                   Render.ShowFindPlayerDialog();
                   for(int i = 0; i<300;i++)
                   {
                       if (Escape_Current_Intro)
                       {
                           Escape_Current_Intro = false;
                           break;
                       }
                       else
                           Thread.Sleep(10);
                   }
                   Render.HighlightPlayers();
                   for (int i = 0; i < 300; i++)
                   {
                       if (Escape_Current_Intro)
                       {
                           Escape_Current_Intro = false;
                           break;
                       }
                       else
                           Thread.Sleep(10);
                   }
               }
               Render.ShowPlaymodeObjective();
               for (int i = 0; i < 300; i++)
               {
                   if (Escape_Current_Intro)
                   {
                       Escape_Current_Intro = false;
                       break;
                   }
                   else
                       Thread.Sleep(10);
               }

               for (int i = 5; i>0;i--)
               {
                Render.ShowCountdownNumber(i);
                for (int j = 0; j < 100; j++)
                {
                    if (Escape_Current_Intro)
                    {
                        Escape_Current_Intro = false;
                        break;
                    }
                    else
                        Thread.Sleep(10);
                }
               }
               
               Render.Start();
                

               //The never-ending game loop
               while (true)
               {
                   //check if our Task is canceled from outside
                   if (GameLoopCancellationToken.IsCancellationRequested)
                   {
                       //if our Task was cancelled, end the loop
                       break;
                   }

                   IndicesToRemove.Clear();
                   BulletIndicesToRemove.Clear();
                   PickupIndicesToRemove.Clear();
                   stopper.Start();
                   lock (GameElementListLock)
                      for (int i = 0; i < GameElements.Count; i++)
                       {
                           GameElements[i].move();
                           if (GameElements[i].IsDead)
                               IndicesToRemove.Add(i);
                       }
                   lock (BulletListLock)
                      for (int i = 0; i < BulletElements.Count; i++)
                       {
                           BulletElements[i].move();
                           if (BulletElements[i].IsDead)
                               BulletIndicesToRemove.Add(i);
                       }
                   lock (PickupListLock)
                      for (int i = 0; i < PickupElements.Count; i++)
                       {
                           PickupElements[i].move();
                           if (PickupElements[i].IsDead)
                               PickupIndicesToRemove.Add(i);
                       }


                   //IndicesToRemove = IndicesToRemove.OrderBy(x => x).ToList();
                   lock (GameElementListLock)
                       for (int i = 0; i < IndicesToRemove.Count; i++)
                       {
                           GameElements.RemoveAt(IndicesToRemove[i] - i);
                       }
                   lock (BulletListLock)
                       for (int i = 0; i < BulletIndicesToRemove.Count; i++)
                       {
                           BulletElements.RemoveAt(BulletIndicesToRemove[i] - i);
                       }
                   lock (PickupListLock)
                       for (int i = 0; i < PickupIndicesToRemove.Count; i++)
                       {
                           PickupElements.RemoveAt(PickupIndicesToRemove[i] - i);
                       }

                   //Respawn
                   if (RespawnCounter-- < 0)
                   {
                       RespawnCounter = RespawnCounterSave;
                       lock (GameElementListLock)
                            GameElements.Add(new Fighter(Lucky.Next(50, Width - 50), Lucky.Next(50, Height - 50), Teams[(RespawnTeam++ % Teams.Count)], this));
                   }

                   //PickUps
                   if (PickupCounter-- < 0)
                   {
                       PickupCounter = PickupCounterSave;
                       CurrentPickup = PickupManager.SpawnRandomPickUp();
                       if(CurrentPickup != null)
                            lock (PickupListLock)
                                PickupElements.Add((PickUp)CurrentPickup);
                   }

                   //Special events from game mode
                   PlayMode.SpecialEvent();

                   if(this.PlayMode.checkWin(out WinningTeam))
                   {
                       GameOver(WinningTeam);
                   }


                   stopper.Stop();
                   if (stopper.ElapsedMilliseconds < LogicTime)
                       Thread.Sleep((int)(LogicTime - stopper.ElapsedMilliseconds));
                   //to show Logic FPS in game
                   LogicTimeActual = stopper.ElapsedMilliseconds;

                   stopper.Reset();
               }
           });
        }

        internal void EscapeCurrentIntro()
        {
            Escape_Current_Intro = true;
        }

        public void GameOver(Team WinningTeam)
        {
            End();
        }

        public void End()
        {
            //end Gameloop
            GameLoopTokenSource.Cancel();

            Thread.Sleep(50); //necessary to show the winner message
            
            //end Renderer
            Render.End();
        }

        internal void SpawnUserGeneratedItem(int X, int Y,PickUpType type)
        {
            lock (PickupListLock)
                PickupElements.Add(PickupManager.spawnPickUp(X, Y, type));
        }
    }
}
