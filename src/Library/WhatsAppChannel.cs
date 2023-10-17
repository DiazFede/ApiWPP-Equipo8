using System;
using Library;
using WhatsAppApiUCU;

namespace Library
{
    public class WhatsAppChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine($"Mensaje enviado por WhatsApp de {message.From} a {message.To}: {message.Text}");
        }
    }
}
