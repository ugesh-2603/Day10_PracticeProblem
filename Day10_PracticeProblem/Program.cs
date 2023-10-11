
using static Day10_PracticeProblem.PersonAge;

namespace Day10_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Choose any Program");
            Console.WriteLine("1.PersonAge \n2. InvalidAge");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    AgeCategorization ageCategorization = new AgeCategorization();
                    string category = ageCategorization.CategorizeAge(15);
                    Console.WriteLine("Age is in category: " + category);
                    break;

                case 2:

                    try
                    {
                        Console.Write("Enter age: ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out int age))
                        {
                            string category1 = AgeCategorization1.CategorizeAge1(age);
                            Console.WriteLine($"Age category: {category1}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Age must be a valid integer.");
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    

                    break;








            }
            Console.ReadLine();
        }
    }
}