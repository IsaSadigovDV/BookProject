using BookProject.Models;


Book[] Books = new Book[2];

for (int i = 0; i < Books.Length; i++)
{
    Console.Write("Enter book name: ");
    string BookName = Console.ReadLine();

    Console.Write("Enter page count: ");
    int Pagecount = int.Parse(Console.ReadLine());

    while (!CheckName(BookName))
    {
        Console.WriteLine("Please enter name correctly");
    }

    while (!CheckPageCount(Pagecount))
    {
        Console.WriteLine("Please enter page numbers correctly");
        Pagecount = int.Parse(Console.ReadLine());
    }

    Book book = new Book(BookName, Pagecount);
    Books[i] = book;

    while (CheckArray(BookName))
    {

        try
        {   

            Console.WriteLine("Name should be different");
            BookName = Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("We find 2 same book name. Please try again: ");
            throw ex;
        }
    
    }
    
}



bool CheckArray(string name)
{
    foreach (Book book in Books)
    {
        if(book != null)
        {
            if(name == book.Name)
            {
                return false;
            }
        }
    }

    return true;
    
      
}



bool CheckName(string name)
{
    if(!string.IsNullOrWhiteSpace(name) && name.Length > 2)
        return true;
    return false;
}

bool CheckPageCount(int PageCount)
{
    if (PageCount > 10)
        return true;

    return false;
}

foreach (var book in Books)
{
    Console.WriteLine($"Name: {book.Name} PageCount: {book.PageCount}");
}



