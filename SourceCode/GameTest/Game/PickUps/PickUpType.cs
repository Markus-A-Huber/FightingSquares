using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.PickUps
{
    public enum PickUpType
    {
        Health = 0,
        Cannon = 1,
        Shield = 2,
        Flamethrower = 3,
        Tentacles =4,
        RocketLauncher =5,
        Twister = 6,
        Wings = 7,
        Pistol = 9
       // No coin pickup here because the Gamemode puts them on the screen
    }
}
