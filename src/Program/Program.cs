using System;
using Library;
using WhatsAppApiUCU;

namespace Program
{
    class Program
    {
        public static object WhatsApp { get; private set; }

        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact contacto1 = new Contact("Dueño");
            Phonebook contactoDueño = new Phonebook(contacto1);
          

            // Crear la lista de contactos
            Contact contacto2 = new Contact("Rodri");
            contacto2.Phone = "+59899453713";
            contactoDueño.AddContact(contacto2);

            Contact contacto3 = new Contact("Jero");
            contacto3.Phone = "+59891785770";
            contactoDueño.AddContact(contacto3);

            // Agregar contactos a la lista
            String[] listaContactos = new String[4];
            listaContactos[0] = "Jero";
            listaContactos[1] = "Rodri";
            
            // Enviar un WhatsApp a algunos contactos
            var whatsApp = new WhatsAppApi();
            whatsApp.Send("+59891785770", "Hey! I'm using WhatsApp");
            
            Message mensaje2 = new WhatsAppMessage(contactoDueño, listaContactos);
            mensaje2.Text = "PruebaGrupo8/ Hola";
            WhatsAppChannel.Send(mensaje2);

        }
    }

    internal class WhatsAppMessage : Message
    {
        public WhatsAppMessage(Phonebook from, string[] to) : base(from, to)
        {
        }
    }
}





