using System;

namespace RandomNrGenerator_1._0._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNr = new Random();                                                                                         //Generate and save random number
            int RandomNr = randomNr.Next(1, 101);


            Console.WriteLine("I chose a number between 1 and 100. Can you guess it?");                                             //Output instructions
            Console.WriteLine("Before you do that though, how many guesses do you think you will need?");                           //Output instructions (guesses)

            string guessesGuess = Console.ReadLine();
            int GuessesGuess = Convert.ToInt32(guessesGuess);

            Console.WriteLine("Okay now choose a number.");

            string guess1 = Console.ReadLine();                                                                                     //Read Input
            int Guess1 = Convert.ToInt32(guess1);                                                                                   //Convert Input from string to int


            int guesses = 0;                                                                                                        //Set guesses to '0'



            if (Guess1 == RandomNr)                                                                                                 //If correct do:
            {
                guesses++;                                                                                                          //Add last guess to guesses
                Console.WriteLine("Good job!! You got it first try.");                                                              //Output correct confirmation
                Console.WriteLine("guesses needed: " + guesses);                                                                    //Output guesses amount
            }
            else if (Guess1 > RandomNr)                                                                                             //If Guess1 larger 
            {
                Console.WriteLine("SIKE! Thats the wrong number. Your number is too big. Try again.");
                guesses++;
            }

            else if (Guess1 < RandomNr)                                                                                             //If Guess1 smaller
            {
                Console.WriteLine("SIKE! Thats the wrong number. Your number is too small. Try again.");
                guesses++;
            }





            do
            {
                string guess = Console.ReadLine();
                int Guess = Convert.ToInt32(guess);

                if (Guess > RandomNr)                                                                                               //Evaluate Input if >
                {
                    Console.WriteLine("SIKE! Thats the wrong number. Your number is too big. Try again.");                          //Output > confirmation

                    guesses++;                                                                                                      //Guesses +1
                }

                if (Guess < RandomNr)                                                                                          //Evaluate if <
                {
                    Console.WriteLine("SIKE! Thats the wrong number. Your number is too small. Try again.");                        //Output < confirmation

                    guesses++;                                                                                                      //Guesses +1
                }

                if (Guess == RandomNr)                                                                                         //If correct do:
                {
                    guesses++;                                                                                                      //Add last guess to guesses
                    Console.WriteLine("                                     Good job you got it.");                                                                      //Output correct confirmation
                    Console.WriteLine("                                     guesses needed: " + guesses);                                                                //Output guesses amount


                    if (Guess == RandomNr)
                    {

                        if (guesses < GuessesGuess)
                        {
                            Console.Write("                                     You underestimated yourself.");
                        }

                        if (guesses > GuessesGuess)
                        {
                            Console.Write("                                     You overestimated yourself");
                        }

                        if (guesses == GuessesGuess)
                        {
                            Console.Write("                                     You guessed the amount of needed guesses correctly.");
                        }

                    }

                }
            }
            while (Guess1 != RandomNr);


        }
    }
}
