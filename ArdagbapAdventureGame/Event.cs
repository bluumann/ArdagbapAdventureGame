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
        public Image EventImage;
        public string EventDescription;
        public string EventType;

        protected Event(string eventName, Image eventImage, string eventType)
        {
            EventName = eventName;
            EventImage = eventImage;
            EventType = eventType;
        }

        public abstract void UpdateEvent();
    }
}
