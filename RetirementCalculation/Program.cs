using System.Globalization;

namespace RetirementCalculation
{
    internal class Program
    {
                static void Main(string[] args)
        {
          /// <summary>
         /// Creation a new object of Person type
         /// </summary>

            Person person = new Person("DaMarcus Beasley", 65, 40);

            /// <summary>
            /// Calling different pension calculation methods for different countries 
            /// </summary>

           double result = person.GetRetiremetnValue(person.Age,person.Seniority, PensionCalculationUkraine);

           Console.WriteLine($"The pension sum for {person.Name} equals {result:F2}");

            result = person.GetRetiremetnValue(person.Age, person.Seniority, PensionCalculationCanada);

            Console.WriteLine($"The pension sum for {person.Name} equals {result:F2}");

            result = person.GetRetiremetnValue(person.Age, person.Seniority, PensionCalculationGermany);

            Console.WriteLine($"The pension sum for {person.Name} equals {result:F2}");

            /// <summary>
            /// Defining method for calculating pension in Ukraine 
            /// </summary>
            /// <param name="age"> </param> 
            /// <param name="seniority"> </param> 

            static double PensionCalculationUkraine (int age, int seniority)
            
            {
                return 7500 + 15000.01 * seniority/age; 
            }
            /// <summary>
            /// Defining method for calculating pension in Canada 
            /// </summary>
            /// <param name="age"> </param> 
            /// <param name="seniority"> </param> 

            static double PensionCalculationCanada(int age, int seniority)

            {
                return 10000 + 20000.01 * seniority/age;
            }
            /// <summary>
            /// Defining method for calculating pension in Germany 
            /// </summary>
            /// <param name="age"> </param> 
            /// <param name="seniority"> </param> 

            static double PensionCalculationGermany(int age, int seniority)

            {
                return 7500 + 15000 * (age - seniority)/1.33;
            }

        }
    }
}



