using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdagbapAdventureGame
{
    internal class Store : Event
    {
        private List<Card> AvailableItems;

        public Store(string eventName, Image eventImage, string eventDescription, string eventType) : base(eventName, eventImage, eventType)
        {
        }

        public override void UpdateEvent()
        {
            throw new NotImplementedException();
        }

        private void BuyItem()
        {

        }

        private void LeaveStore()
        {

        }
    }
}
