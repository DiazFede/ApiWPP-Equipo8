using System;

namespace Library
{
    public class Message
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public string Text { get; private set; }

        public Message(string from, string to, string text)
        {
            From = from;
            To = to;
            Text = text;
        }
    }
}
