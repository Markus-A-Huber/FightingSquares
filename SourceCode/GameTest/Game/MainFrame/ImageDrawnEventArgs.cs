using System;
using System.Drawing;

namespace GameTest.Game
{
    public class ImageDrawnEventArgs : EventArgs
    {
        public Bitmap Image { get; private set; }
        public ImageDrawnEventArgs( Bitmap b)
        {
            Image = b;
        }
    }
}