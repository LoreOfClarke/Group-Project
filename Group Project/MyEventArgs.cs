using System;

namespace Group_Project
{
    public class MyEventArgs : EventArgs
    {
        /// <summary>
        /// This Class is a manually created Event Argument, that can hold information about the event and pass it to the recieving class
        /// </summary>
        private string EventInfo;
        public MyEventArgs (string Text)
        {
            EventInfo = Text;
        }
        public string GetInfo()
        {
            return EventInfo;
        }
    }
}
