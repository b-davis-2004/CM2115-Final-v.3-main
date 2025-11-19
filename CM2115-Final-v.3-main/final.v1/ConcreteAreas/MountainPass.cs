using final.v1.ConcretePuzzles;

namespace final.v1
{
    public class MountainPass : AreaBase
    {
        public override string Name => "Mountain Pass";
        public override string Description => "This is the treacherous mountain pass, with steep cliffs and howling winds.";

        public MountainPass()
        {
            Conflict = new PuzzleConflict(new Puzzle1());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
}