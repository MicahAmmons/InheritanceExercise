using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - done 
            // give this class 4 members that all Animals have in common -done


            // Create a class Bird - done 
            // give this class 4 members that are specific to Bird - done
            // Set this class to inherit from your Animal Class - done 

            // Create a class Reptile - done 
            // give this class 4 members that are specific to Reptile - done 
            // Set this class to inherit from your Animal Class - done 




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird peregrineFalcon = new Bird() { CanFly = true, ColorOfFeathers = "Blue, Grey, and Black", NumberOfToes = 4, SizeOfBird = "Small"};
            Console.WriteLine($" MY favorite bird of prey is the Peregrine Falcon.  It's {peregrineFalcon.CanFly} that they can fly, even though they are {peregrineFalcon.SizeOfBird}.  They have {peregrineFalcon.NumberOfToes} talons, and their feaths are {peregrineFalcon.ColorOfFeathers}.");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile anole = new Reptile() {BreathesAir = true, IsItCreepy = false, IsItPetWorth = true, PrimaryDiet = "Small insects, like crickets."};
            Console.WriteLine($"The coolest reptile that I know is the Anole.  Thinking that they are creepy is {anole.IsItCreepy} - in fact, it's very {anole.IsItPetWorth} that they can be cute pets.  Their primary diet consists of {anole.PrimaryDiet} and you won't need any water since it's {anole.BreathesAir} that they breathe air.");
        }
    }
}
