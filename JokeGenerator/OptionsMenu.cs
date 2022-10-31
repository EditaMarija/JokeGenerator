using System;

namespace JokeGeneratorWMarEw
{
    public class OptionsMenu
    {
        private ListOfJokes jokes = new();
        private PrintingMethods print = new();
        public bool isRunning = true;

        public void ExecuteOptions()
        {
            while (isRunning)
            {
                print.Menu();
                var input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.Clear();
                    jokes.PrintDirtyJoke();
                }

                if (input == 2)
                {
                    Console.Clear();
                    jokes.PrintFunnyJoke();
                }

                if (input == 3) isRunning = false;
            }

        }

        //public void ExecuteOptions()
        //{
        //    int Option = 0;
        //    do
        //    {
        //        print.Menu();
        //        try
        //        {
        //            Option = int.Parse(Console.ReadLine());
        //        }
        //        catch { break; }
        //        if (Option == 1)
        //        {   
        //            Console.Clear(); 
        //            jokes.PrintDirtyJoke(); 
        //        }
        //        if (Option == 2) 
        //        { 
        //            Console.Clear();
        //            jokes.PrintFunnyJoke(); 
        //        }
        //        if (Option == 3) { Environment.Exit(0); }
        //    }
        //    while (Option != 4);
            
        //}
    }
}