using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdagbapAdventureGame
{
    internal abstract class Event
    {
        public string EventName;
        private Image EventImage;
        private string EventDescription;
        private string EventType;
    }
}
