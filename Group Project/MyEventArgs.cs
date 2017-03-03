using System;

namespace Group_Project
{
    /// <summary>
    /// This Class is a manually created Event Argument, that can hold information about the event and pass it to the recieving class
    /// </summary>
    public class MyEventArgs : EventArgs
    {
        /// <summary>
        /// information regarding the event
        /// </summary>
        private string EventInfo;
        /// <summary>
        /// add a string to the event
        /// </summary>
        /// <param name="Text"></param>
        public MyEventArgs (string Text)
        {
            EventInfo = Text;
        }
        /// <summary>
        /// get the string from the event
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return EventInfo;
        }
    }
}
