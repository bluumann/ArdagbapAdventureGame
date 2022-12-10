using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdagbapAdventureGame
{
    internal class DialogEncounter : Event
    {
        private List<String> EventOptions;

        public DialogEncounter(string eventName, Image eventImage, string eventDescription, string eventType) : base(eventName, eventImage, eventDescription, eventType)
        {
        }

        public override void UpdateEvent()
        {
            throw new NotImplementedException();
        }

        private void DrawEvent()
        {

        }
    }
}
