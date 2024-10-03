using System.Xml.Linq;

namespace Contacts
{
    public class Contacts
    {
        private Dictionary<string, long> contacts;
        Contacts()
        {
            contacts = new Dictionary<string, long>();
        }

        public void Add(string name, int phoneNumber)
        {
            contacts.Add(name, phoneNumber);
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
        }

        public long Get(string name)
        {
            long phoneNumber;
            if (!contacts.TryGetValue(name,out phoneNumber))
                Console.WriteLine("Not found");
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