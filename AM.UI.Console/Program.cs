// See https://aka.ms/new-console-template for more information
using AM.Core.Domain;
using System.Text.RegularExpressions;

//partie 2  
Console.WriteLine("partie 2");
Console.WriteLine("Question 7");
/*
Plane plane = new Plane();
plane.PlaneId = 1;
plane.Capacity = 200;
plane.MyPlaneType = PlaneType.Boeing;  
plane.ManufactureDate = new DateTime(2024, 9, 22);
Console.WriteLine(plane.ToString());

*/

Console.WriteLine("Question 9");

Plane plane = new Plane(PlaneType.Airbus, 150, new DateTime(2024, 9, 22));

Console.WriteLine(plane.ToString());


Console.WriteLine("partie 3");

/*
Passenger passenger = new Passenger
{
    FirstName = "Nakhla",
    LastName = "Najib"
};

bool isMatch = passenger.CheckProfile("Najib", "Nakhla");
Console.WriteLine($"Profile match: {isMatch}");

Passenger passenger2 = new Passenger
{
    FirstName = "Najib",
    LastName = "Nakhla",
    EmailAdress = "najib.nakhla@esprit.tn"
};

bool isMatch2 = passenger.CheckProfile("Nakhla", "Najib", "najib.nakhla@esprit.tn");
Console.WriteLine($"Profile match: {isMatch}"); 
    
*/

Passenger passenger = new Passenger
{
    FirstName = "Najib",
    LastName = "Nakhla",
    EmailAdress = "najib.nakhla@esprit.tn",
    BirthDate = new DateTime(2000, 9, 18)

};

Console.WriteLine("question 11 _ c : oui c'est possible");

//email =null
bool isMatchNameOnly = passenger.CheckProfile("Nakhla", "Najib");
Console.WriteLine($"Profile match (name only): {isMatchNameOnly}"); 

//avec email
bool isMatchFull = passenger.CheckProfile("Nakhla", "Najib", "najib.nakhla@esprit.tn");
Console.WriteLine($"Profile match (full): {isMatchFull}");


Console.WriteLine("question 12");

Staff staff = new Staff();
Traveller traveller = new Traveller();

Console.WriteLine(passenger.GetPassengerType()); 
Console.WriteLine(staff.GetPassengerType());     
Console.WriteLine(traveller.GetPassengerType());


Console.WriteLine("Partie 4");
Console.WriteLine("question 13");

//int age = 0;

//passenger.GetAge(passenger.BirthDate, age);

passenger.GetAge(passenger);

Console.WriteLine($"Passenger's Age: {passenger.Age}");


Console.WriteLine("Partie 5");
Console.WriteLine("question 14");




Passenger passenger3 = new Passenger
{
    BirthDate = new DateTime(1999, 5, 12) 
};

passenger3.CalculateAndSetAge();


Console.WriteLine($"Passenger's 3 Age: {passenger3.Age}"); 
    


