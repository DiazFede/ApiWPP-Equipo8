namespace Library
{
    public class Contact
    {
        public Contact(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}