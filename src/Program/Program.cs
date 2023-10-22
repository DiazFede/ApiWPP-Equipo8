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
            WhatsAppApi whatsAppi = new WhatsAppApi();
            
           // Crear un mensaje
             WhatsAppChannel whatsappChannel = new WhatsAppChannel();
            Message mensaje = new Message(contactoDueño, listaContactos, "Hola rodri te hablo desde el vscode lol");
            mensaje.MakeMessage(contactoDueño, listaContactos, "Hola rodri te hablo desde el vscode lol"); 
            whatsappChannel.Send(mensaje);
            foreach (var nombreContacto in listaContactos)
            {
                var contactosEncontrados = contactoDueño.Search(new string[] { nombreContacto });
                if (contactosEncontrados.Count > 0)
                {
                    // Suponemos que tomamos el primer contacto encontrado
                    var contacto = contactosEncontrados[0];
                    mensaje.To = contacto.Name;

                    // Enviar el mensaje utilizando WhatsAppApi (crea una instancia y llama al método Send)
                    string resultado = whatsAppi.Send(contacto.Phone, mensaje.Text);
                    Console.WriteLine($"Mensaje enviado a {contacto.Name} con resultado: {resultado}");
                }
                else
                {
                    Console.WriteLine($"No se encontró el contacto {nombreContacto} en la lista de contactos.");
                }

        }
    }

   
}
}





