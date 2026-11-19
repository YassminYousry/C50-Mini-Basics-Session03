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
            string var01 = "Clean Code";
            string var02 = "Clean Code";

            Console.WriteLine($"ReferenceEquals: {ReferenceEquals(var01, var02)}");
            #endregion

        }
    }
}
