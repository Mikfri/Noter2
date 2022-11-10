using Exceptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 1)Using bugg, Husk at tilføj Using <Filnavn>         2)Constructor bugg

//String        < Er en class! 

//FootballPlayer player01 = new FootballPlayer() { Id = 1, Name = "Mikkel", Age = 37, ShirtNumber = 8 }; // bruges i forbindelse med filer og databaser
//FootballPlayer player02 = new FootballPlayer(2, "Henrik", 50, 3); // bruges i forbindelse med alm oprettelse/initialisering

FootballPlayer player01 = new FootballPlayer();
FootballPlayer player02 = new FootballPlayer();


///Try block
///
try
{
    player01 = new FootballPlayer() { Id = 1, Name = "Mikkel", Age = 37, ShirtNumber = 8 };
    player02 = new FootballPlayer(2, "P", 34, 3);
}
///Når man bruger Exceptions skal den mest specialiserede/eller den længst nede i hierakiet:
///Stå i toppen/bruges først af catch metoderne - ellers virker det ikke.
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Ex:1: " + ex.Message);
}
///Catch block
///
catch (ArgumentException ex)
{
    player01 = new FootballPlayer();
    Console.WriteLine("EX:2 " + ex.Message);

}


Console.WriteLine();
//Console.WriteLine(player02.Name.Length);
