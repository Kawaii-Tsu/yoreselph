using System;

namespace yoreselph
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            
            Console.WriteLine("Type up 2 numbers");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Select a class...\n1.-Add\n2.-Subtract\n3.-Multiply\n4.-Division");
            int option = int.Parse (Console.ReadLine ());

            EvaluateOption(option, num1, num2);  
        }

        public static float AddTwoNumbers(float n1, float n2)
        {
            float result = n1 + n2;

            return result;
        }

		public static float SubtractTwoNumbers(float n1, float n2)
		{
			float result = n1 - n2;

			return result;
		}

		public static float MultiplyTwoNumbers(float n1, float n2)
		{
			float result = n1 * n2;

			return result;
		}

		public static float DivideTwoNumbers(float n1, float n2)
		{
			float result = n1 / n2;

			return result;
		}

        public static void EvaluateOption(int option, float n1, float n2)
        {
            if (option == 1)
            {
                Console.WriteLine("Result of the addition: " + AddTwoNumbers(n1, n2));
            }
            else if (option == 2)
            {
                Console.WriteLine("Result of the subtraction: " + SubtractTwoNumbers(n1, n2));
            }
            else if (option == 3)
            {
                Console.WriteLine("Result of the multiplication: " + MultiplyTwoNumbers(n1, n2));
            }
            else if (option == 4)
            {
                Console.WriteLine("Result of the division: " + DivideTwoNumbers(n1, n2));
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }

            Start
        }
    }
}