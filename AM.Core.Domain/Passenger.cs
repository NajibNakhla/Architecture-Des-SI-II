using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public DateTime BirthDate { get; set; }
        public string TelNumber { get; set; }
        public IList<Flight> Flights { get; set; }

        public int Age { get; private set; }

        //methods
        public override string ToString()
        {
            return $"PassportNumber: {PassportNumber}, FirstName: {FirstName}, LastName: {LastName}, " +
                   $"EmailAdress: {EmailAdress}, BirthDate: {BirthDate.ToShortDateString()}, TelNumber: {TelNumber}";
        }
         /*
        public bool CheckProfile(string lastName, string firstName)
        {
            return this.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase) &&
                   this.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase);
        }
        public bool CheckProfile(string lastName, string firstName, string email)
        {
            return this.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase) &&
                   this.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                   this.EmailAdress.Equals(email, StringComparison.OrdinalIgnoreCase);
        }
         */


        // on peut remplacer les 2 checkProfile methodes avec une seule 
        public bool CheckProfile(string lastName, string firstName, string email = null)
        {
            bool isNameMatch = this.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase) &&
                               this.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase);

            if (email == null)
            {
                return isNameMatch; 
            }

            return isNameMatch && this.EmailAdress.Equals(email, StringComparison.OrdinalIgnoreCase);
        }


        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }



        public void GetAge(DateTime birthDate,ref int calculatedAge)
        {
            calculatedAge = DateTime.Now.Year - birthDate.Year;


            if (DateTime.Now < birthDate.AddYears(calculatedAge))
            {
                calculatedAge--;
            }


            
            Console.WriteLine($"Calculated age (within method): {calculatedAge}");
        }



        public void GetAge(Passenger aPassenger)
        {
            
            int calculatedAge = 0; 
            GetAge(aPassenger.BirthDate,ref calculatedAge); 

            
            Age = DateTime.Now.Year - aPassenger.BirthDate.Year;
            if (DateTime.Now < aPassenger.BirthDate.AddYears(Age))
            {
                Age--;
            }

            Console.WriteLine($"Calculated age: {Age}");
        }

        public void CalculateAndSetAge()
        {
            int calculatedAge = 0;
            GetAge(BirthDate, ref calculatedAge);
            Age = calculatedAge; 
            Console.WriteLine($"Calculated age: {Age}");
        }
    }
}
