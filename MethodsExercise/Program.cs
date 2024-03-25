using System.Drawing;
using System.Globalization;
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

            // User Input
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
            Console.WriteLine($"\n{CapitalizeFirstChar(animalName)} are {animalType}. They are found in most {animalHabitat} regions. The greatest diversity of {animalName} is found in {CapitalizeFirstChar(animalRegion)}. Many species of {animalName} has {animalColor} color. ");
        }
        static void Main(string[] args)
        {
            // Execute a function
            // Example of output:
            // Parrots are birds. They are found in most tropical regions. The greatest diversity of parrots is found in South America. Many species of parrots has green color.
            AnimalDescription();
        }
    }
}
