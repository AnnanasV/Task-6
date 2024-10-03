namespace StudentsList
{
    public class Students
    {
        private List<string> students;

        public Students()
        {
            students = new List<string>();
        }

        public void AddStudent(string student)
        {
            students.Add(student);
            Console.WriteLine($"Student {student} was added");
        }

        public void RemoveStudent(string student)
        {
            if(!students.Remove(student))
            {
                Console.WriteLine($"Student {student} not found");
                return;
            }
            Console.WriteLine($"Student {student} was removed");
        }

        public string GetStudent(string name)
        {
            string student;
            student = students.Find(s => s.Contains(name, StringComparison.OrdinalIgnoreCase));
            if(student == null)
            {
                Console.WriteLine("Not found");
                student = string.Empty;
            }
            return student;
        }

        public void Count()
        {
            Console.WriteLine($"Students: {students.Count()}");
        }
    }
}