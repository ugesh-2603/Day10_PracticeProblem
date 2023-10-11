using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day10_PracticeProblem.PersonAge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_PracticeProblem.PersonAge.Tests
{
    [TestClass()]
    public class AgeCategorizationTests
    {
        [TestMethod()]
        public void CategorizeAgeTest()
        {
            static void Main()
            {
                try
                {
                    // Test cases
                    Console.WriteLine("Age 5 is in category: " +  (5));
                    Console.WriteLine("Age 20 is in category: " + (20));
                    Console.WriteLine("Age 40 is in category: " + (40));
                    Console.WriteLine("Age 70 is in category: " + (70));

                    // Testing invalid age (negative age)
                    Console.WriteLine("Age -5 is in category: " + (-5));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}