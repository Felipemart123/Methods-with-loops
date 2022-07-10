
class program

{
    static void Main(string[] args)
    {
        //PrintThousand();
        //PrintThousandByThree();
        //AreEqual(10, 10);
        //OddOrEven(4);
        //PositiveOrNegative(-1);
        //CanVote(21);

    }

    public static void PrintThousand()
    {
        for (int i = 1000; i >= -1000; i--)
        {
            //Console.WriteLine(i);
        }
    }


    public static void PrintThousandByThree()

    {
        for (int i = 1; i <= 1000; i = i +3)
        {
            //Console.WriteLine(i);
        }
    }

    public static void AreEqual(int num1, int num2)
    {
        if (num1 == num2)
        {
            //Console.WriteLine($"{num1} and {num2} are equal");

        }
        else
        {
            //Console.WriteLine("they are not equal");
        }
    }

    public static void OddOrEven(int num)
    {
        if (num % 2 == 0)
        {
           // Console.WriteLine("Number is even");
        }
        else
        {
            //Console.WriteLine("Number is odd");
       }
    }

    public static void PositiveOrNegative(int num)
    {
        if (num > 0)
        {
             //Console.WriteLine("Number is positive");
        }
        else
        {
            //Console.WriteLine("Number is negative");
        }
    }

    public static void CanVote(int num)
    {
        if (num >= 21)
        {
            //Console.WriteLine("YOU can vote");
        }
        else
        {
            //Console.WriteLine("YOU cannot vote");
        }
    }


}






















