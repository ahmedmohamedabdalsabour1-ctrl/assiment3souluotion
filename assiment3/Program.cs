using System.Text;

namespace assiment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string title = "clean code";

            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            // string title1 = "Clean Code";
            // string title2 = "Clean Code";
            // Console.WriteLine(object.ReferenceEquals(title1, title2));
            //اول طريقه 
            //string name = "Ahmed";
            //name += " Mohamed";
            //تاني طريقه وهي المطلوبه 
            //StringBuilder ss = new StringBuilder();
            //sb.Append("Ahmed");
            //sb.Append(" Mohamed");
            //Console.WriteLine(sb);
            // ss.Replace("Book List", "Library");
            //  Console.WriteLine(ss);
            /* string title = "Clean Code";
             int pages = 464;
             string result = "Book :" + title + "  Pages:  " + pages;
             Console.WriteLine(result);
             Console.WriteLine($"Book: {title}, Pages: {pages}");
             string sentence = string.Format("Book: {0} , page : {1}",title , pages);
             Console.WriteLine(sentence);
             int pages = 464;
             if (pages > 300)
             {
                 Console.WriteLine("Long Book");
             }
             else
             {
                 Console.WriteLine("Short Book");
            }*/
            /*  string title = "Refactoring";
              switch (title)
              {
                  case "Clean Code":
                      Console.WriteLine("Great choice!");
                      break;

                  case "Refactoring":
                      Console.WriteLine("Nice pick!");
                      break;

                  default:
                      Console.WriteLine("Never heard of it");
                      break;
              }

              int pages = 464;
              string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";
              Console.WriteLine(sizeLabel);

              string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

              for (int i = 0; i < books.Length; i++)
              {
                  Console.WriteLine($"{i + 1}. {books[i]}");
              }*/
            int result = 1;
            int fact = int.Parse( Console.ReadLine());
            if (fact < 1)
            {

                Console.WriteLine("not found");
            }
            else
            {
                for (int i = 1; i <= fact; i++)
                {
                    result *= i;
                }
                Console.WriteLine(result);

            }
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int i = 0;
            while (i < books.Length)
            {
                Console.WriteLine(books[i]);
                i++;
            }
            int count = 1;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            }
            while (count <= 3);
           // string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
          //  string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(book);
            }
           // string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }






        }
    }
}
