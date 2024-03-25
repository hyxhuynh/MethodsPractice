using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        // Function to capitalize the first charater of a word
        public static string CapitalizeFirstChar(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        // Function to describe an animal
        public static void AnimalDescription()
        {
            // Declaration of variables
            string animalName;
            string animalType;
            string animalHabitat;
            string animalRegion;
            string animalColor;

            // User input
            Console.WriteLine("Name one animal in plural:");
            animalName = Console.ReadLine();

            Console.WriteLine("Name the type of animal, such as birds, dogs, or insects:");
            animalType = Console.ReadLine();

            Console.WriteLine("Name the habitat, such as tropical, subtropical, or rainforest:");
            animalHabitat = Console.ReadLine();

            Console.WriteLine("Name one region where there is the greatest diversity, such as South America, North America, or Australia:");
            animalRegion = Console.ReadLine();

            Console.WriteLine("Name one color of the animal:");
            animalColor = Console.ReadLine();

            // User input in string interpolation
            Console.WriteLine($"\n{CapitalizeFirstChar(animalName)} are {animalType}. They are found in most {animalHabitat} regions. The greatest diversity of {animalName} is found in {CapitalizeFirstChar(animalRegion)}. Many species of {animalName} have {animalColor} color. ");
        }

        // Add function
        public static decimal Add (decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        
        // Subtract function
        public static decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        
        // Multiply function
        public static decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        
        // Divide function
        public static decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        // Modulus function
        public static decimal Mod(decimal num1, decimal num2)
        {
            return num1 % num2;
        }

        // Sum of multiple numbers
        public static int SumArray(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++) 
            {
                sum = sum + list[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            // EXERCISE ONE
            // Description of an animal
            // Example of output:
            // Parrots are birds. They are found in most tropical regions. The greatest diversity of parrots is found in South America. Many species of parrots have green color.
            AnimalDescription();

            // EXERCISE TWO
            // Math operators
            // User input
            Console.WriteLine("\nEnter first number:");
            decimal userNum1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            decimal userNum2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Select a math function (type 1 for sum, 2 to subtraction, 3 for multiplication, 4 for division, or 5 for modulus):");
            int result = int.Parse(Console.ReadLine());

            // User selection
            if (result == 1)
            {
                decimal sum = Add(userNum1, userNum2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{userNum1} + {userNum2} = {sum}");
            }
            else if (result == 2)
            {
                decimal subtraction = Subtract(userNum1, userNum2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{userNum1} - {userNum2} = {subtraction}");
            }
            else if (result == 3)
            {
                decimal multiplication = Multiply(userNum1, userNum2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{userNum1} * {userNum2} = {multiplication}");
            }
            else if (result == 4)
            {
                decimal division = Divide(userNum1, userNum2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{userNum1} / {userNum2} = {division}");
            }
            else if (result == 5)
            {
                decimal modulus = Mod(userNum1, userNum2);
                Console.WriteLine("Answer:");
                Console.WriteLine($"{userNum1} % {userNum2} = {modulus}");
            }
            else
            {
                // if user pick another number other than 1, 2, 3, 4, or 5
                Console.WriteLine("INVALID INPUT");
            }

            // BONUS
            // Sum of an array
            Console.WriteLine("\nEnter 5 integer numbers to calculate the sum");
            Console.WriteLine("First number:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Third number:");
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Fourth number:");
            int fourthNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Fifth number:");
            int fifthNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of the above five integer numbers:");
            Console.WriteLine($"Answer:{SumArray(firstNum, secondNum, thirdNum, fourthNum, fifthNum)}");
        }
    }
}
