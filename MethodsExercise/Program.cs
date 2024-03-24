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
        static void Main(string[] args)
        {
            // Declaration of variables
            string nameOfAnimal;
            string typeOfAnimal;
            string habitat;
            string region;
            string color;

            // User Input
            Console.WriteLine("Name one animal in plural:");
            nameOfAnimal = Console.ReadLine();

            Console.WriteLine("Name the type of animal, such as birds, dogs, or insects:");
            typeOfAnimal = Console.ReadLine();
            
            Console.WriteLine("Name the habitat, such as tropical, subtropical, or rainforest:");
            habitat = Console.ReadLine();
            
            Console.WriteLine("Name one region where there is the greatest diversity, such as South America, North America, or Australia:");
            region = Console.ReadLine();

            Console.WriteLine("Name one color of the animal:");
            color = Console.ReadLine();

            // User input in string interpolation
            Console.WriteLine($"\n{CapitalizeFirstChar(nameOfAnimal)} are {typeOfAnimal}. They are found in most {habitat} regions. The greatest diversity of {nameOfAnimal} is found in {CapitalizeFirstChar(region)}. Many species of {nameOfAnimal} has {color} color. ");


        }
    }
}
