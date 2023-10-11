using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day10_PracticeProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Day10_PracticeProblem.PersonAge;

namespace Day10_PracticeProblem.Tests
{
    [TestClass()]
    public class AgeCategorization1Tests
    {

        [TestMethod()]
        static void TestAgeCategorization(string input)
        {
            Console.WriteLine($"Testing age categorization for input: {input}");
            try
            {
                if (int.TryParse(input, out int age))
                {
                    string category = AgeCategorization1.CategorizeAge1(age);
                    Console.WriteLine($"Age category: {category}");
                }
                else
                {
                    throw new ArgumentException("Invalid input. Age must be a valid integer.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            Console.WriteLine();
        }
    }
}
