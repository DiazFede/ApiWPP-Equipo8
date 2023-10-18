using System;
using WhatsAppApiUCU;
namespace Library
{
    public class WhatsAppMessages : Message
    {
        public WhatsAppMessages (Phonebook from, string[] to) : base (from, to)
        {
        }
    }
}