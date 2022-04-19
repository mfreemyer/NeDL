using System;

namespace Collection
{

    class Program
    {

        static void Main(string[] args)
        {
            // Declare and instantiate the array of Pokemon objects
            Pokemon[] pokemonArray=new Pokemon[25];

            // Now, loop through each array element and instantiate a Pokemon object for each.
            // Note that the constructor with no parameters will be used.

            for (int index = 0; index < pokemonArray.Length; index++)
            {
                pokemonArray[index] = new Pokemon();
            }

            // Load in some test data to test both ways to assign values
            pokemonArray[1].SetName("Charizard");
            // *** can't have these working until i can make my get and set work in Pokemon.cs
            pokemonArray[1].PType = ("Fire-Flying");
            pokemonArray[1].PWeight = 199.5;
            pokemonArray[2].SetName("Mew");
            pokemonArray[2].PType = ("Psychic");
            pokemonArray[2].PWeight = 8.8;
            pokemonArray[4].SetName("Cherrim");
            pokemonArray[4].PType = ("Grass");
            pokemonArray[4].PWeight = 20.5;

            //print each pokemon to test the property gets and the toString
            for (int index = 0; index < pokemonArray.Length; index++)
            {
                if(!(((pokemonArray[index]).GetName())==null))
                    Console.WriteLine(pokemonArray[index]);
            }




        } // Ends Main
    } // Ends Class
} //  Ends Namespace