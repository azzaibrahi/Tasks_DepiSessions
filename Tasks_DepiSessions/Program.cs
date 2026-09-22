namespace Tasks_DepiSessions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   1
             Console.WriteLine("Enter the number ");
            int number = int.Parse(Console.ReadLine());
             Console.WriteLine($"The number is: {number}");
            //   2 int,TRYParse return False (0) and return "Conversion Failed"
             string input = "azza345";
             bool Result= int.TryParse(input, out int SafReslt) ;
             Console.WriteLine(Result ? SafReslt.ToString() : "Conversion Failed");

            //   3    will print 0.020000001 because of floating point precision issues
            float a = 0.1F;
            float b = 0.2F;
            Console.WriteLine(a * b);

            // 4
            string text = "Hello DEPI Students";
            string sub = text.Substring(6, 4); 
            Console.WriteLine(sub); // DEPI

            // 5    int is a value type int Stack, so when we assign it to another variable, a copy of the value is made. Therefore, changing the value of y does not affect x.
            int x = 10;
            int y = x;      //copy
            x = 50;

            Console.WriteLine(x); // 50
            Console.WriteLine(y); // 10

            // 6
           int[] numbers = { 1, 2, 3, 4, 5 };
            int[] copyNumbers = numbers; // Reference type, so both variables point to the same array in memory
            copyNumbers[0] = 10;
            Console.WriteLine(numbers[0]); // 10
            Console.WriteLine(copyNumbers[0]); // 10
            // 7
            string fname = "azza";
            string Lname = "Ibrahim";
            string fullName = fname + " " + Lname ;
            Console.WriteLine(fullName); // azza Ibrahim

            //  8      number (b)
            int d;
            d = Convert.ToInt32(!(30 < 20));  // 1 --> (!(False))= True = 1

            //  9     number (d)
            Console.WriteLine(13 / 2 + " " + 13 % 2); // 6  1

            //  10    number (d)  
            int num = 1, z = 5;

            //    (!(false)) -----> true 
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z); //2+ 5   1+6 -----> 7  7
            else
                Console.WriteLine(--num + z-- + " " + --z);




        }
    }
}
