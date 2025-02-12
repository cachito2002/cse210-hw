using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("Moroni", 10, 5),
                "And by the power of the Holy Ghost ye may know the truth of all things."
            ),
            new Scripture(
                new Reference("1 Nephi", 3, 7),
                "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
            ),
            new Scripture(
                new Reference("1 Nephi", 4, 6),
                "And I was led by the Spirit, not knowing beforehand the things which I should do."
            )


        };

        Random random = new Random();
        bool keepPlaying = true;

        while (keepPlaying)
        {
            // Get a random scripture
            Scripture scripture = scriptures[random.Next(scriptures.Count)];
            
            string input = "";
            while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
                Console.WriteLine("Type 'next' for a different scripture:");
                input = Console.ReadLine();

                if (input.ToLower() == "next")
                {
                    break;
                }
                else if (input.ToLower() != "quit")
                {
                    scripture.HideRandomWords(3);
                }
            }

            if (input.ToLower() == "quit")
            {
                keepPlaying = false;
            }
        }
    }
}