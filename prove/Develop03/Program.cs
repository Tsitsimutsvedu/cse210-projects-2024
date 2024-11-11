    class Program
    {
        static void Main(string[] args)
        {
            var reference = new Reference("John", 3, 16);
            var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                var input = Console.ReadLine();

                if (input?.ToLower() == "quit")
                    break;

                if (!scripture.AllWordsHidden())
                {
                    scripture.HideRandomWords(5); 
                }
                else
                {
                    Console.WriteLine("\nAll words are hidden. Well done!");
                    break;
                }
            }
        }
    }

