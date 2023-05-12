namespace MethodsExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Story();

            Console.WriteLine("add");
            Console.WriteLine(sum(1,1));
            Console.WriteLine("subtract");
            Console.WriteLine(subtract(2, 2));
            Console.WriteLine("multiply");
            Console.WriteLine(multiply(3, 3));
            Console.WriteLine("divide");
            Console.WriteLine(divide(2, 1));
            Console.WriteLine("modulus");
            Console.WriteLine(modulus(4, 4));


          
        }
        public static void Story()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite Color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Who is your favorite music artist?");
            string musicArtist = Console.ReadLine();

            Console.WriteLine($"His name is {userName} and his favorite color is {color} The animal that is his favorite is a {animal}.{userName} wishes his best friend was a {color} {animal} " +
                $"so they could hangout and listen to {musicArtist} together.");


            
           



        }
        public static int sum(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;

        }
        public static int subtract(int num1, int num2)
        {
            int subtract = num1 - num2;

            return subtract;
        }
        public static int multiply(int num1, int num2)
        {
            int multiply = num1 * num2;

            return multiply;
        }
        public static int divide(int num1, int num2)
        {
            int divide = num1 / num2;

            return divide;
        }
        public static int modulus(int num1, int num2)
        {
            int modulus = num1 % num2;

                return modulus;
        }



            



    }
}
