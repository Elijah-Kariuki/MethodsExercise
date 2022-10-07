using System;
namespace MethodsExercise
{
    internal class Program
    {
        public static string AdlibStory()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your dog's name?");
            string userDogName = Console.ReadLine();

            Console.WriteLine("What breed is your dog?");
            string dogBreed = Console.ReadLine();

            return ($"There was a man named {userName}, he was {age} years old. \n{userName} had a dog named {userDogName} that was a {dogBreed} that he loved very much.");

        }

        public static int Sum1(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];

            }
            return sum;
        }

    
        public static void Sum(int num1, int num2)
        {
           int answerIs = num1 + num2;
            Console.WriteLine($"The sum of {num1} plus {num2} is {answerIs}");
        }

        public static void Subtraction(int num1, int num2)
        {
            int answerIs = num1 - num2;
            Console.WriteLine($"The total of {num1} minus {num2} is {answerIs}");
        }

        public static void Multiplication(int num1, int num2)
        {
            int answerIs = num1 * num2;
            Console.WriteLine($"The total of {num1} multiplied by {num2} is {answerIs}");
        }

        public static void Division(int num1, int num2)
        {
            int answerIs = num1 / num2;
            Console.WriteLine($"The division of {num1} by {num2} is {answerIs}");
        }
        public static void Remainder(int num1, int num2)
        {
            int answerIs = num1 % num2;
            Console.WriteLine($"The remainder of {num1} divided by {num2} is {answerIs}");
        }

        public static void Main(string[] args)
        {

            //Console.WriteLine(AdlibStory());



            Console.WriteLine("Provide the first number to calculate");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Provide the second number to calculate");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Sum(num1, num2);
            Subtraction(num1, num2);
            Multiplication(num1, num2);
            Division(num1, num2);
            Remainder(num1, num2);
                                  
        }

    }   
}