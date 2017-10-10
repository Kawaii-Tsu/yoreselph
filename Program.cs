using System;

namespace yoreselph
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type up 2 numbers");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine(AddTwoNumbers(num1, num2)); 
        }

        public static float AddTwoNumbers(float n1, float n2)
        {
            float result = n1 + n2;

            return result;
        }
    }
}
