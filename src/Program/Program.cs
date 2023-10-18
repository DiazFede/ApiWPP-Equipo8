using System;
using System.Collections.Generic;
using WhatsAppApiUCU;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var whatsApp = new WhatsAppApi();
            whatsApp.Send("+59891785771", "Hey! I'm using WhatsApp");
            Contact owner = new Contact("Dueño", "+598091785770");

            Phonebook phonebook = new Phonebook(owner);

            Contact contact1 = new Contact("Amigo 1", "+598091785771"); 

            phonebook.AddContact(contact1);

            WhatsAppChannel whatsappChannel = new WhatsAppChannel();
            
            Contact sender = owner;
            string[] recipientNames = { "Amigo 1" };
            string messageText = "¡Hola desde WhatsApp!";

            // Busca el destinatario en el Phonebook
            List<Contact> recipients = phonebook.Search(recipientNames);
            if (recipients.Count > 0)
            {
                // Solo si se encontró al menos un destinatario
                Contact recipient = recipients[0]; 

                // Crea un mensaje y envíalo
                Message message = new Message(sender.Name, recipient.Name, messageText);
                whatsappChannel.Send(message);

                Console.WriteLine("Mensaje enviado con éxito a " + recipient.Name);
            }
            else
            {
                Console.WriteLine("El destinatario no se encontró en la lista de contactos.");
            }
        }
    }
}





