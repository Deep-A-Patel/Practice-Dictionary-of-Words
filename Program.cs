using System;
using System.Collections.Generic;


namespace Dictionary_of_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>(){
                {"Love", "an intense feeling of deep affection."},
                {"Hate", "feel intense or passionate dislike for (someone)"},
                {"Like", "having the same characteristics or qualities as; similar to"},
                {"Friend", "a person whom one knows and with whom one has a bond of mutual affection, typically exclusive of sexual or family relations."}
            };


            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "extremely impressive or daunting; inspiring great admiration, apprehension, or fear.");
            wordsAndDefinitions.Add("Cool", "of or at a fairly low temperature.");
            wordsAndDefinitions.Add("Super", "very good or pleasant; excellent.");


            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine($"The definition of Cool is {wordsAndDefinitions["Cool"]}");
            Console.WriteLine($"The definition of Love is {wordsAndDefinitions["Love"]}");

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                The definition of (WORD) is (DEFINITION)
                The definition of (WORD) is (DEFINITION)
                The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }
    }
}




