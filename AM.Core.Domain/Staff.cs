using System;

namespace AM.Core.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public string Function { get; set; }
        public int Salary { get; set; }

        //methods
        public override string ToString()
        {
            return base.ToString() + $", EmploymentDate: {EmploymentDate.ToShortDateString()}, Function: {Function}, Salary: {Salary}";
        }

        public override string GetPassengerType()
        {
            return "I am a passenger. I am a Staff Member.";
        }

    }
}
