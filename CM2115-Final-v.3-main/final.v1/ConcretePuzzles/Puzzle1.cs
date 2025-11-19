namespace final.v1.ConcretePuzzles
{
    public class Puzzle1 : IPuzzle
    {
        public string Name => "Ancient Riddle";
        public string Description => "Solve the ancient riddle to proceed.";

        // Interface REQUIRES a public setter
        public bool IsResolved { get; set; } = false;

        // Interface requires: bool Resolve(Player player)
        public bool Resolve(Player player)
        {
            Console.Write("Enter your answer: ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "time")
            {
                IsResolved = true;
                Console.WriteLine("Correct! You have solved the puzzle.");
                return true;
            }

            Console.WriteLine("Incorrect answer. Try again.");
            return false;
        }

        // Optional helper method you had before
        public void AttemptSolve(string answer)
        {
            if (answer.ToLower() == "time")
            {
                IsResolved = true;
                Console.WriteLine("Correct! You have solved the puzzle.");
            }
            else
            {
                Console.WriteLine("Incorrect answer. Try again.");
            }
        }
    }
}


// Concrete puzzle class implementing IPuzzle interface
// Represents a specific puzzle with its own properties and solving logic
// Includes properties for Name, Description, and IsResolved status