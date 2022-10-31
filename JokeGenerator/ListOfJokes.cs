using System;
using System.Collections.Generic;

namespace JokeGeneratorWMarEw
{
    internal class ListOfJokes
    {
        public List<Joke> JokesList { get; set; }
        public List<Joke> randomJoke { get; set; }


        Random random = new();

        public ListOfJokes()
        {
            JokesList = new List<Joke>();
            randomJoke = new List<Joke>();
            {
                JokesList.Add(new Joke("\nWhat did the toaster say to the slice of bread? \"I want you inside me.\"", "Dirty"));
                JokesList.Add(new Joke("\nI'll admit it, I have a tremendous sex drive. My girlfriend lives forty miles away.", "Dirty"));
                JokesList.Add(new Joke("\nWhy did the sperm cross the road? Because I put on the wrong sock this morning.", "Dirty"));
                JokesList.Add(new Joke("\nWhy does a mermaid wear seashells? Because she outgrew her B-shells!", "Dirty"));
                JokesList.Add(new Joke("\nWhy do we tell actors break a leg? Because every play has a cast", "Funny"));
                JokesList.Add(new Joke("\nDebugging: Removing the needles from the haystack.", "Funny"));
                JokesList.Add(new Joke("\nWhat did the snail who was riding on the turtle's back say? Wheeeee!", "Funny"));
                JokesList.Add(new Joke("\nI was going to tell a time traveling joke, but you guys didn't like it.", "Funny"));
            }
        }


        public void PrintDirtyJoke()
        {
            foreach (Joke joke in JokesList)
            {
                if (joke.Genre == "Dirty")
                {
                    randomJoke.Add(joke);
                }
            }
            PrintRandomJoke();
        }

        public void PrintFunnyJoke()
        {
            foreach (Joke joke in JokesList)
            {
                if (joke.Genre == "Funny")
                {
                    randomJoke.Add(joke);
                }
            }
            PrintRandomJoke();
        }

        public void PrintRandomJoke()
        {
            var randomIndex = random.Next(0, randomJoke.Count);
            randomJoke[randomIndex].PrintJoke();
            randomJoke.Clear();
        }
    }
}