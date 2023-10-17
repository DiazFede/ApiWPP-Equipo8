using System;
using System.Collections.Generic;  // Agrega esta directiva para List
using Library;  // Asegúrate de que esta referencia esté configurada

namespace Program
{
    class Program
    {
        private static string recipientName;

        static void Main(string[] args)
        {
            // Crear el dueño del teléfono
            Contact owner = new Contact("Dueño");

            // Crear una lista de contactos (Phonebook)
            Phonebook phonebook = new Phonebook(owner);

            // Crear y agregar contactos a la lista
            Contact contact1 = new Contact("Amigo 1");
            Contact contact2 = new Contact("Amigo 2");

            // Agregar contactos a la lista
            phonebook.AddContact(contact1);
            phonebook.AddContact(contact2);

            // Enviar un mensaje por WhatsApp a algunos contactos
            WhatsAppChannel whatsappChannel = new WhatsAppChannel();

            Contact sender = owner; // El remitente es el dueño
            string[] recipientNames = { "Amigo 1", "Amigo 2" };
            string messageText = "¡Hola desde WhatsApp!";

            List<Contact> recipient = phonebook.Search(recipientNames);
            Message message = new Message(sender.Name, recipientName, messageText);
            whatsappChannel.Send(message);



            Console.WriteLine("Mensajes enviados con éxito.");
        }
    }
}




