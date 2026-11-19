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
            int pages = 464;

            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

        }
    }
}
