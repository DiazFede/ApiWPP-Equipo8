using System;

namespace Library
{
    public class Message
    {
        private Phonebook from;
        private string[] to;

        public string From { get; private set; }
        public string To { get; private set; }
        public string Text { get; private set; }

        public Message(string from, string to, string text)
        {
            From = from;
            To = to;
            Text = text;
        }

        public Message(Phonebook from, string[] to)
        {
            this.from = from;
            this.to = to;
        }
    }
}
