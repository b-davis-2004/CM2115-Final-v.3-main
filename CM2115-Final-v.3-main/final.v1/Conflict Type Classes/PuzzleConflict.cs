namespace final.v1;

public class PuzzleConflict : IConflict
{
    public string Description => $"You are face with a {Puzzle.Name}!";
    public bool IsResolved { get; private set; }
    public IPuzzle Puzzle { get; private set; }

    public PuzzleConflict(IPuzzle puzzle)
    {
        Puzzle = puzzle;
        IsResolved = false;
    }

    public void Resolve(Player player)
    {
        Console.WriteLine(Description);
        while (!Puzzle.IsResolved)
        {
            Console.WriteLine("Solve the puzzle to proceed!");
            // Implement puzzle solving logic here
            // For example, you could prompt the player for input
            // and check if the input solves the puzzle

            // Placeholder logic for solving the puzzle
            Console.WriteLine("Enter your solution:");
            var input = Console.ReadLine();
            if (input == "correct_solution") // Replace with actual solution check
            {
                Puzzle.IsResolved = true;
                Console.WriteLine("You have solved the puzzle!");
                IsResolved = true;
            }
            else
            {
                Console.WriteLine("Incorrect solution. Try again.");
            }
        }
    }
}

// conflict type class for puzzle conflicts
// will need to add the conflict logic that inplments concrete puzzle classes
// to be used by concrete area classes
// very similar logic to CombatConflict class