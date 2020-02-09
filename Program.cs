using System;
using System.Collections.Generic;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();

            Movie shrek = new Movie("Shrek", "Animated");
            Movie toystory = new Movie("Toy Story", "Animated");
            Movie starWars = new Movie("Star Wars", "Sci-Fi");
            Movie alien = new Movie("Alien", "Sci-fi");
            Movie twoThousandOne = new Movie("2001: A Space Oddessy", "Sci-Fi");
            Movie fridayTheThirteenth = new Movie("Friday the 13th", "Horror");
            Movie scream = new Movie("Scream", "Horror");
            Movie blairWitch = new Movie("The Blair Witch Project", "Horror");
            Movie notebook = new Movie("The Notebook", "Drama");
            Movie romeoAndJuliet = new Movie("Romeo + Juliet", "Drama");

            movies.Add(shrek);
            movies.Add(toystory);
            movies.Add(starWars);
            movies.Add(alien);
            movies.Add(twoThousandOne);
            movies.Add(fridayTheThirteenth);
            movies.Add(scream);
            movies.Add(blairWitch);
            movies.Add(notebook);
            movies.Add(romeoAndJuliet);

            //movies.Sort();
            // I wanted to make the list alphabetical, but an exception is thrown with this method.

            bool stopIt = false;

            Console.WriteLine("Welcome to the movie lister 5000.");
            Console.WriteLine("Press 1 for Animated films, 2, for Sci-Fi, 3 for Horror, or 4 for Drama.");

            do
            {
                var userInput = int.Parse(Console.ReadLine());
                //if a non int entry is put in here, the program will throw an exception. How to fix? Enclose all in another do/while loop?

                if (userInput == 1)
                {
                    foreach (var movie in movies)
                    {
                        if (movie.Category == "Animated")
                        {
                            Console.WriteLine($"{movie.Title}");
                        }
                    }
                    Console.WriteLine("Do you want to continue? (y/n)");
                    string keepgoing = Console.ReadLine();

                    if (keepgoing == "n")
                    {
                        stopIt = true;
                    } else if (keepgoing == "N")   
                    {
                        stopIt = true;
                    }
                    else
                    {
                        Console.WriteLine("Press 1 for Animated films, 2, for Sci-Fi, 3 for Horror, or 4 for Drama.");
                    }
                }
                else if (userInput == 2)
                {
                    foreach (var movie in movies)
                    {
                        if (movie.Category == "Sci-Fi")
                        {
                            Console.WriteLine($"{movie.Title}");
                        }
                    }
                    Console.WriteLine("Do you want to continue? (y/n)");
                    string keepgoing = Console.ReadLine();

                    if (keepgoing == "n")
                    {
                        stopIt = true;
                    }
                    else if (keepgoing == "N")
                    {
                        stopIt = true;
                    }
                    else
                    {
                        Console.WriteLine("Press 1 for Animated films, 2, for Sci-Fi, 3 for Horror, or 4 for Drama.");
                    }
                }
                else if (userInput == 3)
                {
                    foreach (var movie in movies)
                    {
                        if (movie.Category == "Horror")
                        {
                            Console.WriteLine($"{movie.Title}");
                        }
                    }
                    Console.WriteLine("Do you want to continue? (y/n)");
                    string keepgoing = Console.ReadLine();

                    if (keepgoing == "n")
                    {
                        stopIt = true;
                    }
                    else if (keepgoing == "N")
                    {
                        stopIt = true;
                    }
                    else
                    {
                        Console.WriteLine("Press 1 for Animated films, 2, for Sci-Fi, 3 for Horror, or 4 for Drama.");
                    }
                }
                else if (userInput == 4)
                {
                    foreach (var movie in movies)
                    {
                        if (movie.Category == "Drama")
                        {
                            Console.WriteLine($"{movie.Title}");
                        }
                    }
                    Console.WriteLine("Do you want to continue? (y/n)");
                    string keepgoing = Console.ReadLine();

                    if (keepgoing == "n")
                    {
                        stopIt = true;
                    }
                    else if (keepgoing == "N")

                    {
                        stopIt = true;
                    }
                    else
                    {
                        Console.WriteLine("Press 1 for Animated films, 2, for Sci-Fi, 3 for Horror, or 4 for Drama.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please select 1 for Animated films, 2, for Sci-Fi, 3 for Horror, or 4 for Drama.");
                }

            } while (!stopIt);

        }
    }
}
