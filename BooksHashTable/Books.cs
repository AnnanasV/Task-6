using System.Collections;

namespace BooksHashTable
{
    public class Books
    {
        private Hashtable books;

        public Books()
        {
            books = new Hashtable();
        }

        public void Add(int hash, string name)
        {
            books.Add(hash, name);
            Console.WriteLine($"Book \"{name}\" was added to the library");
        }

        public void Remove(int hash)
        {
            if (books.ContainsKey(hash))
            {
                Console.WriteLine($"Book \"{books[hash]}\" was deleted from the library");
                books.Remove(hash);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void GetBook(int hash)
        {
            if(books.ContainsKey(hash))
            {
                Console.WriteLine($"Book : {books[hash]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void ShowAll()
        {
            foreach(var book in books.Values)
            {
                Console.WriteLine(book);
            }
        }
    }
}