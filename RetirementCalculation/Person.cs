using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RetirementCalculation
{
    /// <summary>
    /// The delegate defining a method that has two input integer parameters and returns a double value
    /// </summary>
    
    public delegate double PensionCalculation(int a, int b);

    /// <summary>
    /// The definition of Person class
    /// </summary>
   
    public class Person
    {
        private string _name;
        private int _age;
        private int _seniority;
        
        /// <summary>
        /// Public Get method for private name property
        /// </summary>
        public string Name
        {
            get => _name;
        }
        /// <summary>
        /// Public Get method for private age property
        /// </summary>
        public int Age
        {
            get => _age;
        }
        /// <summary>
        /// Public Get method for private seniority property
        /// </summary>
        public int Seniority
        {
            get => _seniority;
        }
        /// <summary>
        /// Constructor for creating a new Person object
        /// </summary>
        /// <param name="name"> </param> 
        /// <param name="age"> </param> 
        /// <param name="seniority"> </param> 
        public Person(string name, int age, int seniority)
        {
            _name = name;
            _age = age;
            _seniority = seniority;
           
        }
        /// <summary>
        /// Method accepts delegate as an input parameter for pension calculation 
        /// Also accepts Person's age and seniority for calculation
        /// </summary>
        /// <param name="ag"> </param> 
        /// <param name="srt"> </param> 
        /// <param name="calculation"> </param> 

        public double GetRetiremetnValue(int ag, int srt, PensionCalculation calculation)
        {
            return (calculation(ag,srt));
        }
    }
}
