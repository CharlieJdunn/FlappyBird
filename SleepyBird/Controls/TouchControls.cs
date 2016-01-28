using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SleepyBird.Controls
{
    public class TouchControls : IControls
    {
        public bool ReadFlap()
        {
            return TouchPanel.GetState().Any(touch =>
                touch.State == TouchLocationState.Pressed);
        }
    }
}
