namespace Contacts
{
    public class Contacts
    {
        private Dictionary<string, long> contacts;
        public Contacts()
        {
            contacts = new Dictionary<string, long>();
        }

        public void Add(string name, long phoneNumber)
        {
            try
            {
                contacts.Add(name, phoneNumber);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("You already have this contact");
                return;
            }
            Console.WriteLine($"{phoneNumber} - {name} was added");
        }

        public void Remove(string name)
        {
            long phoneNumber;
            if(contacts.TryGetValue(name, out phoneNumber))
            {
                contacts.Remove(name);
                Console.WriteLine($"{phoneNumber} - {name} was deleted");
            }
            else
            {
                Console.WriteLine($"{name} not found");
            }
        }

        public long Get(string name)
        {
            long phoneNumber;
            if (!contacts.TryGetValue(name,out phoneNumber))
                Console.WriteLine($"{name} not found");
            return phoneNumber;
        }

        public void ShowAll()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Value } - {contact.Key}");
            }
        }
    }
}