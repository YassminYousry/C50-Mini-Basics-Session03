using System.Text;

namespace Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //string title = "clean code";
            //string upperTitle = title.ToUpper();

            //Console.WriteLine($"Original: {title}");
            //Console.WriteLine($"Uppercase: {upperTitle}");
            #endregion

            #region Q02
            //string var01 = "Clean Code";
            //string var02 = "Clean Code";

            //Console.WriteLine($"ReferenceEquals: {ReferenceEquals(var01, var02)}");
            #endregion

            #region Q03
            //StringBuilder sbText = new StringBuilder();

            //sbText.Append("Book List");
            //sbText.Append(" - Updated");

            //Console.WriteLine($"{sbText}");
            #endregion

            #region Q04
            //sbText.Replace("Book List", "Library");

            //Console.WriteLine($"{sbText}");
            #endregion

            #region Q05
            //string title = "Clean Code";
            //int pages = 464;

            //string sentence = "Book: " + title + ", Pages: " + pages;

            //Console.WriteLine($"{sentence}");
            #endregion

            #region Q06
            //string title = "Clean Code";
            //int pages = 464;

            //string sentence = $"Book: {title}, Pages: {pages}";

            //Console.WriteLine($"{sentence}");
            #endregion

            #region Q07
            //string title = "Clean Code";
            //int pages = 464;

            //string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);

            //Console.WriteLine($"{sentence}");
            #endregion

            #region Q08
            //int pages = 464;

            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion

            #region Q09
            //int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot borrow this book");
            //}
            #endregion

            #region Q10
            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Q11
            int pages = 464;

            string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";

            Console.WriteLine($"{sizeLabel}");
            #endregion

        }
    }
}
