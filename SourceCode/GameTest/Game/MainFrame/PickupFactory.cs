using GameTest.Game.PickUps;
using GameTest.Game.PickUps.WeaponPickups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.MainFrame
{
    public class PickupFactory
    {
        private static PickupFactory SingletonInstance;
        private Game TheGame;
        private Random Lucky;
        Dictionary<PickUpType, ConstructorInfo> PickUpMapping;
        List<PickUpType> AvailablePickupTypes;
        

        //lazy loading singleton
        public static PickupFactory getFactory()
        {
            if (SingletonInstance == null)
            {
                throw new NotSupportedException("No available Pickup-Factory. Create one first with PickupFactory.createFactory(Game g).");
            }
            return SingletonInstance;
        }
        public static PickupFactory createFactory(Game g)
        {
            SingletonInstance = new PickupFactory(g);
            SingletonInstance.PickUpMapping = new Dictionary<PickUpType, ConstructorInfo>();
            SingletonInstance.Lucky = new Random();
            SingletonInstance.AvailablePickupTypes = new List<PickUpType>();
            return SingletonInstance;
        }

        //hidden constructor
        private PickupFactory(Game g)
        {
            TheGame = g;
        }

        public void AddAvailablePickups(params PickUpType[] PickupTypeToAdd)
        {
            
            foreach(PickUpType type in PickupTypeToAdd)
            {
                //make sure you get no double types
                if (AvailablePickupTypes.Contains(type))
                    continue;

                AvailablePickupTypes.Add(type);
                switch (type)
                {
                    case PickUpType.Health:
                        PickUpMapping.Add(PickUpType.Health,
                                          typeof(HealthPickup).GetConstructor(new Type[3] { typeof(int), typeof(int), typeof(Game) }));
                        break;
                    case PickUpType.Cannon:
                        PickUpMapping.Add(PickUpType.Cannon,
                                          typeof(CannonPickup).GetConstructor(new Type[3] { typeof(int), typeof(int), typeof(Game) }));
                        break;
                    case PickUpType.Shield:
                        PickUpMapping.Add(PickUpType.Shield,
                                          typeof(ShieldPickup).GetConstructor(new Type[3] { typeof(int), typeof(int), typeof(Game) }));
                        break;
                    case PickUpType.Flamethrower:
                        PickUpMapping.Add(PickUpType.Flamethrower,
                                          typeof(FlamethrowerPickup).GetConstructor(new Type[3] { typeof(int), typeof(int), typeof(Game) }));
                        break;
                    case PickUpType.RocketLauncher:
                        PickUpMapping.Add(PickUpType.RocketLauncher,
                                          typeof(RocketLauncherPickup).GetConstructor(new Type[3] { typeof(int), typeof(int), typeof(Game) }));
                        break;
                    case PickUpType.Tentacles:
                        PickUpMapping.Add(PickUpType.Tentacles,
                                          typeof(TentaclePickup).GetConstructor(new Type[3] { typeof(int), typeof(int), typeof(Game) }));
                        break;
                    case PickUpType.Wings:
                        PickUpMapping.Add(PickUpType.Wings,
                                          typeof(WingsPickup).GetConstructor(new Type[3] { typeof(int), typeof(int), typeof(Game) }));
                        break;
                    case PickUpType.Twister:
                        PickUpMapping.Add(PickUpType.Twister,
                                          typeof(TwisterPickup).GetConstructor(new Type[3] { typeof(int), typeof(int), typeof(Game) }));
                        break;
                    case PickUpType.Pistol:
                        PickUpMapping.Add(PickUpType.Pistol,
                                          typeof(PistolPickup).GetConstructor(new Type[3] { typeof(int), typeof(int), typeof(Game) }));
                        break;
                }
            }
        }

        public void InitiateAllPickups()
        {
            AddAvailablePickups(PickUpType.Cannon, 
                                PickUpType.Flamethrower, 
                                PickUpType.Health, 
                                PickUpType.RocketLauncher, 
                                PickUpType.Shield, 
                                PickUpType.Tentacles, 
                                PickUpType.Wings, 
                                PickUpType.Twister,
                                PickUpType.Pistol);
        }

        public PickUp spawnPickUp(int X, int Y, PickUpType type)
        {
            if (!PickUpMapping.ContainsKey(type))
                throw new IndexOutOfRangeException("Sorry this Pickup was not selected on startup!");
            if (AvailablePickupTypes.Count == 0)
                return null;
            var pickupInfo = PickUpMapping[type];
            return (PickUp)pickupInfo.Invoke(new object[] { X, Y, TheGame });
        }

        internal GameObject SpawnRandomPickUp(int X, int Y)
        {
            if (AvailablePickupTypes.Count == 0)
                return null;
            var pickupInfo = PickUpMapping[AvailablePickupTypes[Lucky.Next(0, AvailablePickupTypes.Count)]];
            return (PickUp)pickupInfo.Invoke(new object[] { X, Y, TheGame });
        }

        internal GameObject SpawnRandomPickUp()
        {
            if (AvailablePickupTypes.Count == 0)
                return null;
            var pickupInfo = PickUpMapping[AvailablePickupTypes[Lucky.Next(0, AvailablePickupTypes.Count)]];
            return (PickUp)pickupInfo.Invoke(new object[] { Lucky.Next(50, TheGame.Width - 50), Lucky.Next(50, TheGame.Height - 50), TheGame });
        }

    }
}
