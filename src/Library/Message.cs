using System;

namespace Library
{
    public class Message
    {
        private Phonebook from;
        private string[] to;

        public string From { get; private set; }
        public string To { get; set; }
        public string Text { get; private set; }

        // Constructor
        public Message(Phonebook from, string[] to, string text)
        {
            MakeMessage(from, to, text);
        }

        // Método para construir el mensaje
        public void MakeMessage(Phonebook from, string[] to, string text)
        {
            this.from = from;
            this.to = to;
            this.Text = text;
        }
    }
}
