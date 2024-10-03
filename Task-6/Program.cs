#region Contacts
/*
var contacts = new Contacts.Contacts();
contacts.Add("Anna", 380990123456);
contacts.Add("Marie", 380991234567);

contacts.Remove("Anna2");
Console.WriteLine("Get Anna contact - " + contacts.Get("Anna"));

contacts.ShowAll();
*/
#endregion

#region Students
/*
var students = new StudentsList.Students();
students.AddStudent("John");
students.AddStudent("Anna Vinda");
students.AddStudent("Mark");
students.AddStudent("Marie");

students.Count();
Console.WriteLine(students.GetStudent("Anna"));
students.RemoveStudent("Anna V");
students.Count();
*/
#endregion

#region Buyers
var buyers = new BuyerQueue.Buyers();
buyers.Add("Anastasia");
buyers.Add("Jake");
buyers.Add("Stanislav");

buyers.Serve();

buyers.Count();
#endregion