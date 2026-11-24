namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            double[] Prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(Prices[1]);
            #endregion
            #region Q2
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Q3
            PrintWelcomeMessage();
            #endregion
            #region Q4
            PrintBookTitle("Clean Code");
            #endregion
            #region Q5
            int pages = 400;
            AddBonusPages(400);
            Console.WriteLine(pages);
            // pages is passed by value, so the original value of pages remains unchanged after calling AddBonusPages.
            #endregion
            #region Q6
            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]);
            //The Price array is passed by reference, so the original value of prices[0] is modified after calling ApplyDiscount.
            #endregion
            #region Q7
            AddBonusPagesByRef(ref pages);
            Console.WriteLine(pages);
            //The pages variable is passed by reference using the ref keyword, so the original value of pages is modified after calling AddBonusPagesByRef.
            #endregion
            #region Q8
            ReplaceArray(ref prices);
            Console.WriteLine(prices.Length);
            #endregion
            #region Q9

           Console.WriteLine( TryGetPrice("Clean Code", out double price));
           Console.WriteLine(price);
            #endregion
            #region Q10
            PrintBookInfo("Clean Code");
            PrintBookInfo("Clean Code", 500);
            #endregion
            #region Q11
            PrintBookInfo(pages: 900, title: "Clean Code");
            #endregion
            #region Q12
            PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Design Patterns");
            #endregion


        }
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book Title:"+title);
        }
        static void AddBonusPages(int pages) {
            pages += 50;
        }
       static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        static void AddBonusPagesByRef(ref int pages) {
            pages += 50;
        }
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0.0;
                return false;
            }
        }
        static void PrintBookInfo(string title, int pages = 300) {
         Console.WriteLine($"Book Title: {title}, Pages: {pages}");
        }
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }

    }
}
