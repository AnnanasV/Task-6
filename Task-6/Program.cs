#region Contacts
var contacts = new Contacts.Contacts();
contacts.Add("Anna", 380990123456);
contacts.Add("Marie", 380991234567);

contacts.Remove("Anna2");
Console.WriteLine("Get Anna contact - " + contacts.Get("Anna"));

contacts.ShowAll();
#endregion